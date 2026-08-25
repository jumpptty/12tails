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

// Token: 0x02001647 RID: 5703
[Serializable]
public class M603_ShadeInTheCity1 : MonoBehaviour
{
	// Token: 0x0600845D RID: 33885 RVA: 0x010A4040 File Offset: 0x010A2240
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M603_ShadeInTheCity1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600845E RID: 33886 RVA: 0x010A4050 File Offset: 0x010A2250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (51060 - 502512 != -451451)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (272114 - 192151 == 79963)
			{
				Game.mGameType = 5;
				if (203375 - 540542 == -337167)
				{
					if (Chat.Initialized)
					{
						if (268116 - 51951 == 216166)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (132101 - 456858 != -324757)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (71521 - 305614 != -234093)
						{
							continue;
						}
					}
					this.xJwcWE52f4m = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (174767 - 544827 != -370059)
					{
						this.dVTcWPg8Y85 = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (7932 - 302012 != -294079)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600845F RID: 33887 RVA: 0x010A41A8 File Offset: 0x010A23A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (102379 - 269185 != -166805)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (295877 - 158908 == 136969)
				{
					if (Game.mNextGameCode != 603)
					{
						break;
					}
					if (74688 - 57229 == 17459)
					{
						Game.nextGame();
						if (156979 - 235286 != -78306)
						{
							Game.mGameCode = 603;
							if (91308 - 255793 != -164484)
							{
								Game.mGameType = 5;
								if (85336 - 189093 != -103756)
								{
									Game.mGameTime = Time.time;
									if (227223 - 14276 != 212948)
									{
										Game.mGameScore = 0;
										if (138067 - 359309 != -221241)
										{
											Game.mGameMana = 0;
											if (45005 - 514868 != -469862)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (255794 - 453861 != -198066)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (278277 - 35916 != 242362)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (19581 - 174797 == -155216)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (259881 - 226713 == 33168)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (99730 - 354363 == -254633)
																{
																	this.XNrcWUwB1nS = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (105103 - 524522 != -419418)
																	{
																		this.ovTcWw1MjS5 = PhotonClient.Connection;
																		if (78731 - 365217 == -286486)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (99602 - 261634 != -162031)
																			{
																				this.InitGame();
																				if (190396 - 7189 != 183208)
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
				if (129124 - 25846 != 103279)
				{
					Game.mGameType = 99;
					if (123897 - 288639 == -164742)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008460 RID: 33888 RVA: 0x010A44B0 File Offset: 0x010A26B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (298662 - 425384 != -126721)
		{
		}
		for (;;)
		{
			if (this.ovTcWw1MjS5 == null)
			{
				if (126133 - 175934 == -49801)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (3104 - 285986 != -282881)
				{
					if (mGameState == eGameState.Init)
					{
						if (183754 - 410060 == -226306)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (260106 - 110548 == 149558)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (242017 - 438692 != -196674)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (26810 - 573254 == -546444)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (240569 - 517419 != -276849)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (99576 - 491678 == -392102)
						{
							if (Time.time > this.jcIcWNaDYsa)
							{
								if (235605 - 214412 == 21194)
								{
									continue;
								}
								Game.mGameMana++;
								if (45744 - 319921 != -274177)
								{
									continue;
								}
								this.jcIcWNaDYsa = Time.time + (float)12;
								if (127729 - 8906 == 118824)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (92605 - 496885 == -404279)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (187215 - 596646 != -409431)
									{
										continue;
									}
									this.audio.Play();
									if (90976 - 518557 == -427580)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (268770 - 435822 == -167052)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (2524 - 93789 != -91264)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (181064 - 383105 != -202040)
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
						if (181929 - 39454 == 142475)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008461 RID: 33889 RVA: 0x010A47B0 File Offset: 0x010A29B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (253874 - 261870 != -7995)
		{
		}
		for (;;)
		{
			if (!this.xJwcWE52f4m)
			{
				if (34602 - 514965 == -480363)
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
				if (22600 - 127733 != -105132)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (170741 - 477792 != -307050)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (95478 - 202605 != -107126)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (59235 - 409369 != -350133)
							{
								GUI.depth = 1;
								if (211019 - 542653 != -331633)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (180611 - 448091 != -267479)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (199297 - 474413 != -275115)
										{
											Color color = GUI.color;
											if (251861 - 571926 != -320064)
											{
												float num3 = color.a = a;
												if (190982 - 48317 != 142666)
												{
													if (128289 - 21574 == 106715)
													{
														Color color2 = GUI.color = color;
														if (142832 - 522868 == -380036 && 153223 - 552629 != -399405)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.xJwcWE52f4m);
															if (84711 - 474742 == -390031)
															{
																float a2 = 1f;
																if (71801 - 149031 != -77229)
																{
																	Color color3 = GUI.color;
																	if (221718 - 400462 == -178744)
																	{
																		color3.a = a2;
																		if (32347 - 146167 != -113819 && 183475 - 199952 != -16476)
																		{
																			Color color4 = GUI.color = color3;
																			if (26569 - 31045 == -4476)
																			{
																				if (200534 - 515726 == -315192)
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

	// Token: 0x06008462 RID: 33890 RVA: 0x010A4B30 File Offset: 0x010A2D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M603_ShadeInTheCity1.$onGameEvent$39684(data, this).GetEnumerator();
	}

	// Token: 0x06008463 RID: 33891 RVA: 0x010A4B40 File Offset: 0x010A2D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M603_ShadeInTheCity1.$StartEvent$39700(this).GetEnumerator();
	}

	// Token: 0x06008464 RID: 33892 RVA: 0x010A4B50 File Offset: 0x010A2D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitZone()
	{
		if (259251 - 453637 != -194386)
		{
		}
		for (;;)
		{
			if (this.UTucW0XBccc < 5)
			{
				if (247739 - 518730 == -270991)
				{
					this.SendMessage("newGameMessage", "Not all NPC in the area are saved!");
					if (155254 - 254275 != -99020)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(6031, 0);
				if (260103 - 317589 != -57485)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06008465 RID: 33893 RVA: 0x010A4C04 File Offset: 0x010A2E04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniCat()
	{
		return new M603_ShadeInTheCity1.$TalkToMiniCat$39704(this).GetEnumerator();
	}

	// Token: 0x06008466 RID: 33894 RVA: 0x010A4C14 File Offset: 0x010A2E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMouse()
	{
		return new M603_ShadeInTheCity1.$TalkToMouse$39711(this).GetEnumerator();
	}

	// Token: 0x06008467 RID: 33895 RVA: 0x010A4C24 File Offset: 0x010A2E24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWarthog()
	{
		return new M603_ShadeInTheCity1.$TalkToWarthog$39718(this).GetEnumerator();
	}

	// Token: 0x06008468 RID: 33896 RVA: 0x010A4C34 File Offset: 0x010A2E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToAlpaca()
	{
		return new M603_ShadeInTheCity1.$TalkToAlpaca$39725(this).GetEnumerator();
	}

	// Token: 0x06008469 RID: 33897 RVA: 0x010A4C44 File Offset: 0x010A2E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLemur()
	{
		return new M603_ShadeInTheCity1.$TalkToLemur$39732(this).GetEnumerator();
	}

	// Token: 0x0600846A RID: 33898 RVA: 0x010A4C54 File Offset: 0x010A2E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther()
	{
		return new M603_ShadeInTheCity1.$TalkToPanther$39739(this).GetEnumerator();
	}

	// Token: 0x0600846B RID: 33899 RVA: 0x010A4C64 File Offset: 0x010A2E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (254373 - 584436 != -330062)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (10079 - 198159 == -188080)
			{
				Hashtable customOpParameters = new Hashtable();
				if (224926 - 283854 != -58927)
				{
					this.ovTcWw1MjS5.OpCustom(52, customOpParameters, true);
					if (76589 - 301586 != -224996)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600846C RID: 33900 RVA: 0x010A4D0C File Offset: 0x010A2F0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (117357 - 270013 != -152656)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (39874 - 260556 != -220681)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (121791 - 269428 == -147637)
				{
					Game.mGameState = eGameState.Setup;
					if (153654 - 325973 != -172318)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600846D RID: 33901 RVA: 0x010A4DB0 File Offset: 0x010A2FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (244201 - 339720 != -95518)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (265103 - 91191 == 173912)
			{
				if (num == PlayerData.UID)
				{
					if (94919 - 276427 != -181507)
					{
						this.SetupActors();
						if (144754 - 505536 != -360781)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (228205 - 320442 != -92236)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600846E RID: 33902 RVA: 0x010A4E80 File Offset: 0x010A3080
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (40570 - 175693 != -135123)
		{
		}
		for (;;)
		{
			IL_C2:
			Debug.Log("Creating Actors");
			if (128102 - 439784 == -311682)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (180107 - 278130 != -98022)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (233964 - 501860 == -267896)
						{
							int i = 0;
							if (239216 - 135777 == 103439)
							{
								CharacterControl[] array2 = array;
								if (248398 - 44294 == 204104)
								{
									int length = array2.Length;
									if (114736 - 18814 != 95923)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (249221 - 564531 == -315309)
											{
												goto IL_C2;
											}
											if (type == "Shade1")
											{
												goto IL_1D3;
											}
											if (160 - 329561 != -329401)
											{
												goto IL_C2;
											}
											if (type == "Shade2")
											{
												if (177462 - 337332 != -159870)
												{
													goto IL_C2;
												}
												goto IL_1D3;
											}
											IL_1AB:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (98635 - 316211 != -217576)
											{
												goto IL_C2;
											}
											this.VBHcWouCbwG++;
											if (241604 - 458100 != -216496)
											{
												goto IL_C2;
											}
											i++;
											if (132065 - 541158 != -409092)
											{
												continue;
											}
											goto IL_C2;
											IL_1D3:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (249906 - 134525 != 115381)
											{
												goto IL_C2;
											}
											goto IL_1AB;
										}
										if (268749 - 12451 == 256298)
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
						if (203226 - 532404 == -329178)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600846F RID: 33903 RVA: 0x010A5120 File Offset: 0x010A3320
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (298129 - 233950 != 64180)
		{
		}
		for (;;)
		{
			IL_BE:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (36753 - 512669 != -475915)
			{
				int i = 0;
				if (150121 - 282294 != -132172)
				{
					CharacterControl[] array2 = array;
					if (218615 - 547053 != -328437)
					{
						int length = array2.Length;
						if (102199 - 318015 != -215815)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (238405 - 119470 == 118936)
								{
									goto IL_BE;
								}
								i++;
								if (188595 - 543828 != -355233)
								{
									goto IL_BE;
								}
							}
							if (184978 - 165906 != 19073)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008470 RID: 33904 RVA: 0x010A5250 File Offset: 0x010A3450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (81572 - 281882 != -200309)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (57 - 360546 == -360489)
			{
				Game.mGameState = eGameState.Ready;
				if (210422 - 503971 == -293549)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (138062 - 441118 == -303056 && 15418 - 589259 != -573840)
					{
						GameObject gameObject = null;
						if (287311 - 438124 == -150813)
						{
							GameObject gameObject2;
							if (playerSlot > 1)
							{
								if (121558 - 570749 == -449190)
								{
									continue;
								}
								if (playerSlot <= 6)
								{
									if (85823 - 583835 == -498011)
									{
										continue;
									}
									gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (234254 - 255712 == -21457)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (224100 - 198056 != 26045)
									{
										goto IL_12B;
									}
									continue;
								}
							}
							gameObject2 = GameObject.Find("StartPoint1");
							if (143730 - 74424 != 69306)
							{
								continue;
							}
							IL_12B:
							if (gameObject2)
							{
								if (64176 - 297489 == -233312)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
								if (32334 - 115647 == -83312)
								{
									continue;
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (97112 - 574406 != -477293)
							{
								this.transform.position = gameObject.transform.position;
								if (57186 - 354501 != -297314)
								{
									this.transform.rotation = gameObject.transform.rotation;
									if (61656 - 228112 == -166456)
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

	// Token: 0x06008471 RID: 33905 RVA: 0x010A54E0 File Offset: 0x010A36E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (270703 - 448150 != -177446)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (55760 - 471096 != -415335)
			{
				Game.mGameState = eGameState.Start;
				if (212660 - 118934 == 93726)
				{
					Game.mGameTime = Time.time;
					if (133906 - 12512 == 121394)
					{
						Game.mStateTime = Time.time;
						if (33087 - 186477 == -153390)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (239124 - 114369 == 124755)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008472 RID: 33906 RVA: 0x010A55CC File Offset: 0x010A37CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008473 RID: 33907 RVA: 0x010A55D0 File Offset: 0x010A37D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (239945 - 545061 != -305116)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (152900 - 173008 == -20108)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (79712 - 24062 == 55650)
				{
					hashtable.Add(43, PlayerData.UID);
					if (11824 - 237165 == -225341)
					{
						hashtable.Add(73, nType);
						if (42058 - 339415 != -297356)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (272695 - 500920 != -228224)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (3518 - 268162 == -264644)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (72813 - 135424 != -62610)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (125801 - 168428 != -42626)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (152038 - 89153 != 62886)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (92838 - 87374 == 5464)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (830 - 319454 != -318623)
													{
														this.ovTcWw1MjS5.OpCustom(63, hashtable, true);
														if (100982 - 594568 == -493586)
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

	// Token: 0x06008474 RID: 33908 RVA: 0x010A58B4 File Offset: 0x010A3AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (213410 - 420775 != -207364)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (212332 - 529864 == -317532)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (85404 - 286870 != -201465)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (22173 - 219334 != -197160)
						{
							if (this.VBHcWouCbwG <= 0)
							{
								break;
							}
							if (186032 - 494374 != -308341)
							{
								this.VBHcWouCbwG--;
								if (110727 - 137054 != -26326)
								{
									if (this.VBHcWouCbwG != 0)
									{
										break;
									}
									if (24722 - 404415 == -379693)
									{
										Game.setGameState(eGameState.Ready);
										if (184539 - 178447 != 6093)
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
						if (24779 - 157342 == -132563)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (30730 - 91146 != -60415)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008475 RID: 33909 RVA: 0x010A5A44 File Offset: 0x010A3C44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008476 RID: 33910 RVA: 0x010A5A58 File Offset: 0x010A3C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008477 RID: 33911 RVA: 0x010A5A6C File Offset: 0x010A3C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (113952 - 109515 != 4438)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (103684 - 490908 == -387224)
			{
				hashtable.Add(71, CID);
				if (180179 - 39372 != 140808)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (78134 - 519967 != -441832)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (225733 - 541160 == -315427)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (97639 - 340597 == -242958)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (21179 - 478571 != -457391)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (190668 - 91586 == 99082)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (18832 - 42488 != -23655)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (150461 - 4641 == 145820)
											{
												this.ovTcWw1MjS5.OpCustom(61, hashtable, true);
												if (195336 - 2875 != 192462)
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

	// Token: 0x06008478 RID: 33912 RVA: 0x010A5CF8 File Offset: 0x010A3EF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (97359 - 490216 != -392857)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (20175 - 540893 != -520717)
			{
				if (!gameObject)
				{
					break;
				}
				if (248980 - 296687 != -47706)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (100055 - 122855 == -22800)
					{
						playerCameraControl.target = gameObject;
						if (139940 - 95209 == 44731)
						{
							this.StartGame();
							if (61241 - 51837 != 9405)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008479 RID: 33913 RVA: 0x010A5DE8 File Offset: 0x010A3FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (26213 - 278507 != -252293)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (283822 - 51571 == 232251)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (293568 - 318186 == -24618)
				{
					gameGui.ResetTeamBar();
					if (209369 - 190289 == 19080)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600847A RID: 33914 RVA: 0x010A5E94 File Offset: 0x010A4094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M603_ShadeInTheCity1.$onDeadPlayer$39746(this).GetEnumerator();
	}

	// Token: 0x0600847B RID: 33915 RVA: 0x010A5EA4 File Offset: 0x010A40A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (97416 - 203641 != -106224)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (276326 - 414230 != -137903)
			{
				this.XNrcWUwB1nS.target = Game.mPlayer;
				if (288577 - 298853 == -10276)
				{
					this.XNrcWUwB1nS.enabled = true;
					if (17728 - 594783 != -577054)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (47155 - 77835 != -30680)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (222677 - 291307 != -68630)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (75351 - 511863 == -436512)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (112835 - 167117 == -54282)
							{
								if (!gameGui)
								{
									break;
								}
								if (181769 - 413630 == -231861)
								{
									gameGui.enabled = true;
									if (264585 - 364718 == -100133)
									{
										gameGui.closeDeadMenu();
										if (126205 - 415578 == -289373)
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

	// Token: 0x0600847C RID: 33916 RVA: 0x010A6050 File Offset: 0x010A4250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (259022 - 175674 != 83349)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (242189 - 190457 != 51733)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (74708 - 396211 == -321503)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (16874 - 121433 == -104559)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600847D RID: 33917 RVA: 0x010A6114 File Offset: 0x010A4314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600847E RID: 33918 RVA: 0x010A6140 File Offset: 0x010A4340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M603_ShadeInTheCity1.$onGameComplete$39752(data, this).GetEnumerator();
	}

	// Token: 0x0600847F RID: 33919 RVA: 0x010A6150 File Offset: 0x010A4350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M603_ShadeInTheCity1.$ReturnToTown$39761(this).GetEnumerator();
	}

	// Token: 0x06008480 RID: 33920 RVA: 0x010A6160 File Offset: 0x010A4360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M603_ShadeInTheCity1.$ReturnToGuild$39766(this).GetEnumerator();
	}

	// Token: 0x06008481 RID: 33921 RVA: 0x010A6170 File Offset: 0x010A4370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M603_ShadeInTheCity1.$ReturnToCamp$39770(this).GetEnumerator();
	}

	// Token: 0x06008482 RID: 33922 RVA: 0x010A6180 File Offset: 0x010A4380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (275351 - 352920 != -77568)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (34562 - 175315 == -140753)
			{
				Hashtable hashtable = new Hashtable();
				if (109189 - 420967 != -311777)
				{
					hashtable.Add(43, PlayerData.UID);
					if (48486 - 43742 == 4744)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (99355 - 292656 != -193300)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008483 RID: 33923 RVA: 0x010A6258 File Offset: 0x010A4458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008484 RID: 33924 RVA: 0x010A626C File Offset: 0x010A446C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (67401 - 440363 != -372961)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (996 - 60012 == -59016)
			{
				Hashtable hashtable = new Hashtable();
				if (3349 - 482043 == -478694)
				{
					if (Game.mNextGameCode == 30)
					{
						if (142759 - 391986 == -249226)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (201707 - 164567 == 37141)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (293931 - 399358 == -105426)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (38071 - 168953 == -130881)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (1685 - 464445 != -462760)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (79037 - 457637 == -378599)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (118665 - 394752 == -276086)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (283894 - 300067 == -16172)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (179860 - 238382 == -58521)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (15213 - 181750 != -166537)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (231148 - 49668 != 181480)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (185838 - 382115 == -196276)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (66818 - 2671 == 64148)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (218925 - 392599 != -173674)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (34881 - 108798 != -73917)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (152431 - 300634 != -148203)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (173175 - 319153 != -145978)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (150411 - 87775 == 62637)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (92479 - 2205 != 90274)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (13736 - 40491 != -26755)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (41344 - 558444 != -517100)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (288979 - 551402 != -262423)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (114616 - 192409 == -77792)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (269533 - 572272 != -302739)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (80386 - 376567 == -296180)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (30201 - 362899 == -332697)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (38844 - 50324 == -11479)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (43365 - 101661 == -58295)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (88939 - 235694 == -146755)
					{
						this.ovTcWw1MjS5.OpCustom(42, hashtable, true);
						if (154526 - 525658 != -371131)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008485 RID: 33925 RVA: 0x010A6820 File Offset: 0x010A4A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008486 RID: 33926 RVA: 0x010A6830 File Offset: 0x010A4A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008487 RID: 33927 RVA: 0x010A6834 File Offset: 0x010A4A34
	internal static bool n1SBRDp11VuVsxoJ4Ve8()
	{
		return true;
	}

	// Token: 0x06008488 RID: 33928 RVA: 0x010A6838 File Offset: 0x010A4A38
	internal static bool rb7sFCp14vSQvu8NtuED()
	{
		return false;
	}

	// Token: 0x0400818B RID: 33163
	private LitePeer ovTcWw1MjS5;

	// Token: 0x0400818C RID: 33164
	private PlayerCameraControl XNrcWUwB1nS;

	// Token: 0x0400818D RID: 33165
	private float jcIcWNaDYsa;

	// Token: 0x0400818E RID: 33166
	private Texture xJwcWE52f4m;

	// Token: 0x0400818F RID: 33167
	private AudioClip dVTcWPg8Y85;

	// Token: 0x04008190 RID: 33168
	private int zepcWSvW28L;

	// Token: 0x04008191 RID: 33169
	private int FWDcWBidFGO;

	// Token: 0x04008192 RID: 33170
	private int UTucW0XBccc;

	// Token: 0x04008193 RID: 33171
	private int QqAcW8j6VWf;

	// Token: 0x04008194 RID: 33172
	private int xpccWiBykLS;

	// Token: 0x04008195 RID: 33173
	private int nn3cWD8ET5n;

	// Token: 0x04008196 RID: 33174
	private int s4ncWm98GT9;

	// Token: 0x04008197 RID: 33175
	private int saIcWjCw0du;

	// Token: 0x04008198 RID: 33176
	private int VBHcWouCbwG;

	// Token: 0x02001648 RID: 5704
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$39684 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008489 RID: 33929 RVA: 0x010A683C File Offset: 0x010A4A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$39684(Hashtable data, M603_ShadeInTheCity1 self_)
		{
			if (293323 - 176225 != 117098)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131806 - 525346 == -393540)
				{
					base..ctor();
					if (63997 - 332068 != -268070)
					{
						this.$data$39698 = data;
						if (217408 - 253610 != -36201)
						{
							this.$self_$39699 = self_;
							if (197970 - 143161 == 54809)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600848A RID: 33930 RVA: 0x010A68F8 File Offset: 0x010A4AF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$onGameEvent$39684.$(this.$data$39698, this.$self_$39699);
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x010A690C File Offset: 0x010A4B0C
		internal static bool fVqRlup1z5xL9UWv7Vd5()
		{
			return true;
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x010A6910 File Offset: 0x010A4B10
		internal static bool I3KWbAp4aQpqQGWY2x0m()
		{
			return false;
		}

		// Token: 0x04008199 RID: 33177
		internal Hashtable $data$39698;

		// Token: 0x0400819A RID: 33178
		internal M603_ShadeInTheCity1 $self_$39699;

		// Token: 0x02001649 RID: 5705
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600848D RID: 33933 RVA: 0x010A6914 File Offset: 0x010A4B14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M603_ShadeInTheCity1 self_)
			{
				if (195853 - 455116 != -259263)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21667 - 418433 == -396766)
					{
						base..ctor();
						if (266563 - 62699 != 203865)
						{
							this.$data$39696 = data;
							if (167525 - 487911 == -320386)
							{
								this.$self_$39697 = self_;
								if (20129 - 140219 == -120090)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600848E RID: 33934 RVA: 0x010A69D0 File Offset: 0x010A4BD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202622 - 75578 != 127044)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_854;
					case 2:
						Game.mGameStage = 2;
						if (292077 - 310449 != -18372)
						{
							continue;
						}
						Application.LoadLevel("M603_ShadeInTheCity2");
						if (231734 - 505221 != -273487)
						{
							continue;
						}
						goto IL_6E4;
					default:
						if (121948 - 581575 != -459627)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (189899 - 426529 != -236629)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$39685 = RuntimeServices.UnboxInt32(this.$data$39696[141]);
						if (277661 - 110415 == 167247)
						{
							continue;
						}
						this.$returnValue$39686 = RuntimeServices.UnboxInt32(this.$data$39696[145]);
						if (100410 - 134312 == -33901)
						{
							continue;
						}
						this.$ownerID$39687 = RuntimeServices.UnboxInt32(this.$data$39696[43]);
						if (185933 - 442476 != -256543)
						{
							continue;
						}
						this.$$switch$6999$39688 = this.$returnCode$39685;
						if (223851 - 259337 != -35486)
						{
							continue;
						}
						if (this.$$switch$6999$39688 == 6031)
						{
							if (133296 - 541302 != -408006)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (3106 - 325311 != -322205)
							{
								continue;
							}
							this.$mGameGui$39689 = (GameGui)this.$self_$39697.GetComponent(typeof(GameGui));
							if (51967 - 64510 != -12543)
							{
								continue;
							}
							this.$mGameGui$39689.close();
							if (108856 - 418096 != -309240)
							{
								continue;
							}
							Game.savePlayer();
							if (62475 - 278944 != -216469)
							{
								continue;
							}
							this.$self_$39697.SendMessage("fadeOut");
							if (212663 - 596387 != -383724)
							{
								continue;
							}
							goto IL_821;
						}
						else if (this.$$switch$6999$39688 == 6032)
						{
							if (152141 - 444288 != -292147)
							{
								continue;
							}
							this.$self_$39697.UTucW0XBccc = this.$self_$39697.UTucW0XBccc + 1;
							if (101095 - 172429 == -71333)
							{
								continue;
							}
							this.$self_$39697.SendMessage("newGameMessage", "Mission Objective: NPC saved:" + this.$self_$39697.UTucW0XBccc + "/10");
							if (222032 - 487108 == -265075)
							{
								continue;
							}
							this.$$switch$6997$39690 = this.$returnValue$39686;
							if (220789 - 446614 == -225824)
							{
								continue;
							}
							if (this.$$switch$6997$39690 == 1)
							{
								if (284059 - 32199 != 251860)
								{
									continue;
								}
								if (this.$self_$39697.QqAcW8j6VWf < 1)
								{
									if (128198 - 417724 != -289526)
									{
										continue;
									}
									this.$mMiniCat$39691 = GameObject.Find("MiniCat");
									if (19074 - 205532 == -186457)
									{
										continue;
									}
									if (this.$mMiniCat$39691)
									{
										if (25270 - 120458 == -95187)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mMiniCat$39691);
										if (81680 - 495249 != -413569)
										{
											continue;
										}
									}
								}
								this.$self_$39697.QqAcW8j6VWf = 2;
								if (271409 - 132267 != 139142)
								{
									continue;
								}
							}
							else if (this.$$switch$6997$39690 == 2)
							{
								if (269608 - 495704 != -226096)
								{
									continue;
								}
								if (this.$self_$39697.xpccWiBykLS < 1)
								{
									if (275912 - 323463 != -47551)
									{
										continue;
									}
									this.$mMouse$39692 = GameObject.Find("Mouse");
									if (122119 - 43359 == 78761)
									{
										continue;
									}
									if (this.$mMouse$39692)
									{
										if (236855 - 19069 != 217786)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mMouse$39692);
										if (191971 - 318432 == -126460)
										{
											continue;
										}
									}
								}
								this.$self_$39697.xpccWiBykLS = 2;
								if (92299 - 248816 != -156517)
								{
									continue;
								}
							}
							else if (this.$$switch$6997$39690 == 3)
							{
								if (99001 - 7363 == 91639)
								{
									continue;
								}
								if (this.$self_$39697.nn3cWD8ET5n < 1)
								{
									if (154685 - 34891 == 119795)
									{
										continue;
									}
									this.$mWarthog$39693 = GameObject.Find("Warthog");
									if (100497 - 98858 == 1640)
									{
										continue;
									}
									if (this.$mWarthog$39693)
									{
										if (252010 - 345417 == -93406)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mWarthog$39693);
										if (91514 - 589292 != -497778)
										{
											continue;
										}
									}
								}
								this.$self_$39697.nn3cWD8ET5n = 2;
								if (142968 - 318770 == -175801)
								{
									continue;
								}
							}
							else if (this.$$switch$6997$39690 == 4)
							{
								if (58841 - 172200 == -113358)
								{
									continue;
								}
								if (this.$self_$39697.s4ncWm98GT9 < 1)
								{
									if (284052 - 265569 != 18483)
									{
										continue;
									}
									this.$mAlpaca$39694 = GameObject.Find("Alpaca");
									if (11525 - 513831 != -502306)
									{
										continue;
									}
									if (this.$mAlpaca$39694)
									{
										if (22002 - 421973 != -399971)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mAlpaca$39694);
										if (67216 - 59505 != 7711)
										{
											continue;
										}
									}
								}
								this.$self_$39697.s4ncWm98GT9 = 2;
								if (265091 - 14343 != 250748)
								{
									continue;
								}
							}
							else if (this.$$switch$6997$39690 == 5)
							{
								if (225002 - 346544 == -121541)
								{
									continue;
								}
								if (this.$self_$39697.saIcWjCw0du < 1)
								{
									if (127224 - 397650 == -270425)
									{
										continue;
									}
									this.$mLemur$39695 = GameObject.Find("Lemur");
									if (65313 - 520853 != -455540)
									{
										continue;
									}
									if (this.$mLemur$39695)
									{
										if (95659 - 433813 == -338153)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mLemur$39695);
										if (34182 - 163187 != -129005)
										{
											continue;
										}
									}
								}
								this.$self_$39697.saIcWjCw0du = 2;
								if (243848 - 355869 == -112020)
								{
									continue;
								}
							}
						}
					}
					IL_6E4:
					this.YieldDefault(1);
				}
				while (160187 - 568257 != -408070);
				goto IL_854;
				IL_821:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_854:
				return false;
			}

			// Token: 0x0600848F RID: 33935 RVA: 0x010A7244 File Offset: 0x010A5444
			internal static bool QjvRdtp45ySoc0VUQSgY()
			{
				return true;
			}

			// Token: 0x06008490 RID: 33936 RVA: 0x010A7248 File Offset: 0x010A5448
			internal static bool O2teTFp4pEMO1fOmDg6M()
			{
				return false;
			}

			// Token: 0x0400819B RID: 33179
			internal int $returnCode$39685;

			// Token: 0x0400819C RID: 33180
			internal int $returnValue$39686;

			// Token: 0x0400819D RID: 33181
			internal int $ownerID$39687;

			// Token: 0x0400819E RID: 33182
			internal int $$switch$6999$39688;

			// Token: 0x0400819F RID: 33183
			internal GameGui $mGameGui$39689;

			// Token: 0x040081A0 RID: 33184
			internal int $$switch$6997$39690;

			// Token: 0x040081A1 RID: 33185
			internal GameObject $mMiniCat$39691;

			// Token: 0x040081A2 RID: 33186
			internal GameObject $mMouse$39692;

			// Token: 0x040081A3 RID: 33187
			internal GameObject $mWarthog$39693;

			// Token: 0x040081A4 RID: 33188
			internal GameObject $mAlpaca$39694;

			// Token: 0x040081A5 RID: 33189
			internal GameObject $mLemur$39695;

			// Token: 0x040081A6 RID: 33190
			internal Hashtable $data$39696;

			// Token: 0x040081A7 RID: 33191
			internal M603_ShadeInTheCity1 $self_$39697;
		}
	}

	// Token: 0x0200164A RID: 5706
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$39700 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008491 RID: 33937 RVA: 0x010A724C File Offset: 0x010A544C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$39700(M603_ShadeInTheCity1 self_)
		{
			if (281825 - 450986 != -169161)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112915 - 295747 != -182831)
				{
					base..ctor();
					if (271689 - 196225 == 75464)
					{
						this.$self_$39703 = self_;
						if (87607 - 55328 != 32280)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x010A72E4 File Offset: 0x010A54E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$StartEvent$39700.$(this.$self_$39703);
		}

		// Token: 0x06008493 RID: 33939 RVA: 0x010A72F4 File Offset: 0x010A54F4
		internal static bool LBNrPkp4VmAYL7NT7bRD()
		{
			return true;
		}

		// Token: 0x06008494 RID: 33940 RVA: 0x010A72F8 File Offset: 0x010A54F8
		internal static bool EhgylJp4tkMKcc4HikWR()
		{
			return false;
		}

		// Token: 0x040081A8 RID: 33192
		internal M603_ShadeInTheCity1 $self_$39703;

		// Token: 0x0200164B RID: 5707
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008495 RID: 33941 RVA: 0x010A72FC File Offset: 0x010A54FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (139189 - 598525 != -459335)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7422 - 157420 != -149997)
					{
						base..ctor();
						if (246209 - 296767 != -50557)
						{
							this.$self_$39702 = self_;
							if (226495 - 514507 != -288011)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008496 RID: 33942 RVA: 0x010A7394 File Offset: 0x010A5594
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242716 - 369248 != -126532)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (151757 - 309918 == -158160)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (182818 - 533543 == -350724)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (278424 - 287577 != -9153)
						{
							continue;
						}
						if (this.$self_$39702.dVTcWPg8Y85)
						{
							if (225715 - 360555 != -134840)
							{
								continue;
							}
							this.$self_$39702.audio.PlayOneShot(this.$self_$39702.dVTcWPg8Y85);
							if (178540 - 440140 == -261599)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (227866 - 335549 != -107683)
						{
							continue;
						}
						goto IL_1D9;
					default:
						if (65677 - 14904 != 50773)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$39701 = (GameGui)this.$self_$39702.GetComponent(typeof(GameGui));
					if (85243 - 102229 == -16986)
					{
						this.$mGameGui$39701.enabled = true;
						if (110814 - 587510 == -476696)
						{
							this.$self_$39702.SendMessage("fadeIn");
							if (173520 - 422566 != -249045)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1D9:
				return false;
			}

			// Token: 0x06008497 RID: 33943 RVA: 0x010A758C File Offset: 0x010A578C
			internal static bool kHt1Fop4NM16eI1SXKRE()
			{
				return true;
			}

			// Token: 0x06008498 RID: 33944 RVA: 0x010A7590 File Offset: 0x010A5790
			internal static bool GGSVcvp4YrJ3oulf5gJ7()
			{
				return false;
			}

			// Token: 0x040081A9 RID: 33193
			internal GameGui $mGameGui$39701;

			// Token: 0x040081AA RID: 33194
			internal M603_ShadeInTheCity1 $self_$39702;
		}
	}

	// Token: 0x0200164C RID: 5708
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniCat$39704 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008499 RID: 33945 RVA: 0x010A7594 File Offset: 0x010A5794
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniCat$39704(M603_ShadeInTheCity1 self_)
		{
			if (222070 - 471070 != -249000)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66410 - 289012 == -222602)
				{
					base..ctor();
					if (204400 - 481058 != -276657)
					{
						this.$self_$39710 = self_;
						if (20338 - 524625 == -504287)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x010A762C File Offset: 0x010A582C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$TalkToMiniCat$39704.$(this.$self_$39710);
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x010A763C File Offset: 0x010A583C
		internal static bool WbvvNyp4cGBB4GbAHlbX()
		{
			return true;
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x010A7640 File Offset: 0x010A5840
		internal static bool oD3h2Sp4UXdAuFqFiVJD()
		{
			return false;
		}

		// Token: 0x040081AB RID: 33195
		internal M603_ShadeInTheCity1 $self_$39710;

		// Token: 0x0200164D RID: 5709
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600849D RID: 33949 RVA: 0x010A7644 File Offset: 0x010A5844
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (116507 - 48018 != 68489)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (282397 - 471012 == -188615)
					{
						base..ctor();
						if (68094 - 73039 != -4944)
						{
							this.$self_$39709 = self_;
							if (84406 - 396231 != -311824)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600849E RID: 33950 RVA: 0x010A76DC File Offset: 0x010A58DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (136422 - 554427 != -418005)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5A9;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (130200 - 186732 != -56531)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$nMessage$39708 = Language.getMessage("M603_ShadeInTheCity", 6033);
							if (26880 - 407752 == -380871)
							{
								continue;
							}
							this.$mStoryGui$39706.newStoryMessage("none", "MiniCat", this.$nMessage$39708, eTalkType.friend);
							if (92385 - 508726 != -416341)
							{
								continue;
							}
							goto IL_183;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (2337 - 527865 != -525528)
							{
								continue;
							}
							goto IL_526;
						}
						else
						{
							this.$mStoryGui$39706.close();
							if (168951 - 235117 == -66165)
							{
								continue;
							}
							this.$mGameGui$39705.enabled = true;
							if (244818 - 73646 != 171173)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (92541 - 499126 != -406585)
							{
								continue;
							}
							goto IL_4A;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (7461 - 321382 != -313921)
							{
								continue;
							}
							if (this.$mMiniCat$39707)
							{
								if (172635 - 236143 != -63508)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mMiniCat$39707);
								if (229573 - 497628 == -268054)
								{
									continue;
								}
							}
							if (this.$self_$39709.QqAcW8j6VWf >= 2)
							{
								goto IL_1F9;
							}
							if (130364 - 349302 != -218938)
							{
								continue;
							}
							Game.sendMissionEvent(6032, 1);
							if (192122 - 131931 != 60191)
							{
								continue;
							}
							goto IL_1F9;
						}
						break;
					default:
						if (385 - 139977 != -139592)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (245330 - 264789 != -19459)
						{
							continue;
						}
						break;
					}
					else if (this.$self_$39709.QqAcW8j6VWf > 0)
					{
						if (205352 - 423307 != -217955)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$39709.QqAcW8j6VWf = 1;
						if (268684 - 351121 == -82436)
						{
							continue;
						}
						this.$mGameGui$39705 = (GameGui)this.$self_$39709.GetComponent(typeof(GameGui));
						if (114276 - 440827 != -326551)
						{
							continue;
						}
						this.$mStoryGui$39706 = (StoryGui)this.$self_$39709.GetComponent(typeof(StoryGui));
						if (287845 - 422419 == -134573)
						{
							continue;
						}
						if (this.$mGameGui$39705)
						{
							if (75680 - 421331 != -345651)
							{
								continue;
							}
							if (this.$mStoryGui$39706)
							{
								if (85609 - 405018 != -319409)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (221762 - 359499 == -137736)
								{
									continue;
								}
								this.$mGameGui$39705.close();
								if (210638 - 549927 == -339288)
								{
									continue;
								}
								this.$mMiniCat$39707 = GameObject.Find("MiniCat");
								if (115021 - 88068 == 26954)
								{
									continue;
								}
								if (this.$mMiniCat$39707)
								{
									if (249533 - 302298 != -52765)
									{
										continue;
									}
									this.$mMiniCat$39707.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mMiniCat$39707.transform.position));
									if (212136 - 64589 == 147548)
									{
										continue;
									}
									this.$mMiniCat$39707.animation.CrossFade("talk", 0.2f);
									if (103030 - 480112 == -377081)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mMiniCat$39707.transform.position);
									if (569 - 28522 != -27953)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find MiniCat");
									if (263737 - 12986 == 250752)
									{
										continue;
									}
								}
								this.$mStoryGui$39706.startStoryMessage("none", "MiniCat", eTalkType.friend);
								if (238465 - 213307 != 25159)
								{
									goto Block_41;
								}
								continue;
							}
						}
					}
					IL_1F9:
					this.YieldDefault(1);
				}
				while (290310 - 514213 != -223903);
				IL_4A:
				goto IL_5A9;
				Block_10:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_183:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_19:
				IL_526:
				goto IL_5A9;
				Block_41:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5A9:
				return false;
			}

			// Token: 0x0600849F RID: 33951 RVA: 0x010A7CA4 File Offset: 0x010A5EA4
			internal static bool Gegfu9p4TxX6buf1rB6W()
			{
				return true;
			}

			// Token: 0x060084A0 RID: 33952 RVA: 0x010A7CA8 File Offset: 0x010A5EA8
			internal static bool EFX2jwp43ENP1u0IoJBO()
			{
				return false;
			}

			// Token: 0x040081AC RID: 33196
			internal GameGui $mGameGui$39705;

			// Token: 0x040081AD RID: 33197
			internal StoryGui $mStoryGui$39706;

			// Token: 0x040081AE RID: 33198
			internal GameObject $mMiniCat$39707;

			// Token: 0x040081AF RID: 33199
			internal string $nMessage$39708;

			// Token: 0x040081B0 RID: 33200
			internal M603_ShadeInTheCity1 $self_$39709;
		}
	}

	// Token: 0x0200164E RID: 5710
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMouse$39711 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084A1 RID: 33953 RVA: 0x010A7CAC File Offset: 0x010A5EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMouse$39711(M603_ShadeInTheCity1 self_)
		{
			if (216616 - 454543 != -237927)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108198 - 79184 != 29015)
				{
					base..ctor();
					if (202954 - 194929 != 8026)
					{
						this.$self_$39717 = self_;
						if (180349 - 422950 != -242600)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x010A7D44 File Offset: 0x010A5F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$TalkToMouse$39711.$(this.$self_$39717);
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x010A7D54 File Offset: 0x010A5F54
		internal static bool eJB9nZp4XiWoMhXhSGXW()
		{
			return true;
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x010A7D58 File Offset: 0x010A5F58
		internal static bool ln2KZwp4QycbQ5qT8isf()
		{
			return false;
		}

		// Token: 0x040081B1 RID: 33201
		internal M603_ShadeInTheCity1 $self_$39717;

		// Token: 0x0200164F RID: 5711
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084A5 RID: 33957 RVA: 0x010A7D5C File Offset: 0x010A5F5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (147366 - 339133 != -191767)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121036 - 67355 != 53682)
					{
						base..ctor();
						if (164309 - 403611 != -239301)
						{
							this.$self_$39716 = self_;
							if (49252 - 20770 != 28483)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084A6 RID: 33958 RVA: 0x010A7DF4 File Offset: 0x010A5FF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264346 - 445527 != -181181)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_5DE;
					case 1:
						goto IL_603;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (237794 - 259795 != -22001)
							{
								continue;
							}
							goto IL_4E5;
						}
						else
						{
							this.$nMessage$39715 = Language.getMessage("M603_ShadeInTheCity", 6032);
							if (101234 - 474807 != -373573)
							{
								continue;
							}
							this.$mStoryGui$39713.newStoryMessage("none", "Mouse", this.$nMessage$39715, eTalkType.friend);
							if (219558 - 573559 != -354000)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (25152 - 280251 != -255099)
							{
								continue;
							}
							goto IL_D4;
						}
						else
						{
							this.$mStoryGui$39713.close();
							if (233503 - 241760 == -8256)
							{
								continue;
							}
							if (this.$mMouse$39714)
							{
								if (125092 - 379556 != -254464)
								{
									continue;
								}
								this.$mMouse$39714.animation.Play("root");
								if (197493 - 125856 != 71637)
								{
									continue;
								}
							}
							this.$mGameGui$39712.enabled = true;
							if (272028 - 284319 != -12290)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (93640 - 404911 != -311271)
							{
								continue;
							}
							goto IL_599;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (195840 - 394941 != -199101)
							{
								continue;
							}
							if (this.$mMouse$39714)
							{
								if (299411 - 429643 == -130231)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mMouse$39714);
								if (139549 - 268976 == -129426)
								{
									continue;
								}
							}
							if (this.$self_$39716.xpccWiBykLS < 2)
							{
								if (52414 - 594418 == -542003)
								{
									continue;
								}
								Game.sendMissionEvent(6032, 2);
								if (133751 - 336326 != -202575)
								{
									continue;
								}
							}
						}
						break;
					default:
						if (92617 - 122579 != -29962)
						{
							continue;
						}
						goto IL_5DE;
					}
					IL_217:
					this.YieldDefault(1);
					if (291283 - 357514 != -66231)
					{
						continue;
					}
					goto IL_603;
					IL_5DE:
					if (Game.mGameState != eGameState.Normal)
					{
						if (80152 - 183070 != -102917)
						{
							goto Block_44;
						}
					}
					else if (this.$self_$39716.xpccWiBykLS > 0)
					{
						if (100864 - 148374 != -47509)
						{
							goto Block_27;
						}
					}
					else
					{
						this.$self_$39716.xpccWiBykLS = 1;
						if (155076 - 157467 == -2391)
						{
							this.$mGameGui$39712 = (GameGui)this.$self_$39716.GetComponent(typeof(GameGui));
							if (216167 - 347910 != -131742)
							{
								this.$mStoryGui$39713 = (StoryGui)this.$self_$39716.GetComponent(typeof(StoryGui));
								if (181236 - 338298 == -157062)
								{
									if (!this.$mGameGui$39712)
									{
										goto IL_217;
									}
									if (152474 - 85848 == 66626)
									{
										if (!this.$mStoryGui$39713)
										{
											goto IL_217;
										}
										if (253317 - 447728 != -194410)
										{
											Game.mGameState = eGameState.Hold;
											if (263934 - 247834 == 16100)
											{
												this.$mGameGui$39712.close();
												if (233481 - 556823 == -323342)
												{
													this.$mMouse$39714 = GameObject.Find("Mouse");
													if (202091 - 330754 != -128662)
													{
														if (this.$mMouse$39714)
														{
															if (62732 - 10947 != 51785)
															{
																continue;
															}
															this.$mMouse$39714.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mMouse$39714.transform.position));
															if (8954 - 267282 == -258327)
															{
																continue;
															}
															this.$mMouse$39714.animation.CrossFade("talk", 0.2f);
															if (236970 - 555447 == -318476)
															{
																continue;
															}
															Game.mPlayer.SendMessage("turnToPos", this.$mMouse$39714.transform.position);
															if (291141 - 311032 != -19891)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find Mouse");
															if (298626 - 300408 != -1782)
															{
																continue;
															}
														}
														this.$mStoryGui$39713.startStoryMessage("none", "Mouse", eTalkType.friend);
														if (115836 - 141155 == -25319)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_D4:
				goto IL_603;
				Block_11:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_21:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_27:
				IL_4E5:
				IL_599:
				Block_44:
				IL_603:
				return false;
			}

			// Token: 0x060084A7 RID: 33959 RVA: 0x010A8418 File Offset: 0x010A6618
			internal static bool niNlEEp4kf3ipfTZZgJU()
			{
				return true;
			}

			// Token: 0x060084A8 RID: 33960 RVA: 0x010A841C File Offset: 0x010A661C
			internal static bool oWi6pop4GYFVkl9PXpMQ()
			{
				return false;
			}

			// Token: 0x040081B2 RID: 33202
			internal GameGui $mGameGui$39712;

			// Token: 0x040081B3 RID: 33203
			internal StoryGui $mStoryGui$39713;

			// Token: 0x040081B4 RID: 33204
			internal GameObject $mMouse$39714;

			// Token: 0x040081B5 RID: 33205
			internal string $nMessage$39715;

			// Token: 0x040081B6 RID: 33206
			internal M603_ShadeInTheCity1 $self_$39716;
		}
	}

	// Token: 0x02001650 RID: 5712
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWarthog$39718 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084A9 RID: 33961 RVA: 0x010A8420 File Offset: 0x010A6620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWarthog$39718(M603_ShadeInTheCity1 self_)
		{
			if (92464 - 72714 != 19750)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214521 - 453290 == -238769)
				{
					base..ctor();
					if (290334 - 126773 == 163561)
					{
						this.$self_$39724 = self_;
						if (129784 - 370126 == -240342)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x010A84B8 File Offset: 0x010A66B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$TalkToWarthog$39718.$(this.$self_$39724);
		}

		// Token: 0x060084AB RID: 33963 RVA: 0x010A84C8 File Offset: 0x010A66C8
		internal static bool j1Uoukp4HwbUC7HRNRQP()
		{
			return true;
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x010A84CC File Offset: 0x010A66CC
		internal static bool KbNcMEp4WcDJPf7Um20M()
		{
			return false;
		}

		// Token: 0x040081B7 RID: 33207
		internal M603_ShadeInTheCity1 $self_$39724;

		// Token: 0x02001651 RID: 5713
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084AD RID: 33965 RVA: 0x010A84D0 File Offset: 0x010A66D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (105878 - 224787 != -118908)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (287369 - 230404 == 56965)
					{
						base..ctor();
						if (91740 - 291409 != -199668)
						{
							this.$self_$39723 = self_;
							if (104391 - 221635 != -117243)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084AE RID: 33966 RVA: 0x010A8568 File Offset: 0x010A6768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (37778 - 343450 != -305671)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5A9;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (119328 - 463601 != -344273)
							{
								continue;
							}
							goto IL_72;
						}
						else
						{
							this.$nMessage$39722 = Language.getMessage("M603_ShadeInTheCity", 6034);
							if (55792 - 502174 != -446382)
							{
								continue;
							}
							this.$mStoryGui$39720.newStoryMessage("none", "Warthog", this.$nMessage$39722, eTalkType.friend);
							if (167051 - 151362 != 15690)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (278073 - 24333 != 253740)
							{
								continue;
							}
							goto IL_47F;
						}
						else
						{
							this.$mStoryGui$39720.close();
							if (191497 - 73948 != 117549)
							{
								continue;
							}
							this.$mGameGui$39719.enabled = true;
							if (230430 - 104504 != 125927)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (219494 - 257587 != -38092)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (199152 - 283071 != -83919)
							{
								continue;
							}
							if (this.$mWarthog$39721)
							{
								if (197405 - 329076 == -131670)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mWarthog$39721);
								if (62471 - 8614 != 53857)
								{
									continue;
								}
							}
							if (this.$self_$39723.nn3cWD8ET5n >= 2)
							{
								goto IL_38A;
							}
							if (209885 - 597942 != -388057)
							{
								continue;
							}
							Game.sendMissionEvent(6032, 3);
							if (258286 - 449689 != -191403)
							{
								continue;
							}
							goto IL_38A;
						}
						break;
					default:
						if (270943 - 75062 == 195882)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (16958 - 178129 != -161171)
						{
							continue;
						}
						break;
					}
					else if (this.$self_$39723.nn3cWD8ET5n > 0)
					{
						if (49512 - 528894 != -479381)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$39723.nn3cWD8ET5n = 1;
						if (107623 - 264663 != -157040)
						{
							continue;
						}
						this.$mGameGui$39719 = (GameGui)this.$self_$39723.GetComponent(typeof(GameGui));
						if (129424 - 305321 != -175897)
						{
							continue;
						}
						this.$mStoryGui$39720 = (StoryGui)this.$self_$39723.GetComponent(typeof(StoryGui));
						if (193087 - 157394 != 35693)
						{
							continue;
						}
						if (this.$mGameGui$39719)
						{
							if (263498 - 229623 != 33875)
							{
								continue;
							}
							if (this.$mStoryGui$39720)
							{
								if (119106 - 197198 == -78091)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (110250 - 84052 != 26198)
								{
									continue;
								}
								this.$mGameGui$39719.close();
								if (234650 - 121735 == 112916)
								{
									continue;
								}
								this.$mWarthog$39721 = GameObject.Find("Warthog");
								if (268381 - 482582 != -214201)
								{
									continue;
								}
								if (this.$mWarthog$39721)
								{
									if (190011 - 225713 == -35701)
									{
										continue;
									}
									this.$mWarthog$39721.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mWarthog$39721.transform.position));
									if (278755 - 248925 != 29830)
									{
										continue;
									}
									this.$mWarthog$39721.animation.CrossFade("root", 0.2f);
									if (121190 - 267917 == -146726)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mWarthog$39721.transform.position);
									if (281940 - 463721 != -181781)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Warthog");
									if (216342 - 597094 != -380752)
									{
										continue;
									}
								}
								this.$mStoryGui$39720.startStoryMessage("none", "Warthog", eTalkType.friend);
								if (33067 - 156828 != -123761)
								{
									continue;
								}
								goto IL_FF;
							}
						}
					}
					IL_38A:
					this.YieldDefault(1);
				}
				while (65833 - 510702 != -444869);
				IL_72:
				goto IL_5A9;
				IL_FF:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_24:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_47F:
				Block_37:
				goto IL_5A9;
				Block_41:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_5A9:
				return false;
			}

			// Token: 0x060084AF RID: 33967 RVA: 0x010A8B30 File Offset: 0x010A6D30
			internal static bool lDNm6gp4AqVmoPbcuPOQ()
			{
				return true;
			}

			// Token: 0x060084B0 RID: 33968 RVA: 0x010A8B34 File Offset: 0x010A6D34
			internal static bool hqLfMOp4lSjcXdKvWX57()
			{
				return false;
			}

			// Token: 0x040081B8 RID: 33208
			internal GameGui $mGameGui$39719;

			// Token: 0x040081B9 RID: 33209
			internal StoryGui $mStoryGui$39720;

			// Token: 0x040081BA RID: 33210
			internal GameObject $mWarthog$39721;

			// Token: 0x040081BB RID: 33211
			internal string $nMessage$39722;

			// Token: 0x040081BC RID: 33212
			internal M603_ShadeInTheCity1 $self_$39723;
		}
	}

	// Token: 0x02001652 RID: 5714
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToAlpaca$39725 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084B1 RID: 33969 RVA: 0x010A8B38 File Offset: 0x010A6D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToAlpaca$39725(M603_ShadeInTheCity1 self_)
		{
			if (201944 - 507664 != -305720)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224962 - 334874 != -109911)
				{
					base..ctor();
					if (274590 - 550588 == -275998)
					{
						this.$self_$39731 = self_;
						if (229222 - 378132 != -148909)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084B2 RID: 33970 RVA: 0x010A8BD0 File Offset: 0x010A6DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$TalkToAlpaca$39725.$(this.$self_$39731);
		}

		// Token: 0x060084B3 RID: 33971 RVA: 0x010A8BE0 File Offset: 0x010A6DE0
		internal static bool qoGG03p4yCDpmQu2ppw8()
		{
			return true;
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x010A8BE4 File Offset: 0x010A6DE4
		internal static bool YlvjoEp4S7nkC8IecSJX()
		{
			return false;
		}

		// Token: 0x040081BD RID: 33213
		internal M603_ShadeInTheCity1 $self_$39731;

		// Token: 0x02001653 RID: 5715
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084B5 RID: 33973 RVA: 0x010A8BE8 File Offset: 0x010A6DE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (228269 - 404147 != -175877)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (54940 - 449591 != -394650)
					{
						base..ctor();
						if (39997 - 5263 != 34735)
						{
							this.$self_$39730 = self_;
							if (190283 - 328761 != -138477)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084B6 RID: 33974 RVA: 0x010A8C80 File Offset: 0x010A6E80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (124413 - 168099 != -43685)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_603;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (277886 - 338473 != -60586)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$nMessage$39729 = Language.getMessage("M603_ShadeInTheCity", 6035);
							if (64205 - 490662 == -426456)
							{
								continue;
							}
							this.$mStoryGui$39727.newStoryMessage("none", "Yves", this.$nMessage$39729, eTalkType.friend);
							if (27385 - 258567 != -231181)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (49205 - 482311 != -433105)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39727.close();
							if (260375 - 72614 == 187762)
							{
								continue;
							}
							if (this.$mAlpaca$39728)
							{
								if (194199 - 10455 != 183744)
								{
									continue;
								}
								this.$mAlpaca$39728.animation.Play("root");
								if (198175 - 413742 != -215567)
								{
									continue;
								}
							}
							this.$mGameGui$39726.enabled = true;
							if (53124 - 235341 != -182216)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (83858 - 456714 != -372856)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (68336 - 11586 != 56750)
							{
								continue;
							}
							if (this.$mAlpaca$39728)
							{
								if (115572 - 511004 == -395431)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mAlpaca$39728);
								if (96231 - 469913 == -373681)
								{
									continue;
								}
							}
							if (this.$self_$39730.s4ncWm98GT9 >= 2)
							{
								goto IL_1DF;
							}
							if (167680 - 106238 == 61443)
							{
								continue;
							}
							Game.sendMissionEvent(6032, 4);
							if (99722 - 245512 != -145789)
							{
								goto IL_1DF;
							}
							continue;
						}
						break;
					default:
						if (162380 - 419700 == -257319)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (243539 - 451119 != -207579)
						{
							break;
						}
						continue;
					}
					else if (this.$self_$39730.s4ncWm98GT9 > 0)
					{
						if (118317 - 88661 != 29656)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$39730.s4ncWm98GT9 = 1;
						if (73849 - 554092 == -480242)
						{
							continue;
						}
						this.$mGameGui$39726 = (GameGui)this.$self_$39730.GetComponent(typeof(GameGui));
						if (221167 - 390025 == -168857)
						{
							continue;
						}
						this.$mStoryGui$39727 = (StoryGui)this.$self_$39730.GetComponent(typeof(StoryGui));
						if (282933 - 359502 == -76568)
						{
							continue;
						}
						if (this.$mGameGui$39726)
						{
							if (86873 - 464168 == -377294)
							{
								continue;
							}
							if (this.$mStoryGui$39727)
							{
								if (67414 - 292540 == -225125)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (204400 - 375894 != -171494)
								{
									continue;
								}
								this.$mGameGui$39726.close();
								if (156753 - 176553 == -19799)
								{
									continue;
								}
								this.$mAlpaca$39728 = GameObject.Find("Alpaca");
								if (33485 - 308351 != -274866)
								{
									continue;
								}
								if (this.$mAlpaca$39728)
								{
									if (112299 - 511893 == -399593)
									{
										continue;
									}
									this.$mAlpaca$39728.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mAlpaca$39728.transform.position));
									if (291143 - 15575 != 275568)
									{
										continue;
									}
									this.$mAlpaca$39728.animation.CrossFade("talk", 0.2f);
									if (218546 - 471726 != -253180)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mAlpaca$39728.transform.position);
									if (177422 - 521318 != -343896)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Alpaca");
									if (225473 - 237550 == -12076)
									{
										continue;
									}
								}
								this.$mStoryGui$39727.startStoryMessage("none", "Yves", eTalkType.friend);
								if (34333 - 540639 != -506306)
								{
									continue;
								}
								goto IL_14F;
							}
						}
					}
					IL_1DF:
					this.YieldDefault(1);
				}
				while (247362 - 156160 != 91202);
				IL_1A:
				goto IL_603;
				Block_3:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_14F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_10:
				goto IL_603;
				Block_26:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_29:
				IL_603:
				return false;
			}

			// Token: 0x060084B7 RID: 33975 RVA: 0x010A92A4 File Offset: 0x010A74A4
			internal static bool CfgllEp4oIH9e1i5f0lB()
			{
				return true;
			}

			// Token: 0x060084B8 RID: 33976 RVA: 0x010A92A8 File Offset: 0x010A74A8
			internal static bool ACET2Xp4E36yEbDr8dED()
			{
				return false;
			}

			// Token: 0x040081BE RID: 33214
			internal GameGui $mGameGui$39726;

			// Token: 0x040081BF RID: 33215
			internal StoryGui $mStoryGui$39727;

			// Token: 0x040081C0 RID: 33216
			internal GameObject $mAlpaca$39728;

			// Token: 0x040081C1 RID: 33217
			internal string $nMessage$39729;

			// Token: 0x040081C2 RID: 33218
			internal M603_ShadeInTheCity1 $self_$39730;
		}
	}

	// Token: 0x02001654 RID: 5716
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLemur$39732 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084B9 RID: 33977 RVA: 0x010A92AC File Offset: 0x010A74AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLemur$39732(M603_ShadeInTheCity1 self_)
		{
			if (12707 - 599777 != -587069)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103021 - 532671 == -429650)
				{
					base..ctor();
					if (1971 - 69193 != -67221)
					{
						this.$self_$39738 = self_;
						if (79764 - 119421 == -39657)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x010A9344 File Offset: 0x010A7544
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$TalkToLemur$39732.$(this.$self_$39738);
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x010A9354 File Offset: 0x010A7554
		internal static bool uIm8Gtp42drmcpHBppFs()
		{
			return true;
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x010A9358 File Offset: 0x010A7558
		internal static bool P6gpCVp48gLdCbDKMgeF()
		{
			return false;
		}

		// Token: 0x040081C3 RID: 33219
		internal M603_ShadeInTheCity1 $self_$39738;

		// Token: 0x02001655 RID: 5717
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084BD RID: 33981 RVA: 0x010A935C File Offset: 0x010A755C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (15462 - 380112 != -364650)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (128563 - 560910 != -432346)
					{
						base..ctor();
						if (107552 - 372245 != -264692)
						{
							this.$self_$39737 = self_;
							if (145430 - 71062 == 74368)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084BE RID: 33982 RVA: 0x010A93F4 File Offset: 0x010A75F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198396 - 348770 != -150373)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_5DE;
					case 1:
						goto IL_603;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (208969 - 507542 != -298573)
							{
								continue;
							}
							goto IL_191;
						}
						else
						{
							this.$nMessage$39736 = Language.getMessage("M603_ShadeInTheCity", 6036);
							if (199044 - 324801 == -125756)
							{
								continue;
							}
							this.$mStoryGui$39734.newStoryMessage("none", "Lemur", this.$nMessage$39736, eTalkType.friend);
							if (149769 - 59054 != 90716)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (66498 - 100749 != -34250)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39734.close();
							if (288740 - 132203 != 156537)
							{
								continue;
							}
							if (this.$mLemur$39735)
							{
								if (73456 - 552501 != -479045)
								{
									continue;
								}
								this.$mLemur$39735.animation.Play("root");
								if (68022 - 270785 != -202763)
								{
									continue;
								}
							}
							this.$mGameGui$39733.enabled = true;
							if (102834 - 115267 != -12432)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (290919 - 400195 != -109275)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (132006 - 322895 != -190889)
							{
								continue;
							}
							if (this.$mLemur$39735)
							{
								if (227754 - 363772 == -136017)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mLemur$39735);
								if (85155 - 166769 == -81613)
								{
									continue;
								}
							}
							if (this.$self_$39737.saIcWjCw0du < 2)
							{
								if (121310 - 294992 == -173681)
								{
									continue;
								}
								Game.sendMissionEvent(6032, 5);
								if (101487 - 49263 == 52225)
								{
									continue;
								}
							}
						}
						break;
					default:
						if (236814 - 863 != 235952)
						{
							goto IL_5DE;
						}
						continue;
					}
					IL_31C:
					this.YieldDefault(1);
					if (235023 - 181697 != 53326)
					{
						continue;
					}
					break;
					IL_5DE:
					if (Game.mGameState != eGameState.Normal)
					{
						if (249545 - 434475 == -184930)
						{
							break;
						}
					}
					else if (this.$self_$39737.saIcWjCw0du > 0)
					{
						if (259327 - 315087 != -55759)
						{
							break;
						}
					}
					else
					{
						this.$self_$39737.saIcWjCw0du = 1;
						if (124933 - 560431 != -435497)
						{
							this.$mGameGui$39733 = (GameGui)this.$self_$39737.GetComponent(typeof(GameGui));
							if (154 - 327654 != -327499)
							{
								this.$mStoryGui$39734 = (StoryGui)this.$self_$39737.GetComponent(typeof(StoryGui));
								if (257836 - 488495 == -230659)
								{
									if (!this.$mGameGui$39733)
									{
										goto IL_31C;
									}
									if (276590 - 59754 != 216837)
									{
										if (!this.$mStoryGui$39734)
										{
											goto IL_31C;
										}
										if (157715 - 213533 == -55818)
										{
											Game.mGameState = eGameState.Hold;
											if (170801 - 443869 == -273068)
											{
												this.$mGameGui$39733.close();
												if (14219 - 369593 != -355373)
												{
													this.$mLemur$39735 = GameObject.Find("Lemur");
													if (96871 - 180706 != -83834)
													{
														if (this.$mLemur$39735)
														{
															if (56344 - 106495 == -50150)
															{
																continue;
															}
															this.$mLemur$39735.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mLemur$39735.transform.position));
															if (185422 - 26560 != 158862)
															{
																continue;
															}
															this.$mLemur$39735.animation.CrossFade("talk", 0.2f);
															if (154043 - 479356 != -325313)
															{
																continue;
															}
															Game.mPlayer.SendMessage("turnToPos", this.$mLemur$39735.transform.position);
															if (151835 - 363942 == -212106)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find Lemur");
															if (297963 - 583689 == -285725)
															{
																continue;
															}
														}
														this.$mStoryGui$39734.startStoryMessage("none", "Lemur", eTalkType.friend);
														if (276933 - 25117 != 251817)
														{
															goto Block_28;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_8:
				IL_191:
				goto IL_603;
				Block_22:
				return this.Yield(4, new WaitForSeconds(1f));
				goto IL_603;
				Block_28:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_39:
				goto IL_603;
				Block_41:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_603:
				return false;
			}

			// Token: 0x060084BF RID: 33983 RVA: 0x010A9A18 File Offset: 0x010A7C18
			internal static bool mHoKdjp4Ze6rVsRLVfSk()
			{
				return true;
			}

			// Token: 0x060084C0 RID: 33984 RVA: 0x010A9A1C File Offset: 0x010A7C1C
			internal static bool FLVsD9p4CF5Z4ste4x0W()
			{
				return false;
			}

			// Token: 0x040081C4 RID: 33220
			internal GameGui $mGameGui$39733;

			// Token: 0x040081C5 RID: 33221
			internal StoryGui $mStoryGui$39734;

			// Token: 0x040081C6 RID: 33222
			internal GameObject $mLemur$39735;

			// Token: 0x040081C7 RID: 33223
			internal string $nMessage$39736;

			// Token: 0x040081C8 RID: 33224
			internal M603_ShadeInTheCity1 $self_$39737;
		}
	}

	// Token: 0x02001656 RID: 5718
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$39739 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084C1 RID: 33985 RVA: 0x010A9A20 File Offset: 0x010A7C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$39739(M603_ShadeInTheCity1 self_)
		{
			if (119010 - 79512 != 39499)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179769 - 329689 == -149920)
				{
					base..ctor();
					if (105506 - 586989 == -481483)
					{
						this.$self_$39745 = self_;
						if (177147 - 330034 != -152886)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x010A9AB8 File Offset: 0x010A7CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$TalkToPanther$39739.$(this.$self_$39745);
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x010A9AC8 File Offset: 0x010A7CC8
		internal static bool w0rMa1p4LiEJ9EgUqk66()
		{
			return true;
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x010A9ACC File Offset: 0x010A7CCC
		internal static bool TaQllSp4OHLSjkXUDk3Q()
		{
			return false;
		}

		// Token: 0x040081C9 RID: 33225
		internal M603_ShadeInTheCity1 $self_$39745;

		// Token: 0x02001657 RID: 5719
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084C5 RID: 33989 RVA: 0x010A9AD0 File Offset: 0x010A7CD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (151444 - 166967 != -15523)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (32621 - 165180 != -132558)
					{
						base..ctor();
						if (255011 - 265048 == -10037)
						{
							this.$self_$39744 = self_;
							if (80298 - 291348 == -211050)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084C6 RID: 33990 RVA: 0x010A9B68 File Offset: 0x010A7D68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179337 - 228083 != -48746)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_428;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (165697 - 550881 != -385184)
							{
								continue;
							}
							goto IL_393;
						}
						else
						{
							this.$nMessage$39743 = Language.getMessage("M603_ShadeInTheCity", 6031);
							if (176594 - 119455 == 57140)
							{
								continue;
							}
							this.$mStoryGui$39741.newStoryMessage("none", "Panther", this.$nMessage$39743, eTalkType.friend);
							if (295159 - 529087 != -233928)
							{
								continue;
							}
							goto IL_A5;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (234822 - 450731 != -215908)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39741.close();
							if (264992 - 91520 != 173472)
							{
								continue;
							}
							this.$mGameGui$39740.enabled = true;
							if (166276 - 256986 != -90710)
							{
								continue;
							}
							goto IL_168;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (6678 - 346897 != -340218)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (158532 - 50788 != 107744)
							{
								continue;
							}
							goto IL_3C7;
						}
						break;
					default:
						if (151624 - 222615 == -70990)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (151007 - 52223 != 98784)
						{
							continue;
						}
						goto IL_3E9;
					}
					else
					{
						this.$mGameGui$39740 = (GameGui)this.$self_$39744.GetComponent(typeof(GameGui));
						if (84942 - 96578 != -11636)
						{
							continue;
						}
						this.$mStoryGui$39741 = (StoryGui)this.$self_$39744.GetComponent(typeof(StoryGui));
						if (259931 - 272121 == -12189)
						{
							continue;
						}
						if (this.$mGameGui$39740)
						{
							if (211251 - 74013 != 137238)
							{
								continue;
							}
							if (this.$mStoryGui$39741)
							{
								if (170687 - 111 != 170576)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (72150 - 351673 != -279523)
								{
									continue;
								}
								this.$mGameGui$39740.close();
								if (132899 - 468177 != -335278)
								{
									continue;
								}
								this.$mPanther$39742 = GameObject.Find("Panther");
								if (275770 - 515402 == -239631)
								{
									continue;
								}
								if (this.$mPanther$39742)
								{
									if (141914 - 10905 == 131010)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mPanther$39742.transform.position);
									if (276383 - 223514 != 52869)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Panther");
									if (140668 - 197450 == -56781)
									{
										continue;
									}
								}
								this.$mStoryGui$39741.startStoryMessage("none", "Panther", eTalkType.friend);
								if (44130 - 42140 != 1990)
								{
									continue;
								}
								goto IL_1A3;
							}
						}
					}
					IL_3C7:
					this.YieldDefault(1);
					if (260268 - 239452 == 20816)
					{
						goto IL_428;
					}
				}
				IL_A5:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_7:
				goto IL_428;
				IL_168:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_13:
				goto IL_428;
				IL_1A3:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_393:
				IL_3E9:
				IL_428:
				return false;
			}

			// Token: 0x060084C7 RID: 33991 RVA: 0x010A9FB0 File Offset: 0x010A81B0
			internal static bool qJJO3tp4mZu5sjCZV9D1()
			{
				return true;
			}

			// Token: 0x060084C8 RID: 33992 RVA: 0x010A9FB4 File Offset: 0x010A81B4
			internal static bool JndOl0p4F7BD5cLUEqol()
			{
				return false;
			}

			// Token: 0x040081CA RID: 33226
			internal GameGui $mGameGui$39740;

			// Token: 0x040081CB RID: 33227
			internal StoryGui $mStoryGui$39741;

			// Token: 0x040081CC RID: 33228
			internal GameObject $mPanther$39742;

			// Token: 0x040081CD RID: 33229
			internal string $nMessage$39743;

			// Token: 0x040081CE RID: 33230
			internal M603_ShadeInTheCity1 $self_$39744;
		}
	}

	// Token: 0x02001658 RID: 5720
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39746 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084C9 RID: 33993 RVA: 0x010A9FB8 File Offset: 0x010A81B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39746(M603_ShadeInTheCity1 self_)
		{
			if (64848 - 69250 != -4402)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66596 - 443882 != -377285)
				{
					base..ctor();
					if (87862 - 496159 == -408297)
					{
						this.$self_$39751 = self_;
						if (162216 - 37151 != 125066)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084CA RID: 33994 RVA: 0x010AA050 File Offset: 0x010A8250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$onDeadPlayer$39746.$(this.$self_$39751);
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x010AA060 File Offset: 0x010A8260
		internal static bool ilINj0p4MiF4OKYUd6VA()
		{
			return true;
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x010AA064 File Offset: 0x010A8264
		internal static bool mIWglFp4xaXOAGdHV6Fo()
		{
			return false;
		}

		// Token: 0x040081CF RID: 33231
		internal M603_ShadeInTheCity1 $self_$39751;

		// Token: 0x02001659 RID: 5721
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084CD RID: 33997 RVA: 0x010AA068 File Offset: 0x010A8268
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (205082 - 518011 != -312928)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14703 - 399069 == -384366)
					{
						base..ctor();
						if (293553 - 398016 != -104462)
						{
							this.$self_$39750 = self_;
							if (194231 - 377311 != -183079)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084CE RID: 33998 RVA: 0x010AA100 File Offset: 0x010A8300
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97614 - 332818 != -235203)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_1E5;
						}
						if (146983 - 301660 != -154677)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (188009 - 425603 != -237593)
							{
								goto IL_1E5;
							}
							continue;
						}
						IL_C6:
						this.YieldDefault(1);
						if (120486 - 228146 != -107660)
						{
							continue;
						}
						goto IL_2F9;
						IL_1E5:
						Game.mGameState = eGameState.Hold;
						if (242042 - 50355 != 191687)
						{
							continue;
						}
						this.$mStoryGui$39747 = (StoryGui)this.$self_$39750.GetComponent(typeof(StoryGui));
						if (201711 - 122623 == 79089)
						{
							continue;
						}
						if (this.$mStoryGui$39747)
						{
							if (170723 - 134378 != 36345)
							{
								continue;
							}
							this.$mStoryGui$39747.close();
							if (163160 - 230667 != -67507)
							{
								continue;
							}
						}
						this.$mChangeGui$39748 = (ChangeGui)this.$self_$39750.GetComponent(typeof(ChangeGui));
						if (76553 - 69915 != 6638)
						{
							continue;
						}
						if (this.$mChangeGui$39748)
						{
							if (171981 - 170384 == 1598)
							{
								continue;
							}
							this.$mChangeGui$39748.close();
							if (11223 - 324855 != -313632)
							{
								continue;
							}
						}
						this.$mGameGui$39749 = (GameGui)this.$self_$39750.GetComponent(typeof(GameGui));
						if (99323 - 454703 == -355379)
						{
							continue;
						}
						if (!this.$mGameGui$39749)
						{
							goto IL_C6;
						}
						if (209028 - 552000 != -342972)
						{
							continue;
						}
						if (!this.$mGameGui$39749.enabled)
						{
							if (92277 - 24244 == 68034)
							{
								continue;
							}
							this.$mGameGui$39749.enabled = true;
							if (294507 - 167490 != 127017)
							{
								continue;
							}
						}
						this.$mGameGui$39749.openDeadMenu();
						if (93644 - 123198 != -29554)
						{
							continue;
						}
						goto IL_C6;
					default:
						if (144006 - 175738 == -31731)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (85943 - 89055 != -3112);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060084CF RID: 33999 RVA: 0x010AA418 File Offset: 0x010A8618
			internal static bool IS8l0Fp4gM0qZVxiebd6()
			{
				return true;
			}

			// Token: 0x060084D0 RID: 34000 RVA: 0x010AA41C File Offset: 0x010A861C
			internal static bool YckCVtp4frasUyYiirv4()
			{
				return false;
			}

			// Token: 0x040081D0 RID: 33232
			internal StoryGui $mStoryGui$39747;

			// Token: 0x040081D1 RID: 33233
			internal ChangeGui $mChangeGui$39748;

			// Token: 0x040081D2 RID: 33234
			internal GameGui $mGameGui$39749;

			// Token: 0x040081D3 RID: 33235
			internal M603_ShadeInTheCity1 $self_$39750;
		}
	}

	// Token: 0x0200165A RID: 5722
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39752 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084D1 RID: 34001 RVA: 0x010AA420 File Offset: 0x010A8620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39752(Hashtable data, M603_ShadeInTheCity1 self_)
		{
			if (279448 - 58029 != 221419)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55105 - 269072 == -213967)
				{
					base..ctor();
					if (128301 - 270337 != -142035)
					{
						this.$data$39759 = data;
						if (25469 - 390236 != -364766)
						{
							this.$self_$39760 = self_;
							if (968 - 473720 != -472751)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x010AA4DC File Offset: 0x010A86DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$onGameComplete$39752.$(this.$data$39759, this.$self_$39760);
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x010AA4F0 File Offset: 0x010A86F0
		internal static bool m43Ahfp4nH7xGrBgvgM8()
		{
			return true;
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x010AA4F4 File Offset: 0x010A86F4
		internal static bool pRml4Pp46wficNYVCHPS()
		{
			return false;
		}

		// Token: 0x040081D4 RID: 33236
		internal Hashtable $data$39759;

		// Token: 0x040081D5 RID: 33237
		internal M603_ShadeInTheCity1 $self_$39760;

		// Token: 0x0200165B RID: 5723
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084D5 RID: 34005 RVA: 0x010AA4F8 File Offset: 0x010A86F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M603_ShadeInTheCity1 self_)
			{
				if (200989 - 454273 != -253283)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90417 - 565913 != -475495)
					{
						base..ctor();
						if (121940 - 61922 == 60018)
						{
							this.$data$39757 = data;
							if (253663 - 455287 != -201623)
							{
								this.$self_$39758 = self_;
								if (216880 - 482552 == -265672)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060084D6 RID: 34006 RVA: 0x010AA5B4 File Offset: 0x010A87B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139333 - 401769 != -262436)
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
						this.$mCompleteGui$39754 = (CompleteGui)this.$self_$39758.GetComponent(typeof(CompleteGui));
						if (113771 - 582333 != -468562)
						{
							continue;
						}
						this.$mCompleteGui$39754.Init();
						if (96424 - 369462 == -273037)
						{
							continue;
						}
						this.$mCompleteGui$39754.readData(this.$data$39757);
						if (137296 - 237136 != -99840)
						{
							continue;
						}
						if (this.$result$39753 == 1)
						{
							if (42269 - 56041 != -13772)
							{
								continue;
							}
							this.$mCompleteGui$39754.displayResult(eCompleteType.Success);
							if (85615 - 532741 == -447125)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39754.displayResult(eCompleteType.Failed);
							if (226412 - 564056 != -337644)
							{
								continue;
							}
						}
						this.$mGameGui$39755 = (GameGui)this.$self_$39758.GetComponent(typeof(GameGui));
						if (130448 - 27617 == 102832)
						{
							continue;
						}
						this.$mStoryGui$39756 = (StoryGui)this.$self_$39758.GetComponent(typeof(StoryGui));
						if (77400 - 401827 != -324427)
						{
							continue;
						}
						if (this.$mGameGui$39755)
						{
							if (249415 - 574537 != -325122)
							{
								continue;
							}
							this.$mGameGui$39755.close();
							if (272734 - 340955 != -68221)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39756)
						{
							if (195901 - 339659 == -143757)
							{
								continue;
							}
							this.$mStoryGui$39756.close();
							if (169665 - 256780 != -87115)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (292021 - 205340 != 86681)
						{
							continue;
						}
						goto IL_352;
					default:
						if (282177 - 394090 != -111913)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39757[31]);
					if (239015 - 259807 != -20791)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (217074 - 523670 == -306596)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (296115 - 383910 != -87794)
							{
								this.$result$39753 = RuntimeServices.UnboxInt32(this.$data$39757[31]);
								if (216522 - 148979 != 67544)
								{
									goto Block_7;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_7:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x060084D7 RID: 34007 RVA: 0x010AA928 File Offset: 0x010A8B28
			internal static bool CrlACVp4iffYIK4d9TVQ()
			{
				return true;
			}

			// Token: 0x060084D8 RID: 34008 RVA: 0x010AA92C File Offset: 0x010A8B2C
			internal static bool nhTCB5p4KaMui9Z0S18k()
			{
				return false;
			}

			// Token: 0x040081D6 RID: 33238
			internal int $result$39753;

			// Token: 0x040081D7 RID: 33239
			internal CompleteGui $mCompleteGui$39754;

			// Token: 0x040081D8 RID: 33240
			internal GameGui $mGameGui$39755;

			// Token: 0x040081D9 RID: 33241
			internal StoryGui $mStoryGui$39756;

			// Token: 0x040081DA RID: 33242
			internal Hashtable $data$39757;

			// Token: 0x040081DB RID: 33243
			internal M603_ShadeInTheCity1 $self_$39758;
		}
	}

	// Token: 0x0200165C RID: 5724
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39761 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084D9 RID: 34009 RVA: 0x010AA930 File Offset: 0x010A8B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39761(M603_ShadeInTheCity1 self_)
		{
			if (274024 - 433798 != -159774)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136987 - 130354 != 6634)
				{
					base..ctor();
					if (124606 - 123074 != 1533)
					{
						this.$self_$39765 = self_;
						if (114202 - 410861 == -296659)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x010AA9C8 File Offset: 0x010A8BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$ReturnToTown$39761.$(this.$self_$39765);
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x010AA9D8 File Offset: 0x010A8BD8
		internal static bool je7gnQp4dvOlL9JSQ8jT()
		{
			return true;
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x010AA9DC File Offset: 0x010A8BDC
		internal static bool JjGWwUp4JTG27QwSPBIu()
		{
			return false;
		}

		// Token: 0x040081DC RID: 33244
		internal M603_ShadeInTheCity1 $self_$39765;

		// Token: 0x0200165D RID: 5725
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084DD RID: 34013 RVA: 0x010AA9E0 File Offset: 0x010A8BE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (213490 - 334469 != -120979)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162100 - 188551 != -26450)
					{
						base..ctor();
						if (57891 - 78920 != -21028)
						{
							this.$self_$39764 = self_;
							if (284180 - 579891 == -295711)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084DE RID: 34014 RVA: 0x010AAA78 File Offset: 0x010A8C78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209619 - 264759 != -55140)
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
						this.$self_$39764.LeaveGame();
						if (231675 - 139440 == 92236)
						{
							continue;
						}
						this.YieldDefault(1);
						if (102348 - 5020 != 97329)
						{
							goto Block_4;
						}
						continue;
					default:
						if (1176 - 418665 == -417488)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (240736 - 477275 != -236538)
					{
						Game.mStateTime = Time.time;
						if (104083 - 588453 != -484369)
						{
							this.$$switch$7003$39762 = PlayerData.SaveGuild;
							if (212353 - 239441 != -27087)
							{
								if (this.$$switch$7003$39762 == 1)
								{
									if (142246 - 242049 == -99802)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (183221 - 574522 == -391300)
									{
										continue;
									}
								}
								else if (this.$$switch$7003$39762 == 2)
								{
									if (37522 - 277810 != -240288)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (15908 - 25826 != -9918)
									{
										continue;
									}
								}
								else if (this.$$switch$7003$39762 == 3)
								{
									if (115070 - 580100 == -465029)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (88633 - 385266 != -296633)
									{
										continue;
									}
								}
								else if (this.$$switch$7003$39762 == 4)
								{
									if (282380 - 400685 == -118304)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (247198 - 347359 == -100160)
									{
										continue;
									}
								}
								else if (this.$$switch$7003$39762 == 5)
								{
									if (63327 - 260609 != -197282)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (75451 - 92167 == -16715)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (4761 - 188977 != -184216)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (35947 - 364948 != -329001)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (123375 - 39590 != 83785)
									{
										continue;
									}
								}
								this.$mGameGui$39763 = (GameGui)this.$self_$39764.GetComponent(typeof(GameGui));
								if (181120 - 479337 != -298216)
								{
									if (this.$mGameGui$39763)
									{
										if (203295 - 163746 != 39549)
										{
											continue;
										}
										this.$mGameGui$39763.close();
										if (147518 - 9585 != 137933)
										{
											continue;
										}
									}
									this.$self_$39764.SendMessage("fadeOut");
									if (204685 - 517045 == -312360)
									{
										goto IL_15C;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_3AD;
				IL_15C:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060084DF RID: 34015 RVA: 0x010AAE44 File Offset: 0x010A9044
			internal static bool rhRTtcp4DmZshOTgGUnm()
			{
				return true;
			}

			// Token: 0x060084E0 RID: 34016 RVA: 0x010AAE48 File Offset: 0x010A9048
			internal static bool XRPjKfp4vir2duEou6or()
			{
				return false;
			}

			// Token: 0x040081DD RID: 33245
			internal int $$switch$7003$39762;

			// Token: 0x040081DE RID: 33246
			internal GameGui $mGameGui$39763;

			// Token: 0x040081DF RID: 33247
			internal M603_ShadeInTheCity1 $self_$39764;
		}
	}

	// Token: 0x0200165E RID: 5726
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39766 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084E1 RID: 34017 RVA: 0x010AAE4C File Offset: 0x010A904C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39766(M603_ShadeInTheCity1 self_)
		{
			if (272201 - 39155 != 233046)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44239 - 577681 == -533442)
				{
					base..ctor();
					if (74630 - 64972 != 9659)
					{
						this.$self_$39769 = self_;
						if (55431 - 244545 != -189113)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x010AAEE4 File Offset: 0x010A90E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$ReturnToGuild$39766.$(this.$self_$39769);
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x010AAEF4 File Offset: 0x010A90F4
		internal static bool dpCFYEp4RjXuQhwsnybH()
		{
			return true;
		}

		// Token: 0x060084E4 RID: 34020 RVA: 0x010AAEF8 File Offset: 0x010A90F8
		internal static bool G7TNbap4wLHeWkPt2paP()
		{
			return false;
		}

		// Token: 0x040081E0 RID: 33248
		internal M603_ShadeInTheCity1 $self_$39769;

		// Token: 0x0200165F RID: 5727
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084E5 RID: 34021 RVA: 0x010AAEFC File Offset: 0x010A90FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (209163 - 114438 != 94726)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8154 - 204391 != -196236)
					{
						base..ctor();
						if (194419 - 19945 == 174474)
						{
							this.$self_$39768 = self_;
							if (214950 - 110399 == 104551)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084E6 RID: 34022 RVA: 0x010AAF94 File Offset: 0x010A9194
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174198 - 141671 != 32528)
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
						this.$self_$39768.LeaveGame();
						if (196433 - 105464 != 90969)
						{
							continue;
						}
						this.YieldDefault(1);
						if (17206 - 200847 != -183641)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (214868 - 46214 != 168654)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (218978 - 511911 == -292933)
					{
						Game.mStateTime = Time.time;
						if (243136 - 354131 != -110994)
						{
							Game.mNextGameCode = 31;
							if (96228 - 193150 != -96921)
							{
								this.$mGameGui$39767 = (GameGui)this.$self_$39768.GetComponent(typeof(GameGui));
								if (190216 - 62962 != 127255)
								{
									if (this.$mGameGui$39767)
									{
										if (67442 - 40975 == 26468)
										{
											continue;
										}
										this.$mGameGui$39767.close();
										if (38454 - 267096 != -228642)
										{
											continue;
										}
									}
									this.$self_$39768.SendMessage("fadeOut");
									if (161865 - 111285 == 50580)
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

			// Token: 0x060084E7 RID: 34023 RVA: 0x010AB170 File Offset: 0x010A9370
			internal static bool m1BMF3p4qdSIY0MCMB60()
			{
				return true;
			}

			// Token: 0x060084E8 RID: 34024 RVA: 0x010AB174 File Offset: 0x010A9374
			internal static bool D7Sabkp47p52F77Ucxfd()
			{
				return false;
			}

			// Token: 0x040081E1 RID: 33249
			internal GameGui $mGameGui$39767;

			// Token: 0x040081E2 RID: 33250
			internal M603_ShadeInTheCity1 $self_$39768;
		}
	}

	// Token: 0x02001660 RID: 5728
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39770 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060084E9 RID: 34025 RVA: 0x010AB178 File Offset: 0x010A9378
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39770(M603_ShadeInTheCity1 self_)
		{
			if (275006 - 87901 != 187105)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119593 - 554285 == -434692)
				{
					base..ctor();
					if (113495 - 252627 == -139132)
					{
						this.$self_$39774 = self_;
						if (123927 - 462965 != -339037)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x010AB210 File Offset: 0x010A9410
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity1.$ReturnToCamp$39770.$(this.$self_$39774);
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x010AB220 File Offset: 0x010A9420
		internal static bool vjV5jrp4PVnhbhTgvuYo()
		{
			return true;
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x010AB224 File Offset: 0x010A9424
		internal static bool op5ngTp40ibyKqPDNvBy()
		{
			return false;
		}

		// Token: 0x040081E3 RID: 33251
		internal M603_ShadeInTheCity1 $self_$39774;

		// Token: 0x02001661 RID: 5729
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060084ED RID: 34029 RVA: 0x010AB228 File Offset: 0x010A9428
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity1 self_)
			{
				if (144417 - 57871 != 86547)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (227074 - 207875 != 19200)
					{
						base..ctor();
						if (108348 - 423335 == -314987)
						{
							this.$self_$39773 = self_;
							if (269482 - 40009 != 229474)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060084EE RID: 34030 RVA: 0x010AB2C0 File Offset: 0x010A94C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149905 - 109927 != 39979)
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
						this.$self_$39773.LeaveGame();
						if (255115 - 107116 != 147999)
						{
							continue;
						}
						this.YieldDefault(1);
						if (124201 - 89990 != 34212)
						{
							goto Block_25;
						}
						continue;
					default:
						if (273424 - 480197 == -206772)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (40501 - 206911 == -166410)
					{
						Game.mStateTime = Time.time;
						if (112897 - 149850 == -36953)
						{
							this.$$switch$7005$39771 = PlayerData.SaveGuild;
							if (202924 - 287182 != -84257)
							{
								if (this.$$switch$7005$39771 == 1)
								{
									if (151910 - 228510 == -76599)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (261884 - 197896 == 63989)
									{
										continue;
									}
								}
								else if (this.$$switch$7005$39771 == 2)
								{
									if (190592 - 415087 != -224495)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (253003 - 244436 != 8567)
									{
										continue;
									}
								}
								else if (this.$$switch$7005$39771 == 3)
								{
									if (259358 - 76418 == 182941)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (2093 - 192962 == -190868)
									{
										continue;
									}
								}
								else if (this.$$switch$7005$39771 == 4)
								{
									if (26059 - 217125 != -191066)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (150400 - 263886 != -113486)
									{
										continue;
									}
								}
								else if (this.$$switch$7005$39771 == 5)
								{
									if (18346 - 122365 == -104018)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (60326 - 8762 != 51564)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (207154 - 203303 != 3851)
									{
										continue;
									}
								}
								this.$mGameGui$39772 = (GameGui)this.$self_$39773.GetComponent(typeof(GameGui));
								if (262273 - 158349 == 103924)
								{
									if (this.$mGameGui$39772)
									{
										if (193001 - 19711 != 173290)
										{
											continue;
										}
										this.$mGameGui$39772.close();
										if (34170 - 123024 == -88853)
										{
											continue;
										}
									}
									this.$self_$39773.SendMessage("fadeOut");
									if (51103 - 267033 != -215929)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_25:
				IL_363:
				return false;
			}

			// Token: 0x060084EF RID: 34031 RVA: 0x010AB644 File Offset: 0x010A9844
			internal static bool vDdqAcp4b7sxH7Paq3Nt()
			{
				return true;
			}

			// Token: 0x060084F0 RID: 34032 RVA: 0x010AB648 File Offset: 0x010A9848
			internal static bool zZZ7Mup4uH0KoslUt8ye()
			{
				return false;
			}

			// Token: 0x040081E4 RID: 33252
			internal int $$switch$7005$39771;

			// Token: 0x040081E5 RID: 33253
			internal GameGui $mGameGui$39772;

			// Token: 0x040081E6 RID: 33254
			internal M603_ShadeInTheCity1 $self_$39773;
		}
	}
}
