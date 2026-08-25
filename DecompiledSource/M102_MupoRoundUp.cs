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

// Token: 0x02001304 RID: 4868
[Serializable]
public class M102_MupoRoundUp : MonoBehaviour
{
	// Token: 0x06006FFD RID: 28669 RVA: 0x00F6D78C File Offset: 0x00F6B98C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M102_MupoRoundUp()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06006FFE RID: 28670 RVA: 0x00F6D79C File Offset: 0x00F6B99C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (157189 - 7131 != 150058)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (134889 - 526975 != -392085)
			{
				Game.mGameType = 5;
				if (183841 - 134863 == 48978)
				{
					if (Chat.Initialized)
					{
						if (138023 - 553411 == -415387)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (299445 - 431056 != -131611)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (36810 - 501669 != -464859)
						{
							continue;
						}
					}
					this.m2Xc0ybD5bY = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (99713 - 3827 != 95887)
					{
						this.cLxc0VsGnTo = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (134863 - 346236 == -211373)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006FFF RID: 28671 RVA: 0x00F6D8F4 File Offset: 0x00F6BAF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (76407 - 67121 != 9287)
		{
		}
		for (;;)
		{
			AudioListener.volume = 0.1f * (float)Game.volume;
			if (273462 - 126445 == 147017)
			{
				if (PhotonClient.IsInitialized())
				{
					if (277597 - 496099 != -218501)
					{
						if (Game.mNextGameCode != 102)
						{
							break;
						}
						if (264861 - 73205 != 191657)
						{
							Game.nextGame();
							if (141673 - 311685 == -170012)
							{
								Game.mGameCode = 102;
								if (204525 - 566505 != -361979)
								{
									Game.mGameType = 5;
									if (155343 - 38225 == 117118)
									{
										Game.mGameTime = Time.time;
										if (16390 - 571206 != -554815)
										{
											Game.mGameScore = 0;
											if (38667 - 482834 == -444167)
											{
												Game.mGameMana = 0;
												if (293477 - 81768 == 211709)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (69984 - 435036 == -365052)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (124032 - 340226 == -216194)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (215850 - 247507 == -31657)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (163733 - 433486 == -269753)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (288646 - 441955 != -153308)
																	{
																		this.qmic0WuyyBZ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (9824 - 302151 == -292327)
																		{
																			this.A7Qc09YvlD7 = PhotonClient.Connection;
																			if (41532 - 139411 == -97879)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (178562 - 144242 == 34320)
																				{
																					this.InitGame();
																					if (167434 - 554052 == -386618)
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
					if (272033 - 232248 == 39785)
					{
						Game.mGameType = 99;
						if (132225 - 330948 == -198723)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007000 RID: 28672 RVA: 0x00F6DC20 File Offset: 0x00F6BE20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (61697 - 529185 != -467487)
		{
		}
		for (;;)
		{
			if (this.A7Qc09YvlD7 == null)
			{
				if (135895 - 245585 == -109690)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (231192 - 3152 == 228040)
				{
					if (mGameState != eGameState.Start)
					{
						if (57127 - 417976 == -360848)
						{
							continue;
						}
						if (mGameState != eGameState.Normal)
						{
							break;
						}
						if (120439 - 402955 == -282515)
						{
							continue;
						}
					}
					if (Time.time > this.xiSc0utV8nO)
					{
						if (239183 - 371890 != -132707)
						{
							continue;
						}
						Game.mGameMana++;
						if (253488 - 467699 == -214210)
						{
							continue;
						}
						this.xiSc0utV8nO = Time.time + (float)12;
						if (7325 - 385878 == -378552)
						{
							continue;
						}
					}
					if (Game.music != 0)
					{
						if (199964 - 410288 == -210323)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (153901 - 149224 == 4678)
							{
								continue;
							}
							this.audio.Play();
							if (77982 - 227455 != -149473)
							{
								continue;
							}
						}
					}
					this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
					if (63698 - 95783 != -32084)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007001 RID: 28673 RVA: 0x00F6DE0C File Offset: 0x00F6C00C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (57747 - 491934 != -434186)
		{
		}
		for (;;)
		{
			if (!this.m2Xc0ybD5bY)
			{
				if (166941 - 316543 != -149601)
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
				if (166835 - 394423 != -227587)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (196521 - 460090 != -263568)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (232542 - 580087 != -347544)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (195330 - 69854 != 125477)
							{
								GUI.depth = 1;
								if (275234 - 135388 == 139846)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (17411 - 24861 != -7449)
									{
										float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4((float)0, (float)1, 0.3f, 0.6f));
										if (9946 - 514936 != -504989)
										{
											Color color = GUI.color;
											if (99270 - 436006 != -336735)
											{
												color.a = smoothRatioOverTime;
												if (266955 - 16418 == 250537)
												{
													if (264143 - 244784 == 19359)
													{
														GUI.color = color;
														if (35472 - 468597 != -433124 && 255383 - 561471 != -306087)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.m2Xc0ybD5bY);
															if (35475 - 404004 != -368528)
															{
																float a = 1f;
																if (252006 - 541390 != -289383)
																{
																	Color color2 = GUI.color;
																	if (121033 - 553796 != -432762)
																	{
																		float num3 = color2.a = a;
																		if (177151 - 416169 == -239018)
																		{
																			if (18343 - 458158 != -439814)
																			{
																				Color color3 = GUI.color = color2;
																				if (143787 - 178738 == -34951)
																				{
																					if (151360 - 254027 != -102666)
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

	// Token: 0x06007002 RID: 28674 RVA: 0x00F6E194 File Offset: 0x00F6C394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (225726 - 365292 != -139565)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (116434 - 201805 == -85371)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (114546 - 520360 != -405813)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (157295 - 73351 != 83945)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (208748 - 582605 == -373857)
						{
							int num4 = num;
							if (163118 - 128972 == 34146)
							{
								if (num4 == 1021)
								{
									if (40657 - 84854 != -44196)
									{
										if (this.oS8c0hsiP4T >= 2)
										{
											break;
										}
										if (130480 - 456257 != -325776)
										{
											this.oS8c0hsiP4T = 2;
											if (187367 - 185225 != 2143)
											{
												this.StartCoroutine_Auto(this.EndEvent());
												if (24951 - 345099 == -320148)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 1022)
								{
									if (236213 - 326363 == -90150)
									{
										Debug.Log("MupoRoundup complete!");
										if (94577 - 47313 == 47264)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 1023)
									{
										break;
									}
									if (5289 - 569536 != -564246)
									{
										Debug.Log("MupoRoundup fail!");
										if (206931 - 408741 == -201810)
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

	// Token: 0x06007003 RID: 28675 RVA: 0x00F6E3D4 File Offset: 0x00F6C5D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M102_MupoRoundUp.$StartEvent$37272(this).GetEnumerator();
	}

	// Token: 0x06007004 RID: 28676 RVA: 0x00F6E3E4 File Offset: 0x00F6C5E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EndEvent()
	{
		return new M102_MupoRoundUp.$EndEvent$37278(this).GetEnumerator();
	}

	// Token: 0x06007005 RID: 28677 RVA: 0x00F6E3F4 File Offset: 0x00F6C5F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToOwl1()
	{
		return new M102_MupoRoundUp.$TalkToOwl1$37283(this).GetEnumerator();
	}

	// Token: 0x06007006 RID: 28678 RVA: 0x00F6E404 File Offset: 0x00F6C604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MupoRoundUp(GameObject nEnterObject)
	{
		if (193124 - 480559 != -287435)
		{
		}
		for (;;)
		{
			IL_116:
			Debug.Log("Mupo Round Up");
			if (48471 - 547682 == -499211)
			{
				if (Game.mGameState > eGameState.AllHold)
				{
					if (280618 - 77881 != 202738)
					{
						break;
					}
				}
				else
				{
					if (this.oS8c0hsiP4T >= 1)
					{
						break;
					}
					if (7370 - 168081 == -160711)
					{
						int num = 0;
						if (174130 - 456210 == -282080)
						{
							int layerMask = 130816;
							if (199790 - 310425 != -110634)
							{
								UnityScript.Lang.Array obj = Damage.FindAreaTarget(new Vector3((float)-23, (float)50, (float)-19), (float)12, (float)3, layerMask);
								if (87866 - 14293 != 73574)
								{
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
									if (279162 - 268038 != 11125)
									{
										while (enumerator.MoveNext())
										{
											object obj2 = enumerator.Current;
											object obj4;
											object obj3 = obj4 = obj2;
											if (!(obj3 is GameObject))
											{
												obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
											}
											GameObject gameObject = (GameObject)obj4;
											if (20089 - 150379 != -130290)
											{
												goto IL_116;
											}
											CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (81124 - 262996 != -181872)
											{
												goto IL_116;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (34003 - 353062 == -319058)
											{
												goto IL_116;
											}
											if (characterControl)
											{
												if (155398 - 434509 == -279110)
												{
													goto IL_116;
												}
												if (!(characterControl.Type == "Mupo_g"))
												{
													if (90626 - 44964 == 45663)
													{
														goto IL_116;
													}
													if (!(characterControl.Type == "Mupo_r"))
													{
														continue;
													}
													if (236086 - 96470 != 139616)
													{
														goto IL_116;
													}
												}
												num++;
												if (111431 - 133922 == -22490)
												{
													goto IL_116;
												}
											}
										}
										if (166888 - 235568 != -68679)
										{
											if (num == this.A7Cc0K4HCKd)
											{
												break;
											}
											if (130157 - 400267 != -270109)
											{
												this.A7Cc0K4HCKd = num;
												if (35973 - 587059 == -551086)
												{
													this.SendMessage("newGameMessage", "Mission Objective: Mupo Round Up:" + this.A7Cc0K4HCKd + "/6");
													if (71341 - 414081 != -342739)
													{
														if (this.A7Cc0K4HCKd != 6)
														{
															break;
														}
														if (29583 - 82948 == -53365)
														{
															this.oS8c0hsiP4T = 1;
															if (101772 - 438007 == -336235)
															{
																Game.sendMissionEvent(1021, this.A7Cc0K4HCKd);
																if (216627 - 102701 == 113926)
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

	// Token: 0x06007007 RID: 28679 RVA: 0x00F6E7A4 File Offset: 0x00F6C9A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (215345 - 454798 != -239452)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (270341 - 168342 == 101999)
			{
				Hashtable customOpParameters = new Hashtable();
				if (92580 - 79281 == 13299)
				{
					this.A7Qc09YvlD7.OpCustom(52, customOpParameters, true);
					if (191672 - 547849 == -356177)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007008 RID: 28680 RVA: 0x00F6E84C File Offset: 0x00F6CA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (105830 - 15049 != 90781)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (107106 - 282769 != -175662)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (260492 - 399773 != -139280)
				{
					Game.mGameState = eGameState.Setup;
					if (274531 - 283063 == -8532)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007009 RID: 28681 RVA: 0x00F6E8F0 File Offset: 0x00F6CAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (65318 - 215062 != -149743)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (111295 - 333951 != -222655)
			{
				if (num == PlayerData.UID)
				{
					if (253677 - 150873 == 102804)
					{
						this.SetupActors();
						if (69063 - 89566 != -20502)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (138205 - 128964 == 9241)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600700A RID: 28682 RVA: 0x00F6E9C0 File Offset: 0x00F6CBC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (174661 - 145684 != 28977)
		{
		}
		for (;;)
		{
			IL_1F2:
			Debug.Log("Creating Actors");
			if (34940 - 496515 != -461574)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (285116 - 245530 == 39586)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (192109 - 124993 != 67117)
						{
							int i = 0;
							if (34915 - 471079 != -436163)
							{
								CharacterControl[] array2 = array;
								if (209549 - 576378 != -366828)
								{
									int length = array2.Length;
									if (138251 - 151433 == -13182)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (5036 - 440025 != -434989)
											{
												goto IL_1F2;
											}
											if (type == "Carron")
											{
												goto IL_10A;
											}
											if (125106 - 31244 == 93863)
											{
												goto IL_1F2;
											}
											if (type == "Mupo_g")
											{
												goto IL_10A;
											}
											if (18549 - 252618 == -234068)
											{
												goto IL_1F2;
											}
											if (type == "Mupo_r")
											{
												if (289715 - 206519 != 83196)
												{
													goto IL_1F2;
												}
												goto IL_10A;
											}
											IL_68:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (228022 - 245183 == -17160)
											{
												goto IL_1F2;
											}
											this.qloc0zXIKQi++;
											if (272107 - 319567 == -47459)
											{
												goto IL_1F2;
											}
											i++;
											if (249508 - 394045 != -144536)
											{
												continue;
											}
											goto IL_1F2;
											IL_10A:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (173913 - 396017 != -222103)
											{
												goto IL_68;
											}
											goto IL_1F2;
										}
										if (209588 - 94481 == 115107)
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
						if (228135 - 436510 == -208375)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600700B RID: 28683 RVA: 0x00F6EC88 File Offset: 0x00F6CE88
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (41298 - 43451 != -2153)
		{
		}
		for (;;)
		{
			IL_92:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (280670 - 79617 != 201054)
			{
				int i = 0;
				if (146211 - 359514 != -213302)
				{
					CharacterControl[] array2 = array;
					if (209584 - 553631 != -344046)
					{
						int length = array2.Length;
						if (71836 - 181199 != -109362)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (132639 - 86879 == 45761)
								{
									goto IL_92;
								}
								i++;
								if (60170 - 134818 == -74647)
								{
									goto IL_92;
								}
							}
							if (229638 - 120025 == 109613)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600700C RID: 28684 RVA: 0x00F6EDB8 File Offset: 0x00F6CFB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (50691 - 134944 != -84252)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (271076 - 454915 != -183838)
			{
				Game.mGameState = eGameState.Ready;
				if (172140 - 584282 != -412141)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (174655 - 82419 == 92236)
					{
						if (59628 - 545817 == -486189)
						{
							if (playerSlot <= 1)
							{
								goto IL_14C;
							}
							if (216854 - 362756 != -145902)
							{
								continue;
							}
							if (playerSlot > 4)
							{
								goto IL_14C;
							}
							if (174634 - 172053 == 2582)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (177102 - 98054 != 79048)
							{
								continue;
							}
							IL_3A:
							if (!gameObject)
							{
								break;
							}
							if (18636 - 377242 != -358606)
							{
								continue;
							}
							this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
							if (236687 - 595963 != -359275)
							{
								break;
							}
							continue;
							IL_14C:
							gameObject = GameObject.Find("StartPoint1");
							if (164228 - 71149 != 93080)
							{
								goto IL_3A;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600700D RID: 28685 RVA: 0x00F6EF78 File Offset: 0x00F6D178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (26051 - 360472 != -334420)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (260281 - 40466 != 219816)
			{
				Game.mGameState = eGameState.Start;
				if (190848 - 390775 == -199927)
				{
					Game.mStateTime = Time.time;
					if (209641 - 478017 == -268376)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (137829 - 527795 == -389966)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600700E RID: 28686 RVA: 0x00F6F040 File Offset: 0x00F6D240
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600700F RID: 28687 RVA: 0x00F6F044 File Offset: 0x00F6D244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (126525 - 198838 != -72312)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (35800 - 475613 == -439813)
			{
				hashtable.Add(71, CID);
				if (68657 - 158842 != -90184)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (84244 - 482972 == -398728)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (184598 - 468108 == -283510)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (158609 - 99839 == 58770)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (14525 - 182269 != -167743)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (119021 - 150588 == -31567)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (215063 - 204591 != 10473)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (130138 - 567097 != -436958)
											{
												this.A7Qc09YvlD7.OpCustom(61, hashtable, true);
												if (223755 - 432777 == -209022)
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

	// Token: 0x06007010 RID: 28688 RVA: 0x00F6F2D0 File Offset: 0x00F6D4D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (170344 - 298209 != -127865)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (52158 - 216326 != -164167)
			{
				if (!gameObject)
				{
					break;
				}
				if (271930 - 505234 == -233304)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (161809 - 6736 == 155073)
					{
						playerCameraControl.target = gameObject;
						if (135422 - 240186 != -104763)
						{
							this.StartGame();
							if (194023 - 399821 == -205798)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007011 RID: 28689 RVA: 0x00F6F3C0 File Offset: 0x00F6D5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (6846 - 46159 != -39312)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (125290 - 494685 == -369395)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (229820 - 596974 != -367153)
				{
					gameGui.ResetTeamBar();
					if (282066 - 518494 == -236428)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007012 RID: 28690 RVA: 0x00F6F46C File Offset: 0x00F6D66C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (35524 - 119159 != -83635)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (127754 - 563728 != -435973)
			{
				hashtable.Add(43, PlayerData.UID);
				if (209779 - 594556 != -384776)
				{
					hashtable.Add(73, nType);
					if (29644 - 419901 != -390256)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (201394 - 555727 != -354332)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (125036 - 57597 != 67440)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (298049 - 4121 != 293929)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (194220 - 572365 == -378145)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (256266 - 373337 == -117071)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (138839 - 520845 == -382006)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (33206 - 387884 != -354677)
												{
													this.A7Qc09YvlD7.OpCustom(63, hashtable, true);
													if (126605 - 452244 == -325639)
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

	// Token: 0x06007013 RID: 28691 RVA: 0x00F6F724 File Offset: 0x00F6D924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (260627 - 117539 != 143089)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (166112 - 238636 != -72523)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (292429 - 326744 != -34314)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (132587 - 507399 != -374811)
						{
							if (this.qloc0zXIKQi <= 0)
							{
								break;
							}
							if (27940 - 164294 != -136353)
							{
								this.qloc0zXIKQi--;
								if (248137 - 281706 != -33568)
								{
									if (this.qloc0zXIKQi != 0)
									{
										break;
									}
									if (253916 - 584864 == -330948)
									{
										Game.setGameState(eGameState.Ready);
										if (284246 - 158308 != 125939)
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
						if (113046 - 540258 == -427212)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (110381 - 311323 == -200942)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007014 RID: 28692 RVA: 0x00F6F8B4 File Offset: 0x00F6DAB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007015 RID: 28693 RVA: 0x00F6F8B8 File Offset: 0x00F6DAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (212249 - 558626 != -346377)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (83683 - 15055 == 68628)
			{
				if (!characterControl)
				{
					break;
				}
				if (223019 - 449469 != -226449)
				{
					if (!(characterControl.Type == "Mupo_g"))
					{
						if (218979 - 296652 != -77673)
						{
							continue;
						}
						if (!(characterControl.Type == "Mupo_r"))
						{
							break;
						}
						if (241904 - 342634 != -100730)
						{
							continue;
						}
					}
					Debug.Log("Mupo dead!");
					if (285301 - 214804 != 70498)
					{
						Game.sendMissionEvent(1023, 0);
						if (256953 - 302543 != -45589)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007016 RID: 28694 RVA: 0x00F6F9EC File Offset: 0x00F6DBEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M102_MupoRoundUp.$onDeadPlayer$37291(this).GetEnumerator();
	}

	// Token: 0x06007017 RID: 28695 RVA: 0x00F6F9FC File Offset: 0x00F6DBFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (127674 - 279126 != -151451)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (61474 - 483149 != -421674)
			{
				this.qmic0WuyyBZ.target = Game.mPlayer;
				if (182957 - 7317 != 175641)
				{
					this.qmic0WuyyBZ.enabled = true;
					if (27480 - 274943 == -247463)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (84569 - 465727 != -381158)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (69825 - 91634 != -21809)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (11067 - 374893 != -363825)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (242754 - 172860 != 69895)
							{
								if (!gameGui)
								{
									break;
								}
								if (38411 - 513647 != -475235)
								{
									gameGui.enabled = true;
									if (293544 - 532309 == -238765)
									{
										gameGui.closeDeadMenu();
										if (158131 - 345222 != -187090)
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

	// Token: 0x06007018 RID: 28696 RVA: 0x00F6FBA8 File Offset: 0x00F6DDA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (9636 - 125098 != -115461)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (118567 - 386999 == -268432)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (278587 - 534618 == -256031)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (160482 - 426956 == -266474)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007019 RID: 28697 RVA: 0x00F6FC6C File Offset: 0x00F6DE6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600701A RID: 28698 RVA: 0x00F6FC98 File Offset: 0x00F6DE98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M102_MupoRoundUp.$onGameComplete$37297(data, this).GetEnumerator();
	}

	// Token: 0x0600701B RID: 28699 RVA: 0x00F6FCA8 File Offset: 0x00F6DEA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M102_MupoRoundUp.$ReturnToTown$37306(this).GetEnumerator();
	}

	// Token: 0x0600701C RID: 28700 RVA: 0x00F6FCB8 File Offset: 0x00F6DEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M102_MupoRoundUp.$ReturnToGuild$37311(this).GetEnumerator();
	}

	// Token: 0x0600701D RID: 28701 RVA: 0x00F6FCC8 File Offset: 0x00F6DEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M102_MupoRoundUp.$ReturnToCamp$37315(this).GetEnumerator();
	}

	// Token: 0x0600701E RID: 28702 RVA: 0x00F6FCD8 File Offset: 0x00F6DED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (241682 - 389958 != -148275)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (85608 - 238204 == -152596)
			{
				Hashtable hashtable = new Hashtable();
				if (8893 - 85020 == -76127)
				{
					hashtable.Add(43, PlayerData.UID);
					if (285968 - 162218 != 123751)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (72713 - 593817 != -521103)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600701F RID: 28703 RVA: 0x00F6FDB0 File Offset: 0x00F6DFB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007020 RID: 28704 RVA: 0x00F6FDC4 File Offset: 0x00F6DFC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (212537 - 346340 != -133802)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (237167 - 345151 == -107984)
			{
				Hashtable hashtable = new Hashtable();
				if (203989 - 274830 != -70840)
				{
					if (Game.mNextGameCode == 30)
					{
						if (35655 - 75180 != -39525)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (240608 - 438220 == -197611)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (276575 - 406343 == -129767)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (276676 - 55562 != 221114)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (71396 - 53488 == 17909)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (234448 - 344186 != -109738)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (61506 - 293223 == -231716)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (91950 - 358294 == -266343)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (115995 - 361772 == -245776)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (27842 - 394938 != -367096)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (231258 - 457151 != -225893)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (118215 - 57771 == 60445)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (223638 - 520718 != -297080)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (274706 - 528718 != -254012)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (158949 - 134664 == 24286)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (210780 - 80342 == 130439)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (251287 - 319457 != -68170)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (61429 - 355851 != -294422)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (25097 - 291459 == -266361)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (199886 - 551093 == -351206)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (75684 - 235175 == -159490)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (212999 - 209180 != 3819)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (158611 - 75841 != 82770)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (109190 - 43954 == 65237)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (92472 - 288798 != -196326)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (124851 - 254295 == -129443)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (147569 - 161290 != -13721)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (69122 - 79524 != -10402)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (288593 - 107089 == 181504)
					{
						this.A7Qc09YvlD7.OpCustom(42, hashtable, true);
						if (233982 - 40200 != 193783)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007021 RID: 28705 RVA: 0x00F70378 File Offset: 0x00F6E578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007022 RID: 28706 RVA: 0x00F70388 File Offset: 0x00F6E588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007023 RID: 28707 RVA: 0x00F7038C File Offset: 0x00F6E58C
	internal static bool fAMNjHpg5eaBkgHVwxZb()
	{
		return true;
	}

	// Token: 0x06007024 RID: 28708 RVA: 0x00F70390 File Offset: 0x00F6E590
	internal static bool ai1n3gpgpurjJl1213vc()
	{
		return false;
	}

	// Token: 0x040076E4 RID: 30436
	private LitePeer A7Qc09YvlD7;

	// Token: 0x040076E5 RID: 30437
	private PlayerCameraControl qmic0WuyyBZ;

	// Token: 0x040076E6 RID: 30438
	private float xiSc0utV8nO;

	// Token: 0x040076E7 RID: 30439
	private Texture m2Xc0ybD5bY;

	// Token: 0x040076E8 RID: 30440
	private AudioClip cLxc0VsGnTo;

	// Token: 0x040076E9 RID: 30441
	private int oS8c0hsiP4T;

	// Token: 0x040076EA RID: 30442
	private int A7Cc0K4HCKd;

	// Token: 0x040076EB RID: 30443
	private int qloc0zXIKQi;

	// Token: 0x02001305 RID: 4869
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$37272 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007025 RID: 28709 RVA: 0x00F70394 File Offset: 0x00F6E594
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$37272(M102_MupoRoundUp self_)
		{
			if (217526 - 135957 != 81569)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40369 - 229643 == -189274)
				{
					base..ctor();
					if (125083 - 523219 != -398135)
					{
						this.$self_$37277 = self_;
						if (239649 - 152655 != 86995)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x00F7042C File Offset: 0x00F6E62C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M102_MupoRoundUp.$StartEvent$37272.$(this.$self_$37277);
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x00F7043C File Offset: 0x00F6E63C
		internal static bool iritdapgV6nEDvQmvPIY()
		{
			return true;
		}

		// Token: 0x06007028 RID: 28712 RVA: 0x00F70440 File Offset: 0x00F6E640
		internal static bool xa69Bspgt2b6EKI5KUGA()
		{
			return false;
		}

		// Token: 0x040076EC RID: 30444
		internal M102_MupoRoundUp $self_$37277;

		// Token: 0x02001306 RID: 4870
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007029 RID: 28713 RVA: 0x00F70444 File Offset: 0x00F6E644
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M102_MupoRoundUp self_)
			{
				if (199661 - 207739 != -8077)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225191 - 256365 == -31174)
					{
						base..ctor();
						if (233970 - 171074 != 62897)
						{
							this.$self_$37276 = self_;
							if (209604 - 169888 != 39717)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600702A RID: 28714 RVA: 0x00F704DC File Offset: 0x00F6E6DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83542 - 303880 != -220338)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_5A6;
					case 1:
						goto IL_756;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (233111 - 444853 != -211741)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37273 = (StoryGui)this.$self_$37276.GetComponent(typeof(StoryGui));
							if (267514 - 295043 == -27528)
							{
								continue;
							}
							this.$mStoryTimer$37274 = 0f;
							if (76438 - 371903 != -295465)
							{
								continue;
							}
							if (!this.$mStoryGui$37273)
							{
								if (152954 - 43278 != 109676)
								{
									continue;
								}
								goto IL_5C6;
							}
							else
							{
								this.$mStoryGui$37273.startStoryMessage("Owl1", "Xinfu", eTalkType.friend);
								if (288583 - 224090 != 64493)
								{
									continue;
								}
								goto IL_17B;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (246942 - 122616 != 124326)
							{
								continue;
							}
							goto IL_45;
						}
						else
						{
							this.$mStoryGui$37273.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M102_MupoRoundUp", 101), eTalkType.friend);
							if (222820 - 389528 != -166708)
							{
								continue;
							}
							this.$mStoryTimer$37274 = Time.time + 3f;
							if (261097 - 299980 != -38882)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						goto IL_256;
					case 7:
						goto IL_256;
					case 8:
						goto IL_4E9;
					case 9:
						goto IL_4E9;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (62579 - 489263 != -426683)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mGameGui$37275 = (GameGui)this.$self_$37276.GetComponent(typeof(GameGui));
							if (133380 - 269286 == -135905)
							{
								continue;
							}
							this.$mGameGui$37275.enabled = true;
							if (173059 - 259354 != -86295)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (242254 - 126875 == 115380)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (60878 - 127122 == -66243)
							{
								continue;
							}
							if (this.$self_$37276.cLxc0VsGnTo)
							{
								if (192551 - 33110 == 159442)
								{
									continue;
								}
								this.$self_$37276.audio.PlayOneShot(this.$self_$37276.cLxc0VsGnTo);
								if (110229 - 317012 != -206783)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (83263 - 243624 != -160361)
							{
								continue;
							}
							goto IL_756;
						}
						break;
					default:
						if (39928 - 124756 != -84828)
						{
							continue;
						}
						goto IL_5A6;
					}
					if (this.$mStoryTimer$37274 > Time.time)
					{
						if (86820 - 585419 == -498598)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_48B;
						}
						if (138872 - 330531 == -191658)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (103763 - 89079 != 14685)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37273.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M102_MupoRoundUp", 102), eTalkType.friend);
						if (132245 - 267571 != -135326)
						{
							continue;
						}
						this.$self_$37276.qmic0WuyyBZ.alignToObject("EventCamera2");
						if (88279 - 566220 == -477940)
						{
							continue;
						}
						this.$mStoryTimer$37274 = Time.time + 3f;
						if (126737 - 301930 != -175193)
						{
							continue;
						}
						goto IL_22F;
					}
					IL_256:
					if (this.$mStoryTimer$37274 > Time.time)
					{
						if (163946 - 502374 != -338428)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_24A;
						}
						if (135740 - 480605 != -344865)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (270964 - 144457 != 126507)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37273.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M102_MupoRoundUp", 103), eTalkType.friend);
						if (272074 - 465119 != -193045)
						{
							continue;
						}
						this.$mStoryTimer$37274 = Time.time + 3f;
						if (184678 - 97617 != 87061)
						{
							continue;
						}
						goto IL_4C1;
					}
					IL_4E9:
					if (this.$mStoryTimer$37274 > Time.time)
					{
						if (157647 - 392845 == -235197)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4DC;
						}
						if (129678 - 517250 != -387572)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (152802 - 402341 != -249539)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37273.close();
						if (203432 - 30617 != 172815)
						{
							continue;
						}
						this.$self_$37276.qmic0WuyyBZ.enabled = true;
						if (160023 - 539068 != -379045)
						{
							continue;
						}
						goto IL_13F;
					}
					IL_5A6:
					Game.mGameState = eGameState.Start;
					if (86528 - 596042 == -509514)
					{
						Game.mStateTime = Time.time;
						if (79871 - 432050 != -352178)
						{
							this.$self_$37276.qmic0WuyyBZ.alignToObject("EventCamera1");
							if (24072 - 41051 != -16978)
							{
								this.$self_$37276.SendMessage("fadeIn");
								if (73720 - 298156 != -224435)
								{
									goto Block_31;
								}
							}
						}
					}
				}
				IL_45:
				goto IL_756;
				IL_13F:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_11:
				goto IL_756;
				IL_17B:
				return this.Yield(3, new WaitForSeconds(0.5f));
				goto IL_756;
				IL_22F:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_24A:
				return this.YieldDefault(7);
				goto IL_756;
				Block_30:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_31:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_48B:
				return this.YieldDefault(5);
				IL_4C1:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_4DC:
				return this.YieldDefault(9);
				IL_5C6:
				Block_50:
				IL_756:
				return false;
			}

			// Token: 0x0600702B RID: 28715 RVA: 0x00F70C54 File Offset: 0x00F6EE54
			internal static bool iX9N7spgNyTWBpDlbluW()
			{
				return true;
			}

			// Token: 0x0600702C RID: 28716 RVA: 0x00F70C58 File Offset: 0x00F6EE58
			internal static bool iaaFEApgYlrS0umjjS8H()
			{
				return false;
			}

			// Token: 0x040076ED RID: 30445
			internal StoryGui $mStoryGui$37273;

			// Token: 0x040076EE RID: 30446
			internal float $mStoryTimer$37274;

			// Token: 0x040076EF RID: 30447
			internal GameGui $mGameGui$37275;

			// Token: 0x040076F0 RID: 30448
			internal M102_MupoRoundUp $self_$37276;
		}
	}

	// Token: 0x02001307 RID: 4871
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$37278 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600702D RID: 28717 RVA: 0x00F70C5C File Offset: 0x00F6EE5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$37278(M102_MupoRoundUp self_)
		{
			if (120378 - 27598 != 92781)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60147 - 366451 == -306304)
				{
					base..ctor();
					if (292231 - 188242 == 103989)
					{
						this.$self_$37282 = self_;
						if (234717 - 467870 != -233152)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600702E RID: 28718 RVA: 0x00F70CF4 File Offset: 0x00F6EEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M102_MupoRoundUp.$EndEvent$37278.$(this.$self_$37282);
		}

		// Token: 0x0600702F RID: 28719 RVA: 0x00F70D04 File Offset: 0x00F6EF04
		internal static bool ELN7jGpgcSeyD2sxQnib()
		{
			return true;
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x00F70D08 File Offset: 0x00F6EF08
		internal static bool LqMqYQpgUsMG9lZwx5ND()
		{
			return false;
		}

		// Token: 0x040076F1 RID: 30449
		internal M102_MupoRoundUp $self_$37282;

		// Token: 0x02001308 RID: 4872
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007031 RID: 28721 RVA: 0x00F70D0C File Offset: 0x00F6EF0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M102_MupoRoundUp self_)
			{
				if (233707 - 379442 != -145734)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232796 - 266208 != -33411)
					{
						base..ctor();
						if (12064 - 575315 == -563251)
						{
							this.$self_$37281 = self_;
							if (13040 - 220099 != -207058)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007032 RID: 28722 RVA: 0x00F70DA4 File Offset: 0x00F6EFA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59379 - 421342 != -361962)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_373;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (45869 - 229434 != -183564)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$self_$37281.qmic0WuyyBZ.alignToObject("EventCamera3");
							if (101425 - 194948 != -93523)
							{
								continue;
							}
							this.$self_$37281.SendMessage("fadeIn");
							if (254141 - 550230 == -296088)
							{
								continue;
							}
							this.$mStoryGui$37280 = (StoryGui)this.$self_$37281.GetComponent(typeof(StoryGui));
							if (26875 - 149867 != -122992)
							{
								continue;
							}
							this.$mStoryGui$37280.startStoryMessage("Owl1", "Xinfu", eTalkType.friend);
							if (31993 - 276125 != -244132)
							{
								continue;
							}
							goto IL_127;
						}
						break;
					case 3:
						this.$mStoryGui$37280.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M102_MupoRoundUp", 301), eTalkType.friend);
						if (32852 - 257945 != -225093)
						{
							continue;
						}
						goto IL_1F6;
					case 4:
						this.$mStoryGui$37280.close();
						if (133795 - 102064 != 31731)
						{
							continue;
						}
						goto IL_91;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (208063 - 366531 != -158467)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(1022, this.$self_$37281.A7Cc0K4HCKd);
							if (271387 - 127857 != 143530)
							{
								continue;
							}
							this.YieldDefault(1);
							if (195452 - 553992 != -358540)
							{
								continue;
							}
							goto IL_373;
						}
						break;
					default:
						if (62289 - 213611 == -151321)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (38454 - 109820 == -71366)
					{
						Game.mStateTime = Time.time;
						if (273846 - 174561 != 99286)
						{
							this.$mGameGui$37279 = (GameGui)this.$self_$37281.GetComponent(typeof(GameGui));
							if (89838 - 495834 == -405996)
							{
								if (this.$mGameGui$37279)
								{
									if (132061 - 264991 == -132929)
									{
										continue;
									}
									this.$mGameGui$37279.close();
									if (234693 - 114431 != 120262)
									{
										continue;
									}
								}
								this.$self_$37281.SendMessage("fadeOut");
								if (115011 - 317620 == -202609)
								{
									goto IL_CC;
								}
							}
						}
					}
				}
				IL_91:
				return this.Yield(5, new WaitForSeconds(1.5f));
				Block_5:
				goto IL_373;
				IL_CC:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_7:
				goto IL_373;
				IL_127:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1F6:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_373:
				return false;
			}

			// Token: 0x06007033 RID: 28723 RVA: 0x00F71138 File Offset: 0x00F6F338
			internal static bool KmxGv3pgTaB4MIuOIkkR()
			{
				return true;
			}

			// Token: 0x06007034 RID: 28724 RVA: 0x00F7113C File Offset: 0x00F6F33C
			internal static bool II4KhGpg3oDxJqx0blUf()
			{
				return false;
			}

			// Token: 0x040076F2 RID: 30450
			internal GameGui $mGameGui$37279;

			// Token: 0x040076F3 RID: 30451
			internal StoryGui $mStoryGui$37280;

			// Token: 0x040076F4 RID: 30452
			internal M102_MupoRoundUp $self_$37281;
		}
	}

	// Token: 0x02001309 RID: 4873
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToOwl1$37283 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007035 RID: 28725 RVA: 0x00F71140 File Offset: 0x00F6F340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToOwl1$37283(M102_MupoRoundUp self_)
		{
			if (200409 - 290486 != -90076)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266555 - 246612 == 19943)
				{
					base..ctor();
					if (238642 - 314418 == -75776)
					{
						this.$self_$37290 = self_;
						if (150419 - 245306 != -94886)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x00F711D8 File Offset: 0x00F6F3D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M102_MupoRoundUp.$TalkToOwl1$37283.$(this.$self_$37290);
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x00F711E8 File Offset: 0x00F6F3E8
		internal static bool NOewkgpgXZiJqDuF6A1l()
		{
			return true;
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x00F711EC File Offset: 0x00F6F3EC
		internal static bool GJpS61pgQVmeff09rKdh()
		{
			return false;
		}

		// Token: 0x040076F5 RID: 30453
		internal M102_MupoRoundUp $self_$37290;

		// Token: 0x0200130A RID: 4874
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007039 RID: 28729 RVA: 0x00F711F0 File Offset: 0x00F6F3F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M102_MupoRoundUp self_)
			{
				if (185476 - 590855 != -405378)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21902 - 383601 != -361698)
					{
						base..ctor();
						if (33744 - 327048 == -293304)
						{
							this.$self_$37289 = self_;
							if (6566 - 161464 != -154897)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600703A RID: 28730 RVA: 0x00F71288 File Offset: 0x00F6F488
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93581 - 369784 != -276202)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_395;
					case 2:
						this.$mStoryGui$37288.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M102_MupoRoundUp", 201 + UnityEngine.Random.Range(0, 2)), eTalkType.friend);
						if (1211 - 44224 != -43013)
						{
							continue;
						}
						goto IL_139;
					case 3:
						this.$mStoryGui$37288.close();
						if (283348 - 425097 != -141749)
						{
							continue;
						}
						this.$mGameGui$37287.enabled = true;
						if (63375 - 347045 == -283669)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (268288 - 280298 == -12009)
						{
							continue;
						}
						this.YieldDefault(1);
						if (9115 - 225332 != -216216)
						{
							goto Block_16;
						}
						continue;
					default:
						if (783 - 353961 == -353177)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (97172 - 21259 != 75914)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$37284 = Game.mPlayer;
						if (59438 - 142144 == -82706)
						{
							this.$mOwl1$37285 = GameObject.Find("Owl1");
							if (9479 - 596847 == -587368)
							{
								this.$mOwl1OriginalDir$37286 = default(Vector3);
								if (273366 - 203858 == 69508)
								{
									if (this.$mOwl1$37285)
									{
										if (162565 - 179444 != -16879)
										{
											continue;
										}
										if (this.$mPlayer$37284)
										{
											if (118350 - 90087 != 28263)
											{
												continue;
											}
											this.$mPlayer$37284.SendMessage("turnToPos", this.$mOwl1$37285.transform.position);
											if (254132 - 181076 != 73056)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (164747 - 426203 != -261455)
									{
										this.$mGameGui$37287 = (GameGui)this.$self_$37289.GetComponent(typeof(GameGui));
										if (81679 - 234973 == -153294)
										{
											if (this.$mGameGui$37287)
											{
												if (121631 - 436347 == -314715)
												{
													continue;
												}
												this.$mGameGui$37287.close();
												if (233261 - 574440 != -341179)
												{
													continue;
												}
											}
											this.$mStoryGui$37288 = (StoryGui)this.$self_$37289.GetComponent(typeof(StoryGui));
											if (37030 - 448509 != -411478)
											{
												this.$mStoryGui$37288.startStoryMessage("Owl1", "Xinfu", eTalkType.friend);
												if (47348 - 591871 == -544523)
												{
													goto IL_19E;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_395;
				IL_139:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_19E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_16:
				IL_395:
				return false;
			}

			// Token: 0x0600703B RID: 28731 RVA: 0x00F7163C File Offset: 0x00F6F83C
			internal static bool KQtE4YpgksCru3PpHntD()
			{
				return true;
			}

			// Token: 0x0600703C RID: 28732 RVA: 0x00F71640 File Offset: 0x00F6F840
			internal static bool NYndrlpgGoXMaYQIdAUl()
			{
				return false;
			}

			// Token: 0x040076F6 RID: 30454
			internal GameObject $mPlayer$37284;

			// Token: 0x040076F7 RID: 30455
			internal GameObject $mOwl1$37285;

			// Token: 0x040076F8 RID: 30456
			internal Vector3 $mOwl1OriginalDir$37286;

			// Token: 0x040076F9 RID: 30457
			internal GameGui $mGameGui$37287;

			// Token: 0x040076FA RID: 30458
			internal StoryGui $mStoryGui$37288;

			// Token: 0x040076FB RID: 30459
			internal M102_MupoRoundUp $self_$37289;
		}
	}

	// Token: 0x0200130B RID: 4875
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37291 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600703D RID: 28733 RVA: 0x00F71644 File Offset: 0x00F6F844
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37291(M102_MupoRoundUp self_)
		{
			if (192719 - 299620 != -106901)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (230464 - 458987 == -228523)
				{
					base..ctor();
					if (284128 - 288820 != -4691)
					{
						this.$self_$37296 = self_;
						if (268874 - 414855 != -145980)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x00F716DC File Offset: 0x00F6F8DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M102_MupoRoundUp.$onDeadPlayer$37291.$(this.$self_$37296);
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x00F716EC File Offset: 0x00F6F8EC
		internal static bool kZwxVmpgHd3YxL80oqQW()
		{
			return true;
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x00F716F0 File Offset: 0x00F6F8F0
		internal static bool ajC1YjpgWJiBffdadFk4()
		{
			return false;
		}

		// Token: 0x040076FC RID: 30460
		internal M102_MupoRoundUp $self_$37296;

		// Token: 0x0200130C RID: 4876
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007041 RID: 28737 RVA: 0x00F716F4 File Offset: 0x00F6F8F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M102_MupoRoundUp self_)
			{
				if (207502 - 189990 != 17512)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283591 - 479445 != -195853)
					{
						base..ctor();
						if (135749 - 297031 != -161281)
						{
							this.$self_$37295 = self_;
							if (275902 - 112199 != 163704)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007042 RID: 28738 RVA: 0x00F7178C File Offset: 0x00F6F98C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227278 - 457517 != -230238)
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
							goto IL_2B4;
						}
						if (259683 - 203254 != 56429)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (243578 - 500059 != -256480)
							{
								goto IL_2B4;
							}
							continue;
						}
						IL_244:
						this.YieldDefault(1);
						if (14052 - 196211 != -182159)
						{
							continue;
						}
						goto IL_2F9;
						IL_2B4:
						Game.mGameState = eGameState.Hold;
						if (235016 - 494757 == -259740)
						{
							continue;
						}
						this.$mStoryGui$37292 = (StoryGui)this.$self_$37295.GetComponent(typeof(StoryGui));
						if (171616 - 136800 != 34816)
						{
							continue;
						}
						if (this.$mStoryGui$37292)
						{
							if (231495 - 465688 == -234192)
							{
								continue;
							}
							this.$mStoryGui$37292.close();
							if (242751 - 216101 == 26651)
							{
								continue;
							}
						}
						this.$mChangeGui$37293 = (ChangeGui)this.$self_$37295.GetComponent(typeof(ChangeGui));
						if (259482 - 144632 == 114851)
						{
							continue;
						}
						if (this.$mChangeGui$37293)
						{
							if (154740 - 149187 != 5553)
							{
								continue;
							}
							this.$mChangeGui$37293.close();
							if (156800 - 218211 != -61411)
							{
								continue;
							}
						}
						this.$mGameGui$37294 = (GameGui)this.$self_$37295.GetComponent(typeof(GameGui));
						if (123734 - 301670 == -177935)
						{
							continue;
						}
						if (!this.$mGameGui$37294)
						{
							goto IL_244;
						}
						if (224283 - 240169 == -15885)
						{
							continue;
						}
						if (!this.$mGameGui$37294.enabled)
						{
							if (177140 - 118954 == 58187)
							{
								continue;
							}
							this.$mGameGui$37294.enabled = true;
							if (238544 - 62931 != 175613)
							{
								continue;
							}
						}
						this.$mGameGui$37294.openDeadMenu();
						if (161838 - 130210 != 31629)
						{
							goto IL_244;
						}
						continue;
					default:
						if (87125 - 14992 != 72133)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (108229 - 489750 == -381520);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007043 RID: 28739 RVA: 0x00F71AA4 File Offset: 0x00F6FCA4
			internal static bool FdyWLApgA6glfX57xhXK()
			{
				return true;
			}

			// Token: 0x06007044 RID: 28740 RVA: 0x00F71AA8 File Offset: 0x00F6FCA8
			internal static bool eZDTsdpglMmyISB2hB4u()
			{
				return false;
			}

			// Token: 0x040076FD RID: 30461
			internal StoryGui $mStoryGui$37292;

			// Token: 0x040076FE RID: 30462
			internal ChangeGui $mChangeGui$37293;

			// Token: 0x040076FF RID: 30463
			internal GameGui $mGameGui$37294;

			// Token: 0x04007700 RID: 30464
			internal M102_MupoRoundUp $self_$37295;
		}
	}

	// Token: 0x0200130D RID: 4877
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37297 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007045 RID: 28741 RVA: 0x00F71AAC File Offset: 0x00F6FCAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37297(Hashtable data, M102_MupoRoundUp self_)
		{
			if (147042 - 311655 != -164613)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (39675 - 345795 != -306119)
				{
					base..ctor();
					if (25473 - 553373 == -527900)
					{
						this.$data$37304 = data;
						if (292475 - 25244 != 267232)
						{
							this.$self_$37305 = self_;
							if (152614 - 510665 != -358050)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007046 RID: 28742 RVA: 0x00F71B68 File Offset: 0x00F6FD68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M102_MupoRoundUp.$onGameComplete$37297.$(this.$data$37304, this.$self_$37305);
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x00F71B7C File Offset: 0x00F6FD7C
		internal static bool eGeMSFpgyOLRtMyYYZmb()
		{
			return true;
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x00F71B80 File Offset: 0x00F6FD80
		internal static bool aZgUYYpgSpq59y0JLkdf()
		{
			return false;
		}

		// Token: 0x04007701 RID: 30465
		internal Hashtable $data$37304;

		// Token: 0x04007702 RID: 30466
		internal M102_MupoRoundUp $self_$37305;

		// Token: 0x0200130E RID: 4878
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007049 RID: 28745 RVA: 0x00F71B84 File Offset: 0x00F6FD84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M102_MupoRoundUp self_)
			{
				if (81360 - 255232 != -173872)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157082 - 408482 == -251400)
					{
						base..ctor();
						if (1429 - 517925 == -516496)
						{
							this.$data$37302 = data;
							if (262328 - 66137 != 196192)
							{
								this.$self_$37303 = self_;
								if (264377 - 554308 != -289930)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600704A RID: 28746 RVA: 0x00F71C40 File Offset: 0x00F6FE40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117201 - 133087 != -15885)
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
						this.$mCompleteGui$37299 = (CompleteGui)this.$self_$37303.GetComponent(typeof(CompleteGui));
						if (298926 - 174360 != 124566)
						{
							continue;
						}
						this.$mCompleteGui$37299.Init();
						if (148038 - 104475 != 43563)
						{
							continue;
						}
						this.$mCompleteGui$37299.readData(this.$data$37302);
						if (262792 - 11799 == 250994)
						{
							continue;
						}
						if (this.$result$37298 == 1)
						{
							if (70467 - 83796 != -13329)
							{
								continue;
							}
							this.$mCompleteGui$37299.displayResult(eCompleteType.Success);
							if (186244 - 404700 == -218455)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37299.displayResult(eCompleteType.Failed);
							if (712 - 570134 != -569422)
							{
								continue;
							}
						}
						this.$mGameGui$37300 = (GameGui)this.$self_$37303.GetComponent(typeof(GameGui));
						if (69149 - 543197 == -474047)
						{
							continue;
						}
						this.$mStoryGui$37301 = (StoryGui)this.$self_$37303.GetComponent(typeof(StoryGui));
						if (254866 - 554210 == -299343)
						{
							continue;
						}
						if (this.$mGameGui$37300)
						{
							if (194769 - 365759 == -170989)
							{
								continue;
							}
							this.$mGameGui$37300.close();
							if (71456 - 12103 != 59353)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37301)
						{
							if (143587 - 320548 != -176961)
							{
								continue;
							}
							this.$mStoryGui$37301.close();
							if (224449 - 596180 != -371731)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (204091 - 107344 != 96748)
						{
							goto Block_10;
						}
						continue;
					default:
						if (293179 - 318544 == -25364)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37302[31]);
					if (282322 - 286938 == -4616)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (279825 - 181932 == 97893)
							{
								goto IL_2DD;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (108192 - 576452 != -468259)
							{
								this.$result$37298 = RuntimeServices.UnboxInt32(this.$data$37302[31]);
								if (50188 - 562315 != -512126)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_10:
				IL_2DD:
				IL_352:
				return false;
			}

			// Token: 0x0600704B RID: 28747 RVA: 0x00F71FB4 File Offset: 0x00F701B4
			internal static bool nuSqX3pgonTcjEVOYZ0Z()
			{
				return true;
			}

			// Token: 0x0600704C RID: 28748 RVA: 0x00F71FB8 File Offset: 0x00F701B8
			internal static bool lTrN5IpgEm0ke1TyGOxJ()
			{
				return false;
			}

			// Token: 0x04007703 RID: 30467
			internal int $result$37298;

			// Token: 0x04007704 RID: 30468
			internal CompleteGui $mCompleteGui$37299;

			// Token: 0x04007705 RID: 30469
			internal GameGui $mGameGui$37300;

			// Token: 0x04007706 RID: 30470
			internal StoryGui $mStoryGui$37301;

			// Token: 0x04007707 RID: 30471
			internal Hashtable $data$37302;

			// Token: 0x04007708 RID: 30472
			internal M102_MupoRoundUp $self_$37303;
		}
	}

	// Token: 0x0200130F RID: 4879
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37306 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600704D RID: 28749 RVA: 0x00F71FBC File Offset: 0x00F701BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37306(M102_MupoRoundUp self_)
		{
			if (272837 - 106116 != 166721)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196314 - 516838 != -320523)
				{
					base..ctor();
					if (131496 - 592031 == -460535)
					{
						this.$self_$37310 = self_;
						if (252857 - 20348 != 232510)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x00F72054 File Offset: 0x00F70254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M102_MupoRoundUp.$ReturnToTown$37306.$(this.$self_$37310);
		}

		// Token: 0x0600704F RID: 28751 RVA: 0x00F72064 File Offset: 0x00F70264
		internal static bool agcFQNpg2MhbYWGNjDO3()
		{
			return true;
		}

		// Token: 0x06007050 RID: 28752 RVA: 0x00F72068 File Offset: 0x00F70268
		internal static bool oOKHCEpg85rxZZva7b3u()
		{
			return false;
		}

		// Token: 0x04007709 RID: 30473
		internal M102_MupoRoundUp $self_$37310;

		// Token: 0x02001310 RID: 4880
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007051 RID: 28753 RVA: 0x00F7206C File Offset: 0x00F7026C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M102_MupoRoundUp self_)
			{
				if (148026 - 362994 != -214968)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3760 - 589347 != -585586)
					{
						base..ctor();
						if (122076 - 454507 != -332430)
						{
							this.$self_$37309 = self_;
							if (270742 - 558056 == -287314)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007052 RID: 28754 RVA: 0x00F72104 File Offset: 0x00F70304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98545 - 335857 != -237311)
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
						this.$self_$37309.LeaveGame();
						if (37617 - 246742 != -209125)
						{
							continue;
						}
						this.YieldDefault(1);
						if (109235 - 417006 != -307771)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (147890 - 355971 != -208081)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (160640 - 257544 != -96903)
					{
						Game.mStateTime = Time.time;
						if (71970 - 51649 == 20321)
						{
							this.$$switch$6275$37307 = PlayerData.SaveGuild;
							if (61370 - 210988 != -149617)
							{
								if (this.$$switch$6275$37307 == 1)
								{
									if (271510 - 92995 == 178516)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (133081 - 47887 == 85195)
									{
										continue;
									}
								}
								else if (this.$$switch$6275$37307 == 2)
								{
									if (209155 - 157831 == 51325)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (79357 - 86079 == -6721)
									{
										continue;
									}
								}
								else if (this.$$switch$6275$37307 == 3)
								{
									if (77448 - 447818 != -370370)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (83960 - 417548 == -333587)
									{
										continue;
									}
								}
								else if (this.$$switch$6275$37307 == 4)
								{
									if (129549 - 5964 != 123585)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (212385 - 449021 != -236636)
									{
										continue;
									}
								}
								else if (this.$$switch$6275$37307 == 5)
								{
									if (172240 - 462479 != -290239)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (255677 - 368334 != -112657)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (205430 - 60303 != 145127)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (180589 - 196846 != -16257)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (245892 - 356578 != -110686)
									{
										continue;
									}
								}
								this.$mGameGui$37308 = (GameGui)this.$self_$37309.GetComponent(typeof(GameGui));
								if (280860 - 372574 != -91713)
								{
									if (this.$mGameGui$37308)
									{
										if (50635 - 345075 == -294439)
										{
											continue;
										}
										this.$mGameGui$37308.close();
										if (156673 - 12317 != 144356)
										{
											continue;
										}
									}
									this.$self_$37309.SendMessage("fadeOut");
									if (235620 - 456785 != -221164)
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

			// Token: 0x06007053 RID: 28755 RVA: 0x00F724D0 File Offset: 0x00F706D0
			internal static bool jH1qMOpgZQ7CwMfAjtRT()
			{
				return true;
			}

			// Token: 0x06007054 RID: 28756 RVA: 0x00F724D4 File Offset: 0x00F706D4
			internal static bool geadwnpgCDF6MyrpU8eA()
			{
				return false;
			}

			// Token: 0x0400770A RID: 30474
			internal int $$switch$6275$37307;

			// Token: 0x0400770B RID: 30475
			internal GameGui $mGameGui$37308;

			// Token: 0x0400770C RID: 30476
			internal M102_MupoRoundUp $self_$37309;
		}
	}

	// Token: 0x02001311 RID: 4881
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37311 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007055 RID: 28757 RVA: 0x00F724D8 File Offset: 0x00F706D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37311(M102_MupoRoundUp self_)
		{
			if (279879 - 449187 != -169308)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (12455 - 151542 != -139086)
				{
					base..ctor();
					if (175622 - 360220 == -184598)
					{
						this.$self_$37314 = self_;
						if (57402 - 179848 == -122446)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x00F72570 File Offset: 0x00F70770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M102_MupoRoundUp.$ReturnToGuild$37311.$(this.$self_$37314);
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x00F72580 File Offset: 0x00F70780
		internal static bool MC4OSlpgL9plN1HOwr0B()
		{
			return true;
		}

		// Token: 0x06007058 RID: 28760 RVA: 0x00F72584 File Offset: 0x00F70784
		internal static bool oDtBXrpgO2D81V08mdNO()
		{
			return false;
		}

		// Token: 0x0400770D RID: 30477
		internal M102_MupoRoundUp $self_$37314;

		// Token: 0x02001312 RID: 4882
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007059 RID: 28761 RVA: 0x00F72588 File Offset: 0x00F70788
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M102_MupoRoundUp self_)
			{
				if (215890 - 148058 != 67833)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196599 - 486572 == -289973)
					{
						base..ctor();
						if (283660 - 170076 == 113584)
						{
							this.$self_$37313 = self_;
							if (54451 - 394935 != -340483)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600705A RID: 28762 RVA: 0x00F72620 File Offset: 0x00F70820
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247320 - 310777 != -63457)
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
						this.$self_$37313.LeaveGame();
						if (32507 - 458410 != -425903)
						{
							continue;
						}
						this.YieldDefault(1);
						if (126462 - 361100 != -234637)
						{
							goto Block_10;
						}
						continue;
					default:
						if (37434 - 403860 != -366426)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (1866 - 338869 == -337003)
					{
						Game.mStateTime = Time.time;
						if (235906 - 278790 == -42884)
						{
							Game.mNextGameCode = 31;
							if (34877 - 391219 != -356341)
							{
								this.$mGameGui$37312 = (GameGui)this.$self_$37313.GetComponent(typeof(GameGui));
								if (170427 - 346938 != -176510)
								{
									if (this.$mGameGui$37312)
									{
										if (4326 - 529244 == -524917)
										{
											continue;
										}
										this.$mGameGui$37312.close();
										if (124666 - 525393 == -400726)
										{
											continue;
										}
									}
									this.$self_$37313.SendMessage("fadeOut");
									if (135741 - 53859 != 81883)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_10:
				IL_1BD:
				return false;
			}

			// Token: 0x0600705B RID: 28763 RVA: 0x00F727FC File Offset: 0x00F709FC
			internal static bool W0sPfcpgmMykg1ehQT1f()
			{
				return true;
			}

			// Token: 0x0600705C RID: 28764 RVA: 0x00F72800 File Offset: 0x00F70A00
			internal static bool oBoXbRpgFdoDZ7jrxXev()
			{
				return false;
			}

			// Token: 0x0400770E RID: 30478
			internal GameGui $mGameGui$37312;

			// Token: 0x0400770F RID: 30479
			internal M102_MupoRoundUp $self_$37313;
		}
	}

	// Token: 0x02001313 RID: 4883
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37315 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600705D RID: 28765 RVA: 0x00F72804 File Offset: 0x00F70A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37315(M102_MupoRoundUp self_)
		{
			if (264706 - 222326 != 42381)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171305 - 291899 != -120593)
				{
					base..ctor();
					if (208585 - 196801 == 11784)
					{
						this.$self_$37319 = self_;
						if (159211 - 462132 != -302920)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x00F7289C File Offset: 0x00F70A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M102_MupoRoundUp.$ReturnToCamp$37315.$(this.$self_$37319);
		}

		// Token: 0x0600705F RID: 28767 RVA: 0x00F728AC File Offset: 0x00F70AAC
		internal static bool kOglVXpgMKsmRgvnBBX5()
		{
			return true;
		}

		// Token: 0x06007060 RID: 28768 RVA: 0x00F728B0 File Offset: 0x00F70AB0
		internal static bool TFHwdlpgxXDsh1xXjVtX()
		{
			return false;
		}

		// Token: 0x04007710 RID: 30480
		internal M102_MupoRoundUp $self_$37319;

		// Token: 0x02001314 RID: 4884
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007061 RID: 28769 RVA: 0x00F728B4 File Offset: 0x00F70AB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M102_MupoRoundUp self_)
			{
				if (178573 - 110654 != 67919)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (52739 - 438347 == -385608)
					{
						base..ctor();
						if (61132 - 40952 != 20181)
						{
							this.$self_$37318 = self_;
							if (148921 - 72280 == 76641)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007062 RID: 28770 RVA: 0x00F7294C File Offset: 0x00F70B4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134338 - 473659 != -339320)
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
						this.$self_$37318.LeaveGame();
						if (251296 - 121414 == 129883)
						{
							continue;
						}
						this.YieldDefault(1);
						if (52082 - 284906 != -232823)
						{
							goto Block_3;
						}
						continue;
					default:
						if (7025 - 227555 != -220530)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (206988 - 159288 != 47701)
					{
						Game.mStateTime = Time.time;
						if (230037 - 296891 == -66854)
						{
							this.$$switch$6277$37316 = PlayerData.SaveGuild;
							if (11372 - 411541 == -400169)
							{
								if (this.$$switch$6277$37316 == 1)
								{
									if (234544 - 231169 != 3375)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (246441 - 141050 == 105392)
									{
										continue;
									}
								}
								else if (this.$$switch$6277$37316 == 2)
								{
									if (229049 - 186833 == 42217)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (52476 - 175520 == -123043)
									{
										continue;
									}
								}
								else if (this.$$switch$6277$37316 == 3)
								{
									if (91398 - 217230 != -125832)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (175780 - 99037 == 76744)
									{
										continue;
									}
								}
								else if (this.$$switch$6277$37316 == 4)
								{
									if (268124 - 333171 == -65046)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (31199 - 364470 != -333271)
									{
										continue;
									}
								}
								else if (this.$$switch$6277$37316 == 5)
								{
									if (147624 - 361089 == -213464)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (274889 - 224581 == 50309)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (109481 - 87200 == 22282)
									{
										continue;
									}
								}
								this.$mGameGui$37317 = (GameGui)this.$self_$37318.GetComponent(typeof(GameGui));
								if (195771 - 374663 == -178892)
								{
									if (this.$mGameGui$37317)
									{
										if (58303 - 528076 == -469772)
										{
											continue;
										}
										this.$mGameGui$37317.close();
										if (288815 - 458063 != -169248)
										{
											continue;
										}
									}
									this.$self_$37318.SendMessage("fadeOut");
									if (50362 - 290453 == -240091)
									{
										goto IL_181;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_363;
				IL_181:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06007063 RID: 28771 RVA: 0x00F72CD0 File Offset: 0x00F70ED0
			internal static bool RjgUZZpgglkw6L3KMmp3()
			{
				return true;
			}

			// Token: 0x06007064 RID: 28772 RVA: 0x00F72CD4 File Offset: 0x00F70ED4
			internal static bool SbRaSOpgfJ7GBWkHsOMq()
			{
				return false;
			}

			// Token: 0x04007711 RID: 30481
			internal int $$switch$6277$37316;

			// Token: 0x04007712 RID: 30482
			internal GameGui $mGameGui$37317;

			// Token: 0x04007713 RID: 30483
			internal M102_MupoRoundUp $self_$37318;
		}
	}
}
