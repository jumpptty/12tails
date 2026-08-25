using System;
using System.Collections;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020010A5 RID: 4261
[Serializable]
public class TransportGui : MonoBehaviour
{
	// Token: 0x0600632D RID: 25389 RVA: 0x00DC1A78 File Offset: 0x00DBFC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TransportGui()
	{
		if (150876 - 558658 != -407782)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (98817 - 111118 != -12300)
			{
				base..ctor();
				if (11968 - 468027 != -456058)
				{
					this.mState = eTransportState.init;
					if (216385 - 17994 == 198391)
					{
						this.CcKcPzEjUZY = string.Empty;
						if (258036 - 197417 != 60620)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600632E RID: 25390 RVA: 0x00DC1B38 File Offset: 0x00DBFD38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (234613 - 303407 != -68794)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (138128 - 69372 == 68756)
			{
				if (this.mState == eTransportState.init)
				{
					if (100842 - 505848 == -405005)
					{
						continue;
					}
					this.InitNPC();
					if (203026 - 338335 == -135308)
					{
						continue;
					}
					this.InitTransportMenu();
					if (225796 - 343673 != -117877)
					{
						continue;
					}
					this.InitNoticeBar();
					if (258194 - 270014 != -11820)
					{
						continue;
					}
				}
				else
				{
					this.ResetNPC();
					if (98643 - 46874 != 51769)
					{
						continue;
					}
				}
				this.p74cPrnBljt = MissionData.getData(Game.mGameCode);
				if (243379 - 591860 == -348481)
				{
					this.BUGcPxkmCrk = 0;
					if (230902 - 269909 != -39006)
					{
						this.W2scPTdE0ay = 1f;
						if (92910 - 453364 == -360454)
						{
							if (this.ncgcPYpftpa)
							{
								if (245229 - 512194 != -266965)
								{
									continue;
								}
								this.ncgcPYpftpa.animation.CrossFade("talk", 0.2f);
								if (117974 - 410611 == -292636)
								{
									continue;
								}
							}
							this.mState = eTransportState.open;
							if (261254 - 536740 != -275485)
							{
								this.lS1cPqyDpEF = Time.time;
								if (186508 - 147243 == 39265)
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

	// Token: 0x0600632F RID: 25391 RVA: 0x00DC1D50 File Offset: 0x00DBFF50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (232830 - 53645 != 179185)
		{
		}
		for (;;)
		{
			if (this.mState <= eTransportState.init)
			{
				if (116906 - 491877 == -374971)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (293982 - 330669 == -36687)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (269304 - 576528 == -307224)
					{
						this.HKqcPpMdMRx = (float)(1024 * Screen.width / Screen.height);
						if (27145 - 317185 == -290040)
						{
							this.sIgcPRm9xft = (float)Screen.height / 1024f;
							if (105638 - 66215 == 39423)
							{
								this.RenderTransportMenu();
								if (142406 - 25740 != 116667)
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

	// Token: 0x06006330 RID: 25392 RVA: 0x00DC1EA0 File Offset: 0x00DC00A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (38508 - 553090 != -514582)
		{
		}
		for (;;)
		{
			this.jaxcPbhYRil = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (7121 - 463266 != -456144)
			{
				this.IPbcPdysbPY = new GUIStyle();
				if (94956 - 474864 == -379908)
				{
					this.IPbcPdysbPY.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (272977 - 305091 != -32113)
					{
						this.IPbcPdysbPY.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (198198 - 465711 == -267513)
						{
							this.IPbcPdysbPY.alignment = TextAnchor.UpperLeft;
							if (269544 - 166886 != 102659)
							{
								this.LNEcPgUNQ9i = new GUIStyle();
								if (244673 - 77270 != 167404)
								{
									this.LNEcPgUNQ9i.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (241083 - 189192 == 51891)
									{
										this.LNEcPgUNQ9i.alignment = TextAnchor.UpperLeft;
										if (130707 - 258520 == -127813)
										{
											this.ncgcPYpftpa = GameObject.Find("PilotMole");
											if (128767 - 171446 == -42679)
											{
												this.S83cP3p4otN = (Texture)Resources.Load("GameGui/Story/Characters/PilotMole", typeof(Texture));
												if (208946 - 492231 != -283284)
												{
													this.ResetNPC();
													if (51709 - 580873 == -529164)
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

	// Token: 0x06006331 RID: 25393 RVA: 0x00DC20E8 File Offset: 0x00DC02E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (296913 - 119981 != 176932)
		{
		}
		for (;;)
		{
			int num = UnityEngine.Random.Range(0, 2);
			if (164266 - 369267 == -205001)
			{
				this.XOlcPalhJnj = Language.getMessage("TransportGui", 101);
				if (85292 - 375973 != -290680)
				{
					this.nNvcPHtLBO5 = (AudioClip)Resources.Load("Sound/Voice/transport101", typeof(AudioClip));
					if (193435 - 395118 != -201682)
					{
						this.KutcP4PB1Da = Language.getMessage("TransportGui", 201 + num);
						if (272082 - 468827 != -196744)
						{
							this.jjCcP7UKCUq = (AudioClip)Resources.Load("Sound/Voice/transport" + (201 + num), typeof(AudioClip));
							if (55505 - 404244 == -348739)
							{
								this.aSlcPsHrkP3 = Language.getMessage("TransportGui", 301 + UnityEngine.Random.Range(0, 5));
								if (228530 - 15950 != 212581)
								{
									this.BelcPZOuWh5 = false;
									if (137919 - 411811 != -273891)
									{
										this.xQGcPCBPMCk = false;
										if (6616 - 580414 == -573798)
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

	// Token: 0x06006332 RID: 25394 RVA: 0x00DC229C File Offset: 0x00DC049C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (this.S83cP3p4otN)
		{
			GUI.DrawTexture(new Rect((float)0 - this.W2scPTdE0ay * (float)438, (float)596, (float)438, (float)428), this.S83cP3p4otN);
		}
	}

	// Token: 0x06006333 RID: 25395 RVA: 0x00DC22EC File Offset: 0x00DC04EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTransportMenu()
	{
		if (78959 - 345810 != -266850)
		{
		}
		for (;;)
		{
			this.VylcPfUmLDS = (Texture)Resources.Load("GameGui/GameWindow/optionMenu/worldMap", typeof(Texture));
			if (289827 - 442875 == -153048)
			{
				this.VS3cPLgbmgT = (Texture)Resources.Load("GameGui/GameWindow/optionMenu/mapPointer", typeof(Texture));
				if (229060 - 437117 != -208056)
				{
					int @int = PlayerPrefs.GetInt("language", 0);
					if (288699 - 329527 == -40828)
					{
						if (@int == 0)
						{
							if (126886 - 154654 == -27767)
							{
								continue;
							}
							this.GbucPMdZT2A = (Texture)Resources.Load("GameGui/Transport/thai/transportWindow", typeof(Texture));
							if (32941 - 160484 == -127542)
							{
								continue;
							}
							this.REWcP8vjE4O = (Texture)Resources.Load("GameGui/Transport/thai/ticket_snowCamp", typeof(Texture));
							if (73282 - 455893 != -382611)
							{
								continue;
							}
							this.n6bcPirSMic = (Texture)Resources.Load("GameGui/Transport/thai/ticket_crystalBeach", typeof(Texture));
							if (186546 - 542932 == -356385)
							{
								continue;
							}
							this.FCdcPDe8PpN = (Texture)Resources.Load("GameGui/Transport/thai/ticket_excavationCamp", typeof(Texture));
							if (199172 - 177869 == 21304)
							{
								continue;
							}
							this.WOucPmE2jaB = (Texture)Resources.Load("GameGui/Transport/thai/ticket_undergroundCamp", typeof(Texture));
							if (220284 - 444197 != -223913)
							{
								continue;
							}
							this.YgFcPjkEy8x = (Texture)Resources.Load("GameGui/Transport/thai/ticket_forestCamp", typeof(Texture));
							if (119504 - 37549 != 81955)
							{
								continue;
							}
						}
						else if (@int == 1)
						{
							if (86739 - 599723 != -512984)
							{
								continue;
							}
							this.GbucPMdZT2A = (Texture)Resources.Load("GameGui/Transport/english/transportWindow", typeof(Texture));
							if (123094 - 2092 != 121002)
							{
								continue;
							}
							this.REWcP8vjE4O = (Texture)Resources.Load("GameGui/Transport/english/ticket_snowCamp", typeof(Texture));
							if (174941 - 411829 != -236888)
							{
								continue;
							}
							this.n6bcPirSMic = (Texture)Resources.Load("GameGui/Transport/english/ticket_crystalBeach", typeof(Texture));
							if (209010 - 230945 != -21935)
							{
								continue;
							}
							this.FCdcPDe8PpN = (Texture)Resources.Load("GameGui/Transport/english/ticket_excavationCamp", typeof(Texture));
							if (220771 - 502148 == -281376)
							{
								continue;
							}
							this.WOucPmE2jaB = (Texture)Resources.Load("GameGui/Transport/english/ticket_undergroundCamp", typeof(Texture));
							if (22578 - 335512 != -312934)
							{
								continue;
							}
							this.YgFcPjkEy8x = (Texture)Resources.Load("GameGui/Transport/english/ticket_forestCamp", typeof(Texture));
							if (106890 - 249583 == -142692)
							{
								continue;
							}
						}
						this.xEqcPEkCDqg = new GUIStyle();
						if (93174 - 378431 == -285257)
						{
							this.xEqcPEkCDqg.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
							if (164620 - 496509 != -331888)
							{
								this.xEqcPEkCDqg.alignment = TextAnchor.MiddleCenter;
								if (95042 - 45726 == 49316)
								{
									this.xEqcPEkCDqg.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
									if (1881 - 308490 != -306608)
									{
										this.DEWcPPmHcNU = new GUIStyle();
										if (174968 - 157894 == 17074)
										{
											this.DEWcPPmHcNU.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Transport/button_left_h", typeof(Texture)));
											if (254166 - 147986 != 106181)
											{
												this.sQ8cPSfwW0B = new GUIStyle();
												if (287985 - 129740 == 158245)
												{
													this.sQ8cPSfwW0B.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Transport/button_right_h", typeof(Texture)));
													if (143795 - 275488 != -131692)
													{
														this.HswcP0OiSdj = new GUIStyle();
														if (145780 - 380528 == -234748)
														{
															this.HswcP0OiSdj.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Transport/button_takeoff_h", typeof(Texture)));
															if (237918 - 318571 == -80653)
															{
																this.r1ocPB0l4gq = new GUIStyle();
																if (272174 - 45245 == 226929)
																{
																	this.r1ocPB0l4gq.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Transport/button_close_h", typeof(Texture)));
																	if (234326 - 86017 == 148309)
																	{
																		this.oRMcPonQETM = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																		if (199130 - 460625 != -261494)
																		{
																			this.BJLcPkbkfk9 = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																			if (16428 - 451581 != -435152)
																			{
																				this.exqcPFyM281 = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																				if (225184 - 545346 != -320161)
																				{
																					this.BiTcPAWjnFi = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																					if (162212 - 18820 != 143393)
																					{
																						this.tLKcP9lh4em = (AudioClip)Resources.Load("Sound/GUI/takeoff", typeof(AudioClip));
																						if (108888 - 320317 == -211429)
																						{
																							this.QaUcPWbAwLC = (Texture)Resources.Load("GameGui/Transport/loadingTexture", typeof(Texture));
																							if (134615 - 277834 == -143219)
																							{
																								this.f2vcPu55R4o = (Texture)Resources.Load("GameGui/Common/White", typeof(Texture));
																								if (263284 - 245880 == 17404)
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

	// Token: 0x06006334 RID: 25396 RVA: 0x00DC2AC0 File Offset: 0x00DC0CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTransportMenu()
	{
		if (278303 - 510146 != -231842)
		{
		}
		for (;;)
		{
			float num = Time.time - this.lS1cPqyDpEF;
			if (212336 - 440014 == -227678)
			{
				eTransportState eTransportState = this.mState;
				if (256441 - 530996 != -274554)
				{
					if (eTransportState == eTransportState.init)
					{
						if (96925 - 99689 == -2764)
						{
							break;
						}
					}
					else if (eTransportState == eTransportState.open)
					{
						if (8048 - 584142 == -576094)
						{
							if (num <= 0.5f)
							{
								if (165577 - 283559 == -117982)
								{
									this.W2scPTdE0ay = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (111814 - 311203 != -199388)
									{
										this.RenderNPC();
										if (80520 - 174182 != -93661)
										{
											GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)336, (float)724 + this.W2scPTdE0ay * (float)300, (float)836, (float)196), this.jaxcPbhYRil);
											if (65619 - 457519 == -391900)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (136457 - 422759 != -286301)
								{
									this.W2scPTdE0ay = (float)0;
									if (277118 - 48322 == 228796)
									{
										this.RenderNPC();
										if (285736 - 498109 == -212373)
										{
											GUI.BeginGroup(new Rect(0.5f * this.HKqcPpMdMRx - (float)350, (float)724, (float)850, (float)200));
											if (144675 - 97911 != 46765)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.jaxcPbhYRil);
												if (218772 - 239796 == -21024)
												{
													GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Gaza", this.IPbcPdysbPY);
													if (170406 - 189519 != -19112)
													{
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.XOlcPalhJnj, num - 0.5f), this.LNEcPgUNQ9i);
														if (61613 - 551076 == -489463)
														{
															GUI.EndGroup();
															if (252660 - 295510 != -42849)
															{
																if (this.BelcPZOuWh5)
																{
																	break;
																}
																if (290638 - 590335 == -299697)
																{
																	this.BelcPZOuWh5 = true;
																	if (26260 - 584471 != -558210)
																	{
																		if (PlayerPrefs.GetInt("nvoice", 1) == 0)
																		{
																			break;
																		}
																		if (98622 - 16290 != 82333)
																		{
																			if (!this.nNvcPHtLBO5)
																			{
																				break;
																			}
																			if (205883 - 434613 != -228729)
																			{
																				this.audio.PlayOneShot(this.nNvcPHtLBO5);
																				if (68017 - 549400 != -481382)
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
								this.RenderNPC();
								if (62996 - 210140 != -147143)
								{
									int bugcPxkmCrk = this.BUGcPxkmCrk;
									if (88751 - 270893 == -182142)
									{
										if (bugcPxkmCrk == 0)
										{
											if (36617 - 424590 == -387972)
											{
												continue;
											}
											this.TZCcPUW3iaD = new Vector2((float)371, (float)742);
											if (25803 - 570351 == -544547)
											{
												continue;
											}
											this.LrZcPwpNmba = new Vector2((float)371, (float)742);
											if (232399 - 579529 == -347129)
											{
												continue;
											}
										}
										else if (bugcPxkmCrk == 1)
										{
											if (100873 - 44610 != 56263)
											{
												continue;
											}
											this.TZCcPUW3iaD = new Vector2((float)371, (float)742);
											if (192607 - 192394 != 213)
											{
												continue;
											}
											this.LrZcPwpNmba = new Vector2((float)357, (float)375);
											if (134729 - 23231 == 111499)
											{
												continue;
											}
										}
										else if (bugcPxkmCrk == 2)
										{
											if (95523 - 529847 != -434324)
											{
												continue;
											}
											this.TZCcPUW3iaD = new Vector2((float)371, (float)742);
											if (198895 - 532322 != -333427)
											{
												continue;
											}
											this.LrZcPwpNmba = new Vector2((float)663, (float)612);
											if (274238 - 318990 != -44752)
											{
												continue;
											}
										}
										else if (bugcPxkmCrk == 3)
										{
											if (35916 - 505117 != -469201)
											{
												continue;
											}
											this.TZCcPUW3iaD = new Vector2((float)371, (float)742);
											if (244908 - 595719 != -350811)
											{
												continue;
											}
											this.LrZcPwpNmba = new Vector2((float)612, (float)408);
											if (289089 - 454018 == -164928)
											{
												continue;
											}
										}
										else if (bugcPxkmCrk == 4)
										{
											if (105919 - 95423 == 10497)
											{
												continue;
											}
											this.TZCcPUW3iaD = new Vector2((float)371, (float)742);
											if (151408 - 472541 == -321132)
											{
												continue;
											}
											this.LrZcPwpNmba = new Vector2((float)77, (float)569);
											if (153152 - 372240 == -219087)
											{
												continue;
											}
										}
										else if (bugcPxkmCrk == 5)
										{
											if (256474 - 517302 != -260828)
											{
												continue;
											}
											this.TZCcPUW3iaD = new Vector2((float)371, (float)742);
											if (169321 - 355098 != -185777)
											{
												continue;
											}
											this.LrZcPwpNmba = new Vector2((float)726, (float)274);
											if (124641 - 68726 != 55915)
											{
												continue;
											}
										}
										this.mState = eTransportState.select;
										if (10390 - 301438 == -291048)
										{
											this.lS1cPqyDpEF = Time.time;
											if (259790 - 134329 != 125462)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (eTransportState == eTransportState.select)
					{
						if (262227 - 307462 != -45234)
						{
							this.W2scPTdE0ay = (float)0;
							if (135675 - 333357 != -197681)
							{
								int bugcPxkmCrk2 = this.BUGcPxkmCrk;
								if (55929 - 250834 != -194904)
								{
									if (bugcPxkmCrk2 == 0)
									{
										if (42722 - 512521 == -469798)
										{
											continue;
										}
										this.jvacPNvIWLx = "Plain Coloseum";
										if (241908 - 179647 != 62261)
										{
											continue;
										}
										this.LrZcPwpNmba = new Vector2((float)371, (float)742);
										if (289267 - 199088 != 90179)
										{
											continue;
										}
									}
									else if (bugcPxkmCrk2 == 1)
									{
										if (154658 - 484010 == -329351)
										{
											continue;
										}
										this.jvacPNvIWLx = "Snow Camp";
										if (152378 - 480672 == -328293)
										{
											continue;
										}
										this.LrZcPwpNmba = new Vector2((float)357, (float)375);
										if (224272 - 2237 == 222036)
										{
											continue;
										}
									}
									else if (bugcPxkmCrk2 == 2)
									{
										if (282991 - 168359 == 114633)
										{
											continue;
										}
										this.jvacPNvIWLx = "Crystal Beach";
										if (251630 - 462895 != -211265)
										{
											continue;
										}
										this.LrZcPwpNmba = new Vector2((float)663, (float)612);
										if (41168 - 132500 == -91331)
										{
											continue;
										}
									}
									else if (bugcPxkmCrk2 == 3)
									{
										if (99607 - 293797 != -194190)
										{
											continue;
										}
										this.jvacPNvIWLx = "Excavation Camp";
										if (44902 - 336372 == -291469)
										{
											continue;
										}
										this.LrZcPwpNmba = new Vector2((float)612, (float)408);
										if (189920 - 32241 == 157680)
										{
											continue;
										}
									}
									else if (bugcPxkmCrk2 == 4)
									{
										if (242429 - 545468 != -303039)
										{
											continue;
										}
										this.jvacPNvIWLx = "Underground Camp";
										if (108381 - 260843 != -152462)
										{
											continue;
										}
										this.LrZcPwpNmba = new Vector2((float)77, (float)569);
										if (478 - 448485 == -448006)
										{
											continue;
										}
									}
									else if (bugcPxkmCrk2 == 5)
									{
										if (24174 - 188996 != -164822)
										{
											continue;
										}
										this.jvacPNvIWLx = "Forest Camp";
										if (115333 - 296117 == -180783)
										{
											continue;
										}
										this.LrZcPwpNmba = new Vector2((float)726, (float)274);
										if (83220 - 267747 == -184526)
										{
											continue;
										}
									}
									this.TZCcPUW3iaD = Vector2.Lerp(this.TZCcPUW3iaD, this.LrZcPwpNmba, Time.deltaTime);
									if (51583 - 273239 == -221656)
									{
										int num2 = Mathf.FloorToInt((float)-284 * this.TZCcPUW3iaD.x / (float)1024);
										if (106930 - 193232 == -86302)
										{
											int num3 = Mathf.FloorToInt((float)-564 * this.TZCcPUW3iaD.y / (float)1024);
											if (128183 - 481020 == -352837)
											{
												int num4 = (int)(this.LrZcPwpNmba.x + (float)num2);
												if (134035 - 35355 != 98681)
												{
													int num5 = (int)(this.LrZcPwpNmba.y + (float)num3);
													if (169037 - 539130 != -370092)
													{
														GUI.BeginGroup(new Rect(0.5f * this.HKqcPpMdMRx - (float)270, (float)120, (float)740, (float)460));
														if (150934 - 542772 != -391837)
														{
															GUI.DrawTexture(new Rect((float)num2, (float)num3, (float)1024, (float)1024), this.VylcPfUmLDS);
															if (10476 - 548120 != -537643)
															{
																GUI.DrawTexture(new Rect((float)num4, (float)(num5 + 3), (float)170, (float)62), this.VS3cPLgbmgT);
																if (268151 - 246245 == 21906)
																{
																	GUI.Label(new Rect((float)num4, (float)(num5 + 31), (float)170, (float)20), this.jvacPNvIWLx, this.xEqcPEkCDqg);
																	if (131396 - 2662 != 128735)
																	{
																		GUI.EndGroup();
																		if (75011 - 483105 == -408094)
																		{
																			GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)300, (float)100, (float)800, (float)810), this.GbucPMdZT2A);
																			if (141029 - 103603 == 37426)
																			{
																				int bugcPxkmCrk3 = this.BUGcPxkmCrk;
																				if (47335 - 345131 == -297796)
																				{
																					if (bugcPxkmCrk3 == 0)
																					{
																						if (43050 - 96428 == -53377)
																						{
																							continue;
																						}
																					}
																					else if (bugcPxkmCrk3 == 1)
																					{
																						if (108313 - 364827 != -256514)
																						{
																							continue;
																						}
																						if (this.REWcP8vjE4O)
																						{
																							if (273911 - 520586 != -246675)
																							{
																								continue;
																							}
																							GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)213, (float)609, (float)628, (float)256), this.REWcP8vjE4O);
																							if (255803 - 499384 == -243580)
																							{
																								continue;
																							}
																						}
																					}
																					else if (bugcPxkmCrk3 == 2)
																					{
																						if (239652 - 223803 != 15849)
																						{
																							continue;
																						}
																						if (this.n6bcPirSMic)
																						{
																							if (145000 - 415645 == -270644)
																							{
																								continue;
																							}
																							GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)213, (float)609, (float)628, (float)256), this.n6bcPirSMic);
																							if (288537 - 195228 == 93310)
																							{
																								continue;
																							}
																						}
																					}
																					else if (bugcPxkmCrk3 == 3)
																					{
																						if (65823 - 266227 == -200403)
																						{
																							continue;
																						}
																						if (this.FCdcPDe8PpN)
																						{
																							if (295886 - 372697 == -76810)
																							{
																								continue;
																							}
																							GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)213, (float)609, (float)628, (float)256), this.FCdcPDe8PpN);
																							if (109203 - 175988 == -66784)
																							{
																								continue;
																							}
																						}
																					}
																					else if (bugcPxkmCrk3 == 4)
																					{
																						if (87713 - 245352 != -157639)
																						{
																							continue;
																						}
																						if (this.WOucPmE2jaB)
																						{
																							if (43979 - 387626 != -343647)
																							{
																								continue;
																							}
																							GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)213, (float)609, (float)628, (float)256), this.WOucPmE2jaB);
																							if (126472 - 269799 != -143327)
																							{
																								continue;
																							}
																						}
																					}
																					else if (bugcPxkmCrk3 == 5)
																					{
																						if (292491 - 563928 != -271437)
																						{
																							continue;
																						}
																						if (this.YgFcPjkEy8x)
																						{
																							if (64367 - 271172 == -206804)
																							{
																								continue;
																							}
																							GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)213, (float)609, (float)628, (float)256), this.YgFcPjkEy8x);
																							if (202837 - 564178 == -361340)
																							{
																								continue;
																							}
																						}
																					}
																					if (GUI.Button(new Rect(0.5f * this.HKqcPpMdMRx - (float)268, (float)681, (float)86, (float)77), string.Empty, this.DEWcPPmHcNU))
																					{
																						if (281658 - 560697 == -279038)
																						{
																							continue;
																						}
																						this.BUGcPxkmCrk = (int)Mathf.Repeat((float)(this.BUGcPxkmCrk - 1), (float)6);
																						if (835 - 133880 != -133045)
																						{
																							continue;
																						}
																						if (this.BiTcPAWjnFi)
																						{
																							if (20611 - 388425 == -367813)
																							{
																								continue;
																							}
																							this.audio.PlayOneShot(this.BiTcPAWjnFi);
																							if (145336 - 507450 == -362113)
																							{
																								continue;
																							}
																						}
																					}
																					if (GUI.Button(new Rect(0.5f * this.HKqcPpMdMRx + (float)379, (float)681, (float)86, (float)77), string.Empty, this.sQ8cPSfwW0B))
																					{
																						if (259746 - 319032 != -59286)
																						{
																							continue;
																						}
																						this.BUGcPxkmCrk = (int)Mathf.Repeat((float)(this.BUGcPxkmCrk + 1), (float)6);
																						if (258170 - 119123 == 139048)
																						{
																							continue;
																						}
																						if (this.BiTcPAWjnFi)
																						{
																							if (43771 - 323060 == -279288)
																							{
																								continue;
																							}
																							this.audio.PlayOneShot(this.BiTcPAWjnFi);
																							if (205673 - 161102 == 44572)
																							{
																								continue;
																							}
																						}
																					}
																					if (GUI.Button(new Rect(0.5f * this.HKqcPpMdMRx + (float)250, (float)783, (float)116, (float)34), string.Empty, this.HswcP0OiSdj))
																					{
																						if (244547 - 262239 == -17691)
																						{
																							continue;
																						}
																						if (this.BUGcPxkmCrk == 1)
																						{
																							if (209823 - 38573 != 171250)
																							{
																								continue;
																							}
																							if (PlayerData.Gil < 10)
																							{
																								goto IL_1574;
																							}
																							if (246279 - 12981 == 233299)
																							{
																								continue;
																							}
																						}
																						if (this.BUGcPxkmCrk == 2)
																						{
																							if (246562 - 161263 != 85299)
																							{
																								continue;
																							}
																							if (PlayerData.Gil < 20)
																							{
																								goto IL_1574;
																							}
																							if (197972 - 173328 == 24645)
																							{
																								continue;
																							}
																						}
																						if (this.BUGcPxkmCrk == 3)
																						{
																							if (49715 - 599372 == -549656)
																							{
																								continue;
																							}
																							if (PlayerData.Gil < 40)
																							{
																								goto IL_1574;
																							}
																							if (82670 - 36190 == 46481)
																							{
																								continue;
																							}
																						}
																						if (this.BUGcPxkmCrk == 3)
																						{
																							if (110438 - 162506 == -52067)
																							{
																								continue;
																							}
																							if (PlayerData.Gil < 70)
																							{
																								goto IL_1574;
																							}
																							if (256950 - 247163 != 9787)
																							{
																								continue;
																							}
																						}
																						if (this.BUGcPxkmCrk == 4)
																						{
																							if (158810 - 151965 != 6845)
																							{
																								continue;
																							}
																							if (PlayerData.Gil < 100)
																							{
																								if (146219 - 521333 != -375114)
																								{
																									continue;
																								}
																								goto IL_1574;
																							}
																						}
																						if (this.BUGcPxkmCrk != 0)
																						{
																							goto IL_8E2;
																						}
																						if (126941 - 477202 != -350261)
																						{
																							continue;
																						}
																						if (Game.mGameCode != 56)
																						{
																							if (145972 - 315661 != -169689)
																							{
																								continue;
																							}
																							goto IL_8E2;
																						}
																						IL_8C:
																						this.newNoticeBar("You are already there!", (float)1);
																						if (138052 - 119623 != 18430)
																						{
																							if (this.exqcPFyM281)
																							{
																								if (152674 - 356328 != -203654)
																								{
																									continue;
																								}
																								this.audio.PlayOneShot(this.exqcPFyM281);
																								if (209460 - 271587 != -62127)
																								{
																									continue;
																								}
																							}
																							goto IL_145B;
																						}
																						continue;
																						IL_8E2:
																						if (this.BUGcPxkmCrk == 1)
																						{
																							if (115887 - 372397 != -256510)
																							{
																								continue;
																							}
																							if (Game.mGameCode == 32)
																							{
																								goto IL_8C;
																							}
																							if (232558 - 436069 == -203510)
																							{
																								continue;
																							}
																						}
																						if (this.BUGcPxkmCrk == 2)
																						{
																							if (156038 - 511769 == -355730)
																							{
																								continue;
																							}
																							if (Game.mGameCode == 33)
																							{
																								goto IL_8C;
																							}
																							if (102064 - 548766 == -446701)
																							{
																								continue;
																							}
																						}
																						if (this.BUGcPxkmCrk == 3)
																						{
																							if (193584 - 114355 != 79229)
																							{
																								continue;
																							}
																							if (Game.mGameCode == 34)
																							{
																								goto IL_8C;
																							}
																							if (177091 - 439955 != -262864)
																							{
																								continue;
																							}
																						}
																						if (this.BUGcPxkmCrk == 4)
																						{
																							if (137153 - 40557 != 96596)
																							{
																								continue;
																							}
																							if (Game.mGameCode == 35)
																							{
																								goto IL_8C;
																							}
																							if (160065 - 414555 == -254489)
																							{
																								continue;
																							}
																						}
																						if (this.BUGcPxkmCrk == 5)
																						{
																							if (153092 - 441639 != -288547)
																							{
																								continue;
																							}
																							if (Game.mGameCode == 36)
																							{
																								if (117647 - 587195 != -469547)
																								{
																									goto IL_8C;
																								}
																								continue;
																							}
																						}
																						this.mState = eTransportState.takeoff;
																						if (135269 - 102851 != 32418)
																						{
																							continue;
																						}
																						this.lS1cPqyDpEF = Time.time;
																						if (299987 - 591164 == -291176)
																						{
																							continue;
																						}
																						int bugcPxkmCrk4 = this.BUGcPxkmCrk;
																						if (20864 - 17756 != 3108)
																						{
																							continue;
																						}
																						if (bugcPxkmCrk4 == 1)
																						{
																							if (8031 - 285080 == -277048)
																							{
																								continue;
																							}
																							this.Transport(1, 10);
																							if (244651 - 8330 != 236321)
																							{
																								continue;
																							}
																						}
																						else if (bugcPxkmCrk4 == 2)
																						{
																							if (201251 - 218606 == -17354)
																							{
																								continue;
																							}
																							this.Transport(2, 20);
																							if (277371 - 358170 == -80798)
																							{
																								continue;
																							}
																						}
																						else if (bugcPxkmCrk4 == 3)
																						{
																							if (285210 - 361558 != -76348)
																							{
																								continue;
																							}
																							this.Transport(3, 40);
																							if (107343 - 375094 != -267751)
																							{
																								continue;
																							}
																						}
																						else if (bugcPxkmCrk4 == 4)
																						{
																							if (23393 - 305397 == -282003)
																							{
																								continue;
																							}
																							this.Transport(4, 70);
																							if (251415 - 280334 == -28918)
																							{
																								continue;
																							}
																						}
																						else if (bugcPxkmCrk4 == 5)
																						{
																							if (20538 - 346443 != -325905)
																							{
																								continue;
																							}
																							this.Transport(5, 100);
																							if (203438 - 320926 == -117487)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							this.Transport(0, 0);
																							if (294320 - 356538 != -62218)
																							{
																								continue;
																							}
																						}
																						if (!this.exqcPFyM281)
																						{
																							goto IL_145B;
																						}
																						if (80128 - 312036 == -231907)
																						{
																							continue;
																						}
																						this.audio.PlayOneShot(this.exqcPFyM281);
																						if (202011 - 552333 != -350322)
																						{
																							continue;
																						}
																						goto IL_145B;
																						IL_1574:
																						this.newNoticeBar("Not enough gil", (float)1);
																						if (107996 - 41953 == 66044)
																						{
																							continue;
																						}
																						if (this.exqcPFyM281)
																						{
																							if (130382 - 268713 != -138331)
																							{
																								continue;
																							}
																							this.audio.PlayOneShot(this.exqcPFyM281);
																							if (278070 - 355881 == -77810)
																							{
																								continue;
																							}
																						}
																					}
																					IL_145B:
																					if (GUI.Button(new Rect(0.5f * this.HKqcPpMdMRx - (float)296, (float)106, (float)57, (float)52), string.Empty, this.r1ocPB0l4gq))
																					{
																						goto IL_EF3;
																					}
																					if (100269 - 580382 == -480112)
																					{
																						continue;
																					}
																					if (Input.GetKeyDown("escape"))
																					{
																						if (105385 - 331585 != -226199)
																						{
																							goto IL_EF3;
																						}
																						continue;
																					}
																					IL_241:
																					this.RenderNoticeBar();
																					if (190909 - 397286 == -206376)
																					{
																						continue;
																					}
																					this.RenderNPC();
																					if (68176 - 519342 != -451165)
																					{
																						break;
																					}
																					continue;
																					IL_EF3:
																					this.mState = eTransportState.close;
																					if (130788 - 209356 != -78567)
																					{
																						this.lS1cPqyDpEF = Time.time;
																						if (103186 - 560168 != -456981)
																						{
																							if (!this.BJLcPkbkfk9)
																							{
																								goto IL_241;
																							}
																							if (265767 - 487648 != -221880)
																							{
																								this.audio.PlayOneShot(this.BJLcPkbkfk9);
																								if (184803 - 117357 != 67447)
																								{
																									goto IL_241;
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					else if (eTransportState == eTransportState.takeoff)
					{
						if (83322 - 55190 != 28133)
						{
							if (num <= (float)2)
							{
								if (39906 - 426188 != -386281)
								{
									this.RenderNPC();
									if (43063 - 245439 == -202376)
									{
										if (this.ncgcPYpftpa)
										{
											if (201213 - 272315 == -71101)
											{
												continue;
											}
											this.ncgcPYpftpa.animation.CrossFade("salute", 0.2f);
											if (94828 - 240370 != -145542)
											{
												continue;
											}
										}
										GUI.BeginGroup(new Rect(0.5f * this.HKqcPpMdMRx - (float)350, (float)724, (float)850, (float)200));
										if (165402 - 303897 == -138495)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.jaxcPbhYRil);
											if (128124 - 463841 == -335717)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Gaza", this.IPbcPdysbPY);
												if (57909 - 573418 != -515508)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.KutcP4PB1Da, num), this.LNEcPgUNQ9i);
													if (298990 - 369966 != -70975)
													{
														GUI.EndGroup();
														if (65116 - 492654 != -427537)
														{
															if (this.xQGcPCBPMCk)
															{
																break;
															}
															if (165870 - 144193 == 21677)
															{
																this.xQGcPCBPMCk = true;
																if (124141 - 420354 != -296212)
																{
																	if (PlayerPrefs.GetInt("nvoice", 1) == 0)
																	{
																		break;
																	}
																	if (65589 - 92808 == -27219)
																	{
																		if (!this.jjCcP7UKCUq)
																		{
																			break;
																		}
																		if (91639 - 435727 != -344087)
																		{
																			this.audio.PlayOneShot(this.jjCcP7UKCUq);
																			if (4661 - 515470 != -510808)
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
							else if (num <= 2.5f)
							{
								if (142042 - 402650 != -260607)
								{
									this.W2scPTdE0ay = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (241360 - 59989 != 181372)
									{
										this.RenderNPC();
										if (227682 - 375562 == -147880)
										{
											break;
										}
									}
								}
							}
							else if (num < (float)3)
							{
								if (169562 - 69252 != 100311)
								{
									this.SendMessage("fadeOut");
									if (242467 - 494129 != -251661)
									{
										if (!this.tLKcP9lh4em)
										{
											break;
										}
										if (86325 - 435524 == -349199)
										{
											if (this.tbWcPy0HC8E)
											{
												break;
											}
											if (287029 - 555988 == -268959)
											{
												this.tbWcPy0HC8E = true;
												if (205999 - 94136 == 111863)
												{
													this.audio.PlayOneShot(this.tLKcP9lh4em);
													if (193830 - 158791 != 35040)
													{
														break;
													}
												}
											}
										}
									}
								}
							}
							else if (num < (float)4)
							{
								if (290727 - 251818 != 38910)
								{
									float a = num - (float)3;
									if (282228 - 436420 != -154191)
									{
										Color color = GUI.color;
										if (69201 - 234697 != -165495)
										{
											color.a = a;
											if (155256 - 505586 != -350329)
											{
												if (50515 - 178631 == -128116)
												{
													GUI.color = color;
													if (157828 - 278006 != -120177)
													{
														if (187173 - 246171 == -58998)
														{
															GUI.DrawTexture(new Rect((float)0, (float)0, this.HKqcPpMdMRx, (float)1024), this.f2vcPu55R4o);
															if (50963 - 265713 == -214750)
															{
																GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)720, (float)0, (float)1440, (float)1024), this.QaUcPWbAwLC);
																if (285277 - 113909 != 171369)
																{
																	float a2 = 1f;
																	if (33059 - 338876 == -305817)
																	{
																		Color color2 = GUI.color;
																		if (199441 - 59190 != 140252)
																		{
																			color2.a = a2;
																			if (5521 - 99040 != -93518 && 24448 - 378173 != -353724)
																			{
																				Color color3 = GUI.color = color2;
																				if (75822 - 419474 == -343652)
																				{
																					if (218792 - 241777 == -22985)
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
							else if (num < (float)8)
							{
								if (37411 - 139498 != -102086)
								{
									GUI.DrawTexture(new Rect((float)0, (float)0, this.HKqcPpMdMRx, (float)1024), this.f2vcPu55R4o);
									if (260125 - 389156 != -129030)
									{
										GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)720, (float)0, (float)1440, (float)1024), this.QaUcPWbAwLC);
										if (257832 - 478021 == -220189)
										{
											break;
										}
									}
								}
							}
							else if (num < 8.5f)
							{
								if (139108 - 320913 != -181804)
								{
									GUI.DrawTexture(new Rect((float)0, (float)0, this.HKqcPpMdMRx, (float)1024), this.f2vcPu55R4o);
									if (249699 - 14615 == 235084)
									{
										float a3 = (float)2 * (8.5f - num);
										if (133839 - 139485 == -5646)
										{
											Color color4 = GUI.color;
											if (249895 - 24573 == 225322)
											{
												float num6 = color4.a = a3;
												if (203133 - 324720 != -121586 && 240502 - 511367 != -270864)
												{
													GUI.color = color4;
													if (76209 - 206341 != -130131)
													{
														if (69781 - 139072 == -69291)
														{
															GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)720, (float)0, (float)1440, (float)1024), this.QaUcPWbAwLC);
															if (166168 - 504342 != -338173)
															{
																float a4 = 1f;
																if (229259 - 112355 != 116905)
																{
																	Color color5 = GUI.color;
																	if (28962 - 483881 == -454919)
																	{
																		color5.a = a4;
																		if (27104 - 434322 != -407217)
																		{
																			if (34574 - 7112 == 27462)
																			{
																				Color color6 = GUI.color = color5;
																				if (6466 - 74280 == -67814)
																				{
																					if (122834 - 172707 != -49872)
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
							else
							{
								GUI.DrawTexture(new Rect((float)0, (float)0, this.HKqcPpMdMRx, (float)1024), this.f2vcPu55R4o);
								if (199254 - 184145 == 15109)
								{
									Chat.ClearChatMode(eChatMode.mission);
									if (136856 - 525615 == -388759)
									{
										this.mState = eTransportState.disabled;
										if (189719 - 338841 != -149121)
										{
											this.enabled = false;
											if (167517 - 20909 != 146609)
											{
												int bugcPxkmCrk5 = this.BUGcPxkmCrk;
												if (169243 - 324055 != -154811)
												{
													if (bugcPxkmCrk5 == 0)
													{
														if (106639 - 347831 != -241192)
														{
															continue;
														}
														Game.mNextGameCode = 56;
														if (67640 - 369600 == -301959)
														{
															continue;
														}
														Game.mNextGameId = 506;
														if (130562 - 347291 == -216728)
														{
															continue;
														}
													}
													else if (bugcPxkmCrk5 == 1)
													{
														if (3955 - 82369 != -78414)
														{
															continue;
														}
														Game.mNextGameCode = 32;
														if (27987 - 48915 != -20928)
														{
															continue;
														}
														Game.mNextGameId = 302;
														if (262118 - 508656 == -246537)
														{
															continue;
														}
													}
													else if (bugcPxkmCrk5 == 2)
													{
														if (138941 - 481158 == -342216)
														{
															continue;
														}
														Game.mNextGameCode = 33;
														if (81874 - 416609 == -334734)
														{
															continue;
														}
														Game.mNextGameId = 303;
														if (167554 - 86764 == 80791)
														{
															continue;
														}
													}
													else if (bugcPxkmCrk5 == 3)
													{
														if (34308 - 160465 != -126157)
														{
															continue;
														}
														Game.mNextGameCode = 34;
														if (186523 - 431209 == -244685)
														{
															continue;
														}
														Game.mNextGameId = 304;
														if (133970 - 432310 == -298339)
														{
															continue;
														}
													}
													else if (bugcPxkmCrk5 == 4)
													{
														if (197252 - 175816 != 21436)
														{
															continue;
														}
														Game.mNextGameCode = 35;
														if (254417 - 532861 == -278443)
														{
															continue;
														}
														Game.mNextGameId = 305;
														if (141031 - 270578 != -129547)
														{
															continue;
														}
													}
													else if (bugcPxkmCrk5 == 5)
													{
														if (24283 - 397529 == -373245)
														{
															continue;
														}
														Game.mNextGameCode = 36;
														if (86728 - 357951 == -271222)
														{
															continue;
														}
														Game.mNextGameId = 306;
														if (237180 - 338581 != -101401)
														{
															continue;
														}
													}
													this.SendMessage("LeaveTown");
													if (13518 - 540745 == -527227)
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
					else if (eTransportState == eTransportState.close)
					{
						if (54706 - 253315 == -198609)
						{
							if (num <= (float)2)
							{
								if (129554 - 123433 != 6122)
								{
									this.RenderNPC();
									if (289704 - 573636 == -283932)
									{
										GUI.BeginGroup(new Rect(0.5f * this.HKqcPpMdMRx - (float)350, (float)724, (float)850, (float)200));
										if (235781 - 319310 == -83529)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.jaxcPbhYRil);
											if (156259 - 504298 != -348038)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Gaza", this.IPbcPdysbPY);
												if (62486 - 24936 == 37550)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.aSlcPsHrkP3, num), this.LNEcPgUNQ9i);
													if (120438 - 453652 == -333214)
													{
														GUI.EndGroup();
														if (209331 - 535812 == -326481)
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
								if (19650 - 399977 != -380326)
								{
									this.W2scPTdE0ay = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (190501 - 353734 == -163233)
									{
										this.RenderNPC();
										if (167862 - 191681 != -23818)
										{
											break;
										}
									}
								}
							}
							else
							{
								if (this.ncgcPYpftpa)
								{
									if (248059 - 403281 != -155222)
									{
										continue;
									}
									this.ncgcPYpftpa.animation.CrossFade("root", 0.2f);
									if (167916 - 128700 != 39216)
									{
										continue;
									}
								}
								Game.mGameState = eGameState.Normal;
								if (82260 - 357975 != -275714)
								{
									GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
									if (66499 - 560668 == -494169)
									{
										gameGui.enabled = true;
										if (281925 - 112902 == 169023)
										{
											this.mState = eTransportState.disabled;
											if (221631 - 491634 != -270002)
											{
												this.enabled = false;
												if (241717 - 267623 == -25906)
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
					else
					{
						if (eTransportState != eTransportState.disabled)
						{
							break;
						}
						if (125587 - 436226 == -310639)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006335 RID: 25397 RVA: 0x00DC557C File Offset: 0x00DC377C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNoticeBar()
	{
		if (208036 - 489503 != -281466)
		{
		}
		for (;;)
		{
			this.f3kcPVwJ4b5 = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (283857 - 265806 != 18052)
			{
				this.yhZcPhM5SBJ = new GUIStyle();
				if (218502 - 313800 != -95297)
				{
					this.yhZcPhM5SBJ.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (117152 - 294287 == -177135)
					{
						this.yhZcPhM5SBJ.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (194821 - 15402 == 179419)
						{
							this.yhZcPhM5SBJ.alignment = TextAnchor.MiddleCenter;
							if (41565 - 295322 == -253757)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006336 RID: 25398 RVA: 0x00DC56B8 File Offset: 0x00DC38B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newNoticeBar(string s, float t)
	{
		this.CcKcPzEjUZY = s;
		this.B2ScPKjpt1R = Time.time + t;
	}

	// Token: 0x06006337 RID: 25399 RVA: 0x00DC56D0 File Offset: 0x00DC38D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar()
	{
		if (161053 - 372247 != -211194)
		{
		}
		while (this.B2ScPKjpt1R > Time.time)
		{
			if (294557 - 14690 == 279867)
			{
				GUI.DrawTexture(new Rect(0.5f * this.HKqcPpMdMRx - (float)137, (float)570, (float)475, (float)102), this.f3kcPVwJ4b5);
				if (49768 - 18814 != 30955)
				{
					GUI.Label(new Rect(0.5f * this.HKqcPpMdMRx - (float)92, (float)600, (float)400, (float)40), this.CcKcPzEjUZY, this.yhZcPhM5SBJ);
					if (139395 - 368551 != -229155)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006338 RID: 25400 RVA: 0x00DC57D0 File Offset: 0x00DC39D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Transport(int nGamdCode, int nGil)
	{
		if (65821 - 447769 != -381948)
		{
		}
		for (;;)
		{
			PlayerData.Gil -= nGil;
			if (44911 - 164434 != -119522)
			{
				Hashtable hashtable = new Hashtable();
				if (178874 - 97836 == 81038)
				{
					hashtable.Add(43, PlayerData.UID);
					if (14183 - 322852 != -308668)
					{
						hashtable.Add(5, PhotonClient.cInt16(nGamdCode));
						if (12111 - 496513 != -484401)
						{
							hashtable.Add(48, nGil);
							if (277974 - 174388 != 103587)
							{
								PhotonClient.Connection.OpCustom(220, hashtable, true);
								if (164924 - 455560 != -290635)
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

	// Token: 0x06006339 RID: 25401 RVA: 0x00DC590C File Offset: 0x00DC3B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600633A RID: 25402 RVA: 0x00DC5910 File Offset: 0x00DC3B10
	internal static bool fSDegDpkLEL4KT1ocrZN()
	{
		return true;
	}

	// Token: 0x0600633B RID: 25403 RVA: 0x00DC5914 File Offset: 0x00DC3B14
	internal static bool QXQoUSpkOtandclGJrvX()
	{
		return false;
	}

	// Token: 0x040072D8 RID: 29400
	public int posx;

	// Token: 0x040072D9 RID: 29401
	public int posy;

	// Token: 0x040072DA RID: 29402
	public int posz;

	// Token: 0x040072DB RID: 29403
	public int posa;

	// Token: 0x040072DC RID: 29404
	public int posb;

	// Token: 0x040072DD RID: 29405
	public int divx;

	// Token: 0x040072DE RID: 29406
	public int divy;

	// Token: 0x040072DF RID: 29407
	public int divz;

	// Token: 0x040072E0 RID: 29408
	public int diva;

	// Token: 0x040072E1 RID: 29409
	public int divb;

	// Token: 0x040072E2 RID: 29410
	public eTransportState mState;

	// Token: 0x040072E3 RID: 29411
	private float lS1cPqyDpEF;

	// Token: 0x040072E4 RID: 29412
	private float HKqcPpMdMRx;

	// Token: 0x040072E5 RID: 29413
	private float sIgcPRm9xft;

	// Token: 0x040072E6 RID: 29414
	private MissionClass p74cPrnBljt;

	// Token: 0x040072E7 RID: 29415
	private int BUGcPxkmCrk;

	// Token: 0x040072E8 RID: 29416
	private float W2scPTdE0ay;

	// Token: 0x040072E9 RID: 29417
	private GameObject ncgcPYpftpa;

	// Token: 0x040072EA RID: 29418
	private Texture S83cP3p4otN;

	// Token: 0x040072EB RID: 29419
	private Texture jaxcPbhYRil;

	// Token: 0x040072EC RID: 29420
	private GUIStyle IPbcPdysbPY;

	// Token: 0x040072ED RID: 29421
	private GUIStyle LNEcPgUNQ9i;

	// Token: 0x040072EE RID: 29422
	private string XOlcPalhJnj;

	// Token: 0x040072EF RID: 29423
	private string KutcP4PB1Da;

	// Token: 0x040072F0 RID: 29424
	private string aSlcPsHrkP3;

	// Token: 0x040072F1 RID: 29425
	private AudioClip nNvcPHtLBO5;

	// Token: 0x040072F2 RID: 29426
	private AudioClip jjCcP7UKCUq;

	// Token: 0x040072F3 RID: 29427
	private bool BelcPZOuWh5;

	// Token: 0x040072F4 RID: 29428
	private bool xQGcPCBPMCk;

	// Token: 0x040072F5 RID: 29429
	private Texture GbucPMdZT2A;

	// Token: 0x040072F6 RID: 29430
	private Texture VylcPfUmLDS;

	// Token: 0x040072F7 RID: 29431
	private Texture VS3cPLgbmgT;

	// Token: 0x040072F8 RID: 29432
	private Vector2 LrZcPwpNmba;

	// Token: 0x040072F9 RID: 29433
	private Vector2 TZCcPUW3iaD;

	// Token: 0x040072FA RID: 29434
	private string jvacPNvIWLx;

	// Token: 0x040072FB RID: 29435
	private GUIStyle xEqcPEkCDqg;

	// Token: 0x040072FC RID: 29436
	private GUIStyle DEWcPPmHcNU;

	// Token: 0x040072FD RID: 29437
	private GUIStyle sQ8cPSfwW0B;

	// Token: 0x040072FE RID: 29438
	private GUIStyle r1ocPB0l4gq;

	// Token: 0x040072FF RID: 29439
	private GUIStyle HswcP0OiSdj;

	// Token: 0x04007300 RID: 29440
	private Texture REWcP8vjE4O;

	// Token: 0x04007301 RID: 29441
	private Texture n6bcPirSMic;

	// Token: 0x04007302 RID: 29442
	private Texture FCdcPDe8PpN;

	// Token: 0x04007303 RID: 29443
	private Texture WOucPmE2jaB;

	// Token: 0x04007304 RID: 29444
	private Texture YgFcPjkEy8x;

	// Token: 0x04007305 RID: 29445
	private AudioClip oRMcPonQETM;

	// Token: 0x04007306 RID: 29446
	private AudioClip BJLcPkbkfk9;

	// Token: 0x04007307 RID: 29447
	private AudioClip exqcPFyM281;

	// Token: 0x04007308 RID: 29448
	private AudioClip BiTcPAWjnFi;

	// Token: 0x04007309 RID: 29449
	private AudioClip tLKcP9lh4em;

	// Token: 0x0400730A RID: 29450
	private Texture QaUcPWbAwLC;

	// Token: 0x0400730B RID: 29451
	private Texture f2vcPu55R4o;

	// Token: 0x0400730C RID: 29452
	private bool tbWcPy0HC8E;

	// Token: 0x0400730D RID: 29453
	private Texture f3kcPVwJ4b5;

	// Token: 0x0400730E RID: 29454
	private GUIStyle yhZcPhM5SBJ;

	// Token: 0x0400730F RID: 29455
	private float B2ScPKjpt1R;

	// Token: 0x04007310 RID: 29456
	private string CcKcPzEjUZY;
}
