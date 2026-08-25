using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001017 RID: 4119
[Serializable]
public class ArenaShopGui : MonoBehaviour
{
	// Token: 0x06005EDC RID: 24284 RVA: 0x00CBE50C File Offset: 0x00CBC70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArenaShopGui()
	{
		if (56427 - 97305 != -40877)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (162140 - 334934 != -172793)
			{
				base..ctor();
				if (297910 - 348465 == -50555)
				{
					this.jElclAckVgV = string.Empty;
					if (107776 - 70362 != 37415)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005EDD RID: 24285 RVA: 0x00CBE5A8 File Offset: 0x00CBC7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (134548 - 447819 != -313271)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (250343 - 81500 == 168843)
			{
				if (this.mState == eArenaShopState.init)
				{
					if (150462 - 206103 == -55640)
					{
						continue;
					}
					this.InitNPC();
					if (216546 - 37715 == 178832)
					{
						continue;
					}
					this.InitArenaShopMenu();
					if (130751 - 367395 != -236644)
					{
						continue;
					}
					this.InitArenaShopList();
					if (112628 - 352336 == -239707)
					{
						continue;
					}
					this.InitArenaShopEntry();
					if (98443 - 499123 == -400679)
					{
						continue;
					}
					this.InitNoticeBar();
					if (184647 - 450999 != -266352)
					{
						continue;
					}
				}
				this.VQyclrwsN60 = 0;
				if (53891 - 127182 == -73291)
				{
					this.Rc5clxUL1t0 = 1f;
					if (293795 - 115604 == 178191)
					{
						this.ResetNPC();
						if (262828 - 446979 != -184150)
						{
							this.ResetArenaShopList();
							if (273751 - 130932 != 142820)
							{
								this.ResetArenaShopEntry();
								if (274191 - 486405 != -212213)
								{
									this.mState = eArenaShopState.open;
									if (194510 - 305998 != -111487)
									{
										this.g5bclq1SgQS = Time.time;
										if (18119 - 280387 != -262267)
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

	// Token: 0x06005EDE RID: 24286 RVA: 0x00CBE7B4 File Offset: 0x00CBC9B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (30144 - 218108 != -187963)
		{
		}
		for (;;)
		{
			if (this.mState <= eArenaShopState.init)
			{
				if (61636 - 539014 == -477378)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (106229 - 401963 == -295734)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (80630 - 109536 == -28906)
					{
						this.zFSclp4sTO6 = (float)(1024 * Screen.width / Screen.height);
						if (124132 - 156484 == -32352)
						{
							this.jGYclR9umbk = (float)Screen.height / 1024f;
							if (16401 - 32385 == -15984)
							{
								this.RenderArenaShopMenu();
								if (94673 - 399845 != -305171)
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

	// Token: 0x06005EDF RID: 24287 RVA: 0x00CBE904 File Offset: 0x00CBCB04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitArenaShopMenu()
	{
		if (2429 - 171147 != -168718)
		{
		}
		for (;;)
		{
			this.vQvclTZtoPR = (Texture)Resources.Load("GameGui/ArenaShop/arenaShopWindow", typeof(Texture));
			if (56848 - 391106 != -334257)
			{
				this.sGNclYUURTt = new GUIStyle();
				if (104033 - 295204 == -191171)
				{
					this.sGNclYUURTt.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
					if (183290 - 580182 != -396891)
					{
						this.XjDcl3BbIyD = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
						if (249989 - 26212 != 223778)
						{
							this.XrdclbKwRiG = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
							if (105829 - 52307 == 53522)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005EE0 RID: 24288 RVA: 0x00CBEA54 File Offset: 0x00CBCC54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderArenaShopMenu()
	{
		if (232271 - 205422 != 26849)
		{
		}
		for (;;)
		{
			float num = Time.time - this.g5bclq1SgQS;
			if (50589 - 173206 != -122616)
			{
				eArenaShopState eArenaShopState = this.mState;
				if (209084 - 458109 != -249024)
				{
					if (eArenaShopState == eArenaShopState.open)
					{
						if (146208 - 353759 == -207551)
						{
							if (num <= 0.5f)
							{
								if (88135 - 98627 == -10492)
								{
									this.Rc5clxUL1t0 = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (291343 - 71311 == 220032)
									{
										this.RenderNPC();
										if (223114 - 376924 == -153810)
										{
											GUI.DrawTexture(new Rect(0.5f * this.zFSclp4sTO6 - (float)336, (float)724 + this.Rc5clxUL1t0 * (float)300, (float)836, (float)196), this.TMCclaOciRw);
											if (215312 - 96258 == 119054)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (78389 - 102315 != -23925)
								{
									this.Rc5clxUL1t0 = (float)0;
									if (206650 - 488819 == -282169)
									{
										this.RenderNPC();
										if (131386 - 293952 == -162566)
										{
											GUI.BeginGroup(new Rect(0.5f * this.zFSclp4sTO6 - (float)350, (float)724, (float)850, (float)200));
											if (249181 - 175736 != 73446)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.TMCclaOciRw);
												if (112594 - 378259 != -265664)
												{
													eArenaShopType eArenaShopType = this.mType;
													if (115965 - 392411 != -276445)
													{
														if (eArenaShopType == eArenaShopType.Liger)
														{
															if (75775 - 326761 == -250985)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Boldas", this.ukBcl4bBbxf);
															if (206414 - 436630 == -230215)
															{
																continue;
															}
														}
														else if (eArenaShopType == eArenaShopType.Falcon)
														{
															if (151646 - 108172 == 43475)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Falcon", this.ukBcl4bBbxf);
															if (183900 - 80734 != 103166)
															{
																continue;
															}
														}
														else if (eArenaShopType == eArenaShopType.Owl1)
														{
															if (261511 - 111581 == 149931)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Xinfu", this.ukBcl4bBbxf);
															if (116292 - 591780 != -475488)
															{
																continue;
															}
														}
														else if (eArenaShopType == eArenaShopType.Owl2)
														{
															if (226333 - 154217 == 72117)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Linlin", this.ukBcl4bBbxf);
															if (53024 - 580779 == -527754)
															{
																continue;
															}
														}
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.OvjclHTiqgE, num - 0.5f), this.rXcclsDmowC);
														if (42904 - 569629 == -526725)
														{
															GUI.EndGroup();
															if (210444 - 267764 != -57319)
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
								this.Rc5clxUL1t0 = (float)0;
								if (195237 - 428917 == -233680)
								{
									this.RenderNPC();
									if (87653 - 144708 != -57054)
									{
										this.VQyclrwsN60 = 0;
										if (8659 - 106185 == -97526)
										{
											this.mState = eArenaShopState.shop;
											if (284788 - 550985 == -266197)
											{
												this.g5bclq1SgQS = Time.time;
												if (6924 - 487770 == -480846)
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
					else if (eArenaShopState == eArenaShopState.shop)
					{
						if (160855 - 469972 == -309117)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.zFSclp4sTO6 - (float)450) / this.zFSclp4sTO6, (float)1);
							if (293014 - 262416 == 30598)
							{
								GUI.BeginGroup(new Rect(this.zFSclp4sTO6 - (float)550, (float)0, (float)550, (float)1024));
								if (128035 - 508220 == -380185)
								{
									GUI.DrawTexture(new Rect((float)0, (float)0, (float)550, (float)1024), this.vQvclTZtoPR);
									if (267311 - 316497 != -49185)
									{
										Guix.renderSmallNumber(480, 62, Game.mGameMana, false, (float)1);
										if (147510 - 151344 == -3834)
										{
											this.RenderArenaShopList();
											if (259913 - 376719 == -116806)
											{
												this.RenderArenaShopEntry();
												if (1419 - 325153 != -323733)
												{
													this.RenderNoticeBar();
													if (294988 - 174490 == 120498)
													{
														if (GUI.Button(new Rect((float)99, (float)1, (float)57, (float)52), string.Empty, this.sGNclYUURTt))
														{
															if (214101 - 314967 == -100865)
															{
																continue;
															}
															this.mState = eArenaShopState.close;
															if (93873 - 299746 == -205872)
															{
																continue;
															}
															this.g5bclq1SgQS = Time.time;
															if (35155 - 364897 != -329742)
															{
																continue;
															}
															this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
															if (297262 - 72401 != 224861)
															{
																continue;
															}
														}
														GUI.EndGroup();
														if (261265 - 270895 != -9629)
														{
															this.RenderNPC();
															if (257546 - 352718 != -95171)
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
					else
					{
						if (eArenaShopState != eArenaShopState.close)
						{
							break;
						}
						if (43463 - 489119 != -445655)
						{
							if (num <= (float)2)
							{
								if (17658 - 366236 == -348578)
								{
									this.RenderNPC();
									if (220663 - 149811 == 70852)
									{
										GUI.BeginGroup(new Rect(0.5f * this.zFSclp4sTO6 - (float)350, (float)724, (float)850, (float)200));
										if (278270 - 124018 == 154252)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.TMCclaOciRw);
											if (216625 - 591750 != -375124)
											{
												eArenaShopType eArenaShopType2 = this.mType;
												if (232060 - 400536 == -168476)
												{
													if (eArenaShopType2 == eArenaShopType.Liger)
													{
														if (172118 - 242016 != -69898)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Boldas", this.ukBcl4bBbxf);
														if (81808 - 96189 != -14381)
														{
															continue;
														}
													}
													else if (eArenaShopType2 == eArenaShopType.Falcon)
													{
														if (234447 - 578695 == -344247)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Falcon", this.ukBcl4bBbxf);
														if (93833 - 542759 != -448926)
														{
															continue;
														}
													}
													else if (eArenaShopType2 == eArenaShopType.Owl1)
													{
														if (101645 - 348034 == -246388)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Xinfu", this.ukBcl4bBbxf);
														if (276544 - 213157 != 63387)
														{
															continue;
														}
													}
													else if (eArenaShopType2 == eArenaShopType.Owl2)
													{
														if (5561 - 116198 == -110636)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Linlin", this.ukBcl4bBbxf);
														if (214698 - 160478 != 54220)
														{
															continue;
														}
													}
													GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.ueqclZAUcsF, num), this.rXcclsDmowC);
													if (16936 - 47511 == -30575)
													{
														GUI.EndGroup();
														if (27067 - 311800 == -284733)
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
								if (19159 - 483142 == -463983)
								{
									this.Rc5clxUL1t0 = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (118521 - 446649 != -328127)
									{
										this.RenderNPC();
										if (101110 - 94766 != 6345)
										{
											break;
										}
									}
								}
							}
							else
							{
								if (Game.mGameState != eGameState.Normal)
								{
									if (264259 - 319676 == -55416)
									{
										continue;
									}
									if (Game.mGameState != eGameState.Hold)
									{
										goto IL_4E5;
									}
									if (257411 - 133378 != 124033)
									{
										continue;
									}
								}
								Game.mGameState = eGameState.Normal;
								if (142327 - 529292 != -386965)
								{
									continue;
								}
								GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
								if (98458 - 418730 != -320272)
								{
									continue;
								}
								gameGui.enabled = true;
								if (159362 - 580541 != -421179)
								{
									continue;
								}
								IL_4E5:
								this.mState = eArenaShopState.disabled;
								if (104808 - 130534 != -25725)
								{
									this.enabled = false;
									if (34990 - 138787 != -103796)
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

	// Token: 0x06005EE1 RID: 24289 RVA: 0x00CBF668 File Offset: 0x00CBD868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (288022 - 551539 != -263516)
		{
		}
		for (;;)
		{
			this.TMCclaOciRw = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (30607 - 498891 != -468283)
			{
				this.ukBcl4bBbxf = new GUIStyle();
				if (168576 - 241565 == -72989)
				{
					this.ukBcl4bBbxf.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (114236 - 149156 != -34919)
					{
						this.ukBcl4bBbxf.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (71115 - 318511 == -247396)
						{
							this.ukBcl4bBbxf.alignment = TextAnchor.UpperLeft;
							if (38254 - 241865 == -203611)
							{
								this.rXcclsDmowC = new GUIStyle();
								if (39399 - 90299 == -50900)
								{
									this.rXcclsDmowC.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (214184 - 228436 == -14252)
									{
										this.rXcclsDmowC.alignment = TextAnchor.UpperLeft;
										if (178498 - 10852 != 167647)
										{
											this.ResetNPC();
											if (45366 - 117524 == -72158)
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

	// Token: 0x06005EE2 RID: 24290 RVA: 0x00CBF84C File Offset: 0x00CBDA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (108654 - 304877 != -196222)
		{
		}
		for (;;)
		{
			eArenaShopType eArenaShopType = this.mType;
			if (231926 - 207585 == 24341)
			{
				if (eArenaShopType == eArenaShopType.Liger)
				{
					if (99204 - 509596 != -410391)
					{
						this.OvjclHTiqgE = ArenaShopGui_m.getMessage("LigerOpen");
						if (280666 - 315092 != -34425)
						{
							this.ueqclZAUcsF = ArenaShopGui_m.getMessage("LigerClose");
							if (249045 - 149416 != 99630)
							{
								this.WfkclgibeDC = (Texture)Resources.Load("GameGui/Story/Characters/Liger", typeof(Texture));
								if (215053 - 163423 != 51631)
								{
									break;
								}
							}
						}
					}
				}
				else if (eArenaShopType == eArenaShopType.Falcon)
				{
					if (17993 - 375138 != -357144)
					{
						this.OvjclHTiqgE = ArenaShopGui_m.getMessage("FalconOpen");
						if (26256 - 486897 != -460640)
						{
							this.ueqclZAUcsF = ArenaShopGui_m.getMessage("FalconClose");
							if (186929 - 430549 != -243619)
							{
								this.WfkclgibeDC = (Texture)Resources.Load("GameGui/Story/Characters/Falcon", typeof(Texture));
								if (133246 - 574530 == -441284)
								{
									break;
								}
							}
						}
					}
				}
				else if (eArenaShopType == eArenaShopType.Owl1)
				{
					if (114104 - 415675 == -301571)
					{
						this.OvjclHTiqgE = ArenaShopGui_m.getMessage("Owl1Open");
						if (268342 - 280278 != -11935)
						{
							this.ueqclZAUcsF = ArenaShopGui_m.getMessage("Owl1Close");
							if (116231 - 235474 != -119242)
							{
								this.WfkclgibeDC = (Texture)Resources.Load("GameGui/Story/Characters/Owl1", typeof(Texture));
								if (260044 - 465312 == -205268)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (eArenaShopType != eArenaShopType.Owl2)
					{
						break;
					}
					if (232894 - 93364 != 139531)
					{
						this.OvjclHTiqgE = ArenaShopGui_m.getMessage("Owl2Open");
						if (186090 - 443798 == -257708)
						{
							this.ueqclZAUcsF = ArenaShopGui_m.getMessage("Owl2Close");
							if (141664 - 318349 != -176684)
							{
								this.WfkclgibeDC = (Texture)Resources.Load("GameGui/Story/Characters/Owl2", typeof(Texture));
								if (246058 - 416180 == -170122)
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

	// Token: 0x06005EE3 RID: 24291 RVA: 0x00CBFB74 File Offset: 0x00CBDD74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (52638 - 263588 != -210949)
		{
		}
		for (;;)
		{
			eArenaShopType eArenaShopType = this.mType;
			if (240886 - 428797 == -187911)
			{
				if (eArenaShopType == eArenaShopType.Liger)
				{
					if (213834 - 22649 != 191186)
					{
						GUI.DrawTexture(new Rect((float)0 - this.Rc5clxUL1t0 * (float)472, (float)430, (float)472, (float)594), this.WfkclgibeDC);
						if (238845 - 438715 != -199869)
						{
							break;
						}
					}
				}
				else if (eArenaShopType == eArenaShopType.Falcon)
				{
					if (247719 - 366101 == -118382)
					{
						GUI.DrawTexture(new Rect((float)0 - this.Rc5clxUL1t0 * (float)413, (float)275, (float)413, (float)749), this.WfkclgibeDC);
						if (147750 - 423830 != -276079)
						{
							break;
						}
					}
				}
				else if (eArenaShopType == eArenaShopType.Owl1)
				{
					if (134654 - 396665 == -262011)
					{
						GUI.DrawTexture(new Rect((float)0 - this.Rc5clxUL1t0 * (float)354, (float)576, (float)354, (float)448), this.WfkclgibeDC);
						if (84791 - 16746 == 68045)
						{
							break;
						}
					}
				}
				else
				{
					if (eArenaShopType != eArenaShopType.Owl2)
					{
						break;
					}
					if (214583 - 90110 != 124474)
					{
						GUI.DrawTexture(new Rect((float)0 - this.Rc5clxUL1t0 * (float)364, (float)592, (float)364, (float)432), this.WfkclgibeDC);
						if (68700 - 258735 != -190034)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005EE4 RID: 24292 RVA: 0x00CBFD98 File Offset: 0x00CBDF98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitArenaShopList()
	{
		if (121666 - 177503 != -55836)
		{
		}
		for (;;)
		{
			this.GXYclNNnWJJ = (Texture)Resources.Load("GameGui/ArenaShop/supplyHighlight", typeof(Texture));
			if (265727 - 51927 != 213801)
			{
				this.ihLclEXlMCm = new GUIStyle();
				if (36059 - 575003 == -538944)
				{
					this.ihLclEXlMCm.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_shop_h", typeof(Texture)));
					if (260938 - 551737 == -290799)
					{
						this.jp6clLsKkUR = new GUIStyle();
						if (240757 - 163948 == 76809)
						{
							this.jp6clLsKkUR.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
							if (120155 - 133206 == -13051)
							{
								this.jp6clLsKkUR.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
								if (68243 - 73199 == -4956)
								{
									this.jp6clLsKkUR.alignment = TextAnchor.MiddleLeft;
									if (108676 - 314480 == -205804)
									{
										this.aH8clw85uYG = new GUIStyle();
										if (83552 - 599324 != -515771)
										{
											this.aH8clw85uYG.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
											if (114409 - 163580 != -49170)
											{
												this.aH8clw85uYG.normal.textColor = new Color(0.16f, 0.27f, 0.42f, (float)1);
												if (278028 - 311852 != -33823)
												{
													this.aH8clw85uYG.alignment = TextAnchor.MiddleRight;
													if (30544 - 575664 == -545120)
													{
														this.MGHclUYwbwv = new GUIStyle();
														if (275559 - 273307 != 2253)
														{
															this.MGHclUYwbwv.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
															if (151652 - 182190 != -30537)
															{
																this.MGHclUYwbwv.normal.textColor = new Color(0.5f, 0.21f, 0.16f, (float)1);
																if (185742 - 208355 == -22613)
																{
																	this.MGHclUYwbwv.alignment = TextAnchor.MiddleRight;
																	if (139502 - 545456 == -405954)
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

	// Token: 0x06005EE5 RID: 24293 RVA: 0x00CC00C8 File Offset: 0x00CBE2C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetArenaShopList()
	{
		if (205278 - 449599 != -244321)
		{
		}
		for (;;)
		{
			IL_488:
			eArenaShopType eArenaShopType = this.mType;
			if (12554 - 588069 != -575514)
			{
				if (eArenaShopType == eArenaShopType.Liger)
				{
					if (289610 - 170701 != 118909)
					{
						continue;
					}
				}
				else if (eArenaShopType == eArenaShopType.Falcon)
				{
					if (56884 - 500252 != -443368)
					{
						continue;
					}
				}
				else
				{
					if (eArenaShopType == eArenaShopType.Owl1)
					{
						if (60681 - 59838 != 843)
						{
							continue;
						}
					}
					else
					{
						if (eArenaShopType != eArenaShopType.Owl2)
						{
							goto IL_346;
						}
						if (259987 - 409738 != -149751)
						{
							continue;
						}
					}
					this.dW3clCbO3po = new string[]
					{
						"TowerPower",
						"TowerBreak",
						"TowerBarrier",
						"TowerFreeze"
					};
					if (110168 - 214814 != -104646)
					{
						continue;
					}
					this.TF2clMXn0Eo = new int[]
					{
						5,
						10,
						15,
						20
					};
					if (119224 - 108617 != 10608)
					{
						goto IL_346;
					}
					continue;
				}
				this.dW3clCbO3po = new string[]
				{
					"LightLeopard",
					"LightGolem",
					"WhiteFlag"
				};
				if (221182 - 506310 == -285127)
				{
					continue;
				}
				this.TF2clMXn0Eo = new int[]
				{
					20,
					100,
					10
				};
				if (149463 - 119445 != 30018)
				{
					continue;
				}
				IL_346:
				int num = 0;
				if (85197 - 477750 != -392552)
				{
					if (CharacterData.current.Type == "Rabbit")
					{
						if (217814 - 260152 == -42337)
						{
							continue;
						}
						if (CharacterData.current.hasSkill(311))
						{
							if (75502 - 27965 == 47538)
							{
								continue;
							}
							num++;
							if (116948 - 180888 != -63940)
							{
								continue;
							}
						}
						if (CharacterData.current.hasSkill(312))
						{
							if (50159 - 52679 == -2519)
							{
								continue;
							}
							num++;
							if (32376 - 213436 == -181059)
							{
								continue;
							}
						}
						if (CharacterData.current.hasSkill(313))
						{
							if (24262 - 20895 != 3367)
							{
								continue;
							}
							num++;
							if (69759 - 333783 != -264024)
							{
								continue;
							}
						}
						if (CharacterData.current.hasSkill(314))
						{
							if (113750 - 232852 != -119102)
							{
								continue;
							}
							num++;
							if (190297 - 176134 != 14163)
							{
								continue;
							}
						}
					}
					this.hIdclfBEFYt = new Texture[Extensions.get_length(this.dW3clCbO3po)];
					if (299830 - 162968 == 136862)
					{
						if (Extensions.get_length(this.dW3clCbO3po) <= 0)
						{
							break;
						}
						if (129983 - 165661 != -35677)
						{
							int i = 0;
							if (30131 - 111744 != -81612)
							{
								while (i < Extensions.get_length(this.dW3clCbO3po))
								{
									this.hIdclfBEFYt[i] = (Texture)Resources.Load("GameGui/ArenaShop/supply_" + this.dW3clCbO3po[i], typeof(Texture));
									if (108323 - 577410 == -469086)
									{
										goto IL_488;
									}
									if (num > 0)
									{
										if (190152 - 308448 != -118296)
										{
											goto IL_488;
										}
										this.TF2clMXn0Eo[i] = Mathf.FloorToInt((1f - 0.05f * (float)num) * (float)this.TF2clMXn0Eo[i]);
										if (17415 - 429479 != -412064)
										{
											goto IL_488;
										}
									}
									i++;
									if (255445 - 126195 != 129250)
									{
										goto IL_488;
									}
								}
								if (115816 - 257169 != -141352)
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

	// Token: 0x06005EE6 RID: 24294 RVA: 0x00CC0590 File Offset: 0x00CBE790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderArenaShopList()
	{
		if (75242 - 130517 != -55274)
		{
		}
		IL_1D1:
		while (this.dW3clCbO3po != null)
		{
			if (160577 - 260538 != -99960)
			{
				if (Extensions.get_length(this.dW3clCbO3po) <= 0)
				{
					break;
				}
				if (61029 - 319880 != -258850)
				{
					int i = 0;
					if (143534 - 561644 == -418110)
					{
						while (i < Extensions.get_length(this.dW3clCbO3po))
						{
							if (this.VQyclrwsN60 == i)
							{
								if (268398 - 159123 != 109275)
								{
									goto IL_1D1;
								}
								GUI.DrawTexture(new Rect((float)80, (float)(177 + 51 * i), (float)415, (float)51), this.GXYclNNnWJJ);
								if (59556 - 342401 != -282845)
								{
									goto IL_1D1;
								}
							}
							if (this.hIdclfBEFYt[i])
							{
								if (47063 - 319313 != -272250)
								{
									goto IL_1D1;
								}
								GUI.DrawTexture(new Rect((float)105, (float)(178 + 51 * i), (float)50, (float)50), this.hIdclfBEFYt[i]);
								if (267530 - 313951 != -46421)
								{
									goto IL_1D1;
								}
							}
							GUI.Label(new Rect((float)190, (float)(175 + 51 * i), (float)175, (float)50), this.dW3clCbO3po[i], this.jp6clLsKkUR);
							if (166591 - 121355 != 45236)
							{
								goto IL_1D1;
							}
							if (Game.mGameMana >= this.TF2clMXn0Eo[i])
							{
								if (117040 - 409974 == -292933)
								{
									goto IL_1D1;
								}
								GUI.Label(new Rect((float)420, (float)(185 + 51 * i), (float)80, (float)30), this.TF2clMXn0Eo[i] + " mn", this.aH8clw85uYG);
								if (259541 - 153990 != 105551)
								{
									goto IL_1D1;
								}
							}
							else
							{
								GUI.Label(new Rect((float)420, (float)(185 + 51 * i), (float)80, (float)30), this.TF2clMXn0Eo[i] + " mn", this.MGHclUYwbwv);
								if (274906 - 587789 != -312883)
								{
									goto IL_1D1;
								}
							}
							if (GUI.Button(new Rect((float)110, (float)(182 + 51 * i), (float)257, (float)50), string.Empty, this.ihLclEXlMCm))
							{
								if (75688 - 61357 == 14332)
								{
									goto IL_1D1;
								}
								this.VQyclrwsN60 = i;
								if (51649 - 524688 != -473039)
								{
									goto IL_1D1;
								}
								this.ResetArenaShopEntry();
								if (54253 - 347189 != -292936)
								{
									goto IL_1D1;
								}
								this.audio.PlayOneShot(this.XrdclbKwRiG);
								if (238441 - 436958 != -198517)
								{
									goto IL_1D1;
								}
							}
							i++;
							if (154521 - 326265 == -171743)
							{
								goto IL_1D1;
							}
						}
						if (197586 - 577655 != -380068)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005EE7 RID: 24295 RVA: 0x00CC093C File Offset: 0x00CBEB3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitArenaShopEntry()
	{
		if (101538 - 284489 != -182951)
		{
		}
		for (;;)
		{
			this.EyDcliRJ3Xl = new string[]
			{
				"none",
				"none",
				"none",
				"none",
				"none",
				"none",
				"none",
				"none"
			};
			if (27266 - 248438 != -221171)
			{
				this.aYkclDfDGHW = new Texture[12];
				if (88336 - 298700 != -210363)
				{
					this.CZ8clPenYp3 = new GUIStyle();
					if (58302 - 266294 != -207991)
					{
						this.CZ8clPenYp3.font = (Font)Resources.Load("GameGui/Fonts/Century22", typeof(Font));
						if (24268 - 90730 == -66462)
						{
							this.CZ8clPenYp3.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
							if (87656 - 574459 == -486803)
							{
								this.CZ8clPenYp3.alignment = TextAnchor.MiddleLeft;
								if (202976 - 302906 != -99929)
								{
									this.sKXclSnZ4uf = new GUIStyle();
									if (235873 - 458838 == -222965)
									{
										this.sKXclSnZ4uf.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
										if (161590 - 289645 == -128055)
										{
											this.sKXclSnZ4uf.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
											if (2606 - 351217 == -348611)
											{
												this.sKXclSnZ4uf.alignment = TextAnchor.UpperLeft;
												if (228721 - 25055 != 203667)
												{
													this.sKXclSnZ4uf.wordWrap = true;
													if (110372 - 587858 != -477485)
													{
														this.PV2clmrGrDf = new GUIStyle();
														if (226428 - 541843 != -315414)
														{
															this.PV2clmrGrDf.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/ArenaShop/buy_h", typeof(Texture)));
															if (103850 - 210488 == -106638)
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

	// Token: 0x06005EE8 RID: 24296 RVA: 0x00CC0C14 File Offset: 0x00CBEE14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetArenaShopEntry()
	{
		if (159717 - 173110 != -13392)
		{
		}
		for (;;)
		{
			IL_135:
			if (this.dW3clCbO3po == null)
			{
				if (63672 - 547376 == -483704)
				{
					break;
				}
			}
			else if (this.EyDcliRJ3Xl == null)
			{
				if (168723 - 42335 != 126389)
				{
					break;
				}
			}
			else
			{
				if (Extensions.get_length(this.dW3clCbO3po) <= this.VQyclrwsN60)
				{
					if (205645 - 563344 != -357699)
					{
						continue;
					}
					this.VQyclrwsN60 = 0;
					if (12936 - 288755 == -275818)
					{
						continue;
					}
				}
				this.QOFclB3d932 = this.dW3clCbO3po[this.VQyclrwsN60];
				if (109917 - 57407 != 52511)
				{
					this.x0rcl8VxTc1 = ArenaShopGui_m.getMessage(this.QOFclB3d932);
					if (273377 - 550159 == -276782)
					{
						if (Game.mGameCode != 983)
						{
							break;
						}
						if (72356 - 351108 != -278751)
						{
							this.dylcljF5Zrs = (M983_CrystalDefense)this.GetComponent(typeof(M983_CrystalDefense));
							if (77938 - 328915 == -250977)
							{
								if (this.dylcljF5Zrs)
								{
									if (188875 - 555339 == -366463)
									{
										continue;
									}
									eArenaShopType eArenaShopType = this.mType;
									if (39288 - 529974 != -490686)
									{
										continue;
									}
									if (eArenaShopType == eArenaShopType.Liger)
									{
										if (100572 - 153971 != -53399)
										{
											continue;
										}
									}
									else if (eArenaShopType == eArenaShopType.Falcon)
									{
										if (161423 - 184676 == -23252)
										{
											continue;
										}
									}
									else
									{
										if (eArenaShopType == eArenaShopType.Owl1)
										{
											if (51314 - 10833 != 40481)
											{
												continue;
											}
										}
										else
										{
											if (eArenaShopType != eArenaShopType.Owl2)
											{
												goto IL_9D;
											}
											if (102587 - 116965 == -14377)
											{
												continue;
											}
										}
										this.EyDcliRJ3Xl = (string[])this.dylcljF5Zrs.getSupplyList().ToBuiltin(typeof(string));
										if (107915 - 221247 != -113332)
										{
											continue;
										}
										goto IL_9D;
									}
									this.EyDcliRJ3Xl = (string[])this.dylcljF5Zrs.getSoldierList().ToBuiltin(typeof(string));
									if (224790 - 478903 != -254113)
									{
										continue;
									}
								}
								IL_9D:
								this.aYkclDfDGHW = new Texture[12];
								if (170199 - 298101 != -127901)
								{
									int i = 0;
									if (163968 - 597042 != -433073)
									{
										while (i < 12)
										{
											if (Extensions.get_length(this.EyDcliRJ3Xl) > i)
											{
												if (182064 - 180207 == 1858)
												{
													goto IL_135;
												}
												this.aYkclDfDGHW[i] = (Texture)Resources.Load("GameGui/ArenaShop/supply_" + this.EyDcliRJ3Xl[i], typeof(Texture));
												if (230273 - 440120 == -209846)
												{
													goto IL_135;
												}
											}
											else
											{
												this.aYkclDfDGHW[i] = null;
												if (273565 - 495580 != -222015)
												{
													goto IL_135;
												}
											}
											i++;
											if (124321 - 24791 == 99531)
											{
												goto IL_135;
											}
										}
										if (173299 - 179118 != -5818)
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

	// Token: 0x06005EE9 RID: 24297 RVA: 0x00CC102C File Offset: 0x00CBF22C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderArenaShopEntry()
	{
		if (76343 - 44364 != 31980)
		{
		}
		for (;;)
		{
			IL_FB:
			if (this.hIdclfBEFYt[this.VQyclrwsN60])
			{
				if (58306 - 220023 == -161716)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)137, (float)690, (float)64, (float)64), this.hIdclfBEFYt[this.VQyclrwsN60]);
				if (111489 - 242058 == -130568)
				{
					continue;
				}
			}
			GUI.Label(new Rect((float)220, (float)678, (float)200, (float)50), this.QOFclB3d932, this.CZ8clPenYp3);
			if (262011 - 357469 != -95457)
			{
				GUI.Label(new Rect((float)220, (float)730, (float)220, (float)300), this.x0rcl8VxTc1, this.sKXclSnZ4uf);
				if (35687 - 251049 == -215362)
				{
					if (Time.time > this.LfnclFaiJE6)
					{
						if (94536 - 558913 != -464377)
						{
							continue;
						}
						if (GUI.Button(new Rect((float)400, (float)790, (float)84, (float)38), string.Empty, this.PV2clmrGrDf))
						{
							if (122014 - 240955 == -118940)
							{
								continue;
							}
							if (this.TF2clMXn0Eo[this.VQyclrwsN60] > Game.mGameMana)
							{
								if (127983 - 580376 == -452392)
								{
									continue;
								}
								this.newNoticeBar("Not enough mana", (float)2);
								if (279796 - 116909 != 162887)
								{
									continue;
								}
							}
							else
							{
								if (Extensions.get_length(this.EyDcliRJ3Xl) >= 12)
								{
									if (65336 - 473646 != -408310)
									{
										continue;
									}
									if (this.QOFclB3d932 != "WhiteFlag")
									{
										if (141327 - 170000 != -28673)
										{
											continue;
										}
										this.newNoticeBar("Slot is full", (float)2);
										if (298556 - 177878 != 120679)
										{
											goto IL_54C;
										}
										continue;
									}
								}
								if (this.QOFclB3d932 == "WhiteFlag")
								{
									if (111758 - 311706 == -199947)
									{
										continue;
									}
									if (Time.time - Game.mGameTime < (float)1440)
									{
										if (80054 - 572068 != -492014)
										{
											continue;
										}
										this.newNoticeBar("Need to wait at least 24 minutes", (float)2);
										if (170416 - 197027 != -26611)
										{
											continue;
										}
										goto IL_54C;
									}
								}
								if (this.QOFclB3d932 == "WhiteFlag")
								{
									if (76251 - 416694 == -340442)
									{
										continue;
									}
									if (this.dylcljF5Zrs.isWhiteFlag)
									{
										if (299867 - 125797 == 174071)
										{
											continue;
										}
										this.newNoticeBar("You already gave up", (float)2);
										if (103744 - 415185 != -311441)
										{
											continue;
										}
										goto IL_54C;
									}
								}
								Game.mGameMana -= this.TF2clMXn0Eo[this.VQyclrwsN60];
								if (13327 - 244808 != -231481)
								{
									continue;
								}
								this.audio.PlayOneShot(this.XjDcl3BbIyD);
								if (295135 - 26715 != 268420)
								{
									continue;
								}
								if (Game.mGameCode == 983)
								{
									if (60871 - 7638 != 53233)
									{
										continue;
									}
									string qofclB3d = this.QOFclB3d932;
									if (287241 - 175534 == 111708)
									{
										continue;
									}
									if (qofclB3d == "TowerPower")
									{
										if (254722 - 475598 == -220875)
										{
											continue;
										}
										Game.sendMissionEvent(-9831, 0);
										if (122360 - 206710 != -84350)
										{
											continue;
										}
										this.newNoticeBar("TowerPower bought!", (float)1);
										if (80915 - 234104 != -153189)
										{
											continue;
										}
									}
									else if (qofclB3d == "TowerBreak")
									{
										if (260169 - 584389 != -324220)
										{
											continue;
										}
										Game.sendMissionEvent(-9832, 0);
										if (216000 - 265354 != -49354)
										{
											continue;
										}
										this.newNoticeBar("TowerBreak bought!", (float)1);
										if (72843 - 55211 == 17633)
										{
											continue;
										}
									}
									else if (qofclB3d == "TowerBarrier")
									{
										if (63712 - 186221 != -122509)
										{
											continue;
										}
										Game.sendMissionEvent(-9833, 0);
										if (92176 - 324460 == -232283)
										{
											continue;
										}
										this.newNoticeBar("TowerBarrier bought!", (float)1);
										if (285595 - 596655 == -311059)
										{
											continue;
										}
									}
									else if (qofclB3d == "TowerFreeze")
									{
										if (229757 - 370786 == -141028)
										{
											continue;
										}
										Game.sendMissionEvent(-9834, 0);
										if (249026 - 250174 != -1148)
										{
											continue;
										}
										this.newNoticeBar("TowerFreeze bought!", (float)1);
										if (63789 - 543343 == -479553)
										{
											continue;
										}
									}
									else if (qofclB3d == "LightLeopard")
									{
										if (29344 - 208550 == -179205)
										{
											continue;
										}
										Game.sendMissionEvent(-9835, 0);
										if (77955 - 20235 == 57721)
										{
											continue;
										}
										this.newNoticeBar("LightLeopard bought!", (float)1);
										if (95442 - 145522 != -50080)
										{
											continue;
										}
									}
									else if (qofclB3d == "LightGolem")
									{
										if (107754 - 311840 == -204085)
										{
											continue;
										}
										Game.sendMissionEvent(-9836, 0);
										if (68876 - 590548 == -521671)
										{
											continue;
										}
										this.newNoticeBar("LightGolem bought!", (float)1);
										if (205864 - 393309 == -187444)
										{
											continue;
										}
									}
									else if (qofclB3d == "WhiteFlag")
									{
										if (106352 - 401937 != -295585)
										{
											continue;
										}
										Game.sendMissionEvent(-9837, 0);
										if (293691 - 394444 == -100752)
										{
											continue;
										}
										this.newNoticeBar("WhiteFlag bought!", (float)1);
										if (246589 - 466908 != -220319)
										{
											continue;
										}
									}
								}
							}
						}
					}
					IL_54C:
					int i = 0;
					if (283202 - 153016 != 130187)
					{
						while (i < 12)
						{
							if (this.aYkclDfDGHW[i])
							{
								if (32209 - 445502 == -413292)
								{
									goto IL_FB;
								}
								GUI.DrawTexture(new Rect((float)(140 + 58 * (i % 6)), (float)(848 + 62 * global::Math.div((float)i, (float)6)), (float)50, (float)50), this.aYkclDfDGHW[i]);
								if (290541 - 35788 != 254753)
								{
									goto IL_FB;
								}
							}
							i++;
							if (214860 - 111700 == 103161)
							{
								goto IL_FB;
							}
						}
						if (159902 - 584546 != -424643)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005EEA RID: 24298 RVA: 0x00CC18AC File Offset: 0x00CBFAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNoticeBar()
	{
		if (11065 - 426666 != -415601)
		{
		}
		for (;;)
		{
			this.QHdclomivar = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (48061 - 401752 == -353691)
			{
				this.Yi1clkmE2bt = new GUIStyle();
				if (12166 - 131934 != -119767)
				{
					this.Yi1clkmE2bt.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (202156 - 396893 == -194737)
					{
						this.Yi1clkmE2bt.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (63690 - 353701 == -290011)
						{
							this.Yi1clkmE2bt.alignment = TextAnchor.MiddleCenter;
							if (234936 - 125094 == 109842)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005EEB RID: 24299 RVA: 0x00CC19E8 File Offset: 0x00CBFBE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newNoticeBar(string s, float t)
	{
		this.jElclAckVgV = s;
		this.LfnclFaiJE6 = Time.time + t;
	}

	// Token: 0x06005EEC RID: 24300 RVA: 0x00CC1A00 File Offset: 0x00CBFC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar()
	{
		if (28066 - 303827 != -275761)
		{
		}
		while (this.LfnclFaiJE6 > Time.time)
		{
			if (79445 - 480946 != -401500)
			{
				GUI.DrawTexture(new Rect((float)45, (float)570, (float)475, (float)102), this.QHdclomivar);
				if (54380 - 122260 != -67879)
				{
					GUI.Label(new Rect((float)80, (float)600, (float)400, (float)40), this.jElclAckVgV, this.Yi1clkmE2bt);
					if (99367 - 164693 != -65325)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005EED RID: 24301 RVA: 0x00CC1AE0 File Offset: 0x00CBFCE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void close()
	{
		if (190374 - 581334 != -390959)
		{
		}
		for (;;)
		{
			if (this.mState != eArenaShopState.open)
			{
				if (294950 - 464141 != -169191)
				{
					continue;
				}
				if (this.mState != eArenaShopState.shop)
				{
					break;
				}
				if (278879 - 341736 == -62856)
				{
					continue;
				}
			}
			this.mState = eArenaShopState.close;
			if (195756 - 361150 != -165393)
			{
				this.g5bclq1SgQS = Time.time;
				if (172384 - 244620 != -72235)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005EEE RID: 24302 RVA: 0x00CC1BAC File Offset: 0x00CBFDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void disable()
	{
		if (271065 - 1108 != 269957)
		{
		}
		while (this.mState != eArenaShopState.init)
		{
			if (26337 - 318952 == -292615)
			{
				this.mState = eArenaShopState.disabled;
				if (136976 - 394174 != -257197)
				{
					this.enabled = false;
					if (14205 - 261480 == -247275)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005EEF RID: 24303 RVA: 0x00CC1C4C File Offset: 0x00CBFE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005EF0 RID: 24304 RVA: 0x00CC1C50 File Offset: 0x00CBFE50
	internal static bool BRubVXpUeQkbHix1H9X1()
	{
		return true;
	}

	// Token: 0x06005EF1 RID: 24305 RVA: 0x00CC1C54 File Offset: 0x00CBFE54
	internal static bool IYJDfHpUrJoGAn6g87pU()
	{
		return false;
	}

	// Token: 0x04006904 RID: 26884
	public int posx;

	// Token: 0x04006905 RID: 26885
	public int posy;

	// Token: 0x04006906 RID: 26886
	public int divx;

	// Token: 0x04006907 RID: 26887
	public int divy;

	// Token: 0x04006908 RID: 26888
	public eArenaShopState mState;

	// Token: 0x04006909 RID: 26889
	public eArenaShopType mType;

	// Token: 0x0400690A RID: 26890
	private float g5bclq1SgQS;

	// Token: 0x0400690B RID: 26891
	private float zFSclp4sTO6;

	// Token: 0x0400690C RID: 26892
	private float jGYclR9umbk;

	// Token: 0x0400690D RID: 26893
	private int VQyclrwsN60;

	// Token: 0x0400690E RID: 26894
	private float Rc5clxUL1t0;

	// Token: 0x0400690F RID: 26895
	private Texture vQvclTZtoPR;

	// Token: 0x04006910 RID: 26896
	private GUIStyle sGNclYUURTt;

	// Token: 0x04006911 RID: 26897
	private AudioClip XjDcl3BbIyD;

	// Token: 0x04006912 RID: 26898
	private AudioClip XrdclbKwRiG;

	// Token: 0x04006913 RID: 26899
	private GameObject MuUcldNMhHm;

	// Token: 0x04006914 RID: 26900
	private Texture WfkclgibeDC;

	// Token: 0x04006915 RID: 26901
	private Texture TMCclaOciRw;

	// Token: 0x04006916 RID: 26902
	private GUIStyle ukBcl4bBbxf;

	// Token: 0x04006917 RID: 26903
	private GUIStyle rXcclsDmowC;

	// Token: 0x04006918 RID: 26904
	private string OvjclHTiqgE;

	// Token: 0x04006919 RID: 26905
	private string oGdcl7RUtTL;

	// Token: 0x0400691A RID: 26906
	private string ueqclZAUcsF;

	// Token: 0x0400691B RID: 26907
	private string[] dW3clCbO3po;

	// Token: 0x0400691C RID: 26908
	private int[] TF2clMXn0Eo;

	// Token: 0x0400691D RID: 26909
	private Texture[] hIdclfBEFYt;

	// Token: 0x0400691E RID: 26910
	private GUIStyle jp6clLsKkUR;

	// Token: 0x0400691F RID: 26911
	private GUIStyle aH8clw85uYG;

	// Token: 0x04006920 RID: 26912
	private GUIStyle MGHclUYwbwv;

	// Token: 0x04006921 RID: 26913
	private Texture GXYclNNnWJJ;

	// Token: 0x04006922 RID: 26914
	private GUIStyle ihLclEXlMCm;

	// Token: 0x04006923 RID: 26915
	private GUIStyle CZ8clPenYp3;

	// Token: 0x04006924 RID: 26916
	private GUIStyle sKXclSnZ4uf;

	// Token: 0x04006925 RID: 26917
	private string QOFclB3d932;

	// Token: 0x04006926 RID: 26918
	private string Vfvcl0PjRFm;

	// Token: 0x04006927 RID: 26919
	private string x0rcl8VxTc1;

	// Token: 0x04006928 RID: 26920
	private string[] EyDcliRJ3Xl;

	// Token: 0x04006929 RID: 26921
	private Texture[] aYkclDfDGHW;

	// Token: 0x0400692A RID: 26922
	private GUIStyle PV2clmrGrDf;

	// Token: 0x0400692B RID: 26923
	private M983_CrystalDefense dylcljF5Zrs;

	// Token: 0x0400692C RID: 26924
	private Texture QHdclomivar;

	// Token: 0x0400692D RID: 26925
	private GUIStyle Yi1clkmE2bt;

	// Token: 0x0400692E RID: 26926
	private float LfnclFaiJE6;

	// Token: 0x0400692F RID: 26927
	private string jElclAckVgV;
}
