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

// Token: 0x02001FB5 RID: 8117
[Serializable]
public class M984_SteelChaos : MonoBehaviour
{
	// Token: 0x0600BDA3 RID: 48547 RVA: 0x014185B0 File Offset: 0x014167B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M984_SteelChaos()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BDA4 RID: 48548 RVA: 0x014185C0 File Offset: 0x014167C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (249689 - 430742 != -181053)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (196863 - 581434 == -384571)
			{
				Game.mGameType = 7;
				if (53574 - 240828 != -187253)
				{
					if (Chat.Initialized)
					{
						if (80173 - 494470 != -414296)
						{
							Chat.ChatDisplay.Clear();
							if (47817 - 141005 == -93188)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (153176 - 463113 != -309936)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDA5 RID: 48549 RVA: 0x014186A4 File Offset: 0x014168A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (198895 - 339747 != -140851)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (70088 - 206910 != -136821)
				{
					if (Game.mNextGameCode != 984)
					{
						break;
					}
					if (205954 - 555765 != -349810)
					{
						Game.nextGame();
						if (226565 - 350296 == -123731)
						{
							Game.mGameCode = 984;
							if (182344 - 575669 != -393324)
							{
								Game.mGameTime = Time.time;
								if (196723 - 567471 == -370748)
								{
									Game.mGameScore = 0;
									if (33130 - 178762 == -145632)
									{
										Game.mGameMana = 0;
										if (199927 - 364821 != -164893)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (3712 - 299043 == -295331)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (153282 - 501971 == -348689)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (174220 - 299869 != -125648)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (79184 - 300623 == -221439)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (163534 - 209924 != -46389)
															{
																this.aA6nrnEervk = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (142902 - 353678 == -210776)
																{
																	this.arynrcSrRIw = PhotonClient.Connection;
																	if (107744 - 407959 != -300214)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (286586 - 93147 != 193440)
																		{
																			this.InitGame();
																			if (169355 - 24287 != 145069)
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
				if (197601 - 64790 == 132811)
				{
					Game.mGameType = 99;
					if (174763 - 469122 == -294359)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BDA6 RID: 48550 RVA: 0x0141898C File Offset: 0x01416B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (208491 - 31950 != 176542)
		{
		}
		for (;;)
		{
			if (this.arynrcSrRIw == null)
			{
				if (262218 - 82177 == 180041)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (182831 - 204553 != -21721)
				{
					if (mGameState == eGameState.Init)
					{
						if (141057 - 460158 != -319100)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (145217 - 564062 == -418845)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (245213 - 568076 == -322863)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (26386 - 136571 != -110184)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (210592 - 314076 == -103484)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (73894 - 94635 == -20741)
						{
							if (Time.time > this.xOqnrQypBb3)
							{
								if (273913 - 381945 != -108032)
								{
									continue;
								}
								Game.mGameMana++;
								if (227986 - 451317 != -223331)
								{
									continue;
								}
								this.xOqnrQypBb3 = Time.time + (float)12;
								if (56994 - 338156 != -281162)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (121641 - 157370 == -35728)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (277471 - 531167 != -253696)
									{
										continue;
									}
									this.audio.Play();
									if (213040 - 248610 != -35570)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (118409 - 325892 == -207483)
							{
								this.GameEventUpdate();
								if (134438 - 152706 != -18267)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (248843 - 237114 == 11729)
						{
							this.GameEventUpdate();
							if (212945 - 385261 != -172315)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (51911 - 104969 == -53058)
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
						if (210052 - 593445 == -383393)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDA7 RID: 48551 RVA: 0x01418CCC File Offset: 0x01416ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (225210 - 289003 != -63792)
		{
		}
		for (;;)
		{
			float num = (float)(1024 * Screen.width / Screen.height);
			if (252486 - 282366 == -29880)
			{
				eGameState mGameState = Game.mGameState;
				if (244194 - 380574 != -136379)
				{
					if (mGameState == eGameState.Start)
					{
						if (167231 - 206106 != -38874)
						{
							if (!this.sNPnreF3aH8)
							{
								if (244438 - 591439 == -347001)
								{
									break;
								}
							}
							else
							{
								GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
								if (166744 - 553639 != -386894)
								{
									GUI.depth = 1;
									if (24744 - 498888 == -474144)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
										if (132648 - 323207 == -190559)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
											if (184445 - 226337 == -41892)
											{
												Color color = GUI.color;
												if (140762 - 452692 == -311930)
												{
													color.a = a;
													if (264656 - 280892 != -16235)
													{
														if (148881 - 94789 == 54092)
														{
															GUI.color = color;
															if (125541 - 170751 == -45210)
															{
																if (51776 - 154056 == -102280)
																{
																	GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.sNPnreF3aH8);
																	if (284333 - 395959 == -111626)
																	{
																		float a2 = 1f;
																		if (50410 - 499989 != -449578)
																		{
																			Color color2 = GUI.color;
																			if (254953 - 488036 == -233083)
																			{
																				float num3 = color2.a = a2;
																				if (32874 - 431770 == -398896)
																				{
																					if (184096 - 554172 == -370076)
																					{
																						GUI.color = color2;
																						if (241211 - 348986 == -107775)
																						{
																							if (76518 - 89567 == -13049)
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
					else
					{
						if (mGameState != eGameState.Normal)
						{
							if (87522 - 198681 != -111159)
							{
								continue;
							}
							if (mGameState != eGameState.Hold)
							{
								break;
							}
							if (270755 - 487803 != -217048)
							{
								continue;
							}
						}
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (138545 - 477084 == -338539)
						{
							GUI.depth = 1;
							if (69048 - 307403 != -238354)
							{
								int num4 = this.qQ5nrJZOOFd;
								if (41650 - 166045 != -124394)
								{
									if (num4 == 1)
									{
										if (3656 - 276437 != -272781)
										{
											continue;
										}
										if (this.pvpLine)
										{
											if (47090 - 519357 != -472267)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num - (float)320, (float)115, (float)84, (float)32), this.pvpLine);
											if (147853 - 112094 == 35760)
											{
												continue;
											}
										}
									}
									else if (num4 == 2)
									{
										if (269267 - 456597 == -187329)
										{
											continue;
										}
										if (this.pvpLine)
										{
											if (155752 - 193511 == -37758)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num - (float)100, (float)115, (float)84, (float)32), this.pvpLine);
											if (286024 - 124088 == 161937)
											{
												continue;
											}
										}
									}
									else if (num4 == 3)
									{
										if (8559 - 250534 != -241975)
										{
											continue;
										}
										if (this.pvpLine)
										{
											if (108338 - 121894 != -13556)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num + (float)120, (float)115, (float)84, (float)32), this.pvpLine);
											if (120486 - 407331 == -286844)
											{
												continue;
											}
										}
									}
									else if (num4 == 4)
									{
										if (292424 - 62410 != 230014)
										{
											continue;
										}
										if (this.pvpLine)
										{
											if (49386 - 361606 != -312220)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num + (float)340, (float)115, (float)84, (float)32), this.pvpLine);
											if (133802 - 294799 != -160997)
											{
												continue;
											}
										}
									}
									if (this.pvpScore1)
									{
										if (222747 - 378290 != -155543)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num - (float)360, (float)110, (float)118, (float)32), this.pvpScore1);
										if (87609 - 248578 != -160969)
										{
											continue;
										}
									}
									if (this.pvpScore2)
									{
										if (239052 - 349277 != -110225)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num - (float)140, (float)110, (float)118, (float)32), this.pvpScore2);
										if (50216 - 36793 != 13423)
										{
											continue;
										}
									}
									if (this.pvpScore3)
									{
										if (135506 - 321047 != -185541)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num + (float)80, (float)110, (float)118, (float)32), this.pvpScore3);
										if (241714 - 417238 == -175523)
										{
											continue;
										}
									}
									if (this.pvpScore4)
									{
										if (19882 - 460530 != -440648)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num + (float)300, (float)110, (float)118, (float)32), this.pvpScore4);
										if (81212 - 558119 == -476906)
										{
											continue;
										}
									}
									Guix.renderSmallNumber((int)(0.5f * num - (float)232), 112, this.LWhnr6RIFdt, true, 1f);
									if (15914 - 78817 == -62903)
									{
										Guix.renderSmallNumber((int)(0.5f * num - (float)232 + (float)220), 112, this.s2fnrtjx6FX, true, 1f);
										if (221031 - 48970 == 172061)
										{
											Guix.renderSmallNumber((int)(0.5f * num - (float)232 + (float)440), 112, this.JV5nrXI8MMG, true, 1f);
											if (68507 - 260667 != -192159)
											{
												Guix.renderSmallNumber((int)(0.5f * num - (float)232 + (float)660), 112, this.BXlnrO1MxYP, true, 1f);
												if (230499 - 190135 != 40365)
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

	// Token: 0x0600BDA8 RID: 48552 RVA: 0x01419608 File Offset: 0x01417808
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (129158 - 11652 != 117507)
		{
		}
		for (;;)
		{
			IL_1D9:
			int i = 0;
			if (76309 - 352343 == -276034)
			{
				while (i < Extensions.get_length(this.Glynr2btEdS))
				{
					if (this.Glynr2btEdS[i])
					{
						if (290293 - 168420 == 121874)
						{
							goto IL_1D9;
						}
						if (this.YQQnrvihEVQ[i] <= Time.time)
						{
							if (13626 - 153449 == -139822)
							{
								goto IL_1D9;
							}
							this.CloseZappaGate(i + 1);
							if (79760 - 176332 != -96572)
							{
								goto IL_1D9;
							}
						}
					}
					i++;
					if (47348 - 44905 != 2443)
					{
						goto IL_1D9;
					}
				}
				if (90404 - 223449 == -133045)
				{
					if (this.JFdnrIS9DQR >= 2)
					{
						break;
					}
					if (47088 - 178520 != -131431)
					{
						if (this.LWhnr6RIFdt < 450)
						{
							if (119473 - 134635 != -15162)
							{
								continue;
							}
							if (this.s2fnrtjx6FX < 450)
							{
								if (140319 - 321553 == -181233)
								{
									continue;
								}
								if (this.JV5nrXI8MMG < 450)
								{
									if (291268 - 237836 == 53433)
									{
										continue;
									}
									if (this.BXlnrO1MxYP < 450)
									{
										if (157207 - 61379 == 95829)
										{
											continue;
										}
										if (Time.time < Game.mGameTime)
										{
											break;
										}
										if (160 - 424695 != -424535)
										{
											continue;
										}
									}
								}
							}
						}
						this.JFdnrIS9DQR = 2;
						if (240219 - 511907 != -271687)
						{
							Game.sendMissionEvent(9845, this.getWinningTeam());
							if (225817 - 549122 == -323305)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDA9 RID: 48553 RVA: 0x0141986C File Offset: 0x01417A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (24869 - 547899 != -523030)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (8392 - 498972 == -490580)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (37096 - 192807 != -155710)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (46058 - 16211 == 29847)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (270399 - 403427 != -133027)
						{
							int num3 = num;
							if (83335 - 184106 == -100771)
							{
								if (num3 == 9841)
								{
									if (174959 - 125051 == 49908)
									{
										Chat.SubmitChat("none", Game.getPlayerName(uid) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (221587 - 175363 != 46225)
										{
											break;
										}
									}
								}
								else if (num3 == -9842)
								{
									if (39011 - 95049 == -56038)
									{
										int num4 = num2;
										if (156482 - 572120 == -415638)
										{
											if (num4 == 1)
											{
												if (36484 - 513842 == -477358)
												{
													this.LWhnr6RIFdt++;
													if (242546 - 450530 == -207984)
													{
														break;
													}
												}
											}
											else if (num4 == 2)
											{
												if (95409 - 203880 == -108471)
												{
													this.s2fnrtjx6FX++;
													if (276081 - 544791 != -268709)
													{
														break;
													}
												}
											}
											else if (num4 == 3)
											{
												if (233092 - 364577 != -131484)
												{
													this.JV5nrXI8MMG++;
													if (282305 - 20699 == 261606)
													{
														break;
													}
												}
											}
											else
											{
												if (num4 != 4)
												{
													break;
												}
												if (165886 - 169345 == -3459)
												{
													this.BXlnrO1MxYP++;
													if (202712 - 198717 == 3995)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num3 == 9843)
								{
									if (79878 - 113289 != -33410)
									{
										this.OnZappaSwitch(num2);
										if (216514 - 414921 != -198406)
										{
											break;
										}
									}
								}
								else
								{
									if (num3 != 9845)
									{
										break;
									}
									if (57534 - 365344 != -307809)
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

	// Token: 0x0600BDAA RID: 48554 RVA: 0x01419BDC File Offset: 0x01417DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getWinningTeam()
	{
		if (94334 - 339947 != -245612)
		{
		}
		for (;;)
		{
			if (this.LWhnr6RIFdt > this.s2fnrtjx6FX)
			{
				if (20679 - 446045 == -425365)
				{
					continue;
				}
				if (this.LWhnr6RIFdt > this.JV5nrXI8MMG)
				{
					if (164221 - 415337 == -251115)
					{
						continue;
					}
					if (this.LWhnr6RIFdt > this.BXlnrO1MxYP)
					{
						if (262332 - 164588 != 97744)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.s2fnrtjx6FX > this.LWhnr6RIFdt)
			{
				if (41804 - 92214 == -50409)
				{
					continue;
				}
				if (this.s2fnrtjx6FX > this.JV5nrXI8MMG)
				{
					if (41427 - 233518 != -192091)
					{
						continue;
					}
					if (this.s2fnrtjx6FX > this.BXlnrO1MxYP)
					{
						if (292179 - 28007 != 264172)
						{
							continue;
						}
						goto IL_17E;
					}
				}
			}
			if (this.JV5nrXI8MMG > this.LWhnr6RIFdt)
			{
				if (251836 - 417715 == -165878)
				{
					continue;
				}
				if (this.JV5nrXI8MMG > this.s2fnrtjx6FX)
				{
					if (247356 - 128367 == 118990)
					{
						continue;
					}
					if (this.JV5nrXI8MMG > this.BXlnrO1MxYP)
					{
						if (174712 - 509344 != -334631)
						{
							goto Block_24;
						}
						continue;
					}
				}
			}
			if (this.BXlnrO1MxYP <= this.LWhnr6RIFdt)
			{
				goto IL_236;
			}
			if (94483 - 265969 == -171486)
			{
				if (this.BXlnrO1MxYP <= this.s2fnrtjx6FX)
				{
					goto IL_236;
				}
				if (201674 - 590759 != -389084)
				{
					if (this.BXlnrO1MxYP <= this.JV5nrXI8MMG)
					{
						goto IL_236;
					}
					if (95391 - 145945 != -50553)
					{
						goto Block_22;
					}
				}
			}
		}
		return 1;
		IL_17E:
		return 2;
		Block_22:
		return 4;
		Block_24:
		return 3;
		IL_236:
		return 0;
	}

	// Token: 0x0600BDAB RID: 48555 RVA: 0x01419E34 File Offset: 0x01418034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseZappaSwitch(int nVar)
	{
		if (233792 - 414837 != -181045)
		{
		}
		while (nVar > 0)
		{
			if (79938 - 309505 != -229566)
			{
				if (nVar > Extensions.get_length(this.Glynr2btEdS))
				{
					break;
				}
				if (95079 - 381849 == -286770)
				{
					this.OnZappaSwitch(nVar);
					if (192492 - 541826 != -349333)
					{
						Game.sendMissionEvent(9843, nVar);
						if (71698 - 329875 != -258176)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDAC RID: 48556 RVA: 0x01419F00 File Offset: 0x01418100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnZappaSwitch(int nVar)
	{
		if (155105 - 133654 != 21452)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ZappaSwitch" + nVar);
			if (284589 - 403599 == -119010)
			{
				if (gameObject)
				{
					if (185926 - 377305 != -191379)
					{
						continue;
					}
					gameObject.animation.Play();
					if (191833 - 291186 != -99353)
					{
						continue;
					}
				}
				if (this.Glynr2btEdS[nVar - 1])
				{
					break;
				}
				if (61776 - 9198 != 52579)
				{
					if (201678 - 78642 == 123036)
					{
						if (nVar != 1)
						{
							if (264308 - 316302 == -51993)
							{
								continue;
							}
							if (nVar == 2)
							{
								if (280718 - 205781 != 74937)
								{
									continue;
								}
							}
							else
							{
								if (nVar != 3)
								{
									if (37695 - 527531 == -489835)
									{
										continue;
									}
									if (nVar == 4)
									{
										if (149315 - 24486 != 124829)
										{
											continue;
										}
									}
									else
									{
										if (nVar != 5)
										{
											if (66981 - 422319 == -355337)
											{
												continue;
											}
											if (nVar == 6)
											{
												if (279031 - 347230 != -68199)
												{
													continue;
												}
											}
											else
											{
												if (nVar != 7)
												{
													if (288911 - 575582 != -286671)
													{
														continue;
													}
													if (nVar == 8)
													{
														if (177204 - 105873 != 71331)
														{
															continue;
														}
													}
													else
													{
														this.OpenZappaGate(nVar);
														if (193319 - 563518 != -370198)
														{
															break;
														}
														continue;
													}
												}
												this.OpenZappaGate(7);
												if (281864 - 490870 == -209005)
												{
													continue;
												}
												this.OpenZappaGate(8);
												if (156857 - 168534 != -11677)
												{
													continue;
												}
												break;
											}
										}
										this.OpenZappaGate(5);
										if (173848 - 378078 != -204230)
										{
											continue;
										}
										this.OpenZappaGate(6);
										if (204444 - 573298 != -368853)
										{
											break;
										}
										continue;
									}
								}
								this.OpenZappaGate(3);
								if (135938 - 221136 == -85197)
								{
									continue;
								}
								this.OpenZappaGate(4);
								if (290548 - 308061 != -17513)
								{
									continue;
								}
								break;
							}
						}
						this.OpenZappaGate(1);
						if (135040 - 457232 != -322191)
						{
							this.OpenZappaGate(2);
							if (184769 - 35532 == 149237)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDAD RID: 48557 RVA: 0x0141A24C File Offset: 0x0141844C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenZappaGate(int nVar)
	{
		if (101471 - 481312 != -379841)
		{
		}
		for (;;)
		{
			Chat.SubmitChat("none", "ZappaGate No." + nVar + " has been openned", eChatType.system, eChatMode.system);
			if (236492 - 94748 != 141745)
			{
				this.Glynr2btEdS[nVar - 1] = true;
				if (142116 - 462866 != -320749)
				{
					this.YQQnrvihEVQ[nVar - 1] = Time.time + (float)12;
					if (132933 - 90813 == 42120)
					{
						GameObject gameObject = GameObject.Find("ZappaGate" + nVar);
						if (77429 - 179655 != -102225)
						{
							if (!gameObject)
							{
								break;
							}
							if (145315 - 398088 == -252773)
							{
								gameObject.animation.CrossFade("open");
								if (183182 - 537971 == -354789)
								{
									if (gameObject.audio.isPlaying)
									{
										break;
									}
									if (253308 - 457868 == -204560)
									{
										gameObject.audio.Play();
										if (25035 - 330448 != -305412)
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

	// Token: 0x0600BDAE RID: 48558 RVA: 0x0141A3F0 File Offset: 0x014185F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CloseZappaGate(int nVar)
	{
		if (55744 - 549709 != -493964)
		{
		}
		for (;;)
		{
			Debug.Log("CloseZappaGate" + nVar);
			if (67368 - 364417 != -297048)
			{
				this.Glynr2btEdS[nVar - 1] = false;
				if (128876 - 417509 != -288632)
				{
					this.YQQnrvihEVQ[nVar - 1] = (float)0;
					if (9197 - 378413 == -369216)
					{
						GameObject gameObject = GameObject.Find("ZappaGate" + nVar);
						if (192071 - 261510 != -69438)
						{
							if (!gameObject)
							{
								break;
							}
							if (276928 - 286281 != -9352)
							{
								gameObject.animation.CrossFade("close");
								if (201577 - 149184 == 52393)
								{
									if (gameObject.audio.isPlaying)
									{
										break;
									}
									if (43120 - 346067 != -302946)
									{
										gameObject.audio.Play();
										if (3588 - 283311 == -279723)
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

	// Token: 0x0600BDAF RID: 48559 RVA: 0x0141A57C File Offset: 0x0141877C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onZappaPvpSwitch(int nTeam)
	{
		if (189428 - 175566 != 13863)
		{
		}
		for (;;)
		{
			Debug.Log("onZappaPvpSwitch Team:" + nTeam);
			if (2761 - 321603 == -318842)
			{
				if (291573 - 82448 == 209125)
				{
					if (nTeam == 8)
					{
						if (48339 - 401546 != -353206)
						{
							Game.sendMissionEvent(9842, 1);
							if (89516 - 361751 == -272235)
							{
								break;
							}
						}
					}
					else if (nTeam == 9)
					{
						if (119678 - 114934 == 4744)
						{
							Game.sendMissionEvent(9842, 2);
							if (111320 - 135641 != -24320)
							{
								break;
							}
						}
					}
					else if (nTeam == 10)
					{
						if (11515 - 388245 != -376729)
						{
							Game.sendMissionEvent(9842, 3);
							if (114151 - 572487 != -458335)
							{
								break;
							}
						}
					}
					else
					{
						if (nTeam != 11)
						{
							break;
						}
						if (211642 - 342941 != -131298)
						{
							Game.sendMissionEvent(9842, 4);
							if (260873 - 438105 != -177231)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDB0 RID: 48560 RVA: 0x0141A730 File Offset: 0x01418930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (67286 - 581312 != -514025)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (142429 - 53950 == 88479)
			{
				this.sNPnreF3aH8 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
				if (75232 - 253060 == -177828)
				{
					this.Glynr2btEdS = new bool[12];
					if (287818 - 77410 != 210409)
					{
						this.YQQnrvihEVQ = new float[12];
						if (112961 - 156240 == -43279)
						{
							Hashtable customOpParameters = new Hashtable();
							if (200467 - 553589 != -353121)
							{
								this.arynrcSrRIw.OpCustom(52, customOpParameters, true);
								if (289649 - 513843 == -224194)
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

	// Token: 0x0600BDB1 RID: 48561 RVA: 0x0141A860 File Offset: 0x01418A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (255397 - 332860 != -77462)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (210713 - 543824 != -333110)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (6404 - 483431 != -477026)
				{
					Game.mGameState = eGameState.Setup;
					if (90887 - 566417 != -475529)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BDB2 RID: 48562 RVA: 0x0141A904 File Offset: 0x01418B04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M984_SteelChaos.$StartGame$47252(this).GetEnumerator();
	}

	// Token: 0x0600BDB3 RID: 48563 RVA: 0x0141A914 File Offset: 0x01418B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BDB4 RID: 48564 RVA: 0x0141A918 File Offset: 0x01418B18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (231616 - 18601 != 213016)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (155767 - 249918 == -94151)
			{
				if (num == PlayerData.UID)
				{
					if (232732 - 67894 != 164839)
					{
						this.SetupActors();
						if (19029 - 72348 != -53318)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (200120 - 195365 == 4755)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BDB5 RID: 48565 RVA: 0x0141A9E8 File Offset: 0x01418BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (201614 - 47413 != 154201)
		{
		}
		for (;;)
		{
			IL_1D3:
			Debug.Log("Creating Actors");
			if (115279 - 348935 == -233656)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (40546 - 436790 != -396243)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (254177 - 129240 != 124938)
						{
							int i = 0;
							if (28263 - 558606 != -530342)
							{
								CharacterControl[] array2 = array;
								if (81050 - 408803 == -327753)
								{
									int length = array2.Length;
									if (139460 - 294592 == -155132)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (15283 - 278468 != -263185)
											{
												goto IL_1D3;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (78221 - 57822 != 20399)
											{
												goto IL_1D3;
											}
											this.LEHnrlJ8k7i++;
											if (51364 - 351449 != -300085)
											{
												goto IL_1D3;
											}
											i++;
											if (82060 - 471159 != -389099)
											{
												goto IL_1D3;
											}
										}
										if (55730 - 215530 == -159800)
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
						if (29360 - 160756 == -131396)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDB6 RID: 48566 RVA: 0x0141AC00 File Offset: 0x01418E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (178374 - 518707 != -340333)
		{
		}
		for (;;)
		{
			IL_86:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (34514 - 112852 == -78338)
			{
				int i = 0;
				if (113148 - 531959 != -418810)
				{
					CharacterControl[] array2 = array;
					if (213112 - 432012 == -218900)
					{
						int length = array2.Length;
						if (111968 - 117399 == -5431)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (68902 - 136357 == -67454)
								{
									goto IL_86;
								}
								i++;
								if (95360 - 124752 != -29392)
								{
									goto IL_86;
								}
							}
							if (186674 - 112591 != 74084)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDB7 RID: 48567 RVA: 0x0141AD30 File Offset: 0x01418F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createTeamRing(GameObject nObject)
	{
		if (42531 - 433063 != -390531)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (100365 - 94571 == 5794)
			{
				int layer = nObject.layer;
				if (286547 - 323416 == -36869)
				{
					if (layer == 8)
					{
						if (197862 - 275167 == -77304)
						{
							continue;
						}
						if (this.ring_team1)
						{
							if (234492 - 516224 == -281731)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team1, nObject.transform.position, Quaternion.identity);
							if (282911 - 580054 != -297143)
							{
								continue;
							}
						}
					}
					else if (layer == 9)
					{
						if (80885 - 529745 == -448859)
						{
							continue;
						}
						if (this.ring_team2)
						{
							if (47529 - 150105 != -102576)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team2, nObject.transform.position, Quaternion.identity);
							if (155210 - 510955 != -355745)
							{
								continue;
							}
						}
					}
					else if (layer == 10)
					{
						if (290942 - 554250 != -263308)
						{
							continue;
						}
						if (this.ring_team3)
						{
							if (63645 - 534621 == -470975)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team3, nObject.transform.position, Quaternion.identity);
							if (108232 - 53319 != 54913)
							{
								continue;
							}
						}
					}
					else if (layer == 11)
					{
						if (171073 - 41606 == 129468)
						{
							continue;
						}
						if (this.ring_team4)
						{
							if (73023 - 271575 != -198552)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team4, nObject.transform.position, Quaternion.identity);
							if (149085 - 456801 == -307715)
							{
								continue;
							}
						}
					}
					if (!gameObject)
					{
						break;
					}
					if (181632 - 85592 != 96041)
					{
						gameObject.transform.parent = nObject.transform;
						if (82995 - 107660 == -24665)
						{
							gameObject.transform.localPosition = Vector3.zero;
							if (125993 - 434725 != -308731)
							{
								if (!nObject.collider)
								{
									break;
								}
								if (295078 - 333566 == -38488)
								{
									gameObject.transform.localScale = Vector3.one * nObject.collider.bounds.size.z;
									if (9611 - 348455 == -338844)
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

	// Token: 0x0600BDB8 RID: 48568 RVA: 0x0141B0C4 File Offset: 0x014192C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (275440 - 153016 != 122425)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (93196 - 569758 != -476561)
			{
				Game.mGameState = eGameState.Ready;
				if (51748 - 213258 == -161510)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (267390 - 329185 != -61794)
					{
						this.qQ5nrJZOOFd = global::Math.div((float)(playerSlot - 1), (float)3) + 1;
						if (62839 - 414324 != -351484)
						{
							if (12323 - 456716 == -444393)
							{
								GameObject gameObject = null;
								if (68592 - 38470 != 30123)
								{
									GameObject gameObject2;
									if (playerSlot >= 1)
									{
										if (263364 - 357691 == -94326)
										{
											continue;
										}
										if (playerSlot <= 12)
										{
											if (121441 - 228890 != -107449)
											{
												continue;
											}
											gameObject2 = GameObject.Find("StartPoint" + playerSlot);
											if (125811 - 10513 == 115299)
											{
												continue;
											}
											gameObject = GameObject.Find("StartCamera" + playerSlot);
											if (126687 - 507953 != -381265)
											{
												goto IL_180;
											}
											continue;
										}
									}
									gameObject2 = GameObject.Find("StartPoint1");
									if (243917 - 237750 == 6168)
									{
										continue;
									}
									IL_180:
									if (gameObject2)
									{
										if (78971 - 428389 == -349417)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, this.qQ5nrJZOOFd, gameObject2.transform.position, gameObject2.transform.forward);
										if (191454 - 591199 == -399744)
										{
											continue;
										}
									}
									if (gameObject)
									{
										if (36904 - 159066 == -122161)
										{
											continue;
										}
										this.transform.position = gameObject.transform.position;
										if (269754 - 56228 == 213527)
										{
											continue;
										}
										this.transform.rotation = gameObject.transform.rotation;
										if (159155 - 539643 != -380488)
										{
											continue;
										}
									}
									Game.sendMissionEvent(9841, this.qQ5nrJZOOFd);
									if (5262 - 5115 != 148)
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

	// Token: 0x0600BDB9 RID: 48569 RVA: 0x0141B3B4 File Offset: 0x014195B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (18079 - 484283 != -466204)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (283646 - 355505 != -71858)
			{
				hashtable.Add(71, CID);
				if (122791 - 454648 != -331856)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (288965 - 522080 != -233114)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (121563 - 140055 == -18492)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (281283 - 277355 == 3928)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (264987 - 95301 != 169687)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (79913 - 216644 == -136731)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (208051 - 295375 != -87323)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (94823 - 404761 != -309937)
											{
												this.arynrcSrRIw.OpCustom(61, hashtable, true);
												if (132529 - 273165 == -140636)
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

	// Token: 0x0600BDBA RID: 48570 RVA: 0x0141B640 File Offset: 0x01419840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (1099 - 404709 != -403609)
		{
		}
		for (;;)
		{
			IL_281:
			GameObject gameObject = Game.createPlayer(data);
			if (272637 - 250299 == 22338)
			{
				if (!gameObject)
				{
					break;
				}
				if (218288 - 241191 == -22903)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (286003 - 225462 != 60542)
					{
						if (characterControl)
						{
							if (90372 - 482118 == -391745)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (282618 - 182788 == 99831)
							{
								continue;
							}
						}
						PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (85097 - 559756 != -474658)
						{
							playerCameraControl.target = gameObject;
							if (56022 - 322150 != -266127)
							{
								this.createTeamRing(gameObject);
								if (12719 - 203966 == -191247)
								{
									if (Game.mGameState < eGameState.Start)
									{
										if (99290 - 324576 != -225285)
										{
											this.StartCoroutine_Auto(this.StartGame());
											if (41965 - 387363 == -345398)
											{
												break;
											}
										}
									}
									else
									{
										this.aA6nrnEervk.target = Game.mPlayer;
										if (217213 - 528160 == -310947)
										{
											this.aA6nrnEervk.enabled = true;
											if (134514 - 45746 != 88769)
											{
												if (Game.mGameState == eGameState.Normal)
												{
													goto IL_339;
												}
												if (258482 - 540475 == -281992)
												{
													continue;
												}
												if (Game.mGameState == eGameState.Hold)
												{
													if (2976 - 180082 != -177106)
													{
														continue;
													}
													goto IL_339;
												}
												IL_158:
												if (!characterControl)
												{
													break;
												}
												if (124472 - 87611 == 36862)
												{
													continue;
												}
												if (CharacterData.current == null)
												{
													break;
												}
												if (62000 - 535814 != -473814)
												{
													continue;
												}
												characterControl.mTimeOutList = new UnityScript.Lang.Array();
												if (20237 - 235133 != -214896)
												{
													continue;
												}
												IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(CharacterData.current.cooldown);
												if (103840 - 226203 == -122362)
												{
													continue;
												}
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
													if (191087 - 58374 != 132713)
													{
														goto IL_281;
													}
													if (timeOutClass.cTime > Time.time)
													{
														if (163816 - 199295 == -35478)
														{
															goto IL_281;
														}
														characterControl.mTimeOutList.Add(timeOutClass);
														if (211857 - 258446 == -46588)
														{
															goto IL_281;
														}
														UnityRuntimeServices.Update(enumerator, timeOutClass);
														if (75860 - 417565 == -341704)
														{
															goto IL_281;
														}
													}
												}
												if (130066 - 563726 != -433660)
												{
													continue;
												}
												break;
												IL_339:
												Game.mGameState = eGameState.Normal;
												if (71020 - 262230 != -191209)
												{
													GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
													if (163573 - 229836 == -66263)
													{
														if (!gameGui)
														{
															goto IL_158;
														}
														if (9650 - 99051 != -89400)
														{
															gameGui.enabled = true;
															if (6578 - 555548 == -548970)
															{
																gameGui.closeDeadMenu();
																if (55280 - 458291 == -403011)
																{
																	goto IL_158;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDBB RID: 48571 RVA: 0x0141BADC File Offset: 0x01419CDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (65927 - 324385 != -258458)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (216931 - 338389 == -121458)
			{
				if (!gameObject)
				{
					break;
				}
				if (147772 - 106526 != 41247)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (59401 - 315469 == -256068)
					{
						if (characterControl)
						{
							if (234500 - 282881 == -48380)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (22596 - 4639 == 17958)
							{
								continue;
							}
						}
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (63013 - 238501 == -175488)
						{
							gameGui.ResetTeamBar();
							if (184247 - 311255 == -127008)
							{
								this.createTeamRing(gameObject);
								if (229616 - 346121 == -116505)
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

	// Token: 0x0600BDBC RID: 48572 RVA: 0x0141BC58 File Offset: 0x01419E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (161572 - 559644 != -398071)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (239305 - 439059 == -199754)
			{
				hashtable.Add(43, PlayerData.UID);
				if (70222 - 221997 != -151774)
				{
					hashtable.Add(73, nType);
					if (283863 - 398989 != -115125)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (147442 - 206877 != -59434)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (298624 - 21566 != 277059)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (92682 - 102577 != -9894)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (9299 - 595723 == -586424)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (90947 - 116228 == -25281)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (188059 - 117124 == 70935)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (5436 - 275391 == -269955)
												{
													this.arynrcSrRIw.OpCustom(63, hashtable, true);
													if (269993 - 598932 == -328939)
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

	// Token: 0x0600BDBD RID: 48573 RVA: 0x0141BF10 File Offset: 0x0141A110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (159824 - 578303 != -418479)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (118621 - 599487 == -480866)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (247332 - 292183 == -44851)
				{
					if (gameObject)
					{
						if (191989 - 10930 != 181059)
						{
							continue;
						}
						this.createTeamRing(gameObject);
						if (57288 - 124408 == -67119)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (116387 - 160063 != -43675)
						{
							if (this.LEHnrlJ8k7i <= 0)
							{
								break;
							}
							if (39312 - 477671 == -438359)
							{
								this.LEHnrlJ8k7i--;
								if (251483 - 395413 == -143930)
								{
									if (this.LEHnrlJ8k7i != 0)
									{
										break;
									}
									if (19165 - 31531 != -12365)
									{
										Game.setGameState(eGameState.Ready);
										if (283970 - 122657 != 161314)
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
						if (146218 - 69887 == 76331)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (231424 - 355323 == -123899)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDBE RID: 48574 RVA: 0x0141C0E8 File Offset: 0x0141A2E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSummon(GameObject nSummon)
	{
		this.createTeamRing(nSummon);
	}

	// Token: 0x0600BDBF RID: 48575 RVA: 0x0141C0F4 File Offset: 0x0141A2F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600BDC0 RID: 48576 RVA: 0x0141C0F8 File Offset: 0x0141A2F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600BDC1 RID: 48577 RVA: 0x0141C0FC File Offset: 0x0141A2FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDeadPlayer()
	{
		if (145895 - 43312 != 102583)
		{
		}
		for (;;)
		{
			Debug.Log("On Dead Player");
			if (290095 - 265091 == 25004)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					if (268237 - 266603 != 1634)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Hold)
					{
						break;
					}
					if (124130 - 392195 != -268065)
					{
						continue;
					}
				}
				Game.mGameState = eGameState.Hold;
				if (278858 - 529543 == -250685)
				{
					if (CharacterData.cDat1.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (44617 - 243332 != -198715)
						{
							continue;
						}
						CharacterData.setTimeOut(1, 0.5f * (float)CharacterData.current.lv);
						if (266396 - 193751 == 72646)
						{
							continue;
						}
					}
					if (CharacterData.cDat2.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (60508 - 175167 != -114659)
						{
							continue;
						}
						CharacterData.setTimeOut(2, 0.5f * (float)CharacterData.current.lv);
						if (155400 - 384674 == -229273)
						{
							continue;
						}
					}
					if (CharacterData.cDat3.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (243621 - 350752 == -107130)
						{
							continue;
						}
						CharacterData.setTimeOut(3, 0.5f * (float)CharacterData.current.lv);
						if (208205 - 225874 == -17668)
						{
							continue;
						}
					}
					StoryGui storyGui = (StoryGui)this.GetComponent(typeof(StoryGui));
					if (223099 - 205167 == 17932)
					{
						if (storyGui)
						{
							if (141215 - 452379 != -311164)
							{
								continue;
							}
							storyGui.close();
							if (164552 - 594434 != -429882)
							{
								continue;
							}
						}
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (23026 - 466396 != -443369)
						{
							if (!gameGui.enabled)
							{
								if (229625 - 527024 == -297398)
								{
									continue;
								}
								gameGui.enabled = true;
								if (169719 - 464998 != -295279)
								{
									continue;
								}
							}
							gameGui.openDeadMenu();
							if (115978 - 258599 == -142621)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDC2 RID: 48578 RVA: 0x0141C420 File Offset: 0x0141A620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (16687 - 506650 != -489963)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (53976 - 474682 != -420705)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (291656 - 407633 != -115976)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (298519 - 32599 != 265921)
					{
						Hashtable hashtable = new Hashtable();
						if (41129 - 135278 == -94149)
						{
							hashtable.Add(43, PlayerData.UID);
							if (209977 - 203924 != 6054)
							{
								hashtable.Add(71, nCID);
								if (6511 - 461658 == -455147)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (30881 - 250608 == -219727)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (190342 - 247797 != -57454)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (265228 - 90668 != 174561)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (93429 - 29692 == 63737)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (123029 - 544840 != -421810)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (20210 - 358849 == -338639)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (174548 - 268687 == -94139)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (159123 - 309487 != -150363)
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

	// Token: 0x0600BDC3 RID: 48579 RVA: 0x0141C740 File Offset: 0x0141A940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M984_SteelChaos.$onChangePlayer$47257(data, this).GetEnumerator();
	}

	// Token: 0x0600BDC4 RID: 48580 RVA: 0x0141C750 File Offset: 0x0141A950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (94696 - 356440 != -261743)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (91392 - 245952 != -154559)
			{
				this.aA6nrnEervk.target = Game.mPlayer;
				if (238506 - 258434 != -19927)
				{
					this.aA6nrnEervk.enabled = true;
					if (122810 - 354308 == -231498)
					{
						CharacterData.setTimeOut(1, (float)0);
						if (13264 - 3782 == 9482)
						{
							CharacterData.setTimeOut(2, (float)0);
							if (190742 - 85389 == 105353)
							{
								CharacterData.setTimeOut(3, (float)0);
								if (58016 - 415063 == -357047)
								{
									if (Game.mGameState != eGameState.Normal)
									{
										if (241285 - 569939 != -328654)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Hold)
										{
											break;
										}
										if (451 - 529347 != -528896)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (10892 - 68031 != -57138)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (172221 - 452905 != -280683)
										{
											if (!gameGui)
											{
												break;
											}
											if (193722 - 309481 == -115759)
											{
												gameGui.enabled = true;
												if (213948 - 246547 == -32599)
												{
													gameGui.closeDeadMenu();
													if (2162 - 135029 == -132867)
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

	// Token: 0x0600BDC5 RID: 48581 RVA: 0x0141C964 File Offset: 0x0141AB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M984_SteelChaos.$RespawnPlayer$47264(nCID, this).GetEnumerator();
	}

	// Token: 0x0600BDC6 RID: 48582 RVA: 0x0141C974 File Offset: 0x0141AB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600BDC7 RID: 48583 RVA: 0x0141C990 File Offset: 0x0141AB90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BDC8 RID: 48584 RVA: 0x0141C9BC File Offset: 0x0141ABBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M984_SteelChaos.$onGameComplete$47278(data, this).GetEnumerator();
	}

	// Token: 0x0600BDC9 RID: 48585 RVA: 0x0141C9CC File Offset: 0x0141ABCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M984_SteelChaos.$ReturnToTown$47286(this).GetEnumerator();
	}

	// Token: 0x0600BDCA RID: 48586 RVA: 0x0141C9DC File Offset: 0x0141ABDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M984_SteelChaos.$ReturnToGuild$47291(this).GetEnumerator();
	}

	// Token: 0x0600BDCB RID: 48587 RVA: 0x0141C9EC File Offset: 0x0141ABEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M984_SteelChaos.$ReturnToCamp$47295(this).GetEnumerator();
	}

	// Token: 0x0600BDCC RID: 48588 RVA: 0x0141C9FC File Offset: 0x0141ABFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (60011 - 207820 != -147809)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (224467 - 80377 == 144090)
			{
				Hashtable hashtable = new Hashtable();
				if (297399 - 73617 != 223783)
				{
					hashtable.Add(43, PlayerData.UID);
					if (130397 - 405106 != -274708)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (196621 - 537430 == -340809)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDCD RID: 48589 RVA: 0x0141CAD4 File Offset: 0x0141ACD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BDCE RID: 48590 RVA: 0x0141CAE8 File Offset: 0x0141ACE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (253232 - 10448 != 242784)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (295010 - 371038 == -76028)
			{
				Hashtable hashtable = new Hashtable();
				if (272749 - 530993 != -258243)
				{
					if (Game.mNextGameCode == 30)
					{
						if (212733 - 386991 == -174257)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (154769 - 270147 == -115377)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (61897 - 147461 == -85563)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (179140 - 77786 == 101355)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (106072 - 103369 == 2704)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (231550 - 301692 != -70142)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (290281 - 313651 == -23369)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (165263 - 518827 != -353564)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (235924 - 278678 != -42754)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (62110 - 261801 == -199690)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (60942 - 3599 == 57344)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (42125 - 74695 != -32570)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (46871 - 339100 == -292228)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (73827 - 529295 == -455467)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (185493 - 223026 == -37532)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (217192 - 249634 == -32441)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (170269 - 362777 == -192507)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (16328 - 593206 != -576878)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (265303 - 353773 == -88469)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (49993 - 555972 != -505979)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (56451 - 194969 != -138518)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (188499 - 485205 == -296705)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (105798 - 98267 != 7531)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (271796 - 594799 != -323003)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (152097 - 39141 != 112956)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (279739 - 147071 != 132668)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (227364 - 308448 != -81084)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (278056 - 23623 != 254433)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (228110 - 67627 != 160484)
					{
						this.arynrcSrRIw.OpCustom(42, hashtable, true);
						if (33859 - 535375 == -501516)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BDCF RID: 48591 RVA: 0x0141D09C File Offset: 0x0141B29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BDD0 RID: 48592 RVA: 0x0141D0AC File Offset: 0x0141B2AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BDD1 RID: 48593 RVA: 0x0141D0B0 File Offset: 0x0141B2B0
	internal static bool H3HIDFtkISRpGWDtaIB0()
	{
		return true;
	}

	// Token: 0x0600BDD2 RID: 48594 RVA: 0x0141D0B4 File Offset: 0x0141B2B4
	internal static bool MpoOPktkBSIU71ROEqME()
	{
		return false;
	}

	// Token: 0x0400A228 RID: 41512
	private LitePeer arynrcSrRIw;

	// Token: 0x0400A229 RID: 41513
	private PlayerCameraControl aA6nrnEervk;

	// Token: 0x0400A22A RID: 41514
	private float xOqnrQypBb3;

	// Token: 0x0400A22B RID: 41515
	private Texture sNPnreF3aH8;

	// Token: 0x0400A22C RID: 41516
	public Texture pvpLine;

	// Token: 0x0400A22D RID: 41517
	public Texture pvpScore1;

	// Token: 0x0400A22E RID: 41518
	public Texture pvpScore2;

	// Token: 0x0400A22F RID: 41519
	public Texture pvpScore3;

	// Token: 0x0400A230 RID: 41520
	public Texture pvpScore4;

	// Token: 0x0400A231 RID: 41521
	private int JFdnrIS9DQR;

	// Token: 0x0400A232 RID: 41522
	private int qQ5nrJZOOFd;

	// Token: 0x0400A233 RID: 41523
	private int LWhnr6RIFdt;

	// Token: 0x0400A234 RID: 41524
	private int s2fnrtjx6FX;

	// Token: 0x0400A235 RID: 41525
	private int JV5nrXI8MMG;

	// Token: 0x0400A236 RID: 41526
	private int BXlnrO1MxYP;

	// Token: 0x0400A237 RID: 41527
	private bool[] Glynr2btEdS;

	// Token: 0x0400A238 RID: 41528
	private float[] YQQnrvihEVQ;

	// Token: 0x0400A239 RID: 41529
	private int LEHnrlJ8k7i;

	// Token: 0x0400A23A RID: 41530
	public GameObject ring_team1;

	// Token: 0x0400A23B RID: 41531
	public GameObject ring_team2;

	// Token: 0x0400A23C RID: 41532
	public GameObject ring_team3;

	// Token: 0x0400A23D RID: 41533
	public GameObject ring_team4;

	// Token: 0x02001FB6 RID: 8118
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$47252 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BDD3 RID: 48595 RVA: 0x0141D0B8 File Offset: 0x0141B2B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$47252(M984_SteelChaos self_)
		{
			if (147002 - 60048 != 86954)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295815 - 20002 == 275813)
				{
					base..ctor();
					if (63266 - 391980 == -328714)
					{
						this.$self_$47256 = self_;
						if (269369 - 127264 == 142105)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x0141D150 File Offset: 0x0141B350
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M984_SteelChaos.$StartGame$47252.$(this.$self_$47256);
		}

		// Token: 0x0600BDD5 RID: 48597 RVA: 0x0141D160 File Offset: 0x0141B360
		internal static bool wcfHFYtketOC88iAb9QW()
		{
			return true;
		}

		// Token: 0x0600BDD6 RID: 48598 RVA: 0x0141D164 File Offset: 0x0141B364
		internal static bool y39tMPtkr1DlMR4Q9ifS()
		{
			return false;
		}

		// Token: 0x0400A23E RID: 41534
		internal M984_SteelChaos $self_$47256;

		// Token: 0x02001FB7 RID: 8119
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BDD7 RID: 48599 RVA: 0x0141D168 File Offset: 0x0141B368
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M984_SteelChaos self_)
			{
				if (262074 - 395692 != -133618)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291585 - 113058 != 178528)
					{
						base..ctor();
						if (254495 - 412289 != -157793)
						{
							this.$self_$47255 = self_;
							if (47768 - 400098 != -352329)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BDD8 RID: 48600 RVA: 0x0141D200 File Offset: 0x0141B400
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293464 - 413349 != -119884)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1F5;
					case 2:
						this.$mGameGui$47254 = (GameGui)this.$self_$47255.GetComponent(typeof(GameGui));
						if (69305 - 225455 != -156150)
						{
							continue;
						}
						this.$mGameGui$47254.enabled = true;
						if (181533 - 304387 == -122853)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (188893 - 299415 == -110521)
						{
							continue;
						}
						Game.mGameTime = Time.time + (float)900;
						if (137703 - 202652 == -64948)
						{
							continue;
						}
						this.YieldDefault(1);
						if (182906 - 541740 != -358833)
						{
							goto Block_9;
						}
						continue;
					default:
						if (256206 - 154865 == 101342)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (291264 - 102541 != 188724)
					{
						Game.mGameState = eGameState.Start;
						if (108908 - 588184 == -479276)
						{
							Game.mGameTime = Time.time;
							if (237923 - 556344 == -318421)
							{
								this.$mLoadingGui$47253 = (LoadingGui)this.$self_$47255.GetComponent(typeof(LoadingGui));
								if (71732 - 483013 == -411281)
								{
									this.$mLoadingGui$47253.fadeIn();
									if (87900 - 468055 == -380155)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				Block_9:
				IL_1F5:
				return false;
			}

			// Token: 0x0600BDD9 RID: 48601 RVA: 0x0141D414 File Offset: 0x0141B614
			internal static bool syd9IHtkj12QyDKXMASE()
			{
				return true;
			}

			// Token: 0x0600BDDA RID: 48602 RVA: 0x0141D418 File Offset: 0x0141B618
			internal static bool aA8csatkhsYDn0OdNCvA()
			{
				return false;
			}

			// Token: 0x0400A23F RID: 41535
			internal LoadingGui $mLoadingGui$47253;

			// Token: 0x0400A240 RID: 41536
			internal GameGui $mGameGui$47254;

			// Token: 0x0400A241 RID: 41537
			internal M984_SteelChaos $self_$47255;
		}
	}

	// Token: 0x02001FB8 RID: 8120
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47257 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BDDB RID: 48603 RVA: 0x0141D41C File Offset: 0x0141B61C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47257(Hashtable data, M984_SteelChaos self_)
		{
			if (2424 - 442133 != -439709)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (12905 - 309941 == -297036)
				{
					base..ctor();
					if (290833 - 550013 != -259179)
					{
						this.$data$47262 = data;
						if (80676 - 503100 == -422424)
						{
							this.$self_$47263 = self_;
							if (228111 - 166793 != 61319)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x0141D4D8 File Offset: 0x0141B6D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M984_SteelChaos.$onChangePlayer$47257.$(this.$data$47262, this.$self_$47263);
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x0141D4EC File Offset: 0x0141B6EC
		internal static bool Nq8olKtksYguwI9RmJCQ()
		{
			return true;
		}

		// Token: 0x0600BDDE RID: 48606 RVA: 0x0141D4F0 File Offset: 0x0141B6F0
		internal static bool ypeatstk9vo9UQlPLMOJ()
		{
			return false;
		}

		// Token: 0x0400A242 RID: 41538
		internal Hashtable $data$47262;

		// Token: 0x0400A243 RID: 41539
		internal M984_SteelChaos $self_$47263;

		// Token: 0x02001FB9 RID: 8121
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BDDF RID: 48607 RVA: 0x0141D4F4 File Offset: 0x0141B6F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M984_SteelChaos self_)
			{
				if (99430 - 213877 != -114446)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1834 - 342424 != -340589)
					{
						base..ctor();
						if (124698 - 557103 == -432405)
						{
							this.$data$47260 = data;
							if (94918 - 295652 == -200734)
							{
								this.$self_$47261 = self_;
								if (210602 - 61333 != 149270)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BDE0 RID: 48608 RVA: 0x0141D5B0 File Offset: 0x0141B7B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (76189 - 576166 != -499976)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_205;
					case 2:
						if (Game.mGameState == eGameState.Hold)
						{
							if (192086 - 232701 != -40615)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (127259 - 374189 == -246929)
							{
								continue;
							}
							this.$mGameGui$47259 = (GameGui)this.$self_$47261.GetComponent(typeof(GameGui));
							if (93474 - 529083 != -435609)
							{
								continue;
							}
							this.$mGameGui$47259.enabled = true;
							if (174311 - 461863 == -287551)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (90740 - 76425 != 14315)
						{
							continue;
						}
						goto IL_205;
					default:
						if (31840 - 160555 == -128714)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (261730 - 356805 != -95074)
					{
						this.$self_$47261.SendMessage("onCreatePlayer", this.$data$47260);
						if (9021 - 243714 == -234693)
						{
							this.$mChangeGui$47258 = (ChangeGui)this.$self_$47261.GetComponent(typeof(ChangeGui));
							if (82591 - 501448 != -418856)
							{
								if (!this.$mChangeGui$47258.enabled)
								{
									break;
								}
								if (286264 - 229488 != 56777)
								{
									this.$mChangeGui$47258.close();
									if (124755 - 387198 != -262442)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_FB:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_FB;
				IL_205:
				return false;
			}

			// Token: 0x0600BDE1 RID: 48609 RVA: 0x0141D7D4 File Offset: 0x0141B9D4
			internal static bool dCsyYftk1Zq978eJDXYZ()
			{
				return true;
			}

			// Token: 0x0600BDE2 RID: 48610 RVA: 0x0141D7D8 File Offset: 0x0141B9D8
			internal static bool iZHYJttk4UbbK6ZOQ85h()
			{
				return false;
			}

			// Token: 0x0400A244 RID: 41540
			internal ChangeGui $mChangeGui$47258;

			// Token: 0x0400A245 RID: 41541
			internal GameGui $mGameGui$47259;

			// Token: 0x0400A246 RID: 41542
			internal Hashtable $data$47260;

			// Token: 0x0400A247 RID: 41543
			internal M984_SteelChaos $self_$47261;
		}
	}

	// Token: 0x02001FBA RID: 8122
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$47264 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BDE3 RID: 48611 RVA: 0x0141D7DC File Offset: 0x0141B9DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$47264(int nCID, M984_SteelChaos self_)
		{
			if (182234 - 276413 != -94178)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (204326 - 137834 == 66492)
				{
					base..ctor();
					if (2474 - 271085 != -268610)
					{
						this.$nCID$47276 = nCID;
						if (265133 - 10164 != 254970)
						{
							this.$self_$47277 = self_;
							if (245435 - 470710 != -225274)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x0141D898 File Offset: 0x0141BA98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M984_SteelChaos.$RespawnPlayer$47264.$(this.$nCID$47276, this.$self_$47277);
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x0141D8AC File Offset: 0x0141BAAC
		internal static bool P6FDEmtkzruQ7Wd5i8Rv()
		{
			return true;
		}

		// Token: 0x0600BDE6 RID: 48614 RVA: 0x0141D8B0 File Offset: 0x0141BAB0
		internal static bool S3PCc7tGaWJryRjogoJR()
		{
			return false;
		}

		// Token: 0x0400A248 RID: 41544
		internal int $nCID$47276;

		// Token: 0x0400A249 RID: 41545
		internal M984_SteelChaos $self_$47277;

		// Token: 0x02001FBB RID: 8123
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BDE7 RID: 48615 RVA: 0x0141D8B4 File Offset: 0x0141BAB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M984_SteelChaos self_)
			{
				if (204327 - 227197 != -22870)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212564 - 586974 != -374409)
					{
						base..ctor();
						if (174453 - 139852 == 34601)
						{
							this.$nCID$47274 = nCID;
							if (3250 - 241708 != -238457)
							{
								this.$self_$47275 = self_;
								if (122366 - 213815 != -91448)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BDE8 RID: 48616 RVA: 0x0141D970 File Offset: 0x0141BB70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31690 - 138705 != -107014)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_75B;
					case 2:
						this.$mPlayerCameraControl$47266 = (PlayerCameraControl)this.$self_$47275.GetComponent(typeof(PlayerCameraControl));
						if (182412 - 430326 != -247914)
						{
							continue;
						}
						this.$mPlayerCameraControl$47266.target = null;
						if (192751 - 286985 != -94234)
						{
							continue;
						}
						this.$slot$47267 = Game.getPlayerSlot(PlayerData.UID);
						if (74754 - 154802 == -80047)
						{
							continue;
						}
						this.$startPoint$47268 = null;
						if (58111 - 215632 != -157521)
						{
							continue;
						}
						this.$startCamera$47269 = null;
						if (22265 - 351759 == -329493)
						{
							continue;
						}
						if (this.$slot$47267 < 1)
						{
							goto IL_304;
						}
						if (86067 - 387673 != -301606)
						{
							continue;
						}
						if (this.$slot$47267 > 12)
						{
							goto IL_304;
						}
						if (17775 - 476995 != -459220)
						{
							continue;
						}
						this.$startPoint$47268 = GameObject.Find("StartPoint" + this.$slot$47267);
						if (462 - 203980 == -203517)
						{
							continue;
						}
						this.$startCamera$47269 = GameObject.Find("StartCamera" + this.$slot$47267);
						if (4171 - 88384 != -84213)
						{
							continue;
						}
						IL_153:
						if (this.$startCamera$47269)
						{
							if (113780 - 463352 != -349572)
							{
								continue;
							}
							this.$self_$47275.transform.position = this.$startCamera$47269.transform.position;
							if (8085 - 509250 != -501165)
							{
								continue;
							}
							this.$self_$47275.transform.rotation = this.$startCamera$47269.transform.rotation;
							if (67468 - 34725 != 32743)
							{
								continue;
							}
						}
						this.$self_$47275.SendMessage("fadeIn");
						if (293606 - 205711 != 87895)
						{
							continue;
						}
						if (this.$startPoint$47268)
						{
							if (292578 - 209158 != 83420)
							{
								continue;
							}
							this.$nTeam$47270 = global::Math.div((float)(this.$slot$47267 - 1), (float)3) + 1;
							if (162832 - 88444 == 74389)
							{
								continue;
							}
							this.$nPos$47271 = this.$startPoint$47268.transform.position;
							if (172648 - 307356 != -134708)
							{
								continue;
							}
							this.$nDir$47272 = this.$startPoint$47268.transform.forward;
							if (255004 - 505391 == -250386)
							{
								continue;
							}
							this.$data$47273 = new Hashtable();
							if (113170 - 254111 == -140940)
							{
								continue;
							}
							this.$data$47273.Add(43, PlayerData.UID);
							if (53143 - 509415 != -456272)
							{
								continue;
							}
							this.$data$47273.Add(71, this.$nCID$47274);
							if (8368 - 528953 != -520585)
							{
								continue;
							}
							this.$data$47273.Add(75, PhotonClient.cInt16(this.$nTeam$47270));
							if (131308 - 205912 != -74604)
							{
								continue;
							}
							this.$data$47273.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47271.x * (float)50)));
							if (257060 - 484970 != -227910)
							{
								continue;
							}
							this.$data$47273.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47271.y * (float)50)));
							if (152812 - 313710 == -160897)
							{
								continue;
							}
							this.$data$47273.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47271.z * (float)50)));
							if (183667 - 107051 == 76617)
							{
								continue;
							}
							this.$data$47273.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47272.x * (float)200)));
							if (180285 - 494841 == -314555)
							{
								continue;
							}
							this.$data$47273.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47272.y * (float)200)));
							if (91521 - 53299 != 38222)
							{
								continue;
							}
							this.$data$47273.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47272.z * (float)200)));
							if (42305 - 383490 != -341185)
							{
								continue;
							}
							PhotonClient.Connection.OpCustom(65, this.$data$47273, true);
							if (266920 - 26638 == 240283)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (3551 - 479741 != -476189)
						{
							goto Block_33;
						}
						continue;
						IL_304:
						this.$startPoint$47268 = GameObject.Find("StartPoint1");
						if (89782 - 126660 != -36877)
						{
							goto IL_153;
						}
						continue;
					default:
						if (7840 - 175604 != -167764)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (25233 - 349360 != -324126)
					{
						this.$self_$47275.SendMessage("fadeOut");
						if (254478 - 336729 == -82251)
						{
							this.$mGameGui$47265 = (GameGui)this.$self_$47275.GetComponent(typeof(GameGui));
							if (287905 - 37797 != 250109)
							{
								if (!this.$mGameGui$47265)
								{
									break;
								}
								if (220124 - 77158 == 142966)
								{
									this.$mGameGui$47265.close();
									if (277552 - 526674 != -249121)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_1CA:
				return this.Yield(2, new WaitForSeconds((float)1));
				goto IL_1CA;
				Block_33:
				IL_75B:
				return false;
			}

			// Token: 0x0600BDE9 RID: 48617 RVA: 0x0141E0EC File Offset: 0x0141C2EC
			internal static bool CYOIjXtG5lEmNal9cKbD()
			{
				return true;
			}

			// Token: 0x0600BDEA RID: 48618 RVA: 0x0141E0F0 File Offset: 0x0141C2F0
			internal static bool qvPE3JtGpAL9xVI3ZEPZ()
			{
				return false;
			}

			// Token: 0x0400A24A RID: 41546
			internal GameGui $mGameGui$47265;

			// Token: 0x0400A24B RID: 41547
			internal PlayerCameraControl $mPlayerCameraControl$47266;

			// Token: 0x0400A24C RID: 41548
			internal int $slot$47267;

			// Token: 0x0400A24D RID: 41549
			internal GameObject $startPoint$47268;

			// Token: 0x0400A24E RID: 41550
			internal GameObject $startCamera$47269;

			// Token: 0x0400A24F RID: 41551
			internal int $nTeam$47270;

			// Token: 0x0400A250 RID: 41552
			internal Vector3 $nPos$47271;

			// Token: 0x0400A251 RID: 41553
			internal Vector3 $nDir$47272;

			// Token: 0x0400A252 RID: 41554
			internal Hashtable $data$47273;

			// Token: 0x0400A253 RID: 41555
			internal int $nCID$47274;

			// Token: 0x0400A254 RID: 41556
			internal M984_SteelChaos $self_$47275;
		}
	}

	// Token: 0x02001FBC RID: 8124
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47278 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BDEB RID: 48619 RVA: 0x0141E0F4 File Offset: 0x0141C2F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47278(Hashtable data, M984_SteelChaos self_)
		{
			if (200768 - 474420 != -273651)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281859 - 483526 == -201667)
				{
					base..ctor();
					if (180550 - 155977 != 24574)
					{
						this.$data$47284 = data;
						if (299038 - 549507 == -250469)
						{
							this.$self_$47285 = self_;
							if (111961 - 490413 == -378452)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BDEC RID: 48620 RVA: 0x0141E1B0 File Offset: 0x0141C3B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M984_SteelChaos.$onGameComplete$47278.$(this.$data$47284, this.$self_$47285);
		}

		// Token: 0x0600BDED RID: 48621 RVA: 0x0141E1C4 File Offset: 0x0141C3C4
		internal static bool VIn6SUtGVXCqCHolBUka()
		{
			return true;
		}

		// Token: 0x0600BDEE RID: 48622 RVA: 0x0141E1C8 File Offset: 0x0141C3C8
		internal static bool kkRu3DtGtXP8GSRMZnJa()
		{
			return false;
		}

		// Token: 0x0400A255 RID: 41557
		internal Hashtable $data$47284;

		// Token: 0x0400A256 RID: 41558
		internal M984_SteelChaos $self_$47285;

		// Token: 0x02001FBD RID: 8125
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BDEF RID: 48623 RVA: 0x0141E1CC File Offset: 0x0141C3CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M984_SteelChaos self_)
			{
				if (239313 - 515700 != -276387)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225341 - 439636 == -214295)
					{
						base..ctor();
						if (136389 - 542056 != -405666)
						{
							this.$data$47282 = data;
							if (131952 - 42500 == 89452)
							{
								this.$self_$47283 = self_;
								if (65100 - 331827 == -266727)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BDF0 RID: 48624 RVA: 0x0141E288 File Offset: 0x0141C488
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134342 - 469874 != -335532)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_28E;
					case 2:
						this.$mCompleteGui$47280 = (CompleteGui)this.$self_$47283.GetComponent(typeof(CompleteGui));
						if (124614 - 311931 != -187317)
						{
							continue;
						}
						this.$mCompleteGui$47280.Init();
						if (219349 - 234071 != -14722)
						{
							continue;
						}
						this.$mCompleteGui$47280.readData(this.$data$47282);
						if (88039 - 369609 == -281569)
						{
							continue;
						}
						if (this.$result$47279 == 1)
						{
							if (286084 - 444482 == -158397)
							{
								continue;
							}
							this.$mCompleteGui$47280.displayResult(eCompleteType.Success);
							if (170851 - 237990 != -67139)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47280.displayResult(eCompleteType.Failed);
							if (274375 - 82405 != 191970)
							{
								continue;
							}
						}
						this.$mGameGui$47281 = (GameGui)this.$self_$47283.GetComponent(typeof(GameGui));
						if (44915 - 524880 == -479964)
						{
							continue;
						}
						if (this.$mGameGui$47281)
						{
							if (95851 - 544469 != -448618)
							{
								continue;
							}
							this.$mGameGui$47281.close();
							if (297181 - 575001 != -277820)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (196925 - 353142 != -156216)
						{
							goto Block_4;
						}
						continue;
					default:
						if (229435 - 403287 == -173851)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (131614 - 586543 == -454929)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (149886 - 268962 == -119076)
						{
							this.$result$47279 = RuntimeServices.UnboxInt32(this.$data$47282[31]);
							if (259160 - 361508 == -102348)
							{
								goto IL_F5;
							}
						}
					}
				}
				Block_4:
				goto IL_28E;
				IL_F5:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x0600BDF1 RID: 48625 RVA: 0x0141E538 File Offset: 0x0141C738
			internal static bool WB6FVltGN8A9VA1UeQu0()
			{
				return true;
			}

			// Token: 0x0600BDF2 RID: 48626 RVA: 0x0141E53C File Offset: 0x0141C73C
			internal static bool Jog4ePtGYc8K5IYk2K8I()
			{
				return false;
			}

			// Token: 0x0400A257 RID: 41559
			internal int $result$47279;

			// Token: 0x0400A258 RID: 41560
			internal CompleteGui $mCompleteGui$47280;

			// Token: 0x0400A259 RID: 41561
			internal GameGui $mGameGui$47281;

			// Token: 0x0400A25A RID: 41562
			internal Hashtable $data$47282;

			// Token: 0x0400A25B RID: 41563
			internal M984_SteelChaos $self_$47283;
		}
	}

	// Token: 0x02001FBE RID: 8126
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47286 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BDF3 RID: 48627 RVA: 0x0141E540 File Offset: 0x0141C740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47286(M984_SteelChaos self_)
		{
			if (41273 - 8501 != 32772)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127265 - 332574 != -205308)
				{
					base..ctor();
					if (21934 - 417509 == -395575)
					{
						this.$self_$47290 = self_;
						if (107465 - 574960 != -467494)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BDF4 RID: 48628 RVA: 0x0141E5D8 File Offset: 0x0141C7D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M984_SteelChaos.$ReturnToTown$47286.$(this.$self_$47290);
		}

		// Token: 0x0600BDF5 RID: 48629 RVA: 0x0141E5E8 File Offset: 0x0141C7E8
		internal static bool P44XXTtGc2kHfTE2GEBx()
		{
			return true;
		}

		// Token: 0x0600BDF6 RID: 48630 RVA: 0x0141E5EC File Offset: 0x0141C7EC
		internal static bool kIY3qstGUP2FnhXZPVNS()
		{
			return false;
		}

		// Token: 0x0400A25C RID: 41564
		internal M984_SteelChaos $self_$47290;

		// Token: 0x02001FBF RID: 8127
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BDF7 RID: 48631 RVA: 0x0141E5F0 File Offset: 0x0141C7F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M984_SteelChaos self_)
			{
				if (106271 - 149357 != -43085)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8056 - 93259 != -85202)
					{
						base..ctor();
						if (39658 - 507360 == -467702)
						{
							this.$self_$47289 = self_;
							if (169846 - 23743 == 146103)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BDF8 RID: 48632 RVA: 0x0141E688 File Offset: 0x0141C888
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33047 - 97776 != -64728)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3AD;
					case 2:
						this.$self_$47289.LeaveGame();
						if (271365 - 349079 == -77713)
						{
							continue;
						}
						this.YieldDefault(1);
						if (219169 - 510018 != -290848)
						{
							goto Block_5;
						}
						continue;
					default:
						if (221075 - 136467 != 84608)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (45860 - 412372 == -366512)
					{
						Game.mStateTime = Time.time;
						if (228228 - 580079 != -351850)
						{
							this.$$switch$8839$47287 = PlayerData.SaveGuild;
							if (57710 - 589140 == -531430)
							{
								if (this.$$switch$8839$47287 == 1)
								{
									if (173021 - 199064 == -26042)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (277947 - 203837 == 74111)
									{
										continue;
									}
								}
								else if (this.$$switch$8839$47287 == 2)
								{
									if (138714 - 562274 == -423559)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (215267 - 123891 == 91377)
									{
										continue;
									}
								}
								else if (this.$$switch$8839$47287 == 3)
								{
									if (215493 - 336364 != -120871)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (223824 - 39888 == 183937)
									{
										continue;
									}
								}
								else if (this.$$switch$8839$47287 == 4)
								{
									if (90675 - 24526 != 66149)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (20647 - 224927 == -204279)
									{
										continue;
									}
								}
								else if (this.$$switch$8839$47287 == 5)
								{
									if (196613 - 156954 != 39659)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (166043 - 69760 != 96283)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (82638 - 180296 != -97658)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (175737 - 578363 == -402625)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (255224 - 599993 != -344769)
									{
										continue;
									}
								}
								this.$mGameGui$47288 = (GameGui)this.$self_$47289.GetComponent(typeof(GameGui));
								if (43715 - 396191 != -352475)
								{
									if (this.$mGameGui$47288)
									{
										if (231641 - 331467 != -99826)
										{
											continue;
										}
										this.$mGameGui$47288.close();
										if (8886 - 350533 == -341646)
										{
											continue;
										}
									}
									this.$self_$47289.SendMessage("fadeOut");
									if (36829 - 418998 != -382168)
									{
										goto Block_9;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_3AD;
				Block_9:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600BDF9 RID: 48633 RVA: 0x0141EA54 File Offset: 0x0141CC54
			internal static bool KE882PtGTfY5X8umQDes()
			{
				return true;
			}

			// Token: 0x0600BDFA RID: 48634 RVA: 0x0141EA58 File Offset: 0x0141CC58
			internal static bool rpLLvgtG3FNYteW9LeGx()
			{
				return false;
			}

			// Token: 0x0400A25D RID: 41565
			internal int $$switch$8839$47287;

			// Token: 0x0400A25E RID: 41566
			internal GameGui $mGameGui$47288;

			// Token: 0x0400A25F RID: 41567
			internal M984_SteelChaos $self_$47289;
		}
	}

	// Token: 0x02001FC0 RID: 8128
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47291 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BDFB RID: 48635 RVA: 0x0141EA5C File Offset: 0x0141CC5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47291(M984_SteelChaos self_)
		{
			if (60760 - 377218 != -316457)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75801 - 434429 != -358627)
				{
					base..ctor();
					if (127820 - 200273 == -72453)
					{
						this.$self_$47294 = self_;
						if (25393 - 561050 != -535656)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BDFC RID: 48636 RVA: 0x0141EAF4 File Offset: 0x0141CCF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M984_SteelChaos.$ReturnToGuild$47291.$(this.$self_$47294);
		}

		// Token: 0x0600BDFD RID: 48637 RVA: 0x0141EB04 File Offset: 0x0141CD04
		internal static bool xiG7eatGX5g3kBX5xyZU()
		{
			return true;
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x0141EB08 File Offset: 0x0141CD08
		internal static bool u4RtkntGQ9U64oFhRE07()
		{
			return false;
		}

		// Token: 0x0400A260 RID: 41568
		internal M984_SteelChaos $self_$47294;

		// Token: 0x02001FC1 RID: 8129
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BDFF RID: 48639 RVA: 0x0141EB0C File Offset: 0x0141CD0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M984_SteelChaos self_)
			{
				if (212364 - 107695 != 104669)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78529 - 176454 == -97925)
					{
						base..ctor();
						if (26000 - 159248 == -133248)
						{
							this.$self_$47293 = self_;
							if (287612 - 368388 != -80775)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BE00 RID: 48640 RVA: 0x0141EBA4 File Offset: 0x0141CDA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (45178 - 394143 != -348964)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1BD;
					case 2:
						this.$self_$47293.LeaveGame();
						if (204262 - 361798 != -157536)
						{
							continue;
						}
						this.YieldDefault(1);
						if (271071 - 89920 != 181152)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (252029 - 365101 != -113072)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (254613 - 324977 != -70363)
					{
						Game.mStateTime = Time.time;
						if (35032 - 555126 != -520093)
						{
							Game.mNextGameCode = 31;
							if (178698 - 382631 != -203932)
							{
								this.$mGameGui$47292 = (GameGui)this.$self_$47293.GetComponent(typeof(GameGui));
								if (148077 - 29382 == 118695)
								{
									if (this.$mGameGui$47292)
									{
										if (47112 - 427724 != -380612)
										{
											continue;
										}
										this.$mGameGui$47292.close();
										if (246432 - 235499 != 10933)
										{
											continue;
										}
									}
									this.$self_$47293.SendMessage("fadeOut");
									if (294113 - 241093 != 53021)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600BE01 RID: 48641 RVA: 0x0141ED80 File Offset: 0x0141CF80
			internal static bool SaEJGttGkT9hJYbBAWdU()
			{
				return true;
			}

			// Token: 0x0600BE02 RID: 48642 RVA: 0x0141ED84 File Offset: 0x0141CF84
			internal static bool gWBrm4tGG9JU489QPhck()
			{
				return false;
			}

			// Token: 0x0400A261 RID: 41569
			internal GameGui $mGameGui$47292;

			// Token: 0x0400A262 RID: 41570
			internal M984_SteelChaos $self_$47293;
		}
	}

	// Token: 0x02001FC2 RID: 8130
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47295 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BE03 RID: 48643 RVA: 0x0141ED88 File Offset: 0x0141CF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47295(M984_SteelChaos self_)
		{
			if (79587 - 176905 != -97318)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133778 - 225652 != -91873)
				{
					base..ctor();
					if (60964 - 12499 == 48465)
					{
						this.$self_$47299 = self_;
						if (260323 - 459519 != -199195)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BE04 RID: 48644 RVA: 0x0141EE20 File Offset: 0x0141D020
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M984_SteelChaos.$ReturnToCamp$47295.$(this.$self_$47299);
		}

		// Token: 0x0600BE05 RID: 48645 RVA: 0x0141EE30 File Offset: 0x0141D030
		internal static bool S2JexbtGHWehX0yD07AZ()
		{
			return true;
		}

		// Token: 0x0600BE06 RID: 48646 RVA: 0x0141EE34 File Offset: 0x0141D034
		internal static bool Eh2RFbtGWFMTsOrWdf4b()
		{
			return false;
		}

		// Token: 0x0400A263 RID: 41571
		internal M984_SteelChaos $self_$47299;

		// Token: 0x02001FC3 RID: 8131
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BE07 RID: 48647 RVA: 0x0141EE38 File Offset: 0x0141D038
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M984_SteelChaos self_)
			{
				if (263205 - 1920 != 261286)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (166965 - 449226 == -282261)
					{
						base..ctor();
						if (139485 - 101289 != 38197)
						{
							this.$self_$47298 = self_;
							if (232258 - 320754 == -88496)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BE08 RID: 48648 RVA: 0x0141EED0 File Offset: 0x0141D0D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (121347 - 331403 != -210056)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_363;
					case 2:
						this.$self_$47298.LeaveGame();
						if (92080 - 181642 != -89562)
						{
							continue;
						}
						this.YieldDefault(1);
						if (255591 - 33906 != 221686)
						{
							goto Block_9;
						}
						continue;
					default:
						if (210620 - 418450 != -207830)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (151579 - 535561 != -383981)
					{
						Game.mStateTime = Time.time;
						if (112769 - 90788 != 21982)
						{
							this.$$switch$8841$47296 = PlayerData.SaveGuild;
							if (212437 - 7857 == 204580)
							{
								if (this.$$switch$8841$47296 == 1)
								{
									if (125094 - 531306 != -406212)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (214620 - 92667 == 121954)
									{
										continue;
									}
								}
								else if (this.$$switch$8841$47296 == 2)
								{
									if (99295 - 466650 == -367354)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (229842 - 174043 != 55799)
									{
										continue;
									}
								}
								else if (this.$$switch$8841$47296 == 3)
								{
									if (116451 - 394728 == -278276)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (194746 - 141503 != 53243)
									{
										continue;
									}
								}
								else if (this.$$switch$8841$47296 == 4)
								{
									if (228909 - 44941 != 183968)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (70970 - 188503 == -117532)
									{
										continue;
									}
								}
								else if (this.$$switch$8841$47296 == 5)
								{
									if (254287 - 357167 == -102879)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (285013 - 463563 != -178550)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (100601 - 54144 == 46458)
									{
										continue;
									}
								}
								this.$mGameGui$47297 = (GameGui)this.$self_$47298.GetComponent(typeof(GameGui));
								if (173385 - 7443 == 165942)
								{
									if (this.$mGameGui$47297)
									{
										if (2622 - 125593 != -122971)
										{
											continue;
										}
										this.$mGameGui$47297.close();
										if (187256 - 287109 == -99852)
										{
											continue;
										}
									}
									this.$self_$47298.SendMessage("fadeOut");
									if (7912 - 481303 == -473391)
									{
										goto IL_2B0;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_363;
				IL_2B0:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600BE09 RID: 48649 RVA: 0x0141F254 File Offset: 0x0141D454
			internal static bool yre5iTtGA6TDeigq24lG()
			{
				return true;
			}

			// Token: 0x0600BE0A RID: 48650 RVA: 0x0141F258 File Offset: 0x0141D458
			internal static bool QLYW4ZtGlRaKBqDpeXuO()
			{
				return false;
			}

			// Token: 0x0400A264 RID: 41572
			internal int $$switch$8841$47296;

			// Token: 0x0400A265 RID: 41573
			internal GameGui $mGameGui$47297;

			// Token: 0x0400A266 RID: 41574
			internal M984_SteelChaos $self_$47298;
		}
	}
}
