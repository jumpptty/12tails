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

// Token: 0x0200192D RID: 6445
[Serializable]
public class M913_CarrierSite2 : MonoBehaviour
{
	// Token: 0x060095FA RID: 38394 RVA: 0x011C2590 File Offset: 0x011C0790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M913_CarrierSite2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060095FB RID: 38395 RVA: 0x011C25A0 File Offset: 0x011C07A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (40190 - 514665 != -474474)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (38012 - 223069 != -185056)
			{
				Game.mGameType = 5;
				if (259522 - 293302 != -33779)
				{
					if (Chat.Initialized)
					{
						if (100772 - 82996 != 17777)
						{
							Chat.ChatDisplay.Clear();
							if (53 - 385399 != -385345)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (32952 - 150972 == -118020)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060095FC RID: 38396 RVA: 0x011C2684 File Offset: 0x011C0884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (269919 - 139229 != 130691)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (242961 - 336617 == -93656)
				{
					Game.nextGame();
					if (191898 - 571524 == -379626)
					{
						Game.mGameCode = 913;
						if (246158 - 277337 == -31179)
						{
							Game.mGameType = 5;
							if (70476 - 370851 != -300374)
							{
								Game.mGameTime = Time.time;
								if (197340 - 327331 != -129990)
								{
									Game.mGameScore = 0;
									if (59730 - 428576 == -368846)
									{
										Game.mGameMana = 0;
										if (274434 - 64992 != 209443)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (44146 - 427767 != -383620)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (270171 - 368163 != -97991)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (179296 - 76966 != 102331)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (226874 - 391614 != -164739)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (16545 - 14026 != 2520)
															{
																this.snEnnYEMQmw = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (30756 - 540784 != -510027)
																{
																	this.os9nnTTWWa3 = PhotonClient.Connection;
																	if (273800 - 13640 != 260161)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (289339 - 137206 != 152134)
																		{
																			this.InitGame();
																			if (277219 - 78537 == 198682)
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
				if (95188 - 451606 != -356417)
				{
					Game.mGameType = 99;
					if (145268 - 589894 == -444626)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060095FD RID: 38397 RVA: 0x011C2964 File Offset: 0x011C0B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (84462 - 389677 != -305215)
		{
		}
		for (;;)
		{
			if (this.os9nnTTWWa3 == null)
			{
				if (160549 - 209445 != -48895)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (195319 - 107503 == 87816)
				{
					if (mGameState == eGameState.Init)
					{
						if (15521 - 476612 == -461091)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (21828 - 548299 != -526470)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (174640 - 312176 == -137536)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (294632 - 210444 == 84188)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (35501 - 447706 != -412204)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (82940 - 7133 == 75807)
						{
							if (Game.music != 0)
							{
								if (108671 - 112069 != -3398)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (86070 - 473378 == -387307)
									{
										continue;
									}
									this.audio.Play();
									if (232074 - 66376 == 165699)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (295968 - 279367 == 16602)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (138256 - 568673 != -430417)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (249519 - 275717 == -26197)
								{
									continue;
								}
							}
							if (Time.time <= this.kZRnn3W61Ci)
							{
								break;
							}
							if (140989 - 485809 == -344820)
							{
								Game.mGameMana++;
								if (137197 - 263163 == -125966)
								{
									this.kZRnn3W61Ci = Time.time + (float)12;
									if (34439 - 568699 == -534260)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (254589 - 507121 == -252532)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (104625 - 299448 != -194822)
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
						if (26868 - 266831 != -239962)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060095FE RID: 38398 RVA: 0x011C2CD8 File Offset: 0x011C0ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (599 - 73317 != -72718)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (271927 - 596697 != -324769)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (286908 - 167611 == 119297)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (251662 - 309204 != -57541)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (226293 - 46624 == 179669)
						{
							int num4 = num;
							if (38327 - 123386 == -85059)
							{
								if (num4 == 9131)
								{
									if (112640 - 538186 != -425545)
									{
										break;
									}
								}
								else if (num4 == 9132)
								{
									if (245241 - 162068 == 83173)
									{
										break;
									}
								}
								else if (num4 == -9132)
								{
									if (74450 - 452657 == -378207)
									{
										if (this.yQ2nnbXvGBc >= num2)
										{
											break;
										}
										if (259554 - 515962 == -256408)
										{
											this.yQ2nnbXvGBc = num2;
											if (155158 - 437612 != -282453)
											{
												int num5 = num2;
												if (195492 - 50530 != 144963)
												{
													if (num5 == 1)
													{
														if (265752 - 477749 != -211996)
														{
															this.StartCoroutine_Auto(this.CarrierEvent());
															if (89770 - 365442 == -275672)
															{
																break;
															}
														}
													}
													else
													{
														if (num5 != 2)
														{
															break;
														}
														if (238281 - 196453 == 41828)
														{
															GameObject gameObject = GameObject.Find("NPC");
															if (90244 - 105488 == -15244)
															{
																if (gameObject)
																{
																	if (8657 - 212063 != -203406)
																	{
																		continue;
																	}
																	UnityEngine.Object.Destroy(gameObject);
																	if (16279 - 41851 == -25571)
																	{
																		continue;
																	}
																}
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (72522 - 44904 == 27618)
																{
																	this.spawnActor("CarrierBot", 9, 1);
																	if (103492 - 263566 == -160074)
																	{
																		this.spawnActor("CutBot", 9, 2);
																		if (248885 - 36631 != 212255)
																		{
																			this.spawnActor("CutBot", 9, 3);
																			if (9165 - 519918 == -510753)
																			{
																				this.spawnActor("CutBot", 9, 4);
																				if (251589 - 159314 == 92275)
																				{
																					this.spawnActor("CutBot", 9, 5);
																					if (252827 - 312094 != -59266)
																					{
																						this.spawnActor("CutBot", 9, 6);
																						if (58497 - 39407 != 19091)
																						{
																							this.spawnActor("CutBot", 9, 7);
																							if (145777 - 50296 == 95481)
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
								else if (num4 == 9133)
								{
									if (168317 - 521784 == -353467)
									{
										this.qPCnndoGA8n++;
										if (210297 - 115245 != 95053)
										{
											if (num2 != 4)
											{
												break;
											}
											if (130405 - 292259 == -161854)
											{
												Game.sendMissionEvent(9131, 2);
												if (104171 - 24401 != 79771)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (194304 - 507983 == -313679)
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

	// Token: 0x060095FF RID: 38399 RVA: 0x011C31B0 File Offset: 0x011C13B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator CarrierEvent()
	{
		return new M913_CarrierSite2.$CarrierEvent$42101(this).GetEnumerator();
	}

	// Token: 0x06009600 RID: 38400 RVA: 0x011C31C0 File Offset: 0x011C13C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterCarrierZone()
	{
		if (this.yQ2nnbXvGBc < 1)
		{
			Game.sendMissionEvent(9132, 1);
		}
	}

	// Token: 0x06009601 RID: 38401 RVA: 0x011C31DC File Offset: 0x011C13DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (42881 - 292677 != -249795)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (99734 - 479640 != -379905)
			{
				Time.timeScale = 1f;
				if (90055 - 454914 == -364859)
				{
					Hashtable customOpParameters = new Hashtable();
					if (273479 - 233170 != 40310)
					{
						this.os9nnTTWWa3.OpCustom(52, customOpParameters, true);
						if (179424 - 306264 != -126839)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009602 RID: 38402 RVA: 0x011C32A8 File Offset: 0x011C14A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (160703 - 171997 != -11293)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (205035 - 127882 != 77154)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (240233 - 504755 != -264521)
				{
					Game.mGameState = eGameState.Setup;
					if (206163 - 374604 != -168440)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009603 RID: 38403 RVA: 0x011C334C File Offset: 0x011C154C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (173770 - 382018 != -208248)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (254873 - 22240 == 232633)
			{
				if (num == PlayerData.UID)
				{
					if (260788 - 580340 != -319551)
					{
						this.SetupActors();
						if (104143 - 505083 != -400939)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (144800 - 490850 == -346050)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009604 RID: 38404 RVA: 0x011C341C File Offset: 0x011C161C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (214716 - 188085 != 26631)
		{
		}
		for (;;)
		{
			IL_130:
			Debug.Log("Creating Actors");
			if (54418 - 192981 != -138562)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (192958 - 575246 == -382288)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (59653 - 501074 != -441420)
						{
							int i = 0;
							if (104056 - 191192 == -87136)
							{
								CharacterControl[] array2 = array;
								if (62781 - 128502 == -65721)
								{
									int length = array2.Length;
									if (112275 - 598200 == -485925)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (173757 - 441002 == -267244)
												{
													goto IL_130;
												}
												string type = array2[i].Type;
												if (187244 - 87084 != 100160)
												{
													goto IL_130;
												}
												if (type == "Carron_p")
												{
													goto IL_65;
												}
												if (36347 - 457850 != -421503)
												{
													goto IL_130;
												}
												if (type == "CamBot")
												{
													goto IL_65;
												}
												if (154071 - 444459 != -290388)
												{
													goto IL_130;
												}
												if (type == "CutBot")
												{
													goto IL_65;
												}
												if (84469 - 14244 != 70225)
												{
													goto IL_130;
												}
												if (type == "CarryBot")
												{
													if (1399 - 553570 != -552171)
													{
														goto IL_130;
													}
													goto IL_65;
												}
												IL_2D4:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (215982 - 139051 == 76932)
												{
													goto IL_130;
												}
												this.G2XnngwDI3l++;
												if (4524 - 473967 != -469443)
												{
													goto IL_130;
												}
												goto IL_1A;
												IL_65:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (295088 - 276471 != 18618)
												{
													goto IL_2D4;
												}
												goto IL_130;
											}
											IL_1A:
											i++;
											if (113521 - 300173 == -186651)
											{
												goto IL_130;
											}
										}
										if (41438 - 436979 == -395541)
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
						if (294007 - 139295 == 154712)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009605 RID: 38405 RVA: 0x011C3738 File Offset: 0x011C1938
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (233735 - 7778 != 225958)
		{
		}
		for (;;)
		{
			IL_84:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (80489 - 79687 == 802)
			{
				int i = 0;
				if (225320 - 590797 == -365477)
				{
					CharacterControl[] array2 = array;
					if (55742 - 453685 != -397942)
					{
						int length = array2.Length;
						if (127591 - 476380 == -348789)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (181374 - 564132 != -382758)
								{
									goto IL_84;
								}
								i++;
								if (9100 - 417507 == -408406)
								{
									goto IL_84;
								}
							}
							if (194608 - 300272 == -105664)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009606 RID: 38406 RVA: 0x011C3868 File Offset: 0x011C1A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (239175 - 306295 != -67120)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (231295 - 478527 != -247231)
			{
				Game.mGameState = eGameState.Ready;
				if (216766 - 316926 != -100159)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (175951 - 534850 != -358898)
					{
						if (240258 - 264017 == -23759)
						{
							GameObject gameObject = null;
							if (88419 - 410086 != -321666)
							{
								if (playerSlot < 1)
								{
									goto IL_2DF;
								}
								if (63167 - 530415 != -467248)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_2DF;
								}
								if (196504 - 399005 != -202501)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (271036 - 128674 == 142363)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (166336 - 103790 == 62547)
								{
									continue;
								}
								IL_1E3:
								if (gameObject2)
								{
									if (210730 - 30917 == 179814)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (237398 - 562443 == -325044)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (243862 - 447560 == -203697)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (156475 - 339362 != -182887)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (91438 - 597052 != -505614)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (12056 - 291742 == -279685)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (165329 - 477990 == -312660)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (30179 - 116228 != -86048)
								{
									break;
								}
								continue;
								IL_2DF:
								gameObject2 = GameObject.Find("StartPoint1");
								if (51061 - 78548 != -27486)
								{
									goto IL_1E3;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009607 RID: 38407 RVA: 0x011C3B8C File Offset: 0x011C1D8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M913_CarrierSite2.$StartGame$42108(this).GetEnumerator();
	}

	// Token: 0x06009608 RID: 38408 RVA: 0x011C3B9C File Offset: 0x011C1D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009609 RID: 38409 RVA: 0x011C3BA0 File Offset: 0x011C1DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (101413 - 295295 != -193882)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (105809 - 220151 == -114342)
			{
				if (gameObject)
				{
					if (251780 - 523757 == -271977)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (231095 - 452643 == -221548)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (252402 - 336100 == -83698)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600960A RID: 38410 RVA: 0x011C3C9C File Offset: 0x011C1E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (192003 - 35335 != 156668)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (274361 - 578948 != -304586)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (88514 - 210139 != -121624)
				{
					hashtable.Add(43, PlayerData.UID);
					if (151542 - 326430 == -174888)
					{
						hashtable.Add(73, nType);
						if (297684 - 582258 == -284574)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (61171 - 583012 != -521840)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (242129 - 234254 != 7876)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (183024 - 383382 == -200358)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (191997 - 178377 != 13621)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (161042 - 359967 != -198924)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (136806 - 366942 != -230135)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (59808 - 395276 == -335468)
													{
														this.os9nnTTWWa3.OpCustom(63, hashtable, true);
														if (262365 - 390934 != -128568)
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

	// Token: 0x0600960B RID: 38411 RVA: 0x011C3F80 File Offset: 0x011C2180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (103298 - 568208 != -464910)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (255675 - 405214 != -149538)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (136206 - 465200 != -328993)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (50725 - 320257 != -269531)
						{
							if (this.G2XnngwDI3l <= 0)
							{
								break;
							}
							if (128826 - 34671 == 94155)
							{
								this.G2XnngwDI3l--;
								if (61661 - 103675 == -42014)
								{
									if (this.G2XnngwDI3l != 0)
									{
										break;
									}
									if (215032 - 262999 != -47966)
									{
										Game.setGameState(eGameState.Ready);
										if (162757 - 468932 == -306175)
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
						if (295000 - 243378 != 51623)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (237366 - 557881 != -320514)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600960C RID: 38412 RVA: 0x011C4110 File Offset: 0x011C2310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600960D RID: 38413 RVA: 0x011C4124 File Offset: 0x011C2324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (37812 - 367627 != -329814)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (123819 - 252996 == -129177)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (54513 - 6863 != 47651)
				{
					if (!characterControl)
					{
						break;
					}
					if (31155 - 39596 == -8441)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (92242 - 589001 != -496758)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (70648 - 465716 == -395068)
							{
								string type = characterControl.Type;
								if (110828 - 95023 != 15806)
								{
									if (type == "CamBot")
									{
										if (234335 - 35765 != 198571)
										{
											Game.sendMissionEvent(9133, 1);
											if (59507 - 183512 != -124004)
											{
												break;
											}
										}
									}
									else if (type == "CutBot")
									{
										if (296264 - 570821 != -274556)
										{
											Game.sendMissionEvent(9133, 2);
											if (16815 - 329621 == -312806)
											{
												break;
											}
										}
									}
									else if (type == "CarryBot")
									{
										if (203686 - 246416 != -42729)
										{
											Game.sendMissionEvent(9133, 3);
											if (49833 - 581905 == -532072)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CarrierBot"))
										{
											break;
										}
										if (252191 - 478295 == -226104)
										{
											Game.sendMissionEvent(9133, 4);
											if (33176 - 252326 != -219149)
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

	// Token: 0x0600960E RID: 38414 RVA: 0x011C4398 File Offset: 0x011C2598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (292514 - 408638 != -116124)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (276363 - 572502 != -296138)
			{
				hashtable.Add(71, CID);
				if (131634 - 135069 == -3435)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (186872 - 184216 == 2656)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (115305 - 174276 != -58970)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (9597 - 182635 == -173038)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (118473 - 543770 == -425297)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (70460 - 373518 == -303058)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (41132 - 68777 != -27644)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (243794 - 145895 != 97900)
											{
												this.os9nnTTWWa3.OpCustom(61, hashtable, true);
												if (237933 - 201598 == 36335)
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

	// Token: 0x0600960F RID: 38415 RVA: 0x011C4624 File Offset: 0x011C2824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (50972 - 27529 != 23443)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (178295 - 174716 != 3580)
			{
				if (!gameObject)
				{
					break;
				}
				if (150289 - 118460 == 31829)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (255607 - 380100 != -124492)
					{
						playerCameraControl.target = gameObject;
						if (215842 - 343854 == -128012)
						{
							if (Game.useAdvanceMode)
							{
								if (237637 - 32925 == 204713)
								{
									continue;
								}
								Game.loadPlayer();
								if (139350 - 584425 == -445074)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (44472 - 60544 == -16072)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009610 RID: 38416 RVA: 0x011C4760 File Offset: 0x011C2960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (168953 - 446778 != -277824)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (200452 - 209114 != -8661)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (230987 - 12967 == 218020)
				{
					gameGui.ResetTeamBar();
					if (157623 - 370204 == -212581)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009611 RID: 38417 RVA: 0x011C480C File Offset: 0x011C2A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M913_CarrierSite2.$onDeadPlayer$42112(this).GetEnumerator();
	}

	// Token: 0x06009612 RID: 38418 RVA: 0x011C481C File Offset: 0x011C2A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (95028 - 230443 != -135415)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (4494 - 544854 != -540359)
			{
				this.snEnnYEMQmw.target = Game.mPlayer;
				if (252257 - 288464 != -36206)
				{
					this.snEnnYEMQmw.enabled = true;
					if (277240 - 95227 != 182014)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (231766 - 321459 != -89693)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (245227 - 88016 != 157211)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (86967 - 329222 == -242255)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (201279 - 194792 == 6487)
							{
								if (!gameGui)
								{
									break;
								}
								if (197754 - 44896 != 152859)
								{
									gameGui.enabled = true;
									if (148922 - 504452 == -355530)
									{
										gameGui.closeDeadMenu();
										if (282479 - 99957 == 182522)
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

	// Token: 0x06009613 RID: 38419 RVA: 0x011C49C8 File Offset: 0x011C2BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (68313 - 318679 != -250366)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (207666 - 493873 == -286207)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (194636 - 445269 == -250633)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (92566 - 224657 == -132091)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009614 RID: 38420 RVA: 0x011C4A8C File Offset: 0x011C2C8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009615 RID: 38421 RVA: 0x011C4AB8 File Offset: 0x011C2CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (32623 - 372318 != -339694)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (267428 - 177899 != 89530)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (132250 - 114854 != 17397)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (297804 - 211672 != 86133)
					{
						Hashtable hashtable = new Hashtable();
						if (289454 - 26511 != 262944)
						{
							hashtable.Add(43, PlayerData.UID);
							if (224196 - 169485 == 54711)
							{
								hashtable.Add(71, nCID);
								if (286281 - 484464 != -198182)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (40543 - 334517 != -293973)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (294678 - 71942 == 222736)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (214900 - 539326 != -324425)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (191439 - 60177 != 131263)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (46919 - 258681 != -211761)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (299259 - 362421 != -63161)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (249526 - 513457 != -263930)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (150729 - 136208 != 14522)
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

	// Token: 0x06009616 RID: 38422 RVA: 0x011C4DD8 File Offset: 0x011C2FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M913_CarrierSite2.$onChangePlayer$42118(data, this).GetEnumerator();
	}

	// Token: 0x06009617 RID: 38423 RVA: 0x011C4DE8 File Offset: 0x011C2FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M913_CarrierSite2.$onGameComplete$42125(data, this).GetEnumerator();
	}

	// Token: 0x06009618 RID: 38424 RVA: 0x011C4DF8 File Offset: 0x011C2FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M913_CarrierSite2.$ReturnToTown$42135(this).GetEnumerator();
	}

	// Token: 0x06009619 RID: 38425 RVA: 0x011C4E08 File Offset: 0x011C3008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M913_CarrierSite2.$ReturnToGuild$42140(this).GetEnumerator();
	}

	// Token: 0x0600961A RID: 38426 RVA: 0x011C4E18 File Offset: 0x011C3018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M913_CarrierSite2.$ReturnToCamp$42144(this).GetEnumerator();
	}

	// Token: 0x0600961B RID: 38427 RVA: 0x011C4E28 File Offset: 0x011C3028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (100937 - 132295 != -31357)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (71661 - 290407 == -218746)
			{
				Hashtable hashtable = new Hashtable();
				if (131867 - 290573 == -158706)
				{
					hashtable.Add(43, PlayerData.UID);
					if (292085 - 448873 != -156787)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (57148 - 113669 != -56520)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600961C RID: 38428 RVA: 0x011C4F00 File Offset: 0x011C3100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600961D RID: 38429 RVA: 0x011C4F14 File Offset: 0x011C3114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (70436 - 22429 != 48007)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (27455 - 569653 == -542198)
			{
				Hashtable hashtable = new Hashtable();
				if (58590 - 174256 != -115665)
				{
					if (Game.mNextGameCode == 30)
					{
						if (86770 - 302889 != -216119)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (126791 - 292979 == -166187)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (43751 - 468527 == -424775)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (16174 - 313465 != -297291)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (104720 - 146130 == -41409)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (55564 - 346288 == -290723)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (139019 - 21865 == 117155)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (124511 - 47053 == 77459)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (30783 - 335286 != -304503)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (16505 - 115606 == -99100)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (129128 - 481011 != -351883)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (23365 - 581758 == -558392)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (157567 - 48654 != 108913)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (17273 - 78931 == -61657)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (86327 - 405267 == -318939)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (28373 - 8176 != 20197)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (95123 - 587416 != -492293)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (177755 - 390056 == -212300)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (55898 - 455539 == -399640)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (187401 - 94706 == 92696)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (64244 - 591506 == -527261)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (150320 - 85369 != 64951)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (70486 - 332531 != -262045)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (34378 - 42082 != -7704)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (179973 - 122213 != 57760)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (129982 - 248391 != -118409)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (175291 - 382179 == -206887)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (12013 - 135046 == -123032)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (160291 - 302540 != -142248)
					{
						this.os9nnTTWWa3.OpCustom(42, hashtable, true);
						if (1357 - 470085 != -468727)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600961E RID: 38430 RVA: 0x011C54C8 File Offset: 0x011C36C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600961F RID: 38431 RVA: 0x011C54D8 File Offset: 0x011C36D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009620 RID: 38432 RVA: 0x011C54DC File Offset: 0x011C36DC
	internal static bool aGq41QVojK3mpG0dIdtT()
	{
		return true;
	}

	// Token: 0x06009621 RID: 38433 RVA: 0x011C54E0 File Offset: 0x011C36E0
	internal static bool p2XRB5VohIGYGHxuMc1F()
	{
		return false;
	}

	// Token: 0x04008BED RID: 35821
	private LitePeer os9nnTTWWa3;

	// Token: 0x04008BEE RID: 35822
	private PlayerCameraControl snEnnYEMQmw;

	// Token: 0x04008BEF RID: 35823
	private float kZRnn3W61Ci;

	// Token: 0x04008BF0 RID: 35824
	private int yQ2nnbXvGBc;

	// Token: 0x04008BF1 RID: 35825
	private int qPCnndoGA8n;

	// Token: 0x04008BF2 RID: 35826
	private int G2XnngwDI3l;

	// Token: 0x0200192E RID: 6446
	[CompilerGenerated]
	[Serializable]
	internal sealed class $CarrierEvent$42101 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009622 RID: 38434 RVA: 0x011C54E4 File Offset: 0x011C36E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $CarrierEvent$42101(M913_CarrierSite2 self_)
		{
			if (154950 - 364543 != -209593)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50717 - 237340 == -186623)
				{
					base..ctor();
					if (56751 - 77664 == -20913)
					{
						this.$self_$42107 = self_;
						if (27439 - 177437 != -149997)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x011C557C File Offset: 0x011C377C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite2.$CarrierEvent$42101.$(this.$self_$42107);
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x011C558C File Offset: 0x011C378C
		internal static bool zIOYjpVosRSNWnovy8uI()
		{
			return true;
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x011C5590 File Offset: 0x011C3790
		internal static bool MiIiQTVo9PClNBYmbF3T()
		{
			return false;
		}

		// Token: 0x04008BF3 RID: 35827
		internal M913_CarrierSite2 $self_$42107;

		// Token: 0x0200192F RID: 6447
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009626 RID: 38438 RVA: 0x011C5594 File Offset: 0x011C3794
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite2 self_)
			{
				if (130632 - 87254 != 43379)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94058 - 579584 != -485525)
					{
						base..ctor();
						if (272677 - 382906 != -110228)
						{
							this.$self_$42106 = self_;
							if (297776 - 262434 != 35343)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009627 RID: 38439 RVA: 0x011C562C File Offset: 0x011C382C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (120067 - 463004 != -342937)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6F9;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (92545 - 364208 != -271662)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (Game.mPlayer)
							{
								if (227389 - 175765 == 51625)
								{
									continue;
								}
								this.$startPoint$42104 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 4));
								if (119416 - 577228 != -457812)
								{
									continue;
								}
								if (this.$startPoint$42104)
								{
									if (155216 - 503836 == -348619)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$startPoint$42104.transform.position;
									if (258633 - 462782 == -204148)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$startPoint$42104.transform.rotation;
									if (260048 - 361958 != -101910)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (19918 - 336886 != -316968)
									{
										continue;
									}
								}
							}
							if (this.$self_$42106.snEnnYEMQmw)
							{
								if (173962 - 297492 == -123529)
								{
									continue;
								}
								this.$self_$42106.snEnnYEMQmw.alignToObject("EventCamera1");
								if (78193 - 152243 == -74049)
								{
									continue;
								}
							}
							this.$self_$42106.SendMessage("fadeIn");
							if (213910 - 134507 != 79404)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (183634 - 229340 != -45706)
							{
								continue;
							}
							goto IL_33C;
						}
						else
						{
							this.$mStoryGui$42103.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (234190 - 465136 != -230945)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (14405 - 280770 != -266364)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42103.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M913_CarrierSite", 101), eTalkType.friend);
							if (20291 - 177777 != -157485)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (273327 - 295772 != -22444)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42103.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M913_CarrierSite", 102), eTalkType.friend);
							if (123532 - 247571 != -124039)
							{
								continue;
							}
							goto IL_2C6;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (267024 - 513837 != -246813)
							{
								continue;
							}
							goto IL_50F;
						}
						else
						{
							this.$nCarrierBot$42105 = GameObject.Find("CarrierBot");
							if (93195 - 184107 != -90912)
							{
								continue;
							}
							if (!this.$nCarrierBot$42105)
							{
								goto IL_49A;
							}
							if (216655 - 452640 == -235984)
							{
								continue;
							}
							this.$nCarrierBot$42105.animation.Play("close");
							if (174777 - 85027 != 89750)
							{
								continue;
							}
							goto IL_49A;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (259721 - 255350 != 4371)
							{
								continue;
							}
							goto IL_12E;
						}
						else
						{
							this.$self_$42106.camera.SendMessage("resetPlayerCamera");
							if (122918 - 441983 == -319064)
							{
								continue;
							}
							this.$mStoryGui$42103.close();
							if (270474 - 408831 == -138356)
							{
								continue;
							}
							this.$mGameGui$42102.enabled = true;
							if (50405 - 441310 != -390905)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (229174 - 570009 == -340834)
							{
								continue;
							}
							Game.sendMissionEvent(9132, 2);
							if (78231 - 598356 != -520124)
							{
								goto IL_661;
							}
							continue;
						}
						break;
					default:
						if (222310 - 271243 == -48932)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$42102 = (GameGui)this.$self_$42106.GetComponent(typeof(GameGui));
					if (298580 - 528779 != -230199)
					{
						continue;
					}
					this.$mStoryGui$42103 = (StoryGui)this.$self_$42106.GetComponent(typeof(StoryGui));
					if (43165 - 347732 == -304566)
					{
						continue;
					}
					if (this.$mGameGui$42102)
					{
						if (114667 - 544137 != -429470)
						{
							continue;
						}
						if (this.$mStoryGui$42103)
						{
							if (119654 - 478729 != -359075)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (92267 - 599182 == -506914)
							{
								continue;
							}
							this.$self_$42106.SendMessage("fadeOut");
							if (141875 - 502346 == -360470)
							{
								continue;
							}
							this.$mGameGui$42102.close();
							if (186370 - 261022 != -74651)
							{
								goto Block_26;
							}
							continue;
						}
					}
					IL_661:
					this.YieldDefault(1);
				}
				while (31795 - 201604 != -169809);
				IL_12E:
				Block_20:
				goto IL_6F9;
				IL_2C6:
				return this.Yield(6, new WaitForSeconds(2f));
				Block_24:
				IL_33C:
				goto IL_6F9;
				Block_25:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_26:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_27:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_31:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_49A:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_50F:
				Block_44:
				IL_6F9:
				return false;
			}

			// Token: 0x06009628 RID: 38440 RVA: 0x011C5D44 File Offset: 0x011C3F44
			internal static bool ExCjPgVo1ciq4IwBhTqq()
			{
				return true;
			}

			// Token: 0x06009629 RID: 38441 RVA: 0x011C5D48 File Offset: 0x011C3F48
			internal static bool Ocp8CbVo45njQ48oM959()
			{
				return false;
			}

			// Token: 0x04008BF4 RID: 35828
			internal GameGui $mGameGui$42102;

			// Token: 0x04008BF5 RID: 35829
			internal StoryGui $mStoryGui$42103;

			// Token: 0x04008BF6 RID: 35830
			internal GameObject $startPoint$42104;

			// Token: 0x04008BF7 RID: 35831
			internal GameObject $nCarrierBot$42105;

			// Token: 0x04008BF8 RID: 35832
			internal M913_CarrierSite2 $self_$42106;
		}
	}

	// Token: 0x02001930 RID: 6448
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42108 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600962A RID: 38442 RVA: 0x011C5D4C File Offset: 0x011C3F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42108(M913_CarrierSite2 self_)
		{
			if (236307 - 420205 != -183897)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24912 - 554390 != -529477)
				{
					base..ctor();
					if (181929 - 370486 != -188556)
					{
						this.$self_$42111 = self_;
						if (72983 - 216018 != -143034)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600962B RID: 38443 RVA: 0x011C5DE4 File Offset: 0x011C3FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite2.$StartGame$42108.$(this.$self_$42111);
		}

		// Token: 0x0600962C RID: 38444 RVA: 0x011C5DF4 File Offset: 0x011C3FF4
		internal static bool THSsT7VozDJG9IMxwFE7()
		{
			return true;
		}

		// Token: 0x0600962D RID: 38445 RVA: 0x011C5DF8 File Offset: 0x011C3FF8
		internal static bool u6CVwCVEaVif6KavHw1S()
		{
			return false;
		}

		// Token: 0x04008BF9 RID: 35833
		internal M913_CarrierSite2 $self_$42111;

		// Token: 0x02001931 RID: 6449
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600962E RID: 38446 RVA: 0x011C5DFC File Offset: 0x011C3FFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite2 self_)
			{
				if (164551 - 345387 != -180835)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56848 - 550586 != -493737)
					{
						base..ctor();
						if (89231 - 244801 == -155570)
						{
							this.$self_$42110 = self_;
							if (123924 - 4988 == 118936)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600962F RID: 38447 RVA: 0x011C5E94 File Offset: 0x011C4094
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68924 - 307796 != -238871)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (250506 - 404162 != -153656)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (276643 - 93548 == 183096)
						{
							continue;
						}
						this.YieldDefault(1);
						if (275951 - 321261 != -45309)
						{
							goto Block_11;
						}
						continue;
					default:
						if (182370 - 91797 == 90574)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (63782 - 204811 != -141028)
					{
						Game.mGameState = eGameState.Start;
						if (182717 - 450706 != -267988)
						{
							Game.mGameTime = Time.time;
							if (178304 - 209769 == -31465)
							{
								this.$mGameGui$42109 = (GameGui)this.$self_$42110.GetComponent(typeof(GameGui));
								if (134967 - 491072 == -356105)
								{
									this.$mGameGui$42109.enabled = true;
									if (87131 - 210876 == -123745)
									{
										this.$self_$42110.SendMessage("fadeIn");
										if (182210 - 261 == 181949)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_11:
				IL_1B9:
				return false;
			}

			// Token: 0x06009630 RID: 38448 RVA: 0x011C606C File Offset: 0x011C426C
			internal static bool eTPqtpVE5BgXopqL6130()
			{
				return true;
			}

			// Token: 0x06009631 RID: 38449 RVA: 0x011C6070 File Offset: 0x011C4270
			internal static bool l1C282VEpQhcIfZbNvfq()
			{
				return false;
			}

			// Token: 0x04008BFA RID: 35834
			internal GameGui $mGameGui$42109;

			// Token: 0x04008BFB RID: 35835
			internal M913_CarrierSite2 $self_$42110;
		}
	}

	// Token: 0x02001932 RID: 6450
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42112 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009632 RID: 38450 RVA: 0x011C6074 File Offset: 0x011C4274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42112(M913_CarrierSite2 self_)
		{
			if (258571 - 473736 != -215164)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55736 - 517397 == -461661)
				{
					base..ctor();
					if (104279 - 22685 != 81595)
					{
						this.$self_$42117 = self_;
						if (186519 - 91668 == 94851)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x011C610C File Offset: 0x011C430C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite2.$onDeadPlayer$42112.$(this.$self_$42117);
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x011C611C File Offset: 0x011C431C
		internal static bool i8BxvMVEVgKHi8Q8cRIm()
		{
			return true;
		}

		// Token: 0x06009635 RID: 38453 RVA: 0x011C6120 File Offset: 0x011C4320
		internal static bool PFKOJwVEtHp979T6e7ff()
		{
			return false;
		}

		// Token: 0x04008BFC RID: 35836
		internal M913_CarrierSite2 $self_$42117;

		// Token: 0x02001933 RID: 6451
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009636 RID: 38454 RVA: 0x011C6124 File Offset: 0x011C4324
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite2 self_)
			{
				if (87983 - 268733 != -180750)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (280160 - 18410 != 261751)
					{
						base..ctor();
						if (244619 - 411439 != -166819)
						{
							this.$self_$42116 = self_;
							if (168176 - 410922 != -242745)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009637 RID: 38455 RVA: 0x011C61BC File Offset: 0x011C43BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148944 - 485756 != -336812)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2F9;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (232704 - 324633 == -91928)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_12B;
							}
							if (14440 - 196813 != -182373)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (209947 - 100084 != 109863)
						{
							continue;
						}
						this.$mStoryGui$42113 = (StoryGui)this.$self_$42116.GetComponent(typeof(StoryGui));
						if (45255 - 398182 != -352927)
						{
							continue;
						}
						if (this.$mStoryGui$42113)
						{
							if (262483 - 19450 == 243034)
							{
								continue;
							}
							this.$mStoryGui$42113.close();
							if (40378 - 72086 != -31708)
							{
								continue;
							}
						}
						this.$mChangeGui$42114 = (ChangeGui)this.$self_$42116.GetComponent(typeof(ChangeGui));
						if (188572 - 93012 == 95561)
						{
							continue;
						}
						if (this.$mChangeGui$42114)
						{
							if (139585 - 311028 == -171442)
							{
								continue;
							}
							this.$mChangeGui$42114.close();
							if (121676 - 581902 != -460226)
							{
								continue;
							}
						}
						this.$mGameGui$42115 = (GameGui)this.$self_$42116.GetComponent(typeof(GameGui));
						if (219765 - 282818 != -63053)
						{
							continue;
						}
						if (this.$mGameGui$42115)
						{
							if (214359 - 172818 != 41541)
							{
								continue;
							}
							if (!this.$mGameGui$42115.enabled)
							{
								if (166479 - 235745 == -69265)
								{
									continue;
								}
								this.$mGameGui$42115.enabled = true;
								if (59044 - 143226 != -84182)
								{
									continue;
								}
							}
							this.$mGameGui$42115.openDeadMenu();
							if (196959 - 320834 != -123875)
							{
								continue;
							}
						}
						IL_12B:
						this.YieldDefault(1);
						if (17596 - 124222 != -106625)
						{
							goto Block_11;
						}
						continue;
					default:
						if (213869 - 8047 == 205823)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (205794 - 65177 != 140617);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_11:
				IL_2F9:
				return false;
			}

			// Token: 0x06009638 RID: 38456 RVA: 0x011C64D4 File Offset: 0x011C46D4
			internal static bool jggmK3VENiiP9eTJUiI9()
			{
				return true;
			}

			// Token: 0x06009639 RID: 38457 RVA: 0x011C64D8 File Offset: 0x011C46D8
			internal static bool Kbw7ETVEYQ3lIyrOoFrT()
			{
				return false;
			}

			// Token: 0x04008BFD RID: 35837
			internal StoryGui $mStoryGui$42113;

			// Token: 0x04008BFE RID: 35838
			internal ChangeGui $mChangeGui$42114;

			// Token: 0x04008BFF RID: 35839
			internal GameGui $mGameGui$42115;

			// Token: 0x04008C00 RID: 35840
			internal M913_CarrierSite2 $self_$42116;
		}
	}

	// Token: 0x02001934 RID: 6452
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42118 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600963A RID: 38458 RVA: 0x011C64DC File Offset: 0x011C46DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42118(Hashtable data, M913_CarrierSite2 self_)
		{
			if (5429 - 397563 != -392133)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (11149 - 66857 == -55708)
				{
					base..ctor();
					if (197716 - 442475 == -244759)
					{
						this.$data$42123 = data;
						if (294841 - 556895 == -262054)
						{
							this.$self_$42124 = self_;
							if (134105 - 152652 != -18546)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x011C6598 File Offset: 0x011C4798
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite2.$onChangePlayer$42118.$(this.$data$42123, this.$self_$42124);
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x011C65AC File Offset: 0x011C47AC
		internal static bool nkyKbBVEclrbXRdUU1oK()
		{
			return true;
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x011C65B0 File Offset: 0x011C47B0
		internal static bool Js0xB2VEUtJenILZ7kqv()
		{
			return false;
		}

		// Token: 0x04008C01 RID: 35841
		internal Hashtable $data$42123;

		// Token: 0x04008C02 RID: 35842
		internal M913_CarrierSite2 $self_$42124;

		// Token: 0x02001935 RID: 6453
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600963E RID: 38462 RVA: 0x011C65B4 File Offset: 0x011C47B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M913_CarrierSite2 self_)
			{
				if (72976 - 598480 != -525504)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46439 - 128648 != -82208)
					{
						base..ctor();
						if (230020 - 534601 != -304580)
						{
							this.$data$42121 = data;
							if (103649 - 507142 == -403493)
							{
								this.$self_$42122 = self_;
								if (65221 - 586270 == -521049)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600963F RID: 38463 RVA: 0x011C6670 File Offset: 0x011C4870
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224170 - 176972 != 47199)
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
							if (22706 - 542636 == -519929)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (261479 - 481764 == -220284)
							{
								continue;
							}
							this.$mGameGui$42120 = (GameGui)this.$self_$42122.GetComponent(typeof(GameGui));
							if (56350 - 543298 == -486947)
							{
								continue;
							}
							this.$mGameGui$42120.enabled = true;
							if (277350 - 254039 == 23312)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (111010 - 495356 != -384346)
						{
							continue;
						}
						goto IL_205;
					default:
						if (135945 - 367337 == -231391)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (249503 - 408130 == -158627)
					{
						this.$self_$42122.SendMessage("onCreatePlayer", this.$data$42121);
						if (17472 - 367127 == -349655)
						{
							this.$mChangeGui$42119 = (ChangeGui)this.$self_$42122.GetComponent(typeof(ChangeGui));
							if (128404 - 86493 != 41912)
							{
								if (!this.$mChangeGui$42119.enabled)
								{
									break;
								}
								if (281285 - 32813 == 248472)
								{
									this.$mChangeGui$42119.close();
									if (171005 - 221410 != -50404)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06009640 RID: 38464 RVA: 0x011C6894 File Offset: 0x011C4A94
			internal static bool LtLcU7VET32XQwMSWgiP()
			{
				return true;
			}

			// Token: 0x06009641 RID: 38465 RVA: 0x011C6898 File Offset: 0x011C4A98
			internal static bool uTLFsoVE3B3BN79QPmdC()
			{
				return false;
			}

			// Token: 0x04008C03 RID: 35843
			internal ChangeGui $mChangeGui$42119;

			// Token: 0x04008C04 RID: 35844
			internal GameGui $mGameGui$42120;

			// Token: 0x04008C05 RID: 35845
			internal Hashtable $data$42121;

			// Token: 0x04008C06 RID: 35846
			internal M913_CarrierSite2 $self_$42122;
		}
	}

	// Token: 0x02001936 RID: 6454
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42125 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009642 RID: 38466 RVA: 0x011C689C File Offset: 0x011C4A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42125(Hashtable data, M913_CarrierSite2 self_)
		{
			if (59592 - 132019 != -72426)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214736 - 200672 != 14065)
				{
					base..ctor();
					if (243179 - 352783 == -109604)
					{
						this.$data$42133 = data;
						if (102867 - 309188 != -206320)
						{
							this.$self_$42134 = self_;
							if (191004 - 472598 != -281593)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x011C6958 File Offset: 0x011C4B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite2.$onGameComplete$42125.$(this.$data$42133, this.$self_$42134);
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x011C696C File Offset: 0x011C4B6C
		internal static bool I7B2bGVEXWcQJOcLxsHX()
		{
			return true;
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x011C6970 File Offset: 0x011C4B70
		internal static bool BNelaWVEQ4UFBfIpuvEt()
		{
			return false;
		}

		// Token: 0x04008C07 RID: 35847
		internal Hashtable $data$42133;

		// Token: 0x04008C08 RID: 35848
		internal M913_CarrierSite2 $self_$42134;

		// Token: 0x02001937 RID: 6455
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009646 RID: 38470 RVA: 0x011C6974 File Offset: 0x011C4B74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M913_CarrierSite2 self_)
			{
				if (187272 - 484095 != -296822)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129302 - 307456 != -178153)
					{
						base..ctor();
						if (17451 - 497522 != -480070)
						{
							this.$data$42131 = data;
							if (64712 - 63864 != 849)
							{
								this.$self_$42132 = self_;
								if (183696 - 259360 == -75664)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009647 RID: 38471 RVA: 0x011C6A30 File Offset: 0x011C4C30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289353 - 492733 != -203379)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3DB;
					case 2:
						this.$mCompleteGui$42127 = (CompleteGui)this.$self_$42132.GetComponent(typeof(CompleteGui));
						if (205346 - 354131 == -148784)
						{
							continue;
						}
						this.$mCompleteGui$42127.Init();
						if (104190 - 80525 == 23666)
						{
							continue;
						}
						this.$mCompleteGui$42127.readData(this.$data$42131);
						if (178773 - 312256 == -133482)
						{
							continue;
						}
						if (this.$result$42126 == 1)
						{
							if (260872 - 100366 == 160507)
							{
								continue;
							}
							this.$mCompleteGui$42127.displayResult(eCompleteType.Success);
							if (165795 - 428689 == -262893)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42127.displayResult(eCompleteType.Failed);
							if (135334 - 101835 == 33500)
							{
								continue;
							}
						}
						this.$mGameGui$42128 = (GameGui)this.$self_$42132.GetComponent(typeof(GameGui));
						if (289382 - 242568 != 46814)
						{
							continue;
						}
						this.$mStoryGui$42129 = (StoryGui)this.$self_$42132.GetComponent(typeof(StoryGui));
						if (226889 - 417579 != -190690)
						{
							continue;
						}
						this.$mChangeGui$42130 = (ChangeGui)this.$self_$42132.GetComponent(typeof(ChangeGui));
						if (122083 - 184736 == -62652)
						{
							continue;
						}
						if (this.$mGameGui$42128)
						{
							if (140161 - 267859 != -127698)
							{
								continue;
							}
							this.$mGameGui$42128.close();
							if (35785 - 448851 != -413066)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42129)
						{
							if (196693 - 570163 != -373470)
							{
								continue;
							}
							this.$mStoryGui$42129.close();
							if (144127 - 70338 == 73790)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42130)
						{
							if (32440 - 321725 != -289285)
							{
								continue;
							}
							this.$mChangeGui$42130.disable();
							if (193661 - 475243 != -281582)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (199274 - 74789 != 124486)
						{
							goto Block_10;
						}
						continue;
					default:
						if (120188 - 455721 == -335532)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42131[31]);
					if (200649 - 413641 == -212992)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (187440 - 564555 == -377115)
							{
								goto IL_243;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (274844 - 529843 == -254999)
							{
								this.$result$42126 = RuntimeServices.UnboxInt32(this.$data$42131[31]);
								if (182466 - 125663 != 56804)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_10:
				IL_243:
				IL_3DB:
				return false;
			}

			// Token: 0x06009648 RID: 38472 RVA: 0x011C6E2C File Offset: 0x011C502C
			internal static bool hVCU7aVEkDkKWZ27yfne()
			{
				return true;
			}

			// Token: 0x06009649 RID: 38473 RVA: 0x011C6E30 File Offset: 0x011C5030
			internal static bool AOy3HJVEGU3LQuimicbG()
			{
				return false;
			}

			// Token: 0x04008C09 RID: 35849
			internal int $result$42126;

			// Token: 0x04008C0A RID: 35850
			internal CompleteGui $mCompleteGui$42127;

			// Token: 0x04008C0B RID: 35851
			internal GameGui $mGameGui$42128;

			// Token: 0x04008C0C RID: 35852
			internal StoryGui $mStoryGui$42129;

			// Token: 0x04008C0D RID: 35853
			internal ChangeGui $mChangeGui$42130;

			// Token: 0x04008C0E RID: 35854
			internal Hashtable $data$42131;

			// Token: 0x04008C0F RID: 35855
			internal M913_CarrierSite2 $self_$42132;
		}
	}

	// Token: 0x02001938 RID: 6456
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42135 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600964A RID: 38474 RVA: 0x011C6E34 File Offset: 0x011C5034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42135(M913_CarrierSite2 self_)
		{
			if (52134 - 105589 != -53454)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196630 - 230709 != -34078)
				{
					base..ctor();
					if (186949 - 255010 != -68060)
					{
						this.$self_$42139 = self_;
						if (153525 - 78814 != 74712)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600964B RID: 38475 RVA: 0x011C6ECC File Offset: 0x011C50CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite2.$ReturnToTown$42135.$(this.$self_$42139);
		}

		// Token: 0x0600964C RID: 38476 RVA: 0x011C6EDC File Offset: 0x011C50DC
		internal static bool KwRUtgVEHcqBPgIQHAqS()
		{
			return true;
		}

		// Token: 0x0600964D RID: 38477 RVA: 0x011C6EE0 File Offset: 0x011C50E0
		internal static bool JQXQngVEWwNtrciu53Yb()
		{
			return false;
		}

		// Token: 0x04008C10 RID: 35856
		internal M913_CarrierSite2 $self_$42139;

		// Token: 0x02001939 RID: 6457
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600964E RID: 38478 RVA: 0x011C6EE4 File Offset: 0x011C50E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite2 self_)
			{
				if (83727 - 70884 != 12843)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229392 - 52875 == 176517)
					{
						base..ctor();
						if (186872 - 377745 == -190873)
						{
							this.$self_$42138 = self_;
							if (231354 - 557077 == -325723)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600964F RID: 38479 RVA: 0x011C6F7C File Offset: 0x011C517C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149176 - 107159 != 42018)
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
						this.$self_$42138.LeaveGame();
						if (110318 - 84891 == 25428)
						{
							continue;
						}
						this.YieldDefault(1);
						if (91819 - 26586 != 65234)
						{
							goto Block_14;
						}
						continue;
					default:
						if (246183 - 482571 == -236387)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (104503 - 52608 != 51896)
					{
						Game.mStateTime = Time.time;
						if (118070 - 197772 == -79702)
						{
							this.$$switch$7614$42136 = PlayerData.SaveGuild;
							if (2452 - 228035 == -225583)
							{
								if (this.$$switch$7614$42136 == 1)
								{
									if (51332 - 347673 == -296340)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (29839 - 220805 != -190966)
									{
										continue;
									}
								}
								else if (this.$$switch$7614$42136 == 2)
								{
									if (43950 - 319391 == -275440)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (178299 - 424716 == -246416)
									{
										continue;
									}
								}
								else if (this.$$switch$7614$42136 == 3)
								{
									if (94391 - 585500 == -491108)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (89531 - 294027 != -204496)
									{
										continue;
									}
								}
								else if (this.$$switch$7614$42136 == 4)
								{
									if (30526 - 232392 == -201865)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (73029 - 150783 != -77754)
									{
										continue;
									}
								}
								else if (this.$$switch$7614$42136 == 5)
								{
									if (299147 - 180132 == 119016)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (232609 - 56093 != 176516)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (80945 - 265380 != -184435)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (184873 - 185731 == -857)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (123813 - 542421 != -418608)
									{
										continue;
									}
								}
								this.$mGameGui$42137 = (GameGui)this.$self_$42138.GetComponent(typeof(GameGui));
								if (65867 - 250439 != -184571)
								{
									if (this.$mGameGui$42137)
									{
										if (56018 - 416825 != -360807)
										{
											continue;
										}
										this.$mGameGui$42137.close();
										if (257011 - 372975 == -115963)
										{
											continue;
										}
									}
									this.$self_$42138.SendMessage("fadeOut");
									if (260396 - 305774 == -45378)
									{
										goto IL_1EA;
									}
								}
							}
						}
					}
				}
				Block_14:
				goto IL_3AD;
				IL_1EA:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06009650 RID: 38480 RVA: 0x011C7348 File Offset: 0x011C5548
			internal static bool kRPmJOVEA2iv4tpSs9YC()
			{
				return true;
			}

			// Token: 0x06009651 RID: 38481 RVA: 0x011C734C File Offset: 0x011C554C
			internal static bool S7K0vjVElVJcxKY8tHR1()
			{
				return false;
			}

			// Token: 0x04008C11 RID: 35857
			internal int $$switch$7614$42136;

			// Token: 0x04008C12 RID: 35858
			internal GameGui $mGameGui$42137;

			// Token: 0x04008C13 RID: 35859
			internal M913_CarrierSite2 $self_$42138;
		}
	}

	// Token: 0x0200193A RID: 6458
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42140 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009652 RID: 38482 RVA: 0x011C7350 File Offset: 0x011C5550
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42140(M913_CarrierSite2 self_)
		{
			if (35893 - 331236 != -295342)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1155 - 53915 == -52760)
				{
					base..ctor();
					if (210820 - 187997 != 22824)
					{
						this.$self_$42143 = self_;
						if (217295 - 135451 != 81845)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009653 RID: 38483 RVA: 0x011C73E8 File Offset: 0x011C55E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite2.$ReturnToGuild$42140.$(this.$self_$42143);
		}

		// Token: 0x06009654 RID: 38484 RVA: 0x011C73F8 File Offset: 0x011C55F8
		internal static bool aWvZkDVEyXy3KQGJI4Tw()
		{
			return true;
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x011C73FC File Offset: 0x011C55FC
		internal static bool vQpyPbVESpafAR6b47CW()
		{
			return false;
		}

		// Token: 0x04008C14 RID: 35860
		internal M913_CarrierSite2 $self_$42143;

		// Token: 0x0200193B RID: 6459
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009656 RID: 38486 RVA: 0x011C7400 File Offset: 0x011C5600
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite2 self_)
			{
				if (265988 - 562149 != -296161)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155944 - 430962 != -275017)
					{
						base..ctor();
						if (287098 - 538664 == -251566)
						{
							this.$self_$42142 = self_;
							if (283226 - 546174 != -262947)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009657 RID: 38487 RVA: 0x011C7498 File Offset: 0x011C5698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (291137 - 533937 != -242799)
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
						this.$self_$42142.LeaveGame();
						if (214528 - 387067 != -172539)
						{
							continue;
						}
						this.YieldDefault(1);
						if (275200 - 520368 != -245168)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (199753 - 106277 != 93476)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (91588 - 158346 != -66757)
					{
						Game.mStateTime = Time.time;
						if (117630 - 52845 == 64785)
						{
							Game.mNextGameCode = 31;
							if (149924 - 66916 != 83009)
							{
								this.$mGameGui$42141 = (GameGui)this.$self_$42142.GetComponent(typeof(GameGui));
								if (207277 - 420654 != -213376)
								{
									if (this.$mGameGui$42141)
									{
										if (38493 - 343199 != -304706)
										{
											continue;
										}
										this.$mGameGui$42141.close();
										if (85491 - 376961 != -291470)
										{
											continue;
										}
									}
									this.$self_$42142.SendMessage("fadeOut");
									if (118426 - 417951 != -299524)
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

			// Token: 0x06009658 RID: 38488 RVA: 0x011C7674 File Offset: 0x011C5874
			internal static bool nX8SUqVEoNyADAIKvuD1()
			{
				return true;
			}

			// Token: 0x06009659 RID: 38489 RVA: 0x011C7678 File Offset: 0x011C5878
			internal static bool FeonEaVEEaqPe3YoqZ3Q()
			{
				return false;
			}

			// Token: 0x04008C15 RID: 35861
			internal GameGui $mGameGui$42141;

			// Token: 0x04008C16 RID: 35862
			internal M913_CarrierSite2 $self_$42142;
		}
	}

	// Token: 0x0200193C RID: 6460
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42144 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600965A RID: 38490 RVA: 0x011C767C File Offset: 0x011C587C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42144(M913_CarrierSite2 self_)
		{
			if (49363 - 423477 != -374113)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16545 - 508681 == -492136)
				{
					base..ctor();
					if (66445 - 457824 != -391378)
					{
						this.$self_$42148 = self_;
						if (153256 - 78188 != 75069)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x011C7714 File Offset: 0x011C5914
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite2.$ReturnToCamp$42144.$(this.$self_$42148);
		}

		// Token: 0x0600965C RID: 38492 RVA: 0x011C7724 File Offset: 0x011C5924
		internal static bool PmF0hoVE2COxSAGaR5QO()
		{
			return true;
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x011C7728 File Offset: 0x011C5928
		internal static bool fmZpCBVE8pcnEl8iCXdY()
		{
			return false;
		}

		// Token: 0x04008C17 RID: 35863
		internal M913_CarrierSite2 $self_$42148;

		// Token: 0x0200193D RID: 6461
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600965E RID: 38494 RVA: 0x011C772C File Offset: 0x011C592C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite2 self_)
			{
				if (250066 - 142237 != 107830)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53704 - 542464 != -488759)
					{
						base..ctor();
						if (8888 - 424492 != -415603)
						{
							this.$self_$42147 = self_;
							if (238664 - 234072 == 4592)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600965F RID: 38495 RVA: 0x011C77C4 File Offset: 0x011C59C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135429 - 45667 != 89763)
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
						this.$self_$42147.LeaveGame();
						if (1579 - 556394 == -554814)
						{
							continue;
						}
						this.YieldDefault(1);
						if (272127 - 75010 != 197117)
						{
							continue;
						}
						goto IL_363;
					default:
						if (139509 - 328752 == -189242)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (78378 - 201838 != -123459)
					{
						Game.mStateTime = Time.time;
						if (127662 - 146524 == -18862)
						{
							this.$$switch$7616$42145 = PlayerData.SaveGuild;
							if (196070 - 169946 == 26124)
							{
								if (this.$$switch$7616$42145 == 1)
								{
									if (78639 - 242475 == -163835)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (22095 - 321743 == -299647)
									{
										continue;
									}
								}
								else if (this.$$switch$7616$42145 == 2)
								{
									if (186687 - 211713 == -25025)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (215785 - 194108 != 21677)
									{
										continue;
									}
								}
								else if (this.$$switch$7616$42145 == 3)
								{
									if (222341 - 66037 != 156304)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (129825 - 25080 != 104745)
									{
										continue;
									}
								}
								else if (this.$$switch$7616$42145 == 4)
								{
									if (26478 - 148060 == -121581)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (45895 - 570252 != -524357)
									{
										continue;
									}
								}
								else if (this.$$switch$7616$42145 == 5)
								{
									if (114026 - 53972 != 60054)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (209388 - 449922 != -240534)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (222094 - 230777 != -8683)
									{
										continue;
									}
								}
								this.$mGameGui$42146 = (GameGui)this.$self_$42147.GetComponent(typeof(GameGui));
								if (4276 - 350821 != -346544)
								{
									if (this.$mGameGui$42146)
									{
										if (201716 - 372507 == -170790)
										{
											continue;
										}
										this.$mGameGui$42146.close();
										if (15060 - 405068 == -390007)
										{
											continue;
										}
									}
									this.$self_$42147.SendMessage("fadeOut");
									if (203357 - 257828 != -54470)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06009660 RID: 38496 RVA: 0x011C7B48 File Offset: 0x011C5D48
			internal static bool D1BOUQVEZEHh5OpWXxd7()
			{
				return true;
			}

			// Token: 0x06009661 RID: 38497 RVA: 0x011C7B4C File Offset: 0x011C5D4C
			internal static bool rNZUMJVECf0RBtZ6G6fJ()
			{
				return false;
			}

			// Token: 0x04008C18 RID: 35864
			internal int $$switch$7616$42145;

			// Token: 0x04008C19 RID: 35865
			internal GameGui $mGameGui$42146;

			// Token: 0x04008C1A RID: 35866
			internal M913_CarrierSite2 $self_$42147;
		}
	}
}
