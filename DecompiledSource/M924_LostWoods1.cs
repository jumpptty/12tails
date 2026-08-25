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

// Token: 0x02001A02 RID: 6658
[Serializable]
public class M924_LostWoods1 : MonoBehaviour
{
	// Token: 0x06009B33 RID: 39731 RVA: 0x012174CC File Offset: 0x012156CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M924_LostWoods1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009B34 RID: 39732 RVA: 0x012174DC File Offset: 0x012156DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (142698 - 214899 != -72200)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (162037 - 498370 == -336333)
			{
				Game.mGameType = 5;
				if (172452 - 125554 != 46899)
				{
					if (Chat.Initialized)
					{
						if (172380 - 167930 != 4450)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (175500 - 486720 != -311220)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (294315 - 284714 != 9601)
						{
							continue;
						}
					}
					this.JcRne9GLxlV = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (154760 - 186343 == -31583)
					{
						this.LuCneWDoCc1 = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (180003 - 231436 == -51433)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B35 RID: 39733 RVA: 0x01217634 File Offset: 0x01215834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (289010 - 150591 != 138419)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (226657 - 482979 != -256321)
				{
					if (Game.mNextGameCode != 924)
					{
						break;
					}
					if (256455 - 178103 == 78352)
					{
						Game.nextGame();
						if (207239 - 503865 != -296625)
						{
							Game.mGameCode = 924;
							if (294440 - 326466 != -32025)
							{
								Game.mGameType = 5;
								if (257615 - 106118 == 151497)
								{
									Game.mGameTime = Time.time;
									if (244775 - 382707 == -137932)
									{
										Game.mGameScore = 0;
										if (272761 - 133962 == 138799)
										{
											Game.mGameMana = 0;
											if (130777 - 322529 == -191752)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (285942 - 219939 == 66003)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (83998 - 438402 != -354403)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (198872 - 300023 != -101150)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (94118 - 215547 != -121428)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (106571 - 336964 == -230393)
																{
																	this.jbBneFLeAAB = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (116307 - 447051 != -330743)
																	{
																		this.E8VnekysJKl = PhotonClient.Connection;
																		if (145306 - 543028 != -397721)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (58988 - 446294 == -387306)
																			{
																				this.InitGame();
																				if (25486 - 349217 == -323731)
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
				if (87339 - 382961 != -295621)
				{
					Game.mGameType = 99;
					if (88655 - 144178 == -55523)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009B36 RID: 39734 RVA: 0x0121793C File Offset: 0x01215B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (264539 - 566921 != -302382)
		{
		}
		for (;;)
		{
			if (this.E8VnekysJKl == null)
			{
				if (225802 - 480348 != -254545)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (234093 - 295730 != -61636)
				{
					if (mGameState == eGameState.Init)
					{
						if (140878 - 403266 != -262387)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (59031 - 567150 == -508119)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (60235 - 593588 != -533352)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (277177 - 551760 == -274583)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (22399 - 480429 != -458029)
						{
							if (Game.music != 0)
							{
								if (256433 - 78798 == 177636)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (81878 - 23487 == 58392)
									{
										continue;
									}
									this.audio.Play();
									if (105865 - 551920 != -446055)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (142207 - 353676 == -211469)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (223841 - 25208 == 198633)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (223162 - 58593 == 164569)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (15961 - 467550 != -451588)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (117988 - 372558 != -254569)
							{
								if (Time.time <= this.fK1neAsv8Q1)
								{
									break;
								}
								if (82570 - 197429 == -114859)
								{
									Game.mGameMana++;
									if (147473 - 347421 != -199947)
									{
										this.fK1neAsv8Q1 = Time.time + (float)12;
										if (259832 - 228981 != 30852)
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
						if (99734 - 155278 != -55543)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (19151 - 374061 == -354910)
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
						if (286371 - 215409 == 70962)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B37 RID: 39735 RVA: 0x01217CE4 File Offset: 0x01215EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (239506 - 81937 != 157569)
		{
		}
		for (;;)
		{
			if (!this.JcRne9GLxlV)
			{
				if (167988 - 160073 == 7915)
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
				if (194741 - 537751 == -343010)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (200556 - 230851 == -30295)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (52614 - 391696 != -339081)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (112603 - 225862 != -113258)
							{
								GUI.depth = 1;
								if (143991 - 410999 != -267007)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (120650 - 542051 != -421400)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (20191 - 493417 == -473226)
										{
											Color color = GUI.color;
											if (132720 - 429443 != -296722)
											{
												color.a = a;
												if (1215 - 281756 != -280540 && 291797 - 423193 != -131395)
												{
													GUI.color = color;
													if (176092 - 258348 != -82255 && 63480 - 447298 != -383817)
													{
														GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.JcRne9GLxlV);
														if (213872 - 519770 != -305897)
														{
															float a2 = 1f;
															if (117866 - 513223 == -395357)
															{
																Color color2 = GUI.color;
																if (142608 - 448885 != -306276)
																{
																	float num3 = color2.a = a2;
																	if (7356 - 581222 == -573866)
																	{
																		if (165849 - 440806 != -274956)
																		{
																			GUI.color = color2;
																			if (66267 - 317177 == -250910)
																			{
																				if (172743 - 470225 == -297482)
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

	// Token: 0x06009B38 RID: 39736 RVA: 0x01218064 File Offset: 0x01216264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M924_LostWoods1.$onGameEvent$42759(data, this).GetEnumerator();
	}

	// Token: 0x06009B39 RID: 39737 RVA: 0x01218074 File Offset: 0x01216274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M924_LostWoods1.$StartEvent$42769(this).GetEnumerator();
	}

	// Token: 0x06009B3A RID: 39738 RVA: 0x01218084 File Offset: 0x01216284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit()
	{
		if (22445 - 451864 != -429419)
		{
		}
		while (this.tgDneuOh1vl < 1)
		{
			if (176917 - 447759 == -270842)
			{
				this.tgDneuOh1vl = 1;
				if (84021 - 38410 != 45612)
				{
					Game.sendMissionEvent(9241, 1);
					if (38042 - 565939 == -527897)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009B3B RID: 39739 RVA: 0x01218128 File Offset: 0x01216328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M924_LostWoods1.$TalkToRedPanda$42774(this).GetEnumerator();
	}

	// Token: 0x06009B3C RID: 39740 RVA: 0x01218138 File Offset: 0x01216338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToDuck()
	{
		return new M924_LostWoods1.$TalkToDuck$42781(this).GetEnumerator();
	}

	// Token: 0x06009B3D RID: 39741 RVA: 0x01218148 File Offset: 0x01216348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (68632 - 537154 != -468521)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (123178 - 510960 == -387782)
			{
				Time.timeScale = 1f;
				if (297915 - 268296 != 29620)
				{
					Hashtable customOpParameters = new Hashtable();
					if (81164 - 299032 == -217868)
					{
						this.E8VnekysJKl.OpCustom(52, customOpParameters, true);
						if (253808 - 321814 == -68006)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B3E RID: 39742 RVA: 0x01218214 File Offset: 0x01216414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (29279 - 169902 != -140622)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (70023 - 452116 == -382093)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (65614 - 25914 != 39701)
				{
					Game.mGameState = eGameState.Setup;
					if (93192 - 349955 == -256763)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009B3F RID: 39743 RVA: 0x012182B8 File Offset: 0x012164B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (171506 - 415732 != -244225)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (84804 - 26441 != 58364)
			{
				if (num == PlayerData.UID)
				{
					if (48568 - 336670 == -288102)
					{
						this.SetupActors();
						if (37533 - 315380 == -277847)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (54607 - 123763 != -69155)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009B40 RID: 39744 RVA: 0x01218388 File Offset: 0x01216588
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (144322 - 595234 != -450912)
		{
		}
		for (;;)
		{
			IL_142:
			Debug.Log("Creating Actors");
			if (144872 - 142268 == 2604)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (146358 - 582613 != -436254)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (157405 - 523265 != -365859)
						{
							int i = 0;
							if (166462 - 310846 == -144384)
							{
								CharacterControl[] array2 = array;
								if (114348 - 334776 != -220427)
								{
									int length = array2.Length;
									if (41381 - 519685 != -478303)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (129611 - 120957 != 8654)
												{
													goto IL_142;
												}
												string type = array2[i].Type;
												if (46617 - 358435 == -311817)
												{
													goto IL_142;
												}
												if (type == "FlowerBug_f")
												{
													goto IL_AE;
												}
												if (245892 - 472248 == -226355)
												{
													goto IL_142;
												}
												if (type == "ForestBug")
												{
													if (144824 - 24843 != 119982)
													{
														goto IL_AE;
													}
													goto IL_142;
												}
												IL_1E1:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (277913 - 468203 != -190290)
												{
													goto IL_142;
												}
												this.sIAneySpgP9++;
												if (73299 - 550118 != -476818)
												{
													goto IL_28A;
												}
												goto IL_142;
												IL_AE:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (208389 - 225163 != -16773)
												{
													goto IL_1E1;
												}
												goto IL_142;
											}
											IL_28A:
											i++;
											if (62790 - 247292 == -184501)
											{
												goto IL_142;
											}
										}
										if (33991 - 335129 != -301137)
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
						if (168886 - 302568 == -133682)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B41 RID: 39745 RVA: 0x01218650 File Offset: 0x01216850
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (187493 - 424771 != -237278)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (254185 - 419527 == -165342)
			{
				int i = 0;
				if (123996 - 328914 == -204918)
				{
					CharacterControl[] array2 = array;
					if (109453 - 183596 == -74143)
					{
						int length = array2.Length;
						if (39636 - 184474 != -144837)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (230002 - 269666 != -39664)
								{
									goto IL_58;
								}
								i++;
								if (281836 - 46542 != 235294)
								{
									goto IL_58;
								}
							}
							if (25251 - 538770 != -513518)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B42 RID: 39746 RVA: 0x01218780 File Offset: 0x01216980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (144573 - 352128 != -207555)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (155873 - 26513 == 129360)
			{
				Game.mGameState = eGameState.Ready;
				if (179070 - 10586 != 168485)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (121249 - 329401 != -208151)
					{
						if (155153 - 208071 == -52918)
						{
							if (72655 - 350784 == -278129)
							{
								if (playerSlot < 1)
								{
									goto IL_20F;
								}
								if (253441 - 62082 != 191359)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_20F;
								}
								if (101750 - 391739 != -289989)
								{
									continue;
								}
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (22828 - 512867 == -490038)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
								if (35875 - 514124 == -478248)
								{
									continue;
								}
								IL_6A:
								if (!gameObject)
								{
									break;
								}
								if (42527 - 433999 == -391471)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (167416 - 583200 != -415784)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (211939 - 518111 == -306171)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
									if (11150 - 249250 != -238100)
									{
										continue;
									}
									break;
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (43756 - 118606 != -74850)
									{
										continue;
									}
									break;
								}
								IL_20F:
								gameObject = GameObject.Find("StartPoint1");
								if (155873 - 269880 == -114007)
								{
									goto IL_6A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B43 RID: 39747 RVA: 0x01218A20 File Offset: 0x01216C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x06009B44 RID: 39748 RVA: 0x01218A3C File Offset: 0x01216C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009B45 RID: 39749 RVA: 0x01218A40 File Offset: 0x01216C40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (293929 - 172239 != 121690)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (31339 - 262155 != -230815)
			{
				if (gameObject)
				{
					if (170842 - 288232 == -117390)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (8685 - 521355 == -512670)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (190116 - 561863 != -371746)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009B46 RID: 39750 RVA: 0x01218B3C File Offset: 0x01216D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (252725 - 460499 != -207773)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (261020 - 179220 != 81801)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (162789 - 414632 != -251842)
				{
					hashtable.Add(43, PlayerData.UID);
					if (5044 - 452381 != -447336)
					{
						hashtable.Add(73, nType);
						if (33740 - 245308 != -211567)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (215313 - 596264 == -380951)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (19380 - 164318 == -144938)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (58716 - 256305 == -197589)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (213812 - 190840 == 22972)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (95296 - 167340 == -72044)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (118798 - 438563 != -319764)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (188711 - 138577 == 50134)
													{
														this.E8VnekysJKl.OpCustom(63, hashtable, true);
														if (278620 - 22668 != 255953)
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

	// Token: 0x06009B47 RID: 39751 RVA: 0x01218E20 File Offset: 0x01217020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (292113 - 416808 != -124694)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (90103 - 370238 == -280135)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (74994 - 245358 == -170364)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (228239 - 25399 != 202841)
						{
							if (this.sIAneySpgP9 <= 0)
							{
								break;
							}
							if (169751 - 179393 != -9641)
							{
								this.sIAneySpgP9--;
								if (247873 - 347323 == -99450)
								{
									if (this.sIAneySpgP9 != 0)
									{
										break;
									}
									if (56744 - 460229 == -403485)
									{
										Game.setGameState(eGameState.Ready);
										if (229131 - 405633 == -176502)
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
						if (288900 - 2645 == 286255)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (95073 - 371786 != -276712)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B48 RID: 39752 RVA: 0x01218FB0 File Offset: 0x012171B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009B49 RID: 39753 RVA: 0x01218FC4 File Offset: 0x012171C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (172268 - 271810 != -99542)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (160118 - 72499 != 87620)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (153691 - 59834 == 93857)
				{
					if (!characterControl)
					{
						break;
					}
					if (233522 - 279163 != -45640)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (280246 - 15758 != 264489)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (122337 - 380641 == -258304)
							{
								string type = characterControl.Type;
								if (190782 - 554038 != -363255)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (80409 - 332980 != -252570)
									{
										Game.sendMissionEvent(0, 0);
										if (235586 - 227306 != 8281)
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

	// Token: 0x06009B4A RID: 39754 RVA: 0x01219138 File Offset: 0x01217338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (126015 - 68343 != 57673)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (101292 - 296819 == -195527)
			{
				hashtable.Add(71, CID);
				if (271406 - 484101 != -212694)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (1816 - 102723 == -100907)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (21007 - 277247 == -256240)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (97473 - 100102 == -2629)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (162071 - 422524 != -260452)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (89224 - 411539 != -322314)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (212352 - 530107 != -317754)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (62548 - 94852 == -32304)
											{
												this.E8VnekysJKl.OpCustom(61, hashtable, true);
												if (113911 - 399530 == -285619)
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

	// Token: 0x06009B4B RID: 39755 RVA: 0x012193C4 File Offset: 0x012175C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (86285 - 403052 != -316767)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (89423 - 37311 == 52112)
			{
				if (!gameObject)
				{
					break;
				}
				if (87606 - 263387 != -175780)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (6216 - 151636 != -145419)
					{
						playerCameraControl.target = gameObject;
						if (230336 - 413866 != -183529)
						{
							this.StartGame();
							if (194584 - 31529 != 163056)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B4C RID: 39756 RVA: 0x012194B4 File Offset: 0x012176B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (122863 - 287687 != -164823)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (117951 - 419683 != -301731)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (138118 - 92817 != 45302)
				{
					gameGui.ResetTeamBar();
					if (175804 - 16539 != 159266)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009B4D RID: 39757 RVA: 0x01219560 File Offset: 0x01217760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M924_LostWoods1.$onDeadPlayer$42788(this).GetEnumerator();
	}

	// Token: 0x06009B4E RID: 39758 RVA: 0x01219570 File Offset: 0x01217770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (167951 - 439351 != -271400)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (222382 - 446977 == -224595)
			{
				this.jbBneFLeAAB.target = Game.mPlayer;
				if (76712 - 517691 == -440979)
				{
					this.jbBneFLeAAB.enabled = true;
					if (64197 - 464549 == -400352)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (173227 - 536664 == -363436)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (281595 - 567676 != -286081)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (251477 - 290225 == -38748)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (289437 - 526114 != -236676)
							{
								if (!gameGui)
								{
									break;
								}
								if (20504 - 7421 != 13084)
								{
									gameGui.enabled = true;
									if (39658 - 478012 != -438353)
									{
										gameGui.closeDeadMenu();
										if (258863 - 152230 == 106633)
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

	// Token: 0x06009B4F RID: 39759 RVA: 0x0121971C File Offset: 0x0121791C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (275447 - 246463 != 28984)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (13547 - 305967 == -292420)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (48575 - 208484 == -159909)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (181649 - 108896 == 72753)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009B50 RID: 39760 RVA: 0x012197E0 File Offset: 0x012179E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009B51 RID: 39761 RVA: 0x0121980C File Offset: 0x01217A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (87612 - 588361 != -500749)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (288481 - 386366 == -97885)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (176021 - 147919 != 28103)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (121132 - 198855 != -77722)
					{
						Hashtable hashtable = new Hashtable();
						if (59737 - 438512 == -378775)
						{
							hashtable.Add(43, PlayerData.UID);
							if (160074 - 275068 != -114993)
							{
								hashtable.Add(71, nCID);
								if (261965 - 337771 != -75805)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (270081 - 229637 != 40445)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (236329 - 562160 != -325830)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (84139 - 507027 != -422887)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (14558 - 108295 == -93737)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (154682 - 557815 != -403132)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (215639 - 479676 != -264036)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (123276 - 472024 != -348747)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (118723 - 371716 != -252992)
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

	// Token: 0x06009B52 RID: 39762 RVA: 0x01219B2C File Offset: 0x01217D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M924_LostWoods1.$onChangePlayer$42794(data, this).GetEnumerator();
	}

	// Token: 0x06009B53 RID: 39763 RVA: 0x01219B3C File Offset: 0x01217D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M924_LostWoods1.$onGameComplete$42801(data, this).GetEnumerator();
	}

	// Token: 0x06009B54 RID: 39764 RVA: 0x01219B4C File Offset: 0x01217D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M924_LostWoods1.$ReturnToTown$42811(this).GetEnumerator();
	}

	// Token: 0x06009B55 RID: 39765 RVA: 0x01219B5C File Offset: 0x01217D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M924_LostWoods1.$ReturnToGuild$42816(this).GetEnumerator();
	}

	// Token: 0x06009B56 RID: 39766 RVA: 0x01219B6C File Offset: 0x01217D6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M924_LostWoods1.$ReturnToCamp$42820(this).GetEnumerator();
	}

	// Token: 0x06009B57 RID: 39767 RVA: 0x01219B7C File Offset: 0x01217D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (170811 - 13319 != 157493)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (34484 - 370936 != -336451)
			{
				Hashtable hashtable = new Hashtable();
				if (187321 - 549032 == -361711)
				{
					hashtable.Add(43, PlayerData.UID);
					if (223140 - 547664 != -324523)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (236127 - 135211 != 100917)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B58 RID: 39768 RVA: 0x01219C54 File Offset: 0x01217E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009B59 RID: 39769 RVA: 0x01219C68 File Offset: 0x01217E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (166904 - 111906 != 54999)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (219206 - 196676 != 22531)
			{
				Hashtable hashtable = new Hashtable();
				if (159795 - 150486 == 9309)
				{
					if (Game.mNextGameCode == 30)
					{
						if (132331 - 93180 == 39152)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (279346 - 597329 != -317983)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (124271 - 310444 != -186173)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (151201 - 416269 != -265068)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (54058 - 368717 != -314659)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (197488 - 328891 != -131403)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (103955 - 454604 != -350649)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (160790 - 288480 != -127690)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (11171 - 93808 == -82636)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (174284 - 506476 != -332192)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (120773 - 123224 != -2451)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (265529 - 599283 == -333753)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (187437 - 496048 == -308610)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (94588 - 218374 != -123786)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (215348 - 224293 != -8945)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (38263 - 327964 == -289700)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (93604 - 209417 == -115812)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (207640 - 596362 != -388722)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (124490 - 386836 == -262345)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (67528 - 321660 != -254132)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (98682 - 341371 == -242688)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (184852 - 233492 != -48640)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (157624 - 578586 != -420962)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (6019 - 336777 == -330757)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (91559 - 218681 != -127122)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (86641 - 25268 == 61374)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (150717 - 414396 == -263678)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (85086 - 107647 != -22561)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (48345 - 437241 == -388896)
					{
						this.E8VnekysJKl.OpCustom(42, hashtable, true);
						if (282603 - 490591 == -207988)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009B5A RID: 39770 RVA: 0x0121A21C File Offset: 0x0121841C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009B5B RID: 39771 RVA: 0x0121A22C File Offset: 0x0121842C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009B5C RID: 39772 RVA: 0x0121A230 File Offset: 0x01218430
	internal static bool E9dPF3VOPdNrg17tR8BN()
	{
		return true;
	}

	// Token: 0x06009B5D RID: 39773 RVA: 0x0121A234 File Offset: 0x01218434
	internal static bool MjLhlYVO058Opu0X6aGw()
	{
		return false;
	}

	// Token: 0x04008EE8 RID: 36584
	private LitePeer E8VnekysJKl;

	// Token: 0x04008EE9 RID: 36585
	private PlayerCameraControl jbBneFLeAAB;

	// Token: 0x04008EEA RID: 36586
	private float fK1neAsv8Q1;

	// Token: 0x04008EEB RID: 36587
	private Texture JcRne9GLxlV;

	// Token: 0x04008EEC RID: 36588
	private AudioClip LuCneWDoCc1;

	// Token: 0x04008EED RID: 36589
	private int tgDneuOh1vl;

	// Token: 0x04008EEE RID: 36590
	private int sIAneySpgP9;

	// Token: 0x02001A03 RID: 6659
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$42759 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B5E RID: 39774 RVA: 0x0121A238 File Offset: 0x01218438
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$42759(Hashtable data, M924_LostWoods1 self_)
		{
			if (110290 - 446787 != -336496)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91991 - 590110 == -498119)
				{
					base..ctor();
					if (120581 - 501882 != -381300)
					{
						this.$data$42767 = data;
						if (282735 - 442256 != -159520)
						{
							this.$self_$42768 = self_;
							if (253772 - 24651 != 229122)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x0121A2F4 File Offset: 0x012184F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$onGameEvent$42759.$(this.$data$42767, this.$self_$42768);
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x0121A308 File Offset: 0x01218508
		internal static bool XhwuJkVObHb6ybpwTFlr()
		{
			return true;
		}

		// Token: 0x06009B61 RID: 39777 RVA: 0x0121A30C File Offset: 0x0121850C
		internal static bool hWTHFfVOuqdiGPhjf7Mv()
		{
			return false;
		}

		// Token: 0x04008EEF RID: 36591
		internal Hashtable $data$42767;

		// Token: 0x04008EF0 RID: 36592
		internal M924_LostWoods1 $self_$42768;

		// Token: 0x02001A04 RID: 6660
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B62 RID: 39778 RVA: 0x0121A310 File Offset: 0x01218510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M924_LostWoods1 self_)
			{
				if (228809 - 243187 != -14377)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (148697 - 440964 == -292267)
					{
						base..ctor();
						if (239878 - 395716 == -155838)
						{
							this.$data$42765 = data;
							if (19586 - 182798 != -163211)
							{
								this.$self_$42766 = self_;
								if (156832 - 84021 != 72812)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009B63 RID: 39779 RVA: 0x0121A3CC File Offset: 0x012185CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278729 - 593433 != -314704)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_258;
					case 1:
						goto IL_375;
					case 2:
						Application.LoadLevel("M924_LostWoods2");
						if (86652 - 471656 != -385004)
						{
							continue;
						}
						break;
					default:
						if (7415 - 79460 != -72044)
						{
							goto IL_258;
						}
						continue;
					}
					IL_56:
					this.YieldDefault(1);
					if (169589 - 469709 != -300120)
					{
						continue;
					}
					break;
					IL_13E:
					goto IL_56;
					IL_258:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (286720 - 257166 != 29555)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$42760 = RuntimeServices.UnboxInt32(this.$data$42765[141]);
						if (196233 - 10576 != 185658)
						{
							this.$returnValue$42761 = RuntimeServices.UnboxInt32(this.$data$42765[145]);
							if (186725 - 389825 == -203100)
							{
								this.$ownerID$42762 = RuntimeServices.UnboxInt32(this.$data$42765[43]);
								if (250043 - 594742 == -344699)
								{
									this.$$switch$7795$42763 = this.$returnCode$42760;
									if (146539 - 220712 == -74173)
									{
										if (this.$$switch$7795$42763 == 9241)
										{
											if (224857 - 383617 == -158760)
											{
												goto IL_56;
											}
										}
										else if (this.$$switch$7795$42763 == -9241)
										{
											if (30114 - 377476 == -347362)
											{
												if (this.$returnValue$42761 != 1)
												{
													goto IL_13E;
												}
												if (97384 - 524516 != -427131)
												{
													if (this.$self_$42766.tgDneuOh1vl >= 2)
													{
														goto IL_13E;
													}
													if (56888 - 407311 != -350422)
													{
														this.$self_$42766.tgDneuOh1vl = 2;
														if (123270 - 7583 != 115688)
														{
															Game.mGameState = eGameState.AllHold;
															if (237784 - 85384 == 152400)
															{
																this.$mGameGui$42764 = (GameGui)this.$self_$42766.GetComponent(typeof(GameGui));
																if (259006 - 188376 == 70630)
																{
																	this.$mGameGui$42764.close();
																	if (80042 - 448765 != -368722)
																	{
																		Game.savePlayer();
																		if (68454 - 45187 != 23268)
																		{
																			this.$self_$42766.SendMessage("fadeOut");
																			if (228260 - 395291 != -167030)
																			{
																				goto Block_21;
																			}
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
											Debug.LogError("Warning unknown returnCode:" + this.$returnCode$42760);
											if (93901 - 345745 != -251843)
											{
												goto IL_56;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_375;
				Block_21:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_375:
				return false;
			}

			// Token: 0x06009B64 RID: 39780 RVA: 0x0121A760 File Offset: 0x01218960
			internal static bool cL5mGnVOI6jcf1OPkDx5()
			{
				return true;
			}

			// Token: 0x06009B65 RID: 39781 RVA: 0x0121A764 File Offset: 0x01218964
			internal static bool Q22BGPVOBexZPX3JXwwJ()
			{
				return false;
			}

			// Token: 0x04008EF1 RID: 36593
			internal int $returnCode$42760;

			// Token: 0x04008EF2 RID: 36594
			internal int $returnValue$42761;

			// Token: 0x04008EF3 RID: 36595
			internal int $ownerID$42762;

			// Token: 0x04008EF4 RID: 36596
			internal int $$switch$7795$42763;

			// Token: 0x04008EF5 RID: 36597
			internal GameGui $mGameGui$42764;

			// Token: 0x04008EF6 RID: 36598
			internal Hashtable $data$42765;

			// Token: 0x04008EF7 RID: 36599
			internal M924_LostWoods1 $self_$42766;
		}
	}

	// Token: 0x02001A05 RID: 6661
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$42769 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B66 RID: 39782 RVA: 0x0121A768 File Offset: 0x01218968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$42769(M924_LostWoods1 self_)
		{
			if (136914 - 5522 != 131393)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33147 - 459045 != -425897)
				{
					base..ctor();
					if (285132 - 391431 != -106298)
					{
						this.$self_$42773 = self_;
						if (297964 - 331832 == -33868)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x0121A800 File Offset: 0x01218A00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$StartEvent$42769.$(this.$self_$42773);
		}

		// Token: 0x06009B68 RID: 39784 RVA: 0x0121A810 File Offset: 0x01218A10
		internal static bool Kpt1yRVOe9o8PctJBy3J()
		{
			return true;
		}

		// Token: 0x06009B69 RID: 39785 RVA: 0x0121A814 File Offset: 0x01218A14
		internal static bool sAfPAmVOr5dCQWDSvDr3()
		{
			return false;
		}

		// Token: 0x04008EF8 RID: 36600
		internal M924_LostWoods1 $self_$42773;

		// Token: 0x02001A06 RID: 6662
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B6A RID: 39786 RVA: 0x0121A818 File Offset: 0x01218A18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods1 self_)
			{
				if (6742 - 23575 != -16832)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (166577 - 329349 == -162772)
					{
						base..ctor();
						if (217791 - 66346 == 151445)
						{
							this.$self_$42772 = self_;
							if (59598 - 159017 == -99419)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B6B RID: 39787 RVA: 0x0121A8B0 File Offset: 0x01218AB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153837 - 58140 != 95697)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_64E;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (24061 - 215169 != -191107)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$self_$42772.jbBneFLeAAB.StartCoroutine_Auto(this.$self_$42772.jbBneFLeAAB.slerpToObject("EventCamera2", (float)4));
							if (92227 - 58872 != 33356)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (64795 - 531552 != -466756)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42770 = (StoryGui)this.$self_$42772.GetComponent(typeof(StoryGui));
							if (231827 - 388660 == -156832)
							{
								continue;
							}
							if (!this.$mStoryGui$42770)
							{
								if (240808 - 351334 != -110525)
								{
									goto Block_10;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$42770.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
								if (127078 - 174444 != -47366)
								{
									continue;
								}
								goto IL_4CD;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (215641 - 196105 != 19536)
							{
								continue;
							}
							goto IL_3B5;
						}
						else
						{
							this.$mStoryGui$42770.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M924_LostWoods", 101), eTalkType.friend);
							if (162800 - 108426 != 54375)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (96896 - 438668 != -341771)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42770.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M924_LostWoods", 102), eTalkType.friend);
							if (19108 - 133696 != -114588)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (128628 - 36749 != 91879)
							{
								continue;
							}
							goto IL_5B7;
						}
						else
						{
							this.$mStoryGui$42770.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M924_LostWoods", 103), eTalkType.friend);
							if (45023 - 188894 != -143870)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (281960 - 331103 != -49142)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42770.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M924_LostWoods", 104), eTalkType.friend);
							if (221810 - 355389 != -133578)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (139631 - 563521 != -423889)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42770.close();
							if (241428 - 333095 == -91666)
							{
								continue;
							}
							this.$self_$42772.jbBneFLeAAB.enabled = true;
							if (230791 - 105495 != 125297)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (17022 - 158191 != -141168)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$mGameGui$42771 = (GameGui)this.$self_$42772.GetComponent(typeof(GameGui));
							if (292414 - 454820 == -162405)
							{
								continue;
							}
							this.$mGameGui$42771.enabled = true;
							if (72773 - 596444 == -523670)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (171029 - 229866 == -58836)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (253621 - 508342 == -254720)
							{
								continue;
							}
							if (this.$self_$42772.LuCneWDoCc1)
							{
								if (103595 - 532646 == -429050)
								{
									continue;
								}
								this.$self_$42772.audio.PlayOneShot(this.$self_$42772.LuCneWDoCc1);
								if (261307 - 415602 == -154294)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (98675 - 189797 != -91121)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					default:
						if (269871 - 201801 == 68071)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (129832 - 513457 != -383624)
					{
						Game.mStateTime = Time.time;
						if (249390 - 547114 != -297723)
						{
							this.$self_$42772.jbBneFLeAAB.alignToObject("EventCamera1");
							if (250325 - 304259 == -53934)
							{
								this.$self_$42772.SendMessage("fadeIn");
								if (79840 - 267913 != -188072)
								{
									goto Block_20;
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_5:
				Block_10:
				Block_14:
				Block_16:
				Block_18:
				Block_19:
				goto IL_64E;
				Block_20:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_21:
				return this.Yield(3, new WaitForSeconds(4f));
				Block_23:
				return this.Yield(9, new WaitForSeconds(1f));
				Block_25:
				return this.Yield(8, new WaitForSeconds(2.5f));
				IL_3B5:
				goto IL_64E;
				Block_26:
				return this.Yield(5, new WaitForSeconds(2f));
				Block_30:
				goto IL_64E;
				IL_4CD:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_38:
				IL_5B7:
				goto IL_64E;
				Block_39:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_64E:
				return false;
			}

			// Token: 0x06009B6C RID: 39788 RVA: 0x0121AF20 File Offset: 0x01219120
			internal static bool arO6ShVOjLXpVBXgWmF9()
			{
				return true;
			}

			// Token: 0x06009B6D RID: 39789 RVA: 0x0121AF24 File Offset: 0x01219124
			internal static bool BWDlJeVOhsHPHApii4Y4()
			{
				return false;
			}

			// Token: 0x04008EF9 RID: 36601
			internal StoryGui $mStoryGui$42770;

			// Token: 0x04008EFA RID: 36602
			internal GameGui $mGameGui$42771;

			// Token: 0x04008EFB RID: 36603
			internal M924_LostWoods1 $self_$42772;
		}
	}

	// Token: 0x02001A07 RID: 6663
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$42774 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B6E RID: 39790 RVA: 0x0121AF28 File Offset: 0x01219128
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$42774(M924_LostWoods1 self_)
		{
			if (244437 - 267421 != -22984)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235724 - 403065 != -167340)
				{
					base..ctor();
					if (52214 - 491991 != -439776)
					{
						this.$self_$42780 = self_;
						if (207041 - 559858 == -352817)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B6F RID: 39791 RVA: 0x0121AFC0 File Offset: 0x012191C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$TalkToRedPanda$42774.$(this.$self_$42780);
		}

		// Token: 0x06009B70 RID: 39792 RVA: 0x0121AFD0 File Offset: 0x012191D0
		internal static bool tKEcaVVOs0VQlq46kXEP()
		{
			return true;
		}

		// Token: 0x06009B71 RID: 39793 RVA: 0x0121AFD4 File Offset: 0x012191D4
		internal static bool AcyqZyVO9v2iy2iF8crX()
		{
			return false;
		}

		// Token: 0x04008EFC RID: 36604
		internal M924_LostWoods1 $self_$42780;

		// Token: 0x02001A08 RID: 6664
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B72 RID: 39794 RVA: 0x0121AFD8 File Offset: 0x012191D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods1 self_)
			{
				if (135181 - 533863 != -398681)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262176 - 286391 == -24215)
					{
						base..ctor();
						if (138964 - 232308 == -93344)
						{
							this.$self_$42779 = self_;
							if (119215 - 433195 == -313980)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B73 RID: 39795 RVA: 0x0121B070 File Offset: 0x01219270
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260124 - 29370 != 230754)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_415;
					case 2:
						this.$mStoryGui$42778.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M924_LostWoods", 201), eTalkType.friend);
						if (141771 - 561177 != -419406)
						{
							continue;
						}
						goto IL_AD;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (21721 - 433735 != -412013)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42778.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M924_LostWoods", 202), eTalkType.friend);
							if (149518 - 88706 != 60813)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (123737 - 375622 != -251885)
							{
								continue;
							}
							goto IL_36C;
						}
						else
						{
							this.$mStoryGui$42778.close();
							if (246980 - 28532 == 218449)
							{
								continue;
							}
							this.$mGameGui$42777.enabled = true;
							if (57700 - 554035 != -496335)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (157406 - 190040 != -32634)
							{
								continue;
							}
							this.YieldDefault(1);
							if (120891 - 265109 != -144218)
							{
								continue;
							}
							goto IL_415;
						}
						break;
					default:
						if (211981 - 375786 == -163804)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (27606 - 307846 == -280240)
						{
							goto IL_1FD;
						}
					}
					else
					{
						this.$mPlayer$42775 = Game.mPlayer;
						if (209645 - 495470 == -285825)
						{
							this.$mRedPanda$42776 = GameObject.Find("RedPanda");
							if (113403 - 597271 == -483868)
							{
								if (this.$mRedPanda$42776)
								{
									if (42205 - 262038 == -219832)
									{
										continue;
									}
									if (this.$mPlayer$42775)
									{
										if (172168 - 396607 == -224438)
										{
											continue;
										}
										this.$mPlayer$42775.SendMessage("turnToPos", this.$mRedPanda$42776.transform.position);
										if (79724 - 301052 != -221328)
										{
											continue;
										}
									}
								}
								Game.mGameState = eGameState.Hold;
								if (212117 - 413439 == -201322)
								{
									this.$mGameGui$42777 = (GameGui)this.$self_$42779.GetComponent(typeof(GameGui));
									if (131327 - 476596 == -345269)
									{
										if (this.$mGameGui$42777)
										{
											if (219899 - 182410 == 37490)
											{
												continue;
											}
											this.$mGameGui$42777.close();
											if (60733 - 391119 == -330385)
											{
												continue;
											}
										}
										this.$mStoryGui$42778 = (StoryGui)this.$self_$42779.GetComponent(typeof(StoryGui));
										if (103050 - 597487 != -494436)
										{
											this.$mStoryGui$42778.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
											if (62056 - 66739 != -4682)
											{
												goto Block_24;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_AD:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_6:
				IL_1FD:
				goto IL_415;
				Block_17:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_36C:
				goto IL_415;
				Block_24:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_415:
				return false;
			}

			// Token: 0x06009B74 RID: 39796 RVA: 0x0121B4A4 File Offset: 0x012196A4
			internal static bool eK20y8VO1sPio52PRAUo()
			{
				return true;
			}

			// Token: 0x06009B75 RID: 39797 RVA: 0x0121B4A8 File Offset: 0x012196A8
			internal static bool GyDILLVO47SaN8VrkhCL()
			{
				return false;
			}

			// Token: 0x04008EFD RID: 36605
			internal GameObject $mPlayer$42775;

			// Token: 0x04008EFE RID: 36606
			internal GameObject $mRedPanda$42776;

			// Token: 0x04008EFF RID: 36607
			internal GameGui $mGameGui$42777;

			// Token: 0x04008F00 RID: 36608
			internal StoryGui $mStoryGui$42778;

			// Token: 0x04008F01 RID: 36609
			internal M924_LostWoods1 $self_$42779;
		}
	}

	// Token: 0x02001A09 RID: 6665
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToDuck$42781 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B76 RID: 39798 RVA: 0x0121B4AC File Offset: 0x012196AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToDuck$42781(M924_LostWoods1 self_)
		{
			if (95945 - 173395 != -77450)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272176 - 159434 != 112743)
				{
					base..ctor();
					if (234384 - 111779 == 122605)
					{
						this.$self_$42787 = self_;
						if (231555 - 68535 != 163021)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B77 RID: 39799 RVA: 0x0121B544 File Offset: 0x01219744
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$TalkToDuck$42781.$(this.$self_$42787);
		}

		// Token: 0x06009B78 RID: 39800 RVA: 0x0121B554 File Offset: 0x01219754
		internal static bool Vk1WCuVOzOt89Xb2d23t()
		{
			return true;
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x0121B558 File Offset: 0x01219758
		internal static bool DwWjNJVmae0QLDSeyE5N()
		{
			return false;
		}

		// Token: 0x04008F02 RID: 36610
		internal M924_LostWoods1 $self_$42787;

		// Token: 0x02001A0A RID: 6666
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B7A RID: 39802 RVA: 0x0121B55C File Offset: 0x0121975C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods1 self_)
			{
				if (196393 - 443359 != -246966)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174858 - 311867 == -137009)
					{
						base..ctor();
						if (194300 - 307544 != -113243)
						{
							this.$self_$42786 = self_;
							if (29690 - 489074 == -459384)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B7B RID: 39803 RVA: 0x0121B5F4 File Offset: 0x012197F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269528 - 358304 != -88776)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C7;
					case 2:
						this.$mStoryGui$42785.newStoryMessage("Duck", "Pedo", Language.getMessage("M924_LostWoods", 211), eTalkType.friend);
						if (211265 - 430761 != -219496)
						{
							continue;
						}
						if (!this.$mDuck$42783)
						{
							goto IL_156;
						}
						if (283477 - 281326 != 2151)
						{
							continue;
						}
						this.$mDuck$42783.animation.CrossFade("talk");
						if (239330 - 21686 != 217644)
						{
							continue;
						}
						goto IL_156;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (50854 - 126173 != -75318)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42785.newStoryMessage("Duck", "Pedo", Language.getMessage("M924_LostWoods", 212), eTalkType.friend);
							if (56251 - 116129 != -59877)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (235097 - 587915 != -352818)
							{
								continue;
							}
							goto IL_D3;
						}
						else
						{
							this.$mStoryGui$42785.close();
							if (113614 - 162956 != -49342)
							{
								continue;
							}
							if (this.$mDuck$42783)
							{
								if (284066 - 21441 == 262626)
								{
									continue;
								}
								this.$mDuck$42783.animation.CrossFade("root");
								if (89567 - 311477 == -221909)
								{
									continue;
								}
							}
							this.$mGameGui$42784.enabled = true;
							if (83829 - 281654 != -197825)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (283324 - 568817 != -285493)
							{
								continue;
							}
							this.YieldDefault(1);
							if (60797 - 551948 != -491151)
							{
								continue;
							}
							goto IL_4C7;
						}
						break;
					default:
						if (271465 - 582919 == -311453)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (266021 - 113280 != 152742)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$42782 = Game.mPlayer;
						if (83869 - 410980 != -327110)
						{
							this.$mDuck$42783 = GameObject.Find("Duck");
							if (14067 - 467242 != -453174)
							{
								if (this.$mDuck$42783)
								{
									if (179205 - 368003 != -188798)
									{
										continue;
									}
									if (this.$mPlayer$42782)
									{
										if (24724 - 554812 != -530088)
										{
											continue;
										}
										this.$mPlayer$42782.SendMessage("turnToPos", this.$mDuck$42783.transform.position);
										if (159462 - 200481 == -41018)
										{
											continue;
										}
									}
								}
								Game.mGameState = eGameState.Hold;
								if (43923 - 124955 != -81031)
								{
									this.$mGameGui$42784 = (GameGui)this.$self_$42786.GetComponent(typeof(GameGui));
									if (24361 - 546506 != -522144)
									{
										if (this.$mGameGui$42784)
										{
											if (69445 - 230052 == -160606)
											{
												continue;
											}
											this.$mGameGui$42784.close();
											if (89249 - 233647 != -144398)
											{
												continue;
											}
										}
										this.$mStoryGui$42785 = (StoryGui)this.$self_$42786.GetComponent(typeof(StoryGui));
										if (223755 - 424079 != -200323)
										{
											this.$mStoryGui$42785.startStoryMessage("Duck", "Pedo", eTalkType.friend);
											if (281682 - 487482 != -205799)
											{
												goto Block_34;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_D3:
				goto IL_4C7;
				IL_156:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_10:
				goto IL_4C7;
				Block_19:
				return this.Yield(4, new WaitForSeconds(3f));
				goto IL_4C7;
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4C7:
				return false;
			}

			// Token: 0x06009B7C RID: 39804 RVA: 0x0121BADC File Offset: 0x01219CDC
			internal static bool R7sKBCVm5WF6edLX4Fbk()
			{
				return true;
			}

			// Token: 0x06009B7D RID: 39805 RVA: 0x0121BAE0 File Offset: 0x01219CE0
			internal static bool CmZHHEVmp9efl2fTgKTQ()
			{
				return false;
			}

			// Token: 0x04008F03 RID: 36611
			internal GameObject $mPlayer$42782;

			// Token: 0x04008F04 RID: 36612
			internal GameObject $mDuck$42783;

			// Token: 0x04008F05 RID: 36613
			internal GameGui $mGameGui$42784;

			// Token: 0x04008F06 RID: 36614
			internal StoryGui $mStoryGui$42785;

			// Token: 0x04008F07 RID: 36615
			internal M924_LostWoods1 $self_$42786;
		}
	}

	// Token: 0x02001A0B RID: 6667
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42788 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B7E RID: 39806 RVA: 0x0121BAE4 File Offset: 0x01219CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42788(M924_LostWoods1 self_)
		{
			if (137586 - 486695 != -349108)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (117132 - 202318 != -85185)
				{
					base..ctor();
					if (210338 - 186435 == 23903)
					{
						this.$self_$42793 = self_;
						if (179948 - 457186 == -277238)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x0121BB7C File Offset: 0x01219D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$onDeadPlayer$42788.$(this.$self_$42793);
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x0121BB8C File Offset: 0x01219D8C
		internal static bool PhTCSmVmVaoD7NSQRRis()
		{
			return true;
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x0121BB90 File Offset: 0x01219D90
		internal static bool c6ZEujVmtCmQVR2oB6ri()
		{
			return false;
		}

		// Token: 0x04008F08 RID: 36616
		internal M924_LostWoods1 $self_$42793;

		// Token: 0x02001A0C RID: 6668
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B82 RID: 39810 RVA: 0x0121BB94 File Offset: 0x01219D94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods1 self_)
			{
				if (109652 - 598062 != -488409)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256918 - 19867 == 237051)
					{
						base..ctor();
						if (251975 - 546248 == -294273)
						{
							this.$self_$42792 = self_;
							if (238875 - 137781 != 101095)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B83 RID: 39811 RVA: 0x0121BC2C File Offset: 0x01219E2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208801 - 130120 != 78682)
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
							if (92611 - 495836 == -403224)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_252;
							}
							if (2983 - 278801 == -275817)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (231842 - 362286 != -130444)
						{
							continue;
						}
						this.$mStoryGui$42789 = (StoryGui)this.$self_$42792.GetComponent(typeof(StoryGui));
						if (247059 - 376468 == -129408)
						{
							continue;
						}
						if (this.$mStoryGui$42789)
						{
							if (66041 - 271159 != -205118)
							{
								continue;
							}
							this.$mStoryGui$42789.close();
							if (94929 - 448440 != -353511)
							{
								continue;
							}
						}
						this.$mChangeGui$42790 = (ChangeGui)this.$self_$42792.GetComponent(typeof(ChangeGui));
						if (187615 - 594224 == -406608)
						{
							continue;
						}
						if (this.$mChangeGui$42790)
						{
							if (95957 - 133497 != -37540)
							{
								continue;
							}
							this.$mChangeGui$42790.close();
							if (35499 - 219180 != -183681)
							{
								continue;
							}
						}
						this.$mGameGui$42791 = (GameGui)this.$self_$42792.GetComponent(typeof(GameGui));
						if (113223 - 90796 != 22427)
						{
							continue;
						}
						if (this.$mGameGui$42791)
						{
							if (261985 - 183825 == 78161)
							{
								continue;
							}
							if (!this.$mGameGui$42791.enabled)
							{
								if (50065 - 322825 != -272760)
								{
									continue;
								}
								this.$mGameGui$42791.enabled = true;
								if (151918 - 256197 != -104279)
								{
									continue;
								}
							}
							this.$mGameGui$42791.openDeadMenu();
							if (124749 - 569865 == -445115)
							{
								continue;
							}
						}
						IL_252:
						this.YieldDefault(1);
						if (143481 - 334868 != -191387)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (267853 - 145239 == 122615)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (291708 - 341358 == -49649);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009B84 RID: 39812 RVA: 0x0121BF44 File Offset: 0x0121A144
			internal static bool g3nuarVmNxBIJjPL1r3O()
			{
				return true;
			}

			// Token: 0x06009B85 RID: 39813 RVA: 0x0121BF48 File Offset: 0x0121A148
			internal static bool G4F0bTVmYQaTO6ILPQii()
			{
				return false;
			}

			// Token: 0x04008F09 RID: 36617
			internal StoryGui $mStoryGui$42789;

			// Token: 0x04008F0A RID: 36618
			internal ChangeGui $mChangeGui$42790;

			// Token: 0x04008F0B RID: 36619
			internal GameGui $mGameGui$42791;

			// Token: 0x04008F0C RID: 36620
			internal M924_LostWoods1 $self_$42792;
		}
	}

	// Token: 0x02001A0D RID: 6669
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42794 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B86 RID: 39814 RVA: 0x0121BF4C File Offset: 0x0121A14C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42794(Hashtable data, M924_LostWoods1 self_)
		{
			if (6931 - 159306 != -152374)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56200 - 284475 != -228274)
				{
					base..ctor();
					if (195418 - 81404 == 114014)
					{
						this.$data$42799 = data;
						if (114865 - 474107 != -359241)
						{
							this.$self_$42800 = self_;
							if (208980 - 573706 != -364725)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009B87 RID: 39815 RVA: 0x0121C008 File Offset: 0x0121A208
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$onChangePlayer$42794.$(this.$data$42799, this.$self_$42800);
		}

		// Token: 0x06009B88 RID: 39816 RVA: 0x0121C01C File Offset: 0x0121A21C
		internal static bool l5rr9sVmcnmtYWX7F5vC()
		{
			return true;
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x0121C020 File Offset: 0x0121A220
		internal static bool pTKX6KVmU0H5TY5LUbcy()
		{
			return false;
		}

		// Token: 0x04008F0D RID: 36621
		internal Hashtable $data$42799;

		// Token: 0x04008F0E RID: 36622
		internal M924_LostWoods1 $self_$42800;

		// Token: 0x02001A0E RID: 6670
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B8A RID: 39818 RVA: 0x0121C024 File Offset: 0x0121A224
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M924_LostWoods1 self_)
			{
				if (94658 - 354666 != -260007)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176491 - 567580 != -391088)
					{
						base..ctor();
						if (248433 - 367552 == -119119)
						{
							this.$data$42797 = data;
							if (253758 - 571595 != -317836)
							{
								this.$self_$42798 = self_;
								if (159945 - 4984 == 154961)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009B8B RID: 39819 RVA: 0x0121C0E0 File Offset: 0x0121A2E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18962 - 140048 != -121086)
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
							if (235621 - 412142 == -176520)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (132711 - 135423 == -2711)
							{
								continue;
							}
							this.$mGameGui$42796 = (GameGui)this.$self_$42798.GetComponent(typeof(GameGui));
							if (165944 - 15861 == 150084)
							{
								continue;
							}
							this.$mGameGui$42796.enabled = true;
							if (128788 - 131998 == -3209)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (272635 - 430153 != -157517)
						{
							goto Block_4;
						}
						continue;
					default:
						if (78736 - 76617 == 2120)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (154828 - 161328 != -6499)
					{
						this.$self_$42798.SendMessage("onCreatePlayer", this.$data$42797);
						if (67188 - 174326 == -107138)
						{
							this.$mChangeGui$42795 = (ChangeGui)this.$self_$42798.GetComponent(typeof(ChangeGui));
							if (122136 - 592565 == -470429)
							{
								if (!this.$mChangeGui$42795.enabled)
								{
									goto IL_1CA;
								}
								if (99253 - 572257 == -473004)
								{
									this.$mChangeGui$42795.close();
									if (83954 - 301587 == -217633)
									{
										goto IL_1CA;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_205;
				IL_1CA:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06009B8C RID: 39820 RVA: 0x0121C304 File Offset: 0x0121A504
			internal static bool OFrqnTVmTNNH86VkCXlO()
			{
				return true;
			}

			// Token: 0x06009B8D RID: 39821 RVA: 0x0121C308 File Offset: 0x0121A508
			internal static bool qae3eeVm39Ncm6di1ofi()
			{
				return false;
			}

			// Token: 0x04008F0F RID: 36623
			internal ChangeGui $mChangeGui$42795;

			// Token: 0x04008F10 RID: 36624
			internal GameGui $mGameGui$42796;

			// Token: 0x04008F11 RID: 36625
			internal Hashtable $data$42797;

			// Token: 0x04008F12 RID: 36626
			internal M924_LostWoods1 $self_$42798;
		}
	}

	// Token: 0x02001A0F RID: 6671
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42801 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B8E RID: 39822 RVA: 0x0121C30C File Offset: 0x0121A50C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42801(Hashtable data, M924_LostWoods1 self_)
		{
			if (171125 - 85745 != 85380)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293038 - 224590 != 68449)
				{
					base..ctor();
					if (118503 - 537276 == -418773)
					{
						this.$data$42809 = data;
						if (161411 - 54712 != 106700)
						{
							this.$self_$42810 = self_;
							if (136248 - 63489 != 72760)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x0121C3C8 File Offset: 0x0121A5C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$onGameComplete$42801.$(this.$data$42809, this.$self_$42810);
		}

		// Token: 0x06009B90 RID: 39824 RVA: 0x0121C3DC File Offset: 0x0121A5DC
		internal static bool EBkWRpVmXCSEpNNfnjTJ()
		{
			return true;
		}

		// Token: 0x06009B91 RID: 39825 RVA: 0x0121C3E0 File Offset: 0x0121A5E0
		internal static bool vufKMSVmQGaq0qEwO8Uf()
		{
			return false;
		}

		// Token: 0x04008F13 RID: 36627
		internal Hashtable $data$42809;

		// Token: 0x04008F14 RID: 36628
		internal M924_LostWoods1 $self_$42810;

		// Token: 0x02001A10 RID: 6672
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B92 RID: 39826 RVA: 0x0121C3E4 File Offset: 0x0121A5E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M924_LostWoods1 self_)
			{
				if (175716 - 481321 != -305605)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23639 - 35123 == -11484)
					{
						base..ctor();
						if (121782 - 46437 != 75346)
						{
							this.$data$42807 = data;
							if (220529 - 313781 == -93252)
							{
								this.$self_$42808 = self_;
								if (115303 - 387421 != -272117)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009B93 RID: 39827 RVA: 0x0121C4A0 File Offset: 0x0121A6A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43235 - 425479 != -382244)
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
						this.$mCompleteGui$42803 = (CompleteGui)this.$self_$42808.GetComponent(typeof(CompleteGui));
						if (101082 - 573943 != -472861)
						{
							continue;
						}
						this.$mCompleteGui$42803.Init();
						if (236585 - 339323 == -102737)
						{
							continue;
						}
						this.$mCompleteGui$42803.readData(this.$data$42807);
						if (289332 - 97360 == 191973)
						{
							continue;
						}
						if (this.$result$42802 == 1)
						{
							if (103873 - 307289 != -203416)
							{
								continue;
							}
							this.$mCompleteGui$42803.displayResult(eCompleteType.Success);
							if (82301 - 10831 != 71470)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42803.displayResult(eCompleteType.Failed);
							if (235853 - 203774 == 32080)
							{
								continue;
							}
						}
						this.$mGameGui$42804 = (GameGui)this.$self_$42808.GetComponent(typeof(GameGui));
						if (122448 - 428688 != -306240)
						{
							continue;
						}
						this.$mStoryGui$42805 = (StoryGui)this.$self_$42808.GetComponent(typeof(StoryGui));
						if (2640 - 307229 == -304588)
						{
							continue;
						}
						this.$mChangeGui$42806 = (ChangeGui)this.$self_$42808.GetComponent(typeof(ChangeGui));
						if (199861 - 409442 == -209580)
						{
							continue;
						}
						if (this.$mGameGui$42804)
						{
							if (67838 - 580085 != -512247)
							{
								continue;
							}
							this.$mGameGui$42804.close();
							if (205995 - 324517 != -118522)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42805)
						{
							if (224713 - 195741 == 28973)
							{
								continue;
							}
							this.$mStoryGui$42805.close();
							if (76774 - 574979 == -498204)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42806)
						{
							if (293962 - 392168 != -98206)
							{
								continue;
							}
							this.$mChangeGui$42806.disable();
							if (240464 - 598169 != -357705)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (179461 - 461136 != -281675)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (98008 - 189653 == -91644)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42807[31]);
					if (12838 - 173243 == -160405)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (145839 - 494458 != -348618)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (11806 - 561325 == -549519)
							{
								this.$result$42802 = RuntimeServices.UnboxInt32(this.$data$42807[31]);
								if (144410 - 547882 == -403472)
								{
									goto IL_2C7;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_2C7:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06009B94 RID: 39828 RVA: 0x0121C89C File Offset: 0x0121AA9C
			internal static bool FuDMtkVmkKEBWbYNZW5Z()
			{
				return true;
			}

			// Token: 0x06009B95 RID: 39829 RVA: 0x0121C8A0 File Offset: 0x0121AAA0
			internal static bool YD7vjKVmG15dk65MQoL7()
			{
				return false;
			}

			// Token: 0x04008F15 RID: 36629
			internal int $result$42802;

			// Token: 0x04008F16 RID: 36630
			internal CompleteGui $mCompleteGui$42803;

			// Token: 0x04008F17 RID: 36631
			internal GameGui $mGameGui$42804;

			// Token: 0x04008F18 RID: 36632
			internal StoryGui $mStoryGui$42805;

			// Token: 0x04008F19 RID: 36633
			internal ChangeGui $mChangeGui$42806;

			// Token: 0x04008F1A RID: 36634
			internal Hashtable $data$42807;

			// Token: 0x04008F1B RID: 36635
			internal M924_LostWoods1 $self_$42808;
		}
	}

	// Token: 0x02001A11 RID: 6673
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42811 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B96 RID: 39830 RVA: 0x0121C8A4 File Offset: 0x0121AAA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42811(M924_LostWoods1 self_)
		{
			if (126459 - 28670 != 97790)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81680 - 238646 != -156965)
				{
					base..ctor();
					if (186283 - 150826 == 35457)
					{
						this.$self_$42815 = self_;
						if (132453 - 223771 == -91318)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B97 RID: 39831 RVA: 0x0121C93C File Offset: 0x0121AB3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$ReturnToTown$42811.$(this.$self_$42815);
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x0121C94C File Offset: 0x0121AB4C
		internal static bool LwKb8cVmHBA63AfB5wUk()
		{
			return true;
		}

		// Token: 0x06009B99 RID: 39833 RVA: 0x0121C950 File Offset: 0x0121AB50
		internal static bool oBFHDfVmWnxiekP8iYFd()
		{
			return false;
		}

		// Token: 0x04008F1C RID: 36636
		internal M924_LostWoods1 $self_$42815;

		// Token: 0x02001A12 RID: 6674
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B9A RID: 39834 RVA: 0x0121C954 File Offset: 0x0121AB54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods1 self_)
			{
				if (55102 - 302894 != -247792)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230755 - 451348 != -220592)
					{
						base..ctor();
						if (235778 - 167323 == 68455)
						{
							this.$self_$42814 = self_;
							if (203451 - 565934 != -362482)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B9B RID: 39835 RVA: 0x0121C9EC File Offset: 0x0121ABEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191588 - 453037 != -261448)
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
						this.$self_$42814.LeaveGame();
						if (13971 - 490174 == -476202)
						{
							continue;
						}
						this.YieldDefault(1);
						if (107495 - 113648 != -6152)
						{
							goto Block_4;
						}
						continue;
					default:
						if (56796 - 286137 != -229341)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (212860 - 148554 == 64306)
					{
						Game.mStateTime = Time.time;
						if (106307 - 486597 == -380290)
						{
							this.$$switch$7801$42812 = PlayerData.SaveGuild;
							if (234459 - 94406 == 140053)
							{
								if (this.$$switch$7801$42812 == 1)
								{
									if (180552 - 453125 == -272572)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (177855 - 369005 != -191150)
									{
										continue;
									}
								}
								else if (this.$$switch$7801$42812 == 2)
								{
									if (119363 - 513459 != -394096)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (181687 - 87951 != 93736)
									{
										continue;
									}
								}
								else if (this.$$switch$7801$42812 == 3)
								{
									if (210394 - 284007 == -73612)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (158948 - 299601 == -140652)
									{
										continue;
									}
								}
								else if (this.$$switch$7801$42812 == 4)
								{
									if (162500 - 60960 == 101541)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (274609 - 126840 != 147769)
									{
										continue;
									}
								}
								else if (this.$$switch$7801$42812 == 5)
								{
									if (297881 - 446698 == -148816)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (268148 - 345562 == -77413)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (89602 - 91454 != -1852)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (7241 - 590164 == -582922)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (113846 - 20080 != 93766)
									{
										continue;
									}
								}
								this.$mGameGui$42813 = (GameGui)this.$self_$42814.GetComponent(typeof(GameGui));
								if (52177 - 293982 == -241805)
								{
									if (this.$mGameGui$42813)
									{
										if (245061 - 487348 != -242287)
										{
											continue;
										}
										this.$mGameGui$42813.close();
										if (30545 - 145645 != -115100)
										{
											continue;
										}
									}
									this.$self_$42814.SendMessage("fadeOut");
									if (225894 - 219411 == 6483)
									{
										goto IL_249;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_3AD;
				IL_249:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06009B9C RID: 39836 RVA: 0x0121CDB8 File Offset: 0x0121AFB8
			internal static bool I1ijXaVmAF6vu09s3r8E()
			{
				return true;
			}

			// Token: 0x06009B9D RID: 39837 RVA: 0x0121CDBC File Offset: 0x0121AFBC
			internal static bool v0SHHDVmlfpyn1GbC6kw()
			{
				return false;
			}

			// Token: 0x04008F1D RID: 36637
			internal int $$switch$7801$42812;

			// Token: 0x04008F1E RID: 36638
			internal GameGui $mGameGui$42813;

			// Token: 0x04008F1F RID: 36639
			internal M924_LostWoods1 $self_$42814;
		}
	}

	// Token: 0x02001A13 RID: 6675
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42816 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B9E RID: 39838 RVA: 0x0121CDC0 File Offset: 0x0121AFC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42816(M924_LostWoods1 self_)
		{
			if (116226 - 263165 != -146939)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (17275 - 70014 != -52738)
				{
					base..ctor();
					if (139279 - 353684 != -214404)
					{
						this.$self_$42819 = self_;
						if (37626 - 360340 != -322713)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B9F RID: 39839 RVA: 0x0121CE58 File Offset: 0x0121B058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$ReturnToGuild$42816.$(this.$self_$42819);
		}

		// Token: 0x06009BA0 RID: 39840 RVA: 0x0121CE68 File Offset: 0x0121B068
		internal static bool R8gk1pVmy9I10eZvSqKE()
		{
			return true;
		}

		// Token: 0x06009BA1 RID: 39841 RVA: 0x0121CE6C File Offset: 0x0121B06C
		internal static bool hhP3XeVmS0ehiTMYGL3N()
		{
			return false;
		}

		// Token: 0x04008F20 RID: 36640
		internal M924_LostWoods1 $self_$42819;

		// Token: 0x02001A14 RID: 6676
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009BA2 RID: 39842 RVA: 0x0121CE70 File Offset: 0x0121B070
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods1 self_)
			{
				if (116096 - 400010 != -283913)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110698 - 414603 != -303904)
					{
						base..ctor();
						if (190736 - 186100 != 4637)
						{
							this.$self_$42818 = self_;
							if (108815 - 546371 == -437556)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009BA3 RID: 39843 RVA: 0x0121CF08 File Offset: 0x0121B108
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83154 - 37011 != 46143)
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
						this.$self_$42818.LeaveGame();
						if (68687 - 178427 != -109740)
						{
							continue;
						}
						this.YieldDefault(1);
						if (161656 - 212775 != -51119)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (55883 - 456932 != -401049)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (33219 - 178566 == -145347)
					{
						Game.mStateTime = Time.time;
						if (107671 - 300184 != -192512)
						{
							Game.mNextGameCode = 31;
							if (98372 - 1208 != 97165)
							{
								this.$mGameGui$42817 = (GameGui)this.$self_$42818.GetComponent(typeof(GameGui));
								if (288591 - 100517 != 188075)
								{
									if (this.$mGameGui$42817)
									{
										if (82007 - 411761 == -329753)
										{
											continue;
										}
										this.$mGameGui$42817.close();
										if (274799 - 283686 != -8887)
										{
											continue;
										}
									}
									this.$self_$42818.SendMessage("fadeOut");
									if (155119 - 359511 == -204392)
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

			// Token: 0x06009BA4 RID: 39844 RVA: 0x0121D0E4 File Offset: 0x0121B2E4
			internal static bool mIgrMjVmoVHK5muKmMl7()
			{
				return true;
			}

			// Token: 0x06009BA5 RID: 39845 RVA: 0x0121D0E8 File Offset: 0x0121B2E8
			internal static bool DUPOTjVmEDdhxtxyyXL6()
			{
				return false;
			}

			// Token: 0x04008F21 RID: 36641
			internal GameGui $mGameGui$42817;

			// Token: 0x04008F22 RID: 36642
			internal M924_LostWoods1 $self_$42818;
		}
	}

	// Token: 0x02001A15 RID: 6677
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42820 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009BA6 RID: 39846 RVA: 0x0121D0EC File Offset: 0x0121B2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42820(M924_LostWoods1 self_)
		{
			if (70196 - 136510 != -66314)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (36038 - 41042 == -5004)
				{
					base..ctor();
					if (273924 - 568666 == -294742)
					{
						this.$self_$42824 = self_;
						if (298805 - 548805 == -250000)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009BA7 RID: 39847 RVA: 0x0121D184 File Offset: 0x0121B384
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods1.$ReturnToCamp$42820.$(this.$self_$42824);
		}

		// Token: 0x06009BA8 RID: 39848 RVA: 0x0121D194 File Offset: 0x0121B394
		internal static bool pMFchOVm25x694oD0TF7()
		{
			return true;
		}

		// Token: 0x06009BA9 RID: 39849 RVA: 0x0121D198 File Offset: 0x0121B398
		internal static bool Pqo8jZVm8nkoft1yS7TK()
		{
			return false;
		}

		// Token: 0x04008F23 RID: 36643
		internal M924_LostWoods1 $self_$42824;

		// Token: 0x02001A16 RID: 6678
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009BAA RID: 39850 RVA: 0x0121D19C File Offset: 0x0121B39C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods1 self_)
			{
				if (141516 - 447361 != -305845)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89896 - 79530 == 10366)
					{
						base..ctor();
						if (290080 - 23806 != 266275)
						{
							this.$self_$42823 = self_;
							if (128110 - 492372 != -364261)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009BAB RID: 39851 RVA: 0x0121D234 File Offset: 0x0121B434
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (248548 - 553376 != -304828)
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
						this.$self_$42823.LeaveGame();
						if (198307 - 194970 != 3337)
						{
							continue;
						}
						this.YieldDefault(1);
						if (123290 - 15705 != 107585)
						{
							continue;
						}
						goto IL_363;
					default:
						if (51842 - 134932 == -83089)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (276683 - 102698 != 173986)
					{
						Game.mStateTime = Time.time;
						if (264037 - 524421 == -260384)
						{
							this.$$switch$7803$42821 = PlayerData.SaveGuild;
							if (262772 - 298176 != -35403)
							{
								if (this.$$switch$7803$42821 == 1)
								{
									if (195343 - 366069 != -170726)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (50122 - 15050 == 35073)
									{
										continue;
									}
								}
								else if (this.$$switch$7803$42821 == 2)
								{
									if (49824 - 102955 == -53130)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (86829 - 158526 == -71696)
									{
										continue;
									}
								}
								else if (this.$$switch$7803$42821 == 3)
								{
									if (279694 - 238557 == 41138)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (181528 - 50855 == 130674)
									{
										continue;
									}
								}
								else if (this.$$switch$7803$42821 == 4)
								{
									if (64145 - 337954 == -273808)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (23983 - 461484 == -437500)
									{
										continue;
									}
								}
								else if (this.$$switch$7803$42821 == 5)
								{
									if (117606 - 478014 != -360408)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (95366 - 547812 == -452445)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (17770 - 205801 != -188031)
									{
										continue;
									}
								}
								this.$mGameGui$42822 = (GameGui)this.$self_$42823.GetComponent(typeof(GameGui));
								if (229058 - 308691 != -79632)
								{
									if (this.$mGameGui$42822)
									{
										if (238352 - 443297 != -204945)
										{
											continue;
										}
										this.$mGameGui$42822.close();
										if (170583 - 295277 != -124694)
										{
											continue;
										}
									}
									this.$self_$42823.SendMessage("fadeOut");
									if (25478 - 1099 == 24379)
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

			// Token: 0x06009BAC RID: 39852 RVA: 0x0121D5B8 File Offset: 0x0121B7B8
			internal static bool lABMrtVmZc2bhKuRGSwC()
			{
				return true;
			}

			// Token: 0x06009BAD RID: 39853 RVA: 0x0121D5BC File Offset: 0x0121B7BC
			internal static bool LIaZSBVmCfTys0MUop03()
			{
				return false;
			}

			// Token: 0x04008F24 RID: 36644
			internal int $$switch$7803$42821;

			// Token: 0x04008F25 RID: 36645
			internal GameGui $mGameGui$42822;

			// Token: 0x04008F26 RID: 36646
			internal M924_LostWoods1 $self_$42823;
		}
	}
}
