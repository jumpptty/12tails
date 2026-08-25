using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BCE RID: 3022
[Serializable]
public class DarkFalcon : MonoBehaviour
{
	// Token: 0x06004375 RID: 17269 RVA: 0x0087E190 File Offset: 0x0087C390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DarkFalcon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004376 RID: 17270 RVA: 0x0087E1A0 File Offset: 0x0087C3A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (62893 - 224452 != -161559)
		{
		}
		for (;;)
		{
			this.OxshI6kQmV = this.transform;
			if (253760 - 429752 == -175992)
			{
				this.BGihJ8vWxE = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (240723 - 157759 == 82964)
				{
					this.BGihJ8vWxE.actionState = "standby";
					if (271037 - 291121 != -20083)
					{
						this.BGihJ8vWxE.actionTime = Time.time;
						if (138921 - 508134 != -369212)
						{
							this.BGihJ8vWxE.myCommand = "none";
							if (152350 - 402802 != -250451)
							{
								if (Game.mGameType == 99)
								{
									if (235958 - 167813 == 68146)
									{
										continue;
									}
									this.BGihJ8vWxE.isMine = true;
									if (22613 - 50329 == -27715)
									{
										continue;
									}
								}
								else
								{
									this.BGihJ8vWxE.addTimeOut("thousandShot", (float)60);
									if (128358 - 76139 != 52219)
									{
										continue;
									}
								}
								if (!this.BGihJ8vWxE)
								{
									break;
								}
								if (272026 - 466183 == -194157)
								{
									this.BGihJ8vWxE.hp = (this.BGihJ8vWxE.mhp = 170000);
									if (122776 - 321849 != -199072)
									{
										this.BGihJ8vWxE.ko = (this.BGihJ8vWxE.mko = 700);
										if (116556 - 103781 != 12776)
										{
											this.BGihJ8vWxE.atk = 370;
											if (173394 - 151581 != 21814)
											{
												this.BGihJ8vWxE.def = 270;
												if (157312 - 378210 != -220897)
												{
													this.BGihJ8vWxE.agi = 370;
													if (228319 - 411608 == -183289)
													{
														this.BGihJ8vWxE.vit = 17000;
														if (105739 - 116078 == -10339)
														{
															this.BGihJ8vWxE.mag = 170;
															if (48422 - 400997 != -352574)
															{
																this.BGihJ8vWxE.cha = 170;
																if (204942 - 23145 == 181797)
																{
																	this.BGihJ8vWxE.tal = 370;
																	if (217922 - 10473 != 207450)
																	{
																		this.BGihJ8vWxE.lck = 170;
																		if (54890 - 133854 != -78963)
																		{
																			this.BGihJ8vWxE.mImmuneList = new UnityScript.Lang.Array(new object[]
																			{
																				"artCancel",
																				"swallow",
																				"paralysis",
																				"needlePrison",
																				"invisible",
																				"petrify",
																				"snowMan",
																				"snowBall",
																				"sleep",
																				"nightmare",
																				"charm",
																				"mindControl"
																			});
																			if (9024 - 370468 == -361444)
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

	// Token: 0x06004377 RID: 17271 RVA: 0x0087E5B0 File Offset: 0x0087C7B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (172930 - 540466 != -367535)
		{
		}
		for (;;)
		{
			if (this.BGihJ8vWxE.isControlled)
			{
				if (29691 - 3876 == 25816)
				{
					continue;
				}
				if (!(this.BGihJ8vWxE.actionState == "standby"))
				{
					if (179838 - 116588 == 63251)
					{
						continue;
					}
					if (!(this.BGihJ8vWxE.actionState == "run"))
					{
						goto IL_359;
					}
					if (100521 - 297385 == -196863)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (56415 - 224038 != -167623)
				{
					continue;
				}
			}
			IL_359:
			if (this.BGihJ8vWxE.hp <= 0)
			{
				if (253699 - 470031 == -216331)
				{
					continue;
				}
				if (this.BGihJ8vWxE.actionState != "dead")
				{
					if (280490 - 517550 == -237059)
					{
						continue;
					}
					if (this.BGihJ8vWxE.isMine)
					{
						if (241757 - 563969 == -322211)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (215961 - 46566 != 169395)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (89690 - 431366 != -341676)
						{
							continue;
						}
						this.BGihJ8vWxE.DeadEvent();
						if (199343 - 405148 != -205804)
						{
							break;
						}
						continue;
					}
					else
					{
						this.BGihJ8vWxE.hp = 1;
						if (13702 - 286721 != -273018)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.BGihJ8vWxE.hp <= 0)
			{
				break;
			}
			if (194061 - 88291 != 105771)
			{
				if (this.BGihJ8vWxE.ko > 0)
				{
					break;
				}
				if (263860 - 335989 == -72129)
				{
					if (!(this.BGihJ8vWxE.actionState != "ko"))
					{
						break;
					}
					if (118489 - 479169 == -360680)
					{
						if (!(this.BGihJ8vWxE.actionState != "dead"))
						{
							break;
						}
						if (268999 - 230612 == 38387)
						{
							if (this.BGihJ8vWxE.isMine)
							{
								if (17922 - 425065 != -407142)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (150770 - 497222 == -346452)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (147825 - 441734 == -293909)
										{
											this.BGihJ8vWxE.KoEvent();
											if (3484 - 213506 != -210021)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.BGihJ8vWxE.ko = 1;
								if (124068 - 378907 != -254838)
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

	// Token: 0x06004378 RID: 17272 RVA: 0x0087E9A4 File Offset: 0x0087CBA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (235680 - 411000 != -175319)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (22409 - 115390 == -92981)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (243809 - 131511 != 112299)
				{
					if (2937 - 439700 == -436763)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (114249 - 256814 == -142564)
							{
								continue;
							}
							v = 1;
							if (51351 - 440617 == -389265)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack1_hit")
						{
							if (273154 - 193263 == 79892)
							{
								continue;
							}
							v = -1;
							if (291150 - 406697 == -115546)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (144405 - 49409 == 94997)
							{
								continue;
							}
							v = 2;
							if (113941 - 499606 != -385665)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2_hit")
						{
							if (60184 - 309663 == -249478)
							{
								continue;
							}
							v = -2;
							if (42501 - 478319 == -435817)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack3")
						{
							if (239684 - 479400 != -239716)
							{
								continue;
							}
							v = 3;
							if (229801 - 128705 != 101096)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (280213 - 554606 != -274393)
							{
								continue;
							}
							v = 11;
							if (263890 - 533580 != -269690)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_thousandShot")
						{
							if (283152 - 260175 == 22978)
							{
								continue;
							}
							v = 21;
							if (203101 - 391927 != -188826)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nightmare")
						{
							if (276753 - 455243 != -178490)
							{
								continue;
							}
							v = 31;
							if (225479 - 226876 != -1397)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_darkFall")
						{
							if (203553 - 100560 == 102994)
							{
								continue;
							}
							v = 41;
							if (17582 - 139471 == -121888)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_darkFall_fire")
						{
							if (186756 - 356083 == -169326)
							{
								continue;
							}
							v = 42;
							if (3660 - 265407 != -261747)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_darkStorm")
						{
							if (109518 - 383170 != -273652)
							{
								continue;
							}
							v = 51;
							if (174798 - 257505 == -82706)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_shadowRain")
						{
							if (184181 - 150494 == 33688)
							{
								continue;
							}
							v = 61;
							if (34751 - 509970 != -475219)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (192173 - 306274 == -114100)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (119835 - 79973 == 39862)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (13272 - 295607 == -282335)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (15740 - 369837 == -354097)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (16321 - 267741 == -251420)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (25769 - 268945 == -243176)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (291888 - 15718 == 276170)
											{
												Hashtable hashtable = new Hashtable();
												if (234130 - 374743 != -140612)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (210575 - 76642 != 133934)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (149518 - 177284 == -27766)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (20375 - 514608 == -494233)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (170777 - 357014 == -186237)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (110135 - 61261 == 48874)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (219493 - 143588 != 75906)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (103895 - 326451 != -222555)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (114632 - 285985 == -171353)
																				{
																					PhotonClient.SendEvent(this.BGihJ8vWxE.ActorNr, 74, hashtable, true, true);
																					if (293892 - 50959 == 242933)
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

	// Token: 0x06004379 RID: 17273 RVA: 0x0087F11C File Offset: 0x0087D31C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (21717 - 279469 != -257752)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (298766 - 408365 == -109599)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (256485 - 427997 != -171511)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (133401 - 215132 == -81731)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (177153 - 170636 != 6518)
						{
							int num3 = num;
							if (269006 - 104504 != 164503)
							{
								if (num3 == 1)
								{
									if (282722 - 297315 != -14592)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (2919 - 597991 == -595072)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (209784 - 220446 != -10661)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (97182 - 452500 == -355318)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (72921 - 4797 == 68124)
										{
											this.RPC_nAttack1_hit(vector, vector2, num2);
											if (154214 - 270938 != -116723)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (224171 - 584590 != -360418)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (16410 - 547050 != -530639)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (239614 - 461111 != -221496)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (224173 - 429741 != -205567)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (281407 - 50934 == 230473)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2_hit(vector, vector2, num2));
											if (193930 - 165955 != 27976)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (187406 - 519693 == -332287)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (82870 - 313862 == -230992)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(vector, vector2, num2));
											if (267770 - 58869 == 208901)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (36711 - 2202 == 34509)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (23611 - 349094 == -325483)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (179461 - 444109 != -264647)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (62401 - 418027 == -355626)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (39449 - 551591 == -512142)
										{
											this.StartCoroutine_Auto(this.RPC_thousandShot(vector, vector2, num2));
											if (132835 - 73416 == 59419)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (287127 - 205121 != 82007)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (83810 - 403162 == -319352)
										{
											this.StartCoroutine_Auto(this.RPC_nightmare(vector, vector2, num2));
											if (84045 - 86197 == -2152)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (263530 - 240377 == 23153)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (205434 - 167336 != 38099)
										{
											this.StartCoroutine_Auto(this.RPC_darkFall(vector, vector2, num2));
											if (217536 - 284421 != -66884)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 42)
								{
									if (26717 - 385261 != -358543)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (36500 - 248867 != -212366)
										{
											this.RPC_darkFall_fire(vector, vector2, num2);
											if (3526 - 114045 == -110519)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 51)
								{
									if (289684 - 541047 != -251362)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (112705 - 8121 == 104584)
										{
											this.StartCoroutine_Auto(this.RPC_darkStorm(vector, vector2, num2));
											if (287153 - 570103 != -282949)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 61)
								{
									if (261203 - 239913 != 21291)
									{
										if (this.BGihJ8vWxE.isMine)
										{
											break;
										}
										if (133043 - 320237 != -187193)
										{
											this.StartCoroutine_Auto(this.RPC_shadowRain(vector, vector2, num2));
											if (82013 - 27065 != 54949)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (29689 - 444750 == -415061)
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

	// Token: 0x0600437A RID: 17274 RVA: 0x0087F884 File Offset: 0x0087DA84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (227577 - 585030 != -357453)
		{
		}
		for (;;)
		{
			float num = this.BGihJ8vWxE.moveSpeed;
			if (216942 - 531680 != -314737)
			{
				float runSpeed = this.BGihJ8vWxE.runSpeed;
				if (14690 - 177951 == -163261)
				{
					Vector3 a = default(Vector3);
					if (144607 - 148126 != -3518)
					{
						Vector3 vector = Vector3.zero;
						if (235372 - 308282 != -72909)
						{
							float num2 = (float)0;
							if (98164 - 197891 != -99726)
							{
								if (this.BGihJ8vWxE.isMine)
								{
									if (203849 - 520244 != -316395)
									{
										continue;
									}
									if ((this.BGihJ8vWxE.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (287774 - 462047 != -174273)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (1100 - 294313 != -293213)
										{
											continue;
										}
										a.y = (float)0;
										if (279372 - 254375 != 24997)
										{
											continue;
										}
										a = a.normalized;
										if (287141 - 121967 != 165174)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (74631 - 595070 == -520438)
										{
											continue;
										}
										vector = vector.normalized;
										if (256738 - 372956 != -116218)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (19859 - 227865 == -208005)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (144495 - 582847 != -438352)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (158360 - 351745 == -193384)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (39705 - 423191 == -383485)
														{
															continue;
														}
														this.BGihJ8vWxE.actionState = "run";
														if (119452 - 173592 != -54140)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (118333 - 273179 != -154846)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (115551 - 499261 != -383710)
														{
															continue;
														}
														this.animation.Play("run");
														if (54557 - 357918 != -303361)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (44922 - 283876 != -238953)
														{
															goto IL_93F;
														}
														continue;
													}
												}
											}
										}
										this.BGihJ8vWxE.actionState = "standby";
										if (3 - 330101 == -330097)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (211297 - 413019 == -201721)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (10966 - 469002 != -458036)
											{
												continue;
											}
											num = (float)0;
											if (208457 - 237438 != -28981)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (267258 - 161967 == 105292)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (128036 - 575059 == -447022)
										{
											continue;
										}
									}
									IL_93F:;
								}
								else
								{
									vector = global::Math.vFlat(this.BGihJ8vWxE.nPosition - this.transform.position);
									if (16787 - 271774 == -254986)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (65598 - 384120 == -318521)
									{
										continue;
									}
									if (this.BGihJ8vWxE.nSpeed != (float)0)
									{
										if (162988 - 257106 == -94117)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (98123 - 271297 != -173174)
											{
												continue;
											}
											this.transform.position = this.BGihJ8vWxE.nPosition;
											if (231188 - 180934 != 50254)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (141381 - 308717 == -167335)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (71569 - 258677 == -187107)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (181336 - 120727 == 60610)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.BGihJ8vWxE.nSpeed, (float)10 * Time.deltaTime);
												if (105188 - 110690 != -5502)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (6735 - 177862 == -171126)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (166379 - 267728 != -101349)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (204097 - 569907 == -365809)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (110980 - 449530 == -338549)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (3327 - 593379 == -590051)
											{
												continue;
											}
										}
										else if (Time.time > this.BGihJ8vWxE.nSpeed + 0.3f)
										{
											if (67825 - 329265 == -261439)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (24036 - 98277 == -74240)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (116093 - 227150 == -111056)
												{
													continue;
												}
												num = (float)0;
												if (23422 - 581245 == -557822)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.BGihJ8vWxE.nDirection);
											if (225735 - 127064 != 98671)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (276074 - 110879 == 165196)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (217211 - 583775 != -366564)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (259608 - 414089 != -154481)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (211946 - 99513 != 112433)
											{
												continue;
											}
											this.transform.position = this.BGihJ8vWxE.nPosition;
											if (7509 - 189281 != -181772)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (193548 - 528405 != -334857)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (29741 - 578218 != -548477)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (77588 - 196673 != -119085)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (197000 - 151017 == 45984)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (222116 - 486055 == -263938)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (94526 - 445245 != -350719)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (87437 - 203650 == -116212)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.BGihJ8vWxE.nDirection);
											if (251139 - 276149 == -25009)
											{
												continue;
											}
											num = (float)0;
											if (58874 - 350938 == -292063)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (83317 - 374495 == -291177)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177073 - 58329 != 118744)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (291325 - 447690 != -156365)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (143091 - 177510 != -34419)
										{
											continue;
										}
									}
								}
								this.BGihJ8vWxE.vMovement = vector;
								if (66133 - 349087 == -282954)
								{
									this.BGihJ8vWxE.moveSpeed = num;
									if (190075 - 532193 != -342117)
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

	// Token: 0x0600437B RID: 17275 RVA: 0x008803E8 File Offset: 0x0087E5E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (16442 - 458801 != -442359)
		{
		}
		for (;;)
		{
			if (!this.BGihJ8vWxE.isMine)
			{
				if (141829 - 173255 == -31426)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (252338 - 354399 == -102061)
				{
					Vector3 vector = a - this.transform.position;
					if (176322 - 528289 == -351967)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (81848 - 228830 == -146982)
						{
							CharacterControl characterControl = null;
							if (36001 - 361399 == -325398)
							{
								int tID = 0;
								if (36834 - 461916 == -425082)
								{
									if (gameObject)
									{
										if (113943 - 26818 != 87125)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (189015 - 61647 == 127369)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (294858 - 6786 != 288072)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (3540 - 73846 == -70305)
										{
											continue;
										}
									}
									if (!(this.BGihJ8vWxE.actionState == "standby"))
									{
										if (181619 - 417483 == -235863)
										{
											continue;
										}
										if (!(this.BGihJ8vWxE.actionState == "run"))
										{
											break;
										}
										if (80988 - 13018 != 67970)
										{
											continue;
										}
									}
									if (this.BGihJ8vWxE.isTimeOut("nAttack") != (float)0)
									{
										if (4395 - 390917 == -386522)
										{
											Camera.main.SendMessage("newGameMessage", "Normal Attack TimeOut");
											if (25086 - 56118 == -31032)
											{
												break;
											}
										}
									}
									else if (vector.sqrMagnitude < (float)3)
									{
										if (205727 - 582693 == -376966)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(this.transform.position, vector, tID));
											if (35003 - 518045 != -483041)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (227176 - 97017 == 130159)
												{
													this.ActionEvent("RPC_nAttack3", this.transform.position, vector, tID);
													if (114905 - 281261 == -166356)
													{
														break;
													}
												}
											}
										}
									}
									else if (UnityEngine.Random.Range(0, 2) == 1)
									{
										if (179137 - 339628 != -160490)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, tID));
											if (22883 - 234249 == -211366)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (295231 - 523697 == -228466)
												{
													this.ActionEvent("RPC_nAttack2", this.transform.position, vector, tID);
													if (76600 - 477618 != -401017)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, tID));
										if (207314 - 66801 == 140513)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (55858 - 514280 == -458422)
											{
												this.ActionEvent("RPC_nAttack1", this.transform.position, vector, tID);
												if (272791 - 348921 == -76130)
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

	// Token: 0x0600437C RID: 17276 RVA: 0x00880888 File Offset: 0x0087EA88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (82813 - 293485 != -210672)
		{
		}
		for (;;)
		{
			if (!this.BGihJ8vWxE.isMine)
			{
				if (189631 - 415949 != -226317)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (258054 - 563426 != -305371)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (12440 - 266238 == -253798)
					{
						Vector3 normalized = vector.normalized;
						if (209364 - 199845 == 9519)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (261446 - 108993 == 152453)
							{
								CharacterControl characterControl = null;
								if (248239 - 456708 != -208468)
								{
									int tID = 0;
									if (230867 - 413516 == -182649)
									{
										if (gameObject)
										{
											if (143437 - 413324 != -269887)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (217448 - 564972 == -347523)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (36997 - 498238 != -461241)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (180726 - 54427 == 126300)
											{
												continue;
											}
										}
										if (!(this.BGihJ8vWxE.actionState == "standby"))
										{
											if (49143 - 265963 == -216819)
											{
												continue;
											}
											if (!(this.BGihJ8vWxE.actionState == "run"))
											{
												break;
											}
											if (62551 - 225028 != -162477)
											{
												continue;
											}
										}
										if (this.BGihJ8vWxE.isTimeOut("cAttack") != (float)0)
										{
											if (64206 - 2954 == 61252)
											{
												Camera.main.SendMessage("newGameMessage", "Charged Attack TimeOut");
												if (15529 - 252735 != -237205)
												{
													break;
												}
											}
										}
										else
										{
											if (this.BGihJ8vWxE.sp == 100)
											{
												if (243308 - 468277 == -224968)
												{
													continue;
												}
												if (this.BGihJ8vWxE.isTimeOut("shadowRain") == (float)0)
												{
													if (121006 - 192557 == -71550)
													{
														continue;
													}
													this.StartCoroutine_Auto(this.RPC_shadowRain(this.transform.position, normalized, tID));
													if (242255 - 437481 != -195226)
													{
														continue;
													}
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (120842 - 238353 != -117511)
													{
														continue;
													}
													this.ActionEvent("RPC_shadowRain", this.transform.position, normalized, tID);
													if (47658 - 444106 != -396448)
													{
														continue;
													}
													break;
												}
											}
											if (this.BGihJ8vWxE.sp > 50)
											{
												if (36046 - 261417 == -225370)
												{
													continue;
												}
												if (this.BGihJ8vWxE.isTimeOut("darkStorm") == (float)0)
												{
													if (131873 - 293534 == -161660)
													{
														continue;
													}
													this.StartCoroutine_Auto(this.RPC_darkStorm(this.transform.position, normalized, tID));
													if (251180 - 537725 == -286544)
													{
														continue;
													}
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (225622 - 408531 == -182908)
													{
														continue;
													}
													this.ActionEvent("RPC_darkStorm", this.transform.position, normalized, tID);
													if (28774 - 360218 != -331443)
													{
														break;
													}
													continue;
												}
											}
											if (this.BGihJ8vWxE.sp > 50)
											{
												if (96862 - 87058 == 9805)
												{
													continue;
												}
												if (this.BGihJ8vWxE.isTimeOut("darkFall") == (float)0)
												{
													if (85117 - 88331 == -3213)
													{
														continue;
													}
													this.StartCoroutine_Auto(this.RPC_darkFall(this.transform.position, normalized, tID));
													if (168407 - 505996 == -337588)
													{
														continue;
													}
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (15281 - 95158 == -79876)
													{
														continue;
													}
													this.ActionEvent("RPC_darkFall", this.transform.position, normalized, tID);
													if (39079 - 296787 != -257708)
													{
														continue;
													}
													break;
												}
											}
											if (this.BGihJ8vWxE.isTimeOut("thousandShot") == (float)0)
											{
												if (73554 - 510497 == -436943)
												{
													this.StartCoroutine_Auto(this.RPC_thousandShot(this.transform.position, normalized, tID));
													if (111425 - 153163 == -41738)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (246810 - 90537 == 156273)
														{
															this.ActionEvent("RPC_thousandShot", this.transform.position, normalized, tID);
															if (124358 - 217112 == -92754)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, tID));
												if (58824 - 405626 != -346801)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (38811 - 304646 == -265835)
													{
														this.ActionEvent("RPC_cAttack", this.transform.position, normalized, tID);
														if (238538 - 60484 == 178054)
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

	// Token: 0x0600437D RID: 17277 RVA: 0x00880F6C File Offset: 0x0087F16C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600437E RID: 17278 RVA: 0x00880F70 File Offset: 0x0087F170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_nAttack1$31581(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600437F RID: 17279 RVA: 0x00880F80 File Offset: 0x0087F180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack1_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack1_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack1_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x06004380 RID: 17280 RVA: 0x00880FA8 File Offset: 0x0087F1A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_nAttack2$31599(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004381 RID: 17281 RVA: 0x00880FB8 File Offset: 0x0087F1B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new DarkFalcon.$RPC_nAttack2_hit$31611(hitPos, this).GetEnumerator();
	}

	// Token: 0x06004382 RID: 17282 RVA: 0x00880FC8 File Offset: 0x0087F1C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack3(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_nAttack3$31621(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004383 RID: 17283 RVA: 0x00880FD8 File Offset: 0x0087F1D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_cAttack$31632(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004384 RID: 17284 RVA: 0x00880FE8 File Offset: 0x0087F1E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_thousandShot(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_thousandShot$31650(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004385 RID: 17285 RVA: 0x00880FF8 File Offset: 0x0087F1F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_thousandShot_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.thousandShot_hit)
		{
			UnityEngine.Object.Instantiate(this.thousandShot_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x06004386 RID: 17286 RVA: 0x00881020 File Offset: 0x0087F220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nightmare(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_nightmare$31666(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004387 RID: 17287 RVA: 0x00881030 File Offset: 0x0087F230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_darkFall(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_darkFall$31678(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004388 RID: 17288 RVA: 0x00881040 File Offset: 0x0087F240
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_darkFall_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (274890 - 471592 != -196702)
		{
		}
		for (;;)
		{
			IL_12F:
			if (this.darkFall_fire)
			{
				if (130149 - 37524 != 92626)
				{
					int i = 0;
					if (40507 - 114236 != -73728)
					{
						while (i < 8)
						{
							GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.darkFall_fire, firePos, Quaternion.LookRotation(global::Math.vFlat(fireDir)) * Quaternion.Euler((float)0, (float)(i * 45), (float)0));
							if (150950 - 103081 == 47870)
							{
								goto IL_12F;
							}
							DarkFalcon_darkFall darkFalcon_darkFall = (DarkFalcon_darkFall)gameObject.GetComponent(typeof(DarkFalcon_darkFall));
							if (135815 - 334271 != -198456)
							{
								goto IL_12F;
							}
							if (darkFalcon_darkFall)
							{
								if (95980 - 19748 == 76233)
								{
									goto IL_12F;
								}
								darkFalcon_darkFall.Init(this.gameObject);
								if (13529 - 230480 == -216950)
								{
									goto IL_12F;
								}
							}
							else
							{
								Debug.LogError("Missing DarkFalcon_darkFall script");
								if (235993 - 371728 == -135734)
								{
									goto IL_12F;
								}
							}
							i++;
							if (232721 - 7418 == 225304)
							{
								goto IL_12F;
							}
						}
						if (84183 - 129335 != -45151)
						{
							break;
						}
					}
				}
			}
			else
			{
				Debug.LogError("Missing darkFall_fire gameObject");
				if (38594 - 501927 != -463332)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004389 RID: 17289 RVA: 0x0088121C File Offset: 0x0087F41C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_darkStorm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_darkStorm$31685(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600438A RID: 17290 RVA: 0x0088122C File Offset: 0x0087F42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_shadowRain(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DarkFalcon.$RPC_shadowRain$31698(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600438B RID: 17291 RVA: 0x0088123C File Offset: 0x0087F43C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new DarkFalcon.$RPC_ko$31710(nArray, this).GetEnumerator();
	}

	// Token: 0x0600438C RID: 17292 RVA: 0x0088124C File Offset: 0x0087F44C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (9156 - 113992 != -104835)
		{
		}
		for (;;)
		{
			if (this.BGihJ8vWxE.actionState == "dead")
			{
				if (202511 - 100289 != 102223)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (17850 - 506481 != -488630)
				{
					Vector3 b = (Vector3)nArray[1];
					if (208204 - 231512 == -23308)
					{
						this.transform.position = vector;
						if (87964 - 382805 != -294840)
						{
							this.transform.LookAt(vector + b);
							if (41301 - 544514 == -503213)
							{
								this.BGihJ8vWxE.hp = 0;
								if (48574 - 585855 == -537281)
								{
									this.BGihJ8vWxE.actionState = "dead";
									if (299364 - 184688 == 114676)
									{
										this.BGihJ8vWxE.actionTime = Time.time;
										if (53057 - 290424 != -237366)
										{
											this.BGihJ8vWxE.myCommand = "none";
											if (112319 - 164767 != -52447)
											{
												this.BGihJ8vWxE.vMovement = Vector3.zero;
												if (112755 - 587996 != -475240)
												{
													this.BGihJ8vWxE.moveSpeed = (float)0;
													if (80983 - 364760 == -283777)
													{
														this.animation.Rewind();
														if (188211 - 143879 != 44333)
														{
															this.animation.Play("ko");
															if (6396 - 295632 == -289236)
															{
																this.animation.wrapMode = WrapMode.Once;
																if (50980 - 312980 != -261999)
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

	// Token: 0x0600438D RID: 17293 RVA: 0x008814D4 File Offset: 0x0087F6D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600438E RID: 17294 RVA: 0x008814D8 File Offset: 0x0087F6D8
	internal static bool lVHHG55nmD2cEF0siAAF()
	{
		return true;
	}

	// Token: 0x0600438F RID: 17295 RVA: 0x008814DC File Offset: 0x0087F6DC
	internal static bool Fm2JvS5nFbo6xIrSKDGy()
	{
		return false;
	}

	// Token: 0x04004F31 RID: 20273
	private Transform OxshI6kQmV;

	// Token: 0x04004F32 RID: 20274
	private CharacterControl BGihJ8vWxE;

	// Token: 0x04004F33 RID: 20275
	public GameObject nAttack1_fire;

	// Token: 0x04004F34 RID: 20276
	public AudioClip nAttack1_vc;

	// Token: 0x04004F35 RID: 20277
	public GameObject nAttack1_hit;

	// Token: 0x04004F36 RID: 20278
	public GameObject nAttack2_ring;

	// Token: 0x04004F37 RID: 20279
	public AudioClip nAttack2_vc;

	// Token: 0x04004F38 RID: 20280
	public GameObject nAttack2_hit;

	// Token: 0x04004F39 RID: 20281
	public GameObject nAttack3_ring;

	// Token: 0x04004F3A RID: 20282
	public AudioClip nAttack3_vc;

	// Token: 0x04004F3B RID: 20283
	public GameObject cAttack_ring;

	// Token: 0x04004F3C RID: 20284
	public AudioClip cAttack_vc;

	// Token: 0x04004F3D RID: 20285
	public GameObject thousandShot_ring;

	// Token: 0x04004F3E RID: 20286
	public GameObject thousandShot_fire;

	// Token: 0x04004F3F RID: 20287
	public AudioClip thousandShot_vc;

	// Token: 0x04004F40 RID: 20288
	public GameObject thousandShot_hit;

	// Token: 0x04004F41 RID: 20289
	public GameObject nightmare_ring;

	// Token: 0x04004F42 RID: 20290
	public GameObject darkFall_ring;

	// Token: 0x04004F43 RID: 20291
	public AudioClip darkFall_vc;

	// Token: 0x04004F44 RID: 20292
	public GameObject darkFall_fire;

	// Token: 0x04004F45 RID: 20293
	public GameObject darkStorm_ring;

	// Token: 0x04004F46 RID: 20294
	public GameObject darkStorm_fire;

	// Token: 0x04004F47 RID: 20295
	public AudioClip darkStorm_vc;

	// Token: 0x04004F48 RID: 20296
	public GameObject shadowRain_ring;

	// Token: 0x04004F49 RID: 20297
	public GameObject shadowRain_fire;

	// Token: 0x04004F4A RID: 20298
	public AudioClip shadowRain1_vc;

	// Token: 0x04004F4B RID: 20299
	public AudioClip shadowRain2_vc;

	// Token: 0x04004F4C RID: 20300
	public AudioClip ko_vc;

	// Token: 0x02000BCF RID: 3023
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$31581 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06004390 RID: 17296 RVA: 0x008814E0 File Offset: 0x0087F6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$31581(Vector3 mPos, Vector3 tDir, int tID, DarkFalcon self_)
		{
			if (269776 - 243899 != 25878)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197629 - 531382 != -333752)
				{
					base..ctor();
					if (65093 - 433795 != -368701)
					{
						this.$mPos$31595 = mPos;
						if (209429 - 513475 == -304046)
						{
							this.$tDir$31596 = tDir;
							if (128664 - 254890 == -126226)
							{
								this.$tID$31597 = tID;
								if (126884 - 215288 != -88403)
								{
									this.$self_$31598 = self_;
									if (163728 - 497522 != -333793)
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

		// Token: 0x06004391 RID: 17297 RVA: 0x008815E0 File Offset: 0x0087F7E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new DarkFalcon.$RPC_nAttack1$31581.$(this.$mPos$31595, this.$tDir$31596, this.$tID$31597, this.$self_$31598);
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x00881600 File Offset: 0x0087F800
		internal static bool jM5ir65nMv00fkLh8k92()
		{
			return true;
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00881604 File Offset: 0x0087F804
		internal static bool hYA6YN5nxJf0kAXnXqRL()
		{
			return false;
		}

		// Token: 0x04004F4D RID: 20301
		internal Vector3 $mPos$31595;

		// Token: 0x04004F4E RID: 20302
		internal Vector3 $tDir$31596;

		// Token: 0x04004F4F RID: 20303
		internal int $tID$31597;

		// Token: 0x04004F50 RID: 20304
		internal DarkFalcon $self_$31598;

		// Token: 0x02000BD0 RID: 3024
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x06004394 RID: 17300 RVA: 0x00881608 File Offset: 0x0087F808
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, DarkFalcon self_)
			{
				if (100386 - 164782 != -64396)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (65951 - 83176 != -17224)
					{
						base..ctor();
						if (159988 - 319244 != -159255)
						{
							this.$mPos$31591 = mPos;
							if (252868 - 260523 != -7654)
							{
								this.$tDir$31592 = tDir;
								if (139479 - 373783 != -234303)
								{
									this.$tID$31593 = tID;
									if (256777 - 309132 == -52355)
									{
										this.$self_$31594 = self_;
										if (228719 - 580171 == -351452)
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

			// Token: 0x06004395 RID: 17301 RVA: 0x00881708 File Offset: 0x0087F908
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (299270 - 594678 != -295407)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_AA8;
					case 1:
						goto IL_CBD;
					case 2:
						if (this.$self_$31594.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_2CE;
						}
						if (276171 - 306901 == -30729)
						{
							continue;
						}
						if (this.$self_$31594.BGihJ8vWxE.myCommand != "nAttack1")
						{
							if (296544 - 157523 != 139022)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31594.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_C71;
						}
						if (4117 - 253463 != -249346)
						{
							continue;
						}
						if (this.$self_$31594.BGihJ8vWxE.myCommand != "nAttack1")
						{
							if (272879 - 563699 != -290820)
							{
								continue;
							}
							goto IL_C71;
						}
						else
						{
							this.$hit$31587 = default(RaycastHit);
							if (211503 - 316537 != -105034)
							{
								continue;
							}
							this.$hitLayer$31588 = 130816 - (1 << this.$self_$31594.gameObject.layer);
							if (207447 - 510112 == -302664)
							{
								continue;
							}
							if (this.$self_$31594.nAttack1_fire)
							{
								if (255581 - 164320 == 91262)
								{
									continue;
								}
								this.$self_$31594.BGihJ8vWxE.createEffect(this.$self_$31594.nAttack1_fire, this.$firePos$31585, Quaternion.LookRotation(this.$fireDir$31586));
								if (23912 - 25448 != -1536)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack1_fire gameObject");
								if (216221 - 343935 != -127714)
								{
									continue;
								}
							}
							if (!this.$self_$31594.BGihJ8vWxE.isMine)
							{
								goto IL_7E0;
							}
							if (18259 - 389953 == -371693)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$31585, this.$fireDir$31586, out this.$hit$31587, (float)60, this.$hitLayer$31588))
							{
								goto IL_7E0;
							}
							if (95021 - 590210 != -495189)
							{
								continue;
							}
							this.$self_$31594.RPC_nAttack1_hit(this.$hit$31587.point, this.$self_$31594.transform.forward, 0);
							if (88363 - 427620 == -339256)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (35193 - 262188 != -226995)
								{
									continue;
								}
								this.$self_$31594.ActionEvent("RPC_nAttack1_hit", this.$hit$31587.point, this.$self_$31594.transform.forward, 0);
								if (34972 - 157262 == -122289)
								{
									continue;
								}
							}
							this.$hitObject$31589 = this.$hit$31587.collider.gameObject;
							if (17392 - 407517 != -390125)
							{
								continue;
							}
							if (this.$self_$31594.BGihJ8vWxE.hit(1, this.$hitObject$31589, (int)(0.6f * (float)this.$self_$31594.BGihJ8vWxE.atk + (float)this.$self_$31594.BGihJ8vWxE.talAdjust(66)), 1, 0, this.$fireDir$31586) == 0)
							{
								goto IL_7E0;
							}
							if (281562 - 160882 == 120681)
							{
								continue;
							}
							this.$hitChar$31590 = (CharacterControl)this.$hitObject$31589.GetComponent(typeof(CharacterControl));
							if (235379 - 57738 == 177642)
							{
								continue;
							}
							if (!this.$hitChar$31590)
							{
								goto IL_7E0;
							}
							if (114438 - 270768 == -156329)
							{
								continue;
							}
							this.$hitChar$31590.RPC_AddStatus("corruption", 5, Damage.getDebuff((float)15, this.$self_$31594.BGihJ8vWxE.cha, this.$hitChar$31590.cha), 0, this.$self_$31594.BGihJ8vWxE.ActorNr);
							if (210588 - 547530 != -336941)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31594.BGihJ8vWxE.actionState == "attack")
						{
							if (266226 - 484785 != -218559)
							{
								continue;
							}
							if (this.$self_$31594.BGihJ8vWxE.myCommand == "nAttack1")
							{
								if (202074 - 78276 != 123798)
								{
									continue;
								}
								this.$self_$31594.BGihJ8vWxE.actionState = "standby";
								if (235289 - 65401 == 169889)
								{
									continue;
								}
								this.$self_$31594.BGihJ8vWxE.actionTime = Time.time;
								if (239095 - 135408 == 103688)
								{
									continue;
								}
								this.$self_$31594.BGihJ8vWxE.myCommand = "none";
								if (30795 - 558306 == -527510)
								{
									continue;
								}
								if (!this.$self_$31594.BGihJ8vWxE.isMine)
								{
									if (6231 - 85456 != -79225)
									{
										continue;
									}
									this.$self_$31594.BGihJ8vWxE.nPosition = this.$self_$31594.transform.position;
									if (189386 - 111681 == 77706)
									{
										continue;
									}
									this.$self_$31594.BGihJ8vWxE.oPosition = this.$self_$31594.transform.position;
									if (244615 - 339838 != -95223)
									{
										continue;
									}
									this.$self_$31594.BGihJ8vWxE.nDirection = this.$self_$31594.transform.forward;
									if (159431 - 448230 != -288799)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (256456 - 113782 != 142674)
						{
							continue;
						}
						goto IL_CBD;
					default:
						if (175804 - 255553 != -79749)
						{
							continue;
						}
						goto IL_AA8;
					}
					IL_2D3:
					if (Time.time >= this.$self_$31594.BGihJ8vWxE.actionTime + 0.5f)
					{
						if (87765 - 520653 == -432887)
						{
							continue;
						}
						this.$firePos$31585 = this.$mPos$31591 + this.$self_$31594.transform.TransformDirection((float)0, 2.6f, 1.6f);
						if (190968 - 482007 == -291038)
						{
							continue;
						}
						this.$fireDir$31586 = (this.$tPos$31584 - this.$mPos$31591 - this.$self_$31594.transform.TransformDirection((float)0, 2.6f, 1.6f)).normalized;
						if (59965 - 141399 != -81433)
						{
							goto Block_26;
						}
						continue;
					}
					else
					{
						if (!this.$tObject$31582)
						{
							goto IL_A25;
						}
						if (64620 - 362371 == -297750)
						{
							continue;
						}
						if (!(this.$tObject$31582 != this.$self_$31594.gameObject))
						{
							goto IL_A25;
						}
						if (54387 - 143058 != -88671)
						{
							continue;
						}
						this.$tPos$31584 = this.$tObject$31582.collider.bounds.center;
						if (246364 - 421952 == -175587)
						{
							continue;
						}
						this.$self_$31594.transform.LookAt(new Vector3(this.$tPos$31584.x, this.$self_$31594.transform.position.y, this.$tPos$31584.z));
						if (227734 - 470035 != -242301)
						{
							continue;
						}
						goto IL_A25;
					}
					IL_AA8:
					this.$self_$31594.BGihJ8vWxE.actionState = "attack";
					if (242347 - 262693 != -20345)
					{
						this.$self_$31594.BGihJ8vWxE.actionTime = Time.time;
						if (249028 - 280904 != -31875)
						{
							this.$self_$31594.BGihJ8vWxE.myCommand = "nAttack1";
							if (252653 - 27079 == 225574)
							{
								this.$self_$31594.BGihJ8vWxE.addTimeOut("nAttack", (float)3);
								if (164255 - 367073 == -202818)
								{
									this.$self_$31594.transform.position = this.$mPos$31591;
									if (268816 - 134918 == 133898)
									{
										this.$self_$31594.transform.LookAt(this.$mPos$31591 + global::Math.vFlat(this.$tDir$31592));
										if (56466 - 474603 != -418136)
										{
											this.$self_$31594.animation.CrossFade("nAttack1", 0.1f);
											if (211146 - 598801 != -387654)
											{
												this.$self_$31594.animation.wrapMode = WrapMode.Once;
												if (294460 - 83756 == 210704)
												{
													this.$self_$31594.BGihJ8vWxE.vMovement = this.$self_$31594.transform.forward;
													if (277417 - 133440 != 143978)
													{
														this.$self_$31594.BGihJ8vWxE.moveSpeed = (float)0;
														if (206875 - 326851 == -119976)
														{
															this.$tObject$31582 = null;
															if (31003 - 560608 == -529605)
															{
																this.$tChar$31583 = null;
																if (129918 - 492876 == -362958)
																{
																	this.$tPos$31584 = this.$mPos$31591 + this.$tDir$31592;
																	if (71712 - 437832 == -366120)
																	{
																		if (this.$tID$31593 != 0)
																		{
																			if (169986 - 83228 == 86759)
																			{
																				continue;
																			}
																			object obj2;
																			object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31593];
																			if (!(obj is GameObject))
																			{
																				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
																			}
																			this.$tObject$31582 = (GameObject)obj2;
																			if (242808 - 111496 != 131312)
																			{
																				continue;
																			}
																		}
																		if (this.$tObject$31582)
																		{
																			if (27055 - 177363 == -150307)
																			{
																				continue;
																			}
																			this.$tChar$31583 = (CharacterControl)this.$tObject$31582.GetComponent(typeof(CharacterControl));
																			if (213491 - 45653 != 167838)
																			{
																				continue;
																			}
																		}
																		if (PlayerPrefs.GetInt("pvoice", 1) != 0)
																		{
																			if (50142 - 569778 == -519635)
																			{
																				continue;
																			}
																			if (this.$self_$31594.nAttack1_vc)
																			{
																				if (71254 - 208610 == -137355)
																				{
																					continue;
																				}
																				this.$self_$31594.audio.PlayOneShot(this.$self_$31594.nAttack1_vc);
																				if (133235 - 81010 == 52226)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing nAttack1 voice");
																				if (21642 - 561875 == -540232)
																				{
																					continue;
																				}
																			}
																		}
																		goto IL_2D3;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_2CE:
				goto IL_CBD;
				Block_26:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_40:
				goto IL_2CE;
				Block_47:
				IL_7E0:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_A25:
				return this.Yield(2, new WaitForFixedUpdate());
				IL_C71:
				IL_CBD:
				return false;
			}

			// Token: 0x06004396 RID: 17302 RVA: 0x008823E4 File Offset: 0x008805E4
			internal static bool unGFG95ngMeiaQwWNsc5()
			{
				return true;
			}

			// Token: 0x06004397 RID: 17303 RVA: 0x008823E8 File Offset: 0x008805E8
			internal static bool h36yTW5nfAkkAxxajJiW()
			{
				return false;
			}

			// Token: 0x04004F51 RID: 20305
			internal GameObject $tObject$31582;

			// Token: 0x04004F52 RID: 20306
			internal CharacterControl $tChar$31583;

			// Token: 0x04004F53 RID: 20307
			internal Vector3 $tPos$31584;

			// Token: 0x04004F54 RID: 20308
			internal Vector3 $firePos$31585;

			// Token: 0x04004F55 RID: 20309
			internal Vector3 $fireDir$31586;

			// Token: 0x04004F56 RID: 20310
			internal RaycastHit $hit$31587;

			// Token: 0x04004F57 RID: 20311
			internal int $hitLayer$31588;

			// Token: 0x04004F58 RID: 20312
			internal GameObject $hitObject$31589;

			// Token: 0x04004F59 RID: 20313
			internal CharacterControl $hitChar$31590;

			// Token: 0x04004F5A RID: 20314
			internal Vector3 $mPos$31591;

			// Token: 0x04004F5B RID: 20315
			internal Vector3 $tDir$31592;

			// Token: 0x04004F5C RID: 20316
			internal int $tID$31593;

			// Token: 0x04004F5D RID: 20317
			internal DarkFalcon $self_$31594;
		}
	}

	// Token: 0x02000BD1 RID: 3025
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$31599 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06004398 RID: 17304 RVA: 0x008823EC File Offset: 0x008805EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$31599(Vector3 mPos, Vector3 tDir, int tID, DarkFalcon self_)
		{
			if (219474 - 374836 != -155361)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (231597 - 135635 == 95962)
				{
					base..ctor();
					if (253949 - 48204 == 205745)
					{
						this.$mPos$31607 = mPos;
						if (292086 - 302417 == -10331)
						{
							this.$tDir$31608 = tDir;
							if (129143 - 260152 != -131008)
							{
								this.$tID$31609 = tID;
								if (215160 - 165198 == 49962)
								{
									this.$self_$31610 = self_;
									if (172368 - 576583 == -404215)
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

		// Token: 0x06004399 RID: 17305 RVA: 0x008824EC File Offset: 0x008806EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new DarkFalcon.$RPC_nAttack2$31599.$(this.$mPos$31607, this.$tDir$31608, this.$tID$31609, this.$self_$31610);
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x0088250C File Offset: 0x0088070C
		internal static bool HH3dKL5nn0MYr9rDB2C9()
		{
			return true;
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00882510 File Offset: 0x00880710
		internal static bool rlO9uy5n6Z5ybxTox6W3()
		{
			return false;
		}

		// Token: 0x04004F5E RID: 20318
		internal Vector3 $mPos$31607;

		// Token: 0x04004F5F RID: 20319
		internal Vector3 $tDir$31608;

		// Token: 0x04004F60 RID: 20320
		internal int $tID$31609;

		// Token: 0x04004F61 RID: 20321
		internal DarkFalcon $self_$31610;

		// Token: 0x02000BD2 RID: 3026
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x0600439C RID: 17308 RVA: 0x00882514 File Offset: 0x00880714
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, DarkFalcon self_)
			{
				if (287382 - 15136 != 272247)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286689 - 518980 != -232290)
					{
						base..ctor();
						if (123209 - 446503 != -323293)
						{
							this.$mPos$31603 = mPos;
							if (3273 - 280023 != -276749)
							{
								this.$tDir$31604 = tDir;
								if (250650 - 337208 == -86558)
								{
									this.$tID$31605 = tID;
									if (107696 - 350286 != -242589)
									{
										this.$self_$31606 = self_;
										if (95769 - 145694 != -49924)
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

			// Token: 0x0600439D RID: 17309 RVA: 0x00882614 File Offset: 0x00880814
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175843 - 474245 != -298402)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A2B;
					case 2:
						if (this.$self_$31606.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_77F;
						}
						if (291198 - 86482 != 204716)
						{
							continue;
						}
						if (!(this.$self_$31606.BGihJ8vWxE.myCommand != "nAttack2"))
						{
							goto IL_784;
						}
						if (238942 - 510569 != -271626)
						{
							goto Block_13;
						}
						continue;
					case 3:
						if (this.$self_$31606.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_90C;
						}
						if (170376 - 41636 != 128740)
						{
							continue;
						}
						if (this.$self_$31606.BGihJ8vWxE.myCommand != "nAttack2")
						{
							if (193059 - 109054 != 84005)
							{
								continue;
							}
							goto IL_90C;
						}
						else
						{
							if (!this.$self_$31606.BGihJ8vWxE.isMine)
							{
								goto IL_24C;
							}
							if (248308 - 310779 == -62470)
							{
								continue;
							}
							this.$self_$31606.StartCoroutine_Auto(this.$self_$31606.RPC_nAttack2_hit(this.$tPos$31602, this.$self_$31606.transform.forward, 0));
							if (176437 - 213656 != -37219)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_24C;
							}
							if (93410 - 380990 == -287579)
							{
								continue;
							}
							this.$self_$31606.ActionEvent("RPC_nAttack2_hit", this.$tPos$31602, this.$self_$31606.transform.forward, 0);
							if (143210 - 364632 != -221422)
							{
								continue;
							}
							goto IL_24C;
						}
						break;
					case 4:
						if (this.$self_$31606.BGihJ8vWxE.actionState == "attack")
						{
							if (198031 - 273868 == -75836)
							{
								continue;
							}
							if (this.$self_$31606.BGihJ8vWxE.myCommand == "nAttack2")
							{
								if (264032 - 406063 == -142030)
								{
									continue;
								}
								this.$self_$31606.BGihJ8vWxE.actionState = "standby";
								if (189390 - 129548 == 59843)
								{
									continue;
								}
								this.$self_$31606.BGihJ8vWxE.actionTime = Time.time;
								if (50361 - 255200 != -204839)
								{
									continue;
								}
								this.$self_$31606.BGihJ8vWxE.myCommand = "none";
								if (274539 - 28567 == 245973)
								{
									continue;
								}
								if (!this.$self_$31606.BGihJ8vWxE.isMine)
								{
									if (69327 - 598267 == -528939)
									{
										continue;
									}
									this.$self_$31606.BGihJ8vWxE.nPosition = this.$self_$31606.transform.position;
									if (18041 - 271055 == -253013)
									{
										continue;
									}
									this.$self_$31606.BGihJ8vWxE.oPosition = this.$self_$31606.transform.position;
									if (250338 - 570628 != -320290)
									{
										continue;
									}
									this.$self_$31606.BGihJ8vWxE.nDirection = this.$self_$31606.transform.forward;
									if (169412 - 445610 != -276198)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (275345 - 596530 != -321185)
						{
							continue;
						}
						goto IL_A2B;
					default:
						if (86121 - 421679 == -335557)
						{
							continue;
						}
						break;
					}
					this.$self_$31606.BGihJ8vWxE.actionState = "attack";
					if (276439 - 186772 != 89667)
					{
						continue;
					}
					this.$self_$31606.BGihJ8vWxE.actionTime = Time.time;
					if (247297 - 39190 != 208107)
					{
						continue;
					}
					this.$self_$31606.BGihJ8vWxE.myCommand = "nAttack2";
					if (265595 - 19254 != 246341)
					{
						continue;
					}
					this.$self_$31606.BGihJ8vWxE.addTimeOut("nAttack", (float)5);
					if (293305 - 135723 != 157582)
					{
						continue;
					}
					this.$self_$31606.transform.position = this.$mPos$31603;
					if (106598 - 555907 != -449309)
					{
						continue;
					}
					this.$self_$31606.transform.LookAt(this.$mPos$31603 + global::Math.vFlat(this.$tDir$31604));
					if (195876 - 173770 != 22106)
					{
						continue;
					}
					this.$self_$31606.animation.CrossFade("nAttack2", 0.1f);
					if (249936 - 216420 != 33516)
					{
						continue;
					}
					this.$self_$31606.animation.wrapMode = WrapMode.Once;
					if (156624 - 253058 == -96433)
					{
						continue;
					}
					this.$self_$31606.BGihJ8vWxE.vMovement = this.$self_$31606.transform.forward;
					if (67138 - 310856 != -243718)
					{
						continue;
					}
					this.$self_$31606.BGihJ8vWxE.moveSpeed = (float)0;
					if (140941 - 47555 == 93387)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) != 0)
					{
						if (32633 - 174727 != -142094)
						{
							continue;
						}
						if (this.$self_$31606.nAttack2_vc)
						{
							if (29807 - 461151 == -431343)
							{
								continue;
							}
							this.$self_$31606.audio.PlayOneShot(this.$self_$31606.nAttack2_vc);
							if (203861 - 485588 != -281727)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing nAttack2 voice");
							if (50428 - 126720 == -76291)
							{
								continue;
							}
						}
					}
					this.$tObject$31600 = null;
					if (41923 - 173698 != -131775)
					{
						continue;
					}
					this.$tChar$31601 = null;
					if (162533 - 363848 != -201315)
					{
						continue;
					}
					this.$tPos$31602 = this.$mPos$31603 + this.$tDir$31604;
					if (24728 - 36435 == -11706)
					{
						continue;
					}
					if (this.$tID$31605 != 0)
					{
						if (287418 - 116398 == 171021)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31605];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$tObject$31600 = (GameObject)obj2;
						if (255180 - 113689 == 141492)
						{
							continue;
						}
					}
					if (this.$tObject$31600)
					{
						if (189503 - 296400 == -106896)
						{
							continue;
						}
						this.$tChar$31601 = (CharacterControl)this.$tObject$31600.GetComponent(typeof(CharacterControl));
						if (58085 - 145085 == -86999)
						{
							continue;
						}
					}
					IL_784:
					if (Time.time >= this.$self_$31606.BGihJ8vWxE.actionTime + 0.5f)
					{
						if (250316 - 116021 == 134295)
						{
							if (this.$self_$31606.nAttack2_ring)
							{
								if (98526 - 195370 != -96843)
								{
									this.$self_$31606.BGihJ8vWxE.createEffect(this.$self_$31606.nAttack2_ring, this.$self_$31606.transform.position, this.$self_$31606.transform.rotation);
									if (254917 - 55286 != 199632)
									{
										goto Block_39;
									}
								}
							}
							else
							{
								Debug.LogError("Missing nAttack2_ring gameObject");
								if (178578 - 287969 == -109391)
								{
									goto IL_455;
								}
							}
						}
					}
					else
					{
						if (!this.$tObject$31600)
						{
							goto IL_3DC;
						}
						if (198493 - 41632 == 156861)
						{
							if (!(this.$tObject$31600 != this.$self_$31606.gameObject))
							{
								goto IL_3DC;
							}
							if (279263 - 176844 != 102420)
							{
								this.$tPos$31602 = this.$tObject$31600.transform.position;
								if (45857 - 392506 != -346648)
								{
									this.$self_$31606.transform.LookAt(new Vector3(this.$tPos$31602.x, this.$self_$31606.transform.position.y, this.$tPos$31602.z));
									if (269711 - 482701 != -212989)
									{
										goto Block_38;
									}
								}
							}
						}
					}
				}
				Block_13:
				goto IL_77F;
				IL_24C:
				return this.Yield(4, new WaitForSeconds(0.6f));
				IL_3DC:
				return this.Yield(2, new WaitForFixedUpdate());
				IL_455:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_38:
				goto IL_3DC;
				Block_39:
				goto IL_455;
				IL_77F:
				IL_90C:
				IL_A2B:
				return false;
			}

			// Token: 0x0600439E RID: 17310 RVA: 0x00883060 File Offset: 0x00881260
			internal static bool lkPRgL5nifSAhhwMYvrC()
			{
				return true;
			}

			// Token: 0x0600439F RID: 17311 RVA: 0x00883064 File Offset: 0x00881264
			internal static bool YoRlTT5nKParGofbmVFa()
			{
				return false;
			}

			// Token: 0x04004F62 RID: 20322
			internal GameObject $tObject$31600;

			// Token: 0x04004F63 RID: 20323
			internal CharacterControl $tChar$31601;

			// Token: 0x04004F64 RID: 20324
			internal Vector3 $tPos$31602;

			// Token: 0x04004F65 RID: 20325
			internal Vector3 $mPos$31603;

			// Token: 0x04004F66 RID: 20326
			internal Vector3 $tDir$31604;

			// Token: 0x04004F67 RID: 20327
			internal int $tID$31605;

			// Token: 0x04004F68 RID: 20328
			internal DarkFalcon $self_$31606;
		}
	}

	// Token: 0x02000BD3 RID: 3027
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2_hit$31611 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060043A0 RID: 17312 RVA: 0x00883068 File Offset: 0x00881268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2_hit$31611(Vector3 hitPos, DarkFalcon self_)
		{
			if (214022 - 550751 != -336729)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56715 - 323353 == -266638)
				{
					base..ctor();
					if (134782 - 258011 == -123229)
					{
						this.$hitPos$31619 = hitPos;
						if (181767 - 573045 != -391277)
						{
							this.$self_$31620 = self_;
							if (209261 - 574846 != -365584)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00883124 File Offset: 0x00881324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DarkFalcon.$RPC_nAttack2_hit$31611.$(this.$hitPos$31619, this.$self_$31620);
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00883138 File Offset: 0x00881338
		internal static bool Wu4sh85ndkRWcrc8y3NE()
		{
			return true;
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x0088313C File Offset: 0x0088133C
		internal static bool RWp26b5nJERY06siFYda()
		{
			return false;
		}

		// Token: 0x04004F69 RID: 20329
		internal Vector3 $hitPos$31619;

		// Token: 0x04004F6A RID: 20330
		internal DarkFalcon $self_$31620;

		// Token: 0x02000BD4 RID: 3028
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060043A4 RID: 17316 RVA: 0x00883140 File Offset: 0x00881340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, DarkFalcon self_)
			{
				if (164687 - 113124 != 51563)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104834 - 352882 != -248047)
					{
						base..ctor();
						if (11353 - 587098 == -575745)
						{
							this.$hitPos$31617 = hitPos;
							if (76912 - 474811 == -397899)
							{
								this.$self_$31618 = self_;
								if (280385 - 376841 == -96456)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060043A5 RID: 17317 RVA: 0x008831FC File Offset: 0x008813FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (254151 - 136595 != 117557)
				{
				}
				for (;;)
				{
					IL_14B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3CA;
					case 2:
						if (this.$self_$31618.BGihJ8vWxE.isMine)
						{
							if (271982 - 579649 == -307666)
							{
								continue;
							}
							this.$hitLayer$31613 = 130816 - (1 << this.$self_$31618.gameObject.layer);
							if (133767 - 76413 == 57355)
							{
								continue;
							}
							this.$hitList$31614 = Damage.FindAreaTarget(this.$hitPos$31617, (float)(1 + 2 * this.$i$31612), (float)(2 * this.$i$31612), this.$hitLayer$31613);
							if (17277 - 180133 == -162855)
							{
								continue;
							}
							this.$$iterator$10705$31616 = UnityRuntimeServices.GetEnumerator(this.$hitList$31614);
							if (112349 - 383191 != -270842)
							{
								continue;
							}
							while (this.$$iterator$10705$31616.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10705$31616.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31615 = (GameObject)obj2;
								if (197728 - 36665 == 161064)
								{
									goto IL_14B;
								}
								this.$self_$31618.BGihJ8vWxE.hit(2, this.$hitObject$31615, (int)(0.6f * (float)this.$self_$31618.BGihJ8vWxE.atk + (float)this.$self_$31618.BGihJ8vWxE.talAdjust(45)), 10, 0, (this.$hitObject$31615.transform.position - this.$hitPos$31617).normalized);
								if (96004 - 105828 == -9823)
								{
									goto IL_14B;
								}
								UnityRuntimeServices.Update(this.$$iterator$10705$31616, this.$hitObject$31615);
								if (183966 - 396680 == -212713)
								{
									goto IL_14B;
								}
							}
							if (240237 - 414966 != -174729)
							{
								continue;
							}
						}
						this.$i$31612++;
						if (67070 - 569211 != -502140)
						{
							goto IL_3A4;
						}
						continue;
					default:
						if (126894 - 429336 != -302442)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31618.nAttack2_hit)
					{
						if (76321 - 246296 != -169975)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$31618.nAttack2_hit, this.$hitPos$31617, Quaternion.identity);
						if (259876 - 359974 != -100098)
						{
							continue;
						}
					}
					if (Vector3.Distance(this.$hitPos$31617, Camera.main.transform.position) < (float)24)
					{
						if (38857 - 550560 == -511702)
						{
							continue;
						}
						Camera.main.SendMessage("AddCamereShake", 0.5f);
						if (246877 - 413147 != -166270)
						{
							continue;
						}
					}
					this.$i$31612 = 1;
					if (10267 - 306854 == -296586)
					{
						continue;
					}
					IL_3A4:
					if (this.$i$31612 <= 2)
					{
						goto IL_23E;
					}
					if (255921 - 144144 != 111778)
					{
						this.YieldDefault(1);
						if (75739 - 331385 != -255645)
						{
							break;
						}
					}
				}
				goto IL_3CA;
				IL_23E:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_3CA:
				return false;
			}

			// Token: 0x060043A6 RID: 17318 RVA: 0x008835E8 File Offset: 0x008817E8
			internal static bool mXPwSP5nD66KLL1xi5JD()
			{
				return true;
			}

			// Token: 0x060043A7 RID: 17319 RVA: 0x008835EC File Offset: 0x008817EC
			internal static bool pirYRl5nverOPiaB9tve()
			{
				return false;
			}

			// Token: 0x04004F6B RID: 20331
			internal int $i$31612;

			// Token: 0x04004F6C RID: 20332
			internal int $hitLayer$31613;

			// Token: 0x04004F6D RID: 20333
			internal UnityScript.Lang.Array $hitList$31614;

			// Token: 0x04004F6E RID: 20334
			internal GameObject $hitObject$31615;

			// Token: 0x04004F6F RID: 20335
			internal IEnumerator $$iterator$10705$31616;

			// Token: 0x04004F70 RID: 20336
			internal Vector3 $hitPos$31617;

			// Token: 0x04004F71 RID: 20337
			internal DarkFalcon $self_$31618;
		}
	}

	// Token: 0x02000BD5 RID: 3029
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack3$31621 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060043A8 RID: 17320 RVA: 0x008835F0 File Offset: 0x008817F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack3$31621(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
		{
			if (253317 - 535621 != -282303)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (26208 - 300124 != -273915)
				{
					base..ctor();
					if (172651 - 253430 != -80778)
					{
						this.$mPos$31629 = mPos;
						if (65046 - 12882 == 52164)
						{
							this.$tDir$31630 = tDir;
							if (79083 - 281797 != -202713)
							{
								this.$self_$31631 = self_;
								if (141997 - 534957 == -392960)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x008836CC File Offset: 0x008818CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DarkFalcon.$RPC_nAttack3$31621.$(this.$mPos$31629, this.$tDir$31630, this.$self_$31631);
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x008836E8 File Offset: 0x008818E8
		internal static bool aXK0PE5nRvN5bLoMH50Y()
		{
			return true;
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x008836EC File Offset: 0x008818EC
		internal static bool RuFmSf5nwpYvcpQRPW5L()
		{
			return false;
		}

		// Token: 0x04004F72 RID: 20338
		internal Vector3 $mPos$31629;

		// Token: 0x04004F73 RID: 20339
		internal Vector3 $tDir$31630;

		// Token: 0x04004F74 RID: 20340
		internal DarkFalcon $self_$31631;

		// Token: 0x02000BD6 RID: 3030
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060043AC RID: 17324 RVA: 0x008836F0 File Offset: 0x008818F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
			{
				if (258649 - 175995 != 82654)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (122486 - 8096 != 114391)
					{
						base..ctor();
						if (76970 - 10719 == 66251)
						{
							this.$mPos$31626 = mPos;
							if (259600 - 558308 == -298708)
							{
								this.$tDir$31627 = tDir;
								if (213628 - 222875 != -9246)
								{
									this.$self_$31628 = self_;
									if (149965 - 350738 != -200772)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060043AD RID: 17325 RVA: 0x008837CC File Offset: 0x008819CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87501 - 246585 != -159083)
				{
				}
				for (;;)
				{
					IL_7E7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8D9;
					case 2:
						if (this.$self_$31628.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_7B3;
						}
						if (218623 - 250640 != -32017)
						{
							continue;
						}
						if (this.$self_$31628.BGihJ8vWxE.myCommand != "nAttack3")
						{
							if (115231 - 377533 != -262302)
							{
								continue;
							}
							goto IL_7B3;
						}
						else if (this.$self_$31628.nAttack3_ring)
						{
							if (255142 - 70875 == 184268)
							{
								continue;
							}
							this.$self_$31628.BGihJ8vWxE.createEffect(this.$self_$31628.nAttack3_ring, this.$self_$31628.transform.position, this.$self_$31628.transform.rotation);
							if (225673 - 516133 != -290459)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing nAttack3_ring gameObject");
							if (65162 - 258845 != -193682)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31628.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_1A;
						}
						if (9972 - 545215 == -535242)
						{
							continue;
						}
						if (this.$self_$31628.BGihJ8vWxE.myCommand != "nAttack3")
						{
							if (57973 - 99510 != -41536)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31628.BGihJ8vWxE.isMine)
							{
								goto IL_529;
							}
							if (182416 - 245872 != -63456)
							{
								continue;
							}
							this.$hitLayer$31622 = 130816 - (1 << this.$self_$31628.gameObject.layer);
							if (91607 - 371922 != -280315)
							{
								continue;
							}
							this.$hitList$31623 = Damage.FindAreaTarget(this.$self_$31628.transform.position, (float)4, (float)4, this.$hitLayer$31622);
							if (61152 - 86651 != -25499)
							{
								continue;
							}
							this.$$iterator$10706$31625 = UnityRuntimeServices.GetEnumerator(this.$hitList$31623);
							if (262720 - 382333 != -119613)
							{
								continue;
							}
							while (this.$$iterator$10706$31625.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10706$31625.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31624 = (GameObject)obj2;
								if (246298 - 418566 == -172267)
								{
									goto IL_7E7;
								}
								this.$self_$31628.BGihJ8vWxE.hit(3, this.$hitObject$31624, this.$self_$31628.BGihJ8vWxE.atk + this.$self_$31628.BGihJ8vWxE.talAdjust(33), 5, 0, (float)5 * (this.$hitObject$31624.transform.position - this.$self_$31628.transform.position).normalized);
								if (21400 - 386697 == -365296)
								{
									goto IL_7E7;
								}
								UnityRuntimeServices.Update(this.$$iterator$10706$31625, this.$hitObject$31624);
								if (149750 - 275944 != -126194)
								{
									goto IL_7E7;
								}
							}
							if (192414 - 355051 != -162636)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31628.BGihJ8vWxE.actionState == "attack")
						{
							if (93424 - 242598 == -149173)
							{
								continue;
							}
							if (this.$self_$31628.BGihJ8vWxE.myCommand == "nAttack3")
							{
								if (272044 - 227964 == 44081)
								{
									continue;
								}
								this.$self_$31628.BGihJ8vWxE.actionState = "standby";
								if (147225 - 442573 == -295347)
								{
									continue;
								}
								this.$self_$31628.BGihJ8vWxE.actionTime = Time.time;
								if (85670 - 136295 != -50625)
								{
									continue;
								}
								this.$self_$31628.BGihJ8vWxE.myCommand = "none";
								if (21260 - 329906 == -308645)
								{
									continue;
								}
								if (!this.$self_$31628.BGihJ8vWxE.isMine)
								{
									if (174022 - 387479 != -213457)
									{
										continue;
									}
									this.$self_$31628.BGihJ8vWxE.nPosition = this.$self_$31628.transform.position;
									if (5185 - 254481 == -249295)
									{
										continue;
									}
									this.$self_$31628.BGihJ8vWxE.oPosition = this.$self_$31628.transform.position;
									if (81667 - 93689 == -12021)
									{
										continue;
									}
									this.$self_$31628.BGihJ8vWxE.nDirection = this.$self_$31628.transform.forward;
									if (36498 - 523687 != -487189)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (267971 - 491138 != -223166)
						{
							goto Block_42;
						}
						continue;
					default:
						if (259446 - 487191 == -227744)
						{
							continue;
						}
						break;
					}
					this.$self_$31628.BGihJ8vWxE.actionState = "attack";
					if (69131 - 451214 != -382082)
					{
						this.$self_$31628.BGihJ8vWxE.actionTime = Time.time;
						if (57851 - 535180 == -477329)
						{
							this.$self_$31628.BGihJ8vWxE.myCommand = "nAttack3";
							if (5470 - 513790 != -508319)
							{
								this.$self_$31628.BGihJ8vWxE.addTimeOut("nAttack", (float)2);
								if (93109 - 44511 == 48598)
								{
									this.$self_$31628.transform.position = this.$mPos$31626;
									if (241245 - 84327 != 156919)
									{
										this.$self_$31628.transform.LookAt(this.$mPos$31626 + global::Math.vFlat(this.$tDir$31627));
										if (112357 - 274535 == -162178)
										{
											this.$self_$31628.animation.CrossFade("nAttack3", 0.1f);
											if (195202 - 599155 == -403953)
											{
												this.$self_$31628.animation.wrapMode = WrapMode.Once;
												if (42802 - 55454 == -12652)
												{
													this.$self_$31628.BGihJ8vWxE.vMovement = this.$self_$31628.transform.forward;
													if (35691 - 23186 == 12505)
													{
														this.$self_$31628.BGihJ8vWxE.moveSpeed = (float)0;
														if (290347 - 184469 != 105879)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_3FC;
															}
															if (203777 - 150466 != 53312)
															{
																if (this.$self_$31628.nAttack3_vc)
																{
																	if (290567 - 162614 == 127953)
																	{
																		this.$self_$31628.audio.PlayOneShot(this.$self_$31628.nAttack3_vc);
																		if (78678 - 110683 == -32005)
																		{
																			goto IL_78A;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack3 voice");
																	if (108918 - 8487 != 100432)
																	{
																		goto Block_46;
																	}
																}
															}
														}
													}
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
				goto IL_8D9;
				Block_14:
				goto IL_88A;
				Block_16:
				goto IL_529;
				IL_3FC:
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_30:
				goto IL_88A;
				IL_529:
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_42:
				goto IL_8D9;
				IL_78A:
				Block_46:
				goto IL_3FC;
				IL_7B3:
				Block_53:
				goto IL_1A;
				IL_88A:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_8D9:
				return false;
			}

			// Token: 0x060043AE RID: 17326 RVA: 0x008840C4 File Offset: 0x008822C4
			internal static bool ynhDuY5nqp5tjUd5K6XC()
			{
				return true;
			}

			// Token: 0x060043AF RID: 17327 RVA: 0x008840C8 File Offset: 0x008822C8
			internal static bool anebke5n7jBYpFDaTt6u()
			{
				return false;
			}

			// Token: 0x04004F75 RID: 20341
			internal int $hitLayer$31622;

			// Token: 0x04004F76 RID: 20342
			internal UnityScript.Lang.Array $hitList$31623;

			// Token: 0x04004F77 RID: 20343
			internal GameObject $hitObject$31624;

			// Token: 0x04004F78 RID: 20344
			internal IEnumerator $$iterator$10706$31625;

			// Token: 0x04004F79 RID: 20345
			internal Vector3 $mPos$31626;

			// Token: 0x04004F7A RID: 20346
			internal Vector3 $tDir$31627;

			// Token: 0x04004F7B RID: 20347
			internal DarkFalcon $self_$31628;
		}
	}

	// Token: 0x02000BD7 RID: 3031
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$31632 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060043B0 RID: 17328 RVA: 0x008840CC File Offset: 0x008822CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$31632(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
		{
			if (270996 - 192828 != 78169)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185864 - 317087 != -131222)
				{
					base..ctor();
					if (133087 - 139959 == -6872)
					{
						this.$mPos$31647 = mPos;
						if (166874 - 275120 == -108246)
						{
							this.$tDir$31648 = tDir;
							if (202440 - 46052 == 156388)
							{
								this.$self_$31649 = self_;
								if (59089 - 226661 != -167571)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x008841A8 File Offset: 0x008823A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DarkFalcon.$RPC_cAttack$31632.$(this.$mPos$31647, this.$tDir$31648, this.$self_$31649);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x008841C4 File Offset: 0x008823C4
		internal static bool QTGPys5nPe0UnK2Z1CZa()
		{
			return true;
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x008841C8 File Offset: 0x008823C8
		internal static bool OQ8fZV5n0JwZIIht9jMU()
		{
			return false;
		}

		// Token: 0x04004F7C RID: 20348
		internal Vector3 $mPos$31647;

		// Token: 0x04004F7D RID: 20349
		internal Vector3 $tDir$31648;

		// Token: 0x04004F7E RID: 20350
		internal DarkFalcon $self_$31649;

		// Token: 0x02000BD8 RID: 3032
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060043B4 RID: 17332 RVA: 0x008841CC File Offset: 0x008823CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
			{
				if (168693 - 519605 != -350911)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222023 - 404305 == -182282)
					{
						base..ctor();
						if (247798 - 453962 == -206164)
						{
							this.$mPos$31644 = mPos;
							if (114174 - 38861 != 75314)
							{
								this.$tDir$31645 = tDir;
								if (175844 - 365199 != -189354)
								{
									this.$self_$31646 = self_;
									if (256990 - 80738 != 176253)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060043B5 RID: 17333 RVA: 0x008842A8 File Offset: 0x008824A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82322 - 152652 != -70330)
				{
				}
				for (;;)
				{
					IL_362:
					switch (this._state)
					{
					case 0:
						goto IL_E1C;
					case 1:
						goto IL_EE9;
					case 2:
						if (this.$self_$31646.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_457;
						}
						if (89340 - 545638 != -456298)
						{
							continue;
						}
						if (this.$self_$31646.BGihJ8vWxE.myCommand != "cAttack")
						{
							if (115092 - 472882 != -357790)
							{
								continue;
							}
							goto IL_457;
						}
						else
						{
							this.$self_$31646.BGihJ8vWxE.moveSpeed = (float)16;
							if (243856 - 3237 == 240620)
							{
								continue;
							}
							if (this.$self_$31646.cAttack_ring)
							{
								if (246326 - 437975 != -191649)
								{
									continue;
								}
								this.$self_$31646.BGihJ8vWxE.createEffect(this.$self_$31646.cAttack_ring, this.$self_$31646.transform.position, this.$self_$31646.transform.rotation);
								if (219178 - 599793 != -380615)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring gameObject");
								if (227777 - 135409 != 92368)
								{
									continue;
								}
							}
							this.$ignoreLayer$31633 = 130818;
							if (57529 - 9434 != 48095)
							{
								continue;
							}
							this.$ignoreList$31634 = Damage.FindAreaTarget(this.$self_$31646.OxshI6kQmV.position, (float)50, (float)10, this.$ignoreLayer$31633);
							if (34525 - 342022 == -307496)
							{
								continue;
							}
							this.$$iterator$10707$31636 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$31634);
							if (261876 - 264533 != -2657)
							{
								continue;
							}
							while (this.$$iterator$10707$31636.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10707$31636.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$ignoreObject$31635 = (GameObject)obj2;
								if (278275 - 335055 != -56780)
								{
									goto IL_362;
								}
								if (this.$ignoreObject$31635)
								{
									if (50509 - 276637 == -226127)
									{
										goto IL_362;
									}
									if (this.$self_$31646.gameObject != this.$ignoreObject$31635)
									{
										if (126376 - 335483 == -209106)
										{
											goto IL_362;
										}
										Physics.IgnoreCollision(this.$self_$31646.gameObject.collider, this.$ignoreObject$31635.collider, true);
										if (88374 - 364964 != -276590)
										{
											goto IL_362;
										}
										UnityRuntimeServices.Update(this.$$iterator$10707$31636, this.$ignoreObject$31635);
										if (293022 - 591875 == -298852)
										{
											goto IL_362;
										}
									}
								}
							}
							if (4853 - 381851 != -376998)
							{
								continue;
							}
							this.$i$31637 = 0;
							if (66862 - 73920 == -7057)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31646.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_9E9;
						}
						if (250652 - 374250 != -123598)
						{
							continue;
						}
						if (this.$self_$31646.BGihJ8vWxE.myCommand != "cAttack")
						{
							if (261761 - 49821 != 211940)
							{
								continue;
							}
							goto IL_9E9;
						}
						else
						{
							if (this.$self_$31646.BGihJ8vWxE.isMine)
							{
								if (149619 - 201072 != -51453)
								{
									continue;
								}
								this.$hitLayer$31638 = 130816 - (1 << this.$self_$31646.gameObject.layer);
								if (104916 - 154302 == -49385)
								{
									continue;
								}
								this.$hitList$31639 = Damage.FindRecTarget(this.$self_$31646.transform.position, -this.$self_$31646.transform.forward, (float)4, (float)4, (float)3, (float)3, this.$hitLayer$31638);
								if (73943 - 216400 == -142456)
								{
									continue;
								}
								this.$$iterator$10708$31641 = UnityRuntimeServices.GetEnumerator(this.$hitList$31639);
								if (102456 - 375913 != -273457)
								{
									continue;
								}
								while (this.$$iterator$10708$31641.MoveNext())
								{
									object obj4;
									object obj3 = obj4 = this.$$iterator$10708$31641.Current;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									this.$hitObject$31640 = (GameObject)obj4;
									if (257369 - 594479 == -337109)
									{
										goto IL_362;
									}
									this.$self_$31646.BGihJ8vWxE.hit(11, this.$hitObject$31640, (int)(0.6f * (float)this.$self_$31646.BGihJ8vWxE.atk + (float)this.$self_$31646.BGihJ8vWxE.talAdjust(66)), 5, 0, this.$self_$31646.transform.forward);
									if (49228 - 21282 == 27947)
									{
										goto IL_362;
									}
									UnityRuntimeServices.Update(this.$$iterator$10708$31641, this.$hitObject$31640);
									if (281214 - 498666 != -217452)
									{
										goto IL_362;
									}
								}
								if (254008 - 581181 == -327172)
								{
									continue;
								}
							}
							this.$i$31637++;
							if (200192 - 289521 == -89328)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$31646.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_C2;
						}
						if (107456 - 497220 != -389764)
						{
							continue;
						}
						if (this.$self_$31646.BGihJ8vWxE.myCommand != "cAttack")
						{
							if (7692 - 478389 != -470696)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							this.$self_$31646.BGihJ8vWxE.moveSpeed = (float)6;
							if (24144 - 338450 != -314305)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$31646.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_78E;
						}
						if (298544 - 131611 != 166933)
						{
							continue;
						}
						if (this.$self_$31646.BGihJ8vWxE.myCommand != "cAttack")
						{
							if (231971 - 99819 != 132152)
							{
								continue;
							}
							goto IL_78E;
						}
						else
						{
							this.$self_$31646.BGihJ8vWxE.moveSpeed = (float)3;
							if (256345 - 321933 != -65587)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$31646.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_2B5;
						}
						if (16749 - 93915 == -77165)
						{
							continue;
						}
						if (this.$self_$31646.BGihJ8vWxE.myCommand != "cAttack")
						{
							if (2219 - 210001 != -207781)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$31646.BGihJ8vWxE.moveSpeed = (float)0;
							if (39013 - 14519 != 24494)
							{
								continue;
							}
							goto IL_C22;
						}
						break;
					case 7:
						if (this.$self_$31646.BGihJ8vWxE.actionState == "attack")
						{
							if (91665 - 140199 != -48534)
							{
								continue;
							}
							if (this.$self_$31646.BGihJ8vWxE.myCommand == "cAttack")
							{
								if (127667 - 543213 != -415546)
								{
									continue;
								}
								this.$self_$31646.BGihJ8vWxE.actionState = "standby";
								if (171708 - 272625 == -100916)
								{
									continue;
								}
								this.$self_$31646.BGihJ8vWxE.actionTime = Time.time;
								if (55547 - 333396 != -277849)
								{
									continue;
								}
								this.$self_$31646.BGihJ8vWxE.myCommand = "none";
								if (221387 - 378255 == -156867)
								{
									continue;
								}
								if (!this.$self_$31646.BGihJ8vWxE.isMine)
								{
									if (16862 - 537887 != -521025)
									{
										continue;
									}
									this.$self_$31646.BGihJ8vWxE.nPosition = this.$self_$31646.transform.position;
									if (193223 - 429638 == -236414)
									{
										continue;
									}
									this.$self_$31646.BGihJ8vWxE.oPosition = this.$self_$31646.transform.position;
									if (27706 - 376537 != -348831)
									{
										continue;
									}
									this.$self_$31646.BGihJ8vWxE.nDirection = this.$self_$31646.transform.forward;
									if (78729 - 266734 == -188004)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (68432 - 31721 != 36711)
						{
							continue;
						}
						goto IL_EE9;
					default:
						if (91851 - 575283 != -483431)
						{
							goto IL_E1C;
						}
						continue;
					}
					if (this.$i$31637 < 3)
					{
						break;
					}
					if (244322 - 519827 == -275504)
					{
						continue;
					}
					this.$$iterator$10709$31643 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$31634);
					if (283484 - 470690 != -187206)
					{
						continue;
					}
					while (this.$$iterator$10709$31643.MoveNext())
					{
						object obj6;
						object obj5 = obj6 = this.$$iterator$10709$31643.Current;
						if (!(obj5 is GameObject))
						{
							obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
						}
						this.$ignoreObject$31642 = (GameObject)obj6;
						if (81482 - 575328 == -493845)
						{
							goto IL_362;
						}
						if (this.$ignoreObject$31642)
						{
							if (201343 - 412194 != -210851)
							{
								goto IL_362;
							}
							if (this.$self_$31646.gameObject != this.$ignoreObject$31642)
							{
								if (28431 - 113907 != -85476)
								{
									goto IL_362;
								}
								Physics.IgnoreCollision(this.$self_$31646.gameObject.collider, this.$ignoreObject$31642.collider, false);
								if (76970 - 184642 == -107671)
								{
									goto IL_362;
								}
								UnityRuntimeServices.Update(this.$$iterator$10709$31643, this.$ignoreObject$31642);
								if (177525 - 388865 != -211340)
								{
									goto IL_362;
								}
							}
						}
					}
					if (38478 - 188344 != -149866)
					{
						continue;
					}
					goto IL_E9A;
					IL_E1C:
					this.$self_$31646.BGihJ8vWxE.actionState = "attack";
					if (219985 - 597554 == -377569)
					{
						this.$self_$31646.BGihJ8vWxE.actionTime = Time.time;
						if (204898 - 489610 == -284712)
						{
							this.$self_$31646.BGihJ8vWxE.myCommand = "cAttack";
							if (242945 - 384777 == -141832)
							{
								this.$self_$31646.BGihJ8vWxE.addTimeOut("cAttack", (float)13);
								if (252844 - 362259 != -109414)
								{
									this.$self_$31646.transform.position = this.$mPos$31644;
									if (243700 - 32420 != 211281)
									{
										this.$self_$31646.transform.LookAt(this.$mPos$31644 + global::Math.vFlat(this.$tDir$31645));
										if (36026 - 285254 != -249227)
										{
											this.$self_$31646.animation.CrossFade("cAttack", 0.1f);
											if (37382 - 565736 == -528354)
											{
												this.$self_$31646.animation.wrapMode = WrapMode.Once;
												if (259463 - 564674 != -305210)
												{
													this.$self_$31646.BGihJ8vWxE.vMovement = this.$self_$31646.transform.forward;
													if (261607 - 165904 != 95704)
													{
														this.$self_$31646.BGihJ8vWxE.moveSpeed = (float)0;
														if (7680 - 149894 == -142214)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_AD2;
															}
															if (281521 - 360845 != -79323)
															{
																if (this.$self_$31646.cAttack_vc)
																{
																	if (288845 - 519363 != -230517)
																	{
																		this.$self_$31646.audio.PlayOneShot(this.$self_$31646.cAttack_vc);
																		if (299509 - 488982 == -189473)
																		{
																			goto IL_A48;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing cAttack voice");
																	if (149685 - 85659 == 64026)
																	{
																		goto IL_AD2;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_C2:
				goto IL_EE9;
				Block_6:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_2B5:
				Block_28:
				IL_457:
				IL_78E:
				goto IL_EE9;
				Block_51:
				return this.Yield(6, new WaitForSeconds(0.1f));
				Block_63:
				IL_9E9:
				goto IL_EE9;
				IL_A48:
				IL_AD2:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_C22:
				return this.Yield(7, new WaitForSeconds(0.3f));
				IL_E9A:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_EE9:
				return false;
			}

			// Token: 0x060043B6 RID: 17334 RVA: 0x008851B0 File Offset: 0x008833B0
			internal static bool vuNOYQ5nbQkq5BtAHyfL()
			{
				return true;
			}

			// Token: 0x060043B7 RID: 17335 RVA: 0x008851B4 File Offset: 0x008833B4
			internal static bool Wgo4Si5nubZUtsosyfB5()
			{
				return false;
			}

			// Token: 0x04004F7F RID: 20351
			internal int $ignoreLayer$31633;

			// Token: 0x04004F80 RID: 20352
			internal UnityScript.Lang.Array $ignoreList$31634;

			// Token: 0x04004F81 RID: 20353
			internal GameObject $ignoreObject$31635;

			// Token: 0x04004F82 RID: 20354
			internal IEnumerator $$iterator$10707$31636;

			// Token: 0x04004F83 RID: 20355
			internal int $i$31637;

			// Token: 0x04004F84 RID: 20356
			internal int $hitLayer$31638;

			// Token: 0x04004F85 RID: 20357
			internal UnityScript.Lang.Array $hitList$31639;

			// Token: 0x04004F86 RID: 20358
			internal GameObject $hitObject$31640;

			// Token: 0x04004F87 RID: 20359
			internal IEnumerator $$iterator$10708$31641;

			// Token: 0x04004F88 RID: 20360
			internal GameObject $ignoreObject$31642;

			// Token: 0x04004F89 RID: 20361
			internal IEnumerator $$iterator$10709$31643;

			// Token: 0x04004F8A RID: 20362
			internal Vector3 $mPos$31644;

			// Token: 0x04004F8B RID: 20363
			internal Vector3 $tDir$31645;

			// Token: 0x04004F8C RID: 20364
			internal DarkFalcon $self_$31646;
		}
	}

	// Token: 0x02000BD9 RID: 3033
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_thousandShot$31650 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x060043B8 RID: 17336 RVA: 0x008851B8 File Offset: 0x008833B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_thousandShot$31650(Vector3 mPos, Vector3 tDir, int tID, DarkFalcon self_)
		{
			if (50750 - 174260 != -123510)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276411 - 424118 != -147706)
				{
					base..ctor();
					if (144890 - 246762 != -101871)
					{
						this.$mPos$31662 = mPos;
						if (222662 - 511751 != -289088)
						{
							this.$tDir$31663 = tDir;
							if (126125 - 520989 == -394864)
							{
								this.$tID$31664 = tID;
								if (265819 - 331927 == -66108)
								{
									this.$self_$31665 = self_;
									if (145839 - 124019 != 21821)
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

		// Token: 0x060043B9 RID: 17337 RVA: 0x008852B8 File Offset: 0x008834B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new DarkFalcon.$RPC_thousandShot$31650.$(this.$mPos$31662, this.$tDir$31663, this.$tID$31664, this.$self_$31665);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x008852D8 File Offset: 0x008834D8
		internal static bool hn274S5nIZp7gILTcU9e()
		{
			return true;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x008852DC File Offset: 0x008834DC
		internal static bool I7thaL5nBIR1mXYcS6pY()
		{
			return false;
		}

		// Token: 0x04004F8D RID: 20365
		internal Vector3 $mPos$31662;

		// Token: 0x04004F8E RID: 20366
		internal Vector3 $tDir$31663;

		// Token: 0x04004F8F RID: 20367
		internal int $tID$31664;

		// Token: 0x04004F90 RID: 20368
		internal DarkFalcon $self_$31665;

		// Token: 0x02000BDA RID: 3034
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x060043BC RID: 17340 RVA: 0x008852E0 File Offset: 0x008834E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, DarkFalcon self_)
			{
				if (118660 - 268925 != -150265)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254238 - 417357 == -163119)
					{
						base..ctor();
						if (234375 - 325392 != -91016)
						{
							this.$mPos$31658 = mPos;
							if (280917 - 89536 == 191381)
							{
								this.$tDir$31659 = tDir;
								if (154245 - 505203 != -350957)
								{
									this.$tID$31660 = tID;
									if (196043 - 510741 != -314697)
									{
										this.$self_$31661 = self_;
										if (177898 - 231806 != -53907)
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

			// Token: 0x060043BD RID: 17341 RVA: 0x008853E0 File Offset: 0x008835E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83357 - 25606 != 57751)
				{
				}
				for (;;)
				{
					IL_8D6:
					switch (this._state)
					{
					case 0:
						goto IL_694;
					case 1:
						goto IL_D0D;
					case 2:
						if (this.$self_$31661.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_80E;
						}
						if (252213 - 18718 != 233495)
						{
							continue;
						}
						if (!(this.$self_$31661.BGihJ8vWxE.myCommand != "thousandShot"))
						{
							goto IL_813;
						}
						if (213527 - 390682 != -177154)
						{
							goto Block_80;
						}
						continue;
					case 3:
						if (this.$self_$31661.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_966;
						}
						if (296951 - 503132 != -206181)
						{
							continue;
						}
						if (this.$self_$31661.BGihJ8vWxE.myCommand != "thousandShot")
						{
							if (28426 - 475801 != -447374)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (this.$self_$31661.thousandShot_fire)
							{
								if (197031 - 446049 == -249017)
								{
									continue;
								}
								this.$self_$31661.BGihJ8vWxE.createEffect(this.$self_$31661.thousandShot_fire, this.$self_$31661.transform.position, this.$self_$31661.transform.rotation);
								if (259451 - 235714 == 23738)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing thousandShot_fire gameObject");
								if (118342 - 352854 == -234511)
								{
									continue;
								}
							}
							this.$i$31652 = 0;
							if (153994 - 13033 == 140962)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$31661.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_667;
						}
						if (68660 - 49383 != 19277)
						{
							continue;
						}
						if (this.$self_$31661.BGihJ8vWxE.myCommand != "thousandShot")
						{
							if (238973 - 170587 != 68387)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$i$31652++;
							if (175722 - 137188 != 38534)
							{
								continue;
							}
						}
						break;
					case 5:
						if (this.$self_$31661.BGihJ8vWxE.actionState == "attack")
						{
							if (293381 - 218333 == 75049)
							{
								continue;
							}
							if (this.$self_$31661.BGihJ8vWxE.myCommand == "thousandShot")
							{
								if (297629 - 504624 != -206995)
								{
									continue;
								}
								this.$self_$31661.BGihJ8vWxE.actionState = "standby";
								if (41438 - 34908 != 6530)
								{
									continue;
								}
								this.$self_$31661.BGihJ8vWxE.actionTime = Time.time;
								if (71537 - 590641 != -519104)
								{
									continue;
								}
								this.$self_$31661.BGihJ8vWxE.myCommand = "none";
								if (88947 - 100282 != -11335)
								{
									continue;
								}
								if (!this.$self_$31661.BGihJ8vWxE.isMine)
								{
									if (213417 - 473485 != -260068)
									{
										continue;
									}
									this.$self_$31661.BGihJ8vWxE.nPosition = this.$self_$31661.transform.position;
									if (69407 - 226812 != -157405)
									{
										continue;
									}
									this.$self_$31661.BGihJ8vWxE.oPosition = this.$self_$31661.transform.position;
									if (184924 - 272295 != -87371)
									{
										continue;
									}
									this.$self_$31661.BGihJ8vWxE.nDirection = this.$self_$31661.transform.forward;
									if (276956 - 61164 == 215793)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (168954 - 496565 != -327610)
						{
							goto Block_36;
						}
						continue;
					default:
						if (204172 - 539627 != -335455)
						{
							continue;
						}
						goto IL_694;
					}
					if (this.$i$31652 >= 10)
					{
						if (125424 - 240138 == -114713)
						{
							continue;
						}
						this.$self_$31661.animation.CrossFade("root", 0.3f);
						if (220215 - 550316 == -330100)
						{
							continue;
						}
						this.$self_$31661.animation.wrapMode = WrapMode.Loop;
						if (143388 - 355457 != -212068)
						{
							break;
						}
						continue;
					}
					else
					{
						if (!this.$self_$31661.BGihJ8vWxE.isMine)
						{
							goto IL_AEA;
						}
						if (257495 - 68521 != 188974)
						{
							continue;
						}
						this.$hitLayer$31653 = 130816 - (1 << this.$self_$31661.gameObject.layer);
						if (147992 - 263155 == -115162)
						{
							continue;
						}
						this.$hitList$31654 = Damage.FindRecTarget(this.$self_$31661.transform.position, this.$self_$31661.transform.forward, (float)5, (float)5, (float)40, (float)10, this.$hitLayer$31653);
						if (111459 - 252039 != -140580)
						{
							continue;
						}
						this.$$iterator$10710$31657 = UnityRuntimeServices.GetEnumerator(this.$hitList$31654);
						if (200056 - 45347 == 154710)
						{
							continue;
						}
						while (this.$$iterator$10710$31657.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10710$31657.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$31655 = (GameObject)obj2;
							if (100920 - 160691 == -59770)
							{
								goto IL_8D6;
							}
							if (this.$self_$31661.BGihJ8vWxE.hit(21, this.$hitObject$31655, 499, 9, 0, this.$self_$31661.transform.forward) != 0)
							{
								if (165908 - 95800 != 70108)
								{
									goto IL_8D6;
								}
								this.$hitPos$31656 = this.$hitObject$31655.collider.bounds.center;
								if (169474 - 311563 == -142088)
								{
									goto IL_8D6;
								}
								UnityRuntimeServices.Update(this.$$iterator$10710$31657, this.$hitObject$31655);
								if (134893 - 41603 == 93291)
								{
									goto IL_8D6;
								}
								this.$self_$31661.RPC_thousandShot_hit(this.$hitPos$31656, this.$self_$31661.transform.forward, 0);
								if (197039 - 137118 != 59921)
								{
									goto IL_8D6;
								}
								if (PhotonClient.IsInitialized())
								{
									if (43482 - 342732 == -299249)
									{
										goto IL_8D6;
									}
									this.$self_$31661.ActionEvent("RPC_thousandShot_hit", this.$hitPos$31656, this.$self_$31661.transform.forward, 0);
									if (98871 - 392005 != -293134)
									{
										goto IL_8D6;
									}
								}
							}
						}
						if (293823 - 210393 != 83430)
						{
							continue;
						}
						goto IL_AEA;
					}
					IL_694:
					this.$self_$31661.BGihJ8vWxE.actionState = "attack";
					if (47350 - 202434 != -155084)
					{
						continue;
					}
					this.$self_$31661.BGihJ8vWxE.actionTime = Time.time;
					if (262205 - 471379 == -209173)
					{
						continue;
					}
					this.$self_$31661.BGihJ8vWxE.myCommand = "thousandShot";
					if (52359 - 34529 == 17831)
					{
						continue;
					}
					this.$self_$31661.BGihJ8vWxE.addTimeOut("thousandShot", (float)60);
					if (196649 - 589798 == -393148)
					{
						continue;
					}
					this.$self_$31661.transform.position = this.$mPos$31658;
					if (92217 - 373594 == -281376)
					{
						continue;
					}
					this.$self_$31661.transform.LookAt(this.$mPos$31658 + global::Math.vFlat(this.$tDir$31659));
					if (3769 - 461557 == -457787)
					{
						continue;
					}
					this.$self_$31661.animation.CrossFade("thousandShot", 0.1f);
					if (191486 - 65473 == 126014)
					{
						continue;
					}
					this.$self_$31661.animation.wrapMode = WrapMode.Once;
					if (65147 - 383774 != -318627)
					{
						continue;
					}
					this.$self_$31661.BGihJ8vWxE.vMovement = this.$self_$31661.transform.forward;
					if (2302 - 323577 != -321275)
					{
						continue;
					}
					this.$self_$31661.BGihJ8vWxE.moveSpeed = (float)0;
					if (10288 - 445814 != -435526)
					{
						continue;
					}
					if (this.$self_$31661.thousandShot_ring)
					{
						if (236764 - 598929 == -362164)
						{
							continue;
						}
						this.$self_$31661.BGihJ8vWxE.createEffect(this.$self_$31661.thousandShot_ring, this.$self_$31661.transform.position, this.$self_$31661.transform.rotation);
						if (269789 - 231168 != 38621)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing thousandShot_ring gameObject");
						if (19529 - 122783 != -103254)
						{
							continue;
						}
					}
					if (PlayerPrefs.GetInt("pvoice", 1) != 0)
					{
						if (29534 - 215104 == -185569)
						{
							continue;
						}
						if (this.$self_$31661.thousandShot_vc)
						{
							if (93410 - 471038 == -377627)
							{
								continue;
							}
							this.$self_$31661.audio.PlayOneShot(this.$self_$31661.thousandShot_vc);
							if (149631 - 370951 != -221320)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing thousandShot voice");
							if (188465 - 383977 != -195512)
							{
								continue;
							}
						}
					}
					this.$tObject$31651 = null;
					if (273119 - 524591 == -251471)
					{
						continue;
					}
					if (this.$tID$31660 != 0)
					{
						if (75233 - 504456 != -429223)
						{
							continue;
						}
						object obj4;
						object obj3 = obj4 = PhotonClient.ActorNrList[this.$tID$31660];
						if (!(obj3 is GameObject))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
						}
						this.$tObject$31651 = (GameObject)obj4;
						if (152993 - 198547 != -45554)
						{
							continue;
						}
					}
					IL_813:
					if (Time.time >= this.$self_$31661.BGihJ8vWxE.actionTime + 2f)
					{
						if (236115 - 491339 != -255223)
						{
							goto Block_52;
						}
					}
					else
					{
						if (!this.$tObject$31651)
						{
							goto IL_9CA;
						}
						if (90934 - 378450 != -287515)
						{
							if (!(this.$tObject$31651 != this.$self_$31661.gameObject))
							{
								goto IL_9CA;
							}
							if (246894 - 203289 != 43606)
							{
								this.$self_$31661.transform.LookAt(this.$tObject$31651.transform.position);
								if (229258 - 240577 != -11318)
								{
									goto Block_37;
								}
							}
						}
					}
				}
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_27:
				Block_36:
				goto IL_D0D;
				Block_37:
				goto IL_9CA;
				IL_667:
				Block_46:
				IL_80E:
				goto IL_D0D;
				Block_52:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_966:
				goto IL_D0D;
				IL_9CA:
				return this.Yield(2, new WaitForFixedUpdate());
				IL_AEA:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_80:
				IL_D0D:
				return false;
			}

			// Token: 0x060043BE RID: 17342 RVA: 0x0088610C File Offset: 0x0088430C
			internal static bool sIYBMN5neBauhKjP2xmY()
			{
				return true;
			}

			// Token: 0x060043BF RID: 17343 RVA: 0x00886110 File Offset: 0x00884310
			internal static bool Mn4uln5nrH4Yj4gC7kZG()
			{
				return false;
			}

			// Token: 0x04004F91 RID: 20369
			internal GameObject $tObject$31651;

			// Token: 0x04004F92 RID: 20370
			internal int $i$31652;

			// Token: 0x04004F93 RID: 20371
			internal int $hitLayer$31653;

			// Token: 0x04004F94 RID: 20372
			internal UnityScript.Lang.Array $hitList$31654;

			// Token: 0x04004F95 RID: 20373
			internal GameObject $hitObject$31655;

			// Token: 0x04004F96 RID: 20374
			internal Vector3 $hitPos$31656;

			// Token: 0x04004F97 RID: 20375
			internal IEnumerator $$iterator$10710$31657;

			// Token: 0x04004F98 RID: 20376
			internal Vector3 $mPos$31658;

			// Token: 0x04004F99 RID: 20377
			internal Vector3 $tDir$31659;

			// Token: 0x04004F9A RID: 20378
			internal int $tID$31660;

			// Token: 0x04004F9B RID: 20379
			internal DarkFalcon $self_$31661;
		}
	}

	// Token: 0x02000BDB RID: 3035
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nightmare$31666 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060043C0 RID: 17344 RVA: 0x00886114 File Offset: 0x00884314
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nightmare$31666(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
		{
			if (64388 - 157945 != -93557)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278203 - 200335 == 77868)
				{
					base..ctor();
					if (248196 - 25401 != 222796)
					{
						this.$mPos$31675 = mPos;
						if (56321 - 434831 == -378510)
						{
							this.$tDir$31676 = tDir;
							if (108820 - 40652 != 68169)
							{
								this.$self_$31677 = self_;
								if (56543 - 330764 == -274221)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x008861F0 File Offset: 0x008843F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DarkFalcon.$RPC_nightmare$31666.$(this.$mPos$31675, this.$tDir$31676, this.$self_$31677);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x0088620C File Offset: 0x0088440C
		internal static bool TOipeH5njifMlVPuobLj()
		{
			return true;
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00886210 File Offset: 0x00884410
		internal static bool hF8Jo25nhofPoDSCNrs7()
		{
			return false;
		}

		// Token: 0x04004F9C RID: 20380
		internal Vector3 $mPos$31675;

		// Token: 0x04004F9D RID: 20381
		internal Vector3 $tDir$31676;

		// Token: 0x04004F9E RID: 20382
		internal DarkFalcon $self_$31677;

		// Token: 0x02000BDC RID: 3036
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060043C4 RID: 17348 RVA: 0x00886214 File Offset: 0x00884414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
			{
				if (22692 - 563894 != -541202)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174782 - 256790 != -82007)
					{
						base..ctor();
						if (31883 - 380852 != -348968)
						{
							this.$mPos$31672 = mPos;
							if (240934 - 295645 != -54710)
							{
								this.$tDir$31673 = tDir;
								if (254800 - 519978 != -265177)
								{
									this.$self_$31674 = self_;
									if (190553 - 24406 == 166147)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060043C5 RID: 17349 RVA: 0x008862F0 File Offset: 0x008844F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288279 - 399750 != -111471)
				{
				}
				for (;;)
				{
					IL_214:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_913;
					case 2:
						if (this.$self_$31674.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_2A1;
						}
						if (180967 - 11379 == 169589)
						{
							continue;
						}
						if (this.$self_$31674.BGihJ8vWxE.myCommand != "nightmare")
						{
							if (187085 - 231806 != -44720)
							{
								goto Block_30;
							}
							continue;
						}
						else if (this.$self_$31674.nightmare_ring)
						{
							if (11455 - 441285 != -429830)
							{
								continue;
							}
							this.$self_$31674.BGihJ8vWxE.createEffect(this.$self_$31674.nightmare_ring, this.$self_$31674.transform.position, this.$self_$31674.transform.rotation);
							if (25109 - 110914 != -85805)
							{
								continue;
							}
							goto IL_278;
						}
						else
						{
							Debug.LogError("Missing nightmare_ring gameObject");
							if (285091 - 330536 != -45445)
							{
								continue;
							}
							goto IL_651;
						}
						break;
					case 3:
						if (this.$self_$31674.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_404;
						}
						if (276048 - 82749 == 193300)
						{
							continue;
						}
						if (this.$self_$31674.BGihJ8vWxE.myCommand != "nightmare")
						{
							if (152756 - 47477 != 105279)
							{
								continue;
							}
							goto IL_404;
						}
						else
						{
							if (!this.$self_$31674.BGihJ8vWxE.isMine)
							{
								goto IL_599;
							}
							if (176151 - 467197 == -291045)
							{
								continue;
							}
							this.$hitLayer$31667 = 130816 - (1 << this.$self_$31674.gameObject.layer);
							if (121350 - 278547 != -157197)
							{
								continue;
							}
							this.$hitList$31668 = Damage.FindAreaTarget(this.$self_$31674.transform.position, (float)50, (float)10, this.$hitLayer$31667);
							if (184056 - 339717 == -155660)
							{
								continue;
							}
							this.$$iterator$10711$31671 = UnityRuntimeServices.GetEnumerator(this.$hitList$31668);
							if (59719 - 494894 == -435174)
							{
								continue;
							}
							while (this.$$iterator$10711$31671.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10711$31671.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31669 = (GameObject)obj2;
								if (129991 - 571857 != -441866)
								{
									goto IL_214;
								}
								this.$hitChar$31670 = (CharacterControl)this.$hitObject$31669.GetComponent(typeof(CharacterControl));
								if (256438 - 517664 == -261225)
								{
									goto IL_214;
								}
								UnityRuntimeServices.Update(this.$$iterator$10711$31671, this.$hitObject$31669);
								if (87856 - 35158 != 52698)
								{
									goto IL_214;
								}
								if (this.$hitChar$31670)
								{
									if (244008 - 223528 == 20481)
									{
										goto IL_214;
									}
									this.$hitChar$31670.RPC_AddStatus("nightmare", 4, Damage.getDebuff((float)6, this.$self_$31674.BGihJ8vWxE.cha, this.$hitChar$31670.cha), 0, this.$self_$31674.BGihJ8vWxE.ActorNr);
									if (151597 - 349520 == -197922)
									{
										goto IL_214;
									}
								}
							}
							if (76857 - 96629 != -19771)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31674.BGihJ8vWxE.actionState == "attack")
						{
							if (253530 - 129356 != 124174)
							{
								continue;
							}
							if (this.$self_$31674.BGihJ8vWxE.myCommand == "nightmare")
							{
								if (9745 - 47609 != -37864)
								{
									continue;
								}
								this.$self_$31674.BGihJ8vWxE.actionState = "standby";
								if (58261 - 449320 != -391059)
								{
									continue;
								}
								this.$self_$31674.BGihJ8vWxE.actionTime = Time.time;
								if (228370 - 169864 == 58507)
								{
									continue;
								}
								this.$self_$31674.BGihJ8vWxE.myCommand = "none";
								if (86421 - 324595 == -238173)
								{
									continue;
								}
								if (!this.$self_$31674.BGihJ8vWxE.isMine)
								{
									if (294792 - 175254 == 119539)
									{
										continue;
									}
									this.$self_$31674.BGihJ8vWxE.nPosition = this.$self_$31674.transform.position;
									if (205786 - 91245 == 114542)
									{
										continue;
									}
									this.$self_$31674.BGihJ8vWxE.oPosition = this.$self_$31674.transform.position;
									if (185261 - 542741 == -357479)
									{
										continue;
									}
									this.$self_$31674.BGihJ8vWxE.nDirection = this.$self_$31674.transform.forward;
									if (115114 - 173665 != -58551)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (101643 - 554586 != -452942)
						{
							goto Block_54;
						}
						continue;
					default:
						if (229511 - 477884 != -248373)
						{
							continue;
						}
						break;
					}
					this.$self_$31674.BGihJ8vWxE.actionState = "attack";
					if (287065 - 589945 != -302879)
					{
						this.$self_$31674.BGihJ8vWxE.actionTime = Time.time;
						if (168147 - 469959 != -301811)
						{
							this.$self_$31674.BGihJ8vWxE.myCommand = "nightmare";
							if (254538 - 425756 == -171218)
							{
								this.$self_$31674.BGihJ8vWxE.addTimeOut("nightmare", (float)90);
								if (174563 - 547895 != -373331)
								{
									this.$self_$31674.transform.position = this.$mPos$31672;
									if (218819 - 301229 != -82409)
									{
										this.$self_$31674.transform.LookAt(this.$mPos$31672 + global::Math.vFlat(this.$tDir$31673));
										if (255590 - 409303 != -153712)
										{
											this.$self_$31674.animation.CrossFade("cast", 0.1f);
											if (154221 - 328995 != -174773)
											{
												this.$self_$31674.animation.wrapMode = WrapMode.Once;
												if (78964 - 46335 != 32630)
												{
													this.$self_$31674.BGihJ8vWxE.vMovement = this.$self_$31674.transform.forward;
													if (188865 - 569562 != -380696)
													{
														this.$self_$31674.BGihJ8vWxE.moveSpeed = (float)0;
														if (227243 - 120575 == 106668)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (286609 - 238460 == 48149)
															{
																if (this.$self_$31674.nAttack1_vc)
																{
																	if (239405 - 409423 == -170018)
																	{
																		this.$self_$31674.audio.PlayOneShot(this.$self_$31674.nAttack1_vc);
																		if (269227 - 297621 != -28393)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack1 voice");
																	if (276921 - 535174 != -258252)
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
				goto IL_386;
				IL_278:
				goto IL_651;
				IL_2A1:
				goto IL_913;
				IL_386:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_404:
				goto IL_913;
				Block_28:
				goto IL_599;
				Block_30:
				goto IL_2A1;
				goto IL_386;
				IL_599:
				return this.Yield(4, new WaitForSeconds(0.8f));
				IL_651:
				return this.Yield(3, new WaitForSeconds(0.7f));
				Block_54:
				IL_913:
				return false;
			}

			// Token: 0x060043C6 RID: 17350 RVA: 0x00886C24 File Offset: 0x00884E24
			internal static bool Jqkgsh5ns8csiQpQxTgN()
			{
				return true;
			}

			// Token: 0x060043C7 RID: 17351 RVA: 0x00886C28 File Offset: 0x00884E28
			internal static bool zYQtdn5n9IoGZ7u8Udmk()
			{
				return false;
			}

			// Token: 0x04004F9F RID: 20383
			internal int $hitLayer$31667;

			// Token: 0x04004FA0 RID: 20384
			internal UnityScript.Lang.Array $hitList$31668;

			// Token: 0x04004FA1 RID: 20385
			internal GameObject $hitObject$31669;

			// Token: 0x04004FA2 RID: 20386
			internal CharacterControl $hitChar$31670;

			// Token: 0x04004FA3 RID: 20387
			internal IEnumerator $$iterator$10711$31671;

			// Token: 0x04004FA4 RID: 20388
			internal Vector3 $mPos$31672;

			// Token: 0x04004FA5 RID: 20389
			internal Vector3 $tDir$31673;

			// Token: 0x04004FA6 RID: 20390
			internal DarkFalcon $self_$31674;
		}
	}

	// Token: 0x02000BDD RID: 3037
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_darkFall$31678 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060043C8 RID: 17352 RVA: 0x00886C2C File Offset: 0x00884E2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_darkFall$31678(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
		{
			if (101522 - 153830 != -52307)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159805 - 490913 == -331108)
				{
					base..ctor();
					if (76752 - 89589 == -12837)
					{
						this.$mPos$31682 = mPos;
						if (17948 - 435763 != -417814)
						{
							this.$tDir$31683 = tDir;
							if (199812 - 79710 != 120103)
							{
								this.$self_$31684 = self_;
								if (15038 - 400230 == -385192)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00886D08 File Offset: 0x00884F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DarkFalcon.$RPC_darkFall$31678.$(this.$mPos$31682, this.$tDir$31683, this.$self_$31684);
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00886D24 File Offset: 0x00884F24
		internal static bool mu7WqY5n1DWI4ufCBYLP()
		{
			return true;
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00886D28 File Offset: 0x00884F28
		internal static bool MMBELp5n4KlrwSE6RsYf()
		{
			return false;
		}

		// Token: 0x04004FA7 RID: 20391
		internal Vector3 $mPos$31682;

		// Token: 0x04004FA8 RID: 20392
		internal Vector3 $tDir$31683;

		// Token: 0x04004FA9 RID: 20393
		internal DarkFalcon $self_$31684;

		// Token: 0x02000BDE RID: 3038
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060043CC RID: 17356 RVA: 0x00886D2C File Offset: 0x00884F2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
			{
				if (229427 - 310729 != -81302)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98624 - 411505 != -312880)
					{
						base..ctor();
						if (264162 - 571528 == -307366)
						{
							this.$mPos$31679 = mPos;
							if (69986 - 306640 == -236654)
							{
								this.$tDir$31680 = tDir;
								if (59848 - 483195 == -423347)
								{
									this.$self_$31681 = self_;
									if (125872 - 470186 == -344314)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060043CD RID: 17357 RVA: 0x00886E08 File Offset: 0x00885008
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48689 - 68713 != -20024)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7BE;
					case 2:
						if (this.$self_$31681.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_112;
						}
						if (177419 - 357337 != -179918)
						{
							continue;
						}
						if (this.$self_$31681.BGihJ8vWxE.myCommand != "darkFall")
						{
							if (48652 - 341079 != -292426)
							{
								goto Block_5;
							}
							continue;
						}
						else if (this.$self_$31681.darkFall_ring)
						{
							if (162869 - 300723 != -137854)
							{
								continue;
							}
							this.$self_$31681.BGihJ8vWxE.createEffect(this.$self_$31681.darkFall_ring, this.$self_$31681.transform.position, this.$self_$31681.transform.rotation);
							if (26798 - 167604 != -140805)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing darkFall_ring gameObject");
							if (81776 - 381165 != -299389)
							{
								continue;
							}
							goto IL_1DE;
						}
						break;
					case 3:
						if (this.$self_$31681.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_1A;
						}
						if (50880 - 107164 != -56284)
						{
							continue;
						}
						if (this.$self_$31681.BGihJ8vWxE.myCommand != "darkFall")
						{
							if (94473 - 105391 != -10918)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							if (!this.$self_$31681.BGihJ8vWxE.isMine)
							{
								goto IL_76F;
							}
							if (41258 - 308860 != -267602)
							{
								continue;
							}
							this.$self_$31681.RPC_darkFall_fire(this.$self_$31681.transform.position, this.$self_$31681.transform.forward, 0);
							if (168695 - 13352 == 155344)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_76F;
							}
							if (249934 - 590573 != -340639)
							{
								continue;
							}
							this.$self_$31681.ActionEvent("RPC_darkFall_fire", this.$self_$31681.transform.position, this.$self_$31681.transform.forward, 0);
							if (166217 - 260400 != -94182)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31681.BGihJ8vWxE.actionState == "attack")
						{
							if (66668 - 3892 == 62777)
							{
								continue;
							}
							if (this.$self_$31681.BGihJ8vWxE.myCommand == "darkFall")
							{
								if (264814 - 581644 != -316830)
								{
									continue;
								}
								this.$self_$31681.BGihJ8vWxE.actionState = "standby";
								if (284060 - 520792 != -236732)
								{
									continue;
								}
								this.$self_$31681.BGihJ8vWxE.actionTime = Time.time;
								if (118529 - 434065 == -315535)
								{
									continue;
								}
								this.$self_$31681.BGihJ8vWxE.myCommand = "none";
								if (157335 - 469329 != -311994)
								{
									continue;
								}
								if (!this.$self_$31681.BGihJ8vWxE.isMine)
								{
									if (15672 - 359414 != -343742)
									{
										continue;
									}
									this.$self_$31681.BGihJ8vWxE.nPosition = this.$self_$31681.transform.position;
									if (53371 - 515934 != -462563)
									{
										continue;
									}
									this.$self_$31681.BGihJ8vWxE.oPosition = this.$self_$31681.transform.position;
									if (15916 - 286811 != -270895)
									{
										continue;
									}
									this.$self_$31681.BGihJ8vWxE.nDirection = this.$self_$31681.transform.forward;
									if (115391 - 468235 != -352844)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (241477 - 41883 != 199595)
						{
							goto Block_6;
						}
						continue;
					default:
						if (204645 - 537790 == -333144)
						{
							continue;
						}
						break;
					}
					this.$self_$31681.BGihJ8vWxE.actionState = "attack";
					if (221741 - 57339 != 164403)
					{
						this.$self_$31681.BGihJ8vWxE.actionTime = Time.time;
						if (7015 - 284176 != -277160)
						{
							this.$self_$31681.BGihJ8vWxE.myCommand = "darkFall";
							if (286803 - 48597 == 238206)
							{
								this.$self_$31681.BGihJ8vWxE.addTimeOut("darkFall", (float)15);
								if (58945 - 111142 == -52197)
								{
									this.$self_$31681.transform.position = this.$mPos$31679;
									if (122973 - 141923 == -18950)
									{
										this.$self_$31681.transform.LookAt(this.$mPos$31679 + global::Math.vFlat(this.$tDir$31680));
										if (154379 - 348433 != -194053)
										{
											this.$self_$31681.animation.CrossFade("darkFall", 0.1f);
											if (227836 - 385166 == -157330)
											{
												this.$self_$31681.animation.wrapMode = WrapMode.Once;
												if (128160 - 571507 != -443346)
												{
													this.$self_$31681.BGihJ8vWxE.vMovement = this.$self_$31681.transform.forward;
													if (68466 - 445760 == -377294)
													{
														this.$self_$31681.BGihJ8vWxE.moveSpeed = (float)0;
														if (175305 - 473501 == -298196)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_50F;
															}
															if (254927 - 568496 == -313569)
															{
																if (this.$self_$31681.darkFall_vc)
																{
																	if (12002 - 367236 != -355233)
																	{
																		this.$self_$31681.audio.PlayOneShot(this.$self_$31681.darkFall_vc);
																		if (116796 - 360544 != -243747)
																		{
																			goto Block_18;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing darkFall voice");
																	if (182896 - 401168 == -218272)
																	{
																		goto IL_50F;
																	}
																}
															}
														}
													}
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
				Block_5:
				Block_6:
				IL_112:
				goto IL_7BE;
				IL_1DE:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_18:
				IL_50F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_37:
				goto IL_76F;
				Block_43:
				goto IL_1DE;
				IL_76F:
				return this.Yield(4, new WaitForSeconds(3.2f));
				IL_7BE:
				return false;
			}

			// Token: 0x060043CE RID: 17358 RVA: 0x008875E8 File Offset: 0x008857E8
			internal static bool CJYu6l5nzFVmHAonLj7T()
			{
				return true;
			}

			// Token: 0x060043CF RID: 17359 RVA: 0x008875EC File Offset: 0x008857EC
			internal static bool CD4tQT56aVrjUa7qmJkI()
			{
				return false;
			}

			// Token: 0x04004FAA RID: 20394
			internal Vector3 $mPos$31679;

			// Token: 0x04004FAB RID: 20395
			internal Vector3 $tDir$31680;

			// Token: 0x04004FAC RID: 20396
			internal DarkFalcon $self_$31681;
		}
	}

	// Token: 0x02000BDF RID: 3039
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_darkStorm$31685 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060043D0 RID: 17360 RVA: 0x008875F0 File Offset: 0x008857F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_darkStorm$31685(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
		{
			if (177322 - 280527 != -103204)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (296918 - 559668 != -262749)
				{
					base..ctor();
					if (75292 - 172455 != -97162)
					{
						this.$mPos$31695 = mPos;
						if (157840 - 134972 == 22868)
						{
							this.$tDir$31696 = tDir;
							if (19670 - 46506 == -26836)
							{
								this.$self_$31697 = self_;
								if (28251 - 152318 == -124067)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x008876CC File Offset: 0x008858CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DarkFalcon.$RPC_darkStorm$31685.$(this.$mPos$31695, this.$tDir$31696, this.$self_$31697);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x008876E8 File Offset: 0x008858E8
		internal static bool WPYR1o565wUIQFKBIF8W()
		{
			return true;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x008876EC File Offset: 0x008858EC
		internal static bool g04RhG56pfkRGDIKoLjp()
		{
			return false;
		}

		// Token: 0x04004FAD RID: 20397
		internal Vector3 $mPos$31695;

		// Token: 0x04004FAE RID: 20398
		internal Vector3 $tDir$31696;

		// Token: 0x04004FAF RID: 20399
		internal DarkFalcon $self_$31697;

		// Token: 0x02000BE0 RID: 3040
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060043D4 RID: 17364 RVA: 0x008876F0 File Offset: 0x008858F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
			{
				if (13625 - 327865 != -314239)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (97330 - 213291 == -115961)
					{
						base..ctor();
						if (295764 - 521790 == -226026)
						{
							this.$mPos$31692 = mPos;
							if (103278 - 420738 == -317460)
							{
								this.$tDir$31693 = tDir;
								if (117489 - 116960 != 530)
								{
									this.$self_$31694 = self_;
									if (257049 - 416040 == -158991)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060043D5 RID: 17365 RVA: 0x008877CC File Offset: 0x008859CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90966 - 63258 != 27708)
				{
				}
				for (;;)
				{
					IL_ACF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B4F;
					case 2:
						if (this.$self_$31694.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_F8;
						}
						if (284425 - 277076 != 7349)
						{
							continue;
						}
						if (this.$self_$31694.BGihJ8vWxE.myCommand != "darkStorm")
						{
							if (28611 - 163092 != -134481)
							{
								continue;
							}
							goto IL_F8;
						}
						else if (this.$self_$31694.darkStorm_ring)
						{
							if (6886 - 185732 != -178846)
							{
								continue;
							}
							this.$self_$31694.BGihJ8vWxE.createEffect(this.$self_$31694.darkStorm_ring, this.$self_$31694.transform.position, this.$self_$31694.transform.rotation);
							if (36867 - 60782 != -23915)
							{
								continue;
							}
							goto IL_165;
						}
						else
						{
							Debug.LogError("Missing darkStorm_ring gameObject");
							if (110855 - 559502 != -448647)
							{
								continue;
							}
							goto IL_A48;
						}
						break;
					case 3:
						if (this.$self_$31694.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_7C2;
						}
						if (96532 - 472591 != -376059)
						{
							continue;
						}
						if (this.$self_$31694.BGihJ8vWxE.myCommand != "darkStorm")
						{
							if (288477 - 211764 != 76713)
							{
								continue;
							}
							goto IL_7C2;
						}
						else
						{
							if (this.$self_$31694.darkStorm_fire)
							{
								if (191565 - 5032 != 186533)
								{
									continue;
								}
								this.$self_$31694.BGihJ8vWxE.createEffect(this.$self_$31694.darkStorm_fire, this.$self_$31694.transform.position, this.$self_$31694.transform.rotation);
								if (256001 - 433959 != -177958)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing darkStorm_ring gameObject");
								if (195387 - 522177 != -326790)
								{
									continue;
								}
							}
							this.$i$31686 = 0;
							if (27722 - 242972 != -215249)
							{
								goto IL_6B2;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31694.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_48A;
						}
						if (38600 - 390796 != -352196)
						{
							continue;
						}
						if (this.$self_$31694.BGihJ8vWxE.myCommand != "darkStorm")
						{
							if (140637 - 512416 != -371778)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$i$31686++;
							if (31036 - 277746 != -246710)
							{
								continue;
							}
							goto IL_6B2;
						}
						break;
					case 5:
						if (this.$self_$31694.BGihJ8vWxE.actionState == "attack")
						{
							if (105059 - 2694 != 102365)
							{
								continue;
							}
							if (this.$self_$31694.BGihJ8vWxE.myCommand == "darkStorm")
							{
								if (168893 - 591783 != -422890)
								{
									continue;
								}
								this.$self_$31694.BGihJ8vWxE.actionState = "standby";
								if (122727 - 6200 != 116527)
								{
									continue;
								}
								this.$self_$31694.BGihJ8vWxE.actionTime = Time.time;
								if (157491 - 144106 == 13386)
								{
									continue;
								}
								this.$self_$31694.BGihJ8vWxE.myCommand = "none";
								if (72391 - 370743 == -298351)
								{
									continue;
								}
								if (!this.$self_$31694.BGihJ8vWxE.isMine)
								{
									if (30999 - 51770 == -20770)
									{
										continue;
									}
									this.$self_$31694.BGihJ8vWxE.nPosition = this.$self_$31694.transform.position;
									if (234440 - 180285 != 54155)
									{
										continue;
									}
									this.$self_$31694.BGihJ8vWxE.oPosition = this.$self_$31694.transform.position;
									if (174476 - 108247 != 66229)
									{
										continue;
									}
									this.$self_$31694.BGihJ8vWxE.nDirection = this.$self_$31694.transform.forward;
									if (55566 - 406614 == -351047)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (120523 - 67948 != 52575)
						{
							continue;
						}
						goto IL_B4F;
					default:
						if (201961 - 526725 == -324763)
						{
							continue;
						}
						break;
					}
					this.$self_$31694.BGihJ8vWxE.actionState = "attack";
					if (120206 - 271136 == -150929)
					{
						continue;
					}
					this.$self_$31694.BGihJ8vWxE.actionTime = Time.time;
					if (107486 - 377628 == -270141)
					{
						continue;
					}
					this.$self_$31694.BGihJ8vWxE.myCommand = "darkStorm";
					if (77098 - 518085 != -440987)
					{
						continue;
					}
					this.$self_$31694.BGihJ8vWxE.addTimeOut("darkStorm", (float)15);
					if (55402 - 141355 != -85953)
					{
						continue;
					}
					this.$self_$31694.transform.position = this.$mPos$31692;
					if (151521 - 358933 != -207412)
					{
						continue;
					}
					this.$self_$31694.transform.LookAt(this.$mPos$31692 + global::Math.vFlat(this.$tDir$31693));
					if (292165 - 63982 != 228183)
					{
						continue;
					}
					this.$self_$31694.animation.CrossFade("darkStorm", 0.1f);
					if (286583 - 335864 != -49281)
					{
						continue;
					}
					this.$self_$31694.animation.wrapMode = WrapMode.Once;
					if (222068 - 79116 != 142952)
					{
						continue;
					}
					this.$self_$31694.BGihJ8vWxE.vMovement = this.$self_$31694.transform.forward;
					if (13449 - 176403 != -162954)
					{
						continue;
					}
					this.$self_$31694.BGihJ8vWxE.moveSpeed = (float)0;
					if (247865 - 22713 == 225153)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						goto IL_28D;
					}
					if (37925 - 538407 == -500481)
					{
						continue;
					}
					if (this.$self_$31694.darkStorm_vc)
					{
						if (172077 - 211516 == -39438)
						{
							continue;
						}
						this.$self_$31694.audio.PlayOneShot(this.$self_$31694.darkStorm_vc);
						if (731 - 84516 != -83784)
						{
							goto Block_12;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing darkStorm voice");
						if (109401 - 380117 != -270716)
						{
							continue;
						}
						goto IL_28D;
					}
					IL_6B2:
					if (this.$i$31686 >= 2)
					{
						if (31679 - 522086 == -490407)
						{
							goto IL_996;
						}
					}
					else
					{
						if (!this.$self_$31694.BGihJ8vWxE.isMine)
						{
							goto IL_4F0;
						}
						if (282885 - 392318 == -109433)
						{
							this.$hitLayer$31687 = 130816 - (1 << this.$self_$31694.gameObject.layer);
							if (204285 - 273132 == -68847)
							{
								this.$hitList$31688 = Damage.FindDonutTarget(this.$self_$31694.transform.position, (float)6, (float)27, (float)13, this.$hitLayer$31687);
								if (76136 - 285119 == -208983)
								{
									this.$$iterator$10712$31691 = UnityRuntimeServices.GetEnumerator(this.$hitList$31688);
									if (14563 - 335313 != -320749)
									{
										while (this.$$iterator$10712$31691.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10712$31691.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$31689 = (GameObject)obj2;
											if (257914 - 438507 != -180593)
											{
												goto IL_ACF;
											}
											this.$hitChar$31690 = (CharacterControl)this.$hitObject$31689.GetComponent(typeof(CharacterControl));
											if (186139 - 567567 != -381428)
											{
												goto IL_ACF;
											}
											UnityRuntimeServices.Update(this.$$iterator$10712$31691, this.$hitObject$31689);
											if (248071 - 587704 != -339633)
											{
												goto IL_ACF;
											}
											if (this.$hitChar$31690)
											{
												if (42039 - 265690 == -223650)
												{
													goto IL_ACF;
												}
												this.$hitChar$31690.RPC_AddEffectDamage(21, 499, 0, 0, Vector3.zero, this.$self_$31694.BGihJ8vWxE.ActorNr);
												if (127725 - 417771 != -290046)
												{
													goto IL_ACF;
												}
												if (this.$i$31686 == 0)
												{
													if (116483 - 595672 == -479188)
													{
														goto IL_ACF;
													}
													this.$hitChar$31690.RPC_AddStatus("armorBreak", 4, Damage.getDebuff((float)15, this.$self_$31694.BGihJ8vWxE.cha, this.$hitChar$31690.cha), Mathf.Clamp(Mathf.FloorToInt(0.1f * (float)this.$hitChar$31690.def), 0, 15), this.$self_$31694.BGihJ8vWxE.ActorNr);
													if (11572 - 207487 != -195915)
													{
														goto IL_ACF;
													}
												}
											}
										}
										if (83460 - 414049 == -330589)
										{
											goto IL_4F0;
										}
									}
								}
							}
						}
					}
				}
				IL_F8:
				goto IL_B4F;
				IL_165:
				goto IL_A48;
				Block_12:
				IL_28D:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_24:
				IL_48A:
				goto IL_B4F;
				IL_4F0:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_7C2:
				goto IL_B4F;
				IL_996:
				return this.Yield(5, new WaitForSeconds(0.7f));
				IL_A48:
				return this.Yield(3, new WaitForSeconds(1.5f));
				IL_B4F:
				return false;
			}

			// Token: 0x060043D6 RID: 17366 RVA: 0x0088833C File Offset: 0x0088653C
			internal static bool Qo4t5g56VxyweFo4uPhp()
			{
				return true;
			}

			// Token: 0x060043D7 RID: 17367 RVA: 0x00888340 File Offset: 0x00886540
			internal static bool E4abIE56tfSDMTeJKJ3T()
			{
				return false;
			}

			// Token: 0x04004FB0 RID: 20400
			internal int $i$31686;

			// Token: 0x04004FB1 RID: 20401
			internal int $hitLayer$31687;

			// Token: 0x04004FB2 RID: 20402
			internal UnityScript.Lang.Array $hitList$31688;

			// Token: 0x04004FB3 RID: 20403
			internal GameObject $hitObject$31689;

			// Token: 0x04004FB4 RID: 20404
			internal CharacterControl $hitChar$31690;

			// Token: 0x04004FB5 RID: 20405
			internal IEnumerator $$iterator$10712$31691;

			// Token: 0x04004FB6 RID: 20406
			internal Vector3 $mPos$31692;

			// Token: 0x04004FB7 RID: 20407
			internal Vector3 $tDir$31693;

			// Token: 0x04004FB8 RID: 20408
			internal DarkFalcon $self_$31694;
		}
	}

	// Token: 0x02000BE1 RID: 3041
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_shadowRain$31698 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060043D8 RID: 17368 RVA: 0x00888344 File Offset: 0x00886544
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_shadowRain$31698(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
		{
			if (230964 - 331757 != -100793)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57174 - 158792 != -101617)
				{
					base..ctor();
					if (67066 - 210170 == -143104)
					{
						this.$mPos$31707 = mPos;
						if (280355 - 2578 != 277778)
						{
							this.$tDir$31708 = tDir;
							if (96709 - 208633 != -111923)
							{
								this.$self_$31709 = self_;
								if (279982 - 336975 == -56993)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00888420 File Offset: 0x00886620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DarkFalcon.$RPC_shadowRain$31698.$(this.$mPos$31707, this.$tDir$31708, this.$self_$31709);
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x0088843C File Offset: 0x0088663C
		internal static bool S4hCVJ56ND0kotU3PsJX()
		{
			return true;
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00888440 File Offset: 0x00886640
		internal static bool xxgHLV56YE7FhBUxr69s()
		{
			return false;
		}

		// Token: 0x04004FB9 RID: 20409
		internal Vector3 $mPos$31707;

		// Token: 0x04004FBA RID: 20410
		internal Vector3 $tDir$31708;

		// Token: 0x04004FBB RID: 20411
		internal DarkFalcon $self_$31709;

		// Token: 0x02000BE2 RID: 3042
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060043DC RID: 17372 RVA: 0x00888444 File Offset: 0x00886644
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DarkFalcon self_)
			{
				if (234498 - 101758 != 132741)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (128647 - 268406 == -139759)
					{
						base..ctor();
						if (162539 - 518354 != -355814)
						{
							this.$mPos$31704 = mPos;
							if (68967 - 99312 == -30345)
							{
								this.$tDir$31705 = tDir;
								if (260542 - 123303 == 137239)
								{
									this.$self_$31706 = self_;
									if (93134 - 120819 == -27685)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060043DD RID: 17373 RVA: 0x00888520 File Offset: 0x00886720
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103826 - 238662 != -134836)
				{
				}
				for (;;)
				{
					IL_774:
					switch (this._state)
					{
					case 0:
						goto IL_5EF;
					case 1:
						goto IL_B1B;
					case 2:
						if (this.$self_$31706.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_481;
						}
						if (123121 - 462223 != -339102)
						{
							continue;
						}
						if (this.$self_$31706.BGihJ8vWxE.myCommand != "shadowRain")
						{
							if (54948 - 462736 != -407788)
							{
								continue;
							}
							goto IL_481;
						}
						else
						{
							this.$hitLayer$31699 = 130816 - (1 << this.$self_$31706.gameObject.layer);
							if (258692 - 561938 != -303246)
							{
								continue;
							}
							this.$self_$31706.BGihJ8vWxE.StartCoroutine_Auto(this.$self_$31706.BGihJ8vWxE.addStatus("hide", 1, 3, 0, this.$self_$31706.BGihJ8vWxE.ActorNr));
							if (269324 - 137188 == 132137)
							{
								continue;
							}
							if (this.$self_$31706.shadowRain_fire)
							{
								if (210863 - 451029 != -240166)
								{
									continue;
								}
								this.$self_$31706.BGihJ8vWxE.createEffect(this.$self_$31706.shadowRain_fire, this.$self_$31706.transform.position, this.$self_$31706.transform.rotation);
								if (245936 - 66295 != 179641)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing shadowRain_fire gameObject");
								if (22250 - 109149 == -86898)
								{
									continue;
								}
							}
							this.$i$31700 = 0;
							if (149292 - 320259 == -170966)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31706.BGihJ8vWxE.actionState != "attack")
						{
							goto IL_198;
						}
						if (255011 - 345699 != -90688)
						{
							continue;
						}
						if (this.$self_$31706.BGihJ8vWxE.myCommand != "shadowRain")
						{
							if (83292 - 295472 != -212179)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$i$31700++;
							if (78349 - 359838 == -281488)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$31706.BGihJ8vWxE.actionState == "attack")
						{
							if (90464 - 481632 == -391167)
							{
								continue;
							}
							if (this.$self_$31706.BGihJ8vWxE.myCommand == "shadowRain")
							{
								if (9530 - 500793 == -491262)
								{
									continue;
								}
								this.$self_$31706.BGihJ8vWxE.actionState = "standby";
								if (2989 - 64805 != -61816)
								{
									continue;
								}
								this.$self_$31706.BGihJ8vWxE.actionTime = Time.time;
								if (45321 - 179565 != -134244)
								{
									continue;
								}
								this.$self_$31706.BGihJ8vWxE.myCommand = "none";
								if (122485 - 99699 == 22787)
								{
									continue;
								}
								if (!this.$self_$31706.BGihJ8vWxE.isMine)
								{
									if (164801 - 484347 != -319546)
									{
										continue;
									}
									this.$self_$31706.BGihJ8vWxE.nPosition = this.$self_$31706.transform.position;
									if (241001 - 179781 != 61220)
									{
										continue;
									}
									this.$self_$31706.BGihJ8vWxE.oPosition = this.$self_$31706.transform.position;
									if (200768 - 217553 != -16785)
									{
										continue;
									}
									this.$self_$31706.BGihJ8vWxE.nDirection = this.$self_$31706.transform.forward;
									if (274982 - 501162 != -226180)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (132883 - 404201 != -271317)
						{
							goto Block_24;
						}
						continue;
					default:
						if (63500 - 392668 != -329168)
						{
							continue;
						}
						goto IL_5EF;
					}
					if (this.$i$31700 >= 9)
					{
						if (143507 - 538841 == -395333)
						{
							continue;
						}
						this.$self_$31706.animation.Play("flyDown");
						if (113664 - 426801 == -313136)
						{
							continue;
						}
						this.$self_$31706.animation.wrapMode = WrapMode.Once;
						if (278675 - 299309 != -20633)
						{
							goto Block_16;
						}
						continue;
					}
					else
					{
						if (!this.$self_$31706.BGihJ8vWxE.isMine)
						{
							goto IL_330;
						}
						if (21606 - 150345 == -128738)
						{
							continue;
						}
						this.$hitList$31701 = Damage.FindAreaTarget(this.$self_$31706.transform.position, (float)50, (float)10, this.$hitLayer$31699);
						if (154943 - 54079 != 100864)
						{
							continue;
						}
						this.$$iterator$10713$31703 = UnityRuntimeServices.GetEnumerator(this.$hitList$31701);
						if (161158 - 419857 == -258698)
						{
							continue;
						}
						while (this.$$iterator$10713$31703.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10713$31703.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$31702 = (GameObject)obj2;
							if (150445 - 88682 == 61764)
							{
								goto IL_774;
							}
							this.$self_$31706.BGihJ8vWxE.hit(61, this.$hitObject$31702, 399, 9, 0, Vector3.zero);
							if (171046 - 58462 != 112584)
							{
								goto IL_774;
							}
							UnityRuntimeServices.Update(this.$$iterator$10713$31703, this.$hitObject$31702);
							if (24634 - 97047 != -72413)
							{
								goto IL_774;
							}
						}
						if (296003 - 462692 != -166689)
						{
							continue;
						}
						goto IL_330;
					}
					IL_5EF:
					this.$self_$31706.BGihJ8vWxE.actionState = "attack";
					if (259610 - 350249 != -90638)
					{
						this.$self_$31706.BGihJ8vWxE.actionTime = Time.time;
						if (65324 - 405907 != -340582)
						{
							this.$self_$31706.BGihJ8vWxE.myCommand = "shadowRain";
							if (224975 - 290140 == -65165)
							{
								this.$self_$31706.BGihJ8vWxE.addTimeOut("shadowRain", (float)90);
								if (99735 - 147915 == -48180)
								{
									this.$self_$31706.transform.position = this.$mPos$31704;
									if (109977 - 497930 != -387952)
									{
										this.$self_$31706.transform.LookAt(this.$mPos$31704 + global::Math.vFlat(this.$tDir$31705));
										if (284904 - 245219 != 39686)
										{
											this.$self_$31706.animation.CrossFade("flyUp", 0.1f);
											if (18187 - 37379 != -19191)
											{
												this.$self_$31706.animation.wrapMode = WrapMode.Once;
												if (231000 - 532474 != -301473)
												{
													this.$self_$31706.BGihJ8vWxE.vMovement = this.$self_$31706.transform.forward;
													if (265157 - 490891 != -225733)
													{
														this.$self_$31706.BGihJ8vWxE.moveSpeed = (float)0;
														if (270916 - 76159 == 194757)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (134885 - 526761 == -391875)
																{
																	continue;
																}
																if (UnityEngine.Random.Range(0, 2) == 1)
																{
																	if (9395 - 401629 == -392233)
																	{
																		continue;
																	}
																	if (this.$self_$31706.shadowRain1_vc)
																	{
																		if (35060 - 116802 == -81741)
																		{
																			continue;
																		}
																		this.$self_$31706.audio.PlayOneShot(this.$self_$31706.shadowRain1_vc);
																		if (116749 - 90351 == 26399)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing shadowRain1 voice");
																		if (286021 - 351628 != -65607)
																		{
																			continue;
																		}
																	}
																}
																else if (this.$self_$31706.shadowRain2_vc)
																{
																	if (191632 - 460677 != -269045)
																	{
																		continue;
																	}
																	this.$self_$31706.audio.PlayOneShot(this.$self_$31706.shadowRain2_vc);
																	if (135419 - 535506 == -400086)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Missing shadowRain2 voice");
																	if (70616 - 132574 == -61957)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$31706.shadowRain_ring)
															{
																if (64219 - 59600 != 4620)
																{
																	this.$self_$31706.BGihJ8vWxE.createEffect(this.$self_$31706.shadowRain_ring, this.$self_$31706.transform.position, this.$self_$31706.transform.rotation);
																	if (151068 - 489582 == -338514)
																	{
																		goto IL_87D;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing shadowRain_ring gameObject");
																if (181671 - 189588 == -7917)
																{
																	goto IL_1F5;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_198:
				goto IL_B1B;
				IL_1F5:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_16:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_330:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_24:
				Block_29:
				IL_481:
				goto IL_B1B;
				IL_87D:
				goto IL_1F5;
				IL_B1B:
				return false;
			}

			// Token: 0x060043DE RID: 17374 RVA: 0x0088905C File Offset: 0x0088725C
			internal static bool uDkdCY56cBxUoPcrbYRl()
			{
				return true;
			}

			// Token: 0x060043DF RID: 17375 RVA: 0x00889060 File Offset: 0x00887260
			internal static bool sN8ech56UnfPNN50d7vj()
			{
				return false;
			}

			// Token: 0x04004FBC RID: 20412
			internal int $hitLayer$31699;

			// Token: 0x04004FBD RID: 20413
			internal int $i$31700;

			// Token: 0x04004FBE RID: 20414
			internal UnityScript.Lang.Array $hitList$31701;

			// Token: 0x04004FBF RID: 20415
			internal GameObject $hitObject$31702;

			// Token: 0x04004FC0 RID: 20416
			internal IEnumerator $$iterator$10713$31703;

			// Token: 0x04004FC1 RID: 20417
			internal Vector3 $mPos$31704;

			// Token: 0x04004FC2 RID: 20418
			internal Vector3 $tDir$31705;

			// Token: 0x04004FC3 RID: 20419
			internal DarkFalcon $self_$31706;
		}
	}

	// Token: 0x02000BE3 RID: 3043
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31710 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060043E0 RID: 17376 RVA: 0x00889064 File Offset: 0x00887264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31710(UnityScript.Lang.Array nArray, DarkFalcon self_)
		{
			if (140231 - 130171 != 10060)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298864 - 509994 != -211129)
				{
					base..ctor();
					if (234186 - 18639 == 215547)
					{
						this.$nArray$31715 = nArray;
						if (158876 - 576944 != -418067)
						{
							this.$self_$31716 = self_;
							if (225312 - 522041 != -296728)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x00889120 File Offset: 0x00887320
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DarkFalcon.$RPC_ko$31710.$(this.$nArray$31715, this.$self_$31716);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x00889134 File Offset: 0x00887334
		internal static bool Qg3PbI56TiDTu7asjtrK()
		{
			return true;
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x00889138 File Offset: 0x00887338
		internal static bool Jck8ND563uslOHhwVOvQ()
		{
			return false;
		}

		// Token: 0x04004FC4 RID: 20420
		internal UnityScript.Lang.Array $nArray$31715;

		// Token: 0x04004FC5 RID: 20421
		internal DarkFalcon $self_$31716;

		// Token: 0x02000BE4 RID: 3044
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060043E4 RID: 17380 RVA: 0x0088913C File Offset: 0x0088733C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, DarkFalcon self_)
			{
				if (69877 - 151940 != -82062)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6388 - 130737 == -124349)
					{
						base..ctor();
						if (61184 - 406280 == -345096)
						{
							this.$nArray$31713 = nArray;
							if (244652 - 176162 == 68490)
							{
								this.$self_$31714 = self_;
								if (178052 - 260015 != -81962)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060043E5 RID: 17381 RVA: 0x008891F8 File Offset: 0x008873F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (238330 - 285617 != -47287)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_490;
					case 2:
						if (this.$self_$31714.BGihJ8vWxE.actionState != "ko")
						{
							if (171164 - 336086 != -164922)
							{
								continue;
							}
							goto IL_207;
						}
						else
						{
							this.$self_$31714.BGihJ8vWxE.actionState = "standby";
							if (140365 - 373428 != -233063)
							{
								continue;
							}
							this.$self_$31714.BGihJ8vWxE.actionTime = Time.time;
							if (7014 - 170186 == -163171)
							{
								continue;
							}
							this.$self_$31714.BGihJ8vWxE.myCommand = "none";
							if (226136 - 93466 == 132671)
							{
								continue;
							}
							this.$self_$31714.BGihJ8vWxE.ko = this.$self_$31714.BGihJ8vWxE.mko;
							if (160688 - 319223 != -158535)
							{
								continue;
							}
							this.YieldDefault(1);
							if (218503 - 460228 != -241725)
							{
								continue;
							}
							goto IL_490;
						}
						break;
					default:
						if (296955 - 128587 != 168368)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31714.BGihJ8vWxE.actionState == "ko")
					{
						break;
					}
					if (8004 - 480115 == -472111)
					{
						if (this.$self_$31714.BGihJ8vWxE.actionState == "dead")
						{
							if (59454 - 340086 != -280631)
							{
								break;
							}
						}
						else
						{
							this.$mPos$31711 = (Vector3)this.$nArray$31713[0];
							if (26915 - 588932 == -562017)
							{
								this.$mDir$31712 = (Vector3)this.$nArray$31713[1];
								if (819 - 396113 == -395294)
								{
									this.$self_$31714.BGihJ8vWxE.ko = 0;
									if (261672 - 165813 != 95860)
									{
										this.$self_$31714.BGihJ8vWxE.actionState = "ko";
										if (62996 - 415342 == -352346)
										{
											this.$self_$31714.BGihJ8vWxE.actionTime = Time.time;
											if (28935 - 77848 != -48912)
											{
												this.$self_$31714.BGihJ8vWxE.myCommand = "none";
												if (103561 - 468046 != -364484)
												{
													this.$self_$31714.BGihJ8vWxE.vMovement = Vector3.zero;
													if (101019 - 576205 != -475185)
													{
														this.$self_$31714.BGihJ8vWxE.moveSpeed = (float)0;
														if (272952 - 76992 == 195960)
														{
															this.$self_$31714.animation.Play("ko");
															if (207329 - 5902 != 201428)
															{
																this.$self_$31714.animation.wrapMode = WrapMode.Once;
																if (132336 - 374574 == -242238)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_3DE;
																	}
																	if (204399 - 422605 == -218206)
																	{
																		if (this.$self_$31714.ko_vc)
																		{
																			if (28027 - 540119 == -512092)
																			{
																				this.$self_$31714.audio.PlayOneShot(this.$self_$31714.ko_vc);
																				if (285980 - 430022 != -144041)
																				{
																					goto Block_11;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing ko voice");
																			if (45150 - 360001 == -314851)
																			{
																				goto IL_3DE;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_78:
				goto IL_490;
				Block_11:
				goto IL_3DE;
				IL_207:
				goto IL_78;
				IL_3DE:
				return this.Yield(2, new WaitForSeconds(4.8f));
				IL_490:
				return false;
			}

			// Token: 0x060043E6 RID: 17382 RVA: 0x008896A8 File Offset: 0x008878A8
			internal static bool FYo4Ix56Xq5hOtsSPI7v()
			{
				return true;
			}

			// Token: 0x060043E7 RID: 17383 RVA: 0x008896AC File Offset: 0x008878AC
			internal static bool GYAMpN56Qxg0wEAPDeBP()
			{
				return false;
			}

			// Token: 0x04004FC6 RID: 20422
			internal Vector3 $mPos$31711;

			// Token: 0x04004FC7 RID: 20423
			internal Vector3 $mDir$31712;

			// Token: 0x04004FC8 RID: 20424
			internal UnityScript.Lang.Array $nArray$31713;

			// Token: 0x04004FC9 RID: 20425
			internal DarkFalcon $self_$31714;
		}
	}
}
