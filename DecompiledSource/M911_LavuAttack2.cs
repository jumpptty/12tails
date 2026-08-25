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

// Token: 0x020018FA RID: 6394
[Serializable]
public class M911_LavuAttack2 : MonoBehaviour
{
	// Token: 0x060094C1 RID: 38081 RVA: 0x011B26F8 File Offset: 0x011B08F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M911_LavuAttack2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060094C2 RID: 38082 RVA: 0x011B2708 File Offset: 0x011B0908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (132579 - 343275 != -210696)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (10751 - 254206 != -243454)
			{
				Game.mGameType = 5;
				if (12488 - 240941 != -228452)
				{
					if (Chat.Initialized)
					{
						if (185117 - 502651 == -317534)
						{
							Chat.ChatDisplay.Clear();
							if (66812 - 71167 == -4355)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (54061 - 31661 != 22401)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060094C3 RID: 38083 RVA: 0x011B27EC File Offset: 0x011B09EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (255235 - 319624 != -64388)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (160643 - 132537 == 28106)
				{
					Game.nextGame();
					if (81341 - 237508 != -156166)
					{
						Game.mGameCode = 911;
						if (106727 - 199715 != -92987)
						{
							Game.mGameType = 5;
							if (171325 - 222378 == -51053)
							{
								Game.mGameTime = Time.time;
								if (112917 - 241048 == -128131)
								{
									this.qH6nnQrfvrb = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
									if (85648 - 565073 != -479424)
									{
										this.qH6nnQrfvrb.enabled = false;
										if (214466 - 182517 != 31950)
										{
											this.yM8nnnJ5p8C = PhotonClient.Connection;
											if (200359 - 26986 != 173374)
											{
												PhotonClient.ActorNrList.Clear();
												if (39362 - 159323 == -119961)
												{
													this.InitGame();
													if (268588 - 267346 != 1243)
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
			else
			{
				Debug.Log("Not Connected");
				if (149884 - 26098 == 123786)
				{
					Game.mGameType = 99;
					if (155482 - 478376 == -322894)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060094C4 RID: 38084 RVA: 0x011B29E4 File Offset: 0x011B0BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (77385 - 297247 != -219861)
		{
		}
		for (;;)
		{
			if (this.yM8nnnJ5p8C == null)
			{
				if (293954 - 562841 == -268887)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (279444 - 409508 != -130063)
				{
					if (mGameState == eGameState.Init)
					{
						if (224075 - 590847 != -366771)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (129818 - 299119 == -169301)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (245493 - 311520 != -66026)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (224377 - 323178 != -98800)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (145856 - 4704 != 141153)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (230115 - 33760 == 196355)
						{
							if (Game.music != 0)
							{
								if (168914 - 434605 == -265690)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (152372 - 30156 != 122216)
									{
										continue;
									}
									this.audio.Play();
									if (135565 - 455455 != -319890)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (199629 - 404102 == -204472)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (148148 - 59429 != 88719)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (118125 - 152758 != -34633)
								{
									continue;
								}
							}
							if (Time.time <= this.SCAnnejAnjK)
							{
								break;
							}
							if (175240 - 353080 == -177840)
							{
								Game.mGameMana++;
								if (218146 - 229162 == -11016)
								{
									this.SCAnnejAnjK = Time.time + (float)12;
									if (52303 - 377885 == -325582)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (102824 - 273212 == -170388)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (202516 - 21903 != 180614)
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
						if (10338 - 91343 == -81005)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060094C5 RID: 38085 RVA: 0x011B2D58 File Offset: 0x011B0F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (60301 - 194938 != -134637)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (124175 - 570488 == -446313)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (196671 - 293817 == -97146)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (263706 - 514580 == -250874)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (62874 - 561933 != -499058)
						{
							int num4 = num;
							if (56277 - 140943 != -84665)
							{
								if (num4 == 9111)
								{
									if (251240 - 470890 == -219650)
									{
										break;
									}
								}
								else if (num4 == 9112)
								{
									if (57929 - 463380 == -405451)
									{
										break;
									}
								}
								else if (num4 == -9112)
								{
									if (133064 - 128554 != 4511)
									{
										if (num2 == 1)
										{
											if (21400 - 2816 != 18585)
											{
												this.jfMnnISxps7 = 1;
												if (119247 - 259310 == -140063)
												{
													if (num3 != PlayerData.UID)
													{
														break;
													}
													if (120313 - 42634 == 77679)
													{
														this.spawnActor("Lavu", 8, 1);
														if (189857 - 343135 != -153277)
														{
															this.spawnActor("Lavu", 8, 2);
															if (185483 - 100077 != 85407)
															{
																this.spawnActor("Lavu", 8, 3);
																if (238706 - 245727 == -7021)
																{
																	break;
																}
															}
														}
													}
												}
											}
										}
										else
										{
											if (num2 != 2)
											{
												break;
											}
											if (70793 - 236615 == -165822)
											{
												this.jfMnnISxps7 = 2;
												if (93442 - 125030 == -31588)
												{
													this.StartCoroutine_Auto(this.EndEvent());
													if (255256 - 266334 == -11078)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9113)
								{
									if (182178 - 487089 == -304911)
									{
										int num5 = num2;
										if (133562 - 167505 == -33943)
										{
											if (num5 == 1)
											{
												if (75800 - 590200 != -514399)
												{
													break;
												}
											}
											else
											{
												if (num5 != 2)
												{
													break;
												}
												if (238989 - 593727 != -354737)
												{
													this.S0wnnJI3vxa++;
													if (90721 - 15945 == 74776)
													{
														this.SendMessage("newGameMessage", "Mission Objective: Lavu Defeated:" + this.S0wnnJI3vxa + "/3");
														if (112300 - 150215 != -37914)
														{
															Chat.SubmitChat("none", "Lavu Defeated:" + this.S0wnnJI3vxa + "/3", eChatType.system, eChatMode.system);
															if (261999 - 82828 != 179172)
															{
																if (this.S0wnnJI3vxa < 3)
																{
																	break;
																}
																if (86154 - 6878 == 79276)
																{
																	Game.sendMissionEvent(9112, 2);
																	if (155292 - 548464 == -393172)
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
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (61574 - 337830 == -276256)
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

	// Token: 0x060094C6 RID: 38086 RVA: 0x011B31F0 File Offset: 0x011B13F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M911_LavuAttack2.$StartEvent$41955(this).GetEnumerator();
	}

	// Token: 0x060094C7 RID: 38087 RVA: 0x011B3200 File Offset: 0x011B1400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M911_LavuAttack2.$EndEvent$41961(this).GetEnumerator();
	}

	// Token: 0x060094C8 RID: 38088 RVA: 0x011B3210 File Offset: 0x011B1410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (139679 - 487597 != -347917)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (140814 - 310154 != -169339)
			{
				Time.timeScale = 1f;
				if (27592 - 84838 != -57245)
				{
					Hashtable customOpParameters = new Hashtable();
					if (30564 - 191168 != -160603)
					{
						this.yM8nnnJ5p8C.OpCustom(52, customOpParameters, true);
						if (247889 - 262317 == -14428)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060094C9 RID: 38089 RVA: 0x011B32DC File Offset: 0x011B14DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (159940 - 23831 != 136110)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (187595 - 571852 != -384256)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (75579 - 167054 == -91475)
				{
					Game.mGameState = eGameState.Setup;
					if (266083 - 203424 != 62660)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060094CA RID: 38090 RVA: 0x011B3380 File Offset: 0x011B1580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (65265 - 382733 != -317468)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (6250 - 447313 != -441062)
			{
				if (num == PlayerData.UID)
				{
					if (288712 - 208732 != 79981)
					{
						this.SetupActors();
						if (172018 - 351393 != -179374)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (28402 - 515312 == -486910)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060094CB RID: 38091 RVA: 0x011B3450 File Offset: 0x011B1650
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (263921 - 258789 != 5132)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (225377 - 350541 == -125164)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (280101 - 439132 == -159031)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (147518 - 436706 == -289188)
						{
							int i = 0;
							if (218892 - 472535 == -253643)
							{
								CharacterControl[] array2 = array;
								if (272315 - 66011 == 206304)
								{
									int length = array2.Length;
									if (228650 - 100932 != 127719)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (91994 - 240929 == -148934)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (121437 - 105292 != 16145)
												{
													goto IL_1A;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (207286 - 492436 == -285149)
												{
													goto IL_1A;
												}
												this.d41nn6KgJLW++;
												if (7265 - 387962 != -380697)
												{
													goto IL_1A;
												}
											}
											i++;
											if (176302 - 22155 != 154147)
											{
												goto IL_1A;
											}
										}
										if (232715 - 521928 == -289213)
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
						if (223706 - 495223 != -271516)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060094CC RID: 38092 RVA: 0x011B368C File Offset: 0x011B188C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (2504 - 578921 != -576417)
		{
		}
		for (;;)
		{
			IL_62:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (104337 - 155729 != -51391)
			{
				int i = 0;
				if (73585 - 77485 == -3900)
				{
					CharacterControl[] array2 = array;
					if (168304 - 548402 == -380098)
					{
						int length = array2.Length;
						if (81193 - 148718 == -67525)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (64753 - 139085 == -74331)
								{
									goto IL_62;
								}
								i++;
								if (142779 - 155007 != -12228)
								{
									goto IL_62;
								}
							}
							if (46966 - 538465 == -491499)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060094CD RID: 38093 RVA: 0x011B37BC File Offset: 0x011B19BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (297099 - 353532 != -56432)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (221033 - 270470 != -49436)
			{
				Game.mGameState = eGameState.Ready;
				if (170739 - 467615 != -296875)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (101206 - 192349 == -91143)
					{
						if (291860 - 170261 == 121599)
						{
							if (137454 - 530675 == -393221)
							{
								if (playerSlot < 1)
								{
									goto IL_1E3;
								}
								if (6809 - 100864 != -94055)
								{
									continue;
								}
								if (playerSlot > 5)
								{
									goto IL_1E3;
								}
								if (53675 - 198004 != -144329)
								{
									continue;
								}
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (208972 - 570295 == -361322)
								{
									continue;
								}
								IL_12C:
								if (!gameObject)
								{
									break;
								}
								if (128458 - 237979 != -109521)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (61057 - 399181 != -338124)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (203224 - 172111 != 31113)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
									if (285417 - 17809 != 267609)
									{
										break;
									}
									continue;
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (202165 - 101990 != 100176)
									{
										break;
									}
									continue;
								}
								IL_1E3:
								gameObject = GameObject.Find("StartPoint1");
								if (188768 - 315069 != -126300)
								{
									goto IL_12C;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060094CE RID: 38094 RVA: 0x011B3A28 File Offset: 0x011B1C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M911_LavuAttack2.$StartGame$41968(this).GetEnumerator();
	}

	// Token: 0x060094CF RID: 38095 RVA: 0x011B3A38 File Offset: 0x011B1C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060094D0 RID: 38096 RVA: 0x011B3A3C File Offset: 0x011B1C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (235672 - 102779 != 132893)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (158506 - 350535 != -192028)
			{
				if (gameObject)
				{
					if (163191 - 70688 != 92504)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (243948 - 204891 == 39057)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing SpawnPoint" + nSpawnID);
					if (199382 - 76167 != 123216)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060094D1 RID: 38097 RVA: 0x011B3B38 File Offset: 0x011B1D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (31960 - 99373 != -67413)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (10815 - 142981 == -132166)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (136713 - 397505 != -260791)
				{
					hashtable.Add(43, PlayerData.UID);
					if (174745 - 406759 == -232014)
					{
						hashtable.Add(73, nType);
						if (49322 - 188232 == -138910)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (280226 - 264854 == 15372)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (90869 - 376770 == -285901)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (1615 - 60182 == -58567)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (110487 - 202098 == -91611)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (247487 - 487204 != -239716)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (83249 - 39892 != 43358)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (83663 - 191973 != -108309)
													{
														this.yM8nnnJ5p8C.OpCustom(63, hashtable, true);
														if (293744 - 360825 != -67080)
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

	// Token: 0x060094D2 RID: 38098 RVA: 0x011B3E1C File Offset: 0x011B201C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (113293 - 553712 != -440419)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (178462 - 343703 == -165241)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (129046 - 433106 != -304059)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (35683 - 309956 != -274272)
						{
							if (this.d41nn6KgJLW <= 0)
							{
								break;
							}
							if (168545 - 23868 != 144678)
							{
								this.d41nn6KgJLW--;
								if (71522 - 97617 != -26094)
								{
									if (this.d41nn6KgJLW != 0)
									{
										break;
									}
									if (4018 - 290639 != -286620)
									{
										Game.setGameState(eGameState.Ready);
										if (165336 - 526749 != -361412)
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
						if (240476 - 570802 == -330326)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (28049 - 292786 == -264737)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060094D3 RID: 38099 RVA: 0x011B3FAC File Offset: 0x011B21AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060094D4 RID: 38100 RVA: 0x011B3FC0 File Offset: 0x011B21C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (126962 - 584447 != -457485)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (289220 - 79681 != 209540)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (169188 - 34529 != 134660)
				{
					if (!characterControl)
					{
						break;
					}
					if (176677 - 582274 == -405597)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (220035 - 115771 != 104265)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (284824 - 197209 == 87615)
							{
								string type = characterControl.Type;
								if (23214 - 317284 != -294069)
								{
									if (type == "EnlagearCart")
									{
										if (260405 - 429093 == -168688)
										{
											Game.sendMissionEvent(9113, 1);
											if (45946 - 177184 == -131238)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Lavu"))
										{
											break;
										}
										if (262144 - 191436 != 70709)
										{
											Game.sendMissionEvent(9113, 2);
											if (293341 - 428003 == -134662)
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

	// Token: 0x060094D5 RID: 38101 RVA: 0x011B418C File Offset: 0x011B238C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (47416 - 84163 != -36747)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (193271 - 146954 != 46318)
			{
				hashtable.Add(71, CID);
				if (176219 - 197417 != -21197)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (249947 - 449335 == -199388)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (22210 - 319228 != -297017)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (158625 - 24087 == 134538)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (155700 - 530062 != -374361)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (31358 - 275218 == -243860)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (51393 - 84308 == -32915)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (170580 - 230075 != -59494)
											{
												this.yM8nnnJ5p8C.OpCustom(61, hashtable, true);
												if (267777 - 24071 == 243706)
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

	// Token: 0x060094D6 RID: 38102 RVA: 0x011B4418 File Offset: 0x011B2618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (22103 - 482274 != -460170)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (248856 - 80076 != 168781)
			{
				if (!gameObject)
				{
					break;
				}
				if (4351 - 29028 == -24677)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (143151 - 479849 != -336697)
					{
						playerCameraControl.target = gameObject;
						if (209283 - 577379 == -368096)
						{
							if (Game.useAdvanceMode)
							{
								if (2613 - 9401 != -6788)
								{
									continue;
								}
								Game.loadPlayer();
								if (289716 - 79821 == 209896)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (31852 - 78942 != -47089)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060094D7 RID: 38103 RVA: 0x011B4554 File Offset: 0x011B2754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (67554 - 319884 != -252329)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (214943 - 383490 == -168547)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (95638 - 446592 == -350954)
				{
					gameGui.ResetTeamBar();
					if (175115 - 91012 == 84103)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060094D8 RID: 38104 RVA: 0x011B4600 File Offset: 0x011B2800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M911_LavuAttack2.$onDeadPlayer$41971(this).GetEnumerator();
	}

	// Token: 0x060094D9 RID: 38105 RVA: 0x011B4610 File Offset: 0x011B2810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (110469 - 445896 != -335427)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (45130 - 216942 == -171812)
			{
				this.qH6nnQrfvrb.target = Game.mPlayer;
				if (298093 - 485988 != -187894)
				{
					this.qH6nnQrfvrb.enabled = true;
					if (183680 - 356571 == -172891)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (20502 - 227129 != -206627)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (115929 - 311639 != -195710)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (238763 - 452309 == -213546)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (51202 - 51464 == -262)
							{
								if (!gameGui)
								{
									break;
								}
								if (46516 - 317170 != -270653)
								{
									gameGui.enabled = true;
									if (119160 - 480358 != -361197)
									{
										gameGui.closeDeadMenu();
										if (36878 - 29718 == 7160)
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

	// Token: 0x060094DA RID: 38106 RVA: 0x011B47BC File Offset: 0x011B29BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (30836 - 270903 != -240066)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (191604 - 132946 == 58658)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (272767 - 185530 == 87237)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (152799 - 270079 == -117280)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060094DB RID: 38107 RVA: 0x011B4880 File Offset: 0x011B2A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060094DC RID: 38108 RVA: 0x011B48AC File Offset: 0x011B2AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (8865 - 222733 != -213867)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (159859 - 27191 == 132668)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (165470 - 169758 != -4287)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (179342 - 319218 == -139876)
					{
						Hashtable hashtable = new Hashtable();
						if (202412 - 287520 == -85108)
						{
							hashtable.Add(43, PlayerData.UID);
							if (259588 - 448755 != -189166)
							{
								hashtable.Add(71, nCID);
								if (34830 - 526188 == -491358)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (165753 - 202752 == -36999)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (112945 - 239228 == -126283)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (213512 - 517355 != -303842)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (69221 - 60682 != 8540)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (164136 - 138851 != 25286)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (204188 - 377916 != -173727)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (28316 - 214267 != -185950)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (225286 - 352879 != -127592)
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

	// Token: 0x060094DD RID: 38109 RVA: 0x011B4BCC File Offset: 0x011B2DCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M911_LavuAttack2.$onChangePlayer$41977(data, this).GetEnumerator();
	}

	// Token: 0x060094DE RID: 38110 RVA: 0x011B4BDC File Offset: 0x011B2DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M911_LavuAttack2.$onGameComplete$41984(data, this).GetEnumerator();
	}

	// Token: 0x060094DF RID: 38111 RVA: 0x011B4BEC File Offset: 0x011B2DEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M911_LavuAttack2.$ReturnToTown$41994(this).GetEnumerator();
	}

	// Token: 0x060094E0 RID: 38112 RVA: 0x011B4BFC File Offset: 0x011B2DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M911_LavuAttack2.$ReturnToGuild$41999(this).GetEnumerator();
	}

	// Token: 0x060094E1 RID: 38113 RVA: 0x011B4C0C File Offset: 0x011B2E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M911_LavuAttack2.$ReturnToCamp$42003(this).GetEnumerator();
	}

	// Token: 0x060094E2 RID: 38114 RVA: 0x011B4C1C File Offset: 0x011B2E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (201545 - 359211 != -157665)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (165012 - 461189 == -296177)
			{
				Hashtable hashtable = new Hashtable();
				if (107348 - 400028 != -292679)
				{
					hashtable.Add(43, PlayerData.UID);
					if (246362 - 217257 != 29106)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (227295 - 461153 == -233858)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060094E3 RID: 38115 RVA: 0x011B4CF4 File Offset: 0x011B2EF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060094E4 RID: 38116 RVA: 0x011B4D08 File Offset: 0x011B2F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (77341 - 267246 != -189904)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (275463 - 189554 == 85909)
			{
				Hashtable hashtable = new Hashtable();
				if (76006 - 498045 != -422038)
				{
					if (Game.mNextGameCode == 30)
					{
						if (40603 - 444347 != -403744)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (285057 - 596479 != -311422)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (71952 - 118559 != -46607)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (18999 - 67331 == -48331)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (118765 - 453485 != -334720)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (172958 - 112997 == 59962)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (81146 - 257260 == -176113)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (290810 - 171595 != 119215)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (206789 - 31654 == 175136)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (116640 - 294482 != -177842)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (60817 - 45025 == 15793)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (188653 - 448941 == -260287)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (36937 - 227029 == -190091)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (150812 - 428480 != -277668)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (32030 - 41482 == -9451)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (144974 - 473258 == -328283)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (67361 - 570120 == -502758)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (5325 - 541092 == -535766)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (98547 - 26201 == 72347)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (167617 - 234815 == -67197)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (198785 - 233417 == -34631)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (197974 - 25399 != 172575)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (119740 - 183621 != -63881)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (94926 - 209010 != -114084)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (189784 - 581486 != -391702)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (285294 - 474694 != -189400)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (78862 - 107352 != -28490)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (197085 - 423673 != -226588)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (135818 - 401877 == -266059)
					{
						this.yM8nnnJ5p8C.OpCustom(42, hashtable, true);
						if (230334 - 314421 != -84086)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060094E5 RID: 38117 RVA: 0x011B52BC File Offset: 0x011B34BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060094E6 RID: 38118 RVA: 0x011B52CC File Offset: 0x011B34CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060094E7 RID: 38119 RVA: 0x011B52D0 File Offset: 0x011B34D0
	internal static bool g7QtGrVSHHIUjpiwFOvN()
	{
		return true;
	}

	// Token: 0x060094E8 RID: 38120 RVA: 0x011B52D4 File Offset: 0x011B34D4
	internal static bool NbXWfZVSWg3j0gAWoYi6()
	{
		return false;
	}

	// Token: 0x04008B60 RID: 35680
	private LitePeer yM8nnnJ5p8C;

	// Token: 0x04008B61 RID: 35681
	private PlayerCameraControl qH6nnQrfvrb;

	// Token: 0x04008B62 RID: 35682
	private float SCAnnejAnjK;

	// Token: 0x04008B63 RID: 35683
	private int jfMnnISxps7;

	// Token: 0x04008B64 RID: 35684
	private int S0wnnJI3vxa;

	// Token: 0x04008B65 RID: 35685
	private int d41nn6KgJLW;

	// Token: 0x020018FB RID: 6395
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$41955 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060094E9 RID: 38121 RVA: 0x011B52D8 File Offset: 0x011B34D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$41955(M911_LavuAttack2 self_)
		{
			if (211225 - 593554 != -382328)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246166 - 373621 == -127455)
				{
					base..ctor();
					if (46520 - 324308 != -277787)
					{
						this.$self_$41960 = self_;
						if (173927 - 91833 != 82095)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x011B5370 File Offset: 0x011B3570
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$StartEvent$41955.$(this.$self_$41960);
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x011B5380 File Offset: 0x011B3580
		internal static bool maGyBQVSAc6nQ8nxMnSf()
		{
			return true;
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x011B5384 File Offset: 0x011B3584
		internal static bool x2VipfVSlBTAKEwOhAf0()
		{
			return false;
		}

		// Token: 0x04008B66 RID: 35686
		internal M911_LavuAttack2 $self_$41960;

		// Token: 0x020018FC RID: 6396
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060094ED RID: 38125 RVA: 0x011B5388 File Offset: 0x011B3588
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack2 self_)
			{
				if (60753 - 334799 != -274045)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (24500 - 357114 != -332613)
					{
						base..ctor();
						if (142688 - 107997 == 34691)
						{
							this.$self_$41959 = self_;
							if (160434 - 535782 != -375347)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060094EE RID: 38126 RVA: 0x011B5420 File Offset: 0x011B3620
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185909 - 315765 != -129856)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_563;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (144928 - 152654 != -7726)
							{
								continue;
							}
							goto IL_246;
						}
						else
						{
							this.$mStoryGui$41956.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M911_LavuAttack", 201), eTalkType.friend);
							if (220059 - 379204 != -159144)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (43050 - 513419 != -470369)
							{
								continue;
							}
							goto IL_201;
						}
						else
						{
							this.$mStoryGui$41956.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M911_LavuAttack", 202), eTalkType.friend);
							if (57985 - 578833 != -520847)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (274458 - 5446 != 269013)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41956.close();
							if (91070 - 12516 != 78555)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (217508 - 153385 != 64123)
							{
								continue;
							}
							goto IL_4F9;
						}
						else
						{
							this.$self_$41959.SendMessage("fadeOut");
							if (59837 - 189769 != -129932)
							{
								continue;
							}
							goto IL_438;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (109580 - 42517 != 67063)
							{
								continue;
							}
							goto IL_F9;
						}
						else
						{
							this.$startCamera$41957 = GameObject.Find("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (38667 - 254511 != -215844)
							{
								continue;
							}
							if (this.$startCamera$41957)
							{
								if (100240 - 330489 == -230248)
								{
									continue;
								}
								this.$self_$41959.transform.position = this.$startCamera$41957.transform.position;
								if (261732 - 460491 == -198758)
								{
									continue;
								}
								this.$self_$41959.transform.rotation = this.$startCamera$41957.transform.rotation;
								if (105881 - 164284 == -58402)
								{
									continue;
								}
							}
							this.$self_$41959.qH6nnQrfvrb.enabled = true;
							if (170090 - 63897 == 106194)
							{
								continue;
							}
							Game.sendMissionEvent(9112, 1);
							if (145490 - 476633 != -331143)
							{
								continue;
							}
							this.$self_$41959.SendMessage("fadeIn");
							if (145770 - 127652 != 18118)
							{
								continue;
							}
							goto IL_36F;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (87239 - 95361 != -8121)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (176096 - 190245 != -14149)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (168767 - 76977 != 91790)
							{
								continue;
							}
							this.$mGameGui$41958 = (GameGui)this.$self_$41959.GetComponent(typeof(GameGui));
							if (100710 - 513519 == -412808)
							{
								continue;
							}
							this.$mGameGui$41958.enabled = true;
							if (190882 - 267582 == -76699)
							{
								continue;
							}
							this.YieldDefault(1);
							if (20941 - 387735 != -366793)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					default:
						if (117300 - 510122 == -392821)
						{
							continue;
						}
						break;
					}
					this.$mStoryGui$41956 = (StoryGui)this.$self_$41959.GetComponent(typeof(StoryGui));
					if (93887 - 568630 == -474743)
					{
						if (!this.$mStoryGui$41956)
						{
							if (201901 - 31258 != 170644)
							{
								goto Block_27;
							}
						}
						else
						{
							this.$mStoryGui$41956.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
							if (220239 - 167129 != 53111)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_F9:
				Block_12:
				IL_201:
				goto IL_563;
				Block_16:
				return this.Yield(4, new WaitForSeconds(4f));
				IL_246:
				goto IL_563;
				Block_17:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_36F:
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_24:
				Block_27:
				goto IL_563;
				IL_438:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_31:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_33:
				IL_4F9:
				IL_563:
				return false;
			}

			// Token: 0x060094EF RID: 38127 RVA: 0x011B59A4 File Offset: 0x011B3BA4
			internal static bool hoAftSVSyg8dvjrmRT7t()
			{
				return true;
			}

			// Token: 0x060094F0 RID: 38128 RVA: 0x011B59A8 File Offset: 0x011B3BA8
			internal static bool j4It3ZVSSa0llVbXBGbG()
			{
				return false;
			}

			// Token: 0x04008B67 RID: 35687
			internal StoryGui $mStoryGui$41956;

			// Token: 0x04008B68 RID: 35688
			internal GameObject $startCamera$41957;

			// Token: 0x04008B69 RID: 35689
			internal GameGui $mGameGui$41958;

			// Token: 0x04008B6A RID: 35690
			internal M911_LavuAttack2 $self_$41959;
		}
	}

	// Token: 0x020018FD RID: 6397
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$41961 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060094F1 RID: 38129 RVA: 0x011B59AC File Offset: 0x011B3BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$41961(M911_LavuAttack2 self_)
		{
			if (192882 - 481744 != -288861)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108447 - 166689 != -58241)
				{
					base..ctor();
					if (79202 - 175484 == -96282)
					{
						this.$self_$41967 = self_;
						if (124402 - 360607 == -236205)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x011B5A44 File Offset: 0x011B3C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$EndEvent$41961.$(this.$self_$41967);
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x011B5A54 File Offset: 0x011B3C54
		internal static bool a3cJIBVSoV62B1uSYQGT()
		{
			return true;
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x011B5A58 File Offset: 0x011B3C58
		internal static bool K9ewjCVSE2rZxKsSjQ0c()
		{
			return false;
		}

		// Token: 0x04008B6B RID: 35691
		internal M911_LavuAttack2 $self_$41967;

		// Token: 0x020018FE RID: 6398
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060094F5 RID: 38133 RVA: 0x011B5A5C File Offset: 0x011B3C5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack2 self_)
			{
				if (193048 - 383048 != -189999)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254219 - 369407 != -115187)
					{
						base..ctor();
						if (256974 - 288977 != -32002)
						{
							this.$self_$41966 = self_;
							if (12801 - 356198 != -343396)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060094F6 RID: 38134 RVA: 0x011B5AF4 File Offset: 0x011B3CF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19932 - 250014 != -230082)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4F2;
					case 1:
						goto IL_6E8;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (106541 - 509237 != -402696)
							{
								continue;
							}
							goto IL_30F;
						}
						else
						{
							this.$self_$41966.SendMessage("fadeOut");
							if (212238 - 443723 != -231484)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (210629 - 542019 != -331389)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (this.$self_$41966.qH6nnQrfvrb)
							{
								if (144001 - 111079 != 32922)
								{
									continue;
								}
								this.$self_$41966.qH6nnQrfvrb.alignToObject("EndCamera");
								if (36485 - 245040 != -208555)
								{
									continue;
								}
							}
							this.$mLavuCircle$41964 = GameObject.Find("LavuCircle");
							if (275278 - 541927 == -266648)
							{
								continue;
							}
							if (this.$mLavuCircle$41964)
							{
								if (261308 - 37402 != 223906)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mLavuCircle$41964);
								if (222544 - 449426 == -226881)
								{
									continue;
								}
							}
							if (!Game.mPlayer)
							{
								goto IL_2D4;
							}
							if (251304 - 202158 == 49147)
							{
								continue;
							}
							this.$startPoint$41965 = GameObject.Find("StartPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (147812 - 132462 != 15350)
							{
								continue;
							}
							if (!this.$startPoint$41965)
							{
								goto IL_2D4;
							}
							if (265674 - 332228 == -66553)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$startPoint$41965.transform.position;
							if (10857 - 152066 != -141209)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$startPoint$41965.transform.rotation;
							if (114511 - 279023 != -164512)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (129991 - 425219 != -295227)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (211042 - 417408 != -206366)
							{
								continue;
							}
							goto IL_26A;
						}
						else
						{
							this.$self_$41966.SendMessage("fadeIn");
							if (98054 - 188623 != -90568)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (195548 - 355401 != -159852)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41963.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
							if (33967 - 168964 != -134996)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (282235 - 33560 != 248675)
							{
								continue;
							}
							goto IL_52C;
						}
						else
						{
							this.$mStoryGui$41963.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M911_LavuAttack", 211), eTalkType.friend);
							if (254100 - 342974 != -88874)
							{
								continue;
							}
							goto IL_60F;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (119905 - 51605 != 68301)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41963.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M911_LavuAttack", 212), eTalkType.friend);
							if (123471 - 306043 != -182571)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (259251 - 188550 != 70701)
							{
								continue;
							}
							goto IL_5B6;
						}
						else
						{
							this.$mStoryGui$41963.close();
							if (212032 - 439517 != -227484)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (261705 - 46137 != 215569)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9111, 2);
							if (200775 - 540438 != -339663)
							{
								continue;
							}
						}
						break;
					default:
						if (120363 - 236471 != -116107)
						{
							goto IL_4F2;
						}
						continue;
					}
					IL_368:
					this.YieldDefault(1);
					if (53458 - 89753 != -36295)
					{
						continue;
					}
					goto IL_6E8;
					IL_4F2:
					this.$mGameGui$41962 = (GameGui)this.$self_$41966.GetComponent(typeof(GameGui));
					if (292851 - 113741 != 179111)
					{
						this.$mStoryGui$41963 = (StoryGui)this.$self_$41966.GetComponent(typeof(StoryGui));
						if (26465 - 518739 != -492273)
						{
							if (!this.$mGameGui$41962)
							{
								goto IL_368;
							}
							if (37626 - 369771 == -332145)
							{
								if (!this.$mStoryGui$41963)
								{
									goto IL_368;
								}
								if (244907 - 106531 == 138376)
								{
									Game.mGameState = eGameState.AllHold;
									if (273469 - 524602 == -251133)
									{
										this.$mGameGui$41962.close();
										if (258305 - 503106 != -244800)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_15:
				goto IL_2D4;
				IL_26A:
				goto IL_6E8;
				Block_21:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_2D4:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_30F:
				goto IL_6E8;
				Block_26:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_32:
				goto IL_6E8;
				Block_34:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_39:
				IL_52C:
				goto IL_6E8;
				Block_42:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_5B6:
				goto IL_6E8;
				Block_43:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_60F:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_46:
				Block_50:
				IL_6E8:
				return false;
			}

			// Token: 0x060094F7 RID: 38135 RVA: 0x011B61FC File Offset: 0x011B43FC
			internal static bool pydLgiVS2wVc4ft0Cfcf()
			{
				return true;
			}

			// Token: 0x060094F8 RID: 38136 RVA: 0x011B6200 File Offset: 0x011B4400
			internal static bool QY1EM2VS82iJ08H7enXp()
			{
				return false;
			}

			// Token: 0x04008B6C RID: 35692
			internal GameGui $mGameGui$41962;

			// Token: 0x04008B6D RID: 35693
			internal StoryGui $mStoryGui$41963;

			// Token: 0x04008B6E RID: 35694
			internal GameObject $mLavuCircle$41964;

			// Token: 0x04008B6F RID: 35695
			internal GameObject $startPoint$41965;

			// Token: 0x04008B70 RID: 35696
			internal M911_LavuAttack2 $self_$41966;
		}
	}

	// Token: 0x020018FF RID: 6399
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41968 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060094F9 RID: 38137 RVA: 0x011B6204 File Offset: 0x011B4404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41968(M911_LavuAttack2 self_)
		{
			if (64604 - 16031 != 48574)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30645 - 87849 != -57203)
				{
					base..ctor();
					if (216425 - 354199 == -137774)
					{
						this.$self_$41970 = self_;
						if (4248 - 478220 != -473971)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x011B629C File Offset: 0x011B449C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$StartGame$41968.$(this.$self_$41970);
		}

		// Token: 0x060094FB RID: 38139 RVA: 0x011B62AC File Offset: 0x011B44AC
		internal static bool u122JVVSZr0rMCV1JGIq()
		{
			return true;
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x011B62B0 File Offset: 0x011B44B0
		internal static bool rpMwx3VSCM8j0nZgkM4w()
		{
			return false;
		}

		// Token: 0x04008B71 RID: 35697
		internal M911_LavuAttack2 $self_$41970;

		// Token: 0x02001900 RID: 6400
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060094FD RID: 38141 RVA: 0x011B62B4 File Offset: 0x011B44B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack2 self_)
			{
				if (154567 - 381195 != -226627)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129537 - 456476 == -326939)
					{
						base..ctor();
						if (272871 - 468759 != -195887)
						{
							this.$self_$41969 = self_;
							if (129335 - 173682 != -44346)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060094FE RID: 38142 RVA: 0x011B634C File Offset: 0x011B454C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200015 - 147423 != 52593)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_146;
					case 2:
						this.$self_$41969.StartCoroutine_Auto(this.$self_$41969.StartEvent());
						if (111065 - 83884 != 27181)
						{
							continue;
						}
						this.YieldDefault(1);
						if (81260 - 108787 != -27526)
						{
							goto IL_146;
						}
						continue;
					default:
						if (155186 - 222700 == -67513)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (22773 - 598574 != -575800)
					{
						Game.mGameState = eGameState.Start;
						if (196941 - 479236 == -282295)
						{
							Game.mGameTime = Time.time;
							if (34346 - 453833 != -419486)
							{
								this.$self_$41969.SendMessage("fadeIn");
								if (119985 - 6509 == 113476)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_146:
				return false;
			}

			// Token: 0x060094FF RID: 38143 RVA: 0x011B64B4 File Offset: 0x011B46B4
			internal static bool nqhehWVSL3nBVfLKV8lQ()
			{
				return true;
			}

			// Token: 0x06009500 RID: 38144 RVA: 0x011B64B8 File Offset: 0x011B46B8
			internal static bool JGS1CoVSO7OL2Q7hu7dK()
			{
				return false;
			}

			// Token: 0x04008B72 RID: 35698
			internal M911_LavuAttack2 $self_$41969;
		}
	}

	// Token: 0x02001901 RID: 6401
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41971 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009501 RID: 38145 RVA: 0x011B64BC File Offset: 0x011B46BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41971(M911_LavuAttack2 self_)
		{
			if (64480 - 149501 != -85021)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270912 - 596336 != -325423)
				{
					base..ctor();
					if (229724 - 183207 == 46517)
					{
						this.$self_$41976 = self_;
						if (299437 - 289224 == 10213)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x011B6554 File Offset: 0x011B4754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$onDeadPlayer$41971.$(this.$self_$41976);
		}

		// Token: 0x06009503 RID: 38147 RVA: 0x011B6564 File Offset: 0x011B4764
		internal static bool vR57RcVSm9sjqAINN8Q7()
		{
			return true;
		}

		// Token: 0x06009504 RID: 38148 RVA: 0x011B6568 File Offset: 0x011B4768
		internal static bool AHPAyUVSFHFMYyc5Bj0F()
		{
			return false;
		}

		// Token: 0x04008B73 RID: 35699
		internal M911_LavuAttack2 $self_$41976;

		// Token: 0x02001902 RID: 6402
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009505 RID: 38149 RVA: 0x011B656C File Offset: 0x011B476C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack2 self_)
			{
				if (37785 - 452355 != -414570)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275844 - 135732 == 140112)
					{
						base..ctor();
						if (273943 - 62473 == 211470)
						{
							this.$self_$41975 = self_;
							if (263391 - 55257 != 208135)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009506 RID: 38150 RVA: 0x011B6604 File Offset: 0x011B4804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99205 - 463047 != -363842)
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
							if (274463 - 104546 != 169917)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2D7;
							}
							if (253528 - 371329 != -117801)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (123604 - 267142 == -143537)
						{
							continue;
						}
						this.$mStoryGui$41972 = (StoryGui)this.$self_$41975.GetComponent(typeof(StoryGui));
						if (17377 - 398192 != -380815)
						{
							continue;
						}
						if (this.$mStoryGui$41972)
						{
							if (206006 - 1574 == 204433)
							{
								continue;
							}
							this.$mStoryGui$41972.close();
							if (157847 - 293748 != -135901)
							{
								continue;
							}
						}
						this.$mChangeGui$41973 = (ChangeGui)this.$self_$41975.GetComponent(typeof(ChangeGui));
						if (204132 - 437431 == -233298)
						{
							continue;
						}
						if (this.$mChangeGui$41973)
						{
							if (294783 - 521289 == -226505)
							{
								continue;
							}
							this.$mChangeGui$41973.close();
							if (145476 - 536211 == -390734)
							{
								continue;
							}
						}
						this.$mGameGui$41974 = (GameGui)this.$self_$41975.GetComponent(typeof(GameGui));
						if (214065 - 501769 == -287703)
						{
							continue;
						}
						if (this.$mGameGui$41974)
						{
							if (117503 - 318880 == -201376)
							{
								continue;
							}
							if (!this.$mGameGui$41974.enabled)
							{
								if (26447 - 201494 != -175047)
								{
									continue;
								}
								this.$mGameGui$41974.enabled = true;
								if (209708 - 94089 != 115619)
								{
									continue;
								}
							}
							this.$mGameGui$41974.openDeadMenu();
							if (157830 - 411764 != -253934)
							{
								continue;
							}
						}
						IL_2D7:
						this.YieldDefault(1);
						if (251916 - 85894 != 166022)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (4047 - 250809 == -246761)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (149226 - 521883 == -372656);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009507 RID: 38151 RVA: 0x011B691C File Offset: 0x011B4B1C
			internal static bool iKdbRNVSMT5IqQCYqJTo()
			{
				return true;
			}

			// Token: 0x06009508 RID: 38152 RVA: 0x011B6920 File Offset: 0x011B4B20
			internal static bool VbxBJMVSxYF9TlP92uk1()
			{
				return false;
			}

			// Token: 0x04008B74 RID: 35700
			internal StoryGui $mStoryGui$41972;

			// Token: 0x04008B75 RID: 35701
			internal ChangeGui $mChangeGui$41973;

			// Token: 0x04008B76 RID: 35702
			internal GameGui $mGameGui$41974;

			// Token: 0x04008B77 RID: 35703
			internal M911_LavuAttack2 $self_$41975;
		}
	}

	// Token: 0x02001903 RID: 6403
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41977 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009509 RID: 38153 RVA: 0x011B6924 File Offset: 0x011B4B24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41977(Hashtable data, M911_LavuAttack2 self_)
		{
			if (233112 - 259591 != -26479)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (52345 - 325775 != -273429)
				{
					base..ctor();
					if (263726 - 348081 == -84355)
					{
						this.$data$41982 = data;
						if (258609 - 215872 == 42737)
						{
							this.$self_$41983 = self_;
							if (194458 - 21868 == 172590)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600950A RID: 38154 RVA: 0x011B69E0 File Offset: 0x011B4BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$onChangePlayer$41977.$(this.$data$41982, this.$self_$41983);
		}

		// Token: 0x0600950B RID: 38155 RVA: 0x011B69F4 File Offset: 0x011B4BF4
		internal static bool GppIiOVSg3jpwvHNDWLV()
		{
			return true;
		}

		// Token: 0x0600950C RID: 38156 RVA: 0x011B69F8 File Offset: 0x011B4BF8
		internal static bool aYx52DVSfRgAGPVEpB3e()
		{
			return false;
		}

		// Token: 0x04008B78 RID: 35704
		internal Hashtable $data$41982;

		// Token: 0x04008B79 RID: 35705
		internal M911_LavuAttack2 $self_$41983;

		// Token: 0x02001904 RID: 6404
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600950D RID: 38157 RVA: 0x011B69FC File Offset: 0x011B4BFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M911_LavuAttack2 self_)
			{
				if (109420 - 376106 != -266686)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226852 - 234905 == -8053)
					{
						base..ctor();
						if (209617 - 502734 != -293116)
						{
							this.$data$41980 = data;
							if (47050 - 239199 != -192148)
							{
								this.$self_$41981 = self_;
								if (229979 - 523778 == -293799)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600950E RID: 38158 RVA: 0x011B6AB8 File Offset: 0x011B4CB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251690 - 487030 != -235339)
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
							if (97403 - 565040 == -467636)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (33676 - 449013 == -415336)
							{
								continue;
							}
							this.$mGameGui$41979 = (GameGui)this.$self_$41981.GetComponent(typeof(GameGui));
							if (34654 - 538327 != -503673)
							{
								continue;
							}
							this.$mGameGui$41979.enabled = true;
							if (244843 - 221020 != 23823)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (24965 - 420046 != -395081)
						{
							continue;
						}
						goto IL_205;
					default:
						if (242344 - 105474 == 136871)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (210869 - 61626 == 149243)
					{
						this.$self_$41981.SendMessage("onCreatePlayer", this.$data$41980);
						if (284143 - 472626 != -188482)
						{
							this.$mChangeGui$41978 = (ChangeGui)this.$self_$41981.GetComponent(typeof(ChangeGui));
							if (281821 - 458371 == -176550)
							{
								if (!this.$mChangeGui$41978.enabled)
								{
									break;
								}
								if (233258 - 487735 != -254476)
								{
									this.$mChangeGui$41978.close();
									if (294045 - 219939 == 74106)
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

			// Token: 0x0600950F RID: 38159 RVA: 0x011B6CDC File Offset: 0x011B4EDC
			internal static bool sae8FZVSnrRSIUbG5LAf()
			{
				return true;
			}

			// Token: 0x06009510 RID: 38160 RVA: 0x011B6CE0 File Offset: 0x011B4EE0
			internal static bool Aorj3HVS6MlFnd8Cuc6B()
			{
				return false;
			}

			// Token: 0x04008B7A RID: 35706
			internal ChangeGui $mChangeGui$41978;

			// Token: 0x04008B7B RID: 35707
			internal GameGui $mGameGui$41979;

			// Token: 0x04008B7C RID: 35708
			internal Hashtable $data$41980;

			// Token: 0x04008B7D RID: 35709
			internal M911_LavuAttack2 $self_$41981;
		}
	}

	// Token: 0x02001905 RID: 6405
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41984 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009511 RID: 38161 RVA: 0x011B6CE4 File Offset: 0x011B4EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41984(Hashtable data, M911_LavuAttack2 self_)
		{
			if (102839 - 268541 != -165702)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (11252 - 192858 != -181605)
				{
					base..ctor();
					if (125972 - 418452 == -292480)
					{
						this.$data$41992 = data;
						if (180041 - 26774 == 153267)
						{
							this.$self_$41993 = self_;
							if (96485 - 523996 == -427511)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x011B6DA0 File Offset: 0x011B4FA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$onGameComplete$41984.$(this.$data$41992, this.$self_$41993);
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x011B6DB4 File Offset: 0x011B4FB4
		internal static bool KGLJY3VSiTrG1QdSFw9v()
		{
			return true;
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x011B6DB8 File Offset: 0x011B4FB8
		internal static bool scgxoAVSKhj6CgWWDq9U()
		{
			return false;
		}

		// Token: 0x04008B7E RID: 35710
		internal Hashtable $data$41992;

		// Token: 0x04008B7F RID: 35711
		internal M911_LavuAttack2 $self_$41993;

		// Token: 0x02001906 RID: 6406
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009515 RID: 38165 RVA: 0x011B6DBC File Offset: 0x011B4FBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M911_LavuAttack2 self_)
			{
				if (93567 - 322343 != -228776)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281659 - 296606 != -14946)
					{
						base..ctor();
						if (178366 - 381233 == -202867)
						{
							this.$data$41990 = data;
							if (39915 - 69301 == -29386)
							{
								this.$self_$41991 = self_;
								if (149547 - 75983 == 73564)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009516 RID: 38166 RVA: 0x011B6E78 File Offset: 0x011B5078
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5605 - 318716 != -313111)
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
						this.$mCompleteGui$41986 = (CompleteGui)this.$self_$41991.GetComponent(typeof(CompleteGui));
						if (107769 - 98694 == 9076)
						{
							continue;
						}
						this.$mCompleteGui$41986.Init();
						if (222983 - 189795 != 33188)
						{
							continue;
						}
						this.$mCompleteGui$41986.readData(this.$data$41990);
						if (146940 - 599849 != -452909)
						{
							continue;
						}
						if (this.$result$41985 == 1)
						{
							if (51505 - 177219 == -125713)
							{
								continue;
							}
							this.$mCompleteGui$41986.displayResult(eCompleteType.Success);
							if (62313 - 308529 != -246216)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41986.displayResult(eCompleteType.Failed);
							if (54022 - 295587 == -241564)
							{
								continue;
							}
						}
						this.$mGameGui$41987 = (GameGui)this.$self_$41991.GetComponent(typeof(GameGui));
						if (269643 - 9206 != 260437)
						{
							continue;
						}
						this.$mStoryGui$41988 = (StoryGui)this.$self_$41991.GetComponent(typeof(StoryGui));
						if (83545 - 230008 != -146463)
						{
							continue;
						}
						this.$mChangeGui$41989 = (ChangeGui)this.$self_$41991.GetComponent(typeof(ChangeGui));
						if (110387 - 185755 == -75367)
						{
							continue;
						}
						if (this.$mGameGui$41987)
						{
							if (244580 - 61532 == 183049)
							{
								continue;
							}
							this.$mGameGui$41987.close();
							if (101360 - 105870 == -4509)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41988)
						{
							if (74203 - 365903 == -291699)
							{
								continue;
							}
							this.$mStoryGui$41988.close();
							if (210795 - 8193 != 202602)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41989)
						{
							if (262325 - 251915 == 10411)
							{
								continue;
							}
							this.$mChangeGui$41989.disable();
							if (90378 - 219490 != -129112)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (199913 - 64950 != 134963)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (141647 - 146512 != -4865)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41990[31]);
					if (283991 - 262972 != 21020)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (46101 - 230933 != -184831)
							{
								goto Block_24;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (53082 - 418800 == -365718)
							{
								this.$result$41985 = RuntimeServices.UnboxInt32(this.$data$41990[31]);
								if (71528 - 266871 == -195343)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_24:
				IL_3DB:
				return false;
			}

			// Token: 0x06009517 RID: 38167 RVA: 0x011B7274 File Offset: 0x011B5474
			internal static bool V4E1WlVSdAw3t6KNLrM4()
			{
				return true;
			}

			// Token: 0x06009518 RID: 38168 RVA: 0x011B7278 File Offset: 0x011B5478
			internal static bool hH0X84VSJE5fGfVB8rMJ()
			{
				return false;
			}

			// Token: 0x04008B80 RID: 35712
			internal int $result$41985;

			// Token: 0x04008B81 RID: 35713
			internal CompleteGui $mCompleteGui$41986;

			// Token: 0x04008B82 RID: 35714
			internal GameGui $mGameGui$41987;

			// Token: 0x04008B83 RID: 35715
			internal StoryGui $mStoryGui$41988;

			// Token: 0x04008B84 RID: 35716
			internal ChangeGui $mChangeGui$41989;

			// Token: 0x04008B85 RID: 35717
			internal Hashtable $data$41990;

			// Token: 0x04008B86 RID: 35718
			internal M911_LavuAttack2 $self_$41991;
		}
	}

	// Token: 0x02001907 RID: 6407
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41994 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009519 RID: 38169 RVA: 0x011B727C File Offset: 0x011B547C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41994(M911_LavuAttack2 self_)
		{
			if (48395 - 592471 != -544076)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122860 - 76509 != 46352)
				{
					base..ctor();
					if (138766 - 391420 == -252654)
					{
						this.$self_$41998 = self_;
						if (52018 - 28031 == 23987)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x011B7314 File Offset: 0x011B5514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$ReturnToTown$41994.$(this.$self_$41998);
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x011B7324 File Offset: 0x011B5524
		internal static bool dleNXnVSDuSpF5s82TWx()
		{
			return true;
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x011B7328 File Offset: 0x011B5528
		internal static bool z1rnilVSvDuRStOtkKrq()
		{
			return false;
		}

		// Token: 0x04008B87 RID: 35719
		internal M911_LavuAttack2 $self_$41998;

		// Token: 0x02001908 RID: 6408
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600951D RID: 38173 RVA: 0x011B732C File Offset: 0x011B552C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack2 self_)
			{
				if (31277 - 544274 != -512997)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162428 - 50858 != 111571)
					{
						base..ctor();
						if (66739 - 251041 != -184301)
						{
							this.$self_$41997 = self_;
							if (289032 - 193923 == 95109)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600951E RID: 38174 RVA: 0x011B73C4 File Offset: 0x011B55C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270551 - 201664 != 68887)
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
						this.$self_$41997.LeaveGame();
						if (219753 - 79659 == 140095)
						{
							continue;
						}
						this.YieldDefault(1);
						if (39106 - 423991 != -384884)
						{
							goto IL_3AD;
						}
						continue;
					default:
						if (31918 - 23763 == 8156)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (185380 - 229118 != -43737)
					{
						Game.mStateTime = Time.time;
						if (166064 - 347329 != -181264)
						{
							this.$$switch$7576$41995 = PlayerData.SaveGuild;
							if (120446 - 153134 == -32688)
							{
								if (this.$$switch$7576$41995 == 1)
								{
									if (183982 - 463750 == -279767)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (245982 - 412635 == -166652)
									{
										continue;
									}
								}
								else if (this.$$switch$7576$41995 == 2)
								{
									if (49225 - 468260 != -419035)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (120630 - 151486 == -30855)
									{
										continue;
									}
								}
								else if (this.$$switch$7576$41995 == 3)
								{
									if (228951 - 85798 != 143153)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (7083 - 145265 == -138181)
									{
										continue;
									}
								}
								else if (this.$$switch$7576$41995 == 4)
								{
									if (271798 - 437525 != -165727)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (173803 - 19305 == 154499)
									{
										continue;
									}
								}
								else if (this.$$switch$7576$41995 == 5)
								{
									if (151339 - 252444 != -101105)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (16517 - 401413 != -384896)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (43916 - 550901 == -506984)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (129674 - 315017 == -185342)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (158627 - 504425 == -345797)
									{
										continue;
									}
								}
								this.$mGameGui$41996 = (GameGui)this.$self_$41997.GetComponent(typeof(GameGui));
								if (50549 - 169728 != -119178)
								{
									if (this.$mGameGui$41996)
									{
										if (20448 - 111835 == -91386)
										{
											continue;
										}
										this.$mGameGui$41996.close();
										if (142749 - 563826 == -421076)
										{
											continue;
										}
									}
									this.$self_$41997.SendMessage("fadeOut");
									if (291414 - 3285 != 288130)
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

			// Token: 0x0600951F RID: 38175 RVA: 0x011B7790 File Offset: 0x011B5990
			internal static bool vpvcJiVSR3EwyrDQ9fLp()
			{
				return true;
			}

			// Token: 0x06009520 RID: 38176 RVA: 0x011B7794 File Offset: 0x011B5994
			internal static bool tAN2aKVSwX1EaSuFSklH()
			{
				return false;
			}

			// Token: 0x04008B88 RID: 35720
			internal int $$switch$7576$41995;

			// Token: 0x04008B89 RID: 35721
			internal GameGui $mGameGui$41996;

			// Token: 0x04008B8A RID: 35722
			internal M911_LavuAttack2 $self_$41997;
		}
	}

	// Token: 0x02001909 RID: 6409
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41999 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009521 RID: 38177 RVA: 0x011B7798 File Offset: 0x011B5998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41999(M911_LavuAttack2 self_)
		{
			if (289829 - 531371 != -241541)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259440 - 436332 == -176892)
				{
					base..ctor();
					if (86087 - 321249 == -235162)
					{
						this.$self_$42002 = self_;
						if (145846 - 311572 != -165725)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x011B7830 File Offset: 0x011B5A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$ReturnToGuild$41999.$(this.$self_$42002);
		}

		// Token: 0x06009523 RID: 38179 RVA: 0x011B7840 File Offset: 0x011B5A40
		internal static bool GvLw0WVSqwLFvdBGYmxZ()
		{
			return true;
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x011B7844 File Offset: 0x011B5A44
		internal static bool E0DtMuVS7qaaggHXZpF2()
		{
			return false;
		}

		// Token: 0x04008B8B RID: 35723
		internal M911_LavuAttack2 $self_$42002;

		// Token: 0x0200190A RID: 6410
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009525 RID: 38181 RVA: 0x011B7848 File Offset: 0x011B5A48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack2 self_)
			{
				if (201758 - 343639 != -141881)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53250 - 505052 == -451802)
					{
						base..ctor();
						if (249454 - 291508 == -42054)
						{
							this.$self_$42001 = self_;
							if (137822 - 188199 != -50376)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009526 RID: 38182 RVA: 0x011B78E0 File Offset: 0x011B5AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133040 - 539102 != -406062)
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
						this.$self_$42001.LeaveGame();
						if (123549 - 8780 != 114769)
						{
							continue;
						}
						this.YieldDefault(1);
						if (232599 - 458893 != -226293)
						{
							goto Block_2;
						}
						continue;
					default:
						if (135003 - 138186 == -3182)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (26454 - 586742 == -560288)
					{
						Game.mStateTime = Time.time;
						if (255236 - 208970 != 46267)
						{
							Game.mNextGameCode = 31;
							if (117891 - 503456 != -385564)
							{
								this.$mGameGui$42000 = (GameGui)this.$self_$42001.GetComponent(typeof(GameGui));
								if (186814 - 128039 == 58775)
								{
									if (this.$mGameGui$42000)
									{
										if (186173 - 189519 != -3346)
										{
											continue;
										}
										this.$mGameGui$42000.close();
										if (21874 - 296754 == -274879)
										{
											continue;
										}
									}
									this.$self_$42001.SendMessage("fadeOut");
									if (59230 - 275238 == -216008)
									{
										goto IL_111;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_111:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06009527 RID: 38183 RVA: 0x011B7ABC File Offset: 0x011B5CBC
			internal static bool tfwBkfVSPJvIa4q2OoMx()
			{
				return true;
			}

			// Token: 0x06009528 RID: 38184 RVA: 0x011B7AC0 File Offset: 0x011B5CC0
			internal static bool BqKv6UVS0K80a5fjCfOU()
			{
				return false;
			}

			// Token: 0x04008B8C RID: 35724
			internal GameGui $mGameGui$42000;

			// Token: 0x04008B8D RID: 35725
			internal M911_LavuAttack2 $self_$42001;
		}
	}

	// Token: 0x0200190B RID: 6411
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42003 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009529 RID: 38185 RVA: 0x011B7AC4 File Offset: 0x011B5CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42003(M911_LavuAttack2 self_)
		{
			if (171524 - 265422 != -93897)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269555 - 313532 == -43977)
				{
					base..ctor();
					if (258997 - 37735 != 221263)
					{
						this.$self_$42007 = self_;
						if (220198 - 262638 == -42440)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600952A RID: 38186 RVA: 0x011B7B5C File Offset: 0x011B5D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack2.$ReturnToCamp$42003.$(this.$self_$42007);
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x011B7B6C File Offset: 0x011B5D6C
		internal static bool cfPescVSb0mPbyeVylhK()
		{
			return true;
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x011B7B70 File Offset: 0x011B5D70
		internal static bool IPBi4cVSuHF2XRGSwERa()
		{
			return false;
		}

		// Token: 0x04008B8E RID: 35726
		internal M911_LavuAttack2 $self_$42007;

		// Token: 0x0200190C RID: 6412
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600952D RID: 38189 RVA: 0x011B7B74 File Offset: 0x011B5D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack2 self_)
			{
				if (94923 - 595353 != -500430)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163011 - 508648 == -345637)
					{
						base..ctor();
						if (198865 - 562893 != -364027)
						{
							this.$self_$42006 = self_;
							if (42899 - 61854 != -18954)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600952E RID: 38190 RVA: 0x011B7C0C File Offset: 0x011B5E0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19229 - 401635 != -382405)
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
						this.$self_$42006.LeaveGame();
						if (236654 - 382097 != -145443)
						{
							continue;
						}
						this.YieldDefault(1);
						if (123540 - 109711 != 13830)
						{
							goto Block_21;
						}
						continue;
					default:
						if (66277 - 255356 != -189079)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (200425 - 542191 != -341765)
					{
						Game.mStateTime = Time.time;
						if (143462 - 554938 != -411475)
						{
							this.$$switch$7578$42004 = PlayerData.SaveGuild;
							if (90642 - 247478 == -156836)
							{
								if (this.$$switch$7578$42004 == 1)
								{
									if (122437 - 556795 != -434358)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (120540 - 509881 == -389340)
									{
										continue;
									}
								}
								else if (this.$$switch$7578$42004 == 2)
								{
									if (110114 - 507866 != -397752)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (191784 - 170306 == 21479)
									{
										continue;
									}
								}
								else if (this.$$switch$7578$42004 == 3)
								{
									if (255608 - 131456 == 124153)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (17033 - 75914 == -58880)
									{
										continue;
									}
								}
								else if (this.$$switch$7578$42004 == 4)
								{
									if (116255 - 84835 != 31420)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (183858 - 219387 == -35528)
									{
										continue;
									}
								}
								else if (this.$$switch$7578$42004 == 5)
								{
									if (126159 - 497922 != -371763)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (100990 - 8662 == 92329)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (6051 - 141756 == -135704)
									{
										continue;
									}
								}
								this.$mGameGui$42005 = (GameGui)this.$self_$42006.GetComponent(typeof(GameGui));
								if (45352 - 271199 == -225847)
								{
									if (this.$mGameGui$42005)
									{
										if (253328 - 238888 != 14440)
										{
											continue;
										}
										this.$mGameGui$42005.close();
										if (284623 - 172791 != 111832)
										{
											continue;
										}
									}
									this.$self_$42006.SendMessage("fadeOut");
									if (210914 - 164609 != 46306)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_21:
				IL_363:
				return false;
			}

			// Token: 0x0600952F RID: 38191 RVA: 0x011B7F90 File Offset: 0x011B6190
			internal static bool JSAu4vVSINFeNVcImW5H()
			{
				return true;
			}

			// Token: 0x06009530 RID: 38192 RVA: 0x011B7F94 File Offset: 0x011B6194
			internal static bool BlyLGlVSBIgFOtgJQhJx()
			{
				return false;
			}

			// Token: 0x04008B8F RID: 35727
			internal int $$switch$7578$42004;

			// Token: 0x04008B90 RID: 35728
			internal GameGui $mGameGui$42005;

			// Token: 0x04008B91 RID: 35729
			internal M911_LavuAttack2 $self_$42006;
		}
	}
}
