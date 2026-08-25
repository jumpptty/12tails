using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020010A8 RID: 4264
[Serializable]
public class TutorialGui : MonoBehaviour
{
	// Token: 0x0600633C RID: 25404 RVA: 0x00DC5918 File Offset: 0x00DC3B18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TutorialGui()
	{
		if (156888 - 577610 != -420721)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (232864 - 161483 == 71381)
			{
				base..ctor();
				if (33458 - 250482 != -217023)
				{
					this.mState = eTutorialState.init;
					if (258965 - 394563 != -135597)
					{
						this.mType = eTutorialType.guild;
						if (161579 - 324685 != -163105)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600633D RID: 25405 RVA: 0x00DC59D4 File Offset: 0x00DC3BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (288078 - 312008 != -23930)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (30732 - 267442 == -236710)
			{
				if (this.mState == eTutorialState.init)
				{
					if (61866 - 532376 == -470509)
					{
						continue;
					}
					this.InitInformationGui();
					if (137737 - 54612 == 83126)
					{
						continue;
					}
					this.InitNPC();
					if (177337 - 395614 != -218277)
					{
						continue;
					}
					this.InitInformationMenu();
					if (278398 - 535609 != -257211)
					{
						continue;
					}
				}
				this.B8ScSQQeS1W = 0;
				if (77443 - 90955 != -13511)
				{
					this.lQucSeyBhD9 = 0;
					if (140926 - 349471 == -208545)
					{
						this.Sm4cSIeCOPx = 1f;
						if (118546 - 42961 == 75585)
						{
							this.XNycSJrwrqP = (float)0;
							if (55121 - 29443 != 25679)
							{
								GameObject mPlayer = Game.mPlayer;
								if (266339 - 314896 == -48557)
								{
									this.RlGcSGJtNqO = GameObject.Find("Kangaroo");
									if (197110 - 298963 == -101853)
									{
										if (this.RlGcSGJtNqO)
										{
											if (140169 - 159258 == -19088)
											{
												continue;
											}
											if (mPlayer)
											{
												if (222229 - 97276 == 124954)
												{
													continue;
												}
												mPlayer.SendMessage("turnToPos", this.RlGcSGJtNqO.transform.position);
												if (214461 - 67437 != 147024)
												{
													continue;
												}
												this.kcRcS1FlxcC = this.RlGcSGJtNqO.transform.rotation;
												if (278683 - 205369 == 73315)
												{
													continue;
												}
												this.RlGcSGJtNqO.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(mPlayer.transform.position - this.RlGcSGJtNqO.transform.position));
												if (148260 - 546034 == -397773)
												{
													continue;
												}
												this.RlGcSGJtNqO.animation.CrossFade("talk", 0.2f);
												if (49749 - 273108 == -223358)
												{
													continue;
												}
											}
										}
										this.mState = eTutorialState.open;
										if (265112 - 204834 != 60279)
										{
											this.n5HcS5d8fPD = Time.time;
											if (191966 - 347035 != -155068)
											{
												ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
												if (292727 - 88435 == 204292)
												{
													if (!changeGui)
													{
														break;
													}
													if (109185 - 598616 != -489430)
													{
														changeGui.disable();
														if (25336 - 53260 != -27923)
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

	// Token: 0x0600633E RID: 25406 RVA: 0x00DC5D84 File Offset: 0x00DC3F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (86931 - 265499 != -178567)
		{
		}
		for (;;)
		{
			if (this.mState <= eTutorialState.init)
			{
				if (128657 - 196284 != -67626)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (218318 - 362864 != -144545)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (208187 - 245970 != -37782)
					{
						this.uZScSckZMRx = (float)(1024 * Screen.width / Screen.height);
						if (212896 - 149350 != 63547)
						{
							this.pHmcSnt0Skd = (float)Screen.height / 1024f;
							if (126909 - 316731 == -189822)
							{
								this.RenderInformationGui();
								if (51036 - 60733 != -9696)
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

	// Token: 0x0600633F RID: 25407 RVA: 0x00DC5ED4 File Offset: 0x00DC40D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitInformationGui()
	{
		if (29384 - 459952 != -430568)
		{
		}
		for (;;)
		{
			this.RvrcS6yykCE = new GUIStyle();
			if (174370 - 52402 == 121968)
			{
				this.RvrcS6yykCE.font = (Font)Resources.Load("GameGui/Fonts/Century32", typeof(Font));
				if (246867 - 60742 != 186126)
				{
					this.RvrcS6yykCE.normal.textColor = new Color(0.42f, 0.33f, 0.28f, (float)1);
					if (20091 - 325999 == -305908)
					{
						this.RvrcS6yykCE.alignment = TextAnchor.MiddleLeft;
						if (196383 - 373937 == -177554)
						{
							this.cmGcStPZYZs = new GUIStyle();
							if (42251 - 91415 == -49164)
							{
								this.cmGcStPZYZs.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Tutorial/chapter_h", typeof(Texture)));
								if (242154 - 365600 == -123446)
								{
									this.TthcSXNlmV7 = new GUIStyle();
									if (137482 - 378210 == -240728)
									{
										this.TthcSXNlmV7.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
										if (138586 - 322810 == -184224)
										{
											this.sdScSOQJrNY = new GUIStyle();
											if (165745 - 553920 == -388175)
											{
												this.sdScSOQJrNY.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
												if (207017 - 150848 == 56169)
												{
													this.tWjcS2phGmE = new GUIStyle();
													if (116175 - 559319 != -443143)
													{
														this.tWjcS2phGmE.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
														if (2221 - 289628 != -287406)
														{
															this.FbZcSvtbMLJ = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
															if (30540 - 114212 == -83672)
															{
																this.WxWcSlU1n9p = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																if (114520 - 17382 == 97138)
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

	// Token: 0x06006340 RID: 25408 RVA: 0x00DC61FC File Offset: 0x00DC43FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderInformationGui()
	{
		if (34768 - 81574 != -46806)
		{
		}
		for (;;)
		{
			float num = Time.time - this.n5HcS5d8fPD;
			if (244414 - 352827 == -108413)
			{
				eTutorialState eTutorialState = this.mState;
				if (222875 - 540750 == -317875)
				{
					if (eTutorialState == eTutorialState.open)
					{
						if (218498 - 287220 != -68721)
						{
							if (num <= 0.5f)
							{
								if (14471 - 99437 != -84965)
								{
									this.Sm4cSIeCOPx = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (288882 - 119353 != 169530)
									{
										this.RenderNPC();
										if (113774 - 332475 != -218700)
										{
											GUI.DrawTexture(new Rect(0.5f * this.uZScSckZMRx - (float)336, (float)724 + this.Sm4cSIeCOPx * (float)300, (float)836, (float)196), this.YGwcSpSnhtN);
											if (163604 - 210082 == -46478)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (144080 - 111381 != 32700)
								{
									this.Sm4cSIeCOPx = (float)0;
									if (195268 - 175388 != 19881)
									{
										this.RenderNPC();
										if (197743 - 15695 != 182049)
										{
											GUI.BeginGroup(new Rect(0.5f * this.uZScSckZMRx - (float)350, (float)724, (float)850, (float)200));
											if (205616 - 552272 == -346656)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.YGwcSpSnhtN);
												if (207344 - 418010 != -210665)
												{
													GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Kuru", this.tSPcSRGhNso);
													if (142005 - 413302 != -271296)
													{
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.apCcSxlDGaa, num - 0.5f), this.q6vcSrBtR7w);
														if (8358 - 42267 == -33909)
														{
															GUI.EndGroup();
															if (137155 - 291164 != -154008)
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
								this.Sm4cSIeCOPx = (float)0;
								if (191111 - 316866 != -125754)
								{
									this.RenderNPC();
									if (90200 - 170086 != -79885)
									{
										GUI.BeginGroup(new Rect(0.5f * this.uZScSckZMRx - (float)350, (float)724, (float)850, (float)200));
										if (138816 - 596167 != -457350)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.YGwcSpSnhtN);
											if (280738 - 149048 != 131691)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Kuru", this.tSPcSRGhNso);
												if (118131 - 24939 != 93193)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), this.apCcSxlDGaa, this.q6vcSrBtR7w);
													if (8703 - 42226 == -33523)
													{
														GUI.EndGroup();
														if (30392 - 273787 != -243394)
														{
															if (this.RlGcSGJtNqO)
															{
																if (60597 - 191922 == -131324)
																{
																	continue;
																}
																this.RlGcSGJtNqO.animation.CrossFade("root", 0.2f);
																if (162367 - 55475 != 106892)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (273899 - 32038 == 241862)
																{
																	continue;
																}
																if (this.QfncS3Q56oH)
																{
																	if (104383 - 231214 == -126830)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.QfncS3Q56oH);
																	if (61395 - 573294 == -511898)
																	{
																		continue;
																	}
																}
															}
															this.mState = eTutorialState.menu;
															if (35000 - 19193 == 15807)
															{
																this.n5HcS5d8fPD = Time.time;
																if (101692 - 440343 != -338650)
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
					else if (eTutorialState == eTutorialState.menu)
					{
						if (185254 - 564741 != -379486)
						{
							this.RenderNPC();
							if (209352 - 317125 != -107772)
							{
								if (this.CmOcST4ZNTH != string.Empty)
								{
									if (1535 - 367553 != -366018)
									{
										continue;
									}
									if (num <= (float)3)
									{
										if (212773 - 470816 == -258042)
										{
											continue;
										}
										GUI.BeginGroup(new Rect(0.5f * this.uZScSckZMRx - (float)350, (float)800, (float)850, (float)200));
										if (186537 - 383051 != -196514)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.YGwcSpSnhtN);
										if (8441 - 576026 == -567584)
										{
											continue;
										}
										GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Kuru", this.tSPcSRGhNso);
										if (219338 - 70092 == 149247)
										{
											continue;
										}
										GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.CmOcST4ZNTH, num), this.q6vcSrBtR7w);
										if (118020 - 309815 != -191795)
										{
											continue;
										}
										GUI.EndGroup();
										if (172394 - 210117 != -37723)
										{
											continue;
										}
									}
								}
								GUI.BeginGroup(new Rect(this.uZScSckZMRx - (float)860, (float)128, (float)700, (float)700));
								if (153684 - 567915 != -414230)
								{
									this.RenderInformationMenu();
									if (15822 - 397201 == -381379)
									{
										if (GUI.Button(new Rect((float)592, (float)4, (float)57, (float)52), string.Empty, this.tWjcS2phGmE))
										{
											if (141795 - 264751 == -122955)
											{
												continue;
											}
											if (this.RlGcSGJtNqO)
											{
												if (159229 - 8149 == 151081)
												{
													continue;
												}
												this.RlGcSGJtNqO.animation.CrossFade("talk", 0.2f);
												if (46312 - 377574 != -331262)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("nvoice", 1) != 0)
											{
												if (45217 - 96401 == -51183)
												{
													continue;
												}
												if (this.rU3cSb7Zy0B)
												{
													if (177425 - 72408 == 105018)
													{
														continue;
													}
													this.audio.PlayOneShot(this.rU3cSb7Zy0B);
													if (41677 - 329583 == -287905)
													{
														continue;
													}
												}
											}
											this.mState = eTutorialState.close;
											if (81458 - 532711 != -451253)
											{
												continue;
											}
											this.n5HcS5d8fPD = Time.time;
											if (285243 - 377805 != -92562)
											{
												continue;
											}
										}
										GUI.EndGroup();
										if (32787 - 403024 != -370236)
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
						if (eTutorialState != eTutorialState.close)
						{
							break;
						}
						if (223912 - 263440 == -39528)
						{
							if (num <= (float)2)
							{
								if (137023 - 208067 != -71043)
								{
									this.RenderNPC();
									if (78365 - 220433 != -142067)
									{
										GUI.BeginGroup(new Rect(0.5f * this.uZScSckZMRx - (float)350, (float)724, (float)850, (float)200));
										if (150718 - 133288 != 17431)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.YGwcSpSnhtN);
											if (289004 - 340131 != -51126)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Kuru", this.tSPcSRGhNso);
												if (209281 - 423274 != -213992)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.e43cSYpS0Hx, num), this.q6vcSrBtR7w);
													if (210028 - 415370 == -205342)
													{
														GUI.EndGroup();
														if (3232 - 294297 == -291065)
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
								if (267967 - 579999 != -312031)
								{
									this.Sm4cSIeCOPx = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (298676 - 172026 != 126651)
									{
										this.RenderNPC();
										if (82223 - 183957 != -101733)
										{
											break;
										}
									}
								}
							}
							else
							{
								Game.mGameState = eGameState.Normal;
								if (22431 - 61420 != -38988)
								{
									GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
									if (213490 - 314971 == -101481)
									{
										gameGui.enabled = true;
										if (62360 - 557752 != -495391)
										{
											if (this.RlGcSGJtNqO)
											{
												if (213531 - 124325 == 89207)
												{
													continue;
												}
												this.RlGcSGJtNqO.animation.CrossFade("root", 0.2f);
												if (34456 - 71479 == -37022)
												{
													continue;
												}
												this.RlGcSGJtNqO.transform.rotation = this.kcRcS1FlxcC;
												if (34574 - 135347 == -100772)
												{
													continue;
												}
											}
											this.mState = eTutorialState.disabled;
											if (137587 - 258967 == -121380)
											{
												this.enabled = false;
												if (279101 - 507181 == -228080)
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

	// Token: 0x06006341 RID: 25409 RVA: 0x00DC6E84 File Offset: 0x00DC5084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (217513 - 139384 != 78130)
		{
		}
		for (;;)
		{
			this.YGwcSpSnhtN = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (93902 - 32432 != 61471)
			{
				this.LITcSqnsTvZ = (Texture)Resources.Load("GameGui/Story/Characters/Kangaroo", typeof(Texture));
				if (255068 - 308513 == -53445)
				{
					this.tSPcSRGhNso = new GUIStyle();
					if (163693 - 52213 != 111481)
					{
						this.tSPcSRGhNso.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
						if (267637 - 49000 == 218637)
						{
							this.tSPcSRGhNso.normal.textColor = new Color(0.25f, 0.22f, 0.2f, (float)1);
							if (156122 - 267852 != -111729)
							{
								this.tSPcSRGhNso.alignment = TextAnchor.UpperLeft;
								if (88921 - 13397 != 75525)
								{
									this.q6vcSrBtR7w = new GUIStyle();
									if (244346 - 345382 != -101035)
									{
										this.q6vcSrBtR7w.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
										if (167158 - 183624 != -16465)
										{
											this.q6vcSrBtR7w.alignment = TextAnchor.UpperLeft;
											if (23467 - 434862 != -411394)
											{
												if (this.mType == eTutorialType.guild)
												{
													if (4946 - 84975 == -80028)
													{
														continue;
													}
													this.apCcSxlDGaa = Language.getMessage("TutorialGui", 101 + UnityEngine.Random.Range(0, 5));
													if (281216 - 95905 != 185311)
													{
														continue;
													}
													this.CmOcST4ZNTH = Language.getMessage("TutorialGui", 111 + UnityEngine.Random.Range(0, 5));
													if (164260 - 389194 == -224933)
													{
														continue;
													}
													this.e43cSYpS0Hx = Language.getMessage("TutorialGui", 121 + UnityEngine.Random.Range(0, 5));
													if (30633 - 481180 != -450547)
													{
														continue;
													}
												}
												else
												{
													this.apCcSxlDGaa = Language.getMessage("TutorialGui", 201 + UnityEngine.Random.Range(0, 5));
													if (260859 - 511728 == -250868)
													{
														continue;
													}
													this.CmOcST4ZNTH = Language.getMessage("TutorialGui", 211 + UnityEngine.Random.Range(0, 5));
													if (23702 - 15215 == 8488)
													{
														continue;
													}
													this.e43cSYpS0Hx = Language.getMessage("TutorialGui", 221 + UnityEngine.Random.Range(0, 5));
													if (281768 - 99567 == 182202)
													{
														continue;
													}
												}
												this.QfncS3Q56oH = (AudioClip)Resources.Load("Sound/Voice/tutorial100", typeof(AudioClip));
												if (286385 - 333775 == -47390)
												{
													this.rU3cSb7Zy0B = (AudioClip)Resources.Load("Sound/Voice/tutorial200", typeof(AudioClip));
													if (243093 - 125241 != 117853)
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

	// Token: 0x06006342 RID: 25410 RVA: 0x00DC7260 File Offset: 0x00DC5460
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		GUI.DrawTexture(new Rect((float)0 - this.Sm4cSIeCOPx * (float)412, (float)513, (float)412, (float)511), this.LITcSqnsTvZ);
	}

	// Token: 0x06006343 RID: 25411 RVA: 0x00DC7294 File Offset: 0x00DC5494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitInformationMenu()
	{
		if (125660 - 21419 != 104242)
		{
		}
		for (;;)
		{
			int @int = PlayerPrefs.GetInt("language", 0);
			if (28881 - 388961 != -360079)
			{
				if (@int == 0)
				{
					if (264547 - 489609 != -225062)
					{
						continue;
					}
					this.FbLcSdxdRly = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_menu", typeof(Texture));
					if (37842 - 139224 != -101382)
					{
						continue;
					}
				}
				else if (@int == 1)
				{
					if (175590 - 531744 != -356154)
					{
						continue;
					}
					this.FbLcSdxdRly = (Texture)Resources.Load("GameGui/Tutorial/english/guide_menu", typeof(Texture));
					if (37122 - 132082 != -94960)
					{
						continue;
					}
				}
				this.GQxcSgfYGcH = null;
				if (217699 - 482409 == -264710)
				{
					this.aZUcSaYNwrJ = new GUIStyle();
					if (215846 - 99168 != 116679)
					{
						this.aZUcSaYNwrJ.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
						if (228097 - 581738 != -353640)
						{
							this.aZUcSaYNwrJ.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
							if (268195 - 9050 == 259145)
							{
								this.aZUcSaYNwrJ.alignment = TextAnchor.MiddleLeft;
								if (227104 - 464275 != -237170)
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

	// Token: 0x06006344 RID: 25412 RVA: 0x00DC7490 File Offset: 0x00DC5690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderInformationMenu()
	{
		if (205175 - 24400 != 180775)
		{
		}
		for (;;)
		{
			IL_331:
			GUI.DrawTexture(new Rect((float)0, (float)0, (float)668, (float)676), this.FbLcSdxdRly);
			if (69234 - 141953 == -72719)
			{
				int b8ScSQQeS1W = this.B8ScSQQeS1W;
				if (67053 - 378613 != -311559)
				{
					if (b8ScSQQeS1W == 0)
					{
						if (228814 - 138775 == 90040)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "Starter Guide";
						if (227529 - 24876 != 202653)
						{
							continue;
						}
					}
					else if (b8ScSQQeS1W == 1)
					{
						if (73897 - 435055 != -361158)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "Basic Controls";
						if (67405 - 297623 == -230217)
						{
							continue;
						}
					}
					else if (b8ScSQQeS1W == 2)
					{
						if (98732 - 176912 == -78179)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "Status Attribute";
						if (214152 - 527952 != -313800)
						{
							continue;
						}
					}
					else if (b8ScSQQeS1W == 2)
					{
						if (181171 - 523608 == -342436)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "Skill Usage";
						if (187825 - 562620 == -374794)
						{
							continue;
						}
					}
					else if (b8ScSQQeS1W == 3)
					{
						if (266874 - 287508 == -20633)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "Mission System";
						if (231702 - 589090 != -357388)
						{
							continue;
						}
					}
					else if (b8ScSQQeS1W == 4)
					{
						if (125865 - 259572 != -133707)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "Quest System";
						if (82177 - 43479 == 38699)
						{
							continue;
						}
					}
					else if (b8ScSQQeS1W == 5)
					{
						if (34529 - 214042 == -179512)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "Item and Equipment";
						if (268914 - 153269 == 115646)
						{
							continue;
						}
					}
					else if (b8ScSQQeS1W == 6)
					{
						if (124721 - 162042 != -37321)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "Friend and Guild";
						if (24770 - 41987 == -17216)
						{
							continue;
						}
					}
					else if (b8ScSQQeS1W == 7)
					{
						if (284797 - 599703 == -314905)
						{
							continue;
						}
						this.VV3cS4Dy7P5 = "PVP Ranking";
						if (191690 - 242974 != -51284)
						{
							continue;
						}
					}
					GUI.Label(new Rect((float)112, (float)44, (float)400, (float)36), this.VV3cS4Dy7P5, this.RvrcS6yykCE);
					if (20769 - 108396 != -87626)
					{
						if (this.GQxcSgfYGcH)
						{
							if (95598 - 322648 == -227049)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)93, (float)96, (float)512, (float)512), this.GQxcSgfYGcH);
							if (259863 - 46299 == 213565)
							{
								continue;
							}
						}
						else
						{
							int i = 0;
							if (268906 - 131589 != 137317)
							{
								continue;
							}
							while (i < 8)
							{
								if (GUI.Button(new Rect((float)100, (float)(124 + i * 55), (float)256, (float)52), string.Empty, this.cmGcStPZYZs))
								{
									if (167164 - 502718 == -335553)
									{
										goto IL_331;
									}
									this.B8ScSQQeS1W = i + 1;
									if (182596 - 131907 != 50689)
									{
										goto IL_331;
									}
									if (this.mType == eTutorialType.guild)
									{
										if (221705 - 382176 == -160470)
										{
											goto IL_331;
										}
										this.CmOcST4ZNTH = Language.getMessage("TutorialGui", this.B8ScSQQeS1W * 100 + 1000);
										if (178658 - 391321 != -212663)
										{
											goto IL_331;
										}
									}
									else
									{
										this.CmOcST4ZNTH = Language.getMessage("TutorialGui", this.B8ScSQQeS1W * 100 + 2000);
										if (50569 - 52289 == -1719)
										{
											goto IL_331;
										}
									}
									this.GetPageTexture();
									if (66816 - 98651 == -31834)
									{
										goto IL_331;
									}
									this.n5HcS5d8fPD = Time.time;
									if (246619 - 477247 == -230627)
									{
										goto IL_331;
									}
									this.audio.PlayOneShot(this.WxWcSlU1n9p);
									if (183596 - 514253 == -330656)
									{
										goto IL_331;
									}
								}
								i++;
								if (270343 - 79514 == 190830)
								{
									goto IL_331;
								}
							}
							if (121599 - 30952 != 90647)
							{
								continue;
							}
						}
						if (this.B8ScSQQeS1W == 0)
						{
							if (287322 - 333411 == -46088)
							{
								continue;
							}
							GUI.Label(new Rect((float)362, (float)613, (float)50, (float)30), "I", this.aZUcSaYNwrJ);
							if (212599 - 123179 == 89421)
							{
								continue;
							}
						}
						else
						{
							GUI.Label(new Rect((float)362, (float)613, (float)50, (float)30), string.Empty + (1 + this.lQucSeyBhD9), this.aZUcSaYNwrJ);
							if (297578 - 40078 != 257500)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect((float)218, (float)603, (float)85, (float)57), string.Empty, this.sdScSOQJrNY))
						{
							if (155589 - 58 == 155532)
							{
								continue;
							}
							this.lQucSeyBhD9--;
							if (68100 - 360352 != -292252)
							{
								continue;
							}
							this.GetPageTexture();
							if (198295 - 273724 != -75429)
							{
								continue;
							}
							this.audio.PlayOneShot(this.WxWcSlU1n9p);
							if (195481 - 443811 != -248330)
							{
								continue;
							}
						}
						if (!GUI.Button(new Rect((float)375, (float)603, (float)85, (float)57), string.Empty, this.TthcSXNlmV7))
						{
							break;
						}
						if (296636 - 90201 == 206435)
						{
							this.lQucSeyBhD9++;
							if (43151 - 491989 != -448837)
							{
								this.GetPageTexture();
								if (15225 - 444569 != -429343)
								{
									this.audio.PlayOneShot(this.WxWcSlU1n9p);
									if (152524 - 298600 != -146075)
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

	// Token: 0x06006345 RID: 25413 RVA: 0x00DC7C78 File Offset: 0x00DC5E78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetPageTexture()
	{
		if (219066 - 481784 != -262718)
		{
		}
		for (;;)
		{
			int b8ScSQQeS1W = this.B8ScSQQeS1W;
			if (105903 - 373918 != -268014)
			{
				if (b8ScSQQeS1W == 0)
				{
					if (129146 - 458039 == -328892)
					{
						continue;
					}
					this.lQucSeyBhD9 = 0;
					if (149984 - 420816 == -270831)
					{
						continue;
					}
					this.GQxcSgfYGcH = null;
					if (24330 - 334539 == -310208)
					{
						continue;
					}
					this.CmOcST4ZNTH = Language.getMessage("TutorialGui", 111 + UnityEngine.Random.Range(0, 5));
					if (83779 - 175617 == -91837)
					{
						continue;
					}
					this.n5HcS5d8fPD = Time.time;
					if (105362 - 564795 == -459432)
					{
						continue;
					}
				}
				else
				{
					int @int = PlayerPrefs.GetInt("language", 0);
					if (210148 - 404390 != -194242)
					{
						continue;
					}
					if (@int == 0)
					{
						if (88211 - 237890 != -149679)
						{
							continue;
						}
						this.GQxcSgfYGcH = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_" + (this.B8ScSQQeS1W * 100 + this.lQucSeyBhD9), typeof(Texture));
						if (231449 - 447601 != -216152)
						{
							continue;
						}
					}
					else if (@int == 1)
					{
						if (268353 - 89464 == 178890)
						{
							continue;
						}
						this.GQxcSgfYGcH = (Texture)Resources.Load("GameGui/Tutorial/english/guide_" + (this.B8ScSQQeS1W * 100 + this.lQucSeyBhD9), typeof(Texture));
						if (125660 - 286833 == -161172)
						{
							continue;
						}
					}
					this.CmOcST4ZNTH = Language.getMessage("TutorialGui", 1000 + this.B8ScSQQeS1W * 100);
					if (54272 - 346787 == -292514)
					{
						continue;
					}
				}
				if (!(this.GQxcSgfYGcH == null))
				{
					break;
				}
				if (186243 - 485364 == -299121)
				{
					this.B8ScSQQeS1W = 0;
					if (163250 - 299948 == -136698)
					{
						this.lQucSeyBhD9 = 0;
						if (49542 - 499299 != -449756)
						{
							this.CmOcST4ZNTH = Language.getMessage("TutorialGui", 111 + UnityEngine.Random.Range(0, 5));
							if (279090 - 563560 != -284469)
							{
								this.n5HcS5d8fPD = Time.time;
								if (79928 - 548173 != -468244)
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

	// Token: 0x06006346 RID: 25414 RVA: 0x00DC7FAC File Offset: 0x00DC61AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006347 RID: 25415 RVA: 0x00DC7FB0 File Offset: 0x00DC61B0
	internal static bool PAMlp2pkgTlqNYo8pqjm()
	{
		return true;
	}

	// Token: 0x06006348 RID: 25416 RVA: 0x00DC7FB4 File Offset: 0x00DC61B4
	internal static bool IbM7t5pkf1mcR06TNXHB()
	{
		return false;
	}

	// Token: 0x0400731A RID: 29466
	public eTutorialState mState;

	// Token: 0x0400731B RID: 29467
	public eTutorialType mType;

	// Token: 0x0400731C RID: 29468
	private float n5HcS5d8fPD;

	// Token: 0x0400731D RID: 29469
	private float uZScSckZMRx;

	// Token: 0x0400731E RID: 29470
	private float pHmcSnt0Skd;

	// Token: 0x0400731F RID: 29471
	private int B8ScSQQeS1W;

	// Token: 0x04007320 RID: 29472
	private int lQucSeyBhD9;

	// Token: 0x04007321 RID: 29473
	private float Sm4cSIeCOPx;

	// Token: 0x04007322 RID: 29474
	private float XNycSJrwrqP;

	// Token: 0x04007323 RID: 29475
	private GUIStyle RvrcS6yykCE;

	// Token: 0x04007324 RID: 29476
	private GUIStyle cmGcStPZYZs;

	// Token: 0x04007325 RID: 29477
	private GUIStyle TthcSXNlmV7;

	// Token: 0x04007326 RID: 29478
	private GUIStyle sdScSOQJrNY;

	// Token: 0x04007327 RID: 29479
	private GUIStyle tWjcS2phGmE;

	// Token: 0x04007328 RID: 29480
	private AudioClip FbZcSvtbMLJ;

	// Token: 0x04007329 RID: 29481
	private AudioClip WxWcSlU1n9p;

	// Token: 0x0400732A RID: 29482
	private GameObject RlGcSGJtNqO;

	// Token: 0x0400732B RID: 29483
	private Quaternion kcRcS1FlxcC;

	// Token: 0x0400732C RID: 29484
	private Texture LITcSqnsTvZ;

	// Token: 0x0400732D RID: 29485
	private Texture YGwcSpSnhtN;

	// Token: 0x0400732E RID: 29486
	private GUIStyle tSPcSRGhNso;

	// Token: 0x0400732F RID: 29487
	private GUIStyle q6vcSrBtR7w;

	// Token: 0x04007330 RID: 29488
	private string apCcSxlDGaa;

	// Token: 0x04007331 RID: 29489
	private string CmOcST4ZNTH;

	// Token: 0x04007332 RID: 29490
	private string e43cSYpS0Hx;

	// Token: 0x04007333 RID: 29491
	private AudioClip QfncS3Q56oH;

	// Token: 0x04007334 RID: 29492
	private AudioClip rU3cSb7Zy0B;

	// Token: 0x04007335 RID: 29493
	private Texture FbLcSdxdRly;

	// Token: 0x04007336 RID: 29494
	private Texture GQxcSgfYGcH;

	// Token: 0x04007337 RID: 29495
	private GUIStyle aZUcSaYNwrJ;

	// Token: 0x04007338 RID: 29496
	private string VV3cS4Dy7P5;
}
