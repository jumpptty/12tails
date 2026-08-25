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

// Token: 0x02001E7A RID: 7802
[Serializable]
public class M973_PirateCave11 : MonoBehaviour
{
	// Token: 0x0600B624 RID: 46628 RVA: 0x013A5774 File Offset: 0x013A3974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave11()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B625 RID: 46629 RVA: 0x013A5784 File Offset: 0x013A3984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (288416 - 247462 != 40954)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (156732 - 358776 == -202044)
			{
				Game.mGameType = 5;
				if (101986 - 87311 != 14676)
				{
					if (Chat.Initialized)
					{
						if (79533 - 108667 != -29133)
						{
							Chat.ChatDisplay.Clear();
							if (209611 - 7036 != 202576)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (210303 - 569392 == -359089)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B626 RID: 46630 RVA: 0x013A5868 File Offset: 0x013A3A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (94924 - 245605 != -150680)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (54639 - 289176 != -234536)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (43460 - 23636 != 19825)
					{
						if (Game.mGameStage != 11)
						{
							break;
						}
						if (259323 - 171524 != 87800)
						{
							Game.nextGame();
							if (74908 - 421640 == -346732)
							{
								Game.mGameCode = 973;
								if (254328 - 432402 == -178074)
								{
									Game.mGameType = 5;
									if (243268 - 75144 != 168125)
									{
										Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
										if (220128 - 455055 != -234926)
										{
											Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
											if (226535 - 460298 == -233763)
											{
												Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
												if (295153 - 152273 != 142881)
												{
													Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
													if (253776 - 477377 == -223601)
													{
														Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
														if (293632 - 189256 != 104377)
														{
															this.Fwin1CjURMl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
															if (181174 - 547796 == -366622)
															{
																this.S6cn1ZTDD18 = PhotonClient.Connection;
																if (151825 - 474921 != -323095)
																{
																	PhotonClient.ActorNrList.Clear();
																	if (74455 - 472064 == -397609)
																	{
																		this.InitGame();
																		if (92761 - 131251 != -38489)
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
			else
			{
				Debug.Log("Not Connected");
				if (283271 - 599491 == -316220)
				{
					Game.mGameType = 99;
					if (121083 - 214811 == -93728)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B627 RID: 46631 RVA: 0x013A5B30 File Offset: 0x013A3D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (220760 - 260608 != -39848)
		{
		}
		for (;;)
		{
			if (this.S6cn1ZTDD18 == null)
			{
				if (76043 - 568245 == -492202)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (60352 - 192287 != -131934)
				{
					if (mGameState == eGameState.Init)
					{
						if (58494 - 1162 != 57333)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (287902 - 351583 != -63680)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (211706 - 101092 != 110615)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (91448 - 463223 == -371775)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (45322 - 78122 == -32800)
						{
							if (Game.music != 0)
							{
								if (131734 - 112574 != 19160)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (178370 - 393505 != -215135)
									{
										continue;
									}
									this.audio.Play();
									if (190787 - 352217 != -161430)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (231371 - 52154 != 179218)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (273480 - 195278 == 78202)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (110068 - 153913 != -43844)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (167145 - 424874 == -257729)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (154853 - 17806 == 137047)
							{
								if (Time.time <= this.Y6gn1M2xKxK)
								{
									break;
								}
								if (40240 - 314897 == -274657)
								{
									Game.mGameMana++;
									if (75987 - 503388 != -427400)
									{
										this.Y6gn1M2xKxK = Time.time + (float)12;
										if (245939 - 104503 == 141436)
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
						if (189137 - 306594 == -117457)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (72470 - 421192 != -348721)
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
						if (253600 - 222370 == 31230)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B628 RID: 46632 RVA: 0x013A5ED8 File Offset: 0x013A40D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (289914 - 575484 != -285569)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (151638 - 195649 != -44010)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (152820 - 106171 == 46649)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (84570 - 326916 == -242346)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (210609 - 410297 == -199688)
						{
							int num4 = num;
							if (239118 - 442586 == -203468)
							{
								if (num4 == 9732)
								{
									if (168017 - 80312 != 87706)
									{
										break;
									}
								}
								else if (num4 == -9732)
								{
									if (151557 - 564749 != -413191)
									{
										if (this.Hvln1flmXml >= 2)
										{
											break;
										}
										if (203227 - 334152 == -130925)
										{
											if (num2 != 1)
											{
												break;
											}
											if (296651 - 29382 == 267269)
											{
												this.Hvln1flmXml = 2;
												if (97289 - 332306 != -235016)
												{
													this.StartCoroutine_Auto(this.EndEvent());
													if (229362 - 431645 == -202283)
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
									Debug.LogError("Warning unknown returnCode:" + num);
									if (56975 - 124135 != -67159)
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

	// Token: 0x0600B629 RID: 46633 RVA: 0x013A60FC File Offset: 0x013A42FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M973_PirateCave11.$StartEvent$46280(this).GetEnumerator();
	}

	// Token: 0x0600B62A RID: 46634 RVA: 0x013A610C File Offset: 0x013A430C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M973_PirateCave11.$EndEvent$46286(this).GetEnumerator();
	}

	// Token: 0x0600B62B RID: 46635 RVA: 0x013A611C File Offset: 0x013A431C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToCaptainCrab()
	{
		if (201437 - 446504 != -245067)
		{
		}
		while (this.Hvln1flmXml < 1)
		{
			if (53873 - 382237 != -328363)
			{
				this.Hvln1flmXml = 1;
				if (214057 - 216262 != -2204)
				{
					Game.sendMissionEvent(9732, 1);
					if (264404 - 63808 != 200597)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B62C RID: 46636 RVA: 0x013A61C0 File Offset: 0x013A43C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToHumpback()
	{
		if (this.Hvln1flmXml < 1)
		{
			Chat.SubmitChat("Jamon", Language.getMessage("M973_PirateCave", UnityEngine.Random.Range(1131, 1136)), eChatType.npc, eChatMode.system);
		}
	}

	// Token: 0x0600B62D RID: 46637 RVA: 0x013A61F4 File Offset: 0x013A43F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToKoala()
	{
		if (184811 - 217059 != -32247)
		{
		}
		while (this.Hvln1flmXml < 1)
		{
			if (54765 - 53603 == 1162)
			{
				Chat.SubmitChat("Akola", Language.getMessage("M973_PirateCave", 1141 + this.O5Bn1L4jt44 % 5), eChatType.npc, eChatMode.system);
				if (208558 - 154057 == 54501)
				{
					this.O5Bn1L4jt44++;
					if (107210 - 97302 == 9908)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B62E RID: 46638 RVA: 0x013A62B8 File Offset: 0x013A44B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToCatfish()
	{
		if (this.Hvln1flmXml < 1)
		{
			Chat.SubmitChat("Dwukfu", Language.getMessage("M973_PirateCave", UnityEngine.Random.Range(1151, 1156)), eChatType.npc, eChatMode.system);
		}
	}

	// Token: 0x0600B62F RID: 46639 RVA: 0x013A62EC File Offset: 0x013A44EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToGuibo()
	{
		if (this.Hvln1flmXml < 1)
		{
			Chat.SubmitChat("Guibo", Language.getMessage("M973_PirateCave", UnityEngine.Random.Range(1161, 1166)), eChatType.npc, eChatMode.system);
		}
	}

	// Token: 0x0600B630 RID: 46640 RVA: 0x013A6320 File Offset: 0x013A4520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (123060 - 413905 != -290844)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (55417 - 190007 != -134589)
			{
				Time.timeScale = 1f;
				if (29336 - 240217 != -210880)
				{
					Hashtable customOpParameters = new Hashtable();
					if (68926 - 235819 == -166893)
					{
						this.S6cn1ZTDD18.OpCustom(52, customOpParameters, true);
						if (274916 - 214192 == 60724)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B631 RID: 46641 RVA: 0x013A63EC File Offset: 0x013A45EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (167578 - 245085 != -77506)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (210266 - 454786 != -244519)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (155480 - 217200 != -61719)
				{
					Game.mGameState = eGameState.Setup;
					if (258176 - 118237 == 139939)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B632 RID: 46642 RVA: 0x013A6490 File Offset: 0x013A4690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (167786 - 594953 != -427167)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (135928 - 338884 == -202956)
			{
				if (num == PlayerData.UID)
				{
					if (93580 - 494863 == -401283)
					{
						this.SetupActors();
						if (10768 - 341490 == -330722)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (94037 - 516940 != -422902)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B633 RID: 46643 RVA: 0x013A6560 File Offset: 0x013A4760
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (152496 - 511902 != -359405)
		{
		}
		for (;;)
		{
			IL_B8:
			Debug.Log("Creating Actors");
			if (249423 - 217444 != 31980)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (233626 - 395198 == -161572)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (211090 - 355925 == -144835)
						{
							int i = 0;
							if (124780 - 499430 == -374650)
							{
								CharacterControl[] array2 = array;
								if (80077 - 587253 == -507176)
								{
									int length = array2.Length;
									if (97965 - 445495 == -347530)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (267858 - 263434 == 4425)
												{
													goto IL_B8;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (168666 - 598263 == -429596)
												{
													goto IL_B8;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (30676 - 588950 != -558274)
												{
													goto IL_B8;
												}
												this.gebn1wX0Mp6++;
												if (149780 - 34808 == 114973)
												{
													goto IL_B8;
												}
											}
											i++;
											if (106690 - 388615 != -281925)
											{
												goto IL_B8;
											}
										}
										if (175902 - 364231 != -188328)
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
						if (199138 - 557386 != -358247)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B634 RID: 46644 RVA: 0x013A679C File Offset: 0x013A499C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (199573 - 245658 != -46084)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (148599 - 447779 == -299180)
			{
				int i = 0;
				if (221482 - 419266 != -197783)
				{
					CharacterControl[] array2 = array;
					if (80083 - 13929 != 66155)
					{
						int length = array2.Length;
						if (278211 - 62113 == 216098)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (176012 - 136318 != 39694)
								{
									goto IL_58;
								}
								i++;
								if (93971 - 197859 == -103887)
								{
									goto IL_58;
								}
							}
							if (154801 - 205737 != -50935)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B635 RID: 46645 RVA: 0x013A68CC File Offset: 0x013A4ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (35906 - 366302 != -330396)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (105252 - 208921 == -103669)
			{
				Game.mGameState = eGameState.Ready;
				if (156290 - 215343 == -59053)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (7110 - 269333 != -262222 && 50607 - 389677 != -339069)
					{
						GameObject gameObject = null;
						if (97566 - 4815 == 92751)
						{
							if (playerSlot < 1)
							{
								goto IL_274;
							}
							if (198984 - 573110 != -374126)
							{
								continue;
							}
							if (playerSlot > 12)
							{
								goto IL_274;
							}
							if (231151 - 25682 != 205469)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (186777 - 385185 != -198408)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (74641 - 416388 == -341746)
							{
								continue;
							}
							IL_182:
							if (gameObject2)
							{
								if (246452 - 237417 == 9036)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (34136 - 443075 != -408939)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (38620 - 122404 != -83784)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (280008 - 248196 != 31812)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (34393 - 273930 != -239537)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (33866 - 474007 == -440140)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (74459 - 38226 != 36233)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (292242 - 318965 != -26722)
							{
								break;
							}
							continue;
							IL_274:
							gameObject2 = GameObject.Find("StartPoint1");
							if (88474 - 582786 == -494312)
							{
								goto IL_182;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B636 RID: 46646 RVA: 0x013A6BF0 File Offset: 0x013A4DF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (152924 - 324511 != -171586)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (68 - 274540 != -274471)
			{
				Game.mGameState = eGameState.Start;
				if (193353 - 517715 != -324361)
				{
					Game.mStateTime = Time.time;
					if (182085 - 470001 == -287916)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (182330 - 22857 != 159474)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B637 RID: 46647 RVA: 0x013A6CB8 File Offset: 0x013A4EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B638 RID: 46648 RVA: 0x013A6CBC File Offset: 0x013A4EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (218084 - 330235 != -112150)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (3015 - 268730 != -265714)
			{
				if (gameObject)
				{
					if (154878 - 39153 == 115725)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (46110 - 555164 != -509053)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (298636 - 73737 != 224900)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B639 RID: 46649 RVA: 0x013A6DB8 File Offset: 0x013A4FB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (193624 - 491691 != -298066)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (41922 - 168978 == -127056)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (29443 - 24930 == 4513)
				{
					hashtable.Add(43, PlayerData.UID);
					if (140470 - 261678 == -121208)
					{
						hashtable.Add(73, nType);
						if (241767 - 169174 != 72594)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (240228 - 275007 != -34778)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (225959 - 585003 != -359043)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (222769 - 575375 != -352605)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (62067 - 181871 == -119804)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (291476 - 286604 != 4873)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (224728 - 354820 == -130092)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (273330 - 271823 == 1507)
													{
														this.S6cn1ZTDD18.OpCustom(63, hashtable, true);
														if (255180 - 524088 == -268908)
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

	// Token: 0x0600B63A RID: 46650 RVA: 0x013A709C File Offset: 0x013A529C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (152091 - 272758 != -120667)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (13957 - 481136 == -467179)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (136837 - 126965 == 9872)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (125660 - 137667 == -12007)
						{
							if (this.gebn1wX0Mp6 <= 0)
							{
								break;
							}
							if (5361 - 434039 != -428677)
							{
								this.gebn1wX0Mp6--;
								if (268281 - 288023 != -19741)
								{
									if (this.gebn1wX0Mp6 != 0)
									{
										break;
									}
									if (291274 - 249329 != 41946)
									{
										Game.setGameState(eGameState.Ready);
										if (232947 - 189914 != 43034)
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
						if (88689 - 481015 != -392325)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (214471 - 335722 == -121251)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B63B RID: 46651 RVA: 0x013A722C File Offset: 0x013A542C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (205476 - 290110 != -84633)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (229837 - 494623 == -264786)
			{
				hashtable.Add(71, CID);
				if (204230 - 258129 == -53899)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (284889 - 248762 == 36127)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (182638 - 416879 != -234240)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (24966 - 153584 == -128618)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (161248 - 569246 != -407997)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (43824 - 234441 == -190617)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (179444 - 337626 == -158182)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (252724 - 185701 == 67023)
											{
												this.S6cn1ZTDD18.OpCustom(61, hashtable, true);
												if (176217 - 12735 == 163482)
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

	// Token: 0x0600B63C RID: 46652 RVA: 0x013A74B8 File Offset: 0x013A56B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (188949 - 351473 != -162524)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (152638 - 465824 != -313185)
			{
				if (!gameObject)
				{
					break;
				}
				if (134709 - 569845 == -435136)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (297305 - 39176 != 258130)
					{
						playerCameraControl.target = gameObject;
						if (243958 - 429311 == -185353)
						{
							this.StartGame();
							if (209864 - 19550 != 190315)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B63D RID: 46653 RVA: 0x013A75A8 File Offset: 0x013A57A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (105472 - 533680 != -428208)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (242318 - 346105 == -103787)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (51684 - 508660 == -456976)
				{
					gameGui.ResetTeamBar();
					if (240501 - 122483 != 118019)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B63E RID: 46654 RVA: 0x013A7654 File Offset: 0x013A5854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave11.$onDeadPlayer$46291(this).GetEnumerator();
	}

	// Token: 0x0600B63F RID: 46655 RVA: 0x013A7664 File Offset: 0x013A5864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (272669 - 89044 != 183625)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (114546 - 535262 != -420715)
			{
				this.Fwin1CjURMl.target = Game.mPlayer;
				if (230784 - 217572 != 13213)
				{
					this.Fwin1CjURMl.enabled = true;
					if (33842 - 387708 == -353866)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (271056 - 591032 == -319975)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (252054 - 207302 == 44753)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (88821 - 106317 == -17496)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (148135 - 256170 == -108035)
							{
								if (!gameGui)
								{
									break;
								}
								if (148752 - 160003 == -11251)
								{
									gameGui.enabled = true;
									if (289681 - 570923 != -281241)
									{
										gameGui.closeDeadMenu();
										if (160970 - 565865 == -404895)
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

	// Token: 0x0600B640 RID: 46656 RVA: 0x013A7810 File Offset: 0x013A5A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (231228 - 495220 != -263992)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (44533 - 243358 == -198825)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (95232 - 271114 == -175882)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (265186 - 404102 == -138916)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B641 RID: 46657 RVA: 0x013A78D4 File Offset: 0x013A5AD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B642 RID: 46658 RVA: 0x013A7900 File Offset: 0x013A5B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (264432 - 105066 != 159366)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (36292 - 483450 != -447157)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (261966 - 1437 != 260530)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (125860 - 544384 == -418524)
					{
						Hashtable hashtable = new Hashtable();
						if (126708 - 119294 != 7415)
						{
							hashtable.Add(43, PlayerData.UID);
							if (12120 - 360215 == -348095)
							{
								hashtable.Add(71, nCID);
								if (146875 - 472705 == -325830)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (85984 - 370481 == -284497)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (244779 - 237078 == 7701)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (6154 - 496732 != -490577)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (266510 - 533727 == -267217)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (34178 - 374032 == -339854)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (175812 - 507805 == -331993)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (145616 - 517780 == -372164)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (153292 - 556006 != -402713)
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

	// Token: 0x0600B643 RID: 46659 RVA: 0x013A7C20 File Offset: 0x013A5E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave11.$onChangePlayer$46297(data, this).GetEnumerator();
	}

	// Token: 0x0600B644 RID: 46660 RVA: 0x013A7C30 File Offset: 0x013A5E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave11.$onGameComplete$46304(data, this).GetEnumerator();
	}

	// Token: 0x0600B645 RID: 46661 RVA: 0x013A7C40 File Offset: 0x013A5E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave11.$ReturnToTown$46314(this).GetEnumerator();
	}

	// Token: 0x0600B646 RID: 46662 RVA: 0x013A7C50 File Offset: 0x013A5E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave11.$ReturnToGuild$46319(this).GetEnumerator();
	}

	// Token: 0x0600B647 RID: 46663 RVA: 0x013A7C60 File Offset: 0x013A5E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave11.$ReturnToCamp$46323(this).GetEnumerator();
	}

	// Token: 0x0600B648 RID: 46664 RVA: 0x013A7C70 File Offset: 0x013A5E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (61513 - 373109 != -311596)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (151873 - 213403 == -61530)
			{
				Hashtable hashtable = new Hashtable();
				if (182259 - 492134 != -309874)
				{
					hashtable.Add(43, PlayerData.UID);
					if (159621 - 100877 == 58744)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (160968 - 410852 != -249883)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B649 RID: 46665 RVA: 0x013A7D48 File Offset: 0x013A5F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B64A RID: 46666 RVA: 0x013A7D5C File Offset: 0x013A5F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (97583 - 328671 != -231087)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (17045 - 279183 == -262138)
			{
				Hashtable hashtable = new Hashtable();
				if (234651 - 361055 != -126403)
				{
					if (Game.mNextGameCode == 30)
					{
						if (217724 - 344899 == -127174)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (285959 - 57525 == 228435)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (69726 - 544566 != -474840)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (185596 - 214225 != -28629)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (153003 - 69320 == 83684)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (86855 - 170606 == -83750)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (1905 - 386885 != -384980)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (45427 - 90684 != -45257)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (232234 - 592160 == -359925)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (299073 - 214326 == 84748)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (161457 - 513692 != -352235)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (264694 - 220576 == 44119)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (118814 - 298923 != -180109)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (259106 - 381722 != -122616)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (215005 - 446666 != -231661)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (248285 - 378032 != -129747)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (209389 - 353419 != -144030)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (4075 - 520881 == -516805)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (281994 - 77398 == 204597)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (296035 - 57607 == 238429)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (84362 - 197408 == -113045)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (11927 - 390431 != -378504)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (277739 - 329785 == -52045)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (273665 - 31058 != 242607)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (111391 - 334804 == -223412)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (273472 - 507094 != -233622)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (142835 - 280114 != -137279)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (289541 - 358090 == -68548)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (167793 - 530306 == -362513)
					{
						this.S6cn1ZTDD18.OpCustom(42, hashtable, true);
						if (263210 - 52195 != 211016)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B64B RID: 46667 RVA: 0x013A8310 File Offset: 0x013A6510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B64C RID: 46668 RVA: 0x013A8320 File Offset: 0x013A6520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B64D RID: 46669 RVA: 0x013A8324 File Offset: 0x013A6524
	internal static bool JPGelNtVDdGrStyJJOfB()
	{
		return true;
	}

	// Token: 0x0600B64E RID: 46670 RVA: 0x013A8328 File Offset: 0x013A6528
	internal static bool LLTWbktVvKd8R7wiAs8B()
	{
		return false;
	}

	// Token: 0x04009DF3 RID: 40435
	private LitePeer S6cn1ZTDD18;

	// Token: 0x04009DF4 RID: 40436
	private PlayerCameraControl Fwin1CjURMl;

	// Token: 0x04009DF5 RID: 40437
	private float Y6gn1M2xKxK;

	// Token: 0x04009DF6 RID: 40438
	private int Hvln1flmXml;

	// Token: 0x04009DF7 RID: 40439
	private int O5Bn1L4jt44;

	// Token: 0x04009DF8 RID: 40440
	private int gebn1wX0Mp6;

	// Token: 0x02001E7B RID: 7803
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46280 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B64F RID: 46671 RVA: 0x013A832C File Offset: 0x013A652C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46280(M973_PirateCave11 self_)
		{
			if (62093 - 230257 != -168163)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (229361 - 45895 == 183466)
				{
					base..ctor();
					if (279576 - 547991 == -268415)
					{
						this.$self_$46285 = self_;
						if (29866 - 237742 != -207875)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B650 RID: 46672 RVA: 0x013A83C4 File Offset: 0x013A65C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave11.$StartEvent$46280.$(this.$self_$46285);
		}

		// Token: 0x0600B651 RID: 46673 RVA: 0x013A83D4 File Offset: 0x013A65D4
		internal static bool uccmbUtVRmCGRYWEcXoB()
		{
			return true;
		}

		// Token: 0x0600B652 RID: 46674 RVA: 0x013A83D8 File Offset: 0x013A65D8
		internal static bool uGVevetVwekb9mEorR7x()
		{
			return false;
		}

		// Token: 0x04009DF9 RID: 40441
		internal M973_PirateCave11 $self_$46285;

		// Token: 0x02001E7C RID: 7804
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B653 RID: 46675 RVA: 0x013A83DC File Offset: 0x013A65DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave11 self_)
			{
				if (33920 - 522499 != -488578)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19466 - 369467 == -350001)
					{
						base..ctor();
						if (64648 - 458996 != -394347)
						{
							this.$self_$46284 = self_;
							if (61989 - 204399 != -142409)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B654 RID: 46676 RVA: 0x013A8474 File Offset: 0x013A6674
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (152891 - 301346 != -148455)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E4;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (288497 - 217387 != 71111)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46281 = (StoryGui)this.$self_$46284.GetComponent(typeof(StoryGui));
							if (14605 - 303135 == -288529)
							{
								continue;
							}
							this.$mStoryTimer$46282 = 0f;
							if (263444 - 210115 != 53329)
							{
								continue;
							}
							if (!this.$mStoryGui$46281)
							{
								goto IL_483;
							}
							if (238633 - 206793 == 31841)
							{
								continue;
							}
							this.$mStoryGui$46281.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (24175 - 478631 != -454455)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (276069 - 577040 != -300970)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46281.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 1101), eTalkType.friend);
							if (114657 - 100682 != 13975)
							{
								continue;
							}
							goto IL_59;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (223836 - 240913 != -17076)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46281.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 1102), eTalkType.friend);
							if (28043 - 391798 != -363755)
							{
								continue;
							}
							goto IL_30F;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (90527 - 100463 != -9936)
							{
								continue;
							}
							goto IL_2AA;
						}
						else
						{
							this.$mStoryGui$46281.close();
							if (145382 - 485120 != -339738)
							{
								continue;
							}
							goto IL_3AE;
						}
						break;
					case 6:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_483;
						}
						if (236703 - 483341 != -246637)
						{
							goto Block_25;
						}
						continue;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (55309 - 7430 != 47879)
							{
								continue;
							}
							goto IL_E3;
						}
						else
						{
							this.$mGameGui$46283 = (GameGui)this.$self_$46284.GetComponent(typeof(GameGui));
							if (156929 - 133135 == 23795)
							{
								continue;
							}
							this.$mGameGui$46283.enabled = true;
							if (149308 - 430829 == -281520)
							{
								continue;
							}
							this.$self_$46284.Fwin1CjURMl.enabled = true;
							if (23140 - 86337 != -63197)
							{
								continue;
							}
							goto IL_183;
						}
						break;
					case 8:
						Game.mGameState = eGameState.Normal;
						if (56325 - 512729 == -456403)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (19966 - 381988 == -362021)
						{
							continue;
						}
						this.YieldDefault(1);
						if (191925 - 590857 != -398931)
						{
							goto Block_27;
						}
						continue;
					default:
						if (181846 - 386816 == -204969)
						{
							continue;
						}
						break;
					}
					Debug.Log("StartEvent");
					if (65947 - 462447 == -396500)
					{
						this.$self_$46284.Fwin1CjURMl.alignToObject("EventCamera1");
						if (26633 - 62624 != -35990)
						{
							this.$self_$46284.SendMessage("fadeIn");
							if (15183 - 476263 == -461080)
							{
								goto IL_2D4;
							}
						}
					}
				}
				IL_59:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_4:
				IL_E3:
				Block_9:
				goto IL_4E4;
				IL_183:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_2AA:
				goto IL_4E4;
				IL_2D4:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_19:
				goto IL_4E4;
				IL_30F:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_22:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_3AE:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_25:
				Block_27:
				goto IL_4E4;
				IL_483:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_4E4:
				return false;
			}

			// Token: 0x0600B655 RID: 46677 RVA: 0x013A8978 File Offset: 0x013A6B78
			internal static bool looeWntVqdmoydZ08N04()
			{
				return true;
			}

			// Token: 0x0600B656 RID: 46678 RVA: 0x013A897C File Offset: 0x013A6B7C
			internal static bool jxGvDDtV7Do6nn9inqDD()
			{
				return false;
			}

			// Token: 0x04009DFA RID: 40442
			internal StoryGui $mStoryGui$46281;

			// Token: 0x04009DFB RID: 40443
			internal float $mStoryTimer$46282;

			// Token: 0x04009DFC RID: 40444
			internal GameGui $mGameGui$46283;

			// Token: 0x04009DFD RID: 40445
			internal M973_PirateCave11 $self_$46284;
		}
	}

	// Token: 0x02001E7D RID: 7805
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$46286 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B657 RID: 46679 RVA: 0x013A8980 File Offset: 0x013A6B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$46286(M973_PirateCave11 self_)
		{
			if (135105 - 28815 != 106290)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109020 - 292703 == -183683)
				{
					base..ctor();
					if (173470 - 577200 != -403729)
					{
						this.$self_$46290 = self_;
						if (138031 - 510952 == -372921)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x013A8A18 File Offset: 0x013A6C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave11.$EndEvent$46286.$(this.$self_$46290);
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x013A8A28 File Offset: 0x013A6C28
		internal static bool LtBLd8tVPRkyUmsccbwG()
		{
			return true;
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x013A8A2C File Offset: 0x013A6C2C
		internal static bool nPYudatV0goaCo57a52D()
		{
			return false;
		}

		// Token: 0x04009DFE RID: 40446
		internal M973_PirateCave11 $self_$46290;

		// Token: 0x02001E7E RID: 7806
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B65B RID: 46683 RVA: 0x013A8A30 File Offset: 0x013A6C30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave11 self_)
			{
				if (242733 - 317587 != -74854)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141537 - 435195 != -293657)
					{
						base..ctor();
						if (225263 - 308980 != -83716)
						{
							this.$self_$46289 = self_;
							if (12815 - 2683 != 10133)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B65C RID: 46684 RVA: 0x013A8AC8 File Offset: 0x013A6CC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (206276 - 457256 != -250979)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_954;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212339 - 118270 != 94070)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$self_$46289.SendMessage("fadeOut");
							if (163930 - 404934 != -241004)
							{
								continue;
							}
							goto IL_309;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (147117 - 559610 != -412492)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$46289.Fwin1CjURMl.alignToObject("EventCamera2");
							if (257347 - 575674 != -318326)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (14353 - 10977 != 3377)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$46289.SendMessage("fadeIn");
							if (197981 - 207429 == -9447)
							{
								continue;
							}
							this.$self_$46289.Fwin1CjURMl.StartCoroutine_Auto(this.$self_$46289.Fwin1CjURMl.slerpToObject("EventCamera2", (float)1));
							if (173489 - 417781 != -244291)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 5:
						this.$mStoryGui$46288 = (StoryGui)this.$self_$46289.GetComponent(typeof(StoryGui));
						if (256423 - 48475 != 207948)
						{
							continue;
						}
						if (!this.$mStoryGui$46288)
						{
							goto IL_6AE;
						}
						if (158699 - 510863 != -352164)
						{
							continue;
						}
						this.$mStoryGui$46288.startStoryMessage("Humpback", "Jamon", eTalkType.friend);
						if (44566 - 461277 != -416711)
						{
							continue;
						}
						goto IL_5B0;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (23651 - 29194 != -5543)
							{
								continue;
							}
							goto IL_7B7;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("Humpback", "Jamon", Language.getMessage("M973_PirateCave", 1111), eTalkType.friend);
							if (38081 - 150425 != -112344)
							{
								continue;
							}
							goto IL_919;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (218727 - 232218 != -13491)
							{
								continue;
							}
							goto IL_3CE;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1112), eTalkType.friend);
							if (239579 - 212684 != 26896)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (253046 - 344259 != -91213)
							{
								continue;
							}
							goto IL_389;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1113), eTalkType.friend);
							if (20106 - 415782 != -395675)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (274420 - 433745 != -159324)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1114), eTalkType.friend);
							if (119846 - 556784 != -436937)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (6419 - 161303 != -154884)
							{
								continue;
							}
							goto IL_344;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1115), eTalkType.friend);
							if (204796 - 281929 != -77133)
							{
								continue;
							}
							goto IL_53A;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (50394 - 351818 != -301424)
							{
								continue;
							}
							goto IL_7FC;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("Humpback", "Jamon", Language.getMessage("M973_PirateCave", 1116), eTalkType.friend);
							if (132642 - 217362 != -84720)
							{
								continue;
							}
							goto IL_73F;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (250408 - 86628 != 163781)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("Humpback", "Jamon", Language.getMessage("M973_PirateCave", 1117), eTalkType.friend);
							if (43356 - 313577 != -270221)
							{
								continue;
							}
							goto IL_2A3;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (26682 - 471487 != -444804)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("Humpback", "Jamon", Language.getMessage("M973_PirateCave", 1118), eTalkType.friend);
							if (299390 - 483675 != -184284)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (20861 - 133126 != -112264)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("Humpback", "Jamon", Language.getMessage("M973_PirateCave", 1119), eTalkType.friend);
							if (4253 - 287345 != -283091)
							{
								goto Block_45;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (179436 - 343059 != -163622)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46288.newStoryMessage("Humpback", "Jamon", Language.getMessage("M973_PirateCave", 1120), eTalkType.friend);
							if (35663 - 273885 != -238221)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (192736 - 481441 != -288704)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46288.close();
							if (97398 - 171049 != -73650)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (216424 - 5358 != 211066)
							{
								continue;
							}
							goto IL_715;
						}
						else
						{
							Game.sendMissionEvent(9739, 1);
							if (266677 - 108661 != 158016)
							{
								continue;
							}
							goto IL_6AE;
						}
						break;
					default:
						if (77586 - 523779 == -446192)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (168849 - 287871 != -119022)
					{
						continue;
					}
					this.$mGameGui$46287 = (GameGui)this.$self_$46289.GetComponent(typeof(GameGui));
					if (188272 - 370047 == -181774)
					{
						continue;
					}
					if (!this.$mGameGui$46287)
					{
						goto IL_488;
					}
					if (268598 - 8847 == 259752)
					{
						continue;
					}
					this.$mGameGui$46287.close();
					if (36416 - 212102 != -175686)
					{
						continue;
					}
					goto IL_488;
					IL_6AE:
					this.YieldDefault(1);
				}
				while (97435 - 123930 == -26494);
				Block_5:
				goto IL_954;
				Block_6:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_10:
				return this.Yield(14, new WaitForSeconds(3f));
				Block_11:
				return this.Yield(17, new WaitForSeconds(2f));
				Block_12:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_17:
				goto IL_954;
				IL_2A3:
				return this.Yield(13, new WaitForSeconds(3f));
				Block_19:
				goto IL_954;
				IL_309:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_23:
				IL_344:
				IL_389:
				goto IL_954;
				Block_25:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_3CE:
				goto IL_954;
				Block_26:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_488:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_30:
				Block_32:
				goto IL_954;
				IL_53A:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_5B0:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_41:
				goto IL_954;
				Block_42:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_43:
				return this.Yield(16, new WaitForSeconds(3f));
				goto IL_954;
				Block_45:
				return this.Yield(15, new WaitForSeconds(3f));
				IL_715:
				goto IL_954;
				IL_73F:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_48:
				IL_7B7:
				IL_7FC:
				Block_54:
				goto IL_954;
				IL_919:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_954:
				return false;
			}

			// Token: 0x0600B65D RID: 46685 RVA: 0x013A943C File Offset: 0x013A763C
			internal static bool Ro0wUatVbdSJlNeESpcG()
			{
				return true;
			}

			// Token: 0x0600B65E RID: 46686 RVA: 0x013A9440 File Offset: 0x013A7640
			internal static bool ajuSvTtVuK70rKjfTdPZ()
			{
				return false;
			}

			// Token: 0x04009DFF RID: 40447
			internal GameGui $mGameGui$46287;

			// Token: 0x04009E00 RID: 40448
			internal StoryGui $mStoryGui$46288;

			// Token: 0x04009E01 RID: 40449
			internal M973_PirateCave11 $self_$46289;
		}
	}

	// Token: 0x02001E7F RID: 7807
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46291 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B65F RID: 46687 RVA: 0x013A9444 File Offset: 0x013A7644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46291(M973_PirateCave11 self_)
		{
			if (251439 - 19022 != 232417)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157626 - 111619 != 46008)
				{
					base..ctor();
					if (169656 - 18209 == 151447)
					{
						this.$self_$46296 = self_;
						if (291028 - 209081 == 81947)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B660 RID: 46688 RVA: 0x013A94DC File Offset: 0x013A76DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave11.$onDeadPlayer$46291.$(this.$self_$46296);
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x013A94EC File Offset: 0x013A76EC
		internal static bool RqI0NItVIKybye5NEXdm()
		{
			return true;
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x013A94F0 File Offset: 0x013A76F0
		internal static bool Yl2yBTtVBVL4ToBL8kew()
		{
			return false;
		}

		// Token: 0x04009E02 RID: 40450
		internal M973_PirateCave11 $self_$46296;

		// Token: 0x02001E80 RID: 7808
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B663 RID: 46691 RVA: 0x013A94F4 File Offset: 0x013A76F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave11 self_)
			{
				if (169587 - 154068 != 15519)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55134 - 21189 != 33946)
					{
						base..ctor();
						if (2884 - 182715 == -179831)
						{
							this.$self_$46295 = self_;
							if (281056 - 216602 != 64455)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B664 RID: 46692 RVA: 0x013A958C File Offset: 0x013A778C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298442 - 311610 != -13168)
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
							if (287933 - 113978 != 173955)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1C4;
							}
							if (270898 - 329382 != -58484)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (210508 - 1994 != 208514)
						{
							continue;
						}
						this.$mStoryGui$46292 = (StoryGui)this.$self_$46295.GetComponent(typeof(StoryGui));
						if (68180 - 364777 != -296597)
						{
							continue;
						}
						if (this.$mStoryGui$46292)
						{
							if (170044 - 506916 == -336871)
							{
								continue;
							}
							this.$mStoryGui$46292.close();
							if (91378 - 27696 == 63683)
							{
								continue;
							}
						}
						this.$mChangeGui$46293 = (ChangeGui)this.$self_$46295.GetComponent(typeof(ChangeGui));
						if (176574 - 47624 != 128950)
						{
							continue;
						}
						if (this.$mChangeGui$46293)
						{
							if (63739 - 475333 != -411594)
							{
								continue;
							}
							this.$mChangeGui$46293.close();
							if (243289 - 508675 == -265385)
							{
								continue;
							}
						}
						this.$mGameGui$46294 = (GameGui)this.$self_$46295.GetComponent(typeof(GameGui));
						if (290358 - 529820 == -239461)
						{
							continue;
						}
						if (this.$mGameGui$46294)
						{
							if (16453 - 504545 == -488091)
							{
								continue;
							}
							if (!this.$mGameGui$46294.enabled)
							{
								if (263511 - 446002 == -182490)
								{
									continue;
								}
								this.$mGameGui$46294.enabled = true;
								if (11875 - 6498 == 5378)
								{
									continue;
								}
							}
							this.$mGameGui$46294.openDeadMenu();
							if (146435 - 238674 != -92239)
							{
								continue;
							}
						}
						IL_1C4:
						this.YieldDefault(1);
						if (24286 - 455920 != -431633)
						{
							goto Block_15;
						}
						continue;
					default:
						if (71972 - 370426 != -298454)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (2604 - 250679 != -248075);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_15:
				IL_2F9:
				return false;
			}

			// Token: 0x0600B665 RID: 46693 RVA: 0x013A98A4 File Offset: 0x013A7AA4
			internal static bool kJ3n5otVeQsseYmrpQ7D()
			{
				return true;
			}

			// Token: 0x0600B666 RID: 46694 RVA: 0x013A98A8 File Offset: 0x013A7AA8
			internal static bool CmTBbptVrVL1daqEbdac()
			{
				return false;
			}

			// Token: 0x04009E03 RID: 40451
			internal StoryGui $mStoryGui$46292;

			// Token: 0x04009E04 RID: 40452
			internal ChangeGui $mChangeGui$46293;

			// Token: 0x04009E05 RID: 40453
			internal GameGui $mGameGui$46294;

			// Token: 0x04009E06 RID: 40454
			internal M973_PirateCave11 $self_$46295;
		}
	}

	// Token: 0x02001E81 RID: 7809
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46297 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B667 RID: 46695 RVA: 0x013A98AC File Offset: 0x013A7AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46297(Hashtable data, M973_PirateCave11 self_)
		{
			if (151381 - 432919 != -281537)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287150 - 58953 != 228198)
				{
					base..ctor();
					if (81808 - 580994 != -499185)
					{
						this.$data$46302 = data;
						if (257337 - 538358 == -281021)
						{
							this.$self_$46303 = self_;
							if (123627 - 271007 != -147379)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B668 RID: 46696 RVA: 0x013A9968 File Offset: 0x013A7B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave11.$onChangePlayer$46297.$(this.$data$46302, this.$self_$46303);
		}

		// Token: 0x0600B669 RID: 46697 RVA: 0x013A997C File Offset: 0x013A7B7C
		internal static bool QiSvwWtVjt9DkjEgOajU()
		{
			return true;
		}

		// Token: 0x0600B66A RID: 46698 RVA: 0x013A9980 File Offset: 0x013A7B80
		internal static bool G8pwNQtVhDp5WDItehyX()
		{
			return false;
		}

		// Token: 0x04009E07 RID: 40455
		internal Hashtable $data$46302;

		// Token: 0x04009E08 RID: 40456
		internal M973_PirateCave11 $self_$46303;

		// Token: 0x02001E82 RID: 7810
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B66B RID: 46699 RVA: 0x013A9984 File Offset: 0x013A7B84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave11 self_)
			{
				if (169588 - 183447 != -13859)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (41959 - 26624 != 15336)
					{
						base..ctor();
						if (262151 - 333750 != -71598)
						{
							this.$data$46300 = data;
							if (79159 - 6151 != 73009)
							{
								this.$self_$46301 = self_;
								if (156531 - 382715 == -226184)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B66C RID: 46700 RVA: 0x013A9A40 File Offset: 0x013A7C40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (206593 - 462377 != -255784)
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
							if (160255 - 353072 == -192816)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (288142 - 298672 != -10530)
							{
								continue;
							}
							this.$mGameGui$46299 = (GameGui)this.$self_$46301.GetComponent(typeof(GameGui));
							if (226351 - 133903 != 92448)
							{
								continue;
							}
							this.$mGameGui$46299.enabled = true;
							if (17540 - 574305 == -556764)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (264722 - 195669 != 69053)
						{
							continue;
						}
						goto IL_205;
					default:
						if (164973 - 237219 == -72245)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (34879 - 391381 == -356502)
					{
						this.$self_$46301.SendMessage("onCreatePlayer", this.$data$46300);
						if (186374 - 374099 != -187724)
						{
							this.$mChangeGui$46298 = (ChangeGui)this.$self_$46301.GetComponent(typeof(ChangeGui));
							if (162963 - 162466 == 497)
							{
								if (!this.$mChangeGui$46298.enabled)
								{
									break;
								}
								if (150971 - 273073 != -122101)
								{
									this.$mChangeGui$46298.close();
									if (142734 - 214806 == -72072)
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

			// Token: 0x0600B66D RID: 46701 RVA: 0x013A9C64 File Offset: 0x013A7E64
			internal static bool gXqGsdtVsWXwyYhdg010()
			{
				return true;
			}

			// Token: 0x0600B66E RID: 46702 RVA: 0x013A9C68 File Offset: 0x013A7E68
			internal static bool oxpjuitV9hsiGIKGadxM()
			{
				return false;
			}

			// Token: 0x04009E09 RID: 40457
			internal ChangeGui $mChangeGui$46298;

			// Token: 0x04009E0A RID: 40458
			internal GameGui $mGameGui$46299;

			// Token: 0x04009E0B RID: 40459
			internal Hashtable $data$46300;

			// Token: 0x04009E0C RID: 40460
			internal M973_PirateCave11 $self_$46301;
		}
	}

	// Token: 0x02001E83 RID: 7811
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46304 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B66F RID: 46703 RVA: 0x013A9C6C File Offset: 0x013A7E6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46304(Hashtable data, M973_PirateCave11 self_)
		{
			if (273055 - 557922 != -284867)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238120 - 106675 == 131445)
				{
					base..ctor();
					if (282256 - 402736 == -120480)
					{
						this.$data$46312 = data;
						if (71474 - 43074 == 28400)
						{
							this.$self_$46313 = self_;
							if (254086 - 23621 != 230466)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B670 RID: 46704 RVA: 0x013A9D28 File Offset: 0x013A7F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave11.$onGameComplete$46304.$(this.$data$46312, this.$self_$46313);
		}

		// Token: 0x0600B671 RID: 46705 RVA: 0x013A9D3C File Offset: 0x013A7F3C
		internal static bool TxS2jltV1ont6rwYVUBl()
		{
			return true;
		}

		// Token: 0x0600B672 RID: 46706 RVA: 0x013A9D40 File Offset: 0x013A7F40
		internal static bool qPCVWdtV4teZOmyXK1HV()
		{
			return false;
		}

		// Token: 0x04009E0D RID: 40461
		internal Hashtable $data$46312;

		// Token: 0x04009E0E RID: 40462
		internal M973_PirateCave11 $self_$46313;

		// Token: 0x02001E84 RID: 7812
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B673 RID: 46707 RVA: 0x013A9D44 File Offset: 0x013A7F44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave11 self_)
			{
				if (292344 - 356400 != -64056)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (278652 - 395111 == -116459)
					{
						base..ctor();
						if (223660 - 38595 == 185065)
						{
							this.$data$46310 = data;
							if (168835 - 576020 != -407184)
							{
								this.$self_$46311 = self_;
								if (83390 - 157624 != -74233)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B674 RID: 46708 RVA: 0x013A9E00 File Offset: 0x013A8000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163741 - 193676 != -29934)
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
						this.$mCompleteGui$46306 = (CompleteGui)this.$self_$46311.GetComponent(typeof(CompleteGui));
						if (220733 - 288124 == -67390)
						{
							continue;
						}
						this.$mCompleteGui$46306.Init();
						if (143444 - 58894 != 84550)
						{
							continue;
						}
						this.$mCompleteGui$46306.readData(this.$data$46310);
						if (127034 - 98059 == 28976)
						{
							continue;
						}
						if (this.$result$46305 == 1)
						{
							if (266316 - 429751 == -163434)
							{
								continue;
							}
							this.$mCompleteGui$46306.displayResult(eCompleteType.Success);
							if (263255 - 31363 == 231893)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46306.displayResult(eCompleteType.Failed);
							if (33274 - 514813 == -481538)
							{
								continue;
							}
						}
						this.$mGameGui$46307 = (GameGui)this.$self_$46311.GetComponent(typeof(GameGui));
						if (169164 - 387197 != -218033)
						{
							continue;
						}
						this.$mStoryGui$46308 = (StoryGui)this.$self_$46311.GetComponent(typeof(StoryGui));
						if (297724 - 440253 == -142528)
						{
							continue;
						}
						this.$mChangeGui$46309 = (ChangeGui)this.$self_$46311.GetComponent(typeof(ChangeGui));
						if (54273 - 392413 != -338140)
						{
							continue;
						}
						if (this.$mGameGui$46307)
						{
							if (250622 - 289778 != -39156)
							{
								continue;
							}
							this.$mGameGui$46307.close();
							if (156257 - 440239 != -283982)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46308)
						{
							if (298809 - 481886 != -183077)
							{
								continue;
							}
							this.$mStoryGui$46308.close();
							if (116288 - 156230 != -39942)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46309)
						{
							if (72179 - 306249 == -234069)
							{
								continue;
							}
							this.$mChangeGui$46309.disable();
							if (246268 - 189074 != 57194)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (34808 - 597391 != -562583)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (60457 - 278636 != -218179)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46310[31]);
					if (68506 - 413790 != -345283)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (75490 - 491616 == -416126)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (128588 - 272068 != -143479)
							{
								this.$result$46305 = RuntimeServices.UnboxInt32(this.$data$46310[31]);
								if (81960 - 586025 == -504065)
								{
									goto IL_185;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_185:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B675 RID: 46709 RVA: 0x013AA1FC File Offset: 0x013A83FC
			internal static bool pyM9L8tVz2PsF6rvwOxJ()
			{
				return true;
			}

			// Token: 0x0600B676 RID: 46710 RVA: 0x013AA200 File Offset: 0x013A8400
			internal static bool coEdmyttalFNmQYMe68t()
			{
				return false;
			}

			// Token: 0x04009E0F RID: 40463
			internal int $result$46305;

			// Token: 0x04009E10 RID: 40464
			internal CompleteGui $mCompleteGui$46306;

			// Token: 0x04009E11 RID: 40465
			internal GameGui $mGameGui$46307;

			// Token: 0x04009E12 RID: 40466
			internal StoryGui $mStoryGui$46308;

			// Token: 0x04009E13 RID: 40467
			internal ChangeGui $mChangeGui$46309;

			// Token: 0x04009E14 RID: 40468
			internal Hashtable $data$46310;

			// Token: 0x04009E15 RID: 40469
			internal M973_PirateCave11 $self_$46311;
		}
	}

	// Token: 0x02001E85 RID: 7813
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46314 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B677 RID: 46711 RVA: 0x013AA204 File Offset: 0x013A8404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46314(M973_PirateCave11 self_)
		{
			if (23032 - 7813 != 15220)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259118 - 570692 != -311573)
				{
					base..ctor();
					if (76135 - 272831 != -196695)
					{
						this.$self_$46318 = self_;
						if (249061 - 197455 != 51607)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B678 RID: 46712 RVA: 0x013AA29C File Offset: 0x013A849C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave11.$ReturnToTown$46314.$(this.$self_$46318);
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x013AA2AC File Offset: 0x013A84AC
		internal static bool qEKbYRtt5itwqksitbhL()
		{
			return true;
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x013AA2B0 File Offset: 0x013A84B0
		internal static bool VEb795ttpvv1YTmgTKkO()
		{
			return false;
		}

		// Token: 0x04009E16 RID: 40470
		internal M973_PirateCave11 $self_$46318;

		// Token: 0x02001E86 RID: 7814
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B67B RID: 46715 RVA: 0x013AA2B4 File Offset: 0x013A84B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave11 self_)
			{
				if (290832 - 40485 != 250348)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164381 - 73832 != 90550)
					{
						base..ctor();
						if (56715 - 345842 != -289126)
						{
							this.$self_$46317 = self_;
							if (2193 - 71726 == -69533)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B67C RID: 46716 RVA: 0x013AA34C File Offset: 0x013A854C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217954 - 142748 != 75206)
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
						this.$self_$46317.LeaveGame();
						if (65169 - 497617 == -432447)
						{
							continue;
						}
						this.YieldDefault(1);
						if (104258 - 325218 != -220960)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (270576 - 434932 == -164355)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (91533 - 326287 == -234754)
					{
						Game.mStateTime = Time.time;
						if (297024 - 260956 == 36068)
						{
							this.$$switch$8638$46315 = PlayerData.SaveGuild;
							if (147713 - 103395 != 44319)
							{
								if (this.$$switch$8638$46315 == 1)
								{
									if (53656 - 130954 != -77298)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (208620 - 500384 != -291764)
									{
										continue;
									}
								}
								else if (this.$$switch$8638$46315 == 2)
								{
									if (128716 - 566795 == -438078)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (130141 - 430676 != -300535)
									{
										continue;
									}
								}
								else if (this.$$switch$8638$46315 == 3)
								{
									if (252763 - 503159 != -250396)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (152383 - 517885 == -365501)
									{
										continue;
									}
								}
								else if (this.$$switch$8638$46315 == 4)
								{
									if (35210 - 509662 == -474451)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (24235 - 198746 != -174511)
									{
										continue;
									}
								}
								else if (this.$$switch$8638$46315 == 5)
								{
									if (282700 - 355835 == -73134)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (192239 - 418566 != -226327)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (16367 - 571658 != -555291)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (84989 - 582965 != -497976)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (114126 - 57435 == 56692)
									{
										continue;
									}
								}
								this.$mGameGui$46316 = (GameGui)this.$self_$46317.GetComponent(typeof(GameGui));
								if (235651 - 420758 != -185106)
								{
									if (this.$mGameGui$46316)
									{
										if (21946 - 255295 != -233349)
										{
											continue;
										}
										this.$mGameGui$46316.close();
										if (190406 - 233355 != -42949)
										{
											continue;
										}
									}
									this.$self_$46317.SendMessage("fadeOut");
									if (289318 - 307543 != -18224)
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

			// Token: 0x0600B67D RID: 46717 RVA: 0x013AA718 File Offset: 0x013A8918
			internal static bool XUa8sYttVSlxngVS1FPa()
			{
				return true;
			}

			// Token: 0x0600B67E RID: 46718 RVA: 0x013AA71C File Offset: 0x013A891C
			internal static bool qsTXlrtttZ15TVPhP805()
			{
				return false;
			}

			// Token: 0x04009E17 RID: 40471
			internal int $$switch$8638$46315;

			// Token: 0x04009E18 RID: 40472
			internal GameGui $mGameGui$46316;

			// Token: 0x04009E19 RID: 40473
			internal M973_PirateCave11 $self_$46317;
		}
	}

	// Token: 0x02001E87 RID: 7815
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46319 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B67F RID: 46719 RVA: 0x013AA720 File Offset: 0x013A8920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46319(M973_PirateCave11 self_)
		{
			if (265537 - 301686 != -36149)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122643 - 131206 == -8563)
				{
					base..ctor();
					if (170075 - 464994 != -294918)
					{
						this.$self_$46322 = self_;
						if (115290 - 596558 != -481267)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B680 RID: 46720 RVA: 0x013AA7B8 File Offset: 0x013A89B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave11.$ReturnToGuild$46319.$(this.$self_$46322);
		}

		// Token: 0x0600B681 RID: 46721 RVA: 0x013AA7C8 File Offset: 0x013A89C8
		internal static bool mhu8QMttN3JqB0WLDDXW()
		{
			return true;
		}

		// Token: 0x0600B682 RID: 46722 RVA: 0x013AA7CC File Offset: 0x013A89CC
		internal static bool eRNIbYttY3N42K6Hm0qD()
		{
			return false;
		}

		// Token: 0x04009E1A RID: 40474
		internal M973_PirateCave11 $self_$46322;

		// Token: 0x02001E88 RID: 7816
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B683 RID: 46723 RVA: 0x013AA7D0 File Offset: 0x013A89D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave11 self_)
			{
				if (21764 - 150203 != -128439)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291813 - 285837 != 5977)
					{
						base..ctor();
						if (39644 - 459749 == -420105)
						{
							this.$self_$46321 = self_;
							if (148641 - 593807 != -445165)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B684 RID: 46724 RVA: 0x013AA868 File Offset: 0x013A8A68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252989 - 469169 != -216180)
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
						this.$self_$46321.LeaveGame();
						if (271276 - 201714 != 69562)
						{
							continue;
						}
						this.YieldDefault(1);
						if (53759 - 84024 != -30264)
						{
							goto Block_10;
						}
						continue;
					default:
						if (74966 - 586327 == -511360)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (3370 - 583880 != -580509)
					{
						Game.mStateTime = Time.time;
						if (12303 - 19010 != -6706)
						{
							Game.mNextGameCode = 31;
							if (219396 - 181781 != 37616)
							{
								this.$mGameGui$46320 = (GameGui)this.$self_$46321.GetComponent(typeof(GameGui));
								if (15831 - 21882 == -6051)
								{
									if (this.$mGameGui$46320)
									{
										if (193796 - 436796 == -242999)
										{
											continue;
										}
										this.$mGameGui$46320.close();
										if (257730 - 312631 == -54900)
										{
											continue;
										}
									}
									this.$self_$46321.SendMessage("fadeOut");
									if (233564 - 253126 == -19562)
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

			// Token: 0x0600B685 RID: 46725 RVA: 0x013AAA44 File Offset: 0x013A8C44
			internal static bool t3orbLttc3n0i2C7j39V()
			{
				return true;
			}

			// Token: 0x0600B686 RID: 46726 RVA: 0x013AAA48 File Offset: 0x013A8C48
			internal static bool UWj7SAttUYUmftrf4Gi4()
			{
				return false;
			}

			// Token: 0x04009E1B RID: 40475
			internal GameGui $mGameGui$46320;

			// Token: 0x04009E1C RID: 40476
			internal M973_PirateCave11 $self_$46321;
		}
	}

	// Token: 0x02001E89 RID: 7817
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46323 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B687 RID: 46727 RVA: 0x013AAA4C File Offset: 0x013A8C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46323(M973_PirateCave11 self_)
		{
			if (186001 - 30887 != 155115)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (234104 - 369100 != -134995)
				{
					base..ctor();
					if (76283 - 377916 == -301633)
					{
						this.$self_$46326 = self_;
						if (55116 - 407499 == -352383)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x013AAAE4 File Offset: 0x013A8CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave11.$ReturnToCamp$46323.$(this.$self_$46326);
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x013AAAF4 File Offset: 0x013A8CF4
		internal static bool MLZSF5ttT0BThKfTS5ni()
		{
			return true;
		}

		// Token: 0x0600B68A RID: 46730 RVA: 0x013AAAF8 File Offset: 0x013A8CF8
		internal static bool JfcKfett3H7BiJbPnrUq()
		{
			return false;
		}

		// Token: 0x04009E1D RID: 40477
		internal M973_PirateCave11 $self_$46326;

		// Token: 0x02001E8A RID: 7818
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B68B RID: 46731 RVA: 0x013AAAFC File Offset: 0x013A8CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave11 self_)
			{
				if (62757 - 4060 != 58697)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11492 - 189048 == -177556)
					{
						base..ctor();
						if (17680 - 270757 == -253077)
						{
							this.$self_$46325 = self_;
							if (67978 - 318165 != -250186)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B68C RID: 46732 RVA: 0x013AAB94 File Offset: 0x013A8D94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74466 - 108774 != -34307)
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
						this.$self_$46325.LeaveGame();
						if (220346 - 235928 != -15582)
						{
							continue;
						}
						this.YieldDefault(1);
						if (149968 - 583955 != -433987)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (281643 - 348716 != -67073)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (76604 - 71319 == 5285)
					{
						Game.mStateTime = Time.time;
						if (123206 - 518285 == -395079)
						{
							Game.mNextGameCode = 33;
							if (141309 - 18068 == 123241)
							{
								this.$mGameGui$46324 = (GameGui)this.$self_$46325.GetComponent(typeof(GameGui));
								if (2381 - 502846 == -500465)
								{
									if (this.$mGameGui$46324)
									{
										if (227229 - 305358 == -78128)
										{
											continue;
										}
										this.$mGameGui$46324.close();
										if (83725 - 446004 == -362278)
										{
											continue;
										}
									}
									this.$self_$46325.SendMessage("fadeOut");
									if (251229 - 440 != 250790)
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

			// Token: 0x0600B68D RID: 46733 RVA: 0x013AAD70 File Offset: 0x013A8F70
			internal static bool s0ARPYttXhtny8ZC7xvg()
			{
				return true;
			}

			// Token: 0x0600B68E RID: 46734 RVA: 0x013AAD74 File Offset: 0x013A8F74
			internal static bool qITuXpttQtg8dZn8Bd7i()
			{
				return false;
			}

			// Token: 0x04009E1E RID: 40478
			internal GameGui $mGameGui$46324;

			// Token: 0x04009E1F RID: 40479
			internal M973_PirateCave11 $self_$46325;
		}
	}
}
