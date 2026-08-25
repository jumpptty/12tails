using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200105E RID: 4190
[Serializable]
public class GuildGui : MonoBehaviour
{
	// Token: 0x0600610A RID: 24842 RVA: 0x00D46D64 File Offset: 0x00D44F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GuildGui()
	{
		if (233978 - 255051 != -21072)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (80285 - 471805 != -391519)
			{
				base..ctor();
				if (180403 - 473237 != -292833)
				{
					this.mState = eGuildGuiState.init;
					if (70952 - 102351 != -31398)
					{
						this.mTimeOutState = eGuildGuiTimeoutState.none;
						if (48093 - 173978 == -125885)
						{
							this.O0Fc4nkuQGI = 40;
							if (111031 - 89967 != 21065)
							{
								this.IVbc46bF2NA = string.Empty;
								if (140327 - 493816 == -353489)
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

	// Token: 0x0600610B RID: 24843 RVA: 0x00D46E64 File Offset: 0x00D45064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (269501 - 98400 != 171101)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (224110 - 354815 != -130704)
			{
				if (this.mState == eGuildGuiState.init)
				{
					if (76391 - 39876 == 36516)
					{
						continue;
					}
					this.InitNPC();
					if (138718 - 169753 != -31035)
					{
						continue;
					}
					this.InitGuildGui();
					if (227866 - 186197 == 41670)
					{
						continue;
					}
					this.InitInfoBar();
					if (127514 - 147754 == -20239)
					{
						continue;
					}
					this.InitMemberMenu();
					if (85601 - 385213 != -299612)
					{
						continue;
					}
					this.InitAchievementMenu();
					if (58739 - 61113 != -2374)
					{
						continue;
					}
					this.InitRecipeMenu();
					if (248389 - 73771 == 174619)
					{
						continue;
					}
					this.InitItemMenu();
					if (266567 - 367818 != -101251)
					{
						continue;
					}
					this.InitRegistrationMenu();
					if (231411 - 538664 == -307252)
					{
						continue;
					}
					this.InitNoticeBar();
					if (219428 - 436152 == -216723)
					{
						continue;
					}
				}
				this.ysAcgycI1Qy = 1f;
				if (144269 - 129272 == 14997)
				{
					this.g0QcgVjhcrw = (float)0;
					if (289223 - 253576 != 35648)
					{
						this.i0wcavZkLTG = Language.getMessage("GuildGui", 101 + UnityEngine.Random.Range(0, 5));
						if (251512 - 187106 != 64407)
						{
							this.KWJcalyXChn = Language.getMessage("GuildGui", 111 + UnityEngine.Random.Range(0, 5));
							if (202332 - 315256 == -112924)
							{
								this.mState = eGuildGuiState.open;
								if (206605 - 216969 != -10363)
								{
									this.Yi0cgALoGcO = Time.time;
									if (91396 - 338482 == -247086)
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

	// Token: 0x0600610C RID: 24844 RVA: 0x00D470F8 File Offset: 0x00D452F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (279239 - 520464 != -241225)
		{
		}
		for (;;)
		{
			if (this.mState <= eGuildGuiState.init)
			{
				if (39429 - 322885 == -283456)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (258754 - 503924 == -245170)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (9140 - 424083 != -414942)
					{
						this.iLicgWlh2O4 = (float)(1024 * Screen.width / Screen.height);
						if (40750 - 156674 != -115923)
						{
							this.j4ZcguG9SBQ = (float)Screen.height / 1024f;
							if (22654 - 141 != 22514)
							{
								this.RenderGuildGui();
								if (74754 - 326575 == -251821)
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

	// Token: 0x0600610D RID: 24845 RVA: 0x00D47248 File Offset: 0x00D45448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGuildGui()
	{
		if (9414 - 399624 != -390210)
		{
		}
		for (;;)
		{
			this.txNcghngNVe = (Texture)Resources.Load("GameGui/GuildWindow/guildWindow", typeof(Texture));
			if (62726 - 282976 == -220250)
			{
				this.nHtcgKwCwwb = new GUIStyle();
				if (13202 - 22453 == -9251)
				{
					this.nHtcgKwCwwb.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_close_h", typeof(Texture)));
					if (245300 - 587176 == -341876)
					{
						this.WtkcgzLdS4H = new GUIStyle();
						if (106435 - 69272 != 37164)
						{
							this.WtkcgzLdS4H.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
							if (163122 - 172406 == -9284)
							{
								this.qJWca5ynFlv = new GUIStyle();
								if (57512 - 109290 != -51777)
								{
									this.qJWca5ynFlv.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
									if (47005 - 316073 != -269067)
									{
										this.K80cacvxbhl = new GUIStyle();
										if (138189 - 432118 == -293929)
										{
											this.K80cacvxbhl.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numUp", typeof(Texture)));
											if (107615 - 186077 == -78462)
											{
												this.K80cacvxbhl.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numUp_h", typeof(Texture)));
												if (152764 - 264994 != -112229)
												{
													this.CVtcanKrka4 = new GUIStyle();
													if (275951 - 431117 != -155165)
													{
														this.CVtcanKrka4.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numDown", typeof(Texture)));
														if (106905 - 237872 != -130966)
														{
															this.CVtcanKrka4.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_numDown_h", typeof(Texture)));
															if (187429 - 27300 != 160130)
															{
																this.rUmcaQUJeie = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
																if (219049 - 375689 == -156640)
																{
																	this.SjUcaeLG42P = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																	if (82134 - 368516 == -286382)
																	{
																		this.xXTcaIoE07t = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																		if (229223 - 114168 != 115056)
																		{
																			this.ivPcaJvWb2B = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																			if (94584 - 167110 != -72525)
																			{
																				this.MxBca6eAcK5 = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																				if (226002 - 83366 == 142636)
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

	// Token: 0x0600610E RID: 24846 RVA: 0x00D47688 File Offset: 0x00D45888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGuildGui()
	{
		if (72998 - 358965 != -285966)
		{
		}
		for (;;)
		{
			float num = Time.time - this.Yi0cgALoGcO;
			if (77970 - 99139 != -21168)
			{
				eGuildGuiState eGuildGuiState = this.mState;
				if (15933 - 22403 == -6470)
				{
					if (eGuildGuiState != eGuildGuiState.open)
					{
						if (eGuildGuiState == eGuildGuiState.member)
						{
							if (197368 - 277971 == -80602)
							{
								continue;
							}
						}
						else if (eGuildGuiState == eGuildGuiState.achievement)
						{
							if (192181 - 205733 == -13551)
							{
								continue;
							}
						}
						else if (eGuildGuiState == eGuildGuiState.recipe)
						{
							if (140997 - 108474 != 32523)
							{
								continue;
							}
						}
						else if (eGuildGuiState == eGuildGuiState.item)
						{
							if (73590 - 478869 == -405278)
							{
								continue;
							}
						}
						else if (eGuildGuiState == eGuildGuiState.registration)
						{
							if (100659 - 125832 != -25173)
							{
								continue;
							}
						}
						else
						{
							if (eGuildGuiState != eGuildGuiState.close)
							{
								break;
							}
							if (14623 - 357411 == -342787)
							{
								continue;
							}
							this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
							if (169313 - 169525 != -212)
							{
								continue;
							}
							if (num <= (float)2)
							{
								if (145126 - 119211 == 25916)
								{
									continue;
								}
								this.RenderNPC();
								if (275530 - 101795 != 173735)
								{
									continue;
								}
								GUI.BeginGroup(new Rect(0.5f * this.iLicgWlh2O4 - (float)350, (float)724, (float)850, (float)200));
								if (288168 - 553193 != -265025)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.gHocaXu7H1C);
								if (270885 - 94791 != 176094)
								{
									continue;
								}
								GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Raccoon", this.pHEcaO4pqpp);
								if (208044 - 244424 != -36380)
								{
									continue;
								}
								GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.KWJcalyXChn, num), this.Naaca2wDBwq);
								if (125216 - 537135 != -411919)
								{
									continue;
								}
								GUI.EndGroup();
								if (259010 - 242397 != 16613)
								{
									continue;
								}
								break;
							}
							else if (num <= 2.5f)
							{
								if (5164 - 574822 != -569658)
								{
									continue;
								}
								this.ysAcgycI1Qy = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
								if (239634 - 326310 != -86676)
								{
									continue;
								}
								this.RenderNPC();
								if (90283 - 241283 != -150999)
								{
									break;
								}
								continue;
							}
							else
							{
								Game.mGameState = eGameState.Normal;
								if (237787 - 491457 == -253669)
								{
									continue;
								}
								GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
								if (285073 - 272165 == 12909)
								{
									continue;
								}
								gameGui.enabled = true;
								if (58226 - 515350 == -457123)
								{
									continue;
								}
								this.mState = eGuildGuiState.disabled;
								if (218816 - 577886 == -359069)
								{
									continue;
								}
								this.enabled = false;
								if (121434 - 51266 != 70169)
								{
									break;
								}
								continue;
							}
						}
						IL_2A6:
						this.camera.rect = new Rect((float)0, (float)0, (this.iLicgWlh2O4 - (float)800) / this.iLicgWlh2O4, (float)1);
						if (123425 - 51936 == 71490)
						{
							continue;
						}
						GUI.DrawTexture(new Rect(this.iLicgWlh2O4 - (float)950, (float)0, (float)950, (float)1024), this.txNcghngNVe);
						if (104856 - 388136 != -283280)
						{
							continue;
						}
						this.RenderInfoBar();
						if (137713 - 598766 != -461053)
						{
							continue;
						}
						eGuildGuiState eGuildGuiState2 = this.mState;
						if (79627 - 94483 != -14856)
						{
							continue;
						}
						if (eGuildGuiState2 == eGuildGuiState.member)
						{
							if (243960 - 13693 == 230268)
							{
								continue;
							}
							this.RenderMemberMenu();
							if (150223 - 75562 != 74661)
							{
								continue;
							}
						}
						else if (eGuildGuiState2 == eGuildGuiState.achievement)
						{
							if (297872 - 584364 != -286492)
							{
								continue;
							}
							this.RenderAchievementMenu();
							if (57306 - 427936 == -370629)
							{
								continue;
							}
						}
						else if (eGuildGuiState2 == eGuildGuiState.recipe)
						{
							if (298895 - 586047 != -287152)
							{
								continue;
							}
							this.RenderRecipeMenu();
							if (226363 - 172892 != 53471)
							{
								continue;
							}
						}
						else if (eGuildGuiState2 == eGuildGuiState.item)
						{
							if (111439 - 487783 != -376344)
							{
								continue;
							}
							this.RenderItemMenu();
							if (190474 - 147783 != 42691)
							{
								continue;
							}
						}
						else if (eGuildGuiState2 == eGuildGuiState.registration)
						{
							if (87262 - 391106 == -303843)
							{
								continue;
							}
							this.RenderRegistrationMenu();
							if (220031 - 159931 != 60100)
							{
								continue;
							}
						}
						if (this.mTimeOutState == eGuildGuiTimeoutState.none)
						{
							if (237997 - 237884 == 114)
							{
								continue;
							}
							if (GUI.Button(new Rect(this.iLicgWlh2O4 - (float)1024 + (float)182, (float)-1, (float)57, (float)52), string.Empty, this.nHtcgKwCwwb))
							{
								if (237309 - 437254 != -199945)
								{
									continue;
								}
								this.mState = eGuildGuiState.close;
								if (281567 - 120065 == 161503)
								{
									continue;
								}
								this.Yi0cgALoGcO = Time.time;
								if (51626 - 579449 != -527823)
								{
									continue;
								}
								this.audio.PlayOneShot(this.ivPcaJvWb2B);
								if (140190 - 125972 == 14219)
								{
									continue;
								}
							}
							if (Input.GetKeyDown("escape"))
							{
								if (5855 - 288566 == -282710)
								{
									continue;
								}
								this.mState = eGuildGuiState.close;
								if (33974 - 525076 != -491102)
								{
									continue;
								}
								this.Yi0cgALoGcO = Time.time;
								if (53330 - 522602 == -469271)
								{
									continue;
								}
								this.audio.PlayOneShot(this.xXTcaIoE07t);
								if (59862 - 34122 == 25741)
								{
									continue;
								}
							}
						}
						else
						{
							this.RenderNoticeBar();
							if (140401 - 556549 == -416147)
							{
								continue;
							}
						}
						this.RenderNPC();
						if (23950 - 61317 != -37367)
						{
							continue;
						}
						break;
						IL_A0B:
						goto IL_2A6;
						IL_5C6:
						goto IL_A0B;
						goto IL_5C6;
					}
					if (266473 - 99400 != 167074)
					{
						if (num <= 0.5f)
						{
							if (207210 - 180233 != 26978)
							{
								this.ysAcgycI1Qy = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
								if (89413 - 271253 != -181839)
								{
									this.RenderNPC();
									if (78550 - 249707 != -171156)
									{
										GUI.DrawTexture(new Rect(0.5f * this.iLicgWlh2O4 - (float)336, (float)724 + this.ysAcgycI1Qy * (float)300, (float)836, (float)196), this.gHocaXu7H1C);
										if (66722 - 166333 == -99611)
										{
											break;
										}
									}
								}
							}
						}
						else if (num <= (float)4)
						{
							if (187745 - 534814 != -347068)
							{
								this.ysAcgycI1Qy = (float)0;
								if (141909 - 275755 != -133845)
								{
									this.RenderNPC();
									if (11761 - 431006 == -419245)
									{
										GUI.BeginGroup(new Rect(0.5f * this.iLicgWlh2O4 - (float)350, (float)724, (float)850, (float)200));
										if (293417 - 436226 == -142809)
										{
											GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.gHocaXu7H1C);
											if (247078 - 93010 != 154069)
											{
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Raccoon", this.pHEcaO4pqpp);
												if (239163 - 389155 != -149991)
												{
													GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.i0wcavZkLTG, num - 0.5f), this.Naaca2wDBwq);
													if (284181 - 337747 == -53566)
													{
														GUI.EndGroup();
														if (238935 - 140153 != 98783)
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
							this.ysAcgycI1Qy = (float)0;
							if (112418 - 425660 != -313241)
							{
								this.RenderNPC();
								if (148818 - 192133 == -43315)
								{
									this.mState = eGuildGuiState.member;
									if (222955 - 112479 != 110477)
									{
										this.Yi0cgALoGcO = Time.time;
										if (71468 - 322745 == -251277)
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

	// Token: 0x0600610F RID: 24847 RVA: 0x00D481C0 File Offset: 0x00D463C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (211568 - 65429 != 146140)
		{
		}
		for (;;)
		{
			this.Kw8catc4GqP = (Texture)Resources.Load("GameGui/Story/Characters/Raccoon", typeof(Texture));
			if (68176 - 452029 != -383852)
			{
				this.gHocaXu7H1C = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
				if (163401 - 512353 == -348952)
				{
					this.pHEcaO4pqpp = new GUIStyle();
					if (252284 - 75895 == 176389)
					{
						this.pHEcaO4pqpp.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
						if (224463 - 101170 != 123294)
						{
							this.pHEcaO4pqpp.normal.textColor = new Color(0.25f, 0.22f, 0.2f, (float)1);
							if (149329 - 353045 != -203715)
							{
								this.pHEcaO4pqpp.alignment = TextAnchor.UpperLeft;
								if (237447 - 523836 == -286389)
								{
									this.Naaca2wDBwq = new GUIStyle();
									if (73569 - 31263 != 42307)
									{
										this.Naaca2wDBwq.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
										if (162163 - 335028 == -172865)
										{
											this.Naaca2wDBwq.alignment = TextAnchor.UpperLeft;
											if (272730 - 251531 != 21200)
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

	// Token: 0x06006110 RID: 24848 RVA: 0x00D483BC File Offset: 0x00D465BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC()
	{
		GUI.DrawTexture(new Rect((float)0 - this.ysAcgycI1Qy * (float)372, (float)512, (float)372, (float)512), this.Kw8catc4GqP);
	}

	// Token: 0x06006111 RID: 24849 RVA: 0x00D483F0 File Offset: 0x00D465F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitInfoBar()
	{
		if (292134 - 450624 != -158489)
		{
		}
		for (;;)
		{
			this.f63caGUgsHF = new GUIStyle();
			if (152046 - 124458 == 27588)
			{
				this.f63caGUgsHF.font = (Font)Resources.Load("GameGui/Fonts/Century22", typeof(Font));
				if (214662 - 484556 == -269894)
				{
					this.f63caGUgsHF.normal.textColor = new Color(0.24f, 0.2f, 0.14f, (float)1);
					if (279788 - 126711 != 153078)
					{
						this.f63caGUgsHF.alignment = TextAnchor.MiddleLeft;
						if (16265 - 542880 != -526614)
						{
							this.HqFca1FjJw1 = new GUIStyle();
							if (55648 - 102264 != -46615)
							{
								this.HqFca1FjJw1.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
								if (231397 - 34738 == 196659)
								{
									this.HqFca1FjJw1.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
									if (165399 - 538462 != -373062)
									{
										this.HqFca1FjJw1.alignment = TextAnchor.UpperLeft;
										if (219958 - 54419 != 165540)
										{
											this.HqFca1FjJw1.wordWrap = true;
											if (3427 - 108913 != -105485)
											{
												this.avXcaqB1PWc = new GUIStyle();
												if (261757 - 440478 == -178721)
												{
													this.avXcaqB1PWc.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
													if (139888 - 168194 != -28305)
													{
														this.avXcaqB1PWc.normal.textColor = new Color(0.24f, 0.2f, 0.14f, (float)1);
														if (47443 - 391571 != -344127)
														{
															this.avXcaqB1PWc.alignment = TextAnchor.MiddleLeft;
															if (260125 - 50435 == 209690)
															{
																this.dnScapASnPv = new GUIStyle();
																if (15879 - 60878 != -44998)
																{
																	this.dnScapASnPv.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																	if (167286 - 536489 != -369202)
																	{
																		this.dnScapASnPv.normal.textColor = new Color(0.16f, 0.42f, 0.31f, (float)1);
																		if (101879 - 509527 != -407647)
																		{
																			this.dnScapASnPv.alignment = TextAnchor.MiddleRight;
																			if (157400 - 410920 != -253519)
																			{
																				this.Ao6caRm2WvD = new GUIStyle();
																				if (199148 - 401419 != -202270)
																				{
																					this.Ao6caRm2WvD.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_regis", typeof(Texture)));
																					if (68822 - 53309 == 15513)
																					{
																						this.Ao6caRm2WvD.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_regis_h", typeof(Texture)));
																						if (152212 - 259797 == -107585)
																						{
																							this.fSHcarinCtW = new GUIStyle();
																							if (262775 - 288288 == -25513)
																							{
																								this.fSHcarinCtW.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_leave_h", typeof(Texture)));
																								if (99419 - 203508 == -104089)
																								{
																									this.By7caYv3ydU = new GUIStyle();
																									if (149653 - 373077 != -223423)
																									{
																										this.By7caYv3ydU.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/tab_member_h", typeof(Texture)));
																										if (78613 - 374269 != -295655)
																										{
																											this.AJwca3ydX5C = new GUIStyle();
																											if (141701 - 339016 != -197314)
																											{
																												this.AJwca3ydX5C.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/tab_achievement_h", typeof(Texture)));
																												if (8712 - 85595 == -76883)
																												{
																													this.oydcad9BFBm = new GUIStyle();
																													if (193757 - 507926 == -314169)
																													{
																														this.oydcad9BFBm.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/tab_item_h", typeof(Texture)));
																														if (138099 - 245271 == -107172)
																														{
																															this.sQdcab7J8Si = new GUIStyle();
																															if (210990 - 8132 != 202859)
																															{
																																this.sQdcab7J8Si.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/tab_recipe_h", typeof(Texture)));
																																if (188864 - 170012 != 18853)
																																{
																																	this.m2fcax0oUE2 = (Texture)Resources.Load("GameGui/Icons/Guild/a1", typeof(Texture));
																																	if (238347 - 139506 == 98841)
																																	{
																																		this.ygBcaT4njq2 = (Texture)Resources.Load("GameGui/Icons/Guild/b1", typeof(Texture));
																																		if (64734 - 531695 != -466960)
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

	// Token: 0x06006112 RID: 24850 RVA: 0x00D48AB4 File Offset: 0x00D46CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderInfoBar()
	{
		if (205237 - 452626 != -247389)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(this.iLicgWlh2O4 - (float)950, (float)0, (float)950, (float)1024));
			if (158344 - 147255 != 11090)
			{
				Guix.renderSmallNumber(640, 35, PlayerData.Gil, false, (float)1);
				if (99295 - 85621 != 13675)
				{
					Guix.renderSmallNumber(820, 35, PlayerData.Jil, false, (float)1);
					if (196981 - 91698 == 105283)
					{
						if (this.ygBcaT4njq2)
						{
							if (95603 - 153490 == -57886)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)159, (float)174, (float)32, (float)32), this.ygBcaT4njq2);
							if (47456 - 523752 != -476296)
							{
								continue;
							}
						}
						if (this.m2fcax0oUE2)
						{
							if (67300 - 548333 == -481032)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)159, (float)174, (float)32, (float)32), this.m2fcax0oUE2);
							if (90292 - 10685 != 79607)
							{
								continue;
							}
						}
						GUI.DrawTexture(new Rect((float)152, (float)167, (float)46, (float)46), this.BKGcazVZZT6.hover.background);
						if (277853 - 463692 != -185838)
						{
							if (PlayerData.GID > 0)
							{
								if (218333 - 316272 != -97939)
								{
									continue;
								}
								Guix.renderSmallNumber(390, 189, GuildData.Lv, false, (float)1);
								if (297477 - 137147 != 160330)
								{
									continue;
								}
								GUI.Label(new Rect((float)205, (float)178, (float)350, (float)40), GuildData.Name, this.f63caGUgsHF);
								if (168308 - 425444 == -257135)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)235, (float)200, (float)30), string.Empty + GuildData.Member.length, this.dnScapASnPv);
								if (66430 - 173459 != -107029)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)265, (float)200, (float)30), string.Empty + GuildData.MemberLv, this.dnScapASnPv);
								if (215548 - 562822 != -347274)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)296, (float)200, (float)30), string.Empty + GuildData.Money, this.dnScapASnPv);
								if (132100 - 440937 != -308837)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)326, (float)200, (float)30), string.Empty + GuildData.Achievement.length + "/30", this.dnScapASnPv);
								if (87421 - 572660 == -485238)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)357, (float)200, (float)30), string.Empty + GuildData.Item.length + "/30", this.dnScapASnPv);
								if (270708 - 225289 == 45420)
								{
									continue;
								}
							}
							else
							{
								Guix.renderSmallTilda(390, 189, false, (float)1);
								if (737 - 559485 == -558747)
								{
									continue;
								}
								GUI.Label(new Rect((float)205, (float)178, (float)350, (float)40), "No Guild", this.f63caGUgsHF);
								if (85345 - 152161 == -66815)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)235, (float)200, (float)30), "--", this.dnScapASnPv);
								if (60892 - 514569 == -453676)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)265, (float)200, (float)30), "--", this.dnScapASnPv);
								if (222946 - 148781 != 74165)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)296, (float)200, (float)30), "--", this.dnScapASnPv);
								if (227120 - 312611 != -85491)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)326, (float)200, (float)30), "--", this.dnScapASnPv);
								if (4251 - 434460 == -430208)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)357, (float)200, (float)30), "--", this.dnScapASnPv);
								if (32667 - 71447 == -38779)
								{
									continue;
								}
								GUI.Label(new Rect((float)200, (float)388, (float)200, (float)30), "--", this.dnScapASnPv);
								if (188482 - 431596 == -243113)
								{
									continue;
								}
							}
							if (this.mTimeOutState == eGuildGuiTimeoutState.none)
							{
								if (180497 - 337360 == -156862)
								{
									continue;
								}
								if (PlayerData.GID == 0)
								{
									if (116281 - 474824 == -358542)
									{
										continue;
									}
									if (this.mState == eGuildGuiState.registration)
									{
										if (244973 - 231725 != 13248)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)193, (float)426, (float)180, (float)42), this.Ao6caRm2WvD.hover.background);
										if (31303 - 338460 == -307156)
										{
											continue;
										}
									}
									else if (GUI.Button(new Rect((float)193, (float)426, (float)180, (float)42), string.Empty, this.Ao6caRm2WvD))
									{
										if (49315 - 307731 == -258415)
										{
											continue;
										}
										this.mState = eGuildGuiState.registration;
										if (126211 - 543980 == -417768)
										{
											continue;
										}
										this.ResetRegistrationMenu();
										if (191935 - 193368 == -1432)
										{
											continue;
										}
										this.audio.PlayOneShot(this.SjUcaeLG42P);
										if (69877 - 520684 == -450806)
										{
											continue;
										}
									}
								}
								else if (this.mTimeOutState == eGuildGuiTimeoutState.leaving)
								{
									if (226073 - 592714 != -366641)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)218, (float)426, (float)126, (float)42), this.fSHcarinCtW.hover.background);
									if (89564 - 522006 == -432441)
									{
										continue;
									}
								}
								else if (GUI.Button(new Rect((float)218, (float)426, (float)126, (float)42), string.Empty, this.fSHcarinCtW))
								{
									if (206524 - 341978 == -135453)
									{
										continue;
									}
									this.mTimeOutState = eGuildGuiTimeoutState.leaving;
									if (278026 - 307450 != -29424)
									{
										continue;
									}
									this.audio.PlayOneShot(this.SjUcaeLG42P);
									if (266962 - 566364 == -299401)
									{
										continue;
									}
								}
								if (this.mState == eGuildGuiState.member)
								{
									if (118404 - 564764 == -446359)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)486, (float)78, (float)97, (float)33), this.By7caYv3ydU.hover.background);
									if (74154 - 47997 == 26158)
									{
										continue;
									}
								}
							}
							GUI.EndGroup();
							if (18926 - 48964 != -30037)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006113 RID: 24851 RVA: 0x00D49408 File Offset: 0x00D47608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMemberMenu()
	{
		if (174427 - 516202 != -341774)
		{
		}
		for (;;)
		{
			this.ct2ca4ooh9x = new GUIStyle();
			if (147678 - 93908 != 53771)
			{
				this.ct2ca4ooh9x.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_rank", typeof(Texture)));
				if (87086 - 45163 != 41924)
				{
					this.ct2ca4ooh9x.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_rank_h", typeof(Texture)));
					if (243099 - 15768 == 227331)
					{
						this.OAvcasgT17G = (Texture)Resources.Load("GameGui/GuildWindow/button_rankDropMenu", typeof(Texture));
						if (194132 - 535217 != -341084)
						{
							this.KOPcaH9R2jf = new GUIStyle();
							if (268086 - 14655 != 253432)
							{
								this.KOPcaH9R2jf.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_rankDropMenu_h", typeof(Texture)));
								if (164342 - 178037 != -13694)
								{
									this.ResetMemberMenu();
									if (200459 - 487234 != -286774)
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

	// Token: 0x06006114 RID: 24852 RVA: 0x00D495BC File Offset: 0x00D477BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMemberMenu()
	{
		this.lP4cagWyeDB = 0;
		this.go5caaKF1Ja = -1;
	}

	// Token: 0x06006115 RID: 24853 RVA: 0x00D495CC File Offset: 0x00D477CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMemberMenu()
	{
		if (211318 - 288181 != -76863)
		{
		}
		for (;;)
		{
			IL_63D:
			GUI.BeginGroup(new Rect(this.iLicgWlh2O4 - (float)950, (float)0, (float)950, (float)1024));
			if (47319 - 17063 != 30257)
			{
				if (PlayerData.GID != 0)
				{
					if (60500 - 45965 != 14535)
					{
						continue;
					}
					if (GuildData.Member != null)
					{
						if (255462 - 558970 == -303507)
						{
							continue;
						}
						int i = this.lP4cagWyeDB * 10;
						if (117637 - 171674 == -54036)
						{
							continue;
						}
						while (i < (this.lP4cagWyeDB + 1) * 10)
						{
							if (GuildData.Member.length > i)
							{
								if (116587 - 47978 == 68610)
								{
									goto IL_63D;
								}
								object obj2;
								object obj = obj2 = GuildData.Member[i];
								if (!(obj is MemberClass))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(MemberClass));
								}
								MemberClass memberClass = (MemberClass)obj2;
								if (160124 - 28737 != 131387)
								{
									goto IL_63D;
								}
								GUI.Label(new Rect((float)510, (float)(185 + i % 10 * 51), (float)250, (float)30), memberClass.name, this.avXcaqB1PWc);
								if (100172 - 457923 != -357751)
								{
									goto IL_63D;
								}
								if (this.go5caaKF1Ja != -1)
								{
									if (233295 - 175177 != 58118)
									{
										goto IL_63D;
									}
									if (this.go5caaKF1Ja != i)
									{
										goto IL_97B;
									}
									if (57283 - 204877 != -147594)
									{
										goto IL_63D;
									}
								}
								if (GuildData.Rank == 1)
								{
									goto IL_6E7;
								}
								if (251392 - 546150 != -294758)
								{
									goto IL_63D;
								}
								if (GuildData.Rank < memberClass.rank)
								{
									if (204188 - 196853 != 7335)
									{
										goto IL_63D;
									}
									goto IL_6E7;
								}
								IL_505:
								int rank = memberClass.rank;
								if (46840 - 283386 == -236545)
								{
									goto IL_63D;
								}
								if (rank == 1)
								{
									if (167293 - 254564 != -87271)
									{
										goto IL_63D;
									}
									GUI.Label(new Rect((float)760, (float)(185 + i % 10 * 51), (float)250, (float)30), "Leader", this.avXcaqB1PWc);
									if (296026 - 292826 != 3201)
									{
										goto IL_97B;
									}
									goto IL_63D;
								}
								else if (rank == 2)
								{
									if (28009 - 122734 != -94725)
									{
										goto IL_63D;
									}
									GUI.Label(new Rect((float)760, (float)(185 + i % 10 * 51), (float)250, (float)30), "SubLeader", this.avXcaqB1PWc);
									if (223872 - 371996 != -148124)
									{
										goto IL_63D;
									}
									goto IL_97B;
								}
								else if (rank == 3)
								{
									if (126801 - 371974 == -245172)
									{
										goto IL_63D;
									}
									GUI.Label(new Rect((float)760, (float)(185 + i % 10 * 51), (float)250, (float)30), "Officer", this.avXcaqB1PWc);
									if (65826 - 575906 != -510080)
									{
										goto IL_63D;
									}
									goto IL_97B;
								}
								else
								{
									if (rank != 4)
									{
										goto IL_97B;
									}
									if (136661 - 104909 != 31752)
									{
										goto IL_63D;
									}
									GUI.Label(new Rect((float)760, (float)(185 + i % 10 * 51), (float)250, (float)30), "Member", this.avXcaqB1PWc);
									if (1271 - 313586 != -312314)
									{
										goto IL_97B;
									}
									goto IL_63D;
								}
								IL_6E7:
								if (!GUI.Button(new Rect((float)740, (float)(180 + i % 10 * 51), (float)145, (float)40), string.Empty, this.ct2ca4ooh9x))
								{
									goto IL_505;
								}
								if (254040 - 363644 != -109604)
								{
									goto IL_63D;
								}
								if (this.go5caaKF1Ja != i)
								{
									if (105102 - 447722 == -342619)
									{
										goto IL_63D;
									}
									this.go5caaKF1Ja = i;
									if (33490 - 461683 == -428192)
									{
										goto IL_63D;
									}
								}
								else
								{
									this.go5caaKF1Ja = -1;
									if (27918 - 399708 == -371789)
									{
										goto IL_63D;
									}
								}
								this.audio.PlayOneShot(this.rUmcaQUJeie);
								if (80141 - 463032 != -382891)
								{
									goto IL_63D;
								}
								goto IL_505;
							}
							IL_97B:
							i++;
							if (128232 - 450278 != -322046)
							{
								goto IL_63D;
							}
						}
						if (284194 - 581312 == -297117)
						{
							continue;
						}
					}
				}
				if (this.go5caaKF1Ja != -1)
				{
					if (126158 - 302456 != -176298)
					{
						continue;
					}
					object obj4;
					object obj3 = obj4 = GuildData.Member[this.go5caaKF1Ja];
					if (!(obj3 is MemberClass))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(MemberClass));
					}
					MemberClass memberClass2 = (MemberClass)obj4;
					if (117126 - 125303 == -8176)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)740, (float)(215 + this.go5caaKF1Ja % 10 * 51), (float)143, (float)98), this.OAvcasgT17G);
					if (210373 - 162886 != 47487)
					{
						continue;
					}
					if (GuildData.Rank == 1)
					{
						goto IL_155;
					}
					if (19161 - 312611 != -293450)
					{
						continue;
					}
					if (GuildData.Rank < memberClass2.rank - 1)
					{
						if (83652 - 360290 != -276637)
						{
							goto IL_155;
						}
						continue;
					}
					IL_484:
					if (!GUI.Button(new Rect((float)740, (float)(279 + this.go5caaKF1Ja % 10 * 51), (float)143, (float)28), "   kick", this.KOPcaH9R2jf))
					{
						goto IL_824;
					}
					if (230363 - 248002 != -17639)
					{
						continue;
					}
					this.go5caaKF1Ja = -1;
					if (234729 - 340393 == -105663)
					{
						continue;
					}
					this.newNoticeBar("This feature is closed", 2f);
					if (104184 - 589017 == -484832)
					{
						continue;
					}
					this.audio.PlayOneShot(this.rUmcaQUJeie);
					if (246976 - 416590 != -169614)
					{
						continue;
					}
					goto IL_824;
					IL_155:
					if (GUI.Button(new Rect((float)740, (float)(224 + this.go5caaKF1Ja % 10 * 51), (float)143, (float)28), "   promote", this.KOPcaH9R2jf))
					{
						if (125428 - 142494 == -17065)
						{
							continue;
						}
						this.go5caaKF1Ja = -1;
						if (203317 - 315295 == -111977)
						{
							continue;
						}
						this.newNoticeBar("This feature is closed", 2f);
						if (230405 - 345426 != -115021)
						{
							continue;
						}
						this.audio.PlayOneShot(this.rUmcaQUJeie);
						if (194252 - 315544 == -121291)
						{
							continue;
						}
					}
					if (!GUI.Button(new Rect((float)740, (float)(252 + this.go5caaKF1Ja % 10 * 51), (float)143, (float)28), "   demote", this.KOPcaH9R2jf))
					{
						goto IL_484;
					}
					if (91611 - 569567 == -477955)
					{
						continue;
					}
					this.go5caaKF1Ja = -1;
					if (10611 - 75763 == -65151)
					{
						continue;
					}
					this.newNoticeBar("This feature is closed", 2f);
					if (164358 - 572526 != -408168)
					{
						continue;
					}
					this.audio.PlayOneShot(this.rUmcaQUJeie);
					if (216808 - 117034 != 99775)
					{
						goto IL_484;
					}
					continue;
				}
				IL_824:
				if (GUI.Button(new Rect((float)569, (float)688, (float)85, (float)57), string.Empty, this.WtkcgzLdS4H))
				{
					if (272404 - 142727 != 129677)
					{
						continue;
					}
					this.lP4cagWyeDB = Mathf.Clamp(this.lP4cagWyeDB - 1, 0, 9);
					if (247581 - 390086 == -142504)
					{
						continue;
					}
					this.audio.PlayOneShot(this.MxBca6eAcK5);
					if (64244 - 455167 != -390923)
					{
						continue;
					}
				}
				if (GUI.Button(new Rect((float)721, (float)688, (float)85, (float)57), string.Empty, this.qJWca5ynFlv))
				{
					if (186290 - 138807 == 47484)
					{
						continue;
					}
					this.lP4cagWyeDB = Mathf.Clamp(this.lP4cagWyeDB + 1, 0, 9);
					if (158006 - 391093 == -233086)
					{
						continue;
					}
					this.audio.PlayOneShot(this.MxBca6eAcK5);
					if (48473 - 18433 == 30041)
					{
						continue;
					}
				}
				GUI.Label(new Rect((float)710, (float)697, (float)50, (float)30), string.Empty + (1 + this.lP4cagWyeDB), this.avXcaqB1PWc);
				if (242903 - 33125 != 209779)
				{
					GUI.EndGroup();
					if (228779 - 125912 == 102867)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006116 RID: 24854 RVA: 0x00D4A050 File Offset: 0x00D48250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitAchievementMenu()
	{
		this.CYqca7wCW86 = (Texture)Resources.Load("GameGui/GuildWindow/bar_achievement", typeof(Texture));
		this.KdVcaZlV3ax = (Texture)Resources.Load("GameGui/GuildWindow/info_achievement", typeof(Texture));
	}

	// Token: 0x06006117 RID: 24855 RVA: 0x00D4A090 File Offset: 0x00D48290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderAchievementMenu()
	{
		if (47565 - 102465 != -54899)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(this.iLicgWlh2O4 - (float)950, (float)0, (float)950, (float)1024));
			if (37405 - 303998 == -266593)
			{
				GUI.DrawTexture(new Rect((float)470, (float)112, (float)429, (float)647), this.CYqca7wCW86);
				if (238468 - 334958 != -96489)
				{
					GUI.DrawTexture(new Rect((float)131, (float)537, (float)299, (float)340), this.KdVcaZlV3ax);
					if (239714 - 580386 == -340672)
					{
						GUI.Label(new Rect((float)710, (float)697, (float)50, (float)30), string.Empty + (1 + this.ghLcaCHLl5Y), this.avXcaqB1PWc);
						if (164323 - 118229 != 46095)
						{
							if (GUI.Button(new Rect((float)569, (float)688, (float)85, (float)57), string.Empty, this.WtkcgzLdS4H))
							{
								if (198081 - 553750 != -355669)
								{
									continue;
								}
								this.ghLcaCHLl5Y = Mathf.Clamp(this.ghLcaCHLl5Y - 1, 0, 9);
								if (82625 - 492718 == -410092)
								{
									continue;
								}
								this.audio.PlayOneShot(this.MxBca6eAcK5);
								if (176087 - 523951 == -347863)
								{
									continue;
								}
							}
							if (GUI.Button(new Rect((float)721, (float)688, (float)85, (float)57), string.Empty, this.qJWca5ynFlv))
							{
								if (75448 - 450217 != -374769)
								{
									continue;
								}
								this.ghLcaCHLl5Y = Mathf.Clamp(this.ghLcaCHLl5Y + 1, 0, 9);
								if (213148 - 586492 == -373343)
								{
									continue;
								}
								this.audio.PlayOneShot(this.MxBca6eAcK5);
								if (125888 - 472405 != -346517)
								{
									continue;
								}
							}
							GUI.EndGroup();
							if (125478 - 242615 == -117137)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006118 RID: 24856 RVA: 0x00D4A33C File Offset: 0x00D4853C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitItemMenu()
	{
		if (267408 - 75834 != 191575)
		{
		}
		for (;;)
		{
			this.lOncafTPnZJ = (Texture)Resources.Load("GameGui/GuildWindow/bar_item", typeof(Texture));
			if (98932 - 114674 == -15742)
			{
				this.CjycaLBVgdJ = (Texture)Resources.Load("GameGui/GuildWindow/info_item", typeof(Texture));
				if (260725 - 552051 == -291326)
				{
					this.J3ncawcIyvD = new GUIStyle();
					if (202949 - 341284 == -138335)
					{
						this.J3ncawcIyvD.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_item_h", typeof(Texture)));
						if (48032 - 568494 != -520461)
						{
							this.J3ncawcIyvD.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_item_h", typeof(Texture)));
							if (136396 - 440400 == -304004)
							{
								this.A72caUt7oMm = new GUIStyle();
								if (290464 - 377151 != -86686)
								{
									this.A72caUt7oMm.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_buyItem_h", typeof(Texture)));
									if (192063 - 418379 != -226315)
									{
										this.HRncaNBTpwO = new GUIStyle();
										if (111656 - 515045 != -403388)
										{
											this.HRncaNBTpwO.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_donate_h", typeof(Texture)));
											if (109994 - 144014 != -34019)
											{
												this.ResetItemMenu();
												if (81685 - 599638 == -517953)
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

	// Token: 0x06006119 RID: 24857 RVA: 0x00D4A598 File Offset: 0x00D48798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetItemMenu()
	{
		if (155417 - 481051 != -325633)
		{
		}
		for (;;)
		{
			this.EH0caEbHdNl = 0;
			if (53859 - 196340 == -142481)
			{
				this.W8icaPn2rkL = 0;
				if (230723 - 167055 != 63669)
				{
					this.HRkca0X0lqS = 0;
					if (200018 - 296352 != -96333)
					{
						this.PWHcaSawihx = new ItemClass[0];
						if (116051 - 442861 != -326809)
						{
							this.CFdcaBr59jX = new Texture[0];
							if (140372 - 101123 != 39250)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600611A RID: 24858 RVA: 0x00D4A680 File Offset: 0x00D48880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderItemMenu()
	{
		if (105742 - 318141 != -212399)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(this.iLicgWlh2O4 - (float)950, (float)0, (float)950, (float)1024));
			if (48536 - 406933 != -358396)
			{
				GUI.DrawTexture(new Rect((float)480, (float)130, (float)411, (float)556), this.lOncafTPnZJ);
				if (219753 - 462679 == -242926)
				{
					GUI.DrawTexture(new Rect((float)131, (float)537, (float)299, (float)340), this.CjycaLBVgdJ);
					if (202319 - 132939 == 69380)
					{
						if (GUI.Button(new Rect((float)321, (float)664, (float)72, (float)37), string.Empty, this.A72caUt7oMm))
						{
							if (159319 - 1437 != 157882)
							{
								continue;
							}
							this.audio.PlayOneShot(this.ivPcaJvWb2B);
							if (81848 - 219323 != -137475)
							{
								continue;
							}
						}
						if (this.W8icaPn2rkL >= Extensions.get_length(this.PWHcaSawihx))
						{
							if (213647 - 121781 != 91866)
							{
								continue;
							}
							GUI.Label(new Rect((float)160, (float)544, (float)300, (float)40), "n/a", this.f63caGUgsHF);
							if (126493 - 381855 != -255362)
							{
								continue;
							}
							GUI.Label(new Rect((float)240, (float)590, (float)180, (float)60), "-", this.HqFca1FjJw1);
							if (112340 - 444889 == -332548)
							{
								continue;
							}
						}
						else if (!RuntimeServices.EqualityOperator(this.PWHcaSawihx[this.W8icaPn2rkL], null))
						{
							if (284663 - 162182 == 122482)
							{
								continue;
							}
							GUI.Label(new Rect((float)160, (float)544, (float)300, (float)40), this.PWHcaSawihx[this.W8icaPn2rkL].name, this.f63caGUgsHF);
							if (213591 - 24069 == 189523)
							{
								continue;
							}
							GUI.Label(new Rect((float)240, (float)590, (float)180, (float)60), this.PWHcaSawihx[this.W8icaPn2rkL].des, this.HqFca1FjJw1);
							if (126340 - 458465 != -332125)
							{
								continue;
							}
						}
						GUI.SetNextControlName("DonateFocus");
						if (228697 - 493233 == -264536)
						{
							string nString = GUI.TextField(new Rect((float)214, (float)776, (float)60, (float)30), string.Empty + this.HRkca0X0lqS, 5, this.dnScapASnPv);
							if (221958 - 154470 == 67488)
							{
								GUI.SetNextControlName("DonateUnfocus");
								if (218640 - 144576 != 74065)
								{
									GUI.TextField(new Rect((float)0, (float)0, (float)0, (float)0), string.Empty);
									if (140767 - 202636 != -61868)
									{
										this.HRkca0X0lqS = Mathf.Clamp(Stringf.getInteger(nString), 0, PlayerData.Gil);
										if (72943 - 445460 != -372516)
										{
											if (GUI.Button(new Rect((float)286, (float)775, (float)22, (float)18), string.Empty, this.K80cacvxbhl))
											{
												if (278777 - 88050 == 190728)
												{
													continue;
												}
												this.HRkca0X0lqS = Mathf.Clamp(this.HRkca0X0lqS + 100, 0, PlayerData.Gil);
												if (38367 - 493367 == -454999)
												{
													continue;
												}
												this.audio.PlayOneShot(this.rUmcaQUJeie);
												if (94057 - 366294 == -272236)
												{
													continue;
												}
											}
											if (GUI.Button(new Rect((float)286, (float)793, (float)22, (float)18), string.Empty, this.CVtcanKrka4))
											{
												if (122783 - 77235 == 45549)
												{
													continue;
												}
												this.HRkca0X0lqS = Mathf.Clamp(this.HRkca0X0lqS - 100, 0, PlayerData.Gil);
												if (88210 - 37883 != 50327)
												{
													continue;
												}
												this.audio.PlayOneShot(this.rUmcaQUJeie);
												if (6333 - 225503 != -219170)
												{
													continue;
												}
											}
											if (GUI.Button(new Rect((float)307, (float)775, (float)92, (float)37), string.Empty, this.HRncaNBTpwO))
											{
												if (160926 - 414304 == -253377)
												{
													continue;
												}
												this.audio.PlayOneShot(this.ivPcaJvWb2B);
												if (232590 - 506430 == -273839)
												{
													continue;
												}
											}
											if (GUI.Button(new Rect((float)569, (float)688, (float)85, (float)57), string.Empty, this.WtkcgzLdS4H))
											{
												if (211908 - 383111 == -171202)
												{
													continue;
												}
												this.EH0caEbHdNl = Mathf.Clamp(this.EH0caEbHdNl - 1, 0, 9);
												if (127322 - 283395 != -156073)
												{
													continue;
												}
												this.audio.PlayOneShot(this.MxBca6eAcK5);
												if (18653 - 194909 == -176255)
												{
													continue;
												}
											}
											if (GUI.Button(new Rect((float)721, (float)688, (float)85, (float)57), string.Empty, this.qJWca5ynFlv))
											{
												if (275687 - 442756 == -167068)
												{
													continue;
												}
												this.EH0caEbHdNl = Mathf.Clamp(this.EH0caEbHdNl + 1, 0, 9);
												if (108468 - 416540 != -308072)
												{
													continue;
												}
												this.audio.PlayOneShot(this.MxBca6eAcK5);
												if (162778 - 404685 == -241906)
												{
													continue;
												}
											}
											GUI.Label(new Rect((float)710, (float)697, (float)50, (float)30), string.Empty + (1 + this.EH0caEbHdNl), this.avXcaqB1PWc);
											if (35311 - 394502 == -359191)
											{
												GUI.EndGroup();
												if (51677 - 142302 != -90624)
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

	// Token: 0x0600611B RID: 24859 RVA: 0x00D4ADEC File Offset: 0x00D48FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitRecipeMenu()
	{
		if (188791 - 388262 != -199471)
		{
		}
		for (;;)
		{
			this.uX8ca8hWBxp = (Texture)Resources.Load("GameGui/GuildWindow/bar_recipe", typeof(Texture));
			if (208998 - 457911 != -248912)
			{
				this.Ux3caiIGxoD = (Texture)Resources.Load("GameGui/GuildWindow/info_recipe", typeof(Texture));
				if (220058 - 482424 != -262365)
				{
					this.ResetRecipeMenu();
					if (266256 - 69941 != 196316)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600611C RID: 24860 RVA: 0x00D4AEB8 File Offset: 0x00D490B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetRecipeMenu()
	{
		if (188089 - 486912 != -298822)
		{
		}
		for (;;)
		{
			IL_15C:
			this.yPvcaDJJYZD = 0;
			if (81396 - 526388 != -444991)
			{
				this.JLccamxB2dO = 0;
				if (71373 - 489017 == -417644)
				{
					if (PlayerData.RecipeList == null)
					{
						if (197413 - 399033 == -201620)
						{
							this.tYFcajAuMeK = new ItemClass[0];
							if (176829 - 344583 != -167753)
							{
								this.HBkcaoWPsIa = new Texture[0];
								if (192175 - 67870 != 124306)
								{
									break;
								}
							}
						}
					}
					else
					{
						UnityScript.Lang.Array array = new UnityScript.Lang.Array();
						if (91637 - 17015 == 74622)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.RecipeList);
							if (251574 - 30354 == 221220)
							{
								while (enumerator.MoveNext())
								{
									object value = enumerator.Current;
									int num = RuntimeServices.UnboxInt32(value);
									if (195348 - 57239 == 138110)
									{
										goto IL_15C;
									}
									string name = RecipeData.getName(num);
									if (42801 - 52454 != -9653)
									{
										goto IL_15C;
									}
									UnityRuntimeServices.Update(enumerator, num);
									if (284238 - 543240 == -259001)
									{
										goto IL_15C;
									}
									if (name != "none")
									{
										if (38617 - 423108 != -384491)
										{
											goto IL_15C;
										}
										array.Add(name);
										if (159884 - 21088 == 138797)
										{
											goto IL_15C;
										}
									}
								}
								if (239844 - 148231 == 91613)
								{
									this.tYFcajAuMeK = new ItemClass[array.length];
									if (122047 - 570252 == -448205)
									{
										this.HBkcaoWPsIa = new Texture[Extensions.get_length(this.tYFcajAuMeK)];
										if (82707 - 4852 != 77856)
										{
											int i = 0;
											if (23525 - 480514 == -456989)
											{
												while (i < array.length)
												{
													object obj2;
													object obj = obj2 = array[i];
													if (!(obj is string))
													{
														obj2 = RuntimeServices.Coerce(obj, typeof(string));
													}
													string text = (string)obj2;
													if (189825 - 104985 == 84841)
													{
														goto IL_15C;
													}
													this.tYFcajAuMeK[i] = RecipeData.getData(text);
													if (39287 - 228698 != -189411)
													{
														goto IL_15C;
													}
													this.HBkcaoWPsIa[i] = (Texture)Resources.Load("GameGui/Icons/Items/Recipe/" + text.Substring(2, 3), typeof(Texture));
													if (57343 - 84358 == -27014)
													{
														goto IL_15C;
													}
													i++;
													if (2899 - 161034 != -158135)
													{
														goto IL_15C;
													}
												}
												if (158153 - 186689 == -28536)
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

	// Token: 0x0600611D RID: 24861 RVA: 0x00D4B24C File Offset: 0x00D4944C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderRecipeMenu()
	{
		if (64239 - 76729 != -12490)
		{
		}
		for (;;)
		{
			IL_2E4:
			GUI.BeginGroup(new Rect(this.iLicgWlh2O4 - (float)950, (float)0, (float)950, (float)1024));
			if (41974 - 373656 != -331681)
			{
				GUI.DrawTexture(new Rect((float)480, (float)130, (float)411, (float)556), this.uX8ca8hWBxp);
				if (201435 - 10915 != 190521)
				{
					GUI.DrawTexture(new Rect((float)131, (float)537, (float)299, (float)340), this.Ux3caiIGxoD);
					if (287936 - 299142 == -11206)
					{
						if (this.JLccamxB2dO >= Extensions.get_length(this.tYFcajAuMeK))
						{
							if (142375 - 102194 == 40182)
							{
								continue;
							}
							GUI.Label(new Rect((float)160, (float)544, (float)300, (float)40), "n/a", this.f63caGUgsHF);
							if (291097 - 270436 == 20662)
							{
								continue;
							}
							GUI.Label(new Rect((float)240, (float)590, (float)180, (float)60), "-", this.HqFca1FjJw1);
							if (26953 - 497348 != -470395)
							{
								continue;
							}
						}
						else if (!RuntimeServices.EqualityOperator(this.tYFcajAuMeK[this.JLccamxB2dO], null))
						{
							if (150729 - 352872 != -202143)
							{
								continue;
							}
							GUI.Label(new Rect((float)160, (float)544, (float)300, (float)40), this.tYFcajAuMeK[this.JLccamxB2dO].name, this.f63caGUgsHF);
							if (222752 - 460444 != -237692)
							{
								continue;
							}
							GUI.Label(new Rect((float)240, (float)590, (float)180, (float)60), this.tYFcajAuMeK[this.JLccamxB2dO].des, this.HqFca1FjJw1);
							if (73964 - 95294 == -21329)
							{
								continue;
							}
						}
						if (PlayerData.GID != 0)
						{
							if (75087 - 338836 == -263748)
							{
								continue;
							}
							if (this.tYFcajAuMeK != null)
							{
								if (172093 - 175139 != -3046)
								{
									continue;
								}
								int i = 10 * this.yPvcaDJJYZD;
								if (253032 - 354838 == -101805)
								{
									continue;
								}
								while (i < 10 * (this.yPvcaDJJYZD + 1))
								{
									if (Extensions.get_length(this.tYFcajAuMeK) > i)
									{
										if (61782 - 445347 == -383564)
										{
											goto IL_2E4;
										}
										if (this.tYFcajAuMeK[i] != null)
										{
											if (50401 - 511172 == -460770)
											{
												goto IL_2E4;
											}
											GUI.Label(new Rect((float)560, (float)(180 + i % 10 * 51), (float)250, (float)30), this.tYFcajAuMeK[i].name, this.avXcaqB1PWc);
											if (191649 - 362700 == -171050)
											{
												goto IL_2E4;
											}
										}
										if (this.HBkcaoWPsIa[i])
										{
											if (184101 - 255693 != -71592)
											{
												goto IL_2E4;
											}
											GUI.DrawTexture(new Rect((float)489, (float)(166 + i % 10 * 51), (float)64, (float)64), this.HBkcaoWPsIa[i]);
											if (239216 - 366786 != -127570)
											{
												goto IL_2E4;
											}
										}
									}
									i++;
									if (106206 - 362505 == -256298)
									{
										goto IL_2E4;
									}
								}
								if (79510 - 38549 != 40961)
								{
									continue;
								}
							}
						}
						if (GUI.Button(new Rect((float)569, (float)688, (float)85, (float)57), string.Empty, this.WtkcgzLdS4H))
						{
							if (225365 - 175724 != 49641)
							{
								continue;
							}
							this.yPvcaDJJYZD = Mathf.Clamp(this.yPvcaDJJYZD - 1, 0, 9);
							if (59595 - 328226 != -268631)
							{
								continue;
							}
							this.audio.PlayOneShot(this.MxBca6eAcK5);
							if (93850 - 424483 == -330632)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect((float)721, (float)688, (float)85, (float)57), string.Empty, this.qJWca5ynFlv))
						{
							if (282777 - 36056 == 246722)
							{
								continue;
							}
							this.yPvcaDJJYZD = Mathf.Clamp(this.yPvcaDJJYZD + 1, 0, 9);
							if (194508 - 136123 == 58386)
							{
								continue;
							}
							this.audio.PlayOneShot(this.MxBca6eAcK5);
							if (145404 - 33811 == 111594)
							{
								continue;
							}
						}
						GUI.Label(new Rect((float)710, (float)697, (float)50, (float)30), string.Empty + (1 + this.yPvcaDJJYZD), this.avXcaqB1PWc);
						if (223073 - 229958 == -6885)
						{
							GUI.EndGroup();
							if (196602 - 452250 != -255647)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600611E RID: 24862 RVA: 0x00D4B864 File Offset: 0x00D49A64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitRegistrationMenu()
	{
		if (67293 - 229663 != -162369)
		{
		}
		for (;;)
		{
			IL_1A:
			this.MSvcakLAbep = (Texture)Resources.Load("GameGui/GuildWindow/bar_registration", typeof(Texture));
			if (16115 - 203916 != -187800)
			{
				this.zcacaVBLNuY = new GUIStyle();
				if (190646 - 399278 == -208632)
				{
					this.zcacaVBLNuY.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_create_h", typeof(Texture)));
					if (132029 - 395658 == -263629)
					{
						this.W46cahcDTQK = new GUIStyle();
						if (284207 - 490332 == -206125)
						{
							this.W46cahcDTQK.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_backPage_h", typeof(Texture)));
							if (35630 - 515947 == -480317)
							{
								this.fihcaKVuXir = new GUIStyle();
								if (223218 - 370192 == -146974)
								{
									this.fihcaKVuXir.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_nextPage_h", typeof(Texture)));
									if (196016 - 481669 != -285652)
									{
										this.BKGcazVZZT6 = new GUIStyle();
										if (119635 - 538003 == -418368)
										{
											this.BKGcazVZZT6.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GuildWindow/button_guildIcon_h", typeof(Texture)));
											if (219611 - 252274 != -32662)
											{
												this.ayncauxG0X3 = new Texture[this.O0Fc4nkuQGI];
												if (114183 - 556015 == -441832)
												{
													this.eNdcay7q6l8 = new Texture[this.O0Fc4nkuQGI];
													if (180351 - 316010 == -135659)
													{
														int i = 0;
														if (145323 - 506177 == -360854)
														{
															while (i < this.O0Fc4nkuQGI)
															{
																this.ayncauxG0X3[i] = (Texture)Resources.Load("GameGui/Icons/Guild/a" + (i + 1), typeof(Texture));
																if (139782 - 57747 != 82035)
																{
																	goto IL_1A;
																}
																this.eNdcay7q6l8[i] = (Texture)Resources.Load("GameGui/Icons/Guild/b" + (i + 1), typeof(Texture));
																if (183575 - 497911 == -314335)
																{
																	goto IL_1A;
																}
																i++;
																if (272059 - 157559 != 114500)
																{
																	goto IL_1A;
																}
															}
															if (284675 - 212409 != 72267)
															{
																this.ResetRegistrationMenu();
																if (66198 - 399924 == -333726)
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

	// Token: 0x0600611F RID: 24863 RVA: 0x00D4BBF4 File Offset: 0x00D49DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetRegistrationMenu()
	{
		if (26333 - 119593 != -93260)
		{
		}
		for (;;)
		{
			this.eVccaFeYygu = "New guild name";
			if (136813 - 391556 == -254743)
			{
				this.dtScaAsBX0X = UnityEngine.Random.Range(1, this.O0Fc4nkuQGI) * 100 + UnityEngine.Random.Range(1, this.O0Fc4nkuQGI);
				if (190387 - 107597 == 82790)
				{
					this.SNYc45Bk9ks = 0;
					if (5132 - 39825 != -34692)
					{
						this.Qayc4coSBRd = 0;
						if (134624 - 298799 != -164174)
						{
							this.AgTca9rFki5 = this.ayncauxG0X3[global::Math.div((float)this.dtScaAsBX0X, (float)100) - 1];
							if (247799 - 394372 == -146573)
							{
								this.zmhcaWRafpy = this.eNdcay7q6l8[this.dtScaAsBX0X % 100 - 1];
								if (16669 - 281422 != -264752)
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

	// Token: 0x06006120 RID: 24864 RVA: 0x00D4BD3C File Offset: 0x00D49F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderRegistrationMenu()
	{
		if (200230 - 530047 != -329817)
		{
		}
		for (;;)
		{
			IL_199:
			GUI.BeginGroup(new Rect(this.iLicgWlh2O4 - (float)950, (float)0, (float)950, (float)1024));
			if (20352 - 217374 != -197021)
			{
				GUI.DrawTexture(new Rect((float)467, (float)68, (float)437, (float)696), this.MSvcakLAbep);
				if (26488 - 579535 == -553047)
				{
					if (this.zmhcaWRafpy)
					{
						if (258370 - 57375 == 200996)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)542, (float)205, (float)48, (float)48), this.zmhcaWRafpy);
						if (93237 - 218126 != -124889)
						{
							continue;
						}
					}
					if (this.AgTca9rFki5)
					{
						if (172084 - 217098 != -45014)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)542, (float)205, (float)48, (float)48), this.AgTca9rFki5);
						if (256620 - 331316 != -74696)
						{
							continue;
						}
					}
					GUI.DrawTexture(new Rect((float)531, (float)195, (float)69, (float)69), this.BKGcazVZZT6.hover.background);
					if (166648 - 323272 == -156624)
					{
						if (Event.current.type == EventType.KeyDown)
						{
							if (107351 - 268194 != -160843)
							{
								continue;
							}
							if (Event.current.character == "\n")
							{
								if (120078 - 536462 != -416384)
								{
									continue;
								}
								if (RuntimeServices.EqualityOperator(string.IsNullOrEmpty(GUI.GetNameOfFocusedControl()), "GuildNameField"))
								{
									if (275642 - 114135 != 161507)
									{
										continue;
									}
									GUI.FocusControl("GuildNameField");
									if (273235 - 423066 != -149831)
									{
										continue;
									}
								}
								goto IL_4AE;
							}
						}
						GUI.SetNextControlName("GuildNameField");
						if (69667 - 360160 == -290492)
						{
							continue;
						}
						this.eVccaFeYygu = GUI.TextField(new Rect((float)620, (float)221, (float)220, (float)40), this.eVccaFeYygu, 15, this.avXcaqB1PWc);
						if (34580 - 446082 == -411501)
						{
							continue;
						}
						IL_4AE:
						if (GUI.Button(new Rect((float)619, (float)305, (float)131, (float)38), string.Empty, this.zcacaVBLNuY))
						{
							if (23934 - 60639 == -36704)
							{
								continue;
							}
							this.mTimeOutState = eGuildGuiTimeoutState.creating;
							if (41906 - 195566 == -153659)
							{
								continue;
							}
							this.audio.PlayOneShot(this.ivPcaJvWb2B);
							if (138625 - 153685 != -15060)
							{
								continue;
							}
						}
						int i = 0;
						if (190493 - 328373 == -137880)
						{
							while (i < 5)
							{
								if (GUI.Button(new Rect((float)(549 + i * 57), (float)465, (float)46, (float)46), string.Empty, this.BKGcazVZZT6))
								{
									if (257154 - 19665 == 237490)
									{
										goto IL_199;
									}
									this.dtScaAsBX0X = global::Math.div((float)this.dtScaAsBX0X, (float)100) * 100 + i + this.Qayc4coSBRd * 5 + 1;
									if (117000 - 136269 == -19268)
									{
										goto IL_199;
									}
									this.zmhcaWRafpy = this.eNdcay7q6l8[this.dtScaAsBX0X % 100 - 1];
									if (34647 - 465712 == -431064)
									{
										goto IL_199;
									}
									this.audio.PlayOneShot(this.rUmcaQUJeie);
									if (96463 - 468820 != -372357)
									{
										goto IL_199;
									}
								}
								GUI.DrawTexture(new Rect((float)(556 + 57 * i), (float)473, (float)32, (float)32), this.eNdcay7q6l8[i + this.Qayc4coSBRd * 5]);
								if (13164 - 521417 != -508253)
								{
									goto IL_199;
								}
								i++;
								if (270393 - 119239 == 151155)
								{
									goto IL_199;
								}
							}
							if (136618 - 263229 != -126610)
							{
								if (GUI.Button(new Rect((float)486, (float)467, (float)66, (float)44), string.Empty, this.W46cahcDTQK))
								{
									if (147474 - 407879 == -260404)
									{
										continue;
									}
									this.Qayc4coSBRd = (int)Mathf.Repeat((float)(this.Qayc4coSBRd - 1), (float)global::Math.div((float)this.O0Fc4nkuQGI, (float)5));
									if (243198 - 270141 != -26943)
									{
										continue;
									}
									this.audio.PlayOneShot(this.rUmcaQUJeie);
									if (297996 - 30172 != 267824)
									{
										continue;
									}
								}
								if (GUI.Button(new Rect((float)820, (float)467, (float)66, (float)44), string.Empty, this.fihcaKVuXir))
								{
									if (138328 - 514768 == -376439)
									{
										continue;
									}
									this.Qayc4coSBRd = (int)Mathf.Repeat((float)(this.Qayc4coSBRd + 1), (float)global::Math.div((float)this.O0Fc4nkuQGI, (float)5));
									if (218395 - 369370 == -150974)
									{
										continue;
									}
									this.audio.PlayOneShot(this.rUmcaQUJeie);
									if (65761 - 247489 == -181727)
									{
										continue;
									}
								}
								int j = 0;
								if (131104 - 431843 != -300738)
								{
									while (j < 5)
									{
										if (GUI.Button(new Rect((float)(547 + j * 57), (float)576, (float)46, (float)46), string.Empty, this.BKGcazVZZT6))
										{
											if (213975 - 511325 == -297349)
											{
												goto IL_199;
											}
											this.dtScaAsBX0X = (j + this.SNYc45Bk9ks * 10 + 1) * 100 + this.dtScaAsBX0X % 100;
											if (122278 - 233159 == -110880)
											{
												goto IL_199;
											}
											this.AgTca9rFki5 = this.ayncauxG0X3[global::Math.div((float)this.dtScaAsBX0X, (float)100) - 1];
											if (59873 - 364217 != -304344)
											{
												goto IL_199;
											}
											this.audio.PlayOneShot(this.rUmcaQUJeie);
											if (234275 - 172933 == 61343)
											{
												goto IL_199;
											}
										}
										if (GUI.Button(new Rect((float)(547 + j * 57), (float)629, (float)46, (float)46), string.Empty, this.BKGcazVZZT6))
										{
											if (79686 - 498621 != -418935)
											{
												goto IL_199;
											}
											this.dtScaAsBX0X = (j + this.SNYc45Bk9ks * 10 + 5 + 1) * 100 + this.dtScaAsBX0X % 100;
											if (75406 - 593219 != -517813)
											{
												goto IL_199;
											}
											this.AgTca9rFki5 = this.ayncauxG0X3[global::Math.div((float)this.dtScaAsBX0X, (float)100) - 1];
											if (180422 - 71577 != 108845)
											{
												goto IL_199;
											}
											this.audio.PlayOneShot(this.rUmcaQUJeie);
											if (259419 - 548685 == -289265)
											{
												goto IL_199;
											}
										}
										GUI.DrawTexture(new Rect((float)(556 + 57 * j), (float)584, (float)32, (float)32), this.ayncauxG0X3[j + this.SNYc45Bk9ks * 10]);
										if (224045 - 349143 != -125098)
										{
											goto IL_199;
										}
										GUI.DrawTexture(new Rect((float)(556 + 57 * j), (float)638, (float)32, (float)32), this.ayncauxG0X3[j + this.SNYc45Bk9ks * 10 + 5]);
										if (77808 - 304434 != -226626)
										{
											goto IL_199;
										}
										j++;
										if (270107 - 320956 != -50849)
										{
											goto IL_199;
										}
									}
									if (32605 - 43353 != -10747)
									{
										if (GUI.Button(new Rect((float)486, (float)604, (float)66, (float)44), string.Empty, this.W46cahcDTQK))
										{
											if (124827 - 535146 == -410318)
											{
												continue;
											}
											this.SNYc45Bk9ks = (int)Mathf.Repeat((float)(this.SNYc45Bk9ks - 1), (float)global::Math.div((float)this.O0Fc4nkuQGI, (float)10));
											if (45466 - 235606 == -190139)
											{
												continue;
											}
											this.audio.PlayOneShot(this.rUmcaQUJeie);
											if (26191 - 195590 == -169398)
											{
												continue;
											}
										}
										if (GUI.Button(new Rect((float)820, (float)604, (float)66, (float)44), string.Empty, this.fihcaKVuXir))
										{
											if (25124 - 483414 == -458289)
											{
												continue;
											}
											this.SNYc45Bk9ks = (int)Mathf.Repeat((float)(this.SNYc45Bk9ks + 1), (float)global::Math.div((float)this.O0Fc4nkuQGI, (float)10));
											if (110957 - 469942 == -358984)
											{
												continue;
											}
											this.audio.PlayOneShot(this.rUmcaQUJeie);
											if (85907 - 227754 == -141846)
											{
												continue;
											}
										}
										GUI.EndGroup();
										if (101051 - 244354 == -143303)
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

	// Token: 0x06006121 RID: 24865 RVA: 0x00D4C80C File Offset: 0x00D4AA0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNoticeBar()
	{
		if (88109 - 132984 != -44874)
		{
		}
		for (;;)
		{
			this.Vjfc4QXx4YA = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (191604 - 355576 != -163971)
			{
				this.IyDc4e2asgj = new GUIStyle();
				if (77460 - 539053 != -461592)
				{
					this.IyDc4e2asgj.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (150931 - 20549 == 130382)
					{
						this.IyDc4e2asgj.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (67043 - 537771 != -470727)
						{
							this.IyDc4e2asgj.alignment = TextAnchor.MiddleCenter;
							if (4587 - 349528 == -344941)
							{
								this.Qytc4IZvZBn = new GUIStyle();
								if (43231 - 280898 == -237667)
								{
									this.Qytc4IZvZBn.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_yes", typeof(Texture)));
									if (280279 - 553053 == -272774)
									{
										this.Qytc4IZvZBn.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_yes_h", typeof(Texture)));
										if (290563 - 166274 != 124290)
										{
											this.HUhc4Jj6H6M = new GUIStyle();
											if (155392 - 539932 != -384539)
											{
												this.HUhc4Jj6H6M.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_no", typeof(Texture)));
												if (289695 - 383350 != -93654)
												{
													this.HUhc4Jj6H6M.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_no_h", typeof(Texture)));
													if (159194 - 503833 == -344639)
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

	// Token: 0x06006122 RID: 24866 RVA: 0x00D4CAB0 File Offset: 0x00D4ACB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newNoticeBar(string s, float t)
	{
		if (283904 - 226159 != 57745)
		{
		}
		for (;;)
		{
			this.IVbc46bF2NA = s;
			if (76075 - 406684 == -330609)
			{
				this.mTimeOutState = eGuildGuiTimeoutState.message;
				if (59865 - 87352 != -27486)
				{
					this.Hlicg9YAaO2 = Time.time + t;
					if (226432 - 216595 == 9837)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006123 RID: 24867 RVA: 0x00D4CB54 File Offset: 0x00D4AD54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar()
	{
		if (65416 - 588412 != -522996)
		{
		}
		for (;;)
		{
			eGuildGuiTimeoutState eGuildGuiTimeoutState = this.mTimeOutState;
			if (199761 - 33346 != 166416)
			{
				if (eGuildGuiTimeoutState == eGuildGuiTimeoutState.timeout)
				{
					if (253608 - 454090 == -200482)
					{
						if (this.Hlicg9YAaO2 >= Time.time)
						{
							break;
						}
						if (224938 - 100588 != 124351)
						{
							this.mTimeOutState = eGuildGuiTimeoutState.none;
							if (224961 - 349709 != -124747)
							{
								break;
							}
						}
					}
				}
				else if (eGuildGuiTimeoutState == eGuildGuiTimeoutState.message)
				{
					if (118501 - 243135 == -124634)
					{
						if (this.Hlicg9YAaO2 > Time.time)
						{
							if (182430 - 22478 != 159953)
							{
								GUI.DrawTexture(new Rect(this.iLicgWlh2O4 - (float)680, (float)470, (float)475, (float)102), this.Vjfc4QXx4YA);
								if (286566 - 27704 == 258862)
								{
									GUI.Label(new Rect(this.iLicgWlh2O4 - (float)640, (float)498, (float)400, (float)40), this.IVbc46bF2NA, this.IyDc4e2asgj);
									if (37954 - 372645 == -334691)
									{
										break;
									}
								}
							}
						}
						else
						{
							this.mTimeOutState = eGuildGuiTimeoutState.none;
							if (146344 - 167652 != -21307)
							{
								break;
							}
						}
					}
				}
				else if (eGuildGuiTimeoutState == eGuildGuiTimeoutState.creating)
				{
					if (19454 - 243593 != -224138)
					{
						GUI.DrawTexture(new Rect(this.iLicgWlh2O4 - (float)680, (float)470, (float)475, (float)102), this.Vjfc4QXx4YA);
						if (235034 - 52152 != 182883)
						{
							GUI.Label(new Rect(this.iLicgWlh2O4 - (float)640, (float)498, (float)400, (float)40), "Create new guild?", this.IyDc4e2asgj);
							if (238014 - 306479 != -68464)
							{
								if (GUI.Button(new Rect(this.iLicgWlh2O4 - (float)430, (float)540, (float)78, (float)40), string.Empty, this.Qytc4IZvZBn))
								{
									if (33096 - 35234 != -2138)
									{
										continue;
									}
									if (this.eVccaFeYygu == "New guild name")
									{
										if (176809 - 289947 != -113138)
										{
											continue;
										}
										this.newNoticeBar("Please name your guild", 2f);
										if (188683 - 121641 == 67043)
										{
											continue;
										}
										this.audio.PlayOneShot(this.xXTcaIoE07t);
										if (71839 - 319528 != -247689)
										{
											continue;
										}
									}
									else if (PlayerData.Jil < 1000)
									{
										if (11205 - 210230 != -199025)
										{
											continue;
										}
										this.newNoticeBar("Not enough jil", 2f);
										if (5144 - 270485 == -265340)
										{
											continue;
										}
										this.audio.PlayOneShot(this.xXTcaIoE07t);
										if (42888 - 149598 != -106710)
										{
											continue;
										}
									}
									else if (!SafeLetter.isSafe(this.eVccaFeYygu))
									{
										if (176262 - 290056 == -113793)
										{
											continue;
										}
										this.newNoticeBar("Can only use a-z and 0-9", 2f);
										if (196876 - 277828 != -80952)
										{
											continue;
										}
										this.audio.PlayOneShot(this.xXTcaIoE07t);
										if (75370 - 549141 == -473770)
										{
											continue;
										}
									}
									else if (!SafeName.isSafe(this.eVccaFeYygu))
									{
										if (280455 - 90253 != 190202)
										{
											continue;
										}
										this.newNoticeBar("Name contains protected name", 2f);
										if (133903 - 36085 != 97818)
										{
											continue;
										}
										this.audio.PlayOneShot(this.xXTcaIoE07t);
										if (191477 - 478584 == -287106)
										{
											continue;
										}
									}
									else if (!SafeWord.isSafe(this.eVccaFeYygu))
									{
										if (66248 - 441815 != -375567)
										{
											continue;
										}
										this.newNoticeBar("Name contains bad word", 2f);
										if (67451 - 150682 != -83231)
										{
											continue;
										}
										this.audio.PlayOneShot(this.xXTcaIoE07t);
										if (227563 - 307017 != -79454)
										{
											continue;
										}
									}
									else if (!Stringf.isSafe(this.eVccaFeYygu))
									{
										if (233044 - 287920 != -54876)
										{
											continue;
										}
										this.newNoticeBar("Name contains illegal word", 2f);
										if (13704 - 92496 == -78791)
										{
											continue;
										}
										this.audio.PlayOneShot(this.xXTcaIoE07t);
										if (142360 - 599827 != -457467)
										{
											continue;
										}
									}
									else
									{
										this.GuildCreate();
										if (105385 - 583043 == -477657)
										{
											continue;
										}
										this.newNoticeBar("Registering new guild...", 3f);
										if (96915 - 242622 == -145706)
										{
											continue;
										}
										this.audio.PlayOneShot(this.ivPcaJvWb2B);
										if (92758 - 303089 != -210331)
										{
											continue;
										}
									}
								}
								if (!GUI.Button(new Rect(this.iLicgWlh2O4 - (float)340, (float)540, (float)79, (float)40), string.Empty, this.HUhc4Jj6H6M))
								{
									break;
								}
								if (206004 - 512910 == -306906)
								{
									this.mTimeOutState = eGuildGuiTimeoutState.none;
									if (245907 - 107663 == 138244)
									{
										this.audio.PlayOneShot(this.xXTcaIoE07t);
										if (151397 - 548597 != -397199)
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
					if (eGuildGuiTimeoutState != eGuildGuiTimeoutState.leaving)
					{
						break;
					}
					if (34428 - 47263 == -12835)
					{
						GUI.DrawTexture(new Rect(this.iLicgWlh2O4 - (float)680, (float)470, (float)475, (float)102), this.Vjfc4QXx4YA);
						if (200601 - 446764 != -246162)
						{
							GUI.Label(new Rect(this.iLicgWlh2O4 - (float)640, (float)498, (float)400, (float)40), "Leave your guild?", this.IyDc4e2asgj);
							if (266705 - 131253 == 135452)
							{
								if (GUI.Button(new Rect(this.iLicgWlh2O4 - (float)430, (float)540, (float)78, (float)40), string.Empty, this.Qytc4IZvZBn))
								{
									if (159579 - 524328 == -364748)
									{
										continue;
									}
									this.LeaveGuild();
									if (26081 - 586715 != -560634)
									{
										continue;
									}
									this.newNoticeBar("Leaving guild", 3f);
									if (195493 - 442788 != -247295)
									{
										continue;
									}
									this.audio.PlayOneShot(this.ivPcaJvWb2B);
									if (61499 - 3748 != 57751)
									{
										continue;
									}
								}
								if (!GUI.Button(new Rect(this.iLicgWlh2O4 - (float)340, (float)540, (float)79, (float)40), string.Empty, this.HUhc4Jj6H6M))
								{
									break;
								}
								if (3644 - 530653 == -527009)
								{
									this.mTimeOutState = eGuildGuiTimeoutState.none;
									if (250129 - 131074 != 119056)
									{
										this.audio.PlayOneShot(this.xXTcaIoE07t);
										if (99907 - 30607 == 69300)
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

	// Token: 0x06006124 RID: 24868 RVA: 0x00D4D46C File Offset: 0x00D4B66C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GuildCreate()
	{
		if (269788 - 586214 != -316425)
		{
		}
		for (;;)
		{
			Debug.Log("Registering new guild :" + this.eVccaFeYygu + "@" + this.dtScaAsBX0X);
			if (258229 - 589147 != -330917)
			{
				Hashtable hashtable = new Hashtable();
				if (267042 - 539732 == -272690)
				{
					hashtable.Add(43, PlayerData.UID);
					if (206171 - 184353 == 21818)
					{
						hashtable.Add(21, this.eVccaFeYygu);
						if (279417 - 127045 == 152372)
						{
							hashtable.Add(22, PhotonClient.cInt16(this.dtScaAsBX0X));
							if (93513 - 515672 != -422158)
							{
								PhotonClient.Connection.OpCustom(225, hashtable, true);
								if (101365 - 288073 != -186707)
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

	// Token: 0x06006125 RID: 24869 RVA: 0x00D4D5D0 File Offset: 0x00D4B7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGuildCreate(Hashtable data)
	{
		if (255121 - 446633 != -191512)
		{
		}
		for (;;)
		{
			Debug.Log("onCreateNewGuild");
			if (76716 - 135433 == -58717)
			{
				int num = RuntimeServices.UnboxInt32(data[47]);
				if (257457 - 106819 != 150639)
				{
					int jil = RuntimeServices.UnboxInt32(data[49]);
					if (7456 - 184771 != -177314)
					{
						if (num > 0)
						{
							if (268657 - 9919 == 258738)
							{
								this.newNoticeBar("Guild register successful", 2f);
								if (63181 - 506402 == -443221)
								{
									this.mState = eGuildGuiState.member;
									if (113918 - 11890 != 102029)
									{
										PlayerData.Jil = jil;
										if (191244 - 253344 != -62099)
										{
											GuildData.LoadHashData(data);
											if (268235 - 471731 == -203496)
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
							int num2 = num;
							if (50548 - 539079 != -488530)
							{
								if (num2 == -1)
								{
									if (149719 - 165399 != -15679)
									{
										this.newNoticeBar("Error: Duplicated GID!", 2f);
										if (69827 - 187589 == -117762)
										{
											break;
										}
									}
								}
								else if (num2 == -2)
								{
									if (120756 - 568506 == -447750)
									{
										this.newNoticeBar("Error: Duplicated Name!", 2f);
										if (55202 - 50732 == 4470)
										{
											break;
										}
									}
								}
								else
								{
									this.newNoticeBar("Guild register fail!", 2f);
									if (189453 - 202018 != -12564)
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

	// Token: 0x06006126 RID: 24870 RVA: 0x00D4D824 File Offset: 0x00D4BA24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGuild()
	{
		if (233291 - 522381 != -289089)
		{
		}
		for (;;)
		{
			Debug.Log("Leaving guild :" + this.eVccaFeYygu);
			if (134384 - 105967 == 28417)
			{
				Hashtable hashtable = new Hashtable();
				if (204068 - 438704 == -234636)
				{
					hashtable.Add(43, PlayerData.UID);
					if (46783 - 343987 != -297203)
					{
						hashtable.Add(47, PlayerData.GID);
						if (247549 - 398780 != -151230)
						{
							hashtable.Add(21, PlayerData.UID);
							if (17353 - 121016 != -103662)
							{
								PhotonClient.Connection.OpCustom(227, hashtable, true);
								if (8777 - 297611 == -288834)
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

	// Token: 0x06006127 RID: 24871 RVA: 0x00D4D96C File Offset: 0x00D4BB6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGuild(bool success)
	{
		if (106195 - 322669 != -216473)
		{
		}
		for (;;)
		{
			if (success)
			{
				if (195560 - 22429 == 173131)
				{
					this.newNoticeBar("Leave guild successful", 2f);
					if (78692 - 532528 == -453836)
					{
						this.mState = eGuildGuiState.member;
						if (196695 - 490647 != -293951)
						{
							break;
						}
					}
				}
			}
			else
			{
				this.newNoticeBar("Leave guild fail!", 2f);
				if (268445 - 311756 == -43311)
				{
					this.mState = eGuildGuiState.member;
					if (245984 - 381776 == -135792)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006128 RID: 24872 RVA: 0x00D4DA60 File Offset: 0x00D4BC60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRemoveMember(bool success)
	{
		if (28429 - 504073 != -475643)
		{
		}
		for (;;)
		{
			if (success)
			{
				if (71691 - 116878 != -45186)
				{
					this.newNoticeBar("Remove palyer successful", 2f);
					if (123134 - 149196 != -26061)
					{
						break;
					}
				}
			}
			else
			{
				this.newNoticeBar("Remove palyer fail!", 2f);
				if (134920 - 305510 == -170590)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006129 RID: 24873 RVA: 0x00D4DB14 File Offset: 0x00D4BD14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void BuyGuildItem(int nItem)
	{
		if (129241 - 174755 != -45514)
		{
		}
		for (;;)
		{
			Debug.Log("Buying Guild Item :" + nItem);
			if (115076 - 168687 != -53610)
			{
				Hashtable hashtable = new Hashtable();
				if (14407 - 581443 != -567035)
				{
					hashtable.Add(43, PlayerData.UID);
					if (268304 - 420455 != -152150)
					{
						hashtable.Add(47, PlayerData.GID);
						if (192857 - 524372 == -331515)
						{
							hashtable.Add(21, PhotonClient.cInt16(2));
							if (194638 - 341190 != -146551)
							{
								hashtable.Add(22, PhotonClient.cInt16(nItem));
								if (240290 - 491769 == -251479)
								{
									PhotonClient.Connection.OpCustom(228, hashtable, true);
									if (176190 - 135548 == 40642)
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

	// Token: 0x0600612A RID: 24874 RVA: 0x00D4DC90 File Offset: 0x00D4BE90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DonateGuildMoney(int nMoney)
	{
		if (103107 - 246411 != -143304)
		{
		}
		for (;;)
		{
			Debug.Log("Donating Guild Money :" + nMoney);
			if (184364 - 94307 != 90058)
			{
				Hashtable hashtable = new Hashtable();
				if (259115 - 507098 != -247982)
				{
					hashtable.Add(43, PlayerData.UID);
					if (297889 - 468375 != -170485)
					{
						hashtable.Add(47, PlayerData.GID);
						if (139767 - 72028 == 67739)
						{
							hashtable.Add(21, PhotonClient.cInt16(3));
							if (50729 - 282735 != -232005)
							{
								hashtable.Add(22, PhotonClient.cInt16(nMoney));
								if (175286 - 559888 == -384602)
								{
									PhotonClient.Connection.OpCustom(228, hashtable, true);
									if (37545 - 99560 == -62015)
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

	// Token: 0x0600612B RID: 24875 RVA: 0x00D4DE0C File Offset: 0x00D4C00C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600612C RID: 24876 RVA: 0x00D4DE10 File Offset: 0x00D4C010
	internal static bool X1iETcpXTDZ23F9aXuyc()
	{
		return true;
	}

	// Token: 0x0600612D RID: 24877 RVA: 0x00D4DE14 File Offset: 0x00D4C014
	internal static bool SNpAFhpX38pPYWPJVb9W()
	{
		return false;
	}

	// Token: 0x04006DBA RID: 28090
	public int posx;

	// Token: 0x04006DBB RID: 28091
	public int posy;

	// Token: 0x04006DBC RID: 28092
	public int posa;

	// Token: 0x04006DBD RID: 28093
	public int posb;

	// Token: 0x04006DBE RID: 28094
	public int divx;

	// Token: 0x04006DBF RID: 28095
	public int divy;

	// Token: 0x04006DC0 RID: 28096
	public int diva;

	// Token: 0x04006DC1 RID: 28097
	public int divb;

	// Token: 0x04006DC2 RID: 28098
	public eGuildGuiState mState;

	// Token: 0x04006DC3 RID: 28099
	public eGuildGuiTimeoutState mTimeOutState;

	// Token: 0x04006DC4 RID: 28100
	private float Yi0cgALoGcO;

	// Token: 0x04006DC5 RID: 28101
	private float Hlicg9YAaO2;

	// Token: 0x04006DC6 RID: 28102
	private float iLicgWlh2O4;

	// Token: 0x04006DC7 RID: 28103
	private float j4ZcguG9SBQ;

	// Token: 0x04006DC8 RID: 28104
	private float ysAcgycI1Qy;

	// Token: 0x04006DC9 RID: 28105
	private float g0QcgVjhcrw;

	// Token: 0x04006DCA RID: 28106
	private Texture txNcghngNVe;

	// Token: 0x04006DCB RID: 28107
	private GUIStyle nHtcgKwCwwb;

	// Token: 0x04006DCC RID: 28108
	private GUIStyle WtkcgzLdS4H;

	// Token: 0x04006DCD RID: 28109
	private GUIStyle qJWca5ynFlv;

	// Token: 0x04006DCE RID: 28110
	private GUIStyle K80cacvxbhl;

	// Token: 0x04006DCF RID: 28111
	private GUIStyle CVtcanKrka4;

	// Token: 0x04006DD0 RID: 28112
	private AudioClip rUmcaQUJeie;

	// Token: 0x04006DD1 RID: 28113
	private AudioClip SjUcaeLG42P;

	// Token: 0x04006DD2 RID: 28114
	private AudioClip xXTcaIoE07t;

	// Token: 0x04006DD3 RID: 28115
	private AudioClip ivPcaJvWb2B;

	// Token: 0x04006DD4 RID: 28116
	private AudioClip MxBca6eAcK5;

	// Token: 0x04006DD5 RID: 28117
	private Texture Kw8catc4GqP;

	// Token: 0x04006DD6 RID: 28118
	private Texture gHocaXu7H1C;

	// Token: 0x04006DD7 RID: 28119
	private GUIStyle pHEcaO4pqpp;

	// Token: 0x04006DD8 RID: 28120
	private GUIStyle Naaca2wDBwq;

	// Token: 0x04006DD9 RID: 28121
	private string i0wcavZkLTG;

	// Token: 0x04006DDA RID: 28122
	private string KWJcalyXChn;

	// Token: 0x04006DDB RID: 28123
	private GUIStyle f63caGUgsHF;

	// Token: 0x04006DDC RID: 28124
	private GUIStyle HqFca1FjJw1;

	// Token: 0x04006DDD RID: 28125
	private GUIStyle avXcaqB1PWc;

	// Token: 0x04006DDE RID: 28126
	private GUIStyle dnScapASnPv;

	// Token: 0x04006DDF RID: 28127
	private GUIStyle Ao6caRm2WvD;

	// Token: 0x04006DE0 RID: 28128
	private GUIStyle fSHcarinCtW;

	// Token: 0x04006DE1 RID: 28129
	private Texture m2fcax0oUE2;

	// Token: 0x04006DE2 RID: 28130
	private Texture ygBcaT4njq2;

	// Token: 0x04006DE3 RID: 28131
	private GUIStyle By7caYv3ydU;

	// Token: 0x04006DE4 RID: 28132
	private GUIStyle AJwca3ydX5C;

	// Token: 0x04006DE5 RID: 28133
	private GUIStyle sQdcab7J8Si;

	// Token: 0x04006DE6 RID: 28134
	private GUIStyle oydcad9BFBm;

	// Token: 0x04006DE7 RID: 28135
	private int lP4cagWyeDB;

	// Token: 0x04006DE8 RID: 28136
	private int go5caaKF1Ja;

	// Token: 0x04006DE9 RID: 28137
	private GUIStyle ct2ca4ooh9x;

	// Token: 0x04006DEA RID: 28138
	private Texture OAvcasgT17G;

	// Token: 0x04006DEB RID: 28139
	private GUIStyle KOPcaH9R2jf;

	// Token: 0x04006DEC RID: 28140
	private Texture CYqca7wCW86;

	// Token: 0x04006DED RID: 28141
	private Texture KdVcaZlV3ax;

	// Token: 0x04006DEE RID: 28142
	private int ghLcaCHLl5Y;

	// Token: 0x04006DEF RID: 28143
	private int aG1caM13Ov9;

	// Token: 0x04006DF0 RID: 28144
	private Texture lOncafTPnZJ;

	// Token: 0x04006DF1 RID: 28145
	private Texture CjycaLBVgdJ;

	// Token: 0x04006DF2 RID: 28146
	private GUIStyle J3ncawcIyvD;

	// Token: 0x04006DF3 RID: 28147
	private GUIStyle A72caUt7oMm;

	// Token: 0x04006DF4 RID: 28148
	private GUIStyle HRncaNBTpwO;

	// Token: 0x04006DF5 RID: 28149
	private int EH0caEbHdNl;

	// Token: 0x04006DF6 RID: 28150
	private int W8icaPn2rkL;

	// Token: 0x04006DF7 RID: 28151
	private ItemClass[] PWHcaSawihx;

	// Token: 0x04006DF8 RID: 28152
	private Texture[] CFdcaBr59jX;

	// Token: 0x04006DF9 RID: 28153
	private int HRkca0X0lqS;

	// Token: 0x04006DFA RID: 28154
	private Texture uX8ca8hWBxp;

	// Token: 0x04006DFB RID: 28155
	private Texture Ux3caiIGxoD;

	// Token: 0x04006DFC RID: 28156
	private int yPvcaDJJYZD;

	// Token: 0x04006DFD RID: 28157
	private int JLccamxB2dO;

	// Token: 0x04006DFE RID: 28158
	private ItemClass[] tYFcajAuMeK;

	// Token: 0x04006DFF RID: 28159
	private Texture[] HBkcaoWPsIa;

	// Token: 0x04006E00 RID: 28160
	private Texture MSvcakLAbep;

	// Token: 0x04006E01 RID: 28161
	private string eVccaFeYygu;

	// Token: 0x04006E02 RID: 28162
	private int dtScaAsBX0X;

	// Token: 0x04006E03 RID: 28163
	private Texture AgTca9rFki5;

	// Token: 0x04006E04 RID: 28164
	private Texture zmhcaWRafpy;

	// Token: 0x04006E05 RID: 28165
	private Texture[] ayncauxG0X3;

	// Token: 0x04006E06 RID: 28166
	private Texture[] eNdcay7q6l8;

	// Token: 0x04006E07 RID: 28167
	private GUIStyle zcacaVBLNuY;

	// Token: 0x04006E08 RID: 28168
	private GUIStyle W46cahcDTQK;

	// Token: 0x04006E09 RID: 28169
	private GUIStyle fihcaKVuXir;

	// Token: 0x04006E0A RID: 28170
	private GUIStyle BKGcazVZZT6;

	// Token: 0x04006E0B RID: 28171
	private int SNYc45Bk9ks;

	// Token: 0x04006E0C RID: 28172
	private int Qayc4coSBRd;

	// Token: 0x04006E0D RID: 28173
	private int O0Fc4nkuQGI;

	// Token: 0x04006E0E RID: 28174
	private Texture Vjfc4QXx4YA;

	// Token: 0x04006E0F RID: 28175
	private GUIStyle IyDc4e2asgj;

	// Token: 0x04006E10 RID: 28176
	private GUIStyle Qytc4IZvZBn;

	// Token: 0x04006E11 RID: 28177
	private GUIStyle HUhc4Jj6H6M;

	// Token: 0x04006E12 RID: 28178
	private string IVbc46bF2NA;
}
