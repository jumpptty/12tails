using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001035 RID: 4149
[Serializable]
public class BankGui : MonoBehaviour
{
	// Token: 0x06005FAB RID: 24491 RVA: 0x00CDD7BC File Offset: 0x00CDB9BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BankGui()
	{
		if (54174 - 145345 != -91170)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (52146 - 505397 == -453251)
			{
				base..ctor();
				if (41844 - 571601 == -529757)
				{
					this.posa = 1f;
					if (164216 - 18398 != 145819)
					{
						this.posb = 1f;
						if (16477 - 337366 == -320889)
						{
							this.diva = 1f;
							if (116612 - 51963 != 64650)
							{
								this.divb = 1f;
								if (66990 - 170288 != -103297)
								{
									this.mState = eBankState.init;
									if (129379 - 11204 != 118176)
									{
										this.JvLcqXZRVrp = 1;
										if (91872 - 63379 != 28494)
										{
											this.BmicqmsC27D = string.Empty;
											if (209632 - 493362 != -283729)
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

	// Token: 0x06005FAC RID: 24492 RVA: 0x00CDD930 File Offset: 0x00CDBB30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (78255 - 415788 != -337532)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (44578 - 216533 == -171955)
			{
				if (this.mState == eBankState.init)
				{
					if (135887 - 16042 != 119845)
					{
						continue;
					}
					this.InitBankGui();
					if (31229 - 451502 == -420272)
					{
						continue;
					}
					this.InitNPC();
					if (47383 - 5072 == 42312)
					{
						continue;
					}
					this.InitBankMenu();
					if (90927 - 69014 != 21913)
					{
						continue;
					}
					this.InitBankInventory();
					if (95912 - 392935 == -297022)
					{
						continue;
					}
					this.InitBankNotice();
					if (138876 - 534556 == -395679)
					{
						continue;
					}
				}
				this.ResetNPC();
				if (201127 - 480336 != -279208)
				{
					this.ResetBankMenu();
					if (82384 - 548687 == -466303)
					{
						this.ResetBankInventory();
						if (201050 - 309656 == -108606)
						{
							this.IgjcqIFl1m8 = 1f;
							if (208016 - 362540 == -154524)
							{
								this.mState = eBankState.open;
								if (257469 - 238656 == 18813)
								{
									this.VDrcqnjcPBl = Time.time;
									if (283997 - 302891 == -18894)
									{
										this.UpdateGold();
										if (185625 - 403840 != -218214)
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

	// Token: 0x06005FAD RID: 24493 RVA: 0x00CDDB3C File Offset: 0x00CDBD3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (204286 - 22991 != 181295)
		{
		}
		for (;;)
		{
			if (this.mState <= eBankState.init)
			{
				if (60964 - 4745 != 56220)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (95375 - 175223 != -79847)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (57511 - 281963 != -224451)
					{
						this.X5xcqQYJWmK = (float)(1024 * Screen.width / Screen.height);
						if (285965 - 210612 != 75354)
						{
							this.kFTcqeaR3tw = (float)Screen.height / 1024f;
							if (282946 - 126419 != 156528)
							{
								this.RenderBankGui();
								if (48466 - 181247 == -132781)
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

	// Token: 0x06005FAE RID: 24494 RVA: 0x00CDDC8C File Offset: 0x00CDBE8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitBankGui()
	{
		if (219659 - 489731 != -270071)
		{
		}
		for (;;)
		{
			this.MlWcq28VS4g = new GUIStyle();
			if (279808 - 521949 != -242140)
			{
				this.MlWcq28VS4g.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
				if (14186 - 477762 == -463576)
				{
					this.A2mcqvkM1AJ = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
					if (247407 - 18106 == 229301)
					{
						this.uVLcqlmwox4 = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
						if (298850 - 514075 != -215224)
						{
							this.mPOcqGFG61Q = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
							if (54835 - 577501 != -522665)
							{
								this.BDpcq1YOtI8 = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
								if (284582 - 327093 == -42511)
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

	// Token: 0x06005FAF RID: 24495 RVA: 0x00CDDE18 File Offset: 0x00CDC018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderBankGui()
	{
		if (207381 - 66736 != 140645)
		{
		}
		for (;;)
		{
			float num = Time.time - this.VDrcqnjcPBl;
			if (205783 - 392080 != -186296)
			{
				eBankState eBankState = this.mState;
				if (88991 - 124311 != -35319)
				{
					if (eBankState == eBankState.init)
					{
						if (277660 - 88209 == 189451)
						{
							break;
						}
					}
					else if (eBankState == eBankState.open)
					{
						if (189915 - 115773 != 74143)
						{
							if (num <= 0.5f)
							{
								if (22755 - 479084 != -456328)
								{
									this.IgjcqIFl1m8 = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (117056 - 94859 == 22197)
									{
										this.RenderNPC();
										if (293843 - 307190 == -13347)
										{
											GUI.DrawTexture(new Rect(0.5f * this.X5xcqQYJWmK - (float)336, (float)724 + this.IgjcqIFl1m8 * (float)300, (float)836, (float)196), this.FvFcqpvoslj);
											if (164678 - 335649 != -170970)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (196029 - 73375 == 122654)
								{
									this.IgjcqIFl1m8 = (float)0;
									if (59848 - 407876 != -348027)
									{
										this.RenderNPC();
										if (295459 - 222648 == 72811)
										{
											GUI.BeginGroup(new Rect(0.5f * this.X5xcqQYJWmK - (float)350, (float)724, (float)850, (float)200));
											if (207745 - 182515 == 25230)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.FvFcqpvoslj);
												if (264594 - 238459 == 26135)
												{
													GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Dwukphu", this.aNVcqR0tSgm);
													if (205313 - 5154 == 200159)
													{
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.I1RcqxRIiip, num - 0.5f), this.MDTcqra4ruU);
														if (251389 - 529705 == -278316)
														{
															GUI.EndGroup();
															if (148361 - 334321 != -185959)
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
								this.IgjcqIFl1m8 = (float)0;
								if (143374 - 501232 != -357857)
								{
									this.RenderNPC();
									if (249345 - 251715 != -2369)
									{
										this.mState = eBankState.bankmenu;
										if (61311 - 492691 != -431379)
										{
											this.VDrcqnjcPBl = Time.time;
											if (100589 - 558497 == -457908)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (eBankState == eBankState.bankmenu)
					{
						if (119115 - 302774 == -183659)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.X5xcqQYJWmK - (float)400) / this.X5xcqQYJWmK, (float)1);
							if (143124 - 126265 != 16860)
							{
								GUI.BeginGroup(new Rect(this.X5xcqQYJWmK - (float)850, (float)0, (float)850, (float)1024));
								if (133407 - 63415 == 69992)
								{
									GUI.DrawTexture(new Rect((float)300, (float)0, (float)550, (float)1024), this.jg9cqYwdVjq);
									if (240070 - 15552 == 224518)
									{
										Guix.renderSmallNumber(532, 64, PlayerData.Gil, false, (float)1);
										if (35939 - 115487 != -79547)
										{
											Guix.renderSmallNumber(730, 64, PlayerData.Jil, false, (float)1);
											if (169041 - 505667 != -336625)
											{
												this.RenderBankMenu();
												if (184964 - 564798 == -379834)
												{
													this.RenderBankInventory();
													if (190379 - 335559 != -145179)
													{
														this.RenderNoticeBar();
														if (77614 - 170324 == -92710)
														{
															if (GUI.Button(new Rect((float)401, (float)1, (float)57, (float)52), string.Empty, this.MlWcq28VS4g))
															{
																if (277288 - 277697 != -409)
																{
																	continue;
																}
																this.mState = eBankState.close;
																if (277620 - 574707 == -297086)
																{
																	continue;
																}
																this.VDrcqnjcPBl = Time.time;
																if (274589 - 147128 == 127462)
																{
																	continue;
																}
																this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
																if (106042 - 131783 == -25740)
																{
																	continue;
																}
																if (this.BDpcq1YOtI8)
																{
																	if (135074 - 455984 == -320909)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.BDpcq1YOtI8);
																	if (229822 - 407140 == -177317)
																	{
																		continue;
																	}
																}
															}
															GUI.EndGroup();
															if (266137 - 475816 != -209678)
															{
																this.RenderNPC();
																if (99438 - 233265 == -133827)
																{
																	this.RenderDragIcon();
																	if (215284 - 126803 == 88481)
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
					else
					{
						if (eBankState != eBankState.close)
						{
							break;
						}
						if (299240 - 535947 != -236706)
						{
							if (num <= (float)2)
							{
								if (127377 - 159051 != -31673)
								{
									this.RenderNPC();
									if (87307 - 430157 == -342850)
									{
										GUI.BeginGroup(new Rect(0.5f * this.X5xcqQYJWmK - (float)350, (float)724, (float)850, (float)200));
										if (255722 - 348260 != -92537)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.FvFcqpvoslj);
											if (109324 - 144858 != -35533)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Dwukphu", this.aNVcqR0tSgm);
												if (58906 - 149076 != -90169)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.SiKcqTV1E2j, num), this.MDTcqra4ruU);
													if (28421 - 18962 != 9460)
													{
														GUI.EndGroup();
														if (257892 - 455862 == -197970)
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
								if (118541 - 120953 != -2411)
								{
									this.IgjcqIFl1m8 = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (293872 - 378162 == -84290)
									{
										this.RenderNPC();
										if (233678 - 56204 != 177475)
										{
											break;
										}
									}
								}
							}
							else
							{
								Game.mGameState = eGameState.Normal;
								if (17618 - 576799 != -559180)
								{
									GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
									if (128932 - 92347 != 36586)
									{
										gameGui.enabled = true;
										if (41699 - 226871 != -185171)
										{
											this.mState = eBankState.disabled;
											if (132078 - 584230 != -452151)
											{
												this.enabled = false;
												if (23787 - 478968 == -455181)
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

	// Token: 0x06005FB0 RID: 24496 RVA: 0x00CDE7A8 File Offset: 0x00CDC9A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (163084 - 201542 != -38457)
		{
		}
		for (;;)
		{
			this.FvFcqpvoslj = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (189770 - 284610 == -94840)
			{
				this.aNVcqR0tSgm = new GUIStyle();
				if (224293 - 371635 == -147342)
				{
					this.aNVcqR0tSgm.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (116351 - 565677 == -449326)
					{
						this.aNVcqR0tSgm.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (101548 - 295799 == -194251)
						{
							this.aNVcqR0tSgm.alignment = TextAnchor.UpperLeft;
							if (287119 - 371700 != -84580)
							{
								this.MDTcqra4ruU = new GUIStyle();
								if (219701 - 218136 != 1566)
								{
									this.MDTcqra4ruU.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (214476 - 508743 != -294266)
									{
										this.MDTcqra4ruU.alignment = TextAnchor.UpperLeft;
										if (256386 - 160273 != 96114)
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

	// Token: 0x06005FB1 RID: 24497 RVA: 0x00CDE96C File Offset: 0x00CDCB6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (177410 - 444421 != -267010)
		{
		}
		for (;;)
		{
			this.gkZcqqxZ7Cd = (Texture)Resources.Load("GameGui/Story/Characters/CatFish", typeof(Texture));
			if (193333 - 42528 != 150806)
			{
				this.I1RcqxRIiip = Language.getMessage("BankGui", UnityEngine.Random.Range(101, 106));
				if (279594 - 360526 != -80931)
				{
					this.SiKcqTV1E2j = Language.getMessage("BankGui", UnityEngine.Random.Range(201, 206));
					if (35862 - 155591 == -119729)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005FB2 RID: 24498 RVA: 0x00CDEA4C File Offset: 0x00CDCC4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (this.gkZcqqxZ7Cd)
		{
			GUI.DrawTexture(new Rect((float)0 - this.IgjcqIFl1m8 * (float)512, (float)553, (float)512, (float)471), this.gkZcqqxZ7Cd);
		}
	}

	// Token: 0x06005FB3 RID: 24499 RVA: 0x00CDEA9C File Offset: 0x00CDCC9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitBankMenu()
	{
		if (189879 - 338862 != -148983)
		{
		}
		for (;;)
		{
			this.jg9cqYwdVjq = (Texture)Resources.Load("GameGui/Bank/bankWindow", typeof(Texture));
			if (251048 - 169379 != 81670)
			{
				this.hvVcq3V1OXW = (Texture)Resources.Load("GameGui/Bank/sellBar", typeof(Texture));
				if (150449 - 311242 != -160792)
				{
					this.QZqcqbqvRCy = new GUIStyle();
					if (171270 - 5784 == 165486)
					{
						this.QZqcqbqvRCy.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Bank/button_highlight_h", typeof(Texture)));
						if (100508 - 568279 == -467771)
						{
							this.QZqcqbqvRCy.active.background = (Texture2D)((Texture)Resources.Load("GameGui/Bank/button_highlight_a", typeof(Texture)));
							if (108286 - 101448 != 6839)
							{
								this.j5ycqdVAkNE = new GUIStyle();
								if (290233 - 353336 != -63102)
								{
									this.j5ycqdVAkNE.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Bank/button_buy_h", typeof(Texture)));
									if (222493 - 72594 == 149899)
									{
										this.YI2cqgKLkfT = new GUIStyle();
										if (140385 - 108166 == 32219)
										{
											this.YI2cqgKLkfT.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Bank/button_sell_h", typeof(Texture)));
											if (33674 - 130677 == -97003)
											{
												this.qwfcqao1Co6 = new GUIStyle();
												if (246898 - 106162 != 140737)
												{
													this.qwfcqao1Co6.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numUp_h", typeof(Texture)));
													if (270151 - 175107 != 95045)
													{
														this.Gnccq4a22xV = new GUIStyle();
														if (137720 - 410922 != -273201)
														{
															this.Gnccq4a22xV.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numDown_h", typeof(Texture)));
															if (191932 - 593779 != -401846)
															{
																this.lKmcqsusHAr = new GUIStyle();
																if (257871 - 148876 == 108995)
																{
																	this.lKmcqsusHAr.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																	if (186595 - 88187 != 98409)
																	{
																		this.lKmcqsusHAr.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																		if (253772 - 347043 != -93270)
																		{
																			this.lKmcqsusHAr.alignment = TextAnchor.MiddleLeft;
																			if (125513 - 510698 == -385185)
																			{
																				this.ChicqH0O2qf = new GUIStyle();
																				if (95959 - 556311 == -460352)
																				{
																					this.ChicqH0O2qf.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																					if (71692 - 284623 != -212930)
																					{
																						this.ChicqH0O2qf.normal.textColor = new Color(0.16f, 0.42f, 0.31f, (float)1);
																						if (183749 - 479845 != -296095)
																						{
																							this.ChicqH0O2qf.alignment = TextAnchor.MiddleRight;
																							if (64972 - 484182 != -419209)
																							{
																								this.fiMcq7hK5LS = new GUIStyle();
																								if (133315 - 481171 == -347856)
																								{
																									this.fiMcq7hK5LS.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																									if (70506 - 200269 == -129763)
																									{
																										this.fiMcq7hK5LS.normal.textColor = new Color(0.16f, 0.27f, 0.42f, (float)1);
																										if (174266 - 589961 == -415695)
																										{
																											this.fiMcq7hK5LS.alignment = TextAnchor.MiddleRight;
																											if (170993 - 406149 != -235155)
																											{
																												this.lXicqZPPQ7p = new GUIStyle();
																												if (156875 - 159628 == -2753)
																												{
																													this.lXicqZPPQ7p.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																													if (116275 - 18756 == 97519)
																													{
																														this.lXicqZPPQ7p.normal.textColor = new Color(0.5f, 0.21f, 0.16f, (float)1);
																														if (152329 - 86731 == 65598)
																														{
																															this.lXicqZPPQ7p.alignment = TextAnchor.MiddleRight;
																															if (87123 - 104480 != -17356)
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

	// Token: 0x06005FB4 RID: 24500 RVA: 0x00CDF0CC File Offset: 0x00CDD2CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetBankMenu()
	{
		if (296008 - 389836 != -93828)
		{
		}
		for (;;)
		{
			IL_1A:
			this.Pu7cqCgWsWv = (string[])ShopData.getCatFishList(PlayerData.Rank);
			if (219197 - 314921 == -95724)
			{
				this.A8ucqMXre76 = new ItemClass[Extensions.get_length(this.Pu7cqCgWsWv)];
				if (144117 - 387262 == -243145)
				{
					this.f0qcqfN7Vkp = new Texture[Extensions.get_length(this.Pu7cqCgWsWv)];
					if (58591 - 368047 == -309456)
					{
						int i = 0;
						if (290272 - 137937 == 152335)
						{
							while (i < Extensions.get_length(this.Pu7cqCgWsWv))
							{
								if (!string.IsNullOrEmpty(this.Pu7cqCgWsWv[i]))
								{
									if (165243 - 557593 != -392350)
									{
										goto IL_1A;
									}
									this.A8ucqMXre76[i] = ItemData.getItemData(this.Pu7cqCgWsWv[i]);
									if (143678 - 584876 == -441197)
									{
										goto IL_1A;
									}
									this.f0qcqfN7Vkp[i] = IconButton.getIconImage(this.Pu7cqCgWsWv[i]);
									if (149343 - 517409 == -368065)
									{
										goto IL_1A;
									}
								}
								i++;
								if (31325 - 528487 == -497161)
								{
									goto IL_1A;
								}
							}
							if (171562 - 191873 != -20310)
							{
								this.jQTcqJ1lcDi = 0;
								if (6614 - 388185 != -381570)
								{
									this.BDTcq60gCD5 = 0;
									if (276837 - 485366 != -208528)
									{
										if (this.A8ucqMXre76[0] != null)
										{
											if (238529 - 468134 == -229604)
											{
												continue;
											}
											this.UF8cqtyQSgU = this.A8ucqMXre76[0];
											if (8737 - 341436 != -332699)
											{
												continue;
											}
										}
										else
										{
											this.UF8cqtyQSgU = new ItemClass();
											if (181318 - 133042 != 48276)
											{
												continue;
											}
										}
										this.JvLcqXZRVrp = 1;
										if (43928 - 268696 == -224768)
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

	// Token: 0x06005FB5 RID: 24501 RVA: 0x00CDF364 File Offset: 0x00CDD564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderBankMenu()
	{
		if (95211 - 57486 != 37726)
		{
		}
		for (;;)
		{
			IL_332:
			Guix.renderBigNumber(550, 187, this.jQTcqJ1lcDi, false, 0.5f);
			if (924 - 403119 != -402194)
			{
				Guix.renderBigNumber(740, 187, this.jQTcqJ1lcDi - 20, false, 0.5f);
				if (104573 - 53763 == 50810)
				{
					int num = 0;
					if (172085 - 96017 != 76069)
					{
						int i = 0;
						if (8906 - 191489 == -182583)
						{
							while (i < Extensions.get_length(this.Pu7cqCgWsWv))
							{
								if (i == this.BDTcq60gCD5)
								{
									if (246979 - 58168 != 188811)
									{
										goto IL_332;
									}
									GUI.DrawTexture(new Rect((float)390, (float)(297 + 51 * i), (float)415, (float)51), this.QZqcqbqvRCy.active.background);
									if (18000 - 502519 != -484519)
									{
										goto IL_332;
									}
								}
								else if (GUI.Button(new Rect((float)390, (float)(297 + 51 * i), (float)415, (float)51), string.Empty, this.QZqcqbqvRCy))
								{
									if (293828 - 53248 == 240581)
									{
										goto IL_332;
									}
									this.BDTcq60gCD5 = i;
									if (235085 - 554508 != -319423)
									{
										goto IL_332;
									}
									this.UF8cqtyQSgU = this.A8ucqMXre76[i];
									if (119499 - 277676 == -158176)
									{
										goto IL_332;
									}
									this.JvLcqXZRVrp = 1;
									if (167659 - 82851 == 84809)
									{
										goto IL_332;
									}
								}
								int num2 = i;
								if (278420 - 559886 != -281466)
								{
									goto IL_332;
								}
								if (num2 == 0)
								{
									if (82471 - 10756 == 71716)
									{
										goto IL_332;
									}
									num = 10000 + this.jQTcqJ1lcDi;
									if (244180 - 355749 != -111569)
									{
										goto IL_332;
									}
								}
								else if (num2 == 1)
								{
									if (197431 - 352949 == -155517)
									{
										goto IL_332;
									}
									num = 30000 + 3 * this.jQTcqJ1lcDi;
									if (215668 - 518553 == -302884)
									{
										goto IL_332;
									}
								}
								else if (num2 == 2)
								{
									if (12948 - 597105 != -584157)
									{
										goto IL_332;
									}
									num = 70000 + 7 * this.jQTcqJ1lcDi;
									if (68390 - 200442 != -132052)
									{
										goto IL_332;
									}
								}
								if (this.f0qcqfN7Vkp[i])
								{
									if (107631 - 300211 != -192580)
									{
										goto IL_332;
									}
									GUI.DrawTexture(new Rect((float)398, (float)(295 + 51 * i), (float)64, (float)64), this.f0qcqfN7Vkp[i]);
									if (206859 - 97778 != 109081)
									{
										goto IL_332;
									}
								}
								if (!RuntimeServices.EqualityOperator(this.A8ucqMXre76[i], "none"))
								{
									if (60906 - 400959 == -340052)
									{
										goto IL_332;
									}
									GUI.Label(new Rect((float)480, (float)(296 + 51 * i), (float)175, (float)50), this.A8ucqMXre76[i].name, this.lKmcqsusHAr);
									if (220216 - 150685 == 69532)
									{
										goto IL_332;
									}
								}
								if (num <= PlayerData.Gil)
								{
									if (272921 - 24066 == 248856)
									{
										goto IL_332;
									}
									GUI.Label(new Rect((float)695, (float)(306 + 51 * i), (float)100, (float)30), num + "g", this.fiMcq7hK5LS);
									if (247927 - 74115 == 173813)
									{
										goto IL_332;
									}
								}
								else
								{
									GUI.Label(new Rect((float)695, (float)(306 + 51 * i), (float)100, (float)30), num + "g", this.lXicqZPPQ7p);
									if (153400 - 501510 == -348109)
									{
										goto IL_332;
									}
								}
								i++;
								if (78353 - 577526 == -499172)
								{
									goto IL_332;
								}
							}
							if (63917 - 339411 == -275494)
							{
								if (this.BDTcq60gCD5 < 20)
								{
									if (140482 - 56157 == 84326)
									{
										continue;
									}
									if (this.BDTcq60gCD5 < Extensions.get_length(this.Pu7cqCgWsWv))
									{
										if (109476 - 107195 == 2282)
										{
											continue;
										}
										int num3 = 0;
										if (132771 - 281203 != -148432)
										{
											continue;
										}
										int bdtcq60gCD = this.BDTcq60gCD5;
										if (230762 - 503847 != -273085)
										{
											continue;
										}
										if (bdtcq60gCD == 0)
										{
											if (120081 - 572327 == -452245)
											{
												continue;
											}
											num3 = 10000 + this.jQTcqJ1lcDi;
											if (206949 - 50163 != 156786)
											{
												continue;
											}
										}
										else if (bdtcq60gCD == 1)
										{
											if (156701 - 567971 == -411269)
											{
												continue;
											}
											num3 = 30000 + 3 * this.jQTcqJ1lcDi;
											if (280725 - 398875 != -118150)
											{
												continue;
											}
										}
										else if (bdtcq60gCD == 2)
										{
											if (219553 - 146398 != 73155)
											{
												continue;
											}
											num3 = 70000 + 7 * this.jQTcqJ1lcDi;
											if (74937 - 200364 != -125427)
											{
												continue;
											}
										}
										if (this.f0qcqfN7Vkp[this.BDTcq60gCD5])
										{
											if (52484 - 301237 != -248753)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)436, (float)542, (float)64, (float)64), this.f0qcqfN7Vkp[this.BDTcq60gCD5]);
											if (267121 - 311988 == -44866)
											{
												continue;
											}
										}
										GUI.Label(new Rect((float)500, (float)545, (float)40, (float)36), string.Empty + this.JvLcqXZRVrp, this.ChicqH0O2qf);
										if (252025 - 432157 == -180131)
										{
											continue;
										}
										GUI.Label(new Rect((float)580, (float)554, (float)90, (float)30), num3 * this.JvLcqXZRVrp + "g", this.fiMcq7hK5LS);
										if (196506 - 36425 != 160081)
										{
											continue;
										}
										if (GUI.Button(new Rect((float)556, (float)547, (float)22, (float)18), string.Empty, this.qwfcqao1Co6))
										{
											if (212525 - 244756 != -32231)
											{
												continue;
											}
											this.JvLcqXZRVrp = Mathf.Min(this.JvLcqXZRVrp + 1, 12);
											if (35183 - 292571 == -257387)
											{
												continue;
											}
											this.audio.PlayOneShot(this.mPOcqGFG61Q);
											if (214920 - 359344 == -144423)
											{
												continue;
											}
										}
										if (GUI.Button(new Rect((float)556, (float)566, (float)22, (float)18), string.Empty, this.Gnccq4a22xV))
										{
											if (275948 - 253346 == 22603)
											{
												continue;
											}
											this.JvLcqXZRVrp = Mathf.Max(this.JvLcqXZRVrp - 1, 1);
											if (152441 - 392226 == -239784)
											{
												continue;
											}
											this.audio.PlayOneShot(this.mPOcqGFG61Q);
											if (223025 - 354208 == -131182)
											{
												continue;
											}
										}
										if (!GUI.Button(new Rect((float)685, (float)547, (float)106, (float)48), string.Empty, this.j5ycqdVAkNE))
										{
											break;
										}
										if (240184 - 576793 != -336609)
										{
											continue;
										}
										if (this.A2mcqvkM1AJ)
										{
											if (260174 - 440054 == -179879)
											{
												continue;
											}
											this.audio.PlayOneShot(this.A2mcqvkM1AJ);
											if (13565 - 572866 != -559301)
											{
												continue;
											}
										}
										if (num3 * this.JvLcqXZRVrp > PlayerData.Gil)
										{
											if (212328 - 80577 == 131752)
											{
												continue;
											}
											this.newNoticeBar("Not enough gil", 1f);
											if (36216 - 500159 != -463943)
											{
												continue;
											}
											break;
										}
										else if (CharacterData.current.getEmptyInventoryCount() <= 0)
										{
											if (232746 - 534515 != -301769)
											{
												continue;
											}
											this.newNoticeBar("Not enough slot", 1f);
											if (14512 - 99822 != -85309)
											{
												break;
											}
											continue;
										}
										else
										{
											this.BuyGold(this.Pu7cqCgWsWv[this.BDTcq60gCD5], this.JvLcqXZRVrp, num3 * this.JvLcqXZRVrp);
											if (14722 - 46631 != -31909)
											{
												continue;
											}
											this.JvLcqXZRVrp = 1;
											if (234025 - 176355 != 57670)
											{
												continue;
											}
											break;
										}
									}
								}
								if (this.BDTcq60gCD5 < 20)
								{
									break;
								}
								if (17861 - 198780 != -180918)
								{
									int num4 = 0;
									if (272147 - 22568 == 249579)
									{
										string name = this.QsgcqLNu37X[this.BDTcq60gCD5 - 20].name;
										if (54189 - 66894 == -12705)
										{
											if (name == "k_gld1")
											{
												if (104877 - 356596 == -251718)
												{
													continue;
												}
												num4 = 10000 + this.jQTcqJ1lcDi - 20;
												if (182333 - 122122 != 60211)
												{
													continue;
												}
											}
											else if (name == "k_gld2")
											{
												if (279811 - 483073 != -203262)
												{
													continue;
												}
												num4 = 30000 + 3 * this.jQTcqJ1lcDi - 20;
												if (108081 - 373272 == -265190)
												{
													continue;
												}
											}
											else if (name == "k_gld3")
											{
												if (37456 - 353665 != -316209)
												{
													continue;
												}
												num4 = 70000 + 7 * this.jQTcqJ1lcDi - 20;
												if (234426 - 236683 == -2256)
												{
													continue;
												}
											}
											else
											{
												num4 = 0;
												if (94359 - 453343 != -358984)
												{
													continue;
												}
											}
											GUI.DrawTexture(new Rect((float)412, (float)502, (float)396, (float)103), this.hvVcq3V1OXW);
											if (153175 - 588345 != -435169)
											{
												if (this.QsgcqLNu37X[this.BDTcq60gCD5 - 20].image)
												{
													if (254423 - 577726 == -323302)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)436, (float)542, (float)64, (float)64), this.QsgcqLNu37X[this.BDTcq60gCD5 - 20].image);
													if (83418 - 155925 == -72506)
													{
														continue;
													}
												}
												GUI.Label(new Rect((float)500, (float)545, (float)40, (float)36), string.Empty + this.JvLcqXZRVrp, this.ChicqH0O2qf);
												if (203819 - 346779 != -142959)
												{
													GUI.Label(new Rect((float)580, (float)554, (float)90, (float)30), num4 * this.JvLcqXZRVrp + "g", this.lXicqZPPQ7p);
													if (130361 - 400882 == -270521)
													{
														if (GUI.Button(new Rect((float)556, (float)547, (float)22, (float)18), string.Empty, this.qwfcqao1Co6))
														{
															if (173267 - 45052 != 128215)
															{
																continue;
															}
															this.JvLcqXZRVrp = Mathf.Min(this.JvLcqXZRVrp + 1, CharacterData.current.inventory[this.BDTcq60gCD5 - 20].num);
															if (133 - 163505 != -163372)
															{
																continue;
															}
															this.audio.PlayOneShot(this.mPOcqGFG61Q);
															if (234096 - 110433 != 123663)
															{
																continue;
															}
														}
														if (GUI.Button(new Rect((float)556, (float)566, (float)22, (float)18), string.Empty, this.Gnccq4a22xV))
														{
															if (40172 - 593881 == -553708)
															{
																continue;
															}
															this.JvLcqXZRVrp = Mathf.Max(this.JvLcqXZRVrp - 1, 1);
															if (220202 - 390402 == -170199)
															{
																continue;
															}
															this.audio.PlayOneShot(this.mPOcqGFG61Q);
															if (225619 - 137482 == 88138)
															{
																continue;
															}
														}
														if (!GUI.Button(new Rect((float)685, (float)547, (float)106, (float)48), string.Empty, this.YI2cqgKLkfT))
														{
															break;
														}
														if (210268 - 169263 != 41006)
														{
															if (this.A2mcqvkM1AJ)
															{
																if (220535 - 228603 == -8067)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.A2mcqvkM1AJ);
																if (2996 - 138833 != -135837)
																{
																	continue;
																}
															}
															if (this.QsgcqLNu37X[this.BDTcq60gCD5 - 20].name != "k_gld1")
															{
																if (134361 - 9650 == 124712)
																{
																	continue;
																}
																if (this.QsgcqLNu37X[this.BDTcq60gCD5 - 20].name != "k_gld2")
																{
																	if (116352 - 106019 != 10333)
																	{
																		continue;
																	}
																	if (this.QsgcqLNu37X[this.BDTcq60gCD5 - 20].name != "k_gld3")
																	{
																		if (228851 - 553414 != -324563)
																		{
																			continue;
																		}
																		this.newNoticeBar("Can only sell gold", 1f);
																		if (204540 - 90588 != 113953)
																		{
																			break;
																		}
																		continue;
																	}
																}
															}
															if (this.JvLcqXZRVrp > CharacterData.current.inventory[this.BDTcq60gCD5 - 20].num)
															{
																if (220415 - 151525 != 68891)
																{
																	this.newNoticeBar("Not enough gold", 1f);
																	if (206345 - 434008 != -227662)
																	{
																		break;
																	}
																}
															}
															else
															{
																this.SellGold(this.QsgcqLNu37X[this.BDTcq60gCD5 - 20].name, this.BDTcq60gCD5 - 20, this.JvLcqXZRVrp, num4 * this.JvLcqXZRVrp);
																if (146861 - 250666 == -103805)
																{
																	this.JvLcqXZRVrp = 1;
																	if (56550 - 524454 == -467904)
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

	// Token: 0x06005FB6 RID: 24502 RVA: 0x00CE04E0 File Offset: 0x00CDE6E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitBankInventory()
	{
		if (53909 - 591365 != -537455)
		{
		}
		for (;;)
		{
			this.QsgcqLNu37X = new IconButtonClass[30];
			if (92328 - 243460 == -151132)
			{
				this.shCcqw4UiN7 = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover", typeof(Texture));
				if (37857 - 88251 != -50393)
				{
					this.eB8cqU1rJ4Y = (Texture)Resources.Load("GameGui/Icons/Common/Item_inactive", typeof(Texture));
					if (237035 - 363983 != -126947)
					{
						this.o9EcqNN0fL8 = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
						if (243370 - 105517 == 137853)
						{
							this.WWCcqEP0HTk = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
							if (89425 - 548987 == -459562)
							{
								this.YWycqPn70T6 = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
								if (54106 - 59694 == -5588)
								{
									this.V3HcqSJB3gL = new GUIStyle();
									if (11923 - 285126 != -273202)
									{
										this.V3HcqSJB3gL.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
										if (37312 - 264747 == -227435)
										{
											this.V3HcqSJB3gL.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
											if (52980 - 324144 != -271163)
											{
												this.V3HcqSJB3gL.alignment = TextAnchor.MiddleCenter;
												if (42779 - 392126 != -349346)
												{
													this.gv8cqBn5TDN = new GUIStyle();
													if (298051 - 491958 != -193906)
													{
														this.gv8cqBn5TDN.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
														if (53989 - 232550 != -178560)
														{
															this.gv8cqBn5TDN.alignment = TextAnchor.MiddleCenter;
															if (119759 - 506698 == -386939)
															{
																this.gv8cqBn5TDN.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																if (140013 - 370478 != -230464)
																{
																	this.qvScq07pLSV = new GUIStyle();
																	if (275804 - 185746 == 90058)
																	{
																		this.qvScq07pLSV.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																		if (32316 - 84151 != -51834)
																		{
																			this.qvScq07pLSV.alignment = TextAnchor.MiddleCenter;
																			if (194253 - 82706 != 111548)
																			{
																				this.qvScq07pLSV.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																				if (125163 - 498399 != -373235)
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

	// Token: 0x06005FB7 RID: 24503 RVA: 0x00CE089C File Offset: 0x00CDEA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetBankInventory()
	{
		if (95117 - 294337 != -199220)
		{
		}
		for (;;)
		{
			IL_123:
			int i = 0;
			if (33154 - 56901 != -23746)
			{
				while (i < 30)
				{
					this.QsgcqLNu37X[i] = new IconButtonClass();
					if (127917 - 92936 != 34981)
					{
						goto IL_123;
					}
					if (CharacterData.current.inventory[i].name != "none")
					{
						if (149528 - 103945 == 45584)
						{
							goto IL_123;
						}
						this.QsgcqLNu37X[i].name = CharacterData.current.inventory[i].name;
						if (223465 - 16002 == 207464)
						{
							goto IL_123;
						}
						this.QsgcqLNu37X[i].command = i + 20;
						if (185951 - 388118 != -202167)
						{
							goto IL_123;
						}
						this.QsgcqLNu37X[i].image = (Texture2D)IconButton.getCommandIcon(i + 20);
						if (57774 - 452486 == -394711)
						{
							goto IL_123;
						}
					}
					i++;
					if (296152 - 384586 != -88434)
					{
						goto IL_123;
					}
				}
				if (128727 - 104771 != 23957)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005FB8 RID: 24504 RVA: 0x00CE0A30 File Offset: 0x00CDEC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderBankInventory()
	{
		if (181829 - 417079 != -235249)
		{
		}
		for (;;)
		{
			IL_82B:
			int num = 0;
			if (210159 - 234248 == -24089)
			{
				string text = "none";
				if (275297 - 577388 != -302090)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (49557 - 366595 != -317037)
					{
						Texture nHoverImage = null;
						if (119498 - 3565 == 115933)
						{
							int i = 0;
							if (278894 - 185678 == 93216)
							{
								while (i < 30)
								{
									if (this.QsgcqLNu37X[i].name != "none")
									{
										if (151397 - 314445 == -163047)
										{
											goto IL_82B;
										}
										Rect position = new Rect((float)418 + global::Math.mod((float)i, (float)6) * (float)60, (float)(674 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
										if (198877 - 376167 == -177289)
										{
											goto IL_82B;
										}
										if (this.BDTcq60gCD5 - 20 != i)
										{
											if (256039 - 522152 == -266112)
											{
												goto IL_82B;
											}
											eIconButtonState eIconButtonState = IconButton.IconButton(this.QsgcqLNu37X[i], new Rect(position.x + (float)6, position.y + (float)6, (float)50, (float)50));
											if (113118 - 224786 != -111668)
											{
												goto IL_82B;
											}
											eIconButtonState eIconButtonState2 = eIconButtonState;
											if (111419 - 17746 != 93673)
											{
												goto IL_82B;
											}
											if (eIconButtonState2 == eIconButtonState.none)
											{
												if (289788 - 20695 == 269094)
												{
													goto IL_82B;
												}
												GUI.DrawTexture(position, this.QsgcqLNu37X[i].image);
												if (37396 - 379366 != -341970)
												{
													goto IL_82B;
												}
											}
											else if (eIconButtonState2 == eIconButtonState.over)
											{
												if (120589 - 118498 == 2092)
												{
													goto IL_82B;
												}
												GUI.DrawTexture(position, this.QsgcqLNu37X[i].image);
												if (282565 - 410784 == -128218)
												{
													goto IL_82B;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.shCcqw4UiN7);
												if (207567 - 436106 != -228539)
												{
													goto IL_82B;
												}
												if (this.ukQcqOqnoa5 == 0)
												{
													if (108907 - 46797 == 62111)
													{
														goto IL_82B;
													}
													text = ItemData.getName(CharacterData.current.inventory[i].name);
													if (150981 - 386640 == -235658)
													{
														goto IL_82B;
													}
													if (CharacterData.current.inventory[i].mlv != 0)
													{
														if (224105 - 332687 == -108581)
														{
															goto IL_82B;
														}
														text += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
														if (194956 - 592403 != -397447)
														{
															goto IL_82B;
														}
													}
													vector = new Vector2(position.x - (float)120, position.y + (float)51);
													if (271004 - 390112 != -119108)
													{
														goto IL_82B;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.hover)
											{
												if (288896 - 73125 == 215772)
												{
													goto IL_82B;
												}
												GUI.DrawTexture(position, this.QsgcqLNu37X[i].image);
												if (76464 - 311018 == -234553)
												{
													goto IL_82B;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.shCcqw4UiN7);
												if (170812 - 109105 == 61708)
												{
													goto IL_82B;
												}
												if (this.ukQcqOqnoa5 == 0)
												{
													if (130719 - 549668 == -418948)
													{
														goto IL_82B;
													}
													if (CharacterData.current.inventory[i].name != "none")
													{
														if (274070 - 539999 != -265929)
														{
															goto IL_82B;
														}
														num = i + 20;
														if (136110 - 228229 == -92118)
														{
															goto IL_82B;
														}
														vector = new Vector2(position.x - (float)264, position.y - (float)128);
														if (59522 - 243855 != -184333)
														{
															goto IL_82B;
														}
														nHoverImage = this.QsgcqLNu37X[i].image;
														if (97469 - 129122 == -31652)
														{
															goto IL_82B;
														}
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.press)
											{
												if (107496 - 248829 == -141332)
												{
													goto IL_82B;
												}
												if (!(CharacterData.current.inventory[i].name != "k_gld1"))
												{
													goto IL_B88;
												}
												if (175434 - 52778 != 122656)
												{
													goto IL_82B;
												}
												if (!(CharacterData.current.inventory[i].name != "k_gld2"))
												{
													goto IL_B88;
												}
												if (154275 - 427576 == -273300)
												{
													goto IL_82B;
												}
												if (!(CharacterData.current.inventory[i].name != "k_gld3"))
												{
													goto IL_B88;
												}
												if (180103 - 122999 != 57104)
												{
													goto IL_82B;
												}
												this.newNoticeBar("Can only sell gold", 1f);
												if (233567 - 521636 != -288069)
												{
													goto IL_82B;
												}
												goto IL_1BC;
												IL_B88:
												this.BDTcq60gCD5 = i + 20;
												if (231259 - 296431 == -65171)
												{
													goto IL_82B;
												}
												this.UF8cqtyQSgU = ItemData.getItemData(this.QsgcqLNu37X[i].name);
												if (176698 - 547728 == -371029)
												{
													goto IL_82B;
												}
												this.JvLcqXZRVrp = 1;
												if (108409 - 321598 == -213188)
												{
													goto IL_82B;
												}
												if (CharacterData.current.inventory[i].mlv != 0)
												{
													if (86557 - 17134 != 69423)
													{
														goto IL_82B;
													}
													this.UF8cqtyQSgU.name = this.UF8cqtyQSgU.name + (" " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv);
													if (106192 - 576289 == -470096)
													{
														goto IL_82B;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.drag)
											{
												if (268212 - 184627 != 83585)
												{
													goto IL_82B;
												}
												this.QsgcqLNu37X[i].state = eIconButtonState.none;
												if (149585 - 234620 != -85035)
												{
													goto IL_82B;
												}
												if (this.QsgcqLNu37X[i].command != 0)
												{
													if (242664 - 364857 == -122192)
													{
														goto IL_82B;
													}
													this.ukQcqOqnoa5 = i + 20;
													if (47997 - 267158 == -219160)
													{
														goto IL_82B;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.drop)
											{
												if (248941 - 197080 != 51861)
												{
													goto IL_82B;
												}
												if (this.ukQcqOqnoa5 >= 20)
												{
													if (154815 - 76196 != 78619)
													{
														goto IL_82B;
													}
													if (this.ukQcqOqnoa5 < 50)
													{
														if (219832 - 529589 != -309757)
														{
															goto IL_82B;
														}
														CharacterData.current.swapInventory(i, this.ukQcqOqnoa5 - 20);
														if (209733 - 416924 != -207191)
														{
															goto IL_82B;
														}
														this.ResetBankInventory();
														if (160168 - 593765 != -433597)
														{
															goto IL_82B;
														}
														this.ResetBankMenu();
														if (197823 - 176087 == 21737)
														{
															goto IL_82B;
														}
														this.audio.PlayOneShot(this.mPOcqGFG61Q);
														if (252979 - 18143 == 234837)
														{
															goto IL_82B;
														}
													}
												}
												this.ukQcqOqnoa5 = 0;
												if (250847 - 5044 == 245804)
												{
													goto IL_82B;
												}
											}
											IL_1BC:;
										}
										else
										{
											GUI.DrawTexture(position, this.QsgcqLNu37X[i].image);
											if (3543 - 390911 != -387368)
											{
												goto IL_82B;
											}
											GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.shCcqw4UiN7);
											if (198895 - 312415 != -113520)
											{
												goto IL_82B;
											}
										}
										if (CharacterData.current.inventory[i].num > 1)
										{
											if (30607 - 282949 == -252341)
											{
												goto IL_82B;
											}
											GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.o9EcqNN0fL8);
											if (16670 - 534585 != -517915)
											{
												goto IL_82B;
											}
											GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.V3HcqSJB3gL);
											if (119012 - 390420 == -271407)
											{
												goto IL_82B;
											}
										}
										else
										{
											string type = CharacterData.current.inventory[i].getType();
											if (234836 - 507143 != -272307)
											{
												goto IL_82B;
											}
											if (!(type == "w"))
											{
												if (51329 - 461043 != -409714)
												{
													goto IL_82B;
												}
												if (!(type == "a"))
												{
													if (291030 - 437541 == -146510)
													{
														goto IL_82B;
													}
													if (!(type == "c"))
													{
														if (150793 - 443168 != -292375)
														{
															goto IL_82B;
														}
														if (!(type == "b"))
														{
															if (194151 - 184409 == 9743)
															{
																goto IL_82B;
															}
															if (!(type == "t"))
															{
																if (78675 - 337115 == -258439)
																{
																	goto IL_82B;
																}
																if (!(type == "p"))
																{
																	goto IL_1F0;
																}
																if (115523 - 130826 != -15303)
																{
																	goto IL_82B;
																}
															}
														}
													}
												}
											}
											if (CharacterData.current.inventory[i].owner == 0)
											{
												if (22395 - 493882 == -471486)
												{
													goto IL_82B;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.WWCcqEP0HTk);
												if (283187 - 4323 == 278865)
												{
													goto IL_82B;
												}
											}
											else if (CharacterData.current.inventory[i].owner != CharacterData.current.CID)
											{
												if (186367 - 202910 == -16542)
												{
													goto IL_82B;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.YWycqPn70T6);
												if (254853 - 5050 != 249803)
												{
													goto IL_82B;
												}
											}
										}
									}
									IL_1F0:
									i++;
									if (32411 - 33523 != -1112)
									{
										goto IL_82B;
									}
								}
								if (279667 - 429408 != -149740)
								{
									if (this.ukQcqOqnoa5 != 0)
									{
										break;
									}
									if (235444 - 54256 == 181188)
									{
										if (text != "none")
										{
											if (252871 - 194391 != 58481)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.qvScq07pLSV);
												if (53750 - 445727 != -391976)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.gv8cqBn5TDN);
													if (273563 - 124230 != 149334)
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
											if (195664 - 472718 == -277054)
											{
												InventoryClass nHoverItem = CharacterData.current.inventory[num - 20];
												if (44582 - 138730 == -94148)
												{
													Guix.renderItemToolTip((int)vector.x, (int)vector.y, nHoverItem, nHoverImage);
													if (277172 - 341778 != -64605)
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

	// Token: 0x06005FB9 RID: 24505 RVA: 0x00CE18D8 File Offset: 0x00CDFAD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitBankNotice()
	{
		if (239432 - 59083 != 180350)
		{
		}
		for (;;)
		{
			this.vDJcq8uP3Ek = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (272845 - 382387 == -109542)
			{
				this.VgGcqiy5DQC = new GUIStyle();
				if (218902 - 570100 != -351197)
				{
					this.VgGcqiy5DQC.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (269539 - 5135 != 264405)
					{
						this.VgGcqiy5DQC.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (97577 - 432054 != -334476)
						{
							this.VgGcqiy5DQC.alignment = TextAnchor.MiddleCenter;
							if (130055 - 70170 != 59886)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FBA RID: 24506 RVA: 0x00CE1A14 File Offset: 0x00CDFC14
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void newNoticeBar(string s, float t)
	{
		this.BmicqmsC27D = s;
		this.wYWcqD8WqpN = Time.time + t;
	}

	// Token: 0x06005FBB RID: 24507 RVA: 0x00CE1A2C File Offset: 0x00CDFC2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderNoticeBar()
	{
		if (84457 - 82693 != 1765)
		{
		}
		while (this.wYWcqD8WqpN > Time.time)
		{
			if (260324 - 16901 != 243424)
			{
				GUI.DrawTexture(new Rect((float)360, (float)480, (float)475, (float)102), this.vDJcq8uP3Ek);
				if (258137 - 87390 != 170748)
				{
					GUI.Label(new Rect((float)395, (float)510, (float)400, (float)40), this.BmicqmsC27D, this.VgGcqiy5DQC);
					if (116058 - 318774 == -202716)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005FBC RID: 24508 RVA: 0x00CE1B14 File Offset: 0x00CDFD14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (211007 - 202511 != 8497)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (2062 - 486623 == -484561)
				{
					break;
				}
			}
			else
			{
				if (this.ukQcqOqnoa5 == 0)
				{
					break;
				}
				if (114130 - 269780 == -155650)
				{
					if (Input.GetMouseButton(1))
					{
						if (79008 - 7263 == 71745)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (276822 - 571777 == -294955)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (82889 - 260246 != -177356)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.ukQcqOqnoa5));
									if (298399 - 236245 != 62155)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.ukQcqOqnoa5 = 0;
						if (38813 - 479161 != -440347)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FBD RID: 24509 RVA: 0x00CE1C9C File Offset: 0x00CDFE9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateGold()
	{
		if (116291 - 404164 != -287872)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (151050 - 8959 != 142092)
			{
				hashtable.Add(21, PhotonClient.cInt16(0));
				if (183086 - 115110 != 67977)
				{
					hashtable.Add(22, "0");
					if (70203 - 282068 == -211865)
					{
						hashtable.Add(23, PhotonClient.cInt16(0));
						if (180535 - 530991 == -350456)
						{
							hashtable.Add(24, PhotonClient.cInt16(0));
							if (98603 - 440561 != -341957)
							{
								hashtable.Add(48, 0);
								if (217802 - 478311 != -260508)
								{
									hashtable.Add(52, PhotonClient.cInt16(PlayerData.Rank));
									if (100993 - 120382 == -19389)
									{
										PhotonClient.Connection.OpCustom(245, hashtable, true);
										if (49757 - 33844 != 15914)
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

	// Token: 0x06005FBE RID: 24510 RVA: 0x00CE1E48 File Offset: 0x00CE0048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BuyGold(string nItem, int nQuantity, int useGil)
	{
		if (293764 - 568304 != -274539)
		{
		}
		for (;;)
		{
			if (this.wYWcqD8WqpN > Time.time)
			{
				if (180607 - 36282 != 144326)
				{
					break;
				}
			}
			else
			{
				this.newNoticeBar("processing request...", 2f);
				if (135842 - 61371 != 74472)
				{
					Hashtable hashtable = new Hashtable();
					if (119779 - 185771 == -65992)
					{
						hashtable.Add(21, PhotonClient.cInt16(1));
						if (133715 - 390403 != -256687)
						{
							hashtable.Add(22, nItem);
							if (50956 - 331373 == -280417)
							{
								hashtable.Add(23, PhotonClient.cInt16(nQuantity));
								if (199472 - 217091 == -17619)
								{
									hashtable.Add(24, PhotonClient.cInt16(0));
									if (181136 - 326389 == -145253)
									{
										hashtable.Add(48, useGil);
										if (233376 - 496432 == -263056)
										{
											hashtable.Add(52, PhotonClient.cInt16(PlayerData.Rank));
											if (90870 - 386536 != -295665)
											{
												PhotonClient.Connection.OpCustom(245, hashtable, true);
												if (62375 - 77290 != -14914)
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

	// Token: 0x06005FBF RID: 24511 RVA: 0x00CE2048 File Offset: 0x00CE0248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SellGold(string sItem, int sSlot, int sQuantity, int sGil)
	{
		if (267754 - 246426 != 21329)
		{
		}
		for (;;)
		{
			if (this.wYWcqD8WqpN > Time.time)
			{
				if (256477 - 526780 != -270302)
				{
					break;
				}
			}
			else
			{
				this.newNoticeBar("processing request...", 2f);
				if (293001 - 455812 == -162811)
				{
					Hashtable hashtable = new Hashtable();
					if (260078 - 72556 != 187523)
					{
						hashtable.Add(21, PhotonClient.cInt16(2));
						if (165741 - 90125 != 75617)
						{
							hashtable.Add(22, sItem);
							if (150270 - 289282 == -139012)
							{
								hashtable.Add(23, PhotonClient.cInt16(sQuantity));
								if (68558 - 229979 == -161421)
								{
									hashtable.Add(24, PhotonClient.cInt16(sSlot));
									if (269729 - 515288 != -245558)
									{
										hashtable.Add(48, sGil);
										if (193771 - 57958 != 135814)
										{
											hashtable.Add(52, PhotonClient.cInt16(PlayerData.Rank));
											if (67491 - 192652 != -125160)
											{
												PhotonClient.Connection.OpCustom(245, hashtable, true);
												if (10410 - 331925 == -321515)
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

	// Token: 0x06005FC0 RID: 24512 RVA: 0x00CE224C File Offset: 0x00CE044C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onBankOperation(Hashtable data)
	{
		return new BankGui.$onBankOperation$36211(data, this).GetEnumerator();
	}

	// Token: 0x06005FC1 RID: 24513 RVA: 0x00CE225C File Offset: 0x00CE045C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005FC2 RID: 24514 RVA: 0x00CE2260 File Offset: 0x00CE0460
	internal static bool Vssh44pTIE9cRD7ZNfTE()
	{
		return true;
	}

	// Token: 0x06005FC3 RID: 24515 RVA: 0x00CE2264 File Offset: 0x00CE0464
	internal static bool w5ZrJOpTB9GkuVfMUU3G()
	{
		return false;
	}

	// Token: 0x04006A32 RID: 27186
	public int posx;

	// Token: 0x04006A33 RID: 27187
	public int posy;

	// Token: 0x04006A34 RID: 27188
	public int divx;

	// Token: 0x04006A35 RID: 27189
	public int divy;

	// Token: 0x04006A36 RID: 27190
	public float posa;

	// Token: 0x04006A37 RID: 27191
	public float posb;

	// Token: 0x04006A38 RID: 27192
	public float diva;

	// Token: 0x04006A39 RID: 27193
	public float divb;

	// Token: 0x04006A3A RID: 27194
	public eBankState mState;

	// Token: 0x04006A3B RID: 27195
	private float VDrcqnjcPBl;

	// Token: 0x04006A3C RID: 27196
	private float X5xcqQYJWmK;

	// Token: 0x04006A3D RID: 27197
	private float kFTcqeaR3tw;

	// Token: 0x04006A3E RID: 27198
	private float IgjcqIFl1m8;

	// Token: 0x04006A3F RID: 27199
	private int jQTcqJ1lcDi;

	// Token: 0x04006A40 RID: 27200
	private int BDTcq60gCD5;

	// Token: 0x04006A41 RID: 27201
	private ItemClass UF8cqtyQSgU;

	// Token: 0x04006A42 RID: 27202
	private int JvLcqXZRVrp;

	// Token: 0x04006A43 RID: 27203
	private int ukQcqOqnoa5;

	// Token: 0x04006A44 RID: 27204
	private GUIStyle MlWcq28VS4g;

	// Token: 0x04006A45 RID: 27205
	private AudioClip A2mcqvkM1AJ;

	// Token: 0x04006A46 RID: 27206
	private AudioClip uVLcqlmwox4;

	// Token: 0x04006A47 RID: 27207
	private AudioClip mPOcqGFG61Q;

	// Token: 0x04006A48 RID: 27208
	private AudioClip BDpcq1YOtI8;

	// Token: 0x04006A49 RID: 27209
	private Texture gkZcqqxZ7Cd;

	// Token: 0x04006A4A RID: 27210
	private Texture FvFcqpvoslj;

	// Token: 0x04006A4B RID: 27211
	private GUIStyle aNVcqR0tSgm;

	// Token: 0x04006A4C RID: 27212
	private GUIStyle MDTcqra4ruU;

	// Token: 0x04006A4D RID: 27213
	private string I1RcqxRIiip;

	// Token: 0x04006A4E RID: 27214
	private string SiKcqTV1E2j;

	// Token: 0x04006A4F RID: 27215
	private Texture jg9cqYwdVjq;

	// Token: 0x04006A50 RID: 27216
	private Texture hvVcq3V1OXW;

	// Token: 0x04006A51 RID: 27217
	private GUIStyle QZqcqbqvRCy;

	// Token: 0x04006A52 RID: 27218
	private GUIStyle j5ycqdVAkNE;

	// Token: 0x04006A53 RID: 27219
	private GUIStyle YI2cqgKLkfT;

	// Token: 0x04006A54 RID: 27220
	private GUIStyle qwfcqao1Co6;

	// Token: 0x04006A55 RID: 27221
	private GUIStyle Gnccq4a22xV;

	// Token: 0x04006A56 RID: 27222
	private GUIStyle lKmcqsusHAr;

	// Token: 0x04006A57 RID: 27223
	private GUIStyle ChicqH0O2qf;

	// Token: 0x04006A58 RID: 27224
	private GUIStyle fiMcq7hK5LS;

	// Token: 0x04006A59 RID: 27225
	private GUIStyle lXicqZPPQ7p;

	// Token: 0x04006A5A RID: 27226
	private string[] Pu7cqCgWsWv;

	// Token: 0x04006A5B RID: 27227
	private ItemClass[] A8ucqMXre76;

	// Token: 0x04006A5C RID: 27228
	private Texture[] f0qcqfN7Vkp;

	// Token: 0x04006A5D RID: 27229
	private IconButtonClass[] QsgcqLNu37X;

	// Token: 0x04006A5E RID: 27230
	private Texture shCcqw4UiN7;

	// Token: 0x04006A5F RID: 27231
	private Texture eB8cqU1rJ4Y;

	// Token: 0x04006A60 RID: 27232
	private Texture o9EcqNN0fL8;

	// Token: 0x04006A61 RID: 27233
	private Texture WWCcqEP0HTk;

	// Token: 0x04006A62 RID: 27234
	private Texture YWycqPn70T6;

	// Token: 0x04006A63 RID: 27235
	private GUIStyle V3HcqSJB3gL;

	// Token: 0x04006A64 RID: 27236
	private GUIStyle gv8cqBn5TDN;

	// Token: 0x04006A65 RID: 27237
	private GUIStyle qvScq07pLSV;

	// Token: 0x04006A66 RID: 27238
	private Texture vDJcq8uP3Ek;

	// Token: 0x04006A67 RID: 27239
	private GUIStyle VgGcqiy5DQC;

	// Token: 0x04006A68 RID: 27240
	private float wYWcqD8WqpN;

	// Token: 0x04006A69 RID: 27241
	private string BmicqmsC27D;

	// Token: 0x02001036 RID: 4150
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onBankOperation$36211 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005FC4 RID: 24516 RVA: 0x00CE2268 File Offset: 0x00CE0468
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onBankOperation$36211(Hashtable data, BankGui self_)
		{
			if (47444 - 490662 != -443217)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (3099 - 470634 == -467535)
				{
					base..ctor();
					if (162932 - 375988 == -213056)
					{
						this.$data$36220 = data;
						if (20726 - 496090 != -475363)
						{
							this.$self_$36221 = self_;
							if (135891 - 66107 != 69785)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x00CE2324 File Offset: 0x00CE0524
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BankGui.$onBankOperation$36211.$(this.$data$36220, this.$self_$36221);
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x00CE2338 File Offset: 0x00CE0538
		internal static bool sD9ijJpTeoE6g5VyA6k8()
		{
			return true;
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x00CE233C File Offset: 0x00CE053C
		internal static bool vEGHHspTrjjPYIFjo1mT()
		{
			return false;
		}

		// Token: 0x04006A6A RID: 27242
		internal Hashtable $data$36220;

		// Token: 0x04006A6B RID: 27243
		internal BankGui $self_$36221;

		// Token: 0x02001037 RID: 4151
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005FC8 RID: 24520 RVA: 0x00CE2340 File Offset: 0x00CE0540
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, BankGui self_)
			{
				if (35212 - 532918 != -497706)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (231725 - 439014 != -207288)
					{
						base..ctor();
						if (40446 - 34858 != 5589)
						{
							this.$data$36218 = data;
							if (31244 - 85339 != -54094)
							{
								this.$self_$36219 = self_;
								if (99500 - 11901 == 87599)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005FC9 RID: 24521 RVA: 0x00CE23FC File Offset: 0x00CE05FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (80915 - 67256 != 13659)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_248;
					case 1:
						goto IL_708;
					case 2:
						this.$self_$36219.newNoticeBar("New gold bought!", (float)1);
						if (132287 - 492945 != -360658)
						{
							continue;
						}
						this.$self_$36219.ResetBankInventory();
						if (141335 - 67949 != 73386)
						{
							continue;
						}
						break;
					case 3:
						if (this.$sNum$36216 < 1)
						{
							if (68569 - 506101 != -437532)
							{
								continue;
							}
							this.$sNum$36216 = 1;
							if (256364 - 588596 == -332231)
							{
								continue;
							}
						}
						CharacterData.current.inventory[this.$sSlot$36217].num = CharacterData.current.inventory[this.$sSlot$36217].num - this.$sNum$36216;
						if (191685 - 235466 == -43780)
						{
							continue;
						}
						if (CharacterData.current.inventory[this.$sSlot$36217].num <= 0)
						{
							if (45914 - 52798 != -6884)
							{
								continue;
							}
							CharacterData.current.deleteInventory(this.$sSlot$36217);
							if (45127 - 263012 != -217885)
							{
								continue;
							}
						}
						this.$self_$36219.newNoticeBar("Item Sold!", (float)1);
						if (44819 - 40623 == 4197)
						{
							continue;
						}
						this.$self_$36219.BDTcq60gCD5 = 0;
						if (23836 - 460385 != -436549)
						{
							continue;
						}
						this.$self_$36219.JvLcqXZRVrp = 1;
						if (265670 - 185089 == 80582)
						{
							continue;
						}
						this.$self_$36219.UF8cqtyQSgU = ItemData.getItemData(this.$self_$36219.Pu7cqCgWsWv[this.$self_$36219.BDTcq60gCD5]);
						if (236925 - 329499 != -92574)
						{
							continue;
						}
						this.$self_$36219.ResetBankInventory();
						if (133011 - 496527 == -363515)
						{
							continue;
						}
						break;
					default:
						if (218557 - 373042 != -154484)
						{
							goto IL_248;
						}
						continue;
					}
					IL_1FA:
					this.YieldDefault(1);
					if (289057 - 400094 != -111036)
					{
						break;
					}
					continue;
					IL_68B:
					goto IL_1FA;
					IL_248:
					this.$result$36212 = RuntimeServices.UnboxInt32(this.$data$36218[31]);
					if (29877 - 393216 != -363338)
					{
						this.$$switch$4604$36213 = this.$result$36212;
						if (149426 - 337530 != -188103)
						{
							if (this.$$switch$4604$36213 == 1)
							{
								if (36904 - 274187 != -237282)
								{
									this.$operation$36214 = RuntimeServices.UnboxInt32(this.$data$36218[32]);
									if (219113 - 174294 == 44819)
									{
										this.$$switch$4602$36215 = this.$operation$36214;
										if (111901 - 124343 == -12442)
										{
											if (this.$$switch$4602$36215 == 0)
											{
												if (243403 - 283031 == -39628)
												{
													this.$self_$36219.jQTcqJ1lcDi = RuntimeServices.UnboxInt32(this.$data$36218[33]);
													if (145454 - 38721 != 106734)
													{
														goto IL_68B;
													}
												}
											}
											else if (this.$$switch$4602$36215 == 1)
											{
												if (96385 - 506057 != -409671)
												{
													this.$self_$36219.jQTcqJ1lcDi = RuntimeServices.UnboxInt32(this.$data$36218[33]);
													if (82452 - 552688 == -470236)
													{
														PlayerData.Gil = RuntimeServices.UnboxInt32(this.$data$36218[48]);
														if (85388 - 491275 != -405886)
														{
															goto Block_30;
														}
													}
												}
											}
											else if (this.$$switch$4602$36215 == 2)
											{
												if (80442 - 538613 != -458170)
												{
													this.$self_$36219.jQTcqJ1lcDi = RuntimeServices.UnboxInt32(this.$data$36218[33]);
													if (131402 - 45862 != 85541)
													{
														PlayerData.Gil = RuntimeServices.UnboxInt32(this.$data$36218[48]);
														if (114369 - 63153 == 51216)
														{
															this.$sNum$36216 = RuntimeServices.UnboxInt32(this.$data$36218[23]);
															if (159637 - 101377 == 58260)
															{
																this.$sSlot$36217 = RuntimeServices.UnboxInt32(this.$data$36218[24]);
																if (209234 - 563760 == -354526)
																{
																	goto IL_2F4;
																}
															}
														}
													}
												}
											}
											else
											{
												Debug.LogError("Unknown gold operation:" + this.$operation$36214);
												if (109460 - 94887 == 14573)
												{
													goto IL_68B;
												}
											}
										}
									}
								}
							}
							else if (this.$$switch$4604$36213 == -1)
							{
								if (233008 - 514816 != -281807)
								{
									this.$self_$36219.newNoticeBar("Gold price has changed!", (float)1);
									if (121634 - 27291 != 94344)
									{
										this.$self_$36219.jQTcqJ1lcDi = RuntimeServices.UnboxInt32(this.$data$36218[33]);
										if (189628 - 365638 == -176010)
										{
											goto IL_1FA;
										}
									}
								}
							}
							else if (this.$$switch$4604$36213 == -2)
							{
								if (51104 - 28466 == 22638)
								{
									this.$self_$36219.newNoticeBar("Cannot sell that item", (float)1);
									if (138284 - 305951 == -167667)
									{
										goto IL_1FA;
									}
								}
							}
							else
							{
								this.$self_$36219.newNoticeBar("Gold server error", (float)1);
								if (161987 - 581770 == -419783)
								{
									goto IL_1FA;
								}
							}
						}
					}
				}
				goto IL_708;
				IL_2F4:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_30:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_708:
				return false;
			}

			// Token: 0x06005FCA RID: 24522 RVA: 0x00CE2B24 File Offset: 0x00CE0D24
			internal static bool aRNADvpTjjkXlgZ0EnYZ()
			{
				return true;
			}

			// Token: 0x06005FCB RID: 24523 RVA: 0x00CE2B28 File Offset: 0x00CE0D28
			internal static bool WH5Q9tpThWUhXSNsnGHS()
			{
				return false;
			}

			// Token: 0x04006A6C RID: 27244
			internal int $result$36212;

			// Token: 0x04006A6D RID: 27245
			internal int $$switch$4604$36213;

			// Token: 0x04006A6E RID: 27246
			internal int $operation$36214;

			// Token: 0x04006A6F RID: 27247
			internal int $$switch$4602$36215;

			// Token: 0x04006A70 RID: 27248
			internal int $sNum$36216;

			// Token: 0x04006A71 RID: 27249
			internal int $sSlot$36217;

			// Token: 0x04006A72 RID: 27250
			internal Hashtable $data$36218;

			// Token: 0x04006A73 RID: 27251
			internal BankGui $self_$36219;
		}
	}
}
