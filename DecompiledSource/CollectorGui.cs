using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001044 RID: 4164
[Serializable]
public class CollectorGui : MonoBehaviour
{
	// Token: 0x06006002 RID: 24578 RVA: 0x00CE7598 File Offset: 0x00CE5798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CollectorGui()
	{
		if (118394 - 232255 != -113860)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (271191 - 447073 == -175882)
			{
				base..ctor();
				if (296005 - 183356 != 112650)
				{
					this.mState = eCollectorState.init;
					if (168335 - 469352 == -301017)
					{
						this.PcycpsymjOM = eCollectorTab.item;
						if (116215 - 464829 != -348613)
						{
							this.an4cp7Ln50Y = -1;
							if (78561 - 292011 != -213449)
							{
								this.dqncR2hfC6U = string.Empty;
								if (95673 - 156626 != -60952)
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

	// Token: 0x06006003 RID: 24579 RVA: 0x00CE7698 File Offset: 0x00CE5898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (21147 - 21186 != -38)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (295898 - 415282 != -119383)
			{
				if (this.mState == eCollectorState.init)
				{
					if (143101 - 281782 != -138681)
					{
						continue;
					}
					this.InitCollectorGui();
					if (130436 - 593914 != -463478)
					{
						continue;
					}
					this.InitNPC();
					if (221790 - 377442 == -155651)
					{
						continue;
					}
					this.InitCollectorMenu();
					if (202148 - 14615 == 187534)
					{
						continue;
					}
					this.InitCollectorInventory();
					if (209472 - 72534 != 136938)
					{
						continue;
					}
					this.InitCollectorNotice();
					if (238792 - 282968 != -44176)
					{
						continue;
					}
				}
				this.ResetNPC();
				if (297888 - 66704 == 231184)
				{
					this.ResetCollectorMenu();
					if (256211 - 415490 == -159279)
					{
						this.ResetCollectorInventory();
						if (225947 - 26298 != 199650)
						{
							this.j6Icp4EQVlc = 1f;
							if (203776 - 51105 == 152671)
							{
								this.mState = eCollectorState.open;
								if (152490 - 119037 == 33453)
								{
									this.LsWcpdWNHOP = Time.time;
									if (85094 - 476799 != -391704)
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

	// Token: 0x06006004 RID: 24580 RVA: 0x00CE7884 File Offset: 0x00CE5A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (163756 - 448511 != -284755)
		{
		}
		for (;;)
		{
			if (this.mState <= eCollectorState.init)
			{
				if (127105 - 37471 == 89634)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (89173 - 347445 != -258271)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (93523 - 450086 != -356562)
					{
						this.LhqcpgVeWTb = (float)(1024 * Screen.width / Screen.height);
						if (37672 - 62679 == -25007)
						{
							this.dU6cpamugfc = (float)Screen.height / 1024f;
							if (277107 - 529117 == -252010)
							{
								this.RenderCollectorGui();
								if (183450 - 471152 != -287701)
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

	// Token: 0x06006005 RID: 24581 RVA: 0x00CE79D4 File Offset: 0x00CE5BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCollectorGui()
	{
		if (115212 - 197610 != -82397)
		{
		}
		for (;;)
		{
			this.mMvcpCDfc9j = new GUIStyle();
			if (72766 - 508357 == -435591)
			{
				this.mMvcpCDfc9j.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
				if (138265 - 325993 != -187727)
				{
					this.TaPcpMZhW3Y = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
					if (145528 - 553159 != -407630)
					{
						this.e35cpf15SmP = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
						if (203473 - 396123 == -192650)
						{
							this.fckcpLjU6eX = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
							if (21578 - 422601 != -401022)
							{
								this.DcacpwrmqEl = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
								if (58548 - 256456 != -197907)
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

	// Token: 0x06006006 RID: 24582 RVA: 0x00CE7B60 File Offset: 0x00CE5D60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCollectorGui()
	{
		if (146576 - 37973 != 108604)
		{
		}
		for (;;)
		{
			float num = Time.time - this.LsWcpdWNHOP;
			if (49913 - 577589 == -527676)
			{
				eCollectorState eCollectorState = this.mState;
				if (241467 - 210362 != 31106)
				{
					if (eCollectorState == eCollectorState.init)
					{
						if (274752 - 183097 != 91656)
						{
							break;
						}
					}
					else if (eCollectorState == eCollectorState.open)
					{
						if (194572 - 546758 != -352185)
						{
							if (num <= 0.5f)
							{
								if (295629 - 67470 != 228160)
								{
									this.j6Icp4EQVlc = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (188718 - 280537 == -91819)
									{
										this.RenderNPC();
										if (201598 - 218034 != -16435)
										{
											GUI.DrawTexture(new Rect(0.5f * this.LhqcpgVeWTb - (float)336, (float)724 + this.j6Icp4EQVlc * (float)300, (float)836, (float)196), this.pMycpN9nDYC);
											if (70009 - 394407 == -324398)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (293100 - 107461 == 185639)
								{
									this.j6Icp4EQVlc = (float)0;
									if (184382 - 302551 == -118169)
									{
										this.RenderNPC();
										if (2099 - 101302 != -99202)
										{
											GUI.BeginGroup(new Rect(0.5f * this.LhqcpgVeWTb - (float)350, (float)724, (float)850, (float)200));
											if (141685 - 106634 != 35052)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.pMycpN9nDYC);
												if (174475 - 489592 == -315117)
												{
													GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Peddo", this.RH2cpEvNNGp);
													if (295982 - 299308 != -3325)
													{
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.R66cpSyEiP6, num - 0.5f), this.yekcpPtC2bv);
														if (69894 - 200375 == -130481)
														{
															GUI.EndGroup();
															if (34285 - 4362 == 29923)
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
								this.j6Icp4EQVlc = (float)0;
								if (104725 - 174503 == -69778)
								{
									this.RenderNPC();
									if (264497 - 197981 == 66516)
									{
										this.mState = eCollectorState.collectormenu;
										if (110150 - 70928 == 39222)
										{
											this.LsWcpdWNHOP = Time.time;
											if (171295 - 137848 == 33447)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (eCollectorState == eCollectorState.collectormenu)
					{
						if (209926 - 297946 != -88019)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.LhqcpgVeWTb - (float)400) / this.LhqcpgVeWTb, (float)1);
							if (98172 - 585219 == -487047)
							{
								GUI.BeginGroup(new Rect(this.LhqcpgVeWTb - (float)850, (float)0, (float)850, (float)1024));
								if (246549 - 416584 != -170034)
								{
									GUI.DrawTexture(new Rect((float)300, (float)0, (float)550, (float)1024), this.C3ecp0lXabm);
									if (64803 - 583527 == -518724)
									{
										Guix.renderSmallNumber(532, 64, PlayerData.Gil, false, (float)1);
										if (101758 - 5116 == 96642)
										{
											Guix.renderSmallNumber(730, 64, PlayerData.Jil, false, (float)1);
											if (205002 - 193332 != 11671)
											{
												this.RenderCollectorMenu();
												if (157552 - 195096 != -37543)
												{
													this.RenderCollectorInventory();
													if (78990 - 177435 == -98445)
													{
														this.RenderNoticeBar();
														if (24373 - 249094 == -224721)
														{
															if (GUI.Button(new Rect((float)401, (float)1, (float)57, (float)52), string.Empty, this.mMvcpCDfc9j))
															{
																if (115251 - 47454 != 67797)
																{
																	continue;
																}
																this.mState = eCollectorState.close;
																if (83285 - 554910 == -471624)
																{
																	continue;
																}
																this.LsWcpdWNHOP = Time.time;
																if (195928 - 258511 == -62582)
																{
																	continue;
																}
																this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
																if (200315 - 309435 != -109120)
																{
																	continue;
																}
																if (this.DcacpwrmqEl)
																{
																	if (218024 - 255508 != -37484)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.DcacpwrmqEl);
																	if (206434 - 252039 != -45605)
																	{
																		continue;
																	}
																}
															}
															GUI.EndGroup();
															if (285816 - 6768 != 279049)
															{
																this.RenderNPC();
																if (103055 - 322156 != -219100)
																{
																	this.RenderDragIcon();
																	if (199788 - 290444 == -90656)
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
						if (eCollectorState != eCollectorState.close)
						{
							break;
						}
						if (271589 - 396026 != -124436)
						{
							if (num <= (float)2)
							{
								if (83467 - 406101 == -322634)
								{
									this.RenderNPC();
									if (295073 - 267025 == 28048)
									{
										GUI.BeginGroup(new Rect(0.5f * this.LhqcpgVeWTb - (float)350, (float)724, (float)850, (float)200));
										if (220100 - 68233 == 151867)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.pMycpN9nDYC);
											if (115461 - 199387 != -83925)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Peddo", this.RH2cpEvNNGp);
												if (159356 - 518324 == -358968)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.TNncpBYkfGm, num), this.yekcpPtC2bv);
													if (184254 - 460182 != -275927)
													{
														GUI.EndGroup();
														if (243909 - 361067 != -117157)
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
								if (234024 - 6186 == 227838)
								{
									this.j6Icp4EQVlc = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (108746 - 1691 == 107055)
									{
										this.RenderNPC();
										if (203240 - 338095 != -134854)
										{
											break;
										}
									}
								}
							}
							else
							{
								GameObject gameObject = GameObject.Find("Duck");
								if (148857 - 390172 != -241314)
								{
									if (gameObject)
									{
										if (115314 - 109174 == 6141)
										{
											continue;
										}
										gameObject.animation.CrossFade("talk");
										if (82276 - 45823 == 36454)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (6618 - 559674 == -553056)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (267815 - 483966 == -216151)
										{
											gameGui.enabled = true;
											if (286880 - 215107 != 71774)
											{
												this.mState = eCollectorState.disabled;
												if (145175 - 526169 != -380993)
												{
													this.enabled = false;
													if (133205 - 61180 == 72025)
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

	// Token: 0x06006007 RID: 24583 RVA: 0x00CE8564 File Offset: 0x00CE6764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (147312 - 199212 != -51899)
		{
		}
		for (;;)
		{
			this.pMycpN9nDYC = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (26011 - 479614 != -453602)
			{
				this.RH2cpEvNNGp = new GUIStyle();
				if (166481 - 21883 != 144599)
				{
					this.RH2cpEvNNGp.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (263167 - 553615 == -290448)
					{
						this.RH2cpEvNNGp.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (232985 - 397919 != -164933)
						{
							this.RH2cpEvNNGp.alignment = TextAnchor.UpperLeft;
							if (38253 - 233095 == -194842)
							{
								this.yekcpPtC2bv = new GUIStyle();
								if (74901 - 140026 == -65125)
								{
									this.yekcpPtC2bv.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (16466 - 236229 == -219763)
									{
										this.yekcpPtC2bv.alignment = TextAnchor.UpperLeft;
										if (38760 - 160532 == -121772)
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

	// Token: 0x06006008 RID: 24584 RVA: 0x00CE8728 File Offset: 0x00CE6928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (54654 - 301377 != -246722)
		{
		}
		for (;;)
		{
			this.AbBcpUvxjf0 = (Texture)Resources.Load("GameGui/Story/Characters/Duck", typeof(Texture));
			if (73234 - 26715 != 46520)
			{
				this.R66cpSyEiP6 = Language.getMessage("CollectorGui", UnityEngine.Random.Range(101, 106));
				if (190600 - 260004 != -69403)
				{
					this.TNncpBYkfGm = Language.getMessage("CollectorGui", UnityEngine.Random.Range(201, 206));
					if (154010 - 20845 != 133166)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006009 RID: 24585 RVA: 0x00CE8808 File Offset: 0x00CE6A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (this.AbBcpUvxjf0)
		{
			GUI.DrawTexture(new Rect((float)0 - this.j6Icp4EQVlc * (float)396, (float)512, (float)396, (float)512), this.AbBcpUvxjf0);
		}
	}

	// Token: 0x0600600A RID: 24586 RVA: 0x00CE8858 File Offset: 0x00CE6A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCollectorMenu()
	{
		if (282958 - 64587 != 218371)
		{
		}
		for (;;)
		{
			IL_38B:
			this.C3ecp0lXabm = (Texture)Resources.Load("GameGui/Collector/collectorWindow", typeof(Texture));
			if (83533 - 65756 == 17777)
			{
				this.auscp8htfgt = new GUIStyle();
				if (156791 - 307354 != -150562)
				{
					this.auscp8htfgt.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Collector/tab_item_h", typeof(Texture)));
					if (172574 - 176733 == -4159)
					{
						this.EVOcpiiMNrd = new GUIStyle();
						if (71570 - 420784 == -349214)
						{
							this.EVOcpiiMNrd.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Collector/tab_equipment_h", typeof(Texture)));
							if (280275 - 159488 == 120787)
							{
								this.amjcpDT7G8u = new GUIStyle();
								if (130142 - 508840 == -378698)
								{
									this.amjcpDT7G8u.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Collector/tab_coin_h", typeof(Texture)));
									if (50317 - 126394 == -76077)
									{
										this.i4ycpmXWmDb = (Texture)Resources.Load("GameGui/Common/check", typeof(Texture));
										if (209182 - 57295 != 151888)
										{
											this.u8AcpjctYAP = new GUIStyle();
											if (147286 - 473555 != -326268)
											{
												this.u8AcpjctYAP.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/checkBox", typeof(Texture)));
												if (188944 - 384526 != -195581)
												{
													this.u8AcpjctYAP.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/checkBox_h", typeof(Texture)));
													if (207880 - 482804 != -274923)
													{
														this.lDocpogeQU1 = new GUIStyle();
														if (21903 - 306310 == -284407)
														{
															this.lDocpogeQU1.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Collector/button_highlight_h", typeof(Texture)));
															if (14544 - 359092 == -344548)
															{
																this.lDocpogeQU1.active.background = (Texture2D)((Texture)Resources.Load("GameGui/Collector/button_highlight_a", typeof(Texture)));
																if (160463 - 483272 == -322809)
																{
																	this.ghMcpkC3jOC = new GUIStyle();
																	if (191449 - 160402 == 31047)
																	{
																		this.ghMcpkC3jOC.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Collector/button_trade", typeof(Texture)));
																		if (10393 - 220931 != -210537)
																		{
																			this.ghMcpkC3jOC.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Collector/button_trade_h", typeof(Texture)));
																			if (247653 - 112047 == 135606)
																			{
																				this.lAOcpFtXZR2 = new GUIStyle();
																				if (157380 - 567010 != -409629)
																				{
																					this.lAOcpFtXZR2.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
																					if (112593 - 314628 == -202035)
																					{
																						this.Ui5cpAaPOBo = new GUIStyle();
																						if (196707 - 236033 != -39325)
																						{
																							this.Ui5cpAaPOBo.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
																							if (180433 - 532842 != -352408)
																							{
																								this.egVcp9YAHN4 = new GUIStyle();
																								if (123359 - 117222 != 6138)
																								{
																									this.egVcp9YAHN4.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																									if (239917 - 316449 != -76531)
																									{
																										this.egVcp9YAHN4.normal.textColor = new Color(0.63f, 0.98f, (float)1, (float)1);
																										if (148086 - 236586 == -88500)
																										{
																											this.egVcp9YAHN4.alignment = TextAnchor.UpperLeft;
																											if (286606 - 236299 == 50307)
																											{
																												this.egVcp9YAHN4.wordWrap = true;
																												if (22998 - 278135 == -255137)
																												{
																													this.J6EcpWIvI8x = new GUIStyle();
																													if (36908 - 32751 == 4157)
																													{
																														this.J6EcpWIvI8x.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																														if (171001 - 282830 != -111828)
																														{
																															this.J6EcpWIvI8x.normal.textColor = new Color(0.99f, 0.45f, 0.42f, (float)1);
																															if (56614 - 599442 == -542828)
																															{
																																this.J6EcpWIvI8x.alignment = TextAnchor.UpperLeft;
																																if (99600 - 60847 == 38753)
																																{
																																	this.J6EcpWIvI8x.wordWrap = true;
																																	if (142713 - 519766 == -377053)
																																	{
																																		this.YZlcpumPBCs = new GUIStyle();
																																		if (132024 - 170140 != -38115)
																																		{
																																			this.YZlcpumPBCs.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																			if (562 - 133596 == -133034)
																																			{
																																				this.YZlcpumPBCs.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																																				if (40970 - 575924 == -534954)
																																				{
																																					this.YZlcpumPBCs.alignment = TextAnchor.UpperLeft;
																																					if (28906 - 323894 == -294988)
																																					{
																																						this.YZlcpumPBCs.wordWrap = true;
																																						if (235681 - 315721 == -80040)
																																						{
																																							this.EelcpyCTyHI = new GUIStyle();
																																							if (19017 - 120699 == -101682)
																																							{
																																								this.EelcpyCTyHI.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																																								if (242448 - 32749 != 209700)
																																								{
																																									this.EelcpyCTyHI.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																																									if (194551 - 275572 == -81021)
																																									{
																																										this.EelcpyCTyHI.alignment = TextAnchor.MiddleCenter;
																																										if (259659 - 220639 == 39020)
																																										{
																																											this.qyFcpVGjiQF = new HoverButtonClass[6];
																																											if (68582 - 293885 == -225303)
																																											{
																																												int i = 0;
																																												if (206182 - 386532 != -180349)
																																												{
																																													while (i < 6)
																																													{
																																														this.qyFcpVGjiQF[i] = new HoverButtonClass();
																																														if (208205 - 354072 != -145867)
																																														{
																																															goto IL_38B;
																																														}
																																														i++;
																																														if (294369 - 46117 == 248253)
																																														{
																																															goto IL_38B;
																																														}
																																													}
																																													if (278398 - 360756 != -82357)
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
	}

	// Token: 0x0600600B RID: 24587 RVA: 0x00CE9178 File Offset: 0x00CE7378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetCollectorMenu()
	{
		if (227074 - 284792 != -57718)
		{
		}
		for (;;)
		{
			IL_40F:
			if (11444 - 527621 == -516177)
			{
				eCollectorTab pcycpsymjOM = this.PcycpsymjOM;
				if (212457 - 369950 == -157493)
				{
					string[] array;
					if (pcycpsymjOM == eCollectorTab.item)
					{
						if (136866 - 376604 != -239738)
						{
							continue;
						}
						array = CollectorData.getItemList(PlayerPrefs.GetInt("usableItem", 1) == 1);
						if (61214 - 54858 != 6356)
						{
							continue;
						}
					}
					else if (pcycpsymjOM == eCollectorTab.equipment)
					{
						if (240090 - 62764 != 177326)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = CollectorData.getEquipmentList(PlayerPrefs.GetInt("usableItem", 1) == 1);
						if (!(obj is string[]))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string[]));
						}
						array = (string[])obj2;
						if (229886 - 27395 == 202492)
						{
							continue;
						}
					}
					else
					{
						object obj4;
						object obj3 = obj4 = CollectorData.getCoinList(PlayerPrefs.GetInt("usableItem", 1) == 1);
						if (!(obj3 is string[]))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(string[]));
						}
						array = (string[])obj4;
						if (86697 - 489342 == -402644)
						{
							continue;
						}
					}
					CharacterDataClass current = CharacterData.current;
					if (95155 - 457354 != -362198)
					{
						this.sQScphCSqCH = new CollectorClass[Extensions.get_length(array)];
						if (51625 - 551785 != -500159)
						{
							int i = 0;
							if (228748 - 306783 != -78034)
							{
								while (i < Extensions.get_length(array))
								{
									this.sQScphCSqCH[i] = new CollectorClass();
									if (204954 - 587668 == -382713)
									{
										goto IL_40F;
									}
									if (this.sQScphCSqCH[i] != null)
									{
										if (184449 - 48769 == 135681)
										{
											goto IL_40F;
										}
										this.sQScphCSqCH[i].name = array[i];
										if (125355 - 511031 == -385675)
										{
											goto IL_40F;
										}
										this.sQScphCSqCH[i].item = ItemData.getItemData(array[i]);
										if (64123 - 365688 != -301565)
										{
											goto IL_40F;
										}
										this.sQScphCSqCH[i].icon = IconButton.getIconImage(array[i]);
										if (264324 - 245261 == 19064)
										{
											goto IL_40F;
										}
										string material = CollectorData.getMaterial(array[i]);
										if (5799 - 341919 != -336120)
										{
											goto IL_40F;
										}
										if (material != "none")
										{
											if (245295 - 158535 != 86760)
											{
												goto IL_40F;
											}
											string[] array2 = (string[])Stringf.splitToArray(material, ",").ToBuiltin(typeof(string));
											if (95613 - 31039 != 64574)
											{
												goto IL_40F;
											}
											if (Extensions.get_length(array2) > 0)
											{
												if (103987 - 414146 == -310158)
												{
													goto IL_40F;
												}
												this.sQScphCSqCH[i].material = new string[Extensions.get_length(array2)];
												if (99116 - 562284 == -463167)
												{
													goto IL_40F;
												}
												this.sQScphCSqCH[i].materialNum = new int[Extensions.get_length(array2)];
												if (104399 - 408124 != -303725)
												{
													goto IL_40F;
												}
												this.sQScphCSqCH[i].materialIcon = new Texture[Extensions.get_length(array2)];
												if (114300 - 324528 == -210227)
												{
													goto IL_40F;
												}
												this.sQScphCSqCH[i].materialCheck = new bool[Extensions.get_length(array2)];
												if (61304 - 72576 == -11271)
												{
													goto IL_40F;
												}
												int j = 0;
												if (231640 - 265828 == -34187)
												{
													goto IL_40F;
												}
												while (j < Extensions.get_length(array2))
												{
													string[] array3 = (string[])Stringf.splitToArray(array2[j], "%").ToBuiltin(typeof(string));
													if (83325 - 503558 != -420233)
													{
														goto IL_40F;
													}
													if (Extensions.get_length(array3) > 0)
													{
														if (133571 - 525222 != -391651)
														{
															goto IL_40F;
														}
														this.sQScphCSqCH[i].material[j] = array3[0];
														if (54246 - 317494 != -263248)
														{
															goto IL_40F;
														}
													}
													if (Extensions.get_length(array3) > 1)
													{
														if (285384 - 334595 != -49211)
														{
															goto IL_40F;
														}
														this.sQScphCSqCH[i].materialNum[j] = Mathf.Clamp(Stringf.getInteger(array3[1]), 1, 99);
														if (79466 - 327117 != -247651)
														{
															goto IL_40F;
														}
													}
													else
													{
														this.sQScphCSqCH[i].materialNum[j] = 1;
														if (108297 - 233052 == -124754)
														{
															goto IL_40F;
														}
													}
													this.sQScphCSqCH[i].materialIcon[j] = IconButton.getIconImage(this.sQScphCSqCH[i].material[j]);
													if (156895 - 320165 == -163269)
													{
														goto IL_40F;
													}
													if (current.getItemTotalNum(this.sQScphCSqCH[i].material[j]) >= this.sQScphCSqCH[i].materialNum[j])
													{
														if (278068 - 289260 != -11192)
														{
															goto IL_40F;
														}
														this.sQScphCSqCH[i].materialCheck[j] = true;
														if (281781 - 199044 == 82738)
														{
															goto IL_40F;
														}
													}
													else
													{
														this.sQScphCSqCH[i].materialCheck[j] = false;
														if (133518 - 75800 == 57719)
														{
															goto IL_40F;
														}
														this.sQScphCSqCH[i].canTrade = false;
														if (24647 - 59787 == -35139)
														{
															goto IL_40F;
														}
													}
													j++;
													if (116981 - 124001 != -7020)
													{
														goto IL_40F;
													}
												}
												if (266595 - 56766 == 209830)
												{
													goto IL_40F;
												}
											}
											else
											{
												this.sQScphCSqCH[i].canTrade = false;
												if (136939 - 230822 == -93882)
												{
													goto IL_40F;
												}
											}
										}
									}
									i++;
									if (193044 - 17132 != 175912)
									{
										goto IL_40F;
									}
								}
								if (168495 - 570620 == -402125)
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

	// Token: 0x0600600C RID: 24588 RVA: 0x00CE98E0 File Offset: 0x00CE7AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCollectorMenu()
	{
		if (7248 - 538239 != -530991)
		{
		}
		for (;;)
		{
			IL_1553:
			string text = "none";
			if (46007 - 212991 != -166983)
			{
				string text2 = "none";
				if (297834 - 478417 == -180583)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (112822 - 396975 == -284153)
					{
						Texture nHoverImage = null;
						if (89107 - 74581 == 14526)
						{
							if (this.PcycpsymjOM == eCollectorTab.item)
							{
								if (71470 - 149836 != -78366)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)393, (float)104, (float)64, (float)40), this.auscp8htfgt.hover.background);
								if (12066 - 492106 != -480040)
								{
									continue;
								}
							}
							else if (this.G6mcpK3UGuB < Time.time)
							{
								if (59720 - 241594 != -181874)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)393, (float)104, (float)64, (float)40), string.Empty, this.auscp8htfgt))
								{
									if (199640 - 97917 == 101724)
									{
										continue;
									}
									this.PcycpsymjOM = eCollectorTab.item;
									if (64541 - 291229 != -226688)
									{
										continue;
									}
									this.PXKcpHuVsiT = 0;
									if (159839 - 89067 == 70773)
									{
										continue;
									}
									this.an4cp7Ln50Y = -1;
									if (231733 - 242804 == -11070)
									{
										continue;
									}
									this.G6mcpK3UGuB = Time.time + 0.2f;
									if (279947 - 520018 == -240070)
									{
										continue;
									}
									this.audio.PlayOneShot(this.fckcpLjU6eX);
									if (194141 - 189999 == 4143)
									{
										continue;
									}
									this.ResetCollectorMenu();
									if (293870 - 18951 == 274920)
									{
										continue;
									}
								}
							}
							if (this.PcycpsymjOM == eCollectorTab.equipment)
							{
								if (289504 - 101408 != 188096)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)467, (float)104, (float)100, (float)40), this.EVOcpiiMNrd.hover.background);
								if (16305 - 377854 != -361549)
								{
									continue;
								}
							}
							else if (this.G6mcpK3UGuB < Time.time)
							{
								if (114014 - 141680 != -27666)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)467, (float)104, (float)100, (float)40), string.Empty, this.EVOcpiiMNrd))
								{
									if (41394 - 50513 == -9118)
									{
										continue;
									}
									this.PcycpsymjOM = eCollectorTab.equipment;
									if (197318 - 67326 != 129992)
									{
										continue;
									}
									this.PXKcpHuVsiT = 0;
									if (91330 - 533071 == -441740)
									{
										continue;
									}
									this.an4cp7Ln50Y = -1;
									if (265556 - 497061 == -231504)
									{
										continue;
									}
									this.G6mcpK3UGuB = Time.time + 0.2f;
									if (148087 - 152033 != -3946)
									{
										continue;
									}
									this.audio.PlayOneShot(this.fckcpLjU6eX);
									if (218590 - 124805 == 93786)
									{
										continue;
									}
									this.ResetCollectorMenu();
									if (166035 - 18753 != 147282)
									{
										continue;
									}
								}
							}
							if (this.PcycpsymjOM == eCollectorTab.coin)
							{
								if (89543 - 427900 == -338356)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)574, (float)104, (float)68, (float)40), this.amjcpDT7G8u.hover.background);
								if (11092 - 6792 != 4300)
								{
									continue;
								}
							}
							else if (this.G6mcpK3UGuB < Time.time)
							{
								if (157636 - 128652 == 28985)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)574, (float)104, (float)68, (float)40), string.Empty, this.amjcpDT7G8u))
								{
									if (36093 - 440053 == -403959)
									{
										continue;
									}
									this.PcycpsymjOM = eCollectorTab.coin;
									if (137659 - 35885 != 101774)
									{
										continue;
									}
									this.PXKcpHuVsiT = 0;
									if (229338 - 277736 != -48398)
									{
										continue;
									}
									this.an4cp7Ln50Y = -1;
									if (158747 - 513313 == -354565)
									{
										continue;
									}
									this.G6mcpK3UGuB = Time.time + 0.2f;
									if (37680 - 41597 != -3917)
									{
										continue;
									}
									this.audio.PlayOneShot(this.fckcpLjU6eX);
									if (67097 - 87800 != -20703)
									{
										continue;
									}
									this.ResetCollectorMenu();
									if (237148 - 597316 != -360168)
									{
										continue;
									}
								}
							}
							if (GUI.Button(new Rect((float)684, (float)102, (float)21, (float)22), string.Empty, this.u8AcpjctYAP))
							{
								if (144936 - 223848 == -78911)
								{
									continue;
								}
								if (this.G6mcpK3UGuB < Time.time)
								{
									if (8980 - 45701 == -36720)
									{
										continue;
									}
									if (PlayerPrefs.GetInt("usableItem", 1) != 0)
									{
										if (133263 - 133497 == -233)
										{
											continue;
										}
										PlayerPrefs.SetInt("usableItem", 0);
										if (212795 - 286014 != -73219)
										{
											continue;
										}
									}
									else
									{
										PlayerPrefs.SetInt("usableItem", 1);
										if (273228 - 569399 != -296171)
										{
											continue;
										}
									}
									this.PXKcpHuVsiT = 0;
									if (5748 - 488761 != -483013)
									{
										continue;
									}
									this.an4cp7Ln50Y = -1;
									if (174893 - 410088 != -235195)
									{
										continue;
									}
									this.G6mcpK3UGuB = Time.time + 0.2f;
									if (284352 - 352980 == -68627)
									{
										continue;
									}
									if (this.e35cpf15SmP)
									{
										if (17917 - 493089 != -475172)
										{
											continue;
										}
										this.audio.PlayOneShot(this.e35cpf15SmP);
										if (119376 - 138151 != -18775)
										{
											continue;
										}
									}
									this.ResetCollectorMenu();
									if (9029 - 342667 != -333638)
									{
										continue;
									}
								}
							}
							if (PlayerPrefs.GetInt("usableItem", 1) != 0)
							{
								if (78960 - 529252 == -450291)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)686, (float)104, (float)16, (float)16), this.i4ycpmXWmDb);
								if (215701 - 570800 != -355099)
								{
									continue;
								}
							}
							int i = 0 + 6 * this.PXKcpHuVsiT;
							if (231831 - 587116 == -355285)
							{
								while (i < Mathf.Min(Extensions.get_length(this.sQScphCSqCH), 6 * this.PXKcpHuVsiT + 6))
								{
									if (this.sQScphCSqCH[i] != null)
									{
										if (73471 - 209631 == -136159)
										{
											goto IL_1553;
										}
										if (i == this.an4cp7Ln50Y)
										{
											if (38941 - 333214 != -294273)
											{
												goto IL_1553;
											}
											GUI.DrawTexture(new Rect((float)388, (float)(191 + 68 * (i % 6)), (float)430, (float)68), this.lDocpogeQU1.hover.background);
											if (107899 - 400146 == -292246)
											{
												goto IL_1553;
											}
										}
										else if (this.sQScphCSqCH[i].canTrade)
										{
											if (6286 - 450539 == -444252)
											{
												goto IL_1553;
											}
											if (this.G6mcpK3UGuB < Time.time)
											{
												if (130311 - 303272 != -172961)
												{
													goto IL_1553;
												}
												if (GUI.Button(new Rect((float)388, (float)(191 + 68 * (i % 6)), (float)430, (float)68), string.Empty, this.lDocpogeQU1))
												{
													if (130522 - 358010 != -227488)
													{
														goto IL_1553;
													}
													this.an4cp7Ln50Y = i;
													if (189559 - 465127 == -275567)
													{
														goto IL_1553;
													}
													this.G6mcpK3UGuB = Time.time + 0.2f;
													if (37334 - 412640 == -375305)
													{
														goto IL_1553;
													}
													if (this.e35cpf15SmP)
													{
														if (220730 - 294864 != -74134)
														{
															goto IL_1553;
														}
														this.audio.PlayOneShot(this.e35cpf15SmP);
														if (76949 - 89772 != -12823)
														{
															goto IL_1553;
														}
													}
												}
											}
										}
										else
										{
											GUI.DrawTexture(new Rect((float)388, (float)(191 + 68 * (i % 6)), (float)430, (float)68), this.lDocpogeQU1.active.background);
											if (44421 - 102860 == -58438)
											{
												goto IL_1553;
											}
										}
										if (this.sQScphCSqCH[i].icon)
										{
											if (45274 - 155124 == -109849)
											{
												goto IL_1553;
											}
											GUI.DrawTexture(new Rect((float)404, (float)(191 + 68 * (i % 6)), (float)64, (float)64), this.sQScphCSqCH[i].icon);
											if (45263 - 46422 == -1158)
											{
												goto IL_1553;
											}
										}
										if (!this.sQScphCSqCH[i].canTrade)
										{
											if (196256 - 297599 == -101342)
											{
												goto IL_1553;
											}
											GUI.DrawTexture(new Rect((float)410, (float)(191 + 68 * (i % 6) + 5), (float)52, (float)52), this.RLNcRcoglc0);
											if (167841 - 561196 == -393354)
											{
												goto IL_1553;
											}
										}
										int j = 0;
										if (299956 - 441970 == -142013)
										{
											goto IL_1553;
										}
										while (j < Extensions.get_length(this.sQScphCSqCH[i].material))
										{
											if (this.sQScphCSqCH[i].materialIcon[j])
											{
												if (250197 - 371499 != -121302)
												{
													goto IL_1553;
												}
												GUI.DrawTexture(new Rect((float)(498 + 78 * j), (float)(191 + 68 * (i % 6)), (float)64, (float)64), this.sQScphCSqCH[i].materialIcon[j]);
												if (128168 - 437285 != -309117)
												{
													goto IL_1553;
												}
											}
											if (this.sQScphCSqCH[i].materialCheck[j])
											{
												if (38402 - 440276 == -401873)
												{
													goto IL_1553;
												}
												Guix.renderTextOutline(new Rect((float)(498 + 78 * j + 45), (float)(191 + 68 * (i % 6) + 35), (float)60, (float)30), "x" + this.sQScphCSqCH[i].materialNum[j], this.YZlcpumPBCs);
												if (150584 - 321498 != -170914)
												{
													goto IL_1553;
												}
												GUI.Label(new Rect((float)(498 + 78 * j + 45), (float)(191 + 68 * (i % 6) + 35), (float)60, (float)30), "x" + this.sQScphCSqCH[i].materialNum[j], this.egVcp9YAHN4);
												if (205807 - 491360 != -285553)
												{
													goto IL_1553;
												}
												Rect rect = new Rect((float)(498 + 78 * j), (float)(191 + 68 * (i % 6)), (float)64, (float)64);
												if (46676 - 271586 == -224909)
												{
													goto IL_1553;
												}
												if (rect.Contains(Event.current.mousePosition))
												{
													if (138131 - 581001 != -442870)
													{
														goto IL_1553;
													}
													text2 = ItemData.getName(this.sQScphCSqCH[i].material[j]);
													if (208398 - 146611 != 61787)
													{
														goto IL_1553;
													}
													vector = new Vector2((float)(498 + 78 * j - 120), (float)(191 + 68 * (i % 6) + 51));
													if (14172 - 55454 != -41282)
													{
														goto IL_1553;
													}
												}
											}
											else
											{
												GUI.DrawTexture(new Rect((float)(498 + 78 * j + 6), (float)(191 + 68 * (i % 6) + 5), (float)52, (float)52), this.RLNcRcoglc0);
												if (274196 - 87225 == 186972)
												{
													goto IL_1553;
												}
												Guix.renderTextOutline(new Rect((float)(498 + 78 * j + 45), (float)(191 + 68 * (i % 6) + 35), (float)60, (float)30), "x" + this.sQScphCSqCH[i].materialNum[j], this.YZlcpumPBCs);
												if (136156 - 159727 == -23570)
												{
													goto IL_1553;
												}
												GUI.Label(new Rect((float)(498 + 78 * j + 45), (float)(191 + 68 * (i % 6) + 35), (float)60, (float)30), "x" + this.sQScphCSqCH[i].materialNum[j], this.J6EcpWIvI8x);
												if (29146 - 46244 != -17098)
												{
													goto IL_1553;
												}
												Rect rect2 = new Rect((float)(498 + 78 * j), (float)(191 + 68 * (i % 6)), (float)64, (float)64);
												if (10207 - 545917 == -535709)
												{
													goto IL_1553;
												}
												if (rect2.Contains(Event.current.mousePosition))
												{
													if (239467 - 250378 == -10910)
													{
														goto IL_1553;
													}
													text2 = ItemData.getName(this.sQScphCSqCH[i].material[j]);
													if (87091 - 162921 != -75830)
													{
														goto IL_1553;
													}
													vector = new Vector2((float)(498 + 78 * j - 120), (float)(191 + 68 * (i % 6) + 51));
													if (145836 - 443831 != -297995)
													{
														goto IL_1553;
													}
												}
											}
											j++;
											if (191133 - 178145 != 12988)
											{
												goto IL_1553;
											}
										}
										if (26097 - 286618 == -260520)
										{
											goto IL_1553;
										}
									}
									eHoverButtonState eHoverButtonState = HoverButton.newButton(this.qyFcpVGjiQF[i % 6], new Rect((float)404, (float)(191 + 68 * (i % 6)), (float)64, (float)64), 0.5f);
									if (286686 - 475452 == -188765)
									{
										goto IL_1553;
									}
									eHoverButtonState eHoverButtonState2 = eHoverButtonState;
									if (169110 - 285381 != -116271)
									{
										goto IL_1553;
									}
									if (eHoverButtonState2 == eHoverButtonState.over)
									{
										if (162945 - 260338 == -97392)
										{
											goto IL_1553;
										}
										text2 = ItemData.getName(this.sQScphCSqCH[i].name);
										if (143426 - 409393 == -265966)
										{
											goto IL_1553;
										}
										vector = new Vector2((float)284, (float)(191 + 68 * (i % 6) + 51));
										if (163485 - 489033 == -325547)
										{
											goto IL_1553;
										}
									}
									else if (eHoverButtonState2 == eHoverButtonState.hover)
									{
										if (71599 - 435562 == -363962)
										{
											goto IL_1553;
										}
										text = this.sQScphCSqCH[i].name;
										if (241954 - 137174 == 104781)
										{
											goto IL_1553;
										}
										nHoverImage = this.sQScphCSqCH[i].icon;
										if (79091 - 121287 == -42195)
										{
											goto IL_1553;
										}
										vector = new Vector2((float)134, (float)(191 + 68 * (i % 6) - 120));
										if (15661 - 376959 == -361297)
										{
											goto IL_1553;
										}
									}
									i++;
									if (2339 - 543373 == -541033)
									{
										goto IL_1553;
									}
								}
								if (281410 - 19694 == 261716)
								{
									GUI.Label(new Rect((float)684, (float)606, (float)50, (float)30), string.Empty + (1 + this.PXKcpHuVsiT) + "/" + (global::Math.div((float)(Extensions.get_length(this.sQScphCSqCH) - 1), (float)6) + 1), this.EelcpyCTyHI);
									if (176156 - 296281 != -120124)
									{
										if (GUI.Button(new Rect((float)568, (float)595, (float)85, (float)57), string.Empty, this.lAOcpFtXZR2))
										{
											if (36610 - 57063 == -20452)
											{
												continue;
											}
											if (this.PXKcpHuVsiT > 0)
											{
												if (197822 - 213997 == -16174)
												{
													continue;
												}
												this.an4cp7Ln50Y = -1;
												if (250468 - 23550 != 226918)
												{
													continue;
												}
												this.PXKcpHuVsiT--;
												if (51554 - 84269 == -32714)
												{
													continue;
												}
											}
											this.audio.PlayOneShot(this.fckcpLjU6eX);
											if (162763 - 195304 == -32540)
											{
												continue;
											}
										}
										if (GUI.Button(new Rect((float)720, (float)595, (float)85, (float)57), string.Empty, this.Ui5cpAaPOBo))
										{
											if (119236 - 482329 != -363093)
											{
												continue;
											}
											if (this.PXKcpHuVsiT < global::Math.div((float)(Extensions.get_length(this.sQScphCSqCH) - 1), (float)6))
											{
												if (75963 - 506862 == -430898)
												{
													continue;
												}
												this.an4cp7Ln50Y = -1;
												if (144574 - 394887 == -250312)
												{
													continue;
												}
												this.PXKcpHuVsiT++;
												if (164430 - 7076 == 157355)
												{
													continue;
												}
											}
											this.audio.PlayOneShot(this.fckcpLjU6eX);
											if (46388 - 94394 == -48005)
											{
												continue;
											}
										}
										if (this.an4cp7Ln50Y >= 0)
										{
											if (145849 - 581129 == -435279)
											{
												continue;
											}
											if (Extensions.get_length(this.sQScphCSqCH) > this.an4cp7Ln50Y)
											{
												if (119517 - 417469 != -297952)
												{
													continue;
												}
												if (this.sQScphCSqCH[this.an4cp7Ln50Y].canTrade)
												{
													if (248983 - 202340 != 46643)
													{
														continue;
													}
													if (GUI.Button(new Rect((float)439, (float)603, (float)106, (float)40), string.Empty, this.ghMcpkC3jOC))
													{
														if (268492 - 320589 == -52096)
														{
															continue;
														}
														if (this.G6mcpK3UGuB < Time.time)
														{
															if (260922 - 496431 == -235508)
															{
																continue;
															}
															this.G6mcpK3UGuB = Time.time + 2f;
															if (124946 - 333507 == -208560)
															{
																continue;
															}
															this.newNoticeBar("Trading..", (float)2);
															if (286739 - 239526 == 47214)
															{
																continue;
															}
															this.audio.PlayOneShot(this.e35cpf15SmP);
															if (126606 - 527604 != -400998)
															{
																continue;
															}
															this.Collector(this.sQScphCSqCH[this.an4cp7Ln50Y].name);
															if (218215 - 362466 == -144250)
															{
																continue;
															}
														}
													}
												}
											}
										}
										if (text2 != "none")
										{
											if (24507 - 3567 == 20940)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text2, this.SwacR6leDyq);
												if (269145 - 445069 == -175924)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text2, this.ysvcRJp8Us1);
													if (241008 - 278499 == -37491)
													{
														break;
													}
												}
											}
										}
										else
										{
											if (!(text != "none"))
											{
												break;
											}
											if (142382 - 594817 == -452435)
											{
												InventoryClass inventoryClass = new InventoryClass();
												if (186836 - 540738 != -353901)
												{
													inventoryClass.name = text;
													if (154452 - 252321 != -97868)
													{
														Guix.renderItemToolTip((int)vector.x, (int)vector.y, inventoryClass, nHoverImage);
														if (280772 - 20533 != 260240)
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

	// Token: 0x0600600D RID: 24589 RVA: 0x00CEB0A0 File Offset: 0x00CE92A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCollectorInventory()
	{
		if (22167 - 74549 != -52382)
		{
		}
		for (;;)
		{
			this.gkgcpzsqxP4 = new IconButtonClass[30];
			if (114425 - 91165 == 23260)
			{
				this.NrfcR5tkcY3 = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover", typeof(Texture));
				if (79239 - 17980 != 61260)
				{
					this.RLNcRcoglc0 = (Texture)Resources.Load("GameGui/Icons/Common/Item_inactive", typeof(Texture));
					if (213323 - 12556 != 200768)
					{
						this.JrccRnTYFYT = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
						if (142842 - 317314 != -174471)
						{
							this.fedcRQrNLqs = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
							if (121928 - 119564 != 2365)
							{
								this.vi2cRernTGw = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
								if (119717 - 195922 == -76205)
								{
									this.hBacRIetl3O = new GUIStyle();
									if (253942 - 589072 != -335129)
									{
										this.hBacRIetl3O.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
										if (244282 - 365928 != -121645)
										{
											this.hBacRIetl3O.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
											if (98052 - 79149 == 18903)
											{
												this.hBacRIetl3O.alignment = TextAnchor.MiddleCenter;
												if (221248 - 416524 == -195276)
												{
													this.ysvcRJp8Us1 = new GUIStyle();
													if (90367 - 344705 == -254338)
													{
														this.ysvcRJp8Us1.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
														if (289715 - 194016 == 95699)
														{
															this.ysvcRJp8Us1.alignment = TextAnchor.MiddleCenter;
															if (232659 - 588010 != -355350)
															{
																this.ysvcRJp8Us1.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																if (288842 - 282478 == 6364)
																{
																	this.SwacR6leDyq = new GUIStyle();
																	if (88904 - 245409 == -156505)
																	{
																		this.SwacR6leDyq.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																		if (234824 - 258676 != -23851)
																		{
																			this.SwacR6leDyq.alignment = TextAnchor.MiddleCenter;
																			if (84360 - 368638 == -284278)
																			{
																				this.SwacR6leDyq.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																				if (280189 - 183808 != 96382)
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

	// Token: 0x0600600E RID: 24590 RVA: 0x00CEB45C File Offset: 0x00CE965C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetCollectorInventory()
	{
		if (159494 - 91955 != 67540)
		{
		}
		for (;;)
		{
			IL_68:
			int i = 0;
			if (235051 - 341797 == -106746)
			{
				while (i < 30)
				{
					this.gkgcpzsqxP4[i] = new IconButtonClass();
					if (296375 - 402059 == -105683)
					{
						goto IL_68;
					}
					if (CharacterData.current.inventory[i].name != "none")
					{
						if (20055 - 407127 != -387072)
						{
							goto IL_68;
						}
						this.gkgcpzsqxP4[i].name = CharacterData.current.inventory[i].name;
						if (99153 - 410582 == -311428)
						{
							goto IL_68;
						}
						this.gkgcpzsqxP4[i].command = i + 20;
						if (275028 - 216449 != 58579)
						{
							goto IL_68;
						}
						this.gkgcpzsqxP4[i].image = (Texture2D)IconButton.getCommandIcon(i + 20);
						if (8646 - 252657 != -244011)
						{
							goto IL_68;
						}
					}
					i++;
					if (148130 - 295654 != -147524)
					{
						goto IL_68;
					}
				}
				if (216757 - 590012 != -373254)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600600F RID: 24591 RVA: 0x00CEB5F0 File Offset: 0x00CE97F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCollectorInventory()
	{
		if (153751 - 513520 != -359769)
		{
		}
		for (;;)
		{
			IL_787:
			int num = 0;
			if (212001 - 399000 != -186998)
			{
				string text = "none";
				if (106231 - 406537 == -300306)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (134865 - 68844 == 66021)
					{
						Texture nHoverImage = null;
						if (7016 - 506506 != -499489)
						{
							int i = 0;
							if (246312 - 113807 != 132506)
							{
								while (i < 30)
								{
									if (this.gkgcpzsqxP4[i].name != "none")
									{
										if (284199 - 223061 == 61139)
										{
											goto IL_787;
										}
										Rect position = new Rect((float)418 + global::Math.mod((float)i, (float)6) * (float)60, (float)(674 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
										if (194836 - 279398 == -84561)
										{
											goto IL_787;
										}
										if (this.an4cp7Ln50Y - 20 != i)
										{
											if (259367 - 258501 == 867)
											{
												goto IL_787;
											}
											eIconButtonState eIconButtonState = IconButton.IconButton(this.gkgcpzsqxP4[i], new Rect(position.x + (float)6, position.y + (float)6, (float)50, (float)50));
											if (1647 - 153859 != -152212)
											{
												goto IL_787;
											}
											eIconButtonState eIconButtonState2 = eIconButtonState;
											if (127340 - 193458 == -66117)
											{
												goto IL_787;
											}
											if (eIconButtonState2 == eIconButtonState.none)
											{
												goto IL_8F0;
											}
											if (113372 - 156182 == -42809)
											{
												goto IL_787;
											}
											if (eIconButtonState2 == eIconButtonState.press)
											{
												if (161997 - 71255 != 90743)
												{
													goto IL_8F0;
												}
												goto IL_787;
											}
											else if (eIconButtonState2 == eIconButtonState.over)
											{
												if (92990 - 33972 == 59019)
												{
													goto IL_787;
												}
												GUI.DrawTexture(position, this.gkgcpzsqxP4[i].image);
												if (143464 - 535050 != -391586)
												{
													goto IL_787;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.NrfcR5tkcY3);
												if (285888 - 546619 == -260730)
												{
													goto IL_787;
												}
												if (this.i22cpZB6pZk == 0)
												{
													if (146476 - 87875 == 58602)
													{
														goto IL_787;
													}
													text = ItemData.getName(CharacterData.current.inventory[i].name);
													if (16490 - 308687 == -292196)
													{
														goto IL_787;
													}
													if (CharacterData.current.inventory[i].mlv != 0)
													{
														if (205937 - 117718 == 88220)
														{
															goto IL_787;
														}
														text += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
														if (267161 - 343619 == -76457)
														{
															goto IL_787;
														}
													}
													vector = new Vector2(position.x - (float)120, position.y + (float)51);
													if (139743 - 160034 == -20290)
													{
														goto IL_787;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.hover)
											{
												if (62047 - 432538 == -370490)
												{
													goto IL_787;
												}
												GUI.DrawTexture(position, this.gkgcpzsqxP4[i].image);
												if (284006 - 201481 != 82525)
												{
													goto IL_787;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.NrfcR5tkcY3);
												if (107982 - 296733 != -188751)
												{
													goto IL_787;
												}
												if (this.i22cpZB6pZk == 0)
												{
													if (194728 - 495321 != -300593)
													{
														goto IL_787;
													}
													if (CharacterData.current.inventory[i].name != "none")
													{
														if (16681 - 564153 == -547471)
														{
															goto IL_787;
														}
														num = i + 20;
														if (39000 - 484295 != -445295)
														{
															goto IL_787;
														}
														vector = new Vector2(position.x - (float)264, position.y - (float)128);
														if (213325 - 397771 != -184446)
														{
															goto IL_787;
														}
														nHoverImage = this.gkgcpzsqxP4[i].image;
														if (73168 - 460657 == -387488)
														{
															goto IL_787;
														}
													}
												}
											}
											goto IL_41F;
											IL_8F0:
											GUI.DrawTexture(position, this.gkgcpzsqxP4[i].image);
											if (48106 - 161102 == -112995)
											{
												goto IL_787;
											}
										}
										else
										{
											GUI.DrawTexture(position, this.gkgcpzsqxP4[i].image);
											if (260800 - 370621 != -109821)
											{
												goto IL_787;
											}
											GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.NrfcR5tkcY3);
											if (293341 - 157043 == 136299)
											{
												goto IL_787;
											}
										}
										IL_41F:
										if (CharacterData.current.inventory[i].num > 1)
										{
											if (282080 - 300453 != -18373)
											{
												goto IL_787;
											}
											GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.JrccRnTYFYT);
											if (51937 - 276995 != -225058)
											{
												goto IL_787;
											}
											GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.hBacRIetl3O);
											if (182085 - 134710 == 47376)
											{
												goto IL_787;
											}
										}
										else
										{
											string type = CharacterData.current.inventory[i].getType();
											if (292238 - 249338 == 42901)
											{
												goto IL_787;
											}
											if (!(type == "w"))
											{
												if (265537 - 58831 != 206706)
												{
													goto IL_787;
												}
												if (!(type == "a"))
												{
													if (4978 - 215186 == -210207)
													{
														goto IL_787;
													}
													if (!(type == "c"))
													{
														if (71364 - 463168 != -391804)
														{
															goto IL_787;
														}
														if (!(type == "b"))
														{
															if (277655 - 599013 == -321357)
															{
																goto IL_787;
															}
															if (!(type == "t"))
															{
																if (163892 - 42852 != 121040)
																{
																	goto IL_787;
																}
																if (!(type == "p"))
																{
																	goto IL_8AD;
																}
																if (230350 - 358843 == -128492)
																{
																	goto IL_787;
																}
															}
														}
													}
												}
											}
											if (CharacterData.current.inventory[i].owner == 0)
											{
												if (151683 - 456112 != -304429)
												{
													goto IL_787;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.fedcRQrNLqs);
												if (188018 - 222451 != -34433)
												{
													goto IL_787;
												}
											}
											else if (CharacterData.current.inventory[i].owner != CharacterData.current.CID)
											{
												if (72266 - 55719 == 16548)
												{
													goto IL_787;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.vi2cRernTGw);
												if (198630 - 457376 == -258745)
												{
													goto IL_787;
												}
											}
										}
									}
									IL_8AD:
									i++;
									if (20235 - 155784 != -135549)
									{
										goto IL_787;
									}
								}
								if (80603 - 266635 == -186032)
								{
									if (this.i22cpZB6pZk != 0)
									{
										break;
									}
									if (255843 - 520837 == -264994)
									{
										if (text != "none")
										{
											if (183227 - 470787 == -287560)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.SwacR6leDyq);
												if (195862 - 558082 == -362220)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.ysvcRJp8Us1);
													if (34889 - 405923 == -371034)
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
											if (61997 - 11031 == 50966)
											{
												InventoryClass nHoverItem = CharacterData.current.inventory[num - 20];
												if (28233 - 41941 != -13707)
												{
													Guix.renderItemToolTip((int)vector.x, (int)vector.y, nHoverItem, nHoverImage);
													if (83639 - 526915 == -443276)
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

	// Token: 0x06006010 RID: 24592 RVA: 0x00CEC0B8 File Offset: 0x00CEA2B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCollectorNotice()
	{
		if (242000 - 10995 != 231005)
		{
		}
		for (;;)
		{
			this.O6ScRtkKuwP = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (132123 - 412816 == -280693)
			{
				this.o37cRXP4eDh = new GUIStyle();
				if (245509 - 204351 != 41159)
				{
					this.o37cRXP4eDh.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (136715 - 392507 == -255792)
					{
						this.o37cRXP4eDh.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (24222 - 110230 != -86007)
						{
							this.o37cRXP4eDh.alignment = TextAnchor.MiddleCenter;
							if (168170 - 453048 != -284877)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006011 RID: 24593 RVA: 0x00CEC1F4 File Offset: 0x00CEA3F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newNoticeBar(string s, float t)
	{
		this.dqncR2hfC6U = s;
		this.CUfcRO7JlLg = Time.time + t;
	}

	// Token: 0x06006012 RID: 24594 RVA: 0x00CEC20C File Offset: 0x00CEA40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar()
	{
		if (2621 - 3002 != -380)
		{
		}
		while (this.CUfcRO7JlLg > Time.time)
		{
			if (172358 - 275581 == -103223)
			{
				GUI.DrawTexture(new Rect((float)360, (float)480, (float)475, (float)102), this.O6ScRtkKuwP);
				if (9455 - 131730 != -122274)
				{
					GUI.Label(new Rect((float)395, (float)510, (float)400, (float)40), this.dqncR2hfC6U, this.o37cRXP4eDh);
					if (276490 - 260855 == 15635)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006013 RID: 24595 RVA: 0x00CEC2F4 File Offset: 0x00CEA4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (237519 - 522407 != -284887)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (193100 - 59014 != 134087)
				{
					break;
				}
			}
			else
			{
				if (this.i22cpZB6pZk == 0)
				{
					break;
				}
				if (9267 - 356877 == -347610)
				{
					if (Input.GetMouseButton(1))
					{
						if (268349 - 379123 == -110774)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (287414 - 598871 != -311456)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (69140 - 515031 != -445890)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.i22cpZB6pZk));
									if (52827 - 52536 != 292)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.i22cpZB6pZk = 0;
						if (166963 - 3508 != 163456)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006014 RID: 24596 RVA: 0x00CEC47C File Offset: 0x00CEA67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Collector(string nItem)
	{
		if (201490 - 564682 != -363192)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (201086 - 302830 == -101744)
			{
				hashtable.Add(21, nItem);
				if (271130 - 332118 != -60987)
				{
					PhotonClient.Connection.OpCustom(246, hashtable, true);
					if (44285 - 96676 == -52391)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006015 RID: 24597 RVA: 0x00CEC528 File Offset: 0x00CEA728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCollectorOperation(Hashtable data)
	{
		if (247390 - 339473 != -92083)
		{
		}
		for (;;)
		{
			IL_2EC:
			Debug.Log("onCollectorOperation:" + data[31]);
			if (60595 - 139814 == -79219)
			{
				int num = RuntimeServices.UnboxInt32(data[31]);
				if (288649 - 258058 != 30592)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string s = (string)obj2;
					if (298320 - 323488 != -25167)
					{
						if (num == 1)
						{
							if (251723 - 375388 != -123664)
							{
								InventoryClass inventoryClass = new InventoryClass();
								if (248381 - 249408 != -1026)
								{
									inventoryClass.readData(s);
									if (295283 - 423572 == -128289)
									{
										if (inventoryClass.name != "none")
										{
											if (100054 - 233017 != -132963)
											{
												continue;
											}
											if (inventoryClass.slot != -1)
											{
												if (203785 - 567843 == -364057)
												{
													continue;
												}
												CharacterData.current.inventory[inventoryClass.slot] = inventoryClass;
												if (26229 - 352198 != -325969)
												{
													continue;
												}
											}
										}
										ItemClass itemData = ItemData.getItemData(inventoryClass.name);
										if (21300 - 27764 != -6463)
										{
											string material = CollectorData.getMaterial(inventoryClass.name);
											if (145843 - 17942 == 127901)
											{
												if (material != "none")
												{
													if (268965 - 17513 != 251452)
													{
														continue;
													}
													string[] array = (string[])Stringf.splitToArray(material, ",").ToBuiltin(typeof(string));
													if (165083 - 176849 == -11765)
													{
														continue;
													}
													if (Extensions.get_length(array) > 0)
													{
														if (223361 - 476353 != -252992)
														{
															continue;
														}
														int i = 0;
														if (41672 - 179372 == -137699)
														{
															continue;
														}
														while (i < Extensions.get_length(array))
														{
															string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
															if (105786 - 13002 == 92785)
															{
																goto IL_2EC;
															}
															string nItem = array2[0];
															if (67994 - 174838 == -106843)
															{
																goto IL_2EC;
															}
															int nNum = 1;
															if (97724 - 163869 == -66144)
															{
																goto IL_2EC;
															}
															if (Extensions.get_length(array2) > 1)
															{
																if (151830 - 566826 != -414996)
																{
																	goto IL_2EC;
																}
																nNum = Stringf.getInteger(array2[1]);
																if (229608 - 143619 != 85989)
																{
																	goto IL_2EC;
																}
															}
															CharacterData.current.removeInventory(nItem, nNum);
															if (241738 - 282360 == -40621)
															{
																goto IL_2EC;
															}
															i++;
															if (122108 - 533521 == -411412)
															{
																goto IL_2EC;
															}
														}
														if (174246 - 235539 == -61292)
														{
															continue;
														}
													}
												}
												this.newNoticeBar("Recieve " + itemData.name, 2f);
												if (298773 - 556167 == -257394)
												{
													this.G6mcpK3UGuB = Time.time + (float)2;
													if (198303 - 580188 != -381884)
													{
														this.ResetCollectorMenu();
														if (179255 - 563921 != -384665)
														{
															this.ResetCollectorInventory();
															if (2758 - 84354 != -81595)
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
						else
						{
							this.newNoticeBar("Collector Trade Error!", 1f);
							if (160247 - 222893 != -62645)
							{
								this.G6mcpK3UGuB = Time.time + (float)1;
								if (91307 - 112540 == -21233)
								{
									this.ResetCollectorMenu();
									if (90581 - 193009 == -102428)
									{
										this.ResetCollectorInventory();
										if (221431 - 412207 != -190775)
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

	// Token: 0x06006016 RID: 24598 RVA: 0x00CECA58 File Offset: 0x00CEAC58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006017 RID: 24599 RVA: 0x00CECA5C File Offset: 0x00CEAC5C
	internal static bool eYDLyJp3yMBwpkAm2OqY()
	{
		return true;
	}

	// Token: 0x06006018 RID: 24600 RVA: 0x00CECA60 File Offset: 0x00CEAC60
	internal static bool ssP7eIp3Sm9FiymDYAYY()
	{
		return false;
	}

	// Token: 0x04006ACA RID: 27338
	public eCollectorState mState;

	// Token: 0x04006ACB RID: 27339
	private float LsWcpdWNHOP;

	// Token: 0x04006ACC RID: 27340
	private float LhqcpgVeWTb;

	// Token: 0x04006ACD RID: 27341
	private float dU6cpamugfc;

	// Token: 0x04006ACE RID: 27342
	private float j6Icp4EQVlc;

	// Token: 0x04006ACF RID: 27343
	private eCollectorTab PcycpsymjOM;

	// Token: 0x04006AD0 RID: 27344
	private int PXKcpHuVsiT;

	// Token: 0x04006AD1 RID: 27345
	private int an4cp7Ln50Y;

	// Token: 0x04006AD2 RID: 27346
	private int i22cpZB6pZk;

	// Token: 0x04006AD3 RID: 27347
	private GUIStyle mMvcpCDfc9j;

	// Token: 0x04006AD4 RID: 27348
	private AudioClip TaPcpMZhW3Y;

	// Token: 0x04006AD5 RID: 27349
	private AudioClip e35cpf15SmP;

	// Token: 0x04006AD6 RID: 27350
	private AudioClip fckcpLjU6eX;

	// Token: 0x04006AD7 RID: 27351
	private AudioClip DcacpwrmqEl;

	// Token: 0x04006AD8 RID: 27352
	private Texture AbBcpUvxjf0;

	// Token: 0x04006AD9 RID: 27353
	private Texture pMycpN9nDYC;

	// Token: 0x04006ADA RID: 27354
	private GUIStyle RH2cpEvNNGp;

	// Token: 0x04006ADB RID: 27355
	private GUIStyle yekcpPtC2bv;

	// Token: 0x04006ADC RID: 27356
	private string R66cpSyEiP6;

	// Token: 0x04006ADD RID: 27357
	private string TNncpBYkfGm;

	// Token: 0x04006ADE RID: 27358
	private Texture C3ecp0lXabm;

	// Token: 0x04006ADF RID: 27359
	private GUIStyle auscp8htfgt;

	// Token: 0x04006AE0 RID: 27360
	private GUIStyle EVOcpiiMNrd;

	// Token: 0x04006AE1 RID: 27361
	private GUIStyle amjcpDT7G8u;

	// Token: 0x04006AE2 RID: 27362
	private Texture i4ycpmXWmDb;

	// Token: 0x04006AE3 RID: 27363
	private GUIStyle u8AcpjctYAP;

	// Token: 0x04006AE4 RID: 27364
	private GUIStyle lDocpogeQU1;

	// Token: 0x04006AE5 RID: 27365
	private GUIStyle ghMcpkC3jOC;

	// Token: 0x04006AE6 RID: 27366
	private GUIStyle lAOcpFtXZR2;

	// Token: 0x04006AE7 RID: 27367
	private GUIStyle Ui5cpAaPOBo;

	// Token: 0x04006AE8 RID: 27368
	private GUIStyle egVcp9YAHN4;

	// Token: 0x04006AE9 RID: 27369
	private GUIStyle J6EcpWIvI8x;

	// Token: 0x04006AEA RID: 27370
	private GUIStyle YZlcpumPBCs;

	// Token: 0x04006AEB RID: 27371
	private GUIStyle EelcpyCTyHI;

	// Token: 0x04006AEC RID: 27372
	private HoverButtonClass[] qyFcpVGjiQF;

	// Token: 0x04006AED RID: 27373
	private CollectorClass[] sQScphCSqCH;

	// Token: 0x04006AEE RID: 27374
	private float G6mcpK3UGuB;

	// Token: 0x04006AEF RID: 27375
	private IconButtonClass[] gkgcpzsqxP4;

	// Token: 0x04006AF0 RID: 27376
	private Texture NrfcR5tkcY3;

	// Token: 0x04006AF1 RID: 27377
	private Texture RLNcRcoglc0;

	// Token: 0x04006AF2 RID: 27378
	private Texture JrccRnTYFYT;

	// Token: 0x04006AF3 RID: 27379
	private Texture fedcRQrNLqs;

	// Token: 0x04006AF4 RID: 27380
	private Texture vi2cRernTGw;

	// Token: 0x04006AF5 RID: 27381
	private GUIStyle hBacRIetl3O;

	// Token: 0x04006AF6 RID: 27382
	private GUIStyle ysvcRJp8Us1;

	// Token: 0x04006AF7 RID: 27383
	private GUIStyle SwacR6leDyq;

	// Token: 0x04006AF8 RID: 27384
	private Texture O6ScRtkKuwP;

	// Token: 0x04006AF9 RID: 27385
	private GUIStyle o37cRXP4eDh;

	// Token: 0x04006AFA RID: 27386
	private float CUfcRO7JlLg;

	// Token: 0x04006AFB RID: 27387
	private string dqncR2hfC6U;
}
