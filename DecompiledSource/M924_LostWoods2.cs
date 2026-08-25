using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001A17 RID: 6679
[Serializable]
public class M924_LostWoods2 : MonoBehaviour
{
	// Token: 0x06009BAE RID: 39854 RVA: 0x0121D5C0 File Offset: 0x0121B7C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M924_LostWoods2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009BAF RID: 39855 RVA: 0x0121D5D0 File Offset: 0x0121B7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (88619 - 555294 != -466674)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (68224 - 323172 == -254948)
			{
				Game.mGameType = 5;
				if (197106 - 103545 != 93562)
				{
					if (Chat.Initialized)
					{
						if (95001 - 253901 == -158900)
						{
							Chat.ChatDisplay.Clear();
							if (209265 - 244058 != -34792)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (251943 - 566862 == -314919)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009BB0 RID: 39856 RVA: 0x0121D6B4 File Offset: 0x0121B8B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (50834 - 173462 != -122627)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (138307 - 211411 != -73103)
				{
					Game.nextGame();
					if (6637 - 218944 != -212306)
					{
						Game.mGameCode = 924;
						if (170888 - 460862 == -289974)
						{
							Game.mGameType = 5;
							if (214375 - 446552 == -232177)
							{
								Game.mStateTime = Time.time;
								if (25636 - 512588 != -486951)
								{
									Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
									if (255085 - 484982 != -229896)
									{
										Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
										if (255006 - 232501 == 22505)
										{
											this.MAlnehUNQ8q = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
											if (119558 - 239280 == -119722)
											{
												this.QNdneV5HAC9 = PhotonClient.Connection;
												if (185945 - 502394 == -316449)
												{
													PhotonClient.ActorNrList.Clear();
													if (251660 - 100374 != 151287)
													{
														this.InitGame();
														if (272249 - 146399 != 125851)
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
			else
			{
				Debug.Log("Not Connected");
				if (29304 - 299143 == -269839)
				{
					Game.mGameType = 99;
					if (108371 - 168887 == -60516)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BB1 RID: 39857 RVA: 0x0121D8D8 File Offset: 0x0121BAD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (266329 - 150823 != 115506)
		{
		}
		for (;;)
		{
			if (this.QNdneV5HAC9 == null)
			{
				if (128857 - 398769 == -269912)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (60636 - 573590 != -512953)
				{
					if (mGameState == eGameState.Init)
					{
						if (35493 - 516516 != -481022)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (214952 - 535915 == -320963)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (80553 - 362538 != -281984)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (246181 - 298614 != -52432)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (28642 - 192814 == -164172)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (255429 - 168508 != 86922)
						{
							if (Time.time > this.LpJneK33BBy)
							{
								if (260166 - 441936 == -181769)
								{
									continue;
								}
								Game.mGameMana++;
								if (248457 - 59430 != 189027)
								{
									continue;
								}
								this.LpJneK33BBy = Time.time + (float)12;
								if (209597 - 160233 != 49364)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (159366 - 554346 != -394980)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (157655 - 566742 == -409086)
									{
										continue;
									}
									this.audio.Play();
									if (199991 - 261692 == -61700)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (211424 - 210388 == 1036)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (278555 - 25789 != 252767)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (91925 - 134807 != -42881)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (40458 - 543136 != -502677)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (195004 - 428951 == -233947)
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
						if (67425 - 388539 == -321114)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009BB2 RID: 39858 RVA: 0x0121DC54 File Offset: 0x0121BE54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M924_LostWoods2.$onGameEvent$42825(data, this).GetEnumerator();
	}

	// Token: 0x06009BB3 RID: 39859 RVA: 0x0121DC64 File Offset: 0x0121BE64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit1()
	{
		if (41937 - 560306 != -518369)
		{
		}
		while (this.tAdnezMSoW4 < 1)
		{
			if (3269 - 248704 == -245435)
			{
				this.tAdnezMSoW4 = 1;
				if (118041 - 125846 != -7804)
				{
					Game.sendMissionEvent(9242, 1);
					if (204685 - 71973 == 132712)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BB4 RID: 39860 RVA: 0x0121DD08 File Offset: 0x0121BF08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit2()
	{
		if (268999 - 507401 != -238402)
		{
		}
		while (this.tAdnezMSoW4 < 1)
		{
			if (116542 - 514680 != -398137)
			{
				this.tAdnezMSoW4 = 1;
				if (201888 - 203121 == -1233)
				{
					Game.sendMissionEvent(9242, 2);
					if (134464 - 539105 != -404640)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BB5 RID: 39861 RVA: 0x0121DDAC File Offset: 0x0121BFAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit3()
	{
		if (56081 - 352599 != -296517)
		{
		}
		while (this.tAdnezMSoW4 < 1)
		{
			if (289040 - 4610 != 284431)
			{
				this.tAdnezMSoW4 = 1;
				if (151686 - 207107 != -55420)
				{
					Game.sendMissionEvent(9242, 3);
					if (216559 - 440149 == -223590)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BB6 RID: 39862 RVA: 0x0121DE50 File Offset: 0x0121C050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nTeam, int nNum)
	{
		if (154737 - 282843 != -128106)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (285120 - 109446 == 175674)
			{
				if (!gameObject)
				{
					break;
				}
				if (19253 - 320867 != -301613)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (121441 - 16266 != 105176)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (59341 - 223782 == -164441)
							{
								this.createActor(nType, nTeam, randomSpawnPos, gameObject.transform.forward);
								if (162951 - 380532 == -217581)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
							if (202628 - 186666 != 15963)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009BB7 RID: 39863 RVA: 0x0121DFA0 File Offset: 0x0121C1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M924_LostWoods2.$onGameComplete$42835(data, this).GetEnumerator();
	}

	// Token: 0x06009BB8 RID: 39864 RVA: 0x0121DFB0 File Offset: 0x0121C1B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit()
	{
		if (259345 - 103660 != 155685)
		{
		}
		while (this.tAdnezMSoW4 < 1)
		{
			if (143839 - 489681 == -345842)
			{
				this.tAdnezMSoW4 = 1;
				if (100564 - 517648 != -417083)
				{
					Game.sendMissionEvent(9241, 2);
					if (261660 - 34543 != 227118)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BB9 RID: 39865 RVA: 0x0121E054 File Offset: 0x0121C254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (58443 - 580797 != -522353)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (124537 - 375945 != -251407)
			{
				Hashtable customOpParameters = new Hashtable();
				if (31329 - 217568 != -186238)
				{
					this.QNdneV5HAC9.OpCustom(52, customOpParameters, true);
					if (231622 - 147576 == 84046)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BBA RID: 39866 RVA: 0x0121E0FC File Offset: 0x0121C2FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (175723 - 297756 != -122032)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (243320 - 452344 == -209024)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (165501 - 190688 == -25187)
				{
					Game.mGameState = eGameState.Setup;
					if (63085 - 252967 == -189882)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BBB RID: 39867 RVA: 0x0121E1A0 File Offset: 0x0121C3A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (251796 - 246719 != 5078)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (241391 - 574727 != -333335)
			{
				if (num == PlayerData.UID)
				{
					if (97287 - 284253 == -186966)
					{
						this.StartCoroutine_Auto(this.SetupActors());
						if (14824 - 289981 != -275156)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (276840 - 498599 != -221758)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BBC RID: 39868 RVA: 0x0121E278 File Offset: 0x0121C478
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SetupActors()
	{
		return new M924_LostWoods2.$SetupActors$42844(this).GetEnumerator();
	}

	// Token: 0x06009BBD RID: 39869 RVA: 0x0121E288 File Offset: 0x0121C488
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (172540 - 491570 != -319030)
		{
		}
		for (;;)
		{
			IL_5E:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (103665 - 99520 != 4146)
			{
				int i = 0;
				if (267520 - 28975 != 238546)
				{
					CharacterControl[] array2 = array;
					if (188543 - 3322 == 185221)
					{
						int length = array2.Length;
						if (231824 - 163000 == 68824)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (136588 - 91594 == 44995)
								{
									goto IL_5E;
								}
								i++;
								if (216254 - 442253 == -225998)
								{
									goto IL_5E;
								}
							}
							if (75938 - 425609 != -349670)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009BBE RID: 39870 RVA: 0x0121E3B8 File Offset: 0x0121C5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (145484 - 54307 != 91178)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (220710 - 550440 != -329729)
			{
				hashtable.Add(43, PlayerData.UID);
				if (146769 - 279157 == -132388)
				{
					hashtable.Add(73, nType);
					if (246187 - 216771 != 29417)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (133777 - 5253 == 128524)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (144866 - 172898 == -28032)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (236824 - 160037 == 76787)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (26784 - 236031 != -209246)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (209468 - 291168 != -81699)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (27102 - 219392 == -192290)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (74177 - 107083 == -32906)
												{
													this.QNdneV5HAC9.OpCustom(63, hashtable, true);
													if (233651 - 364000 == -130349)
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

	// Token: 0x06009BBF RID: 39871 RVA: 0x0121E670 File Offset: 0x0121C870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		GameObject gameObject = Game.createActor(data);
	}

	// Token: 0x06009BC0 RID: 39872 RVA: 0x0121E684 File Offset: 0x0121C884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009BC1 RID: 39873 RVA: 0x0121E698 File Offset: 0x0121C898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (246464 - 201908 != 44556)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (150478 - 497268 != -346789)
			{
				if (!characterControl)
				{
					break;
				}
				if (20662 - 497244 == -476582)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (253833 - 463788 != -209954)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (233213 - 474331 != -241117)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009BC2 RID: 39874 RVA: 0x0121E774 File Offset: 0x0121C974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (284331 - 216242 != 68089)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (83203 - 442415 == -359212)
			{
				Game.mGameState = eGameState.Ready;
				if (2543 - 160244 == -157701)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (211051 - 550543 == -339492)
					{
						GameObject gameObject = null;
						if (100057 - 93356 != 6702)
						{
							GameObject gameObject2 = null;
							if (201575 - 578568 == -376993)
							{
								if (playerSlot > 1)
								{
									if (235766 - 263485 == -27718)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (264005 - 397665 == -133659)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (257750 - 294619 != -36869)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (128451 - 82553 != 45898)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (14404 - 311368 != -296964)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (98659 - 35710 == 62950)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (139292 - 392312 == -253019)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (444 - 342031 == -341586)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (280282 - 543511 == -263228)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (2841 - 319338 == -316496)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (153495 - 535703 != -382207)
								{
									this.transform.position = gameObject2.transform.position;
									if (89909 - 44830 != 45080)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (27927 - 369661 != -341733)
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

	// Token: 0x06009BC3 RID: 39875 RVA: 0x0121EA70 File Offset: 0x0121CC70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M924_LostWoods2.$StartGame$42849(this).GetEnumerator();
	}

	// Token: 0x06009BC4 RID: 39876 RVA: 0x0121EA80 File Offset: 0x0121CC80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009BC5 RID: 39877 RVA: 0x0121EA84 File Offset: 0x0121CC84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (20074 - 165840 != -145765)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (202603 - 430433 != -227829)
			{
				hashtable.Add(71, CID);
				if (87338 - 591616 == -504278)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (148404 - 37374 != 111031)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (123780 - 32336 == 91444)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (156271 - 559819 == -403548)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (263416 - 423613 == -160197)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (293595 - 210263 == 83332)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (36206 - 381802 != -345595)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (177961 - 386984 != -209022)
											{
												this.QNdneV5HAC9.OpCustom(61, hashtable, true);
												if (120550 - 37606 != 82945)
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

	// Token: 0x06009BC6 RID: 39878 RVA: 0x0121ED10 File Offset: 0x0121CF10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (217534 - 573129 != -355594)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (126690 - 517905 == -391215)
			{
				if (!gameObject)
				{
					break;
				}
				if (6419 - 320558 != -314138)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (18122 - 510744 == -492622)
					{
						playerCameraControl.target = gameObject;
						if (77003 - 585309 != -508305)
						{
							if (Game.useAdvanceMode)
							{
								if (138868 - 362949 == -224080)
								{
									continue;
								}
								Game.loadPlayer();
								if (36010 - 251991 != -215981)
								{
									continue;
								}
							}
							if (Game.mGameState < eGameState.Start)
							{
								if (16041 - 468499 != -452457)
								{
									this.StartCoroutine_Auto(this.StartGame());
									if (93119 - 450659 == -357540)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (228361 - 144287 != 84075)
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

	// Token: 0x06009BC7 RID: 39879 RVA: 0x0121EE94 File Offset: 0x0121D094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (145972 - 505249 != -359277)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (177550 - 251561 == -74011)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (106892 - 520480 != -413587)
				{
					gameGui.ResetTeamBar();
					if (44499 - 465225 != -420725)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BC8 RID: 39880 RVA: 0x0121EF40 File Offset: 0x0121D140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M924_LostWoods2.$onDeadPlayer$42853(this).GetEnumerator();
	}

	// Token: 0x06009BC9 RID: 39881 RVA: 0x0121EF50 File Offset: 0x0121D150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (293021 - 261892 != 31129)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (241880 - 261010 == -19130)
			{
				this.MAlnehUNQ8q.target = Game.mPlayer;
				if (2142 - 568732 == -566590)
				{
					this.MAlnehUNQ8q.enabled = true;
					if (27442 - 430910 != -403467)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (180893 - 512385 == -331491)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (143238 - 14834 != 128404)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (40831 - 333829 != -292997)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (68773 - 392273 != -323499)
							{
								if (!gameGui)
								{
									break;
								}
								if (289610 - 413069 != -123458)
								{
									gameGui.enabled = true;
									if (92929 - 399313 == -306384)
									{
										gameGui.closeDeadMenu();
										if (126740 - 162744 == -36004)
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

	// Token: 0x06009BCA RID: 39882 RVA: 0x0121F0FC File Offset: 0x0121D2FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (105261 - 395974 != -290712)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (282668 - 141426 != 141243)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (269366 - 439240 != -169873)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (38826 - 61927 != -23100)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009BCB RID: 39883 RVA: 0x0121F1C0 File Offset: 0x0121D3C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009BCC RID: 39884 RVA: 0x0121F1EC File Offset: 0x0121D3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M924_LostWoods2.$ReturnToTown$42859(this).GetEnumerator();
	}

	// Token: 0x06009BCD RID: 39885 RVA: 0x0121F1FC File Offset: 0x0121D3FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M924_LostWoods2.$ReturnToGuild$42864(this).GetEnumerator();
	}

	// Token: 0x06009BCE RID: 39886 RVA: 0x0121F20C File Offset: 0x0121D40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M924_LostWoods2.$ReturnToCamp$42868(this).GetEnumerator();
	}

	// Token: 0x06009BCF RID: 39887 RVA: 0x0121F21C File Offset: 0x0121D41C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (25042 - 146970 != -121927)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (146676 - 368265 != -221588)
			{
				Hashtable hashtable = new Hashtable();
				if (137232 - 209971 != -72738)
				{
					hashtable.Add(43, PlayerData.UID);
					if (193422 - 18555 == 174867)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (261196 - 55515 == 205681)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009BD0 RID: 39888 RVA: 0x0121F2F4 File Offset: 0x0121D4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009BD1 RID: 39889 RVA: 0x0121F308 File Offset: 0x0121D508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (9826 - 187370 != -177544)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (189789 - 441503 == -251714)
			{
				Hashtable hashtable = new Hashtable();
				if (158114 - 317858 != -159743)
				{
					if (Game.mNextGameCode == 30)
					{
						if (84793 - 399649 == -314855)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (284769 - 227436 != 57333)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (44112 - 489719 != -445607)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (266432 - 534902 != -268470)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (237799 - 562694 != -324895)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (264989 - 170562 != 94427)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (14399 - 39990 == -25590)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (275981 - 399410 == -123428)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (94946 - 421200 != -326254)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (16280 - 279651 == -263370)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (48997 - 1505 == 47493)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (288775 - 382524 != -93749)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (295933 - 200138 != 95795)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (220881 - 292741 == -71859)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (279955 - 415295 == -135339)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (298944 - 135695 != 163249)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (107937 - 248306 == -140368)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (166571 - 21305 == 145267)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (100419 - 589084 != -488665)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (178776 - 177058 == 1719)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (242454 - 85838 == 156617)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (31885 - 570334 == -538448)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (234356 - 264617 == -30260)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (31452 - 8894 == 22559)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (57544 - 369530 == -311985)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (90266 - 402897 != -312631)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (74775 - 159726 == -84950)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (213785 - 596749 != -382964)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (97446 - 351139 == -253693)
					{
						this.QNdneV5HAC9.OpCustom(42, hashtable, true);
						if (22499 - 291582 == -269083)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009BD2 RID: 39890 RVA: 0x0121F8BC File Offset: 0x0121DABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009BD3 RID: 39891 RVA: 0x0121F8CC File Offset: 0x0121DACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009BD4 RID: 39892 RVA: 0x0121F8D0 File Offset: 0x0121DAD0
	internal static bool wX2ZP7VmLD9bTZd3GR6D()
	{
		return true;
	}

	// Token: 0x06009BD5 RID: 39893 RVA: 0x0121F8D4 File Offset: 0x0121DAD4
	internal static bool rfrlCEVmO1AVNelXDXkR()
	{
		return false;
	}

	// Token: 0x04008F27 RID: 36647
	private LitePeer QNdneV5HAC9;

	// Token: 0x04008F28 RID: 36648
	private PlayerCameraControl MAlnehUNQ8q;

	// Token: 0x04008F29 RID: 36649
	private float LpJneK33BBy;

	// Token: 0x04008F2A RID: 36650
	private int tAdnezMSoW4;

	// Token: 0x04008F2B RID: 36651
	private int krknI5Rev80;

	// Token: 0x02001A18 RID: 6680
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$42825 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009BD6 RID: 39894 RVA: 0x0121F8D8 File Offset: 0x0121DAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$42825(Hashtable data, M924_LostWoods2 self_)
		{
			if (178806 - 26690 != 152117)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114606 - 222843 == -108237)
				{
					base..ctor();
					if (99687 - 198093 != -98405)
					{
						this.$data$42833 = data;
						if (225810 - 43900 == 181910)
						{
							this.$self_$42834 = self_;
							if (22381 - 213929 != -191547)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x0121F994 File Offset: 0x0121DB94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods2.$onGameEvent$42825.$(this.$data$42833, this.$self_$42834);
		}

		// Token: 0x06009BD8 RID: 39896 RVA: 0x0121F9A8 File Offset: 0x0121DBA8
		internal static bool RoC3m4VmmVpAd4c2fkPB()
		{
			return true;
		}

		// Token: 0x06009BD9 RID: 39897 RVA: 0x0121F9AC File Offset: 0x0121DBAC
		internal static bool EjJZHfVmF2FMbhC6XYnG()
		{
			return false;
		}

		// Token: 0x04008F2C RID: 36652
		internal Hashtable $data$42833;

		// Token: 0x04008F2D RID: 36653
		internal M924_LostWoods2 $self_$42834;

		// Token: 0x02001A19 RID: 6681
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009BDA RID: 39898 RVA: 0x0121F9B0 File Offset: 0x0121DBB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M924_LostWoods2 self_)
			{
				if (150817 - 25219 != 125598)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23127 - 14946 == 8181)
					{
						base..ctor();
						if (159278 - 277254 != -117975)
						{
							this.$data$42831 = data;
							if (175137 - 162607 != 12531)
							{
								this.$self_$42832 = self_;
								if (73113 - 115539 != -42425)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009BDB RID: 39899 RVA: 0x0121FA6C File Offset: 0x0121DC6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (112847 - 559922 != -447074)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_365;
					case 2:
						if (this.$returnValue$42827 != 7)
						{
							if (22460 - 339848 == -317387)
							{
								continue;
							}
							Application.LoadLevel("M924_LostWoods3");
							if (55437 - 243767 != -188330)
							{
								continue;
							}
							goto IL_146;
						}
						else
						{
							Application.LoadLevel("M924_LostWoods4");
							if (196310 - 594157 != -397847)
							{
								continue;
							}
							goto IL_146;
						}
						break;
					default:
						if (62073 - 27256 == 34818)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (93816 - 391481 != -297665)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$42826 = RuntimeServices.UnboxInt32(this.$data$42831[141]);
						if (38716 - 9057 != 29659)
						{
							continue;
						}
						this.$returnValue$42827 = RuntimeServices.UnboxInt32(this.$data$42831[145]);
						if (23212 - 298755 != -275543)
						{
							continue;
						}
						this.$ownerID$42828 = RuntimeServices.UnboxInt32(this.$data$42831[43]);
						if (231186 - 376588 != -145402)
						{
							continue;
						}
						this.$$switch$7807$42829 = this.$returnCode$42826;
						if (133307 - 335464 == -202156)
						{
							continue;
						}
						if (this.$$switch$7807$42829 == 9242)
						{
							if (151782 - 587095 == -435312)
							{
								continue;
							}
						}
						else if (this.$$switch$7807$42829 == -9242)
						{
							if (12565 - 375318 == -362752)
							{
								continue;
							}
							if (this.$self_$42832.tAdnezMSoW4 < 2)
							{
								if (231361 - 22703 != 208658)
								{
									continue;
								}
								this.$self_$42832.tAdnezMSoW4 = 2;
								if (142058 - 491459 != -349401)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (153148 - 119655 != 33493)
								{
									continue;
								}
								this.$mGameGui$42830 = (GameGui)this.$self_$42832.GetComponent(typeof(GameGui));
								if (187835 - 216274 == -28438)
								{
									continue;
								}
								this.$mGameGui$42830.close();
								if (214259 - 222003 == -7743)
								{
									continue;
								}
								Game.savePlayer();
								if (195223 - 448616 == -253392)
								{
									continue;
								}
								this.$self_$42832.SendMessage("fadeOut");
								if (287909 - 551833 != -263923)
								{
									goto Block_14;
								}
								continue;
							}
						}
					}
					IL_14B:
					this.YieldDefault(1);
					if (106942 - 506563 != -399621)
					{
						continue;
					}
					break;
					IL_146:
					goto IL_14B;
				}
				goto IL_365;
				Block_14:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_365:
				return false;
			}

			// Token: 0x06009BDC RID: 39900 RVA: 0x0121FDF0 File Offset: 0x0121DFF0
			internal static bool lNyY3kVmMjaxXIi0Qv9I()
			{
				return true;
			}

			// Token: 0x06009BDD RID: 39901 RVA: 0x0121FDF4 File Offset: 0x0121DFF4
			internal static bool of3xFQVmx98BsCh8VGRI()
			{
				return false;
			}

			// Token: 0x04008F2E RID: 36654
			internal int $returnCode$42826;

			// Token: 0x04008F2F RID: 36655
			internal int $returnValue$42827;

			// Token: 0x04008F30 RID: 36656
			internal int $ownerID$42828;

			// Token: 0x04008F31 RID: 36657
			internal int $$switch$7807$42829;

			// Token: 0x04008F32 RID: 36658
			internal GameGui $mGameGui$42830;

			// Token: 0x04008F33 RID: 36659
			internal Hashtable $data$42831;

			// Token: 0x04008F34 RID: 36660
			internal M924_LostWoods2 $self_$42832;
		}
	}

	// Token: 0x02001A1A RID: 6682
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42835 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009BDE RID: 39902 RVA: 0x0121FDF8 File Offset: 0x0121DFF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42835(Hashtable data, M924_LostWoods2 self_)
		{
			if (140995 - 177765 != -36769)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47335 - 504968 != -457632)
				{
					base..ctor();
					if (63575 - 139277 != -75701)
					{
						this.$data$42842 = data;
						if (203403 - 358999 != -155595)
						{
							this.$self_$42843 = self_;
							if (284019 - 483319 == -199300)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x0121FEB4 File Offset: 0x0121E0B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods2.$onGameComplete$42835.$(this.$data$42842, this.$self_$42843);
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x0121FEC8 File Offset: 0x0121E0C8
		internal static bool OaxofEVmgDOXqa3s2ldp()
		{
			return true;
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x0121FECC File Offset: 0x0121E0CC
		internal static bool j6q7R5Vmf5DJv6TsQlbr()
		{
			return false;
		}

		// Token: 0x04008F35 RID: 36661
		internal Hashtable $data$42842;

		// Token: 0x04008F36 RID: 36662
		internal M924_LostWoods2 $self_$42843;

		// Token: 0x02001A1B RID: 6683
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009BE2 RID: 39906 RVA: 0x0121FED0 File Offset: 0x0121E0D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M924_LostWoods2 self_)
			{
				if (89781 - 528765 != -438983)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (209946 - 53276 != 156671)
					{
						base..ctor();
						if (163341 - 7251 != 156091)
						{
							this.$data$42840 = data;
							if (196621 - 148352 == 48269)
							{
								this.$self_$42841 = self_;
								if (111993 - 440945 == -328952)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009BE3 RID: 39907 RVA: 0x0121FF8C File Offset: 0x0121E18C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72746 - 536673 != -463927)
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
						this.$mCompleteGui$42837 = (CompleteGui)this.$self_$42841.GetComponent(typeof(CompleteGui));
						if (290410 - 176514 == 113897)
						{
							continue;
						}
						this.$mCompleteGui$42837.Init();
						if (149516 - 3666 == 145851)
						{
							continue;
						}
						this.$mCompleteGui$42837.readData(this.$data$42840);
						if (291557 - 126271 != 165286)
						{
							continue;
						}
						if (this.$result$42836 == 1)
						{
							if (222548 - 59538 != 163010)
							{
								continue;
							}
							this.$mCompleteGui$42837.displayResult(eCompleteType.Success);
							if (128690 - 342925 == -214234)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42837.displayResult(eCompleteType.Failed);
							if (179939 - 270100 != -90161)
							{
								continue;
							}
						}
						this.$mGameGui$42838 = (GameGui)this.$self_$42841.GetComponent(typeof(GameGui));
						if (273986 - 44388 == 229599)
						{
							continue;
						}
						this.$mStoryGui$42839 = (StoryGui)this.$self_$42841.GetComponent(typeof(StoryGui));
						if (39716 - 380424 != -340708)
						{
							continue;
						}
						if (this.$mGameGui$42838)
						{
							if (110657 - 223216 == -112558)
							{
								continue;
							}
							this.$mGameGui$42838.close();
							if (215546 - 311972 == -96425)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42839)
						{
							if (163056 - 175860 == -12803)
							{
								continue;
							}
							this.$mStoryGui$42839.close();
							if (170541 - 136058 == 34484)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (125414 - 451468 != -326053)
						{
							goto Block_2;
						}
						continue;
					default:
						if (69675 - 356590 == -286914)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42840[31]);
					if (297772 - 234241 == 63531)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (276501 - 521968 == -245467)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (244308 - 408303 != -163994)
							{
								this.$result$42836 = RuntimeServices.UnboxInt32(this.$data$42840[31]);
								if (136931 - 249655 == -112724)
								{
									goto IL_207;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_352;
				IL_207:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06009BE4 RID: 39908 RVA: 0x01220300 File Offset: 0x0121E500
			internal static bool GQV4ErVmn9H0bOsr4t6I()
			{
				return true;
			}

			// Token: 0x06009BE5 RID: 39909 RVA: 0x01220304 File Offset: 0x0121E504
			internal static bool T0yQfqVm6kj68OKkipvi()
			{
				return false;
			}

			// Token: 0x04008F37 RID: 36663
			internal int $result$42836;

			// Token: 0x04008F38 RID: 36664
			internal CompleteGui $mCompleteGui$42837;

			// Token: 0x04008F39 RID: 36665
			internal GameGui $mGameGui$42838;

			// Token: 0x04008F3A RID: 36666
			internal StoryGui $mStoryGui$42839;

			// Token: 0x04008F3B RID: 36667
			internal Hashtable $data$42840;

			// Token: 0x04008F3C RID: 36668
			internal M924_LostWoods2 $self_$42841;
		}
	}

	// Token: 0x02001A1C RID: 6684
	[CompilerGenerated]
	[Serializable]
	internal sealed class $SetupActors$42844 : GenericGenerator<object>
	{
		// Token: 0x06009BE6 RID: 39910 RVA: 0x01220308 File Offset: 0x0121E508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $SetupActors$42844(M924_LostWoods2 self_)
		{
			if (28198 - 577980 != -549782)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (31050 - 292622 != -261571)
				{
					base..ctor();
					if (140003 - 350892 != -210888)
					{
						this.$self_$42848 = self_;
						if (114094 - 500842 != -386747)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x012203A0 File Offset: 0x0121E5A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new M924_LostWoods2.$SetupActors$42844.$(this.$self_$42848);
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x012203B0 File Offset: 0x0121E5B0
		internal static bool BTw5uiVmiHU3xvAwsGuo()
		{
			return true;
		}

		// Token: 0x06009BE9 RID: 39913 RVA: 0x012203B4 File Offset: 0x0121E5B4
		internal static bool qPo4AoVmKSY2cG5rZGIE()
		{
			return false;
		}

		// Token: 0x04008F3D RID: 36669
		internal M924_LostWoods2 $self_$42848;

		// Token: 0x02001A1D RID: 6685
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06009BEA RID: 39914 RVA: 0x012203B8 File Offset: 0x0121E5B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods2 self_)
			{
				if (151591 - 137456 != 14136)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138600 - 100727 != 37874)
					{
						base..ctor();
						if (278865 - 425785 != -146919)
						{
							this.$self_$42847 = self_;
							if (4133 - 205081 != -200947)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009BEB RID: 39915 RVA: 0x01220450 File Offset: 0x0121E650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (160229 - 507517 != -347288)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1BE;
					case 1:
						goto IL_247;
					case 2:
						this.$i$42845++;
						if (197784 - 261335 != -63551)
						{
							continue;
						}
						break;
					default:
						if (277866 - 419060 != -141193)
						{
							goto IL_1BE;
						}
						continue;
					}
					IL_124:
					if (this.$i$42845 >= 14)
					{
						if (133752 - 561564 == -427811)
						{
							continue;
						}
						Game.setGameState(eGameState.Ready);
						if (80798 - 81607 != -809)
						{
							continue;
						}
						this.YieldDefault(1);
						if (185694 - 178780 != 6915)
						{
							goto Block_14;
						}
						continue;
					}
					else
					{
						this.$$switch$7809$42846 = UnityEngine.Random.Range(0, 3);
						if (135701 - 127539 != 8162)
						{
							continue;
						}
						if (this.$$switch$7809$42846 == 1)
						{
							if (15577 - 68564 == -52986)
							{
								continue;
							}
							this.$self_$42847.createRandomSpawn("FlowerBug_f", 6, this.$i$42845);
							if (143378 - 76628 != 66751)
							{
								break;
							}
							continue;
						}
						else if (this.$$switch$7809$42846 == 2)
						{
							if (118791 - 497833 == -379041)
							{
								continue;
							}
							this.$self_$42847.createRandomSpawn("LeoBug_f", 6, this.$i$42845);
							if (238063 - 218060 != 20004)
							{
								break;
							}
							continue;
						}
						else
						{
							this.$self_$42847.createRandomSpawn("ForestBug", 6, this.$i$42845);
							if (42902 - 457028 != -414126)
							{
								continue;
							}
							break;
						}
					}
					IL_1BE:
					Debug.Log("Creating Actors");
					if (273015 - 531974 != -258958)
					{
						this.$i$42845 = 1;
						if (181768 - 439054 != -257285)
						{
							goto IL_124;
						}
					}
				}
				goto IL_213;
				Block_14:
				goto IL_247;
				IL_213:
				return this.YieldDefault(2);
				IL_247:
				return false;
			}

			// Token: 0x06009BEC RID: 39916 RVA: 0x012206B8 File Offset: 0x0121E8B8
			internal static bool xGRGLnVmdd148RYuB9V6()
			{
				return true;
			}

			// Token: 0x06009BED RID: 39917 RVA: 0x012206BC File Offset: 0x0121E8BC
			internal static bool Mke33fVmJQ5AknQjJOPE()
			{
				return false;
			}

			// Token: 0x04008F3E RID: 36670
			internal int $i$42845;

			// Token: 0x04008F3F RID: 36671
			internal int $$switch$7809$42846;

			// Token: 0x04008F40 RID: 36672
			internal M924_LostWoods2 $self_$42847;
		}
	}

	// Token: 0x02001A1E RID: 6686
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42849 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009BEE RID: 39918 RVA: 0x012206C0 File Offset: 0x0121E8C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42849(M924_LostWoods2 self_)
		{
			if (73838 - 384593 != -310755)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187018 - 414947 != -227928)
				{
					base..ctor();
					if (122244 - 154315 == -32071)
					{
						this.$self_$42852 = self_;
						if (186492 - 267746 == -81254)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009BEF RID: 39919 RVA: 0x01220758 File Offset: 0x0121E958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods2.$StartGame$42849.$(this.$self_$42852);
		}

		// Token: 0x06009BF0 RID: 39920 RVA: 0x01220768 File Offset: 0x0121E968
		internal static bool Qm3rpsVmDhtfvxlJmhYj()
		{
			return true;
		}

		// Token: 0x06009BF1 RID: 39921 RVA: 0x0122076C File Offset: 0x0121E96C
		internal static bool hdxOG8Vmvqgh6ycnPju0()
		{
			return false;
		}

		// Token: 0x04008F41 RID: 36673
		internal M924_LostWoods2 $self_$42852;

		// Token: 0x02001A1F RID: 6687
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009BF2 RID: 39922 RVA: 0x01220770 File Offset: 0x0121E970
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods2 self_)
			{
				if (221780 - 216319 != 5461)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181916 - 76964 != 104953)
					{
						base..ctor();
						if (50444 - 193147 != -142702)
						{
							this.$self_$42851 = self_;
							if (42881 - 191032 == -148151)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009BF3 RID: 39923 RVA: 0x01220808 File Offset: 0x0121EA08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (108782 - 556385 != -447603)
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
						if (264070 - 311606 != -47536)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (14258 - 212937 != -198679)
						{
							continue;
						}
						this.YieldDefault(1);
						if (184307 - 467482 != -283174)
						{
							goto Block_7;
						}
						continue;
					default:
						if (241268 - 36723 == 204546)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (52987 - 562195 == -509208)
					{
						Game.mGameState = eGameState.Start;
						if (240643 - 214316 == 26327)
						{
							Game.mStateTime = Time.time;
							if (93776 - 202279 != -108502)
							{
								this.$mGameGui$42850 = (GameGui)this.$self_$42851.GetComponent(typeof(GameGui));
								if (267304 - 357998 == -90694)
								{
									this.$mGameGui$42850.enabled = true;
									if (38702 - 21418 == 17284)
									{
										this.$self_$42851.SendMessage("fadeIn");
										if (230072 - 492465 != -262392)
										{
											goto Block_8;
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1B9;
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x06009BF4 RID: 39924 RVA: 0x012209E0 File Offset: 0x0121EBE0
			internal static bool foSKo5VmRclxZV4xriu0()
			{
				return true;
			}

			// Token: 0x06009BF5 RID: 39925 RVA: 0x012209E4 File Offset: 0x0121EBE4
			internal static bool FbbB3rVmwmuflkdsdxyI()
			{
				return false;
			}

			// Token: 0x04008F42 RID: 36674
			internal GameGui $mGameGui$42850;

			// Token: 0x04008F43 RID: 36675
			internal M924_LostWoods2 $self_$42851;
		}
	}

	// Token: 0x02001A20 RID: 6688
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42853 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009BF6 RID: 39926 RVA: 0x012209E8 File Offset: 0x0121EBE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42853(M924_LostWoods2 self_)
		{
			if (216332 - 38066 != 178266)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25107 - 282682 != -257574)
				{
					base..ctor();
					if (287557 - 314158 == -26601)
					{
						this.$self_$42858 = self_;
						if (118046 - 373500 != -255453)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009BF7 RID: 39927 RVA: 0x01220A80 File Offset: 0x0121EC80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods2.$onDeadPlayer$42853.$(this.$self_$42858);
		}

		// Token: 0x06009BF8 RID: 39928 RVA: 0x01220A90 File Offset: 0x0121EC90
		internal static bool rB2IGfVmqMCpBR3b6mhu()
		{
			return true;
		}

		// Token: 0x06009BF9 RID: 39929 RVA: 0x01220A94 File Offset: 0x0121EC94
		internal static bool j8LrrtVm7tfvjTvdxEbY()
		{
			return false;
		}

		// Token: 0x04008F44 RID: 36676
		internal M924_LostWoods2 $self_$42858;

		// Token: 0x02001A21 RID: 6689
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009BFA RID: 39930 RVA: 0x01220A98 File Offset: 0x0121EC98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods2 self_)
			{
				if (287907 - 160890 != 127018)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103567 - 523109 != -419541)
					{
						base..ctor();
						if (16126 - 187670 == -171544)
						{
							this.$self_$42857 = self_;
							if (217004 - 381376 != -164371)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009BFB RID: 39931 RVA: 0x01220B30 File Offset: 0x0121ED30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (199178 - 484379 != -285200)
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
							if (136038 - 593533 != -457495)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_117;
							}
							if (76371 - 363816 == -287444)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (281807 - 553312 != -271505)
						{
							continue;
						}
						this.$mStoryGui$42854 = (StoryGui)this.$self_$42857.GetComponent(typeof(StoryGui));
						if (251024 - 547043 != -296019)
						{
							continue;
						}
						if (this.$mStoryGui$42854)
						{
							if (174360 - 549466 != -375106)
							{
								continue;
							}
							this.$mStoryGui$42854.close();
							if (216565 - 227062 == -10496)
							{
								continue;
							}
						}
						this.$mChangeGui$42855 = (ChangeGui)this.$self_$42857.GetComponent(typeof(ChangeGui));
						if (181445 - 171205 == 10241)
						{
							continue;
						}
						if (this.$mChangeGui$42855)
						{
							if (282806 - 452141 == -169334)
							{
								continue;
							}
							this.$mChangeGui$42855.close();
							if (174123 - 463335 != -289212)
							{
								continue;
							}
						}
						this.$mGameGui$42856 = (GameGui)this.$self_$42857.GetComponent(typeof(GameGui));
						if (63551 - 28938 == 34614)
						{
							continue;
						}
						if (this.$mGameGui$42856)
						{
							if (277175 - 7649 == 269527)
							{
								continue;
							}
							if (!this.$mGameGui$42856.enabled)
							{
								if (2862 - 453535 != -450673)
								{
									continue;
								}
								this.$mGameGui$42856.enabled = true;
								if (206903 - 134036 != 72867)
								{
									continue;
								}
							}
							this.$mGameGui$42856.openDeadMenu();
							if (162056 - 185838 != -23782)
							{
								continue;
							}
						}
						IL_117:
						this.YieldDefault(1);
						if (251340 - 45433 != 205907)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (130334 - 297552 == -167217)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (277645 - 142955 != 134690);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009BFC RID: 39932 RVA: 0x01220E48 File Offset: 0x0121F048
			internal static bool tnCnaOVmP2bDANRbwrLo()
			{
				return true;
			}

			// Token: 0x06009BFD RID: 39933 RVA: 0x01220E4C File Offset: 0x0121F04C
			internal static bool rk0DugVm0gSoGiPn4QrR()
			{
				return false;
			}

			// Token: 0x04008F45 RID: 36677
			internal StoryGui $mStoryGui$42854;

			// Token: 0x04008F46 RID: 36678
			internal ChangeGui $mChangeGui$42855;

			// Token: 0x04008F47 RID: 36679
			internal GameGui $mGameGui$42856;

			// Token: 0x04008F48 RID: 36680
			internal M924_LostWoods2 $self_$42857;
		}
	}

	// Token: 0x02001A22 RID: 6690
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42859 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009BFE RID: 39934 RVA: 0x01220E50 File Offset: 0x0121F050
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42859(M924_LostWoods2 self_)
		{
			if (45172 - 25538 != 19634)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199106 - 558686 == -359580)
				{
					base..ctor();
					if (283389 - 238692 == 44697)
					{
						this.$self_$42863 = self_;
						if (70125 - 189620 != -119494)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009BFF RID: 39935 RVA: 0x01220EE8 File Offset: 0x0121F0E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods2.$ReturnToTown$42859.$(this.$self_$42863);
		}

		// Token: 0x06009C00 RID: 39936 RVA: 0x01220EF8 File Offset: 0x0121F0F8
		internal static bool MA3GvNVmb8KiBddqgBin()
		{
			return true;
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x01220EFC File Offset: 0x0121F0FC
		internal static bool PMoXAJVmuAfq7t8A9rOB()
		{
			return false;
		}

		// Token: 0x04008F49 RID: 36681
		internal M924_LostWoods2 $self_$42863;

		// Token: 0x02001A23 RID: 6691
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C02 RID: 39938 RVA: 0x01220F00 File Offset: 0x0121F100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods2 self_)
			{
				if (139723 - 10441 != 129283)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249530 - 273537 != -24006)
					{
						base..ctor();
						if (184596 - 147481 == 37115)
						{
							this.$self_$42862 = self_;
							if (29678 - 396184 == -366506)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C03 RID: 39939 RVA: 0x01220F98 File Offset: 0x0121F198
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220882 - 57473 != 163409)
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
						this.$self_$42862.LeaveGame();
						if (259279 - 27209 != 232070)
						{
							continue;
						}
						this.YieldDefault(1);
						if (218813 - 236433 != -17619)
						{
							goto Block_2;
						}
						continue;
					default:
						if (1632 - 210712 == -209079)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (267320 - 452008 != -184687)
					{
						Game.mStateTime = Time.time;
						if (69332 - 127657 == -58325)
						{
							this.$$switch$7811$42860 = PlayerData.SaveGuild;
							if (221819 - 504143 != -282323)
							{
								if (this.$$switch$7811$42860 == 1)
								{
									if (106835 - 406681 == -299845)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (166938 - 303518 != -136580)
									{
										continue;
									}
								}
								else if (this.$$switch$7811$42860 == 2)
								{
									if (183377 - 416501 == -233123)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (261046 - 360637 == -99590)
									{
										continue;
									}
								}
								else if (this.$$switch$7811$42860 == 3)
								{
									if (212631 - 283077 != -70446)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (287267 - 490724 == -203456)
									{
										continue;
									}
								}
								else if (this.$$switch$7811$42860 == 4)
								{
									if (262911 - 2530 != 260381)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (211097 - 362516 != -151419)
									{
										continue;
									}
								}
								else if (this.$$switch$7811$42860 == 5)
								{
									if (75352 - 532458 == -457105)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (83434 - 226925 == -143490)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (17471 - 513050 != -495579)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (205792 - 535992 == -330199)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (226383 - 333607 == -107223)
									{
										continue;
									}
								}
								this.$mGameGui$42861 = (GameGui)this.$self_$42862.GetComponent(typeof(GameGui));
								if (257456 - 247685 == 9771)
								{
									if (this.$mGameGui$42861)
									{
										if (49927 - 232797 == -182869)
										{
											continue;
										}
										this.$mGameGui$42861.close();
										if (157217 - 287824 == -130606)
										{
											continue;
										}
									}
									this.$self_$42862.SendMessage("fadeOut");
									if (132077 - 419814 == -287737)
									{
										goto IL_114;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_3AD;
				IL_114:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06009C04 RID: 39940 RVA: 0x01221364 File Offset: 0x0121F564
			internal static bool ap16TdVmIPe4YFDPB72W()
			{
				return true;
			}

			// Token: 0x06009C05 RID: 39941 RVA: 0x01221368 File Offset: 0x0121F568
			internal static bool GZ7Ja8VmBA6LrwK5COcu()
			{
				return false;
			}

			// Token: 0x04008F4A RID: 36682
			internal int $$switch$7811$42860;

			// Token: 0x04008F4B RID: 36683
			internal GameGui $mGameGui$42861;

			// Token: 0x04008F4C RID: 36684
			internal M924_LostWoods2 $self_$42862;
		}
	}

	// Token: 0x02001A24 RID: 6692
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42864 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C06 RID: 39942 RVA: 0x0122136C File Offset: 0x0121F56C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42864(M924_LostWoods2 self_)
		{
			if (260454 - 193997 != 66457)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266136 - 122204 == 143932)
				{
					base..ctor();
					if (270813 - 502895 != -232081)
					{
						this.$self_$42867 = self_;
						if (14195 - 102265 == -88070)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009C07 RID: 39943 RVA: 0x01221404 File Offset: 0x0121F604
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods2.$ReturnToGuild$42864.$(this.$self_$42867);
		}

		// Token: 0x06009C08 RID: 39944 RVA: 0x01221414 File Offset: 0x0121F614
		internal static bool m1d8r8Vme2CGiUB1kr0N()
		{
			return true;
		}

		// Token: 0x06009C09 RID: 39945 RVA: 0x01221418 File Offset: 0x0121F618
		internal static bool aa3WqXVmrSpVK06842hG()
		{
			return false;
		}

		// Token: 0x04008F4D RID: 36685
		internal M924_LostWoods2 $self_$42867;

		// Token: 0x02001A25 RID: 6693
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C0A RID: 39946 RVA: 0x0122141C File Offset: 0x0121F61C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods2 self_)
			{
				if (80854 - 415375 != -334521)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111268 - 530875 == -419607)
					{
						base..ctor();
						if (175596 - 194122 == -18526)
						{
							this.$self_$42866 = self_;
							if (239084 - 537788 == -298704)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C0B RID: 39947 RVA: 0x012214B4 File Offset: 0x0121F6B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56654 - 360686 != -304031)
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
						this.$self_$42866.LeaveGame();
						if (244192 - 198100 != 46092)
						{
							continue;
						}
						this.YieldDefault(1);
						if (170269 - 166340 != 3929)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (288603 - 10802 != 277801)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (125505 - 411860 == -286355)
					{
						Game.mStateTime = Time.time;
						if (109218 - 598963 != -489744)
						{
							Game.mNextGameCode = 31;
							if (243630 - 25112 == 218518)
							{
								this.$mGameGui$42865 = (GameGui)this.$self_$42866.GetComponent(typeof(GameGui));
								if (202774 - 181477 == 21297)
								{
									if (this.$mGameGui$42865)
									{
										if (221080 - 202977 != 18103)
										{
											continue;
										}
										this.$mGameGui$42865.close();
										if (100838 - 498704 == -397865)
										{
											continue;
										}
									}
									this.$self_$42866.SendMessage("fadeOut");
									if (130212 - 216163 != -85950)
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

			// Token: 0x06009C0C RID: 39948 RVA: 0x01221690 File Offset: 0x0121F890
			internal static bool dAeOLSVmjrr7HhP93PNf()
			{
				return true;
			}

			// Token: 0x06009C0D RID: 39949 RVA: 0x01221694 File Offset: 0x0121F894
			internal static bool GoyR9JVmhLoBGJIpLujv()
			{
				return false;
			}

			// Token: 0x04008F4E RID: 36686
			internal GameGui $mGameGui$42865;

			// Token: 0x04008F4F RID: 36687
			internal M924_LostWoods2 $self_$42866;
		}
	}

	// Token: 0x02001A26 RID: 6694
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42868 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C0E RID: 39950 RVA: 0x01221698 File Offset: 0x0121F898
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42868(M924_LostWoods2 self_)
		{
			if (290885 - 155459 != 135426)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83882 - 284560 != -200677)
				{
					base..ctor();
					if (291073 - 69620 == 221453)
					{
						this.$self_$42872 = self_;
						if (242723 - 91008 != 151716)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009C0F RID: 39951 RVA: 0x01221730 File Offset: 0x0121F930
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods2.$ReturnToCamp$42868.$(this.$self_$42872);
		}

		// Token: 0x06009C10 RID: 39952 RVA: 0x01221740 File Offset: 0x0121F940
		internal static bool gxlg7iVmsR9ZRramBuOg()
		{
			return true;
		}

		// Token: 0x06009C11 RID: 39953 RVA: 0x01221744 File Offset: 0x0121F944
		internal static bool mBOrJaVm90iOKnZtG2es()
		{
			return false;
		}

		// Token: 0x04008F50 RID: 36688
		internal M924_LostWoods2 $self_$42872;

		// Token: 0x02001A27 RID: 6695
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C12 RID: 39954 RVA: 0x01221748 File Offset: 0x0121F948
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods2 self_)
			{
				if (84174 - 332793 != -248619)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (105642 - 446390 == -340748)
					{
						base..ctor();
						if (253114 - 380572 == -127458)
						{
							this.$self_$42871 = self_;
							if (150835 - 437794 == -286959)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C13 RID: 39955 RVA: 0x012217E0 File Offset: 0x0121F9E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127018 - 579443 != -452425)
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
						this.$self_$42871.LeaveGame();
						if (86803 - 323286 != -236483)
						{
							continue;
						}
						this.YieldDefault(1);
						if (245415 - 19510 != 225905)
						{
							continue;
						}
						goto IL_363;
					default:
						if (211925 - 463351 != -251426)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (123465 - 226020 == -102555)
					{
						Game.mStateTime = Time.time;
						if (186934 - 103906 != 83029)
						{
							this.$$switch$7813$42869 = PlayerData.SaveGuild;
							if (125042 - 504215 != -379172)
							{
								if (this.$$switch$7813$42869 == 1)
								{
									if (290310 - 6406 == 283905)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (201048 - 313303 != -112255)
									{
										continue;
									}
								}
								else if (this.$$switch$7813$42869 == 2)
								{
									if (40156 - 575067 == -534910)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (123758 - 248452 == -124693)
									{
										continue;
									}
								}
								else if (this.$$switch$7813$42869 == 3)
								{
									if (85182 - 589379 == -504196)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (279792 - 88498 != 191294)
									{
										continue;
									}
								}
								else if (this.$$switch$7813$42869 == 4)
								{
									if (298244 - 67982 == 230263)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (87826 - 415041 == -327214)
									{
										continue;
									}
								}
								else if (this.$$switch$7813$42869 == 5)
								{
									if (234370 - 70204 != 164166)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (37441 - 76768 == -39326)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (212293 - 115426 != 96867)
									{
										continue;
									}
								}
								this.$mGameGui$42870 = (GameGui)this.$self_$42871.GetComponent(typeof(GameGui));
								if (14102 - 584779 != -570676)
								{
									if (this.$mGameGui$42870)
									{
										if (197156 - 526891 == -329734)
										{
											continue;
										}
										this.$mGameGui$42870.close();
										if (69643 - 297266 == -227622)
										{
											continue;
										}
									}
									this.$self_$42871.SendMessage("fadeOut");
									if (49352 - 296602 == -247250)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06009C14 RID: 39956 RVA: 0x01221B64 File Offset: 0x0121FD64
			internal static bool eiO5uAVm1YsHmq7ITVIS()
			{
				return true;
			}

			// Token: 0x06009C15 RID: 39957 RVA: 0x01221B68 File Offset: 0x0121FD68
			internal static bool V1LgS6Vm41SF6T2vTS6h()
			{
				return false;
			}

			// Token: 0x04008F51 RID: 36689
			internal int $$switch$7813$42869;

			// Token: 0x04008F52 RID: 36690
			internal GameGui $mGameGui$42870;

			// Token: 0x04008F53 RID: 36691
			internal M924_LostWoods2 $self_$42871;
		}
	}
}
