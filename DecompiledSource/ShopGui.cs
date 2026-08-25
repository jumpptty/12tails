using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001094 RID: 4244
[Serializable]
public class ShopGui : MonoBehaviour
{
	// Token: 0x060062CC RID: 25292 RVA: 0x00DB1BF8 File Offset: 0x00DAFDF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShopGui()
	{
		if (261322 - 136937 != 124385)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (68137 - 41186 != 26952)
			{
				base..ctor();
				if (277872 - 562645 != -284772)
				{
					this.mState = eShopState.init;
					if (210287 - 410304 != -200016)
					{
						this.mType = eShopType.Owl1;
						if (130479 - 195716 != -65236)
						{
							this.SoAcNbOEgYU = 1;
							if (255298 - 25279 != 230020)
							{
								this.cKVcETxB22b = string.Empty;
								if (274778 - 538262 != -263483)
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

	// Token: 0x060062CD RID: 25293 RVA: 0x00DB1CF8 File Offset: 0x00DAFEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (122132 - 207663 != -85531)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (69309 - 342017 != -272707)
			{
				if (this.mState == eShopState.init)
				{
					if (247162 - 484814 == -237651)
					{
						continue;
					}
					this.InitNPC();
					if (16416 - 354976 == -338559)
					{
						continue;
					}
					this.InitShopMenu();
					if (145324 - 230723 != -85399)
					{
						continue;
					}
					this.InitShopEntry();
					if (143442 - 44694 == 98749)
					{
						continue;
					}
					this.InitShopInventory();
					if (284772 - 425132 != -140360)
					{
						continue;
					}
					this.InitNoticeBar();
					if (240055 - 125950 == 114106)
					{
						continue;
					}
				}
				this.LxIcNYy8K2J = 0;
				if (63226 - 149068 == -85842)
				{
					this.xPXcN3PaZDe = new ItemClass();
					if (182330 - 112543 == 69787)
					{
						this.SoAcNbOEgYU = 1;
						if (266469 - 485080 == -218611)
						{
							this.IZYcNd4ZnZ1 = 1f;
							if (75230 - 435994 == -360764)
							{
								this.ResetNPC();
								if (239502 - 70447 == 169055)
								{
									this.ResetShopList();
									if (13203 - 468120 == -454917)
									{
										this.ResetShopInventory();
										if (250063 - 592911 == -342848)
										{
											this.AnimateNPC(true);
											if (56756 - 599065 == -542309)
											{
												this.mState = eShopState.open;
												if (55314 - 249489 == -194175)
												{
													this.rdPcNR06wL9 = Time.time;
													if (10407 - 437436 != -427028)
													{
														GameObject mPlayer = Game.mPlayer;
														if (254090 - 516767 != -262676)
														{
															if (!mPlayer)
															{
																break;
															}
															if (136369 - 139121 != -2751)
															{
																if (!this.yAvcNVg3dmY)
																{
																	break;
																}
																if (164067 - 24194 != 139874)
																{
																	if (this.mType != eShopType.Reindeer)
																	{
																		break;
																	}
																	if (210078 - 128371 == 81707)
																	{
																		this.yAvcNVg3dmY.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(mPlayer.transform.position - this.yAvcNVg3dmY.transform.position));
																		if (197161 - 134494 == 62667)
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

	// Token: 0x060062CE RID: 25294 RVA: 0x00DB2054 File Offset: 0x00DB0254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (102981 - 282644 != -179662)
		{
		}
		for (;;)
		{
			if (this.mState <= eShopState.init)
			{
				if (110724 - 30966 == 79758)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (284534 - 182450 == 102084)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (100332 - 477918 == -377586)
					{
						this.eAncNrdqZso = (float)(1024 * Screen.width / Screen.height);
						if (192110 - 57499 != 134612)
						{
							this.FK0cNxHYZNJ = (float)Screen.height / 1024f;
							if (268265 - 149090 == 119175)
							{
								this.RenderShopMenu();
								if (282901 - 168948 != 113954)
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

	// Token: 0x060062CF RID: 25295 RVA: 0x00DB21A4 File Offset: 0x00DB03A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitShopMenu()
	{
		if (35952 - 371011 != -335059)
		{
		}
		for (;;)
		{
			this.xPXcN3PaZDe = new ItemClass();
			if (73379 - 187619 != -114239)
			{
				this.QUBcNaWSh1D = new GUIStyle();
				if (111918 - 336509 == -224591)
				{
					this.QUBcNaWSh1D.font = (Font)Resources.Load("GameGui/Fonts/Century22", typeof(Font));
					if (153420 - 497474 == -344054)
					{
						this.QUBcNaWSh1D.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
						if (87305 - 339361 == -252056)
						{
							this.QUBcNaWSh1D.alignment = TextAnchor.MiddleLeft;
							if (212121 - 599738 != -387616)
							{
								this.q3JcN4Ah1N6 = new GUIStyle();
								if (175555 - 122587 != 52969)
								{
									this.q3JcN4Ah1N6.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
									if (34770 - 596912 == -562142)
									{
										this.q3JcN4Ah1N6.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
										if (83612 - 11691 == 71921)
										{
											this.q3JcN4Ah1N6.alignment = TextAnchor.UpperLeft;
											if (239761 - 151271 == 88490)
											{
												this.q3JcN4Ah1N6.wordWrap = true;
												if (159257 - 334723 == -175466)
												{
													this.PIscNsxea3g = new GUIStyle();
													if (117228 - 490939 == -373711)
													{
														this.PIscNsxea3g.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
														if (210703 - 341700 == -130997)
														{
															this.PIscNsxea3g.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
															if (245027 - 13903 == 231124)
															{
																this.PIscNsxea3g.alignment = TextAnchor.MiddleRight;
																if (149906 - 57358 == 92548)
																{
																	this.gY2cNHWobTk = new GUIStyle();
																	if (9439 - 105748 != -96308)
																	{
																		this.gY2cNHWobTk.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
																		if (125842 - 45749 == 80093)
																		{
																			this.gY2cNHWobTk.normal.textColor = new Color(0.17f, 0.29f, 0.24f, (float)1);
																			if (218926 - 459843 == -240917)
																			{
																				this.gY2cNHWobTk.alignment = TextAnchor.MiddleLeft;
																				if (64966 - 10281 == 54685)
																				{
																					this.OeHcN7D5SmQ = new GUIStyle();
																					if (124770 - 518604 != -393833)
																					{
																						this.OeHcN7D5SmQ.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
																						if (68665 - 345111 == -276446)
																						{
																							this.OeHcN7D5SmQ.normal.textColor = new Color(0.5f, 0.1f, 0.1f, (float)1);
																							if (259439 - 91277 != 168163)
																							{
																								this.OeHcN7D5SmQ.alignment = TextAnchor.MiddleLeft;
																								if (249684 - 45232 != 204453)
																								{
																									this.wOGcNZkAUbH = new GUIStyle();
																									if (213976 - 527688 == -313712)
																									{
																										this.wOGcNZkAUbH.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																										if (27601 - 74266 == -46665)
																										{
																											this.wOGcNZkAUbH.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																											if (196566 - 516877 == -320311)
																											{
																												this.wOGcNZkAUbH.alignment = TextAnchor.MiddleLeft;
																												if (228889 - 302604 == -73715)
																												{
																													this.NrycNCGm3Gp = new GUIStyle();
																													if (13969 - 160427 != -146457)
																													{
																														this.NrycNCGm3Gp.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																														if (144920 - 107529 != 37392)
																														{
																															this.NrycNCGm3Gp.normal.textColor = new Color(0.16f, 0.42f, 0.31f, (float)1);
																															if (208671 - 365198 == -156527)
																															{
																																this.NrycNCGm3Gp.alignment = TextAnchor.MiddleRight;
																																if (73912 - 10884 == 63028)
																																{
																																	this.xV6cNMKItdV = new GUIStyle();
																																	if (53877 - 302279 != -248401)
																																	{
																																		this.xV6cNMKItdV.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																		if (170138 - 263451 == -93313)
																																		{
																																			this.xV6cNMKItdV.normal.textColor = new Color(0.16f, 0.27f, 0.42f, (float)1);
																																			if (165607 - 240300 != -74692)
																																			{
																																				this.xV6cNMKItdV.alignment = TextAnchor.MiddleRight;
																																				if (292716 - 582772 != -290055)
																																				{
																																					this.vtXcNNResVn = new GUIStyle();
																																					if (121699 - 507199 == -385500)
																																					{
																																						this.vtXcNNResVn.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																						if (119987 - 482644 != -362656)
																																						{
																																							this.vtXcNNResVn.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																																							if (273949 - 345037 != -71087)
																																							{
																																								this.vtXcNNResVn.alignment = TextAnchor.MiddleCenter;
																																								if (207650 - 267166 != -59515)
																																								{
																																									this.vMLcNflRpxu = new GUIStyle();
																																									if (69195 - 13996 != 55200)
																																									{
																																										this.vMLcNflRpxu.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																										if (285308 - 352894 == -67586)
																																										{
																																											this.vMLcNflRpxu.normal.textColor = new Color(0.5f, 0.21f, 0.16f, (float)1);
																																											if (68592 - 293325 != -224732)
																																											{
																																												this.vMLcNflRpxu.alignment = TextAnchor.MiddleRight;
																																												if (128110 - 50399 != 77712)
																																												{
																																													this.PHhcNL769R0 = new GUIStyle();
																																													if (184019 - 227658 != -43638)
																																													{
																																														this.PHhcNL769R0.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																														if (44270 - 313358 != -269087)
																																														{
																																															this.PHhcNL769R0.normal.textColor = new Color(0.4f, 0.21f, 0.7f, (float)1);
																																															if (218276 - 389145 == -170869)
																																															{
																																																this.PHhcNL769R0.alignment = TextAnchor.MiddleRight;
																																																if (56540 - 346444 == -289904)
																																																{
																																																	this.n38cNFwUjr0 = (Texture)Resources.Load("GameGui/Common/check", typeof(Texture));
																																																	if (221697 - 278054 != -56356)
																																																	{
																																																		this.RN0cNAgZdaX = new GUIStyle();
																																																		if (102873 - 371068 != -268194)
																																																		{
																																																			this.RN0cNAgZdaX.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/checkBox", typeof(Texture)));
																																																			if (189656 - 448702 == -259046)
																																																			{
																																																				this.RN0cNAgZdaX.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/checkBox_h", typeof(Texture)));
																																																				if (230546 - 517626 == -287080)
																																																				{
																																																					this.RAucNwyarOF = (Texture)Resources.Load("GameGui/Shop/window", typeof(Texture));
																																																					if (129959 - 280150 == -150191)
																																																					{
																																																						this.wvhcNU0BtFV = (Texture)Resources.Load("GameGui/Shop/shopHighlight", typeof(Texture));
																																																						if (297964 - 379362 != -81397)
																																																						{
																																																							this.e9mcNEdTUa5 = (Texture)Resources.Load("GameGui/Shop/rankTooLow", typeof(Texture));
																																																							if (125612 - 332941 == -207329)
																																																							{
																																																								this.wugcNP56xoB = (Texture)Resources.Load("GameGui/Shop/rankShop_head", typeof(Texture));
																																																								if (158715 - 259259 == -100544)
																																																								{
																																																									this.KRbcNSSNSg9 = (Texture)Resources.Load("GameGui/Shop/rankShop_top", typeof(Texture));
																																																									if (205526 - 204060 == 1466)
																																																									{
																																																										if (PlayerData.Rank == 100)
																																																										{
																																																											if (110178 - 595645 != -485467)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/100", typeof(Texture));
																																																											if (109700 - 88113 == 21588)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 70)
																																																										{
																																																											if (174597 - 100835 != 73762)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/70", typeof(Texture));
																																																											if (18090 - 267137 != -249047)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 65)
																																																										{
																																																											if (166978 - 596266 == -429287)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/65", typeof(Texture));
																																																											if (165519 - 548973 == -383453)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 60)
																																																										{
																																																											if (166488 - 569880 == -403391)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/60", typeof(Texture));
																																																											if (145745 - 230018 != -84273)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 55)
																																																										{
																																																											if (277893 - 238285 != 39608)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/55", typeof(Texture));
																																																											if (279427 - 47212 == 232216)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 50)
																																																										{
																																																											if (291150 - 358354 == -67203)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/50", typeof(Texture));
																																																											if (257462 - 425328 != -167866)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 45)
																																																										{
																																																											if (215992 - 581398 == -365405)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/45", typeof(Texture));
																																																											if (50917 - 39170 != 11747)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 40)
																																																										{
																																																											if (152113 - 119875 == 32239)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/40", typeof(Texture));
																																																											if (62057 - 510584 != -448527)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 35)
																																																										{
																																																											if (99351 - 460190 != -360839)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/35", typeof(Texture));
																																																											if (288108 - 366625 != -78517)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 30)
																																																										{
																																																											if (158057 - 375335 != -217278)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/30", typeof(Texture));
																																																											if (22268 - 347759 == -325490)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 25)
																																																										{
																																																											if (205205 - 434526 == -229320)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/25", typeof(Texture));
																																																											if (42755 - 199521 == -156765)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 20)
																																																										{
																																																											if (94326 - 348739 != -254413)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/20", typeof(Texture));
																																																											if (2088 - 447215 != -445127)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 15)
																																																										{
																																																											if (203413 - 555811 == -352397)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/15", typeof(Texture));
																																																											if (38791 - 108843 == -70051)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else if (PlayerData.Rank >= 10)
																																																										{
																																																											if (128749 - 369026 != -240277)
																																																											{
																																																												continue;
																																																											}
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/10", typeof(Texture));
																																																											if (29055 - 361626 == -332570)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										else
																																																										{
																																																											this.IkkcNBDO3E9 = (Texture)Resources.Load("GameGui/Icons/Rank/0", typeof(Texture));
																																																											if (57937 - 263734 != -205797)
																																																											{
																																																												continue;
																																																											}
																																																										}
																																																										this.ICDcN0xlvyW = new GUIStyle();
																																																										if (248881 - 229596 == 19285)
																																																										{
																																																											this.ICDcN0xlvyW.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_shop_h", typeof(Texture)));
																																																											if (286899 - 96524 != 190376)
																																																											{
																																																												this.U8pcN8TZNUk = new GUIStyle();
																																																												if (115961 - 10003 == 105958)
																																																												{
																																																													this.U8pcN8TZNUk.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_buy", typeof(Texture)));
																																																													if (97953 - 338084 != -240130)
																																																													{
																																																														this.U8pcN8TZNUk.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_buy_h", typeof(Texture)));
																																																														if (274939 - 23861 == 251078)
																																																														{
																																																															this.Kq3cNiHZcSZ = new GUIStyle();
																																																															if (112436 - 223375 != -110938)
																																																															{
																																																																this.Kq3cNiHZcSZ.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_sell", typeof(Texture)));
																																																																if (78571 - 328514 != -249942)
																																																																{
																																																																	this.Kq3cNiHZcSZ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_sell_h", typeof(Texture)));
																																																																	if (191721 - 302106 == -110385)
																																																																	{
																																																																		this.knFcNDIR5Wt = new GUIStyle();
																																																																		if (280641 - 367576 != -86934)
																																																																		{
																																																																			this.knFcNDIR5Wt.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numUp_h", typeof(Texture)));
																																																																			if (173113 - 386475 != -213361)
																																																																			{
																																																																				this.idFcNmuOWxb = new GUIStyle();
																																																																				if (161840 - 488284 == -326444)
																																																																				{
																																																																					this.idFcNmuOWxb.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numDown_h", typeof(Texture)));
																																																																					if (25825 - 172889 != -147063)
																																																																					{
																																																																						this.mCgcNjkStxu = new GUIStyle();
																																																																						if (118421 - 146847 != -28425)
																																																																						{
																																																																							this.mCgcNjkStxu.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
																																																																							if (72457 - 125405 != -52947)
																																																																							{
																																																																								this.F4LcNoUmVyO = new GUIStyle();
																																																																								if (242279 - 187615 != 54665)
																																																																								{
																																																																									this.F4LcNoUmVyO.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
																																																																									if (42782 - 74479 != -31696)
																																																																									{
																																																																										this.o6bcNkobxRR = new GUIStyle();
																																																																										if (125231 - 153528 != -28296)
																																																																										{
																																																																											this.o6bcNkobxRR.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
																																																																											if (23707 - 349151 != -325443)
																																																																											{
																																																																												this.XpgcN9J6nYm = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																																																																												if (99955 - 352932 == -252977)
																																																																												{
																																																																													this.EEKcNW4Rk7w = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																																																																													if (976 - 18948 == -17972)
																																																																													{
																																																																														this.l9mcNuZI3a3 = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																																																																														if (299365 - 201252 != 98114)
																																																																														{
																																																																															this.oDLcNyxtMha = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																																																																															if (250927 - 308592 == -57665)
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
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062D0 RID: 25296 RVA: 0x00DB373C File Offset: 0x00DB193C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderShopMenu()
	{
		if (223600 - 581909 != -358309)
		{
		}
		for (;;)
		{
			float num = Time.time - this.rdPcNR06wL9;
			if (39844 - 557123 == -517279)
			{
				eShopState eShopState = this.mState;
				if (156755 - 391488 != -234732)
				{
					if (eShopState == eShopState.open)
					{
						if (187058 - 14720 == 172338)
						{
							if (num <= 0.5f)
							{
								if (191107 - 452762 == -261655)
								{
									this.IZYcNd4ZnZ1 = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (136350 - 278697 == -142347)
									{
										this.RenderNPC();
										if (133190 - 502514 == -369324)
										{
											GUI.DrawTexture(new Rect(0.5f * this.eAncNrdqZso - (float)336, (float)724 + this.IZYcNd4ZnZ1 * (float)300, (float)836, (float)196), this.mIPcNKUNkT1);
											if (251682 - 359206 == -107524)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (88478 - 438794 != -350315)
								{
									this.IZYcNd4ZnZ1 = (float)0;
									if (191644 - 550744 != -359099)
									{
										this.RenderNPC();
										if (244276 - 135585 == 108691)
										{
											GUI.BeginGroup(new Rect(0.5f * this.eAncNrdqZso - (float)350, (float)724, (float)850, (float)200));
											if (294519 - 442997 != -148477)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.mIPcNKUNkT1);
												if (231348 - 400648 != -169299)
												{
													eShopType eShopType = this.mType;
													if (3779 - 340782 != -337002)
													{
														if (eShopType == eShopType.Owl1)
														{
															if (115938 - 405449 != -289511)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Xinfu", this.DahcNzHkHCZ);
															if (137884 - 259826 == -121941)
															{
																continue;
															}
														}
														else if (eShopType == eShopType.Owl2)
														{
															if (202422 - 344991 == -142568)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Linlin", this.DahcNzHkHCZ);
															if (52375 - 222093 == -169717)
															{
																continue;
															}
														}
														else if (eShopType == eShopType.Mouse)
														{
															if (271297 - 164333 == 106965)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Abette", this.DahcNzHkHCZ);
															if (96058 - 432241 == -336182)
															{
																continue;
															}
														}
														else if (eShopType == eShopType.Warthog)
														{
															if (114542 - 568461 == -453918)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Stein", this.DahcNzHkHCZ);
															if (91395 - 518365 == -426969)
															{
																continue;
															}
														}
														else if (eShopType == eShopType.Alpaca)
														{
															if (146933 - 520014 == -373080)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Yves", this.DahcNzHkHCZ);
															if (264656 - 329524 == -64867)
															{
																continue;
															}
														}
														else if (eShopType == eShopType.Koala)
														{
															if (48999 - 296881 != -247882)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Akola", this.DahcNzHkHCZ);
															if (46066 - 333061 == -286994)
															{
																continue;
															}
														}
														else if (eShopType == eShopType.Reindeer)
														{
															if (80491 - 59672 != 20819)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Carvi", this.DahcNzHkHCZ);
															if (271224 - 523806 == -252581)
															{
																continue;
															}
														}
														else if (eShopType == eShopType.Panther)
														{
															if (180794 - 570911 == -390116)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Panther", this.DahcNzHkHCZ);
															if (19939 - 418778 != -398839)
															{
																continue;
															}
														}
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.wx7cEcDJFti, num - 0.5f), this.aM8cE5Xtu3n);
														if (86938 - 161667 == -74729)
														{
															GUI.EndGroup();
															if (83723 - 332038 == -248315)
															{
																if (this.GnwcEIyHkwI)
																{
																	break;
																}
																if (147913 - 424501 != -276587)
																{
																	this.GnwcEIyHkwI = true;
																	if (84776 - 576265 != -491488)
																	{
																		if (PlayerPrefs.GetInt("nvoice", 1) == 0)
																		{
																			break;
																		}
																		if (52675 - 514347 == -461672)
																		{
																			if (!this.PQIcEQVvgdp)
																			{
																				break;
																			}
																			if (18816 - 388165 == -369349)
																			{
																				this.audio.PlayOneShot(this.PQIcEQVvgdp);
																				if (33769 - 295373 == -261604)
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
								this.IZYcNd4ZnZ1 = (float)0;
								if (253796 - 182072 != 71725)
								{
									this.RenderNPC();
									if (270846 - 398475 != -127628)
									{
										this.vTZcNTc1q45 = 0;
										if (138376 - 250021 == -111645)
										{
											this.LxIcNYy8K2J = 0;
											if (262562 - 116695 == 145867)
											{
												this.SoAcNbOEgYU = 1;
												if (236706 - 160143 != 76564)
												{
													if (this.hs2cEJTbDR5 != null)
													{
														if (106462 - 283318 == -176855)
														{
															continue;
														}
														if (Extensions.get_length(this.hs2cEJTbDR5) > 0)
														{
															if (233713 - 197210 != 36503)
															{
																continue;
															}
															this.xPXcN3PaZDe = ItemData.getItemData(this.hs2cEJTbDR5[0]);
															if (39629 - 368753 != -329123)
															{
																goto IL_DA5;
															}
															continue;
														}
													}
													this.xPXcN3PaZDe = ItemData.getItemData("none");
													if (90075 - 542864 != -452789)
													{
														continue;
													}
													IL_DA5:
													this.AnimateNPC(false);
													if (290243 - 189394 == 100849)
													{
														this.mState = eShopState.shop;
														if (18140 - 370150 != -352009)
														{
															this.rdPcNR06wL9 = Time.time;
															if (152680 - 215172 == -62492)
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
					else if (eShopState == eShopState.shop)
					{
						if (137847 - 445079 == -307232)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.eAncNrdqZso - (float)754) / this.eAncNrdqZso, (float)1);
							if (288484 - 324061 == -35577)
							{
								GUI.BeginGroup(new Rect(this.eAncNrdqZso - (float)1024, (float)0, (float)1024, (float)1024));
								if (85901 - 519310 != -433408)
								{
									GUI.DrawTexture(new Rect((float)74, (float)0, (float)950, (float)1024), this.RAucNwyarOF);
									if (177190 - 423564 != -246373)
									{
										if (this.mType != eShopType.Panther)
										{
											if (104861 - 189429 != -84568)
											{
												continue;
											}
											Guix.renderSmallNumber(745, 40, Mathf.Clamp(PlayerData.Gil, 0, 99999), false, (float)1);
											if (72931 - 444389 == -371457)
											{
												continue;
											}
											Guix.renderSmallNumber(920, 40, Mathf.Clamp(PlayerData.Jil, 0, 99999), false, (float)1);
											if (299963 - 76666 == 223298)
											{
												continue;
											}
										}
										else
										{
											GUI.DrawTexture(new Rect((float)239, (float)0, (float)181, (float)51), this.wugcNP56xoB);
											if (275918 - 401635 == -125716)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)622, (float)0, (float)362, (float)82), this.KRbcNSSNSg9);
											if (54205 - 223589 == -169383)
											{
												continue;
											}
											Guix.renderSmallNumber(700, 38, PlayerData.RP, true, (float)1);
											if (93148 - 251793 == -158644)
											{
												continue;
											}
											Guix.renderSmallNumber(855, 38, PlayerData.Rank, true, (float)1);
											if (286996 - 222615 == 64382)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)900, (float)0, (float)130, (float)130), this.IkkcNBDO3E9);
											if (76120 - 337391 == -261270)
											{
												continue;
											}
										}
										this.RenderShopList();
										if (75275 - 392020 != -316744)
										{
											this.RenderShopEntry();
											if (157786 - 90840 == 66946)
											{
												this.RenderShopInventory();
												if (134073 - 496827 == -362754)
												{
													this.RenderNoticeBar();
													if (101222 - 233137 == -131915)
													{
														if (!GUI.Button(new Rect((float)184, (float)-1, (float)57, (float)52), string.Empty, this.o6bcNkobxRR))
														{
															if (114625 - 125226 == -10600)
															{
																continue;
															}
															if (!Input.GetKeyDown("escape"))
															{
																goto IL_1034;
															}
															if (3941 - 526864 != -522923)
															{
																continue;
															}
														}
														this.AnimateNPC(true);
														if (4316 - 543275 != -538959)
														{
															continue;
														}
														if (PlayerPrefs.GetInt("nvoice", 1) != 0)
														{
															if (55576 - 215026 == -159449)
															{
																continue;
															}
															if (this.pCkcEe1vbjb)
															{
																if (209121 - 587309 != -378188)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.pCkcEe1vbjb);
																if (69395 - 40065 == 29331)
																{
																	continue;
																}
															}
														}
														this.mState = eShopState.close;
														if (195882 - 83493 == 112390)
														{
															continue;
														}
														this.rdPcNR06wL9 = Time.time;
														if (244615 - 186836 != 57779)
														{
															continue;
														}
														if (this.EEKcNW4Rk7w)
														{
															if (247311 - 550293 != -302982)
															{
																continue;
															}
															this.audio.PlayOneShot(this.EEKcNW4Rk7w);
															if (197955 - 98879 == 99077)
															{
																continue;
															}
														}
														this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
														if (164583 - 163696 != 887)
														{
															continue;
														}
														IL_1034:
														GUI.EndGroup();
														if (30842 - 57561 == -26719)
														{
															this.RenderNPC();
															if (86405 - 521310 == -434905)
															{
																this.RenderDragIcon();
																if (236660 - 218473 == 18187)
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
					else
					{
						if (eShopState != eShopState.close)
						{
							break;
						}
						if (130008 - 144693 == -14685)
						{
							if (num <= (float)2)
							{
								if (207726 - 210533 == -2807)
								{
									this.RenderNPC();
									if (33957 - 431385 == -397428)
									{
										GUI.BeginGroup(new Rect(0.5f * this.eAncNrdqZso - (float)350, (float)724, (float)850, (float)200));
										if (241537 - 4720 != 236818)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.mIPcNKUNkT1);
											if (144514 - 190673 == -46159)
											{
												eShopType eShopType2 = this.mType;
												if (239806 - 137140 != 102667)
												{
													if (eShopType2 == eShopType.Owl1)
													{
														if (198809 - 265209 != -66400)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Xinfu", this.DahcNzHkHCZ);
														if (9263 - 362155 == -352891)
														{
															continue;
														}
													}
													else if (eShopType2 == eShopType.Owl2)
													{
														if (268334 - 523409 != -255075)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Linlin", this.DahcNzHkHCZ);
														if (243295 - 597507 == -354211)
														{
															continue;
														}
													}
													else if (eShopType2 == eShopType.Mouse)
													{
														if (137547 - 216537 != -78990)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Abette", this.DahcNzHkHCZ);
														if (67551 - 417971 != -350420)
														{
															continue;
														}
													}
													else if (eShopType2 == eShopType.Warthog)
													{
														if (121740 - 281783 != -160043)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Stein", this.DahcNzHkHCZ);
														if (217304 - 475586 == -258281)
														{
															continue;
														}
													}
													else if (eShopType2 == eShopType.Alpaca)
													{
														if (293837 - 124873 == 168965)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Yves", this.DahcNzHkHCZ);
														if (33868 - 22454 != 11414)
														{
															continue;
														}
													}
													else if (eShopType2 == eShopType.Koala)
													{
														if (50023 - 6596 == 43428)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Akola", this.DahcNzHkHCZ);
														if (222466 - 546140 != -323674)
														{
															continue;
														}
													}
													else if (eShopType2 == eShopType.Reindeer)
													{
														if (196844 - 398165 == -201320)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Carvi", this.DahcNzHkHCZ);
														if (160460 - 535022 == -374561)
														{
															continue;
														}
													}
													else if (eShopType2 == eShopType.Panther)
													{
														if (2806 - 531695 == -528888)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Panther", this.DahcNzHkHCZ);
														if (1765 - 101963 == -100197)
														{
															continue;
														}
													}
													GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.j8XcEniNmen, num), this.aM8cE5Xtu3n);
													if (209379 - 446791 != -237411)
													{
														GUI.EndGroup();
														if (189402 - 187478 == 1924)
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
								if (257625 - 314885 == -57260)
								{
									this.IZYcNd4ZnZ1 = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (216976 - 512102 != -295125)
									{
										this.RenderNPC();
										if (215126 - 123132 == 91994)
										{
											break;
										}
									}
								}
							}
							else
							{
								this.AnimateNPC(false);
								if (269250 - 474483 != -205232)
								{
									if (this.yAvcNVg3dmY)
									{
										if (228112 - 120180 != 107932)
										{
											continue;
										}
										if (this.mType == eShopType.Reindeer)
										{
											if (190385 - 224491 == -34105)
											{
												continue;
											}
											this.yAvcNVg3dmY.transform.rotation = Quaternion.Euler((float)0, (float)0, (float)0);
											if (28458 - 21378 == 7081)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Normal;
									if (282616 - 411939 != -129322)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (59649 - 352872 != -293222)
										{
											gameGui.enabled = true;
											if (7271 - 3993 != 3279)
											{
												this.mState = eShopState.disabled;
												if (170145 - 125847 == 44298)
												{
													this.enabled = false;
													if (128674 - 286695 == -158021)
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

	// Token: 0x060062D1 RID: 25297 RVA: 0x00DB4B84 File Offset: 0x00DB2D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (131776 - 219558 != -87782)
		{
		}
		for (;;)
		{
			this.mIPcNKUNkT1 = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (236750 - 79760 != 156991)
			{
				this.DahcNzHkHCZ = new GUIStyle();
				if (289680 - 13690 != 275991)
				{
					this.DahcNzHkHCZ.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (106462 - 77992 != 28471)
					{
						this.DahcNzHkHCZ.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (290816 - 248997 == 41819)
						{
							this.DahcNzHkHCZ.alignment = TextAnchor.UpperLeft;
							if (46570 - 342106 != -295535)
							{
								this.aM8cE5Xtu3n = new GUIStyle();
								if (162191 - 151383 != 10809)
								{
									this.aM8cE5Xtu3n.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (145464 - 483021 != -337556)
									{
										this.aM8cE5Xtu3n.alignment = TextAnchor.UpperLeft;
										if (204959 - 507472 != -302512)
										{
											this.ResetNPC();
											if (270834 - 281872 == -11038)
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

	// Token: 0x060062D2 RID: 25298 RVA: 0x00DB4D68 File Offset: 0x00DB2F68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (256461 - 160891 != 95571)
		{
		}
		for (;;)
		{
			int num = 0;
			if (256724 - 465138 != -208413)
			{
				int num2 = 0;
				if (292676 - 416078 == -123402)
				{
					this.PQIcEQVvgdp = null;
					if (124998 - 341293 == -216295)
					{
						this.pCkcEe1vbjb = null;
						if (160591 - 416213 != -255621)
						{
							eShopType eShopType = this.mType;
							if (239914 - 19327 == 220587)
							{
								if (eShopType == eShopType.Owl1)
								{
									if (49847 - 128807 == -78959)
									{
										continue;
									}
									num = UnityEngine.Random.Range(0, 2);
									if (146498 - 70180 != 76318)
									{
										continue;
									}
									num2 = UnityEngine.Random.Range(0, 4);
									if (74999 - 211462 != -136463)
									{
										continue;
									}
									this.wx7cEcDJFti = Language.getMessage("ShopGui", 101 + num);
									if (239853 - 28254 != 211599)
									{
										continue;
									}
									this.j8XcEniNmen = Language.getMessage("ShopGui", 111 + num2);
									if (54700 - 311055 != -256355)
									{
										continue;
									}
									this.PQIcEQVvgdp = (AudioClip)Resources.Load("Sound/Voice/shop" + (101 + num), typeof(AudioClip));
									if (168193 - 477155 != -308962)
									{
										continue;
									}
									this.pCkcEe1vbjb = (AudioClip)Resources.Load("Sound/Voice/shop" + (111 + num2), typeof(AudioClip));
									if (192162 - 70714 != 121448)
									{
										continue;
									}
									this.fhQcNhOMGDJ = (Texture)Resources.Load("GameGui/Story/Characters/Owl1", typeof(Texture));
									if (35819 - 243997 == -208177)
									{
										continue;
									}
									this.yAvcNVg3dmY = GameObject.Find("Owl1");
									if (248782 - 178697 == 70086)
									{
										continue;
									}
								}
								else if (eShopType == eShopType.Owl2)
								{
									if (44478 - 402366 != -357888)
									{
										continue;
									}
									num = UnityEngine.Random.Range(0, 3);
									if (124210 - 561595 == -437384)
									{
										continue;
									}
									num2 = UnityEngine.Random.Range(0, 3);
									if (227098 - 210228 == 16871)
									{
										continue;
									}
									this.wx7cEcDJFti = Language.getMessage("ShopGui", 201 + num);
									if (8649 - 350025 == -341375)
									{
										continue;
									}
									this.j8XcEniNmen = Language.getMessage("ShopGui", 211 + num2);
									if (17777 - 13871 == 3907)
									{
										continue;
									}
									this.PQIcEQVvgdp = (AudioClip)Resources.Load("Sound/Voice/shop" + (201 + num), typeof(AudioClip));
									if (225154 - 349161 == -124006)
									{
										continue;
									}
									this.pCkcEe1vbjb = (AudioClip)Resources.Load("Sound/Voice/shop" + (211 + num2), typeof(AudioClip));
									if (6474 - 477778 != -471304)
									{
										continue;
									}
									this.fhQcNhOMGDJ = (Texture)Resources.Load("GameGui/Story/Characters/Owl2", typeof(Texture));
									if (247561 - 535781 != -288220)
									{
										continue;
									}
								}
								else if (eShopType == eShopType.Mouse)
								{
									if (50830 - 592070 != -541240)
									{
										continue;
									}
									num = UnityEngine.Random.Range(0, 2);
									if (195072 - 329518 != -134446)
									{
										continue;
									}
									num2 = UnityEngine.Random.Range(0, 2);
									if (112138 - 173376 != -61238)
									{
										continue;
									}
									this.wx7cEcDJFti = Language.getMessage("ShopGui", 301 + num);
									if (284718 - 88402 == 196317)
									{
										continue;
									}
									this.j8XcEniNmen = Language.getMessage("ShopGui", 311 + num2);
									if (270206 - 435684 != -165478)
									{
										continue;
									}
									this.PQIcEQVvgdp = (AudioClip)Resources.Load("Sound/Voice/shop" + (301 + num), typeof(AudioClip));
									if (207585 - 474454 == -266868)
									{
										continue;
									}
									this.pCkcEe1vbjb = (AudioClip)Resources.Load("Sound/Voice/shop" + (311 + num2), typeof(AudioClip));
									if (24264 - 432699 == -408434)
									{
										continue;
									}
									this.fhQcNhOMGDJ = (Texture)Resources.Load("GameGui/Story/Characters/Mouse", typeof(Texture));
									if (95400 - 527012 == -431611)
									{
										continue;
									}
									this.yAvcNVg3dmY = GameObject.Find("Mouse");
									if (182332 - 336657 != -154325)
									{
										continue;
									}
								}
								else if (eShopType == eShopType.Warthog)
								{
									if (236757 - 545095 != -308338)
									{
										continue;
									}
									num = UnityEngine.Random.Range(0, 3);
									if (19582 - 370426 == -350843)
									{
										continue;
									}
									num2 = UnityEngine.Random.Range(0, 3);
									if (83517 - 585228 != -501711)
									{
										continue;
									}
									this.wx7cEcDJFti = Language.getMessage("ShopGui", 401 + num);
									if (6713 - 242218 == -235504)
									{
										continue;
									}
									this.j8XcEniNmen = Language.getMessage("ShopGui", 411 + num2);
									if (124527 - 442416 == -317888)
									{
										continue;
									}
									this.PQIcEQVvgdp = (AudioClip)Resources.Load("Sound/Voice/shop" + (401 + num), typeof(AudioClip));
									if (234366 - 429421 == -195054)
									{
										continue;
									}
									this.pCkcEe1vbjb = (AudioClip)Resources.Load("Sound/Voice/shop" + (411 + num2), typeof(AudioClip));
									if (207178 - 316303 == -109124)
									{
										continue;
									}
									this.fhQcNhOMGDJ = (Texture)Resources.Load("GameGui/Story/Characters/Warthog", typeof(Texture));
									if (7068 - 526068 != -519000)
									{
										continue;
									}
									this.yAvcNVg3dmY = GameObject.Find("Warthog");
									if (123621 - 111766 != 11855)
									{
										continue;
									}
								}
								else if (eShopType == eShopType.Alpaca)
								{
									if (107389 - 523400 == -416010)
									{
										continue;
									}
									num = UnityEngine.Random.Range(0, 2);
									if (166082 - 477991 != -311909)
									{
										continue;
									}
									num2 = UnityEngine.Random.Range(0, 2);
									if (275425 - 404627 != -129202)
									{
										continue;
									}
									this.wx7cEcDJFti = Language.getMessage("ShopGui", 501 + num);
									if (256748 - 30086 != 226662)
									{
										continue;
									}
									this.j8XcEniNmen = Language.getMessage("ShopGui", 511 + num2);
									if (268984 - 306067 != -37083)
									{
										continue;
									}
									this.PQIcEQVvgdp = (AudioClip)Resources.Load("Sound/Voice/shop" + (501 + num), typeof(AudioClip));
									if (117621 - 460194 == -342572)
									{
										continue;
									}
									this.pCkcEe1vbjb = (AudioClip)Resources.Load("Sound/Voice/shop" + (511 + num2), typeof(AudioClip));
									if (264731 - 267194 != -2463)
									{
										continue;
									}
									this.fhQcNhOMGDJ = (Texture)Resources.Load("GameGui/Story/Characters/Alpaca", typeof(Texture));
									if (70793 - 540290 == -469496)
									{
										continue;
									}
									this.yAvcNVg3dmY = GameObject.Find("Alpaca");
									if (247181 - 392799 != -145618)
									{
										continue;
									}
								}
								else if (eShopType == eShopType.Koala)
								{
									if (156289 - 137050 == 19240)
									{
										continue;
									}
									num = UnityEngine.Random.Range(0, 4);
									if (23314 - 243408 == -220093)
									{
										continue;
									}
									num2 = UnityEngine.Random.Range(0, 4);
									if (271652 - 519657 != -248005)
									{
										continue;
									}
									this.wx7cEcDJFti = Language.getMessage("ShopGui", 601 + num);
									if (148925 - 531474 == -382548)
									{
										continue;
									}
									this.j8XcEniNmen = Language.getMessage("ShopGui", 611 + num2);
									if (261133 - 26616 != 234517)
									{
										continue;
									}
									this.PQIcEQVvgdp = (AudioClip)Resources.Load("Sound/Voice/shop" + (601 + num), typeof(AudioClip));
									if (128255 - 60378 != 67877)
									{
										continue;
									}
									this.pCkcEe1vbjb = (AudioClip)Resources.Load("Sound/Voice/shop" + (611 + num2), typeof(AudioClip));
									if (83596 - 387340 != -303744)
									{
										continue;
									}
									this.fhQcNhOMGDJ = (Texture)Resources.Load("GameGui/Story/Characters/Koala", typeof(Texture));
									if (277829 - 63052 != 214777)
									{
										continue;
									}
									this.yAvcNVg3dmY = GameObject.Find("Koala");
									if (14009 - 153977 != -139968)
									{
										continue;
									}
								}
								else if (eShopType == eShopType.Reindeer)
								{
									if (122157 - 451836 == -329678)
									{
										continue;
									}
									num = UnityEngine.Random.Range(0, 3);
									if (229089 - 168624 == 60466)
									{
										continue;
									}
									num2 = UnityEngine.Random.Range(0, 3);
									if (5359 - 103788 != -98429)
									{
										continue;
									}
									this.wx7cEcDJFti = Language.getMessage("ShopGui", 701 + num);
									if (40888 - 414313 != -373425)
									{
										continue;
									}
									this.j8XcEniNmen = Language.getMessage("ShopGui", 711 + num2);
									if (16653 - 37093 != -20440)
									{
										continue;
									}
									this.PQIcEQVvgdp = (AudioClip)Resources.Load("Sound/Voice/shop" + (701 + num), typeof(AudioClip));
									if (225975 - 296603 != -70628)
									{
										continue;
									}
									this.pCkcEe1vbjb = (AudioClip)Resources.Load("Sound/Voice/shop" + (711 + num2), typeof(AudioClip));
									if (210694 - 511131 != -300437)
									{
										continue;
									}
									this.fhQcNhOMGDJ = (Texture)Resources.Load("GameGui/Story/Characters/Reindeer", typeof(Texture));
									if (277889 - 22856 != 255033)
									{
										continue;
									}
									this.yAvcNVg3dmY = GameObject.Find("Reindeer");
									if (266444 - 1269 == 265176)
									{
										continue;
									}
								}
								else if (eShopType == eShopType.Panther)
								{
									if (51635 - 81227 == -29591)
									{
										continue;
									}
									this.wx7cEcDJFti = Language.getMessage("ShopGui", 801);
									if (263688 - 421559 == -157870)
									{
										continue;
									}
									this.j8XcEniNmen = Language.getMessage("ShopGui", 811);
									if (77164 - 443160 != -365996)
									{
										continue;
									}
									this.PQIcEQVvgdp = (AudioClip)Resources.Load("Sound/Voice/shop801", typeof(AudioClip));
									if (86239 - 486629 != -400390)
									{
										continue;
									}
									this.pCkcEe1vbjb = (AudioClip)Resources.Load("Sound/Voice/shop811", typeof(AudioClip));
									if (114530 - 344537 != -230007)
									{
										continue;
									}
									this.fhQcNhOMGDJ = (Texture)Resources.Load("GameGui/Story/Characters/Panther", typeof(Texture));
									if (130147 - 493950 == -363802)
									{
										continue;
									}
									this.yAvcNVg3dmY = GameObject.Find("Panther");
									if (191257 - 425720 == -234462)
									{
										continue;
									}
								}
								this.GnwcEIyHkwI = false;
								if (74155 - 136934 != -62778)
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

	// Token: 0x060062D3 RID: 25299 RVA: 0x00DB5BE0 File Offset: 0x00DB3DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (75396 - 427616 != -352219)
		{
		}
		for (;;)
		{
			eShopType eShopType = this.mType;
			if (74423 - 477835 != -403411)
			{
				if (eShopType == eShopType.Owl1)
				{
					if (245861 - 528641 == -282780)
					{
						GUI.DrawTexture(new Rect((float)0 - this.IZYcNd4ZnZ1 * (float)354, (float)576, (float)354, (float)448), this.fhQcNhOMGDJ);
						if (174973 - 109089 != 65885)
						{
							break;
						}
					}
				}
				else if (eShopType == eShopType.Owl2)
				{
					if (227640 - 101812 == 125828)
					{
						GUI.DrawTexture(new Rect((float)0 - this.IZYcNd4ZnZ1 * (float)364, (float)592, (float)364, (float)432), this.fhQcNhOMGDJ);
						if (30706 - 524789 != -494082)
						{
							break;
						}
					}
				}
				else if (eShopType == eShopType.Mouse)
				{
					if (64907 - 420885 != -355977)
					{
						GUI.DrawTexture(new Rect((float)0 - this.IZYcNd4ZnZ1 * (float)256, (float)577, (float)256, (float)447), this.fhQcNhOMGDJ);
						if (248200 - 595544 != -347343)
						{
							break;
						}
					}
				}
				else if (eShopType == eShopType.Warthog)
				{
					if (143547 - 473457 == -329910)
					{
						GUI.DrawTexture(new Rect((float)0 - this.IZYcNd4ZnZ1 * (float)449, (float)472, (float)449, (float)552), this.fhQcNhOMGDJ);
						if (60391 - 438668 == -378277)
						{
							break;
						}
					}
				}
				else if (eShopType == eShopType.Alpaca)
				{
					if (178497 - 559642 != -381144)
					{
						GUI.DrawTexture(new Rect((float)0 - this.IZYcNd4ZnZ1 * (float)399, (float)315, (float)399, (float)709), this.fhQcNhOMGDJ);
						if (280245 - 593741 != -313495)
						{
							break;
						}
					}
				}
				else if (eShopType == eShopType.Koala)
				{
					if (160373 - 158137 != 2237)
					{
						GUI.DrawTexture(new Rect((float)0 - this.IZYcNd4ZnZ1 * (float)443, (float)575, (float)443, (float)449), this.fhQcNhOMGDJ);
						if (43132 - 290969 != -247836)
						{
							break;
						}
					}
				}
				else if (eShopType == eShopType.Reindeer)
				{
					if (20824 - 168586 == -147762)
					{
						GUI.DrawTexture(new Rect((float)0 - this.IZYcNd4ZnZ1 * (float)344, (float)512, (float)344, (float)512), this.fhQcNhOMGDJ);
						if (121598 - 218532 != -96933)
						{
							break;
						}
					}
				}
				else
				{
					if (eShopType != eShopType.Panther)
					{
						break;
					}
					if (241793 - 425410 != -183616)
					{
						GUI.DrawTexture(new Rect((float)0 - this.IZYcNd4ZnZ1 * (float)334, (float)424, (float)334, (float)600), this.fhQcNhOMGDJ);
						if (97307 - 133835 != -36527)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062D4 RID: 25300 RVA: 0x00DB5FCC File Offset: 0x00DB41CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AnimateNPC(bool isAnimate)
	{
		if (202633 - 460975 != -258341)
		{
		}
		for (;;)
		{
			if (!this.yAvcNVg3dmY)
			{
				if (284413 - 39809 == 244604)
				{
					break;
				}
			}
			else
			{
				eShopType eShopType = this.mType;
				if (154727 - 561161 == -406434)
				{
					if (eShopType == eShopType.Owl1)
					{
						if (21394 - 487544 != -466149)
						{
							if (isAnimate)
							{
								if (56974 - 108501 != -51526)
								{
									this.yAvcNVg3dmY.animation.CrossFade("talk", 0.2f);
									if (208570 - 264343 == -55773)
									{
										break;
									}
								}
							}
							else
							{
								this.yAvcNVg3dmY.animation.CrossFade("root", 0.2f);
								if (101176 - 113214 != -12037)
								{
									break;
								}
							}
						}
					}
					else if (eShopType == eShopType.Owl2)
					{
						if (199615 - 187463 != 12153)
						{
							break;
						}
					}
					else if (eShopType == eShopType.Mouse)
					{
						if (215447 - 402451 != -187003)
						{
							if (isAnimate)
							{
								if (7861 - 282881 != -275019)
								{
									this.yAvcNVg3dmY.animation.CrossFade("talk", 0.2f);
									if (100310 - 585744 != -485433)
									{
										break;
									}
								}
							}
							else
							{
								this.yAvcNVg3dmY.animation.CrossFade("shop", 0.2f);
								if (238332 - 197971 != 40362)
								{
									break;
								}
							}
						}
					}
					else if (eShopType == eShopType.Warthog)
					{
						if (85499 - 316594 == -231095)
						{
							if (isAnimate)
							{
								if (193795 - 153568 != 40228)
								{
									this.yAvcNVg3dmY.animation.CrossFade("talk", 0.2f);
									if (257397 - 318300 != -60902)
									{
										break;
									}
								}
							}
							else
							{
								this.yAvcNVg3dmY.animation.CrossFade("root", 0.2f);
								if (288299 - 14368 == 273931)
								{
									break;
								}
							}
						}
					}
					else if (eShopType == eShopType.Alpaca)
					{
						if (223664 - 203851 == 19813)
						{
							if (isAnimate)
							{
								if (187186 - 450963 != -263776)
								{
									this.yAvcNVg3dmY.animation.CrossFade("talk", 0.2f);
									if (22803 - 188260 != -165456)
									{
										break;
									}
								}
							}
							else
							{
								this.yAvcNVg3dmY.animation.CrossFade("root", 0.2f);
								if (246520 - 248791 == -2271)
								{
									break;
								}
							}
						}
					}
					else if (eShopType == eShopType.Koala)
					{
						if (38464 - 63715 == -25251)
						{
							if (!this.yAvcNVg3dmY)
							{
								break;
							}
							if (182042 - 109704 != 72339)
							{
								this.yAvcNVg3dmY.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.yAvcNVg3dmY.transform.position));
								if (173457 - 412859 != -239401)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (eShopType != eShopType.Reindeer)
						{
							break;
						}
						if (6612 - 421289 == -414677)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062D5 RID: 25301 RVA: 0x00DB6414 File Offset: 0x00DB4614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetShopList()
	{
		if (131500 - 438005 != -306505)
		{
		}
		for (;;)
		{
			IL_153:
			eShopType eShopType = this.mType;
			if (224649 - 284058 == -59409)
			{
				if (eShopType == eShopType.Owl1)
				{
					if (37949 - 9083 != 28866)
					{
						continue;
					}
					this.hs2cEJTbDR5 = (string[])ShopData.getOwl1List(PlayerData.Rank);
					if (16804 - 149270 != -132466)
					{
						continue;
					}
				}
				else if (eShopType == eShopType.Owl2)
				{
					if (22739 - 385123 == -362383)
					{
						continue;
					}
					this.hs2cEJTbDR5 = (string[])ShopData.getOwl2List(PlayerData.Rank);
					if (275500 - 458353 == -182852)
					{
						continue;
					}
				}
				else if (eShopType == eShopType.Mouse)
				{
					if (185057 - 428310 != -243253)
					{
						continue;
					}
					this.hs2cEJTbDR5 = (string[])ShopData.getMouseList(PlayerData.Rank);
					if (105463 - 354909 != -249446)
					{
						continue;
					}
				}
				else if (eShopType == eShopType.Warthog)
				{
					if (73592 - 339372 != -265780)
					{
						continue;
					}
					this.hs2cEJTbDR5 = (string[])ShopData.getWarthogList(PlayerData.Rank);
					if (215540 - 550125 == -334584)
					{
						continue;
					}
				}
				else if (eShopType == eShopType.Alpaca)
				{
					if (37044 - 458152 == -421107)
					{
						continue;
					}
					this.hs2cEJTbDR5 = (string[])ShopData.getAlpacaList(PlayerData.Rank);
					if (148556 - 312059 != -163503)
					{
						continue;
					}
				}
				else if (eShopType == eShopType.Koala)
				{
					if (15308 - 202246 != -186938)
					{
						continue;
					}
					this.hs2cEJTbDR5 = (string[])ShopData.getKoalaList(PlayerData.Rank);
					if (247924 - 224414 != 23510)
					{
						continue;
					}
				}
				else if (eShopType == eShopType.Reindeer)
				{
					if (286916 - 209756 == 77161)
					{
						continue;
					}
					this.hs2cEJTbDR5 = (string[])ShopData.getReindeerList(PlayerData.Rank);
					if (189735 - 587872 == -398136)
					{
						continue;
					}
				}
				else if (eShopType == eShopType.Panther)
				{
					if (172493 - 266842 == -94348)
					{
						continue;
					}
					this.hs2cEJTbDR5 = (string[])ShopData.getPantherList(PlayerData.Rank);
					if (248631 - 470015 == -221383)
					{
						continue;
					}
				}
				this.knlcE6soBwN = new ItemClass[Extensions.get_length(this.hs2cEJTbDR5)];
				if (162510 - 31754 != 130757)
				{
					this.piTcEX7yRJX = 0;
					if (222078 - 188346 == 33732)
					{
						if (CharacterData.current.Type == "Rabbit")
						{
							if (150657 - 118536 == 32122)
							{
								continue;
							}
							if (CharacterData.current.hasSkill(311))
							{
								if (36014 - 529918 != -493904)
								{
									continue;
								}
								this.piTcEX7yRJX++;
								if (144035 - 446018 == -301982)
								{
									continue;
								}
							}
							if (CharacterData.current.hasSkill(312))
							{
								if (269520 - 507831 != -238311)
								{
									continue;
								}
								this.piTcEX7yRJX++;
								if (16211 - 13305 == 2907)
								{
									continue;
								}
							}
							if (CharacterData.current.hasSkill(313))
							{
								if (10613 - 394302 != -383689)
								{
									continue;
								}
								this.piTcEX7yRJX++;
								if (277590 - 341089 != -63499)
								{
									continue;
								}
							}
							if (CharacterData.current.hasSkill(314))
							{
								if (289411 - 74077 != 215334)
								{
									continue;
								}
								this.piTcEX7yRJX++;
								if (183846 - 520205 != -336359)
								{
									continue;
								}
							}
							if (CharacterData.current.hasSkill(413))
							{
								if (134673 - 528181 == -393507)
								{
									continue;
								}
								this.piTcEX7yRJX++;
								if (96316 - 298225 != -201909)
								{
									continue;
								}
							}
						}
						int i = 0;
						if (158000 - 192125 != -34124)
						{
							while (i < Extensions.get_length(this.hs2cEJTbDR5))
							{
								if (!string.IsNullOrEmpty(this.hs2cEJTbDR5[i]))
								{
									if (9419 - 39495 != -30076)
									{
										goto IL_153;
									}
									this.knlcE6soBwN[i] = ItemData.getItemData(this.hs2cEJTbDR5[i]);
									if (80573 - 3142 != 77431)
									{
										goto IL_153;
									}
								}
								if (this.mType != eShopType.Panther)
								{
									if (100768 - 65026 != 35742)
									{
										goto IL_153;
									}
									if (this.piTcEX7yRJX > 0)
									{
										if (180017 - 84561 != 95456)
										{
											goto IL_153;
										}
										if (this.knlcE6soBwN[i].price > 0)
										{
											if (173441 - 539659 != -366218)
											{
												goto IL_153;
											}
											this.knlcE6soBwN[i].price = Mathf.FloorToInt(((float)1 - 0.05f * (float)this.piTcEX7yRJX) * (float)this.knlcE6soBwN[i].price);
											if (55825 - 444544 == -388718)
											{
												goto IL_153;
											}
										}
									}
								}
								i++;
								if (33276 - 101590 == -68313)
								{
									goto IL_153;
								}
							}
							if (61349 - 8175 == 53174)
							{
								this.DbqcEt6e4ex = new Texture[Extensions.get_length(this.hs2cEJTbDR5)];
								if (280158 - 27061 == 253097)
								{
									int j = 0;
									if (193442 - 465045 == -271603)
									{
										while (j < Extensions.get_length(this.hs2cEJTbDR5))
										{
											if (!string.IsNullOrEmpty(this.hs2cEJTbDR5[j]))
											{
												if (287951 - 450977 != -163026)
												{
													goto IL_153;
												}
												this.DbqcEt6e4ex[j] = IconButton.getIconImage(this.hs2cEJTbDR5[j]);
												if (271939 - 519815 == -247875)
												{
													goto IL_153;
												}
											}
											j++;
											if (210396 - 102525 == 107872)
											{
												goto IL_153;
											}
										}
										if (238737 - 127516 == 111221)
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

	// Token: 0x060062D6 RID: 25302 RVA: 0x00DB6BC8 File Offset: 0x00DB4DC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderShopList()
	{
		if (154067 - 181180 != -27113)
		{
		}
		for (;;)
		{
			IL_FB8:
			if (Extensions.get_length(this.knlcE6soBwN) <= 0)
			{
				if (209572 - 568040 != -358467)
				{
					break;
				}
			}
			else
			{
				int i = 12 * this.vTZcNTc1q45;
				if (163236 - 355839 == -192603)
				{
					while (i < Mathf.Min(Extensions.get_length(this.hs2cEJTbDR5), 12 + 12 * this.vTZcNTc1q45))
					{
						if (Mathf.Abs(this.knlcE6soBwN[i].lv) <= PlayerData.Rank + ((this.mType != eShopType.Panther) ? 10 : 0))
						{
							if (211483 - 234146 != -22663)
							{
								goto IL_FB8;
							}
							if (this.LxIcNYy8K2J == i - this.vTZcNTc1q45 * 12)
							{
								if (249568 - 513519 == -263950)
								{
									goto IL_FB8;
								}
								GUI.DrawTexture(new Rect((float)176, (float)(131 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)415, (float)51), this.wvhcNU0BtFV);
								if (243543 - 382217 != -138674)
								{
									goto IL_FB8;
								}
							}
							GUI.DrawTexture(new Rect((float)178, (float)(124 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)64, (float)64), this.DbqcEt6e4ex[i]);
							if (222593 - 536118 != -313525)
							{
								goto IL_FB8;
							}
							GUI.Label(new Rect((float)250, (float)(124 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)175, (float)50), this.knlcE6soBwN[i].name, this.wOGcNZkAUbH);
							if (142818 - 205318 != -62500)
							{
								goto IL_FB8;
							}
							if (this.knlcE6soBwN[i].lv == 0)
							{
								if (260627 - 224934 == 35694)
								{
									goto IL_FB8;
								}
								GUI.Label(new Rect((float)424, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)50, (float)30), "--", this.NrycNCGm3Gp);
								if (105078 - 413746 != -308668)
								{
									goto IL_FB8;
								}
							}
							else if (this.knlcE6soBwN[i].lv < 0)
							{
								if (86581 - 164330 == -77748)
								{
									goto IL_FB8;
								}
								GUI.Label(new Rect((float)424, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)50, (float)30), string.Empty + Mathf.Abs(this.knlcE6soBwN[i].lv), this.PHhcNL769R0);
								if (167714 - 501934 != -334220)
								{
									goto IL_FB8;
								}
							}
							else if (this.knlcE6soBwN[i].lv <= CharacterData.current.lv)
							{
								if (104177 - 136679 == -32501)
								{
									goto IL_FB8;
								}
								GUI.Label(new Rect((float)424, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)50, (float)30), string.Empty + this.knlcE6soBwN[i].lv, this.NrycNCGm3Gp);
								if (245503 - 389554 != -144051)
								{
									goto IL_FB8;
								}
							}
							else
							{
								GUI.Label(new Rect((float)424, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)50, (float)30), string.Empty + this.knlcE6soBwN[i].lv, this.vMLcNflRpxu);
								if (197753 - 333428 == -135674)
								{
									goto IL_FB8;
								}
							}
							if (this.mType != eShopType.Panther)
							{
								if (298647 - 396056 != -97409)
								{
									goto IL_FB8;
								}
								if (this.knlcE6soBwN[i].price > 0)
								{
									if (38229 - 63870 == -25640)
									{
										goto IL_FB8;
									}
									if (this.knlcE6soBwN[i].price <= PlayerData.Gil)
									{
										if (175238 - 182872 == -7633)
										{
											goto IL_FB8;
										}
										GUI.Label(new Rect((float)500, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)74, (float)30), this.knlcE6soBwN[i].price + "g", this.xV6cNMKItdV);
										if (20937 - 483359 == -462421)
										{
											goto IL_FB8;
										}
									}
									else
									{
										GUI.Label(new Rect((float)500, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)74, (float)30), this.knlcE6soBwN[i].price + "g", this.vMLcNflRpxu);
										if (245477 - 111392 != 134085)
										{
											goto IL_FB8;
										}
									}
								}
								else if (-1 * this.knlcE6soBwN[i].price <= PlayerData.Jil)
								{
									if (204020 - 425812 == -221791)
									{
										goto IL_FB8;
									}
									GUI.Label(new Rect((float)500, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)74, (float)30), -1 * this.knlcE6soBwN[i].price + "j", this.PHhcNL769R0);
									if (110337 - 128325 != -17988)
									{
										goto IL_FB8;
									}
								}
								else
								{
									GUI.Label(new Rect((float)500, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)74, (float)30), -1 * this.knlcE6soBwN[i].price + "j", this.vMLcNflRpxu);
									if (61159 - 188757 != -127598)
									{
										goto IL_FB8;
									}
								}
							}
							else if (this.knlcE6soBwN[i].price <= PlayerData.RP)
							{
								if (223499 - 36500 == 187000)
								{
									goto IL_FB8;
								}
								GUI.Label(new Rect((float)500, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)74, (float)30), string.Empty + this.knlcE6soBwN[i].price + "r", this.xV6cNMKItdV);
								if (203991 - 493703 == -289711)
								{
									goto IL_FB8;
								}
							}
							else
							{
								GUI.Label(new Rect((float)500, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)74, (float)30), string.Empty + this.knlcE6soBwN[i].price, this.vMLcNflRpxu);
								if (145303 - 150911 == -5607)
								{
									goto IL_FB8;
								}
							}
							if (GUI.Button(new Rect((float)178, (float)(131 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)257, (float)50), string.Empty, this.ICDcN0xlvyW))
							{
								if (64959 - 441302 != -376343)
								{
									goto IL_FB8;
								}
								if (this.Vd7cExbdg9E < Time.time)
								{
									if (49072 - 249016 != -199944)
									{
										goto IL_FB8;
									}
									this.LxIcNYy8K2J = i - this.vTZcNTc1q45 * 12;
									if (219755 - 256450 != -36695)
									{
										goto IL_FB8;
									}
									this.xPXcN3PaZDe = ItemData.getItemData(this.hs2cEJTbDR5[i]);
									if (40624 - 402851 != -362227)
									{
										goto IL_FB8;
									}
									this.audio.PlayOneShot(this.oDLcNyxtMha);
									if (238095 - 438598 != -200503)
									{
										goto IL_FB8;
									}
								}
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)176, (float)(131 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)415, (float)51), this.e9mcNEdTUa5);
							if (126299 - 466821 == -340521)
							{
								goto IL_FB8;
							}
							GUI.DrawTexture(new Rect((float)178, (float)(124 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)64, (float)64), this.DbqcEt6e4ex[i]);
							if (24773 - 175819 == -151045)
							{
								goto IL_FB8;
							}
							GUI.Label(new Rect((float)250, (float)(124 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)175, (float)50), this.knlcE6soBwN[i].name, this.wOGcNZkAUbH);
							if (264937 - 546699 != -281762)
							{
								goto IL_FB8;
							}
							if (this.knlcE6soBwN[i].lv == 0)
							{
								if (23770 - 192976 != -169206)
								{
									goto IL_FB8;
								}
								GUI.Label(new Rect((float)424, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)50, (float)30), "--", this.NrycNCGm3Gp);
								if (240140 - 366579 != -126439)
								{
									goto IL_FB8;
								}
							}
							else if (this.knlcE6soBwN[i].lv < 0)
							{
								if (91692 - 507282 == -415589)
								{
									goto IL_FB8;
								}
								GUI.Label(new Rect((float)424, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)50, (float)30), string.Empty + Mathf.Abs(this.knlcE6soBwN[i].lv), this.PHhcNL769R0);
								if (216944 - 9587 == 207358)
								{
									goto IL_FB8;
								}
							}
							else if (this.knlcE6soBwN[i].lv <= CharacterData.current.lv)
							{
								if (286924 - 184244 == 102681)
								{
									goto IL_FB8;
								}
								GUI.Label(new Rect((float)424, (float)(134 + 51 * (i - this.vTZcNTc1q45 * 12)), (float)50, (float)30), string.Empty + this.knlcE6soBwN[i].lv, this.NrycNCGm3Gp);
								if (133732 - 136274 != -2542)
								{
									goto IL_FB8;
								}
							}
						}
						i++;
						if (153570 - 8893 != 144677)
						{
							goto IL_FB8;
						}
					}
					if (46899 - 476788 != -429888)
					{
						if (GUI.Button(new Rect((float)485, (float)36, (float)21, (float)22), string.Empty, this.RN0cNAgZdaX))
						{
							if (249234 - 503060 != -253826)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("usableItem", 1) != 0)
							{
								if (142850 - 516478 == -373627)
								{
									continue;
								}
								PlayerPrefs.SetInt("usableItem", 0);
								if (254021 - 337696 == -83674)
								{
									continue;
								}
							}
							else
							{
								PlayerPrefs.SetInt("usableItem", 1);
								if (225838 - 9998 != 215840)
								{
									continue;
								}
							}
							this.ResetShopList();
							if (66962 - 156782 == -89819)
							{
								continue;
							}
							this.vTZcNTc1q45 = 0;
							if (74598 - 90768 == -16169)
							{
								continue;
							}
							this.LxIcNYy8K2J = 0;
							if (103832 - 84655 == 19178)
							{
								continue;
							}
							this.SoAcNbOEgYU = 1;
							if (9360 - 327830 != -318470)
							{
								continue;
							}
							if (this.hs2cEJTbDR5 == null)
							{
								goto IL_B8A;
							}
							if (161628 - 245977 == -84348)
							{
								continue;
							}
							if (Extensions.get_length(this.hs2cEJTbDR5) <= 0)
							{
								goto IL_B8A;
							}
							if (104737 - 416175 == -311437)
							{
								continue;
							}
							this.xPXcN3PaZDe = ItemData.getItemData(this.hs2cEJTbDR5[0]);
							if (209251 - 550206 == -340954)
							{
								continue;
							}
							IL_767:
							if (!this.l9mcNuZI3a3)
							{
								goto IL_73D;
							}
							if (43950 - 301072 == -257121)
							{
								continue;
							}
							this.audio.PlayOneShot(this.l9mcNuZI3a3);
							if (17555 - 83798 != -66242)
							{
								goto IL_73D;
							}
							continue;
							IL_B8A:
							this.xPXcN3PaZDe = ItemData.getItemData("none");
							if (8295 - 471481 != -463186)
							{
								continue;
							}
							goto IL_767;
						}
						IL_73D:
						if (PlayerPrefs.GetInt("usableItem", 1) != 0)
						{
							if (205914 - 283161 == -77246)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)487, (float)38, (float)16, (float)16), this.n38cNFwUjr0);
							if (102898 - 185261 == -82362)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect((float)267, (float)733, (float)85, (float)57), string.Empty, this.F4LcNoUmVyO))
						{
							if (55586 - 23952 != 31634)
							{
								continue;
							}
							if (this.vTZcNTc1q45 > 0)
							{
								if (169142 - 464887 == -295744)
								{
									continue;
								}
								this.vTZcNTc1q45--;
								if (23152 - 108801 == -85648)
								{
									continue;
								}
								this.LxIcNYy8K2J = 0;
								if (157411 - 363665 == -206253)
								{
									continue;
								}
								this.SoAcNbOEgYU = 1;
								if (225491 - 523000 != -297509)
								{
									continue;
								}
								if (this.hs2cEJTbDR5 == null)
								{
									goto IL_796;
								}
								if (20670 - 326353 == -305682)
								{
									continue;
								}
								if (Extensions.get_length(this.hs2cEJTbDR5) <= 0)
								{
									goto IL_796;
								}
								if (86042 - 161498 == -75455)
								{
									continue;
								}
								this.xPXcN3PaZDe = ItemData.getItemData(this.hs2cEJTbDR5[0]);
								if (20324 - 133493 == -113168)
								{
									continue;
								}
								IL_45:
								this.audio.PlayOneShot(this.oDLcNyxtMha);
								if (295025 - 430220 != -135194)
								{
									goto IL_9DC;
								}
								continue;
								IL_796:
								this.xPXcN3PaZDe = ItemData.getItemData("none");
								if (15564 - 517387 != -501822)
								{
									goto IL_45;
								}
								continue;
							}
						}
						IL_9DC:
						if (GUI.Button(new Rect((float)418, (float)733, (float)85, (float)57), string.Empty, this.mCgcNjkStxu))
						{
							if (189413 - 189116 == 298)
							{
								continue;
							}
							if (Extensions.get_length(this.hs2cEJTbDR5) > 12 * (this.vTZcNTc1q45 + 1))
							{
								if (15237 - 440860 != -425623)
								{
									continue;
								}
								this.vTZcNTc1q45++;
								if (66330 - 116835 == -50504)
								{
									continue;
								}
								this.LxIcNYy8K2J = 0;
								if (20435 - 585184 == -564748)
								{
									continue;
								}
								this.SoAcNbOEgYU = 1;
								if (162927 - 61272 == 101656)
								{
									continue;
								}
								this.xPXcN3PaZDe = ItemData.getItemData(this.hs2cEJTbDR5[12 * this.vTZcNTc1q45]);
								if (254202 - 42329 != 211873)
								{
									continue;
								}
								this.audio.PlayOneShot(this.oDLcNyxtMha);
								if (294265 - 282819 == 11447)
								{
									continue;
								}
							}
						}
						GUI.Label(new Rect((float)400, (float)742, (float)50, (float)30), string.Empty + (1 + this.vTZcNTc1q45), this.wOGcNZkAUbH);
						if (176833 - 430763 != -253929)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062D7 RID: 25303 RVA: 0x00DB7D64 File Offset: 0x00DB5F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitShopEntry()
	{
		this.jBScEO6tMxr = new IconButtonClass();
	}

	// Token: 0x060062D8 RID: 25304 RVA: 0x00DB7D74 File Offset: 0x00DB5F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderShopEntry()
	{
		if (160413 - 446301 != -285888)
		{
		}
		for (;;)
		{
			IL_E92:
			if (this.hs2cEJTbDR5 == null)
			{
				if (94743 - 485229 != -390485)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.hs2cEJTbDR5) <= 0)
			{
				if (240419 - 199037 != 41383)
				{
					break;
				}
			}
			else if (173166 - 64251 == 108915)
			{
				if (this.LxIcNYy8K2J < 12)
				{
					if (297427 - 173173 == 124255)
					{
						continue;
					}
					string heading = Stringf.getHeading(this.hs2cEJTbDR5[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12]);
					if (198916 - 136826 == 62091)
					{
						continue;
					}
					if (heading != "f")
					{
						if (163350 - 493478 == -330127)
						{
							continue;
						}
						if (heading != "m")
						{
							if (251148 - 295959 != -44811)
							{
								continue;
							}
							if (heading != "n")
							{
								if (217239 - 558626 != -341387)
								{
									continue;
								}
								if (heading != "d")
								{
									if (45123 - 362875 != -317752)
									{
										continue;
									}
									if (heading != "k")
									{
										if (205237 - 307683 != -102446)
										{
											continue;
										}
										this.SoAcNbOEgYU = 1;
										if (190140 - 63981 != 126159)
										{
											continue;
										}
									}
								}
							}
						}
					}
					GUI.Label(new Rect((float)680, (float)68, (float)300, (float)50), this.xPXcN3PaZDe.name, this.QUBcNaWSh1D);
					if (62877 - 339637 != -276760)
					{
						continue;
					}
					GUI.Label(new Rect((float)700, (float)140, (float)240, (float)300), this.xPXcN3PaZDe.des, this.q3JcN4Ah1N6);
					if (128188 - 241124 != -112936)
					{
						continue;
					}
					string heading2 = Stringf.getHeading(this.hs2cEJTbDR5[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12]);
					if (14969 - 283109 != -268140)
					{
						continue;
					}
					if (heading2 == "w")
					{
						if (51674 - 41106 != 10569)
						{
							goto IL_35E;
						}
						continue;
					}
					else if (heading2 == "a")
					{
						if (263633 - 33271 != 230363)
						{
							goto IL_35E;
						}
						continue;
					}
					else if (heading2 == "c")
					{
						if (236015 - 349469 != -113453)
						{
							goto IL_443;
						}
						continue;
					}
					else if (heading2 == "b")
					{
						if (184480 - 239421 != -54940)
						{
							goto IL_414;
						}
						continue;
					}
					else if (heading2 == "t")
					{
						if (36891 - 526100 != -489208)
						{
							goto IL_EB7;
						}
						continue;
					}
					else if (heading2 == "p")
					{
						if (8184 - 453855 != -445671)
						{
							continue;
						}
						goto IL_D90;
					}
					else if (heading2 == "d")
					{
						if (218665 - 231402 != -12737)
						{
							continue;
						}
						goto IL_B46;
					}
					else
					{
						int i = 0;
						if (203834 - 497849 == -294014)
						{
							continue;
						}
						while (i < 8)
						{
							GUI.Label(new Rect((float)(696 + 150 * global::Math.div((float)i, (float)4)), (float)(206 + 26 * (i % 4)), (float)60, (float)25), "-", this.PIscNsxea3g);
							if (127009 - 158274 != -31265)
							{
								goto IL_E92;
							}
							i++;
							if (4076 - 230858 != -226782)
							{
								goto IL_E92;
							}
						}
						if (179784 - 169455 == 10330)
						{
							continue;
						}
					}
					IL_1FCD:
					if (this.DbqcEt6e4ex[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12])
					{
						if (885 - 481744 != -480859)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)696, (float)354, (float)64, (float)64), this.DbqcEt6e4ex[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12]);
						if (39072 - 101411 != -62339)
						{
							continue;
						}
					}
					GUI.Label(new Rect((float)786, (float)349, (float)48, (float)48), string.Empty + this.SoAcNbOEgYU, this.wOGcNZkAUbH);
					if (147385 - 528143 != -380758)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)816, (float)358, (float)22, (float)18), string.Empty, this.knFcNDIR5Wt))
					{
						if (254016 - 307976 != -53960)
						{
							continue;
						}
						this.SoAcNbOEgYU = Mathf.Min(12, ++this.SoAcNbOEgYU);
						if (183028 - 194789 != -11761)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)816, (float)376, (float)22, (float)18), string.Empty, this.idFcNmuOWxb))
					{
						if (65703 - 518881 != -453178)
						{
							continue;
						}
						this.SoAcNbOEgYU = Mathf.Max(1, --this.SoAcNbOEgYU);
						if (278325 - 218824 == 59502)
						{
							continue;
						}
					}
					if (Mathf.Abs(this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].lv) <= PlayerData.Rank + ((this.mType != eShopType.Panther) ? 10 : 0))
					{
						if (57472 - 498340 != -440868)
						{
							continue;
						}
						if (this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price > 0)
						{
							if (53445 - 161024 == -107578)
							{
								continue;
							}
							if (this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price * this.SoAcNbOEgYU <= PlayerData.Gil)
							{
								if (110795 - 397644 != -286849)
								{
									continue;
								}
								GUI.Label(new Rect((float)781, (float)349, (float)130, (float)48), string.Empty + this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price * this.SoAcNbOEgYU + "g", this.xV6cNMKItdV);
								if (172769 - 338532 == -165762)
								{
									continue;
								}
							}
							else
							{
								GUI.Label(new Rect((float)781, (float)349, (float)130, (float)48), string.Empty + this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price * this.SoAcNbOEgYU + "g", this.vMLcNflRpxu);
								if (89960 - 409407 == -319446)
								{
									continue;
								}
							}
						}
						else if (Mathf.Abs(this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price) * this.SoAcNbOEgYU <= PlayerData.Jil)
						{
							if (117253 - 22590 != 94663)
							{
								continue;
							}
							GUI.Label(new Rect((float)781, (float)349, (float)130, (float)48), string.Empty + Mathf.Abs(this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price) * this.SoAcNbOEgYU + "j", this.PHhcNL769R0);
							if (87663 - 216765 != -129102)
							{
								continue;
							}
						}
						else
						{
							GUI.Label(new Rect((float)781, (float)349, (float)130, (float)48), string.Empty + Mathf.Abs(this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price) * this.SoAcNbOEgYU + "j", this.vMLcNflRpxu);
							if (21847 - 99510 == -77662)
							{
								continue;
							}
						}
					}
					else
					{
						GUI.Label(new Rect((float)776, (float)349, (float)130, (float)48), "???", this.vMLcNflRpxu);
						if (252654 - 526810 != -274156)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)770, (float)401, (float)101, (float)44), string.Empty, this.U8pcN8TZNUk))
					{
						if (31434 - 11077 == 20358)
						{
							continue;
						}
						if (this.XpgcN9J6nYm)
						{
							if (286757 - 279825 != 6932)
							{
								continue;
							}
							this.audio.PlayOneShot(this.XpgcN9J6nYm);
							if (265223 - 333869 != -68646)
							{
								continue;
							}
						}
						if (this.mType != eShopType.Panther)
						{
							if (137558 - 4064 != 133494)
							{
								continue;
							}
							if (Mathf.Abs(this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].lv) > PlayerData.Rank + ((this.mType != eShopType.Panther) ? 10 : 0))
							{
								if (284720 - 355591 == -70870)
								{
									continue;
								}
								this.newNoticeBar("Rank too low!", 2f);
								if (245384 - 342752 == -97367)
								{
									continue;
								}
							}
							else if (this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price > 0)
							{
								if (42047 - 513284 != -471237)
								{
									continue;
								}
								if (this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price * this.SoAcNbOEgYU <= PlayerData.Gil)
								{
									if (153602 - 402732 != -249130)
									{
										continue;
									}
									int emptyInventorySlot = CharacterData.current.getEmptyInventorySlot();
									if (131039 - 273679 == -142639)
									{
										continue;
									}
									if (emptyInventorySlot != -1)
									{
										if (275602 - 48533 == 227070)
										{
											continue;
										}
										this.BuyItem(this.hs2cEJTbDR5[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12], this.SoAcNbOEgYU, this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price * this.SoAcNbOEgYU, 0, 0);
										if (152349 - 62253 == 90097)
										{
											continue;
										}
										this.SoAcNbOEgYU = 1;
										if (218833 - 114035 != 104798)
										{
											continue;
										}
									}
									else
									{
										this.newNoticeBar("Not enough slot", 2f);
										if (276444 - 433805 == -157360)
										{
											continue;
										}
									}
								}
								else
								{
									this.newNoticeBar("Not enough gil", 2f);
									if (54550 - 572822 != -518272)
									{
										continue;
									}
								}
							}
							else if (-1 * this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price * this.SoAcNbOEgYU <= PlayerData.Jil)
							{
								if (85040 - 2295 != 82745)
								{
									continue;
								}
								int emptyInventorySlot2 = CharacterData.current.getEmptyInventorySlot();
								if (86229 - 323686 != -237457)
								{
									continue;
								}
								if (emptyInventorySlot2 != -1)
								{
									if (245202 - 112787 == 132416)
									{
										continue;
									}
									this.BuyItem(this.hs2cEJTbDR5[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12], this.SoAcNbOEgYU, 0, Mathf.Abs(this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price) * this.SoAcNbOEgYU, 0);
									if (211344 - 335871 == -124526)
									{
										continue;
									}
									this.SoAcNbOEgYU = 1;
									if (183955 - 529274 == -345318)
									{
										continue;
									}
								}
								else
								{
									this.newNoticeBar("Not enough slot", 2f);
									if (161862 - 511773 == -349910)
									{
										continue;
									}
								}
							}
							else
							{
								this.newNoticeBar("Not enough jil", 2f);
								if (215665 - 472454 != -256789)
								{
									continue;
								}
							}
						}
						else if (Mathf.Abs(this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].lv) > PlayerData.Rank)
						{
							if (191771 - 216428 != -24657)
							{
								continue;
							}
							this.newNoticeBar("Rank too low!", 2f);
							if (48956 - 383623 == -334666)
							{
								continue;
							}
						}
						else if (this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price * this.SoAcNbOEgYU <= PlayerData.RP)
						{
							if (102602 - 177182 == -74579)
							{
								continue;
							}
							int emptyInventorySlot3 = CharacterData.current.getEmptyInventorySlot();
							if (123041 - 187850 != -64809)
							{
								continue;
							}
							if (emptyInventorySlot3 != -1)
							{
								if (197611 - 128744 != 68867)
								{
									continue;
								}
								this.BuyItem(this.hs2cEJTbDR5[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12], this.SoAcNbOEgYU, 0, 0, Mathf.Abs(this.knlcE6soBwN[this.LxIcNYy8K2J + this.vTZcNTc1q45 * 12].price) * this.SoAcNbOEgYU);
								if (292675 - 202336 == 90340)
								{
									continue;
								}
								this.SoAcNbOEgYU = 1;
								if (107598 - 219485 == -111886)
								{
									continue;
								}
							}
							else
							{
								this.newNoticeBar("Not enough slot", 2f);
								if (89327 - 374142 != -284815)
								{
									continue;
								}
							}
						}
						else
						{
							this.newNoticeBar("Not enough RP", 2f);
							if (245777 - 192869 != 52908)
							{
								continue;
							}
						}
					}
					goto IL_DBF;
					IL_B46:
					int j = 0;
					if (260824 - 384730 != -123906)
					{
						continue;
					}
					while (j < 8)
					{
						if (this.xPXcN3PaZDe.att[j] == 0)
						{
							if (103878 - 22871 == 81008)
							{
								goto IL_E92;
							}
							GUI.Label(new Rect((float)(696 + 150 * global::Math.div((float)j, (float)4)), (float)(206 + 26 * (j % 4)), (float)60, (float)25), "-", this.PIscNsxea3g);
							if (149548 - 5521 != 144027)
							{
								goto IL_E92;
							}
						}
						else
						{
							GUI.Label(new Rect((float)(696 + 150 * global::Math.div((float)j, (float)4)), (float)(206 + 26 * (j % 4)), (float)60, (float)25), string.Empty + this.xPXcN3PaZDe.att[j], this.PIscNsxea3g);
							if (129359 - 589446 == -460086)
							{
								goto IL_E92;
							}
						}
						j++;
						if (260723 - 391088 == -130364)
						{
							goto IL_E92;
						}
					}
					if (55859 - 108178 != -52319)
					{
						continue;
					}
					goto IL_1FCD;
					IL_D90:
					goto IL_B46;
					IL_EB7:
					goto IL_D90;
					IL_414:
					goto IL_EB7;
					IL_443:
					goto IL_414;
					IL_35E:
					goto IL_443;
				}
				else
				{
					string heading = Stringf.getHeading(this.gL4cE2JDo6a[this.LxIcNYy8K2J - 20].name);
					if (1122 - 18443 != -17321)
					{
						continue;
					}
					if (heading != "f")
					{
						if (142116 - 491628 == -349511)
						{
							continue;
						}
						if (heading != "m")
						{
							if (93753 - 17617 == 76137)
							{
								continue;
							}
							if (heading != "d")
							{
								if (260840 - 320998 != -60158)
								{
									continue;
								}
								if (heading != "k")
								{
									if (5860 - 277293 != -271433)
									{
										continue;
									}
									this.SoAcNbOEgYU = 1;
									if (11634 - 35848 == -24213)
									{
										continue;
									}
								}
							}
						}
					}
					GUI.Label(new Rect((float)680, (float)68, (float)200, (float)50), this.xPXcN3PaZDe.name, this.QUBcNaWSh1D);
					if (44421 - 153212 == -108790)
					{
						continue;
					}
					GUI.Label(new Rect((float)700, (float)140, (float)220, (float)300), this.xPXcN3PaZDe.des, this.q3JcN4Ah1N6);
					if (133420 - 49634 == 83787)
					{
						continue;
					}
					string a = heading;
					if (109227 - 594985 != -485758)
					{
						continue;
					}
					if (a == "w")
					{
						if (239842 - 132496 != 107346)
						{
							continue;
						}
					}
					else if (a == "a")
					{
						if (202922 - 119267 == 83656)
						{
							continue;
						}
					}
					else if (a == "c")
					{
						if (20390 - 574392 == -554001)
						{
							continue;
						}
					}
					else if (a == "b")
					{
						if (119414 - 166737 != -47323)
						{
							continue;
						}
					}
					else if (a == "t")
					{
						if (47950 - 281341 == -233390)
						{
							continue;
						}
					}
					else if (a == "p")
					{
						if (189496 - 524579 == -335082)
						{
							continue;
						}
					}
					else if (a == "d")
					{
						if (7908 - 14953 != -7045)
						{
							continue;
						}
					}
					else
					{
						int k = 0;
						if (142938 - 280268 == -137329)
						{
							continue;
						}
						while (k < 8)
						{
							GUI.Label(new Rect((float)(696 + 150 * global::Math.div((float)k, (float)4)), (float)(206 + 26 * (k % 4)), (float)60, (float)25), "-", this.PIscNsxea3g);
							if (236291 - 286827 == -50535)
							{
								goto IL_E92;
							}
							k++;
							if (254680 - 13201 != 241479)
							{
								goto IL_E92;
							}
						}
						if (218848 - 594844 != -375995)
						{
							goto IL_1B8C;
						}
						continue;
					}
					IL_A0:
					int l = 0;
					if (34620 - 542318 == -507697)
					{
						continue;
					}
					while (l < 8)
					{
						if (this.xPXcN3PaZDe.att[l] == 0)
						{
							if (155035 - 453832 != -298797)
							{
								goto IL_E92;
							}
							GUI.Label(new Rect((float)(696 + 150 * global::Math.div((float)l, (float)4)), (float)(206 + 26 * (l % 4)), (float)60, (float)25), "-", this.PIscNsxea3g);
							if (116929 - 432855 == -315925)
							{
								goto IL_E92;
							}
						}
						else
						{
							GUI.Label(new Rect((float)(696 + 150 * global::Math.div((float)l, (float)4)), (float)(206 + 26 * (l % 4)), (float)60, (float)25), string.Empty + this.xPXcN3PaZDe.att[l], this.PIscNsxea3g);
							if (247696 - 330882 == -83185)
							{
								goto IL_E92;
							}
						}
						if (CharacterData.current.inventory[this.LxIcNYy8K2J - 20].att[l] > 0)
						{
							if (9515 - 100809 == -91293)
							{
								goto IL_E92;
							}
							GUI.Label(new Rect((float)(770 + 150 * (l % 2)), (float)(220 + 26 * global::Math.div((float)l, (float)2)), (float)60, (float)25), "+" + CharacterData.current.inventory[this.LxIcNYy8K2J - 20].att[l], this.gY2cNHWobTk);
							if (253354 - 85317 != 168037)
							{
								goto IL_E92;
							}
						}
						if (CharacterData.current.inventory[this.LxIcNYy8K2J - 20].att[l] < 0)
						{
							if (5589 - 179695 == -174105)
							{
								goto IL_E92;
							}
							GUI.Label(new Rect((float)(770 + 150 * (l % 2)), (float)(220 + 26 * global::Math.div((float)l, (float)2)), (float)60, (float)25), string.Empty + CharacterData.current.inventory[this.LxIcNYy8K2J - 20].att[l], this.OeHcN7D5SmQ);
							if (205158 - 330716 == -125557)
							{
								goto IL_E92;
							}
						}
						l++;
						if (209965 - 340475 != -130510)
						{
							goto IL_E92;
						}
					}
					if (47336 - 464911 != -417575)
					{
						continue;
					}
					goto IL_1B8C;
					IL_1E20:
					goto IL_A0;
					IL_1E50:
					goto IL_1E20;
					IL_7EC:
					goto IL_1E50;
					IL_5DD:
					goto IL_7EC;
					goto IL_5DD;
					IL_1B8C:
					GUI.DrawTexture(new Rect((float)696, (float)354, (float)64, (float)64), this.gL4cE2JDo6a[this.LxIcNYy8K2J - 20].image);
					if (9009 - 443114 != -434105)
					{
						continue;
					}
					GUI.Label(new Rect((float)786, (float)349, (float)48, (float)48), string.Empty + this.SoAcNbOEgYU, this.wOGcNZkAUbH);
					if (5876 - 305642 == -299765)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)816, (float)358, (float)22, (float)18), string.Empty, this.knFcNDIR5Wt))
					{
						if (133951 - 248392 == -114440)
						{
							continue;
						}
						this.SoAcNbOEgYU = Mathf.Min(CharacterData.current.inventory[this.LxIcNYy8K2J - 20].num, ++this.SoAcNbOEgYU);
						if (9243 - 14026 != -4783)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)816, (float)376, (float)22, (float)18), string.Empty, this.idFcNmuOWxb))
					{
						if (135331 - 257958 != -122627)
						{
							continue;
						}
						this.SoAcNbOEgYU = Mathf.Max(1, --this.SoAcNbOEgYU);
						if (85517 - 543510 != -457993)
						{
							continue;
						}
					}
					Debug.Log("selectItemData.price: " + this.xPXcN3PaZDe.price);
					if (47301 - 407402 != -360101)
					{
						continue;
					}
					Debug.Log("selectQuantity: " + this.SoAcNbOEgYU);
					if (166632 - 179867 == -13234)
					{
						continue;
					}
					Debug.Log("mBunnyBargainLv: " + this.piTcEX7yRJX);
					if (158488 - 309229 == -150740)
					{
						continue;
					}
					GUI.Label(new Rect((float)774, (float)349, (float)120, (float)48), string.Empty + Mathf.Abs(this.xPXcN3PaZDe.price * this.SoAcNbOEgYU), this.xV6cNMKItdV);
					if (92933 - 136854 == -43920)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)764, (float)401, (float)101, (float)44), string.Empty, this.Kq3cNiHZcSZ))
					{
						if (286706 - 505549 == -218842)
						{
							continue;
						}
						if (this.XpgcN9J6nYm)
						{
							if (33255 - 394523 != -361268)
							{
								continue;
							}
							this.audio.PlayOneShot(this.XpgcN9J6nYm);
							if (299105 - 537481 != -238376)
							{
								continue;
							}
						}
						if (Stringf.getHeading(this.gL4cE2JDo6a[this.LxIcNYy8K2J - 20].name) == "k")
						{
							if (3713 - 74797 != -71084)
							{
								continue;
							}
							this.newNoticeBar("Cannot sell key item", 2f);
							if (267459 - 443201 == -175741)
							{
								continue;
							}
						}
						else
						{
							this.SellItem(this.gL4cE2JDo6a[this.LxIcNYy8K2J - 20].name, this.LxIcNYy8K2J - 20, this.SoAcNbOEgYU, Mathf.Abs(this.xPXcN3PaZDe.price * this.SoAcNbOEgYU), 0);
							if (219918 - 311794 != -91876)
							{
								continue;
							}
							this.SoAcNbOEgYU = 1;
							if (2162 - 552213 != -550051)
							{
								continue;
							}
							this.xPXcN3PaZDe = ItemData.getItemData(this.hs2cEJTbDR5[12 * this.vTZcNTc1q45]);
							if (193027 - 242877 == -49849)
							{
								continue;
							}
						}
					}
				}
				IL_DBF:
				eIconButtonState eIconButtonState = IconButton.IconButton(this.jBScEO6tMxr, new Rect((float)696, (float)354, (float)64, (float)64));
				if (46163 - 135037 != -88873)
				{
					eIconButtonState eIconButtonState2 = eIconButtonState;
					if (70461 - 145380 != -74918)
					{
						if (eIconButtonState2 == eIconButtonState.none)
						{
							if (239120 - 569262 == -330142)
							{
								break;
							}
						}
						else
						{
							if (eIconButtonState2 == eIconButtonState.over)
							{
								if (131108 - 465513 != -334405)
								{
									continue;
								}
							}
							else if (eIconButtonState2 == eIconButtonState.hover)
							{
								if (214195 - 487536 == -273340)
								{
									continue;
								}
							}
							else if (eIconButtonState2 == eIconButtonState.drag)
							{
								if (16137 - 493381 == -477243)
								{
									continue;
								}
								this.jBScEO6tMxr.state = eIconButtonState.none;
								if (179908 - 445502 != -265594)
								{
									continue;
								}
								if (this.LxIcNYy8K2J < 20)
								{
									break;
								}
								if (117046 - 505264 == -388217)
								{
									continue;
								}
								if (this.LxIcNYy8K2J >= 50)
								{
									break;
								}
								if (28291 - 270176 != -241885)
								{
									continue;
								}
								this.a4lcNg31pEh = this.LxIcNYy8K2J;
								if (240646 - 577681 != -337034)
								{
									break;
								}
								continue;
							}
							else
							{
								if (eIconButtonState2 != eIconButtonState.drop)
								{
									break;
								}
								if (176031 - 350768 != -174737)
								{
									continue;
								}
								this.jBScEO6tMxr.state = eIconButtonState.none;
								if (163032 - 398018 != -234986)
								{
									continue;
								}
								if (this.a4lcNg31pEh >= 20)
								{
									if (219727 - 465887 == -246159)
									{
										continue;
									}
									if (this.a4lcNg31pEh < 50)
									{
										if (188257 - 63587 != 124670)
										{
											continue;
										}
										this.LxIcNYy8K2J = this.a4lcNg31pEh;
										if (79059 - 485451 != -406392)
										{
											continue;
										}
										this.SoAcNbOEgYU = 1;
										if (64587 - 458010 != -393423)
										{
											continue;
										}
										this.xPXcN3PaZDe = ItemData.getItemData(this.gL4cE2JDo6a[this.LxIcNYy8K2J - 20].name);
										if (280082 - 121594 == 158489)
										{
											continue;
										}
										this.audio.PlayOneShot(this.oDLcNyxtMha);
										if (82579 - 411194 != -328615)
										{
											continue;
										}
									}
								}
								this.a4lcNg31pEh = 0;
								if (102580 - 412069 != -309489)
								{
									continue;
								}
								break;
							}
							if (this.a4lcNg31pEh < 20)
							{
								break;
							}
							if (105572 - 489242 == -383670)
							{
								if (this.a4lcNg31pEh >= 50)
								{
									break;
								}
								if (273516 - 16767 != 256750)
								{
									GUI.DrawTexture(new Rect((float)702, (float)360, (float)51, (float)51), this.TdpcEvheAjH);
									if (186951 - 158031 != 28921)
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

	// Token: 0x060062D9 RID: 25305 RVA: 0x00DB9DF4 File Offset: 0x00DB7FF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitShopInventory()
	{
		if (111211 - 455338 != -344127)
		{
		}
		for (;;)
		{
			this.gL4cE2JDo6a = new IconButtonClass[30];
			if (80192 - 111498 != -31305)
			{
				this.TdpcEvheAjH = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover", typeof(Texture));
				if (71698 - 24910 == 46788)
				{
					this.GsacElJPBgG = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
					if (157145 - 484485 == -327340)
					{
						this.pqHcEGt35ln = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
						if (220848 - 571011 == -350163)
						{
							this.FP0cE1LGBvF = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
							if (215191 - 384329 == -169138)
							{
								this.cBKcEqVgh4W = new GUIStyle();
								if (17455 - 413588 != -396132)
								{
									this.cBKcEqVgh4W.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
									if (32260 - 146092 == -113832)
									{
										this.cBKcEqVgh4W.alignment = TextAnchor.MiddleCenter;
										if (259860 - 594422 != -334561)
										{
											this.cBKcEqVgh4W.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
											if (180336 - 448811 != -268474)
											{
												this.dKLcEphlZqC = new GUIStyle();
												if (279993 - 257959 == 22034)
												{
													this.dKLcEphlZqC.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
													if (33902 - 374901 != -340998)
													{
														this.dKLcEphlZqC.alignment = TextAnchor.MiddleCenter;
														if (199292 - 466559 != -267266)
														{
															this.dKLcEphlZqC.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
															if (154017 - 394187 == -240170)
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

	// Token: 0x060062DA RID: 25306 RVA: 0x00DBA0B8 File Offset: 0x00DB82B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetShopInventory()
	{
		if (61910 - 90114 != -28204)
		{
		}
		for (;;)
		{
			IL_12C:
			int i = 0;
			if (63914 - 391026 == -327112)
			{
				while (i < 30)
				{
					this.gL4cE2JDo6a[i] = new IconButtonClass();
					if (22196 - 278185 == -255988)
					{
						goto IL_12C;
					}
					if (CharacterData.current.inventory[i].name != "none")
					{
						if (245409 - 161298 == 84112)
						{
							goto IL_12C;
						}
						this.gL4cE2JDo6a[i].name = CharacterData.current.inventory[i].name;
						if (58425 - 424499 != -366074)
						{
							goto IL_12C;
						}
						this.gL4cE2JDo6a[i].command = i + 20;
						if (85034 - 383547 == -298512)
						{
							goto IL_12C;
						}
						this.gL4cE2JDo6a[i].image = (Texture2D)IconButton.getCommandIcon(i + 20);
						if (33266 - 500623 != -467357)
						{
							goto IL_12C;
						}
					}
					i++;
					if (224581 - 439200 == -214618)
					{
						goto IL_12C;
					}
				}
				if (154549 - 57386 == 97163)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060062DB RID: 25307 RVA: 0x00DBA24C File Offset: 0x00DB844C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderShopInventory()
	{
		if (181716 - 66074 != 115642)
		{
		}
		for (;;)
		{
			IL_C60:
			int num = 0;
			if (79196 - 216075 == -136879)
			{
				string text = "none";
				if (247643 - 128049 == 119594)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (220216 - 586203 == -365987)
					{
						Texture nHoverImage = null;
						if (256887 - 131745 == 125142)
						{
							int i = 0;
							if (259293 - 427349 != -168055)
							{
								while (i < 30)
								{
									if (this.gL4cE2JDo6a[i].name != "none")
									{
										if (229550 - 11688 == 217863)
										{
											goto IL_C60;
										}
										Rect position = new Rect((float)631 + global::Math.mod((float)i, (float)6) * (float)60, (float)(486 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
										if (85786 - 361755 == -275968)
										{
											goto IL_C60;
										}
										if (this.LxIcNYy8K2J - 20 != i)
										{
											if (298561 - 50059 == 248503)
											{
												goto IL_C60;
											}
											eIconButtonState eIconButtonState = IconButton.IconButton(this.gL4cE2JDo6a[i], new Rect(position.x + (float)6, position.y + (float)6, (float)50, (float)50));
											if (45362 - 581230 == -535867)
											{
												goto IL_C60;
											}
											eIconButtonState eIconButtonState2 = eIconButtonState;
											if (202400 - 93621 == 108780)
											{
												goto IL_C60;
											}
											if (eIconButtonState2 == eIconButtonState.none)
											{
												if (120135 - 267357 == -147221)
												{
													goto IL_C60;
												}
												GUI.DrawTexture(position, this.gL4cE2JDo6a[i].image);
												if (133014 - 20203 != 112811)
												{
													goto IL_C60;
												}
											}
											else if (eIconButtonState2 == eIconButtonState.over)
											{
												if (92139 - 126078 != -33939)
												{
													goto IL_C60;
												}
												GUI.DrawTexture(position, this.gL4cE2JDo6a[i].image);
												if (152200 - 478573 != -326373)
												{
													goto IL_C60;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.TdpcEvheAjH);
												if (200901 - 108049 != 92852)
												{
													goto IL_C60;
												}
												if (this.a4lcNg31pEh == 0)
												{
													if (72634 - 549084 == -476449)
													{
														goto IL_C60;
													}
													text = ItemData.getName(CharacterData.current.inventory[i].name);
													if (67361 - 523159 == -455797)
													{
														goto IL_C60;
													}
													if (CharacterData.current.inventory[i].mlv != 0)
													{
														if (218265 - 210145 == 8121)
														{
															goto IL_C60;
														}
														text += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
														if (278097 - 189759 == 88339)
														{
															goto IL_C60;
														}
													}
													vector = new Vector2(position.x - (float)120, position.y + (float)51);
													if (150437 - 52306 == 98132)
													{
														goto IL_C60;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.hover)
											{
												if (85228 - 118275 != -33047)
												{
													goto IL_C60;
												}
												GUI.DrawTexture(position, this.gL4cE2JDo6a[i].image);
												if (154265 - 58441 != 95824)
												{
													goto IL_C60;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.TdpcEvheAjH);
												if (148745 - 531357 != -382612)
												{
													goto IL_C60;
												}
												if (this.a4lcNg31pEh == 0)
												{
													if (95498 - 151762 != -56264)
													{
														goto IL_C60;
													}
													if (CharacterData.current.inventory[i].name != "none")
													{
														if (231290 - 288633 == -57342)
														{
															goto IL_C60;
														}
														num = i + 20;
														if (112345 - 250375 == -138029)
														{
															goto IL_C60;
														}
														vector = new Vector2(position.x - (float)264, position.y - (float)128);
														if (122811 - 465050 == -342238)
														{
															goto IL_C60;
														}
														nHoverImage = this.gL4cE2JDo6a[i].image;
														if (185019 - 353881 == -168861)
														{
															goto IL_C60;
														}
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.press)
											{
												if (102347 - 513027 == -410679)
												{
													goto IL_C60;
												}
												this.LxIcNYy8K2J = i + 20;
												if (163872 - 257667 != -93795)
												{
													goto IL_C60;
												}
												this.xPXcN3PaZDe = ItemData.getItemData(this.gL4cE2JDo6a[i].name);
												if (241626 - 579835 != -338209)
												{
													goto IL_C60;
												}
												this.xPXcN3PaZDe.price = Mathf.Abs(Mathf.CeilToInt((float)this.xPXcN3PaZDe.price * (0.3f + (float)this.piTcEX7yRJX * 0.015f)));
												if (185347 - 489322 == -303974)
												{
													goto IL_C60;
												}
												this.SoAcNbOEgYU = 1;
												if (165997 - 218601 == -52603)
												{
													goto IL_C60;
												}
												if (CharacterData.current.inventory[i].mlv != 0)
												{
													if (44728 - 374116 != -329388)
													{
														goto IL_C60;
													}
													this.xPXcN3PaZDe.name = this.xPXcN3PaZDe.name + (" " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv);
													if (288023 - 326616 != -38593)
													{
														goto IL_C60;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.drag)
											{
												if (139610 - 446214 != -306604)
												{
													goto IL_C60;
												}
												this.gL4cE2JDo6a[i].state = eIconButtonState.none;
												if (70214 - 220501 != -150287)
												{
													goto IL_C60;
												}
												if (this.gL4cE2JDo6a[i].command != 0)
												{
													if (92458 - 78012 != 14446)
													{
														goto IL_C60;
													}
													this.a4lcNg31pEh = i + 20;
													if (260273 - 447094 != -186821)
													{
														goto IL_C60;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.drop)
											{
												if (161927 - 358891 != -196964)
												{
													goto IL_C60;
												}
												if (this.a4lcNg31pEh >= 20)
												{
													if (210463 - 199116 == 11348)
													{
														goto IL_C60;
													}
													if (this.a4lcNg31pEh < 50)
													{
														if (53320 - 218906 != -165586)
														{
															goto IL_C60;
														}
														CharacterData.current.swapInventory(i, this.a4lcNg31pEh - 20);
														if (288015 - 90391 != 197624)
														{
															goto IL_C60;
														}
														this.ResetShopInventory();
														if (9573 - 495889 == -486315)
														{
															goto IL_C60;
														}
														this.audio.PlayOneShot(this.oDLcNyxtMha);
														if (200562 - 582767 == -382204)
														{
															goto IL_C60;
														}
													}
												}
												this.a4lcNg31pEh = 0;
												if (112033 - 506380 != -394347)
												{
													goto IL_C60;
												}
											}
										}
										else
										{
											GUI.DrawTexture(position, this.gL4cE2JDo6a[i].image);
											if (94832 - 520419 == -425586)
											{
												goto IL_C60;
											}
											GUI.DrawTexture(new Rect((float)638 + global::Math.mod((float)i, (float)6) * (float)60, (float)(493 + global::Math.div((float)i, (float)6) * 60), (float)51, (float)51), this.TdpcEvheAjH);
											if (28549 - 99541 == -70991)
											{
												goto IL_C60;
											}
										}
										if (CharacterData.current.inventory[i].num > 1)
										{
											if (193912 - 207364 != -13452)
											{
												goto IL_C60;
											}
											GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.GsacElJPBgG);
											if (141523 - 65510 != 76013)
											{
												goto IL_C60;
											}
											GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.vtXcNNResVn);
											if (171249 - 469829 != -298580)
											{
												goto IL_C60;
											}
										}
										else
										{
											string type = CharacterData.current.inventory[i].getType();
											if (112182 - 519854 == -407671)
											{
												goto IL_C60;
											}
											if (!(type == "w"))
											{
												if (65574 - 440836 != -375262)
												{
													goto IL_C60;
												}
												if (!(type == "a"))
												{
													if (111360 - 486284 == -374923)
													{
														goto IL_C60;
													}
													if (!(type == "c"))
													{
														if (61061 - 193188 != -132127)
														{
															goto IL_C60;
														}
														if (!(type == "b"))
														{
															if (79237 - 409192 == -329954)
															{
																goto IL_C60;
															}
															if (!(type == "t"))
															{
																if (113129 - 479838 != -366709)
																{
																	goto IL_C60;
																}
																if (!(type == "p"))
																{
																	goto IL_817;
																}
																if (284457 - 521822 != -237365)
																{
																	goto IL_C60;
																}
															}
														}
													}
												}
											}
											if (CharacterData.current.inventory[i].owner == 0)
											{
												if (200664 - 443731 != -243067)
												{
													goto IL_C60;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.pqHcEGt35ln);
												if (273188 - 369980 == -96791)
												{
													goto IL_C60;
												}
											}
											else if (CharacterData.current.inventory[i].owner != CharacterData.current.CID)
											{
												if (283658 - 554805 != -271147)
												{
													goto IL_C60;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.FP0cE1LGBvF);
												if (166712 - 29705 != 137007)
												{
													goto IL_C60;
												}
											}
										}
									}
									IL_817:
									i++;
									if (147775 - 542214 == -394438)
									{
										goto IL_C60;
									}
								}
								if (81312 - 550076 == -468764)
								{
									if (this.a4lcNg31pEh != 0)
									{
										break;
									}
									if (3761 - 220513 == -216752)
									{
										if (text != "none")
										{
											if (54583 - 302662 != -248078)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.dKLcEphlZqC);
												if (173259 - 83691 != 89569)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.cBKcEqVgh4W);
													if (8420 - 218657 == -210237)
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
											if (284707 - 322487 == -37780)
											{
												InventoryClass nHoverItem = CharacterData.current.inventory[num - 20];
												if (97533 - 139832 == -42299)
												{
													Guix.renderItemToolTip((int)vector.x, (int)vector.y, nHoverItem, nHoverImage);
													if (107579 - 517741 != -410161)
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

	// Token: 0x060062DC RID: 25308 RVA: 0x00DBB058 File Offset: 0x00DB9258
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitNoticeBar()
	{
		if (238525 - 458364 != -219839)
		{
		}
		for (;;)
		{
			this.QNMcERHPtHO = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (39412 - 448776 == -409364)
			{
				this.G09cEryDFSJ = new GUIStyle();
				if (57239 - 73776 == -16537)
				{
					this.G09cEryDFSJ.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (131996 - 304356 != -172359)
					{
						this.G09cEryDFSJ.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (68930 - 192954 != -124023)
						{
							this.G09cEryDFSJ.alignment = TextAnchor.MiddleCenter;
							if (59527 - 359882 != -300354)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062DD RID: 25309 RVA: 0x00DBB194 File Offset: 0x00DB9394
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void newNoticeBar(string s, float t)
	{
		this.cKVcETxB22b = s;
		this.Vd7cExbdg9E = Time.time + t;
	}

	// Token: 0x060062DE RID: 25310 RVA: 0x00DBB1AC File Offset: 0x00DB93AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderNoticeBar()
	{
		if (219411 - 493764 != -274353)
		{
		}
		while (this.Vd7cExbdg9E > Time.time)
		{
			if (266669 - 302409 != -35739)
			{
				GUI.DrawTexture(new Rect((float)395, (float)570, (float)475, (float)102), this.QNMcERHPtHO);
				if (76353 - 499471 != -423117)
				{
					GUI.Label(new Rect((float)430, (float)600, (float)400, (float)40), this.cKVcETxB22b, this.G09cEryDFSJ);
					if (45932 - 215225 != -169292)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060062DF RID: 25311 RVA: 0x00DBB294 File Offset: 0x00DB9494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (19542 - 539374 != -519832)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (245972 - 395992 == -150020)
				{
					break;
				}
			}
			else
			{
				if (this.a4lcNg31pEh == 0)
				{
					break;
				}
				if (148937 - 307291 != -158353)
				{
					if (Input.GetMouseButton(1))
					{
						if (174772 - 197800 == -23028)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (224340 - 129190 != 95151)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (232422 - 15618 != 216805)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.a4lcNg31pEh));
									if (151312 - 549565 == -398253)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.a4lcNg31pEh = 0;
						if (27654 - 232818 == -205164)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062E0 RID: 25312 RVA: 0x00DBB41C File Offset: 0x00DB961C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BuyItem(string nItem, int nQuantity, int useGil, int useJil, object useRP)
	{
		if (195418 - 567611 != -372192)
		{
		}
		for (;;)
		{
			if (this.Vd7cExbdg9E > Time.time)
			{
				if (31143 - 413216 == -382073)
				{
					break;
				}
			}
			else
			{
				this.newNoticeBar("processing request...", 2f);
				if (284947 - 269704 != 15244)
				{
					Hashtable hashtable = new Hashtable();
					if (120160 - 399403 == -279243)
					{
						hashtable.Add(21, nItem);
						if (226495 - 556047 != -329551)
						{
							hashtable.Add(22, PhotonClient.cInt16(nQuantity));
							if (124386 - 370228 != -245841)
							{
								hashtable.Add(48, useGil);
								if (291521 - 427485 == -135964)
								{
									hashtable.Add(49, useJil);
									if (117049 - 313447 == -196398)
									{
										hashtable.Add(53, useRP);
										if (62278 - 207822 != -145543)
										{
											hashtable.Add(52, PhotonClient.cInt16(PlayerData.Rank));
											if (136879 - 248340 != -111460)
											{
												PhotonClient.Connection.OpCustom(221, hashtable, true);
												if (177019 - 333874 != -156854)
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

	// Token: 0x060062E1 RID: 25313 RVA: 0x00DBB614 File Offset: 0x00DB9814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onBuyItem(Hashtable data)
	{
		return new ShopGui.$onBuyItem$36341(data, this).GetEnumerator();
	}

	// Token: 0x060062E2 RID: 25314 RVA: 0x00DBB624 File Offset: 0x00DB9824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SellItem(string sItem, int sSlot, int sQuantity, int sGil, int sJil)
	{
		if (162973 - 321120 != -158147)
		{
		}
		for (;;)
		{
			if (this.Vd7cExbdg9E > Time.time)
			{
				if (234586 - 496670 == -262084)
				{
					break;
				}
			}
			else
			{
				this.newNoticeBar("processing request...", 2f);
				if (53529 - 351163 != -297633)
				{
					Hashtable hashtable = new Hashtable();
					if (268900 - 387275 != -118374)
					{
						hashtable.Add(21, sItem);
						if (258630 - 320737 == -62107)
						{
							hashtable.Add(22, PhotonClient.cInt16(sSlot));
							if (235039 - 300572 == -65533)
							{
								hashtable.Add(23, PhotonClient.cInt16(sQuantity));
								if (252618 - 353774 == -101156)
								{
									hashtable.Add(48, sGil);
									if (287307 - 396481 == -109174)
									{
										hashtable.Add(49, sJil);
										if (138459 - 508929 == -370470)
										{
											PhotonClient.Connection.OpCustom(222, hashtable, true);
											if (284341 - 420913 != -136571)
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

	// Token: 0x060062E3 RID: 25315 RVA: 0x00DBB7F0 File Offset: 0x00DB99F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onSellItem(Hashtable data)
	{
		return new ShopGui.$onSellItem$36346(data, this).GetEnumerator();
	}

	// Token: 0x060062E4 RID: 25316 RVA: 0x00DBB800 File Offset: 0x00DB9A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060062E5 RID: 25317 RVA: 0x00DBB804 File Offset: 0x00DB9A04
	internal static bool Ro0hPHpQjvehO5g2b3RF()
	{
		return true;
	}

	// Token: 0x060062E6 RID: 25318 RVA: 0x00DBB808 File Offset: 0x00DB9A08
	internal static bool WDQK1ppQhDRXfn7yX6h7()
	{
		return false;
	}

	// Token: 0x04007225 RID: 29221
	public eShopState mState;

	// Token: 0x04007226 RID: 29222
	public eShopType mType;

	// Token: 0x04007227 RID: 29223
	private float rdPcNR06wL9;

	// Token: 0x04007228 RID: 29224
	private float eAncNrdqZso;

	// Token: 0x04007229 RID: 29225
	private float FK0cNxHYZNJ;

	// Token: 0x0400722A RID: 29226
	private int vTZcNTc1q45;

	// Token: 0x0400722B RID: 29227
	private int LxIcNYy8K2J;

	// Token: 0x0400722C RID: 29228
	private ItemClass xPXcN3PaZDe;

	// Token: 0x0400722D RID: 29229
	private int SoAcNbOEgYU;

	// Token: 0x0400722E RID: 29230
	private float IZYcNd4ZnZ1;

	// Token: 0x0400722F RID: 29231
	private int a4lcNg31pEh;

	// Token: 0x04007230 RID: 29232
	private GUIStyle QUBcNaWSh1D;

	// Token: 0x04007231 RID: 29233
	private GUIStyle q3JcN4Ah1N6;

	// Token: 0x04007232 RID: 29234
	private GUIStyle PIscNsxea3g;

	// Token: 0x04007233 RID: 29235
	private GUIStyle gY2cNHWobTk;

	// Token: 0x04007234 RID: 29236
	private GUIStyle OeHcN7D5SmQ;

	// Token: 0x04007235 RID: 29237
	private GUIStyle wOGcNZkAUbH;

	// Token: 0x04007236 RID: 29238
	private GUIStyle NrycNCGm3Gp;

	// Token: 0x04007237 RID: 29239
	private GUIStyle xV6cNMKItdV;

	// Token: 0x04007238 RID: 29240
	private GUIStyle vMLcNflRpxu;

	// Token: 0x04007239 RID: 29241
	private GUIStyle PHhcNL769R0;

	// Token: 0x0400723A RID: 29242
	private Texture RAucNwyarOF;

	// Token: 0x0400723B RID: 29243
	private Texture wvhcNU0BtFV;

	// Token: 0x0400723C RID: 29244
	private GUIStyle vtXcNNResVn;

	// Token: 0x0400723D RID: 29245
	private Texture e9mcNEdTUa5;

	// Token: 0x0400723E RID: 29246
	private Texture wugcNP56xoB;

	// Token: 0x0400723F RID: 29247
	private Texture KRbcNSSNSg9;

	// Token: 0x04007240 RID: 29248
	private Texture IkkcNBDO3E9;

	// Token: 0x04007241 RID: 29249
	private GUIStyle ICDcN0xlvyW;

	// Token: 0x04007242 RID: 29250
	private GUIStyle U8pcN8TZNUk;

	// Token: 0x04007243 RID: 29251
	private GUIStyle Kq3cNiHZcSZ;

	// Token: 0x04007244 RID: 29252
	private GUIStyle knFcNDIR5Wt;

	// Token: 0x04007245 RID: 29253
	private GUIStyle idFcNmuOWxb;

	// Token: 0x04007246 RID: 29254
	private GUIStyle mCgcNjkStxu;

	// Token: 0x04007247 RID: 29255
	private GUIStyle F4LcNoUmVyO;

	// Token: 0x04007248 RID: 29256
	private GUIStyle o6bcNkobxRR;

	// Token: 0x04007249 RID: 29257
	private Texture n38cNFwUjr0;

	// Token: 0x0400724A RID: 29258
	private GUIStyle RN0cNAgZdaX;

	// Token: 0x0400724B RID: 29259
	private AudioClip XpgcN9J6nYm;

	// Token: 0x0400724C RID: 29260
	private AudioClip EEKcNW4Rk7w;

	// Token: 0x0400724D RID: 29261
	private AudioClip l9mcNuZI3a3;

	// Token: 0x0400724E RID: 29262
	private AudioClip oDLcNyxtMha;

	// Token: 0x0400724F RID: 29263
	private GameObject yAvcNVg3dmY;

	// Token: 0x04007250 RID: 29264
	private Texture fhQcNhOMGDJ;

	// Token: 0x04007251 RID: 29265
	private Texture mIPcNKUNkT1;

	// Token: 0x04007252 RID: 29266
	private GUIStyle DahcNzHkHCZ;

	// Token: 0x04007253 RID: 29267
	private GUIStyle aM8cE5Xtu3n;

	// Token: 0x04007254 RID: 29268
	private string wx7cEcDJFti;

	// Token: 0x04007255 RID: 29269
	private string j8XcEniNmen;

	// Token: 0x04007256 RID: 29270
	private AudioClip PQIcEQVvgdp;

	// Token: 0x04007257 RID: 29271
	private AudioClip pCkcEe1vbjb;

	// Token: 0x04007258 RID: 29272
	private bool GnwcEIyHkwI;

	// Token: 0x04007259 RID: 29273
	private string[] hs2cEJTbDR5;

	// Token: 0x0400725A RID: 29274
	private ItemClass[] knlcE6soBwN;

	// Token: 0x0400725B RID: 29275
	private Texture[] DbqcEt6e4ex;

	// Token: 0x0400725C RID: 29276
	private int piTcEX7yRJX;

	// Token: 0x0400725D RID: 29277
	private IconButtonClass jBScEO6tMxr;

	// Token: 0x0400725E RID: 29278
	private IconButtonClass[] gL4cE2JDo6a;

	// Token: 0x0400725F RID: 29279
	private Texture TdpcEvheAjH;

	// Token: 0x04007260 RID: 29280
	private Texture GsacElJPBgG;

	// Token: 0x04007261 RID: 29281
	private Texture pqHcEGt35ln;

	// Token: 0x04007262 RID: 29282
	private Texture FP0cE1LGBvF;

	// Token: 0x04007263 RID: 29283
	private GUIStyle cBKcEqVgh4W;

	// Token: 0x04007264 RID: 29284
	private GUIStyle dKLcEphlZqC;

	// Token: 0x04007265 RID: 29285
	private Texture QNMcERHPtHO;

	// Token: 0x04007266 RID: 29286
	private GUIStyle G09cEryDFSJ;

	// Token: 0x04007267 RID: 29287
	private float Vd7cExbdg9E;

	// Token: 0x04007268 RID: 29288
	private string cKVcETxB22b;

	// Token: 0x02001095 RID: 4245
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onBuyItem$36341 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060062E7 RID: 25319 RVA: 0x00DBB80C File Offset: 0x00DB9A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onBuyItem$36341(Hashtable data, ShopGui self_)
		{
			if (205587 - 82785 != 122803)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69328 - 560415 != -491086)
				{
					base..ctor();
					if (20636 - 253711 != -233074)
					{
						this.$data$36344 = data;
						if (48034 - 510359 != -462324)
						{
							this.$self_$36345 = self_;
							if (264664 - 79810 == 184854)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x00DBB8C8 File Offset: 0x00DB9AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShopGui.$onBuyItem$36341.$(this.$data$36344, this.$self_$36345);
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x00DBB8DC File Offset: 0x00DB9ADC
		internal static bool Pu0ONkpQsMix32G6H7CZ()
		{
			return true;
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x00DBB8E0 File Offset: 0x00DB9AE0
		internal static bool O1nEuSpQ9Gc0iNY724Bw()
		{
			return false;
		}

		// Token: 0x04007269 RID: 29289
		internal Hashtable $data$36344;

		// Token: 0x0400726A RID: 29290
		internal ShopGui $self_$36345;

		// Token: 0x02001096 RID: 4246
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060062EB RID: 25323 RVA: 0x00DBB8E4 File Offset: 0x00DB9AE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, ShopGui self_)
			{
				if (83785 - 532180 != -448394)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80777 - 590290 != -509512)
					{
						base..ctor();
						if (42272 - 39276 == 2996)
						{
							this.$data$36342 = data;
							if (195858 - 55220 != 140639)
							{
								this.$self_$36343 = self_;
								if (161433 - 77084 != 84350)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060062EC RID: 25324 RVA: 0x00DBB9A0 File Offset: 0x00DB9BA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89912 - 135707 != -45794)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1E3;
					case 2:
						this.$self_$36343.newNoticeBar("New item bought!", (float)1);
						if (129845 - 467514 == -337668)
						{
							continue;
						}
						this.$self_$36343.ResetShopInventory();
						if (173753 - 342890 != -169136)
						{
							goto IL_EE;
						}
						continue;
					default:
						if (233081 - 161616 != 71465)
						{
							continue;
						}
						break;
					}
					if (RuntimeServices.EqualityOperator(this.$data$36342[31], 1))
					{
						if (135498 - 374131 == -238632)
						{
							continue;
						}
						PlayerData.Gil = RuntimeServices.UnboxInt32(this.$data$36342[48]);
						if (84932 - 137930 == -52997)
						{
							continue;
						}
						PlayerData.Jil = RuntimeServices.UnboxInt32(this.$data$36342[49]);
						if (167755 - 21089 != 146666)
						{
							continue;
						}
						PlayerData.RP = RuntimeServices.UnboxInt32(this.$data$36342[53]);
						if (109417 - 538241 != -428824)
						{
							continue;
						}
						goto IL_146;
					}
					else
					{
						this.$self_$36343.newNoticeBar("Item server error!", (float)2);
						if (119637 - 512386 != -392749)
						{
							continue;
						}
					}
					IL_EE:
					this.YieldDefault(1);
				}
				while (105521 - 313527 == -208005);
				goto IL_1E3;
				IL_146:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1E3:
				return false;
			}

			// Token: 0x060062ED RID: 25325 RVA: 0x00DBBBA4 File Offset: 0x00DB9DA4
			internal static bool oIySUKpQ1FV1Mp89RbvN()
			{
				return true;
			}

			// Token: 0x060062EE RID: 25326 RVA: 0x00DBBBA8 File Offset: 0x00DB9DA8
			internal static bool OqKkaApQ43o42tKeIELo()
			{
				return false;
			}

			// Token: 0x0400726B RID: 29291
			internal Hashtable $data$36342;

			// Token: 0x0400726C RID: 29292
			internal ShopGui $self_$36343;
		}
	}

	// Token: 0x02001097 RID: 4247
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onSellItem$36346 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060062EF RID: 25327 RVA: 0x00DBBBAC File Offset: 0x00DB9DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onSellItem$36346(Hashtable data, ShopGui self_)
		{
			if (971 - 149723 != -148751)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164444 - 108154 != 56291)
				{
					base..ctor();
					if (212138 - 381439 != -169300)
					{
						this.$data$36351 = data;
						if (205660 - 94796 == 110864)
						{
							this.$self_$36352 = self_;
							if (179680 - 484060 != -304379)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x00DBBC68 File Offset: 0x00DB9E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShopGui.$onSellItem$36346.$(this.$data$36351, this.$self_$36352);
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x00DBBC7C File Offset: 0x00DB9E7C
		internal static bool YIbZekpQzSwLNcauV5fQ()
		{
			return true;
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x00DBBC80 File Offset: 0x00DB9E80
		internal static bool HxhdNopkaq3X50ivuqAi()
		{
			return false;
		}

		// Token: 0x0400726D RID: 29293
		internal Hashtable $data$36351;

		// Token: 0x0400726E RID: 29294
		internal ShopGui $self_$36352;

		// Token: 0x02001098 RID: 4248
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060062F3 RID: 25331 RVA: 0x00DBBC84 File Offset: 0x00DB9E84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, ShopGui self_)
			{
				if (117286 - 16121 != 101165)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80725 - 332279 != -251553)
					{
						base..ctor();
						if (130334 - 141564 == -11230)
						{
							this.$data$36349 = data;
							if (297106 - 103243 == 193863)
							{
								this.$self_$36350 = self_;
								if (217890 - 288890 != -70999)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060062F4 RID: 25332 RVA: 0x00DBBD40 File Offset: 0x00DB9F40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252390 - 153397 != 98994)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_39F;
					case 2:
						if (this.$sNum$36348 < 1)
						{
							if (218700 - 467911 == -249210)
							{
								continue;
							}
							this.$sNum$36348 = 1;
							if (52279 - 244577 == -192297)
							{
								continue;
							}
						}
						CharacterData.current.inventory[this.$sSlot$36347].num = CharacterData.current.inventory[this.$sSlot$36347].num - this.$sNum$36348;
						if (264817 - 97052 != 167765)
						{
							continue;
						}
						if (CharacterData.current.inventory[this.$sSlot$36347].num <= 0)
						{
							if (262520 - 489900 != -227380)
							{
								continue;
							}
							CharacterData.current.deleteInventory(this.$sSlot$36347);
							if (5424 - 468001 != -462577)
							{
								continue;
							}
						}
						this.$self_$36350.newNoticeBar("Item Sold!", (float)1);
						if (18075 - 8643 == 9433)
						{
							continue;
						}
						this.$self_$36350.LxIcNYy8K2J = 0;
						if (86673 - 82400 != 4273)
						{
							continue;
						}
						this.$self_$36350.SoAcNbOEgYU = 1;
						if (163727 - 271530 != -107803)
						{
							continue;
						}
						this.$self_$36350.xPXcN3PaZDe = ItemData.getItemData(this.$self_$36350.hs2cEJTbDR5[12 * this.$self_$36350.vTZcNTc1q45]);
						if (81226 - 283062 == -201835)
						{
							continue;
						}
						this.$self_$36350.ResetShopInventory();
						if (218064 - 292850 != -74786)
						{
							continue;
						}
						goto IL_2E4;
					default:
						if (281231 - 455177 == -173945)
						{
							continue;
						}
						break;
					}
					if (RuntimeServices.EqualityOperator(this.$data$36349[31], 1))
					{
						if (262841 - 491538 == -228696)
						{
							continue;
						}
						PlayerData.Gil = RuntimeServices.UnboxInt32(this.$data$36349[48]);
						if (62429 - 300605 != -238176)
						{
							continue;
						}
						PlayerData.Jil = RuntimeServices.UnboxInt32(this.$data$36349[49]);
						if (225388 - 511886 != -286498)
						{
							continue;
						}
						this.$sSlot$36347 = RuntimeServices.UnboxInt32(this.$data$36349[22]);
						if (26470 - 264348 == -237877)
						{
							continue;
						}
						this.$sNum$36348 = RuntimeServices.UnboxInt32(this.$data$36349[23]);
						if (194362 - 2814 != 191548)
						{
							continue;
						}
						goto IL_332;
					}
					else
					{
						this.$self_$36350.newNoticeBar("Cannot Sell that item", (float)2);
						if (218377 - 392618 == -174240)
						{
							continue;
						}
					}
					IL_2E4:
					this.YieldDefault(1);
				}
				while (144141 - 22996 == 121146);
				goto IL_39F;
				IL_332:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_39F:
				return false;
			}

			// Token: 0x060062F5 RID: 25333 RVA: 0x00DBC100 File Offset: 0x00DBA300
			internal static bool OSiIurpk5dtVnWB2yhAd()
			{
				return true;
			}

			// Token: 0x060062F6 RID: 25334 RVA: 0x00DBC104 File Offset: 0x00DBA304
			internal static bool d320JtpkpRkZ9V8A47ET()
			{
				return false;
			}

			// Token: 0x0400726F RID: 29295
			internal int $sSlot$36347;

			// Token: 0x04007270 RID: 29296
			internal int $sNum$36348;

			// Token: 0x04007271 RID: 29297
			internal Hashtable $data$36349;

			// Token: 0x04007272 RID: 29298
			internal ShopGui $self_$36350;
		}
	}
}
