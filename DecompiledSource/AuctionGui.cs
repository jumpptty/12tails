using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200101D RID: 4125
[Serializable]
public class AuctionGui : MonoBehaviour
{
	// Token: 0x06005EFE RID: 24318 RVA: 0x00CC2420 File Offset: 0x00CC0620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AuctionGui()
	{
		if (92107 - 290264 != -198156)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (102778 - 488527 != -385748)
			{
				base..ctor();
				if (250145 - 75498 != 174648)
				{
					this.mState = eAuctionState.init;
					if (109328 - 76506 != 32823)
					{
						this.iHUcl9kUj46 = eAuctionPage.All;
						if (234351 - 457765 == -223414)
						{
							this.p3AcGQMwRwn = "none";
							if (83675 - 204197 == -120522)
							{
								this.q7jc11Yr5dE = string.Empty;
								if (42039 - 215678 != -173638)
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

	// Token: 0x06005EFF RID: 24319 RVA: 0x00CC2524 File Offset: 0x00CC0724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (285194 - 440129 != -154935)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (186318 - 303153 != -116834)
			{
				if (this.mState == eAuctionState.init)
				{
					if (279288 - 374917 == -95628)
					{
						continue;
					}
					this.InitAuctonMenu();
					if (201084 - 509378 != -308294)
					{
						continue;
					}
					this.InitAuctionTab();
					if (17011 - 56933 != -39922)
					{
						continue;
					}
					this.InitAuctionList();
					if (227177 - 561224 == -334046)
					{
						continue;
					}
					this.InitSearchBar();
					if (168177 - 340735 != -172558)
					{
						continue;
					}
					this.InitBuyMenu();
					if (179489 - 2593 != 176896)
					{
						continue;
					}
					this.InitSellMenu();
					if (187128 - 203221 != -16093)
					{
						continue;
					}
					this.InitEditMenu();
					if (27561 - 597591 != -570030)
					{
						continue;
					}
					this.InitGetItemMenu();
					if (8094 - 129236 == -121141)
					{
						continue;
					}
					this.InitGetMoneyMenu();
					if (285443 - 427312 == -141868)
					{
						continue;
					}
					this.InitLoseMenu();
					if (15611 - 221621 != -206010)
					{
						continue;
					}
					this.InitNoBidMenu();
					if (10711 - 354381 == -343669)
					{
						continue;
					}
					this.InitAuctionEntry();
					if (207944 - 392944 != -185000)
					{
						continue;
					}
					this.InitAuctionInventory();
					if (118327 - 161623 != -43296)
					{
						continue;
					}
				}
				this.NdYclVaD0e9 = 1f;
				if (189417 - 5893 == 183524)
				{
					this.OCvclhp0OdM = (float)0;
					if (192556 - 44093 == 148463)
					{
						this.uehcGxn0K9u = Language.getMessage("AuctionGui", 101 + UnityEngine.Random.Range(0, 5));
						if (83661 - 239893 != -156231)
						{
							this.nMJcGTFdRZg = Language.getMessage("AuctionGui", 106 + UnityEngine.Random.Range(0, 5));
							if (110962 - 132926 == -21964)
							{
								this.ResetAuctionInventory();
								if (270832 - 132695 == 138137)
								{
									this.mState = eAuctionState.open;
									if (75453 - 163279 == -87826)
									{
										this.T0GclWUNrcs = Time.time;
										if (155442 - 519401 == -363959)
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

	// Token: 0x06005F00 RID: 24320 RVA: 0x00CC2858 File Offset: 0x00CC0A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (191967 - 41099 != 150868)
		{
		}
		for (;;)
		{
			if (this.mState <= eAuctionState.init)
			{
				if (144155 - 210880 != -66724)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (241579 - 404149 != -162569)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (231440 - 88103 != 143338)
					{
						this.qhHcluhicVh = (float)(1024 * Screen.width / Screen.height);
						if (84346 - 274129 == -189783)
						{
							this.FkTclyw9u2h = (float)Screen.height / 1024f;
							if (17173 - 315138 == -297965)
							{
								this.RenderAuctionMenu();
								if (49757 - 57335 != -7577)
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

	// Token: 0x06005F01 RID: 24321 RVA: 0x00CC29A8 File Offset: 0x00CC0BA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitAuctonMenu()
	{
		if (153541 - 435017 != -281475)
		{
		}
		for (;;)
		{
			this.HabcGIWLPdC = (Texture)Resources.Load("GameGui/Auction/auction_window", typeof(Texture));
			if (72693 - 340793 == -268100)
			{
				this.js7cGJARS0G = (Texture)Resources.Load("GameGui/Story/Characters/Lemur", typeof(Texture));
				if (156322 - 589758 == -433436)
				{
					this.gcHcG6U7bdp = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
					if (154121 - 111433 != 42689)
					{
						this.T6ycGORrcb6 = new GUIStyle();
						if (161657 - 95596 == 66061)
						{
							this.T6ycGORrcb6.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/button_close_h", typeof(Texture)));
							if (128039 - 266507 != -138467)
							{
								this.tQicGtuS5mq = new GUIStyle();
								if (241447 - 428521 != -187073)
								{
									this.tQicGtuS5mq.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
									if (47776 - 376884 != -329107)
									{
										this.tQicGtuS5mq.normal.textColor = new Color(0.25f, 0.22f, 0.2f, (float)1);
										if (31257 - 63824 == -32567)
										{
											this.tQicGtuS5mq.alignment = TextAnchor.UpperLeft;
											if (6468 - 293154 == -286686)
											{
												this.w5AcGXIWKBL = new GUIStyle();
												if (129729 - 155964 == -26235)
												{
													this.w5AcGXIWKBL.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
													if (244637 - 76685 == 167952)
													{
														this.w5AcGXIWKBL.alignment = TextAnchor.UpperLeft;
														if (79788 - 361885 != -282096)
														{
															this.aMvcG2ILmr6 = new GUIStyle();
															if (111947 - 401894 != -289946)
															{
																this.aMvcG2ILmr6.active.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/check", typeof(Texture)));
																if (212513 - 489592 != -277078)
																{
																	this.HbQcGG7NTRk = new GUIStyle();
																	if (1886 - 277745 == -275859)
																	{
																		this.HbQcGG7NTRk.font = (Font)Resources.Load("GameGui/Fonts/MsSansSerif18", typeof(Font));
																		if (220991 - 217901 == 3090)
																		{
																			this.HbQcGG7NTRk.alignment = TextAnchor.UpperRight;
																			if (189594 - 448173 != -258578)
																			{
																				this.R8pcG1vOcWc = new GUIStyle();
																				if (215763 - 201230 != 14534)
																				{
																					this.R8pcG1vOcWc.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/numUp", typeof(Texture)));
																					if (54281 - 240116 != -185834)
																					{
																						this.cprcGqbuuec = new GUIStyle();
																						if (42742 - 363854 == -321112)
																						{
																							this.cprcGqbuuec.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/numDown", typeof(Texture)));
																							if (251673 - 133404 != 118270)
																							{
																								this.hOKcGpT2ryQ = new GUIStyle();
																								if (42133 - 557728 != -515594)
																								{
																									this.hOKcGpT2ryQ.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																									if (236205 - 174314 == 61891)
																									{
																										this.hOKcGpT2ryQ.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																										if (285100 - 162659 != 122442)
																										{
																											this.hOKcGpT2ryQ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/drop_h", typeof(Texture)));
																											if (52746 - 352219 == -299473)
																											{
																												this.hOKcGpT2ryQ.alignment = TextAnchor.MiddleLeft;
																												if (56237 - 53421 == 2816)
																												{
																													this.nv7cGvssocD = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
																													if (14211 - 471385 == -457174)
																													{
																														this.cEgcGlqyJVK = new GUIStyle();
																														if (2431 - 27469 == -25038)
																														{
																															this.cEgcGlqyJVK.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																															if (260513 - 159735 != 100779)
																															{
																																this.cEgcGlqyJVK.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																if (172858 - 143658 == 29200)
																																{
																																	this.cEgcGlqyJVK.alignment = TextAnchor.MiddleCenter;
																																	if (162824 - 43786 != 119039)
																																	{
																																		this.iWbcGR02juj = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																																		if (272226 - 561227 != -289000)
																																		{
																																			this.sSycGrFLA24 = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																																			if (5365 - 320054 == -314689)
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

	// Token: 0x06005F02 RID: 24322 RVA: 0x00CC309C File Offset: 0x00CC129C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderAuctionMenu()
	{
		if (228083 - 437341 != -209258)
		{
		}
		for (;;)
		{
			float num = Time.time - this.T0GclWUNrcs;
			if (3816 - 479103 == -475287)
			{
				eAuctionState eAuctionState = this.mState;
				if (230089 - 469390 == -239301)
				{
					if (eAuctionState != eAuctionState.open)
					{
						if (eAuctionState == eAuctionState.search)
						{
							if (276142 - 539135 != -262993)
							{
								continue;
							}
						}
						else if (eAuctionState == eAuctionState.buy)
						{
							if (162233 - 156546 != 5687)
							{
								continue;
							}
						}
						else if (eAuctionState == eAuctionState.sell)
						{
							if (143942 - 268754 != -124812)
							{
								continue;
							}
						}
						else if (eAuctionState == eAuctionState.edit)
						{
							if (96257 - 329599 == -233341)
							{
								continue;
							}
						}
						else if (eAuctionState == eAuctionState.getItem)
						{
							if (89419 - 6582 != 82837)
							{
								continue;
							}
						}
						else if (eAuctionState == eAuctionState.getMoney)
						{
							if (65289 - 49075 != 16214)
							{
								continue;
							}
						}
						else if (eAuctionState == eAuctionState.lose)
						{
							if (121829 - 535033 == -413203)
							{
								continue;
							}
						}
						else if (eAuctionState == eAuctionState.noBid)
						{
							if (41847 - 551951 == -510103)
							{
								continue;
							}
						}
						else
						{
							if (eAuctionState != eAuctionState.close)
							{
								break;
							}
							if (110426 - 405483 == -295056)
							{
								continue;
							}
							if (num <= (float)2)
							{
								if (235861 - 153538 == 82324)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)0 - this.NdYclVaD0e9 * (float)293, (float)554, (float)293, (float)470), this.js7cGJARS0G);
								if (257604 - 124845 != 132759)
								{
									continue;
								}
								GUI.BeginGroup(new Rect(0.5f * this.qhHcluhicVh - (float)350, (float)724, (float)850, (float)200));
								if (130125 - 77250 == 52876)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.gcHcG6U7bdp);
								if (9742 - 122449 == -112706)
								{
									continue;
								}
								GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Lemur", this.tQicGtuS5mq);
								if (282326 - 286391 != -4065)
								{
									continue;
								}
								GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.nMJcGTFdRZg, num), this.w5AcGXIWKBL);
								if (151180 - 97337 != 53843)
								{
									continue;
								}
								GUI.EndGroup();
								if (60138 - 440904 != -380766)
								{
									continue;
								}
								break;
							}
							else if (num <= 2.5f)
							{
								if (188318 - 59293 != 129025)
								{
									continue;
								}
								this.NdYclVaD0e9 = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
								if (127500 - 214315 == -86814)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)0 - this.NdYclVaD0e9 * (float)293, (float)554, (float)293, (float)470), this.js7cGJARS0G);
								if (226795 - 474634 != -247838)
								{
									break;
								}
								continue;
							}
							else
							{
								Game.mGameState = eGameState.Normal;
								if (242884 - 186770 == 56115)
								{
									continue;
								}
								GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
								if (261834 - 22815 != 239019)
								{
									continue;
								}
								gameGui.enabled = true;
								if (198093 - 8497 != 189596)
								{
									continue;
								}
								this.mState = eAuctionState.disabled;
								if (140582 - 333065 != -192483)
								{
									continue;
								}
								this.enabled = false;
								if (34477 - 518616 != -484139)
								{
									continue;
								}
								break;
							}
						}
						IL_B4F:
						this.camera.rect = new Rect((float)0, (float)0, (this.qhHcluhicVh - (float)754) / this.qhHcluhicVh, (float)1);
						if (270504 - 244181 == 26324)
						{
							continue;
						}
						GUI.BeginGroup(new Rect(this.qhHcluhicVh - (float)1024, (float)0, (float)1024, (float)1024));
						if (262921 - 384050 == -121128)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)74, (float)0, (float)950, (float)1024), this.HabcGIWLPdC);
						if (252415 - 501819 != -249404)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)496, (float)48, (float)16, (float)16), string.Empty, this.aMvcG2ILmr6))
						{
							if (232145 - 126786 != 105359)
							{
								continue;
							}
							this.xZxcGn4Ut8J = !this.xZxcGn4Ut8J;
							if (267974 - 537430 == -269455)
							{
								continue;
							}
							this.audio.PlayOneShot(this.iWbcGR02juj);
							if (259964 - 242316 == 17649)
							{
								continue;
							}
						}
						if (this.xZxcGn4Ut8J)
						{
							if (154334 - 560781 != -406447)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)496, (float)48, (float)16, (float)16), this.aMvcG2ILmr6.active.background);
							if (19525 - 13132 != 6393)
							{
								continue;
							}
						}
						Guix.renderSmallNumber(740, 40, PlayerData.Gil, false, (float)1);
						if (286480 - 410666 != -124186)
						{
							continue;
						}
						Guix.renderSmallNumber(920, 40, PlayerData.Jil, false, (float)1);
						if (73945 - 298385 == -224439)
						{
							continue;
						}
						this.RenderAuctionEntry();
						if (219479 - 172930 == 46550)
						{
							continue;
						}
						if (this.mState == eAuctionState.search)
						{
							if (225673 - 102302 == 123372)
							{
								continue;
							}
							if (this.iHUcl9kUj46 == eAuctionPage.All)
							{
								if (65291 - 258221 == -192929)
								{
									continue;
								}
								this.RenderSearchBar();
								if (12500 - 310056 == -297555)
								{
									continue;
								}
							}
						}
						else if (this.mState == eAuctionState.buy)
						{
							if (264649 - 447420 != -182771)
							{
								continue;
							}
							this.RenderBuyMenu();
							if (269033 - 396133 == -127099)
							{
								continue;
							}
						}
						else if (this.mState == eAuctionState.sell)
						{
							if (245858 - 408760 == -162901)
							{
								continue;
							}
							this.RenderSellMenu();
							if (24979 - 375169 == -350189)
							{
								continue;
							}
						}
						else if (this.mState == eAuctionState.edit)
						{
							if (160996 - 64203 == 96794)
							{
								continue;
							}
							this.RenderEditMenu();
							if (147877 - 537722 == -389844)
							{
								continue;
							}
						}
						else if (this.mState == eAuctionState.getItem)
						{
							if (104623 - 388447 != -283824)
							{
								continue;
							}
							this.RenderGetItemMenu();
							if (109322 - 147320 == -37997)
							{
								continue;
							}
						}
						else if (this.mState == eAuctionState.getMoney)
						{
							if (148091 - 256824 == -108732)
							{
								continue;
							}
							this.RenderGetMoneyMenu();
							if (224454 - 128275 != 96179)
							{
								continue;
							}
						}
						else if (this.mState == eAuctionState.lose)
						{
							if (197058 - 188259 != 8799)
							{
								continue;
							}
							this.RenderLoseMenu();
							if (88596 - 380261 != -291665)
							{
								continue;
							}
						}
						else if (this.mState == eAuctionState.noBid)
						{
							if (299000 - 238621 == 60380)
							{
								continue;
							}
							this.RenderNoBidMenu();
							if (191630 - 266587 == -74956)
							{
								continue;
							}
						}
						eAuctionPage eAuctionPage = this.iHUcl9kUj46;
						if (138692 - 540125 == -401432)
						{
							continue;
						}
						if (eAuctionPage == eAuctionPage.All)
						{
							if (162980 - 117850 == 45131)
							{
								continue;
							}
							this.RenderAuctionList();
							if (35158 - 19443 == 15716)
							{
								continue;
							}
						}
						else if (eAuctionPage == eAuctionPage.MyBuy)
						{
							if (58277 - 100755 == -42477)
							{
								continue;
							}
							this.RenderMyBuyList();
							if (202972 - 175461 == 27512)
							{
								continue;
							}
						}
						else if (eAuctionPage == eAuctionPage.MySell)
						{
							if (180547 - 351949 != -171402)
							{
								continue;
							}
							this.RenderMySellList();
							if (3526 - 41423 == -37896)
							{
								continue;
							}
						}
						this.RenderAuctionTab(true);
						if (28079 - 15411 != 12668)
						{
							continue;
						}
						this.RenderAuctionInventory();
						if (165271 - 100788 == 64484)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)181, (float)0, (float)57, (float)52), string.Empty, this.T6ycGORrcb6))
						{
							if (13487 - 464880 != -451393)
							{
								continue;
							}
							this.mState = eAuctionState.close;
							if (193948 - 442806 != -248858)
							{
								continue;
							}
							this.T0GclWUNrcs = Time.time;
							if (145022 - 515432 != -370410)
							{
								continue;
							}
							this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
							if (214355 - 468768 == -254412)
							{
								continue;
							}
						}
						if (this.e3PcGepEuGF >= Time.time)
						{
							if (58899 - 493261 == -434361)
							{
								continue;
							}
							this.RenderNoticeBar(this.p3AcGQMwRwn);
							if (270937 - 458363 == -187425)
							{
								continue;
							}
						}
						GUI.EndGroup();
						if (222672 - 451337 != -228665)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)0, (float)554, (float)293, (float)470), this.js7cGJARS0G);
						if (107686 - 584385 != -476699)
						{
							continue;
						}
						this.RenderDragIcon();
						if (69694 - 157881 != -88187)
						{
							continue;
						}
						break;
						IL_488:
						goto IL_B4F;
						IL_57E:
						goto IL_488;
						IL_F06:
						goto IL_57E;
						IL_68C:
						goto IL_F06;
						IL_6B2:
						goto IL_68C;
						goto IL_6B2;
					}
					if (27082 - 253236 != -226153)
					{
						if (num <= 0.5f)
						{
							if (243114 - 138752 == 104362)
							{
								this.NdYclVaD0e9 = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
								if (60508 - 199806 != -139297)
								{
									GUI.DrawTexture(new Rect((float)0 - this.NdYclVaD0e9 * (float)293, (float)554, (float)293, (float)470), this.js7cGJARS0G);
									if (284316 - 489222 == -204906)
									{
										GUI.DrawTexture(new Rect(0.5f * this.qhHcluhicVh - (float)336, (float)724 + this.NdYclVaD0e9 * (float)300, (float)836, (float)196), this.gcHcG6U7bdp);
										if (171551 - 333918 == -162367)
										{
											break;
										}
									}
								}
							}
						}
						else if (num <= (float)4)
						{
							if (88810 - 468233 == -379423)
							{
								this.NdYclVaD0e9 = (float)0;
								if (43904 - 94613 == -50709)
								{
									GUI.DrawTexture(new Rect((float)0 - this.NdYclVaD0e9 * (float)293, (float)554, (float)293, (float)470), this.js7cGJARS0G);
									if (51131 - 430786 == -379655)
									{
										GUI.BeginGroup(new Rect(0.5f * this.qhHcluhicVh - (float)350, (float)724, (float)850, (float)200));
										if (48627 - 30650 != 17978)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.gcHcG6U7bdp);
											if (187127 - 152927 == 34200)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Lemur", this.w5AcGXIWKBL);
												if (46994 - 457149 == -410155)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.uehcGxn0K9u, num - 0.5f), this.w5AcGXIWKBL);
													if (230048 - 144853 != 85196)
													{
														GUI.EndGroup();
														if (280416 - 218305 == 62111)
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
							this.NdYclVaD0e9 = (float)0;
							if (52398 - 332780 != -280381)
							{
								GUI.DrawTexture(new Rect((float)0, (float)554, (float)293, (float)470), this.js7cGJARS0G);
								if (30999 - 305996 == -274997)
								{
									this.mState = eAuctionState.search;
									if (30446 - 382773 == -352327)
									{
										this.T0GclWUNrcs = Time.time;
										if (10402 - 473210 != -462807)
										{
											this.OpenAuctionList(true);
											if (37363 - 47799 == -10436)
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

	// Token: 0x06005F03 RID: 24323 RVA: 0x00CC4084 File Offset: 0x00CC2284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitAuctionTab()
	{
		if (12691 - 537628 != -524937)
		{
		}
		for (;;)
		{
			this.SkCcGYsIZbM = new GUIStyle();
			if (218605 - 48633 != 169973)
			{
				this.SkCcGYsIZbM.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/page_allitem_h", typeof(Texture)));
				if (200723 - 172249 == 28474)
				{
					this.ROjcG3WWSkH = new GUIStyle();
					if (210317 - 221110 != -10792)
					{
						this.ROjcG3WWSkH.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/page_mybid_h", typeof(Texture)));
						if (72051 - 176676 == -104625)
						{
							this.zRAcGbkuOGg = new GUIStyle();
							if (133612 - 341085 == -207473)
							{
								this.zRAcGbkuOGg.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/page_mysell_h", typeof(Texture)));
								if (10698 - 212996 == -202298)
								{
									this.SbmcGZgtb69 = new HoverButtonClass();
									if (296748 - 595107 == -298359)
									{
										this.QEccGC5DBwC = new HoverButtonClass();
										if (164496 - 445213 == -280717)
										{
											this.G7jcGMX2DcH = new HoverButtonClass();
											if (194554 - 522561 != -328006)
											{
												this.rXRcGfB3Uy9 = new HoverButtonClass();
												if (197055 - 90836 == 106219)
												{
													this.BStcGLxq1Vk = new HoverButtonClass();
													if (70075 - 408538 != -338462)
													{
														this.idbcGdRcPCq = (Texture)Resources.Load("GameGui/Auction/tab_item_h", typeof(Texture));
														if (82037 - 71621 == 10416)
														{
															this.xr2cGgB4c6y = (Texture)Resources.Load("GameGui/Auction/tab_lv_h", typeof(Texture));
															if (259165 - 337900 == -78735)
															{
																this.zO5cGaIT5xA = (Texture)Resources.Load("GameGui/Auction/tab_bid_h", typeof(Texture));
																if (249448 - 121942 == 127506)
																{
																	this.P0vcG4xMkEH = (Texture)Resources.Load("GameGui/Auction/tab_buyout_h", typeof(Texture));
																	if (35952 - 105998 == -70046)
																	{
																		this.KaLcGsIA0BJ = (Texture)Resources.Load("GameGui/Auction/tab_time_h", typeof(Texture));
																		if (150402 - 563487 != -413084)
																		{
																			this.o6RcGHGnlfK = (Texture)Resources.Load("GameGui/Auction/sort_up", typeof(Texture));
																			if (238732 - 572612 != -333879)
																			{
																				this.rsFcG7D9uJh = (Texture)Resources.Load("GameGui/Auction/sort_down", typeof(Texture));
																				if (4710 - 263949 != -259238)
																				{
																					this.rUwcGwHyiIT = new GUIStyle();
																					if (184527 - 415565 != -231037)
																					{
																						this.rUwcGwHyiIT.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/tab_type_h", typeof(Texture)));
																						if (1096 - 93992 != -92895)
																						{
																							this.utFcGUPqfeS = (Texture)Resources.Load("GameGui/Auction/tab_type_d", typeof(Texture));
																							if (243318 - 421574 == -178256)
																							{
																								this.xF1cGE18gns = (Texture)Resources.Load("GameGui/Auction/topic_wep", typeof(Texture));
																								if (25814 - 501712 != -475897)
																								{
																									this.gTocGPpXwOX = (Texture)Resources.Load("GameGui/Auction/topic_arm", typeof(Texture));
																									if (94160 - 294985 == -200825)
																									{
																										this.BKbcGS7haEV = (Texture)Resources.Load("GameGui/Auction/topic_acc", typeof(Texture));
																										if (162327 - 49251 != 113077)
																										{
																											this.lifcGBKJpwD = (Texture)Resources.Load("GameGui/Auction/topic_bot", typeof(Texture));
																											if (189007 - 7646 == 181361)
																											{
																												this.go7cG0K0flL = (Texture)Resources.Load("GameGui/Auction/topic_trn", typeof(Texture));
																												if (66753 - 492952 != -426198)
																												{
																													this.yXQcG8SRmTw = (Texture)Resources.Load("GameGui/Auction/topic_pet", typeof(Texture));
																													if (183541 - 41922 == 141619)
																													{
																														this.BhscGikirDt = (Texture)Resources.Load("GameGui/Auction/topic_fld", typeof(Texture));
																														if (199400 - 482222 != -282821)
																														{
																															this.pgfcGDnsERH = (Texture)Resources.Load("GameGui/Auction/topic_fod", typeof(Texture));
																															if (133049 - 536901 == -403852)
																															{
																																this.UjRcGm1rW33 = (Texture)Resources.Load("GameGui/Auction/topic_mat", typeof(Texture));
																																if (14020 - 120297 == -106277)
																																{
																																	this.w5McGjxPYqx = (Texture)Resources.Load("GameGui/Auction/topic_rcp", typeof(Texture));
																																	if (292403 - 162999 != 129405)
																																	{
																																		this.anAcGoNGkiM = (Texture)Resources.Load("GameGui/Auction/topic_pin", typeof(Texture));
																																		if (175220 - 171746 == 3474)
																																		{
																																			this.m3kcGkdxJK4 = new GUIStyle();
																																			if (277331 - 194503 != 82829)
																																			{
																																				this.m3kcGkdxJK4.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/tab_refresh_h", typeof(Texture)));
																																				if (6346 - 503258 != -496911)
																																				{
																																					this.OqRcGFSENdO = (Texture)Resources.Load("GameGui/Auction/tab_timeout", typeof(Texture));
																																					if (214098 - 526418 != -312319)
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

	// Token: 0x06005F04 RID: 24324 RVA: 0x00CC480C File Offset: 0x00CC2A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderAuctionTab(bool isButton)
	{
		if (123469 - 273973 != -150503)
		{
		}
		for (;;)
		{
			IL_1FE4:
			if (isButton)
			{
				if (259357 - 205339 == 54019)
				{
					continue;
				}
				if (!this.TDwcGNZOoC0)
				{
					if (217154 - 548324 == -331169)
					{
						continue;
					}
					if (this.iHUcl9kUj46 == eAuctionPage.All)
					{
						if (63488 - 595837 == -532348)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)228, (float)80, (float)96, (float)35), this.SkCcGYsIZbM.hover.background);
						if (144538 - 90513 != 54025)
						{
							continue;
						}
					}
					else if (this.Srbc1GmqHoO < Time.time)
					{
						if (235232 - 11589 == 223644)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)228, (float)80, (float)96, (float)35), string.Empty, this.SkCcGYsIZbM))
						{
							if (241155 - 523840 != -282685)
							{
								continue;
							}
							this.OpenAuctionList(false);
							if (229331 - 161552 == 67780)
							{
								continue;
							}
						}
					}
					if (this.iHUcl9kUj46 == eAuctionPage.MyBuy)
					{
						if (99692 - 13434 != 86258)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)327, (float)80, (float)79, (float)35), this.ROjcG3WWSkH.hover.background);
						if (11503 - 482050 == -470546)
						{
							continue;
						}
					}
					else if (this.Srbc1GmqHoO < Time.time)
					{
						if (17083 - 335104 == -318020)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)327, (float)80, (float)79, (float)35), string.Empty, this.ROjcG3WWSkH))
						{
							if (294122 - 201475 == 92648)
							{
								continue;
							}
							this.OpenMyBuyList(false);
							if (68601 - 74443 == -5841)
							{
								continue;
							}
						}
					}
					if (this.iHUcl9kUj46 == eAuctionPage.MySell)
					{
						if (200453 - 452730 != -252277)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)407, (float)80, (float)81, (float)35), this.zRAcGbkuOGg.hover.background);
						if (215397 - 268544 != -53147)
						{
							continue;
						}
					}
					else if (this.Srbc1GmqHoO < Time.time)
					{
						if (23112 - 506130 != -483018)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)407, (float)80, (float)81, (float)35), string.Empty, this.zRAcGbkuOGg))
						{
							if (79336 - 354376 == -275039)
							{
								continue;
							}
							this.OpenMySellList(false);
							if (188570 - 281959 != -93389)
							{
								continue;
							}
						}
					}
					eHoverButtonState eHoverButtonState = HoverButton.newButton(this.SbmcGZgtb69, new Rect((float)208, (float)116, (float)69, (float)38), (float)0);
					if (294349 - 49101 == 245249)
					{
						continue;
					}
					eHoverButtonState eHoverButtonState2 = HoverButton.newButton(this.QEccGC5DBwC, new Rect((float)576, (float)116, (float)44, (float)38), (float)0);
					if (290441 - 227815 == 62627)
					{
						continue;
					}
					eHoverButtonState eHoverButtonState3 = HoverButton.newButton(this.G7jcGMX2DcH, new Rect((float)620, (float)116, (float)137, (float)38), (float)0);
					if (93120 - 16407 != 76713)
					{
						continue;
					}
					eHoverButtonState eHoverButtonState4 = HoverButton.newButton(this.rXRcGfB3Uy9, new Rect((float)757, (float)116, (float)104, (float)38), (float)0);
					if (222045 - 153786 != 68259)
					{
						continue;
					}
					eHoverButtonState eHoverButtonState5 = HoverButton.newButton(this.BStcGLxq1Vk, new Rect((float)861, (float)116, (float)73, (float)38), (float)0);
					if (5270 - 256379 == -251108)
					{
						continue;
					}
					eHoverButtonState eHoverButtonState6 = eHoverButtonState;
					if (253216 - 91563 != 161653)
					{
						continue;
					}
					if (eHoverButtonState6 == eHoverButtonState.none)
					{
						if (58053 - 280177 == -222123)
						{
							continue;
						}
						if (Mathf.Abs(this.aoWc1pH2W9m) == 1)
						{
							if (290937 - 316164 != -25227)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)208, (float)116, (float)69, (float)38), this.idbcGdRcPCq);
							if (297585 - 89388 != 208197)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState6 == eHoverButtonState.hover)
					{
						if (226958 - 447280 != -220322)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)208, (float)116, (float)69, (float)38), this.idbcGdRcPCq);
						if (222414 - 84287 != 138127)
						{
							continue;
						}
						if (this.aoWc1pH2W9m == -1)
						{
							if (215272 - 196217 == 19056)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)235, (float)112, (float)24, (float)48), this.rsFcG7D9uJh);
							if (219170 - 362895 != -143725)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)235, (float)112, (float)24, (float)48), this.o6RcGHGnlfK);
							if (81381 - 476641 == -395259)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState6 == eHoverButtonState.press)
					{
						if (35645 - 474129 != -438484)
						{
							continue;
						}
						this.aoWc1pH2W9m = ((this.aoWc1pH2W9m != 1) ? 1 : -1);
						this.SortList(this.aoWc1pH2W9m);
						if (288832 - 449979 != -161147)
						{
							continue;
						}
						this.audio.PlayOneShot(this.sSycGrFLA24);
						if (123976 - 220026 == -96049)
						{
							continue;
						}
					}
					eHoverButtonState eHoverButtonState7 = eHoverButtonState2;
					if (286094 - 461469 == -175374)
					{
						continue;
					}
					if (eHoverButtonState7 == eHoverButtonState.none)
					{
						if (20895 - 577708 != -556813)
						{
							continue;
						}
						if (Mathf.Abs(this.aoWc1pH2W9m) == 2)
						{
							if (107340 - 559049 == -451708)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)576, (float)116, (float)44, (float)38), this.xr2cGgB4c6y);
							if (152357 - 74729 != 77628)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState7 == eHoverButtonState.hover)
					{
						if (289490 - 253447 != 36043)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)576, (float)116, (float)44, (float)38), this.xr2cGgB4c6y);
						if (268999 - 193001 == 75999)
						{
							continue;
						}
						if (this.aoWc1pH2W9m == -2)
						{
							if (241649 - 274895 == -33245)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)585, (float)112, (float)24, (float)48), this.rsFcG7D9uJh);
							if (175875 - 564827 != -388952)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)585, (float)112, (float)24, (float)48), this.o6RcGHGnlfK);
							if (147033 - 186306 != -39273)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState7 == eHoverButtonState.press)
					{
						if (296590 - 148701 == 147890)
						{
							continue;
						}
						this.aoWc1pH2W9m = ((this.aoWc1pH2W9m != 2) ? 2 : -2);
						this.SortList(this.aoWc1pH2W9m);
						if (179638 - 517323 != -337685)
						{
							continue;
						}
						this.audio.PlayOneShot(this.sSycGrFLA24);
						if (184469 - 191055 == -6585)
						{
							continue;
						}
					}
					eHoverButtonState eHoverButtonState8 = eHoverButtonState3;
					if (179139 - 197302 == -18162)
					{
						continue;
					}
					if (eHoverButtonState8 == eHoverButtonState.none)
					{
						if (55962 - 213764 == -157801)
						{
							continue;
						}
						if (Mathf.Abs(this.aoWc1pH2W9m) == 3)
						{
							if (5841 - 84303 == -78461)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)620, (float)116, (float)137, (float)38), this.zO5cGaIT5xA);
							if (148258 - 365123 != -216865)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState8 == eHoverButtonState.hover)
					{
						if (289703 - 349091 == -59387)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)620, (float)116, (float)137, (float)38), this.zO5cGaIT5xA);
						if (231454 - 314615 == -83160)
						{
							continue;
						}
						if (this.aoWc1pH2W9m == -3)
						{
							if (88990 - 372089 != -283099)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)668, (float)112, (float)24, (float)48), this.rsFcG7D9uJh);
							if (114374 - 394340 != -279966)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)668, (float)112, (float)24, (float)48), this.o6RcGHGnlfK);
							if (71242 - 352104 == -280861)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState8 == eHoverButtonState.press)
					{
						if (278493 - 319828 == -41334)
						{
							continue;
						}
						this.aoWc1pH2W9m = ((this.aoWc1pH2W9m != 3) ? 3 : -3);
						this.SortList(this.aoWc1pH2W9m);
						if (126279 - 395299 != -269020)
						{
							continue;
						}
						this.audio.PlayOneShot(this.sSycGrFLA24);
						if (245954 - 397236 != -151282)
						{
							continue;
						}
					}
					eHoverButtonState eHoverButtonState9 = eHoverButtonState4;
					if (238583 - 52955 == 185629)
					{
						continue;
					}
					if (eHoverButtonState9 == eHoverButtonState.none)
					{
						if (160016 - 585355 == -425338)
						{
							continue;
						}
						if (Mathf.Abs(this.aoWc1pH2W9m) == 4)
						{
							if (44341 - 478442 == -434100)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)757, (float)116, (float)104, (float)38), this.P0vcG4xMkEH);
							if (34501 - 332753 == -298251)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState9 == eHoverButtonState.hover)
					{
						if (47045 - 418898 == -371852)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)757, (float)116, (float)104, (float)38), this.P0vcG4xMkEH);
						if (46125 - 84610 != -38485)
						{
							continue;
						}
						if (this.aoWc1pH2W9m == -4)
						{
							if (155712 - 151391 == 4322)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)796, (float)112, (float)24, (float)48), this.rsFcG7D9uJh);
							if (86915 - 115559 != -28644)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)796, (float)112, (float)24, (float)48), this.o6RcGHGnlfK);
							if (119266 - 282835 != -163569)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState9 == eHoverButtonState.press)
					{
						if (141212 - 104001 == 37212)
						{
							continue;
						}
						this.aoWc1pH2W9m = ((this.aoWc1pH2W9m != 4) ? 4 : -4);
						this.SortList(this.aoWc1pH2W9m);
						if (35057 - 243168 == -208110)
						{
							continue;
						}
						this.audio.PlayOneShot(this.sSycGrFLA24);
						if (206027 - 526806 != -320779)
						{
							continue;
						}
					}
					eHoverButtonState eHoverButtonState10 = eHoverButtonState5;
					if (214982 - 231700 != -16718)
					{
						continue;
					}
					if (eHoverButtonState10 == eHoverButtonState.none)
					{
						if (42603 - 34409 != 8194)
						{
							continue;
						}
						if (Mathf.Abs(this.aoWc1pH2W9m) == 5)
						{
							if (137528 - 317036 != -179508)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)861, (float)116, (float)73, (float)38), this.KaLcGsIA0BJ);
							if (88465 - 533389 != -444924)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState10 == eHoverButtonState.hover)
					{
						if (43170 - 306330 == -263159)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)861, (float)116, (float)73, (float)38), this.KaLcGsIA0BJ);
						if (204034 - 140973 != 63061)
						{
							continue;
						}
						if (this.aoWc1pH2W9m == -5)
						{
							if (226440 - 415040 == -188599)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)884, (float)112, (float)24, (float)48), this.rsFcG7D9uJh);
							if (133379 - 236374 != -102995)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)884, (float)112, (float)24, (float)48), this.o6RcGHGnlfK);
							if (133807 - 327281 == -193473)
							{
								continue;
							}
						}
					}
					else if (eHoverButtonState10 == eHoverButtonState.press)
					{
						if (82640 - 150119 == -67478)
						{
							continue;
						}
						this.aoWc1pH2W9m = ((this.aoWc1pH2W9m != 5) ? 5 : -5);
						this.SortList(this.aoWc1pH2W9m);
						if (228402 - 404345 != -175943)
						{
							continue;
						}
						this.audio.PlayOneShot(this.sSycGrFLA24);
						if (132186 - 322436 != -190250)
						{
							continue;
						}
					}
					if (this.Srbc1GmqHoO < Time.time)
					{
						if (28648 - 29801 == -1152)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)406, (float)121, (float)94, (float)30), string.Empty, this.m3kcGkdxJK4))
						{
							if (229159 - 170224 == 58936)
							{
								continue;
							}
							this.audio.PlayOneShot(this.sSycGrFLA24);
							if (280492 - 171233 != 109259)
							{
								continue;
							}
							eAuctionPage eAuctionPage = this.iHUcl9kUj46;
							if (88853 - 278869 == -190015)
							{
								continue;
							}
							if (eAuctionPage == eAuctionPage.All)
							{
								if (210449 - 244715 == -34265)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.AuctionUpdate(this.q7jc11Yr5dE, this.qHSc1qVfPGK, this.aoWc1pH2W9m));
								if (221538 - 384684 != -163146)
								{
									continue;
								}
							}
							else if (eAuctionPage == eAuctionPage.MyBuy)
							{
								if (120678 - 311945 != -191267)
								{
									continue;
								}
							}
							else
							{
								if (eAuctionPage != eAuctionPage.MySell)
								{
									goto IL_1852;
								}
								if (65647 - 35925 != 29722)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.AuctionUpdateSell());
								if (17096 - 38088 != -20991)
								{
									goto IL_1852;
								}
								continue;
							}
							this.StartCoroutine_Auto(this.AuctionUpdateBuy());
							if (133341 - 456932 == -323590)
							{
								continue;
							}
						}
						IL_1852:;
					}
					else
					{
						GUI.DrawTexture(new Rect((float)406, (float)121, (float)94, (float)30), this.OqRcGFSENdO);
						if (3403 - 439149 != -435746)
						{
							continue;
						}
					}
					goto IL_C6E;
				}
			}
			if (this.iHUcl9kUj46 == eAuctionPage.All)
			{
				if (214324 - 334825 != -120501)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)228, (float)80, (float)96, (float)35), this.SkCcGYsIZbM.hover.background);
				if (217048 - 41540 != 175508)
				{
					continue;
				}
			}
			if (this.iHUcl9kUj46 == eAuctionPage.MyBuy)
			{
				if (56856 - 149246 == -92389)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)327, (float)80, (float)79, (float)35), this.ROjcG3WWSkH.hover.background);
				if (246578 - 467348 != -220770)
				{
					continue;
				}
			}
			if (this.iHUcl9kUj46 == eAuctionPage.MySell)
			{
				if (226464 - 218952 != 7512)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)406, (float)80, (float)81, (float)35), this.zRAcGbkuOGg.hover.background);
				if (242638 - 564831 != -322193)
				{
					continue;
				}
			}
			if (Mathf.Abs(this.aoWc1pH2W9m) == 1)
			{
				if (21401 - 426278 != -404877)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)208, (float)116, (float)69, (float)38), this.idbcGdRcPCq);
				if (94699 - 212887 != -118188)
				{
					continue;
				}
			}
			if (Mathf.Abs(this.aoWc1pH2W9m) == 2)
			{
				if (68205 - 37723 != 30482)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)575, (float)116, (float)44, (float)38), this.xr2cGgB4c6y);
				if (17832 - 396718 != -378886)
				{
					continue;
				}
			}
			if (Mathf.Abs(this.aoWc1pH2W9m) == 3)
			{
				if (108495 - 560056 == -451560)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)620, (float)116, (float)137, (float)38), this.zO5cGaIT5xA);
				if (238312 - 140971 == 97342)
				{
					continue;
				}
			}
			if (Mathf.Abs(this.aoWc1pH2W9m) == 4)
			{
				if (265175 - 472839 == -207663)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)757, (float)116, (float)104, (float)38), this.P0vcG4xMkEH);
				if (275142 - 175830 != 99312)
				{
					continue;
				}
			}
			if (Mathf.Abs(this.aoWc1pH2W9m) == 5)
			{
				if (211457 - 44101 == 167357)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)861, (float)116, (float)73, (float)38), this.KaLcGsIA0BJ);
				if (88203 - 270861 == -182657)
				{
					continue;
				}
			}
			IL_C6E:
			int num = this.qHSc1qVfPGK;
			if (96720 - 139704 == -42984)
			{
				if (num == 1)
				{
					if (46789 - 120862 != -74073)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.xF1cGE18gns);
					if (217908 - 572684 != -354776)
					{
						continue;
					}
				}
				else if (num == 2)
				{
					if (25137 - 137230 == -112092)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.gTocGPpXwOX);
					if (286732 - 290622 == -3889)
					{
						continue;
					}
				}
				else if (num == 3)
				{
					if (129650 - 579048 == -449397)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.BKbcGS7haEV);
					if (287091 - 335440 == -48348)
					{
						continue;
					}
				}
				else if (num == 4)
				{
					if (204749 - 435940 == -231190)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.lifcGBKJpwD);
					if (72538 - 195779 != -123241)
					{
						continue;
					}
				}
				else if (num == 5)
				{
					if (223931 - 414068 != -190137)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.go7cG0K0flL);
					if (227625 - 468949 != -241324)
					{
						continue;
					}
				}
				else if (num == 6)
				{
					if (257388 - 569972 == -312583)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.yXQcG8SRmTw);
					if (145923 - 440963 != -295040)
					{
						continue;
					}
				}
				else if (num == 7)
				{
					if (123542 - 146466 != -22924)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.BhscGikirDt);
					if (26221 - 70159 != -43938)
					{
						continue;
					}
				}
				else if (num == 8)
				{
					if (224042 - 394110 != -170068)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.pgfcGDnsERH);
					if (192433 - 257828 != -65395)
					{
						continue;
					}
				}
				else if (num == 9)
				{
					if (149987 - 276422 != -126435)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.UjRcGm1rW33);
					if (138437 - 532690 == -394252)
					{
						continue;
					}
				}
				else if (num == 10)
				{
					if (17728 - 248434 == -230705)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.w5McGjxPYqx);
					if (32118 - 44155 != -12037)
					{
						continue;
					}
				}
				else if (num == 11)
				{
					if (39172 - 282476 != -243304)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)504, (float)116, (float)71, (float)38), this.anAcGoNGkiM);
					if (173795 - 522963 != -349168)
					{
						continue;
					}
				}
				if (!isButton)
				{
					if (245666 - 125791 == 119875)
					{
						this.TDwcGNZOoC0 = false;
						if (44784 - 533784 == -489000)
						{
							break;
						}
					}
				}
				else if (!this.TDwcGNZOoC0)
				{
					if (74047 - 377681 == -303634)
					{
						if (this.Srbc1GmqHoO < Time.time)
						{
							if (6664 - 436449 == -429785)
							{
								if (!GUI.Button(new Rect((float)500, (float)116, (float)73, (float)37), string.Empty, this.rUwcGwHyiIT))
								{
									break;
								}
								if (71376 - 164189 != -92812)
								{
									this.TDwcGNZOoC0 = true;
									if (194734 - 507529 != -312794)
									{
										break;
									}
								}
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)500, (float)116, (float)73, (float)37), this.rUwcGwHyiIT.hover.background);
							if (180282 - 218779 == -38497)
							{
								break;
							}
						}
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)470, (float)155, (float)107, (float)270), this.utFcGUPqfeS);
					if (139208 - 197946 == -58738)
					{
						int i = 0;
						if (42823 - 3758 == 39065)
						{
							while (i <= 13)
							{
								string text = string.Empty;
								if (177952 - 536390 != -358438)
								{
									goto IL_1FE4;
								}
								int num2 = i;
								if (59525 - 280968 == -221442)
								{
									goto IL_1FE4;
								}
								if (num2 == 0)
								{
									if (200628 - 462534 == -261905)
									{
										goto IL_1FE4;
									}
									text = "   all";
									if (196141 - 342944 != -146803)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 1)
								{
									if (194558 - 596046 != -401488)
									{
										goto IL_1FE4;
									}
									text = "   weapon";
									if (32773 - 345855 != -313082)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 2)
								{
									if (175225 - 126285 != 48940)
									{
										goto IL_1FE4;
									}
									text = "   armor";
									if (289287 - 205689 == 83599)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 3)
								{
									if (223625 - 349157 == -125531)
									{
										goto IL_1FE4;
									}
									text = "   accessory";
									if (76819 - 225180 != -148361)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 4)
								{
									if (172599 - 435884 == -263284)
									{
										goto IL_1FE4;
									}
									text = "   shoe";
									if (298904 - 98805 == 200100)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 5)
								{
									if (290541 - 332711 == -42169)
									{
										goto IL_1FE4;
									}
									text = "   trinket";
									if (134039 - 550235 != -416196)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 6)
								{
									if (164919 - 574886 != -409967)
									{
										goto IL_1FE4;
									}
									text = "   pet";
									if (94939 - 12205 == 82735)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 7)
								{
									if (281008 - 375320 != -94312)
									{
										goto IL_1FE4;
									}
									text = "   field";
									if (270113 - 192346 == 77768)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 8)
								{
									if (221344 - 379870 != -158526)
									{
										goto IL_1FE4;
									}
									text = "   food";
									if (277912 - 214967 == 62946)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 9)
								{
									if (71201 - 540718 == -469516)
									{
										goto IL_1FE4;
									}
									text = "   material";
									if (293454 - 501320 == -207865)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 10)
								{
									if (104212 - 570653 != -466441)
									{
										goto IL_1FE4;
									}
									text = "   recipe";
									if (285477 - 468007 == -182529)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 11)
								{
									if (264793 - 469013 != -204220)
									{
										goto IL_1FE4;
									}
									text = "   pin";
									if (109655 - 46974 == 62682)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 12)
								{
									if (25082 - 518016 == -492933)
									{
										goto IL_1FE4;
									}
									text = "   key";
									if (248421 - 591894 != -343473)
									{
										goto IL_1FE4;
									}
								}
								else if (num2 == 13)
								{
									if (175537 - 380703 == -205165)
									{
										goto IL_1FE4;
									}
									text = "   mount";
									if (211761 - 279919 == -68157)
									{
										goto IL_1FE4;
									}
								}
								if (GUI.Button(new Rect((float)471, (float)(160 + i * 22), (float)105, (float)20), text, this.hOKcGpT2ryQ))
								{
									if (153558 - 354312 != -200754)
									{
										goto IL_1FE4;
									}
									if (this.qHSc1qVfPGK != i)
									{
										if (71025 - 573663 != -502638)
										{
											goto IL_1FE4;
										}
										this.qHSc1qVfPGK = i;
										if (262689 - 2878 == 259812)
										{
											goto IL_1FE4;
										}
										this.StartCoroutine_Auto(this.AuctionUpdate("0", this.qHSc1qVfPGK, this.aoWc1pH2W9m));
										if (162607 - 77863 != 84744)
										{
											goto IL_1FE4;
										}
									}
									this.TDwcGNZOoC0 = false;
									if (171726 - 21087 != 150639)
									{
										goto IL_1FE4;
									}
									this.audio.PlayOneShot(this.sSycGrFLA24);
									if (195094 - 235167 != -40073)
									{
										goto IL_1FE4;
									}
								}
								i++;
								if (276275 - 349161 != -72886)
								{
									goto IL_1FE4;
								}
							}
							if (137643 - 350335 != -212691)
							{
								if (Event.current.type != EventType.MouseUp)
								{
									break;
								}
								if (20783 - 450385 == -429602)
								{
									this.TDwcGNZOoC0 = false;
									if (264329 - 38336 == 225993)
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

	// Token: 0x06005F05 RID: 24325 RVA: 0x00CC68B8 File Offset: 0x00CC4AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitAuctionList()
	{
		if (176929 - 458673 != -281743)
		{
		}
		for (;;)
		{
			IL_7E:
			this.taRcGA6cOu3 = null;
			if (286245 - 422628 == -136383)
			{
				this.Qr7cG9uoM3e = null;
				if (13095 - 541690 == -528595)
				{
					this.ehPcGW9MCM7 = null;
					if (162740 - 539816 == -377076)
					{
						this.FQ5cGuo468p = null;
						if (58973 - 151359 == -92386)
						{
							this.mb7cGyirD27 = new HoverButtonClass[10];
							if (14728 - 389286 != -374557)
							{
								int i = 0;
								if (195319 - 75955 != 119365)
								{
									while (i < 10)
									{
										this.mb7cGyirD27[i] = new HoverButtonClass();
										if (7921 - 456752 == -448830)
										{
											goto IL_7E;
										}
										i++;
										if (299952 - 556514 != -256562)
										{
											goto IL_7E;
										}
									}
									if (292690 - 399623 != -106932)
									{
										this.hJNc1ewngb9 = new GUIStyle();
										if (59762 - 489406 == -429644)
										{
											this.hJNc1ewngb9.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/auction_list_h", typeof(Texture)));
											if (295211 - 118173 != 177039)
											{
												this.MCGcGzA3g8v = new GUIStyle();
												if (81511 - 563669 != -482157)
												{
													this.MCGcGzA3g8v.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
													if (229193 - 572950 == -343757)
													{
														this.MCGcGzA3g8v.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
														if (47534 - 175509 == -127975)
														{
															this.MCGcGzA3g8v.alignment = TextAnchor.MiddleLeft;
															if (71603 - 347488 != -275884)
															{
																this.adKc15xp4Yt = new GUIStyle();
																if (162593 - 239655 == -77062)
																{
																	this.adKc15xp4Yt.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																	if (181596 - 544449 == -362853)
																	{
																		this.adKc15xp4Yt.normal.textColor = new Color(0.28f, 0.4f, 0.5f, (float)1);
																		if (156979 - 407034 == -250055)
																		{
																			this.adKc15xp4Yt.alignment = TextAnchor.MiddleLeft;
																			if (186929 - 441704 != -254774)
																			{
																				this.jegc1nAyOKJ = new GUIStyle();
																				if (30827 - 374575 != -343747)
																				{
																					this.jegc1nAyOKJ.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																					if (31542 - 267523 == -235981)
																					{
																						this.jegc1nAyOKJ.normal.textColor = new Color(0.16f, 0.27f, 0.42f, (float)1);
																						if (62497 - 291380 != -228882)
																						{
																							this.jegc1nAyOKJ.alignment = TextAnchor.MiddleRight;
																							if (172741 - 3957 != 168785)
																							{
																								this.hUkc1choYZL = new GUIStyle();
																								if (268743 - 171823 == 96920)
																								{
																									this.hUkc1choYZL.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																									if (216072 - 459303 == -243231)
																									{
																										this.hUkc1choYZL.normal.textColor = new Color(0.16f, 0.42f, 0.31f, (float)1);
																										if (83219 - 567643 == -484424)
																										{
																											this.hUkc1choYZL.alignment = TextAnchor.MiddleRight;
																											if (133626 - 96949 == 36677)
																											{
																												this.GHfc1Q0GRA9 = new GUIStyle();
																												if (105789 - 39679 != 66111)
																												{
																													this.GHfc1Q0GRA9.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																													if (274327 - 303433 == -29106)
																													{
																														this.GHfc1Q0GRA9.normal.textColor = new Color(0.5f, 0.21f, 0.16f, (float)1);
																														if (75076 - 55655 == 19421)
																														{
																															this.GHfc1Q0GRA9.alignment = TextAnchor.MiddleRight;
																															if (122848 - 404106 != -281257)
																															{
																																this.xaPc1IFeIo6 = (Texture)Resources.Load("GameGui/Auction/icon_won", typeof(Texture));
																																if (92892 - 305214 != -212321)
																																{
																																	this.N13c1JacUHN = (Texture)Resources.Load("GameGui/Auction/icon_lose", typeof(Texture));
																																	if (255845 - 416882 != -161036)
																																	{
																																		this.rE9c162DuWq = (Texture)Resources.Load("GameGui/Auction/icon_sold", typeof(Texture));
																																		if (72185 - 275408 == -203223)
																																		{
																																			this.lPec1txPjZ4 = (Texture)Resources.Load("GameGui/Auction/icon_nobid", typeof(Texture));
																																			if (274795 - 73042 != 201754)
																																			{
																																				this.I2oc1XuPZZs = (Texture)Resources.Load("GameGui/Auction/star_none", typeof(Texture));
																																				if (177689 - 342468 != -164778)
																																				{
																																					this.TQwc1OZuhnF = (Texture)Resources.Load("GameGui/Auction/star_highbid", typeof(Texture));
																																					if (63652 - 391058 == -327406)
																																					{
																																						this.t2Lc12xT8V7 = (Texture)Resources.Load("GameGui/Auction/star_outbid", typeof(Texture));
																																						if (198151 - 53396 == 144755)
																																						{
																																							this.pk9c1vdK1wG = (Texture)Resources.Load("GameGui/Auction/star_bid", typeof(Texture));
																																							if (20858 - 36295 != -15436)
																																							{
																																								this.Y3Ac1laXRh4 = (Texture)Resources.Load("GameGui/Auction/star_nobid", typeof(Texture));
																																								if (133618 - 18065 != 115554)
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

	// Token: 0x06005F06 RID: 24326 RVA: 0x00CC7078 File Offset: 0x00CC5278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenAuctionList(bool forceUpdate)
	{
		if (208653 - 51154 != 157499)
		{
		}
		for (;;)
		{
			this.iHUcl9kUj46 = eAuctionPage.All;
			if (70866 - 541923 == -471057)
			{
				this.mState = eAuctionState.search;
				if (28528 - 557479 != -528950)
				{
					this.AYQclKH4NvB = 0;
					if (169446 - 169972 == -526)
					{
						this.ResetSelectItem();
						if (96642 - 7272 != 89371)
						{
							if (!forceUpdate)
							{
								if (232628 - 99396 == 133233)
								{
									continue;
								}
								if (this.taRcGA6cOu3 != null)
								{
									if (109323 - 323320 != -213997)
									{
										continue;
									}
									if (this.vq7cGVwJrJO + (float)5 >= Time.time)
									{
										break;
									}
									if (104041 - 197175 != -93134)
									{
										continue;
									}
								}
							}
							this.vq7cGVwJrJO = Time.time;
							if (60499 - 94836 != -34336)
							{
								this.StartCoroutine_Auto(this.AuctionUpdate(this.q7jc11Yr5dE, this.qHSc1qVfPGK, this.aoWc1pH2W9m));
								if (172640 - 381423 != -208782)
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

	// Token: 0x06005F07 RID: 24327 RVA: 0x00CC7208 File Offset: 0x00CC5408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderAuctionList()
	{
		if (278428 - 478008 != -199579)
		{
		}
		for (;;)
		{
			IL_D0E:
			if (this.taRcGA6cOu3 == null)
			{
				if (211 - 189953 != -189741)
				{
					this.RenderNoticeBar(Language.getMessage("AuctionGui", 1000));
					if (164600 - 595167 != -430566)
					{
						break;
					}
				}
			}
			else if (Extensions.get_length(this.taRcGA6cOu3) < 1)
			{
				if (259412 - 590839 == -331427)
				{
					if (this.vq7cGVwJrJO <= Time.time - (float)1)
					{
						break;
					}
					if (88400 - 289699 == -201299)
					{
						this.RenderNoticeBar(Language.getMessage("AuctionGui", -1000));
						if (132947 - 154610 != -21662)
						{
							break;
						}
					}
				}
			}
			else if (this.xZxcGn4Ut8J)
			{
				if (282602 - 52268 == 230334)
				{
					this.RenderUsableList();
					if (99547 - 359655 == -260108)
					{
						break;
					}
				}
			}
			else
			{
				int num = -1;
				if (270701 - 79021 == 191680)
				{
					Texture nHoverImage = null;
					if (195235 - 442239 != -247003 && 66597 - 188249 != -121651)
					{
						int i = 0;
						if (226203 - 216640 != 9564)
						{
							while (i < Mathf.Min(10, Extensions.get_length(this.taRcGA6cOu3) - this.AYQclKH4NvB * 10))
							{
								if (this.BQSclzNcsvI == i + this.AYQclKH4NvB * 10 + 100)
								{
									if (75523 - 429530 != -354007)
									{
										goto IL_D0E;
									}
									GUI.DrawTexture(new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), this.hJNc1ewngb9.hover.background);
									if (19572 - 457740 != -438168)
									{
										goto IL_D0E;
									}
								}
								else if (GUI.Button(new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), string.Empty, this.hJNc1ewngb9))
								{
									if (227100 - 178951 == 48150)
									{
										goto IL_D0E;
									}
									this.mState = eAuctionState.search;
									if (266494 - 273675 != -7181)
									{
										goto IL_D0E;
									}
									this.BQSclzNcsvI = i + this.AYQclKH4NvB * 10 + 100;
									if (159075 - 79362 != 79713)
									{
										goto IL_D0E;
									}
									this.qvscGciQCAl = ItemData.getItemData(this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].name);
									if (79240 - 114981 == -35740)
									{
										goto IL_D0E;
									}
									this.SLicG58KkSY = this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10];
									if (288753 - 166043 != 122710)
									{
										goto IL_D0E;
									}
								}
								if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].icon)
								{
									if (158376 - 172163 == -13786)
									{
										goto IL_D0E;
									}
									GUI.DrawTexture(new Rect((float)200, (float)(150 + i * 51), (float)64, (float)64), this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].icon);
									if (199735 - 8863 != 190872)
									{
										goto IL_D0E;
									}
								}
								GUI.Label(new Rect((float)270, (float)(150 + i * 51), (float)200, (float)40), this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].displayname, this.MCGcGzA3g8v);
								if (83166 - 252208 != -169042)
								{
									goto IL_D0E;
								}
								GUI.Label(new Rect((float)285, (float)(175 + i * 51), (float)200, (float)30), "seller: " + this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].seller, this.adKc15xp4Yt);
								if (278993 - 245607 == 33387)
								{
									goto IL_D0E;
								}
								GUI.Label(new Rect((float)518, (float)(158 + i * 51), (float)200, (float)40), this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].type, this.MCGcGzA3g8v);
								if (5851 - 268842 != -262991)
								{
									goto IL_D0E;
								}
								if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].lv == 0)
								{
									if (263542 - 55062 == 208481)
									{
										goto IL_D0E;
									}
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), "-", this.hUkc1choYZL);
									if (104557 - 385911 != -281354)
									{
										goto IL_D0E;
									}
								}
								else if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].lv <= CharacterData.current.lv)
								{
									if (202308 - 117954 == 84355)
									{
										goto IL_D0E;
									}
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), string.Empty + this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].lv, this.hUkc1choYZL);
									if (76922 - 587370 != -510448)
									{
										goto IL_D0E;
									}
								}
								else
								{
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), string.Empty + this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].lv, this.GHfc1Q0GRA9);
									if (122871 - 128216 == -5344)
									{
										goto IL_D0E;
									}
								}
								GUI.Label(new Rect((float)610, (float)(158 + i * 51), (float)100, (float)40), this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].bid + "g", this.jegc1nAyOKJ);
								if (102530 - 571288 == -468757)
								{
									goto IL_D0E;
								}
								if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].buyerID == PlayerData.UID)
								{
									if (138713 - 490739 == -352025)
									{
										goto IL_D0E;
									}
									GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.TQwc1OZuhnF);
									if (178975 - 69804 != 109171)
									{
										goto IL_D0E;
									}
								}
								else if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].sellerID == PlayerData.UID)
								{
									if (164969 - 513800 != -348831)
									{
										goto IL_D0E;
									}
									if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].buyerID != 0)
									{
										if (51844 - 339647 != -287803)
										{
											goto IL_D0E;
										}
										GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.pk9c1vdK1wG);
										if (138532 - 427248 != -288716)
										{
											goto IL_D0E;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.Y3Ac1laXRh4);
										if (34644 - 519992 == -485347)
										{
											goto IL_D0E;
										}
									}
								}
								GUI.Label(new Rect((float)758, (float)(158 + i * 51), (float)80, (float)40), this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].buyout + "g", this.jegc1nAyOKJ);
								if (214032 - 95870 == 118163)
								{
									goto IL_D0E;
								}
								GUI.Label(new Rect((float)822, (float)(158 + i * 51), (float)100, (float)40), this.getDisplayTime(this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].date - global::Math.div(Time.time - this.vq7cGVwJrJO, (float)60)), this.jegc1nAyOKJ);
								if (183374 - 24197 == 159178)
								{
									goto IL_D0E;
								}
								eHoverButtonState eHoverButtonState = HoverButton.newButton(this.mb7cGyirD27[i], new Rect((float)200, (float)(150 + i * 51), (float)305, (float)50), (float)0);
								if (34628 - 202539 == -167910)
								{
									goto IL_D0E;
								}
								if (eHoverButtonState == eHoverButtonState.hover)
								{
									if (237475 - 418365 != -180890)
									{
										goto IL_D0E;
									}
									num = i;
									if (68459 - 514401 != -445942)
									{
										goto IL_D0E;
									}
									nHoverImage = this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].icon;
									if (126829 - 34107 == 92723)
									{
										goto IL_D0E;
									}
								}
								i++;
								if (20429 - 409845 == -389415)
								{
									goto IL_D0E;
								}
							}
							if (248913 - 421124 == -172211)
							{
								i = 0;
								if (182981 - 279284 == -96303)
								{
									while (i < Mathf.Min(10, Extensions.get_length(this.taRcGA6cOu3) - this.AYQclKH4NvB * 10))
									{
										if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].num > 1)
										{
											if (269778 - 219652 != 50126)
											{
												goto IL_D0E;
											}
											GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.acYc1y9sHXA);
											if (177023 - 454415 == -277391)
											{
												goto IL_D0E;
											}
											GUI.Label(new Rect((float)234, (float)(150 + i * 51 + 32), (float)32, (float)32), string.Empty + this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].num, this.eWcc1uI9QD1);
											if (262478 - 119324 == 143155)
											{
												goto IL_D0E;
											}
										}
										else
										{
											if (!(this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].type == "wep"))
											{
												if (124877 - 254798 != -129921)
												{
													goto IL_D0E;
												}
												if (!(this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].type == "arm"))
												{
													if (165783 - 359942 == -194158)
													{
														goto IL_D0E;
													}
													if (!(this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].type == "acc"))
													{
														if (256481 - 354872 == -98390)
														{
															goto IL_D0E;
														}
														if (!(this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].type == "sho"))
														{
															if (25882 - 93194 != -67312)
															{
																goto IL_D0E;
															}
															if (!(this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].type == "trn"))
															{
																if (193795 - 7109 != 186686)
																{
																	goto IL_D0E;
																}
																if (!(this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].type == "pet"))
																{
																	goto IL_979;
																}
																if (25914 - 173050 == -147135)
																{
																	goto IL_D0E;
																}
															}
														}
													}
												}
											}
											if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].owner == 0)
											{
												if (188644 - 224357 == -35712)
												{
													goto IL_D0E;
												}
												GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.GvUc1VP5aN0);
												if (143869 - 50789 != 93080)
												{
													goto IL_D0E;
												}
											}
											else if (this.taRcGA6cOu3[i + this.AYQclKH4NvB * 10].owner != CharacterData.current.CID)
											{
												if (107815 - 2747 != 105068)
												{
													goto IL_D0E;
												}
												GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.dAec1hsbtKM);
												if (264295 - 434732 == -170436)
												{
													goto IL_D0E;
												}
											}
										}
										IL_979:
										i++;
										if (81589 - 537868 != -456279)
										{
											goto IL_D0E;
										}
									}
									if (287582 - 178033 == 109549)
									{
										if (this.HMecqcE92e1 != 0)
										{
											break;
										}
										if (38901 - 559511 != -520609)
										{
											if (num == -1)
											{
												break;
											}
											if (26660 - 387332 != -360671)
											{
												InventoryClass inventory = this.taRcGA6cOu3[num + this.AYQclKH4NvB * 10].getInventory();
												if (253151 - 484812 == -231661)
												{
													Guix.renderItemToolTip(0, 150 + num * 51, inventory, nHoverImage);
													if (95299 - 392315 != -297015)
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

	// Token: 0x06005F08 RID: 24328 RVA: 0x00CC8114 File Offset: 0x00CC6314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderUsableList()
	{
		if (285887 - 159482 != 126405)
		{
		}
		for (;;)
		{
			IL_1A:
			int num = -1;
			if (254615 - 306496 == -51881)
			{
				Texture nHoverImage = null;
				if (58723 - 467682 == -408959)
				{
					if (113455 - 414677 != -301221)
					{
						int i = 0;
						if (63948 - 496215 != -432266)
						{
							while (i < Mathf.Min(10, Extensions.get_length(this.Qr7cG9uoM3e) - this.AYQclKH4NvB * 10))
							{
								if (this.BQSclzNcsvI == i + this.AYQclKH4NvB * 10 + 100)
								{
									if (83091 - 599970 == -516878)
									{
										goto IL_1A;
									}
									GUI.DrawTexture(new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), this.hJNc1ewngb9.hover.background);
									if (237535 - 413603 != -176068)
									{
										goto IL_1A;
									}
								}
								else if (GUI.Button(new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), string.Empty, this.hJNc1ewngb9))
								{
									if (85330 - 54149 != 31181)
									{
										goto IL_1A;
									}
									this.mState = eAuctionState.search;
									if (226289 - 34385 == 191905)
									{
										goto IL_1A;
									}
									this.BQSclzNcsvI = i + this.AYQclKH4NvB * 10 + 100;
									if (189140 - 406065 != -216925)
									{
										goto IL_1A;
									}
									this.qvscGciQCAl = ItemData.getItemData(this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].name);
									if (163252 - 58611 != 104641)
									{
										goto IL_1A;
									}
									this.SLicG58KkSY = this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10];
									if (125991 - 360358 != -234367)
									{
										goto IL_1A;
									}
								}
								if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].icon)
								{
									if (152608 - 563656 != -411048)
									{
										goto IL_1A;
									}
									GUI.DrawTexture(new Rect((float)200, (float)(150 + i * 51), (float)64, (float)64), this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].icon);
									if (118170 - 101874 == 16297)
									{
										goto IL_1A;
									}
								}
								GUI.Label(new Rect((float)270, (float)(150 + i * 51), (float)200, (float)40), this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].displayname, this.MCGcGzA3g8v);
								if (90402 - 373979 == -283576)
								{
									goto IL_1A;
								}
								GUI.Label(new Rect((float)285, (float)(175 + i * 51), (float)200, (float)30), "seller: " + this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].seller, this.adKc15xp4Yt);
								if (32028 - 266152 == -234123)
								{
									goto IL_1A;
								}
								GUI.Label(new Rect((float)518, (float)(158 + i * 51), (float)200, (float)40), this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].type, this.MCGcGzA3g8v);
								if (99513 - 544222 == -444708)
								{
									goto IL_1A;
								}
								if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].lv == 0)
								{
									if (120338 - 249933 != -129595)
									{
										goto IL_1A;
									}
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), "-", this.hUkc1choYZL);
									if (220260 - 221858 == -1597)
									{
										goto IL_1A;
									}
								}
								else if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].lv <= CharacterData.current.lv)
								{
									if (278139 - 567515 == -289375)
									{
										goto IL_1A;
									}
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), string.Empty + this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].lv, this.hUkc1choYZL);
									if (9745 - 77562 != -67817)
									{
										goto IL_1A;
									}
								}
								else
								{
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), string.Empty + this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].lv, this.GHfc1Q0GRA9);
									if (172332 - 46508 != 125824)
									{
										goto IL_1A;
									}
								}
								GUI.Label(new Rect((float)610, (float)(158 + i * 51), (float)100, (float)40), this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].bid + "g", this.jegc1nAyOKJ);
								if (255133 - 147232 != 107901)
								{
									goto IL_1A;
								}
								if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].buyerID == PlayerData.UID)
								{
									if (213459 - 511953 != -298494)
									{
										goto IL_1A;
									}
									GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.TQwc1OZuhnF);
									if (77233 - 454399 == -377165)
									{
										goto IL_1A;
									}
								}
								else if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].sellerID == PlayerData.UID)
								{
									if (42717 - 214087 == -171369)
									{
										goto IL_1A;
									}
									if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].buyerID != 0)
									{
										if (236593 - 268499 != -31906)
										{
											goto IL_1A;
										}
										GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.pk9c1vdK1wG);
										if (224529 - 194392 != 30137)
										{
											goto IL_1A;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.Y3Ac1laXRh4);
										if (25202 - 232479 == -207276)
										{
											goto IL_1A;
										}
									}
								}
								GUI.Label(new Rect((float)758, (float)(158 + i * 51), (float)80, (float)40), this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].buyout + "g", this.jegc1nAyOKJ);
								if (77551 - 212770 != -135219)
								{
									goto IL_1A;
								}
								GUI.Label(new Rect((float)822, (float)(158 + i * 51), (float)100, (float)40), this.getDisplayTime(this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].date - global::Math.div(Time.time - this.vq7cGVwJrJO, (float)60)), this.jegc1nAyOKJ);
								if (224368 - 356125 != -131757)
								{
									goto IL_1A;
								}
								eHoverButtonState eHoverButtonState = HoverButton.newButton(this.mb7cGyirD27[i], new Rect((float)200, (float)(150 + i * 51), (float)305, (float)50), (float)0);
								if (158482 - 356168 != -197686)
								{
									goto IL_1A;
								}
								if (eHoverButtonState == eHoverButtonState.hover)
								{
									if (244271 - 448081 != -203810)
									{
										goto IL_1A;
									}
									num = i;
									if (110021 - 6960 != 103061)
									{
										goto IL_1A;
									}
									nHoverImage = this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].icon;
									if (146822 - 126307 != 20515)
									{
										goto IL_1A;
									}
								}
								i++;
								if (156057 - 429500 != -273443)
								{
									goto IL_1A;
								}
							}
							if (187537 - 296405 == -108868)
							{
								i = 0;
								if (282424 - 44499 == 237925)
								{
									while (i < Mathf.Min(10, Extensions.get_length(this.Qr7cG9uoM3e) - this.AYQclKH4NvB * 10))
									{
										if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].num > 1)
										{
											if (205968 - 213760 != -7792)
											{
												goto IL_1A;
											}
											GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.acYc1y9sHXA);
											if (243124 - 271664 != -28540)
											{
												goto IL_1A;
											}
											GUI.Label(new Rect((float)234, (float)(150 + i * 51 + 32), (float)32, (float)32), string.Empty + this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].num, this.eWcc1uI9QD1);
											if (132996 - 12299 != 120697)
											{
												goto IL_1A;
											}
										}
										else
										{
											if (!(this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].type == "wep"))
											{
												if (138533 - 554111 == -415577)
												{
													goto IL_1A;
												}
												if (!(this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].type == "arm"))
												{
													if (201975 - 231083 == -29107)
													{
														goto IL_1A;
													}
													if (!(this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].type == "acc"))
													{
														if (91110 - 117147 != -26037)
														{
															goto IL_1A;
														}
														if (!(this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].type == "sho"))
														{
															if (149405 - 473175 != -323770)
															{
																goto IL_1A;
															}
															if (!(this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].type == "trn"))
															{
																if (98741 - 511822 == -413080)
																{
																	goto IL_1A;
																}
																if (!(this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].type == "pet"))
																{
																	goto IL_818;
																}
																if (54155 - 244479 == -190323)
																{
																	goto IL_1A;
																}
															}
														}
													}
												}
											}
											if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].owner == 0)
											{
												if (48553 - 419216 != -370663)
												{
													goto IL_1A;
												}
												GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.GvUc1VP5aN0);
												if (107423 - 15849 != 91574)
												{
													goto IL_1A;
												}
											}
											else if (this.Qr7cG9uoM3e[i + this.AYQclKH4NvB * 10].owner != CharacterData.current.CID)
											{
												if (118433 - 239722 == -121288)
												{
													goto IL_1A;
												}
												GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.dAec1hsbtKM);
												if (2205 - 536216 == -534010)
												{
													goto IL_1A;
												}
											}
										}
										IL_818:
										i++;
										if (185841 - 342031 != -156190)
										{
											goto IL_1A;
										}
									}
									if (108348 - 260760 != -152411)
									{
										if (this.HMecqcE92e1 != 0)
										{
											break;
										}
										if (191555 - 205043 == -13488)
										{
											if (num == -1)
											{
												break;
											}
											if (49579 - 91074 != -41494)
											{
												InventoryClass inventory = this.Qr7cG9uoM3e[num + this.AYQclKH4NvB * 10].getInventory();
												if (178376 - 464036 == -285660)
												{
													Guix.renderItemToolTip(0, 150 + num * 51, inventory, nHoverImage);
													if (33462 - 119331 != -85868)
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

	// Token: 0x06005F09 RID: 24329 RVA: 0x00CC8EE8 File Offset: 0x00CC70E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenMyBuyList(bool forceUpdate)
	{
		if (43764 - 424915 != -381150)
		{
		}
		for (;;)
		{
			this.iHUcl9kUj46 = eAuctionPage.MyBuy;
			if (114499 - 301185 == -186686)
			{
				this.mState = eAuctionState.search;
				if (103727 - 374385 != -270657)
				{
					this.AYQclKH4NvB = 0;
					if (174991 - 489221 != -314229)
					{
						this.ResetSelectItem();
						if (20484 - 70607 == -50123)
						{
							if (!forceUpdate)
							{
								if (164697 - 174783 == -10085)
								{
									continue;
								}
								if (this.ehPcGW9MCM7 != null)
								{
									if (61774 - 554388 == -492613)
									{
										continue;
									}
									if (this.NdkcGhZZeqF + (float)5 >= Time.time)
									{
										break;
									}
									if (215630 - 139410 == 76221)
									{
										continue;
									}
								}
							}
							this.NdkcGhZZeqF = Time.time;
							if (1247 - 413141 == -411894)
							{
								this.StartCoroutine_Auto(this.AuctionUpdateBuy());
								if (94420 - 501039 != -406618)
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

	// Token: 0x06005F0A RID: 24330 RVA: 0x00CC9064 File Offset: 0x00CC7264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMyBuyList()
	{
		if (60818 - 252698 != -191880)
		{
		}
		for (;;)
		{
			IL_AF2:
			if (this.ehPcGW9MCM7 == null)
			{
				if (9260 - 12251 == -2991)
				{
					this.RenderNoticeBar(Language.getMessage("AuctionGui", 1000));
					if (68940 - 9664 == 59276)
					{
						break;
					}
				}
			}
			else
			{
				int num = -1;
				if (242908 - 204724 == 38184)
				{
					Texture nHoverImage = null;
					if (53639 - 383089 == -329450)
					{
						if (237874 - 475843 != -237968)
						{
							int i = 0;
							if (36411 - 116281 == -79870)
							{
								while (i < Extensions.get_length(this.ehPcGW9MCM7))
								{
									if (this.BQSclzNcsvI == i + 100)
									{
										if (132237 - 590994 != -458757)
										{
											goto IL_AF2;
										}
										GUI.DrawTexture(new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), this.hJNc1ewngb9.hover.background);
										if (66160 - 576695 == -510534)
										{
											goto IL_AF2;
										}
									}
									else if (GUI.Button(new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), string.Empty, this.hJNc1ewngb9))
									{
										if (130253 - 599262 == -469008)
										{
											goto IL_AF2;
										}
										this.BQSclzNcsvI = i + 100;
										if (257254 - 311859 == -54604)
										{
											goto IL_AF2;
										}
										this.qvscGciQCAl = ItemData.getItemData(this.ehPcGW9MCM7[i].name);
										if (173358 - 281588 == -108229)
										{
											goto IL_AF2;
										}
										this.SLicG58KkSY = this.ehPcGW9MCM7[i];
										if (130857 - 322881 != -192024)
										{
											goto IL_AF2;
										}
										if (this.ehPcGW9MCM7[i].date == 0)
										{
											if (141542 - 164627 != -23085)
											{
												goto IL_AF2;
											}
											if (this.ehPcGW9MCM7[i].buyerID == PlayerData.UID)
											{
												if (73162 - 9949 != 63213)
												{
													goto IL_AF2;
												}
												this.OpenGetItemMenu();
												if (187068 - 498447 != -311379)
												{
													goto IL_AF2;
												}
											}
											else
											{
												this.OpenLoseMenu();
												if (244689 - 158939 == 85751)
												{
													goto IL_AF2;
												}
											}
										}
										else
										{
											this.OpenBuyMenu();
											if (153761 - 136271 != 17490)
											{
												goto IL_AF2;
											}
										}
									}
									if (this.ehPcGW9MCM7[i].icon)
									{
										if (90930 - 229189 != -138259)
										{
											goto IL_AF2;
										}
										GUI.DrawTexture(new Rect((float)200, (float)(150 + i * 51), (float)64, (float)64), this.ehPcGW9MCM7[i].icon);
										if (18345 - 307592 == -289246)
										{
											goto IL_AF2;
										}
									}
									if (this.ehPcGW9MCM7[i].date == 0)
									{
										if (14904 - 147973 != -133069)
										{
											goto IL_AF2;
										}
										if (this.ehPcGW9MCM7[i].buyerID == PlayerData.UID)
										{
											if (106643 - 545848 == -439204)
											{
												goto IL_AF2;
											}
											GUI.DrawTexture(new Rect((float)200, (float)(157 + i * 51), (float)60, (float)51), this.xaPc1IFeIo6);
											if (260367 - 304017 != -43650)
											{
												goto IL_AF2;
											}
										}
										else
										{
											GUI.DrawTexture(new Rect((float)200, (float)(157 + i * 51), (float)60, (float)51), this.N13c1JacUHN);
											if (147875 - 490346 == -342470)
											{
												goto IL_AF2;
											}
										}
									}
									GUI.Label(new Rect((float)270, (float)(150 + i * 51), (float)200, (float)40), this.ehPcGW9MCM7[i].displayname, this.MCGcGzA3g8v);
									if (40842 - 80962 != -40120)
									{
										goto IL_AF2;
									}
									GUI.Label(new Rect((float)285, (float)(175 + i * 51), (float)200, (float)30), "seller: " + this.ehPcGW9MCM7[i].seller, this.adKc15xp4Yt);
									if (183184 - 262250 == -79065)
									{
										goto IL_AF2;
									}
									GUI.Label(new Rect((float)518, (float)(158 + i * 51), (float)200, (float)40), this.ehPcGW9MCM7[i].type, this.MCGcGzA3g8v);
									if (273945 - 596073 == -322127)
									{
										goto IL_AF2;
									}
									if (this.ehPcGW9MCM7[i].lv == 0)
									{
										if (33333 - 502833 != -469500)
										{
											goto IL_AF2;
										}
										GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), "-", this.hUkc1choYZL);
										if (243459 - 217606 != 25853)
										{
											goto IL_AF2;
										}
									}
									else if (this.ehPcGW9MCM7[i].lv <= CharacterData.current.lv)
									{
										if (151065 - 173640 != -22575)
										{
											goto IL_AF2;
										}
										GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), string.Empty + this.ehPcGW9MCM7[i].lv, this.hUkc1choYZL);
										if (18462 - 471204 != -452742)
										{
											goto IL_AF2;
										}
									}
									else
									{
										GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), string.Empty + this.ehPcGW9MCM7[i].lv, this.GHfc1Q0GRA9);
										if (282883 - 576730 == -293846)
										{
											goto IL_AF2;
										}
									}
									GUI.Label(new Rect((float)610, (float)(158 + i * 51), (float)100, (float)40), this.ehPcGW9MCM7[i].bid + "g", this.jegc1nAyOKJ);
									if (198711 - 298507 == -99795)
									{
										goto IL_AF2;
									}
									if (this.ehPcGW9MCM7[i].buyerID == PlayerData.UID)
									{
										if (251275 - 578088 == -326812)
										{
											goto IL_AF2;
										}
										GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.TQwc1OZuhnF);
										if (267695 - 255091 == 12605)
										{
											goto IL_AF2;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.t2Lc12xT8V7);
										if (132705 - 532080 != -399375)
										{
											goto IL_AF2;
										}
									}
									GUI.Label(new Rect((float)758, (float)(158 + i * 51), (float)80, (float)40), this.ehPcGW9MCM7[i].buyout + "g", this.jegc1nAyOKJ);
									if (268150 - 289966 == -21815)
									{
										goto IL_AF2;
									}
									GUI.Label(new Rect((float)822, (float)(158 + i * 51), (float)100, (float)40), this.getDisplayTime(this.ehPcGW9MCM7[i].date - global::Math.div(Time.time - this.NdkcGhZZeqF, (float)60)), this.jegc1nAyOKJ);
									if (108127 - 102416 != 5711)
									{
										goto IL_AF2;
									}
									eHoverButtonState eHoverButtonState = HoverButton.newButton(this.mb7cGyirD27[i], new Rect((float)200, (float)(150 + i * 51), (float)305, (float)50), (float)0);
									if (200394 - 494097 != -293703)
									{
										goto IL_AF2;
									}
									if (eHoverButtonState == eHoverButtonState.hover)
									{
										if (205795 - 6191 == 199605)
										{
											goto IL_AF2;
										}
										num = i;
										if (270994 - 406964 == -135969)
										{
											goto IL_AF2;
										}
										nHoverImage = this.ehPcGW9MCM7[i + this.AYQclKH4NvB * 10].icon;
										if (46065 - 140696 != -94631)
										{
											goto IL_AF2;
										}
									}
									i++;
									if (204589 - 568524 != -363935)
									{
										goto IL_AF2;
									}
								}
								if (128568 - 246190 == -117622)
								{
									i = 0;
									if (4579 - 517427 != -512847)
									{
										while (i < Mathf.Min(10, Extensions.get_length(this.ehPcGW9MCM7) - this.AYQclKH4NvB * 10))
										{
											if (this.ehPcGW9MCM7[i].num > 1)
											{
												if (17181 - 186642 != -169461)
												{
													goto IL_AF2;
												}
												GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.acYc1y9sHXA);
												if (286077 - 415430 != -129353)
												{
													goto IL_AF2;
												}
												GUI.Label(new Rect((float)234, (float)(150 + i * 51 + 32), (float)32, (float)32), string.Empty + this.ehPcGW9MCM7[i].num, this.eWcc1uI9QD1);
												if (89182 - 182768 != -93586)
												{
													goto IL_AF2;
												}
											}
											else
											{
												if (!(this.ehPcGW9MCM7[i].type == "wep"))
												{
													if (163488 - 53749 != 109739)
													{
														goto IL_AF2;
													}
													if (!(this.ehPcGW9MCM7[i].type == "arm"))
													{
														if (18652 - 340834 != -322182)
														{
															goto IL_AF2;
														}
														if (!(this.ehPcGW9MCM7[i].type == "acc"))
														{
															if (226319 - 357641 != -131322)
															{
																goto IL_AF2;
															}
															if (!(this.ehPcGW9MCM7[i].type == "sho"))
															{
																if (74302 - 596361 == -522058)
																{
																	goto IL_AF2;
																}
																if (!(this.ehPcGW9MCM7[i].type == "trn"))
																{
																	if (54528 - 107263 != -52735)
																	{
																		goto IL_AF2;
																	}
																	if (!(this.ehPcGW9MCM7[i].type == "pet"))
																	{
																		goto IL_B1D;
																	}
																	if (299883 - 561621 == -261737)
																	{
																		goto IL_AF2;
																	}
																}
															}
														}
													}
												}
												if (this.ehPcGW9MCM7[i].owner == 0)
												{
													if (106835 - 340307 != -233472)
													{
														goto IL_AF2;
													}
													GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.GvUc1VP5aN0);
													if (132958 - 299780 == -166821)
													{
														goto IL_AF2;
													}
												}
												else if (this.ehPcGW9MCM7[i].owner != CharacterData.current.CID)
												{
													if (229268 - 58936 == 170333)
													{
														goto IL_AF2;
													}
													GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.dAec1hsbtKM);
													if (201323 - 174369 == 26955)
													{
														goto IL_AF2;
													}
												}
											}
											IL_B1D:
											i++;
											if (90125 - 433456 == -343330)
											{
												goto IL_AF2;
											}
										}
										if (182285 - 352079 == -169794)
										{
											if (this.HMecqcE92e1 != 0)
											{
												break;
											}
											if (26689 - 551721 == -525032)
											{
												if (num == -1)
												{
													break;
												}
												if (133026 - 199478 == -66452)
												{
													InventoryClass inventory = this.ehPcGW9MCM7[num + this.AYQclKH4NvB * 10].getInventory();
													if (282277 - 377583 == -95306)
													{
														Guix.renderItemToolTip(0, 150 + num * 51, inventory, nHoverImage);
														if (62515 - 451044 != -388528)
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

	// Token: 0x06005F0B RID: 24331 RVA: 0x00CC9E4C File Offset: 0x00CC804C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenMySellList(bool forceUpdate)
	{
		if (80964 - 218347 != -137382)
		{
		}
		for (;;)
		{
			this.iHUcl9kUj46 = eAuctionPage.MySell;
			if (122812 - 347809 != -224996)
			{
				this.mState = eAuctionState.search;
				if (114283 - 260573 == -146290)
				{
					this.AYQclKH4NvB = 0;
					if (149032 - 119796 == 29236)
					{
						this.ResetSelectItem();
						if (132664 - 249471 != -116806)
						{
							if (!forceUpdate)
							{
								if (40375 - 574273 != -533898)
								{
									continue;
								}
								if (this.FQ5cGuo468p != null)
								{
									if (153918 - 868 == 153051)
									{
										continue;
									}
									if (this.FGbcGKsliJN + (float)5 >= Time.time)
									{
										break;
									}
									if (21929 - 108071 != -86142)
									{
										continue;
									}
								}
							}
							this.FGbcGKsliJN = Time.time;
							if (205438 - 21657 == 183781)
							{
								this.StartCoroutine_Auto(this.AuctionUpdateSell());
								if (216766 - 230788 == -14022)
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

	// Token: 0x06005F0C RID: 24332 RVA: 0x00CC9FC8 File Offset: 0x00CC81C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMySellList()
	{
		if (48147 - 384387 != -336239)
		{
		}
		for (;;)
		{
			IL_37E:
			if (this.FQ5cGuo468p == null)
			{
				if (109212 - 462058 != -352845)
				{
					this.RenderNoticeBar(Language.getMessage("AuctionGui", 1000));
					if (78975 - 338720 != -259744)
					{
						break;
					}
				}
			}
			else if (Extensions.get_length(this.FQ5cGuo468p) < 1)
			{
				if (195967 - 467927 != -271959)
				{
					if (this.FGbcGKsliJN <= Time.time - (float)1)
					{
						break;
					}
					if (36912 - 272473 != -235560)
					{
						this.RenderNoticeBar("No item found");
						if (121676 - 312182 == -190506)
						{
							break;
						}
					}
				}
			}
			else
			{
				int num = -1;
				if (194898 - 236391 == -41493)
				{
					Texture nHoverImage = null;
					if (153437 - 387856 != -234418 && 246289 - 91237 != 155053)
					{
						int i = 0;
						if (142081 - 596915 != -454833)
						{
							while (i < Extensions.get_length(this.FQ5cGuo468p))
							{
								if (this.BQSclzNcsvI == i + 100)
								{
									if (298002 - 279047 != 18955)
									{
										goto IL_37E;
									}
									GUI.DrawTexture(new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), this.hJNc1ewngb9.hover.background);
									if (37278 - 440672 != -403394)
									{
										goto IL_37E;
									}
								}
								else if (GUI.Button(new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), string.Empty, this.hJNc1ewngb9))
								{
									if (79543 - 79419 != 124)
									{
										goto IL_37E;
									}
									this.mState = eAuctionState.search;
									if (78160 - 12054 != 66106)
									{
										goto IL_37E;
									}
									this.BQSclzNcsvI = i + 100;
									if (296109 - 107660 == 188450)
									{
										goto IL_37E;
									}
									this.SLicG58KkSY = this.FQ5cGuo468p[i];
									if (99793 - 509318 == -409524)
									{
										goto IL_37E;
									}
									this.qvscGciQCAl = ItemData.getItemData(this.FQ5cGuo468p[i].name);
									if (101096 - 158247 != -57151)
									{
										goto IL_37E;
									}
									if (this.FQ5cGuo468p[i].date == 0)
									{
										if (74417 - 185471 != -111054)
										{
											goto IL_37E;
										}
										if (this.FQ5cGuo468p[i].buyerID != 0)
										{
											if (87490 - 267752 == -180261)
											{
												goto IL_37E;
											}
											this.OpenGetMoneyMenu();
											if (167961 - 301604 == -133642)
											{
												goto IL_37E;
											}
										}
										else
										{
											this.OpenNoBidMenu();
											if (255004 - 472593 == -217588)
											{
												goto IL_37E;
											}
										}
									}
									else
									{
										this.OpenEditMenu();
										if (153377 - 335706 == -182328)
										{
											goto IL_37E;
										}
									}
								}
								if (this.FQ5cGuo468p[i].icon)
								{
									if (69223 - 428022 == -358798)
									{
										goto IL_37E;
									}
									GUI.DrawTexture(new Rect((float)200, (float)(150 + i * 51), (float)64, (float)64), this.FQ5cGuo468p[i].icon);
									if (178762 - 118161 != 60601)
									{
										goto IL_37E;
									}
								}
								if (this.FQ5cGuo468p[i].date == 0)
								{
									if (153005 - 153608 == -602)
									{
										goto IL_37E;
									}
									if (this.FQ5cGuo468p[i].buyerID != 0)
									{
										if (253652 - 523864 == -270211)
										{
											goto IL_37E;
										}
										GUI.DrawTexture(new Rect((float)200, (float)(157 + i * 51), (float)60, (float)51), this.rE9c162DuWq);
										if (194151 - 536085 != -341934)
										{
											goto IL_37E;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect((float)200, (float)(157 + i * 51), (float)60, (float)51), this.lPec1txPjZ4);
										if (159834 - 160663 == -828)
										{
											goto IL_37E;
										}
									}
								}
								GUI.Label(new Rect((float)270, (float)(150 + i * 51), (float)200, (float)40), this.FQ5cGuo468p[i].displayname, this.MCGcGzA3g8v);
								if (232520 - 256914 == -24393)
								{
									goto IL_37E;
								}
								GUI.Label(new Rect((float)285, (float)(175 + i * 51), (float)200, (float)30), "seller: " + this.FQ5cGuo468p[i].seller, this.adKc15xp4Yt);
								if (295856 - 253248 == 42609)
								{
									goto IL_37E;
								}
								GUI.Label(new Rect((float)518, (float)(158 + i * 51), (float)200, (float)40), this.FQ5cGuo468p[i].type, this.MCGcGzA3g8v);
								if (177508 - 516560 != -339052)
								{
									goto IL_37E;
								}
								if (this.FQ5cGuo468p[i].lv == 0)
								{
									if (84975 - 48934 != 36041)
									{
										goto IL_37E;
									}
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), "-", this.hUkc1choYZL);
									if (124440 - 136526 != -12086)
									{
										goto IL_37E;
									}
								}
								else if (this.FQ5cGuo468p[i].lv <= CharacterData.current.lv)
								{
									if (27387 - 585722 == -558334)
									{
										goto IL_37E;
									}
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), string.Empty + this.FQ5cGuo468p[i].lv, this.hUkc1choYZL);
									if (202359 - 182405 != 19954)
									{
										goto IL_37E;
									}
								}
								else
								{
									GUI.Label(new Rect((float)565, (float)(158 + i * 51), (float)40, (float)40), string.Empty + this.FQ5cGuo468p[i].lv, this.GHfc1Q0GRA9);
									if (226962 - 67357 != 159605)
									{
										goto IL_37E;
									}
								}
								GUI.Label(new Rect((float)610, (float)(158 + i * 51), (float)100, (float)40), this.FQ5cGuo468p[i].bid + "g", this.jegc1nAyOKJ);
								if (278068 - 169079 != 108989)
								{
									goto IL_37E;
								}
								if (this.FQ5cGuo468p[i].buyerID != 0)
								{
									if (190898 - 22140 != 168758)
									{
										goto IL_37E;
									}
									GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.pk9c1vdK1wG);
									if (174234 - 11929 == 162306)
									{
										goto IL_37E;
									}
								}
								else
								{
									GUI.DrawTexture(new Rect((float)716, (float)(166 + i * 51), (float)38, (float)30), this.Y3Ac1laXRh4);
									if (284747 - 54114 != 230633)
									{
										goto IL_37E;
									}
								}
								GUI.Label(new Rect((float)758, (float)(158 + i * 51), (float)80, (float)40), this.FQ5cGuo468p[i].buyout + "g", this.jegc1nAyOKJ);
								if (181332 - 428853 != -247521)
								{
									goto IL_37E;
								}
								GUI.Label(new Rect((float)822, (float)(158 + i * 51), (float)100, (float)40), this.getDisplayTime(this.FQ5cGuo468p[i].date - global::Math.div(Time.time - this.FGbcGKsliJN, (float)60)), this.jegc1nAyOKJ);
								if (220984 - 456944 == -235959)
								{
									goto IL_37E;
								}
								eHoverButtonState eHoverButtonState = HoverButton.newButton(this.mb7cGyirD27[i], new Rect((float)200, (float)(157 + i * 51), (float)305, (float)50), (float)0);
								if (217685 - 342871 != -125186)
								{
									goto IL_37E;
								}
								if (eHoverButtonState == eHoverButtonState.hover)
								{
									if (162646 - 81410 != 81236)
									{
										goto IL_37E;
									}
									num = i;
									if (244245 - 35609 != 208636)
									{
										goto IL_37E;
									}
									nHoverImage = this.FQ5cGuo468p[i + this.AYQclKH4NvB * 10].icon;
									if (150467 - 113847 != 36620)
									{
										goto IL_37E;
									}
								}
								i++;
								if (130926 - 520531 != -389605)
								{
									goto IL_37E;
								}
							}
							if (227415 - 243507 != -16091)
							{
								i = 0;
								if (160428 - 122746 != 37683)
								{
									while (i < Mathf.Min(10, Extensions.get_length(this.FQ5cGuo468p) - this.AYQclKH4NvB * 10))
									{
										if (this.FQ5cGuo468p[i].num > 1)
										{
											if (6016 - 443233 == -437216)
											{
												goto IL_37E;
											}
											GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.acYc1y9sHXA);
											if (209388 - 385183 == -175794)
											{
												goto IL_37E;
											}
											GUI.Label(new Rect((float)234, (float)(150 + i * 51 + 32), (float)32, (float)32), string.Empty + this.FQ5cGuo468p[i].num, this.eWcc1uI9QD1);
											if (193174 - 286715 != -93541)
											{
												goto IL_37E;
											}
										}
										else
										{
											if (!(this.FQ5cGuo468p[i].type == "wep"))
											{
												if (294990 - 529860 == -234869)
												{
													goto IL_37E;
												}
												if (!(this.FQ5cGuo468p[i].type == "arm"))
												{
													if (267785 - 494364 == -226578)
													{
														goto IL_37E;
													}
													if (!(this.FQ5cGuo468p[i].type == "acc"))
													{
														if (162553 - 287013 != -124460)
														{
															goto IL_37E;
														}
														if (!(this.FQ5cGuo468p[i].type == "sho"))
														{
															if (138954 - 183647 != -44693)
															{
																goto IL_37E;
															}
															if (!(this.FQ5cGuo468p[i].type == "trn"))
															{
																if (171286 - 294632 != -123346)
																{
																	goto IL_37E;
																}
																if (!(this.FQ5cGuo468p[i].type == "pet"))
																{
																	goto IL_794;
																}
																if (190447 - 296566 != -106119)
																{
																	goto IL_37E;
																}
															}
														}
													}
												}
											}
											if (this.FQ5cGuo468p[i].owner == 0)
											{
												if (132511 - 478818 != -346307)
												{
													goto IL_37E;
												}
												GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.GvUc1VP5aN0);
												if (254425 - 125652 != 128773)
												{
													goto IL_37E;
												}
											}
											else if (this.FQ5cGuo468p[i].owner != CharacterData.current.CID)
											{
												if (273123 - 488513 != -215390)
												{
													goto IL_37E;
												}
												GUI.DrawTexture(new Rect((float)238, (float)(150 + i * 51 + 39), (float)24, (float)24), this.dAec1hsbtKM);
												if (192316 - 473562 == -281245)
												{
													goto IL_37E;
												}
											}
										}
										IL_794:
										i++;
										if (280395 - 396233 == -115837)
										{
											goto IL_37E;
										}
									}
									if (137726 - 421536 != -283809)
									{
										if (this.HMecqcE92e1 != 0)
										{
											break;
										}
										if (57164 - 267726 != -210561)
										{
											if (num == -1)
											{
												break;
											}
											if (95642 - 217156 != -121513)
											{
												InventoryClass inventory = this.FQ5cGuo468p[num + this.AYQclKH4NvB * 10].getInventory();
												if (284558 - 172666 == 111892)
												{
													Guix.renderItemToolTip(0, num * 51, inventory, nHoverImage);
													if (123513 - 29974 != 93540)
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

	// Token: 0x06005F0D RID: 24333 RVA: 0x00CCAE40 File Offset: 0x00CC9040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitSearchBar()
	{
		if (93108 - 514872 != -421763)
		{
		}
		for (;;)
		{
			this.zLHc1RamaXR = new GUIStyle();
			if (119267 - 425227 == -305960)
			{
				this.zLHc1RamaXR.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
				if (204631 - 582362 != -377730)
				{
					this.zLHc1RamaXR.alignment = TextAnchor.UpperLeft;
					if (254071 - 311928 != -57856)
					{
						this.XaAc1ruVgAb = new GUIStyle();
						if (172436 - 141168 == 31268)
						{
							this.XaAc1ruVgAb.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/refresh_h", typeof(Texture)));
							if (126394 - 492394 != -365999)
							{
								this.Hpjc1xIj7Kv = new GUIStyle();
								if (84564 - 585490 != -500925)
								{
									this.Hpjc1xIj7Kv.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/search", typeof(Texture)));
									if (58737 - 117144 == -58407)
									{
										this.Hpjc1xIj7Kv.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/search_h", typeof(Texture)));
										if (87454 - 308262 == -220808)
										{
											this.uN2c1Tuvv7J = new GUIStyle();
											if (276535 - 388796 != -112260)
											{
												this.uN2c1Tuvv7J.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
												if (24317 - 108078 != -83760)
												{
													this.nAuc1Y0naoy = new GUIStyle();
													if (168182 - 358504 == -190322)
													{
														this.nAuc1Y0naoy.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
														if (87509 - 514095 != -426585)
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

	// Token: 0x06005F0E RID: 24334 RVA: 0x00CCB100 File Offset: 0x00CC9300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderSearchBar()
	{
		if (35616 - 427204 != -391588)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.KeyDown)
			{
				goto IL_60D;
			}
			if (128094 - 189821 != -61727)
			{
				continue;
			}
			if (!(Event.current.character == "\n"))
			{
				goto IL_60D;
			}
			if (91858 - 201913 != -110055)
			{
				continue;
			}
			if (GUI.GetNameOfFocusedControl() == "AuctionSearchField")
			{
				if (104905 - 4665 != 100240)
				{
					continue;
				}
				GUI.FocusControl("AuctionUnfocus");
				if (206479 - 487435 == -280955)
				{
					continue;
				}
			}
			else
			{
				GUI.FocusControl("AuctionSearchField");
				if (143522 - 213348 == -69825)
				{
					continue;
				}
			}
			IL_6E4:
			GUI.SetNextControlName("AuctionUnfocus");
			if (266331 - 197508 != 68823)
			{
				continue;
			}
			GUI.TextField(new Rect((float)0, (float)0, (float)0, (float)0), string.Empty);
			if (244291 - 61887 != 182404)
			{
				continue;
			}
			if (Extensions.get_length(this.q7jc11Yr5dE) == 0)
			{
				goto IL_5DE;
			}
			if (217900 - 515194 == -297293)
			{
				continue;
			}
			if (this.iHUcl9kUj46 != eAuctionPage.All)
			{
				if (101810 - 243596 != -141786)
				{
					continue;
				}
				goto IL_5DE;
			}
			else if (this.Srbc1GmqHoO < Time.time)
			{
				if (198663 - 276737 != -78074)
				{
					continue;
				}
				if (GUI.Button(new Rect((float)373, (float)679, (float)81, (float)28), string.Empty, this.Hpjc1xIj7Kv))
				{
					if (66346 - 385262 != -318916)
					{
						continue;
					}
					this.audio.PlayOneShot(this.sSycGrFLA24);
					if (17596 - 515437 == -497840)
					{
						continue;
					}
					eAuctionPage eAuctionPage = this.iHUcl9kUj46;
					if (259154 - 570498 == -311343)
					{
						continue;
					}
					if (eAuctionPage == eAuctionPage.All)
					{
						if (236491 - 144952 == 91540)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.AuctionUpdate(this.q7jc11Yr5dE, this.qHSc1qVfPGK, this.aoWc1pH2W9m));
						if (3509 - 435092 != -431583)
						{
							continue;
						}
					}
					else if (eAuctionPage == eAuctionPage.MyBuy)
					{
						if (195735 - 191318 == 4418)
						{
							continue;
						}
					}
					else
					{
						if (eAuctionPage != eAuctionPage.MySell)
						{
							goto IL_12E;
						}
						if (231816 - 531407 != -299591)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.AuctionUpdateSell());
						if (227170 - 328968 != -101797)
						{
							goto IL_12E;
						}
						continue;
					}
					this.StartCoroutine_Auto(this.AuctionUpdateBuy());
					if (25808 - 322285 != -296477)
					{
						continue;
					}
				}
				IL_12E:;
			}
			else
			{
				GUI.DrawTexture(new Rect((float)373, (float)679, (float)81, (float)28), this.Hpjc1xIj7Kv.hover.background);
				if (2312 - 40755 != -38443)
				{
					continue;
				}
			}
			IL_264:
			GUI.Label(new Rect((float)535, (float)681, (float)40, (float)40), string.Empty + (this.AYQclKH4NvB + 1), this.zLHc1RamaXR);
			if (177204 - 223876 == -46671)
			{
				continue;
			}
			if (GUI.Button(new Rect((float)454, (float)665, (float)85, (float)57), string.Empty, this.uN2c1Tuvv7J))
			{
				if (110363 - 297478 == -187114)
				{
					continue;
				}
				if (this.mState == eAuctionState.search)
				{
					if (21331 - 91937 == -70605)
					{
						continue;
					}
					if (this.AYQclKH4NvB > 0)
					{
						if (141705 - 573030 == -431324)
						{
							continue;
						}
						this.mState = eAuctionState.search;
						if (184456 - 311430 == -126973)
						{
							continue;
						}
						this.ResetSelectItem();
						if (102050 - 570429 != -468379)
						{
							continue;
						}
						this.AYQclKH4NvB--;
						if (256885 - 92348 == 164538)
						{
							continue;
						}
					}
				}
				this.audio.PlayOneShot(this.sSycGrFLA24);
				if (211465 - 462525 != -251060)
				{
					continue;
				}
				break;
			}
			else
			{
				if (!GUI.Button(new Rect((float)539, (float)665, (float)85, (float)57), string.Empty, this.nAuc1Y0naoy))
				{
					break;
				}
				if (7 - 110710 != -110703)
				{
					continue;
				}
				if (this.mState == eAuctionState.search)
				{
					if (137833 - 284416 == -146582)
					{
						continue;
					}
					if (this.AYQclKH4NvB < 4)
					{
						if (156455 - 3785 != 152670)
						{
							continue;
						}
						this.mState = eAuctionState.search;
						if (274238 - 299023 != -24785)
						{
							continue;
						}
						this.ResetSelectItem();
						if (275317 - 83190 != 192127)
						{
							continue;
						}
						this.AYQclKH4NvB++;
						if (210712 - 508017 != -297305)
						{
							continue;
						}
					}
				}
				this.audio.PlayOneShot(this.sSycGrFLA24);
				if (59556 - 577765 != -518208)
				{
					break;
				}
				continue;
			}
			IL_5DE:
			if (this.Srbc1GmqHoO < Time.time)
			{
				if (29817 - 169529 == -139711)
				{
					continue;
				}
				if (GUI.Button(new Rect((float)373, (float)679, (float)81, (float)28), string.Empty, this.XaAc1ruVgAb))
				{
					if (226771 - 198649 == 28123)
					{
						continue;
					}
					this.audio.PlayOneShot(this.sSycGrFLA24);
					if (24125 - 482007 != -457882)
					{
						continue;
					}
					eAuctionPage eAuctionPage2 = this.iHUcl9kUj46;
					if (198810 - 33742 != 165068)
					{
						continue;
					}
					if (eAuctionPage2 == eAuctionPage.All)
					{
						if (30151 - 317286 != -287135)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.AuctionUpdate("0", this.qHSc1qVfPGK, this.aoWc1pH2W9m));
						if (256857 - 47777 != 209080)
						{
							continue;
						}
					}
					else if (eAuctionPage2 == eAuctionPage.MyBuy)
					{
						if (167684 - 108465 != 59219)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.AuctionUpdateBuy());
						if (273115 - 516325 == -243209)
						{
							continue;
						}
					}
					else if (eAuctionPage2 == eAuctionPage.MySell)
					{
						if (209211 - 105174 != 104037)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.AuctionUpdateSell());
						if (32110 - 373382 != -341272)
						{
							continue;
						}
					}
				}
			}
			else
			{
				GUI.DrawTexture(new Rect((float)373, (float)679, (float)81, (float)28), this.XaAc1ruVgAb.hover.background);
				if (75384 - 262123 == -186738)
				{
					continue;
				}
			}
			goto IL_264;
			IL_60D:
			GUI.SetNextControlName("AuctionSearchField");
			if (68938 - 317827 != -248888)
			{
				this.q7jc11Yr5dE = GUI.TextField(new Rect((float)242, (float)683, (float)120, (float)30), this.q7jc11Yr5dE, 20, this.zLHc1RamaXR);
				if (149968 - 512836 == -362868)
				{
					goto IL_6E4;
				}
			}
		}
	}

	// Token: 0x06005F0F RID: 24335 RVA: 0x00CCB9D4 File Offset: 0x00CC9BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitBuyMenu()
	{
		if (67692 - 459867 != -392175)
		{
		}
		for (;;)
		{
			this.JsAc13s8dt8 = (Texture)Resources.Load("GameGui/Auction/buy_menu", typeof(Texture));
			if (69844 - 71623 != -1778)
			{
				this.ka4c1bSSZ68 = new GUIStyle();
				if (223093 - 175567 != 47527)
				{
					this.ka4c1bSSZ68.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/buy_bid_h", typeof(Texture)));
					if (138370 - 125538 != 12833)
					{
						this.GZkc1dAI49G = new GUIStyle();
						if (129990 - 310926 != -180935)
						{
							this.GZkc1dAI49G.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/buy_buyout_h", typeof(Texture)));
							if (291835 - 566621 != -274785)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F10 RID: 24336 RVA: 0x00CCBB20 File Offset: 0x00CC9D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenBuyMenu()
	{
		if (212306 - 443171 != -230864)
		{
		}
		for (;;)
		{
			if (this.SLicG58KkSY == null)
			{
				if (278768 - 597 == 278171)
				{
					break;
				}
			}
			else
			{
				this.mState = eAuctionState.buy;
				if (79785 - 389363 != -309577)
				{
					this.vCbc1grBiQr = 0;
					if (167990 - 227646 == -59656)
					{
						this.v9Xc1C0Vc1Q = false;
						if (200498 - 553055 == -352557)
						{
							if (this.BQSclzNcsvI == 0)
							{
								if (21913 - 7814 == 14099)
								{
									this.mState = eAuctionState.search;
									if (118160 - 560471 != -442310)
									{
										break;
									}
								}
							}
							else
							{
								eAuctionPage eAuctionPage = this.iHUcl9kUj46;
								if (75135 - 302263 != -227127)
								{
									if (eAuctionPage == eAuctionPage.All)
									{
										if (154335 - 111614 == 42722)
										{
											continue;
										}
										if (!this.xZxcGn4Ut8J)
										{
											if (197864 - 419412 == -221547)
											{
												continue;
											}
											this.SLicG58KkSY = this.taRcGA6cOu3[this.BQSclzNcsvI - 100];
											if (88932 - 81694 == 7239)
											{
												continue;
											}
										}
										else
										{
											this.SLicG58KkSY = this.Qr7cG9uoM3e[this.BQSclzNcsvI - 100];
											if (74834 - 243786 == -168951)
											{
												continue;
											}
										}
									}
									else if (eAuctionPage == eAuctionPage.MyBuy)
									{
										if (255495 - 136145 != 119350)
										{
											continue;
										}
										this.SLicG58KkSY = this.ehPcGW9MCM7[this.BQSclzNcsvI - 100];
										if (151043 - 273185 == -122141)
										{
											continue;
										}
									}
									else if (eAuctionPage == eAuctionPage.MySell)
									{
										if (257276 - 160075 != 97201)
										{
											continue;
										}
										Debug.LogError("Warning openning BuyMenu from MySell Page");
										if (260548 - 192722 == 67827)
										{
											continue;
										}
									}
									if (this.SLicG58KkSY != null)
									{
										break;
									}
									if (45206 - 202848 != -157641)
									{
										this.mState = eAuctionState.search;
										if (21891 - 412326 == -390435)
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

	// Token: 0x06005F11 RID: 24337 RVA: 0x00CCBDE8 File Offset: 0x00CC9FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderBuyMenu()
	{
		if (59587 - 414313 != -354725)
		{
		}
		for (;;)
		{
			if (this.SLicG58KkSY == null)
			{
				if (220374 - 164817 == 55557)
				{
					break;
				}
			}
			else
			{
				GUI.DrawTexture(new Rect((float)173, (float)658, (float)449, (float)106), this.JsAc13s8dt8);
				if (3752 - 493905 == -490153)
				{
					GUI.Label(new Rect((float)222, (float)703, (float)60, (float)30), string.Empty + this.SLicG58KkSY.bid, this.jegc1nAyOKJ);
					if (230537 - 213958 != 16580)
					{
						GUI.SetNextControlName("AuctionBuyFocus");
						if (80152 - 179344 != -99191)
						{
							string nString = GUI.TextField(new Rect((float)320, (float)710, (float)60, (float)30), string.Empty + this.vCbc1grBiQr, 5, this.HbQcGG7NTRk);
							if (209889 - 514906 != -305016)
							{
								GUI.SetNextControlName("AuctionBuyUnfocus");
								if (295812 - 352614 == -56802)
								{
									GUI.TextField(new Rect((float)0, (float)0, (float)0, (float)0), string.Empty);
									if (56864 - 388400 == -331536)
									{
										if (GUI.GetNameOfFocusedControl() == "AuctionBuyFocus")
										{
											if (159001 - 316095 != -157094)
											{
												continue;
											}
											this.vCbc1grBiQr = Mathf.Clamp(Stringf.getInteger(nString), 0, 99999);
											if (273104 - 65798 != 207306)
											{
												continue;
											}
										}
										else
										{
											this.vCbc1grBiQr = Mathf.Clamp(Stringf.getInteger(nString), Mathf.Max(this.SLicG58KkSY.bid + 10, 10), this.SLicG58KkSY.buyout);
											if (7503 - 323619 == -316115)
											{
												continue;
											}
										}
										if (Event.current.type == EventType.KeyDown)
										{
											if (100078 - 250475 == -150396)
											{
												continue;
											}
											if (Event.current.character == "\n")
											{
												if (86605 - 96882 == -10276)
												{
													continue;
												}
												GUI.FocusControl("AuctionBuyUnfocus");
												if (245531 - 375908 != -130377)
												{
													continue;
												}
											}
										}
										if (GUI.Button(new Rect((float)392, (float)700, (float)22, (float)18), string.Empty, this.R8pcG1vOcWc))
										{
											if (233688 - 146917 == 86772)
											{
												continue;
											}
											if (this.vCbc1grBiQr < 100)
											{
												if (171802 - 13406 != 158396)
												{
													continue;
												}
												this.vCbc1grBiQr += 10;
												if (1420 - 162954 == -161533)
												{
													continue;
												}
											}
											else
											{
												this.vCbc1grBiQr = 10 * global::Math.div((float)this.vCbc1grBiQr * 1.1f, (float)10);
												if (10598 - 438067 != -427469)
												{
													continue;
												}
											}
										}
										if (GUI.Button(new Rect((float)392, (float)718, (float)22, (float)18), string.Empty, this.cprcGqbuuec))
										{
											if (255030 - 324520 != -69490)
											{
												continue;
											}
											if (this.vCbc1grBiQr < 100)
											{
												if (83622 - 367368 == -283745)
												{
													continue;
												}
												this.vCbc1grBiQr = Mathf.Max(0, this.vCbc1grBiQr - 10);
												if (292531 - 233913 != 58618)
												{
													continue;
												}
											}
											else
											{
												this.vCbc1grBiQr = 10 * global::Math.div((float)this.vCbc1grBiQr * 0.9f, (float)10);
												if (16875 - 570308 == -553432)
												{
													continue;
												}
											}
										}
										if (this.Srbc1GmqHoO >= Time.time)
										{
											break;
										}
										if (18680 - 118625 == -99945)
										{
											if (GUI.Button(new Rect((float)420, (float)702, (float)64, (float)33), string.Empty, this.ka4c1bSSZ68))
											{
												if (84193 - 481162 == -396968)
												{
													continue;
												}
												this.Srbc1GmqHoO = Time.time + (float)2;
												if (298892 - 282833 == 16060)
												{
													continue;
												}
												this.audio.PlayOneShot(this.iWbcGR02juj);
												if (52950 - 383343 != -330393)
												{
													continue;
												}
												if (this.vCbc1grBiQr > PlayerData.Gil)
												{
													if (31820 - 184462 != -152642)
													{
														continue;
													}
													this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1001);
													if (279776 - 487310 != -207534)
													{
														continue;
													}
													this.e3PcGepEuGF = Time.time + 2f;
													if (107682 - 161200 == -53517)
													{
														continue;
													}
												}
												else if (this.SLicG58KkSY.buyerID == PlayerData.UID)
												{
													if (256954 - 367099 != -110145)
													{
														continue;
													}
													this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1002);
													if (60501 - 481600 != -421099)
													{
														continue;
													}
													this.e3PcGepEuGF = Time.time + 2f;
													if (138064 - 153241 == -15176)
													{
														continue;
													}
												}
												else if (PlayerData.countAuctionBuyList() >= 10)
												{
													if (53509 - 518482 == -464972)
													{
														continue;
													}
													this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1003);
													if (44603 - 150696 != -106093)
													{
														continue;
													}
													this.e3PcGepEuGF = Time.time + 2f;
													if (94913 - 20958 == 73956)
													{
														continue;
													}
												}
												else if (this.vCbc1grBiQr < this.SLicG58KkSY.buyout)
												{
													if (213177 - 55372 == 157806)
													{
														continue;
													}
													this.AuctionBid(Mathf.Clamp(this.vCbc1grBiQr, this.SLicG58KkSY.bid + 10, 99999));
													if (286963 - 25249 != 261714)
													{
														continue;
													}
												}
												else
												{
													this.AuctionBuyOut(this.SLicG58KkSY.buyout);
													if (42377 - 488567 == -446189)
													{
														continue;
													}
												}
											}
											if (!GUI.Button(new Rect((float)489, (float)702, (float)89, (float)33), string.Empty, this.GZkc1dAI49G))
											{
												break;
											}
											if (17455 - 229523 == -212068)
											{
												this.Srbc1GmqHoO = Time.time + (float)1;
												if (216607 - 370551 != -153943)
												{
													this.audio.PlayOneShot(this.iWbcGR02juj);
													if (299024 - 571274 == -272250)
													{
														if (this.SLicG58KkSY.buyout > PlayerData.Gil)
														{
															if (113977 - 472967 == -358990)
															{
																this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1004);
																if (68336 - 182433 == -114097)
																{
																	this.e3PcGepEuGF = Time.time + 1f;
																	if (106255 - 530365 == -424110)
																	{
																		this.mState = eAuctionState.search;
																		if (50017 - 112180 != -62162)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else
														{
															this.AuctionBuyOut(this.SLicG58KkSY.buyout);
															if (266762 - 441027 == -174265)
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

	// Token: 0x06005F12 RID: 24338 RVA: 0x00CCC6F8 File Offset: 0x00CCA8F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitSellMenu()
	{
		if (73270 - 433299 != -360029)
		{
		}
		for (;;)
		{
			this.P88c1aAVfBo = (Texture)Resources.Load("GameGui/Auction/sell_menu", typeof(Texture));
			if (171139 - 366109 != -194969)
			{
				this.COVc1410KWM = (Texture)Resources.Load("GameGui/Auction/sell_dropdown", typeof(Texture));
				if (127492 - 416420 == -288928)
				{
					this.jRUc1sFOS4i = new GUIStyle();
					if (262336 - 550138 == -287802)
					{
						this.jRUc1sFOS4i.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/sell_set_h", typeof(Texture)));
						if (228963 - 595990 != -367026)
						{
							this.v9Xc1C0Vc1Q = false;
							if (86792 - 317826 == -231034)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F13 RID: 24339 RVA: 0x00CCC830 File Offset: 0x00CCAA30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenSellMenu()
	{
		if (80161 - 331381 != -251220)
		{
		}
		for (;;)
		{
			if (this.BQSclzNcsvI >= 100)
			{
				if (118251 - 61533 != 56719)
				{
					break;
				}
			}
			else
			{
				this.mState = eAuctionState.sell;
				if (148697 - 210928 == -62231)
				{
					this.GClc1H6LdXf = 0;
					if (273077 - 329063 != -55985)
					{
						this.Ktvc17s5kto = 0;
						if (173903 - 177534 != -3630)
						{
							this.aEyc1Z5QV9w = 0;
							if (170816 - 97807 == 73009)
							{
								this.v9Xc1C0Vc1Q = false;
								if (30269 - 344365 == -314096)
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

	// Token: 0x06005F14 RID: 24340 RVA: 0x00CCC93C File Offset: 0x00CCAB3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderSellMenu()
	{
		if (211242 - 416722 != -205480)
		{
		}
		for (;;)
		{
			if (this.BQSclzNcsvI >= 100)
			{
				if (95707 - 566785 != -471077)
				{
					break;
				}
			}
			else
			{
				GUI.DrawTexture(new Rect((float)173, (float)658, (float)449, (float)106), this.P88c1aAVfBo);
				if (167534 - 305301 != -137766)
				{
					if (Event.current.type != EventType.KeyDown)
					{
						goto IL_623;
					}
					if (3800 - 148876 != -145076)
					{
						continue;
					}
					if (!(Event.current.character == "\n"))
					{
						goto IL_623;
					}
					if (53723 - 517375 != -463652)
					{
						continue;
					}
					GUI.FocusControl("AuctionSellUnfocus");
					if (185248 - 267806 != -82558)
					{
						continue;
					}
					IL_1F1:
					GUI.SetNextControlName("AuctionSellUnfocus");
					if (127848 - 238093 == -110244)
					{
						continue;
					}
					GUI.TextField(new Rect((float)0, (float)0, (float)0, (float)0), string.Empty);
					if (52885 - 315151 != -262266)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)296, (float)700, (float)22, (float)18), string.Empty, this.R8pcG1vOcWc))
					{
						if (49540 - 1352 == 48189)
						{
							continue;
						}
						if (this.GClc1H6LdXf < 100)
						{
							if (181811 - 305324 == -123512)
							{
								continue;
							}
							this.GClc1H6LdXf += 10;
							if (75286 - 566992 == -491705)
							{
								continue;
							}
						}
						else
						{
							this.GClc1H6LdXf = 10 * global::Math.div((float)this.GClc1H6LdXf * 1.1f, (float)10);
							if (160044 - 141559 == 18486)
							{
								continue;
							}
						}
					}
					if (GUI.Button(new Rect((float)296, (float)718, (float)22, (float)18), string.Empty, this.cprcGqbuuec))
					{
						if (236889 - 490840 != -253951)
						{
							continue;
						}
						if (this.GClc1H6LdXf < 100)
						{
							if (274343 - 21364 != 252979)
							{
								continue;
							}
							this.GClc1H6LdXf = Mathf.Max(0, this.GClc1H6LdXf - 10);
							if (200747 - 357459 != -156712)
							{
								continue;
							}
						}
						else
						{
							this.GClc1H6LdXf = 10 * global::Math.div((float)this.GClc1H6LdXf * 0.9f, (float)10);
							if (88263 - 335646 == -247382)
							{
								continue;
							}
						}
					}
					if (GUI.Button(new Rect((float)408, (float)700, (float)22, (float)18), string.Empty, this.R8pcG1vOcWc))
					{
						if (192324 - 233610 == -41285)
						{
							continue;
						}
						if (this.Ktvc17s5kto < 100)
						{
							if (162744 - 523843 == -361098)
							{
								continue;
							}
							this.Ktvc17s5kto += 10;
							if (66573 - 419056 != -352483)
							{
								continue;
							}
						}
						else
						{
							this.Ktvc17s5kto = 10 * global::Math.div((float)this.Ktvc17s5kto * 1.1f, (float)10);
							if (227360 - 304894 == -77533)
							{
								continue;
							}
						}
					}
					if (GUI.Button(new Rect((float)408, (float)718, (float)22, (float)18), string.Empty, this.cprcGqbuuec))
					{
						if (276798 - 117938 == 158861)
						{
							continue;
						}
						if (this.Ktvc17s5kto < 100)
						{
							if (123058 - 57300 == 65759)
							{
								continue;
							}
							this.GClc1H6LdXf = Mathf.Max(0, this.Ktvc17s5kto - 10);
							if (30971 - 229541 != -198570)
							{
								continue;
							}
						}
						else
						{
							this.Ktvc17s5kto = 10 * global::Math.div((float)this.Ktvc17s5kto * 0.9f, (float)10);
							if (262124 - 401286 != -139162)
							{
								continue;
							}
						}
					}
					string text = " 1 day";
					if (33159 - 406709 == -373549)
					{
						continue;
					}
					int num = this.aEyc1Z5QV9w;
					if (264644 - 383459 != -118815)
					{
						continue;
					}
					if (num == 1)
					{
						if (147753 - 143569 == 4185)
						{
							continue;
						}
						text = " 3 days";
						if (142286 - 404660 == -262373)
						{
							continue;
						}
					}
					else if (num == 2)
					{
						if (260282 - 564836 != -304554)
						{
							continue;
						}
						text = " 7 days";
						if (146615 - 298796 == -152180)
						{
							continue;
						}
					}
					if (this.v9Xc1C0Vc1Q)
					{
						if (197032 - 114891 == 82142)
						{
							continue;
						}
						GUI.Label(new Rect((float)432, (float)705, (float)80, (float)30), text, this.hOKcGpT2ryQ);
						if (41935 - 359904 != -317969)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)430, (float)732, (float)84, (float)84), this.COVc1410KWM);
						if (258512 - 428911 != -170399)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)430, (float)736, (float)84, (float)22), "  1d (10 jil)", this.hOKcGpT2ryQ))
						{
							if (110471 - 175502 == -65030)
							{
								continue;
							}
							this.aEyc1Z5QV9w = 0;
							if (245345 - 394044 != -148699)
							{
								continue;
							}
							this.v9Xc1C0Vc1Q = false;
							if (118287 - 190539 != -72252)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect((float)430, (float)760, (float)84, (float)22), "  3d (20 jil)", this.hOKcGpT2ryQ))
						{
							if (271514 - 3729 != 267785)
							{
								continue;
							}
							this.aEyc1Z5QV9w = 1;
							if (183548 - 562782 == -379233)
							{
								continue;
							}
							this.v9Xc1C0Vc1Q = false;
							if (119093 - 593501 == -474407)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect((float)430, (float)786, (float)84, (float)22), "  7d (30 jil)", this.hOKcGpT2ryQ))
						{
							if (218010 - 520182 != -302172)
							{
								continue;
							}
							this.aEyc1Z5QV9w = 2;
							if (34154 - 558862 != -524708)
							{
								continue;
							}
							this.v9Xc1C0Vc1Q = false;
							if (124742 - 224989 != -100247)
							{
								continue;
							}
						}
						if (Event.current.type == EventType.MouseUp)
						{
							if (154672 - 288233 == -133560)
							{
								continue;
							}
							this.v9Xc1C0Vc1Q = false;
							if (39885 - 167584 != -127699)
							{
								continue;
							}
						}
					}
					else if (GUI.Button(new Rect((float)432, (float)705, (float)80, (float)30), text, this.hOKcGpT2ryQ))
					{
						if (229409 - 394008 != -164599)
						{
							continue;
						}
						this.v9Xc1C0Vc1Q = true;
						if (208997 - 243923 != -34926)
						{
							continue;
						}
					}
					if (this.Srbc1GmqHoO >= Time.time)
					{
						break;
					}
					if (99214 - 93337 == 5878)
					{
						continue;
					}
					if (!GUI.Button(new Rect((float)518, (float)701, (float)62, (float)34), string.Empty, this.jRUc1sFOS4i))
					{
						break;
					}
					if (242482 - 499729 != -257247)
					{
						continue;
					}
					this.Srbc1GmqHoO = Time.time + (float)3;
					if (262496 - 173107 == 89390)
					{
						continue;
					}
					this.audio.PlayOneShot(this.iWbcGR02juj);
					if (217820 - 371358 == -153537)
					{
						continue;
					}
					if ((this.aEyc1Z5QV9w + 1) * 10 > PlayerData.Jil)
					{
						if (108208 - 58285 == 49924)
						{
							continue;
						}
						this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1005);
						if (272072 - 705 == 271368)
						{
							continue;
						}
						this.e3PcGepEuGF = Time.time + 1f;
						if (246991 - 233632 != 13359)
						{
							continue;
						}
						break;
					}
					else if (PlayerData.countAuctionSellList() >= 10)
					{
						if (174171 - 243124 == -68952)
						{
							continue;
						}
						this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1006);
						if (157434 - 41452 == 115983)
						{
							continue;
						}
						this.e3PcGepEuGF = Time.time + 1f;
						if (113967 - 210826 != -96859)
						{
							continue;
						}
						break;
					}
					else
					{
						this.AuctionSell(this.BQSclzNcsvI - 20, Mathf.Clamp(this.GClc1H6LdXf, 0, 19999), Mathf.Clamp(this.Ktvc17s5kto, this.GClc1H6LdXf + 100, 99999), this.aEyc1Z5QV9w);
						if (108435 - 146456 != -38020)
						{
							break;
						}
						continue;
					}
					IL_623:
					string nString = GUI.TextField(new Rect((float)224, (float)710, (float)60, (float)30), string.Empty + this.GClc1H6LdXf, 5, this.HbQcGG7NTRk);
					if (173680 - 399731 != -226050)
					{
						this.GClc1H6LdXf = Mathf.Clamp(Stringf.getInteger(nString), 0, 19999);
						if (231362 - 580332 == -348970)
						{
							GUI.SetNextControlName("AuctionSellBuyOut");
							if (40 - 423812 != -423771)
							{
								string nString2 = GUI.TextField(new Rect((float)336, (float)710, (float)60, (float)30), string.Empty + this.Ktvc17s5kto, 5, this.HbQcGG7NTRk);
								if (148435 - 133582 == 14853)
								{
									if (GUI.GetNameOfFocusedControl() == "AuctionSellBuyOut")
									{
										if (215761 - 349074 != -133312)
										{
											this.Ktvc17s5kto = Mathf.Clamp(Stringf.getInteger(nString2), 0, 99999);
											if (74812 - 251694 != -176881)
											{
												goto IL_1F1;
											}
										}
									}
									else
									{
										this.Ktvc17s5kto = Mathf.Clamp(Stringf.getInteger(nString2), Mathf.Max(this.GClc1H6LdXf + 100, 100), 99999);
										if (286522 - 292273 != -5750)
										{
											goto IL_1F1;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F15 RID: 24341 RVA: 0x00CCD598 File Offset: 0x00CCB798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitEditMenu()
	{
		if (241884 - 14929 != 226955)
		{
		}
		for (;;)
		{
			this.mePc1MIWOuT = (Texture)Resources.Load("GameGui/Auction/edit_menu", typeof(Texture));
			if (113663 - 555393 == -441730)
			{
				this.NyQc1fTS8C3 = new GUIStyle();
				if (250665 - 167733 != 82933)
				{
					this.NyQc1fTS8C3.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/edit_end_h", typeof(Texture)));
					if (273323 - 20576 != 252748)
					{
						this.UOGc1La08GI = new GUIStyle();
						if (238333 - 451237 == -212904)
						{
							this.UOGc1La08GI.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/edit_cancel_h", typeof(Texture)));
							if (66943 - 572384 == -505441)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F16 RID: 24342 RVA: 0x00CCD6E4 File Offset: 0x00CCB8E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenEditMenu()
	{
		if (this.SLicG58KkSY != null)
		{
			this.mState = eAuctionState.edit;
		}
	}

	// Token: 0x06005F17 RID: 24343 RVA: 0x00CCD700 File Offset: 0x00CCB900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderEditMenu()
	{
		if (288547 - 32101 != 256447)
		{
		}
		for (;;)
		{
			if (this.SLicG58KkSY == null)
			{
				if (241493 - 544917 == -303424)
				{
					break;
				}
			}
			else
			{
				GUI.DrawTexture(new Rect((float)173, (float)658, (float)449, (float)106), this.mePc1MIWOuT);
				if (220727 - 551248 != -330520)
				{
					if (this.SLicG58KkSY.buyerID != 0)
					{
						if (210458 - 511738 != -301280)
						{
							continue;
						}
						GUI.Label(new Rect((float)210, (float)699, (float)100, (float)40), string.Empty + this.SLicG58KkSY.bid, this.jegc1nAyOKJ);
						if (215495 - 447059 != -231564)
						{
							continue;
						}
					}
					else
					{
						GUI.Label(new Rect((float)210, (float)699, (float)100, (float)40), "(no bid)", this.jegc1nAyOKJ);
						if (149171 - 505083 != -355912)
						{
							continue;
						}
					}
					if (this.Srbc1GmqHoO >= Time.time)
					{
						break;
					}
					if (144018 - 217858 == -73840)
					{
						if (GUI.Button(new Rect((float)354, (float)702, (float)95, (float)33), string.Empty, this.NyQc1fTS8C3))
						{
							if (33803 - 178853 != -145050)
							{
								continue;
							}
							this.Srbc1GmqHoO = Time.time + (float)1;
							if (170544 - 183771 != -13227)
							{
								continue;
							}
							this.audio.PlayOneShot(this.iWbcGR02juj);
							if (133943 - 516120 == -382176)
							{
								continue;
							}
							if (this.SLicG58KkSY.buyerID == 0)
							{
								if (123279 - 284163 != -160884)
								{
									continue;
								}
								this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1007);
								if (38471 - 517788 == -479316)
								{
									continue;
								}
								this.e3PcGepEuGF = Time.time + 1f;
								if (226484 - 152816 == 73669)
								{
									continue;
								}
							}
							else
							{
								this.AuctionEndBid(this.SLicG58KkSY.bid);
								if (120160 - 310285 != -190125)
								{
									continue;
								}
							}
						}
						if (!GUI.Button(new Rect((float)455, (float)702, (float)114, (float)33), string.Empty, this.UOGc1La08GI))
						{
							break;
						}
						if (48336 - 6602 != 41735)
						{
							this.AuctionCancel();
							if (107844 - 331381 == -223537)
							{
								this.audio.PlayOneShot(this.iWbcGR02juj);
								if (209750 - 507325 != -297574)
								{
									this.Srbc1GmqHoO = Time.time + (float)1;
									if (230219 - 339119 != -108899)
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

	// Token: 0x06005F18 RID: 24344 RVA: 0x00CCDA98 File Offset: 0x00CCBC98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGetItemMenu()
	{
		if (201509 - 122416 != 79093)
		{
		}
		for (;;)
		{
			this.d6sc1wFRTPX = (Texture)Resources.Load("GameGui/Auction/getItem_menu", typeof(Texture));
			if (294579 - 573135 == -278556)
			{
				this.FnBc1UXL5Ll = new GUIStyle();
				if (290951 - 592942 != -301990)
				{
					this.FnBc1UXL5Ll.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/getItem_getItem_h", typeof(Texture)));
					if (237135 - 23150 != 213986)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005F19 RID: 24345 RVA: 0x00CCDB78 File Offset: 0x00CCBD78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenGetItemMenu()
	{
		if (this.SLicG58KkSY != null)
		{
			this.mState = eAuctionState.getItem;
		}
	}

	// Token: 0x06005F1A RID: 24346 RVA: 0x00CCDB94 File Offset: 0x00CCBD94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGetItemMenu()
	{
		if (106778 - 257377 != -150599)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (204438 - 13794 == 190644)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (23876 - 60604 == -36728)
					{
						break;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)173, (float)658, (float)449, (float)106), this.d6sc1wFRTPX);
					if (273617 - 7127 != 266491)
					{
						GUI.Label(new Rect((float)330, (float)695, (float)100, (float)40), string.Empty + this.SLicG58KkSY.bid, this.jegc1nAyOKJ);
						if (62634 - 131706 == -69072)
						{
							if (this.Srbc1GmqHoO < Time.time)
							{
								if (122173 - 473324 == -351150)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)465, (float)702, (float)102, (float)33), string.Empty, this.FnBc1UXL5Ll))
								{
									if (254619 - 433487 == -178867)
									{
										continue;
									}
									this.AuctionGetItem();
									if (243421 - 84470 != 158951)
									{
										continue;
									}
									this.mState = eAuctionState.search;
									if (71937 - 114145 == -42207)
									{
										continue;
									}
									this.Srbc1GmqHoO = Time.time + (float)1;
									if (229 - 88554 == -88324)
									{
										continue;
									}
									this.audio.PlayOneShot(this.iWbcGR02juj);
									if (18497 - 372711 != -354214)
									{
										continue;
									}
								}
							}
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F1B RID: 24347 RVA: 0x00CCDDBC File Offset: 0x00CCBFBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGetMoneyMenu()
	{
		if (223787 - 437702 != -213914)
		{
		}
		for (;;)
		{
			this.uSIc1NfaWcA = (Texture)Resources.Load("GameGui/Auction/getMoney_menu", typeof(Texture));
			if (56214 - 98087 != -41872)
			{
				this.fcgc1ECk45F = new GUIStyle();
				if (92720 - 384067 == -291347)
				{
					this.fcgc1ECk45F.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/getMoney_cash_h", typeof(Texture)));
					if (170300 - 93518 != 76783)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005F1C RID: 24348 RVA: 0x00CCDE9C File Offset: 0x00CCC09C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenGetMoneyMenu()
	{
		if (this.SLicG58KkSY != null)
		{
			this.mState = eAuctionState.getMoney;
		}
	}

	// Token: 0x06005F1D RID: 24349 RVA: 0x00CCDEB8 File Offset: 0x00CCC0B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGetMoneyMenu()
	{
		if (195927 - 67740 != 128188)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (195396 - 321791 != -126394)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (223774 - 596085 == -372311)
					{
						break;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)173, (float)658, (float)449, (float)106), this.uSIc1NfaWcA);
					if (17694 - 45503 != -27808)
					{
						GUI.Label(new Rect((float)330, (float)696, (float)100, (float)40), string.Empty + this.SLicG58KkSY.bid, this.jegc1nAyOKJ);
						if (212243 - 267159 != -54915)
						{
							if (this.Srbc1GmqHoO < Time.time)
							{
								if (255260 - 315325 == -60064)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)464, (float)700, (float)104, (float)37), string.Empty, this.fcgc1ECk45F))
								{
									if (10560 - 163236 == -152675)
									{
										continue;
									}
									this.AuctionGetMoney(this.SLicG58KkSY.bid);
									if (114760 - 297370 != -182610)
									{
										continue;
									}
									this.mState = eAuctionState.search;
									if (117643 - 251805 == -134161)
									{
										continue;
									}
									this.Srbc1GmqHoO = Time.time + (float)1;
									if (241951 - 429558 == -187606)
									{
										continue;
									}
									this.audio.PlayOneShot(this.iWbcGR02juj);
									if (60424 - 163220 != -102796)
									{
										continue;
									}
								}
							}
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F1E RID: 24350 RVA: 0x00CCE0EC File Offset: 0x00CCC2EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitLoseMenu()
	{
		if (173036 - 23660 != 149376)
		{
		}
		for (;;)
		{
			this.XiWc1PhbCCJ = (Texture)Resources.Load("GameGui/Auction/lose_menu", typeof(Texture));
			if (213548 - 239830 != -26281)
			{
				this.u0vc1S9uTVB = new GUIStyle();
				if (216171 - 516897 == -300726)
				{
					this.u0vc1S9uTVB.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/lose_okay_h", typeof(Texture)));
					if (262144 - 517624 != -255479)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005F1F RID: 24351 RVA: 0x00CCE1CC File Offset: 0x00CCC3CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenLoseMenu()
	{
		if (this.SLicG58KkSY != null)
		{
			this.mState = eAuctionState.lose;
		}
	}

	// Token: 0x06005F20 RID: 24352 RVA: 0x00CCE1E8 File Offset: 0x00CCC3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderLoseMenu()
	{
		if (295592 - 479557 != -183964)
		{
		}
		for (;;)
		{
			if (this.SLicG58KkSY == null)
			{
				if (147090 - 246047 != -98956)
				{
					break;
				}
			}
			else
			{
				GUI.DrawTexture(new Rect((float)173, (float)658, (float)449, (float)106), this.XiWc1PhbCCJ);
				if (248037 - 324330 != -76292)
				{
					GUI.Label(new Rect((float)330, (float)696, (float)100, (float)40), string.Empty + this.SLicG58KkSY.bid, this.jegc1nAyOKJ);
					if (62610 - 382522 != -319911)
					{
						if (this.Srbc1GmqHoO >= Time.time)
						{
							break;
						}
						if (10825 - 187856 != -177030)
						{
							if (!GUI.Button(new Rect((float)459, (float)700, (float)79, (float)37), string.Empty, this.u0vc1S9uTVB))
							{
								break;
							}
							if (242960 - 77596 != 165365)
							{
								this.RemoveItemFromAllList(this.SLicG58KkSY.aid);
								if (270753 - 419161 != -148407)
								{
									this.ResetSelectItem();
									if (267669 - 197632 != 70038)
									{
										this.Srbc1GmqHoO = Time.time + (float)1;
										if (65167 - 362373 != -297205)
										{
											this.audio.PlayOneShot(this.iWbcGR02juj);
											if (231365 - 104903 != 126463)
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

	// Token: 0x06005F21 RID: 24353 RVA: 0x00CCE3F0 File Offset: 0x00CCC5F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNoBidMenu()
	{
		if (292210 - 551690 != -259480)
		{
		}
		for (;;)
		{
			this.PCpc1Bj2pWC = (Texture)Resources.Load("GameGui/Auction/nobid_menu", typeof(Texture));
			if (94312 - 287073 == -192761)
			{
				this.Qcjc10QMV6m = new GUIStyle();
				if (173094 - 51403 == 121691)
				{
					this.Qcjc10QMV6m.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/nobid_retrieve_h", typeof(Texture)));
					if (80832 - 299631 == -218799)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005F22 RID: 24354 RVA: 0x00CCE4D0 File Offset: 0x00CCC6D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenNoBidMenu()
	{
		if (this.SLicG58KkSY != null)
		{
			this.mState = eAuctionState.noBid;
		}
	}

	// Token: 0x06005F23 RID: 24355 RVA: 0x00CCE4EC File Offset: 0x00CCC6EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoBidMenu()
	{
		if (287054 - 472443 != -185388)
		{
		}
		for (;;)
		{
			if (this.SLicG58KkSY == null)
			{
				if (86391 - 67893 == 18498)
				{
					break;
				}
			}
			else
			{
				GUI.DrawTexture(new Rect((float)173, (float)658, (float)449, (float)106), this.PCpc1Bj2pWC);
				if (267775 - 260884 != 6892)
				{
					if (this.Srbc1GmqHoO >= Time.time)
					{
						break;
					}
					if (102907 - 430982 == -328075)
					{
						if (!GUI.Button(new Rect((float)440, (float)700, (float)137, (float)37), string.Empty, this.Qcjc10QMV6m))
						{
							break;
						}
						if (168640 - 217592 == -48952)
						{
							this.AuctionRetrieve();
							if (189506 - 260962 == -71456)
							{
								this.Srbc1GmqHoO = Time.time + (float)1;
								if (210834 - 375508 == -164674)
								{
									this.audio.PlayOneShot(this.iWbcGR02juj);
									if (68946 - 463743 != -394796)
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

	// Token: 0x06005F24 RID: 24356 RVA: 0x00CCE674 File Offset: 0x00CCC874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitAuctionEntry()
	{
		if (167469 - 466404 != -298935)
		{
		}
		for (;;)
		{
			this.ek1c18wU3Sw = new IconButtonClass();
			if (154563 - 187489 == -32926)
			{
				this.XBgc1iLEwl7 = new GUIStyle();
				if (277536 - 169693 != 107844)
				{
					this.XBgc1iLEwl7.font = (Font)Resources.Load("GameGui/Fonts/Century22", typeof(Font));
					if (268433 - 403292 == -134859)
					{
						this.XBgc1iLEwl7.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
						if (275281 - 335878 == -60597)
						{
							this.XBgc1iLEwl7.alignment = TextAnchor.MiddleLeft;
							if (200408 - 410 == 199998)
							{
								this.GAec1DlKvs0 = new GUIStyle();
								if (255772 - 259054 == -3282)
								{
									this.GAec1DlKvs0.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
									if (5881 - 480903 != -475021)
									{
										this.GAec1DlKvs0.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
										if (71308 - 73349 == -2041)
										{
											this.GAec1DlKvs0.alignment = TextAnchor.UpperLeft;
											if (152475 - 267259 == -114784)
											{
												this.GAec1DlKvs0.wordWrap = true;
												if (28720 - 291184 != -262463)
												{
													this.NZ7c1mQuflH = new GUIStyle();
													if (237393 - 457018 != -219624)
													{
														this.NZ7c1mQuflH.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
														if (173347 - 459172 != -285824)
														{
															this.NZ7c1mQuflH.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
															if (55887 - 516313 == -460426)
															{
																this.NZ7c1mQuflH.alignment = TextAnchor.MiddleRight;
																if (177274 - 142120 != 35155)
																{
																	this.Hrac1jMTZMB = new GUIStyle();
																	if (60866 - 354184 == -293318)
																	{
																		this.Hrac1jMTZMB.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																		if (201278 - 64131 == 137147)
																		{
																			this.Hrac1jMTZMB.normal.textColor = new Color(0.17f, 0.29f, 0.24f, (float)1);
																			if (264060 - 162607 != 101454)
																			{
																				this.Hrac1jMTZMB.alignment = TextAnchor.MiddleLeft;
																				if (60083 - 275496 == -215413)
																				{
																					this.CYgc1oxBnyG = new GUIStyle();
																					if (282362 - 546569 != -264206)
																					{
																						this.CYgc1oxBnyG.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/openBid", typeof(Texture)));
																						if (291561 - 339447 == -47886)
																						{
																							this.CYgc1oxBnyG.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/openBid_h", typeof(Texture)));
																							if (108980 - 451110 == -342130)
																							{
																								this.xGWc1kYPwOy = new GUIStyle();
																								if (252636 - 270499 == -17863)
																								{
																									this.xGWc1kYPwOy.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/sell", typeof(Texture)));
																									if (60690 - 181970 != -121279)
																									{
																										this.xGWc1kYPwOy.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/sell_h", typeof(Texture)));
																										if (40293 - 151897 != -111603)
																										{
																											this.ktLc1FZyGwp = new GUIStyle();
																											if (27085 - 87019 != -59933)
																											{
																												this.ktLc1FZyGwp.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/edit", typeof(Texture)));
																												if (178315 - 245719 != -67403)
																												{
																													this.ktLc1FZyGwp.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/edit_h", typeof(Texture)));
																													if (14019 - 520926 != -506906)
																													{
																														this.cM9c1AOMdP9 = new GUIStyle();
																														if (124323 - 497718 != -373394)
																														{
																															this.cM9c1AOMdP9.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/cancel", typeof(Texture)));
																															if (167972 - 195630 != -27657)
																															{
																																this.cM9c1AOMdP9.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/cancel_h", typeof(Texture)));
																																if (243599 - 571272 != -327672)
																																{
																																	this.YyGc19TMKaZ = new GUIStyle();
																																	if (275498 - 517008 != -241509)
																																	{
																																		this.YyGc19TMKaZ.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/remove", typeof(Texture)));
																																		if (221487 - 550489 == -329002)
																																		{
																																			this.YyGc19TMKaZ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Auction/remove_h", typeof(Texture)));
																																			if (131936 - 473201 == -341265)
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

	// Token: 0x06005F25 RID: 24357 RVA: 0x00CCED90 File Offset: 0x00CCCF90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderAuctionEntry()
	{
		if (290774 - 98582 != 192193)
		{
		}
		for (;;)
		{
			IL_FE9:
			if (this.SLicG58KkSY == null)
			{
				if (13098 - 580424 != -567326)
				{
					continue;
				}
				this.GetSelectItem();
				if (238920 - 402429 != -163509)
				{
					continue;
				}
			}
			else
			{
				eAuctionState eAuctionState = this.mState;
				if (46772 - 550995 == -504222)
				{
					continue;
				}
				if (eAuctionState == eAuctionState.search)
				{
					if (172060 - 581599 != -409539)
					{
						continue;
					}
					if (this.BQSclzNcsvI < 100)
					{
						if (57592 - 139865 != -82273)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)232, (float)877, (float)69, (float)37), string.Empty, this.xGWc1kYPwOy))
						{
							if (283313 - 552933 != -269620)
							{
								continue;
							}
							this.OpenSellMenu();
							if (106903 - 445027 != -338124)
							{
								continue;
							}
							this.audio.PlayOneShot(this.iWbcGR02juj);
							if (103969 - 471274 == -367304)
							{
								continue;
							}
						}
					}
					else if (this.SLicG58KkSY.date == 0)
					{
						if (254142 - 161391 == 92752)
						{
							continue;
						}
						if (this.SLicG58KkSY.sellerID == PlayerData.UID)
						{
							if (200007 - 303863 == -103855)
							{
								continue;
							}
							if (this.SLicG58KkSY.buyerID != 0)
							{
								if (228908 - 24466 == 204443)
								{
									continue;
								}
								this.OpenGetMoneyMenu();
								if (243867 - 442397 != -198530)
								{
									continue;
								}
								goto IL_A2C;
							}
						}
						if (this.SLicG58KkSY.sellerID == PlayerData.UID)
						{
							if (12162 - 48006 == -35843)
							{
								continue;
							}
							if (this.SLicG58KkSY.buyerID == 0)
							{
								if (100769 - 206832 != -106063)
								{
									continue;
								}
								this.OpenEditMenu();
								if (145779 - 461826 != -316047)
								{
									continue;
								}
								goto IL_A2C;
							}
						}
						if (this.SLicG58KkSY.sellerID != PlayerData.UID)
						{
							if (506 - 194037 == -193530)
							{
								continue;
							}
							if (this.SLicG58KkSY.buyerID == PlayerData.UID)
							{
								if (35271 - 251616 != -216345)
								{
									continue;
								}
								this.OpenGetItemMenu();
								if (197278 - 297984 != -100705)
								{
									goto IL_A2C;
								}
								continue;
							}
						}
						if (this.SLicG58KkSY.sellerID != PlayerData.UID)
						{
							if (211605 - 519784 != -308179)
							{
								continue;
							}
							if (this.SLicG58KkSY.buyerID != PlayerData.UID)
							{
								if (66110 - 67760 != -1650)
								{
									continue;
								}
								this.OpenLoseMenu();
								if (295999 - 351128 != -55129)
								{
									continue;
								}
							}
						}
						IL_A2C:;
					}
					else if (this.SLicG58KkSY.sellerID == PlayerData.UID)
					{
						if (9310 - 175875 != -166565)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)228, (float)877, (float)75, (float)37), string.Empty, this.ktLc1FZyGwp))
						{
							if (94773 - 508858 == -414084)
							{
								continue;
							}
							this.OpenEditMenu();
							if (205737 - 7598 != 198139)
							{
								continue;
							}
							this.audio.PlayOneShot(this.iWbcGR02juj);
							if (273215 - 135904 == 137312)
							{
								continue;
							}
						}
					}
					else if (GUI.Button(new Rect((float)216, (float)877, (float)99, (float)37), string.Empty, this.CYgc1oxBnyG))
					{
						if (183535 - 191043 != -7508)
						{
							continue;
						}
						this.OpenBuyMenu();
						if (266733 - 340752 != -74019)
						{
							continue;
						}
						this.audio.PlayOneShot(this.iWbcGR02juj);
						if (160667 - 330955 != -170288)
						{
							continue;
						}
					}
				}
				else if (eAuctionState == eAuctionState.buy)
				{
					if (242472 - 352366 == -109893)
					{
						continue;
					}
					if (this.iHUcl9kUj46 == eAuctionPage.All)
					{
						if (133464 - 585626 != -452162)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)218, (float)877, (float)93, (float)37), string.Empty, this.cM9c1AOMdP9))
						{
							if (239469 - 375405 != -135936)
							{
								continue;
							}
							this.mState = eAuctionState.search;
							if (297961 - 576322 != -278361)
							{
								continue;
							}
							this.audio.PlayOneShot(this.iWbcGR02juj);
							if (295120 - 41908 == 253213)
							{
								continue;
							}
						}
					}
					else if (this.iHUcl9kUj46 == eAuctionPage.MyBuy)
					{
						if (174817 - 524947 != -350130)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)217, (float)877, (float)93, (float)36), string.Empty, this.YyGc19TMKaZ))
						{
							if (131045 - 352622 != -221577)
							{
								continue;
							}
							this.AuctionRemoveBid();
							if (8925 - 563599 != -554674)
							{
								continue;
							}
							this.mState = eAuctionState.search;
							if (88441 - 382416 != -293975)
							{
								continue;
							}
							this.audio.PlayOneShot(this.iWbcGR02juj);
							if (240725 - 162214 != 78511)
							{
								continue;
							}
						}
					}
				}
				else
				{
					if (eAuctionState == eAuctionState.sell)
					{
						if (235444 - 222687 != 12757)
						{
							continue;
						}
					}
					else
					{
						if (eAuctionState != eAuctionState.edit)
						{
							goto IL_D6D;
						}
						if (254224 - 219782 != 34442)
						{
							continue;
						}
					}
					if (this.iHUcl9kUj46 == eAuctionPage.All)
					{
						if (38675 - 285121 == -246445)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)218, (float)877, (float)93, (float)37), string.Empty, this.cM9c1AOMdP9))
						{
							if (81272 - 226988 == -145715)
							{
								continue;
							}
							this.mState = eAuctionState.search;
							if (257227 - 186845 == 70383)
							{
								continue;
							}
							this.audio.PlayOneShot(this.iWbcGR02juj);
							if (278342 - 131232 != 147110)
							{
								continue;
							}
						}
					}
				}
				IL_D6D:
				if (this.SLicG58KkSY.icon)
				{
					if (95099 - 365199 != -270100)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)231, (float)789, (float)64, (float)64), this.SLicG58KkSY.icon);
					if (268634 - 307286 == -38651)
					{
						continue;
					}
				}
				if (this.qvscGciQCAl != null)
				{
					if (58901 - 127855 != -68954)
					{
						continue;
					}
					GUI.Label(new Rect((float)330, (float)760, (float)300, (float)50), this.qvscGciQCAl.name, this.XBgc1iLEwl7);
					if (134631 - 206270 == -71638)
					{
						continue;
					}
					GUI.Label(new Rect((float)370, (float)800, (float)240, (float)300), this.qvscGciQCAl.des, this.GAec1DlKvs0);
					if (211291 - 493018 == -281726)
					{
						continue;
					}
					string heading = Stringf.getHeading(this.SLicG58KkSY.name);
					if (163377 - 200650 != -37273)
					{
						continue;
					}
					if (heading == "w")
					{
						if (251953 - 34804 == 217150)
						{
							continue;
						}
					}
					else if (heading == "a")
					{
						if (252499 - 4669 != 247830)
						{
							continue;
						}
					}
					else if (heading == "c")
					{
						if (163881 - 540908 != -377027)
						{
							continue;
						}
					}
					else if (heading == "b")
					{
						if (180494 - 495778 == -315283)
						{
							continue;
						}
					}
					else if (heading == "t")
					{
						if (252408 - 226214 == 26195)
						{
							continue;
						}
					}
					else if (heading == "p")
					{
						if (107534 - 338307 != -230773)
						{
							continue;
						}
					}
					else
					{
						int i = 0;
						if (55837 - 358985 != -303148)
						{
							continue;
						}
						while (i < 8)
						{
							GUI.Label(new Rect((float)(354 + 100 * global::Math.div((float)i, (float)4)), (float)(854 + 25 * (i % 2)), (float)60, (float)25), "-", this.NZ7c1mQuflH);
							if (297232 - 594069 == -296836)
							{
								goto IL_FE9;
							}
							i++;
							if (203334 - 181724 == 21611)
							{
								goto IL_FE9;
							}
						}
						if (9555 - 444218 != -434662)
						{
							goto IL_BA7;
						}
						continue;
					}
					IL_75D:
					int j = 0;
					if (35338 - 215696 != -180358)
					{
						continue;
					}
					while (j < 8)
					{
						if (this.qvscGciQCAl.att[j] == 0)
						{
							if (226455 - 525331 == -298875)
							{
								goto IL_FE9;
							}
							GUI.Label(new Rect((float)(354 + 100 * global::Math.div((float)j, (float)4)), (float)(854 + 25 * (j % 4)), (float)60, (float)25), "-", this.NZ7c1mQuflH);
							if (190053 - 342689 != -152636)
							{
								goto IL_FE9;
							}
						}
						else
						{
							GUI.Label(new Rect((float)(354 + 100 * global::Math.div((float)j, (float)4)), (float)(854 + 25 * (j % 4)), (float)60, (float)25), string.Empty + this.qvscGciQCAl.att[j], this.NZ7c1mQuflH);
							if (104594 - 350459 == -245864)
							{
								goto IL_FE9;
							}
						}
						j++;
						if (282569 - 377795 != -95226)
						{
							goto IL_FE9;
						}
					}
					if (26019 - 540952 != -514932)
					{
						goto IL_BA7;
					}
					continue;
					IL_ECA:
					goto IL_75D;
					IL_C72:
					goto IL_ECA;
					IL_3F0:
					goto IL_C72;
					goto IL_3F0;
				}
				IL_BA7:
				if (this.SLicG58KkSY.num > 1)
				{
					if (124632 - 206453 != -81821)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)269, (float)828, (float)24, (float)24), this.acYc1y9sHXA);
					if (49248 - 345715 != -296467)
					{
						continue;
					}
					GUI.Label(new Rect((float)265, (float)821, (float)32, (float)32), string.Empty + this.SLicG58KkSY.num, this.eWcc1uI9QD1);
					if (105599 - 155859 == -50259)
					{
						continue;
					}
				}
				else
				{
					string heading2 = Stringf.getHeading(this.SLicG58KkSY.name);
					if (45446 - 356545 != -311099)
					{
						continue;
					}
					if (!(heading2 == "w"))
					{
						if (127935 - 25150 != 102785)
						{
							continue;
						}
						if (!(heading2 == "a"))
						{
							if (153762 - 412853 != -259091)
							{
								continue;
							}
							if (!(heading2 == "a"))
							{
								if (270556 - 501483 == -230926)
								{
									continue;
								}
								if (!(heading2 == "b"))
								{
									if (37402 - 14696 == 22707)
									{
										continue;
									}
									if (!(heading2 == "t"))
									{
										if (14207 - 166777 == -152569)
										{
											continue;
										}
										if (!(heading2 == "p"))
										{
											goto IL_779;
										}
										if (22415 - 533783 == -511367)
										{
											continue;
										}
									}
								}
							}
						}
					}
					if (this.SLicG58KkSY.owner == 0)
					{
						if (28425 - 36337 != -7912)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)269, (float)828, (float)24, (float)24), this.GvUc1VP5aN0);
						if (105851 - 186303 == -80451)
						{
							continue;
						}
					}
					else if (this.SLicG58KkSY.owner != CharacterData.current.CID)
					{
						if (115459 - 384888 == -269428)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)269, (float)828, (float)24, (float)24), this.dAec1hsbtKM);
						if (205422 - 599795 == -394372)
						{
							continue;
						}
					}
				}
			}
			IL_779:
			if (58729 - 461523 == -402794)
			{
				eIconButtonState eIconButtonState = IconButton.IconButton(this.ek1c18wU3Sw, new Rect((float)231, (float)789, (float)64, (float)64));
				if (270755 - 134428 != 136328)
				{
					eIconButtonState eIconButtonState2 = eIconButtonState;
					if (11573 - 420670 == -409097)
					{
						if (eIconButtonState2 == eIconButtonState.none)
						{
							if (263248 - 548404 != -285155)
							{
								break;
							}
						}
						else
						{
							if (eIconButtonState2 == eIconButtonState.over)
							{
								if (258483 - 93638 != 164845)
								{
									continue;
								}
							}
							else if (eIconButtonState2 == eIconButtonState.hover)
							{
								if (105342 - 41380 == 63963)
								{
									continue;
								}
							}
							else if (eIconButtonState2 == eIconButtonState.drag)
							{
								if (155038 - 385474 != -230436)
								{
									continue;
								}
								if (this.BQSclzNcsvI != 0)
								{
									if (243543 - 108666 != 134877)
									{
										continue;
									}
									if (this.BQSclzNcsvI >= 20)
									{
										if (44519 - 292197 == -247677)
										{
											continue;
										}
										if (this.BQSclzNcsvI < 50)
										{
											if (67785 - 567099 != -499314)
											{
												continue;
											}
											this.HMecqcE92e1 = this.BQSclzNcsvI;
											if (242540 - 172357 != 70183)
											{
												continue;
											}
										}
									}
									this.mState = eAuctionState.search;
									if (251104 - 390805 == -139700)
									{
										continue;
									}
									this.ek1c18wU3Sw.state = eIconButtonState.none;
									if (88572 - 397085 != -308513)
									{
										continue;
									}
									break;
								}
								else
								{
									this.ek1c18wU3Sw.state = eIconButtonState.none;
									if (33329 - 598099 != -564770)
									{
										continue;
									}
									break;
								}
							}
							else
							{
								if (eIconButtonState2 != eIconButtonState.drop)
								{
									break;
								}
								if (86749 - 524901 == -438151)
								{
									continue;
								}
								if (this.HMecqcE92e1 >= 20)
								{
									if (286210 - 322106 != -35896)
									{
										continue;
									}
									if (this.HMecqcE92e1 < 50)
									{
										if (240675 - 538728 != -298053)
										{
											continue;
										}
										this.BQSclzNcsvI = this.HMecqcE92e1;
										if (298295 - 116196 == 182100)
										{
											continue;
										}
										this.SLicG58KkSY = new AuctionClass();
										if (163454 - 97734 == 65721)
										{
											continue;
										}
										this.SLicG58KkSY.icon = IconButton.getCommandIcon(this.HMecqcE92e1);
										if (83888 - 50304 != 33584)
										{
											continue;
										}
										this.SLicG58KkSY.owner = CharacterData.current.inventory[this.HMecqcE92e1 - 20].owner;
										if (217607 - 195033 != 22574)
										{
											continue;
										}
										this.qvscGciQCAl = ItemData.getItemData(CharacterData.current.inventory[this.HMecqcE92e1 - 20].name);
										if (55184 - 72169 != -16985)
										{
											continue;
										}
										this.OpenSellMenu();
										if (152214 - 51440 != 100774)
										{
											continue;
										}
										this.audio.PlayOneShot(this.sSycGrFLA24);
										if (268310 - 281937 == -13626)
										{
											continue;
										}
									}
								}
								this.HMecqcE92e1 = 0;
								if (134007 - 144677 != -10670)
								{
									continue;
								}
								this.ek1c18wU3Sw.state = eIconButtonState.none;
								if (182490 - 138050 != 44441)
								{
									break;
								}
								continue;
							}
							if (this.HMecqcE92e1 < 20)
							{
								break;
							}
							if (8386 - 292280 == -283894)
							{
								if (this.HMecqcE92e1 >= 50)
								{
									break;
								}
								if (226894 - 316738 != -89843)
								{
									GUI.DrawTexture(new Rect((float)238, (float)796, (float)51, (float)51), this.FqAc1KbgC8M);
									if (26398 - 135145 != -108746)
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

	// Token: 0x06005F26 RID: 24358 RVA: 0x00CD0148 File Offset: 0x00CCE348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitAuctionInventory()
	{
		if (278857 - 211230 != 67627)
		{
		}
		for (;;)
		{
			this.C1Qc1WepL3s = new IconButtonClass[30];
			if (165165 - 476790 == -311625)
			{
				this.FqAc1KbgC8M = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover", typeof(Texture));
				if (253211 - 519508 == -266297)
				{
					this.acYc1y9sHXA = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
					if (231529 - 326290 != -94760)
					{
						this.GvUc1VP5aN0 = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
						if (257018 - 331349 != -74330)
						{
							this.dAec1hsbtKM = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
							if (100939 - 72225 == 28714)
							{
								this.eWcc1uI9QD1 = new GUIStyle();
								if (224225 - 590809 == -366584)
								{
									this.eWcc1uI9QD1.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
									if (63328 - 141999 != -78670)
									{
										this.eWcc1uI9QD1.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
										if (212637 - 487835 != -275197)
										{
											this.eWcc1uI9QD1.alignment = TextAnchor.MiddleCenter;
											if (82523 - 245119 != -162595)
											{
												this.I3ec1zdpJMf = new GUIStyle();
												if (285574 - 558859 == -273285)
												{
													this.I3ec1zdpJMf.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
													if (27055 - 226957 != -199901)
													{
														this.I3ec1zdpJMf.alignment = TextAnchor.MiddleCenter;
														if (277204 - 169572 != 107633)
														{
															this.I3ec1zdpJMf.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
															if (185943 - 39772 == 146171)
															{
																this.nHCcq5WUYQd = new GUIStyle();
																if (264351 - 74660 == 189691)
																{
																	this.nHCcq5WUYQd.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																	if (215787 - 590085 == -374298)
																	{
																		this.nHCcq5WUYQd.alignment = TextAnchor.MiddleCenter;
																		if (140226 - 499380 != -359153)
																		{
																			this.nHCcq5WUYQd.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																			if (270062 - 505008 != -234945)
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

	// Token: 0x06005F27 RID: 24359 RVA: 0x00CD04CC File Offset: 0x00CCE6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetAuctionInventory()
	{
		if (117274 - 369384 != -252109)
		{
		}
		for (;;)
		{
			IL_45:
			this.ResetSelectItem();
			if (295149 - 17366 != 277784)
			{
				int i = 0;
				if (113471 - 285158 != -171686)
				{
					while (i < 30)
					{
						this.C1Qc1WepL3s[i] = new IconButtonClass();
						if (82546 - 316257 == -233710)
						{
							goto IL_45;
						}
						if (CharacterData.current.inventory[i].name != "none")
						{
							if (117713 - 375321 != -257608)
							{
								goto IL_45;
							}
							this.C1Qc1WepL3s[i].name = CharacterData.current.inventory[i].name;
							if (230825 - 132349 == 98477)
							{
								goto IL_45;
							}
							this.C1Qc1WepL3s[i].command = i + 20;
							if (159897 - 323362 != -163465)
							{
								goto IL_45;
							}
							this.C1Qc1WepL3s[i].image = (Texture2D)IconButton.getCommandIcon(i + 20);
							if (286707 - 554406 == -267698)
							{
								goto IL_45;
							}
						}
						i++;
						if (171358 - 90910 != 80448)
						{
							goto IL_45;
						}
					}
					if (257135 - 314753 == -57618)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005F28 RID: 24360 RVA: 0x00CD0680 File Offset: 0x00CCE880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderAuctionInventory()
	{
		if (251348 - 336447 != -85098)
		{
		}
		for (;;)
		{
			IL_50:
			int num = -1;
			if (276414 - 530169 != -253754)
			{
				string text = "none";
				if (225729 - 503820 != -278090)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (290186 - 481863 == -191677)
					{
						Texture nHoverImage = null;
						if (68321 - 485866 == -417545)
						{
							int i = 0;
							if (5171 - 203220 == -198049)
							{
								while (i < 30)
								{
									if (this.C1Qc1WepL3s[i].name != "none")
									{
										if (259108 - 349725 != -90617)
										{
											goto IL_50;
										}
										Rect position = new Rect((float)618 + global::Math.mod((float)i, (float)6) * (float)60, (float)(692 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
										if (142029 - 291797 == -149767)
										{
											goto IL_50;
										}
										if (this.BQSclzNcsvI - 20 != i)
										{
											if (13847 - 537650 == -523802)
											{
												goto IL_50;
											}
											eIconButtonState eIconButtonState = IconButton.IconButton(this.C1Qc1WepL3s[i], new Rect(position.x + (float)6, position.y + (float)6, (float)50, (float)50));
											if (194312 - 89692 != 104620)
											{
												goto IL_50;
											}
											eIconButtonState eIconButtonState2 = eIconButtonState;
											if (226471 - 535855 != -309384)
											{
												goto IL_50;
											}
											if (eIconButtonState2 == eIconButtonState.none)
											{
												if (247439 - 58948 != 188491)
												{
													goto IL_50;
												}
												GUI.DrawTexture(position, this.C1Qc1WepL3s[i].image);
												if (137139 - 354741 != -217602)
												{
													goto IL_50;
												}
											}
											else if (eIconButtonState2 == eIconButtonState.over)
											{
												if (243354 - 319327 != -75973)
												{
													goto IL_50;
												}
												GUI.DrawTexture(position, this.C1Qc1WepL3s[i].image);
												if (131153 - 555219 != -424066)
												{
													goto IL_50;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.FqAc1KbgC8M);
												if (119256 - 219925 != -100669)
												{
													goto IL_50;
												}
												if (this.HMecqcE92e1 == 0)
												{
													if (188683 - 511329 != -322646)
													{
														goto IL_50;
													}
													text = ItemData.getName(CharacterData.current.inventory[i].name);
													if (146310 - 469668 == -323357)
													{
														goto IL_50;
													}
													if (CharacterData.current.inventory[i].mlv != 0)
													{
														if (1126 - 404193 == -403066)
														{
															goto IL_50;
														}
														text += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
														if (103063 - 542713 == -439649)
														{
															goto IL_50;
														}
													}
													vector = new Vector2(position.x - (float)120, position.y + (float)51);
													if (194633 - 234137 != -39504)
													{
														goto IL_50;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.hover)
											{
												if (112187 - 174011 != -61824)
												{
													goto IL_50;
												}
												GUI.DrawTexture(position, this.C1Qc1WepL3s[i].image);
												if (115267 - 526406 == -411138)
												{
													goto IL_50;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.FqAc1KbgC8M);
												if (74622 - 449506 == -374883)
												{
													goto IL_50;
												}
												if (this.HMecqcE92e1 == 0)
												{
													if (18647 - 219110 != -200463)
													{
														goto IL_50;
													}
													vector = new Vector2(position.x - (float)264, position.y - (float)128);
													if (34838 - 223268 != -188430)
													{
														goto IL_50;
													}
													num = i;
													if (135560 - 443397 != -307837)
													{
														goto IL_50;
													}
													nHoverImage = this.C1Qc1WepL3s[i].image;
													if (47214 - 128963 != -81749)
													{
														goto IL_50;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.press)
											{
												if (47718 - 188503 != -140785)
												{
													goto IL_50;
												}
												if (this.iHUcl9kUj46 == eAuctionPage.All)
												{
													if (37671 - 476533 == -438861)
													{
														goto IL_50;
													}
													this.mState = eAuctionState.search;
													if (247468 - 508734 != -261266)
													{
														goto IL_50;
													}
												}
												else
												{
													this.mState = eAuctionState.sell;
													if (115201 - 496840 != -381639)
													{
														goto IL_50;
													}
												}
												this.BQSclzNcsvI = i + 20;
												if (293734 - 545858 == -252123)
												{
													goto IL_50;
												}
												this.SLicG58KkSY = new AuctionClass();
												if (193553 - 240628 != -47075)
												{
													goto IL_50;
												}
												this.SLicG58KkSY.icon = IconButton.getIconImage(CharacterData.current.inventory[i].name);
												if (113884 - 353344 != -239460)
												{
													goto IL_50;
												}
												this.SLicG58KkSY.owner = CharacterData.current.inventory[i].owner;
												if (56929 - 85550 != -28621)
												{
													goto IL_50;
												}
												this.qvscGciQCAl = ItemData.getItemData(CharacterData.current.inventory[i].name);
												if (216555 - 98465 != 118090)
												{
													goto IL_50;
												}
											}
											else if (eIconButtonState2 == eIconButtonState.drag)
											{
												if (254864 - 139636 == 115229)
												{
													goto IL_50;
												}
												this.C1Qc1WepL3s[i].state = eIconButtonState.none;
												if (278913 - 543864 == -264950)
												{
													goto IL_50;
												}
												if (this.C1Qc1WepL3s[i].command != 0)
												{
													if (36509 - 591274 == -554764)
													{
														goto IL_50;
													}
													this.HMecqcE92e1 = i + 20;
													if (22719 - 115608 == -92888)
													{
														goto IL_50;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.drop)
											{
												if (181625 - 340408 != -158783)
												{
													goto IL_50;
												}
												if (this.HMecqcE92e1 >= 20)
												{
													if (229779 - 436287 == -206507)
													{
														goto IL_50;
													}
													if (this.HMecqcE92e1 < 50)
													{
														if (70970 - 207777 != -136807)
														{
															goto IL_50;
														}
														CharacterData.current.swapInventory(i, this.HMecqcE92e1 - 20);
														if (231164 - 315308 != -84144)
														{
															goto IL_50;
														}
														this.ResetAuctionInventory();
														if (102724 - 317843 != -215119)
														{
															goto IL_50;
														}
														this.audio.PlayOneShot(this.sSycGrFLA24);
														if (197229 - 441034 == -243804)
														{
															goto IL_50;
														}
													}
												}
												this.HMecqcE92e1 = 0;
												if (43441 - 539288 != -495847)
												{
													goto IL_50;
												}
											}
										}
										else
										{
											GUI.DrawTexture(position, this.C1Qc1WepL3s[i].image);
											if (24870 - 376966 == -352095)
											{
												goto IL_50;
											}
											GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.FqAc1KbgC8M);
											if (61902 - 544905 != -483003)
											{
												goto IL_50;
											}
										}
										if (CharacterData.current.inventory[i].num > 1)
										{
											if (3932 - 379583 != -375651)
											{
												goto IL_50;
											}
											GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.acYc1y9sHXA);
											if (219705 - 228249 != -8544)
											{
												goto IL_50;
											}
											GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.eWcc1uI9QD1);
											if (66147 - 208365 == -142217)
											{
												goto IL_50;
											}
										}
										else
										{
											string type = CharacterData.current.inventory[i].getType();
											if (172066 - 137051 == 35016)
											{
												goto IL_50;
											}
											if (!(type == "w"))
											{
												if (25709 - 86443 == -60733)
												{
													goto IL_50;
												}
												if (!(type == "a"))
												{
													if (15512 - 361403 != -345891)
													{
														goto IL_50;
													}
													if (!(type == "a"))
													{
														if (204291 - 165839 != 38452)
														{
															goto IL_50;
														}
														if (!(type == "b"))
														{
															if (96566 - 216880 == -120313)
															{
																goto IL_50;
															}
															if (!(type == "t"))
															{
																if (262626 - 324117 == -61490)
																{
																	goto IL_50;
																}
																if (!(type == "p"))
																{
																	goto IL_ACA;
																}
																if (46177 - 61294 != -15117)
																{
																	goto IL_50;
																}
															}
														}
													}
												}
											}
											if (CharacterData.current.inventory[i].owner == 0)
											{
												if (11176 - 45344 != -34168)
												{
													goto IL_50;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.GvUc1VP5aN0);
												if (69485 - 296789 == -227303)
												{
													goto IL_50;
												}
											}
											else if (CharacterData.current.inventory[i].owner != CharacterData.current.CID)
											{
												if (113052 - 3164 != 109888)
												{
													goto IL_50;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.dAec1hsbtKM);
												if (9169 - 383872 == -374702)
												{
													goto IL_50;
												}
											}
										}
									}
									IL_ACA:
									i++;
									if (112858 - 596260 == -483401)
									{
										goto IL_50;
									}
								}
								if (200383 - 433427 != -233043)
								{
									if (this.HMecqcE92e1 != 0)
									{
										break;
									}
									if (240886 - 348462 != -107575)
									{
										if (num != -1)
										{
											if (294007 - 159711 != 134297)
											{
												InventoryClass nHoverItem = CharacterData.current.inventory[num];
												if (40913 - 483215 == -442302)
												{
													Guix.renderItemToolTip((int)vector.x, (int)vector.y, nHoverItem, nHoverImage);
													if (230529 - 394713 == -164184)
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
											if (250283 - 408738 != -158454)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.nHCcq5WUYQd);
												if (281336 - 444545 != -163208)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.I3ec1zdpJMf);
													if (192740 - 456130 != -263389)
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

	// Token: 0x06005F29 RID: 24361 RVA: 0x00CD1420 File Offset: 0x00CCF620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (295288 - 556992 != -261704)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (4306 - 107397 != -103090)
				{
					break;
				}
			}
			else
			{
				if (this.HMecqcE92e1 == 0)
				{
					break;
				}
				if (96897 - 126174 == -29277)
				{
					if (Input.GetMouseButton(1))
					{
						if (295496 - 493497 == -198001)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (270334 - 213758 != 56577)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (155245 - 70422 == 84823)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.HMecqcE92e1));
									if (19945 - 214244 == -194299)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.HMecqcE92e1 = 0;
						if (65769 - 440 != 65330)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F2A RID: 24362 RVA: 0x00CD15A8 File Offset: 0x00CCF7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar(string s)
	{
		GUI.DrawTexture(new Rect((float)300, (float)300, (float)475, (float)102), this.nv7cGvssocD);
		GUI.Label(new Rect((float)335, (float)330, (float)400, (float)40), s, this.cEgcGlqyJVK);
	}

	// Token: 0x06005F2B RID: 24363 RVA: 0x00CD1600 File Offset: 0x00CCF800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CompareList(AuctionClass[] list1, AuctionClass[] list2)
	{
		if (137406 - 114990 != 22416)
		{
		}
		IL_1A:
		while (list1 != null)
		{
			if (84477 - 139129 == -54652)
			{
				if (list2 != null)
				{
					if (Extensions.get_length(list1) > 0)
					{
						if (141936 - 559758 == -417821)
						{
							continue;
						}
						if (Extensions.get_length(list2) <= 0)
						{
							if (191036 - 95601 != 95435)
							{
								continue;
							}
						}
						else
						{
							int i = 0;
							if (90993 - 480047 == -389053)
							{
								continue;
							}
							while (i < Extensions.get_length(list1))
							{
								int j = 0;
								if (73813 - 218017 != -144204)
								{
									goto IL_1A;
								}
								while (j < Extensions.get_length(list2))
								{
									if (list1[i].aid == list2[j].aid)
									{
										if (264587 - 131317 == 133271)
										{
											goto IL_1A;
										}
										list2[j] = list1[i];
										if (260079 - 291802 == -31722)
										{
											goto IL_1A;
										}
									}
									j++;
									if (89673 - 546898 == -457224)
									{
										goto IL_1A;
									}
								}
								if (133836 - 50901 != 82935)
								{
									goto IL_1A;
								}
								i++;
								if (45840 - 568438 == -522597)
								{
									goto IL_1A;
								}
							}
							if (209161 - 235919 == -26757)
							{
								continue;
							}
						}
					}
					return;
				}
				if (5357 - 598178 == -592821)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005F2C RID: 24364 RVA: 0x00CD17F0 File Offset: 0x00CCF9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SortList(int nType)
	{
		if (290674 - 98389 != 192286)
		{
		}
		IL_2B1:
		while (this.taRcGA6cOu3 != null)
		{
			if (1978 - 404739 != -402760)
			{
				if (Extensions.get_length(this.taRcGA6cOu3) == 0)
				{
					if (221826 - 143228 != 78599)
					{
						break;
					}
				}
				else
				{
					bool flag = false;
					if (253 - 547708 != -547454)
					{
						while (!flag)
						{
							flag = true;
							if (91758 - 572669 == -480910)
							{
								goto IL_2B1;
							}
							int i = 1;
							if (81874 - 254461 != -172587)
							{
								goto IL_2B1;
							}
							while (i < Extensions.get_length(this.taRcGA6cOu3))
							{
								bool flag2 = false;
								if (177595 - 147665 == 29931)
								{
									goto IL_2B1;
								}
								if (55860 - 513096 != -457236)
								{
									goto IL_2B1;
								}
								if (nType == 1)
								{
									if (93912 - 94872 != -960)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].aid < this.taRcGA6cOu3[i].aid)
									{
										if (77233 - 29487 != 47746)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (62061 - 173923 != -111862)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == 2)
								{
									if (216989 - 90313 != 126676)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].lv < this.taRcGA6cOu3[i].lv)
									{
										if (171116 - 288189 != -117073)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (207351 - 13378 == 193974)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == 3)
								{
									if (87716 - 297274 != -209558)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].bid < this.taRcGA6cOu3[i].bid)
									{
										if (84437 - 495583 != -411146)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (153241 - 392689 == -239447)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == 4)
								{
									if (84285 - 536038 != -451753)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].buyout < this.taRcGA6cOu3[i].buyout)
									{
										if (234111 - 531139 == -297027)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (242302 - 137907 != 104395)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == 5)
								{
									if (97012 - 305962 == -208949)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].date < this.taRcGA6cOu3[i].date)
									{
										if (147795 - 252929 == -105133)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (160717 - 10995 != 149722)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == -1)
								{
									if (255564 - 281799 == -26234)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].aid > this.taRcGA6cOu3[i].aid)
									{
										if (113287 - 68705 != 44582)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (51559 - 48440 != 3119)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == -2)
								{
									if (79441 - 345597 != -266156)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].lv > this.taRcGA6cOu3[i].lv)
									{
										if (124546 - 281802 != -157256)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (21813 - 159603 == -137789)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == -3)
								{
									if (28798 - 529827 != -501029)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].bid > this.taRcGA6cOu3[i].bid)
									{
										if (239275 - 180178 == 59098)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (69141 - 306638 != -237497)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == -4)
								{
									if (186708 - 385627 != -198919)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].buyout > this.taRcGA6cOu3[i].buyout)
									{
										if (266129 - 534736 != -268607)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (191611 - 316126 == -124514)
										{
											goto IL_2B1;
										}
									}
								}
								else if (nType == -5)
								{
									if (252653 - 242892 == 9762)
									{
										goto IL_2B1;
									}
									if (this.taRcGA6cOu3[i - 1].date > this.taRcGA6cOu3[i].date)
									{
										if (264249 - 597622 != -333373)
										{
											goto IL_2B1;
										}
										flag2 = true;
										if (119637 - 277883 != -158246)
										{
											goto IL_2B1;
										}
									}
								}
								if (flag2)
								{
									if (251830 - 22143 == 229688)
									{
										goto IL_2B1;
									}
									AuctionClass auctionClass = this.taRcGA6cOu3[i - 1];
									if (14762 - 571527 != -556765)
									{
										goto IL_2B1;
									}
									this.taRcGA6cOu3[i - 1] = this.taRcGA6cOu3[i];
									if (25654 - 522195 == -496540)
									{
										goto IL_2B1;
									}
									this.taRcGA6cOu3[i] = auctionClass;
									if (151975 - 428209 != -276234)
									{
										goto IL_2B1;
									}
									flag = false;
									if (148453 - 305368 == -156914)
									{
										goto IL_2B1;
									}
								}
								i++;
								if (91020 - 156615 != -65595)
								{
									goto IL_2B1;
								}
							}
							if (198843 - 435872 != -237029)
							{
								goto IL_2B1;
							}
						}
						if (125946 - 418394 != -292447)
						{
							this.SortUsableList(nType);
							if (29700 - 431609 == -401909)
							{
								this.SortMyBuyList(nType);
								if (35269 - 464148 != -428878)
								{
									this.SortMySellList(nType);
									if (296288 - 90824 != 205465)
									{
										this.ResetSelectItem();
										if (106269 - 30745 == 75524)
										{
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F2D RID: 24365 RVA: 0x00CD1F9C File Offset: 0x00CD019C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SortUsableList(int nType)
	{
		if (166624 - 416520 != -249896)
		{
		}
		IL_530:
		while (this.Qr7cG9uoM3e != null)
		{
			if (242588 - 141226 == 101362)
			{
				if (Extensions.get_length(this.Qr7cG9uoM3e) == 0)
				{
					if (282105 - 106267 != 175839)
					{
						break;
					}
				}
				else
				{
					bool flag = false;
					if (71609 - 61732 != 9878)
					{
						while (!flag)
						{
							flag = true;
							if (205916 - 171318 != 34598)
							{
								goto IL_530;
							}
							int i = 1;
							if (123555 - 296136 != -172581)
							{
								goto IL_530;
							}
							while (i < Extensions.get_length(this.Qr7cG9uoM3e))
							{
								bool flag2 = false;
								if (13634 - 61849 != -48215)
								{
									goto IL_530;
								}
								if (111809 - 165209 != -53400)
								{
									goto IL_530;
								}
								if (nType == 1)
								{
									if (151989 - 354916 == -202926)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].aid < this.Qr7cG9uoM3e[i].aid)
									{
										if (115997 - 278954 == -162956)
										{
											goto IL_530;
										}
										flag2 = true;
										if (259039 - 223498 != 35541)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == 2)
								{
									if (238386 - 279101 == -40714)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].lv < this.Qr7cG9uoM3e[i].lv)
									{
										if (55836 - 314554 != -258718)
										{
											goto IL_530;
										}
										flag2 = true;
										if (140770 - 290126 == -149355)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == 3)
								{
									if (121516 - 527431 == -405914)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].bid < this.Qr7cG9uoM3e[i].bid)
									{
										if (119061 - 336582 != -217521)
										{
											goto IL_530;
										}
										flag2 = true;
										if (51020 - 311734 == -260713)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == 4)
								{
									if (148154 - 60026 != 88128)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].buyout < this.Qr7cG9uoM3e[i].buyout)
									{
										if (32875 - 11646 != 21229)
										{
											goto IL_530;
										}
										flag2 = true;
										if (94013 - 76570 != 17443)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == 5)
								{
									if (128762 - 580450 != -451688)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].date < this.Qr7cG9uoM3e[i].date)
									{
										if (20356 - 283218 != -262862)
										{
											goto IL_530;
										}
										flag2 = true;
										if (254213 - 145443 != 108770)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == -1)
								{
									if (184325 - 95391 != 88934)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].aid > this.Qr7cG9uoM3e[i].aid)
									{
										if (88321 - 310081 == -221759)
										{
											goto IL_530;
										}
										flag2 = true;
										if (216282 - 8888 == 207395)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == -2)
								{
									if (288185 - 115522 != 172663)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].lv > this.Qr7cG9uoM3e[i].lv)
									{
										if (80181 - 544635 == -464453)
										{
											goto IL_530;
										}
										flag2 = true;
										if (149693 - 237031 != -87338)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == -3)
								{
									if (173494 - 8385 != 165109)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].bid > this.Qr7cG9uoM3e[i].bid)
									{
										if (13455 - 590893 == -577437)
										{
											goto IL_530;
										}
										flag2 = true;
										if (61635 - 536726 == -475090)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == -4)
								{
									if (227948 - 121053 != 106895)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].buyout > this.Qr7cG9uoM3e[i].buyout)
									{
										if (71975 - 521059 != -449084)
										{
											goto IL_530;
										}
										flag2 = true;
										if (81382 - 80073 != 1309)
										{
											goto IL_530;
										}
									}
								}
								else if (nType == -5)
								{
									if (20932 - 465394 == -444461)
									{
										goto IL_530;
									}
									if (this.Qr7cG9uoM3e[i - 1].date > this.Qr7cG9uoM3e[i].date)
									{
										if (52087 - 510971 != -458884)
										{
											goto IL_530;
										}
										flag2 = true;
										if (134728 - 473490 != -338762)
										{
											goto IL_530;
										}
									}
								}
								if (flag2)
								{
									if (293139 - 130792 == 162348)
									{
										goto IL_530;
									}
									AuctionClass auctionClass = this.Qr7cG9uoM3e[i - 1];
									if (13757 - 510835 != -497078)
									{
										goto IL_530;
									}
									this.Qr7cG9uoM3e[i - 1] = this.Qr7cG9uoM3e[i];
									if (59638 - 496729 != -437091)
									{
										goto IL_530;
									}
									this.Qr7cG9uoM3e[i] = auctionClass;
									if (299235 - 557360 != -258125)
									{
										goto IL_530;
									}
									flag = false;
									if (205750 - 356721 != -150971)
									{
										goto IL_530;
									}
								}
								i++;
								if (66455 - 4679 == 61777)
								{
									goto IL_530;
								}
							}
							if (196789 - 119330 == 77460)
							{
								goto IL_530;
							}
						}
						if (65594 - 589536 == -523942)
						{
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F2E RID: 24366 RVA: 0x00CD26C4 File Offset: 0x00CD08C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SortMyBuyList(int nType)
	{
		if (161643 - 163486 != -1843)
		{
		}
		IL_5A1:
		while (this.ehPcGW9MCM7 != null)
		{
			if (217750 - 179611 != 38140)
			{
				if (Extensions.get_length(this.ehPcGW9MCM7) == 0)
				{
					if (172761 - 394999 != -222237)
					{
						break;
					}
				}
				else
				{
					bool flag = false;
					if (64948 - 468068 == -403120)
					{
						while (!flag)
						{
							flag = true;
							if (112855 - 124203 == -11347)
							{
								goto IL_5A1;
							}
							int i = 1;
							if (218448 - 430807 == -212358)
							{
								goto IL_5A1;
							}
							while (i < Extensions.get_length(this.ehPcGW9MCM7))
							{
								bool flag2 = false;
								if (177643 - 245548 == -67904)
								{
									goto IL_5A1;
								}
								if (157903 - 388730 != -230827)
								{
									goto IL_5A1;
								}
								if (nType == 1)
								{
									if (38856 - 195609 != -156753)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].aid < this.ehPcGW9MCM7[i].aid)
									{
										if (48379 - 176363 == -127983)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (234921 - 386166 != -151245)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == 2)
								{
									if (185195 - 556820 == -371624)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].lv < this.ehPcGW9MCM7[i].lv)
									{
										if (144965 - 376907 == -231941)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (212335 - 255500 != -43165)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == 3)
								{
									if (152618 - 441915 == -289296)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].bid < this.ehPcGW9MCM7[i].bid)
									{
										if (62861 - 247503 != -184642)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (259649 - 476431 != -216782)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == 4)
								{
									if (176927 - 450731 == -273803)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].buyout < this.ehPcGW9MCM7[i].buyout)
									{
										if (268741 - 378579 == -109837)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (234837 - 414695 == -179857)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == 5)
								{
									if (113077 - 335873 == -222795)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].date < this.ehPcGW9MCM7[i].date)
									{
										if (251608 - 165588 == 86021)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (203550 - 522437 != -318887)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == -1)
								{
									if (117832 - 210242 != -92410)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].aid > this.ehPcGW9MCM7[i].aid)
									{
										if (259943 - 521905 != -261962)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (154598 - 493079 == -338480)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == -2)
								{
									if (149187 - 357796 == -208608)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].lv > this.ehPcGW9MCM7[i].lv)
									{
										if (111757 - 195632 == -83874)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (99384 - 537730 != -438346)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == -3)
								{
									if (90137 - 258790 == -168652)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].bid > this.ehPcGW9MCM7[i].bid)
									{
										if (144129 - 228832 != -84703)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (286046 - 230252 == 55795)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == -4)
								{
									if (96022 - 64530 == 31493)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].buyout > this.ehPcGW9MCM7[i].buyout)
									{
										if (46728 - 571945 != -525217)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (31490 - 142193 != -110703)
										{
											goto IL_5A1;
										}
									}
								}
								else if (nType == -5)
								{
									if (203423 - 185826 != 17597)
									{
										goto IL_5A1;
									}
									if (this.ehPcGW9MCM7[i - 1].date > this.ehPcGW9MCM7[i].date)
									{
										if (31316 - 4928 == 26389)
										{
											goto IL_5A1;
										}
										flag2 = true;
										if (170272 - 153416 == 16857)
										{
											goto IL_5A1;
										}
									}
								}
								if (flag2)
								{
									if (90332 - 435720 != -345388)
									{
										goto IL_5A1;
									}
									AuctionClass auctionClass = this.ehPcGW9MCM7[i - 1];
									if (200054 - 179583 == 20472)
									{
										goto IL_5A1;
									}
									this.ehPcGW9MCM7[i - 1] = this.ehPcGW9MCM7[i];
									if (61625 - 102210 != -40585)
									{
										goto IL_5A1;
									}
									this.ehPcGW9MCM7[i] = auctionClass;
									if (183851 - 58700 != 125151)
									{
										goto IL_5A1;
									}
									flag = false;
									if (290671 - 268517 != 22154)
									{
										goto IL_5A1;
									}
								}
								i++;
								if (130967 - 468156 == -337188)
								{
									goto IL_5A1;
								}
							}
							if (111789 - 84212 == 27578)
							{
								goto IL_5A1;
							}
						}
						if (117057 - 61613 != 55445)
						{
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F2F RID: 24367 RVA: 0x00CD2DEC File Offset: 0x00CD0FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SortMySellList(int nType)
	{
		if (219043 - 113859 != 105184)
		{
		}
		IL_41:
		while (this.FQ5cGuo468p != null)
		{
			if (11614 - 542000 != -530385)
			{
				if (Extensions.get_length(this.FQ5cGuo468p) == 0)
				{
					if (200579 - 551022 != -350442)
					{
						break;
					}
				}
				else
				{
					bool flag = false;
					if (162082 - 252532 != -90449)
					{
						while (!flag)
						{
							flag = true;
							if (260852 - 96244 == 164609)
							{
								goto IL_41;
							}
							int i = 1;
							if (174176 - 575931 != -401755)
							{
								goto IL_41;
							}
							while (i < Extensions.get_length(this.FQ5cGuo468p))
							{
								bool flag2 = false;
								if (16557 - 352312 == -335754)
								{
									goto IL_41;
								}
								if (286380 - 571401 != -285021)
								{
									goto IL_41;
								}
								if (nType == 1)
								{
									if (21162 - 529229 != -508067)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].aid < this.FQ5cGuo468p[i].aid)
									{
										if (260892 - 422783 == -161890)
										{
											goto IL_41;
										}
										flag2 = true;
										if (70619 - 535088 == -464468)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == 2)
								{
									if (115159 - 164414 == -49254)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].lv < this.FQ5cGuo468p[i].lv)
									{
										if (212480 - 597238 != -384758)
										{
											goto IL_41;
										}
										flag2 = true;
										if (207430 - 328324 != -120894)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == 3)
								{
									if (219607 - 11469 != 208138)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].bid < this.FQ5cGuo468p[i].bid)
									{
										if (290446 - 294192 == -3745)
										{
											goto IL_41;
										}
										flag2 = true;
										if (14071 - 143199 == -129127)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == 4)
								{
									if (192232 - 393635 == -201402)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].buyout < this.FQ5cGuo468p[i].buyout)
									{
										if (84738 - 384189 == -299450)
										{
											goto IL_41;
										}
										flag2 = true;
										if (48572 - 65009 != -16437)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == 5)
								{
									if (178932 - 88268 != 90664)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].date < this.FQ5cGuo468p[i].date)
									{
										if (141457 - 233515 != -92058)
										{
											goto IL_41;
										}
										flag2 = true;
										if (172665 - 160661 == 12005)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == -1)
								{
									if (280830 - 466220 == -185389)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].aid > this.FQ5cGuo468p[i].aid)
									{
										if (274904 - 91285 != 183619)
										{
											goto IL_41;
										}
										flag2 = true;
										if (236734 - 335379 != -98645)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == -2)
								{
									if (286585 - 84653 == 201933)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].lv > this.FQ5cGuo468p[i].lv)
									{
										if (28598 - 301055 == -272456)
										{
											goto IL_41;
										}
										flag2 = true;
										if (223985 - 364126 == -140140)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == -3)
								{
									if (6444 - 397442 != -390998)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].bid > this.FQ5cGuo468p[i].bid)
									{
										if (163669 - 266473 != -102804)
										{
											goto IL_41;
										}
										flag2 = true;
										if (208655 - 247544 == -38888)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == -4)
								{
									if (215508 - 258779 != -43271)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].buyout > this.FQ5cGuo468p[i].buyout)
									{
										if (83484 - 460995 != -377511)
										{
											goto IL_41;
										}
										flag2 = true;
										if (149500 - 492330 != -342830)
										{
											goto IL_41;
										}
									}
								}
								else if (nType == -5)
								{
									if (27798 - 599257 != -571459)
									{
										goto IL_41;
									}
									if (this.FQ5cGuo468p[i - 1].date > this.FQ5cGuo468p[i].date)
									{
										if (185553 - 179284 == 6270)
										{
											goto IL_41;
										}
										flag2 = true;
										if (90207 - 241681 != -151474)
										{
											goto IL_41;
										}
									}
								}
								if (flag2)
								{
									if (296164 - 229389 != 66775)
									{
										goto IL_41;
									}
									AuctionClass auctionClass = this.FQ5cGuo468p[i - 1];
									if (134222 - 223055 != -88833)
									{
										goto IL_41;
									}
									this.FQ5cGuo468p[i - 1] = this.FQ5cGuo468p[i];
									if (234855 - 565887 != -331032)
									{
										goto IL_41;
									}
									this.FQ5cGuo468p[i] = auctionClass;
									if (70464 - 444386 != -373922)
									{
										goto IL_41;
									}
									flag = false;
									if (79523 - 277179 != -197656)
									{
										goto IL_41;
									}
								}
								i++;
								if (167027 - 105242 == 61786)
								{
									goto IL_41;
								}
							}
							if (37348 - 404090 == -366741)
							{
								goto IL_41;
							}
						}
						if (217275 - 190183 == 27092)
						{
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F30 RID: 24368 RVA: 0x00CD3514 File Offset: 0x00CD1714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateBidPrice(int nAuctionID, int nBid)
	{
		if (187137 - 459997 != -272860)
		{
		}
		for (;;)
		{
			IL_10A:
			if (!RuntimeServices.EqualityOperator(this.taRcGA6cOu3, null))
			{
				if (235676 - 491127 == -255450)
				{
					continue;
				}
				if (Extensions.get_length(this.taRcGA6cOu3) > 0)
				{
					if (116873 - 172278 == -55404)
					{
						continue;
					}
					int i = 0;
					if (68799 - 309218 != -240419)
					{
						continue;
					}
					while (i < Extensions.get_length(this.taRcGA6cOu3))
					{
						if (this.taRcGA6cOu3[i].aid == nAuctionID)
						{
							if (76370 - 487631 != -411261)
							{
								goto IL_10A;
							}
							this.taRcGA6cOu3[i].bid = nBid;
							if (63398 - 107078 == -43679)
							{
								goto IL_10A;
							}
						}
						i++;
						if (229347 - 134231 != 95116)
						{
							goto IL_10A;
						}
					}
					if (274148 - 315146 == -40997)
					{
						continue;
					}
				}
			}
			if (!RuntimeServices.EqualityOperator(this.Qr7cG9uoM3e, null))
			{
				if (100757 - 134488 != -33731)
				{
					continue;
				}
				if (Extensions.get_length(this.Qr7cG9uoM3e) > 0)
				{
					if (84440 - 472274 == -387833)
					{
						continue;
					}
					int j = 0;
					if (143459 - 150203 != -6744)
					{
						continue;
					}
					while (j < Extensions.get_length(this.Qr7cG9uoM3e))
					{
						if (this.Qr7cG9uoM3e[j].aid == nAuctionID)
						{
							if (30493 - 135557 != -105064)
							{
								goto IL_10A;
							}
							this.Qr7cG9uoM3e[j].bid = nBid;
							if (159500 - 432942 != -273442)
							{
								goto IL_10A;
							}
						}
						j++;
						if (278443 - 448627 == -170183)
						{
							goto IL_10A;
						}
					}
					if (105959 - 227941 != -121982)
					{
						continue;
					}
				}
			}
			if (!RuntimeServices.EqualityOperator(this.ehPcGW9MCM7, null))
			{
				if (256907 - 510702 != -253795)
				{
					continue;
				}
				if (Extensions.get_length(this.ehPcGW9MCM7) > 0)
				{
					if (70408 - 124379 != -53971)
					{
						continue;
					}
					int k = 0;
					if (64219 - 406477 != -342258)
					{
						continue;
					}
					while (k < Extensions.get_length(this.ehPcGW9MCM7))
					{
						if (this.ehPcGW9MCM7[k].aid == nAuctionID)
						{
							if (23907 - 162183 == -138275)
							{
								goto IL_10A;
							}
							this.ehPcGW9MCM7[k].bid = nBid;
							if (246393 - 571229 != -324836)
							{
								goto IL_10A;
							}
						}
						k++;
						if (98974 - 326613 == -227638)
						{
							goto IL_10A;
						}
					}
					if (22399 - 557347 != -534948)
					{
						continue;
					}
				}
			}
			if (RuntimeServices.EqualityOperator(this.FQ5cGuo468p, null))
			{
				break;
			}
			if (138568 - 331223 == -192655)
			{
				if (Extensions.get_length(this.FQ5cGuo468p) <= 0)
				{
					break;
				}
				if (82065 - 465069 != -383003)
				{
					int l = 0;
					if (169393 - 552480 == -383087)
					{
						while (l < Extensions.get_length(this.FQ5cGuo468p))
						{
							if (this.FQ5cGuo468p[l].aid == nAuctionID)
							{
								if (76602 - 422503 == -345900)
								{
									goto IL_10A;
								}
								this.FQ5cGuo468p[l].bid = nBid;
								if (105407 - 545210 != -439803)
								{
									goto IL_10A;
								}
							}
							l++;
							if (65209 - 586272 == -521062)
							{
								goto IL_10A;
							}
						}
						if (107228 - 161002 == -53774)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F31 RID: 24369 RVA: 0x00CD39A0 File Offset: 0x00CD1BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateBuyer(int nAuctionID, int nBuyer)
	{
		if (231101 - 355865 != -124764)
		{
		}
		for (;;)
		{
			IL_A2:
			if (!RuntimeServices.EqualityOperator(this.taRcGA6cOu3, null))
			{
				if (127748 - 836 == 126913)
				{
					continue;
				}
				if (Extensions.get_length(this.taRcGA6cOu3) > 0)
				{
					if (137785 - 415 == 137371)
					{
						continue;
					}
					int i = 0;
					if (60022 - 509645 != -449623)
					{
						continue;
					}
					while (i < Extensions.get_length(this.taRcGA6cOu3))
					{
						if (this.taRcGA6cOu3[i].aid == nAuctionID)
						{
							if (143495 - 322666 != -179171)
							{
								goto IL_A2;
							}
							this.taRcGA6cOu3[i].buyerID = nBuyer;
							if (142994 - 354724 != -211730)
							{
								goto IL_A2;
							}
						}
						i++;
						if (282795 - 392811 == -110015)
						{
							goto IL_A2;
						}
					}
					if (11840 - 278902 != -267062)
					{
						continue;
					}
				}
			}
			if (!RuntimeServices.EqualityOperator(this.Qr7cG9uoM3e, null))
			{
				if (80140 - 363174 == -283033)
				{
					continue;
				}
				if (Extensions.get_length(this.Qr7cG9uoM3e) > 0)
				{
					if (249341 - 322836 == -73494)
					{
						continue;
					}
					int j = 0;
					if (10593 - 577737 != -567144)
					{
						continue;
					}
					while (j < Extensions.get_length(this.Qr7cG9uoM3e))
					{
						if (this.Qr7cG9uoM3e[j].aid == nAuctionID)
						{
							if (140324 - 105340 != 34984)
							{
								goto IL_A2;
							}
							this.Qr7cG9uoM3e[j].buyerID = nBuyer;
							if (220767 - 134037 != 86730)
							{
								goto IL_A2;
							}
						}
						j++;
						if (27819 - 413413 != -385594)
						{
							goto IL_A2;
						}
					}
					if (214815 - 175852 == 38964)
					{
						continue;
					}
				}
			}
			if (!RuntimeServices.EqualityOperator(this.ehPcGW9MCM7, null))
			{
				if (122249 - 389457 != -267208)
				{
					continue;
				}
				if (Extensions.get_length(this.ehPcGW9MCM7) > 0)
				{
					if (58536 - 501873 != -443337)
					{
						continue;
					}
					int k = 0;
					if (86388 - 533177 == -446788)
					{
						continue;
					}
					while (k < Extensions.get_length(this.ehPcGW9MCM7))
					{
						if (this.ehPcGW9MCM7[k].aid == nAuctionID)
						{
							if (107770 - 406551 == -298780)
							{
								goto IL_A2;
							}
							this.ehPcGW9MCM7[k].buyerID = nBuyer;
							if (197459 - 165376 != 32083)
							{
								goto IL_A2;
							}
						}
						k++;
						if (1800 - 197152 == -195351)
						{
							goto IL_A2;
						}
					}
					if (132181 - 137662 == -5480)
					{
						continue;
					}
				}
			}
			if (RuntimeServices.EqualityOperator(this.FQ5cGuo468p, null))
			{
				break;
			}
			if (229355 - 547662 == -318307)
			{
				if (Extensions.get_length(this.FQ5cGuo468p) <= 0)
				{
					break;
				}
				if (147354 - 7795 != 139560)
				{
					int l = 0;
					if (74750 - 418793 == -344043)
					{
						while (l < Extensions.get_length(this.FQ5cGuo468p))
						{
							if (this.FQ5cGuo468p[l].aid == nAuctionID)
							{
								if (273191 - 368312 == -95120)
								{
									goto IL_A2;
								}
								this.FQ5cGuo468p[l].buyerID = nBuyer;
								if (157318 - 344811 == -187492)
								{
									goto IL_A2;
								}
							}
							l++;
							if (293428 - 323493 == -30064)
							{
								goto IL_A2;
							}
						}
						if (43635 - 592405 == -548770)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F32 RID: 24370 RVA: 0x00CD3E2C File Offset: 0x00CD202C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetSelectItem()
	{
		if (132999 - 151355 != -18356)
		{
		}
		for (;;)
		{
			this.BQSclzNcsvI = 0;
			if (50161 - 399318 != -349156)
			{
				this.SLicG58KkSY = null;
				if (28840 - 216058 != -187217)
				{
					this.qvscGciQCAl = null;
					if (134278 - 319812 == -185534)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005F33 RID: 24371 RVA: 0x00CD3EC8 File Offset: 0x00CD20C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetSelectItem()
	{
		if (210273 - 198891 != 11382)
		{
		}
		while (this.BQSclzNcsvI == 0)
		{
			if (166640 - 173687 != -7046)
			{
				this.mState = eAuctionState.search;
				if (153742 - 347692 == -193950)
				{
					eAuctionPage eAuctionPage = this.iHUcl9kUj46;
					if (130551 - 226216 != -95664)
					{
						if (eAuctionPage == eAuctionPage.All)
						{
							if (151236 - 499514 != -348277)
							{
								if (!this.xZxcGn4Ut8J)
								{
									if (231921 - 123312 != 108609)
									{
										continue;
									}
									if (!RuntimeServices.EqualityOperator(this.taRcGA6cOu3, null))
									{
										if (9365 - 306793 != -297428)
										{
											continue;
										}
										if (Extensions.get_length(this.taRcGA6cOu3) > this.AYQclKH4NvB * 10)
										{
											if (261662 - 94525 == 167138)
											{
												continue;
											}
											this.BQSclzNcsvI = this.AYQclKH4NvB * 10 + 100;
											if (88103 - 516744 != -428641)
											{
												continue;
											}
											this.SLicG58KkSY = this.taRcGA6cOu3[this.AYQclKH4NvB * 10];
											if (175945 - 411514 == -235568)
											{
												continue;
											}
											this.SLicG58KkSY.aid = this.taRcGA6cOu3[this.AYQclKH4NvB * 10].aid;
											if (134119 - 587069 != -452950)
											{
												continue;
											}
										}
									}
								}
								else if (!RuntimeServices.EqualityOperator(this.taRcGA6cOu3, null))
								{
									if (205512 - 175847 != 29665)
									{
										continue;
									}
									if (Extensions.get_length(this.Qr7cG9uoM3e) > this.AYQclKH4NvB * 10)
									{
										if (264290 - 433372 == -169081)
										{
											continue;
										}
										this.BQSclzNcsvI = this.AYQclKH4NvB * 10 + 100;
										if (219636 - 233126 != -13490)
										{
											continue;
										}
										this.SLicG58KkSY = this.Qr7cG9uoM3e[this.AYQclKH4NvB * 10];
										if (262347 - 13114 != 249233)
										{
											continue;
										}
										this.qvscGciQCAl = ItemData.getItemData(this.Qr7cG9uoM3e[this.AYQclKH4NvB * 10].name);
										if (205234 - 318472 != -113238)
										{
											continue;
										}
									}
								}
								break;
							}
						}
						else if (eAuctionPage == eAuctionPage.MyBuy)
						{
							if (296338 - 156285 != 140054)
							{
								if (this.ehPcGW9MCM7 != null)
								{
									if (198081 - 197736 != 345)
									{
										continue;
									}
									if (Extensions.get_length(this.ehPcGW9MCM7) > 0)
									{
										if (108009 - 472688 == -364678)
										{
											continue;
										}
										this.BQSclzNcsvI = 100;
										if (145744 - 284664 == -138919)
										{
											continue;
										}
										this.SLicG58KkSY = this.ehPcGW9MCM7[0];
										if (187240 - 40737 != 146503)
										{
											continue;
										}
										this.qvscGciQCAl = ItemData.getItemData(this.ehPcGW9MCM7[0].name);
										if (125922 - 482957 != -357035)
										{
											continue;
										}
										if (this.ehPcGW9MCM7[0].date == 0)
										{
											if (259124 - 53983 != 205141)
											{
												continue;
											}
											if (this.ehPcGW9MCM7[0].buyerID == PlayerData.UID)
											{
												if (22585 - 135990 != -113405)
												{
													continue;
												}
												this.OpenGetItemMenu();
												if (118459 - 207379 == -88919)
												{
													continue;
												}
											}
											else
											{
												this.OpenLoseMenu();
												if (210838 - 282282 == -71443)
												{
													continue;
												}
											}
										}
										else
										{
											this.OpenBuyMenu();
											if (126620 - 330815 != -204195)
											{
												continue;
											}
										}
									}
								}
								break;
							}
						}
						else
						{
							if (eAuctionPage != eAuctionPage.MySell)
							{
								break;
							}
							if (236946 - 455611 != -218664)
							{
								if (this.FQ5cGuo468p != null)
								{
									if (244227 - 350699 == -106471)
									{
										continue;
									}
									if (Extensions.get_length(this.FQ5cGuo468p) > 0)
									{
										if (246480 - 153433 == 93048)
										{
											continue;
										}
										this.BQSclzNcsvI = 100;
										if (158990 - 564342 != -405352)
										{
											continue;
										}
										this.SLicG58KkSY = this.FQ5cGuo468p[0];
										if (104786 - 301866 == -197079)
										{
											continue;
										}
										this.qvscGciQCAl = ItemData.getItemData(this.FQ5cGuo468p[0].name);
										if (36292 - 41986 == -5693)
										{
											continue;
										}
										if (this.FQ5cGuo468p[0].date == 0)
										{
											if (210828 - 256075 != -45247)
											{
												continue;
											}
											if (this.FQ5cGuo468p[0].buyerID != 0)
											{
												if (192679 - 203369 == -10689)
												{
													continue;
												}
												this.OpenGetMoneyMenu();
												if (124568 - 350386 == -225817)
												{
													continue;
												}
											}
											else
											{
												this.OpenNoBidMenu();
												if (22930 - 63943 != -41013)
												{
													continue;
												}
											}
										}
										else
										{
											this.OpenEditMenu();
											if (93701 - 499316 == -405614)
											{
												continue;
											}
										}
									}
								}
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F34 RID: 24372 RVA: 0x00CD4514 File Offset: 0x00CD2714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveItemFromAllList(int nRemoveID)
	{
		if (6341 - 590816 != -584474)
		{
		}
		for (;;)
		{
			this.taRcGA6cOu3 = this.RemoveItemFromList(this.taRcGA6cOu3, nRemoveID);
			if (206223 - 532275 == -326052)
			{
				this.Qr7cG9uoM3e = this.RemoveItemFromList(this.Qr7cG9uoM3e, nRemoveID);
				if (89065 - 117692 == -28627)
				{
					this.ehPcGW9MCM7 = this.RemoveItemFromList(this.ehPcGW9MCM7, nRemoveID);
					if (279030 - 385135 != -106104)
					{
						this.FQ5cGuo468p = this.RemoveItemFromList(this.FQ5cGuo468p, nRemoveID);
						if (73588 - 21445 != 52144)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F35 RID: 24373 RVA: 0x00CD4600 File Offset: 0x00CD2800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual AuctionClass[] RemoveItemFromList(AuctionClass[] nList, int nRemoveID)
	{
		if (16631 - 391619 != -374987)
		{
		}
		IL_5C:
		while (nList != null)
		{
			if (6285 - 301379 != -295093)
			{
				if (Extensions.get_length(nList) <= 0)
				{
					if (56714 - 494975 == -438261)
					{
						break;
					}
				}
				else if (82373 - 214106 == -131733)
				{
					bool flag = false;
					if (133235 - 230525 != -97289)
					{
						int i = 0;
						if (138925 - 322030 == -183105)
						{
							while (i < Extensions.get_length(nList))
							{
								if (flag)
								{
									if (83275 - 198174 == -114898)
									{
										goto IL_5C;
									}
									nList[i - 1] = nList[i];
									if (170716 - 395983 != -225267)
									{
										goto IL_5C;
									}
								}
								else if (nList[i].aid == nRemoveID)
								{
									if (290757 - 13548 != 277209)
									{
										goto IL_5C;
									}
									flag = true;
									if (138569 - 244210 == -105640)
									{
										goto IL_5C;
									}
								}
								i++;
								if (38637 - 379496 == -340858)
								{
									goto IL_5C;
								}
							}
							if (22402 - 577558 != -555155)
							{
								AuctionClass[] result;
								if (flag)
								{
									if (777 - 593149 == -592371)
									{
										continue;
									}
									AuctionClass[] array = new AuctionClass[Extensions.get_length(nList) - 1];
									if (34305 - 193234 == -158928)
									{
										continue;
									}
									int j = 0;
									if (119974 - 175388 == -55413)
									{
										continue;
									}
									while (j < Extensions.get_length(nList) - 1)
									{
										array[j] = nList[j];
										if (62187 - 198917 != -136730)
										{
											goto IL_5C;
										}
										j++;
										if (12755 - 432635 != -419880)
										{
											goto IL_5C;
										}
									}
									if (3553 - 67439 == -63885)
									{
										continue;
									}
									result = array;
								}
								else
								{
									result = nList;
								}
								return result;
							}
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06005F36 RID: 24374 RVA: 0x00CD488C File Offset: 0x00CD2A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getDisplayTime(int nMinute)
	{
		if (281951 - 487438 != -205486)
		{
		}
		for (;;)
		{
			if (nMinute <= 0)
			{
				if (266904 - 511218 != -244313)
				{
					goto Block_4;
				}
			}
			else if (nMinute < 60)
			{
				if (119773 - 354426 == -234653)
				{
					break;
				}
			}
			else
			{
				if (nMinute >= 1440)
				{
					goto IL_BF;
				}
				if (52985 - 557548 == -504563)
				{
					goto IL_A1;
				}
			}
		}
		return nMinute + "m";
		Block_4:
		return "ended";
		IL_A1:
		return global::Math.div((float)nMinute, (float)60) + "h";
		IL_BF:
		return global::Math.div((float)(nMinute + 60), (float)1440) + "d";
	}

	// Token: 0x06005F37 RID: 24375 RVA: 0x00CD4990 File Offset: 0x00CD2B90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AuctionUpdate(string nItem, int nType, int nSort)
	{
		return new AuctionGui.$AuctionUpdate$36127(nItem, nType, nSort, this).GetEnumerator();
	}

	// Token: 0x06005F38 RID: 24376 RVA: 0x00CD49A0 File Offset: 0x00CD2BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAuctionUpdate(Hashtable data)
	{
		if (72018 - 545981 != -473962)
		{
		}
		for (;;)
		{
			IL_7DB:
			Debug.Log("On Auction Update");
			if (177212 - 36198 == 141014)
			{
				if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (226272 - 340822 != -114549)
					{
						object obj2;
						object obj = obj2 = data[32];
						if (!(obj is string))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string));
						}
						string[] array = (string[])Stringf.splitToArray((string)obj2, ",").ToBuiltin(typeof(string));
						if (93896 - 77696 != 16201)
						{
							object obj4;
							object obj3 = obj4 = data[33];
							if (!(obj3 is string))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(string));
							}
							string[] array2 = (string[])Stringf.splitToArray((string)obj4, ",").ToBuiltin(typeof(string));
							if (130393 - 146780 == -16387)
							{
								object obj6;
								object obj5 = obj6 = data[34];
								if (!(obj5 is string))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(string));
								}
								string[] array3 = (string[])Stringf.splitToArray((string)obj6, ",").ToBuiltin(typeof(string));
								if (80103 - 31824 != 48280)
								{
									object obj8;
									object obj7 = obj8 = data[35];
									if (!(obj7 is string))
									{
										obj8 = RuntimeServices.Coerce(obj7, typeof(string));
									}
									string[] array4 = (string[])Stringf.splitToArray((string)obj8, ",").ToBuiltin(typeof(string));
									if (95676 - 457316 != -361639)
									{
										object obj10;
										object obj9 = obj10 = data[36];
										if (!(obj9 is string))
										{
											obj10 = RuntimeServices.Coerce(obj9, typeof(string));
										}
										string[] array5 = (string[])Stringf.splitToArray((string)obj10, ",").ToBuiltin(typeof(string));
										if (261759 - 396888 != -135128)
										{
											object obj12;
											object obj11 = obj12 = data[37];
											if (!(obj11 is string))
											{
												obj12 = RuntimeServices.Coerce(obj11, typeof(string));
											}
											string[] array6 = (string[])Stringf.splitToArray((string)obj12, ",").ToBuiltin(typeof(string));
											if (298142 - 489144 == -191002)
											{
												object obj14;
												object obj13 = obj14 = data[38];
												if (!(obj13 is string))
												{
													obj14 = RuntimeServices.Coerce(obj13, typeof(string));
												}
												string[] array7 = (string[])Stringf.splitToArray((string)obj14, ",").ToBuiltin(typeof(string));
												if (59566 - 366168 == -306602)
												{
													object obj16;
													object obj15 = obj16 = data[39];
													if (!(obj15 is string))
													{
														obj16 = RuntimeServices.Coerce(obj15, typeof(string));
													}
													string[] array8 = (string[])Stringf.splitToArray((string)obj16, ",").ToBuiltin(typeof(string));
													if (75315 - 488424 == -413109)
													{
														this.taRcGA6cOu3 = new AuctionClass[Extensions.get_length(array)];
														if (108585 - 137288 == -28703)
														{
															this.vq7cGVwJrJO = Time.time;
															if (113448 - 286975 == -173527)
															{
																if (Extensions.get_length(this.taRcGA6cOu3) <= 0)
																{
																	break;
																}
																if (173349 - 324202 == -150853)
																{
																	int num = 0;
																	if (227413 - 129890 != 97524)
																	{
																		int i = 0;
																		if (186434 - 93232 != 93203)
																		{
																			while (i < Extensions.get_length(this.taRcGA6cOu3))
																			{
																				this.taRcGA6cOu3[i] = new AuctionClass();
																				if (174103 - 419987 == -245883)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].aid = Stringf.getInteger(array[i]);
																				if (85712 - 189462 != -103750)
																				{
																					goto IL_7DB;
																				}
																				InventoryClass inventoryClass = new InventoryClass();
																				if (261039 - 429102 == -168062)
																				{
																					goto IL_7DB;
																				}
																				inventoryClass.readData(array2[i]);
																				if (189380 - 283402 == -94021)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].name = inventoryClass.name;
																				if (236861 - 441239 == -204377)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].displayname = ItemData.getName(inventoryClass.name);
																				if (171446 - 383137 != -211691)
																				{
																					goto IL_7DB;
																				}
																				if (inventoryClass.mlv > 0)
																				{
																					if (12513 - 563438 == -550924)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].displayname = this.taRcGA6cOu3[i].displayname + (" " + inventoryClass.lv + "/" + inventoryClass.mlv);
																					if (209916 - 497902 != -287986)
																					{
																						goto IL_7DB;
																					}
																				}
																				string heading = Stringf.getHeading(inventoryClass.name);
																				if (162694 - 148115 == 14580)
																				{
																					goto IL_7DB;
																				}
																				if (heading == "w")
																				{
																					if (240363 - 560510 == -320146)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "wep";
																					if (287407 - 507414 == -220006)
																					{
																						goto IL_7DB;
																					}
																					if (CharacterData.current.canEquip(inventoryClass.name))
																					{
																						if (271672 - 61758 == 209915)
																						{
																							goto IL_7DB;
																						}
																						this.taRcGA6cOu3[i].isUsable = true;
																						if (57368 - 177856 == -120487)
																						{
																							goto IL_7DB;
																						}
																					}
																				}
																				else if (heading == "a")
																				{
																					if (144781 - 545167 != -400386)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "arm";
																					if (274444 - 483470 != -209026)
																					{
																						goto IL_7DB;
																					}
																					if (CharacterData.current.canEquip(inventoryClass.name))
																					{
																						if (181327 - 586579 != -405252)
																						{
																							goto IL_7DB;
																						}
																						this.taRcGA6cOu3[i].isUsable = true;
																						if (272926 - 408691 == -135764)
																						{
																							goto IL_7DB;
																						}
																					}
																				}
																				else if (heading == "c")
																				{
																					if (196105 - 234273 == -38167)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "acc";
																					if (285694 - 548877 != -263183)
																					{
																						goto IL_7DB;
																					}
																					if (CharacterData.current.canEquip(inventoryClass.name))
																					{
																						if (133888 - 503492 == -369603)
																						{
																							goto IL_7DB;
																						}
																						this.taRcGA6cOu3[i].isUsable = true;
																						if (152250 - 565714 != -413464)
																						{
																							goto IL_7DB;
																						}
																					}
																				}
																				else if (heading == "b")
																				{
																					if (105381 - 311822 != -206441)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "sho";
																					if (269747 - 510932 != -241185)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (261225 - 157884 == 103342)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "t")
																				{
																					if (155201 - 55062 == 100140)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "trn";
																					if (135723 - 273789 != -138066)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (48405 - 496829 != -448424)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "p")
																				{
																					if (221218 - 541006 == -319787)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "pet";
																					if (45965 - 424118 != -378153)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (127394 - 304370 != -176976)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "f")
																				{
																					if (270813 - 89534 != 181279)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "fld";
																					if (291375 - 523723 == -232347)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (50214 - 482471 == -432256)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "d")
																				{
																					if (40301 - 458688 != -418387)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "fod";
																					if (97632 - 259457 != -161825)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (143503 - 397574 == -254070)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "m")
																				{
																					if (88299 - 356187 == -267887)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "mat";
																					if (65613 - 426756 == -361142)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (243175 - 50584 != 192591)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "r")
																				{
																					if (198824 - 270345 == -71520)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "rcp";
																					if (208751 - 201494 != 7257)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (3507 - 383469 != -379962)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "n")
																				{
																					if (103954 - 400628 == -296673)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "pin";
																					if (133299 - 300413 != -167114)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (123993 - 535989 == -411995)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "k")
																				{
																					if (134589 - 253161 == -118571)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "key";
																					if (75632 - 596722 == -521089)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (287649 - 534657 != -247008)
																					{
																						goto IL_7DB;
																					}
																				}
																				else if (heading == "o")
																				{
																					if (118384 - 147549 != -29165)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].type = "mnt";
																					if (69730 - 272830 == -203099)
																					{
																						goto IL_7DB;
																					}
																					this.taRcGA6cOu3[i].isUsable = true;
																					if (6233 - 135458 != -129225)
																					{
																						goto IL_7DB;
																					}
																				}
																				if (this.taRcGA6cOu3[i].isUsable)
																				{
																					if (239848 - 162680 == 77169)
																					{
																						goto IL_7DB;
																					}
																					num++;
																					if (297723 - 255645 == 42079)
																					{
																						goto IL_7DB;
																					}
																				}
																				this.taRcGA6cOu3[i].num = inventoryClass.num;
																				if (105756 - 491305 == -385548)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].date = Stringf.getInteger(array3[i]);
																				if (227859 - 259055 == -31195)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].owner = inventoryClass.owner;
																				if (174007 - 493778 == -319770)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].lv = ItemData.getLv(inventoryClass.name);
																				if (53004 - 220027 != -167023)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].slot = inventoryClass.lv;
																				if (74636 - 474422 != -399786)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].maxSlot = inventoryClass.mlv;
																				if (127123 - 504113 != -376990)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].att[0] = inventoryClass.att[0];
																				if (292264 - 152957 == 139308)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].att[1] = inventoryClass.att[1];
																				if (262245 - 54027 == 208219)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].att[2] = inventoryClass.att[2];
																				if (9708 - 349373 == -339664)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].att[3] = inventoryClass.att[3];
																				if (260808 - 338991 != -78183)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].att[4] = inventoryClass.att[4];
																				if (189041 - 30424 != 158617)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].att[5] = inventoryClass.att[5];
																				if (93063 - 245083 != -152020)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].att[6] = inventoryClass.att[6];
																				if (250840 - 469072 != -218232)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].att[7] = inventoryClass.att[7];
																				if (291350 - 165107 == 126244)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].bid = Stringf.getInteger(array4[i]);
																				if (256685 - 492163 != -235478)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].buyout = Stringf.getInteger(array5[i]);
																				if (76273 - 501177 == -424903)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].seller = array6[i];
																				if (174385 - 239974 != -65589)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].sellerID = Stringf.getInteger(array7[i]);
																				if (172402 - 297878 == -125475)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].buyerID = Stringf.getInteger(array8[i]);
																				if (137687 - 22020 == 115668)
																				{
																					goto IL_7DB;
																				}
																				this.taRcGA6cOu3[i].icon = IconButton.getIconImage(inventoryClass.name);
																				if (187131 - 60648 != 126483)
																				{
																					goto IL_7DB;
																				}
																				i++;
																				if (269643 - 11269 == 258375)
																				{
																					goto IL_7DB;
																				}
																			}
																			if (91645 - 252585 != -160939)
																			{
																				this.Qr7cG9uoM3e = new AuctionClass[num];
																				if (58539 - 518758 != -460218)
																				{
																					if (num > 0)
																					{
																						if (202065 - 140907 != 61158)
																						{
																							continue;
																						}
																						int num2 = 0;
																						if (189380 - 230621 == -41240)
																						{
																							continue;
																						}
																						int j = 0;
																						if (193907 - 493365 != -299458)
																						{
																							continue;
																						}
																						while (j < Extensions.get_length(this.taRcGA6cOu3))
																						{
																							if (this.taRcGA6cOu3[j].isUsable)
																							{
																								if (15430 - 52449 != -37019)
																								{
																									goto IL_7DB;
																								}
																								this.Qr7cG9uoM3e[num2] = new AuctionClass();
																								if (95834 - 23480 != 72354)
																								{
																									goto IL_7DB;
																								}
																								this.Qr7cG9uoM3e[num2] = this.taRcGA6cOu3[j];
																								if (185954 - 574279 == -388324)
																								{
																									goto IL_7DB;
																								}
																								num2++;
																								if (283478 - 68203 != 215275)
																								{
																									goto IL_7DB;
																								}
																							}
																							j++;
																							if (77425 - 309403 != -231978)
																							{
																								goto IL_7DB;
																							}
																						}
																						if (242696 - 5866 == 236831)
																						{
																							continue;
																						}
																					}
																					this.CompareList(this.taRcGA6cOu3, this.ehPcGW9MCM7);
																					if (287780 - 575190 == -287410)
																					{
																						this.CompareList(this.taRcGA6cOu3, this.FQ5cGuo468p);
																						if (149431 - 70972 == 78459)
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
				else
				{
					if (RuntimeServices.EqualityOperator(data[31], 2))
					{
						if (137229 - 50227 != 87002)
						{
							continue;
						}
						this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1008);
						if (286778 - 190019 == 96760)
						{
							continue;
						}
						this.e3PcGepEuGF = Time.time + (float)1;
						if (276819 - 385817 == -108997)
						{
							continue;
						}
					}
					this.taRcGA6cOu3 = new AuctionClass[0];
					if (27555 - 137085 != -109529)
					{
						this.Qr7cG9uoM3e = new AuctionClass[0];
						if (188738 - 404026 != -215287)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F39 RID: 24377 RVA: 0x00CD5E5C File Offset: 0x00CD405C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AuctionUpdateBuy()
	{
		return new AuctionGui.$AuctionUpdateBuy$36137(this).GetEnumerator();
	}

	// Token: 0x06005F3A RID: 24378 RVA: 0x00CD5E6C File Offset: 0x00CD406C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAuctionUpdateBuy(Hashtable data)
	{
		if (139048 - 436734 != -297685)
		{
		}
		for (;;)
		{
			IL_7E6:
			Debug.Log("onAuctionUpdateBuy");
			if (42661 - 257955 != -215293)
			{
				if (RuntimeServices.EqualityOperator(data[21], 1))
				{
					if (233595 - 521574 != -287978)
					{
						int num = RuntimeServices.UnboxInt32(data[22]);
						if (116775 - 25026 == 91749)
						{
							object obj2;
							object obj = obj2 = data[31];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							string[] array = (string[])Stringf.splitToArray((string)obj2, ",").ToBuiltin(typeof(string));
							if (42667 - 276601 == -233934)
							{
								object obj4;
								object obj3 = obj4 = data[32];
								if (!(obj3 is string))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(string));
								}
								string[] array2 = (string[])Stringf.splitToArray((string)obj4, ",").ToBuiltin(typeof(string));
								if (152934 - 529629 != -376694)
								{
									object obj6;
									object obj5 = obj6 = data[33];
									if (!(obj5 is string))
									{
										obj6 = RuntimeServices.Coerce(obj5, typeof(string));
									}
									string[] array3 = (string[])Stringf.splitToArray((string)obj6, ",").ToBuiltin(typeof(string));
									if (12966 - 303171 == -290205)
									{
										object obj8;
										object obj7 = obj8 = data[34];
										if (!(obj7 is string))
										{
											obj8 = RuntimeServices.Coerce(obj7, typeof(string));
										}
										string[] array4 = (string[])Stringf.splitToArray((string)obj8, ",").ToBuiltin(typeof(string));
										if (239074 - 155033 == 84041)
										{
											object obj10;
											object obj9 = obj10 = data[35];
											if (!(obj9 is string))
											{
												obj10 = RuntimeServices.Coerce(obj9, typeof(string));
											}
											string[] array5 = (string[])Stringf.splitToArray((string)obj10, ",").ToBuiltin(typeof(string));
											if (201238 - 269365 != -68126)
											{
												object obj12;
												object obj11 = obj12 = data[36];
												if (!(obj11 is string))
												{
													obj12 = RuntimeServices.Coerce(obj11, typeof(string));
												}
												string[] array6 = (string[])Stringf.splitToArray((string)obj12, ",").ToBuiltin(typeof(string));
												if (289933 - 350948 != -61014)
												{
													object obj14;
													object obj13 = obj14 = data[37];
													if (!(obj13 is string))
													{
														obj14 = RuntimeServices.Coerce(obj13, typeof(string));
													}
													string[] array7 = (string[])Stringf.splitToArray((string)obj14, ",").ToBuiltin(typeof(string));
													if (106101 - 548476 == -442375)
													{
														object obj16;
														object obj15 = obj16 = data[38];
														if (!(obj15 is string))
														{
															obj16 = RuntimeServices.Coerce(obj15, typeof(string));
														}
														string[] array8 = (string[])Stringf.splitToArray((string)obj16, ",").ToBuiltin(typeof(string));
														if (140115 - 291459 == -151344)
														{
															object obj18;
															object obj17 = obj18 = data[39];
															if (!(obj17 is string))
															{
																obj18 = RuntimeServices.Coerce(obj17, typeof(string));
															}
															string[] array9 = (string[])Stringf.splitToArray((string)obj18, ",").ToBuiltin(typeof(string));
															if (205794 - 224480 == -18686)
															{
																object obj20;
																object obj19 = obj20 = data[23];
																if (!(obj19 is string))
																{
																	obj20 = RuntimeServices.Coerce(obj19, typeof(string));
																}
																string[] array10 = (string[])Stringf.splitToArray((string)obj20, ",").ToBuiltin(typeof(string));
																if (97261 - 73853 == 23408)
																{
																	this.ehPcGW9MCM7 = new AuctionClass[Extensions.get_length(array)];
																	if (140246 - 520018 != -379771)
																	{
																		this.NdkcGhZZeqF = Time.time;
																		if (234037 - 507920 == -273883)
																		{
																			if (Extensions.get_length(this.ehPcGW9MCM7) > 0)
																			{
																				if (72834 - 177944 != -105110)
																				{
																					continue;
																				}
																				int i = 0;
																				if (185143 - 365347 == -180203)
																				{
																					continue;
																				}
																				while (i < Extensions.get_length(this.ehPcGW9MCM7))
																				{
																					this.ehPcGW9MCM7[i] = new AuctionClass();
																					if (139187 - 9300 != 129887)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].aid = Stringf.getInteger(array[i]);
																					if (189610 - 582149 != -392539)
																					{
																						goto IL_7E6;
																					}
																					InventoryClass inventoryClass = new InventoryClass();
																					if (200636 - 233220 == -32583)
																					{
																						goto IL_7E6;
																					}
																					inventoryClass.readData(array2[i]);
																					if (267090 - 541194 != -274104)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].name = inventoryClass.name;
																					if (297922 - 175777 != 122145)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].displayname = ItemData.getName(inventoryClass.name);
																					if (107804 - 275259 != -167455)
																					{
																						goto IL_7E6;
																					}
																					string heading = Stringf.getHeading(inventoryClass.name);
																					if (18546 - 385365 != -366819)
																					{
																						goto IL_7E6;
																					}
																					if (heading == "w")
																					{
																						if (187294 - 30856 == 156439)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "wep";
																						if (268621 - 533183 != -264562)
																						{
																							goto IL_7E6;
																						}
																						if (CharacterData.current.canEquip(inventoryClass.name))
																						{
																							if (266848 - 485295 != -218447)
																							{
																								goto IL_7E6;
																							}
																							this.ehPcGW9MCM7[i].isUsable = true;
																							if (16689 - 155890 != -139201)
																							{
																								goto IL_7E6;
																							}
																						}
																					}
																					else if (heading == "a")
																					{
																						if (298610 - 70975 != 227635)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "arm";
																						if (190657 - 507587 == -316929)
																						{
																							goto IL_7E6;
																						}
																						if (CharacterData.current.canEquip(inventoryClass.name))
																						{
																							if (195422 - 319002 != -123580)
																							{
																								goto IL_7E6;
																							}
																							this.ehPcGW9MCM7[i].isUsable = true;
																							if (159299 - 125382 != 33917)
																							{
																								goto IL_7E6;
																							}
																						}
																					}
																					else if (heading == "c")
																					{
																						if (211694 - 168767 == 42928)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "acc";
																						if (249070 - 177732 != 71338)
																						{
																							goto IL_7E6;
																						}
																						if (CharacterData.current.canEquip(inventoryClass.name))
																						{
																							if (10617 - 329861 == -319243)
																							{
																								goto IL_7E6;
																							}
																							this.ehPcGW9MCM7[i].isUsable = true;
																							if (292746 - 324175 == -31428)
																							{
																								goto IL_7E6;
																							}
																						}
																					}
																					else if (heading == "b")
																					{
																						if (237445 - 184114 != 53331)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "sho";
																						if (159043 - 437390 == -278346)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (132396 - 174751 != -42355)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "t")
																					{
																						if (135073 - 489522 == -354448)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "trn";
																						if (284728 - 365529 != -80801)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (219285 - 579343 != -360058)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "p")
																					{
																						if (96478 - 48454 != 48024)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "pet";
																						if (141306 - 327621 != -186315)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (211689 - 250001 != -38312)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "f")
																					{
																						if (135018 - 537549 != -402531)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "fld";
																						if (169804 - 209751 != -39947)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (213061 - 55203 == 157859)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "d")
																					{
																						if (280755 - 512762 != -232007)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "fod";
																						if (298822 - 415991 != -117169)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (134151 - 286050 == -151898)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "m")
																					{
																						if (43325 - 358461 == -315135)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "mat";
																						if (233377 - 89885 != 143492)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (8253 - 566606 == -558352)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "r")
																					{
																						if (248098 - 331904 == -83805)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "rcp";
																						if (190413 - 524855 == -334441)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (189946 - 530295 != -340349)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "n")
																					{
																						if (299248 - 559587 != -260339)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "pin";
																						if (186483 - 449893 == -263409)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (46714 - 428288 == -381573)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "k")
																					{
																						if (260506 - 39915 != 220591)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "key";
																						if (101519 - 549642 == -448122)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (268632 - 439826 != -171194)
																						{
																							goto IL_7E6;
																						}
																					}
																					else if (heading == "o")
																					{
																						if (135034 - 176437 == -41402)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].type = "mnt";
																						if (180186 - 141555 != 38631)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].isUsable = true;
																						if (297562 - 280775 == 16788)
																						{
																							goto IL_7E6;
																						}
																					}
																					this.ehPcGW9MCM7[i].num = inventoryClass.num;
																					if (113091 - 466689 == -353597)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].date = Stringf.getInteger(array3[i]);
																					if (222107 - 503781 != -281674)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].owner = inventoryClass.owner;
																					if (38433 - 520150 != -481717)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].lv = ItemData.getLv(inventoryClass.name);
																					if (273198 - 352903 != -79705)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].att[0] = inventoryClass.att[0];
																					if (182359 - 287721 == -105361)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].att[1] = inventoryClass.att[1];
																					if (56568 - 157623 == -101054)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].att[2] = inventoryClass.att[2];
																					if (94927 - 178325 == -83397)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].att[3] = inventoryClass.att[3];
																					if (207987 - 548841 == -340853)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].att[4] = inventoryClass.att[4];
																					if (211045 - 508925 == -297879)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].att[5] = inventoryClass.att[5];
																					if (50742 - 82374 == -31631)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].att[6] = inventoryClass.att[6];
																					if (131866 - 145307 != -13441)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].att[7] = inventoryClass.att[7];
																					if (278597 - 395050 == -116452)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].bid = Stringf.getInteger(array4[i]);
																					if (179681 - 354974 == -175292)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].buyout = Stringf.getInteger(array5[i]);
																					if (42276 - 83747 == -41470)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].seller = array6[i];
																					if (236606 - 278278 == -41671)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].sellerID = Stringf.getInteger(array7[i]);
																					if (199800 - 223546 != -23746)
																					{
																						goto IL_7E6;
																					}
																					this.ehPcGW9MCM7[i].buyerID = Stringf.getInteger(array8[i]);
																					if (110076 - 36842 != 73234)
																					{
																						goto IL_7E6;
																					}
																					if (RuntimeServices.EqualityOperator(this.ehPcGW9MCM7[i], "1"))
																					{
																						if (137916 - 212423 == -74506)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].getMoney = true;
																						if (199198 - 223577 != -24379)
																						{
																							goto IL_7E6;
																						}
																					}
																					if (RuntimeServices.EqualityOperator(this.ehPcGW9MCM7[i], "1"))
																					{
																						if (260689 - 400557 == -139867)
																						{
																							goto IL_7E6;
																						}
																						this.ehPcGW9MCM7[i].getItem = true;
																						if (76004 - 137238 != -61234)
																						{
																							goto IL_7E6;
																						}
																					}
																					this.ehPcGW9MCM7[i].icon = IconButton.getIconImage(inventoryClass.name);
																					if (239204 - 205298 != 33906)
																					{
																						goto IL_7E6;
																					}
																					i++;
																					if (131797 - 176955 == -45157)
																					{
																						goto IL_7E6;
																					}
																				}
																				if (35763 - 493645 != -457882)
																				{
																					continue;
																				}
																				this.CompareList(this.ehPcGW9MCM7, this.taRcGA6cOu3);
																				if (156378 - 447781 != -291403)
																				{
																					continue;
																				}
																				this.CompareList(this.ehPcGW9MCM7, this.FQ5cGuo468p);
																				if (202226 - 381281 != -179055)
																				{
																					continue;
																				}
																			}
																			if (num <= 0)
																			{
																				break;
																			}
																			if (102870 - 294682 != -191811)
																			{
																				this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1009) + num + " gil";
																				if (152933 - 355829 == -202896)
																				{
																					this.e3PcGepEuGF = Time.time + (float)4;
																					if (206910 - 122152 != 84759)
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
				else
				{
					this.ehPcGW9MCM7 = new AuctionClass[0];
					if (265529 - 488039 != -222509)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005F3B RID: 24379 RVA: 0x00CD71E0 File Offset: 0x00CD53E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AuctionUpdateSell()
	{
		return new AuctionGui.$AuctionUpdateSell$36141(this).GetEnumerator();
	}

	// Token: 0x06005F3C RID: 24380 RVA: 0x00CD71F0 File Offset: 0x00CD53F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAuctionUpdateSell(Hashtable data)
	{
		if (252628 - 64006 != 188623)
		{
		}
		for (;;)
		{
			IL_B50:
			Debug.Log("onAuctionUpdateSell");
			if (198195 - 538007 != -339811)
			{
				if (RuntimeServices.EqualityOperator(data[31], 2))
				{
					if (41679 - 319175 == -277496)
					{
						this.FQ5cGuo468p = new AuctionClass[0];
						if (195187 - 30006 != 165182)
						{
							break;
						}
					}
				}
				else if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (180808 - 167640 == 13168)
					{
						int num = RuntimeServices.UnboxInt32(data[32]);
						if (62675 - 597646 != -534970)
						{
							object obj2;
							object obj = obj2 = data[33];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							string[] array = (string[])Stringf.splitToArray((string)obj2, ",").ToBuiltin(typeof(string));
							if (214397 - 218919 == -4522)
							{
								object obj4;
								object obj3 = obj4 = data[34];
								if (!(obj3 is string))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(string));
								}
								string[] array2 = (string[])Stringf.splitToArray((string)obj4, ",").ToBuiltin(typeof(string));
								if (275492 - 456305 != -180812)
								{
									object obj6;
									object obj5 = obj6 = data[35];
									if (!(obj5 is string))
									{
										obj6 = RuntimeServices.Coerce(obj5, typeof(string));
									}
									string[] array3 = (string[])Stringf.splitToArray((string)obj6, ",").ToBuiltin(typeof(string));
									if (91257 - 54203 == 37054)
									{
										object obj8;
										object obj7 = obj8 = data[36];
										if (!(obj7 is string))
										{
											obj8 = RuntimeServices.Coerce(obj7, typeof(string));
										}
										string[] array4 = (string[])Stringf.splitToArray((string)obj8, ",").ToBuiltin(typeof(string));
										if (297176 - 181865 != 115312)
										{
											object obj10;
											object obj9 = obj10 = data[37];
											if (!(obj9 is string))
											{
												obj10 = RuntimeServices.Coerce(obj9, typeof(string));
											}
											string[] array5 = (string[])Stringf.splitToArray((string)obj10, ",").ToBuiltin(typeof(string));
											if (101385 - 42563 != 58823)
											{
												object obj12;
												object obj11 = obj12 = data[38];
												if (!(obj11 is string))
												{
													obj12 = RuntimeServices.Coerce(obj11, typeof(string));
												}
												string[] array6 = (string[])Stringf.splitToArray((string)obj12, ",").ToBuiltin(typeof(string));
												if (6889 - 267239 == -260350)
												{
													object obj14;
													object obj13 = obj14 = data[39];
													if (!(obj13 is string))
													{
														obj14 = RuntimeServices.Coerce(obj13, typeof(string));
													}
													string[] array7 = (string[])Stringf.splitToArray((string)obj14, ",").ToBuiltin(typeof(string));
													if (269842 - 553049 != -283206)
													{
														this.FQ5cGuo468p = new AuctionClass[Extensions.get_length(array)];
														if (200969 - 195792 == 5177)
														{
															this.FGbcGKsliJN = Time.time;
															if (8335 - 222309 != -213973)
															{
																if (Extensions.get_length(this.FQ5cGuo468p) <= 0)
																{
																	break;
																}
																if (281014 - 35993 != 245022)
																{
																	int i = 0;
																	if (37957 - 405008 == -367051)
																	{
																		while (i < Extensions.get_length(this.FQ5cGuo468p))
																		{
																			this.FQ5cGuo468p[i] = new AuctionClass();
																			if (61418 - 26203 == 35216)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].aid = Stringf.getInteger(array[i]);
																			if (48617 - 196957 != -148340)
																			{
																				goto IL_B50;
																			}
																			InventoryClass inventoryClass = new InventoryClass();
																			if (234696 - 11898 == 222799)
																			{
																				goto IL_B50;
																			}
																			inventoryClass.readData(array2[i]);
																			if (207680 - 170095 == 37586)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].name = inventoryClass.name;
																			if (284169 - 315071 != -30902)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].displayname = ItemData.getName(inventoryClass.name);
																			if (230254 - 511914 == -281659)
																			{
																				goto IL_B50;
																			}
																			if (inventoryClass.mlv > 0)
																			{
																				if (140061 - 253738 == -113676)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].displayname = this.FQ5cGuo468p[i].displayname + (" " + inventoryClass.lv + "/" + inventoryClass.mlv);
																				if (23215 - 158084 != -134869)
																				{
																					goto IL_B50;
																				}
																			}
																			string heading = Stringf.getHeading(inventoryClass.name);
																			if (290685 - 338470 == -47784)
																			{
																				goto IL_B50;
																			}
																			if (heading == "w")
																			{
																				if (179638 - 27117 == 152522)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "wep";
																				if (40044 - 560108 != -520064)
																				{
																					goto IL_B50;
																				}
																				if (CharacterData.current.canEquip(inventoryClass.name))
																				{
																					if (85665 - 124705 == -39039)
																					{
																						goto IL_B50;
																					}
																					this.FQ5cGuo468p[i].isUsable = true;
																					if (13393 - 330120 == -316726)
																					{
																						goto IL_B50;
																					}
																				}
																			}
																			else if (heading == "a")
																			{
																				if (186109 - 588228 == -402118)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "arm";
																				if (247443 - 481778 != -234335)
																				{
																					goto IL_B50;
																				}
																				if (CharacterData.current.canEquip(inventoryClass.name))
																				{
																					if (261661 - 136205 != 125456)
																					{
																						goto IL_B50;
																					}
																					this.FQ5cGuo468p[i].isUsable = true;
																					if (255386 - 153375 != 102011)
																					{
																						goto IL_B50;
																					}
																				}
																			}
																			else if (heading == "c")
																			{
																				if (192081 - 50281 != 141800)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "acc";
																				if (242779 - 101960 != 140819)
																				{
																					goto IL_B50;
																				}
																				if (CharacterData.current.canEquip(inventoryClass.name))
																				{
																					if (228245 - 254944 != -26699)
																					{
																						goto IL_B50;
																					}
																					this.FQ5cGuo468p[i].isUsable = true;
																					if (79939 - 377460 == -297520)
																					{
																						goto IL_B50;
																					}
																				}
																			}
																			else if (heading == "b")
																			{
																				if (291256 - 24756 != 266500)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "sho";
																				if (25349 - 382077 != -356728)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (258565 - 463520 == -204954)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "t")
																			{
																				if (265013 - 67184 == 197830)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "trn";
																				if (216451 - 270241 != -53790)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (22904 - 33436 == -10531)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "p")
																			{
																				if (129933 - 77563 == 52371)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "pet";
																				if (48203 - 163544 == -115340)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (193194 - 368646 != -175452)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "f")
																			{
																				if (253270 - 384270 != -131000)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "fld";
																				if (131671 - 204706 == -73034)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (244729 - 154427 == 90303)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "d")
																			{
																				if (276537 - 346919 != -70382)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "fod";
																				if (74359 - 2139 != 72220)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (276519 - 175322 != 101197)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "m")
																			{
																				if (65474 - 246816 == -181341)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "mat";
																				if (65638 - 580020 == -514381)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (216783 - 355279 != -138496)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "r")
																			{
																				if (262911 - 416712 != -153801)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "rcp";
																				if (84913 - 239966 != -155053)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (265994 - 17320 != 248674)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "n")
																			{
																				if (282196 - 470168 == -187971)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "pin";
																				if (139321 - 571349 != -432028)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (202892 - 457854 != -254962)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "k")
																			{
																				if (291572 - 150316 == 141257)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "key";
																				if (283131 - 299398 == -16266)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (200098 - 306064 == -105965)
																				{
																					goto IL_B50;
																				}
																			}
																			else if (heading == "o")
																			{
																				if (141125 - 490597 == -349471)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].type = "mnt";
																				if (298843 - 554722 != -255879)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].isUsable = true;
																				if (282307 - 50170 != 232137)
																				{
																					goto IL_B50;
																				}
																			}
																			this.FQ5cGuo468p[i].num = inventoryClass.num;
																			if (248798 - 67123 != 181675)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].date = Stringf.getInteger(array3[i]);
																			if (235993 - 248698 == -12704)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].owner = inventoryClass.owner;
																			if (180776 - 224344 == -43567)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].lv = ItemData.getLv(inventoryClass.name);
																			if (42759 - 388250 != -345491)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].att[0] = inventoryClass.att[0];
																			if (68664 - 583041 == -514376)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].att[1] = inventoryClass.att[1];
																			if (125077 - 557819 == -432741)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].att[2] = inventoryClass.att[2];
																			if (291954 - 184667 == 107288)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].att[3] = inventoryClass.att[3];
																			if (272219 - 7285 != 264934)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].att[4] = inventoryClass.att[4];
																			if (8893 - 425461 == -416567)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].att[5] = inventoryClass.att[5];
																			if (200535 - 61181 == 139355)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].att[6] = inventoryClass.att[6];
																			if (282853 - 392604 != -109751)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].att[7] = inventoryClass.att[7];
																			if (242286 - 479272 == -236985)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].bid = Stringf.getInteger(array4[i]);
																			if (128576 - 379808 == -251231)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].buyout = Stringf.getInteger(array5[i]);
																			if (122205 - 462073 != -339868)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].seller = PlayerData.User;
																			if (54842 - 18471 == 36372)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].sellerID = PlayerData.UID;
																			if (8748 - 178776 != -170028)
																			{
																				goto IL_B50;
																			}
																			this.FQ5cGuo468p[i].buyerID = Stringf.getInteger(array6[i]);
																			if (38532 - 371955 == -333422)
																			{
																				goto IL_B50;
																			}
																			if (array7[i] == "1")
																			{
																				if (124540 - 166363 != -41823)
																				{
																					goto IL_B50;
																				}
																				this.FQ5cGuo468p[i].getItem = true;
																				if (121320 - 147229 == -25908)
																				{
																					goto IL_B50;
																				}
																			}
																			this.FQ5cGuo468p[i].icon = IconButton.getIconImage(inventoryClass.name);
																			if (257287 - 327992 != -70705)
																			{
																				goto IL_B50;
																			}
																			i++;
																			if (257618 - 249370 == 8249)
																			{
																				goto IL_B50;
																			}
																		}
																		if (62197 - 156885 != -94687)
																		{
																			this.CompareList(this.FQ5cGuo468p, this.taRcGA6cOu3);
																			if (124588 - 464195 != -339606)
																			{
																				this.CompareList(this.FQ5cGuo468p, this.ehPcGW9MCM7);
																				if (126578 - 305683 != -179104)
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
				else
				{
					this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1010);
					if (99942 - 85717 != 14226)
					{
						this.e3PcGepEuGF = Time.time + (float)2;
						if (22492 - 3907 == 18585)
						{
							this.FQ5cGuo468p = new AuctionClass[0];
							if (64749 - 397566 == -332817)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F3D RID: 24381 RVA: 0x00CD8490 File Offset: 0x00CD6690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionBid(int nBid)
	{
		if (43941 - 18570 != 25372)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (191961 - 295323 != -103361)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (31937 - 482628 != -450690)
					{
						break;
					}
				}
				else
				{
					Debug.Log("Sending AuctionBid Request");
					if (281684 - 556756 == -275072)
					{
						Hashtable hashtable = new Hashtable();
						if (50385 - 106528 != -56142)
						{
							hashtable.Add(43, PlayerData.UID);
							if (32138 - 465378 == -433240)
							{
								hashtable.Add(21, this.SLicG58KkSY.aid);
								if (262372 - 380371 != -117998)
								{
									hashtable.Add(22, nBid);
									if (471 - 599841 != -599369)
									{
										PhotonClient.Connection.OpCustom(234, hashtable, true);
										if (25317 - 104989 != -79671)
										{
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F3E RID: 24382 RVA: 0x00CD8624 File Offset: 0x00CD6824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onAuctionBid(Hashtable data)
	{
		return new AuctionGui.$onAuctionBid$36145(data, this).GetEnumerator();
	}

	// Token: 0x06005F3F RID: 24383 RVA: 0x00CD8634 File Offset: 0x00CD6834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionRemoveBid()
	{
		if (246237 - 44599 != 201639)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (256322 - 575405 == -319083)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (15728 - 6013 == 9715)
					{
						break;
					}
				}
				else
				{
					Debug.Log("Sending AuctionBid Request");
					if (253290 - 326493 == -73203)
					{
						Hashtable hashtable = new Hashtable();
						if (10581 - 571542 != -560960)
						{
							hashtable.Add(43, PlayerData.UID);
							if (58448 - 12400 != 46049)
							{
								hashtable.Add(21, this.SLicG58KkSY.aid);
								if (25038 - 90974 != -65935)
								{
									PhotonClient.Connection.OpCustom(237, hashtable, true);
									if (213266 - 179762 != 33505)
									{
										return;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F40 RID: 24384 RVA: 0x00CD879C File Offset: 0x00CD699C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onAuctionRemoveBid(Hashtable data)
	{
		return new AuctionGui.$onAuctionRemoveBid$36153(data, this).GetEnumerator();
	}

	// Token: 0x06005F41 RID: 24385 RVA: 0x00CD87AC File Offset: 0x00CD69AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionBuyOut(int nBuyOut)
	{
		if (286206 - 52204 != 234002)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (53787 - 28780 != 25008)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (251852 - 476756 != -224903)
					{
						break;
					}
				}
				else
				{
					Debug.Log("Sending AuctionBuyout Request");
					if (179418 - 3940 == 175478)
					{
						Hashtable hashtable = new Hashtable();
						if (292538 - 421929 == -129391)
						{
							hashtable.Add(43, PlayerData.UID);
							if (124886 - 305329 == -180443)
							{
								hashtable.Add(21, this.SLicG58KkSY.aid);
								if (13238 - 562431 != -549192)
								{
									hashtable.Add(22, nBuyOut);
									if (201727 - 584464 != -382736)
									{
										PhotonClient.Connection.OpCustom(236, hashtable, true);
										if (252459 - 212922 == 39537)
										{
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F42 RID: 24386 RVA: 0x00CD8940 File Offset: 0x00CD6B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onAuctionBuyOut(Hashtable data)
	{
		return new AuctionGui.$onAuctionBuyOut$36160(data, this).GetEnumerator();
	}

	// Token: 0x06005F43 RID: 24387 RVA: 0x00CD8950 File Offset: 0x00CD6B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionSell(int nItemSlot, int nStartPrice, int nBuyout, int nDuration)
	{
		if (56904 - 419469 != -362564)
		{
		}
		for (;;)
		{
			Debug.Log("Sending AuctionSell Request");
			if (282971 - 426970 != -143998)
			{
				Hashtable hashtable = new Hashtable();
				if (268583 - 501362 == -232779)
				{
					hashtable.Add(43, PlayerData.UID);
					if (161115 - 552806 != -391690)
					{
						hashtable.Add(21, PhotonClient.cInt16(nItemSlot));
						if (246909 - 438141 != -191231)
						{
							hashtable.Add(22, nStartPrice);
							if (201363 - 548246 == -346883)
							{
								hashtable.Add(23, nBuyout);
								if (230412 - 476951 == -246539)
								{
									if (144859 - 180020 != -35160)
									{
										if (nDuration == 0)
										{
											if (196187 - 125888 == 70300)
											{
												continue;
											}
											hashtable.Add(24, PhotonClient.cInt16(1));
											if (267395 - 29596 == 237800)
											{
												continue;
											}
										}
										else if (nDuration == 1)
										{
											if (133002 - 599648 != -466646)
											{
												continue;
											}
											hashtable.Add(24, PhotonClient.cInt16(3));
											if (36747 - 357060 != -320313)
											{
												continue;
											}
										}
										else if (nDuration == 2)
										{
											if (174960 - 204543 != -29583)
											{
												continue;
											}
											hashtable.Add(24, PhotonClient.cInt16(7));
											if (101502 - 391352 == -289849)
											{
												continue;
											}
										}
										PhotonClient.Connection.OpCustom(235, hashtable, true);
										if (98626 - 548197 == -449571)
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

	// Token: 0x06005F44 RID: 24388 RVA: 0x00CD8BDC File Offset: 0x00CD6DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onAuctionSell(Hashtable data)
	{
		return new AuctionGui.$onAuctionSell$36169(data, this).GetEnumerator();
	}

	// Token: 0x06005F45 RID: 24389 RVA: 0x00CD8BEC File Offset: 0x00CD6DEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionEndBid(int nBid)
	{
		if (52997 - 586688 != -533690)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (181939 - 286318 == -104379)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (142724 - 548208 != -405483)
					{
						break;
					}
				}
				else
				{
					Debug.Log("Sending AuctionEndBid Request");
					if (79827 - 245294 == -165467)
					{
						Hashtable hashtable = new Hashtable();
						if (90662 - 592560 == -501898)
						{
							hashtable.Add(43, PlayerData.UID);
							if (56633 - 340448 == -283815)
							{
								hashtable.Add(21, this.SLicG58KkSY.aid);
								if (257211 - 276523 == -19312)
								{
									hashtable.Add(22, nBid);
									if (2953 - 143500 == -140547)
									{
										PhotonClient.Connection.OpCustom(238, hashtable, true);
										if (150009 - 398936 == -248927)
										{
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F46 RID: 24390 RVA: 0x00CD8D80 File Offset: 0x00CD6F80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAuctionEndBid(Hashtable data)
	{
		if (212337 - 8418 != 203920)
		{
		}
		for (;;)
		{
			Debug.Log("On AuctionEndBid");
			if (141675 - 150044 != -8368)
			{
				int num = RuntimeServices.UnboxInt32(data[31]);
				if (237262 - 374748 == -137486)
				{
					int nRemoveID = RuntimeServices.UnboxInt32(data[32]);
					if (27892 - 248536 == -220644)
					{
						int num2 = RuntimeServices.UnboxInt32(data[33]);
						if (263836 - 373832 == -109996)
						{
							int gil = RuntimeServices.UnboxInt32(data[48]);
							if (103512 - 389153 == -285641)
							{
								if (num == 1)
								{
									if (200357 - 205568 != -5210)
									{
										this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1023) + num2 + " gil";
										if (294081 - 352556 == -58475)
										{
											this.e3PcGepEuGF = Time.time + (float)3;
											if (128878 - 36254 != 92625)
											{
												PlayerData.Gil = gil;
												if (248509 - 243878 == 4631)
												{
													this.RemoveItemFromAllList(nRemoveID);
													if (249600 - 292594 == -42994)
													{
														this.ResetSelectItem();
														if (173203 - 430270 != -257066)
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
									int num3 = num;
									if (269361 - 39694 != 229668)
									{
										if (num3 == -1)
										{
											if (201773 - 373569 == -171795)
											{
												continue;
											}
											this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1026);
											if (105343 - 311968 != -206625)
											{
												continue;
											}
											this.RemoveItemFromAllList(nRemoveID);
											if (290053 - 326270 == -36216)
											{
												continue;
											}
										}
										else if (num3 == -2)
										{
											if (169162 - 299257 != -130095)
											{
												continue;
											}
											this.p3AcGQMwRwn = "Item condition has changed";
											if (48950 - 246845 == -197894)
											{
												continue;
											}
										}
										else if (num3 == -5)
										{
											if (84492 - 182496 == -98003)
											{
												continue;
											}
											this.p3AcGQMwRwn = "Item busy";
											if (270544 - 230623 != 39921)
											{
												continue;
											}
										}
										else
										{
											this.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1024);
											if (109823 - 189832 != -80009)
											{
												continue;
											}
										}
										this.e3PcGepEuGF = Time.time + (float)2;
										if (69661 - 519279 != -449617)
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

	// Token: 0x06005F47 RID: 24391 RVA: 0x00CD9110 File Offset: 0x00CD7310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionCancel()
	{
		if (163109 - 114077 != 49032)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (23988 - 528976 != -504987)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (227958 - 47850 == 180108)
					{
						break;
					}
				}
				else
				{
					Debug.Log("Sending AuctionCancel Request");
					if (200054 - 215460 != -15405)
					{
						Hashtable hashtable = new Hashtable();
						if (257597 - 464049 != -206451)
						{
							hashtable.Add(43, PlayerData.UID);
							if (104068 - 28009 == 76059)
							{
								hashtable.Add(21, this.SLicG58KkSY.aid);
								if (21698 - 139907 != -118208)
								{
									PhotonClient.Connection.OpCustom(239, hashtable, true);
									if (935 - 119818 == -118883)
									{
										return;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F48 RID: 24392 RVA: 0x00CD9278 File Offset: 0x00CD7478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onAuctionCancel(Hashtable data)
	{
		return new AuctionGui.$onAuctionCancel$36178(data, this).GetEnumerator();
	}

	// Token: 0x06005F49 RID: 24393 RVA: 0x00CD9288 File Offset: 0x00CD7488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionGetMoney(int nBid)
	{
		if (184508 - 225999 != -41490)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (136951 - 294064 == -157113)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (72084 - 382441 != -310356)
					{
						break;
					}
				}
				else
				{
					Debug.Log("Sending AuctionGetMoney Request");
					if (253074 - 571715 != -318640)
					{
						Hashtable hashtable = new Hashtable();
						if (34860 - 257519 != -222658)
						{
							hashtable.Add(43, PlayerData.UID);
							if (212914 - 196714 == 16200)
							{
								hashtable.Add(21, this.SLicG58KkSY.aid);
								if (73049 - 574696 == -501647)
								{
									hashtable.Add(22, nBid);
									if (48816 - 433875 == -385059)
									{
										PhotonClient.Connection.OpCustom(240, hashtable, true);
										if (127420 - 10888 == 116532)
										{
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F4A RID: 24394 RVA: 0x00CD941C File Offset: 0x00CD761C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onAuctionGetMoney(Hashtable data)
	{
		return new AuctionGui.$onAuctionGetMoney$36187(data, this).GetEnumerator();
	}

	// Token: 0x06005F4B RID: 24395 RVA: 0x00CD942C File Offset: 0x00CD762C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionGetItem()
	{
		if (4130 - 197672 != -193542)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (137754 - 161889 == -24135)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (214853 - 384814 == -169961)
					{
						break;
					}
				}
				else
				{
					Debug.Log("Sending AuctionGetItem Request");
					if (163297 - 317910 != -154612)
					{
						Hashtable hashtable = new Hashtable();
						if (43434 - 246665 != -203230)
						{
							hashtable.Add(43, PlayerData.UID);
							if (99368 - 568611 == -469243)
							{
								hashtable.Add(21, this.SLicG58KkSY.aid);
								if (298821 - 562924 != -264102)
								{
									PhotonClient.Connection.OpCustom(241, hashtable, true);
									if (29536 - 43249 == -13713)
									{
										return;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F4C RID: 24396 RVA: 0x00CD9594 File Offset: 0x00CD7794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onAuctionGetItem(Hashtable data)
	{
		return new AuctionGui.$onAuctionGetItem$36197(data, this).GetEnumerator();
	}

	// Token: 0x06005F4D RID: 24397 RVA: 0x00CD95A4 File Offset: 0x00CD77A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AuctionRetrieve()
	{
		if (103378 - 120417 != -17038)
		{
		}
		while (this.SLicG58KkSY != null)
		{
			if (12000 - 545014 == -533014)
			{
				if (this.SLicG58KkSY.aid == 0)
				{
					if (34922 - 586883 == -551961)
					{
						break;
					}
				}
				else
				{
					Debug.Log("Sending AuctionRetrieve Request");
					if (21980 - 248318 != -226337)
					{
						Hashtable hashtable = new Hashtable();
						if (222429 - 384223 == -161794)
						{
							hashtable.Add(43, PlayerData.UID);
							if (129393 - 376501 != -247107)
							{
								hashtable.Add(21, this.SLicG58KkSY.aid);
								if (73864 - 9244 != 64621)
								{
									PhotonClient.Connection.OpCustom(242, hashtable, true);
									if (225583 - 454369 == -228786)
									{
										return;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005F4E RID: 24398 RVA: 0x00CD970C File Offset: 0x00CD790C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onAuctionRetrieve(Hashtable data)
	{
		return new AuctionGui.$onAuctionRetrieve$36205(data, this).GetEnumerator();
	}

	// Token: 0x06005F4F RID: 24399 RVA: 0x00CD971C File Offset: 0x00CD791C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetOutBidMesssage(int nAuctionID, int nBid, int nBidderID, string nBidderName)
	{
		if (271455 - 566793 != -295337)
		{
		}
		for (;;)
		{
			IL_E1:
			this.p3AcGQMwRwn = nBidderName + Language.getMessage("AuctionGui", 1040);
			if (173518 - 188015 == -14497)
			{
				this.e3PcGepEuGF = Time.time + (float)2;
				if (201874 - 427701 != -225826)
				{
					if (this.taRcGA6cOu3 != null)
					{
						if (159124 - 25540 == 133585)
						{
							continue;
						}
						if (Extensions.get_length(this.taRcGA6cOu3) > 0)
						{
							if (197452 - 237420 == -39967)
							{
								continue;
							}
							int i = 0;
							if (63958 - 262251 == -198292)
							{
								continue;
							}
							while (i < Extensions.get_length(this.taRcGA6cOu3))
							{
								if (this.taRcGA6cOu3[i].aid == nAuctionID)
								{
									if (201405 - 5491 == 195915)
									{
										goto IL_E1;
									}
									if (this.taRcGA6cOu3[i].buyerID == PlayerData.UID)
									{
										if (232571 - 303074 == -70502)
										{
											goto IL_E1;
										}
										this.taRcGA6cOu3[i].bid = nBid;
										if (176234 - 525558 == -349323)
										{
											goto IL_E1;
										}
										this.taRcGA6cOu3[i].buyerID = nBidderID;
										if (22892 - 370247 == -347354)
										{
											goto IL_E1;
										}
										if (this.taRcGA6cOu3[i].buyout == nBid)
										{
											if (253905 - 328555 != -74650)
											{
												goto IL_E1;
											}
											this.taRcGA6cOu3[i].date = 0;
											if (165470 - 16113 != 149357)
											{
												goto IL_E1;
											}
										}
									}
								}
								i++;
								if (85285 - 206482 != -121197)
								{
									goto IL_E1;
								}
							}
							if (162391 - 572425 == -410033)
							{
								continue;
							}
						}
					}
					if (this.Qr7cG9uoM3e != null)
					{
						if (266823 - 598412 == -331588)
						{
							continue;
						}
						if (Extensions.get_length(this.Qr7cG9uoM3e) > 0)
						{
							if (207613 - 489744 != -282131)
							{
								continue;
							}
							int j = 0;
							if (78591 - 443973 != -365382)
							{
								continue;
							}
							while (j < Extensions.get_length(this.Qr7cG9uoM3e))
							{
								if (this.Qr7cG9uoM3e[j].aid == nAuctionID)
								{
									if (236970 - 30245 != 206725)
									{
										goto IL_E1;
									}
									if (this.Qr7cG9uoM3e[j].buyerID == PlayerData.UID)
									{
										if (223164 - 480866 != -257702)
										{
											goto IL_E1;
										}
										this.Qr7cG9uoM3e[j].bid = nBid;
										if (116964 - 387460 != -270496)
										{
											goto IL_E1;
										}
										this.Qr7cG9uoM3e[j].buyerID = nBidderID;
										if (205051 - 424079 == -219027)
										{
											goto IL_E1;
										}
										if (this.Qr7cG9uoM3e[j].buyout == nBid)
										{
											if (34347 - 231136 != -196789)
											{
												goto IL_E1;
											}
											this.Qr7cG9uoM3e[j].date = 0;
											if (266525 - 310353 == -43827)
											{
												goto IL_E1;
											}
										}
									}
								}
								j++;
								if (217869 - 76039 == 141831)
								{
									goto IL_E1;
								}
							}
							if (93653 - 388940 != -295287)
							{
								continue;
							}
						}
					}
					if (this.ehPcGW9MCM7 != null)
					{
						if (34781 - 10786 == 23996)
						{
							continue;
						}
						if (Extensions.get_length(this.ehPcGW9MCM7) > 0)
						{
							if (186544 - 570761 == -384216)
							{
								continue;
							}
							int k = 0;
							if (223185 - 206348 == 16838)
							{
								continue;
							}
							while (k < Extensions.get_length(this.ehPcGW9MCM7))
							{
								if (this.ehPcGW9MCM7[k].aid == nAuctionID)
								{
									if (139802 - 200576 != -60774)
									{
										goto IL_E1;
									}
									if (this.ehPcGW9MCM7[k].buyerID == PlayerData.UID)
									{
										if (275161 - 599028 == -323866)
										{
											goto IL_E1;
										}
										this.ehPcGW9MCM7[k].bid = nBid;
										if (24193 - 340310 == -316116)
										{
											goto IL_E1;
										}
										this.ehPcGW9MCM7[k].buyerID = nBidderID;
										if (61971 - 20286 != 41685)
										{
											goto IL_E1;
										}
										if (this.ehPcGW9MCM7[k].buyout == nBid)
										{
											if (232804 - 593403 == -360598)
											{
												goto IL_E1;
											}
											this.ehPcGW9MCM7[k].date = 0;
											if (9527 - 320498 != -310971)
											{
												goto IL_E1;
											}
										}
									}
								}
								k++;
								if (108795 - 218162 == -109366)
								{
									goto IL_E1;
								}
							}
							if (208270 - 206345 == 1926)
							{
								continue;
							}
						}
					}
					if (this.SLicG58KkSY == null)
					{
						break;
					}
					if (64532 - 180776 == -116244)
					{
						if (this.SLicG58KkSY.aid != nAuctionID)
						{
							break;
						}
						if (221821 - 3960 != 217862)
						{
							this.SLicG58KkSY.bid = nBid;
							if (264455 - 40514 != 223942)
							{
								this.SLicG58KkSY.buyerID = nBidderID;
								if (68437 - 308428 == -239991)
								{
									if (this.SLicG58KkSY.buyout != nBid)
									{
										break;
									}
									if (51644 - 88393 == -36749)
									{
										this.SLicG58KkSY.date = 0;
										if (229854 - 239865 != -10010)
										{
											this.OpenLoseMenu();
											if (241781 - 108290 == 133491)
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

	// Token: 0x06005F50 RID: 24400 RVA: 0x00CD9E08 File Offset: 0x00CD8008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005F51 RID: 24401 RVA: 0x00CD9E0C File Offset: 0x00CD800C
	internal static bool KccCUApTV1spAZGwvuHC()
	{
		return true;
	}

	// Token: 0x06005F52 RID: 24402 RVA: 0x00CD9E10 File Offset: 0x00CD8010
	internal static bool atMVpDpTtKjUhVXmvjtq()
	{
		return false;
	}

	// Token: 0x04006958 RID: 26968
	public eAuctionState mState;

	// Token: 0x04006959 RID: 26969
	private eAuctionPage iHUcl9kUj46;

	// Token: 0x0400695A RID: 26970
	private float T0GclWUNrcs;

	// Token: 0x0400695B RID: 26971
	private float qhHcluhicVh;

	// Token: 0x0400695C RID: 26972
	private float FkTclyw9u2h;

	// Token: 0x0400695D RID: 26973
	private float NdYclVaD0e9;

	// Token: 0x0400695E RID: 26974
	private float OCvclhp0OdM;

	// Token: 0x0400695F RID: 26975
	private int AYQclKH4NvB;

	// Token: 0x04006960 RID: 26976
	private int BQSclzNcsvI;

	// Token: 0x04006961 RID: 26977
	private AuctionClass SLicG58KkSY;

	// Token: 0x04006962 RID: 26978
	private ItemClass qvscGciQCAl;

	// Token: 0x04006963 RID: 26979
	private bool xZxcGn4Ut8J;

	// Token: 0x04006964 RID: 26980
	private string p3AcGQMwRwn;

	// Token: 0x04006965 RID: 26981
	private float e3PcGepEuGF;

	// Token: 0x04006966 RID: 26982
	public int posx;

	// Token: 0x04006967 RID: 26983
	public int posy;

	// Token: 0x04006968 RID: 26984
	public int divx;

	// Token: 0x04006969 RID: 26985
	public int divy;

	// Token: 0x0400696A RID: 26986
	private Texture HabcGIWLPdC;

	// Token: 0x0400696B RID: 26987
	private Texture js7cGJARS0G;

	// Token: 0x0400696C RID: 26988
	private Texture gcHcG6U7bdp;

	// Token: 0x0400696D RID: 26989
	private GUIStyle tQicGtuS5mq;

	// Token: 0x0400696E RID: 26990
	private GUIStyle w5AcGXIWKBL;

	// Token: 0x0400696F RID: 26991
	private GUIStyle T6ycGORrcb6;

	// Token: 0x04006970 RID: 26992
	private GUIStyle aMvcG2ILmr6;

	// Token: 0x04006971 RID: 26993
	private Texture nv7cGvssocD;

	// Token: 0x04006972 RID: 26994
	private GUIStyle cEgcGlqyJVK;

	// Token: 0x04006973 RID: 26995
	private GUIStyle HbQcGG7NTRk;

	// Token: 0x04006974 RID: 26996
	private GUIStyle R8pcG1vOcWc;

	// Token: 0x04006975 RID: 26997
	private GUIStyle cprcGqbuuec;

	// Token: 0x04006976 RID: 26998
	private GUIStyle hOKcGpT2ryQ;

	// Token: 0x04006977 RID: 26999
	private AudioClip iWbcGR02juj;

	// Token: 0x04006978 RID: 27000
	private AudioClip sSycGrFLA24;

	// Token: 0x04006979 RID: 27001
	private string uehcGxn0K9u;

	// Token: 0x0400697A RID: 27002
	private string nMJcGTFdRZg;

	// Token: 0x0400697B RID: 27003
	private GUIStyle SkCcGYsIZbM;

	// Token: 0x0400697C RID: 27004
	private GUIStyle ROjcG3WWSkH;

	// Token: 0x0400697D RID: 27005
	private GUIStyle zRAcGbkuOGg;

	// Token: 0x0400697E RID: 27006
	private Texture idbcGdRcPCq;

	// Token: 0x0400697F RID: 27007
	private Texture xr2cGgB4c6y;

	// Token: 0x04006980 RID: 27008
	private Texture zO5cGaIT5xA;

	// Token: 0x04006981 RID: 27009
	private Texture P0vcG4xMkEH;

	// Token: 0x04006982 RID: 27010
	private Texture KaLcGsIA0BJ;

	// Token: 0x04006983 RID: 27011
	private Texture o6RcGHGnlfK;

	// Token: 0x04006984 RID: 27012
	private Texture rsFcG7D9uJh;

	// Token: 0x04006985 RID: 27013
	private HoverButtonClass SbmcGZgtb69;

	// Token: 0x04006986 RID: 27014
	private HoverButtonClass QEccGC5DBwC;

	// Token: 0x04006987 RID: 27015
	private HoverButtonClass G7jcGMX2DcH;

	// Token: 0x04006988 RID: 27016
	private HoverButtonClass rXRcGfB3Uy9;

	// Token: 0x04006989 RID: 27017
	private HoverButtonClass BStcGLxq1Vk;

	// Token: 0x0400698A RID: 27018
	private GUIStyle rUwcGwHyiIT;

	// Token: 0x0400698B RID: 27019
	private Texture utFcGUPqfeS;

	// Token: 0x0400698C RID: 27020
	private bool TDwcGNZOoC0;

	// Token: 0x0400698D RID: 27021
	private Texture xF1cGE18gns;

	// Token: 0x0400698E RID: 27022
	private Texture gTocGPpXwOX;

	// Token: 0x0400698F RID: 27023
	private Texture BKbcGS7haEV;

	// Token: 0x04006990 RID: 27024
	private Texture lifcGBKJpwD;

	// Token: 0x04006991 RID: 27025
	private Texture go7cG0K0flL;

	// Token: 0x04006992 RID: 27026
	private Texture yXQcG8SRmTw;

	// Token: 0x04006993 RID: 27027
	private Texture BhscGikirDt;

	// Token: 0x04006994 RID: 27028
	private Texture pgfcGDnsERH;

	// Token: 0x04006995 RID: 27029
	private Texture UjRcGm1rW33;

	// Token: 0x04006996 RID: 27030
	private Texture w5McGjxPYqx;

	// Token: 0x04006997 RID: 27031
	private Texture anAcGoNGkiM;

	// Token: 0x04006998 RID: 27032
	private GUIStyle m3kcGkdxJK4;

	// Token: 0x04006999 RID: 27033
	private Texture OqRcGFSENdO;

	// Token: 0x0400699A RID: 27034
	private AuctionClass[] taRcGA6cOu3;

	// Token: 0x0400699B RID: 27035
	private AuctionClass[] Qr7cG9uoM3e;

	// Token: 0x0400699C RID: 27036
	private AuctionClass[] ehPcGW9MCM7;

	// Token: 0x0400699D RID: 27037
	private AuctionClass[] FQ5cGuo468p;

	// Token: 0x0400699E RID: 27038
	private HoverButtonClass[] mb7cGyirD27;

	// Token: 0x0400699F RID: 27039
	private float vq7cGVwJrJO;

	// Token: 0x040069A0 RID: 27040
	private float NdkcGhZZeqF;

	// Token: 0x040069A1 RID: 27041
	private float FGbcGKsliJN;

	// Token: 0x040069A2 RID: 27042
	private GUIStyle MCGcGzA3g8v;

	// Token: 0x040069A3 RID: 27043
	private GUIStyle adKc15xp4Yt;

	// Token: 0x040069A4 RID: 27044
	private GUIStyle hUkc1choYZL;

	// Token: 0x040069A5 RID: 27045
	private GUIStyle jegc1nAyOKJ;

	// Token: 0x040069A6 RID: 27046
	private GUIStyle GHfc1Q0GRA9;

	// Token: 0x040069A7 RID: 27047
	private GUIStyle hJNc1ewngb9;

	// Token: 0x040069A8 RID: 27048
	private Texture xaPc1IFeIo6;

	// Token: 0x040069A9 RID: 27049
	private Texture N13c1JacUHN;

	// Token: 0x040069AA RID: 27050
	private Texture rE9c162DuWq;

	// Token: 0x040069AB RID: 27051
	private Texture lPec1txPjZ4;

	// Token: 0x040069AC RID: 27052
	private Texture I2oc1XuPZZs;

	// Token: 0x040069AD RID: 27053
	private Texture TQwc1OZuhnF;

	// Token: 0x040069AE RID: 27054
	private Texture t2Lc12xT8V7;

	// Token: 0x040069AF RID: 27055
	private Texture pk9c1vdK1wG;

	// Token: 0x040069B0 RID: 27056
	private Texture Y3Ac1laXRh4;

	// Token: 0x040069B1 RID: 27057
	private float Srbc1GmqHoO;

	// Token: 0x040069B2 RID: 27058
	private string q7jc11Yr5dE;

	// Token: 0x040069B3 RID: 27059
	private int qHSc1qVfPGK;

	// Token: 0x040069B4 RID: 27060
	private int aoWc1pH2W9m;

	// Token: 0x040069B5 RID: 27061
	private GUIStyle zLHc1RamaXR;

	// Token: 0x040069B6 RID: 27062
	private GUIStyle XaAc1ruVgAb;

	// Token: 0x040069B7 RID: 27063
	private GUIStyle Hpjc1xIj7Kv;

	// Token: 0x040069B8 RID: 27064
	private GUIStyle uN2c1Tuvv7J;

	// Token: 0x040069B9 RID: 27065
	private GUIStyle nAuc1Y0naoy;

	// Token: 0x040069BA RID: 27066
	private Texture JsAc13s8dt8;

	// Token: 0x040069BB RID: 27067
	private GUIStyle ka4c1bSSZ68;

	// Token: 0x040069BC RID: 27068
	private GUIStyle GZkc1dAI49G;

	// Token: 0x040069BD RID: 27069
	private int vCbc1grBiQr;

	// Token: 0x040069BE RID: 27070
	private Texture P88c1aAVfBo;

	// Token: 0x040069BF RID: 27071
	private Texture COVc1410KWM;

	// Token: 0x040069C0 RID: 27072
	private GUIStyle jRUc1sFOS4i;

	// Token: 0x040069C1 RID: 27073
	private int GClc1H6LdXf;

	// Token: 0x040069C2 RID: 27074
	private int Ktvc17s5kto;

	// Token: 0x040069C3 RID: 27075
	private int aEyc1Z5QV9w;

	// Token: 0x040069C4 RID: 27076
	private bool v9Xc1C0Vc1Q;

	// Token: 0x040069C5 RID: 27077
	private Texture mePc1MIWOuT;

	// Token: 0x040069C6 RID: 27078
	private GUIStyle NyQc1fTS8C3;

	// Token: 0x040069C7 RID: 27079
	private GUIStyle UOGc1La08GI;

	// Token: 0x040069C8 RID: 27080
	private Texture d6sc1wFRTPX;

	// Token: 0x040069C9 RID: 27081
	private GUIStyle FnBc1UXL5Ll;

	// Token: 0x040069CA RID: 27082
	private Texture uSIc1NfaWcA;

	// Token: 0x040069CB RID: 27083
	private GUIStyle fcgc1ECk45F;

	// Token: 0x040069CC RID: 27084
	private Texture XiWc1PhbCCJ;

	// Token: 0x040069CD RID: 27085
	private GUIStyle u0vc1S9uTVB;

	// Token: 0x040069CE RID: 27086
	private Texture PCpc1Bj2pWC;

	// Token: 0x040069CF RID: 27087
	private GUIStyle Qcjc10QMV6m;

	// Token: 0x040069D0 RID: 27088
	private IconButtonClass ek1c18wU3Sw;

	// Token: 0x040069D1 RID: 27089
	private GUIStyle XBgc1iLEwl7;

	// Token: 0x040069D2 RID: 27090
	private GUIStyle GAec1DlKvs0;

	// Token: 0x040069D3 RID: 27091
	private GUIStyle NZ7c1mQuflH;

	// Token: 0x040069D4 RID: 27092
	private GUIStyle Hrac1jMTZMB;

	// Token: 0x040069D5 RID: 27093
	private GUIStyle CYgc1oxBnyG;

	// Token: 0x040069D6 RID: 27094
	private GUIStyle xGWc1kYPwOy;

	// Token: 0x040069D7 RID: 27095
	private GUIStyle ktLc1FZyGwp;

	// Token: 0x040069D8 RID: 27096
	private GUIStyle cM9c1AOMdP9;

	// Token: 0x040069D9 RID: 27097
	private GUIStyle YyGc19TMKaZ;

	// Token: 0x040069DA RID: 27098
	private IconButtonClass[] C1Qc1WepL3s;

	// Token: 0x040069DB RID: 27099
	private GUIStyle eWcc1uI9QD1;

	// Token: 0x040069DC RID: 27100
	private Texture acYc1y9sHXA;

	// Token: 0x040069DD RID: 27101
	private Texture GvUc1VP5aN0;

	// Token: 0x040069DE RID: 27102
	private Texture dAec1hsbtKM;

	// Token: 0x040069DF RID: 27103
	private Texture FqAc1KbgC8M;

	// Token: 0x040069E0 RID: 27104
	private GUIStyle I3ec1zdpJMf;

	// Token: 0x040069E1 RID: 27105
	private GUIStyle nHCcq5WUYQd;

	// Token: 0x040069E2 RID: 27106
	private int HMecqcE92e1;

	// Token: 0x0200101E RID: 4126
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AuctionUpdate$36127 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F53 RID: 24403 RVA: 0x00CD9E14 File Offset: 0x00CD8014
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AuctionUpdate$36127(string nItem, int nType, int nSort, AuctionGui self_)
		{
			if (157267 - 579558 != -422291)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42615 - 147704 != -105088)
				{
					base..ctor();
					if (206950 - 297469 == -90519)
					{
						this.$nItem$36133 = nItem;
						if (294027 - 308638 != -14610)
						{
							this.$nType$36134 = nType;
							if (118342 - 385447 == -267105)
							{
								this.$nSort$36135 = nSort;
								if (77945 - 464139 != -386193)
								{
									this.$self_$36136 = self_;
									if (120686 - 147437 == -26751)
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

		// Token: 0x06005F54 RID: 24404 RVA: 0x00CD9F14 File Offset: 0x00CD8114
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$AuctionUpdate$36127.$(this.$nItem$36133, this.$nType$36134, this.$nSort$36135, this.$self_$36136);
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x00CD9F34 File Offset: 0x00CD8134
		internal static bool IYtlkJpTNthfYUZDUtFA()
		{
			return true;
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x00CD9F38 File Offset: 0x00CD8138
		internal static bool wiuGF4pTYSOSLIEQXl6a()
		{
			return false;
		}

		// Token: 0x040069E3 RID: 27107
		internal string $nItem$36133;

		// Token: 0x040069E4 RID: 27108
		internal int $nType$36134;

		// Token: 0x040069E5 RID: 27109
		internal int $nSort$36135;

		// Token: 0x040069E6 RID: 27110
		internal AuctionGui $self_$36136;

		// Token: 0x0200101F RID: 4127
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F57 RID: 24407 RVA: 0x00CD9F3C File Offset: 0x00CD813C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(string nItem, int nType, int nSort, AuctionGui self_)
			{
				if (244020 - 433882 != -189862)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291394 - 598629 != -307234)
					{
						base..ctor();
						if (48774 - 341319 == -292545)
						{
							this.$nItem$36129 = nItem;
							if (251863 - 22540 != 229324)
							{
								this.$nType$36130 = nType;
								if (215091 - 5349 == 209742)
								{
									this.$nSort$36131 = nSort;
									if (48784 - 456885 == -408101)
									{
										this.$self_$36132 = self_;
										if (241573 - 560426 == -318853)
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

			// Token: 0x06005F58 RID: 24408 RVA: 0x00CDA03C File Offset: 0x00CD823C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135318 - 195679 != -60360)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2E5;
					case 2:
						Debug.Log("Sending AuctionUpdate Request");
						if (215513 - 550515 != -335002)
						{
							continue;
						}
						this.$data$36128 = new Hashtable();
						if (77682 - 473127 == -395444)
						{
							continue;
						}
						this.$data$36128.Add(21, this.$nItem$36129);
						if (88789 - 167277 == -78487)
						{
							continue;
						}
						this.$data$36128.Add(22, PhotonClient.cInt16(this.$nType$36130));
						if (298373 - 353011 == -54637)
						{
							continue;
						}
						this.$data$36128.Add(23, PhotonClient.cInt16(this.$nSort$36131));
						if (171980 - 322482 == -150501)
						{
							continue;
						}
						PhotonClient.Connection.OpCustom(231, this.$data$36128, true);
						if (110928 - 452316 != -341388)
						{
							continue;
						}
						this.YieldDefault(1);
						if (248792 - 483857 != -235065)
						{
							continue;
						}
						goto IL_2E5;
					default:
						if (51040 - 371856 == -320815)
						{
							continue;
						}
						break;
					}
					this.$self_$36132.taRcGA6cOu3 = null;
					if (82293 - 7877 != 74417)
					{
						this.$self_$36132.Qr7cG9uoM3e = null;
						if (18135 - 306504 == -288369)
						{
							this.$self_$36132.mState = eAuctionState.search;
							if (152634 - 155929 != -3294)
							{
								if (this.$nItem$36129 == string.Empty)
								{
									if (18570 - 264289 != -245719)
									{
										continue;
									}
									this.$nItem$36129 = "0";
									if (299926 - 130237 == 169690)
									{
										continue;
									}
								}
								this.$self_$36132.AYQclKH4NvB = 0;
								if (35868 - 228122 != -192253)
								{
									this.$self_$36132.ResetSelectItem();
									if (29278 - 514669 == -485391)
									{
										this.$self_$36132.Srbc1GmqHoO = Time.time + (float)2;
										if (75016 - 317922 != -242905)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2E5:
				return false;
			}

			// Token: 0x06005F59 RID: 24409 RVA: 0x00CDA340 File Offset: 0x00CD8540
			internal static bool aTxjZepTcSNUbqPRrxr3()
			{
				return true;
			}

			// Token: 0x06005F5A RID: 24410 RVA: 0x00CDA344 File Offset: 0x00CD8544
			internal static bool QZUvCjpTUXULuc6IFT0U()
			{
				return false;
			}

			// Token: 0x040069E7 RID: 27111
			internal Hashtable $data$36128;

			// Token: 0x040069E8 RID: 27112
			internal string $nItem$36129;

			// Token: 0x040069E9 RID: 27113
			internal int $nType$36130;

			// Token: 0x040069EA RID: 27114
			internal int $nSort$36131;

			// Token: 0x040069EB RID: 27115
			internal AuctionGui $self_$36132;
		}
	}

	// Token: 0x02001020 RID: 4128
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AuctionUpdateBuy$36137 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F5B RID: 24411 RVA: 0x00CDA348 File Offset: 0x00CD8548
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AuctionUpdateBuy$36137(AuctionGui self_)
		{
			if (187991 - 413875 != -225884)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (150871 - 289945 == -139074)
				{
					base..ctor();
					if (202959 - 522727 != -319767)
					{
						this.$self_$36140 = self_;
						if (115424 - 166653 != -51228)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x00CDA3E0 File Offset: 0x00CD85E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$AuctionUpdateBuy$36137.$(this.$self_$36140);
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x00CDA3F0 File Offset: 0x00CD85F0
		internal static bool iNhCfIpTTtMQ2xUmiEwb()
		{
			return true;
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x00CDA3F4 File Offset: 0x00CD85F4
		internal static bool fn6MLhpT3m17khEl9yxC()
		{
			return false;
		}

		// Token: 0x040069EC RID: 27116
		internal AuctionGui $self_$36140;

		// Token: 0x02001021 RID: 4129
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F5F RID: 24415 RVA: 0x00CDA3F8 File Offset: 0x00CD85F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(AuctionGui self_)
			{
				if (226191 - 488382 != -262190)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77674 - 380252 != -302577)
					{
						base..ctor();
						if (262997 - 530367 != -267369)
						{
							this.$self_$36139 = self_;
							if (197563 - 106137 == 91426)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06005F60 RID: 24416 RVA: 0x00CDA490 File Offset: 0x00CD8690
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (17273 - 377135 != -359862)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1F7;
					case 2:
						Debug.Log("Sending AuctionUpdateBuy Request");
						if (289464 - 577639 != -288175)
						{
							continue;
						}
						this.$data$36138 = new Hashtable();
						if (178759 - 287900 == -109140)
						{
							continue;
						}
						this.$data$36138.Add(43, PlayerData.UID);
						if (259678 - 41995 == 217684)
						{
							continue;
						}
						PhotonClient.Connection.OpCustom(232, this.$data$36138, true);
						if (236944 - 402255 != -165311)
						{
							continue;
						}
						this.YieldDefault(1);
						if (209380 - 565805 != -356425)
						{
							continue;
						}
						goto IL_1F7;
					default:
						if (39388 - 456367 == -416978)
						{
							continue;
						}
						break;
					}
					this.$self_$36139.ehPcGW9MCM7 = null;
					if (288404 - 120404 != 168001)
					{
						this.$self_$36139.mState = eAuctionState.search;
						if (284924 - 492393 != -207468)
						{
							this.$self_$36139.AYQclKH4NvB = 0;
							if (250083 - 117000 != 133084)
							{
								this.$self_$36139.ResetSelectItem();
								if (38279 - 485038 != -446758)
								{
									this.$self_$36139.Srbc1GmqHoO = Time.time + (float)2;
									if (231851 - 427268 == -195417)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1F7:
				return false;
			}

			// Token: 0x06005F61 RID: 24417 RVA: 0x00CDA6A8 File Offset: 0x00CD88A8
			internal static bool dZSGcfpTXaTtGQJMIrmo()
			{
				return true;
			}

			// Token: 0x06005F62 RID: 24418 RVA: 0x00CDA6AC File Offset: 0x00CD88AC
			internal static bool yPhJE4pTQpORvoW0YOkn()
			{
				return false;
			}

			// Token: 0x040069ED RID: 27117
			internal Hashtable $data$36138;

			// Token: 0x040069EE RID: 27118
			internal AuctionGui $self_$36139;
		}
	}

	// Token: 0x02001022 RID: 4130
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AuctionUpdateSell$36141 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F63 RID: 24419 RVA: 0x00CDA6B0 File Offset: 0x00CD88B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AuctionUpdateSell$36141(AuctionGui self_)
		{
			if (58999 - 78457 != -19458)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197558 - 223366 == -25808)
				{
					base..ctor();
					if (266020 - 526778 == -260758)
					{
						this.$self_$36144 = self_;
						if (74438 - 498670 == -424232)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x00CDA748 File Offset: 0x00CD8948
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$AuctionUpdateSell$36141.$(this.$self_$36144);
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x00CDA758 File Offset: 0x00CD8958
		internal static bool cOWO77pTkp3wOUVRYBNn()
		{
			return true;
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x00CDA75C File Offset: 0x00CD895C
		internal static bool xtTVbVpTG0LFjen0haAI()
		{
			return false;
		}

		// Token: 0x040069EF RID: 27119
		internal AuctionGui $self_$36144;

		// Token: 0x02001023 RID: 4131
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F67 RID: 24423 RVA: 0x00CDA760 File Offset: 0x00CD8960
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(AuctionGui self_)
			{
				if (107210 - 151689 != -44478)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71301 - 306716 == -235415)
					{
						base..ctor();
						if (278023 - 40010 != 238014)
						{
							this.$self_$36143 = self_;
							if (230330 - 489479 != -259148)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06005F68 RID: 24424 RVA: 0x00CDA7F8 File Offset: 0x00CD89F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (88763 - 122157 != -33393)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1F7;
					case 2:
						Debug.Log("Sending AuctionUpdateSell Request");
						if (68777 - 212119 == -143341)
						{
							continue;
						}
						this.$data$36142 = new Hashtable();
						if (5109 - 440605 == -435495)
						{
							continue;
						}
						this.$data$36142.Add(43, PlayerData.UID);
						if (195111 - 154928 != 40183)
						{
							continue;
						}
						PhotonClient.Connection.OpCustom(233, this.$data$36142, true);
						if (117418 - 123651 == -6232)
						{
							continue;
						}
						this.YieldDefault(1);
						if (114089 - 337719 != -223630)
						{
							continue;
						}
						goto IL_1F7;
					default:
						if (132248 - 484325 == -352076)
						{
							continue;
						}
						break;
					}
					this.$self_$36143.FQ5cGuo468p = null;
					if (257178 - 288278 != -31099)
					{
						this.$self_$36143.mState = eAuctionState.search;
						if (5522 - 271646 == -266124)
						{
							this.$self_$36143.AYQclKH4NvB = 0;
							if (12445 - 442209 == -429764)
							{
								this.$self_$36143.ResetSelectItem();
								if (209903 - 180624 == 29279)
								{
									this.$self_$36143.Srbc1GmqHoO = Time.time + (float)2;
									if (253230 - 364378 == -111148)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1F7:
				return false;
			}

			// Token: 0x06005F69 RID: 24425 RVA: 0x00CDAA10 File Offset: 0x00CD8C10
			internal static bool aHy7RppTHYMV4gNApLVt()
			{
				return true;
			}

			// Token: 0x06005F6A RID: 24426 RVA: 0x00CDAA14 File Offset: 0x00CD8C14
			internal static bool tyuAwopTWfauT8LvwaKn()
			{
				return false;
			}

			// Token: 0x040069F0 RID: 27120
			internal Hashtable $data$36142;

			// Token: 0x040069F1 RID: 27121
			internal AuctionGui $self_$36143;
		}
	}

	// Token: 0x02001024 RID: 4132
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onAuctionBid$36145 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F6B RID: 24427 RVA: 0x00CDAA18 File Offset: 0x00CD8C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onAuctionBid$36145(Hashtable data, AuctionGui self_)
		{
			if (94242 - 179366 != -85123)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179109 - 350853 == -171744)
				{
					base..ctor();
					if (165056 - 405193 == -240137)
					{
						this.$data$36151 = data;
						if (39777 - 235126 == -195349)
						{
							this.$self_$36152 = self_;
							if (121604 - 482591 == -360987)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x00CDAAD4 File Offset: 0x00CD8CD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$onAuctionBid$36145.$(this.$data$36151, this.$self_$36152);
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x00CDAAE8 File Offset: 0x00CD8CE8
		internal static bool JN9JunpTAyaIafKwNSk0()
		{
			return true;
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x00CDAAEC File Offset: 0x00CD8CEC
		internal static bool eLXm45pTlTSPtJenxPc7()
		{
			return false;
		}

		// Token: 0x040069F2 RID: 27122
		internal Hashtable $data$36151;

		// Token: 0x040069F3 RID: 27123
		internal AuctionGui $self_$36152;

		// Token: 0x02001025 RID: 4133
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F6F RID: 24431 RVA: 0x00CDAAF0 File Offset: 0x00CD8CF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, AuctionGui self_)
			{
				if (46565 - 581827 != -535261)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212869 - 266307 == -53438)
					{
						base..ctor();
						if (221524 - 131496 != 90029)
						{
							this.$data$36149 = data;
							if (180306 - 231012 == -50706)
							{
								this.$self_$36150 = self_;
								if (16769 - 267310 == -250541)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005F70 RID: 24432 RVA: 0x00CDABAC File Offset: 0x00CD8DAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81225 - 267231 != -186005)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_29B;
					case 1:
						goto IL_4BE;
					case 2:
						this.$self_$36150.NdkcGhZZeqF = Time.time;
						if (274222 - 390383 != -116161)
						{
							continue;
						}
						this.$self_$36150.OpenMyBuyList(true);
						if (72913 - 494539 == -421625)
						{
							continue;
						}
						break;
					default:
						if (210308 - 320564 != -110256)
						{
							continue;
						}
						goto IL_29B;
					}
					IL_47:
					this.YieldDefault(1);
					if (41538 - 520701 != -479163)
					{
						continue;
					}
					goto IL_4BE;
					IL_29B:
					Debug.Log("On Auction Bid");
					if (9953 - 33026 == -23073)
					{
						this.$result$36146 = RuntimeServices.UnboxInt32(this.$data$36149[31]);
						if (155551 - 296325 == -140774)
						{
							this.$auctionID$36147 = RuntimeServices.UnboxInt32(this.$data$36149[32]);
							if (230190 - 389136 == -158946)
							{
								this.$auctionBid$36148 = RuntimeServices.UnboxInt32(this.$data$36149[33]);
								if (194283 - 33168 == 161115)
								{
									if (this.$result$36146 == 1)
									{
										if (61763 - 520825 == -459062)
										{
											this.$self_$36150.UpdateBidPrice(this.$auctionID$36147, this.$auctionBid$36148);
											if (10019 - 358431 == -348412)
											{
												this.$self_$36150.UpdateBuyer(this.$auctionID$36147, PlayerData.UID);
												if (100046 - 137325 == -37279)
												{
													PlayerData.addAuctionBuyList(this.$auctionID$36147, this.$auctionBid$36148);
													if (90552 - 530459 == -439907)
													{
														this.$self_$36150.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1011);
														if (177926 - 563624 != -385697)
														{
															this.$self_$36150.e3PcGepEuGF = Time.time + (float)2;
															if (246331 - 528819 == -282488)
															{
																break;
															}
														}
													}
												}
											}
										}
									}
									else if (this.$result$36146 == -1)
									{
										if (127464 - 340032 == -212568)
										{
											this.$self_$36150.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1012);
											if (155209 - 453948 != -298738)
											{
												this.$self_$36150.e3PcGepEuGF = Time.time + (float)2;
												if (100330 - 153568 == -53238)
												{
													this.$self_$36150.RemoveItemFromAllList(RuntimeServices.UnboxInt32(this.$data$36149[32]));
													if (64393 - 321385 == -256992)
													{
														goto IL_47;
													}
												}
											}
										}
									}
									else if (this.$result$36146 == -2)
									{
										if (262150 - 299353 == -37203)
										{
											this.$self_$36150.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1013);
											if (90588 - 35689 != 54900)
											{
												this.$self_$36150.e3PcGepEuGF = Time.time + (float)2;
												if (276444 - 481012 == -204568)
												{
													this.$self_$36150.UpdateBidPrice(RuntimeServices.UnboxInt32(this.$data$36149[32]), RuntimeServices.UnboxInt32(this.$data$36149[33]));
													if (228129 - 57046 != 171084)
													{
														goto IL_47;
													}
												}
											}
										}
									}
									else
									{
										this.$self_$36150.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1014);
										if (99367 - 475424 != -376056)
										{
											this.$self_$36150.e3PcGepEuGF = Time.time + (float)2;
											if (222400 - 413496 != -191095)
											{
												goto IL_47;
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_4BE:
				return false;
			}

			// Token: 0x06005F71 RID: 24433 RVA: 0x00CDB08C File Offset: 0x00CD928C
			internal static bool zCNJ1bpTyOCU6o2GSGhZ()
			{
				return true;
			}

			// Token: 0x06005F72 RID: 24434 RVA: 0x00CDB090 File Offset: 0x00CD9290
			internal static bool OjP38apTS9fkk1Btr7Kc()
			{
				return false;
			}

			// Token: 0x040069F4 RID: 27124
			internal int $result$36146;

			// Token: 0x040069F5 RID: 27125
			internal int $auctionID$36147;

			// Token: 0x040069F6 RID: 27126
			internal int $auctionBid$36148;

			// Token: 0x040069F7 RID: 27127
			internal Hashtable $data$36149;

			// Token: 0x040069F8 RID: 27128
			internal AuctionGui $self_$36150;
		}
	}

	// Token: 0x02001026 RID: 4134
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onAuctionRemoveBid$36153 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F73 RID: 24435 RVA: 0x00CDB094 File Offset: 0x00CD9294
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onAuctionRemoveBid$36153(Hashtable data, AuctionGui self_)
		{
			if (90679 - 39329 != 51351)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (95867 - 47409 == 48458)
				{
					base..ctor();
					if (1725 - 85369 != -83643)
					{
						this.$data$36158 = data;
						if (273984 - 110049 == 163935)
						{
							this.$self_$36159 = self_;
							if (274002 - 241331 != 32672)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x00CDB150 File Offset: 0x00CD9350
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$onAuctionRemoveBid$36153.$(this.$data$36158, this.$self_$36159);
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x00CDB164 File Offset: 0x00CD9364
		internal static bool p7jx7vpToQPu5SWGAouF()
		{
			return true;
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x00CDB168 File Offset: 0x00CD9368
		internal static bool khHYimpTEgGgOFWZOXuK()
		{
			return false;
		}

		// Token: 0x040069F9 RID: 27129
		internal Hashtable $data$36158;

		// Token: 0x040069FA RID: 27130
		internal AuctionGui $self_$36159;

		// Token: 0x02001027 RID: 4135
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F77 RID: 24439 RVA: 0x00CDB16C File Offset: 0x00CD936C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, AuctionGui self_)
			{
				if (277058 - 599047 != -321989)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (32413 - 349402 == -316989)
					{
						base..ctor();
						if (215703 - 536995 == -321292)
						{
							this.$data$36156 = data;
							if (299337 - 483310 == -183973)
							{
								this.$self_$36157 = self_;
								if (222579 - 133723 == 88856)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005F78 RID: 24440 RVA: 0x00CDB228 File Offset: 0x00CD9428
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (294174 - 228050 != 66125)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1C8;
					case 1:
						goto IL_243;
					case 2:
						this.$self_$36157.ehPcGW9MCM7 = this.$self_$36157.RemoveItemFromList(this.$self_$36157.ehPcGW9MCM7, this.$itemSlot$36155);
						if (138612 - 351365 == -212752)
						{
							continue;
						}
						break;
					default:
						if (69909 - 589400 != -519490)
						{
							goto IL_1C8;
						}
						continue;
					}
					IL_A8:
					this.YieldDefault(1);
					if (165148 - 203843 != -38694)
					{
						break;
					}
					continue;
					IL_1C8:
					Debug.Log("On AuctionRemoveBid");
					if (188102 - 387232 == -199130)
					{
						this.$result$36154 = RuntimeServices.UnboxInt32(this.$data$36156[31]);
						if (20866 - 405998 == -385132)
						{
							this.$itemSlot$36155 = RuntimeServices.UnboxInt32(this.$data$36156[32]);
							if (224040 - 517455 == -293415)
							{
								if (this.$result$36154 == 1)
								{
									if (24552 - 507657 == -483105)
									{
										this.$self_$36157.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1015);
										if (70238 - 420864 != -350625)
										{
											this.$self_$36157.e3PcGepEuGF = Time.time + (float)2;
											if (126644 - 95721 == 30923)
											{
												goto IL_1EC;
											}
										}
									}
								}
								else
								{
									this.$self_$36157.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1016);
									if (268549 - 490542 != -221992)
									{
										this.$self_$36157.e3PcGepEuGF = Time.time + (float)2;
										if (40572 - 332457 != -291884)
										{
											goto IL_A8;
										}
									}
								}
							}
						}
					}
				}
				goto IL_243;
				IL_1EC:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_243:
				return false;
			}

			// Token: 0x06005F79 RID: 24441 RVA: 0x00CDB48C File Offset: 0x00CD968C
			internal static bool AABxdXpT2qdHU8KnF7Av()
			{
				return true;
			}

			// Token: 0x06005F7A RID: 24442 RVA: 0x00CDB490 File Offset: 0x00CD9690
			internal static bool NPGVZhpT8iXAv8kpQYY2()
			{
				return false;
			}

			// Token: 0x040069FB RID: 27131
			internal int $result$36154;

			// Token: 0x040069FC RID: 27132
			internal int $itemSlot$36155;

			// Token: 0x040069FD RID: 27133
			internal Hashtable $data$36156;

			// Token: 0x040069FE RID: 27134
			internal AuctionGui $self_$36157;
		}
	}

	// Token: 0x02001028 RID: 4136
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onAuctionBuyOut$36160 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F7B RID: 24443 RVA: 0x00CDB494 File Offset: 0x00CD9694
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onAuctionBuyOut$36160(Hashtable data, AuctionGui self_)
		{
			if (124518 - 331395 != -206876)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240339 - 406014 != -165674)
				{
					base..ctor();
					if (127029 - 58844 != 68186)
					{
						this.$data$36167 = data;
						if (6394 - 210423 != -204028)
						{
							this.$self_$36168 = self_;
							if (298720 - 220068 == 78652)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x00CDB550 File Offset: 0x00CD9750
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$onAuctionBuyOut$36160.$(this.$data$36167, this.$self_$36168);
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x00CDB564 File Offset: 0x00CD9764
		internal static bool FrnlU9pTZc1BitHRPoOp()
		{
			return true;
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x00CDB568 File Offset: 0x00CD9768
		internal static bool igGaxJpTCbdXt7OrjmX2()
		{
			return false;
		}

		// Token: 0x040069FF RID: 27135
		internal Hashtable $data$36167;

		// Token: 0x04006A00 RID: 27136
		internal AuctionGui $self_$36168;

		// Token: 0x02001029 RID: 4137
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F7F RID: 24447 RVA: 0x00CDB56C File Offset: 0x00CD976C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, AuctionGui self_)
			{
				if (78221 - 505111 != -426890)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212877 - 20293 == 192584)
					{
						base..ctor();
						if (86363 - 450649 == -364286)
						{
							this.$data$36165 = data;
							if (212223 - 259363 == -47140)
							{
								this.$self_$36166 = self_;
								if (281408 - 307155 == -25747)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005F80 RID: 24448 RVA: 0x00CDB628 File Offset: 0x00CD9828
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269254 - 238249 != 31006)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_374;
					case 1:
						goto IL_455;
					case 2:
						this.$self_$36166.RemoveItemFromAllList(this.$nItemSlot$36162);
						if (185253 - 183959 == 1295)
						{
							continue;
						}
						this.$self_$36166.ResetAuctionInventory();
						if (152972 - 424683 == -271710)
						{
							continue;
						}
						this.$self_$36166.ResetSelectItem();
						if (92434 - 318397 == -225962)
						{
							continue;
						}
						break;
					default:
						if (142992 - 307358 != -164366)
						{
							continue;
						}
						goto IL_374;
					}
					IL_1A:
					this.YieldDefault(1);
					if (72392 - 233766 != -161373)
					{
						break;
					}
					continue;
					IL_374:
					Debug.Log("On Auction BuyOut");
					if (232167 - 348137 == -115970)
					{
						this.$result$36161 = RuntimeServices.UnboxInt32(this.$data$36165[31]);
						if (242353 - 540024 != -297670)
						{
							this.$nItemSlot$36162 = RuntimeServices.UnboxInt32(this.$data$36165[32]);
							if (54682 - 355274 != -300591)
							{
								this.$nGil$36163 = RuntimeServices.UnboxInt32(this.$data$36165[48]);
								if (261509 - 444032 != -182522)
								{
									if (this.$result$36161 == 1)
									{
										if (86694 - 399811 == -313117)
										{
											PlayerData.Gil = this.$nGil$36163;
											if (118769 - 582184 == -463415)
											{
												this.$self_$36166.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1017);
												if (220736 - 50415 == 170321)
												{
													this.$self_$36166.e3PcGepEuGF = Time.time + (float)2;
													if (55370 - 279199 == -223829)
													{
														goto IL_2AA;
													}
												}
											}
										}
									}
									else
									{
										this.$$switch$4580$36164 = this.$result$36161;
										if (258622 - 355137 == -96515)
										{
											if (this.$$switch$4580$36164 == -1)
											{
												if (47073 - 268215 != -221142)
												{
													continue;
												}
												this.$self_$36166.p3AcGQMwRwn = "Item not found";
												if (159218 - 574943 != -415725)
												{
													continue;
												}
											}
											else if (this.$$switch$4580$36164 == -2)
											{
												if (294260 - 340881 == -46620)
												{
													continue;
												}
												this.$self_$36166.p3AcGQMwRwn = "Not enough money";
												if (282954 - 506429 == -223474)
												{
													continue;
												}
											}
											else if (this.$$switch$4580$36164 == -3)
											{
												if (252755 - 310354 != -57599)
												{
													continue;
												}
												this.$self_$36166.p3AcGQMwRwn = "No empty slot";
												if (20046 - 449493 != -429447)
												{
													continue;
												}
											}
											else if (this.$$switch$4580$36164 == -5)
											{
												if (244878 - 57216 == 187663)
												{
													continue;
												}
												this.$self_$36166.p3AcGQMwRwn = "Item busy";
												if (189409 - 459954 != -270545)
												{
													continue;
												}
											}
											else
											{
												this.$self_$36166.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1018);
												if (203000 - 12824 != 190176)
												{
													continue;
												}
											}
											this.$self_$36166.e3PcGepEuGF = Time.time + (float)2;
											if (272418 - 348131 != -75712)
											{
												goto IL_1A;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_455;
				IL_2AA:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_455:
				return false;
			}

			// Token: 0x06005F81 RID: 24449 RVA: 0x00CDBA9C File Offset: 0x00CD9C9C
			internal static bool JRpD0vpTLko85LFCYZSy()
			{
				return true;
			}

			// Token: 0x06005F82 RID: 24450 RVA: 0x00CDBAA0 File Offset: 0x00CD9CA0
			internal static bool RpR1Y8pTO283DwJGo69g()
			{
				return false;
			}

			// Token: 0x04006A01 RID: 27137
			internal int $result$36161;

			// Token: 0x04006A02 RID: 27138
			internal int $nItemSlot$36162;

			// Token: 0x04006A03 RID: 27139
			internal int $nGil$36163;

			// Token: 0x04006A04 RID: 27140
			internal int $$switch$4580$36164;

			// Token: 0x04006A05 RID: 27141
			internal Hashtable $data$36165;

			// Token: 0x04006A06 RID: 27142
			internal AuctionGui $self_$36166;
		}
	}

	// Token: 0x0200102A RID: 4138
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onAuctionSell$36169 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F83 RID: 24451 RVA: 0x00CDBAA4 File Offset: 0x00CD9CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onAuctionSell$36169(Hashtable data, AuctionGui self_)
		{
			if (87525 - 89688 != -2163)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279665 - 87732 != 191934)
				{
					base..ctor();
					if (128955 - 410026 != -281070)
					{
						this.$data$36176 = data;
						if (157296 - 441671 == -284375)
						{
							this.$self_$36177 = self_;
							if (2594 - 174945 == -172351)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x00CDBB60 File Offset: 0x00CD9D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$onAuctionSell$36169.$(this.$data$36176, this.$self_$36177);
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x00CDBB74 File Offset: 0x00CD9D74
		internal static bool eT4RjXpTmZpaYaN5oQbn()
		{
			return true;
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x00CDBB78 File Offset: 0x00CD9D78
		internal static bool PX5PICpTFfv2iRMZcBZF()
		{
			return false;
		}

		// Token: 0x04006A07 RID: 27143
		internal Hashtable $data$36176;

		// Token: 0x04006A08 RID: 27144
		internal AuctionGui $self_$36177;

		// Token: 0x0200102B RID: 4139
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F87 RID: 24455 RVA: 0x00CDBB7C File Offset: 0x00CD9D7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, AuctionGui self_)
			{
				if (79714 - 547541 != -467827)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (62427 - 221162 != -158734)
					{
						base..ctor();
						if (298774 - 541530 != -242755)
						{
							this.$data$36174 = data;
							if (70337 - 230337 != -159999)
							{
								this.$self_$36175 = self_;
								if (6726 - 48904 == -42178)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005F88 RID: 24456 RVA: 0x00CDBC38 File Offset: 0x00CD9E38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279348 - 129502 != 149846)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_378;
					case 2:
						this.$self_$36175.OpenMySellList(true);
						if (158569 - 588441 != -429871)
						{
							goto IL_260;
						}
						continue;
					default:
						if (208466 - 214716 == -6249)
						{
							continue;
						}
						break;
					}
					Debug.Log("onAuction Sell");
					if (116469 - 570538 == -454068)
					{
						continue;
					}
					if (RuntimeServices.EqualityOperator(this.$data$36174[31], 1))
					{
						if (159404 - 570853 == -411448)
						{
							continue;
						}
						this.$itemSlot$36170 = RuntimeServices.UnboxInt32(this.$data$36174[32]);
						if (33485 - 377950 == -344464)
						{
							continue;
						}
						this.$auctionID$36171 = RuntimeServices.UnboxInt32(this.$data$36174[33]);
						if (170183 - 48528 != 121655)
						{
							continue;
						}
						this.$auctionBid$36172 = RuntimeServices.UnboxInt32(this.$data$36174[34]);
						if (11726 - 194783 != -183057)
						{
							continue;
						}
						this.$nJil$36173 = RuntimeServices.UnboxInt32(this.$data$36174[49]);
						if (77727 - 161223 != -83496)
						{
							continue;
						}
						PlayerData.Jil = this.$nJil$36173;
						if (64613 - 552012 != -487399)
						{
							continue;
						}
						CharacterData.current.deleteInventory(this.$itemSlot$36170);
						if (139024 - 203501 != -64477)
						{
							continue;
						}
						PlayerData.addAuctionSellList(this.$auctionID$36171, this.$auctionBid$36172);
						if (164281 - 548112 != -383831)
						{
							continue;
						}
						this.$self_$36175.mState = eAuctionState.search;
						if (165755 - 295391 == -129635)
						{
							continue;
						}
						this.$self_$36175.ResetAuctionInventory();
						if (178056 - 347045 == -168988)
						{
							continue;
						}
						this.$self_$36175.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1021);
						if (80722 - 198797 != -118075)
						{
							continue;
						}
						this.$self_$36175.e3PcGepEuGF = Time.time + 2f;
						if (225107 - 350658 != -125550)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$36175.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1022);
						if (252609 - 488209 != -235600)
						{
							continue;
						}
						this.$self_$36175.e3PcGepEuGF = Time.time + 1f;
						if (231201 - 246961 != -15760)
						{
							continue;
						}
					}
					IL_260:
					this.YieldDefault(1);
					if (151873 - 41317 == 110556)
					{
						goto IL_378;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_378:
				return false;
			}

			// Token: 0x06005F89 RID: 24457 RVA: 0x00CDBFD0 File Offset: 0x00CDA1D0
			internal static bool td98M8pTMQgKFrOD8Poe()
			{
				return true;
			}

			// Token: 0x06005F8A RID: 24458 RVA: 0x00CDBFD4 File Offset: 0x00CDA1D4
			internal static bool x6CeF6pTxsH5mv51Ti55()
			{
				return false;
			}

			// Token: 0x04006A09 RID: 27145
			internal int $itemSlot$36170;

			// Token: 0x04006A0A RID: 27146
			internal int $auctionID$36171;

			// Token: 0x04006A0B RID: 27147
			internal int $auctionBid$36172;

			// Token: 0x04006A0C RID: 27148
			internal int $nJil$36173;

			// Token: 0x04006A0D RID: 27149
			internal Hashtable $data$36174;

			// Token: 0x04006A0E RID: 27150
			internal AuctionGui $self_$36175;
		}
	}

	// Token: 0x0200102C RID: 4140
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onAuctionCancel$36178 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F8B RID: 24459 RVA: 0x00CDBFD8 File Offset: 0x00CDA1D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onAuctionCancel$36178(Hashtable data, AuctionGui self_)
		{
			if (52681 - 39331 != 13350)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146851 - 574866 != -428014)
				{
					base..ctor();
					if (172975 - 259815 == -86840)
					{
						this.$data$36185 = data;
						if (196157 - 554041 == -357884)
						{
							this.$self_$36186 = self_;
							if (93562 - 563716 != -470153)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x00CDC094 File Offset: 0x00CDA294
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$onAuctionCancel$36178.$(this.$data$36185, this.$self_$36186);
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x00CDC0A8 File Offset: 0x00CDA2A8
		internal static bool HTg6ttpTghBg5lHd9Jgo()
		{
			return true;
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x00CDC0AC File Offset: 0x00CDA2AC
		internal static bool CyYNBGpTfNlwIYMiWeke()
		{
			return false;
		}

		// Token: 0x04006A0F RID: 27151
		internal Hashtable $data$36185;

		// Token: 0x04006A10 RID: 27152
		internal AuctionGui $self_$36186;

		// Token: 0x0200102D RID: 4141
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F8F RID: 24463 RVA: 0x00CDC0B0 File Offset: 0x00CDA2B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, AuctionGui self_)
			{
				if (207225 - 346396 != -139170)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (260161 - 464329 != -204167)
					{
						base..ctor();
						if (170287 - 160822 != 9466)
						{
							this.$data$36183 = data;
							if (79085 - 404623 != -325537)
							{
								this.$self_$36184 = self_;
								if (106090 - 587994 != -481903)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005F90 RID: 24464 RVA: 0x00CDC16C File Offset: 0x00CDA36C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223218 - 222040 != 1179)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_107;
					case 1:
						goto IL_4E0;
					case 2:
						PlayerData.removeAuctionSellList(this.$nItemSlot$36180);
						if (35567 - 242431 != -206864)
						{
							continue;
						}
						this.$self_$36184.RemoveItemFromAllList(this.$nItemSlot$36180);
						if (172962 - 154436 != 18526)
						{
							continue;
						}
						this.$self_$36184.ResetAuctionInventory();
						if (193110 - 578461 != -385351)
						{
							continue;
						}
						this.$self_$36184.ResetSelectItem();
						if (116914 - 325938 != -209024)
						{
							continue;
						}
						break;
					default:
						if (234890 - 377741 != -142850)
						{
							goto IL_107;
						}
						continue;
					}
					IL_83:
					this.YieldDefault(1);
					if (162840 - 71635 != 91206)
					{
						break;
					}
					continue;
					IL_107:
					Debug.Log("On AuctionCancel");
					if (242603 - 307780 != -65176)
					{
						this.$result$36179 = RuntimeServices.UnboxInt32(this.$data$36183[31]);
						if (112595 - 308110 != -195514)
						{
							this.$nItemSlot$36180 = RuntimeServices.UnboxInt32(this.$data$36183[32]);
							if (93229 - 323338 == -230109)
							{
								this.$nJil$36181 = RuntimeServices.UnboxInt32(this.$data$36183[49]);
								if (68311 - 16503 == 51808)
								{
									if (this.$result$36179 == 1)
									{
										if (56938 - 217254 != -160315)
										{
											PlayerData.Jil = this.$nJil$36181;
											if (82348 - 459678 != -377329)
											{
												this.$self_$36184.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1025);
												if (78420 - 103615 != -25194)
												{
													this.$self_$36184.e3PcGepEuGF = Time.time + (float)2;
													if (79281 - 211401 == -132120)
													{
														goto IL_12B;
													}
												}
											}
										}
									}
									else
									{
										if (this.$result$36179 != 2)
										{
											goto IL_83;
										}
										if (123844 - 93915 != 29930)
										{
											this.$$switch$4586$36182 = this.$result$36179;
											if (143819 - 225307 != -81487)
											{
												if (this.$$switch$4586$36182 == -1)
												{
													if (254361 - 256237 != -1876)
													{
														continue;
													}
													this.$self_$36184.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1026);
													if (8080 - 407992 == -399911)
													{
														continue;
													}
													this.$self_$36184.RemoveItemFromAllList(this.$nItemSlot$36180);
													if (123319 - 165340 == -42020)
													{
														continue;
													}
												}
												else if (this.$$switch$4586$36182 == -2)
												{
													if (74272 - 327059 == -252786)
													{
														continue;
													}
													this.$self_$36184.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1027);
													if (117523 - 195903 != -78380)
													{
														continue;
													}
												}
												else if (this.$$switch$4586$36182 == -3)
												{
													if (180218 - 416327 != -236109)
													{
														continue;
													}
													this.$self_$36184.p3AcGQMwRwn = "No empty slot";
													if (281613 - 83260 == 198354)
													{
														continue;
													}
												}
												else if (this.$$switch$4586$36182 == -5)
												{
													if (102864 - 511142 != -408278)
													{
														continue;
													}
													this.$self_$36184.p3AcGQMwRwn = "Item busy";
													if (189956 - 479810 != -289854)
													{
														continue;
													}
												}
												else
												{
													this.$self_$36184.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1024);
													if (94823 - 127006 != -32183)
													{
														continue;
													}
												}
												this.$self_$36184.e3PcGepEuGF = Time.time + (float)2;
												if (161296 - 328387 != -167090)
												{
													goto IL_83;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4E0;
				IL_12B:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_4E0:
				return false;
			}

			// Token: 0x06005F91 RID: 24465 RVA: 0x00CDC66C File Offset: 0x00CDA86C
			internal static bool m3XJC0pTn86Dm2u3orsh()
			{
				return true;
			}

			// Token: 0x06005F92 RID: 24466 RVA: 0x00CDC670 File Offset: 0x00CDA870
			internal static bool RdkYW8pT6AXJCS8bbvXg()
			{
				return false;
			}

			// Token: 0x04006A11 RID: 27153
			internal int $result$36179;

			// Token: 0x04006A12 RID: 27154
			internal int $nItemSlot$36180;

			// Token: 0x04006A13 RID: 27155
			internal int $nJil$36181;

			// Token: 0x04006A14 RID: 27156
			internal int $$switch$4586$36182;

			// Token: 0x04006A15 RID: 27157
			internal Hashtable $data$36183;

			// Token: 0x04006A16 RID: 27158
			internal AuctionGui $self_$36184;
		}
	}

	// Token: 0x0200102E RID: 4142
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onAuctionGetMoney$36187 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F93 RID: 24467 RVA: 0x00CDC674 File Offset: 0x00CDA874
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onAuctionGetMoney$36187(Hashtable data, AuctionGui self_)
		{
			if (162981 - 499410 != -336428)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (128240 - 282122 != -153881)
				{
					base..ctor();
					if (166543 - 355358 != -188814)
					{
						this.$data$36195 = data;
						if (27426 - 244915 != -217488)
						{
							this.$self_$36196 = self_;
							if (18916 - 142813 != -123896)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x00CDC730 File Offset: 0x00CDA930
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$onAuctionGetMoney$36187.$(this.$data$36195, this.$self_$36196);
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x00CDC744 File Offset: 0x00CDA944
		internal static bool hAoMfgpTicf4uA1RJBWl()
		{
			return true;
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x00CDC748 File Offset: 0x00CDA948
		internal static bool lOOebNpTKnqPjb9IFJo6()
		{
			return false;
		}

		// Token: 0x04006A17 RID: 27159
		internal Hashtable $data$36195;

		// Token: 0x04006A18 RID: 27160
		internal AuctionGui $self_$36196;

		// Token: 0x0200102F RID: 4143
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F97 RID: 24471 RVA: 0x00CDC74C File Offset: 0x00CDA94C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, AuctionGui self_)
			{
				if (228070 - 235536 != -7466)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154167 - 430346 != -276178)
					{
						base..ctor();
						if (86659 - 431622 != -344962)
						{
							this.$data$36193 = data;
							if (298217 - 111389 == 186828)
							{
								this.$self_$36194 = self_;
								if (75932 - 250551 == -174619)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005F98 RID: 24472 RVA: 0x00CDC808 File Offset: 0x00CDAA08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (152838 - 541784 != -388946)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_510;
					case 2:
						this.$self_$36194.RemoveItemFromAllList(this.$nItemSlot$36189);
						if (297668 - 500179 == -202510)
						{
							continue;
						}
						this.$self_$36194.ResetSelectItem();
						if (15106 - 542228 != -527121)
						{
							goto IL_249;
						}
						continue;
					default:
						if (158478 - 238350 != -79872)
						{
							continue;
						}
						break;
					}
					Debug.Log("On AuctionGetMoney");
					if (105741 - 146319 != -40578)
					{
						continue;
					}
					this.$result$36188 = RuntimeServices.UnboxInt32(this.$data$36193[31]);
					if (177284 - 38561 != 138723)
					{
						continue;
					}
					this.$nItemSlot$36189 = RuntimeServices.UnboxInt32(this.$data$36193[32]);
					if (227187 - 50259 == 176929)
					{
						continue;
					}
					this.$nBid$36190 = RuntimeServices.UnboxInt32(this.$data$36193[33]);
					if (292965 - 504297 != -211332)
					{
						continue;
					}
					this.$nGil$36191 = RuntimeServices.UnboxInt32(this.$data$36193[48]);
					if (208818 - 414474 == -205655)
					{
						continue;
					}
					if (this.$result$36188 == 1)
					{
						if (258043 - 541419 == -283375)
						{
							continue;
						}
						PlayerData.Gil = this.$nGil$36191;
						if (161205 - 466325 != -305120)
						{
							continue;
						}
						this.$self_$36194.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1031) + this.$nBid$36190 + "gil!";
						if (156648 - 268785 == -112136)
						{
							continue;
						}
						this.$self_$36194.e3PcGepEuGF = Time.time + (float)2;
						if (210993 - 196516 == 14478)
						{
							continue;
						}
						this.$self_$36194.ResetSelectItem();
						if (54055 - 584266 != -530210)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$$switch$4588$36192 = this.$result$36188;
						if (210274 - 378294 == -168019)
						{
							continue;
						}
						if (this.$$switch$4588$36192 == -1)
						{
							if (161687 - 155645 != 6042)
							{
								continue;
							}
							this.$self_$36194.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1026);
							if (166233 - 482381 != -316148)
							{
								continue;
							}
							this.$self_$36194.RemoveItemFromAllList(this.$nItemSlot$36189);
							if (169952 - 478131 != -308179)
							{
								continue;
							}
						}
						else if (this.$$switch$4588$36192 == -2)
						{
							if (63358 - 344114 != -280756)
							{
								continue;
							}
							this.$self_$36194.p3AcGQMwRwn = "Get money error";
							if (31762 - 400448 == -368685)
							{
								continue;
							}
						}
						else if (this.$$switch$4588$36192 == -3)
						{
							if (65064 - 583940 != -518876)
							{
								continue;
							}
							this.$self_$36194.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1032);
							if (123442 - 271753 != -148311)
							{
								continue;
							}
							this.$self_$36194.RemoveItemFromAllList(this.$nItemSlot$36189);
							if (10451 - 492733 != -482282)
							{
								continue;
							}
						}
						else if (this.$$switch$4588$36192 == -5)
						{
							if (177374 - 464209 == -286834)
							{
								continue;
							}
							this.$self_$36194.p3AcGQMwRwn = "Item busy";
							if (46296 - 192185 != -145889)
							{
								continue;
							}
						}
						else
						{
							this.$self_$36194.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1033);
							if (84346 - 256925 == -172578)
							{
								continue;
							}
						}
						this.$self_$36194.e3PcGepEuGF = Time.time + (float)2;
						if (132919 - 590601 != -457682)
						{
							continue;
						}
					}
					IL_249:
					this.YieldDefault(1);
					if (139521 - 230305 != -90783)
					{
						goto Block_14;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				IL_510:
				return false;
			}

			// Token: 0x06005F99 RID: 24473 RVA: 0x00CDCD38 File Offset: 0x00CDAF38
			internal static bool uIFTMopTdYS9stifvdq0()
			{
				return true;
			}

			// Token: 0x06005F9A RID: 24474 RVA: 0x00CDCD3C File Offset: 0x00CDAF3C
			internal static bool uVWIRWpTJxurBheSr29M()
			{
				return false;
			}

			// Token: 0x04006A19 RID: 27161
			internal int $result$36188;

			// Token: 0x04006A1A RID: 27162
			internal int $nItemSlot$36189;

			// Token: 0x04006A1B RID: 27163
			internal int $nBid$36190;

			// Token: 0x04006A1C RID: 27164
			internal int $nGil$36191;

			// Token: 0x04006A1D RID: 27165
			internal int $$switch$4588$36192;

			// Token: 0x04006A1E RID: 27166
			internal Hashtable $data$36193;

			// Token: 0x04006A1F RID: 27167
			internal AuctionGui $self_$36194;
		}
	}

	// Token: 0x02001030 RID: 4144
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onAuctionGetItem$36197 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005F9B RID: 24475 RVA: 0x00CDCD40 File Offset: 0x00CDAF40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onAuctionGetItem$36197(Hashtable data, AuctionGui self_)
		{
			if (118604 - 227200 != -108595)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220245 - 275444 != -55198)
				{
					base..ctor();
					if (153948 - 417315 == -263367)
					{
						this.$data$36203 = data;
						if (193458 - 492406 == -298948)
						{
							this.$self_$36204 = self_;
							if (258359 - 499087 != -240727)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x00CDCDFC File Offset: 0x00CDAFFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$onAuctionGetItem$36197.$(this.$data$36203, this.$self_$36204);
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x00CDCE10 File Offset: 0x00CDB010
		internal static bool LqbEsLpTDhTNLfCtd4uL()
		{
			return true;
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x00CDCE14 File Offset: 0x00CDB014
		internal static bool dLmjfOpTvlJMfFwpyZGp()
		{
			return false;
		}

		// Token: 0x04006A20 RID: 27168
		internal Hashtable $data$36203;

		// Token: 0x04006A21 RID: 27169
		internal AuctionGui $self_$36204;

		// Token: 0x02001031 RID: 4145
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005F9F RID: 24479 RVA: 0x00CDCE18 File Offset: 0x00CDB018
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, AuctionGui self_)
			{
				if (148851 - 550814 != -401963)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (124213 - 149825 == -25612)
					{
						base..ctor();
						if (265352 - 290858 == -25506)
						{
							this.$data$36201 = data;
							if (120237 - 592543 != -472305)
							{
								this.$self_$36202 = self_;
								if (280677 - 212352 != 68326)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005FA0 RID: 24480 RVA: 0x00CDCED4 File Offset: 0x00CDB0D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72451 - 259563 != -187111)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_464;
					case 1:
						goto IL_488;
					case 2:
						this.$self_$36202.RemoveItemFromAllList(this.$nItemSlot$36199);
						if (171625 - 183663 != -12038)
						{
							continue;
						}
						this.$self_$36202.ResetAuctionInventory();
						if (237701 - 584605 != -346904)
						{
							continue;
						}
						this.$self_$36202.ResetSelectItem();
						if (286095 - 325881 == -39785)
						{
							continue;
						}
						break;
					default:
						if (113535 - 464924 != -351388)
						{
							goto IL_464;
						}
						continue;
					}
					IL_304:
					this.YieldDefault(1);
					if (254267 - 217510 != 36758)
					{
						goto Block_24;
					}
					continue;
					IL_464:
					Debug.Log("On AuctionGetItem");
					if (68428 - 172578 != -104149)
					{
						this.$result$36198 = RuntimeServices.UnboxInt32(this.$data$36201[31]);
						if (94204 - 169950 != -75745)
						{
							this.$nItemSlot$36199 = RuntimeServices.UnboxInt32(this.$data$36201[32]);
							if (29512 - 191919 != -162406)
							{
								if (this.$result$36198 == 1)
								{
									if (131024 - 34966 != 96059)
									{
										this.$self_$36202.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1034);
										if (271540 - 593268 != -321727)
										{
											this.$self_$36202.e3PcGepEuGF = Time.time + (float)2;
											if (55587 - 298869 == -243282)
											{
												this.$self_$36202.ResetSelectItem();
												if (155470 - 493194 == -337724)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									this.$$switch$4590$36200 = this.$result$36198;
									if (36769 - 598448 != -561678)
									{
										if (this.$$switch$4590$36200 == -1)
										{
											if (42018 - 149941 == -107922)
											{
												continue;
											}
											this.$self_$36202.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1026);
											if (180366 - 233901 == -53534)
											{
												continue;
											}
											this.$self_$36202.RemoveItemFromAllList(this.$nItemSlot$36199);
											if (272438 - 143965 != 128473)
											{
												continue;
											}
										}
										else if (this.$$switch$4590$36200 == -2)
										{
											if (285793 - 478933 == -193139)
											{
												continue;
											}
											this.$self_$36202.p3AcGQMwRwn = "Get item error";
											if (261499 - 94406 != 167093)
											{
												continue;
											}
										}
										else if (this.$$switch$4590$36200 == -3)
										{
											if (163740 - 299830 == -136089)
											{
												continue;
											}
											this.$self_$36202.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1035);
											if (227240 - 318143 == -90902)
											{
												continue;
											}
											this.$self_$36202.RemoveItemFromAllList(this.$nItemSlot$36199);
											if (44140 - 395020 != -350880)
											{
												continue;
											}
										}
										else if (this.$$switch$4590$36200 == -5)
										{
											if (77067 - 117164 != -40097)
											{
												continue;
											}
											this.$self_$36202.p3AcGQMwRwn = "Item busy";
											if (103971 - 12520 != 91451)
											{
												continue;
											}
										}
										else
										{
											this.$self_$36202.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1036);
											if (10575 - 353507 != -342932)
											{
												continue;
											}
										}
										this.$self_$36202.e3PcGepEuGF = Time.time + (float)2;
										if (149411 - 166297 != -16885)
										{
											goto IL_304;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_24:
				IL_488:
				return false;
			}

			// Token: 0x06005FA1 RID: 24481 RVA: 0x00CDD37C File Offset: 0x00CDB57C
			internal static bool OEdL5wpTRqJR5ROWDU9H()
			{
				return true;
			}

			// Token: 0x06005FA2 RID: 24482 RVA: 0x00CDD380 File Offset: 0x00CDB580
			internal static bool dn6a9PpTwKLIqfZoWmng()
			{
				return false;
			}

			// Token: 0x04006A22 RID: 27170
			internal int $result$36198;

			// Token: 0x04006A23 RID: 27171
			internal int $nItemSlot$36199;

			// Token: 0x04006A24 RID: 27172
			internal int $$switch$4590$36200;

			// Token: 0x04006A25 RID: 27173
			internal Hashtable $data$36201;

			// Token: 0x04006A26 RID: 27174
			internal AuctionGui $self_$36202;
		}
	}

	// Token: 0x02001032 RID: 4146
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onAuctionRetrieve$36205 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005FA3 RID: 24483 RVA: 0x00CDD384 File Offset: 0x00CDB584
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onAuctionRetrieve$36205(Hashtable data, AuctionGui self_)
		{
			if (205310 - 481144 != -275833)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237320 - 571587 != -334266)
				{
					base..ctor();
					if (167879 - 223194 != -55314)
					{
						this.$data$36209 = data;
						if (122602 - 547668 == -425066)
						{
							this.$self_$36210 = self_;
							if (109184 - 478470 != -369285)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x00CDD440 File Offset: 0x00CDB640
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AuctionGui.$onAuctionRetrieve$36205.$(this.$data$36209, this.$self_$36210);
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00CDD454 File Offset: 0x00CDB654
		internal static bool WnYP5hpTqQAxZqpsDaTl()
		{
			return true;
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x00CDD458 File Offset: 0x00CDB658
		internal static bool Ur7oFGpT7hybdWmF5hP4()
		{
			return false;
		}

		// Token: 0x04006A27 RID: 27175
		internal Hashtable $data$36209;

		// Token: 0x04006A28 RID: 27176
		internal AuctionGui $self_$36210;

		// Token: 0x02001033 RID: 4147
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005FA7 RID: 24487 RVA: 0x00CDD45C File Offset: 0x00CDB65C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, AuctionGui self_)
			{
				if (119890 - 564821 != -444930)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (47823 - 144174 == -96351)
					{
						base..ctor();
						if (153514 - 493312 != -339797)
						{
							this.$data$36207 = data;
							if (286349 - 326396 == -40047)
							{
								this.$self_$36208 = self_;
								if (275465 - 483881 == -208416)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005FA8 RID: 24488 RVA: 0x00CDD518 File Offset: 0x00CDB718
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220669 - 275267 != -54598)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1BD;
					case 1:
						goto IL_27B;
					case 2:
						this.$itemSlot$36206 = RuntimeServices.UnboxInt32(this.$data$36207[32]);
						if (144839 - 257272 == -112432)
						{
							continue;
						}
						this.$self_$36208.RemoveItemFromAllList(this.$itemSlot$36206);
						if (186137 - 78162 != 107975)
						{
							continue;
						}
						this.$self_$36208.ResetAuctionInventory();
						if (163737 - 391776 == -228038)
						{
							continue;
						}
						this.$self_$36208.ResetSelectItem();
						if (195557 - 536656 == -341098)
						{
							continue;
						}
						break;
					default:
						if (172589 - 224239 != -51650)
						{
							continue;
						}
						goto IL_1BD;
					}
					IL_1A:
					this.YieldDefault(1);
					if (260517 - 90967 != 169550)
					{
						continue;
					}
					goto IL_27B;
					IL_1BD:
					Debug.Log("On AuctionRetrieve");
					if (22147 - 427209 == -405062)
					{
						if (RuntimeServices.EqualityOperator(this.$data$36207[31], 1))
						{
							if (40875 - 972 == 39903)
							{
								this.$self_$36208.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1037);
								if (249848 - 592584 == -342736)
								{
									this.$self_$36208.e3PcGepEuGF = Time.time + (float)2;
									if (238518 - 444170 == -205652)
									{
										this.$self_$36208.ResetSelectItem();
										if (54525 - 404078 == -349553)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.$self_$36208.p3AcGQMwRwn = Language.getMessage("AuctionGui", 1038);
							if (135164 - 501218 != -366053)
							{
								this.$self_$36208.e3PcGepEuGF = Time.time + (float)2;
								if (137336 - 445405 == -308069)
								{
									goto IL_1A;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_27B:
				return false;
			}

			// Token: 0x06005FA9 RID: 24489 RVA: 0x00CDD7B4 File Offset: 0x00CDB9B4
			internal static bool eaf2pgpTP2ARnkHPutdL()
			{
				return true;
			}

			// Token: 0x06005FAA RID: 24490 RVA: 0x00CDD7B8 File Offset: 0x00CDB9B8
			internal static bool Axn4oUpT0Bmd08O7rcP9()
			{
				return false;
			}

			// Token: 0x04006A29 RID: 27177
			internal int $itemSlot$36206;

			// Token: 0x04006A2A RID: 27178
			internal Hashtable $data$36207;

			// Token: 0x04006A2B RID: 27179
			internal AuctionGui $self_$36208;
		}
	}
}
