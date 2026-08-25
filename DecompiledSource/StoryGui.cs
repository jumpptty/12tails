using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200109E RID: 4254
[Serializable]
public class StoryGui : MonoBehaviour
{
	// Token: 0x06006308 RID: 25352 RVA: 0x00DBFD88 File Offset: 0x00DBDF88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StoryGui()
	{
		if (210312 - 19120 != 191193)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (177251 - 370738 == -193487)
			{
				base..ctor();
				if (291722 - 242988 == 48734)
				{
					this.BnUcPcbOAUb = string.Empty;
					if (227902 - 167562 == 60340)
					{
						this.px3cPnTheo5 = string.Empty;
						if (192052 - 412693 != -220640)
						{
							this.F0ncPQFu9Xs = string.Empty;
							if (189774 - 53439 != 136336)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006309 RID: 25353 RVA: 0x00DBFE70 File Offset: 0x00DBE070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (71386 - 108452 != -37065)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (273181 - 300116 == -26935)
			{
				this.Jd5cPJtQp07 = 0;
				if (143748 - 281815 == -138067)
				{
					this.DWmcP6fPHFT = 0;
					if (208531 - 359111 == -150580)
					{
						this.DBvcEVJIavv = eStoryState.open;
						if (242439 - 555804 != -313364)
						{
							this.xNScEhT00Aj = Time.time;
							if (219365 - 289133 == -69768)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600630A RID: 25354 RVA: 0x00DBFF50 File Offset: 0x00DBE150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init()
	{
		if (10649 - 35379 != -24730)
		{
		}
		for (;;)
		{
			this.EigcPthngAM = true;
			if (86674 - 568628 == -481954)
			{
				this.GTgcPXcB44l = new GUIStyle();
				if (78042 - 435428 != -357385)
				{
					this.GTgcPXcB44l.font = (Font)Resources.Load("GameGui/Fonts/GMO48");
					if (243472 - 173292 == 70180)
					{
						this.GTgcPXcB44l.normal.textColor = new Color(0.25f, 0.22f, 0.2f, (float)1);
						if (243870 - 11097 == 232773)
						{
							this.GTgcPXcB44l.alignment = TextAnchor.UpperLeft;
							if (42650 - 93171 == -50521)
							{
								this.PmFcPOorYEW = new GUIStyle();
								if (161122 - 312856 == -151734)
								{
									this.PmFcPOorYEW.font = (Font)Resources.Load("GameGui/Fonts/GMO38");
									if (160298 - 554767 == -394469)
									{
										this.PmFcPOorYEW.alignment = TextAnchor.UpperLeft;
										if (178706 - 222225 == -43519)
										{
											this.PmFcPOorYEW.wordWrap = true;
											if (153974 - 533169 != -379194)
											{
												this.EdVcP2GajT2 = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_system");
												if (76967 - 527820 != -450852)
												{
													this.TFMcPvc0VYV = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend");
													if (269291 - 470191 == -200900)
													{
														this.Fi8cPl8EAOc = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_enemy");
														if (297728 - 165614 == 132114)
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

	// Token: 0x0600630B RID: 25355 RVA: 0x00DC019C File Offset: 0x00DBE39C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (274102 - 464689 != -190587)
		{
		}
		for (;;)
		{
			GUI.depth = 1;
			if (100396 - 320892 != -220495)
			{
				GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
				if (295165 - 564053 != -268887)
				{
					this.AficEKD7ZYL = (float)(1024 * Screen.width / Screen.height);
					if (48978 - 107055 != -58076)
					{
						this.lqhcEzYIrjC = (float)Screen.height / 1024f;
						if (287641 - 317614 == -29973)
						{
							eStoryState dbvcEVJIavv = this.DBvcEVJIavv;
							if (23334 - 165439 == -142105)
							{
								if (dbvcEVJIavv == eStoryState.init)
								{
									if (111360 - 4314 == 107046)
									{
										break;
									}
								}
								else if (dbvcEVJIavv == eStoryState.open)
								{
									if (58967 - 200838 == -141871)
									{
										int num = (int)Mathf.SmoothStep((float)1024, (float)724, (float)2 * (Time.time - this.xNScEhT00Aj));
										if (34609 - 379973 == -345364)
										{
											if (this.sSycP5vUAvp)
											{
												if (91120 - 48567 == 42554)
												{
													continue;
												}
												if (this.sSycP5vUAvp.width < 600)
												{
													if (69951 - 290516 == -220564)
													{
														continue;
													}
													GUI.DrawTexture(new Rect(((float)2 * (Time.time - this.xNScEhT00Aj) - (float)1) * (float)this.sSycP5vUAvp.width, (float)(1024 - this.sSycP5vUAvp.height), (float)this.sSycP5vUAvp.width, (float)this.sSycP5vUAvp.height), this.sSycP5vUAvp);
													if (15395 - 447274 != -431879)
													{
														continue;
													}
												}
												else
												{
													GUI.DrawTexture(new Rect((float)0, (float)(1024 - this.sSycP5vUAvp.height), (float)this.sSycP5vUAvp.width, (float)this.sSycP5vUAvp.height), this.sSycP5vUAvp);
													if (55101 - 138663 == -83561)
													{
														continue;
													}
												}
											}
											eTalkType lrscPebaSwn = this.LRScPebaSwn;
											if (253956 - 524184 != -270227)
											{
												if (lrscPebaSwn == eTalkType.friend)
												{
													if (160179 - 590712 != -430533)
													{
														continue;
													}
													GUI.DrawTexture(new Rect(0.5f * this.AficEKD7ZYL - (float)350, (float)num, (float)845, (float)199), this.TFMcPvc0VYV);
													if (136908 - 300764 == -163855)
													{
														continue;
													}
												}
												else if (lrscPebaSwn == eTalkType.enemy)
												{
													if (74164 - 550195 == -476030)
													{
														continue;
													}
													GUI.DrawTexture(new Rect(0.5f * this.AficEKD7ZYL - (float)350, (float)num, (float)845, (float)199), this.Fi8cPl8EAOc);
													if (283927 - 300507 != -16580)
													{
														continue;
													}
												}
												else
												{
													GUI.DrawTexture(new Rect(0.5f * this.AficEKD7ZYL - (float)350, (float)num, (float)845, (float)199), this.EdVcP2GajT2);
													if (109355 - 546512 == -437156)
													{
														continue;
													}
												}
												if (Time.time - this.xNScEhT00Aj <= 0.5f)
												{
													break;
												}
												if (296170 - 96339 == 199831)
												{
													this.DBvcEVJIavv = eStoryState.normal;
													if (271409 - 451482 == -180073)
													{
														this.xNScEhT00Aj = Time.time;
														if (253716 - 555727 != -302010)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (dbvcEVJIavv == eStoryState.normal)
								{
									if (224690 - 257598 != -32907)
									{
										if (this.sSycP5vUAvp)
										{
											if (128141 - 116086 == 12056)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)0, (float)(1024 - this.sSycP5vUAvp.height), (float)this.sSycP5vUAvp.width, (float)this.sSycP5vUAvp.height), this.sSycP5vUAvp);
											if (266670 - 168836 == 97835)
											{
												continue;
											}
										}
										this.RenderTalkBar(Stringf.timed(this.px3cPnTheo5, Time.time - this.xNScEhT00Aj));
										if (232743 - 192534 != 40210)
										{
											break;
										}
									}
								}
								else if (dbvcEVJIavv == eStoryState.blank)
								{
									if (228570 - 510639 != -282068)
									{
										break;
									}
								}
								else if (dbvcEVJIavv == eStoryState.yesno)
								{
									if (134911 - 561618 == -426707)
									{
										break;
									}
								}
								else if (dbvcEVJIavv == eStoryState.close)
								{
									if (145935 - 565914 == -419979)
									{
										if (this.sSycP5vUAvp)
										{
											if (188455 - 366123 != -177668)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)2 * (this.xNScEhT00Aj - Time.time) * (float)this.sSycP5vUAvp.width, (float)(1024 - this.sSycP5vUAvp.height), (float)this.sSycP5vUAvp.width, (float)this.sSycP5vUAvp.height), this.sSycP5vUAvp);
											if (195478 - 307574 != -112096)
											{
												continue;
											}
										}
										eTalkType lrscPebaSwn2 = this.LRScPebaSwn;
										if (265882 - 120023 == 145859)
										{
											if (lrscPebaSwn2 == eTalkType.friend)
											{
												if (164620 - 284069 == -119448)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * this.AficEKD7ZYL - (float)350, Mathf.SmoothStep((float)724, (float)1024, (float)2 * (Time.time - this.xNScEhT00Aj)), (float)845, (float)199), this.TFMcPvc0VYV);
												if (96612 - 39936 != 56676)
												{
													continue;
												}
											}
											else if (lrscPebaSwn2 == eTalkType.enemy)
											{
												if (221694 - 236396 != -14702)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * this.AficEKD7ZYL - (float)350, Mathf.SmoothStep((float)724, (float)1024, (float)2 * (Time.time - this.xNScEhT00Aj)), (float)845, (float)199), this.Fi8cPl8EAOc);
												if (85296 - 365471 == -280174)
												{
													continue;
												}
											}
											else
											{
												GUI.DrawTexture(new Rect(0.5f * this.AficEKD7ZYL - (float)350, Mathf.SmoothStep((float)724, (float)1024, (float)2 * (Time.time - this.xNScEhT00Aj)), (float)845, (float)199), this.EdVcP2GajT2);
												if (234968 - 472725 == -237756)
												{
													continue;
												}
											}
											if (Time.time - this.xNScEhT00Aj <= 0.5f)
											{
												break;
											}
											if (107671 - 371419 != -263747)
											{
												this.DBvcEVJIavv = eStoryState.disabled;
												if (60147 - 227549 == -167402)
												{
													this.xNScEhT00Aj = Time.time;
													if (216195 - 37987 != 178209)
													{
														this.enabled = false;
														if (187956 - 592798 == -404842)
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
									if (dbvcEVJIavv != eStoryState.disabled)
									{
										break;
									}
									if (147638 - 452916 != -305277)
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

	// Token: 0x0600630C RID: 25356 RVA: 0x00DC0A8C File Offset: 0x00DBEC8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void startStoryMessage(string nIcon, string nName, eTalkType nTalkType)
	{
		if (90701 - 507160 != -416459)
		{
		}
		for (;;)
		{
			if (!this.EigcPthngAM)
			{
				if (285904 - 335154 != -49250)
				{
					continue;
				}
				this.Init();
				if (221361 - 327809 == -106447)
				{
					continue;
				}
			}
			if (nIcon == "none")
			{
				if (83877 - 493785 != -409908)
				{
					continue;
				}
				this.sSycP5vUAvp = null;
				if (173871 - 170323 != 3548)
				{
					continue;
				}
			}
			else
			{
				this.sSycP5vUAvp = (Texture)Resources.Load("GameGui/Story/Characters/" + nIcon, typeof(Texture));
				if (115012 - 640 != 114372)
				{
					continue;
				}
			}
			this.BnUcPcbOAUb = nName;
			if (147751 - 137406 != 10346)
			{
				this.px3cPnTheo5 = string.Empty;
				if (109836 - 309872 != -200035)
				{
					this.LRScPebaSwn = nTalkType;
					if (114484 - 553949 == -439465)
					{
						this.psbcPIQqeaB = eTalkMode.singlePlayer;
						if (108057 - 415718 == -307661)
						{
							this.enabled = true;
							if (225836 - 116362 == 109474)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600630D RID: 25357 RVA: 0x00DC0C44 File Offset: 0x00DBEE44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool newStoryMessage(string nIcon, string nName, string nMessage, eTalkType nTalkType)
	{
		if (158522 - 469618 != -311096)
		{
		}
		for (;;)
		{
			if (!this.EigcPthngAM)
			{
				if (155398 - 111458 != 43940)
				{
					continue;
				}
				this.Init();
				if (189759 - 595563 == -405803)
				{
					continue;
				}
			}
			if (nIcon == "none")
			{
				if (206967 - 292440 != -85473)
				{
					continue;
				}
				this.sSycP5vUAvp = null;
				if (66624 - 256953 == -190328)
				{
					continue;
				}
			}
			else
			{
				this.sSycP5vUAvp = (Texture)Resources.Load("GameGui/Story/Characters/" + nIcon, typeof(Texture));
				if (196183 - 178762 == 17422)
				{
					continue;
				}
			}
			this.BnUcPcbOAUb = nName;
			if (83342 - 395485 != -312142)
			{
				this.px3cPnTheo5 = nMessage;
				if (246337 - 239888 == 6449)
				{
					this.LRScPebaSwn = nTalkType;
					if (79329 - 133790 != -54460)
					{
						this.DBvcEVJIavv = eStoryState.normal;
						if (199111 - 235080 == -35969)
						{
							this.xNScEhT00Aj = Time.time;
							if (278376 - 50 == 278326)
							{
								break;
							}
						}
					}
				}
			}
		}
		return true;
	}

	// Token: 0x0600630E RID: 25358 RVA: 0x00DC0E00 File Offset: 0x00DBF000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTalkBar(string m)
	{
		if (127124 - 575357 != -448233)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(0.5f * this.AficEKD7ZYL - (float)350, (float)724, (float)850, (float)200));
			if (215825 - 6492 == 209333)
			{
				eTalkType lrscPebaSwn = this.LRScPebaSwn;
				if (3585 - 542549 != -538963)
				{
					if (lrscPebaSwn == eTalkType.system)
					{
						if (84074 - 145419 != -61345)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)845, (float)199), this.EdVcP2GajT2);
						if (13413 - 447623 == -434209)
						{
							continue;
						}
					}
					else if (lrscPebaSwn == eTalkType.friend)
					{
						if (72885 - 390184 != -317299)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)845, (float)199), this.TFMcPvc0VYV);
						if (160351 - 89878 != 70473)
						{
							continue;
						}
					}
					else if (lrscPebaSwn == eTalkType.enemy)
					{
						if (258904 - 595985 == -337080)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)845, (float)199), this.Fi8cPl8EAOc);
						if (295344 - 199421 == 95924)
						{
							continue;
						}
					}
					GUI.Label(new Rect((float)82, (float)24, (float)300, (float)50), this.BnUcPcbOAUb, this.GTgcPXcB44l);
					if (249926 - 70844 == 179082)
					{
						GUI.Label(new Rect((float)100, (float)90, (float)740, (float)50), m, this.PmFcPOorYEW);
						if (160216 - 277215 == -116999)
						{
							GUI.EndGroup();
							if (254158 - 560801 == -306643)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600630F RID: 25359 RVA: 0x00DC105C File Offset: 0x00DBF25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void close()
	{
		if (235334 - 238999 != -3665)
		{
		}
		for (;;)
		{
			if (this.DBvcEVJIavv != eStoryState.open)
			{
				if (261824 - 361942 != -100118)
				{
					continue;
				}
				if (this.DBvcEVJIavv != eStoryState.normal)
				{
					if (297622 - 164339 == 133284)
					{
						continue;
					}
					if (this.DBvcEVJIavv != eStoryState.blank)
					{
						if (89180 - 272396 != -183216)
						{
							continue;
						}
						if (this.DBvcEVJIavv != eStoryState.yesno)
						{
							break;
						}
						if (252184 - 203324 != 48860)
						{
							continue;
						}
					}
				}
			}
			this.DBvcEVJIavv = eStoryState.close;
			if (222168 - 584716 == -362548)
			{
				this.xNScEhT00Aj = Time.time;
				if (143600 - 255829 == -112229)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006310 RID: 25360 RVA: 0x00DC1174 File Offset: 0x00DBF374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void disable()
	{
		if (193032 - 368891 != -175858)
		{
		}
		while (this.DBvcEVJIavv != eStoryState.init)
		{
			if (128380 - 31559 == 96821)
			{
				this.DBvcEVJIavv = eStoryState.disabled;
				if (76804 - 161600 == -84796)
				{
					this.xNScEhT00Aj = Time.time;
					if (193678 - 425255 == -231577)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006311 RID: 25361 RVA: 0x00DC1218 File Offset: 0x00DBF418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void blank()
	{
		this.DBvcEVJIavv = eStoryState.blank;
		this.xNScEhT00Aj = Time.time;
	}

	// Token: 0x06006312 RID: 25362 RVA: 0x00DC122C File Offset: 0x00DBF42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006313 RID: 25363 RVA: 0x00DC1230 File Offset: 0x00DBF430
	internal static bool aX5ZeepkkQFiVvygktvV()
	{
		return true;
	}

	// Token: 0x06006314 RID: 25364 RVA: 0x00DC1234 File Offset: 0x00DBF434
	internal static bool DtRDunpkGO225BJOqmyM()
	{
		return false;
	}

	// Token: 0x040072B5 RID: 29365
	private eStoryState DBvcEVJIavv;

	// Token: 0x040072B6 RID: 29366
	private float xNScEhT00Aj;

	// Token: 0x040072B7 RID: 29367
	private float AficEKD7ZYL;

	// Token: 0x040072B8 RID: 29368
	private float lqhcEzYIrjC;

	// Token: 0x040072B9 RID: 29369
	private Texture sSycP5vUAvp;

	// Token: 0x040072BA RID: 29370
	private string BnUcPcbOAUb;

	// Token: 0x040072BB RID: 29371
	private string px3cPnTheo5;

	// Token: 0x040072BC RID: 29372
	private string F0ncPQFu9Xs;

	// Token: 0x040072BD RID: 29373
	private eTalkType LRScPebaSwn;

	// Token: 0x040072BE RID: 29374
	private eTalkMode psbcPIQqeaB;

	// Token: 0x040072BF RID: 29375
	private int Jd5cPJtQp07;

	// Token: 0x040072C0 RID: 29376
	private int DWmcP6fPHFT;

	// Token: 0x040072C1 RID: 29377
	private bool EigcPthngAM;

	// Token: 0x040072C2 RID: 29378
	private GUIStyle GTgcPXcB44l;

	// Token: 0x040072C3 RID: 29379
	private GUIStyle PmFcPOorYEW;

	// Token: 0x040072C4 RID: 29380
	private Texture EdVcP2GajT2;

	// Token: 0x040072C5 RID: 29381
	private Texture TFMcPvc0VYV;

	// Token: 0x040072C6 RID: 29382
	private Texture Fi8cPl8EAOc;
}
