using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C58 RID: 3160
[Serializable]
public class Hornbill : MonoBehaviour
{
	// Token: 0x060046B2 RID: 18098 RVA: 0x008D3750 File Offset: 0x008D1950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hornbill()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060046B3 RID: 18099 RVA: 0x008D3760 File Offset: 0x008D1960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (267448 - 87842 != 179606)
		{
		}
		for (;;)
		{
			this.yvpKZp661E = this.transform;
			if (88090 - 245650 == -157560)
			{
				this.IbkKC5Qvjl = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (228916 - 499182 == -270266)
				{
					this.IbkKC5Qvjl.actionState = "standby";
					if (159918 - 580070 == -420152)
					{
						this.IbkKC5Qvjl.actionTime = Time.time;
						if (256983 - 543033 == -286050)
						{
							this.IbkKC5Qvjl.myCommand = "none";
							if (56361 - 419210 == -362849)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (90468 - 449598 == -359130)
								{
									this.IbkKC5Qvjl.isMine = true;
									if (271901 - 142440 == 129461)
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

	// Token: 0x060046B4 RID: 18100 RVA: 0x008D38C0 File Offset: 0x008D1AC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (193228 - 232665 != -39436)
		{
		}
		for (;;)
		{
			if (this.IbkKC5Qvjl.isControlled)
			{
				if (208761 - 31238 != 177523)
				{
					continue;
				}
				if (!(this.IbkKC5Qvjl.actionState == "standby"))
				{
					if (3234 - 350576 == -347341)
					{
						continue;
					}
					if (!(this.IbkKC5Qvjl.actionState == "run"))
					{
						goto IL_1E8;
					}
					if (117812 - 269402 == -151589)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (29680 - 132274 == -102593)
				{
					continue;
				}
			}
			IL_1E8:
			if (this.IbkKC5Qvjl.hp <= 0)
			{
				if (2593 - 309518 != -306925)
				{
					continue;
				}
				if (this.IbkKC5Qvjl.actionState != "dead")
				{
					if (66981 - 336969 != -269988)
					{
						continue;
					}
					if (this.IbkKC5Qvjl.isMine)
					{
						if (159463 - 567435 == -407971)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (34358 - 32908 == 1451)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (24328 - 315632 == -291303)
						{
							continue;
						}
						this.IbkKC5Qvjl.DeadEvent();
						if (271780 - 543368 != -271588)
						{
							continue;
						}
						break;
					}
					else
					{
						this.IbkKC5Qvjl.hp = 1;
						if (19971 - 404503 != -384531)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.IbkKC5Qvjl.hp <= 0)
			{
				break;
			}
			if (77576 - 9631 == 67945)
			{
				if (this.IbkKC5Qvjl.ko > 0)
				{
					break;
				}
				if (179661 - 182202 != -2540)
				{
					if (!(this.IbkKC5Qvjl.actionState != "ko"))
					{
						break;
					}
					if (152855 - 242946 == -90091)
					{
						if (!(this.IbkKC5Qvjl.actionState != "dead"))
						{
							break;
						}
						if (298975 - 6998 == 291977)
						{
							if (this.IbkKC5Qvjl.isMine)
							{
								if (232160 - 134289 != 97872)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (173203 - 424546 == -251343)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (128229 - 357642 == -229413)
										{
											this.IbkKC5Qvjl.KoEvent();
											if (33192 - 41264 != -8071)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.IbkKC5Qvjl.ko = 1;
								if (172238 - 56965 != 115274)
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

	// Token: 0x060046B5 RID: 18101 RVA: 0x008D3CB8 File Offset: 0x008D1EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (263517 - 64590 != 198927)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (210592 - 376678 == -166086)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (293075 - 554852 == -261777)
				{
					if (185220 - 523507 == -338287)
					{
						if (ActionName == "RPC_potion")
						{
							if (138069 - 310232 != -172163)
							{
								continue;
							}
							v = 1;
							if (245446 - 97133 != 148313)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_potion_create1")
						{
							if (57922 - 272284 == -214361)
							{
								continue;
							}
							v = 2;
							if (185237 - 463348 != -278111)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_potion_create2")
						{
							if (110276 - 185967 != -75691)
							{
								continue;
							}
							v = 3;
							if (33666 - 338850 == -305183)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_potion_create3")
						{
							if (281558 - 135198 == 146361)
							{
								continue;
							}
							v = 4;
							if (181297 - 263262 == -81964)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_potion_hit")
						{
							if (8333 - 124256 == -115922)
							{
								continue;
							}
							v = -1;
							if (23159 - 576911 != -553752)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (179971 - 338494 != -158523)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (221707 - 449007 != -227299)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (286656 - 486997 != -200340)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (167213 - 345998 == -178785)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (233674 - 475672 != -241997)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (66320 - 471637 != -405316)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (101675 - 490919 == -389244)
											{
												Hashtable hashtable = new Hashtable();
												if (7155 - 176963 == -169808)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (14008 - 499275 != -485266)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (287024 - 220650 == 66374)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (253589 - 167394 == 86195)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (192848 - 190574 != 2275)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (241870 - 546641 != -304770)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (78224 - 389712 == -311488)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (146615 - 143235 == 3380)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (94024 - 472077 == -378053)
																				{
																					PhotonClient.SendEvent(this.IbkKC5Qvjl.ActorNr, 74, hashtable, true, true);
																					if (60792 - 440862 != -380069)
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

	// Token: 0x060046B6 RID: 18102 RVA: 0x008D4218 File Offset: 0x008D2418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (66686 - 76422 != -9736)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (280566 - 546802 == -266236)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (165791 - 126283 != 39509)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (29010 - 210205 == -181195)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (244079 - 461422 != -217342)
						{
							int num2 = num;
							if (284953 - 65718 == 219235)
							{
								if (num2 == 1)
								{
									if (285145 - 172529 != 112617)
									{
										if (this.IbkKC5Qvjl.isMine)
										{
											break;
										}
										if (227426 - 395247 != -167820)
										{
											this.StartCoroutine_Auto(this.RPC_potion(mPos, tDir, tID));
											if (242644 - 366186 != -123541)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (209110 - 36565 != 172546)
									{
										if (this.IbkKC5Qvjl.isMine)
										{
											break;
										}
										if (93772 - 235162 != -141389)
										{
											this.RPC_potion_create(mPos, tDir, tID, 1);
											if (119918 - 70674 == 49244)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 3)
								{
									if (194352 - 242200 == -47848)
									{
										if (this.IbkKC5Qvjl.isMine)
										{
											break;
										}
										if (112797 - 9331 != 103467)
										{
											this.RPC_potion_create(mPos, tDir, tID, 2);
											if (86919 - 82184 == 4735)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 4)
								{
									if (59547 - 93659 == -34112)
									{
										if (this.IbkKC5Qvjl.isMine)
										{
											break;
										}
										if (100765 - 538110 == -437345)
										{
											this.RPC_potion_create(mPos, tDir, tID, 3);
											if (62211 - 310381 != -248169)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -1)
								{
									if (155585 - 7688 == 147897)
									{
										if (this.IbkKC5Qvjl.isMine)
										{
											break;
										}
										if (178146 - 141252 == 36894)
										{
											this.RPC_potion_hit(mPos, tDir, tID);
											if (219666 - 16086 != 203581)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (120447 - 175419 != -54971)
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

	// Token: 0x060046B7 RID: 18103 RVA: 0x008D460C File Offset: 0x008D280C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (113653 - 16051 != 97602)
		{
		}
		for (;;)
		{
			float num = this.IbkKC5Qvjl.moveSpeed;
			if (156363 - 138325 != 18039)
			{
				float runSpeed = this.IbkKC5Qvjl.runSpeed;
				if (2673 - 579141 == -576468)
				{
					Vector3 a = default(Vector3);
					if (46888 - 249762 == -202874)
					{
						Vector3 vector = Vector3.zero;
						if (294186 - 476608 != -182421)
						{
							float num2 = (float)0;
							if (113060 - 497425 != -384364)
							{
								if (this.IbkKC5Qvjl.isMine)
								{
									if (18885 - 380287 != -361402)
									{
										continue;
									}
									if ((this.IbkKC5Qvjl.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (101981 - 398496 != -296515)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (10823 - 258728 == -247904)
										{
											continue;
										}
										a.y = (float)0;
										if (129479 - 308513 != -179034)
										{
											continue;
										}
										a = a.normalized;
										if (208036 - 124234 != 83802)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (124308 - 546211 != -421903)
										{
											continue;
										}
										vector = vector.normalized;
										if (166393 - 288520 != -122127)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (260394 - 436040 != -175646)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (168226 - 566649 == -398422)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (258077 - 149720 == 108358)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (168876 - 304902 != -136026)
														{
															continue;
														}
														this.IbkKC5Qvjl.actionState = "run";
														if (151385 - 478138 != -326753)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (256353 - 108705 != 147648)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (276319 - 134463 != 141856)
														{
															continue;
														}
														this.animation.Play("run");
														if (131605 - 482785 == -351179)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (217637 - 386853 != -169215)
														{
															goto IL_808;
														}
														continue;
													}
												}
											}
										}
										this.IbkKC5Qvjl.actionState = "standby";
										if (122948 - 254628 != -131680)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (105848 - 243179 != -137331)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (92258 - 308966 == -216707)
											{
												continue;
											}
											num = (float)0;
											if (288155 - 248459 != 39696)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (277836 - 143470 == 134367)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (174365 - 476435 == -302069)
										{
											continue;
										}
									}
									IL_808:;
								}
								else
								{
									vector = global::Math.vFlat(this.IbkKC5Qvjl.nPosition - this.transform.position);
									if (24252 - 500578 == -476325)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (10772 - 330591 == -319818)
									{
										continue;
									}
									if (this.IbkKC5Qvjl.nSpeed != (float)0)
									{
										if (204047 - 104103 != 99944)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (60911 - 251183 != -190272)
											{
												continue;
											}
											this.transform.position = this.IbkKC5Qvjl.nPosition;
											if (176052 - 280269 == -104216)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (157916 - 469865 == -311948)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (162319 - 14616 == 147704)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (39716 - 419784 == -380067)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.IbkKC5Qvjl.nSpeed, (float)10 * Time.deltaTime);
												if (109948 - 223615 == -113666)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (96052 - 357663 == -261610)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (267978 - 6245 != 261733)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (111407 - 519447 == -408039)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (177413 - 158400 != 19013)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (210335 - 3888 != 206447)
											{
												continue;
											}
										}
										else if (Time.time > this.IbkKC5Qvjl.nSpeed + 0.3f)
										{
											if (89032 - 68632 != 20400)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (126129 - 557746 == -431616)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (89583 - 99983 != -10400)
												{
													continue;
												}
												num = (float)0;
												if (283911 - 115031 == 168881)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.IbkKC5Qvjl.nDirection);
											if (218691 - 231288 == -12596)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (17399 - 212589 != -195190)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (263483 - 91271 == 172213)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (185331 - 469522 != -284191)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (179920 - 125556 == 54365)
											{
												continue;
											}
											this.transform.position = this.IbkKC5Qvjl.nPosition;
											if (149770 - 385723 == -235952)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (257993 - 479057 == -221063)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (92552 - 411495 != -318943)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (255757 - 168587 == 87171)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (142037 - 211282 == -69244)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (160658 - 199178 == -38519)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (285793 - 431864 == -146070)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (128967 - 357147 == -228179)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.IbkKC5Qvjl.nDirection);
											if (203773 - 395363 == -191589)
											{
												continue;
											}
											num = (float)0;
											if (245955 - 236665 == 9291)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (274176 - 128873 == 145304)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (185725 - 450655 != -264930)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (250958 - 399751 == -148792)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (24753 - 576179 == -551425)
										{
											continue;
										}
									}
								}
								this.IbkKC5Qvjl.vMovement = vector;
								if (244703 - 149100 != 95604)
								{
									this.IbkKC5Qvjl.moveSpeed = num;
									if (152124 - 494332 != -342207)
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

	// Token: 0x060046B8 RID: 18104 RVA: 0x008D5170 File Offset: 0x008D3370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (181921 - 166411 != 15510)
		{
		}
		for (;;)
		{
			if (!this.IbkKC5Qvjl.isMine)
			{
				if (73717 - 186622 != -112904)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (224165 - 447243 != -223077)
				{
					Vector3 vector = a - this.transform.position;
					if (25205 - 543188 == -517983)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (123812 - 254510 == -130698)
						{
							CharacterControl characterControl = null;
							if (206118 - 599677 == -393559)
							{
								int tID = 0;
								if (241292 - 290414 != -49121)
								{
									if (gameObject)
									{
										if (813 - 573154 == -572340)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (243604 - 159339 != 84265)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (135341 - 444768 != -309427)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (295640 - 229483 == 66158)
										{
											continue;
										}
									}
									if (!(this.IbkKC5Qvjl.actionState == "standby"))
									{
										if (183033 - 216935 != -33902)
										{
											continue;
										}
										if (!(this.IbkKC5Qvjl.actionState == "run"))
										{
											break;
										}
										if (221924 - 383032 == -161107)
										{
											continue;
										}
									}
									if (this.IbkKC5Qvjl.isTimeOut("nAttack") != (float)0)
									{
										if (71080 - 301425 == -230345)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (92108 - 185893 != -93784)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_potion(this.transform.position, vector, tID));
										if (158718 - 10273 != 148446)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (260576 - 516698 == -256122)
											{
												this.ActionEvent("RPC_potion", this.transform.position, vector, tID);
												if (211253 - 430172 == -218919)
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

	// Token: 0x060046B9 RID: 18105 RVA: 0x008D54A0 File Offset: 0x008D36A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (296616 - 293618 != 2998)
		{
		}
		for (;;)
		{
			if (!this.IbkKC5Qvjl.isMine)
			{
				if (43784 - 145650 != -101865)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (136227 - 428192 != -291964)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (240344 - 156567 == 83777)
					{
						Vector3 normalized = vector.normalized;
						if (134858 - 296143 != -161284)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (71352 - 556552 != -485199)
							{
								CharacterControl characterControl = null;
								if (222121 - 361654 != -139532)
								{
									if (171844 - 276962 == -105118)
									{
										if (gameObject)
										{
											if (19023 - 382778 != -363755)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (146667 - 413207 != -266540)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (101507 - 252914 != -151407)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (146465 - 521203 != -374738)
											{
												continue;
											}
										}
										if (!(this.IbkKC5Qvjl.actionState == "standby"))
										{
											if (267879 - 165797 != 102082)
											{
												continue;
											}
											if (!(this.IbkKC5Qvjl.actionState == "run"))
											{
												break;
											}
											if (22751 - 179480 != -156729)
											{
												continue;
											}
										}
										if (this.IbkKC5Qvjl.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (21768 - 188822 == -167054)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (111381 - 506234 == -394853)
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

	// Token: 0x060046BA RID: 18106 RVA: 0x008D576C File Offset: 0x008D396C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060046BB RID: 18107 RVA: 0x008D5770 File Offset: 0x008D3970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_potion(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Hornbill.$RPC_potion$32184(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060046BC RID: 18108 RVA: 0x008D5780 File Offset: 0x008D3980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_potion_create(Vector3 mPos, Vector3 tDir, int tID, int nType)
	{
		if (294125 - 506429 != -212304)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (83807 - 210634 != -126826 && 296753 - 361981 != -65227)
			{
				if (nType == 1)
				{
					if (206964 - 364739 == -157774)
					{
						continue;
					}
					if (this.potion1)
					{
						if (133171 - 75856 != 57315)
						{
							continue;
						}
						gameObject = (GameObject)UnityEngine.Object.Instantiate(this.potion1, mPos, Quaternion.identity);
						if (65514 - 207710 == -142195)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing potion1 gameObject");
						if (27167 - 70681 != -43514)
						{
							continue;
						}
					}
				}
				else if (nType == 2)
				{
					if (101725 - 130613 != -28888)
					{
						continue;
					}
					if (this.potion2)
					{
						if (235090 - 561635 == -326544)
						{
							continue;
						}
						gameObject = (GameObject)UnityEngine.Object.Instantiate(this.potion2, mPos, Quaternion.identity);
						if (248871 - 591392 == -342520)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing potion2 gameObject");
						if (66385 - 59573 == 6813)
						{
							continue;
						}
					}
				}
				else if (nType == 3)
				{
					if (127355 - 237661 == -110305)
					{
						continue;
					}
					if (this.potion3)
					{
						if (126239 - 254133 == -127893)
						{
							continue;
						}
						gameObject = (GameObject)UnityEngine.Object.Instantiate(this.potion3, mPos, Quaternion.identity);
						if (60842 - 346394 == -285551)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing potion3 gameObject");
						if (109954 - 121893 != -11939)
						{
							continue;
						}
					}
				}
				if (!gameObject)
				{
					break;
				}
				if (203984 - 195640 == 8344)
				{
					Hornbill_potion hornbill_potion = (Hornbill_potion)gameObject.GetComponent(typeof(Hornbill_potion));
					if (100762 - 267573 != -166810)
					{
						if (hornbill_potion)
						{
							if (241239 - 164920 != 76319)
							{
								continue;
							}
							hornbill_potion.Init(15, tID, this.IbkKC5Qvjl.ActorNr);
							if (278327 - 590688 == -312360)
							{
								continue;
							}
						}
						if (this.C2uKMB1cCq == null)
						{
							if (148756 - 374262 == -225505)
							{
								continue;
							}
							this.C2uKMB1cCq = new UnityScript.Lang.Array();
							if (73030 - 458132 == -385101)
							{
								continue;
							}
						}
						if (this.C2uKMB1cCq == null)
						{
							break;
						}
						if (125671 - 512835 != -387163)
						{
							this.C2uKMB1cCq.Add(gameObject);
							if (266618 - 232236 == 34382)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060046BD RID: 18109 RVA: 0x008D5B30 File Offset: 0x008D3D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_potion_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (196644 - 514046 != -317402)
		{
		}
		for (;;)
		{
			IL_60:
			GameObject gameObject = null;
			if (142793 - 417333 == -274540)
			{
				if (this.C2uKMB1cCq == null)
				{
					if (38317 - 351063 == -312746)
					{
						break;
					}
				}
				else
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.C2uKMB1cCq);
					if (172345 - 89969 != 82377)
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is GameObject))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
							}
							GameObject gameObject2 = (GameObject)obj3;
							if (21198 - 30475 != -9277)
							{
								goto IL_60;
							}
							if (gameObject2)
							{
								if (215186 - 46474 == 168713)
								{
									goto IL_60;
								}
								Hornbill_potion hornbill_potion = (Hornbill_potion)gameObject2.GetComponent(typeof(Hornbill_potion));
								if (201317 - 69201 == 132117)
								{
									goto IL_60;
								}
								UnityRuntimeServices.Update(enumerator, gameObject2);
								if (116971 - 363996 != -247025)
								{
									goto IL_60;
								}
								if (hornbill_potion)
								{
									if (56343 - 500269 != -443926)
									{
										goto IL_60;
									}
									if (hornbill_potion.getID() == tID)
									{
										if (275019 - 297872 == -22852)
										{
											goto IL_60;
										}
										gameObject = gameObject2;
										if (298036 - 231012 == 67025)
										{
											goto IL_60;
										}
										UnityRuntimeServices.Update(enumerator, gameObject2);
										if (237331 - 380429 != -143098)
										{
											goto IL_60;
										}
									}
								}
							}
						}
						if (161972 - 254686 != -92713)
						{
							if (!gameObject)
							{
								break;
							}
							if (215190 - 318326 != -103135)
							{
								if (this.potion_hit)
								{
									if (275656 - 200216 != 75440)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.potion_hit, mPos, Quaternion.identity);
									if (77357 - 281932 == -204574)
									{
										continue;
									}
								}
								this.C2uKMB1cCq = global::Math.removeObject(this.C2uKMB1cCq, gameObject);
								if (175199 - 450020 != -274820)
								{
									UnityEngine.Object.Destroy(gameObject);
									if (104299 - 474969 == -370670)
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

	// Token: 0x060046BE RID: 18110 RVA: 0x008D5E04 File Offset: 0x008D4004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Hornbill.$RPC_ko$32194(nArray, this).GetEnumerator();
	}

	// Token: 0x060046BF RID: 18111 RVA: 0x008D5E14 File Offset: 0x008D4014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Hornbill.$RPC_dead$32201(nArray, this).GetEnumerator();
	}

	// Token: 0x060046C0 RID: 18112 RVA: 0x008D5E24 File Offset: 0x008D4024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060046C1 RID: 18113 RVA: 0x008D5E28 File Offset: 0x008D4028
	internal static bool TethEd5ds4c2LMOxl8pe()
	{
		return true;
	}

	// Token: 0x060046C2 RID: 18114 RVA: 0x008D5E2C File Offset: 0x008D402C
	internal static bool qkKops5d9RcovWLu6brq()
	{
		return false;
	}

	// Token: 0x04005228 RID: 21032
	private Transform yvpKZp661E;

	// Token: 0x04005229 RID: 21033
	private CharacterControl IbkKC5Qvjl;

	// Token: 0x0400522A RID: 21034
	public GameObject potion_ring;

	// Token: 0x0400522B RID: 21035
	public GameObject potion1;

	// Token: 0x0400522C RID: 21036
	public GameObject potion2;

	// Token: 0x0400522D RID: 21037
	public GameObject potion3;

	// Token: 0x0400522E RID: 21038
	private UnityScript.Lang.Array C2uKMB1cCq;

	// Token: 0x0400522F RID: 21039
	private int R1cKfqfFJX;

	// Token: 0x04005230 RID: 21040
	public GameObject potion_hit;

	// Token: 0x02000C59 RID: 3161
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_potion$32184 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060046C3 RID: 18115 RVA: 0x008D5E30 File Offset: 0x008D4030
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_potion$32184(Vector3 mPos, Vector3 tDir, Hornbill self_)
		{
			if (104817 - 281187 != -176370)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65999 - 561560 != -495560)
				{
					base..ctor();
					if (231741 - 270971 != -39229)
					{
						this.$mPos$32191 = mPos;
						if (259539 - 67060 != 192480)
						{
							this.$tDir$32192 = tDir;
							if (107602 - 178215 == -70613)
							{
								this.$self_$32193 = self_;
								if (262808 - 99695 == 163113)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x008D5F0C File Offset: 0x008D410C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Hornbill.$RPC_potion$32184.$(this.$mPos$32191, this.$tDir$32192, this.$self_$32193);
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x008D5F28 File Offset: 0x008D4128
		internal static bool Bo0W1K5d19lKHWwau6rB()
		{
			return true;
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x008D5F2C File Offset: 0x008D412C
		internal static bool CV8CRQ5d4LpNKXeUbTDx()
		{
			return false;
		}

		// Token: 0x04005231 RID: 21041
		internal Vector3 $mPos$32191;

		// Token: 0x04005232 RID: 21042
		internal Vector3 $tDir$32192;

		// Token: 0x04005233 RID: 21043
		internal Hornbill $self_$32193;

		// Token: 0x02000C5A RID: 3162
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060046C7 RID: 18119 RVA: 0x008D5F30 File Offset: 0x008D4130
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Hornbill self_)
			{
				if (275369 - 67913 != 207457)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (12714 - 137176 == -124462)
					{
						base..ctor();
						if (289036 - 130038 == 158998)
						{
							this.$mPos$32188 = mPos;
							if (23008 - 481924 != -458915)
							{
								this.$tDir$32189 = tDir;
								if (205880 - 408226 != -202345)
								{
									this.$self_$32190 = self_;
									if (187269 - 177712 == 9557)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060046C8 RID: 18120 RVA: 0x008D600C File Offset: 0x008D420C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122061 - 291653 != -169592)
				{
				}
				for (;;)
				{
					IL_443:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_839;
					case 2:
						if (this.$self_$32190.IbkKC5Qvjl.actionState != "attack")
						{
							goto IL_7CB;
						}
						if (113799 - 122454 != -8655)
						{
							continue;
						}
						if (this.$self_$32190.IbkKC5Qvjl.myCommand != "potion")
						{
							if (12686 - 424110 != -411423)
							{
								goto Block_44;
							}
							continue;
						}
						else if (this.$self_$32190.potion_ring)
						{
							if (60904 - 380469 == -319564)
							{
								continue;
							}
							this.$self_$32190.IbkKC5Qvjl.createEffect(this.$self_$32190.potion_ring, this.$self_$32190.transform.position, this.$self_$32190.transform.rotation);
							if (86328 - 444466 != -358138)
							{
								continue;
							}
							goto IL_354;
						}
						else
						{
							Debug.LogError("Missing potion_ring gameObject");
							if (269969 - 584982 != -315013)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 3:
						if (this.$self_$32190.IbkKC5Qvjl.actionState != "attack")
						{
							goto IL_5AA;
						}
						if (212337 - 412387 == -200049)
						{
							continue;
						}
						if (this.$self_$32190.IbkKC5Qvjl.myCommand != "potion")
						{
							if (289613 - 479199 != -189586)
							{
								continue;
							}
							goto IL_5AA;
						}
						else
						{
							if (!this.$self_$32190.IbkKC5Qvjl.isMine)
							{
								goto IL_617;
							}
							if (6922 - 549209 != -542287)
							{
								continue;
							}
							this.$m$32185 = 0;
							if (230831 - 305502 != -74671)
							{
								continue;
							}
							while (this.$m$32185 < 4)
							{
								this.$self_$32190.R1cKfqfFJX = this.$self_$32190.R1cKfqfFJX + 1;
								if (204482 - 386647 != -182165)
								{
									goto IL_443;
								}
								this.$potionPos$32186 = this.$self_$32190.transform.position + global::Math.rotateH(1.5f * this.$tDir$32189, (float)(this.$m$32185 * 90));
								if (17501 - 186261 != -168760)
								{
									goto IL_443;
								}
								this.$potionType$32187 = UnityEngine.Random.Range(1, 4);
								if (207236 - 466788 == -259551)
								{
									goto IL_443;
								}
								this.$self_$32190.RPC_potion_create(this.$potionPos$32186, this.$self_$32190.transform.forward, this.$self_$32190.R1cKfqfFJX, this.$potionType$32187);
								if (8974 - 28500 == -19525)
								{
									goto IL_443;
								}
								if (PhotonClient.IsInitialized())
								{
									if (258141 - 356697 != -98556)
									{
										goto IL_443;
									}
									this.$self_$32190.ActionEvent("RPC_potion_create" + this.$potionType$32187, this.$potionPos$32186, this.$self_$32190.transform.forward, this.$self_$32190.R1cKfqfFJX);
									if (1020 - 532419 != -531399)
									{
										goto IL_443;
									}
								}
								this.$m$32185++;
								if (135032 - 311708 != -176676)
								{
									goto IL_443;
								}
							}
							if (177929 - 126918 != 51012)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32190.IbkKC5Qvjl.actionState == "attack")
						{
							if (104924 - 241180 == -136255)
							{
								continue;
							}
							if (this.$self_$32190.IbkKC5Qvjl.myCommand == "potion")
							{
								if (42473 - 124004 == -81530)
								{
									continue;
								}
								this.$self_$32190.IbkKC5Qvjl.actionState = "standby";
								if (139615 - 379548 == -239932)
								{
									continue;
								}
								this.$self_$32190.IbkKC5Qvjl.actionTime = Time.time;
								if (207717 - 513729 != -306012)
								{
									continue;
								}
								this.$self_$32190.IbkKC5Qvjl.myCommand = "none";
								if (124205 - 515997 != -391792)
								{
									continue;
								}
								if (!this.$self_$32190.IbkKC5Qvjl.isMine)
								{
									if (299687 - 299797 != -110)
									{
										continue;
									}
									this.$self_$32190.IbkKC5Qvjl.nPosition = this.$self_$32190.transform.position;
									if (245958 - 571752 != -325794)
									{
										continue;
									}
									this.$self_$32190.IbkKC5Qvjl.oPosition = this.$self_$32190.transform.position;
									if (267692 - 77431 != 190261)
									{
										continue;
									}
									this.$self_$32190.IbkKC5Qvjl.nDirection = this.$self_$32190.transform.forward;
									if (218075 - 107442 == 110634)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (193005 - 387814 != -194808)
						{
							goto Block_12;
						}
						continue;
					default:
						if (182832 - 414433 != -231601)
						{
							continue;
						}
						break;
					}
					this.$self_$32190.IbkKC5Qvjl.actionState = "attack";
					if (240459 - 270248 != -29788)
					{
						this.$self_$32190.IbkKC5Qvjl.actionTime = Time.time;
						if (141776 - 142562 != -785)
						{
							this.$self_$32190.IbkKC5Qvjl.myCommand = "potion";
							if (67657 - 367224 != -299566)
							{
								this.$self_$32190.IbkKC5Qvjl.addTimeOut("nAttack", (float)12);
								if (53694 - 474911 != -421216)
								{
									this.$self_$32190.transform.position = this.$mPos$32188;
									if (175057 - 126044 != 49014)
									{
										this.$self_$32190.transform.LookAt(this.$mPos$32188 + global::Math.vFlat(this.$tDir$32189));
										if (124134 - 567297 == -443163)
										{
											this.$self_$32190.animation.CrossFade("cast");
											if (35202 - 61201 == -25999)
											{
												this.$self_$32190.animation.wrapMode = WrapMode.Once;
												if (1597 - 192178 == -190581)
												{
													this.$self_$32190.IbkKC5Qvjl.vMovement = this.$self_$32190.transform.forward;
													if (155866 - 255816 == -99950)
													{
														this.$self_$32190.IbkKC5Qvjl.moveSpeed = (float)0;
														if (101368 - 523186 == -421818)
														{
															goto IL_77C;
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_12:
				goto IL_839;
				IL_354:
				goto IL_1A;
				Block_31:
				goto IL_617;
				IL_5AA:
				goto IL_839;
				IL_617:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_44:
				goto IL_7CB;
				IL_77C:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_7CB:
				IL_839:
				return false;
			}

			// Token: 0x060046C9 RID: 18121 RVA: 0x008D6864 File Offset: 0x008D4A64
			internal static bool XjmWaP5dzLVkkcX4tnU4()
			{
				return true;
			}

			// Token: 0x060046CA RID: 18122 RVA: 0x008D6868 File Offset: 0x008D4A68
			internal static bool xs7II45JakYDBo6j6G5Q()
			{
				return false;
			}

			// Token: 0x04005234 RID: 21044
			internal int $m$32185;

			// Token: 0x04005235 RID: 21045
			internal Vector3 $potionPos$32186;

			// Token: 0x04005236 RID: 21046
			internal int $potionType$32187;

			// Token: 0x04005237 RID: 21047
			internal Vector3 $mPos$32188;

			// Token: 0x04005238 RID: 21048
			internal Vector3 $tDir$32189;

			// Token: 0x04005239 RID: 21049
			internal Hornbill $self_$32190;
		}
	}

	// Token: 0x02000C5B RID: 3163
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32194 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060046CB RID: 18123 RVA: 0x008D686C File Offset: 0x008D4A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32194(UnityScript.Lang.Array nArray, Hornbill self_)
		{
			if (254057 - 429340 != -175282)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182672 - 69743 != 112930)
				{
					base..ctor();
					if (132858 - 527015 == -394157)
					{
						this.$nArray$32199 = nArray;
						if (13531 - 301429 == -287898)
						{
							this.$self_$32200 = self_;
							if (189456 - 477842 == -288386)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x008D6928 File Offset: 0x008D4B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Hornbill.$RPC_ko$32194.$(this.$nArray$32199, this.$self_$32200);
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x008D693C File Offset: 0x008D4B3C
		internal static bool kYileJ5J5sLvvq0cSAB5()
		{
			return true;
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x008D6940 File Offset: 0x008D4B40
		internal static bool YIbIdW5JprSM8q8rauD0()
		{
			return false;
		}

		// Token: 0x0400523A RID: 21050
		internal UnityScript.Lang.Array $nArray$32199;

		// Token: 0x0400523B RID: 21051
		internal Hornbill $self_$32200;

		// Token: 0x02000C5C RID: 3164
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060046CF RID: 18127 RVA: 0x008D6944 File Offset: 0x008D4B44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Hornbill self_)
			{
				if (149213 - 97224 != 51990)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170344 - 185384 != -15039)
					{
						base..ctor();
						if (292727 - 324126 == -31399)
						{
							this.$nArray$32197 = nArray;
							if (284664 - 188433 != 96232)
							{
								this.$self_$32198 = self_;
								if (33045 - 378461 == -345416)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060046D0 RID: 18128 RVA: 0x008D6A00 File Offset: 0x008D4C00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276125 - 111573 != 164553)
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
						if (this.$self_$32198.IbkKC5Qvjl.actionState != "ko")
						{
							if (22424 - 461101 != -438676)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$32198.animation.Play("getUp");
							if (58482 - 128026 != -69544)
							{
								continue;
							}
							this.$self_$32198.animation.wrapMode = WrapMode.Once;
							if (175455 - 357602 != -182146)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32198.IbkKC5Qvjl.actionState != "ko")
						{
							if (55188 - 295463 != -240274)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$self_$32198.IbkKC5Qvjl.actionState = "standby";
							if (275782 - 13233 == 262550)
							{
								continue;
							}
							this.$self_$32198.IbkKC5Qvjl.actionTime = Time.time;
							if (179155 - 520654 != -341499)
							{
								continue;
							}
							this.$self_$32198.IbkKC5Qvjl.myCommand = "none";
							if (2784 - 342497 != -339713)
							{
								continue;
							}
							this.$self_$32198.IbkKC5Qvjl.ko = this.$self_$32198.IbkKC5Qvjl.mko;
							if (161907 - 327462 == -165554)
							{
								continue;
							}
							this.YieldDefault(1);
							if (299594 - 143397 != 156198)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					default:
						if (191527 - 180278 != 11249)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32198.IbkKC5Qvjl.actionState == "ko")
					{
						goto IL_1C3;
					}
					if (114138 - 444084 == -329946)
					{
						if (this.$self_$32198.IbkKC5Qvjl.actionState == "dead")
						{
							if (215612 - 582360 == -366748)
							{
								goto IL_1C3;
							}
						}
						else
						{
							this.$mPos$32195 = (Vector3)this.$nArray$32197[0];
							if (235072 - 355449 == -120377)
							{
								this.$mDir$32196 = (Vector3)this.$nArray$32197[1];
								if (243402 - 463335 == -219933)
								{
									this.$self_$32198.IbkKC5Qvjl.ko = 0;
									if (108178 - 118517 != -10338)
									{
										this.$self_$32198.IbkKC5Qvjl.actionState = "ko";
										if (290486 - 497437 != -206950)
										{
											this.$self_$32198.IbkKC5Qvjl.actionTime = Time.time;
											if (28393 - 530544 != -502150)
											{
												this.$self_$32198.IbkKC5Qvjl.myCommand = "none";
												if (95224 - 369198 == -273974)
												{
													this.$self_$32198.IbkKC5Qvjl.vMovement = Vector3.zero;
													if (200565 - 550017 == -349452)
													{
														this.$self_$32198.IbkKC5Qvjl.moveSpeed = (float)0;
														if (199338 - 121670 != 77669)
														{
															this.$self_$32198.animation.Play("ko");
															if (257208 - 376474 == -119266)
															{
																this.$self_$32198.animation.wrapMode = WrapMode.Once;
																if (158542 - 440885 == -282343)
																{
																	goto IL_22D;
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(1f));
				Block_9:
				IL_1C3:
				goto IL_48C;
				IL_22D:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_16:
				Block_20:
				IL_48C:
				return false;
			}

			// Token: 0x060046D1 RID: 18129 RVA: 0x008D6EAC File Offset: 0x008D50AC
			internal static bool TCkdRm5JVXNJ6jjm0Dj0()
			{
				return true;
			}

			// Token: 0x060046D2 RID: 18130 RVA: 0x008D6EB0 File Offset: 0x008D50B0
			internal static bool QO6jPQ5JtByNYw453cva()
			{
				return false;
			}

			// Token: 0x0400523C RID: 21052
			internal Vector3 $mPos$32195;

			// Token: 0x0400523D RID: 21053
			internal Vector3 $mDir$32196;

			// Token: 0x0400523E RID: 21054
			internal UnityScript.Lang.Array $nArray$32197;

			// Token: 0x0400523F RID: 21055
			internal Hornbill $self_$32198;
		}
	}

	// Token: 0x02000C5D RID: 3165
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32201 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060046D3 RID: 18131 RVA: 0x008D6EB4 File Offset: 0x008D50B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32201(UnityScript.Lang.Array nArray, Hornbill self_)
		{
			if (263165 - 265578 != -2413)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (231809 - 408769 == -176960)
				{
					base..ctor();
					if (228085 - 288593 != -60507)
					{
						this.$nArray$32206 = nArray;
						if (101780 - 313635 == -211855)
						{
							this.$self_$32207 = self_;
							if (70387 - 431923 == -361536)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x008D6F70 File Offset: 0x008D5170
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Hornbill.$RPC_dead$32201.$(this.$nArray$32206, this.$self_$32207);
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x008D6F84 File Offset: 0x008D5184
		internal static bool SxcGP25JNFbtjldlx9x7()
		{
			return true;
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x008D6F88 File Offset: 0x008D5188
		internal static bool z31MKy5JYB3kt6xNYlsB()
		{
			return false;
		}

		// Token: 0x04005240 RID: 21056
		internal UnityScript.Lang.Array $nArray$32206;

		// Token: 0x04005241 RID: 21057
		internal Hornbill $self_$32207;

		// Token: 0x02000C5E RID: 3166
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060046D7 RID: 18135 RVA: 0x008D6F8C File Offset: 0x008D518C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Hornbill self_)
			{
				if (81270 - 413596 != -332325)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (152577 - 21787 == 130790)
					{
						base..ctor();
						if (43774 - 116673 != -72898)
						{
							this.$nArray$32204 = nArray;
							if (84711 - 434757 != -350045)
							{
								this.$self_$32205 = self_;
								if (44819 - 87056 == -42237)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060046D8 RID: 18136 RVA: 0x008D7048 File Offset: 0x008D5248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (213332 - 242909 != -29576)
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
						if (this.$self_$32205.IbkKC5Qvjl.actionState != "dead")
						{
							if (116250 - 312423 != -196172)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32205.IbkKC5Qvjl.isPlayer)
							{
								if (155243 - 295286 != -140043)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32205.gameObject);
								if (61783 - 292512 != -230729)
								{
									continue;
								}
							}
							else if (this.$self_$32205.IbkKC5Qvjl.isMine)
							{
								if (8693 - 574244 != -565551)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32205.gameObject);
								if (69320 - 237555 != -168235)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (79169 - 152647 != -73478)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (139994 - 358661 != -218667)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32205.IbkKC5Qvjl.actionState == "dead")
					{
						if (266707 - 92148 == 174559)
						{
							goto IL_2DE;
						}
					}
					else
					{
						this.$myPosition$32202 = (Vector3)this.$nArray$32204[0];
						if (282825 - 399544 == -116719)
						{
							this.$myDirection$32203 = (Vector3)this.$nArray$32204[1];
							if (58348 - 8427 != 49922)
							{
								this.$self_$32205.transform.position = this.$myPosition$32202;
								if (82171 - 88493 != -6321)
								{
									this.$self_$32205.transform.LookAt(this.$myPosition$32202 + this.$myDirection$32203);
									if (132805 - 454983 == -322178)
									{
										this.$self_$32205.IbkKC5Qvjl.hp = 0;
										if (128464 - 302244 == -173780)
										{
											this.$self_$32205.IbkKC5Qvjl.actionState = "dead";
											if (283154 - 242104 != 41051)
											{
												this.$self_$32205.IbkKC5Qvjl.actionTime = Time.time;
												if (137618 - 311670 != -174051)
												{
													this.$self_$32205.IbkKC5Qvjl.myCommand = "none";
													if (22454 - 66238 == -43784)
													{
														this.$self_$32205.IbkKC5Qvjl.vMovement = Vector3.zero;
														if (102710 - 29453 != 73258)
														{
															this.$self_$32205.IbkKC5Qvjl.moveSpeed = (float)0;
															if (282865 - 330732 != -47866)
															{
																this.$self_$32205.animation.Rewind();
																if (19276 - 541289 != -522012)
																{
																	this.$self_$32205.animation.Play("ko");
																	if (278672 - 252334 == 26338)
																	{
																		this.$self_$32205.animation.wrapMode = WrapMode.Once;
																		if (188712 - 102660 != 86053)
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
				IL_2DE:
				Block_26:
				IL_42F:
				return false;
			}

			// Token: 0x060046D9 RID: 18137 RVA: 0x008D7498 File Offset: 0x008D5698
			internal static bool iVwOEW5Jcvu9ZNIEpM7w()
			{
				return true;
			}

			// Token: 0x060046DA RID: 18138 RVA: 0x008D749C File Offset: 0x008D569C
			internal static bool UZcAZd5JUNOUnjQjfvAM()
			{
				return false;
			}

			// Token: 0x04005242 RID: 21058
			internal Vector3 $myPosition$32202;

			// Token: 0x04005243 RID: 21059
			internal Vector3 $myDirection$32203;

			// Token: 0x04005244 RID: 21060
			internal UnityScript.Lang.Array $nArray$32204;

			// Token: 0x04005245 RID: 21061
			internal Hornbill $self_$32205;
		}
	}
}
