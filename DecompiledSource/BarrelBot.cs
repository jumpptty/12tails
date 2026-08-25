using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E85 RID: 3717
[Serializable]
public class BarrelBot : MonoBehaviour
{
	// Token: 0x06005440 RID: 21568 RVA: 0x00A3D740 File Offset: 0x00A3B940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BarrelBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005441 RID: 21569 RVA: 0x00A3D750 File Offset: 0x00A3B950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (108250 - 516075 != -407824)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (22821 - 419977 != -397155)
			{
				this.mChar.actionState = "standby";
				if (277813 - 125273 == 152540)
				{
					this.mChar.actionTime = Time.time;
					if (60200 - 199513 != -139312)
					{
						this.mChar.myCommand = "none";
						if (114337 - 401252 == -286915)
						{
							string type = this.mChar.Type;
							if (59128 - 510765 == -451637)
							{
								if (type == "BarrelBot1")
								{
									if (85256 - 515626 == -430370)
									{
										this.mChar.hp = (this.mChar.mhp = 100);
										if (9852 - 162563 != -152710)
										{
											this.mChar.atk = (this.mChar.def = 15);
											if (144639 - 121055 == 23584)
											{
												this.mChar.agi = (this.mChar.mag = (this.mChar.cha = 10));
												if (298854 - 557666 == -258812)
												{
													this.mChar.vit = (this.mChar.tal = (this.mChar.lck = 10));
													if (81616 - 355970 == -274354)
													{
														this.mChar.rangeMod = 0.9f;
														if (242096 - 377338 == -135242)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (type == "BarrelBot2")
								{
									if (163991 - 564352 != -400360)
									{
										this.mChar.hp = (this.mChar.mhp = 200);
										if (163965 - 306502 == -142537)
										{
											this.mChar.atk = (this.mChar.def = 30);
											if (246769 - 35858 != 210912)
											{
												this.mChar.agi = (this.mChar.mag = (this.mChar.cha = 10));
												if (286625 - 436965 == -150340)
												{
													this.mChar.vit = (this.mChar.tal = (this.mChar.lck = 20));
													if (40718 - 236737 == -196019)
													{
														this.mChar.rangeMod = 1f;
														if (224577 - 238567 != -13989)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (type == "BarrelBot3")
								{
									if (48638 - 322841 != -274202)
									{
										this.mChar.hp = (this.mChar.mhp = 300);
										if (224935 - 374128 == -149193)
										{
											this.mChar.atk = (this.mChar.def = 45);
											if (197691 - 358792 == -161101)
											{
												this.mChar.agi = (this.mChar.mag = (this.mChar.cha = 10));
												if (101094 - 254258 != -153163)
												{
													this.mChar.vit = (this.mChar.tal = (this.mChar.lck = 30));
													if (52803 - 209392 != -156588)
													{
														this.mChar.rangeMod = 1.1f;
														if (59216 - 239676 == -180460)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else
								{
									if (!(type == "BarrelBot4"))
									{
										break;
									}
									if (222013 - 486297 == -264284)
									{
										this.mChar.hp = (this.mChar.mhp = 400);
										if (138681 - 202887 == -64206)
										{
											this.mChar.atk = (this.mChar.def = 60);
											if (246012 - 66128 != 179885)
											{
												this.mChar.agi = (this.mChar.mag = (this.mChar.cha = 10));
												if (68330 - 356532 == -288202)
												{
													this.mChar.vit = (this.mChar.tal = (this.mChar.lck = 40));
													if (247904 - 370806 != -122901)
													{
														this.mChar.rangeMod = 1.2f;
														if (230015 - 177217 == 52798)
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

	// Token: 0x06005442 RID: 21570 RVA: 0x00A3DDB8 File Offset: 0x00A3BFB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06005443 RID: 21571 RVA: 0x00A3DDD4 File Offset: 0x00A3BFD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (65740 - 74764 != -9023)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (107482 - 396729 == -289246)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (239532 - 94665 != 144867)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_280;
					}
					if (214176 - 183899 != 30277)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (147127 - 506047 == -358919)
				{
					continue;
				}
			}
			IL_280:
			if (this.mChar.hp <= 0)
			{
				if (203301 - 425265 == -221963)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (213328 - 460901 == -247572)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (24891 - 569585 != -544694)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (290097 - 34305 == 255793)
						{
							continue;
						}
						if (status != null)
						{
							if (191594 - 120416 != 71178)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (168789 - 454157 == -285367)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (81913 - 339881 != -257968)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (230375 - 417405 == -187029)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (13817 - 292069 != -278251)
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
							if (191771 - 587303 == -395531)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (193488 - 111543 == 81946)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (106516 - 71220 != 35297)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (79405 - 147531 != -68126)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.ko <= 0)
			{
				if (22142 - 159095 == -136952)
				{
					continue;
				}
				if (this.mChar.actionState != "ko")
				{
					if (228548 - 583515 != -354967)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (108587 - 393730 != -285143)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (289629 - 525335 != -235706)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (163402 - 169984 != -6582)
						{
							continue;
						}
						this.mChar.KoEvent();
						if (40799 - 504892 != -464093)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.ko = 1;
						if (49426 - 333343 != -283917)
						{
							continue;
						}
						break;
					}
				}
			}
			if (!this.isCreate)
			{
				break;
			}
			if (157734 - 467470 != -309735)
			{
				if (!this.mCreatorChar)
				{
					if (235959 - 305004 == -69045)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (83405 - 224243 == -140838)
						{
							break;
						}
					}
				}
				else
				{
					if (!this.mChar.isMine)
					{
						break;
					}
					if (243673 - 543947 == -300274)
					{
						if (this.mCreatorChar.hp > 0)
						{
							break;
						}
						if (68337 - 333290 == -264953)
						{
							if (!(this.mChar.actionState != "dead"))
							{
								break;
							}
							if (198454 - 52153 == 146301)
							{
								this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (179261 - 581981 != -402719)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (228034 - 363902 == -135868)
									{
										this.mChar.DeadEvent();
										if (95410 - 87519 != 7892)
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

	// Token: 0x06005444 RID: 21572 RVA: 0x00A3E41C File Offset: 0x00A3C61C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (221796 - 91470 != 130326)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (187489 - 4977 == 182512)
			{
				float runSpeed = this.mChar.runSpeed;
				if (34832 - 253703 != -218870)
				{
					Vector3 a = default(Vector3);
					if (121013 - 413742 == -292729)
					{
						Vector3 vector = Vector3.zero;
						if (222141 - 460931 != -238789)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (8241 - 466416 != -458174)
							{
								if (this.mChar.isMine)
								{
									if (102727 - 45999 == 56729)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (120014 - 284046 != -164032)
									{
										continue;
									}
									a.y = (float)0;
									if (231286 - 547695 == -316408)
									{
										continue;
									}
									a = a.normalized;
									if (258921 - 565478 == -306556)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (62737 - 288358 == -225620)
									{
										continue;
									}
									vector = vector.normalized;
									if (90975 - 116498 != -25523)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (242389 - 329089 == -86699)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (181152 - 532435 == -351282)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (289638 - 465065 == -175426)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (2159 - 418135 == -415975)
										{
											continue;
										}
										this.animation.Play("run");
										if (90375 - 568862 == -478486)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (247540 - 247725 == -184)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (49035 - 85313 == -36277)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (58674 - 385265 != -326591)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (149048 - 451452 != -302404)
											{
												continue;
											}
											num = (float)0;
											if (262923 - 73255 == 189669)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (101451 - 198559 == -97107)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (63408 - 570903 == -507494)
										{
											continue;
										}
									}
								}
								else
								{
									Vector3 vector2 = this.mChar.nPosition - this.transform.position;
									if (215778 - 191583 == 24196)
									{
										continue;
									}
									if (vector2.magnitude > runSpeed)
									{
										if (101528 - 529829 == -428300)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (126131 - 84635 == 41497)
										{
											continue;
										}
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (298463 - 361438 != -62975)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (104215 - 87509 == 16707)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (117695 - 179463 == -61767)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (120111 - 275623 != -155512)
											{
												continue;
											}
											num = (float)0;
											if (140851 - 551035 != -410184)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (52835 - 522453 == -469617)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (158697 - 64859 != 93838)
											{
												continue;
											}
											vector = lhs.normalized;
											if (5575 - 518613 != -513038)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector);
											if (102791 - 157748 != -54957)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (155253 - 251508 != -96255)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (54172 - 277980 == -223807)
											{
												continue;
											}
										}
										else
										{
											vector = this.transform.forward;
											if (136775 - 323653 == -186877)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (219917 - 279106 == -59188)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (13535 - 592502 == -578966)
											{
												continue;
											}
										}
									}
								}
								this.mChar.vMovement = vector;
								if (167103 - 530536 != -363432)
								{
									this.mChar.moveSpeed = num;
									if (93710 - 4434 != 89277)
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

	// Token: 0x06005445 RID: 21573 RVA: 0x00A3EB60 File Offset: 0x00A3CD60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (93064 - 309002 != -215937)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (260160 - 451888 != -191727)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (120472 - 414870 == -294398)
				{
					if (34413 - 56203 != -21789)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (232086 - 122105 != 109981)
							{
								continue;
							}
							v = 1;
							if (36611 - 432469 != -395858)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (288027 - 61228 == 226800)
							{
								continue;
							}
							v = -1;
							if (20307 - 375417 != -355110)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_punch")
						{
							if (253991 - 247291 == 6701)
							{
								continue;
							}
							v = 11;
							if (255016 - 551106 != -296090)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_punch_hit")
						{
							if (39910 - 42647 != -2737)
							{
								continue;
							}
							v = -11;
							if (248607 - 310992 != -62385)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_hammer")
						{
							if (105749 - 393461 == -287711)
							{
								continue;
							}
							v = 21;
							if (145072 - 475695 != -330623)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_hammer_hit")
						{
							if (155163 - 380924 == -225760)
							{
								continue;
							}
							v = -21;
							if (106697 - 374886 != -268189)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_chopper")
						{
							if (159763 - 429532 == -269768)
							{
								continue;
							}
							v = 31;
							if (109571 - 269620 != -160049)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_chopper_hit")
						{
							if (121658 - 140556 != -18898)
							{
								continue;
							}
							v = -31;
							if (11027 - 549659 == -538631)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_missile")
						{
							if (133434 - 147366 == -13931)
							{
								continue;
							}
							v = 41;
							if (150233 - 60244 != 89989)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_missile_fire")
						{
							if (131871 - 245446 == -113574)
							{
								continue;
							}
							v = 42;
							if (68769 - 280209 != -211440)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_missile_hit")
						{
							if (249076 - 354900 != -105824)
							{
								continue;
							}
							v = -41;
							if (47715 - 375244 != -327529)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_drill")
						{
							if (52933 - 435247 == -382313)
							{
								continue;
							}
							v = 51;
							if (105911 - 100142 != 5769)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_drill_hit")
						{
							if (218209 - 542531 == -324321)
							{
								continue;
							}
							v = -51;
							if (298897 - 528197 == -229299)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cannon")
						{
							if (156273 - 8003 != 148270)
							{
								continue;
							}
							v = 61;
							if (137066 - 83995 == 53072)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cannon_fire")
						{
							if (115802 - 381039 == -265236)
							{
								continue;
							}
							v = 62;
							if (7948 - 545563 == -537614)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cannon_hit")
						{
							if (158241 - 458716 != -300475)
							{
								continue;
							}
							v = -61;
							if (10229 - 480972 == -470742)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Command: " + ActionName);
							if (172837 - 185162 != -12325)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (114162 - 47740 != 66423)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (245561 - 549847 != -304285)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (40839 - 410830 != -369990)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (39838 - 484790 == -444952)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (140943 - 410986 != -270042)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (60706 - 243730 == -183024)
											{
												Hashtable hashtable = new Hashtable();
												if (270698 - 432406 != -161707)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (152424 - 344843 != -192418)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (223395 - 416212 == -192817)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (242763 - 288519 != -45755)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (286041 - 284487 != 1555)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (80134 - 14029 == 66105)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (17903 - 168308 != -150404)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (12915 - 141264 == -128349)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (146243 - 215684 != -69440)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (126831 - 177856 != -51024)
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

	// Token: 0x06005446 RID: 21574 RVA: 0x00A3F408 File Offset: 0x00A3D608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (223177 - 171399 != 51779)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (148602 - 184888 != -36285)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (245387 - 512691 != -267303)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (263966 - 74041 == 189925)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (189164 - 157596 != 31569)
						{
							int num3 = num;
							if (244542 - 105602 == 138940)
							{
								if (num3 == 1)
								{
									if (253085 - 257920 == -4835)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (60264 - 222856 != -162591)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (46575 - 291956 != -245380)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (81277 - 353989 == -272712)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (148166 - 532857 != -384690)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (16870 - 23577 != -6706)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (80365 - 240933 != -160567)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (16449 - 548563 != -532113)
										{
											this.StartCoroutine_Auto(this.RPC_punch(vector, vector2, num2));
											if (11696 - 177687 == -165991)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (292178 - 94437 == 197741)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (28919 - 288397 == -259478)
										{
											this.RPC_punch_hit(vector, vector2, num2);
											if (274485 - 356893 != -82407)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (233192 - 595702 == -362510)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (268716 - 481672 != -212955)
										{
											this.StartCoroutine_Auto(this.RPC_hammer(vector, vector2, num2));
											if (39163 - 424926 != -385762)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (193916 - 524449 != -330532)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (237624 - 378705 != -141080)
										{
											this.RPC_hammer_hit(vector, vector2, num2);
											if (222649 - 207946 != 14704)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (261763 - 337804 != -76040)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (286305 - 495849 != -209543)
										{
											this.StartCoroutine_Auto(this.RPC_chopper(vector, vector2, num2));
											if (98099 - 87066 != 11034)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -31)
								{
									if (236248 - 100008 == 136240)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (203762 - 410590 != -206827)
										{
											this.RPC_chopper_hit(vector, vector2, num2);
											if (229151 - 252047 == -22896)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (50086 - 416106 == -366020)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (70821 - 590078 == -519257)
										{
											this.StartCoroutine_Auto(this.RPC_missile(vector, vector2, num2));
											if (95747 - 52978 != 42770)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 42)
								{
									if (96225 - 379648 == -283423)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (175062 - 77638 != 97425)
										{
											this.RPC_missile_fire(vector, vector2, num2);
											if (214464 - 124914 != 89551)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -41)
								{
									if (205556 - 26080 != 179477)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (39513 - 476859 != -437345)
										{
											this.RPC_missile_hit(vector, vector2, num2);
											if (228041 - 219661 == 8380)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 51)
								{
									if (20090 - 38365 != -18274)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (287518 - 456826 == -169308)
										{
											this.StartCoroutine_Auto(this.RPC_drill(vector, vector2, num2));
											if (240942 - 571116 != -330173)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -51)
								{
									if (165325 - 355419 != -190093)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (231214 - 505921 != -274706)
										{
											this.RPC_drill_hit(vector, vector2, num2);
											if (182449 - 120105 != 62345)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 61)
								{
									if (106796 - 160257 != -53460)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (31881 - 189320 == -157439)
										{
											this.StartCoroutine_Auto(this.RPC_cannon(vector, vector2, num2));
											if (138958 - 468809 != -329850)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 62)
								{
									if (250266 - 6597 == 243669)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (255955 - 270470 == -14515)
										{
											this.RPC_cannon_fire(vector, vector2, num2);
											if (269235 - 253216 == 16019)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -61)
								{
									if (41107 - 141610 != -100502)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (79477 - 453950 != -374472)
										{
											this.RPC_cannon_hit(vector, vector2, num2);
											if (127181 - 447505 == -320324)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 71)
								{
									if (7982 - 188341 != -180358)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (264965 - 361523 == -96558)
										{
											this.StartCoroutine_Auto(this.RPC_cannonForm(vector, vector2, num2));
											if (195015 - 342124 != -147108)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (138018 - 372472 != -234453)
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

	// Token: 0x06005447 RID: 21575 RVA: 0x00A3FDA8 File Offset: 0x00A3DFA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (264750 - 466392 != -201642)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (238866 - 280752 == -41886)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (285444 - 338576 != -53131)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (180359 - 472055 == -291696)
					{
						Vector3 normalized = vector.normalized;
						if (175679 - 179610 == -3931)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (264836 - 136534 == 128302)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (220218 - 397786 == -177567)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (234128 - 89852 != 144276)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("missile") == (float)0)
								{
									if (30059 - 334289 != -304229)
									{
										this.StartCoroutine_Auto(this.RPC_missile(this.transform.position, normalized, 0));
										if (215970 - 350348 != -134377)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (82754 - 382417 != -299662)
											{
												this.ActionEvent("RPC_missile", this.transform.position, normalized, 0);
												if (183658 - 100260 == 83398)
												{
													break;
												}
											}
										}
									}
								}
								else if (this.mChar.isTimeOut("hammer") == (float)0)
								{
									if (142835 - 79393 == 63442)
									{
										this.StartCoroutine_Auto(this.RPC_hammer(this.transform.position, normalized, 0));
										if (110498 - 115813 != -5314)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (127820 - 235617 == -107797)
											{
												this.ActionEvent("RPC_hammer", this.transform.position, normalized, 0);
												if (291940 - 9253 != 282688)
												{
													break;
												}
											}
										}
									}
								}
								else if (this.mChar.isTimeOut("punch") == (float)0)
								{
									if (187568 - 381441 != -193872)
									{
										this.StartCoroutine_Auto(this.RPC_punch(this.transform.position, normalized, 0));
										if (158153 - 190861 != -32707)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (185224 - 414883 != -229658)
											{
												this.ActionEvent("RPC_punch", this.transform.position, normalized, 0);
												if (44062 - 479386 == -435324)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (38213 - 472641 != -434427)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (6960 - 590435 != -583474)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (239931 - 175101 != 64831)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (200887 - 320802 == -119915)
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

	// Token: 0x06005448 RID: 21576 RVA: 0x00A40234 File Offset: 0x00A3E434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (178518 - 251294 != -72776)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (293334 - 480331 == -186997)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (47403 - 406567 != -359163)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (77780 - 563725 == -485945)
					{
						Vector3 normalized = vector.normalized;
						if (83217 - 595372 == -512155)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (112591 - 148883 != -36291)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (179930 - 208516 != -28586)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (272581 - 83601 == 188981)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("chopper") != (float)0)
								{
									if (123679 - 196775 == -73096)
									{
										Camera.main.SendMessage("newGameMessage", "Chopper is not ready");
										if (142397 - 152626 != -10228)
										{
											break;
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_chopper(this.transform.position, normalized, 0));
									if (121413 - 16880 == 104533)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (36164 - 376822 == -340658)
										{
											this.ActionEvent("RPC_chopper", this.transform.position, normalized, 0);
											if (271211 - 65216 != 205996)
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

	// Token: 0x06005449 RID: 21577 RVA: 0x00A404B4 File Offset: 0x00A3E6B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		if (80289 - 502338 != -422049)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (92023 - 41250 == 50773)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (18347 - 280809 != -262461)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (286563 - 439112 == -152549)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (279876 - 220844 == 59032)
						{
							if (!(this.mChar.actionState == "attack"))
							{
								break;
							}
							if (226812 - 333280 != -106467)
							{
								if (!(this.mChar.myCommand == "cAttack1"))
								{
									break;
								}
								if (252845 - 171335 != 81511)
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

	// Token: 0x0600544A RID: 21578 RVA: 0x00A40628 File Offset: 0x00A3E828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BarrelBot.$RPC_nAttack$34337(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600544B RID: 21579 RVA: 0x00A40638 File Offset: 0x00A3E838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (277590 - 273352 != 4239)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (250629 - 144645 == 105984)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (292752 - 508186 != -215433)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (22547 - 262391 != -239843)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600544C RID: 21580 RVA: 0x00A406F0 File Offset: 0x00A3E8F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_punch(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BarrelBot.$RPC_punch$34351(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600544D RID: 21581 RVA: 0x00A40700 File Offset: 0x00A3E900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_punch_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.punch_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x0600544E RID: 21582 RVA: 0x00A4071C File Offset: 0x00A3E91C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_hammer(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BarrelBot.$RPC_hammer$34364(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600544F RID: 21583 RVA: 0x00A4072C File Offset: 0x00A3E92C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_hammer_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.hammer_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06005450 RID: 21584 RVA: 0x00A40748 File Offset: 0x00A3E948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_chopper(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BarrelBot.$RPC_chopper$34377(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005451 RID: 21585 RVA: 0x00A40758 File Offset: 0x00A3E958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_chopper_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.chopper_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06005452 RID: 21586 RVA: 0x00A40774 File Offset: 0x00A3E974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_missile(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BarrelBot.$RPC_missile$34392(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005453 RID: 21587 RVA: 0x00A40784 File Offset: 0x00A3E984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_missile_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (251749 - 135685 != 116065)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.missile_fire, firePos, Quaternion.LookRotation(fireDir));
			if (147048 - 129837 == 17211)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (75813 - 539454 != -463640)
				{
					projectileControl.Init(this.mChar.ActorNr);
					if (162507 - 163180 == -673)
					{
						projectileControl.life = (float)5 * this.mChar.rangeMod;
						if (121689 - 336609 == -214920)
						{
							GameObject gameObject2 = null;
							if (223756 - 232471 != -8714)
							{
								if (tID != 0)
								{
									if (292825 - 460961 == -168135)
									{
										continue;
									}
									if (tID != this.mChar.ActorNr)
									{
										if (167126 - 267187 == -100060)
										{
											continue;
										}
										object obj2;
										object obj = obj2 = PhotonClient.ActorNrList[tID];
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										gameObject2 = (GameObject)obj2;
										if (213987 - 494357 != -280370)
										{
											continue;
										}
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (139749 - 46838 != 92912)
								{
									BarrelBot_missile barrelBot_missile = (BarrelBot_missile)gameObject.GetComponent(typeof(BarrelBot_missile));
									if (215207 - 468114 == -252907)
									{
										barrelBot_missile.mTarget = gameObject2;
										if (224324 - 110805 != 113520)
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

	// Token: 0x06005454 RID: 21588 RVA: 0x00A409A0 File Offset: 0x00A3EBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_missile_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.missile_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06005455 RID: 21589 RVA: 0x00A409BC File Offset: 0x00A3EBBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_drill(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BarrelBot.$RPC_drill$34410(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005456 RID: 21590 RVA: 0x00A409CC File Offset: 0x00A3EBCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_drill_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (219 - 472553 != -472333)
		{
		}
		for (;;)
		{
			if (this.drill_hit)
			{
				if (3915 - 308340 == -304425)
				{
					UnityEngine.Object.Instantiate(this.drill_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (216909 - 3283 == 213626)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find drill_hit effect");
				if (214352 - 474912 == -260560)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005457 RID: 21591 RVA: 0x00A40A84 File Offset: 0x00A3EC84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cannon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BarrelBot.$RPC_cannon$34425(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005458 RID: 21592 RVA: 0x00A40A94 File Offset: 0x00A3EC94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cannon_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (288268 - 573559 != -285291)
		{
		}
		while (this.cannon_fire)
		{
			if (62901 - 101715 == -38814)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.cannon_fire, firePos, Quaternion.LookRotation(fireDir));
				if (153127 - 523958 != -370830)
				{
					ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
					if (20183 - 476793 == -456610)
					{
						projectileControl.Init(this.mChar.ActorNr);
						if (100129 - 330500 != -230370)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005459 RID: 21593 RVA: 0x00A40B84 File Offset: 0x00A3ED84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cannon_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (138811 - 458662 != -319850)
		{
		}
		for (;;)
		{
			IL_17B:
			if (this.cannon_hit)
			{
				if (179017 - 263551 != -84534)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.cannon_hit, hitPos, this.transform.rotation);
				if (50628 - 399050 == -348421)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (25909 - 370048 != -344138)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (225070 - 20044 != 205027)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)3, (float)4, layerMask);
					if (13157 - 414391 == -401234)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (268393 - 148657 == 119736)
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
								if (146247 - 380324 != -234077)
								{
									goto IL_17B;
								}
								this.mChar.hit(1, gameObject, Mathf.FloorToInt(1.5f * (float)this.mChar.atk), 1, 0, 0.3f * (gameObject.transform.position - this.transform.position).normalized);
								if (238009 - 503096 != -265087)
								{
									goto IL_17B;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (181987 - 300805 == -118817)
								{
									goto IL_17B;
								}
							}
							if (204718 - 251206 != -46487)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600545A RID: 21594 RVA: 0x00A40DB4 File Offset: 0x00A3EFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cannonForm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BarrelBot.$RPC_cannonForm$34435(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600545B RID: 21595 RVA: 0x00A40DC4 File Offset: 0x00A3EFC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator create(int nCreatorID)
	{
		return new BarrelBot.$create$34450(nCreatorID, this).GetEnumerator();
	}

	// Token: 0x0600545C RID: 21596 RVA: 0x00A40DD4 File Offset: 0x00A3EFD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new BarrelBot.$RPC_ko$34455(nArray, this).GetEnumerator();
	}

	// Token: 0x0600545D RID: 21597 RVA: 0x00A40DE4 File Offset: 0x00A3EFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new BarrelBot.$RPC_dead$34462(nArray, this).GetEnumerator();
	}

	// Token: 0x0600545E RID: 21598 RVA: 0x00A40DF4 File Offset: 0x00A3EFF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600545F RID: 21599 RVA: 0x00A40DF8 File Offset: 0x00A3EFF8
	internal static bool mbGXWR5sjQmy0t2uMPKg()
	{
		return true;
	}

	// Token: 0x06005460 RID: 21600 RVA: 0x00A40DFC File Offset: 0x00A3EFFC
	internal static bool tRnWeW5shtsAK1DlT2Pi()
	{
		return false;
	}

	// Token: 0x04005D4B RID: 23883
	public CharacterControl mChar;

	// Token: 0x04005D4C RID: 23884
	public int BarrelBotLv;

	// Token: 0x04005D4D RID: 23885
	public int PunchLv;

	// Token: 0x04005D4E RID: 23886
	public int HammerLv;

	// Token: 0x04005D4F RID: 23887
	public int ChopperLv;

	// Token: 0x04005D50 RID: 23888
	public int MissileLv;

	// Token: 0x04005D51 RID: 23889
	public int CannonLv;

	// Token: 0x04005D52 RID: 23890
	public int DrillLv;

	// Token: 0x04005D53 RID: 23891
	public AudioClip nAttack_fx;

	// Token: 0x04005D54 RID: 23892
	public GameObject nAttack_hit;

	// Token: 0x04005D55 RID: 23893
	public GameObject punch;

	// Token: 0x04005D56 RID: 23894
	public GameObject punch_hit;

	// Token: 0x04005D57 RID: 23895
	public GameObject hammer;

	// Token: 0x04005D58 RID: 23896
	public GameObject hammer_hit;

	// Token: 0x04005D59 RID: 23897
	public GameObject chopper;

	// Token: 0x04005D5A RID: 23898
	public GameObject chopper_startDust;

	// Token: 0x04005D5B RID: 23899
	public GameObject chopper_forwardDust;

	// Token: 0x04005D5C RID: 23900
	public GameObject chopper_hit;

	// Token: 0x04005D5D RID: 23901
	public GameObject missile_fire;

	// Token: 0x04005D5E RID: 23902
	public GameObject missile_hit;

	// Token: 0x04005D5F RID: 23903
	public GameObject drill_ring;

	// Token: 0x04005D60 RID: 23904
	public GameObject drill_hit;

	// Token: 0x04005D61 RID: 23905
	public GameObject cannon;

	// Token: 0x04005D62 RID: 23906
	public GameObject cannon_fire;

	// Token: 0x04005D63 RID: 23907
	public GameObject cannon_hit;

	// Token: 0x04005D64 RID: 23908
	public GameObject cannonForm_ring;

	// Token: 0x04005D65 RID: 23909
	public bool isCreate;

	// Token: 0x04005D66 RID: 23910
	public GameObject mCreator;

	// Token: 0x04005D67 RID: 23911
	public CharacterControl mCreatorChar;

	// Token: 0x04005D68 RID: 23912
	public AudioClip create_fx;

	// Token: 0x02000E86 RID: 3718
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34337 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005461 RID: 21601 RVA: 0x00A40E00 File Offset: 0x00A3F000
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34337(Vector3 mPos, Vector3 tDir, BarrelBot self_)
		{
			if (144876 - 67809 != 77067)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33791 - 232754 == -198963)
				{
					base..ctor();
					if (112339 - 555425 != -443085)
					{
						this.$mPos$34348 = mPos;
						if (181319 - 83055 == 98264)
						{
							this.$tDir$34349 = tDir;
							if (108500 - 23348 != 85153)
							{
								this.$self_$34350 = self_;
								if (137808 - 362947 != -225138)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x00A40EDC File Offset: 0x00A3F0DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_nAttack$34337.$(this.$mPos$34348, this.$tDir$34349, this.$self_$34350);
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x00A40EF8 File Offset: 0x00A3F0F8
		internal static bool C3EywM5ssCOuIW9gDCd5()
		{
			return true;
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x00A40EFC File Offset: 0x00A3F0FC
		internal static bool xZxuYE5s9BrMs8ynW5aF()
		{
			return false;
		}

		// Token: 0x04005D69 RID: 23913
		internal Vector3 $mPos$34348;

		// Token: 0x04005D6A RID: 23914
		internal Vector3 $tDir$34349;

		// Token: 0x04005D6B RID: 23915
		internal BarrelBot $self_$34350;

		// Token: 0x02000E87 RID: 3719
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005465 RID: 21605 RVA: 0x00A40F00 File Offset: 0x00A3F100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BarrelBot self_)
			{
				if (63855 - 171216 != -107361)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11105 - 499699 != -488593)
					{
						base..ctor();
						if (24924 - 482056 == -457132)
						{
							this.$mPos$34345 = mPos;
							if (151660 - 418481 == -266821)
							{
								this.$tDir$34346 = tDir;
								if (77637 - 353536 != -275898)
								{
									this.$self_$34347 = self_;
									if (73801 - 293855 != -220053)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005466 RID: 21606 RVA: 0x00A40FDC File Offset: 0x00A3F1DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (299492 - 434384 != -134892)
				{
				}
				for (;;)
				{
					IL_1D7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_CE1;
					case 2:
						if (this.$self_$34347.mChar.actionState != "attack")
						{
							goto IL_1A3;
						}
						if (295466 - 464202 != -168736)
						{
							continue;
						}
						if (this.$self_$34347.mChar.myCommand != "nAttack")
						{
							if (69951 - 477452 != -407500)
							{
								goto Block_20;
							}
							continue;
						}
						else if (this.$self_$34347.nAttack_fx)
						{
							if (158332 - 123751 == 34582)
							{
								continue;
							}
							this.$self_$34347.audio.PlayOneShot(this.$self_$34347.nAttack_fx);
							if (28610 - 293346 != -264735)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							Debug.LogError("Cannot find nAttack_fx effect");
							if (53118 - 235233 != -182114)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34347.mChar.actionState != "attack")
						{
							goto IL_897;
						}
						if (84304 - 576094 == -491789)
						{
							continue;
						}
						if (this.$self_$34347.mChar.myCommand != "nAttack")
						{
							if (243921 - 46545 != 197377)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$hitLayer$34338 = 130816 - (1 << this.$self_$34347.gameObject.layer);
							if (20797 - 552656 != -531859)
							{
								continue;
							}
							this.$hitList$34339 = null;
							if (151194 - 248347 == -97152)
							{
								continue;
							}
							this.$hitPos$34340 = default(Vector3);
							if (282596 - 208257 != 74339)
							{
								continue;
							}
							if (!this.$self_$34347.mChar.isMine)
							{
								goto IL_60D;
							}
							if (17076 - 484167 != -467091)
							{
								continue;
							}
							this.$hitList$34339 = Damage.FindAreaTarget(this.$self_$34347.transform.position + 0.25f * this.$self_$34347.transform.forward, 1.5f * this.$self_$34347.mChar.rangeMod, (float)3 * this.$self_$34347.mChar.rangeMod, this.$hitLayer$34338);
							if (14033 - 353197 == -339163)
							{
								continue;
							}
							this.$$iterator$9822$34342 = UnityRuntimeServices.GetEnumerator(this.$hitList$34339);
							if (246897 - 51322 != 195575)
							{
								continue;
							}
							while (this.$$iterator$9822$34342.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9822$34342.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34341 = (GameObject)obj2;
								if (29382 - 430836 == -401453)
								{
									goto IL_1D7;
								}
								if (this.$self_$34347.mChar.hit(1, this.$hitObject$34341, (int)(0.5f * (float)this.$self_$34347.mChar.atk), 1, 0, (float)2 * this.$self_$34347.transform.forward) != 0)
								{
									if (107708 - 505648 != -397940)
									{
										goto IL_1D7;
									}
									this.$hitPos$34340 = this.$hitObject$34341.collider.ClosestPointOnBounds(this.$self_$34347.transform.position + this.$self_$34347.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (24860 - 13515 != 11345)
									{
										goto IL_1D7;
									}
									UnityRuntimeServices.Update(this.$$iterator$9822$34342, this.$hitObject$34341);
									if (214217 - 47942 == 166276)
									{
										goto IL_1D7;
									}
									this.$self_$34347.RPC_nAttack_hit(this.$hitPos$34340, this.$self_$34347.transform.forward, 0);
									if (261794 - 23474 == 238321)
									{
										goto IL_1D7;
									}
									if (PhotonClient.IsInitialized())
									{
										if (132913 - 300506 != -167593)
										{
											goto IL_1D7;
										}
										this.$self_$34347.ActionEvent("RPC_nAttack_hit", this.$hitPos$34340, this.$self_$34347.transform.forward, 0);
										if (217105 - 343386 != -126281)
										{
											goto IL_1D7;
										}
									}
								}
							}
							if (193744 - 16669 != 177075)
							{
								continue;
							}
							goto IL_60D;
						}
						break;
					case 4:
						if (this.$self_$34347.mChar.actionState != "attack")
						{
							goto IL_465;
						}
						if (285258 - 580750 != -295492)
						{
							continue;
						}
						if (this.$self_$34347.mChar.myCommand != "nAttack")
						{
							if (97151 - 594772 != -497620)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34347.mChar.isMine)
							{
								goto IL_C92;
							}
							if (225765 - 402095 == -176329)
							{
								continue;
							}
							this.$hitList$34339 = Damage.FindAreaTarget(this.$self_$34347.transform.position + 0.25f * this.$self_$34347.transform.forward, 1.5f * this.$self_$34347.mChar.rangeMod, (float)3 * this.$self_$34347.mChar.rangeMod, this.$hitLayer$34338);
							if (100634 - 403623 == -302988)
							{
								continue;
							}
							this.$$iterator$9823$34344 = UnityRuntimeServices.GetEnumerator(this.$hitList$34339);
							if (99653 - 596657 == -497003)
							{
								continue;
							}
							while (this.$$iterator$9823$34344.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9823$34344.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$34343 = (GameObject)obj4;
								if (240286 - 497673 != -257387)
								{
									goto IL_1D7;
								}
								if (this.$self_$34347.mChar.hit(1, this.$hitObject$34343, (int)(0.5f * (float)this.$self_$34347.mChar.atk), 1, 0, (float)2 * this.$self_$34347.transform.forward) != 0)
								{
									if (233660 - 188547 != 45113)
									{
										goto IL_1D7;
									}
									this.$hitPos$34340 = this.$hitObject$34343.collider.ClosestPointOnBounds(this.$self_$34347.transform.position + this.$self_$34347.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (84353 - 374321 == -289967)
									{
										goto IL_1D7;
									}
									UnityRuntimeServices.Update(this.$$iterator$9823$34344, this.$hitObject$34343);
									if (15074 - 339231 == -324156)
									{
										goto IL_1D7;
									}
									this.$self_$34347.RPC_nAttack_hit(this.$hitPos$34340, this.$self_$34347.transform.forward, 0);
									if (192532 - 150014 != 42518)
									{
										goto IL_1D7;
									}
									if (PhotonClient.IsInitialized())
									{
										if (67554 - 466106 == -398551)
										{
											goto IL_1D7;
										}
										this.$self_$34347.ActionEvent("RPC_nAttack_hit", this.$hitPos$34340, this.$self_$34347.transform.forward, 0);
										if (56172 - 138268 != -82096)
										{
											goto IL_1D7;
										}
									}
								}
							}
							if (13889 - 218240 != -204350)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$34347.mChar.actionState == "attack")
						{
							if (174738 - 179023 != -4285)
							{
								continue;
							}
							if (this.$self_$34347.mChar.myCommand == "nAttack")
							{
								if (204127 - 512187 != -308060)
								{
									continue;
								}
								this.$self_$34347.mChar.actionState = "standby";
								if (97672 - 297967 != -200295)
								{
									continue;
								}
								this.$self_$34347.mChar.actionTime = Time.time;
								if (284124 - 241798 != 42326)
								{
									continue;
								}
								this.$self_$34347.mChar.myCommand = "none";
								if (165930 - 523946 == -358015)
								{
									continue;
								}
								if (!this.$self_$34347.mChar.isMine)
								{
									if (1982 - 121780 != -119798)
									{
										continue;
									}
									this.$self_$34347.mChar.nPosition = this.$self_$34347.transform.position;
									if (289514 - 295777 != -6263)
									{
										continue;
									}
									this.$self_$34347.mChar.oPosition = this.$self_$34347.transform.position;
									if (220063 - 93646 != 126417)
									{
										continue;
									}
									this.$self_$34347.mChar.nDirection = this.$self_$34347.transform.forward;
									if (123700 - 374126 != -250426)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (162211 - 350889 != -188677)
						{
							goto Block_63;
						}
						continue;
					default:
						if (70141 - 179354 == -109212)
						{
							continue;
						}
						break;
					}
					this.$self_$34347.mChar.actionState = "attack";
					if (9789 - 543082 != -533292)
					{
						this.$self_$34347.mChar.actionTime = Time.time;
						if (159318 - 217968 == -58650)
						{
							this.$self_$34347.mChar.myCommand = "nAttack";
							if (178033 - 332428 != -154394)
							{
								this.$self_$34347.mChar.addTimeOut("nAttack", (float)3);
								if (198373 - 226227 != -27853)
								{
									this.$self_$34347.transform.position = this.$mPos$34345;
									if (74894 - 407190 != -332295)
									{
										this.$self_$34347.transform.LookAt(this.$mPos$34345 + global::Math.vFlat(this.$tDir$34346));
										if (63155 - 182230 == -119075)
										{
											this.$self_$34347.animation.Play("nAttack");
											if (204396 - 448267 != -243870)
											{
												this.$self_$34347.animation.wrapMode = WrapMode.Once;
												if (269382 - 43151 == 226231)
												{
													this.$self_$34347.mChar.vMovement = this.$self_$34347.transform.forward;
													if (269994 - 581855 == -311861)
													{
														this.$self_$34347.mChar.moveSpeed = (float)0;
														if (286348 - 135820 == 150528)
														{
															goto IL_726;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_53:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_8:
				IL_1A3:
				Block_20:
				IL_465:
				Block_31:
				goto IL_897;
				IL_60D:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_41:
				goto IL_53;
				IL_726:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_49:
				goto IL_C92;
				IL_897:
				goto IL_CE1;
				Block_59:
				goto IL_53;
				Block_63:
				goto IL_CE1;
				IL_C92:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_CE1:
				return false;
			}

			// Token: 0x06005467 RID: 21607 RVA: 0x00A41CDC File Offset: 0x00A3FEDC
			internal static bool srQJeo5s1ecLogoIODOW()
			{
				return true;
			}

			// Token: 0x06005468 RID: 21608 RVA: 0x00A41CE0 File Offset: 0x00A3FEE0
			internal static bool qMXtqX5s4QtGMxfRnvrX()
			{
				return false;
			}

			// Token: 0x04005D6C RID: 23916
			internal int $hitLayer$34338;

			// Token: 0x04005D6D RID: 23917
			internal UnityScript.Lang.Array $hitList$34339;

			// Token: 0x04005D6E RID: 23918
			internal Vector3 $hitPos$34340;

			// Token: 0x04005D6F RID: 23919
			internal GameObject $hitObject$34341;

			// Token: 0x04005D70 RID: 23920
			internal IEnumerator $$iterator$9822$34342;

			// Token: 0x04005D71 RID: 23921
			internal GameObject $hitObject$34343;

			// Token: 0x04005D72 RID: 23922
			internal IEnumerator $$iterator$9823$34344;

			// Token: 0x04005D73 RID: 23923
			internal Vector3 $mPos$34345;

			// Token: 0x04005D74 RID: 23924
			internal Vector3 $tDir$34346;

			// Token: 0x04005D75 RID: 23925
			internal BarrelBot $self_$34347;
		}
	}

	// Token: 0x02000E88 RID: 3720
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_punch$34351 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005469 RID: 21609 RVA: 0x00A41CE4 File Offset: 0x00A3FEE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_punch$34351(Vector3 mPos, Vector3 tDir, BarrelBot self_)
		{
			if (212046 - 413336 != -201290)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121523 - 156263 != -34739)
				{
					base..ctor();
					if (26263 - 549906 != -523642)
					{
						this.$mPos$34361 = mPos;
						if (127062 - 115778 == 11284)
						{
							this.$tDir$34362 = tDir;
							if (220014 - 447923 == -227909)
							{
								this.$self_$34363 = self_;
								if (119259 - 94482 == 24777)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x00A41DC0 File Offset: 0x00A3FFC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_punch$34351.$(this.$mPos$34361, this.$tDir$34362, this.$self_$34363);
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00A41DDC File Offset: 0x00A3FFDC
		internal static bool e2ORuW5szMd3jIS5R82Z()
		{
			return true;
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00A41DE0 File Offset: 0x00A3FFE0
		internal static bool iA3oYp59apNLyhHTQ0Gj()
		{
			return false;
		}

		// Token: 0x04005D76 RID: 23926
		internal Vector3 $mPos$34361;

		// Token: 0x04005D77 RID: 23927
		internal Vector3 $tDir$34362;

		// Token: 0x04005D78 RID: 23928
		internal BarrelBot $self_$34363;

		// Token: 0x02000E89 RID: 3721
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600546D RID: 21613 RVA: 0x00A41DE4 File Offset: 0x00A3FFE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BarrelBot self_)
			{
				if (241664 - 599282 != -357617)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63075 - 132914 == -69839)
					{
						base..ctor();
						if (239196 - 228216 != 10981)
						{
							this.$mPos$34358 = mPos;
							if (173213 - 425736 == -252523)
							{
								this.$tDir$34359 = tDir;
								if (5003 - 560545 != -555541)
								{
									this.$self_$34360 = self_;
									if (189955 - 336313 != -146357)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600546E RID: 21614 RVA: 0x00A41EC0 File Offset: 0x00A400C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221248 - 456456 != -235207)
				{
				}
				for (;;)
				{
					IL_1B7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_978;
					case 2:
						if (this.$self_$34360.mChar.actionState != "attack")
						{
							goto IL_925;
						}
						if (286995 - 404459 != -117464)
						{
							continue;
						}
						if (this.$self_$34360.mChar.myCommand != "punch")
						{
							if (153528 - 183045 != -29516)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$34360.mChar.moveSpeed = (float)0;
							if (233141 - 193010 == 40132)
							{
								continue;
							}
							this.$hitLayer$34353 = 130816 - (1 << this.$self_$34360.gameObject.layer);
							if (270226 - 423809 != -153583)
							{
								continue;
							}
							this.$hitList$34354 = null;
							if (72292 - 235583 == -163290)
							{
								continue;
							}
							this.$hitPos$34355 = default(Vector3);
							if (291215 - 151859 == 139357)
							{
								continue;
							}
							if (!this.$self_$34360.mChar.isMine)
							{
								goto IL_454;
							}
							if (266658 - 69778 == 196881)
							{
								continue;
							}
							this.$hitList$34354 = Damage.FindRecTarget(this.$self_$34360.transform.position, this.$self_$34360.transform.forward, (float)1 * this.$self_$34360.mChar.rangeMod, (float)1 * this.$self_$34360.mChar.rangeMod, 3.5f * this.$self_$34360.mChar.rangeMod, (float)3 * this.$self_$34360.mChar.rangeMod, this.$hitLayer$34353);
							if (81039 - 462923 == -381883)
							{
								continue;
							}
							this.$$iterator$9824$34357 = UnityRuntimeServices.GetEnumerator(this.$hitList$34354);
							if (203425 - 492952 != -289527)
							{
								continue;
							}
							while (this.$$iterator$9824$34357.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9824$34357.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34356 = (GameObject)obj2;
								if (70124 - 75941 == -5816)
								{
									goto IL_1B7;
								}
								if (this.$self_$34360.mChar.hit(2, this.$hitObject$34356, (int)(0.4f * (float)this.$self_$34360.mChar.atk + (float)this.$self_$34360.mChar.talAdjust(12 * this.$self_$34360.PunchLv)), 5, 0, (float)2 * this.$self_$34360.transform.forward) != 0)
								{
									if (185713 - 65844 == 119870)
									{
										goto IL_1B7;
									}
									this.$hitPos$34355 = this.$hitObject$34356.collider.ClosestPointOnBounds(this.$self_$34360.transform.position + this.$self_$34360.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (124901 - 135327 == -10425)
									{
										goto IL_1B7;
									}
									UnityRuntimeServices.Update(this.$$iterator$9824$34357, this.$hitObject$34356);
									if (186871 - 217741 != -30870)
									{
										goto IL_1B7;
									}
									this.$self_$34360.RPC_punch_hit(this.$hitPos$34355, this.$self_$34360.transform.forward, 0);
									if (15629 - 93177 != -77548)
									{
										goto IL_1B7;
									}
									if (PhotonClient.IsInitialized())
									{
										if (64724 - 326061 == -261336)
										{
											goto IL_1B7;
										}
										this.$self_$34360.ActionEvent("RPC_punch_hit", this.$hitPos$34355, this.$self_$34360.transform.forward, 0);
										if (179243 - 277848 != -98605)
										{
											goto IL_1B7;
										}
									}
								}
							}
							if (92757 - 272813 != -180055)
							{
								goto Block_44;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34360.mChar.actionState == "attack")
						{
							if (279430 - 359451 == -80020)
							{
								continue;
							}
							if (this.$self_$34360.mChar.myCommand == "punch")
							{
								if (65259 - 179929 != -114670)
								{
									continue;
								}
								this.$self_$34360.mChar.actionState = "standby";
								if (135618 - 459606 == -323987)
								{
									continue;
								}
								this.$self_$34360.mChar.actionTime = Time.time;
								if (236351 - 248005 != -11654)
								{
									continue;
								}
								this.$self_$34360.mChar.myCommand = "none";
								if (211522 - 6994 == 204529)
								{
									continue;
								}
								if (!this.$self_$34360.mChar.isMine)
								{
									if (116001 - 94491 != 21510)
									{
										continue;
									}
									this.$self_$34360.mChar.nPosition = this.$self_$34360.transform.position;
									if (68547 - 449062 != -380515)
									{
										continue;
									}
									this.$self_$34360.mChar.oPosition = this.$self_$34360.transform.position;
									if (41428 - 550727 == -509298)
									{
										continue;
									}
									this.$self_$34360.mChar.nDirection = this.$self_$34360.transform.forward;
									if (53416 - 515882 != -462466)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (240212 - 165294 != 74918)
						{
							continue;
						}
						goto IL_978;
					default:
						if (434 - 523485 == -523050)
						{
							continue;
						}
						break;
					}
					this.$self_$34360.mChar.actionState = "attack";
					if (243805 - 90222 != 153584)
					{
						this.$self_$34360.mChar.actionTime = Time.time;
						if (853 - 415588 != -414734)
						{
							this.$self_$34360.mChar.myCommand = "punch";
							if (215568 - 236750 != -21181)
							{
								this.$self_$34360.mChar.addTimeOut("punch", this.$self_$34360.mChar.agiAdjust((float)12));
								if (133395 - 206362 != -72966)
								{
									this.$self_$34360.transform.position = this.$mPos$34358;
									if (244235 - 10278 != 233958)
									{
										this.$self_$34360.transform.LookAt(this.$mPos$34358 + global::Math.vFlat(this.$tDir$34359));
										if (32576 - 365178 != -332601)
										{
											this.$self_$34360.animation.Play("punch");
											if (162405 - 570102 == -407697)
											{
												this.$self_$34360.animation.wrapMode = WrapMode.Once;
												if (264619 - 463613 != -198993)
												{
													this.$self_$34360.mChar.vMovement = this.$self_$34360.transform.forward;
													if (254746 - 152922 == 101824)
													{
														this.$self_$34360.mChar.moveSpeed = (float)-1;
														if (87622 - 306947 == -219325)
														{
															this.$mPunch$34352 = this.$self_$34360.mChar.createEffect(this.$self_$34360.punch, this.$self_$34360.transform.position, this.$self_$34360.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
															if (63758 - 204841 != -141082)
															{
																this.$mPunch$34352.transform.localScale = (0.7f + 0.1f * (float)this.$self_$34360.BarrelBotLv) * Vector3.one;
																if (210486 - 468497 != -258010)
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
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_19:
				goto IL_925;
				IL_454:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_44:
				goto IL_454;
				IL_925:
				IL_978:
				return false;
			}

			// Token: 0x0600546F RID: 21615 RVA: 0x00A42858 File Offset: 0x00A40A58
			internal static bool PSxuc0595sxUdQ7iOrb2()
			{
				return true;
			}

			// Token: 0x06005470 RID: 21616 RVA: 0x00A4285C File Offset: 0x00A40A5C
			internal static bool Wcgqs159pXxUldJ0lh1y()
			{
				return false;
			}

			// Token: 0x04005D79 RID: 23929
			internal GameObject $mPunch$34352;

			// Token: 0x04005D7A RID: 23930
			internal int $hitLayer$34353;

			// Token: 0x04005D7B RID: 23931
			internal UnityScript.Lang.Array $hitList$34354;

			// Token: 0x04005D7C RID: 23932
			internal Vector3 $hitPos$34355;

			// Token: 0x04005D7D RID: 23933
			internal GameObject $hitObject$34356;

			// Token: 0x04005D7E RID: 23934
			internal IEnumerator $$iterator$9824$34357;

			// Token: 0x04005D7F RID: 23935
			internal Vector3 $mPos$34358;

			// Token: 0x04005D80 RID: 23936
			internal Vector3 $tDir$34359;

			// Token: 0x04005D81 RID: 23937
			internal BarrelBot $self_$34360;
		}
	}

	// Token: 0x02000E8A RID: 3722
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_hammer$34364 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005471 RID: 21617 RVA: 0x00A42860 File Offset: 0x00A40A60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_hammer$34364(Vector3 mPos, Vector3 tDir, BarrelBot self_)
		{
			if (3697 - 36815 != -33118)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92078 - 271355 == -179277)
				{
					base..ctor();
					if (95999 - 321642 == -225643)
					{
						this.$mPos$34374 = mPos;
						if (62475 - 147925 == -85450)
						{
							this.$tDir$34375 = tDir;
							if (266616 - 395404 != -128787)
							{
								this.$self_$34376 = self_;
								if (136528 - 331238 != -194709)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x00A4293C File Offset: 0x00A40B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_hammer$34364.$(this.$mPos$34374, this.$tDir$34375, this.$self_$34376);
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x00A42958 File Offset: 0x00A40B58
		internal static bool gfYSLE59VK9VuKScyKB5()
		{
			return true;
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x00A4295C File Offset: 0x00A40B5C
		internal static bool HAqUac59tajv9gcvkCVY()
		{
			return false;
		}

		// Token: 0x04005D82 RID: 23938
		internal Vector3 $mPos$34374;

		// Token: 0x04005D83 RID: 23939
		internal Vector3 $tDir$34375;

		// Token: 0x04005D84 RID: 23940
		internal BarrelBot $self_$34376;

		// Token: 0x02000E8B RID: 3723
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005475 RID: 21621 RVA: 0x00A42960 File Offset: 0x00A40B60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BarrelBot self_)
			{
				if (199618 - 313833 != -114215)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (82997 - 206085 == -123088)
					{
						base..ctor();
						if (208556 - 261365 == -52809)
						{
							this.$mPos$34371 = mPos;
							if (238647 - 461328 != -222680)
							{
								this.$tDir$34372 = tDir;
								if (291131 - 56619 == 234512)
								{
									this.$self_$34373 = self_;
									if (37578 - 403874 != -366295)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005476 RID: 21622 RVA: 0x00A42A3C File Offset: 0x00A40C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (131099 - 86087 != 45012)
				{
				}
				for (;;)
				{
					IL_465:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_93D;
					case 2:
						if (this.$self_$34373.mChar.actionState != "attack")
						{
							goto IL_328;
						}
						if (181626 - 145252 != 36374)
						{
							continue;
						}
						if (this.$self_$34373.mChar.myCommand != "hammer")
						{
							if (42808 - 203963 != -161154)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$hitLayer$34366 = 130816 - (1 << this.$self_$34373.gameObject.layer);
							if (58592 - 94190 != -35598)
							{
								continue;
							}
							this.$hitList$34367 = null;
							if (188301 - 254122 == -65820)
							{
								continue;
							}
							this.$hitPos$34368 = default(Vector3);
							if (16890 - 504057 != -487167)
							{
								continue;
							}
							if (!this.$self_$34373.mChar.isMine)
							{
								goto IL_365;
							}
							if (203944 - 560128 != -356184)
							{
								continue;
							}
							this.$hitList$34367 = Damage.FindRecTarget(this.$self_$34373.transform.position, this.$self_$34373.transform.forward, (float)2 * this.$self_$34373.mChar.rangeMod, (float)2 * this.$self_$34373.mChar.rangeMod, 2.5f * this.$self_$34373.mChar.rangeMod, (float)3 * this.$self_$34373.mChar.rangeMod, this.$hitLayer$34366);
							if (245034 - 144095 != 100939)
							{
								continue;
							}
							this.$$iterator$9825$34370 = UnityRuntimeServices.GetEnumerator(this.$hitList$34367);
							if (273203 - 593917 == -320713)
							{
								continue;
							}
							while (this.$$iterator$9825$34370.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9825$34370.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34369 = (GameObject)obj2;
								if (287010 - 29652 == 257359)
								{
									goto IL_465;
								}
								if (this.$self_$34373.mChar.hit(3, this.$hitObject$34369, (int)(0.5f * (float)this.$self_$34373.mChar.atk + (float)this.$self_$34373.mChar.talAdjust(10 * this.$self_$34373.HammerLv)), 10 * this.$self_$34373.HammerLv, 0, this.$self_$34373.transform.forward) != 0)
								{
									if (119005 - 457213 != -338208)
									{
										goto IL_465;
									}
									this.$hitPos$34368 = this.$hitObject$34369.collider.ClosestPointOnBounds(this.$self_$34373.transform.position + this.$self_$34373.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (283570 - 593022 != -309452)
									{
										goto IL_465;
									}
									UnityRuntimeServices.Update(this.$$iterator$9825$34370, this.$hitObject$34369);
									if (200667 - 328772 != -128105)
									{
										goto IL_465;
									}
									this.$self_$34373.RPC_hammer_hit(this.$hitPos$34368, this.$self_$34373.transform.forward, 0);
									if (186078 - 504590 == -318511)
									{
										goto IL_465;
									}
									if (PhotonClient.IsInitialized())
									{
										if (83050 - 344983 == -261932)
										{
											goto IL_465;
										}
										this.$self_$34373.ActionEvent("RPC_hammer_hit", this.$hitPos$34368, this.$self_$34373.transform.forward, 0);
										if (38009 - 345097 == -307087)
										{
											goto IL_465;
										}
									}
								}
							}
							if (91923 - 56104 != 35819)
							{
								continue;
							}
							goto IL_365;
						}
						break;
					case 3:
						if (this.$self_$34373.mChar.actionState == "attack")
						{
							if (269608 - 76302 == 193307)
							{
								continue;
							}
							if (this.$self_$34373.mChar.myCommand == "hammer")
							{
								if (102273 - 127053 != -24780)
								{
									continue;
								}
								this.$self_$34373.mChar.actionState = "standby";
								if (39049 - 206874 == -167824)
								{
									continue;
								}
								this.$self_$34373.mChar.actionTime = Time.time;
								if (196184 - 43666 != 152518)
								{
									continue;
								}
								this.$self_$34373.mChar.myCommand = "none";
								if (89171 - 381527 == -292355)
								{
									continue;
								}
								if (!this.$self_$34373.mChar.isMine)
								{
									if (200772 - 213326 != -12554)
									{
										continue;
									}
									this.$self_$34373.mChar.nPosition = this.$self_$34373.transform.position;
									if (86658 - 283120 != -196462)
									{
										continue;
									}
									this.$self_$34373.mChar.oPosition = this.$self_$34373.transform.position;
									if (157071 - 209727 == -52655)
									{
										continue;
									}
									this.$self_$34373.mChar.nDirection = this.$self_$34373.transform.forward;
									if (108862 - 373933 == -265070)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (227680 - 425668 != -197987)
						{
							goto Block_40;
						}
						continue;
					default:
						if (111329 - 473350 != -362021)
						{
							continue;
						}
						break;
					}
					this.$self_$34373.mChar.actionState = "attack";
					if (182372 - 460252 != -277879)
					{
						this.$self_$34373.mChar.actionTime = Time.time;
						if (12656 - 259073 == -246417)
						{
							this.$self_$34373.mChar.myCommand = "hammer";
							if (238962 - 389196 != -150233)
							{
								this.$self_$34373.mChar.addTimeOut("hammer", this.$self_$34373.mChar.agiAdjust((float)15));
								if (238376 - 191859 == 46517)
								{
									this.$self_$34373.transform.position = this.$mPos$34371;
									if (221964 - 91082 == 130882)
									{
										this.$self_$34373.transform.LookAt(this.$mPos$34371 + global::Math.vFlat(this.$tDir$34372));
										if (22970 - 545506 == -522536)
										{
											this.$self_$34373.animation.Play("hammer");
											if (141531 - 437512 != -295980)
											{
												this.$self_$34373.animation.wrapMode = WrapMode.Once;
												if (120180 - 111968 == 8212)
												{
													this.$self_$34373.mChar.vMovement = this.$self_$34373.transform.forward;
													if (137049 - 293247 == -156198)
													{
														this.$self_$34373.mChar.moveSpeed = (float)0;
														if (37724 - 456544 != -418819)
														{
															this.$mHammer$34365 = this.$self_$34373.mChar.createEffect(this.$self_$34373.hammer, this.$self_$34373.transform.position, this.$self_$34373.transform.rotation);
															if (191542 - 26763 != 164780)
															{
																this.$mHammer$34365.transform.localScale = (0.7f + 0.1f * (float)this.$self_$34373.BarrelBotLv) * Vector3.one;
																if (188969 - 362386 == -173417)
																{
																	goto IL_61E;
																}
															}
														}
													}
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
				IL_328:
				goto IL_93D;
				IL_365:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_61E:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_40:
				IL_93D:
				return false;
			}

			// Token: 0x06005477 RID: 21623 RVA: 0x00A43398 File Offset: 0x00A41598
			internal static bool wURFtW59NbxhQ5Ndt2hj()
			{
				return true;
			}

			// Token: 0x06005478 RID: 21624 RVA: 0x00A4339C File Offset: 0x00A4159C
			internal static bool FSQ57C59YqJnkWIlRKg5()
			{
				return false;
			}

			// Token: 0x04005D85 RID: 23941
			internal GameObject $mHammer$34365;

			// Token: 0x04005D86 RID: 23942
			internal int $hitLayer$34366;

			// Token: 0x04005D87 RID: 23943
			internal UnityScript.Lang.Array $hitList$34367;

			// Token: 0x04005D88 RID: 23944
			internal Vector3 $hitPos$34368;

			// Token: 0x04005D89 RID: 23945
			internal GameObject $hitObject$34369;

			// Token: 0x04005D8A RID: 23946
			internal IEnumerator $$iterator$9825$34370;

			// Token: 0x04005D8B RID: 23947
			internal Vector3 $mPos$34371;

			// Token: 0x04005D8C RID: 23948
			internal Vector3 $tDir$34372;

			// Token: 0x04005D8D RID: 23949
			internal BarrelBot $self_$34373;
		}
	}

	// Token: 0x02000E8C RID: 3724
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_chopper$34377 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005479 RID: 21625 RVA: 0x00A433A0 File Offset: 0x00A415A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_chopper$34377(Vector3 mPos, Vector3 tDir, BarrelBot self_)
		{
			if (93932 - 457884 != -363952)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (90395 - 81575 != 8821)
				{
					base..ctor();
					if (286301 - 377624 != -91322)
					{
						this.$mPos$34389 = mPos;
						if (275040 - 237091 == 37949)
						{
							this.$tDir$34390 = tDir;
							if (16840 - 296435 != -279594)
							{
								this.$self_$34391 = self_;
								if (77499 - 436113 != -358613)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x00A4347C File Offset: 0x00A4167C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_chopper$34377.$(this.$mPos$34389, this.$tDir$34390, this.$self_$34391);
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x00A43498 File Offset: 0x00A41698
		internal static bool WdE7LA59co4e8WmOe4JN()
		{
			return true;
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x00A4349C File Offset: 0x00A4169C
		internal static bool SZnwHt59Um5DP9ywVSc7()
		{
			return false;
		}

		// Token: 0x04005D8E RID: 23950
		internal Vector3 $mPos$34389;

		// Token: 0x04005D8F RID: 23951
		internal Vector3 $tDir$34390;

		// Token: 0x04005D90 RID: 23952
		internal BarrelBot $self_$34391;

		// Token: 0x02000E8D RID: 3725
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600547D RID: 21629 RVA: 0x00A434A0 File Offset: 0x00A416A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BarrelBot self_)
			{
				if (130938 - 336421 != -205482)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (61825 - 310632 == -248807)
					{
						base..ctor();
						if (131032 - 173594 != -42561)
						{
							this.$mPos$34386 = mPos;
							if (219058 - 188373 == 30685)
							{
								this.$tDir$34387 = tDir;
								if (253571 - 42924 == 210647)
								{
									this.$self_$34388 = self_;
									if (18198 - 511535 == -493337)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600547E RID: 21630 RVA: 0x00A4357C File Offset: 0x00A4177C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182785 - 313934 != -131148)
				{
				}
				for (;;)
				{
					IL_83F:
					switch (this._state)
					{
					case 0:
						goto IL_AAE;
					case 1:
						goto IL_DDA;
					case 2:
						if (this.$self_$34388.mChar.actionState != "attack")
						{
							goto IL_734;
						}
						if (245984 - 42789 == 203196)
						{
							continue;
						}
						if (this.$self_$34388.mChar.myCommand != "chopper")
						{
							if (76977 - 488352 != -411375)
							{
								continue;
							}
							goto IL_734;
						}
						else
						{
							this.$self_$34388.mChar.moveSpeed = (float)3;
							if (251852 - 546142 != -294290)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$34388.chopper_startDust, this.$self_$34388.transform.position, Quaternion.identity);
							if (141744 - 525003 != -383259)
							{
								continue;
							}
							this.$mChopper$34378.audio.Play();
							if (270059 - 142116 != 127944)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34388.mChar.actionState != "attack")
						{
							goto IL_19E;
						}
						if (52562 - 190856 != -138294)
						{
							continue;
						}
						if (this.$self_$34388.mChar.myCommand != "chopper")
						{
							if (266939 - 69545 != 197395)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$self_$34388.mChar.moveSpeed = (float)5;
							if (237366 - 240017 == -2650)
							{
								continue;
							}
							this.$hitLayer$34380 = 130816 - (1 << this.$self_$34388.gameObject.layer);
							if (189521 - 3408 == 186114)
							{
								continue;
							}
							this.$hitList$34381 = null;
							if (148085 - 46656 == 101430)
							{
								continue;
							}
							this.$hitPos$34382 = default(Vector3);
							if (22431 - 307693 != -285262)
							{
								continue;
							}
							this.$i$34383 = 0;
							if (209417 - 304613 != -95196)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34388.mChar.actionState != "attack")
						{
							goto IL_B48;
						}
						if (109794 - 331928 == -222133)
						{
							continue;
						}
						if (!(this.$self_$34388.mChar.myCommand != "chopper"))
						{
							goto IL_9EC;
						}
						if (34482 - 467873 != -433390)
						{
							goto Block_55;
						}
						continue;
					case 5:
						if (this.$self_$34388.mChar.actionState != "attack")
						{
							goto IL_3FA;
						}
						if (221156 - 315341 == -94184)
						{
							continue;
						}
						if (this.$self_$34388.mChar.myCommand != "chopper")
						{
							if (187312 - 527039 != -339726)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$self_$34388.mChar.moveSpeed = (float)0;
							if (218001 - 342390 == -124388)
							{
								continue;
							}
							if (!this.$mChopper$34378)
							{
								goto IL_332;
							}
							if (167749 - 30991 != 136758)
							{
								continue;
							}
							this.$mChopper$34378.audio.Stop();
							if (136242 - 488571 != -352328)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$34388.mChar.actionState == "attack")
						{
							if (137070 - 49094 == 87977)
							{
								continue;
							}
							if (this.$self_$34388.mChar.myCommand == "chopper")
							{
								if (236961 - 8359 == 228603)
								{
									continue;
								}
								this.$self_$34388.mChar.actionState = "standby";
								if (297884 - 369249 != -71365)
								{
									continue;
								}
								this.$self_$34388.mChar.actionTime = Time.time;
								if (170829 - 526454 == -355624)
								{
									continue;
								}
								this.$self_$34388.mChar.myCommand = "none";
								if (80626 - 537242 == -456615)
								{
									continue;
								}
								if (!this.$self_$34388.mChar.isMine)
								{
									if (12621 - 93025 != -80404)
									{
										continue;
									}
									this.$self_$34388.mChar.nPosition = this.$self_$34388.transform.position;
									if (250165 - 573981 == -323815)
									{
										continue;
									}
									this.$self_$34388.mChar.oPosition = this.$self_$34388.transform.position;
									if (141941 - 229144 == -87202)
									{
										continue;
									}
									this.$self_$34388.mChar.nDirection = this.$self_$34388.transform.forward;
									if (108422 - 522619 != -414197)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (117618 - 43335 != 74283)
						{
							continue;
						}
						goto IL_DDA;
					default:
						if (143238 - 116094 != 27145)
						{
							goto IL_AAE;
						}
						continue;
					}
					IL_A14:
					if (this.$i$34383 >= 4)
					{
						if (250916 - 38658 != 212258)
						{
							continue;
						}
						goto IL_BAD;
					}
					else
					{
						UnityEngine.Object.Instantiate(this.$self_$34388.chopper_forwardDust, this.$self_$34388.transform.position, this.$self_$34388.transform.rotation);
						if (292409 - 498764 == -206354)
						{
							continue;
						}
						if (this.$self_$34388.mChar.isMine)
						{
							if (141256 - 409079 != -267823)
							{
								continue;
							}
							this.$hitList$34381 = Damage.FindRecTarget(this.$self_$34388.transform.position, this.$self_$34388.transform.forward, (float)1 * this.$self_$34388.mChar.rangeMod, (float)1 * this.$self_$34388.mChar.rangeMod, (float)3 * this.$self_$34388.mChar.rangeMod, (float)2 * this.$self_$34388.mChar.rangeMod, this.$hitLayer$34380);
							if (263498 - 501975 == -238476)
							{
								continue;
							}
							this.$$iterator$9826$34385 = UnityRuntimeServices.GetEnumerator(this.$hitList$34381);
							if (124204 - 210581 == -86376)
							{
								continue;
							}
							while (this.$$iterator$9826$34385.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9826$34385.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34384 = (GameObject)obj2;
								if (8107 - 322817 != -314710)
								{
									goto IL_83F;
								}
								if (this.$self_$34388.mChar.hit(4, this.$hitObject$34384, (int)(0.3f * (float)this.$self_$34388.mChar.atk + (float)this.$self_$34388.mChar.talAdjust(5 * this.$self_$34388.ChopperLv)), 1, 0, this.$self_$34388.transform.forward) != 0)
								{
									if (195402 - 585167 == -389764)
									{
										goto IL_83F;
									}
									this.$hitPos$34382 = this.$hitObject$34384.collider.ClosestPointOnBounds(this.$self_$34388.transform.position + this.$self_$34388.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (1100 - 200266 != -199166)
									{
										goto IL_83F;
									}
									UnityRuntimeServices.Update(this.$$iterator$9826$34385, this.$hitObject$34384);
									if (294089 - 298844 != -4755)
									{
										goto IL_83F;
									}
									this.$self_$34388.RPC_chopper_hit(this.$hitPos$34382, this.$self_$34388.transform.forward, 0);
									if (64206 - 252911 != -188705)
									{
										goto IL_83F;
									}
									if (PhotonClient.IsInitialized())
									{
										if (156229 - 533036 == -376806)
										{
											goto IL_83F;
										}
										this.$self_$34388.ActionEvent("RPC_chopper_hit", this.$hitPos$34382, this.$self_$34388.transform.forward, 0);
										if (263183 - 531856 != -268673)
										{
											goto IL_83F;
										}
									}
								}
							}
							if (48148 - 233618 == -185469)
							{
								continue;
							}
						}
						if (this.$i$34383 < 3)
						{
							if (152096 - 63460 != 88636)
							{
								continue;
							}
							goto IL_C85;
						}
						else
						{
							this.$self_$34388.mChar.moveSpeed = (float)2;
							if (95514 - 100593 != -5079)
							{
								continue;
							}
						}
					}
					IL_9EC:
					this.$i$34383++;
					if (298861 - 387244 != -88383)
					{
						continue;
					}
					goto IL_A14;
					IL_AAE:
					this.$self_$34388.mChar.actionState = "attack";
					if (83414 - 552279 != -468864)
					{
						this.$self_$34388.mChar.actionTime = Time.time;
						if (275613 - 515701 == -240088)
						{
							this.$self_$34388.mChar.myCommand = "chopper";
							if (135070 - 70016 != 65055)
							{
								this.$self_$34388.mChar.addTimeOut("chopper", this.$self_$34388.mChar.agiAdjust((float)60));
								if (155964 - 530029 == -374065)
								{
									this.$self_$34388.transform.position = this.$mPos$34386;
									if (67121 - 26294 != 40828)
									{
										this.$self_$34388.transform.LookAt(this.$mPos$34386 + global::Math.vFlat(this.$tDir$34387));
										if (259014 - 496440 == -237426)
										{
											this.$self_$34388.animation.Play("chopper");
											if (88151 - 382354 != -294202)
											{
												this.$self_$34388.animation.wrapMode = WrapMode.Once;
												if (56934 - 442678 == -385744)
												{
													this.$self_$34388.mChar.vMovement = this.$self_$34388.transform.forward;
													if (102630 - 477594 != -374963)
													{
														this.$self_$34388.mChar.moveSpeed = (float)0;
														if (234461 - 1703 != 232759)
														{
															this.$mChopper$34378 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$34388.chopper, this.$self_$34388.transform.position, this.$self_$34388.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
															if (122922 - 130662 == -7740)
															{
																this.$mChopper$34378.transform.localScale = (0.8f + 0.1f * (float)this.$self_$34388.BarrelBotLv) * Vector3.one;
																if (205819 - 527066 == -321247)
																{
																	this.$mChopperEffectControl$34379 = (EffectControl)this.$mChopper$34378.GetComponent(typeof(EffectControl));
																	if (56145 - 341459 != -285313)
																	{
																		if (!this.$mChopperEffectControl$34379)
																		{
																			goto IL_582;
																		}
																		if (99206 - 113030 != -13823)
																		{
																			this.$mChopperEffectControl$34379.InitEffectControl(this.$self_$34388.gameObject);
																			if (230423 - 409628 != -179204)
																			{
																				goto Block_9;
																			}
																		}
																	}
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_6:
				goto IL_332;
				Block_9:
				goto IL_582;
				IL_19E:
				goto IL_DDA;
				IL_332:
				return this.Yield(6, new WaitForSeconds(0.2f));
				IL_3FA:
				goto IL_DDA;
				Block_31:
				goto IL_3FA;
				IL_582:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_42:
				IL_734:
				Block_55:
				IL_B48:
				goto IL_DDA;
				IL_BAD:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_C85:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_DDA:
				return false;
			}

			// Token: 0x0600547F RID: 21631 RVA: 0x00A44378 File Offset: 0x00A42578
			internal static bool hv2PLB59TbeKB0BniCYr()
			{
				return true;
			}

			// Token: 0x06005480 RID: 21632 RVA: 0x00A4437C File Offset: 0x00A4257C
			internal static bool koUagX593YAHfbfmUy9C()
			{
				return false;
			}

			// Token: 0x04005D91 RID: 23953
			internal GameObject $mChopper$34378;

			// Token: 0x04005D92 RID: 23954
			internal EffectControl $mChopperEffectControl$34379;

			// Token: 0x04005D93 RID: 23955
			internal int $hitLayer$34380;

			// Token: 0x04005D94 RID: 23956
			internal UnityScript.Lang.Array $hitList$34381;

			// Token: 0x04005D95 RID: 23957
			internal Vector3 $hitPos$34382;

			// Token: 0x04005D96 RID: 23958
			internal int $i$34383;

			// Token: 0x04005D97 RID: 23959
			internal GameObject $hitObject$34384;

			// Token: 0x04005D98 RID: 23960
			internal IEnumerator $$iterator$9826$34385;

			// Token: 0x04005D99 RID: 23961
			internal Vector3 $mPos$34386;

			// Token: 0x04005D9A RID: 23962
			internal Vector3 $tDir$34387;

			// Token: 0x04005D9B RID: 23963
			internal BarrelBot $self_$34388;
		}
	}

	// Token: 0x02000E8E RID: 3726
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_missile$34392 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005481 RID: 21633 RVA: 0x00A44380 File Offset: 0x00A42580
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_missile$34392(Vector3 mPos, Vector3 tDir, BarrelBot self_)
		{
			if (276455 - 326546 != -50091)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (833 - 411002 == -410169)
				{
					base..ctor();
					if (26510 - 390693 == -364183)
					{
						this.$mPos$34407 = mPos;
						if (251896 - 137836 == 114060)
						{
							this.$tDir$34408 = tDir;
							if (150988 - 477380 != -326391)
							{
								this.$self_$34409 = self_;
								if (71604 - 4840 == 66764)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x00A4445C File Offset: 0x00A4265C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_missile$34392.$(this.$mPos$34407, this.$tDir$34408, this.$self_$34409);
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x00A44478 File Offset: 0x00A42678
		internal static bool WZEI9o59XDdw5voIw8cV()
		{
			return true;
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x00A4447C File Offset: 0x00A4267C
		internal static bool SrntpI59QOh5BIunkPKp()
		{
			return false;
		}

		// Token: 0x04005D9C RID: 23964
		internal Vector3 $mPos$34407;

		// Token: 0x04005D9D RID: 23965
		internal Vector3 $tDir$34408;

		// Token: 0x04005D9E RID: 23966
		internal BarrelBot $self_$34409;

		// Token: 0x02000E8F RID: 3727
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005485 RID: 21637 RVA: 0x00A44480 File Offset: 0x00A42680
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BarrelBot self_)
			{
				if (52544 - 20621 != 31923)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150486 - 60673 != 89814)
					{
						base..ctor();
						if (150437 - 188046 != -37608)
						{
							this.$mPos$34404 = mPos;
							if (74057 - 158752 != -84694)
							{
								this.$tDir$34405 = tDir;
								if (254928 - 280068 == -25140)
								{
									this.$self_$34406 = self_;
									if (152252 - 20475 == 131777)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005486 RID: 21638 RVA: 0x00A4455C File Offset: 0x00A4275C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182277 - 40480 != 141798)
				{
				}
				for (;;)
				{
					IL_27A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B4A;
					case 2:
						if (this.$self_$34406.mChar.actionState != "attack")
						{
							goto IL_A8C;
						}
						if (225307 - 564191 != -338884)
						{
							continue;
						}
						if (this.$self_$34406.mChar.myCommand != "missile")
						{
							if (236136 - 38345 != 197791)
							{
								continue;
							}
							goto IL_A8C;
						}
						else
						{
							if (!this.$self_$34406.mChar.isMine)
							{
								goto IL_3A7;
							}
							if (202640 - 225261 == -22620)
							{
								continue;
							}
							this.$targetLayer$34393 = 130816 - (1 << this.$self_$34406.gameObject.layer);
							if (160548 - 285271 != -124723)
							{
								continue;
							}
							this.$targetList$34394 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$34406.transform.position, (float)32, (float)10, this.$targetLayer$34393));
							if (45248 - 406421 != -361173)
							{
								continue;
							}
							this.$startAngle$34395 = 0;
							if (287324 - 122974 == 164351)
							{
								continue;
							}
							this.$deltaAngle$34396 = 0;
							if (98879 - 510209 != -411330)
							{
								continue;
							}
							this.$$switch$3920$34397 = this.$self_$34406.MissileLv;
							if (121906 - 133087 == -11180)
							{
								continue;
							}
							if (this.$$switch$3920$34397 == 1)
							{
								if (38980 - 299433 == -260452)
								{
									continue;
								}
								this.$startAngle$34395 = 0;
								if (249732 - 560714 == -310981)
								{
									continue;
								}
								this.$deltaAngle$34396 = 0;
								if (293426 - 585680 != -292254)
								{
									continue;
								}
							}
							else if (this.$$switch$3920$34397 == 2)
							{
								if (55346 - 572340 != -516994)
								{
									continue;
								}
								this.$startAngle$34395 = -60;
								if (281471 - 26972 == 254500)
								{
									continue;
								}
								this.$deltaAngle$34396 = 120;
								if (89211 - 146496 == -57284)
								{
									continue;
								}
							}
							else if (this.$$switch$3920$34397 == 3)
							{
								if (42984 - 251288 == -208303)
								{
									continue;
								}
								this.$startAngle$34395 = -60;
								if (288659 - 380324 == -91664)
								{
									continue;
								}
								this.$deltaAngle$34396 = 120;
								if (4145 - 225135 == -220989)
								{
									continue;
								}
							}
							else if (this.$$switch$3920$34397 == 4)
							{
								if (244479 - 374507 != -130028)
								{
									continue;
								}
								this.$startAngle$34395 = -45;
								if (286055 - 522368 != -236313)
								{
									continue;
								}
								this.$deltaAngle$34396 = 90;
								if (94048 - 249958 == -155909)
								{
									continue;
								}
							}
							else if (this.$$switch$3920$34397 == 5)
							{
								if (43667 - 293526 != -249859)
								{
									continue;
								}
								this.$startAngle$34395 = 0;
								if (73109 - 9278 == 63832)
								{
									continue;
								}
								this.$deltaAngle$34396 = 36;
								if (102482 - 264486 != -162004)
								{
									continue;
								}
							}
							this.$i$34398 = 0;
							if (57670 - 587843 != -530173)
							{
								continue;
							}
							while (this.$i$34398 < this.$self_$34406.MissileLv)
							{
								this.$targetID$34399 = 0;
								if (225680 - 158037 == 67644)
								{
									goto IL_27A;
								}
								if (this.$targetList$34394.length > 0)
								{
									if (239593 - 396694 == -157100)
									{
										goto IL_27A;
									}
									object obj2;
									object obj = obj2 = this.$targetList$34394[UnityEngine.Random.Range(1, this.$targetList$34394.length) - 1];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$34400 = (GameObject)obj2;
									if (151827 - 555965 != -404138)
									{
										goto IL_27A;
									}
									if (this.$tObject$34400)
									{
										if (17659 - 575042 == -557382)
										{
											goto IL_27A;
										}
										this.$tChar$34401 = (CharacterControl)this.$tObject$34400.GetComponent(typeof(CharacterControl));
										if (90055 - 487311 != -397256)
										{
											goto IL_27A;
										}
									}
									if (this.$tChar$34401)
									{
										if (104061 - 496768 != -392707)
										{
											goto IL_27A;
										}
										this.$targetID$34399 = this.$tChar$34401.ActorNr;
										if (153269 - 448780 == -295510)
										{
											goto IL_27A;
										}
									}
								}
								this.$firePos$34402 = this.$self_$34406.transform.position + ((float)this.$self_$34406.BarrelBotLv * 0.1f + 0.8f) * Vector3.up;
								if (194384 - 278798 != -84414)
								{
									goto IL_27A;
								}
								this.$fireDir$34403 = global::Math.rotateH(this.$self_$34406.transform.forward, (float)(this.$startAngle$34395 + this.$deltaAngle$34396 * this.$i$34398));
								if (115093 - 464835 == -349741)
								{
									goto IL_27A;
								}
								this.$self_$34406.RPC_missile_fire(this.$firePos$34402, this.$fireDir$34403, this.$targetID$34399);
								if (94440 - 303952 == -209511)
								{
									goto IL_27A;
								}
								if (PhotonClient.IsInitialized())
								{
									if (234643 - 112492 != 122151)
									{
										goto IL_27A;
									}
									this.$self_$34406.ActionEvent("RPC_missile_fire", this.$firePos$34402, this.$fireDir$34403, this.$targetID$34399);
									if (270120 - 588540 != -318420)
									{
										goto IL_27A;
									}
								}
								this.$i$34398++;
								if (125388 - 319133 == -193744)
								{
									goto IL_27A;
								}
							}
							if (243295 - 220414 != 22881)
							{
								continue;
							}
							goto IL_3A7;
						}
						break;
					case 3:
						if (this.$self_$34406.mChar.actionState == "attack")
						{
							if (62477 - 68938 != -6461)
							{
								continue;
							}
							if (this.$self_$34406.mChar.myCommand == "missile")
							{
								if (297837 - 171956 == 125882)
								{
									continue;
								}
								this.$self_$34406.mChar.actionState = "standby";
								if (93678 - 331860 == -238181)
								{
									continue;
								}
								this.$self_$34406.mChar.actionTime = Time.time;
								if (21826 - 523171 == -501344)
								{
									continue;
								}
								this.$self_$34406.mChar.myCommand = "none";
								if (245126 - 456056 != -210930)
								{
									continue;
								}
								if (!this.$self_$34406.mChar.isMine)
								{
									if (258170 - 244361 != 13809)
									{
										continue;
									}
									this.$self_$34406.mChar.nPosition = this.$self_$34406.transform.position;
									if (207796 - 69709 == 138088)
									{
										continue;
									}
									this.$self_$34406.mChar.oPosition = this.$self_$34406.transform.position;
									if (57673 - 35420 == 22254)
									{
										continue;
									}
									this.$self_$34406.mChar.nDirection = this.$self_$34406.transform.forward;
									if (202980 - 100644 != 102336)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (61717 - 128291 != -66574)
						{
							continue;
						}
						goto IL_B4A;
					default:
						if (110138 - 370707 != -260569)
						{
							continue;
						}
						break;
					}
					this.$self_$34406.mChar.actionState = "attack";
					if (78589 - 595697 == -517108)
					{
						this.$self_$34406.mChar.actionTime = Time.time;
						if (168867 - 192735 != -23867)
						{
							this.$self_$34406.mChar.myCommand = "missile";
							if (143934 - 89556 == 54378)
							{
								this.$self_$34406.mChar.addTimeOut("missile", this.$self_$34406.mChar.agiAdjust((float)60));
								if (80564 - 391072 == -310508)
								{
									this.$self_$34406.transform.position = this.$mPos$34404;
									if (279644 - 203042 != 76603)
									{
										this.$self_$34406.transform.LookAt(this.$mPos$34404 + global::Math.vFlat(this.$tDir$34405));
										if (237271 - 108418 != 128854)
										{
											this.$self_$34406.animation.Play("missile");
											if (86850 - 166999 != -80148)
											{
												this.$self_$34406.animation.wrapMode = WrapMode.Once;
												if (54041 - 306925 != -252883)
												{
													this.$self_$34406.mChar.vMovement = this.$self_$34406.transform.forward;
													if (60411 - 564604 == -504193)
													{
														this.$self_$34406.mChar.moveSpeed = (float)0;
														if (140225 - 106196 == 34029)
														{
															goto IL_5A1;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_3A7:
				return this.Yield(3, new WaitForSeconds(0.9f));
				IL_5A1:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_A8C:
				IL_B4A:
				return false;
			}

			// Token: 0x06005487 RID: 21639 RVA: 0x00A450C8 File Offset: 0x00A432C8
			internal static bool v6sJII59k6It0Lh7MRNf()
			{
				return true;
			}

			// Token: 0x06005488 RID: 21640 RVA: 0x00A450CC File Offset: 0x00A432CC
			internal static bool MPZHMy59G5hRPhPXucOg()
			{
				return false;
			}

			// Token: 0x04005D9F RID: 23967
			internal int $targetLayer$34393;

			// Token: 0x04005DA0 RID: 23968
			internal UnityScript.Lang.Array $targetList$34394;

			// Token: 0x04005DA1 RID: 23969
			internal int $startAngle$34395;

			// Token: 0x04005DA2 RID: 23970
			internal int $deltaAngle$34396;

			// Token: 0x04005DA3 RID: 23971
			internal int $$switch$3920$34397;

			// Token: 0x04005DA4 RID: 23972
			internal int $i$34398;

			// Token: 0x04005DA5 RID: 23973
			internal int $targetID$34399;

			// Token: 0x04005DA6 RID: 23974
			internal GameObject $tObject$34400;

			// Token: 0x04005DA7 RID: 23975
			internal CharacterControl $tChar$34401;

			// Token: 0x04005DA8 RID: 23976
			internal Vector3 $firePos$34402;

			// Token: 0x04005DA9 RID: 23977
			internal Vector3 $fireDir$34403;

			// Token: 0x04005DAA RID: 23978
			internal Vector3 $mPos$34404;

			// Token: 0x04005DAB RID: 23979
			internal Vector3 $tDir$34405;

			// Token: 0x04005DAC RID: 23980
			internal BarrelBot $self_$34406;
		}
	}

	// Token: 0x02000E90 RID: 3728
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_drill$34410 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005489 RID: 21641 RVA: 0x00A450D0 File Offset: 0x00A432D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_drill$34410(Vector3 mPos, Vector3 tDir, BarrelBot self_)
		{
			if (73937 - 530158 != -456220)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (296344 - 295289 == 1055)
				{
					base..ctor();
					if (233072 - 114010 != 119063)
					{
						this.$mPos$34422 = mPos;
						if (239213 - 38283 == 200930)
						{
							this.$tDir$34423 = tDir;
							if (226355 - 27053 != 199303)
							{
								this.$self_$34424 = self_;
								if (113639 - 525406 == -411767)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x00A451AC File Offset: 0x00A433AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_drill$34410.$(this.$mPos$34422, this.$tDir$34423, this.$self_$34424);
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x00A451C8 File Offset: 0x00A433C8
		internal static bool vOLGAf59HImVr2HtaVG2()
		{
			return true;
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x00A451CC File Offset: 0x00A433CC
		internal static bool IvLBqg59WwCYN44G9Oju()
		{
			return false;
		}

		// Token: 0x04005DAD RID: 23981
		internal Vector3 $mPos$34422;

		// Token: 0x04005DAE RID: 23982
		internal Vector3 $tDir$34423;

		// Token: 0x04005DAF RID: 23983
		internal BarrelBot $self_$34424;

		// Token: 0x02000E91 RID: 3729
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600548D RID: 21645 RVA: 0x00A451D0 File Offset: 0x00A433D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BarrelBot self_)
			{
				if (234065 - 172686 != 61379)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167698 - 398851 != -231152)
					{
						base..ctor();
						if (70104 - 239831 == -169727)
						{
							this.$mPos$34419 = mPos;
							if (80728 - 549915 == -469187)
							{
								this.$tDir$34420 = tDir;
								if (234325 - 358947 != -124621)
								{
									this.$self_$34421 = self_;
									if (64651 - 214757 != -150105)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600548E RID: 21646 RVA: 0x00A452AC File Offset: 0x00A434AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82698 - 196112 != -113414)
				{
				}
				for (;;)
				{
					IL_49C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C2F;
					case 2:
						if (this.$self_$34421.mChar.actionState != "attack")
						{
							goto IL_1AF;
						}
						if (157218 - 405089 != -247871)
						{
							continue;
						}
						if (this.$self_$34421.mChar.myCommand != "drill")
						{
							if (154209 - 156953 != -2743)
							{
								goto Block_70;
							}
							continue;
						}
						else
						{
							this.$self_$34421.mChar.moveSpeed = (float)0;
							if (108341 - 233947 == -125605)
							{
								continue;
							}
							this.$i$34413 = 0;
							if (203321 - 253279 != -49958)
							{
								continue;
							}
							goto IL_97C;
						}
						break;
					case 3:
						if (this.$self_$34421.mChar.actionState != "attack")
						{
							goto IL_43D;
						}
						if (212635 - 64271 != 148364)
						{
							continue;
						}
						if (this.$self_$34421.mChar.myCommand != "drill")
						{
							if (239793 - 560052 != -320259)
							{
								continue;
							}
							goto IL_43D;
						}
						else
						{
							if (this.$self_$34421.mChar.isMine)
							{
								if (24200 - 88999 != -64799)
								{
									continue;
								}
								this.$hitLayer$34414 = 130816 - (1 << this.$self_$34421.gameObject.layer);
								if (79292 - 231355 == -152062)
								{
									continue;
								}
								this.$hitList$34415 = Damage.FindRecTarget(this.$self_$34421.transform.position, this.$self_$34421.transform.forward, (float)1 * this.$self_$34421.mChar.rangeMod, (float)1 * this.$self_$34421.mChar.rangeMod, (float)3 * this.$self_$34421.mChar.rangeMod, (float)2 * this.$self_$34421.mChar.rangeMod, this.$hitLayer$34414);
								if (218238 - 422945 != -204707)
								{
									continue;
								}
								this.$$iterator$9827$34418 = UnityRuntimeServices.GetEnumerator(this.$hitList$34415);
								if (271330 - 325767 == -54436)
								{
									continue;
								}
								while (this.$$iterator$9827$34418.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9827$34418.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34416 = (GameObject)obj2;
									if (90687 - 533612 != -442925)
									{
										goto IL_49C;
									}
									if (this.$self_$34421.mChar.hit(2, this.$hitObject$34416, (int)(0.5f * (float)this.$self_$34421.mChar.atk + (float)this.$self_$34421.mChar.talAdjust(15)), 2, 0, (float)2 * this.$self_$34421.transform.forward) != 0)
									{
										if (2684 - 207968 != -205284)
										{
											goto IL_49C;
										}
										this.$hitPos$34417 = this.$hitObject$34416.collider.ClosestPointOnBounds(this.$self_$34421.transform.position + this.$self_$34421.transform.TransformDirection((float)1, 1.5f, 2.5f));
										if (285858 - 383844 != -97986)
										{
											goto IL_49C;
										}
										UnityRuntimeServices.Update(this.$$iterator$9827$34418, this.$hitObject$34416);
										if (101370 - 493860 == -392489)
										{
											goto IL_49C;
										}
										this.$self_$34421.RPC_drill_hit(this.$hitPos$34417, this.$self_$34421.transform.forward, 0);
										if (211556 - 542412 == -330855)
										{
											goto IL_49C;
										}
										if (PhotonClient.IsInitialized())
										{
											if (105933 - 501913 != -395980)
											{
												goto IL_49C;
											}
											this.$self_$34421.ActionEvent("RPC_drill_hit", this.$hitPos$34417, this.$self_$34421.transform.forward, 0);
											if (82392 - 115171 == -32778)
											{
												goto IL_49C;
											}
										}
										this.$self_$34421.mChar.sp = this.$self_$34421.mChar.sp + 1;
										if (271721 - 505022 != -233301)
										{
											goto IL_49C;
										}
									}
								}
								if (239971 - 506885 != -266914)
								{
									continue;
								}
							}
							this.$i$34413++;
							if (106997 - 382746 != -275749)
							{
								continue;
							}
							goto IL_97C;
						}
						break;
					case 4:
						if (this.$self_$34421.mChar.actionState == "attack")
						{
							if (188525 - 39192 == 149334)
							{
								continue;
							}
							if (this.$self_$34421.mChar.myCommand == "drill")
							{
								if (137190 - 102854 != 34336)
								{
									continue;
								}
								this.$self_$34421.mChar.actionState = "standby";
								if (166596 - 276090 != -109494)
								{
									continue;
								}
								this.$self_$34421.mChar.actionTime = Time.time;
								if (143481 - 435655 == -292173)
								{
									continue;
								}
								this.$self_$34421.mChar.myCommand = "none";
								if (30700 - 74531 != -43831)
								{
									continue;
								}
								if (!this.$self_$34421.mChar.isMine)
								{
									if (81496 - 475811 != -394315)
									{
										continue;
									}
									this.$self_$34421.mChar.nPosition = this.$self_$34421.transform.position;
									if (151160 - 369206 != -218046)
									{
										continue;
									}
									this.$self_$34421.mChar.oPosition = this.$self_$34421.transform.position;
									if (148576 - 50812 == 97765)
									{
										continue;
									}
									this.$self_$34421.mChar.nDirection = this.$self_$34421.transform.forward;
									if (38364 - 55425 != -17061)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (234465 - 34289 != 200177)
						{
							goto Block_57;
						}
						continue;
					default:
						if (247746 - 64953 == 182794)
						{
							continue;
						}
						break;
					}
					this.$self_$34421.mChar.actionState = "attack";
					if (290638 - 254221 == 36418)
					{
						continue;
					}
					this.$self_$34421.mChar.actionTime = Time.time;
					if (54428 - 452813 != -398385)
					{
						continue;
					}
					this.$self_$34421.mChar.myCommand = "drill";
					if (260301 - 227887 == 32415)
					{
						continue;
					}
					this.$self_$34421.mChar.addTimeOut("drill", (float)9);
					if (4823 - 90791 == -85967)
					{
						continue;
					}
					this.$self_$34421.transform.position = this.$mPos$34419;
					if (248084 - 136634 != 111450)
					{
						continue;
					}
					this.$self_$34421.transform.LookAt(this.$mPos$34419 + global::Math.vFlat(this.$tDir$34420));
					if (92062 - 25984 != 66078)
					{
						continue;
					}
					this.$self_$34421.animation.Play("drill");
					if (11208 - 144309 == -133100)
					{
						continue;
					}
					this.$self_$34421.animation.wrapMode = WrapMode.Once;
					if (170577 - 67679 != 102898)
					{
						continue;
					}
					this.$self_$34421.mChar.vMovement = this.$self_$34421.transform.forward;
					if (51672 - 460707 != -409035)
					{
						continue;
					}
					this.$self_$34421.mChar.moveSpeed = (float)-1;
					if (116500 - 333971 != -217471)
					{
						continue;
					}
					if (this.$self_$34421.drill_ring)
					{
						if (202319 - 302914 != -100595)
						{
							continue;
						}
						this.$mDrill$34411 = this.$self_$34421.mChar.createEffect(this.$self_$34421.drill_ring, this.$self_$34421.transform.position, this.$self_$34421.transform.rotation);
						if (147513 - 589149 != -441636)
						{
							continue;
						}
						if (!this.$mDrill$34411)
						{
							goto IL_234;
						}
						if (206810 - 471171 != -264361)
						{
							continue;
						}
						this.$$switch$3922$34412 = this.$self_$34421.BarrelBotLv;
						if (88272 - 97036 != -8764)
						{
							continue;
						}
						if (this.$$switch$3922$34412 == 1)
						{
							if (292512 - 108294 != 184218)
							{
								continue;
							}
							this.$mDrill$34411.transform.localScale = 0.6f * Vector3.one;
							if (156153 - 373413 != -217259)
							{
								goto Block_41;
							}
							continue;
						}
						else if (this.$$switch$3922$34412 == 2)
						{
							if (173362 - 49305 == 124058)
							{
								continue;
							}
							this.$mDrill$34411.transform.localScale = 0.66f * Vector3.one;
							if (168140 - 228965 != -60824)
							{
								goto Block_52;
							}
							continue;
						}
						else if (this.$$switch$3922$34412 == 3)
						{
							if (98011 - 24316 == 73696)
							{
								continue;
							}
							this.$mDrill$34411.transform.localScale = 0.73f * Vector3.one;
							if (82350 - 6446 != 75904)
							{
								continue;
							}
							goto IL_397;
						}
						else
						{
							if (this.$$switch$3922$34412 != 4)
							{
								goto IL_234;
							}
							if (242871 - 390155 != -147284)
							{
								continue;
							}
							this.$mDrill$34411.transform.localScale = 0.8f * Vector3.one;
							if (102566 - 242480 != -139914)
							{
								continue;
							}
							goto IL_22F;
						}
					}
					else
					{
						Debug.LogError("Cannot find drill_ring effect");
						if (70911 - 214018 != -143106)
						{
							goto Block_15;
						}
						continue;
					}
					IL_97C:
					if (this.$i$34413 < 4)
					{
						goto IL_7CB;
					}
					if (242211 - 586254 != -344042)
					{
						goto Block_59;
					}
				}
				IL_1AF:
				goto IL_C2F;
				IL_1E0:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_22F:
				IL_234:
				goto IL_1E0;
				Block_15:
				IL_397:
				goto IL_234;
				IL_43D:
				goto IL_C2F;
				Block_41:
				goto IL_234;
				IL_7CB:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_52:
				goto IL_234;
				Block_57:
				goto IL_C2F;
				Block_59:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_70:
				IL_C2F:
				return false;
			}

			// Token: 0x0600548F RID: 21647 RVA: 0x00A45EFC File Offset: 0x00A440FC
			internal static bool je7pDc59AieSaEXh0QUP()
			{
				return true;
			}

			// Token: 0x06005490 RID: 21648 RVA: 0x00A45F00 File Offset: 0x00A44100
			internal static bool RhLMiD59lHyeG1OXpdDJ()
			{
				return false;
			}

			// Token: 0x04005DB0 RID: 23984
			internal GameObject $mDrill$34411;

			// Token: 0x04005DB1 RID: 23985
			internal int $$switch$3922$34412;

			// Token: 0x04005DB2 RID: 23986
			internal int $i$34413;

			// Token: 0x04005DB3 RID: 23987
			internal int $hitLayer$34414;

			// Token: 0x04005DB4 RID: 23988
			internal UnityScript.Lang.Array $hitList$34415;

			// Token: 0x04005DB5 RID: 23989
			internal GameObject $hitObject$34416;

			// Token: 0x04005DB6 RID: 23990
			internal Vector3 $hitPos$34417;

			// Token: 0x04005DB7 RID: 23991
			internal IEnumerator $$iterator$9827$34418;

			// Token: 0x04005DB8 RID: 23992
			internal Vector3 $mPos$34419;

			// Token: 0x04005DB9 RID: 23993
			internal Vector3 $tDir$34420;

			// Token: 0x04005DBA RID: 23994
			internal BarrelBot $self_$34421;
		}
	}

	// Token: 0x02000E92 RID: 3730
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cannon$34425 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005491 RID: 21649 RVA: 0x00A45F04 File Offset: 0x00A44104
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cannon$34425(Vector3 mPos, Vector3 tDir, BarrelBot self_)
		{
			if (175847 - 453168 != -277321)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156830 - 239358 != -82527)
				{
					base..ctor();
					if (222765 - 361332 != -138566)
					{
						this.$mPos$34432 = mPos;
						if (29994 - 58931 == -28937)
						{
							this.$tDir$34433 = tDir;
							if (82880 - 366513 == -283633)
							{
								this.$self_$34434 = self_;
								if (197804 - 85647 == 112157)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x00A45FE0 File Offset: 0x00A441E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_cannon$34425.$(this.$mPos$34432, this.$tDir$34433, this.$self_$34434);
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x00A45FFC File Offset: 0x00A441FC
		internal static bool Qr4hLm59yTDYl6iocOrx()
		{
			return true;
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x00A46000 File Offset: 0x00A44200
		internal static bool dFCRNi59SYUZBKxoaKAc()
		{
			return false;
		}

		// Token: 0x04005DBB RID: 23995
		internal Vector3 $mPos$34432;

		// Token: 0x04005DBC RID: 23996
		internal Vector3 $tDir$34433;

		// Token: 0x04005DBD RID: 23997
		internal BarrelBot $self_$34434;

		// Token: 0x02000E93 RID: 3731
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005495 RID: 21653 RVA: 0x00A46004 File Offset: 0x00A44204
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BarrelBot self_)
			{
				if (143647 - 382352 != -238705)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196053 - 295381 == -99328)
					{
						base..ctor();
						if (224141 - 291839 == -67698)
						{
							this.$mPos$34429 = mPos;
							if (36366 - 305202 != -268835)
							{
								this.$tDir$34430 = tDir;
								if (74909 - 231648 == -156739)
								{
									this.$self_$34431 = self_;
									if (268488 - 439641 != -171152)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005496 RID: 21654 RVA: 0x00A460E0 File Offset: 0x00A442E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57 - 237858 != -237800)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_73B;
					case 2:
						if (this.$self_$34431.mChar.actionState != "attack")
						{
							goto IL_C3;
						}
						if (81336 - 573582 == -492245)
						{
							continue;
						}
						if (this.$self_$34431.mChar.myCommand != "cannon")
						{
							if (49606 - 108847 != -59241)
							{
								continue;
							}
							goto IL_C3;
						}
						else
						{
							if (!this.$self_$34431.mChar.isMine)
							{
								goto IL_63D;
							}
							if (58278 - 446964 == -388685)
							{
								continue;
							}
							this.$firePos$34427 = this.$self_$34431.transform.position + this.$self_$34431.transform.TransformDirection((float)0, 0.7f, 0.7f);
							if (134301 - 362254 == -227952)
							{
								continue;
							}
							this.$fireDir$34428 = this.$tDir$34430 - this.$self_$34431.transform.TransformDirection((float)0, 0.7f, 0.7f);
							if (110092 - 590424 != -480332)
							{
								continue;
							}
							this.$self_$34431.RPC_cannon_fire(this.$firePos$34427, this.$fireDir$34428, 0);
							if (159562 - 160425 == -862)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_63D;
							}
							if (26519 - 507403 != -480884)
							{
								continue;
							}
							this.$self_$34431.ActionEvent("RPC_cannon_fire", this.$firePos$34427, this.$fireDir$34428, 0);
							if (58663 - 106469 != -47805)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34431.mChar.actionState == "attack")
						{
							if (193704 - 556081 == -362376)
							{
								continue;
							}
							if (this.$self_$34431.mChar.myCommand == "cannon")
							{
								if (293187 - 10471 != 282716)
								{
									continue;
								}
								this.$self_$34431.mChar.actionState = "standby";
								if (86477 - 479624 != -393147)
								{
									continue;
								}
								this.$self_$34431.mChar.actionTime = Time.time;
								if (207091 - 383055 == -175963)
								{
									continue;
								}
								this.$self_$34431.mChar.myCommand = "none";
								if (147676 - 267151 == -119474)
								{
									continue;
								}
								if (!this.$self_$34431.mChar.isMine)
								{
									if (120605 - 136859 != -16254)
									{
										continue;
									}
									this.$self_$34431.mChar.nPosition = this.$self_$34431.transform.position;
									if (14154 - 149637 != -135483)
									{
										continue;
									}
									this.$self_$34431.mChar.oPosition = this.$self_$34431.transform.position;
									if (45788 - 327943 == -282154)
									{
										continue;
									}
									this.$self_$34431.mChar.nDirection = this.$self_$34431.transform.forward;
									if (260494 - 253558 == 6937)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (204630 - 148115 != 56515)
						{
							continue;
						}
						goto IL_73B;
					default:
						if (142819 - 66884 == 75936)
						{
							continue;
						}
						break;
					}
					this.$self_$34431.mChar.actionState = "attack";
					if (262937 - 232584 == 30353)
					{
						this.$self_$34431.mChar.actionTime = Time.time;
						if (228917 - 520767 != -291849)
						{
							this.$self_$34431.mChar.myCommand = "cannon";
							if (63703 - 174986 != -111282)
							{
								this.$self_$34431.mChar.addTimeOut("cannon", this.$self_$34431.mChar.agiAdjust((float)9));
								if (219472 - 257153 != -37680)
								{
									this.$self_$34431.transform.position = this.$mPos$34429;
									if (122282 - 340365 != -218082)
									{
										this.$self_$34431.transform.LookAt(this.$mPos$34429 + global::Math.vFlat(this.$tDir$34430));
										if (146370 - 494451 != -348080)
										{
											this.$self_$34431.animation.Play("cannon");
											if (150823 - 460536 == -309713)
											{
												this.$self_$34431.animation.wrapMode = WrapMode.Once;
												if (70738 - 82617 == -11879)
												{
													this.$self_$34431.mChar.vMovement = this.$self_$34431.transform.forward;
													if (265208 - 134159 != 131050)
													{
														this.$self_$34431.mChar.moveSpeed = (float)0;
														if (89015 - 497689 == -408674)
														{
															this.$mCannon$34426 = null;
															if (66470 - 517003 != -450532)
															{
																if (!this.$self_$34431.cannon)
																{
																	goto IL_41C;
																}
																if (135071 - 330850 == -195779)
																{
																	this.$mCannon$34426 = this.$self_$34431.mChar.createEffect(this.$self_$34431.cannon, this.$self_$34431.transform.position, this.$self_$34431.transform.rotation);
																	if (12078 - 258756 == -246678)
																	{
																		this.$mCannon$34426.transform.localScale = (0.7f + 0.1f * (float)this.$self_$34431.BarrelBotLv) * Vector3.one;
																		if (78801 - 142216 == -63415)
																		{
																			goto IL_41C;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_C3:
				goto IL_73B;
				Block_19:
				goto IL_63D;
				IL_41C:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_63D:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_73B:
				return false;
			}

			// Token: 0x06005497 RID: 21655 RVA: 0x00A4683C File Offset: 0x00A44A3C
			internal static bool rdYJw559oWkbfhbZUOCf()
			{
				return true;
			}

			// Token: 0x06005498 RID: 21656 RVA: 0x00A46840 File Offset: 0x00A44A40
			internal static bool rmIltB59EmAKBQpg7tfJ()
			{
				return false;
			}

			// Token: 0x04005DBE RID: 23998
			internal GameObject $mCannon$34426;

			// Token: 0x04005DBF RID: 23999
			internal Vector3 $firePos$34427;

			// Token: 0x04005DC0 RID: 24000
			internal Vector3 $fireDir$34428;

			// Token: 0x04005DC1 RID: 24001
			internal Vector3 $mPos$34429;

			// Token: 0x04005DC2 RID: 24002
			internal Vector3 $tDir$34430;

			// Token: 0x04005DC3 RID: 24003
			internal BarrelBot $self_$34431;
		}
	}

	// Token: 0x02000E94 RID: 3732
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cannonForm$34435 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005499 RID: 21657 RVA: 0x00A46844 File Offset: 0x00A44A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cannonForm$34435(Vector3 mPos, Vector3 tDir, int tID, BarrelBot self_)
		{
			if (265589 - 212238 != 53351)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160662 - 292667 == -132005)
				{
					base..ctor();
					if (96168 - 40606 != 55563)
					{
						this.$mPos$34446 = mPos;
						if (258972 - 28956 == 230016)
						{
							this.$tDir$34447 = tDir;
							if (150833 - 426787 == -275954)
							{
								this.$tID$34448 = tID;
								if (180605 - 402728 != -222122)
								{
									this.$self_$34449 = self_;
									if (137007 - 3941 == 133066)
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

		// Token: 0x0600549A RID: 21658 RVA: 0x00A46944 File Offset: 0x00A44B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_cannonForm$34435.$(this.$mPos$34446, this.$tDir$34447, this.$tID$34448, this.$self_$34449);
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x00A46964 File Offset: 0x00A44B64
		internal static bool VqOMOJ592vZoXuyqiaIV()
		{
			return true;
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00A46968 File Offset: 0x00A44B68
		internal static bool KProJ3598ajqxlI0Ndo3()
		{
			return false;
		}

		// Token: 0x04005DC4 RID: 24004
		internal Vector3 $mPos$34446;

		// Token: 0x04005DC5 RID: 24005
		internal Vector3 $tDir$34447;

		// Token: 0x04005DC6 RID: 24006
		internal int $tID$34448;

		// Token: 0x04005DC7 RID: 24007
		internal BarrelBot $self_$34449;

		// Token: 0x02000E95 RID: 3733
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600549D RID: 21661 RVA: 0x00A4696C File Offset: 0x00A44B6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, BarrelBot self_)
			{
				if (259532 - 44938 != 214594)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93734 - 104987 == -11253)
					{
						base..ctor();
						if (280493 - 163338 != 117156)
						{
							this.$mPos$34442 = mPos;
							if (285009 - 470465 != -185455)
							{
								this.$tDir$34443 = tDir;
								if (291834 - 379263 != -87428)
								{
									this.$tID$34444 = tID;
									if (111007 - 534623 == -423616)
									{
										this.$self_$34445 = self_;
										if (252083 - 165526 == 86557)
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

			// Token: 0x0600549E RID: 21662 RVA: 0x00A46A6C File Offset: 0x00A44C6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184488 - 177615 != 6873)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9D2;
					case 2:
						if (this.$self_$34445.mChar.actionState != "attack")
						{
							goto IL_47D;
						}
						if (74754 - 496429 != -421675)
						{
							continue;
						}
						if (this.$self_$34445.mChar.myCommand != "cannonForm")
						{
							if (243116 - 383695 != -140579)
							{
								continue;
							}
							goto IL_47D;
						}
						else
						{
							this.$self_$34445.animation.Play("cannonForm2");
							if (236524 - 402213 == -165688)
							{
								continue;
							}
							this.$self_$34445.animation.wrapMode = WrapMode.Loop;
							if (7895 - 232156 != -224261)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34444];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$34437 = (GameObject)obj2;
							if (120094 - 316550 == -196455)
							{
								continue;
							}
							this.$mCannonTime$34438 = Time.time + 0.5f;
							if (48300 - 353883 != -305583)
							{
								continue;
							}
							this.$mCannonCount$34439 = 0;
							if (256070 - 173369 != 82702)
							{
								goto IL_1E6;
							}
							continue;
						}
						break;
					case 3:
						goto IL_1E6;
					case 4:
						if (this.$self_$34445.mChar.actionState == "attack")
						{
							if (157697 - 453819 == -296121)
							{
								continue;
							}
							if (this.$self_$34445.mChar.myCommand == "cannonForm")
							{
								if (49334 - 77712 != -28378)
								{
									continue;
								}
								this.$self_$34445.mChar.actionState = "standby";
								if (15903 - 562126 != -546223)
								{
									continue;
								}
								this.$self_$34445.mChar.actionTime = Time.time;
								if (291876 - 236683 != 55193)
								{
									continue;
								}
								this.$self_$34445.mChar.myCommand = "none";
								if (146051 - 36716 == 109336)
								{
									continue;
								}
								if (!this.$self_$34445.mChar.isMine)
								{
									if (131434 - 16641 != 114793)
									{
										continue;
									}
									this.$self_$34445.mChar.nPosition = this.$self_$34445.transform.position;
									if (248780 - 535802 == -287021)
									{
										continue;
									}
									this.$self_$34445.mChar.oPosition = this.$self_$34445.transform.position;
									if (231240 - 166732 == 64509)
									{
										continue;
									}
									this.$self_$34445.mChar.nDirection = this.$self_$34445.transform.forward;
									if (111364 - 1257 == 110108)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (48106 - 129765 != -81658)
						{
							goto Block_4;
						}
						continue;
					default:
						if (130963 - 306910 == -175946)
						{
							continue;
						}
						break;
					}
					this.$self_$34445.mChar.actionState = "attack";
					if (252106 - 423102 != -170996)
					{
						continue;
					}
					this.$self_$34445.mChar.actionTime = Time.time;
					if (202786 - 265207 != -62421)
					{
						continue;
					}
					this.$self_$34445.mChar.myCommand = "cannonForm";
					if (125127 - 369080 != -243953)
					{
						continue;
					}
					this.$self_$34445.mChar.addTimeOut("cannonForm", this.$self_$34445.mChar.agiAdjust((float)90));
					if (62913 - 249323 != -186410)
					{
						continue;
					}
					this.$self_$34445.transform.position = this.$mPos$34442;
					if (166563 - 464277 == -297713)
					{
						continue;
					}
					this.$self_$34445.transform.LookAt(this.$mPos$34442 + global::Math.vFlat(this.$tDir$34443));
					if (132654 - 557002 != -424348)
					{
						continue;
					}
					this.$self_$34445.animation.Play("cannonForm1");
					if (29750 - 596132 != -566382)
					{
						continue;
					}
					this.$self_$34445.animation.wrapMode = WrapMode.Once;
					if (144077 - 286186 == -142108)
					{
						continue;
					}
					this.$self_$34445.mChar.vMovement = this.$self_$34445.transform.forward;
					if (272808 - 8699 == 264110)
					{
						continue;
					}
					this.$self_$34445.mChar.moveSpeed = (float)0;
					if (249041 - 217450 != 31591)
					{
						continue;
					}
					if (this.$self_$34445.cannonForm_ring)
					{
						if (182542 - 191444 != -8902)
						{
							continue;
						}
						this.$mCannonForm_ring$34436 = this.$self_$34445.mChar.createEffect(this.$self_$34445.cannonForm_ring, this.$self_$34445.transform.position, this.$self_$34445.transform.rotation);
						if (289787 - 160763 == 129025)
						{
							continue;
						}
						if (!this.$mCannonForm_ring$34436)
						{
							goto IL_454;
						}
						if (151464 - 149961 == 1504)
						{
							continue;
						}
						this.$mCannonForm_ring$34436.transform.localScale = (0.7f + 0.1f * (float)this.$self_$34445.BarrelBotLv) * Vector3.one;
						if (243348 - 414822 != -171474)
						{
							continue;
						}
						goto IL_454;
					}
					else
					{
						Debug.LogError("Missing cannonForm_ring effect");
						if (38789 - 403281 != -364491)
						{
							goto Block_26;
						}
						continue;
					}
					IL_1E6:
					if (!this.$tObject$34437)
					{
						goto IL_A2;
					}
					if (192219 - 219193 == -26974)
					{
						if (this.$mCannonCount$34439 >= 10)
						{
							if (222360 - 76316 != 146045)
							{
								goto Block_57;
							}
						}
						else
						{
							if (this.$tObject$34437)
							{
								if (110992 - 373820 == -262827)
								{
									continue;
								}
								this.$self_$34445.transform.LookAt(global::Math.cFlat(this.$tObject$34437.transform.position, this.$self_$34445.transform.position.y));
								if (147229 - 353419 == -206189)
								{
									continue;
								}
							}
							if (this.$mCannonTime$34438 >= Time.time)
							{
								goto IL_1DA;
							}
							if (225881 - 401256 == -175375)
							{
								this.$mCannonTime$34438 = Time.time + 0.5f;
								if (53234 - 547043 != -493808)
								{
									this.$mCannonCount$34439++;
									if (8218 - 155760 == -147542)
									{
										if (!this.$self_$34445.mChar.isMine)
										{
											goto IL_1DA;
										}
										if (256687 - 466659 == -209972)
										{
											this.$firePos$34440 = this.$self_$34445.transform.position + this.$self_$34445.transform.TransformDirection((float)0, 0.5f, 0.7f);
											if (207447 - 135898 != 71550)
											{
												this.$fireDir$34441 = this.$tObject$34437.collider.bounds.center - this.$firePos$34440;
												if (3008 - 373194 != -370185)
												{
													this.$self_$34445.RPC_cannon_fire(this.$firePos$34440, this.$fireDir$34441, this.$tID$34444);
													if (282761 - 281273 != 1489)
													{
														if (!PhotonClient.IsInitialized())
														{
															goto IL_1DA;
														}
														if (81275 - 538309 != -457033)
														{
															this.$self_$34445.ActionEvent("RPC_cannon_fire", this.$firePos$34440, this.$fireDir$34441, this.$tID$34444);
															if (253290 - 176993 == 76297)
															{
																goto IL_1DA;
															}
														}
													}
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
				goto IL_9D2;
				IL_A2:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_1DA:
				return this.YieldDefault(3);
				IL_454:
				Block_26:
				goto IL_75F;
				IL_47D:
				goto IL_9D2;
				IL_75F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_57:
				goto IL_A2;
				IL_9D2:
				return false;
			}

			// Token: 0x0600549F RID: 21663 RVA: 0x00A47460 File Offset: 0x00A45660
			internal static bool kQ1YQN59ZIWmaYlLyZHe()
			{
				return true;
			}

			// Token: 0x060054A0 RID: 21664 RVA: 0x00A47464 File Offset: 0x00A45664
			internal static bool Fg6Hjw59Cag1ac3XtiT7()
			{
				return false;
			}

			// Token: 0x04005DC8 RID: 24008
			internal GameObject $mCannonForm_ring$34436;

			// Token: 0x04005DC9 RID: 24009
			internal GameObject $tObject$34437;

			// Token: 0x04005DCA RID: 24010
			internal float $mCannonTime$34438;

			// Token: 0x04005DCB RID: 24011
			internal int $mCannonCount$34439;

			// Token: 0x04005DCC RID: 24012
			internal Vector3 $firePos$34440;

			// Token: 0x04005DCD RID: 24013
			internal Vector3 $fireDir$34441;

			// Token: 0x04005DCE RID: 24014
			internal Vector3 $mPos$34442;

			// Token: 0x04005DCF RID: 24015
			internal Vector3 $tDir$34443;

			// Token: 0x04005DD0 RID: 24016
			internal int $tID$34444;

			// Token: 0x04005DD1 RID: 24017
			internal BarrelBot $self_$34445;
		}
	}

	// Token: 0x02000E96 RID: 3734
	[CompilerGenerated]
	[Serializable]
	internal sealed class $create$34450 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060054A1 RID: 21665 RVA: 0x00A47468 File Offset: 0x00A45668
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $create$34450(int nCreatorID, BarrelBot self_)
		{
			if (213433 - 209748 != 3686)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220921 - 9010 == 211911)
				{
					base..ctor();
					if (222161 - 95566 == 126595)
					{
						this.$nCreatorID$34453 = nCreatorID;
						if (216757 - 385217 == -168460)
						{
							this.$self_$34454 = self_;
							if (273315 - 552970 == -279655)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x00A47524 File Offset: 0x00A45724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$create$34450.$(this.$nCreatorID$34453, this.$self_$34454);
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x00A47538 File Offset: 0x00A45738
		internal static bool rgBHLa59LHbNEl7UIcPD()
		{
			return true;
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x00A4753C File Offset: 0x00A4573C
		internal static bool hGqjJQ59OTL6XpXjUv5r()
		{
			return false;
		}

		// Token: 0x04005DD2 RID: 24018
		internal int $nCreatorID$34453;

		// Token: 0x04005DD3 RID: 24019
		internal BarrelBot $self_$34454;

		// Token: 0x02000E97 RID: 3735
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060054A5 RID: 21669 RVA: 0x00A47540 File Offset: 0x00A45740
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCreatorID, BarrelBot self_)
			{
				if (14771 - 451439 != -436668)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (122853 - 421492 == -298639)
					{
						base..ctor();
						if (5687 - 452499 == -446812)
						{
							this.$nCreatorID$34451 = nCreatorID;
							if (55036 - 581497 == -526461)
							{
								this.$self_$34452 = self_;
								if (226770 - 208210 == 18560)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060054A6 RID: 21670 RVA: 0x00A475FC File Offset: 0x00A457FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15004 - 380954 != -365949)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5A6;
					case 2:
						if (this.$self_$34452.mChar.actionState == "attack")
						{
							if (205954 - 246212 == -40257)
							{
								continue;
							}
							if (this.$self_$34452.mChar.myCommand == "create")
							{
								if (57485 - 236820 == -179334)
								{
									continue;
								}
								this.$self_$34452.mChar.actionState = "standby";
								if (51346 - 271913 == -220566)
								{
									continue;
								}
								this.$self_$34452.mChar.actionTime = Time.time;
								if (242689 - 230722 == 11968)
								{
									continue;
								}
								this.$self_$34452.mChar.myCommand = "none";
								if (248932 - 508969 == -260036)
								{
									continue;
								}
								if (!this.$self_$34452.mChar.isMine)
								{
									if (37360 - 399138 == -361777)
									{
										continue;
									}
									this.$self_$34452.mChar.nPosition = this.$self_$34452.transform.position;
									if (193021 - 414521 == -221499)
									{
										continue;
									}
									this.$self_$34452.mChar.oPosition = this.$self_$34452.transform.position;
									if (60164 - 89541 == -29376)
									{
										continue;
									}
									this.$self_$34452.mChar.nDirection = this.$self_$34452.transform.forward;
									if (40721 - 394760 == -354038)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (243912 - 31859 != 212054)
						{
							goto Block_19;
						}
						continue;
					default:
						if (149983 - 66003 == 83981)
						{
							continue;
						}
						break;
					}
					this.$self_$34452.isCreate = true;
					if (139606 - 549855 == -410249)
					{
						BarrelBot barrelBot = this.$self_$34452;
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$nCreatorID$34451];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						barrelBot.mCreator = (GameObject)obj2;
						if (201578 - 490790 == -289212)
						{
							this.$self_$34452.mCreatorChar = (CharacterControl)this.$self_$34452.mCreator.GetComponent(typeof(CharacterControl));
							if (130752 - 506865 == -376113)
							{
								this.$self_$34452.gameObject.layer = this.$self_$34452.mCreator.layer;
								if (179780 - 256695 != -76914)
								{
									this.$self_$34452.mChar.mOriginalLayer = this.$self_$34452.mCreator.layer;
									if (118847 - 414155 == -295308)
									{
										Camera.main.SendMessage("onSummon", this.$self_$34452.gameObject, SendMessageOptions.DontRequireReceiver);
										if (222699 - 335785 == -113086)
										{
											this.$self_$34452.mChar.actionState = "attack";
											if (72215 - 472106 == -399891)
											{
												this.$self_$34452.mChar.actionTime = Time.time;
												if (254178 - 63801 != 190378)
												{
													this.$self_$34452.mChar.myCommand = "create";
													if (156299 - 255288 == -98989)
													{
														if (this.$self_$34452.create_fx)
														{
															if (242554 - 174136 != 68418)
															{
																continue;
															}
															this.$self_$34452.audio.PlayOneShot(this.$self_$34452.create_fx);
															if (13428 - 40797 == -27368)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find create_fx effect");
															if (197734 - 36243 == 161492)
															{
																continue;
															}
														}
														this.$self_$34452.animation.Play("getUp");
														if (210856 - 465145 != -254288)
														{
															this.$self_$34452.animation.wrapMode = WrapMode.Once;
															if (207498 - 263201 != -55702)
															{
																this.$self_$34452.mChar.vMovement = this.$self_$34452.transform.forward;
																if (58791 - 16910 != 41882)
																{
																	this.$self_$34452.mChar.moveSpeed = (float)0;
																	if (195172 - 478876 != -283703)
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
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_19:
				IL_5A6:
				return false;
			}

			// Token: 0x060054A7 RID: 21671 RVA: 0x00A47BC4 File Offset: 0x00A45DC4
			internal static bool KxICnw59mNWFUJ9BiiVV()
			{
				return true;
			}

			// Token: 0x060054A8 RID: 21672 RVA: 0x00A47BC8 File Offset: 0x00A45DC8
			internal static bool vIJ80B59F0L7c0OJvr6Z()
			{
				return false;
			}

			// Token: 0x04005DD4 RID: 24020
			internal int $nCreatorID$34451;

			// Token: 0x04005DD5 RID: 24021
			internal BarrelBot $self_$34452;
		}
	}

	// Token: 0x02000E98 RID: 3736
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$34455 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060054A9 RID: 21673 RVA: 0x00A47BCC File Offset: 0x00A45DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$34455(UnityScript.Lang.Array nArray, BarrelBot self_)
		{
			if (136552 - 173686 != -37133)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269922 - 378754 == -108832)
				{
					base..ctor();
					if (219875 - 581147 != -361271)
					{
						this.$nArray$34460 = nArray;
						if (290992 - 164988 == 126004)
						{
							this.$self_$34461 = self_;
							if (144157 - 2999 != 141159)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x00A47C88 File Offset: 0x00A45E88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_ko$34455.$(this.$nArray$34460, this.$self_$34461);
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x00A47C9C File Offset: 0x00A45E9C
		internal static bool RB3HcT59M1CIOgNXViuk()
		{
			return true;
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x00A47CA0 File Offset: 0x00A45EA0
		internal static bool sctUmu59xjxaehwQ6BKh()
		{
			return false;
		}

		// Token: 0x04005DD6 RID: 24022
		internal UnityScript.Lang.Array $nArray$34460;

		// Token: 0x04005DD7 RID: 24023
		internal BarrelBot $self_$34461;

		// Token: 0x02000E99 RID: 3737
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060054AD RID: 21677 RVA: 0x00A47CA4 File Offset: 0x00A45EA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BarrelBot self_)
			{
				if (158480 - 370050 != -211570)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19084 - 268554 == -249470)
					{
						base..ctor();
						if (53861 - 273847 == -219986)
						{
							this.$nArray$34458 = nArray;
							if (174550 - 25735 == 148815)
							{
								this.$self_$34459 = self_;
								if (104720 - 200472 == -95752)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060054AE RID: 21678 RVA: 0x00A47D60 File Offset: 0x00A45F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282566 - 5080 != 277487)
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
						if (this.$self_$34459.mChar.actionState != "ko")
						{
							if (143003 - 523049 != -380045)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$34459.animation.Play("getUp");
							if (80191 - 8684 == 71508)
							{
								continue;
							}
							this.$self_$34459.animation.wrapMode = WrapMode.Once;
							if (298939 - 474226 != -175287)
							{
								continue;
							}
							goto IL_3A8;
						}
						break;
					case 3:
						if (this.$self_$34459.mChar.actionState != "ko")
						{
							if (97533 - 260583 != -163049)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$self_$34459.mChar.actionState = "standby";
							if (3995 - 313227 == -309231)
							{
								continue;
							}
							this.$self_$34459.mChar.actionTime = Time.time;
							if (158529 - 457132 != -298603)
							{
								continue;
							}
							this.$self_$34459.mChar.myCommand = "none";
							if (190956 - 72931 == 118026)
							{
								continue;
							}
							this.$self_$34459.mChar.ko = this.$self_$34459.mChar.mko;
							if (233074 - 591874 != -358800)
							{
								continue;
							}
							this.YieldDefault(1);
							if (139765 - 409471 != -269705)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					default:
						if (242570 - 456904 == -214333)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34459.mChar.actionState == "ko")
					{
						break;
					}
					if (182783 - 386372 == -203589)
					{
						if (this.$self_$34459.mChar.actionState == "dead")
						{
							if (222795 - 543997 == -321202)
							{
								break;
							}
						}
						else
						{
							this.$mPos$34456 = (Vector3)this.$nArray$34458[0];
							if (41395 - 261750 == -220355)
							{
								this.$mDir$34457 = (Vector3)this.$nArray$34458[1];
								if (258654 - 241529 != 17126)
								{
									this.$self_$34459.mChar.ko = 0;
									if (96083 - 117516 != -21432)
									{
										this.$self_$34459.mChar.actionState = "ko";
										if (131378 - 485712 != -354333)
										{
											this.$self_$34459.mChar.actionTime = Time.time;
											if (153348 - 43316 == 110032)
											{
												this.$self_$34459.mChar.myCommand = "none";
												if (280045 - 427515 != -147469)
												{
													this.$self_$34459.mChar.vMovement = Vector3.zero;
													if (19983 - 132601 != -112617)
													{
														this.$self_$34459.mChar.moveSpeed = (float)0;
														if (156577 - 597283 == -440706)
														{
															this.$self_$34459.animation.Play("ko");
															if (42423 - 164724 != -122300)
															{
																this.$self_$34459.animation.wrapMode = WrapMode.Once;
																if (173465 - 105951 != 67515)
																{
																	goto Block_17;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_14:
				Block_15:
				goto IL_48C;
				Block_17:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3A8:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_24:
				IL_48C:
				return false;
			}

			// Token: 0x060054AF RID: 21679 RVA: 0x00A4820C File Offset: 0x00A4640C
			internal static bool znKuhT59g4GbXrgPwDA1()
			{
				return true;
			}

			// Token: 0x060054B0 RID: 21680 RVA: 0x00A48210 File Offset: 0x00A46410
			internal static bool TS2fgo59fkb7vYs7h8jt()
			{
				return false;
			}

			// Token: 0x04005DD8 RID: 24024
			internal Vector3 $mPos$34456;

			// Token: 0x04005DD9 RID: 24025
			internal Vector3 $mDir$34457;

			// Token: 0x04005DDA RID: 24026
			internal UnityScript.Lang.Array $nArray$34458;

			// Token: 0x04005DDB RID: 24027
			internal BarrelBot $self_$34459;
		}
	}

	// Token: 0x02000E9A RID: 3738
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34462 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060054B1 RID: 21681 RVA: 0x00A48214 File Offset: 0x00A46414
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34462(UnityScript.Lang.Array nArray, BarrelBot self_)
		{
			if (270559 - 20117 != 250443)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65303 - 496897 == -431594)
				{
					base..ctor();
					if (154515 - 285660 != -131144)
					{
						this.$nArray$34467 = nArray;
						if (217619 - 547324 == -329705)
						{
							this.$self_$34468 = self_;
							if (172567 - 427136 == -254569)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x00A482D0 File Offset: 0x00A464D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BarrelBot.$RPC_dead$34462.$(this.$nArray$34467, this.$self_$34468);
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00A482E4 File Offset: 0x00A464E4
		internal static bool DR3bKI59nkLYpQiKLJWC()
		{
			return true;
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x00A482E8 File Offset: 0x00A464E8
		internal static bool lFmBRp596onR86Ze60XQ()
		{
			return false;
		}

		// Token: 0x04005DDC RID: 24028
		internal UnityScript.Lang.Array $nArray$34467;

		// Token: 0x04005DDD RID: 24029
		internal BarrelBot $self_$34468;

		// Token: 0x02000E9B RID: 3739
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060054B5 RID: 21685 RVA: 0x00A482EC File Offset: 0x00A464EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BarrelBot self_)
			{
				if (100307 - 322432 != -222125)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9594 - 357657 == -348063)
					{
						base..ctor();
						if (226641 - 428173 == -201532)
						{
							this.$nArray$34465 = nArray;
							if (224290 - 177329 == 46961)
							{
								this.$self_$34466 = self_;
								if (184789 - 23805 == 160984)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060054B6 RID: 21686 RVA: 0x00A483A8 File Offset: 0x00A465A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (8269 - 313592 != -305323)
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
						if (this.$self_$34466.mChar.actionState != "dead")
						{
							if (262431 - 570448 != -308016)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34466.mChar.isPlayer)
							{
								if (72371 - 236235 != -163864)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$34466.gameObject);
								if (250224 - 541957 != -291733)
								{
									continue;
								}
							}
							else if (this.$self_$34466.mChar.isMine)
							{
								if (98632 - 420583 != -321951)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34466.gameObject);
								if (40682 - 80661 != -39979)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (197854 - 115630 != 82225)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (155863 - 562633 != -406770)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34466.mChar.actionState == "dead")
					{
						if (191238 - 77014 != 114225)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$34463 = (Vector3)this.$nArray$34465[0];
						if (187970 - 312864 == -124894)
						{
							this.$myDirection$34464 = (Vector3)this.$nArray$34465[1];
							if (53859 - 440315 != -386455)
							{
								this.$self_$34466.transform.position = this.$myPosition$34463;
								if (123633 - 552820 == -429187)
								{
									this.$self_$34466.transform.LookAt(this.$myPosition$34463 + this.$myDirection$34464);
									if (36909 - 278956 == -242047)
									{
										this.$self_$34466.mChar.hp = 0;
										if (67266 - 521235 != -453968)
										{
											this.$self_$34466.mChar.actionState = "dead";
											if (14805 - 547 == 14258)
											{
												this.$self_$34466.mChar.actionTime = Time.time;
												if (222334 - 380668 == -158334)
												{
													this.$self_$34466.mChar.myCommand = "none";
													if (105834 - 101644 != 4191)
													{
														this.$self_$34466.mChar.vMovement = Vector3.zero;
														if (108649 - 284100 == -175451)
														{
															this.$self_$34466.mChar.moveSpeed = (float)0;
															if (92797 - 387561 == -294764)
															{
																this.$self_$34466.animation.Rewind();
																if (138515 - 168595 != -30079)
																{
																	this.$self_$34466.animation.Play("ko");
																	if (192042 - 180891 != 11152)
																	{
																		this.$self_$34466.animation.wrapMode = WrapMode.Once;
																		if (239191 - 257042 != -17850)
																		{
																			goto Block_18;
																		}
																	}
																}
															}
														}
													}
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
				Block_15:
				goto IL_42F;
				Block_18:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060054B7 RID: 21687 RVA: 0x00A487F8 File Offset: 0x00A469F8
			internal static bool rTGLTH59i6QTKWMrOT61()
			{
				return true;
			}

			// Token: 0x060054B8 RID: 21688 RVA: 0x00A487FC File Offset: 0x00A469FC
			internal static bool E8IrRO59Kct2VMMc5ZWY()
			{
				return false;
			}

			// Token: 0x04005DDE RID: 24030
			internal Vector3 $myPosition$34463;

			// Token: 0x04005DDF RID: 24031
			internal Vector3 $myDirection$34464;

			// Token: 0x04005DE0 RID: 24032
			internal UnityScript.Lang.Array $nArray$34465;

			// Token: 0x04005DE1 RID: 24033
			internal BarrelBot $self_$34466;
		}
	}
}
