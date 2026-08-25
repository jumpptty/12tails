using System;
using System.Collections;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200109A RID: 4250
[Serializable]
public class StorageGui : MonoBehaviour
{
	// Token: 0x060062F7 RID: 25335 RVA: 0x00DBC108 File Offset: 0x00DBA308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StorageGui()
	{
		if (210941 - 37135 != 173807)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (221905 - 33381 != 188525)
			{
				base..ctor();
				if (196231 - 464061 == -267830)
				{
					this.mState = eStorageState.init;
					if (268764 - 522680 != -253915)
					{
						this.nG9cEiiwIEI = "none";
						if (105482 - 286198 == -180716)
						{
							this.RW3cEmpK8P4 = "none";
							if (234856 - 312925 == -78069)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062F8 RID: 25336 RVA: 0x00DBC1EC File Offset: 0x00DBA3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (232499 - 345074 != -112574)
		{
		}
		for (;;)
		{
			this.InitStorageMenu();
			if (296630 - 20193 != 276438)
			{
				this.InitNPC();
				if (269077 - 541054 != -271976)
				{
					this.ResetStorageMenu();
					if (291384 - 586746 != -295361)
					{
						this.ResetStorageButton();
						if (285424 - 137744 == 147680)
						{
							this.ResetInventoryButton();
							if (196521 - 100952 != 95570)
							{
								this.e5bcEgKxqY9 = 0;
								if (175435 - 392040 != -216604)
								{
									this.FlgcEaCF6Qi = 1f;
									if (59958 - 13509 != 46450)
									{
										this.mState = eStorageState.open;
										if (133605 - 38545 == 95060)
										{
											this.zENcEYbakir = Time.time;
											if (100014 - 125553 != -25538)
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

	// Token: 0x060062F9 RID: 25337 RVA: 0x00DBC350 File Offset: 0x00DBA550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (190443 - 473589 != -283146)
		{
		}
		for (;;)
		{
			if (this.mState <= eStorageState.init)
			{
				if (45404 - 344848 == -299444)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (19788 - 455251 == -435463)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (65360 - 114116 != -48755)
					{
						this.FYbcE3ZToWU = (float)(1024 * Screen.width / Screen.height);
						if (39124 - 91352 != -52227)
						{
							this.HXAcEbMhY9D = (float)Screen.height / 1024f;
							if (4103 - 123093 == -118990)
							{
								this.RenderStorageMenu();
								if (133834 - 268918 == -135084)
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

	// Token: 0x060062FA RID: 25338 RVA: 0x00DBC4A0 File Offset: 0x00DBA6A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitStorageMenu()
	{
		if (226365 - 285182 != -58816)
		{
		}
		for (;;)
		{
			this.D1RcE42p67L = (Texture)Resources.Load("GameGui/Storage/window", typeof(Texture));
			if (51877 - 449883 != -398005)
			{
				this.gKQcEsmcvjm = (Texture)Resources.Load("GameGui/Storage/key1", typeof(Texture));
				if (226184 - 477154 == -250970)
				{
					this.LOjcEHxPMGJ = (Texture)Resources.Load("GameGui/Storage/key2", typeof(Texture));
					if (184758 - 169122 == 15636)
					{
						this.yFbcE7QT7i2 = (Texture)Resources.Load("GameGui/Storage/key3", typeof(Texture));
						if (146762 - 394510 != -247747)
						{
							this.zfRcEZunxaZ = (Texture)Resources.Load("GameGui/Storage/key4", typeof(Texture));
							if (104669 - 450764 == -346095)
							{
								this.CuhcECqkdkb = (Texture)Resources.Load("GameGui/Storage/key5", typeof(Texture));
								if (110999 - 331877 == -220878)
								{
									this.kXtcEMm0cdj = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover");
									if (113141 - 597844 == -484703)
									{
										this.rhrcEfCVfkH = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
										if (191201 - 384164 == -192963)
										{
											this.QYmcELrFhbD = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
											if (265523 - 11321 == 254202)
											{
												this.zYicEwEQN6Q = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
												if (103984 - 59842 == 44142)
												{
													this.pFHcEUwcEeY = (Texture)Resources.Load("GameGui/Icons/Common/Item_inactive", typeof(Texture));
													if (292639 - 296759 == -4120)
													{
														this.zaZcEEqxxfm = new GUIStyle();
														if (218394 - 305815 != -87420)
														{
															this.zaZcEEqxxfm.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
															if (246502 - 333380 != -86877)
															{
																this.SdBcENrf6fm = new GUIStyle();
																if (164436 - 350621 == -186185)
																{
																	this.SdBcENrf6fm.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
																	if (195914 - 391578 == -195664)
																	{
																		this.KY2cEPxoZq7 = new GUIStyle();
																		if (191941 - 275710 == -83769)
																		{
																			this.KY2cEPxoZq7.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Storage/button_close_h", typeof(Texture)));
																			if (101928 - 388419 != -286490)
																			{
																				this.dsycESYYvE1 = new GUIStyle();
																				if (43757 - 389445 == -345688)
																				{
																					this.dsycESYYvE1.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																					if (108672 - 486799 == -378127)
																					{
																						this.dsycESYYvE1.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																						if (22194 - 340892 != -318697)
																						{
																							this.dsycESYYvE1.alignment = TextAnchor.MiddleCenter;
																							if (56624 - 391992 == -335368)
																							{
																								this.IlFcEBkorcQ = new GUIStyle();
																								if (19603 - 411224 == -391621)
																								{
																									this.IlFcEBkorcQ.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																									if (102609 - 347154 == -244545)
																									{
																										this.IlFcEBkorcQ.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																										if (17915 - 82442 == -64527)
																										{
																											this.IlFcEBkorcQ.alignment = TextAnchor.MiddleLeft;
																											if (136051 - 122818 != 13234)
																											{
																												this.nkycEjwdLym = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																												if (153337 - 116566 != 36772)
																												{
																													this.ntUcEoG1yPj = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																													if (253758 - 346193 != -92434)
																													{
																														this.pKocEkS1R18 = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																														if (35746 - 348966 != -313219)
																														{
																															this.gE0cEF9PR6y = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																															if (176137 - 335370 == -159233)
																															{
																																this.GN1cE0TS5G0 = new IconButtonClass[168];
																																if (10893 - 566700 != -555806)
																																{
																																	this.UFgcE8YjEoS = new IconButtonClass[30];
																																	if (152462 - 500267 == -347805)
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

	// Token: 0x060062FB RID: 25339 RVA: 0x00DBCB44 File Offset: 0x00DBAD44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetStorageMenu()
	{
		if (298809 - 68775 != 230034)
		{
		}
		for (;;)
		{
			IL_22F:
			this.e5bcEgKxqY9 = 0;
			if (144214 - 213794 == -69580)
			{
				int i = 0;
				if (82621 - 443364 == -360743)
				{
					while (i < 168)
					{
						this.GN1cE0TS5G0[i] = new IconButtonClass();
						if (68299 - 290392 == -222092)
						{
							goto IL_22F;
						}
						if (PlayerData.ItemList[i] != null)
						{
							if (291496 - 306977 != -15481)
							{
								goto IL_22F;
							}
							if (PlayerData.ItemList[i].name != "none")
							{
								if (72715 - 125723 != -53008)
								{
									goto IL_22F;
								}
								this.GN1cE0TS5G0[i].name = PlayerData.ItemList[i].name;
								if (297332 - 400694 == -103361)
								{
									goto IL_22F;
								}
								this.GN1cE0TS5G0[i].command = -1 * (i + 20);
								if (296086 - 473068 != -176982)
								{
									goto IL_22F;
								}
								this.GN1cE0TS5G0[i].image = (Texture2D)IconButton.getCommandIcon(-1 * (i + 20));
								if (82474 - 571156 != -488682)
								{
									goto IL_22F;
								}
							}
						}
						else
						{
							Debug.Log("Inventory Error: " + i);
							if (20243 - 193383 != -173140)
							{
								goto IL_22F;
							}
						}
						i++;
						if (178148 - 434467 == -256318)
						{
							goto IL_22F;
						}
					}
					if (151168 - 114448 == 36720)
					{
						int j = 0;
						if (227185 - 431545 != -204359)
						{
							while (j < 30)
							{
								this.UFgcE8YjEoS[j] = new IconButtonClass();
								if (91819 - 236329 == -144509)
								{
									goto IL_22F;
								}
								if (CharacterData.current.inventory[j].name != "none")
								{
									if (96160 - 479720 != -383560)
									{
										goto IL_22F;
									}
									this.UFgcE8YjEoS[j].name = CharacterData.current.inventory[j].name;
									if (185413 - 431685 == -246271)
									{
										goto IL_22F;
									}
									this.UFgcE8YjEoS[j].command = j + 20;
									if (88253 - 46992 == 41262)
									{
										goto IL_22F;
									}
									this.UFgcE8YjEoS[j].image = (Texture2D)IconButton.getCommandIcon(j + 20);
									if (176867 - 388578 != -211711)
									{
										goto IL_22F;
									}
								}
								j++;
								if (143354 - 318173 != -174819)
								{
									goto IL_22F;
								}
							}
							if (172843 - 176384 != -3540)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062FC RID: 25340 RVA: 0x00DBCEA8 File Offset: 0x00DBB0A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderStorageMenu()
	{
		if (122126 - 407574 != -285448)
		{
		}
		for (;;)
		{
			float num = Time.time - this.zENcEYbakir;
			if (89162 - 346256 == -257094)
			{
				eStorageState eStorageState = this.mState;
				if (225881 - 83948 != 141934)
				{
					if (eStorageState == eStorageState.init)
					{
						if (177882 - 197458 != -19575)
						{
							break;
						}
					}
					else if (eStorageState == eStorageState.open)
					{
						if (199979 - 238196 == -38217)
						{
							if (num <= 0.5f)
							{
								if (137549 - 556372 == -418823)
								{
									this.FlgcEaCF6Qi = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (8162 - 270648 == -262486)
									{
										GUI.DrawTexture(new Rect(this.FYbcE3ZToWU - (float)578 + this.FlgcEaCF6Qi * (float)578, (float)0, (float)578, (float)1024), this.D1RcE42p67L);
										if (214802 - 22654 == 192148)
										{
											this.RenderNPC(this.FlgcEaCF6Qi);
											if (40285 - 580136 == -539851)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)3)
							{
								if (120027 - 166102 == -46075)
								{
									this.FlgcEaCF6Qi = (float)0;
									if (282218 - 572685 == -290467)
									{
										GUI.DrawTexture(new Rect(this.FYbcE3ZToWU - (float)578 + this.FlgcEaCF6Qi * (float)578, (float)0, (float)578, (float)1024), this.D1RcE42p67L);
										if (186556 - 568626 != -382069)
										{
											this.RenderNPC(this.FlgcEaCF6Qi);
											if (88707 - 214915 == -126208)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.FlgcEaCF6Qi = (float)0;
								if (236886 - 43337 != 193550)
								{
									GUI.DrawTexture(new Rect(this.FYbcE3ZToWU - (float)578 + this.FlgcEaCF6Qi * (float)578, (float)0, (float)578, (float)1024), this.D1RcE42p67L);
									if (25079 - 587730 == -562651)
									{
										this.RenderNPC(this.FlgcEaCF6Qi);
										if (37635 - 1914 != 35722)
										{
											this.mState = eStorageState.storage;
											if (72804 - 571023 == -498219)
											{
												this.zENcEYbakir = Time.time;
												if (39564 - 66890 != -27325)
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
					else if (eStorageState == eStorageState.storage)
					{
						if (152228 - 427624 == -275396)
						{
							GUI.BeginGroup(new Rect(this.FYbcE3ZToWU - (float)578, (float)0, (float)578, (float)1024));
							if (95604 - 542905 == -447301)
							{
								GUI.DrawTexture(new Rect((float)0, (float)0, (float)578, (float)1024), this.D1RcE42p67L);
								if (55571 - 504677 == -449106)
								{
									if (PlayerData.InventoryKey >= 1)
									{
										if (234908 - 440466 == -205557)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)315, (float)15, (float)64, (float)64), this.gKQcEsmcvjm);
										if (275134 - 318567 != -43433)
										{
											continue;
										}
									}
									if (PlayerData.InventoryKey >= 2)
									{
										if (232227 - 255406 == -23178)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)349, (float)15, (float)64, (float)64), this.LOjcEHxPMGJ);
										if (49674 - 440332 != -390658)
										{
											continue;
										}
									}
									if (PlayerData.InventoryKey >= 3)
									{
										if (53732 - 62740 == -9007)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)383, (float)15, (float)64, (float)64), this.yFbcE7QT7i2);
										if (90462 - 413918 != -323456)
										{
											continue;
										}
									}
									if (PlayerData.InventoryKey >= 4)
									{
										if (282699 - 113014 != 169685)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)416, (float)15, (float)64, (float)64), this.zfRcEZunxaZ);
										if (196446 - 418275 == -221828)
										{
											continue;
										}
									}
									if (PlayerData.InventoryKey >= 5)
									{
										if (29175 - 400689 == -371513)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)450, (float)15, (float)64, (float)64), this.CuhcECqkdkb);
										if (230812 - 564931 != -334119)
										{
											continue;
										}
									}
									this.RenderStorageButton();
									if (172784 - 585495 == -412711)
									{
										this.RenderInventoryButton();
										if (47906 - 115799 != -67892)
										{
											if (GUI.Button(new Rect((float)214, (float)509, (float)85, (float)57), string.Empty, this.zaZcEEqxxfm))
											{
												if (80828 - 240601 != -159773)
												{
													continue;
												}
												this.hUNcEdFgLQG = Mathf.Clamp(this.hUNcEdFgLQG - 1, 0, 3);
												if (43889 - 400022 == -356132)
												{
													continue;
												}
												this.audio.PlayOneShot(this.pKocEkS1R18);
												if (284465 - 176964 != 107501)
												{
													continue;
												}
											}
											if (GUI.Button(new Rect((float)366, (float)509, (float)85, (float)57), string.Empty, this.SdBcENrf6fm))
											{
												if (49462 - 101996 != -52534)
												{
													continue;
												}
												this.hUNcEdFgLQG = Mathf.Clamp(this.hUNcEdFgLQG + 1, 0, 3);
												if (124146 - 552252 == -428105)
												{
													continue;
												}
												this.audio.PlayOneShot(this.pKocEkS1R18);
												if (15855 - 534508 != -518653)
												{
													continue;
												}
											}
											GUI.Label(new Rect((float)348, (float)517, (float)50, (float)30), string.Empty + (1 + this.hUNcEdFgLQG), this.IlFcEBkorcQ);
											if (187584 - 337772 != -150187)
											{
												if (GUI.Button(new Rect((float)101, (float)1, (float)57, (float)52), string.Empty, this.KY2cEPxoZq7))
												{
													if (50579 - 60025 == -9445)
													{
														continue;
													}
													GameObject gameObject = GameObject.Find("StorageBox");
													if (14098 - 257991 == -243892)
													{
														continue;
													}
													if (gameObject)
													{
														if (157588 - 422256 != -264668)
														{
															continue;
														}
														gameObject.animation.Play("close");
														if (232622 - 331091 == -98468)
														{
															continue;
														}
													}
													this.mState = eStorageState.close;
													if (86066 - 315201 == -229134)
													{
														continue;
													}
													this.zENcEYbakir = Time.time;
													if (281935 - 124900 == 157036)
													{
														continue;
													}
													if (this.gE0cEF9PR6y)
													{
														if (250899 - 324670 == -73770)
														{
															continue;
														}
														this.audio.PlayOneShot(this.gE0cEF9PR6y);
														if (197345 - 413218 != -215873)
														{
															continue;
														}
													}
												}
												GUI.EndGroup();
												if (126581 - 563875 != -437293)
												{
													this.RenderNPC((float)0);
													if (122279 - 88681 != 33599)
													{
														this.RenderDragIcon();
														if (283523 - 211095 != 72429)
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
						if (eStorageState != eStorageState.close)
						{
							break;
						}
						if (132086 - 11383 == 120703)
						{
							this.FlgcEaCF6Qi = Mathf.SmoothStep((float)0, (float)1, (float)2 * num);
							if (167437 - 169498 == -2061)
							{
								this.RenderNPC(this.FlgcEaCF6Qi);
								if (112824 - 534890 == -422066)
								{
									GUI.DrawTexture(new Rect(this.FYbcE3ZToWU - (float)578 + this.FlgcEaCF6Qi * (float)578, (float)0, (float)578, (float)1024), this.D1RcE42p67L);
									if (208395 - 542961 != -334565)
									{
										if (num <= 0.5f)
										{
											break;
										}
										if (162513 - 371605 == -209092)
										{
											Game.mGameState = eGameState.Normal;
											if (40304 - 462259 != -421954)
											{
												GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
												if (34310 - 64442 != -30131)
												{
													gameGui.enabled = true;
													if (197521 - 334825 != -137303)
													{
														this.mState = eStorageState.disabled;
														if (225687 - 3950 != 221738)
														{
															this.enabled = false;
															if (21320 - 230372 != -209051)
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

	// Token: 0x060062FD RID: 25341 RVA: 0x00DBD984 File Offset: 0x00DBBB84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (285696 - 535965 != -250268)
		{
		}
		for (;;)
		{
			this.aAecE9RFXSK = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (20620 - 434662 == -414042)
			{
				this.GkJcEWfQl8n = new GUIStyle();
				if (48591 - 593361 != -544769)
				{
					this.GkJcEWfQl8n.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (216159 - 93783 == 122376)
					{
						this.GkJcEWfQl8n.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (97192 - 187108 == -89916)
						{
							this.GkJcEWfQl8n.alignment = TextAnchor.UpperLeft;
							if (288300 - 88656 != 199645)
							{
								this.cJ1cEuMFDeY = new GUIStyle();
								if (68797 - 554752 == -485955)
								{
									this.cJ1cEuMFDeY.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (236075 - 211093 != 24983)
									{
										this.cJ1cEuMFDeY.alignment = TextAnchor.UpperLeft;
										if (148709 - 105494 != 43216)
										{
											this.ResetNPC();
											if (30327 - 203195 == -172868)
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

	// Token: 0x060062FE RID: 25342 RVA: 0x00DBDB68 File Offset: 0x00DBBD68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (50326 - 281291 != -230964)
		{
		}
		for (;;)
		{
			this.ByDcEAN4dnW = (Texture)Resources.Load("GameGui/Story/Characters/" + CharacterData.current.Type, typeof(Texture));
			if (27148 - 417813 == -390665)
			{
				string type = CharacterData.current.Type;
				if (62154 - 272642 == -210488)
				{
					if (type == "Wolf")
					{
						if (168171 - 576456 == -408285)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 101 + UnityEngine.Random.Range(0, 5));
							if (296839 - 296726 != 114)
							{
								break;
							}
						}
					}
					else if (type == "Bison")
					{
						if (151085 - 38311 != 112775)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 201 + UnityEngine.Random.Range(0, 5));
							if (84237 - 412373 == -328136)
							{
								break;
							}
						}
					}
					else if (type == "Panda")
					{
						if (251449 - 374706 != -123256)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 301 + UnityEngine.Random.Range(0, 5));
							if (215101 - 566997 == -351896)
							{
								break;
							}
						}
					}
					else if (type == "Whale")
					{
						if (156389 - 224426 == -68037)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 401 + UnityEngine.Random.Range(0, 5));
							if (224305 - 390605 == -166300)
							{
								break;
							}
						}
					}
					else if (type == "Cat")
					{
						if (58307 - 482552 == -424245)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 501 + UnityEngine.Random.Range(0, 5));
							if (17150 - 122596 != -105445)
							{
								break;
							}
						}
					}
					else if (type == "Chameleon")
					{
						if (181641 - 302862 == -121221)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 601 + UnityEngine.Random.Range(0, 5));
							if (158092 - 68636 == 89456)
							{
								break;
							}
						}
					}
					else if (type == "Rabbit")
					{
						if (94999 - 546031 != -451031)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 701 + UnityEngine.Random.Range(0, 5));
							if (248990 - 5381 == 243609)
							{
								break;
							}
						}
					}
					else if (type == "Mole")
					{
						if (194221 - 427769 != -233547)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 801 + UnityEngine.Random.Range(0, 5));
							if (190373 - 538140 == -347767)
							{
								break;
							}
						}
					}
					else if (type == "Monkey")
					{
						if (253744 - 541695 != -287950)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 901 + UnityEngine.Random.Range(0, 5));
							if (118620 - 314122 == -195502)
							{
								break;
							}
						}
					}
					else if (type == "Penguin")
					{
						if (39872 - 304408 == -264536)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 1001 + UnityEngine.Random.Range(0, 5));
							if (262093 - 486849 != -224755)
							{
								break;
							}
						}
					}
					else if (type == "Sheep")
					{
						if (190625 - 162000 != 28626)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 1101 + UnityEngine.Random.Range(0, 5));
							if (138122 - 301812 != -163689)
							{
								break;
							}
						}
					}
					else
					{
						if (!(type == "Bat"))
						{
							break;
						}
						if (192179 - 143628 != 48552)
						{
							this.SsAcEykITSg = Language.getMessage("StorageGui", 1201 + UnityEngine.Random.Range(0, 5));
							if (206609 - 532752 == -326143)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062FF RID: 25343 RVA: 0x00DBE0D4 File Offset: 0x00DBC2D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC(float mOffset)
	{
		if (50084 - 114752 != -64667)
		{
		}
		for (;;)
		{
			if (this.ByDcEAN4dnW)
			{
				if (168863 - 194166 == -25302)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)0 - mOffset * (float)this.ByDcEAN4dnW.width, (float)(1024 - this.ByDcEAN4dnW.height), (float)this.ByDcEAN4dnW.width, (float)this.ByDcEAN4dnW.height), this.ByDcEAN4dnW);
				if (71987 - 252970 != -180983)
				{
					continue;
				}
			}
			if (this.mState != eStorageState.open)
			{
				break;
			}
			if (152702 - 486158 == -333456)
			{
				GUI.DrawTexture(new Rect(0.5f * this.FYbcE3ZToWU - (float)336, (float)724 + mOffset * (float)300, (float)836, (float)196), this.aAecE9RFXSK);
				if (290348 - 15583 == 274765)
				{
					if (mOffset != (float)0)
					{
						break;
					}
					if (179381 - 267358 == -87977)
					{
						float num = Time.time - this.zENcEYbakir;
						if (238930 - 468129 != -229198)
						{
							GUI.BeginGroup(new Rect(0.5f * this.FYbcE3ZToWU - (float)350, (float)724, (float)850, (float)200));
							if (30272 - 473589 != -443316)
							{
								GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.aAecE9RFXSK);
								if (216761 - 21400 == 195361)
								{
									GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), CharacterData.current.Name, this.GkJcEWfQl8n);
									if (181495 - 530229 != -348733)
									{
										GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.SsAcEykITSg, num - 0.5f), this.cJ1cEuMFDeY);
										if (134569 - 544432 == -409863)
										{
											GUI.EndGroup();
											if (8921 - 524104 == -515183)
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

	// Token: 0x06006300 RID: 25344 RVA: 0x00DBE394 File Offset: 0x00DBC594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetStorageButton()
	{
		if (235255 - 131134 != 104121)
		{
		}
		for (;;)
		{
			IL_155:
			int i = 0;
			if (293463 - 112804 == 180659)
			{
				while (i < 168)
				{
					this.GN1cE0TS5G0[i] = new IconButtonClass();
					if (298833 - 213829 != 85004)
					{
						goto IL_155;
					}
					if (PlayerData.ItemList[i].name != "none")
					{
						if (27097 - 527498 == -500400)
						{
							goto IL_155;
						}
						this.GN1cE0TS5G0[i].name = PlayerData.ItemList[i].name;
						if (62955 - 521800 == -458844)
						{
							goto IL_155;
						}
						this.GN1cE0TS5G0[i].command = -1 * (i + 20);
						if (274628 - 59985 != 214643)
						{
							goto IL_155;
						}
						this.GN1cE0TS5G0[i].image = (Texture2D)IconButton.getCommandIcon(-1 * (i + 10));
						if (193818 - 306297 != -112479)
						{
							goto IL_155;
						}
					}
					i++;
					if (280383 - 251515 == 28869)
					{
						goto IL_155;
					}
				}
				if (287715 - 28974 == 258741)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006301 RID: 25345 RVA: 0x00DBE524 File Offset: 0x00DBC724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderStorageButton()
	{
		if (281202 - 144871 != 136331)
		{
		}
		for (;;)
		{
			IL_3B7:
			int i = this.hUNcEdFgLQG * 42;
			if (13875 - 173374 == -159499)
			{
				while (i < 42 + this.hUNcEdFgLQG * 42)
				{
					Rect position = new Rect((float)(151 + i % 6 * 60), (float)(79 + global::Math.div((float)(i % 42), (float)6) * 60), (float)64, (float)64);
					if (298321 - 179102 == 119220)
					{
						goto IL_3B7;
					}
					int num = 24;
					if (104253 - 103314 != 939)
					{
						goto IL_3B7;
					}
					int inventoryKey = PlayerData.InventoryKey;
					if (22451 - 597643 == -575191)
					{
						goto IL_3B7;
					}
					if (inventoryKey == 1)
					{
						if (114743 - 129240 == -14496)
						{
							goto IL_3B7;
						}
						num = 42;
						if (119540 - 206074 == -86533)
						{
							goto IL_3B7;
						}
					}
					else if (inventoryKey == 2)
					{
						if (7009 - 267939 == -260929)
						{
							goto IL_3B7;
						}
						num = 60;
						if (218817 - 238714 == -19896)
						{
							goto IL_3B7;
						}
					}
					else if (inventoryKey == 3)
					{
						if (4467 - 268329 != -263862)
						{
							goto IL_3B7;
						}
						num = 84;
						if (37295 - 233627 != -196332)
						{
							goto IL_3B7;
						}
					}
					else if (inventoryKey == 4)
					{
						if (217186 - 140710 != 76476)
						{
							goto IL_3B7;
						}
						num = 126;
						if (268549 - 575430 == -306880)
						{
							goto IL_3B7;
						}
					}
					else if (inventoryKey == 5)
					{
						if (155996 - 100594 != 55402)
						{
							goto IL_3B7;
						}
						num = 168;
						if (31215 - 265912 != -234697)
						{
							goto IL_3B7;
						}
					}
					if (i >= num)
					{
						if (287033 - 578572 == -291538)
						{
							goto IL_3B7;
						}
						GUI.DrawTexture(new Rect(position.x + (float)6, position.y + (float)5, (float)51, (float)51), this.pFHcEUwcEeY);
						if (238415 - 162971 == 75445)
						{
							goto IL_3B7;
						}
					}
					else
					{
						if (this.GN1cE0TS5G0[i].name != "none")
						{
							if (201207 - 572427 == -371219)
							{
								goto IL_3B7;
							}
							GUI.DrawTexture(position, this.GN1cE0TS5G0[i].image);
							if (132947 - 168898 != -35951)
							{
								goto IL_3B7;
							}
						}
						IconButtonClass iconButtonClass = this.GN1cE0TS5G0[i];
						if (239607 - 101096 == 138512)
						{
							goto IL_3B7;
						}
						eIconButtonState eIconButtonState = IconButton.IconButton(iconButtonClass, new Rect(position.x + (float)7, position.y + (float)7, (float)50, (float)50));
						if (107083 - 77025 != 30058)
						{
							goto IL_3B7;
						}
						eIconButtonState eIconButtonState2 = eIconButtonState;
						if (79355 - 68114 == 11242)
						{
							goto IL_3B7;
						}
						if (eIconButtonState2 == eIconButtonState.over)
						{
							if (255232 - 79572 != 175660)
							{
								goto IL_3B7;
							}
							goto IL_297;
						}
						else if (eIconButtonState2 == eIconButtonState.hover)
						{
							if (217362 - 8924 != 208439)
							{
								goto IL_297;
							}
							goto IL_3B7;
						}
						else if (eIconButtonState2 == eIconButtonState.drag)
						{
							if (57545 - 204218 != -146673)
							{
								goto IL_3B7;
							}
							iconButtonClass.state = eIconButtonState.none;
							if (199731 - 159143 == 40589)
							{
								goto IL_3B7;
							}
							if (this.GN1cE0TS5G0[i].name != "none")
							{
								if (69038 - 41797 == 27242)
								{
									goto IL_3B7;
								}
								this.e5bcEgKxqY9 = -10 - i;
								if (157069 - 565479 == -408409)
								{
									goto IL_3B7;
								}
							}
						}
						else if (eIconButtonState2 == eIconButtonState.drop)
						{
							if (213898 - 269311 == -55412)
							{
								goto IL_3B7;
							}
							if (20 > this.e5bcEgKxqY9)
							{
								goto IL_CE;
							}
							if (133689 - 568165 != -434476)
							{
								goto IL_3B7;
							}
							if (this.e5bcEgKxqY9 >= 50)
							{
								goto IL_CE;
							}
							if (175266 - 154408 != 20858)
							{
								goto IL_3B7;
							}
							int num2 = i;
							if (47011 - 453002 != -405991)
							{
								goto IL_3B7;
							}
							int num3 = this.e5bcEgKxqY9 - 20;
							if (238827 - 28702 != 210125)
							{
								goto IL_3B7;
							}
							InventoryClass inventoryClass = PlayerData.ItemList[num2];
							if (289396 - 207199 != 82197)
							{
								goto IL_3B7;
							}
							PlayerData.ItemList[num2] = CharacterData.current.inventory[num3];
							if (53740 - 165098 != -111358)
							{
								goto IL_3B7;
							}
							CharacterData.current.inventory[num3] = inventoryClass;
							if (55897 - 519297 == -463399)
							{
								goto IL_3B7;
							}
							PlayerData.ItemList[num2].slot = num2;
							if (290755 - 154507 == 136249)
							{
								goto IL_3B7;
							}
							CharacterData.current.inventory[num3].slot = num3;
							if (245799 - 480830 == -235030)
							{
								goto IL_3B7;
							}
							if (PhotonClient.IsInitialized())
							{
								if (83574 - 245445 != -161871)
								{
									goto IL_3B7;
								}
								Hashtable hashtable = new Hashtable();
								if (232049 - 22584 != 209465)
								{
									goto IL_3B7;
								}
								hashtable.Add(21, PhotonClient.cInt16(num2 + 100));
								if (298703 - 57023 != 241680)
								{
									goto IL_3B7;
								}
								hashtable.Add(22, PhotonClient.cInt16(num3));
								if (216711 - 228342 == -11630)
								{
									goto IL_3B7;
								}
								PhotonClient.SendEvent(0, 174, hashtable, false, true);
								if (179482 - 176653 != 2829)
								{
									goto IL_3B7;
								}
							}
							this.ResetStorageButton();
							if (206489 - 255389 == -48899)
							{
								goto IL_3B7;
							}
							this.ResetInventoryButton();
							if (42330 - 126946 != -84616)
							{
								goto IL_3B7;
							}
							IL_76A:
							this.e5bcEgKxqY9 = 0;
							if (221170 - 33549 != 187621)
							{
								goto IL_3B7;
							}
							goto IL_87A;
							IL_CE:
							if (this.e5bcEgKxqY9 > -10)
							{
								goto IL_76A;
							}
							if (259639 - 6732 != 252907)
							{
								goto IL_3B7;
							}
							this.ResetStorageButton();
							if (264452 - 162574 != 101879)
							{
								goto IL_76A;
							}
							goto IL_3B7;
						}
						IL_87A:
						if (!(this.GN1cE0TS5G0[i].name != "none"))
						{
							goto IL_967;
						}
						if (294195 - 368595 != -74400)
						{
							goto IL_3B7;
						}
						if (PlayerData.ItemList[i].num <= 1)
						{
							goto IL_967;
						}
						if (93035 - 552930 == -459894)
						{
							goto IL_3B7;
						}
						GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.rhrcEfCVfkH);
						if (71429 - 257208 == -185778)
						{
							goto IL_3B7;
						}
						GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + PlayerData.ItemList[i].num, this.dsycESYYvE1);
						if (111211 - 457053 != -345842)
						{
							goto IL_3B7;
						}
						goto IL_967;
						IL_297:
						if (this.GN1cE0TS5G0[i].name != "none")
						{
							goto IL_22D;
						}
						if (56790 - 200478 != -143688)
						{
							goto IL_3B7;
						}
						if (this.e5bcEgKxqY9 != 0)
						{
							if (790 - 374344 != -373553)
							{
								goto IL_22D;
							}
							goto IL_3B7;
						}
						IL_931:
						if (this.GN1cE0TS5G0[i].name != "none")
						{
							if (227832 - 361449 == -133616)
							{
								goto IL_3B7;
							}
							if (this.e5bcEgKxqY9 == 0)
							{
								if (86912 - 515913 == -429000)
								{
									goto IL_3B7;
								}
								this.nG9cEiiwIEI = ItemData.getName(PlayerData.ItemList[i].name);
								if (196083 - 449199 != -253116)
								{
									goto IL_3B7;
								}
								this.XijcEDYnZ9F = new Rect(this.FYbcE3ZToWU - (float)570 + position.x, position.y + (float)51, (float)300, (float)30);
								if (37423 - 76221 != -38798)
								{
									goto IL_3B7;
								}
							}
						}
						goto IL_87A;
						IL_22D:
						GUI.DrawTexture(new Rect(position.x + (float)6, position.y + (float)5, (float)51, (float)51), this.kXtcEMm0cdj);
						if (51042 - 186826 != -135784)
						{
							goto IL_3B7;
						}
						goto IL_931;
					}
					IL_967:
					i++;
					if (8099 - 253164 == -245064)
					{
						goto IL_3B7;
					}
				}
				if (41089 - 261760 == -220671)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006302 RID: 25346 RVA: 0x00DBEF78 File Offset: 0x00DBD178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetInventoryButton()
	{
		if (14158 - 553461 != -539303)
		{
		}
		for (;;)
		{
			IL_82:
			int i = 0;
			if (60532 - 357241 != -296708)
			{
				while (i < 30)
				{
					this.UFgcE8YjEoS[i] = new IconButtonClass();
					if (279600 - 543554 == -263953)
					{
						goto IL_82;
					}
					if (CharacterData.current.inventory[i].name != "none")
					{
						if (271897 - 438920 == -167022)
						{
							goto IL_82;
						}
						this.UFgcE8YjEoS[i].name = CharacterData.current.inventory[i].name;
						if (93294 - 301856 == -208561)
						{
							goto IL_82;
						}
						this.UFgcE8YjEoS[i].command = i;
						if (129532 - 463286 == -333753)
						{
							goto IL_82;
						}
						this.UFgcE8YjEoS[i].image = (Texture2D)IconButton.getIconImage(CharacterData.current.inventory[i].name);
						if (176102 - 447516 == -271413)
						{
							goto IL_82;
						}
					}
					i++;
					if (242930 - 249962 == -7031)
					{
						goto IL_82;
					}
				}
				if (72452 - 350217 != -277764)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006303 RID: 25347 RVA: 0x00DBF114 File Offset: 0x00DBD314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderInventoryButton()
	{
		if (98121 - 150907 != -52785)
		{
		}
		for (;;)
		{
			IL_2C1:
			int i = 0;
			if (248888 - 189410 == 59478)
			{
				while (i < 30)
				{
					Rect position = new Rect((float)151 + global::Math.mod((float)i, (float)6) * (float)60, (float)(639 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
					if (184648 - 217943 == -33294)
					{
						goto IL_2C1;
					}
					if (this.UFgcE8YjEoS[i].name != "none")
					{
						if (79130 - 203827 != -124697)
						{
							goto IL_2C1;
						}
						GUI.DrawTexture(position, this.UFgcE8YjEoS[i].image);
						if (179668 - 546365 != -366697)
						{
							goto IL_2C1;
						}
					}
					IconButtonClass iconButtonClass = this.UFgcE8YjEoS[i];
					if (14787 - 67519 == -52731)
					{
						goto IL_2C1;
					}
					eIconButtonState eIconButtonState = IconButton.IconButton(iconButtonClass, new Rect(position.x + (float)7, position.y + (float)7, (float)50, (float)50));
					if (97555 - 404779 == -307223)
					{
						goto IL_2C1;
					}
					eIconButtonState eIconButtonState2 = eIconButtonState;
					if (174699 - 144163 != 30536)
					{
						goto IL_2C1;
					}
					if (eIconButtonState2 == eIconButtonState.over)
					{
						if (299111 - 581199 != -282087)
						{
							goto IL_59B;
						}
						goto IL_2C1;
					}
					else if (eIconButtonState2 == eIconButtonState.hover)
					{
						if (167757 - 374484 != -206727)
						{
							goto IL_2C1;
						}
						goto IL_59B;
					}
					else if (eIconButtonState2 == eIconButtonState.drag)
					{
						if (242790 - 212172 != 30618)
						{
							goto IL_2C1;
						}
						iconButtonClass.state = eIconButtonState.none;
						if (136872 - 472471 == -335598)
						{
							goto IL_2C1;
						}
						if (this.UFgcE8YjEoS[i].name != "none")
						{
							if (287415 - 527573 != -240158)
							{
								goto IL_2C1;
							}
							this.e5bcEgKxqY9 = i + 20;
							if (159615 - 248720 != -89105)
							{
								goto IL_2C1;
							}
						}
					}
					else if (eIconButtonState2 == eIconButtonState.drop)
					{
						if (41620 - 34011 == 7610)
						{
							goto IL_2C1;
						}
						if (20 > this.e5bcEgKxqY9)
						{
							goto IL_196;
						}
						if (265705 - 528359 != -262654)
						{
							goto IL_2C1;
						}
						if (this.e5bcEgKxqY9 >= 50)
						{
							goto IL_196;
						}
						if (202240 - 408866 != -206626)
						{
							goto IL_2C1;
						}
						if (this.e5bcEgKxqY9 == i - 20)
						{
							goto IL_196;
						}
						if (171499 - 371198 == -199698)
						{
							goto IL_2C1;
						}
						CharacterData.current.swapInventory(this.e5bcEgKxqY9 - 20, i);
						if (223920 - 548369 != -324449)
						{
							goto IL_2C1;
						}
						this.ResetInventoryButton();
						if (121437 - 283679 == -162241)
						{
							goto IL_2C1;
						}
						IL_A0A:
						this.e5bcEgKxqY9 = 0;
						if (155028 - 552866 != -397837)
						{
							goto IL_2E2;
						}
						goto IL_2C1;
						IL_196:
						if (this.e5bcEgKxqY9 > -10)
						{
							goto IL_A0A;
						}
						if (296908 - 359662 == -62753)
						{
							goto IL_2C1;
						}
						int num = -10 - this.e5bcEgKxqY9;
						if (37621 - 135249 != -97628)
						{
							goto IL_2C1;
						}
						int num2 = i;
						if (133271 - 311554 == -178282)
						{
							goto IL_2C1;
						}
						InventoryClass inventoryClass = PlayerData.ItemList[num];
						if (61836 - 323309 == -261472)
						{
							goto IL_2C1;
						}
						PlayerData.ItemList[num] = CharacterData.current.inventory[num2];
						if (51240 - 140649 == -89408)
						{
							goto IL_2C1;
						}
						CharacterData.current.inventory[num2] = inventoryClass;
						if (18481 - 552134 == -533652)
						{
							goto IL_2C1;
						}
						PlayerData.ItemList[num].slot = num;
						if (53407 - 20812 != 32595)
						{
							goto IL_2C1;
						}
						CharacterData.current.inventory[num2].slot = num2;
						if (84688 - 569319 == -484630)
						{
							goto IL_2C1;
						}
						if (PhotonClient.IsInitialized())
						{
							if (226018 - 405025 != -179007)
							{
								goto IL_2C1;
							}
							Hashtable hashtable = new Hashtable();
							if (176732 - 385906 == -209173)
							{
								goto IL_2C1;
							}
							hashtable.Add(21, PhotonClient.cInt16(num + 100));
							if (235317 - 79200 == 156118)
							{
								goto IL_2C1;
							}
							hashtable.Add(22, PhotonClient.cInt16(num2));
							if (156076 - 143809 != 12267)
							{
								goto IL_2C1;
							}
							PhotonClient.SendEvent(0, 174, hashtable, false, true);
							if (32426 - 538300 == -505873)
							{
								goto IL_2C1;
							}
						}
						this.ResetStorageButton();
						if (137549 - 121852 == 15698)
						{
							goto IL_2C1;
						}
						this.ResetInventoryButton();
						if (162142 - 599630 != -437488)
						{
							goto IL_2C1;
						}
						goto IL_A0A;
					}
					IL_2E2:
					if (!(this.UFgcE8YjEoS[i].name != "none"))
					{
						goto IL_1E5;
					}
					if (52282 - 592152 != -539870)
					{
						goto IL_2C1;
					}
					if (CharacterData.current.inventory[i].num <= 1)
					{
						goto IL_1E5;
					}
					if (185806 - 208649 == -22842)
					{
						goto IL_2C1;
					}
					GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.rhrcEfCVfkH);
					if (10195 - 543326 != -533131)
					{
						goto IL_2C1;
					}
					GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.dsycESYYvE1);
					if (123041 - 588254 != -465213)
					{
						goto IL_2C1;
					}
					IL_7D5:
					i++;
					if (154208 - 289525 != -135316)
					{
						continue;
					}
					goto IL_2C1;
					IL_1E5:
					string type = CharacterData.current.inventory[i].getType();
					if (4475 - 369991 != -365516)
					{
						goto IL_2C1;
					}
					if (!(type == "w"))
					{
						if (57012 - 445563 != -388551)
						{
							goto IL_2C1;
						}
						if (!(type == "a"))
						{
							if (216104 - 443710 != -227606)
							{
								goto IL_2C1;
							}
							if (!(type == "c"))
							{
								if (38552 - 517440 != -478888)
								{
									goto IL_2C1;
								}
								if (!(type == "b"))
								{
									if (210107 - 445155 != -235048)
									{
										goto IL_2C1;
									}
									if (!(type == "t"))
									{
										if (129744 - 320659 == -190914)
										{
											goto IL_2C1;
										}
										if (!(type == "p"))
										{
											goto IL_7D5;
										}
										if (148668 - 397188 == -248519)
										{
											goto IL_2C1;
										}
									}
								}
							}
						}
					}
					if (CharacterData.current.inventory[i].owner == 0)
					{
						if (6193 - 344649 != -338456)
						{
							goto IL_2C1;
						}
						GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.QYmcELrFhbD);
						if (17675 - 180606 != -162931)
						{
							goto IL_2C1;
						}
						goto IL_7D5;
					}
					else
					{
						if (CharacterData.current.inventory[i].owner == CharacterData.current.CID)
						{
							goto IL_7D5;
						}
						if (267494 - 152238 != 115256)
						{
							goto IL_2C1;
						}
						GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.zYicEwEQN6Q);
						if (109078 - 376056 != -266977)
						{
							goto IL_7D5;
						}
						goto IL_2C1;
					}
					IL_59B:
					if (this.UFgcE8YjEoS[i].name != "none")
					{
						goto IL_672;
					}
					if (187496 - 97251 != 90245)
					{
						goto IL_2C1;
					}
					if (this.e5bcEgKxqY9 != 0)
					{
						if (103972 - 141845 != -37873)
						{
							goto IL_2C1;
						}
						goto IL_672;
					}
					IL_60:
					if (this.UFgcE8YjEoS[i].name != "none")
					{
						if (181285 - 67163 != 114122)
						{
							goto IL_2C1;
						}
						if (this.e5bcEgKxqY9 == 0)
						{
							if (202689 - 385786 != -183097)
							{
								goto IL_2C1;
							}
							this.nG9cEiiwIEI = ItemData.getName(CharacterData.current.inventory[i].name);
							if (183880 - 304392 != -120512)
							{
								goto IL_2C1;
							}
							this.XijcEDYnZ9F = new Rect(this.FYbcE3ZToWU - (float)570 + position.x, position.y + (float)51, (float)300, (float)30);
							if (67042 - 558082 != -491040)
							{
								goto IL_2C1;
							}
						}
					}
					goto IL_2E2;
					IL_672:
					GUI.DrawTexture(new Rect(position.x + (float)6, position.y + (float)5, (float)51, (float)51), this.kXtcEMm0cdj);
					if (141795 - 545271 != -403476)
					{
						goto IL_2C1;
					}
					goto IL_60;
				}
				if (45657 - 72785 != -27127)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006304 RID: 25348 RVA: 0x00DBFBF4 File Offset: 0x00DBDDF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (161367 - 140069 != 21299)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (195148 - 428046 == -232898)
				{
					break;
				}
			}
			else
			{
				if (this.e5bcEgKxqY9 == 0)
				{
					break;
				}
				if (37915 - 414928 == -377013)
				{
					if (Input.GetMouseButton(1))
					{
						if (186279 - 248224 != -61944)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (288028 - 451514 == -163486)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (186925 - 108538 == 78387)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.e5bcEgKxqY9));
									if (287723 - 281286 == 6437)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.e5bcEgKxqY9 = 0;
						if (195485 - 230035 != -34549)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006305 RID: 25349 RVA: 0x00DBFD7C File Offset: 0x00DBDF7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006306 RID: 25350 RVA: 0x00DBFD80 File Offset: 0x00DBDF80
	internal static bool VdWMD7pkNCdNbHo3ZAbI()
	{
		return true;
	}

	// Token: 0x06006307 RID: 25351 RVA: 0x00DBFD84 File Offset: 0x00DBDF84
	internal static bool waFZ91pkYW2A6S16vj7E()
	{
		return false;
	}

	// Token: 0x04007279 RID: 29305
	public int posx;

	// Token: 0x0400727A RID: 29306
	public int posy;

	// Token: 0x0400727B RID: 29307
	public int divx;

	// Token: 0x0400727C RID: 29308
	public int divy;

	// Token: 0x0400727D RID: 29309
	public int posa;

	// Token: 0x0400727E RID: 29310
	public int posb;

	// Token: 0x0400727F RID: 29311
	public int diva;

	// Token: 0x04007280 RID: 29312
	public int divb;

	// Token: 0x04007281 RID: 29313
	public eStorageState mState;

	// Token: 0x04007282 RID: 29314
	private float zENcEYbakir;

	// Token: 0x04007283 RID: 29315
	private float FYbcE3ZToWU;

	// Token: 0x04007284 RID: 29316
	private float HXAcEbMhY9D;

	// Token: 0x04007285 RID: 29317
	private int hUNcEdFgLQG;

	// Token: 0x04007286 RID: 29318
	private int e5bcEgKxqY9;

	// Token: 0x04007287 RID: 29319
	private float FlgcEaCF6Qi;

	// Token: 0x04007288 RID: 29320
	private Texture D1RcE42p67L;

	// Token: 0x04007289 RID: 29321
	private Texture gKQcEsmcvjm;

	// Token: 0x0400728A RID: 29322
	private Texture LOjcEHxPMGJ;

	// Token: 0x0400728B RID: 29323
	private Texture yFbcE7QT7i2;

	// Token: 0x0400728C RID: 29324
	private Texture zfRcEZunxaZ;

	// Token: 0x0400728D RID: 29325
	private Texture CuhcECqkdkb;

	// Token: 0x0400728E RID: 29326
	private Texture kXtcEMm0cdj;

	// Token: 0x0400728F RID: 29327
	private Texture rhrcEfCVfkH;

	// Token: 0x04007290 RID: 29328
	private Texture QYmcELrFhbD;

	// Token: 0x04007291 RID: 29329
	private Texture zYicEwEQN6Q;

	// Token: 0x04007292 RID: 29330
	private Texture pFHcEUwcEeY;

	// Token: 0x04007293 RID: 29331
	private GUIStyle SdBcENrf6fm;

	// Token: 0x04007294 RID: 29332
	private GUIStyle zaZcEEqxxfm;

	// Token: 0x04007295 RID: 29333
	private GUIStyle KY2cEPxoZq7;

	// Token: 0x04007296 RID: 29334
	private GUIStyle dsycESYYvE1;

	// Token: 0x04007297 RID: 29335
	private GUIStyle IlFcEBkorcQ;

	// Token: 0x04007298 RID: 29336
	private IconButtonClass[] GN1cE0TS5G0;

	// Token: 0x04007299 RID: 29337
	private IconButtonClass[] UFgcE8YjEoS;

	// Token: 0x0400729A RID: 29338
	private string nG9cEiiwIEI;

	// Token: 0x0400729B RID: 29339
	private Rect XijcEDYnZ9F;

	// Token: 0x0400729C RID: 29340
	private string RW3cEmpK8P4;

	// Token: 0x0400729D RID: 29341
	private AudioClip nkycEjwdLym;

	// Token: 0x0400729E RID: 29342
	private AudioClip ntUcEoG1yPj;

	// Token: 0x0400729F RID: 29343
	private AudioClip pKocEkS1R18;

	// Token: 0x040072A0 RID: 29344
	private AudioClip gE0cEF9PR6y;

	// Token: 0x040072A1 RID: 29345
	private Texture ByDcEAN4dnW;

	// Token: 0x040072A2 RID: 29346
	private Texture aAecE9RFXSK;

	// Token: 0x040072A3 RID: 29347
	private GUIStyle GkJcEWfQl8n;

	// Token: 0x040072A4 RID: 29348
	private GUIStyle cJ1cEuMFDeY;

	// Token: 0x040072A5 RID: 29349
	private string SsAcEykITSg;
}
