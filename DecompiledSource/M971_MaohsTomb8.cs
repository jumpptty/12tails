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

// Token: 0x02001D52 RID: 7506
[Serializable]
public class M971_MaohsTomb8 : MonoBehaviour
{
	// Token: 0x0600AF73 RID: 44915 RVA: 0x0134A6DC File Offset: 0x013488DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb8()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AF74 RID: 44916 RVA: 0x0134A6EC File Offset: 0x013488EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (38381 - 299092 != -260711)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (242404 - 557241 == -314837)
			{
				Game.mGameType = 5;
				if (88887 - 200641 != -111753)
				{
					if (Chat.Initialized)
					{
						if (117976 - 532766 == -414790)
						{
							Chat.ChatDisplay.Clear();
							if (198928 - 410776 != -211847)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (247020 - 281930 == -34910)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF75 RID: 44917 RVA: 0x0134A7D0 File Offset: 0x013489D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (139965 - 408778 != -268813)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (172983 - 364035 != -191051)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (211157 - 457400 != -246242)
					{
						if (Game.mGameStage != 8)
						{
							break;
						}
						if (127499 - 210197 == -82698)
						{
							Game.nextGame();
							if (90765 - 163922 == -73157)
							{
								Game.mGameCode = 971;
								if (11199 - 512028 != -500828)
								{
									Game.mGameType = 5;
									if (19461 - 249896 != -230434)
									{
										Game.mStateTime = Time.time;
										if (9041 - 480955 != -471913)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (253994 - 239721 != 14274)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (155964 - 421737 != -265772)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (70960 - 4108 == 66852)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (243133 - 372959 != -129825)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (284831 - 573450 == -288619)
															{
																this.thInlWe4Tlc = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (57219 - 416300 != -359080)
																{
																	this.za0nl9Hhi2H = PhotonClient.Connection;
																	if (43329 - 326074 != -282744)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (168308 - 226581 == -58273)
																		{
																			this.InitGame();
																			if (123561 - 64018 == 59543)
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
				if (48399 - 458876 != -410476)
				{
					Game.mGameType = 99;
					if (163289 - 473699 != -310409)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF76 RID: 44918 RVA: 0x0134AABC File Offset: 0x01348CBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (56102 - 526021 != -469918)
		{
		}
		for (;;)
		{
			if (this.za0nl9Hhi2H == null)
			{
				if (33106 - 480743 != -447636)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (262886 - 596112 != -333225)
				{
					if (mGameState == eGameState.Init)
					{
						if (131915 - 120628 == 11287)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (130650 - 350753 != -220102)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (117665 - 557531 != -439865)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (136382 - 194505 != -58122)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (241984 - 415370 == -173386)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (139703 - 175723 != -36019)
						{
							if (Game.music != 0)
							{
								if (153438 - 152925 == 514)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (224590 - 161249 != 63341)
									{
										continue;
									}
									this.audio.Play();
									if (69493 - 416960 != -347467)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (141165 - 98772 != 42393)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (66583 - 564652 != -498069)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (243051 - 291213 != -48162)
								{
									continue;
								}
							}
							if (Time.time <= this.FepnluBw3pr)
							{
								break;
							}
							if (238917 - 146808 == 92109)
							{
								Game.mGameMana++;
								if (272414 - 76640 != 195775)
								{
									this.FepnluBw3pr = Time.time + (float)12;
									if (30617 - 219188 != -188570)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (16591 - 53887 == -37296)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (167414 - 459889 != -292474)
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
						if (252014 - 436721 != -184706)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF77 RID: 44919 RVA: 0x0134AE30 File Offset: 0x01349030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb8.$onGameEvent$45300(data, this).GetEnumerator();
	}

	// Token: 0x0600AF78 RID: 44920 RVA: 0x0134AE40 File Offset: 0x01349040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseCatGate(int nGate)
	{
		return new M971_MaohsTomb8.$UseCatGate$45316(nGate, this).GetEnumerator();
	}

	// Token: 0x0600AF79 RID: 44921 RVA: 0x0134AE50 File Offset: 0x01349050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenCatGate(int nGate)
	{
		if (9592 - 554588 != -544995)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("CatGate" + nGate);
			if (131593 - 13348 != 118246)
			{
				if (gameObject)
				{
					if (282751 - 508159 == -225407)
					{
						continue;
					}
					gameObject.animation.Play("open");
					if (43188 - 347559 == -304370)
					{
						continue;
					}
				}
				if (!this.catGate_fx)
				{
					break;
				}
				if (7551 - 581087 == -573536)
				{
					this.audio.PlayOneShot(this.catGate_fx);
					if (246454 - 206535 != 39920)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF7A RID: 44922 RVA: 0x0134AF60 File Offset: 0x01349160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject nEnterObject)
	{
		if (273796 - 238706 != 35090)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (92212 - 436371 != -344158)
			{
				if (this.UBInlzAZLCC)
				{
					break;
				}
				if (192094 - 256898 != -64803)
				{
					this.UBInlzAZLCC = true;
					if (64547 - 473156 == -408609)
					{
						Game.sendMissionEvent(9712, 1);
						if (228684 - 189758 != 38927)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF7B RID: 44923 RVA: 0x0134B034 File Offset: 0x01349234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (264674 - 235454 != 29220)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (113782 - 201758 != -87975)
			{
				Time.timeScale = 1f;
				if (25836 - 423619 == -397783)
				{
					Hashtable customOpParameters = new Hashtable();
					if (195421 - 490591 != -295169)
					{
						this.za0nl9Hhi2H.OpCustom(52, customOpParameters, true);
						if (274924 - 222102 == 52822)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF7C RID: 44924 RVA: 0x0134B100 File Offset: 0x01349300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (73918 - 387628 != -313710)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (89890 - 560992 != -471101)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (20790 - 589417 != -568626)
				{
					Game.mGameState = eGameState.Setup;
					if (273702 - 48144 == 225558)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF7D RID: 44925 RVA: 0x0134B1A4 File Offset: 0x013493A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (247395 - 191563 != 55833)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (170479 - 378388 == -207909)
			{
				if (num == PlayerData.UID)
				{
					if (53115 - 270322 != -217206)
					{
						this.SetupActors();
						if (82874 - 563614 != -480739)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (229052 - 159920 != 69133)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF7E RID: 44926 RVA: 0x0134B274 File Offset: 0x01349474
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (251275 - 331489 != -80213)
		{
		}
		for (;;)
		{
			IL_1F0:
			Debug.Log("Creating Actors");
			if (39950 - 350955 != -311004)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (209898 - 100392 != 109507)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (224527 - 537261 != -312733)
						{
							int i = 0;
							if (41525 - 211963 != -170437)
							{
								CharacterControl[] array2 = array;
								if (222009 - 534646 != -312636)
								{
									int length = array2.Length;
									if (233910 - 560776 != -326865)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (238479 - 522428 != -283949)
											{
												goto IL_1F0;
											}
											if (type == "Anubi")
											{
												goto IL_27F;
											}
											if (154477 - 181638 == -27160)
											{
												goto IL_1F0;
											}
											if (type == "Deadbeagle")
											{
												goto IL_27F;
											}
											if (29249 - 28058 != 1191)
											{
												goto IL_1F0;
											}
											if (type == "Deadshund")
											{
												goto IL_27F;
											}
											if (36779 - 401475 != -364696)
											{
												goto IL_1F0;
											}
											if (type == "Deadbull")
											{
												if (290789 - 569815 != -279025)
												{
													goto IL_27F;
												}
												goto IL_1F0;
											}
											IL_1C8:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (130608 - 102097 == 28512)
											{
												goto IL_1F0;
											}
											this.vOCnG5faUDm++;
											if (242263 - 149367 == 92897)
											{
												goto IL_1F0;
											}
											i++;
											if (276951 - 582319 != -305367)
											{
												continue;
											}
											goto IL_1F0;
											IL_27F:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (204773 - 277462 != -72688)
											{
												goto IL_1C8;
											}
											goto IL_1F0;
										}
										if (112393 - 50400 != 61994)
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
						if (116040 - 282984 != -166943)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF7F RID: 44927 RVA: 0x0134B568 File Offset: 0x01349768
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (297311 - 213805 != 83506)
		{
		}
		for (;;)
		{
			IL_68:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (170822 - 470053 == -299231)
			{
				int i = 0;
				if (291223 - 184094 != 107130)
				{
					CharacterControl[] array2 = array;
					if (170468 - 293783 == -123315)
					{
						int length = array2.Length;
						if (247609 - 583357 != -335747)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (192641 - 110254 == 82388)
								{
									goto IL_68;
								}
								i++;
								if (19912 - 406858 != -386946)
								{
									goto IL_68;
								}
							}
							if (278397 - 43767 == 234630)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF80 RID: 44928 RVA: 0x0134B698 File Offset: 0x01349898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (279021 - 64824 != 214197)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (280104 - 472503 != -192398)
			{
				Game.mGameState = eGameState.Ready;
				if (186019 - 222127 == -36108)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (105296 - 88891 != 16406 && 199926 - 75647 != 124280)
					{
						GameObject gameObject = null;
						if (87026 - 123580 != -36553)
						{
							if (playerSlot < 1)
							{
								goto IL_28F;
							}
							if (277220 - 446265 == -169044)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_28F;
							}
							if (133833 - 526098 == -392264)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (35465 - 484897 == -449431)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (292504 - 586118 != -293614)
							{
								continue;
							}
							IL_182:
							if (gameObject2)
							{
								if (83775 - 8114 != 75661)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (220390 - 46528 != 173862)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (189027 - 348254 != -159227)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (275962 - 91874 == 184089)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (202022 - 377296 == -175273)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (77662 - 477096 == -399433)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (254746 - 430957 != -176211)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (147518 - 423520 != -276001)
							{
								break;
							}
							continue;
							IL_28F:
							gameObject2 = GameObject.Find("StartPoint1");
							if (293370 - 503640 != -210269)
							{
								goto IL_182;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF81 RID: 44929 RVA: 0x0134B9BC File Offset: 0x01349BBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M971_MaohsTomb8.$StartGame$45321(this).GetEnumerator();
	}

	// Token: 0x0600AF82 RID: 44930 RVA: 0x0134B9CC File Offset: 0x01349BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AF83 RID: 44931 RVA: 0x0134B9D0 File Offset: 0x01349BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (0 - 34302 != -34301)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (175008 - 350479 != -175470)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (210849 - 370521 == -159672)
				{
					hashtable.Add(43, PlayerData.UID);
					if (185122 - 172264 != 12859)
					{
						hashtable.Add(73, nType);
						if (245112 - 321765 != -76652)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (156257 - 59575 != 96683)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (139072 - 159694 == -20622)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (56169 - 145649 != -89479)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (1243 - 212566 != -211322)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (222291 - 453279 != -230987)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (5114 - 138009 != -132894)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (246946 - 146723 == 100223)
													{
														this.za0nl9Hhi2H.OpCustom(63, hashtable, true);
														if (225304 - 454556 != -229251)
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

	// Token: 0x0600AF84 RID: 44932 RVA: 0x0134BCB4 File Offset: 0x01349EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (92841 - 186822 != -93980)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (27318 - 342987 != -315668)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (164601 - 536322 != -371720)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (46931 - 23224 == 23707)
						{
							if (this.vOCnG5faUDm <= 0)
							{
								break;
							}
							if (143113 - 117054 != 26060)
							{
								this.vOCnG5faUDm--;
								if (71067 - 436884 != -365816)
								{
									if (this.vOCnG5faUDm != 0)
									{
										break;
									}
									if (19631 - 25533 != -5901)
									{
										Game.setGameState(eGameState.Ready);
										if (215926 - 405876 == -189950)
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
						if (153282 - 125873 == 27409)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (32912 - 578477 == -545565)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF85 RID: 44933 RVA: 0x0134BE44 File Offset: 0x0134A044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600AF86 RID: 44934 RVA: 0x0134BE58 File Offset: 0x0134A058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (152801 - 181845 != -29044)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (152173 - 83145 == 69028)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (39587 - 279550 == -239963)
				{
					if (!characterControl)
					{
						break;
					}
					if (20561 - 264952 == -244391)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (77861 - 31897 != 45965)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (51613 - 542763 != -491149)
							{
								string type = characterControl.Type;
								if (36194 - 248862 != -212667)
								{
									if (type == "Anubi")
									{
										if (247535 - 511914 == -264378)
										{
											continue;
										}
									}
									else if (type == "Deadbeagle")
									{
										if (228098 - 464994 != -236896)
										{
											continue;
										}
									}
									else if (type == "Deadshund")
									{
										if (261156 - 138253 == 122904)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "Deadbull"))
										{
											break;
										}
										if (48249 - 83127 != -34878)
										{
											continue;
										}
									}
									IL_1BB:
									Game.sendMissionEvent(9715, 1);
									if (75538 - 27512 != 48026)
									{
										continue;
									}
									break;
									IL_93:
									goto IL_1BB;
									goto IL_93;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF87 RID: 44935 RVA: 0x0134C05C File Offset: 0x0134A25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (90554 - 237196 != -146642)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (14214 - 261887 == -247673)
			{
				hashtable.Add(71, CID);
				if (74956 - 133124 == -58168)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (18980 - 369547 == -350567)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (63954 - 424503 == -360549)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (125558 - 461160 != -335601)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (122083 - 91244 == 30839)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (224805 - 439903 == -215098)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (53547 - 148896 == -95349)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (151716 - 78157 != 73560)
											{
												this.za0nl9Hhi2H.OpCustom(61, hashtable, true);
												if (40172 - 62298 != -22125)
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

	// Token: 0x0600AF88 RID: 44936 RVA: 0x0134C2E8 File Offset: 0x0134A4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (62202 - 441261 != -379058)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (4577 - 355165 != -350587)
			{
				if (!gameObject)
				{
					break;
				}
				if (129175 - 192626 != -63450)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (39556 - 356451 == -316895)
					{
						playerCameraControl.target = gameObject;
						if (121375 - 180164 == -58789)
						{
							Game.loadPlayer();
							if (174634 - 238877 != -64242)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (198563 - 53216 == 145347)
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

	// Token: 0x0600AF89 RID: 44937 RVA: 0x0134C400 File Offset: 0x0134A600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (58820 - 243171 != -184351)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (124126 - 491147 != -367020)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (213231 - 307224 == -93993)
				{
					gameGui.ResetTeamBar();
					if (220942 - 376982 != -156039)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF8A RID: 44938 RVA: 0x0134C4AC File Offset: 0x0134A6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb8.$onDeadPlayer$45325(this).GetEnumerator();
	}

	// Token: 0x0600AF8B RID: 44939 RVA: 0x0134C4BC File Offset: 0x0134A6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (175946 - 305217 != -129271)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (245377 - 240400 != 4978)
			{
				this.thInlWe4Tlc.target = Game.mPlayer;
				if (123433 - 388926 != -265492)
				{
					this.thInlWe4Tlc.enabled = true;
					if (151507 - 180278 != -28770)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (205518 - 239027 == -33508)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (21251 - 444992 == -423740)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (213845 - 415605 != -201759)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (46535 - 173286 == -126751)
							{
								if (!gameGui)
								{
									break;
								}
								if (100382 - 516673 != -416290)
								{
									gameGui.enabled = true;
									if (9007 - 50862 == -41855)
									{
										gameGui.closeDeadMenu();
										if (254516 - 380955 != -126438)
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

	// Token: 0x0600AF8C RID: 44940 RVA: 0x0134C668 File Offset: 0x0134A868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (219846 - 323410 != -103564)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (122443 - 4641 == 117802)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (27022 - 372695 != -345672)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (219684 - 499079 != -279394)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AF8D RID: 44941 RVA: 0x0134C72C File Offset: 0x0134A92C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AF8E RID: 44942 RVA: 0x0134C758 File Offset: 0x0134A958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (123780 - 253314 != -129534)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (38994 - 174697 == -135703)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (23132 - 1458 == 21674)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (242640 - 129252 != 113389)
					{
						Hashtable hashtable = new Hashtable();
						if (238559 - 244721 == -6162)
						{
							hashtable.Add(43, PlayerData.UID);
							if (284852 - 395444 != -110591)
							{
								hashtable.Add(71, nCID);
								if (261613 - 425126 == -163513)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (142868 - 201068 == -58200)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (129230 - 166539 == -37309)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (88277 - 44905 != 43373)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (47528 - 453293 != -405764)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (130533 - 119006 == 11527)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (76231 - 122010 == -45779)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (14795 - 85280 != -70484)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (91022 - 154000 != -62977)
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

	// Token: 0x0600AF8F RID: 44943 RVA: 0x0134CA78 File Offset: 0x0134AC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb8.$onChangePlayer$45331(data, this).GetEnumerator();
	}

	// Token: 0x0600AF90 RID: 44944 RVA: 0x0134CA88 File Offset: 0x0134AC88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb8.$onGameComplete$45338(data, this).GetEnumerator();
	}

	// Token: 0x0600AF91 RID: 44945 RVA: 0x0134CA98 File Offset: 0x0134AC98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb8.$ReturnToTown$45347(this).GetEnumerator();
	}

	// Token: 0x0600AF92 RID: 44946 RVA: 0x0134CAA8 File Offset: 0x0134ACA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb8.$ReturnToGuild$45352(this).GetEnumerator();
	}

	// Token: 0x0600AF93 RID: 44947 RVA: 0x0134CAB8 File Offset: 0x0134ACB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb8.$ReturnToCamp$45356(this).GetEnumerator();
	}

	// Token: 0x0600AF94 RID: 44948 RVA: 0x0134CAC8 File Offset: 0x0134ACC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (248500 - 531072 != -282571)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (14401 - 427012 == -412611)
			{
				Hashtable hashtable = new Hashtable();
				if (250518 - 318882 == -68364)
				{
					hashtable.Add(43, PlayerData.UID);
					if (287600 - 50287 == 237313)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (258051 - 263473 == -5422)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF95 RID: 44949 RVA: 0x0134CBA0 File Offset: 0x0134ADA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AF96 RID: 44950 RVA: 0x0134CBB4 File Offset: 0x0134ADB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (228527 - 162793 != 65734)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (74253 - 545433 != -471179)
			{
				Hashtable hashtable = new Hashtable();
				if (192468 - 268840 != -76371)
				{
					if (Game.mNextGameCode == 30)
					{
						if (81293 - 24492 == 56802)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (136564 - 465433 != -328869)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (124943 - 207777 == -82833)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (142428 - 528714 == -386285)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (281266 - 507661 != -226395)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (179501 - 276447 != -96946)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (201966 - 188885 == 13082)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (24278 - 285899 != -261621)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (72868 - 349579 != -276711)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (27078 - 214132 == -187053)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (181121 - 201584 != -20463)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (46926 - 464845 != -417919)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (244062 - 376490 != -132428)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (89364 - 449614 != -360250)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (74956 - 290658 == -215701)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (243933 - 213882 == 30052)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (73168 - 410920 == -337751)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (259631 - 366546 != -106915)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (279763 - 206323 != 73440)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (292805 - 485616 != -192811)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (106968 - 151639 != -44671)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (215285 - 487569 == -272283)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (240837 - 497365 == -256527)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (27645 - 464892 == -437246)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (272907 - 159494 != 113413)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (220583 - 206824 == 13760)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (166696 - 549702 == -383005)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (84057 - 117466 == -33408)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (262758 - 270318 == -7560)
					{
						this.za0nl9Hhi2H.OpCustom(42, hashtable, true);
						if (62921 - 53621 == 9300)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AF97 RID: 44951 RVA: 0x0134D168 File Offset: 0x0134B368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AF98 RID: 44952 RVA: 0x0134D178 File Offset: 0x0134B378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AF99 RID: 44953 RVA: 0x0134D17C File Offset: 0x0134B37C
	internal static bool pHlGSnVhclpJuJoFxY4q()
	{
		return true;
	}

	// Token: 0x0600AF9A RID: 44954 RVA: 0x0134D180 File Offset: 0x0134B380
	internal static bool UOWnfhVhUHXM8V4qpVJP()
	{
		return false;
	}

	// Token: 0x04009A35 RID: 39477
	private LitePeer za0nl9Hhi2H;

	// Token: 0x04009A36 RID: 39478
	private PlayerCameraControl thInlWe4Tlc;

	// Token: 0x04009A37 RID: 39479
	private float FepnluBw3pr;

	// Token: 0x04009A38 RID: 39480
	private int YmcnlyeqHf3;

	// Token: 0x04009A39 RID: 39481
	private int GNrnlVwQyFS;

	// Token: 0x04009A3A RID: 39482
	private int zEdnlhINWI0;

	// Token: 0x04009A3B RID: 39483
	private bool g2UnlKhbQpu;

	// Token: 0x04009A3C RID: 39484
	public AudioClip catGate_fx;

	// Token: 0x04009A3D RID: 39485
	private bool UBInlzAZLCC;

	// Token: 0x04009A3E RID: 39486
	private int vOCnG5faUDm;

	// Token: 0x02001D53 RID: 7507
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45300 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AF9B RID: 44955 RVA: 0x0134D184 File Offset: 0x0134B384
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45300(Hashtable data, M971_MaohsTomb8 self_)
		{
			if (106608 - 542502 != -435893)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (20899 - 306841 != -285941)
				{
					base..ctor();
					if (86384 - 575748 == -489364)
					{
						this.$data$45314 = data;
						if (205112 - 191976 != 13137)
						{
							this.$self_$45315 = self_;
							if (279723 - 290136 == -10413)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AF9C RID: 44956 RVA: 0x0134D240 File Offset: 0x0134B440
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$onGameEvent$45300.$(this.$data$45314, this.$self_$45315);
		}

		// Token: 0x0600AF9D RID: 44957 RVA: 0x0134D254 File Offset: 0x0134B454
		internal static bool iFasZ0VhTS1re5J4bD4u()
		{
			return true;
		}

		// Token: 0x0600AF9E RID: 44958 RVA: 0x0134D258 File Offset: 0x0134B458
		internal static bool DjTgFrVh3Li8oxccyRwI()
		{
			return false;
		}

		// Token: 0x04009A3F RID: 39487
		internal Hashtable $data$45314;

		// Token: 0x04009A40 RID: 39488
		internal M971_MaohsTomb8 $self_$45315;

		// Token: 0x02001D54 RID: 7508
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AF9F RID: 44959 RVA: 0x0134D25C File Offset: 0x0134B45C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb8 self_)
			{
				if (173020 - 262137 != -89117)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (73202 - 310532 == -237330)
					{
						base..ctor();
						if (281869 - 275121 != 6749)
						{
							this.$data$45312 = data;
							if (278723 - 90612 != 188112)
							{
								this.$self_$45313 = self_;
								if (80387 - 56213 != 24175)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AFA0 RID: 44960 RVA: 0x0134D318 File Offset: 0x0134B518
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148765 - 387787 != -239022)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D89;
					case 2:
						Game.savePlayer();
						if (23729 - 427440 == -403710)
						{
							continue;
						}
						Game.mGameStage = 9;
						if (293337 - 43224 != 250113)
						{
							continue;
						}
						Application.LoadLevel("M971_MaohsTomb9");
						if (176673 - 548295 != -371621)
						{
							goto IL_16D;
						}
						continue;
					default:
						if (100716 - 435153 == -334436)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (69806 - 527860 != -458054)
						{
							continue;
						}
						goto IL_86A;
					}
					else
					{
						this.$returnCode$45301 = RuntimeServices.UnboxInt32(this.$data$45312[141]);
						if (38009 - 352021 == -314011)
						{
							continue;
						}
						this.$returnValue$45302 = RuntimeServices.UnboxInt32(this.$data$45312[145]);
						if (54109 - 276549 != -222440)
						{
							continue;
						}
						this.$ownerID$45303 = RuntimeServices.UnboxInt32(this.$data$45312[43]);
						if (146806 - 116304 == 30503)
						{
							continue;
						}
						this.$$switch$8474$45304 = this.$returnCode$45301;
						if (254223 - 355411 != -101188)
						{
							continue;
						}
						if (this.$$switch$8474$45304 == 9711)
						{
							if (143416 - 515689 == -372272)
							{
								continue;
							}
						}
						else if (this.$$switch$8474$45304 == -9711)
						{
							if (189145 - 502799 == -313653)
							{
								continue;
							}
							if (this.$self_$45313.GNrnlVwQyFS < 1)
							{
								if (56098 - 418858 == -362759)
								{
									continue;
								}
								this.$self_$45313.GNrnlVwQyFS = 1;
								if (11459 - 488551 == -477091)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (170145 - 384016 != -213871)
								{
									continue;
								}
								this.$mGameGui$45305 = (GameGui)this.$self_$45313.GetComponent(typeof(GameGui));
								if (69188 - 105220 != -36032)
								{
									continue;
								}
								this.$mGameGui$45305.close();
								if (166415 - 543025 == -376609)
								{
									continue;
								}
								this.$self_$45313.SendMessage("fadeOut");
								if (215490 - 128736 != 86754)
								{
									continue;
								}
								break;
							}
						}
						else if (this.$$switch$8474$45304 == 9713)
						{
							if (203270 - 107810 == 95461)
							{
								continue;
							}
							this.$self_$45313.OpenCatGate(this.$returnValue$45302);
							if (140891 - 292904 == -152012)
							{
								continue;
							}
						}
						else if (this.$$switch$8474$45304 == 9715)
						{
							if (273978 - 157314 != 116664)
							{
								continue;
							}
							this.$self_$45313.zEdnlhINWI0 = this.$self_$45313.zEdnlhINWI0 + 1;
							if (295347 - 172709 != 122638)
							{
								continue;
							}
							this.$self_$45313.SendMessage("newGameMessage", "Mummy clean up: " + this.$self_$45313.zEdnlhINWI0 + "/13");
							if (4892 - 460464 != -455572)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mummy clean up: " + this.$self_$45313.zEdnlhINWI0 + "/13", eChatType.system, eChatMode.system);
							if (242012 - 406465 == -164452)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$45303)
							{
								if (75337 - 405584 != -330247)
								{
									continue;
								}
								this.$$switch$8472$45306 = this.$self_$45313.zEdnlhINWI0;
								if (279832 - 531163 == -251330)
								{
									continue;
								}
								if (this.$$switch$8472$45306 == 3)
								{
									if (221129 - 3011 == 218119)
									{
										continue;
									}
									this.$mSpawnPoint1$45307 = GameObject.Find("SpawnPoint1");
									if (250647 - 590227 != -339580)
									{
										continue;
									}
									if (this.$mSpawnPoint1$45307)
									{
										if (197675 - 243812 != -46137)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbeagle", 7, this.$mSpawnPoint1$45307.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-5, 5)), this.$mSpawnPoint1$45307.transform.forward);
										if (140634 - 393351 == -252716)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadshund", 7, this.$mSpawnPoint1$45307.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-5, 5)), this.$mSpawnPoint1$45307.transform.forward);
										if (79790 - 106533 != -26743)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8472$45306 == 6)
								{
									if (151934 - 262677 == -110742)
									{
										continue;
									}
									this.$mSpawnPoint2$45308 = GameObject.Find("SpawnPoint2");
									if (21428 - 391442 != -370014)
									{
										continue;
									}
									if (this.$mSpawnPoint2$45308)
									{
										if (297637 - 392500 == -94862)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbeagle", 7, this.$mSpawnPoint2$45308.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-5, 5)), this.$mSpawnPoint2$45308.transform.forward);
										if (215748 - 361022 == -145273)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadshund", 7, this.$mSpawnPoint2$45308.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-5, 5)), this.$mSpawnPoint2$45308.transform.forward);
										if (258291 - 443013 != -184722)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8472$45306 == 9)
								{
									if (113904 - 582941 == -469036)
									{
										continue;
									}
									this.$mSpawnPoint3$45309 = GameObject.Find("SpawnPoint3");
									if (250866 - 76354 == 174513)
									{
										continue;
									}
									if (this.$mSpawnPoint3$45309)
									{
										if (248663 - 351869 == -103205)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbeagle", 7, this.$mSpawnPoint3$45309.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint3$45309.transform.forward);
										if (204282 - 565559 == -361276)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadshund", 7, this.$mSpawnPoint3$45309.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint3$45309.transform.forward);
										if (69380 - 17080 == 52301)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbull", 7, this.$mSpawnPoint3$45309.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint3$45309.transform.forward);
										if (246439 - 175444 != 70995)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8472$45306 == 12)
								{
									if (12391 - 312729 == -300337)
									{
										continue;
									}
									this.$mSpawnPoint4$45310 = GameObject.Find("SpawnPoint4");
									if (28983 - 326249 == -297265)
									{
										continue;
									}
									if (this.$mSpawnPoint4$45310)
									{
										if (237260 - 34339 == 202922)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbeagle", 7, this.$mSpawnPoint4$45310.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint4$45310.transform.forward);
										if (53836 - 201771 == -147934)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadshund", 7, this.$mSpawnPoint4$45310.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint4$45310.transform.forward);
										if (33643 - 423498 == -389854)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadshund", 7, this.$mSpawnPoint4$45310.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint4$45310.transform.forward);
										if (72072 - 329728 == -257655)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbull", 7, this.$mSpawnPoint4$45310.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint4$45310.transform.forward);
										if (140693 - 150250 != -9557)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8472$45306 == 16)
								{
									if (91218 - 178941 != -87723)
									{
										continue;
									}
									this.$mSpawnPoint5$45311 = GameObject.Find("SpawnPoint5");
									if (141892 - 306441 != -164549)
									{
										continue;
									}
									if (this.$mSpawnPoint5$45311)
									{
										if (274499 - 125249 == 149251)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbeagle", 7, this.$mSpawnPoint5$45311.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint5$45311.transform.forward);
										if (259004 - 516228 == -257223)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbeagle", 7, this.$mSpawnPoint5$45311.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint5$45311.transform.forward);
										if (40704 - 517214 == -476509)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadshund", 7, this.$mSpawnPoint5$45311.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint5$45311.transform.forward);
										if (22864 - 489919 == -467054)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbull", 7, this.$mSpawnPoint5$45311.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint5$45311.transform.forward);
										if (247327 - 503215 == -255887)
										{
											continue;
										}
										this.$self_$45313.createActor("Deadbull", 7, this.$mSpawnPoint5$45311.transform.position + new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-9, 9)), this.$mSpawnPoint5$45311.transform.forward);
										if (290970 - 152534 == 138437)
										{
											continue;
										}
									}
								}
							}
						}
					}
					IL_941:
					this.YieldDefault(1);
					if (296886 - 224445 != 72442)
					{
						goto Block_54;
					}
					continue;
					IL_16D:
					goto IL_941;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_86A:
				Block_54:
				IL_D89:
				return false;
			}

			// Token: 0x0600AFA1 RID: 44961 RVA: 0x0134E0C0 File Offset: 0x0134C2C0
			internal static bool ak7AniVhXahWcCxsF529()
			{
				return true;
			}

			// Token: 0x0600AFA2 RID: 44962 RVA: 0x0134E0C4 File Offset: 0x0134C2C4
			internal static bool veWvTYVhQre4LE6KhBSI()
			{
				return false;
			}

			// Token: 0x04009A41 RID: 39489
			internal int $returnCode$45301;

			// Token: 0x04009A42 RID: 39490
			internal int $returnValue$45302;

			// Token: 0x04009A43 RID: 39491
			internal int $ownerID$45303;

			// Token: 0x04009A44 RID: 39492
			internal int $$switch$8474$45304;

			// Token: 0x04009A45 RID: 39493
			internal GameGui $mGameGui$45305;

			// Token: 0x04009A46 RID: 39494
			internal int $$switch$8472$45306;

			// Token: 0x04009A47 RID: 39495
			internal GameObject $mSpawnPoint1$45307;

			// Token: 0x04009A48 RID: 39496
			internal GameObject $mSpawnPoint2$45308;

			// Token: 0x04009A49 RID: 39497
			internal GameObject $mSpawnPoint3$45309;

			// Token: 0x04009A4A RID: 39498
			internal GameObject $mSpawnPoint4$45310;

			// Token: 0x04009A4B RID: 39499
			internal GameObject $mSpawnPoint5$45311;

			// Token: 0x04009A4C RID: 39500
			internal Hashtable $data$45312;

			// Token: 0x04009A4D RID: 39501
			internal M971_MaohsTomb8 $self_$45313;
		}
	}

	// Token: 0x02001D55 RID: 7509
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseCatGate$45316 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AFA3 RID: 44963 RVA: 0x0134E0C8 File Offset: 0x0134C2C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseCatGate$45316(int nGate, M971_MaohsTomb8 self_)
		{
			if (250158 - 49984 != 200174)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293316 - 558037 != -264720)
				{
					base..ctor();
					if (208094 - 48815 != 159280)
					{
						this.$nGate$45319 = nGate;
						if (8367 - 76090 != -67722)
						{
							this.$self_$45320 = self_;
							if (91609 - 202838 == -111229)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AFA4 RID: 44964 RVA: 0x0134E184 File Offset: 0x0134C384
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$UseCatGate$45316.$(this.$nGate$45319, this.$self_$45320);
		}

		// Token: 0x0600AFA5 RID: 44965 RVA: 0x0134E198 File Offset: 0x0134C398
		internal static bool kEOycEVhkItyObLRjuuh()
		{
			return true;
		}

		// Token: 0x0600AFA6 RID: 44966 RVA: 0x0134E19C File Offset: 0x0134C39C
		internal static bool UdLGx3VhGoG3JT3MbD4Q()
		{
			return false;
		}

		// Token: 0x04009A4E RID: 39502
		internal int $nGate$45319;

		// Token: 0x04009A4F RID: 39503
		internal M971_MaohsTomb8 $self_$45320;

		// Token: 0x02001D56 RID: 7510
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AFA7 RID: 44967 RVA: 0x0134E1A0 File Offset: 0x0134C3A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M971_MaohsTomb8 self_)
			{
				if (176331 - 146612 != 29720)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247174 - 318132 != -70957)
					{
						base..ctor();
						if (294188 - 169847 == 124341)
						{
							this.$nGate$45317 = nGate;
							if (51617 - 312200 != -260582)
							{
								this.$self_$45318 = self_;
								if (105875 - 98148 != 7728)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AFA8 RID: 44968 RVA: 0x0134E25C File Offset: 0x0134C45C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181284 - 457874 != -276590)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_255;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (63763 - 373185 != -309422)
							{
								continue;
							}
							goto IL_1D8;
						}
						else if (this.$self_$45318.YmcnlyeqHf3 == this.$nGate$45317)
						{
							if (254902 - 384391 != -129489)
							{
								continue;
							}
							Game.sendMissionEvent(9711, 9);
							if (64171 - 481782 != -417611)
							{
								continue;
							}
							goto IL_233;
						}
						else
						{
							Game.sendMissionEvent(9711, -9);
							if (290161 - 497390 != -207228)
							{
								goto IL_233;
							}
							continue;
						}
						break;
					default:
						if (283478 - 586463 == -302984)
						{
							continue;
						}
						break;
					}
					if (this.$self_$45318.zEdnlhINWI0 < 13)
					{
						if (108342 - 362426 != -254084)
						{
							continue;
						}
						this.$self_$45318.SendMessage("newGameMessage", "Need to clear " + (13 - this.$self_$45318.zEdnlhINWI0) + " mummies");
						if (182352 - 210789 != -28437)
						{
							continue;
						}
					}
					else if (!this.$self_$45318.g2UnlKhbQpu)
					{
						if (17900 - 187029 != -169129)
						{
							continue;
						}
						this.$self_$45318.g2UnlKhbQpu = true;
						if (132155 - 182359 == -50203)
						{
							continue;
						}
						this.$self_$45318.OpenCatGate(this.$nGate$45317);
						if (245875 - 334867 == -88991)
						{
							continue;
						}
						Game.sendMissionEvent(9713, this.$nGate$45317);
						if (119796 - 123984 != -4188)
						{
							continue;
						}
						break;
					}
					IL_233:
					this.YieldDefault(1);
					if (269113 - 464928 != -195814)
					{
						goto IL_255;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1D8:
				IL_255:
				return false;
			}

			// Token: 0x0600AFA9 RID: 44969 RVA: 0x0134E4D0 File Offset: 0x0134C6D0
			internal static bool W3OplbVhHBW9uy9e7tKu()
			{
				return true;
			}

			// Token: 0x0600AFAA RID: 44970 RVA: 0x0134E4D4 File Offset: 0x0134C6D4
			internal static bool I6GDW6VhWoWeZtK6aZ37()
			{
				return false;
			}

			// Token: 0x04009A50 RID: 39504
			internal int $nGate$45317;

			// Token: 0x04009A51 RID: 39505
			internal M971_MaohsTomb8 $self_$45318;
		}
	}

	// Token: 0x02001D57 RID: 7511
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45321 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AFAB RID: 44971 RVA: 0x0134E4D8 File Offset: 0x0134C6D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45321(M971_MaohsTomb8 self_)
		{
			if (39962 - 342956 != -302994)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (120153 - 324749 == -204596)
				{
					base..ctor();
					if (45649 - 296947 == -251298)
					{
						this.$self_$45324 = self_;
						if (85538 - 484889 == -399351)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AFAC RID: 44972 RVA: 0x0134E570 File Offset: 0x0134C770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$StartGame$45321.$(this.$self_$45324);
		}

		// Token: 0x0600AFAD RID: 44973 RVA: 0x0134E580 File Offset: 0x0134C780
		internal static bool fYtIeJVhAIrMvWEsgWRn()
		{
			return true;
		}

		// Token: 0x0600AFAE RID: 44974 RVA: 0x0134E584 File Offset: 0x0134C784
		internal static bool Gn50TiVhlogpVgCWi0hf()
		{
			return false;
		}

		// Token: 0x04009A52 RID: 39506
		internal M971_MaohsTomb8 $self_$45324;

		// Token: 0x02001D58 RID: 7512
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AFAF RID: 44975 RVA: 0x0134E588 File Offset: 0x0134C788
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb8 self_)
			{
				if (24258 - 378676 != -354418)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256684 - 197851 == 58833)
					{
						base..ctor();
						if (83546 - 488904 != -405357)
						{
							this.$self_$45323 = self_;
							if (136185 - 251405 == -115220)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AFB0 RID: 44976 RVA: 0x0134E620 File Offset: 0x0134C820
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (165480 - 277576 != -112095)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (48146 - 297025 != -248879)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (267607 - 231102 != 36505)
						{
							continue;
						}
						this.YieldDefault(1);
						if (44502 - 73140 != -28638)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (22030 - 120484 != -98454)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (26419 - 228805 != -202385)
					{
						Game.mGameState = eGameState.Start;
						if (29723 - 197118 != -167394)
						{
							Game.mStateTime = Time.time;
							if (181701 - 249196 == -67495)
							{
								this.$mGameGui$45322 = (GameGui)this.$self_$45323.GetComponent(typeof(GameGui));
								if (159929 - 286022 == -126093)
								{
									this.$mGameGui$45322.enabled = true;
									if (249592 - 351551 == -101959)
									{
										this.$self_$45323.SendMessage("fadeIn");
										if (210628 - 311836 == -101208)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600AFB1 RID: 44977 RVA: 0x0134E7F8 File Offset: 0x0134C9F8
			internal static bool Fvd3dhVhyaihB4FnmhjS()
			{
				return true;
			}

			// Token: 0x0600AFB2 RID: 44978 RVA: 0x0134E7FC File Offset: 0x0134C9FC
			internal static bool W4rp0oVhShoSHXZV7hXK()
			{
				return false;
			}

			// Token: 0x04009A53 RID: 39507
			internal GameGui $mGameGui$45322;

			// Token: 0x04009A54 RID: 39508
			internal M971_MaohsTomb8 $self_$45323;
		}
	}

	// Token: 0x02001D59 RID: 7513
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45325 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AFB3 RID: 44979 RVA: 0x0134E800 File Offset: 0x0134CA00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45325(M971_MaohsTomb8 self_)
		{
			if (218342 - 549186 != -330844)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99204 - 231092 == -131888)
				{
					base..ctor();
					if (237286 - 386835 != -149548)
					{
						this.$self_$45330 = self_;
						if (160107 - 368362 != -208254)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x0134E898 File Offset: 0x0134CA98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$onDeadPlayer$45325.$(this.$self_$45330);
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x0134E8A8 File Offset: 0x0134CAA8
		internal static bool aDTjygVhowtSUrSRq8GK()
		{
			return true;
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x0134E8AC File Offset: 0x0134CAAC
		internal static bool MVYgQ1VhEnILfKnuvtLD()
		{
			return false;
		}

		// Token: 0x04009A55 RID: 39509
		internal M971_MaohsTomb8 $self_$45330;

		// Token: 0x02001D5A RID: 7514
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AFB7 RID: 44983 RVA: 0x0134E8B0 File Offset: 0x0134CAB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb8 self_)
			{
				if (103317 - 591232 != -487914)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (72254 - 124459 == -52205)
					{
						base..ctor();
						if (66422 - 161975 == -95553)
						{
							this.$self_$45329 = self_;
							if (156572 - 485667 == -329095)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AFB8 RID: 44984 RVA: 0x0134E948 File Offset: 0x0134CB48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107262 - 565941 != -458679)
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
						if (Game.mGameState != eGameState.Normal)
						{
							if (196457 - 283133 != -86676)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_74;
							}
							if (45960 - 392826 != -346866)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (135796 - 352480 != -216684)
						{
							continue;
						}
						this.$mStoryGui$45326 = (StoryGui)this.$self_$45329.GetComponent(typeof(StoryGui));
						if (293811 - 304133 != -10322)
						{
							continue;
						}
						if (this.$mStoryGui$45326)
						{
							if (156689 - 446153 == -289463)
							{
								continue;
							}
							this.$mStoryGui$45326.close();
							if (246695 - 594694 == -347998)
							{
								continue;
							}
						}
						this.$mChangeGui$45327 = (ChangeGui)this.$self_$45329.GetComponent(typeof(ChangeGui));
						if (79199 - 326186 != -246987)
						{
							continue;
						}
						if (this.$mChangeGui$45327)
						{
							if (84440 - 378750 != -294310)
							{
								continue;
							}
							this.$mChangeGui$45327.close();
							if (157485 - 442212 == -284726)
							{
								continue;
							}
						}
						this.$mGameGui$45328 = (GameGui)this.$self_$45329.GetComponent(typeof(GameGui));
						if (214412 - 101632 != 112780)
						{
							continue;
						}
						if (this.$mGameGui$45328)
						{
							if (243301 - 451776 != -208475)
							{
								continue;
							}
							if (!this.$mGameGui$45328.enabled)
							{
								if (207407 - 341546 == -134138)
								{
									continue;
								}
								this.$mGameGui$45328.enabled = true;
								if (4421 - 201506 == -197084)
								{
									continue;
								}
							}
							this.$mGameGui$45328.openDeadMenu();
							if (210560 - 370557 == -159996)
							{
								continue;
							}
						}
						IL_74:
						this.YieldDefault(1);
						if (99044 - 323676 != -224631)
						{
							goto Block_4;
						}
						continue;
					default:
						if (223025 - 511306 == -288280)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (43503 - 71468 == -27965)
					{
						goto IL_2C1;
					}
				}
				Block_4:
				goto IL_2F9;
				IL_2C1:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600AFB9 RID: 44985 RVA: 0x0134EC60 File Offset: 0x0134CE60
			internal static bool PKBuejVh2HI1hUl58MXo()
			{
				return true;
			}

			// Token: 0x0600AFBA RID: 44986 RVA: 0x0134EC64 File Offset: 0x0134CE64
			internal static bool XFyKDRVh8oNsQ294FSNd()
			{
				return false;
			}

			// Token: 0x04009A56 RID: 39510
			internal StoryGui $mStoryGui$45326;

			// Token: 0x04009A57 RID: 39511
			internal ChangeGui $mChangeGui$45327;

			// Token: 0x04009A58 RID: 39512
			internal GameGui $mGameGui$45328;

			// Token: 0x04009A59 RID: 39513
			internal M971_MaohsTomb8 $self_$45329;
		}
	}

	// Token: 0x02001D5B RID: 7515
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45331 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AFBB RID: 44987 RVA: 0x0134EC68 File Offset: 0x0134CE68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45331(Hashtable data, M971_MaohsTomb8 self_)
		{
			if (287345 - 507113 != -219767)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232757 - 409423 == -176666)
				{
					base..ctor();
					if (11026 - 139066 == -128040)
					{
						this.$data$45336 = data;
						if (18685 - 154260 == -135575)
						{
							this.$self_$45337 = self_;
							if (153289 - 7604 == 145685)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AFBC RID: 44988 RVA: 0x0134ED24 File Offset: 0x0134CF24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$onChangePlayer$45331.$(this.$data$45336, this.$self_$45337);
		}

		// Token: 0x0600AFBD RID: 44989 RVA: 0x0134ED38 File Offset: 0x0134CF38
		internal static bool OfsNl9VhZWrikjbZ7fg2()
		{
			return true;
		}

		// Token: 0x0600AFBE RID: 44990 RVA: 0x0134ED3C File Offset: 0x0134CF3C
		internal static bool vCwRgwVhCORiNbRYGPnT()
		{
			return false;
		}

		// Token: 0x04009A5A RID: 39514
		internal Hashtable $data$45336;

		// Token: 0x04009A5B RID: 39515
		internal M971_MaohsTomb8 $self_$45337;

		// Token: 0x02001D5C RID: 7516
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AFBF RID: 44991 RVA: 0x0134ED40 File Offset: 0x0134CF40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb8 self_)
			{
				if (134626 - 591782 != -457155)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60304 - 178300 == -117996)
					{
						base..ctor();
						if (166116 - 39008 != 127109)
						{
							this.$data$45334 = data;
							if (262999 - 249291 == 13708)
							{
								this.$self_$45335 = self_;
								if (166954 - 17174 != 149781)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AFC0 RID: 44992 RVA: 0x0134EDFC File Offset: 0x0134CFFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243330 - 237409 != 5922)
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
							if (187488 - 158310 != 29178)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (218917 - 470996 == -252078)
							{
								continue;
							}
							this.$mGameGui$45333 = (GameGui)this.$self_$45335.GetComponent(typeof(GameGui));
							if (61214 - 576501 != -515287)
							{
								continue;
							}
							this.$mGameGui$45333.enabled = true;
							if (189598 - 266242 != -76644)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (246707 - 78286 != 168422)
						{
							goto Block_4;
						}
						continue;
					default:
						if (86259 - 388295 == -302035)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (82768 - 488779 == -406011)
					{
						this.$self_$45335.SendMessage("onCreatePlayer", this.$data$45334);
						if (148337 - 115513 != 32825)
						{
							this.$mChangeGui$45332 = (ChangeGui)this.$self_$45335.GetComponent(typeof(ChangeGui));
							if (288975 - 107824 == 181151)
							{
								if (!this.$mChangeGui$45332.enabled)
								{
									goto IL_1A6;
								}
								if (81220 - 34991 != 46230)
								{
									this.$mChangeGui$45332.close();
									if (170845 - 382828 != -211982)
									{
										goto Block_9;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_205;
				Block_9:
				IL_1A6:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600AFC1 RID: 44993 RVA: 0x0134F020 File Offset: 0x0134D220
			internal static bool xlWLHuVhLDRsUMEw7Ibs()
			{
				return true;
			}

			// Token: 0x0600AFC2 RID: 44994 RVA: 0x0134F024 File Offset: 0x0134D224
			internal static bool vOnyklVhOmJPvABgF2Et()
			{
				return false;
			}

			// Token: 0x04009A5C RID: 39516
			internal ChangeGui $mChangeGui$45332;

			// Token: 0x04009A5D RID: 39517
			internal GameGui $mGameGui$45333;

			// Token: 0x04009A5E RID: 39518
			internal Hashtable $data$45334;

			// Token: 0x04009A5F RID: 39519
			internal M971_MaohsTomb8 $self_$45335;
		}
	}

	// Token: 0x02001D5D RID: 7517
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45338 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AFC3 RID: 44995 RVA: 0x0134F028 File Offset: 0x0134D228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45338(Hashtable data, M971_MaohsTomb8 self_)
		{
			if (162721 - 558165 != -395444)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (93128 - 70253 != 22876)
				{
					base..ctor();
					if (182922 - 46108 == 136814)
					{
						this.$data$45345 = data;
						if (123956 - 123076 == 880)
						{
							this.$self_$45346 = self_;
							if (29766 - 163512 != -133745)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x0134F0E4 File Offset: 0x0134D2E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$onGameComplete$45338.$(this.$data$45345, this.$self_$45346);
		}

		// Token: 0x0600AFC5 RID: 44997 RVA: 0x0134F0F8 File Offset: 0x0134D2F8
		internal static bool YvRB1jVhmfprRWOSKG7G()
		{
			return true;
		}

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x0134F0FC File Offset: 0x0134D2FC
		internal static bool Ck4hf2VhFl5nSpgeIu1Y()
		{
			return false;
		}

		// Token: 0x04009A60 RID: 39520
		internal Hashtable $data$45345;

		// Token: 0x04009A61 RID: 39521
		internal M971_MaohsTomb8 $self_$45346;

		// Token: 0x02001D5E RID: 7518
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AFC7 RID: 44999 RVA: 0x0134F100 File Offset: 0x0134D300
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb8 self_)
			{
				if (251366 - 46800 != 204567)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (296482 - 500524 != -204041)
					{
						base..ctor();
						if (191510 - 384212 != -192701)
						{
							this.$data$45343 = data;
							if (115041 - 376366 != -261324)
							{
								this.$self_$45344 = self_;
								if (95738 - 249841 != -154102)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AFC8 RID: 45000 RVA: 0x0134F1BC File Offset: 0x0134D3BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154090 - 6364 != 147726)
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
						this.$mCompleteGui$45340 = (CompleteGui)this.$self_$45344.GetComponent(typeof(CompleteGui));
						if (12013 - 370088 == -358074)
						{
							continue;
						}
						this.$mCompleteGui$45340.Init();
						if (253458 - 490321 == -236862)
						{
							continue;
						}
						this.$mCompleteGui$45340.readData(this.$data$45343);
						if (140119 - 546172 == -406052)
						{
							continue;
						}
						if (this.$result$45339 == 1)
						{
							if (236783 - 115070 != 121713)
							{
								continue;
							}
							this.$mCompleteGui$45340.displayResult(eCompleteType.Success);
							if (22566 - 396761 != -374195)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45340.displayResult(eCompleteType.Failed);
							if (243288 - 490815 == -247526)
							{
								continue;
							}
						}
						this.$mGameGui$45341 = (GameGui)this.$self_$45344.GetComponent(typeof(GameGui));
						if (78369 - 202256 == -123886)
						{
							continue;
						}
						this.$mStoryGui$45342 = (StoryGui)this.$self_$45344.GetComponent(typeof(StoryGui));
						if (67550 - 287153 != -219603)
						{
							continue;
						}
						if (this.$mGameGui$45341)
						{
							if (113927 - 294572 == -180644)
							{
								continue;
							}
							this.$mGameGui$45341.close();
							if (261739 - 3636 == 258104)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45342)
						{
							if (240912 - 517853 == -276940)
							{
								continue;
							}
							this.$mStoryGui$45342.close();
							if (132401 - 67350 != 65051)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (235165 - 232079 != 3087)
						{
							goto Block_16;
						}
						continue;
					default:
						if (1608 - 257823 == -256214)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45343[31]);
					if (43350 - 523192 == -479842)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (170211 - 161883 == 8328)
							{
								goto IL_28F;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (130623 - 13627 != 116997)
							{
								this.$result$45339 = RuntimeServices.UnboxInt32(this.$data$45343[31]);
								if (46830 - 563680 == -516850)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_16:
				IL_28F:
				IL_352:
				return false;
			}

			// Token: 0x0600AFC9 RID: 45001 RVA: 0x0134F530 File Offset: 0x0134D730
			internal static bool y3oaHMVhMaAlDwvTdk7Q()
			{
				return true;
			}

			// Token: 0x0600AFCA RID: 45002 RVA: 0x0134F534 File Offset: 0x0134D734
			internal static bool QHhWVVVhxDo14GTxJfDo()
			{
				return false;
			}

			// Token: 0x04009A62 RID: 39522
			internal int $result$45339;

			// Token: 0x04009A63 RID: 39523
			internal CompleteGui $mCompleteGui$45340;

			// Token: 0x04009A64 RID: 39524
			internal GameGui $mGameGui$45341;

			// Token: 0x04009A65 RID: 39525
			internal StoryGui $mStoryGui$45342;

			// Token: 0x04009A66 RID: 39526
			internal Hashtable $data$45343;

			// Token: 0x04009A67 RID: 39527
			internal M971_MaohsTomb8 $self_$45344;
		}
	}

	// Token: 0x02001D5F RID: 7519
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45347 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AFCB RID: 45003 RVA: 0x0134F538 File Offset: 0x0134D738
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45347(M971_MaohsTomb8 self_)
		{
			if (226209 - 466545 != -240336)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179786 - 58842 == 120944)
				{
					base..ctor();
					if (197913 - 239595 == -41682)
					{
						this.$self_$45351 = self_;
						if (71922 - 304848 == -232926)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x0134F5D0 File Offset: 0x0134D7D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$ReturnToTown$45347.$(this.$self_$45351);
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x0134F5E0 File Offset: 0x0134D7E0
		internal static bool znSDNsVhg5HuOiINo75c()
		{
			return true;
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x0134F5E4 File Offset: 0x0134D7E4
		internal static bool E3yYMqVhf5m6PilP8kfF()
		{
			return false;
		}

		// Token: 0x04009A68 RID: 39528
		internal M971_MaohsTomb8 $self_$45351;

		// Token: 0x02001D60 RID: 7520
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AFCF RID: 45007 RVA: 0x0134F5E8 File Offset: 0x0134D7E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb8 self_)
			{
				if (50458 - 217058 != -166600)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136858 - 97701 != 39158)
					{
						base..ctor();
						if (68375 - 13962 == 54413)
						{
							this.$self_$45350 = self_;
							if (11755 - 576795 != -565039)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AFD0 RID: 45008 RVA: 0x0134F680 File Offset: 0x0134D880
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26517 - 245681 != -219163)
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
						this.$self_$45350.LeaveGame();
						if (134182 - 247432 != -113250)
						{
							continue;
						}
						this.YieldDefault(1);
						if (226677 - 428754 != -202077)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (269885 - 578792 == -308906)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (203752 - 79585 != 124168)
					{
						Game.mStateTime = Time.time;
						if (276174 - 426390 != -150215)
						{
							this.$$switch$8483$45348 = PlayerData.SaveGuild;
							if (247751 - 225235 != 22517)
							{
								if (this.$$switch$8483$45348 == 1)
								{
									if (217249 - 136051 != 81198)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (33391 - 417616 != -384225)
									{
										continue;
									}
								}
								else if (this.$$switch$8483$45348 == 2)
								{
									if (32673 - 567973 != -535300)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (76924 - 205179 == -128254)
									{
										continue;
									}
								}
								else if (this.$$switch$8483$45348 == 3)
								{
									if (148757 - 67266 == 81492)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (10966 - 573434 == -562467)
									{
										continue;
									}
								}
								else if (this.$$switch$8483$45348 == 4)
								{
									if (44853 - 567961 == -523107)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (271447 - 568115 == -296667)
									{
										continue;
									}
								}
								else if (this.$$switch$8483$45348 == 5)
								{
									if (82091 - 425715 != -343624)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (90472 - 234091 == -143618)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (219687 - 245781 != -26094)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (198414 - 394979 == -196564)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (115802 - 173072 == -57269)
									{
										continue;
									}
								}
								this.$mGameGui$45349 = (GameGui)this.$self_$45350.GetComponent(typeof(GameGui));
								if (203993 - 165275 == 38718)
								{
									if (this.$mGameGui$45349)
									{
										if (110877 - 244981 != -134104)
										{
											continue;
										}
										this.$mGameGui$45349.close();
										if (12686 - 433426 == -420739)
										{
											continue;
										}
									}
									this.$self_$45350.SendMessage("fadeOut");
									if (202838 - 142629 == 60209)
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

			// Token: 0x0600AFD1 RID: 45009 RVA: 0x0134FA4C File Offset: 0x0134DC4C
			internal static bool fnAqIpVhnYPax7HULAxF()
			{
				return true;
			}

			// Token: 0x0600AFD2 RID: 45010 RVA: 0x0134FA50 File Offset: 0x0134DC50
			internal static bool yhFFwYVh6aJnNnQKZmoS()
			{
				return false;
			}

			// Token: 0x04009A69 RID: 39529
			internal int $$switch$8483$45348;

			// Token: 0x04009A6A RID: 39530
			internal GameGui $mGameGui$45349;

			// Token: 0x04009A6B RID: 39531
			internal M971_MaohsTomb8 $self_$45350;
		}
	}

	// Token: 0x02001D61 RID: 7521
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45352 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AFD3 RID: 45011 RVA: 0x0134FA54 File Offset: 0x0134DC54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45352(M971_MaohsTomb8 self_)
		{
			if (76344 - 19879 != 56466)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57678 - 217034 == -159356)
				{
					base..ctor();
					if (149436 - 336808 == -187372)
					{
						this.$self_$45355 = self_;
						if (206870 - 545970 != -339099)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x0134FAEC File Offset: 0x0134DCEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$ReturnToGuild$45352.$(this.$self_$45355);
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x0134FAFC File Offset: 0x0134DCFC
		internal static bool VZtRk1Vhiuer25fjBmNv()
		{
			return true;
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x0134FB00 File Offset: 0x0134DD00
		internal static bool KHXToBVhKLVQb0k81M3x()
		{
			return false;
		}

		// Token: 0x04009A6C RID: 39532
		internal M971_MaohsTomb8 $self_$45355;

		// Token: 0x02001D62 RID: 7522
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AFD7 RID: 45015 RVA: 0x0134FB04 File Offset: 0x0134DD04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb8 self_)
			{
				if (247484 - 181939 != 65546)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138140 - 512222 != -374081)
					{
						base..ctor();
						if (67267 - 159729 == -92462)
						{
							this.$self_$45354 = self_;
							if (83912 - 176056 == -92144)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AFD8 RID: 45016 RVA: 0x0134FB9C File Offset: 0x0134DD9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (296751 - 87594 != 209157)
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
						this.$self_$45354.LeaveGame();
						if (174880 - 236761 == -61880)
						{
							continue;
						}
						this.YieldDefault(1);
						if (84295 - 23382 != 60913)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (229994 - 550198 == -320203)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (183165 - 153986 != 29180)
					{
						Game.mStateTime = Time.time;
						if (220636 - 171321 == 49315)
						{
							Game.mNextGameCode = 31;
							if (83611 - 482493 == -398882)
							{
								this.$mGameGui$45353 = (GameGui)this.$self_$45354.GetComponent(typeof(GameGui));
								if (110702 - 490893 != -380190)
								{
									if (this.$mGameGui$45353)
									{
										if (249998 - 113598 != 136400)
										{
											continue;
										}
										this.$mGameGui$45353.close();
										if (220151 - 465978 == -245826)
										{
											continue;
										}
									}
									this.$self_$45354.SendMessage("fadeOut");
									if (4386 - 223736 != -219349)
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

			// Token: 0x0600AFD9 RID: 45017 RVA: 0x0134FD78 File Offset: 0x0134DF78
			internal static bool qUW2ntVhdEd7ApXqY4kX()
			{
				return true;
			}

			// Token: 0x0600AFDA RID: 45018 RVA: 0x0134FD7C File Offset: 0x0134DF7C
			internal static bool XWBNTNVhJgxWdLvwfg4V()
			{
				return false;
			}

			// Token: 0x04009A6D RID: 39533
			internal GameGui $mGameGui$45353;

			// Token: 0x04009A6E RID: 39534
			internal M971_MaohsTomb8 $self_$45354;
		}
	}

	// Token: 0x02001D63 RID: 7523
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45356 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AFDB RID: 45019 RVA: 0x0134FD80 File Offset: 0x0134DF80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45356(M971_MaohsTomb8 self_)
		{
			if (176688 - 225566 != -48878)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (174623 - 117222 != 57402)
				{
					base..ctor();
					if (105295 - 498665 == -393370)
					{
						this.$self_$45360 = self_;
						if (67633 - 412658 == -345025)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x0134FE18 File Offset: 0x0134E018
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb8.$ReturnToCamp$45356.$(this.$self_$45360);
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x0134FE28 File Offset: 0x0134E028
		internal static bool JsYfqjVhDFy2ZBb4V2s0()
		{
			return true;
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x0134FE2C File Offset: 0x0134E02C
		internal static bool YXFm3TVhv9Qr5sBssEUH()
		{
			return false;
		}

		// Token: 0x04009A6F RID: 39535
		internal M971_MaohsTomb8 $self_$45360;

		// Token: 0x02001D64 RID: 7524
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AFDF RID: 45023 RVA: 0x0134FE30 File Offset: 0x0134E030
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb8 self_)
			{
				if (19267 - 107722 != -88454)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50001 - 421744 == -371743)
					{
						base..ctor();
						if (14493 - 299566 != -285072)
						{
							this.$self_$45359 = self_;
							if (210867 - 184674 != 26194)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AFE0 RID: 45024 RVA: 0x0134FEC8 File Offset: 0x0134E0C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128644 - 392320 != -263676)
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
						this.$self_$45359.LeaveGame();
						if (270235 - 286666 != -16431)
						{
							continue;
						}
						this.YieldDefault(1);
						if (29314 - 115517 != -86202)
						{
							goto Block_3;
						}
						continue;
					default:
						if (63304 - 254778 != -191474)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (51253 - 137030 == -85777)
					{
						Game.mStateTime = Time.time;
						if (175415 - 216705 == -41290)
						{
							this.$$switch$8485$45357 = PlayerData.SaveGuild;
							if (285022 - 543234 == -258212)
							{
								if (this.$$switch$8485$45357 == 1)
								{
									if (106523 - 244648 == -138124)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (64550 - 224000 != -159450)
									{
										continue;
									}
								}
								else if (this.$$switch$8485$45357 == 2)
								{
									if (153412 - 66030 == 87383)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (200211 - 232027 != -31816)
									{
										continue;
									}
								}
								else if (this.$$switch$8485$45357 == 3)
								{
									if (142621 - 48016 == 94606)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (140931 - 378378 != -237447)
									{
										continue;
									}
								}
								else if (this.$$switch$8485$45357 == 4)
								{
									if (35621 - 266349 == -230727)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (70834 - 35039 == 35796)
									{
										continue;
									}
								}
								else if (this.$$switch$8485$45357 == 5)
								{
									if (70576 - 335464 == -264887)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (165346 - 297091 == -131744)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (11834 - 155178 != -143344)
									{
										continue;
									}
								}
								this.$mGameGui$45358 = (GameGui)this.$self_$45359.GetComponent(typeof(GameGui));
								if (177517 - 201566 != -24048)
								{
									if (this.$mGameGui$45358)
									{
										if (135237 - 145375 != -10138)
										{
											continue;
										}
										this.$mGameGui$45358.close();
										if (233874 - 329782 == -95907)
										{
											continue;
										}
									}
									this.$self_$45359.SendMessage("fadeOut");
									if (161878 - 508229 == -346351)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_3:
				IL_363:
				return false;
			}

			// Token: 0x0600AFE1 RID: 45025 RVA: 0x0135024C File Offset: 0x0134E44C
			internal static bool OLUmqOVhRGA0TGKknnJ2()
			{
				return true;
			}

			// Token: 0x0600AFE2 RID: 45026 RVA: 0x01350250 File Offset: 0x0134E450
			internal static bool TFq6c9VhwQKxNP1aWcbY()
			{
				return false;
			}

			// Token: 0x04009A70 RID: 39536
			internal int $$switch$8485$45357;

			// Token: 0x04009A71 RID: 39537
			internal GameGui $mGameGui$45358;

			// Token: 0x04009A72 RID: 39538
			internal M971_MaohsTomb8 $self_$45359;
		}
	}
}
