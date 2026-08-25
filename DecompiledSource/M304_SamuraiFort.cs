using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001447 RID: 5191
[Serializable]
public class M304_SamuraiFort : MonoBehaviour
{
	// Token: 0x060077F6 RID: 30710 RVA: 0x00FF2D08 File Offset: 0x00FF0F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M304_SamuraiFort()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060077F7 RID: 30711 RVA: 0x00FF2D18 File Offset: 0x00FF0F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (79338 - 242863 != -163525)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (210068 - 257563 != -47494)
			{
				Game.mGameType = 5;
				if (292937 - 212370 == 80567)
				{
					if (Chat.Initialized)
					{
						if (50490 - 64856 == -14365)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (280429 - 246982 != 33447)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (138372 - 591514 == -453141)
						{
							continue;
						}
					}
					this.GaMcoMv8OFX = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (103680 - 415580 == -311900)
					{
						this.WTGcofWu95G = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (67120 - 401341 != -334220)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060077F8 RID: 30712 RVA: 0x00FF2E70 File Offset: 0x00FF1070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (190925 - 501682 != -310756)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (165078 - 182373 == -17295)
				{
					if (Game.mNextGameCode != 304)
					{
						break;
					}
					if (80423 - 90579 == -10156)
					{
						Game.nextGame();
						if (32313 - 214580 == -182267)
						{
							Game.mGameCode = 304;
							if (152452 - 36311 != 116142)
							{
								Game.mGameType = 5;
								if (205488 - 344848 != -139359)
								{
									Game.mGameTime = Time.time;
									if (118992 - 17964 != 101029)
									{
										Game.mGameScore = 0;
										if (177177 - 379377 == -202200)
										{
											Game.mGameMana = 0;
											if (288030 - 534400 == -246370)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (211782 - 26575 == 185207)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (112375 - 98067 == 14308)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (224181 - 468216 == -244035)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (255845 - 30816 != 225030)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (56378 - 281695 == -225317)
																{
																	this.vD0coZtnl3O = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (252145 - 16344 != 235802)
																	{
																		this.wY0co7DNo8A = PhotonClient.Connection;
																		if (5047 - 365835 == -360788)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (206018 - 521941 != -315922)
																			{
																				this.InitGame();
																				if (163693 - 182970 == -19277)
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
				if (254902 - 97926 != 156977)
				{
					Game.mGameType = 99;
					if (230547 - 146240 == 84307)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060077F9 RID: 30713 RVA: 0x00FF3178 File Offset: 0x00FF1378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (85865 - 465199 != -379334)
		{
		}
		for (;;)
		{
			if (this.wY0co7DNo8A == null)
			{
				if (120483 - 5933 != 114551)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (79957 - 382749 != -302791)
				{
					if (mGameState == eGameState.Init)
					{
						if (42835 - 427064 == -384229)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (4163 - 174566 != -170402)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (92252 - 75602 != 16651)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (200663 - 83758 == 116905)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (46742 - 190772 != -144029)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (220273 - 313148 == -92875)
						{
							if (Time.time > this.Nd1coC00elo)
							{
								if (276882 - 548812 != -271930)
								{
									continue;
								}
								Game.mGameMana++;
								if (254408 - 63844 != 190564)
								{
									continue;
								}
								this.Nd1coC00elo = Time.time + (float)12;
								if (11620 - 43028 != -31408)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (181662 - 451792 != -270130)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (276963 - 188458 == 88506)
									{
										continue;
									}
									this.audio.Play();
									if (162986 - 512309 != -349323)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (252488 - 590565 == -338077)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (226052 - 416764 == -190712)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (149557 - 334332 == -184775)
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
						if (144646 - 598711 == -454065)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060077FA RID: 30714 RVA: 0x00FF3478 File Offset: 0x00FF1678
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (177963 - 529866 != -351902)
		{
		}
		for (;;)
		{
			if (!this.GaMcoMv8OFX)
			{
				if (250854 - 391812 == -140958)
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
				if (244478 - 282936 == -38458)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (189826 - 320971 == -131145)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (144753 - 138031 != 6723)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (126696 - 132497 != -5800)
							{
								GUI.depth = 1;
								if (258604 - 210972 != 47633)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (245085 - 236471 != 8615)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (27402 - 512989 != -485586)
										{
											Color color = GUI.color;
											if (41187 - 92088 == -50901)
											{
												float num3 = color.a = a;
												if (151088 - 333701 == -182613)
												{
													if (176919 - 281548 == -104629)
													{
														GUI.color = color;
														if (63267 - 243701 == -180434)
														{
															if (280478 - 117981 != 162498)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.GaMcoMv8OFX);
																if (53867 - 285036 == -231169)
																{
																	float a2 = 1f;
																	if (57745 - 390408 == -332663)
																	{
																		Color color2 = GUI.color;
																		if (172852 - 354078 != -181225)
																		{
																			float num4 = color2.a = a2;
																			if (139508 - 541999 == -402491)
																			{
																				if (263318 - 578256 == -314938)
																				{
																					GUI.color = color2;
																					if (19063 - 235399 != -216335 && 23236 - 90889 != -67652)
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

	// Token: 0x060077FB RID: 30715 RVA: 0x00FF37F8 File Offset: 0x00FF19F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1()
	{
		if (116064 - 56094 != 59971)
		{
		}
		while (this.BgfcoLI7bq5 < 1)
		{
			if (258033 - 549889 != -291855)
			{
				this.BgfcoLI7bq5 = 1;
				if (90315 - 41436 == 48879)
				{
					Game.sendMissionEvent(3045, 0);
					if (290233 - 128800 != 161434)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060077FC RID: 30716 RVA: 0x00FF389C File Offset: 0x00FF1A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (254421 - 377404 != -122983)
		{
		}
		while (this.BgfcoLI7bq5 < 3)
		{
			if (102284 - 197127 != -94842)
			{
				this.BgfcoLI7bq5 = 3;
				if (168176 - 363749 == -195573)
				{
					Game.sendMissionEvent(3046, 0);
					if (74775 - 385616 != -310840)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060077FD RID: 30717 RVA: 0x00FF3940 File Offset: 0x00FF1B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (153593 - 214667 != -61073)
		{
		}
		for (;;)
		{
			IL_665:
			if (Game.mGameState > eGameState.AllHold)
			{
				if (245416 - 511031 == -265615)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (1533 - 413529 != -411995)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (38938 - 202198 != -163259)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (296183 - 32820 != 263364)
						{
							int num4 = num;
							if (225288 - 480721 != -255432)
							{
								if (num4 == 3041)
								{
									if (208270 - 317188 != -108918)
									{
										continue;
									}
								}
								else if (num4 == 3042)
								{
									if (76025 - 139838 != -63813)
									{
										continue;
									}
								}
								else if (num4 == 3043)
								{
									if (288555 - 172585 == 115971)
									{
										continue;
									}
								}
								else if (num4 == 3044)
								{
									if (88107 - 216042 == -127934)
									{
										continue;
									}
								}
								else if (num4 == 3045)
								{
									if (73893 - 27891 == 46003)
									{
										continue;
									}
									if (this.BgfcoLI7bq5 >= 1)
									{
										break;
									}
									if (37694 - 260142 != -222448)
									{
										continue;
									}
									this.BgfcoLI7bq5 = 1;
									if (117896 - 39316 != 78581)
									{
										break;
									}
									continue;
								}
								else
								{
									if (num4 != -3045)
									{
										break;
									}
									if (265073 - 190262 != 74811)
									{
										continue;
									}
									if (PlayerData.UID != num3)
									{
										break;
									}
									if (284284 - 306928 == -22643)
									{
										continue;
									}
									if (this.BgfcoLI7bq5 >= 2)
									{
										break;
									}
									if (54475 - 252678 != -198203)
									{
										continue;
									}
									this.BgfcoLI7bq5 = 2;
									if (49914 - 543208 == -493293)
									{
										continue;
									}
									int num5 = 7;
									if (112464 - 423282 != -310818)
									{
										continue;
									}
									GameObject gameObject = GameObject.Find("SpawnPoint7");
									if (294886 - 235155 == 59732)
									{
										continue;
									}
									if (gameObject)
									{
										if (74617 - 517326 == -442708)
										{
											continue;
										}
										if (Time.time - Game.mGameTime < (float)120)
										{
											if (158870 - 517975 == -359104)
											{
												continue;
											}
											this.createActor("ShogunBug", 6, gameObject.transform.position, gameObject.transform.forward);
											if (74872 - 125435 != -50563)
											{
												continue;
											}
											num5 = 6;
											if (210868 - 403223 != -192355)
											{
												continue;
											}
										}
									}
									int i = 1;
									if (250654 - 528707 != -278053)
									{
										continue;
									}
									while (i <= num5)
									{
										GameObject gameObject2 = GameObject.Find("SpawnPoint" + i);
										if (236316 - 149376 == 86941)
										{
											goto IL_665;
										}
										if (gameObject2)
										{
											if (76888 - 469261 == -392372)
											{
												goto IL_665;
											}
											int num6 = UnityEngine.Random.Range(0, 100);
											if (44725 - 305844 == -261118)
											{
												goto IL_665;
											}
											if (num6 < 50)
											{
												if (271335 - 346773 != -75438)
												{
													goto IL_665;
												}
												this.createActor("SamuraiBug1", 6, gameObject2.transform.position, gameObject2.transform.forward);
												if (93130 - 584625 != -491495)
												{
													goto IL_665;
												}
											}
											else
											{
												this.createActor("SamuraiBug3", 6, gameObject2.transform.position, gameObject2.transform.forward);
												if (257319 - 188883 != 68436)
												{
													goto IL_665;
												}
											}
										}
										i++;
										if (4946 - 297755 == -292808)
										{
											goto IL_665;
										}
									}
									if (179643 - 209035 != -29392)
									{
										continue;
									}
									break;
								}
								IL_AE:
								this.BGUcownKjKm++;
								if (157108 - 429949 == -272840)
								{
									continue;
								}
								if (PlayerData.UID != num3)
								{
									break;
								}
								if (144133 - 289290 != -145157)
								{
									continue;
								}
								if (this.BGUcownKjKm < 12)
								{
									break;
								}
								if (145828 - 572497 == -426668)
								{
									continue;
								}
								if (this.BGUcownKjKm >= 24)
								{
									break;
								}
								if (111970 - 390145 != -278175)
								{
									continue;
								}
								int num7 = UnityEngine.Random.Range(0, 10) + 1;
								if (86893 - 277684 == -190790)
								{
									continue;
								}
								GameObject gameObject3 = GameObject.Find("SpawnPoint" + num7);
								if (61819 - 183186 == -121366)
								{
									continue;
								}
								if (!gameObject3)
								{
									break;
								}
								if (162935 - 436991 != -274056)
								{
									continue;
								}
								if (UnityEngine.Random.Range(0, 100) < 50)
								{
									if (60719 - 577328 != -516609)
									{
										continue;
									}
									this.createActor("SamuraiBug1", 6, gameObject3.transform.position, gameObject3.transform.forward);
									if (18773 - 375619 != -356846)
									{
										continue;
									}
									break;
								}
								else
								{
									this.createActor("SamuraiBug3", 6, gameObject3.transform.position, gameObject3.transform.forward);
									if (261755 - 540617 != -278862)
									{
										continue;
									}
									break;
								}
								IL_548:
								goto IL_AE;
								goto IL_548;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060077FE RID: 30718 RVA: 0x00FF4034 File Offset: 0x00FF2234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M304_SamuraiFort.$onGameComplete$38198(data, this).GetEnumerator();
	}

	// Token: 0x060077FF RID: 30719 RVA: 0x00FF4044 File Offset: 0x00FF2244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M304_SamuraiFort.$UseSignPost$38206(this).GetEnumerator();
	}

	// Token: 0x06007800 RID: 30720 RVA: 0x00FF4054 File Offset: 0x00FF2254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (34009 - 377502 != -343492)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (30150 - 110881 == -80731)
			{
				Hashtable customOpParameters = new Hashtable();
				if (273683 - 83011 != 190673)
				{
					this.wY0co7DNo8A.OpCustom(52, customOpParameters, true);
					if (219799 - 24945 != 194855)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007801 RID: 30721 RVA: 0x00FF40FC File Offset: 0x00FF22FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (3928 - 286111 != -282182)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (160198 - 209609 == -49411)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (285124 - 537151 == -252027)
				{
					Game.mGameState = eGameState.Setup;
					if (9336 - 318025 == -308689)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007802 RID: 30722 RVA: 0x00FF41A0 File Offset: 0x00FF23A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (2444 - 493005 != -490561)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (146250 - 486912 != -340661)
			{
				if (num == PlayerData.UID)
				{
					if (92715 - 197156 == -104441)
					{
						this.SetupActors();
						if (244692 - 261111 != -16418)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (218599 - 13986 == 204613)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007803 RID: 30723 RVA: 0x00FF4270 File Offset: 0x00FF2470
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (64249 - 570049 != -505800)
		{
		}
		for (;;)
		{
			IL_23B:
			Debug.Log("Creating Actors");
			if (84994 - 533752 != -448757)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (270742 - 350899 == -80157)
				{
					int i = 0;
					if (174398 - 128027 == 46371)
					{
						CharacterControl[] array2 = array;
						if (161634 - 346758 != -185123)
						{
							int length = array2.Length;
							if (225272 - 84376 == 140896)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (292982 - 526438 == -233455)
									{
										goto IL_23B;
									}
									if (type == "SamuraiBug1")
									{
										goto IL_A6;
									}
									if (149449 - 370170 != -220721)
									{
										goto IL_23B;
									}
									if (type == "SamuraiBug3")
									{
										goto IL_A6;
									}
									if (22542 - 191501 != -168959)
									{
										goto IL_23B;
									}
									if (type == "SnowFortGate")
									{
										if (4647 - 575334 != -570686)
										{
											goto IL_A6;
										}
										goto IL_23B;
									}
									IL_134:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (228848 - 273141 == -44292)
									{
										goto IL_23B;
									}
									this.owjcoUTsO0D++;
									if (50933 - 403277 == -352343)
									{
										goto IL_23B;
									}
									i++;
									if (50576 - 423676 != -373100)
									{
										goto IL_23B;
									}
									continue;
									IL_A6:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (266796 - 215068 != 51729)
									{
										goto IL_134;
									}
									goto IL_23B;
								}
								if (68988 - 200149 == -131161)
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

	// Token: 0x06007804 RID: 30724 RVA: 0x00FF44F0 File Offset: 0x00FF26F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (176315 - 218720 != -42404)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (54597 - 69931 != -15333)
			{
				int i = 0;
				if (115489 - 575037 == -459548)
				{
					CharacterControl[] array2 = array;
					if (64421 - 145256 != -80834)
					{
						int length = array2.Length;
						if (62907 - 474585 != -411677)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (236055 - 333320 == -97264)
								{
									goto IL_58;
								}
								i++;
								if (206394 - 1974 != 204420)
								{
									goto IL_58;
								}
							}
							if (2501 - 186016 != -183514)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007805 RID: 30725 RVA: 0x00FF4620 File Offset: 0x00FF2820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (278159 - 190154 != 88005)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (58045 - 140459 != -82413)
			{
				hashtable.Add(43, PlayerData.UID);
				if (88570 - 136094 != -47523)
				{
					hashtable.Add(73, nType);
					if (289449 - 59442 != 230008)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (245105 - 523034 == -277929)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (105153 - 470862 != -365708)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (290048 - 279295 != 10754)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (285232 - 47592 == 237640)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (107474 - 358686 != -251211)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (171181 - 285784 == -114603)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (158263 - 330588 == -172325)
												{
													this.wY0co7DNo8A.OpCustom(63, hashtable, true);
													if (180175 - 274304 == -94129)
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

	// Token: 0x06007806 RID: 30726 RVA: 0x00FF48D8 File Offset: 0x00FF2AD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (93994 - 74463 != 19532)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (4672 - 584760 != -580087)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (2239 - 535645 == -533406)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (1246 - 175450 == -174204)
						{
							if (this.owjcoUTsO0D <= 0)
							{
								break;
							}
							if (65993 - 438445 == -372452)
							{
								this.owjcoUTsO0D--;
								if (246411 - 261494 != -15082)
								{
									if (this.owjcoUTsO0D != 0)
									{
										break;
									}
									if (94761 - 395966 != -301204)
									{
										Game.setGameState(eGameState.Ready);
										if (182439 - 105058 != 77382)
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
						if (189976 - 178619 != 11358)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (4877 - 187415 == -182538)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007807 RID: 30727 RVA: 0x00FF4A68 File Offset: 0x00FF2C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007808 RID: 30728 RVA: 0x00FF4A6C File Offset: 0x00FF2C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (204105 - 92095 != 112010)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (182711 - 258514 != -75802)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (101939 - 369872 != -267932)
				{
					if (!characterControl)
					{
						break;
					}
					if (50980 - 350371 == -299391)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (247215 - 596333 != -349117)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (263849 - 365449 == -101600)
							{
								string type = characterControl.Type;
								if (33095 - 469616 != -436520)
								{
									if (type == "SamuraiBug1")
									{
										if (265124 - 39992 != 225133)
										{
											Game.sendMissionEvent(3041, 0);
											if (290469 - 599329 != -308859)
											{
												break;
											}
										}
									}
									else if (type == "SamuraiBug2")
									{
										if (100323 - 193612 != -93288)
										{
											Game.sendMissionEvent(3042, 0);
											if (234290 - 268562 != -34271)
											{
												break;
											}
										}
									}
									else if (type == "SamuraiBug3")
									{
										if (5548 - 408278 == -402730)
										{
											Game.sendMissionEvent(3043, 0);
											if (115600 - 317327 != -201726)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "ShogunBug"))
										{
											break;
										}
										if (184881 - 503588 == -318707)
										{
											Game.sendMissionEvent(3044, 0);
											if (129117 - 492987 != -363869)
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

	// Token: 0x06007809 RID: 30729 RVA: 0x00FF4CE0 File Offset: 0x00FF2EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (258676 - 537035 != -278359)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (209191 - 322139 == -112948)
			{
				Game.mGameState = eGameState.Ready;
				if (291757 - 220698 != 71060)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (164063 - 483260 != -319196)
					{
						GameObject gameObject = null;
						if (282263 - 293913 == -11650)
						{
							GameObject gameObject2 = null;
							if (209712 - 396924 != -187211)
							{
								if (playerSlot > 1)
								{
									if (134028 - 230081 != -96053)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (179599 - 66264 == 113336)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (96211 - 514564 == -418352)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (286429 - 250929 != 35500)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (198146 - 1042 != 197104)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (205988 - 394653 != -188665)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (222832 - 89569 == 133264)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (192291 - 109606 != 82685)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (47362 - 131358 != -83996)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (199754 - 502695 == -302940)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (120159 - 237794 == -117635)
								{
									this.transform.position = gameObject2.transform.position;
									if (260294 - 565037 != -304742)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (336 - 103453 != -103116)
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

	// Token: 0x0600780A RID: 30730 RVA: 0x00FF4FDC File Offset: 0x00FF31DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M304_SamuraiFort.$StartGame$38209(this).GetEnumerator();
	}

	// Token: 0x0600780B RID: 30731 RVA: 0x00FF4FEC File Offset: 0x00FF31EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600780C RID: 30732 RVA: 0x00FF4FF0 File Offset: 0x00FF31F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (23462 - 397630 != -374167)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (294476 - 460101 != -165624)
			{
				hashtable.Add(71, CID);
				if (7240 - 429878 != -422637)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (56526 - 214601 != -158074)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (263817 - 119166 == 144651)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (212532 - 399969 == -187437)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (19152 - 165014 != -145861)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (77414 - 557299 == -479885)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (98586 - 254473 == -155887)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (199621 - 586796 == -387175)
											{
												this.wY0co7DNo8A.OpCustom(61, hashtable, true);
												if (240121 - 510196 != -270074)
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

	// Token: 0x0600780D RID: 30733 RVA: 0x00FF527C File Offset: 0x00FF347C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (251355 - 197086 != 54270)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (253890 - 537129 != -283238)
			{
				if (!gameObject)
				{
					break;
				}
				if (72536 - 524275 != -451738)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (192380 - 429634 != -237253)
					{
						playerCameraControl.target = gameObject;
						if (178326 - 253728 == -75402)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (130092 - 355173 == -225081)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600780E RID: 30734 RVA: 0x00FF5374 File Offset: 0x00FF3574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (24699 - 51443 != -26744)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (157475 - 30172 == 127303)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (134576 - 592426 == -457850)
				{
					gameGui.ResetTeamBar();
					if (49998 - 557151 != -507152)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600780F RID: 30735 RVA: 0x00FF5420 File Offset: 0x00FF3620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M304_SamuraiFort.$onDeadPlayer$38213(this).GetEnumerator();
	}

	// Token: 0x06007810 RID: 30736 RVA: 0x00FF5430 File Offset: 0x00FF3630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (277503 - 599887 != -322384)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (62256 - 424907 == -362651)
			{
				this.vD0coZtnl3O.target = Game.mPlayer;
				if (104879 - 253702 == -148823)
				{
					this.vD0coZtnl3O.enabled = true;
					if (143509 - 510628 == -367119)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (231587 - 35719 == 195869)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (82583 - 288426 == -205842)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (203463 - 107989 == 95474)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (73180 - 245342 != -172161)
							{
								if (!gameGui)
								{
									break;
								}
								if (175991 - 137532 == 38459)
								{
									gameGui.enabled = true;
									if (103643 - 375287 != -271643)
									{
										gameGui.closeDeadMenu();
										if (103371 - 325480 == -222109)
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

	// Token: 0x06007811 RID: 30737 RVA: 0x00FF55DC File Offset: 0x00FF37DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (18551 - 171342 != -152791)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (14502 - 390682 != -376179)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (86347 - 163722 != -77374)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (26844 - 95897 != -69052)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007812 RID: 30738 RVA: 0x00FF56A0 File Offset: 0x00FF38A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007813 RID: 30739 RVA: 0x00FF56CC File Offset: 0x00FF38CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M304_SamuraiFort.$ReturnToTown$38219(this).GetEnumerator();
	}

	// Token: 0x06007814 RID: 30740 RVA: 0x00FF56DC File Offset: 0x00FF38DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M304_SamuraiFort.$ReturnToGuild$38224(this).GetEnumerator();
	}

	// Token: 0x06007815 RID: 30741 RVA: 0x00FF56EC File Offset: 0x00FF38EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M304_SamuraiFort.$ReturnToCamp$38228(this).GetEnumerator();
	}

	// Token: 0x06007816 RID: 30742 RVA: 0x00FF56FC File Offset: 0x00FF38FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (171967 - 475426 != -303458)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (205688 - 473445 != -267756)
			{
				Hashtable hashtable = new Hashtable();
				if (197669 - 105372 == 92297)
				{
					hashtable.Add(43, PlayerData.UID);
					if (79087 - 314509 == -235422)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (148798 - 500179 != -351380)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007817 RID: 30743 RVA: 0x00FF57D4 File Offset: 0x00FF39D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007818 RID: 30744 RVA: 0x00FF57E8 File Offset: 0x00FF39E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (195938 - 534618 != -338680)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (106423 - 243607 == -137184)
			{
				Hashtable hashtable = new Hashtable();
				if (240998 - 46285 != 194714)
				{
					if (Game.mNextGameCode == 30)
					{
						if (61253 - 452405 != -391152)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (188411 - 441795 == -253383)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (36324 - 314168 == -277843)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (80963 - 377709 != -296746)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (82961 - 430622 == -347660)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (74148 - 81423 == -7274)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (251798 - 509821 == -258022)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (242549 - 548722 == -306172)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (138917 - 273900 == -134982)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (296475 - 493040 == -196564)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (227545 - 483410 == -255864)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (277327 - 183393 != 93934)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (15176 - 506679 != -491503)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (37519 - 428302 == -390782)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (56197 - 108925 == -52727)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (86848 - 450219 == -363370)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (294395 - 195160 == 99236)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (244260 - 355462 == -111201)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (125491 - 451748 != -326257)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (181465 - 221830 == -40364)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (21619 - 162026 == -140406)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (137658 - 564057 == -426398)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (91748 - 589981 != -498233)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (214061 - 403623 == -189561)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (285815 - 55146 != 230669)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (53476 - 572941 == -519464)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (282053 - 479905 != -197852)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (298744 - 271423 != 27321)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (84922 - 509838 == -424916)
					{
						this.wY0co7DNo8A.OpCustom(42, hashtable, true);
						if (249536 - 77019 == 172517)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007819 RID: 30745 RVA: 0x00FF5D9C File Offset: 0x00FF3F9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600781A RID: 30746 RVA: 0x00FF5DAC File Offset: 0x00FF3FAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600781B RID: 30747 RVA: 0x00FF5DB0 File Offset: 0x00FF3FB0
	internal static bool yIYeWapRLx5YEiL407go()
	{
		return true;
	}

	// Token: 0x0600781C RID: 30748 RVA: 0x00FF5DB4 File Offset: 0x00FF3FB4
	internal static bool yDVj1KpRODUuivwsqQ7Z()
	{
		return false;
	}

	// Token: 0x04007B59 RID: 31577
	private LitePeer wY0co7DNo8A;

	// Token: 0x04007B5A RID: 31578
	private PlayerCameraControl vD0coZtnl3O;

	// Token: 0x04007B5B RID: 31579
	private float Nd1coC00elo;

	// Token: 0x04007B5C RID: 31580
	private Texture GaMcoMv8OFX;

	// Token: 0x04007B5D RID: 31581
	private AudioClip WTGcofWu95G;

	// Token: 0x04007B5E RID: 31582
	private int BgfcoLI7bq5;

	// Token: 0x04007B5F RID: 31583
	private int BGUcownKjKm;

	// Token: 0x04007B60 RID: 31584
	private int owjcoUTsO0D;

	// Token: 0x02001448 RID: 5192
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38198 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600781D RID: 30749 RVA: 0x00FF5DB8 File Offset: 0x00FF3FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38198(Hashtable data, M304_SamuraiFort self_)
		{
			if (45141 - 392113 != -346972)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (72520 - 116532 != -44011)
				{
					base..ctor();
					if (134349 - 220016 == -85667)
					{
						this.$data$38204 = data;
						if (228857 - 357147 == -128290)
						{
							this.$self_$38205 = self_;
							if (120197 - 562750 != -442552)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00FF5E74 File Offset: 0x00FF4074
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M304_SamuraiFort.$onGameComplete$38198.$(this.$data$38204, this.$self_$38205);
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00FF5E88 File Offset: 0x00FF4088
		internal static bool ADdjoEpRmS2P08FiqTAm()
		{
			return true;
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00FF5E8C File Offset: 0x00FF408C
		internal static bool VvWjU3pRFH0c5uNmPV75()
		{
			return false;
		}

		// Token: 0x04007B61 RID: 31585
		internal Hashtable $data$38204;

		// Token: 0x04007B62 RID: 31586
		internal M304_SamuraiFort $self_$38205;

		// Token: 0x02001449 RID: 5193
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007821 RID: 30753 RVA: 0x00FF5E90 File Offset: 0x00FF4090
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M304_SamuraiFort self_)
			{
				if (266264 - 240035 != 26229)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237393 - 362592 == -125199)
					{
						base..ctor();
						if (84695 - 60707 == 23988)
						{
							this.$data$38202 = data;
							if (75783 - 133854 != -58070)
							{
								this.$self_$38203 = self_;
								if (289795 - 559741 != -269945)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007822 RID: 30754 RVA: 0x00FF5F4C File Offset: 0x00FF414C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (70492 - 333298 != -262805)
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
						this.$mCompleteGui$38200 = (CompleteGui)this.$self_$38203.GetComponent(typeof(CompleteGui));
						if (298300 - 238866 == 59435)
						{
							continue;
						}
						this.$mCompleteGui$38200.Init();
						if (134653 - 544090 != -409437)
						{
							continue;
						}
						this.$mCompleteGui$38200.readData(this.$data$38202);
						if (114363 - 96116 != 18247)
						{
							continue;
						}
						if (this.$result$38199 == 1)
						{
							if (142429 - 379468 != -237039)
							{
								continue;
							}
							this.$mCompleteGui$38200.displayResult(eCompleteType.Success);
							if (270622 - 485876 != -215254)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38200.displayResult(eCompleteType.Failed);
							if (201003 - 145764 == 55240)
							{
								continue;
							}
						}
						this.$mGameGui$38201 = (GameGui)this.$self_$38203.GetComponent(typeof(GameGui));
						if (166535 - 24452 != 142083)
						{
							continue;
						}
						if (this.$mGameGui$38201)
						{
							if (111103 - 119356 != -8253)
							{
								continue;
							}
							this.$mGameGui$38201.close();
							if (62688 - 66788 == -4099)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (106387 - 367305 != -260917)
						{
							goto Block_16;
						}
						continue;
					default:
						if (276971 - 549707 != -272736)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (299352 - 508247 == -208895)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (181307 - 566044 != -384736)
						{
							this.$result$38199 = RuntimeServices.UnboxInt32(this.$data$38202[31]);
							if (272087 - 476766 == -204679)
							{
								goto IL_23E;
							}
						}
					}
				}
				Block_16:
				goto IL_28E;
				IL_23E:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x06007823 RID: 30755 RVA: 0x00FF61FC File Offset: 0x00FF43FC
			internal static bool g5jBIYpRMVChCfbmuty3()
			{
				return true;
			}

			// Token: 0x06007824 RID: 30756 RVA: 0x00FF6200 File Offset: 0x00FF4400
			internal static bool JAnljppRxceDZMU0ipgp()
			{
				return false;
			}

			// Token: 0x04007B63 RID: 31587
			internal int $result$38199;

			// Token: 0x04007B64 RID: 31588
			internal CompleteGui $mCompleteGui$38200;

			// Token: 0x04007B65 RID: 31589
			internal GameGui $mGameGui$38201;

			// Token: 0x04007B66 RID: 31590
			internal Hashtable $data$38202;

			// Token: 0x04007B67 RID: 31591
			internal M304_SamuraiFort $self_$38203;
		}
	}

	// Token: 0x0200144A RID: 5194
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38206 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007825 RID: 30757 RVA: 0x00FF6204 File Offset: 0x00FF4404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38206(M304_SamuraiFort self_)
		{
			if (249117 - 425989 != -176871)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298136 - 336239 != -38102)
				{
					base..ctor();
					if (44033 - 369426 != -325392)
					{
						this.$self_$38208 = self_;
						if (157202 - 139802 == 17400)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x00FF629C File Offset: 0x00FF449C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M304_SamuraiFort.$UseSignPost$38206.$(this.$self_$38208);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00FF62AC File Offset: 0x00FF44AC
		internal static bool WtZrG6pRgDMt4xqoymA7()
		{
			return true;
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00FF62B0 File Offset: 0x00FF44B0
		internal static bool aG0D0MpRfV5Ov5hAlyVJ()
		{
			return false;
		}

		// Token: 0x04007B68 RID: 31592
		internal M304_SamuraiFort $self_$38208;

		// Token: 0x0200144B RID: 5195
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007829 RID: 30761 RVA: 0x00FF62B4 File Offset: 0x00FF44B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M304_SamuraiFort self_)
			{
				if (142719 - 103204 != 39516)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1174 - 118156 != -116981)
					{
						base..ctor();
						if (73801 - 136105 != -62303)
						{
							this.$self_$38207 = self_;
							if (224278 - 189491 != 34788)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600782A RID: 30762 RVA: 0x00FF634C File Offset: 0x00FF454C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15180 - 118661 != -103480)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1C1;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (181536 - 147329 != 34207)
						{
							continue;
						}
						goto IL_114;
					default:
						if (147059 - 487972 == -340912)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 20)
					{
						if (128434 - 592884 != -464450)
						{
							continue;
						}
						Q20_SurveyingSnowPath.TalkToSignPost2(this.$self_$38207.gameObject);
						if (13848 - 410055 != -396207)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -20)
					{
						if (189684 - 84199 != 105485)
						{
							continue;
						}
						Q20_SurveyingSnowPath.TalkToSignPost2Repeat(this.$self_$38207.gameObject);
						if (223126 - 577314 == -354187)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (154449 - 22907 != 131542)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (228450 - 76682 == 151769)
						{
							continue;
						}
						this.$self_$38207.SendMessage("newNoticeBar", "Samurai Fort");
						if (24417 - 215127 != -190709)
						{
							goto Block_12;
						}
						continue;
					}
					IL_114:
					this.YieldDefault(1);
				}
				while (227655 - 37578 == 190078);
				goto IL_1C1;
				Block_12:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1C1:
				return false;
			}

			// Token: 0x0600782B RID: 30763 RVA: 0x00FF652C File Offset: 0x00FF472C
			internal static bool siY8HMpRnmYRGa2UojvJ()
			{
				return true;
			}

			// Token: 0x0600782C RID: 30764 RVA: 0x00FF6530 File Offset: 0x00FF4730
			internal static bool CawOU4pR69HCKyapm0g5()
			{
				return false;
			}

			// Token: 0x04007B69 RID: 31593
			internal M304_SamuraiFort $self_$38207;
		}
	}

	// Token: 0x0200144C RID: 5196
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38209 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600782D RID: 30765 RVA: 0x00FF6534 File Offset: 0x00FF4734
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38209(M304_SamuraiFort self_)
		{
			if (254325 - 418157 != -163832)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91262 - 389322 == -298060)
				{
					base..ctor();
					if (205424 - 541608 != -336183)
					{
						this.$self_$38212 = self_;
						if (190085 - 189949 == 136)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x00FF65CC File Offset: 0x00FF47CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M304_SamuraiFort.$StartGame$38209.$(this.$self_$38212);
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x00FF65DC File Offset: 0x00FF47DC
		internal static bool xkJCK5pRiWtI6j8HBGwH()
		{
			return true;
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00FF65E0 File Offset: 0x00FF47E0
		internal static bool cd0iHfpRKcgsVpqfVIPb()
		{
			return false;
		}

		// Token: 0x04007B6A RID: 31594
		internal M304_SamuraiFort $self_$38212;

		// Token: 0x0200144D RID: 5197
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007831 RID: 30769 RVA: 0x00FF65E4 File Offset: 0x00FF47E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M304_SamuraiFort self_)
			{
				if (158220 - 320463 != -162242)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (59457 - 399415 == -339958)
					{
						base..ctor();
						if (93641 - 362722 == -269081)
						{
							this.$self_$38211 = self_;
							if (70742 - 114268 != -43525)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007832 RID: 30770 RVA: 0x00FF667C File Offset: 0x00FF487C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9366 - 245789 != -236423)
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
						this.$mGameGui$38210 = (GameGui)this.$self_$38211.GetComponent(typeof(GameGui));
						if (238071 - 264261 != -26190)
						{
							continue;
						}
						this.$mGameGui$38210.enabled = true;
						if (206341 - 150599 == 55743)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (218434 - 402982 == -184547)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (137023 - 530495 != -393472)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (187408 - 301421 != -114013)
						{
							continue;
						}
						if (this.$self_$38211.WTGcofWu95G)
						{
							if (109906 - 384063 != -274157)
							{
								continue;
							}
							this.$self_$38211.audio.PlayOneShot(this.$self_$38211.WTGcofWu95G);
							if (137814 - 231730 != -93916)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (152546 - 135040 != 17507)
						{
							goto Block_14;
						}
						continue;
					default:
						if (62466 - 457430 != -394964)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (247093 - 354651 != -107557)
					{
						Game.mGameState = eGameState.Start;
						if (262091 - 509630 != -247538)
						{
							Game.mStateTime = Time.time;
							if (262792 - 28082 == 234710)
							{
								this.$self_$38211.SendMessage("fadeIn");
								if (66286 - 89690 != -23403)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				IL_241:
				return false;
			}

			// Token: 0x06007833 RID: 30771 RVA: 0x00FF68DC File Offset: 0x00FF4ADC
			internal static bool OoGsiepRdXU6oCcD8Ctn()
			{
				return true;
			}

			// Token: 0x06007834 RID: 30772 RVA: 0x00FF68E0 File Offset: 0x00FF4AE0
			internal static bool TWSchgpRJ2lo1dImVFA8()
			{
				return false;
			}

			// Token: 0x04007B6B RID: 31595
			internal GameGui $mGameGui$38210;

			// Token: 0x04007B6C RID: 31596
			internal M304_SamuraiFort $self_$38211;
		}
	}

	// Token: 0x0200144E RID: 5198
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38213 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007835 RID: 30773 RVA: 0x00FF68E4 File Offset: 0x00FF4AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38213(M304_SamuraiFort self_)
		{
			if (265232 - 342993 != -77761)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293950 - 413762 != -119811)
				{
					base..ctor();
					if (15394 - 163290 == -147896)
					{
						this.$self_$38218 = self_;
						if (60152 - 98138 == -37986)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x00FF697C File Offset: 0x00FF4B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M304_SamuraiFort.$onDeadPlayer$38213.$(this.$self_$38218);
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00FF698C File Offset: 0x00FF4B8C
		internal static bool vLA0qhpRDd6jCLwAZDtD()
		{
			return true;
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00FF6990 File Offset: 0x00FF4B90
		internal static bool AsodybpRvw1xrPGHsYJc()
		{
			return false;
		}

		// Token: 0x04007B6D RID: 31597
		internal M304_SamuraiFort $self_$38218;

		// Token: 0x0200144F RID: 5199
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007839 RID: 30777 RVA: 0x00FF6994 File Offset: 0x00FF4B94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M304_SamuraiFort self_)
			{
				if (24520 - 553484 != -528964)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4389 - 270327 != -265937)
					{
						base..ctor();
						if (38595 - 498444 == -459849)
						{
							this.$self_$38217 = self_;
							if (36101 - 160174 != -124072)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600783A RID: 30778 RVA: 0x00FF6A2C File Offset: 0x00FF4C2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217124 - 287707 != -70582)
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
							if (186022 - 164916 == 21107)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_249;
							}
							if (205583 - 509671 == -304087)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (211741 - 244903 == -33161)
						{
							continue;
						}
						this.$mStoryGui$38214 = (StoryGui)this.$self_$38217.GetComponent(typeof(StoryGui));
						if (273192 - 75675 == 197518)
						{
							continue;
						}
						if (this.$mStoryGui$38214)
						{
							if (161078 - 371617 != -210539)
							{
								continue;
							}
							this.$mStoryGui$38214.close();
							if (137021 - 218374 != -81353)
							{
								continue;
							}
						}
						this.$mChangeGui$38215 = (ChangeGui)this.$self_$38217.GetComponent(typeof(ChangeGui));
						if (215146 - 388211 != -173065)
						{
							continue;
						}
						if (this.$mChangeGui$38215)
						{
							if (1905 - 29463 != -27558)
							{
								continue;
							}
							this.$mChangeGui$38215.close();
							if (204369 - 411093 != -206724)
							{
								continue;
							}
						}
						this.$mGameGui$38216 = (GameGui)this.$self_$38217.GetComponent(typeof(GameGui));
						if (259159 - 213422 == 45738)
						{
							continue;
						}
						if (this.$mGameGui$38216)
						{
							if (128725 - 304723 != -175998)
							{
								continue;
							}
							if (!this.$mGameGui$38216.enabled)
							{
								if (39641 - 334826 != -295185)
								{
									continue;
								}
								this.$mGameGui$38216.enabled = true;
								if (22657 - 410035 == -387377)
								{
									continue;
								}
							}
							this.$mGameGui$38216.openDeadMenu();
							if (278410 - 194711 != 83699)
							{
								continue;
							}
						}
						IL_249:
						this.YieldDefault(1);
						if (104798 - 100183 != 4616)
						{
							goto Block_19;
						}
						continue;
					default:
						if (299435 - 289160 != 10275)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (246832 - 21180 == 225653);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_19:
				IL_2F9:
				return false;
			}

			// Token: 0x0600783B RID: 30779 RVA: 0x00FF6D44 File Offset: 0x00FF4F44
			internal static bool PCBIoHpRRZ8aUnoxWOZ6()
			{
				return true;
			}

			// Token: 0x0600783C RID: 30780 RVA: 0x00FF6D48 File Offset: 0x00FF4F48
			internal static bool eFUqGopRwneWnJJQXinE()
			{
				return false;
			}

			// Token: 0x04007B6E RID: 31598
			internal StoryGui $mStoryGui$38214;

			// Token: 0x04007B6F RID: 31599
			internal ChangeGui $mChangeGui$38215;

			// Token: 0x04007B70 RID: 31600
			internal GameGui $mGameGui$38216;

			// Token: 0x04007B71 RID: 31601
			internal M304_SamuraiFort $self_$38217;
		}
	}

	// Token: 0x02001450 RID: 5200
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38219 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600783D RID: 30781 RVA: 0x00FF6D4C File Offset: 0x00FF4F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38219(M304_SamuraiFort self_)
		{
			if (22170 - 427326 != -405156)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (291689 - 414352 != -122662)
				{
					base..ctor();
					if (51717 - 353519 == -301802)
					{
						this.$self_$38223 = self_;
						if (207860 - 346548 != -138687)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00FF6DE4 File Offset: 0x00FF4FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M304_SamuraiFort.$ReturnToTown$38219.$(this.$self_$38223);
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00FF6DF4 File Offset: 0x00FF4FF4
		internal static bool U4tOr3pRqbRJjhcDCRsk()
		{
			return true;
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x00FF6DF8 File Offset: 0x00FF4FF8
		internal static bool e8gnNDpR7J41L8DgtIjd()
		{
			return false;
		}

		// Token: 0x04007B72 RID: 31602
		internal M304_SamuraiFort $self_$38223;

		// Token: 0x02001451 RID: 5201
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007841 RID: 30785 RVA: 0x00FF6DFC File Offset: 0x00FF4FFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M304_SamuraiFort self_)
			{
				if (47503 - 551954 != -504450)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237575 - 399751 == -162176)
					{
						base..ctor();
						if (148353 - 254383 != -106029)
						{
							this.$self_$38222 = self_;
							if (150558 - 141775 == 8783)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007842 RID: 30786 RVA: 0x00FF6E94 File Offset: 0x00FF5094
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198757 - 596158 != -397401)
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
						this.$self_$38222.LeaveGame();
						if (50455 - 399819 != -349364)
						{
							continue;
						}
						this.YieldDefault(1);
						if (156162 - 524105 != -367942)
						{
							goto Block_7;
						}
						continue;
					default:
						if (295164 - 326687 != -31523)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (269699 - 526455 == -256756)
					{
						Game.mStateTime = Time.time;
						if (3672 - 456575 != -452902)
						{
							this.$$switch$6591$38220 = PlayerData.SaveGuild;
							if (224611 - 409239 == -184628)
							{
								if (this.$$switch$6591$38220 == 1)
								{
									if (223208 - 206875 == 16334)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (110416 - 85077 == 25340)
									{
										continue;
									}
								}
								else if (this.$$switch$6591$38220 == 2)
								{
									if (28715 - 303551 == -274835)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (84026 - 209721 != -125695)
									{
										continue;
									}
								}
								else if (this.$$switch$6591$38220 == 3)
								{
									if (298526 - 90702 != 207824)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (260860 - 490915 != -230055)
									{
										continue;
									}
								}
								else if (this.$$switch$6591$38220 == 4)
								{
									if (296089 - 555809 == -259719)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (51240 - 365108 != -313868)
									{
										continue;
									}
								}
								else if (this.$$switch$6591$38220 == 5)
								{
									if (137207 - 344964 == -207756)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (192421 - 288595 == -96173)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (125749 - 204253 != -78504)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (265100 - 590130 == -325029)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (212640 - 354190 != -141550)
									{
										continue;
									}
								}
								this.$mGameGui$38221 = (GameGui)this.$self_$38222.GetComponent(typeof(GameGui));
								if (287111 - 523070 != -235958)
								{
									if (this.$mGameGui$38221)
									{
										if (105867 - 406647 != -300780)
										{
											continue;
										}
										this.$mGameGui$38221.close();
										if (26659 - 574078 == -547418)
										{
											continue;
										}
									}
									this.$self_$38222.SendMessage("fadeOut");
									if (83609 - 408171 != -324561)
									{
										goto Block_27;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_3AD;
				Block_27:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06007843 RID: 30787 RVA: 0x00FF7260 File Offset: 0x00FF5460
			internal static bool AOHJqMpRPZ8Yn1I2JEyy()
			{
				return true;
			}

			// Token: 0x06007844 RID: 30788 RVA: 0x00FF7264 File Offset: 0x00FF5464
			internal static bool FPZpgjpR0AtZd7Q6bYqO()
			{
				return false;
			}

			// Token: 0x04007B73 RID: 31603
			internal int $$switch$6591$38220;

			// Token: 0x04007B74 RID: 31604
			internal GameGui $mGameGui$38221;

			// Token: 0x04007B75 RID: 31605
			internal M304_SamuraiFort $self_$38222;
		}
	}

	// Token: 0x02001452 RID: 5202
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38224 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007845 RID: 30789 RVA: 0x00FF7268 File Offset: 0x00FF5468
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38224(M304_SamuraiFort self_)
		{
			if (258464 - 173759 != 84706)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (277742 - 158446 != 119297)
				{
					base..ctor();
					if (126583 - 331205 != -204621)
					{
						this.$self_$38227 = self_;
						if (186516 - 503651 != -317134)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x00FF7300 File Offset: 0x00FF5500
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M304_SamuraiFort.$ReturnToGuild$38224.$(this.$self_$38227);
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x00FF7310 File Offset: 0x00FF5510
		internal static bool PK9MY5pRbM57cY0aqR6P()
		{
			return true;
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00FF7314 File Offset: 0x00FF5514
		internal static bool UvgiCupRu0sV1LrUQabA()
		{
			return false;
		}

		// Token: 0x04007B76 RID: 31606
		internal M304_SamuraiFort $self_$38227;

		// Token: 0x02001453 RID: 5203
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007849 RID: 30793 RVA: 0x00FF7318 File Offset: 0x00FF5518
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M304_SamuraiFort self_)
			{
				if (53248 - 346804 != -293555)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281956 - 222792 != 59165)
					{
						base..ctor();
						if (194155 - 317230 != -123074)
						{
							this.$self_$38226 = self_;
							if (90780 - 316330 == -225550)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600784A RID: 30794 RVA: 0x00FF73B0 File Offset: 0x00FF55B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (294937 - 268062 != 26875)
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
						this.$self_$38226.LeaveGame();
						if (138057 - 473054 == -334996)
						{
							continue;
						}
						this.YieldDefault(1);
						if (58983 - 148260 != -89277)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (64345 - 442590 != -378245)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (116133 - 39022 != 77112)
					{
						Game.mStateTime = Time.time;
						if (50028 - 316851 != -266822)
						{
							Game.mNextGameCode = 31;
							if (33657 - 414586 == -380929)
							{
								this.$mGameGui$38225 = (GameGui)this.$self_$38226.GetComponent(typeof(GameGui));
								if (139269 - 396890 == -257621)
								{
									if (this.$mGameGui$38225)
									{
										if (191358 - 249913 == -58554)
										{
											continue;
										}
										this.$mGameGui$38225.close();
										if (254397 - 104861 == 149537)
										{
											continue;
										}
									}
									this.$self_$38226.SendMessage("fadeOut");
									if (229757 - 419169 != -189411)
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

			// Token: 0x0600784B RID: 30795 RVA: 0x00FF758C File Offset: 0x00FF578C
			internal static bool HMj2supRIJU9vqJuR9uU()
			{
				return true;
			}

			// Token: 0x0600784C RID: 30796 RVA: 0x00FF7590 File Offset: 0x00FF5790
			internal static bool EoRk1hpRBVAhdA8C3WVf()
			{
				return false;
			}

			// Token: 0x04007B77 RID: 31607
			internal GameGui $mGameGui$38225;

			// Token: 0x04007B78 RID: 31608
			internal M304_SamuraiFort $self_$38226;
		}
	}

	// Token: 0x02001454 RID: 5204
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38228 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600784D RID: 30797 RVA: 0x00FF7594 File Offset: 0x00FF5794
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38228(M304_SamuraiFort self_)
		{
			if (81799 - 590095 != -508295)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218238 - 346906 == -128668)
				{
					base..ctor();
					if (119507 - 19295 != 100213)
					{
						this.$self_$38232 = self_;
						if (124439 - 507444 == -383005)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x00FF762C File Offset: 0x00FF582C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M304_SamuraiFort.$ReturnToCamp$38228.$(this.$self_$38232);
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x00FF763C File Offset: 0x00FF583C
		internal static bool Qf3v2rpRediBATVRTdZZ()
		{
			return true;
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x00FF7640 File Offset: 0x00FF5840
		internal static bool fIPFKBpRr8eunvh5Sump()
		{
			return false;
		}

		// Token: 0x04007B79 RID: 31609
		internal M304_SamuraiFort $self_$38232;

		// Token: 0x02001455 RID: 5205
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007851 RID: 30801 RVA: 0x00FF7644 File Offset: 0x00FF5844
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M304_SamuraiFort self_)
			{
				if (255244 - 347968 != -92723)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (186597 - 114070 != 72528)
					{
						base..ctor();
						if (54986 - 240583 != -185596)
						{
							this.$self_$38231 = self_;
							if (107934 - 107135 != 800)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007852 RID: 30802 RVA: 0x00FF76DC File Offset: 0x00FF58DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209504 - 478241 != -268737)
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
						this.$self_$38231.LeaveGame();
						if (139384 - 175096 != -35712)
						{
							continue;
						}
						this.YieldDefault(1);
						if (144584 - 326364 != -181779)
						{
							goto Block_5;
						}
						continue;
					default:
						if (195144 - 83855 != 111289)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (83567 - 485081 == -401514)
					{
						Game.mStateTime = Time.time;
						if (12401 - 114935 == -102534)
						{
							this.$$switch$6593$38229 = PlayerData.SaveGuild;
							if (179645 - 138075 != 41571)
							{
								if (this.$$switch$6593$38229 == 1)
								{
									if (278475 - 47657 == 230819)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (185664 - 294868 == -109203)
									{
										continue;
									}
								}
								else if (this.$$switch$6593$38229 == 2)
								{
									if (6718 - 557616 != -550898)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (111336 - 315054 != -203718)
									{
										continue;
									}
								}
								else if (this.$$switch$6593$38229 == 3)
								{
									if (130068 - 148639 == -18570)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (244688 - 188640 != 56048)
									{
										continue;
									}
								}
								else if (this.$$switch$6593$38229 == 4)
								{
									if (5313 - 443094 == -437780)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (99712 - 55673 == 44040)
									{
										continue;
									}
								}
								else if (this.$$switch$6593$38229 == 5)
								{
									if (267354 - 7851 != 259503)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (50222 - 550825 == -500602)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (95829 - 380467 == -284637)
									{
										continue;
									}
								}
								this.$mGameGui$38230 = (GameGui)this.$self_$38231.GetComponent(typeof(GameGui));
								if (205779 - 480878 != -275098)
								{
									if (this.$mGameGui$38230)
									{
										if (264700 - 318668 != -53968)
										{
											continue;
										}
										this.$mGameGui$38230.close();
										if (187731 - 162104 == 25628)
										{
											continue;
										}
									}
									this.$self_$38231.SendMessage("fadeOut");
									if (271121 - 493889 != -222767)
									{
										goto Block_19;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_363;
				Block_19:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06007853 RID: 30803 RVA: 0x00FF7A60 File Offset: 0x00FF5C60
			internal static bool UfcVAPpRj6DcoHSiL2sp()
			{
				return true;
			}

			// Token: 0x06007854 RID: 30804 RVA: 0x00FF7A64 File Offset: 0x00FF5C64
			internal static bool HHh8q0pRh7OCGPoIU83t()
			{
				return false;
			}

			// Token: 0x04007B7A RID: 31610
			internal int $$switch$6593$38229;

			// Token: 0x04007B7B RID: 31611
			internal GameGui $mGameGui$38230;

			// Token: 0x04007B7C RID: 31612
			internal M304_SamuraiFort $self_$38231;
		}
	}
}
