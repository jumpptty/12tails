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

// Token: 0x02001759 RID: 5977
[Serializable]
public class M707_MachineFromThePast : MonoBehaviour
{
	// Token: 0x06008AE5 RID: 35557 RVA: 0x01104118 File Offset: 0x01102318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M707_MachineFromThePast()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008AE6 RID: 35558 RVA: 0x01104128 File Offset: 0x01102328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (43835 - 133702 != -89867)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (261192 - 460354 == -199162)
			{
				Game.mGameType = 4;
				if (97066 - 373583 == -276517)
				{
					if (Chat.Initialized)
					{
						if (188201 - 206145 == -17943)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (54363 - 168061 != -113698)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (215 - 112717 != -112502)
						{
							continue;
						}
					}
					this.Gx7cV3aOBXu = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (139688 - 3540 == 136148)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008AE7 RID: 35559 RVA: 0x01104248 File Offset: 0x01102448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (109390 - 588468 != -479078)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (97894 - 477574 == -379680)
				{
					if (Game.mNextGameCode != 707)
					{
						break;
					}
					if (146468 - 235996 == -89528)
					{
						Game.nextGame();
						if (160735 - 55533 == 105202)
						{
							Game.mGameCode = 707;
							if (237583 - 21560 == 216023)
							{
								Game.mGameType = 4;
								if (245465 - 591793 == -346328)
								{
									Game.mGameTime = Time.time;
									if (146005 - 62320 != 83686)
									{
										Game.mGameScore = 0;
										if (13690 - 479862 != -466171)
										{
											Game.mGameMana = 0;
											if (277523 - 342217 != -64693)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (39608 - 156091 == -116483)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (187651 - 536289 == -348638)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (139249 - 491309 != -352059)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (244469 - 141447 == 103022)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (164902 - 426332 == -261430)
																{
																	this.uuicVTjTbYD = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (9909 - 148010 != -138100)
																	{
																		this.uuicVTjTbYD.enabled = false;
																		if (33822 - 413474 == -379652)
																		{
																			this.er5cVxRr7Yf = PhotonClient.Connection;
																			if (140805 - 302819 == -162014)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (34499 - 220631 != -186131)
																				{
																					this.InitGame();
																					if (20303 - 336002 != -315698)
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
			else
			{
				Debug.Log("Not Connected");
				if (102273 - 517050 == -414777)
				{
					Game.mGameType = 99;
					if (284696 - 324658 == -39962)
					{
						this.uuicVTjTbYD = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (212568 - 451146 == -238578)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AE8 RID: 35560 RVA: 0x011045A4 File Offset: 0x011027A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (224968 - 372748 != -147779)
		{
		}
		for (;;)
		{
			if (this.er5cVxRr7Yf == null)
			{
				if (111871 - 93854 == 18017)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (85517 - 383407 == -297890)
				{
					if (mGameState == eGameState.Init)
					{
						if (266959 - 241369 == 25590)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (181401 - 27749 != 153653)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (262703 - 87980 == 174723)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (235188 - 176839 == 58349)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (23892 - 196447 != -172554)
						{
							if (Game.music != 0)
							{
								if (128077 - 233012 != -104935)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (244277 - 552330 != -308053)
									{
										continue;
									}
									this.audio.Play();
									if (195509 - 561267 != -365758)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (221670 - 425757 != -204086)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (28679 - 526135 == -497456)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (18881 - 450243 != -431361)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (145880 - 323207 == -177327)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (93589 - 493210 == -399621)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (41433 - 327983 != -286549)
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
						if (297301 - 9515 != 287787)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AE9 RID: 35561 RVA: 0x0110489C File Offset: 0x01102A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (86471 - 360334 != -273863)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (276920 - 573332 != -296411)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (64972 - 399039 == -334067)
				{
					if (!this.Gx7cV3aOBXu)
					{
						break;
					}
					if (285066 - 171203 == 113863)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (161510 - 281053 == -119543)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (31934 - 3080 != 28855)
							{
								float num2 = (float)Screen.height / 1024f;
								if (18606 - 53546 != -34939)
								{
									GUI.depth = 1;
									if (80484 - 184551 == -104067)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.j34cVdqFYNm));
										if (234278 - 571315 == -337037)
										{
											Color color = GUI.color;
											if (162668 - 61374 != 101295)
											{
												float num3 = color.a = a;
												if (26859 - 539545 == -512686)
												{
													if (3275 - 184357 == -181082)
													{
														GUI.color = color;
														if (162741 - 499319 != -336577)
														{
															if (5196 - 276347 == -271151)
															{
																float num4 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.j34cVdqFYNm);
																if (249991 - 399304 == -149313)
																{
																	GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.Gx7cV3aOBXu.width * num4, (float)530 - 0.5f * (float)this.Gx7cV3aOBXu.height * num4, (float)this.Gx7cV3aOBXu.width * num4, (float)this.Gx7cV3aOBXu.height * num4), this.Gx7cV3aOBXu);
																	if (207668 - 596944 == -389276)
																	{
																		int num5 = 1;
																		if (7608 - 59561 == -51953)
																		{
																			Color color2 = GUI.color;
																			if (57644 - 468718 != -411073)
																			{
																				color2.a = (float)num5;
																				if (218765 - 33408 == 185357)
																				{
																					if (51915 - 583382 != -531466)
																					{
																						GUI.color = color2;
																						if (15833 - 169219 == -153386)
																						{
																							if (45992 - 140883 == -94891)
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
	}

	// Token: 0x06008AEA RID: 35562 RVA: 0x01104C5C File Offset: 0x01102E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (235306 - 567649 != -332342)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (4012 - 354148 == -350136)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (244764 - 428429 == -183665)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (186773 - 382041 == -195268)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (44570 - 415560 != -370989)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AEB RID: 35563 RVA: 0x01104D4C File Offset: 0x01102F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (199610 - 328079 != -128469)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (161714 - 334924 != -173209)
			{
				Time.timeScale = 1f;
				if (281796 - 303668 == -21872)
				{
					Hashtable customOpParameters = new Hashtable();
					if (214427 - 591593 != -377165)
					{
						this.er5cVxRr7Yf.OpCustom(52, customOpParameters, true);
						if (29105 - 292408 == -263303)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AEC RID: 35564 RVA: 0x01104E18 File Offset: 0x01103018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (184239 - 344908 != -160669)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (186153 - 442590 == -256437)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (91279 - 68213 != 23067)
				{
					Game.mGameState = eGameState.Setup;
					if (168579 - 534335 != -365755)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008AED RID: 35565 RVA: 0x01104EBC File Offset: 0x011030BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (187126 - 432478 != -245351)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (242972 - 84526 == 158446)
			{
				if (num == PlayerData.UID)
				{
					if (112572 - 70423 == 42149)
					{
						this.SetupActors();
						if (148110 - 226686 == -78576)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (69392 - 217055 != -147662)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008AEE RID: 35566 RVA: 0x01104F8C File Offset: 0x0110318C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (145128 - 344566 != -199437)
		{
		}
		for (;;)
		{
			IL_13F:
			Debug.Log("Creating Actors");
			if (154651 - 167886 != -13234)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (41460 - 225422 == -183962)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (189278 - 327087 != -137808)
						{
							int i = 0;
							if (70447 - 435833 == -365386)
							{
								CharacterControl[] array2 = array;
								if (190256 - 268847 != -78590)
								{
									int length = array2.Length;
									if (90757 - 147413 != -56655)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (229123 - 69712 != 159411)
											{
												goto IL_13F;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (150547 - 234413 == -83865)
											{
												goto IL_13F;
											}
											this.VJucVgpNdeH++;
											if (197943 - 348166 != -150223)
											{
												goto IL_13F;
											}
											i++;
											if (170674 - 267966 != -97292)
											{
												goto IL_13F;
											}
										}
										if (101258 - 536617 == -435359)
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
						if (135253 - 235616 != -100362)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AEF RID: 35567 RVA: 0x011051A4 File Offset: 0x011033A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (465 - 241000 != -240535)
		{
		}
		for (;;)
		{
			IL_84:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (102472 - 286135 == -183663)
			{
				int i = 0;
				if (198647 - 273045 == -74398)
				{
					CharacterControl[] array2 = array;
					if (211569 - 12132 == 199437)
					{
						int length = array2.Length;
						if (285332 - 53582 == 231750)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (123575 - 161584 == -38008)
								{
									goto IL_84;
								}
								i++;
								if (200006 - 207284 != -7278)
								{
									goto IL_84;
								}
							}
							if (113050 - 401404 == -288354)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AF0 RID: 35568 RVA: 0x011052D4 File Offset: 0x011034D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (23982 - 417585 != -393602)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (54581 - 308957 != -254375)
			{
				Game.mGameState = eGameState.Ready;
				if (217387 - 24510 != 192878)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (283684 - 156684 != 127001 && 4 - 259406 == -259402)
					{
						GameObject gameObject = null;
						if (75615 - 167997 == -92382)
						{
							if (playerSlot <= 1)
							{
								goto IL_129;
							}
							if (120165 - 45399 == 74767)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_129;
							}
							if (57718 - 6265 == 51454)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (87739 - 294220 != -206481)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (249588 - 246098 == 3491)
							{
								continue;
							}
							IL_7F:
							if (gameObject2)
							{
								if (222926 - 333540 != -110614)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
								if (232970 - 376429 != -143459)
								{
									continue;
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (274472 - 163937 == 110536)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (56900 - 225086 == -168185)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (44914 - 243396 != -198482)
							{
								continue;
							}
							break;
							IL_129:
							gameObject2 = GameObject.Find("StartPoint1");
							if (256481 - 499441 != -242959)
							{
								goto IL_7F;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AF1 RID: 35569 RVA: 0x01105564 File Offset: 0x01103764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M707_MachineFromThePast.$StartGame$40525(this).GetEnumerator();
	}

	// Token: 0x06008AF2 RID: 35570 RVA: 0x01105574 File Offset: 0x01103774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008AF3 RID: 35571 RVA: 0x01105578 File Offset: 0x01103778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M707_MachineFromThePast.$onGameComplete$40545(data, this).GetEnumerator();
	}

	// Token: 0x06008AF4 RID: 35572 RVA: 0x01105588 File Offset: 0x01103788
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (207780 - 222554 != -14774)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (80513 - 317327 == -236814)
			{
				hashtable.Add(71, CID);
				if (256543 - 137241 != 119303)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (60578 - 445669 == -385091)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (196759 - 58736 == 138023)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (216173 - 95795 == 120378)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (49437 - 109217 != -59779)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (114932 - 127303 == -12371)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (265710 - 62028 == 203682)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (115958 - 251823 == -135865)
											{
												this.er5cVxRr7Yf.OpCustom(61, hashtable, true);
												if (275621 - 43986 == 231635)
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

	// Token: 0x06008AF5 RID: 35573 RVA: 0x01105814 File Offset: 0x01103A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (285943 - 291214 != -5270)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (264701 - 73838 == 190863)
			{
				if (!gameObject)
				{
					break;
				}
				if (268297 - 7254 != 261044)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (163713 - 589235 != -425521)
					{
						playerCameraControl.target = gameObject;
						if (29137 - 32101 != -2963)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (209550 - 158040 == 51510)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AF6 RID: 35574 RVA: 0x0110590C File Offset: 0x01103B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (94707 - 119169 != -24462)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (247870 - 23706 != 224165)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (33812 - 557820 == -524008)
				{
					gameGui.ResetTeamBar();
					if (87723 - 309481 != -221757)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008AF7 RID: 35575 RVA: 0x011059B8 File Offset: 0x01103BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M707_MachineFromThePast.$onDeadPlayer$40550(this).GetEnumerator();
	}

	// Token: 0x06008AF8 RID: 35576 RVA: 0x011059C8 File Offset: 0x01103BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (118173 - 197002 != -78828)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (255093 - 18235 != 236859)
			{
				this.uuicVTjTbYD.target = Game.mPlayer;
				if (233699 - 260076 != -26376)
				{
					this.uuicVTjTbYD.enabled = true;
					if (45858 - 305062 != -259203)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (292140 - 490284 == -198143)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (86589 - 543999 == -457409)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (151502 - 501612 == -350110)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (183821 - 219330 == -35509)
							{
								if (!gameGui)
								{
									break;
								}
								if (3861 - 292570 == -288709)
								{
									gameGui.enabled = true;
									if (29183 - 165069 == -135886)
									{
										gameGui.closeDeadMenu();
										if (241227 - 558255 == -317028)
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

	// Token: 0x06008AF9 RID: 35577 RVA: 0x01105B74 File Offset: 0x01103D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (211267 - 50149 != 161119)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (192061 - 206113 == -14052)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (138488 - 566682 != -428193)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (127421 - 267356 != -139934)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008AFA RID: 35578 RVA: 0x01105C38 File Offset: 0x01103E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008AFB RID: 35579 RVA: 0x01105C64 File Offset: 0x01103E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (57921 - 124211 != -66289)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (141208 - 78030 != 63179)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (93045 - 481848 == -388803)
				{
					hashtable.Add(43, PlayerData.UID);
					if (86888 - 122723 == -35835)
					{
						hashtable.Add(73, nType);
						if (132501 - 43162 != 89340)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (295960 - 14920 == 281040)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (271990 - 297648 != -25657)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (168896 - 416955 == -248059)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (157749 - 51660 != 106090)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (105421 - 134863 == -29442)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (60196 - 465014 != -404817)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (85292 - 323884 == -238592)
													{
														this.er5cVxRr7Yf.OpCustom(63, hashtable, true);
														if (8922 - 31063 != -22140)
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

	// Token: 0x06008AFC RID: 35580 RVA: 0x01105F48 File Offset: 0x01104148
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (269102 - 464412 != -195310)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (73964 - 468796 == -394832)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (242100 - 74290 != 167811)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (28592 - 250330 == -221738)
						{
							if (this.VJucVgpNdeH <= 0)
							{
								break;
							}
							if (210145 - 364002 == -153857)
							{
								this.VJucVgpNdeH--;
								if (222017 - 356778 == -134761)
								{
									if (this.VJucVgpNdeH != 0)
									{
										break;
									}
									if (267871 - 588494 != -320622)
									{
										Game.setGameState(eGameState.Ready);
										if (181824 - 497834 == -316010)
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
						if (284207 - 97683 == 186524)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (2217 - 454699 == -452482)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AFD RID: 35581 RVA: 0x011060D8 File Offset: 0x011042D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008AFE RID: 35582 RVA: 0x011060EC File Offset: 0x011042EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008AFF RID: 35583 RVA: 0x01106100 File Offset: 0x01104300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M707_MachineFromThePast.$ReturnToTown$40556(this).GetEnumerator();
	}

	// Token: 0x06008B00 RID: 35584 RVA: 0x01106110 File Offset: 0x01104310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M707_MachineFromThePast.$ReturnToGuild$40561(this).GetEnumerator();
	}

	// Token: 0x06008B01 RID: 35585 RVA: 0x01106120 File Offset: 0x01104320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M707_MachineFromThePast.$ReturnToCamp$40565(this).GetEnumerator();
	}

	// Token: 0x06008B02 RID: 35586 RVA: 0x01106130 File Offset: 0x01104330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (117299 - 435807 != -318507)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (117783 - 457134 != -339350)
			{
				Hashtable hashtable = new Hashtable();
				if (1155 - 276858 == -275703)
				{
					hashtable.Add(43, PlayerData.UID);
					if (98651 - 412762 == -314111)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (269147 - 464167 == -195020)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B03 RID: 35587 RVA: 0x01106208 File Offset: 0x01104408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008B04 RID: 35588 RVA: 0x0110621C File Offset: 0x0110441C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (41790 - 227664 != -185873)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (288957 - 369505 == -80548)
			{
				Hashtable hashtable = new Hashtable();
				if (135230 - 62761 == 72469)
				{
					if (Game.mNextGameCode == 30)
					{
						if (132783 - 111091 != 21692)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (289178 - 595484 == -306305)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (199689 - 157318 != 42371)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (205621 - 118957 == 86665)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (39049 - 140505 != -101456)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (27629 - 380218 == -352588)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (251380 - 218951 == 32430)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (295142 - 137893 == 157250)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (141647 - 200856 == -59208)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (173271 - 40590 != 132681)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (95366 - 74055 != 21311)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (241620 - 355811 != -114191)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (40389 - 358988 == -318598)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (93652 - 505092 != -411440)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (138794 - 255321 == -116526)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (120197 - 341063 != -220866)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (78168 - 398000 != -319832)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (106300 - 433860 == -327559)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (50917 - 520717 != -469800)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (155977 - 130684 != 25293)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (137709 - 147131 != -9422)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (158945 - 548575 == -389629)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (237029 - 219894 != 17135)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (186504 - 175751 != 10753)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (9052 - 403430 != -394378)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (132779 - 440617 == -307837)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (72988 - 148346 == -75357)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (179200 - 531087 == -351886)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (41379 - 556562 == -515183)
					{
						this.er5cVxRr7Yf.OpCustom(42, hashtable, true);
						if (182209 - 457549 == -275340)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B05 RID: 35589 RVA: 0x011067D0 File Offset: 0x011049D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008B06 RID: 35590 RVA: 0x011067E0 File Offset: 0x011049E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008B07 RID: 35591 RVA: 0x011067E4 File Offset: 0x011049E4
	internal static bool W4F8A9VYbHYuhN33jgZM()
	{
		return true;
	}

	// Token: 0x06008B08 RID: 35592 RVA: 0x011067E8 File Offset: 0x011049E8
	internal static bool GcbsZrVYuVRLwjIwOkxy()
	{
		return false;
	}

	// Token: 0x0400850C RID: 34060
	private LitePeer er5cVxRr7Yf;

	// Token: 0x0400850D RID: 34061
	private PlayerCameraControl uuicVTjTbYD;

	// Token: 0x0400850E RID: 34062
	private float wwWcVYjBbKU;

	// Token: 0x0400850F RID: 34063
	private Texture Gx7cV3aOBXu;

	// Token: 0x04008510 RID: 34064
	private int a3IcVbMh3KF;

	// Token: 0x04008511 RID: 34065
	private float j34cVdqFYNm;

	// Token: 0x04008512 RID: 34066
	private int VJucVgpNdeH;

	// Token: 0x04008513 RID: 34067
	public AudioClip laugh_vc;

	// Token: 0x0200175A RID: 5978
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40525 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B09 RID: 35593 RVA: 0x011067EC File Offset: 0x011049EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40525(M707_MachineFromThePast self_)
		{
			if (250274 - 486073 != -235798)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7535 - 207681 == -200146)
				{
					base..ctor();
					if (31310 - 256367 == -225057)
					{
						this.$self_$40544 = self_;
						if (13104 - 409922 == -396818)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x01106884 File Offset: 0x01104A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M707_MachineFromThePast.$StartGame$40525.$(this.$self_$40544);
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x01106894 File Offset: 0x01104A94
		internal static bool cGiQA6VYI9f6xYeqdbjE()
		{
			return true;
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x01106898 File Offset: 0x01104A98
		internal static bool UmnOyXVYBOK6XJ6y5eTT()
		{
			return false;
		}

		// Token: 0x04008514 RID: 34068
		internal M707_MachineFromThePast $self_$40544;

		// Token: 0x0200175B RID: 5979
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B0D RID: 35597 RVA: 0x0110689C File Offset: 0x01104A9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M707_MachineFromThePast self_)
			{
				if (297712 - 216997 != 80716)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129618 - 569684 == -440066)
					{
						base..ctor();
						if (105748 - 546832 != -441083)
						{
							this.$self_$40543 = self_;
							if (71118 - 335948 == -264830)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B0E RID: 35598 RVA: 0x01106934 File Offset: 0x01104B34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265849 - 232885 != 32965)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_CC0;
					case 1:
						goto IL_3360;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (120385 - 570037 != -449651)
							{
								goto Block_282;
							}
							continue;
						}
						else
						{
							this.$self_$40543.SendMessage("fadeIn");
							if (272479 - 212111 != 60369)
							{
								goto Block_267;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (10652 - 453231 != -442578)
							{
								goto Block_136;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40536 = (StoryGui)this.$self_$40543.GetComponent(typeof(StoryGui));
							if (177861 - 91566 != 86295)
							{
								continue;
							}
							this.$mStoryTimer$40537 = 0f;
							if (220364 - 60890 != 159474)
							{
								continue;
							}
							this.$mStoryGui$40536.startStoryMessage("CyborgMole", "Dr. Zappa", eTalkType.friend);
							if (113133 - 316070 != -202937)
							{
								continue;
							}
							if (!this.$mCyborgMole$40527)
							{
								goto IL_20E4;
							}
							if (297698 - 479273 == -181574)
							{
								continue;
							}
							this.$mCyborgMole$40527.animation.CrossFade("think");
							if (91361 - 588684 != -497323)
							{
								continue;
							}
							goto IL_20E4;
						}
						break;
					case 4:
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 101);
						if (209584 - 184503 != 25081)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (240250 - 444998 != -204748)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (257683 - 26173 != 231511)
						{
							goto Block_30;
						}
						continue;
					case 5:
						goto IL_20B;
					case 6:
						goto IL_20B;
					case 7:
						goto IL_192D;
					case 8:
						goto IL_192D;
					case 9:
						goto IL_313B;
					case 10:
						goto IL_313B;
					case 11:
						goto IL_231B;
					case 12:
						goto IL_142;
					case 13:
						goto IL_142;
					case 14:
						goto IL_2B84;
					case 15:
						goto IL_96;
					case 16:
						goto IL_96;
					case 17:
						goto IL_103D;
					case 18:
						goto IL_103D;
					case 19:
						goto IL_2217;
					case 20:
						goto IL_2217;
					case 21:
						goto IL_2E33;
					case 22:
						goto IL_2E33;
					case 23:
						goto IL_1CA4;
					case 24:
						goto IL_1CA4;
					case 25:
						goto IL_D38;
					case 26:
						goto IL_D38;
					case 27:
						goto IL_1BB8;
					case 28:
						goto IL_1BB8;
					case 29:
						if (Game.mGameState != eGameState.Start)
						{
							if (131358 - 237026 != -105668)
							{
								continue;
							}
							goto IL_8E9;
						}
						else
						{
							this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 113);
							if (187133 - 195328 == -8194)
							{
								continue;
							}
							this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
							if (195103 - 433082 == -237978)
							{
								continue;
							}
							if (this.$mCyborgMole$40527)
							{
								if (224368 - 598160 == -373791)
								{
									continue;
								}
								this.$mCyborgMole$40527.animation.CrossFade("think");
								if (209772 - 381985 == -172212)
								{
									continue;
								}
							}
							this.$mStoryTimer$40537 = Time.time + 4f;
							if (28741 - 377211 != -348470)
							{
								continue;
							}
							goto IL_179B;
						}
						break;
					case 30:
						goto IL_17C4;
					case 31:
						goto IL_17C4;
					case 32:
						break;
					case 33:
						break;
					case 34:
						goto IL_2700;
					case 35:
						goto IL_2700;
					case 36:
						goto IL_7C5;
					case 37:
						goto IL_7C5;
					case 38:
						goto IL_C71;
					case 39:
						goto IL_C71;
					case 40:
						goto IL_E07;
					case 41:
						goto IL_E07;
					case 42:
						goto IL_2089;
					case 43:
						goto IL_2089;
					case 44:
						goto IL_1886;
					case 45:
						goto IL_1886;
					case 46:
						goto IL_1BA;
					case 47:
						goto IL_1BA;
					case 48:
						goto IL_3251;
					case 49:
						goto IL_3251;
					case 50:
						goto IL_2C95;
					case 51:
						goto IL_2C95;
					case 52:
						goto IL_1B65;
					case 53:
						goto IL_1B65;
					case 54:
						goto IL_128B;
					case 55:
						goto IL_128B;
					case 56:
						goto IL_FEA;
					case 57:
						goto IL_FEA;
					case 58:
						goto IL_2E86;
					case 59:
						goto IL_2E86;
					case 60:
						if (Game.mGameState != eGameState.Start)
						{
							if (292402 - 445786 != -153384)
							{
								continue;
							}
							goto IL_22C0;
						}
						else
						{
							Game.sendMissionEvent(7071, 0);
							if (112307 - 315170 != -202863)
							{
								continue;
							}
							this.YieldDefault(1);
							if (132851 - 371023 != -238172)
							{
								continue;
							}
							goto IL_3360;
						}
						break;
					default:
						if (20595 - 111282 != -90687)
						{
							continue;
						}
						goto IL_CC0;
					}
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (42414 - 527683 == -485268)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							break;
						}
						if (246690 - 287367 != -40677)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (32779 - 511192 != -478413)
						{
							continue;
						}
						goto IL_12E6;
					}
					else
					{
						this.$self_$40543.uuicVTjTbYD.alignToObject("EventCamera3");
						if (115461 - 441600 == -326138)
						{
							continue;
						}
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 115);
						if (2888 - 203894 != -201006)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (284744 - 171431 != 113313)
						{
							continue;
						}
						if (this.$mCyborgMole$40527)
						{
							if (223650 - 353003 != -129353)
							{
								continue;
							}
							this.$mCyborgMole$40527.animation.CrossFade("root");
							if (173061 - 542111 != -369050)
							{
								continue;
							}
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (24666 - 545732 != -521066)
						{
							continue;
						}
						goto IL_26D7;
					}
					IL_96:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (182812 - 269762 != -86950)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_89;
						}
						if (285693 - 355332 == -69638)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (133118 - 502484 != -369365)
						{
							goto Block_297;
						}
						continue;
					}
					else
					{
						this.$self_$40543.uuicVTjTbYD.alignToObject("EventCamera4");
						if (161295 - 133921 != 27374)
						{
							continue;
						}
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 106);
						if (286697 - 241542 != 45155)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (244686 - 48526 == 196161)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 2f;
						if (286858 - 167321 != 119538)
						{
							goto Block_140;
						}
						continue;
					}
					IL_142:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (275160 - 461244 != -186084)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_135;
						}
						if (207750 - 123211 != 84539)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (3437 - 337291 != -333854)
						{
							continue;
						}
						goto IL_1605;
					}
					else
					{
						this.$self_$40543.uuicVTjTbYD.alignToObject("EventCamera3");
						if (59450 - 167501 == -108050)
						{
							continue;
						}
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 105);
						if (60015 - 507180 != -447165)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (140598 - 564623 == -424024)
						{
							continue;
						}
						if (this.$mCyborgMole$40527)
						{
							if (24718 - 421160 == -396441)
							{
								continue;
							}
							this.$mCyborgMole$40527.animation.CrossFade("run");
							if (9376 - 382434 == -373057)
							{
								continue;
							}
						}
						this.$self_$40543.j34cVdqFYNm = Time.time;
						if (223263 - 423431 != -200168)
						{
							continue;
						}
						goto IL_2B84;
					}
					IL_E07:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (94961 - 250481 == -155519)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_DFA;
						}
						if (243514 - 512219 != -268705)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (69872 - 354549 != -284676)
						{
							goto Block_11;
						}
						continue;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 119);
						if (281665 - 122711 == 158955)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (116693 - 159960 != -43267)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 5f;
						if (79567 - 301571 != -222004)
						{
							continue;
						}
						goto IL_2060;
					}
					IL_1BA:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (101070 - 516568 == -415497)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1AD;
						}
						if (86391 - 539469 != -453078)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (290216 - 289426 != 791)
						{
							goto Block_321;
						}
						continue;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 122);
						if (277584 - 103251 != 174333)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (14010 - 66067 != -52057)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 5f;
						if (70893 - 345784 != -274890)
						{
							goto Block_218;
						}
						continue;
					}
					IL_20B:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (143500 - 448927 == -305426)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1FF;
						}
						if (115851 - 434446 != -318595)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (176527 - 47933 != 128595)
						{
							goto Block_260;
						}
						continue;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 102);
						if (144775 - 574641 == -429865)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (91279 - 230973 == -139693)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (93514 - 78100 != 15414)
						{
							continue;
						}
						goto IL_1906;
					}
					IL_FEA:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (227740 - 227451 != 289)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_FDD;
						}
						if (257341 - 403663 == -146321)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (252218 - 463873 != -211655)
						{
							continue;
						}
						goto IL_2576;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 127);
						if (164303 - 349695 != -185392)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (276097 - 455448 == -179350)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 5f;
						if (252370 - 558749 != -306379)
						{
							continue;
						}
						goto IL_2E5D;
					}
					IL_C71:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (220744 - 252119 == -31374)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C64;
						}
						if (6676 - 175781 != -169105)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (278328 - 287029 != -8701)
						{
							continue;
						}
						goto IL_2FFA;
					}
					else
					{
						this.$self_$40543.uuicVTjTbYD.alignToObject("EventCamera5");
						if (284740 - 38765 == 245976)
						{
							continue;
						}
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 118);
						if (166011 - 407747 != -241736)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (153648 - 153189 != 459)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (213216 - 523604 != -310387)
						{
							goto Block_263;
						}
						continue;
					}
					IL_2700:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (270463 - 355178 == -84714)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_26F3;
						}
						if (228124 - 281664 != -53540)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (183432 - 28920 != 154512)
						{
							continue;
						}
						goto IL_349;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 116);
						if (269702 - 151969 == 117734)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$40538, eTalkType.friend);
						if (96567 - 357528 != -260961)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (104035 - 127351 != -23315)
						{
							goto Block_293;
						}
						continue;
					}
					IL_3251:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (264913 - 94094 == 170820)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3244;
						}
						if (28061 - 333952 != -305891)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (170480 - 51637 != 118843)
						{
							continue;
						}
						goto IL_37A;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 123);
						if (63319 - 277278 == -213958)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (82960 - 120564 == -37603)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (292024 - 539638 != -247613)
						{
							goto Block_283;
						}
						continue;
					}
					IL_CC0:
					Debug.Log("Start Game");
					if (12422 - 304888 != -292466)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (116786 - 384808 == -268021)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (185066 - 441816 != -256750)
					{
						continue;
					}
					this.$self_$40543.uuicVTjTbYD.enabled = false;
					if (113492 - 372988 == -259495)
					{
						continue;
					}
					this.$self_$40543.SendMessage("alignToObject", "EventCamera1");
					if (63580 - 340856 == -277275)
					{
						continue;
					}
					this.$mPlayer$40526 = Game.mPlayer;
					if (116092 - 220377 == -104284)
					{
						continue;
					}
					this.$mCyborgMole$40527 = GameObject.Find("CyborgMole");
					if (72491 - 515582 != -443091)
					{
						continue;
					}
					this.$mStartPoint1$40528 = GameObject.Find("StartPoint1");
					if (20413 - 482045 != -461632)
					{
						continue;
					}
					if (this.$mPlayer$40526)
					{
						if (237620 - 303227 != -65607)
						{
							continue;
						}
						if (this.$mStartPoint1$40528)
						{
							if (129278 - 328254 == -198975)
							{
								continue;
							}
							this.$mPlayer$40526.transform.position = this.$mStartPoint1$40528.transform.position;
							if (54213 - 477877 == -423663)
							{
								continue;
							}
							this.$mPlayer$40526.transform.rotation = this.$mStartPoint1$40528.transform.rotation;
							if (17138 - 133994 == -116855)
							{
								continue;
							}
						}
					}
					this.$mCDat2$40529 = null;
					if (2363 - 29614 != -27251)
					{
						continue;
					}
					this.$mCDat3$40530 = null;
					if (93875 - 269242 == -175366)
					{
						continue;
					}
					this.$$switch$7208$40531 = CharacterData.mSlot;
					if (266595 - 246210 == 20386)
					{
						continue;
					}
					if (this.$$switch$7208$40531 == 1)
					{
						if (30560 - 30282 == 279)
						{
							continue;
						}
						this.$mCDat2$40529 = CharacterData.getCDat(2);
						if (207901 - 25695 == 182207)
						{
							continue;
						}
						this.$mCDat3$40530 = CharacterData.getCDat(3);
						if (158863 - 270710 == -111846)
						{
							continue;
						}
					}
					else if (this.$$switch$7208$40531 == 2)
					{
						if (16261 - 27933 != -11672)
						{
							continue;
						}
						this.$mCDat2$40529 = CharacterData.getCDat(1);
						if (170000 - 373403 == -203402)
						{
							continue;
						}
						this.$mCDat3$40530 = CharacterData.getCDat(3);
						if (284116 - 551625 != -267509)
						{
							continue;
						}
					}
					else if (this.$$switch$7208$40531 == 3)
					{
						if (253345 - 432190 != -178845)
						{
							continue;
						}
						this.$mCDat2$40529 = CharacterData.getCDat(1);
						if (241701 - 354718 != -113017)
						{
							continue;
						}
						this.$mCDat3$40530 = CharacterData.getCDat(2);
						if (69099 - 577325 == -508225)
						{
							continue;
						}
					}
					this.$mStartPoint2$40532 = GameObject.Find("StartPoint2");
					if (279850 - 231505 != 48345)
					{
						continue;
					}
					if (this.$mStartPoint2$40532)
					{
						if (209760 - 109674 == 100087)
						{
							continue;
						}
						if (this.$mCDat2$40529 != null)
						{
							if (155407 - 453952 == -298544)
							{
								continue;
							}
							if (this.$mCDat2$40529.Type != "none")
							{
								if (170462 - 596024 != -425562)
								{
									continue;
								}
								this.$mPlayer2$40533 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$40529.Type, typeof(GameObject)), this.$mStartPoint2$40532.transform.position, this.$mStartPoint2$40532.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (247160 - 568831 == -321670)
								{
									continue;
								}
								if (this.$mPlayer2$40533)
								{
									if (105477 - 452041 == -346563)
									{
										continue;
									}
									this.$mPlayer2$40533.SendMessage("EquipCDat", this.$mCDat2$40529.slot);
									if (136509 - 79006 != 57503)
									{
										continue;
									}
								}
							}
						}
					}
					this.$mStartPoint3$40534 = GameObject.Find("StartPoint3");
					if (167248 - 66776 == 100473)
					{
						continue;
					}
					if (!this.$mStartPoint3$40534)
					{
						goto IL_285A;
					}
					if (122203 - 208390 != -86187)
					{
						continue;
					}
					if (this.$mCDat3$40530 == null)
					{
						goto IL_285A;
					}
					if (5442 - 189605 != -184163)
					{
						continue;
					}
					if (!(this.$mCDat3$40530.Type != "none"))
					{
						goto IL_285A;
					}
					if (187269 - 417966 == -230696)
					{
						continue;
					}
					this.$mPlayer3$40535 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$40530.Type, typeof(GameObject)), this.$mStartPoint3$40534.transform.position, this.$mStartPoint3$40534.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
					if (69545 - 471135 != -401590)
					{
						continue;
					}
					if (!this.$mPlayer3$40535)
					{
						goto IL_285A;
					}
					if (44162 - 515673 != -471511)
					{
						continue;
					}
					this.$mPlayer3$40535.SendMessage("EquipCDat", this.$mCDat3$40530.slot);
					if (262249 - 314167 != -51917)
					{
						goto Block_369;
					}
					continue;
					IL_103D:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (192722 - 58891 != 133831)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1030;
						}
						if (114701 - 232124 == -117422)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (185989 - 581769 != -395779)
						{
							goto Block_34;
						}
						continue;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 107);
						if (201770 - 368334 != -166564)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (261643 - 57330 != 204313)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (62258 - 478518 != -416260)
						{
							continue;
						}
						goto IL_21EE;
					}
					IL_313B:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (182654 - 55037 != 127617)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_312E;
						}
						if (104570 - 109197 == -4626)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (265179 - 234424 != 30755)
						{
							continue;
						}
						goto IL_583;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 104);
						if (162945 - 75022 != 87923)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (9135 - 496304 == -487168)
						{
							continue;
						}
						if (this.$mCyborgMole$40527)
						{
							if (267904 - 448890 != -180986)
							{
								continue;
							}
							this.$mCyborgMole$40527.animation.CrossFade("root");
							if (42533 - 85813 == -43279)
							{
								continue;
							}
						}
						this.$self_$40543.j34cVdqFYNm = Time.time;
						if (131346 - 21532 != 109814)
						{
							continue;
						}
						goto IL_231B;
					}
					IL_2E33:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (197129 - 153723 == 43407)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2E26;
						}
						if (39565 - 125363 == -85797)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (72527 - 10209 != 62318)
						{
							continue;
						}
						goto IL_20B3;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 109);
						if (53734 - 33808 != 19926)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (239624 - 120307 != 119317)
						{
							continue;
						}
						if (this.$mCyborgMole$40527)
						{
							if (168653 - 348839 == -180185)
							{
								continue;
							}
							this.$mCyborgMole$40527.animation.CrossFade("build");
							if (23238 - 475911 == -452672)
							{
								continue;
							}
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (207884 - 17048 != 190836)
						{
							continue;
						}
						goto IL_1C7B;
					}
					IL_192D:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (201254 - 302393 == -101138)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1921;
						}
						if (177088 - 514205 == -337116)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (87972 - 113562 != -25589)
						{
							goto Block_366;
						}
						continue;
					}
					else
					{
						this.$self_$40543.uuicVTjTbYD.StartCoroutine_Auto(this.$self_$40543.uuicVTjTbYD.slerpToObject("EventCamera2", 2f));
						if (151135 - 159578 != -8443)
						{
							continue;
						}
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 103);
						if (154250 - 455847 != -301597)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$40538, eTalkType.friend);
						if (29634 - 373054 == -343419)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (32020 - 185200 != -153180)
						{
							continue;
						}
						goto IL_3112;
					}
					IL_7C5:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (70147 - 201185 != -131038)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7B8;
						}
						if (53637 - 471310 != -417673)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (116796 - 234423 != -117626)
						{
							goto Block_134;
						}
						continue;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 117);
						if (115463 - 198137 == -82673)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$40538, eTalkType.friend);
						if (269357 - 444907 == -175549)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 3f;
						if (103645 - 257162 != -153517)
						{
							continue;
						}
						goto IL_C48;
					}
					IL_2E86:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (71762 - 119201 != -47439)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2E79;
						}
						if (14920 - 499631 != -484711)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (115544 - 425652 != -310107)
						{
							goto Block_62;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40536.close();
						if (101963 - 569421 != -467457)
						{
							goto Block_313;
						}
						continue;
					}
					IL_2217:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (147074 - 182263 == -35188)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_220A;
						}
						if (181921 - 525698 != -343777)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (263035 - 340426 != -77391)
						{
							continue;
						}
						goto IL_267B;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 108);
						if (227861 - 312668 == -84806)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (8402 - 181315 != -172913)
						{
							continue;
						}
						if (this.$mCyborgMole$40527)
						{
							if (70344 - 239122 != -168778)
							{
								continue;
							}
							this.$mCyborgMole$40527.animation.CrossFade("root");
							if (7575 - 7397 != 178)
							{
								continue;
							}
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (249498 - 235852 != 13647)
						{
							goto Block_139;
						}
						continue;
					}
					IL_17C4:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (121115 - 176552 != -55437)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_17B7;
						}
						if (160950 - 146339 == 14612)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (171865 - 509887 != -338022)
						{
							continue;
						}
						goto IL_F90;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 114);
						if (70535 - 554626 == -484090)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (8132 - 447126 == -438993)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 5f;
						if (33083 - 374333 != -341249)
						{
							goto Block_46;
						}
						continue;
					}
					IL_1886:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (198270 - 400559 == -202288)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1879;
						}
						if (124040 - 167673 != -43633)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (234967 - 241454 != -6487)
						{
							continue;
						}
						goto IL_13E5;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 121);
						if (29896 - 513483 == -483586)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (207837 - 446929 != -239092)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (98564 - 117867 != -19303)
						{
							continue;
						}
						goto IL_191;
					}
					IL_1CA4:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (250601 - 181412 != 69189)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1C97;
						}
						if (49400 - 136199 == -86798)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (59917 - 87890 != -27972)
						{
							goto Block_196;
						}
						continue;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 110);
						if (89113 - 278883 != -189770)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (225232 - 500964 != -275732)
						{
							continue;
						}
						if (this.$mCyborgMole$40527)
						{
							if (227816 - 347067 == -119250)
							{
								continue;
							}
							this.$mCyborgMole$40527.animation.CrossFade("root");
							if (285157 - 22726 != 262431)
							{
								continue;
							}
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (225699 - 370535 != -144835)
						{
							goto Block_92;
						}
						continue;
					}
					IL_D38:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (175053 - 338187 == -163133)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_D2B;
						}
						if (114541 - 592050 != -477509)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (275953 - 238780 != 37174)
						{
							goto Block_200;
						}
						continue;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 111);
						if (215116 - 326601 == -111484)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (19542 - 79667 != -60125)
						{
							continue;
						}
						if (this.$mCyborgMole$40527)
						{
							if (72012 - 161223 == -89210)
							{
								continue;
							}
							this.$mCyborgMole$40527.animation.CrossFade("build");
							if (250818 - 267163 != -16345)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (58292 - 391878 == -333585)
							{
								continue;
							}
							if (this.$self_$40543.laugh_vc)
							{
								if (214267 - 277721 == -63453)
								{
									continue;
								}
								this.$self_$40543.audio.PlayOneShot(this.$self_$40543.laugh_vc);
								if (138265 - 296289 == -158023)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find laugh voice");
								if (2873 - 343028 != -340155)
								{
									continue;
								}
							}
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (288624 - 244593 != 44031)
						{
							continue;
						}
						goto IL_1B8F;
					}
					IL_128B:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (96752 - 31732 != 65020)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_127E;
						}
						if (169883 - 441035 == -271151)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (297047 - 488422 != -191375)
						{
							continue;
						}
						goto IL_2126;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 126);
						if (13157 - 77068 == -63910)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (237636 - 46133 != 191503)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (128731 - 534068 != -405336)
						{
							goto Block_348;
						}
						continue;
					}
					IL_231B:
					if (Time.time >= this.$self_$40543.j34cVdqFYNm + 0.25f)
					{
						if (11527 - 247391 == -235863)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 3f;
						if (36502 - 391052 != -354550)
						{
							continue;
						}
						goto IL_119;
					}
					else
					{
						if (!this.$mCyborgMole$40527)
						{
							goto IL_230E;
						}
						if (255180 - 1930 != 253250)
						{
							continue;
						}
						this.$$14436$40539 = Mathf.SmoothStep((float)0, (float)180, (float)4 * (Time.time - this.$self_$40543.j34cVdqFYNm));
						if (189441 - 264017 == -74575)
						{
							continue;
						}
						if (33102 - 594772 != -561670)
						{
							continue;
						}
						Vector3 vector = this.$$14437$40540 = this.$mCyborgMole$40527.transform.eulerAngles;
						if (107621 - 444963 != -337342)
						{
							continue;
						}
						if (77830 - 397768 == -319937)
						{
							continue;
						}
						float num = this.$$14437$40540.y = this.$$14436$40539;
						if (190284 - 420382 != -230098)
						{
							continue;
						}
						if (213535 - 47610 != 165925)
						{
							continue;
						}
						Vector3 vector2 = this.$mCyborgMole$40527.transform.eulerAngles = this.$$14437$40540;
						if (241568 - 463458 != -221889 && 272832 - 141702 != 131131)
						{
							goto Block_205;
						}
						continue;
					}
					IL_2C95:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (33949 - 245714 == -211764)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2C88;
						}
						if (263596 - 147815 == 115782)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (88828 - 505216 != -416388)
						{
							continue;
						}
						goto IL_11DE;
					}
					else
					{
						this.$self_$40543.uuicVTjTbYD.alignToObject("EventCamera6");
						if (162923 - 393035 == -230111)
						{
							continue;
						}
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 124);
						if (10930 - 435974 == -425043)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (216629 - 110964 != 105665)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (268458 - 318218 != -49760)
						{
							continue;
						}
						goto IL_1B3C;
					}
					IL_1B65:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (229367 - 325881 == -96513)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1B58;
						}
						if (133297 - 230739 == -97441)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (101338 - 516476 != -415138)
						{
							continue;
						}
						goto IL_138B;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 125);
						if (196077 - 149544 == 46534)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (79421 - 244008 == -164586)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (76335 - 103765 != -27429)
						{
							goto Block_36;
						}
						continue;
					}
					IL_2089:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (70612 - 191732 == -121119)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_207C;
						}
						if (294940 - 481203 != -186263)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (56576 - 441342 != -384766)
						{
							continue;
						}
						goto IL_1957;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 120);
						if (183781 - 355945 != -172164)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (218885 - 436493 == -217607)
						{
							continue;
						}
						this.$mStoryTimer$40537 = Time.time + 4f;
						if (155937 - 294764 != -138827)
						{
							continue;
						}
						goto IL_185D;
					}
					IL_1BB8:
					if (this.$mStoryTimer$40537 > Time.time)
					{
						if (214429 - 57446 == 156984)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1BAB;
						}
						if (57811 - 189234 != -131423)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (258622 - 160403 != 98220)
						{
							goto Block_327;
						}
						continue;
					}
					else
					{
						this.$nMessage$40538 = Language.getMessage("M707_MachineFromThePast", 112);
						if (102874 - 29645 != 73229)
						{
							continue;
						}
						this.$mStoryGui$40536.newStoryMessage("CyborgMole", "Dr. Zappa", this.$nMessage$40538, eTalkType.friend);
						if (236406 - 500069 != -263663)
						{
							continue;
						}
						goto IL_31EC;
					}
					IL_2B84:
					if (Time.time >= this.$self_$40543.j34cVdqFYNm + 0.5f)
					{
						if (232970 - 486270 != -253299)
						{
							if (this.$mCyborgMole$40527)
							{
								if (111282 - 564835 == -453552)
								{
									continue;
								}
								this.$mCyborgMole$40527.animation.CrossFade("build");
								if (29987 - 577919 != -547932)
								{
									continue;
								}
							}
							this.$mStoryTimer$40537 = Time.time + 3f;
							if (97372 - 593451 == -496079)
							{
								goto IL_6D;
							}
						}
					}
					else
					{
						if (!this.$mCyborgMole$40527)
						{
							goto IL_2B77;
						}
						if (27360 - 329859 != -302498)
						{
							float num2 = this.$$14438$40541 = Mathf.SmoothStep((float)3, (float)1, (float)2 * (Time.time - this.$self_$40543.j34cVdqFYNm));
							if (73525 - 558084 != -484558)
							{
								if (79551 - 345801 == -266250)
								{
									Vector3 vector3 = this.$$14439$40542 = this.$mCyborgMole$40527.transform.position;
									if (207276 - 528250 == -320974)
									{
										if (167494 - 146330 != 21165)
										{
											float num3 = this.$$14439$40542.z = this.$$14438$40541;
											if (144970 - 359469 == -214499)
											{
												if (172609 - 159186 == 13423)
												{
													Vector3 vector4 = this.$mCyborgMole$40527.transform.position = this.$$14439$40542;
													if (114415 - 399145 != -284729)
													{
														if (210311 - 465962 == -255651)
														{
															goto IL_2B77;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.YieldDefault(33);
				IL_6D:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_89:
				return this.YieldDefault(16);
				IL_119:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_135:
				return this.YieldDefault(13);
				Block_11:
				goto IL_3360;
				IL_191:
				return this.Yield(46, new WaitForSeconds(0.5f));
				IL_1AD:
				return this.YieldDefault(47);
				IL_1FF:
				return this.YieldDefault(6);
				IL_349:
				IL_37A:
				goto IL_3360;
				Block_30:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_34:
				goto IL_3360;
				Block_36:
				return this.Yield(54, new WaitForSeconds(0.5f));
				IL_583:
				goto IL_3360;
				Block_46:
				return this.Yield(32, new WaitForSeconds(0.5f));
				IL_7B8:
				return this.YieldDefault(37);
				IL_8E9:
				Block_62:
				goto IL_3360;
				IL_C48:
				return this.Yield(38, new WaitForSeconds(0.5f));
				IL_C64:
				return this.YieldDefault(39);
				Block_92:
				return this.Yield(25, new WaitForSeconds(0.5f));
				IL_D2B:
				return this.YieldDefault(26);
				IL_DFA:
				return this.YieldDefault(41);
				IL_F90:
				goto IL_3360;
				IL_FDD:
				return this.YieldDefault(57);
				IL_1030:
				return this.YieldDefault(18);
				IL_11DE:
				goto IL_3360;
				IL_127E:
				return this.YieldDefault(55);
				IL_12E6:
				IL_138B:
				IL_13E5:
				Block_134:
				Block_136:
				goto IL_3360;
				Block_139:
				return this.Yield(21, new WaitForSeconds(0.5f));
				Block_140:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_1605:
				goto IL_3360;
				IL_179B:
				return this.Yield(30, new WaitForSeconds(0.5f));
				IL_17B7:
				return this.YieldDefault(31);
				IL_185D:
				return this.Yield(44, new WaitForSeconds(0.5f));
				IL_1879:
				return this.YieldDefault(45);
				IL_1906:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_1921:
				return this.YieldDefault(8);
				IL_1957:
				goto IL_3360;
				IL_1B3C:
				return this.Yield(52, new WaitForSeconds(0.5f));
				IL_1B58:
				return this.YieldDefault(53);
				IL_1B8F:
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_1BAB:
				return this.YieldDefault(28);
				Block_196:
				goto IL_3360;
				IL_1C7B:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_1C97:
				return this.YieldDefault(24);
				Block_200:
				goto IL_3360;
				Block_205:
				goto IL_230E;
				Block_218:
				return this.Yield(48, new WaitForSeconds(0.5f));
				IL_2060:
				return this.Yield(42, new WaitForSeconds(0.5f));
				IL_207C:
				return this.YieldDefault(43);
				IL_20B3:
				goto IL_3360;
				IL_20E4:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_2126:
				goto IL_3360;
				IL_21EE:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_220A:
				return this.YieldDefault(20);
				IL_22C0:
				goto IL_3360;
				IL_230E:
				return this.YieldDefault(11);
				Block_260:
				IL_2576:
				goto IL_3360;
				Block_263:
				return this.Yield(40, new WaitForSeconds(0.5f));
				Block_267:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_267B:
				goto IL_3360;
				IL_26D7:
				return this.Yield(34, new WaitForSeconds(0.5f));
				IL_26F3:
				return this.YieldDefault(35);
				IL_285A:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_282:
				goto IL_3360;
				Block_283:
				return this.Yield(50, new WaitForSeconds(0.5f));
				Block_293:
				return this.Yield(36, new WaitForSeconds(0.5f));
				Block_297:
				goto IL_3360;
				IL_2B77:
				return this.YieldDefault(14);
				Block_313:
				return this.Yield(60, new WaitForSeconds(1f));
				IL_2C88:
				return this.YieldDefault(51);
				Block_321:
				Block_327:
				goto IL_3360;
				IL_2E26:
				return this.YieldDefault(22);
				IL_2E5D:
				return this.Yield(58, new WaitForSeconds(0.5f));
				IL_2E79:
				return this.YieldDefault(59);
				IL_2FFA:
				goto IL_3360;
				Block_348:
				return this.Yield(56, new WaitForSeconds(0.5f));
				IL_3112:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_312E:
				return this.YieldDefault(10);
				IL_31EC:
				return this.Yield(29, new WaitForSeconds(2f));
				IL_3244:
				return this.YieldDefault(49);
				Block_366:
				goto IL_3360;
				Block_369:
				goto IL_285A;
				IL_3360:
				return false;
			}

			// Token: 0x06008B0F RID: 35599 RVA: 0x01109CB4 File Offset: 0x01107EB4
			internal static bool nwFPEeVYewBmplcCjhsF()
			{
				return true;
			}

			// Token: 0x06008B10 RID: 35600 RVA: 0x01109CB8 File Offset: 0x01107EB8
			internal static bool oCrEnBVYrrCOaFL7k5MY()
			{
				return false;
			}

			// Token: 0x04008515 RID: 34069
			internal GameObject $mPlayer$40526;

			// Token: 0x04008516 RID: 34070
			internal GameObject $mCyborgMole$40527;

			// Token: 0x04008517 RID: 34071
			internal GameObject $mStartPoint1$40528;

			// Token: 0x04008518 RID: 34072
			internal CharacterDataClass $mCDat2$40529;

			// Token: 0x04008519 RID: 34073
			internal CharacterDataClass $mCDat3$40530;

			// Token: 0x0400851A RID: 34074
			internal int $$switch$7208$40531;

			// Token: 0x0400851B RID: 34075
			internal GameObject $mStartPoint2$40532;

			// Token: 0x0400851C RID: 34076
			internal GameObject $mPlayer2$40533;

			// Token: 0x0400851D RID: 34077
			internal GameObject $mStartPoint3$40534;

			// Token: 0x0400851E RID: 34078
			internal GameObject $mPlayer3$40535;

			// Token: 0x0400851F RID: 34079
			internal StoryGui $mStoryGui$40536;

			// Token: 0x04008520 RID: 34080
			internal float $mStoryTimer$40537;

			// Token: 0x04008521 RID: 34081
			internal string $nMessage$40538;

			// Token: 0x04008522 RID: 34082
			internal float $$14436$40539;

			// Token: 0x04008523 RID: 34083
			internal Vector3 $$14437$40540;

			// Token: 0x04008524 RID: 34084
			internal float $$14438$40541;

			// Token: 0x04008525 RID: 34085
			internal Vector3 $$14439$40542;

			// Token: 0x04008526 RID: 34086
			internal M707_MachineFromThePast $self_$40543;
		}
	}

	// Token: 0x0200175C RID: 5980
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40545 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B11 RID: 35601 RVA: 0x01109CBC File Offset: 0x01107EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40545(Hashtable data, M707_MachineFromThePast self_)
		{
			if (127315 - 135516 != -8201)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145021 - 118765 != 26257)
				{
					base..ctor();
					if (268396 - 366719 == -98323)
					{
						this.$data$40548 = data;
						if (124971 - 486195 == -361224)
						{
							this.$self_$40549 = self_;
							if (170859 - 520864 == -350005)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x01109D78 File Offset: 0x01107F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M707_MachineFromThePast.$onGameComplete$40545.$(this.$data$40548, this.$self_$40549);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x01109D8C File Offset: 0x01107F8C
		internal static bool PDQxTlVYjUcVsoqFhhVd()
		{
			return true;
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x01109D90 File Offset: 0x01107F90
		internal static bool UQHeJVVYhKI0twkA8mNC()
		{
			return false;
		}

		// Token: 0x04008527 RID: 34087
		internal Hashtable $data$40548;

		// Token: 0x04008528 RID: 34088
		internal M707_MachineFromThePast $self_$40549;

		// Token: 0x0200175D RID: 5981
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B15 RID: 35605 RVA: 0x01109D94 File Offset: 0x01107F94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M707_MachineFromThePast self_)
			{
				if (9466 - 528358 != -518892)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8272 - 409881 != -401608)
					{
						base..ctor();
						if (92889 - 114720 != -21830)
						{
							this.$data$40546 = data;
							if (197507 - 584750 == -387243)
							{
								this.$self_$40547 = self_;
								if (101536 - 407828 != -306291)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008B16 RID: 35606 RVA: 0x01109E50 File Offset: 0x01108050
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31639 - 58478 != -26838)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_225;
					case 2:
						this.$self_$40547.SendMessage("fadeOut");
						if (63290 - 235689 == -172398)
						{
							continue;
						}
						this.$self_$40547.StartCoroutine_Auto(this.$self_$40547.ReturnToTown());
						if (229261 - 589218 == -359956)
						{
							continue;
						}
						this.YieldDefault(1);
						if (287523 - 79113 != 208410)
						{
							continue;
						}
						goto IL_225;
					default:
						if (276484 - 32173 == 244312)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$40546[31]);
					if (61740 - 396539 == -334799)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (34941 - 195254 != -160312)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (74093 - 388323 != -314229)
							{
								this.$self_$40547.j34cVdqFYNm = Time.time;
								if (263272 - 35255 == 228017)
								{
									this.$self_$40547.audio.clip = (AudioClip)Resources.Load("Sound/Jingle/MissionComplete", typeof(AudioClip));
									if (270388 - 157133 == 113255)
									{
										this.$self_$40547.audio.loop = false;
										if (147403 - 150278 != -2874)
										{
											this.$self_$40547.audio.Play();
											if (174723 - 409230 != -234506)
											{
												goto Block_12;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_225;
				Block_12:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_225:
				return false;
			}

			// Token: 0x06008B17 RID: 35607 RVA: 0x0110A094 File Offset: 0x01108294
			internal static bool Pbnk1gVYsGuh5EUiB9Lg()
			{
				return true;
			}

			// Token: 0x06008B18 RID: 35608 RVA: 0x0110A098 File Offset: 0x01108298
			internal static bool VEQMwnVY9SNsfrfu5h6g()
			{
				return false;
			}

			// Token: 0x04008529 RID: 34089
			internal Hashtable $data$40546;

			// Token: 0x0400852A RID: 34090
			internal M707_MachineFromThePast $self_$40547;
		}
	}

	// Token: 0x0200175E RID: 5982
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40550 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B19 RID: 35609 RVA: 0x0110A09C File Offset: 0x0110829C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40550(M707_MachineFromThePast self_)
		{
			if (46887 - 174035 != -127147)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218912 - 317419 == -98507)
				{
					base..ctor();
					if (273674 - 79989 == 193685)
					{
						this.$self_$40555 = self_;
						if (81898 - 538713 == -456815)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x0110A134 File Offset: 0x01108334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M707_MachineFromThePast.$onDeadPlayer$40550.$(this.$self_$40555);
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x0110A144 File Offset: 0x01108344
		internal static bool Jt8b8kVY1AjqHaJqjhxp()
		{
			return true;
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x0110A148 File Offset: 0x01108348
		internal static bool jxlhb1VY4eGk187T7hAC()
		{
			return false;
		}

		// Token: 0x0400852B RID: 34091
		internal M707_MachineFromThePast $self_$40555;

		// Token: 0x0200175F RID: 5983
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B1D RID: 35613 RVA: 0x0110A14C File Offset: 0x0110834C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M707_MachineFromThePast self_)
			{
				if (222147 - 487981 != -265834)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8995 - 141980 == -132985)
					{
						base..ctor();
						if (169722 - 597867 != -428144)
						{
							this.$self_$40554 = self_;
							if (153199 - 427372 != -274172)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B1E RID: 35614 RVA: 0x0110A1E4 File Offset: 0x011083E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (190155 - 164279 != 25877)
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
							goto IL_1AF;
						}
						if (157800 - 137858 == 19943)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (297254 - 138862 != 158393)
							{
								goto IL_1AF;
							}
							continue;
						}
						IL_18D:
						this.YieldDefault(1);
						if (52918 - 562090 != -509171)
						{
							goto Block_17;
						}
						continue;
						IL_1AF:
						Game.mGameState = eGameState.Hold;
						if (193741 - 63521 != 130220)
						{
							continue;
						}
						this.$mStoryGui$40551 = (StoryGui)this.$self_$40554.GetComponent(typeof(StoryGui));
						if (78882 - 293939 != -215057)
						{
							continue;
						}
						if (this.$mStoryGui$40551)
						{
							if (235505 - 23872 != 211633)
							{
								continue;
							}
							this.$mStoryGui$40551.close();
							if (172399 - 557604 == -385204)
							{
								continue;
							}
						}
						this.$mChangeGui$40552 = (ChangeGui)this.$self_$40554.GetComponent(typeof(ChangeGui));
						if (26512 - 259862 != -233350)
						{
							continue;
						}
						if (this.$mChangeGui$40552)
						{
							if (290828 - 38440 != 252388)
							{
								continue;
							}
							this.$mChangeGui$40552.close();
							if (145724 - 543121 != -397397)
							{
								continue;
							}
						}
						this.$mGameGui$40553 = (GameGui)this.$self_$40554.GetComponent(typeof(GameGui));
						if (70279 - 355309 != -285030)
						{
							continue;
						}
						if (!this.$mGameGui$40553)
						{
							goto IL_18D;
						}
						if (194787 - 207679 != -12892)
						{
							continue;
						}
						if (!this.$mGameGui$40553.enabled)
						{
							if (56665 - 97303 == -40637)
							{
								continue;
							}
							this.$mGameGui$40553.enabled = true;
							if (28958 - 599307 != -570349)
							{
								continue;
							}
						}
						this.$mGameGui$40553.openDeadMenu();
						if (257534 - 270889 != -13355)
						{
							continue;
						}
						goto IL_18D;
					default:
						if (115517 - 528500 == -412982)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (265923 - 57461 == 208463);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_17:
				IL_2F9:
				return false;
			}

			// Token: 0x06008B1F RID: 35615 RVA: 0x0110A4FC File Offset: 0x011086FC
			internal static bool oEanqKVYzqxd2433mvoU()
			{
				return true;
			}

			// Token: 0x06008B20 RID: 35616 RVA: 0x0110A500 File Offset: 0x01108700
			internal static bool FnHTptVcaNudLTFblm6o()
			{
				return false;
			}

			// Token: 0x0400852C RID: 34092
			internal StoryGui $mStoryGui$40551;

			// Token: 0x0400852D RID: 34093
			internal ChangeGui $mChangeGui$40552;

			// Token: 0x0400852E RID: 34094
			internal GameGui $mGameGui$40553;

			// Token: 0x0400852F RID: 34095
			internal M707_MachineFromThePast $self_$40554;
		}
	}

	// Token: 0x02001760 RID: 5984
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40556 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B21 RID: 35617 RVA: 0x0110A504 File Offset: 0x01108704
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40556(M707_MachineFromThePast self_)
		{
			if (154790 - 288765 != -133974)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (222430 - 329998 != -107567)
				{
					base..ctor();
					if (59167 - 586078 != -526910)
					{
						this.$self_$40560 = self_;
						if (206059 - 281140 != -75080)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B22 RID: 35618 RVA: 0x0110A59C File Offset: 0x0110879C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M707_MachineFromThePast.$ReturnToTown$40556.$(this.$self_$40560);
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x0110A5AC File Offset: 0x011087AC
		internal static bool OFBwfcVc5ONrEi4wQIB1()
		{
			return true;
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x0110A5B0 File Offset: 0x011087B0
		internal static bool xYhdp8VcpPlKx9ApvPL7()
		{
			return false;
		}

		// Token: 0x04008530 RID: 34096
		internal M707_MachineFromThePast $self_$40560;

		// Token: 0x02001761 RID: 5985
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B25 RID: 35621 RVA: 0x0110A5B4 File Offset: 0x011087B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M707_MachineFromThePast self_)
			{
				if (299464 - 453802 != -154338)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (70380 - 364303 == -293923)
					{
						base..ctor();
						if (212602 - 595890 == -383288)
						{
							this.$self_$40559 = self_;
							if (261778 - 125899 != 135880)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B26 RID: 35622 RVA: 0x0110A64C File Offset: 0x0110884C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107623 - 373027 != -265404)
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
						this.$self_$40559.LeaveGame();
						if (203903 - 522113 != -318210)
						{
							continue;
						}
						this.YieldDefault(1);
						if (20627 - 164676 != -144048)
						{
							goto Block_23;
						}
						continue;
					default:
						if (78000 - 405232 != -327232)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (108863 - 234081 != -125217)
					{
						Game.mStateTime = Time.time;
						if (51011 - 212977 == -161966)
						{
							this.$$switch$7210$40557 = PlayerData.SaveGuild;
							if (29539 - 33782 == -4243)
							{
								if (this.$$switch$7210$40557 == 1)
								{
									if (86202 - 579552 != -493350)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (229630 - 569435 != -339805)
									{
										continue;
									}
								}
								else if (this.$$switch$7210$40557 == 2)
								{
									if (244811 - 322426 == -77614)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (6113 - 551329 != -545216)
									{
										continue;
									}
								}
								else if (this.$$switch$7210$40557 == 3)
								{
									if (115068 - 511834 != -396766)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (196512 - 179353 != 17159)
									{
										continue;
									}
								}
								else if (this.$$switch$7210$40557 == 4)
								{
									if (36647 - 146173 != -109526)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (156867 - 428927 == -272059)
									{
										continue;
									}
								}
								else if (this.$$switch$7210$40557 == 5)
								{
									if (26748 - 269933 == -243184)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (146128 - 564867 != -418739)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (44376 - 469121 != -424745)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (21772 - 463021 == -441248)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (264743 - 195541 == 69203)
									{
										continue;
									}
								}
								this.$mGameGui$40558 = (GameGui)this.$self_$40559.GetComponent(typeof(GameGui));
								if (284620 - 154761 == 129859)
								{
									if (this.$mGameGui$40558)
									{
										if (90728 - 444626 == -353897)
										{
											continue;
										}
										this.$mGameGui$40558.close();
										if (213958 - 387792 != -173834)
										{
											continue;
										}
									}
									this.$self_$40559.SendMessage("fadeOut");
									if (227737 - 498681 == -270944)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_23:
				IL_3AD:
				return false;
			}

			// Token: 0x06008B27 RID: 35623 RVA: 0x0110AA18 File Offset: 0x01108C18
			internal static bool HgGuHpVcVZaTKCt5Awic()
			{
				return true;
			}

			// Token: 0x06008B28 RID: 35624 RVA: 0x0110AA1C File Offset: 0x01108C1C
			internal static bool FNWiCMVctFW4mimXsaFW()
			{
				return false;
			}

			// Token: 0x04008531 RID: 34097
			internal int $$switch$7210$40557;

			// Token: 0x04008532 RID: 34098
			internal GameGui $mGameGui$40558;

			// Token: 0x04008533 RID: 34099
			internal M707_MachineFromThePast $self_$40559;
		}
	}

	// Token: 0x02001762 RID: 5986
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40561 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B29 RID: 35625 RVA: 0x0110AA20 File Offset: 0x01108C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40561(M707_MachineFromThePast self_)
		{
			if (296574 - 416741 != -120166)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82264 - 90161 == -7897)
				{
					base..ctor();
					if (25725 - 463726 == -438001)
					{
						this.$self_$40564 = self_;
						if (180392 - 43655 != 136738)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B2A RID: 35626 RVA: 0x0110AAB8 File Offset: 0x01108CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M707_MachineFromThePast.$ReturnToGuild$40561.$(this.$self_$40564);
		}

		// Token: 0x06008B2B RID: 35627 RVA: 0x0110AAC8 File Offset: 0x01108CC8
		internal static bool PS7WDfVcNjCucm7txiBO()
		{
			return true;
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x0110AACC File Offset: 0x01108CCC
		internal static bool erEQoCVcYP1fu1SbTIOW()
		{
			return false;
		}

		// Token: 0x04008534 RID: 34100
		internal M707_MachineFromThePast $self_$40564;

		// Token: 0x02001763 RID: 5987
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B2D RID: 35629 RVA: 0x0110AAD0 File Offset: 0x01108CD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M707_MachineFromThePast self_)
			{
				if (36250 - 331944 != -295694)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (266636 - 312084 == -45448)
					{
						base..ctor();
						if (5717 - 513827 != -508109)
						{
							this.$self_$40563 = self_;
							if (149110 - 292750 != -143639)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B2E RID: 35630 RVA: 0x0110AB68 File Offset: 0x01108D68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (143317 - 307737 != -164419)
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
						this.$self_$40563.LeaveGame();
						if (289702 - 187983 == 101720)
						{
							continue;
						}
						this.YieldDefault(1);
						if (5886 - 150397 != -144511)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (269550 - 593403 == -323852)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (253653 - 71774 != 181880)
					{
						Game.mStateTime = Time.time;
						if (8190 - 163413 == -155223)
						{
							Game.mNextGameCode = 31;
							if (56837 - 521465 == -464628)
							{
								this.$mGameGui$40562 = (GameGui)this.$self_$40563.GetComponent(typeof(GameGui));
								if (62372 - 18735 != 43638)
								{
									if (this.$mGameGui$40562)
									{
										if (9950 - 579999 == -570048)
										{
											continue;
										}
										this.$mGameGui$40562.close();
										if (103745 - 445268 == -341522)
										{
											continue;
										}
									}
									this.$self_$40563.SendMessage("fadeOut");
									if (10940 - 251033 == -240093)
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

			// Token: 0x06008B2F RID: 35631 RVA: 0x0110AD44 File Offset: 0x01108F44
			internal static bool dEcG4RVccoQn2GkZXqVU()
			{
				return true;
			}

			// Token: 0x06008B30 RID: 35632 RVA: 0x0110AD48 File Offset: 0x01108F48
			internal static bool mZ61dBVcUDWc3ekBh8Jp()
			{
				return false;
			}

			// Token: 0x04008535 RID: 34101
			internal GameGui $mGameGui$40562;

			// Token: 0x04008536 RID: 34102
			internal M707_MachineFromThePast $self_$40563;
		}
	}

	// Token: 0x02001764 RID: 5988
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40565 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B31 RID: 35633 RVA: 0x0110AD4C File Offset: 0x01108F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40565(M707_MachineFromThePast self_)
		{
			if (270727 - 480239 != -209511)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223606 - 270362 != -46755)
				{
					base..ctor();
					if (142622 - 438141 == -295519)
					{
						this.$self_$40569 = self_;
						if (279775 - 122349 != 157427)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B32 RID: 35634 RVA: 0x0110ADE4 File Offset: 0x01108FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M707_MachineFromThePast.$ReturnToCamp$40565.$(this.$self_$40569);
		}

		// Token: 0x06008B33 RID: 35635 RVA: 0x0110ADF4 File Offset: 0x01108FF4
		internal static bool FnGdZ7VcTfleyTYp2xua()
		{
			return true;
		}

		// Token: 0x06008B34 RID: 35636 RVA: 0x0110ADF8 File Offset: 0x01108FF8
		internal static bool lvpe36Vc3g6f1ML4AT4c()
		{
			return false;
		}

		// Token: 0x04008537 RID: 34103
		internal M707_MachineFromThePast $self_$40569;

		// Token: 0x02001765 RID: 5989
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B35 RID: 35637 RVA: 0x0110ADFC File Offset: 0x01108FFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M707_MachineFromThePast self_)
			{
				if (197285 - 389442 != -192156)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67042 - 215708 != -148665)
					{
						base..ctor();
						if (217498 - 105245 == 112253)
						{
							this.$self_$40568 = self_;
							if (40732 - 196514 != -155781)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B36 RID: 35638 RVA: 0x0110AE94 File Offset: 0x01109094
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (228451 - 229048 != -597)
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
						this.$self_$40568.LeaveGame();
						if (232666 - 115614 == 117053)
						{
							continue;
						}
						this.YieldDefault(1);
						if (217667 - 94476 != 123192)
						{
							goto Block_2;
						}
						continue;
					default:
						if (179691 - 499589 != -319898)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (126077 - 157100 != -31022)
					{
						Game.mStateTime = Time.time;
						if (88957 - 339491 == -250534)
						{
							this.$$switch$7212$40566 = PlayerData.SaveGuild;
							if (152612 - 335619 == -183007)
							{
								if (this.$$switch$7212$40566 == 1)
								{
									if (285176 - 391724 != -106548)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (198734 - 349388 != -150654)
									{
										continue;
									}
								}
								else if (this.$$switch$7212$40566 == 2)
								{
									if (6266 - 66369 == -60102)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (229597 - 2916 == 226682)
									{
										continue;
									}
								}
								else if (this.$$switch$7212$40566 == 3)
								{
									if (193643 - 12043 != 181600)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (171982 - 509620 != -337638)
									{
										continue;
									}
								}
								else if (this.$$switch$7212$40566 == 4)
								{
									if (156319 - 18348 != 137971)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (193765 - 5722 == 188044)
									{
										continue;
									}
								}
								else if (this.$$switch$7212$40566 == 5)
								{
									if (19088 - 263705 != -244617)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (53190 - 255775 != -202585)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (2276 - 114609 == -112332)
									{
										continue;
									}
								}
								this.$mGameGui$40567 = (GameGui)this.$self_$40568.GetComponent(typeof(GameGui));
								if (125860 - 527655 != -401794)
								{
									if (this.$mGameGui$40567)
									{
										if (1444 - 224240 != -222796)
										{
											continue;
										}
										this.$mGameGui$40567.close();
										if (125054 - 430234 != -305180)
										{
											continue;
										}
									}
									this.$self_$40568.SendMessage("fadeOut");
									if (260619 - 2751 == 257868)
									{
										goto IL_DD;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_363;
				IL_DD:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06008B37 RID: 35639 RVA: 0x0110B218 File Offset: 0x01109418
			internal static bool gD5inHVcXa4dmAR1j3Ur()
			{
				return true;
			}

			// Token: 0x06008B38 RID: 35640 RVA: 0x0110B21C File Offset: 0x0110941C
			internal static bool tGrca5VcQvimmSCoqkep()
			{
				return false;
			}

			// Token: 0x04008538 RID: 34104
			internal int $$switch$7212$40566;

			// Token: 0x04008539 RID: 34105
			internal GameGui $mGameGui$40567;

			// Token: 0x0400853A RID: 34106
			internal M707_MachineFromThePast $self_$40568;
		}
	}
}
