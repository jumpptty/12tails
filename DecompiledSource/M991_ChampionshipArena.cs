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

// Token: 0x0200200A RID: 8202
[Serializable]
public class M991_ChampionshipArena : MonoBehaviour
{
	// Token: 0x0600BFD9 RID: 49113 RVA: 0x0143E8C8 File Offset: 0x0143CAC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M991_ChampionshipArena()
	{
		if (204257 - 345358 != -141101)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (165404 - 167038 != -1633)
			{
				base..ctor();
				if (121431 - 456925 != -335493)
				{
					this.J1wnxd2iIBD = true;
					if (33878 - 308849 == -274971)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BFDA RID: 49114 RVA: 0x0143E960 File Offset: 0x0143CB60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (216471 - 405451 != -188979)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (104538 - 93357 != 11182)
			{
				Game.mGameType = 5;
				if (220904 - 156629 != 64276)
				{
					if (Chat.Initialized)
					{
						if (64312 - 304122 == -239810)
						{
							Chat.ChatDisplay.Clear();
							if (81021 - 282904 != -201882)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (38020 - 299837 == -261817)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFDB RID: 49115 RVA: 0x0143EA44 File Offset: 0x0143CC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (230229 - 28544 != 201686)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (100276 - 82945 != 17332)
				{
					Game.nextGame();
					if (201463 - 262977 != -61513)
					{
						Game.mGameCode = 991;
						if (64671 - 487477 != -422805)
						{
							Game.mGameType = 5;
							if (290102 - 447570 != -157467)
							{
								Game.mGameTime = Time.time;
								if (279525 - 279448 == 77)
								{
									Game.mGameScore = 0;
									if (47918 - 591473 != -543554)
									{
										Game.mGameMana = 0;
										if (183990 - 402065 != -218074)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (202312 - 139848 == 62464)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (51056 - 358370 == -307314)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (2461 - 380193 == -377732)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (298315 - 115603 != 182713)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (37162 - 227991 != -190828)
															{
																this.rXnnxOFdH2D = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (262060 - 265188 == -3128)
																{
																	this.AZ3nxX6xmWP = PhotonClient.Connection;
																	if (193780 - 313143 != -119362)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (248537 - 339542 == -91005)
																		{
																			this.InitGame();
																			if (69286 - 153390 == -84104)
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
				Debug.Log("Not Connected");
				if (205301 - 252373 != -47071)
				{
					Game.mGameType = 99;
					if (76719 - 250772 == -174053)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BFDC RID: 49116 RVA: 0x0143ED24 File Offset: 0x0143CF24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (285367 - 319689 != -34321)
		{
		}
		for (;;)
		{
			if (this.AZ3nxX6xmWP == null)
			{
				if (51609 - 462715 == -411106)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (261179 - 381623 != -120443)
				{
					if (mGameState == eGameState.Init)
					{
						if (56346 - 43040 != 13307)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (160606 - 38523 != 122084)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (187375 - 298784 == -111409)
						{
							Game.mGameTime = Time.time + (float)720;
							if (145790 - 468396 != -322605)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (163754 - 419432 != -255677)
						{
							Game.mGameTime = Time.time + (float)720;
							if (103696 - 129993 == -26297)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (71455 - 308617 != -237161)
						{
							if (Time.time > this.mQSnx27RWmO)
							{
								if (225840 - 113043 == 112798)
								{
									continue;
								}
								Game.mGameMana++;
								if (189573 - 517446 != -327873)
								{
									continue;
								}
								this.mQSnx27RWmO = Time.time + (float)12;
								if (267869 - 254342 == 13528)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (9033 - 162399 != -153366)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (155552 - 111677 == 43876)
									{
										continue;
									}
									this.audio.Play();
									if (283874 - 339908 == -56033)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (46086 - 149798 == -103712)
							{
								AudioListener.volume = 0.1f * (float)Game.volume;
								if (185938 - 91369 == 94569)
								{
									this.GameEventUpdate();
									if (278382 - 86600 != 191783)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (59475 - 420433 == -360958)
						{
							this.GameEventUpdate();
							if (205024 - 356502 != -151477)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (115715 - 262015 != -146299)
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
						if (1827 - 342179 != -340351)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFDD RID: 49117 RVA: 0x0143F0BC File Offset: 0x0143D2BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (103773 - 110105 != -6332)
		{
		}
		while (this.DChnx9Yo2k0 < 2)
		{
			if (220021 - 335737 != -115715)
			{
				if (Time.time < Game.mGameTime)
				{
					break;
				}
				if (59935 - 326973 != -267037)
				{
					this.DChnx9Yo2k0 = 2;
					if (211056 - 408986 == -197930)
					{
						Game.sendMissionEvent(9915, 0);
						if (55160 - 174352 != -119191)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFDE RID: 49118 RVA: 0x0143F18C File Offset: 0x0143D38C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (81446 - 412248 != -330802)
		{
		}
		for (;;)
		{
			if (!this.MBxnxvB4LNN)
			{
				if (105608 - 67103 == 38505)
				{
					break;
				}
			}
			else
			{
				if (Input.GetKeyDown("escape"))
				{
					if (65476 - 359338 != -293862)
					{
						continue;
					}
					this.J1wnxd2iIBD = !this.J1wnxd2iIBD;
					if (241152 - 18743 != 222409)
					{
						continue;
					}
					if (this.JMynxg9l8ym)
					{
						if (79988 - 478145 == -398156)
						{
							continue;
						}
						this.audio.PlayOneShot(this.JMynxg9l8ym);
						if (204832 - 538286 == -333453)
						{
							continue;
						}
					}
				}
				if (Input.GetKeyDown(KeyCode.Return))
				{
					if (125330 - 353536 == -228205)
					{
						continue;
					}
					if (Chat.ChatTimeOut <= Time.time)
					{
						if (98267 - 409902 == -311634)
						{
							continue;
						}
						this.J1wnxd2iIBD = true;
						if (230533 - 152274 != 78259)
						{
							continue;
						}
						Chat.ChatActive = true;
						if (201411 - 395443 != -194032)
						{
							continue;
						}
						Chat.ChatTimeOut = Time.time + 0.1f;
						if (37374 - 179470 == -142095)
						{
							continue;
						}
					}
				}
				if (this.rXnnxOFdH2D.target == null)
				{
					if (142810 - 157254 != -14443)
					{
						if (!this.dO1nxGHp3hq)
						{
							break;
						}
						if (171188 - 16650 == 154538)
						{
							this.transform.position = this.dO1nxGHp3hq.transform.position;
							if (73923 - 26828 == 47095)
							{
								this.transform.rotation = this.dO1nxGHp3hq.transform.rotation;
								if (269983 - 297025 == -27042)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (this.rXnnxOFdH2D)
					{
						if (152603 - 267350 != -114747)
						{
							continue;
						}
						if (this.rXnnxOFdH2D.enabled)
						{
							if (131101 - 95450 != 35651)
							{
								continue;
							}
							if (Input.GetMouseButton(1))
							{
								if (87070 - 509449 != -422379)
								{
									continue;
								}
								this.rXnnxOFdH2D.rotation = Mathf.Clamp(1.4f * Input.GetAxis("Mouse X"), (float)-15, (float)15);
								if (55691 - 87 == 55605)
								{
									continue;
								}
							}
						}
					}
					this.rXnnxOFdH2D.zoom = Mathf.Clamp(Input.GetAxis("Mouse ScrollWheel"), -0.3f, 0.3f);
					if (28420 - 14309 != 14112)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BFDF RID: 49119 RVA: 0x0143F510 File Offset: 0x0143D710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (268388 - 182370 != 86018)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (25546 - 455300 != -429753)
			{
				GUI.depth = 1;
				if (122823 - 61316 == 61507)
				{
					this.GQnnxlvlFOr = (float)(1024 * Screen.width / Screen.height);
					if (99790 - 163734 == -63944)
					{
						float num = (float)1;
						if (205263 - 467977 != -262713)
						{
							eGameState mGameState = Game.mGameState;
							if (167356 - 236997 != -69640)
							{
								if (mGameState == eGameState.Ready)
								{
									if (140776 - 324759 == -183983)
									{
										if (this.iWLnx1fJ7wb)
										{
											if (195732 - 504253 == -308520)
											{
												continue;
											}
											if (Time.time - Game.mStateTime < (float)2)
											{
												if (70348 - 395915 != -325567)
												{
													continue;
												}
												float num2 = Mathf.SmoothStep(1f, 0.8f, Time.time - Game.mStateTime);
												if (258284 - 520465 == -262180)
												{
													continue;
												}
												float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
												if (26207 - 569335 == -543127)
												{
													continue;
												}
												Color color = GUI.color;
												if (88170 - 422205 != -334035)
												{
													continue;
												}
												float num3 = color.a = a;
												if (34107 - 446906 == -412798 || 85908 - 307086 == -221177)
												{
													continue;
												}
												GUI.color = color;
												if (296186 - 455054 == -158867 || 228483 - 471210 == -242726)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * (this.GQnnxlvlFOr - (float)this.iWLnx1fJ7wb.width * num2), (float)450 - 0.5f * (float)this.iWLnx1fJ7wb.height * num2, (float)this.iWLnx1fJ7wb.width * num2, (float)this.iWLnx1fJ7wb.height * num2), this.iWLnx1fJ7wb);
												if (288065 - 566373 == -278307)
												{
													continue;
												}
												float a2 = 1f;
												if (270556 - 351552 == -80995)
												{
													continue;
												}
												Color color2 = GUI.color;
												if (187377 - 314787 == -127409)
												{
													continue;
												}
												color2.a = a2;
												if (147307 - 472193 != -324886)
												{
													continue;
												}
												if (178208 - 286893 == -108684)
												{
													continue;
												}
												GUI.color = color2;
												if (210456 - 433959 == -223502)
												{
													continue;
												}
												if (290510 - 569297 != -278787)
												{
													continue;
												}
											}
										}
										if (!this.MBxnxvB4LNN)
										{
											break;
										}
										if (281833 - 112642 != 169192)
										{
											this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
											if (35656 - 47545 == -11889)
											{
												if (this.J1wnxd2iIBD)
												{
													if (107909 - 94752 == 13158)
													{
														continue;
													}
													this.RenderObserverMenu();
													if (260234 - 101771 == 158464)
													{
														continue;
													}
													this.RenderTeamBar1();
													if (139315 - 77001 == 62315)
													{
														continue;
													}
													this.RenderTeamBar2();
													if (4109 - 287565 == -283455)
													{
														continue;
													}
													this.RenderChatBar();
													if (253279 - 502599 != -249320)
													{
														continue;
													}
													this.RenderGameMessege();
													if (81377 - 342644 == -261266)
													{
														continue;
													}
												}
												if (!Chat.ChatActive)
												{
													break;
												}
												if (189217 - 253286 == -64069)
												{
													GUI.FocusControl("ChatBarField");
													if (124889 - 270959 != -146069)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (mGameState == eGameState.Start)
								{
									if (260349 - 77022 == 183327)
									{
										if (Time.time - Game.mStateTime < (float)1)
										{
											if (112747 - 561625 != -448878)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime);
											if (26348 - 506906 == -480557)
											{
												continue;
											}
											float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime);
											if (109325 - 350101 == -240775)
											{
												continue;
											}
											Color color3 = GUI.color;
											if (13455 - 9124 == 4332)
											{
												continue;
											}
											color3.a = a3;
											if (111473 - 336324 != -224851)
											{
												continue;
											}
											if (205877 - 31125 != 174752)
											{
												continue;
											}
											Color color4 = GUI.color = color3;
											if (75127 - 363321 == -288193)
											{
												continue;
											}
											if (197360 - 126873 != 70487)
											{
												continue;
											}
											if (this.gCNnxpQXJNK)
											{
												if (275266 - 46865 != 228401)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * this.GQnnxlvlFOr - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.famnxrAskaM);
												if (72140 - 564230 == -492089)
												{
													continue;
												}
											}
											float a4 = 1f;
											if (58304 - 277857 == -219552)
											{
												continue;
											}
											Color color5 = GUI.color;
											if (56426 - 14966 == 41461)
											{
												continue;
											}
											float num4 = color5.a = a4;
											if (242082 - 474648 == -232565)
											{
												continue;
											}
											if (234835 - 363571 != -128736)
											{
												continue;
											}
											GUI.color = color5;
											if (129145 - 305369 == -176223)
											{
												continue;
											}
											if (281920 - 143525 != 138395)
											{
												continue;
											}
										}
										else if (Time.time - Game.mStateTime < (float)2)
										{
											if (212210 - 505367 != -293157)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
											if (403 - 13698 == -13294)
											{
												continue;
											}
											float a5 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
											if (202060 - 262416 == -60355)
											{
												continue;
											}
											Color color6 = GUI.color;
											if (161956 - 157838 != 4118)
											{
												continue;
											}
											float num5 = color6.a = a5;
											if (165020 - 392690 != -227670)
											{
												continue;
											}
											if (50971 - 107915 == -56943)
											{
												continue;
											}
											Color color7 = GUI.color = color6;
											if (29179 - 461971 != -432792)
											{
												continue;
											}
											if (294831 - 487996 != -193165)
											{
												continue;
											}
											if (this.uConxRCg5MD)
											{
												if (231859 - 323242 != -91383)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * this.GQnnxlvlFOr - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.uConxRCg5MD);
												if (200835 - 442999 != -242164)
												{
													continue;
												}
											}
											float a6 = 1f;
											if (106849 - 581685 == -474835)
											{
												continue;
											}
											Color color8 = GUI.color;
											if (296028 - 475341 == -179312)
											{
												continue;
											}
											float num6 = color8.a = a6;
											if (127788 - 267615 == -139826)
											{
												continue;
											}
											if (25676 - 90977 != -65301)
											{
												continue;
											}
											Color color9 = GUI.color = color8;
											if (203647 - 564872 == -361224 || 135551 - 530775 == -395223)
											{
												continue;
											}
										}
										else if (Time.time - Game.mStateTime < (float)3)
										{
											if (106845 - 276178 == -169332)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
											if (66758 - 13692 == 53067)
											{
												continue;
											}
											float a7 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
											if (144677 - 597894 != -453217)
											{
												continue;
											}
											Color color10 = GUI.color;
											if (1052 - 493384 == -492331)
											{
												continue;
											}
											color10.a = a7;
											if (265298 - 482306 != -217008)
											{
												continue;
											}
											if (177561 - 259870 == -82308)
											{
												continue;
											}
											Color color11 = GUI.color = color10;
											if (291845 - 171732 != 120113)
											{
												continue;
											}
											if (69890 - 353144 == -283253)
											{
												continue;
											}
											if (this.famnxrAskaM)
											{
												if (7913 - 82898 != -74985)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * this.GQnnxlvlFOr - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.gCNnxpQXJNK);
												if (205905 - 408694 != -202789)
												{
													continue;
												}
											}
											float a8 = 1f;
											if (507 - 21948 == -21440)
											{
												continue;
											}
											Color color12 = GUI.color;
											if (145430 - 25010 != 120420)
											{
												continue;
											}
											color12.a = a8;
											if (131437 - 456365 != -324928)
											{
												continue;
											}
											if (107794 - 257021 != -149227)
											{
												continue;
											}
											GUI.color = color12;
											if (201431 - 40095 == 161337 || 8825 - 428333 == -419507)
											{
												continue;
											}
										}
										else
										{
											Game.mGameState = eGameState.Normal;
											if (32740 - 80882 == -48141)
											{
												continue;
											}
											Game.mGameTime = Time.time + (float)720;
											if (222393 - 86264 != 136129)
											{
												continue;
											}
											Game.mStateTime = Time.time;
											if (19630 - 357627 == -337996)
											{
												continue;
											}
										}
										if (!this.MBxnxvB4LNN)
										{
											break;
										}
										if (30497 - 23053 == 7444)
										{
											this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
											if (280302 - 461513 != -181210)
											{
												if (this.J1wnxd2iIBD)
												{
													if (205847 - 472209 == -266361)
													{
														continue;
													}
													this.RenderObserverMenu();
													if (260920 - 114625 == 146296)
													{
														continue;
													}
													this.RenderTeamBar1();
													if (154741 - 232734 == -77992)
													{
														continue;
													}
													this.RenderTeamBar2();
													if (13749 - 487980 == -474230)
													{
														continue;
													}
													this.RenderChatBar();
													if (239295 - 63232 != 176063)
													{
														continue;
													}
													this.RenderGameMessege();
													if (246452 - 319888 == -73435)
													{
														continue;
													}
												}
												if (!Chat.ChatActive)
												{
													break;
												}
												if (47812 - 320076 != -272263)
												{
													GUI.FocusControl("ChatBarField");
													if (276707 - 381198 == -104491)
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
									if (mGameState != eGameState.Normal)
									{
										break;
									}
									if (294165 - 552895 == -258730)
									{
										if (Time.time - Game.mStateTime < (float)2)
										{
											if (74609 - 561785 == -487175)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
											if (233984 - 404652 == -170667)
											{
												continue;
											}
											float a9 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
											if (222430 - 108686 != 113744)
											{
												continue;
											}
											Color color13 = GUI.color;
											if (167894 - 166351 != 1543)
											{
												continue;
											}
											float num7 = color13.a = a9;
											if (271441 - 151665 != 119776)
											{
												continue;
											}
											if (86145 - 392363 != -306218)
											{
												continue;
											}
											GUI.color = color13;
											if (168863 - 479580 == -310716 || 151706 - 504273 == -352566)
											{
												continue;
											}
											if (this.Mr1nxqT8FcY)
											{
												if (230378 - 532743 != -302365)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * this.GQnnxlvlFOr - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.Mr1nxqT8FcY);
												if (182067 - 545207 == -363139)
												{
													continue;
												}
											}
											float a10 = 1f;
											if (270589 - 352423 == -81833)
											{
												continue;
											}
											Color color14 = GUI.color;
											if (134271 - 405987 != -271716)
											{
												continue;
											}
											color14.a = a10;
											if (295003 - 98084 != 196919)
											{
												continue;
											}
											if (161262 - 354857 == -193594)
											{
												continue;
											}
											GUI.color = color14;
											if (268604 - 334599 == -65994 || 47580 - 225869 == -178288)
											{
												continue;
											}
										}
										if (!this.MBxnxvB4LNN)
										{
											break;
										}
										if (39804 - 509841 == -470037)
										{
											this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
											if (75679 - 513489 != -437809)
											{
												if (this.J1wnxd2iIBD)
												{
													if (72273 - 524801 == -452527)
													{
														continue;
													}
													this.RenderObserverMenu();
													if (275863 - 425987 != -150124)
													{
														continue;
													}
													this.RenderTeamBar1();
													if (183393 - 185981 == -2587)
													{
														continue;
													}
													this.RenderTeamBar2();
													if (105946 - 113930 != -7984)
													{
														continue;
													}
													this.RenderChatBar();
													if (114215 - 283381 != -169166)
													{
														continue;
													}
													this.RenderGameMessege();
													if (38666 - 572079 != -533413)
													{
														continue;
													}
												}
												if (!Chat.ChatActive)
												{
													break;
												}
												if (100177 - 306646 == -206469)
												{
													GUI.FocusControl("ChatBarField");
													if (172522 - 59093 == 113429)
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

	// Token: 0x0600BFE0 RID: 49120 RVA: 0x01440804 File Offset: 0x0143EA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitObserverMenu()
	{
		if (160796 - 292202 != -131406)
		{
		}
		for (;;)
		{
			this.edpnxYhSuYi = (Texture2D)Resources.Load("GameGui/Observer/timerBar", typeof(Texture2D));
			if (196378 - 362571 == -166193)
			{
				this.pA8nx3x8nf1 = new GUIStyle();
				if (117961 - 209721 == -91760)
				{
					this.pA8nx3x8nf1.normal.background = (Texture2D)Resources.Load("GameGui/Observer/start", typeof(Texture2D));
					if (212976 - 357664 != -144687)
					{
						this.pA8nx3x8nf1.hover.background = (Texture2D)Resources.Load("GameGui/Observer/start_h", typeof(Texture2D));
						if (227604 - 370167 != -142562)
						{
							this.gHinxbsqOlN = new GUIStyle();
							if (199324 - 378140 == -178816)
							{
								this.gHinxbsqOlN.normal.background = (Texture2D)Resources.Load("GameGui/Observer/quit", typeof(Texture2D));
								if (84428 - 214561 == -130133)
								{
									this.gHinxbsqOlN.hover.background = (Texture2D)Resources.Load("GameGui/Observer/quit_h", typeof(Texture2D));
									if (24305 - 2571 != 21735)
									{
										this.y2Inxx90Er0 = (Texture2D)Resources.Load("GameGui/Observer/win_team1", typeof(Texture2D));
										if (34418 - 534539 != -500120)
										{
											this.IA8nxTdbNbR = (Texture2D)Resources.Load("GameGui/Observer/win_team2", typeof(Texture2D));
											if (259227 - 128741 != 130487)
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

	// Token: 0x0600BFE1 RID: 49121 RVA: 0x01440A40 File Offset: 0x0143EC40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderObserverMenu()
	{
		if (177011 - 38552 != 138459)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Start)
			{
				if (261632 - 103885 == 157748)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Ready)
				{
					if (19113 - 516066 != -496953)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (293365 - 338992 != -45626)
						{
							break;
						}
						continue;
					}
				}
			}
			int num = 0;
			if (281309 - 446089 == -164780)
			{
				int nNum = 0;
				if (287807 - 253718 != 34090)
				{
					if (Game.mGameTime != (float)0)
					{
						if (48176 - 71535 == -23358)
						{
							continue;
						}
						num = Mathf.Abs(Mathf.FloorToInt(Time.time - Game.mGameTime));
						if (64992 - 596118 == -531125)
						{
							continue;
						}
						nNum = global::Math.div((float)num, (float)60);
						if (168601 - 48887 != 119714)
						{
							continue;
						}
						num %= 60;
						if (25421 - 240959 == -215537)
						{
							continue;
						}
					}
					GUI.DrawTexture(new Rect(0.5f * (this.GQnnxlvlFOr - (float)169), (float)4, (float)169, (float)96), this.edpnxYhSuYi);
					if (124223 - 575879 == -451656)
					{
						Guix.renderSmallNumber((int)(0.5f * this.GQnnxlvlFOr - (float)30), 40, nNum, false, 1.25f);
						if (207848 - 496860 == -289012)
						{
							Guix.renderSmallNumber((int)(0.5f * this.GQnnxlvlFOr + (float)30), 40, num, false, 1.25f);
							if (299116 - 392182 == -93066)
							{
								if (Game.mGameState > eGameState.Ready)
								{
									if (221229 - 422640 != -201411)
									{
										continue;
									}
									if (this.y2Inxx90Er0)
									{
										if (282482 - 35164 != 247318)
										{
											continue;
										}
										if (this.gw5nxyHZKCJ >= this.oGPnxWcKH7j)
										{
											if (226076 - 215165 == 10912)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * this.GQnnxlvlFOr - (float)260, (float)400, (float)523, (float)179), this.y2Inxx90Er0);
											if (44927 - 446774 != -401846)
											{
												goto IL_1A;
											}
											continue;
										}
									}
									if (this.IA8nxTdbNbR)
									{
										if (222690 - 101914 != 120776)
										{
											continue;
										}
										if (this.gi5nxVTRxp3 >= this.CBYnxuvuEWN)
										{
											if (254454 - 213297 == 41158)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * this.GQnnxlvlFOr - (float)260, (float)400, (float)523, (float)179), this.IA8nxTdbNbR);
											if (150772 - 175302 != -24530)
											{
												continue;
											}
										}
									}
								}
								IL_1A:
								if (!this.J1wnxd2iIBD)
								{
									break;
								}
								if (182534 - 217370 != -34835)
								{
									if (Game.mGameState == eGameState.Ready)
									{
										if (81295 - 461523 != -380227)
										{
											if (!GUI.Button(new Rect(this.GQnnxlvlFOr - (float)120, (float)940, (float)93, (float)41), string.Empty, this.pA8nx3x8nf1))
											{
												break;
											}
											if (154413 - 144206 != 10208)
											{
												Game.sendMissionEvent(9916, 0);
												if (7841 - 388816 == -380975)
												{
													Game.mGameTime = Time.time + (float)720;
													if (112172 - 522040 == -409868)
													{
														if (!this.ngNnxa9CpOQ)
														{
															break;
														}
														if (130359 - 571735 != -441375)
														{
															this.audio.PlayOneShot(this.ngNnxa9CpOQ);
															if (287314 - 265947 == 21367)
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
										if (!GUI.Button(new Rect(this.GQnnxlvlFOr - (float)120, (float)940, (float)93, (float)41), string.Empty, this.gHinxbsqOlN))
										{
											break;
										}
										if (68475 - 396847 != -328371)
										{
											this.StartCoroutine_Auto(this.ReturnToTown());
											if (176363 - 507836 != -331472)
											{
												if (!this.ngNnxa9CpOQ)
												{
													break;
												}
												if (289849 - 357808 == -67959)
												{
													this.audio.PlayOneShot(this.ngNnxa9CpOQ);
													if (115425 - 77566 != 37860)
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

	// Token: 0x0600BFE2 RID: 49122 RVA: 0x01440FF0 File Offset: 0x0143F1F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTeamBar()
	{
		if (63528 - 525803 != -462275)
		{
		}
		for (;;)
		{
			this.lLInxfc5JuV = new CharacterControl[3];
			if (272784 - 258345 != 14440)
			{
				this.vI5nxL9yT1r = new Texture[3];
				if (165043 - 191174 != -26130)
				{
					this.LWCnxwiLdvx = new CharacterControl[3];
					if (21991 - 105590 == -83599)
					{
						this.earnxUOaqYx = new Texture[3];
						if (226294 - 567339 == -341045)
						{
							this.M2anx44upO9 = new GUIStyle();
							if (108364 - 170712 == -62348)
							{
								this.M2anx44upO9.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
								if (233878 - 221410 != 12469)
								{
									this.M2anx44upO9.alignment = TextAnchor.MiddleLeft;
									if (288399 - 399967 == -111568)
									{
										this.l9qnxsWZb8v = new GUIStyle();
										if (120050 - 223220 != -103169)
										{
											this.l9qnxsWZb8v.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_Button", typeof(Texture)));
											if (278214 - 366 == 277848)
											{
												this.Ek1nxHsss5G = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_BG", typeof(Texture));
												if (266904 - 169786 == 97118)
												{
													this.ufdnx7Y1F4k = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_BG2", typeof(Texture));
													if (102915 - 385510 != -282594)
													{
														this.qNBnxCaSAsv = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_Top", typeof(Texture));
														if (289001 - 116396 != 172606)
														{
															this.S7vnxZCiwaV = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_HP", typeof(Texture));
															if (109497 - 152017 != -42519)
															{
																this.aePnxMW43cv = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_Hit", typeof(Texture));
																if (185994 - 157881 != 28114)
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

	// Token: 0x0600BFE3 RID: 49123 RVA: 0x014412D4 File Offset: 0x0143F4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetTeamBar()
	{
		if (227316 - 423034 != -195717)
		{
		}
		for (;;)
		{
			IL_488:
			this.lLInxfc5JuV = new CharacterControl[3];
			if (147200 - 256386 == -109186)
			{
				this.vI5nxL9yT1r = new Texture[3];
				if (159252 - 56868 != 102385)
				{
					this.LWCnxwiLdvx = new CharacterControl[3];
					if (26779 - 434057 != -407277)
					{
						this.earnxUOaqYx = new Texture[3];
						if (155463 - 157285 == -1822)
						{
							GameObject gameObject = GameObject.Find("Team1");
							if (104612 - 339115 != -234502)
							{
								int num = 0;
								if (42339 - 215161 != -172821)
								{
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(gameObject.transform);
									if (797 - 110130 != -109332)
									{
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											object obj3;
											object obj2 = obj3 = obj;
											if (!(obj2 is Transform))
											{
												obj3 = RuntimeServices.Coerce(obj2, typeof(Transform));
											}
											Transform transform = (Transform)obj3;
											if (253773 - 395148 == -141374)
											{
												goto IL_488;
											}
											CharacterControl characterControl = (CharacterControl)transform.GetComponent(typeof(CharacterControl));
											if (274153 - 217821 == 56333)
											{
												goto IL_488;
											}
											UnityRuntimeServices.Update(enumerator, transform);
											if (191629 - 462723 == -271093)
											{
												goto IL_488;
											}
											if (characterControl)
											{
												if (215920 - 100170 != 115750)
												{
													goto IL_488;
												}
												if (!characterControl.isTransform)
												{
													if (36942 - 382616 != -345674)
													{
														goto IL_488;
													}
													if (transform.tag == "Player")
													{
														if (170789 - 442987 == -272197)
														{
															goto IL_488;
														}
														this.lLInxfc5JuV[num] = characterControl;
														if (172886 - 560833 != -387947)
														{
															goto IL_488;
														}
														this.vI5nxL9yT1r[num] = (Texture)Resources.Load("GameGui/Icons/Heroes/" + characterControl.Type + Mathf.FloorToInt((float)(characterControl.Skin / 100)), typeof(Texture));
														if (219341 - 47242 == 172100)
														{
															goto IL_488;
														}
														num++;
														if (3135 - 542299 != -539164)
														{
															goto IL_488;
														}
													}
												}
											}
										}
										if (109304 - 132392 == -23088)
										{
											GameObject gameObject2 = GameObject.Find("Team2");
											if (75117 - 121673 == -46556)
											{
												int num2 = 0;
												if (103029 - 515463 == -412434)
												{
													IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(gameObject2.transform);
													if (108778 - 195733 == -86955)
													{
														while (enumerator2.MoveNext())
														{
															object obj4 = enumerator2.Current;
															object obj6;
															object obj5 = obj6 = obj4;
															if (!(obj5 is Transform))
															{
																obj6 = RuntimeServices.Coerce(obj5, typeof(Transform));
															}
															Transform transform2 = (Transform)obj6;
															if (237102 - 35772 != 201330)
															{
																goto IL_488;
															}
															CharacterControl characterControl2 = (CharacterControl)transform2.GetComponent(typeof(CharacterControl));
															if (135611 - 92830 == 42782)
															{
																goto IL_488;
															}
															UnityRuntimeServices.Update(enumerator2, transform2);
															if (234806 - 292065 == -57258)
															{
																goto IL_488;
															}
															if (characterControl2)
															{
																if (240626 - 575728 != -335102)
																{
																	goto IL_488;
																}
																if (!characterControl2.isTransform)
																{
																	if (13617 - 251522 == -237904)
																	{
																		goto IL_488;
																	}
																	if (transform2.tag == "Player")
																	{
																		if (201602 - 196237 != 5365)
																		{
																			goto IL_488;
																		}
																		this.LWCnxwiLdvx[num2] = characterControl2;
																		if (25059 - 591279 != -566220)
																		{
																			goto IL_488;
																		}
																		this.earnxUOaqYx[num2] = (Texture)Resources.Load("GameGui/Icons/Heroes/" + characterControl2.Type + Mathf.FloorToInt((float)(characterControl2.Skin / 100)), typeof(Texture));
																		if (102120 - 187593 == -85472)
																		{
																			goto IL_488;
																		}
																		num2++;
																		if (287431 - 315361 != -27930)
																		{
																			goto IL_488;
																		}
																	}
																}
															}
														}
														if (194696 - 225881 == -31185)
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

	// Token: 0x0600BFE4 RID: 49124 RVA: 0x01441834 File Offset: 0x0143FA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTeamBar1()
	{
		if (166013 - 84442 != 81571)
		{
		}
		for (;;)
		{
			IL_3CC:
			if (this.lLInxfc5JuV == null)
			{
				if (82875 - 363478 != -280602)
				{
					break;
				}
			}
			else if (this.vI5nxL9yT1r == null)
			{
				if (113298 - 534737 == -421439)
				{
					break;
				}
			}
			else
			{
				int num = 0;
				if (208904 - 377833 == -168929)
				{
					int i = 0;
					if (278893 - 154293 != 124601)
					{
						while (i < 3)
						{
							if (this.lLInxfc5JuV[i])
							{
								if (264334 - 535589 == -271254)
								{
									goto IL_3CC;
								}
								num++;
								if (181172 - 598272 == -417099)
								{
									goto IL_3CC;
								}
								GUI.BeginGroup(new Rect((float)15, (float)(150 + num * 90), (float)180, (float)100));
								if (265754 - 423215 == -157460)
								{
									goto IL_3CC;
								}
								if (this.vI5nxL9yT1r[i])
								{
									if (14528 - 507177 == -492648)
									{
										goto IL_3CC;
									}
									GUI.DrawTexture(new Rect((float)5, (float)10, (float)75, (float)75), this.vI5nxL9yT1r[i]);
									if (264524 - 456313 != -191789)
									{
										goto IL_3CC;
									}
								}
								CharacterControl characterControl = this.lLInxfc5JuV[i];
								if (299731 - 483263 == -183531)
								{
									goto IL_3CC;
								}
								if (characterControl.mTransformChar != null)
								{
									if (91439 - 363836 != -272397)
									{
										goto IL_3CC;
									}
									characterControl = characterControl.mTransformChar;
									if (247498 - 391171 != -143673)
									{
										goto IL_3CC;
									}
								}
								if (characterControl.myDamage != 0)
								{
									if (43268 - 229647 != -186379)
									{
										goto IL_3CC;
									}
									GUI.DrawTexture(new Rect((float)5, (float)10, (float)75, (float)75), this.aePnxMW43cv);
									if (261401 - 361856 != -100455)
									{
										goto IL_3CC;
									}
								}
								GUI.DrawTexture(new Rect((float)0, (float)0, (float)177, (float)89), this.Ek1nxHsss5G);
								if (71253 - 231106 == -159852)
								{
									goto IL_3CC;
								}
								if (characterControl.hp > 0)
								{
									if (182357 - 476245 != -293888)
									{
										goto IL_3CC;
									}
									GUI.DrawTexture(new Rect((float)82, (float)38, (float)Mathf.FloorToInt((float)(92 * characterControl.hp / characterControl.mhp)), (float)12), this.S7vnxZCiwaV);
									if (94914 - 111861 == -16946)
									{
										goto IL_3CC;
									}
								}
								GUI.DrawTexture(new Rect((float)79, (float)35, (float)35, (float)20), this.qNBnxCaSAsv);
								if (5575 - 392494 == -386918)
								{
									goto IL_3CC;
								}
								this.M2anx44upO9.normal.textColor = new Color(0.24f, 0.24f, 0.24f, (float)1);
								if (28823 - 44348 == -15524)
								{
									goto IL_3CC;
								}
								Guix.renderTextOutline(new Rect((float)91, (float)10, (float)100, (float)30), characterControl.Name, this.M2anx44upO9);
								if (284910 - 109162 == 175749)
								{
									goto IL_3CC;
								}
								if (characterControl.hp > 0)
								{
									if (157595 - 320941 == -163345)
									{
										goto IL_3CC;
									}
									Guix.renderTextOutline(new Rect((float)112, (float)35, (float)120, (float)30), characterControl.hp + "/" + characterControl.mhp, this.M2anx44upO9);
									if (160245 - 498098 == -337852)
									{
										goto IL_3CC;
									}
								}
								else
								{
									Guix.renderTextOutline(new Rect((float)112, (float)35, (float)120, (float)30), "dead", this.M2anx44upO9);
									if (151407 - 587881 == -436473)
									{
										goto IL_3CC;
									}
								}
								this.M2anx44upO9.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
								if (210290 - 396792 == -186501)
								{
									goto IL_3CC;
								}
								GUI.Label(new Rect((float)91, (float)10, (float)100, (float)30), characterControl.Name, this.M2anx44upO9);
								if (274197 - 484713 != -210516)
								{
									goto IL_3CC;
								}
								if (characterControl.hp > 0)
								{
									if (69681 - 20380 == 49302)
									{
										goto IL_3CC;
									}
									GUI.Label(new Rect((float)112, (float)35, (float)120, (float)30), characterControl.hp + "/" + characterControl.mhp, this.M2anx44upO9);
									if (272945 - 233668 != 39277)
									{
										goto IL_3CC;
									}
								}
								else
								{
									GUI.Label(new Rect((float)112, (float)35, (float)120, (float)30), "dead", this.M2anx44upO9);
									if (199125 - 34475 != 164650)
									{
										goto IL_3CC;
									}
								}
								if (GUI.Button(new Rect((float)5, (float)10, (float)75, (float)75), string.Empty, this.l9qnxsWZb8v))
								{
									if (209349 - 165466 != 43883)
									{
										goto IL_3CC;
									}
									GameObject gameObject = characterControl.gameObject;
									if (4169 - 360510 != -356341)
									{
										goto IL_3CC;
									}
									if (gameObject)
									{
										if (55360 - 213382 == -158021)
										{
											goto IL_3CC;
										}
										if (gameObject != this.rXnnxOFdH2D.target)
										{
											if (247150 - 39451 == 207700)
											{
												goto IL_3CC;
											}
											this.rXnnxOFdH2D.target = gameObject;
											if (139768 - 342305 == -202536)
											{
												goto IL_3CC;
											}
										}
										else
										{
											this.rXnnxOFdH2D.target = null;
											if (105518 - 26385 == 79134)
											{
												goto IL_3CC;
											}
										}
									}
								}
								GUI.EndGroup();
								if (145641 - 266010 != -120369)
								{
									goto IL_3CC;
								}
							}
							i++;
							if (148047 - 143019 == 5029)
							{
								goto IL_3CC;
							}
						}
						if (4763 - 490622 == -485859)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFE5 RID: 49125 RVA: 0x01441F60 File Offset: 0x01440160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTeamBar2()
	{
		if (180901 - 146026 != 34876)
		{
		}
		for (;;)
		{
			IL_4D6:
			if (this.LWCnxwiLdvx == null)
			{
				if (206957 - 523890 != -316932)
				{
					break;
				}
			}
			else if (this.earnxUOaqYx == null)
			{
				if (25478 - 263539 == -238061)
				{
					break;
				}
			}
			else
			{
				int num = 0;
				if (291132 - 5041 == 286091)
				{
					int i = 0;
					if (117299 - 550818 == -433519)
					{
						while (i < 3)
						{
							if (this.LWCnxwiLdvx[i])
							{
								if (13084 - 405979 != -392895)
								{
									goto IL_4D6;
								}
								num++;
								if (207748 - 546088 == -338339)
								{
									goto IL_4D6;
								}
								GUI.BeginGroup(new Rect(this.GQnnxlvlFOr - (float)195, (float)(150 + num * 90), (float)180, (float)100));
								if (69778 - 421147 != -351369)
								{
									goto IL_4D6;
								}
								if (this.earnxUOaqYx[i])
								{
									if (21635 - 269509 != -247874)
									{
										goto IL_4D6;
									}
									GUI.DrawTexture(new Rect((float)97, (float)10, (float)75, (float)75), this.earnxUOaqYx[i]);
									if (29489 - 431533 == -402043)
									{
										goto IL_4D6;
									}
								}
								CharacterControl characterControl = this.LWCnxwiLdvx[i];
								if (25057 - 217447 == -192389)
								{
									goto IL_4D6;
								}
								if (characterControl.mTransformChar != null)
								{
									if (258396 - 468687 == -210290)
									{
										goto IL_4D6;
									}
									characterControl = characterControl.mTransformChar;
									if (267508 - 456639 != -189131)
									{
										goto IL_4D6;
									}
								}
								if (characterControl.myDamage != 0)
								{
									if (36277 - 473906 != -437629)
									{
										goto IL_4D6;
									}
									GUI.DrawTexture(new Rect((float)97, (float)10, (float)75, (float)75), this.aePnxMW43cv);
									if (96074 - 546140 != -450066)
									{
										goto IL_4D6;
									}
								}
								GUI.DrawTexture(new Rect((float)0, (float)0, (float)177, (float)89), this.ufdnx7Y1F4k);
								if (157923 - 19977 != 137946)
								{
									goto IL_4D6;
								}
								if (characterControl.hp > 0)
								{
									if (112807 - 566450 != -453643)
									{
										goto IL_4D6;
									}
									GUI.DrawTexture(new Rect((float)4, (float)38, (float)Mathf.FloorToInt((float)(92 * characterControl.hp / characterControl.mhp)), (float)12), this.S7vnxZCiwaV);
									if (38878 - 210430 != -171552)
									{
										goto IL_4D6;
									}
								}
								GUI.DrawTexture(new Rect((float)2, (float)35, (float)35, (float)20), this.qNBnxCaSAsv);
								if (95489 - 57716 != 37773)
								{
									goto IL_4D6;
								}
								this.M2anx44upO9.normal.textColor = new Color(0.24f, 0.24f, 0.24f, (float)1);
								if (208613 - 9063 == 199551)
								{
									goto IL_4D6;
								}
								Guix.renderTextOutline(new Rect((float)14, (float)10, (float)100, (float)30), characterControl.Name, this.M2anx44upO9);
								if (154579 - 41122 == 113458)
								{
									goto IL_4D6;
								}
								if (characterControl.hp > 0)
								{
									if (36216 - 523090 != -486874)
									{
										goto IL_4D6;
									}
									Guix.renderTextOutline(new Rect((float)35, (float)35, (float)120, (float)30), characterControl.hp + "/" + characterControl.mhp, this.M2anx44upO9);
									if (19334 - 120164 != -100830)
									{
										goto IL_4D6;
									}
								}
								else
								{
									Guix.renderTextOutline(new Rect((float)35, (float)35, (float)120, (float)30), "dead", this.M2anx44upO9);
									if (294661 - 55397 != 239264)
									{
										goto IL_4D6;
									}
								}
								this.M2anx44upO9.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
								if (177673 - 533456 == -355782)
								{
									goto IL_4D6;
								}
								GUI.Label(new Rect((float)14, (float)10, (float)100, (float)30), characterControl.Name, this.M2anx44upO9);
								if (95038 - 105765 != -10727)
								{
									goto IL_4D6;
								}
								if (characterControl.hp > 0)
								{
									if (135235 - 544330 == -409094)
									{
										goto IL_4D6;
									}
									GUI.Label(new Rect((float)35, (float)35, (float)120, (float)30), characterControl.hp + "/" + characterControl.mhp, this.M2anx44upO9);
									if (74408 - 282759 != -208351)
									{
										goto IL_4D6;
									}
								}
								else
								{
									GUI.Label(new Rect((float)35, (float)35, (float)120, (float)30), "dead", this.M2anx44upO9);
									if (200532 - 231062 == -30529)
									{
										goto IL_4D6;
									}
								}
								if (GUI.Button(new Rect((float)97, (float)10, (float)75, (float)75), string.Empty, this.l9qnxsWZb8v))
								{
									if (91745 - 44174 == 47572)
									{
										goto IL_4D6;
									}
									GameObject gameObject = characterControl.gameObject;
									if (113004 - 298136 != -185132)
									{
										goto IL_4D6;
									}
									if (gameObject)
									{
										if (232249 - 497776 != -265527)
										{
											goto IL_4D6;
										}
										if (gameObject != this.rXnnxOFdH2D.target)
										{
											if (130581 - 501395 == -370813)
											{
												goto IL_4D6;
											}
											this.rXnnxOFdH2D.target = gameObject;
											if (196777 - 390791 == -194013)
											{
												goto IL_4D6;
											}
										}
										else
										{
											this.rXnnxOFdH2D.target = null;
											if (209420 - 152808 == 56613)
											{
												goto IL_4D6;
											}
										}
									}
								}
								GUI.EndGroup();
								if (167171 - 358091 == -190919)
								{
									goto IL_4D6;
								}
							}
							i++;
							if (191842 - 50151 == 141692)
							{
								goto IL_4D6;
							}
						}
						if (277684 - 552969 == -275285)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFE6 RID: 49126 RVA: 0x01442698 File Offset: 0x01440898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitChatBar()
	{
		if (230581 - 151500 != 79081)
		{
		}
		for (;;)
		{
			this.EWTnxNmPtfC = string.Empty;
			if (93598 - 343278 == -249680)
			{
				this.i64nxEEZhv0 = (Texture)Resources.Load("GameGui/Common/TypeField", typeof(Texture));
				if (43273 - 370105 == -326832)
				{
					this.lnMnxPT58dA = new GUIStyle();
					if (153714 - 485163 == -331449)
					{
						this.lnMnxPT58dA.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
						if (282668 - 109771 != 172898)
						{
							this.BTHnxSmAiuk = new GUIStyle();
							if (94654 - 36157 == 58497)
							{
								this.BTHnxSmAiuk.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
								if (272533 - 350782 == -78249)
								{
									this.QXbnxBukavd = Chat.TextColor;
									if (75552 - 501737 == -426185)
									{
										this.gdsnx0iTIRK = Chat.SelfColor;
										if (84104 - 458639 != -374534)
										{
											this.n7onx8JGJmT = Chat.AllyColor;
											if (55409 - 185502 == -130093)
											{
												this.UOonxibZCHv = Chat.EnemyColor;
												if (186396 - 568224 == -381828)
												{
													this.q1PnxDA51sv = Chat.GuildColor;
													if (196775 - 150844 == 45931)
													{
														this.laFnxmKRjuZ = Chat.NPCColor;
														if (241409 - 132887 != 108523)
														{
															this.JgDnxjRAI9V = Chat.ShadowColor;
															if (78813 - 319874 == -241061)
															{
																this.SZrnxo3t9Rh = Chat.SystemColor;
																if (39329 - 249280 != -209950)
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

	// Token: 0x0600BFE7 RID: 49127 RVA: 0x0144291C File Offset: 0x01440B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderChatBar()
	{
		if (70875 - 526351 != -455475)
		{
		}
		for (;;)
		{
			IL_C23:
			GUILayout.BeginArea(new Rect(this.GQnnxlvlFOr - (float)650, (float)300, (float)600, (float)600));
			if (243525 - 85901 == 157624)
			{
				GUILayout.BeginVertical(new GUILayoutOption[0]);
				if (80669 - 568658 != -487988)
				{
					GUILayout.FlexibleSpace();
					if (288245 - 13054 == 275191)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(Chat.ChatDisplay);
						if (268709 - 496255 == -227546)
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								object obj3;
								object obj2 = obj3 = obj;
								if (!(obj2 is ChatEntry))
								{
									obj3 = RuntimeServices.Coerce(obj2, typeof(ChatEntry));
								}
								ChatEntry chatEntry = (ChatEntry)obj3;
								if (236301 - 186583 == 49719)
								{
									goto IL_C23;
								}
								float num = Mathf.Clamp((float)30 - Time.time + chatEntry.time, (float)0, 1f);
								if (141220 - 352963 == -211742)
								{
									goto IL_C23;
								}
								UnityRuntimeServices.Update(enumerator, chatEntry);
								if (86640 - 75246 == 11395)
								{
									goto IL_C23;
								}
								eChatMode mode = chatEntry.mode;
								if (264927 - 516183 == -251255)
								{
									goto IL_C23;
								}
								UnityRuntimeServices.Update(enumerator, chatEntry);
								if (131765 - 1641 == 130125)
								{
									goto IL_C23;
								}
								if (mode == eChatMode.area)
								{
									if (295088 - 35667 == 259422)
									{
										goto IL_C23;
									}
									if (Chat.showAreaChat)
									{
										if (242393 - 179352 != 63041)
										{
											goto IL_C23;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (43849 - 203290 != -159441)
										{
											goto IL_C23;
										}
										GUILayout.FlexibleSpace();
										if (59528 - 153355 == -93826)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.laFnxmKRjuZ;
										if (62545 - 240715 != -178170)
										{
											goto IL_C23;
										}
										float a = num;
										if (215982 - 275920 == -59937)
										{
											goto IL_C23;
										}
										Color textColor = this.BTHnxSmAiuk.normal.textColor;
										if (117942 - 404747 != -286805)
										{
											goto IL_C23;
										}
										float num2 = textColor.a = a;
										if (299301 - 443141 == -143839)
										{
											goto IL_C23;
										}
										if (174402 - 192181 != -17779)
										{
											goto IL_C23;
										}
										Color color = this.BTHnxSmAiuk.normal.textColor = textColor;
										if (222392 - 447252 == -224859 || 269254 - 252822 == 16433)
										{
											goto IL_C23;
										}
										GUILayout.Label("[ALL]", this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (236467 - 114162 == 122306)
										{
											goto IL_C23;
										}
										GUILayout.Space((float)5);
										if (4133 - 305497 != -301364)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.gdsnx0iTIRK;
										if (10356 - 144450 == -134093)
										{
											goto IL_C23;
										}
										float a2 = num;
										if (121829 - 516046 == -394216)
										{
											goto IL_C23;
										}
										Color textColor2 = this.BTHnxSmAiuk.normal.textColor;
										if (55980 - 585215 != -529235)
										{
											goto IL_C23;
										}
										float num3 = textColor2.a = a2;
										if (125185 - 253938 == -128752 || 134673 - 303036 == -168362)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = textColor2;
										if (243253 - 532493 == -289239 || 174308 - 453772 == -279463)
										{
											goto IL_C23;
										}
										GUILayout.Label(chatEntry.name + ":", this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (228308 - 387605 != -159297)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (234475 - 374942 != -140467)
										{
											goto IL_C23;
										}
										GUILayout.Space((float)5);
										if (2095 - 285488 == -283392)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.QXbnxBukavd;
										if (292007 - 423687 == -131679)
										{
											goto IL_C23;
										}
										float a3 = num;
										if (264598 - 277808 != -13210)
										{
											goto IL_C23;
										}
										Color textColor3 = this.BTHnxSmAiuk.normal.textColor;
										if (172884 - 77543 != 95341)
										{
											goto IL_C23;
										}
										float num4 = textColor3.a = a3;
										if (11128 - 381142 == -370013 || 249042 - 87443 == 161600)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = textColor3;
										if (199237 - 224469 == -25231 || 290421 - 294584 == -4162)
										{
											goto IL_C23;
										}
										GUILayout.Label(chatEntry.text, this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (116368 - 22617 == 93752)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (10409 - 28925 != -18516)
										{
											goto IL_C23;
										}
										GUILayout.EndHorizontal();
										if (167148 - 323208 == -156059)
										{
											goto IL_C23;
										}
									}
								}
								else if (mode == eChatMode.party)
								{
									if (123189 - 578582 == -455392)
									{
										goto IL_C23;
									}
									if (Chat.showAreaChat)
									{
										if (127435 - 591258 == -463822)
										{
											goto IL_C23;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (290444 - 259719 != 30725)
										{
											goto IL_C23;
										}
										GUILayout.FlexibleSpace();
										if (38578 - 46324 != -7746)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = new Color(0.8f, 0.2f, 0.2f, num);
										if (75886 - 141871 != -65985)
										{
											goto IL_C23;
										}
										GUILayout.Label("[TEAM]", this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (224030 - 568465 == -344434)
										{
											goto IL_C23;
										}
										GUILayout.Space((float)5);
										if (223373 - 232632 != -9259)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.gdsnx0iTIRK;
										if (139828 - 109358 != 30470)
										{
											goto IL_C23;
										}
										float a4 = num;
										if (276231 - 28971 == 247261)
										{
											goto IL_C23;
										}
										Color textColor4 = this.BTHnxSmAiuk.normal.textColor;
										if (123360 - 144186 == -20825)
										{
											goto IL_C23;
										}
										float num5 = textColor4.a = a4;
										if (138141 - 146300 != -8159)
										{
											goto IL_C23;
										}
										if (256601 - 387649 == -131047)
										{
											goto IL_C23;
										}
										Color color2 = this.BTHnxSmAiuk.normal.textColor = textColor4;
										if (144786 - 67983 != 76803)
										{
											goto IL_C23;
										}
										if (254641 - 475596 != -220955)
										{
											goto IL_C23;
										}
										GUILayout.Label(chatEntry.name + ":", this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (80061 - 465472 != -385411)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (429 - 473429 == -472999)
										{
											goto IL_C23;
										}
										GUILayout.Space((float)5);
										if (1697 - 558935 != -557238)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.QXbnxBukavd;
										if (4238 - 348789 != -344551)
										{
											goto IL_C23;
										}
										float a5 = num;
										if (71217 - 490541 != -419324)
										{
											goto IL_C23;
										}
										Color textColor5 = this.BTHnxSmAiuk.normal.textColor;
										if (251332 - 464819 != -213487)
										{
											goto IL_C23;
										}
										textColor5.a = a5;
										if (268588 - 565095 == -296506)
										{
											goto IL_C23;
										}
										if (4147 - 244592 != -240445)
										{
											goto IL_C23;
										}
										Color color3 = this.BTHnxSmAiuk.normal.textColor = textColor5;
										if (214306 - 534689 == -320382 || 246366 - 235402 == 10965)
										{
											goto IL_C23;
										}
										GUILayout.Label(chatEntry.text, this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (236174 - 466855 != -230681)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (37857 - 379202 == -341344)
										{
											goto IL_C23;
										}
										GUILayout.EndHorizontal();
										if (188469 - 564571 != -376102)
										{
											goto IL_C23;
										}
									}
								}
								else if (mode == eChatMode.guild)
								{
									if (192247 - 361878 == -169630)
									{
										goto IL_C23;
									}
									if (Chat.showGuildChat)
									{
										if (197548 - 235060 == -37511)
										{
											goto IL_C23;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (207571 - 300225 != -92654)
										{
											goto IL_C23;
										}
										GUILayout.FlexibleSpace();
										if (240222 - 283731 != -43509)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.q1PnxDA51sv;
										if (199068 - 336455 == -137386)
										{
											goto IL_C23;
										}
										float a6 = num;
										if (84104 - 53619 != 30485)
										{
											goto IL_C23;
										}
										Color textColor6 = this.BTHnxSmAiuk.normal.textColor;
										if (291125 - 356792 != -65667)
										{
											goto IL_C23;
										}
										textColor6.a = a6;
										if (45876 - 426408 != -380532)
										{
											goto IL_C23;
										}
										if (239707 - 461340 != -221633)
										{
											goto IL_C23;
										}
										Color color4 = this.BTHnxSmAiuk.normal.textColor = textColor6;
										if (147400 - 505120 == -357719)
										{
											goto IL_C23;
										}
										if (10291 - 123867 != -113576)
										{
											goto IL_C23;
										}
										GUILayout.Label("[GLD]", this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (66017 - 265841 != -199824)
										{
											goto IL_C23;
										}
										GUILayout.Space((float)5);
										if (132178 - 542905 != -410727)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.gdsnx0iTIRK;
										if (249928 - 569208 != -319280)
										{
											goto IL_C23;
										}
										float a7 = num;
										if (139584 - 336339 == -196754)
										{
											goto IL_C23;
										}
										Color textColor7 = this.BTHnxSmAiuk.normal.textColor;
										if (54636 - 442175 != -387539)
										{
											goto IL_C23;
										}
										float num6 = textColor7.a = a7;
										if (31951 - 469018 == -437066 || 142469 - 291580 == -149110)
										{
											goto IL_C23;
										}
										Color color5 = this.BTHnxSmAiuk.normal.textColor = textColor7;
										if (12561 - 537700 == -525138)
										{
											goto IL_C23;
										}
										if (253839 - 46263 != 207576)
										{
											goto IL_C23;
										}
										GUILayout.Label(chatEntry.name + ":", this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (94662 - 244228 != -149566)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (248693 - 445563 != -196870)
										{
											goto IL_C23;
										}
										GUILayout.Space((float)5);
										if (126114 - 1019 == 125096)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.q1PnxDA51sv;
										if (282674 - 250007 == 32668)
										{
											goto IL_C23;
										}
										float a8 = num;
										if (228643 - 327626 == -98982)
										{
											goto IL_C23;
										}
										Color textColor8 = this.BTHnxSmAiuk.normal.textColor;
										if (100882 - 177992 != -77110)
										{
											goto IL_C23;
										}
										float num7 = textColor8.a = a8;
										if (21507 - 576067 != -554560)
										{
											goto IL_C23;
										}
										if (166363 - 180789 == -14425)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = textColor8;
										if (15934 - 123413 != -107479)
										{
											goto IL_C23;
										}
										if (181053 - 191211 == -10157)
										{
											goto IL_C23;
										}
										GUILayout.Label(chatEntry.text, this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (133219 - 48522 == 84698)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (271799 - 534913 != -263114)
										{
											goto IL_C23;
										}
										GUILayout.EndHorizontal();
										if (53824 - 413981 == -360156)
										{
											goto IL_C23;
										}
									}
								}
								else if (mode == eChatMode.whisper)
								{
									if (294913 - 390724 != -95811)
									{
										goto IL_C23;
									}
									if (Chat.showPrivateChat)
									{
										if (100392 - 543768 == -443375)
										{
											goto IL_C23;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (176300 - 347154 != -170854)
										{
											goto IL_C23;
										}
										GUILayout.FlexibleSpace();
										if (119721 - 287384 == -167662)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = new Color(0.69f, 0.29f, 0.53f, num);
										if (108752 - 278734 == -169981)
										{
											goto IL_C23;
										}
										GUILayout.Label("[WSP]", this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (244386 - 543685 != -299299)
										{
											goto IL_C23;
										}
										GUILayout.Space((float)5);
										if (222373 - 137558 != 84815)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.gdsnx0iTIRK;
										if (186036 - 114863 == 71174)
										{
											goto IL_C23;
										}
										float a9 = num;
										if (208900 - 112062 != 96838)
										{
											goto IL_C23;
										}
										Color textColor9 = this.BTHnxSmAiuk.normal.textColor;
										if (238199 - 257876 == -19676)
										{
											goto IL_C23;
										}
										textColor9.a = a9;
										if (280296 - 149353 != 130943)
										{
											goto IL_C23;
										}
										if (46826 - 422633 == -375806)
										{
											goto IL_C23;
										}
										Color color6 = this.BTHnxSmAiuk.normal.textColor = textColor9;
										if (127902 - 528313 == -400410)
										{
											goto IL_C23;
										}
										if (106999 - 45955 != 61044)
										{
											goto IL_C23;
										}
										GUILayout.Label(chatEntry.name + ":", this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (170152 - 433445 != -263293)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (81322 - 168534 == -87211)
										{
											goto IL_C23;
										}
										GUILayout.Space((float)5);
										if (221731 - 490251 != -268520)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = this.QXbnxBukavd;
										if (299083 - 567759 != -268676)
										{
											goto IL_C23;
										}
										float a10 = num;
										if (143721 - 138192 == 5530)
										{
											goto IL_C23;
										}
										Color textColor10 = this.BTHnxSmAiuk.normal.textColor;
										if (20510 - 173362 == -152851)
										{
											goto IL_C23;
										}
										float num8 = textColor10.a = a10;
										if (251352 - 456286 != -204934)
										{
											goto IL_C23;
										}
										if (252910 - 543725 == -290814)
										{
											goto IL_C23;
										}
										this.BTHnxSmAiuk.normal.textColor = textColor10;
										if (127679 - 117848 == 9832 || 129777 - 370051 == -240273)
										{
											goto IL_C23;
										}
										GUILayout.Label(chatEntry.text, this.BTHnxSmAiuk, new GUILayoutOption[0]);
										if (26077 - 325520 != -299443)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (92769 - 216146 == -123376)
										{
											goto IL_C23;
										}
										GUILayout.EndHorizontal();
										if (241847 - 479380 != -237533)
										{
											goto IL_C23;
										}
									}
								}
								else if (mode == eChatMode.system)
								{
									if (182227 - 204675 == -22447)
									{
										goto IL_C23;
									}
									if (Chat.showSystemChat)
									{
										if (56831 - 400004 != -343173)
										{
											goto IL_C23;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (16225 - 462514 == -446288)
										{
											goto IL_C23;
										}
										GUILayout.FlexibleSpace();
										if (10042 - 450155 == -440112)
										{
											goto IL_C23;
										}
										eChatType type = chatEntry.type;
										if (25066 - 341144 != -316078)
										{
											goto IL_C23;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (128958 - 237371 != -108413)
										{
											goto IL_C23;
										}
										if (type == eChatType.system)
										{
											if (177575 - 380635 != -203060)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.SZrnxo3t9Rh;
											if (97291 - 587591 != -490300)
											{
												goto IL_C23;
											}
											float a11 = num;
											if (109196 - 83386 == 25811)
											{
												goto IL_C23;
											}
											Color textColor11 = this.BTHnxSmAiuk.normal.textColor;
											if (267503 - 474576 == -207072)
											{
												goto IL_C23;
											}
											textColor11.a = a11;
											if (271969 - 87653 == 184317 || 28860 - 197676 == -168815)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = textColor11;
											if (145042 - 241793 == -96750)
											{
												goto IL_C23;
											}
											if (164891 - 488914 != -324023)
											{
												goto IL_C23;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (84876 - 255431 != -170555)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (161323 - 407556 == -246232)
											{
												goto IL_C23;
											}
										}
										else if (type == eChatType.self)
										{
											if (88142 - 334132 == -245989)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.gdsnx0iTIRK;
											if (175026 - 246219 == -71192)
											{
												goto IL_C23;
											}
											float a12 = num;
											if (194000 - 545695 == -351694)
											{
												goto IL_C23;
											}
											Color textColor12 = this.BTHnxSmAiuk.normal.textColor;
											if (105839 - 373271 != -267432)
											{
												goto IL_C23;
											}
											float num9 = textColor12.a = a12;
											if (117784 - 432535 != -314751)
											{
												goto IL_C23;
											}
											if (171815 - 538900 == -367084)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = textColor12;
											if (254454 - 389876 == -135421 || 67309 - 570615 == -503305)
											{
												goto IL_C23;
											}
											GUILayout.Label(chatEntry.name + ":", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (281275 - 430984 != -149709)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (293879 - 79147 != 214732)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.QXbnxBukavd;
											if (149430 - 417605 != -268175)
											{
												goto IL_C23;
											}
											float a13 = num;
											if (104802 - 137359 != -32557)
											{
												goto IL_C23;
											}
											Color textColor13 = this.BTHnxSmAiuk.normal.textColor;
											if (84211 - 254309 != -170098)
											{
												goto IL_C23;
											}
											textColor13.a = a13;
											if (155714 - 76849 != 78865)
											{
												goto IL_C23;
											}
											if (97539 - 497758 == -400218)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = textColor13;
											if (59106 - 448227 != -389121)
											{
												goto IL_C23;
											}
											if (212289 - 17458 == 194832)
											{
												goto IL_C23;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (225074 - 184009 == 41066)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (185541 - 517152 != -331611)
											{
												goto IL_C23;
											}
										}
										else if (type == eChatType.ally)
										{
											if (87418 - 272743 != -185325)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.n7onx8JGJmT;
											if (92399 - 457347 != -364948)
											{
												goto IL_C23;
											}
											float a14 = num;
											if (229307 - 177952 == 51356)
											{
												goto IL_C23;
											}
											Color textColor14 = this.BTHnxSmAiuk.normal.textColor;
											if (106535 - 565570 != -459035)
											{
												goto IL_C23;
											}
											textColor14.a = a14;
											if (165941 - 373075 != -207134)
											{
												goto IL_C23;
											}
											if (44128 - 293082 == -248953)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = textColor14;
											if (72659 - 85424 != -12765)
											{
												goto IL_C23;
											}
											if (9574 - 117941 == -108366)
											{
												goto IL_C23;
											}
											GUILayout.Label(chatEntry.name + ":", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (68040 - 258062 != -190022)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (90669 - 25577 != 65092)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.QXbnxBukavd;
											if (179672 - 106273 != 73399)
											{
												goto IL_C23;
											}
											float a15 = num;
											if (210801 - 439313 == -228511)
											{
												goto IL_C23;
											}
											Color textColor15 = this.BTHnxSmAiuk.normal.textColor;
											if (58070 - 341668 == -283597)
											{
												goto IL_C23;
											}
											float num10 = textColor15.a = a15;
											if (236396 - 350227 != -113831)
											{
												goto IL_C23;
											}
											if (182099 - 374731 == -192631)
											{
												goto IL_C23;
											}
											Color color7 = this.BTHnxSmAiuk.normal.textColor = textColor15;
											if (114737 - 508546 == -393808 || 14833 - 95259 == -80425)
											{
												goto IL_C23;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (77665 - 28218 == 49448)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (55275 - 224820 == -169544)
											{
												goto IL_C23;
											}
										}
										else if (type == eChatType.enemy)
										{
											if (20767 - 241917 == -221149)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.UOonxibZCHv;
											if (245572 - 10041 == 235532)
											{
												goto IL_C23;
											}
											float a16 = num;
											if (45872 - 314562 != -268690)
											{
												goto IL_C23;
											}
											Color textColor16 = this.BTHnxSmAiuk.normal.textColor;
											if (85881 - 166874 != -80993)
											{
												goto IL_C23;
											}
											float num11 = textColor16.a = a16;
											if (248935 - 497519 == -248583 || 110891 - 554111 == -443219)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = textColor16;
											if (256639 - 303476 == -46836 || 169232 - 425786 == -256553)
											{
												goto IL_C23;
											}
											GUILayout.Label(chatEntry.name + ":", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (127498 - 428357 != -300859)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (257144 - 498220 == -241075)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.QXbnxBukavd;
											if (66152 - 343907 == -277754)
											{
												goto IL_C23;
											}
											float a17 = num;
											if (149555 - 517981 != -368426)
											{
												goto IL_C23;
											}
											Color textColor17 = this.BTHnxSmAiuk.normal.textColor;
											if (180024 - 38742 != 141282)
											{
												goto IL_C23;
											}
											textColor17.a = a17;
											if (241475 - 375659 != -134184)
											{
												goto IL_C23;
											}
											if (105943 - 556315 != -450372)
											{
												goto IL_C23;
											}
											Color color8 = this.BTHnxSmAiuk.normal.textColor = textColor17;
											if (279582 - 319907 == -40324)
											{
												goto IL_C23;
											}
											if (216055 - 476171 != -260116)
											{
												goto IL_C23;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (276231 - 441638 != -165407)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (171716 - 460836 == -289119)
											{
												goto IL_C23;
											}
										}
										else if (type == eChatType.npc)
										{
											if (12849 - 392133 == -379283)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.laFnxmKRjuZ;
											if (282621 - 182407 != 100214)
											{
												goto IL_C23;
											}
											float a18 = num;
											if (6040 - 396404 != -390364)
											{
												goto IL_C23;
											}
											Color textColor18 = this.BTHnxSmAiuk.normal.textColor;
											if (184885 - 379840 == -194954)
											{
												goto IL_C23;
											}
											textColor18.a = a18;
											if (42094 - 358796 == -316701)
											{
												goto IL_C23;
											}
											if (167726 - 564472 != -396746)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = textColor18;
											if (95378 - 519514 != -424136)
											{
												goto IL_C23;
											}
											if (198050 - 539683 != -341633)
											{
												goto IL_C23;
											}
											GUILayout.Label(chatEntry.name + ":", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (137769 - 511952 == -374182)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (243138 - 140442 == 102697)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = this.QXbnxBukavd;
											if (194751 - 438648 != -243897)
											{
												goto IL_C23;
											}
											float a19 = num;
											if (258513 - 589379 != -330866)
											{
												goto IL_C23;
											}
											Color textColor19 = this.BTHnxSmAiuk.normal.textColor;
											if (154091 - 352403 == -198311)
											{
												goto IL_C23;
											}
											textColor19.a = a19;
											if (286912 - 358500 != -71588)
											{
												goto IL_C23;
											}
											if (61745 - 240559 != -178814)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = textColor19;
											if (212890 - 7113 == 205778 || 296674 - 67419 == 229256)
											{
												goto IL_C23;
											}
											GUILayout.Label(" " + chatEntry.text + " ", this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (191249 - 47111 == 144139)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (273434 - 492790 == -219355)
											{
												goto IL_C23;
											}
										}
										else if (type == eChatType.world)
										{
											if (58067 - 292006 == -233938)
											{
												goto IL_C23;
											}
											this.BTHnxSmAiuk.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
											if (291850 - 408219 != -116369)
											{
												goto IL_C23;
											}
											GUILayout.Label(chatEntry.text, this.BTHnxSmAiuk, new GUILayoutOption[0]);
											if (213256 - 44651 == 168606)
											{
												goto IL_C23;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (255940 - 440206 != -184266)
											{
												goto IL_C23;
											}
										}
										GUILayout.EndHorizontal();
										if (296516 - 37782 != 258734)
										{
											goto IL_C23;
										}
									}
								}
								else if (mode == eChatMode.world)
								{
									if (275938 - 110741 == 165198)
									{
										goto IL_C23;
									}
									GUILayout.BeginHorizontal(new GUILayoutOption[0]);
									if (213507 - 527934 != -314427)
									{
										goto IL_C23;
									}
									GUILayout.FlexibleSpace();
									if (281009 - 494301 == -213291)
									{
										goto IL_C23;
									}
									this.BTHnxSmAiuk.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
									if (155545 - 113671 == 41875)
									{
										goto IL_C23;
									}
									GUILayout.Label(chatEntry.text, this.BTHnxSmAiuk, new GUILayoutOption[0]);
									if (68867 - 238722 != -169855)
									{
										goto IL_C23;
									}
									UnityRuntimeServices.Update(enumerator, chatEntry);
									if (21826 - 27521 != -5695)
									{
										goto IL_C23;
									}
									GUILayout.EndHorizontal();
									if (106478 - 171660 != -65182)
									{
										goto IL_C23;
									}
								}
							}
							if (260135 - 237425 == 22710)
							{
								GUILayout.EndVertical();
								if (42640 - 88015 == -45375)
								{
									GUILayout.EndArea();
									if (27421 - 88135 != -60713)
									{
										if (!Chat.ChatActive)
										{
											break;
										}
										if (37021 - 138169 != -101147)
										{
											bool flag = true;
											if (20057 - 425732 == -405675)
											{
												GUI.DrawTexture(new Rect(0.5f * this.GQnnxlvlFOr - (float)157, (float)700, (float)335, (float)33), this.i64nxEEZhv0);
												if (64480 - 477969 != -413488)
												{
													if (Input.GetKeyDown(KeyCode.UpArrow))
													{
														if (149484 - 285813 != -136328)
														{
															this.EWTnxNmPtfC = Chat.switchChatModeUp(this.EWTnxNmPtfC);
															if (186777 - 364508 == -177731)
															{
																break;
															}
														}
													}
													else if (Input.GetKeyDown(KeyCode.DownArrow))
													{
														if (186388 - 39668 != 146721)
														{
															this.EWTnxNmPtfC = Chat.switchChatModeDown(this.EWTnxNmPtfC);
															if (229499 - 122906 == 106593)
															{
																break;
															}
														}
													}
													else
													{
														if (Event.current.type == EventType.KeyDown)
														{
															if (52410 - 201659 == -149248)
															{
																continue;
															}
															if (Event.current.character == "\n")
															{
																if (130580 - 326417 != -195837)
																{
																	continue;
																}
																if (Chat.ChatTimeOut <= Time.time)
																{
																	if (80185 - 165694 != -85509)
																	{
																		continue;
																	}
																	string[] array = (string[])Stringf.splitToArray(this.EWTnxNmPtfC, " ").ToBuiltin(typeof(string));
																	if (45897 - 13388 != 32509)
																	{
																		continue;
																	}
																	if (Extensions.get_length(array) > 0)
																	{
																		if (174244 - 525516 != -351272)
																		{
																			continue;
																		}
																		string a20 = array[0];
																		if (45304 - 112583 == -67278)
																		{
																			continue;
																		}
																		if (a20 == "/a")
																		{
																			if (64348 - 203822 == -139473)
																			{
																				continue;
																			}
																			Chat.ChatMode = 1;
																			if (288144 - 324794 == -36649)
																			{
																				continue;
																			}
																			this.EWTnxNmPtfC = Stringf.getString(this.EWTnxNmPtfC, 2, Extensions.get_length(this.EWTnxNmPtfC));
																			if (35159 - 588860 == -553700)
																			{
																				continue;
																			}
																		}
																		else if (a20 == "/g")
																		{
																			if (84097 - 222477 != -138380)
																			{
																				continue;
																			}
																			if (!RuntimeServices.EqualityOperator(PlayerData.GID, "none"))
																			{
																				if (265858 - 448924 == -183065)
																				{
																					continue;
																				}
																				Chat.ChatMode = 2;
																				if (21663 - 68130 != -46467)
																				{
																					continue;
																				}
																				this.EWTnxNmPtfC = Stringf.getString(this.EWTnxNmPtfC, 2, Extensions.get_length(this.EWTnxNmPtfC));
																				if (189355 - 202921 != -13566)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.newGameMessage("You are not in a guild");
																				if (186169 - 347340 != -161171)
																				{
																					continue;
																				}
																				flag = false;
																				if (200322 - 522768 == -322445)
																				{
																					continue;
																				}
																			}
																		}
																		else if (a20 == "/t")
																		{
																			if (10120 - 98998 != -88878)
																			{
																				continue;
																			}
																			this.newGameMessage("Cannot use team chat");
																			if (41332 - 142274 != -100942)
																			{
																				continue;
																			}
																			this.EWTnxNmPtfC = string.Empty;
																			if (202112 - 388354 != -186242)
																			{
																				continue;
																			}
																		}
																		else if (a20 == "/w")
																		{
																			if (164289 - 525024 == -360734)
																			{
																				continue;
																			}
																			Chat.ChatMode = 4;
																			if (176926 - 340228 != -163302)
																			{
																				continue;
																			}
																			this.EWTnxNmPtfC = Stringf.getString(this.EWTnxNmPtfC, 3, Extensions.get_length(this.EWTnxNmPtfC));
																			if (2912 - 161742 == -158829)
																			{
																				continue;
																			}
																			if (Extensions.get_length(array) > 1)
																			{
																				if (225282 - 78934 != 146348)
																				{
																					continue;
																				}
																				int buddyID = PlayerData.getBuddyID(array[1]);
																				if (247041 - 597035 == -349993)
																				{
																					continue;
																				}
																				if (buddyID != 0)
																				{
																					if (38811 - 327985 != -289174)
																					{
																						continue;
																					}
																					Chat.TargetID = buddyID;
																					if (198935 - 286654 != -87719)
																					{
																						continue;
																					}
																					this.EWTnxNmPtfC = Stringf.getString(this.EWTnxNmPtfC, Extensions.get_length(array[1]) + 1, Extensions.get_length(this.EWTnxNmPtfC));
																					if (58024 - 319779 == -261754)
																					{
																						continue;
																					}
																				}
																			}
																		}
																	}
																	if (flag)
																	{
																		if (10597 - 87707 != -77110)
																		{
																			continue;
																		}
																		if (this.EWTnxNmPtfC.Length > 0)
																		{
																			if (182136 - 475829 == -293692)
																			{
																				continue;
																			}
																			if (Chat.ChatMode == 4)
																			{
																				if (134837 - 325032 != -190195)
																				{
																					continue;
																				}
																				if (Chat.TargetID == 0)
																				{
																					if (151921 - 335788 == -183866)
																					{
																						continue;
																					}
																					this.newGameMessage("Whisper target not found!");
																					if (189552 - 148270 != 41283)
																					{
																						goto IL_1EA7;
																					}
																					continue;
																				}
																			}
																			Chat.SubmitChat(PlayerData.User, this.EWTnxNmPtfC, eChatType.self, (eChatMode)Chat.ChatMode);
																			if (21936 - 413573 != -391637)
																			{
																				continue;
																			}
																		}
																	}
																	IL_1EA7:
																	this.EWTnxNmPtfC = string.Empty;
																	if (227565 - 40983 != 186582)
																	{
																		continue;
																	}
																	Chat.ChatTimeOut = Time.time + 0.5f;
																	if (154349 - 457016 == -302666)
																	{
																		continue;
																	}
																	Chat.ChatActive = false;
																	if (208355 - 305453 != -97097)
																	{
																		break;
																	}
																	continue;
																}
															}
														}
														GUI.SetNextControlName("ChatBarField");
														if (80834 - 398922 == -318088)
														{
															this.EWTnxNmPtfC = GUI.TextField(new Rect(0.5f * this.GQnnxlvlFOr - (float)150, (float)700, (float)300, (float)30), this.EWTnxNmPtfC, 36, this.lnMnxPT58dA);
															if (153241 - 45090 == 108151)
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

	// Token: 0x0600BFE8 RID: 49128 RVA: 0x01445564 File Offset: 0x01443764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGameMessage()
	{
		if (17215 - 551331 != -534115)
		{
		}
		for (;;)
		{
			this.qaFnxAeYrsu = new GUIStyle();
			if (74373 - 429794 == -355421)
			{
				this.qaFnxAeYrsu.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
				if (134822 - 575991 == -441169)
				{
					this.qaFnxAeYrsu.normal.textColor = new Color(0.8f, 0.2f, 0.1f, 0.8f);
					if (68677 - 101779 != -33101)
					{
						this.qaFnxAeYrsu.alignment = TextAnchor.MiddleCenter;
						if (201564 - 153990 == 47574)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFE9 RID: 49129 RVA: 0x01445668 File Offset: 0x01443868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGameMessege()
	{
		if (213590 - 567845 != -354254)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (165781 - 93688 != 72094)
				{
					break;
				}
			}
			else
			{
				if (this.zTZnxF4tGn0 + (float)2 <= Time.time)
				{
					break;
				}
				if (291309 - 471934 == -180625)
				{
					GUI.Label(new Rect(0.5f * this.GQnnxlvlFOr - (float)250, (float)260, (float)500, (float)40), this.YacnxksOlNC, this.qaFnxAeYrsu);
					if (236565 - 363195 != -126629)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BFEA RID: 49130 RVA: 0x01445750 File Offset: 0x01443950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newGameMessage(string Message)
	{
		this.YacnxksOlNC = Message;
		this.zTZnxF4tGn0 = Time.time;
	}

	// Token: 0x0600BFEB RID: 49131 RVA: 0x01445764 File Offset: 0x01443964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600BFEC RID: 49132 RVA: 0x01445768 File Offset: 0x01443968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600BFED RID: 49133 RVA: 0x0144576C File Offset: 0x0144396C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (266624 - 314939 != -48315)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (273112 - 82745 != 190368)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (195593 - 142106 != 53488)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (21824 - 573305 != -551480)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (124763 - 310567 == -185804)
						{
							int num4 = num;
							if (19065 - 478765 == -459700)
							{
								if (num4 == 9911)
								{
									if (109467 - 251114 != -141646)
									{
										if (Game.mGameState <= eGameState.Ready)
										{
											if (255316 - 472714 == -217398)
											{
												this.oGPnxWcKH7j++;
												if (1788 - 104870 == -103082)
												{
													Chat.SubmitChat("none", "Player has join team1: " + this.oGPnxWcKH7j, eChatType.system, eChatMode.system);
													if (17101 - 136801 != -119699)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.gw5nxyHZKCJ--;
											if (130884 - 523428 == -392544)
											{
												Chat.SubmitChat("none", "Team1 has revived: " + this.gw5nxyHZKCJ + "/" + this.oGPnxWcKH7j, eChatType.system, eChatMode.system);
												if (224542 - 189045 != 35498)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 9912)
								{
									if (239565 - 343593 != -104027)
									{
										if (Game.mGameState <= eGameState.Ready)
										{
											if (244265 - 269830 == -25565)
											{
												this.CBYnxuvuEWN++;
												if (7244 - 194736 != -187491)
												{
													Chat.SubmitChat("none", "Player has join team2: " + this.CBYnxuvuEWN, eChatType.system, eChatMode.system);
													if (189301 - 496603 != -307301)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.gi5nxVTRxp3--;
											if (57018 - 516874 != -459855)
											{
												Chat.SubmitChat("none", "Team2 has revived: " + this.gi5nxVTRxp3 + "/" + this.CBYnxuvuEWN, eChatType.system, eChatMode.system);
												if (166750 - 300194 != -133443)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 9913)
								{
									if (156653 - 188230 != -31576)
									{
										this.gw5nxyHZKCJ++;
										if (151455 - 261441 != -109985)
										{
											Debug.Log("Team1 Dead: " + this.gw5nxyHZKCJ);
											if (156558 - 576378 != -419819)
											{
												this.SendMessage("newGameMessage", "Team1 Dead! :" + this.gw5nxyHZKCJ + "/" + this.oGPnxWcKH7j);
												if (56526 - 263232 == -206706)
												{
													Chat.SubmitChat("none", "Team1 Dead! :" + this.gw5nxyHZKCJ + "/" + this.oGPnxWcKH7j, eChatType.system, eChatMode.system);
													if (20807 - 456805 == -435998)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9914)
								{
									if (178924 - 304991 != -126066)
									{
										this.gi5nxVTRxp3++;
										if (7842 - 551833 != -543990)
										{
											Debug.Log("Team2 Dead: " + this.gi5nxVTRxp3);
											if (292185 - 278368 != 13818)
											{
												this.SendMessage("newGameMessage", "Team2 Dead! :" + this.gi5nxVTRxp3 + "/" + this.CBYnxuvuEWN);
												if (166186 - 496136 != -329949)
												{
													Chat.SubmitChat("none", "Team2 Dead! :" + this.gi5nxVTRxp3 + "/" + this.CBYnxuvuEWN, eChatType.system, eChatMode.system);
													if (128665 - 228225 == -99560)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9915)
								{
									if (78588 - 272948 == -194360)
									{
										break;
									}
								}
								else
								{
									if (num4 != 9916)
									{
										break;
									}
									if (237834 - 580483 != -342648)
									{
										Debug.Log("Gm has started the match!");
										if (242758 - 357091 != -114332)
										{
											Game.mGameState = eGameState.Start;
											if (40671 - 503511 != -462839)
											{
												Game.mGameTime = Time.time;
												if (172644 - 51774 == 120870)
												{
													Game.mStateTime = Time.time;
													if (134393 - 278772 != -144378)
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

	// Token: 0x0600BFEE RID: 49134 RVA: 0x01445E20 File Offset: 0x01444020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M991_ChampionshipArena.$onGameComplete$47535(data, this).GetEnumerator();
	}

	// Token: 0x0600BFEF RID: 49135 RVA: 0x01445E30 File Offset: 0x01444030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (68521 - 431049 != -362528)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (67180 - 460087 == -392907)
			{
				Hashtable customOpParameters = new Hashtable();
				if (71273 - 364156 != -292882)
				{
					this.AZ3nxX6xmWP.OpCustom(52, customOpParameters, true);
					if (27881 - 384643 != -356761)
					{
						this.iWLnx1fJ7wb = (Texture)Resources.Load("GameGui/Title/ready", typeof(Texture));
						if (83935 - 13634 == 70301)
						{
							this.Mr1nxqT8FcY = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (116112 - 512933 != -396820)
							{
								this.gCNnxpQXJNK = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
								if (81080 - 336484 != -255403)
								{
									this.uConxRCg5MD = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
									if (182099 - 217054 == -34955)
									{
										this.famnxrAskaM = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
										if (198178 - 44682 != 153497)
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

	// Token: 0x0600BFF0 RID: 49136 RVA: 0x01445FF4 File Offset: 0x014441F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (107795 - 334551 != -226756)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (47246 - 338258 == -291012)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (102074 - 577059 == -474985)
				{
					Game.mGameState = eGameState.Setup;
					if (128415 - 561367 == -432952)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BFF1 RID: 49137 RVA: 0x01446098 File Offset: 0x01444298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (37827 - 148407 != -110579)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (38286 - 142221 != -103934)
			{
				if (num == PlayerData.UID)
				{
					if (141870 - 15174 == 126696)
					{
						this.SetupActors();
						if (225510 - 131254 != 94257)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (3908 - 434222 == -430314)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BFF2 RID: 49138 RVA: 0x01446168 File Offset: 0x01444368
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (23314 - 374380 != -351066)
		{
		}
		for (;;)
		{
			IL_A6:
			Debug.Log("Creating Actors");
			if (215537 - 331725 != -116187)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (57296 - 528790 == -471494)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (31986 - 34349 != -2362)
						{
							int i = 0;
							if (105976 - 64743 != 41234)
							{
								CharacterControl[] array2 = array;
								if (266026 - 484909 != -218882)
								{
									int length = array2.Length;
									if (213101 - 162713 != 50389)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (72126 - 180020 != -107894)
											{
												goto IL_A6;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (29710 - 167542 == -137831)
											{
												goto IL_A6;
											}
											this.ttpnxh3trqt++;
											if (172704 - 210399 == -37694)
											{
												goto IL_A6;
											}
											i++;
											if (141118 - 49108 != 92010)
											{
												goto IL_A6;
											}
										}
										if (29175 - 143109 != -113933)
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
						if (103547 - 252123 == -148576)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFF3 RID: 49139 RVA: 0x01446380 File Offset: 0x01444580
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (55059 - 211689 != -156630)
		{
		}
		for (;;)
		{
			IL_A0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (46982 - 510848 == -463866)
			{
				int i = 0;
				if (48005 - 443690 != -395684)
				{
					CharacterControl[] array2 = array;
					if (82760 - 510260 == -427500)
					{
						int length = array2.Length;
						if (196442 - 62214 != 134229)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (129212 - 461639 == -332426)
								{
									goto IL_A0;
								}
								i++;
								if (181745 - 533320 != -351575)
								{
									goto IL_A0;
								}
							}
							if (268115 - 471286 == -203171)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFF4 RID: 49140 RVA: 0x014464B0 File Offset: 0x014446B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (227080 - 445084 != -218004)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (160203 - 294939 != -134735)
			{
				hashtable.Add(43, PlayerData.UID);
				if (148334 - 222079 == -73745)
				{
					hashtable.Add(73, nType);
					if (116538 - 442409 == -325871)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (229634 - 120045 == 109589)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (193423 - 463624 == -270201)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (38650 - 549554 != -510903)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (62189 - 487166 == -424977)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (71213 - 309779 == -238566)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (4941 - 73070 == -68129)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (218465 - 12259 == 206206)
												{
													this.AZ3nxX6xmWP.OpCustom(63, hashtable, true);
													if (11870 - 493019 != -481148)
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

	// Token: 0x0600BFF5 RID: 49141 RVA: 0x01446768 File Offset: 0x01444968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (245102 - 18785 != 226318)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (159077 - 254605 != -95527)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (157778 - 578706 != -420927)
				{
					if (gameObject)
					{
						if (47160 - 422331 != -375171)
						{
							continue;
						}
						this.createTeamRing(gameObject);
						if (131147 - 424714 == -293566)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (201954 - 336670 == -134716)
						{
							if (this.ttpnxh3trqt <= 0)
							{
								break;
							}
							if (68524 - 140100 == -71576)
							{
								this.ttpnxh3trqt--;
								if (207848 - 152695 == 55153)
								{
									if (this.ttpnxh3trqt != 0)
									{
										break;
									}
									if (155415 - 516899 != -361483)
									{
										Game.setGameState(eGameState.Ready);
										if (104261 - 85343 == 18918)
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
						if (173472 - 37001 == 136471)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (261118 - 278736 != -17617)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFF6 RID: 49142 RVA: 0x01446940 File Offset: 0x01444B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (21767 - 88674 != -66906)
		{
		}
		while (Game.mGameState < eGameState.Ready)
		{
			if (293335 - 265431 != 27905)
			{
				Debug.Log("Game Ready");
				if (85632 - 118677 == -33045)
				{
					Game.mGameState = eGameState.Ready;
					if (254019 - 13289 != 240731)
					{
						Game.mStateTime = Time.time;
						if (98272 - 355848 != -257575)
						{
							int num = Game.getPlayerSlot(PlayerData.UID) - 1;
							if (162648 - 17446 == 145202)
							{
								if (100812 - 313154 != -212341)
								{
									GameObject gameObject = null;
									if (246653 - 420255 != -173601)
									{
										if (num < 0)
										{
											goto IL_32B;
										}
										if (52030 - 105317 != -53287)
										{
											continue;
										}
										if (num > 10)
										{
											goto IL_32B;
										}
										if (248269 - 479817 != -231548)
										{
											continue;
										}
										GameObject gameObject2 = GameObject.Find("StartPoint" + num);
										if (296518 - 573488 != -276970)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + num);
										if (50485 - 554073 != -503588)
										{
											continue;
										}
										IL_242:
										MissionClass data2 = MissionData.getData(991);
										if (94163 - 374959 == -280795)
										{
											continue;
										}
										if (num == 0)
										{
											if (81972 - 461560 == -379587)
											{
												continue;
											}
											this.dO1nxGHp3hq = gameObject;
											if (138596 - 398675 != -260079)
											{
												continue;
											}
											this.StartObserver();
											if (289150 - 389104 != -99953)
											{
												break;
											}
											continue;
										}
										else
										{
											int num2 = (num - 1) % 2 + 1;
											if (138623 - 260296 != -121673)
											{
												continue;
											}
											if (gameObject2)
											{
												if (254747 - 582803 != -328056)
												{
													continue;
												}
												this.CreatePlayer(CharacterData.current.CID, num2, gameObject2.transform.position, gameObject2.transform.forward);
												if (210736 - 296356 != -85620)
												{
													continue;
												}
											}
											if (gameObject)
											{
												if (143186 - 246460 != -103274)
												{
													continue;
												}
												this.transform.position = gameObject.transform.position;
												if (90042 - 176350 != -86308)
												{
													continue;
												}
												this.transform.rotation = gameObject.transform.rotation;
												if (88871 - 430026 == -341154)
												{
													continue;
												}
											}
											if (num2 == 1)
											{
												if (123443 - 343916 == -220472)
												{
													continue;
												}
												Game.sendMissionEvent(9911, 0);
												if (263555 - 141585 != 121970)
												{
													continue;
												}
												break;
											}
											else
											{
												Game.sendMissionEvent(9912, 0);
												if (295470 - 94401 != 201070)
												{
													break;
												}
												continue;
											}
										}
										IL_32B:
										gameObject2 = GameObject.Find("StartPoint1");
										if (114210 - 559402 == -445192)
										{
											goto IL_242;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BFF7 RID: 49143 RVA: 0x01446D3C File Offset: 0x01444F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartObserver()
	{
		if (22669 - 439607 != -416938)
		{
		}
		for (;;)
		{
			Debug.Log("Start Observer");
			if (257121 - 21734 == 235387)
			{
				this.InitObserverMenu();
				if (204586 - 142714 != 61873)
				{
					this.InitTeamBar();
					if (59281 - 135061 != -75779)
					{
						this.InitChatBar();
						if (73161 - 448118 != -374956)
						{
							this.InitGameMessage();
							if (260181 - 343154 == -82973)
							{
								this.MBxnxvB4LNN = true;
								if (215842 - 175154 == 40688)
								{
									Game.mGameState = eGameState.Ready;
									if (145027 - 446176 == -301149)
									{
										Game.mGameTime = Time.time;
										if (8246 - 265282 != -257035)
										{
											Game.mStateTime = Time.time;
											if (130221 - 81693 != 48529)
											{
												Time.timeScale = 1f;
												if (265560 - 275688 != -10127)
												{
													LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
													if (282259 - 580519 == -298260)
													{
														loadingGui.fadeIn();
														if (297364 - 561401 == -264037)
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

	// Token: 0x0600BFF8 RID: 49144 RVA: 0x01446F18 File Offset: 0x01445118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (91802 - 5025 != 86777)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (179732 - 231914 != -52181)
			{
				Game.mGameState = eGameState.Ready;
				if (167780 - 562475 != -394694)
				{
					Game.mGameTime = Time.time;
					if (143690 - 351589 != -207898)
					{
						Game.mStateTime = Time.time;
						if (80012 - 496068 == -416056)
						{
							Time.timeScale = 1f;
							if (242459 - 443983 != -201523)
							{
								GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
								if (256293 - 86717 != 169577)
								{
									gameGui.enabled = true;
									if (246113 - 394525 == -148412)
									{
										LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
										if (167907 - 299551 != -131643)
										{
											loadingGui.fadeIn();
											if (115773 - 492880 != -377106)
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

	// Token: 0x0600BFF9 RID: 49145 RVA: 0x014470A4 File Offset: 0x014452A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BFFA RID: 49146 RVA: 0x014470A8 File Offset: 0x014452A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (139645 - 30365 != 109281)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (66876 - 74277 != -7400)
			{
				hashtable.Add(71, CID);
				if (41908 - 341541 == -299633)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (140739 - 157700 != -16960)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (139249 - 471274 != -332024)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (72937 - 497446 == -424509)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (258287 - 36783 == 221504)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (279258 - 29553 != 249706)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (84497 - 452376 == -367879)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (87516 - 504850 != -417333)
											{
												this.AZ3nxX6xmWP.OpCustom(61, hashtable, true);
												if (59607 - 20585 != 39023)
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

	// Token: 0x0600BFFB RID: 49147 RVA: 0x01447334 File Offset: 0x01445534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (30208 - 552563 != -522355)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (285376 - 493620 == -208244)
			{
				if (!gameObject)
				{
					break;
				}
				if (171890 - 177877 != -5986)
				{
					this.createTeamRing(gameObject);
					if (69175 - 468238 != -399062)
					{
						this.rXnnxOFdH2D.target = gameObject;
						if (108586 - 213558 == -104972)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (257076 - 487061 == -229985)
								{
									this.StartGame();
									if (7569 - 90241 != -82671)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (237428 - 228763 != 8666)
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

	// Token: 0x0600BFFC RID: 49148 RVA: 0x01447464 File Offset: 0x01445664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (169666 - 354537 != -184870)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (237756 - 63973 != 173784)
			{
				if (!gameObject)
				{
					break;
				}
				if (208572 - 254469 == -45897)
				{
					this.createTeamRing(gameObject);
					if (72993 - 198464 != -125470)
					{
						if (this.MBxnxvB4LNN)
						{
							if (26621 - 235873 == -209252)
							{
								this.ResetTeamBar();
								if (9618 - 380128 != -370509)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (219972 - 65562 == 154410)
							{
								gameGui.ResetTeamBar();
								if (113331 - 279292 != -165960)
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

	// Token: 0x0600BFFD RID: 49149 RVA: 0x014475A0 File Offset: 0x014457A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSummon(GameObject nSummon)
	{
		this.createTeamRing(nSummon);
	}

	// Token: 0x0600BFFE RID: 49150 RVA: 0x014475AC File Offset: 0x014457AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createTeamRing(GameObject nObject)
	{
		if (280985 - 300144 != -19158)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (71456 - 526158 != -454701)
			{
				int layer = nObject.layer;
				if (46603 - 498538 != -451934)
				{
					if (layer == 8)
					{
						if (20118 - 42206 != -22088)
						{
							continue;
						}
						if (this.ring_team1)
						{
							if (4167 - 163081 == -158913)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team1, nObject.transform.position, Quaternion.identity);
							if (43336 - 198503 == -155166)
							{
								continue;
							}
						}
					}
					else if (this.ring_team2)
					{
						if (277027 - 73436 != 203591)
						{
							continue;
						}
						gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team2, nObject.transform.position, Quaternion.identity);
						if (144147 - 438031 != -293884)
						{
							continue;
						}
					}
					if (!gameObject)
					{
						break;
					}
					if (212789 - 462481 != -249691)
					{
						gameObject.transform.parent = nObject.transform;
						if (30521 - 26999 != 3523)
						{
							gameObject.transform.localPosition = Vector3.zero;
							if (103435 - 59703 != 43733)
							{
								if (!nObject.collider)
								{
									break;
								}
								if (206664 - 577601 != -370936)
								{
									gameObject.transform.localScale = Vector3.one * nObject.collider.bounds.size.z;
									if (104249 - 142589 != -38339)
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

	// Token: 0x0600BFFF RID: 49151 RVA: 0x01447804 File Offset: 0x01445A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDeadPlayer()
	{
		if (192541 - 91006 != 101536)
		{
		}
		for (;;)
		{
			Debug.Log("On Dead Player");
			if (131888 - 445414 == -313526)
			{
				if (!Game.mPlayer)
				{
					break;
				}
				if (253950 - 571199 != -317248)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (3479 - 285532 != -282052)
					{
						if (!characterControl)
						{
							break;
						}
						if (287778 - 127360 != 160419)
						{
							if (characterControl.mOriginalLayer == 8)
							{
								if (142437 - 66232 == 76205)
								{
									Game.sendMissionEvent(9913, 0);
									if (292493 - 524914 == -232421)
									{
										break;
									}
								}
							}
							else
							{
								Game.sendMissionEvent(9914, 0);
								if (283330 - 470818 == -187488)
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

	// Token: 0x0600C000 RID: 49152 RVA: 0x01447958 File Offset: 0x01445B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (82962 - 370711 != -287749)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (100757 - 171676 != -70918)
			{
				if (Game.mPlayer)
				{
					if (244343 - 193734 != 50609)
					{
						continue;
					}
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (72478 - 528887 != -456409)
					{
						continue;
					}
					if (characterControl)
					{
						if (176835 - 229338 != -52503)
						{
							continue;
						}
						if (characterControl.mOriginalLayer == 8)
						{
							if (75269 - 542883 != -467614)
							{
								continue;
							}
							Game.sendMissionEvent(9911, 0);
							if (70036 - 403824 == -333787)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(9912, 0);
							if (107269 - 294633 == -187363)
							{
								continue;
							}
						}
					}
				}
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (26158 - 17291 == 8867)
				{
					playerCameraControl.target = Game.mPlayer;
					if (195899 - 81326 == 114573)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (124344 - 363994 == -239649)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (270238 - 203385 == 66854)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (211811 - 315150 == -103339)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (222414 - 599075 == -376661)
							{
								if (!gameGui)
								{
									break;
								}
								if (7788 - 531866 == -524078)
								{
									gameGui.enabled = true;
									if (169781 - 444109 == -274328)
									{
										gameGui.closeDeadMenu();
										if (106326 - 452587 != -346260)
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

	// Token: 0x0600C001 RID: 49153 RVA: 0x01447C00 File Offset: 0x01445E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (65197 - 167053 != -101855)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (166038 - 409222 != -243183)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (204976 - 220892 == -15916)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (118068 - 313140 != -195071)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C002 RID: 49154 RVA: 0x01447CC4 File Offset: 0x01445EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (179587 - 199858 != -20270)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (35574 - 289978 == -254404)
				{
					Game.mGameState = eGameState.Ended;
					if (276185 - 111654 != 164532)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (33706 - 365001 == -331295)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600C003 RID: 49155 RVA: 0x01447D7C File Offset: 0x01445F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M991_ChampionshipArena.$ReturnToTown$47543(this).GetEnumerator();
	}

	// Token: 0x0600C004 RID: 49156 RVA: 0x01447D8C File Offset: 0x01445F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (168528 - 150335 != 18194)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (10439 - 589736 != -579296)
			{
				Hashtable hashtable = new Hashtable();
				if (33296 - 204580 == -171284)
				{
					hashtable.Add(43, PlayerData.UID);
					if (236361 - 359198 != -122836)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (75500 - 14874 == 60626)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C005 RID: 49157 RVA: 0x01447E64 File Offset: 0x01446064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600C006 RID: 49158 RVA: 0x01447E78 File Offset: 0x01446078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (30948 - 499472 != -468523)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (97800 - 33905 != 63896)
			{
				Hashtable hashtable = new Hashtable();
				if (19385 - 534995 != -515609)
				{
					if (Game.mNextGameCode == 30)
					{
						if (18825 - 205725 == -186899)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (114829 - 571892 != -457063)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (183137 - 61590 != 121547)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (262961 - 163021 != 99940)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (51330 - 553239 == -501908)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (64522 - 274883 != -210361)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (113131 - 109978 != 3153)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (40323 - 31665 == 8659)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (80772 - 83110 == -2337)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (242291 - 530876 == -288584)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (179748 - 217293 == -37544)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (76477 - 478734 != -402257)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (166977 - 507021 == -340043)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (290949 - 346392 == -55442)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (61615 - 588937 != -527322)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (96449 - 467326 == -370876)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (75706 - 298311 == -222604)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (277080 - 298194 != -21114)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (53942 - 175604 == -121661)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (240009 - 519688 != -279679)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (50423 - 341432 != -291009)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (243037 - 515783 != -272746)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (165402 - 228708 != -63305)
					{
						this.AZ3nxX6xmWP.OpCustom(42, hashtable, true);
						if (171717 - 134762 != 36956)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C007 RID: 49159 RVA: 0x01448324 File Offset: 0x01446524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C008 RID: 49160 RVA: 0x01448334 File Offset: 0x01446534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C009 RID: 49161 RVA: 0x01448338 File Offset: 0x01446538
	internal static bool pWuoectWnW9QOkjUXS8Y()
	{
		return true;
	}

	// Token: 0x0600C00A RID: 49162 RVA: 0x0144833C File Offset: 0x0144653C
	internal static bool EtG1ZEtW6Trpj7xdbUnA()
	{
		return false;
	}

	// Token: 0x0400A38E RID: 41870
	private LitePeer AZ3nxX6xmWP;

	// Token: 0x0400A38F RID: 41871
	private PlayerCameraControl rXnnxOFdH2D;

	// Token: 0x0400A390 RID: 41872
	private float mQSnx27RWmO;

	// Token: 0x0400A391 RID: 41873
	private bool MBxnxvB4LNN;

	// Token: 0x0400A392 RID: 41874
	private float GQnnxlvlFOr;

	// Token: 0x0400A393 RID: 41875
	private GameObject dO1nxGHp3hq;

	// Token: 0x0400A394 RID: 41876
	private Texture iWLnx1fJ7wb;

	// Token: 0x0400A395 RID: 41877
	private Texture Mr1nxqT8FcY;

	// Token: 0x0400A396 RID: 41878
	private Texture gCNnxpQXJNK;

	// Token: 0x0400A397 RID: 41879
	private Texture uConxRCg5MD;

	// Token: 0x0400A398 RID: 41880
	private Texture famnxrAskaM;

	// Token: 0x0400A399 RID: 41881
	private Texture y2Inxx90Er0;

	// Token: 0x0400A39A RID: 41882
	private Texture IA8nxTdbNbR;

	// Token: 0x0400A39B RID: 41883
	private Texture edpnxYhSuYi;

	// Token: 0x0400A39C RID: 41884
	private GUIStyle pA8nx3x8nf1;

	// Token: 0x0400A39D RID: 41885
	private GUIStyle gHinxbsqOlN;

	// Token: 0x0400A39E RID: 41886
	private bool J1wnxd2iIBD;

	// Token: 0x0400A39F RID: 41887
	private AudioClip JMynxg9l8ym;

	// Token: 0x0400A3A0 RID: 41888
	private AudioClip ngNnxa9CpOQ;

	// Token: 0x0400A3A1 RID: 41889
	private GUIStyle M2anx44upO9;

	// Token: 0x0400A3A2 RID: 41890
	private GUIStyle l9qnxsWZb8v;

	// Token: 0x0400A3A3 RID: 41891
	private Texture Ek1nxHsss5G;

	// Token: 0x0400A3A4 RID: 41892
	private Texture ufdnx7Y1F4k;

	// Token: 0x0400A3A5 RID: 41893
	private Texture S7vnxZCiwaV;

	// Token: 0x0400A3A6 RID: 41894
	private Texture qNBnxCaSAsv;

	// Token: 0x0400A3A7 RID: 41895
	private Texture aePnxMW43cv;

	// Token: 0x0400A3A8 RID: 41896
	private CharacterControl[] lLInxfc5JuV;

	// Token: 0x0400A3A9 RID: 41897
	private Texture[] vI5nxL9yT1r;

	// Token: 0x0400A3AA RID: 41898
	private CharacterControl[] LWCnxwiLdvx;

	// Token: 0x0400A3AB RID: 41899
	private Texture[] earnxUOaqYx;

	// Token: 0x0400A3AC RID: 41900
	private string EWTnxNmPtfC;

	// Token: 0x0400A3AD RID: 41901
	private Texture i64nxEEZhv0;

	// Token: 0x0400A3AE RID: 41902
	private GUIStyle lnMnxPT58dA;

	// Token: 0x0400A3AF RID: 41903
	private GUIStyle BTHnxSmAiuk;

	// Token: 0x0400A3B0 RID: 41904
	private Color QXbnxBukavd;

	// Token: 0x0400A3B1 RID: 41905
	private Color gdsnx0iTIRK;

	// Token: 0x0400A3B2 RID: 41906
	private Color n7onx8JGJmT;

	// Token: 0x0400A3B3 RID: 41907
	private Color UOonxibZCHv;

	// Token: 0x0400A3B4 RID: 41908
	private Color q1PnxDA51sv;

	// Token: 0x0400A3B5 RID: 41909
	private Color laFnxmKRjuZ;

	// Token: 0x0400A3B6 RID: 41910
	private Color JgDnxjRAI9V;

	// Token: 0x0400A3B7 RID: 41911
	private Color SZrnxo3t9Rh;

	// Token: 0x0400A3B8 RID: 41912
	private string YacnxksOlNC;

	// Token: 0x0400A3B9 RID: 41913
	private float zTZnxF4tGn0;

	// Token: 0x0400A3BA RID: 41914
	private GUIStyle qaFnxAeYrsu;

	// Token: 0x0400A3BB RID: 41915
	private int DChnx9Yo2k0;

	// Token: 0x0400A3BC RID: 41916
	private int oGPnxWcKH7j;

	// Token: 0x0400A3BD RID: 41917
	private int CBYnxuvuEWN;

	// Token: 0x0400A3BE RID: 41918
	private int gw5nxyHZKCJ;

	// Token: 0x0400A3BF RID: 41919
	private int gi5nxVTRxp3;

	// Token: 0x0400A3C0 RID: 41920
	private int ttpnxh3trqt;

	// Token: 0x0400A3C1 RID: 41921
	public GameObject ring_team1;

	// Token: 0x0400A3C2 RID: 41922
	public GameObject ring_team2;

	// Token: 0x0200200B RID: 8203
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47535 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C00B RID: 49163 RVA: 0x01448340 File Offset: 0x01446540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47535(Hashtable data, M991_ChampionshipArena self_)
		{
			if (148072 - 580133 != -432061)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56465 - 356878 != -300412)
				{
					base..ctor();
					if (66162 - 262864 != -196701)
					{
						this.$data$47541 = data;
						if (253741 - 177731 == 76010)
						{
							this.$self_$47542 = self_;
							if (1805 - 556333 != -554527)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C00C RID: 49164 RVA: 0x014483FC File Offset: 0x014465FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M991_ChampionshipArena.$onGameComplete$47535.$(this.$data$47541, this.$self_$47542);
		}

		// Token: 0x0600C00D RID: 49165 RVA: 0x01448410 File Offset: 0x01446610
		internal static bool vb9osYtWi4B5eAdoHukH()
		{
			return true;
		}

		// Token: 0x0600C00E RID: 49166 RVA: 0x01448414 File Offset: 0x01446614
		internal static bool AieIvytWKnyc2DxVtYLg()
		{
			return false;
		}

		// Token: 0x0400A3C3 RID: 41923
		internal Hashtable $data$47541;

		// Token: 0x0400A3C4 RID: 41924
		internal M991_ChampionshipArena $self_$47542;

		// Token: 0x0200200C RID: 8204
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C00F RID: 49167 RVA: 0x01448418 File Offset: 0x01446618
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M991_ChampionshipArena self_)
			{
				if (273749 - 572484 != -298734)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83817 - 234706 != -150888)
					{
						base..ctor();
						if (35797 - 246970 == -211173)
						{
							this.$data$47539 = data;
							if (29293 - 210738 != -181444)
							{
								this.$self_$47540 = self_;
								if (273091 - 24317 == 248774)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C010 RID: 49168 RVA: 0x014484D4 File Offset: 0x014466D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161643 - 491313 != -329670)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2B7;
					case 2:
						this.$mCompleteGui$47537 = (CompleteGui)this.$self_$47540.GetComponent(typeof(CompleteGui));
						if (153071 - 515336 == -362264)
						{
							continue;
						}
						this.$mCompleteGui$47537.Init();
						if (73783 - 160150 != -86367)
						{
							continue;
						}
						this.$mCompleteGui$47537.readData(this.$data$47539);
						if (42140 - 403704 != -361564)
						{
							continue;
						}
						if (this.$result$47536 == 1)
						{
							if (197924 - 85696 == 112229)
							{
								continue;
							}
							this.$mCompleteGui$47537.displayResult(eCompleteType.Success);
							if (40316 - 382690 == -342373)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47537.displayResult(eCompleteType.Failed);
							if (43829 - 140979 == -97149)
							{
								continue;
							}
						}
						this.$mGameGui$47538 = (GameGui)this.$self_$47540.GetComponent(typeof(GameGui));
						if (140205 - 236556 != -96351)
						{
							continue;
						}
						this.$mGameGui$47538.close();
						if (244929 - 311533 != -66603)
						{
							goto IL_F1;
						}
						continue;
					default:
						if (73347 - 477702 != -404355)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (25898 - 374780 != -348881)
						{
							break;
						}
						continue;
					}
					else if (this.$self_$47540.MBxnxvB4LNN)
					{
						if (191808 - 285475 != -93667)
						{
							continue;
						}
						Debug.Log("Game Complete");
						if (97435 - 360242 != -262807)
						{
							continue;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (36162 - 237024 != -200862)
						{
							continue;
						}
						this.$result$47536 = RuntimeServices.UnboxInt32(this.$data$47539[31]);
						if (156865 - 159425 != -2559)
						{
							goto Block_18;
						}
						continue;
					}
					IL_F1:
					this.YieldDefault(1);
				}
				while (257678 - 9766 != 247912);
				goto IL_2B7;
				Block_18:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2B7:
				return false;
			}

			// Token: 0x0600C011 RID: 49169 RVA: 0x014487AC File Offset: 0x014469AC
			internal static bool nrOCeEtWdssZukHpYuIO()
			{
				return true;
			}

			// Token: 0x0600C012 RID: 49170 RVA: 0x014487B0 File Offset: 0x014469B0
			internal static bool cnGy60tWJdOQKVOUcwN4()
			{
				return false;
			}

			// Token: 0x0400A3C5 RID: 41925
			internal int $result$47536;

			// Token: 0x0400A3C6 RID: 41926
			internal CompleteGui $mCompleteGui$47537;

			// Token: 0x0400A3C7 RID: 41927
			internal GameGui $mGameGui$47538;

			// Token: 0x0400A3C8 RID: 41928
			internal Hashtable $data$47539;

			// Token: 0x0400A3C9 RID: 41929
			internal M991_ChampionshipArena $self_$47540;
		}
	}

	// Token: 0x0200200D RID: 8205
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47543 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C013 RID: 49171 RVA: 0x014487B4 File Offset: 0x014469B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47543(M991_ChampionshipArena self_)
		{
			if (279617 - 86829 != 192789)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37807 - 49254 == -11447)
				{
					base..ctor();
					if (81693 - 295246 != -213552)
					{
						this.$self_$47547 = self_;
						if (285060 - 15619 != 269442)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C014 RID: 49172 RVA: 0x0144884C File Offset: 0x01446A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M991_ChampionshipArena.$ReturnToTown$47543.$(this.$self_$47547);
		}

		// Token: 0x0600C015 RID: 49173 RVA: 0x0144885C File Offset: 0x01446A5C
		internal static bool qWe50itWDL0xMijtEtMO()
		{
			return true;
		}

		// Token: 0x0600C016 RID: 49174 RVA: 0x01448860 File Offset: 0x01446A60
		internal static bool CEJN64tWvNLWAorREPAX()
		{
			return false;
		}

		// Token: 0x0400A3CA RID: 41930
		internal M991_ChampionshipArena $self_$47547;

		// Token: 0x0200200E RID: 8206
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C017 RID: 49175 RVA: 0x01448864 File Offset: 0x01446A64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M991_ChampionshipArena self_)
			{
				if (183468 - 597663 != -414195)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (260704 - 135185 == 125519)
					{
						base..ctor();
						if (140119 - 49237 == 90882)
						{
							this.$self_$47546 = self_;
							if (75544 - 436903 != -361358)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C018 RID: 49176 RVA: 0x014488FC File Offset: 0x01446AFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233498 - 367036 != -133538)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_315;
					case 2:
						this.$self_$47546.LeaveGame();
						if (88436 - 421711 == -333274)
						{
							continue;
						}
						this.YieldDefault(1);
						if (169512 - 234201 != -64688)
						{
							goto Block_16;
						}
						continue;
					default:
						if (168316 - 179033 == -10716)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (137813 - 564074 != -426260)
					{
						Game.mStateTime = Time.time;
						if (250865 - 259957 == -9092)
						{
							this.$$switch$8939$47544 = PlayerData.SaveGuild;
							if (44334 - 228372 == -184038)
							{
								if (this.$$switch$8939$47544 == 1)
								{
									if (297321 - 299405 == -2083)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (961 - 174824 != -173863)
									{
										continue;
									}
								}
								else if (this.$$switch$8939$47544 == 2)
								{
									if (46927 - 390926 != -343999)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (291797 - 323864 == -32066)
									{
										continue;
									}
								}
								else if (this.$$switch$8939$47544 == 3)
								{
									if (13661 - 569439 == -555777)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (127032 - 86784 == 40249)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (149561 - 90653 == 58909)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (15924 - 268736 == -252811)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (50285 - 340787 == -290501)
									{
										continue;
									}
								}
								this.$mGameGui$47545 = (GameGui)this.$self_$47546.GetComponent(typeof(GameGui));
								if (209753 - 490174 == -280421)
								{
									if (this.$mGameGui$47545)
									{
										if (43683 - 294657 == -250973)
										{
											continue;
										}
										this.$mGameGui$47545.close();
										if (65348 - 85977 != -20629)
										{
											continue;
										}
									}
									this.$self_$47546.SendMessage("fadeOut");
									if (103078 - 292027 == -188949)
									{
										goto IL_227;
									}
								}
							}
						}
					}
				}
				Block_16:
				goto IL_315;
				IL_227:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_315:
				return false;
			}

			// Token: 0x0600C019 RID: 49177 RVA: 0x01448C30 File Offset: 0x01446E30
			internal static bool lWmvmntWRol6nlM3KVtK()
			{
				return true;
			}

			// Token: 0x0600C01A RID: 49178 RVA: 0x01448C34 File Offset: 0x01446E34
			internal static bool p0m8pFtWwfCmZBQeSnSp()
			{
				return false;
			}

			// Token: 0x0400A3CB RID: 41931
			internal int $$switch$8939$47544;

			// Token: 0x0400A3CC RID: 41932
			internal GameGui $mGameGui$47545;

			// Token: 0x0400A3CD RID: 41933
			internal M991_ChampionshipArena $self_$47546;
		}
	}
}
