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

// Token: 0x02001ABF RID: 6847
[Serializable]
public class M932_WindHollow1 : MonoBehaviour
{
	// Token: 0x06009FBF RID: 40895 RVA: 0x012579FC File Offset: 0x01255BFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M932_WindHollow1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009FC0 RID: 40896 RVA: 0x01257A0C File Offset: 0x01255C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (156128 - 454526 != -298398)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (158630 - 497119 == -338489)
			{
				Game.mGameType = 5;
				if (22481 - 296418 != -273936)
				{
					if (Chat.Initialized)
					{
						if (295703 - 352909 != -57205)
						{
							Chat.ChatDisplay.Clear();
							if (83172 - 39292 != 43881)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (277071 - 225196 != 51876)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FC1 RID: 40897 RVA: 0x01257AF0 File Offset: 0x01255CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (174583 - 16134 != 158450)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (39186 - 234826 != -195639)
				{
					if (Game.mNextGameCode != 932)
					{
						break;
					}
					if (93455 - 556056 != -462600)
					{
						Game.nextGame();
						if (199671 - 61602 != 138070)
						{
							Game.mGameCode = 932;
							if (180924 - 93044 == 87880)
							{
								Game.mGameType = 5;
								if (288918 - 262859 != 26060)
								{
									Game.mGameTime = Time.time;
									if (130886 - 450806 == -319920)
									{
										Game.mGameScore = 0;
										if (165354 - 242244 == -76890)
										{
											Game.mGameMana = 0;
											if (1086 - 220736 != -219649)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (199326 - 454162 == -254836)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (54631 - 135680 == -81049)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (202058 - 267053 == -64995)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (209378 - 293773 != -84394)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (263031 - 21140 == 241891)
																{
																	this.OSinJ2EUrmm = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (183193 - 515674 == -332481)
																	{
																		this.iRHnJONuRql = PhotonClient.Connection;
																		if (280419 - 550364 == -269945)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (91429 - 573210 != -481780)
																			{
																				this.InitGame();
																				if (156767 - 530413 == -373646)
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
				if (223992 - 22184 == 201808)
				{
					Game.mGameType = 99;
					if (181462 - 138696 == 42766)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009FC2 RID: 40898 RVA: 0x01257DF8 File Offset: 0x01255FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (1237 - 43961 != -42724)
		{
		}
		for (;;)
		{
			if (this.iRHnJONuRql == null)
			{
				if (186408 - 555666 != -369257)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (82055 - 196444 == -114389)
				{
					if (mGameState == eGameState.Init)
					{
						if (196308 - 471702 != -275393)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (58032 - 422554 != -364521)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (245562 - 474257 != -228694)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (184883 - 107227 != 77657)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (184478 - 81160 != 103319)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (108255 - 379660 != -271404)
						{
							if (Game.music != 0)
							{
								if (1136 - 213513 != -212377)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (164887 - 185140 == -20252)
									{
										continue;
									}
									this.audio.Play();
									if (245026 - 592204 != -347178)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (173390 - 575373 == -401982)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (174749 - 398860 == -224110)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (52964 - 181586 != -128622)
								{
									continue;
								}
							}
							if (Time.time <= this.uWXnJvltM77)
							{
								break;
							}
							if (19404 - 408814 == -389410)
							{
								Game.mGameMana++;
								if (211901 - 492692 != -280790)
								{
									this.uWXnJvltM77 = Time.time + (float)12;
									if (168225 - 408193 != -239967)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (153773 - 242363 == -88590)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (34768 - 222917 == -188149)
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
						if (296212 - 433125 != -136912)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FC3 RID: 40899 RVA: 0x0125816C File Offset: 0x0125636C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (273562 - 139246 != 134317)
		{
		}
		for (;;)
		{
			if (!this.mqLnJla1pX4)
			{
				if (225691 - 405357 == -179666)
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
				if (279161 - 351927 == -72766)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (245947 - 300824 == -54877)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (296102 - 106975 != 189128)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (154441 - 62461 != 91981)
							{
								GUI.depth = 1;
								if (15020 - 516873 != -501852)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (121259 - 525176 == -403917)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (17732 - 387933 != -370200)
										{
											Color color = GUI.color;
											if (72144 - 145072 == -72928)
											{
												float num3 = color.a = a;
												if (123638 - 503436 == -379798)
												{
													if (150529 - 528918 == -378389)
													{
														GUI.color = color;
														if (46877 - 122312 != -75434)
														{
															if (82166 - 250969 == -168803)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.mqLnJla1pX4);
																if (217389 - 44464 != 172926)
																{
																	float a2 = 1f;
																	if (153454 - 115620 == 37834)
																	{
																		Color color2 = GUI.color;
																		if (17206 - 56350 == -39144)
																		{
																			color2.a = a2;
																			if (122460 - 38071 == 84389)
																			{
																				if (63638 - 378554 != -314915)
																				{
																					GUI.color = color2;
																					if (281112 - 398207 != -117094 && 47924 - 469942 != -422017)
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

	// Token: 0x06009FC4 RID: 40900 RVA: 0x012584EC File Offset: 0x012566EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M932_WindHollow1.$onGameEvent$43352(data, this).GetEnumerator();
	}

	// Token: 0x06009FC5 RID: 40901 RVA: 0x012584FC File Offset: 0x012566FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M932_WindHollow1.$StartEvent$43362(this).GetEnumerator();
	}

	// Token: 0x06009FC6 RID: 40902 RVA: 0x0125850C File Offset: 0x0125670C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniCat()
	{
		return new M932_WindHollow1.$TalkToMiniCat$43369(this).GetEnumerator();
	}

	// Token: 0x06009FC7 RID: 40903 RVA: 0x0125851C File Offset: 0x0125671C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniSheep()
	{
		return new M932_WindHollow1.$TalkToMiniSheep$43378(this).GetEnumerator();
	}

	// Token: 0x06009FC8 RID: 40904 RVA: 0x0125852C File Offset: 0x0125672C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther()
	{
		return new M932_WindHollow1.$TalkToPanther$43387(this).GetEnumerator();
	}

	// Token: 0x06009FC9 RID: 40905 RVA: 0x0125853C File Offset: 0x0125673C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWindHollowExit()
	{
		if (297780 - 263271 != 34509)
		{
		}
		while (this.uZdnJGKqCga < 1)
		{
			if (42673 - 7358 != 35316)
			{
				this.uZdnJGKqCga = 1;
				if (297358 - 325004 == -27646)
				{
					Game.sendMissionEvent(9321, 2);
					if (13391 - 143 == 13248)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009FCA RID: 40906 RVA: 0x012585E0 File Offset: 0x012567E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (231337 - 574884 != -343546)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (201754 - 102016 != 99739)
			{
				Time.timeScale = 1f;
				if (154815 - 241559 == -86744)
				{
					this.mqLnJla1pX4 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (270596 - 443793 != -173196)
					{
						Hashtable customOpParameters = new Hashtable();
						if (97693 - 569947 != -472253)
						{
							this.iRHnJONuRql.OpCustom(52, customOpParameters, true);
							if (29401 - 393008 == -363607)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FCB RID: 40907 RVA: 0x012586E4 File Offset: 0x012568E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (181030 - 62085 != 118946)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (131993 - 146917 != -14923)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (130993 - 30960 == 100033)
				{
					Game.mGameState = eGameState.Setup;
					if (24018 - 162422 != -138403)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009FCC RID: 40908 RVA: 0x01258788 File Offset: 0x01256988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (211285 - 503573 != -292288)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (286421 - 79478 != 206944)
			{
				if (num == PlayerData.UID)
				{
					if (211341 - 31074 != 180268)
					{
						this.SetupActors();
						if (179775 - 554369 != -374593)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (153102 - 221816 == -68714)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009FCD RID: 40909 RVA: 0x01258858 File Offset: 0x01256A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (84982 - 269928 != -184946)
		{
		}
		for (;;)
		{
			IL_42:
			Debug.Log("Creating Actors");
			if (246980 - 440991 != -194010)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (22880 - 479285 == -456405)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (268558 - 460542 != -191983)
						{
							int i = 0;
							if (263671 - 222351 == 41320)
							{
								CharacterControl[] array2 = array;
								if (250450 - 477498 != -227047)
								{
									int length = array2.Length;
									if (207825 - 508473 != -300647)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (266301 - 346814 != -80513)
												{
													goto IL_42;
												}
												string type = array2[i].Type;
												if (4256 - 45383 != -41127)
												{
													goto IL_42;
												}
												if (type == "SilverBug")
												{
													goto IL_244;
												}
												if (128044 - 226699 == -98654)
												{
													goto IL_42;
												}
												if (type == "Ja4")
												{
													goto IL_244;
												}
												if (45218 - 205026 != -159808)
												{
													goto IL_42;
												}
												if (type == "Ja5")
												{
													goto IL_244;
												}
												if (188225 - 129743 != 58482)
												{
													goto IL_42;
												}
												if (type == "Ja6")
												{
													if (274632 - 447976 != -173344)
													{
														goto IL_42;
													}
													goto IL_244;
												}
												IL_93:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (44677 - 99370 != -54693)
												{
													goto IL_42;
												}
												this.VbunJ1sDwsr++;
												if (275239 - 120175 != 155064)
												{
													goto IL_42;
												}
												goto IL_130;
												IL_244:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (28430 - 77584 != -49153)
												{
													goto IL_93;
												}
												goto IL_42;
											}
											IL_130:
											i++;
											if (94823 - 157046 == -62222)
											{
												goto IL_42;
											}
										}
										if (295837 - 581974 != -286136)
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
						if (94068 - 134839 == -40771)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FCE RID: 40910 RVA: 0x01258B74 File Offset: 0x01256D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (58662 - 473418 != -414756)
		{
		}
		for (;;)
		{
			IL_86:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (189452 - 538284 != -348831)
			{
				int i = 0;
				if (289597 - 8262 == 281335)
				{
					CharacterControl[] array2 = array;
					if (265027 - 544036 == -279009)
					{
						int length = array2.Length;
						if (224260 - 69878 == 154382)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (39535 - 253144 == -213608)
								{
									goto IL_86;
								}
								i++;
								if (42280 - 527538 != -485258)
								{
									goto IL_86;
								}
							}
							if (295777 - 289573 == 6204)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FCF RID: 40911 RVA: 0x01258CA4 File Offset: 0x01256EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (229397 - 591154 != -361756)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (204525 - 252000 != -47474)
			{
				Game.mGameState = eGameState.Ready;
				if (105740 - 480213 != -374472)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (83941 - 466860 == -382919)
					{
						if (139962 - 134712 != 5251)
						{
							GameObject gameObject;
							if (playerSlot >= 1)
							{
								if (128585 - 231279 == -102693)
								{
									continue;
								}
								if (playerSlot <= 12)
								{
									if (128267 - 487179 != -358912)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint" + playerSlot);
									if (191619 - 253548 != -61929)
									{
										continue;
									}
									goto IL_1E4;
								}
							}
							gameObject = GameObject.Find("StartPoint1");
							if (209340 - 35441 == 173900)
							{
								continue;
							}
							IL_1E4:
							if (!gameObject)
							{
								break;
							}
							if (51641 - 317634 != -265992)
							{
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (108798 - 589377 != -480578)
								{
									if (spawnPos != Vector3.zero)
									{
										if (62530 - 492471 != -429940)
										{
											this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
											if (170313 - 286843 == -116530)
											{
												break;
											}
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (299346 - 458722 != -159375)
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

	// Token: 0x06009FD0 RID: 40912 RVA: 0x01258EF8 File Offset: 0x012570F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (120812 - 347380 != -226568)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (93399 - 354926 == -261527)
			{
				Game.mGameState = eGameState.Start;
				if (70632 - 547957 == -477325)
				{
					Game.mGameTime = Time.time;
					if (116045 - 263926 != -147880)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (38084 - 279545 == -241461)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FD1 RID: 40913 RVA: 0x01258FC0 File Offset: 0x012571C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009FD2 RID: 40914 RVA: 0x01258FC4 File Offset: 0x012571C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (109910 - 430861 != -320951)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (154140 - 328592 == -174452)
			{
				if (gameObject)
				{
					if (17806 - 472080 == -454274)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (120623 - 543082 == -422459)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (165721 - 372315 != -206593)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009FD3 RID: 40915 RVA: 0x012590C0 File Offset: 0x012572C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (38058 - 170603 != -132544)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (220479 - 179721 != 40759)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (70611 - 380000 != -309388)
				{
					hashtable.Add(43, PlayerData.UID);
					if (115414 - 205691 == -90277)
					{
						hashtable.Add(73, nType);
						if (108100 - 511886 == -403786)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (194590 - 6014 == 188576)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (295266 - 139535 == 155731)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (151553 - 497788 == -346235)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (140507 - 257671 == -117164)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (85894 - 31987 == 53907)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (234844 - 525845 == -291001)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (191483 - 209468 == -17985)
													{
														this.iRHnJONuRql.OpCustom(63, hashtable, true);
														if (281906 - 225867 != 56040)
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

	// Token: 0x06009FD4 RID: 40916 RVA: 0x012593A4 File Offset: 0x012575A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (246200 - 40853 != 205347)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (80724 - 107044 != -26319)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (98869 - 11646 != 87224)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (55369 - 321156 != -265786)
						{
							if (this.VbunJ1sDwsr <= 0)
							{
								break;
							}
							if (116330 - 416590 != -300259)
							{
								this.VbunJ1sDwsr--;
								if (61441 - 271788 != -210346)
								{
									if (this.VbunJ1sDwsr != 0)
									{
										break;
									}
									if (73470 - 235434 != -161963)
									{
										Game.setGameState(eGameState.Ready);
										if (178724 - 96312 == 82412)
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
						if (233493 - 167176 == 66317)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (121583 - 219154 == -97571)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FD5 RID: 40917 RVA: 0x01259534 File Offset: 0x01257734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009FD6 RID: 40918 RVA: 0x01259548 File Offset: 0x01257748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (7306 - 227358 != -220052)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (66729 - 521461 != -454731)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (200504 - 56844 == 143660)
				{
					if (!characterControl)
					{
						break;
					}
					if (22785 - 296361 != -273575)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (148850 - 526287 != -377436)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (158536 - 522315 != -363778)
							{
								string type = characterControl.Type;
								if (144272 - 439249 != -294976)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (32344 - 313912 == -281568)
									{
										Game.sendMissionEvent(0, 0);
										if (80087 - 340963 != -260875)
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

	// Token: 0x06009FD7 RID: 40919 RVA: 0x012596BC File Offset: 0x012578BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (291064 - 364916 != -73851)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (117386 - 369356 == -251970)
			{
				hashtable.Add(71, CID);
				if (108081 - 237305 == -129224)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (297177 - 274133 != 23045)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (220375 - 589762 != -369386)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (74110 - 554314 != -480203)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (5308 - 502881 != -497572)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (46819 - 68792 != -21972)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (78607 - 589048 != -510440)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (250104 - 19414 != 230691)
											{
												this.iRHnJONuRql.OpCustom(61, hashtable, true);
												if (123056 - 518953 != -395896)
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

	// Token: 0x06009FD8 RID: 40920 RVA: 0x01259948 File Offset: 0x01257B48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (253679 - 413727 != -160047)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (182125 - 327615 == -145490)
			{
				if (!gameObject)
				{
					break;
				}
				if (175019 - 224629 != -49609)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (180876 - 455624 == -274748)
					{
						playerCameraControl.target = gameObject;
						if (9649 - 213398 != -203748)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (116615 - 326699 == -210084)
								{
									this.StartGame();
									if (286961 - 304360 == -17399)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (181286 - 345305 != -164018)
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

	// Token: 0x06009FD9 RID: 40921 RVA: 0x01259A84 File Offset: 0x01257C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (48440 - 374452 != -326011)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (49703 - 421792 == -372089)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (41226 - 165789 != -124562)
				{
					gameGui.ResetTeamBar();
					if (113946 - 120974 != -7027)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009FDA RID: 40922 RVA: 0x01259B30 File Offset: 0x01257D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M932_WindHollow1.$onDeadPlayer$43396(this).GetEnumerator();
	}

	// Token: 0x06009FDB RID: 40923 RVA: 0x01259B40 File Offset: 0x01257D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (74350 - 135329 != -60979)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (275492 - 161822 != 113671)
			{
				this.OSinJ2EUrmm.target = Game.mPlayer;
				if (276698 - 428254 == -151556)
				{
					this.OSinJ2EUrmm.enabled = true;
					if (199116 - 394633 == -195517)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (294908 - 74031 != 220877)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (87894 - 330883 != -242989)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (118423 - 100188 != 18236)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (80026 - 188102 == -108076)
							{
								if (!gameGui)
								{
									break;
								}
								if (277710 - 539965 == -262255)
								{
									gameGui.enabled = true;
									if (271390 - 520875 == -249485)
									{
										gameGui.closeDeadMenu();
										if (102463 - 2335 != 100129)
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

	// Token: 0x06009FDC RID: 40924 RVA: 0x01259CEC File Offset: 0x01257EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (293173 - 164767 != 128406)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (36603 - 306528 != -269924)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (116358 - 367081 == -250723)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (93586 - 286351 != -192764)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009FDD RID: 40925 RVA: 0x01259DB0 File Offset: 0x01257FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009FDE RID: 40926 RVA: 0x01259DDC File Offset: 0x01257FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (284333 - 128169 != 156165)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (209481 - 179012 == 30469)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (220970 - 1223 != 219748)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (122123 - 402409 != -280285)
					{
						Hashtable hashtable = new Hashtable();
						if (210996 - 256308 == -45312)
						{
							hashtable.Add(43, PlayerData.UID);
							if (290720 - 99650 != 191071)
							{
								hashtable.Add(71, nCID);
								if (36257 - 150470 == -114213)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (15548 - 353552 != -338003)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (290429 - 522739 != -232309)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (101899 - 26810 == 75089)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (252057 - 79857 == 172200)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (61717 - 197461 == -135744)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (184354 - 589337 == -404983)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (133025 - 248646 == -115621)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (103179 - 131122 != -27942)
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

	// Token: 0x06009FDF RID: 40927 RVA: 0x0125A0FC File Offset: 0x012582FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M932_WindHollow1.$onChangePlayer$43402(data, this).GetEnumerator();
	}

	// Token: 0x06009FE0 RID: 40928 RVA: 0x0125A10C File Offset: 0x0125830C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M932_WindHollow1.$onGameComplete$43409(data, this).GetEnumerator();
	}

	// Token: 0x06009FE1 RID: 40929 RVA: 0x0125A11C File Offset: 0x0125831C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M932_WindHollow1.$ReturnToTown$43419(this).GetEnumerator();
	}

	// Token: 0x06009FE2 RID: 40930 RVA: 0x0125A12C File Offset: 0x0125832C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M932_WindHollow1.$ReturnToGuild$43424(this).GetEnumerator();
	}

	// Token: 0x06009FE3 RID: 40931 RVA: 0x0125A13C File Offset: 0x0125833C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M932_WindHollow1.$ReturnToCamp$43428(this).GetEnumerator();
	}

	// Token: 0x06009FE4 RID: 40932 RVA: 0x0125A14C File Offset: 0x0125834C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (89213 - 367515 != -278302)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (186638 - 511258 == -324620)
			{
				Hashtable hashtable = new Hashtable();
				if (214552 - 124641 != 89912)
				{
					hashtable.Add(43, PlayerData.UID);
					if (113968 - 285993 == -172025)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (169367 - 575282 != -405914)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FE5 RID: 40933 RVA: 0x0125A224 File Offset: 0x01258424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009FE6 RID: 40934 RVA: 0x0125A238 File Offset: 0x01258438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (141453 - 369458 != -228005)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (14306 - 517450 != -503143)
			{
				Hashtable hashtable = new Hashtable();
				if (88327 - 555022 != -466694)
				{
					if (Game.mNextGameCode == 30)
					{
						if (124760 - 513677 == -388916)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (142083 - 378978 == -236894)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (195185 - 102115 == 93071)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (111414 - 334964 == -223549)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (39661 - 548368 == -508706)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (56007 - 485613 == -429605)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (181083 - 557573 != -376490)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (296498 - 203632 != 92866)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (214714 - 193228 != 21486)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (251171 - 394722 == -143550)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (189747 - 521909 == -332161)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (68061 - 455173 == -387111)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (298011 - 242767 == 55245)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (205177 - 143679 == 61499)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (120444 - 236006 != -115562)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (42845 - 284366 == -241520)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (128900 - 125238 != 3662)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (30518 - 307654 != -277136)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (192132 - 559093 != -366961)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (222776 - 306129 == -83352)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (287295 - 357792 == -70496)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (100414 - 536311 != -435897)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (226910 - 552194 == -325283)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (176434 - 217080 != -40646)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (112952 - 305007 == -192054)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (151381 - 579084 == -427702)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (27935 - 589582 == -561646)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (13428 - 394344 != -380916)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (237647 - 249619 != -11971)
					{
						this.iRHnJONuRql.OpCustom(42, hashtable, true);
						if (221417 - 78364 == 143053)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009FE7 RID: 40935 RVA: 0x0125A7EC File Offset: 0x012589EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009FE8 RID: 40936 RVA: 0x0125A7FC File Offset: 0x012589FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009FE9 RID: 40937 RVA: 0x0125A800 File Offset: 0x01258A00
	internal static bool evMsZ0VfegOdmNYO3Fum()
	{
		return true;
	}

	// Token: 0x06009FEA RID: 40938 RVA: 0x0125A804 File Offset: 0x01258A04
	internal static bool Q6RRCmVfrLKo1yGcu0JQ()
	{
		return false;
	}

	// Token: 0x04009147 RID: 37191
	private LitePeer iRHnJONuRql;

	// Token: 0x04009148 RID: 37192
	private PlayerCameraControl OSinJ2EUrmm;

	// Token: 0x04009149 RID: 37193
	private float uWXnJvltM77;

	// Token: 0x0400914A RID: 37194
	private Texture mqLnJla1pX4;

	// Token: 0x0400914B RID: 37195
	private int uZdnJGKqCga;

	// Token: 0x0400914C RID: 37196
	private int VbunJ1sDwsr;

	// Token: 0x02001AC0 RID: 6848
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43352 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009FEB RID: 40939 RVA: 0x0125A808 File Offset: 0x01258A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43352(Hashtable data, M932_WindHollow1 self_)
		{
			if (211483 - 494559 != -283075)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185599 - 343524 == -157925)
				{
					base..ctor();
					if (145286 - 530551 != -385264)
					{
						this.$data$43360 = data;
						if (186421 - 129919 == 56502)
						{
							this.$self_$43361 = self_;
							if (42837 - 59361 != -16523)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x0125A8C4 File Offset: 0x01258AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$onGameEvent$43352.$(this.$data$43360, this.$self_$43361);
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x0125A8D8 File Offset: 0x01258AD8
		internal static bool JPLdEJVfjcE5OxBsyNZY()
		{
			return true;
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x0125A8DC File Offset: 0x01258ADC
		internal static bool kn2mvpVfhEjE883pewSh()
		{
			return false;
		}

		// Token: 0x0400914D RID: 37197
		internal Hashtable $data$43360;

		// Token: 0x0400914E RID: 37198
		internal M932_WindHollow1 $self_$43361;

		// Token: 0x02001AC1 RID: 6849
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009FEF RID: 40943 RVA: 0x0125A8E0 File Offset: 0x01258AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M932_WindHollow1 self_)
			{
				if (137730 - 352986 != -215256)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28250 - 194173 == -165923)
					{
						base..ctor();
						if (62460 - 578826 != -516365)
						{
							this.$data$43358 = data;
							if (110063 - 32561 != 77503)
							{
								this.$self_$43359 = self_;
								if (94778 - 190857 != -96078)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009FF0 RID: 40944 RVA: 0x0125A99C File Offset: 0x01258B9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91838 - 534666 != -442828)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_406;
					case 2:
						Game.mGameStage = 2;
						if (284734 - 373343 == -88608)
						{
							continue;
						}
						Application.LoadLevel("M932_WindHollow2");
						if (72276 - 17249 != 55028)
						{
							goto IL_226;
						}
						continue;
					default:
						if (114432 - 510970 == -396537)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (54057 - 297636 != -243579)
						{
							continue;
						}
						goto IL_299;
					}
					else
					{
						this.$returnCode$43353 = RuntimeServices.UnboxInt32(this.$data$43358[141]);
						if (35062 - 139755 != -104693)
						{
							continue;
						}
						this.$returnValue$43354 = RuntimeServices.UnboxInt32(this.$data$43358[145]);
						if (116508 - 84576 != 31932)
						{
							continue;
						}
						this.$ownerID$43355 = RuntimeServices.UnboxInt32(this.$data$43358[43]);
						if (152134 - 448370 == -296235)
						{
							continue;
						}
						this.$$switch$7929$43356 = this.$returnCode$43353;
						if (23041 - 855 == 22187)
						{
							continue;
						}
						if (this.$$switch$7929$43356 == 9321)
						{
							if (217188 - 541941 != -324753)
							{
								continue;
							}
						}
						else if (this.$$switch$7929$43356 == -9321)
						{
							if (131899 - 234543 == -102643)
							{
								continue;
							}
							if (this.$returnValue$43354 == 2)
							{
								if (7575 - 60210 == -52634)
								{
									continue;
								}
								if (this.$self_$43359.uZdnJGKqCga < 2)
								{
									if (183168 - 103408 != 79760)
									{
										continue;
									}
									this.$self_$43359.uZdnJGKqCga = 2;
									if (188269 - 191425 != -3156)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (221889 - 217988 != 3901)
									{
										continue;
									}
									this.$self_$43359.OSinJ2EUrmm.alignToObject("ExitCamera1");
									if (240895 - 420094 == -179198)
									{
										continue;
									}
									this.$mGameGui$43357 = (GameGui)this.$self_$43359.GetComponent(typeof(GameGui));
									if (75515 - 32988 != 42527)
									{
										continue;
									}
									this.$mGameGui$43357.close();
									if (268707 - 78847 == 189861)
									{
										continue;
									}
									Game.savePlayer();
									if (144510 - 595686 != -451176)
									{
										continue;
									}
									this.$self_$43359.SendMessage("fadeOut");
									if (40013 - 523051 != -483038)
									{
										continue;
									}
									this.$self_$43359.OSinJ2EUrmm.StartCoroutine_Auto(this.$self_$43359.OSinJ2EUrmm.slerpToObject("ExitCamera2", (float)1));
									if (284123 - 581935 != -297811)
									{
										break;
									}
									continue;
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43353);
							if (75518 - 51557 != 23961)
							{
								continue;
							}
						}
					}
					IL_301:
					this.YieldDefault(1);
					if (121931 - 376988 != -255057)
					{
						continue;
					}
					goto IL_406;
					IL_226:
					goto IL_301;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_299:
				IL_406:
				return false;
			}

			// Token: 0x06009FF1 RID: 40945 RVA: 0x0125ADC4 File Offset: 0x01258FC4
			internal static bool aGhH7wVfsZQUsVxhE2YK()
			{
				return true;
			}

			// Token: 0x06009FF2 RID: 40946 RVA: 0x0125ADC8 File Offset: 0x01258FC8
			internal static bool qArVDtVf9chOD7k1Q915()
			{
				return false;
			}

			// Token: 0x0400914F RID: 37199
			internal int $returnCode$43353;

			// Token: 0x04009150 RID: 37200
			internal int $returnValue$43354;

			// Token: 0x04009151 RID: 37201
			internal int $ownerID$43355;

			// Token: 0x04009152 RID: 37202
			internal int $$switch$7929$43356;

			// Token: 0x04009153 RID: 37203
			internal GameGui $mGameGui$43357;

			// Token: 0x04009154 RID: 37204
			internal Hashtable $data$43358;

			// Token: 0x04009155 RID: 37205
			internal M932_WindHollow1 $self_$43359;
		}
	}

	// Token: 0x02001AC2 RID: 6850
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43362 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009FF3 RID: 40947 RVA: 0x0125ADCC File Offset: 0x01258FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43362(M932_WindHollow1 self_)
		{
			if (239560 - 173017 != 66544)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (49013 - 308068 == -259055)
				{
					base..ctor();
					if (167610 - 149731 != 17880)
					{
						this.$self_$43368 = self_;
						if (270663 - 187613 != 83051)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x0125AE64 File Offset: 0x01259064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$StartEvent$43362.$(this.$self_$43368);
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x0125AE74 File Offset: 0x01259074
		internal static bool dtmkidVf1HmpMoAAtYew()
		{
			return true;
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x0125AE78 File Offset: 0x01259078
		internal static bool BedjMyVf4VWBDE3j2hVm()
		{
			return false;
		}

		// Token: 0x04009156 RID: 37206
		internal M932_WindHollow1 $self_$43368;

		// Token: 0x02001AC3 RID: 6851
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009FF7 RID: 40951 RVA: 0x0125AE7C File Offset: 0x0125907C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow1 self_)
			{
				if (196673 - 293047 != -96374)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196907 - 340046 != -143138)
					{
						base..ctor();
						if (270968 - 280300 == -9332)
						{
							this.$self_$43367 = self_;
							if (181935 - 406021 != -224085)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009FF8 RID: 40952 RVA: 0x0125AF14 File Offset: 0x01259114
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27440 - 509204 != -481763)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_A2A;
					case 1:
						goto IL_B3E;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (108065 - 480099 != -372033)
							{
								goto Block_80;
							}
							continue;
						}
						else
						{
							this.$self_$43367.OSinJ2EUrmm.StartCoroutine_Auto(this.$self_$43367.OSinJ2EUrmm.slerpToObject("EventCamera2", (float)3));
							if (278678 - 27928 != 250750)
							{
								continue;
							}
							goto IL_DD;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (254373 - 163785 != 90589)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43363 = (StoryGui)this.$self_$43367.GetComponent(typeof(StoryGui));
							if (7857 - 210563 == -202705)
							{
								continue;
							}
							this.$mStoryTimer$43364 = 0f;
							if (274233 - 184478 == 89756)
							{
								continue;
							}
							if (!this.$mStoryGui$43363)
							{
								goto IL_317;
							}
							if (223031 - 187056 != 35975)
							{
								continue;
							}
							this.$mStoryGui$43363.startStoryMessage("none", "Nico", eTalkType.friend);
							if (117624 - 176470 != -58846)
							{
								continue;
							}
							goto IL_AA3;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (283852 - 256558 != 27295)
							{
								goto Block_76;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43363.newStoryMessage("none", "Nico", Language.getMessage("M932_WindHollow", 101), eTalkType.friend);
							if (18083 - 134631 == -116547)
							{
								continue;
							}
							this.$mMiniCat$43365 = GameObject.Find("MiniCat");
							if (115868 - 73131 != 42737)
							{
								continue;
							}
							if (this.$mMiniCat$43365)
							{
								if (196680 - 139942 != 56738)
								{
									continue;
								}
								this.$mMiniCat$43365.animation.CrossFade("talk");
								if (258713 - 504936 != -246223)
								{
									continue;
								}
							}
							this.$mStoryTimer$43364 = Time.time + 3f;
							if (26330 - 559096 != -532765)
							{
								goto Block_74;
							}
							continue;
						}
						break;
					case 5:
						goto IL_2D6;
					case 6:
						goto IL_2D6;
					case 7:
						goto IL_76B;
					case 8:
						goto IL_76B;
					case 9:
						goto IL_656;
					case 10:
						goto IL_656;
					case 11:
						goto IL_71A;
					case 12:
						goto IL_71A;
					case 13:
						goto IL_25A;
					case 14:
						goto IL_25A;
					case 15:
						break;
					case 16:
						break;
					case 17:
						goto IL_317;
					case 18:
						Game.mGameState = eGameState.Normal;
						if (296381 - 288235 == 8147)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (240283 - 288781 == -48497)
						{
							continue;
						}
						this.YieldDefault(1);
						if (6595 - 372009 != -365414)
						{
							continue;
						}
						goto IL_B3E;
					default:
						if (260543 - 364556 != -104013)
						{
							continue;
						}
						goto IL_A2A;
					}
					if (this.$mStoryTimer$43364 > Time.time)
					{
						if (124396 - 80433 != 43963)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_402;
						}
						if (46702 - 288208 == -241505)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (141299 - 329466 != -188167)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$mMiniCat$43365)
						{
							if (216544 - 207034 == 9511)
							{
								continue;
							}
							this.$mMiniCat$43365.animation.CrossFade("root");
							if (210294 - 181058 == 29237)
							{
								continue;
							}
						}
						this.$mStoryGui$43363.close();
						if (244092 - 599968 != -355876)
						{
							continue;
						}
						goto IL_300;
					}
					IL_2D6:
					if (this.$mStoryTimer$43364 > Time.time)
					{
						if (129868 - 434577 != -304709)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2CA;
						}
						if (264163 - 74333 == 189831)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (151735 - 140392 != 11343)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$43363.newStoryMessage("none", "Fah", Language.getMessage("M932_WindHollow", 102), eTalkType.friend);
						if (32256 - 159184 != -126928)
						{
							continue;
						}
						this.$mStoryTimer$43364 = Time.time + 3f;
						if (30837 - 118015 != -87177)
						{
							goto Block_11;
						}
						continue;
					}
					IL_25A:
					if (this.$mStoryTimer$43364 > Time.time)
					{
						if (134169 - 456668 != -322499)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_24D;
						}
						if (250875 - 171632 != 79243)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (110753 - 105303 != 5451)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43363.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 106), eTalkType.friend);
						if (239048 - 316006 != -76958)
						{
							continue;
						}
						this.$mStoryTimer$43364 = Time.time + 3f;
						if (260975 - 593754 != -332779)
						{
							continue;
						}
						goto IL_3E6;
					}
					IL_71A:
					if (this.$mStoryTimer$43364 > Time.time)
					{
						if (198346 - 48822 != 149524)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_70D;
						}
						if (109188 - 597727 != -488539)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (56859 - 20824 != 36036)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43363.newStoryMessage("none", "Fah", Language.getMessage("M932_WindHollow", 105), eTalkType.friend);
						if (101097 - 186092 != -84995)
						{
							continue;
						}
						this.$mStoryTimer$43364 = Time.time + 3f;
						if (222517 - 456438 != -233920)
						{
							goto Block_53;
						}
						continue;
					}
					IL_656:
					if (this.$mStoryTimer$43364 > Time.time)
					{
						if (172076 - 481595 == -309518)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_649;
						}
						if (298602 - 507301 == -208698)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (50879 - 383511 != -332632)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$43363.newStoryMessage("none", "Fah", Language.getMessage("M932_WindHollow", 104), eTalkType.friend);
						if (162509 - 572740 != -410231)
						{
							continue;
						}
						this.$mStoryTimer$43364 = Time.time + 3f;
						if (86126 - 392314 != -306187)
						{
							goto Block_21;
						}
						continue;
					}
					IL_317:
					this.$mGameGui$43366 = (GameGui)this.$self_$43367.GetComponent(typeof(GameGui));
					if (177300 - 43223 != 134077)
					{
						continue;
					}
					this.$mGameGui$43366.enabled = true;
					if (225868 - 19368 == 206501)
					{
						continue;
					}
					this.$self_$43367.OSinJ2EUrmm.enabled = true;
					if (69688 - 49880 != 19808)
					{
						continue;
					}
					goto IL_933;
					IL_76B:
					if (this.$mStoryTimer$43364 > Time.time)
					{
						if (232071 - 207982 == 24090)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_75F;
						}
						if (102784 - 504472 != -401688)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (131505 - 324414 != -192908)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43363.newStoryMessage("none", "Fah", Language.getMessage("M932_WindHollow", 103), eTalkType.friend);
						if (81491 - 324361 != -242870)
						{
							continue;
						}
						this.$mStoryTimer$43364 = Time.time + 3f;
						if (204044 - 440177 != -236132)
						{
							goto Block_60;
						}
						continue;
					}
					IL_A2A:
					Debug.Log("StartEvent");
					if (153640 - 583959 != -430318)
					{
						this.$self_$43367.OSinJ2EUrmm.alignToObject("EventCamera1");
						if (237329 - 345427 != -108097)
						{
							this.$self_$43367.SendMessage("fadeIn");
							if (136068 - 347374 != -211305)
							{
								goto Block_73;
							}
						}
					}
				}
				goto IL_B3E;
				IL_DD:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_8:
				goto IL_B3E;
				Block_11:
				return this.Yield(7, new WaitForSeconds(0.5f));
				goto IL_B3E;
				IL_24D:
				return this.YieldDefault(14);
				Block_21:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_2CA:
				return this.YieldDefault(6);
				IL_300:
				return this.Yield(17, new WaitForSeconds(0.5f));
				goto IL_B3E;
				IL_3E6:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_402:
				return this.YieldDefault(16);
				goto IL_B3E;
				IL_649:
				return this.YieldDefault(10);
				IL_70D:
				return this.YieldDefault(12);
				IL_75F:
				return this.YieldDefault(8);
				Block_53:
				return this.Yield(13, new WaitForSeconds(0.5f));
				goto IL_B3E;
				Block_60:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_933:
				return this.Yield(18, new WaitForSeconds(0.5f));
				Block_73:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_74:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_AA3:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_76:
				Block_80:
				IL_B3E:
				return false;
			}

			// Token: 0x06009FF9 RID: 40953 RVA: 0x0125BA74 File Offset: 0x01259C74
			internal static bool TLkWFSVfzcKtwPLcO2N4()
			{
				return true;
			}

			// Token: 0x06009FFA RID: 40954 RVA: 0x0125BA78 File Offset: 0x01259C78
			internal static bool DJMwNKVnaHNpMBxZJcXL()
			{
				return false;
			}

			// Token: 0x04009157 RID: 37207
			internal StoryGui $mStoryGui$43363;

			// Token: 0x04009158 RID: 37208
			internal float $mStoryTimer$43364;

			// Token: 0x04009159 RID: 37209
			internal GameObject $mMiniCat$43365;

			// Token: 0x0400915A RID: 37210
			internal GameGui $mGameGui$43366;

			// Token: 0x0400915B RID: 37211
			internal M932_WindHollow1 $self_$43367;
		}
	}

	// Token: 0x02001AC4 RID: 6852
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniCat$43369 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009FFB RID: 40955 RVA: 0x0125BA7C File Offset: 0x01259C7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniCat$43369(M932_WindHollow1 self_)
		{
			if (193641 - 125821 != 67821)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298215 - 427165 != -128949)
				{
					base..ctor();
					if (156831 - 400064 == -243233)
					{
						this.$self_$43377 = self_;
						if (206552 - 353581 != -147028)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009FFC RID: 40956 RVA: 0x0125BB14 File Offset: 0x01259D14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$TalkToMiniCat$43369.$(this.$self_$43377);
		}

		// Token: 0x06009FFD RID: 40957 RVA: 0x0125BB24 File Offset: 0x01259D24
		internal static bool g7NmSFVn5mVwNtPvtJZU()
		{
			return true;
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x0125BB28 File Offset: 0x01259D28
		internal static bool SNRWpjVnp5nYQwkCvOul()
		{
			return false;
		}

		// Token: 0x0400915C RID: 37212
		internal M932_WindHollow1 $self_$43377;

		// Token: 0x02001AC5 RID: 6853
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009FFF RID: 40959 RVA: 0x0125BB2C File Offset: 0x01259D2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow1 self_)
			{
				if (7581 - 262021 != -254440)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91417 - 319358 == -227941)
					{
						base..ctor();
						if (114884 - 148483 == -33599)
						{
							this.$self_$43376 = self_;
							if (257859 - 582122 == -324263)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A000 RID: 40960 RVA: 0x0125BBC4 File Offset: 0x01259DC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230930 - 10997 != 219934)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_577;
					case 1:
						goto IL_611;
					case 2:
						this.$mStoryGui$43374.newStoryMessage("none", "Nico", Language.getMessage("M932_WindHollow", 201), eTalkType.friend);
						if (35092 - 474036 == -438943)
						{
							continue;
						}
						this.$mStoryTimer$43375 = Time.time + 3f;
						if (222732 - 117462 != 105271)
						{
							goto Block_24;
						}
						continue;
					case 3:
						goto IL_54D;
					case 4:
						goto IL_54D;
					case 5:
						break;
					case 6:
						break;
					default:
						if (168943 - 96814 != 72129)
						{
							continue;
						}
						goto IL_577;
					}
					if (this.$mStoryTimer$43375 > Time.time)
					{
						if (147207 - 7286 != 139921)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_425;
						}
						if (160996 - 12883 != 148113)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (5189 - 372359 != -367170)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mMiniCat$43371.animation.Play("root");
						if (268567 - 330254 == -61686)
						{
							continue;
						}
						this.$mStoryGui$43374.close();
						if (64369 - 446000 != -381631)
						{
							continue;
						}
						this.$mGameGui$43373.enabled = true;
						if (3572 - 207655 == -204082)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (233854 - 391606 != -157752)
						{
							continue;
						}
						this.YieldDefault(1);
						if (143205 - 482530 != -339324)
						{
							break;
						}
						continue;
					}
					IL_577:
					if (Game.mGameState != eGameState.Normal)
					{
						if (283062 - 119315 != 163747)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mPlayer$43370 = Game.mPlayer;
						if (12323 - 364733 == -352409)
						{
							continue;
						}
						this.$mMiniCat$43371 = GameObject.Find("MiniCat");
						if (127260 - 167055 != -39795)
						{
							continue;
						}
						this.$mMiniCatOriginalDir$43372 = default(Vector3);
						if (184834 - 124493 == 60342)
						{
							continue;
						}
						if (this.$mMiniCat$43371)
						{
							if (284409 - 377944 == -93534)
							{
								continue;
							}
							if (this.$mPlayer$43370)
							{
								if (33624 - 298987 == -265362)
								{
									continue;
								}
								this.$mPlayer$43370.SendMessage("turnToPos", this.$mMiniCat$43371.transform.position);
								if (6467 - 342893 != -336426)
								{
									continue;
								}
								this.$mMiniCat$43371.transform.rotation = Quaternion.LookRotation(this.$mPlayer$43370.transform.position - this.$mMiniCat$43371.transform.position);
								if (160679 - 399912 == -239232)
								{
									continue;
								}
								this.$mMiniCat$43371.animation.Play("talk");
								if (288291 - 352453 == -64161)
								{
									continue;
								}
							}
						}
						Game.mGameState = eGameState.Hold;
						if (292171 - 69755 == 222417)
						{
							continue;
						}
						this.$mGameGui$43373 = (GameGui)this.$self_$43376.GetComponent(typeof(GameGui));
						if (40318 - 201459 != -161141)
						{
							continue;
						}
						this.$mGameGui$43373.close();
						if (88402 - 204479 == -116076)
						{
							continue;
						}
						this.$mStoryGui$43374 = (StoryGui)this.$self_$43376.GetComponent(typeof(StoryGui));
						if (17062 - 133832 != -116770)
						{
							continue;
						}
						this.$mStoryTimer$43375 = 0f;
						if (53494 - 206346 != -152852)
						{
							continue;
						}
						this.$mStoryGui$43374.startStoryMessage("none", "Nico", eTalkType.friend);
						if (42913 - 134730 != -91817)
						{
							continue;
						}
						goto IL_149;
					}
					IL_54D:
					if (this.$mStoryTimer$43375 > Time.time)
					{
						if (32122 - 79192 != -47070)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_541;
						}
						if (102780 - 18543 != 84237)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (236449 - 131345 != 105105)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$43374.newStoryMessage("none", "Nico", Language.getMessage("M932_WindHollow", 202), eTalkType.friend);
						if (78164 - 377009 != -298844)
						{
							this.$mStoryTimer$43375 = Time.time + 3f;
							if (39165 - 584608 == -545443)
							{
								goto IL_40A;
							}
						}
					}
				}
				goto IL_611;
				IL_149:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_24:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_40A:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_425:
				return this.YieldDefault(6);
				goto IL_611;
				IL_541:
				return this.YieldDefault(4);
				IL_611:
				return false;
			}

			// Token: 0x0600A001 RID: 40961 RVA: 0x0125C1F4 File Offset: 0x0125A3F4
			internal static bool A17PfAVnVv1ZvjIGbD5m()
			{
				return true;
			}

			// Token: 0x0600A002 RID: 40962 RVA: 0x0125C1F8 File Offset: 0x0125A3F8
			internal static bool Hpj9MkVntRen3FSXYe2C()
			{
				return false;
			}

			// Token: 0x0400915D RID: 37213
			internal GameObject $mPlayer$43370;

			// Token: 0x0400915E RID: 37214
			internal GameObject $mMiniCat$43371;

			// Token: 0x0400915F RID: 37215
			internal Vector3 $mMiniCatOriginalDir$43372;

			// Token: 0x04009160 RID: 37216
			internal GameGui $mGameGui$43373;

			// Token: 0x04009161 RID: 37217
			internal StoryGui $mStoryGui$43374;

			// Token: 0x04009162 RID: 37218
			internal float $mStoryTimer$43375;

			// Token: 0x04009163 RID: 37219
			internal M932_WindHollow1 $self_$43376;
		}
	}

	// Token: 0x02001AC6 RID: 6854
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniSheep$43378 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A003 RID: 40963 RVA: 0x0125C1FC File Offset: 0x0125A3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniSheep$43378(M932_WindHollow1 self_)
		{
			if (173740 - 149950 != 23791)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88369 - 482570 != -394200)
				{
					base..ctor();
					if (108262 - 196507 != -88244)
					{
						this.$self_$43386 = self_;
						if (294413 - 422764 == -128351)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x0125C294 File Offset: 0x0125A494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$TalkToMiniSheep$43378.$(this.$self_$43386);
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x0125C2A4 File Offset: 0x0125A4A4
		internal static bool Sfn2QoVnNRTQAqF0qGRv()
		{
			return true;
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x0125C2A8 File Offset: 0x0125A4A8
		internal static bool afgBg9VnYapujynn0xrG()
		{
			return false;
		}

		// Token: 0x04009164 RID: 37220
		internal M932_WindHollow1 $self_$43386;

		// Token: 0x02001AC7 RID: 6855
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A007 RID: 40967 RVA: 0x0125C2AC File Offset: 0x0125A4AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow1 self_)
			{
				if (255844 - 389743 != -133899)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (260614 - 324809 != -64194)
					{
						base..ctor();
						if (269598 - 60661 != 208938)
						{
							this.$self_$43385 = self_;
							if (205131 - 142469 != 62663)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A008 RID: 40968 RVA: 0x0125C344 File Offset: 0x0125A544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194865 - 11187 != 183679)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2E7;
					case 1:
						goto IL_6C8;
					case 2:
						this.$mStoryGui$43383.newStoryMessage("none", "Fah", Language.getMessage("M932_WindHollow", 301), eTalkType.friend);
						if (109266 - 357187 == -247920)
						{
							continue;
						}
						this.$mStoryTimer$43384 = Time.time + 3f;
						if (263498 - 190465 != 73034)
						{
							goto Block_31;
						}
						continue;
					case 3:
						goto IL_69E;
					case 4:
						goto IL_69E;
					case 5:
						goto IL_2BD;
					case 6:
						goto IL_2BD;
					case 7:
						break;
					case 8:
						break;
					default:
						if (229036 - 103903 != 125133)
						{
							continue;
						}
						goto IL_2E7;
					}
					if (this.$mStoryTimer$43384 > Time.time)
					{
						if (52713 - 240988 == -188274)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1B8;
						}
						if (19880 - 528908 != -509028)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (244920 - 285683 != -40762)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43383.close();
						if (139991 - 214303 != -74312)
						{
							continue;
						}
						this.$mGameGui$43382.enabled = true;
						if (92021 - 349534 == -257512)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (16250 - 265087 != -248837)
						{
							continue;
						}
						this.YieldDefault(1);
						if (67762 - 514160 != -446398)
						{
							continue;
						}
						break;
					}
					IL_2BD:
					if (this.$mStoryTimer$43384 > Time.time)
					{
						if (276664 - 237439 != 39225)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2B1;
						}
						if (64269 - 248686 != -184417)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (156967 - 32630 != 124338)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43383.newStoryMessage("none", "Fah", Language.getMessage("M932_WindHollow", 303), eTalkType.friend);
						if (173803 - 300452 != -126649)
						{
							continue;
						}
						this.$mStoryTimer$43384 = Time.time + 3f;
						if (191295 - 172248 != 19047)
						{
							continue;
						}
						goto IL_19D;
					}
					IL_2E7:
					if (Game.mGameState != eGameState.Normal)
					{
						if (95574 - 70878 != 24697)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mPlayer$43379 = Game.mPlayer;
						if (77999 - 241931 != -163932)
						{
							continue;
						}
						this.$mMiniSheep$43380 = GameObject.Find("MiniSheep");
						if (169137 - 395070 != -225933)
						{
							continue;
						}
						this.$mMiniSheepOriginalDir$43381 = default(Vector3);
						if (110515 - 250501 == -139985)
						{
							continue;
						}
						if (this.$mMiniSheep$43380)
						{
							if (271365 - 481806 == -210440)
							{
								continue;
							}
							if (this.$mPlayer$43379)
							{
								if (98136 - 120649 != -22513)
								{
									continue;
								}
								this.$mPlayer$43379.SendMessage("turnToPos", this.$mMiniSheep$43380.transform.position);
								if (149236 - 519200 == -369963)
								{
									continue;
								}
								this.$mMiniSheep$43380.transform.rotation = Quaternion.LookRotation(this.$mPlayer$43379.transform.position - this.$mMiniSheep$43380.transform.position);
								if (128675 - 509315 == -380639)
								{
									continue;
								}
							}
						}
						Game.mGameState = eGameState.Hold;
						if (215601 - 427610 == -212008)
						{
							continue;
						}
						this.$mGameGui$43382 = (GameGui)this.$self_$43385.GetComponent(typeof(GameGui));
						if (260620 - 448745 == -188124)
						{
							continue;
						}
						this.$mGameGui$43382.close();
						if (218492 - 183211 != 35281)
						{
							continue;
						}
						this.$mStoryGui$43383 = (StoryGui)this.$self_$43385.GetComponent(typeof(StoryGui));
						if (14980 - 84738 == -69757)
						{
							continue;
						}
						this.$mStoryTimer$43384 = 0f;
						if (179463 - 504622 == -325158)
						{
							continue;
						}
						this.$mStoryGui$43383.startStoryMessage("none", "Fah", eTalkType.friend);
						if (115232 - 509828 != -394596)
						{
							continue;
						}
						goto IL_B3;
					}
					IL_69E:
					if (this.$mStoryTimer$43384 > Time.time)
					{
						if (239232 - 593579 != -354347)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_692;
						}
						if (295466 - 59928 != 235538)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (159802 - 282434 == -122632)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$43383.newStoryMessage("none", "Fah", Language.getMessage("M932_WindHollow", 302), eTalkType.friend);
						if (216343 - 514253 == -297910)
						{
							this.$mStoryTimer$43384 = Time.time + 3f;
							if (142081 - 92263 == 49818)
							{
								goto IL_296;
							}
						}
					}
				}
				goto IL_6C8;
				IL_B3:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_19D:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_1B8:
				return this.YieldDefault(8);
				IL_296:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_2B1:
				return this.YieldDefault(6);
				goto IL_6C8;
				Block_31:
				return this.Yield(3, new WaitForSeconds(0.5f));
				goto IL_6C8;
				IL_692:
				return this.YieldDefault(4);
				IL_6C8:
				return false;
			}

			// Token: 0x0600A009 RID: 40969 RVA: 0x0125CA2C File Offset: 0x0125AC2C
			internal static bool tMHWSrVncZ3UIClfaGbZ()
			{
				return true;
			}

			// Token: 0x0600A00A RID: 40970 RVA: 0x0125CA30 File Offset: 0x0125AC30
			internal static bool AuKhQtVnUjaIbHxZV0Ve()
			{
				return false;
			}

			// Token: 0x04009165 RID: 37221
			internal GameObject $mPlayer$43379;

			// Token: 0x04009166 RID: 37222
			internal GameObject $mMiniSheep$43380;

			// Token: 0x04009167 RID: 37223
			internal Vector3 $mMiniSheepOriginalDir$43381;

			// Token: 0x04009168 RID: 37224
			internal GameGui $mGameGui$43382;

			// Token: 0x04009169 RID: 37225
			internal StoryGui $mStoryGui$43383;

			// Token: 0x0400916A RID: 37226
			internal float $mStoryTimer$43384;

			// Token: 0x0400916B RID: 37227
			internal M932_WindHollow1 $self_$43385;
		}
	}

	// Token: 0x02001AC8 RID: 6856
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$43387 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A00B RID: 40971 RVA: 0x0125CA34 File Offset: 0x0125AC34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$43387(M932_WindHollow1 self_)
		{
			if (84378 - 50235 != 34143)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37958 - 259031 == -221073)
				{
					base..ctor();
					if (280487 - 553340 != -272852)
					{
						this.$self_$43395 = self_;
						if (260738 - 590099 == -329361)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x0125CACC File Offset: 0x0125ACCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$TalkToPanther$43387.$(this.$self_$43395);
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x0125CADC File Offset: 0x0125ACDC
		internal static bool Ge0OTHVnTIMmD8kUqnkS()
		{
			return true;
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x0125CAE0 File Offset: 0x0125ACE0
		internal static bool YF0T62Vn3PJtfTi2pFsk()
		{
			return false;
		}

		// Token: 0x0400916C RID: 37228
		internal M932_WindHollow1 $self_$43395;

		// Token: 0x02001AC9 RID: 6857
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A00F RID: 40975 RVA: 0x0125CAE4 File Offset: 0x0125ACE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow1 self_)
			{
				if (147352 - 69795 != 77557)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217344 - 94730 == 122614)
					{
						base..ctor();
						if (195898 - 380355 != -184456)
						{
							this.$self_$43394 = self_;
							if (217566 - 177532 == 40034)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A010 RID: 40976 RVA: 0x0125CB7C File Offset: 0x0125AD7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223922 - 211409 != 12514)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_303;
					case 1:
						goto IL_44E;
					case 2:
						this.$mStoryGui$43392.newStoryMessage("none", "Soldier", Language.getMessage("M932_WindHollow", 401 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (80852 - 115280 != -34428)
						{
							continue;
						}
						this.$mStoryTimer$43393 = Time.time + 3f;
						if (294432 - 174506 != 119927)
						{
							goto Block_7;
						}
						continue;
					case 3:
						break;
					case 4:
						break;
					default:
						if (151387 - 365475 != -214088)
						{
							continue;
						}
						goto IL_303;
					}
					if (this.$mStoryTimer$43393 > Time.time)
					{
						if (288977 - 566871 == -277893)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2A3;
						}
						if (286357 - 458868 == -172510)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (35383 - 127907 != -92524)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$43392.close();
						if (117037 - 566244 != -449207)
						{
							continue;
						}
						this.$mGameGui$43391.enabled = true;
						if (272264 - 268046 == 4219)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (203602 - 555288 == -351685)
						{
							continue;
						}
						this.YieldDefault(1);
						if (208927 - 570609 != -361681)
						{
							break;
						}
						continue;
					}
					IL_303:
					if (Game.mGameState != eGameState.Normal)
					{
						if (115620 - 365399 != -249778)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$43388 = Game.mPlayer;
						if (123607 - 165145 != -41537)
						{
							this.$mPanther$43389 = GameObject.Find("Panther");
							if (159600 - 120764 == 38836)
							{
								this.$mPantherOriginalDir$43390 = default(Vector3);
								if (298983 - 594034 == -295051)
								{
									if (this.$mPanther$43389)
									{
										if (144834 - 350326 != -205492)
										{
											continue;
										}
										if (this.$mPlayer$43388)
										{
											if (57080 - 580564 != -523484)
											{
												continue;
											}
											this.$mPlayer$43388.SendMessage("turnToPos", this.$mPanther$43389.transform.position);
											if (72246 - 378661 != -306415)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (283498 - 585739 == -302241)
									{
										this.$mGameGui$43391 = (GameGui)this.$self_$43394.GetComponent(typeof(GameGui));
										if (116034 - 474822 != -358787)
										{
											this.$mGameGui$43391.close();
											if (138948 - 123429 != 15520)
											{
												this.$mStoryGui$43392 = (StoryGui)this.$self_$43394.GetComponent(typeof(StoryGui));
												if (284547 - 27047 != 257501)
												{
													this.$mStoryTimer$43393 = 0f;
													if (285561 - 307823 != -22261)
													{
														this.$mStoryGui$43392.startStoryMessage("none", "Soldier", eTalkType.friend);
														if (116175 - 598191 == -482016)
														{
															goto IL_1CB;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_44E;
				Block_7:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1CB:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2A3:
				return this.YieldDefault(4);
				IL_44E:
				return false;
			}

			// Token: 0x0600A011 RID: 40977 RVA: 0x0125CFEC File Offset: 0x0125B1EC
			internal static bool dfiU5sVnX8CGjeDy4hTR()
			{
				return true;
			}

			// Token: 0x0600A012 RID: 40978 RVA: 0x0125CFF0 File Offset: 0x0125B1F0
			internal static bool XHYW0bVnQBrtWWtnj3r9()
			{
				return false;
			}

			// Token: 0x0400916D RID: 37229
			internal GameObject $mPlayer$43388;

			// Token: 0x0400916E RID: 37230
			internal GameObject $mPanther$43389;

			// Token: 0x0400916F RID: 37231
			internal Vector3 $mPantherOriginalDir$43390;

			// Token: 0x04009170 RID: 37232
			internal GameGui $mGameGui$43391;

			// Token: 0x04009171 RID: 37233
			internal StoryGui $mStoryGui$43392;

			// Token: 0x04009172 RID: 37234
			internal float $mStoryTimer$43393;

			// Token: 0x04009173 RID: 37235
			internal M932_WindHollow1 $self_$43394;
		}
	}

	// Token: 0x02001ACA RID: 6858
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43396 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A013 RID: 40979 RVA: 0x0125CFF4 File Offset: 0x0125B1F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43396(M932_WindHollow1 self_)
		{
			if (3868 - 34167 != -30299)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59315 - 208082 != -148766)
				{
					base..ctor();
					if (82968 - 359518 == -276550)
					{
						this.$self_$43401 = self_;
						if (114684 - 152412 == -37728)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x0125D08C File Offset: 0x0125B28C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$onDeadPlayer$43396.$(this.$self_$43401);
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x0125D09C File Offset: 0x0125B29C
		internal static bool axB0dnVnk2ui2Wy5DBfJ()
		{
			return true;
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x0125D0A0 File Offset: 0x0125B2A0
		internal static bool Y7RpPYVnGIoDxnuSWuLu()
		{
			return false;
		}

		// Token: 0x04009174 RID: 37236
		internal M932_WindHollow1 $self_$43401;

		// Token: 0x02001ACB RID: 6859
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A017 RID: 40983 RVA: 0x0125D0A4 File Offset: 0x0125B2A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow1 self_)
			{
				if (23317 - 426284 != -402967)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205891 - 345609 != -139717)
					{
						base..ctor();
						if (122694 - 175134 != -52439)
						{
							this.$self_$43400 = self_;
							if (198106 - 208434 != -10327)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A018 RID: 40984 RVA: 0x0125D13C File Offset: 0x0125B33C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (213614 - 351122 != -137508)
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
							goto IL_113;
						}
						if (9533 - 101075 == -91541)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (213512 - 400058 != -186546)
							{
								continue;
							}
							goto IL_113;
						}
						IL_B9:
						this.YieldDefault(1);
						if (132339 - 365454 != -233114)
						{
							goto Block_9;
						}
						continue;
						IL_113:
						Game.mGameState = eGameState.Hold;
						if (5109 - 93521 != -88412)
						{
							continue;
						}
						this.$mStoryGui$43397 = (StoryGui)this.$self_$43400.GetComponent(typeof(StoryGui));
						if (140268 - 342615 == -202346)
						{
							continue;
						}
						if (this.$mStoryGui$43397)
						{
							if (194724 - 154262 != 40462)
							{
								continue;
							}
							this.$mStoryGui$43397.close();
							if (189665 - 203599 != -13934)
							{
								continue;
							}
						}
						this.$mChangeGui$43398 = (ChangeGui)this.$self_$43400.GetComponent(typeof(ChangeGui));
						if (122542 - 4454 != 118088)
						{
							continue;
						}
						if (this.$mChangeGui$43398)
						{
							if (259616 - 135991 != 123625)
							{
								continue;
							}
							this.$mChangeGui$43398.close();
							if (237658 - 168451 == 69208)
							{
								continue;
							}
						}
						this.$mGameGui$43399 = (GameGui)this.$self_$43400.GetComponent(typeof(GameGui));
						if (241597 - 260631 == -19033)
						{
							continue;
						}
						if (!this.$mGameGui$43399)
						{
							goto IL_B9;
						}
						if (22093 - 343988 != -321895)
						{
							continue;
						}
						if (!this.$mGameGui$43399.enabled)
						{
							if (259113 - 67253 == 191861)
							{
								continue;
							}
							this.$mGameGui$43399.enabled = true;
							if (52239 - 39218 != 13021)
							{
								continue;
							}
						}
						this.$mGameGui$43399.openDeadMenu();
						if (68966 - 323016 != -254050)
						{
							continue;
						}
						goto IL_B9;
					default:
						if (271726 - 51539 == 220188)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (156980 - 373025 == -216045)
					{
						goto IL_DB;
					}
				}
				Block_9:
				goto IL_2F9;
				IL_DB:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A019 RID: 40985 RVA: 0x0125D454 File Offset: 0x0125B654
			internal static bool m8Oq0lVnHs0cNJZYvYXJ()
			{
				return true;
			}

			// Token: 0x0600A01A RID: 40986 RVA: 0x0125D458 File Offset: 0x0125B658
			internal static bool kVt0T7VnW6q0op2mBYUm()
			{
				return false;
			}

			// Token: 0x04009175 RID: 37237
			internal StoryGui $mStoryGui$43397;

			// Token: 0x04009176 RID: 37238
			internal ChangeGui $mChangeGui$43398;

			// Token: 0x04009177 RID: 37239
			internal GameGui $mGameGui$43399;

			// Token: 0x04009178 RID: 37240
			internal M932_WindHollow1 $self_$43400;
		}
	}

	// Token: 0x02001ACC RID: 6860
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43402 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A01B RID: 40987 RVA: 0x0125D45C File Offset: 0x0125B65C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43402(Hashtable data, M932_WindHollow1 self_)
		{
			if (266211 - 194700 != 71511)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99412 - 527145 != -427732)
				{
					base..ctor();
					if (22884 - 559115 != -536230)
					{
						this.$data$43407 = data;
						if (238796 - 525775 != -286978)
						{
							this.$self_$43408 = self_;
							if (166178 - 245096 != -78917)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A01C RID: 40988 RVA: 0x0125D518 File Offset: 0x0125B718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$onChangePlayer$43402.$(this.$data$43407, this.$self_$43408);
		}

		// Token: 0x0600A01D RID: 40989 RVA: 0x0125D52C File Offset: 0x0125B72C
		internal static bool h93b9SVnAn0b9l7leT2e()
		{
			return true;
		}

		// Token: 0x0600A01E RID: 40990 RVA: 0x0125D530 File Offset: 0x0125B730
		internal static bool Oe9fOHVnl6hQQf50D5XN()
		{
			return false;
		}

		// Token: 0x04009179 RID: 37241
		internal Hashtable $data$43407;

		// Token: 0x0400917A RID: 37242
		internal M932_WindHollow1 $self_$43408;

		// Token: 0x02001ACD RID: 6861
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A01F RID: 40991 RVA: 0x0125D534 File Offset: 0x0125B734
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M932_WindHollow1 self_)
			{
				if (249612 - 176085 != 73528)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283651 - 76449 != 207203)
					{
						base..ctor();
						if (106780 - 480115 != -373334)
						{
							this.$data$43405 = data;
							if (74786 - 355726 != -280939)
							{
								this.$self_$43406 = self_;
								if (60363 - 317023 == -256660)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A020 RID: 40992 RVA: 0x0125D5F0 File Offset: 0x0125B7F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209886 - 484582 != -274695)
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
							if (6707 - 33603 == -26895)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (143947 - 422408 == -278460)
							{
								continue;
							}
							this.$mGameGui$43404 = (GameGui)this.$self_$43406.GetComponent(typeof(GameGui));
							if (157549 - 191335 == -33785)
							{
								continue;
							}
							this.$mGameGui$43404.enabled = true;
							if (170673 - 370326 == -199652)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (223658 - 35114 != 188544)
						{
							continue;
						}
						goto IL_205;
					default:
						if (143707 - 63684 != 80023)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (129165 - 74755 == 54410)
					{
						this.$self_$43406.SendMessage("onCreatePlayer", this.$data$43405);
						if (154228 - 95857 != 58372)
						{
							this.$mChangeGui$43403 = (ChangeGui)this.$self_$43406.GetComponent(typeof(ChangeGui));
							if (150652 - 520961 != -370308)
							{
								if (!this.$mChangeGui$43403.enabled)
								{
									break;
								}
								if (25960 - 533885 == -507925)
								{
									this.$mChangeGui$43403.close();
									if (259839 - 570355 != -310515)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600A021 RID: 40993 RVA: 0x0125D814 File Offset: 0x0125BA14
			internal static bool T7ilnGVny3iDc9SW2TL3()
			{
				return true;
			}

			// Token: 0x0600A022 RID: 40994 RVA: 0x0125D818 File Offset: 0x0125BA18
			internal static bool pbNCsXVnSHAVWBX0FcpN()
			{
				return false;
			}

			// Token: 0x0400917B RID: 37243
			internal ChangeGui $mChangeGui$43403;

			// Token: 0x0400917C RID: 37244
			internal GameGui $mGameGui$43404;

			// Token: 0x0400917D RID: 37245
			internal Hashtable $data$43405;

			// Token: 0x0400917E RID: 37246
			internal M932_WindHollow1 $self_$43406;
		}
	}

	// Token: 0x02001ACE RID: 6862
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43409 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A023 RID: 40995 RVA: 0x0125D81C File Offset: 0x0125BA1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43409(Hashtable data, M932_WindHollow1 self_)
		{
			if (101438 - 192040 != -90602)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217028 - 346854 == -129826)
				{
					base..ctor();
					if (4927 - 95354 == -90427)
					{
						this.$data$43417 = data;
						if (146643 - 514210 != -367566)
						{
							this.$self_$43418 = self_;
							if (149250 - 47146 == 102104)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x0125D8D8 File Offset: 0x0125BAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$onGameComplete$43409.$(this.$data$43417, this.$self_$43418);
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x0125D8EC File Offset: 0x0125BAEC
		internal static bool Ewvx2PVnobuYkD45bVXr()
		{
			return true;
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x0125D8F0 File Offset: 0x0125BAF0
		internal static bool IuLpCjVnEEqlUKpsfgnN()
		{
			return false;
		}

		// Token: 0x0400917F RID: 37247
		internal Hashtable $data$43417;

		// Token: 0x04009180 RID: 37248
		internal M932_WindHollow1 $self_$43418;

		// Token: 0x02001ACF RID: 6863
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A027 RID: 40999 RVA: 0x0125D8F4 File Offset: 0x0125BAF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M932_WindHollow1 self_)
			{
				if (84848 - 246331 != -161482)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165675 - 599473 != -433797)
					{
						base..ctor();
						if (244618 - 223306 != 21313)
						{
							this.$data$43415 = data;
							if (39164 - 71793 == -32629)
							{
								this.$self_$43416 = self_;
								if (206076 - 496557 != -290480)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A028 RID: 41000 RVA: 0x0125D9B0 File Offset: 0x0125BBB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280256 - 172084 != 108173)
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
						this.$mCompleteGui$43411 = (CompleteGui)this.$self_$43416.GetComponent(typeof(CompleteGui));
						if (24618 - 313472 == -288853)
						{
							continue;
						}
						this.$mCompleteGui$43411.Init();
						if (271613 - 591477 != -319864)
						{
							continue;
						}
						this.$mCompleteGui$43411.readData(this.$data$43415);
						if (90560 - 368276 != -277716)
						{
							continue;
						}
						if (this.$result$43410 == 1)
						{
							if (260344 - 397240 != -136896)
							{
								continue;
							}
							this.$mCompleteGui$43411.displayResult(eCompleteType.Success);
							if (32917 - 326779 == -293861)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43411.displayResult(eCompleteType.Failed);
							if (155762 - 108649 != 47113)
							{
								continue;
							}
						}
						this.$mGameGui$43412 = (GameGui)this.$self_$43416.GetComponent(typeof(GameGui));
						if (222310 - 259887 != -37577)
						{
							continue;
						}
						this.$mStoryGui$43413 = (StoryGui)this.$self_$43416.GetComponent(typeof(StoryGui));
						if (110449 - 153529 != -43080)
						{
							continue;
						}
						this.$mChangeGui$43414 = (ChangeGui)this.$self_$43416.GetComponent(typeof(ChangeGui));
						if (99165 - 575791 == -476625)
						{
							continue;
						}
						if (this.$mGameGui$43412)
						{
							if (40822 - 334439 != -293617)
							{
								continue;
							}
							this.$mGameGui$43412.close();
							if (180573 - 50607 == 129967)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43413)
						{
							if (196191 - 326042 == -129850)
							{
								continue;
							}
							this.$mStoryGui$43413.close();
							if (105644 - 394899 == -289254)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43414)
						{
							if (7792 - 258576 != -250784)
							{
								continue;
							}
							this.$mChangeGui$43414.disable();
							if (10675 - 141951 == -131275)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (209339 - 214950 != -5611)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (246240 - 11047 != 235193)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43415[31]);
					if (160262 - 212925 != -52662)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (128836 - 549159 == -420323)
							{
								goto IL_3B6;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (269135 - 34009 != 235127)
							{
								this.$result$43410 = RuntimeServices.UnboxInt32(this.$data$43415[31]);
								if (171828 - 140967 == 30861)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3B6:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A029 RID: 41001 RVA: 0x0125DDAC File Offset: 0x0125BFAC
			internal static bool sJL61TVn2SxT3uxfPAZe()
			{
				return true;
			}

			// Token: 0x0600A02A RID: 41002 RVA: 0x0125DDB0 File Offset: 0x0125BFB0
			internal static bool nvcQpHVn8xVYKqyP7VMh()
			{
				return false;
			}

			// Token: 0x04009181 RID: 37249
			internal int $result$43410;

			// Token: 0x04009182 RID: 37250
			internal CompleteGui $mCompleteGui$43411;

			// Token: 0x04009183 RID: 37251
			internal GameGui $mGameGui$43412;

			// Token: 0x04009184 RID: 37252
			internal StoryGui $mStoryGui$43413;

			// Token: 0x04009185 RID: 37253
			internal ChangeGui $mChangeGui$43414;

			// Token: 0x04009186 RID: 37254
			internal Hashtable $data$43415;

			// Token: 0x04009187 RID: 37255
			internal M932_WindHollow1 $self_$43416;
		}
	}

	// Token: 0x02001AD0 RID: 6864
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43419 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A02B RID: 41003 RVA: 0x0125DDB4 File Offset: 0x0125BFB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43419(M932_WindHollow1 self_)
		{
			if (179600 - 234755 != -55155)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24651 - 371329 != -346677)
				{
					base..ctor();
					if (77592 - 73863 == 3729)
					{
						this.$self_$43423 = self_;
						if (48563 - 507322 == -458759)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x0125DE4C File Offset: 0x0125C04C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$ReturnToTown$43419.$(this.$self_$43423);
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x0125DE5C File Offset: 0x0125C05C
		internal static bool TWC1nAVnZSuAAMnbF4a6()
		{
			return true;
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x0125DE60 File Offset: 0x0125C060
		internal static bool OJDAOmVnCmy0muslWVw4()
		{
			return false;
		}

		// Token: 0x04009188 RID: 37256
		internal M932_WindHollow1 $self_$43423;

		// Token: 0x02001AD1 RID: 6865
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A02F RID: 41007 RVA: 0x0125DE64 File Offset: 0x0125C064
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow1 self_)
			{
				if (287545 - 534105 != -246559)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84733 - 162657 != -77923)
					{
						base..ctor();
						if (121106 - 218094 == -96988)
						{
							this.$self_$43422 = self_;
							if (89170 - 549930 != -460759)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A030 RID: 41008 RVA: 0x0125DEFC File Offset: 0x0125C0FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157850 - 234980 != -77130)
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
						this.$self_$43422.LeaveGame();
						if (269490 - 468800 != -199310)
						{
							continue;
						}
						this.YieldDefault(1);
						if (202562 - 564911 != -362348)
						{
							goto Block_2;
						}
						continue;
					default:
						if (425 - 39875 == -39449)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (15831 - 548884 != -533052)
					{
						Game.mStateTime = Time.time;
						if (274549 - 572084 == -297535)
						{
							this.$$switch$7935$43420 = PlayerData.SaveGuild;
							if (201079 - 5001 == 196078)
							{
								if (this.$$switch$7935$43420 == 1)
								{
									if (237308 - 499795 == -262486)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (195979 - 252215 != -56236)
									{
										continue;
									}
								}
								else if (this.$$switch$7935$43420 == 2)
								{
									if (182736 - 522090 == -339353)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (287704 - 47615 == 240090)
									{
										continue;
									}
								}
								else if (this.$$switch$7935$43420 == 3)
								{
									if (260622 - 140401 != 120221)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (13223 - 589829 != -576606)
									{
										continue;
									}
								}
								else if (this.$$switch$7935$43420 == 4)
								{
									if (264672 - 409106 != -144434)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (35944 - 101594 == -65649)
									{
										continue;
									}
								}
								else if (this.$$switch$7935$43420 == 5)
								{
									if (20834 - 260772 != -239938)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (240563 - 539150 != -298587)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (144541 - 320058 != -175517)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (173460 - 196737 == -23276)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (211107 - 16905 != 194202)
									{
										continue;
									}
								}
								this.$mGameGui$43421 = (GameGui)this.$self_$43422.GetComponent(typeof(GameGui));
								if (61611 - 396644 == -335033)
								{
									if (this.$mGameGui$43421)
									{
										if (71005 - 341043 == -270037)
										{
											continue;
										}
										this.$mGameGui$43421.close();
										if (71507 - 436178 != -364671)
										{
											continue;
										}
									}
									this.$self_$43422.SendMessage("fadeOut");
									if (174568 - 302350 != -127781)
									{
										goto Block_15;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_3AD;
				Block_15:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600A031 RID: 41009 RVA: 0x0125E2C8 File Offset: 0x0125C4C8
			internal static bool auYYPxVnLHnmLiHLGbdE()
			{
				return true;
			}

			// Token: 0x0600A032 RID: 41010 RVA: 0x0125E2CC File Offset: 0x0125C4CC
			internal static bool CrJSn1VnOYg7TBjHC3Z0()
			{
				return false;
			}

			// Token: 0x04009189 RID: 37257
			internal int $$switch$7935$43420;

			// Token: 0x0400918A RID: 37258
			internal GameGui $mGameGui$43421;

			// Token: 0x0400918B RID: 37259
			internal M932_WindHollow1 $self_$43422;
		}
	}

	// Token: 0x02001AD2 RID: 6866
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43424 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A033 RID: 41011 RVA: 0x0125E2D0 File Offset: 0x0125C4D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43424(M932_WindHollow1 self_)
		{
			if (93075 - 380171 != -287096)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (150124 - 400262 != -250137)
				{
					base..ctor();
					if (287163 - 404692 == -117529)
					{
						this.$self_$43427 = self_;
						if (12438 - 375084 != -362645)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x0125E368 File Offset: 0x0125C568
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$ReturnToGuild$43424.$(this.$self_$43427);
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x0125E378 File Offset: 0x0125C578
		internal static bool QjH27WVnmJMbY6yFnXv4()
		{
			return true;
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x0125E37C File Offset: 0x0125C57C
		internal static bool EKZ9YNVnFWvlt7045KYU()
		{
			return false;
		}

		// Token: 0x0400918C RID: 37260
		internal M932_WindHollow1 $self_$43427;

		// Token: 0x02001AD3 RID: 6867
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A037 RID: 41015 RVA: 0x0125E380 File Offset: 0x0125C580
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow1 self_)
			{
				if (225685 - 76466 != 149219)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243132 - 380721 != -137588)
					{
						base..ctor();
						if (263738 - 542194 == -278456)
						{
							this.$self_$43426 = self_;
							if (106459 - 486405 == -379946)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A038 RID: 41016 RVA: 0x0125E418 File Offset: 0x0125C618
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229091 - 58944 != 170148)
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
						this.$self_$43426.LeaveGame();
						if (276502 - 24478 != 252024)
						{
							continue;
						}
						this.YieldDefault(1);
						if (108966 - 76329 != 32637)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (253080 - 587681 == -334600)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (19894 - 278293 == -258399)
					{
						Game.mStateTime = Time.time;
						if (55344 - 561801 != -506456)
						{
							Game.mNextGameCode = 31;
							if (170741 - 261967 != -91225)
							{
								this.$mGameGui$43425 = (GameGui)this.$self_$43426.GetComponent(typeof(GameGui));
								if (11573 - 2736 != 8838)
								{
									if (this.$mGameGui$43425)
									{
										if (132879 - 283431 == -150551)
										{
											continue;
										}
										this.$mGameGui$43425.close();
										if (172418 - 457537 == -285118)
										{
											continue;
										}
									}
									this.$self_$43426.SendMessage("fadeOut");
									if (122832 - 563756 == -440924)
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

			// Token: 0x0600A039 RID: 41017 RVA: 0x0125E5F4 File Offset: 0x0125C7F4
			internal static bool oY9VKHVnMsnyscachgBm()
			{
				return true;
			}

			// Token: 0x0600A03A RID: 41018 RVA: 0x0125E5F8 File Offset: 0x0125C7F8
			internal static bool dnbc2pVnx0vigINPNDPQ()
			{
				return false;
			}

			// Token: 0x0400918D RID: 37261
			internal GameGui $mGameGui$43425;

			// Token: 0x0400918E RID: 37262
			internal M932_WindHollow1 $self_$43426;
		}
	}

	// Token: 0x02001AD4 RID: 6868
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43428 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A03B RID: 41019 RVA: 0x0125E5FC File Offset: 0x0125C7FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43428(M932_WindHollow1 self_)
		{
			if (187253 - 395609 != -208355)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193010 - 249561 != -56550)
				{
					base..ctor();
					if (86832 - 265354 == -178522)
					{
						this.$self_$43432 = self_;
						if (292488 - 275492 == 16996)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x0125E694 File Offset: 0x0125C894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow1.$ReturnToCamp$43428.$(this.$self_$43432);
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x0125E6A4 File Offset: 0x0125C8A4
		internal static bool dBZnJqVnghLoC2vyGPW0()
		{
			return true;
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x0125E6A8 File Offset: 0x0125C8A8
		internal static bool wbvEh6Vnfb7MPKuN907q()
		{
			return false;
		}

		// Token: 0x0400918F RID: 37263
		internal M932_WindHollow1 $self_$43432;

		// Token: 0x02001AD5 RID: 6869
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A03F RID: 41023 RVA: 0x0125E6AC File Offset: 0x0125C8AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow1 self_)
			{
				if (224578 - 382657 != -158078)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218350 - 60987 == 157363)
					{
						base..ctor();
						if (298250 - 510847 == -212597)
						{
							this.$self_$43431 = self_;
							if (216394 - 171887 == 44507)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A040 RID: 41024 RVA: 0x0125E744 File Offset: 0x0125C944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230611 - 249233 != -18622)
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
						this.$self_$43431.LeaveGame();
						if (136849 - 417245 != -280396)
						{
							continue;
						}
						this.YieldDefault(1);
						if (157981 - 476153 != -318171)
						{
							goto Block_15;
						}
						continue;
					default:
						if (6264 - 333399 == -327134)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (152557 - 157502 != -4944)
					{
						Game.mStateTime = Time.time;
						if (243176 - 133778 == 109398)
						{
							this.$$switch$7937$43429 = PlayerData.SaveGuild;
							if (173357 - 174977 == -1620)
							{
								if (this.$$switch$7937$43429 == 1)
								{
									if (153930 - 238545 != -84615)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (19742 - 166429 == -146686)
									{
										continue;
									}
								}
								else if (this.$$switch$7937$43429 == 2)
								{
									if (84467 - 374237 == -289769)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (196740 - 178827 != 17913)
									{
										continue;
									}
								}
								else if (this.$$switch$7937$43429 == 3)
								{
									if (50142 - 357059 != -306917)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (12229 - 260356 != -248127)
									{
										continue;
									}
								}
								else if (this.$$switch$7937$43429 == 4)
								{
									if (240886 - 439723 == -198836)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (220831 - 5226 == 215606)
									{
										continue;
									}
								}
								else if (this.$$switch$7937$43429 == 5)
								{
									if (79784 - 267358 == -187573)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (287933 - 64256 != 223677)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (249052 - 300983 != -51931)
									{
										continue;
									}
								}
								this.$mGameGui$43430 = (GameGui)this.$self_$43431.GetComponent(typeof(GameGui));
								if (213700 - 188621 == 25079)
								{
									if (this.$mGameGui$43430)
									{
										if (296969 - 353045 != -56076)
										{
											continue;
										}
										this.$mGameGui$43430.close();
										if (44251 - 354562 == -310310)
										{
											continue;
										}
									}
									this.$self_$43431.SendMessage("fadeOut");
									if (130321 - 217336 != -87014)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_15:
				IL_363:
				return false;
			}

			// Token: 0x0600A041 RID: 41025 RVA: 0x0125EAC8 File Offset: 0x0125CCC8
			internal static bool QkSRFKVnndT9ZmP7TDru()
			{
				return true;
			}

			// Token: 0x0600A042 RID: 41026 RVA: 0x0125EACC File Offset: 0x0125CCCC
			internal static bool Wyu4kNVn6u3yInocleEY()
			{
				return false;
			}

			// Token: 0x04009190 RID: 37264
			internal int $$switch$7937$43429;

			// Token: 0x04009191 RID: 37265
			internal GameGui $mGameGui$43430;

			// Token: 0x04009192 RID: 37266
			internal M932_WindHollow1 $self_$43431;
		}
	}
}
