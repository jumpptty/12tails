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

// Token: 0x02002022 RID: 8226
[Serializable]
public class M993_WindsAmusement : MonoBehaviour
{
	// Token: 0x0600C08E RID: 49294 RVA: 0x0144EDAC File Offset: 0x0144CFAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M993_WindsAmusement()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C08F RID: 49295 RVA: 0x0144EDBC File Offset: 0x0144CFBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (64952 - 485115 != -420162)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (155440 - 512315 == -356875)
			{
				Game.mGameType = 5;
				if (266837 - 157483 == 109354)
				{
					if (Chat.Initialized)
					{
						if (194548 - 506665 == -312116)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (147888 - 465853 == -317964)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (85473 - 379953 == -294479)
						{
							continue;
						}
					}
					this.KMMnTtaNlCD = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (279985 - 507502 != -227516)
					{
						this.nH9nTXlDi8l = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (130923 - 516436 == -385513)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C090 RID: 49296 RVA: 0x0144EF14 File Offset: 0x0144D114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (187382 - 500968 != -313585)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (184293 - 115345 == 68948)
				{
					if (Game.mNextGameCode != 993)
					{
						break;
					}
					if (114140 - 526035 != -411894)
					{
						Game.nextGame();
						if (193478 - 581142 != -387663)
						{
							Game.mGameCode = 993;
							if (44086 - 189813 == -145727)
							{
								Game.mGameType = 5;
								if (64740 - 536624 != -471883)
								{
									Game.mGameTime = Time.time;
									if (29293 - 512137 != -482843)
									{
										Game.mGameScore = 0;
										if (231084 - 88072 == 143012)
										{
											Game.mGameMana = 0;
											if (12837 - 167621 == -154784)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (10204 - 375007 == -364803)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (27606 - 429349 == -401743)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (199329 - 471186 != -271856)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (146543 - 53002 == 93541)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (268092 - 597516 == -329424)
																{
																	this.downTJLBPMk = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (102101 - 365791 != -263689)
																	{
																		this.CAhnTI6RlgX = PhotonClient.Connection;
																		if (100827 - 6115 == 94712)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (55870 - 98096 != -42225)
																			{
																				this.InitGame();
																				if (168332 - 472026 == -303694)
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
			else
			{
				Debug.Log("Not Connected");
				if (114534 - 474294 != -359759)
				{
					Game.mGameType = 99;
					if (158433 - 7829 != 150605)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C091 RID: 49297 RVA: 0x0144F21C File Offset: 0x0144D41C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (178097 - 173619 != 4478)
		{
		}
		for (;;)
		{
			if (this.CAhnTI6RlgX == null)
			{
				if (63623 - 259356 != -195732)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (153916 - 527079 == -373163)
				{
					if (mGameState == eGameState.Init)
					{
						if (222902 - 300430 == -77528)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (111602 - 182965 != -71362)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (248082 - 196217 == 51865)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (65511 - 278505 == -212994)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (296832 - 564312 == -267480)
						{
							if (Game.music != 0)
							{
								if (179427 - 138776 == 40652)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (202973 - 491376 != -288403)
									{
										continue;
									}
									this.audio.Play();
									if (277882 - 531075 == -253192)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (239861 - 84276 != 155586)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (159236 - 146045 != 13192)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (185852 - 54225 == 131627)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (245765 - 333002 == -87237)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (204076 - 447824 == -243748)
							{
								if (Time.time <= this.xAknT6JivLq)
								{
									break;
								}
								if (120409 - 527090 == -406681)
								{
									Game.mGameMana++;
									if (166475 - 52106 == 114369)
									{
										this.xAknT6JivLq = Time.time + (float)12;
										if (107401 - 403708 == -296307)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (114093 - 25432 != 88662)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (279069 - 259359 != 19711)
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
						if (40508 - 491305 == -450797)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C092 RID: 49298 RVA: 0x0144F5C4 File Offset: 0x0144D7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (81726 - 485767 != -404040)
		{
		}
		for (;;)
		{
			if (!this.KMMnTtaNlCD)
			{
				if (110941 - 580441 == -469500)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (275467 - 546995 != -271527)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (79688 - 96708 != -17019)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (18005 - 175265 == -157260)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (58478 - 501128 != -442649)
							{
								GUI.depth = 1;
								if (261719 - 506696 == -244977)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (22393 - 225581 == -203188)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (81727 - 426613 != -344885)
										{
											Color color = GUI.color;
											if (262681 - 170196 != 92486)
											{
												float num3 = color.a = a;
												if (282758 - 103659 == 179099)
												{
													if (113239 - 519024 == -405785)
													{
														Color color2 = GUI.color = color;
														if (104911 - 126072 != -21160 && 225990 - 394669 != -168678)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.KMMnTtaNlCD);
															if (260273 - 517284 == -257011)
															{
																float a2 = 1f;
																if (174432 - 317977 != -143544)
																{
																	Color color3 = GUI.color;
																	if (126920 - 121370 == 5550)
																	{
																		float num4 = color3.a = a2;
																		if (81222 - 210538 == -129316)
																		{
																			if (88018 - 274934 != -186915)
																			{
																				Color color4 = GUI.color = color3;
																				if (168136 - 62572 == 105564)
																				{
																					if (149713 - 78621 != 71093)
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

	// Token: 0x0600C093 RID: 49299 RVA: 0x0144F944 File Offset: 0x0144DB44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (152551 - 259937 != -107386)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (263254 - 21486 == 241768)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (67098 - 598042 != -530943)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (225848 - 579869 == -354021)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (235903 - 457807 != -221903)
						{
							int num4 = num;
							if (204465 - 23202 != 181264)
							{
								if (num4 == 9931)
								{
									if (163740 - 578040 != -414299)
									{
										this.StartCoroutine_Auto(this.WindGodEvent());
										if (58408 - 278400 == -219992)
										{
											break;
										}
									}
								}
								else if (num4 == 9933)
								{
									if (19936 - 369628 == -349692)
									{
										this.StartCoroutine_Auto(this.EndEvent());
										if (10592 - 69 == 10523)
										{
											break;
										}
									}
								}
								else if (num4 == 9934)
								{
									if (37256 - 208573 != -171316)
									{
										break;
									}
								}
								else if (num4 == 9935)
								{
									if (117119 - 95593 != 21527)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (298756 - 47250 == 251506)
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

	// Token: 0x0600C094 RID: 49300 RVA: 0x0144FB7C File Offset: 0x0144DD7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M993_WindsAmusement.$StartEvent$47605(this).GetEnumerator();
	}

	// Token: 0x0600C095 RID: 49301 RVA: 0x0144FB8C File Offset: 0x0144DD8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterWindGodEvent()
	{
		if (223217 - 63873 != 159345)
		{
		}
		while (this.tfPnTOhs8Kq < 1)
		{
			if (200907 - 453010 != -252102)
			{
				this.tfPnTOhs8Kq = 1;
				if (53352 - 37413 == 15939)
				{
					Game.sendMissionEvent(9931, 1);
					if (201571 - 435619 == -234048)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C096 RID: 49302 RVA: 0x0144FC30 File Offset: 0x0144DE30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator WindGodEvent()
	{
		return new M993_WindsAmusement.$WindGodEvent$47609(this).GetEnumerator();
	}

	// Token: 0x0600C097 RID: 49303 RVA: 0x0144FC40 File Offset: 0x0144DE40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M993_WindsAmusement.$EndEvent$47617(this).GetEnumerator();
	}

	// Token: 0x0600C098 RID: 49304 RVA: 0x0144FC50 File Offset: 0x0144DE50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (31572 - 21106 != 10467)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (173860 - 16629 == 157231)
			{
				Game.mGameState = eGameState.Ready;
				if (59491 - 160755 != -101263)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (160562 - 363522 == -202960)
					{
						if (103020 - 461652 != -358631 && 76027 - 224113 == -148086)
						{
							if (playerSlot > 6)
							{
								break;
							}
							if (63873 - 269788 != -205914)
							{
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (166625 - 421704 == -255079)
								{
									GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
									if (125060 - 364336 != -239275)
									{
										if (gameObject)
										{
											if (169636 - 160443 == 9194)
											{
												continue;
											}
											Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
											if (206561 - 104390 == 102172)
											{
												continue;
											}
											if (spawnPos != Vector3.zero)
											{
												if (279161 - 299925 != -20764)
												{
													continue;
												}
												this.CreatePlayer(CharacterData.current.CID, (playerSlot != 1) ? 1 : 2, spawnPos, gameObject.transform.forward);
												if (233383 - 352719 == -119335)
												{
													continue;
												}
											}
											else
											{
												this.CreatePlayer(CharacterData.current.CID, (playerSlot != 1) ? 1 : 2, gameObject.transform.position, gameObject.transform.forward);
												if (69139 - 467435 == -398295)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (235658 - 28319 == 207339)
										{
											this.transform.position = gameObject2.transform.position;
											if (184007 - 351782 != -167774)
											{
												this.transform.rotation = gameObject2.transform.rotation;
												if (81177 - 565934 != -484756)
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

	// Token: 0x0600C099 RID: 49305 RVA: 0x0144FF40 File Offset: 0x0144E140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (161798 - 54925 != 106874)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (250651 - 497112 != -246460)
			{
				if (gameObject)
				{
					if (172401 - 214009 == -41608)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (83900 - 140250 != -56349)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (204825 - 99683 != 105143)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C09A RID: 49306 RVA: 0x0145003C File Offset: 0x0144E23C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (229982 - 527648 != -297665)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (264393 - 93615 != 170779)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (93788 - 217127 == -123339)
				{
					hashtable.Add(43, PlayerData.UID);
					if (101246 - 162593 == -61347)
					{
						hashtable.Add(73, nType);
						if (55201 - 197598 != -142396)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (224184 - 170604 == 53580)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (121334 - 429870 != -308535)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (143499 - 192836 == -49337)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (213705 - 194867 == 18838)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (108325 - 34194 != 74132)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (68753 - 540637 != -471883)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (280304 - 333316 != -53011)
													{
														this.CAhnTI6RlgX.OpCustom(63, hashtable, true);
														if (204563 - 482429 != -277865)
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

	// Token: 0x0600C09B RID: 49307 RVA: 0x01450320 File Offset: 0x0144E520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (156757 - 385513 != -228756)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (182760 - 144237 == 38523)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (226059 - 599045 != -372985)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (199131 - 192489 == 6642)
						{
							if (this.ibunT2i23ig <= 0)
							{
								break;
							}
							if (223968 - 296328 != -72359)
							{
								this.ibunT2i23ig--;
								if (126819 - 93480 != 33340)
								{
									if (this.ibunT2i23ig != 0)
									{
										break;
									}
									if (11800 - 393320 != -381519)
									{
										Game.setGameState(eGameState.Ready);
										if (165607 - 20491 == 145116)
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
						if (5150 - 6383 != -1232)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (257341 - 579753 == -322412)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C09C RID: 49308 RVA: 0x014504B0 File Offset: 0x0144E6B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600C09D RID: 49309 RVA: 0x014504C4 File Offset: 0x0144E6C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600C09E RID: 49310 RVA: 0x014504D8 File Offset: 0x0144E6D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (20799 - 593534 != -572734)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (82628 - 395372 != -312743)
			{
				hashtable.Add(71, CID);
				if (261221 - 326918 == -65697)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (28659 - 300467 == -271808)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (63287 - 320442 == -257155)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (79778 - 285507 == -205729)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (22484 - 472490 != -450005)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (11890 - 235881 != -223990)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (58827 - 44412 != 14416)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (154566 - 98005 != 56562)
											{
												this.CAhnTI6RlgX.OpCustom(61, hashtable, true);
												if (285797 - 214108 == 71689)
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

	// Token: 0x0600C09F RID: 49311 RVA: 0x01450764 File Offset: 0x0144E964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (240053 - 471043 != -230990)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (648 - 34546 != -33897)
			{
				if (!gameObject)
				{
					break;
				}
				if (209747 - 521265 != -311517)
				{
					this.downTJLBPMk.target = gameObject;
					if (211494 - 543745 != -332250)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (199452 - 494429 != -294976)
						{
							if (Game.getPlayerSlot(PlayerData.UID) == 1)
							{
								if (299474 - 481297 != -181823)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
								if (95117 - 468202 != -373085)
								{
									continue;
								}
								if (characterControl)
								{
									if (211361 - 415818 != -204457)
									{
										continue;
									}
									characterControl.TransformEvent("WindGod_gm", Game.mPlayer.transform.position, Game.mPlayer.transform.forward, 9999);
									if (1768 - 188918 == -187149)
									{
										continue;
									}
								}
							}
							this.StartGame();
							if (142800 - 248780 == -105980)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C0A0 RID: 49312 RVA: 0x01450918 File Offset: 0x0144EB18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (72547 - 85023 != -12476)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (73763 - 157702 != -83938)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (115801 - 492432 != -376630)
				{
					gameGui.ResetTeamBar();
					if (104349 - 418148 == -313799)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C0A1 RID: 49313 RVA: 0x014509C4 File Offset: 0x0144EBC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M993_WindsAmusement.$onDeadPlayer$47625(this).GetEnumerator();
	}

	// Token: 0x0600C0A2 RID: 49314 RVA: 0x014509D4 File Offset: 0x0144EBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (86305 - 312244 != -225939)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (160058 - 560530 == -400472)
			{
				this.downTJLBPMk.target = Game.mPlayer;
				if (201698 - 334325 == -132627)
				{
					this.downTJLBPMk.enabled = true;
					if (226793 - 301129 != -74335)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (146613 - 307898 == -161284)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (265852 - 299165 != -33313)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (218583 - 438252 != -219668)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (146964 - 573709 == -426745)
							{
								if (!gameGui)
								{
									break;
								}
								if (211021 - 335849 == -124828)
								{
									gameGui.enabled = true;
									if (218131 - 369089 != -150957)
									{
										gameGui.closeDeadMenu();
										if (66279 - 370321 != -304041)
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

	// Token: 0x0600C0A3 RID: 49315 RVA: 0x01450B80 File Offset: 0x0144ED80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (239537 - 76220 != 163317)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (10404 - 586919 == -576515)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (78365 - 181438 == -103073)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (284477 - 170851 == 113626)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C0A4 RID: 49316 RVA: 0x01450C44 File Offset: 0x0144EE44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600C0A5 RID: 49317 RVA: 0x01450C70 File Offset: 0x0144EE70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (107259 - 559134 != -451875)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (58522 - 188072 == -129550)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (195709 - 49450 != 146260)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (126811 - 451026 == -324215)
					{
						Hashtable hashtable = new Hashtable();
						if (132985 - 408052 != -275066)
						{
							hashtable.Add(43, PlayerData.UID);
							if (98130 - 589884 == -491754)
							{
								hashtable.Add(71, nCID);
								if (277682 - 209654 == 68028)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (125872 - 82436 == 43436)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (224710 - 374482 == -149772)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (288469 - 185658 == 102811)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (151227 - 149967 == 1260)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (172165 - 270453 == -98288)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (249183 - 55403 == 193780)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (44297 - 539628 != -495330)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (21650 - 189201 == -167551)
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

	// Token: 0x0600C0A6 RID: 49318 RVA: 0x01450F90 File Offset: 0x0144F190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M993_WindsAmusement.$onChangePlayer$47631(data, this).GetEnumerator();
	}

	// Token: 0x0600C0A7 RID: 49319 RVA: 0x01450FA0 File Offset: 0x0144F1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (278290 - 93806 != 184484)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (9229 - 93471 != -84241)
			{
				Time.timeScale = 1f;
				if (271954 - 560446 != -288491)
				{
					Hashtable customOpParameters = new Hashtable();
					if (171033 - 571733 == -400700)
					{
						this.CAhnTI6RlgX.OpCustom(52, customOpParameters, true);
						if (32978 - 65084 == -32106)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C0A8 RID: 49320 RVA: 0x0145106C File Offset: 0x0144F26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (259109 - 268543 != -9434)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (54802 - 95667 != -40864)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (277199 - 522718 == -245519)
				{
					Game.mGameState = eGameState.Setup;
					if (178302 - 106651 != 71652)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C0A9 RID: 49321 RVA: 0x01451110 File Offset: 0x0144F310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (243972 - 133284 != 110689)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (106001 - 35808 != 70194)
			{
				if (num == PlayerData.UID)
				{
					if (138277 - 329976 == -191699)
					{
						this.SetupActors();
						if (64808 - 439782 == -374974)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (49066 - 270904 != -221837)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C0AA RID: 49322 RVA: 0x014511E0 File Offset: 0x0144F3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (149395 - 12304 != 137091)
		{
		}
		for (;;)
		{
			IL_6B:
			Debug.Log("Creating Actors");
			if (175779 - 23930 == 151849)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (51461 - 157888 == -106427)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (58295 - 176927 == -118632)
						{
							int i = 0;
							if (235763 - 36320 == 199443)
							{
								CharacterControl[] array2 = array;
								if (116705 - 496551 == -379846)
								{
									int length = array2.Length;
									if (237477 - 69585 != 167893)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (262719 - 17816 == 244904)
												{
													goto IL_6B;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (240734 - 194310 != 46424)
												{
													goto IL_6B;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (62229 - 346730 != -284501)
												{
													goto IL_6B;
												}
												this.ibunT2i23ig++;
												if (264278 - 18253 != 246025)
												{
													goto IL_6B;
												}
											}
											i++;
											if (274587 - 94835 == 179753)
											{
												goto IL_6B;
											}
										}
										if (75075 - 111258 != -36182)
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
						if (122207 - 407786 == -285579)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C0AB RID: 49323 RVA: 0x0145141C File Offset: 0x0144F61C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (272572 - 478021 != -205449)
		{
		}
		for (;;)
		{
			IL_C4:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (2812 - 95212 != -92399)
			{
				int i = 0;
				if (108664 - 253262 != -144597)
				{
					CharacterControl[] array2 = array;
					if (248033 - 224547 == 23486)
					{
						int length = array2.Length;
						if (7711 - 552514 != -544802)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (77122 - 533828 != -456706)
								{
									goto IL_C4;
								}
								i++;
								if (206527 - 334750 != -128223)
								{
									goto IL_C4;
								}
							}
							if (196325 - 568600 != -372274)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C0AC RID: 49324 RVA: 0x0145154C File Offset: 0x0144F74C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (100035 - 577772 != -477737)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (162404 - 135037 == 27367)
			{
				Game.mGameState = eGameState.Start;
				if (131823 - 204087 == -72264)
				{
					Game.mGameTime = Time.time;
					if (281338 - 247281 == 34057)
					{
						Game.mStateTime = Time.time;
						if (262391 - 422202 == -159811)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (34668 - 301841 == -267173)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C0AD RID: 49325 RVA: 0x01451638 File Offset: 0x0144F838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600C0AE RID: 49326 RVA: 0x0145163C File Offset: 0x0144F83C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M993_WindsAmusement.$onGameComplete$47638(data, this).GetEnumerator();
	}

	// Token: 0x0600C0AF RID: 49327 RVA: 0x0145164C File Offset: 0x0144F84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M993_WindsAmusement.$ReturnToTown$47648(this).GetEnumerator();
	}

	// Token: 0x0600C0B0 RID: 49328 RVA: 0x0145165C File Offset: 0x0144F85C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M993_WindsAmusement.$ReturnToGuild$47653(this).GetEnumerator();
	}

	// Token: 0x0600C0B1 RID: 49329 RVA: 0x0145166C File Offset: 0x0144F86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M993_WindsAmusement.$ReturnToCamp$47657(this).GetEnumerator();
	}

	// Token: 0x0600C0B2 RID: 49330 RVA: 0x0145167C File Offset: 0x0144F87C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (34974 - 78780 != -43805)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (50983 - 577198 != -526214)
			{
				Hashtable hashtable = new Hashtable();
				if (199890 - 327210 != -127319)
				{
					hashtable.Add(43, PlayerData.UID);
					if (171996 - 405056 != -233059)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (186105 - 93326 == 92779)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C0B3 RID: 49331 RVA: 0x01451754 File Offset: 0x0144F954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600C0B4 RID: 49332 RVA: 0x01451768 File Offset: 0x0144F968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (158158 - 228636 != -70478)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (232235 - 562762 != -330526)
			{
				Hashtable hashtable = new Hashtable();
				if (124187 - 475249 == -351062)
				{
					if (Game.mNextGameCode == 30)
					{
						if (215030 - 53845 != 161185)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (189857 - 538858 != -349001)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (281371 - 162345 == 119027)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (206515 - 350693 != -144178)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (167326 - 561685 != -394359)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (213606 - 297993 == -84386)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (275394 - 238553 != 36841)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (8976 - 549113 == -540136)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (126314 - 100573 != 25741)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (299406 - 511928 != -212522)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (81631 - 169361 != -87730)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (294661 - 586754 != -292093)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (280827 - 364769 != -83942)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (127109 - 368285 != -241176)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (73235 - 561049 == -487813)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (114992 - 395423 == -280430)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (235202 - 394724 == -159521)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (155566 - 549860 != -394294)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (140552 - 29522 == 111031)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (298561 - 23172 == 275390)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (117155 - 416336 != -299181)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (234894 - 230016 != 4878)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (114835 - 84271 != 30564)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (229076 - 188178 == 40899)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (4864 - 48067 != -43203)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (82141 - 278555 == -196413)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (103134 - 377598 == -274463)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (11461 - 153061 == -141599)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (80189 - 267487 != -187297)
					{
						this.CAhnTI6RlgX.OpCustom(42, hashtable, true);
						if (77951 - 252283 != -174331)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C0B5 RID: 49333 RVA: 0x01451D1C File Offset: 0x0144FF1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C0B6 RID: 49334 RVA: 0x01451D2C File Offset: 0x0144FF2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C0B7 RID: 49335 RVA: 0x01451D30 File Offset: 0x0144FF30
	internal static bool UDUDhCtAoOnpdKACd352()
	{
		return true;
	}

	// Token: 0x0600C0B8 RID: 49336 RVA: 0x01451D34 File Offset: 0x0144FF34
	internal static bool efZPEAtAEP9MFveCglHd()
	{
		return false;
	}

	// Token: 0x0400A406 RID: 41990
	private LitePeer CAhnTI6RlgX;

	// Token: 0x0400A407 RID: 41991
	private PlayerCameraControl downTJLBPMk;

	// Token: 0x0400A408 RID: 41992
	private float xAknT6JivLq;

	// Token: 0x0400A409 RID: 41993
	private Texture KMMnTtaNlCD;

	// Token: 0x0400A40A RID: 41994
	private AudioClip nH9nTXlDi8l;

	// Token: 0x0400A40B RID: 41995
	private int tfPnTOhs8Kq;

	// Token: 0x0400A40C RID: 41996
	public AudioClip mBattleMusic;

	// Token: 0x0400A40D RID: 41997
	private int ibunT2i23ig;

	// Token: 0x02002023 RID: 8227
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$47605 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0B9 RID: 49337 RVA: 0x01451D38 File Offset: 0x0144FF38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$47605(M993_WindsAmusement self_)
		{
			if (74386 - 248197 != -173810)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47370 - 467619 != -420248)
				{
					base..ctor();
					if (29786 - 187762 == -157976)
					{
						this.$self_$47608 = self_;
						if (82617 - 15459 == 67158)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C0BA RID: 49338 RVA: 0x01451DD0 File Offset: 0x0144FFD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$StartEvent$47605.$(this.$self_$47608);
		}

		// Token: 0x0600C0BB RID: 49339 RVA: 0x01451DE0 File Offset: 0x0144FFE0
		internal static bool NRxT6htA23nLsNIfROTi()
		{
			return true;
		}

		// Token: 0x0600C0BC RID: 49340 RVA: 0x01451DE4 File Offset: 0x0144FFE4
		internal static bool MtihijtA8kX739atn0hl()
		{
			return false;
		}

		// Token: 0x0400A40E RID: 41998
		internal M993_WindsAmusement $self_$47608;

		// Token: 0x02002024 RID: 8228
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0BD RID: 49341 RVA: 0x01451DE8 File Offset: 0x0144FFE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M993_WindsAmusement self_)
			{
				if (6525 - 186313 != -179788)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136454 - 590338 == -453884)
					{
						base..ctor();
						if (161922 - 281534 != -119611)
						{
							this.$self_$47607 = self_;
							if (130039 - 303488 == -173449)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C0BE RID: 49342 RVA: 0x01451E80 File Offset: 0x01450080
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182931 - 207596 != -24664)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B5;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (1749 - 551085 != -549336)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (10858 - 582198 == -571339)
						{
							continue;
						}
						if (this.$self_$47607.nH9nTXlDi8l)
						{
							if (270738 - 485414 == -214675)
							{
								continue;
							}
							this.$self_$47607.audio.PlayOneShot(this.$self_$47607.nH9nTXlDi8l);
							if (281606 - 99404 == 182203)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (285223 - 254133 != 31091)
						{
							goto Block_8;
						}
						continue;
					default:
						if (169083 - 456689 != -287606)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$47606 = (GameGui)this.$self_$47607.GetComponent(typeof(GameGui));
					if (13023 - 517915 != -504891)
					{
						this.$mGameGui$47606.enabled = true;
						if (223417 - 216192 == 7225)
						{
							this.$self_$47607.SendMessage("fadeIn");
							if (234981 - 163387 != 71595)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_8:
				IL_1B5:
				return false;
			}

			// Token: 0x0600C0BF RID: 49343 RVA: 0x01452054 File Offset: 0x01450254
			internal static bool augXTitAZvl1ZZoBb8Q4()
			{
				return true;
			}

			// Token: 0x0600C0C0 RID: 49344 RVA: 0x01452058 File Offset: 0x01450258
			internal static bool nQCmemtACYw26kTMZbZ7()
			{
				return false;
			}

			// Token: 0x0400A40F RID: 41999
			internal GameGui $mGameGui$47606;

			// Token: 0x0400A410 RID: 42000
			internal M993_WindsAmusement $self_$47607;
		}
	}

	// Token: 0x02002025 RID: 8229
	[CompilerGenerated]
	[Serializable]
	internal sealed class $WindGodEvent$47609 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0C1 RID: 49345 RVA: 0x0145205C File Offset: 0x0145025C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $WindGodEvent$47609(M993_WindsAmusement self_)
		{
			if (57758 - 534910 != -477152)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114715 - 67601 == 47114)
				{
					base..ctor();
					if (293773 - 312965 != -19191)
					{
						this.$self_$47616 = self_;
						if (293177 - 298530 != -5352)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C0C2 RID: 49346 RVA: 0x014520F4 File Offset: 0x014502F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$WindGodEvent$47609.$(this.$self_$47616);
		}

		// Token: 0x0600C0C3 RID: 49347 RVA: 0x01452104 File Offset: 0x01450304
		internal static bool CorBl2tALPrXNjVYajVj()
		{
			return true;
		}

		// Token: 0x0600C0C4 RID: 49348 RVA: 0x01452108 File Offset: 0x01450308
		internal static bool vHglXCtAOdpKrf6fttm5()
		{
			return false;
		}

		// Token: 0x0400A411 RID: 42001
		internal M993_WindsAmusement $self_$47616;

		// Token: 0x02002026 RID: 8230
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0C5 RID: 49349 RVA: 0x0145210C File Offset: 0x0145030C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M993_WindsAmusement self_)
			{
				if (34751 - 226674 != -191923)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (24708 - 125493 != -100784)
					{
						base..ctor();
						if (54165 - 352287 == -298122)
						{
							this.$self_$47615 = self_;
							if (221433 - 202698 == 18735)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C0C6 RID: 49350 RVA: 0x014521A4 File Offset: 0x014503A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215177 - 197423 != 17755)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_942;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (46193 - 128491 != -82298)
							{
								continue;
							}
							goto IL_1F3;
						}
						else
						{
							this.$self_$47615.SendMessage("fadeOut");
							if (128865 - 46198 != 82667)
							{
								continue;
							}
							goto IL_613;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (69188 - 561032 != -491844)
							{
								continue;
							}
							goto IL_48D;
						}
						else
						{
							this.$self_$47615.downTJLBPMk.alignToObject("EventCamera1");
							if (150008 - 558903 == -408894)
							{
								continue;
							}
							this.$self_$47615.downTJLBPMk.enabled = false;
							if (100448 - 512424 != -411976)
							{
								continue;
							}
							this.$mPlayer$47611 = Game.mPlayer;
							if (56282 - 519160 != -462878)
							{
								continue;
							}
							this.$mSpawnPoint$47612 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (220416 - 424587 == -204170)
							{
								continue;
							}
							if (this.$mPlayer$47611)
							{
								if (27656 - 71283 == -43626)
								{
									continue;
								}
								if (this.$mSpawnPoint$47612)
								{
									if (1455 - 512741 != -511286)
									{
										continue;
									}
									this.$mPlayer$47611.transform.position = this.$mSpawnPoint$47612.transform.position;
									if (114587 - 335453 != -220866)
									{
										continue;
									}
									this.$mPlayer$47611.transform.rotation = this.$mSpawnPoint$47612.transform.rotation;
									if (67266 - 58280 == 8987)
									{
										continue;
									}
									this.$mPlayer$47611.SendMessage("PositionEvent");
									if (199824 - 389950 != -190126)
									{
										continue;
									}
								}
							}
							this.$self_$47615.SendMessage("fadeIn");
							if (175470 - 69354 != 106117)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (51415 - 223037 != -171622)
							{
								continue;
							}
							goto IL_7F5;
						}
						else
						{
							this.$mStoryGui$47613 = (StoryGui)this.$self_$47615.GetComponent(typeof(StoryGui));
							if (284584 - 91266 != 193318)
							{
								continue;
							}
							this.$mStoryTimer$47614 = 0f;
							if (259572 - 556336 == -296763)
							{
								continue;
							}
							if (!this.$mStoryGui$47613)
							{
								if (128030 - 419392 != -291361)
								{
									goto Block_13;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$47613.startStoryMessage("WindGod", "Sun Sun", eTalkType.friend);
								if (220270 - 493301 != -273031)
								{
									continue;
								}
								goto IL_4C1;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (29649 - 47714 != -18065)
							{
								continue;
							}
							goto IL_4FC;
						}
						else
						{
							this.$mStoryGui$47613.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M993_WindsAmusement", 101), eTalkType.friend);
							if (193184 - 500709 != -307524)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (248102 - 431872 != -183769)
							{
								goto Block_62;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47613.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M993_WindsAmusement", 102), eTalkType.friend);
							if (172300 - 577213 != -404912)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (198373 - 15799 != 182575)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47613.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M993_WindsAmusement", 103), eTalkType.friend);
							if (40790 - 415430 != -374640)
							{
								continue;
							}
							goto IL_17D;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (234894 - 369946 != -135051)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47613.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M993_WindsAmusement", 104), eTalkType.enemy);
							if (199860 - 560298 != -360437)
							{
								goto Block_55;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212531 - 295671 != -83140)
							{
								continue;
							}
							goto IL_870;
						}
						else
						{
							this.$mStoryGui$47613.close();
							if (132999 - 85844 != 47155)
							{
								continue;
							}
							goto IL_599;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (159707 - 20440 != 139268)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							if (this.$self_$47615.mBattleMusic)
							{
								if (178127 - 200056 == -21928)
								{
									continue;
								}
								this.$self_$47615.audio.clip = this.$self_$47615.mBattleMusic;
								if (283932 - 260114 != 23818)
								{
									continue;
								}
								this.$self_$47615.audio.volume = 0.1f * (float)Game.music;
								if (250158 - 248429 != 1729)
								{
									continue;
								}
								this.$self_$47615.audio.Play();
								if (176384 - 307990 != -131606)
								{
									continue;
								}
							}
							this.$mGameGui$47610.enabled = true;
							if (180265 - 42286 == 137980)
							{
								continue;
							}
							this.$self_$47615.downTJLBPMk.enabled = true;
							if (132952 - 275932 != -142980)
							{
								continue;
							}
							goto IL_834;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (137012 - 364821 != -227808)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (186841 - 441585 == -254743)
							{
								continue;
							}
							this.YieldDefault(1);
							if (51192 - 130804 != -79611)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (79810 - 5501 == 74310)
						{
							continue;
						}
						break;
					}
					Debug.Log("WindGodEvent");
					if (267990 - 278222 == -10232)
					{
						if (this.$self_$47615.tfPnTOhs8Kq < 1)
						{
							if (251765 - 184876 != 66889)
							{
								continue;
							}
							this.$self_$47615.tfPnTOhs8Kq = 1;
							if (14534 - 231351 != -216817)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (101581 - 231919 != -130337)
						{
							this.$mGameGui$47610 = (GameGui)this.$self_$47615.GetComponent(typeof(GameGui));
							if (97674 - 270875 == -173201)
							{
								if (!this.$mGameGui$47610)
								{
									goto IL_1B8;
								}
								if (47614 - 413300 == -365686)
								{
									this.$mGameGui$47610.close();
									if (166056 - 394653 != -228596)
									{
										goto Block_20;
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_942;
				Block_11:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_13:
				goto IL_942;
				IL_17D:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_15:
				goto IL_942;
				IL_1B8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1F3:
				goto IL_942;
				Block_20:
				goto IL_1B8;
				Block_26:
				IL_48D:
				goto IL_942;
				IL_4C1:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_4FC:
				goto IL_942;
				Block_39:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_599:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_43:
				goto IL_942;
				IL_613:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_47:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_55:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_7F5:
				goto IL_942;
				IL_834:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_59:
				IL_870:
				Block_62:
				IL_942:
				return false;
			}

			// Token: 0x0600C0C7 RID: 49351 RVA: 0x01452B08 File Offset: 0x01450D08
			internal static bool jB2GKGtAmvSJLkoQbEPc()
			{
				return true;
			}

			// Token: 0x0600C0C8 RID: 49352 RVA: 0x01452B0C File Offset: 0x01450D0C
			internal static bool kXBZeXtAFgVVOnvIenkK()
			{
				return false;
			}

			// Token: 0x0400A412 RID: 42002
			internal GameGui $mGameGui$47610;

			// Token: 0x0400A413 RID: 42003
			internal GameObject $mPlayer$47611;

			// Token: 0x0400A414 RID: 42004
			internal GameObject $mSpawnPoint$47612;

			// Token: 0x0400A415 RID: 42005
			internal StoryGui $mStoryGui$47613;

			// Token: 0x0400A416 RID: 42006
			internal float $mStoryTimer$47614;

			// Token: 0x0400A417 RID: 42007
			internal M993_WindsAmusement $self_$47615;
		}
	}

	// Token: 0x02002027 RID: 8231
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$47617 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0C9 RID: 49353 RVA: 0x01452B10 File Offset: 0x01450D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$47617(M993_WindsAmusement self_)
		{
			if (127882 - 217524 != -89642)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77 - 259643 == -259566)
				{
					base..ctor();
					if (67398 - 415213 != -347814)
					{
						this.$self_$47624 = self_;
						if (209249 - 342048 == -132799)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C0CA RID: 49354 RVA: 0x01452BA8 File Offset: 0x01450DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$EndEvent$47617.$(this.$self_$47624);
		}

		// Token: 0x0600C0CB RID: 49355 RVA: 0x01452BB8 File Offset: 0x01450DB8
		internal static bool Vjb93atAMqnhmgD9KtMN()
		{
			return true;
		}

		// Token: 0x0600C0CC RID: 49356 RVA: 0x01452BBC File Offset: 0x01450DBC
		internal static bool qjTMpytAxX95PnUTryJd()
		{
			return false;
		}

		// Token: 0x0400A418 RID: 42008
		internal M993_WindsAmusement $self_$47624;

		// Token: 0x02002028 RID: 8232
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0CD RID: 49357 RVA: 0x01452BC0 File Offset: 0x01450DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M993_WindsAmusement self_)
			{
				if (234630 - 589434 != -354804)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103556 - 111339 != -7782)
					{
						base..ctor();
						if (222614 - 55567 != 167048)
						{
							this.$self_$47623 = self_;
							if (29623 - 43278 != -13654)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C0CE RID: 49358 RVA: 0x01452C58 File Offset: 0x01450E58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (121207 - 210128 != -88920)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7C5;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (222049 - 512699 != -290649)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$self_$47623.SendMessage("fadeOut");
							if (221950 - 512974 != -291024)
							{
								continue;
							}
							goto IL_13C;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (10975 - 364021 != -353045)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$47623.downTJLBPMk.alignToObject("EventCamera1");
							if (219756 - 222776 != -3020)
							{
								continue;
							}
							this.$self_$47623.downTJLBPMk.enabled = false;
							if (175204 - 67972 == 107233)
							{
								continue;
							}
							this.$mPlayer$47619 = Game.mPlayer;
							if (250698 - 188895 == 61804)
							{
								continue;
							}
							this.$mSpawnPoint$47620 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (109844 - 539218 == -429373)
							{
								continue;
							}
							if (this.$mPlayer$47619)
							{
								if (234602 - 176537 == 58066)
								{
									continue;
								}
								if (this.$mSpawnPoint$47620)
								{
									if (75235 - 14036 == 61200)
									{
										continue;
									}
									this.$mPlayer$47619.transform.position = this.$mSpawnPoint$47620.transform.position;
									if (136714 - 394730 != -258016)
									{
										continue;
									}
									this.$mPlayer$47619.transform.rotation = this.$mSpawnPoint$47620.transform.rotation;
									if (54209 - 53986 == 224)
									{
										continue;
									}
									this.$mPlayer$47619.SendMessage("PositionEvent");
									if (75870 - 295605 != -219735)
									{
										continue;
									}
								}
							}
							this.$self_$47623.SendMessage("fadeIn");
							if (275212 - 212949 != 62264)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (170678 - 421420 != -250741)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47621 = (StoryGui)this.$self_$47623.GetComponent(typeof(StoryGui));
							if (52467 - 349364 == -296896)
							{
								continue;
							}
							this.$mStoryTimer$47622 = 0f;
							if (163784 - 325477 == -161692)
							{
								continue;
							}
							if (!this.$mStoryGui$47621)
							{
								if (236734 - 211680 != 25055)
								{
									goto Block_20;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$47621.startStoryMessage("WindGod", "Sun Sun", eTalkType.friend);
								if (12326 - 511884 != -499557)
								{
									goto Block_30;
								}
								continue;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (89652 - 231467 != -141814)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47621.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M993_WindsAmusement", 201), eTalkType.friend);
							if (261171 - 351362 != -90191)
							{
								continue;
							}
							goto IL_101;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (117659 - 198145 != -80486)
							{
								continue;
							}
							goto IL_689;
						}
						else
						{
							this.$mStoryGui$47621.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M993_WindsAmusement", 202), eTalkType.friend);
							if (2725 - 220343 != -217618)
							{
								continue;
							}
							goto IL_6CE;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (175288 - 31773 != 143516)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47621.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M993_WindsAmusement", 203), eTalkType.friend);
							if (136304 - 155759 != -19454)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (210187 - 164249 != 45939)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47621.close();
							if (1279 - 195470 != -194191)
							{
								continue;
							}
							goto IL_1A1;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (137767 - 485801 != -348034)
							{
								continue;
							}
							goto IL_2EC;
						}
						else
						{
							if (this.$self_$47623.tfPnTOhs8Kq < 3)
							{
								if (180663 - 343114 != -162451)
								{
									continue;
								}
								this.$self_$47623.tfPnTOhs8Kq = 3;
								if (254874 - 40954 == 213921)
								{
									continue;
								}
								Game.sendMissionEvent(9934, 1);
								if (28459 - 116488 != -88029)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (13501 - 211565 != -198064)
							{
								continue;
							}
							goto IL_7C5;
						}
						break;
					default:
						if (1145 - 53995 == -52849)
						{
							continue;
						}
						break;
					}
					Debug.Log("EndEvent");
					if (292637 - 96967 != 195671)
					{
						if (this.$self_$47623.tfPnTOhs8Kq < 2)
						{
							if (54254 - 248680 == -194425)
							{
								continue;
							}
							this.$self_$47623.tfPnTOhs8Kq = 2;
							if (210283 - 458556 != -248273)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (225595 - 590146 != -364550)
						{
							this.$mGameGui$47618 = (GameGui)this.$self_$47623.GetComponent(typeof(GameGui));
							if (133472 - 377747 != -244274)
							{
								if (!this.$mGameGui$47618)
								{
									goto IL_346;
								}
								if (220084 - 525378 != -305293)
								{
									this.$mGameGui$47618.close();
									if (21015 - 513839 != -492823)
									{
										goto Block_36;
									}
								}
							}
						}
					}
				}
				Block_8:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_101:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_13C:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_12:
				goto IL_7C5;
				IL_1A1:
				return this.Yield(9, new WaitForSeconds(1.5f));
				Block_20:
				IL_2EC:
				goto IL_7C5;
				IL_346:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_27:
				goto IL_7C5;
				Block_30:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_36:
				goto IL_346;
				Block_38:
				goto IL_7C5;
				Block_39:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_689:
				goto IL_7C5;
				IL_6CE:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_49:
				Block_51:
				Block_55:
				IL_7C5:
				return false;
			}

			// Token: 0x0600C0CF RID: 49359 RVA: 0x0145343C File Offset: 0x0145163C
			internal static bool wiSqtytAgw8eq8dfUsEu()
			{
				return true;
			}

			// Token: 0x0600C0D0 RID: 49360 RVA: 0x01453440 File Offset: 0x01451640
			internal static bool PQ41FotAfyjjMTtHCRij()
			{
				return false;
			}

			// Token: 0x0400A419 RID: 42009
			internal GameGui $mGameGui$47618;

			// Token: 0x0400A41A RID: 42010
			internal GameObject $mPlayer$47619;

			// Token: 0x0400A41B RID: 42011
			internal GameObject $mSpawnPoint$47620;

			// Token: 0x0400A41C RID: 42012
			internal StoryGui $mStoryGui$47621;

			// Token: 0x0400A41D RID: 42013
			internal float $mStoryTimer$47622;

			// Token: 0x0400A41E RID: 42014
			internal M993_WindsAmusement $self_$47623;
		}
	}

	// Token: 0x02002029 RID: 8233
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$47625 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0D1 RID: 49361 RVA: 0x01453444 File Offset: 0x01451644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$47625(M993_WindsAmusement self_)
		{
			if (22238 - 378081 != -355843)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196960 - 251269 == -54309)
				{
					base..ctor();
					if (85969 - 276104 != -190134)
					{
						this.$self_$47630 = self_;
						if (44382 - 333084 == -288702)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C0D2 RID: 49362 RVA: 0x014534DC File Offset: 0x014516DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$onDeadPlayer$47625.$(this.$self_$47630);
		}

		// Token: 0x0600C0D3 RID: 49363 RVA: 0x014534EC File Offset: 0x014516EC
		internal static bool SqYXkltAnt7KnjbFkey7()
		{
			return true;
		}

		// Token: 0x0600C0D4 RID: 49364 RVA: 0x014534F0 File Offset: 0x014516F0
		internal static bool ulQMactA6EddB3TkgLXK()
		{
			return false;
		}

		// Token: 0x0400A41F RID: 42015
		internal M993_WindsAmusement $self_$47630;

		// Token: 0x0200202A RID: 8234
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0D5 RID: 49365 RVA: 0x014534F4 File Offset: 0x014516F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M993_WindsAmusement self_)
			{
				if (68184 - 68051 != 133)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237608 - 321637 != -84028)
					{
						base..ctor();
						if (133231 - 398351 == -265120)
						{
							this.$self_$47629 = self_;
							if (145735 - 324024 == -178289)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C0D6 RID: 49366 RVA: 0x0145358C File Offset: 0x0145178C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159983 - 534953 != -374970)
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
							if (135371 - 566740 != -431369)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1AC;
							}
							if (29492 - 171112 == -141619)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (290121 - 438410 != -148289)
						{
							continue;
						}
						this.$mStoryGui$47626 = (StoryGui)this.$self_$47629.GetComponent(typeof(StoryGui));
						if (23183 - 250684 != -227501)
						{
							continue;
						}
						if (this.$mStoryGui$47626)
						{
							if (143000 - 104575 != 38425)
							{
								continue;
							}
							this.$mStoryGui$47626.close();
							if (253882 - 362636 != -108754)
							{
								continue;
							}
						}
						this.$mChangeGui$47627 = (ChangeGui)this.$self_$47629.GetComponent(typeof(ChangeGui));
						if (172761 - 228703 == -55941)
						{
							continue;
						}
						if (this.$mChangeGui$47627)
						{
							if (64962 - 464312 == -399349)
							{
								continue;
							}
							this.$mChangeGui$47627.close();
							if (66730 - 276124 == -209393)
							{
								continue;
							}
						}
						this.$mGameGui$47628 = (GameGui)this.$self_$47629.GetComponent(typeof(GameGui));
						if (112698 - 496550 == -383851)
						{
							continue;
						}
						if (this.$mGameGui$47628)
						{
							if (135136 - 172140 == -37003)
							{
								continue;
							}
							if (!this.$mGameGui$47628.enabled)
							{
								if (281050 - 48040 == 233011)
								{
									continue;
								}
								this.$mGameGui$47628.enabled = true;
								if (128696 - 77823 != 50873)
								{
									continue;
								}
							}
							this.$mGameGui$47628.openDeadMenu();
							if (279549 - 42732 != 236817)
							{
								continue;
							}
						}
						IL_1AC:
						this.YieldDefault(1);
						if (192293 - 97885 != 94408)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (281150 - 150528 == 130623)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (167878 - 118556 == 49323);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600C0D7 RID: 49367 RVA: 0x014538A4 File Offset: 0x01451AA4
			internal static bool KL3tDgtAiDPOTgJG1Bta()
			{
				return true;
			}

			// Token: 0x0600C0D8 RID: 49368 RVA: 0x014538A8 File Offset: 0x01451AA8
			internal static bool k5mXJ2tAKgcXVBLINl9d()
			{
				return false;
			}

			// Token: 0x0400A420 RID: 42016
			internal StoryGui $mStoryGui$47626;

			// Token: 0x0400A421 RID: 42017
			internal ChangeGui $mChangeGui$47627;

			// Token: 0x0400A422 RID: 42018
			internal GameGui $mGameGui$47628;

			// Token: 0x0400A423 RID: 42019
			internal M993_WindsAmusement $self_$47629;
		}
	}

	// Token: 0x0200202B RID: 8235
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47631 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0D9 RID: 49369 RVA: 0x014538AC File Offset: 0x01451AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47631(Hashtable data, M993_WindsAmusement self_)
		{
			if (126458 - 490570 != -364111)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253402 - 586940 != -333537)
				{
					base..ctor();
					if (4591 - 147383 != -142791)
					{
						this.$data$47636 = data;
						if (96706 - 21762 == 74944)
						{
							this.$self_$47637 = self_;
							if (241031 - 413921 != -172889)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C0DA RID: 49370 RVA: 0x01453968 File Offset: 0x01451B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$onChangePlayer$47631.$(this.$data$47636, this.$self_$47637);
		}

		// Token: 0x0600C0DB RID: 49371 RVA: 0x0145397C File Offset: 0x01451B7C
		internal static bool sc2tv1tAd3fbqUU60lvF()
		{
			return true;
		}

		// Token: 0x0600C0DC RID: 49372 RVA: 0x01453980 File Offset: 0x01451B80
		internal static bool iPwS9ntAJAj9L0BWy2II()
		{
			return false;
		}

		// Token: 0x0400A424 RID: 42020
		internal Hashtable $data$47636;

		// Token: 0x0400A425 RID: 42021
		internal M993_WindsAmusement $self_$47637;

		// Token: 0x0200202C RID: 8236
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0DD RID: 49373 RVA: 0x01453984 File Offset: 0x01451B84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M993_WindsAmusement self_)
			{
				if (22195 - 388004 != -365809)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19551 - 316663 == -297112)
					{
						base..ctor();
						if (53009 - 163548 != -110538)
						{
							this.$data$47634 = data;
							if (192177 - 262402 != -70224)
							{
								this.$self_$47635 = self_;
								if (105555 - 53617 != 51939)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C0DE RID: 49374 RVA: 0x01453A40 File Offset: 0x01451C40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (73249 - 456157 != -382908)
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
							if (82350 - 129231 == -46880)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (95170 - 132987 != -37817)
							{
								continue;
							}
							this.$mGameGui$47633 = (GameGui)this.$self_$47635.GetComponent(typeof(GameGui));
							if (63369 - 502641 == -439271)
							{
								continue;
							}
							this.$mGameGui$47633.enabled = true;
							if (245176 - 293086 == -47909)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (372 - 253487 != -253114)
						{
							goto Block_2;
						}
						continue;
					default:
						if (37576 - 44133 == -6556)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (107169 - 594308 == -487139)
					{
						this.$self_$47635.SendMessage("onCreatePlayer", this.$data$47634);
						if (4778 - 456139 != -451360)
						{
							this.$mChangeGui$47632 = (ChangeGui)this.$self_$47635.GetComponent(typeof(ChangeGui));
							if (237308 - 187571 == 49737)
							{
								if (!this.$mChangeGui$47632.enabled)
								{
									goto IL_17A;
								}
								if (185317 - 192339 != -7021)
								{
									this.$mChangeGui$47632.close();
									if (62002 - 415794 != -353791)
									{
										goto IL_17A;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_205;
				IL_17A:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600C0DF RID: 49375 RVA: 0x01453C64 File Offset: 0x01451E64
			internal static bool QfN5srtAD7baYKHQIMud()
			{
				return true;
			}

			// Token: 0x0600C0E0 RID: 49376 RVA: 0x01453C68 File Offset: 0x01451E68
			internal static bool d9cEKWtAvO4b8IHMeZro()
			{
				return false;
			}

			// Token: 0x0400A426 RID: 42022
			internal ChangeGui $mChangeGui$47632;

			// Token: 0x0400A427 RID: 42023
			internal GameGui $mGameGui$47633;

			// Token: 0x0400A428 RID: 42024
			internal Hashtable $data$47634;

			// Token: 0x0400A429 RID: 42025
			internal M993_WindsAmusement $self_$47635;
		}
	}

	// Token: 0x0200202D RID: 8237
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47638 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0E1 RID: 49377 RVA: 0x01453C6C File Offset: 0x01451E6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47638(Hashtable data, M993_WindsAmusement self_)
		{
			if (34225 - 31595 != 2631)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (211545 - 29654 != 181892)
				{
					base..ctor();
					if (286635 - 242080 == 44555)
					{
						this.$data$47646 = data;
						if (106149 - 256373 != -150223)
						{
							this.$self_$47647 = self_;
							if (208024 - 185896 != 22129)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C0E2 RID: 49378 RVA: 0x01453D28 File Offset: 0x01451F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$onGameComplete$47638.$(this.$data$47646, this.$self_$47647);
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x01453D3C File Offset: 0x01451F3C
		internal static bool JhNi9VtARWIcUBZ6Zb7d()
		{
			return true;
		}

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x01453D40 File Offset: 0x01451F40
		internal static bool R0WEDStAwaIUV1AFcShP()
		{
			return false;
		}

		// Token: 0x0400A42A RID: 42026
		internal Hashtable $data$47646;

		// Token: 0x0400A42B RID: 42027
		internal M993_WindsAmusement $self_$47647;

		// Token: 0x0200202E RID: 8238
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0E5 RID: 49381 RVA: 0x01453D44 File Offset: 0x01451F44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M993_WindsAmusement self_)
			{
				if (286280 - 10430 != 275851)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29094 - 439509 == -410415)
					{
						base..ctor();
						if (82821 - 453749 != -370927)
						{
							this.$data$47644 = data;
							if (264437 - 456484 != -192046)
							{
								this.$self_$47645 = self_;
								if (235950 - 39617 == 196333)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C0E6 RID: 49382 RVA: 0x01453E00 File Offset: 0x01452000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214968 - 345820 != -130852)
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
						this.$mCompleteGui$47640 = (CompleteGui)this.$self_$47645.GetComponent(typeof(CompleteGui));
						if (257565 - 453013 != -195448)
						{
							continue;
						}
						this.$mCompleteGui$47640.Init();
						if (132098 - 590375 != -458277)
						{
							continue;
						}
						this.$mCompleteGui$47640.readData(this.$data$47644);
						if (153113 - 131382 == 21732)
						{
							continue;
						}
						if (this.$result$47639 == 1)
						{
							if (204490 - 253641 != -49151)
							{
								continue;
							}
							this.$mCompleteGui$47640.displayResult(eCompleteType.Success);
							if (204001 - 591085 == -387083)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47640.displayResult(eCompleteType.Failed);
							if (243796 - 510140 == -266343)
							{
								continue;
							}
						}
						this.$mGameGui$47641 = (GameGui)this.$self_$47645.GetComponent(typeof(GameGui));
						if (181147 - 62311 != 118836)
						{
							continue;
						}
						this.$mStoryGui$47642 = (StoryGui)this.$self_$47645.GetComponent(typeof(StoryGui));
						if (60993 - 31186 != 29807)
						{
							continue;
						}
						this.$mChangeGui$47643 = (ChangeGui)this.$self_$47645.GetComponent(typeof(ChangeGui));
						if (162952 - 518703 != -355751)
						{
							continue;
						}
						if (this.$mGameGui$47641)
						{
							if (154234 - 233688 != -79454)
							{
								continue;
							}
							this.$mGameGui$47641.close();
							if (264644 - 323716 == -59071)
							{
								continue;
							}
						}
						if (this.$mStoryGui$47642)
						{
							if (42588 - 239961 == -197372)
							{
								continue;
							}
							this.$mStoryGui$47642.close();
							if (211512 - 103756 == 107757)
							{
								continue;
							}
						}
						if (this.$mChangeGui$47643)
						{
							if (284141 - 400864 == -116722)
							{
								continue;
							}
							this.$mChangeGui$47643.disable();
							if (11124 - 164533 != -153409)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (158215 - 294786 != -136571)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (146665 - 183036 != -36371)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$47644[31]);
					if (22862 - 196609 == -173747)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (92038 - 184606 == -92568)
							{
								goto IL_310;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (127031 - 269025 != -141993)
							{
								this.$result$47639 = RuntimeServices.UnboxInt32(this.$data$47644[31]);
								if (259830 - 308089 != -48258)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_310:
				IL_3DB:
				return false;
			}

			// Token: 0x0600C0E7 RID: 49383 RVA: 0x014541FC File Offset: 0x014523FC
			internal static bool FKijcstAqHV0tgaSX9st()
			{
				return true;
			}

			// Token: 0x0600C0E8 RID: 49384 RVA: 0x01454200 File Offset: 0x01452400
			internal static bool vmehZmtA79DNPoC9Z7Qw()
			{
				return false;
			}

			// Token: 0x0400A42C RID: 42028
			internal int $result$47639;

			// Token: 0x0400A42D RID: 42029
			internal CompleteGui $mCompleteGui$47640;

			// Token: 0x0400A42E RID: 42030
			internal GameGui $mGameGui$47641;

			// Token: 0x0400A42F RID: 42031
			internal StoryGui $mStoryGui$47642;

			// Token: 0x0400A430 RID: 42032
			internal ChangeGui $mChangeGui$47643;

			// Token: 0x0400A431 RID: 42033
			internal Hashtable $data$47644;

			// Token: 0x0400A432 RID: 42034
			internal M993_WindsAmusement $self_$47645;
		}
	}

	// Token: 0x0200202F RID: 8239
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47648 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0E9 RID: 49385 RVA: 0x01454204 File Offset: 0x01452404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47648(M993_WindsAmusement self_)
		{
			if (100351 - 350457 != -250105)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33214 - 207459 == -174245)
				{
					base..ctor();
					if (248121 - 262751 == -14630)
					{
						this.$self_$47652 = self_;
						if (218249 - 446313 != -228063)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C0EA RID: 49386 RVA: 0x0145429C File Offset: 0x0145249C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$ReturnToTown$47648.$(this.$self_$47652);
		}

		// Token: 0x0600C0EB RID: 49387 RVA: 0x014542AC File Offset: 0x014524AC
		internal static bool DEetOttAPS81spr8UDrm()
		{
			return true;
		}

		// Token: 0x0600C0EC RID: 49388 RVA: 0x014542B0 File Offset: 0x014524B0
		internal static bool l8bcRHtA0eTg9xUmnjyJ()
		{
			return false;
		}

		// Token: 0x0400A433 RID: 42035
		internal M993_WindsAmusement $self_$47652;

		// Token: 0x02002030 RID: 8240
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0ED RID: 49389 RVA: 0x014542B4 File Offset: 0x014524B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M993_WindsAmusement self_)
			{
				if (271069 - 271257 != -187)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (100072 - 121586 != -21513)
					{
						base..ctor();
						if (90953 - 112664 == -21711)
						{
							this.$self_$47651 = self_;
							if (58169 - 348245 != -290075)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C0EE RID: 49390 RVA: 0x0145434C File Offset: 0x0145254C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253421 - 467450 != -214028)
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
						this.$self_$47651.LeaveGame();
						if (120210 - 285991 == -165780)
						{
							continue;
						}
						this.YieldDefault(1);
						if (189907 - 243141 != -53234)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (80463 - 360153 == -279689)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (259303 - 496243 == -236940)
					{
						Game.mStateTime = Time.time;
						if (260053 - 106210 != 153844)
						{
							this.$$switch$8953$47649 = PlayerData.SaveGuild;
							if (76694 - 488043 != -411348)
							{
								if (this.$$switch$8953$47649 == 1)
								{
									if (90164 - 367602 == -277437)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (192174 - 247342 != -55168)
									{
										continue;
									}
								}
								else if (this.$$switch$8953$47649 == 2)
								{
									if (52694 - 240472 == -187777)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (48922 - 447359 == -398436)
									{
										continue;
									}
								}
								else if (this.$$switch$8953$47649 == 3)
								{
									if (229568 - 38847 == 190722)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (193365 - 204307 == -10941)
									{
										continue;
									}
								}
								else if (this.$$switch$8953$47649 == 4)
								{
									if (285911 - 218430 != 67481)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (165511 - 406929 == -241417)
									{
										continue;
									}
								}
								else if (this.$$switch$8953$47649 == 5)
								{
									if (11288 - 225714 == -214425)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (281408 - 578322 == -296913)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (9031 - 532863 != -523832)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (43815 - 311456 == -267640)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (59742 - 23776 != 35966)
									{
										continue;
									}
								}
								this.$mGameGui$47650 = (GameGui)this.$self_$47651.GetComponent(typeof(GameGui));
								if (109397 - 432689 == -323292)
								{
									if (this.$mGameGui$47650)
									{
										if (94968 - 523689 != -428721)
										{
											continue;
										}
										this.$mGameGui$47650.close();
										if (63858 - 130484 != -66626)
										{
											continue;
										}
									}
									this.$self_$47651.SendMessage("fadeOut");
									if (237867 - 30629 != 207239)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600C0EF RID: 49391 RVA: 0x01454718 File Offset: 0x01452918
			internal static bool enBCNhtAbRXSYeHQoYju()
			{
				return true;
			}

			// Token: 0x0600C0F0 RID: 49392 RVA: 0x0145471C File Offset: 0x0145291C
			internal static bool McEJa9tAusnIjvXYENAm()
			{
				return false;
			}

			// Token: 0x0400A434 RID: 42036
			internal int $$switch$8953$47649;

			// Token: 0x0400A435 RID: 42037
			internal GameGui $mGameGui$47650;

			// Token: 0x0400A436 RID: 42038
			internal M993_WindsAmusement $self_$47651;
		}
	}

	// Token: 0x02002031 RID: 8241
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47653 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0F1 RID: 49393 RVA: 0x01454720 File Offset: 0x01452920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47653(M993_WindsAmusement self_)
		{
			if (5120 - 506008 != -500887)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197946 - 209731 == -11785)
				{
					base..ctor();
					if (134251 - 349911 == -215660)
					{
						this.$self_$47656 = self_;
						if (91036 - 156079 != -65042)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C0F2 RID: 49394 RVA: 0x014547B8 File Offset: 0x014529B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$ReturnToGuild$47653.$(this.$self_$47656);
		}

		// Token: 0x0600C0F3 RID: 49395 RVA: 0x014547C8 File Offset: 0x014529C8
		internal static bool ckDqTNtAIkrFkFUhy54I()
		{
			return true;
		}

		// Token: 0x0600C0F4 RID: 49396 RVA: 0x014547CC File Offset: 0x014529CC
		internal static bool NofsqctABPRtuDPx2YTs()
		{
			return false;
		}

		// Token: 0x0400A437 RID: 42039
		internal M993_WindsAmusement $self_$47656;

		// Token: 0x02002032 RID: 8242
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0F5 RID: 49397 RVA: 0x014547D0 File Offset: 0x014529D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M993_WindsAmusement self_)
			{
				if (209176 - 30944 != 178233)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91937 - 13965 != 77973)
					{
						base..ctor();
						if (210570 - 234192 == -23622)
						{
							this.$self_$47655 = self_;
							if (295556 - 115939 == 179617)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C0F6 RID: 49398 RVA: 0x01454868 File Offset: 0x01452A68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191677 - 325579 != -133901)
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
						this.$self_$47655.LeaveGame();
						if (182234 - 242350 == -60115)
						{
							continue;
						}
						this.YieldDefault(1);
						if (111244 - 471107 != -359862)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (71039 - 61371 != 9668)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (272389 - 83038 == 189351)
					{
						Game.mStateTime = Time.time;
						if (289119 - 369140 != -80020)
						{
							Game.mNextGameCode = 31;
							if (237861 - 313939 == -76078)
							{
								this.$mGameGui$47654 = (GameGui)this.$self_$47655.GetComponent(typeof(GameGui));
								if (245620 - 504235 == -258615)
								{
									if (this.$mGameGui$47654)
									{
										if (148599 - 250443 != -101844)
										{
											continue;
										}
										this.$mGameGui$47654.close();
										if (246621 - 458083 != -211462)
										{
											continue;
										}
									}
									this.$self_$47655.SendMessage("fadeOut");
									if (25768 - 216863 != -191094)
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

			// Token: 0x0600C0F7 RID: 49399 RVA: 0x01454A44 File Offset: 0x01452C44
			internal static bool yDgIPttAesFodd0KAmu2()
			{
				return true;
			}

			// Token: 0x0600C0F8 RID: 49400 RVA: 0x01454A48 File Offset: 0x01452C48
			internal static bool zkp2VgtArA6wjHlMr9DA()
			{
				return false;
			}

			// Token: 0x0400A438 RID: 42040
			internal GameGui $mGameGui$47654;

			// Token: 0x0400A439 RID: 42041
			internal M993_WindsAmusement $self_$47655;
		}
	}

	// Token: 0x02002033 RID: 8243
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47657 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C0F9 RID: 49401 RVA: 0x01454A4C File Offset: 0x01452C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47657(M993_WindsAmusement self_)
		{
			if (21085 - 412697 != -391611)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65987 - 508737 != -442749)
				{
					base..ctor();
					if (94054 - 39456 == 54598)
					{
						this.$self_$47661 = self_;
						if (190405 - 540167 == -349762)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C0FA RID: 49402 RVA: 0x01454AE4 File Offset: 0x01452CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M993_WindsAmusement.$ReturnToCamp$47657.$(this.$self_$47661);
		}

		// Token: 0x0600C0FB RID: 49403 RVA: 0x01454AF4 File Offset: 0x01452CF4
		internal static bool N8F5VXtAj8vjpp9sRWKX()
		{
			return true;
		}

		// Token: 0x0600C0FC RID: 49404 RVA: 0x01454AF8 File Offset: 0x01452CF8
		internal static bool FhuSiGtAhXh0ZCWPHOMf()
		{
			return false;
		}

		// Token: 0x0400A43A RID: 42042
		internal M993_WindsAmusement $self_$47661;

		// Token: 0x02002034 RID: 8244
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C0FD RID: 49405 RVA: 0x01454AFC File Offset: 0x01452CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M993_WindsAmusement self_)
			{
				if (37218 - 597803 != -560585)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33747 - 38740 != -4992)
					{
						base..ctor();
						if (4965 - 285713 != -280747)
						{
							this.$self_$47660 = self_;
							if (96811 - 421239 != -324427)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C0FE RID: 49406 RVA: 0x01454B94 File Offset: 0x01452D94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5377 - 205142 != -199765)
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
						this.$self_$47660.LeaveGame();
						if (171009 - 164378 != 6631)
						{
							continue;
						}
						this.YieldDefault(1);
						if (152362 - 299759 != -147397)
						{
							continue;
						}
						goto IL_363;
					default:
						if (155692 - 130718 != 24974)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (243523 - 341678 != -98154)
					{
						Game.mStateTime = Time.time;
						if (255503 - 227734 == 27769)
						{
							this.$$switch$8955$47658 = PlayerData.SaveGuild;
							if (136815 - 342753 == -205938)
							{
								if (this.$$switch$8955$47658 == 1)
								{
									if (102541 - 518453 != -415912)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (209981 - 527411 != -317430)
									{
										continue;
									}
								}
								else if (this.$$switch$8955$47658 == 2)
								{
									if (144758 - 414438 != -269680)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (87110 - 23431 == 63680)
									{
										continue;
									}
								}
								else if (this.$$switch$8955$47658 == 3)
								{
									if (59297 - 498364 == -439066)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (271951 - 52692 == 219260)
									{
										continue;
									}
								}
								else if (this.$$switch$8955$47658 == 4)
								{
									if (202479 - 450732 != -248253)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (260673 - 114862 == 145812)
									{
										continue;
									}
								}
								else if (this.$$switch$8955$47658 == 5)
								{
									if (189047 - 577636 != -388589)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (8164 - 126576 != -118412)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (60933 - 319645 == -258711)
									{
										continue;
									}
								}
								this.$mGameGui$47659 = (GameGui)this.$self_$47660.GetComponent(typeof(GameGui));
								if (146798 - 428311 == -281513)
								{
									if (this.$mGameGui$47659)
									{
										if (193824 - 592995 == -399170)
										{
											continue;
										}
										this.$mGameGui$47659.close();
										if (457 - 319942 != -319485)
										{
											continue;
										}
									}
									this.$self_$47660.SendMessage("fadeOut");
									if (129158 - 264137 != -134978)
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

			// Token: 0x0600C0FF RID: 49407 RVA: 0x01454F18 File Offset: 0x01453118
			internal static bool MLdM68tAsJpUtaWdij7n()
			{
				return true;
			}

			// Token: 0x0600C100 RID: 49408 RVA: 0x01454F1C File Offset: 0x0145311C
			internal static bool nukAXZtA9ySTTsJEapb0()
			{
				return false;
			}

			// Token: 0x0400A43B RID: 42043
			internal int $$switch$8955$47658;

			// Token: 0x0400A43C RID: 42044
			internal GameGui $mGameGui$47659;

			// Token: 0x0400A43D RID: 42045
			internal M993_WindsAmusement $self_$47660;
		}
	}
}
