using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001FF9 RID: 8185
[Serializable]
public class M988_GuildWar : MonoBehaviour
{
	// Token: 0x0600BF62 RID: 48994 RVA: 0x01435774 File Offset: 0x01433974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M988_GuildWar()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BF63 RID: 48995 RVA: 0x01435784 File Offset: 0x01433984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (117330 - 192732 != -75401)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (79947 - 514891 != -434943)
			{
				Game.mGameType = 5;
				if (6850 - 310699 != -303848)
				{
					if (Chat.Initialized)
					{
						if (63289 - 576662 == -513372)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (89097 - 280129 != -191032)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (216715 - 471627 != -254912)
						{
							continue;
						}
					}
					this.SAHnrVB2TM3 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (133364 - 432256 == -298892)
					{
						this.nwFnrhvHy3C = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (236664 - 505277 == -268613)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF64 RID: 48996 RVA: 0x014358DC File Offset: 0x01433ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (45627 - 61571 != -15944)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (198669 - 575979 == -377310)
				{
					if (Game.mNextGameCode != 988)
					{
						break;
					}
					if (220332 - 200770 == 19562)
					{
						Game.nextGame();
						if (113690 - 599728 == -486038)
						{
							Game.mGameCode = 988;
							if (32581 - 212547 == -179966)
							{
								Game.mGameType = 5;
								if (153760 - 574109 == -420349)
								{
									Game.mGameTime = Time.time;
									if (207594 - 358131 == -150537)
									{
										Game.mGameScore = 0;
										if (86964 - 502393 == -415429)
										{
											Game.mGameMana = 0;
											if (109083 - 436258 != -327174)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (39981 - 495930 == -455949)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (38641 - 567773 != -529131)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (171250 - 282778 == -111528)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (1631 - 305876 == -304245)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (147264 - 220943 == -73679)
																{
																	this.aD8nrAMXZSy = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (288418 - 509360 == -220942)
																	{
																		this.dhhnr9M2RyZ = (GameGui)this.GetComponent(typeof(GameGui));
																		if (281119 - 578289 == -297170)
																		{
																			this.IyXnrWhomMU = Game.getPlayerSlot(PlayerData.UID);
																			if (225462 - 124280 == 101182)
																			{
																				this.xG4nruYqvqm = global::Math.div((float)(this.IyXnrWhomMU - 1), (float)12) + 1;
																				if (291339 - 42125 != 249215)
																				{
																					this.ihwnrFMunfM = PhotonClient.Connection;
																					if (254219 - 596506 != -342286)
																					{
																						PhotonClient.ActorNrList.Clear();
																						if (257900 - 271241 != -13340)
																						{
																							this.InitGame();
																							if (582 - 161780 == -161198)
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
			else
			{
				Debug.Log("Not Connected");
				if (50511 - 496693 == -446182)
				{
					Game.mGameType = 99;
					if (278588 - 49078 == 229510)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BF65 RID: 48997 RVA: 0x01435C74 File Offset: 0x01433E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (298848 - 524337 != -225489)
		{
		}
		for (;;)
		{
			if (this.ihwnrFMunfM == null)
			{
				if (292285 - 88669 == 203616)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (199726 - 13997 != 185730)
				{
					if (mGameState == eGameState.Init)
					{
						if (221411 - 227921 == -6510)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (193393 - 360162 == -166769)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (262694 - 298474 != -35779)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (104587 - 557414 == -452827)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (66321 - 368084 != -301762)
						{
							if (Game.music != 0)
							{
								if (219243 - 154691 != 64552)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (49824 - 81356 != -31532)
									{
										continue;
									}
									this.audio.Play();
									if (30717 - 44785 == -14067)
									{
										continue;
									}
								}
							}
							this.audio.volume = 0.1f * (float)Game.music;
							if (190653 - 24214 == 166439)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (23978 - 113771 == -89793)
						{
							if (Game.music != 0)
							{
								if (53820 - 321403 != -267583)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (64074 - 262784 != -198710)
									{
										continue;
									}
									this.audio.Play();
									if (114461 - 141461 != -27000)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (188312 - 380638 == -192326)
							{
								if (Time.time > this.RFDnry81sI9)
								{
									if (218563 - 339461 == -120897)
									{
										continue;
									}
									Game.mGameMana++;
									if (166514 - 136829 == 29686)
									{
										continue;
									}
									this.RFDnry81sI9 = Time.time + (float)12;
									if (243099 - 592490 == -349390)
									{
										continue;
									}
								}
								this.GameUpdateEvent();
								if (280883 - 412488 == -131605)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (77854 - 493284 != -415429)
						{
							this.GameUpdateEvent();
							if (180593 - 388522 == -207929)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (234056 - 317678 == -83622)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Ended)
						{
							break;
						}
						if (111030 - 174519 != -63488)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF66 RID: 48998 RVA: 0x01436058 File Offset: 0x01434258
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M988_GuildWar.$StartEvent$47488(this).GetEnumerator();
	}

	// Token: 0x0600BF67 RID: 48999 RVA: 0x01436068 File Offset: 0x01434268
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameUpdateEvent()
	{
		if (129352 - 420608 != -291256)
		{
		}
		while (this.NjmnrzYFBjy < 2)
		{
			if (147177 - 72658 != 74520)
			{
				if (this.Ekknxc0DUXX < 6000)
				{
					if (21905 - 499982 == -478076)
					{
						continue;
					}
					if (this.A1mnxn0JIHP >= 6000)
					{
						if (81196 - 518028 != -436832)
						{
							continue;
						}
					}
					else
					{
						if (this.FJ1nxQuqoLI == null)
						{
							break;
						}
						if (283719 - 148268 == 135452)
						{
							continue;
						}
						if (Time.time <= this.gM3nrK4S4tu)
						{
							break;
						}
						if (149059 - 187694 != -38635)
						{
							continue;
						}
						this.gM3nrK4S4tu = Time.time + 1f;
						if (265011 - 33106 == 231906)
						{
							continue;
						}
						int flagCount = this.getFlagCount(1);
						if (257749 - 67548 != 190201)
						{
							continue;
						}
						if (flagCount == 8)
						{
							if (118389 - 111237 == 7153)
							{
								continue;
							}
							this.Ekknxc0DUXX++;
							if (179585 - 469523 != -289938)
							{
								continue;
							}
							goto IL_453;
						}
						else if (flagCount == 7)
						{
							if (152692 - 533828 != -381135)
							{
								goto IL_453;
							}
							continue;
						}
						else if (flagCount == 6)
						{
							if (121348 - 172298 != -50949)
							{
								goto IL_1CB;
							}
							continue;
						}
						else
						{
							if (flagCount != 5)
							{
								goto IL_313;
							}
							if (204600 - 175457 == 29144)
							{
								continue;
							}
						}
						IL_73:
						this.Ekknxc0DUXX++;
						if (84952 - 213278 != -128325)
						{
							goto IL_313;
						}
						continue;
						IL_1CB:
						this.Ekknxc0DUXX++;
						if (6134 - 27016 != -20882)
						{
							continue;
						}
						goto IL_73;
						IL_453:
						this.Ekknxc0DUXX++;
						if (18785 - 570452 != -551667)
						{
							continue;
						}
						goto IL_1CB;
						IL_313:
						this.Ekknxc0DUXX += this.getFlagCount(1);
						if (172663 - 100511 != 72152)
						{
							continue;
						}
						int flagCount2 = this.getFlagCount(2);
						if (72170 - 56696 != 15474)
						{
							continue;
						}
						if (flagCount2 == 8)
						{
							if (5125 - 354984 == -349858)
							{
								continue;
							}
							this.A1mnxn0JIHP++;
							if (189818 - 207915 != -18096)
							{
								goto IL_3FE;
							}
							continue;
						}
						else if (flagCount2 == 7)
						{
							if (281111 - 360951 != -79839)
							{
								goto IL_3FE;
							}
							continue;
						}
						else if (flagCount2 == 6)
						{
							if (140334 - 340107 != -199773)
							{
								continue;
							}
							goto IL_247;
						}
						else if (flagCount2 == 5)
						{
							if (144938 - 578557 != -433618)
							{
								goto IL_26F;
							}
							continue;
						}
						IL_45:
						this.A1mnxn0JIHP += this.getFlagCount(2);
						if (203602 - 283780 != -80178)
						{
							continue;
						}
						break;
						IL_247:
						this.A1mnxn0JIHP++;
						if (88151 - 145810 == -57658)
						{
							continue;
						}
						IL_26F:
						this.A1mnxn0JIHP++;
						if (254596 - 492396 != -237799)
						{
							goto IL_45;
						}
						continue;
						IL_3FE:
						this.A1mnxn0JIHP++;
						if (289902 - 51157 != 238746)
						{
							goto IL_247;
						}
						continue;
					}
				}
				this.NjmnrzYFBjy = 2;
				if (167164 - 317545 == -150381)
				{
					if (this.Ekknxc0DUXX > this.A1mnxn0JIHP)
					{
						if (103140 - 589092 == -485951)
						{
							continue;
						}
						Game.sendMissionEvent(9888, 1);
						if (83867 - 13293 != 70574)
						{
							continue;
						}
					}
					else
					{
						Game.sendMissionEvent(9888, 2);
						if (222721 - 266499 == -43777)
						{
							continue;
						}
					}
					break;
				}
			}
		}
	}

	// Token: 0x0600BF68 RID: 49000 RVA: 0x01436554 File Offset: 0x01434754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (251843 - 264667 != -12823)
		{
		}
		for (;;)
		{
			if (!this.dhhnr9M2RyZ)
			{
				if (216896 - 112233 == 104663)
				{
					break;
				}
			}
			else
			{
				int num = (int)this.dhhnr9M2RyZ.GetScreenWidth();
				if (215580 - 382545 != -166964)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (75935 - 163457 == -87522)
					{
						GUI.depth = 2;
						if (36566 - 144639 != -108072)
						{
							eGameState mGameState = Game.mGameState;
							if (295163 - 162528 == 132635)
							{
								if (mGameState != eGameState.Normal)
								{
									if (27009 - 54343 != -27334)
									{
										continue;
									}
									if (mGameState != eGameState.Hold)
									{
										break;
									}
									if (172482 - 536012 != -363530)
									{
										continue;
									}
								}
								if (Time.time - Game.mStateTime < (float)2)
								{
									if (243519 - 90193 == 153326)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (199186 - 26369 != 172818)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
											if (164972 - 530963 == -365991)
											{
												Color color = GUI.color;
												if (168366 - 123651 == 44715)
												{
													float num3 = color.a = a;
													if (296096 - 42732 == 253364 && 275716 - 181682 != 94035)
													{
														GUI.color = color;
														if (83270 - 347988 == -264718)
														{
															if (100774 - 241251 == -140477)
															{
																GUI.DrawTexture(new Rect(0.5f * (float)num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.SAHnrVB2TM3);
																if (53564 - 325083 != -271518)
																{
																	float a2 = 1f;
																	if (221388 - 138600 == 82788)
																	{
																		Color color2 = GUI.color;
																		if (85790 - 403657 != -317866)
																		{
																			color2.a = a2;
																			if (229788 - 91121 == 138667)
																			{
																				if (280674 - 362552 != -81877)
																				{
																					Color color3 = GUI.color = color2;
																					if (138577 - 320138 == -181561)
																					{
																						if (138146 - 16016 == 122130)
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
									this.RenderPvpScore(num, 0);
									if (139039 - 52010 != 87030)
									{
										this.RenderWarMap(num, 160);
										if (207479 - 548579 == -341100)
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

	// Token: 0x0600BF69 RID: 49001 RVA: 0x01436960 File Offset: 0x01434B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderPvpScore(int pos_x, int pos_y)
	{
		if (92327 - 516147 != -423819)
		{
		}
		for (;;)
		{
			int num = this.zChnx5Y7ULy;
			if (73077 - 136250 == -63173)
			{
				if (num == 1)
				{
					if (241683 - 39163 == 202521)
					{
						continue;
					}
					if (this.pvpLine)
					{
						if (162967 - 375640 == -212672)
						{
							continue;
						}
						GUI.DrawTexture(new Rect(0.5f * (float)pos_x - (float)100, (float)115, (float)84, (float)32), this.pvpLine);
						if (128511 - 232612 == -104100)
						{
							continue;
						}
					}
				}
				else if (num == 2)
				{
					if (67124 - 62661 != 4463)
					{
						continue;
					}
					if (this.pvpLine)
					{
						if (18629 - 25759 != -7130)
						{
							continue;
						}
						GUI.DrawTexture(new Rect(0.5f * (float)pos_x + (float)120, (float)115, (float)84, (float)32), this.pvpLine);
						if (10691 - 99097 != -88406)
						{
							continue;
						}
					}
				}
				if (this.pvpScore1)
				{
					if (112756 - 348216 != -235460)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * (float)pos_x - (float)140, (float)110, (float)118, (float)32), this.pvpScore1);
					if (239035 - 250842 != -11807)
					{
						continue;
					}
				}
				if (this.pvpScore2)
				{
					if (201613 - 430138 == -228524)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * (float)pos_x + (float)80, (float)110, (float)118, (float)32), this.pvpScore2);
					if (297043 - 20923 != 276120)
					{
						continue;
					}
				}
				Guix.renderSmallNumber((int)(0.5f * (float)pos_x - (float)232 + (float)220), 112, this.Ekknxc0DUXX, true, 1f);
				if (207626 - 368147 == -160521)
				{
					Guix.renderSmallNumber((int)(0.5f * (float)pos_x - (float)232 + (float)440), 112, this.A1mnxn0JIHP, true, 1f);
					if (221521 - 246887 == -25366)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BF6A RID: 49002 RVA: 0x01436C34 File Offset: 0x01434E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderWarMap(int pos_x, int pos_y)
	{
		if (150887 - 35181 != 115707)
		{
		}
		for (;;)
		{
			IL_51A:
			if (this.xG4nruYqvqm == 0)
			{
				if (223081 - 115824 != 107258)
				{
					break;
				}
			}
			else
			{
				int num;
				if (this.xG4nruYqvqm == 1)
				{
					if (119594 - 148707 == -29112)
					{
						continue;
					}
					num = -1;
				}
				else
				{
					num = 1;
				}
				int num2 = num;
				GUI.BeginGroup(new Rect((float)(pos_x - 400), (float)pos_y, (float)400, (float)480));
				if (105523 - 192394 != -86870)
				{
					if (this.map_background)
					{
						if (253779 - 516642 != -262863)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)400, (float)480), this.map_background);
						if (86157 - 546078 == -459920)
						{
							continue;
						}
					}
					if (this.FJ1nxQuqoLI != null)
					{
						if (214512 - 497180 == -282667)
						{
							continue;
						}
						if (this.jxPnxeYAmwk != null)
						{
							if (6457 - 511603 != -505146)
							{
								continue;
							}
							int i = 0;
							if (204134 - 448360 == -244225)
							{
								continue;
							}
							while (i < 8)
							{
								Vector2 vector = this.jxPnxeYAmwk[i];
								if (138002 - 198821 == -60818)
								{
									goto IL_51A;
								}
								if (Time.time < this.j5xnxILqOmU[i] + (float)3)
								{
									if (196594 - 476653 != -280059)
									{
										goto IL_51A;
									}
									float num3 = (float)3 * Mathf.Repeat(Time.time - this.j5xnxILqOmU[i], 0.3f);
									if (182816 - 110407 == 72410)
									{
										goto IL_51A;
									}
									if (this.map_warningRing)
									{
										if (100197 - 486125 == -385927)
										{
											goto IL_51A;
										}
										if (num3 > (float)0)
										{
											if (145962 - 105650 == 40313)
											{
												goto IL_51A;
											}
											GUI.DrawTexture(new Rect((float)200 + (float)num2 * vector.x - num3 * (float)32, (float)240 - (float)num2 * vector.y - num3 * (float)32, (float)64 * num3, (float)64 * num3), this.map_warningRing);
											if (230128 - 505137 != -275009)
											{
												goto IL_51A;
											}
										}
									}
								}
								int num4 = this.FJ1nxQuqoLI[i];
								if (176143 - 190334 == -14190)
								{
									goto IL_51A;
								}
								if (num4 == 1)
								{
									if (84231 - 398180 != -313949)
									{
										goto IL_51A;
									}
									if (this.icon_flag_b)
									{
										if (47656 - 251176 == -203519)
										{
											goto IL_51A;
										}
										GUI.DrawTexture(new Rect((float)192 + (float)num2 * vector.x, (float)210 - (float)num2 * vector.y, (float)23, (float)32), this.icon_flag_b);
										if (170337 - 556598 != -386261)
										{
											goto IL_51A;
										}
									}
								}
								else if (num4 == 2)
								{
									if (271583 - 376369 != -104786)
									{
										goto IL_51A;
									}
									if (this.icon_flag_r)
									{
										if (118067 - 304359 != -186292)
										{
											goto IL_51A;
										}
										GUI.DrawTexture(new Rect((float)192 + (float)num2 * vector.x, (float)210 - (float)num2 * vector.y, (float)23, (float)32), this.icon_flag_r);
										if (185993 - 584271 != -398278)
										{
											goto IL_51A;
										}
									}
								}
								else if (this.icon_flag_w)
								{
									if (74704 - 55627 != 19077)
									{
										goto IL_51A;
									}
									GUI.DrawTexture(new Rect((float)192 + (float)num2 * vector.x, (float)210 - (float)num2 * vector.y, (float)23, (float)32), this.icon_flag_w);
									if (232176 - 7561 != 224615)
									{
										goto IL_51A;
									}
								}
								i++;
								if (253321 - 532178 != -278857)
								{
									goto IL_51A;
								}
							}
							if (104777 - 505054 == -400276)
							{
								continue;
							}
						}
					}
					if (this.map_playerDot)
					{
						if (63605 - 89584 != -25979)
						{
							continue;
						}
						if (this.map_allyDot)
						{
							if (33273 - 68153 == -34879)
							{
								continue;
							}
							if (this.map_enemyDot)
							{
								if (199420 - 346709 != -147289)
								{
									continue;
								}
								int j = 0;
								if (94016 - 362120 == -268103)
								{
									continue;
								}
								while (j < 24)
								{
									int num5 = global::Math.div((float)(j - 1), (float)12) + 1;
									if (198499 - 102688 == 95812)
									{
										goto IL_51A;
									}
									if (this.xG4nruYqvqm == num5)
									{
										if (2052 - 449261 != -447209)
										{
											goto IL_51A;
										}
										object obj2;
										object obj = obj2 = Game.mGamePlayerList[j];
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										GameObject gameObject = (GameObject)obj2;
										if (153517 - 301385 == -147867)
										{
											goto IL_51A;
										}
										if (gameObject)
										{
											if (89880 - 480266 == -390385)
											{
												goto IL_51A;
											}
											Vector3 position = gameObject.transform.position;
											if (20399 - 472654 != -452255)
											{
												goto IL_51A;
											}
											if (j == this.IyXnrWhomMU)
											{
												if (172418 - 452227 == -279808)
												{
													goto IL_51A;
												}
												GUI.DrawTexture(new Rect((float)194 + (float)num2 * position.x, (float)234 - (float)num2 * position.z, (float)12, (float)12), this.map_playerDot);
												if (88840 - 496140 == -407299)
												{
													goto IL_51A;
												}
											}
											else if (num5 == this.xG4nruYqvqm)
											{
												if (150192 - 413520 != -263328)
												{
													goto IL_51A;
												}
												GUI.DrawTexture(new Rect((float)197 + (float)num2 * position.x, (float)237 - (float)num2 * position.z, (float)6, (float)6), this.map_allyDot);
												if (247969 - 66852 == 181118)
												{
													goto IL_51A;
												}
											}
											else
											{
												GUI.DrawTexture(new Rect((float)197 + (float)num2 * position.x, (float)237 - (float)num2 * position.z, (float)6, (float)6), this.map_enemyDot);
												if (188630 - 443218 != -254588)
												{
													goto IL_51A;
												}
											}
										}
									}
									j++;
									if (266238 - 573332 != -307094)
									{
										goto IL_51A;
									}
								}
								if (173160 - 575889 != -402729)
								{
									continue;
								}
							}
						}
					}
					GUI.EndGroup();
					if (101830 - 509835 == -408005)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BF6B RID: 49003 RVA: 0x01437474 File Offset: 0x01435674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (198078 - 514862 != -316784)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (222587 - 81602 != 140986)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (177801 - 406671 == -228870)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (88331 - 53729 != 34603)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (97044 - 65458 == 31586)
						{
							int num4 = num;
							if (137460 - 211105 != -73644)
							{
								if (num4 == 9881)
								{
									if (185715 - 336132 != -150416)
									{
										Chat.SubmitChat("none", Game.getPlayerName(num3) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (229632 - 336964 != -107331)
										{
											break;
										}
									}
								}
								else if (num4 == -9882)
								{
									if (226836 - 366776 != -139939)
									{
										this.Ekknxc0DUXX += num2;
										if (120429 - 110164 != 10266)
										{
											break;
										}
									}
								}
								else if (num4 == -9883)
								{
									if (71217 - 290069 != -218851)
									{
										this.A1mnxn0JIHP += num2;
										if (174036 - 312648 != -138611)
										{
											break;
										}
									}
								}
								else if (num4 == -9884)
								{
									if (17413 - 332091 == -314678)
									{
										this.CaptureFlag(1, num3, num2);
										if (230257 - 48679 != 181579)
										{
											break;
										}
									}
								}
								else if (num4 == -9885)
								{
									if (26775 - 127053 != -100277)
									{
										this.CaptureFlag(2, num3, num2);
										if (41217 - 594137 != -552919)
										{
											break;
										}
									}
								}
								else if (num4 == -9886)
								{
									if (2800 - 154494 != -151693)
									{
										if (num2 > 0)
										{
											if (55056 - 116904 == -61847)
											{
												continue;
											}
											this.OpenMainGate(num3, num2);
											if (91843 - 438798 == -346954)
											{
												continue;
											}
										}
										else if (num2 < 0)
										{
											if (288091 - 154494 != 133597)
											{
												continue;
											}
											this.CloseMainGate(num3, Mathf.Abs(num2));
											if (274758 - 398921 == -124162)
											{
												continue;
											}
										}
										if (num3 == PlayerData.UID)
										{
											break;
										}
										if (217433 - 533679 == -316246)
										{
											this.ActivateWarSwitch(Mathf.Abs(num2));
											if (251696 - 132231 == 119465)
											{
												break;
											}
										}
									}
								}
								else if (num4 == -9887)
								{
									if (112910 - 322292 != -209381)
									{
										this.AlertFlag(num3, num2);
										if (91485 - 534139 == -442654)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 9888)
									{
										break;
									}
									if (38734 - 535462 != -496727)
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

	// Token: 0x0600BF6C RID: 49004 RVA: 0x014378A4 File Offset: 0x01435AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseFlag(int nFlagID)
	{
		return new M988_GuildWar.$UseFlag$47491(nFlagID, this).GetEnumerator();
	}

	// Token: 0x0600BF6D RID: 49005 RVA: 0x014378B4 File Offset: 0x01435AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (253680 - 472546 != -218866)
		{
		}
		for (;;)
		{
			Debug.Log("ActivateIcon@" + nID);
			if (146437 - 260609 != -114171)
			{
				if (nID >= 1)
				{
					if (132859 - 377099 == -244239)
					{
						continue;
					}
					if (nID <= 8)
					{
						if (123594 - 537079 == -413484)
						{
							continue;
						}
						int num = this.xG4nruYqvqm;
						if (88678 - 374167 == -285488)
						{
							continue;
						}
						if (num == 1)
						{
							if (267130 - 469781 == -202650)
							{
								continue;
							}
							if (this.FJ1nxQuqoLI[nID - 1] == 1)
							{
								break;
							}
							if (179577 - 542041 == -362463)
							{
								continue;
							}
							Game.sendMissionEvent(9884, nID);
							if (181719 - 543944 != -362225)
							{
								continue;
							}
							break;
						}
						else if (num == 2)
						{
							if (224313 - 407236 == -182922)
							{
								continue;
							}
							if (this.FJ1nxQuqoLI[nID - 1] == 2)
							{
								break;
							}
							if (256707 - 125524 != 131183)
							{
								continue;
							}
							Game.sendMissionEvent(9885, nID);
							if (165497 - 82986 != 82511)
							{
								continue;
							}
							break;
						}
						else
						{
							Debug.LogError("Unknown PlayerTeam:" + this.xG4nruYqvqm);
							if (112137 - 59404 != 52734)
							{
								break;
							}
							continue;
						}
					}
				}
				Debug.LogError("Unknown Icon:" + nID);
				if (154687 - 209743 != -55055)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600BF6E RID: 49006 RVA: 0x01437AD0 File Offset: 0x01435CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CaptureFlag(int nFlagOwnerTeam, int nFlagOwnerID, int nFlagID)
	{
		if (141603 - 393350 != -251747)
		{
		}
		for (;;)
		{
			Debug.Log("CaptureFlag:" + nFlagOwnerID + "@" + nFlagID);
			if (182770 - 182320 != 451)
			{
				if (nFlagID > this.FJ1nxQuqoLI.Length)
				{
					if (22023 - 144811 != -122787)
					{
						break;
					}
				}
				else if (this.FJ1nxQuqoLI[nFlagID - 1] == nFlagOwnerTeam)
				{
					if (280638 - 398541 != -117902)
					{
						break;
					}
				}
				else
				{
					int num = this.FJ1nxQuqoLI[nFlagID - 1];
					if (113684 - 218419 == -104735)
					{
						object obj2;
						object obj = obj2 = Game.getPlayerName(nFlagOwnerID);
						if (!(obj is string))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string));
						}
						string lhs = (string)obj2;
						if (4019 - 273144 == -269125)
						{
							int playerSlot = Game.getPlayerSlot(nFlagOwnerID);
							if (140456 - 10851 == 129605)
							{
								int num2 = 0;
								if (54231 - 301030 != -246798)
								{
									int num3 = 0;
									if (180398 - 336758 == -156360)
									{
										if (142377 - 234707 == -92330)
										{
											if (nFlagOwnerTeam == 1)
											{
												if (182775 - 49924 != 132851)
												{
													continue;
												}
												num2 = 100 * this.getFlagCount(1) + 100;
												if (104608 - 6567 == 98042)
												{
													continue;
												}
												num3 = -100 * this.getFlagCount(2);
												if (207755 - 471736 == -263980)
												{
													continue;
												}
											}
											else if (nFlagOwnerTeam == 2)
											{
												if (95391 - 390582 != -295191)
												{
													continue;
												}
												num2 = 100 * this.getFlagCount(2) + 100;
												if (92457 - 98744 == -6286)
												{
													continue;
												}
												num3 = -100 * this.getFlagCount(1);
												if (58027 - 193779 != -135752)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Unknown PlayerTeam: " + nFlagOwnerTeam);
												if (298726 - 555294 == -256567)
												{
													continue;
												}
											}
											this.FJ1nxQuqoLI[nFlagID - 1] = nFlagOwnerTeam;
											if (193559 - 48753 == 144806)
											{
												this.CaptureWarGate(nFlagID, nFlagOwnerTeam);
												if (56704 - 473905 == -417201)
												{
													if (num == 0)
													{
														if (122565 - 150992 != -28427)
														{
															continue;
														}
														if (nFlagOwnerID == PlayerData.UID)
														{
															if (233206 - 58204 == 175003)
															{
																continue;
															}
															this.SendMessage("newNoticeBar", "You have captured Flag" + nFlagID + " (+" + num2 + ")");
															if (196516 - 242237 == -45720)
															{
																continue;
															}
															Chat.SubmitChat("none", "You have captured flag" + nFlagID + "! (+" + num2 + ")", eChatType.system, eChatMode.system);
															if (229957 - 558035 != -328078)
															{
																continue;
															}
															if (nFlagOwnerTeam == 1)
															{
																if (15883 - 70770 == -54886)
																{
																	continue;
																}
																Game.sendMissionEvent(9882, num2);
																if (236199 - 395996 == -159796)
																{
																	continue;
																}
															}
															else if (nFlagOwnerTeam == 2)
															{
																if (104986 - 530542 == -425555)
																{
																	continue;
																}
																Game.sendMissionEvent(9883, num2);
																if (278564 - 3903 != 274661)
																{
																	continue;
																}
															}
														}
														else
														{
															this.SendMessage("newNoticeBar", "Team" + nFlagOwnerTeam + " has captured Flag" + nFlagID + "! (+" + num2 + ")");
															if (149033 - 135006 == 14028)
															{
																continue;
															}
															Chat.SubmitChat("none", lhs + "[" + nFlagOwnerTeam + "] has captured flag" + nFlagID + "! (+" + num2 + ")", eChatType.system, eChatMode.system);
															if (278334 - 576211 == -297876)
															{
																continue;
															}
														}
													}
													else if (nFlagOwnerID == PlayerData.UID)
													{
														if (224782 - 175934 == 48849)
														{
															continue;
														}
														this.SendMessage("newNoticeBar", "You have stolen flag" + nFlagID + "! (+" + num2 + ")");
														if (248016 - 547235 == -299218)
														{
															continue;
														}
														Chat.SubmitChat("none", "You have stolen flag" + nFlagID + "! (+" + num2 + ")", eChatType.system, eChatMode.system);
														if (166030 - 298165 == -132134)
														{
															continue;
														}
														if (this.xG4nruYqvqm == 1)
														{
															if (259256 - 148498 == 110759)
															{
																continue;
															}
															Game.sendMissionEvent(9882, num2);
															if (16669 - 21613 != -4944)
															{
																continue;
															}
															Game.sendMissionEvent(9883, num3);
															if (119098 - 390929 != -271831)
															{
																continue;
															}
														}
														else if (this.xG4nruYqvqm == 2)
														{
															if (100080 - 136928 == -36847)
															{
																continue;
															}
															Game.sendMissionEvent(9883, num2);
															if (152995 - 529590 != -376595)
															{
																continue;
															}
															Game.sendMissionEvent(9882, num3);
															if (10885 - 584553 != -573668)
															{
																continue;
															}
														}
													}
													else if (this.xG4nruYqvqm == nFlagOwnerTeam)
													{
														if (87568 - 29875 != 57693)
														{
															continue;
														}
														this.SendMessage("newNoticeBar", "Your team has taken Flag" + nFlagID + "! (+" + num2 + ")");
														if (267679 - 233862 != 33817)
														{
															continue;
														}
														Chat.SubmitChat("none", lhs + "[" + nFlagOwnerTeam + "] has taken flag" + nFlagID + " (+" + num2 + ")", eChatType.system, eChatMode.system);
														if (266991 - 217789 != 49202)
														{
															continue;
														}
													}
													else
													{
														this.SendMessage("newNoticeBar", "Your enemies have stolen Flag" + nFlagID + "! (" + num3 + ")");
														if (57560 - 288846 == -231285)
														{
															continue;
														}
														Chat.SubmitChat("none", lhs + "[" + nFlagOwnerTeam + "] has stolen flag" + nFlagID + " (" + num3 + ")", eChatType.system, eChatMode.system);
														if (224670 - 299384 == -74713)
														{
															continue;
														}
													}
													GameObject gameObject = GameObject.Find("WarFlag" + nFlagID);
													if (293928 - 587454 == -293526)
													{
														if (!gameObject)
														{
															break;
														}
														if (164438 - 589230 != -424791)
														{
															Transform transform = gameObject.transform.Find("flag");
															if (289379 - 550833 != -261453)
															{
																IconControl iconControl = (IconControl)gameObject.GetComponent(typeof(IconControl));
																if (265297 - 252024 != 13274)
																{
																	if (transform)
																	{
																		if (232287 - 145035 != 87252)
																		{
																			continue;
																		}
																		if (iconControl)
																		{
																			if (152020 - 315287 == -163266)
																			{
																				continue;
																			}
																			ClothRenderer clothRenderer = (ClothRenderer)transform.GetComponent(typeof(ClothRenderer));
																			if (114942 - 97930 != 17012)
																			{
																				continue;
																			}
																			if (clothRenderer)
																			{
																				if (100405 - 362009 != -261604)
																				{
																					continue;
																				}
																				if (174748 - 408486 != -233738)
																				{
																					continue;
																				}
																				if (nFlagOwnerTeam == 1)
																				{
																					if (135875 - 48846 != 87029)
																					{
																						continue;
																					}
																					if (this.mFlag_b)
																					{
																						if (93852 - 413305 != -319453)
																						{
																							continue;
																						}
																						clothRenderer.material = this.mFlag_b;
																						if (116741 - 302713 == -185971)
																						{
																							continue;
																						}
																					}
																					if (this.icon_flag_b)
																					{
																						if (176072 - 16098 != 159974)
																						{
																							continue;
																						}
																						iconControl.MapIcon = this.icon_flag_b;
																						if (157566 - 555133 != -397567)
																						{
																							continue;
																						}
																					}
																				}
																				else if (nFlagOwnerTeam == 2)
																				{
																					if (37404 - 146754 == -109349)
																					{
																						continue;
																					}
																					if (this.mFlag_r)
																					{
																						if (262507 - 393723 == -131215)
																						{
																							continue;
																						}
																						clothRenderer.material = this.mFlag_r;
																						if (99209 - 435535 == -336325)
																						{
																							continue;
																						}
																					}
																					if (this.icon_flag_r)
																					{
																						if (154070 - 346619 != -192549)
																						{
																							continue;
																						}
																						iconControl.MapIcon = this.icon_flag_r;
																						if (229523 - 328106 != -98583)
																						{
																							continue;
																						}
																					}
																				}
																				else
																				{
																					if (this.mFlag_w)
																					{
																						if (208546 - 340215 == -131668)
																						{
																							continue;
																						}
																						clothRenderer.material = this.mFlag_w;
																						if (1020 - 66187 != -65167)
																						{
																							continue;
																						}
																					}
																					if (this.icon_flag_w)
																					{
																						if (5919 - 571806 != -565887)
																						{
																							continue;
																						}
																						iconControl.MapIcon = this.icon_flag_w;
																						if (52036 - 150441 == -98404)
																						{
																							continue;
																						}
																					}
																				}
																			}
																			Transform transform2 = gameObject.transform.Find("flagRing");
																			if (159681 - 358544 == -198862)
																			{
																				continue;
																			}
																			if (transform2)
																			{
																				if (91126 - 515995 == -424868)
																				{
																					continue;
																				}
																				UnityEngine.Object.Destroy(transform2.gameObject);
																				if (260797 - 310244 != -49447)
																				{
																					continue;
																				}
																			}
																			GameObject gameObject2 = null;
																			if (230380 - 290333 != -59952 && 21345 - 253363 != -232017)
																			{
																				if (nFlagOwnerTeam == 1)
																				{
																					if (204920 - 12094 == 192827)
																					{
																						continue;
																					}
																					if (this.mFlagRing1)
																					{
																						if (275346 - 396398 != -121052)
																						{
																							continue;
																						}
																						gameObject2 = (GameObject)UnityEngine.Object.Instantiate(this.mFlagRing1, transform.position, Quaternion.identity);
																						if (15066 - 197026 != -181960)
																						{
																							continue;
																						}
																					}
																				}
																				else if (nFlagOwnerTeam == 2)
																				{
																					if (294113 - 105390 != 188723)
																					{
																						continue;
																					}
																					if (this.mFlagRing2)
																					{
																						if (233811 - 557748 != -323937)
																						{
																							continue;
																						}
																						gameObject2 = (GameObject)UnityEngine.Object.Instantiate(this.mFlagRing2, transform.position, Quaternion.identity);
																						if (267168 - 5741 == 261428)
																						{
																							continue;
																						}
																					}
																				}
																				if (gameObject2)
																				{
																					if (167368 - 419249 == -251880)
																					{
																						continue;
																					}
																					gameObject2.name = "flagRing";
																					if (197207 - 425886 == -228678)
																					{
																						continue;
																					}
																					gameObject2.transform.parent = transform;
																					if (184779 - 267033 == -82253)
																					{
																						continue;
																					}
																				}
																				goto IL_D60;
																			}
																			continue;
																		}
																	}
																	Debug.Log("Cannot find FlagTransform");
																	if (248420 - 79799 == 168622)
																	{
																		continue;
																	}
																	IL_D60:
																	if (this.mFlagCapture_ring)
																	{
																		if (260601 - 553961 != -293359)
																		{
																			UnityEngine.Object.Instantiate(this.mFlagCapture_ring, gameObject.transform.position, Quaternion.identity);
																			if (203102 - 285191 == -82089)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing mFlagCapture_ring gameObject");
																		if (30264 - 128017 != -97752)
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

	// Token: 0x0600BF6F RID: 49007 RVA: 0x01438A5C File Offset: 0x01436C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AlertFlag(int nPlayerID, int nFlagID)
	{
		if (166705 - 60776 != 105929)
		{
		}
		for (;;)
		{
			Debug.Log("OnAlertFlag: " + nPlayerID + "@" + nFlagID);
			if (118682 - 527557 == -408875)
			{
				object obj2;
				object obj = obj2 = Game.getPlayerName(nPlayerID);
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				string lhs = (string)obj2;
				if (256734 - 324052 == -67318)
				{
					int playerSlot = Game.getPlayerSlot(nPlayerID);
					if (163004 - 567890 == -404886)
					{
						int num = global::Math.div((float)(playerSlot - 1), (float)12) + 1;
						if (76176 - 30438 != 45739)
						{
							if (nFlagID < 1)
							{
								break;
							}
							if (251767 - 374167 == -122400)
							{
								if (nFlagID > 8)
								{
									break;
								}
								if (19652 - 290628 != -270975)
								{
									if (Time.time <= this.j5xnxILqOmU[nFlagID - 1] + (float)3)
									{
										break;
									}
									if (278517 - 497582 == -219065)
									{
										this.j5xnxILqOmU[nFlagID - 1] = Time.time;
										if (211719 - 1380 == 210339)
										{
											if (this.FJ1nxQuqoLI[nFlagID - 1] == 0)
											{
												if (20762 - 569058 == -548296)
												{
													if (this.xG4nruYqvqm == num)
													{
														if (172201 - 145900 != 26302)
														{
															this.SendMessage("newGameMessage", lhs + " is taking flag" + nFlagID + ".");
															if (152410 - 302334 == -149924)
															{
																break;
															}
														}
													}
													else
													{
														this.SendMessage("newGameMessage", "Your enemy is taking flag" + nFlagID + "!");
														if (219197 - 181775 == 37422)
														{
															break;
														}
													}
												}
											}
											else if (this.xG4nruYqvqm == num)
											{
												if (184808 - 159700 != 25109)
												{
													this.SendMessage("newGameMessage", lhs + " is taking enemy's flag" + nFlagID + ".");
													if (23622 - 53779 != -30156)
													{
														break;
													}
												}
											}
											else
											{
												this.SendMessage("newGameMessage", "Your enemy is stealing your flag" + nFlagID + "!");
												if (261885 - 322624 != -60738)
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

	// Token: 0x0600BF70 RID: 49008 RVA: 0x01438D8C File Offset: 0x01436F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getFlagCount(int nTeam)
	{
		if (177692 - 140028 != 37664)
		{
		}
		int num;
		for (;;)
		{
			IL_81:
			if (this.FJ1nxQuqoLI == null)
			{
				if (18126 - 345857 == -327731)
				{
					break;
				}
			}
			else
			{
				num = 0;
				if (84013 - 575964 != -491950)
				{
					int i = 0;
					if (201518 - 251576 == -50058)
					{
						while (i < 8)
						{
							if (this.FJ1nxQuqoLI[i] == nTeam)
							{
								if (129592 - 276628 == -147035)
								{
									goto IL_81;
								}
								num++;
								if (98252 - 345059 != -246807)
								{
									goto IL_81;
								}
							}
							i++;
							if (21653 - 593552 != -571899)
							{
								goto IL_81;
							}
						}
						if (42557 - 535710 == -493153)
						{
							goto IL_107;
						}
					}
				}
			}
		}
		return 0;
		IL_107:
		return num;
	}

	// Token: 0x0600BF71 RID: 49009 RVA: 0x01438EB8 File Offset: 0x014370B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseWarSwitch(int nSwitchID)
	{
		if (225963 - 243305 != -17341)
		{
		}
		do
		{
			if (nSwitchID >= 1)
			{
				if (183183 - 470401 != -287218)
				{
					continue;
				}
				if (nSwitchID <= 6)
				{
					if (223568 - 401001 != -177433)
					{
						continue;
					}
					if (Time.time < this.l8inxJXDHfE[nSwitchID - 1])
					{
						if (287679 - 270868 != 16811)
						{
							continue;
						}
						this.SendMessage("newGameMessage", "MainGate switch time out.");
						if (213132 - 387993 != -174860)
						{
							break;
						}
						continue;
					}
					else
					{
						this.ActivateWarSwitch(nSwitchID);
						if (284452 - 440667 == -156214)
						{
							continue;
						}
						if (this.Onhnx6SlbOb[nSwitchID - 1])
						{
							if (220525 - 342527 == -122001)
							{
								continue;
							}
							Game.sendMissionEvent(9886, nSwitchID);
							if (154024 - 174810 != -20785)
							{
								break;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9886, -1 * nSwitchID);
							if (103441 - 382453 != -279012)
							{
								continue;
							}
							break;
						}
					}
				}
			}
			Debug.LogError("Unknown SwitchID: " + nSwitchID);
		}
		while (73360 - 186133 == -112772);
	}

	// Token: 0x0600BF72 RID: 49010 RVA: 0x01439068 File Offset: 0x01437268
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActivateWarSwitch(int nSwitchID)
	{
		if (244513 - 534760 != -290247)
		{
		}
		while (nSwitchID >= 1)
		{
			if (139141 - 337725 == -198584)
			{
				if (nSwitchID > 6)
				{
					break;
				}
				if (22846 - 436859 != -414012)
				{
					this.l8inxJXDHfE[nSwitchID - 1] = Time.time + (float)4;
					if (200352 - 186284 == 14068)
					{
						GameObject gameObject = GameObject.Find("WarSwitch" + nSwitchID);
						if (251299 - 453121 == -201822)
						{
							if (!gameObject)
							{
								break;
							}
							if (23444 - 174554 != -151109)
							{
								gameObject.animation.Play();
								if (85439 - 204714 != -119274)
								{
									gameObject.audio.Play();
									if (57970 - 141679 == -83709)
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

	// Token: 0x0600BF73 RID: 49011 RVA: 0x014391B0 File Offset: 0x014373B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenMainGate(int nPlayerID, int nGateID)
	{
		if (47923 - 24879 != 23044)
		{
		}
		while (nGateID >= 1)
		{
			if (234720 - 472957 == -238237)
			{
				if (nGateID > 6)
				{
					break;
				}
				if (262047 - 175832 != 86216)
				{
					this.Onhnx6SlbOb[nGateID - 1] = false;
					if (227171 - 580455 == -353284)
					{
						GameObject gameObject = GameObject.Find("WarMainGate" + nGateID);
						if (265431 - 566064 == -300633)
						{
							if (!gameObject)
							{
								break;
							}
							if (194269 - 160208 != 34062)
							{
								gameObject.animation.Play("open");
								if (275903 - 283865 == -7962)
								{
									gameObject.audio.Play();
									if (75032 - 99620 == -24588)
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

	// Token: 0x0600BF74 RID: 49012 RVA: 0x01439300 File Offset: 0x01437500
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseMainGate(int nPlayerID, int nGateID)
	{
		if (279618 - 306434 != -26815)
		{
		}
		while (nGateID >= 1)
		{
			if (158504 - 424581 == -266077)
			{
				if (nGateID > 6)
				{
					break;
				}
				if (210443 - 139177 == 71266)
				{
					this.Onhnx6SlbOb[nGateID - 1] = true;
					if (78260 - 191585 == -113325)
					{
						GameObject gameObject = GameObject.Find("WarMainGate" + nGateID);
						if (2199 - 2134 != 66)
						{
							if (!gameObject)
							{
								break;
							}
							if (11694 - 29158 == -17464)
							{
								gameObject.animation.Play("close");
								if (159163 - 213793 != -54629)
								{
									gameObject.audio.Play();
									if (17718 - 18547 == -829)
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

	// Token: 0x0600BF75 RID: 49013 RVA: 0x01439450 File Offset: 0x01437650
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CaptureWarGate(int nGateID, int nTeam)
	{
		if (204050 - 173827 != 30223)
		{
		}
		for (;;)
		{
			IL_54:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
			if (188689 - 568492 == -379803)
			{
				int i = 0;
				if (284086 - 179340 == 104746)
				{
					GameObject[] array2 = array;
					if (274413 - 162136 == 112277)
					{
						int length = array2.Length;
						if (286932 - 179781 != 107152)
						{
							while (i < length)
							{
								if (array2[i].name == "WarGate" + nGateID)
								{
									if (13638 - 124492 == -110853)
									{
										goto IL_54;
									}
									array2[i].SendMessage("GateCapture", nTeam);
									if (173713 - 309493 != -135780)
									{
										goto IL_54;
									}
								}
								i++;
								if (29676 - 261803 == -232126)
								{
									goto IL_54;
								}
							}
							if (83740 - 470435 == -386695)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF76 RID: 49014 RVA: 0x014395B8 File Offset: 0x014377B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitGame()
	{
		if (54655 - 59541 != -4885)
		{
		}
		for (;;)
		{
			IL_8A:
			Debug.Log("Initializing Mission");
			if (92789 - 293610 != -200820)
			{
				this.SAHnrVB2TM3 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
				if (57824 - 28223 != 29602)
				{
					this.FJ1nxQuqoLI = new int[8];
					if (271553 - 52122 != 219432)
					{
						this.jxPnxeYAmwk = new Vector2[8];
						if (63983 - 73670 != -9686)
						{
							this.j5xnxILqOmU = new float[8];
							if (228801 - 147775 == 81026)
							{
								this.Onhnx6SlbOb = new bool[6];
								if (248815 - 538496 != -289680)
								{
									this.l8inxJXDHfE = new float[6];
									if (33226 - 218051 == -184825)
									{
										int i = 1;
										if (47637 - 540114 == -492477)
										{
											while (i <= 8)
											{
												GameObject gameObject = GameObject.Find("WarFlag" + i);
												if (288624 - 553550 != -264926)
												{
													goto IL_8A;
												}
												if (gameObject)
												{
													if (52060 - 305011 != -252951)
													{
														goto IL_8A;
													}
													this.jxPnxeYAmwk[i - 1] = new Vector2(gameObject.transform.position.x, gameObject.transform.position.z);
													if (157877 - 485338 == -327460)
													{
														goto IL_8A;
													}
												}
												else
												{
													Debug.LogError("Cannot find WarFlag" + i);
													if (149140 - 146802 == 2339)
													{
														goto IL_8A;
													}
												}
												i++;
												if (132437 - 103376 == 29062)
												{
													goto IL_8A;
												}
											}
											if (118029 - 23293 != 94737)
											{
												Hashtable customOpParameters = new Hashtable();
												if (291968 - 83373 == 208595)
												{
													this.ihwnrFMunfM.OpCustom(52, customOpParameters, true);
													if (23125 - 451609 == -428484)
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

	// Token: 0x0600BF77 RID: 49015 RVA: 0x01439898 File Offset: 0x01437A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (17805 - 228907 != -211101)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (195750 - 86849 != 108902)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (67468 - 480307 != -412838)
				{
					Game.mGameState = eGameState.Setup;
					if (248859 - 288740 == -39881)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BF78 RID: 49016 RVA: 0x0143993C File Offset: 0x01437B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (208416 - 254140 != -45723)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (278067 - 352441 != -74373)
			{
				Game.mGameState = eGameState.Start;
				if (37216 - 425129 == -387913)
				{
					Game.mGameTime = Time.time;
					if (247567 - 519442 != -271874)
					{
						Game.mStateTime = Time.time;
						if (72978 - 592106 != -519127)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (61324 - 135166 != -73841)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF79 RID: 49017 RVA: 0x01439A28 File Offset: 0x01437C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BF7A RID: 49018 RVA: 0x01439A2C File Offset: 0x01437C2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (187086 - 578243 != -391156)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (73958 - 328820 == -254862)
			{
				if (num == PlayerData.UID)
				{
					if (266432 - 133321 == 133111)
					{
						this.SetupActors();
						if (85003 - 268187 == -183184)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (62090 - 125909 != -63818)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BF7B RID: 49019 RVA: 0x01439AFC File Offset: 0x01437CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (49347 - 209083 != -159736)
		{
		}
		for (;;)
		{
			IL_95:
			Debug.Log("Creating Actors");
			if (179370 - 193879 == -14509)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (107636 - 158522 == -50886)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (248349 - 162313 == 86036)
						{
							int i = 0;
							if (215751 - 37295 != 178457)
							{
								CharacterControl[] array2 = array;
								if (71658 - 210797 != -139138)
								{
									int length = array2.Length;
									if (34180 - 34868 != -687)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (247574 - 359000 != -111426)
											{
												goto IL_95;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (79939 - 331525 != -251586)
											{
												goto IL_95;
											}
											this.gG9nxtwUTcy++;
											if (158021 - 286164 == -128142)
											{
												goto IL_95;
											}
											i++;
											if (190344 - 534453 == -344108)
											{
												goto IL_95;
											}
										}
										if (264482 - 96637 != 167846)
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
						Game.setGameState(eGameState.Ready);
						if (140784 - 38608 == 102176)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF7C RID: 49020 RVA: 0x01439D14 File Offset: 0x01437F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (45414 - 388385 != -342971)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (57087 - 40783 == 16304)
			{
				int i = 0;
				if (33610 - 347055 != -313444)
				{
					CharacterControl[] array2 = array;
					if (17114 - 226021 == -208907)
					{
						int length = array2.Length;
						if (110424 - 309458 != -199033)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (133787 - 583589 != -449802)
								{
									goto IL_E0;
								}
								i++;
								if (182753 - 437196 == -254442)
								{
									goto IL_E0;
								}
							}
							if (13555 - 22857 == -9302)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF7D RID: 49021 RVA: 0x01439E44 File Offset: 0x01438044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (241505 - 417656 != -176151)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (77997 - 78851 == -854)
			{
				Game.mGameState = eGameState.Ready;
				if (33845 - 94519 != -60673)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (109097 - 179648 != -70550)
					{
						this.zChnx5Y7ULy = global::Math.div((float)(playerSlot - 1), (float)12) + 1;
						if (167035 - 52584 == 114451)
						{
							if (245740 - 49239 != 196502)
							{
								GameObject gameObject;
								if (playerSlot >= 1)
								{
									if (244694 - 354897 == -110202)
									{
										continue;
									}
									if (playerSlot <= 24)
									{
										if (251673 - 273108 != -21435)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (206436 - 264516 != -58080)
										{
											continue;
										}
										goto IL_AF;
									}
								}
								gameObject = GameObject.Find("StartPoint1");
								if (84879 - 444312 == -359432)
								{
									continue;
								}
								IL_AF:
								if (gameObject)
								{
									if (42701 - 70098 == -27396)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, this.zChnx5Y7ULy, gameObject.transform.position, gameObject.transform.forward);
									if (292972 - 223757 == 69216)
									{
										continue;
									}
								}
								Game.sendMissionEvent(9881, this.zChnx5Y7ULy);
								if (281436 - 32334 != 249103)
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

	// Token: 0x0600BF7E RID: 49022 RVA: 0x0143A064 File Offset: 0x01438264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (128033 - 810 != 127224)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (120597 - 4266 != 116332)
			{
				hashtable.Add(71, CID);
				if (172838 - 418170 == -245332)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (80941 - 149889 != -68947)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (298380 - 123099 == 175281)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (103830 - 196909 == -93079)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (6183 - 328683 != -322499)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (173610 - 392817 == -219207)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (44264 - 370313 == -326049)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (226500 - 469644 == -243144)
											{
												this.ihwnrFMunfM.OpCustom(61, hashtable, true);
												if (266393 - 69784 != 196610)
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

	// Token: 0x0600BF7F RID: 49023 RVA: 0x0143A2F0 File Offset: 0x014384F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (61512 - 583590 != -522078)
		{
		}
		for (;;)
		{
			IL_190:
			GameObject gameObject = Game.createPlayer(data);
			if (17607 - 506187 == -488580)
			{
				if (!gameObject)
				{
					break;
				}
				if (80107 - 283115 == -203008)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (208927 - 96419 != 112509)
					{
						if (characterControl)
						{
							if (130456 - 363671 == -233214)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (184438 - 242821 != -58383)
							{
								continue;
							}
						}
						PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (114904 - 540794 == -425890)
						{
							playerCameraControl.target = gameObject;
							if (214510 - 441933 != -227422)
							{
								this.createTeamRing(gameObject);
								if (144045 - 411466 == -267421)
								{
									if (Game.mGameState < eGameState.Start)
									{
										if (214395 - 352479 != -138083)
										{
											this.StartGame();
											if (75706 - 257780 != -182073)
											{
												break;
											}
										}
									}
									else
									{
										this.aD8nrAMXZSy.target = Game.mPlayer;
										if (183184 - 32838 == 150346)
										{
											this.aD8nrAMXZSy.enabled = true;
											if (87536 - 223328 == -135792)
											{
												if (Game.mGameState != eGameState.Normal)
												{
													if (233162 - 59820 == 173343)
													{
														continue;
													}
													if (Game.mGameState != eGameState.Hold)
													{
														goto IL_24B;
													}
													if (27099 - 246120 == -219020)
													{
														continue;
													}
												}
												Game.mGameState = eGameState.Normal;
												if (84309 - 412276 == -327966)
												{
													continue;
												}
												if (this.dhhnr9M2RyZ)
												{
													if (66481 - 571233 != -504752)
													{
														continue;
													}
													this.dhhnr9M2RyZ.enabled = true;
													if (280566 - 36639 == 243928)
													{
														continue;
													}
													this.dhhnr9M2RyZ.closeDeadMenu();
													if (133200 - 473553 == -340352)
													{
														continue;
													}
												}
												IL_24B:
												if (!characterControl)
												{
													break;
												}
												if (83608 - 242515 == -158907)
												{
													if (CharacterData.current == null)
													{
														break;
													}
													if (203832 - 108141 == 95691)
													{
														characterControl.mTimeOutList = new UnityScript.Lang.Array();
														if (258654 - 35308 == 223346)
														{
															IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(CharacterData.current.cooldown);
															if (272709 - 323732 != -51022)
															{
																while (enumerator.MoveNext())
																{
																	object obj = enumerator.Current;
																	object obj3;
																	object obj2 = obj3 = obj;
																	if (!(obj2 is timeOutClass))
																	{
																		obj3 = RuntimeServices.Coerce(obj2, typeof(timeOutClass));
																	}
																	timeOutClass timeOutClass = (timeOutClass)obj3;
																	if (215635 - 525279 == -309643)
																	{
																		goto IL_190;
																	}
																	if (timeOutClass.cTime > Time.time)
																	{
																		if (183785 - 129738 == 54048)
																		{
																			goto IL_190;
																		}
																		characterControl.mTimeOutList.Add(timeOutClass);
																		if (95805 - 246861 == -151055)
																		{
																			goto IL_190;
																		}
																		UnityRuntimeServices.Update(enumerator, timeOutClass);
																		if (39669 - 283472 != -243803)
																		{
																			goto IL_190;
																		}
																	}
																}
																if (58887 - 519872 == -460985)
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

	// Token: 0x0600BF80 RID: 49024 RVA: 0x0143A760 File Offset: 0x01438960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (229880 - 175833 != 54047)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (276382 - 298512 == -22130)
			{
				if (!gameObject)
				{
					break;
				}
				if (241393 - 531276 != -289882)
				{
					this.createTeamRing(gameObject);
					if (155850 - 378144 != -222293)
					{
						if (!this.dhhnr9M2RyZ)
						{
							break;
						}
						if (298757 - 326925 != -28167)
						{
							this.dhhnr9M2RyZ.ResetTeamBar();
							if (134774 - 20087 == 114687)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF81 RID: 49025 RVA: 0x0143A850 File Offset: 0x01438A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (41934 - 54327 != -12393)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (64400 - 194644 != -130243)
			{
				hashtable.Add(43, PlayerData.UID);
				if (132088 - 532773 != -400684)
				{
					hashtable.Add(73, nType);
					if (138185 - 441165 == -302980)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (48450 - 26696 == 21754)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (97074 - 437316 != -340241)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (31612 - 587118 == -555506)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (143536 - 411110 == -267574)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (104267 - 456395 != -352127)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (247835 - 152145 != 95691)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (243978 - 528224 != -284245)
												{
													this.ihwnrFMunfM.OpCustom(63, hashtable, true);
													if (255092 - 316963 == -61871)
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

	// Token: 0x0600BF82 RID: 49026 RVA: 0x0143AB08 File Offset: 0x01438D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (103079 - 423038 != -319959)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (45012 - 452774 != -407761)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (200786 - 460050 == -259264)
				{
					if (gameObject)
					{
						if (107331 - 155050 == -47718)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (49248 - 465814 != -416566)
						{
							continue;
						}
						if (characterControl)
						{
							if (8662 - 56600 != -47938)
							{
								continue;
							}
							if (characterControl.Type != "WarGate")
							{
								if (271576 - 458975 == -187398)
								{
									continue;
								}
								this.createTeamRing(gameObject);
								if (22352 - 486 != 21866)
								{
									continue;
								}
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (277756 - 241971 != 35786)
						{
							if (this.gG9nxtwUTcy <= 0)
							{
								break;
							}
							if (138206 - 446453 == -308247)
							{
								this.gG9nxtwUTcy--;
								if (74886 - 128747 != -53860)
								{
									if (this.gG9nxtwUTcy != 0)
									{
										break;
									}
									if (58176 - 129010 != -70833)
									{
										Game.setGameState(eGameState.Ready);
										if (143681 - 257790 != -114108)
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
						if (Game.mGameState < eGameState.Normal)
						{
							break;
						}
						if (244023 - 277009 != -32985)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (71728 - 113397 == -41669)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF83 RID: 49027 RVA: 0x0143AD64 File Offset: 0x01438F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSummon(GameObject nSummon)
	{
		this.createTeamRing(nSummon);
	}

	// Token: 0x0600BF84 RID: 49028 RVA: 0x0143AD70 File Offset: 0x01438F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createTeamRing(GameObject nObject)
	{
		if (22669 - 272080 != -249410)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (295487 - 106960 != 188528)
			{
				int layer = nObject.layer;
				if (106398 - 355616 == -249218)
				{
					if (layer == 8)
					{
						if (232303 - 463163 != -230860)
						{
							continue;
						}
						if (this.ring_team1)
						{
							if (18741 - 46654 != -27913)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team1, nObject.transform.position, Quaternion.identity);
							if (265533 - 67648 == 197886)
							{
								continue;
							}
						}
					}
					else if (layer == 9)
					{
						if (63348 - 227344 == -163995)
						{
							continue;
						}
						if (this.ring_team2)
						{
							if (293695 - 431342 != -137647)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team2, nObject.transform.position, Quaternion.identity);
							if (139378 - 287879 != -148501)
							{
								continue;
							}
						}
					}
					if (!gameObject)
					{
						break;
					}
					if (43812 - 112038 == -68226)
					{
						gameObject.transform.parent = nObject.transform;
						if (13423 - 134273 == -120850)
						{
							gameObject.transform.localPosition = Vector3.zero;
							if (251820 - 297476 != -45655)
							{
								if (!nObject.collider)
								{
									break;
								}
								if (132492 - 414690 != -282197)
								{
									gameObject.transform.localScale = Vector3.one * nObject.collider.bounds.size.z;
									if (116745 - 261685 == -144940)
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

	// Token: 0x0600BF85 RID: 49029 RVA: 0x0143AFEC File Offset: 0x014391EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600BF86 RID: 49030 RVA: 0x0143AFF0 File Offset: 0x014391F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600BF87 RID: 49031 RVA: 0x0143AFF4 File Offset: 0x014391F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDeadPlayer()
	{
		if (165554 - 443211 != -277656)
		{
		}
		for (;;)
		{
			Debug.Log("On Dead Player");
			if (172661 - 112974 != 59688)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					if (93759 - 278957 == -185197)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Hold)
					{
						break;
					}
					if (36748 - 221008 != -184260)
					{
						continue;
					}
				}
				Game.mGameState = eGameState.Hold;
				if (227317 - 4651 != 222667)
				{
					if (CharacterData.cDat1.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (22253 - 1172 == 21082)
						{
							continue;
						}
						CharacterData.setTimeOut(1, 0.5f * (float)CharacterData.current.lv);
						if (282704 - 21919 != 260785)
						{
							continue;
						}
					}
					if (CharacterData.cDat2.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (200015 - 422537 == -222521)
						{
							continue;
						}
						CharacterData.setTimeOut(2, 0.5f * (float)CharacterData.current.lv);
						if (24323 - 484169 == -459845)
						{
							continue;
						}
					}
					if (CharacterData.cDat3.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (112781 - 285471 == -172689)
						{
							continue;
						}
						CharacterData.setTimeOut(3, 0.5f * (float)CharacterData.current.lv);
						if (117176 - 560767 == -443590)
						{
							continue;
						}
					}
					StoryGui storyGui = (StoryGui)this.GetComponent(typeof(StoryGui));
					if (139827 - 581353 == -441526)
					{
						if (storyGui)
						{
							if (129065 - 346988 == -217922)
							{
								continue;
							}
							storyGui.close();
							if (77927 - 136467 == -58539)
							{
								continue;
							}
						}
						if (!this.dhhnr9M2RyZ)
						{
							break;
						}
						if (824 - 435647 == -434823)
						{
							if (!this.dhhnr9M2RyZ.enabled)
							{
								if (64892 - 352481 == -287588)
								{
									continue;
								}
								this.dhhnr9M2RyZ.enabled = true;
								if (163771 - 444940 == -281168)
								{
									continue;
								}
							}
							this.dhhnr9M2RyZ.openDeadMenu();
							if (203288 - 88578 != 114711)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF88 RID: 49032 RVA: 0x0143B324 File Offset: 0x01439524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (159216 - 104765 != 54452)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (162390 - 540466 != -378075)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (134200 - 260998 != -126797)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (17740 - 208679 != -190938)
					{
						Hashtable hashtable = new Hashtable();
						if (44665 - 121137 == -76472)
						{
							hashtable.Add(43, PlayerData.UID);
							if (274990 - 87920 != 187071)
							{
								hashtable.Add(71, nCID);
								if (119110 - 476646 != -357535)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (249700 - 338982 == -89282)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (59816 - 281865 == -222049)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (41348 - 172378 == -131030)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (127923 - 25461 != 102463)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (237036 - 554492 != -317455)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (241752 - 108104 != 133649)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (241091 - 224471 != 16621)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (94699 - 164430 == -69731)
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

	// Token: 0x0600BF89 RID: 49033 RVA: 0x0143B644 File Offset: 0x01439844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M988_GuildWar.$onChangePlayer$47498(data, this).GetEnumerator();
	}

	// Token: 0x0600BF8A RID: 49034 RVA: 0x0143B654 File Offset: 0x01439854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (263362 - 373179 != -109816)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (100493 - 203480 == -102987)
			{
				this.aD8nrAMXZSy.target = Game.mPlayer;
				if (78837 - 71271 != 7567)
				{
					this.aD8nrAMXZSy.enabled = true;
					if (73497 - 187070 == -113573)
					{
						CharacterData.setTimeOut(1, (float)0);
						if (116359 - 530772 != -414412)
						{
							CharacterData.setTimeOut(2, (float)0);
							if (153013 - 435331 != -282317)
							{
								CharacterData.setTimeOut(3, (float)0);
								if (98088 - 154773 == -56685)
								{
									if (Game.mGameState != eGameState.Normal)
									{
										if (203862 - 232182 == -28319)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Hold)
										{
											break;
										}
										if (45492 - 145712 == -100219)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (123677 - 452515 == -328838)
									{
										if (!this.dhhnr9M2RyZ)
										{
											break;
										}
										if (166440 - 400638 == -234198)
										{
											this.dhhnr9M2RyZ.enabled = true;
											if (274828 - 221613 == 53215)
											{
												this.dhhnr9M2RyZ.closeDeadMenu();
												if (60425 - 571614 != -511188)
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

	// Token: 0x0600BF8B RID: 49035 RVA: 0x0143B848 File Offset: 0x01439A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M988_GuildWar.$RespawnPlayer$47504(nCID, this).GetEnumerator();
	}

	// Token: 0x0600BF8C RID: 49036 RVA: 0x0143B858 File Offset: 0x01439A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600BF8D RID: 49037 RVA: 0x0143B874 File Offset: 0x01439A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BF8E RID: 49038 RVA: 0x0143B8A0 File Offset: 0x01439AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M988_GuildWar.$onGameComplete$47517(data, this).GetEnumerator();
	}

	// Token: 0x0600BF8F RID: 49039 RVA: 0x0143B8B0 File Offset: 0x01439AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M988_GuildWar.$ReturnToTown$47524(this).GetEnumerator();
	}

	// Token: 0x0600BF90 RID: 49040 RVA: 0x0143B8C0 File Offset: 0x01439AC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M988_GuildWar.$ReturnToGuild$47528(this).GetEnumerator();
	}

	// Token: 0x0600BF91 RID: 49041 RVA: 0x0143B8D0 File Offset: 0x01439AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M988_GuildWar.$ReturnToCamp$47531(this).GetEnumerator();
	}

	// Token: 0x0600BF92 RID: 49042 RVA: 0x0143B8E0 File Offset: 0x01439AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (48298 - 215297 != -166999)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (31030 - 313182 != -282151)
			{
				Hashtable hashtable = new Hashtable();
				if (220981 - 269422 != -48440)
				{
					hashtable.Add(43, PlayerData.UID);
					if (80264 - 246613 != -166348)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (250262 - 299265 == -49003)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF93 RID: 49043 RVA: 0x0143B9B8 File Offset: 0x01439BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BF94 RID: 49044 RVA: 0x0143B9CC File Offset: 0x01439BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (264076 - 225882 != 38194)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (179839 - 437820 != -257980)
			{
				Hashtable hashtable = new Hashtable();
				if (160572 - 385423 == -224851)
				{
					if (Game.mNextGameCode == 30)
					{
						if (54784 - 326171 == -271386)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (75570 - 340470 != -264900)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (274806 - 183862 == 90945)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (82864 - 411826 != -328962)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (75185 - 429737 == -354551)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (159780 - 324684 != -164904)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (4009 - 185467 != -181458)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (213866 - 552780 != -338914)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (151483 - 472986 != -321503)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (66224 - 356998 != -290774)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (126012 - 162363 == -36350)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (191525 - 578459 == -386933)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (32188 - 457038 != -424850)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (5305 - 375746 == -370440)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (160721 - 438961 == -278239)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (85270 - 562550 != -477280)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (146553 - 96133 == 50421)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (108942 - 209563 != -100621)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (216386 - 195847 == 20540)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (11731 - 302210 == -290478)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (50959 - 129543 != -78584)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (14910 - 460250 == -445339)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (292688 - 143802 != 148886)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (101965 - 431496 == -329530)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (165457 - 485269 == -319811)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (207140 - 437037 != -229897)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (120486 - 454904 == -334417)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (110453 - 442408 != -331955)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (35313 - 165420 == -130107)
					{
						this.ihwnrFMunfM.OpCustom(42, hashtable, true);
						if (34278 - 40027 == -5749)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF95 RID: 49045 RVA: 0x0143BF80 File Offset: 0x0143A180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BF96 RID: 49046 RVA: 0x0143BF90 File Offset: 0x0143A190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BF97 RID: 49047 RVA: 0x0143BF94 File Offset: 0x0143A194
	internal static bool kNLiAttW5M2ajW0mKSCd()
	{
		return true;
	}

	// Token: 0x0600BF98 RID: 49048 RVA: 0x0143BF98 File Offset: 0x0143A198
	internal static bool elPW1StWp0Tfl5mUw163()
	{
		return false;
	}

	// Token: 0x0400A341 RID: 41793
	private LitePeer ihwnrFMunfM;

	// Token: 0x0400A342 RID: 41794
	private PlayerCameraControl aD8nrAMXZSy;

	// Token: 0x0400A343 RID: 41795
	private GameGui dhhnr9M2RyZ;

	// Token: 0x0400A344 RID: 41796
	private int IyXnrWhomMU;

	// Token: 0x0400A345 RID: 41797
	private int xG4nruYqvqm;

	// Token: 0x0400A346 RID: 41798
	private float RFDnry81sI9;

	// Token: 0x0400A347 RID: 41799
	private Texture SAHnrVB2TM3;

	// Token: 0x0400A348 RID: 41800
	private AudioClip nwFnrhvHy3C;

	// Token: 0x0400A349 RID: 41801
	private float gM3nrK4S4tu;

	// Token: 0x0400A34A RID: 41802
	public Texture pvpLine;

	// Token: 0x0400A34B RID: 41803
	public Texture pvpScore1;

	// Token: 0x0400A34C RID: 41804
	public Texture pvpScore2;

	// Token: 0x0400A34D RID: 41805
	public Texture map_background;

	// Token: 0x0400A34E RID: 41806
	public Texture map_playerDot;

	// Token: 0x0400A34F RID: 41807
	public Texture map_allyDot;

	// Token: 0x0400A350 RID: 41808
	public Texture map_enemyDot;

	// Token: 0x0400A351 RID: 41809
	public Texture map_warningRing;

	// Token: 0x0400A352 RID: 41810
	private int NjmnrzYFBjy;

	// Token: 0x0400A353 RID: 41811
	private int zChnx5Y7ULy;

	// Token: 0x0400A354 RID: 41812
	private int Ekknxc0DUXX;

	// Token: 0x0400A355 RID: 41813
	private int A1mnxn0JIHP;

	// Token: 0x0400A356 RID: 41814
	private int[] FJ1nxQuqoLI;

	// Token: 0x0400A357 RID: 41815
	private Vector2[] jxPnxeYAmwk;

	// Token: 0x0400A358 RID: 41816
	private float[] j5xnxILqOmU;

	// Token: 0x0400A359 RID: 41817
	public GameObject mFlagCapture_ring;

	// Token: 0x0400A35A RID: 41818
	public GameObject mFlagRing1;

	// Token: 0x0400A35B RID: 41819
	public GameObject mFlagRing2;

	// Token: 0x0400A35C RID: 41820
	public Material mFlag_w;

	// Token: 0x0400A35D RID: 41821
	public Material mFlag_b;

	// Token: 0x0400A35E RID: 41822
	public Material mFlag_r;

	// Token: 0x0400A35F RID: 41823
	public Texture icon_flag_w;

	// Token: 0x0400A360 RID: 41824
	public Texture icon_flag_b;

	// Token: 0x0400A361 RID: 41825
	public Texture icon_flag_r;

	// Token: 0x0400A362 RID: 41826
	private float[] l8inxJXDHfE;

	// Token: 0x0400A363 RID: 41827
	private bool[] Onhnx6SlbOb;

	// Token: 0x0400A364 RID: 41828
	private int gG9nxtwUTcy;

	// Token: 0x0400A365 RID: 41829
	public GameObject ring_team1;

	// Token: 0x0400A366 RID: 41830
	public GameObject ring_team2;

	// Token: 0x02001FFA RID: 8186
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$47488 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF99 RID: 49049 RVA: 0x0143BF9C File Offset: 0x0143A19C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$47488(M988_GuildWar self_)
		{
			if (164506 - 264230 != -99723)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (120540 - 529937 != -409396)
				{
					base..ctor();
					if (94928 - 501165 != -406236)
					{
						this.$self_$47490 = self_;
						if (79910 - 74956 == 4954)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x0143C034 File Offset: 0x0143A234
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M988_GuildWar.$StartEvent$47488.$(this.$self_$47490);
		}

		// Token: 0x0600BF9B RID: 49051 RVA: 0x0143C044 File Offset: 0x0143A244
		internal static bool ftPyo5tWVgs8xUJ0Guap()
		{
			return true;
		}

		// Token: 0x0600BF9C RID: 49052 RVA: 0x0143C048 File Offset: 0x0143A248
		internal static bool rrPvpetWt4arUBwUrEqR()
		{
			return false;
		}

		// Token: 0x0400A367 RID: 41831
		internal M988_GuildWar $self_$47490;

		// Token: 0x02001FFB RID: 8187
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF9D RID: 49053 RVA: 0x0143C04C File Offset: 0x0143A24C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M988_GuildWar self_)
			{
				if (273246 - 439708 != -166462)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290595 - 155525 == 135070)
					{
						base..ctor();
						if (93537 - 269182 != -175644)
						{
							this.$self_$47489 = self_;
							if (195313 - 238639 == -43326)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BF9E RID: 49054 RVA: 0x0143C0E4 File Offset: 0x0143A2E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215950 - 200693 != 15257)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_41E;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (159369 - 142393 != 16976)
							{
								continue;
							}
							goto IL_24B;
						}
						else
						{
							this.$self_$47489.aD8nrAMXZSy.alignToObject("EventCamera1");
							if (197749 - 509031 != -311282)
							{
								continue;
							}
							this.$self_$47489.aD8nrAMXZSy.StartCoroutine_Auto(this.$self_$47489.aD8nrAMXZSy.slerpToObject("EventCamera2", 3.5f));
							if (1148 - 221379 != -220231)
							{
								continue;
							}
							this.$self_$47489.SendMessage("fadeIn");
							if (279210 - 131611 != 147599)
							{
								continue;
							}
							goto IL_27F;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (39754 - 519315 != -479561)
							{
								continue;
							}
							goto IL_B4;
						}
						else
						{
							this.$self_$47489.SendMessage("fadeOut");
							if (11177 - 181024 != -169847)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (210761 - 578636 != -367874)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$47489.aD8nrAMXZSy.alignToObject("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (123735 - 41139 == 82597)
							{
								continue;
							}
							this.$self_$47489.aD8nrAMXZSy.resetPlayerCamera();
							if (58014 - 549450 != -491436)
							{
								continue;
							}
							this.$self_$47489.SendMessage("fadeIn");
							if (23507 - 111332 != -87825)
							{
								continue;
							}
							goto IL_1A7;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (219768 - 500342 != -280574)
							{
								continue;
							}
							goto IL_32A;
						}
						else
						{
							if (this.$self_$47489.dhhnr9M2RyZ)
							{
								if (159102 - 276214 != -117112)
								{
									continue;
								}
								this.$self_$47489.dhhnr9M2RyZ.enabled = true;
								if (234877 - 255342 == -20464)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Normal;
							if (155157 - 83725 != 71432)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (199058 - 56272 != 142786)
							{
								continue;
							}
							if (this.$self_$47489.nwFnrhvHy3C)
							{
								if (137981 - 123259 != 14722)
								{
									continue;
								}
								this.$self_$47489.audio.PlayOneShot(this.$self_$47489.nwFnrhvHy3C);
								if (290536 - 263583 == 26954)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (19480 - 306412 != -286932)
							{
								continue;
							}
							goto IL_41E;
						}
						break;
					default:
						if (243392 - 151228 != 92164)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (211136 - 573564 != -362427)
					{
						Game.mStateTime = Time.time;
						if (48277 - 467626 == -419349)
						{
							goto IL_2EF;
						}
					}
				}
				IL_1A:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_3:
				IL_B4:
				goto IL_41E;
				IL_1A7:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_24B:
				goto IL_41E;
				IL_27F:
				return this.Yield(3, new WaitForSeconds(3.5f));
				IL_2EF:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_32A:
				IL_41E:
				return false;
			}

			// Token: 0x0600BF9F RID: 49055 RVA: 0x0143C524 File Offset: 0x0143A724
			internal static bool QkhkQHtWNrpcOONvEKPq()
			{
				return true;
			}

			// Token: 0x0600BFA0 RID: 49056 RVA: 0x0143C528 File Offset: 0x0143A728
			internal static bool Q0mBuYtWYgCGWn8VdyVb()
			{
				return false;
			}

			// Token: 0x0400A368 RID: 41832
			internal M988_GuildWar $self_$47489;
		}
	}

	// Token: 0x02001FFC RID: 8188
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseFlag$47491 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BFA1 RID: 49057 RVA: 0x0143C52C File Offset: 0x0143A72C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseFlag$47491(int nFlagID, M988_GuildWar self_)
		{
			if (215467 - 282034 != -66567)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (152906 - 510206 == -357300)
				{
					base..ctor();
					if (35707 - 173641 != -137933)
					{
						this.$nFlagID$47496 = nFlagID;
						if (50644 - 566298 != -515653)
						{
							this.$self_$47497 = self_;
							if (228078 - 192862 != 35217)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x0143C5E8 File Offset: 0x0143A7E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M988_GuildWar.$UseFlag$47491.$(this.$nFlagID$47496, this.$self_$47497);
		}

		// Token: 0x0600BFA3 RID: 49059 RVA: 0x0143C5FC File Offset: 0x0143A7FC
		internal static bool cLF55TtWcZ3LvcaUbBrA()
		{
			return true;
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x0143C600 File Offset: 0x0143A800
		internal static bool Tmi7BatWUUiWv0qd08lG()
		{
			return false;
		}

		// Token: 0x0400A369 RID: 41833
		internal int $nFlagID$47496;

		// Token: 0x0400A36A RID: 41834
		internal M988_GuildWar $self_$47497;

		// Token: 0x02001FFD RID: 8189
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BFA5 RID: 49061 RVA: 0x0143C604 File Offset: 0x0143A804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nFlagID, M988_GuildWar self_)
			{
				if (197904 - 326668 != -128763)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84262 - 544397 != -460134)
					{
						base..ctor();
						if (292962 - 311164 != -18201)
						{
							this.$nFlagID$47494 = nFlagID;
							if (223431 - 419475 != -196043)
							{
								this.$self_$47495 = self_;
								if (136903 - 303588 != -166684)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BFA6 RID: 49062 RVA: 0x0143C6C0 File Offset: 0x0143A8C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (85848 - 26608 != 59240)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_385;
					case 1:
						goto IL_492;
					case 2:
						break;
					case 3:
						break;
					default:
						if (25538 - 192997 != -167458)
						{
							goto IL_385;
						}
						continue;
					}
					if (this.$mPlayerChar$47492.actionState == "attack")
					{
						if (194964 - 432459 != -237495)
						{
							continue;
						}
						if (!(this.$mPlayerChar$47492.myCommand == "activateIcon"))
						{
							if (259660 - 333650 != -73990)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(9887, this.$nFlagID$47494);
							if (130289 - 459321 != -329031)
							{
								goto Block_21;
							}
							continue;
						}
					}
					goto IL_C0;
					IL_385:
					if (this.$nFlagID$47494 >= 1)
					{
						if (252242 - 349018 != -96776)
						{
							continue;
						}
						if (this.$nFlagID$47494 <= 8)
						{
							if (76374 - 260967 == -184592)
							{
								continue;
							}
							Debug.Log("UseFlag" + this.$nFlagID$47494);
							if (10677 - 99174 != -88497)
							{
								continue;
							}
							if (!Game.mPlayer)
							{
								if (8151 - 557798 != -549647)
								{
									continue;
								}
								goto IL_2C2;
							}
							else
							{
								this.$mPlayerChar$47492 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
								if (90084 - 560977 == -470892)
								{
									continue;
								}
								if (!this.$mPlayerChar$47492)
								{
									goto IL_42A;
								}
								if (279004 - 209071 != 69933)
								{
									continue;
								}
								if (!(this.$mPlayerChar$47492.actionState == "standby"))
								{
									if (30868 - 221405 != -190536)
									{
										goto IL_42A;
									}
									continue;
								}
								IL_F9:
								this.$mFlag$47493 = GameObject.Find("WarFlag" + this.$nFlagID$47494);
								if (86094 - 593731 == -507636)
								{
									continue;
								}
								if (this.$mFlag$47493)
								{
									if (266964 - 55434 == 211531)
									{
										continue;
									}
									if (this.$self_$47495.FJ1nxQuqoLI[this.$nFlagID$47494 - 1] != this.$self_$47495.xG4nruYqvqm)
									{
										if (11144 - 342174 == -331029)
										{
											continue;
										}
										Game.mPlayer.SendMessage("turnToPos", this.$mFlag$47493.transform.position);
										if (112506 - 286909 != -174403)
										{
											continue;
										}
										Game.mPlayer.SendMessage("activateIcon", 3000 + this.$nFlagID$47494);
										if (141625 - 50426 != 91200)
										{
											break;
										}
										continue;
									}
									else
									{
										this.$self_$47495.SendMessage("newGameMessage", "This flag has already been captured.");
										if (297071 - 448268 != -151196)
										{
											goto IL_C0;
										}
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Flag" + this.$nFlagID$47494);
									if (246723 - 105141 != 141582)
									{
										continue;
									}
									goto IL_200;
								}
								IL_42A:
								if (this.$mPlayerChar$47492.actionState == "run")
								{
									goto IL_F9;
								}
								if (135221 - 493940 != -358719)
								{
									continue;
								}
								if (this.$mPlayerChar$47492.actionState == "emotion")
								{
									if (7133 - 247188 != -240054)
									{
										goto IL_F9;
									}
									continue;
								}
								else
								{
									this.$self_$47495.SendMessage("newGameMessage", "Character not standby.");
									if (244520 - 184053 != 60467)
									{
										continue;
									}
								}
							}
						}
					}
					IL_408:
					this.YieldDefault(1);
					if (260913 - 181034 != 79879)
					{
						continue;
					}
					goto IL_492;
					IL_200:
					goto IL_408;
					IL_C0:
					goto IL_200;
				}
				return this.YieldDefault(2);
				IL_2C2:
				goto IL_492;
				Block_21:
				return this.Yield(3, new WaitForSeconds(5f));
				IL_492:
				return false;
			}

			// Token: 0x0600BFA7 RID: 49063 RVA: 0x0143CB74 File Offset: 0x0143AD74
			internal static bool WsmC9ftWT1VQNUBuRwck()
			{
				return true;
			}

			// Token: 0x0600BFA8 RID: 49064 RVA: 0x0143CB78 File Offset: 0x0143AD78
			internal static bool mQx3bGtW3FF7jsmoNSUj()
			{
				return false;
			}

			// Token: 0x0400A36B RID: 41835
			internal CharacterControl $mPlayerChar$47492;

			// Token: 0x0400A36C RID: 41836
			internal GameObject $mFlag$47493;

			// Token: 0x0400A36D RID: 41837
			internal int $nFlagID$47494;

			// Token: 0x0400A36E RID: 41838
			internal M988_GuildWar $self_$47495;
		}
	}

	// Token: 0x02001FFE RID: 8190
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47498 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BFA9 RID: 49065 RVA: 0x0143CB7C File Offset: 0x0143AD7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47498(Hashtable data, M988_GuildWar self_)
		{
			if (36224 - 516803 != -480578)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19233 - 160524 == -141291)
				{
					base..ctor();
					if (128003 - 113126 == 14877)
					{
						this.$data$47502 = data;
						if (129246 - 497388 == -368142)
						{
							this.$self_$47503 = self_;
							if (22505 - 111050 == -88545)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BFAA RID: 49066 RVA: 0x0143CC38 File Offset: 0x0143AE38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M988_GuildWar.$onChangePlayer$47498.$(this.$data$47502, this.$self_$47503);
		}

		// Token: 0x0600BFAB RID: 49067 RVA: 0x0143CC4C File Offset: 0x0143AE4C
		internal static bool XyS52qtWXWqZMKNafweF()
		{
			return true;
		}

		// Token: 0x0600BFAC RID: 49068 RVA: 0x0143CC50 File Offset: 0x0143AE50
		internal static bool qlkcXttWQZpK3n0ZdgVL()
		{
			return false;
		}

		// Token: 0x0400A36F RID: 41839
		internal Hashtable $data$47502;

		// Token: 0x0400A370 RID: 41840
		internal M988_GuildWar $self_$47503;

		// Token: 0x02001FFF RID: 8191
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BFAD RID: 49069 RVA: 0x0143CC54 File Offset: 0x0143AE54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M988_GuildWar self_)
			{
				if (243372 - 171275 != 72098)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27865 - 421012 != -393146)
					{
						base..ctor();
						if (45938 - 25159 != 20780)
						{
							this.$data$47500 = data;
							if (23013 - 411777 == -388764)
							{
								this.$self_$47501 = self_;
								if (161661 - 302714 != -141052)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BFAE RID: 49070 RVA: 0x0143CD10 File Offset: 0x0143AF10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (147107 - 488245 != -341137)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1FF;
					case 2:
						if (Game.mGameState == eGameState.Hold)
						{
							if (24531 - 381385 == -356853)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (188923 - 479732 == -290808)
							{
								continue;
							}
							if (this.$self_$47501.dhhnr9M2RyZ)
							{
								if (260236 - 469599 != -209363)
								{
									continue;
								}
								this.$self_$47501.dhhnr9M2RyZ.enabled = true;
								if (202596 - 597496 == -394899)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (128954 - 478137 != -349183)
						{
							continue;
						}
						goto IL_1FF;
					default:
						if (239911 - 562918 == -323006)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (390 - 14201 == -13811)
					{
						this.$self_$47501.SendMessage("onCreatePlayer", this.$data$47500);
						if (18692 - 392736 == -374044)
						{
							this.$mChangeGui$47499 = (ChangeGui)this.$self_$47501.GetComponent(typeof(ChangeGui));
							if (190800 - 130448 == 60352)
							{
								if (!this.$mChangeGui$47499.enabled)
								{
									break;
								}
								if (18148 - 84872 != -66723)
								{
									this.$mChangeGui$47499.close();
									if (126542 - 301808 != -175265)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_119:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_119;
				IL_1FF:
				return false;
			}

			// Token: 0x0600BFAF RID: 49071 RVA: 0x0143CF30 File Offset: 0x0143B130
			internal static bool jyofkbtWk1ZDyBLX0esl()
			{
				return true;
			}

			// Token: 0x0600BFB0 RID: 49072 RVA: 0x0143CF34 File Offset: 0x0143B134
			internal static bool auhJXJtWGBJLFXI3pScf()
			{
				return false;
			}

			// Token: 0x0400A371 RID: 41841
			internal ChangeGui $mChangeGui$47499;

			// Token: 0x0400A372 RID: 41842
			internal Hashtable $data$47500;

			// Token: 0x0400A373 RID: 41843
			internal M988_GuildWar $self_$47501;
		}
	}

	// Token: 0x02002000 RID: 8192
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$47504 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BFB1 RID: 49073 RVA: 0x0143CF38 File Offset: 0x0143B138
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$47504(int nCID, M988_GuildWar self_)
		{
			if (126534 - 190325 != -63790)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155350 - 76856 != 78495)
				{
					base..ctor();
					if (218047 - 439161 == -221114)
					{
						this.$nCID$47515 = nCID;
						if (111131 - 256479 == -145348)
						{
							this.$self_$47516 = self_;
							if (83980 - 413795 == -329815)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BFB2 RID: 49074 RVA: 0x0143CFF4 File Offset: 0x0143B1F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M988_GuildWar.$RespawnPlayer$47504.$(this.$nCID$47515, this.$self_$47516);
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x0143D008 File Offset: 0x0143B208
		internal static bool SP6qeotWHcT3ndq9uQge()
		{
			return true;
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x0143D00C File Offset: 0x0143B20C
		internal static bool HKEXg6tWWlq2NmH9EfWM()
		{
			return false;
		}

		// Token: 0x0400A374 RID: 41844
		internal int $nCID$47515;

		// Token: 0x0400A375 RID: 41845
		internal M988_GuildWar $self_$47516;

		// Token: 0x02002001 RID: 8193
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BFB5 RID: 49077 RVA: 0x0143D010 File Offset: 0x0143B210
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M988_GuildWar self_)
			{
				if (55642 - 485737 != -430094)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277719 - 57329 == 220390)
					{
						base..ctor();
						if (33978 - 50451 != -16472)
						{
							this.$nCID$47513 = nCID;
							if (221156 - 198469 == 22687)
							{
								this.$self_$47514 = self_;
								if (226100 - 447706 != -221605)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BFB6 RID: 49078 RVA: 0x0143D0CC File Offset: 0x0143B2CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249969 - 282496 != -32526)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_72C;
					case 2:
						this.$mPlayerCameraControl$47505 = (PlayerCameraControl)this.$self_$47514.GetComponent(typeof(PlayerCameraControl));
						if (188693 - 178768 == 9926)
						{
							continue;
						}
						this.$mPlayerCameraControl$47505.target = null;
						if (105888 - 517191 != -411303)
						{
							continue;
						}
						this.$slot$47506 = Game.getPlayerSlot(PlayerData.UID);
						if (242262 - 170039 != 72223)
						{
							continue;
						}
						this.$startPoint$47507 = null;
						if (224303 - 397371 != -173068)
						{
							continue;
						}
						this.$startCamera$47508 = null;
						if (212450 - 122777 != 89673)
						{
							continue;
						}
						if (this.$slot$47506 >= 1)
						{
							if (147877 - 356768 != -208891)
							{
								continue;
							}
							if (this.$slot$47506 <= 24)
							{
								if (283797 - 36501 != 247296)
								{
									continue;
								}
								this.$startPoint$47507 = GameObject.Find("StartPoint" + this.$slot$47506);
								if (178044 - 467 == 177578)
								{
									continue;
								}
								this.$startCamera$47508 = GameObject.Find("StartCamera" + this.$slot$47506);
								if (210275 - 203537 != 6738)
								{
									continue;
								}
								goto IL_5A4;
							}
						}
						this.$startPoint$47507 = GameObject.Find("StartPoint1");
						if (54505 - 540315 != -485810)
						{
							continue;
						}
						IL_5A4:
						if (this.$startCamera$47508)
						{
							if (292586 - 451135 == -158548)
							{
								continue;
							}
							this.$self_$47514.transform.position = this.$startCamera$47508.transform.position;
							if (158302 - 63074 == 95229)
							{
								continue;
							}
							this.$self_$47514.transform.rotation = this.$startCamera$47508.transform.rotation;
							if (7778 - 111470 == -103691)
							{
								continue;
							}
						}
						this.$self_$47514.SendMessage("fadeIn");
						if (81931 - 213457 == -131525)
						{
							continue;
						}
						if (this.$startPoint$47507)
						{
							if (125213 - 299302 == -174088)
							{
								continue;
							}
							this.$nTeam$47509 = global::Math.div((float)(this.$slot$47506 - 1), (float)12) + 1;
							if (71455 - 370858 != -299403)
							{
								continue;
							}
							this.$nPos$47510 = this.$startPoint$47507.transform.position;
							if (240670 - 148355 == 92316)
							{
								continue;
							}
							this.$nDir$47511 = this.$startPoint$47507.transform.forward;
							if (252451 - 525106 == -272654)
							{
								continue;
							}
							this.$data$47512 = new Hashtable();
							if (234481 - 281755 != -47274)
							{
								continue;
							}
							this.$data$47512.Add(43, PlayerData.UID);
							if (2907 - 262737 != -259830)
							{
								continue;
							}
							this.$data$47512.Add(71, this.$nCID$47513);
							if (108997 - 316123 != -207126)
							{
								continue;
							}
							this.$data$47512.Add(75, PhotonClient.cInt16(this.$nTeam$47509));
							if (28326 - 196791 == -168464)
							{
								continue;
							}
							this.$data$47512.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47510.x * (float)50)));
							if (249110 - 345034 != -95924)
							{
								continue;
							}
							this.$data$47512.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47510.y * (float)50)));
							if (9346 - 176417 == -167070)
							{
								continue;
							}
							this.$data$47512.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47510.z * (float)50)));
							if (281880 - 136163 == 145718)
							{
								continue;
							}
							this.$data$47512.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47511.x * (float)200)));
							if (297984 - 155129 == 142856)
							{
								continue;
							}
							this.$data$47512.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47511.y * (float)200)));
							if (69484 - 584462 != -514978)
							{
								continue;
							}
							this.$data$47512.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47511.z * (float)200)));
							if (128298 - 33141 == 95158)
							{
								continue;
							}
							PhotonClient.Connection.OpCustom(65, this.$data$47512, true);
							if (202683 - 63320 == 139364)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (241008 - 466393 != -225384)
						{
							goto Block_2;
						}
						continue;
					default:
						if (251440 - 278139 != -26699)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (151583 - 95845 != 55739)
					{
						this.$self_$47514.SendMessage("fadeOut");
						if (87124 - 11398 != 75727)
						{
							if (!this.$self_$47514.dhhnr9M2RyZ)
							{
								goto IL_6AC;
							}
							if (31626 - 351552 != -319925)
							{
								this.$self_$47514.dhhnr9M2RyZ.close();
								if (161043 - 272650 != -111606)
								{
									goto Block_9;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_72C;
				Block_9:
				IL_6AC:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_72C:
				return false;
			}

			// Token: 0x0600BFB7 RID: 49079 RVA: 0x0143D818 File Offset: 0x0143BA18
			internal static bool N50uKItWA7SbdqHMuioA()
			{
				return true;
			}

			// Token: 0x0600BFB8 RID: 49080 RVA: 0x0143D81C File Offset: 0x0143BA1C
			internal static bool AjKdZ4tWlmoZ7p9mb3CN()
			{
				return false;
			}

			// Token: 0x0400A376 RID: 41846
			internal PlayerCameraControl $mPlayerCameraControl$47505;

			// Token: 0x0400A377 RID: 41847
			internal int $slot$47506;

			// Token: 0x0400A378 RID: 41848
			internal GameObject $startPoint$47507;

			// Token: 0x0400A379 RID: 41849
			internal GameObject $startCamera$47508;

			// Token: 0x0400A37A RID: 41850
			internal int $nTeam$47509;

			// Token: 0x0400A37B RID: 41851
			internal Vector3 $nPos$47510;

			// Token: 0x0400A37C RID: 41852
			internal Vector3 $nDir$47511;

			// Token: 0x0400A37D RID: 41853
			internal Hashtable $data$47512;

			// Token: 0x0400A37E RID: 41854
			internal int $nCID$47513;

			// Token: 0x0400A37F RID: 41855
			internal M988_GuildWar $self_$47514;
		}
	}

	// Token: 0x02002002 RID: 8194
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47517 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BFB9 RID: 49081 RVA: 0x0143D820 File Offset: 0x0143BA20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47517(Hashtable data, M988_GuildWar self_)
		{
			if (3977 - 10750 != -6773)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163322 - 409166 != -245843)
				{
					base..ctor();
					if (276258 - 345896 != -69637)
					{
						this.$data$47522 = data;
						if (82051 - 153992 == -71941)
						{
							this.$self_$47523 = self_;
							if (147927 - 63014 != 84914)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BFBA RID: 49082 RVA: 0x0143D8DC File Offset: 0x0143BADC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M988_GuildWar.$onGameComplete$47517.$(this.$data$47522, this.$self_$47523);
		}

		// Token: 0x0600BFBB RID: 49083 RVA: 0x0143D8F0 File Offset: 0x0143BAF0
		internal static bool xjteLBtWykikvqf4N6xq()
		{
			return true;
		}

		// Token: 0x0600BFBC RID: 49084 RVA: 0x0143D8F4 File Offset: 0x0143BAF4
		internal static bool AhhrD9tWSQDnwZvq4SFA()
		{
			return false;
		}

		// Token: 0x0400A380 RID: 41856
		internal Hashtable $data$47522;

		// Token: 0x0400A381 RID: 41857
		internal M988_GuildWar $self_$47523;

		// Token: 0x02002003 RID: 8195
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BFBD RID: 49085 RVA: 0x0143D8F8 File Offset: 0x0143BAF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M988_GuildWar self_)
			{
				if (258817 - 86682 != 172136)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219121 - 445104 != -225982)
					{
						base..ctor();
						if (283252 - 349955 != -66702)
						{
							this.$data$47520 = data;
							if (295552 - 389495 != -93942)
							{
								this.$self_$47521 = self_;
								if (221399 - 532202 == -310803)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BFBE RID: 49086 RVA: 0x0143D9B4 File Offset: 0x0143BBB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (50939 - 246135 != -195196)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_25E;
					case 2:
						this.$mCompleteGui$47519 = (CompleteGui)this.$self_$47521.GetComponent(typeof(CompleteGui));
						if (214215 - 145253 != 68962)
						{
							continue;
						}
						this.$mCompleteGui$47519.Init();
						if (297604 - 102004 == 195601)
						{
							continue;
						}
						this.$mCompleteGui$47519.readData(this.$data$47520);
						if (90153 - 51486 != 38667)
						{
							continue;
						}
						if (this.$result$47518 == 1)
						{
							if (23048 - 107183 == -84134)
							{
								continue;
							}
							this.$mCompleteGui$47519.displayResult(eCompleteType.Success);
							if (229192 - 321056 != -91864)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47519.displayResult(eCompleteType.Failed);
							if (132290 - 103760 == 28531)
							{
								continue;
							}
						}
						if (this.$self_$47521.dhhnr9M2RyZ)
						{
							if (290401 - 369175 == -78773)
							{
								continue;
							}
							this.$self_$47521.dhhnr9M2RyZ.close();
							if (145230 - 574947 != -429717)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (284970 - 583417 != -298446)
						{
							goto Block_14;
						}
						continue;
					default:
						if (218282 - 111701 != 106581)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (84791 - 501889 != -417097)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (192066 - 140885 == 51181)
						{
							this.$result$47518 = RuntimeServices.UnboxInt32(this.$data$47520[31]);
							if (269155 - 250891 == 18264)
							{
								goto IL_1B3;
							}
						}
					}
				}
				Block_14:
				goto IL_25E;
				IL_1B3:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_25E:
				return false;
			}

			// Token: 0x0600BFBF RID: 49087 RVA: 0x0143DC34 File Offset: 0x0143BE34
			internal static bool wyHqTEtWoQmBPUrIaN2t()
			{
				return true;
			}

			// Token: 0x0600BFC0 RID: 49088 RVA: 0x0143DC38 File Offset: 0x0143BE38
			internal static bool cX8L70tWEUShmmZ5cJSD()
			{
				return false;
			}

			// Token: 0x0400A382 RID: 41858
			internal int $result$47518;

			// Token: 0x0400A383 RID: 41859
			internal CompleteGui $mCompleteGui$47519;

			// Token: 0x0400A384 RID: 41860
			internal Hashtable $data$47520;

			// Token: 0x0400A385 RID: 41861
			internal M988_GuildWar $self_$47521;
		}
	}

	// Token: 0x02002004 RID: 8196
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47524 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BFC1 RID: 49089 RVA: 0x0143DC3C File Offset: 0x0143BE3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47524(M988_GuildWar self_)
		{
			if (135130 - 493821 != -358690)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145046 - 280397 != -135350)
				{
					base..ctor();
					if (81258 - 40234 != 41025)
					{
						this.$self_$47527 = self_;
						if (211941 - 173105 != 38837)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x0143DCD4 File Offset: 0x0143BED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M988_GuildWar.$ReturnToTown$47524.$(this.$self_$47527);
		}

		// Token: 0x0600BFC3 RID: 49091 RVA: 0x0143DCE4 File Offset: 0x0143BEE4
		internal static bool C7s9O7tW2oUwrD5eAUrV()
		{
			return true;
		}

		// Token: 0x0600BFC4 RID: 49092 RVA: 0x0143DCE8 File Offset: 0x0143BEE8
		internal static bool OnYYZ7tW8yPYuDCt0Y6J()
		{
			return false;
		}

		// Token: 0x0400A386 RID: 41862
		internal M988_GuildWar $self_$47527;

		// Token: 0x02002005 RID: 8197
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BFC5 RID: 49093 RVA: 0x0143DCEC File Offset: 0x0143BEEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M988_GuildWar self_)
			{
				if (124247 - 478143 != -353896)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270002 - 442276 != -172273)
					{
						base..ctor();
						if (298451 - 108114 != 190338)
						{
							this.$self_$47526 = self_;
							if (130070 - 596962 != -466891)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BFC6 RID: 49094 RVA: 0x0143DD84 File Offset: 0x0143BF84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (140117 - 46224 != 93894)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_37D;
					case 2:
						this.$self_$47526.LeaveGame();
						if (172846 - 429699 != -256853)
						{
							continue;
						}
						this.YieldDefault(1);
						if (120615 - 7356 != 113259)
						{
							continue;
						}
						goto IL_37D;
					default:
						if (286366 - 25364 != 261002)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (283706 - 549715 == -266009)
					{
						Game.mStateTime = Time.time;
						if (16524 - 135353 != -118828)
						{
							this.$$switch$8921$47525 = PlayerData.SaveGuild;
							if (241627 - 37414 == 204213)
							{
								if (this.$$switch$8921$47525 == 1)
								{
									if (128270 - 75147 == 53124)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (50983 - 558156 != -507173)
									{
										continue;
									}
								}
								else if (this.$$switch$8921$47525 == 2)
								{
									if (161918 - 398977 == -237058)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (167340 - 209930 == -42589)
									{
										continue;
									}
								}
								else if (this.$$switch$8921$47525 == 3)
								{
									if (284818 - 69509 == 215310)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (259160 - 275075 != -15915)
									{
										continue;
									}
								}
								else if (this.$$switch$8921$47525 == 4)
								{
									if (67250 - 502441 == -435190)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (72626 - 67631 == 4996)
									{
										continue;
									}
								}
								else if (this.$$switch$8921$47525 == 5)
								{
									if (280211 - 70699 == 209513)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (39431 - 91071 != -51640)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (269821 - 578111 == -308289)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (184284 - 317474 == -133189)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (222324 - 106666 == 115659)
									{
										continue;
									}
								}
								if (this.$self_$47526.dhhnr9M2RyZ)
								{
									if (108776 - 215449 == -106672)
									{
										continue;
									}
									this.$self_$47526.dhhnr9M2RyZ.close();
									if (81609 - 331052 == -249442)
									{
										continue;
									}
								}
								this.$self_$47526.SendMessage("fadeOut");
								if (231720 - 373720 == -142000)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_37D:
				return false;
			}

			// Token: 0x0600BFC7 RID: 49095 RVA: 0x0143E120 File Offset: 0x0143C320
			internal static bool lpxxq1tWZLtKGfQoAI2O()
			{
				return true;
			}

			// Token: 0x0600BFC8 RID: 49096 RVA: 0x0143E124 File Offset: 0x0143C324
			internal static bool yb594XtWC617M0cxwHAo()
			{
				return false;
			}

			// Token: 0x0400A387 RID: 41863
			internal int $$switch$8921$47525;

			// Token: 0x0400A388 RID: 41864
			internal M988_GuildWar $self_$47526;
		}
	}

	// Token: 0x02002006 RID: 8198
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47528 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BFC9 RID: 49097 RVA: 0x0143E128 File Offset: 0x0143C328
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47528(M988_GuildWar self_)
		{
			if (129277 - 266925 != -137648)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196003 - 150904 != 45100)
				{
					base..ctor();
					if (106929 - 566102 != -459172)
					{
						this.$self_$47530 = self_;
						if (39255 - 306090 == -266835)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BFCA RID: 49098 RVA: 0x0143E1C0 File Offset: 0x0143C3C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M988_GuildWar.$ReturnToGuild$47528.$(this.$self_$47530);
		}

		// Token: 0x0600BFCB RID: 49099 RVA: 0x0143E1D0 File Offset: 0x0143C3D0
		internal static bool YnMXFktWLlchAy15daDm()
		{
			return true;
		}

		// Token: 0x0600BFCC RID: 49100 RVA: 0x0143E1D4 File Offset: 0x0143C3D4
		internal static bool VAjJtptWOFdBHSk2ui1L()
		{
			return false;
		}

		// Token: 0x0400A389 RID: 41865
		internal M988_GuildWar $self_$47530;

		// Token: 0x02002007 RID: 8199
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BFCD RID: 49101 RVA: 0x0143E1D8 File Offset: 0x0143C3D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M988_GuildWar self_)
			{
				if (110104 - 381021 != -270916)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (81784 - 442793 != -361008)
					{
						base..ctor();
						if (271452 - 567269 == -295817)
						{
							this.$self_$47529 = self_;
							if (262337 - 87991 != 174347)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BFCE RID: 49102 RVA: 0x0143E270 File Offset: 0x0143C470
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86508 - 140722 != -54214)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_18D;
					case 2:
						this.$self_$47529.LeaveGame();
						if (56717 - 299747 != -243030)
						{
							continue;
						}
						this.YieldDefault(1);
						if (125303 - 251378 != -126074)
						{
							goto Block_10;
						}
						continue;
					default:
						if (64615 - 559597 != -494982)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (162510 - 391996 == -229486)
					{
						Game.mStateTime = Time.time;
						if (9828 - 536365 != -526536)
						{
							Game.mNextGameCode = 31;
							if (29225 - 22796 != 6430)
							{
								if (this.$self_$47529.dhhnr9M2RyZ)
								{
									if (14330 - 355662 == -341331)
									{
										continue;
									}
									this.$self_$47529.dhhnr9M2RyZ.close();
									if (152427 - 214615 == -62187)
									{
										continue;
									}
								}
								this.$self_$47529.SendMessage("fadeOut");
								if (73892 - 108511 != -34618)
								{
									goto Block_11;
								}
							}
						}
					}
				}
				Block_10:
				goto IL_18D;
				Block_11:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_18D:
				return false;
			}

			// Token: 0x0600BFCF RID: 49103 RVA: 0x0143E41C File Offset: 0x0143C61C
			internal static bool OTOWpUtWmltitfAaJYeT()
			{
				return true;
			}

			// Token: 0x0600BFD0 RID: 49104 RVA: 0x0143E420 File Offset: 0x0143C620
			internal static bool uSybr0tWFda4KYdkr7g8()
			{
				return false;
			}

			// Token: 0x0400A38A RID: 41866
			internal M988_GuildWar $self_$47529;
		}
	}

	// Token: 0x02002008 RID: 8200
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47531 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BFD1 RID: 49105 RVA: 0x0143E424 File Offset: 0x0143C624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47531(M988_GuildWar self_)
		{
			if (23651 - 114959 != -91308)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224887 - 524909 == -300022)
				{
					base..ctor();
					if (152655 - 14834 == 137821)
					{
						this.$self_$47534 = self_;
						if (145482 - 524807 != -379324)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BFD2 RID: 49106 RVA: 0x0143E4BC File Offset: 0x0143C6BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M988_GuildWar.$ReturnToCamp$47531.$(this.$self_$47534);
		}

		// Token: 0x0600BFD3 RID: 49107 RVA: 0x0143E4CC File Offset: 0x0143C6CC
		internal static bool NJxVIjtWMH47KWaI9XXh()
		{
			return true;
		}

		// Token: 0x0600BFD4 RID: 49108 RVA: 0x0143E4D0 File Offset: 0x0143C6D0
		internal static bool WFYZlUtWxV6pvwASNmwR()
		{
			return false;
		}

		// Token: 0x0400A38B RID: 41867
		internal M988_GuildWar $self_$47534;

		// Token: 0x02002009 RID: 8201
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BFD5 RID: 49109 RVA: 0x0143E4D4 File Offset: 0x0143C6D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M988_GuildWar self_)
			{
				if (91548 - 97559 != -6011)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250690 - 257103 == -6413)
					{
						base..ctor();
						if (211067 - 1050 != 210018)
						{
							this.$self_$47533 = self_;
							if (231424 - 344207 == -112783)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BFD6 RID: 49110 RVA: 0x0143E56C File Offset: 0x0143C76C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (377 - 214837 != -214459)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_333;
					case 2:
						this.$self_$47533.LeaveGame();
						if (112178 - 484403 == -372224)
						{
							continue;
						}
						this.YieldDefault(1);
						if (39929 - 419748 != -379818)
						{
							goto Block_4;
						}
						continue;
					default:
						if (289271 - 234787 != 54484)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (28029 - 81875 != -53845)
					{
						Game.mStateTime = Time.time;
						if (24618 - 211885 != -187266)
						{
							this.$$switch$8923$47532 = PlayerData.SaveGuild;
							if (159433 - 330921 != -171487)
							{
								if (this.$$switch$8923$47532 == 1)
								{
									if (162687 - 235813 != -73126)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (251663 - 451081 == -199417)
									{
										continue;
									}
								}
								else if (this.$$switch$8923$47532 == 2)
								{
									if (198123 - 290618 == -92494)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (244689 - 599286 == -354596)
									{
										continue;
									}
								}
								else if (this.$$switch$8923$47532 == 3)
								{
									if (62379 - 337111 == -274731)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (148558 - 367077 != -218519)
									{
										continue;
									}
								}
								else if (this.$$switch$8923$47532 == 4)
								{
									if (107639 - 32264 != 75375)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (196980 - 77588 == 119393)
									{
										continue;
									}
								}
								else if (this.$$switch$8923$47532 == 5)
								{
									if (67110 - 96963 == -29852)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (80070 - 209461 != -129391)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (156204 - 222278 != -66074)
									{
										continue;
									}
								}
								if (this.$self_$47533.dhhnr9M2RyZ)
								{
									if (245683 - 33541 != 212142)
									{
										continue;
									}
									this.$self_$47533.dhhnr9M2RyZ.close();
									if (6100 - 542904 != -536804)
									{
										continue;
									}
								}
								this.$self_$47533.SendMessage("fadeOut");
								if (120990 - 466444 == -345454)
								{
									goto IL_165;
								}
							}
						}
					}
				}
				Block_4:
				goto IL_333;
				IL_165:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_333:
				return false;
			}

			// Token: 0x0600BFD7 RID: 49111 RVA: 0x0143E8C0 File Offset: 0x0143CAC0
			internal static bool ejUJOStWgnIDTiXUxYEH()
			{
				return true;
			}

			// Token: 0x0600BFD8 RID: 49112 RVA: 0x0143E8C4 File Offset: 0x0143CAC4
			internal static bool dfHlZotWfqCmwEYyr7UM()
			{
				return false;
			}

			// Token: 0x0400A38C RID: 41868
			internal int $$switch$8923$47532;

			// Token: 0x0400A38D RID: 41869
			internal M988_GuildWar $self_$47533;
		}
	}
}
