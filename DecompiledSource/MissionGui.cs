using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001088 RID: 4232
[Serializable]
public class MissionGui : MonoBehaviour
{
	// Token: 0x0600622C RID: 25132 RVA: 0x00D80160 File Offset: 0x00D7E360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MissionGui()
	{
		if (114649 - 36114 != 78535)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (126362 - 392442 == -266080)
			{
				base..ctor();
				if (129845 - 392800 == -262955)
				{
					this.HeGcCkg9Cyt = eMissionState.init;
					if (175202 - 345488 == -170286)
					{
						this.V5wcCFOg9QT = eMissionSelectMode.mission;
						if (210107 - 107640 == 102467)
						{
							this.mType = eMissionGuiType.guild;
							if (217131 - 220135 == -3004)
							{
								this.N6Hcf4ZG2YW = -1;
								if (158865 - 276772 != -117906)
								{
									this.t4jcfsesB5S = -1;
									if (9384 - 27065 != -17680)
									{
										this.aoRcffyBoam = -1;
										if (233571 - 523234 == -289663)
										{
											this.HRdcL68KVyr = string.Empty;
											if (92187 - 29804 == 62383)
											{
												this.uRscLX5Cell = new Vector2((float)0, (float)3000);
												if (139658 - 259175 != -119516)
												{
													this.RWFcLOoCcpG = true;
													if (183488 - 330962 == -147474)
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

	// Token: 0x0600622D RID: 25133 RVA: 0x00D80310 File Offset: 0x00D7E510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (262044 - 23889 != 238155)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (289549 - 476983 == -187434)
			{
				this.V5wcCFOg9QT = eMissionSelectMode.mission;
				if (291568 - 396255 != -104686)
				{
					if (this.HeGcCkg9Cyt == eMissionState.init)
					{
						if (226093 - 170754 == 55340)
						{
							continue;
						}
						this.InitNPC();
						if (31021 - 405815 == -374793)
						{
							continue;
						}
						this.InitMissionMenu();
						if (121669 - 437540 == -315870)
						{
							continue;
						}
						this.InitRecordBar();
						if (185310 - 227455 == -42144)
						{
							continue;
						}
						this.InitMatchBar();
						if (103198 - 474320 != -371122)
						{
							continue;
						}
						this.InitChatBar();
						if (207126 - 354709 != -147583)
						{
							continue;
						}
					}
					this.ResetNPC();
					if (62217 - 295553 != -233335)
					{
						this.ResetMissionMenu();
						if (155453 - 30766 != 124688)
						{
							this.HeGcCkg9Cyt = eMissionState.open;
							if (89485 - 570682 == -481197)
							{
								this.L4rcCAGc8mu = Time.time;
								if (271918 - 164900 == 107018)
								{
									if (PlayerPrefs.GetInt("privateRoom", 0) == 1)
									{
										if (247569 - 280112 == -32542)
										{
											continue;
										}
										this.gDNcMOEi4v6 = true;
										if (10906 - 469960 != -459054)
										{
											continue;
										}
									}
									else
									{
										this.gDNcMOEi4v6 = false;
										if (79655 - 149787 != -70132)
										{
											continue;
										}
									}
									if (this.GGacC9TpOAR < Time.time - (float)12)
									{
										if (231374 - 186598 != 44776)
										{
											continue;
										}
										this.GGacC9TpOAR = Time.time;
										if (137614 - 124043 == 13572)
										{
											continue;
										}
										eMissionGuiType eMissionGuiType = this.mType;
										if (34003 - 57605 != -23602)
										{
											continue;
										}
										if (eMissionGuiType == eMissionGuiType.guild)
										{
											if (173602 - 395799 == -222196)
											{
												continue;
											}
											this.ListMission(0);
											if (43037 - 409688 == -366650)
											{
												continue;
											}
										}
										else if (eMissionGuiType == eMissionGuiType.town)
										{
											if (78743 - 400774 != -322031)
											{
												continue;
											}
											this.ListMission(3);
											if (266236 - 103598 == 162639)
											{
												continue;
											}
										}
										else if (eMissionGuiType == eMissionGuiType.arena)
										{
											if (97977 - 112919 == -14941)
											{
												continue;
											}
											this.ListMission(4);
											if (271847 - 258567 != 13280)
											{
												continue;
											}
										}
										else if (eMissionGuiType == eMissionGuiType.dungeon)
										{
											if (82325 - 261663 == -179337)
											{
												continue;
											}
										}
									}
									this.acHcCWIWCnx = Time.time;
									if (229774 - 306512 == -76738)
									{
										ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
										if (221585 - 525674 == -304089)
										{
											if (!changeGui)
											{
												break;
											}
											if (231707 - 470455 != -238747)
											{
												changeGui.disable();
												if (90617 - 150338 != -59720)
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

	// Token: 0x0600622E RID: 25134 RVA: 0x00D80750 File Offset: 0x00D7E950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (154683 - 354291 != -199607)
		{
		}
		for (;;)
		{
			if (this.HeGcCkg9Cyt <= eMissionState.init)
			{
				if (4433 - 284691 == -280258)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (50370 - 255428 == -205058)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (172962 - 234446 == -61484)
					{
						this.T45cCyVhtgd = (float)(1024 * Screen.width / Screen.height);
						if (299025 - 411844 == -112819)
						{
							this.fhucCVXKrBS = (float)Screen.height / 1024f;
							if (41183 - 310931 == -269748)
							{
								this.RenderMissionMenu();
								if (249419 - 492811 == -243392)
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

	// Token: 0x0600622F RID: 25135 RVA: 0x00D808A0 File Offset: 0x00D7EAA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMissionMenu()
	{
		if (207145 - 263895 != -56749)
		{
		}
		for (;;)
		{
			IL_2BBC:
			this.s6gcCukRVfQ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
			if (36823 - 420467 != -383643)
			{
				this.zpCcM1sSJB3 = (Texture)Resources.Load("GameGui/MissionWindow/missionWindow", typeof(Texture));
				if (169788 - 557975 != -388186)
				{
					this.RGUcMGX8HcF = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
					if (106226 - 516325 != -410098)
					{
						this.WKDcMqjWvjD = (Texture)Resources.Load("GameGui/MissionWindow/searchBar", typeof(Texture));
						if (17349 - 299480 == -282131)
						{
							this.XT8cMRhcF3e = (Texture)Resources.Load("GameGui/MissionWindow/listStar", typeof(Texture));
							if (107863 - 83648 == 24215)
							{
								this.zfZcMYeRYTY = (Texture)Resources.Load("GameGui/MissionWindow/title_summary", typeof(Texture));
								if (235544 - 478540 != -242995)
								{
									this.ALNcM3KeNBF = (Texture)Resources.Load("GameGui/MissionWindow/title_objective", typeof(Texture));
									if (110037 - 261939 != -151901)
									{
										this.kiTcMr3DSmR = (Texture)Resources.Load("GameGui/MissionWindow/header_town", typeof(Texture));
										if (142433 - 50369 == 92064)
										{
											this.s4PcMxSM4KI = (Texture)Resources.Load("GameGui/MissionWindow/header_arena", typeof(Texture));
											if (283637 - 518917 != -235279)
											{
												this.r5ycMTEYxlX = (Texture)Resources.Load("GameGui/MissionWindow/header_dungeon", typeof(Texture));
												if (232474 - 282307 != -49832)
												{
													this.tXfcMbSmHvR = (Texture)Resources.Load("GameGui/MissionWindow/title_team0", typeof(Texture));
													if (124312 - 394713 == -270401)
													{
														this.DB0cMdG7Phx = (Texture)Resources.Load("GameGui/MissionWindow/title_team1", typeof(Texture));
														if (161690 - 154322 != 7369)
														{
															this.GulcMgHWJeM = (Texture)Resources.Load("GameGui/MissionWindow/title_team2", typeof(Texture));
															if (180632 - 517713 == -337081)
															{
																this.rPgcMaLylWk = (Texture)Resources.Load("GameGui/MissionWindow/title_team3", typeof(Texture));
																if (168011 - 21677 != 146335)
																{
																	this.OctcM4i9gTI = (Texture)Resources.Load("GameGui/MissionWindow/title_team4", typeof(Texture));
																	if (47167 - 194908 == -147741)
																	{
																		this.YiAcMsNnfR3 = (Texture)Resources.Load("GameGui/MissionWindow/title_team5", typeof(Texture));
																		if (99220 - 306501 == -207281)
																		{
																			this.UyrcMHIQ76S = (Texture)Resources.Load("GameGui/MissionWindow/matchSearch", typeof(Texture));
																			if (108475 - 224164 == -115689)
																			{
																				this.qXscM7pXUtx = (Texture)Resources.Load("GameGui/MissionWindow/matchFound", typeof(Texture));
																				if (17986 - 501125 == -483139)
																				{
																					this.PGYcMZAuJ79 = (Texture)Resources.Load("GameGui/MissionWindow/matchStart", typeof(Texture));
																					if (70709 - 583070 == -512361)
																					{
																						this.u5gcMCFwFJK = new GUIStyle();
																						if (214928 - 142693 == 72235)
																						{
																							this.u5gcMCFwFJK.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/matchCancel", typeof(Texture)));
																							if (166354 - 10436 == 155918)
																							{
																								this.VTwcMM157vy = new GUIStyle();
																								if (151136 - 395743 != -244606)
																								{
																									this.VTwcMM157vy.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_mission", typeof(Texture)));
																									if (45856 - 241276 != -195419)
																									{
																										this.YbycMf7ENWK = new GUIStyle();
																										if (198002 - 310000 != -111997)
																										{
																											this.YbycMf7ENWK.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_area", typeof(Texture)));
																											if (153872 - 359072 != -205199)
																											{
																												this.Nv1cML8YUFd = new GUIStyle();
																												if (138285 - 313212 != -174926)
																												{
																													this.Nv1cML8YUFd.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_guild", typeof(Texture)));
																													if (177295 - 542567 == -365272)
																													{
																														this.o8xcMwqaerl = new GUIStyle();
																														if (288950 - 129407 != 159544)
																														{
																															this.o8xcMwqaerl.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt1", typeof(Texture)));
																															if (22961 - 279348 != -256386)
																															{
																																this.o8xcMwqaerl.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt1_h", typeof(Texture)));
																																if (192137 - 35802 == 156335)
																																{
																																	this.o8xcMwqaerl.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt1_i", typeof(Texture)));
																																	if (11802 - 33003 == -21201)
																																	{
																																		this.FBScMU3slIB = new GUIStyle();
																																		if (100196 - 480664 != -380467)
																																		{
																																			this.FBScMU3slIB.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt2", typeof(Texture)));
																																			if (126578 - 134043 != -7464)
																																			{
																																				this.FBScMU3slIB.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt2_h", typeof(Texture)));
																																				if (239843 - 442688 != -202844)
																																				{
																																					this.FBScMU3slIB.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt2_i", typeof(Texture)));
																																					if (147069 - 539028 != -391958)
																																					{
																																						this.CGBcMNNDdjq = new GUIStyle();
																																						if (145244 - 581718 != -436473)
																																						{
																																							this.CGBcMNNDdjq.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt3", typeof(Texture)));
																																							if (46916 - 514708 == -467792)
																																							{
																																								this.CGBcMNNDdjq.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt3_h", typeof(Texture)));
																																								if (143723 - 65386 == 78337)
																																								{
																																									this.CGBcMNNDdjq.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt3_i", typeof(Texture)));
																																									if (21128 - 183366 != -162237)
																																									{
																																										this.P1JcMElT010 = new GUIStyle();
																																										if (109687 - 270911 != -161223)
																																										{
																																											this.P1JcMElT010.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt4", typeof(Texture)));
																																											if (13035 - 364228 == -351193)
																																											{
																																												this.P1JcMElT010.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt4_h", typeof(Texture)));
																																												if (270095 - 37542 != 232554)
																																												{
																																													this.P1JcMElT010.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt4_i", typeof(Texture)));
																																													if (75155 - 295894 == -220739)
																																													{
																																														this.pdLcMP9YIL2 = new GUIStyle();
																																														if (225944 - 337254 != -111309)
																																														{
																																															this.pdLcMP9YIL2.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt5", typeof(Texture)));
																																															if (44205 - 352708 != -308502)
																																															{
																																																this.pdLcMP9YIL2.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt5_h", typeof(Texture)));
																																																if (108829 - 447718 != -338888)
																																																{
																																																	this.pdLcMP9YIL2.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt5_i", typeof(Texture)));
																																																	if (275126 - 168700 == 106426)
																																																	{
																																																		this.XLTcMSXe5u8 = new GUIStyle();
																																																		if (67124 - 528618 == -461494)
																																																		{
																																																			this.XLTcMSXe5u8.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt6", typeof(Texture)));
																																																			if (118381 - 225728 != -107346)
																																																			{
																																																				this.XLTcMSXe5u8.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt6_h", typeof(Texture)));
																																																				if (98775 - 55803 == 42972)
																																																				{
																																																					this.XLTcMSXe5u8.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt6_i", typeof(Texture)));
																																																					if (15795 - 53790 != -37994)
																																																					{
																																																						this.XgLcMBWrSLW = new GUIStyle();
																																																						if (142156 - 379065 != -236908)
																																																						{
																																																							this.XgLcMBWrSLW.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt7", typeof(Texture)));
																																																							if (295975 - 563501 != -267525)
																																																							{
																																																								this.XgLcMBWrSLW.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt7_h", typeof(Texture)));
																																																								if (114097 - 61555 == 52542)
																																																								{
																																																									this.XgLcMBWrSLW.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt7_i", typeof(Texture)));
																																																									if (269539 - 229441 == 40098)
																																																									{
																																																										this.U29cM02eEv9 = new GUIStyle();
																																																										if (275141 - 5336 != 269806)
																																																										{
																																																											this.U29cM02eEv9.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt8", typeof(Texture)));
																																																											if (65441 - 352150 != -286708)
																																																											{
																																																												this.U29cM02eEv9.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt8_h", typeof(Texture)));
																																																												if (270617 - 258842 == 11775)
																																																												{
																																																													this.U29cM02eEv9.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt8_i", typeof(Texture)));
																																																													if (192795 - 96933 == 95862)
																																																													{
																																																														this.MTAcM81WKKt = new GUIStyle();
																																																														if (278662 - 261515 == 17147)
																																																														{
																																																															this.MTAcM81WKKt.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt9", typeof(Texture)));
																																																															if (283146 - 176375 == 106771)
																																																															{
																																																																this.MTAcM81WKKt.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt9_h", typeof(Texture)));
																																																																if (19704 - 45331 == -25627)
																																																																{
																																																																	this.MTAcM81WKKt.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt9_i", typeof(Texture)));
																																																																	if (177460 - 11488 != 165973)
																																																																	{
																																																																		this.IvEcMiJ6Fxm = new GUIStyle();
																																																																		if (142205 - 359867 == -217662)
																																																																		{
																																																																			this.IvEcMiJ6Fxm.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt10", typeof(Texture)));
																																																																			if (268471 - 205557 == 62914)
																																																																			{
																																																																				this.IvEcMiJ6Fxm.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt10_h", typeof(Texture)));
																																																																				if (418 - 75435 == -75017)
																																																																				{
																																																																					this.IvEcMiJ6Fxm.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt10_i", typeof(Texture)));
																																																																					if (69695 - 528159 == -458464)
																																																																					{
																																																																						this.huAcMD9Isey = new GUIStyle();
																																																																						if (175656 - 234994 == -59338)
																																																																						{
																																																																							this.huAcMD9Isey.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt11", typeof(Texture)));
																																																																							if (189164 - 38317 != 150848)
																																																																							{
																																																																								this.huAcMD9Isey.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt11_h", typeof(Texture)));
																																																																								if (207626 - 179924 != 27703)
																																																																								{
																																																																									this.huAcMD9Isey.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt11_i", typeof(Texture)));
																																																																									if (169712 - 163083 == 6629)
																																																																									{
																																																																										this.pPVcMmdparU = new GUIStyle();
																																																																										if (245318 - 494040 != -248721)
																																																																										{
																																																																											this.pPVcMmdparU.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt12", typeof(Texture)));
																																																																											if (30522 - 299818 != -269295)
																																																																											{
																																																																												this.pPVcMmdparU.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt12_h", typeof(Texture)));
																																																																												if (292698 - 448646 == -155948)
																																																																												{
																																																																													this.pPVcMmdparU.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chapt12_i", typeof(Texture)));
																																																																													if (209577 - 255905 == -46328)
																																																																													{
																																																																														this.NvYcMjaPNFr = new GUIStyle();
																																																																														if (69780 - 149385 == -79605)
																																																																														{
																																																																															this.NvYcMjaPNFr.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chaptGM", typeof(Texture)));
																																																																															if (93526 - 101576 != -8049)
																																																																															{
																																																																																this.NvYcMjaPNFr.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_chaptGM_h", typeof(Texture)));
																																																																																if (282730 - 465698 == -182968)
																																																																																{
																																																																																	this.s24cMoYKaZU = new GUIStyle();
																																																																																	if (290482 - 63907 != 226576)
																																																																																	{
																																																																																		this.s24cMoYKaZU.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day1", typeof(Texture)));
																																																																																		if (95179 - 376967 != -281787)
																																																																																		{
																																																																																			this.s24cMoYKaZU.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day1_h", typeof(Texture)));
																																																																																			if (172713 - 3019 == 169694)
																																																																																			{
																																																																																				this.s24cMoYKaZU.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day1_i", typeof(Texture)));
																																																																																				if (222572 - 81923 != 140650)
																																																																																				{
																																																																																					this.oyHcMkF6IQf = new GUIStyle();
																																																																																					if (218695 - 253112 != -34416)
																																																																																					{
																																																																																						this.oyHcMkF6IQf.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day2", typeof(Texture)));
																																																																																						if (98926 - 60305 == 38621)
																																																																																						{
																																																																																							this.oyHcMkF6IQf.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day2_h", typeof(Texture)));
																																																																																							if (245085 - 494409 == -249324)
																																																																																							{
																																																																																								this.oyHcMkF6IQf.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day2_i", typeof(Texture)));
																																																																																								if (107089 - 346968 != -239878)
																																																																																								{
																																																																																									this.TKqcMFAVcbL = new GUIStyle();
																																																																																									if (200480 - 599637 == -399157)
																																																																																									{
																																																																																										this.TKqcMFAVcbL.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day3", typeof(Texture)));
																																																																																										if (161746 - 444147 != -282400)
																																																																																										{
																																																																																											this.TKqcMFAVcbL.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day3_h", typeof(Texture)));
																																																																																											if (7435 - 443183 == -435748)
																																																																																											{
																																																																																												this.TKqcMFAVcbL.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day3_i", typeof(Texture)));
																																																																																												if (226251 - 12544 != 213708)
																																																																																												{
																																																																																													this.zPrcMA5RWDE = new GUIStyle();
																																																																																													if (276825 - 392845 != -116019)
																																																																																													{
																																																																																														this.zPrcMA5RWDE.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day4", typeof(Texture)));
																																																																																														if (92605 - 247784 != -155178)
																																																																																														{
																																																																																															this.zPrcMA5RWDE.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day4_h", typeof(Texture)));
																																																																																															if (138734 - 19891 != 118844)
																																																																																															{
																																																																																																this.zPrcMA5RWDE.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day4_i", typeof(Texture)));
																																																																																																if (196869 - 468771 == -271902)
																																																																																																{
																																																																																																	this.U95cM9UyP2Q = new GUIStyle();
																																																																																																	if (243538 - 370156 != -126617)
																																																																																																	{
																																																																																																		this.U95cM9UyP2Q.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day5", typeof(Texture)));
																																																																																																		if (229919 - 311013 != -81093)
																																																																																																		{
																																																																																																			this.U95cM9UyP2Q.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day5_h", typeof(Texture)));
																																																																																																			if (42162 - 271145 != -228982)
																																																																																																			{
																																																																																																				this.U95cM9UyP2Q.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day5_i", typeof(Texture)));
																																																																																																				if (157072 - 264876 != -107803)
																																																																																																				{
																																																																																																					this.l5KcMW9wsT7 = new GUIStyle();
																																																																																																					if (269936 - 98079 == 171857)
																																																																																																					{
																																																																																																						this.l5KcMW9wsT7.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day6", typeof(Texture)));
																																																																																																						if (78012 - 228070 != -150057)
																																																																																																						{
																																																																																																							this.l5KcMW9wsT7.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day6_h", typeof(Texture)));
																																																																																																							if (35198 - 482592 == -447394)
																																																																																																							{
																																																																																																								this.l5KcMW9wsT7.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day6_i", typeof(Texture)));
																																																																																																								if (37681 - 277963 == -240282)
																																																																																																								{
																																																																																																									this.Bq4cMugRf4q = new GUIStyle();
																																																																																																									if (138595 - 252732 == -114137)
																																																																																																									{
																																																																																																										this.Bq4cMugRf4q.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day7", typeof(Texture)));
																																																																																																										if (156254 - 505794 == -349540)
																																																																																																										{
																																																																																																											this.Bq4cMugRf4q.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day7_h", typeof(Texture)));
																																																																																																											if (108169 - 249749 != -141579)
																																																																																																											{
																																																																																																												this.Bq4cMugRf4q.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/tab_day7_i", typeof(Texture)));
																																																																																																												if (239770 - 597908 == -358138)
																																																																																																												{
																																																																																																													this.mu6cMycy0Ne = new GUIStyle();
																																																																																																													if (298308 - 536758 == -238450)
																																																																																																													{
																																																																																																														this.mu6cMycy0Ne.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
																																																																																																														if (103646 - 501335 == -397689)
																																																																																																														{
																																																																																																															this.mu6cMycy0Ne.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																																																																																															if (92599 - 359434 != -266834)
																																																																																																															{
																																																																																																																this.mu6cMycy0Ne.hover.textColor = new Color(0.6f, 0.06f, 0.43f, (float)1);
																																																																																																																if (114501 - 20799 != 93703)
																																																																																																																{
																																																																																																																	this.mu6cMycy0Ne.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_list", typeof(Texture)));
																																																																																																																	if (268074 - 108202 != 159873)
																																																																																																																	{
																																																																																																																		this.mu6cMycy0Ne.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_list_h", typeof(Texture)));
																																																																																																																		if (127464 - 310065 == -182601)
																																																																																																																		{
																																																																																																																			this.jeMcMVdaOFZ = new GUIStyle();
																																																																																																																			if (76812 - 27011 == 49801)
																																																																																																																			{
																																																																																																																				this.jeMcMVdaOFZ.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
																																																																																																																				if (86712 - 202749 == -116037)
																																																																																																																				{
																																																																																																																					this.jeMcMVdaOFZ.normal.textColor = new Color(0.06f, 0.6f, 0.43f, (float)1);
																																																																																																																					if (247508 - 262110 != -14601)
																																																																																																																					{
																																																																																																																						this.jeMcMVdaOFZ.normal.background = this.mu6cMycy0Ne.hover.background;
																																																																																																																						if (108746 - 92352 != 16395)
																																																																																																																						{
																																																																																																																							this.a7KcMhwvE0q = new GUIStyle();
																																																																																																																							if (212480 - 321956 == -109476)
																																																																																																																							{
																																																																																																																								this.a7KcMhwvE0q.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
																																																																																																																								if (53950 - 45061 == 8889)
																																																																																																																								{
																																																																																																																									this.a7KcMhwvE0q.normal.textColor = new Color(0.06f, 0.6f, 0.43f, (float)1);
																																																																																																																									if (242263 - 412104 != -169840)
																																																																																																																									{
																																																																																																																										this.a7KcMhwvE0q.normal.background = this.mu6cMycy0Ne.hover.background;
																																																																																																																										if (176085 - 304861 != -128775)
																																																																																																																										{
																																																																																																																											this.Bo6cMKxjM2x = new GUIStyle();
																																																																																																																											if (169196 - 47517 == 121679)
																																																																																																																											{
																																																																																																																												this.Bo6cMKxjM2x.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
																																																																																																																												if (194373 - 132704 != 61670)
																																																																																																																												{
																																																																																																																													this.Bo6cMKxjM2x.normal.textColor = new Color(0.46f, 0.4f, 0.28f, (float)1);
																																																																																																																													if (117433 - 103157 != 14277)
																																																																																																																													{
																																																																																																																														this.Bo6cMKxjM2x.normal.background = this.mu6cMycy0Ne.normal.background;
																																																																																																																														if (265818 - 100008 == 165810)
																																																																																																																														{
																																																																																																																															this.PEQcMzR3pyj = new GUIStyle();
																																																																																																																															if (75468 - 11508 != 63961)
																																																																																																																															{
																																																																																																																																this.PEQcMzR3pyj.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
																																																																																																																																if (100511 - 90527 != 9985)
																																																																																																																																{
																																																																																																																																	this.PEQcMzR3pyj.normal.textColor = new Color(0.28f, 0.4f, 0.5f, (float)1);
																																																																																																																																	if (284455 - 336567 != -52111)
																																																																																																																																	{
																																																																																																																																		this.PEQcMzR3pyj.normal.background = this.mu6cMycy0Ne.normal.background;
																																																																																																																																		if (70082 - 96542 == -26460)
																																																																																																																																		{
																																																																																																																																			this.F5icf5cI9vA = new GUIStyle();
																																																																																																																																			if (55880 - 287853 != -231972)
																																																																																																																																			{
																																																																																																																																				this.F5icf5cI9vA.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																																																																																																																																				if (53416 - 288548 == -235132)
																																																																																																																																				{
																																																																																																																																					this.F5icf5cI9vA.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																																																																																																																					if (269371 - 261758 == 7613)
																																																																																																																																					{
																																																																																																																																						this.F5icf5cI9vA.wordWrap = true;
																																																																																																																																						if (152349 - 333210 == -180861)
																																																																																																																																						{
																																																																																																																																							this.sttcfc0d0X5 = new GUIStyle();
																																																																																																																																							if (53093 - 387760 == -334667)
																																																																																																																																							{
																																																																																																																																								this.sttcfc0d0X5.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																																																																																																																																								if (261831 - 316793 != -54961)
																																																																																																																																								{
																																																																																																																																									this.sttcfc0d0X5.normal.textColor = new Color(0.2f, 0.17f, 0.14f, (float)1);
																																																																																																																																									if (26439 - 390636 == -364197)
																																																																																																																																									{
																																																																																																																																										this.sttcfc0d0X5.wordWrap = true;
																																																																																																																																										if (283711 - 365162 != -81450)
																																																																																																																																										{
																																																																																																																																											this.NKVcfn22ZtW = new GUIStyle();
																																																																																																																																											if (190345 - 372821 != -182475)
																																																																																																																																											{
																																																																																																																																												this.NKVcfn22ZtW.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																																																																																																																												if (67880 - 581052 != -513171)
																																																																																																																																												{
																																																																																																																																													this.NKVcfn22ZtW.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																																																																																																																													if (140297 - 97399 == 42898)
																																																																																																																																													{
																																																																																																																																														this.NKVcfn22ZtW.alignment = TextAnchor.MiddleCenter;
																																																																																																																																														if (257304 - 245613 == 11691)
																																																																																																																																														{
																																																																																																																																															this.e1DcfQ3ex3l = new GUIStyle();
																																																																																																																																															if (125008 - 135884 != -10875)
																																																																																																																																															{
																																																																																																																																																this.e1DcfQ3ex3l.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_close_h", typeof(Texture)));
																																																																																																																																																if (208571 - 431278 != -222706)
																																																																																																																																																{
																																																																																																																																																	this.aT6cfeAjuFQ = new GUIStyle();
																																																																																																																																																	if (259957 - 422001 != -162043)
																																																																																																																																																	{
																																																																																																																																																		this.aT6cfeAjuFQ.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_create", typeof(Texture)));
																																																																																																																																																		if (162379 - 570691 != -408311)
																																																																																																																																																		{
																																																																																																																																																			this.aT6cfeAjuFQ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_create_h", typeof(Texture)));
																																																																																																																																																			if (14414 - 9511 != 4904)
																																																																																																																																																			{
																																																																																																																																																				this.t23cfI0D2aP = new GUIStyle();
																																																																																																																																																				if (215203 - 519924 != -304720)
																																																																																																																																																				{
																																																																																																																																																					this.t23cfI0D2aP.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_join", typeof(Texture)));
																																																																																																																																																					if (19449 - 431563 == -412114)
																																																																																																																																																					{
																																																																																																																																																						this.t23cfI0D2aP.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_join_h", typeof(Texture)));
																																																																																																																																																						if (153415 - 200877 == -47462)
																																																																																																																																																						{
																																																																																																																																																							this.p9ScfJZBqDb = new GUIStyle();
																																																																																																																																																							if (274653 - 135911 == 138742)
																																																																																																																																																							{
																																																																																																																																																								this.p9ScfJZBqDb.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_start", typeof(Texture)));
																																																																																																																																																								if (282839 - 533412 == -250573)
																																																																																																																																																								{
																																																																																																																																																									this.p9ScfJZBqDb.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_start_h", typeof(Texture)));
																																																																																																																																																									if (74968 - 53224 != 21745)
																																																																																																																																																									{
																																																																																																																																																										this.NTGcf6ubKck = new GUIStyle();
																																																																																																																																																										if (74626 - 472004 != -397377)
																																																																																																																																																										{
																																																																																																																																																											this.NTGcf6ubKck.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_cancel", typeof(Texture)));
																																																																																																																																																											if (59501 - 296334 != -236832)
																																																																																																																																																											{
																																																																																																																																																												this.NTGcf6ubKck.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_cancel_h", typeof(Texture)));
																																																																																																																																																												if (181959 - 364515 == -182556)
																																																																																																																																																												{
																																																																																																																																																													this.FrfcfXTjGBC = new GUIStyle();
																																																																																																																																																													if (294774 - 178533 == 116241)
																																																																																																																																																													{
																																																																																																																																																														this.FrfcfXTjGBC.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_search_h", typeof(Texture)));
																																																																																																																																																														if (163247 - 84223 == 79024)
																																																																																																																																																														{
																																																																																																																																																															this.CAscftTnFA0 = new GUIStyle();
																																																																																																																																																															if (128685 - 320606 != -191920)
																																																																																																																																																															{
																																																																																																																																																																this.CAscftTnFA0.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_refresh_h", typeof(Texture)));
																																																																																																																																																																if (238535 - 509614 == -271079)
																																																																																																																																																																{
																																																																																																																																																																	this.icZcfOjPP65 = (Texture)Resources.Load("GameGui/Common/check", typeof(Texture));
																																																																																																																																																																	if (197790 - 12385 != 185406)
																																																																																																																																																																	{
																																																																																																																																																																		this.Of4cf2GEvq1 = new GUIStyle();
																																																																																																																																																																		if (299061 - 54490 == 244571)
																																																																																																																																																																		{
																																																																																																																																																																			this.Of4cf2GEvq1.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/checkBox", typeof(Texture)));
																																																																																																																																																																			if (127717 - 13268 != 114450)
																																																																																																																																																																			{
																																																																																																																																																																				this.Of4cf2GEvq1.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/checkBox_h", typeof(Texture)));
																																																																																																																																																																				if (16314 - 307637 == -291323)
																																																																																																																																																																				{
																																																																																																																																																																					this.JhlcfvBBDH5 = new GUIStyle();
																																																																																																																																																																					if (76993 - 45544 == 31449)
																																																																																																																																																																					{
																																																																																																																																																																						this.JhlcfvBBDH5.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
																																																																																																																																																																						if (278502 - 113704 == 164798)
																																																																																																																																																																						{
																																																																																																																																																																							this.JhlcfvBBDH5.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																																																																																																																																																							if (76576 - 342382 != -265805)
																																																																																																																																																																							{
																																																																																																																																																																								this.JhlcfvBBDH5.alignment = TextAnchor.MiddleLeft;
																																																																																																																																																																								if (55049 - 403658 == -348609)
																																																																																																																																																																								{
																																																																																																																																																																									this.DW8cflw6LAd = new GUIStyle();
																																																																																																																																																																									if (130430 - 333105 == -202675)
																																																																																																																																																																									{
																																																																																																																																																																										this.DW8cflw6LAd.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																																																																																																																																																										if (145741 - 273167 == -127426)
																																																																																																																																																																										{
																																																																																																																																																																											this.LavcfGMel9m = new GUIStyle();
																																																																																																																																																																											if (90573 - 524589 == -434016)
																																																																																																																																																																											{
																																																																																																																																																																												this.LavcfGMel9m.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																																																																																																																																																												if (91356 - 189498 == -98142)
																																																																																																																																																																												{
																																																																																																																																																																													this.LavcfGMel9m.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_player", typeof(Texture)));
																																																																																																																																																																													if (61994 - 488708 != -426713)
																																																																																																																																																																													{
																																																																																																																																																																														this.LavcfGMel9m.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_player_h", typeof(Texture)));
																																																																																																																																																																														if (268003 - 543049 != -275045)
																																																																																																																																																																														{
																																																																																																																																																																															this.L11cf1iJFuW = new GUIStyle();
																																																																																																																																																																															if (145514 - 24069 != 121446)
																																																																																																																																																																															{
																																																																																																																																																																																this.L11cf1iJFuW.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																																																																																																																																																																if (275793 - 580645 != -304851)
																																																																																																																																																																																{
																																																																																																																																																																																	this.L11cf1iJFuW.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_char", typeof(Texture)));
																																																																																																																																																																																	if (29713 - 120282 == -90569)
																																																																																																																																																																																	{
																																																																																																																																																																																		this.Veecfq2QtjG = new GUIStyle();
																																																																																																																																																																																		if (258918 - 44394 != 214525)
																																																																																																																																																																																		{
																																																																																																																																																																																			this.Veecfq2QtjG.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_ready", typeof(Texture)));
																																																																																																																																																																																			if (103418 - 22744 == 80674)
																																																																																																																																																																																			{
																																																																																																																																																																																				this.Veecfq2QtjG.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_ready_h", typeof(Texture)));
																																																																																																																																																																																				if (118858 - 141181 == -22323)
																																																																																																																																																																																				{
																																																																																																																																																																																					this.Veecfq2QtjG.active.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_ready_a", typeof(Texture)));
																																																																																																																																																																																					if (157109 - 309396 == -152287)
																																																																																																																																																																																					{
																																																																																																																																																																																						this.arIcfxJlHJr = (Texture)Resources.Load("GameGui/MissionWindow/other_leader", typeof(Texture));
																																																																																																																																																																																						if (234764 - 464808 != -230043)
																																																																																																																																																																																						{
																																																																																																																																																																																							this.ENTcfYjBfXr = (Texture)Resources.Load("GameGui/MissionWindow/other_ready", typeof(Texture));
																																																																																																																																																																																							if (205922 - 485168 != -279245)
																																																																																																																																																																																							{
																																																																																																																																																																																								this.DEacfTF05hp = (Texture)Resources.Load("GameGui/MissionWindow/other_wait", typeof(Texture));
																																																																																																																																																																																								if (190958 - 486982 == -296024)
																																																																																																																																																																																								{
																																																																																																																																																																																									this.fjscf3YOutn = (Texture)Resources.Load("GameGui/MissionWindow/allow_item", typeof(Texture));
																																																																																																																																																																																									if (77393 - 289625 != -212231)
																																																																																																																																																																																									{
																																																																																																																																																																																										this.tGMcfbCejgj = (Texture)Resources.Load("GameGui/MissionWindow/allow_mount", typeof(Texture));
																																																																																																																																																																																										if (209753 - 392978 == -183225)
																																																																																																																																																																																										{
																																																																																																																																																																																											this.Ne4cfdZEmjk = (Texture)Resources.Load("GameGui/MissionWindow/allow_change", typeof(Texture));
																																																																																																																																																																																											if (101034 - 34981 != 66054)
																																																																																																																																																																																											{
																																																																																																																																																																																												this.zlmcfgSatIG = (Texture)Resources.Load("GameGui/MissionWindow/allow_revive", typeof(Texture));
																																																																																																																																																																																												if (212360 - 210801 == 1559)
																																																																																																																																																																																												{
																																																																																																																																																																																													this.KVicfaMw68h = (Texture)Resources.Load("GameGui/MissionWindow/allow_coin", typeof(Texture));
																																																																																																																																																																																													if (266039 - 526611 != -260571)
																																																																																																																																																																																													{
																																																																																																																																																																																														this.BH0cfp0ZEhx = (Texture)Resources.Load("GameGui/MissionWindow/button_playerMenu", typeof(Texture));
																																																																																																																																																																																														if (240627 - 17353 != 223275)
																																																																																																																																																																																														{
																																																																																																																																																																																															this.r9xcfRB7Jj5 = (Texture)Resources.Load("GameGui/MissionWindow/button_charMenu", typeof(Texture));
																																																																																																																																																																																															if (256583 - 432706 == -176123)
																																																																																																																																																																																															{
																																																																																																																																																																																																this.wivcfrFiCw8 = new GUIStyle();
																																																																																																																																																																																																if (282774 - 413706 == -130932)
																																																																																																																																																																																																{
																																																																																																																																																																																																	this.wivcfrFiCw8.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																																																																																																																																																																																	if (21362 - 327834 == -306472)
																																																																																																																																																																																																	{
																																																																																																																																																																																																		this.wivcfrFiCw8.alignment = TextAnchor.MiddleLeft;
																																																																																																																																																																																																		if (85856 - 333293 != -247436)
																																																																																																																																																																																																		{
																																																																																																																																																																																																			this.wivcfrFiCw8.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																																																																																																																																																																																			if (163284 - 524664 != -361379)
																																																																																																																																																																																																			{
																																																																																																																																																																																																				this.wivcfrFiCw8.hover.textColor = new Color(0.06f, 0.6f, 0.43f, (float)1);
																																																																																																																																																																																																				if (2903 - 135409 == -132506)
																																																																																																																																																																																																				{
																																																																																																																																																																																																					this.wivcfrFiCw8.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/button_playerMenu_h", typeof(Texture)));
																																																																																																																																																																																																					if (9373 - 498192 != -488818)
																																																																																																																																																																																																					{
																																																																																																																																																																																																						this.Ph6cfL8crLa = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
																																																																																																																																																																																																						if (16166 - 580122 == -563956)
																																																																																																																																																																																																						{
																																																																																																																																																																																																							this.MHYcfw23xt3 = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																																																																																																																																																																																																							if (62463 - 235463 != -172999)
																																																																																																																																																																																																							{
																																																																																																																																																																																																								this.tDRcfUqyCxE = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																																																																																																																																																																																																								if (222472 - 530948 == -308476)
																																																																																																																																																																																																								{
																																																																																																																																																																																																									this.phJcfNLcQPB = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																																																																																																																																																																																																									if (252994 - 500358 != -247363)
																																																																																																																																																																																																									{
																																																																																																																																																																																																										this.wWocfEaARRv = (AudioClip)Resources.Load("Sound/GUI/clock", typeof(AudioClip));
																																																																																																																																																																																																										if (104822 - 344535 != -239712)
																																																																																																																																																																																																										{
																																																																																																																																																																																																											this.BsAcChUqUV7 = 1;
																																																																																																																																																																																																											if (154364 - 178675 == -24311)
																																																																																																																																																																																																											{
																																																																																																																																																																																																												this.vpEcCKjSAwn = 1;
																																																																																																																																																																																																												if (93628 - 15551 == 78077)
																																																																																																																																																																																																												{
																																																																																																																																																																																																													this.l20cCzKUHlN = 0;
																																																																																																																																																																																																													if (159853 - 556098 == -396245)
																																																																																																																																																																																																													{
																																																																																																																																																																																																														this.oTYcM5rfhDM = new int[97];
																																																																																																																																																																																																														if (118455 - 394281 == -275826)
																																																																																																																																																																																																														{
																																																																																																																																																																																																															this.OkJcMcf7XmO = new int[97];
																																																																																																																																																																																																															if (53215 - 560312 != -507096)
																																																																																																																																																																																																															{
																																																																																																																																																																																																																this.C3xcMteTFQj = (int)DateTime.Now.DayOfWeek;
																																																																																																																																																																																																																if (43618 - 153138 == -109520)
																																																																																																																																																																																																																{
																																																																																																																																																																																																																	this.TrRcfiTWco2 = new IconButtonClass[12];
																																																																																																																																																																																																																	if (187811 - 150673 != 37139)
																																																																																																																																																																																																																	{
																																																																																																																																																																																																																		int i = 0;
																																																																																																																																																																																																																		if (58162 - 414131 == -355969)
																																																																																																																																																																																																																		{
																																																																																																																																																																																																																			while (i < 12)
																																																																																																																																																																																																																			{
																																																																																																																																																																																																																				this.TrRcfiTWco2[i] = new IconButtonClass();
																																																																																																																																																																																																																				if (2480 - 140924 != -138444)
																																																																																																																																																																																																																				{
																																																																																																																																																																																																																					goto IL_2BBC;
																																																																																																																																																																																																																				}
																																																																																																																																																																																																																				i++;
																																																																																																																																																																																																																				if (19026 - 590678 == -571651)
																																																																																																																																																																																																																				{
																																																																																																																																																																																																																					goto IL_2BBC;
																																																																																																																																																																																																																				}
																																																																																																																																																																																																																			}
																																																																																																																																																																																																																			if (209182 - 153865 == 55317)
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
																																																																																																																																																		}
																																																																																																																																																	}
																																																																																																																																																}
																																																																																																																																															}
																																																																																																																																														}
																																																																																																																																													}
																																																																																																																																												}
																																																																																																																																											}
																																																																																																																																										}
																																																																																																																																									}
																																																																																																																																								}
																																																																																																																																							}
																																																																																																																																						}
																																																																																																																																					}
																																																																																																																																				}
																																																																																																																																			}
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																}
																																																																																																																															}
																																																																																																																														}
																																																																																																																													}
																																																																																																																												}
																																																																																																																											}
																																																																																																																										}
																																																																																																																									}
																																																																																																																								}
																																																																																																																							}
																																																																																																																						}
																																																																																																																					}
																																																																																																																				}
																																																																																																																			}
																																																																																																																		}
																																																																																																																	}
																																																																																																																}
																																																																																																															}
																																																																																																														}
																																																																																																													}
																																																																																																												}
																																																																																																											}
																																																																																																										}
																																																																																																									}
																																																																																																								}
																																																																																																							}
																																																																																																						}
																																																																																																					}
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																									}
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																													}
																																																																												}
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006230 RID: 25136 RVA: 0x00D83854 File Offset: 0x00D81A54
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetMissionMenu()
	{
		if (89526 - 576540 != -487013)
		{
		}
		for (;;)
		{
			eMissionGuiType eMissionGuiType = this.mType;
			if (223511 - 508505 == -284994)
			{
				if (eMissionGuiType == eMissionGuiType.guild)
				{
					if (216619 - 490214 != -273595)
					{
						continue;
					}
					int @int = PlayerPrefs.GetInt("lastMission", 0);
					if (121049 - 48760 != 72289)
					{
						continue;
					}
					if (@int != 0)
					{
						if (194204 - 373695 != -179491)
						{
							continue;
						}
						if (@int >= 940)
						{
							if (17998 - 260638 != -242640)
							{
								continue;
							}
						}
						else
						{
							if (@int < 910)
							{
								if (294268 - 251163 == 43106)
								{
									continue;
								}
								this.BsAcChUqUV7 = global::Math.div((float)@int, (float)100);
								if (186943 - 437238 != -250295)
								{
									continue;
								}
							}
							else
							{
								this.BsAcChUqUV7 = 9 + (global::Math.div((float)@int, (float)10) - 90);
								if (217497 - 51110 != 166387)
								{
									continue;
								}
							}
							this.vpEcCKjSAwn = @int;
							if (265909 - 345316 != -79407)
							{
								continue;
							}
							this.l20cCzKUHlN = 0;
							if (226841 - 235710 != -8869)
							{
								continue;
							}
							goto IL_7A3;
						}
					}
					this.BsAcChUqUV7 = 1;
					if (37203 - 487191 == -449987)
					{
						continue;
					}
					this.vpEcCKjSAwn = 101;
					if (123520 - 334678 == -211157)
					{
						continue;
					}
					this.l20cCzKUHlN = 0;
					if (207880 - 533542 != -325662)
					{
						continue;
					}
					IL_7A3:
					int mGameCode = Game.mGameCode;
					if (53072 - 291151 == -238078)
					{
						continue;
					}
					if (mGameCode == 30)
					{
						if (299863 - 365717 != -65854)
						{
							continue;
						}
						if (this.BsAcChUqUV7 > 2)
						{
							if (256327 - 122852 == 133476)
							{
								continue;
							}
							this.BsAcChUqUV7 = 1;
							if (68490 - 141783 != -73293)
							{
								continue;
							}
							this.vpEcCKjSAwn = 101;
							if (45289 - 344618 == -299328)
							{
								continue;
							}
						}
					}
					else if (mGameCode == 32)
					{
						if (237099 - 450026 == -212926)
						{
							continue;
						}
						if (this.BsAcChUqUV7 < 3)
						{
							goto IL_6CD;
						}
						if (277938 - 447109 == -169170)
						{
							continue;
						}
						if (this.BsAcChUqUV7 > 4)
						{
							if (36284 - 355165 != -318880)
							{
								goto IL_6CD;
							}
							continue;
						}
						goto IL_3F3;
						IL_6CD:
						this.BsAcChUqUV7 = 3;
						if (263144 - 180803 == 82342)
						{
							continue;
						}
						this.vpEcCKjSAwn = 301;
						if (136601 - 571271 != -434670)
						{
							continue;
						}
					}
					else if (mGameCode == 33)
					{
						if (151329 - 294654 != -143325)
						{
							continue;
						}
						if (this.BsAcChUqUV7 >= 5)
						{
							if (254453 - 177823 == 76631)
							{
								continue;
							}
							if (this.BsAcChUqUV7 <= 6)
							{
								goto IL_77C;
							}
							if (297103 - 122997 != 174106)
							{
								continue;
							}
						}
						this.BsAcChUqUV7 = 5;
						if (285846 - 122207 != 163639)
						{
							continue;
						}
						this.vpEcCKjSAwn = 501;
						if (50791 - 432484 != -381693)
						{
							continue;
						}
						IL_77C:;
					}
					else if (mGameCode == 34)
					{
						if (266950 - 272742 != -5792)
						{
							continue;
						}
						if (this.BsAcChUqUV7 >= 7)
						{
							if (159319 - 10878 != 148441)
							{
								continue;
							}
							if (this.BsAcChUqUV7 <= 8)
							{
								goto IL_2A4;
							}
							if (293138 - 533187 != -240049)
							{
								continue;
							}
						}
						this.BsAcChUqUV7 = 7;
						if (297322 - 110215 != 187107)
						{
							continue;
						}
						this.vpEcCKjSAwn = 701;
						if (57374 - 274340 == -216965)
						{
							continue;
						}
						IL_2A4:;
					}
					else if (mGameCode == 35)
					{
						if (223056 - 80905 == 142152)
						{
							continue;
						}
						if (this.BsAcChUqUV7 < 9)
						{
							goto IL_718;
						}
						if (267861 - 526993 == -259131)
						{
							continue;
						}
						if (this.BsAcChUqUV7 > 10)
						{
							if (74475 - 158177 != -83702)
							{
								continue;
							}
							goto IL_718;
						}
						goto IL_3F3;
						IL_718:
						this.BsAcChUqUV7 = 9;
						if (20283 - 159680 == -139396)
						{
							continue;
						}
						this.vpEcCKjSAwn = 901;
						if (39632 - 171415 != -131783)
						{
							continue;
						}
					}
					else if (mGameCode == 36)
					{
						if (174388 - 140395 == 33994)
						{
							continue;
						}
						if (this.BsAcChUqUV7 >= 11)
						{
							if (16972 - 536662 == -519689)
							{
								continue;
							}
							if (this.BsAcChUqUV7 <= 12)
							{
								goto IL_3EE;
							}
							if (280533 - 143944 != 136589)
							{
								continue;
							}
						}
						this.BsAcChUqUV7 = 11;
						if (189906 - 191647 == -1740)
						{
							continue;
						}
						this.vpEcCKjSAwn = 921;
						if (190800 - 255446 == -64645)
						{
							continue;
						}
						IL_3EE:;
					}
					IL_3F3:;
				}
				else if (eMissionGuiType == eMissionGuiType.town)
				{
					if (36399 - 136221 == -99821)
					{
						continue;
					}
					this.BsAcChUqUV7 = 1;
					if (279525 - 329064 != -49539)
					{
						continue;
					}
					this.vpEcCKjSAwn = 0;
					if (1921 - 502614 == -500692)
					{
						continue;
					}
					this.l20cCzKUHlN = 0;
					if (49748 - 129474 == -79725)
					{
						continue;
					}
				}
				else if (eMissionGuiType == eMissionGuiType.arena)
				{
					if (198391 - 67681 == 130711)
					{
						continue;
					}
					this.BsAcChUqUV7 = 1;
					if (225790 - 119523 != 106267)
					{
						continue;
					}
					this.vpEcCKjSAwn = 0;
					if (291087 - 215882 == 75206)
					{
						continue;
					}
					this.l20cCzKUHlN = 0;
					if (13494 - 514226 != -500732)
					{
						continue;
					}
				}
				else if (eMissionGuiType == eMissionGuiType.dungeon)
				{
					if (121407 - 270367 == -148959)
					{
						continue;
					}
					this.BsAcChUqUV7 = 1;
					if (67333 - 341898 != -274565)
					{
						continue;
					}
					int mGameCode2 = Game.mGameCode;
					if (31048 - 322310 == -291261)
					{
						continue;
					}
					if (mGameCode2 == 32)
					{
						if (174026 - 290181 == -116154)
						{
							continue;
						}
						this.vpEcCKjSAwn = 972;
						if (137344 - 538305 != -400961)
						{
							continue;
						}
					}
					else if (mGameCode2 == 34)
					{
						if (175369 - 289205 != -113836)
						{
							continue;
						}
						this.vpEcCKjSAwn = 971;
						if (138822 - 496872 != -358050)
						{
							continue;
						}
					}
					else if (mGameCode2 == 33)
					{
						if (191989 - 236549 != -44560)
						{
							continue;
						}
						this.vpEcCKjSAwn = 973;
						if (228804 - 467866 == -239061)
						{
							continue;
						}
					}
					else if (mGameCode2 == 35)
					{
						if (268314 - 522574 != -254260)
						{
							continue;
						}
						this.vpEcCKjSAwn = 974;
						if (168291 - 515513 != -347222)
						{
							continue;
						}
					}
					this.l20cCzKUHlN = 0;
					if (73034 - 262051 != -189017)
					{
						continue;
					}
				}
				this.ST5cM6mrbBP = 0;
				if (36706 - 422768 != -386061)
				{
					this.NQ8cfC229OA = 1f;
					if (186721 - 50222 == 136499)
					{
						this.jNGcfMbha5l = (float)0;
						if (235362 - 583479 == -348117)
						{
							this.a4BcMl1gP4S = string.Empty;
							if (17882 - 286429 == -268547)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006231 RID: 25137 RVA: 0x00D84218 File Offset: 0x00D82418
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderMissionMenu()
	{
		if (195523 - 54609 != 140914)
		{
		}
		for (;;)
		{
			IL_47B8:
			float num = Time.time - this.L4rcCAGc8mu;
			if (85329 - 96091 == -10762)
			{
				if (280448 - 81648 != 198801)
				{
					MissionClass data = MissionData.getData(this.vpEcCKjSAwn);
					if (44226 - 179976 == -135750)
					{
						eMissionState heGcCkg9Cyt = this.HeGcCkg9Cyt;
						if (62977 - 592952 == -529975)
						{
							if (heGcCkg9Cyt == eMissionState.open)
							{
								if (73231 - 543209 == -469978)
								{
									if (num <= 0.5f)
									{
										if (86829 - 360431 == -273602)
										{
											this.NQ8cfC229OA = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
											if (139046 - 598072 != -459025)
											{
												this.RenderNPC();
												if (211587 - 590380 != -378792)
												{
													GUI.DrawTexture(new Rect(0.5f * this.T45cCyVhtgd - (float)336, (float)724 + this.NQ8cfC229OA * (float)300, (float)836, (float)196), this.odScfm5CIwr);
													if (7820 - 456970 != -449149)
													{
														break;
													}
												}
											}
										}
									}
									else if (num <= (float)4)
									{
										if (146539 - 60774 != 85766)
										{
											this.NQ8cfC229OA = (float)0;
											if (60661 - 111135 != -50473)
											{
												this.RenderNPC();
												if (94085 - 295259 != -201173)
												{
													this.playGreetingAudio();
													if (213843 - 405024 != -191180)
													{
														GUI.BeginGroup(new Rect(0.5f * this.T45cCyVhtgd - (float)350, (float)724, (float)850, (float)200));
														if (248549 - 424637 != -176087)
														{
															GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.odScfm5CIwr);
															if (86828 - 218025 != -131196)
															{
																eMissionGuiType eMissionGuiType = this.mType;
																if (148222 - 575797 == -427575)
																{
																	if (eMissionGuiType == eMissionGuiType.guild)
																	{
																		if (291829 - 215455 != 76374)
																		{
																			continue;
																		}
																		GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Red Panda", this.U5ecfjlQCnv);
																		if (248404 - 43550 != 204854)
																		{
																			continue;
																		}
																	}
																	else if (eMissionGuiType == eMissionGuiType.town)
																	{
																		if (146273 - 245615 == -99341)
																		{
																			continue;
																		}
																		GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Skunk", this.U5ecfjlQCnv);
																		if (296146 - 34888 != 261258)
																		{
																			continue;
																		}
																	}
																	else if (eMissionGuiType == eMissionGuiType.arena)
																	{
																		if (280943 - 383524 == -102580)
																		{
																			continue;
																		}
																		GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Leopard", this.U5ecfjlQCnv);
																		if (97637 - 211007 != -113370)
																		{
																			continue;
																		}
																	}
																	else if (eMissionGuiType == eMissionGuiType.dungeon)
																	{
																		if (63294 - 560294 != -497000)
																		{
																			continue;
																		}
																		int mGameCode = Game.mGameCode;
																		if (139073 - 206132 != -67059)
																		{
																			continue;
																		}
																		if (mGameCode == 34)
																		{
																			if (73388 - 76357 != -2969)
																			{
																				continue;
																			}
																			GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Liza", this.U5ecfjlQCnv);
																			if (16929 - 114324 != -97395)
																			{
																				continue;
																			}
																		}
																		else if (mGameCode == 32)
																		{
																			if (201475 - 128875 != 72600)
																			{
																				continue;
																			}
																			GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Penne", this.U5ecfjlQCnv);
																			if (4463 - 453679 == -449215)
																			{
																				continue;
																			}
																		}
																		else if (mGameCode == 33)
																		{
																			if (176016 - 557050 == -381033)
																			{
																				continue;
																			}
																			GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Guibo", this.U5ecfjlQCnv);
																			if (55669 - 83894 != -28225)
																			{
																				continue;
																			}
																		}
																		else if (mGameCode == 35)
																		{
																			if (17883 - 100170 != -82287)
																			{
																				continue;
																			}
																			GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "GallonBot", this.U5ecfjlQCnv);
																			if (242490 - 499065 == -256574)
																			{
																				continue;
																			}
																		}
																	}
																	GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.oR2cfkegSEs, num - 0.5f), this.GAucfoKnRxs);
																	if (193712 - 30455 != 163258)
																	{
																		GUI.EndGroup();
																		if (250859 - 62565 == 188294)
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
										this.RenderNPC();
										if (238645 - 348785 == -110140)
										{
											this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
											if (48577 - 462661 != -414083)
											{
												this.aoRcffyBoam = -1;
												if (66681 - 334022 == -267341)
												{
													this.HeGcCkg9Cyt = eMissionState.selectQuest;
													if (115509 - 254134 != -138624)
													{
														this.L4rcCAGc8mu = Time.time;
														if (257141 - 121316 == 135825)
														{
															this.lS2cLcPvK4w = Time.time;
															if (159183 - 126726 != 32458)
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
							else if (heGcCkg9Cyt == eMissionState.selectQuest)
							{
								if (237465 - 595009 != -357543)
								{
									this.camera.rect = new Rect((float)0, (float)0, (this.T45cCyVhtgd - (float)900) / this.T45cCyVhtgd, (float)1);
									if (195746 - 272006 != -76259)
									{
										GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)1024, (float)0, (float)1024, (float)1024), this.zpCcM1sSJB3);
										if (124436 - 316736 != -192299)
										{
											GUI.BeginGroup(new Rect(this.T45cCyVhtgd - (float)1015, (float)0, (float)1015, (float)1024));
											if (231864 - 499562 == -267698)
											{
												eMissionGuiType eMissionGuiType2 = this.mType;
												if (110837 - 164838 != -54000)
												{
													if (eMissionGuiType2 == eMissionGuiType.guild)
													{
														if (140178 - 335931 != -195753)
														{
															continue;
														}
														this.RenderGuildMissionList(true);
														if (108971 - 510873 == -401901)
														{
															continue;
														}
													}
													else if (eMissionGuiType2 == eMissionGuiType.town)
													{
														if (65906 - 332294 != -266388)
														{
															continue;
														}
														this.RenderTownMissionList(true);
														if (184110 - 172683 != 11427)
														{
															continue;
														}
													}
													else if (eMissionGuiType2 == eMissionGuiType.arena)
													{
														if (220704 - 592364 != -371660)
														{
															continue;
														}
														this.RenderPVPArenaList(true);
														if (165255 - 370072 != -204817)
														{
															continue;
														}
													}
													else if (eMissionGuiType2 == eMissionGuiType.dungeon)
													{
														if (278408 - 160861 != 117547)
														{
															continue;
														}
														this.RenderDungeonList(true);
														if (7727 - 263727 != -256000)
														{
															continue;
														}
													}
													if (this.vpEcCKjSAwn != 0)
													{
														if (214147 - 264671 == -50523)
														{
															continue;
														}
														eMissionGuiType eMissionGuiType3 = this.mType;
														if (284237 - 411307 == -127069)
														{
															continue;
														}
														if (eMissionGuiType3 == eMissionGuiType.guild)
														{
															if (30540 - 331727 != -301187)
															{
																continue;
															}
															this.RenderRecordBar();
															if (156470 - 529468 != -372998)
															{
																continue;
															}
														}
														else if (eMissionGuiType3 == eMissionGuiType.town)
														{
															if (239153 - 233737 == 5417)
															{
																continue;
															}
															this.RenderTownRecordBar();
															if (219598 - 545924 != -326326)
															{
																continue;
															}
														}
														else if (eMissionGuiType3 == eMissionGuiType.arena)
														{
															if (107733 - 598779 == -491045)
															{
																continue;
															}
															this.RenderArenaRecordBar();
															if (297223 - 487910 == -190686)
															{
																continue;
															}
														}
														else if (eMissionGuiType3 == eMissionGuiType.dungeon)
														{
															if (88010 - 444456 != -356446)
															{
																continue;
															}
															this.RenderDungeonBar();
															if (67205 - 379124 == -311918)
															{
																continue;
															}
														}
														this.RenderMissionDes();
														if (43806 - 500781 == -456974)
														{
															continue;
														}
														GUI.Label(new Rect((float)585, (float)640, (float)200, (float)30), "private room", this.JhlcfvBBDH5);
														if (40314 - 26956 == 13359)
														{
															continue;
														}
														if (GUI.Button(new Rect((float)555, (float)646, (float)21, (float)22), string.Empty, this.Of4cf2GEvq1))
														{
															if (212138 - 375772 != -163634)
															{
																continue;
															}
															this.gDNcMOEi4v6 = !this.gDNcMOEi4v6;
															if (298188 - 284650 != 13538)
															{
																continue;
															}
															if (this.gDNcMOEi4v6)
															{
																if (239763 - 344670 == -104906)
																{
																	continue;
																}
																PlayerPrefs.SetInt("privateRoom", 1);
																if (114499 - 238117 == -123617)
																{
																	continue;
																}
															}
															else
															{
																PlayerPrefs.SetInt("privateRoom", 0);
																if (33894 - 508597 != -474703)
																{
																	continue;
																}
															}
															if (this.tDRcfUqyCxE)
															{
																if (125089 - 49101 == 75989)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.tDRcfUqyCxE);
																if (98050 - 475186 != -377136)
																{
																	continue;
																}
															}
														}
														if (this.gDNcMOEi4v6)
														{
															if (61521 - 143574 == -82052)
															{
																continue;
															}
															GUI.DrawTexture(new Rect((float)557, (float)648, (float)16, (float)16), this.icZcfOjPP65);
															if (197555 - 225523 == -27967)
															{
																continue;
															}
														}
														eMissionType type = data.type;
														if (296110 - 565195 != -269084)
														{
															if (type == eMissionType.story)
															{
																if (81897 - 474970 == -393072)
																{
																	continue;
																}
															}
															else if (type == eMissionType.pvp)
															{
																if (150749 - 492356 == -341606)
																{
																	continue;
																}
															}
															else if (type == eMissionType.arena)
															{
																if (32151 - 315875 == -283723)
																{
																	continue;
																}
															}
															else if (type == eMissionType.@event)
															{
																if (64937 - 421671 != -356733)
																{
																	if (GUI.Button(new Rect((float)820, (float)640, (float)102, (float)36), string.Empty, this.aT6cfeAjuFQ))
																	{
																		if (185892 - 539096 != -353204)
																		{
																			continue;
																		}
																		if (data.slv > PlayerData.SLv)
																		{
																			if (126114 - 567227 == -441112)
																			{
																				continue;
																			}
																			Chat.SubmitChat("none", "Cannot join event: story level too low", eChatType.system, eChatMode.mission);
																			if (62573 - 409095 == -346521)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.hxLcMIbiaoH = new EnlistClass[data.player];
																			if (79868 - 211278 == -131409)
																			{
																				continue;
																			}
																			int i = 0;
																			if (173466 - 552730 != -379264)
																			{
																				continue;
																			}
																			while (i < data.player)
																			{
																				this.hxLcMIbiaoH[i] = new EnlistClass();
																				if (223771 - 58992 != 164779)
																				{
																					goto IL_47B8;
																				}
																				i++;
																				if (143440 - 207055 == -63614)
																				{
																					goto IL_47B8;
																				}
																			}
																			if (200932 - 545116 == -344183)
																			{
																				continue;
																			}
																			this.VtIcf7sOiho = 0;
																			if (17909 - 56171 == -38261)
																			{
																				continue;
																			}
																			this.useCharSlot(CharacterData.current.slot);
																			if (111349 - 46794 == 64556)
																			{
																				continue;
																			}
																			this.CreateMission(this.vpEcCKjSAwn);
																			if (120101 - 67425 != 52676)
																			{
																				continue;
																			}
																			this.HeGcCkg9Cyt = eMissionState.createQuest;
																			if (240544 - 187248 != 53296)
																			{
																				continue;
																			}
																			this.L4rcCAGc8mu = Time.time;
																			if (217223 - 246401 == -29177)
																			{
																				continue;
																			}
																			this.RWFcLOoCcpG = false;
																			if (151060 - 490888 == -339827)
																			{
																				continue;
																			}
																		}
																		this.audio.PlayOneShot(this.tDRcfUqyCxE);
																		if (24168 - 396702 != -372534)
																		{
																			continue;
																		}
																	}
																	goto IL_50A;
																}
																continue;
															}
															else if (type == eMissionType.special)
															{
																if (175924 - 295328 != -119404)
																{
																	continue;
																}
																if (PlayerData.Rank == 100)
																{
																	if (1557 - 255494 != -253937)
																	{
																		continue;
																	}
																	if (GUI.Button(new Rect((float)715, (float)640, (float)102, (float)36), string.Empty, this.aT6cfeAjuFQ))
																	{
																		if (193266 - 11123 == 182144)
																		{
																			continue;
																		}
																		if (PlayerData.Rank != 100)
																		{
																			if (285121 - 23105 == 262017)
																			{
																				continue;
																			}
																			Chat.SubmitChat("none", "Only GM can create this mission", eChatType.system, eChatMode.mission);
																			if (114291 - 596961 != -482670)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.hxLcMIbiaoH = new EnlistClass[data.player];
																			if (1647 - 213293 == -211645)
																			{
																				continue;
																			}
																			int i = 0;
																			if (77344 - 292927 == -215582)
																			{
																				continue;
																			}
																			while (i < data.player)
																			{
																				this.hxLcMIbiaoH[i] = new EnlistClass();
																				if (255955 - 358888 == -102932)
																				{
																					goto IL_47B8;
																				}
																				i++;
																				if (279886 - 242730 == 37157)
																				{
																					goto IL_47B8;
																				}
																			}
																			if (17331 - 188603 != -171272)
																			{
																				continue;
																			}
																			this.VtIcf7sOiho = 0;
																			if (274210 - 428458 != -154248)
																			{
																				continue;
																			}
																			this.useCharSlot(CharacterData.current.slot);
																			if (249736 - 480871 == -231134)
																			{
																				continue;
																			}
																			this.CreateMission(this.vpEcCKjSAwn);
																			if (279219 - 536319 == -257099)
																			{
																				continue;
																			}
																			this.HeGcCkg9Cyt = eMissionState.createQuest;
																			if (49392 - 526381 == -476988)
																			{
																				continue;
																			}
																			this.L4rcCAGc8mu = Time.time;
																			if (198412 - 418042 != -219630)
																			{
																				continue;
																			}
																			this.RWFcLOoCcpG = false;
																			if (64850 - 526178 != -461328)
																			{
																				continue;
																			}
																		}
																		this.audio.PlayOneShot(this.tDRcfUqyCxE);
																		if (243288 - 187431 != 55857)
																		{
																			continue;
																		}
																	}
																}
																if (GUI.Button(new Rect((float)825, (float)640, (float)96, (float)36), string.Empty, this.t23cfI0D2aP))
																{
																	if (103195 - 185470 != -82275)
																	{
																		continue;
																	}
																	if (data.slv <= PlayerData.SLv)
																	{
																		if (286852 - 501995 != -215143)
																		{
																			continue;
																		}
																		if (Mathf.Min(data.lv, 99) <= CharacterData.current.lv)
																		{
																			if (155591 - 186746 != -31155)
																			{
																				continue;
																			}
																			this.VtIcf7sOiho = 0;
																			if (237539 - 230325 != 7214)
																			{
																				continue;
																			}
																			this.JoinMission(this.vpEcCKjSAwn, this.l20cCzKUHlN);
																			if (271004 - 428198 == -157193)
																			{
																				continue;
																			}
																			this.HeGcCkg9Cyt = eMissionState.joinQuest;
																			if (245426 - 134348 != 111078)
																			{
																				continue;
																			}
																			this.L4rcCAGc8mu = Time.time;
																			if (150413 - 81279 == 69135)
																			{
																				continue;
																			}
																			this.RWFcLOoCcpG = false;
																			if (126820 - 144814 != -17994)
																			{
																				continue;
																			}
																			goto IL_8B22;
																		}
																	}
																	Chat.SubmitChat("none", "Cannot join mission: Character Level too low", eChatType.system, eChatMode.mission);
																	if (245992 - 299675 == -53682)
																	{
																		continue;
																	}
																	IL_8B22:
																	this.audio.PlayOneShot(this.tDRcfUqyCxE);
																	if (20726 - 336647 == -315920)
																	{
																		continue;
																	}
																}
																goto IL_50A;
															}
															else
															{
																if (type != eMissionType.close)
																{
																	goto IL_50A;
																}
																if (156002 - 546199 != -390196)
																{
																	goto IL_50A;
																}
																continue;
															}
															IL_4B5:
															if (this.V5wcCFOg9QT == eMissionSelectMode.mission)
															{
																if (19014 - 276717 != -257703)
																{
																	continue;
																}
																float num2;
																if (data.player > 1)
																{
																	if (260199 - 5121 != 255078)
																	{
																		continue;
																	}
																	num2 = (float)715;
																}
																else
																{
																	num2 = (float)820;
																}
																if (GUI.Button(new Rect(num2, (float)640, (float)102, (float)36), string.Empty, this.aT6cfeAjuFQ))
																{
																	if (132608 - 535379 != -402771)
																	{
																		continue;
																	}
																	bool flag = false;
																	if (545 - 126858 != -126313)
																	{
																		continue;
																	}
																	if (this.mType == eMissionGuiType.town)
																	{
																		if (55253 - 354153 != -298900)
																		{
																			continue;
																		}
																		if (!RuntimeServices.EqualityOperator(this.n6rcMQX4Xhl, null))
																		{
																			if (25251 - 20349 != 4902)
																			{
																				continue;
																			}
																			int j = 0;
																			if (77609 - 123371 == -45761)
																			{
																				continue;
																			}
																			MissionListClass[] array = this.n6rcMQX4Xhl;
																			if (237060 - 164546 == 72515)
																			{
																				continue;
																			}
																			int length = array.Length;
																			if (59592 - 404054 == -344461)
																			{
																				continue;
																			}
																			while (j < length)
																			{
																				if (array[j].roomCode == this.vpEcCKjSAwn)
																				{
																					if (289179 - 48448 == 240732)
																					{
																						goto IL_47B8;
																					}
																					if (array[j].roomTimer > Time.time)
																					{
																						if (266839 - 128707 != 138132)
																						{
																							goto IL_47B8;
																						}
																						flag = true;
																						if (164781 - 487267 == -322485)
																						{
																							goto IL_47B8;
																						}
																					}
																				}
																				j++;
																				if (284380 - 357721 != -73341)
																				{
																					goto IL_47B8;
																				}
																			}
																			if (60504 - 373639 == -313134)
																			{
																				continue;
																			}
																		}
																	}
																	else if (this.mType == eMissionGuiType.arena)
																	{
																		if (68919 - 9220 == 59700)
																		{
																			continue;
																		}
																		if (!RuntimeServices.EqualityOperator(this.HTmcMeto4Zx, null))
																		{
																			if (113940 - 93665 != 20275)
																			{
																				continue;
																			}
																			int k = 0;
																			if (67030 - 336433 == -269402)
																			{
																				continue;
																			}
																			MissionListClass[] htmcMeto4Zx = this.HTmcMeto4Zx;
																			if (90913 - 557531 == -466617)
																			{
																				continue;
																			}
																			int length2 = htmcMeto4Zx.Length;
																			if (42813 - 476639 == -433825)
																			{
																				continue;
																			}
																			while (k < length2)
																			{
																				if (htmcMeto4Zx[k].roomCode == this.vpEcCKjSAwn)
																				{
																					if (113851 - 584 == 113268)
																					{
																						goto IL_47B8;
																					}
																					if (htmcMeto4Zx[k].roomTimer > Time.time)
																					{
																						if (225804 - 357510 == -131705)
																						{
																							goto IL_47B8;
																						}
																						flag = true;
																						if (64318 - 322694 == -258375)
																						{
																							goto IL_47B8;
																						}
																					}
																				}
																				k++;
																				if (111255 - 294728 == -183472)
																				{
																					goto IL_47B8;
																				}
																			}
																			if (277041 - 120951 != 156090)
																			{
																				continue;
																			}
																		}
																	}
																	else
																	{
																		flag = true;
																		if (62391 - 366696 == -304304)
																		{
																			continue;
																		}
																	}
																	if (!flag)
																	{
																		if (30354 - 450845 == -420490)
																		{
																			continue;
																		}
																		Chat.SubmitChat("none", "Cannot create mission: mission has expire", eChatType.system, eChatMode.system);
																		if (76232 - 225521 != -149289)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (data.slv <= PlayerData.SLv)
																		{
																			if (28496 - 117360 == -88863)
																			{
																				continue;
																			}
																			if (Mathf.Min(data.lv, 99) > CharacterData.current.lv)
																			{
																				if (234617 - 208848 != 25769)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				if (this.vpEcCKjSAwn == 971)
																				{
																					if (102576 - 373034 == -270457)
																					{
																						continue;
																					}
																					if (CharacterData.current.getItemTotalNum("k_dun1") < 1)
																					{
																						if (201517 - 443707 == -242189)
																						{
																							continue;
																						}
																						Chat.SubmitChat("none", "Cannot create mission: Required Cursed Fragment", eChatType.system, eChatMode.system);
																						if (102334 - 179340 != -77005)
																						{
																							goto IL_3C0B;
																						}
																						continue;
																					}
																				}
																				if (this.vpEcCKjSAwn == 972)
																				{
																					if (103416 - 355069 == -251652)
																					{
																						continue;
																					}
																					if (CharacterData.current.getItemTotalNum("k_dun2") < 1)
																					{
																						if (194094 - 250 != 193844)
																						{
																							continue;
																						}
																						Chat.SubmitChat("none", "Cannot create mission: Required Ice Shabu-Shabu", eChatType.system, eChatMode.system);
																						if (252258 - 279435 != -27176)
																						{
																							goto IL_3C0B;
																						}
																						continue;
																					}
																				}
																				if (this.vpEcCKjSAwn == 973)
																				{
																					if (66480 - 588561 != -522081)
																					{
																						continue;
																					}
																					if (CharacterData.current.getItemTotalNum("k_dun3") < 1)
																					{
																						if (126740 - 307199 == -180458)
																						{
																							continue;
																						}
																						Chat.SubmitChat("none", "Cannot create mission: Required Deluxe Plate", eChatType.system, eChatMode.system);
																						if (247975 - 320019 != -72044)
																						{
																							continue;
																						}
																						goto IL_3C0B;
																					}
																				}
																				if (this.vpEcCKjSAwn == 974)
																				{
																					if (128782 - 244931 != -116149)
																					{
																						continue;
																					}
																					if (CharacterData.current.getItemTotalNum("k_dun6") < 1)
																					{
																						if (224514 - 589946 != -365432)
																						{
																							continue;
																						}
																						Chat.SubmitChat("none", "Cannot create mission: Required Demonic Coin", eChatType.system, eChatMode.system);
																						if (68237 - 125670 != -57433)
																						{
																							continue;
																						}
																						goto IL_3C0B;
																					}
																				}
																				this.hxLcMIbiaoH = new EnlistClass[data.player];
																				if (263526 - 36601 == 226926)
																				{
																					continue;
																				}
																				int i = 0;
																				if (292625 - 56464 != 236161)
																				{
																					continue;
																				}
																				while (i < data.player)
																				{
																					this.hxLcMIbiaoH[i] = new EnlistClass();
																					if (211000 - 549999 != -338999)
																					{
																						goto IL_47B8;
																					}
																					i++;
																					if (47042 - 571220 == -524177)
																					{
																						goto IL_47B8;
																					}
																				}
																				if (298066 - 569670 == -271603)
																				{
																					continue;
																				}
																				this.VtIcf7sOiho = 0;
																				if (31209 - 98190 != -66981)
																				{
																					continue;
																				}
																				this.useCharSlot(CharacterData.current.slot);
																				if (31141 - 35013 != -3872)
																				{
																					continue;
																				}
																				this.CreateMission(this.vpEcCKjSAwn);
																				if (117194 - 545021 == -427826)
																				{
																					continue;
																				}
																				this.HeGcCkg9Cyt = eMissionState.createQuest;
																				if (141708 - 39534 == 102175)
																				{
																					continue;
																				}
																				this.L4rcCAGc8mu = Time.time;
																				if (11330 - 48616 != -37286)
																				{
																					continue;
																				}
																				this.RWFcLOoCcpG = false;
																				if (233607 - 348208 != -114601)
																				{
																					continue;
																				}
																				goto IL_3C0B;
																			}
																		}
																		Chat.SubmitChat("none", "Cannot create mission: Character Level too low", eChatType.system, eChatMode.system);
																		if (186524 - 596265 != -409741)
																		{
																			continue;
																		}
																	}
																	IL_3C0B:
																	this.audio.PlayOneShot(this.tDRcfUqyCxE);
																	if (10334 - 28726 == -18391)
																	{
																		continue;
																	}
																}
																if (data.player > 1)
																{
																	if (234224 - 158359 == 75866)
																	{
																		continue;
																	}
																	if (GUI.Button(new Rect((float)825, (float)640, (float)96, (float)36), string.Empty, this.t23cfI0D2aP))
																	{
																		if (94107 - 261288 == -167180)
																		{
																			continue;
																		}
																		bool flag2 = false;
																		if (298779 - 522721 != -223942)
																		{
																			continue;
																		}
																		if (this.mType == eMissionGuiType.town)
																		{
																			if (134344 - 93456 == 40889)
																			{
																				continue;
																			}
																			if (!RuntimeServices.EqualityOperator(this.n6rcMQX4Xhl, null))
																			{
																				if (213205 - 509725 != -296520)
																				{
																					continue;
																				}
																				int l = 0;
																				if (117090 - 400037 == -282946)
																				{
																					continue;
																				}
																				MissionListClass[] array2 = this.n6rcMQX4Xhl;
																				if (279996 - 514679 != -234683)
																				{
																					continue;
																				}
																				int length3 = array2.Length;
																				if (64328 - 396730 == -332401)
																				{
																					continue;
																				}
																				while (l < length3)
																				{
																					if (array2[l].roomCode == this.vpEcCKjSAwn)
																					{
																						if (239458 - 517580 != -278122)
																						{
																							goto IL_47B8;
																						}
																						if (array2[l].roomTimer > Time.time)
																						{
																							if (213374 - 484535 == -271160)
																							{
																								goto IL_47B8;
																							}
																							flag2 = true;
																							if (102599 - 155549 != -52950)
																							{
																								goto IL_47B8;
																							}
																						}
																					}
																					l++;
																					if (27278 - 96512 == -69233)
																					{
																						goto IL_47B8;
																					}
																				}
																				if (188859 - 334346 != -145487)
																				{
																					continue;
																				}
																			}
																		}
																		else if (this.mType == eMissionGuiType.arena)
																		{
																			if (84104 - 410451 != -326347)
																			{
																				continue;
																			}
																			if (!RuntimeServices.EqualityOperator(this.HTmcMeto4Zx, null))
																			{
																				if (173121 - 570120 == -396998)
																				{
																					continue;
																				}
																				int m = 0;
																				if (218402 - 598120 == -379717)
																				{
																					continue;
																				}
																				MissionListClass[] htmcMeto4Zx2 = this.HTmcMeto4Zx;
																				if (220413 - 569989 == -349575)
																				{
																					continue;
																				}
																				int length4 = htmcMeto4Zx2.Length;
																				if (291806 - 573496 != -281690)
																				{
																					continue;
																				}
																				while (m < length4)
																				{
																					if (htmcMeto4Zx2[m].roomCode == this.vpEcCKjSAwn)
																					{
																						if (222813 - 202776 != 20037)
																						{
																							goto IL_47B8;
																						}
																						if (htmcMeto4Zx2[m].roomTimer > Time.time)
																						{
																							if (128145 - 452983 == -324837)
																							{
																								goto IL_47B8;
																							}
																							flag2 = true;
																							if (246981 - 265170 != -18189)
																							{
																								goto IL_47B8;
																							}
																						}
																					}
																					m++;
																					if (32186 - 466307 != -434121)
																					{
																						goto IL_47B8;
																					}
																				}
																				if (123273 - 469921 != -346648)
																				{
																					continue;
																				}
																			}
																		}
																		else
																		{
																			flag2 = true;
																			if (61513 - 505854 != -444341)
																			{
																				continue;
																			}
																		}
																		if (!flag2)
																		{
																			if (9470 - 495031 != -485561)
																			{
																				continue;
																			}
																			Chat.SubmitChat("none", "Cannot create mission: mission has expire", eChatType.system, eChatMode.system);
																			if (40586 - 330902 != -290316)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (data.slv <= PlayerData.SLv)
																			{
																				if (106233 - 245603 != -139370)
																				{
																					continue;
																				}
																				if (Mathf.Min(data.lv, 99) > CharacterData.current.lv)
																				{
																					if (134542 - 39971 != 94571)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					if (this.vpEcCKjSAwn == 971)
																					{
																						if (164457 - 581142 != -416685)
																						{
																							continue;
																						}
																						if (CharacterData.current.getItemTotalNum("k_dun1") < 1)
																						{
																							if (154386 - 445420 != -291034)
																							{
																								continue;
																							}
																							Chat.SubmitChat("none", "Cannot join mission: Required Cursed Fragment", eChatType.system, eChatMode.system);
																							if (65996 - 173957 != -107961)
																							{
																								continue;
																							}
																							goto IL_45FF;
																						}
																					}
																					if (this.vpEcCKjSAwn == 972)
																					{
																						if (263966 - 188525 != 75441)
																						{
																							continue;
																						}
																						if (CharacterData.current.getItemTotalNum("k_dun2") < 1)
																						{
																							if (72262 - 524372 != -452110)
																							{
																								continue;
																							}
																							Chat.SubmitChat("none", "Cannot join mission: Required Ice Shabu-Shabu", eChatType.system, eChatMode.system);
																							if (178356 - 573410 != -395054)
																							{
																								continue;
																							}
																							goto IL_45FF;
																						}
																					}
																					if (this.vpEcCKjSAwn == 973)
																					{
																						if (224900 - 420009 != -195109)
																						{
																							continue;
																						}
																						if (CharacterData.current.getItemTotalNum("k_dun3") < 1)
																						{
																							if (4526 - 556993 == -552466)
																							{
																								continue;
																							}
																							Chat.SubmitChat("none", "Cannot join mission: Required Delux Plate", eChatType.system, eChatMode.system);
																							if (73205 - 514129 != -440924)
																							{
																								continue;
																							}
																							goto IL_45FF;
																						}
																					}
																					if (this.vpEcCKjSAwn == 974)
																					{
																						if (88538 - 424726 == -336187)
																						{
																							continue;
																						}
																						if (CharacterData.current.getItemTotalNum("k_dun6") < 1)
																						{
																							if (193953 - 308770 != -114817)
																							{
																								continue;
																							}
																							Chat.SubmitChat("none", "Cannot join mission: Required Demonic Coin", eChatType.system, eChatMode.system);
																							if (1348 - 395733 != -394385)
																							{
																								continue;
																							}
																							goto IL_45FF;
																						}
																					}
																					this.VtIcf7sOiho = 0;
																					if (81588 - 265068 != -183480)
																					{
																						continue;
																					}
																					this.JoinMission(this.vpEcCKjSAwn, 0);
																					if (129407 - 488359 == -358951)
																					{
																						continue;
																					}
																					this.HeGcCkg9Cyt = eMissionState.joinQuest;
																					if (185253 - 363459 == -178205)
																					{
																						continue;
																					}
																					this.L4rcCAGc8mu = Time.time;
																					if (248957 - 533158 != -284201)
																					{
																						continue;
																					}
																					this.RWFcLOoCcpG = false;
																					if (237623 - 346121 != -108498)
																					{
																						continue;
																					}
																					goto IL_45FF;
																				}
																			}
																			Chat.SubmitChat("none", "Cannot join mission: Character Level too low", eChatType.system, eChatMode.system);
																			if (219104 - 419107 == -200002)
																			{
																				continue;
																			}
																		}
																		IL_45FF:
																		this.audio.PlayOneShot(this.tDRcfUqyCxE);
																		if (28545 - 596594 != -568049)
																		{
																			continue;
																		}
																	}
																}
															}
															else if (data.player > 1)
															{
																if (82289 - 302677 == -220387)
																{
																	continue;
																}
																if (GUI.Button(new Rect((float)825, (float)640, (float)96, (float)36), string.Empty, this.t23cfI0D2aP))
																{
																	if (22860 - 354776 == -331915)
																	{
																		continue;
																	}
																	if (data.slv <= PlayerData.SLv)
																	{
																		if (229853 - 509720 == -279866)
																		{
																			continue;
																		}
																		if (Mathf.Min(data.lv, 99) > CharacterData.current.lv)
																		{
																			if (170338 - 273702 != -103364)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (this.vpEcCKjSAwn == 971)
																			{
																				if (70156 - 63101 != 7055)
																				{
																					continue;
																				}
																				if (CharacterData.current.getItemTotalNum("k_dun1") < 1)
																				{
																					if (220655 - 245764 == -25108)
																					{
																						continue;
																					}
																					Chat.SubmitChat("none", "Cannot join mission: Required Cursed Fragment", eChatType.system, eChatMode.system);
																					if (290818 - 42241 != 248578)
																					{
																						goto IL_1DFB;
																					}
																					continue;
																				}
																			}
																			if (this.vpEcCKjSAwn == 972)
																			{
																				if (236494 - 227092 != 9402)
																				{
																					continue;
																				}
																				if (CharacterData.current.getItemTotalNum("k_dun2") < 1)
																				{
																					if (151062 - 116996 == 34067)
																					{
																						continue;
																					}
																					Chat.SubmitChat("none", "Cannot join mission: Required Ice Shabu-Shabu", eChatType.system, eChatMode.system);
																					if (64936 - 579083 != -514146)
																					{
																						goto IL_1DFB;
																					}
																					continue;
																				}
																			}
																			if (this.vpEcCKjSAwn == 973)
																			{
																				if (251807 - 406485 != -154678)
																				{
																					continue;
																				}
																				if (CharacterData.current.getItemTotalNum("k_dun3") < 1)
																				{
																					if (2001 - 504233 != -502232)
																					{
																						continue;
																					}
																					Chat.SubmitChat("none", "Cannot join mission: Required Deluxe Plate", eChatType.system, eChatMode.system);
																					if (104872 - 564153 != -459280)
																					{
																						goto IL_1DFB;
																					}
																					continue;
																				}
																			}
																			if (this.vpEcCKjSAwn == 974)
																			{
																				if (248020 - 236210 == 11811)
																				{
																					continue;
																				}
																				if (CharacterData.current.getItemTotalNum("k_dun6") < 1)
																				{
																					if (149176 - 324924 == -175747)
																					{
																						continue;
																					}
																					Chat.SubmitChat("none", "Cannot join mission: Required Demonic Coin", eChatType.system, eChatMode.system);
																					if (226023 - 522027 != -296004)
																					{
																						continue;
																					}
																					goto IL_1DFB;
																				}
																			}
																			this.VtIcf7sOiho = 0;
																			if (13472 - 127402 == -113929)
																			{
																				continue;
																			}
																			this.JoinMission(this.vpEcCKjSAwn, this.l20cCzKUHlN);
																			if (101286 - 387849 == -286562)
																			{
																				continue;
																			}
																			this.HeGcCkg9Cyt = eMissionState.joinQuest;
																			if (67753 - 70027 == -2273)
																			{
																				continue;
																			}
																			this.L4rcCAGc8mu = Time.time;
																			if (295153 - 174683 == 120471)
																			{
																				continue;
																			}
																			this.RWFcLOoCcpG = false;
																			if (3688 - 45410 != -41721)
																			{
																				goto IL_1DFB;
																			}
																			continue;
																		}
																	}
																	Chat.SubmitChat("none", "Cannot join mission: Character Level too low", eChatType.system, eChatMode.system);
																	if (270963 - 375831 == -104867)
																	{
																		continue;
																	}
																	IL_1DFB:
																	this.audio.PlayOneShot(this.tDRcfUqyCxE);
																	if (31145 - 130378 == -99232)
																	{
																		continue;
																	}
																}
															}
															goto IL_50A;
															goto IL_4B5;
														}
														continue;
													}
													IL_50A:
													if (GUI.Button(new Rect((float)153, (float)-1, (float)57, (float)52), string.Empty, this.e1DcfQ3ex3l))
													{
														if (292386 - 315982 == -23595)
														{
															continue;
														}
														if (this.aoRcffyBoam == -1)
														{
															if (248282 - 107253 == 141030)
															{
																continue;
															}
															this.HeGcCkg9Cyt = eMissionState.close;
															if (112371 - 291572 == -179200)
															{
																continue;
															}
															this.L4rcCAGc8mu = Time.time;
															if (112804 - 78331 == 34474)
															{
																continue;
															}
															this.aoRcffyBoam = -1;
															if (103146 - 105252 == -2105)
															{
																continue;
															}
															if (this.MHYcfw23xt3)
															{
																if (161920 - 581038 == -419117)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.MHYcfw23xt3);
																if (263467 - 25344 != 238123)
																{
																	continue;
																}
															}
															this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
															if (207714 - 469752 != -262038)
															{
																continue;
															}
														}
													}
													GUI.EndGroup();
													if (138910 - 134326 != 4585)
													{
														this.RenderChatBar();
														if (292429 - 462692 == -170263)
														{
															this.RenderNPC();
															if (283160 - 212314 != 70847)
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
							else if (heGcCkg9Cyt == eMissionState.createQuest)
							{
								if (15003 - 576648 == -561645)
								{
									GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)1024, (float)0, (float)1024, (float)1024), this.zpCcM1sSJB3);
									if (45143 - 151443 != -106299)
									{
										GUI.BeginGroup(new Rect(this.T45cCyVhtgd - (float)1015, (float)0, (float)1015, (float)1024));
										if (218214 - 415090 == -196876)
										{
											eMissionGuiType eMissionGuiType4 = this.mType;
											if (39500 - 129565 != -90064)
											{
												if (eMissionGuiType4 == eMissionGuiType.guild)
												{
													if (124831 - 534019 == -409187)
													{
														continue;
													}
													this.RenderGuildMissionList(false);
													if (51302 - 259691 != -208389)
													{
														continue;
													}
													this.RenderRecordBar();
													if (168961 - 304454 == -135492)
													{
														continue;
													}
												}
												else if (eMissionGuiType4 == eMissionGuiType.town)
												{
													if (147091 - 366552 != -219461)
													{
														continue;
													}
													this.RenderTownMissionList(false);
													if (212765 - 556106 == -343340)
													{
														continue;
													}
													this.RenderTownRecordBar();
													if (175868 - 206742 == -30873)
													{
														continue;
													}
												}
												else if (eMissionGuiType4 == eMissionGuiType.arena)
												{
													if (112558 - 260172 != -147614)
													{
														continue;
													}
													this.RenderPVPArenaList(false);
													if (68685 - 148669 != -79984)
													{
														continue;
													}
													this.RenderArenaRecordBar();
													if (179297 - 154637 == 24661)
													{
														continue;
													}
												}
												else if (eMissionGuiType4 == eMissionGuiType.dungeon)
												{
													if (278656 - 272166 == 6491)
													{
														continue;
													}
													this.RenderDungeonList(false);
													if (54935 - 336669 != -281734)
													{
														continue;
													}
													this.RenderDungeonBar();
													if (226791 - 544472 == -317680)
													{
														continue;
													}
												}
												this.RenderMissionDes();
												if (131895 - 325329 != -193433)
												{
													GUI.EndGroup();
													if (52344 - 138382 != -86037)
													{
														this.RenderChatBar();
														if (238140 - 413050 == -174910)
														{
															if (data.type != eMissionType.arena)
															{
																if (34240 - 230750 != -196510)
																{
																	continue;
																}
																this.RenderNoticeBar("Creating new room...");
																if (219531 - 58968 == 160564)
																{
																	continue;
																}
															}
															else
															{
																this.RenderNoticeBar("Creating new team...");
																if (235485 - 507099 != -271614)
																{
																	continue;
																}
															}
															this.RenderNPC();
															if (54684 - 267525 == -212841)
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
							else if (heGcCkg9Cyt == eMissionState.joinQuest)
							{
								if (239240 - 418301 != -179060)
								{
									GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)1024, (float)0, (float)1024, (float)1024), this.zpCcM1sSJB3);
									if (147835 - 311031 == -163196)
									{
										GUI.BeginGroup(new Rect(this.T45cCyVhtgd - (float)1015, (float)0, (float)1015, (float)1024));
										if (286002 - 419868 == -133866)
										{
											eMissionGuiType eMissionGuiType5 = this.mType;
											if (271452 - 229907 == 41545)
											{
												if (eMissionGuiType5 == eMissionGuiType.guild)
												{
													if (83242 - 448433 != -365191)
													{
														continue;
													}
													this.RenderGuildMissionList(false);
													if (239912 - 484432 == -244519)
													{
														continue;
													}
													this.RenderRecordBar();
													if (285306 - 568970 != -283664)
													{
														continue;
													}
												}
												else if (eMissionGuiType5 == eMissionGuiType.town)
												{
													if (274319 - 396309 != -121990)
													{
														continue;
													}
													this.RenderTownMissionList(false);
													if (188805 - 539050 == -350244)
													{
														continue;
													}
													this.RenderTownRecordBar();
													if (51765 - 238021 != -186256)
													{
														continue;
													}
												}
												else if (eMissionGuiType5 == eMissionGuiType.arena)
												{
													if (29086 - 203760 == -174673)
													{
														continue;
													}
													this.RenderPVPArenaList(false);
													if (176875 - 74266 == 102610)
													{
														continue;
													}
													this.RenderArenaRecordBar();
													if (262830 - 34991 != 227839)
													{
														continue;
													}
												}
												else if (eMissionGuiType5 == eMissionGuiType.dungeon)
												{
													if (266236 - 154434 == 111803)
													{
														continue;
													}
													this.RenderDungeonList(false);
													if (95870 - 121585 == -25714)
													{
														continue;
													}
													this.RenderDungeonBar();
													if (28445 - 119742 == -91296)
													{
														continue;
													}
												}
												this.RenderMissionDes();
												if (268778 - 481489 != -212710)
												{
													GUI.EndGroup();
													if (272118 - 503016 != -230897)
													{
														this.RenderChatBar();
														if (183514 - 524591 != -341076)
														{
															this.RenderNoticeBar("Searching for available spot...");
															if (49076 - 295895 == -246819)
															{
																this.RenderNPC();
																if (63844 - 56933 != 6912)
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
							else if (heGcCkg9Cyt == eMissionState.createTeam)
							{
								if (127509 - 305748 == -178239)
								{
									GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)1024, (float)0, (float)1024, (float)1024), this.zpCcM1sSJB3);
									if (198962 - 418581 == -219619)
									{
										GUI.BeginGroup(new Rect(this.T45cCyVhtgd - (float)1015, (float)0, (float)1015, (float)1024));
										if (44213 - 479623 == -435410)
										{
											eMissionGuiType eMissionGuiType6 = this.mType;
											if (74447 - 486477 == -412030)
											{
												if (eMissionGuiType6 == eMissionGuiType.guild)
												{
													if (247112 - 502098 == -254985)
													{
														continue;
													}
													this.RenderGuildMissionList(false);
													if (187923 - 315648 != -127725)
													{
														continue;
													}
													this.RenderRecordBar();
													if (287126 - 413162 != -126036)
													{
														continue;
													}
												}
												else if (eMissionGuiType6 == eMissionGuiType.town)
												{
													if (279957 - 13089 == 266869)
													{
														continue;
													}
													this.RenderTownMissionList(false);
													if (209105 - 262630 != -53525)
													{
														continue;
													}
													this.RenderTownRecordBar();
													if (76000 - 328726 != -252726)
													{
														continue;
													}
												}
												else if (eMissionGuiType6 == eMissionGuiType.arena)
												{
													if (194400 - 127496 != 66904)
													{
														continue;
													}
													this.RenderPVPArenaList(false);
													if (223725 - 2927 != 220798)
													{
														continue;
													}
													this.RenderArenaRecordBar();
													if (261157 - 107739 == 153419)
													{
														continue;
													}
												}
												else if (eMissionGuiType6 == eMissionGuiType.dungeon)
												{
													if (221858 - 424142 != -202284)
													{
														continue;
													}
													this.RenderDungeonList(false);
													if (39269 - 41691 == -2421)
													{
														continue;
													}
													this.RenderDungeonBar();
													if (229587 - 580786 == -351198)
													{
														continue;
													}
												}
												if (this.vpEcCKjSAwn != 0)
												{
													if (224858 - 105802 != 119056)
													{
														continue;
													}
													if (data.team + data.player > 6)
													{
														if (262365 - 244212 != 18153)
														{
															continue;
														}
														this.S4Mcf0yNvC4 = true;
														if (187188 - 200293 == -13104)
														{
															continue;
														}
													}
													else
													{
														this.S4Mcf0yNvC4 = false;
														if (198398 - 546297 != -347899)
														{
															continue;
														}
													}
													this.I22cf8FU5bh = Mathf.FloorToInt((float)(data.player / data.team)) + data.player % data.team;
													if (6540 - 474454 == -467913)
													{
														continue;
													}
													if (this.jRIcMpVcPPy)
													{
														if (235026 - 244275 != -9249)
														{
															continue;
														}
														if (!this.S4Mcf0yNvC4)
														{
															if (140772 - 454899 != -314127)
															{
																continue;
															}
															GUI.DrawTexture(new Rect((float)512, (float)60, (float)434, (float)285), this.jRIcMpVcPPy);
															if (86134 - 113030 == -26895)
															{
																continue;
															}
														}
													}
													int i = 0;
													if (241207 - 316939 == -75731)
													{
														continue;
													}
													while (i < data.team)
													{
														if (!this.S4Mcf0yNvC4)
														{
															if (54835 - 167533 == -112697)
															{
																goto IL_47B8;
															}
															if (data.team == 1)
															{
																if (284441 - 313398 == -28956)
																{
																	goto IL_47B8;
																}
																GUI.DrawTexture(new Rect((float)484, (float)(345 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.tXfcMbSmHvR);
																if (170954 - 401696 == -230741)
																{
																	goto IL_47B8;
																}
															}
															else
															{
																int num3 = i;
																if (279376 - 274196 != 5180)
																{
																	goto IL_47B8;
																}
																if (num3 == 0)
																{
																	if (65828 - 534112 != -468284)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)(345 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.DB0cMdG7Phx);
																	if (34754 - 164871 == -130116)
																	{
																		goto IL_47B8;
																	}
																}
																else if (num3 == 1)
																{
																	if (100227 - 24490 != 75737)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)(345 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.GulcMgHWJeM);
																	if (89794 - 76026 != 13768)
																	{
																		goto IL_47B8;
																	}
																}
																else if (num3 == 2)
																{
																	if (124852 - 506642 != -381790)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)(345 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.rPgcMaLylWk);
																	if (67876 - 4051 == 63826)
																	{
																		goto IL_47B8;
																	}
																}
																else if (num3 == 3)
																{
																	if (169445 - 579909 != -410464)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)(345 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.OctcM4i9gTI);
																	if (256290 - 575956 == -319665)
																	{
																		goto IL_47B8;
																	}
																}
																else if (num3 == 4)
																{
																	if (146337 - 137346 == 8992)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)(345 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.YiAcMsNnfR3);
																	if (264106 - 234320 == 29787)
																	{
																		goto IL_47B8;
																	}
																}
															}
														}
														else if (data.team == 1)
														{
															if (202896 - 422927 != -220031)
															{
																goto IL_47B8;
															}
															GUI.DrawTexture(new Rect((float)484, (float)(80 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.tXfcMbSmHvR);
															if (171263 - 88222 == 83042)
															{
																goto IL_47B8;
															}
														}
														else
														{
															int num4 = i;
															if (119481 - 522864 == -403382)
															{
																goto IL_47B8;
															}
															if (num4 == 0)
															{
																if (59589 - 598599 != -539010)
																{
																	goto IL_47B8;
																}
																GUI.DrawTexture(new Rect((float)484, (float)(80 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.DB0cMdG7Phx);
																if (275675 - 44082 != 231593)
																{
																	goto IL_47B8;
																}
															}
															else if (num4 == 1)
															{
																if (95418 - 175944 != -80526)
																{
																	goto IL_47B8;
																}
																GUI.DrawTexture(new Rect((float)484, (float)(80 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.GulcMgHWJeM);
																if (130817 - 216473 == -85655)
																{
																	goto IL_47B8;
																}
															}
															else if (num4 == 2)
															{
																if (2997 - 229295 != -226298)
																{
																	goto IL_47B8;
																}
																GUI.DrawTexture(new Rect((float)484, (float)(80 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.rPgcMaLylWk);
																if (202972 - 510389 != -307417)
																{
																	goto IL_47B8;
																}
															}
															else if (num4 == 3)
															{
																if (19570 - 68859 == -49288)
																{
																	goto IL_47B8;
																}
																GUI.DrawTexture(new Rect((float)484, (float)(80 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.OctcM4i9gTI);
																if (160751 - 2883 != 157868)
																{
																	goto IL_47B8;
																}
															}
															else if (num4 == 4)
															{
																if (21269 - 597418 == -576148)
																{
																	goto IL_47B8;
																}
																GUI.DrawTexture(new Rect((float)484, (float)(80 + i * 55 + i * 45 * this.I22cf8FU5bh), (float)421, (float)50), this.YiAcMsNnfR3);
																if (10222 - 96947 == -86724)
																{
																	goto IL_47B8;
																}
															}
														}
														i++;
														if (87521 - 324924 != -237403)
														{
															goto IL_47B8;
														}
													}
													if (185886 - 412194 == -226307)
													{
														continue;
													}
													bool flag3 = false;
													if (78012 - 93748 == -15735)
													{
														continue;
													}
													i = 0;
													if (30758 - 470448 == -439689)
													{
														continue;
													}
													while (i < data.player)
													{
														this.zRZcfPiLvJi = i % data.team;
														if (116701 - 304462 == -187760)
														{
															goto IL_47B8;
														}
														this.xBZcfSA08TD = Mathf.FloorToInt((float)(i / data.team));
														if (225715 - 35512 != 190203)
														{
															goto IL_47B8;
														}
														if (!this.S4Mcf0yNvC4)
														{
															if (93421 - 253674 != -160253)
															{
																goto IL_47B8;
															}
															this.uyTcfBAnraB = 395 + 45 * this.xBZcfSA08TD + 55 * this.zRZcfPiLvJi + 45 * this.zRZcfPiLvJi * this.I22cf8FU5bh;
															if (7630 - 328032 == -320401)
															{
																goto IL_47B8;
															}
														}
														else
														{
															this.uyTcfBAnraB = 130 + 45 * this.xBZcfSA08TD + 55 * this.zRZcfPiLvJi + 45 * this.zRZcfPiLvJi * this.I22cf8FU5bh;
															if (202141 - 443726 == -241584)
															{
																goto IL_47B8;
															}
														}
														if (this.aoRcffyBoam != -1)
														{
															goto IL_21D3;
														}
														if (286549 - 407545 != -120996)
														{
															goto IL_47B8;
														}
														if (this.N6Hcf4ZG2YW != -1)
														{
															if (128966 - 429174 != -300208)
															{
																goto IL_47B8;
															}
															if (i <= this.N6Hcf4ZG2YW + 2)
															{
																goto IL_21D3;
															}
															if (244014 - 503071 == -259056)
															{
																goto IL_47B8;
															}
														}
														eIconButtonState eIconButtonState = IconButton.IconButton(this.TrRcfiTWco2[i], new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41));
														if (221073 - 380551 != -159478)
														{
															goto IL_47B8;
														}
														eIconButtonState eIconButtonState2 = eIconButtonState;
														if (71479 - 416557 == -345077)
														{
															goto IL_47B8;
														}
														if (eIconButtonState2 == eIconButtonState.none)
														{
															if (228790 - 14619 != 214171)
															{
																goto IL_47B8;
															}
															GUI.Label(new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41), "  " + this.hxLcMIbiaoH[i].playerName, this.LavcfGMel9m);
															if (274044 - 573012 == -298967)
															{
																goto IL_47B8;
															}
														}
														else
														{
															if (eIconButtonState2 == eIconButtonState.over)
															{
																if (4713 - 82292 == -77578)
																{
																	goto IL_47B8;
																}
															}
															else if (eIconButtonState2 == eIconButtonState.hover)
															{
																if (61335 - 68986 == -7650)
																{
																	goto IL_47B8;
																}
															}
															else if (eIconButtonState2 == eIconButtonState.press)
															{
																if (225780 - 42966 == 182815)
																{
																	goto IL_47B8;
																}
																this.TrRcfiTWco2[i].state = eIconButtonState.none;
																if (81117 - 490717 != -409600)
																{
																	goto IL_47B8;
																}
																GUI.DrawTexture(new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41), this.LavcfGMel9m.hover.background);
																if (49567 - 405875 == -356307)
																{
																	goto IL_47B8;
																}
																GUI.Label(new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41), "  " + this.hxLcMIbiaoH[i].playerName, this.DW8cflw6LAd);
																if (263083 - 403103 != -140020)
																{
																	goto IL_47B8;
																}
																if (i == this.N6Hcf4ZG2YW)
																{
																	if (240080 - 505997 == -265916)
																	{
																		goto IL_47B8;
																	}
																	this.N6Hcf4ZG2YW = -1;
																	if (114938 - 217969 != -103031)
																	{
																		goto IL_47B8;
																	}
																}
																else
																{
																	this.N6Hcf4ZG2YW = i;
																	if (101511 - 338993 != -237482)
																	{
																		goto IL_47B8;
																	}
																	flag3 = true;
																	if (181926 - 116444 != 65482)
																	{
																		goto IL_47B8;
																	}
																	this.audio.PlayOneShot(this.Ph6cfL8crLa);
																	if (266394 - 331138 != -64744)
																	{
																		goto IL_47B8;
																	}
																}
																goto IL_21CE;
															}
															else if (eIconButtonState2 == eIconButtonState.drag)
															{
																if (117884 - 38009 != 79875)
																{
																	goto IL_47B8;
																}
																this.TrRcfiTWco2[i].state = eIconButtonState.none;
																if (39998 - 315841 != -275843)
																{
																	goto IL_47B8;
																}
																this.t4jcfsesB5S = i;
																if (9657 - 93355 == -83697)
																{
																	goto IL_47B8;
																}
																this.N6Hcf4ZG2YW = -1;
																if (95517 - 426975 != -331458)
																{
																	goto IL_47B8;
																}
																goto IL_21CE;
															}
															else
															{
																if (eIconButtonState2 != eIconButtonState.drop)
																{
																	goto IL_21CE;
																}
																if (279416 - 409653 == -130236)
																{
																	goto IL_47B8;
																}
																this.TrRcfiTWco2[i].state = eIconButtonState.none;
																if (275010 - 297401 != -22390)
																{
																	if (this.t4jcfsesB5S != -1)
																	{
																		if (129632 - 554769 != -425137)
																		{
																			goto IL_47B8;
																		}
																		if (i == 0)
																		{
																			goto IL_38E5;
																		}
																		if (34821 - 314405 != -279584)
																		{
																			goto IL_47B8;
																		}
																		if (this.t4jcfsesB5S == 0)
																		{
																			if (276377 - 154475 != 121902)
																			{
																				goto IL_47B8;
																			}
																			goto IL_38E5;
																		}
																		else
																		{
																			this.swapPlayer(i, this.t4jcfsesB5S);
																			if (152497 - 72843 == 79655)
																			{
																				goto IL_47B8;
																			}
																			this.UpdateMission(2, i, this.t4jcfsesB5S);
																			if (262523 - 258213 == 4311)
																			{
																				goto IL_47B8;
																			}
																		}
																		IL_3B98:
																		this.t4jcfsesB5S = -1;
																		if (83481 - 333036 != -249555)
																		{
																			goto IL_47B8;
																		}
																		this.audio.PlayOneShot(this.tDRcfUqyCxE);
																		if (297674 - 216033 != 81641)
																		{
																			goto IL_47B8;
																		}
																		goto IL_21C9;
																		IL_38E5:
																		Chat.SubmitChat("none", "Cannot change host player slot", eChatType.system, eChatMode.mission);
																		if (25566 - 157461 != -131895)
																		{
																			goto IL_47B8;
																		}
																		goto IL_3B98;
																	}
																	IL_21C9:
																	goto IL_21CE;
																}
																goto IL_47B8;
															}
															GUI.DrawTexture(new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41), this.LavcfGMel9m.hover.background);
															if (141347 - 589028 != -447681)
															{
																goto IL_47B8;
															}
															GUI.Label(new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41), "  " + this.hxLcMIbiaoH[i].playerName, this.DW8cflw6LAd);
															if (182122 - 28362 != 153760)
															{
																goto IL_47B8;
															}
														}
														IL_21CE:
														IL_3647:
														GUI.DrawTexture(new Rect((float)720, (float)this.uyTcfBAnraB, (float)115, (float)40), this.L11cf1iJFuW.normal.background);
														if (98752 - 206701 != -107949)
														{
															goto IL_47B8;
														}
														GUI.Label(new Rect((float)720, (float)this.uyTcfBAnraB, (float)145, (float)40), "  " + this.hxLcMIbiaoH[i].type + " lv." + this.hxLcMIbiaoH[i].lv, this.DW8cflw6LAd);
														if (21146 - 228784 != -207638)
														{
															goto IL_47B8;
														}
														if (i == 0)
														{
															if (276058 - 382720 != -106662)
															{
																goto IL_47B8;
															}
															GUI.DrawTexture(new Rect((float)839, (float)(this.uyTcfBAnraB + 4), (float)93, (float)32), this.arIcfxJlHJr);
															if (45743 - 157549 == -111805)
															{
																goto IL_47B8;
															}
														}
														else if (this.hxLcMIbiaoH[i].ready != 0)
														{
															if (19716 - 264563 != -244847)
															{
																goto IL_47B8;
															}
															GUI.DrawTexture(new Rect((float)839, (float)(this.uyTcfBAnraB + 4), (float)93, (float)32), this.ENTcfYjBfXr);
															if (117368 - 555456 != -438088)
															{
																goto IL_47B8;
															}
														}
														else
														{
															GUI.DrawTexture(new Rect((float)839, (float)(this.uyTcfBAnraB + 4), (float)93, (float)32), this.DEacfTF05hp);
															if (103757 - 1137 != 102620)
															{
																goto IL_47B8;
															}
														}
														i++;
														if (117336 - 253933 != -136596)
														{
															continue;
														}
														goto IL_47B8;
														IL_21D3:
														GUI.DrawTexture(new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41), this.LavcfGMel9m.normal.background);
														if (192249 - 161838 == 30412)
														{
															goto IL_47B8;
														}
														GUI.Label(new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41), "  " + this.hxLcMIbiaoH[i].playerName, this.DW8cflw6LAd);
														if (24769 - 520087 != -495317)
														{
															goto IL_3647;
														}
														goto IL_47B8;
													}
													if (117660 - 12519 != 105141)
													{
														continue;
													}
													if (this.N6Hcf4ZG2YW != -1)
													{
														if (293953 - 386449 != -92496)
														{
															continue;
														}
														this.CbtcfH6sZJR = 45 * Mathf.FloorToInt((float)(this.N6Hcf4ZG2YW / data.team)) + 55 * (this.N6Hcf4ZG2YW % data.team) + 45 * (this.N6Hcf4ZG2YW % data.team) * this.I22cf8FU5bh;
														if (199566 - 545344 == -345777)
														{
															continue;
														}
														if (this.S4Mcf0yNvC4)
														{
															if (241512 - 137821 == 103692)
															{
																continue;
															}
															this.CbtcfH6sZJR -= 265;
															if (252256 - 376314 != -124058)
															{
																continue;
															}
														}
														GUI.DrawTexture(new Rect((float)520, (float)(430 + this.CbtcfH6sZJR), (float)194, (float)98), this.BH0cfp0ZEhx);
														if (191398 - 240854 != -49456)
														{
															continue;
														}
														if (this.N6Hcf4ZG2YW == 0)
														{
															if (56299 - 33028 != 23271)
															{
																continue;
															}
															GUI.Label(new Rect((float)520, (float)(440 + this.CbtcfH6sZJR), (float)194, (float)24), "  host", this.wivcfrFiCw8);
															if (218677 - 520947 == -302269)
															{
																continue;
															}
															if (!flag3)
															{
																if (30857 - 278166 == -247308)
																{
																	continue;
																}
																if (Event.current.type == EventType.MouseDown)
																{
																	if (278252 - 191872 != 86380)
																	{
																		continue;
																	}
																	this.N6Hcf4ZG2YW = -1;
																	if (173192 - 578628 == -405435)
																	{
																		continue;
																	}
																}
															}
														}
														else if (GUI.Button(new Rect((float)520, (float)(440 + this.CbtcfH6sZJR), (float)194, (float)24), "  public", this.wivcfrFiCw8))
														{
															if (298102 - 146306 == 151797)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].playerID = 0;
															if (110895 - 399282 != -288387)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].playerName = "public";
															if (63129 - 240421 != -177292)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].type = "non";
															if (76771 - 307476 == -230704)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].lv = 0;
															if (54839 - 284274 == -229434)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].ready = 0;
															if (9919 - 282512 == -272592)
															{
																continue;
															}
															this.audio.PlayOneShot(this.tDRcfUqyCxE);
															if (96027 - 559343 == -463315)
															{
																continue;
															}
															this.UpdateMission(1, this.N6Hcf4ZG2YW, 1);
															if (276323 - 116597 != 159726)
															{
																continue;
															}
															this.N6Hcf4ZG2YW = -1;
															if (236006 - 291152 != -55146)
															{
																continue;
															}
														}
														else if (GUI.Button(new Rect((float)520, (float)(466 + this.CbtcfH6sZJR), (float)194, (float)24), "  private", this.wivcfrFiCw8))
														{
															if (229779 - 107898 != 121881)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].playerID = 0;
															if (134333 - 54463 != 79870)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].playerName = "private";
															if (38300 - 222656 == -184355)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].type = "non";
															if (55894 - 284087 != -228193)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].lv = 0;
															if (287508 - 177416 == 110093)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].ready = 0;
															if (249255 - 365034 != -115779)
															{
																continue;
															}
															this.audio.PlayOneShot(this.tDRcfUqyCxE);
															if (185687 - 522867 == -337179)
															{
																continue;
															}
															this.UpdateMission(1, this.N6Hcf4ZG2YW, 2);
															if (232952 - 585807 != -352855)
															{
																continue;
															}
															this.N6Hcf4ZG2YW = -1;
															if (79898 - 469067 != -389169)
															{
																continue;
															}
														}
														else if (GUI.Button(new Rect((float)520, (float)(492 + this.CbtcfH6sZJR), (float)194, (float)24), "  close", this.wivcfrFiCw8))
														{
															if (78452 - 276952 != -198500)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].playerID = 0;
															if (146114 - 411687 != -265573)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].playerName = "close";
															if (283727 - 580312 != -296585)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].type = "non";
															if (225045 - 515439 == -290393)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].lv = 0;
															if (268466 - 276391 != -7925)
															{
																continue;
															}
															this.hxLcMIbiaoH[this.N6Hcf4ZG2YW].ready = 0;
															if (242535 - 339467 != -96932)
															{
																continue;
															}
															this.audio.PlayOneShot(this.tDRcfUqyCxE);
															if (249494 - 409889 != -160395)
															{
																continue;
															}
															this.UpdateMission(1, this.N6Hcf4ZG2YW, 0);
															if (248311 - 113802 != 134509)
															{
																continue;
															}
															this.N6Hcf4ZG2YW = -1;
															if (113415 - 341869 != -228454)
															{
																continue;
															}
														}
														else if (!flag3)
														{
															if (219451 - 536498 != -317047)
															{
																continue;
															}
															if (Event.current.type == EventType.MouseDown)
															{
																if (134120 - 505845 != -371725)
																{
																	continue;
																}
																this.N6Hcf4ZG2YW = -1;
																if (185962 - 273956 == -87993)
																{
																	continue;
																}
															}
														}
													}
													if (this.aoRcffyBoam >= 0)
													{
														if (220370 - 381978 == -161607)
														{
															continue;
														}
														this.RenderNoticeBar("Starting mission");
														if (293048 - 80830 != 212218)
														{
															continue;
														}
														if (this.L4rcCAGc8mu <= Time.time)
														{
															if (67152 - 172796 == -105643)
															{
																continue;
															}
															if (this.aoRcffyBoam != 0)
															{
																if (235516 - 368788 != -133272)
																{
																	continue;
																}
																if (this.aoRcffyBoam > 1)
																{
																	if (61289 - 128003 == -66713)
																	{
																		continue;
																	}
																	Chat.SubmitChat("none", "Mission starts in: " + (this.aoRcffyBoam - 1), eChatType.system, eChatMode.mission);
																	if (241362 - 372848 == -131485)
																	{
																		continue;
																	}
																	if (this.wWocfEaARRv)
																	{
																		if (37280 - 242518 == -205237)
																		{
																			continue;
																		}
																		this.audio.PlayOneShot(this.wWocfEaARRv);
																		if (133687 - 44775 == 88913)
																		{
																			continue;
																		}
																	}
																}
																else
																{
																	if (data.type == eMissionType.story)
																	{
																		if (141583 - 396945 != -255362)
																		{
																			continue;
																		}
																		if (this.getPlayerAverageLevel() > data.lv + 12)
																		{
																			if (85363 - 438855 == -353491)
																			{
																				continue;
																			}
																			Chat.SubmitChat("none", "Mission is starting advance mode!", eChatType.system, eChatMode.mission);
																			if (265717 - 47647 != 218070)
																			{
																				continue;
																			}
																			this.yHQcMX8ErSG = true;
																			if (41866 - 129845 != -87978)
																			{
																				goto IL_657C;
																			}
																			continue;
																		}
																	}
																	Chat.SubmitChat("none", "Mission is starting...", eChatType.system, eChatMode.mission);
																	if (113841 - 331666 != -217825)
																	{
																		continue;
																	}
																	this.yHQcMX8ErSG = false;
																	if (193755 - 555824 != -362069)
																	{
																		continue;
																	}
																}
																IL_657C:
																this.L4rcCAGc8mu = Time.time + (float)1;
																if (77151 - 201648 == -124496)
																{
																	continue;
																}
																this.aoRcffyBoam--;
																if (253972 - 130753 != 123219)
																{
																	continue;
																}
															}
															else if (this.aoRcffyBoam == 0)
															{
																if (13366 - 65322 == -51955)
																{
																	continue;
																}
																this.StartMission();
																if (167024 - 438594 == -271569)
																{
																	continue;
																}
																this.aoRcffyBoam = -2;
																if (240384 - 286516 == -46131)
																{
																	continue;
																}
															}
														}
													}
													else
													{
														int num5 = 640;
														if (83464 - 332708 != -249244)
														{
															continue;
														}
														if (this.S4Mcf0yNvC4)
														{
															if (284764 - 290899 == -6134)
															{
																continue;
															}
															num5 = 680;
															if (40666 - 112026 == -71359)
															{
																continue;
															}
														}
														if (GUI.Button(new Rect((float)720, (float)num5, (float)93, (float)36), string.Empty, this.p9ScfJZBqDb))
														{
															if (192202 - 56629 != 135573)
															{
																continue;
															}
															if (this.aoRcffyBoam == -1)
															{
																if (206861 - 32927 == 173935)
																{
																	continue;
																}
																bool flag4 = false;
																if (265659 - 298852 == -33192)
																{
																	continue;
																}
																if (this.mType == eMissionGuiType.town)
																{
																	if (290647 - 323051 == -32403)
																	{
																		continue;
																	}
																	if (!RuntimeServices.EqualityOperator(this.n6rcMQX4Xhl, null))
																	{
																		if (139407 - 389099 != -249692)
																		{
																			continue;
																		}
																		int n = 0;
																		if (32057 - 515706 != -483649)
																		{
																			continue;
																		}
																		MissionListClass[] array3 = this.n6rcMQX4Xhl;
																		if (33702 - 523696 == -489993)
																		{
																			continue;
																		}
																		int length5 = array3.Length;
																		if (99142 - 211600 == -112457)
																		{
																			continue;
																		}
																		while (n < length5)
																		{
																			if (array3[n].roomCode == this.vpEcCKjSAwn)
																			{
																				if (185467 - 13186 == 172282)
																				{
																					goto IL_47B8;
																				}
																				if (array3[n].roomTimer > Time.time)
																				{
																					if (63374 - 322338 == -258963)
																					{
																						goto IL_47B8;
																					}
																					flag4 = true;
																					if (290637 - 253760 != 36877)
																					{
																						goto IL_47B8;
																					}
																				}
																			}
																			n++;
																			if (34379 - 566297 != -531918)
																			{
																				goto IL_47B8;
																			}
																		}
																		if (119852 - 470506 != -350654)
																		{
																			continue;
																		}
																	}
																}
																else if (this.mType == eMissionGuiType.arena)
																{
																	if (260984 - 319951 != -58967)
																	{
																		continue;
																	}
																	if (!RuntimeServices.EqualityOperator(this.HTmcMeto4Zx, null))
																	{
																		if (292300 - 301507 != -9207)
																		{
																			continue;
																		}
																		int num6 = 0;
																		if (22436 - 312767 == -290330)
																		{
																			continue;
																		}
																		MissionListClass[] htmcMeto4Zx3 = this.HTmcMeto4Zx;
																		if (82617 - 296171 == -213553)
																		{
																			continue;
																		}
																		int length6 = htmcMeto4Zx3.Length;
																		if (122843 - 491912 == -369068)
																		{
																			continue;
																		}
																		while (num6 < length6)
																		{
																			if (htmcMeto4Zx3[num6].roomCode == this.vpEcCKjSAwn)
																			{
																				if (172721 - 242661 == -69939)
																				{
																					goto IL_47B8;
																				}
																				if (htmcMeto4Zx3[num6].roomTimer > Time.time)
																				{
																					if (66820 - 429713 != -362893)
																					{
																						goto IL_47B8;
																					}
																					flag4 = true;
																					if (263289 - 563969 != -300680)
																					{
																						goto IL_47B8;
																					}
																				}
																			}
																			num6++;
																			if (62603 - 415729 != -353126)
																			{
																				goto IL_47B8;
																			}
																		}
																		if (163469 - 526130 == -362660)
																		{
																			continue;
																		}
																	}
																}
																else
																{
																	flag4 = true;
																	if (125165 - 45650 == 79516)
																	{
																		continue;
																	}
																}
																if (!flag4)
																{
																	if (114692 - 294974 == -180281)
																	{
																		continue;
																	}
																	Chat.SubmitChat("none", "Cannot start mission: mission has expire", eChatType.system, eChatMode.mission);
																	if (139834 - 526382 != -386548)
																	{
																		continue;
																	}
																}
																else
																{
																	if (this.vpEcCKjSAwn > 940)
																	{
																		if (172292 - 290910 == -118617)
																		{
																			continue;
																		}
																		if (this.vpEcCKjSAwn < 960)
																		{
																			if (165273 - 116944 == 48330)
																			{
																				continue;
																			}
																			if (this.getPlayerCount() < 4)
																			{
																				if (114594 - 394391 != -279797)
																				{
																					continue;
																				}
																				if (Game.server < 3)
																				{
																					if (288023 - 507761 != -219738)
																					{
																						continue;
																					}
																					Chat.SubmitChat("none", "Need at least 4 players", eChatType.system, eChatMode.mission);
																					if (278587 - 85234 != 193354)
																					{
																						goto IL_6BBE;
																					}
																					continue;
																				}
																			}
																		}
																	}
																	if (this.vpEcCKjSAwn > 990)
																	{
																		if (215043 - 322012 != -106969)
																		{
																			continue;
																		}
																		this.StartMission();
																		if (294616 - 176403 == 118214)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		eMissionType type2 = data.type;
																		if (299181 - 140509 != 158672)
																		{
																			continue;
																		}
																		if (type2 == eMissionType.story)
																		{
																			if (127218 - 589012 == -461793)
																			{
																				continue;
																			}
																			if (!this.getPlayerReady())
																			{
																				if (204597 - 440242 == -235644)
																				{
																					continue;
																				}
																				Chat.SubmitChat("none", "Not all players are ready ", eChatType.system, eChatMode.mission);
																				if (243556 - 509198 == -265641)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.aoRcffyBoam = -3;
																				if (228615 - 377029 != -148414)
																				{
																					continue;
																				}
																				this.MissionCountDown();
																				if (87321 - 84705 == 2617)
																				{
																					continue;
																				}
																			}
																		}
																		else if (type2 == eMissionType.pvp)
																		{
																			if (229732 - 343768 == -114035)
																			{
																				continue;
																			}
																			if (!this.getPlayerReady())
																			{
																				if (283292 - 286796 != -3504)
																				{
																					continue;
																				}
																				Chat.SubmitChat("none", "Not all players are ready ", eChatType.system, eChatMode.mission);
																				if (27903 - 52572 != -24669)
																				{
																					continue;
																				}
																			}
																			else if (this.getOpponentCount(data.team) == 0)
																			{
																				if (69156 - 190111 != -120955)
																				{
																					continue;
																				}
																				Chat.SubmitChat("none", "Need Two Team ", eChatType.system, eChatMode.mission);
																				if (179241 - 431667 == -252425)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.aoRcffyBoam = -3;
																				if (85773 - 186174 == -100400)
																				{
																					continue;
																				}
																				this.MissionCountDown();
																				if (148298 - 443584 != -295286)
																				{
																					continue;
																				}
																			}
																		}
																		else if (type2 == eMissionType.arena)
																		{
																			if (74453 - 79506 != -5053)
																			{
																				continue;
																			}
																			if (!this.getPlayerReady())
																			{
																				if (53999 - 199913 != -145914)
																				{
																					continue;
																				}
																				Chat.SubmitChat("none", "Not all players are ready ", eChatType.system, eChatMode.mission);
																				if (53967 - 382176 == -328208)
																				{
																					continue;
																				}
																			}
																			else if (this.getTeamCount(data.team) < data.player)
																			{
																				if (110345 - 65521 != 44824)
																				{
																					continue;
																				}
																				Chat.SubmitChat("none", "Need Full Team ", eChatType.system, eChatMode.mission);
																				if (220034 - 409527 != -189493)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.HeGcCkg9Cyt = eMissionState.matchSearch;
																				if (123932 - 474418 == -350485)
																				{
																					continue;
																				}
																				this.L4rcCAGc8mu = Time.time;
																				if (13772 - 244508 != -230736)
																				{
																					continue;
																				}
																				this.MatchSearch();
																				if (164668 - 308989 != -144321)
																				{
																					continue;
																				}
																			}
																		}
																		else
																		{
																			this.StartMission();
																			if (95227 - 596334 == -501106)
																			{
																				continue;
																			}
																		}
																	}
																}
																IL_6BBE:
																this.audio.PlayOneShot(this.tDRcfUqyCxE);
																if (120430 - 83381 != 37049)
																{
																	continue;
																}
															}
														}
														if (GUI.Button(new Rect((float)825, (float)num5, (float)91, (float)36), string.Empty, this.NTGcf6ubKck))
														{
															if (183184 - 508143 != -324959)
															{
																continue;
															}
															this.LeaveMission();
															if (191133 - 430973 == -239839)
															{
																continue;
															}
															this.E19cMJ4MOu0 = "Mission has been canceled";
															if (245910 - 447189 == -201278)
															{
																continue;
															}
															this.aoRcffyBoam = -1;
															if (115727 - 31652 == 84076)
															{
																continue;
															}
															this.HeGcCkg9Cyt = eMissionState.error;
															if (165333 - 539639 != -374306)
															{
																continue;
															}
															this.L4rcCAGc8mu = Time.time;
															if (262846 - 450489 != -187643)
															{
																continue;
															}
															if (this.MHYcfw23xt3)
															{
																if (289956 - 170534 != 119422)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.MHYcfw23xt3);
																if (96324 - 476138 == -379813)
																{
																	continue;
																}
															}
														}
														GUI.Label(new Rect((float)585, (float)((!this.S4Mcf0yNvC4) ? 640 : 680), (float)200, (float)30), "random loot", this.JhlcfvBBDH5);
														if (130110 - 411425 != -281315)
														{
															continue;
														}
														if (GUI.Button(new Rect((float)555, (float)((!this.S4Mcf0yNvC4) ? 646 : 686), (float)21, (float)22), string.Empty, this.Of4cf2GEvq1))
														{
															if (66791 - 259311 == -192519)
															{
																continue;
															}
															if (this.aoRcffyBoam == -1)
															{
																if (115660 - 406973 != -291313)
																{
																	continue;
																}
																if (this.awFcMvfyL1v < Time.time)
																{
																	if (86819 - 440434 != -353615)
																	{
																		continue;
																	}
																	this.lA4cM2SF4ol = !this.lA4cM2SF4ol;
																	if (80725 - 447039 == -366313)
																	{
																		continue;
																	}
																	this.awFcMvfyL1v = Time.time + (float)1;
																	if (227158 - 337648 == -110489)
																	{
																		continue;
																	}
																	if (this.lA4cM2SF4ol)
																	{
																		if (9190 - 288453 != -279263)
																		{
																			continue;
																		}
																		PlayerPrefs.SetInt("randomLoot", 1);
																		if (55001 - 349904 == -294902)
																		{
																			continue;
																		}
																		this.UpdateMission(4, 0, 1);
																		if (258615 - 322943 == -64327)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		PlayerPrefs.SetInt("randomLoot", 0);
																		if (195278 - 3861 == 191418)
																		{
																			continue;
																		}
																		this.UpdateMission(4, 0, 0);
																		if (198009 - 49839 != 148170)
																		{
																			continue;
																		}
																	}
																	if (this.tDRcfUqyCxE)
																	{
																		if (129212 - 282570 == -153357)
																		{
																			continue;
																		}
																		this.audio.PlayOneShot(this.tDRcfUqyCxE);
																		if (94741 - 97276 == -2534)
																		{
																			continue;
																		}
																	}
																}
															}
														}
														if (this.lA4cM2SF4ol)
														{
															if (272330 - 294911 != -22581)
															{
																continue;
															}
															GUI.DrawTexture(new Rect((float)557, (float)((!this.S4Mcf0yNvC4) ? 648 : 688), (float)16, (float)16), this.icZcfOjPP65);
															if (62953 - 450210 == -387256)
															{
																continue;
															}
														}
													}
												}
												else
												{
													this.HeGcCkg9Cyt = eMissionState.selectQuest;
													if (165143 - 286641 == -121497)
													{
														continue;
													}
													this.L4rcCAGc8mu = Time.time;
													if (102831 - 437682 == -334850)
													{
														continue;
													}
												}
												if (GUI.Button(new Rect((float)153, (float)-1, (float)57, (float)52), string.Empty, this.e1DcfQ3ex3l))
												{
													if (115934 - 476426 != -360492)
													{
														continue;
													}
													if (this.aoRcffyBoam == -1)
													{
														if (204291 - 443378 != -239087)
														{
															continue;
														}
														this.LeaveMission();
														if (22453 - 69495 == -47041)
														{
															continue;
														}
														this.aoRcffyBoam = -1;
														if (240349 - 354457 != -114108)
														{
															continue;
														}
														this.HeGcCkg9Cyt = eMissionState.close;
														if (279294 - 550694 != -271400)
														{
															continue;
														}
														this.L4rcCAGc8mu = Time.time;
														if (131963 - 135280 != -3317)
														{
															continue;
														}
														if (this.MHYcfw23xt3)
														{
															if (189074 - 35445 == 153630)
															{
																continue;
															}
															this.audio.PlayOneShot(this.MHYcfw23xt3);
															if (184095 - 593464 != -409369)
															{
																continue;
															}
														}
														this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
														if (302 - 217353 == -217050)
														{
															continue;
														}
													}
												}
												GUI.EndGroup();
												if (281614 - 525602 != -243987)
												{
													this.RenderChatBar();
													if (54829 - 383121 != -328291)
													{
														this.RenderNPC();
														if (162875 - 544996 != -382120)
														{
															this.RenderDragPlayer();
															if (47573 - 168131 == -120558)
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
							else if (heGcCkg9Cyt == eMissionState.joinTeam)
							{
								if (220239 - 205281 == 14958)
								{
									GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)1024, (float)0, (float)1024, (float)1024), this.zpCcM1sSJB3);
									if (86255 - 271612 == -185357)
									{
										GUI.BeginGroup(new Rect(this.T45cCyVhtgd - (float)1015, (float)0, (float)1015, (float)1024));
										if (177732 - 26280 == 151452)
										{
											eMissionGuiType eMissionGuiType7 = this.mType;
											if (30322 - 520573 != -490250)
											{
												if (eMissionGuiType7 == eMissionGuiType.guild)
												{
													if (80548 - 216551 == -136002)
													{
														continue;
													}
													this.RenderGuildMissionList(false);
													if (130616 - 476287 == -345670)
													{
														continue;
													}
													this.RenderRecordBar();
													if (55251 - 553702 != -498451)
													{
														continue;
													}
												}
												else if (eMissionGuiType7 == eMissionGuiType.town)
												{
													if (169606 - 340690 != -171084)
													{
														continue;
													}
													this.RenderTownMissionList(false);
													if (171733 - 514742 != -343009)
													{
														continue;
													}
													this.RenderTownRecordBar();
													if (187031 - 190683 != -3652)
													{
														continue;
													}
												}
												else if (eMissionGuiType7 == eMissionGuiType.arena)
												{
													if (32188 - 169134 == -136945)
													{
														continue;
													}
													this.RenderPVPArenaList(false);
													if (40214 - 309845 != -269631)
													{
														continue;
													}
													this.RenderArenaRecordBar();
													if (156156 - 76876 != 79280)
													{
														continue;
													}
												}
												else if (eMissionGuiType7 == eMissionGuiType.dungeon)
												{
													if (219287 - 135764 == 83524)
													{
														continue;
													}
													this.RenderDungeonList(false);
													if (24047 - 407899 == -383851)
													{
														continue;
													}
													this.RenderDungeonBar();
													if (121025 - 210646 != -89621)
													{
														continue;
													}
												}
												if (data.team + data.player > 6)
												{
													if (49999 - 298357 != -248358)
													{
														continue;
													}
													this.S4Mcf0yNvC4 = true;
													if (152986 - 588097 == -435110)
													{
														continue;
													}
												}
												else
												{
													this.S4Mcf0yNvC4 = false;
													if (47703 - 470888 != -423185)
													{
														continue;
													}
												}
												this.I22cf8FU5bh = Mathf.FloorToInt((float)(data.player / data.team));
												if (204508 - 78014 != 126495)
												{
													if (this.jRIcMpVcPPy != null)
													{
														if (123961 - 514736 != -390775)
														{
															continue;
														}
														if (!this.S4Mcf0yNvC4)
														{
															if (83151 - 40304 != 42847)
															{
																continue;
															}
															GUI.DrawTexture(new Rect((float)512, (float)60, (float)434, (float)285), this.jRIcMpVcPPy);
															if (208569 - 194887 == 13683)
															{
																continue;
															}
														}
														else
														{
															GUI.BeginGroup(new Rect((float)512, (float)60, (float)434, (float)45));
															if (196626 - 458714 != -262088)
															{
																continue;
															}
															GUI.DrawTexture(new Rect((float)0, (float)0, (float)434, (float)285), this.jRIcMpVcPPy);
															if (92323 - 389018 != -296695)
															{
																continue;
															}
															GUI.EndGroup();
															if (248661 - 509956 != -261295)
															{
																continue;
															}
														}
													}
													num = (float)0;
													if (258909 - 334648 == -75739)
													{
														while (num < (float)data.team)
														{
															if (!this.S4Mcf0yNvC4)
															{
																if (107294 - 586609 != -479315)
																{
																	goto IL_47B8;
																}
																if (data.team == 1)
																{
																	if (144322 - 203182 == -58859)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)345 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.tXfcMbSmHvR);
																	if (29103 - 221325 != -192222)
																	{
																		goto IL_47B8;
																	}
																}
																else
																{
																	float num7 = num;
																	if (200942 - 68296 != 132646)
																	{
																		goto IL_47B8;
																	}
																	if (num7 == (float)0)
																	{
																		if (258116 - 423766 == -165649)
																		{
																			goto IL_47B8;
																		}
																		GUI.DrawTexture(new Rect((float)484, (float)345 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.DB0cMdG7Phx);
																		if (5139 - 476182 != -471043)
																		{
																			goto IL_47B8;
																		}
																	}
																	else if (num7 == (float)1)
																	{
																		if (272636 - 586721 == -314084)
																		{
																			goto IL_47B8;
																		}
																		GUI.DrawTexture(new Rect((float)484, (float)345 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.GulcMgHWJeM);
																		if (129283 - 423077 == -293793)
																		{
																			goto IL_47B8;
																		}
																	}
																	else if (num7 == (float)2)
																	{
																		if (114245 - 368285 != -254040)
																		{
																			goto IL_47B8;
																		}
																		GUI.DrawTexture(new Rect((float)484, (float)345 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.rPgcMaLylWk);
																		if (195660 - 103184 == 92477)
																		{
																			goto IL_47B8;
																		}
																	}
																	else if (num7 == (float)3)
																	{
																		if (219633 - 394853 != -175220)
																		{
																			goto IL_47B8;
																		}
																		GUI.DrawTexture(new Rect((float)484, (float)345 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.OctcM4i9gTI);
																		if (25464 - 567997 != -542533)
																		{
																			goto IL_47B8;
																		}
																	}
																	else if (num7 == (float)4)
																	{
																		if (131498 - 417959 != -286461)
																		{
																			goto IL_47B8;
																		}
																		GUI.DrawTexture(new Rect((float)484, (float)345 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.YiAcMsNnfR3);
																		if (113364 - 381976 != -268612)
																		{
																			goto IL_47B8;
																		}
																	}
																}
															}
															else if (data.team == 1)
															{
																if (296624 - 286191 != 10433)
																{
																	goto IL_47B8;
																}
																GUI.DrawTexture(new Rect((float)484, (float)80 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.tXfcMbSmHvR);
																if (291712 - 564648 == -272935)
																{
																	goto IL_47B8;
																}
															}
															else
															{
																float num8 = num;
																if (195703 - 120994 == 74710)
																{
																	goto IL_47B8;
																}
																if (num8 == (float)0)
																{
																	if (10886 - 408164 != -397278)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)80 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.DB0cMdG7Phx);
																	if (238857 - 339446 == -100588)
																	{
																		goto IL_47B8;
																	}
																}
																else if (num8 == (float)1)
																{
																	if (125442 - 133405 == -7962)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)80 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.GulcMgHWJeM);
																	if (42410 - 49884 == -7473)
																	{
																		goto IL_47B8;
																	}
																}
																else if (num8 == (float)2)
																{
																	if (289480 - 204365 == 85116)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)80 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.rPgcMaLylWk);
																	if (182601 - 154751 == 27851)
																	{
																		goto IL_47B8;
																	}
																}
																else if (num8 == (float)3)
																{
																	if (243175 - 513136 != -269961)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)80 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.OctcM4i9gTI);
																	if (299118 - 81288 != 217830)
																	{
																		goto IL_47B8;
																	}
																}
																else if (num8 == (float)4)
																{
																	if (61947 - 113080 == -51132)
																	{
																		goto IL_47B8;
																	}
																	GUI.DrawTexture(new Rect((float)484, (float)80 + num * (float)55 + num * (float)45 * (float)this.I22cf8FU5bh, (float)421, (float)50), this.YiAcMsNnfR3);
																	if (11970 - 512171 == -500200)
																	{
																		goto IL_47B8;
																	}
																}
															}
															num += (float)1;
															if (123875 - 514465 == -390589)
															{
																goto IL_47B8;
															}
														}
														if (285049 - 120668 != 164382)
														{
															int i = 0;
															if (177270 - 351502 == -174232)
															{
																while (i < data.player)
																{
																	this.zRZcfPiLvJi = i % data.team;
																	if (7325 - 437423 == -430097)
																	{
																		goto IL_47B8;
																	}
																	this.xBZcfSA08TD = Mathf.FloorToInt((float)(i / data.team));
																	if (244774 - 499914 != -255140)
																	{
																		goto IL_47B8;
																	}
																	if (!this.S4Mcf0yNvC4)
																	{
																		if (59755 - 66151 == -6395)
																		{
																			goto IL_47B8;
																		}
																		this.uyTcfBAnraB = 395 + 45 * this.xBZcfSA08TD + 55 * this.zRZcfPiLvJi + 45 * this.zRZcfPiLvJi * this.I22cf8FU5bh;
																		if (27021 - 470467 != -443446)
																		{
																			goto IL_47B8;
																		}
																	}
																	else
																	{
																		this.uyTcfBAnraB = 130 + 45 * this.xBZcfSA08TD + 55 * this.zRZcfPiLvJi + 45 * this.zRZcfPiLvJi * this.I22cf8FU5bh;
																		if (239333 - 383153 == -143819)
																		{
																			goto IL_47B8;
																		}
																	}
																	GUI.Label(new Rect((float)520, (float)this.uyTcfBAnraB, (float)197, (float)41), "  " + this.hxLcMIbiaoH[i].playerName, this.LavcfGMel9m);
																	if (14101 - 58277 != -44176)
																	{
																		goto IL_47B8;
																	}
																	GUI.Label(new Rect((float)720, (float)this.uyTcfBAnraB, (float)115, (float)40), "  " + this.hxLcMIbiaoH[i].type + " lv." + this.hxLcMIbiaoH[i].lv, this.L11cf1iJFuW);
																	if (159824 - 464664 == -304839)
																	{
																		goto IL_47B8;
																	}
																	if (i == 0)
																	{
																		if (241526 - 205221 == 36306)
																		{
																			goto IL_47B8;
																		}
																		GUI.DrawTexture(new Rect((float)839, (float)(this.uyTcfBAnraB + 4), (float)93, (float)32), this.arIcfxJlHJr);
																		if (131904 - 253699 != -121795)
																		{
																			goto IL_47B8;
																		}
																	}
																	else if (this.hxLcMIbiaoH[i].ready != 0)
																	{
																		if (250145 - 496585 == -246439)
																		{
																			goto IL_47B8;
																		}
																		GUI.DrawTexture(new Rect((float)839, (float)(this.uyTcfBAnraB + 4), (float)93, (float)32), this.ENTcfYjBfXr);
																		if (107616 - 89760 == 17857)
																		{
																			goto IL_47B8;
																		}
																	}
																	else if (this.hxLcMIbiaoH[i].playerName != PlayerData.User)
																	{
																		if (115925 - 343608 != -227683)
																		{
																			goto IL_47B8;
																		}
																		GUI.DrawTexture(new Rect((float)839, (float)(this.uyTcfBAnraB + 4), (float)93, (float)32), this.DEacfTF05hp);
																		if (221871 - 444212 != -222341)
																		{
																			goto IL_47B8;
																		}
																	}
																	else if (GUI.Button(new Rect((float)839, (float)(this.uyTcfBAnraB + 4), (float)93, (float)32), string.Empty, this.Veecfq2QtjG))
																	{
																		if (15797 - 50095 != -34298)
																		{
																			goto IL_47B8;
																		}
																		this.hxLcMIbiaoH[i].ready = 1;
																		if (24758 - 453846 != -429088)
																		{
																			goto IL_47B8;
																		}
																		this.UpdateMission(3, i, 1);
																		if (175382 - 312571 == -137188)
																		{
																			goto IL_47B8;
																		}
																		if (this.Ph6cfL8crLa)
																		{
																			if (163595 - 208834 == -45238)
																			{
																				goto IL_47B8;
																			}
																			this.audio.PlayOneShot(this.Ph6cfL8crLa);
																			if (71181 - 282558 == -211376)
																			{
																				goto IL_47B8;
																			}
																		}
																	}
																	i++;
																	if (260048 - 35314 != 224734)
																	{
																		goto IL_47B8;
																	}
																}
																if (170719 - 34621 != 136099)
																{
																	GUI.Label(new Rect((float)585, (float)((!this.S4Mcf0yNvC4) ? 640 : 680), (float)200, (float)30), "random loot", this.JhlcfvBBDH5);
																	if (287946 - 48791 == 239155)
																	{
																		GUI.DrawTexture(new Rect((float)555, (float)((!this.S4Mcf0yNvC4) ? 646 : 686), (float)21, (float)22), this.Of4cf2GEvq1.normal.background);
																		if (83091 - 12088 != 71004)
																		{
																			if (this.lA4cM2SF4ol)
																			{
																				if (112987 - 61687 != 51300)
																				{
																					continue;
																				}
																				GUI.DrawTexture(new Rect((float)557, (float)((!this.S4Mcf0yNvC4) ? 648 : 688), (float)16, (float)16), this.icZcfOjPP65);
																				if (8721 - 125332 == -116610)
																				{
																					continue;
																				}
																			}
																			if (this.aoRcffyBoam >= 0)
																			{
																				if (240780 - 151441 != 89339)
																				{
																					continue;
																				}
																				this.RenderNoticeBar("Starting mission");
																				if (137487 - 7620 != 129867)
																				{
																					continue;
																				}
																				if (this.L4rcCAGc8mu <= Time.time)
																				{
																					if (15504 - 551845 != -536341)
																					{
																						continue;
																					}
																					if (this.aoRcffyBoam != 0)
																					{
																						if (115653 - 432422 != -316769)
																						{
																							continue;
																						}
																						if (this.aoRcffyBoam > 1)
																						{
																							if (82786 - 383134 != -300348)
																							{
																								continue;
																							}
																							Chat.SubmitChat("none", "Mission starts in: " + (this.aoRcffyBoam - 1), eChatType.system, eChatMode.mission);
																							if (57864 - 224928 == -167063)
																							{
																								continue;
																							}
																							if (this.wWocfEaARRv)
																							{
																								if (131965 - 162055 == -30089)
																								{
																									continue;
																								}
																								this.audio.PlayOneShot(this.wWocfEaARRv);
																								if (103158 - 472451 != -369293)
																								{
																									continue;
																								}
																							}
																						}
																						else
																						{
																							if (data.type == eMissionType.story)
																							{
																								if (166825 - 553825 != -387000)
																								{
																									continue;
																								}
																								if (this.getPlayerAverageLevel() > data.lv + 12)
																								{
																									if (222249 - 558857 != -336608)
																									{
																										continue;
																									}
																									Chat.SubmitChat("none", "Mission is starting advance mode!", eChatType.system, eChatMode.mission);
																									if (106430 - 523441 == -417010)
																									{
																										continue;
																									}
																									this.yHQcMX8ErSG = true;
																									if (42998 - 561827 != -518829)
																									{
																										continue;
																									}
																									goto IL_5AEC;
																								}
																							}
																							Chat.SubmitChat("none", "Mission is starting...", eChatType.system, eChatMode.mission);
																							if (57347 - 372253 != -314906)
																							{
																								continue;
																							}
																							this.yHQcMX8ErSG = false;
																							if (74302 - 264958 != -190656)
																							{
																								continue;
																							}
																						}
																						IL_5AEC:
																						this.L4rcCAGc8mu = Time.time + (float)1;
																						if (285089 - 563297 == -278207)
																						{
																							continue;
																						}
																						this.aoRcffyBoam--;
																						if (60385 - 576680 != -516295)
																						{
																							continue;
																						}
																					}
																					else if (this.aoRcffyBoam == 0)
																					{
																						if (124625 - 230310 != -105685)
																						{
																							continue;
																						}
																						this.aoRcffyBoam = -2;
																						if (21253 - 447656 != -426403)
																						{
																							continue;
																						}
																					}
																				}
																			}
																			else
																			{
																				int num9 = 640;
																				if (73362 - 139345 != -65983)
																				{
																					continue;
																				}
																				if (this.S4Mcf0yNvC4)
																				{
																					if (223968 - 189537 == 34432)
																					{
																						continue;
																					}
																					num9 = 680;
																					if (117861 - 110139 != 7722)
																					{
																						continue;
																					}
																				}
																				if (GUI.Button(new Rect((float)825, (float)num9, (float)91, (float)36), string.Empty, this.NTGcf6ubKck))
																				{
																					if (120197 - 364054 != -243857)
																					{
																						continue;
																					}
																					this.LeaveMission();
																					if (213281 - 213216 == 66)
																					{
																						continue;
																					}
																					this.E19cMJ4MOu0 = "Mission has been canceled";
																					if (288135 - 158287 == 129849)
																					{
																						continue;
																					}
																					this.HeGcCkg9Cyt = eMissionState.error;
																					if (96977 - 388596 != -291619)
																					{
																						continue;
																					}
																					this.L4rcCAGc8mu = Time.time;
																					if (7151 - 218319 != -211168)
																					{
																						continue;
																					}
																					if (this.MHYcfw23xt3)
																					{
																						if (43781 - 566784 != -523003)
																						{
																							continue;
																						}
																						this.audio.PlayOneShot(this.MHYcfw23xt3);
																						if (219308 - 299908 != -80600)
																						{
																							continue;
																						}
																					}
																				}
																			}
																			if (GUI.Button(new Rect((float)153, (float)-1, (float)57, (float)52), string.Empty, this.e1DcfQ3ex3l))
																			{
																				if (231268 - 212393 == 18876)
																				{
																					continue;
																				}
																				if (this.aoRcffyBoam == -1)
																				{
																					if (102256 - 207193 != -104937)
																					{
																						continue;
																					}
																					this.LeaveMission();
																					if (156786 - 454830 != -298044)
																					{
																						continue;
																					}
																					this.aoRcffyBoam = -1;
																					if (257064 - 32063 != 225001)
																					{
																						continue;
																					}
																					this.HeGcCkg9Cyt = eMissionState.close;
																					if (284802 - 480670 != -195868)
																					{
																						continue;
																					}
																					this.L4rcCAGc8mu = Time.time;
																					if (140490 - 460915 != -320425)
																					{
																						continue;
																					}
																					if (this.MHYcfw23xt3)
																					{
																						if (110360 - 144349 != -33989)
																						{
																							continue;
																						}
																						this.audio.PlayOneShot(this.MHYcfw23xt3);
																						if (208382 - 324720 != -116338)
																						{
																							continue;
																						}
																					}
																					this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
																					if (256287 - 537177 == -280889)
																					{
																						continue;
																					}
																				}
																			}
																			GUI.EndGroup();
																			if (248367 - 372482 != -124114)
																			{
																				this.RenderChatBar();
																				if (91226 - 62339 == 28887)
																				{
																					this.RenderNPC();
																					if (140151 - 598822 == -458671)
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
								if (heGcCkg9Cyt == eMissionState.matchSearch)
								{
									if (31353 - 395674 == -364320)
									{
										continue;
									}
								}
								else if (heGcCkg9Cyt == eMissionState.matchFound)
								{
									if (40030 - 115843 != -75813)
									{
										continue;
									}
								}
								else if (heGcCkg9Cyt == eMissionState.startQuest)
								{
									if (159161 - 338103 != -178942)
									{
										continue;
									}
									if (num <= (float)2)
									{
										if (276352 - 542753 == -266400)
										{
											continue;
										}
										this.RenderNPC();
										if (134308 - 21199 == 113110)
										{
											continue;
										}
										this.playStartingAudio();
										if (114635 - 569374 == -454738)
										{
											continue;
										}
										GUI.BeginGroup(new Rect(0.5f * this.T45cCyVhtgd - (float)350, (float)724, (float)850, (float)200));
										if (216799 - 179647 != 37152)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.odScfm5CIwr);
										if (6971 - 447528 != -440557)
										{
											continue;
										}
										eMissionGuiType eMissionGuiType8 = this.mType;
										if (11712 - 348495 != -336783)
										{
											continue;
										}
										if (eMissionGuiType8 == eMissionGuiType.guild)
										{
											if (262924 - 67523 != 195401)
											{
												continue;
											}
											GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Red Panda", this.U5ecfjlQCnv);
											if (236558 - 480630 == -244071)
											{
												continue;
											}
										}
										else if (eMissionGuiType8 == eMissionGuiType.town)
										{
											if (263495 - 483512 != -220017)
											{
												continue;
											}
											GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Skunk", this.U5ecfjlQCnv);
											if (45685 - 26628 != 19057)
											{
												continue;
											}
										}
										else if (eMissionGuiType8 == eMissionGuiType.arena)
										{
											if (60408 - 572663 != -512255)
											{
												continue;
											}
											GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Leopard", this.U5ecfjlQCnv);
											if (32220 - 174557 == -142336)
											{
												continue;
											}
										}
										else if (eMissionGuiType8 == eMissionGuiType.dungeon)
										{
											if (196981 - 164303 == 32679)
											{
												continue;
											}
											int mGameCode2 = Game.mGameCode;
											if (180100 - 319188 != -139088)
											{
												continue;
											}
											if (mGameCode2 == 32)
											{
												if (174422 - 264614 == -90191)
												{
													continue;
												}
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Penne", this.U5ecfjlQCnv);
												if (189625 - 329381 != -139756)
												{
													continue;
												}
											}
											else if (mGameCode2 == 34)
											{
												if (264118 - 455831 != -191713)
												{
													continue;
												}
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Liza", this.U5ecfjlQCnv);
												if (265640 - 35737 == 229904)
												{
													continue;
												}
											}
											else if (mGameCode2 == 33)
											{
												if (157464 - 51280 == 106185)
												{
													continue;
												}
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Guibo", this.U5ecfjlQCnv);
												if (286221 - 317611 != -31390)
												{
													continue;
												}
											}
											else if (mGameCode2 == 35)
											{
												if (242217 - 474592 != -232375)
												{
													continue;
												}
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "GallonBot", this.U5ecfjlQCnv);
												if (284169 - 425462 == -141292)
												{
													continue;
												}
											}
										}
										GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.gxAcfFSFYeg, num), this.GAucfoKnRxs);
										if (212805 - 394661 != -181856)
										{
											continue;
										}
										GUI.EndGroup();
										if (295239 - 336804 != -41564)
										{
											break;
										}
										continue;
									}
									else if (num <= 2.5f)
									{
										if (47240 - 194721 == -147480)
										{
											continue;
										}
										this.NQ8cfC229OA = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
										if (216041 - 560755 == -344713)
										{
											continue;
										}
										this.RenderNPC();
										if (93012 - 111005 != -17992)
										{
											break;
										}
										continue;
									}
									else if (num < (float)8)
									{
										if (1814 - 432824 != -431010)
										{
											continue;
										}
										this.SendMessage("splashOut");
										if (46752 - 163732 != -116979)
										{
											break;
										}
										continue;
									}
									else
									{
										this.SendMessage("LeaveTown");
										if (1092 - 29802 != -28710)
										{
											continue;
										}
										this.HeGcCkg9Cyt = eMissionState.disabled;
										if (292272 - 331530 != -39258)
										{
											continue;
										}
										Chat.ClearChatMode(eChatMode.mission);
										if (120760 - 376701 == -255940)
										{
											continue;
										}
										this.enabled = false;
										if (242832 - 481031 != -238199)
										{
											continue;
										}
										break;
									}
								}
								else if (heGcCkg9Cyt == eMissionState.error)
								{
									if (251947 - 384899 != -132952)
									{
										continue;
									}
									if (this.ST5cM6mrbBP != 0)
									{
										if (15507 - 106853 != -91346)
										{
											continue;
										}
										this.ST5cM6mrbBP = 0;
										if (198077 - 281354 == -83276)
										{
											continue;
										}
									}
									GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)1024, (float)0, (float)1024, (float)1024), this.zpCcM1sSJB3);
									if (170425 - 28772 != 141653)
									{
										continue;
									}
									GUI.BeginGroup(new Rect(this.T45cCyVhtgd - (float)1015, (float)0, (float)1015, (float)1024));
									if (77982 - 382603 == -304620)
									{
										continue;
									}
									eMissionGuiType eMissionGuiType9 = this.mType;
									if (45868 - 149470 != -103602)
									{
										continue;
									}
									if (eMissionGuiType9 == eMissionGuiType.guild)
									{
										if (132938 - 276769 == -143830)
										{
											continue;
										}
										this.RenderGuildMissionList(false);
										if (15445 - 588994 == -573548)
										{
											continue;
										}
										this.RenderRecordBar();
										if (247896 - 411587 == -163690)
										{
											continue;
										}
									}
									else if (eMissionGuiType9 == eMissionGuiType.town)
									{
										if (88946 - 503274 == -414327)
										{
											continue;
										}
										this.RenderTownMissionList(false);
										if (267167 - 368014 != -100847)
										{
											continue;
										}
										this.RenderTownRecordBar();
										if (236312 - 579627 != -343315)
										{
											continue;
										}
									}
									else if (eMissionGuiType9 == eMissionGuiType.arena)
									{
										if (52017 - 517087 == -465069)
										{
											continue;
										}
										this.RenderPVPArenaList(false);
										if (272194 - 524535 == -252340)
										{
											continue;
										}
										this.RenderArenaRecordBar();
										if (170905 - 204808 != -33903)
										{
											continue;
										}
									}
									this.RenderMissionDes();
									if (118613 - 156716 != -38103)
									{
										continue;
									}
									this.RenderNoticeBar(this.E19cMJ4MOu0);
									if (281211 - 115691 == 165521)
									{
										continue;
									}
									GUI.EndGroup();
									if (105926 - 20876 != 85050)
									{
										continue;
									}
									this.RenderNPC();
									if (244287 - 348453 != -104166)
									{
										continue;
									}
									this.RenderChatBar();
									if (93559 - 121917 != -28358)
									{
										continue;
									}
									if (num <= (float)2)
									{
										break;
									}
									if (127956 - 339335 != -211379)
									{
										continue;
									}
									this.HeGcCkg9Cyt = eMissionState.selectQuest;
									if (16886 - 539438 != -522552)
									{
										continue;
									}
									this.L4rcCAGc8mu = Time.time;
									if (10791 - 150034 != -139242)
									{
										break;
									}
									continue;
								}
								else
								{
									if (heGcCkg9Cyt != eMissionState.close)
									{
										break;
									}
									if (5325 - 376117 != -370792)
									{
										continue;
									}
									if (num <= (float)2)
									{
										if (46754 - 285099 != -238345)
										{
											continue;
										}
										this.RenderNPC();
										if (299936 - 571903 == -271966)
										{
											continue;
										}
										this.playCancelAudio();
										if (105476 - 124674 != -19198)
										{
											continue;
										}
										GUI.BeginGroup(new Rect(0.5f * this.T45cCyVhtgd - (float)350, (float)724, (float)850, (float)200));
										if (9020 - 193896 != -184876)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.odScfm5CIwr);
										if (110055 - 485002 != -374947)
										{
											continue;
										}
										eMissionGuiType eMissionGuiType10 = this.mType;
										if (265831 - 563169 == -297337)
										{
											continue;
										}
										if (eMissionGuiType10 == eMissionGuiType.guild)
										{
											if (130664 - 119175 == 11490)
											{
												continue;
											}
											GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Red Panda", this.U5ecfjlQCnv);
											if (200960 - 463735 != -262775)
											{
												continue;
											}
										}
										else if (eMissionGuiType10 == eMissionGuiType.town)
										{
											if (76670 - 32818 == 43853)
											{
												continue;
											}
											GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Skunk", this.U5ecfjlQCnv);
											if (65919 - 72408 == -6488)
											{
												continue;
											}
										}
										else if (eMissionGuiType10 == eMissionGuiType.arena)
										{
											if (222121 - 315296 == -93174)
											{
												continue;
											}
											GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Leopard", this.U5ecfjlQCnv);
											if (166712 - 251986 != -85274)
											{
												continue;
											}
										}
										else if (eMissionGuiType10 == eMissionGuiType.dungeon)
										{
											if (131463 - 548115 != -416652)
											{
												continue;
											}
											int mGameCode3 = Game.mGameCode;
											if (146154 - 284478 != -138324)
											{
												continue;
											}
											if (mGameCode3 == 32)
											{
												if (211222 - 278147 == -66924)
												{
													continue;
												}
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Penne", this.U5ecfjlQCnv);
												if (9910 - 186766 == -176855)
												{
													continue;
												}
											}
											else if (mGameCode3 == 34)
											{
												if (8606 - 397754 == -389147)
												{
													continue;
												}
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Liza", this.U5ecfjlQCnv);
												if (205830 - 246083 != -40253)
												{
													continue;
												}
											}
											else if (mGameCode3 == 33)
											{
												if (55663 - 380695 == -325031)
												{
													continue;
												}
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "Guibo", this.U5ecfjlQCnv);
												if (61103 - 534713 == -473609)
												{
													continue;
												}
											}
											else if (mGameCode3 == 35)
											{
												if (192235 - 420915 == -228679)
												{
													continue;
												}
												GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), "GallonBot", this.U5ecfjlQCnv);
												if (111368 - 396929 == -285560)
												{
													continue;
												}
											}
										}
										GUI.Label(new Rect((float)120, (float)90, (float)600, (float)100), Stringf.timed(this.JRecfAH6Mmw, num), this.GAucfoKnRxs);
										if (194315 - 448688 != -254373)
										{
											continue;
										}
										GUI.EndGroup();
										if (165950 - 408710 != -242760)
										{
											continue;
										}
										break;
									}
									else if (num <= 2.5f)
									{
										if (168765 - 595425 != -426660)
										{
											continue;
										}
										this.NQ8cfC229OA = Mathf.SmoothStep((float)0, (float)1, (float)2 * (num - (float)2));
										if (296606 - 279681 == 16926)
										{
											continue;
										}
										this.RenderNPC();
										if (263905 - 472577 != -208672)
										{
											continue;
										}
										break;
									}
									else
									{
										Game.mGameState = eGameState.Normal;
										if (253987 - 377153 == -123165)
										{
											continue;
										}
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (219585 - 318552 == -98966)
										{
											continue;
										}
										gameGui.enabled = true;
										if (27687 - 389618 == -361930)
										{
											continue;
										}
										this.HeGcCkg9Cyt = eMissionState.disabled;
										if (24731 - 1058 == 23674)
										{
											continue;
										}
										Chat.ClearChatMode(eChatMode.mission);
										if (53465 - 554091 == -500625)
										{
											continue;
										}
										this.enabled = false;
										if (26141 - 462854 != -436712)
										{
											break;
										}
										continue;
									}
								}
								GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)1024, (float)0, (float)1024, (float)1024), this.zpCcM1sSJB3);
								if (236265 - 411203 != -174937)
								{
									GUI.BeginGroup(new Rect(this.T45cCyVhtgd - (float)1015, (float)0, (float)1015, (float)1024));
									if (5686 - 100296 == -94610)
									{
										eMissionGuiType eMissionGuiType11 = this.mType;
										if (238256 - 67532 != 170725)
										{
											if (eMissionGuiType11 == eMissionGuiType.guild)
											{
												if (90154 - 581690 == -491535)
												{
													continue;
												}
												this.RenderGuildMissionList(false);
												if (57969 - 33317 == 24653)
												{
													continue;
												}
												this.RenderRecordBar();
												if (132916 - 593341 == -460424)
												{
													continue;
												}
											}
											else if (eMissionGuiType11 == eMissionGuiType.town)
											{
												if (166256 - 367402 == -201145)
												{
													continue;
												}
												this.RenderTownMissionList(false);
												if (39495 - 200578 == -161082)
												{
													continue;
												}
												this.RenderTownRecordBar();
												if (17445 - 412668 != -395223)
												{
													continue;
												}
											}
											else if (eMissionGuiType11 == eMissionGuiType.arena)
											{
												if (93649 - 204843 == -111193)
												{
													continue;
												}
												this.RenderPVPArenaList(false);
												if (234729 - 503408 == -268678)
												{
													continue;
												}
												this.RenderArenaRecordBar();
												if (272566 - 174621 != 97945)
												{
													continue;
												}
											}
											if (data.player <= 6)
											{
												if (16541 - 189858 != -173317)
												{
													continue;
												}
												if (this.jRIcMpVcPPy)
												{
													if (156874 - 226540 == -69665)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)512, (float)60, (float)434, (float)285), this.jRIcMpVcPPy);
													if (18723 - 234998 == -216274)
													{
														continue;
													}
												}
												GUI.DrawTexture(new Rect((float)484, (float)345, (float)421, (float)50), this.tXfcMbSmHvR);
												if (152084 - 221019 == -68934)
												{
													continue;
												}
											}
											else
											{
												GUI.BeginGroup(new Rect((float)512, (float)60, (float)434, (float)45));
												if (53984 - 346961 == -292976)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)0, (float)0, (float)434, (float)285), this.jRIcMpVcPPy);
												if (269201 - 155706 != 113495)
												{
													continue;
												}
												GUI.EndGroup();
												if (289503 - 496564 != -207061)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)484, (float)100, (float)421, (float)50), this.tXfcMbSmHvR);
												if (94244 - 565135 != -470891)
												{
													continue;
												}
											}
											GUI.EndGroup();
											if (25083 - 87224 == -62141)
											{
												this.RenderMatchBar(this.HeGcCkg9Cyt == eMissionState.matchFound);
												if (181647 - 417413 != -235765)
												{
													this.RenderChatBar();
													if (261709 - 183623 != 78087)
													{
														this.RenderNPC();
														if (232889 - 309355 != -76465)
														{
															if (this.HeGcCkg9Cyt != eMissionState.matchFound)
															{
																break;
															}
															if (17671 - 44162 != -26490)
															{
																if (this.L4rcCAGc8mu <= Time.time)
																{
																	if (141633 - 501527 == -359893)
																	{
																		continue;
																	}
																	if (this.aoRcffyBoam >= 0)
																	{
																		if (16967 - 355392 == -338424)
																		{
																			continue;
																		}
																		if (this.aoRcffyBoam != 0)
																		{
																			if (279229 - 124496 != 154733)
																			{
																				continue;
																			}
																			Chat.SubmitChat("none", "Arena starts in: " + this.aoRcffyBoam, eChatType.system, eChatMode.mission);
																			if (232411 - 68196 != 164215)
																			{
																				continue;
																			}
																			this.L4rcCAGc8mu = Time.time + (float)1;
																			if (180048 - 468518 != -288470)
																			{
																				continue;
																			}
																			this.aoRcffyBoam--;
																			if (104733 - 528283 == -423549)
																			{
																				continue;
																			}
																			if (this.wWocfEaARRv)
																			{
																				if (165728 - 109573 == 56156)
																				{
																					continue;
																				}
																				this.audio.PlayOneShot(this.wWocfEaARRv);
																				if (159180 - 198638 != -39458)
																				{
																					continue;
																				}
																			}
																		}
																		else if (this.aoRcffyBoam == 0)
																		{
																			if (20119 - 141648 == -121528)
																			{
																				continue;
																			}
																			if (this.yHQcMX8ErSG)
																			{
																				if (277261 - 384928 == -107666)
																				{
																					continue;
																				}
																				Chat.SubmitChat("none", "Arena is starting advance mode!", eChatType.system, eChatMode.mission);
																				if (895 - 97982 != -97087)
																				{
																					continue;
																				}
																			}
																			if (PlayerData.UID == Game.mNextGameId)
																			{
																				if (137212 - 247965 == -110752)
																				{
																					continue;
																				}
																				this.StartPvpArena();
																				if (77801 - 311136 == -233334)
																				{
																					continue;
																				}
																			}
																			this.aoRcffyBoam = -2;
																			if (164910 - 488090 != -323180)
																			{
																				continue;
																			}
																		}
																	}
																}
																if (this.aoRcffyBoam != -2)
																{
																	break;
																}
																if (9809 - 182906 != -173096)
																{
																	if (Time.time < this.L4rcCAGc8mu + (float)3)
																	{
																		break;
																	}
																	if (70490 - 455382 == -384892)
																	{
																		if (this.ST5cM6mrbBP == PlayerData.UID)
																		{
																			if (189665 - 401754 != -212089)
																			{
																				continue;
																			}
																			this.HeGcCkg9Cyt = eMissionState.createTeam;
																			if (244633 - 431701 == -187067)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.HeGcCkg9Cyt = eMissionState.joinTeam;
																			if (13151 - 496180 == -483028)
																			{
																				continue;
																			}
																		}
																		Chat.SubmitChat("none", "Match has been canceled!", eChatType.system, eChatMode.mission);
																		if (134970 - 414010 == -279040)
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

	// Token: 0x06006232 RID: 25138 RVA: 0x00D8CE4C File Offset: 0x00D8B04C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitNPC()
	{
		if (49492 - 299793 != -250300)
		{
		}
		for (;;)
		{
			this.odScfm5CIwr = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (254935 - 111658 != 143278)
			{
				this.U5ecfjlQCnv = new GUIStyle();
				if (202861 - 97708 != 105154)
				{
					this.U5ecfjlQCnv.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (56643 - 152297 != -95653)
					{
						this.U5ecfjlQCnv.normal.textColor = new Color(0.25f, 0.22f, 0.2f, (float)1);
						if (288906 - 277498 == 11408)
						{
							this.U5ecfjlQCnv.alignment = TextAnchor.UpperLeft;
							if (239365 - 297463 == -58098)
							{
								this.GAucfoKnRxs = new GUIStyle();
								if (288707 - 99008 != 189700)
								{
									this.GAucfoKnRxs.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (65152 - 98168 != -33015)
									{
										this.GAucfoKnRxs.alignment = TextAnchor.UpperLeft;
										if (208500 - 151316 == 57184)
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

	// Token: 0x06006233 RID: 25139 RVA: 0x00D8D010 File Offset: 0x00D8B210
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetNPC()
	{
		if (162077 - 122401 != 39676)
		{
		}
		for (;;)
		{
			int num = 0;
			if (145808 - 309572 != -163763)
			{
				int num2 = 0;
				if (76040 - 224787 != -148746)
				{
					int num3 = 0;
					if (197570 - 569951 != -372380)
					{
						eMissionGuiType eMissionGuiType = this.mType;
						if (68702 - 107773 == -39071)
						{
							if (eMissionGuiType == eMissionGuiType.guild)
							{
								if (82833 - 297133 != -214300)
								{
									continue;
								}
								this.uMXcfDU7uCG = (Texture)Resources.Load("GameGui/Story/Characters/RedPandaSit", typeof(Texture));
								if (250385 - 549576 != -299191)
								{
									continue;
								}
								num = 101 + UnityEngine.Random.Range(0, 5);
								if (269498 - 295023 != -25525)
								{
									continue;
								}
								num2 = 201 + UnityEngine.Random.Range(0, 5);
								if (209241 - 339437 == -130195)
								{
									continue;
								}
								num3 = 301 + UnityEngine.Random.Range(0, 5);
								if (147175 - 382665 != -235490)
								{
									continue;
								}
								int mGameCode = Game.mGameCode;
								if (126856 - 392106 != -265250)
								{
									continue;
								}
								if (mGameCode == 30)
								{
									if (214234 - 508461 == -294226)
									{
										continue;
									}
									if (PlayerData.SLv > 14)
									{
										if (73661 - 24247 == 49415)
										{
											continue;
										}
										num = 111 + UnityEngine.Random.Range(0, 5);
										if (199124 - 173684 == 25441)
										{
											continue;
										}
									}
								}
								else if (mGameCode == 32)
								{
									if (46599 - 498502 != -451903)
									{
										continue;
									}
									if (PlayerData.SLv > 28)
									{
										if (232399 - 597477 == -365077)
										{
											continue;
										}
										num = 111 + UnityEngine.Random.Range(0, 5);
										if (279263 - 399855 != -120592)
										{
											continue;
										}
									}
								}
								else if (mGameCode == 33)
								{
									if (255494 - 163680 == 91815)
									{
										continue;
									}
									if (PlayerData.SLv > 42)
									{
										if (147627 - 324163 == -176535)
										{
											continue;
										}
										num = 111 + UnityEngine.Random.Range(0, 5);
										if (285922 - 154813 == 131110)
										{
											continue;
										}
									}
								}
								else if (mGameCode == 34)
								{
									if (133523 - 241852 != -108329)
									{
										continue;
									}
									if (PlayerData.SLv > 56)
									{
										if (11990 - 598290 == -586299)
										{
											continue;
										}
										num = 111 + UnityEngine.Random.Range(0, 5);
										if (171444 - 156929 == 14516)
										{
											continue;
										}
									}
								}
								else if (mGameCode == 35)
								{
									if (166622 - 281328 != -114706)
									{
										continue;
									}
									if (PlayerData.SLv > 70)
									{
										if (183079 - 251495 != -68416)
										{
											continue;
										}
										num = 111 + UnityEngine.Random.Range(0, 5);
										if (266522 - 406063 == -139540)
										{
											continue;
										}
									}
								}
							}
							else if (eMissionGuiType == eMissionGuiType.town)
							{
								if (157926 - 44820 != 113106)
								{
									continue;
								}
								this.uMXcfDU7uCG = (Texture)Resources.Load("GameGui/Story/Characters/Skunk", typeof(Texture));
								if (34984 - 315144 != -280160)
								{
									continue;
								}
								num = 401 + UnityEngine.Random.Range(0, 5);
								if (254236 - 40813 == 213424)
								{
									continue;
								}
								num2 = 501 + UnityEngine.Random.Range(0, 5);
								if (151760 - 485102 == -333341)
								{
									continue;
								}
								num3 = 601 + UnityEngine.Random.Range(0, 5);
								if (97999 - 490521 != -392522)
								{
									continue;
								}
							}
							else if (eMissionGuiType == eMissionGuiType.arena)
							{
								if (30584 - 175402 != -144818)
								{
									continue;
								}
								this.uMXcfDU7uCG = (Texture)Resources.Load("GameGui/Story/Characters/Leopard", typeof(Texture));
								if (1188 - 495666 != -494478)
								{
									continue;
								}
								num = 701 + UnityEngine.Random.Range(0, 5);
								if (68606 - 91210 == -22603)
								{
									continue;
								}
								num2 = 801 + UnityEngine.Random.Range(0, 5);
								if (256140 - 438936 == -182795)
								{
									continue;
								}
								num3 = 901 + UnityEngine.Random.Range(0, 5);
								if (190466 - 553335 != -362869)
								{
									continue;
								}
							}
							else if (eMissionGuiType == eMissionGuiType.dungeon)
							{
								if (263470 - 293629 == -30158)
								{
									continue;
								}
								int mGameCode2 = Game.mGameCode;
								if (184412 - 520110 == -335697)
								{
									continue;
								}
								if (mGameCode2 == 34)
								{
									if (35591 - 258958 != -223367)
									{
										continue;
									}
									this.uMXcfDU7uCG = (Texture)Resources.Load("GameGui/Story/Characters/Lizard", typeof(Texture));
									if (161760 - 256873 != -95113)
									{
										continue;
									}
									this.P5icf9iNE46 = Language.getMessage("MissionGui", 1100);
									if (177597 - 199955 != -22358)
									{
										continue;
									}
									num = 1101 + UnityEngine.Random.Range(0, 5);
									if (19913 - 526106 != -506193)
									{
										continue;
									}
									num2 = 1111 + UnityEngine.Random.Range(0, 5);
									if (246101 - 120351 == 125751)
									{
										continue;
									}
									num3 = 1121 + UnityEngine.Random.Range(0, 5);
									if (203185 - 267969 == -64783)
									{
										continue;
									}
								}
								else if (mGameCode2 == 32)
								{
									if (55250 - 353619 != -298369)
									{
										continue;
									}
									this.uMXcfDU7uCG = (Texture)Resources.Load("GameGui/Story/Characters/IcePenguin", typeof(Texture));
									if (245748 - 496837 == -251088)
									{
										continue;
									}
									this.P5icf9iNE46 = Language.getMessage("MissionGui", 1200);
									if (286478 - 304190 == -17711)
									{
										continue;
									}
									num = 1201 + UnityEngine.Random.Range(0, 5);
									if (26811 - 192277 != -165466)
									{
										continue;
									}
									num2 = 1211 + UnityEngine.Random.Range(0, 5);
									if (261403 - 453358 != -191955)
									{
										continue;
									}
									num3 = 1221 + UnityEngine.Random.Range(0, 5);
									if (134284 - 98045 != 36239)
									{
										continue;
									}
								}
								else if (mGameCode2 == 33)
								{
									if (197424 - 254209 != -56785)
									{
										continue;
									}
									this.uMXcfDU7uCG = (Texture)Resources.Load("GameGui/Story/Characters/Turtle1", typeof(Texture));
									if (200449 - 456421 != -255972)
									{
										continue;
									}
									this.P5icf9iNE46 = Language.getMessage("MissionGui", 1300);
									if (271881 - 88145 == 183737)
									{
										continue;
									}
									num = 1301;
									if (297569 - 72309 == 225261)
									{
										continue;
									}
									num2 = 1311;
									if (79151 - 504996 != -425845)
									{
										continue;
									}
									num3 = 1321;
									if (279111 - 589814 == -310702)
									{
										continue;
									}
								}
								else if (mGameCode2 == 35)
								{
									if (154494 - 25560 != 128934)
									{
										continue;
									}
									this.uMXcfDU7uCG = (Texture)Resources.Load("GameGui/Story/Characters/GallonBot", typeof(Texture));
									if (20621 - 141455 != -120834)
									{
										continue;
									}
									this.P5icf9iNE46 = Language.getMessage("MissionGui", 1600);
									if (117147 - 422482 == -305334)
									{
										continue;
									}
									num = 1601 + UnityEngine.Random.Range(0, 5);
									if (241063 - 47128 == 193936)
									{
										continue;
									}
									num2 = 1611 + UnityEngine.Random.Range(0, 5);
									if (14921 - 246842 != -231921)
									{
										continue;
									}
									num3 = 1621 + UnityEngine.Random.Range(0, 5);
									if (214143 - 239903 != -25760)
									{
										continue;
									}
								}
							}
							this.oR2cfkegSEs = Language.getMessage("MissionGui", num);
							if (140487 - 83844 == 56643)
							{
								this.gxAcfFSFYeg = Language.getMessage("MissionGui", num2);
								if (33732 - 286170 == -252438)
								{
									this.JRecfAH6Mmw = Language.getMessage("MissionGui", num3);
									if (230443 - 373010 != -142566)
									{
										if (PlayerPrefs.GetInt("nvoice", 1) != 0)
										{
											if (75030 - 404423 == -329392)
											{
												continue;
											}
											if (num > 0)
											{
												if (20530 - 234686 == -214155)
												{
													continue;
												}
												this.VmVcfWMX5S0 = (AudioClip)Resources.Load("Sound/Voice/mission" + num, typeof(AudioClip));
												if (6421 - 144991 != -138570)
												{
													continue;
												}
											}
											if (num2 > 0)
											{
												if (210529 - 233595 == -23065)
												{
													continue;
												}
												this.c9IcfuJyH6q = (AudioClip)Resources.Load("Sound/Voice/mission" + num2, typeof(AudioClip));
												if (199326 - 112392 != 86934)
												{
													continue;
												}
											}
											if (num3 > 0)
											{
												if (281369 - 529028 == -247658)
												{
													continue;
												}
												this.JNXcfyUr8lP = (AudioClip)Resources.Load("Sound/Voice/mission" + num3, typeof(AudioClip));
												if (219845 - 362267 == -142421)
												{
													continue;
												}
											}
										}
										this.iYccfVj7y74 = false;
										if (70265 - 184991 == -114726)
										{
											this.slncfhR4sj5 = false;
											if (145029 - 562088 != -417058)
											{
												this.klAcfKE2Gsf = false;
												if (125435 - 1778 == 123657)
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

	// Token: 0x06006234 RID: 25140 RVA: 0x00D8DC2C File Offset: 0x00D8BE2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderNPC()
	{
		if (144777 - 469864 != -325086)
		{
		}
		for (;;)
		{
			if (!this.uMXcfDU7uCG)
			{
				if (198086 - 327650 != -129563)
				{
					break;
				}
			}
			else
			{
				eMissionGuiType eMissionGuiType = this.mType;
				if (46106 - 475852 == -429746)
				{
					if (eMissionGuiType == eMissionGuiType.guild)
					{
						if (62516 - 496779 != -434262)
						{
							GUI.DrawTexture(new Rect((float)0 - this.NQ8cfC229OA * (float)512, (float)512, (float)512, (float)512), this.uMXcfDU7uCG);
							if (49382 - 508343 != -458960)
							{
								break;
							}
						}
					}
					else if (eMissionGuiType == eMissionGuiType.town)
					{
						if (106756 - 260945 == -154189)
						{
							GUI.DrawTexture(new Rect((float)0 - this.NQ8cfC229OA * (float)326, (float)414, (float)326, (float)610), this.uMXcfDU7uCG);
							if (249027 - 160912 == 88115)
							{
								break;
							}
						}
					}
					else if (eMissionGuiType == eMissionGuiType.arena)
					{
						if (252845 - 9465 == 243380)
						{
							GUI.DrawTexture(new Rect((float)0 - this.NQ8cfC229OA * (float)432, (float)515, (float)432, (float)509), this.uMXcfDU7uCG);
							if (57343 - 598831 != -541487)
							{
								break;
							}
						}
					}
					else
					{
						if (eMissionGuiType != eMissionGuiType.dungeon)
						{
							break;
						}
						if (257191 - 370255 == -113064)
						{
							GUI.DrawTexture(new Rect((float)0 - this.NQ8cfC229OA * (float)this.uMXcfDU7uCG.width, (float)(1024 - this.uMXcfDU7uCG.height), (float)this.uMXcfDU7uCG.width, (float)this.uMXcfDU7uCG.height), this.uMXcfDU7uCG);
							if (258215 - 460987 != -202771)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006235 RID: 25141 RVA: 0x00D8DE9C File Offset: 0x00D8C09C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playGreetingAudio()
	{
		if (151066 - 273680 != -122613)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (128337 - 399651 != -271313)
				{
					break;
				}
			}
			else
			{
				if (this.iYccfVj7y74)
				{
					break;
				}
				if (15709 - 293243 == -277534)
				{
					this.iYccfVj7y74 = true;
					if (137832 - 168273 == -30441)
					{
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							break;
						}
						if (254012 - 158722 == 95290)
						{
							if (!this.VmVcfWMX5S0)
							{
								break;
							}
							if (636 - 502158 != -501521)
							{
								this.audio.PlayOneShot(this.VmVcfWMX5S0);
								if (6496 - 216796 != -210299)
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

	// Token: 0x06006236 RID: 25142 RVA: 0x00D8DFC8 File Offset: 0x00D8C1C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playStartingAudio()
	{
		if (112462 - 305003 != -192540)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (111485 - 448450 == -336965)
				{
					break;
				}
			}
			else
			{
				if (this.slncfhR4sj5)
				{
					break;
				}
				if (229539 - 334610 != -105070)
				{
					this.slncfhR4sj5 = true;
					if (200790 - 349156 == -148366)
					{
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							break;
						}
						if (130029 - 297951 != -167921)
						{
							if (!this.c9IcfuJyH6q)
							{
								break;
							}
							if (220388 - 282425 != -62036)
							{
								this.audio.PlayOneShot(this.c9IcfuJyH6q);
								if (159860 - 413985 != -254124)
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

	// Token: 0x06006237 RID: 25143 RVA: 0x00D8E0F4 File Offset: 0x00D8C2F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void playCancelAudio()
	{
		if (144215 - 45636 != 98579)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (113021 - 359941 == -246920)
				{
					break;
				}
			}
			else
			{
				if (this.klAcfKE2Gsf)
				{
					break;
				}
				if (164404 - 292716 != -128311)
				{
					this.klAcfKE2Gsf = true;
					if (24236 - 480136 != -455899)
					{
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							break;
						}
						if (131490 - 54587 == 76903)
						{
							if (!this.JNXcfyUr8lP)
							{
								break;
							}
							if (10093 - 516384 != -506290)
							{
								this.audio.PlayOneShot(this.JNXcfyUr8lP);
								if (196385 - 173092 == 23293)
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

	// Token: 0x06006238 RID: 25144 RVA: 0x00D8E220 File Offset: 0x00D8C420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGuildMissionList(bool isButton)
	{
		if (204429 - 351119 != -146690)
		{
		}
		for (;;)
		{
			IL_349F:
			if (this.V5wcCFOg9QT == eMissionSelectMode.mission)
			{
				if (128531 - 195677 != -67146)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)155, (float)62, (float)76, (float)31), this.VTwcMM157vy.hover.background);
				if (220526 - 378359 != -157833)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (134445 - 436496 == -302050)
				{
					continue;
				}
				if (GUI.Button(new Rect((float)155, (float)62, (float)76, (float)31), string.Empty, this.VTwcMM157vy))
				{
					if (18404 - 420530 == -402125)
					{
						continue;
					}
					this.V5wcCFOg9QT = eMissionSelectMode.mission;
					if (234419 - 232180 != 2239)
					{
						continue;
					}
					this.ResetMissionDes();
					if (77394 - 466923 != -389529)
					{
						continue;
					}
					if (this.GGacC9TpOAR < Time.time - (float)12)
					{
						if (63170 - 108707 == -45536)
						{
							continue;
						}
						this.GGacC9TpOAR = Time.time;
						if (20787 - 64246 == -43458)
						{
							continue;
						}
						this.ListMission(0);
						if (25655 - 554775 == -529119)
						{
							continue;
						}
					}
					this.audio.PlayOneShot(this.phJcfNLcQPB);
					if (72447 - 30725 != 41722)
					{
						continue;
					}
				}
			}
			if (this.V5wcCFOg9QT == eMissionSelectMode.area)
			{
				if (250910 - 282026 == -31115)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)240, (float)62, (float)68, (float)31), this.YbycMf7ENWK.hover.background);
				if (130787 - 215454 != -84667)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (93031 - 580363 != -487332)
				{
					continue;
				}
				if (this.acHcCWIWCnx < Time.time - (float)3)
				{
					if (15703 - 212474 != -196771)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)240, (float)62, (float)68, (float)31), string.Empty, this.YbycMf7ENWK))
					{
						if (8446 - 133663 == -125216)
						{
							continue;
						}
						this.V5wcCFOg9QT = eMissionSelectMode.area;
						if (159615 - 91633 == 67983)
						{
							continue;
						}
						if (this.acHcCWIWCnx < Time.time - (float)1)
						{
							if (88675 - 239363 == -150687)
							{
								continue;
							}
							this.ResetMissionDes();
							if (150735 - 341900 != -191165)
							{
								continue;
							}
							this.acHcCWIWCnx = Time.time;
							if (44053 - 375323 != -331270)
							{
								continue;
							}
							this.ListMission(1);
							if (22954 - 325927 == -302972)
							{
								continue;
							}
						}
						this.audio.PlayOneShot(this.phJcfNLcQPB);
						if (213773 - 51641 == 162133)
						{
							continue;
						}
					}
				}
			}
			if (this.V5wcCFOg9QT == eMissionSelectMode.guild)
			{
				if (85496 - 388183 != -302687)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)314, (float)62, (float)68, (float)31), this.Nv1cML8YUFd.hover.background);
				if (126147 - 312577 != -186430)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (214937 - 580851 != -365914)
				{
					continue;
				}
				if (this.acHcCWIWCnx < Time.time - (float)3)
				{
					if (18884 - 545589 != -526705)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)314, (float)62, (float)68, (float)31), string.Empty, this.Nv1cML8YUFd))
					{
						if (100464 - 409198 != -308734)
						{
							continue;
						}
						this.V5wcCFOg9QT = eMissionSelectMode.guild;
						if (288330 - 273038 == 15293)
						{
							continue;
						}
						if (this.acHcCWIWCnx < Time.time - (float)1)
						{
							if (137001 - 499616 == -362614)
							{
								continue;
							}
							this.ResetMissionDes();
							if (254185 - 547154 == -292968)
							{
								continue;
							}
							this.acHcCWIWCnx = Time.time;
							if (265692 - 17228 == 248465)
							{
								continue;
							}
							this.ListMission(2);
							if (239546 - 536611 == -297064)
							{
								continue;
							}
						}
						this.audio.PlayOneShot(this.phJcfNLcQPB);
						if (59457 - 419058 == -359600)
						{
							continue;
						}
					}
				}
			}
			if (215308 - 234029 == -18721)
			{
				if (123285 - 19553 == 103732)
				{
					if (145878 - 426490 == -280612)
					{
						if (127315 - 480138 != -352822)
						{
							eMissionSelectMode v5wcCFOg9QT = this.V5wcCFOg9QT;
							if (283697 - 443762 == -160065)
							{
								if (v5wcCFOg9QT == eMissionSelectMode.mission)
								{
									if (122199 - 108440 == 13759)
									{
										if (isButton)
										{
											if (287374 - 399213 != -111838)
											{
												if (this.BsAcChUqUV7 == 1)
												{
													if (241302 - 577273 != -335971)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)94, (float)80, (float)67), this.o8xcMwqaerl.hover.background);
													if (217926 - 146484 != 71442)
													{
														continue;
													}
												}
												else
												{
													if (Game.mGameCode != 30)
													{
														if (85972 - 164890 != -78918)
														{
															continue;
														}
														if (Game.mGameCode == 31)
														{
															if (41564 - 309002 == -267437)
															{
																continue;
															}
														}
														else
														{
															GUI.DrawTexture(new Rect((float)45, (float)94, (float)80, (float)67), this.o8xcMwqaerl.active.background);
															if (188982 - 529318 != -340335)
															{
																goto IL_1922;
															}
															continue;
														}
													}
													if (GUI.Button(new Rect((float)45, (float)94, (float)80, (float)67), string.Empty, this.o8xcMwqaerl))
													{
														if (289342 - 250230 == 39113)
														{
															continue;
														}
														this.BsAcChUqUV7 = 1;
														if (241635 - 15714 == 225922)
														{
															continue;
														}
													}
												}
												IL_1922:
												if (this.BsAcChUqUV7 == 2)
												{
													if (259801 - 231677 == 28125)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)151, (float)80, (float)53), this.FBScMU3slIB.hover.background);
													if (67544 - 279946 == -212401)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 7)
													{
														if (154841 - 393474 != -238633)
														{
															continue;
														}
														if (Game.mGameCode != 30)
														{
															if (257884 - 199160 == 58725)
															{
																continue;
															}
															if (Game.mGameCode != 31)
															{
																goto IL_16FE;
															}
															if (101296 - 576875 != -475579)
															{
																continue;
															}
														}
														if (GUI.Button(new Rect((float)45, (float)151, (float)80, (float)53), string.Empty, this.FBScMU3slIB))
														{
															if (122829 - 436511 == -313681)
															{
																continue;
															}
															this.BsAcChUqUV7 = 2;
															if (92572 - 384114 == -291541)
															{
																continue;
															}
														}
														goto IL_E6A;
													}
													IL_16FE:
													GUI.DrawTexture(new Rect((float)45, (float)151, (float)80, (float)53), this.FBScMU3slIB.active.background);
													if (150884 - 135854 != 15030)
													{
														continue;
													}
												}
												IL_E6A:
												if (this.BsAcChUqUV7 == 3)
												{
													if (257889 - 200838 != 57051)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)190, (float)80, (float)55), this.CGBcMNNDdjq.hover.background);
													if (175861 - 486414 != -310553)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 14)
													{
														if (170940 - 327552 != -156611)
														{
															if (Game.mGameCode != 32)
															{
																if (140257 - 51057 == 89201)
																{
																	continue;
																}
																if (Game.mGameCode != 31)
																{
																	goto IL_607;
																}
																if (40342 - 96013 != -55671)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)45, (float)190, (float)80, (float)55), string.Empty, this.CGBcMNNDdjq))
															{
																if (108558 - 58320 == 50239)
																{
																	continue;
																}
																this.BsAcChUqUV7 = 3;
																if (96207 - 58134 != 38073)
																{
																	continue;
																}
															}
															goto IL_3357;
														}
														continue;
													}
													IL_607:
													GUI.DrawTexture(new Rect((float)45, (float)190, (float)80, (float)55), this.CGBcMNNDdjq.active.background);
													if (81055 - 488684 == -407628)
													{
														continue;
													}
												}
												IL_3357:
												if (this.BsAcChUqUV7 == 4)
												{
													if (219386 - 396743 != -177357)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)232, (float)80, (float)47), this.P1JcMElT010.hover.background);
													if (266494 - 573079 == -306584)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 21)
													{
														if (96631 - 573221 != -476589)
														{
															if (Game.mGameCode != 32)
															{
																if (39073 - 507297 == -468223)
																{
																	continue;
																}
																if (Game.mGameCode != 31)
																{
																	goto IL_4BB;
																}
																if (4994 - 360406 != -355412)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)45, (float)232, (float)80, (float)47), string.Empty, this.P1JcMElT010))
															{
																if (257715 - 468607 != -210892)
																{
																	continue;
																}
																this.BsAcChUqUV7 = 4;
																if (145608 - 570962 == -425353)
																{
																	continue;
																}
															}
															goto IL_1F0;
														}
														continue;
													}
													IL_4BB:
													GUI.DrawTexture(new Rect((float)45, (float)232, (float)80, (float)47), this.P1JcMElT010.active.background);
													if (29081 - 228767 != -199686)
													{
														continue;
													}
												}
												IL_1F0:
												if (this.BsAcChUqUV7 == 5)
												{
													if (3200 - 365961 == -362760)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)272, (float)80, (float)51), this.pdLcMP9YIL2.hover.background);
													if (296267 - 92434 == 203834)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 28)
													{
														if (269712 - 370874 != -101162)
														{
															continue;
														}
														if (Game.mGameCode != 33)
														{
															if (137617 - 409790 == -272172)
															{
																continue;
															}
															if (Game.mGameCode != 31)
															{
																goto IL_14A6;
															}
															if (71609 - 146797 != -75188)
															{
																continue;
															}
														}
														if (GUI.Button(new Rect((float)45, (float)272, (float)80, (float)51), string.Empty, this.pdLcMP9YIL2))
														{
															if (107926 - 440116 == -332189)
															{
																continue;
															}
															this.BsAcChUqUV7 = 5;
															if (102961 - 480330 != -377369)
															{
																continue;
															}
														}
														goto IL_E90;
													}
													IL_14A6:
													GUI.DrawTexture(new Rect((float)45, (float)272, (float)80, (float)51), this.pdLcMP9YIL2.active.background);
													if (102027 - 531398 == -429370)
													{
														continue;
													}
												}
												IL_E90:
												if (this.BsAcChUqUV7 == 6)
												{
													if (230247 - 39834 != 190413)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)314, (float)80, (float)45), this.XLTcMSXe5u8.hover.background);
													if (184806 - 327497 == -142690)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 35)
													{
														if (161411 - 321464 != -160052)
														{
															if (Game.mGameCode != 33)
															{
																if (250661 - 439363 != -188702)
																{
																	continue;
																}
																if (Game.mGameCode != 31)
																{
																	goto IL_B46;
																}
																if (210078 - 169062 == 41017)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)45, (float)314, (float)80, (float)45), string.Empty, this.XLTcMSXe5u8))
															{
																if (268828 - 276190 == -7361)
																{
																	continue;
																}
																this.BsAcChUqUV7 = 6;
																if (224705 - 246793 == -22087)
																{
																	continue;
																}
															}
															goto IL_3170;
														}
														continue;
													}
													IL_B46:
													GUI.DrawTexture(new Rect((float)45, (float)314, (float)80, (float)45), this.XLTcMSXe5u8.active.background);
													if (199062 - 550664 != -351602)
													{
														continue;
													}
												}
												IL_3170:
												if (this.BsAcChUqUV7 == 7)
												{
													if (291455 - 448947 != -157492)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)354, (float)80, (float)50), this.XgLcMBWrSLW.hover.background);
													if (155841 - 502765 != -346924)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 42)
													{
														if (77674 - 93209 != -15534)
														{
															if (Game.mGameCode != 34)
															{
																if (284357 - 565539 != -281182)
																{
																	continue;
																}
																if (Game.mGameCode != 31)
																{
																	goto IL_21B;
																}
																if (97327 - 353768 != -256441)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)45, (float)354, (float)80, (float)50), string.Empty, this.XgLcMBWrSLW))
															{
																if (138603 - 171425 == -32821)
																{
																	continue;
																}
																this.BsAcChUqUV7 = 7;
																if (44016 - 229411 == -185394)
																{
																	continue;
																}
															}
															goto IL_9E0;
														}
														continue;
													}
													IL_21B:
													GUI.DrawTexture(new Rect((float)45, (float)354, (float)80, (float)50), this.XgLcMBWrSLW.active.background);
													if (241797 - 355279 == -113481)
													{
														continue;
													}
												}
												IL_9E0:
												if (this.BsAcChUqUV7 == 8)
												{
													if (157128 - 530213 != -373085)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)397, (float)80, (float)55), this.U29cM02eEv9.hover.background);
													if (187172 - 415037 != -227865)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 49)
													{
														if (167155 - 499616 != -332461)
														{
															continue;
														}
														if (Game.mGameCode != 34)
														{
															if (111828 - 483751 != -371923)
															{
																continue;
															}
															if (Game.mGameCode != 31)
															{
																goto IL_1233;
															}
															if (40307 - 51756 == -11448)
															{
																continue;
															}
														}
														if (GUI.Button(new Rect((float)45, (float)397, (float)80, (float)55), string.Empty, this.U29cM02eEv9))
														{
															if (155283 - 329486 != -174203)
															{
																continue;
															}
															this.BsAcChUqUV7 = 8;
															if (58242 - 388478 == -330235)
															{
																continue;
															}
														}
														goto IL_1A4E;
													}
													IL_1233:
													GUI.DrawTexture(new Rect((float)45, (float)397, (float)80, (float)55), this.U29cM02eEv9.active.background);
													if (242741 - 238208 != 4533)
													{
														continue;
													}
												}
												IL_1A4E:
												if (this.BsAcChUqUV7 == 9)
												{
													if (246499 - 2959 != 243540)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)447, (float)80, (float)45), this.MTAcM81WKKt.hover.background);
													if (81751 - 192708 == -110956)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 56)
													{
														if (250896 - 311265 != -60368)
														{
															if (Game.mGameCode != 35)
															{
																if (69762 - 85501 == -15738)
																{
																	continue;
																}
																if (Game.mGameCode != 31)
																{
																	goto IL_1B32;
																}
																if (102454 - 195474 != -93020)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)45, (float)447, (float)80, (float)45), string.Empty, this.MTAcM81WKKt))
															{
																if (93207 - 267862 != -174655)
																{
																	continue;
																}
																this.BsAcChUqUV7 = 9;
																if (140626 - 291413 == -150786)
																{
																	continue;
																}
															}
															goto IL_3478;
														}
														continue;
													}
													IL_1B32:
													GUI.DrawTexture(new Rect((float)45, (float)447, (float)80, (float)45), this.MTAcM81WKKt.active.background);
													if (173554 - 561145 == -387590)
													{
														continue;
													}
												}
												IL_3478:
												if (this.BsAcChUqUV7 == 10)
												{
													if (76926 - 56926 == 20001)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)484, (float)80, (float)52), this.IvEcMiJ6Fxm.hover.background);
													if (278424 - 324859 != -46435)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 63)
													{
														if (88584 - 37556 != 51028)
														{
															continue;
														}
														if (Game.mGameCode != 35)
														{
															if (233201 - 114667 == 118535)
															{
																continue;
															}
															if (Game.mGameCode != 31)
															{
																goto IL_26D6;
															}
															if (142246 - 158231 == -15984)
															{
																continue;
															}
														}
														if (GUI.Button(new Rect((float)45, (float)484, (float)80, (float)52), string.Empty, this.IvEcMiJ6Fxm))
														{
															if (265705 - 325181 == -59475)
															{
																continue;
															}
															this.BsAcChUqUV7 = 10;
															if (267456 - 537098 != -269642)
															{
																continue;
															}
														}
														goto IL_15A;
													}
													IL_26D6:
													GUI.DrawTexture(new Rect((float)45, (float)484, (float)80, (float)52), this.IvEcMiJ6Fxm.active.background);
													if (128855 - 223893 != -95038)
													{
														continue;
													}
												}
												IL_15A:
												if (this.BsAcChUqUV7 == 11)
												{
													if (196383 - 253987 != -57604)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)532, (float)80, (float)46), this.huAcMD9Isey.hover.background);
													if (180916 - 359415 == -178498)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 70)
													{
														if (150630 - 51057 != 99574)
														{
															if (Game.mGameCode != 36)
															{
																if (96549 - 371194 == -274644)
																{
																	continue;
																}
																if (Game.mGameCode != 31)
																{
																	goto IL_15A2;
																}
																if (61565 - 287299 != -225734)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)45, (float)532, (float)80, (float)46), string.Empty, this.huAcMD9Isey))
															{
																if (9806 - 273350 != -263544)
																{
																	continue;
																}
																this.BsAcChUqUV7 = 11;
																if (204907 - 203437 != 1470)
																{
																	continue;
																}
															}
															goto IL_1C9;
														}
														continue;
													}
													IL_15A2:
													GUI.DrawTexture(new Rect((float)45, (float)532, (float)80, (float)46), this.huAcMD9Isey.active.background);
													if (99943 - 109165 == -9221)
													{
														continue;
													}
												}
												IL_1C9:
												if (this.BsAcChUqUV7 == 12)
												{
													if (160584 - 347748 == -187163)
													{
														continue;
													}
													GUI.DrawTexture(new Rect((float)45, (float)574, (float)80, (float)44), this.pPVcMmdparU.hover.background);
													if (156146 - 182311 == -26164)
													{
														continue;
													}
												}
												else
												{
													if (PlayerData.SLv > 77)
													{
														if (244113 - 379227 != -135113)
														{
															if (Game.mGameCode != 36)
															{
																if (44727 - 329074 != -284347)
																{
																	continue;
																}
																if (Game.mGameCode != 31)
																{
																	goto IL_1F29;
																}
																if (294950 - 325673 == -30722)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)45, (float)574, (float)80, (float)44), string.Empty, this.pPVcMmdparU))
															{
																if (122802 - 50510 == 72293)
																{
																	continue;
																}
																this.BsAcChUqUV7 = 12;
																if (147578 - 153402 == -5823)
																{
																	continue;
																}
															}
															goto IL_36EB;
														}
														continue;
													}
													IL_1F29:
													GUI.DrawTexture(new Rect((float)45, (float)574, (float)80, (float)44), this.pPVcMmdparU.active.background);
													if (184326 - 360936 == -176609)
													{
														continue;
													}
												}
												IL_36EB:
												if (PlayerData.Rank == 100)
												{
													if (159196 - 184451 == -25254)
													{
														continue;
													}
													if (GUI.Button(new Rect((float)45, (float)614, (float)80, (float)55), string.Empty, this.NvYcMjaPNFr))
													{
														if (264498 - 407829 == -143330)
														{
															continue;
														}
														this.BsAcChUqUV7 = 13;
														if (116629 - 92047 == 24583)
														{
															continue;
														}
													}
												}
												int i = 1;
												if (23346 - 150904 == -127558)
												{
													while (i <= 8)
													{
														MissionClass data;
														if (this.BsAcChUqUV7 <= 12)
														{
															if (261625 - 404343 == -142717)
															{
																goto IL_349F;
															}
															data = MissionData.getData(100 * Mathf.Min(this.BsAcChUqUV7, 9) + 10 * Mathf.Max(this.BsAcChUqUV7 - 9, 0) + i);
															if (34245 - 463131 != -428886)
															{
																goto IL_349F;
															}
														}
														else
														{
															data = MissionData.getData(990 + i);
															if (271161 - 117866 == 153296)
															{
																goto IL_349F;
															}
														}
														int num = (this.BsAcChUqUV7 - 1) * 8 + i;
														if (177735 - 188217 == -10481)
														{
															goto IL_349F;
														}
														if (data.name != "none")
														{
															if (236564 - 23400 == 213165)
															{
																goto IL_349F;
															}
															if (data.slv <= PlayerData.SLv)
															{
																if (228506 - 584798 == -356291)
																{
																	goto IL_349F;
																}
																if (Game.mGameCode != 31)
																{
																	if (262875 - 496021 == -233145)
																	{
																		goto IL_349F;
																	}
																	if (this.BsAcChUqUV7 != 13)
																	{
																		if (236223 - 433183 == -196959)
																		{
																			goto IL_349F;
																		}
																		if (Game.mGameCode == 30)
																		{
																			if (272650 - 448291 == -175640)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 1)
																			{
																				goto IL_1F88;
																			}
																			if (66149 - 366789 != -300640)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 2)
																			{
																				goto IL_1F88;
																			}
																			if (16522 - 386783 == -370260)
																			{
																				goto IL_349F;
																			}
																		}
																		if (Game.mGameCode == 32)
																		{
																			if (50965 - 559376 != -508411)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 3)
																			{
																				goto IL_1F88;
																			}
																			if (245353 - 56194 == 189160)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 4)
																			{
																				goto IL_1F88;
																			}
																			if (69137 - 56281 != 12856)
																			{
																				goto IL_349F;
																			}
																		}
																		if (Game.mGameCode == 33)
																		{
																			if (91991 - 333347 != -241356)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 5)
																			{
																				goto IL_1F88;
																			}
																			if (10088 - 433454 != -423366)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 6)
																			{
																				goto IL_1F88;
																			}
																			if (81320 - 345439 != -264119)
																			{
																				goto IL_349F;
																			}
																		}
																		if (Game.mGameCode == 34)
																		{
																			if (69769 - 210853 != -141084)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 7)
																			{
																				goto IL_1F88;
																			}
																			if (179754 - 544621 != -364867)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 8)
																			{
																				goto IL_1F88;
																			}
																			if (257468 - 218420 == 39049)
																			{
																				goto IL_349F;
																			}
																		}
																		if (Game.mGameCode == 35)
																		{
																			if (125182 - 53119 == 72064)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 9)
																			{
																				goto IL_1F88;
																			}
																			if (224566 - 166449 != 58117)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 10)
																			{
																				goto IL_1F88;
																			}
																			if (31785 - 407888 == -376102)
																			{
																				goto IL_349F;
																			}
																		}
																		if (Game.mGameCode == 36)
																		{
																			if (74229 - 509136 != -434907)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 11)
																			{
																				goto IL_1F88;
																			}
																			if (73273 - 443063 == -369789)
																			{
																				goto IL_349F;
																			}
																			if (this.BsAcChUqUV7 == 12)
																			{
																				if (150286 - 324034 != -173748)
																				{
																					goto IL_349F;
																				}
																				goto IL_1F88;
																			}
																		}
																		GUI.Label(new Rect((float)156, (float)(110 + 60 * i), (float)270, (float)30), "#" + this.BsAcChUqUV7 + "/" + i + "  " + data.name, this.Bo6cMKxjM2x);
																		if (196257 - 339984 == -143726)
																		{
																			goto IL_349F;
																		}
																		if (num < 96)
																		{
																			if (255799 - 424724 == -168924)
																			{
																				goto IL_349F;
																			}
																			GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "[" + this.oTYcM5rfhDM[num] + "/" + this.OkJcMcf7XmO[num] + "] Rank:", this.PEQcMzR3pyj);
																			if (237526 - 189537 != 47990)
																			{
																				if (PlayerData.MissionList[num - 1] > 0)
																				{
																					if (171940 - 516317 == -344376)
																					{
																						goto IL_349F;
																					}
																					int j = 0;
																					if (132813 - 87051 == 45763)
																					{
																						goto IL_349F;
																					}
																					while (j < PlayerData.MissionList[num - 1])
																					{
																						GUI.DrawTexture(new Rect((float)(280 + j * 16), (float)(147 + i * 60), (float)16, (float)16), this.XT8cMRhcF3e);
																						if (283019 - 107378 != 175641)
																						{
																							goto IL_349F;
																						}
																						j++;
																						if (180741 - 295439 == -114697)
																						{
																							goto IL_349F;
																						}
																					}
																					if (277976 - 399255 != -121279)
																					{
																						goto IL_349F;
																					}
																				}
																				goto IL_1461;
																			}
																			goto IL_349F;
																		}
																		else
																		{
																			GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "special mission", this.PEQcMzR3pyj);
																			if (284406 - 434599 != -150193)
																			{
																				goto IL_349F;
																			}
																			goto IL_1461;
																		}
																	}
																}
																IL_1F88:
																if (this.vpEcCKjSAwn == 100 * Mathf.Min(this.BsAcChUqUV7, 9) + 10 * Mathf.Max(this.BsAcChUqUV7 - 9, 0) + i)
																{
																	if (14475 - 285479 == -271003)
																	{
																		goto IL_349F;
																	}
																	GUI.Label(new Rect((float)156, (float)(110 + 60 * i), (float)270, (float)30), "#" + this.BsAcChUqUV7 + "/" + i + "  " + data.name, this.jeMcMVdaOFZ);
																	if (193029 - 286508 != -93479)
																	{
																		goto IL_349F;
																	}
																	if (num < 96)
																	{
																		if (188196 - 438109 == -249912)
																		{
																			goto IL_349F;
																		}
																		GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "[" + this.oTYcM5rfhDM[num] + "/" + this.OkJcMcf7XmO[num] + "] Rank:", this.PEQcMzR3pyj);
																		if (81932 - 88090 == -6157)
																		{
																			goto IL_349F;
																		}
																		if (PlayerData.MissionList[num - 1] > 0)
																		{
																			if (129304 - 298965 != -169661)
																			{
																				goto IL_349F;
																			}
																			int j = 0;
																			if (132136 - 397778 != -265642)
																			{
																				goto IL_349F;
																			}
																			while (j < PlayerData.MissionList[num - 1])
																			{
																				GUI.DrawTexture(new Rect((float)(280 + j * 16), (float)(147 + i * 60), (float)16, (float)16), this.XT8cMRhcF3e);
																				if (2983 - 296946 != -293963)
																				{
																					goto IL_349F;
																				}
																				j++;
																				if (277544 - 415699 == -138154)
																				{
																					goto IL_349F;
																				}
																			}
																			if (86508 - 53879 == 32630)
																			{
																				goto IL_349F;
																			}
																		}
																	}
																	else
																	{
																		GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "special mission", this.PEQcMzR3pyj);
																		if (188183 - 283149 == -94965)
																		{
																			goto IL_349F;
																		}
																	}
																}
																else
																{
																	if (GUI.Button(new Rect((float)156, (float)(110 + 60 * i), (float)270, (float)30), "#" + this.BsAcChUqUV7 + "/" + i + "  " + data.name, this.mu6cMycy0Ne))
																	{
																		if (106430 - 190163 != -83733)
																		{
																			goto IL_349F;
																		}
																		if (this.BsAcChUqUV7 <= 12)
																		{
																			if (110548 - 347627 == -237078)
																			{
																				goto IL_349F;
																			}
																			this.vpEcCKjSAwn = 100 * Mathf.Min(this.BsAcChUqUV7, 9) + 10 * Mathf.Max(this.BsAcChUqUV7 - 9, 0) + i;
																			if (205477 - 215754 != -10277)
																			{
																				goto IL_349F;
																			}
																		}
																		else
																		{
																			this.vpEcCKjSAwn = 990 + i;
																			if (269579 - 563246 == -293666)
																			{
																				goto IL_349F;
																			}
																		}
																		PlayerPrefs.SetInt("lastMission", this.vpEcCKjSAwn);
																		if (189800 - 43475 != 146325)
																		{
																			goto IL_349F;
																		}
																		this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
																		if (254422 - 482248 == -227825)
																		{
																			goto IL_349F;
																		}
																		this.audio.PlayOneShot(this.phJcfNLcQPB);
																		if (136381 - 265056 != -128675)
																		{
																			goto IL_349F;
																		}
																	}
																	if (num < 96)
																	{
																		if (49138 - 200095 != -150957)
																		{
																			goto IL_349F;
																		}
																		GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "[" + this.oTYcM5rfhDM[num] + "/" + this.OkJcMcf7XmO[num] + "] Rank:", this.PEQcMzR3pyj);
																		if (69822 - 227622 != -157800)
																		{
																			goto IL_349F;
																		}
																		if (PlayerData.MissionList[num - 1] > 0)
																		{
																			if (18280 - 370222 != -351942)
																			{
																				goto IL_349F;
																			}
																			int j = 0;
																			if (18806 - 499896 == -481089)
																			{
																				goto IL_349F;
																			}
																			while (j < PlayerData.MissionList[num - 1])
																			{
																				GUI.DrawTexture(new Rect((float)(280 + j * 16), (float)(147 + i * 60), (float)16, (float)16), this.XT8cMRhcF3e);
																				if (51980 - 219776 != -167796)
																				{
																					goto IL_349F;
																				}
																				j++;
																				if (130085 - 356808 != -226723)
																				{
																					goto IL_349F;
																				}
																			}
																			if (159977 - 551451 != -391474)
																			{
																				goto IL_349F;
																			}
																		}
																	}
																	else
																	{
																		GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "special mission", this.PEQcMzR3pyj);
																		if (13657 - 374259 != -360602)
																		{
																			goto IL_349F;
																		}
																	}
																}
															}
														}
														IL_1461:
														i++;
														if (139803 - 21950 != 117853)
														{
															goto IL_349F;
														}
													}
													if (282695 - 531922 == -249227)
													{
														break;
													}
												}
											}
										}
										else
										{
											GUI.DrawTexture(new Rect((float)45, (float)94, (float)80, (float)67), this.o8xcMwqaerl.active.background);
											if (55828 - 1042 != 54787)
											{
												GUI.DrawTexture(new Rect((float)45, (float)151, (float)80, (float)53), this.FBScMU3slIB.active.background);
												if (63754 - 16594 != 47161)
												{
													GUI.DrawTexture(new Rect((float)45, (float)190, (float)80, (float)55), this.CGBcMNNDdjq.active.background);
													if (226159 - 482560 == -256401)
													{
														GUI.DrawTexture(new Rect((float)45, (float)232, (float)80, (float)47), this.P1JcMElT010.active.background);
														if (151645 - 394116 != -242470)
														{
															GUI.DrawTexture(new Rect((float)45, (float)272, (float)80, (float)51), this.pdLcMP9YIL2.active.background);
															if (145196 - 450555 != -305358)
															{
																GUI.DrawTexture(new Rect((float)45, (float)314, (float)80, (float)45), this.XLTcMSXe5u8.active.background);
																if (106930 - 47290 != 59641)
																{
																	GUI.DrawTexture(new Rect((float)45, (float)354, (float)80, (float)50), this.XgLcMBWrSLW.active.background);
																	if (280028 - 187322 != 92707)
																	{
																		GUI.DrawTexture(new Rect((float)45, (float)397, (float)80, (float)55), this.U29cM02eEv9.active.background);
																		if (160472 - 486621 != -326148)
																		{
																			GUI.DrawTexture(new Rect((float)45, (float)447, (float)80, (float)45), this.MTAcM81WKKt.active.background);
																			if (7300 - 565324 == -558024)
																			{
																				GUI.DrawTexture(new Rect((float)45, (float)484, (float)80, (float)52), this.IvEcMiJ6Fxm.active.background);
																				if (80047 - 349676 != -269628)
																				{
																					GUI.DrawTexture(new Rect((float)45, (float)532, (float)80, (float)46), this.huAcMD9Isey.active.background);
																					if (87443 - 288927 == -201484)
																					{
																						GUI.DrawTexture(new Rect((float)45, (float)574, (float)80, (float)44), this.pPVcMmdparU.active.background);
																						if (62463 - 329332 != -266868)
																						{
																							int i = 1;
																							if (184436 - 459332 == -274896)
																							{
																								while (i <= 8)
																								{
																									MissionClass data;
																									if (this.BsAcChUqUV7 <= 12)
																									{
																										if (198970 - 83956 == 115015)
																										{
																											goto IL_349F;
																										}
																										data = MissionData.getData(100 * Mathf.Min(this.BsAcChUqUV7, 9) + 10 * Mathf.Max(this.BsAcChUqUV7 - 9, 0) + i);
																										if (62109 - 494971 == -432861)
																										{
																											goto IL_349F;
																										}
																									}
																									else
																									{
																										data = MissionData.getData(990 + i);
																										if (39406 - 47686 == -8279)
																										{
																											goto IL_349F;
																										}
																									}
																									int num = (this.BsAcChUqUV7 - 1) * 8 + i;
																									if (180268 - 441656 == -261387)
																									{
																										goto IL_349F;
																									}
																									if (data.name != "none")
																									{
																										if (59540 - 25652 == 33889)
																										{
																											goto IL_349F;
																										}
																										if (data.slv <= PlayerData.SLv)
																										{
																											if (160692 - 482003 == -321310)
																											{
																												goto IL_349F;
																											}
																											if (this.vpEcCKjSAwn == 100 * Mathf.Min(this.BsAcChUqUV7, 9) + 10 * Mathf.Max(this.BsAcChUqUV7 - 9, 0) + i)
																											{
																												if (189941 - 505097 == -315155)
																												{
																													goto IL_349F;
																												}
																												GUI.Label(new Rect((float)156, (float)(110 + 60 * i), (float)270, (float)30), "#" + this.BsAcChUqUV7 + "/" + i + "  " + data.name, this.a7KcMhwvE0q);
																												if (203406 - 387273 == -183866)
																												{
																													goto IL_349F;
																												}
																												if (num < 96)
																												{
																													if (198948 - 342884 == -143935)
																													{
																														goto IL_349F;
																													}
																													GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "[" + this.oTYcM5rfhDM[num] + "/" + this.OkJcMcf7XmO[num] + "] Rank:", this.PEQcMzR3pyj);
																													if (296268 - 268314 != 27954)
																													{
																														goto IL_349F;
																													}
																													if (PlayerData.MissionList[num - 1] > 0)
																													{
																														if (177945 - 555745 != -377800)
																														{
																															goto IL_349F;
																														}
																														int j = 0;
																														if (58266 - 233450 == -175183)
																														{
																															goto IL_349F;
																														}
																														while (j < PlayerData.MissionList[num - 1])
																														{
																															GUI.DrawTexture(new Rect((float)(280 + j * 16), (float)(147 + i * 60), (float)16, (float)16), this.XT8cMRhcF3e);
																															if (299239 - 29049 == 270191)
																															{
																																goto IL_349F;
																															}
																															j++;
																															if (175770 - 386164 != -210394)
																															{
																																goto IL_349F;
																															}
																														}
																														if (38045 - 210608 != -172563)
																														{
																															goto IL_349F;
																														}
																													}
																												}
																												else
																												{
																													GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "special mission", this.PEQcMzR3pyj);
																													if (17866 - 351742 != -333876)
																													{
																														goto IL_349F;
																													}
																												}
																											}
																											else
																											{
																												GUI.Label(new Rect((float)156, (float)(110 + 60 * i), (float)270, (float)30), "#" + this.BsAcChUqUV7 + "/" + i + "  " + data.name, this.Bo6cMKxjM2x);
																												if (95282 - 392745 == -297462)
																												{
																													goto IL_349F;
																												}
																												if (num < 96)
																												{
																													if (200463 - 336503 != -136040)
																													{
																														goto IL_349F;
																													}
																													GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "[" + this.oTYcM5rfhDM[num] + "/" + this.OkJcMcf7XmO[num] + "] Rank:", this.PEQcMzR3pyj);
																													if (154087 - 397127 != -243040)
																													{
																														goto IL_349F;
																													}
																													if (PlayerData.MissionList[num - 1] > 0)
																													{
																														if (57141 - 197440 != -140299)
																														{
																															goto IL_349F;
																														}
																														int j = 0;
																														if (51199 - 35219 == 15981)
																														{
																															goto IL_349F;
																														}
																														while (j < PlayerData.MissionList[num - 1])
																														{
																															GUI.DrawTexture(new Rect((float)(280 + j * 16), (float)(147 + i * 60), (float)16, (float)16), this.XT8cMRhcF3e);
																															if (168010 - 76365 != 91645)
																															{
																																goto IL_349F;
																															}
																															j++;
																															if (120012 - 66618 == 53395)
																															{
																																goto IL_349F;
																															}
																														}
																														if (109637 - 270903 != -161266)
																														{
																															goto IL_349F;
																														}
																													}
																												}
																												else
																												{
																													GUI.Label(new Rect((float)156, (float)(140 + 60 * i), (float)270, (float)30), "special mission", this.PEQcMzR3pyj);
																													if (214302 - 370655 == -156352)
																													{
																														goto IL_349F;
																													}
																												}
																											}
																										}
																									}
																									i++;
																									if (50132 - 238870 == -188737)
																									{
																										goto IL_349F;
																									}
																								}
																								if (11186 - 72281 == -61095)
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
								else
								{
									if (v5wcCFOg9QT == eMissionSelectMode.area)
									{
										if (62371 - 233219 == -170847)
										{
											continue;
										}
									}
									else
									{
										if (v5wcCFOg9QT != eMissionSelectMode.guild)
										{
											break;
										}
										if (155978 - 288059 != -132081)
										{
											continue;
										}
									}
									if (this.Co1cMnsGxjd != null)
									{
										if (210799 - 541001 == -330201)
										{
											continue;
										}
										if (this.acHcCWIWCnx > Time.time - (float)1)
										{
											if (125099 - 505820 != -380721)
											{
												continue;
											}
										}
										else if (Extensions.get_length(this.Co1cMnsGxjd) == 0)
										{
											if (189186 - 99552 != 89635)
											{
												if (this.V5wcCFOg9QT == eMissionSelectMode.area)
												{
													if (146009 - 220665 != -74656)
													{
														continue;
													}
													this.RenderNoticeBar("No guild mission available");
													if (290937 - 161063 != 129874)
													{
														continue;
													}
												}
												else if (this.V5wcCFOg9QT == eMissionSelectMode.guild)
												{
													if (101064 - 333153 == -232088)
													{
														continue;
													}
													this.RenderNoticeBar("No friend mission available");
													if (240341 - 272514 == -32172)
													{
														continue;
													}
												}
												goto IL_2E16;
											}
											continue;
										}
										else
										{
											int num2 = 0;
											if (118702 - 45014 != 73688)
											{
												continue;
											}
											int k = 0;
											if (240056 - 566349 == -326292)
											{
												continue;
											}
											MissionListClass[] co1cMnsGxjd = this.Co1cMnsGxjd;
											if (265610 - 541887 == -276276)
											{
												continue;
											}
											int length = co1cMnsGxjd.Length;
											if (203140 - 270222 == -67081)
											{
												continue;
											}
											while (k < length)
											{
												if (num2 < 8)
												{
													if (101539 - 140881 == -39341)
													{
														goto IL_349F;
													}
													num2++;
													if (100521 - 111543 == -11021)
													{
														goto IL_349F;
													}
													MissionClass data = MissionData.getData(co1cMnsGxjd[k].roomCode);
													if (31231 - 278382 != -247151)
													{
														goto IL_349F;
													}
													string text = "#" + (global::Math.getDigit(co1cMnsGxjd[k].roomCode, 2) + global::Math.getDigit(co1cMnsGxjd[k].roomCode, 1)) + "/" + global::Math.getDigit(co1cMnsGxjd[k].roomCode, 0) + " " + data.name;
													if (176866 - 435182 != -258316)
													{
														goto IL_349F;
													}
													string text2 = "[" + co1cMnsGxjd[k].roomPlayer + "/" + data.player + "] by: " + co1cMnsGxjd[k].roomOwner;
													if (41396 - 519677 != -478281)
													{
														goto IL_349F;
													}
													if (isButton)
													{
														if (142220 - 453939 == -311718)
														{
															goto IL_349F;
														}
														if (this.l20cCzKUHlN == co1cMnsGxjd[k].roomID)
														{
															if (11481 - 347000 != -335519)
															{
																goto IL_349F;
															}
															GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.jeMcMVdaOFZ);
															if (285041 - 363244 == -78202)
															{
																goto IL_349F;
															}
															GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
															if (41418 - 114669 == -73250)
															{
																goto IL_349F;
															}
														}
														else
														{
															if (GUI.Button(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.mu6cMycy0Ne))
															{
																if (91016 - 412415 == -321398)
																{
																	goto IL_349F;
																}
																this.l20cCzKUHlN = co1cMnsGxjd[k].roomID;
																if (172365 - 318958 != -146593)
																{
																	goto IL_349F;
																}
																this.vpEcCKjSAwn = co1cMnsGxjd[k].roomCode;
																if (127038 - 191287 != -64249)
																{
																	goto IL_349F;
																}
																PlayerPrefs.SetInt("lastMission", this.vpEcCKjSAwn);
																if (26579 - 136748 == -110168)
																{
																	goto IL_349F;
																}
																this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
																if (194457 - 452422 != -257965)
																{
																	goto IL_349F;
																}
																this.audio.PlayOneShot(this.phJcfNLcQPB);
																if (149743 - 385309 == -235565)
																{
																	goto IL_349F;
																}
															}
															GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
															if (191082 - 368955 == -177872)
															{
																goto IL_349F;
															}
														}
													}
													else
													{
														if (this.l20cCzKUHlN == co1cMnsGxjd[k].roomID)
														{
															if (107713 - 329342 == -221628)
															{
																goto IL_349F;
															}
															GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.a7KcMhwvE0q);
															if (51412 - 80926 == -29513)
															{
																goto IL_349F;
															}
														}
														else
														{
															GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.Bo6cMKxjM2x);
															if (37466 - 481887 != -444421)
															{
																goto IL_349F;
															}
														}
														GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
														if (193819 - 296952 != -103133)
														{
															goto IL_349F;
														}
													}
												}
												k++;
												if (51830 - 406251 == -354420)
												{
													goto IL_349F;
												}
											}
											if (194978 - 221331 != -26352)
											{
												goto IL_2E16;
											}
											continue;
										}
									}
									this.RenderNoticeBar("Updating mission list...");
									if (42137 - 176243 != -134106)
									{
										continue;
									}
									IL_2E16:
									GUI.DrawTexture(new Rect((float)117, (float)606, (float)343, (float)69), this.WKDcMqjWvjD);
									if (198346 - 6337 != 192010)
									{
										if (!isButton)
										{
											break;
										}
										if (76213 - 530828 != -454614)
										{
											if (this.acHcCWIWCnx >= Time.time - (float)2)
											{
												break;
											}
											if (220532 - 423455 != -202922)
											{
												GUI.SetNextControlName("SearchField");
												if (40309 - 74079 == -33770)
												{
													this.a4BcMl1gP4S = GUI.TextField(new Rect((float)152, (float)621, (float)120, (float)30), this.a4BcMl1gP4S, 9, this.iiRcLteLIxb);
													if (80179 - 176354 == -96175)
													{
														if (!(this.a4BcMl1gP4S != string.Empty) || 268370 - 590959 == -322589)
														{
															if (GUI.Button(new Rect((float)268, (float)625, (float)82, (float)27), string.Empty, this.FrfcfXTjGBC))
															{
																if (60165 - 458465 == -398299)
																{
																	continue;
																}
																int integer = Stringf.getInteger(this.a4BcMl1gP4S);
																if (175934 - 71040 == 104895)
																{
																	continue;
																}
																if (integer <= 0)
																{
																	if (269437 - 284101 == -14663)
																	{
																		continue;
																	}
																	this.RenderNoticeBar("Search code error!");
																	if (279506 - 190152 == 89355)
																	{
																		continue;
																	}
																	Chat.SubmitChat("none", "Search code error!", eChatType.system, eChatMode.system);
																	if (196906 - 220371 != -23465)
																	{
																		continue;
																	}
																}
																else
																{
																	this.ResetMissionDes();
																	if (287653 - 249222 == 38432)
																	{
																		continue;
																	}
																	this.acHcCWIWCnx = Time.time;
																	if (182602 - 508391 == -325788)
																	{
																		continue;
																	}
																	this.SearchMission(integer);
																	if (9860 - 8840 == 1021)
																	{
																		continue;
																	}
																	this.RenderNoticeBar("Searching...");
																	if (41556 - 289128 != -247572)
																	{
																		continue;
																	}
																	Chat.SubmitChat("none", "Searching for special match", eChatType.system, eChatMode.system);
																	if (113713 - 568390 == -454676)
																	{
																		continue;
																	}
																}
																this.a4BcMl1gP4S = string.Empty;
																if (285083 - 515336 == -230252)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.tDRcfUqyCxE);
																if (78744 - 369555 == -290810)
																{
																	continue;
																}
															}
															if (!GUI.Button(new Rect((float)355, (float)625, (float)82, (float)27), string.Empty, this.CAscftTnFA0))
															{
																break;
															}
															if (117442 - 428213 != -310770)
															{
																this.ResetMissionDes();
																if (43609 - 594062 != -550452)
																{
																	this.acHcCWIWCnx = Time.time;
																	if (296272 - 253375 == 42897)
																	{
																		if (this.V5wcCFOg9QT == eMissionSelectMode.area)
																		{
																			if (36851 - 260236 != -223384)
																			{
																				this.ListMission(1);
																				if (161888 - 15865 == 146023)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			this.ListMission(2);
																			if (49829 - 320279 != -270449)
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

	// Token: 0x06006239 RID: 25145 RVA: 0x00D91CE0 File Offset: 0x00D8FEE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTownMissionList(bool isButton)
	{
		if (293434 - 408882 != -115447)
		{
		}
		for (;;)
		{
			IL_4F0:
			if (this.V5wcCFOg9QT == eMissionSelectMode.mission)
			{
				if (174525 - 152864 != 21661)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)155, (float)62, (float)76, (float)31), this.VTwcMM157vy.hover.background);
				if (150588 - 284353 == -133764)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (82236 - 457571 != -375335)
				{
					continue;
				}
				if (GUI.Button(new Rect((float)155, (float)62, (float)76, (float)31), string.Empty, this.VTwcMM157vy))
				{
					if (97007 - 268211 == -171203)
					{
						continue;
					}
					this.V5wcCFOg9QT = eMissionSelectMode.mission;
					if (13423 - 237593 == -224169)
					{
						continue;
					}
					if (this.GGacC9TpOAR < Time.time - (float)30)
					{
						if (42414 - 329424 == -287009)
						{
							continue;
						}
						this.GGacC9TpOAR = Time.time;
						if (8065 - 410570 == -402504)
						{
							continue;
						}
						this.ListMission(3);
						if (114513 - 245987 == -131473)
						{
							continue;
						}
					}
					this.audio.PlayOneShot(this.phJcfNLcQPB);
					if (117531 - 439290 != -321759)
					{
						continue;
					}
				}
			}
			if (this.V5wcCFOg9QT == eMissionSelectMode.area)
			{
				if (164070 - 412752 == -248681)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)240, (float)62, (float)68, (float)31), this.YbycMf7ENWK.hover.background);
				if (12917 - 326848 == -313930)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (288140 - 488125 != -199985)
				{
					continue;
				}
				if (this.acHcCWIWCnx < Time.time - (float)3)
				{
					if (11946 - 575951 != -564005)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)240, (float)62, (float)68, (float)31), string.Empty, this.YbycMf7ENWK))
					{
						if (251239 - 188827 == 62413)
						{
							continue;
						}
						this.V5wcCFOg9QT = eMissionSelectMode.area;
						if (50615 - 518120 == -467504)
						{
							continue;
						}
						if (this.acHcCWIWCnx < Time.time - (float)1)
						{
							if (268376 - 168521 == 99856)
							{
								continue;
							}
							this.ResetMissionDes();
							if (147155 - 317548 == -170392)
							{
								continue;
							}
							this.acHcCWIWCnx = Time.time;
							if (70192 - 496175 != -425983)
							{
								continue;
							}
							this.ListMission(1);
							if (270907 - 570322 != -299415)
							{
								continue;
							}
						}
						this.audio.PlayOneShot(this.phJcfNLcQPB);
						if (29797 - 361196 != -331399)
						{
							continue;
						}
					}
				}
			}
			if (this.V5wcCFOg9QT == eMissionSelectMode.guild)
			{
				if (112682 - 43639 != 69043)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)314, (float)62, (float)68, (float)31), this.Nv1cML8YUFd.hover.background);
				if (170306 - 485815 == -315508)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (39866 - 104871 == -65004)
				{
					continue;
				}
				if (this.acHcCWIWCnx < Time.time - (float)3)
				{
					if (239470 - 472840 != -233370)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)314, (float)62, (float)68, (float)31), string.Empty, this.Nv1cML8YUFd))
					{
						if (295460 - 581953 == -286492)
						{
							continue;
						}
						this.V5wcCFOg9QT = eMissionSelectMode.guild;
						if (73147 - 455573 != -382426)
						{
							continue;
						}
						if (this.acHcCWIWCnx < Time.time - (float)1)
						{
							if (189689 - 461062 == -271372)
							{
								continue;
							}
							this.ResetMissionDes();
							if (60091 - 232795 == -172703)
							{
								continue;
							}
							this.acHcCWIWCnx = Time.time;
							if (24410 - 71139 == -46728)
							{
								continue;
							}
							this.ListMission(2);
							if (262737 - 188644 != 74093)
							{
								continue;
							}
						}
						this.audio.PlayOneShot(this.phJcfNLcQPB);
						if (206199 - 489393 != -283194)
						{
							continue;
						}
					}
				}
			}
			if (32373 - 43268 != -10894)
			{
				if (this.kiTcMr3DSmR)
				{
					if (202033 - 430047 != -228014)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)210, (float)0, (float)232, (float)47), this.kiTcMr3DSmR);
					if (177617 - 31568 == 146050)
					{
						continue;
					}
				}
				if (this.C3xcMteTFQj == 1)
				{
					if (66398 - 90249 == -23850)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)45, (float)117, (float)80, (float)59), this.s24cMoYKaZU.hover.background);
					if (248300 - 406989 != -158689)
					{
						continue;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)45, (float)117, (float)80, (float)59), this.s24cMoYKaZU.normal.background);
					if (136643 - 428575 != -291932)
					{
						continue;
					}
				}
				if (this.C3xcMteTFQj == 2)
				{
					if (147267 - 506392 == -359124)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)45, (float)168, (float)80, (float)54), this.oyHcMkF6IQf.hover.background);
					if (104811 - 267289 != -162478)
					{
						continue;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)45, (float)168, (float)80, (float)54), this.oyHcMkF6IQf.normal.background);
					if (39578 - 591492 != -551914)
					{
						continue;
					}
				}
				if (this.C3xcMteTFQj == 3)
				{
					if (298860 - 561702 != -262842)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)45, (float)207, (float)80, (float)60), this.TKqcMFAVcbL.hover.background);
					if (10577 - 484273 != -473696)
					{
						continue;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)45, (float)207, (float)80, (float)60), this.TKqcMFAVcbL.normal.background);
					if (131244 - 189502 == -58257)
					{
						continue;
					}
				}
				if (this.C3xcMteTFQj == 4)
				{
					if (182778 - 5444 == 177335)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)45, (float)251, (float)80, (float)51), this.zPrcMA5RWDE.hover.background);
					if (208637 - 555426 != -346789)
					{
						continue;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)45, (float)251, (float)80, (float)51), this.zPrcMA5RWDE.normal.background);
					if (221556 - 158822 == 62735)
					{
						continue;
					}
				}
				if (this.C3xcMteTFQj == 5)
				{
					if (44837 - 535772 == -490934)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)45, (float)295, (float)80, (float)49), this.U95cM9UyP2Q.hover.background);
					if (673 - 113179 != -112506)
					{
						continue;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)45, (float)295, (float)80, (float)49), this.U95cM9UyP2Q.normal.background);
					if (186468 - 16374 == 170095)
					{
						continue;
					}
				}
				if (this.C3xcMteTFQj == 6)
				{
					if (112893 - 19202 == 93692)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)45, (float)340, (float)80, (float)45), this.l5KcMW9wsT7.hover.background);
					if (20434 - 452223 != -431789)
					{
						continue;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)45, (float)340, (float)80, (float)45), this.l5KcMW9wsT7.normal.background);
					if (119613 - 19231 == 100383)
					{
						continue;
					}
				}
				if (this.C3xcMteTFQj == 0)
				{
					if (248863 - 144474 == 104390)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)45, (float)380, (float)80, (float)45), this.Bq4cMugRf4q.hover.background);
					if (131170 - 196766 != -65596)
					{
						continue;
					}
				}
				else
				{
					GUI.DrawTexture(new Rect((float)45, (float)380, (float)80, (float)45), this.Bq4cMugRf4q.normal.background);
					if (280178 - 572749 == -292570)
					{
						continue;
					}
				}
				eMissionSelectMode v5wcCFOg9QT = this.V5wcCFOg9QT;
				if (95384 - 37617 != 57768)
				{
					if (v5wcCFOg9QT == eMissionSelectMode.mission)
					{
						if (51099 - 194246 != -143146)
						{
							if (this.n6rcMQX4Xhl != null)
							{
								if (165024 - 265275 == -100250)
								{
									continue;
								}
								if (this.GGacC9TpOAR > Time.time - (float)1)
								{
									if (290928 - 534471 == -243542)
									{
										continue;
									}
								}
								else if (Extensions.get_length(this.n6rcMQX4Xhl) == 0)
								{
									if (148405 - 467792 == -319386)
									{
										continue;
									}
									this.RenderNoticeBar("No town mission available");
									if (188304 - 459333 != -271028)
									{
										break;
									}
									continue;
								}
								else
								{
									int num = 0;
									if (26998 - 471015 != -444017)
									{
										continue;
									}
									int i = 0;
									if (103433 - 2799 != 100634)
									{
										continue;
									}
									MissionListClass[] array = this.n6rcMQX4Xhl;
									if (131825 - 120753 == 11073)
									{
										continue;
									}
									int length = array.Length;
									if (187398 - 8478 != 178920)
									{
										continue;
									}
									while (i < length)
									{
										MissionClass data = MissionData.getData(array[i].roomCode);
										if (225566 - 38553 == 187014)
										{
											goto IL_4F0;
										}
										if (data.name != "none")
										{
											if (233249 - 515408 != -282159)
											{
												goto IL_4F0;
											}
											if (data.slv <= PlayerData.SLv)
											{
												if (14636 - 364880 == -350243)
												{
													goto IL_4F0;
												}
												if (array[i].roomCode > 940)
												{
													if (59492 - 499174 == -439681)
													{
														goto IL_4F0;
													}
													if (array[i].roomCode < 980)
													{
														if (92290 - 222299 == -130008)
														{
															goto IL_4F0;
														}
														num++;
														if (278125 - 400843 == -122717)
														{
															goto IL_4F0;
														}
														if (this.vpEcCKjSAwn == array[i].roomCode)
														{
															if (200152 - 554315 == -354162)
															{
																goto IL_4F0;
															}
															GUI.Label(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), "Act 1/" + array[i].roomCode % 10 + "  " + data.name, this.jeMcMVdaOFZ);
															if (220030 - 264555 == -44524)
															{
																goto IL_4F0;
															}
															GUI.Label(new Rect((float)156, (float)(140 + 60 * num), (float)270, (float)30), "[?/?] Rank:", this.PEQcMzR3pyj);
															if (64327 - 374966 != -310639)
															{
																goto IL_4F0;
															}
														}
														else
														{
															if (isButton)
															{
																if (5779 - 55771 != -49992)
																{
																	goto IL_4F0;
																}
																if (GUI.Button(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), "Act 1/" + array[i].roomCode % 10 + "  " + data.name, this.mu6cMycy0Ne))
																{
																	if (200475 - 512788 == -312312)
																	{
																		goto IL_4F0;
																	}
																	this.vpEcCKjSAwn = array[i].roomCode;
																	if (77685 - 287811 != -210126)
																	{
																		goto IL_4F0;
																	}
																	this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
																	if (136003 - 225792 != -89789)
																	{
																		goto IL_4F0;
																	}
																	this.audio.PlayOneShot(this.phJcfNLcQPB);
																	if (244619 - 501902 == -257282)
																	{
																		goto IL_4F0;
																	}
																}
															}
															else
															{
																GUI.Label(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), "Act 1/" + array[i].roomCode % 10 + "  " + data.name, this.Bo6cMKxjM2x);
																if (190389 - 368270 == -177880)
																{
																	goto IL_4F0;
																}
															}
															GUI.Label(new Rect((float)156, (float)(140 + 60 * num), (float)270, (float)30), "[?/?] Rank:", this.PEQcMzR3pyj);
															if (122497 - 267215 == -144717)
															{
																goto IL_4F0;
															}
														}
													}
												}
											}
										}
										i++;
										if (128670 - 139428 != -10758)
										{
											goto IL_4F0;
										}
									}
									if (202119 - 380456 != -178336)
									{
										break;
									}
									continue;
								}
							}
							this.RenderNoticeBar("Updating town mission list...");
							if (119805 - 329680 == -209875)
							{
								break;
							}
						}
					}
					else
					{
						if (v5wcCFOg9QT == eMissionSelectMode.area)
						{
							if (19626 - 266006 == -246379)
							{
								continue;
							}
						}
						else
						{
							if (v5wcCFOg9QT != eMissionSelectMode.guild)
							{
								break;
							}
							if (97472 - 435390 == -337917)
							{
								continue;
							}
						}
						if (this.Co1cMnsGxjd == null)
						{
							goto IL_11DA;
						}
						if (12344 - 113286 == -100941)
						{
							continue;
						}
						if (this.acHcCWIWCnx > Time.time - (float)1)
						{
							if (182054 - 501465 != -319411)
							{
								continue;
							}
							goto IL_11DA;
						}
						else if (Extensions.get_length(this.Co1cMnsGxjd) == 0)
						{
							if (116208 - 270207 == -153998)
							{
								continue;
							}
							if (this.V5wcCFOg9QT == eMissionSelectMode.area)
							{
								if (250238 - 540932 != -290694)
								{
									continue;
								}
								this.RenderNoticeBar("No guild mission available");
								if (180045 - 17332 != 162713)
								{
									continue;
								}
							}
							else if (this.V5wcCFOg9QT == eMissionSelectMode.guild)
							{
								if (89251 - 484540 != -395289)
								{
									continue;
								}
								this.RenderNoticeBar("No friend mission available");
								if (102919 - 190061 != -87142)
								{
									continue;
								}
							}
						}
						else
						{
							int num2 = 0;
							if (152097 - 186790 == -34692)
							{
								continue;
							}
							int j = 0;
							if (209796 - 234117 != -24321)
							{
								continue;
							}
							MissionListClass[] co1cMnsGxjd = this.Co1cMnsGxjd;
							if (8500 - 308688 != -300188)
							{
								continue;
							}
							int length2 = co1cMnsGxjd.Length;
							if (10219 - 19783 != -9564)
							{
								continue;
							}
							while (j < length2)
							{
								if (num2 < 8)
								{
									if (96640 - 373746 == -277105)
									{
										goto IL_4F0;
									}
									num2++;
									if (193256 - 174280 == 18977)
									{
										goto IL_4F0;
									}
									MissionClass data = MissionData.getData(co1cMnsGxjd[j].roomCode);
									if (207735 - 206873 == 863)
									{
										goto IL_4F0;
									}
									int num;
									string text = "Act 1/" + num + "  " + data.name;
									if (209480 - 93446 != 116034)
									{
										goto IL_4F0;
									}
									string text2 = "[" + co1cMnsGxjd[j].roomPlayer + "/" + data.player + "] by: " + co1cMnsGxjd[j].roomOwner;
									if (167061 - 119013 == 48049)
									{
										goto IL_4F0;
									}
									if (isButton)
									{
										if (15103 - 586880 != -571777)
										{
											goto IL_4F0;
										}
										if (this.l20cCzKUHlN == co1cMnsGxjd[j].roomID)
										{
											if (215680 - 407900 != -192220)
											{
												goto IL_4F0;
											}
											GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.jeMcMVdaOFZ);
											if (240222 - 49825 == 190398)
											{
												goto IL_4F0;
											}
											GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
											if (132886 - 204539 != -71653)
											{
												goto IL_4F0;
											}
										}
										else
										{
											if (GUI.Button(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.mu6cMycy0Ne))
											{
												if (109341 - 14242 == 95100)
												{
													goto IL_4F0;
												}
												this.l20cCzKUHlN = co1cMnsGxjd[j].roomID;
												if (112074 - 256141 == -144066)
												{
													goto IL_4F0;
												}
												this.vpEcCKjSAwn = co1cMnsGxjd[j].roomCode;
												if (87279 - 8016 != 79263)
												{
													goto IL_4F0;
												}
												PlayerPrefs.SetInt("lastTownMission", this.vpEcCKjSAwn);
												if (164998 - 45858 == 119141)
												{
													goto IL_4F0;
												}
												this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
												if (180961 - 276067 == -95105)
												{
													goto IL_4F0;
												}
												this.audio.PlayOneShot(this.phJcfNLcQPB);
												if (180769 - 216522 != -35753)
												{
													goto IL_4F0;
												}
											}
											GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
											if (262334 - 176461 == 85874)
											{
												goto IL_4F0;
											}
										}
									}
									else
									{
										if (this.l20cCzKUHlN == co1cMnsGxjd[j].roomID)
										{
											if (7668 - 14912 == -7243)
											{
												goto IL_4F0;
											}
											GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.a7KcMhwvE0q);
											if (284273 - 403949 == -119675)
											{
												goto IL_4F0;
											}
										}
										else
										{
											GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.Bo6cMKxjM2x);
											if (292220 - 394175 == -101954)
											{
												goto IL_4F0;
											}
										}
										GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
										if (276952 - 564919 != -287967)
										{
											goto IL_4F0;
										}
									}
								}
								j++;
								if (74559 - 289220 == -214660)
								{
									goto IL_4F0;
								}
							}
							if (129962 - 408059 != -278097)
							{
								continue;
							}
						}
						IL_241:
						GUI.DrawTexture(new Rect((float)117, (float)606, (float)343, (float)69), this.WKDcMqjWvjD);
						if (18682 - 203739 != -185057)
						{
							continue;
						}
						if (!isButton)
						{
							break;
						}
						if (242990 - 174248 == 68743)
						{
							continue;
						}
						if (this.acHcCWIWCnx >= Time.time - (float)2)
						{
							break;
						}
						if (23020 - 28199 == -5178)
						{
							continue;
						}
						GUI.SetNextControlName("SearchField");
						if (143455 - 185787 != -42332)
						{
							continue;
						}
						this.a4BcMl1gP4S = GUI.TextField(new Rect((float)152, (float)621, (float)120, (float)30), this.a4BcMl1gP4S, 9, this.iiRcLteLIxb);
						if (63141 - 66622 == -3480)
						{
							continue;
						}
						if (this.a4BcMl1gP4S != string.Empty)
						{
							if (154981 - 439736 == -284754)
							{
								continue;
							}
							if (GUI.Button(new Rect((float)268, (float)625, (float)82, (float)27), string.Empty, this.FrfcfXTjGBC))
							{
								if (83821 - 458094 != -374273)
								{
									continue;
								}
								int integer = Stringf.getInteger(this.a4BcMl1gP4S);
								if (172844 - 533065 != -360221)
								{
									continue;
								}
								if (integer <= 0)
								{
									if (201917 - 479050 != -277133)
									{
										continue;
									}
									this.RenderNoticeBar("Search code error!");
									if (212557 - 273468 != -60911)
									{
										continue;
									}
									Chat.SubmitChat("none", "Search code error!", eChatType.system, eChatMode.system);
									if (273288 - 194958 != 78330)
									{
										continue;
									}
								}
								else
								{
									this.ResetMissionDes();
									if (90346 - 8878 == 81469)
									{
										continue;
									}
									this.acHcCWIWCnx = Time.time;
									if (105576 - 500323 == -394746)
									{
										continue;
									}
									this.SearchMission(integer);
									if (169215 - 280145 != -110930)
									{
										continue;
									}
									this.RenderNoticeBar("Searching...");
									if (122361 - 501238 == -378876)
									{
										continue;
									}
									Chat.SubmitChat("none", "Searching for special match", eChatType.system, eChatMode.system);
									if (148630 - 168398 != -19768)
									{
										continue;
									}
								}
								this.a4BcMl1gP4S = string.Empty;
								if (4599 - 515138 == -510538)
								{
									continue;
								}
								this.audio.PlayOneShot(this.tDRcfUqyCxE);
								if (191996 - 466985 == -274988)
								{
									continue;
								}
							}
						}
						if (!GUI.Button(new Rect((float)355, (float)625, (float)82, (float)27), string.Empty, this.CAscftTnFA0))
						{
							break;
						}
						if (174493 - 315808 == -141314)
						{
							continue;
						}
						this.ResetMissionDes();
						if (228322 - 229815 != -1493)
						{
							continue;
						}
						this.acHcCWIWCnx = Time.time;
						if (159671 - 539420 == -379748)
						{
							continue;
						}
						if (this.V5wcCFOg9QT == eMissionSelectMode.area)
						{
							if (251227 - 209147 != 42080)
							{
								continue;
							}
							this.ListMission(1);
							if (23699 - 472980 != -449281)
							{
								continue;
							}
							break;
						}
						else
						{
							this.ListMission(2);
							if (249337 - 26213 != 223125)
							{
								break;
							}
							continue;
						}
						IL_11DA:
						this.RenderNoticeBar("Updating mission list...");
						if (10268 - 151952 != -141683)
						{
							goto IL_241;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600623A RID: 25146 RVA: 0x00D93828 File Offset: 0x00D91A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderPVPArenaList(bool isButton)
	{
		if (173414 - 42303 != 131112)
		{
		}
		for (;;)
		{
			IL_14C3:
			if (this.V5wcCFOg9QT == eMissionSelectMode.mission)
			{
				if (269276 - 408965 != -139689)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)155, (float)62, (float)76, (float)31), this.VTwcMM157vy.hover.background);
				if (130533 - 472490 != -341957)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (87340 - 148348 != -61008)
				{
					continue;
				}
				if (GUI.Button(new Rect((float)155, (float)62, (float)76, (float)31), string.Empty, this.VTwcMM157vy))
				{
					if (202083 - 510168 == -308084)
					{
						continue;
					}
					this.V5wcCFOg9QT = eMissionSelectMode.mission;
					if (37370 - 145592 != -108222)
					{
						continue;
					}
					if (this.GGacC9TpOAR < Time.time - (float)30)
					{
						if (270783 - 538823 != -268040)
						{
							continue;
						}
						this.GGacC9TpOAR = Time.time;
						if (210655 - 506854 == -296198)
						{
							continue;
						}
						this.ListMission(4);
						if (221985 - 67887 == 154099)
						{
							continue;
						}
					}
					this.audio.PlayOneShot(this.phJcfNLcQPB);
					if (99098 - 308307 != -209209)
					{
						continue;
					}
				}
			}
			if (this.V5wcCFOg9QT == eMissionSelectMode.area)
			{
				if (114748 - 426563 == -311814)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)240, (float)62, (float)68, (float)31), this.YbycMf7ENWK.hover.background);
				if (63114 - 30258 == 32857)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (295394 - 47511 != 247883)
				{
					continue;
				}
				if (this.acHcCWIWCnx < Time.time - (float)3)
				{
					if (141735 - 27856 == 113880)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)240, (float)62, (float)68, (float)31), string.Empty, this.YbycMf7ENWK))
					{
						if (103979 - 423208 == -319228)
						{
							continue;
						}
						this.V5wcCFOg9QT = eMissionSelectMode.area;
						if (37031 - 344930 != -307899)
						{
							continue;
						}
						if (this.acHcCWIWCnx < Time.time - (float)1)
						{
							if (81510 - 354494 != -272984)
							{
								continue;
							}
							this.ResetMissionDes();
							if (30529 - 108659 == -78129)
							{
								continue;
							}
							this.acHcCWIWCnx = Time.time;
							if (218111 - 474219 != -256108)
							{
								continue;
							}
							this.ListMission(1);
							if (291864 - 436597 == -144732)
							{
								continue;
							}
						}
						this.audio.PlayOneShot(this.phJcfNLcQPB);
						if (180539 - 54375 != 126164)
						{
							continue;
						}
					}
				}
			}
			if (this.V5wcCFOg9QT == eMissionSelectMode.guild)
			{
				if (282225 - 41024 != 241201)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)314, (float)62, (float)68, (float)31), this.Nv1cML8YUFd.hover.background);
				if (290106 - 409131 != -119025)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (16237 - 331126 != -314889)
				{
					continue;
				}
				if (this.acHcCWIWCnx < Time.time - (float)3)
				{
					if (296319 - 96198 != 200121)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)314, (float)62, (float)68, (float)31), string.Empty, this.Nv1cML8YUFd))
					{
						if (197901 - 328112 != -130211)
						{
							continue;
						}
						this.V5wcCFOg9QT = eMissionSelectMode.guild;
						if (279504 - 163767 != 115737)
						{
							continue;
						}
						if (this.acHcCWIWCnx < Time.time - (float)1)
						{
							if (224746 - 163971 == 60776)
							{
								continue;
							}
							this.ResetMissionDes();
							if (152591 - 284550 != -131959)
							{
								continue;
							}
							this.acHcCWIWCnx = Time.time;
							if (298431 - 481947 != -183516)
							{
								continue;
							}
							this.ListMission(2);
							if (256645 - 261903 != -5258)
							{
								continue;
							}
						}
						this.audio.PlayOneShot(this.phJcfNLcQPB);
						if (193134 - 276808 != -83674)
						{
							continue;
						}
					}
				}
			}
			if (231848 - 52339 == 179509)
			{
				if (this.s4PcMxSM4KI)
				{
					if (295698 - 582497 != -286799)
					{
						continue;
					}
					GUI.DrawTexture(new Rect((float)210, (float)0, (float)232, (float)47), this.s4PcMxSM4KI);
					if (256644 - 313442 == -56797)
					{
						continue;
					}
				}
				GUI.DrawTexture(new Rect((float)45, (float)117, (float)80, (float)59), this.s24cMoYKaZU.active.background);
				if (97374 - 334549 != -237174)
				{
					GUI.DrawTexture(new Rect((float)45, (float)168, (float)80, (float)54), this.oyHcMkF6IQf.active.background);
					if (163934 - 237851 == -73917)
					{
						GUI.DrawTexture(new Rect((float)45, (float)207, (float)80, (float)60), this.TKqcMFAVcbL.active.background);
						if (183330 - 126905 != 56426)
						{
							GUI.DrawTexture(new Rect((float)45, (float)251, (float)80, (float)51), this.zPrcMA5RWDE.active.background);
							if (45002 - 119859 == -74857)
							{
								GUI.DrawTexture(new Rect((float)45, (float)295, (float)80, (float)49), this.U95cM9UyP2Q.active.background);
								if (108013 - 180148 != -72134)
								{
									if (this.C3xcMteTFQj == 6)
									{
										if (15385 - 36311 == -20925)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)45, (float)340, (float)80, (float)45), this.l5KcMW9wsT7.hover.background);
										if (145245 - 265660 != -120415)
										{
											continue;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect((float)45, (float)340, (float)80, (float)45), this.l5KcMW9wsT7.normal.background);
										if (166610 - 296930 != -130320)
										{
											continue;
										}
									}
									if (this.C3xcMteTFQj == 0)
									{
										if (124567 - 304088 != -179521)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)45, (float)380, (float)80, (float)56), this.Bq4cMugRf4q.hover.background);
										if (201400 - 384013 == -182612)
										{
											continue;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect((float)45, (float)380, (float)80, (float)45), this.Bq4cMugRf4q.normal.background);
										if (127382 - 79861 != 47521)
										{
											continue;
										}
									}
									eMissionSelectMode v5wcCFOg9QT = this.V5wcCFOg9QT;
									if (153667 - 276856 != -123188)
									{
										if (v5wcCFOg9QT == eMissionSelectMode.mission)
										{
											if (43821 - 410998 == -367177)
											{
												if (this.HTmcMeto4Zx != null)
												{
													if (38751 - 83441 != -44690)
													{
														continue;
													}
													if (this.GGacC9TpOAR > Time.time - (float)1)
													{
														if (96841 - 585334 == -488492)
														{
															continue;
														}
													}
													else if (Extensions.get_length(this.HTmcMeto4Zx) == 0)
													{
														if (156604 - 331196 == -174591)
														{
															continue;
														}
														this.RenderNoticeBar("No arena available");
														if (158073 - 50082 != 107992)
														{
															break;
														}
														continue;
													}
													else
													{
														int num = 0;
														if (156898 - 70882 != 86016)
														{
															continue;
														}
														int i = 0;
														if (7410 - 363879 != -356469)
														{
															continue;
														}
														MissionListClass[] htmcMeto4Zx = this.HTmcMeto4Zx;
														if (140321 - 537987 == -397665)
														{
															continue;
														}
														int length = htmcMeto4Zx.Length;
														if (148610 - 542593 == -393982)
														{
															continue;
														}
														while (i < length)
														{
															MissionClass data = MissionData.getData(htmcMeto4Zx[i].roomCode);
															if (160150 - 271070 == -110919)
															{
																goto IL_14C3;
															}
															if (data.name != "none")
															{
																if (166161 - 183279 != -17118)
																{
																	goto IL_14C3;
																}
																if (data.slv <= PlayerData.SLv)
																{
																	if (237412 - 43647 == 193766)
																	{
																		goto IL_14C3;
																	}
																	if (htmcMeto4Zx[i].roomCode > 980)
																	{
																		if (170378 - 543181 != -372803)
																		{
																			goto IL_14C3;
																		}
																		if (htmcMeto4Zx[i].roomCode < 1000)
																		{
																			if (170299 - 71521 == 98779)
																			{
																				goto IL_14C3;
																			}
																			num++;
																			if (184022 - 356355 != -172333)
																			{
																				goto IL_14C3;
																			}
																			if (this.vpEcCKjSAwn == htmcMeto4Zx[i].roomCode)
																			{
																				if (84509 - 354002 != -269493)
																				{
																					goto IL_14C3;
																				}
																				GUI.Label(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), "Arena " + htmcMeto4Zx[i].roomCode % 10 + "  " + data.name, this.jeMcMVdaOFZ);
																				if (288150 - 205775 == 82376)
																				{
																					goto IL_14C3;
																				}
																				GUI.Label(new Rect((float)156, (float)(140 + 60 * num), (float)270, (float)30), "[?/?] Rank:", this.PEQcMzR3pyj);
																				if (25714 - 594687 != -568973)
																				{
																					goto IL_14C3;
																				}
																			}
																			else
																			{
																				if (isButton)
																				{
																					if (215023 - 95834 != 119189)
																					{
																						goto IL_14C3;
																					}
																					if (GUI.Button(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), "Arena " + htmcMeto4Zx[i].roomCode % 10 + "  " + data.name, this.mu6cMycy0Ne))
																					{
																						if (204377 - 591082 == -386704)
																						{
																							goto IL_14C3;
																						}
																						this.vpEcCKjSAwn = htmcMeto4Zx[i].roomCode;
																						if (293260 - 230812 != 62448)
																						{
																							goto IL_14C3;
																						}
																						this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
																						if (36100 - 65340 == -29239)
																						{
																							goto IL_14C3;
																						}
																						this.audio.PlayOneShot(this.phJcfNLcQPB);
																						if (18958 - 292140 != -273182)
																						{
																							goto IL_14C3;
																						}
																					}
																				}
																				else
																				{
																					GUI.Label(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), "Arena " + htmcMeto4Zx[i].roomCode % 10 + "  " + data.name, this.Bo6cMKxjM2x);
																					if (129355 - 42256 == 87100)
																					{
																						goto IL_14C3;
																					}
																				}
																				GUI.Label(new Rect((float)156, (float)(140 + 60 * num), (float)270, (float)30), "[?/?] Rank:", this.PEQcMzR3pyj);
																				if (82027 - 139135 == -57107)
																				{
																					goto IL_14C3;
																				}
																			}
																		}
																	}
																}
															}
															i++;
															if (167500 - 117210 == 50291)
															{
																goto IL_14C3;
															}
														}
														if (110497 - 392987 != -282490)
														{
															continue;
														}
														break;
													}
												}
												this.RenderNoticeBar("Updating arena list...");
												if (20815 - 212960 != -192144)
												{
													break;
												}
											}
										}
										else
										{
											if (v5wcCFOg9QT == eMissionSelectMode.area)
											{
												if (256407 - 488750 != -232343)
												{
													continue;
												}
											}
											else
											{
												if (v5wcCFOg9QT != eMissionSelectMode.guild)
												{
													break;
												}
												if (97422 - 528321 == -430898)
												{
													continue;
												}
											}
											if (this.Co1cMnsGxjd == null)
											{
												goto IL_1179;
											}
											if (234398 - 321400 == -87001)
											{
												continue;
											}
											if (this.acHcCWIWCnx > Time.time - (float)1)
											{
												if (82515 - 389493 != -306977)
												{
													goto IL_1179;
												}
												continue;
											}
											else if (Extensions.get_length(this.Co1cMnsGxjd) == 0)
											{
												if (160790 - 72455 != 88335)
												{
													continue;
												}
												if (this.V5wcCFOg9QT == eMissionSelectMode.area)
												{
													if (162908 - 394613 != -231705)
													{
														continue;
													}
													this.RenderNoticeBar("No area mission available");
													if (43957 - 414771 != -370814)
													{
														continue;
													}
												}
												else if (this.V5wcCFOg9QT == eMissionSelectMode.guild)
												{
													if (51324 - 63159 != -11835)
													{
														continue;
													}
													this.RenderNoticeBar("No guild mission available");
													if (222427 - 581017 == -358589)
													{
														continue;
													}
												}
											}
											else
											{
												int num2 = 0;
												if (65066 - 536936 == -471869)
												{
													continue;
												}
												int j = 0;
												if (142870 - 297415 == -154544)
												{
													continue;
												}
												MissionListClass[] co1cMnsGxjd = this.Co1cMnsGxjd;
												if (126552 - 166863 == -40310)
												{
													continue;
												}
												int length2 = co1cMnsGxjd.Length;
												if (38672 - 388572 == -349899)
												{
													continue;
												}
												while (j < length2)
												{
													if (num2 < 8)
													{
														if (188040 - 304302 == -116261)
														{
															goto IL_14C3;
														}
														num2++;
														if (51011 - 136501 == -85489)
														{
															goto IL_14C3;
														}
														MissionClass data = MissionData.getData(co1cMnsGxjd[j].roomCode);
														if (116905 - 276123 == -159217)
														{
															goto IL_14C3;
														}
														string text = "Arena " + num2 + "  " + data.name;
														if (193704 - 500902 != -307198)
														{
															goto IL_14C3;
														}
														string text2 = "[" + co1cMnsGxjd[j].roomPlayer + "/" + data.player + "] by: " + co1cMnsGxjd[j].roomOwner;
														if (101696 - 394089 == -292392)
														{
															goto IL_14C3;
														}
														if (isButton)
														{
															if (95558 - 135091 != -39533)
															{
																goto IL_14C3;
															}
															if (this.l20cCzKUHlN == co1cMnsGxjd[j].roomID)
															{
																if (105358 - 191337 != -85979)
																{
																	goto IL_14C3;
																}
																GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.jeMcMVdaOFZ);
																if (284459 - 350801 == -66341)
																{
																	goto IL_14C3;
																}
																GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
																if (138237 - 261358 != -123121)
																{
																	goto IL_14C3;
																}
															}
															else
															{
																if (GUI.Button(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.mu6cMycy0Ne))
																{
																	if (130014 - 395994 != -265980)
																	{
																		goto IL_14C3;
																	}
																	this.l20cCzKUHlN = co1cMnsGxjd[j].roomID;
																	if (150744 - 299555 != -148811)
																	{
																		goto IL_14C3;
																	}
																	this.vpEcCKjSAwn = co1cMnsGxjd[j].roomCode;
																	if (203092 - 133375 == 69718)
																	{
																		goto IL_14C3;
																	}
																	PlayerPrefs.SetInt("lastArena", this.vpEcCKjSAwn);
																	if (54403 - 567806 == -513402)
																	{
																		goto IL_14C3;
																	}
																	this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
																	if (212202 - 597420 != -385218)
																	{
																		goto IL_14C3;
																	}
																	this.audio.PlayOneShot(this.phJcfNLcQPB);
																	if (156108 - 346020 == -189911)
																	{
																		goto IL_14C3;
																	}
																}
																GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
																if (260056 - 549112 == -289055)
																{
																	goto IL_14C3;
																}
															}
														}
														else
														{
															if (this.l20cCzKUHlN == co1cMnsGxjd[j].roomID)
															{
																if (193193 - 96287 == 96907)
																{
																	goto IL_14C3;
																}
																GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.a7KcMhwvE0q);
																if (183296 - 540387 != -357091)
																{
																	goto IL_14C3;
																}
															}
															else
															{
																GUI.Label(new Rect((float)156, (float)(110 + 60 * num2), (float)270, (float)30), text, this.Bo6cMKxjM2x);
																if (226525 - 41306 == 185220)
																{
																	goto IL_14C3;
																}
															}
															GUI.Label(new Rect((float)156, (float)(140 + 60 * num2), (float)270, (float)30), text2, this.PEQcMzR3pyj);
															if (61448 - 371566 == -310117)
															{
																goto IL_14C3;
															}
														}
													}
													j++;
													if (283066 - 433236 == -150169)
													{
														goto IL_14C3;
													}
												}
												if (124971 - 594197 == -469225)
												{
													continue;
												}
											}
											IL_170F:
											GUI.DrawTexture(new Rect((float)117, (float)606, (float)343, (float)69), this.WKDcMqjWvjD);
											if (182222 - 498054 != -315832)
											{
												continue;
											}
											if (!isButton)
											{
												break;
											}
											if (15076 - 262031 == -246954)
											{
												continue;
											}
											if (this.acHcCWIWCnx >= Time.time - (float)2)
											{
												break;
											}
											if (155242 - 231664 != -76422)
											{
												continue;
											}
											GUI.SetNextControlName("SearchField");
											if (123820 - 88579 == 35242)
											{
												continue;
											}
											this.a4BcMl1gP4S = GUI.TextField(new Rect((float)152, (float)621, (float)120, (float)30), this.a4BcMl1gP4S, 9, this.iiRcLteLIxb);
											if (23067 - 118715 != -95648)
											{
												continue;
											}
											if (this.a4BcMl1gP4S != string.Empty)
											{
												if (279199 - 310391 == -31191)
												{
													continue;
												}
												if (GUI.Button(new Rect((float)268, (float)625, (float)82, (float)27), string.Empty, this.FrfcfXTjGBC))
												{
													if (142338 - 247288 != -104950)
													{
														continue;
													}
													int integer = Stringf.getInteger(this.a4BcMl1gP4S);
													if (135366 - 434670 != -299304)
													{
														continue;
													}
													if (integer <= 0)
													{
														if (122387 - 232 != 122155)
														{
															continue;
														}
														this.RenderNoticeBar("Search code error!");
														if (154622 - 347480 == -192857)
														{
															continue;
														}
														Chat.SubmitChat("none", "Search code error!", eChatType.system, eChatMode.system);
														if (178226 - 352144 == -173917)
														{
															continue;
														}
													}
													else
													{
														this.ResetMissionDes();
														if (262395 - 579085 == -316689)
														{
															continue;
														}
														this.acHcCWIWCnx = Time.time;
														if (218414 - 107482 != 110932)
														{
															continue;
														}
														this.SearchMission(integer);
														if (98175 - 533291 == -435115)
														{
															continue;
														}
														this.RenderNoticeBar("Searching...");
														if (37978 - 166977 == -128998)
														{
															continue;
														}
														Chat.SubmitChat("none", "Searching for special match", eChatType.system, eChatMode.system);
														if (249123 - 429289 != -180166)
														{
															continue;
														}
													}
													this.a4BcMl1gP4S = string.Empty;
													if (80994 - 149821 == -68826)
													{
														continue;
													}
													this.audio.PlayOneShot(this.tDRcfUqyCxE);
													if (246433 - 287916 != -41483)
													{
														continue;
													}
												}
											}
											if (!GUI.Button(new Rect((float)355, (float)625, (float)82, (float)27), string.Empty, this.CAscftTnFA0))
											{
												break;
											}
											if (35173 - 367786 == -332612)
											{
												continue;
											}
											this.ResetMissionDes();
											if (143720 - 283385 == -139664)
											{
												continue;
											}
											this.acHcCWIWCnx = Time.time;
											if (165762 - 506034 != -340272)
											{
												continue;
											}
											if (this.V5wcCFOg9QT == eMissionSelectMode.area)
											{
												if (70404 - 101626 != -31222)
												{
													continue;
												}
												this.ListMission(1);
												if (247160 - 266480 != -19320)
												{
													continue;
												}
												break;
											}
											else
											{
												this.ListMission(2);
												if (52538 - 429751 != -377213)
												{
													continue;
												}
												break;
											}
											IL_1179:
											this.RenderNoticeBar("Updating mission list...");
											if (70849 - 123302 != -52452)
											{
												goto IL_170F;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600623B RID: 25147 RVA: 0x00D9514C File Offset: 0x00D9334C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitMatchBar()
	{
		if (176787 - 21541 != 155246)
		{
		}
		for (;;)
		{
			this.FtUcfzpXTpK = new GUIStyle();
			if (221822 - 575995 != -354172)
			{
				this.FtUcfzpXTpK.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
				if (121409 - 348797 != -227387)
				{
					this.FtUcfzpXTpK.normal.textColor = new Color(0.11f, 0.16f, 0.19f, (float)1);
					if (86614 - 592518 != -505903)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600623C RID: 25148 RVA: 0x00D95220 File Offset: 0x00D93420
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderMatchBar(bool isFound)
	{
		if (244433 - 396095 != -151662)
		{
		}
		for (;;)
		{
			GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)640, (float)400, (float)368, (float)199), this.UyrcMHIQ76S);
			if (80345 - 148635 == -68290)
			{
				GUI.Label(new Rect(this.T45cCyVhtgd - (float)420, (float)483, (float)200, (float)30), "15:00", this.FtUcfzpXTpK);
				if (160161 - 414721 == -254560)
				{
					if (isFound)
					{
						if (218612 - 257456 == -38844)
						{
							GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)618, (float)440, (float)325, (float)40), this.qXscM7pXUtx);
							if (270425 - 133206 != 137220)
							{
								GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)460, (float)518, (float)141, (float)39), this.PGYcMZAuJ79);
								if (249510 - 98409 == 151101)
								{
									break;
								}
							}
						}
					}
					else
					{
						GUI.Label(new Rect(this.T45cCyVhtgd - (float)420, (float)522, (float)200, (float)30), global::Math.div(Time.time - this.L4rcCAGc8mu, (float)60) + ":" + Mathf.FloorToInt((Time.time - this.L4rcCAGc8mu) % (float)60), this.FtUcfzpXTpK);
						if (96918 - 500212 == -403294)
						{
							if (!GUI.Button(new Rect(this.T45cCyVhtgd - (float)386, (float)559, (float)100, (float)32), string.Empty, this.u5gcMCFwFJK))
							{
								break;
							}
							if (33090 - 556449 != -523358)
							{
								if (this.ST5cM6mrbBP == PlayerData.UID)
								{
									if (125612 - 345520 == -219907)
									{
										continue;
									}
									this.HeGcCkg9Cyt = eMissionState.createTeam;
									if (226043 - 108290 == 117754)
									{
										continue;
									}
								}
								else
								{
									this.HeGcCkg9Cyt = eMissionState.joinTeam;
									if (31508 - 463702 != -432194)
									{
										continue;
									}
								}
								this.MatchCancel();
								if (97867 - 191277 != -93409)
								{
									if (!this.MHYcfw23xt3)
									{
										break;
									}
									if (89706 - 5586 != 84121)
									{
										this.audio.PlayOneShot(this.MHYcfw23xt3);
										if (230784 - 554249 == -323465)
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

	// Token: 0x0600623D RID: 25149 RVA: 0x00D95558 File Offset: 0x00D93758
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderDungeonList(bool isButton)
	{
		if (250436 - 399882 != -149445)
		{
		}
		for (;;)
		{
			IL_C70:
			if (this.r5ycMTEYxlX)
			{
				if (237993 - 436873 != -198880)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)210, (float)0, (float)232, (float)47), this.r5ycMTEYxlX);
				if (78133 - 138747 != -60614)
				{
					continue;
				}
			}
			if (this.HeGcCkg9Cyt != eMissionState.selectQuest)
			{
				if (161381 - 397274 != -235893)
				{
					continue;
				}
				if (this.HeGcCkg9Cyt != eMissionState.createQuest)
				{
					if (52286 - 52043 == 244)
					{
						continue;
					}
					if (this.HeGcCkg9Cyt != eMissionState.joinQuest)
					{
						if (180224 - 165654 != 14570)
						{
							continue;
						}
						if (this.HeGcCkg9Cyt != eMissionState.createTeam)
						{
							if (255230 - 47044 != 208186)
							{
								continue;
							}
							if (this.HeGcCkg9Cyt != eMissionState.joinTeam)
							{
								goto IL_7F7;
							}
							if (205599 - 93977 == 111623)
							{
								continue;
							}
						}
					}
				}
			}
			if (!this.rrScL5a5H6E)
			{
				if (107721 - 287404 != -179683)
				{
					continue;
				}
				int mGameCode = Game.mGameCode;
				if (52861 - 53193 != -332)
				{
					continue;
				}
				if (mGameCode == 32)
				{
					if (16564 - 595102 == -578537)
					{
						continue;
					}
					this.rrScL5a5H6E = (Texture)Resources.Load("GameGui/MissionWindow/dungeon_ice", typeof(Texture));
					if (150023 - 370267 == -220243)
					{
						continue;
					}
				}
				else if (mGameCode == 34)
				{
					if (203366 - 13138 == 190229)
					{
						continue;
					}
					this.rrScL5a5H6E = (Texture)Resources.Load("GameGui/MissionWindow/dungeon_sand", typeof(Texture));
					if (54812 - 494399 == -439586)
					{
						continue;
					}
				}
				else if (mGameCode == 33)
				{
					if (131430 - 262755 == -131324)
					{
						continue;
					}
					this.rrScL5a5H6E = (Texture)Resources.Load("GameGui/MissionWindow/dungeon_water", typeof(Texture));
					if (128000 - 75795 == 52206)
					{
						continue;
					}
				}
				else if (mGameCode == 35)
				{
					if (232205 - 288504 != -56299)
					{
						continue;
					}
					this.rrScL5a5H6E = (Texture)Resources.Load("GameGui/MissionWindow/dungeon_demon", typeof(Texture));
					if (19742 - 541773 != -522031)
					{
						continue;
					}
				}
			}
			else if (this.V5wcCFOg9QT == eMissionSelectMode.mission)
			{
				if (262134 - 20532 == 241603)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)143, (float)119, (float)314, (float)543), this.rrScL5a5H6E);
				if (222012 - 532981 != -310969)
				{
					continue;
				}
			}
			IL_7F7:
			if (this.V5wcCFOg9QT == eMissionSelectMode.mission)
			{
				if (198016 - 335608 != -137592)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)155, (float)62, (float)76, (float)31), this.VTwcMM157vy.hover.background);
				if (193916 - 465171 == -271254)
				{
					continue;
				}
				if (this.P5icf9iNE46 != string.Empty)
				{
					if (193359 - 478583 != -285224)
					{
						continue;
					}
					GUI.BeginGroup(new Rect((float)165, (float)230, (float)250, (float)390));
					if (206133 - 573718 != -367585)
					{
						continue;
					}
					GUI.Label(new Rect((float)0, (float)400 - (float)12 * (Time.time - this.lS2cLcPvK4w) % (float)600, (float)250, (float)600), this.P5icf9iNE46, this.sttcfc0d0X5);
					if (191041 - 134307 != 56734)
					{
						continue;
					}
					GUI.EndGroup();
					if (251265 - 210353 != 40912)
					{
						continue;
					}
				}
			}
			else if (isButton)
			{
				if (290402 - 257909 == 32494)
				{
					continue;
				}
				if (GUI.Button(new Rect((float)155, (float)62, (float)76, (float)31), string.Empty, this.VTwcMM157vy))
				{
					if (270308 - 248802 == 21507)
					{
						continue;
					}
					this.V5wcCFOg9QT = eMissionSelectMode.mission;
					if (330 - 394276 == -393945)
					{
						continue;
					}
					int mGameCode2 = Game.mGameCode;
					if (17642 - 184531 != -166889)
					{
						continue;
					}
					if (mGameCode2 == 32)
					{
						if (246820 - 407723 == -160902)
						{
							continue;
						}
						this.vpEcCKjSAwn = 972;
						if (18903 - 129437 == -110533)
						{
							continue;
						}
					}
					else if (mGameCode2 == 34)
					{
						if (279684 - 570031 == -290346)
						{
							continue;
						}
						this.vpEcCKjSAwn = 971;
						if (12358 - 423826 == -411467)
						{
							continue;
						}
					}
					else if (mGameCode2 == 33)
					{
						if (23256 - 167903 != -144647)
						{
							continue;
						}
						this.vpEcCKjSAwn = 973;
						if (198127 - 285767 == -87639)
						{
							continue;
						}
					}
					else if (mGameCode2 == 35)
					{
						if (3067 - 93171 == -90103)
						{
							continue;
						}
						this.vpEcCKjSAwn = 974;
						if (96420 - 375729 == -279308)
						{
							continue;
						}
					}
					this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
					if (233280 - 410892 != -177612)
					{
						continue;
					}
					this.l20cCzKUHlN = 0;
					if (9049 - 167837 == -158787)
					{
						continue;
					}
					this.audio.PlayOneShot(this.phJcfNLcQPB);
					if (18249 - 487140 == -468890)
					{
						continue;
					}
				}
			}
			if (this.V5wcCFOg9QT == eMissionSelectMode.area)
			{
				if (228113 - 209870 == 18244)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)240, (float)62, (float)68, (float)31), this.YbycMf7ENWK.hover.background);
				if (91928 - 479966 == -388037)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (86159 - 352402 != -266243)
				{
					continue;
				}
				if (this.acHcCWIWCnx < Time.time - (float)3)
				{
					if (112542 - 15425 == 97118)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)240, (float)62, (float)68, (float)31), string.Empty, this.YbycMf7ENWK))
					{
						if (236036 - 530218 == -294181)
						{
							continue;
						}
						this.V5wcCFOg9QT = eMissionSelectMode.area;
						if (35925 - 301721 == -265795)
						{
							continue;
						}
						if (this.acHcCWIWCnx < Time.time - (float)1)
						{
							if (140386 - 205868 != -65482)
							{
								continue;
							}
							this.ResetMissionDes();
							if (42172 - 24370 == 17803)
							{
								continue;
							}
							this.acHcCWIWCnx = Time.time;
							if (150044 - 167683 != -17639)
							{
								continue;
							}
							this.ListMission(5);
							if (203903 - 230843 == -26939)
							{
								continue;
							}
						}
						this.audio.PlayOneShot(this.phJcfNLcQPB);
						if (142938 - 109121 == 33818)
						{
							continue;
						}
					}
				}
			}
			if (this.V5wcCFOg9QT == eMissionSelectMode.guild)
			{
				if (88155 - 582353 != -494198)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)314, (float)62, (float)68, (float)31), this.Nv1cML8YUFd.hover.background);
				if (118544 - 526533 != -407989)
				{
					continue;
				}
			}
			else if (isButton)
			{
				if (92109 - 244081 != -151972)
				{
					continue;
				}
				if (this.acHcCWIWCnx < Time.time - (float)3)
				{
					if (12727 - 320236 != -307509)
					{
						continue;
					}
					if (GUI.Button(new Rect((float)314, (float)62, (float)68, (float)31), string.Empty, this.Nv1cML8YUFd))
					{
						if (105512 - 419074 != -313562)
						{
							continue;
						}
						this.V5wcCFOg9QT = eMissionSelectMode.guild;
						if (168952 - 315131 == -146178)
						{
							continue;
						}
						if (this.acHcCWIWCnx < Time.time - (float)1)
						{
							if (85212 - 435954 == -350741)
							{
								continue;
							}
							this.ResetMissionDes();
							if (150412 - 299404 != -148992)
							{
								continue;
							}
							this.acHcCWIWCnx = Time.time;
							if (213215 - 538035 != -324820)
							{
								continue;
							}
							this.ListMission(6);
							if (227730 - 586157 == -358426)
							{
								continue;
							}
						}
						this.audio.PlayOneShot(this.phJcfNLcQPB);
						if (290036 - 354990 == -64953)
						{
							continue;
						}
					}
				}
			}
			if (109420 - 192036 == -82616)
			{
				eMissionSelectMode v5wcCFOg9QT = this.V5wcCFOg9QT;
				if (204137 - 22026 != 182112)
				{
					if (v5wcCFOg9QT == eMissionSelectMode.area)
					{
						if (267071 - 510596 == -243524)
						{
							continue;
						}
					}
					else
					{
						if (v5wcCFOg9QT != eMissionSelectMode.guild)
						{
							break;
						}
						if (71980 - 544919 != -472939)
						{
							continue;
						}
					}
					if (this.Co1cMnsGxjd != null)
					{
						if (95437 - 33968 != 61469)
						{
							continue;
						}
						if (this.acHcCWIWCnx > Time.time - (float)1)
						{
							if (178348 - 181514 == -3165)
							{
								continue;
							}
						}
						else if (Extensions.get_length(this.Co1cMnsGxjd) == 0)
						{
							if (82465 - 186794 != -104328)
							{
								if (this.V5wcCFOg9QT == eMissionSelectMode.area)
								{
									if (11958 - 440622 != -428664)
									{
										continue;
									}
									this.RenderNoticeBar("No area mission available");
									if (85933 - 528720 == -442786)
									{
										continue;
									}
								}
								else if (this.V5wcCFOg9QT == eMissionSelectMode.guild)
								{
									if (198465 - 157466 != 40999)
									{
										continue;
									}
									this.RenderNoticeBar("No guild mission available");
									if (273064 - 362555 == -89490)
									{
										continue;
									}
								}
								goto IL_102B;
							}
							continue;
						}
						else
						{
							int num = 0;
							if (248370 - 86647 != 161723)
							{
								continue;
							}
							int i = 0;
							if (230500 - 365926 == -135425)
							{
								continue;
							}
							MissionListClass[] co1cMnsGxjd = this.Co1cMnsGxjd;
							if (270470 - 408278 == -137807)
							{
								continue;
							}
							int length = co1cMnsGxjd.Length;
							if (223235 - 115867 == 107369)
							{
								continue;
							}
							while (i < length)
							{
								if (num < 8)
								{
									if (154966 - 473014 == -318047)
									{
										goto IL_C70;
									}
									num++;
									if (194654 - 462689 != -268035)
									{
										goto IL_C70;
									}
									MissionClass data = MissionData.getData(co1cMnsGxjd[i].roomCode);
									if (177762 - 542419 != -364657)
									{
										goto IL_C70;
									}
									string text = "Arena " + num + "  " + data.name;
									if (172593 - 306182 == -133588)
									{
										goto IL_C70;
									}
									string text2 = "[" + co1cMnsGxjd[i].roomPlayer + "/" + data.player + "] by: " + co1cMnsGxjd[i].roomOwner;
									if (290630 - 205565 == 85066)
									{
										goto IL_C70;
									}
									if (isButton)
									{
										if (277490 - 68584 != 208906)
										{
											goto IL_C70;
										}
										if (this.l20cCzKUHlN == co1cMnsGxjd[i].roomID)
										{
											if (2286 - 431532 != -429246)
											{
												goto IL_C70;
											}
											GUI.Label(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), text, this.jeMcMVdaOFZ);
											if (144468 - 529236 != -384768)
											{
												goto IL_C70;
											}
											GUI.Label(new Rect((float)156, (float)(140 + 60 * num), (float)270, (float)30), text2, this.PEQcMzR3pyj);
											if (217456 - 599470 != -382014)
											{
												goto IL_C70;
											}
										}
										else
										{
											if (GUI.Button(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), text, this.mu6cMycy0Ne))
											{
												if (290989 - 452982 == -161992)
												{
													goto IL_C70;
												}
												this.l20cCzKUHlN = co1cMnsGxjd[i].roomID;
												if (51898 - 395349 == -343450)
												{
													goto IL_C70;
												}
												this.vpEcCKjSAwn = co1cMnsGxjd[i].roomCode;
												if (8046 - 226648 == -218601)
												{
													goto IL_C70;
												}
												PlayerPrefs.SetInt("lastArena", this.vpEcCKjSAwn);
												if (290771 - 38277 != 252494)
												{
													goto IL_C70;
												}
												this.jRIcMpVcPPy = (Texture)MissionData.getImg(this.vpEcCKjSAwn);
												if (226105 - 131548 != 94557)
												{
													goto IL_C70;
												}
												this.audio.PlayOneShot(this.phJcfNLcQPB);
												if (274232 - 390967 != -116735)
												{
													goto IL_C70;
												}
											}
											GUI.Label(new Rect((float)156, (float)(140 + 60 * num), (float)270, (float)30), text2, this.PEQcMzR3pyj);
											if (179902 - 249223 != -69321)
											{
												goto IL_C70;
											}
										}
									}
									else
									{
										if (this.l20cCzKUHlN == co1cMnsGxjd[i].roomID)
										{
											if (237526 - 264634 == -27107)
											{
												goto IL_C70;
											}
											GUI.Label(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), text, this.a7KcMhwvE0q);
											if (53770 - 236561 != -182791)
											{
												goto IL_C70;
											}
										}
										else
										{
											GUI.Label(new Rect((float)156, (float)(110 + 60 * num), (float)270, (float)30), text, this.Bo6cMKxjM2x);
											if (61449 - 25670 == 35780)
											{
												goto IL_C70;
											}
										}
										GUI.Label(new Rect((float)156, (float)(140 + 60 * num), (float)270, (float)30), text2, this.PEQcMzR3pyj);
										if (257512 - 338908 == -81395)
										{
											goto IL_C70;
										}
									}
								}
								i++;
								if (260079 - 574007 == -313927)
								{
									goto IL_C70;
								}
							}
							if (14842 - 398331 != -383489)
							{
								continue;
							}
							goto IL_102B;
						}
					}
					this.RenderNoticeBar("Updating mission list...");
					if (168387 - 341158 != -172771)
					{
						continue;
					}
					IL_102B:
					GUI.DrawTexture(new Rect((float)117, (float)606, (float)343, (float)69), this.WKDcMqjWvjD);
					if (295770 - 383332 != -87561)
					{
						if (!isButton)
						{
							break;
						}
						if (291601 - 87963 == 203638)
						{
							if (this.acHcCWIWCnx >= Time.time - (float)2)
							{
								break;
							}
							if (103731 - 26622 == 77109)
							{
								if (!GUI.Button(new Rect((float)355, (float)625, (float)82, (float)27), string.Empty, this.CAscftTnFA0))
								{
									break;
								}
								if (25093 - 246903 != -221809)
								{
									this.ResetMissionDes();
									if (90839 - 54408 == 36431)
									{
										this.acHcCWIWCnx = Time.time;
										if (162479 - 541940 == -379461)
										{
											if (this.V5wcCFOg9QT == eMissionSelectMode.area)
											{
												if (80450 - 595698 != -515247)
												{
													this.ListMission(5);
													if (119464 - 54901 == 64563)
													{
														break;
													}
												}
											}
											else
											{
												this.ListMission(6);
												if (2941 - 550020 == -547079)
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

	// Token: 0x0600623E RID: 25150 RVA: 0x00D968C8 File Offset: 0x00D94AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetMissionDes()
	{
		if (275085 - 204370 != 70715)
		{
		}
		for (;;)
		{
			this.vpEcCKjSAwn = 0;
			if (215074 - 429322 != -214247)
			{
				this.l20cCzKUHlN = 0;
				if (266886 - 250328 != 16559)
				{
					this.jRIcMpVcPPy = null;
					if (194381 - 424561 == -230180)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600623F RID: 25151 RVA: 0x00D96964 File Offset: 0x00D94B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderMissionDes()
	{
		if (125416 - 67672 != 57744)
		{
		}
		while (this.vpEcCKjSAwn != 0)
		{
			if (69922 - 294314 == -224392)
			{
				MissionClass data = MissionData.getData(this.vpEcCKjSAwn);
				if (23297 - 294679 == -271382)
				{
					if (this.jRIcMpVcPPy != null)
					{
						if (165931 - 349312 != -183381)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)512, (float)60, (float)434, (float)285), this.jRIcMpVcPPy);
						if (166651 - 454484 == -287832)
						{
							continue;
						}
					}
					if (data.des != "none")
					{
						if (211659 - 338134 == -126474)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)484, (float)345, (float)421, (float)50), this.zfZcMYeRYTY);
						if (283205 - 394179 == -110973)
						{
							continue;
						}
						GUI.Label(new Rect((float)520, (float)400, (float)400, (float)400), data.des, this.F5icf5cI9vA);
						if (207616 - 57411 == 150206)
						{
							continue;
						}
					}
					if (!(data.obj != "none"))
					{
						break;
					}
					if (283328 - 51421 == 231907)
					{
						GUI.DrawTexture(new Rect((float)484, (float)485, (float)421, (float)50), this.ALNcM3KeNBF);
						if (143260 - 438087 == -294827)
						{
							GUI.Label(new Rect((float)520, (float)550, (float)400, (float)400), data.obj, this.F5icf5cI9vA);
							if (9325 - 303957 != -294631)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006240 RID: 25152 RVA: 0x00D96BC0 File Offset: 0x00D94DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitRecordBar()
	{
		if (69772 - 546442 != -476670)
		{
		}
		for (;;)
		{
			this.EFOcLn5mHXy = new GUIStyle();
			if (266092 - 352906 != -86813)
			{
				this.EFOcLn5mHXy.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
				if (99167 - 118092 != -18924)
				{
					this.EFOcLn5mHXy.alignment = TextAnchor.MiddleRight;
					if (128995 - 467977 != -338981)
					{
						this.EFOcLn5mHXy.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (87371 - 447277 == -359906)
						{
							this.KiacLQSVgxN = (Texture)Resources.Load("GameGui/MissionWindow/missionTime", typeof(Texture));
							if (248237 - 553757 != -305519)
							{
								this.qxccLeFCYe3 = (Texture)Resources.Load("GameGui/MissionWindow/missionExpire", typeof(Texture));
								if (66851 - 173062 == -106211)
								{
									int mGameCode = Game.mGameCode;
									if (114549 - 15352 == 99197)
									{
										if (mGameCode == 32)
										{
											if (42336 - 434921 != -392585)
											{
												continue;
											}
											this.qqncLI3OMaf = (Texture)Resources.Load("GameGui/MissionWindow/missionDungeon2", typeof(Texture));
											if (260385 - 585496 != -325111)
											{
												continue;
											}
										}
										else if (mGameCode == 34)
										{
											if (258925 - 329252 != -70327)
											{
												continue;
											}
											this.qqncLI3OMaf = (Texture)Resources.Load("GameGui/MissionWindow/missionDungeon1", typeof(Texture));
											if (186449 - 513608 == -327158)
											{
												continue;
											}
										}
										else if (mGameCode == 33)
										{
											if (36160 - 197099 != -160939)
											{
												continue;
											}
											this.qqncLI3OMaf = (Texture)Resources.Load("GameGui/MissionWindow/missionDungeon3", typeof(Texture));
											if (256715 - 74129 != 182586)
											{
												continue;
											}
										}
										else if (mGameCode == 35)
										{
											if (299861 - 392367 != -92506)
											{
												continue;
											}
											this.qqncLI3OMaf = (Texture)Resources.Load("GameGui/MissionWindow/missionDungeon4", typeof(Texture));
											if (142883 - 321964 != -179081)
											{
												continue;
											}
										}
										else
										{
											this.qqncLI3OMaf = (Texture)Resources.Load("GameGui/MissionWindow/missionDungeon", typeof(Texture));
											if (226302 - 493479 == -267176)
											{
												continue;
											}
										}
										this.MaXcLJ46CqE = (Texture)Resources.Load("GameGui/Number/bAll", typeof(Texture));
										if (199323 - 334218 == -134895)
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

	// Token: 0x06006241 RID: 25153 RVA: 0x00D96F4C File Offset: 0x00D9514C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderRecordBar()
	{
		if (11438 - 297775 != -286336)
		{
		}
		for (;;)
		{
			if (this.vpEcCKjSAwn != 0)
			{
				if (285647 - 555875 == -270228)
				{
					MissionClass data = MissionData.getData(this.vpEcCKjSAwn);
					if (172008 - 235313 == -63305)
					{
						if (data.type != eMissionType.@event)
						{
							if (103395 - 576331 != -472936)
							{
								continue;
							}
							if (this.vpEcCKjSAwn == 938)
							{
								goto IL_666;
							}
							if (3918 - 330506 != -326588)
							{
								continue;
							}
							if (this.vpEcCKjSAwn == 971)
							{
								goto IL_666;
							}
							if (141892 - 438800 == -296907)
							{
								continue;
							}
							if (this.vpEcCKjSAwn == 972)
							{
								goto IL_666;
							}
							if (137457 - 403046 == -265588)
							{
								continue;
							}
							if (this.vpEcCKjSAwn == 973)
							{
								goto IL_666;
							}
							if (104495 - 181330 != -76835)
							{
								continue;
							}
							if (this.vpEcCKjSAwn == 974)
							{
								if (27806 - 49957 != -22150)
								{
									goto IL_666;
								}
								continue;
							}
							else if (data.lv != 0)
							{
								if (199591 - 524754 == -325162)
								{
									continue;
								}
								Guix.renderTwoSmallNumberWithTilda(400, 710, Mathf.Clamp(data.lv, 1, 80), Mathf.Clamp(data.lv + 6, 1, 80), false, 1f);
								if (297429 - 518250 != -220821)
								{
									continue;
								}
							}
							else
							{
								GUI.DrawTexture(new Rect((float)360, (float)710, (float)54, (float)33), this.MaXcLJ46CqE);
								if (58073 - 431861 == -373787)
								{
									continue;
								}
							}
							IL_640:
							int missionNumber = MissionData.getMissionNumber(this.vpEcCKjSAwn);
							if (189026 - 530056 != -341030)
							{
								continue;
							}
							int num = PlayerData.MissionWin[missionNumber - 1];
							if (283338 - 141262 == 142077)
							{
								continue;
							}
							int num2 = PlayerData.MissionLose[missionNumber - 1];
							if (19422 - 381946 != -362524)
							{
								continue;
							}
							int num3 = PlayerData.MissionWithdraw[missionNumber - 1];
							if (257110 - 219752 != 37358)
							{
								continue;
							}
							int num4;
							if (num == 0)
							{
								if (251519 - 132779 == 118741)
								{
									continue;
								}
								num4 = 0;
							}
							else
							{
								num4 = Mathf.FloorToInt((float)(100 * num / (num + num2 + num3)));
							}
							int num5 = num4;
							int nRank = PlayerData.MissionList[missionNumber - 1];
							if (67584 - 540568 == -472983)
							{
								continue;
							}
							string text = null;
							if (21710 - 276339 != -254629)
							{
								continue;
							}
							if (num <= 0)
							{
								if (133748 - 200310 != -66562)
								{
									continue;
								}
								text += " -- ";
								if (204548 - 496584 == -292035)
								{
									continue;
								}
							}
							else
							{
								text = " " + num;
								if (129007 - 383604 == -254596)
								{
									continue;
								}
							}
							if (num2 <= 0)
							{
								if (101312 - 321075 == -219762)
								{
									continue;
								}
								text += " / -- ";
								if (243394 - 134477 == 108918)
								{
									continue;
								}
							}
							else
							{
								text += " / " + num2;
								if (159564 - 497665 == -338100)
								{
									continue;
								}
							}
							if (num3 <= 0)
							{
								if (224608 - 292371 != -67763)
								{
									continue;
								}
								text += " / -- ";
								if (277023 - 14465 == 262559)
								{
									continue;
								}
							}
							else
							{
								text += " / " + num3;
								if (101020 - 373641 != -272621)
								{
									continue;
								}
							}
							GUI.Label(new Rect((float)210, (float)745, (float)200, (float)100), text, this.EFOcLn5mHXy);
							if (120730 - 337559 != -216829)
							{
								continue;
							}
							if (num5 <= 0)
							{
								if (276553 - 380433 == -103879)
								{
									continue;
								}
								GUI.Label(new Rect((float)210, (float)820, (float)210, (float)35), "--", this.EFOcLn5mHXy);
								if (158451 - 368321 == -209869)
								{
									continue;
								}
							}
							else
							{
								GUI.Label(new Rect((float)210, (float)820, (float)210, (float)35), num5 + "%", this.EFOcLn5mHXy);
								if (49371 - 71215 != -21844)
								{
									continue;
								}
							}
							Guix.renderRankNumber(375, 866, nRank, 1f);
							if (287562 - 501252 != -213690)
							{
								continue;
							}
							goto IL_712;
							IL_666:
							Guix.renderTwoSmallNumberWithTilda(400, 710, data.lv, Game.maxLevel, false, 1f);
							if (73138 - 587014 != -513876)
							{
								continue;
							}
							goto IL_640;
						}
						else
						{
							GUI.DrawTexture(new Rect((float)360, (float)710, (float)54, (float)33), this.MaXcLJ46CqE);
							if (119152 - 317373 != -198221)
							{
								continue;
							}
							GUI.Label(new Rect((float)210, (float)745, (float)200, (float)100), " --  /  --  /  --", this.EFOcLn5mHXy);
							if (258426 - 489817 != -231391)
							{
								continue;
							}
							GUI.Label(new Rect((float)210, (float)820, (float)210, (float)35), "--", this.EFOcLn5mHXy);
							if (18805 - 590790 == -571984)
							{
								continue;
							}
							Guix.renderRankNumber(375, 866, 0, 1f);
							if (94296 - 78926 != 15370)
							{
								continue;
							}
						}
						IL_712:
						int num6 = 0;
						if (138723 - 369076 != -230352)
						{
							if (data.allowItem)
							{
								if (270892 - 348533 != -77641)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)180, (float)924, (float)32, (float)32), this.fjscf3YOutn);
								if (255163 - 272486 != -17323)
								{
									continue;
								}
								num6++;
								if (70878 - 36153 == 34726)
								{
									continue;
								}
							}
							if (data.allowMount)
							{
								if (89956 - 405416 == -315459)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)(180 + 48 * num6), (float)924, (float)32, (float)32), this.tGMcfbCejgj);
								if (202907 - 588486 != -385579)
								{
									continue;
								}
								num6++;
								if (181736 - 59733 != 122003)
								{
									continue;
								}
							}
							if (data.allowChange)
							{
								if (69190 - 18490 == 50701)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)(180 + 48 * num6), (float)924, (float)32, (float)32), this.Ne4cfdZEmjk);
								if (262656 - 331009 != -68353)
								{
									continue;
								}
								num6++;
								if (72839 - 485167 != -412328)
								{
									continue;
								}
							}
							if (data.allowRespawn)
							{
								if (112189 - 78108 != 34081)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)(180 + 48 * num6), (float)924, (float)32, (float)32), this.zlmcfgSatIG);
								if (142441 - 465206 != -322765)
								{
									continue;
								}
								num6++;
								if (206202 - 418790 == -212587)
								{
									continue;
								}
							}
							if (!data.allowCoin)
							{
								break;
							}
							if (175565 - 353209 == -177644)
							{
								GUI.DrawTexture(new Rect((float)(180 + 48 * num6), (float)924, (float)32, (float)32), this.KVicfaMw68h);
								if (255992 - 469206 != -213213)
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
				GUI.Label(new Rect((float)210, (float)745, (float)200, (float)100), " --  /  --  /  --", this.EFOcLn5mHXy);
				if (25027 - 215934 == -190907)
				{
					GUI.Label(new Rect((float)210, (float)862, (float)210, (float)35), "--", this.EFOcLn5mHXy);
					if (187021 - 189212 != -2190)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006242 RID: 25154 RVA: 0x00D97990 File Offset: 0x00D95B90
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderTownRecordBar()
	{
		if (26820 - 556720 != -529900)
		{
		}
		for (;;)
		{
			IL_3E8:
			GUI.DrawTexture(new Rect((float)125, (float)695, (float)334, (float)294), this.KiacLQSVgxN);
			if (45238 - 97153 != -51914)
			{
				if (this.vpEcCKjSAwn == 0)
				{
					if (72463 - 487029 == -414566)
					{
						GUI.Label(new Rect((float)210, (float)745, (float)200, (float)100), " --  /  --  ", this.EFOcLn5mHXy);
						if (185945 - 29841 != 156105)
						{
							break;
						}
					}
				}
				else
				{
					MissionClass data = MissionData.getData(this.vpEcCKjSAwn);
					if (279068 - 43791 == 235277)
					{
						if (data.lv != 0)
						{
							if (158454 - 274218 != -115764)
							{
								continue;
							}
							Guix.renderTwoSmallNumberWithTilda(400, 710, Mathf.Clamp(data.lv, 1, 80), Mathf.Clamp(data.lv + 6, 1, 80), false, 1f);
							if (61445 - 11345 == 50101)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)360, (float)716, (float)54, (float)33), this.MaXcLJ46CqE);
							if (47835 - 249341 != -201506)
							{
								continue;
							}
						}
						GUI.Label(new Rect((float)210, (float)745, (float)200, (float)100), " 12 / 1", this.EFOcLn5mHXy);
						if (157929 - 76058 == 81871)
						{
							if (!RuntimeServices.EqualityOperator(this.n6rcMQX4Xhl, null))
							{
								if (56430 - 354075 == -297644)
								{
									continue;
								}
								int i = 0;
								if (171882 - 359179 == -187296)
								{
									continue;
								}
								MissionListClass[] array = this.n6rcMQX4Xhl;
								if (207111 - 152508 != 54603)
								{
									continue;
								}
								int length = array.Length;
								if (170205 - 450984 == -280778)
								{
									continue;
								}
								while (i < length)
								{
									if (array[i].roomCode == this.vpEcCKjSAwn)
									{
										if (156597 - 590288 == -433690)
										{
											goto IL_3E8;
										}
										if (array[i].roomTimer > Time.time)
										{
											if (138280 - 589588 == -451307)
											{
												goto IL_3E8;
											}
											int num = (int)(array[i].roomTimer - Time.time);
											if (170493 - 64204 != 106289)
											{
												goto IL_3E8;
											}
											int num2 = global::Math.div((float)num, (float)3600);
											if (288615 - 300736 != -12121)
											{
												goto IL_3E8;
											}
											int nMinute = global::Math.div((float)(num - num2 * 3600), (float)60);
											if (179505 - 91019 != 88486)
											{
												goto IL_3E8;
											}
											int nSecond = num % 60;
											if (77184 - 422694 == -345509)
											{
												goto IL_3E8;
											}
											Guix.renderBigNumberTime(390, 860, num2, nMinute, nSecond, 0.5f);
											if (211747 - 66843 == 144905)
											{
												goto IL_3E8;
											}
										}
										else
										{
											GUI.DrawTexture(new Rect((float)260, (float)844, (float)167, (float)47), this.qxccLeFCYe3);
											if (193056 - 355170 == -162113)
											{
												goto IL_3E8;
											}
										}
									}
									i++;
									if (146717 - 124780 != 21937)
									{
										goto IL_3E8;
									}
								}
								if (260811 - 123208 != 137603)
								{
									continue;
								}
							}
							int num3 = 0;
							if (271950 - 186433 == 85517)
							{
								if (data.allowItem)
								{
									if (57403 - 211848 != -154445)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)180, (float)924, (float)32, (float)32), this.fjscf3YOutn);
									if (278834 - 143895 == 134940)
									{
										continue;
									}
									num3++;
									if (121392 - 19780 == 101613)
									{
										continue;
									}
								}
								if (data.allowMount)
								{
									if (28282 - 473531 == -445248)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)(180 + 48 * num3), (float)924, (float)32, (float)32), this.tGMcfbCejgj);
									if (132130 - 292881 == -160750)
									{
										continue;
									}
									num3++;
									if (188284 - 496133 != -307849)
									{
										continue;
									}
								}
								if (data.allowChange)
								{
									if (67990 - 452411 == -384420)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)(180 + 48 * num3), (float)924, (float)32, (float)32), this.Ne4cfdZEmjk);
									if (220777 - 383731 == -162953)
									{
										continue;
									}
									num3++;
									if (162341 - 61877 == 100465)
									{
										continue;
									}
								}
								if (!data.allowRespawn)
								{
									break;
								}
								if (133668 - 434722 != -301053)
								{
									GUI.DrawTexture(new Rect((float)(180 + 48 * num3), (float)924, (float)32, (float)32), this.zlmcfgSatIG);
									if (180084 - 243912 == -63828)
									{
										num3++;
										if (132072 - 426989 != -294916)
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

	// Token: 0x06006243 RID: 25155 RVA: 0x00D98010 File Offset: 0x00D96210
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderArenaRecordBar()
	{
		if (215976 - 48364 != 167613)
		{
		}
		for (;;)
		{
			IL_713:
			GUI.DrawTexture(new Rect((float)125, (float)695, (float)334, (float)294), this.KiacLQSVgxN);
			if (68818 - 534618 == -465800)
			{
				if (this.vpEcCKjSAwn == 0)
				{
					if (67742 - 487284 == -419542)
					{
						GUI.Label(new Rect((float)210, (float)745, (float)200, (float)100), " --  /  --  ", this.EFOcLn5mHXy);
						if (42923 - 244112 == -201189)
						{
							break;
						}
					}
				}
				else
				{
					MissionClass data = MissionData.getData(this.vpEcCKjSAwn);
					if (91368 - 261033 == -169665)
					{
						if (data.lv != 0)
						{
							if (122143 - 357699 == -235555)
							{
								continue;
							}
							GUI.DrawTexture(new Rect((float)360, (float)710, (float)54, (float)33), this.MaXcLJ46CqE);
							if (270063 - 214370 == 55694)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect((float)360, (float)716, (float)54, (float)33), this.MaXcLJ46CqE);
							if (51854 - 250570 == -198715)
							{
								continue;
							}
						}
						string text = " --  /  --  ";
						if (284744 - 75252 == 209492)
						{
							int num = this.vpEcCKjSAwn;
							if (298692 - 504725 != -206032)
							{
								if (num == 941)
								{
									if (256607 - 128072 == 128536)
									{
										continue;
									}
									text = "1 / 8 ";
									if (298246 - 532117 == -233870)
									{
										continue;
									}
								}
								else if (num == 942)
								{
									if (104314 - 377150 != -272836)
									{
										continue;
									}
									text = "3 / 2 ";
									if (23601 - 193221 == -169619)
									{
										continue;
									}
								}
								else if (num == 943)
								{
									if (199939 - 375090 != -175151)
									{
										continue;
									}
									text = "5 / 2 ";
									if (75056 - 91 == 74966)
									{
										continue;
									}
								}
								GUI.Label(new Rect((float)210, (float)745, (float)200, (float)100), text, this.EFOcLn5mHXy);
								if (76710 - 230192 == -153482)
								{
									if (!RuntimeServices.EqualityOperator(this.HTmcMeto4Zx, null))
									{
										if (102862 - 437176 == -334313)
										{
											continue;
										}
										int i = 0;
										if (14561 - 260948 == -246386)
										{
											continue;
										}
										MissionListClass[] htmcMeto4Zx = this.HTmcMeto4Zx;
										if (76818 - 86830 != -10012)
										{
											continue;
										}
										int length = htmcMeto4Zx.Length;
										if (81899 - 259751 != -177852)
										{
											continue;
										}
										while (i < length)
										{
											if (htmcMeto4Zx[i].roomCode == this.vpEcCKjSAwn)
											{
												if (145865 - 77141 == 68725)
												{
													goto IL_713;
												}
												if (htmcMeto4Zx[i].roomTimer > Time.time)
												{
													if (222847 - 16709 != 206138)
													{
														goto IL_713;
													}
													int num2 = (int)(htmcMeto4Zx[i].roomTimer - Time.time);
													if (286895 - 13053 == 273843)
													{
														goto IL_713;
													}
													int num3 = global::Math.div((float)num2, (float)3600);
													if (277165 - 346198 == -69032)
													{
														goto IL_713;
													}
													int nMinute = global::Math.div((float)(num2 - num3 * 3600), (float)60);
													if (226673 - 116542 == 110132)
													{
														goto IL_713;
													}
													int nSecond = num2 % 60;
													if (247727 - 295629 == -47901)
													{
														goto IL_713;
													}
													Guix.renderBigNumberTime(390, 860, num3, nMinute, nSecond, 0.5f);
													if (154915 - 264658 != -109743)
													{
														goto IL_713;
													}
												}
												else
												{
													GUI.DrawTexture(new Rect((float)260, (float)844, (float)167, (float)47), this.qxccLeFCYe3);
													if (264565 - 552995 == -288429)
													{
														goto IL_713;
													}
												}
											}
											i++;
											if (253072 - 107563 != 145509)
											{
												goto IL_713;
											}
										}
										if (179387 - 551508 == -372120)
										{
											continue;
										}
									}
									int num4 = 0;
									if (79947 - 157270 == -77323)
									{
										if (data.allowItem)
										{
											if (294477 - 285891 != 8586)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)180, (float)924, (float)32, (float)32), this.fjscf3YOutn);
											if (111842 - 544673 != -432831)
											{
												continue;
											}
											num4++;
											if (248555 - 22698 == 225858)
											{
												continue;
											}
										}
										if (data.allowMount)
										{
											if (170873 - 326476 != -155603)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)(180 + 48 * num4), (float)924, (float)32, (float)32), this.tGMcfbCejgj);
											if (197245 - 164836 != 32409)
											{
												continue;
											}
											num4++;
											if (42672 - 25337 != 17335)
											{
												continue;
											}
										}
										if (data.allowChange)
										{
											if (35631 - 274989 != -239358)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)(180 + 48 * num4), (float)924, (float)32, (float)32), this.Ne4cfdZEmjk);
											if (46990 - 21658 == 25333)
											{
												continue;
											}
											num4++;
											if (194756 - 166566 != 28190)
											{
												continue;
											}
										}
										if (!data.allowRespawn)
										{
											break;
										}
										if (261819 - 563952 == -302133)
										{
											GUI.DrawTexture(new Rect((float)(180 + 48 * num4), (float)924, (float)32, (float)32), this.zlmcfgSatIG);
											if (113968 - 534805 != -420836)
											{
												num4++;
												if (14256 - 253095 == -238839)
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

	// Token: 0x06006244 RID: 25156 RVA: 0x00D987A4 File Offset: 0x00D969A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderDungeonBar()
	{
		GUI.DrawTexture(new Rect((float)125, (float)695, (float)334, (float)294), this.qqncLI3OMaf);
	}

	// Token: 0x06006245 RID: 25157 RVA: 0x00D987CC File Offset: 0x00D969CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderNoticeBar(string s)
	{
		GUI.DrawTexture(new Rect((float)495, (float)570, (float)475, (float)102), this.RGUcMGX8HcF);
		GUI.Label(new Rect((float)530, (float)600, (float)400, (float)40), s, this.NKVcfn22ZtW);
	}

	// Token: 0x06006246 RID: 25158 RVA: 0x00D98824 File Offset: 0x00D96A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderDragPlayer()
	{
		if (141462 - 164205 != -22743)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (90549 - 306529 == -215980)
				{
					break;
				}
			}
			else
			{
				if (this.t4jcfsesB5S == -1)
				{
					break;
				}
				if (25239 - 297135 == -271896)
				{
					if (Input.GetMouseButton(1))
					{
						if (31143 - 158725 == -127582)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (211332 - 125659 != 85674)
							{
								Rect position = new Rect((mousePosition.x - (float)45) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)20) * (float)1024 / (float)Screen.height, (float)197, (float)41);
								if (39439 - 86768 == -47329)
								{
									GUI.DrawTexture(position, this.LavcfGMel9m.normal.background);
									if (144510 - 241034 == -96524)
									{
										GUI.Label(position, "  " + this.hxLcMIbiaoH[this.t4jcfsesB5S].playerName, this.DW8cflw6LAd);
										if (239178 - 113534 != 125645)
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
						this.t4jcfsesB5S = -1;
						if (261205 - 507272 == -246067)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006247 RID: 25159 RVA: 0x00D989F8 File Offset: 0x00D96BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitChatBar()
	{
		if (272546 - 275249 != -2702)
		{
		}
		for (;;)
		{
			this.iiRcLteLIxb = new GUIStyle();
			if (211847 - 469764 != -257916)
			{
				this.iiRcLteLIxb.font = (Font)Resources.Load("GameGui/Fonts/GMO28");
				if (224512 - 140994 != 83519)
				{
					this.l5tcL2NTHk1 = new GUIStyle();
					if (292524 - 550045 == -257521)
					{
						this.l5tcL2NTHk1.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/chatAreaButton", typeof(Texture)));
						if (294212 - 590378 == -296166)
						{
							this.l5tcL2NTHk1.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/chatAreaButton_h", typeof(Texture)));
							if (89444 - 476474 != -387029)
							{
								this.yxrcLvgCnb3 = new GUIStyle();
								if (204654 - 285118 != -80463)
								{
									this.yxrcLvgCnb3.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/chatMissionButton", typeof(Texture)));
									if (59865 - 302415 == -242550)
									{
										this.yxrcLvgCnb3.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MissionWindow/chatMissionButton_h", typeof(Texture)));
										if (163615 - 56246 == 107369)
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

	// Token: 0x06006248 RID: 25160 RVA: 0x00D98BF4 File Offset: 0x00D96DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderChatBar()
	{
		if (29292 - 401352 != -372059)
		{
		}
		for (;;)
		{
			IL_281:
			if (this.HeGcCkg9Cyt != eMissionState.selectQuest)
			{
				if (226289 - 78164 == 148126)
				{
					continue;
				}
				if (this.HeGcCkg9Cyt != eMissionState.error)
				{
					goto IL_DF0;
				}
				if (129023 - 225487 == -96463)
				{
					continue;
				}
			}
			this.RWFcLOoCcpG = true;
			if (53201 - 334656 != -281455)
			{
				continue;
			}
			IL_DF0:
			this.uRscLX5Cell = GUI.BeginScrollView(new Rect(this.T45cCyVhtgd - (float)520, (float)740, (float)486, (float)184), this.uRscLX5Cell, new Rect((float)0, (float)0, (float)450, (float)3000), false, true);
			if (249694 - 503237 != -253542)
			{
				int num = 0;
				if (15080 - 181263 != -166182)
				{
					int i = Chat.ChatEntries.length - 1;
					if (153401 - 292905 != -139503)
					{
						while (i >= 0)
						{
							object obj2;
							object obj = obj2 = Chat.ChatEntries[i];
							if (!(obj is ChatEntry))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(ChatEntry));
							}
							ChatEntry chatEntry = (ChatEntry)obj2;
							if (141860 - 454835 != -312975)
							{
								goto IL_281;
							}
							if (!this.RWFcLOoCcpG)
							{
								goto IL_911;
							}
							if (78978 - 199620 == -120641)
							{
								goto IL_281;
							}
							if (chatEntry.mode == eChatMode.area)
							{
								goto IL_81A;
							}
							if (28958 - 267297 == -238338)
							{
								goto IL_281;
							}
							if (chatEntry.mode == eChatMode.guild)
							{
								goto IL_81A;
							}
							if (19711 - 391518 == -371806)
							{
								goto IL_281;
							}
							if (chatEntry.mode == eChatMode.whisper)
							{
								goto IL_81A;
							}
							if (152978 - 9126 != 143852)
							{
								goto IL_281;
							}
							if (chatEntry.mode == eChatMode.system)
							{
								goto IL_81A;
							}
							if (292809 - 111027 != 181782)
							{
								goto IL_281;
							}
							if (chatEntry.mode == eChatMode.world)
							{
								goto IL_81A;
							}
							if (121260 - 277247 != -155986)
							{
								goto IL_911;
							}
							goto IL_281;
							IL_8F3:
							i--;
							if (68058 - 205435 != -137377)
							{
								goto IL_281;
							}
							continue;
							IL_911:
							if (!this.RWFcLOoCcpG)
							{
								if (287891 - 218699 != 69192)
								{
									goto IL_281;
								}
								if (chatEntry.mode == eChatMode.mission)
								{
									goto IL_81A;
								}
								if (33797 - 446707 == -412909)
								{
									goto IL_281;
								}
							}
							if (chatEntry.mode != eChatMode.world)
							{
								goto IL_8F3;
							}
							if (55119 - 324212 != -269093)
							{
								goto IL_281;
							}
							IL_81A:
							if (num >= 100)
							{
								goto IL_8F3;
							}
							if (273322 - 335640 != -62318)
							{
								goto IL_281;
							}
							num++;
							if (104619 - 188652 != -84033)
							{
								goto IL_281;
							}
							string text = string.Empty;
							if (163318 - 526940 == -363621)
							{
								goto IL_281;
							}
							eChatMode mode = chatEntry.mode;
							if (229070 - 380731 == -151660)
							{
								goto IL_281;
							}
							if (mode == eChatMode.area)
							{
								if (90338 - 160074 != -69736)
								{
									goto IL_281;
								}
								text = "[Area] ";
								if (213584 - 182047 == 31538)
								{
									goto IL_281;
								}
								this.iiRcLteLIxb.normal.textColor = new Color((float)0, 0.45f, (float)0, (float)1);
								if (80918 - 527710 == -446791)
								{
									goto IL_281;
								}
							}
							else if (mode == eChatMode.guild)
							{
								if (78058 - 228343 != -150285)
								{
									goto IL_281;
								}
								text = "[Gld] ";
								if (200771 - 19100 != 181671)
								{
									goto IL_281;
								}
								this.iiRcLteLIxb.normal.textColor = new Color((float)0, 0.44f, 0.64f, (float)1);
								if (63154 - 17377 == 45778)
								{
									goto IL_281;
								}
							}
							else if (mode == eChatMode.whisper)
							{
								if (113429 - 277298 == -163868)
								{
									goto IL_281;
								}
								text = "[Wsp] ";
								if (57009 - 22096 == 34914)
								{
									goto IL_281;
								}
								this.iiRcLteLIxb.normal.textColor = new Color(0.7f, 0.26f, 0.53f, (float)1);
								if (99958 - 177990 != -78032)
								{
									goto IL_281;
								}
							}
							else if (mode == eChatMode.world)
							{
								if (65632 - 37495 == 28138)
								{
									goto IL_281;
								}
								text = "[Wld] ";
								if (124764 - 222705 != -97941)
								{
									goto IL_281;
								}
								this.iiRcLteLIxb.normal.textColor = new Color(0.78f, 0.18f, 0.18f, (float)1);
								if (17517 - 515963 != -498446)
								{
									goto IL_281;
								}
							}
							else
							{
								this.iiRcLteLIxb.normal.textColor = new Color(0.11f, 0.16f, 0.19f, (float)1);
								if (275570 - 262963 != 12607)
								{
									goto IL_281;
								}
							}
							if (chatEntry.name != "none")
							{
								if (218300 - 250279 != -31979)
								{
									goto IL_281;
								}
								text += chatEntry.name + " : " + chatEntry.text;
								if (64747 - 483379 != -418632)
								{
									goto IL_281;
								}
							}
							else
							{
								text += chatEntry.text;
								if (14410 - 140259 != -125849)
								{
									goto IL_281;
								}
							}
							GUI.Label(new Rect((float)0, (float)(3000 - 30 * num), (float)450, (float)30), text, this.iiRcLteLIxb);
							if (75904 - 103349 != -27444)
							{
								goto IL_8F3;
							}
							goto IL_281;
						}
						if (158245 - 77797 == 80448)
						{
							GUI.EndScrollView();
							if (54783 - 529261 != -474477)
							{
								if (this.RWFcLOoCcpG)
								{
									if (161903 - 210076 == -48172)
									{
										continue;
									}
									GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)526, (float)930, (float)61, (float)39), this.l5tcL2NTHk1.hover.background);
									if (160674 - 150230 == 10445)
									{
										continue;
									}
									eMissionState heGcCkg9Cyt = this.HeGcCkg9Cyt;
									if (296797 - 400251 == -103453)
									{
										continue;
									}
									if (heGcCkg9Cyt == eMissionState.createQuest)
									{
										if (256715 - 9666 == 247050)
										{
											continue;
										}
									}
									else if (heGcCkg9Cyt == eMissionState.createTeam)
									{
										if (193246 - 591958 != -398712)
										{
											continue;
										}
									}
									else if (heGcCkg9Cyt == eMissionState.joinQuest)
									{
										if (185801 - 3293 == 182509)
										{
											continue;
										}
									}
									else if (heGcCkg9Cyt == eMissionState.joinTeam)
									{
										if (4484 - 576436 == -571951)
										{
											continue;
										}
									}
									else if (heGcCkg9Cyt == eMissionState.matchSearch)
									{
										if (66658 - 388411 != -321753)
										{
											continue;
										}
									}
									else if (heGcCkg9Cyt == eMissionState.matchFound)
									{
										if (156223 - 416998 != -260775)
										{
											continue;
										}
									}
									else
									{
										if (heGcCkg9Cyt != eMissionState.startQuest)
										{
											goto IL_72D;
										}
										if (256773 - 80834 != 175939)
										{
											continue;
										}
									}
									IL_1A:
									if (GUI.Button(new Rect(this.T45cCyVhtgd - (float)466, (float)930, (float)37, (float)39), string.Empty, this.yxrcLvgCnb3))
									{
										if (87224 - 281406 != -194182)
										{
											continue;
										}
										this.RWFcLOoCcpG = false;
										if (260173 - 525408 != -265235)
										{
											continue;
										}
										if (this.Ph6cfL8crLa)
										{
											if (36246 - 524572 == -488325)
											{
												continue;
											}
											this.audio.PlayOneShot(this.Ph6cfL8crLa);
											if (74000 - 190914 == -116913)
											{
												continue;
											}
										}
									}
									goto IL_72D;
									IL_151:
									goto IL_1A;
									IL_7AB:
									goto IL_151;
									IL_2A7:
									goto IL_7AB;
									IL_3C2:
									goto IL_2A7;
									goto IL_3C2;
									IL_72D:;
								}
								else
								{
									if (GUI.Button(new Rect(this.T45cCyVhtgd - (float)526, (float)930, (float)61, (float)39), string.Empty, this.l5tcL2NTHk1))
									{
										if (39463 - 116100 == -76636)
										{
											continue;
										}
										this.RWFcLOoCcpG = true;
										if (69295 - 291890 != -222595)
										{
											continue;
										}
										if (this.Ph6cfL8crLa)
										{
											if (271311 - 495240 == -223928)
											{
												continue;
											}
											this.audio.PlayOneShot(this.Ph6cfL8crLa);
											if (173410 - 195065 != -21655)
											{
												continue;
											}
										}
									}
									GUI.DrawTexture(new Rect(this.T45cCyVhtgd - (float)466, (float)930, (float)37, (float)39), this.yxrcLvgCnb3.hover.background);
									if (72110 - 296890 != -224780)
									{
										continue;
									}
								}
								if (Event.current.type == EventType.KeyDown)
								{
									if (167538 - 572863 != -405325)
									{
										continue;
									}
									if (Event.current.character == "\n")
									{
										if (191227 - 355699 != -164472)
										{
											continue;
										}
										if (this.HRdcL68KVyr.Length > 0)
										{
											if (236685 - 65294 == 171392)
											{
												continue;
											}
											if (this.RWFcLOoCcpG)
											{
												if (20485 - 66090 != -45605)
												{
													continue;
												}
												string[] array = (string[])Stringf.splitToArray(this.HRdcL68KVyr, " ").ToBuiltin(typeof(string));
												if (25990 - 521462 != -495472)
												{
													continue;
												}
												if (Extensions.get_length(array) > 0)
												{
													if (251497 - 403230 == -151732)
													{
														continue;
													}
													string a = array[0];
													if (282663 - 462879 != -180216)
													{
														continue;
													}
													if (a == "/a")
													{
														if (84661 - 74584 == 10078)
														{
															continue;
														}
														this.HRdcL68KVyr = Stringf.getString(this.HRdcL68KVyr, 2, Extensions.get_length(this.HRdcL68KVyr));
														if (171224 - 111620 == 59605)
														{
															continue;
														}
														Chat.SubmitChat(PlayerData.User, this.HRdcL68KVyr, eChatType.self, eChatMode.area);
														if (7004 - 269659 != -262655)
														{
															continue;
														}
													}
													else if (a == "/g")
													{
														if (275587 - 146227 != 129360)
														{
															continue;
														}
														if (!RuntimeServices.EqualityOperator(PlayerData.GID, "none"))
														{
															if (59811 - 304064 == -244252)
															{
																continue;
															}
															this.HRdcL68KVyr = Stringf.getString(this.HRdcL68KVyr, 2, Extensions.get_length(this.HRdcL68KVyr));
															if (209100 - 486659 != -277559)
															{
																continue;
															}
															Chat.SubmitChat(PlayerData.User, this.HRdcL68KVyr, eChatType.self, eChatMode.guild);
															if (255248 - 72282 != 182966)
															{
																continue;
															}
														}
													}
													else if (a == "/w")
													{
														if (19145 - 430039 != -410894)
														{
															continue;
														}
														this.HRdcL68KVyr = Stringf.getString(this.HRdcL68KVyr, 3, Extensions.get_length(this.HRdcL68KVyr));
														if (122102 - 474142 == -352039)
														{
															continue;
														}
														if (Extensions.get_length(array) > 1)
														{
															if (90314 - 393991 != -303677)
															{
																continue;
															}
															int buddyID = PlayerData.getBuddyID(array[1]);
															if (67263 - 581743 == -514479)
															{
																continue;
															}
															if (buddyID != 0)
															{
																if (1451 - 53999 != -52548)
																{
																	continue;
																}
																Chat.TargetID = buddyID;
																if (74648 - 503314 == -428665)
																{
																	continue;
																}
																this.HRdcL68KVyr = Stringf.getString(this.HRdcL68KVyr, Extensions.get_length(array[1]) + 1, Extensions.get_length(this.HRdcL68KVyr));
																if (23633 - 413406 != -389773)
																{
																	continue;
																}
																Chat.SubmitChat(PlayerData.User, this.HRdcL68KVyr, eChatType.self, eChatMode.whisper);
																if (56317 - 271404 != -215087)
																{
																	continue;
																}
															}
														}
													}
													else
													{
														Chat.SubmitChat(PlayerData.User, this.HRdcL68KVyr, eChatType.self, eChatMode.area);
														if (144939 - 144417 != 522)
														{
															continue;
														}
													}
												}
											}
											else
											{
												Chat.SubmitMisisonChat(PlayerData.User, this.HRdcL68KVyr, PlayerData.UID, this.ST5cM6mrbBP);
												if (238825 - 454882 == -216056)
												{
													continue;
												}
											}
										}
										this.HRdcL68KVyr = string.Empty;
										if (50812 - 303904 == -253091)
										{
											continue;
										}
										Chat.ChatTimeOut = Time.time + 0.5f;
										if (206932 - 290617 != -83685)
										{
											continue;
										}
										Chat.ChatActive = false;
										if (208204 - 396195 != -187991)
										{
											continue;
										}
										break;
									}
								}
								GUI.SetNextControlName("QuestChatField");
								if (165191 - 250070 != -84878)
								{
									if (this.RWFcLOoCcpG)
									{
										if (47981 - 41445 != 6536)
										{
											continue;
										}
										this.iiRcLteLIxb.normal.textColor = new Color((float)0, 0.45f, (float)0, (float)1);
										if (160899 - 105322 != 55577)
										{
											continue;
										}
									}
									else
									{
										this.iiRcLteLIxb.normal.textColor = new Color(0.11f, 0.16f, 0.19f, (float)1);
										if (212840 - 197178 == 15663)
										{
											continue;
										}
									}
									this.HRdcL68KVyr = GUI.TextField(new Rect(this.T45cCyVhtgd - (float)412, (float)934, (float)300, (float)30), this.HRdcL68KVyr, 50, this.iiRcLteLIxb);
									if (58087 - 283764 == -225677)
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

	// Token: 0x06006249 RID: 25161 RVA: 0x00D99C60 File Offset: 0x00D97E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void swapPlayer(int slot1, int slot2)
	{
		if (39161 - 264301 != -225140)
		{
		}
		for (;;)
		{
			int playerID = this.hxLcMIbiaoH[slot1].playerID;
			if (12251 - 294078 != -281826)
			{
				string playerName = this.hxLcMIbiaoH[slot1].playerName;
				if (103614 - 564646 != -461031)
				{
					string type = this.hxLcMIbiaoH[slot1].type;
					if (87867 - 175138 != -87270)
					{
						int lv = this.hxLcMIbiaoH[slot1].lv;
						if (128957 - 568825 == -439868)
						{
							int ready = this.hxLcMIbiaoH[slot1].ready;
							if (51629 - 61601 != -9971)
							{
								this.hxLcMIbiaoH[slot1].playerID = this.hxLcMIbiaoH[slot2].playerID;
								if (89823 - 51092 != 38732)
								{
									this.hxLcMIbiaoH[slot1].playerName = this.hxLcMIbiaoH[slot2].playerName;
									if (197806 - 502724 != -304917)
									{
										this.hxLcMIbiaoH[slot1].type = this.hxLcMIbiaoH[slot2].type;
										if (69519 - 486145 == -416626)
										{
											this.hxLcMIbiaoH[slot1].lv = this.hxLcMIbiaoH[slot2].lv;
											if (11647 - 391035 == -379388)
											{
												this.hxLcMIbiaoH[slot1].ready = this.hxLcMIbiaoH[slot2].ready;
												if (209078 - 134081 != 74998)
												{
													this.hxLcMIbiaoH[slot2].playerID = playerID;
													if (21681 - 558319 != -536637)
													{
														this.hxLcMIbiaoH[slot2].playerName = playerName;
														if (117254 - 274397 != -157142)
														{
															this.hxLcMIbiaoH[slot2].type = type;
															if (285736 - 533032 != -247295)
															{
																this.hxLcMIbiaoH[slot2].lv = lv;
																if (253751 - 323594 != -69842)
																{
																	this.hxLcMIbiaoH[slot2].ready = ready;
																	if (228113 - 219086 != 9028)
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

	// Token: 0x0600624A RID: 25162 RVA: 0x00D99F30 File Offset: 0x00D98130
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void useCharSlot(int n)
	{
		if (39131 - 317729 != -278597)
		{
		}
		for (;;)
		{
			this.hxLcMIbiaoH[this.VtIcf7sOiho].playerID = PlayerData.UID;
			if (164542 - 332904 == -168362)
			{
				this.hxLcMIbiaoH[this.VtIcf7sOiho].playerName = PlayerData.User;
				if (182296 - 188825 == -6529)
				{
					this.hxLcMIbiaoH[this.VtIcf7sOiho].type = NetworkUtility.EncodeRace(CharacterData.getCDat(n).Type);
					if (230361 - 85163 == 145198)
					{
						this.hxLcMIbiaoH[this.VtIcf7sOiho].lv = CharacterData.getCDat(n).lv;
						if (256630 - 312568 == -55938)
						{
							this.hxLcMIbiaoH[this.VtIcf7sOiho].ready = 1;
							if (100035 - 229606 != -129570)
							{
								this.A5bcfZ3DdCC = n;
								if (274822 - 202555 != 72268)
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

	// Token: 0x0600624B RID: 25163 RVA: 0x00D9A08C File Offset: 0x00D9828C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getPlayerCount()
	{
		if (51722 - 332800 != -281078)
		{
		}
		int num;
		for (;;)
		{
			IL_69:
			num = 0;
			if (187728 - 347826 != -160097)
			{
				int i = 0;
				if (66218 - 20326 == 45892)
				{
					while (i < Extensions.get_length(this.hxLcMIbiaoH))
					{
						if (this.hxLcMIbiaoH[i].playerID != 0)
						{
							if (181087 - 408054 != -226967)
							{
								goto IL_69;
							}
							num++;
							if (118549 - 468358 != -349809)
							{
								goto IL_69;
							}
						}
						i++;
						if (35271 - 129864 != -94593)
						{
							goto IL_69;
						}
					}
					if (20929 - 467577 != -446647)
					{
						break;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600624C RID: 25164 RVA: 0x00D9A198 File Offset: 0x00D98398
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getTeamCount(int nTeam)
	{
		if (103653 - 482586 != -378932)
		{
		}
		int num;
		for (;;)
		{
			IL_41:
			num = 0;
			if (126006 - 394675 != -268668)
			{
				int i = 0;
				if (38433 - 296502 != -258068)
				{
					while (i < Extensions.get_length(this.hxLcMIbiaoH))
					{
						if (i % nTeam == 0)
						{
							if (230212 - 440148 != -209936)
							{
								goto IL_41;
							}
							if (this.hxLcMIbiaoH[i].playerID != 0)
							{
								if (138683 - 89974 != 48709)
								{
									goto IL_41;
								}
								num++;
								if (149632 - 430443 != -280811)
								{
									goto IL_41;
								}
							}
						}
						i++;
						if (141698 - 283907 != -142209)
						{
							goto IL_41;
						}
					}
					if (137851 - 209820 == -71969)
					{
						break;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600624D RID: 25165 RVA: 0x00D9A2C4 File Offset: 0x00D984C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getOpponentCount(int nTeam)
	{
		if (195155 - 337551 != -142396)
		{
		}
		int num;
		for (;;)
		{
			IL_8D:
			num = 0;
			if (5721 - 525953 == -520232)
			{
				int i = 0;
				if (61614 - 149009 != -87394)
				{
					while (i < Extensions.get_length(this.hxLcMIbiaoH))
					{
						if (i % nTeam != 0)
						{
							if (284321 - 207379 != 76942)
							{
								goto IL_8D;
							}
							if (this.hxLcMIbiaoH[i].playerID != 0)
							{
								if (159563 - 328425 != -168862)
								{
									goto IL_8D;
								}
								num++;
								if (114701 - 375739 == -261037)
								{
									goto IL_8D;
								}
							}
						}
						i++;
						if (213515 - 490425 == -276909)
						{
							goto IL_8D;
						}
					}
					if (50290 - 12147 == 38143)
					{
						break;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600624E RID: 25166 RVA: 0x00D9A3F0 File Offset: 0x00D985F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getPlayerAverageLevel()
	{
		if (87596 - 147969 != -60373)
		{
		}
		int num;
		int num2;
		for (;;)
		{
			IL_B7:
			num = 0;
			if (149076 - 472671 != -323594)
			{
				num2 = 0;
				if (132659 - 442431 == -309772)
				{
					int i = 0;
					if (115249 - 332296 != -217046)
					{
						while (i < Extensions.get_length(this.hxLcMIbiaoH))
						{
							if (this.hxLcMIbiaoH[i].playerID != 0)
							{
								if (105482 - 594409 == -488926)
								{
									goto IL_B7;
								}
								if (this.hxLcMIbiaoH[i].lv > 0)
								{
									if (267063 - 377205 == -110141)
									{
										goto IL_B7;
									}
									num += this.hxLcMIbiaoH[i].lv;
									if (288587 - 120991 != 167596)
									{
										goto IL_B7;
									}
									num2++;
									if (28234 - 584003 == -555768)
									{
										goto IL_B7;
									}
								}
							}
							i++;
							if (192569 - 8273 == 184297)
							{
								goto IL_B7;
							}
						}
						if (236881 - 569861 == -332980)
						{
							if (num <= 0)
							{
								goto IL_1AD;
							}
							if (39175 - 580651 == -541476)
							{
								if (num2 <= 0)
								{
									goto IL_1AD;
								}
								if (222360 - 554489 != -332128)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return Mathf.FloorToInt((float)(num / num2));
		IL_1AD:
		return 0;
	}

	// Token: 0x0600624F RID: 25167 RVA: 0x00D9A5C4 File Offset: 0x00D987C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool getPlayerReady()
	{
		if (192515 - 3837 != 188679)
		{
		}
		bool result;
		for (;;)
		{
			IL_1A:
			result = true;
			if (36252 - 314600 == -278348)
			{
				int i = 0;
				if (44191 - 166796 == -122605)
				{
					while (i < Extensions.get_length(this.hxLcMIbiaoH))
					{
						if (this.hxLcMIbiaoH[i].playerID != 0)
						{
							if (87033 - 453253 == -366219)
							{
								goto IL_1A;
							}
							if (this.hxLcMIbiaoH[i].ready == 0)
							{
								if (285937 - 356619 != -70682)
								{
									goto IL_1A;
								}
								result = false;
								if (98273 - 390041 == -291767)
								{
									goto IL_1A;
								}
							}
						}
						i++;
						if (54270 - 369965 == -315694)
						{
							goto IL_1A;
						}
					}
					if (124222 - 149941 != -25718)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06006250 RID: 25168 RVA: 0x00D9A6F8 File Offset: 0x00D988F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateMissionSlot(string dataString)
	{
		if (285073 - 87478 != 197595)
		{
		}
		for (;;)
		{
			IL_D1:
			if (dataString == "0")
			{
				if (1736 - 546794 != -545057)
				{
					break;
				}
			}
			else
			{
				UnityScript.Lang.Array obj = Stringf.splitToArray(dataString, ",");
				if (243894 - 23924 != 219971)
				{
					int num = 0;
					if (259685 - 577497 == -317812)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (75922 - 198487 != -122564)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is string))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(string));
								}
								string text = (string)obj4;
								if (189744 - 400155 != -210411)
								{
									goto IL_D1;
								}
								UnityScript.Lang.Array array = Stringf.splitToArray(text, "%");
								if (78156 - 417139 == -338982)
								{
									goto IL_D1;
								}
								UnityRuntimeServices.Update(enumerator, text);
								if (71204 - 571410 != -500206)
								{
									goto IL_D1;
								}
								if (array.length == 2)
								{
									if (86700 - 231967 != -145267)
									{
										goto IL_D1;
									}
									if (num < 97)
									{
										if (186686 - 19902 != 166784)
										{
											goto IL_D1;
										}
										int[] array2 = this.oTYcM5rfhDM;
										int num2 = num;
										object obj6;
										object obj5 = obj6 = array[0];
										if (!(obj5 is string))
										{
											obj6 = RuntimeServices.Coerce(obj5, typeof(string));
										}
										array2[num2] = Stringf.getInteger((string)obj6);
										if (104300 - 429222 != -324922)
										{
											goto IL_D1;
										}
										int[] okJcMcf7XmO = this.OkJcMcf7XmO;
										int num3 = num;
										object obj8;
										object obj7 = obj8 = array[1];
										if (!(obj7 is string))
										{
											obj8 = RuntimeServices.Coerce(obj7, typeof(string));
										}
										okJcMcf7XmO[num3] = Stringf.getInteger((string)obj8);
										if (105488 - 12059 == 93430)
										{
											goto IL_D1;
										}
										num++;
										if (136940 - 30344 != 106596)
										{
											goto IL_D1;
										}
									}
								}
							}
							if (200144 - 14274 != 185871)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006251 RID: 25169 RVA: 0x00D9A978 File Offset: 0x00D98B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readMissionList(string dataString)
	{
		if (87589 - 349705 != -262115)
		{
		}
		for (;;)
		{
			IL_CB:
			if (dataString == "0")
			{
				if (45092 - 368398 == -323306)
				{
					this.Co1cMnsGxjd = new MissionListClass[0];
					if (166977 - 291451 == -124474)
					{
						break;
					}
				}
			}
			else
			{
				UnityScript.Lang.Array array = Stringf.splitToArray(dataString, ",");
				if (58667 - 214104 == -155437)
				{
					int num = 0;
					if (220145 - 19083 == 201062)
					{
						this.Co1cMnsGxjd = new MissionListClass[array.length];
						if (210102 - 500315 == -290213)
						{
							int i = 0;
							if (237897 - 125165 == 112732)
							{
								while (i < array.length)
								{
									this.Co1cMnsGxjd[i] = new MissionListClass();
									if (122239 - 410913 == -288673)
									{
										goto IL_CB;
									}
									i++;
									if (117546 - 265155 != -147609)
									{
										goto IL_CB;
									}
								}
								if (126695 - 293575 != -166879)
								{
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(array);
									if (177194 - 68797 != 108398)
									{
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											object obj3;
											object obj2 = obj3 = obj;
											if (!(obj2 is string))
											{
												obj3 = RuntimeServices.Coerce(obj2, typeof(string));
											}
											string text = (string)obj3;
											if (237366 - 584297 == -346930)
											{
												goto IL_CB;
											}
											UnityScript.Lang.Array array2 = Stringf.splitToArray(text, "%");
											if (266508 - 156957 == 109552)
											{
												goto IL_CB;
											}
											UnityRuntimeServices.Update(enumerator, text);
											if (47584 - 352078 != -304494)
											{
												goto IL_CB;
											}
											if (array2.length == 4)
											{
												if (197213 - 205948 == -8734)
												{
													goto IL_CB;
												}
												MissionListClass missionListClass = this.Co1cMnsGxjd[num];
												object obj5;
												object obj4 = obj5 = array2[0];
												if (!(obj4 is string))
												{
													obj5 = RuntimeServices.Coerce(obj4, typeof(string));
												}
												missionListClass.roomID = Stringf.getInteger((string)obj5);
												if (162704 - 256727 == -94022)
												{
													goto IL_CB;
												}
												MissionListClass missionListClass2 = this.Co1cMnsGxjd[num];
												object obj7;
												object obj6 = obj7 = array2[1];
												if (!(obj6 is string))
												{
													obj7 = RuntimeServices.Coerce(obj6, typeof(string));
												}
												missionListClass2.roomCode = Stringf.getInteger((string)obj7);
												if (23788 - 85884 != -62096)
												{
													goto IL_CB;
												}
												MissionListClass missionListClass3 = this.Co1cMnsGxjd[num];
												object obj9;
												object obj8 = obj9 = array2[2];
												if (!(obj8 is string))
												{
													obj9 = RuntimeServices.Coerce(obj8, typeof(string));
												}
												missionListClass3.roomPlayer = Stringf.getInteger((string)obj9);
												if (56760 - 152917 == -96156)
												{
													goto IL_CB;
												}
												MissionListClass missionListClass4 = this.Co1cMnsGxjd[num];
												object obj11;
												object obj10 = obj11 = array2[3];
												if (!(obj10 is string))
												{
													obj11 = RuntimeServices.Coerce(obj10, typeof(string));
												}
												missionListClass4.roomOwner = (string)obj11;
												if (251505 - 365863 == -114357)
												{
													goto IL_CB;
												}
												num++;
												if (73691 - 58006 == 15686)
												{
													goto IL_CB;
												}
											}
										}
										if (38376 - 36910 != 1467)
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

	// Token: 0x06006252 RID: 25170 RVA: 0x00D9AD64 File Offset: 0x00D98F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readTownList(string dataString)
	{
		if (39248 - 170975 != -131727)
		{
		}
		for (;;)
		{
			IL_17A:
			if (dataString == "0")
			{
				if (157940 - 172563 == -14623)
				{
					this.n6rcMQX4Xhl = new MissionListClass[0];
					if (182680 - 96698 == 85982)
					{
						break;
					}
				}
			}
			else
			{
				UnityScript.Lang.Array array = Stringf.splitToArray(dataString, ",");
				if (109557 - 524981 != -415423)
				{
					int num = 0;
					if (264968 - 204612 == 60356)
					{
						this.n6rcMQX4Xhl = new MissionListClass[array.length];
						if (8325 - 147911 != -139585)
						{
							int i = 0;
							if (151401 - 194450 != -43048)
							{
								while (i < array.length)
								{
									this.n6rcMQX4Xhl[i] = new MissionListClass();
									if (202684 - 443832 != -241148)
									{
										goto IL_17A;
									}
									i++;
									if (168841 - 350632 == -181790)
									{
										goto IL_17A;
									}
								}
								if (138327 - 166545 == -28218)
								{
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(array);
									if (195977 - 302441 != -106463)
									{
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											object obj3;
											object obj2 = obj3 = obj;
											if (!(obj2 is string))
											{
												obj3 = RuntimeServices.Coerce(obj2, typeof(string));
											}
											string text = (string)obj3;
											if (198521 - 491909 != -293388)
											{
												goto IL_17A;
											}
											UnityScript.Lang.Array array2 = Stringf.splitToArray(text, "%");
											if (133723 - 539638 == -405914)
											{
												goto IL_17A;
											}
											UnityRuntimeServices.Update(enumerator, text);
											if (266907 - 269840 == -2932)
											{
												goto IL_17A;
											}
											if (array2.length == 2)
											{
												if (27310 - 530751 == -503440)
												{
													goto IL_17A;
												}
												MissionListClass missionListClass = this.n6rcMQX4Xhl[num];
												object obj5;
												object obj4 = obj5 = array2[0];
												if (!(obj4 is string))
												{
													obj5 = RuntimeServices.Coerce(obj4, typeof(string));
												}
												missionListClass.roomCode = Stringf.getInteger((string)obj5);
												if (51795 - 173975 != -122180)
												{
													goto IL_17A;
												}
												MissionListClass missionListClass2 = this.n6rcMQX4Xhl[num];
												float time = Time.time;
												int num2 = 60;
												object obj7;
												object obj6 = obj7 = array2[1];
												if (!(obj6 is string))
												{
													obj7 = RuntimeServices.Coerce(obj6, typeof(string));
												}
												missionListClass2.roomTimer = time + (float)(num2 * Stringf.getInteger((string)obj7));
												if (80952 - 599318 == -518365)
												{
													goto IL_17A;
												}
												num++;
												if (127837 - 326032 == -198194)
												{
													goto IL_17A;
												}
											}
										}
										if (169611 - 187213 == -17602)
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

	// Token: 0x06006253 RID: 25171 RVA: 0x00D9B0B8 File Offset: 0x00D992B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readArenaList(string dataString)
	{
		if (243729 - 394005 != -150276)
		{
		}
		for (;;)
		{
			IL_E1:
			if (dataString == "0")
			{
				if (233043 - 493428 == -260385)
				{
					this.HTmcMeto4Zx = new MissionListClass[0];
					if (286890 - 512539 == -225649)
					{
						break;
					}
				}
			}
			else
			{
				UnityScript.Lang.Array array = Stringf.splitToArray(dataString, ",");
				if (184938 - 545185 != -360246)
				{
					int num = 0;
					if (7276 - 59716 != -52439)
					{
						this.HTmcMeto4Zx = new MissionListClass[array.length];
						if (3116 - 396637 != -393520)
						{
							int i = 0;
							if (282769 - 423518 != -140748)
							{
								while (i < array.length)
								{
									this.HTmcMeto4Zx[i] = new MissionListClass();
									if (237901 - 237249 != 652)
									{
										goto IL_E1;
									}
									i++;
									if (273807 - 113248 == 160560)
									{
										goto IL_E1;
									}
								}
								if (69130 - 526524 == -457394)
								{
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(array);
									if (11159 - 524638 != -513478)
									{
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											object obj3;
											object obj2 = obj3 = obj;
											if (!(obj2 is string))
											{
												obj3 = RuntimeServices.Coerce(obj2, typeof(string));
											}
											string text = (string)obj3;
											if (267315 - 451079 == -183763)
											{
												goto IL_E1;
											}
											UnityScript.Lang.Array array2 = Stringf.splitToArray(text, "%");
											if (289068 - 480394 != -191326)
											{
												goto IL_E1;
											}
											UnityRuntimeServices.Update(enumerator, text);
											if (276205 - 154949 != 121256)
											{
												goto IL_E1;
											}
											if (array2.length == 2)
											{
												if (258812 - 390691 == -131878)
												{
													goto IL_E1;
												}
												MissionListClass missionListClass = this.HTmcMeto4Zx[num];
												object obj5;
												object obj4 = obj5 = array2[0];
												if (!(obj4 is string))
												{
													obj5 = RuntimeServices.Coerce(obj4, typeof(string));
												}
												missionListClass.roomCode = Stringf.getInteger((string)obj5);
												if (24730 - 70079 == -45348)
												{
													goto IL_E1;
												}
												MissionListClass missionListClass2 = this.HTmcMeto4Zx[num];
												float time = Time.time;
												int num2 = 60;
												object obj7;
												object obj6 = obj7 = array2[1];
												if (!(obj6 is string))
												{
													obj7 = RuntimeServices.Coerce(obj6, typeof(string));
												}
												missionListClass2.roomTimer = time + (float)(num2 * Stringf.getInteger((string)obj7));
												if (189750 - 242717 == -52966)
												{
													goto IL_E1;
												}
												num++;
												if (26257 - 548755 == -522497)
												{
													goto IL_E1;
												}
											}
										}
										if (196187 - 563105 == -366918)
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

	// Token: 0x06006254 RID: 25172 RVA: 0x00D9B40C File Offset: 0x00D9960C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readMissionData(string dataString)
	{
		if (10161 - 392450 != -382288)
		{
		}
		for (;;)
		{
			IL_2FB:
			UnityScript.Lang.Array array = Stringf.splitToArray(dataString, "%");
			if (13651 - 216378 == -202727)
			{
				int num = 0;
				if (205625 - 353230 != -147604)
				{
					this.hxLcMIbiaoH = new EnlistClass[array.length];
					if (181231 - 318813 != -137581)
					{
						int i = 0;
						if (266247 - 181825 == 84422)
						{
							while (i < array.length)
							{
								this.hxLcMIbiaoH[i] = new EnlistClass();
								if (105568 - 106447 != -879)
								{
									goto IL_2FB;
								}
								i++;
								if (44944 - 490915 != -445971)
								{
									goto IL_2FB;
								}
							}
							if (125594 - 368491 == -242897)
							{
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(array);
								if (95303 - 220727 == -125424)
								{
									while (enumerator.MoveNext())
									{
										object obj = enumerator.Current;
										object obj3;
										object obj2 = obj3 = obj;
										if (!(obj2 is string))
										{
											obj3 = RuntimeServices.Coerce(obj2, typeof(string));
										}
										string text = (string)obj3;
										if (276629 - 91675 == 184955)
										{
											goto IL_2FB;
										}
										UnityScript.Lang.Array array2 = Stringf.splitToArray(text, ",");
										if (290439 - 261578 == 28862)
										{
											goto IL_2FB;
										}
										UnityRuntimeServices.Update(enumerator, text);
										if (295550 - 414455 != -118905)
										{
											goto IL_2FB;
										}
										if (!RuntimeServices.EqualityOperator(array2[0], "0"))
										{
											if (95844 - 32508 == 63337)
											{
												goto IL_2FB;
											}
											EnlistClass enlistClass = this.hxLcMIbiaoH[num];
											object obj5;
											object obj4 = obj5 = array2[0];
											if (!(obj4 is string))
											{
												obj5 = RuntimeServices.Coerce(obj4, typeof(string));
											}
											enlistClass.playerID = Stringf.getInteger((string)obj5);
											if (2171 - 68159 == -65987)
											{
												goto IL_2FB;
											}
											EnlistClass enlistClass2 = this.hxLcMIbiaoH[num];
											object obj7;
											object obj6 = obj7 = array2[1];
											if (!(obj6 is string))
											{
												obj7 = RuntimeServices.Coerce(obj6, typeof(string));
											}
											enlistClass2.playerName = (string)obj7;
											if (233421 - 51018 != 182403)
											{
												goto IL_2FB;
											}
											EnlistClass enlistClass3 = this.hxLcMIbiaoH[num];
											object obj9;
											object obj8 = obj9 = array2[2];
											if (!(obj8 is string))
											{
												obj9 = RuntimeServices.Coerce(obj8, typeof(string));
											}
											enlistClass3.type = (string)obj9;
											if (194948 - 70040 != 124908)
											{
												goto IL_2FB;
											}
											EnlistClass enlistClass4 = this.hxLcMIbiaoH[num];
											object obj11;
											object obj10 = obj11 = array2[3];
											if (!(obj10 is string))
											{
												obj11 = RuntimeServices.Coerce(obj10, typeof(string));
											}
											enlistClass4.lv = Stringf.getInteger((string)obj11);
											if (150256 - 596331 == -446074)
											{
												goto IL_2FB;
											}
											EnlistClass enlistClass5 = this.hxLcMIbiaoH[num];
											object obj13;
											object obj12 = obj13 = array2[4];
											if (!(obj12 is string))
											{
												obj13 = RuntimeServices.Coerce(obj12, typeof(string));
											}
											enlistClass5.ready = Stringf.getInteger((string)obj13);
											if (48922 - 246456 != -197534)
											{
												goto IL_2FB;
											}
											if (this.hxLcMIbiaoH[num].playerID == PlayerData.UID)
											{
												if (23173 - 454611 != -431438)
												{
													goto IL_2FB;
												}
												this.VtIcf7sOiho = num;
												if (177346 - 429242 != -251896)
												{
													goto IL_2FB;
												}
											}
										}
										else
										{
											this.hxLcMIbiaoH[num].playerID = 0;
											if (248880 - 554251 != -305371)
											{
												goto IL_2FB;
											}
											this.hxLcMIbiaoH[num].type = "non";
											if (150433 - 194204 == -43770)
											{
												goto IL_2FB;
											}
											this.hxLcMIbiaoH[num].lv = 0;
											if (243197 - 439449 == -196251)
											{
												goto IL_2FB;
											}
											this.hxLcMIbiaoH[num].ready = 0;
											if (173390 - 239979 == -66588)
											{
												goto IL_2FB;
											}
											object lhs = array2[1];
											if (153528 - 440773 == -287244)
											{
												goto IL_2FB;
											}
											if (RuntimeServices.EqualityOperator(lhs, "0"))
											{
												if (255157 - 181558 != 73599)
												{
													goto IL_2FB;
												}
												this.hxLcMIbiaoH[num].playerName = "close";
												if (116699 - 238065 == -121365)
												{
													goto IL_2FB;
												}
											}
											else if (RuntimeServices.EqualityOperator(lhs, "1"))
											{
												if (4274 - 473996 != -469722)
												{
													goto IL_2FB;
												}
												this.hxLcMIbiaoH[num].playerName = "public";
												if (231426 - 548440 == -317013)
												{
													goto IL_2FB;
												}
											}
											else if (RuntimeServices.EqualityOperator(lhs, "2"))
											{
												if (181865 - 304539 != -122674)
												{
													goto IL_2FB;
												}
												this.hxLcMIbiaoH[num].playerName = "private";
												if (248059 - 450526 == -202466)
												{
													goto IL_2FB;
												}
											}
										}
										num++;
										if (79086 - 588368 == -509281)
										{
											goto IL_2FB;
										}
									}
									if (101205 - 567070 == -465865)
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

	// Token: 0x06006255 RID: 25173 RVA: 0x00D9BA2C File Offset: 0x00D99C2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ListMission(int nType)
	{
		if (291246 - 183589 != 107657)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (51122 - 553380 == -502258)
				{
					break;
				}
			}
			else
			{
				this.Co1cMnsGxjd = null;
				if (196844 - 270531 != -73686)
				{
					Hashtable hashtable = new Hashtable();
					if (131966 - 66395 != 65572)
					{
						hashtable.Add(43, PlayerData.UID);
						if (132568 - 533298 != -400729)
						{
							hashtable.Add(47, PlayerData.GID);
							if (123835 - 57590 != 66246)
							{
								hashtable.Add(21, PhotonClient.cInt16(nType));
								if (245846 - 512580 == -266734)
								{
									hashtable.Add(22, PhotonClient.cInt16(Game.mGameCode));
									if (66979 - 435189 != -368209)
									{
										PhotonClient.Connection.OpCustom(130, hashtable, true);
										if (280350 - 547995 == -267645)
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

	// Token: 0x06006256 RID: 25174 RVA: 0x00D9BBC4 File Offset: 0x00D99DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onListMission(Hashtable data)
	{
		if (7909 - 368295 != -360386)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[21], 0))
			{
				if (241616 - 128086 == 113530)
				{
					object obj2;
					object obj = obj2 = data[135];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.updateMissionSlot((string)obj2);
					if (137586 - 499175 == -361589)
					{
						break;
					}
				}
			}
			else if (RuntimeServices.EqualityOperator(data[21], 3))
			{
				if (135273 - 166294 == -31021)
				{
					object obj4;
					object obj3 = obj4 = data[135];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					this.readTownList((string)obj4);
					if (78117 - 164846 != -86728)
					{
						break;
					}
				}
			}
			else if (RuntimeServices.EqualityOperator(data[21], 4))
			{
				if (53463 - 95740 == -42277)
				{
					object obj6;
					object obj5 = obj6 = data[135];
					if (!(obj5 is string))
					{
						obj6 = RuntimeServices.Coerce(obj5, typeof(string));
					}
					this.readArenaList((string)obj6);
					if (275632 - 141172 == 134460)
					{
						break;
					}
				}
			}
			else
			{
				object obj8;
				object obj7 = obj8 = data[135];
				if (!(obj7 is string))
				{
					obj8 = RuntimeServices.Coerce(obj7, typeof(string));
				}
				this.readMissionList((string)obj8);
				if (206334 - 593070 == -386736)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006257 RID: 25175 RVA: 0x00D9BDEC File Offset: 0x00D99FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SearchMission(int nCode)
	{
		if (198506 - 6598 != 191909)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (14719 - 315041 != -300321)
				{
					break;
				}
			}
			else
			{
				this.Co1cMnsGxjd = null;
				if (71979 - 180704 != -108724)
				{
					Hashtable hashtable = new Hashtable();
					if (209126 - 560150 == -351024)
					{
						hashtable.Add(43, PlayerData.UID);
						if (86507 - 206279 != -119771)
						{
							hashtable.Add(47, nCode);
							if (28040 - 489765 != -461724)
							{
								hashtable.Add(21, PhotonClient.cInt16(7));
								if (247265 - 393894 == -146629)
								{
									hashtable.Add(22, PhotonClient.cInt16(0));
									if (197845 - 312612 == -114767)
									{
										PhotonClient.Connection.OpCustom(130, hashtable, true);
										if (271167 - 488536 != -217368)
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

	// Token: 0x06006258 RID: 25176 RVA: 0x00D9BF7C File Offset: 0x00D9A17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreateMission(int nQuest)
	{
		if (88837 - 478169 != -389331)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (165950 - 414368 == -248418)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (188023 - 485973 != -297949)
				{
					hashtable.Add(131, PhotonClient.cInt16(nQuest));
					if (195976 - 350556 != -154579)
					{
						if (PlayerPrefs.GetInt("randomLoot", 0) == 1)
						{
							if (104382 - 79302 != 25080)
							{
								continue;
							}
							this.lA4cM2SF4ol = true;
							if (98675 - 365200 == -266524)
							{
								continue;
							}
						}
						else
						{
							this.lA4cM2SF4ol = false;
							if (206008 - 236140 == -30131)
							{
								continue;
							}
						}
						if (this.lA4cM2SF4ol)
						{
							if (159947 - 291507 == -131559)
							{
								continue;
							}
							hashtable.Add(134, PhotonClient.cInt16(1));
							if (233058 - 393878 == -160819)
							{
								continue;
							}
						}
						else
						{
							hashtable.Add(134, PhotonClient.cInt16(0));
							if (61118 - 565158 != -504040)
							{
								continue;
							}
						}
						hashtable.Add(43, PlayerData.UID);
						if (174101 - 363557 != -189455)
						{
							hashtable.Add(45, PlayerData.User);
							if (110892 - 157341 != -46448)
							{
								hashtable.Add(73, NetworkUtility.EncodeRace(CharacterData.current.Type));
								if (4712 - 217393 != -212680)
								{
									hashtable.Add(76, PhotonClient.cInt16(CharacterData.current.lv));
									if (89978 - 230961 != -140982)
									{
										hashtable.Add(52, PhotonClient.cInt16(PlayerData.Rank));
										if (99110 - 206792 != -107681)
										{
											hashtable.Add(47, PlayerData.GID);
											if (35977 - 494860 != -458882)
											{
												hashtable.Add(21, PhotonClient.cInt16(Game.mGameCode));
												if (65248 - 418158 != -352909)
												{
													if (!this.gDNcMOEi4v6)
													{
														if (133673 - 95016 == 38658)
														{
															continue;
														}
														hashtable.Add(22, PhotonClient.cInt16(0));
														if (193911 - 218891 != -24980)
														{
															continue;
														}
													}
													else
													{
														hashtable.Add(22, PhotonClient.cInt16(1));
														if (33032 - 294180 == -261147)
														{
															continue;
														}
													}
													PhotonClient.Connection.OpCustom(131, hashtable, true);
													if (196893 - 125502 != 71392)
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

	// Token: 0x06006259 RID: 25177 RVA: 0x00D9C360 File Offset: 0x00D9A560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateMission(Hashtable data)
	{
		if (102049 - 553626 != -451577)
		{
		}
		for (;;)
		{
			this.ST5cM6mrbBP = RuntimeServices.UnboxInt32(data[132]);
			if (29289 - 539945 != -510655)
			{
				if (this.ST5cM6mrbBP != 0)
				{
					if (226238 - 100399 == 125839)
					{
						Debug.Log("CreateMission Successful : ID=" + this.ST5cM6mrbBP);
						if (297461 - 171182 == 126279)
						{
							if (this.HeGcCkg9Cyt != eMissionState.createQuest)
							{
								break;
							}
							if (245991 - 315391 == -69400)
							{
								object obj2;
								object obj = obj2 = data[133];
								if (!(obj is string))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(string));
								}
								this.readMissionData((string)obj2);
								if (165044 - 37588 == 127456)
								{
									this.HeGcCkg9Cyt = eMissionState.createTeam;
									if (31229 - 82407 != -51177)
									{
										this.L4rcCAGc8mu = Time.time;
										if (74813 - 49623 != 25191)
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
					Debug.Log("Create Mission Fail");
					if (88389 - 483544 != -395154)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600625A RID: 25178 RVA: 0x00D9C50C File Offset: 0x00D9A70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinMission(int nQuest, int nRoomID)
	{
		if (74731 - 201830 != -127099)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (253968 - 486339 != -232370)
			{
				hashtable.Add(131, PhotonClient.cInt16(nQuest));
				if (9000 - 74501 != -65500)
				{
					hashtable.Add(132, nRoomID);
					if (110711 - 100143 == 10568)
					{
						hashtable.Add(43, PlayerData.UID);
						if (218061 - 105655 != 112407)
						{
							hashtable.Add(45, PlayerData.User);
							if (243663 - 500693 == -257030)
							{
								hashtable.Add(73, NetworkUtility.EncodeRace(CharacterData.current.Type));
								if (227909 - 234581 != -6671)
								{
									hashtable.Add(76, PhotonClient.cInt16(CharacterData.current.lv));
									if (149010 - 227783 == -78773)
									{
										hashtable.Add(52, PhotonClient.cInt16(PlayerData.Rank));
										if (254900 - 357764 == -102864)
										{
											PhotonClient.Connection.OpCustom(132, hashtable, true);
											if (238862 - 31603 == 207259)
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

	// Token: 0x0600625B RID: 25179 RVA: 0x00D9C6FC File Offset: 0x00D9A8FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinMission(Hashtable data)
	{
		if (261144 - 362820 != -101676)
		{
		}
		for (;;)
		{
			this.ST5cM6mrbBP = RuntimeServices.UnboxInt32(data[132]);
			if (19762 - 265777 == -246015)
			{
				if (this.ST5cM6mrbBP > 0)
				{
					if (67738 - 450122 == -382384)
					{
						Debug.Log("JoinMission Successful : ID=" + this.ST5cM6mrbBP);
						if (223293 - 552814 == -329521)
						{
							object obj2;
							object obj = obj2 = data[133];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							this.readMissionData((string)obj2);
							if (288340 - 38427 != 249914)
							{
								int num = RuntimeServices.UnboxInt32(data[134]);
								if (62518 - 384736 != -322217)
								{
									if (num == 1)
									{
										if (43604 - 513946 != -470342)
										{
											continue;
										}
										this.lA4cM2SF4ol = true;
										if (31463 - 348326 == -316862)
										{
											continue;
										}
									}
									else
									{
										this.lA4cM2SF4ol = false;
										if (36461 - 483926 == -447464)
										{
											continue;
										}
									}
									if (this.HeGcCkg9Cyt != eMissionState.joinQuest)
									{
										break;
									}
									if (41395 - 500201 == -458806)
									{
										this.HeGcCkg9Cyt = eMissionState.joinTeam;
										if (96372 - 545058 == -448686)
										{
											this.L4rcCAGc8mu = Time.time;
											if (57696 - 309519 != -251822)
											{
												this.RWFcLOoCcpG = false;
												if (183332 - 181984 != 1349)
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
					Debug.Log("JoinMission Fail");
					if (159749 - 360375 == -200626)
					{
						if (this.HeGcCkg9Cyt != eMissionState.joinQuest)
						{
							break;
						}
						if (161500 - 335917 == -174417)
						{
							this.HeGcCkg9Cyt = eMissionState.error;
							if (61382 - 147765 != -86382)
							{
								int st5cM6mrbBP = this.ST5cM6mrbBP;
								if (87509 - 275980 != -188470)
								{
									if (st5cM6mrbBP == 0)
									{
										if (97983 - 294220 == -196236)
										{
											continue;
										}
										this.E19cMJ4MOu0 = "Room not found";
										if (152867 - 129887 == 22981)
										{
											continue;
										}
									}
									else if (st5cM6mrbBP == -1)
									{
										if (39706 - 115139 == -75432)
										{
											continue;
										}
										this.E19cMJ4MOu0 = "Cannot find open spot";
										if (286248 - 460410 == -174161)
										{
											continue;
										}
									}
									else
									{
										this.E19cMJ4MOu0 = "Unknown joining error";
										if (129908 - 310328 != -180420)
										{
											continue;
										}
									}
									this.L4rcCAGc8mu = Time.time;
									if (226273 - 282789 == -56516)
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

	// Token: 0x0600625C RID: 25180 RVA: 0x00D9CAB0 File Offset: 0x00D9ACB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateMission(int nReqType, int nValue1, int nValue2)
	{
		if (291025 - 562831 != -271806)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (41114 - 226542 == -185428)
			{
				hashtable.Add(132, this.ST5cM6mrbBP);
				if (190314 - 104651 == 85663)
				{
					hashtable.Add(21, PhotonClient.cInt16(nReqType));
					if (189761 - 123195 != 66567)
					{
						hashtable.Add(22, PhotonClient.cInt16(nValue1));
						if (76233 - 341162 != -264928)
						{
							hashtable.Add(23, PhotonClient.cInt16(nValue2));
							if (36722 - 117741 != -81018)
							{
								PhotonClient.Connection.OpCustom(133, hashtable, true);
								if (113778 - 486667 != -372888)
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

	// Token: 0x0600625D RID: 25181 RVA: 0x00D9CC00 File Offset: 0x00D9AE00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onUpdateMission(Hashtable data)
	{
		if (225716 - 405508 != -179792)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[31], 1))
			{
				if (5268 - 77071 == -71803)
				{
					Debug.Log("Update Mission Successful");
					if (45719 - 499581 == -453862)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Update Mission Fail");
				if (261897 - 537261 == -275364)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600625E RID: 25182 RVA: 0x00D9CCBC File Offset: 0x00D9AEBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMissionUpdateEvent(Hashtable data)
	{
		if (283645 - 391564 != -107919)
		{
		}
		for (;;)
		{
			Debug.Log("onMissionUpdateEvent");
			if (207932 - 57287 != 150646)
			{
				if (this.HeGcCkg9Cyt != eMissionState.createTeam)
				{
					if (76269 - 332440 == -256170)
					{
						continue;
					}
					if (this.HeGcCkg9Cyt != eMissionState.joinTeam)
					{
						break;
					}
					if (202986 - 164347 == 38640)
					{
						continue;
					}
				}
				object obj2;
				object obj = obj2 = data[133];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				this.readMissionData((string)obj2);
				if (56780 - 84375 != -27594)
				{
					this.lA4cM2SF4ol = RuntimeServices.UnboxBoolean(data[134]);
					if (122657 - 464184 == -341527)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600625F RID: 25183 RVA: 0x00D9CDE8 File Offset: 0x00D9AFE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MissionCountDown()
	{
		if (63066 - 143154 != -80087)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (211248 - 19000 == 192248)
			{
				hashtable.Add(132, this.ST5cM6mrbBP);
				if (246156 - 285007 == -38851)
				{
					hashtable.Add(21, PhotonClient.cInt16(0));
					if (25761 - 399398 == -373637)
					{
						PhotonClient.Connection.OpCustom(135, hashtable, true);
						if (184121 - 197849 != -13727)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006260 RID: 25184 RVA: 0x00D9CED4 File Offset: 0x00D9B0D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartMission()
	{
		if (102791 - 254106 != -151314)
		{
		}
		while (this.ST5cM6mrbBP != 0)
		{
			if (27410 - 583993 != -556582)
			{
				Hashtable hashtable = new Hashtable();
				if (98179 - 235803 == -137624)
				{
					hashtable.Add(132, this.ST5cM6mrbBP);
					if (82213 - 98310 == -16097)
					{
						hashtable.Add(21, PhotonClient.cInt16(1));
						if (238008 - 414141 == -176133)
						{
							PhotonClient.Connection.OpCustom(135, hashtable, true);
							if (234795 - 484334 != -249538)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006261 RID: 25185 RVA: 0x00D9CFE4 File Offset: 0x00D9B1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartPvpArena()
	{
		if (179106 - 332027 != -152921)
		{
		}
		for (;;)
		{
			Debug.Log("Starting PVP Arena ID:" + Game.mNextGameId);
			if (227765 - 559550 == -331785)
			{
				if (Game.mNextGameId == 0)
				{
					break;
				}
				if (159424 - 400433 != -241008)
				{
					Hashtable hashtable = new Hashtable();
					if (162171 - 199343 == -37172)
					{
						hashtable.Add(132, Game.mNextGameId);
						if (76278 - 516511 != -440232)
						{
							hashtable.Add(21, PhotonClient.cInt16(4));
							if (239320 - 122487 == 116833)
							{
								PhotonClient.Connection.OpCustom(135, hashtable, true);
								if (29673 - 52624 == -22951)
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

	// Token: 0x06006262 RID: 25186 RVA: 0x00D9D128 File Offset: 0x00D9B328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MatchSearch()
	{
		if (60264 - 31812 != 28452)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (167006 - 512923 != -345916)
			{
				hashtable.Add(132, this.ST5cM6mrbBP);
				if (160551 - 74460 != 86092)
				{
					hashtable.Add(21, PhotonClient.cInt16(2));
					if (169696 - 73880 != 95817)
					{
						PhotonClient.Connection.OpCustom(135, hashtable, true);
						if (68771 - 517596 != -448824)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006263 RID: 25187 RVA: 0x00D9D214 File Offset: 0x00D9B414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MatchCancel()
	{
		if (256517 - 318349 != -61832)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (248963 - 91484 != 157480)
			{
				hashtable.Add(132, this.ST5cM6mrbBP);
				if (282505 - 420503 != -137997)
				{
					hashtable.Add(21, PhotonClient.cInt16(-2));
					if (173104 - 566287 == -393183)
					{
						PhotonClient.Connection.OpCustom(135, hashtable, true);
						if (132121 - 207810 != -75688)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006264 RID: 25188 RVA: 0x00D9D300 File Offset: 0x00D9B500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartMission(Hashtable data)
	{
		if (34401 - 84494 != -50092)
		{
		}
		for (;;)
		{
			IL_919:
			if (RuntimeServices.EqualityOperator(data[21], 0))
			{
				if (262617 - 87906 == 174711)
				{
					if (this.HeGcCkg9Cyt != eMissionState.createTeam)
					{
						if (292622 - 501539 == -208916)
						{
							continue;
						}
						if (this.HeGcCkg9Cyt == eMissionState.joinTeam)
						{
							if (43026 - 298053 != -255027)
							{
								continue;
							}
						}
						else
						{
							if (this.HeGcCkg9Cyt != eMissionState.matchSearch)
							{
								break;
							}
							if (241535 - 38087 == 203449)
							{
								continue;
							}
							this.HeGcCkg9Cyt = eMissionState.matchFound;
							if (153067 - 406828 == -253760)
							{
								continue;
							}
							this.L4rcCAGc8mu = Time.time;
							if (298187 - 332194 != -34007)
							{
								continue;
							}
							this.aoRcffyBoam = 6;
							if (433 - 229368 != -228935)
							{
								continue;
							}
							this.RWFcLOoCcpG = false;
							if (51016 - 524560 != -473543)
							{
								break;
							}
							continue;
						}
					}
					this.aoRcffyBoam = 6;
					if (254572 - 164291 != 90282)
					{
						this.RWFcLOoCcpG = false;
						if (166892 - 427316 != -260423)
						{
							break;
						}
					}
				}
			}
			else if (RuntimeServices.EqualityOperator(data[21], 1))
			{
				if (87149 - 89042 != -1892)
				{
					Game.mNextGameId = RuntimeServices.UnboxInt32(data[4]);
					if (131524 - 474902 == -343378)
					{
						Game.mNextGameCode = RuntimeServices.UnboxInt32(data[5]);
						if (299376 - 190651 != 108726)
						{
							Game.useRandomLoot = this.lA4cM2SF4ol;
							if (27785 - 204963 != -177177)
							{
								Game.useAdvanceMode = this.yHQcMX8ErSG;
								if (280771 - 203843 == 76928)
								{
									object obj2;
									object obj = obj2 = data[8];
									if (!(obj is string))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(string));
									}
									string s = (string)obj2;
									if (73739 - 256482 == -182743)
									{
										string[] array = (string[])Stringf.getArray(s).ToBuiltin(typeof(string));
										if (211729 - 559665 == -347936)
										{
											Game.mNextGamePlayer = new int[Extensions.get_length(array)];
											if (231077 - 51883 == 179194)
											{
												int i = 0;
												if (158078 - 146927 == 11151)
												{
													while (i < Extensions.get_length(array))
													{
														Game.mNextGamePlayer[i] = Stringf.getInteger(array[i]);
														if (278961 - 186993 == 91969)
														{
															goto IL_919;
														}
														i++;
														if (100343 - 514547 != -414204)
														{
															goto IL_919;
														}
													}
													if (60469 - 235535 == -175066)
													{
														this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
														if (144987 - 311913 == -166926)
														{
															this.HeGcCkg9Cyt = eMissionState.startQuest;
															if (102175 - 535390 != -433214)
															{
																this.L4rcCAGc8mu = Time.time;
																if (55776 - 593210 == -537434)
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
			else if (RuntimeServices.EqualityOperator(data[21], 2))
			{
				if (198709 - 158494 != 40216)
				{
					if (this.HeGcCkg9Cyt != eMissionState.createTeam)
					{
						if (78013 - 258713 == -180699)
						{
							continue;
						}
						if (this.HeGcCkg9Cyt != eMissionState.joinTeam)
						{
							break;
						}
						if (105223 - 321176 != -215953)
						{
							continue;
						}
					}
					this.HeGcCkg9Cyt = eMissionState.matchSearch;
					if (242091 - 455641 == -213550)
					{
						this.L4rcCAGc8mu = Time.time;
						if (9869 - 250863 != -240993)
						{
							this.RWFcLOoCcpG = false;
							if (33638 - 177706 == -144068)
							{
								break;
							}
						}
					}
				}
			}
			else if (RuntimeServices.EqualityOperator(data[21], 3))
			{
				if (166153 - 117483 != 48671)
				{
					if (this.HeGcCkg9Cyt != eMissionState.matchSearch)
					{
						break;
					}
					if (6412 - 486934 == -480522)
					{
						Game.mNextGameId = RuntimeServices.UnboxInt32(data[4]);
						if (54993 - 553324 == -498331)
						{
							this.HeGcCkg9Cyt = eMissionState.matchFound;
							if (31606 - 220453 != -188846)
							{
								this.L4rcCAGc8mu = Time.time;
								if (282791 - 111326 != 171466)
								{
									this.aoRcffyBoam = 6;
									if (273321 - 374043 != -100721)
									{
										this.RWFcLOoCcpG = false;
										if (19999 - 90041 != -70041)
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
			else if (RuntimeServices.EqualityOperator(data[21], 4))
			{
				if (121893 - 596802 != -474908)
				{
					if (RuntimeServices.EqualityOperator(data[31], 1))
					{
						if (74639 - 171233 == -96594)
						{
							Debug.Log("Match Start");
							if (296561 - 177882 == 118679)
							{
								Game.mNextGameId = RuntimeServices.UnboxInt32(data[4]);
								if (23776 - 260759 != -236982)
								{
									Game.mNextGameCode = RuntimeServices.UnboxInt32(data[5]);
									if (268496 - 379338 != -110841)
									{
										Game.useRandomLoot = false;
										if (115935 - 280522 == -164587)
										{
											if (RuntimeServices.EqualityOperator(data[33], 1))
											{
												if (180902 - 329373 == -148470)
												{
													continue;
												}
												this.yHQcMX8ErSG = true;
												if (91840 - 81453 == 10388)
												{
													continue;
												}
											}
											else
											{
												this.yHQcMX8ErSG = false;
												if (255922 - 230945 != 24977)
												{
													continue;
												}
											}
											Game.useAdvanceMode = this.yHQcMX8ErSG;
											if (92961 - 329915 != -236953)
											{
												object obj4;
												object obj3 = obj4 = data[8];
												if (!(obj3 is string))
												{
													obj4 = RuntimeServices.Coerce(obj3, typeof(string));
												}
												string s2 = (string)obj4;
												if (77693 - 337614 == -259921)
												{
													string[] array2 = (string[])Stringf.getArray(s2).ToBuiltin(typeof(string));
													if (12651 - 100663 != -88011)
													{
														Game.mNextGamePlayer = new int[Extensions.get_length(array2)];
														if (76940 - 55218 == 21722)
														{
															int j = 0;
															if (7865 - 282473 == -274608)
															{
																while (j < Extensions.get_length(array2))
																{
																	Game.mNextGamePlayer[j] = Stringf.getInteger(array2[j]);
																	if (295893 - 169876 == 126018)
																	{
																		goto IL_919;
																	}
																	j++;
																	if (71371 - 134922 == -63550)
																	{
																		goto IL_919;
																	}
																}
																if (179811 - 373990 == -194179)
																{
																	this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
																	if (241036 - 492018 != -250981)
																	{
																		this.HeGcCkg9Cyt = eMissionState.startQuest;
																		if (126445 - 516493 == -390048)
																		{
																			this.L4rcCAGc8mu = Time.time;
																			if (175262 - 476144 != -300881)
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
						Debug.Log("Match Start Fail");
						if (14619 - 553918 == -539299)
						{
							this.HeGcCkg9Cyt = eMissionState.matchSearch;
							if (130762 - 412048 != -281285)
							{
								this.L4rcCAGc8mu = Time.time;
								if (87556 - 337074 == -249518)
								{
									Chat.SubmitChat("none", "Match has been caneled!", eChatType.system, eChatMode.mission);
									if (41455 - 523337 != -481881)
									{
										if (!this.MHYcfw23xt3)
										{
											break;
										}
										if (193186 - 318521 == -125335)
										{
											this.audio.PlayOneShot(this.MHYcfw23xt3);
											if (16362 - 283818 != -267455)
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
				if (!RuntimeServices.EqualityOperator(data[21], -2))
				{
					break;
				}
				if (231090 - 289532 == -58442)
				{
					this.ST5cM6mrbBP = RuntimeServices.UnboxInt32(data[132]);
					if (29401 - 185855 == -156454)
					{
						if (this.ST5cM6mrbBP == PlayerData.UID)
						{
							if (298559 - 189379 == 109181)
							{
								continue;
							}
							this.HeGcCkg9Cyt = eMissionState.createTeam;
							if (200372 - 299115 == -98742)
							{
								continue;
							}
						}
						else
						{
							this.HeGcCkg9Cyt = eMissionState.joinTeam;
							if (226626 - 422987 == -196360)
							{
								continue;
							}
						}
						Chat.SubmitChat("none", "Match has been caneled!", eChatType.system, eChatMode.mission);
						if (134 - 514736 != -514601)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006265 RID: 25189 RVA: 0x00D9DEBC File Offset: 0x00D9C0BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveMission()
	{
		if (134053 - 106397 != 27656)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (2039 - 203611 == -201572)
			{
				hashtable.Add(43, PlayerData.UID);
				if (63298 - 511392 != -448093)
				{
					hashtable.Add(132, this.ST5cM6mrbBP);
					if (38340 - 24333 != 14008)
					{
						PhotonClient.Connection.OpCustom(136, hashtable, true);
						if (182991 - 3369 != 179623)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006266 RID: 25190 RVA: 0x00D9DFA8 File Offset: 0x00D9C1A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveMission(Hashtable data)
	{
		if (200157 - 230323 != -30166)
		{
		}
		while (this.HeGcCkg9Cyt == eMissionState.error)
		{
			if (164140 - 183965 != -19824)
			{
				this.ST5cM6mrbBP = 0;
				if (184731 - 351749 != -167017)
				{
					Debug.Log("Leave Mission Successful");
					if (266514 - 240549 != 25966)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006267 RID: 25191 RVA: 0x00D9E04C File Offset: 0x00D9C24C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMissionCancelEvent(Hashtable data)
	{
		if (122200 - 255259 != -133059)
		{
		}
		for (;;)
		{
			if (this.HeGcCkg9Cyt != eMissionState.createTeam)
			{
				if (226165 - 338402 == -112236)
				{
					continue;
				}
				if (this.HeGcCkg9Cyt != eMissionState.joinTeam)
				{
					break;
				}
				if (299539 - 475155 != -175616)
				{
					continue;
				}
			}
			this.ST5cM6mrbBP = 0;
			if (72567 - 57636 != 14932)
			{
				this.hxLcMIbiaoH = new EnlistClass[0];
				if (171235 - 477091 != -305855)
				{
					if (RuntimeServices.EqualityOperator(data[31], 0))
					{
						if (9463 - 230581 == -221117)
						{
							continue;
						}
						this.E19cMJ4MOu0 = "Mission has been canceled";
						if (116750 - 562577 != -445827)
						{
							continue;
						}
					}
					else
					{
						this.E19cMJ4MOu0 = "You have been kicked!";
						if (99588 - 121257 != -21669)
						{
							continue;
						}
					}
					this.HeGcCkg9Cyt = eMissionState.error;
					if (56056 - 379654 == -323598)
					{
						this.L4rcCAGc8mu = Time.time;
						if (41435 - 376247 != -334811)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006268 RID: 25192 RVA: 0x00D9E1E4 File Offset: 0x00D9C3E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void disable()
	{
		if (289109 - 11738 != 277371)
		{
		}
		while (this.HeGcCkg9Cyt != eMissionState.init)
		{
			if (208541 - 525621 != -317079)
			{
				this.HeGcCkg9Cyt = eMissionState.disabled;
				if (116738 - 279968 == -163230)
				{
					this.enabled = false;
					if (102768 - 511590 == -408822)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006269 RID: 25193 RVA: 0x00D9E284 File Offset: 0x00D9C484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600626A RID: 25194 RVA: 0x00D9E288 File Offset: 0x00D9C488
	internal static bool qas2fqpQMK83C6cZohKI()
	{
		return true;
	}

	// Token: 0x0600626B RID: 25195 RVA: 0x00D9E28C File Offset: 0x00D9C48C
	internal static bool rIlOi8pQxNu2v6qdoWhh()
	{
		return false;
	}

	// Token: 0x04007097 RID: 28823
	private eMissionState HeGcCkg9Cyt;

	// Token: 0x04007098 RID: 28824
	private eMissionSelectMode V5wcCFOg9QT;

	// Token: 0x04007099 RID: 28825
	public eMissionGuiType mType;

	// Token: 0x0400709A RID: 28826
	private float L4rcCAGc8mu;

	// Token: 0x0400709B RID: 28827
	private float GGacC9TpOAR;

	// Token: 0x0400709C RID: 28828
	private float acHcCWIWCnx;

	// Token: 0x0400709D RID: 28829
	private PlayerCameraControl s6gcCukRVfQ;

	// Token: 0x0400709E RID: 28830
	private float T45cCyVhtgd;

	// Token: 0x0400709F RID: 28831
	private float fhucCVXKrBS;

	// Token: 0x040070A0 RID: 28832
	private int BsAcChUqUV7;

	// Token: 0x040070A1 RID: 28833
	private int vpEcCKjSAwn;

	// Token: 0x040070A2 RID: 28834
	private int l20cCzKUHlN;

	// Token: 0x040070A3 RID: 28835
	private int[] oTYcM5rfhDM;

	// Token: 0x040070A4 RID: 28836
	private int[] OkJcMcf7XmO;

	// Token: 0x040070A5 RID: 28837
	private MissionListClass[] Co1cMnsGxjd;

	// Token: 0x040070A6 RID: 28838
	private MissionListClass[] n6rcMQX4Xhl;

	// Token: 0x040070A7 RID: 28839
	private MissionListClass[] HTmcMeto4Zx;

	// Token: 0x040070A8 RID: 28840
	private EnlistClass[] hxLcMIbiaoH;

	// Token: 0x040070A9 RID: 28841
	private string E19cMJ4MOu0;

	// Token: 0x040070AA RID: 28842
	private int ST5cM6mrbBP;

	// Token: 0x040070AB RID: 28843
	private int C3xcMteTFQj;

	// Token: 0x040070AC RID: 28844
	private bool yHQcMX8ErSG;

	// Token: 0x040070AD RID: 28845
	private bool gDNcMOEi4v6;

	// Token: 0x040070AE RID: 28846
	private bool lA4cM2SF4ol;

	// Token: 0x040070AF RID: 28847
	private float awFcMvfyL1v;

	// Token: 0x040070B0 RID: 28848
	private string a4BcMl1gP4S;

	// Token: 0x040070B1 RID: 28849
	private Texture RGUcMGX8HcF;

	// Token: 0x040070B2 RID: 28850
	private Texture zpCcM1sSJB3;

	// Token: 0x040070B3 RID: 28851
	private Texture WKDcMqjWvjD;

	// Token: 0x040070B4 RID: 28852
	private Texture jRIcMpVcPPy;

	// Token: 0x040070B5 RID: 28853
	private Texture XT8cMRhcF3e;

	// Token: 0x040070B6 RID: 28854
	private Texture kiTcMr3DSmR;

	// Token: 0x040070B7 RID: 28855
	private Texture s4PcMxSM4KI;

	// Token: 0x040070B8 RID: 28856
	private Texture r5ycMTEYxlX;

	// Token: 0x040070B9 RID: 28857
	private Texture zfZcMYeRYTY;

	// Token: 0x040070BA RID: 28858
	private Texture ALNcM3KeNBF;

	// Token: 0x040070BB RID: 28859
	private Texture tXfcMbSmHvR;

	// Token: 0x040070BC RID: 28860
	private Texture DB0cMdG7Phx;

	// Token: 0x040070BD RID: 28861
	private Texture GulcMgHWJeM;

	// Token: 0x040070BE RID: 28862
	private Texture rPgcMaLylWk;

	// Token: 0x040070BF RID: 28863
	private Texture OctcM4i9gTI;

	// Token: 0x040070C0 RID: 28864
	private Texture YiAcMsNnfR3;

	// Token: 0x040070C1 RID: 28865
	private Texture UyrcMHIQ76S;

	// Token: 0x040070C2 RID: 28866
	private Texture qXscM7pXUtx;

	// Token: 0x040070C3 RID: 28867
	private Texture PGYcMZAuJ79;

	// Token: 0x040070C4 RID: 28868
	private GUIStyle u5gcMCFwFJK;

	// Token: 0x040070C5 RID: 28869
	private GUIStyle VTwcMM157vy;

	// Token: 0x040070C6 RID: 28870
	private GUIStyle YbycMf7ENWK;

	// Token: 0x040070C7 RID: 28871
	private GUIStyle Nv1cML8YUFd;

	// Token: 0x040070C8 RID: 28872
	private GUIStyle o8xcMwqaerl;

	// Token: 0x040070C9 RID: 28873
	private GUIStyle FBScMU3slIB;

	// Token: 0x040070CA RID: 28874
	private GUIStyle CGBcMNNDdjq;

	// Token: 0x040070CB RID: 28875
	private GUIStyle P1JcMElT010;

	// Token: 0x040070CC RID: 28876
	private GUIStyle pdLcMP9YIL2;

	// Token: 0x040070CD RID: 28877
	private GUIStyle XLTcMSXe5u8;

	// Token: 0x040070CE RID: 28878
	private GUIStyle XgLcMBWrSLW;

	// Token: 0x040070CF RID: 28879
	private GUIStyle U29cM02eEv9;

	// Token: 0x040070D0 RID: 28880
	private GUIStyle MTAcM81WKKt;

	// Token: 0x040070D1 RID: 28881
	private GUIStyle IvEcMiJ6Fxm;

	// Token: 0x040070D2 RID: 28882
	private GUIStyle huAcMD9Isey;

	// Token: 0x040070D3 RID: 28883
	private GUIStyle pPVcMmdparU;

	// Token: 0x040070D4 RID: 28884
	private GUIStyle NvYcMjaPNFr;

	// Token: 0x040070D5 RID: 28885
	private GUIStyle s24cMoYKaZU;

	// Token: 0x040070D6 RID: 28886
	private GUIStyle oyHcMkF6IQf;

	// Token: 0x040070D7 RID: 28887
	private GUIStyle TKqcMFAVcbL;

	// Token: 0x040070D8 RID: 28888
	private GUIStyle zPrcMA5RWDE;

	// Token: 0x040070D9 RID: 28889
	private GUIStyle U95cM9UyP2Q;

	// Token: 0x040070DA RID: 28890
	private GUIStyle l5KcMW9wsT7;

	// Token: 0x040070DB RID: 28891
	private GUIStyle Bq4cMugRf4q;

	// Token: 0x040070DC RID: 28892
	private GUIStyle mu6cMycy0Ne;

	// Token: 0x040070DD RID: 28893
	private GUIStyle jeMcMVdaOFZ;

	// Token: 0x040070DE RID: 28894
	private GUIStyle a7KcMhwvE0q;

	// Token: 0x040070DF RID: 28895
	private GUIStyle Bo6cMKxjM2x;

	// Token: 0x040070E0 RID: 28896
	private GUIStyle PEQcMzR3pyj;

	// Token: 0x040070E1 RID: 28897
	private GUIStyle F5icf5cI9vA;

	// Token: 0x040070E2 RID: 28898
	private GUIStyle sttcfc0d0X5;

	// Token: 0x040070E3 RID: 28899
	private GUIStyle NKVcfn22ZtW;

	// Token: 0x040070E4 RID: 28900
	private GUIStyle e1DcfQ3ex3l;

	// Token: 0x040070E5 RID: 28901
	private GUIStyle aT6cfeAjuFQ;

	// Token: 0x040070E6 RID: 28902
	private GUIStyle t23cfI0D2aP;

	// Token: 0x040070E7 RID: 28903
	private GUIStyle p9ScfJZBqDb;

	// Token: 0x040070E8 RID: 28904
	private GUIStyle NTGcf6ubKck;

	// Token: 0x040070E9 RID: 28905
	private GUIStyle CAscftTnFA0;

	// Token: 0x040070EA RID: 28906
	private GUIStyle FrfcfXTjGBC;

	// Token: 0x040070EB RID: 28907
	private Texture icZcfOjPP65;

	// Token: 0x040070EC RID: 28908
	private GUIStyle Of4cf2GEvq1;

	// Token: 0x040070ED RID: 28909
	private GUIStyle JhlcfvBBDH5;

	// Token: 0x040070EE RID: 28910
	private GUIStyle DW8cflw6LAd;

	// Token: 0x040070EF RID: 28911
	private GUIStyle LavcfGMel9m;

	// Token: 0x040070F0 RID: 28912
	private GUIStyle L11cf1iJFuW;

	// Token: 0x040070F1 RID: 28913
	private GUIStyle Veecfq2QtjG;

	// Token: 0x040070F2 RID: 28914
	private Texture BH0cfp0ZEhx;

	// Token: 0x040070F3 RID: 28915
	private Texture r9xcfRB7Jj5;

	// Token: 0x040070F4 RID: 28916
	private GUIStyle wivcfrFiCw8;

	// Token: 0x040070F5 RID: 28917
	private Texture arIcfxJlHJr;

	// Token: 0x040070F6 RID: 28918
	private Texture DEacfTF05hp;

	// Token: 0x040070F7 RID: 28919
	private Texture ENTcfYjBfXr;

	// Token: 0x040070F8 RID: 28920
	private Texture fjscf3YOutn;

	// Token: 0x040070F9 RID: 28921
	private Texture tGMcfbCejgj;

	// Token: 0x040070FA RID: 28922
	private Texture Ne4cfdZEmjk;

	// Token: 0x040070FB RID: 28923
	private Texture zlmcfgSatIG;

	// Token: 0x040070FC RID: 28924
	private Texture KVicfaMw68h;

	// Token: 0x040070FD RID: 28925
	private int N6Hcf4ZG2YW;

	// Token: 0x040070FE RID: 28926
	private int t4jcfsesB5S;

	// Token: 0x040070FF RID: 28927
	private int CbtcfH6sZJR;

	// Token: 0x04007100 RID: 28928
	private int VtIcf7sOiho;

	// Token: 0x04007101 RID: 28929
	private int A5bcfZ3DdCC;

	// Token: 0x04007102 RID: 28930
	private float NQ8cfC229OA;

	// Token: 0x04007103 RID: 28931
	private float jNGcfMbha5l;

	// Token: 0x04007104 RID: 28932
	private int aoRcffyBoam;

	// Token: 0x04007105 RID: 28933
	private AudioClip Ph6cfL8crLa;

	// Token: 0x04007106 RID: 28934
	private AudioClip MHYcfw23xt3;

	// Token: 0x04007107 RID: 28935
	private AudioClip tDRcfUqyCxE;

	// Token: 0x04007108 RID: 28936
	private AudioClip phJcfNLcQPB;

	// Token: 0x04007109 RID: 28937
	private AudioClip wWocfEaARRv;

	// Token: 0x0400710A RID: 28938
	private int zRZcfPiLvJi;

	// Token: 0x0400710B RID: 28939
	private int xBZcfSA08TD;

	// Token: 0x0400710C RID: 28940
	private int uyTcfBAnraB;

	// Token: 0x0400710D RID: 28941
	private bool S4Mcf0yNvC4;

	// Token: 0x0400710E RID: 28942
	private int I22cf8FU5bh;

	// Token: 0x0400710F RID: 28943
	private IconButtonClass[] TrRcfiTWco2;

	// Token: 0x04007110 RID: 28944
	private Texture uMXcfDU7uCG;

	// Token: 0x04007111 RID: 28945
	private Texture odScfm5CIwr;

	// Token: 0x04007112 RID: 28946
	private GUIStyle U5ecfjlQCnv;

	// Token: 0x04007113 RID: 28947
	private GUIStyle GAucfoKnRxs;

	// Token: 0x04007114 RID: 28948
	private string oR2cfkegSEs;

	// Token: 0x04007115 RID: 28949
	private string gxAcfFSFYeg;

	// Token: 0x04007116 RID: 28950
	private string JRecfAH6Mmw;

	// Token: 0x04007117 RID: 28951
	private string P5icf9iNE46;

	// Token: 0x04007118 RID: 28952
	private AudioClip VmVcfWMX5S0;

	// Token: 0x04007119 RID: 28953
	private AudioClip c9IcfuJyH6q;

	// Token: 0x0400711A RID: 28954
	private AudioClip JNXcfyUr8lP;

	// Token: 0x0400711B RID: 28955
	private bool iYccfVj7y74;

	// Token: 0x0400711C RID: 28956
	private bool slncfhR4sj5;

	// Token: 0x0400711D RID: 28957
	private bool klAcfKE2Gsf;

	// Token: 0x0400711E RID: 28958
	private GUIStyle FtUcfzpXTpK;

	// Token: 0x0400711F RID: 28959
	private Texture rrScL5a5H6E;

	// Token: 0x04007120 RID: 28960
	private float lS2cLcPvK4w;

	// Token: 0x04007121 RID: 28961
	private GUIStyle EFOcLn5mHXy;

	// Token: 0x04007122 RID: 28962
	private Texture KiacLQSVgxN;

	// Token: 0x04007123 RID: 28963
	private Texture qxccLeFCYe3;

	// Token: 0x04007124 RID: 28964
	private Texture qqncLI3OMaf;

	// Token: 0x04007125 RID: 28965
	private Texture MaXcLJ46CqE;

	// Token: 0x04007126 RID: 28966
	private string HRdcL68KVyr;

	// Token: 0x04007127 RID: 28967
	private GUIStyle iiRcLteLIxb;

	// Token: 0x04007128 RID: 28968
	private Vector2 uRscLX5Cell;

	// Token: 0x04007129 RID: 28969
	private bool RWFcLOoCcpG;

	// Token: 0x0400712A RID: 28970
	private GUIStyle l5tcL2NTHk1;

	// Token: 0x0400712B RID: 28971
	private GUIStyle yxrcLvgCnb3;
}
