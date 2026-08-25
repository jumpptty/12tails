using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001073 RID: 4211
[Serializable]
public class LoginGui : MonoBehaviour
{
	// Token: 0x060061A7 RID: 24999 RVA: 0x00D6757C File Offset: 0x00D6577C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoginGui()
	{
		if (21289 - 510376 != -489086)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (219338 - 597218 != -377879)
			{
				base..ctor();
				if (217479 - 215099 != 2381)
				{
					this.tABcHN2BdYM = string.Empty;
					if (298951 - 560418 != -261466)
					{
						this.SJpcHE2Ikad = string.Empty;
						if (199724 - 307909 == -108185)
						{
							this.WLlcHPyMpsF = string.Empty;
							if (277737 - 121828 == 155909)
							{
								this.c9xcHSf7FwR = string.Empty;
								if (188944 - 170534 != 18411)
								{
									this.r3AcHB7rp0m = string.Empty;
									if (114002 - 65624 == 48378)
									{
										this.XPLcHDoylB2 = 610;
										if (205563 - 335446 != -129882)
										{
											this.vQ3cHjUv5H7 = true;
											if (118628 - 363788 != -245159)
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

	// Token: 0x060061A8 RID: 25000 RVA: 0x00D676F4 File Offset: 0x00D658F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (243616 - 223782 != 19834)
		{
		}
		for (;;)
		{
			if (PlayerPrefs.GetInt("saveUser", 0) == 0)
			{
				if (236358 - 40277 == 196082)
				{
					continue;
				}
				this.tABcHN2BdYM = string.Empty;
				if (179846 - 515264 != -335418)
				{
					continue;
				}
			}
			else
			{
				this.tABcHN2BdYM = PlayerPrefs.GetString("username", string.Empty);
				if (222611 - 535303 != -312692)
				{
					continue;
				}
			}
			this.SJpcHE2Ikad = string.Empty;
			if (161426 - 317881 == -156455)
			{
				this.WLlcHPyMpsF = string.Empty;
				if (223703 - 127142 != 96562)
				{
					this.r3AcHB7rp0m = string.Empty;
					if (199955 - 119161 == 80794)
					{
						this.s2WcHw6McLY = Mathf.Clamp(PlayerPrefs.GetInt("server", 0), 0, 5);
						if (86986 - 541296 == -454310)
						{
							if (this.internationalVersion)
							{
								if (135431 - 555551 == -420119)
								{
									continue;
								}
								PlayerPrefs.SetInt("language", 1);
								if (27864 - 559540 != -531676)
								{
									continue;
								}
							}
							this.g70cH0qkdyF = eLoginState.Init;
							if (126653 - 178136 != -51482)
							{
								this.Init();
								if (283814 - 4205 != 279610)
								{
									Game.Init(this.XPLcHDoylB2);
									if (156891 - 576609 != -419717)
									{
										CharacterData.Init();
										if (59419 - 440869 == -381450)
										{
											GuildData.Init();
											if (574 - 339434 != -338859)
											{
												Chat.Init();
												if (147147 - 354358 == -207211)
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

	// Token: 0x060061A9 RID: 25001 RVA: 0x00D67960 File Offset: 0x00D65B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init()
	{
		if (190053 - 433320 != -243267)
		{
		}
		for (;;)
		{
			this.Fj0cHo2XFT9 = (Texture)Resources.Load("GameGui/LogIn/LogIn_background", typeof(Texture));
			if (31059 - 501889 != -470829)
			{
				this.WdBcHkYaEHh = (Texture)Resources.Load("GameGui/Common/Black", typeof(Texture));
				if (40436 - 115109 != -74672)
				{
					this.QnucHFtyVS8 = (Texture)Resources.Load("GameGui/LogIn/LogIn_serverBg", typeof(Texture));
					if (142249 - 191384 == -49135)
					{
						this.iJmcHApblAJ = (Texture)Resources.Load("GameGui/LogIn/LogIn_serverBg2", typeof(Texture));
						if (250755 - 440294 == -189539)
						{
							this.JR0cH9u2lWO = (Texture)Resources.Load("GameGui/LogIn/LogIn_server1", typeof(Texture));
							if (159809 - 336315 == -176506)
							{
								this.sXhcHWXKGgl = (Texture)Resources.Load("GameGui/LogIn/LogIn_server2", typeof(Texture));
								if (49734 - 199066 == -149332)
								{
									this.rr5cHuEYn4h = (Texture)Resources.Load("GameGui/LogIn/LogIn_server3", typeof(Texture));
									if (33485 - 418583 != -385097)
									{
										this.HOxcHyYsOHw = (Texture)Resources.Load("GameGui/LogIn/LogIn_server4", typeof(Texture));
										if (49723 - 411844 == -362121)
										{
											this.mLmcHVpRBRa = (Texture)Resources.Load("GameGui/LogIn/LogIn_server5", typeof(Texture));
											if (154799 - 522505 == -367706)
											{
												this.tWBcHhiy5MQ = (Texture)Resources.Load("GameGui/LogIn/LogIn_server6", typeof(Texture));
												if (254669 - 370533 == -115864)
												{
													this.l4YcHKpFOnW = (Texture)Resources.Load("GameGui/LogIn/LogIn_server1_sm", typeof(Texture));
													if (187037 - 479172 != -292134)
													{
														this.mqycHz8iGwP = (Texture)Resources.Load("GameGui/LogIn/LogIn_server2_sm", typeof(Texture));
														if (170018 - 505809 == -335791)
														{
															this.e5Jc75Fo1nO = (Texture)Resources.Load("GameGui/LogIn/LogIn_server3_sm", typeof(Texture));
															if (14558 - 122220 == -107662)
															{
																this.SVmc7cVVgPZ = (Texture)Resources.Load("GameGui/LogIn/LogIn_server4_sm", typeof(Texture));
																if (51559 - 161916 == -110357)
																{
																	this.txyc7nUl9mn = (Texture)Resources.Load("GameGui/LogIn/LogIn_server5_sm", typeof(Texture));
																	if (29481 - 469404 != -439922)
																	{
																		this.O9nc7QJ6Zfp = (Texture)Resources.Load("GameGui/LogIn/LogIn_server6_sm", typeof(Texture));
																		if (107772 - 416 != 107357)
																		{
																			this.v99c7eSL88p = (Texture)Resources.Load("GameGui/LogIn/unselect1", typeof(Texture));
																			if (283 - 525634 == -525351)
																			{
																				this.rDqc7ISYRqJ = (Texture)Resources.Load("GameGui/LogIn/unselect2", typeof(Texture));
																				if (168901 - 296106 == -127205)
																				{
																					this.nbac7JU6M7u = (Texture)Resources.Load("GameGui/LogIn/unselect3", typeof(Texture));
																					if (200369 - 121102 == 79267)
																					{
																						this.YCUc76KkBAI = (Texture)Resources.Load("GameGui/LogIn/unselect4", typeof(Texture));
																						if (183115 - 554268 == -371153)
																						{
																							this.PUQc7t2NemP = (Texture)Resources.Load("GameGui/LogIn/unselect5", typeof(Texture));
																							if (122878 - 536923 == -414045)
																							{
																								this.tIwc7XDyDOO = (Texture)Resources.Load("GameGui/LogIn/unselect6", typeof(Texture));
																								if (20090 - 383889 == -363799)
																								{
																									this.mSmc7OtZkNF = new GUIStyle();
																									if (278374 - 514410 == -236036)
																									{
																										this.mSmc7OtZkNF.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_selectServer", typeof(Texture)));
																										if (296419 - 184773 != 111647)
																										{
																											this.mSmc7OtZkNF.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_selectServer_h", typeof(Texture)));
																											if (299287 - 330131 != -30843)
																											{
																												this.OCNc72od5wk = (Texture)Resources.Load("GameGui/LogIn/LogIn_realmSelect", typeof(Texture));
																												if (7527 - 514687 != -507159)
																												{
																													this.J7dc7vks1pg = (Texture)Resources.Load("GameGui/LogIn/server1_active", typeof(Texture));
																													if (225851 - 384746 == -158895)
																													{
																														this.hBPc7lv7CZC = (Texture)Resources.Load("GameGui/LogIn/server1_busy", typeof(Texture));
																														if (184026 - 329892 == -145866)
																														{
																															this.S5kc7GvskCE = (Texture)Resources.Load("GameGui/LogIn/server1_full", typeof(Texture));
																															if (97582 - 311028 != -213445)
																															{
																																this.Gimc71bOovA = (Texture)Resources.Load("GameGui/LogIn/server1_down", typeof(Texture));
																																if (58103 - 172913 != -114809)
																																{
																																	this.z2Mc7q66FZ5 = (Texture)Resources.Load("GameGui/LogIn/server2_active", typeof(Texture));
																																	if (76913 - 502620 != -425706)
																																	{
																																		this.SYVc7pi0oZx = (Texture)Resources.Load("GameGui/LogIn/server2_busy", typeof(Texture));
																																		if (135416 - 144967 == -9551)
																																		{
																																			this.WJMc7RDPCWe = (Texture)Resources.Load("GameGui/LogIn/server2_full", typeof(Texture));
																																			if (73493 - 143933 != -70439)
																																			{
																																				this.HPcc7rr6sEw = (Texture)Resources.Load("GameGui/LogIn/server2_down", typeof(Texture));
																																				if (274148 - 227888 == 46260)
																																				{
																																					this.hDpc7x94GMb = (Texture)Resources.Load("GameGui/LogIn/server3_active", typeof(Texture));
																																					if (129074 - 5190 != 123885)
																																					{
																																						this.C5Wc7TClnIg = (Texture)Resources.Load("GameGui/LogIn/server3_busy", typeof(Texture));
																																						if (26378 - 223736 == -197358)
																																						{
																																							this.R8uc7Y8dQ7m = (Texture)Resources.Load("GameGui/LogIn/server3_full", typeof(Texture));
																																							if (254479 - 519906 == -265427)
																																							{
																																								this.Xrcc73k5tI5 = (Texture)Resources.Load("GameGui/LogIn/server3_down", typeof(Texture));
																																								if (38773 - 467801 != -429027)
																																								{
																																									this.hTHc7bhUky2 = (Texture)Resources.Load("GameGui/LogIn/LogIn_noPlayerData", typeof(Texture));
																																									if (63033 - 388456 == -325423)
																																									{
																																										this.Sycc7djurHG = new GUIStyle();
																																										if (64662 - 179755 == -115093)
																																										{
																																											this.Sycc7djurHG.font = (Font)Resources.Load("GameGui/Fonts/Century22", typeof(Font));
																																											if (87475 - 40878 != 46598)
																																											{
																																												this.Sycc7djurHG.normal.textColor = new Color(0.16f, 0.35f, 0.2f, (float)1);
																																												if (240085 - 403347 == -163262)
																																												{
																																													this.Sycc7djurHG.alignment = TextAnchor.MiddleCenter;
																																													if (261161 - 560482 != -299320)
																																													{
																																														this.xIMc7givWRO = new GUIStyle();
																																														if (247512 - 488320 == -240808)
																																														{
																																															this.xIMc7givWRO.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_createPlayer_h", typeof(Texture)));
																																															if (27962 - 249138 != -221175)
																																															{
																																																this.vqNc7aeByv3 = new GUIStyle();
																																																if (231077 - 127601 != 103477)
																																																{
																																																	this.vqNc7aeByv3.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_createBack_h", typeof(Texture)));
																																																	if (144902 - 456348 != -311445)
																																																	{
																																																		this.kdPc74TxMvl = new GUIStyle();
																																																		if (30739 - 196405 != -165665)
																																																		{
																																																			this.kdPc74TxMvl.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_connect", typeof(Texture)));
																																																			if (103207 - 364603 != -261395)
																																																			{
																																																				this.kdPc74TxMvl.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_connect_h", typeof(Texture)));
																																																				if (150273 - 169644 == -19371)
																																																				{
																																																					this.a31c7s9BOaq = new GUIStyle();
																																																					if (188782 - 597051 != -408268)
																																																					{
																																																						this.a31c7s9BOaq.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_left", typeof(Texture)));
																																																						if (292548 - 357290 == -64742)
																																																						{
																																																							this.a31c7s9BOaq = new GUIStyle();
																																																							if (80597 - 374209 == -293612)
																																																							{
																																																								this.a31c7s9BOaq.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_left", typeof(Texture)));
																																																								if (91428 - 147792 == -56364)
																																																								{
																																																									this.B4Lc7HyblDq = new GUIStyle();
																																																									if (139772 - 74611 == 65161)
																																																									{
																																																										this.B4Lc7HyblDq.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_right", typeof(Texture)));
																																																										if (132815 - 100401 != 32415)
																																																										{
																																																											this.J0qc77SOtmC = (Texture)Resources.Load("GameGui/LogIn/LogIn_box", typeof(Texture));
																																																											if (291247 - 91912 == 199335)
																																																											{
																																																												this.reNc7Z2gFdP = new GUIStyle();
																																																												if (43165 - 367350 == -324185)
																																																												{
																																																													this.reNc7Z2gFdP.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_login", typeof(Texture)));
																																																													if (272162 - 225583 != 46580)
																																																													{
																																																														this.adVc7C1QQoX = new GUIStyle();
																																																														if (93128 - 194439 != -101310)
																																																														{
																																																															this.adVc7C1QQoX.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_back", typeof(Texture)));
																																																															if (147573 - 571115 == -423542)
																																																															{
																																																																this.r5Sc7MZ7LeO = new GUIStyle();
																																																																if (166038 - 372555 != -206516)
																																																																{
																																																																	this.r5Sc7MZ7LeO.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_toggle_h", typeof(Texture)));
																																																																	if (156571 - 272473 != -115901)
																																																																	{
																																																																		this.r5Sc7MZ7LeO.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/LogIn/LogIn_toggle_h", typeof(Texture)));
																																																																		if (205293 - 580320 != -375026)
																																																																		{
																																																																			this.PQYc7LyjfnN = new GUIStyle();
																																																																			if (155067 - 193360 == -38293)
																																																																			{
																																																																				this.PQYc7LyjfnN.font = (Font)Resources.Load("GameGui/Fonts/MsSansSerif18", typeof(Font));
																																																																				if (253419 - 477352 != -223932)
																																																																				{
																																																																					this.PQYc7LyjfnN.alignment = TextAnchor.MiddleLeft;
																																																																					if (205076 - 275186 == -70110)
																																																																					{
																																																																						this.la1c7fdXS4o = (Texture)Resources.Load("GameGui/LogIn/LogIn_check", typeof(Texture));
																																																																						if (273870 - 438009 == -164139)
																																																																						{
																																																																							this.KRoc7wcfBXh = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
																																																																							if (65646 - 187259 == -121613)
																																																																							{
																																																																								this.BJ1c7D1kbWE = new GUIStyle();
																																																																								if (36849 - 2855 == 33994)
																																																																								{
																																																																									this.BJ1c7D1kbWE.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																																																									if (252358 - 168489 != 83870)
																																																																									{
																																																																										this.BJ1c7D1kbWE.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																																																										if (267876 - 581224 == -313348)
																																																																										{
																																																																											this.BJ1c7D1kbWE.alignment = TextAnchor.MiddleCenter;
																																																																											if (246677 - 306774 == -60097)
																																																																											{
																																																																												this.gPRc7NJerAX = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
																																																																												if (207617 - 373216 == -165599)
																																																																												{
																																																																													this.MBIc7ErE7d1 = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																																																																													if (23081 - 579295 != -556213)
																																																																													{
																																																																														this.BrDc7PyG81J = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																																																																														if (243446 - 180156 == 63290)
																																																																														{
																																																																															this.hEMc7SHDLid = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																																																																															if (18337 - 110671 == -92334)
																																																																															{
																																																																																this.i6gc7BHjBej = (AudioClip)Resources.Load("Sound/GUI/tick", typeof(AudioClip));
																																																																																if (106608 - 286197 == -179589)
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
	}

	// Token: 0x060061AA RID: 25002 RVA: 0x00D68A9C File Offset: 0x00D66C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (298675 - 225047 != 73628)
		{
		}
		for (;;)
		{
			Application.targetFrameRate = 80;
			if (190156 - 394228 == -204072)
			{
				Application.runInBackground = true;
				if (49045 - 396679 == -347634)
				{
					if (PlayerPrefs.GetInt("playIntro", 1) != 0)
					{
						if (296646 - 11040 == 285606)
						{
							this.g70cH0qkdyF = eLoginState.intro;
							if (200357 - 173542 == 26815)
							{
								this.VYxcH839KbV = Time.time;
								if (139473 - 57351 == 82122)
								{
									break;
								}
							}
						}
					}
					else
					{
						this.g70cH0qkdyF = eLoginState.fadeIn;
						if (91826 - 68170 != 23657)
						{
							this.VYxcH839KbV = Time.time;
							if (271336 - 278943 == -7607)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060061AB RID: 25003 RVA: 0x00D68BD0 File Offset: 0x00D66DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onNewPDat(Hashtable data)
	{
		if (258270 - 52691 != 205579)
		{
		}
		for (;;)
		{
			if (RuntimeServices.ToBool(RuntimeServices.InvokeBinaryOperator("op_GreaterThan", data[31], 0)))
			{
				if (288725 - 122319 != 166407)
				{
					this.g70cH0qkdyF = eLoginState.createPlayerSuccess;
					if (12719 - 589813 == -577094)
					{
						this.VYxcH839KbV = Time.time;
						if (285408 - 103558 != 181851)
						{
							break;
						}
					}
				}
			}
			else
			{
				this.g70cH0qkdyF = eLoginState.createPlayerFail;
				if (68441 - 402350 == -333909)
				{
					this.VYxcH839KbV = Time.time;
					if (83394 - 162161 == -78767)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060061AC RID: 25004 RVA: 0x00D68CDC File Offset: 0x00D66EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadGuildData()
	{
		if (165170 - 95049 != 70122)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (229132 - 523608 != -294475)
			{
				hashtable.Add(47, PlayerData.GID);
				if (136383 - 308990 == -172607)
				{
					this.miDcHLXbUVB.OpCustom(27, hashtable, true);
					if (21969 - 255705 != -233735)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060061AD RID: 25005 RVA: 0x00D68D90 File Offset: 0x00D66F90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadGuildData(Hashtable data)
	{
		if (132130 - 13221 != 118909)
		{
		}
		for (;;)
		{
			if (!RuntimeServices.EqualityOperator(data[47], null))
			{
				if (179078 - 551424 == -372345)
				{
					continue;
				}
				PlayerData.GID = RuntimeServices.UnboxInt32(data[47]);
				if (261092 - 462363 != -201271)
				{
					continue;
				}
			}
			this.g70cH0qkdyF = eLoginState.join;
			if (198842 - 47479 != 151364)
			{
				this.VYxcH839KbV = Time.time;
				if (267867 - 77619 == 190248)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060061AE RID: 25006 RVA: 0x00D68E74 File Offset: 0x00D67074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (144875 - 289667 != -144792)
		{
		}
		for (;;)
		{
			if (Input.mousePosition != this.Ak7c7jFvDCX)
			{
				goto IL_B51;
			}
			if (265110 - 367514 == -102403)
			{
				continue;
			}
			if (Event.current.type == EventType.MouseDown)
			{
				goto IL_B51;
			}
			if (118066 - 200045 == -81978)
			{
				continue;
			}
			if (Event.current.type == EventType.KeyDown)
			{
				if (179125 - 595136 != -416011)
				{
					continue;
				}
				goto IL_B51;
			}
			IL_12A3:
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (276263 - 337829 != -61566)
			{
				continue;
			}
			GUI.depth = 2;
			if (268899 - 586118 != -317219)
			{
				continue;
			}
			this.XT6cHiD1IDO = (float)(1024 * Screen.width / Screen.height);
			if (149656 - 122116 == 27541)
			{
				continue;
			}
			GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)960, (float)0, (float)1920, (float)1024), this.Fj0cHo2XFT9);
			if (242870 - 56934 == 185937)
			{
				continue;
			}
			eLoginState eLoginState = this.g70cH0qkdyF;
			if (85323 - 284424 != -199101)
			{
				continue;
			}
			if (eLoginState == eLoginState.Init)
			{
				if (259494 - 562091 == -302596)
				{
					continue;
				}
				GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)960, (float)0, (float)1920, (float)1024), this.WdBcHkYaEHh);
				if (71562 - 361194 != -289631)
				{
					break;
				}
				continue;
			}
			else if (eLoginState == eLoginState.intro)
			{
				if (8583 - 418909 != -410326)
				{
					continue;
				}
				GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)960, (float)0, (float)1920, (float)1024), this.WdBcHkYaEHh);
				if (173288 - 29324 != 143964)
				{
					continue;
				}
				if (!this.introMovie)
				{
					break;
				}
				if (135330 - 63075 == 72256)
				{
					continue;
				}
				GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)600, (float)200, (float)1200, (float)600), this.introMovie);
				if (81760 - 557287 == -475526)
				{
					continue;
				}
				if (!this.introMovie.isPlaying)
				{
					if (185184 - 592812 != -407628)
					{
						continue;
					}
					this.audio.clip = this.introMovie.audioClip;
					if (269965 - 172663 == 97303)
					{
						continue;
					}
					this.introMovie.Play();
					if (18564 - 71562 != -52998)
					{
						continue;
					}
					this.audio.Play();
					if (87834 - 595600 == -507765)
					{
						continue;
					}
				}
				if (!Input.GetKeyDown("escape"))
				{
					if (230553 - 43382 != 187171)
					{
						continue;
					}
					if (!Input.GetKeyDown(KeyCode.Space))
					{
						if (287273 - 508317 == -221043)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Return))
						{
							if (258105 - 130185 != 127920)
							{
								continue;
							}
							if (Time.time <= this.VYxcH839KbV + this.introMovie.duration)
							{
								break;
							}
							if (115897 - 448029 != -332132)
							{
								continue;
							}
						}
					}
				}
				this.introMovie.Stop();
				if (1514 - 191226 != -189712)
				{
					continue;
				}
				this.audio.Stop();
				if (132364 - 90427 != 41937)
				{
					continue;
				}
				this.g70cH0qkdyF = eLoginState.fadeIn;
				if (49491 - 464417 != -414926)
				{
					continue;
				}
				this.VYxcH839KbV = Time.time;
				if (6024 - 568780 == -562755)
				{
					continue;
				}
				this.fy2c7mSbCb0 = Time.time;
				if (161191 - 405801 == -244609)
				{
					continue;
				}
				PlayerPrefs.SetInt("playIntro", 0);
				if (283513 - 71379 != 212135)
				{
					break;
				}
				continue;
			}
			else if (eLoginState == eLoginState.fadeIn)
			{
				if (288147 - 278053 != 10094)
				{
					continue;
				}
				if (Time.time < this.VYxcH839KbV + 0.5f)
				{
					if (53214 - 485947 != -432733)
					{
						continue;
					}
					float a = (float)2 * (this.VYxcH839KbV + 0.5f - Time.time);
					if (75014 - 101492 != -26478)
					{
						continue;
					}
					Color color = GUI.color;
					if (254452 - 305683 == -51230)
					{
						continue;
					}
					color.a = a;
					if (5821 - 479537 != -473716)
					{
						continue;
					}
					if (144592 - 456864 == -312271)
					{
						continue;
					}
					Color color2 = GUI.color = color;
					if (19837 - 292762 != -272925)
					{
						continue;
					}
					if (77172 - 141789 != -64617)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)960, (float)0, (float)1920, (float)1024), this.WdBcHkYaEHh);
					if (181112 - 33041 == 148072)
					{
						continue;
					}
					int num = 1;
					if (258345 - 81875 != 176470)
					{
						continue;
					}
					Color color3 = GUI.color;
					if (102774 - 95335 != 7439)
					{
						continue;
					}
					float num2 = color3.a = (float)num;
					if (146079 - 413983 == -267903)
					{
						continue;
					}
					if (17815 - 184915 != -167100)
					{
						continue;
					}
					Color color4 = GUI.color = color3;
					if (277684 - 290686 != -13002)
					{
						continue;
					}
					if (54988 - 252705 != -197716)
					{
						break;
					}
					continue;
				}
				else if (!this.Xn5c7oNkmoQ)
				{
					if (214847 - 590005 == -375157)
					{
						continue;
					}
					this.g70cH0qkdyF = eLoginState.nProtect;
					if (274347 - 555417 == -281069)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (167013 - 312390 != -145377)
					{
						continue;
					}
					this.StartCoroutine_Auto(this.StartNProtect());
					if (19713 - 435998 != -416285)
					{
						continue;
					}
					break;
				}
				else
				{
					this.g70cH0qkdyF = eLoginState.serverSelect;
					if (222088 - 148425 == 73664)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (149239 - 517941 != -368702)
					{
						continue;
					}
					break;
				}
			}
			else if (eLoginState == eLoginState.nProtect)
			{
				if (258655 - 255443 == 3213)
				{
					continue;
				}
				this.RenderNoticeMessage("Starting nProtect service...");
				if (132493 - 261652 != -129158)
				{
					break;
				}
				continue;
			}
			else if (eLoginState == eLoginState.serverSelect)
			{
				if (36815 - 46369 != -9554)
				{
					continue;
				}
				GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)276, (float)735, (float)620, (float)206), this.QnucHFtyVS8);
				if (195624 - 555125 == -359500)
				{
					continue;
				}
				int num3 = this.s2WcHw6McLY;
				if (130997 - 449926 != -318929)
				{
					continue;
				}
				if (num3 == 0)
				{
					if (265424 - 473527 != -208103)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)109, (float)724, (float)262, (float)170), this.JR0cH9u2lWO);
					if (223335 - 403091 != -179756)
					{
						continue;
					}
				}
				else if (num3 == 1)
				{
					if (127458 - 266711 == -139252)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)109, (float)724, (float)262, (float)170), this.sXhcHWXKGgl);
					if (292722 - 320854 == -28131)
					{
						continue;
					}
				}
				else if (num3 == 2)
				{
					if (277313 - 161932 != 115381)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)109, (float)724, (float)262, (float)170), this.rr5cHuEYn4h);
					if (263521 - 104298 != 159223)
					{
						continue;
					}
				}
				else if (num3 == 3)
				{
					if (168828 - 318992 != -150164)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)109, (float)724, (float)262, (float)170), this.HOxcHyYsOHw);
					if (289302 - 561047 != -271745)
					{
						continue;
					}
				}
				else if (num3 == 4)
				{
					if (171121 - 369923 != -198802)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)109, (float)724, (float)262, (float)170), this.mLmcHVpRBRa);
					if (5855 - 432688 == -426832)
					{
						continue;
					}
				}
				else if (num3 == 5)
				{
					if (157951 - 288283 != -130332)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)109, (float)724, (float)262, (float)170), this.tWBcHhiy5MQ);
					if (151629 - 187394 == -35764)
					{
						continue;
					}
				}
				int num4 = this.s2WcHw6McLY;
				if (42269 - 436545 == -394275)
				{
					continue;
				}
				if (num4 == 0)
				{
					if (211350 - 71959 == 139392)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)265, (float)790, (float)64, (float)64), this.tIwc7XDyDOO);
					if (207535 - 501222 != -293687)
					{
						continue;
					}
				}
				else if (num4 == 1)
				{
					if (208928 - 465874 == -256945)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)265, (float)790, (float)64, (float)64), this.v99c7eSL88p);
					if (188884 - 214479 != -25595)
					{
						continue;
					}
				}
				else if (num4 == 2)
				{
					if (84417 - 364767 != -280350)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)265, (float)790, (float)64, (float)64), this.rDqc7ISYRqJ);
					if (133551 - 265667 != -132116)
					{
						continue;
					}
				}
				else if (num4 == 3)
				{
					if (291997 - 148331 != 143666)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)265, (float)790, (float)64, (float)64), this.nbac7JU6M7u);
					if (120504 - 450269 != -329765)
					{
						continue;
					}
				}
				else if (num4 == 4)
				{
					if (235592 - 24200 != 211392)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)265, (float)790, (float)64, (float)64), this.YCUc76KkBAI);
					if (200181 - 121533 == 78649)
					{
						continue;
					}
				}
				else if (num4 == 5)
				{
					if (128981 - 205747 != -76766)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)265, (float)790, (float)64, (float)64), this.PUQc7t2NemP);
					if (162496 - 225714 != -63218)
					{
						continue;
					}
				}
				int num5 = this.s2WcHw6McLY;
				if (49151 - 555242 == -506090)
				{
					continue;
				}
				if (num5 == 0)
				{
					if (100461 - 577841 != -477380)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)252, (float)790, (float)64, (float)64), this.rDqc7ISYRqJ);
					if (7250 - 306916 == -299665)
					{
						continue;
					}
				}
				else if (num5 == 1)
				{
					if (274591 - 342752 == -68160)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)252, (float)790, (float)64, (float)64), this.nbac7JU6M7u);
					if (36234 - 298562 != -262328)
					{
						continue;
					}
				}
				else if (num5 == 2)
				{
					if (220844 - 598547 == -377702)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)252, (float)790, (float)64, (float)64), this.YCUc76KkBAI);
					if (187904 - 443243 != -255339)
					{
						continue;
					}
				}
				else if (num5 == 3)
				{
					if (136790 - 51871 == 84920)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)252, (float)790, (float)64, (float)64), this.PUQc7t2NemP);
					if (295748 - 211173 == 84576)
					{
						continue;
					}
				}
				else if (num5 == 4)
				{
					if (68535 - 141985 == -73449)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)252, (float)790, (float)64, (float)64), this.tIwc7XDyDOO);
					if (226960 - 87950 != 139010)
					{
						continue;
					}
				}
				else if (num5 == 5)
				{
					if (76181 - 526067 != -449886)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)252, (float)790, (float)64, (float)64), this.v99c7eSL88p);
					if (214467 - 543239 != -328772)
					{
						continue;
					}
				}
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO - (float)42, (float)875, (float)138, (float)36), string.Empty, this.kdPc74TxMvl))
				{
					if (191751 - 32380 != 159371)
					{
						continue;
					}
					if (this.MBIc7ErE7d1)
					{
						if (78996 - 543006 != -464010)
						{
							continue;
						}
						this.audio.PlayOneShot(this.MBIc7ErE7d1);
						if (76577 - 173967 == -97389)
						{
							continue;
						}
					}
					this.g70cH0qkdyF = eLoginState.login;
					if (6236 - 303614 != -297378)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (94198 - 466932 == -372733)
					{
						continue;
					}
				}
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO - (float)197, (float)786, (float)80, (float)79), string.Empty, this.a31c7s9BOaq))
				{
					if (98624 - 48358 == 50267)
					{
						continue;
					}
					this.s2WcHw6McLY = (int)Mathf.Repeat((float)(--this.s2WcHw6McLY), (float)6);
					if (265808 - 564904 == -299095)
					{
						continue;
					}
					if (this.hEMc7SHDLid)
					{
						if (111852 - 96138 != 15714)
						{
							continue;
						}
						this.audio.PlayOneShot(this.i6gc7BHjBej);
						if (18815 - 516695 != -497880)
						{
							continue;
						}
					}
				}
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO + (float)169, (float)786, (float)80, (float)79), string.Empty, this.B4Lc7HyblDq))
				{
					if (88426 - 100377 != -11951)
					{
						continue;
					}
					this.s2WcHw6McLY = (int)Mathf.Repeat((float)(++this.s2WcHw6McLY), (float)6);
					if (110109 - 416649 == -306539)
					{
						continue;
					}
					if (this.hEMc7SHDLid)
					{
						if (238208 - 138733 == 99476)
						{
							continue;
						}
						this.audio.PlayOneShot(this.i6gc7BHjBej);
						if (104284 - 445366 != -341082)
						{
							continue;
						}
					}
				}
				if (this.fy2c7mSbCb0 + (float)30 >= Time.time)
				{
					break;
				}
				if (285619 - 154748 == 130872)
				{
					continue;
				}
				if (this.Xn5c7oNkmoQ)
				{
					if (275437 - 475696 != -200259)
					{
						continue;
					}
					this.introMovie.Stop();
					if (175459 - 103968 != 71491)
					{
						continue;
					}
					this.g70cH0qkdyF = eLoginState.intro;
					if (160756 - 493437 == -332680)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (57025 - 501511 != -444485)
					{
						break;
					}
					continue;
				}
				else
				{
					float time = Time.time;
					if (170581 - 552650 != -382068)
					{
						break;
					}
					continue;
				}
			}
			else if (eLoginState == eLoginState.login)
			{
				if (181203 - 325800 != -144597)
				{
					continue;
				}
				int num6 = this.s2WcHw6McLY;
				if (205834 - 127346 == 78489)
				{
					continue;
				}
				if (num6 == 0)
				{
					if (271003 - 230840 != 40163)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)268, (float)725, (float)173, (float)153), this.l4YcHKpFOnW);
					if (88578 - 378971 != -290393)
					{
						continue;
					}
				}
				else if (num6 == 1)
				{
					if (286366 - 30980 == 255387)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)268, (float)725, (float)173, (float)153), this.mqycHz8iGwP);
					if (234986 - 494264 == -259277)
					{
						continue;
					}
				}
				else if (num6 == 2)
				{
					if (12463 - 559420 == -546956)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)268, (float)725, (float)173, (float)153), this.e5Jc75Fo1nO);
					if (107026 - 160171 == -53144)
					{
						continue;
					}
				}
				else if (num6 == 3)
				{
					if (247828 - 100696 != 147132)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)268, (float)725, (float)173, (float)153), this.SVmc7cVVgPZ);
					if (194537 - 404089 != -209552)
					{
						continue;
					}
				}
				else if (num6 == 4)
				{
					if (62071 - 360786 == -298714)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)268, (float)725, (float)173, (float)153), this.txyc7nUl9mn);
					if (39042 - 401071 == -362028)
					{
						continue;
					}
				}
				else if (num6 == 5)
				{
					if (209589 - 51101 == 158489)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)268, (float)725, (float)173, (float)153), this.O9nc7QJ6Zfp);
					if (82213 - 134822 == -52608)
					{
						continue;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)268, (float)725, (float)173, (float)153), this.l4YcHKpFOnW);
					if (234077 - 446670 == -212592)
					{
						continue;
					}
				}
				GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)146, (float)736, (float)435, (float)141), this.J0qc77SOtmC);
				if (136713 - 175722 != -39009)
				{
					continue;
				}
				if (Event.current.type != EventType.KeyDown)
				{
					goto IL_3D9B;
				}
				if (105504 - 235150 == -129645)
				{
					continue;
				}
				if (!(Event.current.character == "\n"))
				{
					goto IL_3D9B;
				}
				if (269425 - 303176 != -33751)
				{
					continue;
				}
				GUI.Label(new Rect(0.5f * this.XT6cHiD1IDO - (float)65, (float)751, (float)200, (float)30), this.tABcHN2BdYM, this.PQYc7LyjfnN);
				if (19289 - 443442 == -424152)
				{
					continue;
				}
				GUI.Label(new Rect(0.5f * this.XT6cHiD1IDO - (float)65, (float)791, (float)200, (float)30), this.SJpcHE2Ikad, this.PQYc7LyjfnN);
				if (198530 - 55790 != 142740)
				{
					continue;
				}
				IL_193E:
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO + (float)130, (float)754, (float)24, (float)24), string.Empty, this.r5Sc7MZ7LeO))
				{
					if (18630 - 561581 == -542950)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("saveUser", 0) != 0)
					{
						if (282734 - 488561 != -205827)
						{
							continue;
						}
						PlayerPrefs.SetInt("saveUser", 0);
						if (104707 - 327260 != -222553)
						{
							continue;
						}
					}
					else
					{
						PlayerPrefs.SetInt("saveUser", 1);
						if (294128 - 259146 != 34982)
						{
							continue;
						}
					}
					if (this.hEMc7SHDLid)
					{
						if (83880 - 204675 != -120795)
						{
							continue;
						}
						this.audio.PlayOneShot(this.hEMc7SHDLid);
						if (178301 - 297131 != -118830)
						{
							continue;
						}
					}
				}
				if (PlayerPrefs.GetInt("saveUser", 0) != 0)
				{
					if (164181 - 89593 != 74588)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)132, (float)756, (float)20, (float)20), this.la1c7fdXS4o);
					if (1552 - 156662 == -155109)
					{
						continue;
					}
				}
				if (Stringf.isSafe(this.tABcHN2BdYM))
				{
					if (220814 - 86095 != 134719)
					{
						continue;
					}
					if (Stringf.isSafe(this.SJpcHE2Ikad))
					{
						if (93693 - 374343 != -280650)
						{
							continue;
						}
						if (!GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO - (float)68, (float)832, (float)136, (float)36), string.Empty, this.reNc7Z2gFdP))
						{
							if (269200 - 127846 == 141355)
							{
								continue;
							}
							if (Event.current.type != EventType.KeyDown)
							{
								goto IL_7BF;
							}
							if (284109 - 395118 == -111008)
							{
								continue;
							}
							if (!(Event.current.character == "\n"))
							{
								goto IL_7BF;
							}
							if (29836 - 261348 != -231512)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("saveUser", 0) != 0)
						{
							if (25799 - 376534 == -350734)
							{
								continue;
							}
							PlayerPrefs.SetString("username", this.tABcHN2BdYM);
							if (244640 - 506501 != -261861)
							{
								continue;
							}
						}
						this.g70cH0qkdyF = eLoginState.loginServer;
						if (41986 - 525638 == -483651)
						{
							continue;
						}
						this.VYxcH839KbV = Time.time;
						if (126392 - 548171 != -421779)
						{
							continue;
						}
						if (this.gPRc7NJerAX)
						{
							if (158227 - 138499 == 19729)
							{
								continue;
							}
							this.audio.PlayOneShot(this.gPRc7NJerAX);
							if (266947 - 184610 != 82337)
							{
								continue;
							}
						}
					}
				}
				IL_7BF:
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO + (float)68, (float)832, (float)51, (float)36), string.Empty, this.adVc7C1QQoX))
				{
					if (69063 - 309788 != -240725)
					{
						continue;
					}
					this.g70cH0qkdyF = eLoginState.serverSelect;
					if (218959 - 581395 != -362436)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (248009 - 399274 == -151264)
					{
						continue;
					}
					if (this.BrDc7PyG81J)
					{
						if (192072 - 230049 == -37976)
						{
							continue;
						}
						this.audio.PlayOneShot(this.BrDc7PyG81J);
						if (122124 - 592155 == -470030)
						{
							continue;
						}
					}
				}
				if (this.fy2c7mSbCb0 + (float)60 >= Time.time)
				{
					break;
				}
				if (221580 - 228713 != -7133)
				{
					continue;
				}
				if (this.Xn5c7oNkmoQ)
				{
					if (211213 - 409686 != -198473)
					{
						continue;
					}
					this.introMovie.Stop();
					if (95657 - 15878 == 79780)
					{
						continue;
					}
					this.g70cH0qkdyF = eLoginState.intro;
					if (5382 - 191165 != -185783)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (24613 - 408066 != -383452)
					{
						break;
					}
					continue;
				}
				else
				{
					float time = Time.time;
					if (91031 - 189122 != -98090)
					{
						break;
					}
					continue;
				}
				IL_3D9B:
				this.tABcHN2BdYM = GUI.TextField(new Rect(0.5f * this.XT6cHiD1IDO - (float)65, (float)751, (float)200, (float)30), this.tABcHN2BdYM, 15, this.PQYc7LyjfnN);
				if (104431 - 442689 == -338257)
				{
					continue;
				}
				this.SJpcHE2Ikad = GUI.PasswordField(new Rect(0.5f * this.XT6cHiD1IDO - (float)65, (float)785, (float)200, (float)30), this.SJpcHE2Ikad, "*"[0], 15, this.PQYc7LyjfnN);
				if (9801 - 436754 != -426953)
				{
					continue;
				}
				goto IL_193E;
			}
			else if (eLoginState == eLoginState.loginServer)
			{
				if (116126 - 224509 == -108382)
				{
					continue;
				}
				if (Time.time - this.VYxcH839KbV < (float)1)
				{
					if (120125 - 459445 != -339320)
					{
						continue;
					}
					this.RenderNoticeMessage("Logging in..");
					if (200668 - 458867 != -258199)
					{
						continue;
					}
					break;
				}
				else
				{
					this.g70cH0qkdyF = eLoginState.loginFail;
					if (267345 - 394278 == -126932)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (160798 - 297964 == -137165)
					{
						continue;
					}
					this.r3AcHB7rp0m = "Unknown login error";
					if (94315 - 258490 == -164174)
					{
						continue;
					}
					string text = LogInServer.LogIn(this.s2WcHw6McLY, this.tABcHN2BdYM, this.SJpcHE2Ikad);
					if (54669 - 380584 == -325914)
					{
						continue;
					}
					if (Extensions.get_length(text) <= 0)
					{
						break;
					}
					if (297348 - 541906 != -244558)
					{
						continue;
					}
					if (text[0] == "1")
					{
						if (110926 - 167457 == -56530)
						{
							continue;
						}
						if (Extensions.get_length(text) > 1)
						{
							if (6577 - 64426 == -57848)
							{
								continue;
							}
							this.WLlcHPyMpsF = text.Substring(1);
							if (202815 - 183236 != 19579)
							{
								continue;
							}
							this.c9xcHSf7FwR = Encryption.SimpleEncrypt(this.tABcHN2BdYM);
							if (219505 - 363517 != -144012)
							{
								continue;
							}
							if (this.s2WcHw6McLY < 2)
							{
								if (4937 - 457889 != -452952)
								{
									continue;
								}
								this.g70cH0qkdyF = eLoginState.realmSelect;
								if (148898 - 487211 != -338313)
								{
									continue;
								}
								this.VYxcH839KbV = Time.time;
								if (157137 - 306569 != -149432)
								{
									continue;
								}
								break;
							}
							else
							{
								this.StartCoroutine_Auto(this.Connect(this.s2WcHw6McLY, 0));
								if (38926 - 71609 != -32682)
								{
									break;
								}
								continue;
							}
						}
					}
					this.g70cH0qkdyF = eLoginState.loginFail;
					if (100416 - 469739 != -369323)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (234120 - 39790 != 194330)
					{
						continue;
					}
					char lhs = text[0];
					if (253914 - 215752 != 38162)
					{
						continue;
					}
					if (lhs == "0")
					{
						if (48289 - 343789 != -295500)
						{
							continue;
						}
						this.r3AcHB7rp0m = "Log in server down";
						if (32231 - 365514 != -333283)
						{
							continue;
						}
						break;
					}
					else if (lhs == "1")
					{
						if (284719 - 529214 == -244494)
						{
							continue;
						}
						this.r3AcHB7rp0m = "Player name registration error";
						if (137490 - 95649 != 41841)
						{
							continue;
						}
						break;
					}
					else if (lhs == "2")
					{
						if (269496 - 25829 != 243667)
						{
							continue;
						}
						this.r3AcHB7rp0m = "User already logged in!";
						if (60327 - 47142 != 13186)
						{
							break;
						}
						continue;
					}
					else if (lhs == "3")
					{
						if (248154 - 129034 == 119121)
						{
							continue;
						}
						this.r3AcHB7rp0m = "Wrong user name and password";
						if (103788 - 361341 != -257553)
						{
							continue;
						}
						break;
					}
					else if (lhs == "4")
					{
						if (170402 - 185071 != -14669)
						{
							continue;
						}
						this.r3AcHB7rp0m = "Wrong game version";
						if (284356 - 85659 != 198697)
						{
							continue;
						}
						break;
					}
					else
					{
						if (!(lhs == "5"))
						{
							break;
						}
						if (41272 - 535050 != -493778)
						{
							continue;
						}
						this.r3AcHB7rp0m = "User banned for: " + text.Substring(1) + " days";
						if (251670 - 123772 != 127898)
						{
							continue;
						}
						break;
					}
				}
			}
			else if (eLoginState == eLoginState.loginFail)
			{
				if (181156 - 224121 != -42965)
				{
					continue;
				}
				if (Time.time - this.VYxcH839KbV < (float)2)
				{
					if (103202 - 269202 == -165999)
					{
						continue;
					}
					this.RenderNoticeMessage(this.r3AcHB7rp0m);
					if (2016 - 488134 != -486117)
					{
						break;
					}
					continue;
				}
				else
				{
					this.g70cH0qkdyF = eLoginState.login;
					if (36226 - 512162 == -475935)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (51686 - 291106 != -239419)
					{
						break;
					}
					continue;
				}
			}
			else if (eLoginState == eLoginState.realmSelect)
			{
				if (120109 - 344444 != -224335)
				{
					continue;
				}
				GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)276, (float)735, (float)620, (float)206), this.iJmcHApblAJ);
				if (79871 - 488063 == -408191)
				{
					continue;
				}
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO - (float)140, (float)748, (float)86, (float)143), string.Empty, this.mSmc7OtZkNF))
				{
					if (136958 - 269179 != -132221)
					{
						continue;
					}
					if (this.MBIc7ErE7d1)
					{
						if (87637 - 465472 == -377834)
						{
							continue;
						}
						this.audio.PlayOneShot(this.MBIc7ErE7d1);
						if (60594 - 148219 == -87624)
						{
							continue;
						}
					}
					this.StartCoroutine_Auto(this.Connect(this.s2WcHw6McLY, 1));
					if (142176 - 532413 == -390236)
					{
						continue;
					}
				}
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO - (float)21, (float)748, (float)86, (float)143), string.Empty, this.mSmc7OtZkNF))
				{
					if (121562 - 319394 == -197831)
					{
						continue;
					}
					if (this.MBIc7ErE7d1)
					{
						if (133595 - 470859 == -337263)
						{
							continue;
						}
						this.audio.PlayOneShot(this.MBIc7ErE7d1);
						if (108041 - 106688 == 1354)
						{
							continue;
						}
					}
					this.StartCoroutine_Auto(this.Connect(this.s2WcHw6McLY, 2));
					if (164494 - 220368 != -55874)
					{
						continue;
					}
				}
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO + (float)96, (float)748, (float)86, (float)143), string.Empty, this.mSmc7OtZkNF))
				{
					if (250280 - 400299 == -150018)
					{
						continue;
					}
					if (this.MBIc7ErE7d1)
					{
						if (211140 - 575810 != -364670)
						{
							continue;
						}
						this.audio.PlayOneShot(this.MBIc7ErE7d1);
						if (94283 - 314253 == -219969)
						{
							continue;
						}
					}
					this.StartCoroutine_Auto(this.Connect(this.s2WcHw6McLY, 3));
					if (273812 - 62817 == 210996)
					{
						continue;
					}
				}
				if (Extensions.get_length(LogInServer.serverStatus) == 10)
				{
					if (242857 - 70316 == 172542)
					{
						continue;
					}
					int num7 = this.s2WcHw6McLY;
					if (52785 - 26876 == 25910)
					{
						continue;
					}
					if (num7 == 0)
					{
						if (178307 - 558971 == -380663)
						{
							continue;
						}
						if (LogInServer.serverStatus[1] == "1")
						{
							if (120816 - 454367 == -333550)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.J7dc7vks1pg);
							if (276542 - 176872 != 99670)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[1] == "2")
						{
							if (47017 - 72294 == -25276)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.hBPc7lv7CZC);
							if (227934 - 44260 != 183674)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[1] == "3")
						{
							if (14190 - 466294 != -452104)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.S5kc7GvskCE);
							if (45042 - 475269 != -430227)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.Gimc71bOovA);
							if (136380 - 108089 != 28291)
							{
								continue;
							}
						}
						if (LogInServer.serverStatus[2] == "1")
						{
							if (203777 - 521143 != -317366)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.J7dc7vks1pg);
							if (121765 - 499147 == -377381)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[2] == "2")
						{
							if (260561 - 585132 != -324571)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.hBPc7lv7CZC);
							if (205544 - 421092 != -215548)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[2] == "3")
						{
							if (263806 - 225462 == 38345)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.S5kc7GvskCE);
							if (276429 - 527595 != -251166)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.Gimc71bOovA);
							if (207930 - 181396 == 26535)
							{
								continue;
							}
						}
						if (LogInServer.serverStatus[3] == "1")
						{
							if (62800 - 594057 == -531256)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.J7dc7vks1pg);
							if (258144 - 224097 != 34047)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[3] == "2")
						{
							if (182507 - 6435 == 176073)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.hBPc7lv7CZC);
							if (148584 - 36622 != 111962)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[3] == "3")
						{
							if (119037 - 180356 != -61319)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.S5kc7GvskCE);
							if (95409 - 347423 == -252013)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.Gimc71bOovA);
							if (287870 - 576614 == -288743)
							{
								continue;
							}
						}
					}
					else if (num7 == 1)
					{
						if (227239 - 17144 != 210095)
						{
							continue;
						}
						if (LogInServer.serverStatus[4] == "1")
						{
							if (95803 - 509140 != -413337)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.z2Mc7q66FZ5);
							if (176823 - 459174 == -282350)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[4] == "2")
						{
							if (144721 - 567785 != -423064)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.SYVc7pi0oZx);
							if (117330 - 544261 == -426930)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[4] == "3")
						{
							if (118599 - 589662 == -471062)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.WJMc7RDPCWe);
							if (198046 - 258951 != -60905)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.HPcc7rr6sEw);
							if (248459 - 306429 == -57969)
							{
								continue;
							}
						}
						if (LogInServer.serverStatus[5] == "1")
						{
							if (151381 - 269447 == -118065)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.z2Mc7q66FZ5);
							if (108846 - 420114 == -311267)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[5] == "2")
						{
							if (220256 - 545267 == -325010)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.SYVc7pi0oZx);
							if (142090 - 218802 != -76712)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[5] == "3")
						{
							if (274768 - 343725 != -68957)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.WJMc7RDPCWe);
							if (182712 - 412970 == -230257)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.HPcc7rr6sEw);
							if (246460 - 58449 == 188012)
							{
								continue;
							}
						}
						if (LogInServer.serverStatus[6] == "1")
						{
							if (85026 - 65215 == 19812)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.z2Mc7q66FZ5);
							if (187080 - 386784 != -199704)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[6] == "2")
						{
							if (232788 - 287522 == -54733)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.SYVc7pi0oZx);
							if (267527 - 22684 != 244843)
							{
								continue;
							}
						}
						else if (LogInServer.serverStatus[6] == "3")
						{
							if (293802 - 184238 == 109565)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.WJMc7RDPCWe);
							if (31790 - 190763 == -158972)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.HPcc7rr6sEw);
							if (31901 - 9968 != 21933)
							{
								continue;
							}
						}
					}
					else
					{
						GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)151, (float)746, (float)111, (float)160), this.J7dc7vks1pg);
						if (99081 - 322964 == -223882)
						{
							continue;
						}
						GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)30, (float)746, (float)111, (float)160), this.J7dc7vks1pg);
						if (249057 - 541770 != -292713)
						{
							continue;
						}
						GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO + (float)87, (float)746, (float)111, (float)160), this.J7dc7vks1pg);
						if (203317 - 157482 == 45836)
						{
							continue;
						}
					}
				}
				GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)152, (float)824, (float)349, (float)67), this.OCNc72od5wk);
				if (280371 - 434707 != -154336)
				{
					continue;
				}
				break;
			}
			else if (eLoginState == eLoginState.connecting)
			{
				if (135105 - 369670 == -234564)
				{
					continue;
				}
				if (Time.time - this.VYxcH839KbV < (float)3)
				{
					if (42153 - 6417 != 35736)
					{
						continue;
					}
					this.RenderNoticeMessage("Connecting..");
					if (297620 - 61193 != 236428)
					{
						break;
					}
					continue;
				}
				else
				{
					if (!RuntimeServices.EqualityOperator(this.miDcHLXbUVB, null))
					{
						if (69997 - 15860 != 54137)
						{
							continue;
						}
						PhotonListener photonListener = (PhotonListener)this.mListener.GetComponent(typeof(PhotonListener));
						if (264589 - 5678 != 258911)
						{
							continue;
						}
						if (photonListener)
						{
							if (261170 - 293364 == -32193)
							{
								continue;
							}
							photonListener.CloseConnection();
							if (71247 - 33899 == 37349)
							{
								continue;
							}
						}
					}
					this.g70cH0qkdyF = eLoginState.serverDown;
					if (251826 - 327420 == -75593)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (96894 - 391032 != -294137)
					{
						break;
					}
					continue;
				}
			}
			else if (eLoginState == eLoginState.connected)
			{
				if (16932 - 98979 != -82047)
				{
					continue;
				}
				if (Time.time - this.VYxcH839KbV < (float)1)
				{
					if (129742 - 577998 == -448255)
					{
						continue;
					}
					this.RenderNoticeMessage("Retrieving player data..");
					if (65180 - 555592 != -490411)
					{
						break;
					}
					continue;
				}
				else
				{
					Hashtable hashtable = new Hashtable();
					if (30900 - 511470 != -480570)
					{
						continue;
					}
					hashtable.Add(41, this.c9xcHSf7FwR);
					if (260492 - 130026 == 130467)
					{
						continue;
					}
					hashtable.Add(42, this.SJpcHE2Ikad);
					if (17110 - 368680 == -351569)
					{
						continue;
					}
					hashtable.Add(4, this.XPLcHDoylB2 + "bbz");
					if (12438 - 478015 == -465576)
					{
						continue;
					}
					this.miDcHLXbUVB.OpCustom(21, hashtable, true);
					if (216439 - 210731 == 5709)
					{
						continue;
					}
					this.g70cH0qkdyF = eLoginState.serverEnter;
					if (89599 - 290132 == -200532)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (115704 - 318371 != -202666)
					{
						break;
					}
					continue;
				}
			}
			else if (eLoginState == eLoginState.serverDown)
			{
				if (130463 - 496653 != -366190)
				{
					continue;
				}
				this.RenderNoticeMessage("Realm Down");
				if (176366 - 206325 != -29959)
				{
					continue;
				}
				if (Time.time - this.VYxcH839KbV <= (float)3)
				{
					break;
				}
				if (55774 - 162617 != -106843)
				{
					continue;
				}
				this.g70cH0qkdyF = eLoginState.serverSelect;
				if (290260 - 59022 == 231239)
				{
					continue;
				}
				this.VYxcH839KbV = Time.time;
				if (42995 - 188463 != -145467)
				{
					break;
				}
				continue;
			}
			else if (eLoginState == eLoginState.serverEnter)
			{
				if (176593 - 114922 == 61672)
				{
					continue;
				}
				this.RenderNoticeMessage("Loading player data..");
				if (61574 - 94398 != -32823)
				{
					break;
				}
				continue;
			}
			else if (eLoginState == eLoginState.noPlayerData)
			{
				if (142173 - 47903 == 94271)
				{
					continue;
				}
				GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)220, (float)723, (float)489, (float)237), this.hTHc7bhUky2);
				if (299349 - 48778 == 250572)
				{
					continue;
				}
				GUI.Label(new Rect(0.5f * this.XT6cHiD1IDO - (float)120, (float)824, (float)300, (float)50), this.WLlcHPyMpsF, this.Sycc7djurHG);
				if (76075 - 115643 != -39568)
				{
					continue;
				}
				if (this.s2WcHw6McLY >= 2)
				{
					if (261362 - 469194 == -207831)
					{
						continue;
					}
					if (this.s2WcHw6McLY != 4)
					{
						if (293698 - 59024 == 234675)
						{
							continue;
						}
						if (this.s2WcHw6McLY == 5)
						{
							if (254209 - 508705 == -254495)
							{
								continue;
							}
						}
						else
						{
							this.RenderNoticeMessage("This server is closed to registration");
							if (54310 - 108297 != -53986)
							{
								goto IL_37DC;
							}
							continue;
						}
					}
				}
				if (GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO - (float)50, (float)884, (float)140, (float)39), string.Empty, this.xIMc7givWRO))
				{
					if (139775 - 464108 != -324333)
					{
						continue;
					}
					this.g70cH0qkdyF = eLoginState.createPlayerData;
					if (181611 - 524570 == -342958)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (139305 - 77786 == 61520)
					{
						continue;
					}
					if (this.MBIc7ErE7d1)
					{
						if (116132 - 545217 == -429084)
						{
							continue;
						}
						this.audio.PlayOneShot(this.MBIc7ErE7d1);
						if (57889 - 358866 == -300976)
						{
							continue;
						}
					}
				}
				IL_37DC:
				if (!GUI.Button(new Rect(0.5f * this.XT6cHiD1IDO + (float)90, (float)884, (float)58, (float)39), string.Empty, this.vqNc7aeByv3))
				{
					break;
				}
				if (62528 - 506383 == -443854)
				{
					continue;
				}
				Application.Quit();
				if (220342 - 199533 == 20810)
				{
					continue;
				}
				if (!this.MBIc7ErE7d1)
				{
					break;
				}
				if (50971 - 383179 != -332208)
				{
					continue;
				}
				this.audio.PlayOneShot(this.MBIc7ErE7d1);
				if (113448 - 444491 != -331043)
				{
					continue;
				}
				break;
			}
			else if (eLoginState == eLoginState.createPlayerData)
			{
				if (200491 - 418114 != -217623)
				{
					continue;
				}
				if (Time.time - this.VYxcH839KbV < (float)1)
				{
					if (291096 - 594679 == -303582)
					{
						continue;
					}
					this.RenderNoticeMessage("Creating new player data..");
					if (44933 - 542437 != -497503)
					{
						break;
					}
					continue;
				}
				else
				{
					Hashtable hashtable2 = new Hashtable();
					if (269725 - 298938 != -29213)
					{
						continue;
					}
					hashtable2.Add(41, this.tABcHN2BdYM);
					if (69797 - 333295 == -263497)
					{
						continue;
					}
					hashtable2.Add(42, this.SJpcHE2Ikad);
					if (275567 - 400270 != -124703)
					{
						continue;
					}
					hashtable2.Add(45, this.WLlcHPyMpsF);
					if (273271 - 130553 != 142718)
					{
						continue;
					}
					this.miDcHLXbUVB.OpCustom(23, hashtable2, true);
					if (197987 - 469741 != -271754)
					{
						continue;
					}
					this.g70cH0qkdyF = eLoginState.createPlayerWait;
					if (65970 - 14460 == 51511)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (207517 - 493722 != -286205)
					{
						continue;
					}
					break;
				}
			}
			else if (eLoginState == eLoginState.createPlayerWait)
			{
				if (232153 - 491431 != -259278)
				{
					continue;
				}
				this.RenderNoticeMessage("Verifying new player data..");
				if (183105 - 337316 != -154210)
				{
					break;
				}
				continue;
			}
			else if (eLoginState == eLoginState.createPlayerSuccess)
			{
				if (289897 - 348780 == -58882)
				{
					continue;
				}
				if (Time.time - this.VYxcH839KbV < (float)2)
				{
					if (223425 - 152640 == 70786)
					{
						continue;
					}
					this.RenderNoticeMessage("New player data created");
					if (245351 - 191494 != 53858)
					{
						break;
					}
					continue;
				}
				else
				{
					this.g70cH0qkdyF = eLoginState.connected;
					if (230905 - 589348 == -358442)
					{
						continue;
					}
					this.VYxcH839KbV = Time.time;
					if (250268 - 153894 != 96375)
					{
						break;
					}
					continue;
				}
			}
			else if (eLoginState == eLoginState.createPlayerFail)
			{
				if (200943 - 599732 == -398788)
				{
					continue;
				}
				if (Time.time - this.VYxcH839KbV < (float)3)
				{
					if (144921 - 52210 != 92711)
					{
						continue;
					}
					this.RenderNoticeMessage("Fatal error: create new player data!");
					if (106396 - 276094 != -169698)
					{
						continue;
					}
					break;
				}
				else
				{
					Application.Quit();
					if (97157 - 217719 != -120561)
					{
						break;
					}
					continue;
				}
			}
			else
			{
				if (eLoginState == eLoginState.join)
				{
					if (71877 - 103571 == -31693)
					{
						continue;
					}
					this.g70cH0qkdyF = eLoginState.loading;
					if (28954 - 326406 == -297451)
					{
						continue;
					}
					int saveGuild = PlayerData.SaveGuild;
					if (254142 - 244078 == 10065)
					{
						continue;
					}
					if (saveGuild == 1)
					{
						if (220643 - 350046 != -129403)
						{
							continue;
						}
						Application.LoadLevel("L12_LobbySnow");
						if (127441 - 344256 != -216815)
						{
							continue;
						}
					}
					else if (saveGuild == 2)
					{
						if (12757 - 356281 != -343524)
						{
							continue;
						}
						Application.LoadLevel("L13_LobbyBeach");
						if (138842 - 251274 == -112431)
						{
							continue;
						}
					}
					else if (saveGuild == 3)
					{
						if (132006 - 496438 != -364432)
						{
							continue;
						}
						Application.LoadLevel("L14_LobbyDesert");
						if (96861 - 19434 == 77428)
						{
							continue;
						}
					}
					else if (saveGuild == 4)
					{
						if (260755 - 420346 == -159590)
						{
							continue;
						}
						Application.LoadLevel("L15_LobbyUnderground");
						if (122517 - 377545 != -255028)
						{
							continue;
						}
					}
					else if (saveGuild == 5)
					{
						if (59323 - 133360 != -74037)
						{
							continue;
						}
						Application.LoadLevel("L16_LobbyForest");
						if (144455 - 418493 == -274037)
						{
							continue;
						}
					}
					else if (PlayerData.GID == 0)
					{
						if (130861 - 114966 != 15895)
						{
							continue;
						}
						Application.LoadLevel("L11_LobbyPlain");
						if (16687 - 131290 != -114603)
						{
							continue;
						}
					}
					else
					{
						Application.LoadLevel("L10_LobbyGuild");
						if (263713 - 6997 == 256717)
						{
							continue;
						}
					}
				}
				else if (eLoginState == eLoginState.loading)
				{
					if (141328 - 490788 == -349459)
					{
						continue;
					}
				}
				else
				{
					if (eLoginState != eLoginState.error)
					{
						break;
					}
					if (11758 - 43326 != -31568)
					{
						continue;
					}
					this.RenderNoticeMessage(this.r3AcHB7rp0m);
					if (158386 - 470698 == -312311)
					{
						continue;
					}
					if (Time.time - this.VYxcH839KbV <= (float)3)
					{
						break;
					}
					if (248820 - 255657 == -6836)
					{
						continue;
					}
					if (this.s2WcHw6McLY < 2)
					{
						if (248656 - 365744 == -117087)
						{
							continue;
						}
						this.g70cH0qkdyF = eLoginState.realmSelect;
						if (111063 - 576518 == -465454)
						{
							continue;
						}
					}
					else
					{
						this.g70cH0qkdyF = eLoginState.serverSelect;
						if (163751 - 538271 == -374519)
						{
							continue;
						}
					}
					this.VYxcH839KbV = Time.time;
					if (171630 - 584393 != -412763)
					{
						continue;
					}
					break;
				}
				this.RenderNoticeMessage("Entering 12Tails Online...");
				if (238157 - 295670 != -57512)
				{
					break;
				}
				continue;
			}
			IL_B51:
			this.Ak7c7jFvDCX = Input.mousePosition;
			if (69763 - 279502 != -209738)
			{
				this.fy2c7mSbCb0 = Time.time;
				if (187337 - 537831 == -350494)
				{
					goto IL_12A3;
				}
			}
		}
	}

	// Token: 0x060061AF RID: 25007 RVA: 0x00D6D244 File Offset: 0x00D6B444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeMessage(string message)
	{
		GUI.DrawTexture(new Rect(0.5f * this.XT6cHiD1IDO - (float)233, (float)740, (float)475, (float)102), this.KRoc7wcfBXh);
		GUI.Label(new Rect(0.5f * this.XT6cHiD1IDO - (float)200, (float)765, (float)400, (float)50), message, this.BJ1c7D1kbWE);
	}

	// Token: 0x060061B0 RID: 25008 RVA: 0x00D6D2B8 File Offset: 0x00D6B4B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartNProtect()
	{
		return new LoginGui.$StartNProtect$36311(this).GetEnumerator();
	}

	// Token: 0x060061B1 RID: 25009 RVA: 0x00D6D2C8 File Offset: 0x00D6B4C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator Connect(int nServer, int nRealm)
	{
		return new LoginGui.$Connect$36314(nServer, nRealm, this).GetEnumerator();
	}

	// Token: 0x060061B2 RID: 25010 RVA: 0x00D6D2D8 File Offset: 0x00D6B4D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onConnect()
	{
		if (this.checkDataVersion())
		{
			this.g70cH0qkdyF = eLoginState.connected;
		}
	}

	// Token: 0x060061B3 RID: 25011 RVA: 0x00D6D2F0 File Offset: 0x00D6B4F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool checkDataVersion()
	{
		if (114492 - 123086 != -8593)
		{
		}
		for (;;)
		{
			if (ItemData.getVersion() != 555)
			{
				if (154302 - 288784 != -134481)
				{
					goto Block_8;
				}
			}
			else if (ShopData.getVersion() != 555)
			{
				if (42392 - 581259 != -538866)
				{
					goto Block_10;
				}
			}
			else if (CompoundData.getVersion() != 555)
			{
				if (15597 - 184147 != -168549)
				{
					goto Block_5;
				}
			}
			else if (CollectorData.getVersion() != 555)
			{
				if (135038 - 12747 == 122291)
				{
					goto IL_FF;
				}
			}
			else if (CookingData.getVersion() != 555)
			{
				if (14928 - 379771 == -364843)
				{
					break;
				}
			}
			else
			{
				if (AlchemistData.getVersion() == 555)
				{
					goto IL_134;
				}
				if (183533 - 283786 != -100252)
				{
					goto Block_3;
				}
			}
		}
		return false;
		Block_3:
		return false;
		Block_5:
		return false;
		Block_8:
		return false;
		Block_10:
		return false;
		IL_FF:
		return false;
		IL_134:
		return true;
	}

	// Token: 0x060061B4 RID: 25012 RVA: 0x00D6D444 File Offset: 0x00D6B644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLogin(Hashtable data)
	{
		if (122742 - 43797 != 78945)
		{
		}
		for (;;)
		{
			if (RuntimeServices.ToBool(RuntimeServices.InvokeBinaryOperator("op_GreaterThan", data[43], 0)))
			{
				if (26922 - 350405 != -323482)
				{
					PlayerData.LoadHashTable(data);
					if (22808 - 483629 == -460821)
					{
						if (PlayerData.GID > 0)
						{
							if (101376 - 563537 != -462160)
							{
								this.LoadGuildData();
								if (210914 - 574222 == -363308)
								{
									break;
								}
							}
						}
						else
						{
							this.g70cH0qkdyF = eLoginState.join;
							if (4203 - 240201 == -235998)
							{
								this.VYxcH839KbV = Time.time;
								if (106243 - 548377 == -442134)
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
				this.In1cHmkAJ1y = RuntimeServices.UnboxInt32(data[43]);
				if (124434 - 282088 != -157653)
				{
					if (this.In1cHmkAJ1y == -5)
					{
						if (174490 - 318021 != -143530)
						{
							this.g70cH0qkdyF = eLoginState.noPlayerData;
							if (246242 - 279885 != -33642)
							{
								this.VYxcH839KbV = Time.time;
								if (201079 - 289095 != -88015)
								{
									break;
								}
							}
						}
					}
					else
					{
						int in1cHmkAJ1y = this.In1cHmkAJ1y;
						if (120380 - 296540 != -176159)
						{
							if (in1cHmkAJ1y == -1)
							{
								if (212606 - 72619 != 139987)
								{
									continue;
								}
								this.r3AcHB7rp0m = "User input error";
								if (89906 - 367157 == -277250)
								{
									continue;
								}
							}
							else if (in1cHmkAJ1y == -2)
							{
								if (269300 - 251786 == 17515)
								{
									continue;
								}
								this.r3AcHB7rp0m = "That user has already logged in!";
								if (208625 - 138710 != 69915)
								{
									continue;
								}
							}
							else if (in1cHmkAJ1y == -3)
							{
								if (272312 - 255351 == 16962)
								{
									continue;
								}
								this.r3AcHB7rp0m = "Wrong game version.";
								if (79750 - 202773 == -123022)
								{
									continue;
								}
							}
							else if (in1cHmkAJ1y == -4)
							{
								if (202925 - 317369 != -114444)
								{
									continue;
								}
								this.r3AcHB7rp0m = "Server is full..";
								if (2808 - 533379 != -530571)
								{
									continue;
								}
							}
							else if (in1cHmkAJ1y == -5)
							{
								if (196528 - 322691 == -126162)
								{
									continue;
								}
								this.r3AcHB7rp0m = "NoPlayerData";
								if (123995 - 255169 != -131174)
								{
									continue;
								}
							}
							else if (in1cHmkAJ1y == -6)
							{
								if (182914 - 329939 != -147025)
								{
									continue;
								}
								this.r3AcHB7rp0m = "Server is shutting down..";
								if (115329 - 181746 == -66416)
								{
									continue;
								}
							}
							else
							{
								this.r3AcHB7rp0m = "Unknown log in error!";
								if (285262 - 450206 != -164944)
								{
									continue;
								}
							}
							this.g70cH0qkdyF = eLoginState.error;
							if (250129 - 159186 == 90943)
							{
								this.VYxcH839KbV = Time.time;
								if (181271 - 457472 != -276200)
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

	// Token: 0x060061B5 RID: 25013 RVA: 0x00D6D874 File Offset: 0x00D6BA74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060061B6 RID: 25014 RVA: 0x00D6D878 File Offset: 0x00D6BA78
	internal static bool UFM6uqpXIwmARQOOJYD7()
	{
		return true;
	}

	// Token: 0x060061B7 RID: 25015 RVA: 0x00D6D87C File Offset: 0x00D6BA7C
	internal static bool sd9eefpXBgRjLbkOGF5x()
	{
		return false;
	}

	// Token: 0x04006F63 RID: 28515
	private LitePeer miDcHLXbUVB;

	// Token: 0x04006F64 RID: 28516
	private int s2WcHw6McLY;

	// Token: 0x04006F65 RID: 28517
	private int GTBcHURKRL0;

	// Token: 0x04006F66 RID: 28518
	private string tABcHN2BdYM;

	// Token: 0x04006F67 RID: 28519
	private string SJpcHE2Ikad;

	// Token: 0x04006F68 RID: 28520
	private string WLlcHPyMpsF;

	// Token: 0x04006F69 RID: 28521
	private string c9xcHSf7FwR;

	// Token: 0x04006F6A RID: 28522
	private string r3AcHB7rp0m;

	// Token: 0x04006F6B RID: 28523
	public GameObject mListener;

	// Token: 0x04006F6C RID: 28524
	public bool internationalVersion;

	// Token: 0x04006F6D RID: 28525
	private eLoginState g70cH0qkdyF;

	// Token: 0x04006F6E RID: 28526
	private float VYxcH839KbV;

	// Token: 0x04006F6F RID: 28527
	private float XT6cHiD1IDO;

	// Token: 0x04006F70 RID: 28528
	private int XPLcHDoylB2;

	// Token: 0x04006F71 RID: 28529
	private int In1cHmkAJ1y;

	// Token: 0x04006F72 RID: 28530
	private bool vQ3cHjUv5H7;

	// Token: 0x04006F73 RID: 28531
	private Texture Fj0cHo2XFT9;

	// Token: 0x04006F74 RID: 28532
	private Texture WdBcHkYaEHh;

	// Token: 0x04006F75 RID: 28533
	private Texture QnucHFtyVS8;

	// Token: 0x04006F76 RID: 28534
	private Texture iJmcHApblAJ;

	// Token: 0x04006F77 RID: 28535
	private Texture JR0cH9u2lWO;

	// Token: 0x04006F78 RID: 28536
	private Texture sXhcHWXKGgl;

	// Token: 0x04006F79 RID: 28537
	private Texture rr5cHuEYn4h;

	// Token: 0x04006F7A RID: 28538
	private Texture HOxcHyYsOHw;

	// Token: 0x04006F7B RID: 28539
	private Texture mLmcHVpRBRa;

	// Token: 0x04006F7C RID: 28540
	private Texture tWBcHhiy5MQ;

	// Token: 0x04006F7D RID: 28541
	private Texture l4YcHKpFOnW;

	// Token: 0x04006F7E RID: 28542
	private Texture mqycHz8iGwP;

	// Token: 0x04006F7F RID: 28543
	private Texture e5Jc75Fo1nO;

	// Token: 0x04006F80 RID: 28544
	private Texture SVmc7cVVgPZ;

	// Token: 0x04006F81 RID: 28545
	private Texture txyc7nUl9mn;

	// Token: 0x04006F82 RID: 28546
	private Texture O9nc7QJ6Zfp;

	// Token: 0x04006F83 RID: 28547
	private Texture v99c7eSL88p;

	// Token: 0x04006F84 RID: 28548
	private Texture rDqc7ISYRqJ;

	// Token: 0x04006F85 RID: 28549
	private Texture nbac7JU6M7u;

	// Token: 0x04006F86 RID: 28550
	private Texture YCUc76KkBAI;

	// Token: 0x04006F87 RID: 28551
	private Texture PUQc7t2NemP;

	// Token: 0x04006F88 RID: 28552
	private Texture tIwc7XDyDOO;

	// Token: 0x04006F89 RID: 28553
	private GUIStyle mSmc7OtZkNF;

	// Token: 0x04006F8A RID: 28554
	private Texture OCNc72od5wk;

	// Token: 0x04006F8B RID: 28555
	private Texture J7dc7vks1pg;

	// Token: 0x04006F8C RID: 28556
	private Texture hBPc7lv7CZC;

	// Token: 0x04006F8D RID: 28557
	private Texture S5kc7GvskCE;

	// Token: 0x04006F8E RID: 28558
	private Texture Gimc71bOovA;

	// Token: 0x04006F8F RID: 28559
	private Texture z2Mc7q66FZ5;

	// Token: 0x04006F90 RID: 28560
	private Texture SYVc7pi0oZx;

	// Token: 0x04006F91 RID: 28561
	private Texture WJMc7RDPCWe;

	// Token: 0x04006F92 RID: 28562
	private Texture HPcc7rr6sEw;

	// Token: 0x04006F93 RID: 28563
	private Texture hDpc7x94GMb;

	// Token: 0x04006F94 RID: 28564
	private Texture C5Wc7TClnIg;

	// Token: 0x04006F95 RID: 28565
	private Texture R8uc7Y8dQ7m;

	// Token: 0x04006F96 RID: 28566
	private Texture Xrcc73k5tI5;

	// Token: 0x04006F97 RID: 28567
	private Texture hTHc7bhUky2;

	// Token: 0x04006F98 RID: 28568
	private GUIStyle Sycc7djurHG;

	// Token: 0x04006F99 RID: 28569
	private GUIStyle xIMc7givWRO;

	// Token: 0x04006F9A RID: 28570
	private GUIStyle vqNc7aeByv3;

	// Token: 0x04006F9B RID: 28571
	private GUIStyle kdPc74TxMvl;

	// Token: 0x04006F9C RID: 28572
	private GUIStyle a31c7s9BOaq;

	// Token: 0x04006F9D RID: 28573
	private GUIStyle B4Lc7HyblDq;

	// Token: 0x04006F9E RID: 28574
	private Texture J0qc77SOtmC;

	// Token: 0x04006F9F RID: 28575
	private GUIStyle reNc7Z2gFdP;

	// Token: 0x04006FA0 RID: 28576
	private GUIStyle adVc7C1QQoX;

	// Token: 0x04006FA1 RID: 28577
	private GUIStyle r5Sc7MZ7LeO;

	// Token: 0x04006FA2 RID: 28578
	private Texture la1c7fdXS4o;

	// Token: 0x04006FA3 RID: 28579
	private GUIStyle PQYc7LyjfnN;

	// Token: 0x04006FA4 RID: 28580
	private Texture KRoc7wcfBXh;

	// Token: 0x04006FA5 RID: 28581
	private Font U9Mc7UTnfMN;

	// Token: 0x04006FA6 RID: 28582
	private AudioClip gPRc7NJerAX;

	// Token: 0x04006FA7 RID: 28583
	private AudioClip MBIc7ErE7d1;

	// Token: 0x04006FA8 RID: 28584
	private AudioClip BrDc7PyG81J;

	// Token: 0x04006FA9 RID: 28585
	private AudioClip hEMc7SHDLid;

	// Token: 0x04006FAA RID: 28586
	private AudioClip i6gc7BHjBej;

	// Token: 0x04006FAB RID: 28587
	private int agCc704rjvP;

	// Token: 0x04006FAC RID: 28588
	private int CFNc78BXGFU;

	// Token: 0x04006FAD RID: 28589
	private int vNgc7imfxdM;

	// Token: 0x04006FAE RID: 28590
	private GUIStyle BJ1c7D1kbWE;

	// Token: 0x04006FAF RID: 28591
	public MovieTexture introMovie;

	// Token: 0x04006FB0 RID: 28592
	private float fy2c7mSbCb0;

	// Token: 0x04006FB1 RID: 28593
	private Vector2 Ak7c7jFvDCX;

	// Token: 0x04006FB2 RID: 28594
	private bool Xn5c7oNkmoQ;

	// Token: 0x02001074 RID: 4212
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartNProtect$36311 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060061B8 RID: 25016 RVA: 0x00D6D880 File Offset: 0x00D6BA80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartNProtect$36311(LoginGui self_)
		{
			if (210227 - 244185 != -33958)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27196 - 308072 == -280876)
				{
					base..ctor();
					if (162126 - 131222 == 30904)
					{
						this.$self_$36313 = self_;
						if (55036 - 257265 != -202228)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x00D6D918 File Offset: 0x00D6BB18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LoginGui.$StartNProtect$36311.$(this.$self_$36313);
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x00D6D928 File Offset: 0x00D6BB28
		internal static bool eGyWVnpXeLQBAYdTvMcc()
		{
			return true;
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x00D6D92C File Offset: 0x00D6BB2C
		internal static bool N2aTbZpXraYIKW6FEqXe()
		{
			return false;
		}

		// Token: 0x04006FB3 RID: 28595
		internal LoginGui $self_$36313;

		// Token: 0x02001075 RID: 4213
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060061BC RID: 25020 RVA: 0x00D6D930 File Offset: 0x00D6BB30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(LoginGui self_)
			{
				if (127083 - 384619 != -257535)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (195743 - 160888 != 34856)
					{
						base..ctor();
						if (84745 - 393887 != -309141)
						{
							this.$self_$36312 = self_;
							if (258835 - 45547 == 213288)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060061BD RID: 25021 RVA: 0x00D6D9C8 File Offset: 0x00D6BBC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (263352 - 184264 != 79088)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1A5;
					case 2:
						Debug.Log(NProtect.StartGameMon());
						if (290867 - 173 != 290695)
						{
							goto Block_2;
						}
						continue;
					case 3:
						goto IL_AC;
					default:
						if (12839 - 134098 == -121258)
						{
							continue;
						}
						break;
					}
					Debug.Log("Starting NProtect");
					if (71917 - 340314 != -268397)
					{
						continue;
					}
					if (Application.platform == RuntimePlatform.WindowsPlayer)
					{
						if (103430 - 339720 == -236289)
						{
							continue;
						}
						if (!this.$self_$36312.Xn5c7oNkmoQ)
						{
							if (84191 - 19359 != 64832)
							{
								continue;
							}
							break;
						}
					}
					IL_AC:
					this.$self_$36312.Xn5c7oNkmoQ = true;
					if (162082 - 514571 != -352488)
					{
						this.$self_$36312.g70cH0qkdyF = eLoginState.serverSelect;
						if (129680 - 357645 != -227964)
						{
							this.$self_$36312.VYxcH839KbV = Time.time;
							if (110072 - 289466 != -179393)
							{
								this.YieldDefault(1);
								if (185108 - 407198 != -222089)
								{
									goto Block_5;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_2:
				return this.YieldDefault(3);
				Block_5:
				IL_1A5:
				return false;
			}

			// Token: 0x060061BE RID: 25022 RVA: 0x00D6DB8C File Offset: 0x00D6BD8C
			internal static bool tJHgeApXjWLP887ngMlg()
			{
				return true;
			}

			// Token: 0x060061BF RID: 25023 RVA: 0x00D6DB90 File Offset: 0x00D6BD90
			internal static bool xpp917pXh514ggvXcwPB()
			{
				return false;
			}

			// Token: 0x04006FB4 RID: 28596
			internal LoginGui $self_$36312;
		}
	}

	// Token: 0x02001076 RID: 4214
	[CompilerGenerated]
	[Serializable]
	internal sealed class $Connect$36314 : GenericGenerator<object>
	{
		// Token: 0x060061C0 RID: 25024 RVA: 0x00D6DB94 File Offset: 0x00D6BD94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $Connect$36314(int nServer, int nRealm, LoginGui self_)
		{
			if (29617 - 388150 != -358533)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133435 - 167461 == -34026)
				{
					base..ctor();
					if (202 - 362983 != -362780)
					{
						this.$nServer$36319 = nServer;
						if (104581 - 138781 != -34199)
						{
							this.$nRealm$36320 = nRealm;
							if (140233 - 523779 != -383545)
							{
								this.$self_$36321 = self_;
								if (236316 - 555217 != -318900)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x00D6DC70 File Offset: 0x00D6BE70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new LoginGui.$Connect$36314.$(this.$nServer$36319, this.$nRealm$36320, this.$self_$36321);
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x00D6DC8C File Offset: 0x00D6BE8C
		internal static bool u3AlREpXsyUWTAZ9sUvf()
		{
			return true;
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x00D6DC90 File Offset: 0x00D6BE90
		internal static bool XOrMGMpX9sg3ygBc7EyO()
		{
			return false;
		}

		// Token: 0x04006FB5 RID: 28597
		internal int $nServer$36319;

		// Token: 0x04006FB6 RID: 28598
		internal int $nRealm$36320;

		// Token: 0x04006FB7 RID: 28599
		internal LoginGui $self_$36321;

		// Token: 0x02001077 RID: 4215
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x060061C4 RID: 25028 RVA: 0x00D6DC94 File Offset: 0x00D6BE94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nServer, int nRealm, LoginGui self_)
			{
				if (263938 - 440854 != -176915)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161214 - 439015 != -277800)
					{
						base..ctor();
						if (34326 - 62257 == -27931)
						{
							this.$nServer$36316 = nServer;
							if (100860 - 66063 != 34798)
							{
								this.$nRealm$36317 = nRealm;
								if (177772 - 170621 == 7151)
								{
									this.$self_$36318 = self_;
									if (289586 - 583818 != -294231)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060061C5 RID: 25029 RVA: 0x00D6DD70 File Offset: 0x00D6BF70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98658 - 278168 != -179509)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_242;
					case 2:
						this.$nListener$36315 = (PhotonListener)this.$self_$36318.mListener.GetComponent(typeof(PhotonListener));
						if (30341 - 131068 == -100726)
						{
							continue;
						}
						if (this.$nListener$36315)
						{
							if (170765 - 398074 == -227308)
							{
								continue;
							}
							this.$self_$36318.miDcHLXbUVB = this.$nListener$36315.NewConnection(this.$nServer$36316, this.$nRealm$36317);
							if (52276 - 296406 != -244130)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Cannot find PhotonListener");
							if (110166 - 406788 == -296621)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (31547 - 203826 != -172278)
						{
							goto Block_11;
						}
						continue;
					default:
						if (26142 - 450963 == -424820)
						{
							continue;
						}
						break;
					}
					this.$self_$36318.s2WcHw6McLY = this.$nServer$36316;
					if (110295 - 115188 == -4893)
					{
						this.$self_$36318.GTBcHURKRL0 = this.$nRealm$36317;
						if (192959 - 22036 == 170923)
						{
							Game.server = this.$nServer$36316;
							if (260660 - 149363 != 111298)
							{
								PlayerPrefs.SetInt("server", this.$self_$36318.s2WcHw6McLY);
								if (81389 - 551868 != -470478)
								{
									this.$self_$36318.g70cH0qkdyF = eLoginState.connecting;
									if (298091 - 86454 != 211638)
									{
										this.$self_$36318.VYxcH839KbV = Time.time;
										if (110660 - 206871 != -96210)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.YieldDefault(2);
				Block_11:
				IL_242:
				return false;
			}

			// Token: 0x060061C6 RID: 25030 RVA: 0x00D6DFD4 File Offset: 0x00D6C1D4
			internal static bool nZ9U7IpX1hVlnwYd7nry()
			{
				return true;
			}

			// Token: 0x060061C7 RID: 25031 RVA: 0x00D6DFD8 File Offset: 0x00D6C1D8
			internal static bool m8l9oUpX4JlTco03jrpH()
			{
				return false;
			}

			// Token: 0x04006FB8 RID: 28600
			internal PhotonListener $nListener$36315;

			// Token: 0x04006FB9 RID: 28601
			internal int $nServer$36316;

			// Token: 0x04006FBA RID: 28602
			internal int $nRealm$36317;

			// Token: 0x04006FBB RID: 28603
			internal LoginGui $self_$36318;
		}
	}
}
