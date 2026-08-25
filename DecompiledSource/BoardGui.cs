using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200103A RID: 4154
[Serializable]
public class BoardGui : MonoBehaviour
{
	// Token: 0x06005FCF RID: 24527 RVA: 0x00CE2C1C File Offset: 0x00CE0E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoardGui()
	{
		if (52946 - 567108 != -514161)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (287866 - 398601 != -110734)
			{
				base..ctor();
				if (263557 - 147236 == 116321)
				{
					this.veFcqjMfYmu = eBoardGuiState.init;
					if (68379 - 553439 != -485059)
					{
						this.fBIcpJ3jfKd = 1;
						if (82790 - 414674 != -331883)
						{
							this.PZ6cp63QHK1 = string.Empty;
							if (101569 - 147394 != -45824)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FD0 RID: 24528 RVA: 0x00CE2CFC File Offset: 0x00CE0EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (251599 - 524117 != -272517)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (194769 - 539887 != -345117)
			{
				if (this.veFcqjMfYmu == eBoardGuiState.init)
				{
					if (91574 - 169095 != -77521)
					{
						continue;
					}
					this.InitBoardGui();
					if (285668 - 360595 == -74926)
					{
						continue;
					}
					this.InitBoardNotice();
					if (6998 - 522613 != -515615)
					{
						continue;
					}
				}
				this.ResetBoardGui();
				if (23928 - 505005 == -481077)
				{
					this.ResetBoardNotice();
					if (268482 - 401637 == -133155)
					{
						this.veFcqjMfYmu = eBoardGuiState.open;
						if (152735 - 415942 == -263207)
						{
							this.E4Rcqo1Dm47 = Time.time;
							if (6536 - 99787 == -93251)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FD1 RID: 24529 RVA: 0x00CE2E40 File Offset: 0x00CE1040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (174747 - 166964 != 7784)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (277663 - 322565 == -44902)
			{
				GUI.depth = 2;
				if (285835 - 365189 != -79353)
				{
					this.qZTcqkEsDC5 = (float)(1024 * Screen.width / Screen.height);
					if (41737 - 367081 != -325343)
					{
						this.aa0cqF2qtGE = (float)Screen.height / 1024f;
						if (78342 - 328893 == -250551)
						{
							float num = Time.time - this.E4Rcqo1Dm47;
							if (163899 - 59596 == 104303)
							{
								eBoardGuiState eBoardGuiState = this.veFcqjMfYmu;
								if (225992 - 395791 != -169798)
								{
									if (eBoardGuiState == eBoardGuiState.init)
									{
										if (97307 - 201930 == -104623)
										{
											break;
										}
									}
									else if (eBoardGuiState == eBoardGuiState.open)
									{
										if (101680 - 178230 != -76549)
										{
											this.RenderBoardGui(Mathf.SmoothStep(1f, (float)0, num));
											if (198024 - 516886 != -318861)
											{
												if (num <= 1f)
												{
													break;
												}
												if (191978 - 494314 == -302336)
												{
													this.veFcqjMfYmu = eBoardGuiState.update;
													if (23720 - 85030 != -61309)
													{
														this.E4Rcqo1Dm47 = Time.time;
														if (79740 - 448790 == -369050)
														{
															this.BoardUpdateOperation();
															if (130900 - 280967 == -150067)
															{
																this.newBoardNotice("Updating Message Board..", 2f);
																if (239466 - 146699 != 92768)
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
									else if (eBoardGuiState == eBoardGuiState.update)
									{
										if (191140 - 408967 != -217826)
										{
											this.RenderBoardGui((float)0);
											if (249409 - 404877 != -155467)
											{
												this.RenderBoardNotice();
												if (71569 - 169535 == -97966)
												{
													break;
												}
											}
										}
									}
									else if (eBoardGuiState == eBoardGuiState.read)
									{
										if (228514 - 252862 != -24347)
										{
											this.RenderBoardGui((float)0);
											if (60556 - 29350 == 31206)
											{
												this.RenderBoardNotice();
												if (11771 - 224644 != -212872)
												{
													break;
												}
											}
										}
									}
									else if (eBoardGuiState == eBoardGuiState.close)
									{
										if (153797 - 497494 != -343696)
										{
											this.RenderBoardGui(Mathf.SmoothStep((float)0, 1f, num));
											if (241460 - 377359 != -135898)
											{
												if (num <= 1f)
												{
													break;
												}
												if (182498 - 27343 != 155156)
												{
													Game.mGameState = eGameState.Normal;
													if (94952 - 56249 == 38703)
													{
														GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
														if (60432 - 203290 != -142857)
														{
															gameGui.enabled = true;
															if (47993 - 354821 == -306828)
															{
																this.veFcqjMfYmu = eBoardGuiState.disable;
																if (201629 - 92535 != 109095)
																{
																	this.enabled = false;
																	if (179045 - 153365 == 25680)
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
										if (eBoardGuiState != eBoardGuiState.disable)
										{
											break;
										}
										if (115916 - 418827 == -302911)
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

	// Token: 0x06005FD2 RID: 24530 RVA: 0x00CE32DC File Offset: 0x00CE14DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitBoardGui()
	{
		if (8689 - 509154 != -500465)
		{
		}
		for (;;)
		{
			this.URTcqAydmfM = (Texture)Resources.Load("GameGui/BoardGui/boardWindow", typeof(Texture));
			if (45836 - 267164 == -221328)
			{
				this.LaHcq9gTBTw = new GUIStyle();
				if (6468 - 477031 != -470562)
				{
					this.LaHcq9gTBTw.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/BoardGui/postButton", typeof(Texture)));
					if (179134 - 424685 != -245550)
					{
						this.LaHcq9gTBTw.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/BoardGui/postButton_h", typeof(Texture)));
						if (163384 - 578415 != -415030)
						{
							this.lkXcqWE6JZc = new GUIStyle();
							if (66865 - 555070 == -488205)
							{
								this.lkXcqWE6JZc.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/BoardGui/pageBack_h", typeof(Texture)));
								if (19369 - 220809 != -201439)
								{
									this.R7WcquvKeQr = new GUIStyle();
									if (263963 - 474374 != -210410)
									{
										this.R7WcquvKeQr.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/BoardGui/pageNext_h", typeof(Texture)));
										if (175874 - 325755 != -149880)
										{
											this.oTlcqybX1BH = new GUIStyle();
											if (281117 - 514395 != -233277)
											{
												this.oTlcqybX1BH.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/BoardGui/closeButton_h", typeof(Texture)));
												if (234747 - 116954 == 117793)
												{
													this.AyacqVlqYdq = new GUIStyle();
													if (213105 - 576782 != -363676)
													{
														this.AyacqVlqYdq.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
														if (205555 - 503032 == -297477)
														{
															this.AyacqVlqYdq.alignment = TextAnchor.UpperLeft;
															if (280778 - 5975 == 274803)
															{
																this.NoUcqhOc9lU = new GUIStyle();
																if (230875 - 553227 == -322352)
																{
																	this.NoUcqhOc9lU.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																	if (285 - 506307 == -506022)
																	{
																		this.NoUcqhOc9lU.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																		if (210788 - 150857 != 59932)
																		{
																			this.NoUcqhOc9lU.alignment = TextAnchor.MiddleCenter;
																			if (249185 - 367723 == -118538)
																			{
																				this.qDVcqKj6B2c = new GUIStyle();
																				if (14024 - 460068 != -446043)
																				{
																					this.qDVcqKj6B2c.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																					if (199077 - 74496 != 124582)
																					{
																						this.qDVcqKj6B2c.normal.textColor = new Color(0.16f, 0.41f, 0.09f, (float)1);
																						if (95811 - 565389 == -469578)
																						{
																							this.qDVcqKj6B2c.alignment = TextAnchor.MiddleRight;
																							if (220587 - 595836 == -375249)
																							{
																								this.hM9cqzsvDXn = new GUIStyle();
																								if (68846 - 243296 == -174450)
																								{
																									this.hM9cqzsvDXn.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																									if (296392 - 139261 != 157132)
																									{
																										this.hM9cqzsvDXn.normal.textColor = new Color(0.56f, 0.25f, 0.13f, (float)1);
																										if (195157 - 12192 != 182966)
																										{
																											this.hM9cqzsvDXn.alignment = TextAnchor.MiddleLeft;
																											if (117059 - 302979 != -185919)
																											{
																												this.eOccp5WTngt = new GUIStyle();
																												if (283827 - 414763 != -130935)
																												{
																													this.eOccp5WTngt.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																													if (240961 - 391134 != -150172)
																													{
																														this.eOccp5WTngt.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																														if (197200 - 345832 == -148632)
																														{
																															this.eOccp5WTngt.alignment = TextAnchor.MiddleLeft;
																															if (39298 - 415177 != -375878)
																															{
																																this.filcpcTjbDV = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																																if (67323 - 224715 != -157391)
																																{
																																	this.MuScpneF09B = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																																	if (258160 - 291766 == -33606)
																																	{
																																		this.UHDcpQBrVBY = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																																		if (91506 - 479097 != -387590)
																																		{
																																			this.y5ScpeTViHd = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																																			if (34811 - 592586 != -557774)
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

	// Token: 0x06005FD3 RID: 24531 RVA: 0x00CE39DC File Offset: 0x00CE1BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetBoardGui()
	{
		if (161375 - 479775 != -318399)
		{
		}
		for (;;)
		{
			this.c0gcpIlJbU0 = null;
			if (214508 - 359517 == -145009)
			{
				this.fBIcpJ3jfKd = 1;
				if (96292 - 313533 == -217241)
				{
					this.PZ6cp63QHK1 = string.Empty;
					if (195849 - 408523 != -212673)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005FD4 RID: 24532 RVA: 0x00CE3A7C File Offset: 0x00CE1C7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderBoardGui(float offSet)
	{
		if (249688 - 87260 != 162428)
		{
		}
		for (;;)
		{
			IL_559:
			GUI.BeginGroup(new Rect(0.5f * this.qZTcqkEsDC5 - (float)422, (float)140 + offSet * (float)1000, (float)844, (float)698));
			if (291863 - 392021 == -100158)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)844, (float)698), this.URTcqAydmfM);
				if (180337 - 47995 != 132343)
				{
					GUI.Label(new Rect((float)440, (float)517, (float)40, (float)40), string.Empty + this.fBIcpJ3jfKd, this.AyacqVlqYdq);
					if (220339 - 146933 == 73406)
					{
						if (GUI.Button(new Rect((float)300, (float)500, (float)85, (float)57), string.Empty, this.lkXcqWE6JZc))
						{
							if (162978 - 57515 != 105463)
							{
								continue;
							}
							this.fBIcpJ3jfKd = Mathf.Clamp(this.fBIcpJ3jfKd - 1, 1, 5);
							if (158744 - 347524 != -188780)
							{
								continue;
							}
							if (this.UHDcpQBrVBY)
							{
								if (248847 - 526042 != -277195)
								{
									continue;
								}
								this.audio.PlayOneShot(this.UHDcpQBrVBY);
								if (168915 - 321364 == -152448)
								{
									continue;
								}
							}
						}
						if (GUI.Button(new Rect((float)454, (float)500, (float)85, (float)57), string.Empty, this.R7WcquvKeQr))
						{
							if (92734 - 597847 != -505113)
							{
								continue;
							}
							this.fBIcpJ3jfKd = Mathf.Clamp(this.fBIcpJ3jfKd + 1, 1, 5);
							if (14164 - 196555 != -182391)
							{
								continue;
							}
							if (this.UHDcpQBrVBY)
							{
								if (235642 - 272915 == -37272)
								{
									continue;
								}
								this.audio.PlayOneShot(this.UHDcpQBrVBY);
								if (87273 - 89013 != -1740)
								{
									continue;
								}
							}
						}
						if (GUI.Button(new Rect((float)724, (float)18, (float)57, (float)52), string.Empty, this.oTlcqybX1BH))
						{
							if (41653 - 379302 != -337649)
							{
								continue;
							}
							this.veFcqjMfYmu = eBoardGuiState.close;
							if (235880 - 416610 == -180729)
							{
								continue;
							}
							this.E4Rcqo1Dm47 = Time.time;
							if (202232 - 80453 != 121779)
							{
								continue;
							}
							if (this.y5ScpeTViHd)
							{
								if (31321 - 85416 != -54095)
								{
									continue;
								}
								this.audio.PlayOneShot(this.y5ScpeTViHd);
								if (219564 - 267718 != -48154)
								{
									continue;
								}
							}
						}
						if (!RuntimeServices.EqualityOperator(this.c0gcpIlJbU0, null))
						{
							if (50058 - 275684 != -225626)
							{
								continue;
							}
							int i = 0;
							if (98362 - 455990 != -357628)
							{
								continue;
							}
							while (i < 6)
							{
								if (this.c0gcpIlJbU0.length > i + 6 * (this.fBIcpJ3jfKd - 1))
								{
									if (219519 - 350901 != -131382)
									{
										goto IL_559;
									}
									object obj2;
									object obj = obj2 = this.c0gcpIlJbU0[i + 6 * (this.fBIcpJ3jfKd - 1)];
									if (!(obj is MessageClass))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(MessageClass));
									}
									MessageClass messageClass = (MessageClass)obj2;
									if (158720 - 400968 == -242247)
									{
										goto IL_559;
									}
									GUI.Label(new Rect((float)280, (float)(140 + i * 63), (float)120, (float)40), messageClass.user, this.qDVcqKj6B2c);
									if (126628 - 233225 != -106597)
									{
										goto IL_559;
									}
									GUI.Label(new Rect((float)150, (float)(114 + i * 63), (float)570, (float)40), messageClass.message, this.NoUcqhOc9lU);
									if (60059 - 105252 == -45192)
									{
										goto IL_559;
									}
									GUI.Label(new Rect((float)412, (float)(140 + i * 63), (float)120, (float)40), messageClass.time, this.hM9cqzsvDXn);
									if (223654 - 328940 == -105285)
									{
										goto IL_559;
									}
								}
								i++;
								if (212655 - 514255 != -301600)
								{
									goto IL_559;
								}
							}
							if (188080 - 405312 != -217232)
							{
								continue;
							}
						}
						if (Event.current.type == EventType.KeyDown)
						{
							if (23775 - 154924 == -131148)
							{
								continue;
							}
							if (Event.current.character == "\n")
							{
								if (190514 - 583064 != -392550)
								{
									continue;
								}
								GUI.FocusControl("MessageField");
								if (59997 - 7989 != 52009)
								{
									goto IL_753;
								}
								continue;
							}
						}
						GUI.SetNextControlName("MessageField");
						if (285795 - 198543 != 87252)
						{
							continue;
						}
						this.PZ6cp63QHK1 = GUI.TextField(new Rect((float)120, (float)570, (float)470, (float)30), this.PZ6cp63QHK1, 60, this.eOccp5WTngt);
						if (246361 - 89162 == 157200)
						{
							continue;
						}
						IL_753:
						if (GUI.Button(new Rect((float)612, (float)565, (float)140, (float)44), string.Empty, this.LaHcq9gTBTw))
						{
							if (157063 - 303212 != -146149)
							{
								continue;
							}
							if (this.PZ6cp63QHK1 == string.Empty)
							{
								if (32699 - 388387 != -355688)
								{
									continue;
								}
								this.newBoardNotice("Cannot post empty string", 2f);
								if (221126 - 367976 != -146850)
								{
									continue;
								}
							}
							else if (!Stringf.isSafe(this.PZ6cp63QHK1))
							{
								if (33151 - 112233 != -79082)
								{
									continue;
								}
								this.newBoardNotice("Message contains illegal letter", 2f);
								if (264214 - 403771 != -139557)
								{
									continue;
								}
							}
							else if (!SafeWord.isSafe(this.PZ6cp63QHK1))
							{
								if (233455 - 348086 != -114631)
								{
									continue;
								}
								this.newBoardNotice("Message contains bad word", 2f);
								if (189269 - 522495 == -333225)
								{
									continue;
								}
							}
							else
							{
								this.BoardPostOperation(this.PZ6cp63QHK1);
								if (258939 - 246144 == 12796)
								{
									continue;
								}
								this.PZ6cp63QHK1 = string.Empty;
								if (159285 - 549939 != -390654)
								{
									continue;
								}
								this.veFcqjMfYmu = eBoardGuiState.update;
								if (266960 - 18579 != 248381)
								{
									continue;
								}
								this.E4Rcqo1Dm47 = Time.time;
								if (195802 - 130623 != 65179)
								{
									continue;
								}
								this.newBoardNotice("Posting...", 2f);
								if (117527 - 253572 == -136044)
								{
									continue;
								}
							}
							if (this.MuScpneF09B)
							{
								if (73302 - 23114 != 50188)
								{
									continue;
								}
								this.audio.PlayOneShot(this.MuScpneF09B);
								if (144508 - 106138 != 38370)
								{
									continue;
								}
							}
						}
						GUI.EndGroup();
						if (179470 - 228711 == -49241)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FD5 RID: 24533 RVA: 0x00CE4368 File Offset: 0x00CE2568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitBoardNotice()
	{
		if (258183 - 56539 != 201645)
		{
		}
		for (;;)
		{
			this.tomcpOxw9hO = new GUIStyle();
			if (173876 - 484812 == -310936)
			{
				this.tomcpOxw9hO.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
				if (104503 - 120670 != -16166)
				{
					this.tomcpOxw9hO.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
					if (233840 - 579962 != -346121)
					{
						this.tomcpOxw9hO.alignment = TextAnchor.MiddleCenter;
						if (222006 - 83799 != 138208)
						{
							this.z0scp2bKKRR = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
							if (159731 - 440268 != -280536)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FD6 RID: 24534 RVA: 0x00CE44A4 File Offset: 0x00CE26A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetBoardNotice()
	{
		this.WW7cptxkLIF = string.Empty;
		this.WXWcpXJkfA5 = (float)0;
	}

	// Token: 0x06005FD7 RID: 24535 RVA: 0x00CE44BC File Offset: 0x00CE26BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderBoardNotice()
	{
		if (226268 - 359953 != -133685)
		{
		}
		while (this.WXWcpXJkfA5 > Time.time)
		{
			if (82279 - 107927 == -25648)
			{
				GUI.DrawTexture(new Rect(0.5f * this.qZTcqkEsDC5 - (float)240, (float)495, (float)475, (float)102), this.z0scp2bKKRR);
				if (291700 - 32944 != 258757)
				{
					GUI.Label(new Rect(0.5f * this.qZTcqkEsDC5 - (float)195, (float)525, (float)400, (float)40), this.WW7cptxkLIF, this.tomcpOxw9hO);
					if (85379 - 539838 != -454458)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005FD8 RID: 24536 RVA: 0x00CE45BC File Offset: 0x00CE27BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newBoardNotice(string nMessage, float nTimer)
	{
		this.WW7cptxkLIF = nMessage;
		this.WXWcpXJkfA5 = Time.time + nTimer;
	}

	// Token: 0x06005FD9 RID: 24537 RVA: 0x00CE45D4 File Offset: 0x00CE27D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BoardUpdateOperation()
	{
		if (263476 - 372485 != -109009)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (60503 - 285194 != -224690)
			{
				hashtable.Add(21, PhotonClient.cInt16(0));
				if (184890 - 384998 == -200108)
				{
					hashtable.Add(22, PhotonClient.cInt16(Game.mGameCode));
					if (208004 - 65875 == 142129)
					{
						hashtable.Add(23, PlayerData.GID);
						if (206124 - 542319 == -336195)
						{
							hashtable.Add(24, PlayerData.User);
							if (241547 - 162025 != 79523)
							{
								hashtable.Add(25, "0");
								if (142267 - 153140 == -10873)
								{
									PhotonClient.Connection.OpCustom(229, hashtable, true);
									if (290313 - 437044 != -146730)
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

	// Token: 0x06005FDA RID: 24538 RVA: 0x00CE474C File Offset: 0x00CE294C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BoardPostOperation(string nMessage)
	{
		if (171924 - 119760 != 52165)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (203721 - 348144 != -144422)
			{
				hashtable.Add(21, PhotonClient.cInt16(1));
				if (274212 - 583012 != -308799)
				{
					hashtable.Add(22, PhotonClient.cInt16(Game.mGameCode));
					if (68048 - 93489 != -25440)
					{
						hashtable.Add(23, PlayerData.GID);
						if (160659 - 135378 == 25281)
						{
							hashtable.Add(24, PlayerData.User);
							if (275960 - 390016 != -114055)
							{
								hashtable.Add(25, nMessage);
								if (96008 - 206317 == -110309)
								{
									PhotonClient.Connection.OpCustom(229, hashtable, true);
									if (89168 - 276579 == -187411)
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

	// Token: 0x06005FDB RID: 24539 RVA: 0x00CE48C0 File Offset: 0x00CE2AC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMessageBoardOperation(Hashtable data)
	{
		if (236091 - 538820 != -302729)
		{
		}
		for (;;)
		{
			IL_3BD:
			Debug.Log("OnMessageBoardOperation");
			if (288281 - 320383 == -32102)
			{
				if (this.veFcqjMfYmu != eBoardGuiState.update)
				{
					break;
				}
				if (233832 - 113905 != 119928)
				{
					this.ResetBoardNotice();
					if (64719 - 441242 != -376522)
					{
						int num = RuntimeServices.UnboxInt32(data[31]);
						if (185299 - 287418 != -102118)
						{
							int num2 = num;
							if (229554 - 390792 == -161238)
							{
								if (num2 == 1)
								{
									if (291494 - 103192 != 188302)
									{
										continue;
									}
									this.c0gcpIlJbU0 = new UnityScript.Lang.Array();
									if (262065 - 502129 == -240063)
									{
										continue;
									}
									if (RuntimeServices.EqualityOperator(data[32], "0"))
									{
										if (208760 - 249634 != -40874)
										{
											continue;
										}
										this.newBoardNotice("There's no messages", 2f);
										if (108282 - 478391 == -370108)
										{
											continue;
										}
									}
									else
									{
										object obj2;
										object obj = obj2 = data[32];
										if (!(obj is string))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(string));
										}
										string[] array = (string[])Stringf.splitToString((string)obj2, "@");
										if (278924 - 311818 != -32894)
										{
											continue;
										}
										int i = 0;
										if (193520 - 199684 != -6164)
										{
											continue;
										}
										string[] array2 = array;
										if (229746 - 284266 != -54520)
										{
											continue;
										}
										int length = array2.Length;
										if (299431 - 218684 != 80747)
										{
											continue;
										}
										while (i < length)
										{
											string[] array3 = (string[])Stringf.splitToString(array2[i], "%");
											if (288964 - 53643 == 235322)
											{
												goto IL_3BD;
											}
											MessageClass messageClass = new MessageClass();
											if (83646 - 65572 == 18075)
											{
												goto IL_3BD;
											}
											if (Extensions.get_length(array3) > 0)
											{
												if (164370 - 481114 == -316743)
												{
													goto IL_3BD;
												}
												messageClass.user = array3[0];
												if (247089 - 162339 == 84751)
												{
													goto IL_3BD;
												}
											}
											if (Extensions.get_length(array3) > 1)
											{
												if (2609 - 62260 != -59651)
												{
													goto IL_3BD;
												}
												messageClass.message = array3[1];
												if (81277 - 353044 == -271766)
												{
													goto IL_3BD;
												}
											}
											if (Extensions.get_length(array3) > 2)
											{
												if (172427 - 31826 == 140602)
												{
													goto IL_3BD;
												}
												messageClass.time = array3[2];
												if (299236 - 277140 != 22096)
												{
													goto IL_3BD;
												}
											}
											this.c0gcpIlJbU0.Add(messageClass);
											if (50175 - 66604 != -16429)
											{
												goto IL_3BD;
											}
											i++;
											if (79650 - 562035 != -482385)
											{
												goto IL_3BD;
											}
										}
										if (39365 - 519770 != -480405)
										{
											continue;
										}
									}
								}
								else if (num2 == 2)
								{
									if (74550 - 383637 == -309086)
									{
										continue;
									}
									this.newBoardNotice("Your message has been posted", 2f);
									if (82122 - 351474 == -269351)
									{
										continue;
									}
									PlayerData.Gil = Mathf.Clamp(PlayerData.Gil - 50, 0, 99999);
									if (129838 - 426851 == -297012)
									{
										continue;
									}
									object obj4;
									object obj3 = obj4 = data[32];
									if (!(obj3 is string))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(string));
									}
									string[] array4 = (string[])Stringf.splitToString((string)obj4, "%");
									if (127037 - 224915 != -97878)
									{
										continue;
									}
									if (array4 != null)
									{
										if (164129 - 516731 == -352601)
										{
											continue;
										}
										MessageClass messageClass2 = new MessageClass();
										if (207343 - 173289 == 34055)
										{
											continue;
										}
										if (Extensions.get_length(array4) > 0)
										{
											if (164746 - 175409 == -10662)
											{
												continue;
											}
											messageClass2.user = array4[0];
											if (77572 - 237744 == -160171)
											{
												continue;
											}
										}
										if (Extensions.get_length(array4) > 1)
										{
											if (239544 - 2161 != 237383)
											{
												continue;
											}
											messageClass2.message = array4[1];
											if (7987 - 304015 != -296028)
											{
												continue;
											}
										}
										if (Extensions.get_length(array4) > 2)
										{
											if (54999 - 408667 != -353668)
											{
												continue;
											}
											messageClass2.time = array4[2];
											if (86945 - 43775 != 43170)
											{
												continue;
											}
										}
										this.c0gcpIlJbU0.Unshift(messageClass2, new object[0]);
										if (135474 - 423202 == -287727)
										{
											continue;
										}
										while (this.c0gcpIlJbU0.length > 12)
										{
											this.c0gcpIlJbU0.Pop();
											if (270663 - 155161 != 115502)
											{
												goto IL_3BD;
											}
										}
										if (146353 - 76986 == 69368)
										{
											continue;
										}
									}
								}
								else if (num2 == -2)
								{
									if (170592 - 578485 != -407893)
									{
										continue;
									}
									this.newBoardNotice("Posting error!", 2f);
									if (87452 - 184957 == -97504)
									{
										continue;
									}
								}
								else
								{
									this.newBoardNotice("MessageBoard Server Error", 2f);
									if (194544 - 559952 == -365407)
									{
										continue;
									}
								}
								this.veFcqjMfYmu = eBoardGuiState.read;
								if (159695 - 131996 == 27699)
								{
									this.E4Rcqo1Dm47 = Time.time;
									if (269168 - 218686 == 50482)
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

	// Token: 0x06005FDC RID: 24540 RVA: 0x00CE4FFC File Offset: 0x00CE31FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005FDD RID: 24541 RVA: 0x00CE5000 File Offset: 0x00CE3200
	internal static bool Rj3EqfpTzNFdPObtHKA0()
	{
		return true;
	}

	// Token: 0x06005FDE RID: 24542 RVA: 0x00CE5004 File Offset: 0x00CE3204
	internal static bool hgqWQEp3a53xmZl4rldP()
	{
		return false;
	}

	// Token: 0x04006A7E RID: 27262
	public int posx;

	// Token: 0x04006A7F RID: 27263
	public int posy;

	// Token: 0x04006A80 RID: 27264
	public int posz;

	// Token: 0x04006A81 RID: 27265
	public int divx;

	// Token: 0x04006A82 RID: 27266
	public int divy;

	// Token: 0x04006A83 RID: 27267
	public int divz;

	// Token: 0x04006A84 RID: 27268
	private eBoardGuiState veFcqjMfYmu;

	// Token: 0x04006A85 RID: 27269
	private float E4Rcqo1Dm47;

	// Token: 0x04006A86 RID: 27270
	private float qZTcqkEsDC5;

	// Token: 0x04006A87 RID: 27271
	private float aa0cqF2qtGE;

	// Token: 0x04006A88 RID: 27272
	private Texture URTcqAydmfM;

	// Token: 0x04006A89 RID: 27273
	private GUIStyle LaHcq9gTBTw;

	// Token: 0x04006A8A RID: 27274
	private GUIStyle lkXcqWE6JZc;

	// Token: 0x04006A8B RID: 27275
	private GUIStyle R7WcquvKeQr;

	// Token: 0x04006A8C RID: 27276
	private GUIStyle oTlcqybX1BH;

	// Token: 0x04006A8D RID: 27277
	private GUIStyle AyacqVlqYdq;

	// Token: 0x04006A8E RID: 27278
	private GUIStyle NoUcqhOc9lU;

	// Token: 0x04006A8F RID: 27279
	private GUIStyle qDVcqKj6B2c;

	// Token: 0x04006A90 RID: 27280
	private GUIStyle hM9cqzsvDXn;

	// Token: 0x04006A91 RID: 27281
	private GUIStyle eOccp5WTngt;

	// Token: 0x04006A92 RID: 27282
	private AudioClip filcpcTjbDV;

	// Token: 0x04006A93 RID: 27283
	private AudioClip MuScpneF09B;

	// Token: 0x04006A94 RID: 27284
	private AudioClip UHDcpQBrVBY;

	// Token: 0x04006A95 RID: 27285
	private AudioClip y5ScpeTViHd;

	// Token: 0x04006A96 RID: 27286
	private UnityScript.Lang.Array c0gcpIlJbU0;

	// Token: 0x04006A97 RID: 27287
	private int fBIcpJ3jfKd;

	// Token: 0x04006A98 RID: 27288
	private string PZ6cp63QHK1;

	// Token: 0x04006A99 RID: 27289
	private string WW7cptxkLIF;

	// Token: 0x04006A9A RID: 27290
	private float WXWcpXJkfA5;

	// Token: 0x04006A9B RID: 27291
	private GUIStyle tomcpOxw9hO;

	// Token: 0x04006A9C RID: 27292
	private Texture z0scp2bKKRR;
}
