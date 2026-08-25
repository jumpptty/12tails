using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200107E RID: 4222
[Serializable]
public class MallGui : MonoBehaviour
{
	// Token: 0x060061EE RID: 25070 RVA: 0x00D74E54 File Offset: 0x00D73054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MallGui()
	{
		if (232283 - 172995 != 59288)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (177196 - 546310 == -369114)
			{
				base..ctor();
				if (75318 - 299112 == -223794)
				{
					this.mState = eMallState.init;
					if (245632 - 439187 != -193554)
					{
						this.mType = eMallType.setup;
						if (192397 - 408223 != -215825)
						{
							this.mLv = 1;
							if (209427 - 284791 != -75363)
							{
								this.mMallName = "none";
								if (175000 - 353200 == -178200)
								{
									this.fSbcZjNXHGo = 1;
									if (231018 - 593958 == -362940)
									{
										this.QVHcCirB1jL = string.Empty;
										if (205677 - 292562 == -86885)
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

	// Token: 0x060061EF RID: 25071 RVA: 0x00D74F9C File Offset: 0x00D7319C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (88968 - 8084 != 80884)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (247979 - 457137 == -209158)
			{
				if (this.mState == eMallState.init)
				{
					if (6221 - 21228 == -15006)
					{
						continue;
					}
					this.InitMallGui();
					if (49104 - 199097 != -149993)
					{
						continue;
					}
					this.InitMallMenu();
					if (52788 - 118188 == -65399)
					{
						continue;
					}
					this.InitNPC();
					if (77703 - 115818 != -38115)
					{
						continue;
					}
					this.InitMallInventory();
					if (197751 - 373856 == -176104)
					{
						continue;
					}
					this.InitChatBar();
					if (47572 - 287250 != -239678)
					{
						continue;
					}
					this.InitNoticeBar();
					if (126462 - 304485 != -178023)
					{
						continue;
					}
					this.InitMallNotice();
					if (11328 - 119013 != -107685)
					{
						continue;
					}
				}
				this.h0ZcZDRCCPd = 0;
				if (899 - 216891 == -215992)
				{
					this.NDCcZmOi0i1 = new ItemClass();
					if (250949 - 573155 != -322205)
					{
						this.fSbcZjNXHGo = 1;
						if (90653 - 445744 == -355091)
						{
							this.y9qcZojuw6S = 1f;
							if (177700 - 15038 != 162663)
							{
								this.ResetMallMenu();
								if (149477 - 571168 == -421691)
								{
									this.ResetMallInventory();
									if (244508 - 451505 == -206997)
									{
										this.mState = eMallState.open;
										if (109174 - 378354 == -269180)
										{
											this.aKxcZ0Pwmdb = Time.time;
											if (82846 - 204692 != -121845)
											{
												ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
												if (49562 - 594901 == -545339)
												{
													if (!changeGui)
													{
														break;
													}
													if (223784 - 478466 != -254681)
													{
														changeGui.disable();
														if (283943 - 582761 == -298818)
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

	// Token: 0x060061F0 RID: 25072 RVA: 0x00D75284 File Offset: 0x00D73484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (170099 - 72087 != 98012)
		{
		}
		for (;;)
		{
			if (this.mState <= eMallState.init)
			{
				if (240393 - 252143 == -11750)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (130912 - 428251 != -297338)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (126108 - 431086 != -304977)
					{
						this.OLjcZ8XfItD = (float)(1024 * Screen.width / Screen.height);
						if (184719 - 37595 == 147124)
						{
							this.AkDcZimBAdJ = (float)Screen.height / 1024f;
							if (192849 - 145304 == 47545)
							{
								this.RenderMallGui();
								if (42457 - 9773 != 32685)
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

	// Token: 0x060061F1 RID: 25073 RVA: 0x00D753D4 File Offset: 0x00D735D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (145027 - 481939 != -336912)
		{
		}
		while (this.mState == eMallState.mall)
		{
			if (24207 - 229336 != -205128)
			{
				if (this.mSeller)
				{
					if (100611 - 4645 != 95966)
					{
						continue;
					}
					if (this.mSellerChar)
					{
						if (78448 - 452832 != -374384)
						{
							continue;
						}
						if (!(this.mSellerChar.myCommand == "mallSetup"))
						{
							if (151804 - 172767 == -20962)
							{
								continue;
							}
							if (!(this.mSellerChar.myCommand == "mallOpen"))
							{
								goto IL_14E;
							}
							if (84808 - 358317 == -273508)
							{
								continue;
							}
						}
						this.captureInput();
						if (77654 - 596972 != -519317)
						{
							break;
						}
						continue;
					}
				}
				IL_14E:
				this.mState = eMallState.close;
				if (88350 - 55675 != 32676)
				{
					this.aKxcZ0Pwmdb = Time.time;
					if (142287 - 51689 != 90599)
					{
						this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
						if (251431 - 577989 != -326557)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060061F2 RID: 25074 RVA: 0x00D7558C File Offset: 0x00D7378C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMallGui()
	{
		if (243543 - 96306 != 147238)
		{
		}
		for (;;)
		{
			this.AjmcZu5L8Co = (Texture)Resources.Load("GameGui/Mall/mallWindow", typeof(Texture));
			if (27878 - 185600 == -157722)
			{
				this.CZ6cZyeVArp = (Texture)Resources.Load("GameGui/Mall/sellBar", typeof(Texture));
				if (37539 - 241226 == -203687)
				{
					this.pCBcZVPuPcD = (Texture)Resources.Load("GameGui/Mall/buyBar", typeof(Texture));
					if (46522 - 155937 == -109415)
					{
						this.Lg7cZh0meg6 = (Texture)Resources.Load("GameGui/Mall/priceBar", typeof(Texture));
						if (203352 - 70264 != 133089)
						{
							this.xincZKvaobg = new GUIStyle();
							if (67342 - 404518 != -337175)
							{
								this.xincZKvaobg.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Mall/button_shop_h", typeof(Texture)));
								if (50660 - 401974 != -351313)
								{
									this.W61cZz1y52v = new GUIStyle();
									if (246194 - 108269 == 137925)
									{
										this.W61cZz1y52v.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Mall/button_mall_h", typeof(Texture)));
										if (46772 - 212738 == -165966)
										{
											this.zuxcCnAhn5Y = new GUIStyle();
											if (47641 - 158997 == -111356)
											{
												this.zuxcCnAhn5Y.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Mall/button_buy_h", typeof(Texture)));
												if (210004 - 379371 != -169366)
												{
													this.ljjcC5Ayq5Y = new GUIStyle();
													if (185895 - 328246 != -142350)
													{
														this.ljjcC5Ayq5Y.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Mall/button_open_h", typeof(Texture)));
														if (293309 - 259655 == 33654)
														{
															this.cALcCcfJN3C = new GUIStyle();
															if (32187 - 417906 == -385719)
															{
																this.cALcCcfJN3C.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Mall/button_hold", typeof(Texture)));
																if (209909 - 42654 == 167255)
																{
																	this.cALcCcfJN3C.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Mall/button_hold_h", typeof(Texture)));
																	if (121215 - 112034 == 9181)
																	{
																		this.TN0cCILf5Ed = new GUIStyle();
																		if (41764 - 140452 == -98688)
																		{
																			this.TN0cCILf5Ed.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
																			if (280821 - 487524 != -206702)
																			{
																				this.VnAcCQn9yfY = new GUIStyle();
																				if (104593 - 387741 == -283148)
																				{
																					this.VnAcCQn9yfY.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numUp_h", typeof(Texture)));
																					if (167312 - 489169 != -321856)
																					{
																						this.TuocCefkvk6 = new GUIStyle();
																						if (280349 - 186061 != 94289)
																						{
																							this.TuocCefkvk6.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numDown_h", typeof(Texture)));
																							if (191735 - 347549 != -155813)
																							{
																								this.QD7cZFWyp6g = new GUIStyle();
																								if (156650 - 484509 == -327859)
																								{
																									this.QD7cZFWyp6g.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																									if (19402 - 568479 != -549076)
																									{
																										this.QD7cZFWyp6g.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																										if (299122 - 366502 == -67380)
																										{
																											this.QD7cZFWyp6g.alignment = TextAnchor.MiddleLeft;
																											if (261582 - 78105 != 183478)
																											{
																												this.CHhcZAWl1yo = new GUIStyle();
																												if (95591 - 119159 != -23567)
																												{
																													this.CHhcZAWl1yo.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																													if (46522 - 536205 == -489683)
																													{
																														this.CHhcZAWl1yo.normal.textColor = new Color(0.16f, 0.42f, 0.31f, (float)1);
																														if (50276 - 363221 != -312944)
																														{
																															this.CHhcZAWl1yo.alignment = TextAnchor.MiddleRight;
																															if (12336 - 57211 != -44874)
																															{
																																this.lCccZ9l0G5I = new GUIStyle();
																																if (146410 - 150684 != -4273)
																																{
																																	this.lCccZ9l0G5I.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																	if (166570 - 329786 != -163215)
																																	{
																																		this.lCccZ9l0G5I.normal.textColor = new Color(0.16f, 0.27f, 0.42f, (float)1);
																																		if (126423 - 589976 == -463553)
																																		{
																																			this.lCccZ9l0G5I.alignment = TextAnchor.MiddleRight;
																																			if (269907 - 302359 == -32452)
																																			{
																																				this.gdncZWriKG1 = new GUIStyle();
																																				if (165195 - 589849 == -424654)
																																				{
																																					this.gdncZWriKG1.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																					if (46906 - 60026 != -13119)
																																					{
																																						this.gdncZWriKG1.normal.textColor = new Color(0.5f, 0.21f, 0.16f, (float)1);
																																						if (157039 - 358515 == -201476)
																																						{
																																							this.gdncZWriKG1.alignment = TextAnchor.MiddleRight;
																																							if (248252 - 208110 != 40143)
																																							{
																																								this.anfcCJEiXwH = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																																								if (239211 - 383357 != -144145)
																																								{
																																									this.kA4cC6ENGop = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																																									if (258564 - 49727 == 208837)
																																									{
																																										this.yhvcCtdZNv7 = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																																										if (266392 - 67277 != 199116)
																																										{
																																											this.zUxcCXPUfVC = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																																											if (160080 - 583347 == -423267)
																																											{
																																												this.j6IcCONNKw1 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																																												if (186329 - 468112 != -281782)
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
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060061F3 RID: 25075 RVA: 0x00D75E8C File Offset: 0x00D7408C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMallGui()
	{
		if (1031 - 349752 != -348721)
		{
		}
		for (;;)
		{
			float num = Time.time - this.aKxcZ0Pwmdb;
			if (178865 - 345117 != -166251)
			{
				eMallState eMallState = this.mState;
				if (45223 - 417170 == -371947)
				{
					if (eMallState == eMallState.open)
					{
						if (162230 - 52530 != 109701)
						{
							if (this.mType == eMallType.buying)
							{
								if (213898 - 151408 != 62491)
								{
									if (num < 0.5f)
									{
										if (217924 - 135038 != 82887)
										{
											GUI.DrawTexture(new Rect(this.OLjcZ8XfItD - Mathf.SmoothStep((float)0, (float)550, (float)2 * num), (float)0, (float)550, (float)1024), this.AjmcZu5L8Co);
											if (100085 - 224526 == -124441)
											{
												break;
											}
										}
									}
									else
									{
										this.y9qcZojuw6S = (float)0;
										if (220388 - 395008 == -174620)
										{
											this.h0ZcZDRCCPd = 0;
											if (262435 - 543436 == -281001)
											{
												this.fSbcZjNXHGo = 1;
												if (193167 - 573212 != -380044)
												{
													this.NDCcZmOi0i1 = new ItemClass();
													if (216087 - 404744 == -188657)
													{
														this.mState = eMallState.mall;
														if (287505 - 238828 == 48677)
														{
															this.aKxcZ0Pwmdb = Time.time;
															if (5850 - 155691 != -149840)
															{
																this.MallBuyOperation(0, 0, 0, 0);
																if (195604 - 195204 != 401)
																{
																	this.qWxcCrOFW5q = null;
																	if (20352 - 535811 != -515458)
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
							else if (num <= 0.5f)
							{
								if (288703 - 53489 == 235214)
								{
									this.y9qcZojuw6S = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (242027 - 510037 != -268009)
									{
										this.RenderNPC();
										if (59808 - 451830 != -392021)
										{
											GUI.DrawTexture(new Rect(0.5f * this.OLjcZ8XfItD - (float)336, (float)724 + this.y9qcZojuw6S * (float)300, (float)836, (float)196), this.C59cCl22qrn);
											if (156320 - 591815 == -435495)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (278302 - 180661 != 97642)
								{
									this.y9qcZojuw6S = (float)0;
									if (266413 - 558784 == -292371)
									{
										this.RenderNPC();
										if (12024 - 224202 != -212177)
										{
											GUI.BeginGroup(new Rect(0.5f * this.OLjcZ8XfItD - (float)350, (float)724, (float)850, (float)200));
											if (50940 - 129052 == -78112)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.C59cCl22qrn);
												if (123942 - 306848 != -182905)
												{
													GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), CharacterData.current.Name, this.GBRcCGAxx9B);
													if (192440 - 490751 == -298311)
													{
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.a6mcCq5wsxr, num - 0.5f), this.xgvcC132G2R);
														if (284971 - 558534 != -273562)
														{
															GUI.EndGroup();
															if (262355 - 177112 != 85244)
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
								this.y9qcZojuw6S = (float)0;
								if (187917 - 292621 == -104704)
								{
									this.RenderNPC();
									if (34101 - 239436 == -205335)
									{
										this.h0ZcZDRCCPd = 0;
										if (7935 - 502266 == -494331)
										{
											this.fSbcZjNXHGo = 1;
											if (276644 - 453442 == -176798)
											{
												this.NDCcZmOi0i1 = new ItemClass();
												if (7047 - 237005 != -229957)
												{
													this.mState = eMallState.mall;
													if (131367 - 251580 != -120212)
													{
														this.aKxcZ0Pwmdb = Time.time;
														if (178421 - 85235 == 93186)
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
					else if (eMallState == eMallState.mall)
					{
						if (279860 - 262948 == 16912)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.OLjcZ8XfItD - (float)400) / this.OLjcZ8XfItD, (float)1);
							if (108163 - 114930 == -6767)
							{
								GUI.BeginGroup(new Rect(this.OLjcZ8XfItD - (float)850, (float)0, (float)850, (float)1024));
								if (151784 - 433850 == -282066)
								{
									GUI.DrawTexture(new Rect((float)300, (float)0, (float)550, (float)1024), this.AjmcZu5L8Co);
									if (165668 - 82836 == 82832)
									{
										Guix.renderSmallNumber(532, 64, PlayerData.Gil, false, (float)1);
										if (285420 - 320583 != -35162)
										{
											Guix.renderSmallNumber(730, 64, PlayerData.Jil, false, (float)1);
											if (259266 - 210158 != 49109)
											{
												eMallType eMallType = this.mType;
												if (33475 - 106089 == -72614)
												{
													if (eMallType == eMallType.setup)
													{
														if (297106 - 243648 == 53459)
														{
															continue;
														}
														this.RenderSetupMenu();
														if (122475 - 400068 == -277592)
														{
															continue;
														}
													}
													else if (eMallType == eMallType.selling)
													{
														if (56292 - 150898 == -94605)
														{
															continue;
														}
														this.RenderSellMenu();
														if (181924 - 525886 == -343961)
														{
															continue;
														}
													}
													else if (eMallType == eMallType.buying)
													{
														if (12647 - 225688 != -213041)
														{
															continue;
														}
														this.RenderBuyMenu();
														if (98204 - 34186 != 64018)
														{
															continue;
														}
													}
													this.RenderMallInventory();
													if (285512 - 468873 != -183360)
													{
														this.RenderNoticeBar();
														if (138868 - 368583 != -229714)
														{
															this.RenderMallMessege();
															if (187403 - 552445 != -365041)
															{
																if (GUI.Button(new Rect((float)401, (float)1, (float)57, (float)52), string.Empty, this.TN0cCILf5Ed))
																{
																	if (13500 - 479810 == -466309)
																	{
																		continue;
																	}
																	if (this.mState != eMallState.close)
																	{
																		if (176029 - 425666 != -249637)
																		{
																			continue;
																		}
																		this.mState = eMallState.close;
																		if (266403 - 463772 != -197369)
																		{
																			continue;
																		}
																		this.aKxcZ0Pwmdb = Time.time;
																		if (145384 - 139520 != 5864)
																		{
																			continue;
																		}
																		this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
																		if (281225 - 562299 != -281074)
																		{
																			continue;
																		}
																		if (this.mType == eMallType.buying)
																		{
																			if (45158 - 69945 != -24787)
																			{
																				continue;
																			}
																			this.MallBuyOperation(2, 0, 0, 0);
																			if (130933 - 309 != 130624)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.MallSellOperation(2);
																			if (1972 - 433841 != -431869)
																			{
																				continue;
																			}
																		}
																		if (this.zUxcCXPUfVC)
																		{
																			if (220133 - 480295 != -260162)
																			{
																				continue;
																			}
																			this.audio.PlayOneShot(this.zUxcCXPUfVC);
																			if (277758 - 338216 != -60458)
																			{
																				continue;
																			}
																		}
																	}
																}
																GUI.EndGroup();
																if (236796 - 35724 != 201073)
																{
																	this.RenderChatBar();
																	if (242432 - 330776 == -88344)
																	{
																		this.RenderDragIcon();
																		if (206767 - 297360 != -90592)
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
					else
					{
						if (eMallState != eMallState.close)
						{
							break;
						}
						if (241490 - 582578 == -341088)
						{
							if (this.mType == eMallType.buying)
							{
								if (94045 - 28735 != 65311)
								{
									Game.mGameState = eGameState.Normal;
									if (232020 - 338235 != -106214)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (276923 - 463711 == -186788)
										{
											if (gameGui)
											{
												if (288016 - 260238 != 27778)
												{
													continue;
												}
												gameGui.enabled = true;
												if (260799 - 60955 == 199845)
												{
													continue;
												}
											}
											this.mState = eMallState.disabled;
											if (240759 - 265228 != -24468)
											{
												this.enabled = false;
												if (70328 - 236437 != -166108)
												{
													break;
												}
											}
										}
									}
								}
							}
							else if (num <= (float)2)
							{
								if (124491 - 181388 != -56896)
								{
									this.RenderNPC();
									if (17141 - 447070 != -429928)
									{
										GUI.BeginGroup(new Rect(0.5f * this.OLjcZ8XfItD - (float)350, (float)724, (float)850, (float)200));
										if (131950 - 287375 == -155425)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.C59cCl22qrn);
											if (157253 - 114341 == 42912)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), CharacterData.current.Name, this.GBRcCGAxx9B);
												if (147685 - 290775 == -143090)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.rTJcCp4wGLm, num), this.xgvcC132G2R);
													if (50003 - 240896 != -190892)
													{
														GUI.EndGroup();
														if (163120 - 588794 == -425674)
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
							else if (num <= 2.5f)
							{
								if (271532 - 593760 == -322228)
								{
									this.y9qcZojuw6S = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (196599 - 547253 == -350654)
									{
										this.RenderNPC();
										if (257089 - 227325 == 29764)
										{
											break;
										}
									}
								}
							}
							else
							{
								Game.mGameState = eGameState.Normal;
								if (256887 - 35923 != 220965)
								{
									GameGui gameGui2 = (GameGui)this.GetComponent(typeof(GameGui));
									if (250996 - 383135 == -132139)
									{
										if (gameGui2)
										{
											if (95446 - 562580 == -467133)
											{
												continue;
											}
											gameGui2.enabled = true;
											if (48572 - 555207 != -506635)
											{
												continue;
											}
										}
										this.mState = eMallState.disabled;
										if (88277 - 577367 != -489089)
										{
											this.enabled = false;
											if (78516 - 406180 != -327663)
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

	// Token: 0x060061F4 RID: 25076 RVA: 0x00D76CD4 File Offset: 0x00D74ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void captureInput()
	{
		if (47964 - 59089 != -11125)
		{
		}
		for (;;)
		{
			if (!this.j6IcCONNKw1)
			{
				if (271361 - 449050 != -177688)
				{
					break;
				}
			}
			else
			{
				if (this.MlDcZktYvwj == 0)
				{
					if (41441 - 440278 == -398836)
					{
						continue;
					}
					if (Input.GetMouseButton(1))
					{
						if (34121 - 502556 != -468435)
						{
							continue;
						}
						this.j6IcCONNKw1.rotation = Mathf.Clamp(1.4f * Input.GetAxis("Mouse X"), (float)-15, (float)15);
						if (225175 - 120975 != 104200)
						{
							continue;
						}
					}
				}
				this.j6IcCONNKw1.zoom = Mathf.Clamp(Input.GetAxis("Mouse ScrollWheel"), -0.3f, 0.3f);
				if (295635 - 36301 == 259334)
				{
					if (!Input.GetKeyDown(KeyCode.Return))
					{
						break;
					}
					if (154336 - 177115 == -22779)
					{
						if (Chat.ChatTimeOut >= Time.time)
						{
							break;
						}
						if (71423 - 92719 == -21296)
						{
							Chat.ChatActive = true;
							if (220335 - 48785 == 171550)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060061F5 RID: 25077 RVA: 0x00D76E74 File Offset: 0x00D75074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (182964 - 514870 != -331906)
		{
		}
		for (;;)
		{
			this.sCicCvErZd6 = (Texture)Resources.Load("GameGui/Story/Characters/Rabbit", typeof(Texture));
			if (49670 - 448727 != -399056)
			{
				this.C59cCl22qrn = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
				if (203752 - 339440 != -135687)
				{
					this.GBRcCGAxx9B = new GUIStyle();
					if (275950 - 425208 == -149258)
					{
						this.GBRcCGAxx9B.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
						if (298595 - 468270 == -169675)
						{
							this.GBRcCGAxx9B.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
							if (4468 - 350194 != -345725)
							{
								this.GBRcCGAxx9B.alignment = TextAnchor.UpperLeft;
								if (77842 - 450734 != -372891)
								{
									this.xgvcC132G2R = new GUIStyle();
									if (275210 - 485080 != -209869)
									{
										this.xgvcC132G2R.font = (Font)Resources.Load("GameGui/Fonts/GMO38");
										if (95311 - 297860 == -202549)
										{
											this.xgvcC132G2R.alignment = TextAnchor.UpperLeft;
											if (60965 - 481800 != -420834)
											{
												this.xgvcC132G2R.wordWrap = true;
												if (245511 - 499047 != -253535)
												{
													this.a6mcCq5wsxr = Language.getMessage("MallGui", 100);
													if (59009 - 535153 == -476144)
													{
														this.rTJcCp4wGLm = Language.getMessage("MallGui", 200);
														if (250329 - 115887 != 134443)
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

	// Token: 0x060061F6 RID: 25078 RVA: 0x00D770E8 File Offset: 0x00D752E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (this.sCicCvErZd6)
		{
			GUI.DrawTexture(new Rect((float)0 - this.y9qcZojuw6S * (float)324, (float)584, (float)324, (float)440), this.sCicCvErZd6);
		}
	}

	// Token: 0x060061F7 RID: 25079 RVA: 0x00D77138 File Offset: 0x00D75338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMallMenu()
	{
		if (115956 - 402458 != -286501)
		{
		}
		for (;;)
		{
			this.NDCcZmOi0i1 = new ItemClass();
			if (36038 - 537899 == -501861)
			{
				this.sqlcCRvX8LR = new ItemClass[8];
				if (68590 - 77958 == -9368)
				{
					this.qWxcCrOFW5q = new InventoryClass[8];
					if (42804 - 75319 == -32515)
					{
						this.zBFcCxk3Ih4 = new int[8];
						if (128245 - 299764 != -171518)
						{
							this.xdHcCT7I2uX = new IconButtonClass[8];
							if (85294 - 210671 != -125376)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060061F8 RID: 25080 RVA: 0x00D77230 File Offset: 0x00D75430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMallMenu()
	{
		if (22207 - 76951 != -54744)
		{
		}
		for (;;)
		{
			IL_66:
			this.NDCcZmOi0i1 = new ItemClass();
			if (96761 - 514959 != -418197)
			{
				if (this.sqlcCRvX8LR == null)
				{
					if (24479 - 472009 == -447529)
					{
						continue;
					}
					this.sqlcCRvX8LR = new ItemClass[8];
					if (75152 - 168882 != -93730)
					{
						continue;
					}
				}
				if (this.qWxcCrOFW5q == null)
				{
					if (9929 - 157306 != -147377)
					{
						continue;
					}
					this.qWxcCrOFW5q = new InventoryClass[8];
					if (246096 - 45025 == 201072)
					{
						continue;
					}
				}
				if (this.zBFcCxk3Ih4 == null)
				{
					if (710 - 503079 != -502369)
					{
						continue;
					}
					this.zBFcCxk3Ih4 = new int[8];
					if (28362 - 451278 == -422915)
					{
						continue;
					}
				}
				if (this.xdHcCT7I2uX == null)
				{
					if (293499 - 292772 == 728)
					{
						continue;
					}
					this.xdHcCT7I2uX = new IconButtonClass[8];
					if (282793 - 350970 != -68177)
					{
						continue;
					}
				}
				int i = 0;
				if (166001 - 574830 == -408829)
				{
					while (i < 8)
					{
						this.sqlcCRvX8LR[i] = new ItemClass();
						if (45674 - 355186 != -309512)
						{
							goto IL_66;
						}
						this.qWxcCrOFW5q[i] = new InventoryClass();
						if (263910 - 20479 == 243432)
						{
							goto IL_66;
						}
						this.zBFcCxk3Ih4[i] = -1;
						if (215572 - 577552 != -361980)
						{
							goto IL_66;
						}
						this.xdHcCT7I2uX[i] = new IconButtonClass();
						if (7186 - 48631 == -41444)
						{
							goto IL_66;
						}
						this.xdHcCT7I2uX[i].image = (Texture2D)((Texture)Resources.Load("GameGui/Icons/Common/unknown", typeof(Texture)));
						if (263127 - 547186 != -284059)
						{
							goto IL_66;
						}
						i++;
						if (264511 - 173121 == 91391)
						{
							goto IL_66;
						}
					}
					if (56072 - 271901 != -215828)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060061F9 RID: 25081 RVA: 0x00D774F8 File Offset: 0x00D756F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMallInventorySlot(int nSlot)
	{
		if (266932 - 279560 != -12628)
		{
		}
		IL_13F:
		while (nSlot != -1)
		{
			if (285245 - 194612 == 90633)
			{
				int i = 0;
				if (255171 - 254266 != 906)
				{
					while (i < 8)
					{
						if (this.qWxcCrOFW5q[i].slot == nSlot)
						{
							if (131877 - 191925 == -60047)
							{
								goto IL_13F;
							}
							this.sqlcCRvX8LR[i].reset();
							if (218723 - 332271 != -113548)
							{
								goto IL_13F;
							}
							this.qWxcCrOFW5q[i].reset();
							if (156622 - 60136 != 96486)
							{
								goto IL_13F;
							}
							this.xdHcCT7I2uX[i].reset();
							if (148904 - 487266 != -338362)
							{
								goto IL_13F;
							}
							this.zBFcCxk3Ih4[i] = -1;
							if (102406 - 404021 != -301615)
							{
								goto IL_13F;
							}
						}
						i++;
						if (47351 - 247664 == -200312)
						{
							goto IL_13F;
						}
					}
					if (102547 - 147007 == -44460)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060061FA RID: 25082 RVA: 0x00D77678 File Offset: 0x00D75878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderSetupMenu()
	{
		if (271183 - 252362 != 18822)
		{
		}
		for (;;)
		{
			IL_E95:
			int i = 0;
			if (262368 - 299503 != -37134)
			{
				while (i < this.mLv * 4)
				{
					eIconButtonState eIconButtonState = IconButton.IconButton(this.xdHcCT7I2uX[i], new Rect((float)396, (float)(177 + 51 * i), (float)257, (float)51));
					if (224984 - 290072 == -65087)
					{
						goto IL_E95;
					}
					eIconButtonState eIconButtonState2 = eIconButtonState;
					if (100648 - 33635 == 67014)
					{
						goto IL_E95;
					}
					if (eIconButtonState2 == eIconButtonState.over)
					{
						if (26248 - 199546 != -173297)
						{
							goto IL_A55;
						}
						goto IL_E95;
					}
					else if (eIconButtonState2 == eIconButtonState.hover)
					{
						if (143386 - 218647 != -75261)
						{
							goto IL_E95;
						}
						goto IL_A55;
					}
					else if (eIconButtonState2 == eIconButtonState.drop)
					{
						if (146349 - 304920 == -158570)
						{
							goto IL_E95;
						}
						if (this.MlDcZktYvwj >= 20)
						{
							if (213265 - 519133 != -305868)
							{
								goto IL_E95;
							}
							if (this.MlDcZktYvwj < 50)
							{
								if (43993 - 274699 != -230706)
								{
									goto IL_E95;
								}
								this.ResetMallInventorySlot(this.qWxcCrOFW5q[i].slot);
								if (28988 - 261966 == -232977)
								{
									goto IL_E95;
								}
								this.sqlcCRvX8LR[i] = ItemData.getItemData(CharacterData.current.inventory[this.MlDcZktYvwj - 20].name);
								if (61425 - 470900 != -409475)
								{
									goto IL_E95;
								}
								this.qWxcCrOFW5q[i].copy(CharacterData.current.inventory[this.MlDcZktYvwj - 20]);
								if (53940 - 185257 != -131317)
								{
									goto IL_E95;
								}
								this.zBFcCxk3Ih4[i] = this.sqlcCRvX8LR[i].price;
								if (18850 - 12071 != 6779)
								{
									goto IL_E95;
								}
								this.xdHcCT7I2uX[i].name = CharacterData.current.inventory[this.MlDcZktYvwj - 20].name;
								if (279479 - 188222 == 91258)
								{
									goto IL_E95;
								}
								this.xdHcCT7I2uX[i].command = this.MlDcZktYvwj;
								if (273028 - 559817 == -286788)
								{
									goto IL_E95;
								}
								this.xdHcCT7I2uX[i].image = (Texture2D)IconButton.getCommandIcon(this.MlDcZktYvwj);
								if (219875 - 328158 != -108283)
								{
									goto IL_E95;
								}
								this.h0ZcZDRCCPd = i + 1;
								if (176488 - 97484 != 79004)
								{
									goto IL_E95;
								}
								this.MlDcZktYvwj = 0;
								if (122498 - 107111 != 15387)
								{
									goto IL_E95;
								}
								this.audio.PlayOneShot(this.yhvcCtdZNv7);
								if (58739 - 64336 != -5597)
								{
									goto IL_E95;
								}
							}
						}
					}
					else if (eIconButtonState2 == eIconButtonState.drag)
					{
						if (79096 - 337150 != -258054)
						{
							goto IL_E95;
						}
						this.MlDcZktYvwj = this.qWxcCrOFW5q[i].slot + 20;
						if (184883 - 96312 == 88572)
						{
							goto IL_E95;
						}
						this.sqlcCRvX8LR[i].reset();
						if (104152 - 541717 == -437564)
						{
							goto IL_E95;
						}
						this.qWxcCrOFW5q[i].reset();
						if (234801 - 351120 == -116318)
						{
							goto IL_E95;
						}
						this.xdHcCT7I2uX[i].reset();
						if (10599 - 96087 == -85487)
						{
							goto IL_E95;
						}
						this.zBFcCxk3Ih4[i] = -1;
						if (123705 - 144724 != -21019)
						{
							goto IL_E95;
						}
						this.h0ZcZDRCCPd = 0;
						if (13598 - 67728 != -54130)
						{
							goto IL_E95;
						}
					}
					IL_FB:
					if (this.xdHcCT7I2uX[i].name != "none")
					{
						if (168998 - 187144 != -18146)
						{
							goto IL_E95;
						}
						if (this.h0ZcZDRCCPd == i + 1)
						{
							if (70867 - 67682 == 3186)
							{
								goto IL_E95;
							}
							if (this.MlDcZktYvwj == 0)
							{
								if (271718 - 44943 != 226775)
								{
									goto IL_E95;
								}
								GUI.DrawTexture(new Rect((float)396, (float)(177 + 51 * i), (float)415, (float)51), this.W61cZz1y52v.hover.background);
								if (227170 - 469170 == -241999)
								{
									goto IL_E95;
								}
							}
						}
						if (this.xdHcCT7I2uX[i].image)
						{
							if (113714 - 266317 != -152603)
							{
								goto IL_E95;
							}
							GUI.DrawTexture(new Rect((float)398, (float)(170 + 51 * i), (float)64, (float)64), this.xdHcCT7I2uX[i].image);
							if (3650 - 96455 != -92805)
							{
								goto IL_E95;
							}
						}
						GUI.Label(new Rect((float)470, (float)(172 + 51 * i), (float)175, (float)50), this.sqlcCRvX8LR[i].name, this.QD7cZFWyp6g);
						if (30764 - 573536 == -542771)
						{
							goto IL_E95;
						}
						GUI.Label(new Rect((float)644, (float)(182 + 51 * i), (float)50, (float)30), string.Empty + this.qWxcCrOFW5q[i].num, this.CHhcZAWl1yo);
						if (271335 - 584067 != -312732)
						{
							goto IL_E95;
						}
						GUI.DrawTexture(new Rect((float)728, (float)(185 + 51 * i), (float)76, (float)35), this.Lg7cZh0meg6);
						if (249946 - 230926 != 19020)
						{
							goto IL_E95;
						}
						this.zBFcCxk3Ih4[i] = Stringf.getInteger(GUI.TextField(new Rect((float)732, (float)(182 + 51 * i), (float)62, (float)30), string.Empty + Mathf.Abs(this.zBFcCxk3Ih4[i]), this.lCccZ9l0G5I));
						if (4922 - 366119 == -361196)
						{
							goto IL_E95;
						}
						if (this.qWxcCrOFW5q[i].num > 1)
						{
							if (30900 - 313279 != -282379)
							{
								goto IL_E95;
							}
							GUI.DrawTexture(new Rect((float)436, (float)(170 + 51 * i + 39), (float)24, (float)24), this.jBjcCdC8Ss0);
							if (242508 - 90154 != 152354)
							{
								goto IL_E95;
							}
							GUI.Label(new Rect((float)432, (float)(170 + 51 * i + 32), (float)32, (float)32), string.Empty + this.qWxcCrOFW5q[i].num, this.WIHcC4SyDQH);
							if (297475 - 424272 != -126797)
							{
								goto IL_E95;
							}
						}
						else
						{
							string type = this.qWxcCrOFW5q[i].getType();
							if (165255 - 424126 == -258870)
							{
								goto IL_E95;
							}
							if (!(type == "w"))
							{
								if (35495 - 428833 == -393337)
								{
									goto IL_E95;
								}
								if (!(type == "a"))
								{
									if (280760 - 377282 != -96522)
									{
										goto IL_E95;
									}
									if (!(type == "c"))
									{
										if (291074 - 447052 != -155978)
										{
											goto IL_E95;
										}
										if (!(type == "b"))
										{
											if (65406 - 518572 != -453166)
											{
												goto IL_E95;
											}
											if (!(type == "t"))
											{
												if (212483 - 1277 != 211206)
												{
													goto IL_E95;
												}
												if (!(type == "p"))
												{
													goto IL_88;
												}
												if (4231 - 137738 != -133507)
												{
													goto IL_E95;
												}
											}
										}
									}
								}
							}
							if (this.qWxcCrOFW5q[i].owner == 0)
							{
								if (15327 - 553132 == -537804)
								{
									goto IL_E95;
								}
								GUI.DrawTexture(new Rect((float)436, (float)(170 + 51 * i + 39), (float)24, (float)24), this.odScCgB5Nif);
								if (16217 - 384195 != -367978)
								{
									goto IL_E95;
								}
							}
							else if (this.qWxcCrOFW5q[i].owner != CharacterData.current.CID)
							{
								if (170791 - 96322 == 74470)
								{
									goto IL_E95;
								}
								GUI.DrawTexture(new Rect((float)436, (float)(170 + 51 * i + 39), (float)24, (float)24), this.oJpcCarHobf);
								if (203798 - 494209 != -290411)
								{
									goto IL_E95;
								}
							}
						}
					}
					IL_88:
					i++;
					if (102667 - 449724 != -347056)
					{
						continue;
					}
					goto IL_E95;
					IL_A55:
					if (this.MlDcZktYvwj < 20)
					{
						goto IL_90D;
					}
					if (84729 - 552564 == -467834)
					{
						goto IL_E95;
					}
					if (this.MlDcZktYvwj >= 50)
					{
						goto IL_90D;
					}
					if (8646 - 79933 != -71287)
					{
						goto IL_E95;
					}
					GUI.DrawTexture(new Rect((float)396, (float)(177 + 51 * i), (float)415, (float)51), this.W61cZz1y52v.hover.background);
					if (60766 - 121216 != -60450)
					{
						goto IL_E95;
					}
					IL_E47:
					goto IL_FB;
					IL_90D:
					if (!(this.xdHcCT7I2uX[i].name != "none"))
					{
						goto IL_E47;
					}
					if (77526 - 386578 != -309052)
					{
						goto IL_E95;
					}
					if (!GUI.Button(new Rect((float)396, (float)(177 + 51 * i), (float)257, (float)50), string.Empty, this.xincZKvaobg))
					{
						goto IL_E47;
					}
					if (15765 - 33917 == -18151)
					{
						goto IL_E95;
					}
					if (this.Er0cC8s2s3d >= Time.time)
					{
						goto IL_E47;
					}
					if (292381 - 249428 == 42954)
					{
						goto IL_E95;
					}
					this.h0ZcZDRCCPd = i + 1;
					if (26512 - 46137 != -19625)
					{
						goto IL_E95;
					}
					this.audio.PlayOneShot(this.yhvcCtdZNv7);
					if (269400 - 34579 != 234822)
					{
						goto IL_E47;
					}
					goto IL_E95;
				}
				if (241241 - 286557 == -45316)
				{
					GUI.DrawTexture(new Rect((float)420, (float)586, (float)385, (float)56), this.CZ6cZyeVArp);
					if (220905 - 340871 == -119966)
					{
						if (GUI.Button(new Rect((float)432, (float)603, (float)110, (float)34), string.Empty, this.ljjcC5Ayq5Y))
						{
							if (91322 - 589190 != -497868)
							{
								continue;
							}
							if (Time.time > this.aKxcZ0Pwmdb + (float)1)
							{
								if (96751 - 263519 != -166768)
								{
									continue;
								}
								if (!SafeWord.isSafe(this.mMallName))
								{
									if (123033 - 165610 != -42577)
									{
										continue;
									}
									this.newNoticeBar("Cannot use bad word", 2f);
									if (4912 - 310257 == -305344)
									{
										continue;
									}
								}
								else if (this.isInventoryEmpty())
								{
									if (45840 - 399266 != -353426)
									{
										continue;
									}
									this.newNoticeBar("Cannot open with empty inventory", 2f);
									if (226178 - 53535 == 172644)
									{
										continue;
									}
								}
								else if (this.isPriceZero())
								{
									if (15407 - 464295 == -448887)
									{
										continue;
									}
									this.newNoticeBar("Cannot set price to be zero", 2f);
									if (242174 - 554140 == -311965)
									{
										continue;
									}
								}
								else
								{
									this.mType = eMallType.selling;
									if (182905 - 254896 != -71991)
									{
										continue;
									}
									this.aKxcZ0Pwmdb = Time.time;
									if (207825 - 335594 != -127769)
									{
										continue;
									}
									this.MallSellOperation(1);
									if (32766 - 249201 != -216435)
									{
										continue;
									}
									this.audio.PlayOneShot(this.anfcCJEiXwH);
									if (121457 - 494987 != -373530)
									{
										continue;
									}
								}
							}
						}
						GUI.SetNextControlName("MallNameField");
						if (197432 - 551830 != -354397)
						{
							this.mMallName = GUI.TextField(new Rect((float)580, (float)610, (float)210, (float)30), this.mMallName, 20, this.aK1cCM5UZk3);
							if (255462 - 449033 == -193571)
							{
								this.mMallName = this.mMallName.Replace("/n", string.Empty);
								if (127913 - 152943 == -25030)
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

	// Token: 0x060061FB RID: 25083 RVA: 0x00D78548 File Offset: 0x00D76748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderSellMenu()
	{
		if (40224 - 151481 != -111257)
		{
		}
		for (;;)
		{
			IL_5C8:
			int i = 0;
			if (126198 - 492110 == -365912)
			{
				while (i < this.mLv * 4)
				{
					if (this.xdHcCT7I2uX[i].name != "none")
					{
						if (61122 - 511337 != -450215)
						{
							goto IL_5C8;
						}
						if (this.xdHcCT7I2uX[i].image)
						{
							if (57632 - 164156 != -106524)
							{
								goto IL_5C8;
							}
							GUI.DrawTexture(new Rect((float)398, (float)(170 + 51 * i), (float)64, (float)64), this.xdHcCT7I2uX[i].image);
							if (85322 - 52046 != 33276)
							{
								goto IL_5C8;
							}
						}
						GUI.Label(new Rect((float)470, (float)(170 + 51 * i), (float)175, (float)50), this.sqlcCRvX8LR[i].name, this.QD7cZFWyp6g);
						if (148715 - 184377 == -35661)
						{
							goto IL_5C8;
						}
						GUI.Label(new Rect((float)644, (float)(182 + 51 * i), (float)50, (float)30), string.Empty + this.qWxcCrOFW5q[i].num, this.CHhcZAWl1yo);
						if (255509 - 374659 != -119150)
						{
							goto IL_5C8;
						}
						GUI.Label(new Rect((float)732, (float)(182 + 51 * i), (float)62, (float)30), string.Empty + this.zBFcCxk3Ih4[i], this.lCccZ9l0G5I);
						if (229294 - 221579 != 7715)
						{
							goto IL_5C8;
						}
						if (this.qWxcCrOFW5q[i].num > 1)
						{
							if (80219 - 504793 == -424573)
							{
								goto IL_5C8;
							}
							GUI.DrawTexture(new Rect((float)436, (float)(170 + 51 * i + 39), (float)24, (float)24), this.jBjcCdC8Ss0);
							if (111539 - 440350 != -328811)
							{
								goto IL_5C8;
							}
							GUI.Label(new Rect((float)432, (float)(170 + 51 * i + 32), (float)32, (float)32), string.Empty + this.qWxcCrOFW5q[i].num, this.WIHcC4SyDQH);
							if (44967 - 18990 == 25978)
							{
								goto IL_5C8;
							}
						}
						else
						{
							string type = this.qWxcCrOFW5q[i].getType();
							if (118076 - 437176 != -319100)
							{
								goto IL_5C8;
							}
							if (!(type == "w"))
							{
								if (55895 - 209740 == -153844)
								{
									goto IL_5C8;
								}
								if (!(type == "a"))
								{
									if (140711 - 456165 != -315454)
									{
										goto IL_5C8;
									}
									if (!(type == "c"))
									{
										if (13471 - 537015 == -523543)
										{
											goto IL_5C8;
										}
										if (!(type == "b"))
										{
											if (13006 - 576967 == -563960)
											{
												goto IL_5C8;
											}
											if (!(type == "t"))
											{
												if (97999 - 344945 == -246945)
												{
													goto IL_5C8;
												}
												if (!(type == "p"))
												{
													goto IL_585;
												}
												if (220087 - 548027 == -327939)
												{
													goto IL_5C8;
												}
											}
										}
									}
								}
							}
							if (this.qWxcCrOFW5q[i].owner == 0)
							{
								if (155626 - 171344 == -15717)
								{
									goto IL_5C8;
								}
								GUI.DrawTexture(new Rect((float)436, (float)(170 + 51 * i + 39), (float)24, (float)24), this.odScCgB5Nif);
								if (27056 - 586562 == -559505)
								{
									goto IL_5C8;
								}
							}
							else if (this.qWxcCrOFW5q[i].owner != CharacterData.current.CID)
							{
								if (135787 - 489783 == -353995)
								{
									goto IL_5C8;
								}
								GUI.DrawTexture(new Rect((float)436, (float)(170 + 51 * i + 39), (float)24, (float)24), this.oJpcCarHobf);
								if (226809 - 176066 == 50744)
								{
									goto IL_5C8;
								}
							}
						}
					}
					IL_585:
					i++;
					if (28463 - 303646 == -275182)
					{
						goto IL_5C8;
					}
				}
				if (289324 - 377286 != -87961)
				{
					GUI.DrawTexture(new Rect((float)420, (float)586, (float)385, (float)56), this.CZ6cZyeVArp);
					if (102502 - 447324 != -344821)
					{
						if (!GUI.Button(new Rect((float)432, (float)603, (float)110, (float)34), string.Empty, this.cALcCcfJN3C))
						{
							break;
						}
						if (26869 - 598944 == -572075)
						{
							if (Time.time <= this.aKxcZ0Pwmdb + (float)1)
							{
								break;
							}
							if (251514 - 407413 == -155899)
							{
								this.mType = eMallType.setup;
								if (148729 - 397718 != -248988)
								{
									this.aKxcZ0Pwmdb = Time.time;
									if (222397 - 340768 == -118371)
									{
										this.MallSellOperation(0);
										if (95421 - 504647 == -409226)
										{
											this.audio.PlayOneShot(this.anfcCJEiXwH);
											if (291098 - 453490 != -162391)
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

	// Token: 0x060061FC RID: 25084 RVA: 0x00D78BCC File Offset: 0x00D76DCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderBuyMenu()
	{
		if (36902 - 50744 != -13841)
		{
		}
		for (;;)
		{
			IL_AFB:
			int num;
			Vector2 vector;
			Texture nHoverImage;
			if (this.qWxcCrOFW5q == null)
			{
				if (183345 - 259615 != -76270)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)360, (float)480, (float)475, (float)102), this.r4QcCBdXGxj);
				if (183422 - 384010 == -200587)
				{
					continue;
				}
				GUI.Label(new Rect((float)395, (float)510, (float)400, (float)40), "Loading Mall Inventory", this.tLdcC0PLftv);
				if (132531 - 460386 != -327855)
				{
					continue;
				}
			}
			else
			{
				num = -1;
				if (217688 - 280215 != -62527)
				{
					continue;
				}
				vector = new Vector2((float)0, (float)0);
				if (77964 - 553593 != -475629)
				{
					continue;
				}
				nHoverImage = null;
				if (264363 - 372705 != -108342)
				{
					continue;
				}
				int i = 0;
				if (279609 - 429037 != -149428)
				{
					continue;
				}
				while (i < 8)
				{
					if (this.xdHcCT7I2uX[i].name != "none")
					{
						if (180535 - 433860 == -253324)
						{
							goto IL_AFB;
						}
						eIconButtonState eIconButtonState = IconButton.IconButton(this.xdHcCT7I2uX[i], new Rect((float)396, (float)(177 + 51 * i), (float)257, (float)51));
						if (70325 - 497096 == -426770)
						{
							goto IL_AFB;
						}
						if (eIconButtonState == eIconButtonState.hover)
						{
							goto IL_255;
						}
						if (56255 - 61960 != -5705)
						{
							goto IL_AFB;
						}
						if (eIconButtonState == eIconButtonState.over)
						{
							if (75759 - 284584 != -208824)
							{
								goto IL_255;
							}
							goto IL_AFB;
						}
						IL_749:
						if (this.h0ZcZDRCCPd == i + 1)
						{
							if (160055 - 136859 != 23196)
							{
								goto IL_AFB;
							}
							GUI.DrawTexture(new Rect((float)396, (float)(177 + 51 * i), (float)415, (float)51), this.W61cZz1y52v.hover.background);
							if (200026 - 315975 != -115949)
							{
								goto IL_AFB;
							}
						}
						if (this.xdHcCT7I2uX[i].image)
						{
							if (270007 - 470009 != -200002)
							{
								goto IL_AFB;
							}
							GUI.DrawTexture(new Rect((float)398, (float)(170 + 51 * i), (float)64, (float)64), this.xdHcCT7I2uX[i].image);
							if (151843 - 90961 != 60882)
							{
								goto IL_AFB;
							}
						}
						string type = this.qWxcCrOFW5q[i].getType();
						if (231881 - 493102 != -261221)
						{
							goto IL_AFB;
						}
						if (type == "w")
						{
							goto IL_271;
						}
						if (217304 - 309760 != -92456)
						{
							goto IL_AFB;
						}
						if (type == "a")
						{
							goto IL_271;
						}
						if (231859 - 25845 == 206015)
						{
							goto IL_AFB;
						}
						if (type == "c")
						{
							goto IL_271;
						}
						if (220965 - 403017 != -182052)
						{
							goto IL_AFB;
						}
						if (type == "b")
						{
							goto IL_271;
						}
						if (211513 - 290905 != -79392)
						{
							goto IL_AFB;
						}
						if (type == "t")
						{
							goto IL_271;
						}
						if (6638 - 220410 == -213771)
						{
							goto IL_AFB;
						}
						if (type == "p")
						{
							if (269309 - 417177 != -147868)
							{
								goto IL_AFB;
							}
							goto IL_271;
						}
						IL_2DC:
						GUI.Label(new Rect((float)470, (float)(170 + 51 * i), (float)175, (float)50), this.sqlcCRvX8LR[i].name, this.QD7cZFWyp6g);
						if (207766 - 89005 != 118761)
						{
							goto IL_AFB;
						}
						GUI.Label(new Rect((float)644, (float)(182 + 51 * i), (float)50, (float)30), "x" + this.qWxcCrOFW5q[i].num, this.CHhcZAWl1yo);
						if (92991 - 390124 == -297132)
						{
							goto IL_AFB;
						}
						if (this.zBFcCxk3Ih4[i] <= PlayerData.Gil)
						{
							if (239282 - 188088 == 51195)
							{
								goto IL_AFB;
							}
							GUI.Label(new Rect((float)732, (float)(182 + 51 * i), (float)62, (float)30), string.Empty + this.zBFcCxk3Ih4[i], this.lCccZ9l0G5I);
							if (36758 - 194807 == -158048)
							{
								goto IL_AFB;
							}
						}
						else
						{
							GUI.Label(new Rect((float)732, (float)(182 + 51 * i), (float)62, (float)30), string.Empty + this.zBFcCxk3Ih4[i], this.gdncZWriKG1);
							if (298176 - 39535 == 258642)
							{
								goto IL_AFB;
							}
						}
						if (!GUI.Button(new Rect((float)396, (float)(179 + 51 * i), (float)257, (float)50), string.Empty, this.xincZKvaobg))
						{
							goto IL_29D;
						}
						if (152176 - 571263 != -419087)
						{
							goto IL_AFB;
						}
						if (this.Er0cC8s2s3d >= Time.time)
						{
							goto IL_29D;
						}
						if (23585 - 186430 == -162844)
						{
							goto IL_AFB;
						}
						this.h0ZcZDRCCPd = i + 1;
						if (81706 - 188116 == -106409)
						{
							goto IL_AFB;
						}
						this.fSbcZjNXHGo = 1;
						if (97716 - 521394 == -423677)
						{
							goto IL_AFB;
						}
						this.audio.PlayOneShot(this.yhvcCtdZNv7);
						if (262036 - 373842 != -111806)
						{
							goto IL_AFB;
						}
						goto IL_29D;
						IL_271:
						if (this.qWxcCrOFW5q[i].owner == 0)
						{
							if (162855 - 49245 != 113610)
							{
								goto IL_AFB;
							}
							GUI.DrawTexture(new Rect((float)436, (float)(170 + 51 * i + 39), (float)24, (float)24), this.odScCgB5Nif);
							if (268233 - 404217 != -135983)
							{
								goto IL_2DC;
							}
							goto IL_AFB;
						}
						else
						{
							if (this.qWxcCrOFW5q[i].owner == CharacterData.current.CID)
							{
								goto IL_2DC;
							}
							if (34786 - 519893 != -485107)
							{
								goto IL_AFB;
							}
							GUI.DrawTexture(new Rect((float)436, (float)(170 + 51 * i + 39), (float)24, (float)24), this.oJpcCarHobf);
							if (286432 - 340620 != -54188)
							{
								goto IL_AFB;
							}
							goto IL_2DC;
						}
						IL_255:
						num = i;
						if (285067 - 367184 == -82116)
						{
							goto IL_AFB;
						}
						vector = new Vector2((float)134, (float)(170 + 51 * i - 128));
						if (283739 - 41784 != 241955)
						{
							goto IL_AFB;
						}
						nHoverImage = this.xdHcCT7I2uX[i].image;
						if (145280 - 279672 != -134392)
						{
							goto IL_AFB;
						}
						goto IL_749;
					}
					IL_29D:
					i++;
					if (41366 - 94842 != -53476)
					{
						goto IL_AFB;
					}
				}
				if (278767 - 400108 != -121341)
				{
					continue;
				}
			}
			GUI.DrawTexture(new Rect((float)420, (float)586, (float)385, (float)56), this.pCBcZVPuPcD);
			if (22294 - 562759 != -540464)
			{
				if (this.h0ZcZDRCCPd == 0)
				{
					if (182619 - 438360 != -255741)
					{
						continue;
					}
					GUI.Label(new Rect((float)410, (float)601, (float)100, (float)36), "-", this.lCccZ9l0G5I);
					if (299681 - 478043 != -178362)
					{
						continue;
					}
					GUI.Label(new Rect((float)548, (float)601, (float)40, (float)36), "-", this.CHhcZAWl1yo);
					if (99339 - 281656 == -182316)
					{
						continue;
					}
					GUI.Label(new Rect((float)588, (float)601, (float)100, (float)36), "-", this.lCccZ9l0G5I);
					if (144279 - 19388 == 124892)
					{
						continue;
					}
				}
				else
				{
					GUI.Label(new Rect((float)410, (float)601, (float)100, (float)36), string.Empty + this.sqlcCRvX8LR[this.h0ZcZDRCCPd - 1].price, this.lCccZ9l0G5I);
					if (61319 - 445797 == -384477)
					{
						continue;
					}
					GUI.Label(new Rect((float)548, (float)601, (float)40, (float)36), string.Empty + this.fSbcZjNXHGo, this.CHhcZAWl1yo);
					if (72997 - 340074 != -267077)
					{
						continue;
					}
					GUI.Label(new Rect((float)588, (float)601, (float)100, (float)36), string.Empty + this.zBFcCxk3Ih4[this.h0ZcZDRCCPd - 1] * this.fSbcZjNXHGo, this.lCccZ9l0G5I);
					if (209533 - 520561 != -311028)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)596, (float)601, (float)22, (float)18), string.Empty, this.VnAcCQn9yfY))
					{
						if (222136 - 235565 != -13429)
						{
							continue;
						}
						this.fSbcZjNXHGo = Mathf.Min(this.fSbcZjNXHGo + 1, this.qWxcCrOFW5q[this.h0ZcZDRCCPd - 1].num);
						if (25910 - 508444 == -482533)
						{
							continue;
						}
						this.audio.PlayOneShot(this.yhvcCtdZNv7);
						if (20716 - 540726 != -520010)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)596, (float)622, (float)22, (float)18), string.Empty, this.TuocCefkvk6))
					{
						if (214212 - 473692 == -259479)
						{
							continue;
						}
						this.fSbcZjNXHGo = Mathf.Max(this.fSbcZjNXHGo - 1, 1);
						if (269224 - 19252 != 249972)
						{
							continue;
						}
						this.audio.PlayOneShot(this.yhvcCtdZNv7);
						if (102619 - 213670 == -111050)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)712, (float)601, (float)85, (float)39), string.Empty, this.zuxcCnAhn5Y))
					{
						if (195241 - 291554 != -96313)
						{
							continue;
						}
						if (Time.time > this.aKxcZ0Pwmdb + (float)1)
						{
							if (147010 - 5079 == 141932)
							{
								continue;
							}
							if (this.zBFcCxk3Ih4[this.h0ZcZDRCCPd - 1] * this.fSbcZjNXHGo > PlayerData.Gil)
							{
								if (229132 - 95595 == 133538)
								{
									continue;
								}
								this.newNoticeBar("Not enough gil!", (float)2);
								if (238661 - 146071 == 92591)
								{
									continue;
								}
							}
							else
							{
								this.MallBuyOperation(1, this.h0ZcZDRCCPd - 1, this.fSbcZjNXHGo, this.zBFcCxk3Ih4[this.h0ZcZDRCCPd - 1] * this.fSbcZjNXHGo);
								if (200930 - 79953 == 120978)
								{
									continue;
								}
							}
							this.aKxcZ0Pwmdb = Time.time;
							if (283341 - 572722 != -289381)
							{
								continue;
							}
							this.audio.PlayOneShot(this.anfcCJEiXwH);
							if (59078 - 326063 == -266984)
							{
								continue;
							}
						}
					}
				}
				if (num < 0)
				{
					break;
				}
				if (240982 - 416127 == -175145)
				{
					if (num >= 8)
					{
						break;
					}
					if (107067 - 328577 == -221510)
					{
						if (this.qWxcCrOFW5q == null)
						{
							break;
						}
						if (45047 - 353029 != -307981)
						{
							if (this.qWxcCrOFW5q[num] == null)
							{
								break;
							}
							if (107971 - 593281 == -485310)
							{
								InventoryClass nHoverItem = this.qWxcCrOFW5q[num];
								if (26631 - 217369 != -190737)
								{
									Guix.renderItemToolTip((int)vector.x, (int)vector.y, nHoverItem, nHoverImage);
									if (75407 - 363704 == -288297)
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

	// Token: 0x060061FD RID: 25085 RVA: 0x00D79A14 File Offset: 0x00D77C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMallInventory()
	{
		if (299598 - 523411 != -223812)
		{
		}
		for (;;)
		{
			this.HoZcCYB1hda = new IconButtonClass[30];
			if (356 - 442304 != -441947)
			{
				this.FswcC3Ywn68 = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover", typeof(Texture));
				if (101235 - 132625 == -31390)
				{
					this.wQHcCbH3elO = (Texture)Resources.Load("GameGui/Icons/Common/Item_inactive", typeof(Texture));
					if (23011 - 216331 != -193319)
					{
						this.jBjcCdC8Ss0 = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
						if (270091 - 532335 == -262244)
						{
							this.odScCgB5Nif = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
							if (54655 - 61225 == -6570)
							{
								this.oJpcCarHobf = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
								if (180613 - 393924 == -213311)
								{
									this.WIHcC4SyDQH = new GUIStyle();
									if (178698 - 595769 != -417070)
									{
										this.WIHcC4SyDQH.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
										if (224462 - 478913 == -254451)
										{
											this.WIHcC4SyDQH.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
											if (260437 - 120897 == 139540)
											{
												this.WIHcC4SyDQH.alignment = TextAnchor.MiddleCenter;
												if (21542 - 90393 != -68850)
												{
													this.KA8cCstZlxB = new GUIStyle();
													if (189974 - 447106 == -257132)
													{
														this.KA8cCstZlxB.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
														if (22421 - 198568 != -176146)
														{
															this.KA8cCstZlxB.alignment = TextAnchor.MiddleCenter;
															if (87856 - 170644 == -82788)
															{
																this.KA8cCstZlxB.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																if (100583 - 514157 == -413574)
																{
																	this.wFNcCHU29WD = new GUIStyle();
																	if (68809 - 469999 == -401190)
																	{
																		this.wFNcCHU29WD.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																		if (42636 - 383720 == -341084)
																		{
																			this.wFNcCHU29WD.alignment = TextAnchor.MiddleCenter;
																			if (186440 - 402021 != -215580)
																			{
																				this.wFNcCHU29WD.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																				if (138229 - 112054 == 26175)
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

	// Token: 0x060061FE RID: 25086 RVA: 0x00D79DD0 File Offset: 0x00D77FD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMallInventory()
	{
		if (128717 - 170433 != -41715)
		{
		}
		for (;;)
		{
			IL_E3:
			int i = 0;
			if (32049 - 453700 == -421651)
			{
				while (i < 30)
				{
					this.HoZcCYB1hda[i] = new IconButtonClass();
					if (186047 - 180352 == 5696)
					{
						goto IL_E3;
					}
					if (CharacterData.current.inventory[i].name != "none")
					{
						if (270944 - 256447 == 14498)
						{
							goto IL_E3;
						}
						this.HoZcCYB1hda[i].name = CharacterData.current.inventory[i].name;
						if (42425 - 236445 != -194020)
						{
							goto IL_E3;
						}
						this.HoZcCYB1hda[i].command = i + 20;
						if (241769 - 175421 == 66349)
						{
							goto IL_E3;
						}
						this.HoZcCYB1hda[i].image = (Texture2D)IconButton.getCommandIcon(i + 20);
						if (22881 - 392365 == -369483)
						{
							goto IL_E3;
						}
					}
					i++;
					if (165740 - 403730 == -237989)
					{
						goto IL_E3;
					}
				}
				if (150316 - 281933 != -131616)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060061FF RID: 25087 RVA: 0x00D79F64 File Offset: 0x00D78164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMallInventory()
	{
		if (161687 - 376109 != -214421)
		{
		}
		for (;;)
		{
			IL_4DA:
			int num = 0;
			if (253084 - 353781 == -100697)
			{
				string text = "none";
				if (87468 - 85261 == 2207)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (25505 - 151734 != -126228)
					{
						Texture nHoverImage = null;
						if (149141 - 273490 != -124348)
						{
							int i = 0;
							if (202174 - 565689 == -363515)
							{
								while (i < 30)
								{
									if (this.HoZcCYB1hda[i].name != "none")
									{
										if (88815 - 475011 == -386195)
										{
											goto IL_4DA;
										}
										Rect position = new Rect((float)418 + global::Math.mod((float)i, (float)6) * (float)60, (float)(674 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
										if (265217 - 584626 != -319409)
										{
											goto IL_4DA;
										}
										if (this.mType != eMallType.selling)
										{
											goto IL_85B;
										}
										if (165179 - 530739 == -365559)
										{
											goto IL_4DA;
										}
										if (!RuntimeServices.EqualityOperator(this.qWxcCrOFW5q[0], CharacterData.current.inventory[i]))
										{
											if (131321 - 217235 != -85914)
											{
												goto IL_4DA;
											}
											if (!RuntimeServices.EqualityOperator(this.qWxcCrOFW5q[1], CharacterData.current.inventory[i]))
											{
												if (176100 - 362833 == -186732)
												{
													goto IL_4DA;
												}
												if (!RuntimeServices.EqualityOperator(this.qWxcCrOFW5q[2], CharacterData.current.inventory[i]))
												{
													if (293334 - 151161 != 142173)
													{
														goto IL_4DA;
													}
													if (!RuntimeServices.EqualityOperator(this.qWxcCrOFW5q[3], CharacterData.current.inventory[i]))
													{
														if (63670 - 420039 != -356369)
														{
															goto IL_4DA;
														}
														if (!RuntimeServices.EqualityOperator(this.qWxcCrOFW5q[4], CharacterData.current.inventory[i]))
														{
															if (69918 - 384551 == -314632)
															{
																goto IL_4DA;
															}
															if (!RuntimeServices.EqualityOperator(this.qWxcCrOFW5q[5], CharacterData.current.inventory[i]))
															{
																if (26267 - 232520 != -206253)
																{
																	goto IL_4DA;
																}
																if (!RuntimeServices.EqualityOperator(this.qWxcCrOFW5q[6], CharacterData.current.inventory[i]))
																{
																	if (8059 - 154096 == -146036)
																	{
																		goto IL_4DA;
																	}
																	if (!RuntimeServices.EqualityOperator(this.qWxcCrOFW5q[7], CharacterData.current.inventory[i]))
																	{
																		goto IL_85B;
																	}
																	if (137391 - 280187 != -142796)
																	{
																		goto IL_4DA;
																	}
																}
															}
														}
													}
												}
											}
										}
										GUI.DrawTexture(position, this.HoZcCYB1hda[i].image);
										if (211211 - 105446 != 105765)
										{
											goto IL_4DA;
										}
										GUI.DrawTexture(new Rect(position.x + (float)6, position.y + (float)6, (float)51, (float)51), this.wQHcCbH3elO);
										if (168619 - 538592 == -369972)
										{
											goto IL_4DA;
										}
										IL_14D:
										if (CharacterData.current.inventory[i].num > 1)
										{
											if (254187 - 37497 != 216690)
											{
												goto IL_4DA;
											}
											GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.jBjcCdC8Ss0);
											if (145497 - 534977 != -389480)
											{
												goto IL_4DA;
											}
											GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.WIHcC4SyDQH);
											if (24661 - 101489 != -76827)
											{
												goto IL_2EE;
											}
											goto IL_4DA;
										}
										else
										{
											string type = CharacterData.current.inventory[i].getType();
											if (116422 - 106886 != 9536)
											{
												goto IL_4DA;
											}
											if (!(type == "w"))
											{
												if (44105 - 302575 == -258469)
												{
													goto IL_4DA;
												}
												if (!(type == "a"))
												{
													if (277129 - 488162 == -211032)
													{
														goto IL_4DA;
													}
													if (!(type == "c"))
													{
														if (21117 - 77316 != -56199)
														{
															goto IL_4DA;
														}
														if (!(type == "b"))
														{
															if (101843 - 255022 != -153179)
															{
																goto IL_4DA;
															}
															if (!(type == "t"))
															{
																if (9011 - 39028 != -30017)
																{
																	goto IL_4DA;
																}
																if (!(type == "p"))
																{
																	goto IL_2EE;
																}
																if (96161 - 505918 == -409756)
																{
																	goto IL_4DA;
																}
															}
														}
													}
												}
											}
											if (CharacterData.current.inventory[i].owner == 0)
											{
												if (43561 - 4651 != 38910)
												{
													goto IL_4DA;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.odScCgB5Nif);
												if (143800 - 148889 != -5088)
												{
													goto IL_2EE;
												}
												goto IL_4DA;
											}
											else
											{
												if (CharacterData.current.inventory[i].owner == CharacterData.current.CID)
												{
													goto IL_2EE;
												}
												if (222754 - 244788 != -22034)
												{
													goto IL_4DA;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.oJpcCarHobf);
												if (135043 - 239914 != -104870)
												{
													goto IL_2EE;
												}
												goto IL_4DA;
											}
										}
										IL_85B:
										eIconButtonState eIconButtonState = IconButton.IconButton(this.HoZcCYB1hda[i], new Rect(position.x + (float)6, position.y + (float)6, (float)50, (float)50));
										if (296671 - 246343 == 50329)
										{
											goto IL_4DA;
										}
										eIconButtonState eIconButtonState2 = eIconButtonState;
										if (239677 - 277911 != -38234)
										{
											goto IL_4DA;
										}
										if (eIconButtonState2 == eIconButtonState.none)
										{
											if (100436 - 400471 != -300035)
											{
												goto IL_4DA;
											}
										}
										else if (eIconButtonState2 == eIconButtonState.press)
										{
											if (114458 - 338740 == -224281)
											{
												goto IL_4DA;
											}
										}
										else if (eIconButtonState2 == eIconButtonState.over)
										{
											if (183227 - 483532 == -300304)
											{
												goto IL_4DA;
											}
											GUI.DrawTexture(position, this.HoZcCYB1hda[i].image);
											if (109605 - 46946 == 62660)
											{
												goto IL_4DA;
											}
											GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.FswcC3Ywn68);
											if (184533 - 599382 != -414849)
											{
												goto IL_4DA;
											}
											if (this.MlDcZktYvwj == 0)
											{
												if (151453 - 382346 != -230893)
												{
													goto IL_4DA;
												}
												text = ItemData.getName(CharacterData.current.inventory[i].name);
												if (170556 - 592075 != -421519)
												{
													goto IL_4DA;
												}
												if (CharacterData.current.inventory[i].mlv != 0)
												{
													if (39080 - 537147 == -498066)
													{
														goto IL_4DA;
													}
													text += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
													if (233745 - 105614 != 128131)
													{
														goto IL_4DA;
													}
												}
												vector = new Vector2(position.x - (float)120, position.y + (float)51);
												if (195156 - 494765 != -299609)
												{
													goto IL_4DA;
												}
											}
											goto IL_14D;
										}
										else if (eIconButtonState2 == eIconButtonState.hover)
										{
											if (283029 - 46040 != 236989)
											{
												goto IL_4DA;
											}
											GUI.DrawTexture(position, this.HoZcCYB1hda[i].image);
											if (249520 - 8229 == 241292)
											{
												goto IL_4DA;
											}
											GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.FswcC3Ywn68);
											if (203263 - 69237 != 134027)
											{
												if (this.MlDcZktYvwj == 0)
												{
													if (40468 - 45742 == -5273)
													{
														goto IL_4DA;
													}
													if (CharacterData.current.inventory[i].name != "none")
													{
														if (197159 - 470111 == -272951)
														{
															goto IL_4DA;
														}
														num = i + 20;
														if (295631 - 388355 != -92724)
														{
															goto IL_4DA;
														}
														vector = new Vector2(position.x - (float)264, position.y - (float)128);
														if (84322 - 350286 != -265964)
														{
															goto IL_4DA;
														}
														nHoverImage = this.HoZcCYB1hda[i].image;
														if (65243 - 500764 != -435521)
														{
															goto IL_4DA;
														}
													}
												}
												goto IL_14D;
											}
											goto IL_4DA;
										}
										else if (eIconButtonState2 == eIconButtonState.drag)
										{
											if (180570 - 478076 != -297506)
											{
												goto IL_4DA;
											}
											if (this.mType != eMallType.selling)
											{
												if (98251 - 281605 == -183353)
												{
													goto IL_4DA;
												}
												this.HoZcCYB1hda[i].state = eIconButtonState.none;
												if (39042 - 471900 == -432857)
												{
													goto IL_4DA;
												}
												if (this.HoZcCYB1hda[i].command != 0)
												{
													if (156048 - 81719 != 74329)
													{
														goto IL_4DA;
													}
													this.MlDcZktYvwj = i + 20;
													if (282129 - 147445 == 134685)
													{
														goto IL_4DA;
													}
												}
											}
											goto IL_14D;
										}
										else
										{
											if (eIconButtonState2 != eIconButtonState.drop)
											{
												goto IL_14D;
											}
											if (24391 - 534618 != -510227)
											{
												goto IL_4DA;
											}
											this.MlDcZktYvwj = 0;
											if (108477 - 473848 != -365371)
											{
												goto IL_4DA;
											}
											goto IL_14D;
										}
										GUI.DrawTexture(position, this.HoZcCYB1hda[i].image);
										if (201411 - 347564 != -146153)
										{
											goto IL_4DA;
										}
										goto IL_14D;
									}
									IL_2EE:
									i++;
									if (278775 - 282074 != -3299)
									{
										goto IL_4DA;
									}
								}
								if (56053 - 508629 == -452576)
								{
									if (this.MlDcZktYvwj != 0)
									{
										break;
									}
									if (292166 - 296710 != -4543)
									{
										if (text != "none")
										{
											if (189692 - 517349 == -327657)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.wFNcCHU29WD);
												if (291789 - 409200 != -117410)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.KA8cCstZlxB);
													if (219789 - 414410 == -194621)
													{
														break;
													}
												}
											}
										}
										else
										{
											if (num < 20)
											{
												break;
											}
											if (78175 - 350663 == -272488)
											{
												InventoryClass nHoverItem = CharacterData.current.inventory[num - 20];
												if (258585 - 116974 == 141611)
												{
													Guix.renderItemToolTip((int)vector.x, (int)vector.y, nHoverItem, nHoverImage);
													if (209185 - 94960 != 114226)
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

	// Token: 0x06006200 RID: 25088 RVA: 0x00D7AD08 File Offset: 0x00D78F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (92096 - 233584 != -141488)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (7106 - 599717 == -592611)
				{
					break;
				}
			}
			else
			{
				if (this.MlDcZktYvwj == 0)
				{
					break;
				}
				if (185927 - 64926 == 121001)
				{
					if (Input.GetMouseButton(1))
					{
						if (19996 - 473519 == -453523)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (129232 - 591390 != -462157)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (204027 - 587207 != -383179)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.MlDcZktYvwj));
									if (199295 - 490474 == -291179)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.MlDcZktYvwj = 0;
						if (55562 - 7977 != 47586)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006201 RID: 25089 RVA: 0x00D7AE90 File Offset: 0x00D79090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitChatBar()
	{
		if (264810 - 146066 != 118745)
		{
		}
		for (;;)
		{
			this.x4JcC7AvfxP = string.Empty;
			if (217250 - 365643 != -148392)
			{
				this.r3IcCC3Yj1m = (Texture)Resources.Load("GameGui/Common/TypeField", typeof(Texture));
				if (267275 - 161932 != 105344)
				{
					this.aK1cCM5UZk3 = new GUIStyle();
					if (105111 - 92174 == 12937)
					{
						this.aK1cCM5UZk3.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
						if (171054 - 168251 == 2803)
						{
							this.TokcCfLJTJX = new GUIStyle();
							if (294180 - 487878 == -193698)
							{
								this.TokcCfLJTJX.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
								if (121276 - 515496 == -394220)
								{
									this.RrOcCLynh1M = Chat.TextColor;
									if (118017 - 548088 != -430070)
									{
										this.aancCwf7USN = Chat.SelfColor;
										if (282972 - 149491 == 133481)
										{
											this.sYLcCUSTgs7 = Chat.AllyColor;
											if (66750 - 25727 != 41024)
											{
												this.x3JcCNHhcRJ = Chat.EnemyColor;
												if (21268 - 310352 != -289083)
												{
													this.cu5cCEwPu7G = Chat.NPCColor;
													if (74377 - 66946 != 7432)
													{
														this.qVHcCPbmkrn = Chat.ShadowColor;
														if (116295 - 530170 == -413875)
														{
															this.CbVcCSBKFAy = Chat.SystemColor;
															if (234760 - 158011 != 76750)
															{
																int mGameCode = Game.mGameCode;
																if (264133 - 322709 != -58575)
																{
																	if (mGameCode == 301)
																	{
																		if (214913 - 266662 != -51749)
																		{
																			continue;
																		}
																	}
																	else if (mGameCode == 302)
																	{
																		if (154663 - 40743 == 113921)
																		{
																			continue;
																		}
																	}
																	else if (mGameCode == 303)
																	{
																		if (228447 - 347845 == -119397)
																		{
																			continue;
																		}
																	}
																	else if (mGameCode == 304)
																	{
																		if (95026 - 65597 != 29429)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (mGameCode != 305)
																		{
																			break;
																		}
																		if (130151 - 319068 != -188917)
																		{
																			continue;
																		}
																	}
																	IL_156:
																	this.RrOcCLynh1M = new Color(0.2f, 0.4f, 0.8f, (float)1);
																	if (149477 - 340602 != -191124)
																	{
																		break;
																	}
																	continue;
																	IL_1CA:
																	goto IL_156;
																	IL_21E:
																	goto IL_1CA;
																	goto IL_21E;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006202 RID: 25090 RVA: 0x00D7B218 File Offset: 0x00D79418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderChatBar()
	{
		if (202884 - 393213 != -190329)
		{
		}
		for (;;)
		{
			IL_9DB:
			GUILayout.BeginArea(new Rect(this.OLjcZ8XfItD - (float)1000, (float)200, (float)450, (float)800));
			if (38204 - 323905 != -285700)
			{
				GUILayout.BeginVertical(new GUILayoutOption[0]);
				if (232743 - 97262 != 135482)
				{
					GUILayout.FlexibleSpace();
					if (131632 - 252786 != -121153)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(Chat.ChatDisplay);
						if (252943 - 142945 == 109998)
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								object obj3;
								object obj2 = obj3 = obj;
								if (!(obj2 is ChatEntry))
								{
									obj3 = RuntimeServices.Coerce(obj2, typeof(ChatEntry));
								}
								ChatEntry chatEntry = (ChatEntry)obj3;
								if (248209 - 467214 != -219005)
								{
									goto IL_9DB;
								}
								float num = Mathf.Clamp((float)30 - Time.time + chatEntry.time, (float)0, 1f);
								if (203481 - 35203 == 168279)
								{
									goto IL_9DB;
								}
								UnityRuntimeServices.Update(enumerator, chatEntry);
								if (220911 - 27196 == 193716)
								{
									goto IL_9DB;
								}
								eChatMode mode = chatEntry.mode;
								if (82492 - 553929 == -471436)
								{
									goto IL_9DB;
								}
								UnityRuntimeServices.Update(enumerator, chatEntry);
								if (184469 - 599352 == -414882)
								{
									goto IL_9DB;
								}
								if (mode == eChatMode.area)
								{
									if (205324 - 233877 != -28553)
									{
										goto IL_9DB;
									}
									if (Chat.showAreaChat)
									{
										if (56217 - 108154 == -51936)
										{
											goto IL_9DB;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (248816 - 144638 == 104179)
										{
											goto IL_9DB;
										}
										GUILayout.FlexibleSpace();
										if (178285 - 513724 == -335438)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = this.cu5cCEwPu7G;
										if (109053 - 515955 == -406901)
										{
											goto IL_9DB;
										}
										float a = num;
										if (194762 - 304719 != -109957)
										{
											goto IL_9DB;
										}
										Color textColor = this.TokcCfLJTJX.normal.textColor;
										if (9002 - 122107 == -113104)
										{
											goto IL_9DB;
										}
										float num2 = textColor.a = a;
										if (172680 - 529198 != -356518)
										{
											goto IL_9DB;
										}
										if (167217 - 472084 == -304866)
										{
											goto IL_9DB;
										}
										Color color = this.TokcCfLJTJX.normal.textColor = textColor;
										if (214965 - 421004 == -206038 || 295921 - 126245 == 169677)
										{
											goto IL_9DB;
										}
										GUILayout.Label("[ALL]", this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (269274 - 116259 != 153015)
										{
											goto IL_9DB;
										}
										GUILayout.Space((float)5);
										if (76942 - 363864 != -286922)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = this.aancCwf7USN;
										if (20086 - 46529 == -26442)
										{
											goto IL_9DB;
										}
										float a2 = num;
										if (44523 - 47896 == -3372)
										{
											goto IL_9DB;
										}
										Color textColor2 = this.TokcCfLJTJX.normal.textColor;
										if (53269 - 586666 != -533397)
										{
											goto IL_9DB;
										}
										float num3 = textColor2.a = a2;
										if (236204 - 157197 != 79007)
										{
											goto IL_9DB;
										}
										if (177267 - 84265 != 93002)
										{
											goto IL_9DB;
										}
										Color color2 = this.TokcCfLJTJX.normal.textColor = textColor2;
										if (128099 - 520377 != -392278)
										{
											goto IL_9DB;
										}
										if (267930 - 574287 == -306356)
										{
											goto IL_9DB;
										}
										GUILayout.Label(chatEntry.name + ":", this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (287359 - 5117 == 282243)
										{
											goto IL_9DB;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (134080 - 120221 != 13859)
										{
											goto IL_9DB;
										}
										GUILayout.Space((float)5);
										if (91082 - 255806 == -164723)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = this.RrOcCLynh1M;
										if (93850 - 497914 == -404063)
										{
											goto IL_9DB;
										}
										float a3 = num;
										if (128447 - 343629 != -215182)
										{
											goto IL_9DB;
										}
										Color textColor3 = this.TokcCfLJTJX.normal.textColor;
										if (269814 - 203166 != 66648)
										{
											goto IL_9DB;
										}
										float num4 = textColor3.a = a3;
										if (92805 - 165480 == -72674 || 175957 - 198067 == -22109)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = textColor3;
										if (232128 - 237300 != -5172)
										{
											goto IL_9DB;
										}
										if (128307 - 8760 == 119548)
										{
											goto IL_9DB;
										}
										GUILayout.Label(chatEntry.text, this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (212627 - 114407 != 98220)
										{
											goto IL_9DB;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (3083 - 148099 != -145016)
										{
											goto IL_9DB;
										}
										GUILayout.EndHorizontal();
										if (281939 - 598061 != -316122)
										{
											goto IL_9DB;
										}
									}
								}
								else if (mode == eChatMode.guild)
								{
									if (161560 - 480741 == -319180)
									{
										goto IL_9DB;
									}
									if (Chat.showGuildChat)
									{
										if (96914 - 126991 == -30076)
										{
											goto IL_9DB;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (161395 - 157805 == 3591)
										{
											goto IL_9DB;
										}
										GUILayout.FlexibleSpace();
										if (22129 - 187649 == -165519)
										{
											goto IL_9DB;
										}
										float a4 = num;
										if (132392 - 270707 != -138315)
										{
											goto IL_9DB;
										}
										Color textColor4 = this.TokcCfLJTJX.normal.textColor;
										if (28390 - 386297 != -357907)
										{
											goto IL_9DB;
										}
										textColor4.a = a4;
										if (80466 - 330081 != -249615)
										{
											goto IL_9DB;
										}
										if (271645 - 568471 != -296826)
										{
											goto IL_9DB;
										}
										Color color3 = this.TokcCfLJTJX.normal.textColor = textColor4;
										if (59227 - 436846 != -377619)
										{
											goto IL_9DB;
										}
										if (86512 - 96221 == -9708)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = this.cu5cCEwPu7G;
										if (154977 - 199559 != -44582)
										{
											goto IL_9DB;
										}
										GUILayout.Label("[GLD]", this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (278214 - 345701 == -67486)
										{
											goto IL_9DB;
										}
										GUILayout.Space((float)5);
										if (145397 - 502067 != -356670)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = this.aancCwf7USN;
										if (257689 - 120018 != 137671)
										{
											goto IL_9DB;
										}
										float a5 = num;
										if (72012 - 483161 == -411148)
										{
											goto IL_9DB;
										}
										Color textColor5 = this.TokcCfLJTJX.normal.textColor;
										if (51382 - 331824 == -280441)
										{
											goto IL_9DB;
										}
										textColor5.a = a5;
										if (207092 - 224079 == -16986 || 189604 - 488198 == -298593)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = textColor5;
										if (257143 - 89482 == 167662)
										{
											goto IL_9DB;
										}
										if (115995 - 504447 != -388452)
										{
											goto IL_9DB;
										}
										GUILayout.Label(chatEntry.name + ":", this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (170231 - 110013 != 60218)
										{
											goto IL_9DB;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (228281 - 186233 == 42049)
										{
											goto IL_9DB;
										}
										GUILayout.Space((float)5);
										if (212241 - 41998 != 170243)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = this.RrOcCLynh1M;
										if (190090 - 565467 != -375377)
										{
											goto IL_9DB;
										}
										float a6 = num;
										if (201228 - 392124 != -190896)
										{
											goto IL_9DB;
										}
										Color textColor6 = this.TokcCfLJTJX.normal.textColor;
										if (282488 - 533949 == -251460)
										{
											goto IL_9DB;
										}
										textColor6.a = a6;
										if (235784 - 182517 == 53268 || 199592 - 591074 == -391481)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = textColor6;
										if (64836 - 42525 == 22312 || 228641 - 247473 == -18831)
										{
											goto IL_9DB;
										}
										GUILayout.Label(chatEntry.text, this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (272541 - 576992 == -304450)
										{
											goto IL_9DB;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (153264 - 542154 == -388889)
										{
											goto IL_9DB;
										}
										GUILayout.EndHorizontal();
										if (232421 - 31522 == 200900)
										{
											goto IL_9DB;
										}
									}
								}
								else if (mode == eChatMode.whisper)
								{
									if (70561 - 191770 == -121208)
									{
										goto IL_9DB;
									}
									if (Chat.showPrivateChat)
									{
										if (187817 - 107938 != 79879)
										{
											goto IL_9DB;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (21110 - 358038 != -336928)
										{
											goto IL_9DB;
										}
										GUILayout.FlexibleSpace();
										if (149047 - 262733 != -113686)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = new Color(0.69f, 0.29f, 0.53f, num);
										if (145982 - 292010 != -146028)
										{
											goto IL_9DB;
										}
										GUILayout.Label("[WSP]", this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (113307 - 333967 != -220660)
										{
											goto IL_9DB;
										}
										GUILayout.Space((float)5);
										if (70285 - 509778 == -439492)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = this.aancCwf7USN;
										if (296094 - 53290 != 242804)
										{
											goto IL_9DB;
										}
										float a7 = num;
										if (263538 - 174904 != 88634)
										{
											goto IL_9DB;
										}
										Color textColor7 = this.TokcCfLJTJX.normal.textColor;
										if (186481 - 244084 != -57603)
										{
											goto IL_9DB;
										}
										float num5 = textColor7.a = a7;
										if (93496 - 518055 == -424558)
										{
											goto IL_9DB;
										}
										if (28245 - 45703 != -17458)
										{
											goto IL_9DB;
										}
										Color color4 = this.TokcCfLJTJX.normal.textColor = textColor7;
										if (10364 - 455253 != -444889)
										{
											goto IL_9DB;
										}
										if (260369 - 55219 == 205151)
										{
											goto IL_9DB;
										}
										GUILayout.Label(chatEntry.name + ":", this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (227746 - 245299 == -17552)
										{
											goto IL_9DB;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (107085 - 91849 == 15237)
										{
											goto IL_9DB;
										}
										GUILayout.Space((float)5);
										if (174829 - 462376 == -287546)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = this.RrOcCLynh1M;
										if (177387 - 305353 == -127965)
										{
											goto IL_9DB;
										}
										float a8 = num;
										if (222771 - 520625 == -297853)
										{
											goto IL_9DB;
										}
										Color textColor8 = this.TokcCfLJTJX.normal.textColor;
										if (132125 - 15323 == 116803)
										{
											goto IL_9DB;
										}
										float num6 = textColor8.a = a8;
										if (52426 - 389559 != -337133)
										{
											goto IL_9DB;
										}
										if (227833 - 22429 != 205404)
										{
											goto IL_9DB;
										}
										this.TokcCfLJTJX.normal.textColor = textColor8;
										if (159934 - 66782 == 93153)
										{
											goto IL_9DB;
										}
										if (237747 - 338782 != -101035)
										{
											goto IL_9DB;
										}
										GUILayout.Label(chatEntry.text, this.TokcCfLJTJX, new GUILayoutOption[0]);
										if (82275 - 326035 == -243759)
										{
											goto IL_9DB;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (133640 - 374299 == -240658)
										{
											goto IL_9DB;
										}
										GUILayout.EndHorizontal();
										if (26609 - 123784 != -97175)
										{
											goto IL_9DB;
										}
									}
								}
								else if (mode == eChatMode.system)
								{
									if (198030 - 57235 == 140796)
									{
										goto IL_9DB;
									}
									if (Chat.showSystemChat)
									{
										if (23776 - 223266 != -199490)
										{
											goto IL_9DB;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (126612 - 97395 == 29218)
										{
											goto IL_9DB;
										}
										GUILayout.FlexibleSpace();
										if (151245 - 440334 == -289088)
										{
											goto IL_9DB;
										}
										eChatType type = chatEntry.type;
										if (90055 - 182139 != -92084)
										{
											goto IL_9DB;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (187221 - 48353 != 138868)
										{
											goto IL_9DB;
										}
										if (type == eChatType.system)
										{
											if (57723 - 430458 != -372735)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.CbVcCSBKFAy;
											if (266001 - 517818 != -251817)
											{
												goto IL_9DB;
											}
											float a9 = num;
											if (81149 - 150954 == -69804)
											{
												goto IL_9DB;
											}
											Color textColor9 = this.TokcCfLJTJX.normal.textColor;
											if (51861 - 345754 != -293893)
											{
												goto IL_9DB;
											}
											textColor9.a = a9;
											if (35960 - 135721 != -99761)
											{
												goto IL_9DB;
											}
											if (240238 - 411961 != -171723)
											{
												goto IL_9DB;
											}
											Color color5 = this.TokcCfLJTJX.normal.textColor = textColor9;
											if (43414 - 558812 != -515398)
											{
												goto IL_9DB;
											}
											if (183384 - 508422 == -325037)
											{
												goto IL_9DB;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (193902 - 520697 == -326794)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (34262 - 29620 == 4643)
											{
												goto IL_9DB;
											}
										}
										else if (type == eChatType.self)
										{
											if (199835 - 196481 != 3354)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.aancCwf7USN;
											if (48649 - 426412 == -377762)
											{
												goto IL_9DB;
											}
											float a10 = num;
											if (3087 - 127188 == -124100)
											{
												goto IL_9DB;
											}
											Color textColor10 = this.TokcCfLJTJX.normal.textColor;
											if (71461 - 104637 != -33176)
											{
												goto IL_9DB;
											}
											textColor10.a = a10;
											if (186012 - 272827 == -86814 || 265025 - 385102 == -120076)
											{
												goto IL_9DB;
											}
											Color color6 = this.TokcCfLJTJX.normal.textColor = textColor10;
											if (262157 - 7417 != 254740)
											{
												goto IL_9DB;
											}
											if (183718 - 552227 != -368509)
											{
												goto IL_9DB;
											}
											GUILayout.Label(chatEntry.name + ":", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (154289 - 115019 != 39270)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (133317 - 439523 == -306205)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.RrOcCLynh1M;
											if (201614 - 452012 == -250397)
											{
												goto IL_9DB;
											}
											float a11 = num;
											if (206501 - 166078 == 40424)
											{
												goto IL_9DB;
											}
											Color textColor11 = this.TokcCfLJTJX.normal.textColor;
											if (126749 - 252759 == -126009)
											{
												goto IL_9DB;
											}
											float num7 = textColor11.a = a11;
											if (137932 - 224681 != -86749)
											{
												goto IL_9DB;
											}
											if (49573 - 456960 != -407387)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = textColor11;
											if (61113 - 269336 == -208222 || 98151 - 201221 == -103069)
											{
												goto IL_9DB;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (279299 - 429352 == -150052)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (38275 - 225901 == -187625)
											{
												goto IL_9DB;
											}
										}
										else if (type == eChatType.ally)
										{
											if (191667 - 472964 == -281296)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.sYLcCUSTgs7;
											if (252582 - 18093 != 234489)
											{
												goto IL_9DB;
											}
											float a12 = num;
											if (198274 - 124160 != 74114)
											{
												goto IL_9DB;
											}
											Color textColor12 = this.TokcCfLJTJX.normal.textColor;
											if (230153 - 529938 != -299785)
											{
												goto IL_9DB;
											}
											float num8 = textColor12.a = a12;
											if (246359 - 135146 == 111214 || 50958 - 128441 == -77482)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = textColor12;
											if (282027 - 136957 == 145071 || 204314 - 42180 == 162135)
											{
												goto IL_9DB;
											}
											GUILayout.Label(chatEntry.name + ":", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (156968 - 532389 == -375420)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (73609 - 94109 == -20499)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.RrOcCLynh1M;
											if (247138 - 261420 != -14282)
											{
												goto IL_9DB;
											}
											float a13 = num;
											if (1573 - 565814 == -564240)
											{
												goto IL_9DB;
											}
											Color textColor13 = this.TokcCfLJTJX.normal.textColor;
											if (81676 - 582597 != -500921)
											{
												goto IL_9DB;
											}
											textColor13.a = a13;
											if (10650 - 508276 == -497625)
											{
												goto IL_9DB;
											}
											if (112795 - 518097 != -405302)
											{
												goto IL_9DB;
											}
											Color color7 = this.TokcCfLJTJX.normal.textColor = textColor13;
											if (96440 - 127349 != -30909)
											{
												goto IL_9DB;
											}
											if (278060 - 533721 != -255661)
											{
												goto IL_9DB;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (131726 - 384669 == -252942)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (75405 - 265544 != -190139)
											{
												goto IL_9DB;
											}
										}
										else if (type == eChatType.enemy)
										{
											if (247723 - 205427 != 42296)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.x3JcCNHhcRJ;
											if (229515 - 116237 == 113279)
											{
												goto IL_9DB;
											}
											float a14 = num;
											if (71670 - 100702 == -29031)
											{
												goto IL_9DB;
											}
											Color textColor14 = this.TokcCfLJTJX.normal.textColor;
											if (26737 - 261012 != -234275)
											{
												goto IL_9DB;
											}
											textColor14.a = a14;
											if (216148 - 96962 != 119186)
											{
												goto IL_9DB;
											}
											if (33142 - 129696 != -96554)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = textColor14;
											if (24282 - 172755 != -148473)
											{
												goto IL_9DB;
											}
											if (83350 - 353967 != -270617)
											{
												goto IL_9DB;
											}
											GUILayout.Label(chatEntry.name + ":", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (226416 - 316844 == -90427)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (274362 - 301448 == -27085)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.RrOcCLynh1M;
											if (69766 - 98467 == -28700)
											{
												goto IL_9DB;
											}
											float a15 = num;
											if (78430 - 143276 == -64845)
											{
												goto IL_9DB;
											}
											Color textColor15 = this.TokcCfLJTJX.normal.textColor;
											if (33536 - 123247 == -89710)
											{
												goto IL_9DB;
											}
											textColor15.a = a15;
											if (48291 - 459927 == -411635 || 107979 - 521897 == -413917)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = textColor15;
											if (229256 - 444307 != -215051)
											{
												goto IL_9DB;
											}
											if (37242 - 496757 == -459514)
											{
												goto IL_9DB;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (64876 - 53949 != 10927)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (149672 - 399602 == -249929)
											{
												goto IL_9DB;
											}
										}
										else if (type == eChatType.npc)
										{
											if (203082 - 54678 != 148404)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.cu5cCEwPu7G;
											if (229628 - 36050 == 193579)
											{
												goto IL_9DB;
											}
											float a16 = num;
											if (162939 - 490057 != -327118)
											{
												goto IL_9DB;
											}
											Color textColor16 = this.TokcCfLJTJX.normal.textColor;
											if (223163 - 225213 != -2050)
											{
												goto IL_9DB;
											}
											float num9 = textColor16.a = a16;
											if (267428 - 108455 == 158974)
											{
												goto IL_9DB;
											}
											if (175696 - 500098 != -324402)
											{
												goto IL_9DB;
											}
											Color color8 = this.TokcCfLJTJX.normal.textColor = textColor16;
											if (174094 - 253176 != -79082)
											{
												goto IL_9DB;
											}
											if (206196 - 168708 != 37488)
											{
												goto IL_9DB;
											}
											GUILayout.Label(chatEntry.name + ":", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (211329 - 435850 == -224520)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (28943 - 2353 == 26591)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = this.RrOcCLynh1M;
											if (220443 - 119850 == 100594)
											{
												goto IL_9DB;
											}
											float a17 = num;
											if (159399 - 487721 == -328321)
											{
												goto IL_9DB;
											}
											Color textColor17 = this.TokcCfLJTJX.normal.textColor;
											if (114147 - 455367 != -341220)
											{
												goto IL_9DB;
											}
											textColor17.a = a17;
											if (260862 - 304651 != -43789)
											{
												goto IL_9DB;
											}
											if (89840 - 156288 == -66447)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = textColor17;
											if (43328 - 91950 == -48621 || 73305 - 490276 == -416970)
											{
												goto IL_9DB;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (150609 - 493466 == -342856)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (187529 - 23757 == 163773)
											{
												goto IL_9DB;
											}
										}
										else if (type == eChatType.world)
										{
											if (145348 - 547786 != -402438)
											{
												goto IL_9DB;
											}
											this.TokcCfLJTJX.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
											if (286817 - 430163 != -143346)
											{
												goto IL_9DB;
											}
											GUILayout.Label(chatEntry.text, this.TokcCfLJTJX, new GUILayoutOption[0]);
											if (246882 - 92528 != 154354)
											{
												goto IL_9DB;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (182229 - 103119 != 79110)
											{
												goto IL_9DB;
											}
										}
										GUILayout.EndHorizontal();
										if (138555 - 548384 != -409829)
										{
											goto IL_9DB;
										}
									}
								}
								else if (mode == eChatMode.world)
								{
									if (57651 - 360734 == -303082)
									{
										goto IL_9DB;
									}
									GUILayout.BeginHorizontal(new GUILayoutOption[0]);
									if (237869 - 250723 != -12854)
									{
										goto IL_9DB;
									}
									GUILayout.FlexibleSpace();
									if (272284 - 583098 != -310814)
									{
										goto IL_9DB;
									}
									this.TokcCfLJTJX.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
									if (74354 - 62255 == 12100)
									{
										goto IL_9DB;
									}
									GUILayout.Label(chatEntry.text, this.TokcCfLJTJX, new GUILayoutOption[0]);
									if (171335 - 137123 != 34212)
									{
										goto IL_9DB;
									}
									UnityRuntimeServices.Update(enumerator, chatEntry);
									if (247766 - 539171 == -291404)
									{
										goto IL_9DB;
									}
									GUILayout.EndHorizontal();
									if (55181 - 354115 != -298934)
									{
										goto IL_9DB;
									}
								}
							}
							if (173418 - 36879 != 136540)
							{
								GUILayout.EndVertical();
								if (175081 - 507346 != -332264)
								{
									GUILayout.EndArea();
									if (213747 - 64836 != 148912)
									{
										if (!Chat.ChatActive)
										{
											break;
										}
										if (112781 - 585137 != -472355)
										{
											bool flag = true;
											if (257175 - 187664 == 69511)
											{
												GUI.DrawTexture(new Rect(0.5f * this.OLjcZ8XfItD - (float)357, (float)700, (float)335, (float)33), this.r3IcCC3Yj1m);
												if (67284 - 159969 == -92685)
												{
													if (Input.GetKeyDown(KeyCode.UpArrow))
													{
														if (209014 - 520574 == -311560)
														{
															this.x4JcC7AvfxP = this.XLjcCZ4HUBQ;
															if (180701 - 468938 == -288237)
															{
																break;
															}
														}
													}
													else if (Input.GetKeyDown(KeyCode.DownArrow))
													{
														if (295402 - 563587 == -268185)
														{
															this.x4JcC7AvfxP = string.Empty;
															if (145274 - 61405 == 83869)
															{
																break;
															}
														}
													}
													else
													{
														if (Event.current.type == EventType.KeyDown)
														{
															if (297901 - 137022 == 160880)
															{
																continue;
															}
															if (Event.current.character == "\n")
															{
																if (67577 - 251567 != -183990)
																{
																	continue;
																}
																string[] array = (string[])Stringf.splitToArray(this.x4JcC7AvfxP, " ").ToBuiltin(typeof(string));
																if (171997 - 582160 != -410163)
																{
																	continue;
																}
																if (Extensions.get_length(array) > 0)
																{
																	if (193418 - 66370 == 127049)
																	{
																		continue;
																	}
																	string a18 = array[0];
																	if (47250 - 551062 != -503812)
																	{
																		continue;
																	}
																	if (a18 == "/a")
																	{
																		if (174607 - 106361 == 68247)
																		{
																			continue;
																		}
																		Chat.ChatMode = 1;
																		if (205544 - 465416 == -259871)
																		{
																			continue;
																		}
																		this.x4JcC7AvfxP = Stringf.getString(this.x4JcC7AvfxP, 2, Extensions.get_length(this.x4JcC7AvfxP));
																		if (201895 - 106229 != 95666)
																		{
																			continue;
																		}
																	}
																	else if (a18 == "/g")
																	{
																		if (165539 - 240465 == -74925)
																		{
																			continue;
																		}
																		if (!RuntimeServices.EqualityOperator(PlayerData.GID, "none"))
																		{
																			if (82508 - 521069 != -438561)
																			{
																				continue;
																			}
																			Chat.ChatMode = 2;
																			if (177881 - 339490 == -161608)
																			{
																				continue;
																			}
																			this.x4JcC7AvfxP = Stringf.getString(this.x4JcC7AvfxP, 2, Extensions.get_length(this.x4JcC7AvfxP));
																			if (77902 - 302024 != -224122)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.newMallNotice("You are not in a guild");
																			if (98759 - 468320 != -369561)
																			{
																				continue;
																			}
																			flag = false;
																			if (182032 - 594088 != -412056)
																			{
																				continue;
																			}
																		}
																	}
																	else if (a18 == "/p")
																	{
																		if (286098 - 458985 != -172887)
																		{
																			continue;
																		}
																		if (Game.mGameType <= 4)
																		{
																			if (7632 - 552204 != -544572)
																			{
																				continue;
																			}
																			Chat.ChatMode = 3;
																			if (88897 - 204562 != -115665)
																			{
																				continue;
																			}
																			this.x4JcC7AvfxP = Stringf.getString(this.x4JcC7AvfxP, 2, Extensions.get_length(this.x4JcC7AvfxP));
																			if (89336 - 508760 == -419423)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.newMallNotice("Cannot use party chat");
																			if (34412 - 334533 != -300121)
																			{
																				continue;
																			}
																			this.x4JcC7AvfxP = string.Empty;
																			if (166924 - 282888 != -115964)
																			{
																				continue;
																			}
																		}
																	}
																	else if (a18 == "/w")
																	{
																		if (205033 - 395584 == -190550)
																		{
																			continue;
																		}
																		Chat.ChatMode = 4;
																		if (62079 - 100016 == -37936)
																		{
																			continue;
																		}
																		this.x4JcC7AvfxP = Stringf.getString(this.x4JcC7AvfxP, 3, Extensions.get_length(this.x4JcC7AvfxP));
																		if (37863 - 523916 != -486053)
																		{
																			continue;
																		}
																		if (Extensions.get_length(array) > 1)
																		{
																			if (194770 - 590945 != -396175)
																			{
																				continue;
																			}
																			int buddyID = PlayerData.getBuddyID(array[1]);
																			if (76341 - 162028 == -85686)
																			{
																				continue;
																			}
																			if (buddyID != 0)
																			{
																				if (118653 - 32727 != 85926)
																				{
																					continue;
																				}
																				Chat.TargetID = buddyID;
																				if (95743 - 124220 == -28476)
																				{
																					continue;
																				}
																				this.x4JcC7AvfxP = Stringf.getString(this.x4JcC7AvfxP, Extensions.get_length(array[1]) + 1, Extensions.get_length(this.x4JcC7AvfxP));
																				if (117119 - 409726 != -292607)
																				{
																					continue;
																				}
																			}
																		}
																	}
																	else if (a18 == "/world")
																	{
																		if (289833 - 69541 != 220292)
																		{
																			continue;
																		}
																		if (PlayerData.Rank >= 90)
																		{
																			if (180050 - 578149 == -398098)
																			{
																				continue;
																			}
																			this.x4JcC7AvfxP = Stringf.getString(this.x4JcC7AvfxP, 7, Extensions.get_length(this.x4JcC7AvfxP));
																			if (265814 - 221643 != 44171)
																			{
																				continue;
																			}
																			Chat.SubmitChat(PlayerData.User, this.x4JcC7AvfxP, eChatType.world, eChatMode.world);
																			if (269312 - 357542 != -88230)
																			{
																				continue;
																			}
																			this.x4JcC7AvfxP = string.Empty;
																			if (171227 - 574116 == -402888)
																			{
																				continue;
																			}
																			Chat.ChatTimeOut = Time.time + 0.5f;
																			if (230113 - 440781 == -210667)
																			{
																				continue;
																			}
																			Chat.ChatActive = false;
																			if (288165 - 510550 != -222385)
																			{
																				continue;
																			}
																			break;
																		}
																		else
																		{
																			this.newMallNotice("Only GM can use world chat");
																			if (24089 - 502855 != -478766)
																			{
																				continue;
																			}
																			flag = false;
																			if (216073 - 510431 != -294358)
																			{
																				continue;
																			}
																		}
																	}
																}
																if (flag)
																{
																	if (289942 - 150120 == 139823)
																	{
																		continue;
																	}
																	if (this.x4JcC7AvfxP.Length > 0)
																	{
																		if (245665 - 267092 != -21427)
																		{
																			continue;
																		}
																		if (Chat.ChatMode == 4)
																		{
																			if (93894 - 344977 == -251082)
																			{
																				continue;
																			}
																			if (Chat.TargetID == 0)
																			{
																				if (82066 - 551785 == -469718)
																				{
																					continue;
																				}
																				this.newMallNotice("Whisper target not found!");
																				if (264172 - 357194 != -93022)
																				{
																					continue;
																				}
																				goto IL_436;
																			}
																		}
																		Chat.SubmitChat(PlayerData.User, this.x4JcC7AvfxP, eChatType.self, (eChatMode)Chat.ChatMode);
																		if (283692 - 285928 == -2235)
																		{
																			continue;
																		}
																	}
																}
																IL_436:
																this.XLjcCZ4HUBQ = this.x4JcC7AvfxP;
																if (101657 - 20230 != 81427)
																{
																	continue;
																}
																this.x4JcC7AvfxP = string.Empty;
																if (255129 - 271958 != -16829)
																{
																	continue;
																}
																Chat.ChatTimeOut = Time.time + 0.5f;
																if (126496 - 69693 == 56804)
																{
																	continue;
																}
																Chat.ChatActive = false;
																if (149710 - 357824 != -208113)
																{
																	break;
																}
																continue;
															}
														}
														GUI.SetNextControlName("MallChatField");
														if (209585 - 475761 != -266175)
														{
															this.x4JcC7AvfxP = GUI.TextField(new Rect(0.5f * this.OLjcZ8XfItD - (float)350, (float)700, (float)300, (float)30), this.x4JcC7AvfxP, 36, this.aK1cCM5UZk3);
															if (31803 - 253886 != -222082)
															{
																GUI.FocusControl("MallChatField");
																if (33442 - 64546 != -31103)
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

	// Token: 0x06006203 RID: 25091 RVA: 0x00D7DC40 File Offset: 0x00D7BE40
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitNoticeBar()
	{
		if (203650 - 462224 != -258574)
		{
		}
		for (;;)
		{
			this.r4QcCBdXGxj = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (65975 - 497159 != -431183)
			{
				this.tLdcC0PLftv = new GUIStyle();
				if (34515 - 151424 == -116909)
				{
					this.tLdcC0PLftv.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (291216 - 162972 != 128245)
					{
						this.tLdcC0PLftv.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (214089 - 163088 == 51001)
						{
							this.tLdcC0PLftv.alignment = TextAnchor.MiddleCenter;
							if (62307 - 15448 != 46860)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006204 RID: 25092 RVA: 0x00D7DD7C File Offset: 0x00D7BF7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void newNoticeBar(string s, float t)
	{
		this.QVHcCirB1jL = s;
		this.Er0cC8s2s3d = Time.time + t;
	}

	// Token: 0x06006205 RID: 25093 RVA: 0x00D7DD94 File Offset: 0x00D7BF94
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderNoticeBar()
	{
		if (293051 - 587163 != -294112)
		{
		}
		while (this.Er0cC8s2s3d > Time.time)
		{
			if (213763 - 519634 == -305871)
			{
				GUI.DrawTexture(new Rect((float)60, (float)480, (float)475, (float)102), this.r4QcCBdXGxj);
				if (70404 - 450959 != -380554)
				{
					GUI.Label(new Rect((float)95, (float)510, (float)400, (float)40), this.QVHcCirB1jL, this.tLdcC0PLftv);
					if (54040 - 418222 == -364182)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006206 RID: 25094 RVA: 0x00D7DE74 File Offset: 0x00D7C074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMallNotice()
	{
		if (138580 - 301361 != -162780)
		{
		}
		for (;;)
		{
			this.WERcCjrQUpx = new GUIStyle();
			if (280521 - 342562 == -62041)
			{
				this.WERcCjrQUpx.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
				if (250489 - 142676 == 107813)
				{
					this.WERcCjrQUpx.normal.textColor = new Color(0.8f, 0.2f, 0.1f, 0.8f);
					if (71832 - 551553 == -479721)
					{
						this.WERcCjrQUpx.alignment = TextAnchor.MiddleCenter;
						if (2424 - 222366 == -219942)
						{
							this.P5gcCoeEbCm = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
							if (134807 - 594488 != -459680)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006207 RID: 25095 RVA: 0x00D7DFB4 File Offset: 0x00D7C1B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMallMessege()
	{
		if (54136 - 522236 != -468099)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (41338 - 374244 == -332906)
				{
					break;
				}
			}
			else
			{
				if (this.D7wcCmO6dLJ + (float)2 <= Time.time)
				{
					break;
				}
				if (42860 - 118392 == -75532)
				{
					GUI.Label(new Rect(0.5f * (this.OLjcZ8XfItD - (float)400), (float)260, (float)500, (float)40), this.B54cCDhJf5G, this.WERcCjrQUpx);
					if (290268 - 177161 == 113107)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006208 RID: 25096 RVA: 0x00D7E09C File Offset: 0x00D7C29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newMallNotice(string Message)
	{
		this.B54cCDhJf5G = Message;
		this.D7wcCmO6dLJ = Time.time;
	}

	// Token: 0x06006209 RID: 25097 RVA: 0x00D7E0B0 File Offset: 0x00D7C2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isInventoryEmpty()
	{
		if (160792 - 499270 != -338477)
		{
		}
		bool result;
		for (;;)
		{
			IL_1A:
			result = true;
			if (69919 - 72359 == -2440)
			{
				int i = 0;
				if (276181 - 303433 == -27252)
				{
					while (i < 8)
					{
						if (this.qWxcCrOFW5q[i].slot > -1)
						{
							if (209983 - 146388 == 63596)
							{
								goto IL_1A;
							}
							result = false;
							if (120385 - 397533 == -277147)
							{
								goto IL_1A;
							}
						}
						i++;
						if (278443 - 221029 == 57415)
						{
							goto IL_1A;
						}
					}
					if (135353 - 170192 != -34838)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600620A RID: 25098 RVA: 0x00D7E1B0 File Offset: 0x00D7C3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isPriceZero()
	{
		if (50915 - 9811 != 41104)
		{
		}
		bool result;
		for (;;)
		{
			IL_C3:
			result = false;
			if (164973 - 119280 == 45693)
			{
				int i = 0;
				if (117203 - 488179 != -370975)
				{
					while (i < 8)
					{
						if (this.qWxcCrOFW5q[i].slot > -1)
						{
							if (160084 - 577513 != -417429)
							{
								goto IL_C3;
							}
							if (this.zBFcCxk3Ih4[i] <= 0)
							{
								if (298742 - 375024 == -76281)
								{
									goto IL_C3;
								}
								result = true;
								if (262721 - 273410 == -10688)
								{
									goto IL_C3;
								}
							}
						}
						i++;
						if (144321 - 60006 != 84315)
						{
							goto IL_C3;
						}
					}
					if (255768 - 368057 != -112288)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600620B RID: 25099 RVA: 0x00D7E2D8 File Offset: 0x00D7C4D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int[] writeMallInventory()
	{
		if (123327 - 186849 != -63522)
		{
		}
		int[] array;
		for (;;)
		{
			IL_1A:
			array = new int[8];
			if (6937 - 318681 == -311744)
			{
				int i = 0;
				if (8318 - 224869 != -216550)
				{
					while (i < 8)
					{
						array[i] = this.qWxcCrOFW5q[i].slot;
						if (22899 - 523663 == -500763)
						{
							goto IL_1A;
						}
						i++;
						if (286335 - 425719 == -139383)
						{
							goto IL_1A;
						}
					}
					if (96097 - 39427 != 56671)
					{
						break;
					}
				}
			}
		}
		return array;
	}

	// Token: 0x0600620C RID: 25100 RVA: 0x00D7E3BC File Offset: 0x00D7C5BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readMallInventory(string nInventoryList)
	{
		if (269475 - 585661 != -316186)
		{
		}
		for (;;)
		{
			IL_B7:
			this.ResetMallMenu();
			if (136445 - 34745 == 101700)
			{
				if (nInventoryList == "0")
				{
					if (152898 - 336397 == -183499)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.splitToArray(nInventoryList, ",").ToBuiltin(typeof(string));
					if (145746 - 129741 != 16006)
					{
						if (array.Length == 8)
						{
							if (169588 - 63791 == 105797)
							{
								int i = 0;
								if (248557 - 591603 == -343046)
								{
									while (i < 8)
									{
										if (array[i] != "0")
										{
											if (280516 - 552315 == -271798)
											{
												goto IL_B7;
											}
											this.qWxcCrOFW5q[i].readData(array[i]);
											if (143967 - 248239 == -104271)
											{
												goto IL_B7;
											}
											this.sqlcCRvX8LR[i] = ItemData.getItemData(this.qWxcCrOFW5q[i].name);
											if (79328 - 546248 != -466920)
											{
												goto IL_B7;
											}
											this.xdHcCT7I2uX[i].name = this.qWxcCrOFW5q[i].name;
											if (46177 - 547616 != -501439)
											{
												goto IL_B7;
											}
											this.xdHcCT7I2uX[i].command = i;
											if (142311 - 233980 != -91669)
											{
												goto IL_B7;
											}
											this.xdHcCT7I2uX[i].image = (Texture2D)IconButton.getIconImage(this.qWxcCrOFW5q[i].name);
											if (3306 - 596269 != -592963)
											{
												goto IL_B7;
											}
										}
										i++;
										if (146414 - 555035 == -408620)
										{
											goto IL_B7;
										}
									}
									if (274657 - 38614 != 236044)
									{
										break;
									}
								}
							}
						}
						else
						{
							Debug.LogError("Mall Inventory Error");
							if (116088 - 278736 != -162647)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600620D RID: 25101 RVA: 0x00D7E650 File Offset: 0x00D7C850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MallSellOperation(int nOperation)
	{
		if (243386 - 296467 != -53081)
		{
		}
		for (;;)
		{
			Debug.Log("MallSellOperation: " + nOperation);
			if (254333 - 344115 != -89781)
			{
				Hashtable hashtable = new Hashtable();
				if (295771 - 64144 != 231628)
				{
					hashtable.Add(43, PlayerData.UID);
					if (144471 - 389852 != -245380)
					{
						hashtable.Add(21, PhotonClient.cInt16(nOperation));
						if (252167 - 561443 != -309275)
						{
							hashtable.Add(22, this.mMallName);
							if (187062 - 149043 == 38019)
							{
								hashtable.Add(23, this.writeMallInventory());
								if (224453 - 83570 == 140883)
								{
									hashtable.Add(24, this.zBFcCxk3Ih4);
									if (156160 - 297731 == -141571)
									{
										PhotonClient.Connection.OpCustom(243, hashtable, true);
										if (26538 - 366246 != -339707)
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

	// Token: 0x0600620E RID: 25102 RVA: 0x00D7E7F0 File Offset: 0x00D7C9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMallSellOperation(Hashtable data)
	{
		if (105471 - 413587 != -308115)
		{
		}
		for (;;)
		{
			Debug.Log("OnMallSellOperation: " + data[21]);
			if (155650 - 514793 != -359142)
			{
				if (!this.mSeller)
				{
					if (164613 - 363776 == -199163)
					{
						break;
					}
				}
				else if (!this.mSellerChar)
				{
					if (238144 - 312358 != -74213)
					{
						break;
					}
				}
				else if (!this.mSellerChar.isMine)
				{
					if (265341 - 347170 == -81829)
					{
						break;
					}
				}
				else
				{
					if (this.mSellerChar.myCommand != "mallSetup")
					{
						if (82394 - 452076 == -369681)
						{
							continue;
						}
						if (this.mSellerChar.myCommand != "mallOpen")
						{
							if (101232 - 248459 != -147226)
							{
								break;
							}
							continue;
						}
					}
					Rabbit rabbit = (Rabbit)this.mSeller.GetComponent(typeof(Rabbit));
					if (298591 - 438467 == -139876)
					{
						if (!rabbit)
						{
							if (289637 - 248945 == 40692)
							{
								break;
							}
						}
						else
						{
							object lhs = data[21];
							if (92890 - 581270 != -488379)
							{
								if (RuntimeServices.EqualityOperator(lhs, 0))
								{
									if (183680 - 563056 != -379375)
									{
										if (RuntimeServices.EqualityOperator(data[31], 1))
										{
											if (199770 - 512041 != -312270)
											{
												rabbit.RPC_mall_setup(this.mSeller.transform.position, this.mSeller.transform.forward, this.mSellerChar.ActorNr);
												if (217709 - 505823 == -288114)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (142996 - 584439 == -441443)
													{
														rabbit.ActionEvent("RPC_mall_setup", this.mSeller.transform.position, this.mSeller.transform.forward, this.mSellerChar.ActorNr);
														if (293563 - 415219 == -121656)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.newNoticeBar("Mall Setup Error", (float)2);
											if (192668 - 183188 == 9480)
											{
												break;
											}
										}
									}
								}
								else if (RuntimeServices.EqualityOperator(lhs, 1))
								{
									if (101463 - 437463 == -336000)
									{
										if (RuntimeServices.EqualityOperator(data[31], 1))
										{
											if (22304 - 555370 == -533066)
											{
												rabbit.StartCoroutine_Auto(rabbit.RPC_mall_open(this.mSeller.transform.position, this.mSeller.transform.forward, this.mSellerChar.ActorNr));
												if (269335 - 419217 != -149881)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (27447 - 211117 == -183670)
													{
														rabbit.ActionEvent("RPC_mall_open", this.mSeller.transform.position, this.mSeller.transform.forward, this.mSellerChar.ActorNr);
														if (269515 - 404474 != -134958)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.newNoticeBar("Mall Open Error", (float)2);
											if (151095 - 318620 != -167524)
											{
												this.mType = eMallType.setup;
												if (52106 - 503147 == -451041)
												{
													this.aKxcZ0Pwmdb = Time.time;
													if (113118 - 587646 == -474528)
													{
														break;
													}
												}
											}
										}
									}
								}
								else
								{
									if (!RuntimeServices.EqualityOperator(lhs, 2))
									{
										break;
									}
									if (87093 - 44782 != 42312)
									{
										rabbit.RPC_mall_close(this.mSeller.transform.position, this.mSeller.transform.forward, this.mSellerChar.ActorNr);
										if (261017 - 63495 != 197523)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (146794 - 157168 == -10374)
											{
												rabbit.ActionEvent("RPC_mall_close", this.mSeller.transform.position, this.mSeller.transform.forward, this.mSellerChar.ActorNr);
												if (289803 - 347652 == -57849)
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

	// Token: 0x0600620F RID: 25103 RVA: 0x00D7EDC0 File Offset: 0x00D7CFC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onMallSellEvent(Hashtable data)
	{
		return new MallGui.$onMallSellEvent$36322(data, this).GetEnumerator();
	}

	// Token: 0x06006210 RID: 25104 RVA: 0x00D7EDD0 File Offset: 0x00D7CFD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MallBuyOperation(int nOperation, int nItemSlot, int nQuanity, int nPrice)
	{
		if (174375 - 336768 != -162392)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (181609 - 243906 != -62296)
			{
				hashtable.Add(43, PlayerData.UID);
				if (192824 - 576799 != -383974)
				{
					hashtable.Add(21, PhotonClient.cInt16(nOperation));
					if (244014 - 105850 != 138165)
					{
						hashtable.Add(22, this.mSellerID);
						if (129245 - 263502 != -134256)
						{
							hashtable.Add(23, PhotonClient.cInt16(nItemSlot));
							if (253208 - 542473 != -289264)
							{
								hashtable.Add(24, PhotonClient.cInt16(nQuanity));
								if (19555 - 209941 == -190386)
								{
									hashtable.Add(25, nPrice);
									if (86695 - 90382 != -3686)
									{
										PhotonClient.Connection.OpCustom(244, hashtable, true);
										if (162455 - 48079 == 114376)
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

	// Token: 0x06006211 RID: 25105 RVA: 0x00D7EF80 File Offset: 0x00D7D180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onMallBuyOperation(Hashtable data)
	{
		return new MallGui.$onMallBuyOperation$36327(data, this).GetEnumerator();
	}

	// Token: 0x06006212 RID: 25106 RVA: 0x00D7EF90 File Offset: 0x00D7D190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMallBuyEvent(Hashtable data)
	{
		if (113833 - 350901 != -237067)
		{
		}
		for (;;)
		{
			Debug.Log("OnMallBuyEvent");
			if (63487 - 178814 == -115327)
			{
				if (!this.mSeller)
				{
					if (90243 - 44646 != 45598)
					{
						break;
					}
				}
				else if (!this.mSellerChar)
				{
					if (106843 - 15961 != 90883)
					{
						break;
					}
				}
				else if (this.mSellerChar.isMine)
				{
					if (77494 - 290055 != -212560)
					{
						break;
					}
				}
				else
				{
					if (this.mSellerChar.myCommand != "mallSetup")
					{
						if (151130 - 462192 == -311061)
						{
							continue;
						}
						if (this.mSellerChar.myCommand != "mallOpen")
						{
							if (37404 - 98047 != -60643)
							{
								continue;
							}
							break;
						}
					}
					if (!RuntimeServices.EqualityOperator(data[31], null))
					{
						if (134754 - 122456 == 12299)
						{
							continue;
						}
						string nChatName = "system";
						object obj2;
						object obj = obj2 = data[31];
						if (!(obj is string))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string));
						}
						Chat.SubmitChat(nChatName, (string)obj2, eChatType.system, eChatMode.system);
						if (220307 - 87971 != 132336)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(data[32], null))
					{
						if (137040 - 135721 != 1319)
						{
							continue;
						}
						object obj4;
						object obj3 = obj4 = data[32];
						if (!(obj3 is string))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(string));
						}
						this.readMallInventory((string)obj4);
						if (55307 - 518562 == -463254)
						{
							continue;
						}
					}
					if (RuntimeServices.EqualityOperator(data[33], null))
					{
						break;
					}
					if (219651 - 13949 == 205702)
					{
						object obj6;
						object obj5 = obj6 = data[33];
						if (!(obj5 is int[]))
						{
							obj6 = RuntimeServices.Coerce(obj5, typeof(int[]));
						}
						this.zBFcCxk3Ih4 = (int[])obj6;
						if (192865 - 233523 == -40658)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006213 RID: 25107 RVA: 0x00D7F268 File Offset: 0x00D7D468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006214 RID: 25108 RVA: 0x00D7F26C File Offset: 0x00D7D46C
	internal static bool c86Z5opQXkQI3xHy71RL()
	{
		return true;
	}

	// Token: 0x06006215 RID: 25109 RVA: 0x00D7F270 File Offset: 0x00D7D470
	internal static bool imBJ98pQQEfaKMHkKGmC()
	{
		return false;
	}

	// Token: 0x04007019 RID: 28697
	public int posx;

	// Token: 0x0400701A RID: 28698
	public int posy;

	// Token: 0x0400701B RID: 28699
	public int divx;

	// Token: 0x0400701C RID: 28700
	public int divy;

	// Token: 0x0400701D RID: 28701
	public int posa;

	// Token: 0x0400701E RID: 28702
	public int posb;

	// Token: 0x0400701F RID: 28703
	public int diva;

	// Token: 0x04007020 RID: 28704
	public int divb;

	// Token: 0x04007021 RID: 28705
	public eMallState mState;

	// Token: 0x04007022 RID: 28706
	public eMallType mType;

	// Token: 0x04007023 RID: 28707
	public GameObject mSeller;

	// Token: 0x04007024 RID: 28708
	public CharacterControl mSellerChar;

	// Token: 0x04007025 RID: 28709
	public int mSellerID;

	// Token: 0x04007026 RID: 28710
	public int mLv;

	// Token: 0x04007027 RID: 28711
	public string mMallName;

	// Token: 0x04007028 RID: 28712
	private float aKxcZ0Pwmdb;

	// Token: 0x04007029 RID: 28713
	private float OLjcZ8XfItD;

	// Token: 0x0400702A RID: 28714
	private float AkDcZimBAdJ;

	// Token: 0x0400702B RID: 28715
	private int h0ZcZDRCCPd;

	// Token: 0x0400702C RID: 28716
	private ItemClass NDCcZmOi0i1;

	// Token: 0x0400702D RID: 28717
	private int fSbcZjNXHGo;

	// Token: 0x0400702E RID: 28718
	private float y9qcZojuw6S;

	// Token: 0x0400702F RID: 28719
	private int MlDcZktYvwj;

	// Token: 0x04007030 RID: 28720
	private GUIStyle QD7cZFWyp6g;

	// Token: 0x04007031 RID: 28721
	private GUIStyle CHhcZAWl1yo;

	// Token: 0x04007032 RID: 28722
	private GUIStyle lCccZ9l0G5I;

	// Token: 0x04007033 RID: 28723
	private GUIStyle gdncZWriKG1;

	// Token: 0x04007034 RID: 28724
	private Texture AjmcZu5L8Co;

	// Token: 0x04007035 RID: 28725
	private Texture CZ6cZyeVArp;

	// Token: 0x04007036 RID: 28726
	private Texture pCBcZVPuPcD;

	// Token: 0x04007037 RID: 28727
	private Texture Lg7cZh0meg6;

	// Token: 0x04007038 RID: 28728
	private GUIStyle xincZKvaobg;

	// Token: 0x04007039 RID: 28729
	private GUIStyle W61cZz1y52v;

	// Token: 0x0400703A RID: 28730
	private GUIStyle ljjcC5Ayq5Y;

	// Token: 0x0400703B RID: 28731
	private GUIStyle cALcCcfJN3C;

	// Token: 0x0400703C RID: 28732
	private GUIStyle zuxcCnAhn5Y;

	// Token: 0x0400703D RID: 28733
	private GUIStyle VnAcCQn9yfY;

	// Token: 0x0400703E RID: 28734
	private GUIStyle TuocCefkvk6;

	// Token: 0x0400703F RID: 28735
	private GUIStyle TN0cCILf5Ed;

	// Token: 0x04007040 RID: 28736
	private AudioClip anfcCJEiXwH;

	// Token: 0x04007041 RID: 28737
	private AudioClip kA4cC6ENGop;

	// Token: 0x04007042 RID: 28738
	private AudioClip yhvcCtdZNv7;

	// Token: 0x04007043 RID: 28739
	private AudioClip zUxcCXPUfVC;

	// Token: 0x04007044 RID: 28740
	private PlayerCameraControl j6IcCONNKw1;

	// Token: 0x04007045 RID: 28741
	private GameObject qelcC2wLLB8;

	// Token: 0x04007046 RID: 28742
	private Texture sCicCvErZd6;

	// Token: 0x04007047 RID: 28743
	private Texture C59cCl22qrn;

	// Token: 0x04007048 RID: 28744
	private GUIStyle GBRcCGAxx9B;

	// Token: 0x04007049 RID: 28745
	private GUIStyle xgvcC132G2R;

	// Token: 0x0400704A RID: 28746
	private string a6mcCq5wsxr;

	// Token: 0x0400704B RID: 28747
	private string rTJcCp4wGLm;

	// Token: 0x0400704C RID: 28748
	private ItemClass[] sqlcCRvX8LR;

	// Token: 0x0400704D RID: 28749
	private InventoryClass[] qWxcCrOFW5q;

	// Token: 0x0400704E RID: 28750
	private int[] zBFcCxk3Ih4;

	// Token: 0x0400704F RID: 28751
	private IconButtonClass[] xdHcCT7I2uX;

	// Token: 0x04007050 RID: 28752
	private IconButtonClass[] HoZcCYB1hda;

	// Token: 0x04007051 RID: 28753
	private Texture FswcC3Ywn68;

	// Token: 0x04007052 RID: 28754
	private Texture wQHcCbH3elO;

	// Token: 0x04007053 RID: 28755
	private Texture jBjcCdC8Ss0;

	// Token: 0x04007054 RID: 28756
	private Texture odScCgB5Nif;

	// Token: 0x04007055 RID: 28757
	private Texture oJpcCarHobf;

	// Token: 0x04007056 RID: 28758
	private GUIStyle WIHcC4SyDQH;

	// Token: 0x04007057 RID: 28759
	private GUIStyle KA8cCstZlxB;

	// Token: 0x04007058 RID: 28760
	private GUIStyle wFNcCHU29WD;

	// Token: 0x04007059 RID: 28761
	private string x4JcC7AvfxP;

	// Token: 0x0400705A RID: 28762
	private string XLjcCZ4HUBQ;

	// Token: 0x0400705B RID: 28763
	private Texture r3IcCC3Yj1m;

	// Token: 0x0400705C RID: 28764
	private GUIStyle aK1cCM5UZk3;

	// Token: 0x0400705D RID: 28765
	private GUIStyle TokcCfLJTJX;

	// Token: 0x0400705E RID: 28766
	private Color RrOcCLynh1M;

	// Token: 0x0400705F RID: 28767
	private Color aancCwf7USN;

	// Token: 0x04007060 RID: 28768
	private Color sYLcCUSTgs7;

	// Token: 0x04007061 RID: 28769
	private Color x3JcCNHhcRJ;

	// Token: 0x04007062 RID: 28770
	private Color cu5cCEwPu7G;

	// Token: 0x04007063 RID: 28771
	private Color qVHcCPbmkrn;

	// Token: 0x04007064 RID: 28772
	private Color CbVcCSBKFAy;

	// Token: 0x04007065 RID: 28773
	private Texture r4QcCBdXGxj;

	// Token: 0x04007066 RID: 28774
	private GUIStyle tLdcC0PLftv;

	// Token: 0x04007067 RID: 28775
	private float Er0cC8s2s3d;

	// Token: 0x04007068 RID: 28776
	private string QVHcCirB1jL;

	// Token: 0x04007069 RID: 28777
	private string B54cCDhJf5G;

	// Token: 0x0400706A RID: 28778
	private float D7wcCmO6dLJ;

	// Token: 0x0400706B RID: 28779
	private GUIStyle WERcCjrQUpx;

	// Token: 0x0400706C RID: 28780
	private Texture P5gcCoeEbCm;

	// Token: 0x0200107F RID: 4223
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onMallSellEvent$36322 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006216 RID: 25110 RVA: 0x00D7F274 File Offset: 0x00D7D474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onMallSellEvent$36322(Hashtable data, MallGui self_)
		{
			if (286580 - 424168 != -137588)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (274843 - 293001 != -18157)
				{
					base..ctor();
					if (264056 - 187113 != 76944)
					{
						this.$data$36325 = data;
						if (214359 - 472835 != -258475)
						{
							this.$self_$36326 = self_;
							if (124195 - 310054 != -185858)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x00D7F330 File Offset: 0x00D7D530
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MallGui.$onMallSellEvent$36322.$(this.$data$36325, this.$self_$36326);
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x00D7F344 File Offset: 0x00D7D544
		internal static bool UmCNDXpQkqY3MA00b1bC()
		{
			return true;
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x00D7F348 File Offset: 0x00D7D548
		internal static bool nHvZ0fpQGweURVRTvfKg()
		{
			return false;
		}

		// Token: 0x0400706D RID: 28781
		internal Hashtable $data$36325;

		// Token: 0x0400706E RID: 28782
		internal MallGui $self_$36326;

		// Token: 0x02001080 RID: 4224
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600621A RID: 25114 RVA: 0x00D7F34C File Offset: 0x00D7D54C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, MallGui self_)
			{
				if (240471 - 450592 != -210120)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98028 - 7966 == 90062)
					{
						base..ctor();
						if (137132 - 42591 == 94541)
						{
							this.$data$36323 = data;
							if (77648 - 41512 != 36137)
							{
								this.$self_$36324 = self_;
								if (85916 - 71610 != 14307)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600621B RID: 25115 RVA: 0x00D7F408 File Offset: 0x00D7D608
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (165824 - 8024 != 157801)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_497;
					case 2:
						if (this.$self_$36324.mState != eMallState.mall)
						{
							goto IL_3FE;
						}
						if (39368 - 14259 != 25109)
						{
							continue;
						}
						this.$self_$36324.ResetMallInventory();
						if (105390 - 440323 != -334933)
						{
							continue;
						}
						goto IL_3FE;
					default:
						if (107347 - 488402 != -381055)
						{
							continue;
						}
						break;
					}
					Debug.Log("OnMallSellEvent");
					if (273084 - 239135 != 33949)
					{
						continue;
					}
					if (!this.$self_$36324.mSeller)
					{
						if (55675 - 316402 != -260727)
						{
							continue;
						}
						break;
					}
					else if (!this.$self_$36324.mSellerChar)
					{
						if (71328 - 16124 != 55204)
						{
							continue;
						}
						break;
					}
					else if (!this.$self_$36324.mSellerChar.isMine)
					{
						if (226961 - 45656 != 181306)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$self_$36324.mSellerChar.myCommand != "mallSetup")
						{
							if (154485 - 92199 == 62287)
							{
								continue;
							}
							if (this.$self_$36324.mSellerChar.myCommand != "mallOpen")
							{
								if (199041 - 425424 != -226383)
								{
									continue;
								}
								break;
							}
						}
						if (!RuntimeServices.EqualityOperator(this.$data$36323[31], null))
						{
							if (132997 - 39009 == 93989)
							{
								continue;
							}
							string nChatName = "system";
							object obj2;
							object obj = obj2 = this.$data$36323[31];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							Chat.SubmitChat(nChatName, (string)obj2, eChatType.system, eChatMode.system);
							if (128712 - 567538 != -438826)
							{
								continue;
							}
						}
						if (!RuntimeServices.EqualityOperator(this.$data$36323[32], null))
						{
							if (110684 - 372015 != -261331)
							{
								continue;
							}
							this.$self_$36324.newNoticeBar("Item sold!", (float)2);
							if (105837 - 360730 == -254892)
							{
								continue;
							}
							MallGui mallGui = this.$self_$36324;
							object obj4;
							object obj3 = obj4 = this.$data$36323[32];
							if (!(obj3 is string))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(string));
							}
							mallGui.readMallInventory((string)obj4);
							if (111730 - 303168 != -191438)
							{
								continue;
							}
							if (!RuntimeServices.EqualityOperator(this.$data$36323[33], null))
							{
								if (16922 - 557935 == -541012)
								{
									continue;
								}
								MallGui mallGui2 = this.$self_$36324;
								object obj6;
								object obj5 = obj6 = this.$data$36323[33];
								if (!(obj5 is int[]))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(int[]));
								}
								mallGui2.zBFcCxk3Ih4 = (int[])obj6;
								if (167533 - 13908 != 153625)
								{
									continue;
								}
							}
							this.$self_$36324.ResetMallInventory();
							if (136908 - 174568 != -37660)
							{
								continue;
							}
							this.$self_$36324.aKxcZ0Pwmdb = Time.time;
							if (265249 - 130943 != 134307)
							{
								goto Block_19;
							}
							continue;
						}
					}
					IL_3FE:
					if (!RuntimeServices.EqualityOperator(this.$data$36323[48], null))
					{
						if (290152 - 507741 == -217588)
						{
							continue;
						}
						PlayerData.Gil = RuntimeServices.UnboxInt32(this.$data$36323[48]);
						if (244786 - 525824 != -281038)
						{
							continue;
						}
					}
					this.YieldDefault(1);
				}
				while (157347 - 157923 == -575);
				goto IL_497;
				Block_19:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_497:
				return false;
			}

			// Token: 0x0600621C RID: 25116 RVA: 0x00D7F8C0 File Offset: 0x00D7DAC0
			internal static bool A5jPIPpQHN2Zb6PLHplq()
			{
				return true;
			}

			// Token: 0x0600621D RID: 25117 RVA: 0x00D7F8C4 File Offset: 0x00D7DAC4
			internal static bool SdjFHppQW1h84gXDRrkM()
			{
				return false;
			}

			// Token: 0x0400706F RID: 28783
			internal Hashtable $data$36323;

			// Token: 0x04007070 RID: 28784
			internal MallGui $self_$36324;
		}
	}

	// Token: 0x02001081 RID: 4225
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onMallBuyOperation$36327 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600621E RID: 25118 RVA: 0x00D7F8C8 File Offset: 0x00D7DAC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onMallBuyOperation$36327(Hashtable data, MallGui self_)
		{
			if (120442 - 86278 != 34165)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (87500 - 47033 != 40468)
				{
					base..ctor();
					if (160511 - 347848 != -187336)
					{
						this.$data$36331 = data;
						if (28567 - 192829 != -164261)
						{
							this.$self_$36332 = self_;
							if (235794 - 502416 == -266622)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00D7F984 File Offset: 0x00D7DB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MallGui.$onMallBuyOperation$36327.$(this.$data$36331, this.$self_$36332);
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x00D7F998 File Offset: 0x00D7DB98
		internal static bool VdARhopQAFDN1lr0W52V()
		{
			return true;
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x00D7F99C File Offset: 0x00D7DB9C
		internal static bool X0PWumpQlg23NyqEQ6tp()
		{
			return false;
		}

		// Token: 0x04007071 RID: 28785
		internal Hashtable $data$36331;

		// Token: 0x04007072 RID: 28786
		internal MallGui $self_$36332;

		// Token: 0x02001082 RID: 4226
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006222 RID: 25122 RVA: 0x00D7F9A0 File Offset: 0x00D7DBA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, MallGui self_)
			{
				if (192753 - 56744 != 136009)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292671 - 301188 == -8517)
					{
						base..ctor();
						if (252287 - 506051 != -253763)
						{
							this.$data$36329 = data;
							if (262949 - 265581 != -2631)
							{
								this.$self_$36330 = self_;
								if (206203 - 222962 == -16759)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006223 RID: 25123 RVA: 0x00D7FA5C File Offset: 0x00D7DC5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (3443 - 491676 != -488232)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_56B;
					case 2:
						if (this.$self_$36330.mState == eMallState.mall)
						{
							if (56764 - 437177 != -380413)
							{
								continue;
							}
							this.$self_$36330.ResetMallInventory();
							if (42773 - 356061 != -313288)
							{
								continue;
							}
						}
						goto IL_511;
					default:
						if (105585 - 508207 != -402622)
						{
							continue;
						}
						break;
					}
					Debug.Log("OnMallBuyOperation:" + this.$data$36329[21]);
					if (143209 - 550559 == -407349)
					{
						continue;
					}
					if (!this.$self_$36330.mSeller)
					{
						if (111872 - 303520 != -191648)
						{
							continue;
						}
						break;
					}
					else if (!this.$self_$36330.mSellerChar)
					{
						if (273113 - 2952 != 270162)
						{
							break;
						}
						continue;
					}
					else if (this.$self_$36330.mSellerChar.isMine)
					{
						if (41030 - 449173 != -408143)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$$switch$4991$36328 = this.$data$36329[21];
						if (230905 - 597577 != -366672)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(this.$$switch$4991$36328, 0))
						{
							if (82164 - 493940 == -411775)
							{
								continue;
							}
							if (RuntimeServices.EqualityOperator(this.$data$36329[31], 1))
							{
								if (231392 - 250512 != -19120)
								{
									continue;
								}
								MallGui mallGui = this.$self_$36330;
								object obj2;
								object obj = obj2 = this.$data$36329[32];
								if (!(obj is string))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(string));
								}
								mallGui.readMallInventory((string)obj2);
								if (209662 - 499962 == -290299)
								{
									continue;
								}
								MallGui mallGui2 = this.$self_$36330;
								object obj4;
								object obj3 = obj4 = this.$data$36329[33];
								if (!(obj3 is int[]))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(int[]));
								}
								mallGui2.zBFcCxk3Ih4 = (int[])obj4;
								if (48995 - 489938 != -440943)
								{
									continue;
								}
							}
							else
							{
								this.$self_$36330.ResetMallMenu();
								if (47202 - 282683 != -235481)
								{
									continue;
								}
								this.$self_$36330.newNoticeBar("Mall failed: Item Server Error", (float)2);
								if (151643 - 346203 != -194560)
								{
									continue;
								}
							}
						}
						else if (RuntimeServices.EqualityOperator(this.$$switch$4991$36328, 1))
						{
							if (163302 - 117390 == 45913)
							{
								continue;
							}
							if (RuntimeServices.EqualityOperator(this.$data$36329[31], 1))
							{
								if (56823 - 250566 == -193742)
								{
									continue;
								}
								this.$self_$36330.newNoticeBar("New item bought!", (float)2);
								if (272889 - 118178 != 154711)
								{
									continue;
								}
								this.$self_$36330.aKxcZ0Pwmdb = Time.time;
								if (9432 - 28147 == -18714)
								{
									continue;
								}
								this.$self_$36330.ResetMallInventory();
								if (14858 - 228952 == -214093)
								{
									continue;
								}
								if (RuntimeServices.EqualityOperator(this.$data$36329[48], null))
								{
									goto IL_B0;
								}
								if (143349 - 60851 == 82499)
								{
									continue;
								}
								PlayerData.Gil = RuntimeServices.UnboxInt32(this.$data$36329[48]);
								if (293472 - 56560 != 236913)
								{
									goto Block_4;
								}
								continue;
							}
							else
							{
								this.$self_$36330.newNoticeBar("Mall failed: Item Server Error", (float)2);
								if (244676 - 574808 == -330131)
								{
									continue;
								}
							}
						}
						else if (RuntimeServices.EqualityOperator(this.$$switch$4991$36328, 2))
						{
							if (83623 - 461456 == -377832)
							{
								continue;
							}
							if (!RuntimeServices.EqualityOperator(this.$data$36329[31], 1))
							{
								if (89746 - 500227 == -410480)
								{
									continue;
								}
								Debug.Log("Warning leaving mall operation failed");
								if (80082 - 383865 == -303782)
								{
									continue;
								}
							}
						}
					}
					IL_499:
					this.YieldDefault(1);
					if (7690 - 563326 != -555635)
					{
						break;
					}
					continue;
					IL_511:
					goto IL_499;
				}
				goto IL_56B;
				Block_4:
				IL_B0:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_56B:
				return false;
			}

			// Token: 0x06006224 RID: 25124 RVA: 0x00D7FFE8 File Offset: 0x00D7E1E8
			internal static bool KasUI1pQyQX7B2EaSnkF()
			{
				return true;
			}

			// Token: 0x06006225 RID: 25125 RVA: 0x00D7FFEC File Offset: 0x00D7E1EC
			internal static bool ItvRIcpQSg0RZb9E7TAQ()
			{
				return false;
			}

			// Token: 0x04007073 RID: 28787
			internal object $$switch$4991$36328;

			// Token: 0x04007074 RID: 28788
			internal Hashtable $data$36329;

			// Token: 0x04007075 RID: 28789
			internal MallGui $self_$36330;
		}
	}
}
