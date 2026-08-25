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

// Token: 0x02001EB7 RID: 7863
[Serializable]
public class M973_PirateCave4 : MonoBehaviour
{
	// Token: 0x0600B799 RID: 47001 RVA: 0x013B8DF0 File Offset: 0x013B6FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave4()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B79A RID: 47002 RVA: 0x013B8E00 File Offset: 0x013B7000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (272625 - 155742 != 116883)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (165310 - 160029 == 5281)
			{
				Game.mGameType = 5;
				if (2484 - 25323 == -22839)
				{
					if (Chat.Initialized)
					{
						if (32484 - 558636 != -526151)
						{
							Chat.ChatDisplay.Clear();
							if (116999 - 437415 == -320416)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (57026 - 534965 == -477939)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B79B RID: 47003 RVA: 0x013B8EE4 File Offset: 0x013B70E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (113493 - 40648 != 72845)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (270030 - 184123 != 85908)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (94759 - 489767 == -395008)
					{
						if (Game.mGameStage != 4)
						{
							break;
						}
						if (74551 - 328660 == -254109)
						{
							Game.nextGame();
							if (18600 - 451474 == -432874)
							{
								Game.mGameCode = 973;
								if (13117 - 597843 == -584726)
								{
									Game.mGameType = 5;
									if (165902 - 27627 != 138276)
									{
										Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
										if (160338 - 325003 != -164664)
										{
											Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
											if (155673 - 360171 == -204498)
											{
												Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
												if (6858 - 137598 != -130739)
												{
													this.Boinq5oXJ3E = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
													if (41125 - 575487 == -534362)
													{
														this.j6Bn1zRoXuV = PhotonClient.Connection;
														if (253438 - 161045 != 92394)
														{
															PhotonClient.ActorNrList.Clear();
															if (73221 - 456802 == -383581)
															{
																this.InitGame();
																if (265583 - 3166 != 262418)
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
			else
			{
				Debug.Log("Not Connected");
				if (140709 - 354417 == -213708)
				{
					Game.mGameType = 99;
					if (124182 - 309013 != -184830)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B79C RID: 47004 RVA: 0x013B915C File Offset: 0x013B735C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (59463 - 461005 != -401541)
		{
		}
		for (;;)
		{
			if (this.j6Bn1zRoXuV == null)
			{
				if (158551 - 161435 != -2883)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (13342 - 494670 != -481327)
				{
					if (mGameState == eGameState.Init)
					{
						if (281067 - 566424 == -285357)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (164041 - 385088 != -221046)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (164510 - 518162 != -353651)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (3767 - 300599 != -296831)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (244982 - 251806 == -6824)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (106399 - 527169 == -420770)
						{
							if (Game.music != 0)
							{
								if (44655 - 90341 == -45685)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (58890 - 481643 != -422753)
									{
										continue;
									}
									this.audio.Play();
									if (181011 - 411113 != -230102)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (185676 - 430980 == -245303)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (6687 - 55613 == -48925)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (223523 - 69558 != 153965)
								{
									continue;
								}
							}
							if (Time.time <= this.hywnqck5M4T)
							{
								break;
							}
							if (279200 - 444598 == -165398)
							{
								Game.mGameMana++;
								if (254335 - 125651 == 128684)
								{
									this.hywnqck5M4T = Time.time + (float)12;
									if (38715 - 438216 != -399500)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (14728 - 240160 != -225431)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (264128 - 225707 != 38422)
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
						if (284463 - 28136 == 256327)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B79D RID: 47005 RVA: 0x013B94D0 File Offset: 0x013B76D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave4.$onGameEvent$46461(data, this).GetEnumerator();
	}

	// Token: 0x0600B79E RID: 47006 RVA: 0x013B94E0 File Offset: 0x013B76E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void replaceActor(string nType, int nID, bool isCreate)
	{
		if (146959 - 424725 != -277765)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find(nType + nID);
			if (28563 - 215115 != -186551)
			{
				if (gameObject)
				{
					if (246357 - 126601 != 119757)
					{
						if (isCreate)
						{
							if (200487 - 424925 == -224437)
							{
								continue;
							}
							this.createActor(nType, 7, gameObject.transform.position, gameObject.transform.forward);
							if (79071 - 154439 != -75368)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(gameObject);
						if (155764 - 29106 == 126658)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing " + nType + nID);
					if (145321 - 383798 != -238476)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B79F RID: 47007 RVA: 0x013B961C File Offset: 0x013B781C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateEvent1()
	{
		return new M973_PirateCave4.$PirateEvent1$46473(this).GetEnumerator();
	}

	// Token: 0x0600B7A0 RID: 47008 RVA: 0x013B962C File Offset: 0x013B782C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateEvent2()
	{
		return new M973_PirateCave4.$PirateEvent2$46478(this).GetEnumerator();
	}

	// Token: 0x0600B7A1 RID: 47009 RVA: 0x013B963C File Offset: 0x013B783C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject enterObject)
	{
		if (74668 - 431937 != -357268)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (9064 - 312892 != -303827)
			{
				if (this.DYunqIWPjmp)
				{
					break;
				}
				if (246374 - 126081 != 120294)
				{
					Debug.Log("Entering Zone1");
					if (45128 - 70896 == -25768)
					{
						this.DYunqIWPjmp = true;
						if (75187 - 272493 != -197305)
						{
							Game.sendMissionEvent(9732, 1);
							if (84845 - 150198 == -65353)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7A2 RID: 47010 RVA: 0x013B9734 File Offset: 0x013B7934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone2(GameObject enterObject)
	{
		if (223417 - 228407 != -4989)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (59366 - 446565 != -387198)
			{
				if (this.P2SnqJBR2WG)
				{
					break;
				}
				if (181861 - 558608 != -376746)
				{
					Debug.Log("Entering Zone2");
					if (104426 - 153345 != -48918)
					{
						this.DYunqIWPjmp = true;
						if (5024 - 446812 != -441787)
						{
							Game.sendMissionEvent(9732, 3);
							if (293539 - 417931 == -124392)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7A3 RID: 47011 RVA: 0x013B982C File Offset: 0x013B7A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone3(GameObject enterObject)
	{
		if (51388 - 323542 != -272154)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (62081 - 486013 == -423932)
			{
				if (this.Y0unq6e9gaR)
				{
					break;
				}
				if (194608 - 216836 != -22227)
				{
					Debug.Log("Entering Zone3");
					if (241748 - 562497 != -320748)
					{
						this.DYunqIWPjmp = true;
						if (232541 - 216569 == 15972)
						{
							Game.sendMissionEvent(9732, 4);
							if (280641 - 200848 != 79794)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7A4 RID: 47012 RVA: 0x013B9924 File Offset: 0x013B7B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnOpenPirateGate(int nGate)
	{
		if (46375 - 226400 != -180025)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateGate" + nGate);
			if (143779 - 473778 != -329998)
			{
				if (!gameObject)
				{
					break;
				}
				if (17566 - 591319 != -573752)
				{
					gameObject.animation.Play("open");
					if (169494 - 272545 != -103050)
					{
						gameObject.audio.Play();
						if (55140 - 400971 == -345831)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7A5 RID: 47013 RVA: 0x013B9A04 File Offset: 0x013B7C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (241927 - 180053 != 61874)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (233893 - 316045 != -82151)
			{
				Time.timeScale = 1f;
				if (142235 - 23162 != 119074)
				{
					Hashtable customOpParameters = new Hashtable();
					if (141177 - 595612 != -454434)
					{
						this.j6Bn1zRoXuV.OpCustom(52, customOpParameters, true);
						if (207341 - 30310 == 177031)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7A6 RID: 47014 RVA: 0x013B9AD0 File Offset: 0x013B7CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (266557 - 165647 != 100911)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (267886 - 424543 != -156656)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (290980 - 510817 == -219837)
				{
					Game.mGameState = eGameState.Setup;
					if (5959 - 340681 != -334721)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B7A7 RID: 47015 RVA: 0x013B9B74 File Offset: 0x013B7D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (247931 - 217406 != 30526)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (120390 - 146170 != -25779)
			{
				if (num == PlayerData.UID)
				{
					if (127355 - 505047 != -377691)
					{
						this.SetupActors();
						if (55970 - 102138 != -46167)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (277158 - 501181 != -224022)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B7A8 RID: 47016 RVA: 0x013B9C44 File Offset: 0x013B7E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (292374 - 70560 != 221814)
		{
		}
		for (;;)
		{
			IL_1D5:
			Debug.Log("Creating Actors");
			if (126143 - 232718 != -106574)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (211023 - 586996 == -375973)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (61200 - 52448 == 8752)
						{
							int i = 0;
							if (206305 - 185923 != 20383)
							{
								CharacterControl[] array2 = array;
								if (192251 - 273167 != -80915)
								{
									int length = array2.Length;
									if (69310 - 566353 == -497043)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (157082 - 350223 != -193141)
												{
													goto IL_1D5;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (254261 - 16825 == 237437)
												{
													goto IL_1D5;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (167778 - 350071 != -182293)
												{
													goto IL_1D5;
												}
												this.L2MnqtgxsOW++;
												if (85485 - 358824 != -273339)
												{
													goto IL_1D5;
												}
											}
											i++;
											if (21576 - 485816 != -464240)
											{
												goto IL_1D5;
											}
										}
										if (225495 - 374640 == -149145)
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
						if (171789 - 115510 != 56280)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7A9 RID: 47017 RVA: 0x013B9E80 File Offset: 0x013B8080
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (82309 - 74736 != 7574)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (27084 - 422697 == -395613)
			{
				int i = 0;
				if (256254 - 97250 == 159004)
				{
					CharacterControl[] array2 = array;
					if (22888 - 348746 != -325857)
					{
						int length = array2.Length;
						if (273529 - 459591 != -186061)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (293716 - 206396 == 87321)
								{
									goto IL_E0;
								}
								i++;
								if (119818 - 314140 == -194321)
								{
									goto IL_E0;
								}
							}
							if (295954 - 253788 == 42166)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7AA RID: 47018 RVA: 0x013B9FB0 File Offset: 0x013B81B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (274325 - 205302 != 69024)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (59511 - 231728 != -172216)
			{
				Game.mGameState = eGameState.Ready;
				if (287016 - 311986 == -24970)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (32777 - 416854 != -384076)
					{
						if (270914 - 148205 == 122709)
						{
							GameObject gameObject = null;
							if (232526 - 190641 != 41886)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (222455 - 58711 != 163744)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (274675 - 577344 != -302669)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (60172 - 465327 != -405155)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (186977 - 250381 != -63404)
										{
											continue;
										}
										goto IL_292;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (110946 - 412118 != -301172)
								{
									continue;
								}
								IL_292:
								if (gameObject2)
								{
									if (139506 - 179616 == -40109)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (11255 - 83839 == -72583)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (236356 - 55727 == 180630)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (161863 - 462320 == -300456)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (292172 - 332959 != -40787)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (42268 - 180468 != -138199)
								{
									this.transform.position = gameObject.transform.position;
									if (237205 - 229003 != 8203)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (273180 - 264315 == 8865)
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

	// Token: 0x0600B7AB RID: 47019 RVA: 0x013BA2D4 File Offset: 0x013B84D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M973_PirateCave4.$StartGame$46482(this).GetEnumerator();
	}

	// Token: 0x0600B7AC RID: 47020 RVA: 0x013BA2E4 File Offset: 0x013B84E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B7AD RID: 47021 RVA: 0x013BA2E8 File Offset: 0x013B84E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (290186 - 447898 != -157711)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (294797 - 30151 != 264647)
			{
				if (gameObject)
				{
					if (220351 - 145128 != 75224)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (132594 - 320536 == -187942)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (129 - 217132 == -217003)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B7AE RID: 47022 RVA: 0x013BA3E4 File Offset: 0x013B85E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (204719 - 423542 != -218822)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (3563 - 76103 != -72539)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (247967 - 308641 != -60673)
				{
					hashtable.Add(43, PlayerData.UID);
					if (44636 - 147295 != -102658)
					{
						hashtable.Add(73, nType);
						if (55083 - 414960 == -359877)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (265975 - 462669 != -196693)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (186160 - 468729 != -282568)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (296541 - 431326 != -134784)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (235479 - 203094 == 32385)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (1988 - 151745 == -149757)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (130319 - 593975 != -463655)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (124715 - 379727 != -255011)
													{
														this.j6Bn1zRoXuV.OpCustom(63, hashtable, true);
														if (13968 - 10535 != 3434)
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

	// Token: 0x0600B7AF RID: 47023 RVA: 0x013BA6C8 File Offset: 0x013B88C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (207799 - 110982 != 96818)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (16581 - 98716 == -82135)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (106778 - 241525 == -134747)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (129014 - 459609 == -330595)
						{
							if (this.L2MnqtgxsOW <= 0)
							{
								break;
							}
							if (54696 - 592029 == -537333)
							{
								this.L2MnqtgxsOW--;
								if (37706 - 252099 == -214393)
								{
									if (this.L2MnqtgxsOW != 0)
									{
										break;
									}
									if (199432 - 531617 != -332184)
									{
										Game.setGameState(eGameState.Ready);
										if (221034 - 233488 == -12454)
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
						if (376 - 189716 != -189339)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (40314 - 421629 == -381315)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7B0 RID: 47024 RVA: 0x013BA858 File Offset: 0x013B8A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B7B1 RID: 47025 RVA: 0x013BA86C File Offset: 0x013B8A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (281699 - 459422 != -177723)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (222076 - 218439 != 3638)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (55137 - 358611 == -303474)
				{
					if (!characterControl)
					{
						break;
					}
					if (55322 - 244682 != -189359)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (115425 - 540650 == -425225)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (117716 - 596905 == -479189)
							{
								string type = characterControl.Type;
								if (297214 - 13217 != 283998)
								{
									if (type == "PirateFish")
									{
										if (168865 - 353248 == -184383)
										{
											Game.sendMissionEvent(9734, 3);
											if (192315 - 596275 == -403960)
											{
												break;
											}
										}
									}
									else if (type == "PirateCrawfish")
									{
										if (203457 - 505441 == -301984)
										{
											Game.sendMissionEvent(9734, 4);
											if (226014 - 366013 != -139998)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "PandoraBug"))
										{
											break;
										}
										if (160746 - 386695 != -225948)
										{
											Game.sendMissionEvent(9734, 7);
											if (174115 - 154462 != 19654)
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

	// Token: 0x0600B7B2 RID: 47026 RVA: 0x013BAA8C File Offset: 0x013B8C8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (255896 - 533470 != -277574)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (239235 - 592819 != -353583)
			{
				hashtable.Add(71, CID);
				if (262414 - 143427 == 118987)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (134184 - 468281 == -334097)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (83888 - 143312 != -59423)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (272155 - 872 == 271283)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (277310 - 555413 != -278102)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (112894 - 355788 != -242893)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (71697 - 553258 == -481561)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (233175 - 336770 != -103594)
											{
												this.j6Bn1zRoXuV.OpCustom(61, hashtable, true);
												if (295058 - 555572 != -260513)
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

	// Token: 0x0600B7B3 RID: 47027 RVA: 0x013BAD18 File Offset: 0x013B8F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (164840 - 59511 != 105329)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (248081 - 39251 == 208830)
			{
				if (!gameObject)
				{
					break;
				}
				if (100664 - 53686 != 46979)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (225343 - 389118 == -163775)
					{
						playerCameraControl.target = gameObject;
						if (114248 - 584869 == -470621)
						{
							Game.loadPlayer();
							if (26965 - 315386 != -288420)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (15646 - 37425 != -21778)
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

	// Token: 0x0600B7B4 RID: 47028 RVA: 0x013BAE30 File Offset: 0x013B9030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (151100 - 562765 != -411665)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (97359 - 187722 != -90362)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (51920 - 520226 != -468305)
				{
					gameGui.ResetTeamBar();
					if (258948 - 306044 != -47095)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B7B5 RID: 47029 RVA: 0x013BAEDC File Offset: 0x013B90DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave4.$onDeadPlayer$46486(this).GetEnumerator();
	}

	// Token: 0x0600B7B6 RID: 47030 RVA: 0x013BAEEC File Offset: 0x013B90EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (40891 - 540275 != -499383)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (164309 - 318911 != -154601)
			{
				this.Boinq5oXJ3E.target = Game.mPlayer;
				if (126077 - 206229 != -80151)
				{
					this.Boinq5oXJ3E.enabled = true;
					if (25598 - 484930 != -459331)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (249652 - 3074 == 246579)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (219928 - 86580 != 133348)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (6684 - 521321 != -514636)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (13459 - 405579 != -392119)
							{
								if (!gameGui)
								{
									break;
								}
								if (210586 - 209203 != 1384)
								{
									gameGui.enabled = true;
									if (295869 - 501018 == -205149)
									{
										gameGui.closeDeadMenu();
										if (186843 - 406007 == -219164)
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

	// Token: 0x0600B7B7 RID: 47031 RVA: 0x013BB098 File Offset: 0x013B9298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (276940 - 160790 != 116150)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (237026 - 420082 != -183055)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (19283 - 451445 != -432161)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (22529 - 391566 == -369037)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B7B8 RID: 47032 RVA: 0x013BB15C File Offset: 0x013B935C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B7B9 RID: 47033 RVA: 0x013BB188 File Offset: 0x013B9388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (236294 - 585623 != -349329)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (17633 - 517529 != -499895)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (211825 - 511773 == -299948)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (131245 - 478104 == -346859)
					{
						Hashtable hashtable = new Hashtable();
						if (284841 - 249874 == 34967)
						{
							hashtable.Add(43, PlayerData.UID);
							if (82084 - 115770 != -33685)
							{
								hashtable.Add(71, nCID);
								if (64303 - 105335 == -41032)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (211761 - 286610 != -74848)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (116924 - 280471 == -163547)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (96811 - 11138 != 85674)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (227681 - 274061 != -46379)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (35451 - 337921 != -302469)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (234477 - 496668 == -262191)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (175206 - 561619 != -386412)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (212564 - 120564 != 92001)
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

	// Token: 0x0600B7BA RID: 47034 RVA: 0x013BB4A8 File Offset: 0x013B96A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave4.$onChangePlayer$46492(data, this).GetEnumerator();
	}

	// Token: 0x0600B7BB RID: 47035 RVA: 0x013BB4B8 File Offset: 0x013B96B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave4.$onGameComplete$46499(data, this).GetEnumerator();
	}

	// Token: 0x0600B7BC RID: 47036 RVA: 0x013BB4C8 File Offset: 0x013B96C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave4.$ReturnToTown$46509(this).GetEnumerator();
	}

	// Token: 0x0600B7BD RID: 47037 RVA: 0x013BB4D8 File Offset: 0x013B96D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave4.$ReturnToGuild$46514(this).GetEnumerator();
	}

	// Token: 0x0600B7BE RID: 47038 RVA: 0x013BB4E8 File Offset: 0x013B96E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave4.$ReturnToCamp$46518(this).GetEnumerator();
	}

	// Token: 0x0600B7BF RID: 47039 RVA: 0x013BB4F8 File Offset: 0x013B96F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (224266 - 509067 != -284801)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (86587 - 18943 == 67644)
			{
				Hashtable hashtable = new Hashtable();
				if (74229 - 254580 != -180350)
				{
					hashtable.Add(43, PlayerData.UID);
					if (83218 - 461737 == -378519)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (293544 - 389992 != -96447)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7C0 RID: 47040 RVA: 0x013BB5D0 File Offset: 0x013B97D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B7C1 RID: 47041 RVA: 0x013BB5E4 File Offset: 0x013B97E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (227995 - 209670 != 18325)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (196375 - 56145 != 140231)
			{
				Hashtable hashtable = new Hashtable();
				if (251119 - 543302 == -292183)
				{
					if (Game.mNextGameCode == 30)
					{
						if (141281 - 525911 == -384629)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (26277 - 46891 == -20613)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (266997 - 352235 != -85238)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (261737 - 334396 != -72659)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (74919 - 99507 == -24587)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (27385 - 214586 != -187201)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (4978 - 528432 != -523454)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (211216 - 178249 != 32967)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (240345 - 373335 == -132989)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (221837 - 417970 != -196133)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (128678 - 433085 == -304406)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (292115 - 537280 != -245165)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (112682 - 425838 == -313155)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (214767 - 543778 != -329011)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (294671 - 248107 != 46564)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (37005 - 162240 != -125235)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (234190 - 284366 != -50176)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (249591 - 411757 != -162166)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (186357 - 349503 == -163145)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (212954 - 72896 == 140059)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (176245 - 542152 == -365906)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (144426 - 466490 == -322063)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (290169 - 297033 != -6864)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (168709 - 368136 != -199427)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (215125 - 304503 == -89377)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (126889 - 181884 != -54995)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (264213 - 430922 != -166709)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (109022 - 35401 == 73622)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (83718 - 206516 != -122797)
					{
						this.j6Bn1zRoXuV.OpCustom(42, hashtable, true);
						if (98299 - 342074 == -243775)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B7C2 RID: 47042 RVA: 0x013BBB98 File Offset: 0x013B9D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B7C3 RID: 47043 RVA: 0x013BBBA8 File Offset: 0x013B9DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B7C4 RID: 47044 RVA: 0x013BBBAC File Offset: 0x013B9DAC
	internal static bool UsQhpKtNdiJ1bcjPO7tv()
	{
		return true;
	}

	// Token: 0x0600B7C5 RID: 47045 RVA: 0x013BBBB0 File Offset: 0x013B9DB0
	internal static bool hMDFPwtNJCdnJ6HskFOO()
	{
		return false;
	}

	// Token: 0x04009EA9 RID: 40617
	private LitePeer j6Bn1zRoXuV;

	// Token: 0x04009EAA RID: 40618
	private PlayerCameraControl Boinq5oXJ3E;

	// Token: 0x04009EAB RID: 40619
	private float hywnqck5M4T;

	// Token: 0x04009EAC RID: 40620
	private int vpgnqnxhXkZ;

	// Token: 0x04009EAD RID: 40621
	private int aDQnqQR4U1R;

	// Token: 0x04009EAE RID: 40622
	private int z5jnqeIDZVN;

	// Token: 0x04009EAF RID: 40623
	private bool DYunqIWPjmp;

	// Token: 0x04009EB0 RID: 40624
	private bool P2SnqJBR2WG;

	// Token: 0x04009EB1 RID: 40625
	private bool Y0unq6e9gaR;

	// Token: 0x04009EB2 RID: 40626
	private int L2MnqtgxsOW;

	// Token: 0x02001EB8 RID: 7864
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46461 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B7C6 RID: 47046 RVA: 0x013BBBB4 File Offset: 0x013B9DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46461(Hashtable data, M973_PirateCave4 self_)
		{
			if (64477 - 155752 != -91275)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34725 - 278 != 34448)
				{
					base..ctor();
					if (284677 - 525570 == -240893)
					{
						this.$data$46471 = data;
						if (23780 - 308301 != -284520)
						{
							this.$self_$46472 = self_;
							if (84860 - 24565 == 60295)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x013BBC70 File Offset: 0x013B9E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$onGameEvent$46461.$(this.$data$46471, this.$self_$46472);
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x013BBC84 File Offset: 0x013B9E84
		internal static bool xf7hUntND3h6Bpi0uwBe()
		{
			return true;
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x013BBC88 File Offset: 0x013B9E88
		internal static bool aelmO7tNvLBLDK4myrMD()
		{
			return false;
		}

		// Token: 0x04009EB3 RID: 40627
		internal Hashtable $data$46471;

		// Token: 0x04009EB4 RID: 40628
		internal M973_PirateCave4 $self_$46472;

		// Token: 0x02001EB9 RID: 7865
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B7CA RID: 47050 RVA: 0x013BBC8C File Offset: 0x013B9E8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave4 self_)
			{
				if (2106 - 98113 != -96007)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245690 - 416351 == -170661)
					{
						base..ctor();
						if (72492 - 493056 != -420563)
						{
							this.$data$46469 = data;
							if (207249 - 254431 != -47181)
							{
								this.$self_$46470 = self_;
								if (35560 - 290877 != -255316)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B7CB RID: 47051 RVA: 0x013BBD48 File Offset: 0x013B9F48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (151369 - 167079 != -15710)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_7CD;
					case 1:
						goto IL_1024;
					case 2:
						Game.savePlayer();
						if (68690 - 552526 != -483836)
						{
							continue;
						}
						Game.mGameStage = 5;
						if (2735 - 502095 == -499359)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave5");
						if (289437 - 210376 != 79061)
						{
							continue;
						}
						break;
					default:
						if (261189 - 14597 != 246593)
						{
							goto IL_7CD;
						}
						continue;
					}
					IL_1AF:
					this.YieldDefault(1);
					if (211919 - 357086 != -145167)
					{
						continue;
					}
					goto IL_1024;
					IL_43E:
					goto IL_1AF;
					IL_7CD:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (7402 - 497955 != -490552)
						{
							goto Block_59;
						}
					}
					else
					{
						this.$returnCode$46462 = RuntimeServices.UnboxInt32(this.$data$46469[141]);
						if (239514 - 159276 != 80239)
						{
							this.$returnValue$46463 = RuntimeServices.UnboxInt32(this.$data$46469[145]);
							if (1978 - 513290 != -511311)
							{
								this.$ownerID$46464 = RuntimeServices.UnboxInt32(this.$data$46469[43]);
								if (230958 - 162075 != 68884)
								{
									this.$$switch$8672$46465 = this.$returnCode$46462;
									if (85369 - 77771 == 7598)
									{
										if (this.$$switch$8672$46465 == 9731)
										{
											if (270047 - 234663 != 35385)
											{
												goto IL_1AF;
											}
										}
										else if (this.$$switch$8672$46465 == -9731)
										{
											if (43425 - 161096 != -117670)
											{
												if (this.$self_$46470.vpgnqnxhXkZ >= 3)
												{
													goto IL_43E;
												}
												if (203686 - 591932 == -388246)
												{
													this.$self_$46470.vpgnqnxhXkZ = 3;
													if (206342 - 231279 != -24936)
													{
														Game.mGameState = eGameState.AllHold;
														if (112245 - 185180 == -72935)
														{
															this.$mGameGui$46466 = (GameGui)this.$self_$46470.GetComponent(typeof(GameGui));
															if (98139 - 169738 != -71598)
															{
																this.$mGameGui$46466.close();
																if (134056 - 503970 != -369913)
																{
																	this.$self_$46470.SendMessage("fadeOut");
																	if (91497 - 50613 == 40884)
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
										else if (this.$$switch$8672$46465 == 9732)
										{
											if (78300 - 190009 != -111708)
											{
												goto IL_1AF;
											}
										}
										else
										{
											if (this.$$switch$8672$46465 == -9732)
											{
												if (143324 - 414316 == -270991)
												{
													continue;
												}
												this.$$switch$8668$46467 = this.$returnValue$46463;
												if (103377 - 185285 == -81907)
												{
													continue;
												}
												if (this.$$switch$8668$46467 == 1)
												{
													if (249187 - 126474 != 122713)
													{
														continue;
													}
													this.$self_$46470.DYunqIWPjmp = true;
													if (206715 - 288033 == -81317)
													{
														continue;
													}
													this.$self_$46470.StartCoroutine_Auto(this.$self_$46470.PirateEvent1());
													if (164269 - 45964 != 118305)
													{
														continue;
													}
												}
												else if (this.$$switch$8668$46467 == 2)
												{
													if (202912 - 168907 == 34006)
													{
														continue;
													}
													this.$self_$46470.replaceActor("PirateFish", 1, PlayerData.UID == this.$ownerID$46464);
													if (173485 - 33829 != 139656)
													{
														continue;
													}
													this.$self_$46470.replaceActor("PirateFish", 2, PlayerData.UID == this.$ownerID$46464);
													if (152956 - 163325 != -10369)
													{
														continue;
													}
													this.$self_$46470.replaceActor("PirateFish", 3, PlayerData.UID == this.$ownerID$46464);
													if (253406 - 275384 == -21977)
													{
														continue;
													}
													this.$self_$46470.replaceActor("PirateFish", 4, PlayerData.UID == this.$ownerID$46464);
													if (63722 - 8795 == 54928)
													{
														continue;
													}
													this.$self_$46470.replaceActor("PirateCrawfish", 1, PlayerData.UID == this.$ownerID$46464);
													if (174506 - 375236 != -200730)
													{
														continue;
													}
													this.$self_$46470.replaceActor("PirateCrawfish", 2, PlayerData.UID == this.$ownerID$46464);
													if (222771 - 240242 != -17471)
													{
														continue;
													}
													this.$self_$46470.replaceActor("PirateCrawfish", 3, PlayerData.UID == this.$ownerID$46464);
													if (170888 - 543725 == -372836)
													{
														continue;
													}
												}
												else if (this.$$switch$8668$46467 == 3)
												{
													if (176909 - 372150 != -195241)
													{
														continue;
													}
													this.$self_$46470.P2SnqJBR2WG = true;
													if (49959 - 36378 != 13581)
													{
														continue;
													}
													if (PlayerData.UID == this.$ownerID$46464)
													{
														if (124270 - 184527 != -60257)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateFish", 7, 21);
														if (187094 - 411582 == -224487)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateFish", 7, 22);
														if (194473 - 3903 == 190571)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateFish", 7, 23);
														if (1303 - 146064 == -144760)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateFish", 7, 24);
														if (121017 - 304768 == -183750)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateCrawfish", 7, 25);
														if (158241 - 460706 == -302464)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateCrawfish", 7, 26);
														if (91676 - 327178 == -235501)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateCrawfish", 7, 27);
														if (140610 - 525767 != -385157)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateCrawfish", 7, 28);
														if (35376 - 335365 != -299989)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PandoraBug", 7, 51);
														if (177642 - 19937 != 157705)
														{
															continue;
														}
													}
												}
												else if (this.$$switch$8668$46467 == 4)
												{
													if (280283 - 479700 == -199416)
													{
														continue;
													}
													this.$self_$46470.Y0unq6e9gaR = true;
													if (135334 - 587029 != -451695)
													{
														continue;
													}
													if (PlayerData.UID == this.$ownerID$46464)
													{
														if (46382 - 426530 == -380147)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateFish", 7, 31);
														if (114594 - 534706 != -420112)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateFish", 7, 32);
														if (67852 - 48773 != 19079)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateFish", 7, 33);
														if (89474 - 154434 != -64960)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateFish", 7, 34);
														if (66085 - 440336 == -374250)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateCrawfish", 7, 35);
														if (293104 - 539074 != -245970)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateCrawfish", 7, 36);
														if (248173 - 462606 == -214432)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateCrawfish", 7, 37);
														if (106806 - 437420 == -330613)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PirateCrawfish", 7, 38);
														if (168751 - 548525 == -379773)
														{
															continue;
														}
														this.$self_$46470.spawnActor("PandoraBug", 7, 54);
														if (262217 - 180642 == 81576)
														{
															continue;
														}
													}
												}
												else if (this.$$switch$8668$46467 == 5)
												{
													if (10478 - 459702 != -449224)
													{
														continue;
													}
													if (this.$self_$46470.vpgnqnxhXkZ < 2)
													{
														if (250039 - 197729 == 52311)
														{
															continue;
														}
														this.$self_$46470.vpgnqnxhXkZ = 2;
														if (65464 - 45954 != 19510)
														{
															continue;
														}
														this.$self_$46470.SendMessage("newGameMessage", "Mission Objective : Pirate key has been found!");
														if (242283 - 71577 != 170706)
														{
															continue;
														}
														Chat.SubmitChat("none", "Mission Objective : Pirate key has been found!", eChatType.system, eChatMode.system);
														if (183104 - 409426 != -226322)
														{
															continue;
														}
														this.$self_$46470.StartCoroutine_Auto(this.$self_$46470.PirateEvent2());
														if (250147 - 422685 != -172538)
														{
															continue;
														}
													}
												}
												else
												{
													Debug.LogError("Warning unknown pirate event code:" + this.$returnCode$46462);
													if (54503 - 202639 != -148136)
													{
														continue;
													}
												}
											}
											else if (this.$$switch$8672$46465 == 9734)
											{
												if (269045 - 507190 == -238144)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46462);
												if (42193 - 66010 != -23817)
												{
													continue;
												}
												goto IL_1AF;
											}
											this.$$switch$8670$46468 = this.$returnValue$46463;
											if (26854 - 217965 != -191110)
											{
												if (this.$$switch$8670$46468 != 3)
												{
													if (164679 - 468800 != -304121)
													{
														continue;
													}
													if (this.$$switch$8670$46468 == 4)
													{
														if (227132 - 283661 == -56528)
														{
															continue;
														}
													}
													else
													{
														if (this.$$switch$8670$46468 != 7)
														{
															goto IL_794;
														}
														if (79752 - 433369 != -353617)
														{
															continue;
														}
														this.$self_$46470.z5jnqeIDZVN = this.$self_$46470.z5jnqeIDZVN + 1;
														if (240296 - 584266 == -343969)
														{
															continue;
														}
														Debug.Log("Pandora Eliminate: " + this.$self_$46470.z5jnqeIDZVN);
														if (41796 - 307693 == -265896)
														{
															continue;
														}
														this.$self_$46470.SendMessage("newGameMessage", "Pandora Eliminated : " + this.$self_$46470.z5jnqeIDZVN + "/??");
														if (186106 - 548015 != -361908)
														{
															if (PlayerData.UID == this.$ownerID$46464)
															{
																if (8249 - 536324 == -528074)
																{
																	continue;
																}
																if (UnityEngine.Random.Range(0, 100) >= 10)
																{
																	if (219116 - 553353 != -334237)
																	{
																		continue;
																	}
																	if (this.$self_$46470.z5jnqeIDZVN < 6)
																	{
																		goto IL_78F;
																	}
																	if (13004 - 242623 != -229619)
																	{
																		continue;
																	}
																}
																Debug.Log("PirateKey Found! from pirate#: " + this.$self_$46470.aDQnqQR4U1R);
																if (281998 - 140908 == 141091)
																{
																	continue;
																}
																Game.sendMissionEvent(9732, 5);
																if (246374 - 132961 == 113414)
																{
																	continue;
																}
															}
															IL_78F:
															goto IL_794;
														}
														continue;
													}
												}
												this.$self_$46470.aDQnqQR4U1R = this.$self_$46470.aDQnqQR4U1R + 1;
												if (91086 - 7896 != 83190)
												{
													continue;
												}
												Debug.Log("Pirate Eliminate: " + this.$self_$46470.aDQnqQR4U1R);
												if (21099 - 333857 == -312757)
												{
													continue;
												}
												this.$self_$46470.SendMessage("newGameMessage", "Pirate Eliminated : " + this.$self_$46470.aDQnqQR4U1R + "/??");
												if (163948 - 346030 == -182081)
												{
													continue;
												}
												if (PlayerData.UID == this.$ownerID$46464)
												{
													if (290369 - 160486 != 129883)
													{
														continue;
													}
													if (this.$self_$46470.aDQnqQR4U1R >= 12)
													{
														if (1029 - 430564 != -429535)
														{
															continue;
														}
														if (this.$self_$46470.vpgnqnxhXkZ < 2)
														{
															if (296633 - 589072 == -292438)
															{
																continue;
															}
															if (this.$self_$46470.aDQnqQR4U1R % 6 == 3)
															{
																if (176839 - 260810 != -83971)
																{
																	continue;
																}
																this.$self_$46470.spawnActor("PandoraBug", 7, UnityEngine.Random.Range(51, 55));
																if (63264 - 361740 == -298475)
																{
																	continue;
																}
															}
															else if (UnityEngine.Random.Range(0, 100) < 60)
															{
																if (277357 - 136866 != 140491)
																{
																	continue;
																}
																this.$self_$46470.spawnActor("PirateFish", 7, UnityEngine.Random.Range(41, 49));
																if (173551 - 50579 == 122973)
																{
																	continue;
																}
															}
															else
															{
																this.$self_$46470.spawnActor("PirateCrawfish", 7, UnityEngine.Random.Range(41, 49));
																if (43191 - 278782 == -235590)
																{
																	continue;
																}
															}
														}
													}
												}
												IL_794:
												goto IL_1AF;
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_59:
				IL_1024:
				return false;
			}

			// Token: 0x0600B7CC RID: 47052 RVA: 0x013BCD8C File Offset: 0x013BAF8C
			internal static bool U8PenVtNR9EV9hIOX03U()
			{
				return true;
			}

			// Token: 0x0600B7CD RID: 47053 RVA: 0x013BCD90 File Offset: 0x013BAF90
			internal static bool kdtK8ItNwWcBIAVuJv6X()
			{
				return false;
			}

			// Token: 0x04009EB5 RID: 40629
			internal int $returnCode$46462;

			// Token: 0x04009EB6 RID: 40630
			internal int $returnValue$46463;

			// Token: 0x04009EB7 RID: 40631
			internal int $ownerID$46464;

			// Token: 0x04009EB8 RID: 40632
			internal int $$switch$8672$46465;

			// Token: 0x04009EB9 RID: 40633
			internal GameGui $mGameGui$46466;

			// Token: 0x04009EBA RID: 40634
			internal int $$switch$8668$46467;

			// Token: 0x04009EBB RID: 40635
			internal int $$switch$8670$46468;

			// Token: 0x04009EBC RID: 40636
			internal Hashtable $data$46469;

			// Token: 0x04009EBD RID: 40637
			internal M973_PirateCave4 $self_$46470;
		}
	}

	// Token: 0x02001EBA RID: 7866
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateEvent1$46473 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B7CE RID: 47054 RVA: 0x013BCD94 File Offset: 0x013BAF94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateEvent1$46473(M973_PirateCave4 self_)
		{
			if (173230 - 248356 != -75125)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108056 - 208510 == -100454)
				{
					base..ctor();
					if (233650 - 118269 == 115381)
					{
						this.$self_$46477 = self_;
						if (233046 - 36958 == 196088)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x013BCE2C File Offset: 0x013BB02C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$PirateEvent1$46473.$(this.$self_$46477);
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x013BCE3C File Offset: 0x013BB03C
		internal static bool SbXf36tNqmV8ikfNOKnC()
		{
			return true;
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x013BCE40 File Offset: 0x013BB040
		internal static bool S9qthptN7Z9RR2Bq9FG8()
		{
			return false;
		}

		// Token: 0x04009EBE RID: 40638
		internal M973_PirateCave4 $self_$46477;

		// Token: 0x02001EBB RID: 7867
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B7D2 RID: 47058 RVA: 0x013BCE44 File Offset: 0x013BB044
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave4 self_)
			{
				if (165225 - 394948 != -229722)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154570 - 526263 != -371692)
					{
						base..ctor();
						if (215290 - 15738 != 199553)
						{
							this.$self_$46476 = self_;
							if (153702 - 309316 == -155614)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B7D3 RID: 47059 RVA: 0x013BCEDC File Offset: 0x013BB0DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14279 - 307977 != -293698)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_604;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (209993 - 103101 != 106892)
							{
								continue;
							}
							goto IL_24F;
						}
						else
						{
							this.$mStoryGui$46475 = (StoryGui)this.$self_$46476.GetComponent(typeof(StoryGui));
							if (154382 - 443473 == -289090)
							{
								continue;
							}
							if (!this.$mStoryGui$46475)
							{
								goto IL_476;
							}
							if (25592 - 293650 == -268057)
							{
								continue;
							}
							this.$mStoryGui$46475.startStoryMessage("none", "Pirate Fish", eTalkType.friend);
							if (59838 - 341374 != -281535)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (75892 - 31645 != 44247)
							{
								continue;
							}
							goto IL_30E;
						}
						else
						{
							this.$mStoryGui$46475.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 401), eTalkType.enemy);
							if (26575 - 154504 != -127929)
							{
								continue;
							}
							goto IL_498;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (23461 - 244511 != -221049)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46475.newStoryMessage("none", "Pirate Crawfish", Language.getMessage("M973_PirateCave", 402), eTalkType.enemy);
							if (39701 - 74472 != -34770)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (251607 - 563617 != -312010)
							{
								continue;
							}
							goto IL_150;
						}
						else
						{
							this.$mStoryGui$46475.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 403), eTalkType.enemy);
							if (223526 - 478446 != -254920)
							{
								continue;
							}
							goto IL_5C9;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (73170 - 266627 != -193457)
							{
								continue;
							}
							goto IL_195;
						}
						else
						{
							this.$mStoryGui$46475.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 404), eTalkType.enemy);
							if (223758 - 9314 != 214444)
							{
								continue;
							}
							goto IL_2D3;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (195761 - 371013 != -175251)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46475.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 405), eTalkType.enemy);
							if (86940 - 327472 != -240531)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (20049 - 508783 != -488733)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9732, 2);
							if (235572 - 16537 != 219035)
							{
								continue;
							}
							this.$mStoryGui$46475.close();
							if (95645 - 425684 == -330038)
							{
								continue;
							}
							this.$self_$46476.Boinq5oXJ3E.enabled = true;
							if (273978 - 173097 != 100881)
							{
								continue;
							}
							goto IL_50E;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (200733 - 58235 != 142498)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (283713 - 34632 != 249081)
							{
								continue;
							}
							this.$mGameGui$46474.enabled = true;
							if (244917 - 568278 != -323361)
							{
								continue;
							}
							goto IL_476;
						}
						break;
					default:
						if (32299 - 254139 != -221840)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (223366 - 513813 != -290447)
					{
						continue;
					}
					this.$mGameGui$46474 = (GameGui)this.$self_$46476.GetComponent(typeof(GameGui));
					if (279476 - 322581 != -43105)
					{
						continue;
					}
					if (this.$mGameGui$46474)
					{
						if (246986 - 508907 != -261921)
						{
							continue;
						}
						this.$mGameGui$46474.close();
						if (176729 - 219337 == -42607)
						{
							continue;
						}
					}
					this.$self_$46476.Boinq5oXJ3E.StartCoroutine_Auto(this.$self_$46476.Boinq5oXJ3E.slerpToObject("EventCamera1", (float)2));
					if (161142 - 239152 != -78010)
					{
						continue;
					}
					goto IL_353;
					IL_476:
					this.YieldDefault(1);
				}
				while (87737 - 254940 != -167203);
				IL_1A:
				goto IL_604;
				Block_8:
				return this.Yield(5, new WaitForSeconds(3.5f));
				IL_150:
				IL_195:
				Block_14:
				IL_24F:
				goto IL_604;
				Block_17:
				return this.Yield(8, new WaitForSeconds(3.5f));
				IL_2D3:
				return this.Yield(7, new WaitForSeconds(3.5f));
				Block_19:
				IL_30E:
				goto IL_604;
				IL_353:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_498:
				return this.Yield(4, new WaitForSeconds(3.5f));
				Block_30:
				goto IL_604;
				IL_50E:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_37:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_5C9:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_604:
				return false;
			}

			// Token: 0x0600B7D4 RID: 47060 RVA: 0x013BD500 File Offset: 0x013BB700
			internal static bool Q5KP9gtNP6yHLMJpZ6n1()
			{
				return true;
			}

			// Token: 0x0600B7D5 RID: 47061 RVA: 0x013BD504 File Offset: 0x013BB704
			internal static bool pNFeLetN0O6KDwJ9Pgp1()
			{
				return false;
			}

			// Token: 0x04009EBF RID: 40639
			internal GameGui $mGameGui$46474;

			// Token: 0x04009EC0 RID: 40640
			internal StoryGui $mStoryGui$46475;

			// Token: 0x04009EC1 RID: 40641
			internal M973_PirateCave4 $self_$46476;
		}
	}

	// Token: 0x02001EBC RID: 7868
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateEvent2$46478 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B7D6 RID: 47062 RVA: 0x013BD508 File Offset: 0x013BB708
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateEvent2$46478(M973_PirateCave4 self_)
		{
			if (241654 - 477491 != -235837)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299634 - 300306 == -672)
				{
					base..ctor();
					if (281661 - 335178 == -53517)
					{
						this.$self_$46481 = self_;
						if (279861 - 488151 != -208289)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x013BD5A0 File Offset: 0x013BB7A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$PirateEvent2$46478.$(this.$self_$46481);
		}

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x013BD5B0 File Offset: 0x013BB7B0
		internal static bool QLwYkUtNbswR3W53b3p7()
		{
			return true;
		}

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x013BD5B4 File Offset: 0x013BB7B4
		internal static bool mrbRgCtNuRaAfCqIddXW()
		{
			return false;
		}

		// Token: 0x04009EC2 RID: 40642
		internal M973_PirateCave4 $self_$46481;

		// Token: 0x02001EBD RID: 7869
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B7DA RID: 47066 RVA: 0x013BD5B8 File Offset: 0x013BB7B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave4 self_)
			{
				if (234259 - 504503 != -270244)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (209286 - 156789 != 52498)
					{
						base..ctor();
						if (176637 - 372656 == -196019)
						{
							this.$self_$46480 = self_;
							if (53274 - 230414 == -177140)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B7DB RID: 47067 RVA: 0x013BD650 File Offset: 0x013BB850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271298 - 245671 != 25627)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_114;
					case 1:
						goto IL_211;
					case 2:
						Game.mGameState = eGameState.AllHold;
						if (292769 - 70961 == 221808)
						{
							this.$mGameGui$46479 = (GameGui)this.$self_$46480.GetComponent(typeof(GameGui));
							if (65752 - 235844 == -170092)
							{
								if (this.$mGameGui$46479)
								{
									if (245342 - 128494 == 116849)
									{
										break;
									}
									this.$mGameGui$46479.close();
									if (206511 - 447257 == -240745)
									{
										break;
									}
								}
								this.$self_$46480.Boinq5oXJ3E.StartCoroutine_Auto(this.$self_$46480.Boinq5oXJ3E.slerpToObject("EventCamera2", (float)3));
								if (158761 - 596604 != -437842)
								{
									goto Block_6;
								}
							}
						}
						break;
					case 3:
						this.$self_$46480.OnOpenPirateGate(1);
						if (218453 - 569293 == -350840)
						{
							goto IL_78;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (191197 - 205070 != -13872)
							{
								goto Block_5;
							}
						}
						else
						{
							Game.sendMissionEvent(9731, 5);
							if (38909 - 447913 == -409004)
							{
								this.YieldDefault(1);
								if (181311 - 88971 != 92341)
								{
									goto Block_7;
								}
							}
						}
						break;
					default:
						if (233515 - 116865 != 116651)
						{
							goto Block_10;
						}
						break;
					}
				}
				IL_78:
				return this.Yield(4, new WaitForSeconds((float)5));
				Block_5:
				goto IL_211;
				Block_6:
				return this.Yield(3, new WaitForSeconds((float)3));
				Block_7:
				goto IL_211;
				IL_114:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_10:
				goto IL_114;
				IL_211:
				return false;
			}

			// Token: 0x0600B7DC RID: 47068 RVA: 0x013BD880 File Offset: 0x013BBA80
			internal static bool T2s2cqtNIVWQbkIdcCtc()
			{
				return true;
			}

			// Token: 0x0600B7DD RID: 47069 RVA: 0x013BD884 File Offset: 0x013BBA84
			internal static bool jkWJlStNBen23hq3Y8iq()
			{
				return false;
			}

			// Token: 0x04009EC3 RID: 40643
			internal GameGui $mGameGui$46479;

			// Token: 0x04009EC4 RID: 40644
			internal M973_PirateCave4 $self_$46480;
		}
	}

	// Token: 0x02001EBE RID: 7870
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$46482 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B7DE RID: 47070 RVA: 0x013BD888 File Offset: 0x013BBA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$46482(M973_PirateCave4 self_)
		{
			if (79000 - 568724 != -489724)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130912 - 230698 != -99785)
				{
					base..ctor();
					if (73232 - 533616 == -460384)
					{
						this.$self_$46485 = self_;
						if (139476 - 392130 == -252654)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x013BD920 File Offset: 0x013BBB20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$StartGame$46482.$(this.$self_$46485);
		}

		// Token: 0x0600B7E0 RID: 47072 RVA: 0x013BD930 File Offset: 0x013BBB30
		internal static bool AmKakItNeHnvGuRDpijM()
		{
			return true;
		}

		// Token: 0x0600B7E1 RID: 47073 RVA: 0x013BD934 File Offset: 0x013BBB34
		internal static bool MiBPs3tNra4123UXUnRJ()
		{
			return false;
		}

		// Token: 0x04009EC5 RID: 40645
		internal M973_PirateCave4 $self_$46485;

		// Token: 0x02001EBF RID: 7871
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B7E2 RID: 47074 RVA: 0x013BD938 File Offset: 0x013BBB38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave4 self_)
			{
				if (140624 - 47960 != 92664)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178904 - 37580 != 141325)
					{
						base..ctor();
						if (52231 - 539706 == -487475)
						{
							this.$self_$46484 = self_;
							if (7764 - 440504 == -432740)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B7E3 RID: 47075 RVA: 0x013BD9D0 File Offset: 0x013BBBD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224371 - 66062 != 158310)
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
						if (184211 - 306055 != -121844)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (111128 - 183580 != -72452)
						{
							continue;
						}
						this.YieldDefault(1);
						if (293886 - 17781 != 276106)
						{
							goto IL_1B9;
						}
						continue;
					default:
						if (185804 - 349619 == -163814)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (713 - 570887 == -570174)
					{
						Game.mGameState = eGameState.Start;
						if (272736 - 127327 != 145410)
						{
							Game.mStateTime = Time.time;
							if (119316 - 260597 != -141280)
							{
								this.$mGameGui$46483 = (GameGui)this.$self_$46484.GetComponent(typeof(GameGui));
								if (256102 - 130281 == 125821)
								{
									this.$mGameGui$46483.enabled = true;
									if (227916 - 173586 == 54330)
									{
										this.$self_$46484.SendMessage("fadeIn");
										if (66086 - 43956 == 22130)
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

			// Token: 0x0600B7E4 RID: 47076 RVA: 0x013BDBA8 File Offset: 0x013BBDA8
			internal static bool SbBeSntNjJx47epUM4pt()
			{
				return true;
			}

			// Token: 0x0600B7E5 RID: 47077 RVA: 0x013BDBAC File Offset: 0x013BBDAC
			internal static bool xaPpOAtNhWCIAlUGI9m7()
			{
				return false;
			}

			// Token: 0x04009EC6 RID: 40646
			internal GameGui $mGameGui$46483;

			// Token: 0x04009EC7 RID: 40647
			internal M973_PirateCave4 $self_$46484;
		}
	}

	// Token: 0x02001EC0 RID: 7872
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46486 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B7E6 RID: 47078 RVA: 0x013BDBB0 File Offset: 0x013BBDB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46486(M973_PirateCave4 self_)
		{
			if (289880 - 198711 != 91170)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (125185 - 280427 == -155242)
				{
					base..ctor();
					if (251903 - 85270 != 166634)
					{
						this.$self_$46491 = self_;
						if (153367 - 593985 != -440617)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x013BDC48 File Offset: 0x013BBE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$onDeadPlayer$46486.$(this.$self_$46491);
		}

		// Token: 0x0600B7E8 RID: 47080 RVA: 0x013BDC58 File Offset: 0x013BBE58
		internal static bool kZ3tsqtNsaC0Q55fb4re()
		{
			return true;
		}

		// Token: 0x0600B7E9 RID: 47081 RVA: 0x013BDC5C File Offset: 0x013BBE5C
		internal static bool rWt3j9tN92mb3rrsIWAO()
		{
			return false;
		}

		// Token: 0x04009EC8 RID: 40648
		internal M973_PirateCave4 $self_$46491;

		// Token: 0x02001EC1 RID: 7873
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B7EA RID: 47082 RVA: 0x013BDC60 File Offset: 0x013BBE60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave4 self_)
			{
				if (46659 - 532897 != -486238)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92609 - 559446 == -466837)
					{
						base..ctor();
						if (208850 - 474954 == -266104)
						{
							this.$self_$46490 = self_;
							if (50578 - 210840 == -160262)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B7EB RID: 47083 RVA: 0x013BDCF8 File Offset: 0x013BBEF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (37195 - 138557 != -101362)
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
							goto IL_2D9;
						}
						if (88567 - 567156 != -478589)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (204287 - 288918 != -84631)
							{
								continue;
							}
							goto IL_2D9;
						}
						IL_B2:
						this.YieldDefault(1);
						if (134816 - 172010 != -37194)
						{
							continue;
						}
						goto IL_2F9;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (77268 - 272669 == -195400)
						{
							continue;
						}
						this.$mStoryGui$46487 = (StoryGui)this.$self_$46490.GetComponent(typeof(StoryGui));
						if (99589 - 246612 == -147022)
						{
							continue;
						}
						if (this.$mStoryGui$46487)
						{
							if (113926 - 548127 != -434201)
							{
								continue;
							}
							this.$mStoryGui$46487.close();
							if (155775 - 207382 == -51606)
							{
								continue;
							}
						}
						this.$mChangeGui$46488 = (ChangeGui)this.$self_$46490.GetComponent(typeof(ChangeGui));
						if (27901 - 595859 == -567957)
						{
							continue;
						}
						if (this.$mChangeGui$46488)
						{
							if (174583 - 587237 == -412653)
							{
								continue;
							}
							this.$mChangeGui$46488.close();
							if (97412 - 50342 != 47070)
							{
								continue;
							}
						}
						this.$mGameGui$46489 = (GameGui)this.$self_$46490.GetComponent(typeof(GameGui));
						if (105730 - 21216 != 84514)
						{
							continue;
						}
						if (!this.$mGameGui$46489)
						{
							goto IL_B2;
						}
						if (101066 - 465766 != -364700)
						{
							continue;
						}
						if (!this.$mGameGui$46489.enabled)
						{
							if (125753 - 479093 != -353340)
							{
								continue;
							}
							this.$mGameGui$46489.enabled = true;
							if (233439 - 498915 != -265476)
							{
								continue;
							}
						}
						this.$mGameGui$46489.openDeadMenu();
						if (157139 - 516166 != -359026)
						{
							goto IL_B2;
						}
						continue;
					default:
						if (128437 - 360084 == -231646)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (252894 - 279496 == -26601);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B7EC RID: 47084 RVA: 0x013BE010 File Offset: 0x013BC210
			internal static bool aGFERdtN19gAtOw1CRvj()
			{
				return true;
			}

			// Token: 0x0600B7ED RID: 47085 RVA: 0x013BE014 File Offset: 0x013BC214
			internal static bool L5X31LtN4hob9D28UU3U()
			{
				return false;
			}

			// Token: 0x04009EC9 RID: 40649
			internal StoryGui $mStoryGui$46487;

			// Token: 0x04009ECA RID: 40650
			internal ChangeGui $mChangeGui$46488;

			// Token: 0x04009ECB RID: 40651
			internal GameGui $mGameGui$46489;

			// Token: 0x04009ECC RID: 40652
			internal M973_PirateCave4 $self_$46490;
		}
	}

	// Token: 0x02001EC2 RID: 7874
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46492 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B7EE RID: 47086 RVA: 0x013BE018 File Offset: 0x013BC218
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46492(Hashtable data, M973_PirateCave4 self_)
		{
			if (55204 - 305396 != -250192)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293120 - 21888 == 271232)
				{
					base..ctor();
					if (214059 - 161718 == 52341)
					{
						this.$data$46497 = data;
						if (228456 - 87858 == 140598)
						{
							this.$self_$46498 = self_;
							if (169439 - 475680 == -306241)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x013BE0D4 File Offset: 0x013BC2D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$onChangePlayer$46492.$(this.$data$46497, this.$self_$46498);
		}

		// Token: 0x0600B7F0 RID: 47088 RVA: 0x013BE0E8 File Offset: 0x013BC2E8
		internal static bool kpC9TgtNzOfvlASJO5mf()
		{
			return true;
		}

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x013BE0EC File Offset: 0x013BC2EC
		internal static bool QPeiTGtYaHMWiS32Lgra()
		{
			return false;
		}

		// Token: 0x04009ECD RID: 40653
		internal Hashtable $data$46497;

		// Token: 0x04009ECE RID: 40654
		internal M973_PirateCave4 $self_$46498;

		// Token: 0x02001EC3 RID: 7875
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B7F2 RID: 47090 RVA: 0x013BE0F0 File Offset: 0x013BC2F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave4 self_)
			{
				if (111791 - 557833 != -446042)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149428 - 23916 != 125513)
					{
						base..ctor();
						if (34806 - 288840 == -254034)
						{
							this.$data$46495 = data;
							if (272860 - 245421 == 27439)
							{
								this.$self_$46496 = self_;
								if (21943 - 157683 == -135740)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B7F3 RID: 47091 RVA: 0x013BE1AC File Offset: 0x013BC3AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79600 - 554962 != -475362)
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
							if (36597 - 518342 == -481744)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (181048 - 192383 == -11334)
							{
								continue;
							}
							this.$mGameGui$46494 = (GameGui)this.$self_$46496.GetComponent(typeof(GameGui));
							if (165272 - 532628 != -367356)
							{
								continue;
							}
							this.$mGameGui$46494.enabled = true;
							if (267627 - 96756 == 170872)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (212644 - 191713 != 20931)
						{
							continue;
						}
						goto IL_205;
					default:
						if (161349 - 405895 == -244545)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (41736 - 491661 != -449924)
					{
						this.$self_$46496.SendMessage("onCreatePlayer", this.$data$46495);
						if (277656 - 84405 != 193252)
						{
							this.$mChangeGui$46493 = (ChangeGui)this.$self_$46496.GetComponent(typeof(ChangeGui));
							if (53549 - 427551 == -374002)
							{
								if (!this.$mChangeGui$46493.enabled)
								{
									break;
								}
								if (286101 - 172247 == 113854)
								{
									this.$mChangeGui$46493.close();
									if (13737 - 525436 == -511699)
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

			// Token: 0x0600B7F4 RID: 47092 RVA: 0x013BE3D0 File Offset: 0x013BC5D0
			internal static bool YtqZ52tY5k3K0sbqYTLl()
			{
				return true;
			}

			// Token: 0x0600B7F5 RID: 47093 RVA: 0x013BE3D4 File Offset: 0x013BC5D4
			internal static bool XpQpZptYpvDxyVfyFQo7()
			{
				return false;
			}

			// Token: 0x04009ECF RID: 40655
			internal ChangeGui $mChangeGui$46493;

			// Token: 0x04009ED0 RID: 40656
			internal GameGui $mGameGui$46494;

			// Token: 0x04009ED1 RID: 40657
			internal Hashtable $data$46495;

			// Token: 0x04009ED2 RID: 40658
			internal M973_PirateCave4 $self_$46496;
		}
	}

	// Token: 0x02001EC4 RID: 7876
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46499 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B7F6 RID: 47094 RVA: 0x013BE3D8 File Offset: 0x013BC5D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46499(Hashtable data, M973_PirateCave4 self_)
		{
			if (232731 - 277578 != -44846)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168494 - 333218 != -164723)
				{
					base..ctor();
					if (257233 - 49966 == 207267)
					{
						this.$data$46507 = data;
						if (184850 - 177452 == 7398)
						{
							this.$self_$46508 = self_;
							if (265916 - 349785 == -83869)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x013BE494 File Offset: 0x013BC694
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$onGameComplete$46499.$(this.$data$46507, this.$self_$46508);
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x013BE4A8 File Offset: 0x013BC6A8
		internal static bool Dcy0yRtYVlSSIN5MfrVi()
		{
			return true;
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x013BE4AC File Offset: 0x013BC6AC
		internal static bool q7e7nitYt8DWvm3Sl2KY()
		{
			return false;
		}

		// Token: 0x04009ED3 RID: 40659
		internal Hashtable $data$46507;

		// Token: 0x04009ED4 RID: 40660
		internal M973_PirateCave4 $self_$46508;

		// Token: 0x02001EC5 RID: 7877
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B7FA RID: 47098 RVA: 0x013BE4B0 File Offset: 0x013BC6B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave4 self_)
			{
				if (21992 - 348358 != -326365)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93171 - 298718 == -205547)
					{
						base..ctor();
						if (3627 - 151026 == -147399)
						{
							this.$data$46505 = data;
							if (31683 - 514844 == -483161)
							{
								this.$self_$46506 = self_;
								if (98573 - 12145 != 86429)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B7FB RID: 47099 RVA: 0x013BE56C File Offset: 0x013BC76C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153398 - 416749 != -263350)
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
						this.$mCompleteGui$46501 = (CompleteGui)this.$self_$46506.GetComponent(typeof(CompleteGui));
						if (122330 - 426108 == -303777)
						{
							continue;
						}
						this.$mCompleteGui$46501.Init();
						if (262135 - 406451 == -144315)
						{
							continue;
						}
						this.$mCompleteGui$46501.readData(this.$data$46505);
						if (180450 - 463778 == -283327)
						{
							continue;
						}
						if (this.$result$46500 == 1)
						{
							if (133278 - 131228 == 2051)
							{
								continue;
							}
							this.$mCompleteGui$46501.displayResult(eCompleteType.Success);
							if (26868 - 448451 != -421583)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46501.displayResult(eCompleteType.Failed);
							if (110081 - 76408 == 33674)
							{
								continue;
							}
						}
						this.$mGameGui$46502 = (GameGui)this.$self_$46506.GetComponent(typeof(GameGui));
						if (285976 - 500019 == -214042)
						{
							continue;
						}
						this.$mStoryGui$46503 = (StoryGui)this.$self_$46506.GetComponent(typeof(StoryGui));
						if (2198 - 415472 == -413273)
						{
							continue;
						}
						this.$mChangeGui$46504 = (ChangeGui)this.$self_$46506.GetComponent(typeof(ChangeGui));
						if (124210 - 252216 != -128006)
						{
							continue;
						}
						if (this.$mGameGui$46502)
						{
							if (189478 - 138267 != 51211)
							{
								continue;
							}
							this.$mGameGui$46502.close();
							if (284137 - 491793 != -207656)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46503)
						{
							if (223249 - 581374 == -358124)
							{
								continue;
							}
							this.$mStoryGui$46503.close();
							if (46095 - 347864 != -301769)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46504)
						{
							if (138209 - 597946 == -459736)
							{
								continue;
							}
							this.$mChangeGui$46504.disable();
							if (30622 - 554821 == -524198)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (213914 - 379652 != -165738)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (62576 - 313653 == -251076)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46505[31]);
					if (198417 - 403279 == -204862)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (79407 - 233648 == -154241)
							{
								goto IL_1CA;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (195347 - 568593 != -373245)
							{
								this.$result$46500 = RuntimeServices.UnboxInt32(this.$data$46505[31]);
								if (44234 - 40089 != 4146)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1CA:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B7FC RID: 47100 RVA: 0x013BE968 File Offset: 0x013BCB68
			internal static bool XvTWjktYNKENfE991jsh()
			{
				return true;
			}

			// Token: 0x0600B7FD RID: 47101 RVA: 0x013BE96C File Offset: 0x013BCB6C
			internal static bool AJ0ORRtYYbm1MIwTgvuf()
			{
				return false;
			}

			// Token: 0x04009ED5 RID: 40661
			internal int $result$46500;

			// Token: 0x04009ED6 RID: 40662
			internal CompleteGui $mCompleteGui$46501;

			// Token: 0x04009ED7 RID: 40663
			internal GameGui $mGameGui$46502;

			// Token: 0x04009ED8 RID: 40664
			internal StoryGui $mStoryGui$46503;

			// Token: 0x04009ED9 RID: 40665
			internal ChangeGui $mChangeGui$46504;

			// Token: 0x04009EDA RID: 40666
			internal Hashtable $data$46505;

			// Token: 0x04009EDB RID: 40667
			internal M973_PirateCave4 $self_$46506;
		}
	}

	// Token: 0x02001EC6 RID: 7878
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46509 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B7FE RID: 47102 RVA: 0x013BE970 File Offset: 0x013BCB70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46509(M973_PirateCave4 self_)
		{
			if (298036 - 534811 != -236774)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (97074 - 122551 != -25476)
				{
					base..ctor();
					if (67367 - 512013 == -444646)
					{
						this.$self_$46513 = self_;
						if (59918 - 560930 == -501012)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x013BEA08 File Offset: 0x013BCC08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$ReturnToTown$46509.$(this.$self_$46513);
		}

		// Token: 0x0600B800 RID: 47104 RVA: 0x013BEA18 File Offset: 0x013BCC18
		internal static bool OCdnQDtYcTR5JBcgrcx2()
		{
			return true;
		}

		// Token: 0x0600B801 RID: 47105 RVA: 0x013BEA1C File Offset: 0x013BCC1C
		internal static bool Q9nOm1tYUF81rlLd5VEr()
		{
			return false;
		}

		// Token: 0x04009EDC RID: 40668
		internal M973_PirateCave4 $self_$46513;

		// Token: 0x02001EC7 RID: 7879
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B802 RID: 47106 RVA: 0x013BEA20 File Offset: 0x013BCC20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave4 self_)
			{
				if (74590 - 475124 != -400534)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141804 - 273786 != -131981)
					{
						base..ctor();
						if (30897 - 259622 != -228724)
						{
							this.$self_$46512 = self_;
							if (176705 - 228643 == -51938)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B803 RID: 47107 RVA: 0x013BEAB8 File Offset: 0x013BCCB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150046 - 567543 != -417496)
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
						this.$self_$46512.LeaveGame();
						if (297626 - 464387 != -166761)
						{
							continue;
						}
						this.YieldDefault(1);
						if (103483 - 247718 != -144234)
						{
							goto Block_30;
						}
						continue;
					default:
						if (184001 - 181224 != 2777)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (126585 - 553408 == -426823)
					{
						Game.mStateTime = Time.time;
						if (142228 - 142081 != 148)
						{
							this.$$switch$8677$46510 = PlayerData.SaveGuild;
							if (270608 - 256832 != 13777)
							{
								if (this.$$switch$8677$46510 == 1)
								{
									if (45221 - 363213 != -317992)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (123818 - 586123 == -462304)
									{
										continue;
									}
								}
								else if (this.$$switch$8677$46510 == 2)
								{
									if (143907 - 204225 != -60318)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (292235 - 551982 == -259746)
									{
										continue;
									}
								}
								else if (this.$$switch$8677$46510 == 3)
								{
									if (281261 - 579669 != -298408)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (219267 - 222629 == -3361)
									{
										continue;
									}
								}
								else if (this.$$switch$8677$46510 == 4)
								{
									if (138305 - 39909 == 98397)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (193258 - 583970 != -390712)
									{
										continue;
									}
								}
								else if (this.$$switch$8677$46510 == 5)
								{
									if (172201 - 240258 != -68057)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (191884 - 446303 != -254419)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (216371 - 574635 != -358264)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (271299 - 168196 == 103104)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (4360 - 580951 != -576591)
									{
										continue;
									}
								}
								this.$mGameGui$46511 = (GameGui)this.$self_$46512.GetComponent(typeof(GameGui));
								if (63264 - 568018 == -504754)
								{
									if (this.$mGameGui$46511)
									{
										if (160770 - 221160 != -60390)
										{
											continue;
										}
										this.$mGameGui$46511.close();
										if (79193 - 178634 == -99440)
										{
											continue;
										}
									}
									this.$self_$46512.SendMessage("fadeOut");
									if (222732 - 216083 == 6649)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_30:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B804 RID: 47108 RVA: 0x013BEE84 File Offset: 0x013BD084
			internal static bool OusW5CtYTBGoC0dNsgOv()
			{
				return true;
			}

			// Token: 0x0600B805 RID: 47109 RVA: 0x013BEE88 File Offset: 0x013BD088
			internal static bool ugCjaItY3kwp7WmtkGXD()
			{
				return false;
			}

			// Token: 0x04009EDD RID: 40669
			internal int $$switch$8677$46510;

			// Token: 0x04009EDE RID: 40670
			internal GameGui $mGameGui$46511;

			// Token: 0x04009EDF RID: 40671
			internal M973_PirateCave4 $self_$46512;
		}
	}

	// Token: 0x02001EC8 RID: 7880
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46514 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B806 RID: 47110 RVA: 0x013BEE8C File Offset: 0x013BD08C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46514(M973_PirateCave4 self_)
		{
			if (59903 - 306489 != -246585)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91430 - 331540 != -240109)
				{
					base..ctor();
					if (161815 - 558801 != -396985)
					{
						this.$self_$46517 = self_;
						if (115460 - 154617 == -39157)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B807 RID: 47111 RVA: 0x013BEF24 File Offset: 0x013BD124
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$ReturnToGuild$46514.$(this.$self_$46517);
		}

		// Token: 0x0600B808 RID: 47112 RVA: 0x013BEF34 File Offset: 0x013BD134
		internal static bool lJp8PstYX0TU0fO70vZY()
		{
			return true;
		}

		// Token: 0x0600B809 RID: 47113 RVA: 0x013BEF38 File Offset: 0x013BD138
		internal static bool jNjEkhtYQaGqj6vdMaTL()
		{
			return false;
		}

		// Token: 0x04009EE0 RID: 40672
		internal M973_PirateCave4 $self_$46517;

		// Token: 0x02001EC9 RID: 7881
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B80A RID: 47114 RVA: 0x013BEF3C File Offset: 0x013BD13C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave4 self_)
			{
				if (84084 - 497961 != -413876)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69683 - 283793 != -214109)
					{
						base..ctor();
						if (176846 - 59391 != 117456)
						{
							this.$self_$46516 = self_;
							if (293339 - 94804 == 198535)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B80B RID: 47115 RVA: 0x013BEFD4 File Offset: 0x013BD1D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242055 - 259078 != -17022)
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
						this.$self_$46516.LeaveGame();
						if (104591 - 126786 == -22194)
						{
							continue;
						}
						this.YieldDefault(1);
						if (13833 - 190060 != -176227)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (4665 - 377691 == -373025)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (252888 - 28481 == 224407)
					{
						Game.mStateTime = Time.time;
						if (136416 - 453100 == -316684)
						{
							Game.mNextGameCode = 31;
							if (193301 - 347508 == -154207)
							{
								this.$mGameGui$46515 = (GameGui)this.$self_$46516.GetComponent(typeof(GameGui));
								if (175747 - 402400 == -226653)
								{
									if (this.$mGameGui$46515)
									{
										if (198413 - 584241 == -385827)
										{
											continue;
										}
										this.$mGameGui$46515.close();
										if (84670 - 228023 != -143353)
										{
											continue;
										}
									}
									this.$self_$46516.SendMessage("fadeOut");
									if (101839 - 63571 == 38268)
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

			// Token: 0x0600B80C RID: 47116 RVA: 0x013BF1B0 File Offset: 0x013BD3B0
			internal static bool gFyjFWtYkfb0kUAP4mPe()
			{
				return true;
			}

			// Token: 0x0600B80D RID: 47117 RVA: 0x013BF1B4 File Offset: 0x013BD3B4
			internal static bool ccVMTAtYGvG9eaXxjjja()
			{
				return false;
			}

			// Token: 0x04009EE1 RID: 40673
			internal GameGui $mGameGui$46515;

			// Token: 0x04009EE2 RID: 40674
			internal M973_PirateCave4 $self_$46516;
		}
	}

	// Token: 0x02001ECA RID: 7882
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46518 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B80E RID: 47118 RVA: 0x013BF1B8 File Offset: 0x013BD3B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46518(M973_PirateCave4 self_)
		{
			if (185920 - 34605 != 151315)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283520 - 208013 == 75507)
				{
					base..ctor();
					if (176308 - 60260 != 116049)
					{
						this.$self_$46521 = self_;
						if (235144 - 464634 != -229489)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x013BF250 File Offset: 0x013BD450
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave4.$ReturnToCamp$46518.$(this.$self_$46521);
		}

		// Token: 0x0600B810 RID: 47120 RVA: 0x013BF260 File Offset: 0x013BD460
		internal static bool z3QDmetYHe5eEqn3e2n3()
		{
			return true;
		}

		// Token: 0x0600B811 RID: 47121 RVA: 0x013BF264 File Offset: 0x013BD464
		internal static bool DF6pn6tYWZhP04hEEcnq()
		{
			return false;
		}

		// Token: 0x04009EE3 RID: 40675
		internal M973_PirateCave4 $self_$46521;

		// Token: 0x02001ECB RID: 7883
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B812 RID: 47122 RVA: 0x013BF268 File Offset: 0x013BD468
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave4 self_)
			{
				if (292396 - 551595 != -259199)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94397 - 415556 == -321159)
					{
						base..ctor();
						if (126311 - 188586 == -62275)
						{
							this.$self_$46520 = self_;
							if (268915 - 461047 == -192132)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B813 RID: 47123 RVA: 0x013BF300 File Offset: 0x013BD500
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (262762 - 162466 != 100296)
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
						this.$self_$46520.LeaveGame();
						if (57234 - 24260 != 32974)
						{
							continue;
						}
						this.YieldDefault(1);
						if (230186 - 181042 != 49144)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (93468 - 239467 == -145998)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (261728 - 306352 == -44624)
					{
						Game.mStateTime = Time.time;
						if (215923 - 516821 == -300898)
						{
							Game.mNextGameCode = 33;
							if (2432 - 415778 == -413346)
							{
								this.$mGameGui$46519 = (GameGui)this.$self_$46520.GetComponent(typeof(GameGui));
								if (84824 - 488311 != -403486)
								{
									if (this.$mGameGui$46519)
									{
										if (278492 - 423044 == -144551)
										{
											continue;
										}
										this.$mGameGui$46519.close();
										if (91734 - 334811 != -243077)
										{
											continue;
										}
									}
									this.$self_$46520.SendMessage("fadeOut");
									if (297183 - 332612 == -35429)
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

			// Token: 0x0600B814 RID: 47124 RVA: 0x013BF4DC File Offset: 0x013BD6DC
			internal static bool A4nOWetYA29A47EO5ZMt()
			{
				return true;
			}

			// Token: 0x0600B815 RID: 47125 RVA: 0x013BF4E0 File Offset: 0x013BD6E0
			internal static bool h9IwDatYlBu4R2vL4LER()
			{
				return false;
			}

			// Token: 0x04009EE4 RID: 40676
			internal GameGui $mGameGui$46519;

			// Token: 0x04009EE5 RID: 40677
			internal M973_PirateCave4 $self_$46520;
		}
	}
}
