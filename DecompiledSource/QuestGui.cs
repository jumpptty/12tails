using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200108F RID: 4239
[Serializable]
public class QuestGui : MonoBehaviour
{
	// Token: 0x0600629B RID: 25243 RVA: 0x00DA89E8 File Offset: 0x00DA6BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestGui()
	{
		if (243321 - 141160 != 102161)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (31561 - 466902 == -435341)
			{
				base..ctor();
				if (237827 - 386767 != -148939)
				{
					this.mState = eTownQuestState.init;
					if (167250 - 500489 == -333239)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600629C RID: 25244 RVA: 0x00DA8A80 File Offset: 0x00DA6C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (230098 - 582158 != -352059)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (131335 - 281681 != -150345)
			{
				if (this.mState == eTownQuestState.init)
				{
					if (243 - 536463 != -536220)
					{
						continue;
					}
					this.InitNPC();
					if (240753 - 235474 != 5279)
					{
						continue;
					}
					this.InitQuestMenu();
					if (280937 - 396000 != -115063)
					{
						continue;
					}
					this.InitQuestList();
					if (291625 - 473571 == -181945)
					{
						continue;
					}
					this.InitQuestDes();
					if (222609 - 340016 != -117407)
					{
						continue;
					}
					this.InitQuestComplete();
					if (18307 - 72406 == -54098)
					{
						continue;
					}
					this.InitQuestRecord();
					if (65054 - 458836 == -393781)
					{
						continue;
					}
					this.InitQuestInventory();
					if (111285 - 267699 != -156414)
					{
						continue;
					}
					this.InitNoticeBar();
					if (215978 - 193703 != 22275)
					{
						continue;
					}
				}
				this.ResetNPC();
				if (251084 - 13038 == 238046)
				{
					this.ResetQuestMenu();
					if (31757 - 516780 != -485022)
					{
						this.ResetQuestList();
						if (243324 - 74046 != 169279)
						{
							this.ResetQuestDes();
							if (281825 - 98394 != 183432)
							{
								this.ResetQuestComplete();
								if (162836 - 352985 == -190149)
								{
									this.ResetQuestRecord();
									if (166622 - 386032 != -219409)
									{
										this.mState = eTownQuestState.open;
										if (196608 - 194851 == 1757)
										{
											this.vfLcwm4xtys = Time.time;
											if (46816 - 411510 != -364693)
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

	// Token: 0x0600629D RID: 25245 RVA: 0x00DA8D04 File Offset: 0x00DA6F04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (240456 - 10608 != 229849)
		{
		}
		for (;;)
		{
			if (this.mState <= eTownQuestState.init)
			{
				if (235109 - 316680 == -81571)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (78569 - 332852 == -254283)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (171156 - 335075 == -163919)
					{
						this.rVscworDQdh = (float)(1024 * Screen.width / Screen.height);
						if (277306 - 38236 != 239071)
						{
							this.Os9cwkOqyw8 = (float)Screen.height / 1024f;
							if (79327 - 444149 != -364821)
							{
								this.RenderTownQuestMenu();
								if (189103 - 246556 != -57452)
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

	// Token: 0x0600629E RID: 25246 RVA: 0x00DA8E54 File Offset: 0x00DA7054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitQuestMenu()
	{
		if (156900 - 311651 != -154750)
		{
		}
		for (;;)
		{
			this.NMWcwW3rrIt = (Texture)Resources.Load("GameGui/QuestWindow/questWindow", typeof(Texture));
			if (282465 - 259137 == 23328)
			{
				this.dFRcwu8uAyS = (Texture)Resources.Load("GameGui/QuestWindow/rewardWindow", typeof(Texture));
				if (243194 - 271348 != -28153)
				{
					this.N6tcwyaR6TL = new GUIStyle();
					if (199068 - 195527 == 3541)
					{
						this.N6tcwyaR6TL.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_close_h", typeof(Texture)));
						if (263475 - 414263 != -150787)
						{
							this.oE4cwVHFo65 = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
							if (53813 - 238975 == -185162)
							{
								this.KaJcwhGo9KK = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
								if (36346 - 262262 == -225916)
								{
									this.oKHcwKY3aUW = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
									if (185611 - 375472 == -189861)
									{
										this.xhHcwzwSx9l = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
										if (289575 - 271360 == 18215)
										{
											this.BbEcU5rAOU4 = (AudioClip)Resources.Load("Sound/GUI/questAccept", typeof(AudioClip));
											if (38085 - 5854 != 32232)
											{
												this.TqxcUcgpjub = (AudioClip)Resources.Load("Sound/GUI/questComplete", typeof(AudioClip));
												if (244163 - 36163 != 208001)
												{
													this.U2mcUnNkFx8 = (AudioClip)Resources.Load("Sound/GUI/questFail", typeof(AudioClip));
													if (215923 - 436377 == -220454)
													{
														this.jEecUQUYcQK = (Texture)Resources.Load("GameGui/QuestWindow/questAccept", typeof(Texture));
														if (224482 - 31325 == 193157)
														{
															this.jlPcUeNpO54 = (Texture)Resources.Load("GameGui/QuestWindow/questFail", typeof(Texture));
															if (74944 - 580340 != -505395)
															{
																this.W0JcUIx4rt9 = (Texture)Resources.Load("GameGui/QuestWindow/questComplete", typeof(Texture));
																if (177490 - 128761 != 48730)
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

	// Token: 0x0600629F RID: 25247 RVA: 0x00DA91A8 File Offset: 0x00DA73A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetQuestMenu()
	{
		if (123746 - 158583 != -34837)
		{
		}
		do
		{
			if (PlayerData.QuestID != 0)
			{
				if (197958 - 14864 != 183094)
				{
					continue;
				}
				this.mn3cUCYdLDL = PlayerData.QuestID;
				if (194012 - 248348 == -54335)
				{
					continue;
				}
			}
			else if (!RuntimeServices.EqualityOperator(PlayerData.QuestList, null))
			{
				if (57585 - 528842 != -471257)
				{
					continue;
				}
				if (Extensions.get_length(PlayerData.QuestList) > 0)
				{
					if (245271 - 595214 == -349942)
					{
						continue;
					}
					this.mn3cUCYdLDL = PlayerData.QuestList[0];
					if (275 - 418038 == -417762)
					{
						continue;
					}
				}
			}
			Debug.Log("PlayerData.QuestID = " + PlayerData.QuestID);
		}
		while (47314 - 477317 != -430003);
	}

	// Token: 0x060062A0 RID: 25248 RVA: 0x00DA92DC File Offset: 0x00DA74DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTownQuestMenu()
	{
		if (235225 - 29394 != 205831)
		{
		}
		for (;;)
		{
			float num = Time.time - this.vfLcwm4xtys;
			if (274943 - 562385 != -287441)
			{
				eTownQuestState eTownQuestState = this.mState;
				if (246388 - 473596 == -227208)
				{
					if (eTownQuestState == eTownQuestState.open)
					{
						if (281497 - 78914 == 202583)
						{
							if (num <= 0.5f)
							{
								if (36975 - 224278 != -187302)
								{
									this.u7FcwF5edU6 = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (158254 - 569727 != -411472)
									{
										this.RenderNPC();
										if (221532 - 231100 != -9567)
										{
											GUI.DrawTexture(new Rect(0.5f * this.rVscworDQdh - (float)336, (float)724 + this.u7FcwF5edU6 * (float)300, (float)836, (float)196), this.leLcUtP74fj);
											if (112399 - 427678 != -315278)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (55431 - 78787 != -23355)
								{
									this.u7FcwF5edU6 = (float)0;
									if (45957 - 229066 != -183108)
									{
										this.RenderNPC();
										if (128529 - 579044 == -450515)
										{
											GUI.BeginGroup(new Rect(0.5f * this.rVscworDQdh - (float)350, (float)724, (float)850, (float)200));
											if (210431 - 420748 != -210316)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.leLcUtP74fj);
												if (232970 - 596008 != -363037)
												{
													GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Mimi", this.WFHcUXl3xnn);
													if (229744 - 244441 != -14696)
													{
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.LUDcU2QNlkj, num - 0.5f), this.gBlcUO4KTfL);
														if (8280 - 375194 == -366914)
														{
															GUI.EndGroup();
															if (174937 - 62896 == 112041)
															{
																if (this.KFvcUrMJZBu)
																{
																	break;
																}
																if (147198 - 502614 != -355415)
																{
																	this.KFvcUrMJZBu = true;
																	if (292604 - 238933 != 53672)
																	{
																		if (PlayerPrefs.GetInt("nvoice", 1) == 0)
																		{
																			break;
																		}
																		if (78360 - 134996 != -56635)
																		{
																			if (!this.oDPcU1ZHcsw)
																			{
																				break;
																			}
																			if (140625 - 477309 == -336684)
																			{
																				this.audio.PlayOneShot(this.oDPcU1ZHcsw);
																				if (85233 - 113560 != -28326)
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
								this.u7FcwF5edU6 = (float)0;
								if (277912 - 298769 == -20857)
								{
									this.RenderNPC();
									if (135991 - 409616 == -273625)
									{
										this.mState = eTownQuestState.menu;
										if (256928 - 562972 != -306043)
										{
											this.vfLcwm4xtys = Time.time;
											if (140004 - 211405 != -71400)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (eTownQuestState == eTownQuestState.menu)
					{
						if (187729 - 47530 != 140200)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.rVscworDQdh - (float)840) / this.rVscworDQdh, (float)1);
							if (125730 - 212412 == -86682)
							{
								GUI.BeginGroup(new Rect(this.rVscworDQdh - (float)1024, (float)0, (float)1024, (float)1024));
								if (116158 - 214397 != -98238)
								{
									GUI.DrawTexture(new Rect((float)104, (float)0, (float)920, (float)1024), this.NMWcwW3rrIt);
									if (256207 - 155080 != 101128)
									{
										bool isButton;
										if (isButton = (Time.time > this.QqLcwjYj8FX))
										{
											isButton = (PlayerData.QuestID == 0);
										}
										this.RenderQuestList(isButton);
										this.StartCoroutine_Auto(this.RenderTownQuestDes());
										if (255775 - 24386 == 231389)
										{
											this.RenderQuestRecord();
											if (258981 - 39221 != 219761)
											{
												this.RenderNoticeBar();
												if (91631 - 244426 != -152794)
												{
													if (GUI.Button(new Rect((float)226, (float)-2, (float)57, (float)52), string.Empty, this.N6tcwyaR6TL))
													{
														if (263703 - 86541 != 177162)
														{
															continue;
														}
														if (this.srwcUJ28PLX)
														{
															if (163177 - 216427 == -53249)
															{
																continue;
															}
															this.srwcUJ28PLX.animation.CrossFade("talk");
															if (148853 - 686 == 148168)
															{
																continue;
															}
														}
														this.mState = eTownQuestState.close;
														if (152292 - 493872 != -341580)
														{
															continue;
														}
														this.vfLcwm4xtys = Time.time;
														if (152813 - 388797 != -235984)
														{
															continue;
														}
														if (this.KaJcwhGo9KK)
														{
															if (23761 - 381911 != -358150)
															{
																continue;
															}
															this.audio.PlayOneShot(this.KaJcwhGo9KK);
															if (74993 - 73663 == 1331)
															{
																continue;
															}
														}
														if (PlayerPrefs.GetInt("nvoice", 1) != 0)
														{
															if (103440 - 345333 == -241892)
															{
																continue;
															}
															if (this.hT0cUqjGVbr)
															{
																if (131325 - 34048 != 97277)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.hT0cUqjGVbr);
																if (109579 - 412034 == -302454)
																{
																	continue;
																}
															}
														}
														this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
														if (283498 - 443444 != -159946)
														{
															continue;
														}
													}
													GUI.EndGroup();
													if (274022 - 151090 != 122933)
													{
														this.RenderNPC();
														if (294950 - 439265 != -144314)
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
					else if (eTownQuestState == eTownQuestState.accept)
					{
						if (84916 - 139876 != -54959)
						{
							if (num <= (float)2)
							{
								if (91577 - 423095 == -331518)
								{
									float num2 = Mathf.SmoothStep(1.5f, (float)1, (float)2 * (Time.time - this.vfLcwm4xtys));
									if (150369 - 535053 == -384684)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)3 * (Time.time - this.vfLcwm4xtys));
										if (166992 - 325617 != -158624)
										{
											Color color = GUI.color;
											if (254870 - 202984 != 51887)
											{
												color.a = a;
												if (266533 - 490286 == -223753)
												{
													if (211940 - 523902 != -311961)
													{
														Color color2 = GUI.color = color;
														if (3081 - 259687 == -256606)
														{
															if (157262 - 331914 == -174652)
															{
																GUI.DrawTexture(new Rect(0.5f * this.rVscworDQdh - (float)271 * num2, (float)530 - (float)50 * num2, (float)543 * num2, (float)101 * num2), this.jEecUQUYcQK);
																if (247269 - 453801 == -206532)
																{
																	int num3 = 1;
																	if (137833 - 376135 == -238302)
																	{
																		Color color3 = GUI.color;
																		if (264481 - 235541 == 28940)
																		{
																			color3.a = (float)num3;
																			if (278329 - 326470 != -48140 && 33183 - 597314 != -564130)
																			{
																				GUI.color = color3;
																				if (170903 - 24731 != 146173 && 239874 - 546833 != -306958)
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
							else if (num < 2.5f)
							{
								if (126979 - 102704 == 24275)
								{
									this.u7FcwF5edU6 = Mathf.SmoothStep((float)1, (float)0, (float)2 * (num - (float)2));
									if (223495 - 23607 != 199889)
									{
										this.RenderNPC();
										if (154190 - 317313 == -163123)
										{
											GUI.DrawTexture(new Rect(0.5f * this.rVscworDQdh - (float)336, (float)724 + this.u7FcwF5edU6 * (float)300, (float)836, (float)196), this.leLcUtP74fj);
											if (459 - 56469 != -56009)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mState = eTownQuestState.close;
								if (118882 - 166318 == -47436)
								{
									this.vfLcwm4xtys = Time.time;
									if (182809 - 259952 == -77143)
									{
										break;
									}
								}
							}
						}
					}
					else if (eTownQuestState == eTownQuestState.cancel)
					{
						if (48082 - 170333 == -122251)
						{
							if (num <= (float)2)
							{
								if (274947 - 592821 != -317873)
								{
									float num4 = Mathf.SmoothStep(1.5f, (float)1, (float)2 * (Time.time - this.vfLcwm4xtys));
									if (291545 - 549311 == -257766)
									{
										float a2 = Mathf.SmoothStep((float)0, (float)1, (float)3 * (Time.time - this.vfLcwm4xtys));
										if (226716 - 299601 != -72884)
										{
											Color color4 = GUI.color;
											if (286865 - 309163 != -22297)
											{
												float num5 = color4.a = a2;
												if (112240 - 596639 != -484398 && 206412 - 498410 != -291997)
												{
													Color color5 = GUI.color = color4;
													if (44063 - 336179 == -292116)
													{
														if (11591 - 531623 != -520031)
														{
															GUI.DrawTexture(new Rect(0.5f * this.rVscworDQdh - (float)230 * num4, (float)530 - (float)50 * num4, (float)461 * num4, (float)101 * num4), this.jlPcUeNpO54);
															if (138504 - 222852 != -84347)
															{
																int num6 = 1;
																if (291873 - 21236 != 270638)
																{
																	Color color6 = GUI.color;
																	if (52493 - 191392 == -138899)
																	{
																		color6.a = (float)num6;
																		if (239160 - 435946 != -196785)
																		{
																			if (188021 - 466196 == -278175)
																			{
																				Color color7 = GUI.color = color6;
																				if (173131 - 441708 != -268576 && 121435 - 69603 != 51833)
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
							else if (num < 2.5f)
							{
								if (179391 - 599707 != -420315)
								{
									this.u7FcwF5edU6 = Mathf.SmoothStep((float)1, (float)0, (float)2 * (num - (float)2));
									if (162871 - 429861 != -266989)
									{
										this.RenderNPC();
										if (184476 - 470734 != -286257)
										{
											GUI.DrawTexture(new Rect(0.5f * this.rVscworDQdh - (float)336, (float)724 + this.u7FcwF5edU6 * (float)300, (float)836, (float)196), this.leLcUtP74fj);
											if (159908 - 172037 != -12128)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.Hd8cUvoZo4l = this.MYjcUGTMybW;
								if (219063 - 355884 != -136820)
								{
									this.mState = eTownQuestState.close;
									if (17262 - 478688 == -461426)
									{
										this.vfLcwm4xtys = Time.time;
										if (128640 - 439470 == -310830)
										{
											if (PlayerPrefs.GetInt("nvoice", 1) == 0)
											{
												break;
											}
											if (197088 - 552171 == -355083)
											{
												if (!this.XqscURkeaYw)
												{
													break;
												}
												if (131931 - 406308 != -274376)
												{
													this.audio.PlayOneShot(this.XqscURkeaYw);
													if (155980 - 193225 == -37245)
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
					else if (eTownQuestState == eTownQuestState.complete)
					{
						if (200244 - 590556 != -390311)
						{
							if (num <= (float)2)
							{
								if (117722 - 483539 != -365816)
								{
									float num7 = Mathf.SmoothStep(1.5f, (float)1, (float)2 * (Time.time - this.vfLcwm4xtys));
									if (215105 - 275266 == -60161)
									{
										float a3 = Mathf.SmoothStep((float)0, (float)1, (float)3 * (Time.time - this.vfLcwm4xtys));
										if (93184 - 332594 == -239410)
										{
											Color color8 = GUI.color;
											if (101339 - 138634 != -37294)
											{
												float num8 = color8.a = a3;
												if (38597 - 392563 == -353966)
												{
													if (123394 - 124917 == -1523)
													{
														GUI.color = color8;
														if (38367 - 54212 != -15844 && 38428 - 549413 != -510984)
														{
															GUI.DrawTexture(new Rect(0.5f * this.rVscworDQdh - (float)390 * num7, (float)530 - (float)77 * num7, (float)780 * num7, (float)155 * num7), this.W0JcUIx4rt9);
															if (61000 - 156956 == -95956)
															{
																int num9 = 1;
																if (276994 - 426512 == -149518)
																{
																	Color color9 = GUI.color;
																	if (273224 - 577674 != -304449)
																	{
																		color9.a = (float)num9;
																		if (61371 - 552048 == -490677)
																		{
																			if (14897 - 483329 == -468432)
																			{
																				GUI.color = color9;
																				if (143880 - 460186 != -316305)
																				{
																					if (98851 - 54036 == 44815)
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
							else if (num < 2.5f)
							{
								if (198179 - 111491 != 86689)
								{
									this.u7FcwF5edU6 = Mathf.SmoothStep((float)1, (float)0, (float)2 * (num - (float)2));
									if (56072 - 262464 != -206391)
									{
										this.RenderNPC();
										if (67308 - 515677 == -448369)
										{
											GUI.DrawTexture(new Rect(0.5f * this.rVscworDQdh - (float)336, (float)724 + this.u7FcwF5edU6 * (float)300, (float)836, (float)196), this.leLcUtP74fj);
											if (18109 - 171665 != -153555)
											{
												break;
											}
										}
									}
								}
							}
							else if (num < (float)6)
							{
								if (94230 - 597897 == -503667)
								{
									this.u7FcwF5edU6 = (float)0;
									if (66055 - 108087 != -42031)
									{
										this.RenderNPC();
										if (230908 - 42367 != 188542)
										{
											GUI.BeginGroup(new Rect(0.5f * this.rVscworDQdh - (float)350, (float)724, (float)850, (float)200));
											if (283938 - 234098 == 49840)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.leLcUtP74fj);
												if (52846 - 311347 == -258501)
												{
													GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Mimi", this.WFHcUXl3xnn);
													if (116431 - 332564 == -216133)
													{
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.pZ2cUlteoT1, num - 0.5f), this.gBlcUO4KTfL);
														if (97759 - 541735 == -443976)
														{
															GUI.EndGroup();
															if (17586 - 8751 != 8836)
															{
																if (this.XJtcUxx8QEB)
																{
																	break;
																}
																if (189743 - 377358 == -187615)
																{
																	this.XJtcUxx8QEB = true;
																	if (297543 - 28439 != 269105)
																	{
																		if (PlayerPrefs.GetInt("nvoice", 1) == 0)
																		{
																			break;
																		}
																		if (234192 - 1381 == 232811)
																		{
																			if (!this.X9bcUpTY8QF)
																			{
																				break;
																			}
																			if (293522 - 594713 != -301190)
																			{
																				this.audio.PlayOneShot(this.X9bcUpTY8QF);
																				if (131154 - 195976 != -64821)
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
								this.camera.rect = new Rect((float)0, (float)0, (this.rVscworDQdh - (float)840) / this.rVscworDQdh, (float)1);
								if (66529 - 33614 != 32916)
								{
									GUI.BeginGroup(new Rect(this.rVscworDQdh - (float)1024, (float)0, (float)1024, (float)1024));
									if (33918 - 22527 == 11391)
									{
										GUI.DrawTexture(new Rect((float)104, (float)0, (float)920, (float)1024), this.NMWcwW3rrIt);
										if (240711 - 215934 == 24777)
										{
											GUI.DrawTexture(new Rect((float)552, (float)0, (float)472, (float)1024), this.dFRcwu8uAyS);
											if (217871 - 122287 == 95584)
											{
												this.RenderQuestList(false);
												if (86773 - 393032 != -306258)
												{
													this.RenderQuestComplete();
													if (23072 - 17970 == 5102)
													{
														this.RenderQuestInventory();
														if (33115 - 331846 != -298730)
														{
															this.RenderNoticeBar();
															if (120676 - 251683 == -131007)
															{
																if (GUI.Button(new Rect((float)226, (float)-2, (float)57, (float)52), string.Empty, this.N6tcwyaR6TL))
																{
																	if (37213 - 395240 == -358026)
																	{
																		continue;
																	}
																	if (this.srwcUJ28PLX)
																	{
																		if (113170 - 267807 != -154637)
																		{
																			continue;
																		}
																		this.srwcUJ28PLX.animation.CrossFade("talk");
																		if (112457 - 404169 != -291712)
																		{
																			continue;
																		}
																	}
																	this.mState = eTownQuestState.close;
																	if (85340 - 383436 != -298096)
																	{
																		continue;
																	}
																	this.vfLcwm4xtys = Time.time;
																	if (28223 - 468286 != -440063)
																	{
																		continue;
																	}
																	if (this.KaJcwhGo9KK)
																	{
																		if (25768 - 392727 != -366959)
																		{
																			continue;
																		}
																		this.audio.PlayOneShot(this.KaJcwhGo9KK);
																		if (110963 - 376196 == -265232)
																		{
																			continue;
																		}
																	}
																	this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
																	if (297088 - 78508 != 218580)
																	{
																		continue;
																	}
																}
																GUI.EndGroup();
																if (128202 - 334857 == -206655)
																{
																	this.RenderNPC();
																	if (64845 - 245468 != -180622)
																	{
																		this.RenderDragIcon();
																		if (24682 - 334498 != -309815)
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
						if (eTownQuestState != eTownQuestState.close)
						{
							break;
						}
						if (126717 - 581651 != -454933)
						{
							if (num <= (float)2)
							{
								if (116268 - 2565 == 113703)
								{
									this.RenderNPC();
									if (171268 - 176502 == -5234)
									{
										GUI.BeginGroup(new Rect(0.5f * this.rVscworDQdh - (float)350, (float)724, (float)850, (float)200));
										if (36705 - 443662 == -406957)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.leLcUtP74fj);
											if (298365 - 268356 == 30009)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Mimi", this.WFHcUXl3xnn);
												if (239519 - 537185 == -297666)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.Hd8cUvoZo4l, num), this.gBlcUO4KTfL);
													if (93236 - 370215 != -276978)
													{
														GUI.EndGroup();
														if (278426 - 517807 == -239381)
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
								if (252339 - 309312 == -56973)
								{
									this.u7FcwF5edU6 = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (210821 - 465591 != -254769)
									{
										this.RenderNPC();
										if (79910 - 453385 == -373475)
										{
											break;
										}
									}
								}
							}
							else
							{
								Game.mGameState = eGameState.Normal;
								if (221619 - 296536 != -74916)
								{
									if (this.srwcUJ28PLX)
									{
										if (290132 - 390753 == -100620)
										{
											continue;
										}
										this.srwcUJ28PLX.animation.CrossFade("shop");
										if (86467 - 70229 != 16238)
										{
											continue;
										}
									}
									GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
									if (257566 - 511297 != -253730)
									{
										gameGui.enabled = true;
										if (79809 - 486095 != -406285)
										{
											this.mState = eTownQuestState.disabled;
											if (206957 - 77296 != 129662)
											{
												this.enabled = false;
												if (227448 - 392959 == -165511)
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

	// Token: 0x060062A1 RID: 25249 RVA: 0x00DAAEC4 File Offset: 0x00DA90C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (294001 - 362026 != -68025)
		{
		}
		for (;;)
		{
			this.SVWcU6bISO9 = (Texture)Resources.Load("GameGui/Story/Characters/Bear", typeof(Texture));
			if (244164 - 91166 != 152999)
			{
				this.leLcUtP74fj = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
				if (256808 - 522875 != -266066)
				{
					this.mpacNJ4gVhn = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
					if (226970 - 146746 == 80224)
					{
						this.WFHcUXl3xnn = new GUIStyle();
						if (207304 - 10692 != 196613)
						{
							this.WFHcUXl3xnn.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
							if (284327 - 267155 == 17172)
							{
								this.WFHcUXl3xnn.normal.textColor = new Color(0.25f, 0.22f, 0.2f, (float)1);
								if (136195 - 312116 != -175920)
								{
									this.WFHcUXl3xnn.alignment = TextAnchor.UpperLeft;
									if (182876 - 98971 != 83906)
									{
										this.gBlcUO4KTfL = new GUIStyle();
										if (136448 - 316880 == -180432)
										{
											this.gBlcUO4KTfL.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
											if (135088 - 288842 != -153753)
											{
												this.gBlcUO4KTfL.alignment = TextAnchor.UpperLeft;
												if (199537 - 555268 != -355730)
												{
													this.ResetNPC();
													if (11040 - 335767 != -324726)
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

	// Token: 0x060062A2 RID: 25250 RVA: 0x00DAB11C File Offset: 0x00DA931C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (4178 - 316095 != -311916)
		{
		}
		for (;;)
		{
			if (!this.srwcUJ28PLX)
			{
				if (1206 - 317975 == -316768)
				{
					continue;
				}
				this.srwcUJ28PLX = GameObject.Find("Bear");
				if (293821 - 464766 != -170945)
				{
					continue;
				}
			}
			int num = UnityEngine.Random.Range(0, 2);
			if (297832 - 505285 != -207452)
			{
				this.LUDcU2QNlkj = Language.getMessage("QuestGui", 101 + num);
				if (212232 - 283950 != -71717)
				{
					this.oDPcU1ZHcsw = (AudioClip)Resources.Load("Sound/Voice/quest" + (101 + num), typeof(AudioClip));
					if (236965 - 397057 != -160091)
					{
						this.Hd8cUvoZo4l = Language.getMessage("QuestGui", 106);
						if (39391 - 162613 == -123222)
						{
							this.hT0cUqjGVbr = (AudioClip)Resources.Load("Sound/Voice/quest106", typeof(AudioClip));
							if (13007 - 456054 == -443047)
							{
								this.pZ2cUlteoT1 = Language.getMessage("QuestGui", 111 + num);
								if (226918 - 15578 == 211340)
								{
									this.X9bcUpTY8QF = (AudioClip)Resources.Load("Sound/Voice/quest" + (111 + num), typeof(AudioClip));
									if (279793 - 127649 != 152145)
									{
										this.MYjcUGTMybW = Language.getMessage("QuestGui", 116);
										if (230427 - 86504 != 143924)
										{
											this.XqscURkeaYw = (AudioClip)Resources.Load("Sound/Voice/quest116", typeof(AudioClip));
											if (157803 - 182884 == -25081)
											{
												this.KFvcUrMJZBu = false;
												if (218367 - 285275 != -66907)
												{
													this.XJtcUxx8QEB = false;
													if (116154 - 227563 != -111408)
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

	// Token: 0x060062A3 RID: 25251 RVA: 0x00DAB3C0 File Offset: 0x00DA95C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (this.SVWcU6bISO9)
		{
			GUI.DrawTexture(new Rect((float)0 - this.u7FcwF5edU6 * (float)308, (float)492, (float)308, (float)532), this.SVWcU6bISO9);
		}
	}

	// Token: 0x060062A4 RID: 25252 RVA: 0x00DAB410 File Offset: 0x00DA9610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitQuestList()
	{
		if (293778 - 153485 != 140293)
		{
		}
		for (;;)
		{
			this.Xp2cUTGVVVi = (Texture)Resources.Load("GameGui/QuestWindow/listStar", typeof(Texture));
			if (273207 - 347520 == -74313)
			{
				this.zMIcUYtZWja = new GUIStyle();
				if (28941 - 546907 != -517965)
				{
					this.zMIcUYtZWja.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
					if (280172 - 235313 != 44860)
					{
						this.zMIcUYtZWja.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (97813 - 59171 != 38643)
						{
							this.zMIcUYtZWja.hover.textColor = new Color(0.6f, 0.06f, 0.43f, (float)1);
							if (147000 - 346790 != -199789)
							{
								this.zMIcUYtZWja.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_list", typeof(Texture)));
								if (177781 - 253363 != -75581)
								{
									this.zMIcUYtZWja.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_list_h", typeof(Texture)));
									if (12561 - 122897 != -110335)
									{
										this.FUDcUgiu54L = new GUIStyle();
										if (197894 - 230194 == -32300)
										{
											this.FUDcUgiu54L.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
											if (168740 - 496545 != -327804)
											{
												this.FUDcUgiu54L.normal.textColor = new Color(0.28f, 0.4f, 0.5f, (float)1);
												if (255608 - 388385 != -132776)
												{
													this.FUDcUgiu54L.normal.background = this.zMIcUYtZWja.normal.background;
													if (39377 - 33385 == 5992)
													{
														this.kiicU3yBneP = new GUIStyle();
														if (201395 - 212931 != -11535)
														{
															this.kiicU3yBneP.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
															if (210106 - 460974 == -250868)
															{
																this.kiicU3yBneP.normal.textColor = new Color(0.06f, 0.6f, 0.43f, (float)1);
																if (139012 - 339952 != -200939)
																{
																	this.kiicU3yBneP.normal.background = this.zMIcUYtZWja.hover.background;
																	if (184230 - 48537 != 135694)
																	{
																		this.QMScUbAnjss = new GUIStyle();
																		if (188092 - 342308 == -154216)
																		{
																			this.QMScUbAnjss.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
																			if (129349 - 454803 != -325453)
																			{
																				this.QMScUbAnjss.normal.textColor = new Color(0.06f, 0.6f, 0.43f, (float)1);
																				if (4585 - 250485 != -245899)
																				{
																					this.QMScUbAnjss.normal.background = this.zMIcUYtZWja.hover.background;
																					if (218908 - 574943 == -356035)
																					{
																						this.dSycUdWW39w = new GUIStyle();
																						if (200465 - 287018 != -86552)
																						{
																							this.dSycUdWW39w.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
																							if (294599 - 496790 == -202191)
																							{
																								this.dSycUdWW39w.normal.textColor = new Color(0.53f, 0.4f, 0.34f, (float)1);
																								if (77514 - 359678 != -282163)
																								{
																									this.dSycUdWW39w.normal.background = this.zMIcUYtZWja.normal.background;
																									if (254308 - 419430 == -165122)
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

	// Token: 0x060062A5 RID: 25253 RVA: 0x00DAB940 File Offset: 0x00DA9B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetQuestList()
	{
	}

	// Token: 0x060062A6 RID: 25254 RVA: 0x00DAB944 File Offset: 0x00DA9B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderQuestList(bool isButton)
	{
		if (39997 - 98409 != -58411)
		{
		}
		do
		{
			IL_280:
			if (PlayerData.QuestList != null)
			{
				if (280713 - 453579 == -172865)
				{
					continue;
				}
				if (Extensions.get_length(PlayerData.QuestList) == 0)
				{
					if (129479 - 501970 == -372490)
					{
						continue;
					}
				}
				else
				{
					int i = 0;
					if (100333 - 225275 == -124941)
					{
						continue;
					}
					while (i < Extensions.get_length(PlayerData.QuestList))
					{
						QuestClass data = QuestData.getData(Mathf.Abs(PlayerData.QuestList[i]));
						if (217075 - 67760 != 149315)
						{
							goto IL_280;
						}
						if (data.name != "none")
						{
							if (199898 - 575065 != -375167)
							{
								goto IL_280;
							}
							if (this.mn3cUCYdLDL == PlayerData.QuestList[i])
							{
								if (121125 - 260010 != -138885)
								{
									goto IL_280;
								}
								GUI.Label(new Rect((float)234, (float)(170 + 60 * i), (float)270, (float)30), "#" + Mathf.Abs(PlayerData.QuestList[i]) + "  " + data.name, this.kiicU3yBneP);
								if (105878 - 524102 == -418223)
								{
									goto IL_280;
								}
								GUI.Label(new Rect((float)245, (float)(200 + 60 * i), (float)270, (float)30), "  Requested by: " + data.requester, this.FUDcUgiu54L);
								if (295484 - 253558 == 41927)
								{
									goto IL_280;
								}
							}
							else
							{
								if (this.mState != eTownQuestState.complete)
								{
									if (98969 - 307980 == -209010)
									{
										goto IL_280;
									}
									if (PlayerData.QuestID != 0)
									{
										if (165928 - 286270 != -120342)
										{
											goto IL_280;
										}
									}
									else
									{
										if (GUI.Button(new Rect((float)234, (float)(170 + 60 * i), (float)270, (float)30), "#" + Mathf.Abs(PlayerData.QuestList[i]) + "  " + data.name, this.zMIcUYtZWja))
										{
											if (97611 - 551765 == -454153)
											{
												goto IL_280;
											}
											if (isButton)
											{
												if (26469 - 70428 == -43958)
												{
													goto IL_280;
												}
												this.mn3cUCYdLDL = PlayerData.QuestList[i];
												if (165704 - 96862 != 68842)
												{
													goto IL_280;
												}
												this.ResetQuestDes();
												if (180603 - 82193 == 98411)
												{
													goto IL_280;
												}
												this.audio.PlayOneShot(this.xhHcwzwSx9l);
												if (66131 - 173083 != -106952)
												{
													goto IL_280;
												}
											}
										}
										GUI.Label(new Rect((float)245, (float)(200 + 60 * i), (float)270, (float)30), "  Requested by: " + data.requester, this.FUDcUgiu54L);
										if (118469 - 98144 != 20325)
										{
											goto IL_280;
										}
										goto IL_14D;
									}
								}
								GUI.Label(new Rect((float)234, (float)(170 + 60 * i), (float)270, (float)30), "#" + Mathf.Abs(PlayerData.QuestList[i]) + "  " + data.name, this.dSycUdWW39w);
								if (221175 - 328182 != -107007)
								{
									goto IL_280;
								}
								GUI.Label(new Rect((float)245, (float)(200 + 60 * i), (float)270, (float)30), "  Requested by: " + data.requester, this.dSycUdWW39w);
								if (246007 - 321492 != -75485)
								{
									goto IL_280;
								}
							}
							IL_14D:
							if (PlayerData.QuestList[i] > 0)
							{
								if (292911 - 218960 != 73951)
								{
									goto IL_280;
								}
								GUI.DrawTexture(new Rect((float)238, (float)(207 + i * 60), (float)16, (float)16), this.Xp2cUTGVVVi);
								if (218587 - 507396 != -288809)
								{
									goto IL_280;
								}
							}
						}
						i++;
						if (234732 - 178044 != 56688)
						{
							goto IL_280;
						}
					}
					if (268650 - 219334 != 49317)
					{
						break;
					}
					continue;
				}
			}
			GUI.Label(new Rect((float)234, (float)170, (float)270, (float)30), "no quest currently available", this.zMIcUYtZWja);
		}
		while (28590 - 366832 == -338241);
	}

	// Token: 0x060062A7 RID: 25255 RVA: 0x00DABEB0 File Offset: 0x00DAA0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitQuestDes()
	{
		if (269447 - 146648 != 122800)
		{
		}
		for (;;)
		{
			this.pTCcULrHYrq = new string[6];
			if (6190 - 330349 == -324159)
			{
				this.PJYcUwjEq5Q = new int[6];
				if (265123 - 389013 != -123889)
				{
					this.d1HcUNl2PSC = new Texture[6];
					if (241895 - 462257 == -220362)
					{
						this.EAecUUGWw0H = new bool[6];
						if (193024 - 142151 == 50873)
						{
							this.d5OcUEUWDD2 = new HoverButtonClass[6];
							if (143047 - 246610 != -103562)
							{
								this.GtucUPWX25g = new string[6];
								if (285512 - 977 != 284536)
								{
									this.CiqcUSsDHFs = new int[6];
									if (32722 - 565066 == -532344)
									{
										this.kD9cUBUOk7U = new Texture[6];
										if (224947 - 464412 == -239465)
										{
											this.DKMcU0FTJhj = new HoverButtonClass[6];
											if (275457 - 579003 == -303546)
											{
												this.H0EcUZ2kM59 = new GUIStyle();
												if (95842 - 484130 != -388287)
												{
													this.H0EcUZ2kM59.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
													if (264118 - 581614 != -317495)
													{
														this.H0EcUZ2kM59.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
														if (176359 - 287977 != -111617)
														{
															this.H0EcUZ2kM59.wordWrap = true;
															if (294299 - 370534 == -76235)
															{
																this.jtxcU7HFwof = (Texture)Resources.Load("GameGui/QuestWindow/stamp", typeof(Texture));
																if (17531 - 533063 != -515531)
																{
																	this.HDEcU8dZkqC = new GUIStyle();
																	if (36133 - 446942 == -410809)
																	{
																		this.HDEcU8dZkqC.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_accept", typeof(Texture)));
																		if (218808 - 35269 == 183539)
																		{
																			this.HDEcU8dZkqC.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_accept_h", typeof(Texture)));
																			if (129439 - 261974 != -132534)
																			{
																				this.HFacUiKMGVE = new GUIStyle();
																				if (221544 - 281243 != -59698)
																				{
																					this.HFacUiKMGVE.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_cancel", typeof(Texture)));
																					if (223756 - 249514 != -25757)
																					{
																						this.HFacUiKMGVE.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_cancel_h", typeof(Texture)));
																						if (17079 - 120551 == -103472)
																						{
																							this.gtNcUDwHKRQ = new GUIStyle();
																							if (105516 - 479028 == -373512)
																							{
																								this.gtNcUDwHKRQ.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_getReward", typeof(Texture)));
																								if (38217 - 97186 == -58969)
																								{
																									this.gtNcUDwHKRQ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_getReward_h", typeof(Texture)));
																									if (188161 - 237378 == -49217)
																									{
																										this.RLNcUmEd3Bf = new GUIStyle();
																										if (22029 - 115099 == -93070)
																										{
																											this.RLNcUmEd3Bf.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																											if (92090 - 147427 != -55336)
																											{
																												this.RLNcUmEd3Bf.normal.textColor = new Color(0.63f, 0.98f, (float)1, (float)1);
																												if (3157 - 540763 == -537606)
																												{
																													this.RLNcUmEd3Bf.alignment = TextAnchor.UpperLeft;
																													if (136418 - 583932 == -447514)
																													{
																														this.RLNcUmEd3Bf.wordWrap = true;
																														if (270619 - 515447 == -244828)
																														{
																															this.kupcUjDif8h = new GUIStyle();
																															if (104197 - 488871 != -384673)
																															{
																																this.kupcUjDif8h.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																if (19191 - 63953 != -44761)
																																{
																																	this.kupcUjDif8h.normal.textColor = new Color(0.99f, 0.45f, 0.42f, (float)1);
																																	if (121289 - 269003 != -147713)
																																	{
																																		this.kupcUjDif8h.alignment = TextAnchor.UpperLeft;
																																		if (244008 - 427362 != -183353)
																																		{
																																			this.kupcUjDif8h.wordWrap = true;
																																			if (156939 - 339256 == -182317)
																																			{
																																				this.q5FcUoKVSIB = new GUIStyle();
																																				if (150944 - 238517 == -87573)
																																				{
																																					this.q5FcUoKVSIB.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																					if (216703 - 177487 != 39217)
																																					{
																																						this.q5FcUoKVSIB.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																																						if (162389 - 258359 != -95969)
																																						{
																																							this.q5FcUoKVSIB.alignment = TextAnchor.UpperLeft;
																																							if (216828 - 389218 == -172390)
																																							{
																																								this.q5FcUoKVSIB.wordWrap = true;
																																								if (48699 - 392342 != -343642)
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

	// Token: 0x060062A8 RID: 25256 RVA: 0x00DAC628 File Offset: 0x00DAA828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetQuestDes()
	{
		if (177381 - 498039 != -320658)
		{
		}
		IL_76D:
		while (!(PlayerData.QuestList == null))
		{
			if (268513 - 370315 == -101802)
			{
				if (Extensions.get_length(PlayerData.QuestList) == 0)
				{
					if (279957 - 14815 == 265142)
					{
						break;
					}
				}
				else
				{
					this.L6dcU4mUmxN = QuestData.getData(Mathf.Abs(this.mn3cUCYdLDL));
					if (65468 - 574612 == -509144)
					{
						this.nbecUaIyQXA = (Texture)Resources.Load("GameGui/QuestImage/" + this.L6dcU4mUmxN.img, typeof(Texture));
						if (150931 - 211919 != -60987)
						{
							this.siccUHNmmEO = true;
							if (20427 - 475567 == -455140)
							{
								string[] array = null;
								if (134838 - 37544 == 97294)
								{
									string[] array2 = null;
									if (98111 - 220542 == -122431)
									{
										if (this.mn3cUCYdLDL == 0)
										{
											if (160038 - 73087 == 86952)
											{
												continue;
											}
											this.siccUHNmmEO = false;
											if (109865 - 216298 != -106433)
											{
												continue;
											}
										}
										else if (this.mn3cUCYdLDL > 0)
										{
											if (207385 - 558581 == -351195)
											{
												continue;
											}
											if (PlayerData.QuestState < this.L6dcU4mUmxN.completeState)
											{
												if (240380 - 455793 != -215413)
												{
													continue;
												}
												this.siccUHNmmEO = false;
												if (221887 - 335629 != -113742)
												{
													continue;
												}
											}
											if (this.L6dcU4mUmxN.request != "none")
											{
												if (284395 - 336062 != -51667)
												{
													continue;
												}
												array = (string[])Stringf.splitToArray(this.L6dcU4mUmxN.request, ",").ToBuiltin(typeof(string));
												if (258619 - 203381 != 55238)
												{
													continue;
												}
											}
											if (this.L6dcU4mUmxN.reward != "none")
											{
												if (191495 - 599977 != -408482)
												{
													continue;
												}
												array2 = (string[])Stringf.splitToArray(this.L6dcU4mUmxN.reward, ",").ToBuiltin(typeof(string));
												if (264190 - 16483 != 247707)
												{
													continue;
												}
											}
										}
										else if (this.mn3cUCYdLDL < 0)
										{
											if (191209 - 471169 == -279959)
											{
												continue;
											}
											if (PlayerData.QuestState < this.L6dcU4mUmxN.completeState2)
											{
												if (293937 - 25240 != 268697)
												{
													continue;
												}
												this.siccUHNmmEO = false;
												if (214045 - 490856 != -276811)
												{
													continue;
												}
											}
											if (this.L6dcU4mUmxN.request2 != "none")
											{
												if (204731 - 108549 != 96182)
												{
													continue;
												}
												array = (string[])Stringf.splitToArray(this.L6dcU4mUmxN.request2, ",").ToBuiltin(typeof(string));
												if (211120 - 436690 != -225570)
												{
													continue;
												}
											}
											if (this.L6dcU4mUmxN.reward2 != "none")
											{
												if (290326 - 7342 == 282985)
												{
													continue;
												}
												array2 = (string[])Stringf.splitToArray(this.L6dcU4mUmxN.reward2, ",").ToBuiltin(typeof(string));
												if (37619 - 77480 == -39860)
												{
													continue;
												}
											}
										}
										int i = 0;
										if (65171 - 466967 != -401795)
										{
											while (i < 6)
											{
												this.d5OcUEUWDD2[i] = new HoverButtonClass();
												if (182985 - 182481 != 504)
												{
													goto IL_76D;
												}
												if (array == null)
												{
													goto IL_585;
												}
												if (194094 - 50648 == 143447)
												{
													goto IL_76D;
												}
												if (Extensions.get_length(array) <= i)
												{
													goto IL_585;
												}
												if (222080 - 67759 != 154321)
												{
													goto IL_76D;
												}
												if (!(array[i] != "none"))
												{
													goto IL_585;
												}
												if (127435 - 454380 != -326945)
												{
													goto IL_76D;
												}
												string[] array3 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
												if (8788 - 374537 != -365749)
												{
													goto IL_76D;
												}
												this.pTCcULrHYrq[i] = array3[0];
												if (27851 - 561312 != -533461)
												{
													goto IL_76D;
												}
												if (Extensions.get_length(array3) > 1)
												{
													if (778 - 125222 == -124443)
													{
														goto IL_76D;
													}
													this.PJYcUwjEq5Q[i] = Stringf.getInteger(array3[1]);
													if (169841 - 452834 == -282992)
													{
														goto IL_76D;
													}
												}
												else
												{
													this.PJYcUwjEq5Q[i] = 1;
													if (213373 - 197702 != 15671)
													{
														goto IL_76D;
													}
												}
												if (CharacterData.current.getItemTotalNum(this.pTCcULrHYrq[i]) >= this.PJYcUwjEq5Q[i])
												{
													if (161358 - 373383 == -212024)
													{
														goto IL_76D;
													}
													this.EAecUUGWw0H[i] = true;
													if (143858 - 290160 == -146301)
													{
														goto IL_76D;
													}
												}
												else
												{
													this.EAecUUGWw0H[i] = false;
													if (42466 - 181108 != -138642)
													{
														goto IL_76D;
													}
													this.siccUHNmmEO = false;
													if (236533 - 25338 == 211196)
													{
														goto IL_76D;
													}
												}
												this.d1HcUNl2PSC[i] = IconButton.getIconImage(this.pTCcULrHYrq[i]);
												if (158641 - 569449 == -410807)
												{
													goto IL_76D;
												}
												IL_302:
												this.DKMcU0FTJhj[i] = new HoverButtonClass();
												if (294325 - 497937 != -203612)
												{
													goto IL_76D;
												}
												if (array2 == null)
												{
													goto IL_119;
												}
												if (271011 - 223179 == 47833)
												{
													goto IL_76D;
												}
												if (Extensions.get_length(array2) <= i)
												{
													goto IL_119;
												}
												if (299726 - 6433 == 293294)
												{
													goto IL_76D;
												}
												if (!(array2[i] != "none"))
												{
													goto IL_119;
												}
												if (68213 - 541405 != -473192)
												{
													goto IL_76D;
												}
												string[] array4 = (string[])Stringf.splitToArray(array2[i], "%").ToBuiltin(typeof(string));
												if (193316 - 126194 == 67123)
												{
													goto IL_76D;
												}
												this.GtucUPWX25g[i] = array4[0];
												if (32468 - 24805 == 7664)
												{
													goto IL_76D;
												}
												if (Extensions.get_length(array4) > 1)
												{
													if (198129 - 47738 != 150391)
													{
														goto IL_76D;
													}
													this.CiqcUSsDHFs[i] = Stringf.getInteger(array4[1]);
													if (144571 - 158959 != -14388)
													{
														goto IL_76D;
													}
												}
												else
												{
													this.CiqcUSsDHFs[i] = 1;
													if (202585 - 92053 != 110532)
													{
														goto IL_76D;
													}
												}
												this.kD9cUBUOk7U[i] = IconButton.getIconImage(this.GtucUPWX25g[i]);
												if (73747 - 248177 != -174430)
												{
													goto IL_76D;
												}
												IL_53D:
												i++;
												if (31654 - 159022 != -127367)
												{
													continue;
												}
												goto IL_76D;
												IL_119:
												this.GtucUPWX25g[i] = "none";
												if (99759 - 60743 == 39017)
												{
													goto IL_76D;
												}
												this.CiqcUSsDHFs[i] = 0;
												if (148023 - 104306 == 43718)
												{
													goto IL_76D;
												}
												this.kD9cUBUOk7U[i] = null;
												if (255249 - 89604 != 165646)
												{
													goto IL_53D;
												}
												goto IL_76D;
												IL_585:
												this.pTCcULrHYrq[i] = "none";
												if (42388 - 224636 != -182248)
												{
													goto IL_76D;
												}
												this.PJYcUwjEq5Q[i] = 0;
												if (143941 - 302 == 143640)
												{
													goto IL_76D;
												}
												this.EAecUUGWw0H[i] = false;
												if (49049 - 563978 != -514929)
												{
													goto IL_76D;
												}
												this.d1HcUNl2PSC[i] = null;
												if (209855 - 179844 != 30011)
												{
													goto IL_76D;
												}
												goto IL_302;
											}
											if (40864 - 79096 == -38232)
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
	}

	// Token: 0x060062A9 RID: 25257 RVA: 0x00DAD01C File Offset: 0x00DAB21C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RenderTownQuestDes()
	{
		return new QuestGui.$RenderTownQuestDes$36333(this).GetEnumerator();
	}

	// Token: 0x060062AA RID: 25258 RVA: 0x00DAD02C File Offset: 0x00DAB22C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitQuestRecord()
	{
		if (61671 - 378965 != -317294)
		{
		}
		for (;;)
		{
			this.vxocUk1aR7R = new GUIStyle();
			if (29364 - 110049 != -80684)
			{
				this.vxocUk1aR7R.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
				if (163354 - 538868 != -375513)
				{
					this.vxocUk1aR7R.alignment = TextAnchor.MiddleRight;
					if (174298 - 125302 != 48997)
					{
						this.vxocUk1aR7R.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (287707 - 300185 == -12478)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062AB RID: 25259 RVA: 0x00DAD130 File Offset: 0x00DAB330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetQuestRecord()
	{
		this.zXVcUFpOft2 = PlayerData.QuestTotal;
		this.sKWcUAIUmkV = PlayerData.QuestHighest;
	}

	// Token: 0x060062AC RID: 25260 RVA: 0x00DAD148 File Offset: 0x00DAB348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderQuestRecord()
	{
		if (117435 - 539084 != -421648)
		{
		}
		for (;;)
		{
			if (this.mn3cUCYdLDL != 0)
			{
				if (34954 - 470908 == -435953)
				{
					continue;
				}
				Guix.renderSmallNumber(466, 726, Mathf.Abs(this.mn3cUCYdLDL), false, 1f);
				if (74289 - 442920 == -368630)
				{
					continue;
				}
			}
			GUI.Label(new Rect((float)270, (float)798, (float)210, (float)35), string.Empty + this.zXVcUFpOft2, this.vxocUk1aR7R);
			if (247986 - 477880 != -229893)
			{
				GUI.Label(new Rect((float)270, (float)832, (float)210, (float)35), string.Empty + this.sKWcUAIUmkV, this.vxocUk1aR7R);
				if (242611 - 579477 == -336866)
				{
					Guix.renderRankNumber(450, 915, 1, 1f);
					if (220137 - 186938 != 33200)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060062AD RID: 25261 RVA: 0x00DAD2B8 File Offset: 0x00DAB4B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitQuestComplete()
	{
		if (249253 - 556378 != -307125)
		{
		}
		for (;;)
		{
			IL_ED:
			this.haxcUW95Dlu = (Texture)Resources.Load("GameGui/QuestWindow/rewardBar", typeof(Texture));
			if (52167 - 251219 == -199052)
			{
				this.HhWcUudmsPF = (Texture)Resources.Load("GameGui/QuestWindow/levelUp", typeof(Texture));
				if (222842 - 419143 == -196301)
				{
					this.AGHcUybgeE6 = new GUIStyle();
					if (14568 - 575951 == -561383)
					{
						this.AGHcUybgeE6.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_getall_h", typeof(Texture)));
						if (79756 - 142431 == -62675)
						{
							this.FaLcUVZrBPA = new GUIStyle();
							if (33492 - 108854 != -75361)
							{
								this.FaLcUVZrBPA.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/QuestWindow/button_finish_h", typeof(Texture)));
								if (79751 - 589641 != -509889)
								{
									this.XILcN58VZMO = new InventoryClass[6];
									if (207766 - 363785 != -156018)
									{
										this.NBacNcwbKnL = new Texture[6];
										if (186610 - 273330 == -86720)
										{
											this.aYccNnc8nKW = new HoverButtonClass[6];
											if (165124 - 595960 != -430835)
											{
												int i = 0;
												if (286666 - 134807 != 151860)
												{
													while (i < 6)
													{
														this.XILcN58VZMO[i] = new InventoryClass();
														if (217391 - 422188 != -204797)
														{
															goto IL_ED;
														}
														this.aYccNnc8nKW[i] = new HoverButtonClass();
														if (182369 - 105858 != 76511)
														{
															goto IL_ED;
														}
														i++;
														if (289986 - 351268 != -61282)
														{
															goto IL_ED;
														}
													}
													if (243161 - 369940 == -126779)
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

	// Token: 0x060062AE RID: 25262 RVA: 0x00DAD55C File Offset: 0x00DAB75C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetQuestComplete()
	{
		if (291625 - 261070 != 30555)
		{
		}
		for (;;)
		{
			IL_A6:
			this.pGycU9p9KUQ = (Texture)Resources.Load("GameGui/Icons/Heroes/" + CharacterData.current.Type + Mathf.FloorToInt((float)(CharacterData.current.Skin / 100)), typeof(Texture));
			if (25888 - 137086 == -111198)
			{
				this.scScUKdRkRa = 0;
				if (186857 - 120966 != 65892)
				{
					this.oEecUzkusRc = 0;
					if (198978 - 399531 == -200553)
					{
						int i = 0;
						if (144177 - 320897 != -176719)
						{
							while (i < 6)
							{
								this.XILcN58VZMO[i] = new InventoryClass();
								if (194463 - 374454 != -179991)
								{
									goto IL_A6;
								}
								this.NBacNcwbKnL[i] = null;
								if (266266 - 484099 == -217832)
								{
									goto IL_A6;
								}
								this.aYccNnc8nKW[i].state = eHoverButtonState.none;
								if (210497 - 535085 == -324587)
								{
									goto IL_A6;
								}
								i++;
								if (113845 - 106087 == 7759)
								{
									goto IL_A6;
								}
							}
							if (205638 - 527188 == -321550)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062AF RID: 25263 RVA: 0x00DAD710 File Offset: 0x00DAB910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReadQuestComplete(Hashtable data)
	{
		if (199560 - 196659 != 2901)
		{
		}
		for (;;)
		{
			IL_2D5:
			this.imKcUhJCJT0 = RuntimeServices.UnboxInt32(data[50]);
			if (207093 - 184393 == 22700)
			{
				this.scScUKdRkRa = RuntimeServices.UnboxInt32(data[32]);
				if (228493 - 418965 != -190471)
				{
					this.oEecUzkusRc = RuntimeServices.UnboxInt32(data[33]);
					if (6887 - 70689 == -63802)
					{
						PlayerData.Gil += this.oEecUzkusRc;
						if (174509 - 349960 == -175451)
						{
							object obj2;
							object obj = obj2 = data[34];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							string text = (string)obj2;
							if (294821 - 149522 == 145299)
							{
								if (text != "0")
								{
									if (222423 - 533062 == -310638)
									{
										continue;
									}
									string[] array = (string[])Stringf.splitToArray(text, ",").ToBuiltin(typeof(string));
									if (163523 - 224103 != -60580)
									{
										continue;
									}
									int i = 0;
									if (57642 - 545961 == -488318)
									{
										continue;
									}
									while (i < Extensions.get_length(array))
									{
										Debug.Log("Got " + array[i]);
										if (253632 - 244548 == 9085)
										{
											goto IL_2D5;
										}
										this.XILcN58VZMO[i].readData(array[i]);
										if (240055 - 230811 == 9245)
										{
											goto IL_2D5;
										}
										this.NBacNcwbKnL[i] = IconButton.getIconImage(this.XILcN58VZMO[i].name);
										if (106944 - 188394 != -81450)
										{
											goto IL_2D5;
										}
										if (this.NBacNcwbKnL[i] == null)
										{
											if (285757 - 440510 != -154753)
											{
												goto IL_2D5;
											}
											Debug.Log("Cannot find Icon");
											if (226737 - 579797 != -353060)
											{
												goto IL_2D5;
											}
										}
										i++;
										if (122845 - 267862 != -145017)
										{
											goto IL_2D5;
										}
									}
									if (30832 - 555156 != -524324)
									{
										continue;
									}
								}
								Debug.Log("Recieved : " + this.scScUKdRkRa + " exp and " + this.oEecUzkusRc + " gil");
								if (228663 - 380079 == -151416)
								{
									int j = 0;
									if (71394 - 593967 == -522573)
									{
										while (j < 6)
										{
											if (this.pTCcULrHYrq[j] != "none")
											{
												if (56897 - 261680 == -204782)
												{
													goto IL_2D5;
												}
												CharacterData.current.removeInventory(this.pTCcULrHYrq[j], this.PJYcUwjEq5Q[j]);
												if (193737 - 584873 != -391136)
												{
													goto IL_2D5;
												}
											}
											j++;
											if (157200 - 427888 != -270688)
											{
												goto IL_2D5;
											}
										}
										if (101454 - 579951 != -478496)
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

	// Token: 0x060062B0 RID: 25264 RVA: 0x00DADB14 File Offset: 0x00DABD14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderQuestComplete()
	{
		if (133591 - 94618 != 38973)
		{
		}
		for (;;)
		{
			IL_44:
			if (this.pGycU9p9KUQ)
			{
				if (298910 - 269413 == 29498)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)610, (float)168, (float)75, (float)75), this.pGycU9p9KUQ);
				if (276885 - 365698 != -88813)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)682, (float)210, (float)184, (float)11), this.haxcUW95Dlu);
				if (236516 - 55085 == 181432)
				{
					continue;
				}
				Guix.renderSmallNumber(736, 179, CharacterData.current.lv, true, (float)1);
				if (248134 - 310373 != -62239)
				{
					continue;
				}
			}
			int i = 0;
			if (55745 - 43189 == 12556)
			{
				while (i < 6)
				{
					if (this.XILcN58VZMO[i].name != "none")
					{
						if (21537 - 418985 != -397448)
						{
							goto IL_44;
						}
						if (this.NBacNcwbKnL[i])
						{
							if (99443 - 153041 != -53598)
							{
								goto IL_44;
							}
							GUI.DrawTexture(new Rect((float)(604 + i * 60), (float)352, (float)64, (float)64), this.NBacNcwbKnL[i]);
							if (289280 - 298329 != -9049)
							{
								goto IL_44;
							}
						}
						if (this.XILcN58VZMO[i].num > 1)
						{
							if (12012 - 108346 == -96333)
							{
								goto IL_44;
							}
							GUI.DrawTexture(new Rect((float)(604 + i * 60 + 38), (float)391, (float)24, (float)24), this.mpacNJ4gVhn);
							if (97321 - 209802 == -112480)
							{
								goto IL_44;
							}
							GUI.Label(new Rect((float)(604 + i * 60 + 34), (float)384, (float)32, (float)32), string.Empty + this.XILcN58VZMO[i].num, this.EF0cNXXMxr3);
							if (176344 - 386303 != -209959)
							{
								goto IL_44;
							}
						}
						if (Time.time > this.QqLcwjYj8FX)
						{
							if (167362 - 483151 != -315789)
							{
								goto IL_44;
							}
							eHoverButtonState eHoverButtonState = HoverButton.newButton(this.aYccNnc8nKW[i], new Rect((float)(611 + i * 60), (float)359, (float)50, (float)50), (float)0);
							if (242329 - 468461 != -226132)
							{
								goto IL_44;
							}
							if (eHoverButtonState == eHoverButtonState.hover)
							{
								if (47403 - 401828 != -354424)
								{
									goto IL_BBC;
								}
								goto IL_44;
							}
							else if (eHoverButtonState == eHoverButtonState.over)
							{
								if (226909 - 268579 != -41669)
								{
									goto IL_BBC;
								}
								goto IL_44;
							}
							else if (eHoverButtonState == eHoverButtonState.press)
							{
								if (67546 - 342822 != -275276)
								{
									goto IL_44;
								}
								if (Time.time > this.QqLcwjYj8FX)
								{
									if (186334 - 438171 != -251837)
									{
										goto IL_44;
									}
									this.QqLcwjYj8FX = Time.time + (float)1;
									if (69897 - 412096 == -342198)
									{
										goto IL_44;
									}
									if (CharacterData.current.getEmptyInventoryCount() == 0)
									{
										if (205541 - 449148 != -243607)
										{
											goto IL_44;
										}
										this.newNoticeBar("Not enough slot!", 1f);
										if (240445 - 177738 != 62707)
										{
											goto IL_44;
										}
									}
									else
									{
										string text = this.XILcN58VZMO[i].name;
										if (205931 - 45760 != 160171)
										{
											goto IL_44;
										}
										if (this.XILcN58VZMO[i].num > 1)
										{
											if (81652 - 134452 != -52800)
											{
												goto IL_44;
											}
											text += "%" + this.XILcN58VZMO[i].num;
											if (272705 - 459452 == -186746)
											{
												goto IL_44;
											}
										}
										this.XILcN58VZMO[i].reset();
										if (83469 - 10725 == 72745)
										{
											goto IL_44;
										}
										this.NBacNcwbKnL[i] = null;
										if (272099 - 298678 != -26579)
										{
											goto IL_44;
										}
										this.newNoticeBar("Processing...", 1f);
										if (209043 - 492371 != -283328)
										{
											goto IL_44;
										}
										this.QuestGetReward(text);
										if (244338 - 266918 != -22580)
										{
											goto IL_44;
										}
									}
								}
							}
							goto IL_B55;
							IL_BBC:
							GUI.DrawTexture(new Rect((float)(604 + i * 60 + 7), (float)359, (float)51, (float)51), this.ERTcNemP1Eh);
							if (1701 - 473350 == -471648)
							{
								goto IL_44;
							}
							this.QbwcNOrKIRj = ItemData.getName(this.XILcN58VZMO[i].name);
							if (256296 - 160303 == 95994)
							{
								goto IL_44;
							}
							this.ctvcN20Yrgs = new Rect((float)(550 + i * 60), (float)800, (float)180, (float)30);
							if (191166 - 522648 == -331481)
							{
								goto IL_44;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)(604 + i * 60 + 7), (float)359, (float)51, (float)51), this.umccNIYuFEr);
							if (272764 - 144212 == 128553)
							{
								goto IL_44;
							}
						}
					}
					IL_B55:
					i++;
					if (18708 - 572261 == -553552)
					{
						goto IL_44;
					}
				}
				if (20346 - 395753 == -375407)
				{
					Guix.renderSmallNumber(650, 292, this.oEecUzkusRc, true, (float)1);
					if (113892 - 349184 != -235291)
					{
						Guix.renderSmallNumber(840, 292, this.scScUKdRkRa, true, (float)1);
						if (266377 - 6621 == 259756)
						{
							if (GUI.Button(new Rect((float)837, (float)454, (float)101, (float)36), string.Empty, this.AGHcUybgeE6))
							{
								if (113585 - 586519 == -472933)
								{
									continue;
								}
								if (Time.time > this.QqLcwjYj8FX)
								{
									if (154649 - 324492 == -169842)
									{
										continue;
									}
									this.QqLcwjYj8FX = Time.time + (float)1;
									if (9387 - 125803 != -116416)
									{
										continue;
									}
									string text2 = string.Empty;
									if (289648 - 548999 == -259350)
									{
										continue;
									}
									int num = 0;
									if (183870 - 146661 != 37209)
									{
										continue;
									}
									int j = 0;
									if (82883 - 531353 == -448469)
									{
										continue;
									}
									while (j < 6)
									{
										if (this.XILcN58VZMO[j].name != string.Empty)
										{
											if (188963 - 128580 == 60384)
											{
												goto IL_44;
											}
											if (this.XILcN58VZMO[j].name != "none")
											{
												if (296487 - 376735 == -80247)
												{
													goto IL_44;
												}
												if (text2 != string.Empty)
												{
													if (240424 - 122123 == 118302)
													{
														goto IL_44;
													}
													text2 += ",";
													if (91175 - 481778 == -390602)
													{
														goto IL_44;
													}
												}
												text2 += this.XILcN58VZMO[j].name;
												if (146362 - 219587 == -73224)
												{
													goto IL_44;
												}
												if (this.XILcN58VZMO[j].num > 1)
												{
													if (218563 - 553786 != -335223)
													{
														goto IL_44;
													}
													text2 += "%" + this.XILcN58VZMO[j].num;
													if (198282 - 7118 == 191165)
													{
														goto IL_44;
													}
												}
												else
												{
													text2 += "%1";
													if (110799 - 254524 != -143725)
													{
														goto IL_44;
													}
												}
												num++;
												if (2493 - 146435 == -143941)
												{
													goto IL_44;
												}
											}
										}
										j++;
										if (38556 - 89445 != -50889)
										{
											goto IL_44;
										}
									}
									if (207804 - 385081 != -177277)
									{
										continue;
									}
									if (CharacterData.current.getEmptyInventoryCount() < num)
									{
										if (26144 - 138540 != -112396)
										{
											continue;
										}
										this.newNoticeBar("Not enough slot!", 1f);
										if (102348 - 137452 != -35104)
										{
											continue;
										}
									}
									else if (text2 != string.Empty)
									{
										if (176043 - 268150 != -92107)
										{
											continue;
										}
										this.newNoticeBar("Processing...", 1f);
										if (90262 - 41525 == 48738)
										{
											continue;
										}
										this.QuestGetReward(text2);
										if (116404 - 70762 == 45643)
										{
											continue;
										}
										int k = 0;
										if (231530 - 4453 != 227077)
										{
											continue;
										}
										while (k < 6)
										{
											this.XILcN58VZMO[k].reset();
											if (21284 - 155805 != -134521)
											{
												goto IL_44;
											}
											k++;
											if (111256 - 4470 == 106787)
											{
												goto IL_44;
											}
										}
										if (85967 - 349037 != -263070)
										{
											continue;
										}
									}
								}
							}
							if (!GUI.Button(new Rect((float)734, (float)911, (float)114, (float)41), string.Empty, this.FaLcUVZrBPA))
							{
								break;
							}
							if (150010 - 51586 == 98424)
							{
								if (this.srwcUJ28PLX)
								{
									if (151030 - 45190 != 105840)
									{
										continue;
									}
									this.srwcUJ28PLX.animation.CrossFade("talk");
									if (74507 - 428040 == -353532)
									{
										continue;
									}
								}
								this.mState = eTownQuestState.close;
								if (291975 - 236049 == 55926)
								{
									this.vfLcwm4xtys = Time.time;
									if (65781 - 577037 == -511256)
									{
										this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
										if (34690 - 122930 != -88239)
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

	// Token: 0x060062B1 RID: 25265 RVA: 0x00DAE760 File Offset: 0x00DAC960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReadQuestGetReward(string inventoryString)
	{
		if (182763 - 532230 != -349466)
		{
		}
		for (;;)
		{
			IL_100:
			string[] array = (string[])Stringf.splitToArray(inventoryString, ",").ToBuiltin(typeof(string));
			if (135341 - 150164 != -14822)
			{
				int i = 0;
				if (207787 - 106882 != 100906)
				{
					while (i < Extensions.get_length(array))
					{
						InventoryClass inventoryClass = new InventoryClass();
						if (3189 - 482390 != -479201)
						{
							goto IL_100;
						}
						inventoryClass.readData(array[i]);
						if (26285 - 493694 == -467408)
						{
							goto IL_100;
						}
						if (inventoryClass.name != "none")
						{
							if (21697 - 275651 != -253954)
							{
								goto IL_100;
							}
							if (inventoryClass.slot != -1)
							{
								if (278935 - 531060 != -252125)
								{
									goto IL_100;
								}
								CharacterData.current.inventory[inventoryClass.slot] = inventoryClass;
								if (169896 - 180429 == -10532)
								{
									goto IL_100;
								}
							}
						}
						i++;
						if (138529 - 122172 == 16358)
						{
							goto IL_100;
						}
					}
					if (140726 - 447067 == -306341)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060062B2 RID: 25266 RVA: 0x00DAE8FC File Offset: 0x00DACAFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitQuestInventory()
	{
		if (189146 - 209777 != -20631)
		{
		}
		for (;;)
		{
			this.Nv3cNQjgHnf = new IconButtonClass[30];
			if (274498 - 276877 != -2378)
			{
				this.ERTcNemP1Eh = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover", typeof(Texture));
				if (172505 - 341743 != -169237)
				{
					this.umccNIYuFEr = (Texture)Resources.Load("GameGui/Icons/Common/Item_inactive", typeof(Texture));
					if (132590 - 151392 == -18802)
					{
						this.mpacNJ4gVhn = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
						if (285940 - 382247 == -96307)
						{
							this.gmgcN6Lc21k = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
							if (124764 - 364372 != -239607)
							{
								this.GVqcNtKXL2M = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
								if (263451 - 113431 == 150020)
								{
									this.EF0cNXXMxr3 = new GUIStyle();
									if (149539 - 525618 != -376078)
									{
										this.EF0cNXXMxr3.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
										if (215128 - 43095 == 172033)
										{
											this.EF0cNXXMxr3.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
											if (125430 - 154364 == -28934)
											{
												this.EF0cNXXMxr3.alignment = TextAnchor.MiddleCenter;
												if (117694 - 176421 != -58726)
												{
													this.O3ocNvLc6Bg = new GUIStyle();
													if (171372 - 305093 == -133721)
													{
														this.O3ocNvLc6Bg.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
														if (80983 - 114080 == -33097)
														{
															this.O3ocNvLc6Bg.alignment = TextAnchor.MiddleCenter;
															if (72422 - 376991 == -304569)
															{
																this.O3ocNvLc6Bg.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																if (98788 - 35232 == 63556)
																{
																	this.MgqcNlZV8Ds = new GUIStyle();
																	if (17180 - 149075 != -131894)
																	{
																		this.MgqcNlZV8Ds.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																		if (117387 - 80737 != 36651)
																		{
																			this.MgqcNlZV8Ds.alignment = TextAnchor.MiddleCenter;
																			if (212886 - 330897 == -118011)
																			{
																				this.MgqcNlZV8Ds.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																				if (284371 - 24573 != 259799)
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

	// Token: 0x060062B3 RID: 25267 RVA: 0x00DAECB8 File Offset: 0x00DACEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetQuestInventory()
	{
		if (282267 - 43385 != 238882)
		{
		}
		for (;;)
		{
			IL_E5:
			this.kXXcUMRqrGn = new ItemClass();
			if (189928 - 378173 != -188244)
			{
				int i = 0;
				if (39090 - 37995 == 1095)
				{
					while (i < 30)
					{
						this.Nv3cNQjgHnf[i] = new IconButtonClass();
						if (137371 - 320317 == -182945)
						{
							goto IL_E5;
						}
						if (CharacterData.current.inventory[i].name != "none")
						{
							if (278042 - 192357 == 85686)
							{
								goto IL_E5;
							}
							this.Nv3cNQjgHnf[i].name = CharacterData.current.inventory[i].name;
							if (204091 - 210299 != -6208)
							{
								goto IL_E5;
							}
							this.Nv3cNQjgHnf[i].command = i + 20;
							if (44283 - 472090 != -427807)
							{
								goto IL_E5;
							}
							this.Nv3cNQjgHnf[i].image = (Texture2D)IconButton.getCommandIcon(i + 20);
							if (232125 - 406242 == -174116)
							{
								goto IL_E5;
							}
						}
						i++;
						if (224382 - 518246 == -293863)
						{
							goto IL_E5;
						}
					}
					if (80491 - 143737 == -63246)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060062B4 RID: 25268 RVA: 0x00DAEE70 File Offset: 0x00DAD070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderQuestInventory()
	{
		if (71997 - 576850 != -504852)
		{
		}
		for (;;)
		{
			IL_4EE:
			this.QbwcNOrKIRj = "none";
			if (135333 - 486299 == -350966)
			{
				int i = 0;
				if (145699 - 561424 == -415725)
				{
					while (i < 30)
					{
						if (this.Nv3cNQjgHnf[i].name != "none")
						{
							if (243214 - 54727 != 188487)
							{
								goto IL_4EE;
							}
							Rect position = new Rect((float)602 + global::Math.mod((float)i, (float)6) * (float)60, (float)(525 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
							if (209234 - 86488 != 122746)
							{
								goto IL_4EE;
							}
							eIconButtonState eIconButtonState = IconButton.IconButton(this.Nv3cNQjgHnf[i], new Rect(position.x + (float)6, position.y + (float)6, (float)50, (float)50));
							if (171207 - 296484 != -125277)
							{
								goto IL_4EE;
							}
							eIconButtonState eIconButtonState2 = eIconButtonState;
							if (36524 - 170117 == -133592)
							{
								goto IL_4EE;
							}
							if (eIconButtonState2 == eIconButtonState.none)
							{
								if (192888 - 557733 == -364844)
								{
									goto IL_4EE;
								}
								GUI.DrawTexture(position, this.Nv3cNQjgHnf[i].image);
								if (223581 - 493600 == -270018)
								{
									goto IL_4EE;
								}
							}
							else
							{
								if (eIconButtonState2 == eIconButtonState.over)
								{
									if (159312 - 246826 != -87514)
									{
										goto IL_4EE;
									}
								}
								else if (eIconButtonState2 == eIconButtonState.hover)
								{
									if (234732 - 516829 == -282096)
									{
										goto IL_4EE;
									}
								}
								else if (eIconButtonState2 == eIconButtonState.press)
								{
									if (103763 - 261689 != -157926)
									{
										goto IL_4EE;
									}
									goto IL_44C;
								}
								else if (eIconButtonState2 == eIconButtonState.drag)
								{
									if (76861 - 160689 == -83827)
									{
										goto IL_4EE;
									}
									this.Nv3cNQjgHnf[i].state = eIconButtonState.none;
									if (139290 - 304011 != -164720)
									{
										if (this.Nv3cNQjgHnf[i].command != 0)
										{
											if (226714 - 196271 != 30443)
											{
												goto IL_4EE;
											}
											this.r4lcw9dSiEF = i + 20;
											if (117116 - 38623 == 78494)
											{
												goto IL_4EE;
											}
											this.kXXcUMRqrGn = ItemData.getItemData(this.Nv3cNQjgHnf[i].name);
											if (150125 - 226517 != -76392)
											{
												goto IL_4EE;
											}
											this.vqRcUfPpY4Z = CharacterData.current.inventory[i];
											if (280166 - 423256 != -143090)
											{
												goto IL_4EE;
											}
										}
										goto IL_44C;
									}
									goto IL_4EE;
								}
								else
								{
									if (eIconButtonState2 != eIconButtonState.drop)
									{
										goto IL_44C;
									}
									if (174186 - 527103 != -352917)
									{
										goto IL_4EE;
									}
									if (this.r4lcw9dSiEF >= 20)
									{
										if (35874 - 352812 != -316938)
										{
											goto IL_4EE;
										}
										if (this.r4lcw9dSiEF < 50)
										{
											if (224328 - 168377 == 55952)
											{
												goto IL_4EE;
											}
											CharacterData.current.swapInventory(i, this.r4lcw9dSiEF - 20);
											if (26750 - 455759 != -429009)
											{
												goto IL_4EE;
											}
											this.ResetQuestInventory();
											if (13688 - 303621 == -289932)
											{
												goto IL_4EE;
											}
											this.kXXcUMRqrGn = ItemData.getItemData(this.Nv3cNQjgHnf[i].name);
											if (83749 - 149893 != -66144)
											{
												goto IL_4EE;
											}
											this.vqRcUfPpY4Z = CharacterData.current.inventory[i];
											if (296286 - 732 != 295554)
											{
												goto IL_4EE;
											}
											if (this.xhHcwzwSx9l)
											{
												if (266677 - 431496 != -164819)
												{
													goto IL_4EE;
												}
												this.audio.PlayOneShot(this.xhHcwzwSx9l);
												if (237352 - 405212 != -167860)
												{
													goto IL_4EE;
												}
											}
										}
									}
									this.r4lcw9dSiEF = 0;
									if (231340 - 217364 != 13976)
									{
										goto IL_4EE;
									}
									goto IL_44C;
								}
								GUI.DrawTexture(position, this.Nv3cNQjgHnf[i].image);
								if (283533 - 172517 == 111017)
								{
									goto IL_4EE;
								}
								GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.ERTcNemP1Eh);
								if (134030 - 47576 != 86454)
								{
									goto IL_4EE;
								}
								if (this.r4lcw9dSiEF == 0)
								{
									if (142399 - 563719 != -421320)
									{
										goto IL_4EE;
									}
									this.QbwcNOrKIRj = ItemData.getName(CharacterData.current.inventory[i].name);
									if (61638 - 187860 != -126222)
									{
										goto IL_4EE;
									}
									if (CharacterData.current.inventory[i].mlv != 0)
									{
										if (243244 - 120641 != 122603)
										{
											goto IL_4EE;
										}
										this.QbwcNOrKIRj += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
										if (11099 - 174888 == -163788)
										{
											goto IL_4EE;
										}
									}
									this.ctvcN20Yrgs = new Rect(position.x - (float)120, position.y + (float)51, (float)300, (float)30);
									if (197844 - 240065 != -42221)
									{
										goto IL_4EE;
									}
								}
							}
							IL_44C:
							if (CharacterData.current.inventory[i].num > 1)
							{
								if (70831 - 413786 != -342955)
								{
									goto IL_4EE;
								}
								GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.mpacNJ4gVhn);
								if (209372 - 12636 == 196737)
								{
									goto IL_4EE;
								}
								GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.EF0cNXXMxr3);
								if (58535 - 492464 != -433929)
								{
									goto IL_4EE;
								}
							}
							else
							{
								string type = CharacterData.current.inventory[i].getType();
								if (241050 - 239423 != 1627)
								{
									goto IL_4EE;
								}
								if (!(type == "wep"))
								{
									if (266845 - 448849 == -182003)
									{
										goto IL_4EE;
									}
									if (!(type == "arm"))
									{
										if (46856 - 257143 != -210287)
										{
											goto IL_4EE;
										}
										if (!(type == "acc"))
										{
											if (217692 - 151701 != 65991)
											{
												goto IL_4EE;
											}
											if (!(type == "bot"))
											{
												if (36023 - 439124 != -403101)
												{
													goto IL_4EE;
												}
												if (!(type == "trn"))
												{
													if (196278 - 196415 == -136)
													{
														goto IL_4EE;
													}
													if (!(type == "pet"))
													{
														goto IL_4D0;
													}
													if (277428 - 388302 == -110873)
													{
														goto IL_4EE;
													}
												}
											}
										}
									}
								}
								if (CharacterData.current.inventory[i].owner == 0)
								{
									if (239007 - 485308 != -246301)
									{
										goto IL_4EE;
									}
									GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.gmgcN6Lc21k);
									if (213381 - 530112 == -316730)
									{
										goto IL_4EE;
									}
								}
								else if (CharacterData.current.inventory[i].owner != CharacterData.current.CID)
								{
									if (267037 - 587372 != -320335)
									{
										goto IL_4EE;
									}
									GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.GVqcNtKXL2M);
									if (192424 - 443939 == -251514)
									{
										goto IL_4EE;
									}
								}
							}
						}
						IL_4D0:
						i++;
						if (1987 - 140279 != -138292)
						{
							goto IL_4EE;
						}
					}
					if (13484 - 363282 == -349798)
					{
						if (this.r4lcw9dSiEF != 0)
						{
							break;
						}
						if (208271 - 430914 != -222642)
						{
							if (!(this.QbwcNOrKIRj != "none"))
							{
								break;
							}
							if (111087 - 83115 != 27973)
							{
								Guix.renderTextOutline(this.ctvcN20Yrgs, this.QbwcNOrKIRj, this.MgqcNlZV8Ds);
								if (116160 - 239260 != -123099)
								{
									GUI.Label(this.ctvcN20Yrgs, this.QbwcNOrKIRj, this.O3ocNvLc6Bg);
									if (298289 - 226672 == 71617)
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

	// Token: 0x060062B5 RID: 25269 RVA: 0x00DAF8E0 File Offset: 0x00DADAE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (118631 - 399863 != -281231)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (17444 - 416342 != -398897)
				{
					break;
				}
			}
			else
			{
				if (this.r4lcw9dSiEF == 0)
				{
					break;
				}
				if (152075 - 364811 == -212736)
				{
					if (Input.GetMouseButton(1))
					{
						if (101609 - 594912 != -493302)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (108454 - 407308 != -298853)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (237344 - 577859 == -340515)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.r4lcw9dSiEF));
									if (193429 - 100432 != 92998)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.r4lcw9dSiEF = 0;
						if (237542 - 55650 == 181892)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062B6 RID: 25270 RVA: 0x00DAFA68 File Offset: 0x00DADC68
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitNoticeBar()
	{
		if (95313 - 488359 != -393045)
		{
		}
		for (;;)
		{
			this.PY1cNGIsJxG = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (75846 - 443009 != -367162)
			{
				this.mbxcN1hZvOu = new GUIStyle();
				if (238802 - 178343 == 60459)
				{
					this.mbxcN1hZvOu.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (160608 - 288830 == -128222)
					{
						this.mbxcN1hZvOu.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (250811 - 118652 == 132159)
						{
							this.mbxcN1hZvOu.alignment = TextAnchor.MiddleCenter;
							if (137016 - 355251 == -218235)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062B7 RID: 25271 RVA: 0x00DAFBA4 File Offset: 0x00DADDA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void newNoticeBar(string s, float t)
	{
		this.e0KcNprJve4 = s;
		this.AXQcNqDj7uV = Time.time + t;
	}

	// Token: 0x060062B8 RID: 25272 RVA: 0x00DAFBBC File Offset: 0x00DADDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderNoticeBar()
	{
		if (60875 - 576103 != -515227)
		{
		}
		while (this.AXQcNqDj7uV > Time.time)
		{
			if (294737 - 213496 == 81241)
			{
				GUI.DrawTexture(new Rect((float)395, (float)570, (float)475, (float)102), this.PY1cNGIsJxG);
				if (246950 - 137232 == 109718)
				{
					GUI.Label(new Rect((float)430, (float)600, (float)400, (float)40), this.e0KcNprJve4, this.mbxcN1hZvOu);
					if (89998 - 168717 == -78719)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060062B9 RID: 25273 RVA: 0x00DAFCA4 File Offset: 0x00DADEA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void QuestAccept()
	{
		if (216890 - 565367 != -348477)
		{
		}
		for (;;)
		{
			Debug.Log("Quest Accept");
			if (47711 - 123704 == -75993)
			{
				Hashtable hashtable = new Hashtable();
				if (90858 - 490282 != -399423)
				{
					hashtable.Add(43, PlayerData.UID);
					if (23291 - 73894 == -50603)
					{
						hashtable.Add(50, PhotonClient.cInt16(this.mn3cUCYdLDL));
						if (179621 - 325706 == -146085)
						{
							PhotonClient.Connection.OpCustom(121, hashtable, true);
							if (155533 - 102214 == 53319)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062BA RID: 25274 RVA: 0x00DAFDB4 File Offset: 0x00DADFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onQuestAccept(Hashtable data)
	{
		if (125355 - 220641 != -95285)
		{
		}
		for (;;)
		{
			Debug.Log("On Quest Accept");
			if (275237 - 156168 != 119070)
			{
				if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (255913 - 463708 != -207794)
					{
						PlayerData.QuestID = RuntimeServices.UnboxInt32(data[50]);
						if (199443 - 284294 == -84851)
						{
							PlayerData.QuestState = 0;
							if (23773 - 129422 != -105648)
							{
								this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
								if (100067 - 25291 != 74777)
								{
									this.mState = eTownQuestState.accept;
									if (121699 - 44027 == 77672)
									{
										this.vfLcwm4xtys = Time.time;
										if (53141 - 317760 != -264618)
										{
											if (this.BbEcU5rAOU4)
											{
												if (17280 - 536560 != -519280)
												{
													continue;
												}
												this.audio.PlayOneShot(this.BbEcU5rAOU4);
												if (205726 - 204056 != 1670)
												{
													continue;
												}
											}
											if (Mathf.Abs(PlayerData.QuestID) != 5)
											{
												break;
											}
											if (297861 - 141960 == 155901)
											{
												GameObject gameObject = GameObject.Find("MiniCat");
												if (18904 - 323259 == -304355)
												{
													if (!gameObject)
													{
														break;
													}
													if (127024 - 265856 != -138831)
													{
														UnityEngine.Object.Destroy(gameObject);
														if (189158 - 537671 == -348513)
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
					this.newNoticeBar("Accepting Quest Error", 2f);
					if (274332 - 60875 == 213457)
					{
						Debug.LogError("Accepting Quest Error");
						if (55454 - 7899 == 47555)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062BB RID: 25275 RVA: 0x00DB004C File Offset: 0x00DAE24C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void QuestComplete()
	{
		if (236840 - 375015 != -138175)
		{
		}
		for (;;)
		{
			Debug.Log("Quest Complete");
			if (53695 - 117825 == -64130)
			{
				Hashtable hashtable = new Hashtable();
				if (173946 - 96598 == 77348)
				{
					hashtable.Add(43, PlayerData.UID);
					if (97759 - 449278 != -351518)
					{
						hashtable.Add(50, PhotonClient.cInt16(PlayerData.QuestID));
						if (133156 - 293976 != -160819)
						{
							PhotonClient.Connection.OpCustom(123, hashtable, true);
							if (131710 - 12984 != 118727)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062BC RID: 25276 RVA: 0x00DB0158 File Offset: 0x00DAE358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onQuestComplete(Hashtable data)
	{
		if (21277 - 435341 != -414064)
		{
		}
		for (;;)
		{
			Debug.Log("On Quest Complete");
			if (158620 - 501190 == -342570)
			{
				if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (185117 - 457614 == -272497)
					{
						this.ReadQuestComplete(data);
						if (176538 - 414711 == -238173)
						{
							this.ResetQuestInventory();
							if (97396 - 560895 == -463499)
							{
								PlayerData.QuestID = 0;
								if (275599 - 220140 == 55459)
								{
									PlayerData.QuestState = 0;
									if (176473 - 41597 != 134877)
									{
										int value = RuntimeServices.UnboxInt32(data[50]);
										if (214340 - 357747 != -143406)
										{
											PlayerData.removeQuestList(Mathf.Abs(value));
											if (163465 - 18573 != 144893)
											{
												this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
												if (289630 - 342138 == -52508)
												{
													this.mState = eTownQuestState.complete;
													if (91374 - 335006 == -243632)
													{
														this.vfLcwm4xtys = Time.time;
														if (125407 - 562259 == -436852)
														{
															if (!this.TqxcUcgpjub)
															{
																break;
															}
															if (198885 - 524056 != -325170)
															{
																this.audio.PlayOneShot(this.TqxcUcgpjub);
																if (297083 - 561322 != -264238)
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
					this.newNoticeBar("Quest Complete Error!", 2f);
					if (174369 - 298572 == -124203)
					{
						Debug.LogError("Quest Complete Error!");
						if (87092 - 308161 != -221068)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062BD RID: 25277 RVA: 0x00DB03E0 File Offset: 0x00DAE5E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void QuestGetReward(string nRewardString)
	{
		if (10741 - 361424 != -350682)
		{
		}
		for (;;)
		{
			Debug.Log("Quest Get Reward : " + nRewardString);
			if (150439 - 519975 != -369535)
			{
				Hashtable hashtable = new Hashtable();
				if (3724 - 307005 == -303281)
				{
					hashtable.Add(43, PlayerData.UID);
					if (134804 - 70212 == 64592)
					{
						hashtable.Add(21, nRewardString);
						if (210978 - 310552 != -99573)
						{
							PhotonClient.Connection.OpCustom(124, hashtable, true);
							if (14330 - 598060 != -583729)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062BE RID: 25278 RVA: 0x00DB04E4 File Offset: 0x00DAE6E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onQuestGetReward(Hashtable data)
	{
		if (294592 - 557507 != -262914)
		{
		}
		for (;;)
		{
			Debug.Log("on Quest Get Reward");
			if (158549 - 250150 == -91601)
			{
				if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (276966 - 129858 != 147109)
					{
						object obj2;
						object obj = obj2 = data[32];
						if (!(obj is string))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string));
						}
						this.ReadQuestGetReward((string)obj2);
						if (276119 - 461606 == -185487)
						{
							this.ResetQuestInventory();
							if (183852 - 331255 == -147403)
							{
								break;
							}
						}
					}
				}
				else
				{
					this.newNoticeBar("Quest Complete Error", 2f);
					if (94645 - 500953 == -406308)
					{
						Debug.LogError("Quest Complete Error");
						if (69191 - 277406 == -208215)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062BF RID: 25279 RVA: 0x00DB0638 File Offset: 0x00DAE838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void QuestCancel()
	{
		if (235879 - 81720 != 154160)
		{
		}
		for (;;)
		{
			Debug.Log("Quest Cancel");
			if (104499 - 497082 == -392583)
			{
				Hashtable hashtable = new Hashtable();
				if (231788 - 597320 != -365531)
				{
					hashtable.Add(43, PlayerData.UID);
					if (109866 - 483504 == -373638)
					{
						hashtable.Add(50, PhotonClient.cInt16(Mathf.Abs(PlayerData.QuestID)));
						if (156053 - 518069 == -362016)
						{
							PhotonClient.Connection.OpCustom(125, hashtable, true);
							if (47726 - 596600 != -548873)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060062C0 RID: 25280 RVA: 0x00DB074C File Offset: 0x00DAE94C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onQuestCancel(Hashtable data)
	{
		if (215718 - 446221 != -230503)
		{
		}
		for (;;)
		{
			Debug.Log("On Quest Cancel");
			if (2892 - 58190 == -55298)
			{
				if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (51693 - 341594 == -289901)
					{
						this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
						if (20477 - 510615 != -490137)
						{
							this.mState = eTownQuestState.cancel;
							if (98591 - 336603 == -238012)
							{
								this.vfLcwm4xtys = Time.time;
								if (111010 - 14359 == 96651)
								{
									if (!this.U2mcUnNkFx8)
									{
										break;
									}
									if (297695 - 272566 != 25130)
									{
										this.audio.PlayOneShot(this.U2mcUnNkFx8);
										if (50002 - 339995 != -289992)
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
					this.newNoticeBar("Cancelling Quest Error", 2f);
					if (80178 - 127353 == -47175)
					{
						Debug.LogError("Cancelling Quest Error");
						if (35509 - 6933 != 28577)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060062C1 RID: 25281 RVA: 0x00DB0900 File Offset: 0x00DAEB00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060062C2 RID: 25282 RVA: 0x00DB0904 File Offset: 0x00DAEB04
	internal static bool c6fVI9pQq8YeTCphHQwH()
	{
		return true;
	}

	// Token: 0x060062C3 RID: 25283 RVA: 0x00DB0908 File Offset: 0x00DAEB08
	internal static bool iThbSgpQ70xwVY6eXNwc()
	{
		return false;
	}

	// Token: 0x040071AC RID: 29100
	public int posx;

	// Token: 0x040071AD RID: 29101
	public int posy;

	// Token: 0x040071AE RID: 29102
	public int divx;

	// Token: 0x040071AF RID: 29103
	public int divy;

	// Token: 0x040071B0 RID: 29104
	public eTownQuestState mState;

	// Token: 0x040071B1 RID: 29105
	private float vfLcwm4xtys;

	// Token: 0x040071B2 RID: 29106
	private float QqLcwjYj8FX;

	// Token: 0x040071B3 RID: 29107
	private float rVscworDQdh;

	// Token: 0x040071B4 RID: 29108
	private float Os9cwkOqyw8;

	// Token: 0x040071B5 RID: 29109
	private float u7FcwF5edU6;

	// Token: 0x040071B6 RID: 29110
	private float lVrcwAobuN2;

	// Token: 0x040071B7 RID: 29111
	private int r4lcw9dSiEF;

	// Token: 0x040071B8 RID: 29112
	private Texture NMWcwW3rrIt;

	// Token: 0x040071B9 RID: 29113
	private Texture dFRcwu8uAyS;

	// Token: 0x040071BA RID: 29114
	private GUIStyle N6tcwyaR6TL;

	// Token: 0x040071BB RID: 29115
	private AudioClip oE4cwVHFo65;

	// Token: 0x040071BC RID: 29116
	private AudioClip KaJcwhGo9KK;

	// Token: 0x040071BD RID: 29117
	private AudioClip oKHcwKY3aUW;

	// Token: 0x040071BE RID: 29118
	private AudioClip xhHcwzwSx9l;

	// Token: 0x040071BF RID: 29119
	private AudioClip BbEcU5rAOU4;

	// Token: 0x040071C0 RID: 29120
	private AudioClip TqxcUcgpjub;

	// Token: 0x040071C1 RID: 29121
	private AudioClip U2mcUnNkFx8;

	// Token: 0x040071C2 RID: 29122
	private Texture jEecUQUYcQK;

	// Token: 0x040071C3 RID: 29123
	private Texture jlPcUeNpO54;

	// Token: 0x040071C4 RID: 29124
	private Texture W0JcUIx4rt9;

	// Token: 0x040071C5 RID: 29125
	private GameObject srwcUJ28PLX;

	// Token: 0x040071C6 RID: 29126
	private Texture SVWcU6bISO9;

	// Token: 0x040071C7 RID: 29127
	private Texture leLcUtP74fj;

	// Token: 0x040071C8 RID: 29128
	private GUIStyle WFHcUXl3xnn;

	// Token: 0x040071C9 RID: 29129
	private GUIStyle gBlcUO4KTfL;

	// Token: 0x040071CA RID: 29130
	private string LUDcU2QNlkj;

	// Token: 0x040071CB RID: 29131
	private string Hd8cUvoZo4l;

	// Token: 0x040071CC RID: 29132
	private string pZ2cUlteoT1;

	// Token: 0x040071CD RID: 29133
	private string MYjcUGTMybW;

	// Token: 0x040071CE RID: 29134
	private AudioClip oDPcU1ZHcsw;

	// Token: 0x040071CF RID: 29135
	private AudioClip hT0cUqjGVbr;

	// Token: 0x040071D0 RID: 29136
	private AudioClip X9bcUpTY8QF;

	// Token: 0x040071D1 RID: 29137
	private AudioClip XqscURkeaYw;

	// Token: 0x040071D2 RID: 29138
	private bool KFvcUrMJZBu;

	// Token: 0x040071D3 RID: 29139
	private bool XJtcUxx8QEB;

	// Token: 0x040071D4 RID: 29140
	private Texture Xp2cUTGVVVi;

	// Token: 0x040071D5 RID: 29141
	private GUIStyle zMIcUYtZWja;

	// Token: 0x040071D6 RID: 29142
	private GUIStyle kiicU3yBneP;

	// Token: 0x040071D7 RID: 29143
	private GUIStyle QMScUbAnjss;

	// Token: 0x040071D8 RID: 29144
	private GUIStyle dSycUdWW39w;

	// Token: 0x040071D9 RID: 29145
	private GUIStyle FUDcUgiu54L;

	// Token: 0x040071DA RID: 29146
	private Texture nbecUaIyQXA;

	// Token: 0x040071DB RID: 29147
	private QuestClass L6dcU4mUmxN;

	// Token: 0x040071DC RID: 29148
	private int JUpcUsJHj5v;

	// Token: 0x040071DD RID: 29149
	private bool siccUHNmmEO;

	// Token: 0x040071DE RID: 29150
	private Texture jtxcU7HFwof;

	// Token: 0x040071DF RID: 29151
	private GUIStyle H0EcUZ2kM59;

	// Token: 0x040071E0 RID: 29152
	private int mn3cUCYdLDL;

	// Token: 0x040071E1 RID: 29153
	private ItemClass kXXcUMRqrGn;

	// Token: 0x040071E2 RID: 29154
	private InventoryClass vqRcUfPpY4Z;

	// Token: 0x040071E3 RID: 29155
	private string[] pTCcULrHYrq;

	// Token: 0x040071E4 RID: 29156
	private int[] PJYcUwjEq5Q;

	// Token: 0x040071E5 RID: 29157
	private bool[] EAecUUGWw0H;

	// Token: 0x040071E6 RID: 29158
	private Texture[] d1HcUNl2PSC;

	// Token: 0x040071E7 RID: 29159
	private HoverButtonClass[] d5OcUEUWDD2;

	// Token: 0x040071E8 RID: 29160
	private string[] GtucUPWX25g;

	// Token: 0x040071E9 RID: 29161
	private int[] CiqcUSsDHFs;

	// Token: 0x040071EA RID: 29162
	private Texture[] kD9cUBUOk7U;

	// Token: 0x040071EB RID: 29163
	private HoverButtonClass[] DKMcU0FTJhj;

	// Token: 0x040071EC RID: 29164
	private GUIStyle HDEcU8dZkqC;

	// Token: 0x040071ED RID: 29165
	private GUIStyle HFacUiKMGVE;

	// Token: 0x040071EE RID: 29166
	private GUIStyle gtNcUDwHKRQ;

	// Token: 0x040071EF RID: 29167
	private GUIStyle RLNcUmEd3Bf;

	// Token: 0x040071F0 RID: 29168
	private GUIStyle kupcUjDif8h;

	// Token: 0x040071F1 RID: 29169
	private GUIStyle q5FcUoKVSIB;

	// Token: 0x040071F2 RID: 29170
	private GUIStyle vxocUk1aR7R;

	// Token: 0x040071F3 RID: 29171
	private int zXVcUFpOft2;

	// Token: 0x040071F4 RID: 29172
	private int sKWcUAIUmkV;

	// Token: 0x040071F5 RID: 29173
	private Texture pGycU9p9KUQ;

	// Token: 0x040071F6 RID: 29174
	private Texture haxcUW95Dlu;

	// Token: 0x040071F7 RID: 29175
	private Texture HhWcUudmsPF;

	// Token: 0x040071F8 RID: 29176
	private GUIStyle AGHcUybgeE6;

	// Token: 0x040071F9 RID: 29177
	private GUIStyle FaLcUVZrBPA;

	// Token: 0x040071FA RID: 29178
	private int imKcUhJCJT0;

	// Token: 0x040071FB RID: 29179
	private int scScUKdRkRa;

	// Token: 0x040071FC RID: 29180
	private int oEecUzkusRc;

	// Token: 0x040071FD RID: 29181
	private InventoryClass[] XILcN58VZMO;

	// Token: 0x040071FE RID: 29182
	private Texture[] NBacNcwbKnL;

	// Token: 0x040071FF RID: 29183
	private HoverButtonClass[] aYccNnc8nKW;

	// Token: 0x04007200 RID: 29184
	private IconButtonClass[] Nv3cNQjgHnf;

	// Token: 0x04007201 RID: 29185
	private Texture ERTcNemP1Eh;

	// Token: 0x04007202 RID: 29186
	private Texture umccNIYuFEr;

	// Token: 0x04007203 RID: 29187
	private Texture mpacNJ4gVhn;

	// Token: 0x04007204 RID: 29188
	private Texture gmgcN6Lc21k;

	// Token: 0x04007205 RID: 29189
	private Texture GVqcNtKXL2M;

	// Token: 0x04007206 RID: 29190
	private GUIStyle EF0cNXXMxr3;

	// Token: 0x04007207 RID: 29191
	private string QbwcNOrKIRj;

	// Token: 0x04007208 RID: 29192
	private Rect ctvcN20Yrgs;

	// Token: 0x04007209 RID: 29193
	private GUIStyle O3ocNvLc6Bg;

	// Token: 0x0400720A RID: 29194
	private GUIStyle MgqcNlZV8Ds;

	// Token: 0x0400720B RID: 29195
	private Texture PY1cNGIsJxG;

	// Token: 0x0400720C RID: 29196
	private GUIStyle mbxcN1hZvOu;

	// Token: 0x0400720D RID: 29197
	private float AXQcNqDj7uV;

	// Token: 0x0400720E RID: 29198
	private string e0KcNprJve4;

	// Token: 0x02001090 RID: 4240
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RenderTownQuestDes$36333 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060062C4 RID: 25284 RVA: 0x00DB090C File Offset: 0x00DAEB0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RenderTownQuestDes$36333(QuestGui self_)
		{
			if (296213 - 66766 != 229447)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262901 - 138363 != 124539)
				{
					base..ctor();
					if (204870 - 570105 == -365235)
					{
						this.$self_$36340 = self_;
						if (75221 - 286046 == -210825)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x00DB09A4 File Offset: 0x00DAEBA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new QuestGui.$RenderTownQuestDes$36333.$(this.$self_$36340);
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x00DB09B4 File Offset: 0x00DAEBB4
		internal static bool xn2nRJpQPw3OuOc3QAgC()
		{
			return true;
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x00DB09B8 File Offset: 0x00DAEBB8
		internal static bool yHEQVepQ0Hs27btOfZCL()
		{
			return false;
		}

		// Token: 0x0400720F RID: 29199
		internal QuestGui $self_$36340;

		// Token: 0x02001091 RID: 4241
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060062C8 RID: 25288 RVA: 0x00DB09BC File Offset: 0x00DAEBBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(QuestGui self_)
			{
				if (226079 - 524996 != -298916)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56243 - 415531 == -359288)
					{
						base..ctor();
						if (169494 - 177181 == -7687)
						{
							this.$self_$36339 = self_;
							if (261676 - 212137 == 49539)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060062C9 RID: 25289 RVA: 0x00DB0A54 File Offset: 0x00DAEC54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177609 - 410231 != -232621)
				{
				}
				for (;;)
				{
					IL_561:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_117A;
					case 2:
						if (this.$self_$36339.oE4cwVHFo65)
						{
							if (120813 - 343559 != -222746)
							{
								continue;
							}
							this.$self_$36339.audio.PlayOneShot(this.$self_$36339.oE4cwVHFo65);
							if (248978 - 267437 == -18458)
							{
								continue;
							}
						}
						this.$self_$36339.QuestAccept();
						if (190067 - 468414 != -278346)
						{
							goto IL_538;
						}
						continue;
					case 3:
						this.$self_$36339.QuestComplete();
						if (180145 - 477089 != -296943)
						{
							goto IL_610;
						}
						continue;
					case 4:
						this.$self_$36339.QuestCancel();
						if (129726 - 5142 != 124585)
						{
							goto IL_104D;
						}
						continue;
					default:
						if (156485 - 245727 != -89242)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestList != null)
					{
						if (169157 - 193847 != -24690)
						{
							continue;
						}
						if (Extensions.get_length(PlayerData.QuestList) == 0)
						{
							if (87454 - 44410 != 43044)
							{
								continue;
							}
						}
						else
						{
							if (this.$self_$36339.nbecUaIyQXA)
							{
								if (233904 - 438181 == -204276)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)569, (float)73, (float)423, (float)252), this.$self_$36339.nbecUaIyQXA);
								if (266476 - 554071 == -287594)
								{
									continue;
								}
							}
							if (this.$self_$36339.L6dcU4mUmxN != null)
							{
								if (189580 - 243540 != -53960)
								{
									continue;
								}
								if (PlayerData.QuestID != 0)
								{
									if (35024 - 335810 != -300786)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)860, (float)560, (float)122, (float)107), this.$self_$36339.jtxcU7HFwof);
									if (138267 - 267875 != -129608)
									{
										continue;
									}
								}
								if (this.$self_$36339.mn3cUCYdLDL > 0)
								{
									if (273441 - 272934 != 507)
									{
										continue;
									}
									GUI.Label(new Rect((float)610, (float)360, (float)350, (float)120), this.$self_$36339.L6dcU4mUmxN.des, this.$self_$36339.H0EcUZ2kM59);
									if (49643 - 268097 == -218453)
									{
										continue;
									}
									GUI.Label(new Rect((float)610, (float)600, (float)350, (float)60), this.$self_$36339.L6dcU4mUmxN.obj, this.$self_$36339.H0EcUZ2kM59);
									if (46327 - 551760 != -505433)
									{
										continue;
									}
									Guix.renderSmallNumber(650, 717, this.$self_$36339.L6dcU4mUmxN.gil, true, (float)1);
									if (56432 - 198565 != -142133)
									{
										continue;
									}
									Guix.renderSmallNumber(850, 717, this.$self_$36339.L6dcU4mUmxN.exp, true, (float)1);
									if (246064 - 523893 != -277829)
									{
										continue;
									}
								}
								else if (this.$self_$36339.mn3cUCYdLDL < 0)
								{
									if (82459 - 211995 == -129535)
									{
										continue;
									}
									GUI.Label(new Rect((float)610, (float)360, (float)350, (float)120), this.$self_$36339.L6dcU4mUmxN.des2, this.$self_$36339.H0EcUZ2kM59);
									if (160061 - 86525 != 73536)
									{
										continue;
									}
									GUI.Label(new Rect((float)610, (float)600, (float)350, (float)60), this.$self_$36339.L6dcU4mUmxN.obj2, this.$self_$36339.H0EcUZ2kM59);
									if (251953 - 558362 != -306409)
									{
										continue;
									}
									Guix.renderSmallNumber(650, 717, this.$self_$36339.L6dcU4mUmxN.gil2, true, (float)1);
									if (148067 - 396409 != -248342)
									{
										continue;
									}
									Guix.renderSmallNumber(850, 717, this.$self_$36339.L6dcU4mUmxN.exp2, true, (float)1);
									if (263349 - 190108 != 73241)
									{
										continue;
									}
								}
								this.$hoverText$36334 = "none";
								if (157012 - 396852 != -239840)
								{
									continue;
								}
								this.$hoverPos$36335 = default(Rect);
								if (52105 - 280215 == -228109)
								{
									continue;
								}
								this.$r$36336 = 0;
								if (89696 - 501183 == -411486)
								{
									continue;
								}
								while (this.$r$36336 < 6)
								{
									if (this.$self_$36339.d1HcUNl2PSC[this.$r$36336] != null)
									{
										if (195131 - 435089 != -239958)
										{
											goto IL_561;
										}
										GUI.DrawTexture(new Rect((float)(604 + this.$r$36336 * 60), (float)517, (float)64, (float)64), this.$self_$36339.d1HcUNl2PSC[this.$r$36336]);
										if (75560 - 597870 != -522310)
										{
											goto IL_561;
										}
										this.$$switch$5107$36337 = HoverButton.newButton(this.$self_$36339.d5OcUEUWDD2[this.$r$36336], new Rect((float)(611 + this.$r$36336 * 60), (float)524, (float)50, (float)50), (float)0);
										if (134698 - 526666 == -391967)
										{
											goto IL_561;
										}
										if (this.$$switch$5107$36337 == eHoverButtonState.hover)
										{
											if (166992 - 280237 != -113245)
											{
												goto IL_561;
											}
											goto IL_741;
										}
										else if (this.$$switch$5107$36337 == eHoverButtonState.over)
										{
											if (198942 - 509139 != -310196)
											{
												goto IL_741;
											}
											goto IL_561;
										}
										IL_46A:
										Guix.renderTextOutline(new Rect((float)(650 + this.$r$36336 * 60), (float)552, (float)60, (float)30), "x" + this.$self_$36339.PJYcUwjEq5Q[this.$r$36336], this.$self_$36339.q5FcUoKVSIB);
										if (287938 - 577887 == -289948)
										{
											goto IL_561;
										}
										if (this.$self_$36339.EAecUUGWw0H[this.$r$36336])
										{
											if (185386 - 455805 != -270419)
											{
												goto IL_561;
											}
											GUI.Label(new Rect((float)(650 + this.$r$36336 * 60), (float)552, (float)60, (float)30), "x" + this.$self_$36339.PJYcUwjEq5Q[this.$r$36336], this.$self_$36339.RLNcUmEd3Bf);
											if (271290 - 552391 != -281101)
											{
												goto IL_561;
											}
											goto IL_40;
										}
										else
										{
											GUI.Label(new Rect((float)(650 + this.$r$36336 * 60), (float)552, (float)60, (float)30), "x" + this.$self_$36339.PJYcUwjEq5Q[this.$r$36336], this.$self_$36339.kupcUjDif8h);
											if (240784 - 94128 != 146656)
											{
												goto IL_561;
											}
											goto IL_40;
										}
										IL_741:
										this.$hoverText$36334 = ItemData.getName(this.$self_$36339.pTCcULrHYrq[this.$r$36336]);
										if (79662 - 581061 == -501398)
										{
											goto IL_561;
										}
										this.$hoverPos$36335 = new Rect((float)(550 + this.$r$36336 * 60), (float)580, (float)180, (float)30);
										if (72399 - 406226 != -333827)
										{
											goto IL_561;
										}
										goto IL_46A;
									}
									IL_40:
									if (this.$self_$36339.kD9cUBUOk7U[this.$r$36336] != null)
									{
										if (108612 - 189880 != -81268)
										{
											goto IL_561;
										}
										GUI.DrawTexture(new Rect((float)(604 + this.$r$36336 * 60), (float)745, (float)64, (float)64), this.$self_$36339.kD9cUBUOk7U[this.$r$36336]);
										if (280855 - 459942 == -179086)
										{
											goto IL_561;
										}
										if (this.$self_$36339.CiqcUSsDHFs[this.$r$36336] > 1)
										{
											if (286893 - 199107 != 87786)
											{
												goto IL_561;
											}
											GUI.DrawTexture(new Rect((float)(604 + this.$r$36336 * 60 + 38), (float)784, (float)24, (float)24), this.$self_$36339.mpacNJ4gVhn);
											if (153787 - 563018 == -409230)
											{
												goto IL_561;
											}
											GUI.Label(new Rect((float)(604 + this.$r$36336 * 60 + 34), (float)777, (float)32, (float)32), string.Empty + this.$self_$36339.CiqcUSsDHFs[this.$r$36336], this.$self_$36339.EF0cNXXMxr3);
											if (113732 - 134993 == -21260)
											{
												goto IL_561;
											}
										}
										this.$$switch$5110$36338 = HoverButton.newButton(this.$self_$36339.DKMcU0FTJhj[this.$r$36336], new Rect((float)(611 + this.$r$36336 * 60), (float)752, (float)50, (float)50), (float)0);
										if (54852 - 92383 == -37530)
										{
											goto IL_561;
										}
										if (this.$$switch$5110$36338 == eHoverButtonState.hover)
										{
											if (207772 - 549993 != -342221)
											{
												goto IL_561;
											}
										}
										else
										{
											if (this.$$switch$5110$36338 != eHoverButtonState.over)
											{
												goto IL_77D;
											}
											if (174525 - 153378 != 21147)
											{
												goto IL_561;
											}
										}
										this.$hoverText$36334 = ItemData.getName(this.$self_$36339.GtucUPWX25g[this.$r$36336]);
										if (43245 - 524728 != -481483)
										{
											goto IL_561;
										}
										this.$hoverPos$36335 = new Rect((float)(550 + this.$r$36336 * 60), (float)800, (float)180, (float)30);
										if (153093 - 373443 == -220349)
										{
											goto IL_561;
										}
									}
									IL_77D:
									this.$r$36336++;
									if (195934 - 140159 == 55776)
									{
										goto IL_561;
									}
								}
								if (215448 - 312499 == -97050)
								{
									continue;
								}
							}
							if (this.$self_$36339.mn3cUCYdLDL == 0)
							{
								goto IL_104D;
							}
							if (22541 - 261137 != -238596)
							{
								continue;
							}
							if (PlayerData.QuestID == 0)
							{
								if (116287 - 343118 == -226830)
								{
									continue;
								}
								if (!GUI.Button(new Rect((float)708, (float)840, (float)151, (float)35), string.Empty, this.$self_$36339.HDEcU8dZkqC))
								{
									goto IL_538;
								}
								if (243333 - 277726 != -34393)
								{
									continue;
								}
								if (Time.time <= this.$self_$36339.QqLcwjYj8FX)
								{
									goto IL_538;
								}
								if (269187 - 31934 != 237253)
								{
									continue;
								}
								this.$self_$36339.newNoticeBar("Registering Quest...", (float)3);
								if (292142 - 438720 != -146578)
								{
									continue;
								}
								this.$self_$36339.QqLcwjYj8FX = Time.time + (float)3;
								if (54177 - 327907 != -273730)
								{
									continue;
								}
								break;
							}
							else
							{
								if (PlayerData.QuestID == 0)
								{
									goto IL_104D;
								}
								if (124006 - 179815 == -55808)
								{
									continue;
								}
								if (this.$self_$36339.siccUHNmmEO)
								{
									if (49387 - 483944 == -434556)
									{
										continue;
									}
									if (!GUI.Button(new Rect((float)708, (float)840, (float)170, (float)49), string.Empty, this.$self_$36339.gtNcUDwHKRQ))
									{
										goto IL_610;
									}
									if (100800 - 212350 == -111549)
									{
										continue;
									}
									if (Time.time <= this.$self_$36339.QqLcwjYj8FX)
									{
										goto IL_610;
									}
									if (216969 - 478659 == -261689)
									{
										continue;
									}
									this.$self_$36339.newNoticeBar("Completing Quest...", (float)3);
									if (181649 - 31972 == 149678)
									{
										continue;
									}
									this.$self_$36339.QqLcwjYj8FX = Time.time + (float)3;
									if (226988 - 200341 != 26648)
									{
										goto Block_92;
									}
									continue;
								}
								else
								{
									if (!GUI.Button(new Rect((float)708, (float)840, (float)151, (float)35), string.Empty, this.$self_$36339.HFacUiKMGVE))
									{
										goto IL_104D;
									}
									if (169338 - 456243 == -286904)
									{
										continue;
									}
									if (Time.time <= this.$self_$36339.QqLcwjYj8FX)
									{
										goto IL_104D;
									}
									if (273738 - 293225 == -19486)
									{
										continue;
									}
									this.$self_$36339.newNoticeBar("Closing Quest...", (float)3);
									if (13709 - 213836 != -200127)
									{
										continue;
									}
									this.$self_$36339.QqLcwjYj8FX = Time.time + (float)3;
									if (120709 - 586865 != -466156)
									{
										continue;
									}
									goto IL_1012;
								}
							}
						}
					}
					if (this.$self_$36339.nbecUaIyQXA)
					{
						if (176137 - 507420 != -331283)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)569, (float)73, (float)423, (float)252), this.$self_$36339.nbecUaIyQXA);
						if (213418 - 185510 == 27909)
						{
							continue;
						}
					}
					else
					{
						this.$self_$36339.nbecUaIyQXA = (Texture)Resources.Load("GameGui/QuestWindow/questImage/T12", typeof(Texture));
						if (230467 - 370265 == -139797)
						{
							continue;
						}
					}
					GUI.Label(new Rect((float)610, (float)360, (float)350, (float)120), "n/a", this.$self_$36339.H0EcUZ2kM59);
					if (16978 - 356390 != -339412)
					{
						continue;
					}
					GUI.Label(new Rect((float)610, (float)600, (float)350, (float)60), "n/a", this.$self_$36339.H0EcUZ2kM59);
					if (153961 - 249814 != -95853)
					{
						continue;
					}
					Guix.renderSmallNumber(650, 717, 0, true, (float)1);
					if (66999 - 416565 != -349566)
					{
						continue;
					}
					Guix.renderSmallNumber(850, 717, 0, true, (float)1);
					if (149122 - 92443 != 56680)
					{
						goto IL_F25;
					}
					continue;
					IL_104D:
					if (!(this.$hoverText$36334 != "none"))
					{
						goto IL_F25;
					}
					if (14082 - 582269 != -568187)
					{
						continue;
					}
					Guix.renderTextOutline(this.$hoverPos$36335, this.$hoverText$36334, this.$self_$36339.MgqcNlZV8Ds);
					if (272477 - 466915 == -194437)
					{
						continue;
					}
					GUI.Label(this.$hoverPos$36335, this.$hoverText$36334, this.$self_$36339.O3ocNvLc6Bg);
					if (107814 - 397540 != -289725)
					{
						goto IL_F25;
					}
					continue;
					IL_610:
					IL_538:
					goto IL_104D;
					IL_F25:
					this.YieldDefault(1);
					if (105099 - 16669 == 88430)
					{
						goto IL_117A;
					}
				}
				return this.Yield(2, new WaitForSeconds(1.5f));
				Block_92:
				return this.Yield(3, new WaitForSeconds(1.5f));
				IL_1012:
				return this.Yield(4, new WaitForSeconds(1.5f));
				IL_117A:
				return false;
			}

			// Token: 0x060062CA RID: 25290 RVA: 0x00DB1BF0 File Offset: 0x00DAFDF0
			internal static bool ksf1N9pQbcP5FGZxQBRO()
			{
				return true;
			}

			// Token: 0x060062CB RID: 25291 RVA: 0x00DB1BF4 File Offset: 0x00DAFDF4
			internal static bool F3s6ERpQufK5wOfPiRA1()
			{
				return false;
			}

			// Token: 0x04007210 RID: 29200
			internal string $hoverText$36334;

			// Token: 0x04007211 RID: 29201
			internal Rect $hoverPos$36335;

			// Token: 0x04007212 RID: 29202
			internal int $r$36336;

			// Token: 0x04007213 RID: 29203
			internal eHoverButtonState $$switch$5107$36337;

			// Token: 0x04007214 RID: 29204
			internal eHoverButtonState $$switch$5110$36338;

			// Token: 0x04007215 RID: 29205
			internal QuestGui $self_$36339;
		}
	}
}
