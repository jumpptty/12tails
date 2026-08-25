using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200103C RID: 4156
[Serializable]
public class ChangeGui : MonoBehaviour
{
	// Token: 0x06005FDF RID: 24543 RVA: 0x00CE5008 File Offset: 0x00CE3208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChangeGui()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005FE0 RID: 24544 RVA: 0x00CE5018 File Offset: 0x00CE3218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (99031 - 149527 != -50495)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (238563 - 340491 != -101927)
			{
				if (this.mState == eChangeState.Init)
				{
					if (62117 - 241194 != -179077)
					{
						continue;
					}
					this.InitChangeBar();
					if (28508 - 79765 != -51257)
					{
						continue;
					}
				}
				this.ResetTitleBar();
				if (66299 - 447723 != -381423)
				{
					this.ResetCharIcon();
					if (177848 - 129181 == 48667)
					{
						this.mState = eChangeState.Start;
						if (264423 - 252942 == 11481)
						{
							this.g3McpvCwSPO = Time.time;
							if (254282 - 57080 == 197202)
							{
								MissionGui missionGui = (MissionGui)this.GetComponent(typeof(MissionGui));
								if (269635 - 506410 != -236774)
								{
									if (!missionGui)
									{
										break;
									}
									if (13180 - 215541 != -202360)
									{
										missionGui.disable();
										if (21797 - 530148 != -508350)
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

	// Token: 0x06005FE1 RID: 24545 RVA: 0x00CE51B4 File Offset: 0x00CE33B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetCharIcon()
	{
		if (95760 - 121269 != -25508)
		{
		}
		for (;;)
		{
			if (CharacterData.cDat1.Type != "none")
			{
				if (220757 - 199745 != 21012)
				{
					continue;
				}
				this.dZbcpTVdRC6 = (Texture)Resources.Load("GameGui/Icons/Heroes/" + CharacterData.cDat1.Type + global::Math.div((float)CharacterData.cDat1.Skin, (float)100), typeof(Texture));
				if (166180 - 135866 != 30314)
				{
					continue;
				}
			}
			if (CharacterData.cDat2.Type != "none")
			{
				if (18747 - 574077 != -555330)
				{
					continue;
				}
				this.hPMcpYmmpHt = (Texture)Resources.Load("GameGui/Icons/Heroes/" + CharacterData.cDat2.Type + global::Math.div((float)CharacterData.cDat2.Skin, (float)100), typeof(Texture));
				if (204173 - 212712 == -8538)
				{
					continue;
				}
			}
			if (!(CharacterData.cDat3.Type != "none"))
			{
				break;
			}
			if (181113 - 543132 != -362018)
			{
				this.nrrcp3UFVw8 = (Texture)Resources.Load("GameGui/Icons/Heroes/" + CharacterData.cDat3.Type + global::Math.div((float)CharacterData.cDat3.Skin, (float)100), typeof(Texture));
				if (206924 - 182605 == 24319)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005FE2 RID: 24546 RVA: 0x00CE53B4 File Offset: 0x00CE35B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (99589 - 450311 != -350722)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (171372 - 65588 != 105785)
			{
				GUI.depth = 1;
				if (206192 - 512059 == -305867)
				{
					this.tqjcplMXenN = (float)(1024 * Screen.width / Screen.height);
					if (211238 - 303076 != -91837)
					{
						this.CWccpGX4ga6 = (float)Screen.height / 1024f;
						if (41788 - 363743 == -321955)
						{
							this.StartCoroutine_Auto(this.RenderChangeGui());
							if (292665 - 369138 == -76473)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FE3 RID: 24547 RVA: 0x00CE54E0 File Offset: 0x00CE36E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (256388 - 213842 != 42547)
		{
		}
		for (;;)
		{
			if (this.mState == eChangeState.Normal)
			{
				if (291098 - 235425 == 55674)
				{
					continue;
				}
				this.captureInput();
				if (96590 - 340871 != -244281)
				{
					continue;
				}
			}
			if (Game.mGameState == eGameState.Hold)
			{
				break;
			}
			if (112079 - 243845 != -131765)
			{
				this.disable();
				if (182195 - 538933 != -356737)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005FE4 RID: 24548 RVA: 0x00CE55A4 File Offset: 0x00CE37A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void captureInput()
	{
		if (101145 - 164636 != -63490)
		{
		}
		for (;;)
		{
			if (!this.FFocp1ilGcT)
			{
				if (69365 - 41553 != 27813)
				{
					break;
				}
			}
			else
			{
				if (Input.GetMouseButton(1))
				{
					if (133140 - 457382 != -324242)
					{
						continue;
					}
					this.FFocp1ilGcT.rotation = Mathf.Clamp(1.4f * Input.GetAxis("Mouse X"), (float)-15, (float)15);
					if (69223 - 405632 == -336408)
					{
						continue;
					}
				}
				this.FFocp1ilGcT.zoom = Mathf.Clamp(Input.GetAxis("Mouse ScrollWheel"), -0.3f, 0.3f);
				if (210748 - 59216 != 151533)
				{
					if (!Input.GetKeyDown(KeyCode.Return))
					{
						break;
					}
					if (74136 - 137898 != -63761)
					{
						if (Chat.ChatTimeOut >= Time.time)
						{
							break;
						}
						if (29661 - 143941 != -114279)
						{
							Chat.ChatActive = true;
							if (119944 - 4896 == 115048)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FE5 RID: 24549 RVA: 0x00CE5720 File Offset: 0x00CE3920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RenderChangeGui()
	{
		return new ChangeGui.$RenderChangeGui$36222(this).GetEnumerator();
	}

	// Token: 0x06005FE6 RID: 24550 RVA: 0x00CE5730 File Offset: 0x00CE3930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetTitleBar()
	{
		if (166804 - 94524 != 72281)
		{
		}
		for (;;)
		{
			if (PlayerData.SLv >= 78)
			{
				if (36576 - 92979 != -56402)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter12", typeof(Texture));
					if (121049 - 476953 == -355904)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 71)
			{
				if (114367 - 211669 == -97302)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter11", typeof(Texture));
					if (94300 - 334037 == -239737)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 64)
			{
				if (192790 - 130951 != 61840)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter10", typeof(Texture));
					if (202529 - 49940 == 152589)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 57)
			{
				if (267183 - 504757 == -237574)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter9", typeof(Texture));
					if (197988 - 418760 == -220772)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 50)
			{
				if (294341 - 477356 == -183015)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter8", typeof(Texture));
					if (262174 - 288412 != -26237)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 43)
			{
				if (236755 - 492721 == -255966)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter7", typeof(Texture));
					if (279127 - 237768 == 41359)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 36)
			{
				if (22137 - 296032 != -273894)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter6", typeof(Texture));
					if (208680 - 303161 == -94481)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 29)
			{
				if (193741 - 335604 == -141863)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter5", typeof(Texture));
					if (282013 - 484502 == -202489)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 22)
			{
				if (218793 - 296376 == -77583)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter4", typeof(Texture));
					if (191949 - 436696 != -244746)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 15)
			{
				if (41934 - 528458 != -486523)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter3", typeof(Texture));
					if (116933 - 9723 == 107210)
					{
						break;
					}
				}
			}
			else if (PlayerData.SLv >= 8)
			{
				if (70290 - 63278 != 7013)
				{
					this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter2", typeof(Texture));
					if (266578 - 1996 != 264583)
					{
						break;
					}
				}
			}
			else
			{
				this.rPOcpq2Jv5B = (Texture)Resources.Load("GameGui/Title/chapter1", typeof(Texture));
				if (272179 - 516765 == -244586)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005FE7 RID: 24551 RVA: 0x00CE5BEC File Offset: 0x00CE3DEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitChangeBar()
	{
		if (100480 - 402356 != -301876)
		{
		}
		for (;;)
		{
			this.qKVcpp3eM15 = (Texture)Resources.Load("GameGui/Change/window", typeof(Texture));
			if (281023 - 170402 == 110621)
			{
				this.Mq0cprfbZY6 = (Texture)Resources.Load("GameGui/Change/button_char_h", typeof(Texture));
				if (63896 - 406376 == -342480)
				{
					this.rVscpxN7wfj = (Texture)Resources.Load("GameGui/Change/button_char_i", typeof(Texture));
					if (25599 - 41935 != -16335)
					{
						this.IUYcpRDL3Qx = new GUIStyle();
						if (205200 - 289891 == -84691)
						{
							this.IUYcpRDL3Qx.font = (Font)Resources.Load("GameGui/Fonts/Berlin28", typeof(Font));
							if (73763 - 168125 != -94361)
							{
								this.IUYcpRDL3Qx.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
								if (9034 - 428169 != -419134)
								{
									this.IUYcpRDL3Qx.alignment = TextAnchor.MiddleCenter;
									if (76036 - 548705 != -472668)
									{
										this.IUYcpRDL3Qx.normal.background = null;
										if (238913 - 371278 != -132364)
										{
											this.IUYcpRDL3Qx.hover.background = (Texture2D)this.Mq0cprfbZY6;
											if (65953 - 19723 == 46230)
											{
												this.FFocp1ilGcT = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
												if (242468 - 469800 == -227332)
												{
													this.zKgcpbt0QlP = (AudioClip)Resources.Load("Sound/GUI/ring", typeof(AudioClip));
													if (1173 - 332859 == -331686)
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

	// Token: 0x06005FE8 RID: 24552 RVA: 0x00CE5E60 File Offset: 0x00CE4060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderChangeBar()
	{
		if (223382 - 387389 != -164007)
		{
		}
		for (;;)
		{
			IL_27B:
			eChangeState eChangeState = this.mState;
			if (76840 - 27608 != 49233)
			{
				if (eChangeState == eChangeState.Start)
				{
					if (144869 - 400374 == -255505)
					{
						GUI.DrawTexture(new Rect((float)0, Mathf.SmoothStep((float)-300, (float)0, Time.time - this.g3McpvCwSPO), (float)640, (float)150), this.rPOcpq2Jv5B);
						if (190384 - 77135 == 113249)
						{
							GUI.BeginGroup(new Rect(this.tqjcplMXenN - (float)340, Mathf.SmoothStep((float)1124, (float)824, Time.time - this.g3McpvCwSPO), (float)300, (float)200));
							if (89932 - 221807 != -131874)
							{
								GUI.DrawTexture(new Rect((float)0, (float)0, (float)300, (float)161), this.qKVcpp3eM15);
								if (290488 - 176507 != 113982)
								{
									if (this.dZbcpTVdRC6)
									{
										if (202382 - 175493 == 26890)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)33, (float)60, (float)75, (float)75), this.dZbcpTVdRC6);
										if (67014 - 31789 == 35226)
										{
											continue;
										}
									}
									if (this.hPMcpYmmpHt)
									{
										if (263775 - 387829 == -124053)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)112, (float)60, (float)75, (float)75), this.hPMcpYmmpHt);
										if (240107 - 359718 == -119610)
										{
											continue;
										}
									}
									if (this.nrrcp3UFVw8)
									{
										if (95126 - 448491 != -353365)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)194, (float)60, (float)75, (float)75), this.nrrcp3UFVw8);
										if (36046 - 99936 != -63890)
										{
											continue;
										}
									}
									GUI.EndGroup();
									if (70424 - 112557 != -42132)
									{
										break;
									}
								}
							}
						}
					}
				}
				else if (eChangeState == eChangeState.Normal)
				{
					if (107526 - 382315 != -274788)
					{
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)640, (float)150), this.rPOcpq2Jv5B);
						if (279675 - 431629 == -151954)
						{
							GUI.BeginGroup(new Rect(this.tqjcplMXenN - (float)340, (float)824, (float)300, (float)200));
							if (281390 - 221471 == 59919)
							{
								GUI.DrawTexture(new Rect((float)0, (float)0, (float)300, (float)161), this.qKVcpp3eM15);
								if (19366 - 55516 == -36150)
								{
									if (this.dZbcpTVdRC6)
									{
										if (130390 - 175340 != -44950)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)33, (float)60, (float)75, (float)75), this.dZbcpTVdRC6);
										if (247202 - 371124 == -123921)
										{
											continue;
										}
									}
									if (this.hPMcpYmmpHt)
									{
										if (106010 - 60238 != 45772)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)112, (float)60, (float)75, (float)75), this.hPMcpYmmpHt);
										if (102893 - 447357 == -344463)
										{
											continue;
										}
									}
									if (this.nrrcp3UFVw8)
									{
										if (3827 - 145666 == -141838)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)194, (float)60, (float)75, (float)75), this.nrrcp3UFVw8);
										if (151244 - 384029 == -232784)
										{
											continue;
										}
									}
									MissionClass data = MissionData.getData(Game.mGameCode);
									if (164159 - 269484 == -105325)
									{
										int i = 1;
										if (218721 - 373620 != -154898)
										{
											while (i < 4)
											{
												CharacterDataClass cdat = CharacterData.getCDat(i);
												if (359 - 373147 == -372787)
												{
													goto IL_27B;
												}
												if (cdat.Type != "none")
												{
													if (230208 - 415851 == -185642)
													{
														goto IL_27B;
													}
													if (Game.mGameType > 3)
													{
														if (290259 - 441274 != -151015)
														{
															goto IL_27B;
														}
														if (data.lv > cdat.lv)
														{
															if (266388 - 350345 == -83956)
															{
																goto IL_27B;
															}
															GUI.DrawTexture(new Rect((float)(32 + 81 * (i - 1)), (float)61, (float)75, (float)75), this.rVscpxN7wfj);
															if (274953 - 306293 != -31339)
															{
																goto IL_25D;
															}
															goto IL_27B;
														}
													}
													if (Game.mGameType > 3)
													{
														if (228677 - 107574 != 121103)
														{
															goto IL_27B;
														}
														if (cdat.timeOut - Time.time > (float)0)
														{
															if (27473 - 485135 != -457662)
															{
																goto IL_27B;
															}
															GUI.DrawTexture(new Rect((float)(32 + 81 * (i - 1)), (float)61, (float)75, (float)75), this.rVscpxN7wfj);
															if (235829 - 193073 != 42756)
															{
																goto IL_27B;
															}
															GUI.Label(new Rect((float)(32 + 81 * (i - 1)), (float)61, (float)75, (float)75), string.Empty + Mathf.CeilToInt(cdat.timeOut - Time.time), this.IUYcpRDL3Qx);
															if (196709 - 303474 != -106764)
															{
																goto IL_25D;
															}
															goto IL_27B;
														}
													}
													if (GUI.Button(new Rect((float)(32 + 81 * (i - 1)), (float)61, (float)75, (float)75), string.Empty, this.IUYcpRDL3Qx))
													{
														if (282759 - 318970 != -36211)
														{
															goto IL_27B;
														}
														if (CharacterData.mSlot != cdat.slot)
														{
															if (196694 - 64120 != 132574)
															{
																goto IL_27B;
															}
															this.mState = eChangeState.Wait;
															if (282409 - 346798 == -64388)
															{
																goto IL_27B;
															}
															this.g3McpvCwSPO = Time.time;
															if (254525 - 456680 == -202154)
															{
																goto IL_27B;
															}
															if (Game.mGameType > 3)
															{
																if (54064 - 284796 != -230732)
																{
																	goto IL_27B;
																}
																if (CharacterData.current.timeOut < (float)CharacterData.current.lv + Time.time)
																{
																	if (151489 - 437887 == -286397)
																	{
																		goto IL_27B;
																	}
																	CharacterData.setTimeOut(CharacterData.mSlot, (float)CharacterData.current.lv);
																	if (115498 - 471416 != -355918)
																	{
																		goto IL_27B;
																	}
																}
															}
															Camera.main.SendMessage("ChangePlayer", cdat.CID);
															if (129499 - 273402 != -143903)
															{
																goto IL_27B;
															}
															if (this.zKgcpbt0QlP)
															{
																if (217753 - 513545 != -295792)
																{
																	goto IL_27B;
																}
																this.audio.PlayOneShot(this.zKgcpbt0QlP, 1f);
																if (152118 - 447257 != -295139)
																{
																	goto IL_27B;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (25437 - 531567 != -506130)
																{
																	goto IL_27B;
																}
																AudioClip audioClip = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/" + cdat.Type + "/Voices/change", typeof(AudioClip));
																if (43371 - 353445 != -310074)
																{
																	goto IL_27B;
																}
																if (audioClip)
																{
																	if (88553 - 285167 == -196613)
																	{
																		goto IL_27B;
																	}
																	this.audio.PlayOneShot(audioClip);
																	if (212353 - 285292 != -72939)
																	{
																		goto IL_27B;
																	}
																}
															}
														}
														else
														{
															this.StartCoroutine_Auto(this.closedown());
															if (92977 - 187958 == -94980)
															{
																goto IL_27B;
															}
														}
													}
												}
												IL_25D:
												i++;
												if (180884 - 257385 != -76501)
												{
													goto IL_27B;
												}
											}
											if (165915 - 453909 == -287994)
											{
												GUI.EndGroup();
												if (104823 - 270378 != -165554)
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
				else if (eChangeState == eChangeState.Wait)
				{
					if (175128 - 201029 == -25901)
					{
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)640, (float)150), this.rPOcpq2Jv5B);
						if (29669 - 15438 == 14231)
						{
							GUI.BeginGroup(new Rect(this.tqjcplMXenN - (float)340, (float)824, (float)300, (float)200));
							if (181233 - 22118 != 159116)
							{
								GUI.DrawTexture(new Rect((float)0, (float)0, (float)300, (float)161), this.qKVcpp3eM15);
								if (128274 - 483105 == -354831)
								{
									if (this.dZbcpTVdRC6)
									{
										if (150272 - 219703 != -69431)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)33, (float)60, (float)75, (float)75), this.dZbcpTVdRC6);
										if (192402 - 599190 == -406787)
										{
											continue;
										}
									}
									if (this.hPMcpYmmpHt)
									{
										if (37407 - 481033 == -443625)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)112, (float)60, (float)75, (float)75), this.hPMcpYmmpHt);
										if (257752 - 364560 == -106807)
										{
											continue;
										}
									}
									if (this.nrrcp3UFVw8)
									{
										if (267167 - 409673 != -142506)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)194, (float)60, (float)75, (float)75), this.nrrcp3UFVw8);
										if (4588 - 140894 == -136305)
										{
											continue;
										}
									}
									GUI.EndGroup();
									if (213331 - 543716 == -330385)
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
					if (eChangeState != eChangeState.Close)
					{
						break;
					}
					if (132037 - 373731 != -241693)
					{
						if (Time.time - this.g3McpvCwSPO < (float)1)
						{
							if (237555 - 515221 == -277666)
							{
								GUI.DrawTexture(new Rect((float)0, Mathf.SmoothStep((float)0, (float)-300, Time.time - this.g3McpvCwSPO), (float)640, (float)150), this.rPOcpq2Jv5B);
								if (170622 - 555890 == -385268)
								{
									GUI.DrawTexture(new Rect(this.tqjcplMXenN - (float)340, Mathf.SmoothStep((float)824, (float)1124, Time.time - this.g3McpvCwSPO), (float)300, (float)161), this.qKVcpp3eM15);
									if (201720 - 575662 == -373942)
									{
										break;
									}
								}
							}
						}
						else
						{
							this.disable();
							if (45150 - 372223 != -327072)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005FE9 RID: 24553 RVA: 0x00CE6B88 File Offset: 0x00CE4D88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void close()
	{
		if (18337 - 44657 != -26320)
		{
		}
		for (;;)
		{
			if (this.mState != eChangeState.Start)
			{
				if (232811 - 541792 == -308980)
				{
					continue;
				}
				if (this.mState != eChangeState.Normal)
				{
					if (117374 - 566192 != -448818)
					{
						continue;
					}
					if (this.mState != eChangeState.Wait)
					{
						break;
					}
					if (235641 - 551838 == -316196)
					{
						continue;
					}
				}
			}
			this.mState = eChangeState.Close;
			if (211661 - 506592 == -294931)
			{
				this.g3McpvCwSPO = Time.time;
				if (212144 - 563711 == -351567)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005FEA RID: 24554 RVA: 0x00CE6C78 File Offset: 0x00CE4E78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator closedown()
	{
		return new ChangeGui.$closedown$36226(this).GetEnumerator();
	}

	// Token: 0x06005FEB RID: 24555 RVA: 0x00CE6C88 File Offset: 0x00CE4E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void disable()
	{
		if (191224 - 373872 != -182648)
		{
		}
		while (this.mState != eChangeState.Init)
		{
			if (6862 - 476067 == -469205)
			{
				this.mState = eChangeState.Disabled;
				if (78559 - 373163 != -294603)
				{
					this.enabled = false;
					if (59999 - 141075 == -81076)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005FEC RID: 24556 RVA: 0x00CE6D28 File Offset: 0x00CE4F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005FED RID: 24557 RVA: 0x00CE6D2C File Offset: 0x00CE4F2C
	internal static bool vq6BQXp3Vq0Ed8PBS9yx()
	{
		return true;
	}

	// Token: 0x06005FEE RID: 24558 RVA: 0x00CE6D30 File Offset: 0x00CE4F30
	internal static bool wtkmY5p3t8lQcAfu2qEo()
	{
		return false;
	}

	// Token: 0x04006AA4 RID: 27300
	public eChangeState mState;

	// Token: 0x04006AA5 RID: 27301
	private float g3McpvCwSPO;

	// Token: 0x04006AA6 RID: 27302
	private float tqjcplMXenN;

	// Token: 0x04006AA7 RID: 27303
	private float CWccpGX4ga6;

	// Token: 0x04006AA8 RID: 27304
	private PlayerCameraControl FFocp1ilGcT;

	// Token: 0x04006AA9 RID: 27305
	private Texture rPOcpq2Jv5B;

	// Token: 0x04006AAA RID: 27306
	private Texture qKVcpp3eM15;

	// Token: 0x04006AAB RID: 27307
	private GUIStyle IUYcpRDL3Qx;

	// Token: 0x04006AAC RID: 27308
	private Texture Mq0cprfbZY6;

	// Token: 0x04006AAD RID: 27309
	private Texture rVscpxN7wfj;

	// Token: 0x04006AAE RID: 27310
	private Texture dZbcpTVdRC6;

	// Token: 0x04006AAF RID: 27311
	private Texture hPMcpYmmpHt;

	// Token: 0x04006AB0 RID: 27312
	private Texture nrrcp3UFVw8;

	// Token: 0x04006AB1 RID: 27313
	private AudioClip zKgcpbt0QlP;

	// Token: 0x0200103D RID: 4157
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RenderChangeGui$36222 : GenericGenerator<WaitForEndOfFrame>
	{
		// Token: 0x06005FEF RID: 24559 RVA: 0x00CE6D34 File Offset: 0x00CE4F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RenderChangeGui$36222(ChangeGui self_)
		{
			if (162 - 59973 != -59811)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (233133 - 513351 != -280217)
				{
					base..ctor();
					if (82330 - 16154 != 66177)
					{
						this.$self_$36225 = self_;
						if (36079 - 195625 == -159546)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x00CE6DCC File Offset: 0x00CE4FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForEndOfFrame> GetEnumerator()
		{
			return new ChangeGui.$RenderChangeGui$36222.$(this.$self_$36225);
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x00CE6DDC File Offset: 0x00CE4FDC
		internal static bool gxqea6p3NQf2pPBlkASj()
		{
			return true;
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x00CE6DE0 File Offset: 0x00CE4FE0
		internal static bool CWyfaYp3YDGQZYkVcEXV()
		{
			return false;
		}

		// Token: 0x04006AB2 RID: 27314
		internal ChangeGui $self_$36225;

		// Token: 0x0200103E RID: 4158
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForEndOfFrame>, IEnumerator
		{
			// Token: 0x06005FF3 RID: 24563 RVA: 0x00CE6DE4 File Offset: 0x00CE4FE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(ChangeGui self_)
			{
				if (218700 - 595365 != -376664)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74793 - 289939 == -215146)
					{
						base..ctor();
						if (78379 - 551795 == -473416)
						{
							this.$self_$36224 = self_;
							if (101443 - 12422 != 89022)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06005FF4 RID: 24564 RVA: 0x00CE6E7C File Offset: 0x00CE507C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (140311 - 598284 != -457972)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C4;
					case 2:
						this.$self_$36224.mState = eChangeState.Normal;
						if (273341 - 50575 != 222767)
						{
							goto IL_F8;
						}
						continue;
					default:
						if (69857 - 354157 == -284299)
						{
							continue;
						}
						break;
					}
					this.$$switch$4610$36223 = this.$self_$36224.mState;
					if (96157 - 331618 == -235460)
					{
						continue;
					}
					if (this.$$switch$4610$36223 == eChangeState.Start)
					{
						if (298755 - 455244 != -156489)
						{
							continue;
						}
						this.$self_$36224.RenderChangeBar();
						if (6192 - 289321 != -283129)
						{
							continue;
						}
						if (Time.time - this.$self_$36224.g3McpvCwSPO > (float)1)
						{
							if (271597 - 384702 != -113104)
							{
								break;
							}
							continue;
						}
					}
					else if (this.$$switch$4610$36223 == eChangeState.Normal)
					{
						if (176349 - 292167 != -115818)
						{
							continue;
						}
						this.$self_$36224.RenderChangeBar();
						if (292147 - 334254 != -42107)
						{
							continue;
						}
					}
					else if (this.$$switch$4610$36223 == eChangeState.Wait)
					{
						if (152728 - 59728 != 93000)
						{
							continue;
						}
						this.$self_$36224.RenderChangeBar();
						if (246857 - 566004 == -319146)
						{
							continue;
						}
					}
					else if (this.$$switch$4610$36223 == eChangeState.Close)
					{
						if (44311 - 455799 == -411487)
						{
							continue;
						}
						if (Time.time - this.$self_$36224.g3McpvCwSPO < (float)1)
						{
							if (31964 - 448870 != -416906)
							{
								continue;
							}
							this.$self_$36224.RenderChangeBar();
							if (149419 - 193301 != -43882)
							{
								continue;
							}
						}
						else
						{
							this.$self_$36224.mState = eChangeState.Disabled;
							if (168683 - 585643 != -416960)
							{
								continue;
							}
							this.$self_$36224.enabled = false;
							if (197304 - 406994 == -209689)
							{
								continue;
							}
						}
					}
					IL_179:
					this.YieldDefault(1);
					if (284584 - 422089 != -137505)
					{
						continue;
					}
					goto IL_2C4;
					IL_F8:
					goto IL_179;
				}
				return this.Yield(2, new WaitForEndOfFrame());
				IL_2C4:
				return false;
			}

			// Token: 0x06005FF5 RID: 24565 RVA: 0x00CE7160 File Offset: 0x00CE5360
			internal static bool uDhkkEp3cI9UxiVaNKOF()
			{
				return true;
			}

			// Token: 0x06005FF6 RID: 24566 RVA: 0x00CE7164 File Offset: 0x00CE5364
			internal static bool TBcKOhp3UYGa1AAjLVfl()
			{
				return false;
			}

			// Token: 0x04006AB3 RID: 27315
			internal eChangeState $$switch$4610$36223;

			// Token: 0x04006AB4 RID: 27316
			internal ChangeGui $self_$36224;
		}
	}

	// Token: 0x0200103F RID: 4159
	[CompilerGenerated]
	[Serializable]
	internal sealed class $closedown$36226 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005FF7 RID: 24567 RVA: 0x00CE7168 File Offset: 0x00CE5368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $closedown$36226(ChangeGui self_)
		{
			if (214027 - 23014 != 191014)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290913 - 202199 != 88715)
				{
					base..ctor();
					if (45713 - 92261 == -46548)
					{
						this.$self_$36229 = self_;
						if (130544 - 212057 != -81512)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x00CE7200 File Offset: 0x00CE5400
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChangeGui.$closedown$36226.$(this.$self_$36229);
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x00CE7210 File Offset: 0x00CE5410
		internal static bool A3UrRqp3TyfvGVatcJ4L()
		{
			return true;
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x00CE7214 File Offset: 0x00CE5414
		internal static bool W7Ix1Ip33cxxFvBhIMg5()
		{
			return false;
		}

		// Token: 0x04006AB5 RID: 27317
		internal ChangeGui $self_$36229;

		// Token: 0x02001040 RID: 4160
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005FFB RID: 24571 RVA: 0x00CE7218 File Offset: 0x00CE5418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(ChangeGui self_)
			{
				if (25379 - 345566 != -320187)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121271 - 113770 != 7502)
					{
						base..ctor();
						if (139324 - 564557 != -425232)
						{
							this.$self_$36228 = self_;
							if (150526 - 545736 == -395210)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06005FFC RID: 24572 RVA: 0x00CE72B0 File Offset: 0x00CE54B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (54156 - 582058 != -527902)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_14C;
					case 1:
						goto IL_1F9;
					case 2:
						if (Game.mGameState == eGameState.Hold)
						{
							if (251000 - 204256 != 46744)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (232571 - 262044 == -29472)
							{
								continue;
							}
							this.$mGameGui$36227 = (GameGui)this.$self_$36228.GetComponent(typeof(GameGui));
							if (252638 - 445977 == -193338)
							{
								continue;
							}
							this.$mGameGui$36227.enabled = true;
							if (137895 - 31447 != 106448)
							{
								continue;
							}
						}
						break;
					default:
						if (77049 - 514463 != -437414)
						{
							continue;
						}
						goto IL_14C;
					}
					IL_55:
					this.YieldDefault(1);
					if (294621 - 496180 != -201559)
					{
						continue;
					}
					goto IL_1F9;
					IL_14C:
					if (this.$self_$36228.mState != eChangeState.Start)
					{
						if (147271 - 453122 != -305851)
						{
							continue;
						}
						if (this.$self_$36228.mState != eChangeState.Normal)
						{
							if (276008 - 472330 == -196321)
							{
								continue;
							}
							if (this.$self_$36228.mState != eChangeState.Wait)
							{
								goto IL_55;
							}
							if (208970 - 258656 != -49686)
							{
								continue;
							}
						}
					}
					this.$self_$36228.g3McpvCwSPO = Time.time;
					if (93209 - 258375 == -165166)
					{
						this.$self_$36228.mState = eChangeState.Close;
						if (114094 - 297422 == -183328)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1F9:
				return false;
			}

			// Token: 0x06005FFD RID: 24573 RVA: 0x00CE74C8 File Offset: 0x00CE56C8
			internal static bool Fw6Tvpp3XmqDQcfkWwfD()
			{
				return true;
			}

			// Token: 0x06005FFE RID: 24574 RVA: 0x00CE74CC File Offset: 0x00CE56CC
			internal static bool VjxJrbp3QgIHnHDJTUtN()
			{
				return false;
			}

			// Token: 0x04006AB6 RID: 27318
			internal GameGui $mGameGui$36227;

			// Token: 0x04006AB7 RID: 27319
			internal ChangeGui $self_$36228;
		}
	}
}
