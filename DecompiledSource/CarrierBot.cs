using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AAD RID: 2733
[Serializable]
public class CarrierBot : MonoBehaviour
{
	// Token: 0x06003C4F RID: 15439 RVA: 0x007CF0A8 File Offset: 0x007CD2A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CarrierBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x007CF0B8 File Offset: 0x007CD2B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (13745 - 256344 != -242598)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (95323 - 334117 == -238794)
			{
				this.mChar.actionState = "standby";
				if (14757 - 529378 != -514620)
				{
					this.mChar.actionTime = Time.time;
					if (256656 - 245101 != 11556)
					{
						this.mChar.myCommand = "none";
						if (5482 - 459922 != -454439)
						{
							this.mChar.hp = (this.mChar.mhp = 11500);
							if (195197 - 485090 != -289892)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x007CF1DC File Offset: 0x007CD3DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (163188 - 66601 != 96588)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (45027 - 388871 == -343843)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (216374 - 592898 != -376524)
				{
					continue;
				}
			}
			this.mChar.addTimeOut("transport", (float)30);
		}
		while (12296 - 410611 == -398314);
	}

	// Token: 0x06003C52 RID: 15442 RVA: 0x007CF290 File Offset: 0x007CD490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (62777 - 566052 != -503275)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (264296 - 160578 == 103719)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (143569 - 510721 != -367152)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_357;
					}
					if (759 - 234096 != -233337)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (181370 - 425896 != -244526)
				{
					continue;
				}
			}
			IL_357:
			if (this.mChar.hp <= 0)
			{
				if (45596 - 362996 != -317400)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (214219 - 504717 != -290498)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (218603 - 234665 == -16061)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (44263 - 473918 == -429654)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (210454 - 442740 == -232285)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (161098 - 320555 != -159457)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (169347 - 516900 != -347552)
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
			if (180200 - 63866 != 116335)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (48828 - 364191 == -315363)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (262231 - 380907 != -118675)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (4124 - 580167 != -576042)
						{
							if (this.mChar.isMine)
							{
								if (163810 - 410348 != -246537)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (280241 - 80287 != 199955)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (72286 - 478783 != -406496)
										{
											this.mChar.KoEvent();
											if (183647 - 509469 == -325822)
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
								if (194103 - 323916 != -129812)
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

	// Token: 0x06003C53 RID: 15443 RVA: 0x007CF688 File Offset: 0x007CD888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (298407 - 554155 != -255748)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (294331 - 85306 == 209025)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (149672 - 476230 != -326557)
				{
					if (153107 - 135007 == 18100)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (114221 - 501498 == -387276)
							{
								continue;
							}
							v = 1;
							if (161046 - 96459 == 64588)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (287370 - 50050 == 237321)
							{
								continue;
							}
							v = -1;
							if (55204 - 45963 == 9242)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_laser")
						{
							if (266142 - 38380 != 227762)
							{
								continue;
							}
							v = 11;
							if (81129 - 290402 != -209273)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_laser_fire")
						{
							if (150480 - 66963 == 83518)
							{
								continue;
							}
							v = 12;
							if (233815 - 3784 == 230032)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_missle")
						{
							if (176165 - 295772 != -119607)
							{
								continue;
							}
							v = 21;
							if (220657 - 423845 != -203188)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_missle_fire")
						{
							if (251222 - 112699 == 138524)
							{
								continue;
							}
							v = 22;
							if (159902 - 219579 == -59676)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_missle_hit")
						{
							if (272160 - 587771 != -315611)
							{
								continue;
							}
							v = -22;
							if (232543 - 518435 != -285892)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_transport")
						{
							if (84336 - 597848 == -513511)
							{
								continue;
							}
							v = 31;
							if (238199 - 114542 != 123657)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (74154 - 547274 == -473119)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (89504 - 171426 != -81921)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (228300 - 325312 == -97012)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (131190 - 99264 == 31926)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (191210 - 214892 == -23682)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (282630 - 16837 == 265793)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (111804 - 457261 != -345456)
											{
												Hashtable hashtable = new Hashtable();
												if (114333 - 299979 == -185646)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (189766 - 159165 != 30602)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (233571 - 74528 == 159043)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (42757 - 226227 != -183469)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (211690 - 274504 != -62813)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (159158 - 40672 != 118487)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (110358 - 217291 == -106933)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (249432 - 551485 == -302053)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (59034 - 106984 != -47949)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (200833 - 364662 == -163829)
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

	// Token: 0x06003C54 RID: 15444 RVA: 0x007CFCD0 File Offset: 0x007CDED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (190168 - 540225 != -350057)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (150317 - 48761 != 101557)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (126929 - 464241 != -337311)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (217450 - 199651 == 17799)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (111354 - 337843 != -226488)
						{
							int num3 = num;
							if (134996 - 4094 == 130902)
							{
								if (num3 == 1)
								{
									if (69107 - 513835 == -444728)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (147627 - 306014 != -158386)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (94588 - 531444 == -436856)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (261889 - 127793 == 134096)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (223069 - 425624 != -202554)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (269468 - 320505 == -51037)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (248595 - 382558 == -133963)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (127020 - 403976 == -276956)
										{
											this.StartCoroutine_Auto(this.RPC_laser(vector, vector2, num2));
											if (282902 - 442051 == -159149)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (283522 - 169949 == 113573)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (255157 - 403567 != -148409)
										{
											this.RPC_laser_fire(vector, vector2, num2);
											if (247216 - 550669 == -303453)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (119958 - 66759 == 53199)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (64256 - 438951 != -374694)
										{
											this.StartCoroutine_Auto(this.RPC_missle(vector, vector2, num2));
											if (239668 - 219075 != 20594)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (62313 - 511349 == -449036)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (243952 - 300815 != -56862)
										{
											this.RPC_missle_fire(vector, vector2, num2);
											if (153107 - 112799 != 40309)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -22)
								{
									if (94194 - 535859 != -441664)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (64506 - 260193 == -195687)
										{
											this.RPC_missle_hit(vector, vector2, num2);
											if (207347 - 515335 == -307988)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (285940 - 135672 == 150268)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (205389 - 220706 == -15317)
										{
											this.StartCoroutine_Auto(this.RPC_transport(vector, vector2, num2));
											if (176631 - 93327 != 83305)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (260620 - 311200 != -50579)
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

	// Token: 0x06003C55 RID: 15445 RVA: 0x007D0238 File Offset: 0x007CE438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (220899 - 287850 != -66951)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (88464 - 580033 != -491568)
			{
				float runSpeed = this.mChar.runSpeed;
				if (237849 - 252700 != -14850)
				{
					Vector3 a = default(Vector3);
					if (235096 - 438346 != -203249)
					{
						Vector3 vector = Vector3.zero;
						if (171568 - 431218 != -259649)
						{
							float num2 = (float)0;
							if (107378 - 577057 != -469678)
							{
								if (this.mChar.isMine)
								{
									if (269066 - 422763 != -153697)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (86668 - 299258 != -212590)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (9501 - 543896 != -534395)
										{
											continue;
										}
										a.y = (float)0;
										if (240720 - 57769 != 182951)
										{
											continue;
										}
										a = a.normalized;
										if (82459 - 515242 == -432782)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (95056 - 590900 != -495844)
										{
											continue;
										}
										vector = vector.normalized;
										if (114087 - 511643 != -397556)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (228747 - 275868 != -47121)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (225670 - 352124 != -126454)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (108535 - 36281 == 72255)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (190427 - 38639 == 151789)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (148410 - 91142 != 57268)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (138007 - 105899 != 32108)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (292878 - 407723 == -114844)
														{
															continue;
														}
														this.animation.Play("run");
														if (164967 - 47400 != 117567)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (66706 - 359758 != -293051)
														{
															goto IL_426;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (169793 - 470340 == -300546)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (181034 - 47323 != 133711)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (279043 - 396508 != -117465)
											{
												continue;
											}
											num = (float)0;
											if (287381 - 572497 == -285115)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (253401 - 563492 == -310090)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (284973 - 468757 == -183783)
										{
											continue;
										}
									}
									IL_426:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (153037 - 65663 == 87375)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (187764 - 374434 != -186670)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (136121 - 60077 != 76044)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (76564 - 274210 != -197646)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (187840 - 183245 == 4596)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (6687 - 577711 != -571024)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (70502 - 374373 != -303871)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (191903 - 492897 != -300994)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (273931 - 160358 != 113573)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (191127 - 156853 != 34274)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (230371 - 383787 == -153415)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (111232 - 114008 != -2776)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (109956 - 213382 == -103425)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (91326 - 421800 == -330473)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (161296 - 414185 != -252889)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (59293 - 391057 != -331764)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (17526 - 588533 != -571007)
												{
													continue;
												}
												num = (float)0;
												if (298853 - 204091 != 94762)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (297046 - 97213 == 199834)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (147143 - 206038 != -58895)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (252980 - 500725 != -247745)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (265226 - 115966 != 149260)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (265147 - 366133 != -100986)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (143752 - 326259 == -182506)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (39781 - 8425 != 31356)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (173010 - 91121 == 81890)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (153518 - 16801 != 136717)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (32338 - 366343 == -334004)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (174200 - 175587 != -1387)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (232802 - 241860 != -9058)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (191935 - 92531 == 99405)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (144844 - 374082 != -229238)
											{
												continue;
											}
											num = (float)0;
											if (262926 - 199388 == 63539)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (203252 - 386622 == -183369)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (73478 - 63978 == 9501)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (91935 - 555446 == -463510)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (288080 - 89750 != 198330)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (55919 - 289944 != -234024)
								{
									this.mChar.moveSpeed = num;
									if (273545 - 282000 != -8454)
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

	// Token: 0x06003C56 RID: 15446 RVA: 0x007D0D9C File Offset: 0x007CEF9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (156893 - 324011 != -167117)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (183555 - 51716 == 131839)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (239959 - 152552 != 87408)
				{
					Vector3 vector = a - this.transform.position;
					if (244629 - 9170 == 235459)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (101655 - 315422 == -213767)
						{
							CharacterControl characterControl = null;
							if (36015 - 445848 == -409833)
							{
								if (231624 - 14286 == 217338)
								{
									if (gameObject)
									{
										if (191180 - 221324 == -30143)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (150606 - 144089 != 6517)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (220397 - 57783 == 162615)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (227512 - 551566 != -324054)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (205989 - 177063 != 28926)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (46762 - 416680 == -369917)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (141203 - 238439 == -97236)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (2172 - 325658 == -323486)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (213818 - 230786 != -16967)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (100338 - 169914 != -69575)
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

	// Token: 0x06003C57 RID: 15447 RVA: 0x007D1094 File Offset: 0x007CF294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (277909 - 338487 != -60578)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (106856 - 314009 == -207153)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (129666 - 182422 != -52755)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (24320 - 201527 != -177206)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (199121 - 439834 == -240713)
						{
							CharacterControl characterControl = null;
							if (122536 - 352998 != -230461)
							{
								int tID = 0;
								if (277130 - 1818 != 275313)
								{
									if (gameObject)
									{
										if (89401 - 151944 == -62542)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (8540 - 13277 == -4736)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (46297 - 256524 != -210227)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (70591 - 48985 == 21607)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (96231 - 318959 != -222728)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (133356 - 494162 != -360806)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (120986 - 280348 == -159362)
									{
										if (UnityEngine.Random.Range(0, 100) > 40)
										{
											if (21244 - 313177 != -291932)
											{
												this.StartCoroutine_Auto(this.RPC_laser(this.transform.position, vector, tID));
												if (47784 - 141113 != -93328)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (43304 - 138785 != -95480)
													{
														this.ActionEvent("RPC_laser", this.transform.position, vector, tID);
														if (140536 - 571073 == -430537)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_missle(this.transform.position, vector, tID));
											if (80932 - 198898 != -117965)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (98471 - 339197 == -240726)
												{
													this.ActionEvent("RPC_missle", this.transform.position, vector, tID);
													if (122767 - 16898 != 105870)
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

	// Token: 0x06003C58 RID: 15448 RVA: 0x007D1450 File Offset: 0x007CF650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x007D1454 File Offset: 0x007CF654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CarrierBot.$RPC_nAttack$30481(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003C5A RID: 15450 RVA: 0x007D1464 File Offset: 0x007CF664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (29423 - 197459 != -168035)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (50489 - 560525 != -510035)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (182353 - 68905 != 113449)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (262956 - 391818 == -128862)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003C5B RID: 15451 RVA: 0x007D1524 File Offset: 0x007CF724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_laser(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CarrierBot.$RPC_laser$30493(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003C5C RID: 15452 RVA: 0x007D1534 File Offset: 0x007CF734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_laser_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (6333 - 523057 != -516723)
		{
		}
		for (;;)
		{
			if (this.laser_fire)
			{
				if (264219 - 510444 != -246224)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (22909 - 186054 != -163144)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.laser_fire, firePos, rotation);
						if (259691 - 402029 == -142338)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (18496 - 2364 == 16132)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (159636 - 457738 == -298102)
								{
									projectileControl.life = (float)1 * this.mChar.rangeMod;
									if (122527 - 95284 == 27243)
									{
										CarrierBot_laser carrierBot_laser = (CarrierBot_laser)gameObject.GetComponent(typeof(CarrierBot_laser));
										if (158763 - 362436 == -203673)
										{
											carrierBot_laser.Init(this.gameObject);
											if (211020 - 529315 == -318295)
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
				Debug.Log("Cannot find Laser Effect");
				if (279247 - 476294 != -197046)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003C5D RID: 15453 RVA: 0x007D16EC File Offset: 0x007CF8EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_missle(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CarrierBot.$RPC_missle$30507(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x007D16FC File Offset: 0x007CF8FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_missle_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (58013 - 10913 != 47101)
		{
		}
		for (;;)
		{
			if (this.missle_fire)
			{
				if (77066 - 283047 != -205980)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.missle_fire, firePos, this.transform.rotation);
					if (48155 - 269263 != -221107)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (111421 - 476211 != -364789)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (56598 - 481216 == -424618)
							{
								CarrierBot_missile carrierBot_missile = (CarrierBot_missile)gameObject.GetComponent(typeof(CarrierBot_missile));
								if (167426 - 524804 != -357377)
								{
									if (!carrierBot_missile)
									{
										break;
									}
									if (279996 - 354479 == -74483)
									{
										carrierBot_missile.Init(firePos + fireDir);
										if (116830 - 593192 != -476361)
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
			else
			{
				Debug.LogError("Missing missle_fire effect");
				if (209456 - 222066 == -12610)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003C5F RID: 15455 RVA: 0x007D1898 File Offset: 0x007CFA98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_missle_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (70195 - 231495 != -161299)
		{
		}
		for (;;)
		{
			IL_AD:
			if (this.missle_hit)
			{
				if (53917 - 91917 != -38000)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.missle_hit, hitPos, this.transform.rotation);
				if (168273 - 423872 == -255598)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing missle_hit effect");
				if (269305 - 498998 == -229692)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (129689 - 596301 == -466612)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (38432 - 51567 != -13134)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)4, (float)4, layerMask);
					if (108123 - 83906 == 24217)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (287992 - 426637 != -138644)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj4;
								if (146750 - 337205 != -190455)
								{
									goto IL_AD;
								}
								this.mChar.hit(1, gameObject, this.mChar.talAdjust(60), 3, 0, Vector3.zero);
								if (164133 - 75896 == 88238)
								{
									goto IL_AD;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (269965 - 55856 == 214110)
								{
									goto IL_AD;
								}
							}
							if (144906 - 253098 != -108191)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x007D1ABC File Offset: 0x007CFCBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_transport(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CarrierBot.$RPC_transport$30522(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003C61 RID: 15457 RVA: 0x007D1ACC File Offset: 0x007CFCCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (90478 - 155886 != -65407)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (101467 - 418390 != -316922)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (69164 - 457641 == -388477)
				{
					hashtable.Add(43, PlayerData.UID);
					if (238901 - 507407 != -268505)
					{
						hashtable.Add(73, nType);
						if (114781 - 182780 != -67998)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (169147 - 229903 != -60755)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (266577 - 463900 == -197323)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (230552 - 567533 != -336980)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (61538 - 52327 != 9212)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (120057 - 170580 == -50523)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (92090 - 447522 == -355432)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (40698 - 451574 == -410876)
													{
														PhotonClient.Connection.OpCustom(63, hashtable, true);
														if (99525 - 381890 == -282365)
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

	// Token: 0x06003C62 RID: 15458 RVA: 0x007D1DAC File Offset: 0x007CFFAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CarrierBot.$RPC_ko$30531(nArray, this).GetEnumerator();
	}

	// Token: 0x06003C63 RID: 15459 RVA: 0x007D1DBC File Offset: 0x007CFFBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CarrierBot.$RPC_dead$30538(nArray, this).GetEnumerator();
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x007D1DCC File Offset: 0x007CFFCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003C65 RID: 15461 RVA: 0x007D1DD0 File Offset: 0x007CFFD0
	internal static bool ft45RB5CTe3oKmnwkEiS()
	{
		return true;
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x007D1DD4 File Offset: 0x007CFFD4
	internal static bool wYr4Dq5C3Htqk9a6VtWL()
	{
		return false;
	}

	// Token: 0x040049D5 RID: 18901
	public CharacterControl mChar;

	// Token: 0x040049D6 RID: 18902
	public AudioClip nAttackFx;

	// Token: 0x040049D7 RID: 18903
	public GameObject nAttack_hit;

	// Token: 0x040049D8 RID: 18904
	public AudioClip laserFx;

	// Token: 0x040049D9 RID: 18905
	public GameObject laser_fire;

	// Token: 0x040049DA RID: 18906
	public GameObject missle_fire;

	// Token: 0x040049DB RID: 18907
	public GameObject missle_hit;

	// Token: 0x040049DC RID: 18908
	private int XNgu63rLjC;

	// Token: 0x040049DD RID: 18909
	public GameObject deadEffect;

	// Token: 0x02000AAE RID: 2734
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30481 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C67 RID: 15463 RVA: 0x007D1DD8 File Offset: 0x007CFFD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30481(Vector3 mPos, Vector3 tDir, CarrierBot self_)
		{
			if (247275 - 4580 != 242695)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (252830 - 51379 == 201451)
				{
					base..ctor();
					if (270201 - 478531 == -208330)
					{
						this.$mPos$30490 = mPos;
						if (77720 - 127015 == -49295)
						{
							this.$tDir$30491 = tDir;
							if (164976 - 216727 == -51751)
							{
								this.$self_$30492 = self_;
								if (150698 - 116861 == 33837)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x007D1EB4 File Offset: 0x007D00B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarrierBot.$RPC_nAttack$30481.$(this.$mPos$30490, this.$tDir$30491, this.$self_$30492);
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x007D1ED0 File Offset: 0x007D00D0
		internal static bool axpp4k5CXheUR0U0i8Le()
		{
			return true;
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x007D1ED4 File Offset: 0x007D00D4
		internal static bool aIuyad5CQc1qMFHxXn5Y()
		{
			return false;
		}

		// Token: 0x040049DE RID: 18910
		internal Vector3 $mPos$30490;

		// Token: 0x040049DF RID: 18911
		internal Vector3 $tDir$30491;

		// Token: 0x040049E0 RID: 18912
		internal CarrierBot $self_$30492;

		// Token: 0x02000AAF RID: 2735
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C6B RID: 15467 RVA: 0x007D1ED8 File Offset: 0x007D00D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CarrierBot self_)
			{
				if (24433 - 230368 != -205934)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57271 - 545789 != -488517)
					{
						base..ctor();
						if (207470 - 282655 == -75185)
						{
							this.$mPos$30487 = mPos;
							if (274448 - 37464 != 236985)
							{
								this.$tDir$30488 = tDir;
								if (224647 - 463563 == -238916)
								{
									this.$self_$30489 = self_;
									if (50121 - 31627 != 18495)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003C6C RID: 15468 RVA: 0x007D1FB4 File Offset: 0x007D01B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284260 - 196552 != 87709)
				{
				}
				for (;;)
				{
					IL_3B7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8AB;
					case 2:
						if (this.$self_$30489.mChar.actionState != "attack")
						{
							goto IL_85;
						}
						if (199869 - 317457 != -117588)
						{
							continue;
						}
						if (this.$self_$30489.mChar.myCommand != "nAttack")
						{
							if (282531 - 98505 != 184026)
							{
								continue;
							}
							goto IL_85;
						}
						else if (this.$self_$30489.nAttackFx)
						{
							if (177659 - 509672 == -332012)
							{
								continue;
							}
							this.$self_$30489.audio.PlayOneShot(this.$self_$30489.nAttackFx);
							if (47640 - 254312 != -206672)
							{
								continue;
							}
							goto IL_4D3;
						}
						else
						{
							Debug.LogError("Missing nAttackFx");
							if (3884 - 40492 != -36607)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30489.mChar.actionState != "attack")
						{
							goto IL_4FC;
						}
						if (221959 - 137442 == 84518)
						{
							continue;
						}
						if (this.$self_$30489.mChar.myCommand != "nAttack")
						{
							if (42456 - 389312 != -346855)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30489.mChar.isMine)
							{
								goto IL_6E6;
							}
							if (61915 - 463981 != -402066)
							{
								continue;
							}
							this.$hitLayer$30482 = 130816 - (1 << this.$self_$30489.gameObject.layer);
							if (42439 - 444639 != -402200)
							{
								continue;
							}
							this.$hitList$30483 = Damage.FindRecTarget(this.$self_$30489.transform.position, this.$self_$30489.transform.forward, (float)3, (float)3, (float)4, (float)3, this.$hitLayer$30482);
							if (46328 - 423149 != -376821)
							{
								continue;
							}
							this.$$iterator$10622$30486 = UnityRuntimeServices.GetEnumerator(this.$hitList$30483);
							if (237481 - 395519 != -158038)
							{
								continue;
							}
							while (this.$$iterator$10622$30486.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10622$30486.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30484 = (GameObject)obj2;
								if (143620 - 311928 == -168307)
								{
									goto IL_3B7;
								}
								if (this.$self_$30489.mChar.hit(1, this.$hitObject$30484, this.$self_$30489.mChar.atk, 1, 0, this.$self_$30489.transform.forward) != 0)
								{
									if (71321 - 125061 == -53739)
									{
										goto IL_3B7;
									}
									this.$hitPos$30485 = this.$hitObject$30484.collider.ClosestPointOnBounds(this.$self_$30489.transform.position + (float)2 * Vector3.up);
									if (241471 - 37827 == 203645)
									{
										goto IL_3B7;
									}
									UnityRuntimeServices.Update(this.$$iterator$10622$30486, this.$hitObject$30484);
									if (32893 - 384212 != -351319)
									{
										goto IL_3B7;
									}
									this.$self_$30489.RPC_nAttack_hit(this.$hitPos$30485, this.$self_$30489.transform.forward, 0);
									if (267236 - 274252 != -7016)
									{
										goto IL_3B7;
									}
									this.$self_$30489.ActionEvent("RPC_nAttack_hit", this.$hitPos$30485, this.$self_$30489.transform.forward, 0);
									if (263596 - 189601 != 73995)
									{
										goto IL_3B7;
									}
								}
							}
							if (165179 - 39625 != 125555)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30489.mChar.actionState == "attack")
						{
							if (273608 - 590420 == -316811)
							{
								continue;
							}
							if (this.$self_$30489.mChar.myCommand == "nAttack")
							{
								if (121845 - 211312 != -89467)
								{
									continue;
								}
								this.$self_$30489.mChar.actionState = "standby";
								if (197102 - 7453 != 189649)
								{
									continue;
								}
								this.$self_$30489.mChar.actionTime = Time.time;
								if (5467 - 76059 == -70591)
								{
									continue;
								}
								this.$self_$30489.mChar.myCommand = "none";
								if (23087 - 159521 == -136433)
								{
									continue;
								}
								if (!this.$self_$30489.mChar.isMine)
								{
									if (169986 - 70808 != 99178)
									{
										continue;
									}
									this.$self_$30489.mChar.nPosition = this.$self_$30489.transform.position;
									if (38580 - 450191 != -411611)
									{
										continue;
									}
									this.$self_$30489.mChar.oPosition = this.$self_$30489.transform.position;
									if (295577 - 443163 == -147585)
									{
										continue;
									}
									this.$self_$30489.mChar.nDirection = this.$self_$30489.transform.forward;
									if (43497 - 52488 != -8991)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (49174 - 590790 != -541615)
						{
							goto Block_25;
						}
						continue;
					default:
						if (215077 - 470998 == -255920)
						{
							continue;
						}
						break;
					}
					this.$self_$30489.mChar.actionState = "attack";
					if (293567 - 36089 != 257479)
					{
						this.$self_$30489.mChar.actionTime = Time.time;
						if (151593 - 253451 != -101857)
						{
							this.$self_$30489.mChar.myCommand = "nAttack";
							if (159331 - 540058 != -380726)
							{
								this.$self_$30489.mChar.addTimeOut("nAttack", (float)4);
								if (198490 - 362891 == -164401)
								{
									this.$self_$30489.transform.position = this.$mPos$30487;
									if (13007 - 400472 != -387464)
									{
										this.$self_$30489.transform.LookAt(this.$mPos$30487 + global::Math.vFlat(this.$tDir$30488));
										if (45915 - 542179 == -496264)
										{
											this.$self_$30489.animation.CrossFade("nAttack");
											if (295491 - 396222 == -100731)
											{
												this.$self_$30489.animation.wrapMode = WrapMode.Once;
												if (51492 - 559974 == -508482)
												{
													this.$self_$30489.mChar.vMovement = this.$self_$30489.transform.forward;
													if (64502 - 357752 != -293249)
													{
														this.$self_$30489.mChar.moveSpeed = (float)0;
														if (127185 - 31711 != 95475)
														{
															goto Block_32;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_85:
				goto IL_8AB;
				Block_13:
				goto IL_6E6;
				Block_25:
				goto IL_8AB;
				IL_4D3:
				Block_28:
				goto IL_85C;
				IL_4FC:
				goto IL_8AB;
				Block_32:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_6E6:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_45:
				goto IL_4FC;
				IL_85C:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_8AB:
				return false;
			}

			// Token: 0x06003C6D RID: 15469 RVA: 0x007D2880 File Offset: 0x007D0A80
			internal static bool zrYIQg5Ckwn1L6XLJZNi()
			{
				return true;
			}

			// Token: 0x06003C6E RID: 15470 RVA: 0x007D2884 File Offset: 0x007D0A84
			internal static bool jOIuv55CGmsJB2g867aO()
			{
				return false;
			}

			// Token: 0x040049E1 RID: 18913
			internal int $hitLayer$30482;

			// Token: 0x040049E2 RID: 18914
			internal UnityScript.Lang.Array $hitList$30483;

			// Token: 0x040049E3 RID: 18915
			internal GameObject $hitObject$30484;

			// Token: 0x040049E4 RID: 18916
			internal Vector3 $hitPos$30485;

			// Token: 0x040049E5 RID: 18917
			internal IEnumerator $$iterator$10622$30486;

			// Token: 0x040049E6 RID: 18918
			internal Vector3 $mPos$30487;

			// Token: 0x040049E7 RID: 18919
			internal Vector3 $tDir$30488;

			// Token: 0x040049E8 RID: 18920
			internal CarrierBot $self_$30489;
		}
	}

	// Token: 0x02000AB0 RID: 2736
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_laser$30493 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C6F RID: 15471 RVA: 0x007D2888 File Offset: 0x007D0A88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_laser$30493(Vector3 mPos, Vector3 tDir, int tID, CarrierBot self_)
		{
			if (290839 - 121412 != 169427)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276112 - 239017 == 37095)
				{
					base..ctor();
					if (201039 - 404579 != -203539)
					{
						this.$mPos$30503 = mPos;
						if (210310 - 279947 != -69636)
						{
							this.$tDir$30504 = tDir;
							if (236493 - 482344 != -245850)
							{
								this.$tID$30505 = tID;
								if (184549 - 84185 != 100365)
								{
									this.$self_$30506 = self_;
									if (91993 - 37377 == 54616)
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

		// Token: 0x06003C70 RID: 15472 RVA: 0x007D2988 File Offset: 0x007D0B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarrierBot.$RPC_laser$30493.$(this.$mPos$30503, this.$tDir$30504, this.$tID$30505, this.$self_$30506);
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x007D29A8 File Offset: 0x007D0BA8
		internal static bool v3RGCn5CHDfbr2M8VW7o()
		{
			return true;
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x007D29AC File Offset: 0x007D0BAC
		internal static bool LiMqeR5CWDN2IXZRNaNg()
		{
			return false;
		}

		// Token: 0x040049E9 RID: 18921
		internal Vector3 $mPos$30503;

		// Token: 0x040049EA RID: 18922
		internal Vector3 $tDir$30504;

		// Token: 0x040049EB RID: 18923
		internal int $tID$30505;

		// Token: 0x040049EC RID: 18924
		internal CarrierBot $self_$30506;

		// Token: 0x02000AB1 RID: 2737
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C73 RID: 15475 RVA: 0x007D29B0 File Offset: 0x007D0BB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CarrierBot self_)
			{
				if (292763 - 43343 != 249420)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161199 - 544010 != -382810)
					{
						base..ctor();
						if (139561 - 327492 != -187930)
						{
							this.$mPos$30499 = mPos;
							if (39484 - 550602 == -511118)
							{
								this.$tDir$30500 = tDir;
								if (117923 - 469567 == -351644)
								{
									this.$tID$30501 = tID;
									if (271185 - 309674 != -38488)
									{
										this.$self_$30502 = self_;
										if (256390 - 277815 == -21425)
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

			// Token: 0x06003C74 RID: 15476 RVA: 0x007D2AB0 File Offset: 0x007D0CB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (299999 - 86387 != 213613)
				{
				}
				for (;;)
				{
					IL_733:
					switch (this._state)
					{
					case 0:
						goto IL_869;
					case 1:
						goto IL_95D;
					case 2:
						if (this.$self_$30502.mChar.actionState != "attack")
						{
							goto IL_61C;
						}
						if (97561 - 430402 != -332841)
						{
							continue;
						}
						if (this.$self_$30502.mChar.myCommand != "laser")
						{
							if (185542 - 471097 != -285554)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							if (this.$self_$30502.laserFx)
							{
								if (15540 - 113267 == -97726)
								{
									continue;
								}
								this.$self_$30502.audio.PlayOneShot(this.$self_$30502.laserFx);
								if (182659 - 303846 != -121187)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing laserFx");
								if (285668 - 369110 == -83441)
								{
									continue;
								}
							}
							this.$t$30494 = 0;
							if (118789 - 445737 == -326947)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30502.mChar.actionState != "attack")
						{
							goto IL_898;
						}
						if (299715 - 448958 == -149242)
						{
							continue;
						}
						if (this.$self_$30502.mChar.myCommand != "laser")
						{
							if (187894 - 190056 != -2162)
							{
								continue;
							}
							goto IL_898;
						}
						else
						{
							this.$t$30494++;
							if (211498 - 387620 != -176122)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$30502.mChar.actionState == "attack")
						{
							if (90041 - 548876 != -458835)
							{
								continue;
							}
							if (this.$self_$30502.mChar.myCommand == "laser")
							{
								if (136175 - 354825 == -218649)
								{
									continue;
								}
								this.$self_$30502.mChar.actionState = "standby";
								if (135226 - 359393 == -224166)
								{
									continue;
								}
								this.$self_$30502.mChar.actionTime = Time.time;
								if (153244 - 497631 == -344386)
								{
									continue;
								}
								this.$self_$30502.mChar.myCommand = "none";
								if (29307 - 444386 != -415079)
								{
									continue;
								}
								if (!this.$self_$30502.mChar.isMine)
								{
									if (246699 - 509884 != -263185)
									{
										continue;
									}
									this.$self_$30502.mChar.nPosition = this.$self_$30502.transform.position;
									if (169236 - 225332 != -56096)
									{
										continue;
									}
									this.$self_$30502.mChar.oPosition = this.$self_$30502.transform.position;
									if (200090 - 249821 != -49731)
									{
										continue;
									}
									this.$self_$30502.mChar.nDirection = this.$self_$30502.transform.forward;
									if (280722 - 428143 == -147420)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (144657 - 568931 != -424273)
						{
							goto Block_46;
						}
						continue;
					default:
						if (225928 - 454251 != -228323)
						{
							continue;
						}
						goto IL_869;
					}
					if (this.$t$30494 >= 3)
					{
						if (50763 - 174005 != -123241)
						{
							goto Block_30;
						}
						continue;
					}
					else
					{
						if (!this.$self_$30502.mChar.isMine)
						{
							goto IL_81A;
						}
						if (158347 - 28377 != 129970)
						{
							continue;
						}
						this.$tObject$30495 = null;
						if (69870 - 152172 != -82302)
						{
							continue;
						}
						if (this.$tID$30501 != 0)
						{
							if (741 - 451312 != -450571)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30501];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$30495 = (GameObject)obj2;
							if (295683 - 556938 != -261255)
							{
								continue;
							}
						}
						if (this.$tObject$30495)
						{
							if (91256 - 126632 == -35375)
							{
								continue;
							}
							this.$tDir$30500 = this.$tObject$30495.collider.bounds.center - this.$self_$30502.transform.position;
							if (239898 - 287866 != -47968)
							{
								continue;
							}
						}
						this.$i$30496 = 0;
						if (168803 - 547172 == -378368)
						{
							continue;
						}
						while (this.$i$30496 < 5)
						{
							this.$firePos$30497 = this.$self_$30502.transform.position + this.$self_$30502.transform.TransformDirection((float)0, 4.7f, (float)4);
							if (228884 - 35895 == 192990)
							{
								goto IL_733;
							}
							this.$fireDir$30498 = global::Math.rotateH(this.$tDir$30500 - this.$self_$30502.transform.TransformDirection((float)0, 4.7f, (float)4), (float)(this.$i$30496 * 20 - 40)).normalized;
							if (60454 - 276374 == -215919)
							{
								goto IL_733;
							}
							this.$self_$30502.RPC_laser_fire(this.$firePos$30497, this.$fireDir$30498, 0);
							if (88668 - 479297 != -390629)
							{
								goto IL_733;
							}
							if (PhotonClient.IsInitialized())
							{
								if (176286 - 342274 != -165988)
								{
									goto IL_733;
								}
								this.$self_$30502.ActionEvent("RPC_laser_fire", this.$firePos$30497, this.$fireDir$30498, 0);
								if (119953 - 306908 == -186954)
								{
									goto IL_733;
								}
							}
							this.$i$30496++;
							if (145933 - 589812 == -443878)
							{
								goto IL_733;
							}
						}
						if (207267 - 564777 != -357510)
						{
							continue;
						}
						goto IL_81A;
					}
					IL_869:
					this.$self_$30502.mChar.actionState = "attack";
					if (153397 - 50000 != 103398)
					{
						this.$self_$30502.mChar.actionTime = Time.time;
						if (155410 - 129280 != 26131)
						{
							this.$self_$30502.mChar.myCommand = "laser";
							if (27515 - 291753 == -264238)
							{
								this.$self_$30502.mChar.addTimeOut("cAttack", (float)5);
								if (201462 - 251162 != -49699)
								{
									this.$self_$30502.transform.position = this.$mPos$30499;
									if (160529 - 264564 == -104035)
									{
										this.$self_$30502.transform.LookAt(this.$mPos$30499 + global::Math.vFlat(this.$tDir$30500));
										if (93588 - 89863 != 3726)
										{
											this.$self_$30502.animation.CrossFade("laser");
											if (119754 - 485987 != -366232)
											{
												this.$self_$30502.animation.wrapMode = WrapMode.Once;
												if (157592 - 239833 != -82240)
												{
													this.$self_$30502.mChar.vMovement = this.$self_$30502.transform.forward;
													if (87441 - 57879 != 29563)
													{
														this.$self_$30502.mChar.moveSpeed = (float)0;
														if (258137 - 284053 == -25916)
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
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_11:
				goto IL_61C;
				Block_30:
				return this.Yield(4, new WaitForSeconds(0.05f));
				IL_61C:
				Block_46:
				goto IL_95D;
				IL_81A:
				return this.Yield(3, new WaitForSeconds(0.15f));
				IL_898:
				IL_95D:
				return false;
			}

			// Token: 0x06003C75 RID: 15477 RVA: 0x007D342C File Offset: 0x007D162C
			internal static bool dpCKNB5CAAlBAJjZ0m12()
			{
				return true;
			}

			// Token: 0x06003C76 RID: 15478 RVA: 0x007D3430 File Offset: 0x007D1630
			internal static bool LqfTel5Cl4YgEf7CdWUd()
			{
				return false;
			}

			// Token: 0x040049ED RID: 18925
			internal int $t$30494;

			// Token: 0x040049EE RID: 18926
			internal GameObject $tObject$30495;

			// Token: 0x040049EF RID: 18927
			internal int $i$30496;

			// Token: 0x040049F0 RID: 18928
			internal Vector3 $firePos$30497;

			// Token: 0x040049F1 RID: 18929
			internal Vector3 $fireDir$30498;

			// Token: 0x040049F2 RID: 18930
			internal Vector3 $mPos$30499;

			// Token: 0x040049F3 RID: 18931
			internal Vector3 $tDir$30500;

			// Token: 0x040049F4 RID: 18932
			internal int $tID$30501;

			// Token: 0x040049F5 RID: 18933
			internal CarrierBot $self_$30502;
		}
	}

	// Token: 0x02000AB2 RID: 2738
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_missle$30507 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C77 RID: 15479 RVA: 0x007D3434 File Offset: 0x007D1634
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_missle$30507(Vector3 mPos, Vector3 tDir, int tID, CarrierBot self_)
		{
			if (138244 - 76393 != 61851)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137485 - 450975 != -313489)
				{
					base..ctor();
					if (74768 - 512244 != -437475)
					{
						this.$mPos$30518 = mPos;
						if (180305 - 479551 != -299245)
						{
							this.$tDir$30519 = tDir;
							if (84998 - 120111 != -35112)
							{
								this.$tID$30520 = tID;
								if (198067 - 378954 != -180886)
								{
									this.$self_$30521 = self_;
									if (195216 - 104864 != 90353)
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

		// Token: 0x06003C78 RID: 15480 RVA: 0x007D3534 File Offset: 0x007D1734
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarrierBot.$RPC_missle$30507.$(this.$mPos$30518, this.$tDir$30519, this.$tID$30520, this.$self_$30521);
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x007D3554 File Offset: 0x007D1754
		internal static bool LS0ius5CyOrFLaS7Xm1x()
		{
			return true;
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x007D3558 File Offset: 0x007D1758
		internal static bool Ta1jkW5CSVMxrQkkEcKT()
		{
			return false;
		}

		// Token: 0x040049F6 RID: 18934
		internal Vector3 $mPos$30518;

		// Token: 0x040049F7 RID: 18935
		internal Vector3 $tDir$30519;

		// Token: 0x040049F8 RID: 18936
		internal int $tID$30520;

		// Token: 0x040049F9 RID: 18937
		internal CarrierBot $self_$30521;

		// Token: 0x02000AB3 RID: 2739
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C7B RID: 15483 RVA: 0x007D355C File Offset: 0x007D175C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CarrierBot self_)
			{
				if (31334 - 76005 != -44671)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (82382 - 424747 == -342365)
					{
						base..ctor();
						if (74660 - 68740 == 5920)
						{
							this.$mPos$30514 = mPos;
							if (218536 - 94973 != 123564)
							{
								this.$tDir$30515 = tDir;
								if (39731 - 159420 == -119689)
								{
									this.$tID$30516 = tID;
									if (113089 - 290747 != -177657)
									{
										this.$self_$30517 = self_;
										if (166856 - 545308 != -378451)
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

			// Token: 0x06003C7C RID: 15484 RVA: 0x007D365C File Offset: 0x007D185C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271838 - 340954 != -69115)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_958;
					case 2:
						if (this.$self_$30517.mChar.actionState != "attack")
						{
							goto IL_301;
						}
						if (41734 - 309623 != -267889)
						{
							continue;
						}
						if (this.$self_$30517.mChar.myCommand != "missle")
						{
							if (54362 - 537397 != -483035)
							{
								continue;
							}
							goto IL_301;
						}
						else
						{
							this.$i$30508 = 0;
							if (174682 - 393312 != -218630)
							{
								continue;
							}
							goto IL_4B5;
						}
						break;
					case 3:
						if (this.$self_$30517.mChar.actionState != "attack")
						{
							goto IL_79E;
						}
						if (86928 - 465256 != -378328)
						{
							continue;
						}
						if (this.$self_$30517.mChar.myCommand != "missle")
						{
							if (114803 - 160381 != -45578)
							{
								continue;
							}
							goto IL_79E;
						}
						else
						{
							this.$i$30508++;
							if (13781 - 494707 != -480926)
							{
								continue;
							}
							goto IL_4B5;
						}
						break;
					case 4:
						if (this.$self_$30517.mChar.actionState == "attack")
						{
							if (188272 - 93744 == 94529)
							{
								continue;
							}
							if (this.$self_$30517.mChar.myCommand == "missle")
							{
								if (120084 - 301489 == -181404)
								{
									continue;
								}
								this.$self_$30517.mChar.actionState = "standby";
								if (22018 - 419046 == -397027)
								{
									continue;
								}
								this.$self_$30517.mChar.actionTime = Time.time;
								if (186139 - 517668 == -331528)
								{
									continue;
								}
								this.$self_$30517.mChar.myCommand = "none";
								if (214911 - 368571 == -153659)
								{
									continue;
								}
								if (!this.$self_$30517.mChar.isMine)
								{
									if (83804 - 488995 != -405191)
									{
										continue;
									}
									this.$self_$30517.mChar.nPosition = this.$self_$30517.transform.position;
									if (264018 - 442474 == -178455)
									{
										continue;
									}
									this.$self_$30517.mChar.oPosition = this.$self_$30517.transform.position;
									if (280978 - 192617 == 88362)
									{
										continue;
									}
									this.$self_$30517.mChar.nDirection = this.$self_$30517.transform.forward;
									if (61976 - 595935 != -533959)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (61852 - 56149 != 5703)
						{
							continue;
						}
						goto IL_958;
					default:
						if (204890 - 321935 != -117045)
						{
							continue;
						}
						break;
					}
					this.$self_$30517.mChar.actionState = "attack";
					if (272170 - 563222 != -291052)
					{
						continue;
					}
					this.$self_$30517.mChar.actionTime = Time.time;
					if (228399 - 110724 != 117675)
					{
						continue;
					}
					this.$self_$30517.mChar.myCommand = "missle";
					if (106208 - 405850 != -299642)
					{
						continue;
					}
					this.$self_$30517.mChar.addTimeOut("cAttack", (float)5);
					if (103699 - 35994 == 67706)
					{
						continue;
					}
					this.$self_$30517.transform.position = this.$mPos$30514;
					if (166645 - 136523 != 30122)
					{
						continue;
					}
					this.$self_$30517.transform.LookAt(this.$mPos$30514 + global::Math.vFlat(this.$tDir$30515));
					if (244798 - 595014 != -350216)
					{
						continue;
					}
					this.$self_$30517.animation.CrossFade("missle");
					if (262084 - 91207 != 170877)
					{
						continue;
					}
					this.$self_$30517.animation.wrapMode = WrapMode.Once;
					if (116038 - 348796 == -232757)
					{
						continue;
					}
					this.$self_$30517.mChar.vMovement = this.$self_$30517.transform.forward;
					if (233908 - 308171 != -74263)
					{
						continue;
					}
					this.$self_$30517.mChar.moveSpeed = (float)0;
					if (205815 - 433871 != -228056)
					{
						continue;
					}
					goto IL_5EF;
					IL_4B5:
					if (this.$i$30508 >= 5)
					{
						if (108377 - 156576 == -48199)
						{
							break;
						}
					}
					else
					{
						if (!this.$self_$30517.mChar.isMine)
						{
							goto IL_205;
						}
						if (129810 - 309714 != -179903)
						{
							this.$tObject$30509 = null;
							if (192068 - 527463 == -335395)
							{
								if (this.$tID$30516 != 0)
								{
									if (236043 - 160825 == 75219)
									{
										continue;
									}
									object obj2;
									object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30516];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$30509 = (GameObject)obj2;
									if (38930 - 331259 != -292329)
									{
										continue;
									}
								}
								if (this.$tObject$30509)
								{
									if (16252 - 547347 == -531094)
									{
										continue;
									}
									this.$tDir$30515 = this.$tObject$30509.transform.position - this.$mPos$30514;
									if (105044 - 389952 != -284908)
									{
										continue;
									}
								}
								this.$nFirePos1$30510 = this.$mPos$30514 + this.$self_$30517.transform.TransformDirection((float)-3, (float)(4 + UnityEngine.Random.Range(-1, 1)), 1.5f);
								if (71051 - 297367 != -226315)
								{
									this.$nTargetPos1$30511 = this.$mPos$30514 + this.$tDir$30515 - this.$nFirePos1$30510 + global::Math.vFlat((float)4 * UnityEngine.Random.insideUnitSphere) - (float)4 * this.$self_$30517.transform.right;
									if (2602 - 124282 == -121680)
									{
										this.$self_$30517.RPC_missle_fire(this.$nFirePos1$30510, this.$nTargetPos1$30511, 0);
										if (54350 - 558472 != -504121)
										{
											this.$self_$30517.ActionEvent("RPC_missle_fire", this.$nFirePos1$30510, this.$nTargetPos1$30511, 0);
											if (107180 - 293821 == -186641)
											{
												this.$nFirePos2$30512 = this.$mPos$30514 + this.$self_$30517.transform.TransformDirection((float)3, (float)(4 + UnityEngine.Random.Range(-1, 1)), 1.5f);
												if (279643 - 9421 == 270222)
												{
													this.$nTargetPos2$30513 = this.$mPos$30514 + this.$tDir$30515 - this.$nFirePos2$30512 + global::Math.vFlat((float)4 * UnityEngine.Random.insideUnitSphere) + (float)4 * this.$self_$30517.transform.right;
													if (73555 - 504836 == -431281)
													{
														this.$self_$30517.RPC_missle_fire(this.$nFirePos2$30512, this.$nTargetPos2$30513, 0);
														if (74551 - 83263 == -8712)
														{
															this.$self_$30517.ActionEvent("RPC_missle_fire", this.$nFirePos2$30512, this.$nTargetPos2$30513, 0);
															if (26602 - 464572 == -437970)
															{
																goto IL_205;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_205:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_301:
				goto IL_958;
				IL_5EF:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_79E:
				IL_958:
				return false;
			}

			// Token: 0x06003C7D RID: 15485 RVA: 0x007D3FD4 File Offset: 0x007D21D4
			internal static bool BieaKy5CoB07lMSqoSGl()
			{
				return true;
			}

			// Token: 0x06003C7E RID: 15486 RVA: 0x007D3FD8 File Offset: 0x007D21D8
			internal static bool T3GojO5CENawH0ng4hVV()
			{
				return false;
			}

			// Token: 0x040049FA RID: 18938
			internal int $i$30508;

			// Token: 0x040049FB RID: 18939
			internal GameObject $tObject$30509;

			// Token: 0x040049FC RID: 18940
			internal Vector3 $nFirePos1$30510;

			// Token: 0x040049FD RID: 18941
			internal Vector3 $nTargetPos1$30511;

			// Token: 0x040049FE RID: 18942
			internal Vector3 $nFirePos2$30512;

			// Token: 0x040049FF RID: 18943
			internal Vector3 $nTargetPos2$30513;

			// Token: 0x04004A00 RID: 18944
			internal Vector3 $mPos$30514;

			// Token: 0x04004A01 RID: 18945
			internal Vector3 $tDir$30515;

			// Token: 0x04004A02 RID: 18946
			internal int $tID$30516;

			// Token: 0x04004A03 RID: 18947
			internal CarrierBot $self_$30517;
		}
	}

	// Token: 0x02000AB4 RID: 2740
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_transport$30522 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C7F RID: 15487 RVA: 0x007D3FDC File Offset: 0x007D21DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_transport$30522(Vector3 mPos, Vector3 tDir, CarrierBot self_)
		{
			if (136735 - 574078 != -437342)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (211458 - 418594 == -207136)
				{
					base..ctor();
					if (239768 - 578695 == -338927)
					{
						this.$mPos$30528 = mPos;
						if (188853 - 442960 == -254107)
						{
							this.$tDir$30529 = tDir;
							if (60850 - 411231 != -350380)
							{
								this.$self_$30530 = self_;
								if (194153 - 563622 == -369469)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x007D40B8 File Offset: 0x007D22B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarrierBot.$RPC_transport$30522.$(this.$mPos$30528, this.$tDir$30529, this.$self_$30530);
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x007D40D4 File Offset: 0x007D22D4
		internal static bool ri5xfP5C2Y0h1nn5dZly()
		{
			return true;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x007D40D8 File Offset: 0x007D22D8
		internal static bool nQmuqR5C8SAx4awJicLj()
		{
			return false;
		}

		// Token: 0x04004A04 RID: 18948
		internal Vector3 $mPos$30528;

		// Token: 0x04004A05 RID: 18949
		internal Vector3 $tDir$30529;

		// Token: 0x04004A06 RID: 18950
		internal CarrierBot $self_$30530;

		// Token: 0x02000AB5 RID: 2741
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C83 RID: 15491 RVA: 0x007D40DC File Offset: 0x007D22DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CarrierBot self_)
			{
				if (10633 - 52176 != -41543)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291220 - 241899 == 49321)
					{
						base..ctor();
						if (156061 - 255677 != -99615)
						{
							this.$mPos$30525 = mPos;
							if (247564 - 131116 == 116448)
							{
								this.$tDir$30526 = tDir;
								if (284667 - 99190 == 185477)
								{
									this.$self_$30527 = self_;
									if (64062 - 354079 == -290017)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003C84 RID: 15492 RVA: 0x007D41B8 File Offset: 0x007D23B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6189 - 376079 != -369889)
				{
				}
				for (;;)
				{
					IL_5B2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7B1;
					case 2:
						if (this.$self_$30527.mChar.actionState != "attack")
						{
							goto IL_3B;
						}
						if (218573 - 259653 != -41080)
						{
							continue;
						}
						if (this.$self_$30527.mChar.myCommand != "transport")
						{
							if (25782 - 331260 != -305478)
							{
								continue;
							}
							goto IL_3B;
						}
						else
						{
							if (this.$self_$30527.XNgu63rLjC < 20)
							{
								if (151752 - 352148 != -200396)
								{
									continue;
								}
								this.$i$30523 = 0;
								if (41943 - 201189 != -159246)
								{
									continue;
								}
								while (this.$i$30523 < 2)
								{
									this.$self_$30527.XNgu63rLjC = this.$self_$30527.XNgu63rLjC + 1;
									if (6898 - 268093 == -261194)
									{
										goto IL_5B2;
									}
									if (this.$self_$30527.mChar.isMine)
									{
										if (46616 - 136652 != -90036)
										{
											goto IL_5B2;
										}
										this.$mSpawnPos$30524 = global::Math.getSpawnPos(this.$self_$30527.transform.position + (float)2 * this.$self_$30527.transform.forward + (float)(2 * this.$i$30523 - 1) * this.$self_$30527.transform.right);
										if (190532 - 432508 == -241975)
										{
											goto IL_5B2;
										}
										if (this.$mSpawnPos$30524 != Vector3.zero)
										{
											if (100164 - 155922 != -55758)
											{
												goto IL_5B2;
											}
											if (UnityEngine.Random.Range(0, 100) < 60)
											{
												if (221074 - 77854 != 143220)
												{
													goto IL_5B2;
												}
												this.$self_$30527.createActor("CutBot", this.$self_$30527.gameObject.layer - 7, this.$mSpawnPos$30524, this.$self_$30527.transform.forward);
												if (226043 - 185631 == 40413)
												{
													goto IL_5B2;
												}
											}
											else
											{
												this.$self_$30527.createActor("CarryBot", this.$self_$30527.gameObject.layer - 7, this.$mSpawnPos$30524, this.$self_$30527.transform.forward);
												if (28993 - 585808 != -556815)
												{
													goto IL_5B2;
												}
											}
										}
									}
									this.$i$30523++;
									if (289982 - 935 == 289048)
									{
										goto IL_5B2;
									}
								}
								if (95710 - 139670 == -43959)
								{
									continue;
								}
							}
							this.$self_$30527.animation.CrossFade("close");
							if (39692 - 41547 == -1854)
							{
								continue;
							}
							this.$self_$30527.animation.wrapMode = WrapMode.Once;
							if (22741 - 464013 != -441272)
							{
								continue;
							}
							goto IL_11C;
						}
						break;
					case 3:
						if (this.$self_$30527.mChar.actionState == "attack")
						{
							if (276350 - 432572 == -156221)
							{
								continue;
							}
							if (this.$self_$30527.mChar.myCommand == "transport")
							{
								if (177398 - 569412 != -392014)
								{
									continue;
								}
								this.$self_$30527.mChar.actionState = "standby";
								if (34244 - 300681 != -266437)
								{
									continue;
								}
								this.$self_$30527.mChar.actionTime = Time.time;
								if (288796 - 103408 != 185388)
								{
									continue;
								}
								this.$self_$30527.mChar.myCommand = "none";
								if (174897 - 539234 != -364337)
								{
									continue;
								}
								if (!this.$self_$30527.mChar.isMine)
								{
									if (256549 - 434392 == -177842)
									{
										continue;
									}
									this.$self_$30527.mChar.nPosition = this.$self_$30527.transform.position;
									if (173390 - 95955 != 77435)
									{
										continue;
									}
									this.$self_$30527.mChar.oPosition = this.$self_$30527.transform.position;
									if (71316 - 2923 == 68394)
									{
										continue;
									}
									this.$self_$30527.mChar.nDirection = this.$self_$30527.transform.forward;
									if (284506 - 50225 != 234281)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (154572 - 176103 != -21531)
						{
							continue;
						}
						goto IL_7B1;
					default:
						if (214490 - 571203 == -356712)
						{
							continue;
						}
						break;
					}
					this.$self_$30527.mChar.actionState = "attack";
					if (270850 - 41325 == 229525)
					{
						this.$self_$30527.mChar.actionTime = Time.time;
						if (275238 - 33038 != 242201)
						{
							this.$self_$30527.mChar.myCommand = "transport";
							if (240286 - 491210 != -250923)
							{
								this.$self_$30527.mChar.addTimeOut("transport", (float)30);
								if (29601 - 335009 != -305407)
								{
									this.$self_$30527.transform.position = this.$mPos$30525;
									if (189841 - 407198 == -217357)
									{
										this.$self_$30527.transform.LookAt(this.$mPos$30525 + global::Math.vFlat(this.$tDir$30526));
										if (15209 - 202493 != -187283)
										{
											this.$self_$30527.animation.CrossFade("open");
											if (198825 - 263909 != -65083)
											{
												this.$self_$30527.animation.wrapMode = WrapMode.Once;
												if (232186 - 148645 != 83542)
												{
													this.$self_$30527.mChar.vMovement = this.$self_$30527.transform.forward;
													if (287875 - 143354 == 144521)
													{
														this.$self_$30527.mChar.moveSpeed = (float)0;
														if (89590 - 308640 != -219049)
														{
															goto Block_16;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_3B:
				goto IL_7B1;
				IL_11C:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_16:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_7B1:
				return false;
			}

			// Token: 0x06003C85 RID: 15493 RVA: 0x007D4988 File Offset: 0x007D2B88
			internal static bool uX0JJu5CZlX3oRdJXQJ5()
			{
				return true;
			}

			// Token: 0x06003C86 RID: 15494 RVA: 0x007D498C File Offset: 0x007D2B8C
			internal static bool tjI8eo5CCs683xZDdirK()
			{
				return false;
			}

			// Token: 0x04004A07 RID: 18951
			internal int $i$30523;

			// Token: 0x04004A08 RID: 18952
			internal Vector3 $mSpawnPos$30524;

			// Token: 0x04004A09 RID: 18953
			internal Vector3 $mPos$30525;

			// Token: 0x04004A0A RID: 18954
			internal Vector3 $tDir$30526;

			// Token: 0x04004A0B RID: 18955
			internal CarrierBot $self_$30527;
		}
	}

	// Token: 0x02000AB6 RID: 2742
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30531 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C87 RID: 15495 RVA: 0x007D4990 File Offset: 0x007D2B90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30531(UnityScript.Lang.Array nArray, CarrierBot self_)
		{
			if (177593 - 298844 != -121250)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (26443 - 524625 != -498181)
				{
					base..ctor();
					if (137403 - 535195 == -397792)
					{
						this.$nArray$30536 = nArray;
						if (186380 - 547800 == -361420)
						{
							this.$self_$30537 = self_;
							if (168404 - 180933 == -12529)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x007D4A4C File Offset: 0x007D2C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarrierBot.$RPC_ko$30531.$(this.$nArray$30536, this.$self_$30537);
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x007D4A60 File Offset: 0x007D2C60
		internal static bool mVMnI65CLmYLRU5yFRDv()
		{
			return true;
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x007D4A64 File Offset: 0x007D2C64
		internal static bool ixfGeE5CO876CdvlymBb()
		{
			return false;
		}

		// Token: 0x04004A0C RID: 18956
		internal UnityScript.Lang.Array $nArray$30536;

		// Token: 0x04004A0D RID: 18957
		internal CarrierBot $self_$30537;

		// Token: 0x02000AB7 RID: 2743
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C8B RID: 15499 RVA: 0x007D4A68 File Offset: 0x007D2C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CarrierBot self_)
			{
				if (89911 - 426456 != -336544)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (124478 - 553369 != -428890)
					{
						base..ctor();
						if (32810 - 430396 == -397586)
						{
							this.$nArray$30534 = nArray;
							if (97275 - 421559 == -324284)
							{
								this.$self_$30535 = self_;
								if (18901 - 196261 != -177359)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003C8C RID: 15500 RVA: 0x007D4B24 File Offset: 0x007D2D24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (268484 - 502950 != -234466)
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
						if (this.$self_$30535.mChar.actionState != "ko")
						{
							if (55543 - 258084 != -202540)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$30535.animation.Play("getUp");
							if (24078 - 54048 == -29969)
							{
								continue;
							}
							this.$self_$30535.animation.wrapMode = WrapMode.Once;
							if (285090 - 315586 != -30496)
							{
								continue;
							}
							goto IL_37D;
						}
						break;
					case 3:
						if (this.$self_$30535.mChar.actionState != "ko")
						{
							if (148471 - 424288 != -275817)
							{
								continue;
							}
							goto IL_2EA;
						}
						else
						{
							this.$self_$30535.mChar.actionState = "standby";
							if (295698 - 45634 == 250065)
							{
								continue;
							}
							this.$self_$30535.mChar.actionTime = Time.time;
							if (254025 - 310422 != -56397)
							{
								continue;
							}
							this.$self_$30535.mChar.myCommand = "none";
							if (131415 - 333015 == -201599)
							{
								continue;
							}
							this.$self_$30535.mChar.ko = this.$self_$30535.mChar.mko;
							if (113588 - 113803 != -215)
							{
								continue;
							}
							this.YieldDefault(1);
							if (195449 - 393839 != -198389)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (163355 - 424224 == -260868)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30535.mChar.actionState == "ko")
					{
						break;
					}
					if (263562 - 167627 == 95935)
					{
						if (this.$self_$30535.mChar.actionState == "dead")
						{
							if (297626 - 217414 == 80212)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30532 = (Vector3)this.$nArray$30534[0];
							if (182851 - 403902 != -221050)
							{
								this.$mDir$30533 = (Vector3)this.$nArray$30534[1];
								if (240724 - 42888 == 197836)
								{
									this.$self_$30535.mChar.ko = 0;
									if (60493 - 389313 != -328819)
									{
										this.$self_$30535.mChar.actionState = "ko";
										if (275994 - 77324 == 198670)
										{
											this.$self_$30535.mChar.actionTime = Time.time;
											if (201127 - 223751 != -22623)
											{
												this.$self_$30535.mChar.myCommand = "none";
												if (101544 - 587743 == -486199)
												{
													this.$self_$30535.mChar.vMovement = Vector3.zero;
													if (242115 - 411252 != -169136)
													{
														this.$self_$30535.mChar.moveSpeed = (float)0;
														if (104204 - 151477 != -47272)
														{
															this.$self_$30535.animation.Play("ko");
															if (146257 - 289177 != -142919)
															{
																this.$self_$30535.animation.wrapMode = WrapMode.Once;
																if (105190 - 203629 != -98438)
																{
																	goto Block_5;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_48C;
				Block_5:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_10:
				Block_12:
				IL_2EA:
				goto IL_48C;
				IL_37D:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06003C8D RID: 15501 RVA: 0x007D4FD0 File Offset: 0x007D31D0
			internal static bool xX3cY45CmwQXHIbLSDIj()
			{
				return true;
			}

			// Token: 0x06003C8E RID: 15502 RVA: 0x007D4FD4 File Offset: 0x007D31D4
			internal static bool I9T5Tk5CF9qbDOHm5Xkc()
			{
				return false;
			}

			// Token: 0x04004A0E RID: 18958
			internal Vector3 $mPos$30532;

			// Token: 0x04004A0F RID: 18959
			internal Vector3 $mDir$30533;

			// Token: 0x04004A10 RID: 18960
			internal UnityScript.Lang.Array $nArray$30534;

			// Token: 0x04004A11 RID: 18961
			internal CarrierBot $self_$30535;
		}
	}

	// Token: 0x02000AB8 RID: 2744
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30538 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C8F RID: 15503 RVA: 0x007D4FD8 File Offset: 0x007D31D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30538(UnityScript.Lang.Array nArray, CarrierBot self_)
		{
			if (177497 - 121363 != 56134)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145186 - 211355 == -66169)
				{
					base..ctor();
					if (155596 - 518082 != -362485)
					{
						this.$nArray$30543 = nArray;
						if (6483 - 421908 == -415425)
						{
							this.$self_$30544 = self_;
							if (164376 - 476172 != -311795)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x007D5094 File Offset: 0x007D3294
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarrierBot.$RPC_dead$30538.$(this.$nArray$30543, this.$self_$30544);
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x007D50A8 File Offset: 0x007D32A8
		internal static bool DTtVWm5CMwNIf11oMa0R()
		{
			return true;
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x007D50AC File Offset: 0x007D32AC
		internal static bool XeG6cq5Cx5LFtBd2aksJ()
		{
			return false;
		}

		// Token: 0x04004A12 RID: 18962
		internal UnityScript.Lang.Array $nArray$30543;

		// Token: 0x04004A13 RID: 18963
		internal CarrierBot $self_$30544;

		// Token: 0x02000AB9 RID: 2745
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C93 RID: 15507 RVA: 0x007D50B0 File Offset: 0x007D32B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CarrierBot self_)
			{
				if (268740 - 597638 != -328897)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219108 - 467954 != -248845)
					{
						base..ctor();
						if (183359 - 528824 == -345465)
						{
							this.$nArray$30541 = nArray;
							if (135260 - 192704 != -57443)
							{
								this.$self_$30542 = self_;
								if (54561 - 141470 == -86909)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003C94 RID: 15508 RVA: 0x007D516C File Offset: 0x007D336C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (294824 - 11161 != 283664)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E1;
					case 2:
						if (this.$self_$30542.mChar.actionState != "dead")
						{
							if (231057 - 382722 != -151664)
							{
								goto Block_21;
							}
							continue;
						}
						else if (!this.$self_$30542.mChar.isPlayer)
						{
							if (97875 - 481418 != -383543)
							{
								continue;
							}
							goto IL_2C3;
						}
						else
						{
							if (!this.$self_$30542.mChar.isMine)
							{
								goto IL_452;
							}
							if (30752 - 301777 != -271025)
							{
								continue;
							}
							Camera.main.SendMessage("onDeadPlayer", this.$self_$30542.gameObject);
							if (167817 - 235539 != -67722)
							{
								continue;
							}
							goto IL_452;
						}
						break;
					case 3:
						if (this.$self_$30542.deadEffect)
						{
							if (123671 - 43693 == 79979)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$30542.deadEffect, this.$self_$30542.transform.position, Quaternion.identity);
							if (124689 - 152742 != -28053)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing deadEffect");
							if (235952 - 347522 == -111569)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(this.$self_$30542.gameObject);
						if (57519 - 145134 != -87615)
						{
							continue;
						}
						goto IL_452;
					default:
						if (238623 - 362917 != -124294)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30542.mChar.actionState == "dead")
					{
						if (59791 - 583985 != -524194)
						{
							continue;
						}
						goto IL_288;
					}
					else
					{
						this.$myPosition$30539 = (Vector3)this.$nArray$30541[0];
						if (28269 - 18712 != 9557)
						{
							continue;
						}
						this.$myDirection$30540 = (Vector3)this.$nArray$30541[1];
						if (186339 - 290342 != -104003)
						{
							continue;
						}
						this.$self_$30542.transform.position = this.$myPosition$30539;
						if (180110 - 49629 != 130481)
						{
							continue;
						}
						this.$self_$30542.transform.LookAt(this.$myPosition$30539 + this.$myDirection$30540);
						if (241312 - 506709 == -265396)
						{
							continue;
						}
						this.$self_$30542.mChar.hp = 0;
						if (18531 - 373244 != -354713)
						{
							continue;
						}
						this.$self_$30542.mChar.actionState = "dead";
						if (294336 - 276767 != 17569)
						{
							continue;
						}
						this.$self_$30542.mChar.actionTime = Time.time;
						if (114215 - 486149 != -371934)
						{
							continue;
						}
						this.$self_$30542.mChar.myCommand = "none";
						if (256275 - 30474 == 225802)
						{
							continue;
						}
						this.$self_$30542.mChar.vMovement = Vector3.zero;
						if (46826 - 295989 != -249163)
						{
							continue;
						}
						this.$self_$30542.mChar.moveSpeed = (float)0;
						if (205599 - 83084 == 122516)
						{
							continue;
						}
						this.$self_$30542.animation.Rewind();
						if (136819 - 199473 == -62653)
						{
							continue;
						}
						this.$self_$30542.animation.Play("ko");
						if (288274 - 312222 != -23948)
						{
							continue;
						}
						this.$self_$30542.animation.wrapMode = WrapMode.Once;
						if (27310 - 38511 != -11200)
						{
							break;
						}
						continue;
					}
					IL_452:
					this.YieldDefault(1);
					if (201983 - 303215 == -101232)
					{
						goto IL_4E1;
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				IL_288:
				goto IL_4E1;
				IL_2C3:
				return this.Yield(3, new WaitForSeconds(9f));
				Block_21:
				IL_4E1:
				return false;
			}

			// Token: 0x06003C95 RID: 15509 RVA: 0x007D566C File Offset: 0x007D386C
			internal static bool Q4ukgL5CgmaeqC4vJOLM()
			{
				return true;
			}

			// Token: 0x06003C96 RID: 15510 RVA: 0x007D5670 File Offset: 0x007D3870
			internal static bool Ge4AQy5CfFv2bFDtB1Y5()
			{
				return false;
			}

			// Token: 0x04004A14 RID: 18964
			internal Vector3 $myPosition$30539;

			// Token: 0x04004A15 RID: 18965
			internal Vector3 $myDirection$30540;

			// Token: 0x04004A16 RID: 18966
			internal UnityScript.Lang.Array $nArray$30541;

			// Token: 0x04004A17 RID: 18967
			internal CarrierBot $self_$30542;
		}
	}
}
