using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02001065 RID: 4197
[Serializable]
public class IceMixerGui : MonoBehaviour
{
	// Token: 0x0600614C RID: 24908 RVA: 0x00D54CD0 File Offset: 0x00D52ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceMixerGui()
	{
		if (204369 - 249685 != -45315)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (43153 - 381900 != -338746)
			{
				base..ctor();
				if (107556 - 544912 == -437356)
				{
					this.kSMc4tEha6l = eIceMixerGuiState.init;
					if (256154 - 452445 == -196291)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600614D RID: 24909 RVA: 0x00D54D68 File Offset: 0x00D52F68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (220367 - 206745 != 13623)
		{
		}
		for (;;)
		{
			this.InitNPC();
			if (52533 - 563821 == -511288)
			{
				this.InitIceMixerGui();
				if (106810 - 504509 != -397698)
				{
					this.kSMc4tEha6l = eIceMixerGuiState.open;
					if (284531 - 302850 == -18319)
					{
						this.cIcc4Xbmool = Time.time;
						if (285215 - 241917 != 43299)
						{
							this.v6oc4OVRdZp = GameObject.Find("IceMixer");
							if (45337 - 464714 != -419376)
							{
								if (!this.v6oc4OVRdZp)
								{
									break;
								}
								if (75322 - 542723 != -467400)
								{
									this.v6oc4OVRdZp.animation.Play();
									if (85253 - 137703 != -52449)
									{
										this.v6oc4OVRdZp.audio.Play();
										if (268499 - 194082 == 74417)
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

	// Token: 0x0600614E RID: 24910 RVA: 0x00D54ED0 File Offset: 0x00D530D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (234614 - 198020 != 36595)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (157934 - 556976 != -399041)
			{
				GUI.depth = 2;
				if (10300 - 389997 != -379696)
				{
					this.ajgc428cEZj = (float)(1024 * Screen.width / Screen.height);
					if (75661 - 59111 != 16551)
					{
						this.vmVc4v6wqQr = (float)Screen.height / 1024f;
						if (189231 - 230535 == -41304)
						{
							eIceMixerGuiState eIceMixerGuiState = this.kSMc4tEha6l;
							if (20029 - 228242 == -208213)
							{
								if (eIceMixerGuiState == eIceMixerGuiState.init)
								{
									if (188459 - 26545 == 161914)
									{
										break;
									}
								}
								else if (eIceMixerGuiState == eIceMixerGuiState.open)
								{
									if (109956 - 265608 != -155651)
									{
										this.RenderNPC(Mathf.SmoothStep((float)1, (float)0, (float)2 * (Time.time - this.cIcc4Xbmool)));
										if (77610 - 443688 == -366078)
										{
											if (Time.time - this.cIcc4Xbmool <= (float)3)
											{
												break;
											}
											if (41413 - 419956 != -378542)
											{
												this.kSMc4tEha6l = eIceMixerGuiState.ready;
												if (284377 - 244346 != 40032)
												{
													this.cIcc4Xbmool = Time.time;
													if (148770 - 501164 == -352394)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (eIceMixerGuiState == eIceMixerGuiState.ready)
								{
									if (218077 - 220609 == -2532)
									{
										this.RenderIceMixer();
										if (284407 - 574055 != -289647)
										{
											this.RenderNPC((float)0);
											if (131757 - 30753 == 101004)
											{
												break;
											}
										}
									}
								}
								else if (eIceMixerGuiState == eIceMixerGuiState.play)
								{
									if (173016 - 350987 == -177971)
									{
										this.RenderIceMixer();
										if (128973 - 515691 != -386717)
										{
											this.RenderNPC((float)0);
											if (7770 - 74744 != -66973)
											{
												break;
											}
										}
									}
								}
								else if (eIceMixerGuiState == eIceMixerGuiState.complete)
								{
									if (291334 - 573066 == -281732)
									{
										this.RenderIceMixer();
										if (234565 - 540087 == -305522)
										{
											this.RenderNPC((float)0);
											if (77365 - 468114 != -390748)
											{
												break;
											}
										}
									}
								}
								else if (eIceMixerGuiState == eIceMixerGuiState.finish)
								{
									if (183940 - 583465 != -399524)
									{
										this.RenderIceMixer();
										if (254391 - 578742 == -324351)
										{
											this.RenderNPC((float)0);
											if (239291 - 413539 == -174248)
											{
												if (Time.time - this.cIcc4Xbmool <= (float)3)
												{
													break;
												}
												if (231223 - 360216 != -128992)
												{
													this.ResetIceMixer();
													if (162139 - 118224 == 43915)
													{
														this.kSMc4tEha6l = eIceMixerGuiState.ready;
														if (71480 - 248426 != -176945)
														{
															this.cIcc4Xbmool = Time.time;
															if (210927 - 278522 == -67595)
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
								else if (eIceMixerGuiState == eIceMixerGuiState.close)
								{
									if (152411 - 520822 == -368411)
									{
										this.RenderNPC(Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.cIcc4Xbmool)));
										if (142678 - 330888 != -188209)
										{
											if (Time.time - this.cIcc4Xbmool <= 0.5f)
											{
												break;
											}
											if (186420 - 530844 == -344424)
											{
												Game.mGameState = eGameState.Normal;
												if (78922 - 294850 != -215927)
												{
													GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
													if (139004 - 568665 != -429660)
													{
														gameGui.enabled = true;
														if (290217 - 262057 == 28160)
														{
															this.kSMc4tEha6l = eIceMixerGuiState.disable;
															if (150572 - 182939 == -32367)
															{
																this.cIcc4Xbmool = Time.time;
																if (271944 - 300717 != -28772)
																{
																	this.enabled = false;
																	if (57265 - 382135 == -324870)
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
									if (eIceMixerGuiState != eIceMixerGuiState.disable)
									{
										break;
									}
									if (98504 - 321032 != -222527)
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

	// Token: 0x0600614F RID: 24911 RVA: 0x00D554AC File Offset: 0x00D536AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (91810 - 351470 != -259660)
		{
		}
		for (;;)
		{
			if (this.kSMc4tEha6l != eIceMixerGuiState.play)
			{
				if (272476 - 237640 == 34836)
				{
					break;
				}
			}
			else if (Time.time - this.cIcc4Xbmool >= (float)30)
			{
				if (228339 - 116897 != 111443)
				{
					this.kSMc4tEha6l = eIceMixerGuiState.complete;
					if (178880 - 341801 != -162920)
					{
						this.cIcc4Xbmool = Time.time;
						if (166431 - 113877 == 52554)
						{
							this.IceMakerCompleteOperation(this.cBuc4E1vrY0);
							if (138256 - 503438 != -365181)
							{
								if (!this.Fcbc4fZKcI7)
								{
									break;
								}
								if (41402 - 304771 != -263368)
								{
									this.audio.PlayOneShot(this.Fcbc4fZKcI7);
									if (56066 - 398130 != -342063)
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
				this.PlayIceMixer();
				if (259707 - 179265 != 80443)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006150 RID: 24912 RVA: 0x00D55624 File Offset: 0x00D53824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (97975 - 115143 != -17168)
		{
		}
		for (;;)
		{
			this.wm8c4GK88Ft = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (283140 - 290024 != -6883)
			{
				this.XQOc41DQNuK = new GUIStyle();
				if (212222 - 381816 != -169593)
				{
					this.XQOc41DQNuK.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (231523 - 422189 != -190665)
					{
						this.XQOc41DQNuK.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (86672 - 11740 != 74933)
						{
							this.XQOc41DQNuK.alignment = TextAnchor.UpperLeft;
							if (154019 - 235635 == -81616)
							{
								this.BFZc4qkuhA4 = new GUIStyle();
								if (275510 - 17571 != 257940)
								{
									this.BFZc4qkuhA4.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (182423 - 381465 != -199041)
									{
										this.BFZc4qkuhA4.alignment = TextAnchor.UpperLeft;
										if (258993 - 37662 != 221332)
										{
											this.ResetNPC();
											if (222833 - 255096 == -32263)
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

	// Token: 0x06006151 RID: 24913 RVA: 0x00D55808 File Offset: 0x00D53A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (8657 - 212830 != -204172)
		{
		}
		for (;;)
		{
			this.rX7c4lNGrDq = (Texture)Resources.Load("GameGui/Story/Characters/" + CharacterData.current.Type, typeof(Texture));
			if (45981 - 135213 == -89232)
			{
				string type = CharacterData.current.Type;
				if (80362 - 309545 != -229182)
				{
					if (type == "Wolf")
					{
						if (259606 - 8848 != 250759)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 101);
							if (63317 - 500716 != -437398)
							{
								break;
							}
						}
					}
					else if (type == "Bison")
					{
						if (111602 - 205393 == -93791)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 201);
							if (249835 - 198786 == 51049)
							{
								break;
							}
						}
					}
					else if (type == "Panda")
					{
						if (76079 - 71134 != 4946)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 301);
							if (211590 - 394990 == -183400)
							{
								break;
							}
						}
					}
					else if (type == "Whale")
					{
						if (168465 - 185674 != -17208)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 401);
							if (198404 - 96645 == 101759)
							{
								break;
							}
						}
					}
					else if (type == "Cat")
					{
						if (242957 - 51627 == 191330)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 501);
							if (86447 - 38733 == 47714)
							{
								break;
							}
						}
					}
					else if (type == "Chameleon")
					{
						if (90195 - 77898 != 12298)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 601);
							if (71861 - 482146 != -410284)
							{
								break;
							}
						}
					}
					else if (type == "Rabbit")
					{
						if (43526 - 326718 != -283191)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 701);
							if (15514 - 24921 == -9407)
							{
								break;
							}
						}
					}
					else if (type == "Mole")
					{
						if (58154 - 499131 == -440977)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 801);
							if (255278 - 544825 == -289547)
							{
								break;
							}
						}
					}
					else if (type == "Monkey")
					{
						if (193166 - 483345 == -290179)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 901);
							if (297797 - 574933 == -277136)
							{
								break;
							}
						}
					}
					else if (type == "Penguin")
					{
						if (118845 - 257484 == -138639)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 1001);
							if (232511 - 569890 == -337379)
							{
								break;
							}
						}
					}
					else if (type == "Sheep")
					{
						if (75778 - 454630 != -378851)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 1101);
							if (163129 - 363743 != -200613)
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
						if (212696 - 374481 == -161785)
						{
							this.tWec4pSCy93 = Language.getMessage("IceMixerGui", 1201);
							if (181464 - 107967 == 73497)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006152 RID: 24914 RVA: 0x00D55D14 File Offset: 0x00D53F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC(float mOffset)
	{
		if (113665 - 132465 != -18799)
		{
		}
		for (;;)
		{
			if (this.rX7c4lNGrDq)
			{
				if (82647 - 493722 == -411074)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)0 - mOffset * (float)this.rX7c4lNGrDq.width, (float)(1024 - this.rX7c4lNGrDq.height), (float)this.rX7c4lNGrDq.width, (float)this.rX7c4lNGrDq.height), this.rX7c4lNGrDq);
				if (179865 - 551826 != -371961)
				{
					continue;
				}
			}
			if (this.kSMc4tEha6l != eIceMixerGuiState.open)
			{
				break;
			}
			if (139241 - 36118 != 103124)
			{
				GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj - (float)336, (float)724 + mOffset * (float)300, (float)836, (float)196), this.wm8c4GK88Ft);
				if (145143 - 306893 != -161749)
				{
					if (mOffset != (float)0)
					{
						break;
					}
					if (105297 - 589410 == -484113)
					{
						float num = Time.time - this.cIcc4Xbmool;
						if (156647 - 19457 == 137190)
						{
							GUI.BeginGroup(new Rect(0.5f * this.ajgc428cEZj - (float)350, (float)724, (float)850, (float)200));
							if (116493 - 309426 != -192932)
							{
								GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.wm8c4GK88Ft);
								if (138251 - 199501 == -61250)
								{
									GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), CharacterData.current.Name, this.XQOc41DQNuK);
									if (283921 - 179977 == 103944)
									{
										GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.tWec4pSCy93, num - 0.5f), this.BFZc4qkuhA4);
										if (83055 - 322335 == -239280)
										{
											GUI.EndGroup();
											if (256372 - 232035 == 24337)
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

	// Token: 0x06006153 RID: 24915 RVA: 0x00D55FD4 File Offset: 0x00D541D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitIceMixerGui()
	{
		if (35300 - 556578 != -521278)
		{
		}
		for (;;)
		{
			IL_228:
			this.rcic4Rrwm0g = (Texture)Resources.Load("GameGui/iceMixer/iceMixerWindow", typeof(Texture));
			if (255458 - 142085 != 113374)
			{
				this.WsHc4ra2FeZ = (Texture)Resources.Load("GameGui/iceMixer/iceMixerLever", typeof(Texture));
				if (136227 - 153694 != -17466)
				{
					this.BPTc4xSA0R3 = (Texture)Resources.Load("GameGui/iceMixer/iceMixerRing", typeof(Texture));
					if (158143 - 21800 == 136343)
					{
						this.iLkc4Tc3NBr = (Texture)Resources.Load("GameGui/iceMixer/iceMixerHand", typeof(Texture));
						if (293639 - 549113 == -255474)
						{
							this.sZEc4YAkmyc = (Texture)Resources.Load("GameGui/iceMixer/iceMixerComplete", typeof(Texture));
							if (197157 - 467997 == -270840)
							{
								this.xMUc43hTAt6 = (Texture)Resources.Load("GameGui/iceMixer/helpBar", typeof(Texture));
								if (62735 - 263574 != -200838)
								{
									this.Jttc4buKfxI = (Texture)Resources.Load("GameGui/iceMixer/itemBox", typeof(Texture));
									if (114691 - 38150 == 76541)
									{
										this.Cujc4dwU4Yq = (Texture)Resources.Load("GameGui/iceMixer/messageBar", typeof(Texture));
										if (69518 - 406325 == -336807)
										{
											this.DU9c4gyN94u = new GUIStyle();
											if (185024 - 117632 == 67392)
											{
												this.DU9c4gyN94u.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
												if (21208 - 346968 != -325759)
												{
													this.DU9c4gyN94u.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
													if (164552 - 204828 != -40275)
													{
														this.DU9c4gyN94u.alignment = TextAnchor.MiddleCenter;
														if (261280 - 13494 == 247786)
														{
															this.IHsc4aLjwAn = new string[]
															{
																"d_ice1",
																"m_ice1",
																"m_gas4",
																"f_bmb6",
																"m_bro7",
																"m_fab13",
																"m_ice2",
																"d_dst8",
																"m_ice3",
																"f_qmp2",
																"c_all21",
																"c_all22",
																"p_sim1"
															};
															if (255671 - 398309 != -142637)
															{
																this.SdCc44DEaD7 = new Texture[13];
																if (117801 - 520275 == -402474)
																{
																	int i = 0;
																	if (148569 - 99767 == 48802)
																	{
																		while (i < 13)
																		{
																			this.SdCc44DEaD7[i] = (Texture)Resources.Load("GameGui/iceMixer/prize/" + this.IHsc4aLjwAn[i], typeof(Texture));
																			if (46827 - 234853 == -188025)
																			{
																				goto IL_228;
																			}
																			i++;
																			if (189801 - 102614 != 87187)
																			{
																				goto IL_228;
																			}
																		}
																		if (4363 - 49614 == -45251)
																		{
																			this.AN6c4s9iAsM = new GUIStyle();
																			if (167016 - 167673 != -656)
																			{
																				this.AN6c4s9iAsM.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/iceMixer/button_spin", typeof(Texture)));
																				if (291328 - 217135 != 74194)
																				{
																					this.AN6c4s9iAsM.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/iceMixer/button_spin_h", typeof(Texture)));
																					if (38898 - 53511 != -14612)
																					{
																						this.AN6c4s9iAsM.active.background = (Texture2D)((Texture)Resources.Load("GameGui/iceMixer/button_spin_i", typeof(Texture)));
																						if (44704 - 330878 != -286173)
																						{
																							this.AGyc4HAFHPW = new GUIStyle();
																							if (30202 - 42133 != -11930)
																							{
																								this.AGyc4HAFHPW.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/iceMixer/button_close_h", typeof(Texture)));
																								if (170724 - 393643 == -222919)
																								{
																									this.INxc471YuFt = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																									if (194592 - 178815 != 15778)
																									{
																										this.NEFc4ZMAaTj = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																										if (206326 - 290719 != -84392)
																										{
																											this.t1uc4CdyJpW = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																											if (71024 - 27208 != 43817)
																											{
																												this.GjCc4MPmiiq = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																												if (125474 - 332680 != -207205)
																												{
																													this.Fcbc4fZKcI7 = (AudioClip)Resources.Load("Sound/FX/raffle", typeof(AudioClip));
																													if (67985 - 450241 != -382255)
																													{
																														this.ResetIceMixer();
																														if (271473 - 450634 == -179161)
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

	// Token: 0x06006154 RID: 24916 RVA: 0x00D566A8 File Offset: 0x00D548A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetIceMixer()
	{
		if (95925 - 33408 != 62517)
		{
		}
		for (;;)
		{
			this.Yavc4LyAUOU = new Vector2((float)0, 1f);
			if (291426 - 270769 != 20658)
			{
				this.Qydc4wj9cim = (float)0;
				if (192851 - 101510 != 91342)
				{
					this.SVLc4Nnt7j6 = (float)0;
					if (170841 - 419366 != -248524)
					{
						this.cBuc4E1vrY0 = -1;
						if (295368 - 100387 == 194981)
						{
							this.lmdc4PdoM3Y = (float)0;
							if (239743 - 190633 == 49110)
							{
								this.eOjc4S5ZK3r = string.Empty;
								if (177573 - 597366 == -419793)
								{
									this.c95c4BXQlLZ = string.Empty;
									if (92518 - 532662 != -440143)
									{
										this.pVDc4030m7U = (float)0;
										if (123578 - 412869 != -289290)
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

	// Token: 0x06006155 RID: 24917 RVA: 0x00D56800 File Offset: 0x00D54A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderIceMixer()
	{
		if (175676 - 529285 != -353608)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(0.5f * this.ajgc428cEZj - (float)100, (float)140, (float)512, (float)666));
			if (12617 - 502327 != -489709)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)512, (float)666), this.rcic4Rrwm0g);
				if (124454 - 155750 == -31296)
				{
					eIceMixerGuiState eIceMixerGuiState = this.kSMc4tEha6l;
					if (19271 - 525818 != -506546)
					{
						if (eIceMixerGuiState == eIceMixerGuiState.open)
						{
							if (180601 - 11810 == 168792)
							{
								continue;
							}
							Guix.renderSmallNumber(279, 560, PlayerData.Jil, false, 1f);
							if (236180 - 423675 == -187494)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)185, (float)513, (float)152, (float)41), this.AN6c4s9iAsM.active.background);
							if (75935 - 513446 != -437511)
							{
								continue;
							}
						}
						else if (eIceMixerGuiState == eIceMixerGuiState.ready)
						{
							if (80871 - 241719 == -160847)
							{
								continue;
							}
							Guix.renderSmallNumber(279, 560, PlayerData.Jil, false, 1f);
							if (282066 - 379026 == -96959)
							{
								continue;
							}
							if (this.pVDc4030m7U > Time.time)
							{
								if (68437 - 208514 != -140077)
								{
									continue;
								}
							}
							else if (GUI.Button(new Rect((float)185, (float)513, (float)152, (float)41), string.Empty, this.AN6c4s9iAsM))
							{
								if (229428 - 476249 == -246820)
								{
									continue;
								}
								if (CharacterData.current.getEmptyInventoryCount() < 1)
								{
									if (259161 - 88057 == 171105)
									{
										continue;
									}
									this.c95c4BXQlLZ = "Need one empty inventory slot";
									if (182510 - 271455 == -88944)
									{
										continue;
									}
									this.pVDc4030m7U = Time.time + (float)2;
									if (253535 - 421001 != -167466)
									{
										continue;
									}
								}
								else if (PlayerData.Jil < 5)
								{
									if (204353 - 437863 == -233509)
									{
										continue;
									}
									this.c95c4BXQlLZ = "Not enough jil";
									if (97414 - 565004 == -467589)
									{
										continue;
									}
									this.pVDc4030m7U = Time.time + (float)2;
									if (3799 - 198372 != -194573)
									{
										continue;
									}
								}
								else
								{
									this.kSMc4tEha6l = eIceMixerGuiState.play;
									if (46651 - 497481 == -450829)
									{
										continue;
									}
									this.cIcc4Xbmool = Time.time;
									if (145208 - 87888 != 57320)
									{
										continue;
									}
								}
								this.audio.PlayOneShot(this.INxc471YuFt);
								if (264029 - 492924 != -228895)
								{
									continue;
								}
							}
							if (GUI.Button(new Rect((float)81, (float)23, (float)57, (float)52), string.Empty, this.AGyc4HAFHPW))
							{
								if (211053 - 86046 == 125008)
								{
									continue;
								}
								this.kSMc4tEha6l = eIceMixerGuiState.close;
								if (30905 - 234572 == -203666)
								{
									continue;
								}
								this.cIcc4Xbmool = Time.time;
								if (166324 - 255876 != -89552)
								{
									continue;
								}
								this.audio.PlayOneShot(this.GjCc4MPmiiq);
								if (147651 - 303890 != -156239)
								{
									continue;
								}
								this.v6oc4OVRdZp = GameObject.Find("IceMixer");
								if (153036 - 23183 != 129853)
								{
									continue;
								}
								if (this.v6oc4OVRdZp)
								{
									if (46296 - 73070 != -26774)
									{
										continue;
									}
									this.v6oc4OVRdZp.animation.Stop();
									if (282123 - 513356 == -231232)
									{
										continue;
									}
									this.v6oc4OVRdZp.audio.Stop();
									if (226387 - 464503 != -238116)
									{
										continue;
									}
								}
							}
						}
						else if (eIceMixerGuiState == eIceMixerGuiState.play)
						{
							if (202084 - 49003 == 153082)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)131, (float)502, (float)256, (float)88), this.xMUc43hTAt6);
							if (102475 - 250044 == -147568)
							{
								continue;
							}
						}
						else if (eIceMixerGuiState == eIceMixerGuiState.complete)
						{
							if (150817 - 165964 == -15146)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)131, (float)502, (float)256, (float)88), this.xMUc43hTAt6);
							if (280038 - 586135 == -306096)
							{
								continue;
							}
						}
						GUI.EndGroup();
						if (37248 - 173733 == -136485)
						{
							Matrix4x4 matrix = GUI.matrix;
							if (24398 - 180301 != -155902)
							{
								this.knIc4UM3oRE = Vector2.Angle(this.Yavc4LyAUOU, new Vector2((float)0, -1f));
								if (242616 - 201476 != 41141)
								{
									if (this.Yavc4LyAUOU.x < (float)0)
									{
										if (187347 - 45692 == 141656)
										{
											continue;
										}
										this.knIc4UM3oRE = (float)360 - this.knIc4UM3oRE;
										if (63637 - 224181 != -160544)
										{
											continue;
										}
									}
									GUIUtility.RotateAroundPivot(this.knIc4UM3oRE, new Vector2((0.5f * this.ajgc428cEZj + (float)157) * this.vmVc4v6wqQr, (float)480 * this.vmVc4v6wqQr));
									if (181986 - 456940 == -274954)
									{
										GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj + (float)58, (float)381, (float)196, (float)196), this.BPTc4xSA0R3);
										if (238441 - 28798 == 209643)
										{
											GUI.matrix = matrix;
											if (194494 - 408745 != -214250)
											{
												if (this.kSMc4tEha6l == eIceMixerGuiState.play)
												{
													if (247326 - 469940 != -222614)
													{
														continue;
													}
													if (Input.GetMouseButton(0))
													{
														if (265902 - 215339 == 50564)
														{
															continue;
														}
														GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj + (float)150 + (float)90 * this.Yavc4LyAUOU.x, (float)440 + (float)90 * this.Yavc4LyAUOU.y, (float)45, (float)45), this.iLkc4Tc3NBr);
														if (267502 - 144781 != 122721)
														{
															continue;
														}
													}
												}
												this.SVLc4Nnt7j6 = Mathf.Lerp(this.SVLc4Nnt7j6, (float)6 * this.Qydc4wj9cim, Time.deltaTime);
												if (98862 - 353544 != -254681)
												{
													GUIUtility.RotateAroundPivot(this.SVLc4Nnt7j6, new Vector2((0.5f * this.ajgc428cEZj + (float)157) * this.vmVc4v6wqQr, (float)480 * this.vmVc4v6wqQr));
													if (247187 - 229230 == 17957)
													{
														GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj + (float)119, (float)290, (float)74, (float)214), this.WsHc4ra2FeZ);
														if (95576 - 572445 != -476868)
														{
															GUI.matrix = matrix;
															if (223450 - 351832 == -128382)
															{
																GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj + (float)115, (float)430, (float)86, (float)86), this.Jttc4buKfxI);
																if (256838 - 33780 == 223058)
																{
																	if (this.cBuc4E1vrY0 >= 0)
																	{
																		if (66158 - 434811 == -368652)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj + (float)126, (float)448, (float)64, (float)64), this.SdCc44DEaD7[this.cBuc4E1vrY0]);
																		if (71450 - 390676 != -319226)
																		{
																			continue;
																		}
																	}
																	eIceMixerGuiState eIceMixerGuiState2 = this.kSMc4tEha6l;
																	if (223827 - 168656 != 55172)
																	{
																		if (eIceMixerGuiState2 == eIceMixerGuiState.ready)
																		{
																			if (111499 - 73313 != 38187)
																			{
																				if (this.pVDc4030m7U <= Time.time)
																				{
																					break;
																				}
																				if (258480 - 412003 == -153523)
																				{
																					GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj - (float)30, (float)620, (float)380, (float)100), this.Cujc4dwU4Yq);
																					if (22790 - 151002 == -128212)
																					{
																						GUI.Label(new Rect(0.5f * this.ajgc428cEZj - (float)30, (float)645, (float)300, (float)40), this.c95c4BXQlLZ, this.DU9c4gyN94u);
																						if (192255 - 80448 == 111807)
																						{
																							break;
																						}
																					}
																				}
																			}
																		}
																		else if (eIceMixerGuiState2 == eIceMixerGuiState.play)
																		{
																			if (74760 - 553578 != -478817)
																			{
																				Guix.renderSmallNumber((int)(0.5f * this.ajgc428cEZj + (float)156), 505, (int)Mathf.Round((float)30 - Time.time + this.cIcc4Xbmool), false, 1f);
																				if (264971 - 301629 != -36657)
																				{
																					break;
																				}
																			}
																		}
																		else if (eIceMixerGuiState2 == eIceMixerGuiState.complete)
																		{
																			if (264677 - 531665 == -266988)
																			{
																				GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj - (float)30, (float)284, (float)370, (float)61), this.sZEc4YAkmyc);
																				if (262992 - 516031 == -253039)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			if (eIceMixerGuiState2 != eIceMixerGuiState.finish)
																			{
																				break;
																			}
																			if (72102 - 302876 == -230774)
																			{
																				GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj - (float)30, (float)284, (float)370, (float)61), this.sZEc4YAkmyc);
																				if (296679 - 582006 != -285326)
																				{
																					GUI.DrawTexture(new Rect(0.5f * this.ajgc428cEZj - (float)30, (float)620, (float)380, (float)100), this.Cujc4dwU4Yq);
																					if (113713 - 472720 == -359007)
																					{
																						GUI.Label(new Rect(0.5f * this.ajgc428cEZj, (float)645, (float)300, (float)40), this.eOjc4S5ZK3r, this.DU9c4gyN94u);
																						if (277105 - 461544 == -184439)
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

	// Token: 0x06006156 RID: 24918 RVA: 0x00D574B8 File Offset: 0x00D556B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayIceMixer()
	{
		if (220619 - 222011 != -1392)
		{
		}
		do
		{
			if (Input.GetMouseButton(0))
			{
				if (81241 - 529609 != -448368)
				{
					continue;
				}
				Vector2 vector = (float)30 * Time.deltaTime * new Vector2(Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y")).normalized;
				if (277117 - 120205 == 156913)
				{
					continue;
				}
				Vector2 yavc4LyAUOU = this.Yavc4LyAUOU;
				if (184585 - 435913 == -251327)
				{
					continue;
				}
				if (this.Yavc4LyAUOU.y < (float)0)
				{
					if (23840 - 341100 != -317260)
					{
						continue;
					}
					this.Yavc4LyAUOU.x = this.Yavc4LyAUOU.x + Mathf.Clamp(-this.Yavc4LyAUOU.y * vector.x, (float)0, (float)1);
					if (100848 - 592086 != -491238)
					{
						continue;
					}
				}
				else
				{
					this.Yavc4LyAUOU.x = this.Yavc4LyAUOU.x + Mathf.Clamp(this.Yavc4LyAUOU.y * vector.x, (float)-1, (float)0);
					if (56143 - 36497 == 19647)
					{
						continue;
					}
				}
				if (this.Yavc4LyAUOU.x > (float)0)
				{
					if (286107 - 374658 == -88550)
					{
						continue;
					}
					this.Yavc4LyAUOU.y = this.Yavc4LyAUOU.y + Mathf.Clamp(this.Yavc4LyAUOU.x * vector.y, (float)0, (float)1);
					if (159112 - 214275 == -55162)
					{
						continue;
					}
				}
				else
				{
					this.Yavc4LyAUOU.y = this.Yavc4LyAUOU.y + Mathf.Clamp(-this.Yavc4LyAUOU.x * vector.y, (float)-1, (float)0);
					if (42201 - 355359 == -313157)
					{
						continue;
					}
				}
				this.Yavc4LyAUOU = this.Yavc4LyAUOU.normalized;
				if (235887 - 576493 != -340606)
				{
					continue;
				}
				if (yavc4LyAUOU.y < (float)0)
				{
					if (52666 - 430309 != -377643)
					{
						continue;
					}
					if (yavc4LyAUOU.x < (float)0)
					{
						if (181048 - 149442 != 31606)
						{
							continue;
						}
						if (this.Yavc4LyAUOU.x >= (float)0)
						{
							if (58603 - 217027 == -158423)
							{
								continue;
							}
							this.Qydc4wj9cim += (float)1;
							if (86505 - 250395 == -163889)
							{
								continue;
							}
						}
					}
				}
			}
			if (Time.time > this.lmdc4PdoM3Y)
			{
				if (235480 - 26438 != 209042)
				{
					continue;
				}
				this.lmdc4PdoM3Y = Time.time + 0.2f;
				if (114388 - 87088 != 27300)
				{
					continue;
				}
				int num = (int)UnityEngine.Random.Range(this.Qydc4wj9cim, this.Qydc4wj9cim + (float)6);
				if (243557 - 176513 == 67045)
				{
					continue;
				}
				this.cBuc4E1vrY0 = Mathf.Clamp(global::Math.div((float)(num - 3), (float)5), 0, 12);
				if (160567 - 580477 == -419909)
				{
					continue;
				}
			}
			if (this.Qydc4wj9cim > (float)60)
			{
				if (276520 - 152108 != 124412)
				{
					continue;
				}
				this.Qydc4wj9cim = (float)0;
				if (250753 - 320440 != -69687)
				{
					continue;
				}
			}
			this.Qydc4wj9cim = Mathf.Clamp(this.Qydc4wj9cim - Mathf.Min((float)1 + 0.05f * this.Qydc4wj9cim, 2f) * Time.deltaTime, (float)0, (float)60);
		}
		while (202180 - 430515 != -228335);
	}

	// Token: 0x06006157 RID: 24919 RVA: 0x00D5793C File Offset: 0x00D55B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void IceMakerCompleteOperation(int nPrize)
	{
		if (264711 - 364460 != -99749)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (140970 - 304586 == -163616)
			{
				hashtable.Add(43, PlayerData.UID);
				if (273690 - 473647 != -199956)
				{
					hashtable.Add(21, PhotonClient.cInt16(32));
					if (286521 - 281960 == 4561)
					{
						hashtable.Add(22, PhotonClient.cInt16(1));
						if (16101 - 11707 != 4395)
						{
							hashtable.Add(23, PhotonClient.cInt16(nPrize));
							if (37475 - 585348 != -547872)
							{
								hashtable.Add(24, "0");
								if (104671 - 346621 != -241949)
								{
									PhotonClient.Connection.OpCustom(251, hashtable, true);
									if (151662 - 204900 == -53238)
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

	// Token: 0x06006158 RID: 24920 RVA: 0x00D57AB4 File Offset: 0x00D55CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onIceMakerCompleteOperation(Hashtable data)
	{
		if (256948 - 380771 != -123822)
		{
		}
		for (;;)
		{
			Debug.Log(RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", "onIceMakerCompleteOperation:", data[31]), "@"), data[32]));
			if (171811 - 191334 != -19522)
			{
				this.cBuc4E1vrY0 = RuntimeServices.UnboxInt32(data[33]);
				if (134592 - 10857 != 123736)
				{
					object obj2;
					object obj = obj2 = data[34];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.eOjc4S5ZK3r = (string)obj2;
					if (113097 - 458047 != -344949)
					{
						PlayerData.Jil = RuntimeServices.UnboxInt32(data[49]);
						if (124741 - 71812 == 52929)
						{
							this.kSMc4tEha6l = eIceMixerGuiState.finish;
							if (233918 - 142085 == 91833)
							{
								this.cIcc4Xbmool = Time.time;
								if (93494 - 245563 != -152068)
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

	// Token: 0x06006159 RID: 24921 RVA: 0x00D57C44 File Offset: 0x00D55E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600615A RID: 24922 RVA: 0x00D57C48 File Offset: 0x00D55E48
	internal static bool sXZQ6mpX2cOI8kQ1iIug()
	{
		return true;
	}

	// Token: 0x0600615B RID: 24923 RVA: 0x00D57C4C File Offset: 0x00D55E4C
	internal static bool orcqqOpX83OVNV20Uqku()
	{
		return false;
	}

	// Token: 0x04006E66 RID: 28262
	public int posx;

	// Token: 0x04006E67 RID: 28263
	public int posy;

	// Token: 0x04006E68 RID: 28264
	public int posz;

	// Token: 0x04006E69 RID: 28265
	public int divx;

	// Token: 0x04006E6A RID: 28266
	public int divy;

	// Token: 0x04006E6B RID: 28267
	public int divz;

	// Token: 0x04006E6C RID: 28268
	private eIceMixerGuiState kSMc4tEha6l;

	// Token: 0x04006E6D RID: 28269
	private float cIcc4Xbmool;

	// Token: 0x04006E6E RID: 28270
	private GameObject v6oc4OVRdZp;

	// Token: 0x04006E6F RID: 28271
	private float ajgc428cEZj;

	// Token: 0x04006E70 RID: 28272
	private float vmVc4v6wqQr;

	// Token: 0x04006E71 RID: 28273
	private Texture rX7c4lNGrDq;

	// Token: 0x04006E72 RID: 28274
	private Texture wm8c4GK88Ft;

	// Token: 0x04006E73 RID: 28275
	private GUIStyle XQOc41DQNuK;

	// Token: 0x04006E74 RID: 28276
	private GUIStyle BFZc4qkuhA4;

	// Token: 0x04006E75 RID: 28277
	private string tWec4pSCy93;

	// Token: 0x04006E76 RID: 28278
	private Texture rcic4Rrwm0g;

	// Token: 0x04006E77 RID: 28279
	private Texture WsHc4ra2FeZ;

	// Token: 0x04006E78 RID: 28280
	private Texture BPTc4xSA0R3;

	// Token: 0x04006E79 RID: 28281
	private Texture iLkc4Tc3NBr;

	// Token: 0x04006E7A RID: 28282
	private Texture sZEc4YAkmyc;

	// Token: 0x04006E7B RID: 28283
	private Texture xMUc43hTAt6;

	// Token: 0x04006E7C RID: 28284
	private Texture Jttc4buKfxI;

	// Token: 0x04006E7D RID: 28285
	private Texture Cujc4dwU4Yq;

	// Token: 0x04006E7E RID: 28286
	private GUIStyle DU9c4gyN94u;

	// Token: 0x04006E7F RID: 28287
	private string[] IHsc4aLjwAn;

	// Token: 0x04006E80 RID: 28288
	private Texture[] SdCc44DEaD7;

	// Token: 0x04006E81 RID: 28289
	private GUIStyle AN6c4s9iAsM;

	// Token: 0x04006E82 RID: 28290
	private GUIStyle AGyc4HAFHPW;

	// Token: 0x04006E83 RID: 28291
	private AudioClip INxc471YuFt;

	// Token: 0x04006E84 RID: 28292
	private AudioClip NEFc4ZMAaTj;

	// Token: 0x04006E85 RID: 28293
	private AudioClip t1uc4CdyJpW;

	// Token: 0x04006E86 RID: 28294
	private AudioClip GjCc4MPmiiq;

	// Token: 0x04006E87 RID: 28295
	private AudioClip Fcbc4fZKcI7;

	// Token: 0x04006E88 RID: 28296
	private Vector2 Yavc4LyAUOU;

	// Token: 0x04006E89 RID: 28297
	private float Qydc4wj9cim;

	// Token: 0x04006E8A RID: 28298
	private float knIc4UM3oRE;

	// Token: 0x04006E8B RID: 28299
	private float SVLc4Nnt7j6;

	// Token: 0x04006E8C RID: 28300
	private int cBuc4E1vrY0;

	// Token: 0x04006E8D RID: 28301
	private float lmdc4PdoM3Y;

	// Token: 0x04006E8E RID: 28302
	private string eOjc4S5ZK3r;

	// Token: 0x04006E8F RID: 28303
	private string c95c4BXQlLZ;

	// Token: 0x04006E90 RID: 28304
	private float pVDc4030m7U;
}
