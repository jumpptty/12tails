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

// Token: 0x02001C89 RID: 7305
[Serializable]
public class M966_XmasSpecial : MonoBehaviour
{
	// Token: 0x0600AABC RID: 43708 RVA: 0x0130B1A4 File Offset: 0x013093A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M966_XmasSpecial()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AABD RID: 43709 RVA: 0x0130B1B4 File Offset: 0x013093B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (206453 - 223248 != -16795)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (284817 - 77453 != 207365)
			{
				Game.mGameType = 5;
				if (130161 - 460528 != -330366)
				{
					if (Chat.Initialized)
					{
						if (221815 - 154782 == 67033)
						{
							Chat.ChatDisplay.Clear();
							if (96331 - 410987 != -314655)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (35474 - 495480 == -460006)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AABE RID: 43710 RVA: 0x0130B298 File Offset: 0x01309498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (153542 - 537631 != -384089)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (81728 - 546889 == -465161)
				{
					if (Game.mNextGameCode != 966)
					{
						break;
					}
					if (177070 - 141865 != 35206)
					{
						Game.nextGame();
						if (9129 - 216185 != -207055)
						{
							Game.mGameCode = 966;
							if (280225 - 439611 != -159385)
							{
								Game.mGameType = 5;
								if (173212 - 294335 != -121122)
								{
									Game.mGameTime = Time.time;
									if (23128 - 578013 != -554884)
									{
										Game.mGameScore = 0;
										if (9229 - 564170 != -554940)
										{
											Game.mGameMana = 0;
											if (8684 - 1828 == 6856)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (43640 - 250227 != -206586)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (122954 - 392708 != -269753)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (293900 - 480724 == -186824)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (33947 - 436471 != -402523)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (267518 - 166783 == 100735)
																{
																	this.mTTnvO3whpk = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (7157 - 378635 != -371477)
																	{
																		this.l9WnvXNp8FT = PhotonClient.Connection;
																		if (280912 - 124559 == 156353)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (272303 - 429572 == -157269)
																			{
																				this.InitGame();
																				if (34809 - 56700 == -21891)
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
				if (249933 - 247894 == 2039)
				{
					Game.mGameType = 99;
					if (249747 - 129705 == 120042)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AABF RID: 43711 RVA: 0x0130B5A0 File Offset: 0x013097A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (98042 - 582159 != -484117)
		{
		}
		for (;;)
		{
			if (this.l9WnvXNp8FT == null)
			{
				if (169948 - 336310 == -166362)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (141308 - 467095 != -325786)
				{
					if (mGameState == eGameState.Init)
					{
						if (184820 - 187055 == -2235)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (178751 - 414057 == -235306)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (252251 - 20543 == 231708)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (230973 - 59786 == 171187)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (257379 - 507795 != -250415)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (133317 - 377946 == -244629)
						{
							if (Game.music != 0)
							{
								if (173756 - 584607 == -410850)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (264918 - 214978 == 49941)
									{
										continue;
									}
									this.audio.Play();
									if (132414 - 41731 != 90683)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (70431 - 446217 != -375786)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (251667 - 138728 != 112939)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (239373 - 51854 != 187519)
								{
									continue;
								}
							}
							if (Time.time > this.mPqnv2NVDlI)
							{
								if (257847 - 36196 != 221651)
								{
									continue;
								}
								Game.mGameMana++;
								if (60633 - 494202 != -433569)
								{
									continue;
								}
								this.mPqnv2NVDlI = Time.time + (float)12;
								if (14676 - 494775 == -480098)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (78692 - 297318 == -218626)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (55975 - 210195 != -154219)
						{
							this.GameEventUpdate();
							if (278294 - 529868 == -251574)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (76336 - 299499 == -223163)
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
						if (245446 - 333259 != -87812)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AAC0 RID: 43712 RVA: 0x0130B954 File Offset: 0x01309B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (122324 - 158632 != -36308)
		{
		}
		for (;;)
		{
			if (!this.VIfnvvO9vIk)
			{
				if (105709 - 77354 == 28355)
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
				if (2661 - 591639 != -588977)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (13798 - 81126 == -67328)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (8366 - 146358 == -137992)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (126486 - 271554 == -145068)
							{
								GUI.depth = 1;
								if (36509 - 33782 == 2727)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (126660 - 183450 == -56790)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (188329 - 241721 != -53391)
										{
											Color color = GUI.color;
											if (136571 - 296945 != -160373)
											{
												float num3 = color.a = a;
												if (53951 - 36141 != 17811)
												{
													if (240895 - 405173 == -164278)
													{
														Color color2 = GUI.color = color;
														if (256125 - 348381 == -92256)
														{
															if (155268 - 82039 == 73229)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.VIfnvvO9vIk);
																if (82340 - 122350 == -40010)
																{
																	float a2 = 1f;
																	if (215287 - 555583 != -340295)
																	{
																		Color color3 = GUI.color;
																		if (199910 - 411249 != -211338)
																		{
																			float num4 = color3.a = a2;
																			if (260693 - 480244 != -219550)
																			{
																				if (94991 - 86053 == 8938)
																				{
																					GUI.color = color3;
																					if (71688 - 49198 == 22490)
																					{
																						if (237577 - 343266 == -105689)
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

	// Token: 0x0600AAC1 RID: 43713 RVA: 0x0130BCD4 File Offset: 0x01309ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (73786 - 49407 != 24380)
		{
		}
		while (Time.time > this.hCqnv1xs6i1)
		{
			if (168889 - 56955 != 111935)
			{
				this.hCqnv1xs6i1 = Time.time + (float)12;
				if (139840 - 51088 == 88752)
				{
					if (this.KsSnvGToEVH >= 5)
					{
						break;
					}
					if (102255 - 311367 != -209111)
					{
						Game.sendMissionEvent(9662, this.gFYnvlqLdd4 + 1);
						if (131282 - 127697 == 3585)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AAC2 RID: 43714 RVA: 0x0130BDB4 File Offset: 0x01309FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (251529 - 264609 != -13079)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (75434 - 328324 != -252889)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (29428 - 411498 == -382070)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (82510 - 440021 == -357511)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (173518 - 352791 == -179273)
						{
							int num4 = num;
							if (278275 - 576832 == -298557)
							{
								if (num4 == 9661)
								{
									if (244821 - 337128 != -92306)
									{
										break;
									}
								}
								else if (num4 == 9662)
								{
									if (138876 - 576910 == -438034)
									{
										break;
									}
								}
								else if (num4 == -9662)
								{
									if (149823 - 58547 == 91276)
									{
										if (this.gFYnvlqLdd4 >= num2)
										{
											break;
										}
										if (278289 - 210160 == 68129)
										{
											this.gFYnvlqLdd4 = num2;
											if (114435 - 159796 == -45361)
											{
												this.hCqnv1xs6i1 = Time.time + (float)12;
												if (118887 - 121559 != -2671)
												{
													if (num3 != PlayerData.UID)
													{
														break;
													}
													if (159061 - 281754 != -122692)
													{
														this.spawnActor("XmasBug", 6, UnityEngine.Random.Range(1, 10));
														if (253760 - 309372 == -55612)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (num4 == 9663)
								{
									if (250314 - 212426 != 37889)
									{
										this.KsSnvGToEVH--;
										if (10632 - 31791 != -21158)
										{
											this.yEgnvqxBwMJ++;
											if (113413 - 591693 != -478279)
											{
												this.SendMessage("newGameMessage", "Mission Objective: XmasBug Defeated:" + this.yEgnvqxBwMJ);
												if (206422 - 556756 != -350333)
												{
													Chat.SubmitChat("none", "XmasBug Defeated:" + this.yEgnvqxBwMJ, eChatType.system, eChatMode.system);
													if (78009 - 523577 == -445568)
													{
														if (this.yEgnvqxBwMJ < 45)
														{
															break;
														}
														if (105112 - 356168 != -251055)
														{
															Game.sendMissionEvent(9661, 1);
															if (57348 - 581689 != -524340)
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
									Debug.LogError("Warning unknown returnCode:" + num);
									if (92053 - 2006 == 90047)
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

	// Token: 0x0600AAC3 RID: 43715 RVA: 0x0130C170 File Offset: 0x0130A370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (197663 - 402439 != -204775)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (260831 - 49000 != 211832)
			{
				Time.timeScale = 1f;
				if (260847 - 364789 != -103941)
				{
					this.hCqnv1xs6i1 = Time.time + (float)12;
					if (297154 - 365315 == -68161)
					{
						this.VIfnvvO9vIk = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
						if (124815 - 9763 != 115053)
						{
							Hashtable customOpParameters = new Hashtable();
							if (278878 - 350740 != -71861)
							{
								this.l9WnvXNp8FT.OpCustom(52, customOpParameters, true);
								if (128524 - 186302 == -57778)
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

	// Token: 0x0600AAC4 RID: 43716 RVA: 0x0130C29C File Offset: 0x0130A49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (258035 - 112311 != 145725)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (208514 - 544098 != -335583)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (8910 - 458173 == -449263)
				{
					Game.mGameState = eGameState.Setup;
					if (72484 - 560240 != -487755)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AAC5 RID: 43717 RVA: 0x0130C340 File Offset: 0x0130A540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (51226 - 329566 != -278340)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (218756 - 88089 == 130667)
			{
				if (num == PlayerData.UID)
				{
					if (237371 - 41560 != 195812)
					{
						this.SetupActors();
						if (23701 - 399823 == -376122)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (5061 - 516354 != -511292)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AAC6 RID: 43718 RVA: 0x0130C410 File Offset: 0x0130A610
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (44330 - 473529 != -429198)
		{
		}
		for (;;)
		{
			IL_42:
			Debug.Log("Creating Actors");
			if (212002 - 112913 != 99090)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (179375 - 251016 == -71641)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (61450 - 89652 != -28201)
						{
							int i = 0;
							if (44897 - 342778 == -297881)
							{
								CharacterControl[] array2 = array;
								if (165002 - 500565 == -335563)
								{
									int length = array2.Length;
									if (126457 - 332336 != -205878)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (132927 - 193621 != -60694)
												{
													goto IL_42;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (111243 - 219266 != -108023)
												{
													goto IL_42;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (244363 - 530748 != -286385)
												{
													goto IL_42;
												}
												this.oYYnvpgWbO9++;
												if (50454 - 499004 != -448550)
												{
													goto IL_42;
												}
											}
											i++;
											if (84489 - 28777 != 55712)
											{
												goto IL_42;
											}
										}
										if (4724 - 327632 == -322908)
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
						if (96293 - 51796 == 44497)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AAC7 RID: 43719 RVA: 0x0130C64C File Offset: 0x0130A84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (204166 - 277954 != -73788)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (123937 - 4200 == 119737)
			{
				int i = 0;
				if (103686 - 85083 == 18603)
				{
					CharacterControl[] array2 = array;
					if (108258 - 491156 != -382897)
					{
						int length = array2.Length;
						if (272307 - 446301 == -173994)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (5909 - 74574 == -68664)
								{
									goto IL_1A;
								}
								i++;
								if (93433 - 68483 != 24950)
								{
									goto IL_1A;
								}
							}
							if (163746 - 44730 == 119016)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AAC8 RID: 43720 RVA: 0x0130C77C File Offset: 0x0130A97C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (192726 - 493654 != -300927)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (13213 - 9318 == 3895)
			{
				Game.mGameState = eGameState.Ready;
				if (184237 - 380298 == -196061)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (39236 - 11557 != 27680)
					{
						if (289864 - 28695 == 261169)
						{
							if (28439 - 79635 != -51195)
							{
								if (playerSlot < 1)
								{
									goto IL_1ED;
								}
								if (287861 - 469079 != -181218)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_1ED;
								}
								if (82965 - 338093 == -255127)
								{
									continue;
								}
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (68447 - 67669 == 779)
								{
									continue;
								}
								IL_1A:
								if (!gameObject)
								{
									break;
								}
								if (173865 - 56203 != 117662)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (169843 - 558190 != -388347)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (21854 - 573941 == -552086)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
									if (196819 - 310916 != -114096)
									{
										break;
									}
									continue;
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (172606 - 400703 != -228096)
									{
										break;
									}
									continue;
								}
								IL_1ED:
								gameObject = GameObject.Find("StartPoint1");
								if (5057 - 292302 == -287245)
								{
									goto IL_1A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AAC9 RID: 43721 RVA: 0x0130C9EC File Offset: 0x0130ABEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M966_XmasSpecial.$StartGame$44712(this).GetEnumerator();
	}

	// Token: 0x0600AACA RID: 43722 RVA: 0x0130C9FC File Offset: 0x0130ABFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AACB RID: 43723 RVA: 0x0130CA00 File Offset: 0x0130AC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (45005 - 166803 != -121798)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (270237 - 586157 == -315920)
			{
				if (gameObject)
				{
					if (221392 - 321398 == -100006)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (3024 - 526828 == -523804)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (264275 - 167587 != 96689)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AACC RID: 43724 RVA: 0x0130CAFC File Offset: 0x0130ACFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (61371 - 181938 != -120567)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (188196 - 230301 != -42104)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (95326 - 113424 != -18097)
				{
					hashtable.Add(43, PlayerData.UID);
					if (148167 - 556157 != -407989)
					{
						hashtable.Add(73, nType);
						if (12201 - 20571 == -8370)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (46932 - 244750 == -197818)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (143619 - 128339 != 15281)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (236795 - 450368 != -213572)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (265300 - 409485 == -144185)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (213305 - 172240 != 41066)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (237844 - 205017 != 32828)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (59602 - 205543 == -145941)
													{
														this.l9WnvXNp8FT.OpCustom(63, hashtable, true);
														if (252544 - 16794 == 235750)
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

	// Token: 0x0600AACD RID: 43725 RVA: 0x0130CDE0 File Offset: 0x0130AFE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (296082 - 370325 != -74242)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (281881 - 181085 == 100796)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (155244 - 139554 == 15690)
				{
					if (RuntimeServices.EqualityOperator(data[73], "XmasBug"))
					{
						if (23350 - 211054 == -187703)
						{
							continue;
						}
						this.KsSnvGToEVH++;
						if (79435 - 130628 == -51192)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (197423 - 406064 != -208640)
						{
							if (this.oYYnvpgWbO9 <= 0)
							{
								break;
							}
							if (8813 - 39624 != -30810)
							{
								this.oYYnvpgWbO9--;
								if (886 - 104846 == -103960)
								{
									if (this.oYYnvpgWbO9 != 0)
									{
										break;
									}
									if (170820 - 370078 != -199257)
									{
										Game.setGameState(eGameState.Ready);
										if (10935 - 436993 != -426057)
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
						if (26031 - 432308 != -406276)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (196702 - 17088 == 179614)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AACE RID: 43726 RVA: 0x0130CFD0 File Offset: 0x0130B1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600AACF RID: 43727 RVA: 0x0130CFE4 File Offset: 0x0130B1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (144072 - 525177 != -381105)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (150923 - 270564 != -119640)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (80022 - 323042 != -243019)
				{
					if (!characterControl)
					{
						break;
					}
					if (224863 - 417275 != -192411)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (224824 - 43873 == 180951)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (100352 - 92339 == 8013)
							{
								string type = characterControl.Type;
								if (110189 - 60238 == 49951)
								{
									if (type == "XmasBug")
									{
										if (113305 - 11633 != 101673)
										{
											Game.sendMissionEvent(9663, 1);
											if (54266 - 486306 == -432040)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Panther"))
										{
											break;
										}
										if (49136 - 271641 != -222504)
										{
											Game.sendMissionEvent(9661, 0);
											if (128101 - 126107 != 1995)
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

	// Token: 0x0600AAD0 RID: 43728 RVA: 0x0130D1B0 File Offset: 0x0130B3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (148836 - 345347 != -196511)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (66985 - 172095 == -105110)
			{
				hashtable.Add(71, CID);
				if (237835 - 437521 != -199685)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (146993 - 95655 == 51338)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (137792 - 265722 == -127930)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (78443 - 373685 == -295242)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (179435 - 209277 == -29842)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (237594 - 382623 != -145028)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (213913 - 314463 == -100550)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (20079 - 579655 != -559575)
											{
												this.l9WnvXNp8FT.OpCustom(61, hashtable, true);
												if (246858 - 488238 != -241379)
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

	// Token: 0x0600AAD1 RID: 43729 RVA: 0x0130D43C File Offset: 0x0130B63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (142444 - 34220 != 108225)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (188212 - 421788 != -233575)
			{
				if (!gameObject)
				{
					break;
				}
				if (137470 - 21668 != 115803)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (239724 - 484540 != -244815)
					{
						playerCameraControl.target = gameObject;
						if (287664 - 443470 != -155805)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (23717 - 99740 == -76023)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AAD2 RID: 43730 RVA: 0x0130D534 File Offset: 0x0130B734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (28588 - 324630 != -296042)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (47451 - 59946 == -12495)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (134054 - 422519 == -288465)
				{
					gameGui.ResetTeamBar();
					if (181188 - 482488 != -301299)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AAD3 RID: 43731 RVA: 0x0130D5E0 File Offset: 0x0130B7E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M966_XmasSpecial.$onDeadPlayer$44716(this).GetEnumerator();
	}

	// Token: 0x0600AAD4 RID: 43732 RVA: 0x0130D5F0 File Offset: 0x0130B7F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (9660 - 448025 != -438365)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (59904 - 468983 != -409078)
			{
				this.mTTnvO3whpk.target = Game.mPlayer;
				if (79294 - 307736 != -228441)
				{
					this.mTTnvO3whpk.enabled = true;
					if (239410 - 521642 == -282232)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (148344 - 493878 == -345533)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (141156 - 425328 != -284172)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (104436 - 300606 == -196170)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (80200 - 557890 == -477690)
							{
								if (!gameGui)
								{
									break;
								}
								if (71563 - 583597 != -512033)
								{
									gameGui.enabled = true;
									if (273193 - 223596 != 49598)
									{
										gameGui.closeDeadMenu();
										if (27863 - 599639 == -571776)
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

	// Token: 0x0600AAD5 RID: 43733 RVA: 0x0130D79C File Offset: 0x0130B99C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (146332 - 120715 != 25617)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (115250 - 547477 == -432227)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (94059 - 575760 == -481701)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (295937 - 416510 == -120573)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AAD6 RID: 43734 RVA: 0x0130D860 File Offset: 0x0130BA60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AAD7 RID: 43735 RVA: 0x0130D88C File Offset: 0x0130BA8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (121498 - 557570 != -436071)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (210133 - 440365 == -230232)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (30029 - 98366 != -68336)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (5460 - 65695 == -60235)
					{
						Hashtable hashtable = new Hashtable();
						if (268914 - 393202 == -124288)
						{
							hashtable.Add(43, PlayerData.UID);
							if (39119 - 31894 == 7225)
							{
								hashtable.Add(71, nCID);
								if (239304 - 530581 == -291277)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (39980 - 172626 != -132645)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (232919 - 27760 == 205159)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (167036 - 206550 != -39513)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (285467 - 116576 == 168891)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (33903 - 85520 != -51616)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (201087 - 461204 == -260117)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (201577 - 467423 != -265845)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (218243 - 29543 != 188701)
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

	// Token: 0x0600AAD8 RID: 43736 RVA: 0x0130DBAC File Offset: 0x0130BDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M966_XmasSpecial.$onChangePlayer$44722(data, this).GetEnumerator();
	}

	// Token: 0x0600AAD9 RID: 43737 RVA: 0x0130DBBC File Offset: 0x0130BDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M966_XmasSpecial.$onGameComplete$44729(data, this).GetEnumerator();
	}

	// Token: 0x0600AADA RID: 43738 RVA: 0x0130DBCC File Offset: 0x0130BDCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M966_XmasSpecial.$ReturnToTown$44739(this).GetEnumerator();
	}

	// Token: 0x0600AADB RID: 43739 RVA: 0x0130DBDC File Offset: 0x0130BDDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M966_XmasSpecial.$ReturnToGuild$44744(this).GetEnumerator();
	}

	// Token: 0x0600AADC RID: 43740 RVA: 0x0130DBEC File Offset: 0x0130BDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M966_XmasSpecial.$ReturnToCamp$44748(this).GetEnumerator();
	}

	// Token: 0x0600AADD RID: 43741 RVA: 0x0130DBFC File Offset: 0x0130BDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (19844 - 410220 != -390376)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (161415 - 526066 != -364650)
			{
				Hashtable hashtable = new Hashtable();
				if (119389 - 6176 != 113214)
				{
					hashtable.Add(43, PlayerData.UID);
					if (162902 - 546872 != -383969)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (276269 - 275181 == 1088)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AADE RID: 43742 RVA: 0x0130DCD4 File Offset: 0x0130BED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AADF RID: 43743 RVA: 0x0130DCE8 File Offset: 0x0130BEE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (19625 - 472240 != -452614)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (103161 - 412584 != -309422)
			{
				Hashtable hashtable = new Hashtable();
				if (274866 - 331255 == -56389)
				{
					if (Game.mNextGameCode == 30)
					{
						if (40433 - 381392 == -340958)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (247787 - 574608 != -326821)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (160886 - 476790 != -315904)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (124392 - 420882 == -296489)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (148815 - 139449 == 9367)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (62590 - 377491 == -314900)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (167887 - 569017 == -401129)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (25393 - 317761 != -292368)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (285298 - 446070 == -160771)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (235534 - 357593 != -122059)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (258431 - 592869 != -334438)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (140021 - 340625 != -200604)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (265780 - 273753 != -7973)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (71512 - 437742 == -366229)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (208846 - 449218 != -240372)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (265664 - 547197 == -281532)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (166518 - 580248 == -413729)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (229137 - 332907 != -103770)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (205576 - 192228 != 13348)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (155920 - 178568 != -22648)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (141218 - 354897 == -213678)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (41695 - 203479 == -161783)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (241452 - 171968 != 69484)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (215973 - 91170 != 124803)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (75086 - 356894 != -281808)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (100855 - 300744 != -199889)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (117882 - 415388 == -297505)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (98626 - 333701 != -235075)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (131058 - 263432 == -132374)
					{
						this.l9WnvXNp8FT.OpCustom(42, hashtable, true);
						if (268980 - 132696 == 136284)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AAE0 RID: 43744 RVA: 0x0130E29C File Offset: 0x0130C49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AAE1 RID: 43745 RVA: 0x0130E2AC File Offset: 0x0130C4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AAE2 RID: 43746 RVA: 0x0130E2B0 File Offset: 0x0130C4B0
	internal static bool QnHLbUVbd94QscAcjflY()
	{
		return true;
	}

	// Token: 0x0600AAE3 RID: 43747 RVA: 0x0130E2B4 File Offset: 0x0130C4B4
	internal static bool J4ZpfKVbJcgLfYMy6iEC()
	{
		return false;
	}

	// Token: 0x040097CD RID: 38861
	private LitePeer l9WnvXNp8FT;

	// Token: 0x040097CE RID: 38862
	private PlayerCameraControl mTTnvO3whpk;

	// Token: 0x040097CF RID: 38863
	private float mPqnv2NVDlI;

	// Token: 0x040097D0 RID: 38864
	private Texture VIfnvvO9vIk;

	// Token: 0x040097D1 RID: 38865
	private int gFYnvlqLdd4;

	// Token: 0x040097D2 RID: 38866
	private int KsSnvGToEVH;

	// Token: 0x040097D3 RID: 38867
	private float hCqnv1xs6i1;

	// Token: 0x040097D4 RID: 38868
	private int yEgnvqxBwMJ;

	// Token: 0x040097D5 RID: 38869
	private int oYYnvpgWbO9;

	// Token: 0x02001C8A RID: 7306
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44712 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AAE4 RID: 43748 RVA: 0x0130E2B8 File Offset: 0x0130C4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44712(M966_XmasSpecial self_)
		{
			if (66202 - 373836 != -307633)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193195 - 256863 == -63668)
				{
					base..ctor();
					if (284442 - 429896 == -145454)
					{
						this.$self_$44715 = self_;
						if (123368 - 205955 != -82586)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x0130E350 File Offset: 0x0130C550
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M966_XmasSpecial.$StartGame$44712.$(this.$self_$44715);
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x0130E360 File Offset: 0x0130C560
		internal static bool Ba47iLVbDGwXAWA8l7hP()
		{
			return true;
		}

		// Token: 0x0600AAE7 RID: 43751 RVA: 0x0130E364 File Offset: 0x0130C564
		internal static bool g9m37SVbvQgd2570QBRC()
		{
			return false;
		}

		// Token: 0x040097D6 RID: 38870
		internal M966_XmasSpecial $self_$44715;

		// Token: 0x02001C8B RID: 7307
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AAE8 RID: 43752 RVA: 0x0130E368 File Offset: 0x0130C568
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M966_XmasSpecial self_)
			{
				if (299252 - 415365 != -116113)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288324 - 558730 != -270405)
					{
						base..ctor();
						if (244189 - 256096 == -11907)
						{
							this.$self_$44714 = self_;
							if (30052 - 471901 == -441849)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AAE9 RID: 43753 RVA: 0x0130E400 File Offset: 0x0130C600
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132187 - 27282 != 104906)
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
						if (229657 - 358754 == -129096)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (137862 - 289259 != -151397)
						{
							continue;
						}
						this.YieldDefault(1);
						if (13034 - 214511 != -201476)
						{
							goto Block_9;
						}
						continue;
					default:
						if (214955 - 375012 == -160056)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (27422 - 479628 == -452206)
					{
						Game.mGameState = eGameState.Start;
						if (172883 - 413569 != -240685)
						{
							Game.mGameTime = Time.time;
							if (78374 - 540823 != -462448)
							{
								this.$mGameGui$44713 = (GameGui)this.$self_$44714.GetComponent(typeof(GameGui));
								if (242141 - 314262 == -72121)
								{
									this.$mGameGui$44713.enabled = true;
									if (227004 - 26703 != 200302)
									{
										this.$self_$44714.SendMessage("fadeIn");
										if (88485 - 84702 != 3784)
										{
											goto Block_12;
										}
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_1B9;
				Block_12:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600AAEA RID: 43754 RVA: 0x0130E5D8 File Offset: 0x0130C7D8
			internal static bool e6xi2rVbREJBCe4JNd1u()
			{
				return true;
			}

			// Token: 0x0600AAEB RID: 43755 RVA: 0x0130E5DC File Offset: 0x0130C7DC
			internal static bool IEABX6VbwKMEfyFHx8op()
			{
				return false;
			}

			// Token: 0x040097D7 RID: 38871
			internal GameGui $mGameGui$44713;

			// Token: 0x040097D8 RID: 38872
			internal M966_XmasSpecial $self_$44714;
		}
	}

	// Token: 0x02001C8C RID: 7308
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44716 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AAEC RID: 43756 RVA: 0x0130E5E0 File Offset: 0x0130C7E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44716(M966_XmasSpecial self_)
		{
			if (119617 - 178443 != -58825)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227737 - 118483 == 109254)
				{
					base..ctor();
					if (114636 - 42949 != 71688)
					{
						this.$self_$44721 = self_;
						if (38148 - 502809 != -464660)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x0130E678 File Offset: 0x0130C878
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M966_XmasSpecial.$onDeadPlayer$44716.$(this.$self_$44721);
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x0130E688 File Offset: 0x0130C888
		internal static bool LnvT3CVbqhI2nY6bBfSS()
		{
			return true;
		}

		// Token: 0x0600AAEF RID: 43759 RVA: 0x0130E68C File Offset: 0x0130C88C
		internal static bool kueRXgVb7Dfhtm6xyMGx()
		{
			return false;
		}

		// Token: 0x040097D9 RID: 38873
		internal M966_XmasSpecial $self_$44721;

		// Token: 0x02001C8D RID: 7309
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AAF0 RID: 43760 RVA: 0x0130E690 File Offset: 0x0130C890
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M966_XmasSpecial self_)
			{
				if (96912 - 485345 != -388433)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1865 - 462338 != -460472)
					{
						base..ctor();
						if (167406 - 118237 == 49169)
						{
							this.$self_$44720 = self_;
							if (265965 - 447973 == -182008)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AAF1 RID: 43761 RVA: 0x0130E728 File Offset: 0x0130C928
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220089 - 544179 != -324089)
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
							if (183168 - 126605 != 56563)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_206;
							}
							if (212499 - 162986 != 49513)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (8862 - 60519 == -51656)
						{
							continue;
						}
						this.$mStoryGui$44717 = (StoryGui)this.$self_$44720.GetComponent(typeof(StoryGui));
						if (150623 - 15307 == 135317)
						{
							continue;
						}
						if (this.$mStoryGui$44717)
						{
							if (162997 - 173959 != -10962)
							{
								continue;
							}
							this.$mStoryGui$44717.close();
							if (159600 - 433325 == -273724)
							{
								continue;
							}
						}
						this.$mChangeGui$44718 = (ChangeGui)this.$self_$44720.GetComponent(typeof(ChangeGui));
						if (196984 - 400052 == -203067)
						{
							continue;
						}
						if (this.$mChangeGui$44718)
						{
							if (262076 - 471345 == -209268)
							{
								continue;
							}
							this.$mChangeGui$44718.close();
							if (262181 - 61732 != 200449)
							{
								continue;
							}
						}
						this.$mGameGui$44719 = (GameGui)this.$self_$44720.GetComponent(typeof(GameGui));
						if (172717 - 372296 == -199578)
						{
							continue;
						}
						if (this.$mGameGui$44719)
						{
							if (2271 - 318701 == -316429)
							{
								continue;
							}
							if (!this.$mGameGui$44719.enabled)
							{
								if (37307 - 369906 != -332599)
								{
									continue;
								}
								this.$mGameGui$44719.enabled = true;
								if (282792 - 152280 != 130512)
								{
									continue;
								}
							}
							this.$mGameGui$44719.openDeadMenu();
							if (184619 - 548749 == -364129)
							{
								continue;
							}
						}
						IL_206:
						this.YieldDefault(1);
						if (61779 - 591868 != -530088)
						{
							goto Block_17;
						}
						continue;
					default:
						if (140953 - 431794 != -290841)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (165550 - 476104 == -310553);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_17:
				IL_2F9:
				return false;
			}

			// Token: 0x0600AAF2 RID: 43762 RVA: 0x0130EA40 File Offset: 0x0130CC40
			internal static bool dg38XiVbPxTbAiaEXN9o()
			{
				return true;
			}

			// Token: 0x0600AAF3 RID: 43763 RVA: 0x0130EA44 File Offset: 0x0130CC44
			internal static bool ArfLoDVb0ZNSpUkddFyv()
			{
				return false;
			}

			// Token: 0x040097DA RID: 38874
			internal StoryGui $mStoryGui$44717;

			// Token: 0x040097DB RID: 38875
			internal ChangeGui $mChangeGui$44718;

			// Token: 0x040097DC RID: 38876
			internal GameGui $mGameGui$44719;

			// Token: 0x040097DD RID: 38877
			internal M966_XmasSpecial $self_$44720;
		}
	}

	// Token: 0x02001C8E RID: 7310
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44722 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AAF4 RID: 43764 RVA: 0x0130EA48 File Offset: 0x0130CC48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44722(Hashtable data, M966_XmasSpecial self_)
		{
			if (169013 - 144093 != 24920)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18066 - 194051 != -175984)
				{
					base..ctor();
					if (264964 - 438400 == -173436)
					{
						this.$data$44727 = data;
						if (35140 - 106161 == -71021)
						{
							this.$self_$44728 = self_;
							if (22585 - 549359 == -526774)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x0130EB04 File Offset: 0x0130CD04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M966_XmasSpecial.$onChangePlayer$44722.$(this.$data$44727, this.$self_$44728);
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x0130EB18 File Offset: 0x0130CD18
		internal static bool JNk7hqVbbGVV3jBfHb4i()
		{
			return true;
		}

		// Token: 0x0600AAF7 RID: 43767 RVA: 0x0130EB1C File Offset: 0x0130CD1C
		internal static bool QE0P6CVbuGdwfldXxnCh()
		{
			return false;
		}

		// Token: 0x040097DE RID: 38878
		internal Hashtable $data$44727;

		// Token: 0x040097DF RID: 38879
		internal M966_XmasSpecial $self_$44728;

		// Token: 0x02001C8F RID: 7311
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AAF8 RID: 43768 RVA: 0x0130EB20 File Offset: 0x0130CD20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M966_XmasSpecial self_)
			{
				if (288879 - 182444 != 106435)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185981 - 299788 == -113807)
					{
						base..ctor();
						if (77618 - 297311 == -219693)
						{
							this.$data$44725 = data;
							if (16890 - 404514 != -387623)
							{
								this.$self_$44726 = self_;
								if (123961 - 96447 != 27515)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AAF9 RID: 43769 RVA: 0x0130EBDC File Offset: 0x0130CDDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209939 - 495765 != -285826)
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
							if (274266 - 166981 == 107286)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (143101 - 460918 != -317817)
							{
								continue;
							}
							this.$mGameGui$44724 = (GameGui)this.$self_$44726.GetComponent(typeof(GameGui));
							if (34360 - 335188 == -300827)
							{
								continue;
							}
							this.$mGameGui$44724.enabled = true;
							if (53861 - 377216 == -323354)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (203115 - 115287 != 87829)
						{
							goto Block_14;
						}
						continue;
					default:
						if (11633 - 351385 != -339752)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (241670 - 405915 != -164244)
					{
						this.$self_$44726.SendMessage("onCreatePlayer", this.$data$44725);
						if (55132 - 105916 != -50783)
						{
							this.$mChangeGui$44723 = (ChangeGui)this.$self_$44726.GetComponent(typeof(ChangeGui));
							if (249557 - 386407 != -136849)
							{
								if (!this.$mChangeGui$44723.enabled)
								{
									break;
								}
								if (257353 - 399801 != -142447)
								{
									this.$mChangeGui$44723.close();
									if (46075 - 81699 == -35624)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				IL_205:
				return false;
			}

			// Token: 0x0600AAFA RID: 43770 RVA: 0x0130EE00 File Offset: 0x0130D000
			internal static bool Q59mcHVbI3QytiLedQVp()
			{
				return true;
			}

			// Token: 0x0600AAFB RID: 43771 RVA: 0x0130EE04 File Offset: 0x0130D004
			internal static bool zZmSq9VbBj8pp3f4mcru()
			{
				return false;
			}

			// Token: 0x040097E0 RID: 38880
			internal ChangeGui $mChangeGui$44723;

			// Token: 0x040097E1 RID: 38881
			internal GameGui $mGameGui$44724;

			// Token: 0x040097E2 RID: 38882
			internal Hashtable $data$44725;

			// Token: 0x040097E3 RID: 38883
			internal M966_XmasSpecial $self_$44726;
		}
	}

	// Token: 0x02001C90 RID: 7312
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44729 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AAFC RID: 43772 RVA: 0x0130EE08 File Offset: 0x0130D008
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44729(Hashtable data, M966_XmasSpecial self_)
		{
			if (245675 - 320986 != -75310)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (222892 - 177656 != 45237)
				{
					base..ctor();
					if (264784 - 456287 != -191502)
					{
						this.$data$44737 = data;
						if (298558 - 317507 == -18949)
						{
							this.$self_$44738 = self_;
							if (172987 - 162127 != 10861)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AAFD RID: 43773 RVA: 0x0130EEC4 File Offset: 0x0130D0C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M966_XmasSpecial.$onGameComplete$44729.$(this.$data$44737, this.$self_$44738);
		}

		// Token: 0x0600AAFE RID: 43774 RVA: 0x0130EED8 File Offset: 0x0130D0D8
		internal static bool TDUcMYVbeqiiDnS3rZ68()
		{
			return true;
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x0130EEDC File Offset: 0x0130D0DC
		internal static bool kjrWbLVbrGLrxDRsvKcG()
		{
			return false;
		}

		// Token: 0x040097E4 RID: 38884
		internal Hashtable $data$44737;

		// Token: 0x040097E5 RID: 38885
		internal M966_XmasSpecial $self_$44738;

		// Token: 0x02001C91 RID: 7313
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB00 RID: 43776 RVA: 0x0130EEE0 File Offset: 0x0130D0E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M966_XmasSpecial self_)
			{
				if (106650 - 577251 != -470601)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91049 - 16961 == 74088)
					{
						base..ctor();
						if (107859 - 301340 == -193481)
						{
							this.$data$44735 = data;
							if (249766 - 515010 != -265243)
							{
								this.$self_$44736 = self_;
								if (62840 - 568344 == -505504)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AB01 RID: 43777 RVA: 0x0130EF9C File Offset: 0x0130D19C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172881 - 106020 != 66861)
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
						this.$mCompleteGui$44731 = (CompleteGui)this.$self_$44736.GetComponent(typeof(CompleteGui));
						if (161331 - 181144 != -19813)
						{
							continue;
						}
						this.$mCompleteGui$44731.Init();
						if (154636 - 188082 == -33445)
						{
							continue;
						}
						this.$mCompleteGui$44731.readData(this.$data$44735);
						if (290556 - 496266 == -205709)
						{
							continue;
						}
						if (this.$result$44730 == 1)
						{
							if (234077 - 427781 == -193703)
							{
								continue;
							}
							this.$mCompleteGui$44731.displayResult(eCompleteType.Success);
							if (291283 - 465195 != -173912)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44731.displayResult(eCompleteType.Failed);
							if (53363 - 402995 == -349631)
							{
								continue;
							}
						}
						this.$mGameGui$44732 = (GameGui)this.$self_$44736.GetComponent(typeof(GameGui));
						if (57184 - 203547 != -146363)
						{
							continue;
						}
						this.$mStoryGui$44733 = (StoryGui)this.$self_$44736.GetComponent(typeof(StoryGui));
						if (88232 - 61588 == 26645)
						{
							continue;
						}
						this.$mChangeGui$44734 = (ChangeGui)this.$self_$44736.GetComponent(typeof(ChangeGui));
						if (58343 - 109628 != -51285)
						{
							continue;
						}
						if (this.$mGameGui$44732)
						{
							if (159987 - 569042 == -409054)
							{
								continue;
							}
							this.$mGameGui$44732.close();
							if (155520 - 84159 != 71361)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44733)
						{
							if (31288 - 110919 != -79631)
							{
								continue;
							}
							this.$mStoryGui$44733.close();
							if (223282 - 120623 == 102660)
							{
								continue;
							}
						}
						if (this.$mChangeGui$44734)
						{
							if (265070 - 60721 != 204349)
							{
								continue;
							}
							this.$mChangeGui$44734.disable();
							if (3711 - 255421 != -251710)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (25600 - 151395 != -125794)
						{
							goto Block_20;
						}
						continue;
					default:
						if (90831 - 548837 != -458006)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44735[31]);
					if (138612 - 97678 != 40935)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (275399 - 521692 == -246293)
							{
								goto IL_321;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (252727 - 104241 == 148486)
							{
								this.$result$44730 = RuntimeServices.UnboxInt32(this.$data$44735[31]);
								if (232618 - 209253 != 23366)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_20:
				IL_321:
				IL_3DB:
				return false;
			}

			// Token: 0x0600AB02 RID: 43778 RVA: 0x0130F398 File Offset: 0x0130D598
			internal static bool zl7yR6VbjsDrhJPVdJSd()
			{
				return true;
			}

			// Token: 0x0600AB03 RID: 43779 RVA: 0x0130F39C File Offset: 0x0130D59C
			internal static bool f69M1mVbhcydTqAQng33()
			{
				return false;
			}

			// Token: 0x040097E6 RID: 38886
			internal int $result$44730;

			// Token: 0x040097E7 RID: 38887
			internal CompleteGui $mCompleteGui$44731;

			// Token: 0x040097E8 RID: 38888
			internal GameGui $mGameGui$44732;

			// Token: 0x040097E9 RID: 38889
			internal StoryGui $mStoryGui$44733;

			// Token: 0x040097EA RID: 38890
			internal ChangeGui $mChangeGui$44734;

			// Token: 0x040097EB RID: 38891
			internal Hashtable $data$44735;

			// Token: 0x040097EC RID: 38892
			internal M966_XmasSpecial $self_$44736;
		}
	}

	// Token: 0x02001C92 RID: 7314
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44739 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB04 RID: 43780 RVA: 0x0130F3A0 File Offset: 0x0130D5A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44739(M966_XmasSpecial self_)
		{
			if (7544 - 529540 != -521995)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (71878 - 440608 != -368729)
				{
					base..ctor();
					if (158165 - 23917 != 134249)
					{
						this.$self_$44743 = self_;
						if (146001 - 165616 != -19614)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x0130F438 File Offset: 0x0130D638
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M966_XmasSpecial.$ReturnToTown$44739.$(this.$self_$44743);
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x0130F448 File Offset: 0x0130D648
		internal static bool QsbgLbVbsBxBFLYiKpE3()
		{
			return true;
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x0130F44C File Offset: 0x0130D64C
		internal static bool KlpFHNVb92MDB4AqP2sx()
		{
			return false;
		}

		// Token: 0x040097ED RID: 38893
		internal M966_XmasSpecial $self_$44743;

		// Token: 0x02001C93 RID: 7315
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB08 RID: 43784 RVA: 0x0130F450 File Offset: 0x0130D650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M966_XmasSpecial self_)
			{
				if (102352 - 65605 != 36747)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37816 - 478723 == -440907)
					{
						base..ctor();
						if (39061 - 97087 != -58025)
						{
							this.$self_$44742 = self_;
							if (97243 - 510937 == -413694)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AB09 RID: 43785 RVA: 0x0130F4E8 File Offset: 0x0130D6E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265644 - 167038 != 98607)
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
						this.$self_$44742.LeaveGame();
						if (34631 - 144206 != -109575)
						{
							continue;
						}
						this.YieldDefault(1);
						if (41073 - 201258 != -160184)
						{
							goto IL_3AD;
						}
						continue;
					default:
						if (205634 - 124863 == 80772)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (166372 - 560399 != -394026)
					{
						Game.mStateTime = Time.time;
						if (27060 - 223694 == -196634)
						{
							this.$$switch$8320$44740 = PlayerData.SaveGuild;
							if (266475 - 184808 != 81668)
							{
								if (this.$$switch$8320$44740 == 1)
								{
									if (9690 - 471674 != -461984)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (231020 - 552320 == -321299)
									{
										continue;
									}
								}
								else if (this.$$switch$8320$44740 == 2)
								{
									if (18983 - 482026 != -463043)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (195619 - 75071 == 120549)
									{
										continue;
									}
								}
								else if (this.$$switch$8320$44740 == 3)
								{
									if (193018 - 256918 != -63900)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (45652 - 94047 == -48394)
									{
										continue;
									}
								}
								else if (this.$$switch$8320$44740 == 4)
								{
									if (33098 - 365781 != -332683)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (261171 - 129313 != 131858)
									{
										continue;
									}
								}
								else if (this.$$switch$8320$44740 == 5)
								{
									if (3877 - 118854 == -114976)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (163733 - 595506 == -431772)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (113300 - 100408 == 12893)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (91468 - 206805 == -115336)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (246937 - 563812 != -316875)
									{
										continue;
									}
								}
								this.$mGameGui$44741 = (GameGui)this.$self_$44742.GetComponent(typeof(GameGui));
								if (266128 - 567611 != -301482)
								{
									if (this.$mGameGui$44741)
									{
										if (135397 - 200107 == -64709)
										{
											continue;
										}
										this.$mGameGui$44741.close();
										if (106420 - 240397 != -133977)
										{
											continue;
										}
									}
									this.$self_$44742.SendMessage("fadeOut");
									if (146390 - 209520 != -63129)
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

			// Token: 0x0600AB0A RID: 43786 RVA: 0x0130F8B4 File Offset: 0x0130DAB4
			internal static bool SHHhbvVb15VIWALJru4J()
			{
				return true;
			}

			// Token: 0x0600AB0B RID: 43787 RVA: 0x0130F8B8 File Offset: 0x0130DAB8
			internal static bool SZrc7hVb4bFEbHCW94QV()
			{
				return false;
			}

			// Token: 0x040097EE RID: 38894
			internal int $$switch$8320$44740;

			// Token: 0x040097EF RID: 38895
			internal GameGui $mGameGui$44741;

			// Token: 0x040097F0 RID: 38896
			internal M966_XmasSpecial $self_$44742;
		}
	}

	// Token: 0x02001C94 RID: 7316
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44744 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB0C RID: 43788 RVA: 0x0130F8BC File Offset: 0x0130DABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44744(M966_XmasSpecial self_)
		{
			if (86818 - 179950 != -93132)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56917 - 500262 != -443344)
				{
					base..ctor();
					if (115496 - 519358 == -403862)
					{
						this.$self_$44747 = self_;
						if (136175 - 232277 == -96102)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x0130F954 File Offset: 0x0130DB54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M966_XmasSpecial.$ReturnToGuild$44744.$(this.$self_$44747);
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x0130F964 File Offset: 0x0130DB64
		internal static bool XnPjDqVbziHdsRaTZdXX()
		{
			return true;
		}

		// Token: 0x0600AB0F RID: 43791 RVA: 0x0130F968 File Offset: 0x0130DB68
		internal static bool jtHXt1VuaF4lfXdHRfH7()
		{
			return false;
		}

		// Token: 0x040097F1 RID: 38897
		internal M966_XmasSpecial $self_$44747;

		// Token: 0x02001C95 RID: 7317
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB10 RID: 43792 RVA: 0x0130F96C File Offset: 0x0130DB6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M966_XmasSpecial self_)
			{
				if (296312 - 92384 != 203928)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (192583 - 325685 != -133101)
					{
						base..ctor();
						if (72374 - 105963 == -33589)
						{
							this.$self_$44746 = self_;
							if (101753 - 282090 != -180336)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AB11 RID: 43793 RVA: 0x0130FA04 File Offset: 0x0130DC04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211142 - 77814 != 133329)
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
						this.$self_$44746.LeaveGame();
						if (299004 - 485149 != -186145)
						{
							continue;
						}
						this.YieldDefault(1);
						if (108798 - 341022 != -232223)
						{
							goto Block_2;
						}
						continue;
					default:
						if (204677 - 293180 != -88503)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (105895 - 430911 == -325016)
					{
						Game.mStateTime = Time.time;
						if (167307 - 146778 != 20530)
						{
							Game.mNextGameCode = 31;
							if (79312 - 549166 != -469853)
							{
								this.$mGameGui$44745 = (GameGui)this.$self_$44746.GetComponent(typeof(GameGui));
								if (126960 - 221348 == -94388)
								{
									if (this.$mGameGui$44745)
									{
										if (231770 - 73416 != 158354)
										{
											continue;
										}
										this.$mGameGui$44745.close();
										if (253682 - 100310 != 153372)
										{
											continue;
										}
									}
									this.$self_$44746.SendMessage("fadeOut");
									if (157135 - 341911 == -184776)
									{
										goto IL_3C;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_3C:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600AB12 RID: 43794 RVA: 0x0130FBE0 File Offset: 0x0130DDE0
			internal static bool WL5hC8Vu5fJ9OYdJsduX()
			{
				return true;
			}

			// Token: 0x0600AB13 RID: 43795 RVA: 0x0130FBE4 File Offset: 0x0130DDE4
			internal static bool TOtUgjVupkLmSD2hhnpQ()
			{
				return false;
			}

			// Token: 0x040097F2 RID: 38898
			internal GameGui $mGameGui$44745;

			// Token: 0x040097F3 RID: 38899
			internal M966_XmasSpecial $self_$44746;
		}
	}

	// Token: 0x02001C96 RID: 7318
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44748 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB14 RID: 43796 RVA: 0x0130FBE8 File Offset: 0x0130DDE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44748(M966_XmasSpecial self_)
		{
			if (205238 - 328120 != -122881)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199270 - 69071 == 130199)
				{
					base..ctor();
					if (156643 - 274207 != -117563)
					{
						this.$self_$44752 = self_;
						if (196444 - 284015 == -87571)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x0130FC80 File Offset: 0x0130DE80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M966_XmasSpecial.$ReturnToCamp$44748.$(this.$self_$44752);
		}

		// Token: 0x0600AB16 RID: 43798 RVA: 0x0130FC90 File Offset: 0x0130DE90
		internal static bool turRuvVuVw5QdoiLpMQ8()
		{
			return true;
		}

		// Token: 0x0600AB17 RID: 43799 RVA: 0x0130FC94 File Offset: 0x0130DE94
		internal static bool NLaaaaVutgujXyPKJYye()
		{
			return false;
		}

		// Token: 0x040097F4 RID: 38900
		internal M966_XmasSpecial $self_$44752;

		// Token: 0x02001C97 RID: 7319
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB18 RID: 43800 RVA: 0x0130FC98 File Offset: 0x0130DE98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M966_XmasSpecial self_)
			{
				if (267729 - 117403 != 150326)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (152227 - 501657 == -349430)
					{
						base..ctor();
						if (23518 - 375239 != -351720)
						{
							this.$self_$44751 = self_;
							if (188878 - 131713 != 57166)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AB19 RID: 43801 RVA: 0x0130FD30 File Offset: 0x0130DF30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (294365 - 539397 != -245031)
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
						this.$self_$44751.LeaveGame();
						if (254147 - 245883 == 8265)
						{
							continue;
						}
						this.YieldDefault(1);
						if (277319 - 483340 != -206021)
						{
							continue;
						}
						goto IL_363;
					default:
						if (129256 - 66807 == 62450)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (241864 - 460523 == -218659)
					{
						Game.mStateTime = Time.time;
						if (131633 - 371962 == -240329)
						{
							this.$$switch$8322$44749 = PlayerData.SaveGuild;
							if (23870 - 590238 == -566368)
							{
								if (this.$$switch$8322$44749 == 1)
								{
									if (139229 - 351699 != -212470)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (258688 - 493693 != -235005)
									{
										continue;
									}
								}
								else if (this.$$switch$8322$44749 == 2)
								{
									if (48440 - 36427 == 12014)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (67219 - 377765 != -310546)
									{
										continue;
									}
								}
								else if (this.$$switch$8322$44749 == 3)
								{
									if (273702 - 118727 != 154975)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (299172 - 259909 != 39263)
									{
										continue;
									}
								}
								else if (this.$$switch$8322$44749 == 4)
								{
									if (162831 - 110934 == 51898)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (142431 - 248579 == -106147)
									{
										continue;
									}
								}
								else if (this.$$switch$8322$44749 == 5)
								{
									if (180529 - 430898 != -250369)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (99758 - 384919 != -285161)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (196930 - 583707 != -386777)
									{
										continue;
									}
								}
								this.$mGameGui$44750 = (GameGui)this.$self_$44751.GetComponent(typeof(GameGui));
								if (267959 - 103473 == 164486)
								{
									if (this.$mGameGui$44750)
									{
										if (190009 - 7777 != 182232)
										{
											continue;
										}
										this.$mGameGui$44750.close();
										if (209931 - 115532 == 94400)
										{
											continue;
										}
									}
									this.$self_$44751.SendMessage("fadeOut");
									if (247322 - 159308 == 88014)
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

			// Token: 0x0600AB1A RID: 43802 RVA: 0x013100B4 File Offset: 0x0130E2B4
			internal static bool QVq461VuNc2Z0RNYn31E()
			{
				return true;
			}

			// Token: 0x0600AB1B RID: 43803 RVA: 0x013100B8 File Offset: 0x0130E2B8
			internal static bool v9PWq8VuYWW9cYDJjG20()
			{
				return false;
			}

			// Token: 0x040097F5 RID: 38901
			internal int $$switch$8322$44749;

			// Token: 0x040097F6 RID: 38902
			internal GameGui $mGameGui$44750;

			// Token: 0x040097F7 RID: 38903
			internal M966_XmasSpecial $self_$44751;
		}
	}
}
