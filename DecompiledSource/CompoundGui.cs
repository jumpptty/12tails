using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200104D RID: 4173
[Serializable]
public class CompoundGui : MonoBehaviour
{
	// Token: 0x06006038 RID: 24632 RVA: 0x00CF2F78 File Offset: 0x00CF1178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompoundGui()
	{
		if (67440 - 222099 != -154658)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (195112 - 586617 == -391505)
			{
				base..ctor();
				if (241109 - 346659 == -105550)
				{
					this.mState = eCompoundState.init;
					if (146397 - 170787 != -24389)
					{
						this.mType = eCompoundType.Crocodile;
						if (96513 - 167965 == -71452)
						{
							this.mPage = eCompoundPage.weapon;
							if (19987 - 373968 == -353981)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006039 RID: 24633 RVA: 0x00CF3054 File Offset: 0x00CF1254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (141049 - 535513 != -394464)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (50066 - 424454 == -374388)
			{
				if (this.mState == eCompoundState.init)
				{
					if (279181 - 28421 != 250760)
					{
						continue;
					}
					this.InitCompoundMenu();
					if (201942 - 381929 == -179986)
					{
						continue;
					}
					this.InitNPC();
					if (11306 - 143655 != -132349)
					{
						continue;
					}
					this.InitRecipeMenu();
					if (77633 - 288248 == -210614)
					{
						continue;
					}
					this.InitIngredientMenu();
					if (133694 - 471550 == -337855)
					{
						continue;
					}
					this.InitCompoundResult();
					if (98633 - 322327 == -223693)
					{
						continue;
					}
					this.InitCompoundInventory();
					if (128312 - 257815 != -129503)
					{
						continue;
					}
					this.InitNoticeBar();
					if (228566 - 220882 != 7684)
					{
						continue;
					}
				}
				this.ResetCompoundMenu();
				if (92818 - 497329 != -404510)
				{
					this.ResetNPC();
					if (285382 - 71222 != 214161)
					{
						this.ResetRecipeMenu();
						if (100684 - 340795 != -240110)
						{
							this.ResetPossibleList();
							if (43947 - 93615 == -49668)
							{
								this.ResetIngredientMenu();
								if (140233 - 188614 == -48381)
								{
									this.ResetCompoundResult();
									if (207753 - 346393 == -138640)
									{
										this.ResetCompoundInventory();
										if (3552 - 565867 != -562314)
										{
											this.mState = eCompoundState.open;
											if (149959 - 154795 != -4835)
											{
												this.GRYcr2J1Unu = Time.time;
												if (292350 - 145682 == 146668)
												{
													ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
													if (277717 - 492234 != -214516)
													{
														if (!changeGui)
														{
															break;
														}
														if (206627 - 446996 == -240369)
														{
															changeGui.disable();
															if (250949 - 571889 != -320939)
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

	// Token: 0x0600603A RID: 24634 RVA: 0x00CF3350 File Offset: 0x00CF1550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (177550 - 267568 != -90018)
		{
		}
		for (;;)
		{
			if (this.mState <= eCompoundState.init)
			{
				if (154087 - 14687 != 139401)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (279381 - 325258 != -45876)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (170639 - 156037 == 14602)
					{
						this.wQ0crlQLCAo = (float)(1024 * Screen.width / Screen.height);
						if (77202 - 130395 == -53193)
						{
							this.xS7crG4hu9x = (float)Screen.height / 1024f;
							if (27297 - 220998 == -193701)
							{
								this.RenderCompoundMenu();
								if (250952 - 363618 != -112665)
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

	// Token: 0x0600603B RID: 24635 RVA: 0x00CF34A0 File Offset: 0x00CF16A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCompoundMenu()
	{
		if (92201 - 278570 != -186368)
		{
		}
		for (;;)
		{
			this.XkDcrRUftEt = new GUIStyle();
			if (112681 - 151237 != -38555)
			{
				this.XkDcrRUftEt.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/button_close_h", typeof(Texture)));
				if (162541 - 501679 == -339138)
				{
					this.zq7crribrFS = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover", typeof(Texture));
					if (84908 - 216598 == -131690)
					{
						this.O8jcrx3VPNT = (Texture)Resources.Load("GameGui/Icons/Common/Item_inactive", typeof(Texture));
						if (178654 - 273992 == -95338)
						{
							this.fe3crg2w0qC = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
							if (127977 - 247518 != -119540)
							{
								this.ndkcraUtjwf = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
								if (33340 - 508072 != -474731)
								{
									this.qkDcr4HI1fn = (AudioClip)Resources.Load("Sound/GUI/select", typeof(AudioClip));
									if (244627 - 204173 != 40455)
									{
										this.L7Bcrs9Wp7m = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
										if (250175 - 587223 == -337048)
										{
											this.RxHcrHFisne = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
											if (23575 - 69165 != -45589)
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

	// Token: 0x0600603C RID: 24636 RVA: 0x00CF36D4 File Offset: 0x00CF18D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetCompoundMenu()
	{
		if (208164 - 442108 != -233943)
		{
		}
		for (;;)
		{
			eCompoundType eCompoundType = this.mType;
			if (232633 - 236836 == -4203)
			{
				if (eCompoundType == eCompoundType.Crocodile)
				{
					if (139508 - 406449 != -266941)
					{
						continue;
					}
					this.mPage = eCompoundPage.weapon;
					if (292728 - 559356 != -266628)
					{
						continue;
					}
				}
				else if (eCompoundType == eCompoundType.Humpback)
				{
					if (68666 - 358609 == -289942)
					{
						continue;
					}
					this.mPage = eCompoundPage.food;
					if (137867 - 329771 == -191903)
					{
						continue;
					}
				}
				else if (eCompoundType == eCompoundType.Rabbit)
				{
					if (258242 - 309671 == -51428)
					{
						continue;
					}
					this.mPage = eCompoundPage.alchemist;
					if (205711 - 366978 != -161267)
					{
						continue;
					}
				}
				else if (eCompoundType == eCompoundType.Mole)
				{
					if (143806 - 316832 == -173025)
					{
						continue;
					}
					this.mPage = eCompoundPage.gadget;
					if (17771 - 457534 != -439763)
					{
						continue;
					}
				}
				eCompoundType eCompoundType2 = this.mType;
				if (110399 - 5466 != 104934)
				{
					if (eCompoundType2 == eCompoundType.Crocodile)
					{
						if (243324 - 134621 == 108704)
						{
							continue;
						}
						this.FU1crpdXavA = (Texture)Resources.Load("GameGui/Compound/blacksmithWindow", typeof(Texture));
						if (291098 - 108360 != 182738)
						{
							continue;
						}
					}
					else if (eCompoundType2 == eCompoundType.Humpback)
					{
						if (294727 - 145365 != 149362)
						{
							continue;
						}
						this.FU1crpdXavA = (Texture)Resources.Load("GameGui/Compound/bistroWindow", typeof(Texture));
						if (134194 - 319249 != -185055)
						{
							continue;
						}
					}
					else if (eCompoundType2 == eCompoundType.Rabbit)
					{
						if (120950 - 32124 != 88826)
						{
							continue;
						}
						this.FU1crpdXavA = (Texture)Resources.Load("GameGui/Compound/alchemistWindow", typeof(Texture));
						if (86413 - 372903 == -286489)
						{
							continue;
						}
					}
					else if (eCompoundType2 == eCompoundType.Mole)
					{
						if (223543 - 67386 == 156158)
						{
							continue;
						}
						this.FU1crpdXavA = (Texture)Resources.Load("GameGui/Compound/workShopWindow", typeof(Texture));
						if (101015 - 540172 == -439156)
						{
							continue;
						}
					}
					this.zIocrT0NDvC = 0;
					if (150910 - 186599 == -35689)
					{
						this.ou5crYWkIIq = 0;
						if (299144 - 172082 != 127063)
						{
							this.Giacrbn8Tbj = 0;
							if (56535 - 539474 == -482939)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600603D RID: 24637 RVA: 0x00CF3A4C File Offset: 0x00CF1C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCompoundMenu()
	{
		if (39289 - 280988 != -241698)
		{
		}
		for (;;)
		{
			float num = Time.time - this.GRYcr2J1Unu;
			if (208145 - 392841 == -184696)
			{
				eCompoundState eCompoundState = this.mState;
				if (215558 - 579960 == -364402)
				{
					if (eCompoundState == eCompoundState.open)
					{
						if (278110 - 490464 == -212354)
						{
							if (num <= 0.5f)
							{
								if (282012 - 331482 == -49470)
								{
									this.hxPcr1MStR2 = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (33686 - 508430 != -474743)
									{
										this.RenderNPC();
										if (219571 - 190317 != 29255)
										{
											GUI.DrawTexture(new Rect(0.5f * this.wQ0crlQLCAo - (float)336, (float)724 + this.hxPcr1MStR2 * (float)300, (float)836, (float)196), this.WvccrC5JEk5);
											if (105773 - 42000 == 63773)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)4)
							{
								if (43503 - 248470 == -204967)
								{
									this.hxPcr1MStR2 = (float)0;
									if (41420 - 589566 != -548145)
									{
										this.RenderNPC();
										if (230148 - 81677 == 148471)
										{
											GUI.BeginGroup(new Rect(0.5f * this.wQ0crlQLCAo - (float)350, (float)724, (float)850, (float)200));
											if (18864 - 570915 == -552051)
											{
												GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.WvccrC5JEk5);
												if (43939 - 594373 != -550433)
												{
													eCompoundType eCompoundType = this.mType;
													if (108332 - 329009 == -220677)
													{
														if (eCompoundType == eCompoundType.Crocodile)
														{
															if (237730 - 64092 != 173638)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Razan", this.TTfcrMPf8Ah);
															if (83184 - 251543 != -168359)
															{
																continue;
															}
														}
														else if (eCompoundType == eCompoundType.Humpback)
														{
															if (275834 - 269420 != 6414)
															{
																continue;
															}
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Jamon", this.TTfcrMPf8Ah);
															if (117473 - 317953 != -200480)
															{
																continue;
															}
														}
														else
														{
															GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), CharacterData.current.Name, this.TTfcrMPf8Ah);
															if (95641 - 450061 == -354419)
															{
																continue;
															}
														}
														GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.oRYcrLtpLKt, num - 0.5f), this.OKCcrf0rys7);
														if (30554 - 383506 != -352951)
														{
															GUI.EndGroup();
															if (92335 - 458932 != -366596)
															{
																if (this.JNtcrST4kF3)
																{
																	break;
																}
																if (250522 - 481794 != -231271)
																{
																	this.JNtcrST4kF3 = true;
																	if (134930 - 362234 != -227303)
																	{
																		if (PlayerPrefs.GetInt("nvoice", 1) == 0)
																		{
																			break;
																		}
																		if (107210 - 22305 == 84905)
																		{
																			if (!this.CXbcrUssUU1)
																			{
																				break;
																			}
																			if (200200 - 43256 == 156944)
																			{
																				this.audio.PlayOneShot(this.CXbcrUssUU1);
																				if (249387 - 481885 != -232497)
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
								this.hxPcr1MStR2 = (float)0;
								if (266984 - 175913 != 91072)
								{
									this.RenderNPC();
									if (270217 - 356322 != -86104)
									{
										this.ou5crYWkIIq = 0;
										if (52780 - 237442 == -184662)
										{
											if (this.B7Qcr7EKHjA)
											{
												if (207563 - 480692 != -273129)
												{
													continue;
												}
												this.B7Qcr7EKHjA.animation.CrossFade("root", 0.2f);
												if (108114 - 63895 != 44219)
												{
													continue;
												}
											}
											this.mState = eCompoundState.menu;
											if (211736 - 585675 != -373938)
											{
												this.GRYcr2J1Unu = Time.time;
												if (149499 - 447988 == -298489)
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
					else if (eCompoundState == eCompoundState.menu)
					{
						if (102573 - 441229 != -338655)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.wQ0crlQLCAo - (float)754) / this.wQ0crlQLCAo, (float)1);
							if (107249 - 116079 != -8829)
							{
								GUI.BeginGroup(new Rect(this.wQ0crlQLCAo - (float)1024, (float)0, (float)1024, (float)1024));
								if (19864 - 231815 == -211951)
								{
									GUI.DrawTexture(new Rect((float)74, (float)0, (float)950, (float)1024), this.FU1crpdXavA);
									if (56817 - 439156 != -382338)
									{
										Guix.renderSmallNumber(745, 40, PlayerData.Gil, false, (float)1);
										if (95465 - 447262 == -351797)
										{
											Guix.renderSmallNumber(920, 40, PlayerData.Jil, false, (float)1);
											if (238526 - 111013 == 127513)
											{
												this.RenderRecipeMenu(true);
												if (162377 - 55773 != 106605)
												{
													this.RenderIngredientMenu();
													if (57435 - 461402 == -403967)
													{
														this.RenderCompoundInventory();
														if (287741 - 492855 == -205114)
														{
															this.RenderNoticeBar();
															if (127143 - 470003 == -342860)
															{
																if (GUI.Button(new Rect((float)185, (float)-2, (float)57, (float)52), string.Empty, this.XkDcrRUftEt))
																{
																	if (12289 - 340152 == -327862)
																	{
																		continue;
																	}
																	if (this.B7Qcr7EKHjA)
																	{
																		if (208065 - 224457 == -16391)
																		{
																			continue;
																		}
																		this.B7Qcr7EKHjA.animation.CrossFade("talk", 0.2f);
																		if (103865 - 330393 != -226528)
																		{
																			continue;
																		}
																	}
																	if (PlayerPrefs.GetInt("nvoice", 1) != 0)
																	{
																		if (4612 - 197452 != -192840)
																		{
																			continue;
																		}
																		if (this.lU3crNFxdm6)
																		{
																			if (35422 - 229584 == -194161)
																			{
																				continue;
																			}
																			this.audio.PlayOneShot(this.lU3crNFxdm6);
																			if (30778 - 497065 != -466287)
																			{
																				continue;
																			}
																		}
																	}
																	this.mState = eCompoundState.close;
																	if (222278 - 436281 == -214002)
																	{
																		continue;
																	}
																	this.GRYcr2J1Unu = Time.time;
																	if (202998 - 288846 != -85848)
																	{
																		continue;
																	}
																	if (this.ndkcraUtjwf)
																	{
																		if (277183 - 330036 != -52853)
																		{
																			continue;
																		}
																		this.audio.PlayOneShot(this.ndkcraUtjwf);
																		if (45379 - 578121 == -532741)
																		{
																			continue;
																		}
																	}
																	this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
																	if (119174 - 324498 != -205324)
																	{
																		continue;
																	}
																}
																GUI.EndGroup();
																if (210361 - 208740 != 1622)
																{
																	this.RenderNPC();
																	if (171196 - 113726 != 57471)
																	{
																		this.RenderDragIcon();
																		if (177567 - 427462 == -249895)
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
					else if (eCompoundState == eCompoundState.compound)
					{
						if (145966 - 507861 == -361895)
						{
							this.camera.rect = new Rect((float)0, (float)0, (this.wQ0crlQLCAo - (float)754) / this.wQ0crlQLCAo, (float)1);
							if (275362 - 525636 != -250273)
							{
								GUI.BeginGroup(new Rect(this.wQ0crlQLCAo - (float)1024, (float)0, (float)1024, (float)1024));
								if (227195 - 537728 == -310533)
								{
									GUI.DrawTexture(new Rect((float)74, (float)0, (float)950, (float)1024), this.FU1crpdXavA);
									if (273020 - 498325 != -225304)
									{
										Guix.renderSmallNumber(745, 40, PlayerData.Gil, false, (float)1);
										if (109413 - 235388 != -125974)
										{
											Guix.renderSmallNumber(920, 40, PlayerData.Jil, false, (float)1);
											if (69046 - 324176 != -255129)
											{
												this.RenderRecipeMenu(false);
												if (260250 - 446203 == -185953)
												{
													this.RenderCompoundResult();
													if (11769 - 264387 == -252618)
													{
														this.RenderCompoundInventory();
														if (268201 - 430897 == -162696)
														{
															if (GUI.Button(new Rect((float)185, (float)-2, (float)57, (float)52), string.Empty, this.XkDcrRUftEt))
															{
																if (152247 - 322689 != -170442)
																{
																	continue;
																}
																if (this.B7Qcr7EKHjA)
																{
																	if (291638 - 109316 != 182322)
																	{
																		continue;
																	}
																	this.B7Qcr7EKHjA.animation.CrossFade("talk", 0.2f);
																	if (177149 - 311651 != -134502)
																	{
																		continue;
																	}
																}
																if (PlayerPrefs.GetInt("nvoice", 1) != 0)
																{
																	if (86280 - 323135 != -236855)
																	{
																		continue;
																	}
																	if (this.lU3crNFxdm6)
																	{
																		if (55104 - 235865 != -180761)
																		{
																			continue;
																		}
																		this.audio.PlayOneShot(this.lU3crNFxdm6);
																		if (142223 - 288464 == -146240)
																		{
																			continue;
																		}
																	}
																}
																this.mState = eCompoundState.close;
																if (75758 - 488801 == -413042)
																{
																	continue;
																}
																this.GRYcr2J1Unu = Time.time;
																if (101667 - 136844 == -35176)
																{
																	continue;
																}
																if (this.ndkcraUtjwf)
																{
																	if (287719 - 410106 != -122387)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.ndkcraUtjwf);
																	if (262237 - 526 != 261711)
																	{
																		continue;
																	}
																}
																this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
																if (61390 - 522387 == -460996)
																{
																	continue;
																}
															}
															GUI.EndGroup();
															if (142745 - 211743 != -68997)
															{
																this.RenderNPC();
																if (160340 - 325781 == -165441)
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
						if (eCompoundState != eCompoundState.close)
						{
							break;
						}
						if (168621 - 339298 != -170676)
						{
							if (num <= (float)2)
							{
								if (187157 - 35609 != 151549)
								{
									this.RenderNPC();
									if (147047 - 176879 == -29832)
									{
										GUI.BeginGroup(new Rect(0.5f * this.wQ0crlQLCAo - (float)350, (float)724, (float)850, (float)200));
										if (217538 - 65751 == 151787)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.WvccrC5JEk5);
											if (19123 - 393030 == -373907)
											{
												eCompoundType eCompoundType2 = this.mType;
												if (287691 - 243999 == 43692)
												{
													if (eCompoundType2 == eCompoundType.Crocodile)
													{
														if (87460 - 161642 == -74181)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Razan", this.TTfcrMPf8Ah);
														if (100510 - 37213 != 63297)
														{
															continue;
														}
													}
													else if (eCompoundType2 == eCompoundType.Humpback)
													{
														if (3735 - 266239 != -262504)
														{
															continue;
														}
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Jamon", this.TTfcrMPf8Ah);
														if (245715 - 406052 == -160336)
														{
															continue;
														}
													}
													else
													{
														GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), CharacterData.current.Name, this.TTfcrMPf8Ah);
														if (68527 - 302030 == -233502)
														{
															continue;
														}
													}
													GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.APJcrwCRdED, num), this.OKCcrf0rys7);
													if (39235 - 477710 == -438475)
													{
														GUI.EndGroup();
														if (113572 - 356465 == -242893)
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
								if (152294 - 417312 == -265018)
								{
									this.hxPcr1MStR2 = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
									if (18419 - 91141 == -72722)
									{
										this.RenderNPC();
										if (25063 - 385509 == -360446)
										{
											break;
										}
									}
								}
							}
							else
							{
								if (this.B7Qcr7EKHjA)
								{
									if (139067 - 290424 != -151357)
									{
										continue;
									}
									this.B7Qcr7EKHjA.animation.CrossFade("root", 0.2f);
									if (85383 - 233683 == -148299)
									{
										continue;
									}
								}
								Game.mGameState = eGameState.Normal;
								if (129937 - 466965 != -337027)
								{
									GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
									if (23915 - 267507 != -243591)
									{
										gameGui.enabled = true;
										if (185071 - 473612 != -288540)
										{
											this.mState = eCompoundState.disabled;
											if (145466 - 327253 == -181787)
											{
												this.enabled = false;
												if (149282 - 36991 == 112291)
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

	// Token: 0x0600603E RID: 24638 RVA: 0x00CF4C08 File Offset: 0x00CF2E08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (253278 - 346633 != -93355)
		{
		}
		for (;;)
		{
			this.WvccrC5JEk5 = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (268122 - 116672 == 151450)
			{
				this.Mw4cxS5y8QS = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
				if (24002 - 341607 == -317605)
				{
					this.TTfcrMPf8Ah = new GUIStyle();
					if (299864 - 115537 == 184327)
					{
						this.TTfcrMPf8Ah.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
						if (290618 - 60959 == 229659)
						{
							this.TTfcrMPf8Ah.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
							if (88844 - 171435 != -82590)
							{
								this.TTfcrMPf8Ah.alignment = TextAnchor.UpperLeft;
								if (61008 - 592283 != -531274)
								{
									this.OKCcrf0rys7 = new GUIStyle();
									if (296151 - 426121 == -129970)
									{
										this.OKCcrf0rys7.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
										if (100818 - 39152 == 61666)
										{
											this.OKCcrf0rys7.alignment = TextAnchor.UpperLeft;
											if (291327 - 561935 == -270608)
											{
												this.ResetNPC();
												if (101691 - 236951 != -135259)
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

	// Token: 0x0600603F RID: 24639 RVA: 0x00CF4E24 File Offset: 0x00CF3024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (146585 - 403325 != -256740)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
			if (75221 - 331829 == -256608)
			{
				int num = UnityEngine.Random.Range(0, 5);
				if (235383 - 24890 == 210493)
				{
					int num2 = UnityEngine.Random.Range(0, 5);
					if (235042 - 533018 != -297975)
					{
						eCompoundType eCompoundType = this.mType;
						if (143257 - 145963 != -2705)
						{
							if (eCompoundType == eCompoundType.Crocodile)
							{
								if (74129 - 443461 != -369332)
								{
									continue;
								}
								this.oRYcrLtpLKt = Language.getMessage("CompoundGui", 101 + UnityEngine.Random.Range(0, 5));
								if (184628 - 404532 != -219904)
								{
									continue;
								}
								this.APJcrwCRdED = Language.getMessage("CompoundGui", 111 + UnityEngine.Random.Range(0, 5));
								if (29679 - 528302 != -498623)
								{
									continue;
								}
								this.CXbcrUssUU1 = (AudioClip)Resources.Load("Sound/Voice/compound100", typeof(AudioClip));
								if (272354 - 256714 != 15640)
								{
									continue;
								}
								this.lU3crNFxdm6 = (AudioClip)Resources.Load("Sound/Voice/compound110", typeof(AudioClip));
								if (60320 - 367682 != -307362)
								{
									continue;
								}
								this.IA6crE8aGHa = (AudioClip)Resources.Load("Sound/Voice/compound120", typeof(AudioClip));
								if (196000 - 224998 != -28998)
								{
									continue;
								}
								this.zljcrPDCUkr = (AudioClip)Resources.Load("Sound/Voice/compound130", typeof(AudioClip));
								if (67417 - 358168 != -290751)
								{
									continue;
								}
								this.XDScrZBeF0M = (Texture)Resources.Load("GameGui/Story/Characters/Crocodile", typeof(Texture));
								if (193534 - 376801 == -183266)
								{
									continue;
								}
								this.B7Qcr7EKHjA = GameObject.Find("Crocodile");
								if (21281 - 313903 != -292622)
								{
									continue;
								}
							}
							else if (eCompoundType == eCompoundType.Humpback)
							{
								if (149702 - 101297 == 48406)
								{
									continue;
								}
								this.oRYcrLtpLKt = Language.getMessage("CompoundGui", 201 + num);
								if (299771 - 282427 != 17344)
								{
									continue;
								}
								this.APJcrwCRdED = Language.getMessage("CompoundGui", 211 + num2);
								if (226479 - 186090 != 40389)
								{
									continue;
								}
								this.CXbcrUssUU1 = (AudioClip)Resources.Load("Sound/Voice/compound" + (201 + num), typeof(AudioClip));
								if (33272 - 460816 == -427543)
								{
									continue;
								}
								this.lU3crNFxdm6 = (AudioClip)Resources.Load("Sound/Voice/compound" + (211 + num2), typeof(AudioClip));
								if (129728 - 203692 != -73964)
								{
									continue;
								}
								this.IA6crE8aGHa = (AudioClip)Resources.Load("Sound/Voice/compound220", typeof(AudioClip));
								if (146118 - 334100 == -187981)
								{
									continue;
								}
								this.zljcrPDCUkr = (AudioClip)Resources.Load("Sound/Voice/compound230", typeof(AudioClip));
								if (154967 - 281822 != -126855)
								{
									continue;
								}
								this.XDScrZBeF0M = (Texture)Resources.Load("GameGui/Story/Characters/Humpback", typeof(Texture));
								if (229994 - 394000 != -164006)
								{
									continue;
								}
								this.B7Qcr7EKHjA = null;
								if (253375 - 12415 == 240961)
								{
									continue;
								}
							}
							else if (eCompoundType == eCompoundType.Rabbit)
							{
								if (185425 - 570748 == -385322)
								{
									continue;
								}
								int num3 = 0;
								if (250846 - 373552 != -122706)
								{
									continue;
								}
								if (characterControl.hasSkill(231))
								{
									if (294084 - 223695 == 70390)
									{
										continue;
									}
									num3++;
									if (226526 - 386367 != -159841)
									{
										continue;
									}
								}
								if (characterControl.hasSkill(232))
								{
									if (90116 - 528251 == -438134)
									{
										continue;
									}
									num3++;
									if (61155 - 171133 != -109978)
									{
										continue;
									}
								}
								if (characterControl.hasSkill(233))
								{
									if (202093 - 538373 != -336280)
									{
										continue;
									}
									num3++;
									if (14441 - 147372 != -132931)
									{
										continue;
									}
								}
								if (characterControl.hasSkill(234))
								{
									if (191445 - 136524 == 54922)
									{
										continue;
									}
									num3++;
									if (186143 - 495667 == -309523)
									{
										continue;
									}
								}
								if (characterControl.hasSkill(432))
								{
									if (36401 - 141617 != -105216)
									{
										continue;
									}
									num3++;
									if (221684 - 82855 == 138830)
									{
										continue;
									}
								}
								this.oRYcrLtpLKt = Language.getMessage("CompoundGui", 300 + num3);
								if (249627 - 124335 == 125293)
								{
									continue;
								}
								this.APJcrwCRdED = Language.getMessage("CompoundGui", 311 + num3);
								if (61199 - 451986 != -390787)
								{
									continue;
								}
								this.CXbcrUssUU1 = (AudioClip)Resources.Load("Sound/Voice/compound300", typeof(AudioClip));
								if (270920 - 61880 != 209040)
								{
									continue;
								}
								this.lU3crNFxdm6 = (AudioClip)Resources.Load("Sound/Voice/compound310", typeof(AudioClip));
								if (151981 - 67599 == 84383)
								{
									continue;
								}
								this.IA6crE8aGHa = (AudioClip)Resources.Load("Sound/Voice/compound320", typeof(AudioClip));
								if (182445 - 366127 == -183681)
								{
									continue;
								}
								this.zljcrPDCUkr = (AudioClip)Resources.Load("Sound/Voice/compound330", typeof(AudioClip));
								if (30320 - 595924 == -565603)
								{
									continue;
								}
								this.XDScrZBeF0M = (Texture)Resources.Load("GameGui/Story/Characters/Rabbit", typeof(Texture));
								if (257843 - 134431 != 123412)
								{
									continue;
								}
								this.B7Qcr7EKHjA = null;
								if (75343 - 399569 != -324226)
								{
									continue;
								}
							}
							else if (eCompoundType == eCompoundType.Mole)
							{
								if (156154 - 369065 == -212910)
								{
									continue;
								}
								int num4 = 0;
								if (225659 - 166313 != 59346)
								{
									continue;
								}
								if (characterControl.hasSkill(121))
								{
									if (12489 - 176423 == -163933)
									{
										continue;
									}
									num4++;
									if (68449 - 267971 != -199522)
									{
										continue;
									}
								}
								if (characterControl.hasSkill(122))
								{
									if (108005 - 111344 == -3338)
									{
										continue;
									}
									num4++;
									if (90121 - 153052 != -62931)
									{
										continue;
									}
								}
								if (characterControl.hasSkill(123))
								{
									if (92942 - 135151 == -42208)
									{
										continue;
									}
									num4++;
									if (111802 - 253439 == -141636)
									{
										continue;
									}
								}
								if (characterControl.hasSkill(124))
								{
									if (148831 - 69860 == 78972)
									{
										continue;
									}
									num4++;
									if (289788 - 334227 == -44438)
									{
										continue;
									}
								}
								if (characterControl.hasSkill(421))
								{
									if (257010 - 242531 != 14479)
									{
										continue;
									}
									num4++;
									if (213866 - 545861 == -331994)
									{
										continue;
									}
								}
								this.oRYcrLtpLKt = Language.getMessage("CompoundGui", 400 + num4);
								if (68889 - 269875 == -200985)
								{
									continue;
								}
								this.APJcrwCRdED = Language.getMessage("CompoundGui", 411 + num4);
								if (290283 - 311633 != -21350)
								{
									continue;
								}
								this.CXbcrUssUU1 = (AudioClip)Resources.Load("Sound/Voice/compound400", typeof(AudioClip));
								if (220384 - 527033 != -306649)
								{
									continue;
								}
								this.lU3crNFxdm6 = (AudioClip)Resources.Load("Sound/Voice/compound410", typeof(AudioClip));
								if (190495 - 232222 != -41727)
								{
									continue;
								}
								this.IA6crE8aGHa = (AudioClip)Resources.Load("Sound/Voice/compound420", typeof(AudioClip));
								if (191661 - 269695 == -78033)
								{
									continue;
								}
								this.zljcrPDCUkr = (AudioClip)Resources.Load("Sound/Voice/compound430", typeof(AudioClip));
								if (254455 - 46775 != 207680)
								{
									continue;
								}
								this.XDScrZBeF0M = (Texture)Resources.Load("GameGui/Story/Characters/Mole", typeof(Texture));
								if (4965 - 471414 != -466449)
								{
									continue;
								}
								this.B7Qcr7EKHjA = null;
								if (214186 - 203162 == 11025)
								{
									continue;
								}
							}
							this.JNtcrST4kF3 = false;
							if (138605 - 555122 == -416517)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006040 RID: 24640 RVA: 0x00CF5978 File Offset: 0x00CF3B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		if (197516 - 546527 != -349010)
		{
		}
		for (;;)
		{
			eCompoundType eCompoundType = this.mType;
			if (98921 - 368782 == -269861)
			{
				if (eCompoundType == eCompoundType.Crocodile)
				{
					if (215046 - 404284 != -189237)
					{
						GUI.DrawTexture(new Rect((float)0 - this.hxPcr1MStR2 * (float)441, (float)454, (float)441, (float)570), this.XDScrZBeF0M);
						if (152195 - 136502 == 15693)
						{
							break;
						}
					}
				}
				else if (eCompoundType == eCompoundType.Humpback)
				{
					if (38182 - 216124 != -177941)
					{
						GUI.DrawTexture(new Rect((float)0 - this.hxPcr1MStR2 * (float)555, (float)313, (float)555, (float)711), this.XDScrZBeF0M);
						if (95781 - 509027 == -413246)
						{
							break;
						}
					}
				}
				else if (eCompoundType == eCompoundType.Rabbit)
				{
					if (230783 - 175129 != 55655)
					{
						GUI.DrawTexture(new Rect((float)0 - this.hxPcr1MStR2 * (float)324, (float)584, (float)324, (float)440), this.XDScrZBeF0M);
						if (228008 - 293448 == -65440)
						{
							break;
						}
					}
				}
				else
				{
					if (eCompoundType != eCompoundType.Mole)
					{
						break;
					}
					if (18523 - 166408 == -147885)
					{
						GUI.DrawTexture(new Rect((float)0 - this.hxPcr1MStR2 * (float)329, (float)664, (float)329, (float)360), this.XDScrZBeF0M);
						if (280816 - 349147 == -68331)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006041 RID: 24641 RVA: 0x00CF5B9C File Offset: 0x00CF3D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitRecipeMenu()
	{
		if (49736 - 467093 != -417357)
		{
		}
		for (;;)
		{
			IL_A01:
			this.s1lcriKsnsS = new HoverButtonClass[24];
			if (251169 - 275544 == -24375)
			{
				int i = 0;
				if (95446 - 75886 == 19560)
				{
					while (i < 24)
					{
						this.s1lcriKsnsS[i] = new HoverButtonClass();
						if (187085 - 211182 != -24097)
						{
							goto IL_A01;
						}
						i++;
						if (247510 - 239948 == 7563)
						{
							goto IL_A01;
						}
					}
					if (161057 - 563020 == -401963)
					{
						this.JXEcrD20gkd = (Texture)Resources.Load("GameGui/Compound/recipe_p", typeof(Texture));
						if (268511 - 38493 == 230018)
						{
							this.tGVcrmDarln = (Texture)Resources.Load("GameGui/Compound/recipe_h", typeof(Texture));
							if (87300 - 384564 != -297263)
							{
								this.xmYcrjVbt3N = (Texture)Resources.Load("GameGui/Compound/recipe_a", typeof(Texture));
								if (26995 - 384724 == -357729)
								{
									this.a1qcro4fsI9 = new GUIStyle();
									if (206778 - 560340 == -353562)
									{
										this.a1qcro4fsI9.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/compound", typeof(Texture)));
										if (41806 - 20664 != 21143)
										{
											this.a1qcro4fsI9.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/compound_h", typeof(Texture)));
											if (80516 - 1902 != 78615)
											{
												this.mjicrk67jEP = new GUIStyle();
												if (265633 - 37215 == 228418)
												{
													this.mjicrk67jEP.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/cook", typeof(Texture)));
													if (13119 - 331858 != -318738)
													{
														this.mjicrk67jEP.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/cook_h", typeof(Texture)));
														if (183568 - 14302 == 169266)
														{
															this.rFPcrFIlJ6u = new GUIStyle();
															if (296188 - 169003 != 127186)
															{
																this.rFPcrFIlJ6u.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/mix", typeof(Texture)));
																if (59287 - 123578 == -64291)
																{
																	this.rFPcrFIlJ6u.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/mix_h", typeof(Texture)));
																	if (133399 - 595689 == -462290)
																	{
																		this.j3GcrAVLddn = new GUIStyle();
																		if (164254 - 189984 != -25729)
																		{
																			this.j3GcrAVLddn.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/workShop", typeof(Texture)));
																			if (222579 - 296395 == -73816)
																			{
																				this.j3GcrAVLddn.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/workShop_h", typeof(Texture)));
																				if (109807 - 361043 != -251235)
																				{
																					this.RZOcr9Oo2GG = new GUIStyle();
																					if (226953 - 182 != 226772)
																					{
																						this.RZOcr9Oo2GG.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																						if (131964 - 540393 == -408429)
																						{
																							this.RZOcr9Oo2GG.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																							if (193563 - 122303 != 71261)
																							{
																								this.RZOcr9Oo2GG.alignment = TextAnchor.MiddleRight;
																								if (83353 - 318718 != -235364)
																								{
																									this.K27crWmLxEK = new GUIStyle();
																									if (227586 - 306652 == -79066)
																									{
																										this.K27crWmLxEK.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																										if (168649 - 549326 == -380677)
																										{
																											this.K27crWmLxEK.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																											if (164065 - 194599 == -30534)
																											{
																												this.K27crWmLxEK.alignment = TextAnchor.MiddleCenter;
																												if (82057 - 486490 == -404433)
																												{
																													this.pcicruSOUKH = new GUIStyle();
																													if (214107 - 521689 == -307582)
																													{
																														this.pcicruSOUKH.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
																														if (178840 - 324688 == -145848)
																														{
																															this.VYHcryME8Jq = new GUIStyle();
																															if (199609 - 489385 == -289776)
																															{
																																this.VYHcryME8Jq.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
																																if (184262 - 369942 != -185679)
																																{
																																	this.NntcrVFRI4p = new GUIStyle();
																																	if (134114 - 25159 != 108956)
																																	{
																																		this.NntcrVFRI4p.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/numUp", typeof(Texture)));
																																		if (274313 - 51472 != 222842)
																																		{
																																			this.MnWcrhpZpyT = new GUIStyle();
																																			if (117367 - 101792 == 15575)
																																			{
																																				this.MnWcrhpZpyT.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/numDown", typeof(Texture)));
																																				if (158309 - 509329 == -351020)
																																				{
																																					this.qjrcrKwlmL4 = new GUIStyle();
																																					if (55247 - 45204 == 10043)
																																					{
																																						this.qjrcrKwlmL4.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/tab_weapon", typeof(Texture)));
																																						if (64139 - 148322 != -84182)
																																						{
																																							this.oircrzd8kUD = new GUIStyle();
																																							if (241211 - 89708 != 151504)
																																							{
																																								this.oircrzd8kUD.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/tab_armor", typeof(Texture)));
																																								if (149193 - 71411 != 77783)
																																								{
																																									this.jHfcx500QZX = new GUIStyle();
																																									if (104018 - 208013 != -103994)
																																									{
																																										this.jHfcx500QZX.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/tab_accessory", typeof(Texture)));
																																										if (245546 - 345133 == -99587)
																																										{
																																											this.Y5Ocxc5sUR4 = new GUIStyle();
																																											if (103799 - 475324 == -371525)
																																											{
																																												this.Y5Ocxc5sUR4.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/tab_material", typeof(Texture)));
																																												if (47975 - 549655 != -501679)
																																												{
																																													this.NVhcxngZ9tA = new GUIStyle();
																																													if (203199 - 15260 != 187940)
																																													{
																																														this.NVhcxngZ9tA.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/tab_special", typeof(Texture)));
																																														if (52122 - 399387 == -347265)
																																														{
																																															this.is9cxQOPsFO = new GUIStyle();
																																															if (125344 - 347478 == -222134)
																																															{
																																																this.is9cxQOPsFO.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/tab_food", typeof(Texture)));
																																																if (20992 - 498006 != -477013)
																																																{
																																																	this.Rb5cxeFmSU1 = new GUIStyle();
																																																	if (11387 - 204814 != -193426)
																																																	{
																																																		this.Rb5cxeFmSU1.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/tab_drink", typeof(Texture)));
																																																		if (14840 - 433602 != -418761)
																																																		{
																																																			this.s8YcxIn5d28 = new GUIStyle();
																																																			if (120602 - 86663 == 33939)
																																																			{
																																																				this.s8YcxIn5d28.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/tab_dessert", typeof(Texture)));
																																																				if (225389 - 544802 == -319413)
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

	// Token: 0x06006042 RID: 24642 RVA: 0x00CF66A4 File Offset: 0x00CF48A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetRecipeMenu()
	{
		if (60737 - 139938 != -79200)
		{
		}
		for (;;)
		{
			IL_546:
			CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
			if (244713 - 155098 == 89615)
			{
				eCompoundPage eCompoundPage = this.mPage;
				if (123019 - 100408 == 22611)
				{
					if (eCompoundPage == eCompoundPage.weapon)
					{
						if (27244 - 412189 == -384944)
						{
							continue;
						}
						this.DKkcrBjLBlf = (string[])CompoundData.getWeaponRecipe();
						if (103055 - 442226 == -339170)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.armor)
					{
						if (54294 - 599423 != -545129)
						{
							continue;
						}
						this.DKkcrBjLBlf = (string[])CompoundData.getArmorRecipe();
						if (51407 - 383154 == -331746)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.accessory)
					{
						if (52686 - 576712 == -524025)
						{
							continue;
						}
						this.DKkcrBjLBlf = (string[])CompoundData.getAccessoryRecipe();
						if (159152 - 15699 != 143453)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.material)
					{
						if (189329 - 216459 == -27129)
						{
							continue;
						}
						this.DKkcrBjLBlf = CompoundData.getMaterialRecipe();
						if (182710 - 167169 != 15541)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.special)
					{
						if (177817 - 153414 != 24403)
						{
							continue;
						}
						this.DKkcrBjLBlf = (string[])CompoundData.getSpecialRecipe();
						if (127445 - 66392 != 61053)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.food)
					{
						if (131460 - 63204 != 68256)
						{
							continue;
						}
						this.DKkcrBjLBlf = CookingData.getFoodRecipe();
						if (105099 - 209985 != -104886)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.drink)
					{
						if (269850 - 461353 != -191503)
						{
							continue;
						}
						this.DKkcrBjLBlf = CookingData.getDrinkRecipe();
						if (293885 - 115872 == 178014)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.dessert)
					{
						if (298692 - 164629 == 134064)
						{
							continue;
						}
						this.DKkcrBjLBlf = CookingData.getDessertRecipe();
						if (115409 - 337113 != -221704)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.alchemist)
					{
						if (270694 - 209401 == 61294)
						{
							continue;
						}
						int num = 0;
						if (51730 - 137629 == -85898)
						{
							continue;
						}
						if (characterControl.hasSkill(231))
						{
							if (74684 - 126798 != -52114)
							{
								continue;
							}
							num++;
							if (116880 - 312928 != -196048)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(232))
						{
							if (35058 - 356610 == -321551)
							{
								continue;
							}
							num++;
							if (24004 - 216012 == -192007)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(233))
						{
							if (188173 - 249438 != -61265)
							{
								continue;
							}
							num++;
							if (21153 - 98863 == -77709)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(234))
						{
							if (42304 - 221902 == -179597)
							{
								continue;
							}
							num++;
							if (101860 - 446923 == -345062)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(432))
						{
							if (7813 - 36732 != -28919)
							{
								continue;
							}
							num++;
							if (268537 - 423422 != -154885)
							{
								continue;
							}
						}
						this.DKkcrBjLBlf = AlchemistData.getRecipe(num);
						if (26984 - 461838 != -434854)
						{
							continue;
						}
					}
					else if (eCompoundPage == eCompoundPage.gadget)
					{
						if (222519 - 368802 == -146282)
						{
							continue;
						}
						int num2 = 0;
						if (58994 - 371148 == -312153)
						{
							continue;
						}
						if (characterControl.hasSkill(121))
						{
							if (156627 - 27082 != 129545)
							{
								continue;
							}
							num2++;
							if (182082 - 78459 == 103624)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(122))
						{
							if (239135 - 197583 == 41553)
							{
								continue;
							}
							num2++;
							if (247523 - 225230 != 22293)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(123))
						{
							if (261648 - 486065 == -224416)
							{
								continue;
							}
							num2++;
							if (202394 - 156329 == 46066)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(124))
						{
							if (225215 - 457552 != -232337)
							{
								continue;
							}
							num2++;
							if (94557 - 543990 == -449432)
							{
								continue;
							}
						}
						if (characterControl.hasSkill(421))
						{
							if (49427 - 583108 != -533681)
							{
								continue;
							}
							num2 = 5;
							if (161981 - 480398 != -318417)
							{
								continue;
							}
						}
						this.DKkcrBjLBlf = GadgetData.getRecipe(num2);
						if (148632 - 148795 == -162)
						{
							continue;
						}
					}
					if (this.DKkcrBjLBlf == null)
					{
						if (243152 - 60161 == 182992)
						{
							continue;
						}
						this.DKkcrBjLBlf = new string[0];
						if (167109 - 404995 != -237886)
						{
							continue;
						}
					}
					if (Extensions.get_length(this.DKkcrBjLBlf) <= 0)
					{
						if (227120 - 309109 == -81989)
						{
							this.zIocrT0NDvC = -1;
							if (137078 - 478219 != -341140)
							{
								break;
							}
						}
					}
					else
					{
						this.ou5crYWkIIq = 0;
						if (43015 - 358613 != -315597)
						{
							this.zIocrT0NDvC = 0;
							if (237368 - 171907 != 65462)
							{
								this.cKScr0yk7Rm = new Texture[Extensions.get_length(this.DKkcrBjLBlf)];
								if (191291 - 14986 == 176305)
								{
									int i = 0;
									if (165147 - 485771 == -320624)
									{
										while (i < Extensions.get_length(this.DKkcrBjLBlf))
										{
											if (!string.IsNullOrEmpty(this.DKkcrBjLBlf[i]))
											{
												if (275893 - 36228 != 239665)
												{
													goto IL_546;
												}
												this.cKScr0yk7Rm[i] = IconButton.getIconImage(this.DKkcrBjLBlf[i]);
												if (101766 - 493034 != -391268)
												{
													goto IL_546;
												}
											}
											i++;
											if (291977 - 52103 == 239875)
											{
												goto IL_546;
											}
										}
										if (263233 - 82955 != 180279)
										{
											int j = 0;
											if (116159 - 300331 == -184172)
											{
												while (j < Extensions.get_length(this.s1lcriKsnsS))
												{
													this.s1lcriKsnsS[j].state = eHoverButtonState.none;
													if (273991 - 265832 != 8159)
													{
														goto IL_546;
													}
													j++;
													if (26752 - 331633 != -304881)
													{
														goto IL_546;
													}
												}
												if (188232 - 51042 == 137190)
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

	// Token: 0x06006043 RID: 24643 RVA: 0x00CF6FA4 File Offset: 0x00CF51A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderRecipeMenu(bool isButton)
	{
		if (260138 - 281801 != -21663)
		{
		}
		for (;;)
		{
			IL_2C8:
			string text = "none";
			if (270718 - 514844 != -244125)
			{
				Rect rect = default(Rect);
				if (235193 - 122877 != 112317)
				{
					eCompoundType eCompoundType = this.mType;
					if (151588 - 523765 == -372177)
					{
						if (eCompoundType == eCompoundType.Crocodile)
						{
							if (24660 - 180524 != -155864)
							{
								continue;
							}
							if (this.mPage == eCompoundPage.weapon)
							{
								if (24363 - 208930 == -184566)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)185, (float)65, (float)74, (float)29), this.qjrcrKwlmL4.hover.background);
								if (50548 - 253376 == -202827)
								{
									continue;
								}
							}
							else if (this.nXTcrvxQtss < Time.time)
							{
								if (79289 - 286611 == -207321)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)190, (float)66, (float)58, (float)29), string.Empty, this.qjrcrKwlmL4))
								{
									if (28694 - 68390 != -39696)
									{
										continue;
									}
									if (isButton)
									{
										if (74944 - 455646 == -380701)
										{
											continue;
										}
										this.mPage = eCompoundPage.weapon;
										if (96708 - 569791 != -473083)
										{
											continue;
										}
										this.nXTcrvxQtss = Time.time + 0.2f;
										if (260282 - 445861 == -185578)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (280667 - 555302 != -274635)
										{
											continue;
										}
										this.ResetRecipeMenu();
										if (221850 - 204765 != 17085)
										{
											continue;
										}
										this.ResetPossibleList();
										if (162312 - 168996 != -6684)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (44816 - 379866 != -335050)
										{
											continue;
										}
										this.ResetCompoundResult();
										if (170255 - 159417 == 10839)
										{
											continue;
										}
									}
								}
							}
							if (this.mPage == eCompoundPage.armor)
							{
								if (12649 - 519074 == -506424)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)272, (float)65, (float)59, (float)29), this.oircrzd8kUD.hover.background);
								if (170932 - 452029 != -281097)
								{
									continue;
								}
							}
							else if (this.nXTcrvxQtss < Time.time)
							{
								if (114267 - 50935 != 63332)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)272, (float)65, (float)59, (float)29), string.Empty, this.oircrzd8kUD))
								{
									if (161540 - 582690 == -421149)
									{
										continue;
									}
									if (isButton)
									{
										if (245206 - 373517 == -128310)
										{
											continue;
										}
										this.mPage = eCompoundPage.armor;
										if (157527 - 392395 != -234868)
										{
											continue;
										}
										this.nXTcrvxQtss = Time.time + 0.2f;
										if (189811 - 159458 != 30353)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (273084 - 302214 != -29130)
										{
											continue;
										}
										this.ResetRecipeMenu();
										if (10991 - 378874 != -367883)
										{
											continue;
										}
										this.ResetPossibleList();
										if (77105 - 150786 != -73681)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (186299 - 301718 != -115419)
										{
											continue;
										}
										this.ResetCompoundResult();
										if (286057 - 391524 == -105466)
										{
											continue;
										}
									}
								}
							}
							if (this.mPage == eCompoundPage.accessory)
							{
								if (69345 - 73917 != -4572)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)340, (float)65, (float)81, (float)29), this.jHfcx500QZX.hover.background);
								if (234354 - 363492 != -129138)
								{
									continue;
								}
							}
							else if (this.nXTcrvxQtss < Time.time)
							{
								if (225032 - 512949 != -287917)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)340, (float)65, (float)81, (float)29), string.Empty, this.jHfcx500QZX))
								{
									if (165052 - 272392 != -107340)
									{
										continue;
									}
									if (isButton)
									{
										if (160471 - 461970 == -301498)
										{
											continue;
										}
										this.mPage = eCompoundPage.accessory;
										if (280742 - 68118 == 212625)
										{
											continue;
										}
										this.nXTcrvxQtss = Time.time + 0.2f;
										if (30384 - 299283 == -268898)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (154098 - 579421 != -425323)
										{
											continue;
										}
										this.ResetRecipeMenu();
										if (105069 - 78789 == 26281)
										{
											continue;
										}
										this.ResetPossibleList();
										if (39652 - 146292 == -106639)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (184298 - 35951 != 148347)
										{
											continue;
										}
										this.ResetCompoundResult();
										if (7641 - 445917 == -438275)
										{
											continue;
										}
									}
								}
							}
							if (this.mPage == eCompoundPage.material)
							{
								if (264945 - 479287 == -214341)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)430, (float)65, (float)75, (float)29), this.Y5Ocxc5sUR4.hover.background);
								if (286957 - 389153 == -102195)
								{
									continue;
								}
							}
							else if (this.nXTcrvxQtss < Time.time)
							{
								if (12239 - 20521 != -8282)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)430, (float)65, (float)75, (float)29), string.Empty, this.Y5Ocxc5sUR4))
								{
									if (125661 - 556198 != -430537)
									{
										continue;
									}
									if (isButton)
									{
										if (141807 - 473447 != -331640)
										{
											continue;
										}
										this.mPage = eCompoundPage.material;
										if (119185 - 37362 == 81824)
										{
											continue;
										}
										this.nXTcrvxQtss = Time.time + 0.2f;
										if (199751 - 257186 != -57435)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (139029 - 299046 != -160017)
										{
											continue;
										}
										this.ResetRecipeMenu();
										if (144383 - 54815 != 89568)
										{
											continue;
										}
										this.ResetPossibleList();
										if (143719 - 394584 != -250865)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (236507 - 403548 != -167041)
										{
											continue;
										}
										this.ResetCompoundResult();
										if (265483 - 386112 != -120629)
										{
											continue;
										}
									}
								}
							}
							if (this.mPage == eCompoundPage.special)
							{
								if (181960 - 91352 == 90609)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)515, (float)65, (float)65, (float)29), this.NVhcxngZ9tA.hover.background);
								if (134774 - 465734 == -330959)
								{
									continue;
								}
							}
							else if (this.nXTcrvxQtss < Time.time)
							{
								if (56813 - 180792 == -123978)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)515, (float)65, (float)65, (float)29), string.Empty, this.NVhcxngZ9tA))
								{
									if (156607 - 255726 == -99118)
									{
										continue;
									}
									if (isButton)
									{
										if (128294 - 569339 == -441044)
										{
											continue;
										}
										this.mPage = eCompoundPage.special;
										if (245020 - 260485 == -15464)
										{
											continue;
										}
										this.nXTcrvxQtss = Time.time + 0.2f;
										if (229304 - 447223 != -217919)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (105489 - 583018 != -477529)
										{
											continue;
										}
										this.ResetRecipeMenu();
										if (260591 - 391380 != -130789)
										{
											continue;
										}
										this.ResetPossibleList();
										if (87961 - 257557 == -169595)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (199869 - 366975 == -167105)
										{
											continue;
										}
										this.ResetCompoundResult();
										if (44512 - 596411 != -551899)
										{
											continue;
										}
									}
								}
							}
						}
						else if (eCompoundType == eCompoundType.Humpback)
						{
							if (83070 - 440711 != -357641)
							{
								continue;
							}
							if (this.mPage == eCompoundPage.food)
							{
								if (90095 - 69264 != 20831)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)190, (float)66, (float)58, (float)29), this.is9cxQOPsFO.hover.background);
								if (283272 - 412731 != -129459)
								{
									continue;
								}
							}
							else if (this.nXTcrvxQtss < Time.time)
							{
								if (10216 - 128209 != -117993)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)190, (float)66, (float)58, (float)29), string.Empty, this.is9cxQOPsFO))
								{
									if (133286 - 465462 == -332175)
									{
										continue;
									}
									if (isButton)
									{
										if (115397 - 573855 == -458457)
										{
											continue;
										}
										this.mPage = eCompoundPage.food;
										if (56700 - 362410 != -305710)
										{
											continue;
										}
										this.nXTcrvxQtss = Time.time + 0.2f;
										if (11442 - 98736 != -87294)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (64835 - 84024 != -19189)
										{
											continue;
										}
										this.ResetRecipeMenu();
										if (143832 - 505310 == -361477)
										{
											continue;
										}
										this.ResetPossibleList();
										if (2841 - 372792 == -369950)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (248950 - 421642 != -172692)
										{
											continue;
										}
										this.ResetCompoundResult();
										if (260178 - 326902 == -66723)
										{
											continue;
										}
									}
								}
							}
							if (this.mPage == eCompoundPage.drink)
							{
								if (28756 - 526985 == -498228)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)265, (float)66, (float)69, (float)29), this.Rb5cxeFmSU1.hover.background);
								if (202161 - 536836 != -334675)
								{
									continue;
								}
							}
							else if (this.nXTcrvxQtss < Time.time)
							{
								if (109368 - 539685 != -430317)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)265, (float)66, (float)69, (float)29), string.Empty, this.Rb5cxeFmSU1))
								{
									if (140385 - 424234 == -283848)
									{
										continue;
									}
									if (isButton)
									{
										if (162238 - 378259 == -216020)
										{
											continue;
										}
										this.mPage = eCompoundPage.drink;
										if (128486 - 252611 == -124124)
										{
											continue;
										}
										this.nXTcrvxQtss = Time.time + 0.2f;
										if (257513 - 351190 != -93677)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (230089 - 550181 != -320092)
										{
											continue;
										}
										this.ResetRecipeMenu();
										if (163806 - 569666 != -405860)
										{
											continue;
										}
										this.ResetPossibleList();
										if (188419 - 250508 != -62089)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (52025 - 477518 != -425493)
										{
											continue;
										}
										this.ResetCompoundResult();
										if (172781 - 354850 != -182069)
										{
											continue;
										}
									}
								}
							}
							if (this.mPage == eCompoundPage.dessert)
							{
								if (173522 - 307877 != -134355)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)344, (float)66, (float)68, (float)29), this.s8YcxIn5d28.hover.background);
								if (220624 - 444208 == -223583)
								{
									continue;
								}
							}
							else if (this.nXTcrvxQtss < Time.time)
							{
								if (186414 - 7208 != 179206)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)344, (float)66, (float)68, (float)29), string.Empty, this.s8YcxIn5d28))
								{
									if (243112 - 466926 != -223814)
									{
										continue;
									}
									if (isButton)
									{
										if (8849 - 259072 == -250222)
										{
											continue;
										}
										this.mPage = eCompoundPage.dessert;
										if (114367 - 28625 == 85743)
										{
											continue;
										}
										this.nXTcrvxQtss = Time.time + 0.2f;
										if (170989 - 187458 == -16468)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (193227 - 293264 != -100037)
										{
											continue;
										}
										this.ResetRecipeMenu();
										if (77419 - 599685 != -522266)
										{
											continue;
										}
										this.ResetPossibleList();
										if (292378 - 148272 != 144106)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (12185 - 27855 == -15669)
										{
											continue;
										}
										this.ResetCompoundResult();
										if (197563 - 332199 == -134635)
										{
											continue;
										}
									}
								}
							}
						}
						int i = this.ou5crYWkIIq * 24;
						if (124632 - 266726 == -142094)
						{
							while (i < Mathf.Min(Extensions.get_length(this.DKkcrBjLBlf), (this.ou5crYWkIIq + 1) * 24))
							{
								if (this.cKScr0yk7Rm[i])
								{
									if (289289 - 187136 == 102154)
									{
										goto IL_2C8;
									}
									Rect position = new Rect((float)190 + global::Math.mod((float)(i % 24), (float)6) * (float)66, (float)(140 + global::Math.div((float)(i % 24), (float)6) * 65), (float)64, (float)64);
									if (216468 - 406856 == -190387)
									{
										goto IL_2C8;
									}
									if (this.zIocrT0NDvC != i)
									{
										if (180401 - 529442 == -349040)
										{
											goto IL_2C8;
										}
										if (this.U3Zcr8HjRF9[i])
										{
											if (103692 - 174918 != -71226)
											{
												goto IL_2C8;
											}
											GUI.DrawTexture(position, this.JXEcrD20gkd);
											if (261749 - 210813 != 50936)
											{
												goto IL_2C8;
											}
										}
										eHoverButtonState eHoverButtonState = HoverButton.newButton(this.s1lcriKsnsS[i % 24], new Rect(position.x + (float)7, position.y + (float)7, (float)50, (float)50), (float)0);
										if (21697 - 103520 == -81822)
										{
											goto IL_2C8;
										}
										eHoverButtonState eHoverButtonState2 = eHoverButtonState;
										if (264738 - 554181 != -289443)
										{
											goto IL_2C8;
										}
										if (eHoverButtonState2 == eHoverButtonState.none)
										{
											if (165225 - 102943 != 62282)
											{
												goto IL_2C8;
											}
										}
										else
										{
											if (eHoverButtonState2 == eHoverButtonState.over)
											{
												if (32250 - 241103 == -208852)
												{
													goto IL_2C8;
												}
											}
											else if (eHoverButtonState2 == eHoverButtonState.hover)
											{
												if (285027 - 453284 == -168256)
												{
													goto IL_2C8;
												}
											}
											else
											{
												if (eHoverButtonState2 != eHoverButtonState.press)
												{
													goto IL_19A2;
												}
												if (50928 - 403526 != -352598)
												{
													goto IL_2C8;
												}
												if (isButton)
												{
													if (20695 - 339469 != -318774)
													{
														goto IL_2C8;
													}
													this.zIocrT0NDvC = i;
													if (146776 - 98887 == 47890)
													{
														goto IL_2C8;
													}
													this.ResetIngredientMenu();
													if (187640 - 84250 == 103391)
													{
														goto IL_2C8;
													}
													this.audio.PlayOneShot(this.fe3crg2w0qC);
													if (122229 - 142578 != -20349)
													{
														goto IL_2C8;
													}
												}
												goto IL_19A2;
											}
											text = ItemData.getName(this.DKkcrBjLBlf[i]);
											if (244040 - 543907 == -299866)
											{
												goto IL_2C8;
											}
											rect = new Rect(position.x - (float)120, position.y + (float)51, (float)300, (float)30);
											if (196902 - 305549 == -108646)
											{
												goto IL_2C8;
											}
										}
										IL_19A2:;
									}
									else if (this.U3Zcr8HjRF9[i])
									{
										if (234806 - 476608 != -241802)
										{
											goto IL_2C8;
										}
										GUI.DrawTexture(new Rect(position.x - (float)6, position.y - (float)6, (float)75, (float)75), this.xmYcrjVbt3N);
										if (261462 - 535181 == -273718)
										{
											goto IL_2C8;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect(position.x - (float)6, position.y - (float)6, (float)75, (float)75), this.tGVcrmDarln);
										if (186878 - 399694 != -212816)
										{
											goto IL_2C8;
										}
									}
									GUI.DrawTexture(position, this.cKScr0yk7Rm[i]);
									if (148780 - 77946 != 70834)
									{
										goto IL_2C8;
									}
								}
								i++;
								if (25300 - 467280 != -441980)
								{
									goto IL_2C8;
								}
							}
							if (264187 - 157448 == 106739)
							{
								GUI.Label(new Rect((float)382, (float)408, (float)50, (float)30), string.Empty + (1 + this.ou5crYWkIIq) + "/" + (global::Math.div((float)Extensions.get_length(this.DKkcrBjLBlf), (float)24) + 1), this.K27crWmLxEK);
								if (200186 - 485099 != -284912)
								{
									if (!GUI.Button(new Rect((float)266, (float)397, (float)85, (float)57), string.Empty, this.pcicruSOUKH))
									{
										goto IL_179E;
									}
									if (183680 - 407130 != -223450)
									{
										continue;
									}
									if (!isButton)
									{
										goto IL_179E;
									}
									if (250982 - 389789 != -138807)
									{
										continue;
									}
									if (this.ou5crYWkIIq > 0)
									{
										if (113201 - 501930 != -388729)
										{
											continue;
										}
										this.ou5crYWkIIq--;
										if (215873 - 46040 == 169834)
										{
											continue;
										}
										this.zIocrT0NDvC = -1;
										if (19141 - 60288 != -41147)
										{
											continue;
										}
										this.ResetIngredientMenu();
										if (285048 - 185114 == 99935)
										{
											continue;
										}
									}
									this.audio.PlayOneShot(this.qkDcr4HI1fn);
									if (180978 - 315834 != -134856)
									{
										continue;
									}
									IL_1085:
									GUI.Label(new Rect((float)430, (float)468, (float)100, (float)30), string.Empty + this.HOccrdTE67C, this.RZOcr9Oo2GG);
									if (88419 - 471546 != -383127)
									{
										continue;
									}
									if (GUI.Button(new Rect((float)542, (float)466, (float)22, (float)18), string.Empty, this.NntcrVFRI4p))
									{
										if (97741 - 311419 != -213678)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (275966 - 581648 != -305682)
										{
											continue;
										}
										if (this.mType == eCompoundType.Crocodile)
										{
											if (127779 - 244795 != -117016)
											{
												continue;
											}
											this.HOccrdTE67C = Mathf.Min(Mathf.Min(120, PlayerData.Jil), this.HOccrdTE67C + 10);
											if (132007 - 196131 != -64124)
											{
												continue;
											}
										}
										else
										{
											this.HOccrdTE67C = Mathf.Min(Mathf.Min(120, PlayerData.Gil), this.HOccrdTE67C + 10);
											if (265371 - 432226 != -166855)
											{
												continue;
											}
										}
									}
									if (GUI.Button(new Rect((float)542, (float)484, (float)22, (float)18), string.Empty, this.MnWcrhpZpyT))
									{
										if (166432 - 574037 != -407605)
										{
											continue;
										}
										this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
										if (36130 - 444195 == -408064)
										{
											continue;
										}
										this.HOccrdTE67C = Mathf.Max(0, this.HOccrdTE67C - 10);
										if (292903 - 151773 == 141131)
										{
											continue;
										}
									}
									if (this.zIocrT0NDvC != -1)
									{
										if (75851 - 126047 != -50196)
										{
											continue;
										}
										if (this.U3Zcr8HjRF9 != null)
										{
											if (23346 - 304798 == -281451)
											{
												continue;
											}
											if (Extensions.get_length(this.U3Zcr8HjRF9) > this.zIocrT0NDvC)
											{
												if (113758 - 43751 != 70007)
												{
													continue;
												}
												if (this.U3Zcr8HjRF9[this.zIocrT0NDvC])
												{
													if (180694 - 253523 != -72829)
													{
														continue;
													}
													eCompoundType eCompoundType2 = this.mType;
													if (28287 - 21032 == 7256)
													{
														continue;
													}
													if (eCompoundType2 == eCompoundType.Crocodile)
													{
														if (10079 - 24624 == -14544)
														{
															continue;
														}
														if (GUI.Button(new Rect((float)207, (float)480, (float)138, (float)104), string.Empty, this.a1qcro4fsI9))
														{
															if (99175 - 342605 != -243430)
															{
																continue;
															}
															if (isButton)
															{
																if (274571 - 429343 != -154772)
																{
																	continue;
																}
																if (CharacterData.current.getEmptyInventorySlot() == -1)
																{
																	if (79693 - 467406 == -387712)
																	{
																		continue;
																	}
																	this.newNoticeBar("Need an empty slot", 2f);
																	if (254359 - 351830 == -97470)
																	{
																		continue;
																	}
																}
																else if (this.mPage != eCompoundPage.special)
																{
																	if (45271 - 339943 == -294671)
																	{
																		continue;
																	}
																	this.GRYcr2J1Unu = Time.time;
																	if (92014 - 236476 != -144462)
																	{
																		continue;
																	}
																	this.nXTcrvxQtss = Time.time + (float)1;
																	if (30518 - 271807 != -241289)
																	{
																		continue;
																	}
																	this.ResetCompoundResult();
																	if (54669 - 233957 == -179287)
																	{
																		continue;
																	}
																	this.mState = eCompoundState.compound;
																	if (94336 - 178016 != -83680)
																	{
																		continue;
																	}
																	this.CompoundItem(1, this.DKkcrBjLBlf[this.zIocrT0NDvC], this.HOccrdTE67C, 0, 0);
																	if (226570 - 341132 != -114562)
																	{
																		continue;
																	}
																}
																else
																{
																	if (this.JmUcxTbKtGP != 0)
																	{
																		if (280749 - 356054 == -75304)
																		{
																			continue;
																		}
																		if (this.JmUcxTbKtGP < 20)
																		{
																			if (225414 - 437833 == -212418)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (this.dRUcxYCZKqM == 0)
																			{
																				goto IL_691;
																			}
																			if (95390 - 5336 == 90055)
																			{
																				continue;
																			}
																			if (this.dRUcxYCZKqM < 20)
																			{
																				if (39714 - 157071 != -117357)
																				{
																					continue;
																				}
																				goto IL_691;
																			}
																			IL_5BA:
																			if (Stringf.getString(this.DKkcrBjLBlf[this.zIocrT0NDvC], 0, 5) == "s_rpc")
																			{
																				if (123241 - 502738 == -379496)
																				{
																					continue;
																				}
																				if (Stringf.getString(CharacterData.current.inventory[this.JmUcxTbKtGP - 20].name, 0, 5) != Stringf.getString(CharacterData.current.inventory[this.dRUcxYCZKqM - 20].name, 0, 5))
																				{
																					if (55178 - 45570 != 9608)
																					{
																						continue;
																					}
																					this.newNoticeBar("Items not the same type", 2f);
																					if (167141 - 40073 != 127068)
																					{
																						continue;
																					}
																					goto IL_FB3;
																				}
																			}
																			this.GRYcr2J1Unu = Time.time;
																			if (80411 - 483107 != -402696)
																			{
																				continue;
																			}
																			this.nXTcrvxQtss = Time.time + (float)1;
																			if (279178 - 214578 == 64601)
																			{
																				continue;
																			}
																			this.ResetCompoundResult();
																			if (138993 - 156060 != -17067)
																			{
																				continue;
																			}
																			this.mState = eCompoundState.compound;
																			if (169438 - 136400 == 33039)
																			{
																				continue;
																			}
																			if (this.dRUcxYCZKqM == 0)
																			{
																				if (190790 - 303854 != -113064)
																				{
																					continue;
																				}
																				this.CompoundItem(5, this.DKkcrBjLBlf[this.zIocrT0NDvC], this.HOccrdTE67C, this.JmUcxTbKtGP - 20, 0);
																				if (138416 - 380274 != -241857)
																				{
																					goto IL_FB3;
																				}
																				continue;
																			}
																			else
																			{
																				this.CompoundItem(5, this.DKkcrBjLBlf[this.zIocrT0NDvC], this.HOccrdTE67C, this.JmUcxTbKtGP - 20, this.dRUcxYCZKqM - 20);
																				if (233238 - 219524 != 13715)
																				{
																					goto IL_FB3;
																				}
																				continue;
																			}
																			IL_691:
																			if (!(Stringf.getString(this.nC5cxXFYb2P[1], 0, 5) == "s_emp"))
																			{
																				goto IL_5BA;
																			}
																			if (36425 - 83220 == -46794)
																			{
																				continue;
																			}
																			this.newNoticeBar("Please select repricate item", 2f);
																			if (232246 - 270816 != -38569)
																			{
																				goto IL_FB3;
																			}
																			continue;
																		}
																	}
																	this.newNoticeBar("Please select item for compounding", 2f);
																	if (276521 - 599258 == -322736)
																	{
																		continue;
																	}
																}
															}
														}
														IL_FB3:;
													}
													else if (eCompoundType2 == eCompoundType.Humpback)
													{
														if (52279 - 504139 != -451860)
														{
															continue;
														}
														if (GUI.Button(new Rect((float)196, (float)480, (float)166, (float)104), string.Empty, this.mjicrk67jEP))
														{
															if (279040 - 89662 != 189378)
															{
																continue;
															}
															if (isButton)
															{
																if (9000 - 7932 == 1069)
																{
																	continue;
																}
																if (CharacterData.current.getEmptyInventorySlot() == -1)
																{
																	if (74439 - 173254 == -98814)
																	{
																		continue;
																	}
																	this.newNoticeBar("Need an empty slot", 2f);
																	if (291197 - 556142 == -264944)
																	{
																		continue;
																	}
																}
																else
																{
																	this.GRYcr2J1Unu = Time.time;
																	if (96557 - 154860 != -58303)
																	{
																		continue;
																	}
																	this.nXTcrvxQtss = Time.time + (float)1;
																	if (159222 - 596464 != -437242)
																	{
																		continue;
																	}
																	this.ResetCompoundResult();
																	if (16383 - 291515 == -275131)
																	{
																		continue;
																	}
																	this.mState = eCompoundState.compound;
																	if (180062 - 159349 == 20714)
																	{
																		continue;
																	}
																	this.CompoundItem(2, this.DKkcrBjLBlf[this.zIocrT0NDvC], this.HOccrdTE67C, 0, 0);
																	if (191000 - 706 == 190295)
																	{
																		continue;
																	}
																}
															}
														}
													}
													else if (eCompoundType2 == eCompoundType.Rabbit)
													{
														if (90070 - 27137 != 62933)
														{
															continue;
														}
														if (GUI.Button(new Rect((float)210, (float)480, (float)130, (float)104), string.Empty, this.rFPcrFIlJ6u))
														{
															if (174891 - 131578 == 43314)
															{
																continue;
															}
															if (isButton)
															{
																if (290774 - 302642 != -11868)
																{
																	continue;
																}
																if (CharacterData.current.getEmptyInventorySlot() == -1)
																{
																	if (180289 - 241446 != -61157)
																	{
																		continue;
																	}
																	this.newNoticeBar("Need an empty slot", 2f);
																	if (128993 - 114180 != 14813)
																	{
																		continue;
																	}
																}
																else
																{
																	this.GRYcr2J1Unu = Time.time;
																	if (54928 - 507013 == -452084)
																	{
																		continue;
																	}
																	this.nXTcrvxQtss = Time.time + (float)1;
																	if (284502 - 93516 == 190987)
																	{
																		continue;
																	}
																	this.ResetCompoundResult();
																	if (162811 - 182715 == -19903)
																	{
																		continue;
																	}
																	this.mState = eCompoundState.compound;
																	if (140148 - 323265 == -183116)
																	{
																		continue;
																	}
																	this.CompoundItem(3, this.DKkcrBjLBlf[this.zIocrT0NDvC], this.HOccrdTE67C, 0, 0);
																	if (23320 - 512238 == -488917)
																	{
																		continue;
																	}
																}
															}
														}
													}
													else if (eCompoundType2 == eCompoundType.Mole)
													{
														if (64169 - 40780 == 23390)
														{
															continue;
														}
														if (GUI.Button(new Rect((float)207, (float)480, (float)138, (float)104), string.Empty, this.j3GcrAVLddn))
														{
															if (180834 - 382459 != -201625)
															{
																continue;
															}
															if (isButton)
															{
																if (68423 - 524102 != -455679)
																{
																	continue;
																}
																if (CharacterData.current.getEmptyInventorySlot() == -1)
																{
																	if (176666 - 429321 == -252654)
																	{
																		continue;
																	}
																	this.newNoticeBar("Need an empty slot", 2f);
																	if (19266 - 328870 != -309604)
																	{
																		continue;
																	}
																}
																else
																{
																	this.GRYcr2J1Unu = Time.time;
																	if (141775 - 558404 == -416628)
																	{
																		continue;
																	}
																	this.nXTcrvxQtss = Time.time + (float)1;
																	if (201570 - 35821 != 165749)
																	{
																		continue;
																	}
																	this.ResetCompoundResult();
																	if (136862 - 497969 != -361107)
																	{
																		continue;
																	}
																	this.mState = eCompoundState.compound;
																	if (284037 - 503097 != -219060)
																	{
																		continue;
																	}
																	this.CompoundItem(4, this.DKkcrBjLBlf[this.zIocrT0NDvC], this.HOccrdTE67C, 0, 0);
																	if (132309 - 324299 != -191990)
																	{
																		continue;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
									if (this.Giacrbn8Tbj != 0)
									{
										break;
									}
									if (62366 - 299305 == -236938)
									{
										continue;
									}
									if (!(text != "none"))
									{
										break;
									}
									if (200738 - 224152 == -23413)
									{
										continue;
									}
									Guix.renderTextOutline(rect, text, this.Ef2cxDStxyK);
									if (112313 - 400251 != -287938)
									{
										continue;
									}
									GUI.Label(rect, text, this.ETXcxi8KJqh);
									if (94156 - 422836 != -328680)
									{
										continue;
									}
									break;
									IL_179E:
									if (!GUI.Button(new Rect((float)420, (float)397, (float)85, (float)57), string.Empty, this.VYHcryME8Jq))
									{
										goto IL_1085;
									}
									if (37719 - 454082 != -416362)
									{
										if (!isButton)
										{
											goto IL_1085;
										}
										if (4003 - 381266 != -377262)
										{
											if (this.ou5crYWkIIq < global::Math.div((float)Extensions.get_length(this.DKkcrBjLBlf), (float)24))
											{
												if (32786 - 179370 != -146584)
												{
													continue;
												}
												this.ou5crYWkIIq++;
												if (69615 - 570802 != -501187)
												{
													continue;
												}
												this.zIocrT0NDvC = -1;
												if (54362 - 101304 != -46942)
												{
													continue;
												}
												this.ResetIngredientMenu();
												if (82188 - 272670 != -190482)
												{
													continue;
												}
											}
											this.audio.PlayOneShot(this.qkDcr4HI1fn);
											if (78918 - 51982 == 26936)
											{
												goto IL_1085;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006044 RID: 24644 RVA: 0x00CF94E4 File Offset: 0x00CF76E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitIngredientMenu()
	{
		if (38193 - 358766 != -320572)
		{
		}
		for (;;)
		{
			IL_BB:
			this.nrUcxt9jRvd = new HoverButtonClass[8];
			if (251868 - 181974 == 69894)
			{
				int i = 0;
				if (234873 - 275950 != -41076)
				{
					while (i < 8)
					{
						this.nrUcxt9jRvd[i] = new HoverButtonClass();
						if (111458 - 564626 == -453167)
						{
							goto IL_BB;
						}
						i++;
						if (266938 - 223876 == 43063)
						{
							goto IL_BB;
						}
					}
					if (31246 - 423989 == -392743)
					{
						this.BSucxlJ0Eda = (Texture)Resources.Load("GameGui/Compound/plus_h", typeof(Texture));
						if (55395 - 287637 == -232242)
						{
							this.XjNcxG2ERut = new GUIStyle();
							if (211106 - 413355 == -202249)
							{
								this.XjNcxG2ERut.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
								if (292800 - 251214 != 41587)
								{
									this.XjNcxG2ERut.normal.textColor = new Color(0.63f, 0.98f, (float)1, (float)1);
									if (89193 - 253370 != -164176)
									{
										this.XjNcxG2ERut.alignment = TextAnchor.UpperLeft;
										if (5229 - 403267 != -398037)
										{
											this.XjNcxG2ERut.wordWrap = true;
											if (211844 - 7836 != 204009)
											{
												this.rMjcx11LFCP = new GUIStyle();
												if (229937 - 150639 == 79298)
												{
													this.rMjcx11LFCP.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
													if (264024 - 338224 == -74200)
													{
														this.rMjcx11LFCP.normal.textColor = new Color(0.99f, 0.45f, 0.42f, (float)1);
														if (116866 - 550505 == -433639)
														{
															this.rMjcx11LFCP.alignment = TextAnchor.UpperLeft;
															if (283953 - 223134 != 60820)
															{
																this.rMjcx11LFCP.wordWrap = true;
																if (253526 - 222199 == 31327)
																{
																	this.lbIcxq74lF5 = new GUIStyle();
																	if (122257 - 33335 == 88922)
																	{
																		this.lbIcxq74lF5.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																		if (109740 - 394200 != -284459)
																		{
																			this.lbIcxq74lF5.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																			if (262514 - 350584 != -88069)
																			{
																				this.lbIcxq74lF5.alignment = TextAnchor.UpperLeft;
																				if (156736 - 292502 == -135766)
																				{
																					this.lbIcxq74lF5.wordWrap = true;
																					if (160427 - 564399 != -403971)
																					{
																						this.Uudcxp1WRnt = (Texture)Resources.Load("GameGui/Compound/drop", typeof(Texture));
																						if (91143 - 548493 == -457350)
																						{
																							this.uO7cxRbMM99 = (Texture)Resources.Load("GameGui/Compound/drop_h", typeof(Texture));
																							if (214585 - 484658 != -270072)
																							{
																								this.J7gcxr8NlZU = (Texture)Resources.Load("GameGui/Compound/replica", typeof(Texture));
																								if (187738 - 567066 != -379327)
																								{
																									this.vaacxxPeE9K = (Texture)Resources.Load("GameGui/Compound/replica_h", typeof(Texture));
																									if (111253 - 221617 != -110363)
																									{
																										this.JmUcxTbKtGP = 0;
																										if (78117 - 228020 != -149902)
																										{
																											this.dRUcxYCZKqM = 0;
																											if (154509 - 322603 != -168093)
																											{
																												this.yZDcx3Tj4gB = new IconButtonClass();
																												if (262639 - 402470 == -139831)
																												{
																													this.gUecxbZxwk7 = new IconButtonClass();
																													if (291848 - 550091 != -258242)
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

	// Token: 0x06006045 RID: 24645 RVA: 0x00CF9A3C File Offset: 0x00CF7C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetIngredientMenu()
	{
		if (21526 - 427944 != -406418)
		{
		}
		for (;;)
		{
			IL_5B4:
			this.kVVcx6PSuUF = null;
			if (95481 - 431083 != -335601)
			{
				this.nC5cxXFYb2P = null;
				if (35800 - 373271 == -337471)
				{
					this.aVJcxOdyxmb = null;
					if (119440 - 71946 != 47495)
					{
						this.xQVcx2CcXLZ = null;
						if (109029 - 213031 == -104002)
						{
							this.xZ8cxvWq8Dx = null;
							if (25819 - 12291 == 13528)
							{
								this.JmUcxTbKtGP = 0;
								if (122723 - 141367 != -18643)
								{
									this.dRUcxYCZKqM = 0;
									if (167920 - 107520 == 60400)
									{
										this.yZDcx3Tj4gB.reset();
										if (273535 - 113234 == 160301)
										{
											this.gUecxbZxwk7.reset();
											if (209797 - 37227 != 172571)
											{
												if (this.zIocrT0NDvC == -1)
												{
													break;
												}
												if (164478 - 18805 == 145673)
												{
													if (this.zIocrT0NDvC >= Extensions.get_length(this.DKkcrBjLBlf))
													{
														break;
													}
													if (282222 - 402090 != -119867)
													{
														this.kVVcx6PSuUF = ItemData.getItemData(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
														if (152391 - 505453 == -353062)
														{
															CharacterDataClass current = CharacterData.current;
															if (19657 - 466457 != -446799)
															{
																string text = null;
																if (259283 - 595128 != -335844)
																{
																	eCompoundType eCompoundType = this.mType;
																	if (282980 - 91232 != 191749)
																	{
																		if (eCompoundType == eCompoundType.Crocodile)
																		{
																			if (235304 - 578800 != -343496)
																			{
																				continue;
																			}
																			text = CompoundData.getMaterial(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
																			if (80428 - 499809 != -419381)
																			{
																				continue;
																			}
																		}
																		else if (eCompoundType == eCompoundType.Humpback)
																		{
																			if (66417 - 270336 != -203919)
																			{
																				continue;
																			}
																			text = CookingData.getIngredient(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
																			if (50234 - 288675 != -238441)
																			{
																				continue;
																			}
																		}
																		else if (eCompoundType == eCompoundType.Rabbit)
																		{
																			if (31715 - 520498 != -488783)
																			{
																				continue;
																			}
																			text = AlchemistData.getIngredient(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
																			if (159809 - 39562 != 120247)
																			{
																				continue;
																			}
																		}
																		else if (eCompoundType == eCompoundType.Mole)
																		{
																			if (82075 - 133586 == -51510)
																			{
																				continue;
																			}
																			text = GadgetData.getIngredient(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
																			if (285477 - 584638 == -299160)
																			{
																				continue;
																			}
																		}
																		if (!(text != "none"))
																		{
																			break;
																		}
																		if (258266 - 569435 != -311168)
																		{
																			string[] array = (string[])Stringf.splitToArray(text, ",").ToBuiltin(typeof(string));
																			if (107191 - 372698 == -265507)
																			{
																				if (Extensions.get_length(array) <= 0)
																				{
																					break;
																				}
																				if (126316 - 571081 == -444765)
																				{
																					this.nC5cxXFYb2P = new string[Extensions.get_length(array)];
																					if (171725 - 397768 != -226042)
																					{
																						this.aVJcxOdyxmb = new int[Extensions.get_length(array)];
																						if (197547 - 249661 != -52113)
																						{
																							this.xQVcx2CcXLZ = new Texture[Extensions.get_length(array)];
																							if (244096 - 557979 != -313882)
																							{
																								this.xZ8cxvWq8Dx = new bool[Extensions.get_length(array)];
																								if (4391 - 336316 == -331925)
																								{
																									int i = 0;
																									if (201772 - 197817 == 3955)
																									{
																										while (i < Extensions.get_length(array))
																										{
																											string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
																											if (278440 - 108927 == 169514)
																											{
																												goto IL_5B4;
																											}
																											if (Extensions.get_length(array2) > 0)
																											{
																												if (22282 - 108982 == -86699)
																												{
																													goto IL_5B4;
																												}
																												this.nC5cxXFYb2P[i] = array2[0];
																												if (195913 - 395813 != -199900)
																												{
																													goto IL_5B4;
																												}
																											}
																											if (Extensions.get_length(array2) > 1)
																											{
																												if (123289 - 375008 == -251718)
																												{
																													goto IL_5B4;
																												}
																												this.aVJcxOdyxmb[i] = Mathf.Clamp(Stringf.getInteger(array2[1]), 0, 12);
																												if (80077 - 311268 == -231190)
																												{
																													goto IL_5B4;
																												}
																											}
																											else
																											{
																												this.aVJcxOdyxmb[i] = 1;
																												if (93831 - 442168 == -348336)
																												{
																													goto IL_5B4;
																												}
																											}
																											this.xQVcx2CcXLZ[i] = IconButton.getIconImage(array2[0]);
																											if (178807 - 166910 == 11898)
																											{
																												goto IL_5B4;
																											}
																											this.xZ8cxvWq8Dx[i] = true;
																											if (196657 - 352438 != -155781)
																											{
																												goto IL_5B4;
																											}
																											if (this.nC5cxXFYb2P[i] != string.Empty)
																											{
																												if (8135 - 84954 == -76818)
																												{
																													goto IL_5B4;
																												}
																												if (this.nC5cxXFYb2P[i] != "none")
																												{
																													if (145785 - 568776 == -422990)
																													{
																														goto IL_5B4;
																													}
																													if (this.aVJcxOdyxmb[i] > 0)
																													{
																														if (36376 - 215315 == -178938)
																														{
																															goto IL_5B4;
																														}
																														if (current.getItemTotalNum(this.nC5cxXFYb2P[i]) < this.aVJcxOdyxmb[i])
																														{
																															if (169190 - 513337 != -344147)
																															{
																																goto IL_5B4;
																															}
																															this.xZ8cxvWq8Dx[i] = false;
																															if (99634 - 462753 == -363118)
																															{
																																goto IL_5B4;
																															}
																														}
																													}
																												}
																											}
																											i++;
																											if (291377 - 315072 == -23694)
																											{
																												goto IL_5B4;
																											}
																										}
																										if (172208 - 169310 == 2898)
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

	// Token: 0x06006046 RID: 24646 RVA: 0x00CFA1D0 File Offset: 0x00CF83D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderIngredientMenu()
	{
		if (57386 - 48758 != 8629)
		{
		}
		for (;;)
		{
			IL_839:
			if (this.zIocrT0NDvC == -1)
			{
				if (199037 - 210140 != -11102)
				{
					break;
				}
			}
			else
			{
				string text = "none";
				if (57213 - 215262 != -158048)
				{
					Rect rect = default(Rect);
					if (127766 - 485487 != -357720)
					{
						if (!RuntimeServices.EqualityOperator(this.kVVcx6PSuUF, null))
						{
							if (117352 - 149018 == -31665)
							{
								continue;
							}
							GUI.Label(new Rect((float)680, (float)68, (float)300, (float)50), this.kVVcx6PSuUF.name, this.pkWcxMjBVZ5);
							if (46612 - 231500 != -184888)
							{
								continue;
							}
							GUI.Label(new Rect((float)700, (float)160, (float)240, (float)300), this.kVVcx6PSuUF.des, this.f2Scxfm2gyh);
							if (27147 - 13285 != 13862)
							{
								continue;
							}
						}
						if (!RuntimeServices.EqualityOperator(this.nC5cxXFYb2P, null))
						{
							if (70992 - 296725 == -225732)
							{
								continue;
							}
							int i = 0;
							if (44307 - 443353 == -399045)
							{
								continue;
							}
							while (i < Mathf.Clamp(Extensions.get_length(this.nC5cxXFYb2P), 0, 8))
							{
								Rect rect2 = new Rect((float)(668 + i % 4 * 80), (float)(276 + global::Math.div((float)i, (float)4) * 66), (float)64, (float)64);
								if (224519 - 534037 == -309517)
								{
									goto IL_839;
								}
								if (Stringf.getString(this.nC5cxXFYb2P[i], 0, 5) != "s_emp")
								{
									if (17130 - 21917 == -4786)
									{
										goto IL_839;
									}
									if (this.xQVcx2CcXLZ[i])
									{
										if (33949 - 529221 == -495271)
										{
											goto IL_839;
										}
										GUI.DrawTexture(rect2, this.xQVcx2CcXLZ[i]);
										if (63612 - 548390 == -484777)
										{
											goto IL_839;
										}
									}
									if (i % 4 != 0)
									{
										if (205130 - 514264 == -309133)
										{
											goto IL_839;
										}
										GUI.DrawTexture(new Rect((float)(650 + i % 4 * 80), (float)(298 + global::Math.div((float)i, (float)4) * 66), (float)20, (float)20), this.BSucxlJ0Eda);
										if (279533 - 63155 != 216378)
										{
											goto IL_839;
										}
									}
									eHoverButtonState eHoverButtonState = HoverButton.newButton(this.nrUcxt9jRvd[i], new Rect(rect2.x + (float)7, rect2.y + (float)7, (float)50, (float)50), (float)0);
									if (226355 - 241067 != -14712)
									{
										goto IL_839;
									}
									if (eHoverButtonState == eHoverButtonState.over)
									{
										goto IL_1047;
									}
									if (4888 - 310805 != -305917)
									{
										goto IL_839;
									}
									if (eHoverButtonState == eHoverButtonState.hover)
									{
										if (169104 - 477252 != -308147)
										{
											goto IL_1047;
										}
										goto IL_839;
									}
									IL_15E9:
									Guix.renderTextOutline(new Rect(rect2.x + (float)45, rect2.y + (float)35, (float)60, (float)30), "x" + this.aVJcxOdyxmb[i], this.lbIcxq74lF5);
									if (139126 - 200917 != -61790)
									{
										if (this.xZ8cxvWq8Dx[i])
										{
											if (224666 - 30678 != 193988)
											{
												goto IL_839;
											}
											GUI.Label(new Rect(rect2.x + (float)45, rect2.y + (float)35, (float)60, (float)30), "x" + this.aVJcxOdyxmb[i], this.XjNcxG2ERut);
											if (285349 - 573040 != -287691)
											{
												goto IL_839;
											}
										}
										else
										{
											GUI.Label(new Rect(rect2.x + (float)45, rect2.y + (float)35, (float)60, (float)30), "x" + this.aVJcxOdyxmb[i], this.rMjcx11LFCP);
											if (287955 - 588415 == -300459)
											{
												goto IL_839;
											}
										}
										goto IL_FC7;
									}
									goto IL_839;
									IL_1047:
									text = ItemData.getName(this.nC5cxXFYb2P[i]);
									if (33437 - 528321 != -494884)
									{
										goto IL_839;
									}
									rect = new Rect(rect2.x - (float)120, rect2.y + (float)51, (float)300, (float)30);
									if (156541 - 518109 != -361567)
									{
										goto IL_15E9;
									}
									goto IL_839;
								}
								else if (i == 0)
								{
									if (209460 - 303747 != -94287)
									{
										goto IL_839;
									}
									eIconButtonState eIconButtonState = IconButton.IconButton(this.yZDcx3Tj4gB, rect2);
									if (170414 - 470935 == -300520)
									{
										goto IL_839;
									}
									if (eIconButtonState == eIconButtonState.none)
									{
										if (260240 - 46423 != 213817)
										{
											goto IL_839;
										}
										goto IL_100B;
									}
									else if (eIconButtonState == eIconButtonState.press)
									{
										if (274517 - 390976 != -116459)
										{
											goto IL_839;
										}
										goto IL_100B;
									}
									else
									{
										if (eIconButtonState == eIconButtonState.hover)
										{
											if (46688 - 57634 == -10945)
											{
												goto IL_839;
											}
										}
										else if (eIconButtonState == eIconButtonState.over)
										{
											if (228372 - 222696 == 5677)
											{
												goto IL_839;
											}
										}
										else if (eIconButtonState == eIconButtonState.drop)
										{
											if (248315 - 32504 == 215812)
											{
												goto IL_839;
											}
											GUI.DrawTexture(new Rect((float)664, (float)262, (float)72, (float)81), this.uO7cxRbMM99);
											if (97173 - 399672 != -302499)
											{
												goto IL_839;
											}
											if (this.Giacrbn8Tbj != 0)
											{
												if (242683 - 458446 == -215762)
												{
													goto IL_839;
												}
												string name = CharacterData.current.inventory[this.Giacrbn8Tbj - 20].name;
												if (104409 - 77450 == 26960)
												{
													goto IL_839;
												}
												if (this.mType == eCompoundType.Crocodile)
												{
													if (78133 - 520890 == -442756)
													{
														goto IL_839;
													}
													if (this.mPage == eCompoundPage.special)
													{
														if (30156 - 148495 != -118339)
														{
															goto IL_839;
														}
														string a = this.DKkcrBjLBlf[this.zIocrT0NDvC].Substring(0, 5);
														if (218411 - 291058 == -72646)
														{
															goto IL_839;
														}
														if (!(a == "s_rnw"))
														{
															if (a == "s_rsl")
															{
																if (208181 - 304709 == -96527)
																{
																	goto IL_839;
																}
															}
															else if (a == "s_asl")
															{
																if (94494 - 486215 != -391721)
																{
																	goto IL_839;
																}
															}
															else if (a == "s_rpc")
															{
																if (251311 - 344426 == -93114)
																{
																	goto IL_839;
																}
															}
															else
															{
																string heading = Stringf.getHeading(name);
																if (219681 - 577274 != -357593)
																{
																	goto IL_839;
																}
																if (heading == "w")
																{
																	if (12088 - 3741 != 8347)
																	{
																		goto IL_839;
																	}
																	goto IL_239;
																}
																else if (heading == "a")
																{
																	if (164474 - 2433 != 162041)
																	{
																		goto IL_839;
																	}
																	goto IL_239;
																}
																else if (heading == "c")
																{
																	if (38115 - 293413 != -255298)
																	{
																		goto IL_839;
																	}
																	goto IL_D36;
																}
																else
																{
																	this.newNoticeBar("Only for weapon, armor, or accessory", 2f);
																	if (46963 - 324564 == -277600)
																	{
																		goto IL_839;
																	}
																}
																IL_CB5:
																goto IL_CBA;
																IL_D36:
																if (CharacterData.current.inventory[this.Giacrbn8Tbj - 20].lv < Mathf.Abs(CharacterData.current.inventory[this.Giacrbn8Tbj - 20].mlv))
																{
																	if (70373 - 110441 == -40067)
																	{
																		goto IL_839;
																	}
																	this.audio.PlayOneShot(this.RxHcrHFisne);
																	if (5368 - 194961 != -189593)
																	{
																		goto IL_839;
																	}
																	this.JmUcxTbKtGP = this.Giacrbn8Tbj;
																	if (258980 - 298371 != -39391)
																	{
																		goto IL_839;
																	}
																	this.yZDcx3Tj4gB.name = name;
																	if (115072 - 167842 == -52769)
																	{
																		goto IL_839;
																	}
																	this.yZDcx3Tj4gB.command = this.Giacrbn8Tbj;
																	if (34462 - 565460 == -530997)
																	{
																		goto IL_839;
																	}
																	this.yZDcx3Tj4gB.image = (Texture2D)IconButton.getIconImage(name);
																	if (103387 - 17504 == 85884)
																	{
																		goto IL_839;
																	}
																}
																else
																{
																	this.newNoticeBar("Item has no slot for compounding", 2f);
																	if (73332 - 404349 != -331017)
																	{
																		goto IL_839;
																	}
																}
																goto IL_CB5;
																IL_239:
																goto IL_D36;
															}
															IL_1372:
															string heading2 = Stringf.getHeading(name);
															if (19621 - 209281 != -189660)
															{
																goto IL_839;
															}
															if (heading2 == "w")
															{
																if (82307 - 388158 != -305850)
																{
																	goto IL_1757;
																}
																goto IL_839;
															}
															else if (heading2 == "a")
															{
																if (200995 - 35804 != 165191)
																{
																	goto IL_839;
																}
																goto IL_1757;
															}
															else if (heading2 == "c")
															{
																if (69918 - 413289 != -343370)
																{
																	goto IL_19DF;
																}
																goto IL_839;
															}
															else
															{
																this.newNoticeBar("Only for weapon, armor, or accessory", 2f);
																if (139193 - 11479 == 127715)
																{
																	goto IL_839;
																}
															}
															IL_14EA:
															goto IL_CBA;
															IL_19DF:
															if (Mathf.Abs(ItemData.getItemData(name).lv) > Stringf.getLastDigit(this.DKkcrBjLBlf[this.zIocrT0NDvC]) * 30)
															{
																if (220492 - 470006 != -249514)
																{
																	goto IL_839;
																}
																this.newNoticeBar("Item level too high", 2f);
																if (201204 - 104309 != 96895)
																{
																	goto IL_839;
																}
															}
															else
															{
																if (this.DKkcrBjLBlf[this.zIocrT0NDvC].Substring(0, 5) == "s_asl")
																{
																	if (133063 - 203582 != -70519)
																	{
																		goto IL_839;
																	}
																	if (CharacterData.current.inventory[this.Giacrbn8Tbj - 20].lv != 0)
																	{
																		if (242507 - 520764 == -278256)
																		{
																			goto IL_839;
																		}
																		this.newNoticeBar("Need to reslot before adding", 2f);
																		if (223649 - 574311 != -350661)
																		{
																			goto IL_F22;
																		}
																		goto IL_839;
																	}
																}
																this.audio.PlayOneShot(this.RxHcrHFisne);
																if (260251 - 389912 != -129661)
																{
																	goto IL_839;
																}
																this.JmUcxTbKtGP = this.Giacrbn8Tbj;
																if (85836 - 115669 == -29832)
																{
																	goto IL_839;
																}
																this.yZDcx3Tj4gB.name = name;
																if (92379 - 599285 == -506905)
																{
																	goto IL_839;
																}
																this.yZDcx3Tj4gB.command = this.Giacrbn8Tbj;
																if (272288 - 8847 == 263442)
																{
																	goto IL_839;
																}
																this.yZDcx3Tj4gB.image = (Texture2D)IconButton.getIconImage(name);
																if (124087 - 196781 == -72693)
																{
																	goto IL_839;
																}
															}
															IL_F22:
															goto IL_14EA;
															IL_1757:
															goto IL_19DF;
															goto IL_1372;
														}
														if (155387 - 137700 != 17687)
														{
															goto IL_839;
														}
														string heading3 = Stringf.getHeading(name);
														if (223223 - 591556 != -368332)
														{
															if (heading3 == "w")
															{
																if (259897 - 443345 != -183448)
																{
																	goto IL_839;
																}
																goto IL_6E9;
															}
															else if (heading3 == "a")
															{
																if (201424 - 181469 != 19956)
																{
																	goto IL_6E9;
																}
																goto IL_839;
															}
															else if (heading3 == "c")
															{
																if (168 - 386447 != -386279)
																{
																	goto IL_839;
																}
																goto IL_1468;
															}
															else if (heading3 == "b")
															{
																if (126146 - 180348 != -54202)
																{
																	goto IL_839;
																}
																goto IL_4B0;
															}
															else if (heading3 == "t")
															{
																if (200990 - 548165 != -347175)
																{
																	goto IL_839;
																}
																goto IL_332;
															}
															else if (heading3 == "p")
															{
																if (294127 - 172217 != 121911)
																{
																	goto IL_11FD;
																}
																goto IL_839;
															}
															else
															{
																this.newNoticeBar("Only equipment can be used", 2f);
																if (155524 - 572317 != -416793)
																{
																	goto IL_839;
																}
															}
															IL_480:
															goto IL_CBA;
															IL_11FD:
															if (Mathf.Abs(ItemData.getItemData(name).lv) <= Stringf.getLastDigit(this.DKkcrBjLBlf[this.zIocrT0NDvC]) * 30)
															{
																if (72362 - 110093 != -37731)
																{
																	goto IL_839;
																}
																this.audio.PlayOneShot(this.RxHcrHFisne);
																if (106113 - 357220 != -251107)
																{
																	goto IL_839;
																}
																this.JmUcxTbKtGP = this.Giacrbn8Tbj;
																if (70133 - 17092 == 53042)
																{
																	goto IL_839;
																}
																this.yZDcx3Tj4gB.name = name;
																if (29394 - 537120 != -507726)
																{
																	goto IL_839;
																}
																this.yZDcx3Tj4gB.command = this.Giacrbn8Tbj;
																if (89614 - 590757 != -501143)
																{
																	goto IL_839;
																}
																this.yZDcx3Tj4gB.image = (Texture2D)IconButton.getIconImage(name);
																if (236283 - 165310 == 70974)
																{
																	goto IL_839;
																}
															}
															else
															{
																this.newNoticeBar("Item level too high", 2f);
																if (137697 - 438319 != -300622)
																{
																	goto IL_839;
																}
															}
															goto IL_480;
															IL_332:
															goto IL_11FD;
															IL_4B0:
															goto IL_332;
															IL_1468:
															goto IL_4B0;
															IL_6E9:
															goto IL_1468;
														}
														goto IL_839;
													}
												}
												IL_CBA:
												this.Giacrbn8Tbj = 0;
												if (156917 - 128917 == 28001)
												{
													goto IL_839;
												}
											}
											goto IL_1816;
										}
										else
										{
											if (eIconButtonState != eIconButtonState.drag)
											{
												goto IL_1816;
											}
											if (120726 - 515381 == -394654)
											{
												goto IL_839;
											}
											this.JmUcxTbKtGP = 0;
											if (181903 - 499137 != -317234)
											{
												goto IL_839;
											}
											this.Giacrbn8Tbj = this.yZDcx3Tj4gB.command;
											if (234790 - 372723 == -137932)
											{
												goto IL_839;
											}
											this.yZDcx3Tj4gB.state = eIconButtonState.none;
											if (78741 - 220232 != -141491)
											{
												goto IL_839;
											}
											this.yZDcx3Tj4gB.name = "none";
											if (229675 - 24219 != 205456)
											{
												goto IL_839;
											}
											this.yZDcx3Tj4gB.command = 0;
											if (250412 - 593100 != -342688)
											{
												goto IL_839;
											}
											this.yZDcx3Tj4gB.image = null;
											if (49598 - 312531 != -262932)
											{
												goto IL_1816;
											}
											goto IL_839;
										}
										if (this.Giacrbn8Tbj != 0)
										{
											if (203767 - 248169 != -44402)
											{
												goto IL_839;
											}
											GUI.DrawTexture(new Rect((float)664, (float)262, (float)72, (float)81), this.uO7cxRbMM99);
											if (82768 - 538365 == -455596)
											{
												goto IL_839;
											}
										}
										else
										{
											GUI.DrawTexture(new Rect((float)664, (float)262, (float)72, (float)81), this.Uudcxp1WRnt);
											if (144408 - 136131 != 8277)
											{
												goto IL_839;
											}
										}
										if (this.yZDcx3Tj4gB.image)
										{
											if (164592 - 84592 == 80001)
											{
												goto IL_839;
											}
											GUI.DrawTexture(rect2, this.yZDcx3Tj4gB.image);
											if (295625 - 553828 != -258203)
											{
												goto IL_839;
											}
										}
									}
									IL_1816:
									goto IL_FC7;
									IL_100B:
									GUI.DrawTexture(new Rect((float)664, (float)262, (float)72, (float)81), this.Uudcxp1WRnt);
									if (268093 - 10260 != 257833)
									{
										goto IL_839;
									}
									if (this.yZDcx3Tj4gB.image)
									{
										if (866 - 474150 == -473283)
										{
											goto IL_839;
										}
										GUI.DrawTexture(rect2, this.yZDcx3Tj4gB.image);
										if (137591 - 373716 != -236125)
										{
											goto IL_839;
										}
									}
								}
								else if (i == 1)
								{
									if (263636 - 216326 == 47311)
									{
										goto IL_839;
									}
									GUI.DrawTexture(new Rect((float)(650 + i % 4 * 80), (float)(298 + global::Math.div((float)i, (float)4) * 66), (float)20, (float)20), this.BSucxlJ0Eda);
									if (198877 - 322935 == -124057)
									{
										goto IL_839;
									}
									eIconButtonState eIconButtonState2 = IconButton.IconButton(this.gUecxbZxwk7, rect2);
									if (274606 - 562425 != -287819)
									{
										goto IL_839;
									}
									if (eIconButtonState2 == eIconButtonState.none)
									{
										if (275372 - 387615 == -112242)
										{
											goto IL_839;
										}
									}
									else if (eIconButtonState2 == eIconButtonState.press)
									{
										if (187860 - 347829 != -159969)
										{
											goto IL_839;
										}
									}
									else
									{
										if (eIconButtonState2 == eIconButtonState.hover)
										{
											if (133866 - 24893 == 108974)
											{
												goto IL_839;
											}
										}
										else if (eIconButtonState2 == eIconButtonState.over)
										{
											if (91779 - 527945 == -436165)
											{
												goto IL_839;
											}
										}
										else if (eIconButtonState2 == eIconButtonState.drop)
										{
											if (110505 - 551284 == -440778)
											{
												goto IL_839;
											}
											GUI.DrawTexture(new Rect((float)744, (float)262, (float)72, (float)81), this.vaacxxPeE9K);
											if (240369 - 563688 != -323319)
											{
												goto IL_839;
											}
											if (this.Giacrbn8Tbj != 0)
											{
												if (70968 - 69557 != 1411)
												{
													goto IL_839;
												}
												string name2 = CharacterData.current.inventory[this.Giacrbn8Tbj - 20].name;
												if (12242 - 180658 != -168416)
												{
													goto IL_839;
												}
												if (this.mType == eCompoundType.Crocodile)
												{
													if (160537 - 37668 == 122870)
													{
														goto IL_839;
													}
													if (this.mPage == eCompoundPage.special)
													{
														if (28097 - 264167 != -236070)
														{
															goto IL_839;
														}
														string heading4 = Stringf.getHeading(name2);
														if (91955 - 321266 != -229311)
														{
															goto IL_839;
														}
														if (heading4 == "w")
														{
															if (275857 - 62098 == 213760)
															{
																goto IL_839;
															}
														}
														else if (heading4 == "a")
														{
															if (50163 - 565900 == -515736)
															{
																goto IL_839;
															}
														}
														else if (heading4 == "c")
														{
															if (129526 - 130205 == -678)
															{
																goto IL_839;
															}
														}
														else
														{
															this.newNoticeBar("Only for weapon, armor, or accessory", 2f);
															if (94749 - 424751 != -330002)
															{
																goto IL_839;
															}
															goto IL_E02;
														}
														IL_7B8:
														if (ItemData.getItemData(CharacterData.current.inventory[this.Giacrbn8Tbj - 20].name).lv <= Stringf.getLastDigit(this.DKkcrBjLBlf[this.zIocrT0NDvC]) * 30)
														{
															if (193219 - 578793 == -385573)
															{
																goto IL_839;
															}
															this.audio.PlayOneShot(this.RxHcrHFisne);
															if (149275 - 490459 != -341184)
															{
																goto IL_839;
															}
															this.dRUcxYCZKqM = this.Giacrbn8Tbj;
															if (7015 - 277472 != -270457)
															{
																goto IL_839;
															}
															this.gUecxbZxwk7.name = name2;
															if (158930 - 241070 != -82140)
															{
																goto IL_839;
															}
															this.gUecxbZxwk7.command = this.Giacrbn8Tbj;
															if (93412 - 147302 == -53889)
															{
																goto IL_839;
															}
															this.gUecxbZxwk7.image = (Texture2D)IconButton.getIconImage(name2);
															if (267435 - 60841 != 206594)
															{
																goto IL_839;
															}
														}
														else
														{
															this.newNoticeBar("Item level too high", 2f);
															if (121217 - 120054 != 1163)
															{
																goto IL_839;
															}
														}
														goto IL_E02;
														goto IL_7B8;
													}
												}
												IL_E02:
												this.Giacrbn8Tbj = 0;
												if (169261 - 45216 == 124046)
												{
													goto IL_839;
												}
											}
											goto IL_FC7;
										}
										else
										{
											if (eIconButtonState2 != eIconButtonState.drag)
											{
												goto IL_FC7;
											}
											if (44625 - 471338 == -426712)
											{
												goto IL_839;
											}
											this.dRUcxYCZKqM = 0;
											if (230350 - 164264 != 66086)
											{
												goto IL_839;
											}
											this.Giacrbn8Tbj = this.gUecxbZxwk7.command;
											if (238740 - 318804 == -80063)
											{
												goto IL_839;
											}
											this.gUecxbZxwk7.state = eIconButtonState.none;
											if (96959 - 198963 == -102003)
											{
												goto IL_839;
											}
											this.gUecxbZxwk7.name = "none";
											if (13816 - 416623 != -402807)
											{
												goto IL_839;
											}
											this.gUecxbZxwk7.command = 0;
											if (289065 - 410918 != -121853)
											{
												goto IL_839;
											}
											this.gUecxbZxwk7.image = null;
											if (100979 - 590332 != -489352)
											{
												goto IL_FC7;
											}
											goto IL_839;
										}
										GUI.DrawTexture(new Rect((float)744, (float)262, (float)72, (float)81), this.vaacxxPeE9K);
										if (142756 - 440551 != -297794)
										{
											if (this.gUecxbZxwk7.image)
											{
												if (283152 - 10767 == 272386)
												{
													goto IL_839;
												}
												GUI.DrawTexture(rect2, this.gUecxbZxwk7.image);
												if (183422 - 340134 == -156711)
												{
													goto IL_839;
												}
											}
											goto IL_FC7;
										}
										goto IL_839;
									}
									GUI.DrawTexture(new Rect((float)744, (float)262, (float)72, (float)81), this.J7gcxr8NlZU);
									if (155505 - 195391 == -39885)
									{
										goto IL_839;
									}
									if (this.gUecxbZxwk7.image)
									{
										if (240229 - 519502 != -279273)
										{
											goto IL_839;
										}
										GUI.DrawTexture(rect2, this.gUecxbZxwk7.image);
										if (279724 - 511764 == -232039)
										{
											goto IL_839;
										}
									}
								}
								IL_FC7:
								i++;
								if (240333 - 456084 != -215751)
								{
									goto IL_839;
								}
							}
							if (45725 - 167691 == -121965)
							{
								continue;
							}
							this.MICcxJiYOZ2 = (int)Mathf.Clamp((float)40 + 0.5f * (float)this.HOccrdTE67C, (float)0, (float)99);
							if (38019 - 77356 == -39336)
							{
								continue;
							}
							Guix.renderSmallNumber(876, 422, this.MICcxJiYOZ2, false, (float)1);
							if (222576 - 38697 == 183880)
							{
								continue;
							}
						}
						if (this.Giacrbn8Tbj != 0)
						{
							break;
						}
						if (101412 - 371695 != -270282)
						{
							if (!(text != "none"))
							{
								break;
							}
							if (206074 - 430531 == -224457)
							{
								Guix.renderTextOutline(rect, text, this.Ef2cxDStxyK);
								if (25331 - 277189 == -251858)
								{
									GUI.Label(rect, text, this.ETXcxi8KJqh);
									if (273417 - 46687 != 226731)
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

	// Token: 0x06006047 RID: 24647 RVA: 0x00CFBCAC File Offset: 0x00CF9EAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCompoundResult()
	{
		if (329 - 308069 != -307740)
		{
		}
		for (;;)
		{
			this.CbXcxduh5f2 = 0;
			if (212506 - 573910 == -361404)
			{
				this.resultSuccess = false;
				if (195300 - 385353 == -190053)
				{
					this.x9lcxaC7a6J = new ItemClass();
					if (268522 - 5392 == 263130)
					{
						this.JJgcx48BG35 = null;
						if (239093 - 121885 == 117208)
						{
							this.JvCcxsD5UaW = (Texture)Resources.Load("GameGui/Compound/progressBG", typeof(Texture));
							if (229096 - 138776 != 90321)
							{
								this.M4kcxHx8ttY = (Texture)Resources.Load("GameGui/Compound/progressBar", typeof(Texture));
								if (197329 - 366460 != -169130)
								{
									this.zAZcx7pYF2d = (Texture)Resources.Load("GameGui/Compound/progressTop", typeof(Texture));
									if (201593 - 71222 != 130372)
									{
										this.SZEcxZhdFMg = (Texture)Resources.Load("GameGui/Compound/success", typeof(Texture));
										if (27067 - 336059 != -308991)
										{
											this.Gg2cxCvsk7Q = (Texture)Resources.Load("GameGui/Compound/fail", typeof(Texture));
											if (107910 - 330564 == -222654)
											{
												this.pkWcxMjBVZ5 = new GUIStyle();
												if (184880 - 249610 != -64729)
												{
													this.pkWcxMjBVZ5.font = (Font)Resources.Load("GameGui/Fonts/Century22", typeof(Font));
													if (291487 - 286034 == 5453)
													{
														this.pkWcxMjBVZ5.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
														if (199933 - 416204 != -216270)
														{
															this.pkWcxMjBVZ5.alignment = TextAnchor.MiddleLeft;
															if (157313 - 482802 == -325489)
															{
																this.f2Scxfm2gyh = new GUIStyle();
																if (208819 - 506588 == -297769)
																{
																	this.f2Scxfm2gyh.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																	if (187904 - 356844 == -168940)
																	{
																		this.f2Scxfm2gyh.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																		if (62332 - 202840 != -140507)
																		{
																			this.f2Scxfm2gyh.alignment = TextAnchor.UpperLeft;
																			if (232865 - 277958 == -45093)
																			{
																				this.f2Scxfm2gyh.wordWrap = true;
																				if (212623 - 452229 != -239605)
																				{
																					this.upAcxLnGOwl = new GUIStyle();
																					if (51971 - 61760 != -9788)
																					{
																						this.upAcxLnGOwl.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
																						if (42970 - 458328 != -415357)
																						{
																							this.upAcxLnGOwl.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																							if (216247 - 462007 != -245759)
																							{
																								this.upAcxLnGOwl.alignment = TextAnchor.MiddleRight;
																								if (76964 - 468359 != -391394)
																								{
																									this.lcVcxwCTb0e = new GUIStyle();
																									if (293478 - 494962 == -201484)
																									{
																										this.lcVcxwCTb0e.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
																										if (163742 - 23564 == 140178)
																										{
																											this.lcVcxwCTb0e.normal.textColor = new Color(0.17f, 0.29f, 0.24f, (float)1);
																											if (204348 - 574052 == -369704)
																											{
																												this.lcVcxwCTb0e.alignment = TextAnchor.MiddleLeft;
																												if (18280 - 387347 == -369067)
																												{
																													this.p2ecxUnonf5 = new GUIStyle();
																													if (234467 - 29455 != 205013)
																													{
																														this.p2ecxUnonf5.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
																														if (122501 - 2739 == 119762)
																														{
																															this.p2ecxUnonf5.normal.textColor = new Color(0.5f, 0.1f, 0.1f, (float)1);
																															if (12758 - 84520 == -71762)
																															{
																																this.p2ecxUnonf5.alignment = TextAnchor.MiddleLeft;
																																if (130265 - 293173 != -162907)
																																{
																																	this.EhVcxE2UEAI = new GUIStyle();
																																	if (250621 - 593605 != -342983)
																																	{
																																		this.EhVcxE2UEAI.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/ok", typeof(Texture)));
																																		if (295233 - 464399 != -169165)
																																		{
																																			this.EhVcxE2UEAI.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Compound/ok_h", typeof(Texture)));
																																			if (43000 - 398325 != -355324)
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

	// Token: 0x06006048 RID: 24648 RVA: 0x00CFC344 File Offset: 0x00CFA544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetCompoundResult()
	{
		if (217883 - 396125 != -178242)
		{
		}
		for (;;)
		{
			this.CbXcxduh5f2 = 0;
			if (2104 - 496474 == -494370)
			{
				this.resultSuccess = false;
				if (148992 - 81734 != 67259)
				{
					this.x9lcxaC7a6J = new ItemClass();
					if (249722 - 424448 != -174725)
					{
						this.JJgcx48BG35 = null;
						if (299859 - 560380 != -260520)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006049 RID: 24649 RVA: 0x00CFC404 File Offset: 0x00CFA604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCompoundResult()
	{
		if (181162 - 147070 != 34093)
		{
		}
		for (;;)
		{
			IL_B74:
			if (this.CbXcxduh5f2 != 4)
			{
				if (119250 - 159119 != -39869)
				{
					continue;
				}
				if (Time.time < this.GRYcr2J1Unu + (float)3)
				{
					if (152380 - 566420 == -414039)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)187, (float)713, (float)190, (float)44), this.JvCcxsD5UaW);
					if (242985 - 30786 != 212199)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)208, (float)730, Mathf.Lerp((float)0, (float)150, (Time.time - this.GRYcr2J1Unu) / (float)3), (float)10), this.M4kcxHx8ttY);
					if (109765 - 215217 != -105452)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)193, (float)716, (float)182, (float)34), this.zAZcx7pYF2d);
					if (263594 - 546590 != -282995)
					{
						break;
					}
					continue;
				}
			}
			if (this.CbXcxduh5f2 == 0)
			{
				if (191650 - 136063 != 55588)
				{
					this.GRYcr2J1Unu = Time.time;
					if (238141 - 144152 != 93990)
					{
						break;
					}
				}
			}
			else if (this.CbXcxduh5f2 == 1)
			{
				if (146826 - 1835 != 144992)
				{
					this.CbXcxduh5f2 = 0;
					if (160287 - 381807 != -221519)
					{
						break;
					}
				}
			}
			else if (this.CbXcxduh5f2 == 2)
			{
				if (108221 - 558081 == -449860)
				{
					this.CbXcxduh5f2 = 4;
					if (151085 - 53791 != 97295)
					{
						if (this.audio)
						{
							if (138320 - 371454 == -233133)
							{
								continue;
							}
							this.audio.PlayOneShot((AudioClip)Resources.Load("Sound/Jingle/QuestComplete", typeof(AudioClip)));
							if (12152 - 133815 == -121662)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (131362 - 332178 == -200815)
							{
								continue;
							}
							if (this.IA6crE8aGHa)
							{
								if (57697 - 310890 == -253192)
								{
									continue;
								}
								this.audio.PlayOneShot(this.IA6crE8aGHa);
								if (271834 - 130389 != 141445)
								{
									continue;
								}
							}
						}
						this.resultSuccess = true;
						if (243006 - 340891 == -97885)
						{
							this.GRYcr2J1Unu = Time.time;
							if (182405 - 433403 == -250998)
							{
								this.ResetIngredientMenu();
								if (36211 - 443676 == -407465)
								{
									this.ResetCompoundInventory();
									if (239163 - 527693 != -288529)
									{
										this.ResetPossibleList();
										if (223799 - 456005 != -232205)
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
			else if (this.CbXcxduh5f2 == 3)
			{
				if (173573 - 541387 != -367813)
				{
					this.CbXcxduh5f2 = 4;
					if (185885 - 543180 != -357294)
					{
						if (this.audio)
						{
							if (96387 - 130513 != -34126)
							{
								continue;
							}
							this.audio.PlayOneShot((AudioClip)Resources.Load("Sound/Jingle/QuestFail", typeof(AudioClip)));
							if (90199 - 67647 != 22552)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (260028 - 192684 == 67345)
							{
								continue;
							}
							if (this.zljcrPDCUkr)
							{
								if (64861 - 477959 != -413098)
								{
									continue;
								}
								this.audio.PlayOneShot(this.zljcrPDCUkr);
								if (248142 - 103812 == 144331)
								{
									continue;
								}
							}
						}
						this.resultSuccess = false;
						if (173107 - 440750 == -267643)
						{
							this.GRYcr2J1Unu = Time.time;
							if (134686 - 224078 == -89392)
							{
								this.ResetIngredientMenu();
								if (56017 - 102332 == -46315)
								{
									this.ResetCompoundInventory();
									if (253053 - 340165 == -87112)
									{
										this.ResetPossibleList();
										if (13757 - 223247 == -209490)
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
				if (this.x9lcxaC7a6J.name != "none")
				{
					if (211516 - 200090 != 11426)
					{
						continue;
					}
					GUI.Label(new Rect((float)345, (float)575, (float)300, (float)50), this.x9lcxaC7a6J.name, this.pkWcxMjBVZ5);
					if (89558 - 29195 == 60364)
					{
						continue;
					}
					GUI.Label(new Rect((float)360, (float)615, (float)240, (float)300), this.x9lcxaC7a6J.des, this.f2Scxfm2gyh);
					if (192462 - 326679 != -134217)
					{
						continue;
					}
					if (this.JJgcx48BG35)
					{
						if (245893 - 349640 == -103746)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)245, (float)613, (float)64, (float)64), this.JJgcx48BG35);
						if (83252 - 122251 == -38998)
						{
							continue;
						}
					}
				}
				string heading = Stringf.getHeading(this.x9lcxaC7a6J.name);
				if (279494 - 592980 == -313486)
				{
					if (heading == "w")
					{
						if (76426 - 400195 != -323769)
						{
							continue;
						}
						goto IL_8DB;
					}
					else if (heading == "a")
					{
						if (183339 - 226244 != -42904)
						{
							goto IL_8DB;
						}
						continue;
					}
					else if (heading == "c")
					{
						if (199854 - 410517 != -210663)
						{
							continue;
						}
						goto IL_392;
					}
					else if (heading == "b")
					{
						if (43141 - 506889 != -463748)
						{
							continue;
						}
						goto IL_316;
					}
					else if (heading == "t")
					{
						if (286598 - 193519 != 93080)
						{
							goto IL_283;
						}
						continue;
					}
					else if (heading == "p")
					{
						if (236465 - 446635 != -210170)
						{
							continue;
						}
						goto IL_51F;
					}
					else
					{
						int i = 0;
						if (148296 - 560116 != -411820)
						{
							continue;
						}
						while (i < 8)
						{
							GUI.Label(new Rect((float)(396 + 100 * (i % 2)), (float)(694 + 26 * global::Math.div((float)i, (float)2)), (float)60, (float)25), "-", this.upAcxLnGOwl);
							if (145974 - 219190 != -73216)
							{
								goto IL_B74;
							}
							i++;
							if (198394 - 190732 == 7663)
							{
								goto IL_B74;
							}
						}
						if (76588 - 427220 == -350631)
						{
							continue;
						}
					}
					IL_1CC:
					if (Time.time < this.GRYcr2J1Unu + (float)3)
					{
						if (40020 - 423624 != -383604)
						{
							continue;
						}
						if (this.resultSuccess)
						{
							if (221068 - 399921 == -178852)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)205, (float)712, (float)166, (float)40), this.SZEcxZhdFMg);
							if (15326 - 358521 != -343195)
							{
								continue;
							}
							break;
						}
						else
						{
							GUI.DrawTexture(new Rect((float)215, (float)712, (float)134, (float)40), this.Gg2cxCvsk7Q);
							if (192830 - 20166 != 172665)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						if (!GUI.Button(new Rect((float)236, (float)712, (float)80, (float)37), string.Empty, this.EhVcxE2UEAI))
						{
							break;
						}
						if (164001 - 181494 == -17492)
						{
							continue;
						}
						this.ResetCompoundResult();
						if (207141 - 410429 != -203288)
						{
							continue;
						}
						this.ResetCompoundInventory();
						if (165983 - 98174 == 67810)
						{
							continue;
						}
						this.mState = eCompoundState.menu;
						if (292186 - 247626 == 44561)
						{
							continue;
						}
						this.GRYcr2J1Unu = Time.time;
						if (162979 - 513662 != -350682)
						{
							break;
						}
						continue;
					}
					IL_51F:
					int j = 0;
					if (53573 - 376669 == -323095)
					{
						continue;
					}
					while (j < 8)
					{
						if (this.x9lcxaC7a6J.att[j] == 0)
						{
							if (68336 - 403578 != -335242)
							{
								goto IL_B74;
							}
							GUI.Label(new Rect((float)(396 + 100 * (j % 2)), (float)(694 + 26 * global::Math.div((float)j, (float)2)), (float)60, (float)25), "-", this.upAcxLnGOwl);
							if (255955 - 231189 != 24766)
							{
								goto IL_B74;
							}
						}
						else
						{
							GUI.Label(new Rect((float)(396 + 100 * (j % 2)), (float)(694 + 26 * global::Math.div((float)j, (float)2)), (float)60, (float)25), string.Empty + this.x9lcxaC7a6J.att[j], this.upAcxLnGOwl);
							if (141414 - 565010 == -423595)
							{
								goto IL_B74;
							}
						}
						j++;
						if (68863 - 77754 != -8891)
						{
							goto IL_B74;
						}
					}
					if (260640 - 585308 != -324667)
					{
						goto IL_1CC;
					}
					continue;
					IL_283:
					goto IL_51F;
					IL_316:
					goto IL_283;
					IL_392:
					goto IL_316;
					IL_8DB:
					goto IL_392;
				}
			}
		}
	}

	// Token: 0x0600604A RID: 24650 RVA: 0x00CFCFDC File Offset: 0x00CFB1DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCompoundInventory()
	{
		if (148965 - 529193 != -380227)
		{
		}
		for (;;)
		{
			this.OxZcxPrrIVw = new IconButtonClass[30];
			if (131854 - 526137 == -394283)
			{
				this.m4TcxNDvH6U = new GUIStyle();
				if (253179 - 322125 != -68945)
				{
					this.m4TcxNDvH6U.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (141011 - 597621 == -456610)
					{
						this.m4TcxNDvH6U.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
						if (106665 - 301383 == -194718)
						{
							this.m4TcxNDvH6U.alignment = TextAnchor.MiddleCenter;
							if (39836 - 187692 == -147856)
							{
								this.ETXcxi8KJqh = new GUIStyle();
								if (155960 - 203441 != -47480)
								{
									this.ETXcxi8KJqh.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
									if (169679 - 389056 == -219377)
									{
										this.ETXcxi8KJqh.alignment = TextAnchor.MiddleCenter;
										if (159357 - 187153 == -27796)
										{
											this.ETXcxi8KJqh.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
											if (237695 - 406664 != -168968)
											{
												this.Ef2cxDStxyK = new GUIStyle();
												if (207735 - 490399 != -282663)
												{
													this.Ef2cxDStxyK.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
													if (195965 - 117683 != 78283)
													{
														this.Ef2cxDStxyK.alignment = TextAnchor.MiddleCenter;
														if (71116 - 194706 != -123589)
														{
															this.Ef2cxDStxyK.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
															if (140327 - 130030 == 10297)
															{
																this.Mw4cxS5y8QS = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
																if (50998 - 389054 == -338056)
																{
																	this.NipcxBxxRnn = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
																	if (246113 - 519047 != -272933)
																	{
																		this.SPQcx0Hs5KO = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
																		if (86283 - 435499 == -349216)
																		{
																			this.BnPcxmbAcv9 = new GUIStyle();
																			if (61636 - 289644 == -228008)
																			{
																				this.BnPcxmbAcv9.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																				if (199516 - 208693 != -9176)
																				{
																					this.BnPcxmbAcv9.alignment = TextAnchor.MiddleLeft;
																					if (87189 - 547700 == -460511)
																					{
																						this.BnPcxmbAcv9.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																						if (106094 - 89985 == 16109)
																						{
																							this.cuecxjVbqYg = new GUIStyle();
																							if (100160 - 175075 == -74915)
																							{
																								this.cuecxjVbqYg.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																								if (61120 - 384050 != -322929)
																								{
																									this.cuecxjVbqYg.alignment = TextAnchor.UpperLeft;
																									if (57380 - 160876 != -103495)
																									{
																										this.cuecxjVbqYg.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																										if (43780 - 405870 != -362089)
																										{
																											this.cuecxjVbqYg.wordWrap = true;
																											if (209241 - 169490 == 39751)
																											{
																												this.zRWcxoHxKhe = new GUIStyle();
																												if (101982 - 319434 == -217452)
																												{
																													this.zRWcxoHxKhe.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																													if (65881 - 219262 != -153380)
																													{
																														this.zRWcxoHxKhe.alignment = TextAnchor.UpperLeft;
																														if (73450 - 465805 == -392355)
																														{
																															this.zRWcxoHxKhe.normal.textColor = new Color(0.17f, 0.29f, 0.24f, (float)1);
																															if (233055 - 344286 == -111231)
																															{
																																this.zRWcxoHxKhe.wordWrap = true;
																																if (291887 - 456509 == -164622)
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

	// Token: 0x0600604B RID: 24651 RVA: 0x00CFD5C8 File Offset: 0x00CFB7C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetCompoundInventory()
	{
		if (83975 - 552436 != -468461)
		{
		}
		for (;;)
		{
			IL_F3:
			int i = 0;
			if (67865 - 136200 != -68334)
			{
				while (i < 30)
				{
					this.OxZcxPrrIVw[i] = new IconButtonClass();
					if (260092 - 409732 == -149639)
					{
						goto IL_F3;
					}
					if (CharacterData.current.inventory[i].name != "none")
					{
						if (231089 - 320945 == -89855)
						{
							goto IL_F3;
						}
						this.OxZcxPrrIVw[i].name = CharacterData.current.inventory[i].name;
						if (139613 - 81439 != 58174)
						{
							goto IL_F3;
						}
						this.OxZcxPrrIVw[i].command = i + 20;
						if (254150 - 427393 != -173243)
						{
							goto IL_F3;
						}
						this.OxZcxPrrIVw[i].image = (Texture2D)IconButton.getCommandIcon(i + 20);
						if (144300 - 381256 == -236955)
						{
							goto IL_F3;
						}
					}
					i++;
					if (224922 - 494758 != -269836)
					{
						goto IL_F3;
					}
				}
				if (254750 - 71768 != 182983)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600604C RID: 24652 RVA: 0x00CFD75C File Offset: 0x00CFB95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCompoundInventory()
	{
		if (287932 - 492144 != -204212)
		{
		}
		for (;;)
		{
			IL_B0A:
			int num = 0;
			if (42774 - 184053 != -141278)
			{
				string text = "none";
				if (182358 - 448586 != -266227)
				{
					Texture nHoverImage = null;
					if (220968 - 450441 == -229473)
					{
						Vector2 vector = new Vector2((float)0, (float)0);
						if (31764 - 519632 != -487867)
						{
							int i = 0;
							if (21133 - 487654 == -466521)
							{
								while (i < 30)
								{
									Rect rect = new Rect((float)632 + global::Math.mod((float)i, (float)6) * (float)60, (float)(487 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
									if (244265 - 315227 != -70962)
									{
										goto IL_B0A;
									}
									if (this.mState == eCompoundState.compound)
									{
										goto IL_75B;
									}
									if (4212 - 202987 != -198775)
									{
										goto IL_B0A;
									}
									if (this.JmUcxTbKtGP == i + 20)
									{
										goto IL_75B;
									}
									if (234039 - 13163 == 220877)
									{
										goto IL_B0A;
									}
									if (this.dRUcxYCZKqM == i + 20)
									{
										if (141017 - 26439 != 114578)
										{
											goto IL_B0A;
										}
										goto IL_75B;
									}
									else if (this.OxZcxPrrIVw[i].name != "none")
									{
										if (44329 - 232194 != -187865)
										{
											goto IL_B0A;
										}
										eIconButtonState eIconButtonState = IconButton.IconButton(this.OxZcxPrrIVw[i], rect);
										if (248148 - 202945 != 45203)
										{
											goto IL_B0A;
										}
										eIconButtonState eIconButtonState2 = eIconButtonState;
										if (28953 - 482565 != -453612)
										{
											goto IL_B0A;
										}
										if (eIconButtonState2 == eIconButtonState.none)
										{
											if (178455 - 93322 == 85134)
											{
												goto IL_B0A;
											}
											GUI.DrawTexture(rect, this.OxZcxPrrIVw[i].image);
											if (18722 - 502235 != -483513)
											{
												goto IL_B0A;
											}
										}
										else if (eIconButtonState2 == eIconButtonState.over)
										{
											if (98616 - 327150 == -228533)
											{
												goto IL_B0A;
											}
											GUI.DrawTexture(rect, this.OxZcxPrrIVw[i].image);
											if (21064 - 293199 == -272134)
											{
												goto IL_B0A;
											}
											GUI.DrawTexture(new Rect(rect.x + (float)6, rect.y + (float)6, (float)51, (float)51), this.zq7crribrFS);
											if (36583 - 457395 == -420811)
											{
												goto IL_B0A;
											}
											if (this.Giacrbn8Tbj == 0)
											{
												if (92539 - 558321 == -465781)
												{
													goto IL_B0A;
												}
												text = ItemData.getName(CharacterData.current.inventory[i].name);
												if (15573 - 598615 == -583041)
												{
													goto IL_B0A;
												}
												if (CharacterData.current.inventory[i].mlv != 0)
												{
													if (2700 - 220813 != -218113)
													{
														goto IL_B0A;
													}
													text += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
													if (164556 - 525087 != -360531)
													{
														goto IL_B0A;
													}
												}
												vector = new Vector2(rect.x - (float)120, rect.y + (float)51);
												if (270661 - 126050 == 144612)
												{
													goto IL_B0A;
												}
											}
										}
										else if (eIconButtonState2 == eIconButtonState.hover)
										{
											if (164953 - 519349 != -354396)
											{
												goto IL_B0A;
											}
											GUI.DrawTexture(rect, this.OxZcxPrrIVw[i].image);
											if (232964 - 221921 != 11043)
											{
												goto IL_B0A;
											}
											GUI.DrawTexture(new Rect(rect.x + (float)6, rect.y + (float)6, (float)51, (float)51), this.zq7crribrFS);
											if (96177 - 477504 == -381326)
											{
												goto IL_B0A;
											}
											if (this.Giacrbn8Tbj == 0)
											{
												if (98657 - 349242 != -250585)
												{
													goto IL_B0A;
												}
												if (CharacterData.current.inventory[i].name != "none")
												{
													if (181629 - 413210 != -231581)
													{
														goto IL_B0A;
													}
													num = i + 20;
													if (62946 - 161636 == -98689)
													{
														goto IL_B0A;
													}
													vector = new Vector2(rect.x - (float)240, rect.y);
													if (83544 - 463445 != -379901)
													{
														goto IL_B0A;
													}
													nHoverImage = this.OxZcxPrrIVw[i].image;
													if (96527 - 154331 == -57803)
													{
														goto IL_B0A;
													}
												}
											}
										}
										else if (eIconButtonState2 == eIconButtonState.press)
										{
											if (12818 - 408878 == -396059)
											{
												goto IL_B0A;
											}
										}
										else if (eIconButtonState2 == eIconButtonState.drag)
										{
											if (279506 - 243293 == 36214)
											{
												goto IL_B0A;
											}
											if (this.OxZcxPrrIVw[i].command != 0)
											{
												if (281236 - 59014 == 222223)
												{
													goto IL_B0A;
												}
												this.Giacrbn8Tbj = i + 20;
												if (244146 - 505284 == -261137)
												{
													goto IL_B0A;
												}
											}
											this.OxZcxPrrIVw[i].state = eIconButtonState.none;
											if (154634 - 539098 != -384464)
											{
												goto IL_B0A;
											}
										}
										else if (eIconButtonState2 == eIconButtonState.drop)
										{
											if (63639 - 52710 != 10929)
											{
												goto IL_B0A;
											}
											if (this.Giacrbn8Tbj >= 20)
											{
												if (24683 - 194825 != -170142)
												{
													goto IL_B0A;
												}
												if (this.Giacrbn8Tbj < 50)
												{
													if (207411 - 86721 != 120690)
													{
														goto IL_B0A;
													}
													CharacterData.current.swapInventory(i, this.Giacrbn8Tbj - 20);
													if (14994 - 192125 == -177130)
													{
														goto IL_B0A;
													}
													this.ResetCompoundInventory();
													if (274728 - 436466 == -161737)
													{
														goto IL_B0A;
													}
													this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
													if (26754 - 317452 == -290697)
													{
														goto IL_B0A;
													}
												}
											}
											this.Giacrbn8Tbj = 0;
											if (144652 - 472634 != -327982)
											{
												goto IL_B0A;
											}
										}
										if (CharacterData.current.inventory[i].num > 1)
										{
											if (161965 - 333590 != -171625)
											{
												goto IL_B0A;
											}
											GUI.DrawTexture(new Rect(rect.x + (float)38, rect.y + (float)39, (float)24, (float)24), this.Mw4cxS5y8QS);
											if (41430 - 17659 == 23772)
											{
												goto IL_B0A;
											}
											GUI.Label(new Rect(rect.x + (float)34, rect.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.m4TcxNDvH6U);
											if (125889 - 369530 == -243640)
											{
												goto IL_B0A;
											}
										}
										else
										{
											string type = CharacterData.current.inventory[i].getType();
											if (33618 - 74615 != -40997)
											{
												goto IL_B0A;
											}
											if (!(type == "w"))
											{
												if (266360 - 298724 != -32364)
												{
													goto IL_B0A;
												}
												if (!(type == "a"))
												{
													if (225019 - 288400 != -63381)
													{
														goto IL_B0A;
													}
													if (!(type == "c"))
													{
														if (137524 - 351221 != -213697)
														{
															goto IL_B0A;
														}
														if (!(type == "b"))
														{
															if (208038 - 39092 != 168946)
															{
																goto IL_B0A;
															}
															if (!(type == "t"))
															{
																if (293345 - 296575 == -3229)
																{
																	goto IL_B0A;
																}
																if (!(type == "p"))
																{
																	goto IL_8A9;
																}
																if (209476 - 511462 == -301985)
																{
																	goto IL_B0A;
																}
															}
														}
													}
												}
											}
											if (CharacterData.current.inventory[i].owner == 0)
											{
												if (34645 - 398332 != -363687)
												{
													goto IL_B0A;
												}
												GUI.DrawTexture(new Rect(rect.x + (float)38, rect.y + (float)39, (float)24, (float)24), this.NipcxBxxRnn);
												if (283376 - 259454 != 23922)
												{
													goto IL_B0A;
												}
											}
											else if (CharacterData.current.inventory[i].owner != CharacterData.current.CID)
											{
												if (139625 - 12378 == 127248)
												{
													goto IL_B0A;
												}
												GUI.DrawTexture(new Rect(rect.x + (float)38, rect.y + (float)39, (float)24, (float)24), this.SPQcx0Hs5KO);
												if (162590 - 496331 != -333741)
												{
													goto IL_B0A;
												}
											}
										}
										IL_8A9:;
									}
									else
									{
										eIconButtonState eIconButtonState3 = IconButton.IconButton(this.OxZcxPrrIVw[i], rect);
										if (282270 - 335192 != -52922)
										{
											goto IL_B0A;
										}
										eIconButtonState eIconButtonState4 = eIconButtonState3;
										if (205325 - 390569 == -185243)
										{
											goto IL_B0A;
										}
										if (eIconButtonState4 == eIconButtonState.over)
										{
											if (222478 - 380306 == -157827)
											{
												goto IL_B0A;
											}
										}
										else if (eIconButtonState4 == eIconButtonState.hover)
										{
											if (83318 - 120624 == -37305)
											{
												goto IL_B0A;
											}
										}
										else
										{
											if (eIconButtonState4 != eIconButtonState.drop)
											{
												goto IL_D64;
											}
											if (63807 - 579803 != -515996)
											{
												goto IL_B0A;
											}
											if (this.Giacrbn8Tbj >= 20)
											{
												if (143643 - 512805 == -369161)
												{
													goto IL_B0A;
												}
												if (this.Giacrbn8Tbj < 50)
												{
													if (241271 - 107393 == 133879)
													{
														goto IL_B0A;
													}
													CharacterData.current.swapInventory(i, this.Giacrbn8Tbj - 20);
													if (273265 - 114664 != 158601)
													{
														goto IL_B0A;
													}
													this.ResetCompoundInventory();
													if (61346 - 382908 != -321562)
													{
														goto IL_B0A;
													}
													this.audio.PlayOneShot(this.L7Bcrs9Wp7m);
													if (152773 - 291196 != -138423)
													{
														goto IL_B0A;
													}
												}
											}
											goto IL_D64;
										}
										GUI.DrawTexture(new Rect(rect.x + (float)6, rect.y + (float)6, (float)51, (float)51), this.zq7crribrFS);
										if (234232 - 172188 != 62044)
										{
											goto IL_B0A;
										}
									}
									IL_D64:
									i++;
									if (9874 - 236426 != -226551)
									{
										continue;
									}
									goto IL_B0A;
									IL_75B:
									if (this.OxZcxPrrIVw[i].image)
									{
										if (109034 - 327829 != -218795)
										{
											goto IL_B0A;
										}
										GUI.DrawTexture(rect, this.OxZcxPrrIVw[i].image);
										if (223339 - 422363 != -199024)
										{
											goto IL_B0A;
										}
										GUI.DrawTexture(new Rect(rect.x + (float)6, rect.y + (float)6, (float)51, (float)51), this.O8jcrx3VPNT);
										if (155678 - 341134 != -185456)
										{
											goto IL_B0A;
										}
									}
									goto IL_D64;
								}
								if (29512 - 281740 == -252228)
								{
									if (this.Giacrbn8Tbj != 0)
									{
										break;
									}
									if (265538 - 308433 != -42894)
									{
										if (text != "none")
										{
											if (192935 - 587813 != -394877)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.Ef2cxDStxyK);
												if (281103 - 190375 == 90728)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.ETXcxi8KJqh);
													if (24037 - 11131 == 12906)
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
											if (277456 - 528111 == -250655)
											{
												InventoryClass nHoverItem = CharacterData.current.inventory[num - 20];
												if (74274 - 469485 != -395210)
												{
													Guix.renderItemToolTip((int)vector.x, (int)vector.y, nHoverItem, nHoverImage);
													if (269910 - 498991 == -229081)
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

	// Token: 0x0600604D RID: 24653 RVA: 0x00CFE60C File Offset: 0x00CFC80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitNoticeBar()
	{
		if (110758 - 430302 != -319543)
		{
		}
		for (;;)
		{
			this.KPUcxkHsEwV = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (515 - 162354 != -161838)
			{
				this.dJlcxFi649Q = new GUIStyle();
				if (276546 - 261374 != 15173)
				{
					this.dJlcxFi649Q.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (95820 - 210056 != -114235)
					{
						this.dJlcxFi649Q.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (220041 - 475402 != -255360)
						{
							this.dJlcxFi649Q.alignment = TextAnchor.MiddleCenter;
							if (286754 - 244462 != 42293)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600604E RID: 24654 RVA: 0x00CFE748 File Offset: 0x00CFC948
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void newNoticeBar(string s, float t)
	{
		this.LFLcx9JqoZh = s;
		this.vPpcxAZoHkZ = Time.time + t;
	}

	// Token: 0x0600604F RID: 24655 RVA: 0x00CFE760 File Offset: 0x00CFC960
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderNoticeBar()
	{
		if (167200 - 279265 != -112065)
		{
		}
		while (this.vPpcxAZoHkZ > Time.time)
		{
			if (133606 - 340689 == -207083)
			{
				GUI.DrawTexture(new Rect((float)395, (float)570, (float)475, (float)102), this.KPUcxkHsEwV);
				if (70389 - 215436 == -145047)
				{
					GUI.Label(new Rect((float)430, (float)600, (float)400, (float)40), this.LFLcx9JqoZh, this.dJlcxFi649Q);
					if (253363 - 228259 != 25105)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006050 RID: 24656 RVA: 0x00CFE848 File Offset: 0x00CFCA48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (4710 - 132134 != -127424)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (34904 - 114504 != -79599)
				{
					break;
				}
			}
			else
			{
				if (this.Giacrbn8Tbj == 0)
				{
					break;
				}
				if (86175 - 46080 != 40096)
				{
					if (Input.GetMouseButton(1))
					{
						if (52265 - 105040 == -52775)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (13642 - 550798 != -537155)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (114657 - 169674 != -55016)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.Giacrbn8Tbj));
									if (298180 - 84852 == 213328)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.Giacrbn8Tbj = 0;
						if (247696 - 434199 != -186502)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006051 RID: 24657 RVA: 0x00CFE9D0 File Offset: 0x00CFCBD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CompoundItem(int nType, string nRecipe, int nGil, int nMatSlot1, int nMatSlot2)
	{
		if (28028 - 286312 != -258283)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (143879 - 136494 != 7386)
			{
				hashtable.Add(43, PlayerData.UID);
				if (130260 - 83258 != 47003)
				{
					hashtable.Add(21, PhotonClient.cInt16(nType));
					if (132387 - 77214 == 55173)
					{
						hashtable.Add(22, nRecipe);
						if (100233 - 539485 != -439251)
						{
							hashtable.Add(23, PhotonClient.cInt16(nGil));
							if (156551 - 339651 != -183099)
							{
								hashtable.Add(24, PhotonClient.cInt16(nMatSlot1));
								if (263151 - 517248 != -254096)
								{
									hashtable.Add(25, PhotonClient.cInt16(nMatSlot2));
									if (18404 - 373317 != -354912)
									{
										PhotonClient.Connection.OpCustom(223, hashtable, true);
										if (251625 - 286637 == -35012)
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

	// Token: 0x06006052 RID: 24658 RVA: 0x00CFEB80 File Offset: 0x00CFCD80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCompoundItem(Hashtable data)
	{
		if (2593 - 484894 != -482300)
		{
		}
		for (;;)
		{
			IL_228:
			if (!RuntimeServices.EqualityOperator(data[31], 0))
			{
				if (291190 - 184616 != 106575)
				{
					InventoryClass inventoryClass;
					if (RuntimeServices.ToBool(data[32]))
					{
						if (235744 - 552550 != -316806)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = data[32];
						if (!(obj is string))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string));
						}
						string s = (string)obj2;
						if (251688 - 167759 != 83929)
						{
							continue;
						}
						inventoryClass = new InventoryClass();
						if (154738 - 230283 != -75545)
						{
							continue;
						}
						inventoryClass.readData(s);
						if (79443 - 374012 != -294569)
						{
							continue;
						}
						if (inventoryClass.name != "none")
						{
							if (238089 - 515986 != -277897)
							{
								continue;
							}
							if (inventoryClass.slot != -1)
							{
								if (208810 - 80816 != 127994)
								{
									continue;
								}
								CharacterData.current.inventory[inventoryClass.slot] = inventoryClass;
								if (26108 - 522204 != -496096)
								{
									continue;
								}
							}
						}
						string text = "none";
						if (35117 - 112641 == -77523)
						{
							continue;
						}
						eCompoundType eCompoundType = this.mType;
						if (71965 - 365349 != -293384)
						{
							continue;
						}
						if (eCompoundType == eCompoundType.Crocodile)
						{
							if (56028 - 197216 != -141188)
							{
								continue;
							}
							text = CompoundData.getMaterial(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
							if (299320 - 406845 != -107525)
							{
								continue;
							}
						}
						else if (eCompoundType == eCompoundType.Humpback)
						{
							if (206869 - 45989 != 160880)
							{
								continue;
							}
							text = CookingData.getIngredient(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
							if (25061 - 374560 == -349498)
							{
								continue;
							}
						}
						else if (eCompoundType == eCompoundType.Rabbit)
						{
							if (113295 - 232242 == -118946)
							{
								continue;
							}
							text = AlchemistData.getIngredient(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
							if (51407 - 86860 == -35452)
							{
								continue;
							}
						}
						else if (eCompoundType == eCompoundType.Mole)
						{
							if (297963 - 84759 != 213204)
							{
								continue;
							}
							text = GadgetData.getIngredient(this.DKkcrBjLBlf[this.zIocrT0NDvC]);
							if (153851 - 234798 == -80946)
							{
								continue;
							}
						}
						if (text != "none")
						{
							if (287637 - 141278 == 146360)
							{
								continue;
							}
							string[] array = (string[])Stringf.splitToArray(text, ",").ToBuiltin(typeof(string));
							if (262107 - 414845 == -152737)
							{
								continue;
							}
							if (Extensions.get_length(array) > 0)
							{
								if (280229 - 230606 != 49623)
								{
									continue;
								}
								int i = 0;
								if (273821 - 3617 != 270204)
								{
									continue;
								}
								while (i < Extensions.get_length(array))
								{
									string[] array2 = (string[])Stringf.splitToArray(array[i], "%").ToBuiltin(typeof(string));
									if (93058 - 562166 == -469107)
									{
										goto IL_228;
									}
									string nItem = array2[0];
									if (277996 - 538247 != -260251)
									{
										goto IL_228;
									}
									int nNum = 1;
									if (100823 - 263004 != -162181)
									{
										goto IL_228;
									}
									if (Extensions.get_length(array2) > 1)
									{
										if (150670 - 370184 != -219514)
										{
											goto IL_228;
										}
										nNum = Stringf.getInteger(array2[1]);
										if (289786 - 531601 == -241814)
										{
											goto IL_228;
										}
									}
									CharacterData.current.removeInventory(nItem, nNum);
									if (169617 - 77781 != 91836)
									{
										goto IL_228;
									}
									i++;
									if (214842 - 480874 == -266031)
									{
										goto IL_228;
									}
								}
								if (65665 - 90305 != -24640)
								{
									continue;
								}
							}
						}
						if (RuntimeServices.EqualityOperator(data[31], 1))
						{
							if (131957 - 33744 != 98213)
							{
								continue;
							}
							if (this.dRUcxYCZKqM != 0)
							{
								if (92065 - 556154 == -464088)
								{
									continue;
								}
								if (Stringf.getString(this.DKkcrBjLBlf[this.zIocrT0NDvC], 0, 5) == "s_rpc")
								{
									if (164675 - 158447 != 6228)
									{
										continue;
									}
									CharacterData.current.inventory[this.dRUcxYCZKqM - 20].reset();
									if (250860 - 275413 != -24553)
									{
										continue;
									}
									CharacterData.current.removeCommand(this.dRUcxYCZKqM);
									if (77771 - 73625 != 4146)
									{
										continue;
									}
								}
							}
							this.CbXcxduh5f2 = 2;
							if (80517 - 557101 == -476583)
							{
								continue;
							}
						}
						else
						{
							this.CbXcxduh5f2 = 3;
							if (66958 - 504724 != -437766)
							{
								continue;
							}
						}
					}
					this.x9lcxaC7a6J = ItemData.getItemData(inventoryClass.name);
					if (70750 - 73725 == -2975)
					{
						this.JJgcx48BG35 = IconButton.getIconImage(inventoryClass.name);
						if (97777 - 344923 != -247145)
						{
							if (!RuntimeServices.EqualityOperator(data[48], null))
							{
								if (33410 - 117416 == -84005)
								{
									continue;
								}
								PlayerData.Gil = RuntimeServices.UnboxInt32(data[48]);
								if (171903 - 361394 != -189491)
								{
									continue;
								}
							}
							if (RuntimeServices.EqualityOperator(data[49], null))
							{
								break;
							}
							if (167592 - 363310 != -195717)
							{
								PlayerData.Jil = RuntimeServices.UnboxInt32(data[49]);
								if (107442 - 482191 == -374749)
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
				this.newNoticeBar("Compound Error!", 2f);
				if (74048 - 65964 != 8085)
				{
					this.ResetIngredientMenu();
					if (283005 - 183504 != 99502)
					{
						this.ResetCompoundResult();
						if (264314 - 556620 != -292305)
						{
							this.ResetCompoundInventory();
							if (146134 - 597072 == -450938)
							{
								this.mState = eCompoundState.menu;
								if (227273 - 75789 == 151484)
								{
									this.GRYcr2J1Unu = Time.time;
									if (72444 - 285102 == -212658)
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

	// Token: 0x06006053 RID: 24659 RVA: 0x00CFF3CC File Offset: 0x00CFD5CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetPossibleList()
	{
		if (20786 - 229566 != -208780)
		{
		}
		for (;;)
		{
			IL_1BE:
			CharacterDataClass current = CharacterData.current;
			if (251440 - 79082 == 172358)
			{
				this.U3Zcr8HjRF9 = new bool[Extensions.get_length(this.DKkcrBjLBlf)];
				if (116446 - 476229 == -359783)
				{
					int i = 0;
					if (100019 - 465116 != -365096)
					{
						while (i < Extensions.get_length(this.DKkcrBjLBlf))
						{
							bool flag = true;
							if (185110 - 12620 != 172490)
							{
								goto IL_1BE;
							}
							string text = null;
							if (8141 - 99175 == -91033)
							{
								goto IL_1BE;
							}
							eCompoundType eCompoundType = this.mType;
							if (115215 - 566572 == -451356)
							{
								goto IL_1BE;
							}
							if (eCompoundType == eCompoundType.Crocodile)
							{
								if (244325 - 133203 == 111123)
								{
									goto IL_1BE;
								}
								text = CompoundData.getMaterial(this.DKkcrBjLBlf[i]);
								if (25849 - 99927 == -74077)
								{
									goto IL_1BE;
								}
							}
							else if (eCompoundType == eCompoundType.Humpback)
							{
								if (126701 - 32525 != 94176)
								{
									goto IL_1BE;
								}
								text = CookingData.getIngredient(this.DKkcrBjLBlf[i]);
								if (276618 - 271820 == 4799)
								{
									goto IL_1BE;
								}
							}
							else if (eCompoundType == eCompoundType.Rabbit)
							{
								if (237516 - 165001 == 72516)
								{
									goto IL_1BE;
								}
								text = AlchemistData.getIngredient(this.DKkcrBjLBlf[i]);
								if (232252 - 292511 != -60259)
								{
									goto IL_1BE;
								}
							}
							else if (eCompoundType == eCompoundType.Mole)
							{
								if (254208 - 366905 == -112696)
								{
									goto IL_1BE;
								}
								text = GadgetData.getIngredient(this.DKkcrBjLBlf[i]);
								if (133615 - 483465 != -349850)
								{
									goto IL_1BE;
								}
							}
							if (text == "none")
							{
								if (126523 - 141369 == -14845)
								{
									goto IL_1BE;
								}
								flag = false;
								if (196928 - 298563 != -101635)
								{
									goto IL_1BE;
								}
							}
							else
							{
								string[] array = (string[])Stringf.splitToArray(text, ",").ToBuiltin(typeof(string));
								if (67061 - 482451 != -415390)
								{
									goto IL_1BE;
								}
								if (Extensions.get_length(array) == 0)
								{
									if (208328 - 166678 != 41650)
									{
										goto IL_1BE;
									}
									flag = false;
									if (58657 - 420559 == -361901)
									{
										goto IL_1BE;
									}
								}
								else
								{
									int j = 0;
									if (216379 - 538550 == -322170)
									{
										goto IL_1BE;
									}
									while (j < Extensions.get_length(array))
									{
										if (Stringf.getString(array[j], 0, 5) != "s_emp")
										{
											if (50614 - 423222 != -372608)
											{
												goto IL_1BE;
											}
											string[] array2 = (string[])Stringf.splitToArray(array[j], "%").ToBuiltin(typeof(string));
											if (131904 - 516761 == -384856)
											{
												goto IL_1BE;
											}
											string text2 = array2[0];
											if (158402 - 333344 != -174942)
											{
												goto IL_1BE;
											}
											int num = 1;
											if (232752 - 62452 != 170300)
											{
												goto IL_1BE;
											}
											if (Extensions.get_length(array2) > 1)
											{
												if (297944 - 499674 == -201729)
												{
													goto IL_1BE;
												}
												num = Mathf.Clamp(Stringf.getInteger(array2[1]), 1, 12);
												if (18623 - 16755 != 1868)
												{
													goto IL_1BE;
												}
											}
											if (text2 != string.Empty)
											{
												if (19185 - 143536 == -124350)
												{
													goto IL_1BE;
												}
												if (text2 != "none")
												{
													if (269919 - 34338 == 235582)
													{
														goto IL_1BE;
													}
													if (num > 0)
													{
														if (162344 - 476864 != -314520)
														{
															goto IL_1BE;
														}
														if (current.getItemTotalNum(text2) < num)
														{
															if (55875 - 528218 != -472343)
															{
																goto IL_1BE;
															}
															flag = false;
															if (272966 - 422345 != -149379)
															{
																goto IL_1BE;
															}
														}
														goto IL_523;
													}
												}
											}
											flag = false;
											if (171013 - 27755 != 143258)
											{
												goto IL_1BE;
											}
										}
										IL_523:
										j++;
										if (92363 - 406229 == -313865)
										{
											goto IL_1BE;
										}
									}
									if (24130 - 495045 == -470914)
									{
										goto IL_1BE;
									}
								}
							}
							this.U3Zcr8HjRF9[i] = flag;
							if (122439 - 467666 != -345227)
							{
								goto IL_1BE;
							}
							i++;
							if (19487 - 380703 != -361216)
							{
								goto IL_1BE;
							}
						}
						if (186940 - 317561 != -130620)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006054 RID: 24660 RVA: 0x00CFF99C File Offset: 0x00CFDB9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006055 RID: 24661 RVA: 0x00CFF9A0 File Offset: 0x00CFDBA0
	internal static bool Ie9CH6p3ilw9ivejbKmC()
	{
		return true;
	}

	// Token: 0x06006056 RID: 24662 RVA: 0x00CFF9A4 File Offset: 0x00CFDBA4
	internal static bool BhP9Kop3KZcNl47ZmScK()
	{
		return false;
	}

	// Token: 0x04006B63 RID: 27491
	public int posx;

	// Token: 0x04006B64 RID: 27492
	public int posy;

	// Token: 0x04006B65 RID: 27493
	public int divx;

	// Token: 0x04006B66 RID: 27494
	public int divy;

	// Token: 0x04006B67 RID: 27495
	public eCompoundState mState;

	// Token: 0x04006B68 RID: 27496
	public eCompoundType mType;

	// Token: 0x04006B69 RID: 27497
	public eCompoundPage mPage;

	// Token: 0x04006B6A RID: 27498
	private float GRYcr2J1Unu;

	// Token: 0x04006B6B RID: 27499
	private float nXTcrvxQtss;

	// Token: 0x04006B6C RID: 27500
	private float wQ0crlQLCAo;

	// Token: 0x04006B6D RID: 27501
	private float xS7crG4hu9x;

	// Token: 0x04006B6E RID: 27502
	private float hxPcr1MStR2;

	// Token: 0x04006B6F RID: 27503
	private float rVgcrqJETO0;

	// Token: 0x04006B70 RID: 27504
	private Texture FU1crpdXavA;

	// Token: 0x04006B71 RID: 27505
	private GUIStyle XkDcrRUftEt;

	// Token: 0x04006B72 RID: 27506
	private Texture zq7crribrFS;

	// Token: 0x04006B73 RID: 27507
	private Texture O8jcrx3VPNT;

	// Token: 0x04006B74 RID: 27508
	private int zIocrT0NDvC;

	// Token: 0x04006B75 RID: 27509
	private int ou5crYWkIIq;

	// Token: 0x04006B76 RID: 27510
	private float zxpcr3GBT7G;

	// Token: 0x04006B77 RID: 27511
	private int Giacrbn8Tbj;

	// Token: 0x04006B78 RID: 27512
	private int HOccrdTE67C;

	// Token: 0x04006B79 RID: 27513
	private AudioClip fe3crg2w0qC;

	// Token: 0x04006B7A RID: 27514
	private AudioClip ndkcraUtjwf;

	// Token: 0x04006B7B RID: 27515
	private AudioClip qkDcr4HI1fn;

	// Token: 0x04006B7C RID: 27516
	private AudioClip L7Bcrs9Wp7m;

	// Token: 0x04006B7D RID: 27517
	private AudioClip RxHcrHFisne;

	// Token: 0x04006B7E RID: 27518
	private GameObject B7Qcr7EKHjA;

	// Token: 0x04006B7F RID: 27519
	private Texture XDScrZBeF0M;

	// Token: 0x04006B80 RID: 27520
	private Texture WvccrC5JEk5;

	// Token: 0x04006B81 RID: 27521
	private GUIStyle TTfcrMPf8Ah;

	// Token: 0x04006B82 RID: 27522
	private GUIStyle OKCcrf0rys7;

	// Token: 0x04006B83 RID: 27523
	private string oRYcrLtpLKt;

	// Token: 0x04006B84 RID: 27524
	private string APJcrwCRdED;

	// Token: 0x04006B85 RID: 27525
	private AudioClip CXbcrUssUU1;

	// Token: 0x04006B86 RID: 27526
	private AudioClip lU3crNFxdm6;

	// Token: 0x04006B87 RID: 27527
	private AudioClip IA6crE8aGHa;

	// Token: 0x04006B88 RID: 27528
	private AudioClip zljcrPDCUkr;

	// Token: 0x04006B89 RID: 27529
	private bool JNtcrST4kF3;

	// Token: 0x04006B8A RID: 27530
	private string[] DKkcrBjLBlf;

	// Token: 0x04006B8B RID: 27531
	private Texture[] cKScr0yk7Rm;

	// Token: 0x04006B8C RID: 27532
	private bool[] U3Zcr8HjRF9;

	// Token: 0x04006B8D RID: 27533
	private HoverButtonClass[] s1lcriKsnsS;

	// Token: 0x04006B8E RID: 27534
	private Texture JXEcrD20gkd;

	// Token: 0x04006B8F RID: 27535
	private Texture tGVcrmDarln;

	// Token: 0x04006B90 RID: 27536
	private Texture xmYcrjVbt3N;

	// Token: 0x04006B91 RID: 27537
	private GUIStyle a1qcro4fsI9;

	// Token: 0x04006B92 RID: 27538
	private GUIStyle mjicrk67jEP;

	// Token: 0x04006B93 RID: 27539
	private GUIStyle rFPcrFIlJ6u;

	// Token: 0x04006B94 RID: 27540
	private GUIStyle j3GcrAVLddn;

	// Token: 0x04006B95 RID: 27541
	private GUIStyle RZOcr9Oo2GG;

	// Token: 0x04006B96 RID: 27542
	private GUIStyle K27crWmLxEK;

	// Token: 0x04006B97 RID: 27543
	private GUIStyle pcicruSOUKH;

	// Token: 0x04006B98 RID: 27544
	private GUIStyle VYHcryME8Jq;

	// Token: 0x04006B99 RID: 27545
	private GUIStyle NntcrVFRI4p;

	// Token: 0x04006B9A RID: 27546
	private GUIStyle MnWcrhpZpyT;

	// Token: 0x04006B9B RID: 27547
	private GUIStyle qjrcrKwlmL4;

	// Token: 0x04006B9C RID: 27548
	private GUIStyle oircrzd8kUD;

	// Token: 0x04006B9D RID: 27549
	private GUIStyle jHfcx500QZX;

	// Token: 0x04006B9E RID: 27550
	private GUIStyle Y5Ocxc5sUR4;

	// Token: 0x04006B9F RID: 27551
	private GUIStyle NVhcxngZ9tA;

	// Token: 0x04006BA0 RID: 27552
	private GUIStyle is9cxQOPsFO;

	// Token: 0x04006BA1 RID: 27553
	private GUIStyle Rb5cxeFmSU1;

	// Token: 0x04006BA2 RID: 27554
	private GUIStyle s8YcxIn5d28;

	// Token: 0x04006BA3 RID: 27555
	private int MICcxJiYOZ2;

	// Token: 0x04006BA4 RID: 27556
	private ItemClass kVVcx6PSuUF;

	// Token: 0x04006BA5 RID: 27557
	private HoverButtonClass[] nrUcxt9jRvd;

	// Token: 0x04006BA6 RID: 27558
	private string[] nC5cxXFYb2P;

	// Token: 0x04006BA7 RID: 27559
	private int[] aVJcxOdyxmb;

	// Token: 0x04006BA8 RID: 27560
	private Texture[] xQVcx2CcXLZ;

	// Token: 0x04006BA9 RID: 27561
	private bool[] xZ8cxvWq8Dx;

	// Token: 0x04006BAA RID: 27562
	private Texture BSucxlJ0Eda;

	// Token: 0x04006BAB RID: 27563
	private GUIStyle XjNcxG2ERut;

	// Token: 0x04006BAC RID: 27564
	private GUIStyle rMjcx11LFCP;

	// Token: 0x04006BAD RID: 27565
	private GUIStyle lbIcxq74lF5;

	// Token: 0x04006BAE RID: 27566
	private Texture Uudcxp1WRnt;

	// Token: 0x04006BAF RID: 27567
	private Texture uO7cxRbMM99;

	// Token: 0x04006BB0 RID: 27568
	private Texture J7gcxr8NlZU;

	// Token: 0x04006BB1 RID: 27569
	private Texture vaacxxPeE9K;

	// Token: 0x04006BB2 RID: 27570
	private int JmUcxTbKtGP;

	// Token: 0x04006BB3 RID: 27571
	private int dRUcxYCZKqM;

	// Token: 0x04006BB4 RID: 27572
	private IconButtonClass yZDcx3Tj4gB;

	// Token: 0x04006BB5 RID: 27573
	private IconButtonClass gUecxbZxwk7;

	// Token: 0x04006BB6 RID: 27574
	private int CbXcxduh5f2;

	// Token: 0x04006BB7 RID: 27575
	public bool resultSuccess;

	// Token: 0x04006BB8 RID: 27576
	private InventoryClass sbtcxgvm2dN;

	// Token: 0x04006BB9 RID: 27577
	private ItemClass x9lcxaC7a6J;

	// Token: 0x04006BBA RID: 27578
	private Texture JJgcx48BG35;

	// Token: 0x04006BBB RID: 27579
	private Texture JvCcxsD5UaW;

	// Token: 0x04006BBC RID: 27580
	private Texture M4kcxHx8ttY;

	// Token: 0x04006BBD RID: 27581
	private Texture zAZcx7pYF2d;

	// Token: 0x04006BBE RID: 27582
	private Texture SZEcxZhdFMg;

	// Token: 0x04006BBF RID: 27583
	private Texture Gg2cxCvsk7Q;

	// Token: 0x04006BC0 RID: 27584
	private GUIStyle pkWcxMjBVZ5;

	// Token: 0x04006BC1 RID: 27585
	private GUIStyle f2Scxfm2gyh;

	// Token: 0x04006BC2 RID: 27586
	private GUIStyle upAcxLnGOwl;

	// Token: 0x04006BC3 RID: 27587
	private GUIStyle lcVcxwCTb0e;

	// Token: 0x04006BC4 RID: 27588
	private GUIStyle p2ecxUnonf5;

	// Token: 0x04006BC5 RID: 27589
	private GUIStyle m4TcxNDvH6U;

	// Token: 0x04006BC6 RID: 27590
	private GUIStyle EhVcxE2UEAI;

	// Token: 0x04006BC7 RID: 27591
	private IconButtonClass[] OxZcxPrrIVw;

	// Token: 0x04006BC8 RID: 27592
	private Texture Mw4cxS5y8QS;

	// Token: 0x04006BC9 RID: 27593
	private Texture NipcxBxxRnn;

	// Token: 0x04006BCA RID: 27594
	private Texture SPQcx0Hs5KO;

	// Token: 0x04006BCB RID: 27595
	private Texture q3pcx885SQt;

	// Token: 0x04006BCC RID: 27596
	private GUIStyle ETXcxi8KJqh;

	// Token: 0x04006BCD RID: 27597
	private GUIStyle Ef2cxDStxyK;

	// Token: 0x04006BCE RID: 27598
	private GUIStyle BnPcxmbAcv9;

	// Token: 0x04006BCF RID: 27599
	private GUIStyle cuecxjVbqYg;

	// Token: 0x04006BD0 RID: 27600
	private GUIStyle zRWcxoHxKhe;

	// Token: 0x04006BD1 RID: 27601
	private Texture KPUcxkHsEwV;

	// Token: 0x04006BD2 RID: 27602
	private GUIStyle dJlcxFi649Q;

	// Token: 0x04006BD3 RID: 27603
	private float vPpcxAZoHkZ;

	// Token: 0x04006BD4 RID: 27604
	private string LFLcx9JqoZh;
}
