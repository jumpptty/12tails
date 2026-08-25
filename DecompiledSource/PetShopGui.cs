using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200108B RID: 4235
[Serializable]
public class PetShopGui : MonoBehaviour
{
	// Token: 0x0600626C RID: 25196 RVA: 0x00D9E290 File Offset: 0x00D9C490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PetShopGui()
	{
		if (278228 - 409347 != -131118)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (55850 - 369960 == -314110)
			{
				base..ctor();
				if (299193 - 353017 != -53823)
				{
					this.mState = ePetShopState.init;
					if (272135 - 246609 == 25526)
					{
						this.AMmcLpO0yFd = ePetShopTab.trade;
						if (54474 - 4295 != 50180)
						{
							this.lS0cLrxNKxn = -1;
							if (209381 - 291777 == -82396)
							{
								this.f8Ncwev6rNE = string.Empty;
								if (237989 - 56252 == 181737)
								{
									this.OhDcwphaXJ8 = string.Empty;
									if (125868 - 32512 == 93356)
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

	// Token: 0x0600626D RID: 25197 RVA: 0x00D9E3B4 File Offset: 0x00D9C5B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (124599 - 191242 != -66643)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (61509 - 464894 != -403384)
			{
				if (this.mState == ePetShopState.init)
				{
					if (129567 - 418162 == -288594)
					{
						continue;
					}
					this.InitPetShopGui();
					if (114305 - 331478 != -217173)
					{
						continue;
					}
					this.InitNPC();
					if (155345 - 428835 == -273489)
					{
						continue;
					}
					this.InitPetShopMenu();
					if (277225 - 51157 == 226069)
					{
						continue;
					}
					this.InitPetShopInventory();
					if (184496 - 576595 == -392098)
					{
						continue;
					}
					this.InitPetShopNotice();
					if (60160 - 491721 == -431560)
					{
						continue;
					}
				}
				this.ResetNPC();
				if (83458 - 461721 != -378262)
				{
					this.ResetPetTradeMenu();
					if (32864 - 537608 != -504743)
					{
						this.ResetPetShopInventory();
						if (184196 - 515492 != -331295)
						{
							this.AMmcLpO0yFd = ePetShopTab.trade;
							if (119155 - 325519 != -206363)
							{
								this.cP8cLRlb51u = 0;
								if (203586 - 391802 == -188216)
								{
									this.lS0cLrxNKxn = -1;
									if (261828 - 383480 != -121651)
									{
										this.aB8cLqk7QmI = 1f;
										if (86553 - 597079 != -510525)
										{
											this.mState = ePetShopState.open;
											if (58881 - 388186 == -329305)
											{
												this.NJncLlRA1gJ = Time.time;
												if (37862 - 537581 != -499718)
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

	// Token: 0x0600626E RID: 25198 RVA: 0x00D9E600 File Offset: 0x00D9C800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (22533 - 341258 != -318725)
		{
		}
		for (;;)
		{
			if (this.mState <= ePetShopState.init)
			{
				if (177359 - 191826 == -14467)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (68753 - 251082 != -182328)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (153832 - 532760 == -378928)
					{
						this.MqFcLGwW7du = (float)(1024 * Screen.width / Screen.height);
						if (185543 - 122743 == 62800)
						{
							this.UiPcL1SgKX7 = (float)Screen.height / 1024f;
							if (116004 - 210490 == -94486)
							{
								this.RenderPetShopGui();
								if (235274 - 166982 == 68292)
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

	// Token: 0x0600626F RID: 25199 RVA: 0x00D9E750 File Offset: 0x00D9C950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitPetShopGui()
	{
		if (207573 - 133825 != 73748)
		{
		}
		for (;;)
		{
			this.keccLT7Dkcw = new GUIStyle();
			if (176692 - 111327 == 65365)
			{
				this.keccLT7Dkcw.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/button_close_h", typeof(Texture)));
				if (56160 - 336192 == -280032)
				{
					this.foHcLYC3JRw = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
					if (213709 - 587692 != -373982)
					{
						this.MYqcL3yskMo = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
						if (63623 - 256145 == -192522)
						{
							this.WgocLbNfyn3 = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
							if (142326 - 56860 != 85467)
							{
								this.hGmcLd8RAfl = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
								if (294332 - 71534 != 222799)
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

	// Token: 0x06006270 RID: 25200 RVA: 0x00D9E8DC File Offset: 0x00D9CADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderPetShopGui()
	{
		if (4410 - 409043 != -404632)
		{
		}
		for (;;)
		{
			float num = Time.time - this.NJncLlRA1gJ;
			if (166049 - 347232 == -181183)
			{
				ePetShopState ePetShopState = this.mState;
				if (255164 - 462380 != -207215)
				{
					if (ePetShopState == ePetShopState.init)
					{
						if (67028 - 24297 != 42732)
						{
							break;
						}
					}
					else if (ePetShopState == ePetShopState.open)
					{
						if (110578 - 571835 == -461257)
						{
							if (num <= 0.5f)
							{
								if (129524 - 495532 != -366007)
								{
									this.aB8cLqk7QmI = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (211436 - 534180 == -322744)
									{
										this.RenderNPC();
										if (297296 - 110763 != 186534)
										{
											GUI.DrawTexture(new Rect(0.5f * this.MqFcLGwW7du - (float)336, (float)724 + this.aB8cLqk7QmI * (float)300, (float)836, (float)196), this.RqQcLaZuN8G);
											if (41673 - 192959 == -151286)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (105172 - 13777 != 91396)
								{
									this.aB8cLqk7QmI = (float)0;
									if (194672 - 9990 == 184682)
									{
										this.RenderNPC();
										if (291887 - 396761 != -104873)
										{
											GUI.BeginGroup(new Rect(0.5f * this.MqFcLGwW7du - (float)350, (float)724, (float)850, (float)200));
											if (222341 - 506848 == -284507)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.RqQcLaZuN8G);
												if (48458 - 183091 != -134632)
												{
													GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Mosoly", this.TgicL4IQO68);
													if (10515 - 559058 == -548543)
													{
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.DmWcLHGphUo, num - 0.5f), this.zqBcLsuEmPi);
														if (94423 - 339216 != -244792)
														{
															GUI.EndGroup();
															if (298407 - 131068 != 167340)
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
								this.aB8cLqk7QmI = (float)0;
								if (290069 - 97102 != 192968)
								{
									this.RenderNPC();
									if (35770 - 516311 != -480540)
									{
										this.mState = ePetShopState.menu;
										if (238156 - 537559 == -299403)
										{
											this.NJncLlRA1gJ = Time.time;
											if (229310 - 507187 != -277876)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (ePetShopState == ePetShopState.menu)
					{
						if (94440 - 599342 == -504902)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.MqFcLGwW7du - (float)400) / this.MqFcLGwW7du, (float)1);
							if (129382 - 322196 != -192813)
							{
								GUI.BeginGroup(new Rect(this.MqFcLGwW7du - (float)850, (float)0, (float)850, (float)1024));
								if (49486 - 11046 == 38440)
								{
									GUI.DrawTexture(new Rect((float)300, (float)0, (float)550, (float)1024), this.M4IcLZAVfTZ);
									if (299942 - 227 != 299716)
									{
										Guix.renderSmallNumber(532, 64, PlayerData.Gil, false, (float)1);
										if (35395 - 289228 == -253833)
										{
											Guix.renderSmallNumber(730, 64, PlayerData.Jil, false, (float)1);
											if (55454 - 346276 == -290822)
											{
												if (this.AMmcLpO0yFd == ePetShopTab.trade)
												{
													if (125855 - 497940 != -372085)
													{
														continue;
													}
													this.RenderPetTradeMenu();
													if (174643 - 492263 != -317620)
													{
														continue;
													}
												}
												else
												{
													this.RenderPetUpgradeMenu();
													if (293382 - 197674 != 95708)
													{
														continue;
													}
												}
												this.RenderPetShopInventory();
												if (72386 - 47677 == 24709)
												{
													this.RenderNoticeBar();
													if (220939 - 396148 == -175209)
													{
														if (GUI.Button(new Rect((float)400, (float)2, (float)57, (float)52), string.Empty, this.keccLT7Dkcw))
														{
															if (178355 - 230759 == -52403)
															{
																continue;
															}
															this.mState = ePetShopState.close;
															if (194895 - 406478 != -211583)
															{
																continue;
															}
															this.NJncLlRA1gJ = Time.time;
															if (198938 - 270087 == -71148)
															{
																continue;
															}
															this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
															if (248665 - 248429 != 236)
															{
																continue;
															}
															if (this.hGmcLd8RAfl)
															{
																if (122007 - 117003 != 5004)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.hGmcLd8RAfl);
																if (51014 - 385914 != -334900)
																{
																	continue;
																}
															}
														}
														GUI.EndGroup();
														if (45574 - 187258 == -141684)
														{
															this.RenderNPC();
															if (155117 - 445040 == -289923)
															{
																this.RenderDragIcon();
																if (72859 - 198025 == -125166)
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
						if (ePetShopState != ePetShopState.close)
						{
							break;
						}
						if (280947 - 418306 == -137359)
						{
							if (num <= (float)2)
							{
								if (227579 - 455569 != -227989)
								{
									this.RenderNPC();
									if (187360 - 464937 == -277577)
									{
										GUI.BeginGroup(new Rect(0.5f * this.MqFcLGwW7du - (float)350, (float)724, (float)850, (float)200));
										if (1171 - 342823 != -341651)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.RqQcLaZuN8G);
											if (83658 - 434159 == -350501)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Mosoly", this.TgicL4IQO68);
												if (90411 - 41807 != 48605)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.csycL7BHOdV, num), this.zqBcLsuEmPi);
													if (169203 - 546252 != -377048)
													{
														GUI.EndGroup();
														if (25813 - 373306 != -347492)
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
								if (282811 - 520434 == -237623)
								{
									this.aB8cLqk7QmI = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (7745 - 224629 != -216883)
									{
										this.RenderNPC();
										if (192721 - 156816 == 35905)
										{
											break;
										}
									}
								}
							}
							else
							{
								GameObject gameObject = GameObject.Find("Baboon");
								if (154230 - 304963 == -150733)
								{
									if (gameObject)
									{
										if (21193 - 264224 != -243031)
										{
											continue;
										}
										gameObject.animation.CrossFade("root");
										if (66074 - 318135 == -252060)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (56002 - 15781 != 40222)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (190514 - 518430 != -327915)
										{
											gameGui.enabled = true;
											if (161198 - 447970 != -286771)
											{
												this.mState = ePetShopState.disabled;
												if (104312 - 380646 == -276334)
												{
													this.enabled = false;
													if (56925 - 270720 != -213794)
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

	// Token: 0x06006271 RID: 25201 RVA: 0x00D9F32C File Offset: 0x00D9D52C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (235339 - 252810 != -17470)
		{
		}
		for (;;)
		{
			this.RqQcLaZuN8G = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (227029 - 368376 == -141347)
			{
				this.TgicL4IQO68 = new GUIStyle();
				if (92675 - 198794 != -106118)
				{
					this.TgicL4IQO68.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (147832 - 364838 == -217006)
					{
						this.TgicL4IQO68.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (192357 - 560081 != -367723)
						{
							this.TgicL4IQO68.alignment = TextAnchor.UpperLeft;
							if (89603 - 452201 != -362597)
							{
								this.zqBcLsuEmPi = new GUIStyle();
								if (169824 - 257369 == -87545)
								{
									this.zqBcLsuEmPi.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (220862 - 283855 != -62992)
									{
										this.zqBcLsuEmPi.alignment = TextAnchor.UpperLeft;
										if (22443 - 258583 != -236139)
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

	// Token: 0x06006272 RID: 25202 RVA: 0x00D9F4F0 File Offset: 0x00D9D6F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (120371 - 232934 != -112563)
		{
		}
		for (;;)
		{
			this.rP5cLgu5lbn = (Texture)Resources.Load("GameGui/Story/Characters/Baboon", typeof(Texture));
			if (12439 - 491203 != -478763)
			{
				this.DmWcLHGphUo = Language.getMessage("PetShopGui", UnityEngine.Random.Range(101, 106));
				if (77122 - 379651 == -302529)
				{
					this.csycL7BHOdV = Language.getMessage("PetShopGui", UnityEngine.Random.Range(201, 206));
					if (156433 - 432269 == -275836)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006273 RID: 25203 RVA: 0x00D9F5D0 File Offset: 0x00D9D7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (this.rP5cLgu5lbn)
		{
			GUI.DrawTexture(new Rect((float)0 - this.aB8cLqk7QmI * (float)448, (float)527, (float)448, (float)497), this.rP5cLgu5lbn);
		}
	}

	// Token: 0x06006274 RID: 25204 RVA: 0x00D9F620 File Offset: 0x00D9D820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitPetShopMenu()
	{
		if (148542 - 558777 != -410235)
		{
		}
		for (;;)
		{
			IL_2F3:
			this.M4IcLZAVfTZ = (Texture)Resources.Load("GameGui/PetShopGui/window_petShop", typeof(Texture));
			if (111514 - 103220 == 8294)
			{
				this.eq2cLCGa6TF = (Texture)Resources.Load("GameGui/PetShopGui/window_petUpgrade", typeof(Texture));
				if (274185 - 570635 == -296450)
				{
					this.rmjcLMiLwID = new GUIStyle();
					if (10629 - 88255 == -77626)
					{
						this.rmjcLMiLwID.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/tab_trade_h", typeof(Texture)));
						if (68723 - 381496 != -312772)
						{
							this.TkHcLfqeE4n = new GUIStyle();
							if (178880 - 311896 == -133016)
							{
								this.TkHcLfqeE4n.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/tab_upgrade_h", typeof(Texture)));
								if (65393 - 317551 != -252157)
								{
									this.AZHcLLKoIOy = new GUIStyle();
									if (156748 - 520921 == -364173)
									{
										this.AZHcLLKoIOy.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/button_trade", typeof(Texture)));
										if (226940 - 203630 == 23310)
										{
											this.AZHcLLKoIOy.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/button_trade_h", typeof(Texture)));
											if (200083 - 99785 == 100298)
											{
												this.rFqcLwkjGyP = new GUIStyle();
												if (31546 - 204585 != -173038)
												{
													this.rFqcLwkjGyP.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/button_upgrade", typeof(Texture)));
													if (182585 - 516541 == -333956)
													{
														this.rFqcLwkjGyP.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/button_upgrade_h", typeof(Texture)));
														if (34828 - 573202 == -538374)
														{
															this.WktcLUIQVAh = new GUIStyle();
															if (272701 - 128788 != 143914)
															{
																this.WktcLUIQVAh.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/button_highlight_h", typeof(Texture)));
																if (224442 - 571028 != -346585)
																{
																	this.WktcLUIQVAh.active.background = (Texture2D)((Texture)Resources.Load("GameGui/PetShopGui/button_highlight_a", typeof(Texture)));
																	if (32082 - 350955 != -318872)
																	{
																		this.xERcLNGBNnj = new GUIStyle();
																		if (74766 - 92032 != -17265)
																		{
																			this.xERcLNGBNnj.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
																			if (124277 - 144982 != -20704)
																			{
																				this.MAjcLEQjTay = new GUIStyle();
																				if (62113 - 132147 != -70033)
																				{
																					this.MAjcLEQjTay.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
																					if (109841 - 258809 == -148968)
																					{
																						this.Ei6cLPOjCHC = new GUIStyle();
																						if (99143 - 491199 != -392055)
																						{
																							this.Ei6cLPOjCHC.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																							if (164237 - 26894 == 137343)
																							{
																								this.Ei6cLPOjCHC.normal.textColor = new Color(0.63f, 0.98f, (float)1, (float)1);
																								if (48094 - 348014 != -299919)
																								{
																									this.Ei6cLPOjCHC.alignment = TextAnchor.UpperLeft;
																									if (76668 - 137373 != -60704)
																									{
																										this.Ei6cLPOjCHC.wordWrap = true;
																										if (85312 - 252249 != -166936)
																										{
																											this.wkvcLSaVlrS = new GUIStyle();
																											if (177360 - 435004 == -257644)
																											{
																												this.wkvcLSaVlrS.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																												if (217972 - 551527 == -333555)
																												{
																													this.wkvcLSaVlrS.normal.textColor = new Color(0.99f, 0.45f, 0.42f, (float)1);
																													if (39318 - 366787 == -327469)
																													{
																														this.wkvcLSaVlrS.alignment = TextAnchor.UpperLeft;
																														if (108746 - 55288 == 53458)
																														{
																															this.wkvcLSaVlrS.wordWrap = true;
																															if (296930 - 596254 != -299323)
																															{
																																this.BPfcLB6C0FG = new GUIStyle();
																																if (122242 - 373724 != -251481)
																																{
																																	this.BPfcLB6C0FG.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																	if (86852 - 376443 != -289590)
																																	{
																																		this.BPfcLB6C0FG.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																																		if (72282 - 374947 == -302665)
																																		{
																																			this.BPfcLB6C0FG.alignment = TextAnchor.UpperLeft;
																																			if (95506 - 74333 == 21173)
																																			{
																																				this.BPfcLB6C0FG.wordWrap = true;
																																				if (211940 - 58941 != 153000)
																																				{
																																					this.WYGcL0numVv = new GUIStyle();
																																					if (270340 - 324108 == -53768)
																																					{
																																						this.WYGcL0numVv.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																																						if (238275 - 398800 == -160525)
																																						{
																																							this.WYGcL0numVv.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																																							if (27244 - 293811 != -266566)
																																							{
																																								this.WYGcL0numVv.alignment = TextAnchor.MiddleCenter;
																																								if (277406 - 16080 == 261326)
																																								{
																																									this.vIrcL8irOZX = (Texture)Resources.Load("GameGui/Compound/progressBG", typeof(Texture));
																																									if (94034 - 296475 == -202441)
																																									{
																																										this.BuNcLit0ylk = (Texture)Resources.Load("GameGui/Compound/progressBar", typeof(Texture));
																																										if (22605 - 417738 == -395133)
																																										{
																																											this.kuycLDA45Rm = (Texture)Resources.Load("GameGui/Compound/progressTop", typeof(Texture));
																																											if (52385 - 254653 != -202267)
																																											{
																																												this.N4OcLmUGgbU = new GUIStyle();
																																												if (238901 - 285517 != -46615)
																																												{
																																													this.N4OcLmUGgbU.font = (Font)Resources.Load("GameGui/Fonts/Century22", typeof(Font));
																																													if (253239 - 574165 != -320925)
																																													{
																																														this.N4OcLmUGgbU.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
																																														if (216196 - 389320 != -173123)
																																														{
																																															this.N4OcLmUGgbU.alignment = TextAnchor.MiddleLeft;
																																															if (72000 - 232250 == -160250)
																																															{
																																																this.Pg8cLjb99rW = new GUIStyle();
																																																if (21543 - 394067 != -372523)
																																																{
																																																	this.Pg8cLjb99rW.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																																																	if (469 - 6623 != -6153)
																																																	{
																																																		this.Pg8cLjb99rW.normal.textColor = new Color(0.35f, 0.3f, 0.2f, (float)1);
																																																		if (22310 - 76526 == -54216)
																																																		{
																																																			this.Pg8cLjb99rW.alignment = TextAnchor.UpperLeft;
																																																			if (247191 - 336232 == -89041)
																																																			{
																																																				this.Pg8cLjb99rW.wordWrap = true;
																																																				if (173201 - 147023 == 26178)
																																																				{
																																																					this.orHcLoZOC7X = new GUIStyle();
																																																					if (212959 - 156690 != 56270)
																																																					{
																																																						this.orHcLoZOC7X.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
																																																						if (149462 - 18732 == 130730)
																																																						{
																																																							this.orHcLoZOC7X.normal.textColor = new Color(0.45f, 0.4f, 0.3f, (float)1);
																																																							if (47804 - 5158 == 42646)
																																																							{
																																																								this.orHcLoZOC7X.alignment = TextAnchor.MiddleRight;
																																																								if (26177 - 241906 == -215729)
																																																								{
																																																									this.VfJcLkaprjS = new GUIStyle();
																																																									if (113022 - 455886 == -342864)
																																																									{
																																																										this.VfJcLkaprjS.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																																																										if (287822 - 13868 != 273955)
																																																										{
																																																											this.VfJcLkaprjS.normal.textColor = new Color(0.36f, (float)0, 0.65f, (float)1);
																																																											if (209770 - 357742 == -147972)
																																																											{
																																																												this.VfJcLkaprjS.alignment = TextAnchor.UpperLeft;
																																																												if (195638 - 65899 == 129739)
																																																												{
																																																													this.VfJcLkaprjS.wordWrap = true;
																																																													if (15768 - 84522 == -68754)
																																																													{
																																																														this.eH5cLAoZ5oF = new HoverButtonClass[6];
																																																														if (41412 - 324425 == -283013)
																																																														{
																																																															int i = 0;
																																																															if (290391 - 226379 != 64013)
																																																															{
																																																																while (i < 6)
																																																																{
																																																																	this.eH5cLAoZ5oF[i] = new HoverButtonClass();
																																																																	if (243918 - 150504 != 93414)
																																																																	{
																																																																		goto IL_2F3;
																																																																	}
																																																																	i++;
																																																																	if (253821 - 110762 != 143059)
																																																																	{
																																																																		goto IL_2F3;
																																																																	}
																																																																}
																																																																if (252244 - 483196 == -230952)
																																																																{
																																																																	this.f8Ncwev6rNE = Language.getMessage("PetShopGui", 100);
																																																																	if (40382 - 22540 == 17842)
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

	// Token: 0x06006275 RID: 25205 RVA: 0x00DA0318 File Offset: 0x00D9E518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetPetTradeMenu()
	{
		if (182464 - 418105 != -235641)
		{
		}
		for (;;)
		{
			IL_18E:
			string[] tradeList = PetShopData.getTradeList();
			if (108915 - 208739 != -99823)
			{
				CharacterDataClass current = CharacterData.current;
				if (276269 - 147045 == 129224)
				{
					this.fL8cLFPW1s0 = new CollectorClass[Extensions.get_length(tradeList)];
					if (54509 - 463662 != -409152)
					{
						int i = 0;
						if (81251 - 274034 != -192782)
						{
							while (i < Extensions.get_length(tradeList))
							{
								this.fL8cLFPW1s0[i] = new CollectorClass();
								if (272715 - 3181 == 269535)
								{
									goto IL_18E;
								}
								if (this.fL8cLFPW1s0[i] != null)
								{
									if (2075 - 200487 == -198411)
									{
										goto IL_18E;
									}
									this.fL8cLFPW1s0[i].name = tradeList[i];
									if (13756 - 77685 != -63929)
									{
										goto IL_18E;
									}
									this.fL8cLFPW1s0[i].item = ItemData.getItemData(tradeList[i]);
									if (125691 - 322986 == -197294)
									{
										goto IL_18E;
									}
									this.fL8cLFPW1s0[i].icon = IconButton.getIconImage(tradeList[i]);
									if (287603 - 342443 != -54840)
									{
										goto IL_18E;
									}
									string tradeItem = PetShopData.getTradeItem(tradeList[i]);
									if (142874 - 555940 == -413065)
									{
										goto IL_18E;
									}
									if (tradeItem != "none")
									{
										if (159454 - 399597 != -240143)
										{
											goto IL_18E;
										}
										string[] array = (string[])Stringf.splitToArray(tradeItem, ",").ToBuiltin(typeof(string));
										if (16865 - 31360 != -14495)
										{
											goto IL_18E;
										}
										if (Extensions.get_length(array) > 0)
										{
											if (282941 - 515750 == -232808)
											{
												goto IL_18E;
											}
											this.fL8cLFPW1s0[i].material = new string[Extensions.get_length(array)];
											if (120126 - 68191 != 51935)
											{
												goto IL_18E;
											}
											this.fL8cLFPW1s0[i].materialNum = new int[Extensions.get_length(array)];
											if (156552 - 571524 != -414972)
											{
												goto IL_18E;
											}
											this.fL8cLFPW1s0[i].materialIcon = new Texture[Extensions.get_length(array)];
											if (125107 - 198776 == -73668)
											{
												goto IL_18E;
											}
											this.fL8cLFPW1s0[i].materialCheck = new bool[Extensions.get_length(array)];
											if (285784 - 322516 == -36731)
											{
												goto IL_18E;
											}
											int j = 0;
											if (120585 - 227671 != -107086)
											{
												goto IL_18E;
											}
											while (j < Extensions.get_length(array))
											{
												string[] array2 = (string[])Stringf.splitToArray(array[j], "%").ToBuiltin(typeof(string));
												if (90431 - 57144 == 33288)
												{
													goto IL_18E;
												}
												if (Extensions.get_length(array2) > 0)
												{
													if (114900 - 279443 == -164542)
													{
														goto IL_18E;
													}
													this.fL8cLFPW1s0[i].material[j] = array2[0];
													if (127119 - 257293 == -130173)
													{
														goto IL_18E;
													}
												}
												if (Extensions.get_length(array2) > 1)
												{
													if (172836 - 114056 != 58780)
													{
														goto IL_18E;
													}
													this.fL8cLFPW1s0[i].materialNum[j] = Mathf.Clamp(Stringf.getInteger(array2[1]), 1, 99);
													if (128213 - 56730 == 71484)
													{
														goto IL_18E;
													}
												}
												else
												{
													this.fL8cLFPW1s0[i].materialNum[j] = 1;
													if (229073 - 548951 == -319877)
													{
														goto IL_18E;
													}
												}
												this.fL8cLFPW1s0[i].materialIcon[j] = IconButton.getIconImage(this.fL8cLFPW1s0[i].material[j]);
												if (219078 - 429142 == -210063)
												{
													goto IL_18E;
												}
												if (current.getItemTotalNum(this.fL8cLFPW1s0[i].material[j]) >= this.fL8cLFPW1s0[i].materialNum[j])
												{
													if (231564 - 554312 != -322748)
													{
														goto IL_18E;
													}
													this.fL8cLFPW1s0[i].materialCheck[j] = true;
													if (244717 - 512502 != -267785)
													{
														goto IL_18E;
													}
												}
												else
												{
													this.fL8cLFPW1s0[i].materialCheck[j] = false;
													if (80955 - 36427 == 44529)
													{
														goto IL_18E;
													}
													this.fL8cLFPW1s0[i].canTrade = false;
													if (252387 - 140540 != 111847)
													{
														goto IL_18E;
													}
												}
												j++;
												if (180740 - 436157 == -255416)
												{
													goto IL_18E;
												}
											}
											if (202651 - 555992 == -353340)
											{
												goto IL_18E;
											}
										}
										else
										{
											this.fL8cLFPW1s0[i].canTrade = false;
											if (67496 - 587869 != -520373)
											{
												goto IL_18E;
											}
										}
									}
								}
								i++;
								if (80225 - 439441 != -359216)
								{
									goto IL_18E;
								}
							}
							if (36470 - 577958 == -541488)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006276 RID: 25206 RVA: 0x00DA0948 File Offset: 0x00D9EB48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderPetTradeMenu()
	{
		if (225511 - 351072 != -125561)
		{
		}
		for (;;)
		{
			IL_40:
			string text = "none";
			if (236923 - 280586 == -43663)
			{
				string text2 = "none";
				if (268050 - 175238 == 92812)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (193706 - 385238 == -191532)
					{
						Texture nHoverImage = null;
						if (234944 - 121391 == 113553)
						{
							GUI.DrawTexture(new Rect((float)397, (float)103, (float)72, (float)40), this.rmjcLMiLwID.hover.background);
							if (92360 - 235027 != -142666)
							{
								if (GUI.Button(new Rect((float)477, (float)103, (float)90, (float)40), string.Empty, this.TkHcLfqeE4n))
								{
									if (83314 - 327546 == -244231)
									{
										continue;
									}
									this.AMmcLpO0yFd = ePetShopTab.upgrade;
									if (261601 - 212939 != 48662)
									{
										continue;
									}
									this.cP8cLRlb51u = 0;
									if (217262 - 433137 != -215875)
									{
										continue;
									}
									this.lS0cLrxNKxn = -1;
									if (230550 - 188327 == 42224)
									{
										continue;
									}
									this.audio.PlayOneShot(this.WgocLbNfyn3);
									if (191909 - 311372 != -119463)
									{
										continue;
									}
									this.ResetPetUpgradeMenu();
									if (17622 - 422008 == -404385)
									{
										continue;
									}
								}
								int i = 0 + 6 * this.cP8cLRlb51u;
								if (262833 - 375817 == -112984)
								{
									while (i < Mathf.Min(Extensions.get_length(this.fL8cLFPW1s0), 6 * this.cP8cLRlb51u + 6))
									{
										if (this.fL8cLFPW1s0[i] != null)
										{
											if (281383 - 203792 == 77592)
											{
												goto IL_40;
											}
											if (i == this.lS0cLrxNKxn)
											{
												if (244186 - 472726 == -228539)
												{
													goto IL_40;
												}
												GUI.DrawTexture(new Rect((float)388, (float)(191 + 68 * (i % 6)), (float)430, (float)68), this.WktcLUIQVAh.hover.background);
												if (238402 - 528098 == -289695)
												{
													goto IL_40;
												}
											}
											else if (this.fL8cLFPW1s0[i].canTrade)
											{
												if (108088 - 548031 != -439943)
												{
													goto IL_40;
												}
												if (Time.time > this.uJ0cL9IEx4S)
												{
													if (83052 - 582848 != -499796)
													{
														goto IL_40;
													}
													if (GUI.Button(new Rect((float)388, (float)(191 + 68 * (i % 6)), (float)430, (float)68), string.Empty, this.WktcLUIQVAh))
													{
														if (176377 - 95688 != 80689)
														{
															goto IL_40;
														}
														this.lS0cLrxNKxn = i;
														if (27913 - 340151 != -312238)
														{
															goto IL_40;
														}
														this.uJ0cL9IEx4S = Time.time + 0.2f;
														if (282741 - 246300 == 36442)
														{
															goto IL_40;
														}
														if (this.MYqcL3yskMo)
														{
															if (189838 - 299733 != -109895)
															{
																goto IL_40;
															}
															this.audio.PlayOneShot(this.MYqcL3yskMo);
															if (17325 - 210068 != -192743)
															{
																goto IL_40;
															}
														}
													}
												}
											}
											else
											{
												GUI.DrawTexture(new Rect((float)388, (float)(191 + 68 * (i % 6)), (float)430, (float)68), this.WktcLUIQVAh.active.background);
												if (20679 - 213252 == -192572)
												{
													goto IL_40;
												}
											}
											if (this.fL8cLFPW1s0[i].icon)
											{
												if (202745 - 338119 == -135373)
												{
													goto IL_40;
												}
												GUI.DrawTexture(new Rect((float)404, (float)(191 + 68 * (i % 6)), (float)64, (float)64), this.fL8cLFPW1s0[i].icon);
												if (84020 - 582215 == -498194)
												{
													goto IL_40;
												}
											}
											if (!this.fL8cLFPW1s0[i].canTrade)
											{
												if (89552 - 360490 == -270937)
												{
													goto IL_40;
												}
												GUI.DrawTexture(new Rect((float)410, (float)(191 + 68 * (i % 6) + 5), (float)52, (float)52), this.fMNcw6ARiRa);
												if (255601 - 484928 == -229326)
												{
													goto IL_40;
												}
											}
											int j = 0;
											if (268994 - 504448 == -235453)
											{
												goto IL_40;
											}
											while (j < Extensions.get_length(this.fL8cLFPW1s0[i].material))
											{
												if (this.fL8cLFPW1s0[i].materialIcon[j])
												{
													if (16684 - 446943 == -430258)
													{
														goto IL_40;
													}
													GUI.DrawTexture(new Rect((float)(498 + 78 * j), (float)(191 + 68 * (i % 6)), (float)64, (float)64), this.fL8cLFPW1s0[i].materialIcon[j]);
													if (132703 - 360432 != -227729)
													{
														goto IL_40;
													}
												}
												if (this.fL8cLFPW1s0[i].materialCheck[j])
												{
													if (152612 - 72877 != 79735)
													{
														goto IL_40;
													}
													Guix.renderTextOutline(new Rect((float)(498 + 78 * j + 45), (float)(191 + 68 * (i % 6) + 35), (float)60, (float)30), "x" + this.fL8cLFPW1s0[i].materialNum[j], this.BPfcLB6C0FG);
													if (221780 - 550755 != -328975)
													{
														goto IL_40;
													}
													GUI.Label(new Rect((float)(498 + 78 * j + 45), (float)(191 + 68 * (i % 6) + 35), (float)60, (float)30), "x" + this.fL8cLFPW1s0[i].materialNum[j], this.Ei6cLPOjCHC);
													if (81819 - 594284 == -512464)
													{
														goto IL_40;
													}
													Rect rect = new Rect((float)(498 + 78 * j), (float)(191 + 68 * (i % 6)), (float)64, (float)64);
													if (100257 - 368912 != -268655)
													{
														goto IL_40;
													}
													if (rect.Contains(Event.current.mousePosition))
													{
														if (204461 - 355019 == -150557)
														{
															goto IL_40;
														}
														text2 = ItemData.getName(this.fL8cLFPW1s0[i].material[j]);
														if (100736 - 113230 == -12493)
														{
															goto IL_40;
														}
														vector = new Vector2((float)(498 + 78 * j - 120), (float)(191 + 68 * (i % 6) + 51));
														if (223963 - 207067 == 16897)
														{
															goto IL_40;
														}
													}
												}
												else
												{
													GUI.DrawTexture(new Rect((float)(498 + 78 * j + 6), (float)(191 + 68 * (i % 6) + 5), (float)52, (float)52), this.fMNcw6ARiRa);
													if (182564 - 472102 == -289537)
													{
														goto IL_40;
													}
													Guix.renderTextOutline(new Rect((float)(498 + 78 * j + 45), (float)(191 + 68 * (i % 6) + 35), (float)60, (float)30), "x" + this.fL8cLFPW1s0[i].materialNum[j], this.BPfcLB6C0FG);
													if (284805 - 88663 == 196143)
													{
														goto IL_40;
													}
													GUI.Label(new Rect((float)(498 + 78 * j + 45), (float)(191 + 68 * (i % 6) + 35), (float)60, (float)30), "x" + this.fL8cLFPW1s0[i].materialNum[j], this.wkvcLSaVlrS);
													if (41392 - 347097 != -305705)
													{
														goto IL_40;
													}
													Rect rect2 = new Rect((float)(498 + 78 * j), (float)(191 + 68 * (i % 6)), (float)64, (float)64);
													if (13558 - 434834 == -421275)
													{
														goto IL_40;
													}
													if (rect2.Contains(Event.current.mousePosition))
													{
														if (59133 - 428362 != -369229)
														{
															goto IL_40;
														}
														text2 = ItemData.getName(this.fL8cLFPW1s0[i].material[j]);
														if (223056 - 83043 == 140014)
														{
															goto IL_40;
														}
														vector = new Vector2((float)(498 + 78 * j - 120), (float)(191 + 68 * (i % 6) + 51));
														if (80200 - 151187 != -70987)
														{
															goto IL_40;
														}
													}
												}
												j++;
												if (76720 - 311682 == -234961)
												{
													goto IL_40;
												}
											}
											if (41525 - 517338 != -475813)
											{
												goto IL_40;
											}
										}
										eHoverButtonState eHoverButtonState = HoverButton.newButton(this.eH5cLAoZ5oF[i % 6], new Rect((float)404, (float)(191 + 68 * (i % 6)), (float)64, (float)64), 0.5f);
										if (114043 - 131737 != -17694)
										{
											goto IL_40;
										}
										eHoverButtonState eHoverButtonState2 = eHoverButtonState;
										if (50030 - 457707 == -407676)
										{
											goto IL_40;
										}
										if (eHoverButtonState2 == eHoverButtonState.over)
										{
											if (159272 - 91497 == 67776)
											{
												goto IL_40;
											}
											text2 = ItemData.getName(this.fL8cLFPW1s0[i].name);
											if (81970 - 335959 != -253989)
											{
												goto IL_40;
											}
											vector = new Vector2((float)284, (float)(191 + 68 * (i % 6) + 51));
											if (261140 - 33773 != 227367)
											{
												goto IL_40;
											}
										}
										else if (eHoverButtonState2 == eHoverButtonState.hover)
										{
											if (272669 - 333618 == -60948)
											{
												goto IL_40;
											}
											text = this.fL8cLFPW1s0[i].name;
											if (297118 - 298253 != -1135)
											{
												goto IL_40;
											}
											nHoverImage = this.fL8cLFPW1s0[i].icon;
											if (269433 - 176281 == 93153)
											{
												goto IL_40;
											}
											vector = new Vector2((float)134, (float)(191 + 68 * (i % 6) - 120));
											if (442 - 415384 == -414941)
											{
												goto IL_40;
											}
										}
										i++;
										if (143680 - 296940 == -153259)
										{
											goto IL_40;
										}
									}
									if (223571 - 74360 != 149212)
									{
										GUI.Label(new Rect((float)684, (float)606, (float)50, (float)30), string.Empty + (1 + this.cP8cLRlb51u) + "/" + (global::Math.div((float)(Extensions.get_length(this.fL8cLFPW1s0) - 1), (float)6) + 1), this.WYGcL0numVv);
										if (78771 - 456689 == -377918)
										{
											if (GUI.Button(new Rect((float)568, (float)595, (float)85, (float)57), string.Empty, this.xERcLNGBNnj))
											{
												if (90774 - 416926 == -326151)
												{
													continue;
												}
												if (this.cP8cLRlb51u > 0)
												{
													if (92496 - 405614 != -313118)
													{
														continue;
													}
													this.lS0cLrxNKxn = -1;
													if (135760 - 180608 == -44847)
													{
														continue;
													}
													this.cP8cLRlb51u--;
													if (126774 - 498256 != -371482)
													{
														continue;
													}
												}
												this.audio.PlayOneShot(this.WgocLbNfyn3);
												if (263401 - 595863 != -332462)
												{
													continue;
												}
											}
											if (GUI.Button(new Rect((float)720, (float)595, (float)85, (float)57), string.Empty, this.MAjcLEQjTay))
											{
												if (29003 - 524251 != -495248)
												{
													continue;
												}
												if (this.cP8cLRlb51u < global::Math.div((float)(Extensions.get_length(this.fL8cLFPW1s0) - 1), (float)6))
												{
													if (176188 - 334053 != -157865)
													{
														continue;
													}
													this.lS0cLrxNKxn = -1;
													if (48778 - 281169 == -232390)
													{
														continue;
													}
													this.cP8cLRlb51u++;
													if (40696 - 579023 != -538327)
													{
														continue;
													}
												}
												this.audio.PlayOneShot(this.WgocLbNfyn3);
												if (158711 - 280041 == -121329)
												{
													continue;
												}
											}
											if (this.lS0cLrxNKxn >= 0)
											{
												if (16478 - 565410 != -548932)
												{
													continue;
												}
												if (Extensions.get_length(this.fL8cLFPW1s0) > this.lS0cLrxNKxn)
												{
													if (17336 - 296817 == -279480)
													{
														continue;
													}
													if (this.fL8cLFPW1s0[this.lS0cLrxNKxn].canTrade)
													{
														if (189925 - 577763 == -387837)
														{
															continue;
														}
														if (GUI.Button(new Rect((float)439, (float)603, (float)106, (float)40), string.Empty, this.AZHcLLKoIOy))
														{
															if (126848 - 150807 != -23959)
															{
																continue;
															}
															if (Time.time > this.uJ0cL9IEx4S)
															{
																if (158684 - 59157 != 99527)
																{
																	continue;
																}
																this.uJ0cL9IEx4S = Time.time + 2f;
																if (216817 - 278955 != -62138)
																{
																	continue;
																}
																this.newNoticeBar("Trading..", (float)2);
																if (203075 - 126943 != 76132)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.MYqcL3yskMo);
																if (282193 - 20806 == 261388)
																{
																	continue;
																}
																this.Collector(this.fL8cLFPW1s0[this.lS0cLrxNKxn].name);
																if (137339 - 573638 == -436298)
																{
																	continue;
																}
															}
														}
													}
												}
											}
											if (text2 != "none")
											{
												if (14894 - 552917 == -538023)
												{
													Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text2, this.VdUcwlsw5y2);
													if (252084 - 276356 != -24271)
													{
														GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text2, this.RKscwv8Hosh);
														if (190207 - 338968 == -148761)
														{
															break;
														}
													}
												}
											}
											else
											{
												if (!(text != "none"))
												{
													break;
												}
												if (166638 - 204739 == -38101)
												{
													InventoryClass inventoryClass = new InventoryClass();
													if (176872 - 328388 == -151516)
													{
														inventoryClass.name = text;
														if (19303 - 571879 != -552575)
														{
															Guix.renderItemToolTip((int)vector.x, (int)vector.y, inventoryClass, nHoverImage);
															if (243538 - 58496 == 185042)
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

	// Token: 0x06006277 RID: 25207 RVA: 0x00DA1AF4 File Offset: 0x00D9FCF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Collector(string nItem)
	{
		if (293892 - 524097 != -230205)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (285923 - 165680 == 120243)
			{
				hashtable.Add(21, nItem);
				if (190355 - 427547 != -237191)
				{
					PhotonClient.Connection.OpCustom(246, hashtable, true);
					if (191677 - 297992 != -106314)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006278 RID: 25208 RVA: 0x00DA1BA0 File Offset: 0x00D9FDA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCollectorOperation(Hashtable data)
	{
		if (96055 - 231821 != -135766)
		{
		}
		for (;;)
		{
			IL_F5:
			Debug.Log("onCollectorOperation:" + data[31]);
			if (39862 - 486518 == -446656)
			{
				int num = RuntimeServices.UnboxInt32(data[31]);
				if (272693 - 552296 == -279603)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string s = (string)obj2;
					if (24991 - 251280 == -226289)
					{
						if (num == 1)
						{
							if (15852 - 306050 == -290198)
							{
								InventoryClass inventoryClass = new InventoryClass();
								if (164521 - 435865 != -271343)
								{
									inventoryClass.readData(s);
									if (85206 - 536086 == -450880)
									{
										if (inventoryClass.name != "none")
										{
											if (146167 - 358578 != -212411)
											{
												continue;
											}
											if (inventoryClass.slot != -1)
											{
												if (204075 - 10941 != 193134)
												{
													continue;
												}
												CharacterData.current.inventory[inventoryClass.slot] = inventoryClass;
												if (19995 - 359389 == -339393)
												{
													continue;
												}
											}
										}
										ItemClass itemData = ItemData.getItemData(inventoryClass.name);
										if (198016 - 131775 == 66241)
										{
											string tradeItem = PetShopData.getTradeItem(inventoryClass.name);
											if (146983 - 74821 != 72163)
											{
												if (tradeItem != "none")
												{
													if (264780 - 574848 != -310068)
													{
														continue;
													}
													string[] array = (string[])Stringf.splitToArray(tradeItem, ",").ToBuiltin(typeof(string));
													if (251334 - 393489 != -142155)
													{
														continue;
													}
													if (Extensions.get_length(array) > 0)
													{
														if (287809 - 536609 == -248799)
														{
															continue;
														}
														int i = 0;
														if (277790 - 521831 == -244040)
														{
															continue;
														}
														while (i < Extensions.get_length(array))
														{
															string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
															if (26922 - 361096 != -334174)
															{
																goto IL_F5;
															}
															string nItem = array2[0];
															if (266126 - 148525 == 117602)
															{
																goto IL_F5;
															}
															int nNum = 1;
															if (161058 - 396797 == -235738)
															{
																goto IL_F5;
															}
															if (Extensions.get_length(array2) > 1)
															{
																if (93052 - 438498 == -345445)
																{
																	goto IL_F5;
																}
																nNum = Stringf.getInteger(array2[1]);
																if (174782 - 542694 == -367911)
																{
																	goto IL_F5;
																}
															}
															CharacterData.current.removeInventory(nItem, nNum);
															if (118973 - 520914 != -401941)
															{
																goto IL_F5;
															}
															i++;
															if (207441 - 536406 == -328964)
															{
																goto IL_F5;
															}
														}
														if (72799 - 407844 == -335044)
														{
															continue;
														}
													}
												}
												this.newNoticeBar("Recieve " + itemData.name, 2f);
												if (113938 - 389263 == -275325)
												{
													this.uJ0cL9IEx4S = Time.time + (float)2;
													if (258653 - 260385 != -1731)
													{
														this.ResetPetTradeMenu();
														if (102156 - 129212 != -27055)
														{
															this.ResetPetShopInventory();
															if (89143 - 295845 == -206702)
															{
																if (!this.audio)
																{
																	break;
																}
																if (81074 - 316380 != -235305)
																{
																	this.audio.PlayOneShot((AudioClip)Resources.Load("Sound/Jingle/QuestComplete", typeof(AudioClip)));
																	if (209499 - 337361 != -127861)
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
							this.newNoticeBar("PetShop Trade Error!", 1f);
							if (132646 - 553255 == -420609)
							{
								this.uJ0cL9IEx4S = Time.time + (float)1;
								if (14675 - 574180 == -559505)
								{
									this.ResetPetTradeMenu();
									if (202884 - 336304 != -133419)
									{
										this.ResetPetShopInventory();
										if (50881 - 304285 == -253404)
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

	// Token: 0x06006279 RID: 25209 RVA: 0x00DA2138 File Offset: 0x00DA0338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetPetUpgradeMenu()
	{
		if (58715 - 44798 != 13917)
		{
		}
		for (;;)
		{
			this.g7VcLWDqu9H = -1;
			if (39449 - 467395 != -427945)
			{
				this.NlIcLuXobWj = null;
				if (119465 - 24325 != 95141)
				{
					this.wOucLytDbLR = new IconButtonClass();
					if (154027 - 248557 == -94530)
					{
						this.iTwcLVZAbxT = null;
						if (37313 - 532345 != -495031)
						{
							this.deVcLhVp6jV = null;
							if (48321 - 337036 == -288715)
							{
								this.YwOcLKphSSR = null;
								if (253971 - 109826 != 144146)
								{
									this.HZKcLzYLyH9 = null;
									if (279486 - 564508 == -285022)
									{
										this.NCDcw5MRBk9 = null;
										if (117330 - 297476 != -180145)
										{
											this.G1gcwcaBs0L = false;
											if (36686 - 300979 != -264292)
											{
												this.LXjcwnoBVJI = null;
												if (120197 - 25031 == 95166)
												{
													this.d2bcwQPWU44 = null;
													if (37116 - 572130 == -535014)
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

	// Token: 0x0600627A RID: 25210 RVA: 0x00DA22E0 File Offset: 0x00DA04E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectPetUpgrade(int nSlot)
	{
		if (281024 - 191313 != 89712)
		{
		}
		for (;;)
		{
			IL_2AA:
			this.g7VcLWDqu9H = -1;
			if (2465 - 362740 != -360274)
			{
				this.NlIcLuXobWj = null;
				if (127575 - 442803 == -315228)
				{
					this.wOucLytDbLR.reset();
					if (252520 - 192184 != 60337)
					{
						this.deVcLhVp6jV = null;
						if (107715 - 195002 == -87287)
						{
							this.YwOcLKphSSR = null;
							if (116105 - 262041 == -145936)
							{
								this.HZKcLzYLyH9 = null;
								if (250212 - 99342 == 150870)
								{
									this.NCDcw5MRBk9 = null;
									if (45082 - 554391 != -509308)
									{
										this.G1gcwcaBs0L = false;
										if (258297 - 132327 == 125970)
										{
											this.LXjcwnoBVJI = null;
											if (41092 - 413204 == -372112)
											{
												this.d2bcwQPWU44 = null;
												if (629 - 386633 != -386003)
												{
													string name = CharacterData.current.inventory[nSlot].name;
													if (167108 - 458833 != -291724)
													{
														string text = name.Substring(0, 5);
														if (80961 - 3940 == 77021)
														{
															int lastDigit = Stringf.getLastDigit(name);
															if (15314 - 590107 == -574793)
															{
																string upgradeItem = PetShopData.getUpgradeItem(text);
																if (268551 - 231863 == 36688)
																{
																	if (text.Substring(0, 2) != "p_")
																	{
																		if (61683 - 302532 == -240849)
																		{
																			this.newNoticeBar("Error: only pet can be trained.", 2f);
																			if (38918 - 31878 == 7040)
																			{
																				break;
																			}
																		}
																	}
																	else if (lastDigit >= 9)
																	{
																		if (167038 - 3427 != 163612)
																		{
																			this.newNoticeBar("This pet has already reach maximum level.", 2f);
																			if (296258 - 81119 == 215139)
																			{
																				break;
																			}
																		}
																	}
																	else if (upgradeItem == "none")
																	{
																		if (69831 - 418940 == -349109)
																		{
																			this.newNoticeBar("Upgrade is not available for this pet.", 2f);
																			if (179256 - 48598 != 130659)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		string[] array = (string[])Stringf.splitToArray(upgradeItem, ",").ToBuiltin(typeof(string));
																		if (229765 - 535284 != -305518)
																		{
																			if (Extensions.get_length(array) <= 0)
																			{
																				break;
																			}
																			if (60352 - 263557 != -203204)
																			{
																				this.g7VcLWDqu9H = nSlot;
																				if (107359 - 245905 == -138546)
																				{
																					this.NlIcLuXobWj = ItemData.getItemData(name);
																					if (235584 - 276442 == -40858)
																					{
																						this.wOucLytDbLR.name = name;
																						if (254339 - 195906 != 58434)
																						{
																							this.wOucLytDbLR.command = nSlot + 20;
																							if (284279 - 233549 == 50730)
																							{
																								this.wOucLytDbLR.image = (Texture2D)IconButton.getIconImage(name);
																								if (239201 - 340891 == -101690)
																								{
																									this.iTwcLVZAbxT = new HoverButtonClass[Extensions.get_length(array)];
																									if (223926 - 302906 == -78980)
																									{
																										this.deVcLhVp6jV = new string[Extensions.get_length(array)];
																										if (105918 - 169897 == -63979)
																										{
																											this.YwOcLKphSSR = new int[Extensions.get_length(array)];
																											if (239790 - 316664 != -76873)
																											{
																												this.HZKcLzYLyH9 = new Texture[Extensions.get_length(array)];
																												if (255475 - 560175 != -304699)
																												{
																													this.NCDcw5MRBk9 = new bool[Extensions.get_length(array)];
																													if (275261 - 140837 == 134424)
																													{
																														this.G1gcwcaBs0L = true;
																														if (239429 - 132036 == 107393)
																														{
																															int i = 0;
																															if (88574 - 15845 == 72729)
																															{
																																while (i < Extensions.get_length(array))
																																{
																																	this.iTwcLVZAbxT[i] = new HoverButtonClass();
																																	if (147961 - 374019 != -226058)
																																	{
																																		goto IL_2AA;
																																	}
																																	string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
																																	if (224378 - 497631 != -273253)
																																	{
																																		goto IL_2AA;
																																	}
																																	if (Extensions.get_length(array2) > 0)
																																	{
																																		if (280767 - 343550 != -62783)
																																		{
																																			goto IL_2AA;
																																		}
																																		this.deVcLhVp6jV[i] = array2[0];
																																		if (277231 - 427710 != -150479)
																																		{
																																			goto IL_2AA;
																																		}
																																	}
																																	if (Extensions.get_length(array2) > 1)
																																	{
																																		if (248691 - 394613 != -145922)
																																		{
																																			goto IL_2AA;
																																		}
																																		this.YwOcLKphSSR[i] = (int)Mathf.Clamp(Mathf.Floor(float.Parse(array2[1]) * (float)lastDigit), (float)1, (float)99);
																																		if (4529 - 249854 != -245325)
																																		{
																																			goto IL_2AA;
																																		}
																																	}
																																	else
																																	{
																																		this.YwOcLKphSSR[i] = 1;
																																		if (1954 - 548124 == -546169)
																																		{
																																			goto IL_2AA;
																																		}
																																	}
																																	this.HZKcLzYLyH9[i] = IconButton.getIconImage(array2[0]);
																																	if (224093 - 544828 == -320734)
																																	{
																																		goto IL_2AA;
																																	}
																																	this.NCDcw5MRBk9[i] = true;
																																	if (93028 - 149628 != -56600)
																																	{
																																		goto IL_2AA;
																																	}
																																	if (this.deVcLhVp6jV[i] != string.Empty)
																																	{
																																		if (186147 - 455788 == -269640)
																																		{
																																			goto IL_2AA;
																																		}
																																		if (this.deVcLhVp6jV[i] != "none")
																																		{
																																			if (2950 - 209272 == -206321)
																																			{
																																				goto IL_2AA;
																																			}
																																			if (this.YwOcLKphSSR[i] > 0)
																																			{
																																				if (101339 - 262957 == -161617)
																																				{
																																					goto IL_2AA;
																																				}
																																				if (CharacterData.current.getItemTotalNum(this.deVcLhVp6jV[i]) < this.YwOcLKphSSR[i])
																																				{
																																					if (245008 - 172166 == 72843)
																																					{
																																						goto IL_2AA;
																																					}
																																					this.NCDcw5MRBk9[i] = false;
																																					if (147692 - 129781 != 17911)
																																					{
																																						goto IL_2AA;
																																					}
																																					this.G1gcwcaBs0L = false;
																																					if (290443 - 473171 != -182728)
																																					{
																																						goto IL_2AA;
																																					}
																																				}
																																			}
																																		}
																																	}
																																	i++;
																																	if (196466 - 342970 == -146503)
																																	{
																																		goto IL_2AA;
																																	}
																																}
																																if (190506 - 119373 != 71134)
																																{
																																	this.LXjcwnoBVJI = ItemData.getItemData(text + (lastDigit + 1));
																																	if (1658 - 91500 != -89841)
																																	{
																																		this.d2bcwQPWU44 = IconButton.getIconImage(name);
																																		if (53466 - 296737 != -243270)
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

	// Token: 0x0600627B RID: 25211 RVA: 0x00DA2B9C File Offset: 0x00DA0D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderPetUpgradeMenu()
	{
		if (121266 - 52872 != 68395)
		{
		}
		for (;;)
		{
			IL_348:
			string text = "none";
			if (65573 - 322659 != -257085)
			{
				string text2 = "none";
				if (98510 - 466528 == -368018)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (66187 - 43584 != 22604)
					{
						Texture nHoverImage = null;
						if (87332 - 384753 == -297421)
						{
							GUI.DrawTexture(new Rect((float)477, (float)103, (float)90, (float)40), this.TkHcLfqeE4n.hover.background);
							if (221309 - 467076 != -245766)
							{
								if (GUI.Button(new Rect((float)397, (float)103, (float)72, (float)40), string.Empty, this.rmjcLMiLwID))
								{
									if (43671 - 202300 == -158628)
									{
										continue;
									}
									this.AMmcLpO0yFd = ePetShopTab.trade;
									if (38998 - 89069 != -50071)
									{
										continue;
									}
									this.cP8cLRlb51u = 0;
									if (117690 - 295629 != -177939)
									{
										continue;
									}
									this.lS0cLrxNKxn = -1;
									if (271651 - 555292 == -283640)
									{
										continue;
									}
									this.audio.PlayOneShot(this.WgocLbNfyn3);
									if (83878 - 508691 != -424813)
									{
										continue;
									}
									this.ResetPetTradeMenu();
									if (122542 - 421870 == -299327)
									{
										continue;
									}
								}
								GUI.DrawTexture(new Rect((float)376, (float)136, (float)464, (float)515), this.eq2cLCGa6TF);
								if (55083 - 469381 != -414297)
								{
									if (this.wOucLytDbLR.image)
									{
										if (211633 - 342978 != -131345)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)446, (float)236, (float)64, (float)64), this.wOucLytDbLR.image);
										if (163018 - 597414 == -434395)
										{
											continue;
										}
									}
									eIconButtonState eIconButtonState = IconButton.IconButton(this.wOucLytDbLR, new Rect((float)446, (float)236, (float)64, (float)64));
									if (143912 - 39728 == 104184)
									{
										if (eIconButtonState == eIconButtonState.hover)
										{
											goto IL_851;
										}
										if (281033 - 539307 != -258274)
										{
											continue;
										}
										if (eIconButtonState == eIconButtonState.over)
										{
											if (48036 - 150778 != -102741)
											{
												goto IL_851;
											}
											continue;
										}
										else if (eIconButtonState == eIconButtonState.drop)
										{
											if (285848 - 299996 == -14147)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)453, (float)243, (float)50, (float)50), this.UipcwJMgJoL);
											if (184964 - 27270 != 157694)
											{
												continue;
											}
											if (this.SVccLxaHEOS != 0)
											{
												if (50661 - 15601 != 35060)
												{
													continue;
												}
												this.SelectPetUpgrade(this.SVccLxaHEOS - 20);
												if (42508 - 504271 == -461762)
												{
													continue;
												}
												this.SVccLxaHEOS = 0;
												if (51511 - 146351 != -94840)
												{
													continue;
												}
												this.audio.PlayOneShot(this.MYqcL3yskMo);
												if (292086 - 273651 != 18435)
												{
													continue;
												}
											}
										}
										else if (eIconButtonState == eIconButtonState.drag)
										{
											if (198729 - 399657 != -200928)
											{
												continue;
											}
											if (!RuntimeServices.EqualityOperator(this.NlIcLuXobWj, null))
											{
												if (298450 - 598880 != -300430)
												{
													continue;
												}
												this.g7VcLWDqu9H = -1;
												if (123377 - 591980 == -468602)
												{
													continue;
												}
												this.SVccLxaHEOS = this.wOucLytDbLR.command;
												if (80175 - 256869 == -176693)
												{
													continue;
												}
												this.ResetPetUpgradeMenu();
												if (18119 - 73510 == -55390)
												{
													continue;
												}
												if (this.hGmcLd8RAfl)
												{
													if (191326 - 69925 != 121401)
													{
														continue;
													}
													this.audio.PlayOneShot(this.hGmcLd8RAfl);
													if (212093 - 19578 != 192515)
													{
														continue;
													}
												}
											}
										}
										IL_10F8:
										if (!RuntimeServices.EqualityOperator(this.NlIcLuXobWj, null))
										{
											if (120369 - 115765 != 4604)
											{
												continue;
											}
											GUI.Label(new Rect((float)420, (float)164, (float)300, (float)30), this.NlIcLuXobWj.name, this.N4OcLmUGgbU);
											if (169012 - 187014 != -18002)
											{
												continue;
											}
											GUI.Label(new Rect((float)750, (float)164, (float)60, (float)30), "Lv." + Stringf.getLastDigit(this.wOucLytDbLR.name), this.N4OcLmUGgbU);
											if (224982 - 536712 == -311729)
											{
												continue;
											}
											Guix.renderSmallNumber(496, 298, Stringf.getLastDigit(this.wOucLytDbLR.name), true, 1f);
											if (108340 - 9242 != 99098)
											{
												continue;
											}
											GUI.Label(new Rect((float)545, (float)200, (float)272, (float)60), this.NlIcLuXobWj.des, this.Pg8cLjb99rW);
											if (289897 - 116572 == 173326)
											{
												continue;
											}
											GUI.Label(new Rect((float)570, (float)310, (float)240, (float)30), this.NlIcLuXobWj.special, this.VfJcLkaprjS);
											if (256888 - 87492 != 169396)
											{
												continue;
											}
											int i = 0;
											if (299217 - 353967 != -54750)
											{
												continue;
											}
											while (i < 8)
											{
												if (this.NlIcLuXobWj.att[i] > 0)
												{
													if (224004 - 544276 == -320271)
													{
														goto IL_348;
													}
													GUI.Label(new Rect((float)(552 + i % 4 * 62), (float)258 + Mathf.Floor((float)(i / 4)) * (float)24, (float)64, (float)24), string.Empty + this.NlIcLuXobWj.att[i], this.orHcLoZOC7X);
													if (240012 - 164732 == 75281)
													{
														goto IL_348;
													}
												}
												else
												{
													GUI.Label(new Rect((float)(552 + i % 4 * 62), (float)258 + Mathf.Floor((float)(i / 4)) * (float)24, (float)64, (float)24), "-", this.orHcLoZOC7X);
													if (35994 - 397130 == -361135)
													{
														goto IL_348;
													}
												}
												i++;
												if (134968 - 497236 != -362268)
												{
													goto IL_348;
												}
											}
											if (132698 - 225814 != -93116)
											{
												continue;
											}
											int j = 0;
											if (83176 - 497158 != -413982)
											{
												continue;
											}
											while (j < Extensions.get_length(this.deVcLhVp6jV))
											{
												if (this.HZKcLzYLyH9[j])
												{
													if (256823 - 181994 == 74830)
													{
														goto IL_348;
													}
													GUI.DrawTexture(new Rect((float)(421 + j * 80), (float)381, (float)64, (float)64), this.HZKcLzYLyH9[j]);
													if (133116 - 350950 == -217833)
													{
														goto IL_348;
													}
												}
												eHoverButtonState eHoverButtonState = HoverButton.newButton(this.iTwcLVZAbxT[j], new Rect((float)(421 + j * 80 + 7), (float)388, (float)50, (float)50), (float)0);
												if (285284 - 146958 != 138326)
												{
													goto IL_348;
												}
												if (eHoverButtonState == eHoverButtonState.over)
												{
													goto IL_D13;
												}
												if (249364 - 405155 == -155790)
												{
													goto IL_348;
												}
												if (eHoverButtonState == eHoverButtonState.hover)
												{
													if (1434 - 316935 != -315500)
													{
														goto IL_D13;
													}
													goto IL_348;
												}
												IL_73D:
												Guix.renderTextOutline(new Rect((float)(421 + j * 80 + 45), (float)416, (float)60, (float)30), "x" + this.YwOcLKphSSR[j], this.BPfcLB6C0FG);
												if (267803 - 508420 == -240616)
												{
													goto IL_348;
												}
												if (this.NCDcw5MRBk9[j])
												{
													if (204444 - 296193 == -91748)
													{
														goto IL_348;
													}
													GUI.Label(new Rect((float)(421 + j * 80 + 45), (float)416, (float)60, (float)30), "x" + this.YwOcLKphSSR[j], this.Ei6cLPOjCHC);
													if (122387 - 252205 != -129818)
													{
														goto IL_348;
													}
												}
												else
												{
													GUI.Label(new Rect((float)(421 + j * 80 + 45), (float)416, (float)60, (float)30), "x" + this.YwOcLKphSSR[j], this.wkvcLSaVlrS);
													if (145949 - 252355 == -106405)
													{
														goto IL_348;
													}
												}
												j++;
												if (162731 - 408523 != -245792)
												{
													goto IL_348;
												}
												continue;
												IL_D13:
												text2 = ItemData.getName(this.deVcLhVp6jV[j]);
												if (220474 - 278218 != -57744)
												{
													goto IL_348;
												}
												vector = new Vector2((float)(421 + j * 80 - 120), (float)432);
												if (10430 - 407854 != -397423)
												{
													goto IL_73D;
												}
												goto IL_348;
											}
											if (92012 - 105093 != -13081)
											{
												continue;
											}
											if (Time.time > this.uJ0cL9IEx4S)
											{
												if (225523 - 402204 != -176681)
												{
													continue;
												}
												if (this.G1gcwcaBs0L)
												{
													if (171547 - 451352 == -279804)
													{
														continue;
													}
													if (GUI.Button(new Rect((float)556, (float)430, (float)118, (float)96), string.Empty, this.rFqcLwkjGyP))
													{
														if (89980 - 465279 != -375299)
														{
															continue;
														}
														this.PetUpgrade(this.wOucLytDbLR.name.Substring(0, 5), Stringf.getLastDigit(this.wOucLytDbLR.name), this.g7VcLWDqu9H);
														if (208438 - 431493 != -223055)
														{
															continue;
														}
														this.uJ0cL9IEx4S = Time.time + (float)3;
														if (37651 - 228676 == -191024)
														{
															continue;
														}
														this.newNoticeBar("Training...", 3f);
														if (127893 - 162231 == -34337)
														{
															continue;
														}
														this.audio.PlayOneShot(this.MYqcL3yskMo);
														if (28881 - 234336 != -205455)
														{
															continue;
														}
													}
												}
											}
										}
										else
										{
											GUI.Label(new Rect((float)420, (float)164, (float)300, (float)30), "N/A", this.N4OcLmUGgbU);
											if (177861 - 384599 != -206738)
											{
												continue;
											}
											GUI.Label(new Rect((float)750, (float)164, (float)60, (float)30), "Lv.0", this.N4OcLmUGgbU);
											if (210246 - 40117 == 170130)
											{
												continue;
											}
											GUI.Label(new Rect((float)545, (float)200, (float)272, (float)60), this.f8Ncwev6rNE, this.Pg8cLjb99rW);
											if (81075 - 448043 == -366967)
											{
												continue;
											}
											GUI.Label(new Rect((float)570, (float)310, (float)240, (float)30), "n/a", this.VfJcLkaprjS);
											if (96254 - 259446 == -163191)
											{
												continue;
											}
											int k = 0;
											if (273492 - 383817 != -110325)
											{
												continue;
											}
											while (k < 8)
											{
												GUI.Label(new Rect((float)(552 + k % 4 * 62), (float)258 + Mathf.Floor((float)(k / 4)) * (float)24, (float)64, (float)24), "-", this.orHcLoZOC7X);
												if (112418 - 443960 == -331541)
												{
													goto IL_348;
												}
												k++;
												if (171769 - 442940 == -271170)
												{
													goto IL_348;
												}
											}
											if (206683 - 446300 == -239616)
											{
												continue;
											}
										}
										if (!RuntimeServices.EqualityOperator(this.LXjcwnoBVJI, null))
										{
											if (60675 - 273857 != -213182)
											{
												continue;
											}
											if (this.d2bcwQPWU44 != null)
											{
												if (290358 - 567126 != -276768)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)446, (float)525, (float)64, (float)64), this.d2bcwQPWU44);
												if (146404 - 386232 == -239827)
												{
													continue;
												}
											}
											if (this.wOucLytDbLR != null)
											{
												if (5151 - 30042 != -24891)
												{
													continue;
												}
												Guix.renderSmallNumber(496, 590, Stringf.getLastDigit(this.wOucLytDbLR.name) + 1, true, 1f);
												if (36129 - 116741 != -80612)
												{
													continue;
												}
											}
											int l = 0;
											if (244447 - 251681 != -7234)
											{
												continue;
											}
											while (l < 8)
											{
												GUI.Label(new Rect((float)(552 + l % 4 * 62), (float)519 + Mathf.Floor((float)(l / 4)) * (float)24, (float)64, (float)24), string.Empty + this.LXjcwnoBVJI.att[l], this.orHcLoZOC7X);
												if (85838 - 213349 == -127510)
												{
													goto IL_348;
												}
												l++;
												if (172137 - 85349 == 86789)
												{
													goto IL_348;
												}
											}
											if (39970 - 410412 == -370441)
											{
												continue;
											}
											GUI.Label(new Rect((float)570, (float)572, (float)240, (float)30), this.LXjcwnoBVJI.special, this.VfJcLkaprjS);
											if (152040 - 297917 != -145877)
											{
												continue;
											}
										}
										else
										{
											int m = 0;
											if (202030 - 458505 == -256474)
											{
												continue;
											}
											while (m < 8)
											{
												GUI.Label(new Rect((float)(552 + m % 4 * 62), (float)519 + Mathf.Floor((float)(m / 4)) * (float)24, (float)64, (float)24), "-", this.orHcLoZOC7X);
												if (254018 - 161906 == 92113)
												{
													goto IL_348;
												}
												m++;
												if (266710 - 82997 != 183713)
												{
													goto IL_348;
												}
											}
											if (68346 - 239473 != -171127)
											{
												continue;
											}
											GUI.Label(new Rect((float)570, (float)572, (float)240, (float)30), "n/a", this.VfJcLkaprjS);
											if (249227 - 286952 == -37724)
											{
												continue;
											}
										}
										if (text2 != "none")
										{
											if (267891 - 192803 == 75089)
											{
												continue;
											}
											Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text2, this.VdUcwlsw5y2);
											if (123183 - 157313 == -34129)
											{
												continue;
											}
											GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text2, this.RKscwv8Hosh);
											if (57747 - 429840 != -372092)
											{
												break;
											}
											continue;
										}
										else
										{
											if (!(text != "none"))
											{
												break;
											}
											if (135040 - 289008 == -153967)
											{
												continue;
											}
											InventoryClass inventoryClass = new InventoryClass();
											if (225926 - 257370 != -31444)
											{
												continue;
											}
											inventoryClass.name = text;
											if (233702 - 200978 == 32725)
											{
												continue;
											}
											Guix.renderItemToolTip((int)vector.x, (int)vector.y, inventoryClass, nHoverImage);
											if (168022 - 75935 != 92088)
											{
												break;
											}
											continue;
										}
										IL_851:
										GUI.DrawTexture(new Rect((float)453, (float)243, (float)50, (float)50), this.UipcwJMgJoL);
										if (143696 - 446859 != -303162)
										{
											goto IL_10F8;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600627C RID: 25212 RVA: 0x00DA3EC0 File Offset: 0x00DA20C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PetUpgrade(string nPetType, int nLevel, int nSlot)
	{
		if (133817 - 410431 != -276613)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (72186 - 470674 == -398488)
			{
				hashtable.Add(21, nPetType);
				if (227305 - 127967 == 99338)
				{
					hashtable.Add(22, PhotonClient.cInt16(nLevel));
					if (30132 - 235594 != -205461)
					{
						hashtable.Add(23, PhotonClient.cInt16(nSlot));
						if (75770 - 557157 == -481387)
						{
							PhotonClient.Connection.OpCustom(247, hashtable, true);
							if (279698 - 553452 == -273754)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600627D RID: 25213 RVA: 0x00DA3FD0 File Offset: 0x00DA21D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPetUpgradeOperation(Hashtable data)
	{
		if (168071 - 416865 != -248793)
		{
		}
		for (;;)
		{
			IL_527:
			Debug.Log("onPetUpgradeOperation:" + data[31]);
			if (18898 - 450113 != -431214)
			{
				int num = RuntimeServices.UnboxInt32(data[31]);
				if (39186 - 119828 == -80642)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string s = (string)obj2;
					if (161162 - 106342 == 54820)
					{
						if (num == 1)
						{
							if (196273 - 70247 != 126027)
							{
								InventoryClass inventoryClass = new InventoryClass();
								if (63242 - 280961 == -217719)
								{
									inventoryClass.readData(s);
									if (32913 - 343692 == -310779)
									{
										if (inventoryClass.name != "none")
										{
											if (148768 - 493971 != -345203)
											{
												continue;
											}
											if (inventoryClass.slot != -1)
											{
												if (263178 - 15835 == 247344)
												{
													continue;
												}
												CharacterData.current.inventory[inventoryClass.slot] = inventoryClass;
												if (273301 - 394163 != -120862)
												{
													continue;
												}
											}
										}
										object obj4;
										object obj3 = obj4 = data[21];
										if (!(obj3 is string))
										{
											obj4 = RuntimeServices.Coerce(obj3, typeof(string));
										}
										string text = (string)obj4;
										if (205408 - 589190 == -383782)
										{
											int num2 = RuntimeServices.UnboxInt32(data[22]);
											if (24425 - 588080 != -563654)
											{
												int num3 = RuntimeServices.UnboxInt32(data[23]);
												if (256886 - 265329 != -8442)
												{
													Debug.Log("Upgraded " + text + num2 + "@" + num3);
													if (264417 - 354453 == -90036)
													{
														string upgradeItem = PetShopData.getUpgradeItem(text);
														if (52099 - 511089 != -458989)
														{
															if (upgradeItem != "none")
															{
																if (80851 - 456717 != -375866)
																{
																	continue;
																}
																string[] array = (string[])Stringf.splitToArray(upgradeItem, ",").ToBuiltin(typeof(string));
																if (210314 - 9560 != 200754)
																{
																	continue;
																}
																if (Extensions.get_length(array) > 0)
																{
																	if (179524 - 346884 == -167359)
																	{
																		continue;
																	}
																	int i = 0;
																	if (155565 - 343698 == -188132)
																	{
																		continue;
																	}
																	while (i < Extensions.get_length(array))
																	{
																		string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
																		if (117235 - 66361 == 50875)
																		{
																			goto IL_527;
																		}
																		string nItem = array2[0];
																		if (39421 - 51784 != -12363)
																		{
																			goto IL_527;
																		}
																		int nNum = (int)Mathf.Clamp(Mathf.Floor(float.Parse(array2[1]) * (float)num2), (float)1, (float)99);
																		if (30431 - 85748 != -55317)
																		{
																			goto IL_527;
																		}
																		CharacterData.current.removeInventory(nItem, nNum);
																		if (290827 - 221302 != 69525)
																		{
																			goto IL_527;
																		}
																		i++;
																		if (67309 - 383115 != -315806)
																		{
																			goto IL_527;
																		}
																	}
																	if (292527 - 151113 != 141414)
																	{
																		continue;
																	}
																}
															}
															this.newNoticeBar("Pet Upgrade Successful!", 1f);
															if (234732 - 481808 != -247075)
															{
																this.uJ0cL9IEx4S = Time.time + (float)1;
																if (280817 - 205936 != 74882)
																{
																	this.ResetPetUpgradeMenu();
																	if (39258 - 456366 != -417107)
																	{
																		this.ResetPetShopInventory();
																		if (208049 - 341313 != -133263)
																		{
																			if (!this.audio)
																			{
																				break;
																			}
																			if (193880 - 218851 == -24971)
																			{
																				this.audio.PlayOneShot((AudioClip)Resources.Load("Sound/Jingle/QuestComplete", typeof(AudioClip)));
																				if (182268 - 416451 == -234183)
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
							this.newNoticeBar("Pet Upgrade Error!", 1f);
							if (41578 - 562835 == -521257)
							{
								this.uJ0cL9IEx4S = Time.time + (float)1;
								if (234412 - 119548 != 114865)
								{
									this.ResetPetUpgradeMenu();
									if (261599 - 202267 == 59332)
									{
										this.ResetPetShopInventory();
										if (68543 - 142321 != -73777)
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

	// Token: 0x0600627E RID: 25214 RVA: 0x00DA45F0 File Offset: 0x00DA27F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitPetShopInventory()
	{
		if (2419 - 492269 != -489849)
		{
		}
		for (;;)
		{
			this.JbdcwI0apKC = new IconButtonClass[30];
			if (184088 - 68130 != 115959)
			{
				this.UipcwJMgJoL = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover", typeof(Texture));
				if (158408 - 412132 == -253724)
				{
					this.fMNcw6ARiRa = (Texture)Resources.Load("GameGui/Icons/Common/Item_inactive", typeof(Texture));
					if (65520 - 503004 != -437483)
					{
						this.MOgcwtTpHtv = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
						if (184719 - 531068 == -346349)
						{
							this.k1JcwX7POps = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
							if (264984 - 288421 == -23437)
							{
								this.dLGcwOYqxw1 = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
								if (76924 - 198395 != -121470)
								{
									this.D1Bcw2TLO0I = new GUIStyle();
									if (288197 - 353321 != -65123)
									{
										this.D1Bcw2TLO0I.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
										if (291316 - 227025 == 64291)
										{
											this.D1Bcw2TLO0I.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
											if (174374 - 515299 == -340925)
											{
												this.D1Bcw2TLO0I.alignment = TextAnchor.MiddleCenter;
												if (75357 - 413417 != -338059)
												{
													this.RKscwv8Hosh = new GUIStyle();
													if (39449 - 33106 == 6343)
													{
														this.RKscwv8Hosh.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
														if (206889 - 523682 == -316793)
														{
															this.RKscwv8Hosh.alignment = TextAnchor.MiddleCenter;
															if (34091 - 570159 == -536068)
															{
																this.RKscwv8Hosh.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																if (187793 - 17341 == 170452)
																{
																	this.VdUcwlsw5y2 = new GUIStyle();
																	if (279600 - 185050 == 94550)
																	{
																		this.VdUcwlsw5y2.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																		if (213898 - 535033 != -321134)
																		{
																			this.VdUcwlsw5y2.alignment = TextAnchor.MiddleCenter;
																			if (184412 - 69244 != 115169)
																			{
																				this.VdUcwlsw5y2.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																				if (299354 - 333682 == -34328)
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

	// Token: 0x0600627F RID: 25215 RVA: 0x00DA49AC File Offset: 0x00DA2BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetPetShopInventory()
	{
		if (25236 - 141269 != -116032)
		{
		}
		for (;;)
		{
			IL_1A:
			int i = 0;
			if (211658 - 539133 != -327474)
			{
				while (i < 30)
				{
					this.JbdcwI0apKC[i] = new IconButtonClass();
					if (247319 - 329278 != -81959)
					{
						goto IL_1A;
					}
					if (CharacterData.current.inventory[i].name != "none")
					{
						if (27732 - 364610 == -336877)
						{
							goto IL_1A;
						}
						this.JbdcwI0apKC[i].name = CharacterData.current.inventory[i].name;
						if (220147 - 597422 != -377275)
						{
							goto IL_1A;
						}
						this.JbdcwI0apKC[i].command = i + 20;
						if (277590 - 322378 != -44788)
						{
							goto IL_1A;
						}
						this.JbdcwI0apKC[i].image = (Texture2D)IconButton.getCommandIcon(i + 20);
						if (297005 - 48421 == 248585)
						{
							goto IL_1A;
						}
					}
					i++;
					if (124432 - 65166 != 59266)
					{
						goto IL_1A;
					}
				}
				if (229749 - 515482 != -285732)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x00DA4B40 File Offset: 0x00DA2D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderPetShopInventory()
	{
		if (30459 - 92420 != -61961)
		{
		}
		for (;;)
		{
			IL_61B:
			int num = 0;
			if (135434 - 312728 == -177294)
			{
				string text = "none";
				if (4695 - 539288 == -534593)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (287677 - 596265 != -308587)
					{
						Texture nHoverImage = null;
						if (63715 - 83274 == -19559)
						{
							int i = 0;
							if (188655 - 225619 == -36964)
							{
								while (i < 30)
								{
									if (this.JbdcwI0apKC[i].name != "none")
									{
										if (70251 - 285026 == -214774)
										{
											goto IL_61B;
										}
										Rect position = new Rect((float)418 + global::Math.mod((float)i, (float)6) * (float)60, (float)(674 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
										if (293069 - 200920 == 92150)
										{
											goto IL_61B;
										}
										if (this.lS0cLrxNKxn - 20 != i)
										{
											if (284096 - 390532 != -106436)
											{
												goto IL_61B;
											}
											eIconButtonState eIconButtonState = IconButton.IconButton(this.JbdcwI0apKC[i], new Rect(position.x + (float)6, position.y + (float)6, (float)50, (float)50));
											if (262768 - 291174 == -28405)
											{
												goto IL_61B;
											}
											if (Time.time < this.uJ0cL9IEx4S)
											{
												if (3489 - 127452 != -123963)
												{
													goto IL_61B;
												}
												eIconButtonState = eIconButtonState.none;
												if (299610 - 110704 != 188906)
												{
													goto IL_61B;
												}
											}
											eIconButtonState eIconButtonState2 = eIconButtonState;
											if (40810 - 313534 == -272723)
											{
												goto IL_61B;
											}
											if (eIconButtonState2 == eIconButtonState.over)
											{
												if (175715 - 104885 == 70831)
												{
													goto IL_61B;
												}
												GUI.DrawTexture(position, this.JbdcwI0apKC[i].image);
												if (77857 - 214528 != -136671)
												{
													goto IL_61B;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.UipcwJMgJoL);
												if (241258 - 35069 == 206190)
												{
													goto IL_61B;
												}
												if (this.SVccLxaHEOS == 0)
												{
													if (298363 - 487081 == -188717)
													{
														goto IL_61B;
													}
													text = ItemData.getName(CharacterData.current.inventory[i].name);
													if (66831 - 42272 == 24560)
													{
														goto IL_61B;
													}
													if (CharacterData.current.inventory[i].mlv != 0)
													{
														if (284650 - 580340 == -295689)
														{
															goto IL_61B;
														}
														text += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
														if (239309 - 19925 != 219384)
														{
															goto IL_61B;
														}
													}
													vector = new Vector2(position.x - (float)120, position.y + (float)51);
													if (36023 - 231927 == -195903)
													{
														goto IL_61B;
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.hover)
											{
												if (58572 - 458366 == -399793)
												{
													goto IL_61B;
												}
												GUI.DrawTexture(position, this.JbdcwI0apKC[i].image);
												if (162507 - 229675 == -67167)
												{
													goto IL_61B;
												}
												GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.UipcwJMgJoL);
												if (208532 - 214422 == -5889)
												{
													goto IL_61B;
												}
												if (this.SVccLxaHEOS == 0)
												{
													if (76655 - 234702 != -158047)
													{
														goto IL_61B;
													}
													if (CharacterData.current.inventory[i].name != "none")
													{
														if (199962 - 390544 != -190582)
														{
															goto IL_61B;
														}
														num = i + 20;
														if (138006 - 479811 != -341805)
														{
															goto IL_61B;
														}
														vector = new Vector2(position.x - (float)264, position.y - (float)128);
														if (55602 - 290087 == -234484)
														{
															goto IL_61B;
														}
														nHoverImage = this.JbdcwI0apKC[i].image;
														if (43848 - 374843 == -330994)
														{
															goto IL_61B;
														}
													}
												}
											}
											else if (eIconButtonState2 == eIconButtonState.press)
											{
												if (280981 - 367093 != -86112)
												{
													goto IL_61B;
												}
												GUI.DrawTexture(position, this.JbdcwI0apKC[i].image);
												if (230821 - 2138 == 228684)
												{
													goto IL_61B;
												}
												this.JbdcwI0apKC[i].state = eIconButtonState.none;
												if (211906 - 478569 != -266663)
												{
													goto IL_61B;
												}
											}
											else if (eIconButtonState2 == eIconButtonState.drag)
											{
												if (79016 - 252987 != -173971)
												{
													goto IL_61B;
												}
												if (this.JbdcwI0apKC[i].command != 0)
												{
													if (89309 - 235759 == -146449)
													{
														goto IL_61B;
													}
													this.SVccLxaHEOS = i + 20;
													if (218621 - 209275 != 9346)
													{
														goto IL_61B;
													}
												}
												this.JbdcwI0apKC[i].state = eIconButtonState.none;
												if (78799 - 328331 != -249532)
												{
													goto IL_61B;
												}
											}
											else if (eIconButtonState2 == eIconButtonState.drop)
											{
												if (33630 - 410051 != -376421)
												{
													goto IL_61B;
												}
												if (this.g7VcLWDqu9H == -1)
												{
													if (105358 - 493812 != -388454)
													{
														goto IL_61B;
													}
													if (this.SVccLxaHEOS >= 20)
													{
														if (363 - 241672 != -241309)
														{
															goto IL_61B;
														}
														if (this.SVccLxaHEOS < 50)
														{
															if (69052 - 154445 == -85392)
															{
																goto IL_61B;
															}
															CharacterData.current.swapInventory(i, this.SVccLxaHEOS - 20);
															if (118101 - 133015 != -14914)
															{
																goto IL_61B;
															}
															this.ResetPetShopInventory();
															if (18050 - 203970 == -185919)
															{
																goto IL_61B;
															}
															this.audio.PlayOneShot(this.WgocLbNfyn3);
															if (144384 - 179814 == -35429)
															{
																goto IL_61B;
															}
														}
													}
												}
												this.SVccLxaHEOS = 0;
												if (53757 - 599237 == -545479)
												{
													goto IL_61B;
												}
											}
											else
											{
												GUI.DrawTexture(position, this.JbdcwI0apKC[i].image);
												if (288414 - 92975 == 195440)
												{
													goto IL_61B;
												}
											}
										}
										else
										{
											GUI.DrawTexture(position, this.JbdcwI0apKC[i].image);
											if (59375 - 105106 != -45731)
											{
												goto IL_61B;
											}
											GUI.DrawTexture(new Rect(position.x + (float)7, position.y + (float)7, (float)51, (float)51), this.UipcwJMgJoL);
											if (127166 - 22731 == 104436)
											{
												goto IL_61B;
											}
										}
										if (CharacterData.current.inventory[i].num > 1)
										{
											if (286328 - 317572 != -31244)
											{
												goto IL_61B;
											}
											GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.MOgcwtTpHtv);
											if (7431 - 208067 == -200635)
											{
												goto IL_61B;
											}
											GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.D1Bcw2TLO0I);
											if (217426 - 11754 == 205673)
											{
												goto IL_61B;
											}
										}
										else
										{
											string type = CharacterData.current.inventory[i].getType();
											if (178438 - 253897 == -75458)
											{
												goto IL_61B;
											}
											if (!(type == "w"))
											{
												if (135281 - 470155 == -334873)
												{
													goto IL_61B;
												}
												if (!(type == "a"))
												{
													if (123229 - 374378 == -251148)
													{
														goto IL_61B;
													}
													if (!(type == "c"))
													{
														if (266400 - 422919 != -156519)
														{
															goto IL_61B;
														}
														if (!(type == "b"))
														{
															if (13988 - 170748 != -156760)
															{
																goto IL_61B;
															}
															if (!(type == "t"))
															{
																if (109759 - 97431 == 12329)
																{
																	goto IL_61B;
																}
																if (!(type == "p"))
																{
																	goto IL_161;
																}
																if (108466 - 175663 != -67197)
																{
																	goto IL_61B;
																}
															}
														}
													}
												}
											}
											if (CharacterData.current.inventory[i].owner == 0)
											{
												if (50182 - 1801 != 48381)
												{
													goto IL_61B;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.k1JcwX7POps);
												if (186721 - 89667 != 97054)
												{
													goto IL_61B;
												}
											}
											else if (CharacterData.current.inventory[i].owner != CharacterData.current.CID)
											{
												if (72864 - 39871 == 32994)
												{
													goto IL_61B;
												}
												GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.dLGcwOYqxw1);
												if (67198 - 256105 == -188906)
												{
													goto IL_61B;
												}
											}
										}
									}
									IL_161:
									i++;
									if (49394 - 410680 == -361285)
									{
										goto IL_61B;
									}
								}
								if (215181 - 408188 == -193007)
								{
									if (this.SVccLxaHEOS != 0)
									{
										break;
									}
									if (268123 - 399953 == -131830)
									{
										if (text != "none")
										{
											if (208132 - 130579 != 77554)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.VdUcwlsw5y2);
												if (147672 - 49121 == 98551)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.RKscwv8Hosh);
													if (193171 - 465498 == -272327)
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
											if (286175 - 542387 != -256211)
											{
												InventoryClass nHoverItem = CharacterData.current.inventory[num - 20];
												if (239259 - 391040 == -151781)
												{
													Guix.renderItemToolTip((int)vector.x, (int)vector.y, nHoverItem, nHoverImage);
													if (289604 - 255276 != 34329)
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

	// Token: 0x06006281 RID: 25217 RVA: 0x00DA5864 File Offset: 0x00DA3A64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitPetShopNotice()
	{
		if (78503 - 131206 != -52702)
		{
		}
		for (;;)
		{
			this.auQcwG9oHaC = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (40125 - 327413 == -287288)
			{
				this.E6scw1xX2qZ = new GUIStyle();
				if (40266 - 554360 != -514093)
				{
					this.E6scw1xX2qZ.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (213402 - 279430 == -66028)
					{
						this.E6scw1xX2qZ.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (89838 - 109760 == -19922)
						{
							this.E6scw1xX2qZ.alignment = TextAnchor.MiddleCenter;
							if (187487 - 371845 == -184358)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006282 RID: 25218 RVA: 0x00DA59A0 File Offset: 0x00DA3BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newNoticeBar(string s, float t)
	{
		this.OhDcwphaXJ8 = s;
		this.YbAcwqwM87V = Time.time + t;
	}

	// Token: 0x06006283 RID: 25219 RVA: 0x00DA59B8 File Offset: 0x00DA3BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar()
	{
		if (45645 - 126399 != -80754)
		{
		}
		while (this.YbAcwqwM87V > Time.time)
		{
			if (110011 - 527846 == -417835)
			{
				GUI.DrawTexture(new Rect((float)360, (float)480, (float)475, (float)102), this.auQcwG9oHaC);
				if (168391 - 489124 == -320733)
				{
					GUI.Label(new Rect((float)395, (float)510, (float)400, (float)40), this.OhDcwphaXJ8, this.E6scw1xX2qZ);
					if (105006 - 209108 == -104102)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006284 RID: 25220 RVA: 0x00DA5AA0 File Offset: 0x00DA3CA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (219322 - 425549 != -206226)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (93733 - 470875 != -377141)
				{
					break;
				}
			}
			else
			{
				if (this.SVccLxaHEOS == 0)
				{
					break;
				}
				if (69337 - 352576 == -283239)
				{
					if (Input.GetMouseButton(1))
					{
						if (233507 - 388351 != -154843)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (273109 - 144098 != 129012)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (97469 - 503245 != -405775)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.SVccLxaHEOS));
									if (259041 - 548572 != -289530)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.SVccLxaHEOS = 0;
						if (202224 - 44100 == 158124)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006285 RID: 25221 RVA: 0x00DA5C28 File Offset: 0x00DA3E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006286 RID: 25222 RVA: 0x00DA5C2C File Offset: 0x00DA3E2C
	internal static bool OZEjeMpQinRNUR5QS2YM()
	{
		return true;
	}

	// Token: 0x06006287 RID: 25223 RVA: 0x00DA5C30 File Offset: 0x00DA3E30
	internal static bool fjdUW3pQKa5O46ItJ3sW()
	{
		return false;
	}

	// Token: 0x04007135 RID: 28981
	public ePetShopState mState;

	// Token: 0x04007136 RID: 28982
	private float NJncLlRA1gJ;

	// Token: 0x04007137 RID: 28983
	private float MqFcLGwW7du;

	// Token: 0x04007138 RID: 28984
	private float UiPcL1SgKX7;

	// Token: 0x04007139 RID: 28985
	private float aB8cLqk7QmI;

	// Token: 0x0400713A RID: 28986
	private ePetShopTab AMmcLpO0yFd;

	// Token: 0x0400713B RID: 28987
	private int cP8cLRlb51u;

	// Token: 0x0400713C RID: 28988
	private int lS0cLrxNKxn;

	// Token: 0x0400713D RID: 28989
	private int SVccLxaHEOS;

	// Token: 0x0400713E RID: 28990
	private GUIStyle keccLT7Dkcw;

	// Token: 0x0400713F RID: 28991
	private AudioClip foHcLYC3JRw;

	// Token: 0x04007140 RID: 28992
	private AudioClip MYqcL3yskMo;

	// Token: 0x04007141 RID: 28993
	private AudioClip WgocLbNfyn3;

	// Token: 0x04007142 RID: 28994
	private AudioClip hGmcLd8RAfl;

	// Token: 0x04007143 RID: 28995
	private Texture rP5cLgu5lbn;

	// Token: 0x04007144 RID: 28996
	private Texture RqQcLaZuN8G;

	// Token: 0x04007145 RID: 28997
	private GUIStyle TgicL4IQO68;

	// Token: 0x04007146 RID: 28998
	private GUIStyle zqBcLsuEmPi;

	// Token: 0x04007147 RID: 28999
	private string DmWcLHGphUo;

	// Token: 0x04007148 RID: 29000
	private string csycL7BHOdV;

	// Token: 0x04007149 RID: 29001
	private Texture M4IcLZAVfTZ;

	// Token: 0x0400714A RID: 29002
	private Texture eq2cLCGa6TF;

	// Token: 0x0400714B RID: 29003
	private GUIStyle rmjcLMiLwID;

	// Token: 0x0400714C RID: 29004
	private GUIStyle TkHcLfqeE4n;

	// Token: 0x0400714D RID: 29005
	private GUIStyle AZHcLLKoIOy;

	// Token: 0x0400714E RID: 29006
	private GUIStyle rFqcLwkjGyP;

	// Token: 0x0400714F RID: 29007
	private GUIStyle WktcLUIQVAh;

	// Token: 0x04007150 RID: 29008
	private GUIStyle xERcLNGBNnj;

	// Token: 0x04007151 RID: 29009
	private GUIStyle MAjcLEQjTay;

	// Token: 0x04007152 RID: 29010
	private GUIStyle Ei6cLPOjCHC;

	// Token: 0x04007153 RID: 29011
	private GUIStyle wkvcLSaVlrS;

	// Token: 0x04007154 RID: 29012
	private GUIStyle BPfcLB6C0FG;

	// Token: 0x04007155 RID: 29013
	private GUIStyle WYGcL0numVv;

	// Token: 0x04007156 RID: 29014
	private Texture vIrcL8irOZX;

	// Token: 0x04007157 RID: 29015
	private Texture BuNcLit0ylk;

	// Token: 0x04007158 RID: 29016
	private Texture kuycLDA45Rm;

	// Token: 0x04007159 RID: 29017
	private GUIStyle N4OcLmUGgbU;

	// Token: 0x0400715A RID: 29018
	private GUIStyle Pg8cLjb99rW;

	// Token: 0x0400715B RID: 29019
	private GUIStyle orHcLoZOC7X;

	// Token: 0x0400715C RID: 29020
	private GUIStyle VfJcLkaprjS;

	// Token: 0x0400715D RID: 29021
	private CollectorClass[] fL8cLFPW1s0;

	// Token: 0x0400715E RID: 29022
	private HoverButtonClass[] eH5cLAoZ5oF;

	// Token: 0x0400715F RID: 29023
	private float uJ0cL9IEx4S;

	// Token: 0x04007160 RID: 29024
	private int g7VcLWDqu9H;

	// Token: 0x04007161 RID: 29025
	private ItemClass NlIcLuXobWj;

	// Token: 0x04007162 RID: 29026
	private IconButtonClass wOucLytDbLR;

	// Token: 0x04007163 RID: 29027
	private HoverButtonClass[] iTwcLVZAbxT;

	// Token: 0x04007164 RID: 29028
	private string[] deVcLhVp6jV;

	// Token: 0x04007165 RID: 29029
	private int[] YwOcLKphSSR;

	// Token: 0x04007166 RID: 29030
	private Texture[] HZKcLzYLyH9;

	// Token: 0x04007167 RID: 29031
	private bool[] NCDcw5MRBk9;

	// Token: 0x04007168 RID: 29032
	private bool G1gcwcaBs0L;

	// Token: 0x04007169 RID: 29033
	private ItemClass LXjcwnoBVJI;

	// Token: 0x0400716A RID: 29034
	private Texture d2bcwQPWU44;

	// Token: 0x0400716B RID: 29035
	private string f8Ncwev6rNE;

	// Token: 0x0400716C RID: 29036
	private IconButtonClass[] JbdcwI0apKC;

	// Token: 0x0400716D RID: 29037
	private Texture UipcwJMgJoL;

	// Token: 0x0400716E RID: 29038
	private Texture fMNcw6ARiRa;

	// Token: 0x0400716F RID: 29039
	private Texture MOgcwtTpHtv;

	// Token: 0x04007170 RID: 29040
	private Texture k1JcwX7POps;

	// Token: 0x04007171 RID: 29041
	private Texture dLGcwOYqxw1;

	// Token: 0x04007172 RID: 29042
	private GUIStyle D1Bcw2TLO0I;

	// Token: 0x04007173 RID: 29043
	private GUIStyle RKscwv8Hosh;

	// Token: 0x04007174 RID: 29044
	private GUIStyle VdUcwlsw5y2;

	// Token: 0x04007175 RID: 29045
	private Texture auQcwG9oHaC;

	// Token: 0x04007176 RID: 29046
	private GUIStyle E6scw1xX2qZ;

	// Token: 0x04007177 RID: 29047
	private float YbAcwqwM87V;

	// Token: 0x04007178 RID: 29048
	private string OhDcwphaXJ8;
}
