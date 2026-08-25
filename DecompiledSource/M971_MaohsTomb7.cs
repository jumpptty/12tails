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

// Token: 0x02001D3F RID: 7487
[Serializable]
public class M971_MaohsTomb7 : MonoBehaviour
{
	// Token: 0x0600AF03 RID: 44803 RVA: 0x0134398C File Offset: 0x01341B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb7()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AF04 RID: 44804 RVA: 0x0134399C File Offset: 0x01341B9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (211051 - 546025 != -334973)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (275056 - 359225 != -84168)
			{
				Game.mGameType = 5;
				if (270091 - 440621 == -170530)
				{
					if (Chat.Initialized)
					{
						if (205067 - 363806 != -158738)
						{
							Chat.ChatDisplay.Clear();
							if (145076 - 135365 == 9711)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (205742 - 430697 != -224954)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF05 RID: 44805 RVA: 0x01343A80 File Offset: 0x01341C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (161451 - 482262 != -320810)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (97497 - 580996 != -483498)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (39927 - 538794 != -498866)
					{
						if (Game.mGameStage != 7)
						{
							break;
						}
						if (295051 - 176274 != 118778)
						{
							Game.nextGame();
							if (215153 - 286440 == -71287)
							{
								Game.mGameCode = 971;
								if (23583 - 235594 == -212011)
								{
									Game.mGameType = 5;
									if (196170 - 182039 == 14131)
									{
										Game.mStateTime = Time.time;
										if (240922 - 211541 != 29382)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (55061 - 187577 != -132515)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (284114 - 148658 != 135457)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (81830 - 135793 != -53962)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (190856 - 166859 != 23998)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (72954 - 273432 == -200478)
															{
																this.UuonlmL6JF6 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (28555 - 108660 == -80105)
																{
																	this.OnQnlDCrIuA = PhotonClient.Connection;
																	if (82022 - 419125 != -337102)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (128297 - 510800 != -382502)
																		{
																			this.InitGame();
																			if (133347 - 462678 == -329331)
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
				if (161257 - 395331 == -234074)
				{
					Game.mGameType = 99;
					if (61043 - 242746 != -181702)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF06 RID: 44806 RVA: 0x01343D6C File Offset: 0x01341F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (148248 - 68367 != 79882)
		{
		}
		for (;;)
		{
			if (this.OnQnlDCrIuA == null)
			{
				if (66709 - 180837 != -114127)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (90688 - 44956 != 45733)
				{
					if (mGameState == eGameState.Init)
					{
						if (143880 - 108592 != 35289)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (193985 - 540585 != -346599)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (253851 - 138006 != 115846)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (64935 - 65274 == -339)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (267055 - 373238 != -106182)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (33474 - 541201 != -507726)
						{
							if (Game.music != 0)
							{
								if (298243 - 239423 != 58820)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (222514 - 154291 != 68223)
									{
										continue;
									}
									this.audio.Play();
									if (160582 - 144079 == 16504)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (208524 - 14770 != 193754)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (237334 - 593943 != -356609)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (249210 - 104241 != 144969)
								{
									continue;
								}
							}
							if (Time.time > this.FTbnljG9wA9)
							{
								if (21296 - 303808 != -282512)
								{
									continue;
								}
								Game.mGameMana++;
								if (164728 - 592312 == -427583)
								{
									continue;
								}
								this.FTbnljG9wA9 = Time.time + (float)12;
								if (189111 - 392681 == -203569)
								{
									continue;
								}
							}
							this.GameUpdateEvent();
							if (135180 - 107514 == 27666)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (200644 - 30846 == 169798)
						{
							this.GameUpdateEvent();
							if (193344 - 425483 == -232139)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (88367 - 26490 == 61877)
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
						if (171056 - 362653 == -191597)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF07 RID: 44807 RVA: 0x01344120 File Offset: 0x01342320
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameUpdateEvent()
	{
		if (273287 - 172241 != 101047)
		{
		}
		while (Time.time > this.M5mnlFnFkHK)
		{
			if (233398 - 331787 == -98389)
			{
				this.M5mnlFnFkHK = Time.time + (float)60;
				if (1203 - 344776 != -343572)
				{
					GameObject gameObject = GameObject.Find("Deadcamel");
					if (214991 - 300377 == -85386)
					{
						if (!gameObject)
						{
							break;
						}
						if (83505 - 219061 == -135556)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (8520 - 191552 == -183032)
							{
								if (!characterControl)
								{
									break;
								}
								if (122465 - 162724 == -40259)
								{
									if (!characterControl.isMine)
									{
										break;
									}
									if (87274 - 87784 == -510)
									{
										if (characterControl.hp <= 0)
										{
											break;
										}
										if (2563 - 307031 != -304467)
										{
											if (this.NJHnlk1d0hd >= 12)
											{
												break;
											}
											if (257916 - 376286 != -118369)
											{
												GameObject gameObject2 = GameObject.Find("SpawnPoint1");
												if (248762 - 444365 != -195602)
												{
													if (gameObject2)
													{
														if (22426 - 598391 == -575964)
														{
															continue;
														}
														this.createActor("Anubi", 7, gameObject2.transform.position, gameObject2.transform.forward);
														if (51874 - 91202 != -39328)
														{
															continue;
														}
													}
													GameObject gameObject3 = GameObject.Find("SpawnPoint2");
													if (219446 - 428794 != -209347)
													{
														if (!gameObject3)
														{
															break;
														}
														if (45016 - 324391 == -279375)
														{
															this.createActor("Anubi", 7, gameObject3.transform.position, gameObject3.transform.forward);
															if (294062 - 331646 == -37584)
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

	// Token: 0x0600AF08 RID: 44808 RVA: 0x013443C8 File Offset: 0x013425C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb7.$onGameEvent$45231(data, this).GetEnumerator();
	}

	// Token: 0x0600AF09 RID: 44809 RVA: 0x013443D8 File Offset: 0x013425D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M971_MaohsTomb7.$StartEvent$45242(this).GetEnumerator();
	}

	// Token: 0x0600AF0A RID: 44810 RVA: 0x013443E8 File Offset: 0x013425E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M971_MaohsTomb7.$EndEvent$45251(this).GetEnumerator();
	}

	// Token: 0x0600AF0B RID: 44811 RVA: 0x013443F8 File Offset: 0x013425F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (57457 - 5541 != 51917)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (128516 - 232035 == -103519)
			{
				Time.timeScale = 1f;
				if (276623 - 503925 == -227302)
				{
					this.M5mnlFnFkHK = Time.time + (float)60;
					if (54481 - 396633 == -342152)
					{
						Hashtable customOpParameters = new Hashtable();
						if (12213 - 472231 != -460017)
						{
							this.OnQnlDCrIuA.OpCustom(52, customOpParameters, true);
							if (226055 - 347219 == -121164)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF0C RID: 44812 RVA: 0x013444EC File Offset: 0x013426EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (242631 - 452821 != -210190)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (30598 - 319945 == -289347)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (194850 - 222401 == -27551)
				{
					Game.mGameState = eGameState.Setup;
					if (267598 - 261732 == 5866)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF0D RID: 44813 RVA: 0x01344590 File Offset: 0x01342790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (134283 - 78430 != 55853)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (32179 - 517512 == -485333)
			{
				if (num == PlayerData.UID)
				{
					if (128026 - 507697 != -379670)
					{
						this.SetupActors();
						if (66874 - 397263 != -330388)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (213906 - 20711 == 193195)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF0E RID: 44814 RVA: 0x01344660 File Offset: 0x01342860
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (175441 - 322850 != -147409)
		{
		}
		for (;;)
		{
			IL_2B0:
			Debug.Log("Creating Actors");
			if (21129 - 97713 == -76584)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (218787 - 355603 != -136815)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (287805 - 507285 != -219479)
						{
							int i = 0;
							if (289016 - 442428 == -153412)
							{
								CharacterControl[] array2 = array;
								if (142740 - 327768 == -185028)
								{
									int length = array2.Length;
									if (213381 - 446401 != -233019)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (30323 - 1078 != 29245)
											{
												goto IL_2B0;
											}
											if (type == "Anubi")
											{
												goto IL_1A;
											}
											if (127777 - 275349 == -147571)
											{
												goto IL_2B0;
											}
											if (type == "Deadbeagle")
											{
												goto IL_1A;
											}
											if (91119 - 251279 != -160160)
											{
												goto IL_2B0;
											}
											if (type == "Deadshund")
											{
												goto IL_1A;
											}
											if (20830 - 204370 != -183540)
											{
												goto IL_2B0;
											}
											if (type == "Deadbull")
											{
												if (73143 - 63606 != 9537)
												{
													goto IL_2B0;
												}
												goto IL_1A;
											}
											IL_288:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (60057 - 312824 != -252767)
											{
												goto IL_2B0;
											}
											this.aUsnlAlhjf8++;
											if (64146 - 582634 == -518487)
											{
												goto IL_2B0;
											}
											i++;
											if (214470 - 246267 != -31797)
											{
												goto IL_2B0;
											}
											continue;
											IL_1A:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (207425 - 518023 != -310598)
											{
												goto IL_2B0;
											}
											goto IL_288;
										}
										if (33457 - 425685 != -392227)
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
						if (164457 - 578452 != -413994)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF0F RID: 44815 RVA: 0x01344954 File Offset: 0x01342B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (70375 - 584212 != -513837)
		{
		}
		for (;;)
		{
			IL_C4:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (90040 - 68771 == 21269)
			{
				int i = 0;
				if (227972 - 83946 == 144026)
				{
					CharacterControl[] array2 = array;
					if (255057 - 187961 == 67096)
					{
						int length = array2.Length;
						if (89383 - 386709 == -297326)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (133809 - 37146 == 96664)
								{
									goto IL_C4;
								}
								i++;
								if (160353 - 305849 == -145495)
								{
									goto IL_C4;
								}
							}
							if (38781 - 15552 != 23230)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF10 RID: 44816 RVA: 0x01344A84 File Offset: 0x01342C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (16754 - 165380 != -148626)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (175537 - 589726 != -414188)
			{
				Game.mGameState = eGameState.Ready;
				if (89410 - 335529 == -246119)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (158288 - 350980 == -192692)
					{
						if (261299 - 480569 != -219269)
						{
							GameObject gameObject = null;
							if (79681 - 195776 != -116094)
							{
								if (playerSlot < 1)
								{
									goto IL_141;
								}
								if (232321 - 263026 != -30705)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_141;
								}
								if (212941 - 318973 == -106031)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (21153 - 24039 == -2885)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (219222 - 452166 == -232943)
								{
									continue;
								}
								IL_182:
								if (gameObject2)
								{
									if (47376 - 504651 == -457274)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (230243 - 301068 != -70825)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (23928 - 65567 != -41639)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (210663 - 591742 == -381078)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (108096 - 486453 == -378356)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (52325 - 374953 != -322628)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (82833 - 224843 == -142009)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (30370 - 92193 != -61822)
								{
									break;
								}
								continue;
								IL_141:
								gameObject2 = GameObject.Find("StartPoint1");
								if (243923 - 535115 == -291192)
								{
									goto IL_182;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF11 RID: 44817 RVA: 0x01344DA8 File Offset: 0x01342FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (176286 - 558162 != -381875)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (48906 - 482027 == -433121)
			{
				Game.mGameState = eGameState.Start;
				if (139418 - 307113 != -167694)
				{
					Game.mStateTime = Time.time;
					if (20523 - 385916 != -365392)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (217237 - 423958 != -206720)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF12 RID: 44818 RVA: 0x01344E70 File Offset: 0x01343070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AF13 RID: 44819 RVA: 0x01344E74 File Offset: 0x01343074
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (135485 - 493112 != -357627)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (178322 - 8617 != 169706)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (230000 - 13462 == 216538)
				{
					hashtable.Add(43, PlayerData.UID);
					if (253752 - 148870 != 104883)
					{
						hashtable.Add(73, nType);
						if (52726 - 444921 == -392195)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (34974 - 454953 == -419979)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (260087 - 5654 == 254433)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (60652 - 239387 != -178734)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (35051 - 80198 != -45146)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (166716 - 513012 != -346295)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (37558 - 414845 != -377286)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (137172 - 118913 != 18260)
													{
														this.OnQnlDCrIuA.OpCustom(63, hashtable, true);
														if (255607 - 452741 == -197134)
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

	// Token: 0x0600AF14 RID: 44820 RVA: 0x01345158 File Offset: 0x01343358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (30526 - 260055 != -229529)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (8261 - 281934 != -273672)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "Lizard"))
				{
					if (223183 - 518718 != -295535)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("Lizard");
					if (27647 - 114903 != -87256)
					{
						continue;
					}
					if (gameObject)
					{
						if (171672 - 131783 == 39890)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (276314 - 326378 == -50063)
						{
							continue;
						}
					}
				}
				if (RuntimeServices.EqualityOperator(data[73], "Deadcamel"))
				{
					if (129283 - 477285 == -348001)
					{
						continue;
					}
					GameObject gameObject2 = GameObject.Find("Deadcamel");
					if (285079 - 36270 == 248810)
					{
						continue;
					}
					if (gameObject2)
					{
						if (271752 - 113109 != 158643)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject2);
						if (110924 - 337516 != -226592)
						{
							continue;
						}
					}
				}
				GameObject gameObject3 = Game.createActor(data);
				if (110585 - 141623 == -31038)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (201689 - 68804 == 132885)
						{
							if (this.aUsnlAlhjf8 <= 0)
							{
								break;
							}
							if (83886 - 130231 != -46344)
							{
								this.aUsnlAlhjf8--;
								if (149735 - 345155 == -195420)
								{
									if (this.aUsnlAlhjf8 != 0)
									{
										break;
									}
									if (235041 - 318459 != -83417)
									{
										Game.setGameState(eGameState.Ready);
										if (180404 - 515815 != -335410)
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
						if (262793 - 577202 != -314408)
						{
							gameObject3.SendMessage("createSpecialEffect", 1);
							if (271033 - 17550 == 253483)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF15 RID: 44821 RVA: 0x01345428 File Offset: 0x01343628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600AF16 RID: 44822 RVA: 0x0134543C File Offset: 0x0134363C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (24170 - 591394 != -567224)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (261465 - 477335 == -215870)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (281765 - 520934 == -239169)
				{
					if (!characterControl)
					{
						break;
					}
					if (201256 - 524885 != -323628)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (99865 - 51640 != 48226)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (35286 - 573362 != -538075)
							{
								string type = characterControl.Type;
								if (247151 - 110064 == 137087)
								{
									if (type == "Anubi")
									{
										if (96803 - 432109 != -335306)
										{
											continue;
										}
									}
									else if (type == "Deadbeagle")
									{
										if (3999 - 322969 == -318969)
										{
											continue;
										}
									}
									else if (type == "Deadshund")
									{
										if (56196 - 231057 != -174861)
										{
											continue;
										}
									}
									else if (type == "Deadbull")
									{
										if (74363 - 417996 != -343633)
										{
											continue;
										}
									}
									else if (type == "Deadcamel")
									{
										if (99123 - 164526 != -65403)
										{
											continue;
										}
										Game.sendMissionEvent(9715, 2);
										if (16902 - 572502 != -555600)
										{
											continue;
										}
										break;
									}
									else if (type == "PharaohCat")
									{
										if (89310 - 77339 == 11972)
										{
											continue;
										}
										Game.sendMissionEvent(9715, 3);
										if (284349 - 36859 != 247490)
										{
											continue;
										}
										break;
									}
									else
									{
										if (!(type == "Lizard"))
										{
											break;
										}
										if (285173 - 95344 != 189829)
										{
											continue;
										}
										Game.sendMissionEvent(9715, 4);
										if (38118 - 61854 != -23736)
										{
											continue;
										}
										break;
									}
									IL_1FA:
									Game.sendMissionEvent(9715, 1);
									if (25784 - 334570 != -308785)
									{
										break;
									}
									continue;
									IL_21F:
									goto IL_1FA;
									goto IL_21F;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF17 RID: 44823 RVA: 0x0134573C File Offset: 0x0134393C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (71785 - 225143 != -153358)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (206392 - 301391 == -94999)
			{
				hashtable.Add(71, CID);
				if (89327 - 9447 == 79880)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (95433 - 496858 != -401424)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (234256 - 544759 == -310503)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (254769 - 108532 == 146237)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (235894 - 101048 == 134846)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (93798 - 466492 != -372693)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (129756 - 253019 != -123262)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (49478 - 318807 == -269329)
											{
												this.OnQnlDCrIuA.OpCustom(61, hashtable, true);
												if (36357 - 570262 != -533904)
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

	// Token: 0x0600AF18 RID: 44824 RVA: 0x013459C8 File Offset: 0x01343BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (143092 - 18466 != 124626)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (56630 - 368845 == -312215)
			{
				if (!gameObject)
				{
					break;
				}
				if (153043 - 100448 == 52595)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (281674 - 424103 != -142428)
					{
						playerCameraControl.target = gameObject;
						if (289454 - 528455 != -239000)
						{
							Game.loadPlayer();
							if (249207 - 76107 == 173100)
							{
								this.StartGame();
								if (286643 - 228327 != 58317)
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

	// Token: 0x0600AF19 RID: 44825 RVA: 0x01345AD8 File Offset: 0x01343CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (144312 - 429708 != -285396)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (54592 - 295703 != -241110)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (195808 - 92524 != 103285)
				{
					gameGui.ResetTeamBar();
					if (8260 - 58076 != -49815)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF1A RID: 44826 RVA: 0x01345B84 File Offset: 0x01343D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb7.$onDeadPlayer$45264(this).GetEnumerator();
	}

	// Token: 0x0600AF1B RID: 44827 RVA: 0x01345B94 File Offset: 0x01343D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (276341 - 418671 != -142329)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (157812 - 45926 == 111886)
			{
				this.UuonlmL6JF6.target = Game.mPlayer;
				if (169497 - 155401 == 14096)
				{
					this.UuonlmL6JF6.enabled = true;
					if (178041 - 66584 == 111457)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (181300 - 225652 == -44351)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (135332 - 162823 == -27490)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (202328 - 3291 != 199038)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (144342 - 555707 == -411365)
							{
								if (!gameGui)
								{
									break;
								}
								if (183854 - 433850 == -249996)
								{
									gameGui.enabled = true;
									if (192506 - 88741 == 103765)
									{
										gameGui.closeDeadMenu();
										if (260844 - 202264 != 58581)
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

	// Token: 0x0600AF1C RID: 44828 RVA: 0x01345D40 File Offset: 0x01343F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (269614 - 95963 != 173651)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (53003 - 213963 != -160959)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (91529 - 423395 == -331866)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (149698 - 539185 == -389487)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF1D RID: 44829 RVA: 0x01345E04 File Offset: 0x01344004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AF1E RID: 44830 RVA: 0x01345E30 File Offset: 0x01344030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (263058 - 140416 != 122642)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (293737 - 477024 != -183286)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (258106 - 241591 == 16515)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (275570 - 123276 == 152294)
					{
						Hashtable hashtable = new Hashtable();
						if (131054 - 446615 == -315561)
						{
							hashtable.Add(43, PlayerData.UID);
							if (168863 - 197692 != -28828)
							{
								hashtable.Add(71, nCID);
								if (210481 - 534484 == -324003)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (18392 - 223231 != -204838)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (12239 - 325009 == -312770)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (172091 - 52241 != 119851)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (232857 - 365395 == -132538)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (108839 - 132134 == -23295)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (298311 - 377732 == -79421)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (298346 - 285799 == 12547)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (97078 - 63036 == 34042)
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

	// Token: 0x0600AF1F RID: 44831 RVA: 0x01346150 File Offset: 0x01344350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb7.$onChangePlayer$45270(data, this).GetEnumerator();
	}

	// Token: 0x0600AF20 RID: 44832 RVA: 0x01346160 File Offset: 0x01344360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb7.$onGameComplete$45277(data, this).GetEnumerator();
	}

	// Token: 0x0600AF21 RID: 44833 RVA: 0x01346170 File Offset: 0x01344370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb7.$ReturnToTown$45286(this).GetEnumerator();
	}

	// Token: 0x0600AF22 RID: 44834 RVA: 0x01346180 File Offset: 0x01344380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb7.$ReturnToGuild$45291(this).GetEnumerator();
	}

	// Token: 0x0600AF23 RID: 44835 RVA: 0x01346190 File Offset: 0x01344390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb7.$ReturnToCamp$45295(this).GetEnumerator();
	}

	// Token: 0x0600AF24 RID: 44836 RVA: 0x013461A0 File Offset: 0x013443A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (294408 - 546362 != -251953)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (16355 - 85786 != -69430)
			{
				Hashtable hashtable = new Hashtable();
				if (53758 - 315557 != -261798)
				{
					hashtable.Add(43, PlayerData.UID);
					if (23 - 490908 != -490884)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (119853 - 185274 != -65420)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF25 RID: 44837 RVA: 0x01346278 File Offset: 0x01344478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AF26 RID: 44838 RVA: 0x0134628C File Offset: 0x0134448C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (31938 - 380554 != -348616)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (209100 - 375429 == -166329)
			{
				Hashtable hashtable = new Hashtable();
				if (72521 - 587227 == -514706)
				{
					if (Game.mNextGameCode == 30)
					{
						if (84741 - 225685 == -140943)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (167180 - 432300 != -265120)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (143487 - 442185 != -298698)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (86572 - 434825 != -348253)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (216963 - 563828 == -346864)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (69112 - 377929 == -308816)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (116769 - 353040 != -236271)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (46077 - 227301 != -181224)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (140219 - 517353 != -377134)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (222164 - 564518 == -342353)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (56444 - 94257 != -37813)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (235179 - 403911 == -168731)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (241440 - 286503 == -45062)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (111620 - 407079 == -295458)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (93285 - 558871 == -465585)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (187232 - 11866 == 175367)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (232338 - 275142 == -42803)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (72109 - 531413 != -459304)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (197416 - 488042 != -290626)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (249234 - 478324 != -229090)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (277090 - 169099 != 107991)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (256778 - 404040 == -147261)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (27158 - 144300 != -117142)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (242379 - 446305 != -203926)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (42398 - 186309 == -143910)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (182671 - 485403 != -302732)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (274620 - 285045 == -10424)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (11333 - 221027 == -209693)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (227447 - 348467 == -121020)
					{
						this.OnQnlDCrIuA.OpCustom(42, hashtable, true);
						if (217392 - 482527 == -265135)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF27 RID: 44839 RVA: 0x01346840 File Offset: 0x01344A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AF28 RID: 44840 RVA: 0x01346850 File Offset: 0x01344A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AF29 RID: 44841 RVA: 0x01346854 File Offset: 0x01344A54
	internal static bool KedeRBVjM1NCwx7Ln3Su()
	{
		return true;
	}

	// Token: 0x0600AF2A RID: 44842 RVA: 0x01346858 File Offset: 0x01344A58
	internal static bool LSUt1QVjxQx6gMOR2Uyb()
	{
		return false;
	}

	// Token: 0x040099F0 RID: 39408
	private LitePeer OnQnlDCrIuA;

	// Token: 0x040099F1 RID: 39409
	private PlayerCameraControl UuonlmL6JF6;

	// Token: 0x040099F2 RID: 39410
	private float FTbnljG9wA9;

	// Token: 0x040099F3 RID: 39411
	private int pYTnlol6Dp5;

	// Token: 0x040099F4 RID: 39412
	private int NJHnlk1d0hd;

	// Token: 0x040099F5 RID: 39413
	private float M5mnlFnFkHK;

	// Token: 0x040099F6 RID: 39414
	public GameObject lizard_whip;

	// Token: 0x040099F7 RID: 39415
	public AudioClip endMusic;

	// Token: 0x040099F8 RID: 39416
	private int aUsnlAlhjf8;

	// Token: 0x02001D40 RID: 7488
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45231 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF2B RID: 44843 RVA: 0x0134685C File Offset: 0x01344A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45231(Hashtable data, M971_MaohsTomb7 self_)
		{
			if (245976 - 452018 != -206041)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (291600 - 64771 != 226830)
				{
					base..ctor();
					if (145349 - 105267 != 40083)
					{
						this.$data$45240 = data;
						if (30719 - 93078 != -62358)
						{
							this.$self_$45241 = self_;
							if (125787 - 465622 != -339834)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x01346918 File Offset: 0x01344B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$onGameEvent$45231.$(this.$data$45240, this.$self_$45241);
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x0134692C File Offset: 0x01344B2C
		internal static bool iQpTtGVjgoLG13Nnx7B8()
		{
			return true;
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x01346930 File Offset: 0x01344B30
		internal static bool GIqhVjVjfiZ1i7elSCAI()
		{
			return false;
		}

		// Token: 0x040099F9 RID: 39417
		internal Hashtable $data$45240;

		// Token: 0x040099FA RID: 39418
		internal M971_MaohsTomb7 $self_$45241;

		// Token: 0x02001D41 RID: 7489
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF2F RID: 44847 RVA: 0x01346934 File Offset: 0x01344B34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb7 self_)
			{
				if (43482 - 580520 != -537038)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198887 - 212795 == -13908)
					{
						base..ctor();
						if (56600 - 87716 != -31115)
						{
							this.$data$45238 = data;
							if (193565 - 578323 != -384757)
							{
								this.$self_$45239 = self_;
								if (164368 - 154077 == 10291)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AF30 RID: 44848 RVA: 0x013469F0 File Offset: 0x01344BF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (41351 - 240555 != -199204)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_589;
					case 2:
						Game.savePlayer();
						if (258320 - 443760 == -185439)
						{
							continue;
						}
						Game.mGameStage = 8;
						if (76814 - 552733 != -475919)
						{
							continue;
						}
						Application.LoadLevel("M971_MaohsTomb8");
						if (291797 - 512989 != -221192)
						{
							continue;
						}
						goto IL_2D0;
					default:
						if (95605 - 135928 != -40323)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (256876 - 75084 != 181793)
						{
							goto Block_23;
						}
						continue;
					}
					else
					{
						this.$returnCode$45232 = RuntimeServices.UnboxInt32(this.$data$45238[141]);
						if (212556 - 574039 != -361483)
						{
							continue;
						}
						this.$returnValue$45233 = RuntimeServices.UnboxInt32(this.$data$45238[145]);
						if (119839 - 524148 != -404309)
						{
							continue;
						}
						this.$ownerID$45234 = RuntimeServices.UnboxInt32(this.$data$45238[43]);
						if (106737 - 93599 == 13139)
						{
							continue;
						}
						this.$$switch$8457$45235 = this.$returnCode$45232;
						if (207873 - 156954 != 50919)
						{
							continue;
						}
						if (this.$$switch$8457$45235 == 9711)
						{
							if (142606 - 519815 == -377208)
							{
								continue;
							}
						}
						else if (this.$$switch$8457$45235 == -9711)
						{
							if (230531 - 137695 == 92837)
							{
								continue;
							}
							if (this.$self_$45239.pYTnlol6Dp5 < 1)
							{
								if (222760 - 431387 != -208627)
								{
									continue;
								}
								this.$self_$45239.pYTnlol6Dp5 = 1;
								if (87882 - 158382 != -70500)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (297359 - 164097 != 133262)
								{
									continue;
								}
								this.$self_$45239.SendMessage("fadeOut");
								if (30831 - 69736 != -38905)
								{
									continue;
								}
								break;
							}
						}
						else if (this.$$switch$8457$45235 == 9712)
						{
							if (187112 - 242599 != -55487)
							{
								continue;
							}
						}
						else if (this.$$switch$8457$45235 == -9712)
						{
							if (205095 - 251750 != -46655)
							{
								continue;
							}
							if (this.$ownerID$45234 == PlayerData.UID)
							{
								if (202381 - 69217 == 133165)
								{
									continue;
								}
								this.$mLizard$45236 = GameObject.Find("Lizard");
								if (218331 - 334739 == -116407)
								{
									continue;
								}
								this.$mDeadcamel$45237 = GameObject.Find("Deadcamel");
								if (60400 - 566175 != -505775)
								{
									continue;
								}
								if (this.$mLizard$45236)
								{
									if (100107 - 118301 != -18194)
									{
										continue;
									}
									this.$self_$45239.createActor("Lizard", 1, this.$mLizard$45236.transform.position, this.$mLizard$45236.transform.forward);
									if (182477 - 397866 == -215388)
									{
										continue;
									}
								}
								if (this.$mDeadcamel$45237)
								{
									if (124289 - 165435 == -41145)
									{
										continue;
									}
									this.$self_$45239.createActor("Deadcamel", 7, this.$mDeadcamel$45237.transform.position, this.$mDeadcamel$45237.transform.forward);
									if (123316 - 285535 != -162219)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8457$45235 == 9713)
						{
							if (120649 - 508304 != -387655)
							{
								continue;
							}
						}
						else if (this.$$switch$8457$45235 == 9715)
						{
							if (157929 - 156659 == 1271)
							{
								continue;
							}
							if (this.$returnValue$45233 != 2)
							{
								if (136613 - 495383 != -358770)
								{
									continue;
								}
								this.$self_$45239.NJHnlk1d0hd = this.$self_$45239.NJHnlk1d0hd + 1;
								if (250928 - 149180 == 101749)
								{
									continue;
								}
							}
							else
							{
								this.$self_$45239.StartCoroutine_Auto(this.$self_$45239.EndEvent());
								if (20418 - 467585 == -447166)
								{
									continue;
								}
							}
						}
					}
					IL_33B:
					this.YieldDefault(1);
					if (187206 - 556666 != -369460)
					{
						continue;
					}
					goto IL_589;
					IL_2D0:
					goto IL_33B;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_23:
				IL_589:
				return false;
			}

			// Token: 0x0600AF31 RID: 44849 RVA: 0x01346F98 File Offset: 0x01345198
			internal static bool XagKTfVjnfP2j4SjmdgI()
			{
				return true;
			}

			// Token: 0x0600AF32 RID: 44850 RVA: 0x01346F9C File Offset: 0x0134519C
			internal static bool aWZ762Vj6jbObeTsEuJb()
			{
				return false;
			}

			// Token: 0x040099FB RID: 39419
			internal int $returnCode$45232;

			// Token: 0x040099FC RID: 39420
			internal int $returnValue$45233;

			// Token: 0x040099FD RID: 39421
			internal int $ownerID$45234;

			// Token: 0x040099FE RID: 39422
			internal int $$switch$8457$45235;

			// Token: 0x040099FF RID: 39423
			internal GameObject $mLizard$45236;

			// Token: 0x04009A00 RID: 39424
			internal GameObject $mDeadcamel$45237;

			// Token: 0x04009A01 RID: 39425
			internal Hashtable $data$45238;

			// Token: 0x04009A02 RID: 39426
			internal M971_MaohsTomb7 $self_$45239;
		}
	}

	// Token: 0x02001D42 RID: 7490
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$45242 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF33 RID: 44851 RVA: 0x01346FA0 File Offset: 0x013451A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$45242(M971_MaohsTomb7 self_)
		{
			if (57412 - 340219 != -282806)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24009 - 477207 != -453197)
				{
					base..ctor();
					if (119142 - 353145 != -234002)
					{
						this.$self_$45250 = self_;
						if (12913 - 132417 == -119504)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AF34 RID: 44852 RVA: 0x01347038 File Offset: 0x01345238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$StartEvent$45242.$(this.$self_$45250);
		}

		// Token: 0x0600AF35 RID: 44853 RVA: 0x01347048 File Offset: 0x01345248
		internal static bool gUm9t9VjivveVK5M22lv()
		{
			return true;
		}

		// Token: 0x0600AF36 RID: 44854 RVA: 0x0134704C File Offset: 0x0134524C
		internal static bool GB4EpoVjK1FhNI3BhiEW()
		{
			return false;
		}

		// Token: 0x04009A03 RID: 39427
		internal M971_MaohsTomb7 $self_$45250;

		// Token: 0x02001D43 RID: 7491
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF37 RID: 44855 RVA: 0x01347050 File Offset: 0x01345250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb7 self_)
			{
				if (126117 - 581325 != -455207)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216777 - 92030 == 124747)
					{
						base..ctor();
						if (152198 - 538150 == -385952)
						{
							this.$self_$45249 = self_;
							if (266005 - 232996 == 33009)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AF38 RID: 44856 RVA: 0x013470E8 File Offset: 0x013452E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221188 - 135577 != 85611)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_BF2;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (68089 - 357714 != -289624)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$nMessage$45247 = string.Empty;
							if (166991 - 243135 != -76144)
							{
								continue;
							}
							this.$mStoryGui$45246.startStoryMessage("none", "Deadcamel", eTalkType.enemy);
							if (130500 - 70576 != 59925)
							{
								goto Block_67;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (242418 - 151557 != 90861)
							{
								continue;
							}
							goto IL_6DF;
						}
						else
						{
							this.$nMessage$45247 = Language.getMessage("M971_MaohsTomb", 1001);
							if (128969 - 172465 != -43496)
							{
								continue;
							}
							this.$mStoryGui$45246.newStoryMessage("none", "Deadcamel", this.$nMessage$45247, eTalkType.enemy);
							if (225062 - 453230 == -228167)
							{
								continue;
							}
							this.$mStartCamera2$45248 = GameObject.Find("StartCamera2");
							if (69727 - 354765 == -285037)
							{
								continue;
							}
							if (!this.$mStartCamera2$45248)
							{
								goto IL_29D;
							}
							if (120343 - 221281 == -100937)
							{
								continue;
							}
							this.$self_$45249.UuonlmL6JF6.enabled = true;
							if (17200 - 532155 == -514954)
							{
								continue;
							}
							this.$self_$45249.UuonlmL6JF6.setSpecialTarget(this.$mStartCamera2$45248, 3f);
							if (298593 - 368366 != -69773)
							{
								continue;
							}
							goto IL_29D;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (226925 - 214288 != 12638)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$nMessage$45247 = Language.getMessage("M971_MaohsTomb", 1002);
							if (75588 - 387668 != -312080)
							{
								continue;
							}
							this.$mStoryGui$45246.newStoryMessage("Lizard", "Liza", this.$nMessage$45247, eTalkType.friend);
							if (27100 - 192648 != -165548)
							{
								continue;
							}
							goto IL_1B7;
						}
						break;
					case 5:
						if (!this.$mLizard$45243)
						{
							goto IL_660;
						}
						if (265275 - 574564 != -309289)
						{
							continue;
						}
						this.$mLizard$45243.animation.Play("nAttack");
						if (169095 - 303896 != -134800)
						{
							goto Block_73;
						}
						continue;
					case 6:
						if (!this.$self_$45249.lizard_whip)
						{
							goto IL_1F7;
						}
						if (72558 - 566730 == -494171)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$45249.lizard_whip, this.$mLizard$45243.transform.position, this.$mLizard$45243.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
						if (215241 - 524272 != -309030)
						{
							goto Block_56;
						}
						continue;
					case 7:
						if (!this.$mLizard$45243)
						{
							goto IL_2D8;
						}
						if (139511 - 375949 == -236437)
						{
							continue;
						}
						this.$mLizard$45243.animation.CrossFade("battle");
						if (79097 - 196129 != -117032)
						{
							continue;
						}
						goto IL_2D8;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (188538 - 64717 != 123821)
							{
								continue;
							}
							goto IL_90F;
						}
						else
						{
							this.$nMessage$45247 = Language.getMessage("M971_MaohsTomb", 1003);
							if (141523 - 485287 == -343763)
							{
								continue;
							}
							this.$mStoryGui$45246.newStoryMessage("Lizard", "Liza", this.$nMessage$45247, eTalkType.friend);
							if (27551 - 184646 != -157094)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (280604 - 554454 != -273850)
							{
								continue;
							}
							goto IL_8DB;
						}
						else
						{
							this.$nMessage$45247 = Language.getMessage("M971_MaohsTomb", 1004);
							if (82304 - 116577 != -34273)
							{
								continue;
							}
							this.$mStoryGui$45246.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$45247, eTalkType.friend);
							if (297069 - 236113 == 60957)
							{
								continue;
							}
							this.$self_$45249.UuonlmL6JF6.enabled = false;
							if (270308 - 538175 != -267867)
							{
								continue;
							}
							this.$self_$45249.SendMessage("alignToObject", "StartCamera3");
							if (143641 - 487740 != -344098)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (233910 - 100027 != 133883)
							{
								continue;
							}
							goto IL_409;
						}
						else
						{
							this.$nMessage$45247 = Language.getMessage("M971_MaohsTomb", 1005);
							if (67999 - 96395 == -28395)
							{
								continue;
							}
							this.$mStoryGui$45246.newStoryMessage("Lizard", "Liza", this.$nMessage$45247, eTalkType.friend);
							if (239652 - 456027 != -216374)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (126161 - 379277 != -253116)
							{
								continue;
							}
							goto IL_39E;
						}
						else
						{
							this.$nMessage$45247 = Language.getMessage("M971_MaohsTomb", 1006);
							if (256373 - 569481 != -313108)
							{
								continue;
							}
							this.$mStoryGui$45246.newStoryMessage("Lizard", "Liza", this.$nMessage$45247, eTalkType.friend);
							if (273948 - 71240 != 202708)
							{
								continue;
							}
							goto IL_B2D;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (127152 - 404842 != -277689)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45246.close();
							if (27460 - 291658 != -264198)
							{
								continue;
							}
							goto IL_33E;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.Start)
						{
							if (119078 - 11353 != 107726)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$45249.SendMessage("fadeOut");
							if (219253 - 126654 != 92599)
							{
								continue;
							}
							goto IL_977;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.Start)
						{
							if (166572 - 562549 != -395977)
							{
								continue;
							}
							goto IL_7D3;
						}
						else
						{
							this.$self_$45249.SendMessage("alignToObject", "StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (219457 - 55503 != 163954)
							{
								continue;
							}
							this.$self_$45249.SendMessage("fadeIn");
							if (120578 - 576095 != -455517)
							{
								continue;
							}
							this.$self_$45249.UuonlmL6JF6.enabled = true;
							if (103735 - 59475 != 44260)
							{
								continue;
							}
							this.$self_$45249.UuonlmL6JF6.specialTarget = null;
							if (249737 - 392104 != -142367)
							{
								continue;
							}
							goto IL_261;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.Start)
						{
							if (275441 - 526893 != -251452)
							{
								continue;
							}
							goto IL_9D8;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (164464 - 146446 == 18019)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (182209 - 394290 != -212081)
							{
								continue;
							}
							Time.timeScale = 1f;
							if (118944 - 74097 == 44848)
							{
								continue;
							}
							this.$mGameGui$45245.enabled = true;
							if (98196 - 469850 == -371653)
							{
								continue;
							}
							Game.sendMissionEvent(9712, 1);
							if (94769 - 208338 == -113568)
							{
								continue;
							}
							this.YieldDefault(1);
							if (97363 - 579671 != -482307)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					default:
						if (296364 - 439520 != -143156)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Event");
					if (252617 - 10620 != 241998)
					{
						this.$mLizard$45243 = GameObject.Find("Lizard");
						if (90823 - 43145 == 47678)
						{
							this.$mDeadcamel$45244 = GameObject.Find("Deadcamel");
							if (288137 - 448171 != -160033)
							{
								this.$mGameGui$45245 = (GameGui)this.$self_$45249.GetComponent(typeof(GameGui));
								if (269487 - 51293 == 218194)
								{
									this.$mStoryGui$45246 = (StoryGui)this.$self_$45249.GetComponent(typeof(StoryGui));
									if (240828 - 361984 != -121155)
									{
										this.$self_$45249.UuonlmL6JF6.enabled = false;
										if (9616 - 477071 == -467455)
										{
											this.$self_$45249.SendMessage("alignToObject", "StartCamera1");
											if (82027 - 545823 == -463796)
											{
												this.$self_$45249.SendMessage("fadeIn");
												if (104440 - 538175 != -433734)
												{
													goto Block_43;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_9:
				goto IL_BF2;
				Block_10:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_1B7:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_1F7:
				return this.Yield(7, new WaitForSeconds(0.7f));
				IL_261:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_29D:
				return this.Yield(4, new WaitForSeconds(2f));
				Block_21:
				goto IL_BF2;
				IL_2D8:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_33E:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_26:
				IL_39E:
				goto IL_BF2;
				Block_29:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_409:
				Block_37:
				goto IL_BF2;
				Block_43:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_660:
				return this.Yield(6, new WaitForSeconds(0.3f));
				IL_6DF:
				IL_7D3:
				goto IL_BF2;
				Block_56:
				goto IL_1F7;
				IL_8DB:
				IL_90F:
				goto IL_BF2;
				IL_977:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_9D8:
				goto IL_BF2;
				Block_67:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_B2D:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_72:
				goto IL_BF2;
				Block_73:
				goto IL_660;
				IL_BF2:
				return false;
			}

			// Token: 0x0600AF39 RID: 44857 RVA: 0x01347CFC File Offset: 0x01345EFC
			internal static bool OxacveVjdM3Ujgwim8yy()
			{
				return true;
			}

			// Token: 0x0600AF3A RID: 44858 RVA: 0x01347D00 File Offset: 0x01345F00
			internal static bool h1bqAqVjJMZowZHHeQDe()
			{
				return false;
			}

			// Token: 0x04009A04 RID: 39428
			internal GameObject $mLizard$45243;

			// Token: 0x04009A05 RID: 39429
			internal GameObject $mDeadcamel$45244;

			// Token: 0x04009A06 RID: 39430
			internal GameGui $mGameGui$45245;

			// Token: 0x04009A07 RID: 39431
			internal StoryGui $mStoryGui$45246;

			// Token: 0x04009A08 RID: 39432
			internal string $nMessage$45247;

			// Token: 0x04009A09 RID: 39433
			internal GameObject $mStartCamera2$45248;

			// Token: 0x04009A0A RID: 39434
			internal M971_MaohsTomb7 $self_$45249;
		}
	}

	// Token: 0x02001D44 RID: 7492
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$45251 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF3B RID: 44859 RVA: 0x01347D04 File Offset: 0x01345F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$45251(M971_MaohsTomb7 self_)
		{
			if (162530 - 162582 != -51)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (89777 - 179008 != -89230)
				{
					base..ctor();
					if (22906 - 448120 == -425214)
					{
						this.$self_$45263 = self_;
						if (62831 - 164290 == -101459)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AF3C RID: 44860 RVA: 0x01347D9C File Offset: 0x01345F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$EndEvent$45251.$(this.$self_$45263);
		}

		// Token: 0x0600AF3D RID: 44861 RVA: 0x01347DAC File Offset: 0x01345FAC
		internal static bool cq1GIQVjD4VoE823Er58()
		{
			return true;
		}

		// Token: 0x0600AF3E RID: 44862 RVA: 0x01347DB0 File Offset: 0x01345FB0
		internal static bool VcBZkfVjvZxiaKcxy1Q9()
		{
			return false;
		}

		// Token: 0x04009A0B RID: 39435
		internal M971_MaohsTomb7 $self_$45263;

		// Token: 0x02001D45 RID: 7493
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF3F RID: 44863 RVA: 0x01347DB4 File Offset: 0x01345FB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb7 self_)
			{
				if (188367 - 164119 != 24249)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106979 - 41687 != 65293)
					{
						base..ctor();
						if (163818 - 303720 != -139901)
						{
							this.$self_$45262 = self_;
							if (224684 - 228817 == -4133)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AF40 RID: 44864 RVA: 0x01347E4C File Offset: 0x0134604C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (116366 - 544641 != -428275)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_DB3;
					case 1:
						goto IL_E12;
					case 2:
						this.$self_$45262.UuonlmL6JF6.enabled = false;
						if (172458 - 137806 != 34652)
						{
							continue;
						}
						this.$mGameGui$45252.close();
						if (86071 - 326826 != -240755)
						{
							continue;
						}
						goto IL_8B4;
					case 3:
						this.$self_$45262.SendMessage("fadeOut");
						if (174149 - 171522 != 2627)
						{
							continue;
						}
						goto IL_CD7;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (35397 - 206091 != -170693)
							{
								goto Block_87;
							}
							continue;
						}
						else
						{
							this.$mPlayer$45254 = Game.mPlayer;
							if (11148 - 421263 == -410114)
							{
								continue;
							}
							this.$mSpawnPoint$45255 = GameObject.Find("SpawnPoint" + (Game.getPlayerSlot(PlayerData.UID) + 4));
							if (70578 - 110847 != -40269)
							{
								continue;
							}
							if (this.$mPlayer$45254)
							{
								if (296492 - 41279 == 255214)
								{
									continue;
								}
								if (this.$mSpawnPoint$45255)
								{
									if (227772 - 115690 == 112083)
									{
										continue;
									}
									this.$mPlayer$45254.transform.position = this.$mSpawnPoint$45255.transform.position;
									if (150136 - 409589 != -259453)
									{
										continue;
									}
									this.$mPlayer$45254.transform.rotation = this.$mSpawnPoint$45255.transform.rotation;
									if (136312 - 59938 == 76375)
									{
										continue;
									}
									this.$mPlayer$45254.SendMessage("PositionEvent");
									if (245848 - 102030 != 143818)
									{
										continue;
									}
								}
							}
							this.$mLizard$45256 = GameObject.Find("Lizard");
							if (253327 - 213458 != 39869)
							{
								continue;
							}
							this.$mSpawnPoint3$45257 = GameObject.Find("SpawnPoint3");
							if (279335 - 204595 == 74741)
							{
								continue;
							}
							if (this.$mLizard$45256)
							{
								if (52022 - 107770 != -55748)
								{
									continue;
								}
								if (this.$mSpawnPoint3$45257)
								{
									if (120338 - 260901 == -140562)
									{
										continue;
									}
									this.$mLizard$45256.transform.position = this.$mSpawnPoint3$45257.transform.position;
									if (281099 - 24741 != 256358)
									{
										continue;
									}
									this.$mLizard$45256.transform.rotation = this.$mSpawnPoint3$45257.transform.rotation;
									if (101576 - 153140 != -51564)
									{
										continue;
									}
									this.$mLizard$45256.animation.Rewind();
									if (7244 - 146976 == -139731)
									{
										continue;
									}
									this.$mLizard$45256.animation.Play("ko");
									if (11372 - 286576 != -275204)
									{
										continue;
									}
									this.$mLizard$45256.animation.wrapMode = WrapMode.Once;
									if (202011 - 18142 != 183869)
									{
										continue;
									}
								}
							}
							this.$mDeadcamel$45258 = GameObject.Find("Deadcamel");
							if (131211 - 494681 == -363469)
							{
								continue;
							}
							this.$mSpawnPoint4$45259 = GameObject.Find("SpawnPoint4");
							if (266522 - 114361 == 152162)
							{
								continue;
							}
							if (this.$mDeadcamel$45258)
							{
								if (282365 - 237200 == 45166)
								{
									continue;
								}
								if (this.$mSpawnPoint4$45259)
								{
									if (120779 - 23832 == 96948)
									{
										continue;
									}
									this.$mDeadcamel$45258.transform.position = this.$mSpawnPoint4$45259.transform.position;
									if (115819 - 302143 != -186324)
									{
										continue;
									}
									this.$mDeadcamel$45258.transform.rotation = this.$mSpawnPoint4$45259.transform.rotation;
									if (60182 - 584456 != -524274)
									{
										continue;
									}
								}
							}
							this.$mEndCamera1$45260 = GameObject.Find("EndCamera1");
							if (199721 - 154114 == 45608)
							{
								continue;
							}
							if (this.$mEndCamera1$45260)
							{
								if (256493 - 73244 == 183250)
								{
									continue;
								}
								this.$self_$45262.UuonlmL6JF6.enabled = false;
								if (224448 - 363392 == -138943)
								{
									continue;
								}
								Camera.main.transform.position = this.$mEndCamera1$45260.transform.position;
								if (145924 - 581901 != -435977)
								{
									continue;
								}
								Camera.main.transform.rotation = this.$mEndCamera1$45260.transform.rotation;
								if (103659 - 20889 == 82771)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find mEndCamera1");
								if (153288 - 297470 != -144182)
								{
									continue;
								}
							}
							if (!this.$self_$45262.endMusic)
							{
								goto IL_45;
							}
							if (176571 - 243237 == -66665)
							{
								continue;
							}
							this.$self_$45262.audio.clip = this.$self_$45262.endMusic;
							if (179826 - 252562 == -72735)
							{
								continue;
							}
							this.$self_$45262.audio.Play();
							if (190815 - 388172 != -197356)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (196890 - 398400 != -201510)
							{
								continue;
							}
							goto IL_193;
						}
						else
						{
							this.$self_$45262.SendMessage("fadeIn");
							if (299276 - 180585 != 118691)
							{
								continue;
							}
							this.$nMessage$45261 = string.Empty;
							if (165404 - 291172 == -125767)
							{
								continue;
							}
							this.$mStoryGui$45253.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (208877 - 51862 != 157016)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (185205 - 518458 != -333253)
							{
								continue;
							}
							goto IL_B42;
						}
						else
						{
							this.$nMessage$45261 = Language.getMessage("M971_MaohsTomb", 2001);
							if (252006 - 69399 != 182607)
							{
								continue;
							}
							this.$mStoryGui$45253.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$45261, eTalkType.friend);
							if (118216 - 560017 != -441800)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (221406 - 524432 != -303025)
							{
								goto Block_93;
							}
							continue;
						}
						else
						{
							this.$nMessage$45261 = Language.getMessage("M971_MaohsTomb", 2002);
							if (169128 - 211082 != -41954)
							{
								continue;
							}
							this.$mStoryGui$45253.newStoryMessage("Lizard", "Liza", this.$nMessage$45261, eTalkType.friend);
							if (166916 - 328027 != -161111)
							{
								continue;
							}
							goto IL_5ED;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (247939 - 75866 != 172073)
							{
								continue;
							}
							goto IL_930;
						}
						else
						{
							this.$nMessage$45261 = Language.getMessage("M971_MaohsTomb", 2003);
							if (234904 - 308657 == -73752)
							{
								continue;
							}
							this.$mStoryGui$45253.newStoryMessage("Lizard", "Liza", this.$nMessage$45261, eTalkType.friend);
							if (88391 - 66472 != 21920)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212884 - 347443 != -134558)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$nMessage$45261 = Language.getMessage("M971_MaohsTomb", 2004);
							if (112968 - 367607 == -254638)
							{
								continue;
							}
							this.$mStoryGui$45253.newStoryMessage("Lizard", "Liza", this.$nMessage$45261, eTalkType.friend);
							if (151566 - 494160 != -342594)
							{
								continue;
							}
							goto IL_8F4;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (271129 - 497779 != -226650)
							{
								continue;
							}
							goto IL_400;
						}
						else
						{
							this.$nMessage$45261 = Language.getMessage("M971_MaohsTomb", 2005);
							if (256835 - 499105 != -242270)
							{
								continue;
							}
							this.$mStoryGui$45253.newStoryMessage("Lizard", "Liza", this.$nMessage$45261, eTalkType.friend);
							if (227014 - 183914 != 43101)
							{
								goto Block_88;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (10985 - 21757 != -10771)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$nMessage$45261 = Language.getMessage("M971_MaohsTomb", 2006);
							if (160230 - 299401 != -139171)
							{
								continue;
							}
							this.$mStoryGui$45253.newStoryMessage("Lizard", "Liza", this.$nMessage$45261, eTalkType.friend);
							if (225198 - 371781 != -146582)
							{
								goto Block_77;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (64443 - 404641 != -340197)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45253.close();
							if (68993 - 533089 != -464095)
							{
								goto Block_80;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState == eGameState.AllHold)
						{
							goto IL_5B1;
						}
						if (181129 - 220884 != -39754)
						{
							goto Block_67;
						}
						continue;
					case 14:
						Game.sendMissionEvent(9711, 8);
						if (267750 - 592473 == -324722)
						{
							continue;
						}
						break;
					default:
						if (224474 - 433400 != -208925)
						{
							goto IL_DB3;
						}
						continue;
					}
					IL_CB5:
					this.YieldDefault(1);
					if (260865 - 533217 != -272351)
					{
						goto Block_85;
					}
					continue;
					IL_DB3:
					Debug.Log("EndEvent");
					if (26863 - 453426 != -426562)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (849 - 274429 != -273579)
							{
								goto Block_8;
							}
						}
						else
						{
							this.$mGameGui$45252 = (GameGui)this.$self_$45262.GetComponent(typeof(GameGui));
							if (83496 - 323562 != -240065)
							{
								this.$mStoryGui$45253 = (StoryGui)this.$self_$45262.GetComponent(typeof(StoryGui));
								if (167651 - 469094 != -301442)
								{
									if (!this.$mGameGui$45252)
									{
										goto IL_CB5;
									}
									if (135144 - 294428 != -159283)
									{
										if (!this.$mStoryGui$45253)
										{
											goto IL_CB5;
										}
										if (202596 - 169759 == 32837)
										{
											Game.mGameState = eGameState.AllHold;
											if (41095 - 304213 == -263118)
											{
												goto IL_7D3;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_45:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_8:
				IL_193:
				Block_19:
				goto IL_E12;
				Block_23:
				goto IL_45;
				IL_400:
				goto IL_E12;
				Block_35:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_36:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_5B1:
				return this.Yield(14, new WaitForSeconds(1f));
				IL_5ED:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_50:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_7D3:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_57:
				goto IL_E12;
				IL_8B4:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_8F4:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_930:
				Block_67:
				Block_72:
				IL_B42:
				goto IL_E12;
				Block_77:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_80:
				return this.Yield(13, new WaitForSeconds(1f));
				Block_85:
				goto IL_E12;
				IL_CD7:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_87:
				goto IL_E12;
				Block_88:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_93:
				IL_E12:
				return false;
			}

			// Token: 0x0600AF41 RID: 44865 RVA: 0x01348C80 File Offset: 0x01346E80
			internal static bool JaVQrbVjRMikSJprq0OE()
			{
				return true;
			}

			// Token: 0x0600AF42 RID: 44866 RVA: 0x01348C84 File Offset: 0x01346E84
			internal static bool VXXP7XVjwrSCYIt3u4Na()
			{
				return false;
			}

			// Token: 0x04009A0C RID: 39436
			internal GameGui $mGameGui$45252;

			// Token: 0x04009A0D RID: 39437
			internal StoryGui $mStoryGui$45253;

			// Token: 0x04009A0E RID: 39438
			internal GameObject $mPlayer$45254;

			// Token: 0x04009A0F RID: 39439
			internal GameObject $mSpawnPoint$45255;

			// Token: 0x04009A10 RID: 39440
			internal GameObject $mLizard$45256;

			// Token: 0x04009A11 RID: 39441
			internal GameObject $mSpawnPoint3$45257;

			// Token: 0x04009A12 RID: 39442
			internal GameObject $mDeadcamel$45258;

			// Token: 0x04009A13 RID: 39443
			internal GameObject $mSpawnPoint4$45259;

			// Token: 0x04009A14 RID: 39444
			internal GameObject $mEndCamera1$45260;

			// Token: 0x04009A15 RID: 39445
			internal string $nMessage$45261;

			// Token: 0x04009A16 RID: 39446
			internal M971_MaohsTomb7 $self_$45262;
		}
	}

	// Token: 0x02001D46 RID: 7494
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45264 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF43 RID: 44867 RVA: 0x01348C88 File Offset: 0x01346E88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45264(M971_MaohsTomb7 self_)
		{
			if (26501 - 425550 != -399048)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287042 - 20414 == 266628)
				{
					base..ctor();
					if (216921 - 468282 != -251360)
					{
						this.$self_$45269 = self_;
						if (51141 - 172805 != -121663)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AF44 RID: 44868 RVA: 0x01348D20 File Offset: 0x01346F20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$onDeadPlayer$45264.$(this.$self_$45269);
		}

		// Token: 0x0600AF45 RID: 44869 RVA: 0x01348D30 File Offset: 0x01346F30
		internal static bool uymc3gVjq8g0Q3kmGUTX()
		{
			return true;
		}

		// Token: 0x0600AF46 RID: 44870 RVA: 0x01348D34 File Offset: 0x01346F34
		internal static bool OCQKl2Vj7DrgNEKx2vHZ()
		{
			return false;
		}

		// Token: 0x04009A17 RID: 39447
		internal M971_MaohsTomb7 $self_$45269;

		// Token: 0x02001D47 RID: 7495
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF47 RID: 44871 RVA: 0x01348D38 File Offset: 0x01346F38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb7 self_)
			{
				if (71502 - 360516 != -289014)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (81816 - 243535 != -161718)
					{
						base..ctor();
						if (66279 - 572832 != -506552)
						{
							this.$self_$45268 = self_;
							if (96596 - 46002 == 50594)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AF48 RID: 44872 RVA: 0x01348DD0 File Offset: 0x01346FD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (244074 - 57775 != 186300)
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
							if (224836 - 153254 == 71583)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_283;
							}
							if (73106 - 231823 != -158717)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (269074 - 471995 == -202920)
						{
							continue;
						}
						this.$mStoryGui$45265 = (StoryGui)this.$self_$45268.GetComponent(typeof(StoryGui));
						if (93415 - 177615 != -84200)
						{
							continue;
						}
						if (this.$mStoryGui$45265)
						{
							if (299040 - 16041 != 282999)
							{
								continue;
							}
							this.$mStoryGui$45265.close();
							if (117953 - 546481 == -428527)
							{
								continue;
							}
						}
						this.$mChangeGui$45266 = (ChangeGui)this.$self_$45268.GetComponent(typeof(ChangeGui));
						if (180673 - 460975 == -280301)
						{
							continue;
						}
						if (this.$mChangeGui$45266)
						{
							if (55233 - 494114 == -438880)
							{
								continue;
							}
							this.$mChangeGui$45266.close();
							if (39759 - 2800 == 36960)
							{
								continue;
							}
						}
						this.$mGameGui$45267 = (GameGui)this.$self_$45268.GetComponent(typeof(GameGui));
						if (68960 - 277539 == -208578)
						{
							continue;
						}
						if (this.$mGameGui$45267)
						{
							if (226239 - 148994 != 77245)
							{
								continue;
							}
							if (!this.$mGameGui$45267.enabled)
							{
								if (101540 - 533336 == -431795)
								{
									continue;
								}
								this.$mGameGui$45267.enabled = true;
								if (274541 - 345360 == -70818)
								{
									continue;
								}
							}
							this.$mGameGui$45267.openDeadMenu();
							if (70093 - 537854 == -467760)
							{
								continue;
							}
						}
						IL_283:
						this.YieldDefault(1);
						if (143968 - 450919 != -306951)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (95619 - 430132 != -334513)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (102196 - 460846 != -358650);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600AF49 RID: 44873 RVA: 0x013490E8 File Offset: 0x013472E8
			internal static bool U8X2iLVjPSbkXBsIE5Ub()
			{
				return true;
			}

			// Token: 0x0600AF4A RID: 44874 RVA: 0x013490EC File Offset: 0x013472EC
			internal static bool fU5R4YVj0D9QXrC4LTsL()
			{
				return false;
			}

			// Token: 0x04009A18 RID: 39448
			internal StoryGui $mStoryGui$45265;

			// Token: 0x04009A19 RID: 39449
			internal ChangeGui $mChangeGui$45266;

			// Token: 0x04009A1A RID: 39450
			internal GameGui $mGameGui$45267;

			// Token: 0x04009A1B RID: 39451
			internal M971_MaohsTomb7 $self_$45268;
		}
	}

	// Token: 0x02001D48 RID: 7496
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45270 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF4B RID: 44875 RVA: 0x013490F0 File Offset: 0x013472F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45270(Hashtable data, M971_MaohsTomb7 self_)
		{
			if (106591 - 73634 != 32958)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (257043 - 97634 != 159410)
				{
					base..ctor();
					if (191667 - 464805 != -273137)
					{
						this.$data$45275 = data;
						if (129907 - 448158 == -318251)
						{
							this.$self_$45276 = self_;
							if (186934 - 88607 == 98327)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AF4C RID: 44876 RVA: 0x013491AC File Offset: 0x013473AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$onChangePlayer$45270.$(this.$data$45275, this.$self_$45276);
		}

		// Token: 0x0600AF4D RID: 44877 RVA: 0x013491C0 File Offset: 0x013473C0
		internal static bool vnwHyiVjbMUJjjd8e9Dp()
		{
			return true;
		}

		// Token: 0x0600AF4E RID: 44878 RVA: 0x013491C4 File Offset: 0x013473C4
		internal static bool cpRYJsVjuy5IVk6idYMp()
		{
			return false;
		}

		// Token: 0x04009A1C RID: 39452
		internal Hashtable $data$45275;

		// Token: 0x04009A1D RID: 39453
		internal M971_MaohsTomb7 $self_$45276;

		// Token: 0x02001D49 RID: 7497
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF4F RID: 44879 RVA: 0x013491C8 File Offset: 0x013473C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb7 self_)
			{
				if (192413 - 60547 != 131867)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286155 - 515544 == -229389)
					{
						base..ctor();
						if (227580 - 177775 != 49806)
						{
							this.$data$45273 = data;
							if (75298 - 71186 != 4113)
							{
								this.$self_$45274 = self_;
								if (299368 - 428098 == -128730)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AF50 RID: 44880 RVA: 0x01349284 File Offset: 0x01347484
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (143317 - 530734 != -387417)
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
							if (277180 - 440975 != -163795)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (98841 - 303078 != -204237)
							{
								continue;
							}
							this.$mGameGui$45272 = (GameGui)this.$self_$45274.GetComponent(typeof(GameGui));
							if (129220 - 585878 == -456657)
							{
								continue;
							}
							this.$mGameGui$45272.enabled = true;
							if (8427 - 180093 != -171666)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (18041 - 336841 != -318799)
						{
							goto Block_2;
						}
						continue;
					default:
						if (215765 - 384131 == -168365)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (277370 - 376516 == -99146)
					{
						this.$self_$45274.SendMessage("onCreatePlayer", this.$data$45273);
						if (294124 - 348604 != -54479)
						{
							this.$mChangeGui$45271 = (ChangeGui)this.$self_$45274.GetComponent(typeof(ChangeGui));
							if (204770 - 428774 != -224003)
							{
								if (!this.$mChangeGui$45271.enabled)
								{
									goto IL_5C;
								}
								if (287325 - 443503 == -156178)
								{
									this.$mChangeGui$45271.close();
									if (63486 - 438497 == -375011)
									{
										goto IL_5C;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_205;
				IL_5C:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600AF51 RID: 44881 RVA: 0x013494A8 File Offset: 0x013476A8
			internal static bool obrLCFVjIPZf5gojq73w()
			{
				return true;
			}

			// Token: 0x0600AF52 RID: 44882 RVA: 0x013494AC File Offset: 0x013476AC
			internal static bool jxPHjuVjBTYdn30KTYeo()
			{
				return false;
			}

			// Token: 0x04009A1E RID: 39454
			internal ChangeGui $mChangeGui$45271;

			// Token: 0x04009A1F RID: 39455
			internal GameGui $mGameGui$45272;

			// Token: 0x04009A20 RID: 39456
			internal Hashtable $data$45273;

			// Token: 0x04009A21 RID: 39457
			internal M971_MaohsTomb7 $self_$45274;
		}
	}

	// Token: 0x02001D4A RID: 7498
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45277 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF53 RID: 44883 RVA: 0x013494B0 File Offset: 0x013476B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45277(Hashtable data, M971_MaohsTomb7 self_)
		{
			if (164124 - 232739 != -68614)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (183906 - 292981 == -109075)
				{
					base..ctor();
					if (263179 - 11099 != 252081)
					{
						this.$data$45284 = data;
						if (255834 - 360054 != -104219)
						{
							this.$self_$45285 = self_;
							if (42353 - 302712 != -260358)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AF54 RID: 44884 RVA: 0x0134956C File Offset: 0x0134776C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$onGameComplete$45277.$(this.$data$45284, this.$self_$45285);
		}

		// Token: 0x0600AF55 RID: 44885 RVA: 0x01349580 File Offset: 0x01347780
		internal static bool HHvvAJVjePGyAbX4MHay()
		{
			return true;
		}

		// Token: 0x0600AF56 RID: 44886 RVA: 0x01349584 File Offset: 0x01347784
		internal static bool DsXF4JVjrFsRyiRPKbpN()
		{
			return false;
		}

		// Token: 0x04009A22 RID: 39458
		internal Hashtable $data$45284;

		// Token: 0x04009A23 RID: 39459
		internal M971_MaohsTomb7 $self_$45285;

		// Token: 0x02001D4B RID: 7499
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF57 RID: 44887 RVA: 0x01349588 File Offset: 0x01347788
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb7 self_)
			{
				if (150308 - 475714 != -325405)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (72462 - 392352 == -319890)
					{
						base..ctor();
						if (67693 - 402069 == -334376)
						{
							this.$data$45282 = data;
							if (48825 - 34576 != 14250)
							{
								this.$self_$45283 = self_;
								if (247723 - 401759 == -154036)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AF58 RID: 44888 RVA: 0x01349644 File Offset: 0x01347844
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (102516 - 58530 != 43987)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_352;
					case 2:
						this.$mCompleteGui$45279 = (CompleteGui)this.$self_$45283.GetComponent(typeof(CompleteGui));
						if (118034 - 63843 == 54192)
						{
							continue;
						}
						this.$mCompleteGui$45279.Init();
						if (152696 - 108614 != 44082)
						{
							continue;
						}
						this.$mCompleteGui$45279.readData(this.$data$45282);
						if (135250 - 360523 != -225273)
						{
							continue;
						}
						if (this.$result$45278 == 1)
						{
							if (40748 - 71550 == -30801)
							{
								continue;
							}
							this.$mCompleteGui$45279.displayResult(eCompleteType.Success);
							if (188468 - 409742 == -221273)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45279.displayResult(eCompleteType.Failed);
							if (262495 - 531445 != -268950)
							{
								continue;
							}
						}
						this.$mGameGui$45280 = (GameGui)this.$self_$45283.GetComponent(typeof(GameGui));
						if (163826 - 384152 != -220326)
						{
							continue;
						}
						this.$mStoryGui$45281 = (StoryGui)this.$self_$45283.GetComponent(typeof(StoryGui));
						if (236219 - 76235 == 159985)
						{
							continue;
						}
						if (this.$mGameGui$45280)
						{
							if (292315 - 390907 != -98592)
							{
								continue;
							}
							this.$mGameGui$45280.close();
							if (72051 - 185314 != -113263)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45281)
						{
							if (166477 - 256930 != -90453)
							{
								continue;
							}
							this.$mStoryGui$45281.close();
							if (68908 - 471382 != -402474)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (38451 - 263529 != -225077)
						{
							goto Block_22;
						}
						continue;
					default:
						if (132144 - 599063 != -466919)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45282[31]);
					if (170160 - 588167 != -418006)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (228489 - 569149 == -340660)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (98110 - 157894 == -59784)
							{
								this.$result$45278 = RuntimeServices.UnboxInt32(this.$data$45282[31]);
								if (59077 - 388280 != -329202)
								{
									goto Block_8;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_8:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_22:
				IL_352:
				return false;
			}

			// Token: 0x0600AF59 RID: 44889 RVA: 0x013499B8 File Offset: 0x01347BB8
			internal static bool iW3lnWVjjyqf5vRn1f17()
			{
				return true;
			}

			// Token: 0x0600AF5A RID: 44890 RVA: 0x013499BC File Offset: 0x01347BBC
			internal static bool Ek6eMFVjhgN2IXRvSt7v()
			{
				return false;
			}

			// Token: 0x04009A24 RID: 39460
			internal int $result$45278;

			// Token: 0x04009A25 RID: 39461
			internal CompleteGui $mCompleteGui$45279;

			// Token: 0x04009A26 RID: 39462
			internal GameGui $mGameGui$45280;

			// Token: 0x04009A27 RID: 39463
			internal StoryGui $mStoryGui$45281;

			// Token: 0x04009A28 RID: 39464
			internal Hashtable $data$45282;

			// Token: 0x04009A29 RID: 39465
			internal M971_MaohsTomb7 $self_$45283;
		}
	}

	// Token: 0x02001D4C RID: 7500
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45286 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF5B RID: 44891 RVA: 0x013499C0 File Offset: 0x01347BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45286(M971_MaohsTomb7 self_)
		{
			if (222327 - 320430 != -98103)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189307 - 517666 == -328359)
				{
					base..ctor();
					if (191275 - 199484 == -8209)
					{
						this.$self_$45290 = self_;
						if (128686 - 26435 != 102252)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x01349A58 File Offset: 0x01347C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$ReturnToTown$45286.$(this.$self_$45290);
		}

		// Token: 0x0600AF5D RID: 44893 RVA: 0x01349A68 File Offset: 0x01347C68
		internal static bool sa5ER2VjsWSi8nFE6sqC()
		{
			return true;
		}

		// Token: 0x0600AF5E RID: 44894 RVA: 0x01349A6C File Offset: 0x01347C6C
		internal static bool rqDK28Vj9CYIuYrNg6k7()
		{
			return false;
		}

		// Token: 0x04009A2A RID: 39466
		internal M971_MaohsTomb7 $self_$45290;

		// Token: 0x02001D4D RID: 7501
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF5F RID: 44895 RVA: 0x01349A70 File Offset: 0x01347C70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb7 self_)
			{
				if (277797 - 338925 != -61127)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162340 - 21403 == 140937)
					{
						base..ctor();
						if (114462 - 501479 != -387016)
						{
							this.$self_$45289 = self_;
							if (12971 - 31850 == -18879)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AF60 RID: 44896 RVA: 0x01349B08 File Offset: 0x01347D08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (162290 - 309205 != -146915)
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
						this.$self_$45289.LeaveGame();
						if (255416 - 183332 != 72084)
						{
							continue;
						}
						this.YieldDefault(1);
						if (295905 - 301890 != -5984)
						{
							goto Block_27;
						}
						continue;
					default:
						if (43129 - 170243 == -127113)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (239310 - 317438 == -78128)
					{
						Game.mStateTime = Time.time;
						if (181161 - 538571 == -357410)
						{
							this.$$switch$8466$45287 = PlayerData.SaveGuild;
							if (2215 - 79460 == -77245)
							{
								if (this.$$switch$8466$45287 == 1)
								{
									if (88366 - 201395 != -113029)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (43002 - 190445 == -147442)
									{
										continue;
									}
								}
								else if (this.$$switch$8466$45287 == 2)
								{
									if (204136 - 11424 == 192713)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (101531 - 251889 == -150357)
									{
										continue;
									}
								}
								else if (this.$$switch$8466$45287 == 3)
								{
									if (38999 - 247737 != -208738)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (115817 - 298912 != -183095)
									{
										continue;
									}
								}
								else if (this.$$switch$8466$45287 == 4)
								{
									if (122496 - 410108 != -287612)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (241518 - 359920 != -118402)
									{
										continue;
									}
								}
								else if (this.$$switch$8466$45287 == 5)
								{
									if (148278 - 267552 != -119274)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (80287 - 9758 == 70530)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (270398 - 423551 == -153152)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (298767 - 567669 != -268902)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (162823 - 531920 != -369097)
									{
										continue;
									}
								}
								this.$mGameGui$45288 = (GameGui)this.$self_$45289.GetComponent(typeof(GameGui));
								if (43778 - 87774 == -43996)
								{
									if (this.$mGameGui$45288)
									{
										if (17131 - 580817 == -563685)
										{
											continue;
										}
										this.$mGameGui$45288.close();
										if (29778 - 539053 == -509274)
										{
											continue;
										}
									}
									this.$self_$45289.SendMessage("fadeOut");
									if (157626 - 504662 == -347036)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_27:
				IL_3AD:
				return false;
			}

			// Token: 0x0600AF61 RID: 44897 RVA: 0x01349ED4 File Offset: 0x013480D4
			internal static bool a0YyUjVj1p26UOjhtm6T()
			{
				return true;
			}

			// Token: 0x0600AF62 RID: 44898 RVA: 0x01349ED8 File Offset: 0x013480D8
			internal static bool xglnokVj4ZmFQPxdyP5b()
			{
				return false;
			}

			// Token: 0x04009A2B RID: 39467
			internal int $$switch$8466$45287;

			// Token: 0x04009A2C RID: 39468
			internal GameGui $mGameGui$45288;

			// Token: 0x04009A2D RID: 39469
			internal M971_MaohsTomb7 $self_$45289;
		}
	}

	// Token: 0x02001D4E RID: 7502
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45291 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF63 RID: 44899 RVA: 0x01349EDC File Offset: 0x013480DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45291(M971_MaohsTomb7 self_)
		{
			if (274887 - 215366 != 59522)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (129930 - 25383 != 104548)
				{
					base..ctor();
					if (294131 - 246987 != 47145)
					{
						this.$self_$45294 = self_;
						if (37096 - 48519 == -11423)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x01349F74 File Offset: 0x01348174
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$ReturnToGuild$45291.$(this.$self_$45294);
		}

		// Token: 0x0600AF65 RID: 44901 RVA: 0x01349F84 File Offset: 0x01348184
		internal static bool mpekrhVjzpWLB5oMyyKe()
		{
			return true;
		}

		// Token: 0x0600AF66 RID: 44902 RVA: 0x01349F88 File Offset: 0x01348188
		internal static bool HGihK7VhaVCdE1WAfEqS()
		{
			return false;
		}

		// Token: 0x04009A2E RID: 39470
		internal M971_MaohsTomb7 $self_$45294;

		// Token: 0x02001D4F RID: 7503
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF67 RID: 44903 RVA: 0x01349F8C File Offset: 0x0134818C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb7 self_)
			{
				if (57426 - 187806 != -130379)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176087 - 409606 == -233519)
					{
						base..ctor();
						if (280514 - 258315 == 22199)
						{
							this.$self_$45293 = self_;
							if (88301 - 222152 == -133851)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AF68 RID: 44904 RVA: 0x0134A024 File Offset: 0x01348224
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133861 - 9607 != 124255)
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
						this.$self_$45293.LeaveGame();
						if (127209 - 111789 != 15420)
						{
							continue;
						}
						this.YieldDefault(1);
						if (145060 - 290964 != -145903)
						{
							goto Block_5;
						}
						continue;
					default:
						if (154463 - 79778 != 74685)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (74231 - 462285 == -388054)
					{
						Game.mStateTime = Time.time;
						if (52726 - 494389 == -441663)
						{
							Game.mNextGameCode = 31;
							if (5648 - 506498 == -500850)
							{
								this.$mGameGui$45292 = (GameGui)this.$self_$45293.GetComponent(typeof(GameGui));
								if (191775 - 94103 == 97672)
								{
									if (this.$mGameGui$45292)
									{
										if (59209 - 445779 == -386569)
										{
											continue;
										}
										this.$mGameGui$45292.close();
										if (67421 - 148853 != -81432)
										{
											continue;
										}
									}
									this.$self_$45293.SendMessage("fadeOut");
									if (251305 - 400077 != -148771)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600AF69 RID: 44905 RVA: 0x0134A200 File Offset: 0x01348400
			internal static bool Q1hIV0Vh5LRgi2lXquue()
			{
				return true;
			}

			// Token: 0x0600AF6A RID: 44906 RVA: 0x0134A204 File Offset: 0x01348404
			internal static bool IkrLEuVhpR10YWdYkPpT()
			{
				return false;
			}

			// Token: 0x04009A2F RID: 39471
			internal GameGui $mGameGui$45292;

			// Token: 0x04009A30 RID: 39472
			internal M971_MaohsTomb7 $self_$45293;
		}
	}

	// Token: 0x02001D50 RID: 7504
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45295 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF6B RID: 44907 RVA: 0x0134A208 File Offset: 0x01348408
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45295(M971_MaohsTomb7 self_)
		{
			if (39750 - 404353 != -364602)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184186 - 525015 != -340828)
				{
					base..ctor();
					if (279123 - 42593 != 236531)
					{
						this.$self_$45299 = self_;
						if (181823 - 35288 == 146535)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AF6C RID: 44908 RVA: 0x0134A2A0 File Offset: 0x013484A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb7.$ReturnToCamp$45295.$(this.$self_$45299);
		}

		// Token: 0x0600AF6D RID: 44909 RVA: 0x0134A2B0 File Offset: 0x013484B0
		internal static bool qykVXHVhV4ig4Up7VNTf()
		{
			return true;
		}

		// Token: 0x0600AF6E RID: 44910 RVA: 0x0134A2B4 File Offset: 0x013484B4
		internal static bool AFxRSlVhtDbTdsJmii4t()
		{
			return false;
		}

		// Token: 0x04009A31 RID: 39473
		internal M971_MaohsTomb7 $self_$45299;

		// Token: 0x02001D51 RID: 7505
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF6F RID: 44911 RVA: 0x0134A2B8 File Offset: 0x013484B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb7 self_)
			{
				if (183488 - 437466 != -253978)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104483 - 208109 == -103626)
					{
						base..ctor();
						if (133839 - 253557 == -119718)
						{
							this.$self_$45298 = self_;
							if (168477 - 191673 != -23195)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AF70 RID: 44912 RVA: 0x0134A350 File Offset: 0x01348550
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (49514 - 578178 != -528664)
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
						this.$self_$45298.LeaveGame();
						if (274046 - 377621 != -103575)
						{
							continue;
						}
						this.YieldDefault(1);
						if (125729 - 190418 != -64688)
						{
							goto Block_10;
						}
						continue;
					default:
						if (274121 - 466425 != -192304)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (279837 - 189083 == 90754)
					{
						Game.mStateTime = Time.time;
						if (209544 - 16244 == 193300)
						{
							this.$$switch$8468$45296 = PlayerData.SaveGuild;
							if (103136 - 347830 != -244693)
							{
								if (this.$$switch$8468$45296 == 1)
								{
									if (145280 - 115326 != 29954)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (211436 - 14196 != 197240)
									{
										continue;
									}
								}
								else if (this.$$switch$8468$45296 == 2)
								{
									if (45032 - 589199 != -544167)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (103060 - 64555 != 38505)
									{
										continue;
									}
								}
								else if (this.$$switch$8468$45296 == 3)
								{
									if (214924 - 262248 != -47324)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (970 - 336128 == -335157)
									{
										continue;
									}
								}
								else if (this.$$switch$8468$45296 == 4)
								{
									if (85672 - 505749 != -420077)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (144712 - 544034 == -399321)
									{
										continue;
									}
								}
								else if (this.$$switch$8468$45296 == 5)
								{
									if (104088 - 460203 == -356114)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (79777 - 336908 != -257131)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (118247 - 443208 != -324961)
									{
										continue;
									}
								}
								this.$mGameGui$45297 = (GameGui)this.$self_$45298.GetComponent(typeof(GameGui));
								if (281179 - 430043 == -148864)
								{
									if (this.$mGameGui$45297)
									{
										if (77163 - 99419 != -22256)
										{
											continue;
										}
										this.$mGameGui$45297.close();
										if (258551 - 207883 == 50669)
										{
											continue;
										}
									}
									this.$self_$45298.SendMessage("fadeOut");
									if (264061 - 127632 != 136430)
									{
										goto Block_17;
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_363;
				Block_17:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600AF71 RID: 44913 RVA: 0x0134A6D4 File Offset: 0x013488D4
			internal static bool qCCePIVhNKKoXYyHa3AA()
			{
				return true;
			}

			// Token: 0x0600AF72 RID: 44914 RVA: 0x0134A6D8 File Offset: 0x013488D8
			internal static bool lRXuMeVhYoSZuECYVbgL()
			{
				return false;
			}

			// Token: 0x04009A32 RID: 39474
			internal int $$switch$8468$45296;

			// Token: 0x04009A33 RID: 39475
			internal GameGui $mGameGui$45297;

			// Token: 0x04009A34 RID: 39476
			internal M971_MaohsTomb7 $self_$45298;
		}
	}
}
