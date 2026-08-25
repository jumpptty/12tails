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

// Token: 0x0200189F RID: 6303
[Serializable]
public class M906_ShadowGodZera1 : MonoBehaviour
{
	// Token: 0x0600929D RID: 37533 RVA: 0x01191DBC File Offset: 0x0118FFBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M906_ShadowGodZera1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600929E RID: 37534 RVA: 0x01191DCC File Offset: 0x0118FFCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (135694 - 241941 != -106246)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (145559 - 207064 != -61504)
			{
				Game.mGameType = 5;
				if (141012 - 402142 == -261130)
				{
					if (Chat.Initialized)
					{
						if (212482 - 247249 != -34766)
						{
							Chat.ChatDisplay.Clear();
							if (35223 - 76830 != -41606)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (293911 - 338460 == -44549)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600929F RID: 37535 RVA: 0x01191EB0 File Offset: 0x011900B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (1764 - 361350 != -359585)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (202934 - 392101 == -189167)
				{
					if (Game.mNextGameCode != 906)
					{
						break;
					}
					if (86125 - 432987 != -346861)
					{
						Game.nextGame();
						if (41167 - 359785 != -318617)
						{
							Game.mGameCode = 906;
							if (235800 - 533165 == -297365)
							{
								Game.mGameType = 5;
								if (220238 - 470526 != -250287)
								{
									Game.mGameTime = Time.time;
									if (14506 - 469853 == -455347)
									{
										Game.mGameScore = 0;
										if (81051 - 154635 != -73583)
										{
											Game.mGameMana = 0;
											if (198303 - 440658 != -242354)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (111740 - 170354 != -58613)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (120630 - 545408 == -424778)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (215593 - 189973 == 25620)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (213123 - 474586 != -261462)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (38777 - 295785 == -257008)
																{
																	this.XSFncll0HvE = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (264205 - 281571 != -17365)
																	{
																		this.XfXnc2W8T06 = PhotonClient.Connection;
																		if (203398 - 544407 == -341009)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (226264 - 535877 == -309613)
																			{
																				this.InitGame();
																				if (292290 - 360616 != -68325)
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
				if (118702 - 453209 != -334506)
				{
					Game.mGameType = 99;
					if (109293 - 228207 == -118914)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060092A0 RID: 37536 RVA: 0x011921B8 File Offset: 0x011903B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (17336 - 362448 != -345112)
		{
		}
		for (;;)
		{
			if (this.XfXnc2W8T06 == null)
			{
				if (89425 - 61496 == 27929)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (20289 - 89179 == -68890)
				{
					if (mGameState == eGameState.Init)
					{
						if (42340 - 422277 == -379937)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (23006 - 144014 == -121008)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (4440 - 73788 == -69348)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (265075 - 416585 == -151510)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (208783 - 459479 != -250695)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (104669 - 375934 == -271265)
						{
							if (Game.music != 0)
							{
								if (88614 - 357345 == -268730)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (51124 - 337916 == -286791)
									{
										continue;
									}
									this.audio.Play();
									if (293928 - 495342 != -201414)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (239775 - 440268 == -200492)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (115169 - 270918 != -155749)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (238231 - 339974 == -101742)
								{
									continue;
								}
							}
							if (Time.time > this.sm3ncG6aMaw)
							{
								if (75851 - 522494 == -446642)
								{
									continue;
								}
								Game.mGameMana++;
								if (156054 - 24827 == 131228)
								{
									continue;
								}
								this.sm3ncG6aMaw = Time.time + (float)12;
								if (287532 - 86940 != 200592)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (232700 - 489297 == -256597)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (128717 - 134158 != -5440)
						{
							this.GameEventUpdate();
							if (299814 - 92841 == 206973)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (240183 - 322663 == -82480)
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
						if (246769 - 432233 != -185463)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060092A1 RID: 37537 RVA: 0x0119256C File Offset: 0x0119076C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (242473 - 544452 != -301979)
		{
		}
		while (this.sl4ncvo4s0y)
		{
			if (290717 - 299232 != -8514)
			{
				Vector3 position = this.sl4ncvo4s0y.transform.position;
				if (146361 - 86666 == 59695)
				{
					if (position.y > (float)10)
					{
						break;
					}
					if (21859 - 166296 != -144436)
					{
						GameObject gameObject = GameObject.Find("restartPoint");
						if (280130 - 464201 == -184071)
						{
							GameObject gameObject2 = GameObject.Find("restartCamera");
							if (163504 - 149706 != 13799)
							{
								if (gameObject)
								{
									if (60512 - 320463 != -259951)
									{
										continue;
									}
									this.sl4ncvo4s0y.transform.position = gameObject.transform.position;
									if (224364 - 349918 == -125553)
									{
										continue;
									}
									this.sl4ncvo4s0y.transform.rotation = gameObject.transform.rotation;
									if (197592 - 447462 != -249870)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)this.sl4ncvo4s0y.GetComponent(typeof(CharacterControl));
									if (119281 - 97147 == 22135)
									{
										continue;
									}
									if (characterControl)
									{
										if (93415 - 227508 != -134093)
										{
											continue;
										}
										characterControl.PositionEvent();
										if (40528 - 511526 != -470998)
										{
											continue;
										}
									}
								}
								if (gameObject2)
								{
									if (285766 - 291866 == -6099)
									{
										continue;
									}
									this.transform.position = gameObject2.transform.position;
									if (211250 - 343977 != -132727)
									{
										continue;
									}
									this.transform.rotation = gameObject2.transform.rotation;
									if (81101 - 493620 != -412519)
									{
										continue;
									}
								}
								CameraEffect cameraEffect = (CameraEffect)this.GetComponent(typeof(CameraEffect));
								if (130714 - 329385 != -198670)
								{
									if (!cameraEffect)
									{
										break;
									}
									if (174407 - 405715 == -231308)
									{
										cameraEffect.AddColorRamp("shadowRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.1f, 0.1f));
										if (13162 - 4033 != 9130)
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

	// Token: 0x060092A2 RID: 37538 RVA: 0x01192890 File Offset: 0x01190A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (264318 - 411645 != -147326)
		{
		}
		for (;;)
		{
			if (!this.Lktnc1pBxLX)
			{
				if (222521 - 130712 == 91809)
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
				if (120128 - 487424 == -367296)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (84616 - 144324 == -59708)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (275914 - 13632 != 262283)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (126080 - 43365 == 82715)
							{
								GUI.depth = 1;
								if (219699 - 238543 == -18844)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (64351 - 219196 != -154844)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (136892 - 31264 != 105629)
										{
											Color color = GUI.color;
											if (179526 - 244584 != -65057)
											{
												float num3 = color.a = a;
												if (181343 - 345699 == -164356)
												{
													if (290116 - 364792 != -74675)
													{
														GUI.color = color;
														if (466 - 262660 == -262194)
														{
															if (152369 - 406446 == -254077)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.Lktnc1pBxLX);
																if (192925 - 23805 != 169121)
																{
																	float a2 = 1f;
																	if (87240 - 539138 == -451898)
																	{
																		Color color2 = GUI.color;
																		if (215268 - 270922 == -55654)
																		{
																			float num4 = color2.a = a2;
																			if (70912 - 64342 == 6570)
																			{
																				if (207027 - 347525 == -140498)
																				{
																					Color color3 = GUI.color = color2;
																					if (175967 - 244350 != -68382)
																					{
																						if (22269 - 456982 == -434713)
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

	// Token: 0x060092A3 RID: 37539 RVA: 0x01192C10 File Offset: 0x01190E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M906_ShadowGodZera1.$onGameEvent$41636(data, this).GetEnumerator();
	}

	// Token: 0x060092A4 RID: 37540 RVA: 0x01192C20 File Offset: 0x01190E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M906_ShadowGodZera1.$onGameComplete$41652(data, this).GetEnumerator();
	}

	// Token: 0x060092A5 RID: 37541 RVA: 0x01192C30 File Offset: 0x01190E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseShadowPortal(int mVar)
	{
		return new M906_ShadowGodZera1.$UseShadowPortal$41662(mVar, this).GetEnumerator();
	}

	// Token: 0x060092A6 RID: 37542 RVA: 0x01192C40 File Offset: 0x01190E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (140676 - 251709 != -111033)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (230303 - 536259 == -305956)
			{
				Time.timeScale = 1f;
				if (180404 - 246608 == -66204)
				{
					this.Lktnc1pBxLX = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (275050 - 594571 == -319521)
					{
						Hashtable customOpParameters = new Hashtable();
						if (23268 - 200955 != -177686)
						{
							this.XfXnc2W8T06.OpCustom(52, customOpParameters, true);
							if (248589 - 72057 == 176532)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060092A7 RID: 37543 RVA: 0x01192D44 File Offset: 0x01190F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (61612 - 359915 != -298302)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (103274 - 576735 != -473460)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (45225 - 286072 == -240847)
				{
					Game.mGameState = eGameState.Setup;
					if (159659 - 44006 != 115654)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060092A8 RID: 37544 RVA: 0x01192DE8 File Offset: 0x01190FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (238674 - 577573 != -338898)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (47932 - 436446 != -388513)
			{
				if (num == PlayerData.UID)
				{
					if (27368 - 19494 != 7875)
					{
						this.SetupActors();
						if (193542 - 239304 != -45761)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (220442 - 209565 == 10877)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060092A9 RID: 37545 RVA: 0x01192EB8 File Offset: 0x011910B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (71284 - 40704 != 30580)
		{
		}
		for (;;)
		{
			IL_125:
			Debug.Log("Creating Actors");
			if (33743 - 308114 == -274371)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (165611 - 476283 != -310671)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (36190 - 3429 == 32761)
						{
							int i = 0;
							if (258716 - 481890 != -223173)
							{
								CharacterControl[] array2 = array;
								if (287462 - 7991 != 279472)
								{
									int length = array2.Length;
									if (150517 - 70256 != 80262)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (169156 - 356719 == -187562)
												{
													goto IL_125;
												}
												string type = array2[i].Type;
												if (281123 - 434954 == -153830)
												{
													goto IL_125;
												}
												if (type == "FakeShadowGod")
												{
													goto IL_253;
												}
												if (96535 - 372319 != -275784)
												{
													goto IL_125;
												}
												if (type == "Shade2")
												{
													goto IL_253;
												}
												if (83056 - 40981 != 42075)
												{
													goto IL_125;
												}
												if (type == "ShadowCrystal")
												{
													if (267328 - 217686 != 49643)
													{
														goto IL_253;
													}
													goto IL_125;
												}
												IL_153:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (138297 - 103183 != 35114)
												{
													goto IL_125;
												}
												this.SgbncdWFFcH++;
												if (144947 - 41904 != 103043)
												{
													goto IL_125;
												}
												goto IL_3C;
												IL_253:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (268468 - 579254 != -310786)
												{
													goto IL_125;
												}
												goto IL_153;
											}
											IL_3C:
											i++;
											if (262884 - 56265 == 206620)
											{
												goto IL_125;
											}
										}
										if (33846 - 232989 != -199142)
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
						if (279912 - 590806 != -310893)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060092AA RID: 37546 RVA: 0x011931A8 File Offset: 0x011913A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (124331 - 319107 != -194775)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (60160 - 367063 != -306902)
			{
				int i = 0;
				if (114171 - 529939 != -415767)
				{
					CharacterControl[] array2 = array;
					if (68400 - 117872 == -49472)
					{
						int length = array2.Length;
						if (56939 - 584762 != -527822)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (126155 - 559851 != -433696)
								{
									goto IL_E0;
								}
								i++;
								if (73576 - 256313 != -182737)
								{
									goto IL_E0;
								}
							}
							if (258303 - 402764 != -144460)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060092AB RID: 37547 RVA: 0x011932D8 File Offset: 0x011914D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (203047 - 944 != 202104)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (106188 - 499731 == -393543)
			{
				Game.mGameState = eGameState.Ready;
				if (37565 - 346711 == -309146)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (83303 - 49894 == 33409)
					{
						if (67721 - 488901 == -421180)
						{
							GameObject gameObject = null;
							if (265403 - 324464 == -59061)
							{
								if (playerSlot < 1)
								{
									goto IL_21E;
								}
								if (226992 - 564685 != -337693)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_21E;
								}
								if (283862 - 401387 != -117525)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (97405 - 273351 == -175945)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (213645 - 39975 != 173670)
								{
									continue;
								}
								IL_119:
								if (gameObject2)
								{
									if (78264 - 267185 != -188921)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (100163 - 221892 == -121728)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (152932 - 74255 != 78677)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (225535 - 167673 == 57863)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (23359 - 287473 == -264113)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (96806 - 130217 == -33410)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (293384 - 275075 == 18310)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (190976 - 337451 != -146474)
								{
									break;
								}
								continue;
								IL_21E:
								gameObject2 = GameObject.Find("StartPoint1");
								if (98347 - 356416 != -258068)
								{
									goto IL_119;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060092AC RID: 37548 RVA: 0x011935FC File Offset: 0x011917FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M906_ShadowGodZera1.$StartGame$41674(this).GetEnumerator();
	}

	// Token: 0x060092AD RID: 37549 RVA: 0x0119360C File Offset: 0x0119180C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060092AE RID: 37550 RVA: 0x01193610 File Offset: 0x01191810
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (217397 - 29910 != 187488)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (17679 - 408675 == -390996)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (23566 - 398763 == -375197)
				{
					hashtable.Add(43, PlayerData.UID);
					if (76072 - 423893 == -347821)
					{
						hashtable.Add(73, nType);
						if (86531 - 210193 != -123661)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (205144 - 222365 != -17220)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (105926 - 315305 != -209378)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (174064 - 491200 == -317136)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (49841 - 581622 != -531780)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (5539 - 258364 == -252825)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (292753 - 106253 == 186500)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (113666 - 73490 == 40176)
													{
														this.XfXnc2W8T06.OpCustom(63, hashtable, true);
														if (127979 - 585123 == -457144)
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

	// Token: 0x060092AF RID: 37551 RVA: 0x011938F4 File Offset: 0x01191AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (260 - 153805 != -153544)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (161450 - 184882 != -23431)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (3894 - 375859 == -371965)
				{
					object obj2;
					object obj = obj2 = data[73];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (147559 - 545112 == -397553)
					{
						string a = text;
						if (211695 - 372222 == -160527)
						{
							if (a == "Shade2")
							{
								if (213419 - 109633 != 103786)
								{
									continue;
								}
								if (gameObject)
								{
									if (230538 - 304184 == -73645)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (64915 - 144138 != -79223)
									{
										continue;
									}
									if (characterControl)
									{
										if (46840 - 133423 != -86583)
										{
											continue;
										}
										characterControl.recieveGravity = false;
										if (292756 - 62464 != 230292)
										{
											continue;
										}
									}
								}
							}
							if (Game.mGameState == eGameState.Setup)
							{
								if (166957 - 586090 != -419132)
								{
									if (this.SgbncdWFFcH <= 0)
									{
										break;
									}
									if (242540 - 305207 == -62667)
									{
										this.SgbncdWFFcH--;
										if (7045 - 281153 == -274108)
										{
											if (this.SgbncdWFFcH != 0)
											{
												break;
											}
											if (166535 - 341292 != -174756)
											{
												Game.setGameState(eGameState.Ready);
												if (223179 - 494974 != -271794)
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
								if (208230 - 369260 == -161030)
								{
									gameObject.SendMessage("createSpecialEffect", 1);
									if (44835 - 42741 == 2094)
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

	// Token: 0x060092B0 RID: 37552 RVA: 0x01193BB4 File Offset: 0x01191DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060092B1 RID: 37553 RVA: 0x01193BC8 File Offset: 0x01191DC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (6742 - 405808 != -399065)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (137066 - 278735 != -141668)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (59446 - 568329 == -508883)
				{
					if (!characterControl)
					{
						break;
					}
					if (229707 - 86074 == 143633)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (123971 - 333409 != -209437)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (106321 - 291445 != -185123)
							{
								string type = characterControl.Type;
								if (64672 - 442113 == -377441)
								{
									if (!(type == "ShadowCrystal"))
									{
										break;
									}
									if (173618 - 517128 != -343509)
									{
										Game.sendMissionEvent(9062, 1);
										if (44869 - 335947 != -291077)
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

	// Token: 0x060092B2 RID: 37554 RVA: 0x01193D40 File Offset: 0x01191F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (284099 - 318761 != -34662)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (35203 - 371826 == -336623)
			{
				hashtable.Add(71, CID);
				if (222752 - 568104 != -345351)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (53864 - 139737 != -85872)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (228980 - 210332 == 18648)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (130631 - 303970 == -173339)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (255369 - 263719 != -8349)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (293032 - 271179 != 21854)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (182889 - 20405 != 162485)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (267820 - 598326 == -330506)
											{
												this.XfXnc2W8T06.OpCustom(61, hashtable, true);
												if (153997 - 128772 != 25226)
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

	// Token: 0x060092B3 RID: 37555 RVA: 0x01193FCC File Offset: 0x011921CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (97742 - 53074 != 44668)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (117028 - 268944 == -151916)
			{
				if (!gameObject)
				{
					break;
				}
				if (144820 - 564924 != -420103)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (225750 - 56768 != 168983)
					{
						playerCameraControl.target = gameObject;
						if (135478 - 406344 == -270866)
						{
							this.sl4ncvo4s0y = gameObject;
							if (139984 - 510602 != -370617)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (182403 - 178775 == 3628)
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

	// Token: 0x060092B4 RID: 37556 RVA: 0x011940E4 File Offset: 0x011922E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (146493 - 9216 != 137277)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (244919 - 380275 == -135356)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (33115 - 131148 == -98033)
				{
					gameGui.ResetTeamBar();
					if (59825 - 146415 == -86590)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060092B5 RID: 37557 RVA: 0x01194190 File Offset: 0x01192390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M906_ShadowGodZera1.$onDeadPlayer$41682(this).GetEnumerator();
	}

	// Token: 0x060092B6 RID: 37558 RVA: 0x011941A0 File Offset: 0x011923A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (240660 - 374580 != -133919)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (288985 - 496763 != -207777)
			{
				this.XSFncll0HvE.target = Game.mPlayer;
				if (26178 - 109220 == -83042)
				{
					this.XSFncll0HvE.enabled = true;
					if (66122 - 363910 != -297787)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (202097 - 567014 == -364916)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (107128 - 191222 == -84093)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (210097 - 443175 == -233078)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (297513 - 29634 != 267880)
							{
								if (!gameGui)
								{
									break;
								}
								if (184132 - 240139 != -56006)
								{
									gameGui.enabled = true;
									if (30054 - 317345 != -287290)
									{
										gameGui.closeDeadMenu();
										if (154074 - 426862 != -272787)
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

	// Token: 0x060092B7 RID: 37559 RVA: 0x0119434C File Offset: 0x0119254C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (88325 - 115403 != -27077)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (205807 - 46752 != 159056)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (91601 - 61562 == 30039)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (278512 - 578668 == -300156)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060092B8 RID: 37560 RVA: 0x01194410 File Offset: 0x01192610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060092B9 RID: 37561 RVA: 0x0119443C File Offset: 0x0119263C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (90729 - 340190 != -249460)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (284649 - 521419 == -236770)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (252683 - 39975 != 212709)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (83832 - 250409 != -166576)
					{
						Hashtable hashtable = new Hashtable();
						if (120654 - 255932 != -135277)
						{
							hashtable.Add(43, PlayerData.UID);
							if (277477 - 79357 == 198120)
							{
								hashtable.Add(71, nCID);
								if (37355 - 482248 == -444893)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (100925 - 177523 != -76597)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (33238 - 412958 == -379720)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (34289 - 546769 != -512479)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (214524 - 441432 == -226908)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (189264 - 252808 != -63543)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (87965 - 542035 != -454069)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (705 - 472174 != -471468)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (56585 - 527951 != -471365)
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

	// Token: 0x060092BA RID: 37562 RVA: 0x0119475C File Offset: 0x0119295C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M906_ShadowGodZera1.$onChangePlayer$41688(data, this).GetEnumerator();
	}

	// Token: 0x060092BB RID: 37563 RVA: 0x0119476C File Offset: 0x0119296C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M906_ShadowGodZera1.$ReturnToTown$41695(this).GetEnumerator();
	}

	// Token: 0x060092BC RID: 37564 RVA: 0x0119477C File Offset: 0x0119297C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M906_ShadowGodZera1.$ReturnToGuild$41700(this).GetEnumerator();
	}

	// Token: 0x060092BD RID: 37565 RVA: 0x0119478C File Offset: 0x0119298C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M906_ShadowGodZera1.$ReturnToCamp$41704(this).GetEnumerator();
	}

	// Token: 0x060092BE RID: 37566 RVA: 0x0119479C File Offset: 0x0119299C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (280932 - 354277 != -73344)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (154481 - 435776 != -281294)
			{
				Hashtable hashtable = new Hashtable();
				if (134752 - 240753 != -106000)
				{
					hashtable.Add(43, PlayerData.UID);
					if (177611 - 30518 == 147093)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (278152 - 11972 == 266180)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060092BF RID: 37567 RVA: 0x01194874 File Offset: 0x01192A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060092C0 RID: 37568 RVA: 0x01194888 File Offset: 0x01192A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (27720 - 541566 != -513845)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (120485 - 180461 == -59976)
			{
				Hashtable hashtable = new Hashtable();
				if (133442 - 344171 != -210728)
				{
					if (Game.mNextGameCode == 30)
					{
						if (250619 - 217473 == 33147)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (34612 - 103725 == -69112)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (129484 - 135291 == -5806)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (101130 - 474461 == -373330)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (277839 - 512601 == -234761)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (265241 - 435878 == -170636)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (148710 - 102745 != 45965)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (230131 - 319523 == -89391)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (129676 - 383595 == -253918)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (158827 - 400692 != -241865)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (185593 - 215530 == -29936)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (33191 - 285115 == -251923)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (104645 - 492746 != -388101)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (41606 - 64541 != -22935)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (203611 - 316202 == -112590)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (34682 - 182747 != -148065)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (171398 - 179300 != -7902)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (62102 - 426253 != -364151)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (57682 - 579477 != -521795)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (130021 - 357452 != -227431)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (56882 - 456725 != -399843)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (230680 - 388658 == -157977)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (250794 - 497868 != -247074)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (4878 - 461936 != -457058)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (265742 - 393788 == -128045)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (79764 - 312780 != -233016)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (284272 - 116882 == 167391)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (102618 - 10936 == 91683)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (118058 - 435102 == -317044)
					{
						this.XfXnc2W8T06.OpCustom(42, hashtable, true);
						if (32073 - 335421 == -303348)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060092C1 RID: 37569 RVA: 0x01194E3C File Offset: 0x0119303C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060092C2 RID: 37570 RVA: 0x01194E4C File Offset: 0x0119304C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060092C3 RID: 37571 RVA: 0x01194E50 File Offset: 0x01193050
	internal static bool Xgq5g2VAyVaBUfvnyDDy()
	{
		return true;
	}

	// Token: 0x060092C4 RID: 37572 RVA: 0x01194E54 File Offset: 0x01193054
	internal static bool Bpo8tlVASre56COtkwy6()
	{
		return false;
	}

	// Token: 0x04008A12 RID: 35346
	private LitePeer XfXnc2W8T06;

	// Token: 0x04008A13 RID: 35347
	private GameObject sl4ncvo4s0y;

	// Token: 0x04008A14 RID: 35348
	private PlayerCameraControl XSFncll0HvE;

	// Token: 0x04008A15 RID: 35349
	private float sm3ncG6aMaw;

	// Token: 0x04008A16 RID: 35350
	private Texture Lktnc1pBxLX;

	// Token: 0x04008A17 RID: 35351
	private int jrQncqgBEqf;

	// Token: 0x04008A18 RID: 35352
	private int FMOncpyYqsJ;

	// Token: 0x04008A19 RID: 35353
	private GameObject nYVncRlYwId;

	// Token: 0x04008A1A RID: 35354
	private GameObject fZsncru9vCw;

	// Token: 0x04008A1B RID: 35355
	private GameObject BrfncxhZA7K;

	// Token: 0x04008A1C RID: 35356
	private GameObject maFncTASTrG;

	// Token: 0x04008A1D RID: 35357
	private GameObject j46ncYOShoB;

	// Token: 0x04008A1E RID: 35358
	private GameObject Ytxnc3cgB3U;

	// Token: 0x04008A1F RID: 35359
	private GameObject oobncbFdxdU;

	// Token: 0x04008A20 RID: 35360
	public AudioClip shadowMirrorFx;

	// Token: 0x04008A21 RID: 35361
	private int SgbncdWFFcH;

	// Token: 0x020018A0 RID: 6304
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$41636 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060092C5 RID: 37573 RVA: 0x01194E58 File Offset: 0x01193058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$41636(Hashtable data, M906_ShadowGodZera1 self_)
		{
			if (119935 - 435311 != -315375)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56676 - 347029 == -290353)
				{
					base..ctor();
					if (50248 - 568908 == -518660)
					{
						this.$data$41650 = data;
						if (180109 - 436370 == -256261)
						{
							this.$self_$41651 = self_;
							if (11543 - 69105 == -57562)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x01194F14 File Offset: 0x01193114
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$onGameEvent$41636.$(this.$data$41650, this.$self_$41651);
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x01194F28 File Offset: 0x01193128
		internal static bool qZAfCZVAoYk4iN3RmRht()
		{
			return true;
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x01194F2C File Offset: 0x0119312C
		internal static bool nUdjI2VAEYFQ4PKcyl0O()
		{
			return false;
		}

		// Token: 0x04008A22 RID: 35362
		internal Hashtable $data$41650;

		// Token: 0x04008A23 RID: 35363
		internal M906_ShadowGodZera1 $self_$41651;

		// Token: 0x020018A1 RID: 6305
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060092C9 RID: 37577 RVA: 0x01194F30 File Offset: 0x01193130
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M906_ShadowGodZera1 self_)
			{
				if (98409 - 123470 != -25060)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174906 - 22225 != 152682)
					{
						base..ctor();
						if (292762 - 252398 != 40365)
						{
							this.$data$41648 = data;
							if (95080 - 148525 == -53445)
							{
								this.$self_$41649 = self_;
								if (221404 - 582383 == -360979)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060092CA RID: 37578 RVA: 0x01194FEC File Offset: 0x011931EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46903 - 272407 != -225503)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B91;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (289135 - 470893 != -181757)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							this.$mEventCamera1$41642 = GameObject.Find("EventCamera1");
							if (96501 - 266901 != -170400)
							{
								continue;
							}
							if (!this.$mEventCamera1$41642)
							{
								goto IL_4E1;
							}
							if (278888 - 283213 != -4325)
							{
								continue;
							}
							this.$self_$41649.XSFncll0HvE.setSpecialTarget(this.$mEventCamera1$41642, 2f);
							if (22266 - 71464 != -49197)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (245332 - 452431 != -207099)
							{
								continue;
							}
							goto IL_1CF;
						}
						else
						{
							Game.savePlayer();
							if (49914 - 123470 == -73555)
							{
								continue;
							}
							this.$self_$41649.SendMessage("fadeOut");
							if (124894 - 301621 != -176727)
							{
								continue;
							}
							goto IL_4AB;
						}
						break;
					case 4:
						Game.mGameStage = 2;
						if (112950 - 355960 != -243010)
						{
							continue;
						}
						Application.LoadLevel("M906_ShadowGodZera2");
						if (183362 - 547233 != -363871)
						{
							continue;
						}
						goto IL_56B;
					default:
						if (54840 - 130958 == -76117)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (13956 - 159892 != -145936)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$41637 = RuntimeServices.UnboxInt32(this.$data$41648[141]);
						if (163029 - 465892 == -302862)
						{
							continue;
						}
						this.$returnValue$41638 = RuntimeServices.UnboxInt32(this.$data$41648[145]);
						if (148639 - 17725 == 130915)
						{
							continue;
						}
						this.$ownerID$41639 = RuntimeServices.UnboxInt32(this.$data$41648[43]);
						if (177328 - 220039 != -42711)
						{
							continue;
						}
						this.$$switch$7508$41640 = this.$returnCode$41637;
						if (193814 - 442676 != -248862)
						{
							continue;
						}
						if (this.$$switch$7508$41640 == 9061)
						{
							if (270816 - 206371 != 64445)
							{
								continue;
							}
						}
						else if (this.$$switch$7508$41640 == -9061)
						{
							if (259208 - 594342 != -335134)
							{
								continue;
							}
							if (this.$self_$41649.jrQncqgBEqf < 7)
							{
								if (124558 - 115039 != 9519)
								{
									continue;
								}
								this.$self_$41649.jrQncqgBEqf = 7;
								if (289408 - 478827 == -189418)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (67969 - 293144 == -225174)
								{
									continue;
								}
								this.$mGameGui$41641 = (GameGui)this.$self_$41649.GetComponent(typeof(GameGui));
								if (120223 - 219918 != -99695)
								{
									continue;
								}
								this.$mGameGui$41641.close();
								if (128514 - 419112 != -290598)
								{
									continue;
								}
								goto IL_971;
							}
						}
						else if (this.$$switch$7508$41640 == 9062)
						{
							if (259087 - 302694 == -43606)
							{
								continue;
							}
							this.$self_$41649.FMOncpyYqsJ = this.$self_$41649.FMOncpyYqsJ + 1;
							if (72677 - 204947 != -132270)
							{
								continue;
							}
							this.$self_$41649.jrQncqgBEqf = this.$self_$41649.FMOncpyYqsJ;
							if (66681 - 80640 != -13959)
							{
								continue;
							}
							this.$self_$41649.SendMessage("newGameMessage", "Shadow Crystal Destroyed:" + this.$self_$41649.FMOncpyYqsJ + "/5");
							if (81466 - 174043 != -92577)
							{
								continue;
							}
							Chat.SubmitChat("none", "Shadow Crystal Destroyed:" + this.$self_$41649.FMOncpyYqsJ + "/5", eChatType.system, eChatMode.system);
							if (277560 - 332008 == -54447)
							{
								continue;
							}
							this.$$switch$7506$41643 = this.$self_$41649.FMOncpyYqsJ;
							if (250274 - 576564 != -326290)
							{
								continue;
							}
							if (this.$$switch$7506$41643 == 2)
							{
								if (150685 - 522242 == -371556)
								{
									continue;
								}
								if (this.$self_$41649.nYVncRlYwId)
								{
									if (181554 - 428656 == -247101)
									{
										continue;
									}
									this.$self_$41649.nYVncRlYwId.renderer.enabled = true;
									if (292998 - 19364 != 273634)
									{
										continue;
									}
									this.$self_$41649.nYVncRlYwId.collider.isTrigger = false;
									if (79557 - 325075 != -245518)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7506$41643 == 3)
							{
								if (16122 - 196263 != -180141)
								{
									continue;
								}
								if (this.$self_$41649.Ytxnc3cgB3U)
								{
									if (175192 - 321206 == -146013)
									{
										continue;
									}
									this.$$14558$41644 = this.$self_$41649.Ytxnc3cgB3U.transform.position.y + (float)300;
									if (41615 - 178362 == -136746)
									{
										continue;
									}
									if (252529 - 557275 != -304746)
									{
										continue;
									}
									Vector3 vector = this.$$14559$41645 = this.$self_$41649.Ytxnc3cgB3U.transform.position;
									if (61943 - 43535 == 18409)
									{
										continue;
									}
									if (97246 - 435514 != -338268)
									{
										continue;
									}
									this.$$14559$41645.y = this.$$14558$41644;
									if (71771 - 421243 == -349471)
									{
										continue;
									}
									if (269871 - 110025 != 159846)
									{
										continue;
									}
									Vector3 vector2 = this.$self_$41649.Ytxnc3cgB3U.transform.position = this.$$14559$41645;
									if (226945 - 275220 == -48274)
									{
										continue;
									}
									if (60528 - 437667 != -377139)
									{
										continue;
									}
								}
								if (this.$self_$41649.fZsncru9vCw)
								{
									if (263245 - 540339 != -277094)
									{
										continue;
									}
									this.$self_$41649.fZsncru9vCw.renderer.enabled = true;
									if (126771 - 361597 != -234826)
									{
										continue;
									}
									this.$self_$41649.fZsncru9vCw.collider.isTrigger = false;
									if (63314 - 129251 == -65936)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7506$41643 == 4)
							{
								if (108839 - 191267 != -82428)
								{
									continue;
								}
								if (this.$self_$41649.BrfncxhZA7K)
								{
									if (78151 - 66262 == 11890)
									{
										continue;
									}
									this.$self_$41649.BrfncxhZA7K.renderer.enabled = true;
									if (81309 - 310513 != -229204)
									{
										continue;
									}
									this.$self_$41649.BrfncxhZA7K.collider.isTrigger = false;
									if (118451 - 118319 != 132)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7506$41643 == 5)
							{
								if (83478 - 306676 == -223197)
								{
									continue;
								}
								if (this.$self_$41649.oobncbFdxdU)
								{
									if (78080 - 539033 == -460952)
									{
										continue;
									}
									this.$$14560$41646 = this.$self_$41649.oobncbFdxdU.transform.position.y + (float)300;
									if (186841 - 512410 != -325569)
									{
										continue;
									}
									if (194274 - 438434 != -244160)
									{
										continue;
									}
									this.$$14561$41647 = this.$self_$41649.oobncbFdxdU.transform.position;
									if (133795 - 546642 == -412846)
									{
										continue;
									}
									if (20222 - 142910 != -122688)
									{
										continue;
									}
									this.$$14561$41647.y = this.$$14560$41646;
									if (256003 - 465475 == -209471 || 69351 - 166703 == -97351)
									{
										continue;
									}
									this.$self_$41649.oobncbFdxdU.transform.position = this.$$14561$41647;
									if (144800 - 116317 == 28484 || 294573 - 3624 == 290950)
									{
										continue;
									}
								}
								if (this.$self_$41649.maFncTASTrG)
								{
									if (275070 - 535667 == -260596)
									{
										continue;
									}
									this.$self_$41649.maFncTASTrG.renderer.enabled = true;
									if (2481 - 92399 != -89918)
									{
										continue;
									}
									this.$self_$41649.maFncTASTrG.collider.isTrigger = false;
									if (9320 - 576534 != -567214)
									{
										continue;
									}
								}
							}
						}
					}
					IL_AB4:
					this.YieldDefault(1);
					if (154392 - 88258 != 66134)
					{
						continue;
					}
					break;
					IL_56B:
					goto IL_AB4;
				}
				IL_1CF:
				goto IL_B91;
				IL_4AB:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_4E1:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_52:
				goto IL_4E1;
				goto IL_B91;
				IL_971:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_69:
				IL_B91:
				return false;
			}

			// Token: 0x060092CB RID: 37579 RVA: 0x01195B9C File Offset: 0x01193D9C
			internal static bool huLYUmVA25QvuBo4Z9DC()
			{
				return true;
			}

			// Token: 0x060092CC RID: 37580 RVA: 0x01195BA0 File Offset: 0x01193DA0
			internal static bool TZg24cVA8MA8V0cvlbn0()
			{
				return false;
			}

			// Token: 0x04008A24 RID: 35364
			internal int $returnCode$41637;

			// Token: 0x04008A25 RID: 35365
			internal int $returnValue$41638;

			// Token: 0x04008A26 RID: 35366
			internal int $ownerID$41639;

			// Token: 0x04008A27 RID: 35367
			internal int $$switch$7508$41640;

			// Token: 0x04008A28 RID: 35368
			internal GameGui $mGameGui$41641;

			// Token: 0x04008A29 RID: 35369
			internal GameObject $mEventCamera1$41642;

			// Token: 0x04008A2A RID: 35370
			internal int $$switch$7506$41643;

			// Token: 0x04008A2B RID: 35371
			internal float $$14558$41644;

			// Token: 0x04008A2C RID: 35372
			internal Vector3 $$14559$41645;

			// Token: 0x04008A2D RID: 35373
			internal float $$14560$41646;

			// Token: 0x04008A2E RID: 35374
			internal Vector3 $$14561$41647;

			// Token: 0x04008A2F RID: 35375
			internal Hashtable $data$41648;

			// Token: 0x04008A30 RID: 35376
			internal M906_ShadowGodZera1 $self_$41649;
		}
	}

	// Token: 0x020018A2 RID: 6306
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41652 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060092CD RID: 37581 RVA: 0x01195BA4 File Offset: 0x01193DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41652(Hashtable data, M906_ShadowGodZera1 self_)
		{
			if (154311 - 287086 != -132775)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205580 - 157766 != 47815)
				{
					base..ctor();
					if (221705 - 297334 == -75629)
					{
						this.$data$41660 = data;
						if (255836 - 537630 == -281794)
						{
							this.$self_$41661 = self_;
							if (115754 - 139922 != -24167)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x01195C60 File Offset: 0x01193E60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$onGameComplete$41652.$(this.$data$41660, this.$self_$41661);
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x01195C74 File Offset: 0x01193E74
		internal static bool t5C6ncVAZffCPjcd4wrc()
		{
			return true;
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x01195C78 File Offset: 0x01193E78
		internal static bool XBc68fVACHkkemnbTJHV()
		{
			return false;
		}

		// Token: 0x04008A31 RID: 35377
		internal Hashtable $data$41660;

		// Token: 0x04008A32 RID: 35378
		internal M906_ShadowGodZera1 $self_$41661;

		// Token: 0x020018A3 RID: 6307
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060092D1 RID: 37585 RVA: 0x01195C7C File Offset: 0x01193E7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M906_ShadowGodZera1 self_)
			{
				if (180923 - 33692 != 147231)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14333 - 330001 == -315668)
					{
						base..ctor();
						if (249257 - 7539 == 241718)
						{
							this.$data$41658 = data;
							if (200547 - 543070 == -342523)
							{
								this.$self_$41659 = self_;
								if (4284 - 433511 != -429226)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060092D2 RID: 37586 RVA: 0x01195D38 File Offset: 0x01193F38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74318 - 234865 != -160546)
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
						this.$mCompleteGui$41654 = (CompleteGui)this.$self_$41659.GetComponent(typeof(CompleteGui));
						if (235248 - 295202 == -59953)
						{
							continue;
						}
						this.$mCompleteGui$41654.Init();
						if (154954 - 437576 != -282622)
						{
							continue;
						}
						this.$mCompleteGui$41654.readData(this.$data$41658);
						if (227764 - 350305 == -122540)
						{
							continue;
						}
						if (this.$result$41653 == 1)
						{
							if (109788 - 297239 != -187451)
							{
								continue;
							}
							this.$mCompleteGui$41654.displayResult(eCompleteType.Success);
							if (74867 - 71077 == 3791)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41654.displayResult(eCompleteType.Failed);
							if (162154 - 382492 != -220338)
							{
								continue;
							}
						}
						this.$mGameGui$41655 = (GameGui)this.$self_$41659.GetComponent(typeof(GameGui));
						if (99119 - 91587 == 7533)
						{
							continue;
						}
						this.$mStoryGui$41656 = (StoryGui)this.$self_$41659.GetComponent(typeof(StoryGui));
						if (114192 - 342845 == -228652)
						{
							continue;
						}
						this.$mChangeGui$41657 = (ChangeGui)this.$self_$41659.GetComponent(typeof(ChangeGui));
						if (237150 - 89185 == 147966)
						{
							continue;
						}
						if (this.$mGameGui$41655)
						{
							if (230000 - 593363 != -363363)
							{
								continue;
							}
							this.$mGameGui$41655.close();
							if (178284 - 297669 != -119385)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41656)
						{
							if (206961 - 149412 != 57549)
							{
								continue;
							}
							this.$mStoryGui$41656.close();
							if (80007 - 111086 == -31078)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41657)
						{
							if (46270 - 179142 != -132872)
							{
								continue;
							}
							this.$mChangeGui$41657.disable();
							if (215585 - 184358 == 31228)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (160664 - 310342 != -149677)
						{
							goto Block_16;
						}
						continue;
					default:
						if (275857 - 330980 != -55123)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41658[31]);
					if (147370 - 435662 != -288291)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (96236 - 87428 == 8808)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (170320 - 135909 == 34411)
							{
								this.$result$41653 = RuntimeServices.UnboxInt32(this.$data$41658[31]);
								if (278370 - 460554 != -182183)
								{
									goto Block_26;
								}
							}
						}
					}
				}
				Block_16:
				goto IL_3DB;
				Block_26:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x060092D3 RID: 37587 RVA: 0x01196134 File Offset: 0x01194334
			internal static bool G3eJgWVALL7G8yncwlDC()
			{
				return true;
			}

			// Token: 0x060092D4 RID: 37588 RVA: 0x01196138 File Offset: 0x01194338
			internal static bool JmUWj1VAOF5PrsUZ6k72()
			{
				return false;
			}

			// Token: 0x04008A33 RID: 35379
			internal int $result$41653;

			// Token: 0x04008A34 RID: 35380
			internal CompleteGui $mCompleteGui$41654;

			// Token: 0x04008A35 RID: 35381
			internal GameGui $mGameGui$41655;

			// Token: 0x04008A36 RID: 35382
			internal StoryGui $mStoryGui$41656;

			// Token: 0x04008A37 RID: 35383
			internal ChangeGui $mChangeGui$41657;

			// Token: 0x04008A38 RID: 35384
			internal Hashtable $data$41658;

			// Token: 0x04008A39 RID: 35385
			internal M906_ShadowGodZera1 $self_$41659;
		}
	}

	// Token: 0x020018A4 RID: 6308
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseShadowPortal$41662 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060092D5 RID: 37589 RVA: 0x0119613C File Offset: 0x0119433C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseShadowPortal$41662(int mVar, M906_ShadowGodZera1 self_)
		{
			if (210126 - 102714 != 107413)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (207340 - 280629 == -73289)
				{
					base..ctor();
					if (68225 - 589930 == -521705)
					{
						this.$mVar$41672 = mVar;
						if (144748 - 303292 != -158543)
						{
							this.$self_$41673 = self_;
							if (41692 - 298993 == -257301)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x011961F8 File Offset: 0x011943F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$UseShadowPortal$41662.$(this.$mVar$41672, this.$self_$41673);
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x0119620C File Offset: 0x0119440C
		internal static bool eP1PnXVAmyEyAmFKFU04()
		{
			return true;
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x01196210 File Offset: 0x01194410
		internal static bool MqDpZ3VAFWtQHvT8Y3tT()
		{
			return false;
		}

		// Token: 0x04008A3A RID: 35386
		internal int $mVar$41672;

		// Token: 0x04008A3B RID: 35387
		internal M906_ShadowGodZera1 $self_$41673;

		// Token: 0x020018A5 RID: 6309
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060092D9 RID: 37593 RVA: 0x01196214 File Offset: 0x01194414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int mVar, M906_ShadowGodZera1 self_)
			{
				if (80567 - 420545 != -339978)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56611 - 276675 == -220064)
					{
						base..ctor();
						if (275492 - 405051 == -129559)
						{
							this.$mVar$41670 = mVar;
							if (264132 - 432572 == -168440)
							{
								this.$self_$41671 = self_;
								if (167106 - 177528 == -10422)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060092DA RID: 37594 RVA: 0x011962D0 File Offset: 0x011944D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43167 - 173149 != -129982)
				{
				}
				for (;;)
				{
					IL_129:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_85C;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (114836 - 54351 != 60486)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							if (this.$self_$41671.shadowMirrorFx)
							{
								if (165767 - 73997 != 91770)
								{
									continue;
								}
								this.$self_$41671.audio.PlayOneShot(this.$self_$41671.shadowMirrorFx);
								if (9470 - 92487 != -83017)
								{
									continue;
								}
							}
							this.$mCameraEffect$41664 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (97594 - 590877 != -493283)
							{
								continue;
							}
							if (!this.$mCameraEffect$41664)
							{
								goto IL_335;
							}
							if (53265 - 153493 == -100227)
							{
								continue;
							}
							this.$mCameraEffect$41664.AddColorRamp("shadowRamp", "none", (float)10, new Vector4(0.1f, 0.1f, 0.1f, (float)0));
							if (80003 - 577473 != -497469)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (41881 - 153015 != -111133)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$warpList$41665 = Damage.FindAreaTarget(Game.mPlayer.transform.position, (float)40, (float)12, 1 << Game.mPlayer.layer);
							if (261541 - 48730 != 212811)
							{
								continue;
							}
							this.$$iterator$10961$41669 = UnityRuntimeServices.GetEnumerator(this.$warpList$41665);
							if (90843 - 539418 == -448574)
							{
								continue;
							}
							while (this.$$iterator$10961$41669.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10961$41669.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$warpObject$41666 = (GameObject)obj2;
								if (28888 - 268674 != -239786)
								{
									goto IL_129;
								}
								this.$warpChar$41667 = (CharacterControl)this.$warpObject$41666.GetComponent(typeof(CharacterControl));
								if (216819 - 355353 != -138534)
								{
									goto IL_129;
								}
								UnityRuntimeServices.Update(this.$$iterator$10961$41669, this.$warpObject$41666);
								if (224128 - 75132 != 148996)
								{
									goto IL_129;
								}
								if (!(this.$warpObject$41666 == Game.mPlayer))
								{
									if (268612 - 201661 == 66952)
									{
										goto IL_129;
									}
									if (!this.$warpChar$41667.isMine)
									{
										continue;
									}
									if (26420 - 176726 == -150305)
									{
										goto IL_129;
									}
									if (!this.$warpChar$41667.isSummon)
									{
										continue;
									}
									if (180027 - 493837 == -313809)
									{
										goto IL_129;
									}
									if (!(this.$warpChar$41667.mSummoner == Game.mPlayer))
									{
										continue;
									}
									if (70267 - 224870 != -154603)
									{
										goto IL_129;
									}
									if (!this.$warpChar$41667.recieveMovement)
									{
										continue;
									}
									if (97050 - 509730 == -412679)
									{
										goto IL_129;
									}
								}
								this.$mWarpPos$41668 = global::Math.getRandomSpawnPos(this.$mWarpPoint$41663.transform.position, 2);
								if (182297 - 153158 == 29140)
								{
									goto IL_129;
								}
								if (this.$mWarpPos$41668 == Vector3.zero)
								{
									if (150543 - 228133 == -77589)
									{
										goto IL_129;
									}
									this.$mWarpPos$41668 = this.$mWarpPoint$41663.transform.position;
									if (14831 - 137190 != -122359)
									{
										goto IL_129;
									}
								}
								this.$warpObject$41666.transform.position = this.$mWarpPos$41668;
								if (117212 - 202474 != -85262)
								{
									goto IL_129;
								}
								UnityRuntimeServices.Update(this.$$iterator$10961$41669, this.$warpObject$41666);
								if (214545 - 581606 == -367060)
								{
									goto IL_129;
								}
								this.$warpObject$41666.transform.rotation = Quaternion.LookRotation(this.$mWarpPoint$41663.transform.forward);
								if (270244 - 564095 != -293851)
								{
									goto IL_129;
								}
								UnityRuntimeServices.Update(this.$$iterator$10961$41669, this.$warpObject$41666);
								if (277058 - 500499 == -223440)
								{
									goto IL_129;
								}
								if (this.$warpChar$41667)
								{
									if (296045 - 270258 == 25788)
									{
										goto IL_129;
									}
									this.$warpChar$41667.PositionEvent();
									if (260910 - 81571 != 179339)
									{
										goto IL_129;
									}
								}
							}
							if (102456 - 411709 != -309252)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (284203 - 498427 != -214224)
							{
								continue;
							}
							goto IL_370;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (147284 - 389329 != -242044)
							{
								goto IL_3F5;
							}
							continue;
						}
						break;
					default:
						if (246907 - 168145 != 78762)
						{
							continue;
						}
						break;
					}
					if (this.$mVar$41670 == 1)
					{
						if (76511 - 67880 == 8632)
						{
							continue;
						}
						this.$mWarpPoint$41663 = null;
						if (166684 - 372166 != -205482)
						{
							continue;
						}
						if (this.$self_$41671.jrQncqgBEqf >= 4)
						{
							if (229489 - 401462 == -171972)
							{
								continue;
							}
							this.$mWarpPoint$41663 = GameObject.Find("WarpPoint2");
							if (4529 - 236363 == -231833)
							{
								continue;
							}
						}
						else if (this.$self_$41671.jrQncqgBEqf >= 2)
						{
							if (90143 - 383674 != -293531)
							{
								continue;
							}
							this.$mWarpPoint$41663 = GameObject.Find("WarpPoint1");
							if (214890 - 363362 == -148471)
							{
								continue;
							}
						}
						if (this.$mWarpPoint$41663)
						{
							if (265575 - 396269 != -130694)
							{
								continue;
							}
							Game.mGameState = eGameState.Hold;
							if (91732 - 196151 != -104418)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							Debug.LogError("Error: Missing WarpPoint" + this.$mVar$41670);
							if (215001 - 445567 == -230565)
							{
								continue;
							}
						}
					}
					else if (this.$mVar$41670 == 2)
					{
						if (171478 - 364745 != -193267)
						{
							continue;
						}
						if (this.$self_$41671.jrQncqgBEqf < 6)
						{
							if (204218 - 366642 != -162424)
							{
								continue;
							}
							this.$self_$41671.jrQncqgBEqf = 6;
							if (131727 - 598617 != -466890)
							{
								continue;
							}
							Game.sendMissionEvent(9061, 0);
							if (180819 - 400090 == -219270)
							{
								continue;
							}
						}
					}
					IL_162:
					this.YieldDefault(1);
					if (29890 - 542575 != -512684)
					{
						goto Block_11;
					}
					continue;
					IL_3F5:
					goto IL_162;
				}
				Block_7:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_11:
				goto IL_85C;
				Block_17:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_335:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_26:
				IL_370:
				goto IL_85C;
				Block_36:
				goto IL_335;
				Block_63:
				IL_85C:
				return false;
			}

			// Token: 0x060092DB RID: 37595 RVA: 0x01196B4C File Offset: 0x01194D4C
			internal static bool O7jxQlVAMugqcKX6D6Rr()
			{
				return true;
			}

			// Token: 0x060092DC RID: 37596 RVA: 0x01196B50 File Offset: 0x01194D50
			internal static bool R05hJGVAxZwRuvObgrMa()
			{
				return false;
			}

			// Token: 0x04008A3C RID: 35388
			internal GameObject $mWarpPoint$41663;

			// Token: 0x04008A3D RID: 35389
			internal CameraEffect $mCameraEffect$41664;

			// Token: 0x04008A3E RID: 35390
			internal UnityScript.Lang.Array $warpList$41665;

			// Token: 0x04008A3F RID: 35391
			internal GameObject $warpObject$41666;

			// Token: 0x04008A40 RID: 35392
			internal CharacterControl $warpChar$41667;

			// Token: 0x04008A41 RID: 35393
			internal Vector3 $mWarpPos$41668;

			// Token: 0x04008A42 RID: 35394
			internal IEnumerator $$iterator$10961$41669;

			// Token: 0x04008A43 RID: 35395
			internal int $mVar$41670;

			// Token: 0x04008A44 RID: 35396
			internal M906_ShadowGodZera1 $self_$41671;
		}
	}

	// Token: 0x020018A6 RID: 6310
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41674 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060092DD RID: 37597 RVA: 0x01196B54 File Offset: 0x01194D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41674(M906_ShadowGodZera1 self_)
		{
			if (11314 - 341977 != -330663)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37749 - 47997 != -10247)
				{
					base..ctor();
					if (254689 - 182121 == 72568)
					{
						this.$self_$41681 = self_;
						if (279495 - 362861 == -83366)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x01196BEC File Offset: 0x01194DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$StartGame$41674.$(this.$self_$41681);
		}

		// Token: 0x060092DF RID: 37599 RVA: 0x01196BFC File Offset: 0x01194DFC
		internal static bool kqih0qVAgODbhM27BN0y()
		{
			return true;
		}

		// Token: 0x060092E0 RID: 37600 RVA: 0x01196C00 File Offset: 0x01194E00
		internal static bool LGJW8cVAf4PdP95Myfnc()
		{
			return false;
		}

		// Token: 0x04008A45 RID: 35397
		internal M906_ShadowGodZera1 $self_$41681;

		// Token: 0x020018A7 RID: 6311
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060092E1 RID: 37601 RVA: 0x01196C04 File Offset: 0x01194E04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera1 self_)
			{
				if (34878 - 62831 != -27953)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43871 - 83304 == -39433)
					{
						base..ctor();
						if (237111 - 339212 != -102100)
						{
							this.$self_$41680 = self_;
							if (26045 - 268406 == -242361)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060092E2 RID: 37602 RVA: 0x01196C9C File Offset: 0x01194E9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270876 - 122086 != 148791)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FE;
					case 2:
						this.$self_$41680.jrQncqgBEqf = 1;
						if (36767 - 70767 == -33999)
						{
							continue;
						}
						this.YieldDefault(1);
						if (228927 - 519315 != -290387)
						{
							goto Block_25;
						}
						continue;
					default:
						if (202866 - 238277 == -35410)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (59292 - 284483 == -225191)
					{
						Game.mGameState = eGameState.Start;
						if (192720 - 193064 != -343)
						{
							Game.mGameTime = Time.time;
							if (209408 - 426524 != -217115)
							{
								this.$self_$41680.nYVncRlYwId = GameObject.Find("ShadowBridge1");
								if (80019 - 281933 != -201913)
								{
									if (this.$self_$41680.nYVncRlYwId)
									{
										if (177867 - 353382 == -175514)
										{
											continue;
										}
										this.$self_$41680.nYVncRlYwId.renderer.enabled = false;
										if (15932 - 392262 != -376330)
										{
											continue;
										}
										this.$self_$41680.nYVncRlYwId.collider.isTrigger = true;
										if (115896 - 400653 == -284756)
										{
											continue;
										}
									}
									this.$self_$41680.fZsncru9vCw = GameObject.Find("ShadowBridge2");
									if (252585 - 361084 == -108499)
									{
										if (this.$self_$41680.fZsncru9vCw)
										{
											if (198323 - 109308 != 89015)
											{
												continue;
											}
											this.$self_$41680.fZsncru9vCw.renderer.enabled = false;
											if (117331 - 94864 == 22468)
											{
												continue;
											}
											this.$self_$41680.fZsncru9vCw.collider.isTrigger = true;
											if (45802 - 434786 == -388983)
											{
												continue;
											}
										}
										this.$self_$41680.BrfncxhZA7K = GameObject.Find("ShadowBridge3");
										if (53501 - 386757 != -333255)
										{
											if (this.$self_$41680.BrfncxhZA7K)
											{
												if (134084 - 234863 == -100778)
												{
													continue;
												}
												this.$self_$41680.BrfncxhZA7K.renderer.enabled = false;
												if (248201 - 584354 != -336153)
												{
													continue;
												}
												this.$self_$41680.BrfncxhZA7K.collider.isTrigger = true;
												if (49 - 415191 == -415141)
												{
													continue;
												}
											}
											this.$self_$41680.maFncTASTrG = GameObject.Find("ShadowBridge4");
											if (220392 - 549609 == -329217)
											{
												if (this.$self_$41680.maFncTASTrG)
												{
													if (260835 - 544358 == -283522)
													{
														continue;
													}
													this.$self_$41680.maFncTASTrG.renderer.enabled = false;
													if (79652 - 149582 != -69930)
													{
														continue;
													}
													this.$self_$41680.maFncTASTrG.collider.isTrigger = true;
													if (277049 - 253875 != 23174)
													{
														continue;
													}
												}
												this.$self_$41680.j46ncYOShoB = GameObject.Find("ShadowBridge5");
												if (18709 - 416693 == -397984)
												{
													if (this.$self_$41680.j46ncYOShoB)
													{
														if (64002 - 301980 == -237977)
														{
															continue;
														}
														this.$self_$41680.j46ncYOShoB.renderer.enabled = false;
														if (29119 - 455298 == -426178)
														{
															continue;
														}
														this.$self_$41680.j46ncYOShoB.collider.isTrigger = true;
														if (230886 - 52522 != 178364)
														{
															continue;
														}
													}
													this.$self_$41680.Ytxnc3cgB3U = GameObject.Find("ShadowPortal1");
													if (74881 - 499162 == -424281)
													{
														if (this.$self_$41680.Ytxnc3cgB3U)
														{
															if (260831 - 492145 != -231314)
															{
																continue;
															}
															this.$$14562$41676 = this.$self_$41680.Ytxnc3cgB3U.transform.position.y - (float)300;
															if (60118 - 267046 != -206928)
															{
																continue;
															}
															if (82661 - 45424 == 37238)
															{
																continue;
															}
															this.$$14563$41677 = this.$self_$41680.Ytxnc3cgB3U.transform.position;
															if (262778 - 552820 != -290042)
															{
																continue;
															}
															if (277815 - 549116 != -271301)
															{
																continue;
															}
															float num = this.$$14563$41677.y = this.$$14562$41676;
															if (172554 - 565173 != -392619)
															{
																continue;
															}
															if (161002 - 530941 == -369938)
															{
																continue;
															}
															this.$self_$41680.Ytxnc3cgB3U.transform.position = this.$$14563$41677;
															if (252432 - 158316 == 94117)
															{
																continue;
															}
															if (9113 - 354548 != -345435)
															{
																continue;
															}
														}
														this.$self_$41680.oobncbFdxdU = GameObject.Find("ShadowPortal2");
														if (78689 - 269061 == -190372)
														{
															if (this.$self_$41680.oobncbFdxdU)
															{
																if (193798 - 469590 != -275792)
																{
																	continue;
																}
																this.$$14564$41678 = this.$self_$41680.oobncbFdxdU.transform.position.y - (float)300;
																if (33250 - 164820 != -131570)
																{
																	continue;
																}
																if (115935 - 306428 == -190492)
																{
																	continue;
																}
																this.$$14565$41679 = this.$self_$41680.oobncbFdxdU.transform.position;
																if (280738 - 599835 == -319096)
																{
																	continue;
																}
																if (55927 - 150297 != -94370)
																{
																	continue;
																}
																float num2 = this.$$14565$41679.y = this.$$14564$41678;
																if (101335 - 419139 != -317804)
																{
																	continue;
																}
																if (217352 - 97140 != 120212)
																{
																	continue;
																}
																this.$self_$41680.oobncbFdxdU.transform.position = this.$$14565$41679;
																if (80842 - 127131 == -46288)
																{
																	continue;
																}
																if (29318 - 444378 != -415060)
																{
																	continue;
																}
															}
															Game.mGameState = eGameState.Normal;
															if (147096 - 155181 != -8084)
															{
																Game.mGameTime = Time.time;
																if (51569 - 293501 != -241931)
																{
																	this.$mGameGui$41675 = (GameGui)this.$self_$41680.GetComponent(typeof(GameGui));
																	if (271804 - 468713 == -196909)
																	{
																		this.$mGameGui$41675.enabled = true;
																		if (259991 - 449332 != -189340)
																		{
																			this.$self_$41680.SendMessage("fadeIn");
																			if (108012 - 229434 == -121422)
																			{
																				goto IL_50E;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_25:
				goto IL_8FE;
				IL_50E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_8FE:
				return false;
			}

			// Token: 0x060092E3 RID: 37603 RVA: 0x011975BC File Offset: 0x011957BC
			internal static bool N1tepnVAnh5NBMyWHmu0()
			{
				return true;
			}

			// Token: 0x060092E4 RID: 37604 RVA: 0x011975C0 File Offset: 0x011957C0
			internal static bool YBXTW0VA6NnUrARM8EnV()
			{
				return false;
			}

			// Token: 0x04008A46 RID: 35398
			internal GameGui $mGameGui$41675;

			// Token: 0x04008A47 RID: 35399
			internal float $$14562$41676;

			// Token: 0x04008A48 RID: 35400
			internal Vector3 $$14563$41677;

			// Token: 0x04008A49 RID: 35401
			internal float $$14564$41678;

			// Token: 0x04008A4A RID: 35402
			internal Vector3 $$14565$41679;

			// Token: 0x04008A4B RID: 35403
			internal M906_ShadowGodZera1 $self_$41680;
		}
	}

	// Token: 0x020018A8 RID: 6312
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41682 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060092E5 RID: 37605 RVA: 0x011975C4 File Offset: 0x011957C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41682(M906_ShadowGodZera1 self_)
		{
			if (223148 - 388245 != -165097)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (165780 - 262013 != -96232)
				{
					base..ctor();
					if (46567 - 38855 == 7712)
					{
						this.$self_$41687 = self_;
						if (136372 - 422762 != -286389)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x0119765C File Offset: 0x0119585C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$onDeadPlayer$41682.$(this.$self_$41687);
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x0119766C File Offset: 0x0119586C
		internal static bool hG05BRVAiaVEd2Vo4uZg()
		{
			return true;
		}

		// Token: 0x060092E8 RID: 37608 RVA: 0x01197670 File Offset: 0x01195870
		internal static bool ODC8WnVAKhqOvi9xV89l()
		{
			return false;
		}

		// Token: 0x04008A4C RID: 35404
		internal M906_ShadowGodZera1 $self_$41687;

		// Token: 0x020018A9 RID: 6313
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060092E9 RID: 37609 RVA: 0x01197674 File Offset: 0x01195874
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera1 self_)
			{
				if (4087 - 113715 != -109628)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235493 - 83199 != 152295)
					{
						base..ctor();
						if (47189 - 158392 != -111202)
						{
							this.$self_$41686 = self_;
							if (155969 - 320245 == -164276)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060092EA RID: 37610 RVA: 0x0119770C File Offset: 0x0119590C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146351 - 389698 != -243347)
				{
				}
				for (;;)
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
							goto IL_29F;
						}
						if (253894 - 317671 == -63776)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (15806 - 349322 != -333515)
							{
								goto IL_29F;
							}
							continue;
						}
						IL_11C:
						this.YieldDefault(1);
						if (208416 - 397690 != -189273)
						{
							goto Block_12;
						}
						continue;
						IL_29F:
						Game.mGameState = eGameState.Hold;
						if (258414 - 130393 == 128022)
						{
							continue;
						}
						this.$mStoryGui$41683 = (StoryGui)this.$self_$41686.GetComponent(typeof(StoryGui));
						if (263739 - 77391 != 186348)
						{
							continue;
						}
						if (this.$mStoryGui$41683)
						{
							if (221232 - 97929 == 123304)
							{
								continue;
							}
							this.$mStoryGui$41683.close();
							if (272938 - 66808 == 206131)
							{
								continue;
							}
						}
						this.$mChangeGui$41684 = (ChangeGui)this.$self_$41686.GetComponent(typeof(ChangeGui));
						if (64356 - 371254 == -306897)
						{
							continue;
						}
						if (this.$mChangeGui$41684)
						{
							if (7466 - 239188 != -231722)
							{
								continue;
							}
							this.$mChangeGui$41684.close();
							if (67564 - 464783 != -397219)
							{
								continue;
							}
						}
						this.$mGameGui$41685 = (GameGui)this.$self_$41686.GetComponent(typeof(GameGui));
						if (88503 - 183600 != -95097)
						{
							continue;
						}
						if (!this.$mGameGui$41685)
						{
							goto IL_11C;
						}
						if (42592 - 152882 != -110290)
						{
							continue;
						}
						if (!this.$mGameGui$41685.enabled)
						{
							if (246260 - 126277 != 119983)
							{
								continue;
							}
							this.$mGameGui$41685.enabled = true;
							if (160551 - 285751 != -125200)
							{
								continue;
							}
						}
						this.$mGameGui$41685.openDeadMenu();
						if (239476 - 157823 != 81654)
						{
							goto IL_11C;
						}
						continue;
					default:
						if (201186 - 452836 == -251649)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (295698 - 133583 != 162116)
					{
						goto Block_20;
					}
				}
				Block_12:
				goto IL_2F9;
				Block_20:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060092EB RID: 37611 RVA: 0x01197A24 File Offset: 0x01195C24
			internal static bool LeNQEBVAdo1gkLMM72ap()
			{
				return true;
			}

			// Token: 0x060092EC RID: 37612 RVA: 0x01197A28 File Offset: 0x01195C28
			internal static bool m4qErIVAJkOyQyfZ9xoC()
			{
				return false;
			}

			// Token: 0x04008A4D RID: 35405
			internal StoryGui $mStoryGui$41683;

			// Token: 0x04008A4E RID: 35406
			internal ChangeGui $mChangeGui$41684;

			// Token: 0x04008A4F RID: 35407
			internal GameGui $mGameGui$41685;

			// Token: 0x04008A50 RID: 35408
			internal M906_ShadowGodZera1 $self_$41686;
		}
	}

	// Token: 0x020018AA RID: 6314
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41688 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060092ED RID: 37613 RVA: 0x01197A2C File Offset: 0x01195C2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41688(Hashtable data, M906_ShadowGodZera1 self_)
		{
			if (82105 - 501750 != -419645)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146228 - 440623 == -294395)
				{
					base..ctor();
					if (61696 - 19490 == 42206)
					{
						this.$data$41693 = data;
						if (231954 - 520496 != -288541)
						{
							this.$self_$41694 = self_;
							if (201895 - 42999 != 158897)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x01197AE8 File Offset: 0x01195CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$onChangePlayer$41688.$(this.$data$41693, this.$self_$41694);
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x01197AFC File Offset: 0x01195CFC
		internal static bool EX9IX3VADgwrZfQ7d1AW()
		{
			return true;
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x01197B00 File Offset: 0x01195D00
		internal static bool YkbqPBVAvfKDmATsXsid()
		{
			return false;
		}

		// Token: 0x04008A51 RID: 35409
		internal Hashtable $data$41693;

		// Token: 0x04008A52 RID: 35410
		internal M906_ShadowGodZera1 $self_$41694;

		// Token: 0x020018AB RID: 6315
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060092F1 RID: 37617 RVA: 0x01197B04 File Offset: 0x01195D04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M906_ShadowGodZera1 self_)
			{
				if (27645 - 391615 != -363969)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (137226 - 512269 != -375042)
					{
						base..ctor();
						if (85897 - 563333 == -477436)
						{
							this.$data$41691 = data;
							if (131966 - 217848 == -85882)
							{
								this.$self_$41692 = self_;
								if (45230 - 419037 != -373806)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060092F2 RID: 37618 RVA: 0x01197BC0 File Offset: 0x01195DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111583 - 505558 != -393975)
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
							if (114006 - 528538 != -414532)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (76801 - 247478 != -170677)
							{
								continue;
							}
							this.$mGameGui$41690 = (GameGui)this.$self_$41692.GetComponent(typeof(GameGui));
							if (284734 - 582812 != -298078)
							{
								continue;
							}
							this.$mGameGui$41690.enabled = true;
							if (178033 - 406111 == -228077)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (266797 - 47992 != 218806)
						{
							goto Block_3;
						}
						continue;
					default:
						if (126382 - 325951 == -199568)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (299605 - 196384 == 103221)
					{
						this.$self_$41692.SendMessage("onCreatePlayer", this.$data$41691);
						if (180285 - 95629 != 84657)
						{
							this.$mChangeGui$41689 = (ChangeGui)this.$self_$41692.GetComponent(typeof(ChangeGui));
							if (156377 - 380473 != -224095)
							{
								if (!this.$mChangeGui$41689.enabled)
								{
									goto IL_AC;
								}
								if (71121 - 113671 == -42550)
								{
									this.$mChangeGui$41689.close();
									if (215070 - 32305 != 182766)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_205;
				IL_AC:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				goto IL_AC;
				IL_205:
				return false;
			}

			// Token: 0x060092F3 RID: 37619 RVA: 0x01197DE4 File Offset: 0x01195FE4
			internal static bool KEfhLoVARWXKLg4ay0yj()
			{
				return true;
			}

			// Token: 0x060092F4 RID: 37620 RVA: 0x01197DE8 File Offset: 0x01195FE8
			internal static bool k29mmgVAwqNEP29LAN7L()
			{
				return false;
			}

			// Token: 0x04008A53 RID: 35411
			internal ChangeGui $mChangeGui$41689;

			// Token: 0x04008A54 RID: 35412
			internal GameGui $mGameGui$41690;

			// Token: 0x04008A55 RID: 35413
			internal Hashtable $data$41691;

			// Token: 0x04008A56 RID: 35414
			internal M906_ShadowGodZera1 $self_$41692;
		}
	}

	// Token: 0x020018AC RID: 6316
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41695 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060092F5 RID: 37621 RVA: 0x01197DEC File Offset: 0x01195FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41695(M906_ShadowGodZera1 self_)
		{
			if (78127 - 18291 != 59837)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101038 - 180070 != -79031)
				{
					base..ctor();
					if (81165 - 494852 != -413686)
					{
						this.$self_$41699 = self_;
						if (74276 - 253496 != -179219)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060092F6 RID: 37622 RVA: 0x01197E84 File Offset: 0x01196084
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$ReturnToTown$41695.$(this.$self_$41699);
		}

		// Token: 0x060092F7 RID: 37623 RVA: 0x01197E94 File Offset: 0x01196094
		internal static bool fEXasMVAqCCfusTUvStc()
		{
			return true;
		}

		// Token: 0x060092F8 RID: 37624 RVA: 0x01197E98 File Offset: 0x01196098
		internal static bool mglhjVVA7o6UBUL7lRnu()
		{
			return false;
		}

		// Token: 0x04008A57 RID: 35415
		internal M906_ShadowGodZera1 $self_$41699;

		// Token: 0x020018AD RID: 6317
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060092F9 RID: 37625 RVA: 0x01197E9C File Offset: 0x0119609C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera1 self_)
			{
				if (272587 - 532875 != -260287)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189000 - 347371 == -158371)
					{
						base..ctor();
						if (69917 - 384906 == -314989)
						{
							this.$self_$41698 = self_;
							if (94804 - 91139 == 3665)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060092FA RID: 37626 RVA: 0x01197F34 File Offset: 0x01196134
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (121590 - 410174 != -288584)
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
						this.$self_$41698.LeaveGame();
						if (179125 - 294953 != -115828)
						{
							continue;
						}
						this.YieldDefault(1);
						if (264929 - 394570 != -129641)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (266020 - 319519 == -53498)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (239391 - 94779 != 144613)
					{
						Game.mStateTime = Time.time;
						if (181054 - 246230 != -65175)
						{
							this.$$switch$7516$41696 = PlayerData.SaveGuild;
							if (125613 - 37395 == 88218)
							{
								if (this.$$switch$7516$41696 == 1)
								{
									if (145539 - 341621 == -196081)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (191252 - 194315 == -3062)
									{
										continue;
									}
								}
								else if (this.$$switch$7516$41696 == 2)
								{
									if (200198 - 354059 != -153861)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (270131 - 592625 != -322494)
									{
										continue;
									}
								}
								else if (this.$$switch$7516$41696 == 3)
								{
									if (17207 - 563387 != -546180)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (185183 - 547136 != -361953)
									{
										continue;
									}
								}
								else if (this.$$switch$7516$41696 == 4)
								{
									if (202294 - 67762 == 134533)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (203733 - 598422 == -394688)
									{
										continue;
									}
								}
								else if (this.$$switch$7516$41696 == 5)
								{
									if (40444 - 224480 != -184036)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (149904 - 167097 == -17192)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (117583 - 157347 == -39763)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (265486 - 118034 == 147453)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (76826 - 452943 == -376116)
									{
										continue;
									}
								}
								this.$mGameGui$41697 = (GameGui)this.$self_$41698.GetComponent(typeof(GameGui));
								if (219056 - 306097 != -87040)
								{
									if (this.$mGameGui$41697)
									{
										if (158828 - 189479 == -30650)
										{
											continue;
										}
										this.$mGameGui$41697.close();
										if (91340 - 336987 == -245646)
										{
											continue;
										}
									}
									this.$self_$41698.SendMessage("fadeOut");
									if (220803 - 292044 != -71240)
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

			// Token: 0x060092FB RID: 37627 RVA: 0x01198300 File Offset: 0x01196500
			internal static bool NH2MogVAPY7iCPDgLh1J()
			{
				return true;
			}

			// Token: 0x060092FC RID: 37628 RVA: 0x01198304 File Offset: 0x01196504
			internal static bool gMqguVVA0xsaktAMrvtg()
			{
				return false;
			}

			// Token: 0x04008A58 RID: 35416
			internal int $$switch$7516$41696;

			// Token: 0x04008A59 RID: 35417
			internal GameGui $mGameGui$41697;

			// Token: 0x04008A5A RID: 35418
			internal M906_ShadowGodZera1 $self_$41698;
		}
	}

	// Token: 0x020018AE RID: 6318
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41700 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060092FD RID: 37629 RVA: 0x01198308 File Offset: 0x01196508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41700(M906_ShadowGodZera1 self_)
		{
			if (254307 - 314260 != -59952)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220255 - 265412 == -45157)
				{
					base..ctor();
					if (181356 - 441131 != -259774)
					{
						this.$self_$41703 = self_;
						if (283624 - 242253 != 41372)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060092FE RID: 37630 RVA: 0x011983A0 File Offset: 0x011965A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$ReturnToGuild$41700.$(this.$self_$41703);
		}

		// Token: 0x060092FF RID: 37631 RVA: 0x011983B0 File Offset: 0x011965B0
		internal static bool rWKHFYVAbruDAc8VWrQr()
		{
			return true;
		}

		// Token: 0x06009300 RID: 37632 RVA: 0x011983B4 File Offset: 0x011965B4
		internal static bool YKvO3JVAuvhRMO6JFn5l()
		{
			return false;
		}

		// Token: 0x04008A5B RID: 35419
		internal M906_ShadowGodZera1 $self_$41703;

		// Token: 0x020018AF RID: 6319
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009301 RID: 37633 RVA: 0x011983B8 File Offset: 0x011965B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera1 self_)
			{
				if (53963 - 82099 != -28135)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149110 - 123804 != 25307)
					{
						base..ctor();
						if (241992 - 218651 != 23342)
						{
							this.$self_$41702 = self_;
							if (174289 - 384609 == -210320)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009302 RID: 37634 RVA: 0x01198450 File Offset: 0x01196650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288167 - 427539 != -139372)
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
						this.$self_$41702.LeaveGame();
						if (236966 - 299851 != -62885)
						{
							continue;
						}
						this.YieldDefault(1);
						if (121800 - 67542 != 54259)
						{
							goto Block_9;
						}
						continue;
					default:
						if (263560 - 107424 != 156136)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (74286 - 525927 == -451641)
					{
						Game.mStateTime = Time.time;
						if (241686 - 490225 != -248538)
						{
							Game.mNextGameCode = 31;
							if (96218 - 272495 != -176276)
							{
								this.$mGameGui$41701 = (GameGui)this.$self_$41702.GetComponent(typeof(GameGui));
								if (121458 - 556799 == -435341)
								{
									if (this.$mGameGui$41701)
									{
										if (126162 - 86658 != 39504)
										{
											continue;
										}
										this.$mGameGui$41701.close();
										if (84996 - 242976 == -157979)
										{
											continue;
										}
									}
									this.$self_$41702.SendMessage("fadeOut");
									if (152521 - 573806 == -421285)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_9:
				IL_1BD:
				return false;
			}

			// Token: 0x06009303 RID: 37635 RVA: 0x0119862C File Offset: 0x0119682C
			internal static bool RTy8BGVAIM7FTgMX4Hmk()
			{
				return true;
			}

			// Token: 0x06009304 RID: 37636 RVA: 0x01198630 File Offset: 0x01196830
			internal static bool KyTxE4VABraDeKm17gq6()
			{
				return false;
			}

			// Token: 0x04008A5C RID: 35420
			internal GameGui $mGameGui$41701;

			// Token: 0x04008A5D RID: 35421
			internal M906_ShadowGodZera1 $self_$41702;
		}
	}

	// Token: 0x020018B0 RID: 6320
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41704 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009305 RID: 37637 RVA: 0x01198634 File Offset: 0x01196834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41704(M906_ShadowGodZera1 self_)
		{
			if (75093 - 295871 != -220778)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298356 - 67902 != 230455)
				{
					base..ctor();
					if (50118 - 42885 == 7233)
					{
						this.$self_$41708 = self_;
						if (214883 - 432268 == -217385)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009306 RID: 37638 RVA: 0x011986CC File Offset: 0x011968CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera1.$ReturnToCamp$41704.$(this.$self_$41708);
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x011986DC File Offset: 0x011968DC
		internal static bool qZfEpFVAefiJ2xQnb3Ce()
		{
			return true;
		}

		// Token: 0x06009308 RID: 37640 RVA: 0x011986E0 File Offset: 0x011968E0
		internal static bool YWt8bVVArt8vUsr4ojyC()
		{
			return false;
		}

		// Token: 0x04008A5E RID: 35422
		internal M906_ShadowGodZera1 $self_$41708;

		// Token: 0x020018B1 RID: 6321
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009309 RID: 37641 RVA: 0x011986E4 File Offset: 0x011968E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera1 self_)
			{
				if (298315 - 454676 != -156360)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40782 - 218764 == -177982)
					{
						base..ctor();
						if (67449 - 270020 != -202570)
						{
							this.$self_$41707 = self_;
							if (133809 - 131672 == 2137)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600930A RID: 37642 RVA: 0x0119877C File Offset: 0x0119697C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91426 - 104984 != -13558)
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
						this.$self_$41707.LeaveGame();
						if (74579 - 55973 != 18606)
						{
							continue;
						}
						this.YieldDefault(1);
						if (20932 - 33866 != -12933)
						{
							goto Block_10;
						}
						continue;
					default:
						if (54740 - 156102 == -101361)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (121177 - 586070 != -464892)
					{
						Game.mStateTime = Time.time;
						if (218139 - 528400 != -310260)
						{
							this.$$switch$7518$41705 = PlayerData.SaveGuild;
							if (62853 - 387750 != -324896)
							{
								if (this.$$switch$7518$41705 == 1)
								{
									if (45490 - 3653 != 41837)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (155336 - 111944 == 43393)
									{
										continue;
									}
								}
								else if (this.$$switch$7518$41705 == 2)
								{
									if (123876 - 308417 == -184540)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (71461 - 592668 != -521207)
									{
										continue;
									}
								}
								else if (this.$$switch$7518$41705 == 3)
								{
									if (163140 - 225174 != -62034)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (274480 - 500887 == -226406)
									{
										continue;
									}
								}
								else if (this.$$switch$7518$41705 == 4)
								{
									if (156012 - 393292 == -237279)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (106999 - 498898 != -391899)
									{
										continue;
									}
								}
								else if (this.$$switch$7518$41705 == 5)
								{
									if (159309 - 409908 == -250598)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (218285 - 413318 != -195033)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (142614 - 543765 == -401150)
									{
										continue;
									}
								}
								this.$mGameGui$41706 = (GameGui)this.$self_$41707.GetComponent(typeof(GameGui));
								if (233321 - 101799 == 131522)
								{
									if (this.$mGameGui$41706)
									{
										if (35766 - 52309 != -16543)
										{
											continue;
										}
										this.$mGameGui$41706.close();
										if (203704 - 358495 == -154790)
										{
											continue;
										}
									}
									this.$self_$41707.SendMessage("fadeOut");
									if (280191 - 518480 != -238288)
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
				IL_363:
				return false;
			}

			// Token: 0x0600930B RID: 37643 RVA: 0x01198B00 File Offset: 0x01196D00
			internal static bool FkTTWLVAjleSEaQi1MUb()
			{
				return true;
			}

			// Token: 0x0600930C RID: 37644 RVA: 0x01198B04 File Offset: 0x01196D04
			internal static bool rGg2kaVAh9T5A1lPIeId()
			{
				return false;
			}

			// Token: 0x04008A5F RID: 35423
			internal int $$switch$7518$41705;

			// Token: 0x04008A60 RID: 35424
			internal GameGui $mGameGui$41706;

			// Token: 0x04008A61 RID: 35425
			internal M906_ShadowGodZera1 $self_$41707;
		}
	}
}
