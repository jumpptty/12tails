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

// Token: 0x020013BC RID: 5052
[Serializable]
public class M205_CrossingPlainLagoon1 : MonoBehaviour
{
	// Token: 0x06007495 RID: 29845 RVA: 0x00FC16B4 File Offset: 0x00FBF8B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M205_CrossingPlainLagoon1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007496 RID: 29846 RVA: 0x00FC16C4 File Offset: 0x00FBF8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (256370 - 289870 != -33500)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (151202 - 291919 != -140716)
			{
				Game.mGameType = 5;
				if (19979 - 385849 != -365869)
				{
					if (Chat.Initialized)
					{
						if (285710 - 318716 != -33006)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (155170 - 7347 == 147824)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (166869 - 164729 == 2141)
						{
							continue;
						}
					}
					this.AhkcjJwq6rW = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (173512 - 120173 != 53340)
					{
						this.P2ccj6TvM0U = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (270822 - 564717 != -293894)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007497 RID: 29847 RVA: 0x00FC181C File Offset: 0x00FBFA1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (61983 - 507654 != -445670)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (276921 - 587766 == -310845)
				{
					if (Game.mNextGameCode != 205)
					{
						break;
					}
					if (6560 - 369015 == -362455)
					{
						Game.nextGame();
						if (255527 - 56086 != 199442)
						{
							Game.mGameCode = 205;
							if (37574 - 366911 != -329336)
							{
								Game.mGameType = 5;
								if (240943 - 256088 == -15145)
								{
									Game.mGameTime = Time.time;
									if (292997 - 528701 == -235704)
									{
										Game.mGameScore = 0;
										if (299482 - 123540 == 175942)
										{
											Game.mGameMana = 0;
											if (120812 - 559035 != -438222)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (261599 - 15438 != 246162)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (65131 - 118367 == -53236)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (250859 - 153452 == 97407)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (11705 - 203062 != -191356)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (9726 - 545029 == -535303)
																{
																	this.LkJcjekVJaF = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (69037 - 199211 == -130174)
																	{
																		this.dhtcjQEj9iQ = PhotonClient.Connection;
																		if (123591 - 73641 == 49950)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (283019 - 109932 == 173087)
																			{
																				this.InitGame();
																				if (90156 - 396228 != -306071)
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
				if (111141 - 238015 == -126874)
				{
					Game.mGameType = 99;
					if (273424 - 33067 == 240357)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007498 RID: 29848 RVA: 0x00FC1B24 File Offset: 0x00FBFD24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (98754 - 176622 != -77867)
		{
		}
		for (;;)
		{
			if (this.dhtcjQEj9iQ == null)
			{
				if (297906 - 305195 != -7288)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (195311 - 555693 != -360381)
				{
					if (mGameState == eGameState.Init)
					{
						if (268214 - 41239 == 226975)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (61578 - 495325 != -433746)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (4190 - 202166 != -197975)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (80976 - 519826 != -438849)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (3958 - 326572 == -322614)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (27575 - 43881 != -16305)
						{
							if (Time.time > this.OIucjIJpWs6)
							{
								if (237513 - 531712 == -294198)
								{
									continue;
								}
								Game.mGameMana++;
								if (169164 - 126936 == 42229)
								{
									continue;
								}
								this.OIucjIJpWs6 = Time.time + (float)12;
								if (174781 - 503871 == -329089)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (143906 - 455049 != -311143)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (127571 - 263712 != -136141)
									{
										continue;
									}
									this.audio.Play();
									if (158820 - 23041 != 135779)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (177482 - 91661 != 85822)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (297112 - 578126 == -281014)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (57696 - 313775 != -256078)
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
						if (170818 - 298324 != -127505)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007499 RID: 29849 RVA: 0x00FC1E24 File Offset: 0x00FC0024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (294913 - 287361 != 7553)
		{
		}
		for (;;)
		{
			if (!this.AhkcjJwq6rW)
			{
				if (163006 - 124070 != 38937)
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
				if (94641 - 41265 == 53376)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (198068 - 557636 != -359567)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (270418 - 251677 != 18742)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (198377 - 151738 == 46639)
							{
								GUI.depth = 1;
								if (294602 - 43707 != 250896)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (227540 - 70533 == 157007)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (269851 - 271571 != -1719)
										{
											Color color = GUI.color;
											if (110677 - 355505 == -244828)
											{
												float num3 = color.a = a;
												if (258680 - 29193 != 229488)
												{
													if (102026 - 240300 == -138274)
													{
														GUI.color = color;
														if (95741 - 314143 == -218402)
														{
															if (208978 - 275442 == -66464)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.AhkcjJwq6rW);
																if (165806 - 378734 == -212928)
																{
																	float a2 = 1f;
																	if (2240 - 236558 == -234318)
																	{
																		Color color2 = GUI.color;
																		if (273094 - 382680 != -109585)
																		{
																			float num4 = color2.a = a2;
																			if (3231 - 433484 == -430253)
																			{
																				if (141486 - 276561 != -135074)
																				{
																					Color color3 = GUI.color = color2;
																					if (225157 - 209162 != 15996)
																					{
																						if (288258 - 89975 == 198283)
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

	// Token: 0x0600749A RID: 29850 RVA: 0x00FC21A4 File Offset: 0x00FC03A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (105577 - 522142 != -416564)
		{
		}
		while (this.wLJcjt3FkZp < 1)
		{
			if (3837 - 540121 == -536284)
			{
				this.wLJcjt3FkZp = 1;
				if (135412 - 156495 != -21082)
				{
					Game.sendMissionEvent(2051, 1);
					if (104773 - 150888 != -46114)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600749B RID: 29851 RVA: 0x00FC2248 File Offset: 0x00FC0448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M205_CrossingPlainLagoon1.$onGameEvent$37796(data, this).GetEnumerator();
	}

	// Token: 0x0600749C RID: 29852 RVA: 0x00FC2258 File Offset: 0x00FC0458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M205_CrossingPlainLagoon1.$onGameComplete$37808(data, this).GetEnumerator();
	}

	// Token: 0x0600749D RID: 29853 RVA: 0x00FC2268 File Offset: 0x00FC0468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (186569 - 49779 != 136790)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (176474 - 404729 == -228255)
			{
				Hashtable customOpParameters = new Hashtable();
				if (110717 - 267502 != -156784)
				{
					this.dhtcjQEj9iQ.OpCustom(52, customOpParameters, true);
					if (169735 - 65248 == 104487)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600749E RID: 29854 RVA: 0x00FC2310 File Offset: 0x00FC0510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (258429 - 256325 != 2104)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (1742 - 549119 != -547376)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (7241 - 530844 != -523602)
				{
					Game.mGameState = eGameState.Setup;
					if (292677 - 338276 != -45598)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600749F RID: 29855 RVA: 0x00FC23B4 File Offset: 0x00FC05B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (70648 - 543223 != -472574)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (284557 - 312574 != -28016)
			{
				if (num == PlayerData.UID)
				{
					if (203889 - 477263 != -273373)
					{
						this.SetupActors();
						if (283894 - 443463 == -159569)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (29685 - 538995 != -509309)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060074A0 RID: 29856 RVA: 0x00FC2484 File Offset: 0x00FC0684
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (178586 - 586058 != -407472)
		{
		}
		for (;;)
		{
			IL_1F1:
			Debug.Log("Creating Actors");
			if (265460 - 218049 != 47412)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (103809 - 336410 == -232601)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (16733 - 594259 == -577526)
						{
							int i = 0;
							if (206635 - 310588 != -103952)
							{
								CharacterControl[] array2 = array;
								if (26139 - 12563 != 13577)
								{
									int length = array2.Length;
									if (16969 - 252139 == -235170)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (186998 - 165358 != 21640)
											{
												goto IL_1F1;
											}
											if (type == "FatBug_g")
											{
												goto IL_6A;
											}
											if (79705 - 172173 != -92468)
											{
												goto IL_1F1;
											}
											if (type == "LittleFatBug_g")
											{
												goto IL_6A;
											}
											if (112363 - 137857 == -25493)
											{
												goto IL_1F1;
											}
											if (type == "FlowerBug_p")
											{
												if (234098 - 322565 != -88467)
												{
													goto IL_1F1;
												}
												goto IL_6A;
											}
											IL_42:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (188621 - 222022 == -33400)
											{
												goto IL_1F1;
											}
											this.McNcj2S462h++;
											if (132023 - 283711 == -151687)
											{
												goto IL_1F1;
											}
											i++;
											if (36782 - 93226 != -56444)
											{
												goto IL_1F1;
											}
											continue;
											IL_6A:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (25037 - 486524 != -461486)
											{
												goto IL_42;
											}
											goto IL_1F1;
										}
										if (228835 - 462467 != -233631)
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
						if (281855 - 67841 == 214014)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060074A1 RID: 29857 RVA: 0x00FC274C File Offset: 0x00FC094C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (120953 - 235581 != -114628)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (106326 - 319003 == -212677)
			{
				int i = 0;
				if (92923 - 484129 == -391206)
				{
					CharacterControl[] array2 = array;
					if (155654 - 338781 == -183127)
					{
						int length = array2.Length;
						if (30412 - 13994 != 16419)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (285255 - 274805 != 10450)
								{
									goto IL_3C;
								}
								i++;
								if (221839 - 51988 != 169851)
								{
									goto IL_3C;
								}
							}
							if (174798 - 159592 != 15207)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060074A2 RID: 29858 RVA: 0x00FC287C File Offset: 0x00FC0A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (276211 - 551779 != -275567)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (223878 - 485315 == -261437)
			{
				Game.mGameState = eGameState.Ready;
				if (206324 - 203849 != 2476)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (69440 - 28036 != 41405)
					{
						if (73373 - 33967 == 39406)
						{
							GameObject gameObject = null;
							if (64205 - 556278 == -492073)
							{
								if (playerSlot <= 1)
								{
									goto IL_E1;
								}
								if (135237 - 26433 == 108805)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_E1;
								}
								if (210559 - 584064 == -373504)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (97355 - 331509 != -234154)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (160274 - 165458 != -5184)
								{
									continue;
								}
								IL_208:
								if (gameObject2)
								{
									if (74383 - 530584 == -456200)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (191706 - 204707 == -13000)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (104569 - 179307 != -74738)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (178529 - 69937 != 108592)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (285447 - 397456 != -112008)
								{
									break;
								}
								continue;
								IL_E1:
								gameObject2 = GameObject.Find("StartPoint1");
								if (125056 - 468254 != -343197)
								{
									goto IL_208;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060074A3 RID: 29859 RVA: 0x00FC2B0C File Offset: 0x00FC0D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M205_CrossingPlainLagoon1.$StartGame$37817(this).GetEnumerator();
	}

	// Token: 0x060074A4 RID: 29860 RVA: 0x00FC2B1C File Offset: 0x00FC0D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060074A5 RID: 29861 RVA: 0x00FC2B20 File Offset: 0x00FC0D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (200011 - 47946 != 152065)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (1541 - 454696 != -453154)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (208120 - 125282 != 82839)
				{
					hashtable.Add(43, PlayerData.UID);
					if (72812 - 175132 == -102320)
					{
						hashtable.Add(73, nType);
						if (118785 - 174924 == -56139)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (25467 - 359652 == -334185)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (277877 - 81579 == 196298)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (216487 - 403717 != -187229)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (137357 - 108536 == 28821)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (191090 - 241484 == -50394)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (6635 - 88451 != -81815)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (148992 - 113063 != 35930)
													{
														this.dhtcjQEj9iQ.OpCustom(63, hashtable, true);
														if (120748 - 16388 == 104360)
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

	// Token: 0x060074A6 RID: 29862 RVA: 0x00FC2E04 File Offset: 0x00FC1004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (91400 - 150749 != -59348)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (43327 - 368644 != -325316)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (214091 - 212438 != 1654)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (244450 - 561457 == -317007)
						{
							if (this.McNcj2S462h <= 0)
							{
								break;
							}
							if (148274 - 239565 == -91291)
							{
								this.McNcj2S462h--;
								if (257015 - 367240 == -110225)
								{
									if (this.McNcj2S462h != 0)
									{
										break;
									}
									if (5426 - 190255 != -184828)
									{
										Game.setGameState(eGameState.Ready);
										if (169975 - 373495 != -203519)
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
						if (203051 - 226736 == -23685)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (92905 - 470439 != -377533)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060074A7 RID: 29863 RVA: 0x00FC2F94 File Offset: 0x00FC1194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060074A8 RID: 29864 RVA: 0x00FC2FA8 File Offset: 0x00FC11A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (198247 - 522194 != -323947)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (122541 - 374946 != -252404)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (162021 - 259368 != -97346)
				{
					if (!characterControl)
					{
						break;
					}
					if (142866 - 531334 != -388467)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (12677 - 149348 == -136671)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (31605 - 366843 != -335237)
							{
								string type = characterControl.Type;
								if (238969 - 46662 != 192308)
								{
									if (type == "FlowerBug_p")
									{
										if (6476 - 341568 == -335092)
										{
											Game.sendMissionEvent(2052, 0);
											if (257855 - 561299 == -303444)
											{
												break;
											}
										}
									}
									else
									{
										if (type == "LittleFatBug_g")
										{
											if (166007 - 62877 != 103130)
											{
												continue;
											}
										}
										else
										{
											if (!(type == "FatBug_g"))
											{
												break;
											}
											if (245629 - 60947 == 184683)
											{
												continue;
											}
										}
										Game.sendMissionEvent(2053, 0);
										if (237486 - 473270 == -235784)
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

	// Token: 0x060074A9 RID: 29865 RVA: 0x00FC31A4 File Offset: 0x00FC13A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (228276 - 26651 != 201626)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (115678 - 596058 != -480379)
			{
				hashtable.Add(71, CID);
				if (20399 - 454029 != -433629)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (88511 - 56649 == 31862)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (209364 - 460646 != -251281)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (172484 - 231915 == -59431)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (256306 - 123246 == 133060)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (60270 - 188050 == -127780)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (128563 - 111271 == 17292)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (74920 - 589028 == -514108)
											{
												this.dhtcjQEj9iQ.OpCustom(61, hashtable, true);
												if (150902 - 475867 != -324964)
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

	// Token: 0x060074AA RID: 29866 RVA: 0x00FC3430 File Offset: 0x00FC1630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (207507 - 64339 != 143168)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (258643 - 588298 == -329655)
			{
				if (!gameObject)
				{
					break;
				}
				if (203038 - 518180 != -315141)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (27742 - 396462 != -368719)
					{
						playerCameraControl.target = gameObject;
						if (131062 - 68009 == 63053)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (176483 - 152615 == 23868)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060074AB RID: 29867 RVA: 0x00FC3528 File Offset: 0x00FC1728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (132754 - 14993 != 117761)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (23226 - 85668 != -62441)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (248128 - 183214 != 64915)
				{
					gameGui.ResetTeamBar();
					if (61774 - 8316 != 53459)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060074AC RID: 29868 RVA: 0x00FC35D4 File Offset: 0x00FC17D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M205_CrossingPlainLagoon1.$onDeadPlayer$37821(this).GetEnumerator();
	}

	// Token: 0x060074AD RID: 29869 RVA: 0x00FC35E4 File Offset: 0x00FC17E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (50970 - 10294 != 40677)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (161700 - 197673 != -35972)
			{
				this.LkJcjekVJaF.target = Game.mPlayer;
				if (253679 - 414494 != -160814)
				{
					this.LkJcjekVJaF.enabled = true;
					if (237098 - 513164 != -276065)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (251344 - 325496 != -74152)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (196398 - 396366 != -199968)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (232025 - 516688 != -284662)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (96471 - 230246 == -133775)
							{
								if (!gameGui)
								{
									break;
								}
								if (70140 - 594020 != -523879)
								{
									gameGui.enabled = true;
									if (92056 - 391627 != -299570)
									{
										gameGui.closeDeadMenu();
										if (32269 - 137542 == -105273)
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

	// Token: 0x060074AE RID: 29870 RVA: 0x00FC3790 File Offset: 0x00FC1990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (238726 - 70119 != 168608)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (186381 - 525804 != -339422)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (597 - 456465 == -455868)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (208718 - 379658 == -170940)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060074AF RID: 29871 RVA: 0x00FC3854 File Offset: 0x00FC1A54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060074B0 RID: 29872 RVA: 0x00FC3880 File Offset: 0x00FC1A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M205_CrossingPlainLagoon1.$ReturnToTown$37827(this).GetEnumerator();
	}

	// Token: 0x060074B1 RID: 29873 RVA: 0x00FC3890 File Offset: 0x00FC1A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M205_CrossingPlainLagoon1.$ReturnToGuild$37832(this).GetEnumerator();
	}

	// Token: 0x060074B2 RID: 29874 RVA: 0x00FC38A0 File Offset: 0x00FC1AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M205_CrossingPlainLagoon1.$ReturnToCamp$37836(this).GetEnumerator();
	}

	// Token: 0x060074B3 RID: 29875 RVA: 0x00FC38B0 File Offset: 0x00FC1AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (75786 - 556328 != -480541)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (51434 - 122467 != -71032)
			{
				Hashtable hashtable = new Hashtable();
				if (122743 - 230160 != -107416)
				{
					hashtable.Add(43, PlayerData.UID);
					if (272230 - 257601 != 14630)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (162036 - 35221 == 126815)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060074B4 RID: 29876 RVA: 0x00FC3988 File Offset: 0x00FC1B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060074B5 RID: 29877 RVA: 0x00FC399C File Offset: 0x00FC1B9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (237198 - 95585 != 141613)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (106285 - 503958 != -397672)
			{
				Hashtable hashtable = new Hashtable();
				if (229439 - 26505 == 202934)
				{
					if (Game.mNextGameCode == 30)
					{
						if (38130 - 407792 != -369662)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (293150 - 350507 != -57357)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (246030 - 54613 != 191417)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (147356 - 144515 != 2841)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (26594 - 374804 == -348209)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (65544 - 405873 != -340329)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (46050 - 233236 == -187185)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (162405 - 567854 != -405449)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (185033 - 390095 != -205062)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (92536 - 589328 == -496791)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (154950 - 290979 != -136029)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (160727 - 451129 == -290401)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (84038 - 572485 != -488447)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (220261 - 172458 != 47803)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (147431 - 225744 != -78313)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (27343 - 45968 != -18625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (155746 - 131272 != 24474)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (286606 - 174200 != 112406)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (44899 - 156018 == -111118)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (217394 - 70254 != 147140)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (241856 - 233180 != 8676)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (220004 - 240445 != -20441)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (131877 - 111192 != 20685)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (222160 - 313421 != -91261)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (115972 - 157414 == -41441)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (123550 - 434934 == -311383)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (221217 - 437940 != -216723)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (287283 - 235945 != 51338)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (4484 - 464958 != -460473)
					{
						this.dhtcjQEj9iQ.OpCustom(42, hashtable, true);
						if (231127 - 215382 == 15745)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060074B6 RID: 29878 RVA: 0x00FC3F50 File Offset: 0x00FC2150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060074B7 RID: 29879 RVA: 0x00FC3F60 File Offset: 0x00FC2160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060074B8 RID: 29880 RVA: 0x00FC3F64 File Offset: 0x00FC2164
	internal static bool HmtH8bpK18s8g1Q8cXbj()
	{
		return true;
	}

	// Token: 0x060074B9 RID: 29881 RVA: 0x00FC3F68 File Offset: 0x00FC2168
	internal static bool ao9d87pK4Uq85bXHfl1A()
	{
		return false;
	}

	// Token: 0x040079AC RID: 31148
	private LitePeer dhtcjQEj9iQ;

	// Token: 0x040079AD RID: 31149
	private PlayerCameraControl LkJcjekVJaF;

	// Token: 0x040079AE RID: 31150
	private float OIucjIJpWs6;

	// Token: 0x040079AF RID: 31151
	private Texture AhkcjJwq6rW;

	// Token: 0x040079B0 RID: 31152
	private AudioClip P2ccj6TvM0U;

	// Token: 0x040079B1 RID: 31153
	private int wLJcjt3FkZp;

	// Token: 0x040079B2 RID: 31154
	private int zXYcjXXi3gM;

	// Token: 0x040079B3 RID: 31155
	private int Y0acjO8od0x;

	// Token: 0x040079B4 RID: 31156
	private int McNcj2S462h;

	// Token: 0x020013BD RID: 5053
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$37796 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060074BA RID: 29882 RVA: 0x00FC3F6C File Offset: 0x00FC216C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$37796(Hashtable data, M205_CrossingPlainLagoon1 self_)
		{
			if (45639 - 274127 != -228487)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275771 - 218277 == 57494)
				{
					base..ctor();
					if (10567 - 284169 == -273602)
					{
						this.$data$37806 = data;
						if (238111 - 529017 != -290905)
						{
							this.$self_$37807 = self_;
							if (23938 - 220763 != -196824)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x00FC4028 File Offset: 0x00FC2228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon1.$onGameEvent$37796.$(this.$data$37806, this.$self_$37807);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x00FC403C File Offset: 0x00FC223C
		internal static bool mcNrCopKzHNWH1vrlrMN()
		{
			return true;
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x00FC4040 File Offset: 0x00FC2240
		internal static bool v2Ilj3pdaeDH9BgL6YKa()
		{
			return false;
		}

		// Token: 0x040079B5 RID: 31157
		internal Hashtable $data$37806;

		// Token: 0x040079B6 RID: 31158
		internal M205_CrossingPlainLagoon1 $self_$37807;

		// Token: 0x020013BE RID: 5054
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060074BE RID: 29886 RVA: 0x00FC4044 File Offset: 0x00FC2244
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M205_CrossingPlainLagoon1 self_)
			{
				if (44803 - 506375 != -461571)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187216 - 232104 == -44888)
					{
						base..ctor();
						if (45512 - 397445 == -351933)
						{
							this.$data$37804 = data;
							if (216580 - 107307 == 109273)
							{
								this.$self_$37805 = self_;
								if (72659 - 1831 != 70829)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060074BF RID: 29887 RVA: 0x00FC4100 File Offset: 0x00FC2300
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (1060 - 510685 != -509624)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_795;
					case 2:
						Game.mGameStage = 2;
						if (181589 - 177861 != 3728)
						{
							continue;
						}
						Application.LoadLevel("M205_CrossingPlainLagoon2");
						if (81671 - 282478 != -200807)
						{
							continue;
						}
						goto IL_14A;
					case 3:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (121107 - 408997 != -287889)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mSpawnPoint$37800 = GameObject.Find("SpawnPoint" + (UnityEngine.Random.Range(0, 5) + 1));
							if (255883 - 291301 != -35418)
							{
								continue;
							}
							if (!this.$mSpawnPoint$37800)
							{
								goto IL_11B;
							}
							if (127078 - 232898 != -105820)
							{
								continue;
							}
							this.$mSpawnPos$37803 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$37800.transform.position, 4);
							if (139524 - 374331 == -234806)
							{
								continue;
							}
							if (this.$mSpawnPos$37803 == Vector3.zero)
							{
								if (124243 - 228493 == -104249)
								{
									continue;
								}
								this.$mSpawnPos$37803 = this.$mSpawnPoint$37800.transform.position;
								if (11822 - 177077 == -165254)
								{
									continue;
								}
							}
							this.$self_$37805.createActor("FlowerBug_p", 6, this.$mSpawnPos$37803, this.$mSpawnPoint$37800.transform.forward);
							if (235673 - 279431 != -43758)
							{
								continue;
							}
							goto IL_11B;
						}
						break;
					default:
						if (260116 - 527861 == -267744)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (185195 - 585446 != -400250)
						{
							goto Block_6;
						}
						continue;
					}
					else
					{
						this.$returnCode$37797 = RuntimeServices.UnboxInt32(this.$data$37804[141]);
						if (82152 - 369695 != -287543)
						{
							continue;
						}
						this.$returnValue$37798 = RuntimeServices.UnboxInt32(this.$data$37804[145]);
						if (17384 - 365784 == -348399)
						{
							continue;
						}
						this.$ownerID$37799 = RuntimeServices.UnboxInt32(this.$data$37804[43]);
						if (276054 - 170831 != 105223)
						{
							continue;
						}
						this.$mSpawnPoint$37800 = null;
						if (217416 - 511665 == -294248)
						{
							continue;
						}
						this.$$switch$6468$37801 = this.$returnCode$37797;
						if (127301 - 557920 != -430619)
						{
							continue;
						}
						if (this.$$switch$6468$37801 == 2051)
						{
							if (296061 - 364748 == -68686)
							{
								continue;
							}
							if (this.$self_$37805.wLJcjt3FkZp < 2)
							{
								if (236353 - 97514 == 138840)
								{
									continue;
								}
								this.$self_$37805.wLJcjt3FkZp = 2;
								if (34608 - 202669 != -168061)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (271579 - 434571 != -162992)
								{
									continue;
								}
								this.$mGameGui$37802 = (GameGui)this.$self_$37805.GetComponent(typeof(GameGui));
								if (196437 - 437579 == -241141)
								{
									continue;
								}
								this.$mGameGui$37802.close();
								if (15794 - 393823 == -378028)
								{
									continue;
								}
								Game.savePlayer();
								if (91563 - 339411 != -247848)
								{
									continue;
								}
								this.$self_$37805.SendMessage("fadeOut");
								if (274545 - 430462 != -155916)
								{
									goto Block_26;
								}
								continue;
							}
						}
						else if (this.$$switch$6468$37801 == 2052)
						{
							if (26549 - 507163 == -480613)
							{
								continue;
							}
							this.$self_$37805.zXYcjXXi3gM = this.$self_$37805.zXYcjXXi3gM + 1;
							if (205558 - 318596 != -113038)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$37799)
							{
								if (118337 - 331034 == -212696)
								{
									continue;
								}
								if (this.$self_$37805.zXYcjXXi3gM >= 8)
								{
									if (240716 - 269896 == -29179)
									{
										continue;
									}
									if (this.$self_$37805.zXYcjXXi3gM < 30)
									{
										if (178317 - 65752 != 112566)
										{
											break;
										}
										continue;
									}
								}
							}
						}
						else if (this.$$switch$6468$37801 == 2053)
						{
							if (169219 - 313815 == -144595)
							{
								continue;
							}
							this.$self_$37805.Y0acjO8od0x = this.$self_$37805.Y0acjO8od0x + 1;
							if (284373 - 204390 == 79984)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$37799)
							{
								if (197941 - 21002 != 176939)
								{
									continue;
								}
								if (this.$self_$37805.Y0acjO8od0x >= 3)
								{
									if (38473 - 486449 != -447976)
									{
										continue;
									}
									if (this.$self_$37805.Y0acjO8od0x < 8)
									{
										if (43644 - 379470 == -335825)
										{
											continue;
										}
										this.$mSpawnPoint$37800 = GameObject.Find("SpawnPoint" + (UnityEngine.Random.Range(6, 10) + 1));
										if (203429 - 282984 == -79554)
										{
											continue;
										}
										if (this.$mSpawnPoint$37800)
										{
											if (231151 - 505949 != -274798)
											{
												continue;
											}
											if (UnityEngine.Random.Range(0, 100) < 70)
											{
												if (296862 - 465002 == -168139)
												{
													continue;
												}
												this.$self_$37805.createActor("LittleFatBug_g", 6, this.$mSpawnPoint$37800.transform.position, this.$mSpawnPoint$37800.transform.forward);
												if (284873 - 364029 != -79156)
												{
													continue;
												}
											}
											else
											{
												this.$self_$37805.createActor("FatBug_g", 6, this.$mSpawnPoint$37800.transform.position, this.$mSpawnPoint$37800.transform.forward);
												if (141497 - 115386 == 26112)
												{
													continue;
												}
											}
										}
									}
								}
							}
						}
					}
					IL_290:
					this.YieldDefault(1);
					if (44365 - 395256 != -350890)
					{
						goto Block_25;
					}
					continue;
					IL_14A:
					IL_11B:
					goto IL_290;
				}
				return this.Yield(3, new WaitForSeconds((float)6));
				Block_6:
				Block_25:
				goto IL_795;
				Block_26:
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_28:
				IL_795:
				return false;
			}

			// Token: 0x060074C0 RID: 29888 RVA: 0x00FC48B4 File Offset: 0x00FC2AB4
			internal static bool MW1CmFpd58f9BAotQS0C()
			{
				return true;
			}

			// Token: 0x060074C1 RID: 29889 RVA: 0x00FC48B8 File Offset: 0x00FC2AB8
			internal static bool U7GibgpdpRma84FufrEl()
			{
				return false;
			}

			// Token: 0x040079B7 RID: 31159
			internal int $returnCode$37797;

			// Token: 0x040079B8 RID: 31160
			internal int $returnValue$37798;

			// Token: 0x040079B9 RID: 31161
			internal int $ownerID$37799;

			// Token: 0x040079BA RID: 31162
			internal GameObject $mSpawnPoint$37800;

			// Token: 0x040079BB RID: 31163
			internal int $$switch$6468$37801;

			// Token: 0x040079BC RID: 31164
			internal GameGui $mGameGui$37802;

			// Token: 0x040079BD RID: 31165
			internal Vector3 $mSpawnPos$37803;

			// Token: 0x040079BE RID: 31166
			internal Hashtable $data$37804;

			// Token: 0x040079BF RID: 31167
			internal M205_CrossingPlainLagoon1 $self_$37805;
		}
	}

	// Token: 0x020013BF RID: 5055
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37808 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060074C2 RID: 29890 RVA: 0x00FC48BC File Offset: 0x00FC2ABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37808(Hashtable data, M205_CrossingPlainLagoon1 self_)
		{
			if (181635 - 333721 != -152085)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201011 - 465426 == -264415)
				{
					base..ctor();
					if (239563 - 211314 != 28250)
					{
						this.$data$37815 = data;
						if (40630 - 313628 != -272997)
						{
							this.$self_$37816 = self_;
							if (146593 - 3319 == 143274)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x00FC4978 File Offset: 0x00FC2B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon1.$onGameComplete$37808.$(this.$data$37815, this.$self_$37816);
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x00FC498C File Offset: 0x00FC2B8C
		internal static bool n3XNQypdVj2jeAYRhIsk()
		{
			return true;
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x00FC4990 File Offset: 0x00FC2B90
		internal static bool gIwVPspdtDAwCQQkybxe()
		{
			return false;
		}

		// Token: 0x040079C0 RID: 31168
		internal Hashtable $data$37815;

		// Token: 0x040079C1 RID: 31169
		internal M205_CrossingPlainLagoon1 $self_$37816;

		// Token: 0x020013C0 RID: 5056
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060074C6 RID: 29894 RVA: 0x00FC4994 File Offset: 0x00FC2B94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M205_CrossingPlainLagoon1 self_)
			{
				if (161439 - 581312 != -419873)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (62684 - 400837 != -338152)
					{
						base..ctor();
						if (167677 - 204123 != -36445)
						{
							this.$data$37813 = data;
							if (34903 - 145541 == -110638)
							{
								this.$self_$37814 = self_;
								if (212220 - 561727 == -349507)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060074C7 RID: 29895 RVA: 0x00FC4A50 File Offset: 0x00FC2C50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200885 - 204570 != -3685)
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
						this.$mCompleteGui$37810 = (CompleteGui)this.$self_$37814.GetComponent(typeof(CompleteGui));
						if (51043 - 596879 == -545835)
						{
							continue;
						}
						this.$mCompleteGui$37810.Init();
						if (85848 - 54412 == 31437)
						{
							continue;
						}
						this.$mCompleteGui$37810.readData(this.$data$37813);
						if (42582 - 232121 != -189539)
						{
							continue;
						}
						if (this.$result$37809 == 1)
						{
							if (231483 - 196629 != 34854)
							{
								continue;
							}
							this.$mCompleteGui$37810.displayResult(eCompleteType.Success);
							if (298076 - 282406 == 15671)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37810.displayResult(eCompleteType.Failed);
							if (252273 - 581030 == -328756)
							{
								continue;
							}
						}
						this.$mGameGui$37811 = (GameGui)this.$self_$37814.GetComponent(typeof(GameGui));
						if (163072 - 271866 == -108793)
						{
							continue;
						}
						this.$mStoryGui$37812 = (StoryGui)this.$self_$37814.GetComponent(typeof(StoryGui));
						if (230426 - 270984 != -40558)
						{
							continue;
						}
						if (this.$mGameGui$37811)
						{
							if (77050 - 323228 != -246178)
							{
								continue;
							}
							this.$mGameGui$37811.close();
							if (156122 - 139406 == 16717)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37812)
						{
							if (207133 - 585840 != -378707)
							{
								continue;
							}
							this.$mStoryGui$37812.close();
							if (10710 - 449433 == -438722)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (185945 - 320044 != -134099)
						{
							continue;
						}
						goto IL_352;
					default:
						if (35747 - 498609 != -462862)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37813[31]);
					if (134673 - 237892 == -103219)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (77376 - 261698 != -184321)
							{
								goto Block_9;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (114889 - 56624 != 58266)
							{
								this.$result$37809 = RuntimeServices.UnboxInt32(this.$data$37813[31]);
								if (7591 - 122695 != -115103)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_9:
				IL_352:
				return false;
			}

			// Token: 0x060074C8 RID: 29896 RVA: 0x00FC4DC4 File Offset: 0x00FC2FC4
			internal static bool AJCAiTpdNkrvlsS05nSX()
			{
				return true;
			}

			// Token: 0x060074C9 RID: 29897 RVA: 0x00FC4DC8 File Offset: 0x00FC2FC8
			internal static bool SeoVPjpdYLhjxZ2tBHDq()
			{
				return false;
			}

			// Token: 0x040079C2 RID: 31170
			internal int $result$37809;

			// Token: 0x040079C3 RID: 31171
			internal CompleteGui $mCompleteGui$37810;

			// Token: 0x040079C4 RID: 31172
			internal GameGui $mGameGui$37811;

			// Token: 0x040079C5 RID: 31173
			internal StoryGui $mStoryGui$37812;

			// Token: 0x040079C6 RID: 31174
			internal Hashtable $data$37813;

			// Token: 0x040079C7 RID: 31175
			internal M205_CrossingPlainLagoon1 $self_$37814;
		}
	}

	// Token: 0x020013C1 RID: 5057
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37817 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060074CA RID: 29898 RVA: 0x00FC4DCC File Offset: 0x00FC2FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37817(M205_CrossingPlainLagoon1 self_)
		{
			if (163798 - 472392 != -308593)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (93670 - 572579 != -478908)
				{
					base..ctor();
					if (30493 - 77837 != -47343)
					{
						this.$self_$37820 = self_;
						if (56202 - 73883 == -17681)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x00FC4E64 File Offset: 0x00FC3064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon1.$StartGame$37817.$(this.$self_$37820);
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x00FC4E74 File Offset: 0x00FC3074
		internal static bool j2kBOtpdcVLDDOeeTHVY()
		{
			return true;
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x00FC4E78 File Offset: 0x00FC3078
		internal static bool Ah5pc5pdU57JOvl4sevP()
		{
			return false;
		}

		// Token: 0x040079C8 RID: 31176
		internal M205_CrossingPlainLagoon1 $self_$37820;

		// Token: 0x020013C2 RID: 5058
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060074CE RID: 29902 RVA: 0x00FC4E7C File Offset: 0x00FC307C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon1 self_)
			{
				if (256505 - 160209 != 96297)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232627 - 34469 == 198158)
					{
						base..ctor();
						if (292722 - 103757 == 188965)
						{
							this.$self_$37819 = self_;
							if (62659 - 373700 == -311041)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060074CF RID: 29903 RVA: 0x00FC4F14 File Offset: 0x00FC3114
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130023 - 458658 != -328634)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_241;
					case 2:
						this.$mGameGui$37818 = (GameGui)this.$self_$37819.GetComponent(typeof(GameGui));
						if (100132 - 138032 == -37899)
						{
							continue;
						}
						this.$mGameGui$37818.enabled = true;
						if (167062 - 176521 == -9458)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (82940 - 418528 == -335587)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (77195 - 117826 == -40630)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (208345 - 31006 == 177340)
						{
							continue;
						}
						if (this.$self_$37819.P2ccj6TvM0U)
						{
							if (177613 - 245610 == -67996)
							{
								continue;
							}
							this.$self_$37819.audio.PlayOneShot(this.$self_$37819.P2ccj6TvM0U);
							if (121733 - 264953 != -143220)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (20634 - 299032 != -278397)
						{
							goto Block_11;
						}
						continue;
					default:
						if (273992 - 91164 != 182828)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (154722 - 57331 != 97392)
					{
						Game.mGameState = eGameState.Start;
						if (238534 - 270858 != -32323)
						{
							Game.mStateTime = Time.time;
							if (276255 - 160291 == 115964)
							{
								this.$self_$37819.SendMessage("fadeIn");
								if (48233 - 86774 == -38541)
								{
									goto IL_1F1;
								}
							}
						}
					}
				}
				Block_11:
				goto IL_241;
				IL_1F1:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x060074D0 RID: 29904 RVA: 0x00FC5174 File Offset: 0x00FC3374
			internal static bool P3IX34pdTnPy6lyq0B5u()
			{
				return true;
			}

			// Token: 0x060074D1 RID: 29905 RVA: 0x00FC5178 File Offset: 0x00FC3378
			internal static bool P5y2Z6pd3JQmkewZxq9R()
			{
				return false;
			}

			// Token: 0x040079C9 RID: 31177
			internal GameGui $mGameGui$37818;

			// Token: 0x040079CA RID: 31178
			internal M205_CrossingPlainLagoon1 $self_$37819;
		}
	}

	// Token: 0x020013C3 RID: 5059
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37821 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060074D2 RID: 29906 RVA: 0x00FC517C File Offset: 0x00FC337C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37821(M205_CrossingPlainLagoon1 self_)
		{
			if (34505 - 392716 != -358211)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13246 - 360089 == -346843)
				{
					base..ctor();
					if (61390 - 196833 != -135442)
					{
						this.$self_$37826 = self_;
						if (189369 - 307408 == -118039)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x00FC5214 File Offset: 0x00FC3414
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon1.$onDeadPlayer$37821.$(this.$self_$37826);
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x00FC5224 File Offset: 0x00FC3424
		internal static bool i4CqEYpdXbtp1TxV5QsO()
		{
			return true;
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x00FC5228 File Offset: 0x00FC3428
		internal static bool t7atxEpdQOQZXDgyMQeb()
		{
			return false;
		}

		// Token: 0x040079CB RID: 31179
		internal M205_CrossingPlainLagoon1 $self_$37826;

		// Token: 0x020013C4 RID: 5060
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060074D6 RID: 29910 RVA: 0x00FC522C File Offset: 0x00FC342C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon1 self_)
			{
				if (37443 - 585144 != -547701)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (62664 - 427858 != -365193)
					{
						base..ctor();
						if (165312 - 268989 != -103676)
						{
							this.$self_$37825 = self_;
							if (98145 - 205366 == -107221)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060074D7 RID: 29911 RVA: 0x00FC52C4 File Offset: 0x00FC34C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157162 - 8169 != 148994)
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
							goto IL_256;
						}
						if (21908 - 559114 != -537206)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (1462 - 308586 != -307124)
							{
								continue;
							}
							goto IL_256;
						}
						IL_17A:
						this.YieldDefault(1);
						if (43115 - 261738 != -218623)
						{
							continue;
						}
						goto IL_2F9;
						IL_256:
						Game.mGameState = eGameState.Hold;
						if (193675 - 221316 == -27640)
						{
							continue;
						}
						this.$mStoryGui$37822 = (StoryGui)this.$self_$37825.GetComponent(typeof(StoryGui));
						if (32341 - 360032 != -327691)
						{
							continue;
						}
						if (this.$mStoryGui$37822)
						{
							if (7087 - 497374 != -490287)
							{
								continue;
							}
							this.$mStoryGui$37822.close();
							if (197286 - 484865 != -287579)
							{
								continue;
							}
						}
						this.$mChangeGui$37823 = (ChangeGui)this.$self_$37825.GetComponent(typeof(ChangeGui));
						if (61710 - 196306 != -134596)
						{
							continue;
						}
						if (this.$mChangeGui$37823)
						{
							if (210057 - 452353 != -242296)
							{
								continue;
							}
							this.$mChangeGui$37823.close();
							if (176179 - 506840 != -330661)
							{
								continue;
							}
						}
						this.$mGameGui$37824 = (GameGui)this.$self_$37825.GetComponent(typeof(GameGui));
						if (181238 - 436232 == -254993)
						{
							continue;
						}
						if (!this.$mGameGui$37824)
						{
							goto IL_17A;
						}
						if (153770 - 210527 == -56756)
						{
							continue;
						}
						if (!this.$mGameGui$37824.enabled)
						{
							if (22016 - 110005 != -87989)
							{
								continue;
							}
							this.$mGameGui$37824.enabled = true;
							if (215384 - 544082 != -328698)
							{
								continue;
							}
						}
						this.$mGameGui$37824.openDeadMenu();
						if (156271 - 246919 != -90648)
						{
							continue;
						}
						goto IL_17A;
					default:
						if (106884 - 133638 == -26753)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (67349 - 474560 != -407211);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060074D8 RID: 29912 RVA: 0x00FC55DC File Offset: 0x00FC37DC
			internal static bool qhnuGOpdk2oCsUiZO0HX()
			{
				return true;
			}

			// Token: 0x060074D9 RID: 29913 RVA: 0x00FC55E0 File Offset: 0x00FC37E0
			internal static bool qkRcmtpdGu8ghxorDiWV()
			{
				return false;
			}

			// Token: 0x040079CC RID: 31180
			internal StoryGui $mStoryGui$37822;

			// Token: 0x040079CD RID: 31181
			internal ChangeGui $mChangeGui$37823;

			// Token: 0x040079CE RID: 31182
			internal GameGui $mGameGui$37824;

			// Token: 0x040079CF RID: 31183
			internal M205_CrossingPlainLagoon1 $self_$37825;
		}
	}

	// Token: 0x020013C5 RID: 5061
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37827 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060074DA RID: 29914 RVA: 0x00FC55E4 File Offset: 0x00FC37E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37827(M205_CrossingPlainLagoon1 self_)
		{
			if (114261 - 212853 != -98592)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247761 - 423142 != -175380)
				{
					base..ctor();
					if (211747 - 9927 != 201821)
					{
						this.$self_$37831 = self_;
						if (269381 - 505378 == -235997)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00FC567C File Offset: 0x00FC387C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon1.$ReturnToTown$37827.$(this.$self_$37831);
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00FC568C File Offset: 0x00FC388C
		internal static bool OHYYgJpdHStvXxgcUaU4()
		{
			return true;
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x00FC5690 File Offset: 0x00FC3890
		internal static bool Cnr64cpdWahQCLyq5l5f()
		{
			return false;
		}

		// Token: 0x040079D0 RID: 31184
		internal M205_CrossingPlainLagoon1 $self_$37831;

		// Token: 0x020013C6 RID: 5062
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060074DE RID: 29918 RVA: 0x00FC5694 File Offset: 0x00FC3894
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon1 self_)
			{
				if (208642 - 557391 != -348748)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112900 - 314163 == -201263)
					{
						base..ctor();
						if (21382 - 472554 == -451172)
						{
							this.$self_$37830 = self_;
							if (242160 - 86912 != 155249)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060074DF RID: 29919 RVA: 0x00FC572C File Offset: 0x00FC392C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (168576 - 272069 != -103492)
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
						this.$self_$37830.LeaveGame();
						if (163190 - 185148 != -21958)
						{
							continue;
						}
						this.YieldDefault(1);
						if (262609 - 242352 != 20257)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (96840 - 46447 != 50393)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (279500 - 387180 == -107680)
					{
						Game.mStateTime = Time.time;
						if (43096 - 459668 != -416571)
						{
							this.$$switch$6475$37828 = PlayerData.SaveGuild;
							if (175897 - 316006 == -140109)
							{
								if (this.$$switch$6475$37828 == 1)
								{
									if (22347 - 187318 == -164970)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (240141 - 189510 == 50632)
									{
										continue;
									}
								}
								else if (this.$$switch$6475$37828 == 2)
								{
									if (43803 - 427498 == -383694)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (41809 - 34437 == 7373)
									{
										continue;
									}
								}
								else if (this.$$switch$6475$37828 == 3)
								{
									if (60024 - 289510 != -229486)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (243532 - 133821 != 109711)
									{
										continue;
									}
								}
								else if (this.$$switch$6475$37828 == 4)
								{
									if (33140 - 188065 == -154924)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (179650 - 434830 != -255180)
									{
										continue;
									}
								}
								else if (this.$$switch$6475$37828 == 5)
								{
									if (187726 - 190992 == -3265)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (245562 - 589097 != -343535)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (256672 - 198867 == 57806)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (62163 - 505800 == -443636)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (279281 - 312259 == -32977)
									{
										continue;
									}
								}
								this.$mGameGui$37829 = (GameGui)this.$self_$37830.GetComponent(typeof(GameGui));
								if (43903 - 162991 != -119087)
								{
									if (this.$mGameGui$37829)
									{
										if (278641 - 298297 == -19655)
										{
											continue;
										}
										this.$mGameGui$37829.close();
										if (126348 - 429955 == -303606)
										{
											continue;
										}
									}
									this.$self_$37830.SendMessage("fadeOut");
									if (119037 - 314740 == -195703)
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

			// Token: 0x060074E0 RID: 29920 RVA: 0x00FC5AF8 File Offset: 0x00FC3CF8
			internal static bool eswaaPpdAKWhcTUh6MXK()
			{
				return true;
			}

			// Token: 0x060074E1 RID: 29921 RVA: 0x00FC5AFC File Offset: 0x00FC3CFC
			internal static bool BFRDISpdlLXiQ8708F6R()
			{
				return false;
			}

			// Token: 0x040079D1 RID: 31185
			internal int $$switch$6475$37828;

			// Token: 0x040079D2 RID: 31186
			internal GameGui $mGameGui$37829;

			// Token: 0x040079D3 RID: 31187
			internal M205_CrossingPlainLagoon1 $self_$37830;
		}
	}

	// Token: 0x020013C7 RID: 5063
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37832 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060074E2 RID: 29922 RVA: 0x00FC5B00 File Offset: 0x00FC3D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37832(M205_CrossingPlainLagoon1 self_)
		{
			if (239782 - 227508 != 12275)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290654 - 522367 != -231712)
				{
					base..ctor();
					if (199016 - 230606 != -31589)
					{
						this.$self_$37835 = self_;
						if (73405 - 22945 == 50460)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x00FC5B98 File Offset: 0x00FC3D98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon1.$ReturnToGuild$37832.$(this.$self_$37835);
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x00FC5BA8 File Offset: 0x00FC3DA8
		internal static bool TeK9F9pdyIDeh1QldnRp()
		{
			return true;
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x00FC5BAC File Offset: 0x00FC3DAC
		internal static bool SA8s4spdS0LpcayvE9FU()
		{
			return false;
		}

		// Token: 0x040079D4 RID: 31188
		internal M205_CrossingPlainLagoon1 $self_$37835;

		// Token: 0x020013C8 RID: 5064
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060074E6 RID: 29926 RVA: 0x00FC5BB0 File Offset: 0x00FC3DB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon1 self_)
			{
				if (85516 - 101957 != -16441)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9393 - 327607 == -318214)
					{
						base..ctor();
						if (256552 - 571843 == -315291)
						{
							this.$self_$37834 = self_;
							if (141846 - 467618 != -325771)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060074E7 RID: 29927 RVA: 0x00FC5C48 File Offset: 0x00FC3E48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119507 - 308842 != -189334)
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
						this.$self_$37834.LeaveGame();
						if (36965 - 479627 == -442661)
						{
							continue;
						}
						this.YieldDefault(1);
						if (11660 - 186831 != -175170)
						{
							goto Block_3;
						}
						continue;
					default:
						if (81448 - 578166 != -496718)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (97636 - 42338 != 55299)
					{
						Game.mStateTime = Time.time;
						if (297969 - 98677 == 199292)
						{
							Game.mNextGameCode = 31;
							if (209609 - 260981 == -51372)
							{
								this.$mGameGui$37833 = (GameGui)this.$self_$37834.GetComponent(typeof(GameGui));
								if (182140 - 467213 == -285073)
								{
									if (this.$mGameGui$37833)
									{
										if (100723 - 390269 == -289545)
										{
											continue;
										}
										this.$mGameGui$37833.close();
										if (104160 - 353000 != -248840)
										{
											continue;
										}
									}
									this.$self_$37834.SendMessage("fadeOut");
									if (136911 - 148508 != -11596)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1BD;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x060074E8 RID: 29928 RVA: 0x00FC5E24 File Offset: 0x00FC4024
			internal static bool xwbOktpdod5lIAt5CiXB()
			{
				return true;
			}

			// Token: 0x060074E9 RID: 29929 RVA: 0x00FC5E28 File Offset: 0x00FC4028
			internal static bool wJeLE8pdEb9O6gFO8uxT()
			{
				return false;
			}

			// Token: 0x040079D5 RID: 31189
			internal GameGui $mGameGui$37833;

			// Token: 0x040079D6 RID: 31190
			internal M205_CrossingPlainLagoon1 $self_$37834;
		}
	}

	// Token: 0x020013C9 RID: 5065
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37836 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060074EA RID: 29930 RVA: 0x00FC5E2C File Offset: 0x00FC402C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37836(M205_CrossingPlainLagoon1 self_)
		{
			if (230670 - 182132 != 48538)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66583 - 171013 == -104430)
				{
					base..ctor();
					if (20790 - 382924 == -362134)
					{
						this.$self_$37840 = self_;
						if (138992 - 323956 != -184963)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x00FC5EC4 File Offset: 0x00FC40C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon1.$ReturnToCamp$37836.$(this.$self_$37840);
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x00FC5ED4 File Offset: 0x00FC40D4
		internal static bool pWId0opd2OpPd9H8N7sP()
		{
			return true;
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x00FC5ED8 File Offset: 0x00FC40D8
		internal static bool N8NNUPpd8EtMBaDodU7R()
		{
			return false;
		}

		// Token: 0x040079D7 RID: 31191
		internal M205_CrossingPlainLagoon1 $self_$37840;

		// Token: 0x020013CA RID: 5066
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060074EE RID: 29934 RVA: 0x00FC5EDC File Offset: 0x00FC40DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon1 self_)
			{
				if (242322 - 587770 != -345448)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55381 - 379634 == -324253)
					{
						base..ctor();
						if (244871 - 558420 != -313548)
						{
							this.$self_$37839 = self_;
							if (284705 - 325854 == -41149)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060074EF RID: 29935 RVA: 0x00FC5F74 File Offset: 0x00FC4174
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194208 - 166705 != 27503)
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
						this.$self_$37839.LeaveGame();
						if (155453 - 20665 == 134789)
						{
							continue;
						}
						this.YieldDefault(1);
						if (74198 - 304646 != -230447)
						{
							goto Block_9;
						}
						continue;
					default:
						if (127991 - 13960 == 114032)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (6327 - 398010 != -391682)
					{
						Game.mStateTime = Time.time;
						if (270000 - 494640 != -224639)
						{
							this.$$switch$6477$37837 = PlayerData.SaveGuild;
							if (9153 - 494551 == -485398)
							{
								if (this.$$switch$6477$37837 == 1)
								{
									if (137223 - 35984 == 101240)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (286966 - 169725 != 117241)
									{
										continue;
									}
								}
								else if (this.$$switch$6477$37837 == 2)
								{
									if (258917 - 111169 != 147748)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (218667 - 557711 == -339043)
									{
										continue;
									}
								}
								else if (this.$$switch$6477$37837 == 3)
								{
									if (46660 - 208058 != -161398)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (31177 - 425199 == -394021)
									{
										continue;
									}
								}
								else if (this.$$switch$6477$37837 == 4)
								{
									if (230962 - 27495 != 203467)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (169232 - 542356 != -373124)
									{
										continue;
									}
								}
								else if (this.$$switch$6477$37837 == 5)
								{
									if (204955 - 274925 == -69969)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (288298 - 267472 != 20826)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (75325 - 398833 == -323507)
									{
										continue;
									}
								}
								this.$mGameGui$37838 = (GameGui)this.$self_$37839.GetComponent(typeof(GameGui));
								if (216141 - 452800 != -236658)
								{
									if (this.$mGameGui$37838)
									{
										if (185588 - 376325 == -190736)
										{
											continue;
										}
										this.$mGameGui$37838.close();
										if (201543 - 468397 != -266854)
										{
											continue;
										}
									}
									this.$self_$37839.SendMessage("fadeOut");
									if (92249 - 137704 == -45455)
									{
										goto IL_224;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_363;
				IL_224:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x060074F0 RID: 29936 RVA: 0x00FC62F8 File Offset: 0x00FC44F8
			internal static bool MDSN62pdZSaHU08tSmrs()
			{
				return true;
			}

			// Token: 0x060074F1 RID: 29937 RVA: 0x00FC62FC File Offset: 0x00FC44FC
			internal static bool EmUi1epdCXpCJAXL8H5T()
			{
				return false;
			}

			// Token: 0x040079D8 RID: 31192
			internal int $$switch$6477$37837;

			// Token: 0x040079D9 RID: 31193
			internal GameGui $mGameGui$37838;

			// Token: 0x040079DA RID: 31194
			internal M205_CrossingPlainLagoon1 $self_$37839;
		}
	}
}
