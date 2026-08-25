using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200106B RID: 4203
[Serializable]
public class LoadingGui : MonoBehaviour
{
	// Token: 0x06006168 RID: 24936 RVA: 0x00D59694 File Offset: 0x00D57894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LoadingGui()
	{
		if (269716 - 547271 != -277554)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (201417 - 33553 != 167865)
			{
				base..ctor();
				if (118747 - 484899 == -366152)
				{
					this.R6lc4DEf58Q = 0.5f;
					if (53368 - 554568 != -501199)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006169 RID: 24937 RVA: 0x00D59730 File Offset: 0x00D57930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (25437 - 358457 != -333019)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (273743 - 214546 != 59197)
				{
					continue;
				}
				this.enabled = false;
				if (214115 - 372368 == -158252)
				{
					continue;
				}
			}
			this.Qwpc4maX9OI = (Texture)Resources.Load("GameGui/Loading/fadeWhite", typeof(Texture));
			if (8547 - 9004 == -457)
			{
				this.dIhc4jrkUDW = (Texture)Resources.Load("GameGui/Loading/fadeBlack", typeof(Texture));
				if (297741 - 382263 == -84522)
				{
					this.s4cc48HDdxY = eLoadingState.init;
					if (224605 - 497702 != -273096)
					{
						this.rJxc4kGMUKA = new GUIStyle();
						if (185079 - 255243 == -70164)
						{
							this.rJxc4kGMUKA.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
							if (117067 - 316753 != -199685)
							{
								this.rJxc4kGMUKA.normal.textColor = new Color(0.8f, 0.8f, 0.8f, (float)1);
								if (77530 - 36407 == 41123)
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

	// Token: 0x0600616A RID: 24938 RVA: 0x00D598E4 File Offset: 0x00D57AE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.s4cc48HDdxY = eLoadingState.blank;
	}

	// Token: 0x0600616B RID: 24939 RVA: 0x00D598F0 File Offset: 0x00D57AF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (164072 - 83653 != 80420)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)1, (float)1, (float)1));
			if (7660 - 363485 != -355824)
			{
				GUI.depth = 2;
				if (275605 - 389106 != -113500)
				{
					float num = (float)Screen.height / 768f;
					if (50366 - 427968 == -377602)
					{
						eLoadingState eLoadingState = this.s4cc48HDdxY;
						if (204355 - 190569 != 13787)
						{
							if (eLoadingState == eLoadingState.blank)
							{
								if (158195 - 131773 != 26423)
								{
									GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
									if (135499 - 15081 != 120419)
									{
										break;
									}
								}
							}
							else if (eLoadingState == eLoadingState.fadeIn)
							{
								if (83506 - 122184 == -38678)
								{
									if (Time.time >= this.XiLc4ibyOt7 + this.R6lc4DEf58Q)
									{
										if (82133 - 41710 != 40424)
										{
											this.s4cc48HDdxY = eLoadingState.disabled;
											if (135296 - 315032 != -179735)
											{
												break;
											}
										}
									}
									else
									{
										float a = Mathf.Lerp((float)1, (float)0, (Time.time - this.XiLc4ibyOt7) / this.R6lc4DEf58Q);
										if (279529 - 143588 == 135941)
										{
											Color color = GUI.color;
											if (35714 - 417924 == -382210)
											{
												color.a = a;
												if (59541 - 531022 == -471481)
												{
													if (184432 - 503732 == -319300)
													{
														GUI.color = color;
														if (166201 - 73817 == 92384)
														{
															if (121128 - 268138 == -147010)
															{
																GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																if (226891 - 186129 == 40762)
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
							else if (eLoadingState == eLoadingState.fadeOut)
							{
								if (176583 - 440844 != -264260)
								{
									float a2 = Mathf.Lerp((float)0, (float)1, (Time.time - this.XiLc4ibyOt7) / this.R6lc4DEf58Q);
									if (265846 - 28769 == 237077)
									{
										Color color2 = GUI.color;
										if (280657 - 497446 != -216788)
										{
											color2.a = a2;
											if (163744 - 337566 == -173822)
											{
												if (31548 - 163356 == -131808)
												{
													Color color3 = GUI.color = color2;
													if (212877 - 565687 == -352810)
													{
														if (258772 - 204049 != 54724)
														{
															GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
															if (180883 - 476299 != -295415)
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
							else if (eLoadingState == eLoadingState.blackIn)
							{
								if (208237 - 596905 == -388668)
								{
									if (Time.time >= this.XiLc4ibyOt7 + this.R6lc4DEf58Q)
									{
										if (236979 - 551351 == -314372)
										{
											this.s4cc48HDdxY = eLoadingState.disabled;
											if (20536 - 46802 != -26265)
											{
												break;
											}
										}
									}
									else
									{
										float a3 = Mathf.Lerp((float)1, (float)0, (Time.time - this.XiLc4ibyOt7) / this.R6lc4DEf58Q);
										if (43692 - 12428 != 31265)
										{
											Color color4 = GUI.color;
											if (126180 - 26151 == 100029)
											{
												color4.a = a3;
												if (51340 - 84967 != -33626 && 141559 - 110652 != 30908)
												{
													GUI.color = color4;
													if (74383 - 91261 != -16877)
													{
														if (81535 - 412728 == -331193)
														{
															GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.dIhc4jrkUDW);
															if (61511 - 558526 != -497014)
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
							else if (eLoadingState == eLoadingState.blackOut)
							{
								if (280333 - 115006 == 165327)
								{
									float a4 = Mathf.Lerp((float)0, (float)1, (Time.time - this.XiLc4ibyOt7) / this.R6lc4DEf58Q);
									if (37908 - 271432 == -233524)
									{
										Color color5 = GUI.color;
										if (33114 - 580080 == -546966)
										{
											float num2 = color5.a = a4;
											if (244358 - 517627 == -273269)
											{
												if (242090 - 133770 != 108321)
												{
													GUI.color = color5;
													if (172849 - 576991 != -404141 && 87427 - 80021 != 7407)
													{
														GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.dIhc4jrkUDW);
														if (153920 - 73723 == 80197)
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
							else if (eLoadingState == eLoadingState.splashIn)
							{
								if (30452 - 206289 != -175836)
								{
									if (Time.time - this.XiLc4ibyOt7 < this.R6lc4DEf58Q)
									{
										if (194172 - 222819 == -28647)
										{
											float a5 = Mathf.Lerp((float)1, (float)0, (Time.time - this.XiLc4ibyOt7) / this.R6lc4DEf58Q);
											if (240693 - 534441 != -293747)
											{
												Color color6 = GUI.color;
												if (220374 - 195813 != 24562)
												{
													float num3 = color6.a = a5;
													if (238422 - 62666 == 175756)
													{
														if (131280 - 64695 != 66586)
														{
															GUI.color = color6;
															if (137796 - 112717 == 25079)
															{
																if (107013 - 371334 == -264321)
																{
																	GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																	if (243186 - 71905 != 171282)
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
									else if (Time.time - this.XiLc4ibyOt7 < (float)1 + this.R6lc4DEf58Q)
									{
										if (164402 - 237544 == -73142)
										{
											float a6 = 1f;
											if (251072 - 22675 != 228398)
											{
												Color color7 = GUI.color;
												if (69652 - 38951 == 30701)
												{
													color7.a = a6;
													if (5761 - 150795 != -145033)
													{
														if (176410 - 466382 == -289972)
														{
															Color color8 = GUI.color = color7;
															if (103721 - 310475 != -206753)
															{
																if (289247 - 443500 == -154253)
																{
																	GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																	if (192987 - 478098 == -285111)
																	{
																		float a7 = Mathf.Lerp((float)0, (float)1, Time.time - this.XiLc4ibyOt7 - (float)1 - this.R6lc4DEf58Q);
																		if (5371 - 506039 == -500668)
																		{
																			Color color9 = GUI.color;
																			if (52100 - 308856 == -256756)
																			{
																				float num4 = color9.a = a7;
																				if (132379 - 581104 != -448724 && 1881 - 462029 != -460147)
																				{
																					GUI.color = color9;
																					if (87138 - 366432 == -279294)
																					{
																						if (291623 - 253737 != 37887)
																						{
																							if (!this.lDPc4o6QUNa)
																							{
																								break;
																							}
																							if (95726 - 282932 != -187205)
																							{
																								GUI.DrawTexture(new Rect(0.5f * ((float)Screen.width - num * (float)this.lDPc4o6QUNa.width), 0.5f * ((float)Screen.height - num * (float)this.lDPc4o6QUNa.height), num * (float)this.lDPc4o6QUNa.width, num * (float)this.lDPc4o6QUNa.height), this.lDPc4o6QUNa);
																								if (252445 - 588544 != -336098)
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
									else if (Time.time - this.XiLc4ibyOt7 < (float)4 + this.R6lc4DEf58Q)
									{
										if (97836 - 507922 != -410085)
										{
											float a8 = 1f;
											if (287464 - 152485 == 134979)
											{
												Color color10 = GUI.color;
												if (246372 - 177694 != 68679)
												{
													color10.a = a8;
													if (37833 - 48437 != -10603)
													{
														if (143815 - 69828 == 73987)
														{
															GUI.color = color10;
															if (129569 - 493687 != -364117)
															{
																if (175309 - 291271 == -115962)
																{
																	GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																	if (290590 - 387041 == -96451)
																	{
																		if (!this.lDPc4o6QUNa)
																		{
																			break;
																		}
																		if (89195 - 283946 == -194751)
																		{
																			GUI.DrawTexture(new Rect(0.5f * ((float)Screen.width - num * (float)this.lDPc4o6QUNa.width), 0.5f * ((float)Screen.height - num * (float)this.lDPc4o6QUNa.height), num * (float)this.lDPc4o6QUNa.width, num * (float)this.lDPc4o6QUNa.height), this.lDPc4o6QUNa);
																			if (231511 - 225416 == 6095)
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
									else if (Time.time - this.XiLc4ibyOt7 < (float)5 + this.R6lc4DEf58Q)
									{
										if (257286 - 250655 != 6632)
										{
											float a9 = 1f;
											if (171551 - 111827 != 59725)
											{
												Color color11 = GUI.color;
												if (95588 - 520148 == -424560)
												{
													float num5 = color11.a = a9;
													if (110695 - 306992 != -196296 && 3282 - 566198 != -562915)
													{
														GUI.color = color11;
														if (241506 - 388593 == -147087)
														{
															if (122032 - 20834 == 101198)
															{
																GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																if (283185 - 326493 == -43308)
																{
																	float a10 = Mathf.Lerp((float)1, (float)0, Time.time - this.XiLc4ibyOt7 - (float)5 - this.R6lc4DEf58Q);
																	if (288389 - 121143 == 167246)
																	{
																		Color color12 = GUI.color;
																		if (293504 - 416587 == -123083)
																		{
																			color12.a = a10;
																			if (102465 - 12686 != 89780 && 141193 - 191910 != -50716)
																			{
																				GUI.color = color12;
																				if (197791 - 117082 != 80710 && 96203 - 440061 != -343857)
																				{
																					if (!this.lDPc4o6QUNa)
																					{
																						break;
																					}
																					if (255976 - 127198 != 128779)
																					{
																						GUI.DrawTexture(new Rect(0.5f * ((float)Screen.width - num * (float)this.lDPc4o6QUNa.width), 0.5f * ((float)Screen.height - num * (float)this.lDPc4o6QUNa.height), num * (float)this.lDPc4o6QUNa.width, num * (float)this.lDPc4o6QUNa.height), this.lDPc4o6QUNa);
																						if (234525 - 234719 == -194)
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
										float a11 = 1f;
										if (87396 - 312050 != -224653)
										{
											Color color13 = GUI.color;
											if (204972 - 286049 == -81077)
											{
												color13.a = a11;
												if (172160 - 289866 == -117706)
												{
													if (60736 - 541601 != -480864)
													{
														GUI.color = color13;
														if (139602 - 535427 == -395825)
														{
															if (80489 - 128405 == -47916)
															{
																GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																if (144523 - 166857 != -22333)
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
							else if (eLoadingState == eLoadingState.splashOut)
							{
								if (264758 - 18237 != 246522)
								{
									if (Time.time - this.XiLc4ibyOt7 < this.R6lc4DEf58Q)
									{
										if (225195 - 173749 == 51446)
										{
											float a12 = Mathf.Lerp((float)0, (float)1, (Time.time - this.XiLc4ibyOt7) / this.R6lc4DEf58Q);
											if (127143 - 587260 != -460116)
											{
												Color color14 = GUI.color;
												if (269375 - 299681 == -30306)
												{
													color14.a = a12;
													if (176744 - 367993 != -191248 && 76289 - 163191 != -86901)
													{
														Color color15 = GUI.color = color14;
														if (37874 - 405332 == -367458)
														{
															if (6384 - 394617 == -388233)
															{
																GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																if (20859 - 303805 == -282946)
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
									else if (Time.time - this.XiLc4ibyOt7 < (float)1 + this.R6lc4DEf58Q)
									{
										if (8682 - 267056 == -258374)
										{
											float a13 = 1f;
											if (149265 - 145855 != 3411)
											{
												Color color16 = GUI.color;
												if (205298 - 103747 == 101551)
												{
													color16.a = a13;
													if (96583 - 294237 == -197654)
													{
														if (284436 - 579423 != -294986)
														{
															Color color17 = GUI.color = color16;
															if (222782 - 332044 == -109262)
															{
																if (4799 - 242493 == -237694)
																{
																	GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																	if (87772 - 326825 == -239053)
																	{
																		float a14 = Mathf.Lerp((float)0, (float)1, Time.time - this.XiLc4ibyOt7 - this.R6lc4DEf58Q);
																		if (160969 - 570169 != -409199)
																		{
																			Color color18 = GUI.color;
																			if (213516 - 516349 == -302833)
																			{
																				float num6 = color18.a = a14;
																				if (153026 - 411298 != -258271 && 72736 - 48351 != 24386)
																				{
																					Color color19 = GUI.color = color18;
																					if (46759 - 350129 != -303369)
																					{
																						if (200698 - 438806 == -238108)
																						{
																							if (!this.lDPc4o6QUNa)
																							{
																								break;
																							}
																							if (72541 - 332097 != -259555)
																							{
																								GUI.DrawTexture(new Rect(0.5f * ((float)Screen.width - num * (float)this.lDPc4o6QUNa.width), 0.5f * ((float)Screen.height - num * (float)this.lDPc4o6QUNa.height), num * (float)this.lDPc4o6QUNa.width, num * (float)this.lDPc4o6QUNa.height), this.lDPc4o6QUNa);
																								if (273185 - 533876 == -260691)
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
									else if (Time.time - this.XiLc4ibyOt7 < (float)4 + this.R6lc4DEf58Q)
									{
										if (29294 - 3177 == 26117)
										{
											float a15 = 1f;
											if (63413 - 496041 == -432628)
											{
												Color color20 = GUI.color;
												if (185824 - 184815 != 1010)
												{
													float num7 = color20.a = a15;
													if (82170 - 170977 == -88807)
													{
														if (194803 - 44692 == 150111)
														{
															Color color21 = GUI.color = color20;
															if (184279 - 526197 == -341918)
															{
																if (140572 - 558802 != -418229)
																{
																	GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																	if (158071 - 197095 != -39023)
																	{
																		if (!this.lDPc4o6QUNa)
																		{
																			break;
																		}
																		if (73542 - 383590 == -310048)
																		{
																			GUI.DrawTexture(new Rect(0.5f * ((float)Screen.width - num * (float)this.lDPc4o6QUNa.width), 0.5f * ((float)Screen.height - num * (float)this.lDPc4o6QUNa.height), num * (float)this.lDPc4o6QUNa.width, num * (float)this.lDPc4o6QUNa.height), this.lDPc4o6QUNa);
																			if (12794 - 135663 != -122868)
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
									else if (Time.time - this.XiLc4ibyOt7 < (float)5 + this.R6lc4DEf58Q)
									{
										if (188013 - 594337 == -406324)
										{
											float a16 = 1f;
											if (185784 - 448895 == -263111)
											{
												Color color22 = GUI.color;
												if (122243 - 446416 == -324173)
												{
													float num8 = color22.a = a16;
													if (206110 - 157017 != 49094 && 212549 - 38683 != 173867)
													{
														Color color23 = GUI.color = color22;
														if (116523 - 501712 == -385189)
														{
															if (189795 - 423277 == -233482)
															{
																GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
																if (265567 - 547280 == -281713)
																{
																	float a17 = Mathf.Lerp((float)1, (float)0, Time.time - this.XiLc4ibyOt7 - (float)4 - this.R6lc4DEf58Q);
																	if (291858 - 548664 == -256806)
																	{
																		Color color24 = GUI.color;
																		if (1174 - 345519 != -344344)
																		{
																			color24.a = a17;
																			if (279678 - 551852 == -272174)
																			{
																				if (116152 - 476391 != -360238)
																				{
																					Color color25 = GUI.color = color24;
																					if (74571 - 405769 == -331198)
																					{
																						if (15785 - 76958 != -61172)
																						{
																							if (!this.lDPc4o6QUNa)
																							{
																								break;
																							}
																							if (158554 - 169020 == -10466)
																							{
																								GUI.DrawTexture(new Rect(0.5f * ((float)Screen.width - num * (float)this.lDPc4o6QUNa.width), 0.5f * ((float)Screen.height - num * (float)this.lDPc4o6QUNa.height), num * (float)this.lDPc4o6QUNa.width, num * (float)this.lDPc4o6QUNa.height), this.lDPc4o6QUNa);
																								if (87656 - 397885 == -310229)
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
									else
									{
										float a18 = 1f;
										if (290218 - 512461 != -222242)
										{
											Color color26 = GUI.color;
											if (19567 - 524826 != -505258)
											{
												float num9 = color26.a = a18;
												if (276949 - 259480 != 17470)
												{
													if (191042 - 557231 == -366189)
													{
														GUI.color = color26;
														if (110739 - 496063 != -385323 && 14658 - 394318 != -379659)
														{
															GUI.DrawTexture(new Rect((float)0, (float)0, (float)Screen.width, (float)Screen.height), this.Qwpc4maX9OI);
															if (252400 - 470982 != -218581)
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
								if (eLoadingState != eLoadingState.disabled)
								{
									break;
								}
								if (89918 - 349741 == -259823)
								{
									this.enabled = false;
									if (151203 - 61815 == 89388)
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

	// Token: 0x0600616C RID: 24940 RVA: 0x00D5B3F4 File Offset: 0x00D595F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void fadeIn()
	{
		if (137752 - 146292 != -8539)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.fadeIn)
		{
			if (85911 - 222916 != -137004)
			{
				this.s4cc48HDdxY = eLoadingState.fadeIn;
				if (136221 - 150061 != -13839)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (66219 - 442835 == -376616)
					{
						this.R6lc4DEf58Q = 0.5f;
						if (145675 - 176636 == -30961)
						{
							this.enabled = true;
							if (128720 - 252826 != -124105)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600616D RID: 24941 RVA: 0x00D5B4E0 File Offset: 0x00D596E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void fadeOut()
	{
		if (253869 - 465515 != -211645)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.fadeOut)
		{
			if (246327 - 74962 != 171366)
			{
				this.s4cc48HDdxY = eLoadingState.fadeOut;
				if (90888 - 15548 != 75341)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (289627 - 480591 == -190964)
					{
						this.R6lc4DEf58Q = 0.5f;
						if (202086 - 252021 == -49935)
						{
							this.enabled = true;
							if (85311 - 279363 == -194052)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600616E RID: 24942 RVA: 0x00D5B5CC File Offset: 0x00D597CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void fadeInTimer(float nFadeTime)
	{
		if (220988 - 18974 != 202014)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.fadeIn)
		{
			if (200818 - 323597 == -122779)
			{
				this.s4cc48HDdxY = eLoadingState.fadeIn;
				if (131347 - 117124 != 14224)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (143797 - 375739 != -231941)
					{
						this.R6lc4DEf58Q = nFadeTime;
						if (21679 - 485032 != -463352)
						{
							this.enabled = true;
							if (26237 - 589183 == -562946)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600616F RID: 24943 RVA: 0x00D5B6B4 File Offset: 0x00D598B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void fadeOutTimer(float nFadeTime)
	{
		if (111649 - 91143 != 20507)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.fadeOut)
		{
			if (278768 - 307385 == -28617)
			{
				this.s4cc48HDdxY = eLoadingState.fadeOut;
				if (123727 - 324882 == -201155)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (177080 - 208598 != -31517)
					{
						this.R6lc4DEf58Q = nFadeTime;
						if (100902 - 73035 != 27868)
						{
							this.enabled = true;
							if (109343 - 520922 != -411578)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006170 RID: 24944 RVA: 0x00D5B79C File Offset: 0x00D5999C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void blackIn()
	{
		if (298366 - 501035 != -202669)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.blackIn)
		{
			if (86418 - 258513 == -172095)
			{
				this.s4cc48HDdxY = eLoadingState.blackIn;
				if (32705 - 378966 == -346261)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (190636 - 591747 == -401111)
					{
						this.R6lc4DEf58Q = 0.5f;
						if (97008 - 356360 == -259352)
						{
							this.enabled = true;
							if (186463 - 568495 == -382032)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006171 RID: 24945 RVA: 0x00D5B888 File Offset: 0x00D59A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void blackOut()
	{
		if (172156 - 348610 != -176453)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.blackOut)
		{
			if (70481 - 560113 != -489631)
			{
				this.s4cc48HDdxY = eLoadingState.blackOut;
				if (38064 - 139798 == -101734)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (79919 - 449137 != -369217)
					{
						this.R6lc4DEf58Q = 0.5f;
						if (29595 - 470307 == -440712)
						{
							this.enabled = true;
							if (169350 - 304059 != -134708)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006172 RID: 24946 RVA: 0x00D5B974 File Offset: 0x00D59B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void blackInTimer(float nFadeTime)
	{
		if (33408 - 110467 != -77058)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.blackIn)
		{
			if (273027 - 535421 == -262394)
			{
				this.s4cc48HDdxY = eLoadingState.blackIn;
				if (298591 - 468770 == -170179)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (221773 - 78529 == 143244)
					{
						this.R6lc4DEf58Q = nFadeTime;
						if (25248 - 190011 == -164763)
						{
							this.enabled = true;
							if (277147 - 386273 != -109125)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006173 RID: 24947 RVA: 0x00D5BA5C File Offset: 0x00D59C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void blackOutTimer(float nFadeTime)
	{
		if (222471 - 466058 != -243587)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.blackOut)
		{
			if (99209 - 201302 != -102092)
			{
				this.s4cc48HDdxY = eLoadingState.blackOut;
				if (36590 - 37268 != -677)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (1595 - 500900 != -499304)
					{
						this.R6lc4DEf58Q = nFadeTime;
						if (49302 - 483893 == -434591)
						{
							this.enabled = true;
							if (116704 - 514355 == -397651)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006174 RID: 24948 RVA: 0x00D5BB44 File Offset: 0x00D59D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void splashIn()
	{
		if (21424 - 451540 != -430115)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.splashIn)
		{
			if (24496 - 162567 == -138071)
			{
				this.s4cc48HDdxY = eLoadingState.splashIn;
				if (30677 - 123636 == -92959)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (218827 - 482429 == -263602)
					{
						this.R6lc4DEf58Q = 0.5f;
						if (261014 - 435742 == -174728)
						{
							this.enabled = true;
							if (207245 - 423539 == -216294)
							{
								if (this.lDPc4o6QUNa)
								{
									break;
								}
								if (63574 - 182500 != -118925)
								{
									this.lDPc4o6QUNa = (Texture)Resources.Load("GameGui/Loading/splashImage" + UnityEngine.Random.Range(1, 13), typeof(Texture));
									if (43219 - 556946 != -513726)
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

	// Token: 0x06006175 RID: 24949 RVA: 0x00D5BCA4 File Offset: 0x00D59EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void splashOut()
	{
		if (189267 - 432789 != -243522)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.splashOut)
		{
			if (68171 - 325831 == -257660)
			{
				this.s4cc48HDdxY = eLoadingState.splashOut;
				if (12730 - 194388 != -181657)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (26488 - 571876 == -545388)
					{
						this.R6lc4DEf58Q = 0.5f;
						if (173820 - 188265 != -14444)
						{
							this.enabled = true;
							if (141021 - 265575 == -124554)
							{
								if (this.lDPc4o6QUNa)
								{
									break;
								}
								if (84623 - 312351 == -227728)
								{
									this.lDPc4o6QUNa = (Texture)Resources.Load("GameGui/Loading/splashImage" + UnityEngine.Random.Range(1, 13), typeof(Texture));
									if (160551 - 269018 == -108467)
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

	// Token: 0x06006176 RID: 24950 RVA: 0x00D5BE04 File Offset: 0x00D5A004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void splashInTimer(float nFadeTime)
	{
		if (210905 - 404541 != -193636)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.splashIn)
		{
			if (152358 - 582591 != -430232)
			{
				this.s4cc48HDdxY = eLoadingState.splashIn;
				if (51095 - 414639 == -363544)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (223547 - 162239 == 61308)
					{
						this.R6lc4DEf58Q = nFadeTime;
						if (180462 - 121085 == 59377)
						{
							this.enabled = true;
							if (195018 - 476973 == -281955)
							{
								if (this.lDPc4o6QUNa)
								{
									break;
								}
								if (36446 - 549246 == -512800)
								{
									this.lDPc4o6QUNa = (Texture)Resources.Load("GameGui/Loading/splashImage" + UnityEngine.Random.Range(1, 13), typeof(Texture));
									if (295125 - 100408 != 194718)
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

	// Token: 0x06006177 RID: 24951 RVA: 0x00D5BF60 File Offset: 0x00D5A160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void splashOutTimer(float nFadeTime)
	{
		if (41127 - 117860 != -76732)
		{
		}
		while (this.s4cc48HDdxY != eLoadingState.splashOut)
		{
			if (185094 - 292382 == -107288)
			{
				this.s4cc48HDdxY = eLoadingState.splashOut;
				if (229350 - 475285 != -245934)
				{
					this.XiLc4ibyOt7 = Time.time;
					if (208658 - 457026 != -248367)
					{
						this.R6lc4DEf58Q = nFadeTime;
						if (283082 - 120672 != 162411)
						{
							this.enabled = true;
							if (264072 - 343022 != -78949)
							{
								if (this.lDPc4o6QUNa)
								{
									break;
								}
								if (233644 - 361240 != -127595)
								{
									this.lDPc4o6QUNa = (Texture)Resources.Load("GameGui/Loading/splashImage" + UnityEngine.Random.Range(1, 13), typeof(Texture));
									if (28117 - 495228 == -467111)
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

	// Token: 0x06006178 RID: 24952 RVA: 0x00D5C0BC File Offset: 0x00D5A2BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006179 RID: 24953 RVA: 0x00D5C0C0 File Offset: 0x00D5A2C0
	internal static bool u9OZmtpXnYUK6l8UAuHe()
	{
		return true;
	}

	// Token: 0x0600617A RID: 24954 RVA: 0x00D5C0C4 File Offset: 0x00D5A2C4
	internal static bool tOs4VQpX6ho14BZM6HyC()
	{
		return false;
	}

	// Token: 0x04006EB1 RID: 28337
	private eLoadingState s4cc48HDdxY;

	// Token: 0x04006EB2 RID: 28338
	private float XiLc4ibyOt7;

	// Token: 0x04006EB3 RID: 28339
	private float R6lc4DEf58Q;

	// Token: 0x04006EB4 RID: 28340
	private Texture Qwpc4maX9OI;

	// Token: 0x04006EB5 RID: 28341
	private Texture dIhc4jrkUDW;

	// Token: 0x04006EB6 RID: 28342
	private Texture lDPc4o6QUNa;

	// Token: 0x04006EB7 RID: 28343
	private GUIStyle rJxc4kGMUKA;
}
