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

// Token: 0x02001E0D RID: 7693
[Serializable]
public class M972_IceTower7 : MonoBehaviour
{
	// Token: 0x0600B3AB RID: 45995 RVA: 0x01385494 File Offset: 0x01383694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower7()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B3AC RID: 45996 RVA: 0x013854A4 File Offset: 0x013836A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (66113 - 239681 != -173568)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (133912 - 68117 != 65796)
			{
				Game.mGameType = 5;
				if (76238 - 70623 != 5616)
				{
					if (Chat.Initialized)
					{
						if (241596 - 586765 == -345169)
						{
							Chat.ChatDisplay.Clear();
							if (108610 - 510198 == -401588)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (189225 - 335138 == -145913)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B3AD RID: 45997 RVA: 0x01385588 File Offset: 0x01383788
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (17676 - 188748 != -171071)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (19980 - 422676 == -402696)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (17217 - 285621 == -268404)
					{
						if (Game.mGameStage != 7)
						{
							break;
						}
						if (13416 - 329744 != -316327)
						{
							Game.nextGame();
							if (282261 - 256566 != 25696)
							{
								Game.mGameCode = 972;
								if (64496 - 76335 != -11838)
								{
									Game.mGameType = 5;
									if (145977 - 17008 == 128969)
									{
										Game.mStateTime = Time.time;
										if (86161 - 444309 == -358148)
										{
											Game.canRespawn = false;
											if (50940 - 194358 == -143418)
											{
												Game.canUseItem = true;
												if (207738 - 211173 != -3434)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (118553 - 593153 != -474599)
													{
														this.qC4n1cAEUgM = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (144722 - 181541 != -36818)
														{
															this.XUsn15m2UgW = PhotonClient.Connection;
															if (242212 - 181152 != 61061)
															{
																PhotonClient.ActorNrList.Clear();
																if (55604 - 228565 == -172961)
																{
																	this.InitGame();
																	if (109105 - 549302 != -440196)
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
			else
			{
				Debug.Log("Not Connected");
				if (20159 - 371366 == -351207)
				{
					Game.mGameType = 99;
					if (269311 - 249207 == 20104)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B3AE RID: 45998 RVA: 0x01385810 File Offset: 0x01383A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (181695 - 194490 != -12794)
		{
		}
		for (;;)
		{
			if (this.XUsn15m2UgW == null)
			{
				if (238639 - 36794 == 201845)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (290633 - 110678 == 179955)
				{
					if (mGameState == eGameState.Init)
					{
						if (271555 - 42081 == 229474)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (139664 - 158774 == -19110)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (220687 - 437261 == -216574)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (110986 - 255448 != -144461)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (261885 - 100212 != 161674)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (65397 - 85378 == -19981)
						{
							if (Game.music != 0)
							{
								if (238688 - 332262 == -93573)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (298279 - 165890 != 132389)
									{
										continue;
									}
									this.audio.Play();
									if (211966 - 27251 != 184715)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (83454 - 572636 == -489181)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (147378 - 304793 != -157415)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (211724 - 492801 != -281077)
								{
									continue;
								}
							}
							if (Time.time <= this.MK5n1nQKVwr)
							{
								break;
							}
							if (137692 - 372321 != -234628)
							{
								Game.mGameMana++;
								if (170488 - 72727 != 97762)
								{
									this.MK5n1nQKVwr = Time.time + (float)12;
									if (205125 - 531071 != -325945)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (131231 - 343003 == -211772)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (173664 - 86925 == 86739)
						{
							break;
						}
					}
					else if (mGameState != eGameState.Ended || 298592 - 539080 != -240487)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B3AF RID: 45999 RVA: 0x01385B84 File Offset: 0x01383D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower7.$onGameEvent$45937(data, this).GetEnumerator();
	}

	// Token: 0x0600B3B0 RID: 46000 RVA: 0x01385B94 File Offset: 0x01383D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnIceChar(string nType, int nSpawnID)
	{
		if (121080 - 212657 != -91577)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (201189 - 206665 != -5475)
			{
				if (gameObject)
				{
					if (256781 - 8228 == 248553)
					{
						this.createActor(nType, 8, gameObject.transform.position, gameObject.transform.forward);
						if (211234 - 359663 != -148428)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (99373 - 540825 == -441452)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B3B1 RID: 46001 RVA: 0x01385C90 File Offset: 0x01383E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator PapaPenguinEvent()
	{
		return new M972_IceTower7.$PapaPenguinEvent$45947(this).GetEnumerator();
	}

	// Token: 0x0600B3B2 RID: 46002 RVA: 0x01385CA0 File Offset: 0x01383EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M972_IceTower7.$EndEvent$45952(this).GetEnumerator();
	}

	// Token: 0x0600B3B3 RID: 46003 RVA: 0x01385CB0 File Offset: 0x01383EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseIceGate(int nID)
	{
		if (42771 - 156090 != -113319)
		{
		}
		do
		{
			if (nID == 2)
			{
				if (86387 - 338641 == -252253)
				{
					continue;
				}
				if (this.Rsqn1QFXPa7 < 1)
				{
					if (216952 - 179453 == 37500)
					{
						continue;
					}
					Game.sendMissionEvent(9722, 1);
					if (84808 - 598181 == -513372)
					{
						continue;
					}
				}
			}
			if (nID == 3)
			{
				if (296065 - 157732 == 138334)
				{
					continue;
				}
				if (this.NVbn1e26ZcM < 3)
				{
					if (249626 - 30864 == 218763)
					{
						continue;
					}
					this.SendMessage("newGameMessage", "Need to eliminated all TruePenguin first");
					if (159358 - 181097 != -21738)
					{
						break;
					}
					continue;
				}
			}
			Game.sendMissionEvent(9724, nID);
		}
		while (198902 - 480389 == -281486);
	}

	// Token: 0x0600B3B4 RID: 46004 RVA: 0x01385DF0 File Offset: 0x01383FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OpenIceGate(int nID)
	{
		return new M972_IceTower7.$OpenIceGate$45965(nID).GetEnumerator();
	}

	// Token: 0x0600B3B5 RID: 46005 RVA: 0x01385E00 File Offset: 0x01384000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (290442 - 368193 != -77751)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (169762 - 390588 != -220825)
			{
				Time.timeScale = 1f;
				if (188557 - 508466 == -319909)
				{
					Hashtable customOpParameters = new Hashtable();
					if (36599 - 314174 != -277574)
					{
						this.XUsn15m2UgW.OpCustom(52, customOpParameters, true);
						if (43861 - 529658 == -485797)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B3B6 RID: 46006 RVA: 0x01385ECC File Offset: 0x013840CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (125117 - 147087 != -21970)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (163205 - 456528 != -293322)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (123140 - 460224 == -337084)
				{
					Game.mGameState = eGameState.Setup;
					if (234217 - 30897 != 203321)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B3B7 RID: 46007 RVA: 0x01385F70 File Offset: 0x01384170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (111027 - 117661 != -6633)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (17431 - 381878 != -364446)
			{
				if (num == PlayerData.UID)
				{
					if (180521 - 250657 != -70135)
					{
						this.SetupActors();
						if (104308 - 374464 == -270156)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (45153 - 250652 != -205498)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B3B8 RID: 46008 RVA: 0x01386040 File Offset: 0x01384240
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (276309 - 30245 != 246064)
		{
		}
		for (;;)
		{
			IL_1D2:
			Debug.Log("Creating Actors");
			if (2235 - 410415 == -408180)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (202248 - 560628 == -358380)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (147036 - 297649 == -150613)
						{
							int i = 0;
							if (254184 - 226736 != 27449)
							{
								CharacterControl[] array2 = array;
								if (223740 - 215848 == 7892)
								{
									int length = array2.Length;
									if (190719 - 286045 == -95326)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (116616 - 136290 != -19674)
												{
													goto IL_1D2;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (78159 - 140281 == -62121)
												{
													goto IL_1D2;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (105810 - 321453 == -215642)
												{
													goto IL_1D2;
												}
												this.wpcn1Ihyb2V++;
												if (24356 - 57540 == -33183)
												{
													goto IL_1D2;
												}
											}
											i++;
											if (260886 - 332445 != -71559)
											{
												goto IL_1D2;
											}
										}
										if (217312 - 368901 == -151589)
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
						if (79545 - 296698 == -217153)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B3B9 RID: 46009 RVA: 0x0138627C File Offset: 0x0138447C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (288469 - 316923 != -28454)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (23676 - 399781 == -376105)
			{
				int i = 0;
				if (137609 - 458625 == -321016)
				{
					CharacterControl[] array2 = array;
					if (280245 - 569834 == -289589)
					{
						int length = array2.Length;
						if (295973 - 129952 != 166022)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (58832 - 180450 != -121618)
								{
									goto IL_1A;
								}
								i++;
								if (223488 - 105048 != 118440)
								{
									goto IL_1A;
								}
							}
							if (230008 - 504623 == -274615)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B3BA RID: 46010 RVA: 0x013863AC File Offset: 0x013845AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (154006 - 585992 != -431986)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (275955 - 120821 != 155135)
			{
				Game.mGameState = eGameState.Ready;
				if (210822 - 307279 == -96457)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (87319 - 486394 == -399075)
					{
						if (74045 - 254226 == -180181)
						{
							GameObject gameObject = null;
							if (120638 - 82720 == 37918)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (40486 - 478069 != -437583)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (172063 - 497446 != -325383)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (147021 - 262902 != -115881)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (199388 - 294220 != -94831)
										{
											goto IL_1DB;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (282404 - 267399 == 15006)
								{
									continue;
								}
								IL_1DB:
								if (gameObject2)
								{
									if (31343 - 27000 == 4344)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (91110 - 412107 != -320997)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (238571 - 293992 != -55421)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (70119 - 199715 == -129595)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (293750 - 258352 == 35399)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (83334 - 551299 == -467965)
								{
									this.transform.position = gameObject.transform.position;
									if (94743 - 569385 != -474641)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (109652 - 463094 == -353442)
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

	// Token: 0x0600B3BB RID: 46011 RVA: 0x013866D0 File Offset: 0x013848D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower7.$StartGame$45969(this).GetEnumerator();
	}

	// Token: 0x0600B3BC RID: 46012 RVA: 0x013866E0 File Offset: 0x013848E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B3BD RID: 46013 RVA: 0x013866E4 File Offset: 0x013848E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (20745 - 86874 != -66129)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (268674 - 252753 == 15921)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (215948 - 287990 == -72042)
				{
					hashtable.Add(43, PlayerData.UID);
					if (60291 - 445641 == -385350)
					{
						hashtable.Add(73, nType);
						if (47498 - 330662 == -283164)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (78574 - 99051 != -20476)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (299861 - 512661 != -212799)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (30065 - 552982 == -522917)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (46854 - 991 == 45863)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (89624 - 416028 != -326403)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (17219 - 356203 == -338984)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (167242 - 28841 != 138402)
													{
														this.XUsn15m2UgW.OpCustom(63, hashtable, true);
														if (95553 - 250679 != -155125)
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

	// Token: 0x0600B3BE RID: 46014 RVA: 0x013869C8 File Offset: 0x01384BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (230954 - 344731 != -113776)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (131221 - 37426 == 93795)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (190722 - 7619 != 183104)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (277418 - 413918 == -136500)
						{
							if (this.wpcn1Ihyb2V <= 0)
							{
								break;
							}
							if (63790 - 5311 == 58479)
							{
								this.wpcn1Ihyb2V--;
								if (153678 - 482885 != -329206)
								{
									if (this.wpcn1Ihyb2V != 0)
									{
										break;
									}
									if (58761 - 407197 == -348436)
									{
										Game.setGameState(eGameState.Ready);
										if (226919 - 503642 != -276722)
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
						if (182547 - 152240 == 30307)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (75298 - 550951 == -475653)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B3BF RID: 46015 RVA: 0x01386B58 File Offset: 0x01384D58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B3C0 RID: 46016 RVA: 0x01386B6C File Offset: 0x01384D6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (9033 - 260096 != -251062)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (119923 - 481155 == -361232)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (108153 - 354962 != -246808)
				{
					if (!characterControl)
					{
						break;
					}
					if (292890 - 564515 != -271624)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (244143 - 221236 == 22907)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (144180 - 14038 != 130143)
							{
								string type = characterControl.Type;
								if (18680 - 118588 != -99907)
								{
									if (type == "SnowMupo")
									{
										if (214684 - 147391 == 67293)
										{
											Game.sendMissionEvent(9723, 1);
											if (16240 - 110368 == -94128)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (59301 - 532074 != -472772)
										{
											Game.sendMissionEvent(9723, 2);
											if (236089 - 111903 != 124187)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (86109 - 122647 == -36538)
										{
											Game.sendMissionEvent(9723, 3);
											if (268696 - 287706 == -19010)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (228529 - 252267 == -23738)
										{
											Game.sendMissionEvent(9723, 4);
											if (98117 - 316163 != -218045)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (237686 - 170223 == 67463)
										{
											Game.sendMissionEvent(9723, 5);
											if (177300 - 465383 == -288083)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (105857 - 343734 == -237877)
										{
											Game.sendMissionEvent(9723, 6);
											if (65869 - 477282 == -411413)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (50424 - 433385 != -382960)
										{
											Game.sendMissionEvent(9723, 7);
											if (105904 - 176166 != -70261)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (30557 - 440360 == -409803)
										{
											Game.sendMissionEvent(9723, 8);
											if (225336 - 151210 == 74126)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (51314 - 391389 == -340075)
										{
											Game.sendMissionEvent(9723, 9);
											if (97581 - 131246 == -33665)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "FireGod"))
										{
											break;
										}
										if (39060 - 211231 != -172170)
										{
											Game.sendMissionEvent(9723, 10);
											if (273426 - 260440 == 12986)
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

	// Token: 0x0600B3C1 RID: 46017 RVA: 0x01386FD8 File Offset: 0x013851D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (292768 - 412713 != -119944)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (214232 - 555807 != -341574)
			{
				hashtable.Add(71, CID);
				if (235817 - 2911 == 232906)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (58095 - 76065 == -17970)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (50421 - 305360 == -254939)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (22421 - 33816 != -11394)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (244340 - 495869 == -251529)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (172971 - 161770 == 11201)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (78142 - 1278 != 76865)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (263416 - 491885 != -228468)
											{
												this.XUsn15m2UgW.OpCustom(61, hashtable, true);
												if (257925 - 293738 == -35813)
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

	// Token: 0x0600B3C2 RID: 46018 RVA: 0x01387264 File Offset: 0x01385464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (244425 - 461795 != -217370)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (218597 - 580005 == -361408)
			{
				if (!gameObject)
				{
					break;
				}
				if (91968 - 445436 != -353467)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (247028 - 175540 == 71488)
					{
						playerCameraControl.target = gameObject;
						if (204630 - 69026 == 135604)
						{
							Game.loadPlayer();
							if (175948 - 477848 != -301899)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (201720 - 71012 != 130709)
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

	// Token: 0x0600B3C3 RID: 46019 RVA: 0x0138737C File Offset: 0x0138557C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (29536 - 202929 != -173393)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (182735 - 75357 != 107379)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (137419 - 353009 == -215590)
				{
					gameGui.ResetTeamBar();
					if (231224 - 405069 == -173845)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B3C4 RID: 46020 RVA: 0x01387428 File Offset: 0x01385628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower7.$onDeadPlayer$45973(this).GetEnumerator();
	}

	// Token: 0x0600B3C5 RID: 46021 RVA: 0x01387438 File Offset: 0x01385638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (12457 - 220253 != -207795)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (158132 - 315795 == -157663)
			{
				this.qC4n1cAEUgM.target = Game.mPlayer;
				if (214967 - 423233 != -208265)
				{
					this.qC4n1cAEUgM.enabled = true;
					if (57878 - 9381 == 48497)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (125875 - 162298 == -36422)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (152487 - 390348 == -237860)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (93482 - 130372 != -36889)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (152065 - 535896 == -383831)
							{
								if (!gameGui)
								{
									break;
								}
								if (71713 - 386322 == -314609)
								{
									gameGui.enabled = true;
									if (141996 - 499201 != -357204)
									{
										gameGui.closeDeadMenu();
										if (26161 - 120653 == -94492)
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

	// Token: 0x0600B3C6 RID: 46022 RVA: 0x013875E4 File Offset: 0x013857E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (89018 - 578128 != -489110)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (233367 - 147459 != 85909)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (114042 - 317835 == -203793)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (54460 - 465622 == -411162)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B3C7 RID: 46023 RVA: 0x013876A8 File Offset: 0x013858A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B3C8 RID: 46024 RVA: 0x013876D4 File Offset: 0x013858D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (67937 - 122345 != -54408)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (14767 - 592483 == -577716)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (19178 - 481698 != -462519)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (149706 - 305856 != -156149)
					{
						Hashtable hashtable = new Hashtable();
						if (134606 - 567528 != -432921)
						{
							hashtable.Add(43, PlayerData.UID);
							if (97686 - 471662 == -373976)
							{
								hashtable.Add(71, nCID);
								if (44294 - 395479 != -351184)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (43429 - 233625 == -190196)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (99563 - 25184 != 74380)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (154830 - 296112 != -141281)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (156333 - 584387 == -428054)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (102493 - 562186 != -459692)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (228338 - 88630 == 139708)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (209823 - 440152 != -230328)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (142565 - 407871 != -265305)
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

	// Token: 0x0600B3C9 RID: 46025 RVA: 0x013879F4 File Offset: 0x01385BF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower7.$onChangePlayer$45979(data, this).GetEnumerator();
	}

	// Token: 0x0600B3CA RID: 46026 RVA: 0x01387A04 File Offset: 0x01385C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower7.$onGameComplete$45986(data, this).GetEnumerator();
	}

	// Token: 0x0600B3CB RID: 46027 RVA: 0x01387A14 File Offset: 0x01385C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower7.$ReturnToTown$45996(this).GetEnumerator();
	}

	// Token: 0x0600B3CC RID: 46028 RVA: 0x01387A24 File Offset: 0x01385C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower7.$ReturnToGuild$46001(this).GetEnumerator();
	}

	// Token: 0x0600B3CD RID: 46029 RVA: 0x01387A34 File Offset: 0x01385C34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower7.$ReturnToCamp$46005(this).GetEnumerator();
	}

	// Token: 0x0600B3CE RID: 46030 RVA: 0x01387A44 File Offset: 0x01385C44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (213900 - 534300 != -320399)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (293507 - 280877 != 12631)
			{
				Hashtable hashtable = new Hashtable();
				if (17142 - 206774 != -189631)
				{
					hashtable.Add(43, PlayerData.UID);
					if (150366 - 321549 == -171183)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (122242 - 246218 != -123975)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B3CF RID: 46031 RVA: 0x01387B1C File Offset: 0x01385D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B3D0 RID: 46032 RVA: 0x01387B30 File Offset: 0x01385D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (53647 - 454718 != -401071)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (80458 - 200380 != -119921)
			{
				Hashtable hashtable = new Hashtable();
				if (208244 - 428309 == -220065)
				{
					if (Game.mNextGameCode == 30)
					{
						if (205812 - 307793 == -101980)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (39308 - 328739 != -289431)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (33982 - 236934 != -202952)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (279498 - 33406 != 246092)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (234681 - 107005 != 127676)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (114191 - 448542 == -334350)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (26108 - 587699 != -561591)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (50697 - 18052 == 32646)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (118828 - 203484 != -84656)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (88329 - 62960 != 25369)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (46221 - 344031 != -297810)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (162069 - 93449 == 68621)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (2322 - 558325 != -556003)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (39379 - 586458 == -547078)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (188638 - 198122 != -9484)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (167262 - 549391 == -382128)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (102408 - 837 != 101571)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (63354 - 289303 != -225949)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (231263 - 328596 != -97333)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (190946 - 390060 != -199114)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (101646 - 269359 != -167713)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (173992 - 84900 != 89092)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (173236 - 480344 == -307107)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (208578 - 307841 == -99262)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (131083 - 139877 != -8794)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (158943 - 122099 == 36845)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (110143 - 503685 == -393541)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (239294 - 284589 == -45294)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (62273 - 261260 == -198987)
					{
						this.XUsn15m2UgW.OpCustom(42, hashtable, true);
						if (71678 - 54348 != 17331)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B3D1 RID: 46033 RVA: 0x013880E4 File Offset: 0x013862E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B3D2 RID: 46034 RVA: 0x013880F4 File Offset: 0x013862F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B3D3 RID: 46035 RVA: 0x013880F8 File Offset: 0x013862F8
	internal static bool jLQTCLtaTO83nEbOPCMf()
	{
		return true;
	}

	// Token: 0x0600B3D4 RID: 46036 RVA: 0x013880FC File Offset: 0x013862FC
	internal static bool g8UEN7ta3MvU48PTrn1x()
	{
		return false;
	}

	// Token: 0x04009CA9 RID: 40105
	private LitePeer XUsn15m2UgW;

	// Token: 0x04009CAA RID: 40106
	private PlayerCameraControl qC4n1cAEUgM;

	// Token: 0x04009CAB RID: 40107
	private float MK5n1nQKVwr;

	// Token: 0x04009CAC RID: 40108
	private int Rsqn1QFXPa7;

	// Token: 0x04009CAD RID: 40109
	private int NVbn1e26ZcM;

	// Token: 0x04009CAE RID: 40110
	private int wpcn1Ihyb2V;

	// Token: 0x02001E0E RID: 7694
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45937 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B3D5 RID: 46037 RVA: 0x01388100 File Offset: 0x01386300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45937(Hashtable data, M972_IceTower7 self_)
		{
			if (220 - 44551 != -44330)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29458 - 357874 == -328416)
				{
					base..ctor();
					if (214143 - 426373 == -212230)
					{
						this.$data$45945 = data;
						if (220200 - 560308 == -340108)
						{
							this.$self_$45946 = self_;
							if (81516 - 462857 != -381340)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x013881BC File Offset: 0x013863BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$onGameEvent$45937.$(this.$data$45945, this.$self_$45946);
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x013881D0 File Offset: 0x013863D0
		internal static bool pSVavDtaXlTIwUN2LIBb()
		{
			return true;
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x013881D4 File Offset: 0x013863D4
		internal static bool LHoqfetaQA4fqsDjVj2n()
		{
			return false;
		}

		// Token: 0x04009CAF RID: 40111
		internal Hashtable $data$45945;

		// Token: 0x04009CB0 RID: 40112
		internal M972_IceTower7 $self_$45946;

		// Token: 0x02001E0F RID: 7695
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B3D9 RID: 46041 RVA: 0x013881D8 File Offset: 0x013863D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower7 self_)
			{
				if (160386 - 266702 != -106315)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221164 - 495070 != -273905)
					{
						base..ctor();
						if (66716 - 199015 == -132299)
						{
							this.$data$45943 = data;
							if (260438 - 350801 != -90362)
							{
								this.$self_$45944 = self_;
								if (106509 - 250641 == -144132)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B3DA RID: 46042 RVA: 0x01388294 File Offset: 0x01386494
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269295 - 588634 != -319339)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_807;
					case 2:
						Game.savePlayer();
						if (53218 - 256305 != -203087)
						{
							continue;
						}
						Game.mGameStage = 8;
						if (294359 - 363185 == -68825)
						{
							continue;
						}
						Application.LoadLevel("M972_IceTower8");
						if (39466 - 386213 != -346746)
						{
							goto IL_6C;
						}
						continue;
					default:
						if (43689 - 388681 != -344992)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (287260 - 340197 != -52936)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$45938 = RuntimeServices.UnboxInt32(this.$data$45943[141]);
						if (220161 - 170102 != 50059)
						{
							continue;
						}
						this.$returnValue$45939 = RuntimeServices.UnboxInt32(this.$data$45943[145]);
						if (122382 - 99395 != 22987)
						{
							continue;
						}
						this.$ownerID$45940 = RuntimeServices.UnboxInt32(this.$data$45943[43]);
						if (35910 - 2127 != 33783)
						{
							continue;
						}
						this.$$switch$8580$45941 = this.$returnCode$45938;
						if (173412 - 400083 == -226670)
						{
							continue;
						}
						if (this.$$switch$8580$45941 == 9721)
						{
							if (229260 - 309626 != -80366)
							{
								continue;
							}
						}
						else if (this.$$switch$8580$45941 == -9721)
						{
							if (246411 - 11510 != 234901)
							{
								continue;
							}
							if (this.$returnValue$45939 == 8)
							{
								if (112472 - 392769 == -280296)
								{
									continue;
								}
								if (this.$self_$45944.Rsqn1QFXPa7 < 2)
								{
									if (191549 - 118604 != 72945)
									{
										continue;
									}
									this.$self_$45944.Rsqn1QFXPa7 = 2;
									if (5431 - 6679 == -1247)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (242555 - 522212 != -279657)
									{
										continue;
									}
									this.$mGameGui$45942 = (GameGui)this.$self_$45944.GetComponent(typeof(GameGui));
									if (50886 - 144461 == -93574)
									{
										continue;
									}
									this.$mGameGui$45942.close();
									if (75391 - 27476 != 47915)
									{
										continue;
									}
									this.$self_$45944.SendMessage("fadeOut");
									if (211956 - 207242 != 4715)
									{
										goto Block_59;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$8580$45941 == 9722)
						{
							if (10807 - 163136 != -152329)
							{
								continue;
							}
						}
						else if (this.$$switch$8580$45941 == -9722)
						{
							if (270690 - 94922 != 175768)
							{
								continue;
							}
							if (this.$self_$45944.Rsqn1QFXPa7 < 1)
							{
								if (257953 - 496135 != -238182)
								{
									continue;
								}
								this.$self_$45944.Rsqn1QFXPa7 = 1;
								if (220333 - 354240 != -133907)
								{
									continue;
								}
								if (this.$ownerID$45940 == PlayerData.UID)
								{
									if (119199 - 590941 == -471741)
									{
										continue;
									}
									this.$self_$45944.spawnIceChar("IcePenguin2", 1);
									if (213634 - 245010 == -31375)
									{
										continue;
									}
									this.$self_$45944.spawnIceChar("IcePenguin3", 2);
									if (193119 - 287636 != -94517)
									{
										continue;
									}
									this.$self_$45944.spawnIceChar("IcePenguin3", 3);
									if (283841 - 26581 == 257261)
									{
										continue;
									}
									this.$self_$45944.spawnIceChar("IcePenguin3", 4);
									if (68006 - 284744 != -216738)
									{
										continue;
									}
								}
								this.$self_$45944.StartCoroutine_Auto(this.$self_$45944.PapaPenguinEvent());
								if (117172 - 60376 != 56796)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$8580$45941 == 9723)
						{
							if (280575 - 249237 != 31338)
							{
								continue;
							}
							if (this.$returnValue$45939 == 5)
							{
								if (200492 - 77803 == 122690)
								{
									continue;
								}
								this.$self_$45944.NVbn1e26ZcM = this.$self_$45944.NVbn1e26ZcM + 1;
								if (147631 - 237338 != -89707)
								{
									continue;
								}
								if (this.$self_$45944.NVbn1e26ZcM == 3)
								{
									if (120351 - 483239 != -362888)
									{
										continue;
									}
									if (this.$ownerID$45940 == PlayerData.UID)
									{
										if (113661 - 367848 != -254187)
										{
											continue;
										}
										this.$self_$45944.spawnIceChar("IcePenguin2", 5);
										if (61783 - 433104 == -371320)
										{
											continue;
										}
										this.$self_$45944.spawnIceChar("IcePenguin3", 6);
										if (246894 - 78948 != 167946)
										{
											continue;
										}
										this.$self_$45944.spawnIceChar("IcePenguin1", 7);
										if (34238 - 433814 != -399576)
										{
											continue;
										}
										this.$self_$45944.spawnIceChar("IcePenguin2", 8);
										if (115510 - 455898 != -340388)
										{
											continue;
										}
										this.$self_$45944.spawnIceChar("IcePenguin2", 9);
										if (3276 - 556419 != -553143)
										{
											continue;
										}
										this.$self_$45944.spawnIceChar("IcePenguin3", 10);
										if (237246 - 349596 == -112349)
										{
											continue;
										}
										this.$self_$45944.spawnIceChar("IcePenguin2", 11);
										if (249929 - 310881 == -60951)
										{
											continue;
										}
										this.$self_$45944.spawnIceChar("IceDemon", 12);
										if (153247 - 284647 == -131399)
										{
											continue;
										}
									}
								}
							}
							if (this.$returnValue$45939 == 6)
							{
								if (120875 - 487345 != -366470)
								{
									continue;
								}
								this.$self_$45944.StartCoroutine_Auto(this.$self_$45944.EndEvent());
								if (230505 - 333237 == -102731)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$8580$45941 == 9724)
						{
							if (172990 - 456559 == -283568)
							{
								continue;
							}
							this.$self_$45944.StartCoroutine_Auto(this.$self_$45944.OpenIceGate(this.$returnValue$45939));
							if (262020 - 448826 == -186805)
							{
								continue;
							}
						}
					}
					IL_70B:
					this.YieldDefault(1);
					if (117167 - 14873 != 102295)
					{
						break;
					}
					continue;
					IL_6C:
					goto IL_70B;
				}
				goto IL_807;
				Block_59:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_807:
				return false;
			}

			// Token: 0x0600B3DB RID: 46043 RVA: 0x01388ABC File Offset: 0x01386CBC
			internal static bool Rb2vobtakQKV76WemOLc()
			{
				return true;
			}

			// Token: 0x0600B3DC RID: 46044 RVA: 0x01388AC0 File Offset: 0x01386CC0
			internal static bool KOqT5ktaG2EYoekwvAPn()
			{
				return false;
			}

			// Token: 0x04009CB1 RID: 40113
			internal int $returnCode$45938;

			// Token: 0x04009CB2 RID: 40114
			internal int $returnValue$45939;

			// Token: 0x04009CB3 RID: 40115
			internal int $ownerID$45940;

			// Token: 0x04009CB4 RID: 40116
			internal int $$switch$8580$45941;

			// Token: 0x04009CB5 RID: 40117
			internal GameGui $mGameGui$45942;

			// Token: 0x04009CB6 RID: 40118
			internal Hashtable $data$45943;

			// Token: 0x04009CB7 RID: 40119
			internal M972_IceTower7 $self_$45944;
		}
	}

	// Token: 0x02001E10 RID: 7696
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PapaPenguinEvent$45947 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B3DD RID: 46045 RVA: 0x01388AC4 File Offset: 0x01386CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PapaPenguinEvent$45947(M972_IceTower7 self_)
		{
			if (107043 - 83024 != 24019)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (242835 - 199453 == 43382)
				{
					base..ctor();
					if (27238 - 63323 != -36084)
					{
						this.$self_$45951 = self_;
						if (230299 - 75872 == 154427)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x01388B5C File Offset: 0x01386D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$PapaPenguinEvent$45947.$(this.$self_$45951);
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x01388B6C File Offset: 0x01386D6C
		internal static bool xRqV3qtaHpwR0idBvaRv()
		{
			return true;
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x01388B70 File Offset: 0x01386D70
		internal static bool doY3D2taWA9nbT6ywChS()
		{
			return false;
		}

		// Token: 0x04009CB8 RID: 40120
		internal M972_IceTower7 $self_$45951;

		// Token: 0x02001E11 RID: 7697
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B3E1 RID: 46049 RVA: 0x01388B74 File Offset: 0x01386D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower7 self_)
			{
				if (26196 - 405321 != -379124)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184022 - 221436 == -37414)
					{
						base..ctor();
						if (54018 - 565987 == -511969)
						{
							this.$self_$45950 = self_;
							if (74209 - 492994 != -418784)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B3E2 RID: 46050 RVA: 0x01388C0C File Offset: 0x01386E0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243263 - 169262 != 74002)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_42D;
					case 1:
						goto IL_49B;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (241873 - 244089 != -2215)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45949.startStoryMessage("none", "FrostPenguin", eTalkType.enemy);
							if (51245 - 499581 != -448336)
							{
								continue;
							}
							goto IL_264;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (22275 - 554731 != -532456)
							{
								continue;
							}
							goto IL_344;
						}
						else
						{
							this.$mStoryGui$45949.newStoryMessage("none", "FrostPenguin", Language.getMessage("M972_IceTower", 701), eTalkType.enemy);
							if (50795 - 96622 != -45826)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (20783 - 583075 != -562292)
							{
								continue;
							}
							goto IL_2FF;
						}
						else
						{
							this.$mStoryGui$45949.newStoryMessage("none", "FrostPenguin", Language.getMessage("M972_IceTower", 702), eTalkType.enemy);
							if (213252 - 166271 != 46982)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (189886 - 510232 != -320346)
							{
								continue;
							}
							goto IL_467;
						}
						else
						{
							this.$self_$45950.camera.SendMessage("resetPlayerCamera");
							if (59385 - 511265 == -451879)
							{
								continue;
							}
							this.$mStoryGui$45949.close();
							if (135850 - 90094 != 45756)
							{
								continue;
							}
							if (this.$self_$45950.qC4n1cAEUgM)
							{
								if (57911 - 99967 != -42056)
								{
									continue;
								}
								this.$self_$45950.qC4n1cAEUgM.enabled = true;
								if (152962 - 535083 != -382121)
								{
									continue;
								}
							}
							this.$mGameGui$45948.enabled = true;
							if (200436 - 40514 != 159922)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (91521 - 425028 != -333507)
							{
								continue;
							}
						}
						break;
					default:
						if (213664 - 505411 != -291746)
						{
							goto IL_42D;
						}
						continue;
					}
					IL_EC:
					this.YieldDefault(1);
					if (232545 - 151142 != 81403)
					{
						continue;
					}
					goto IL_49B;
					IL_42D:
					this.$mGameGui$45948 = (GameGui)this.$self_$45950.GetComponent(typeof(GameGui));
					if (220151 - 337571 != -117419)
					{
						this.$mStoryGui$45949 = (StoryGui)this.$self_$45950.GetComponent(typeof(StoryGui));
						if (51967 - 263542 != -211574)
						{
							if (!this.$mGameGui$45948)
							{
								goto IL_EC;
							}
							if (40291 - 478750 == -438459)
							{
								if (!this.$mStoryGui$45949)
								{
									goto IL_EC;
								}
								if (183140 - 416467 != -233326)
								{
									Game.mGameState = eGameState.AllHold;
									if (216773 - 58331 != 158443)
									{
										this.$mGameGui$45948.close();
										if (127597 - 9330 != 118268)
										{
											if (!this.$self_$45950.qC4n1cAEUgM)
											{
												goto IL_2C4;
											}
											if (41649 - 222687 != -181037)
											{
												this.$self_$45950.qC4n1cAEUgM.StartCoroutine_Auto(this.$self_$45950.qC4n1cAEUgM.slerpToObject("EventCamera1", (float)1));
												if (86122 - 132662 == -46540)
												{
													goto IL_2C4;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_264:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_2C4:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_22:
				IL_2FF:
				goto IL_49B;
				Block_23:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_344:
				goto IL_49B;
				Block_24:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_467:
				IL_49B:
				return false;
			}

			// Token: 0x0600B3E3 RID: 46051 RVA: 0x013890C8 File Offset: 0x013872C8
			internal static bool E7E8nItaAMV5xF0Vgmx8()
			{
				return true;
			}

			// Token: 0x0600B3E4 RID: 46052 RVA: 0x013890CC File Offset: 0x013872CC
			internal static bool TnlTZ1talUqhPiJZXjLD()
			{
				return false;
			}

			// Token: 0x04009CB9 RID: 40121
			internal GameGui $mGameGui$45948;

			// Token: 0x04009CBA RID: 40122
			internal StoryGui $mStoryGui$45949;

			// Token: 0x04009CBB RID: 40123
			internal M972_IceTower7 $self_$45950;
		}
	}

	// Token: 0x02001E12 RID: 7698
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$45952 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B3E5 RID: 46053 RVA: 0x013890D0 File Offset: 0x013872D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$45952(M972_IceTower7 self_)
		{
			if (200300 - 166952 != 33348)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135289 - 436985 != -301695)
				{
					base..ctor();
					if (50652 - 475322 != -424669)
					{
						this.$self_$45964 = self_;
						if (24154 - 580254 == -556100)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x01389168 File Offset: 0x01387368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$EndEvent$45952.$(this.$self_$45964);
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x01389178 File Offset: 0x01387378
		internal static bool yHT54CtaybNotjPfUHN2()
		{
			return true;
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x0138917C File Offset: 0x0138737C
		internal static bool Q9HpUCtaSZ51ZSYjltK9()
		{
			return false;
		}

		// Token: 0x04009CBC RID: 40124
		internal M972_IceTower7 $self_$45964;

		// Token: 0x02001E13 RID: 7699
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B3E9 RID: 46057 RVA: 0x01389180 File Offset: 0x01387380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower7 self_)
			{
				if (174423 - 113727 != 60696)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (199429 - 310279 != -110849)
					{
						base..ctor();
						if (213854 - 254238 == -40384)
						{
							this.$self_$45963 = self_;
							if (65612 - 250006 == -184394)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B3EA RID: 46058 RVA: 0x01389218 File Offset: 0x01387418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225391 - 236334 != -10943)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9D8;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (221197 - 86843 != 134354)
							{
								continue;
							}
							goto IL_707;
						}
						else
						{
							this.$self_$45963.SendMessage("fadeOut");
							if (36939 - 397654 != -360714)
							{
								goto Block_55;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (191573 - 341382 != -149809)
							{
								continue;
							}
							goto IL_827;
						}
						else
						{
							this.$self_$45963.qC4n1cAEUgM.alignToObject("EventCamera2");
							if (67100 - 201413 == -134312)
							{
								continue;
							}
							if (!Game.mPlayer)
							{
								goto IL_FD;
							}
							if (145322 - 202988 != -57666)
							{
								continue;
							}
							this.$startPoint$45954 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 5));
							if (40908 - 186275 == -145366)
							{
								continue;
							}
							if (!this.$startPoint$45954)
							{
								goto IL_FD;
							}
							if (175794 - 564615 != -388821)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$startPoint$45954.transform.position;
							if (292920 - 281662 == 11259)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$startPoint$45954.transform.rotation;
							if (210732 - 542429 != -331697)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (292046 - 492860 != -200814)
							{
								continue;
							}
							goto IL_FD;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (266608 - 408753 != -142144)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$self_$45963.SendMessage("fadeIn");
							if (154165 - 253714 != -99548)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (12705 - 583144 != -570439)
							{
								continue;
							}
							goto IL_793;
						}
						else
						{
							this.$mIceFloor$45955 = GameObject.Find("IceFloor3");
							if (248455 - 230428 != 18027)
							{
								continue;
							}
							if (this.$mIceFloor$45955)
							{
								if (24158 - 523048 != -498890)
								{
									continue;
								}
								this.$mIceFloor$45955.audio.Play();
								if (23427 - 548866 == -525438)
								{
									continue;
								}
								this.$mIceFloorShatter$45956 = (ShatterMesh)this.$mIceFloor$45955.GetComponent(typeof(ShatterMesh));
								if (106120 - 385234 == -279113)
								{
									continue;
								}
								if (this.$mIceFloorShatter$45956)
								{
									if (258772 - 572530 == -313757)
									{
										continue;
									}
									this.$mIceFloorShatter$45956.enabled = true;
									if (162493 - 510186 != -347693)
									{
										continue;
									}
								}
							}
							this.$mIceElevator$45957 = GameObject.Find("IceElevator");
							if (186115 - 218864 == -32748)
							{
								continue;
							}
							if (this.$mIceElevator$45957)
							{
								if (91668 - 220255 != -128587)
								{
									continue;
								}
								this.$mIceElevator$45957.audio.Play();
								if (39532 - 388779 == -349246)
								{
									continue;
								}
							}
							this.$mIceElevatorTimer$45958 = Time.time;
							if (181370 - 238739 != -57368)
							{
								goto IL_3B5;
							}
							continue;
						}
						break;
					case 6:
						goto IL_3B5;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (113902 - 524698 != -410795)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$self_$45963.SendMessage("fadeOut");
							if (161832 - 282618 != -120786)
							{
								continue;
							}
							if (!this.$mIceElevator$45957)
							{
								goto IL_98;
							}
							if (228726 - 335146 == -106419)
							{
								continue;
							}
							this.$mIceElevator$45957.audio.Stop();
							if (176821 - 140307 != 36515)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (122911 - 539289 != -416377)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9721, 8);
							if (179990 - 533577 == -353586)
							{
								continue;
							}
							this.YieldDefault(1);
							if (21221 - 115987 != -94766)
							{
								continue;
							}
							goto IL_9D8;
						}
						break;
					default:
						if (67741 - 196142 == -128400)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (148115 - 125790 != 22325)
					{
						continue;
					}
					this.$mGameGui$45953 = (GameGui)this.$self_$45963.GetComponent(typeof(GameGui));
					if (205024 - 568166 == -363141)
					{
						continue;
					}
					if (!this.$mGameGui$45953)
					{
						goto IL_907;
					}
					if (5947 - 23367 != -17420)
					{
						continue;
					}
					this.$mGameGui$45953.close();
					if (211989 - 96210 != 115779)
					{
						continue;
					}
					goto IL_907;
					IL_3B5:
					if (Time.time >= this.$mIceElevatorTimer$45958 + (float)6)
					{
						if (38799 - 516835 == -478036)
						{
							if (!this.$mIceFloor$45955)
							{
								goto IL_631;
							}
							if (251625 - 95354 != 156272)
							{
								UnityEngine.Object.Destroy(this.$mIceFloor$45955);
								if (132393 - 233005 == -100612)
								{
									goto IL_631;
								}
							}
						}
					}
					else
					{
						if (!this.$mIceElevator$45957)
						{
							goto IL_3A9;
						}
						if (125535 - 504407 == -378872)
						{
							this.$$14884$45959 = (float)59 + 1.5f * (Time.time - this.$mIceElevatorTimer$45958);
							if (91239 - 513622 != -422382)
							{
								if (191223 - 118119 == 73104)
								{
									this.$$14885$45960 = this.$mIceElevator$45957.transform.position;
									if (215634 - 263587 == -47953)
									{
										if (152252 - 94801 != 57452)
										{
											this.$$14885$45960.y = this.$$14884$45959;
											if (38212 - 598594 == -560382)
											{
												if (72163 - 453906 != -381742)
												{
													Vector3 vector = this.$mIceElevator$45957.transform.position = this.$$14885$45960;
													if (227719 - 218493 != 9227)
													{
														if (209733 - 526747 == -317014)
														{
															this.$$14886$45961 = (float)45 * (Time.time - this.$mIceElevatorTimer$45958);
															if (114739 - 50163 != 64577 && 285939 - 519777 != -233837)
															{
																this.$$14887$45962 = this.$mIceElevator$45957.transform.eulerAngles;
																if (138648 - 300868 == -162220)
																{
																	if (70912 - 476635 != -405722)
																	{
																		float num = this.$$14887$45962.y = this.$$14886$45961;
																		if (169431 - 426296 == -256865)
																		{
																			if (68324 - 28347 == 39977)
																			{
																				Vector3 vector2 = this.$mIceElevator$45957.transform.eulerAngles = this.$$14887$45962;
																				if (71449 - 249267 == -177818)
																				{
																					if (266765 - 69396 == 197369)
																					{
																						goto IL_3A9;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_98:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_6:
				goto IL_9D8;
				IL_FD:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_10:
				goto IL_9D8;
				Block_15:
				goto IL_98;
				IL_3A9:
				return this.YieldDefault(6);
				IL_631:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_49:
				IL_707:
				goto IL_9D8;
				Block_55:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_793:
				IL_827:
				goto IL_9D8;
				IL_907:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_9D8:
				return false;
			}

			// Token: 0x0600B3EB RID: 46059 RVA: 0x01389C10 File Offset: 0x01387E10
			internal static bool rsinGPtao5UA6WAumIo6()
			{
				return true;
			}

			// Token: 0x0600B3EC RID: 46060 RVA: 0x01389C14 File Offset: 0x01387E14
			internal static bool ubZEU3taENEJGN8tfKOI()
			{
				return false;
			}

			// Token: 0x04009CBD RID: 40125
			internal GameGui $mGameGui$45953;

			// Token: 0x04009CBE RID: 40126
			internal GameObject $startPoint$45954;

			// Token: 0x04009CBF RID: 40127
			internal GameObject $mIceFloor$45955;

			// Token: 0x04009CC0 RID: 40128
			internal ShatterMesh $mIceFloorShatter$45956;

			// Token: 0x04009CC1 RID: 40129
			internal GameObject $mIceElevator$45957;

			// Token: 0x04009CC2 RID: 40130
			internal float $mIceElevatorTimer$45958;

			// Token: 0x04009CC3 RID: 40131
			internal float $$14884$45959;

			// Token: 0x04009CC4 RID: 40132
			internal Vector3 $$14885$45960;

			// Token: 0x04009CC5 RID: 40133
			internal float $$14886$45961;

			// Token: 0x04009CC6 RID: 40134
			internal Vector3 $$14887$45962;

			// Token: 0x04009CC7 RID: 40135
			internal M972_IceTower7 $self_$45963;
		}
	}

	// Token: 0x02001E14 RID: 7700
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OpenIceGate$45965 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B3ED RID: 46061 RVA: 0x01389C18 File Offset: 0x01387E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OpenIceGate$45965(int nID)
		{
			if (133548 - 419280 != -285732)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99531 - 350166 == -250635)
				{
					base..ctor();
					if (141442 - 199790 != -58347)
					{
						this.$nID$45968 = nID;
						if (121871 - 327128 == -205257)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x01389CB0 File Offset: 0x01387EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$OpenIceGate$45965.$(this.$nID$45968);
		}

		// Token: 0x0600B3EF RID: 46063 RVA: 0x01389CC0 File Offset: 0x01387EC0
		internal static bool U1EJ6bta2iY7QGkSZJhb()
		{
			return true;
		}

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x01389CC4 File Offset: 0x01387EC4
		internal static bool wALL6Qta8NxdLHrNYFD0()
		{
			return false;
		}

		// Token: 0x04009CC8 RID: 40136
		internal int $nID$45968;

		// Token: 0x02001E15 RID: 7701
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B3F1 RID: 46065 RVA: 0x01389CC8 File Offset: 0x01387EC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nID)
			{
				if (161792 - 260787 != -98994)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235176 - 456105 == -220929)
					{
						base..ctor();
						if (165819 - 141711 == 24108)
						{
							this.$nID$45967 = nID;
							if (171935 - 525483 != -353547)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B3F2 RID: 46066 RVA: 0x01389D60 File Offset: 0x01387F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260607 - 205529 != 55078)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_190;
					case 2:
						if (this.$mIceGate$45966)
						{
							if (132352 - 517325 == -384972)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mIceGate$45966);
							if (153569 - 272445 == -118875)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (18551 - 489297 != -470745)
						{
							goto IL_190;
						}
						continue;
					default:
						if (118203 - 411232 != -293029)
						{
							continue;
						}
						break;
					}
					this.$mIceGate$45966 = GameObject.Find("IceTowerGate" + this.$nID$45967);
					if (150496 - 28027 != 122470)
					{
						if (!this.$mIceGate$45966)
						{
							break;
						}
						if (262531 - 6659 != 255873)
						{
							if (this.$mIceGate$45966.animation.isPlaying)
							{
								break;
							}
							if (44779 - 563585 == -518806)
							{
								this.$mIceGate$45966.animation.Play();
								if (287745 - 231050 != 56696)
								{
									break;
								}
							}
						}
					}
				}
				IL_49:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_49;
				IL_190:
				return false;
			}

			// Token: 0x0600B3F3 RID: 46067 RVA: 0x01389F10 File Offset: 0x01388110
			internal static bool Yfem1ntaZ2AjIRYY9eXv()
			{
				return true;
			}

			// Token: 0x0600B3F4 RID: 46068 RVA: 0x01389F14 File Offset: 0x01388114
			internal static bool tCjfdotaCL0maFBAiOqv()
			{
				return false;
			}

			// Token: 0x04009CC9 RID: 40137
			internal GameObject $mIceGate$45966;

			// Token: 0x04009CCA RID: 40138
			internal int $nID$45967;
		}
	}

	// Token: 0x02001E16 RID: 7702
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45969 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B3F5 RID: 46069 RVA: 0x01389F18 File Offset: 0x01388118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45969(M972_IceTower7 self_)
		{
			if (14889 - 349184 != -334295)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (274780 - 150648 != 124133)
				{
					base..ctor();
					if (96049 - 257700 != -161650)
					{
						this.$self_$45972 = self_;
						if (181035 - 281826 != -100790)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B3F6 RID: 46070 RVA: 0x01389FB0 File Offset: 0x013881B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$StartGame$45969.$(this.$self_$45972);
		}

		// Token: 0x0600B3F7 RID: 46071 RVA: 0x01389FC0 File Offset: 0x013881C0
		internal static bool yEFPq8taLYrLCLq7YuiM()
		{
			return true;
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x01389FC4 File Offset: 0x013881C4
		internal static bool iryBOrtaOKYxcCttmj1d()
		{
			return false;
		}

		// Token: 0x04009CCB RID: 40139
		internal M972_IceTower7 $self_$45972;

		// Token: 0x02001E17 RID: 7703
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B3F9 RID: 46073 RVA: 0x01389FC8 File Offset: 0x013881C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower7 self_)
			{
				if (273364 - 33643 != 239721)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (285878 - 116004 != 169875)
					{
						base..ctor();
						if (103762 - 120721 == -16959)
						{
							this.$self_$45971 = self_;
							if (297318 - 595390 == -298072)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B3FA RID: 46074 RVA: 0x0138A060 File Offset: 0x01388260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256990 - 178349 != 78642)
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
						if (216464 - 210210 != 6254)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (95346 - 192926 == -97579)
						{
							continue;
						}
						this.YieldDefault(1);
						if (133618 - 459970 != -326352)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (144540 - 460844 != -316304)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (24386 - 499915 != -475528)
					{
						Game.mGameState = eGameState.Start;
						if (125312 - 11849 != 113464)
						{
							Game.mStateTime = Time.time;
							if (222069 - 376261 == -154192)
							{
								this.$mGameGui$45970 = (GameGui)this.$self_$45971.GetComponent(typeof(GameGui));
								if (30966 - 209685 == -178719)
								{
									this.$mGameGui$45970.enabled = true;
									if (20378 - 257317 == -236939)
									{
										this.$self_$45971.SendMessage("fadeIn");
										if (221390 - 420011 == -198621)
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

			// Token: 0x0600B3FB RID: 46075 RVA: 0x0138A238 File Offset: 0x01388438
			internal static bool kEKkJptamgL66Ir8lxRT()
			{
				return true;
			}

			// Token: 0x0600B3FC RID: 46076 RVA: 0x0138A23C File Offset: 0x0138843C
			internal static bool nA5HmLtaFJOuFSdRKLDd()
			{
				return false;
			}

			// Token: 0x04009CCC RID: 40140
			internal GameGui $mGameGui$45970;

			// Token: 0x04009CCD RID: 40141
			internal M972_IceTower7 $self_$45971;
		}
	}

	// Token: 0x02001E18 RID: 7704
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45973 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B3FD RID: 46077 RVA: 0x0138A240 File Offset: 0x01388440
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45973(M972_IceTower7 self_)
		{
			if (262045 - 300432 != -38386)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221406 - 318746 != -97339)
				{
					base..ctor();
					if (207289 - 288049 != -80759)
					{
						this.$self_$45978 = self_;
						if (63291 - 373671 != -310379)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B3FE RID: 46078 RVA: 0x0138A2D8 File Offset: 0x013884D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$onDeadPlayer$45973.$(this.$self_$45978);
		}

		// Token: 0x0600B3FF RID: 46079 RVA: 0x0138A2E8 File Offset: 0x013884E8
		internal static bool FGBfmVtaMrf1HhJWYYVG()
		{
			return true;
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x0138A2EC File Offset: 0x013884EC
		internal static bool vjofxltax0JD4TKeAlSp()
		{
			return false;
		}

		// Token: 0x04009CCE RID: 40142
		internal M972_IceTower7 $self_$45978;

		// Token: 0x02001E19 RID: 7705
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B401 RID: 46081 RVA: 0x0138A2F0 File Offset: 0x013884F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower7 self_)
			{
				if (275163 - 113015 != 162148)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264838 - 284696 != -19857)
					{
						base..ctor();
						if (241553 - 509415 == -267862)
						{
							this.$self_$45977 = self_;
							if (73291 - 563696 != -490404)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B402 RID: 46082 RVA: 0x0138A388 File Offset: 0x01388588
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (261568 - 324804 != -63236)
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
							goto IL_2D9;
						}
						if (117228 - 48958 == 68271)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (42786 - 15679 != 27107)
							{
								continue;
							}
							goto IL_2D9;
						}
						IL_52:
						this.YieldDefault(1);
						if (186562 - 529841 != -343278)
						{
							goto Block_4;
						}
						continue;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (74122 - 29177 == 44946)
						{
							continue;
						}
						this.$mStoryGui$45974 = (StoryGui)this.$self_$45977.GetComponent(typeof(StoryGui));
						if (87684 - 277751 != -190067)
						{
							continue;
						}
						if (this.$mStoryGui$45974)
						{
							if (242145 - 45209 != 196936)
							{
								continue;
							}
							this.$mStoryGui$45974.close();
							if (72147 - 595990 == -523842)
							{
								continue;
							}
						}
						this.$mChangeGui$45975 = (ChangeGui)this.$self_$45977.GetComponent(typeof(ChangeGui));
						if (177077 - 106177 != 70900)
						{
							continue;
						}
						if (this.$mChangeGui$45975)
						{
							if (26843 - 209077 != -182234)
							{
								continue;
							}
							this.$mChangeGui$45975.close();
							if (51730 - 10422 == 41309)
							{
								continue;
							}
						}
						this.$mGameGui$45976 = (GameGui)this.$self_$45977.GetComponent(typeof(GameGui));
						if (101733 - 222082 != -120349)
						{
							continue;
						}
						if (!this.$mGameGui$45976)
						{
							goto IL_52;
						}
						if (250262 - 8178 != 242084)
						{
							continue;
						}
						if (!this.$mGameGui$45976.enabled)
						{
							if (27411 - 430697 == -403285)
							{
								continue;
							}
							this.$mGameGui$45976.enabled = true;
							if (191162 - 348843 == -157680)
							{
								continue;
							}
						}
						this.$mGameGui$45976.openDeadMenu();
						if (268153 - 166865 != 101289)
						{
							goto IL_52;
						}
						continue;
					default:
						if (46156 - 218703 == -172546)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (274747 - 497516 != -222768)
					{
						goto Block_11;
					}
				}
				Block_4:
				goto IL_2F9;
				Block_11:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B403 RID: 46083 RVA: 0x0138A6A0 File Offset: 0x013888A0
			internal static bool c3QvyWtagZfOik0GJ1E8()
			{
				return true;
			}

			// Token: 0x0600B404 RID: 46084 RVA: 0x0138A6A4 File Offset: 0x013888A4
			internal static bool H9Qv4StafNFHTB4VId1l()
			{
				return false;
			}

			// Token: 0x04009CCF RID: 40143
			internal StoryGui $mStoryGui$45974;

			// Token: 0x04009CD0 RID: 40144
			internal ChangeGui $mChangeGui$45975;

			// Token: 0x04009CD1 RID: 40145
			internal GameGui $mGameGui$45976;

			// Token: 0x04009CD2 RID: 40146
			internal M972_IceTower7 $self_$45977;
		}
	}

	// Token: 0x02001E1A RID: 7706
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45979 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B405 RID: 46085 RVA: 0x0138A6A8 File Offset: 0x013888A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45979(Hashtable data, M972_IceTower7 self_)
		{
			if (264898 - 266427 != -1528)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (93703 - 567632 == -473929)
				{
					base..ctor();
					if (265331 - 4859 == 260472)
					{
						this.$data$45984 = data;
						if (81432 - 568090 != -486657)
						{
							this.$self_$45985 = self_;
							if (63744 - 363391 != -299646)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B406 RID: 46086 RVA: 0x0138A764 File Offset: 0x01388964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$onChangePlayer$45979.$(this.$data$45984, this.$self_$45985);
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x0138A778 File Offset: 0x01388978
		internal static bool q9xJd0tana7FKN5mb5VL()
		{
			return true;
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x0138A77C File Offset: 0x0138897C
		internal static bool EtcDPGta69MIQTvO5QVy()
		{
			return false;
		}

		// Token: 0x04009CD3 RID: 40147
		internal Hashtable $data$45984;

		// Token: 0x04009CD4 RID: 40148
		internal M972_IceTower7 $self_$45985;

		// Token: 0x02001E1B RID: 7707
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B409 RID: 46089 RVA: 0x0138A780 File Offset: 0x01388980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower7 self_)
			{
				if (37837 - 367634 != -329796)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11029 - 237857 != -226827)
					{
						base..ctor();
						if (16214 - 185834 != -169619)
						{
							this.$data$45982 = data;
							if (240761 - 264774 == -24013)
							{
								this.$self_$45983 = self_;
								if (90797 - 59768 != 31030)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B40A RID: 46090 RVA: 0x0138A83C File Offset: 0x01388A3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101824 - 425375 != -323551)
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
							if (45150 - 48624 != -3474)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (9218 - 60412 == -51193)
							{
								continue;
							}
							this.$mGameGui$45981 = (GameGui)this.$self_$45983.GetComponent(typeof(GameGui));
							if (203295 - 160583 != 42712)
							{
								continue;
							}
							this.$mGameGui$45981.enabled = true;
							if (261057 - 391662 == -130604)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (167555 - 277803 != -110248)
						{
							continue;
						}
						goto IL_205;
					default:
						if (17728 - 167570 != -149842)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (20635 - 59601 != -38965)
					{
						this.$self_$45983.SendMessage("onCreatePlayer", this.$data$45982);
						if (223140 - 264371 == -41231)
						{
							this.$mChangeGui$45980 = (ChangeGui)this.$self_$45983.GetComponent(typeof(ChangeGui));
							if (1014 - 564193 != -563178)
							{
								if (!this.$mChangeGui$45980.enabled)
								{
									break;
								}
								if (86035 - 387619 == -301584)
								{
									this.$mChangeGui$45980.close();
									if (38389 - 143312 == -104923)
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

			// Token: 0x0600B40B RID: 46091 RVA: 0x0138AA60 File Offset: 0x01388C60
			internal static bool rvqSZptaiUE9278me34F()
			{
				return true;
			}

			// Token: 0x0600B40C RID: 46092 RVA: 0x0138AA64 File Offset: 0x01388C64
			internal static bool wMXGUrtaKbyV29wrV75h()
			{
				return false;
			}

			// Token: 0x04009CD5 RID: 40149
			internal ChangeGui $mChangeGui$45980;

			// Token: 0x04009CD6 RID: 40150
			internal GameGui $mGameGui$45981;

			// Token: 0x04009CD7 RID: 40151
			internal Hashtable $data$45982;

			// Token: 0x04009CD8 RID: 40152
			internal M972_IceTower7 $self_$45983;
		}
	}

	// Token: 0x02001E1C RID: 7708
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45986 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B40D RID: 46093 RVA: 0x0138AA68 File Offset: 0x01388C68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45986(Hashtable data, M972_IceTower7 self_)
		{
			if (99132 - 541212 != -442080)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112783 - 328104 == -215321)
				{
					base..ctor();
					if (17753 - 303322 != -285568)
					{
						this.$data$45994 = data;
						if (260763 - 530957 == -270194)
						{
							this.$self_$45995 = self_;
							if (257060 - 79287 != 177774)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x0138AB24 File Offset: 0x01388D24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$onGameComplete$45986.$(this.$data$45994, this.$self_$45995);
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x0138AB38 File Offset: 0x01388D38
		internal static bool xRtoTUtadCbOXnDUtl7R()
		{
			return true;
		}

		// Token: 0x0600B410 RID: 46096 RVA: 0x0138AB3C File Offset: 0x01388D3C
		internal static bool PHBxb2taJkNqkkyKZsvA()
		{
			return false;
		}

		// Token: 0x04009CD9 RID: 40153
		internal Hashtable $data$45994;

		// Token: 0x04009CDA RID: 40154
		internal M972_IceTower7 $self_$45995;

		// Token: 0x02001E1D RID: 7709
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B411 RID: 46097 RVA: 0x0138AB40 File Offset: 0x01388D40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower7 self_)
			{
				if (298014 - 290775 != 7239)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (72466 - 415729 != -343262)
					{
						base..ctor();
						if (245734 - 221304 != 24431)
						{
							this.$data$45992 = data;
							if (236369 - 342554 == -106185)
							{
								this.$self_$45993 = self_;
								if (93973 - 10512 == 83461)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B412 RID: 46098 RVA: 0x0138ABFC File Offset: 0x01388DFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (126115 - 174311 != -48195)
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
						this.$mCompleteGui$45988 = (CompleteGui)this.$self_$45993.GetComponent(typeof(CompleteGui));
						if (178204 - 376280 != -198076)
						{
							continue;
						}
						this.$mCompleteGui$45988.Init();
						if (152573 - 341007 == -188433)
						{
							continue;
						}
						this.$mCompleteGui$45988.readData(this.$data$45992);
						if (187660 - 420644 == -232983)
						{
							continue;
						}
						if (this.$result$45987 == 1)
						{
							if (160035 - 116022 != 44013)
							{
								continue;
							}
							this.$mCompleteGui$45988.displayResult(eCompleteType.Success);
							if (240296 - 464527 == -224230)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45988.displayResult(eCompleteType.Failed);
							if (144161 - 514701 != -370540)
							{
								continue;
							}
						}
						this.$mGameGui$45989 = (GameGui)this.$self_$45993.GetComponent(typeof(GameGui));
						if (113539 - 147031 != -33492)
						{
							continue;
						}
						this.$mStoryGui$45990 = (StoryGui)this.$self_$45993.GetComponent(typeof(StoryGui));
						if (295093 - 307324 == -12230)
						{
							continue;
						}
						this.$mChangeGui$45991 = (ChangeGui)this.$self_$45993.GetComponent(typeof(ChangeGui));
						if (294804 - 301840 == -7035)
						{
							continue;
						}
						if (this.$mGameGui$45989)
						{
							if (78467 - 147598 == -69130)
							{
								continue;
							}
							this.$mGameGui$45989.close();
							if (256938 - 122602 != 134336)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45990)
						{
							if (14639 - 523061 != -508422)
							{
								continue;
							}
							this.$mStoryGui$45990.close();
							if (246675 - 112966 != 133709)
							{
								continue;
							}
						}
						if (this.$mChangeGui$45991)
						{
							if (63121 - 72322 != -9201)
							{
								continue;
							}
							this.$mChangeGui$45991.disable();
							if (75212 - 365709 != -290497)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (168860 - 384102 != -215241)
						{
							goto Block_12;
						}
						continue;
					default:
						if (298709 - 243284 == 55426)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45992[31]);
					if (213440 - 282064 == -68624)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (224329 - 66490 != 157840)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (200524 - 295862 == -95338)
							{
								this.$result$45987 = RuntimeServices.UnboxInt32(this.$data$45992[31]);
								if (57426 - 263581 == -206155)
								{
									goto IL_38B;
								}
							}
						}
					}
				}
				Block_12:
				goto IL_3DB;
				IL_38B:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B413 RID: 46099 RVA: 0x0138AFF8 File Offset: 0x013891F8
			internal static bool Es04cltaDeMGl8liTEAo()
			{
				return true;
			}

			// Token: 0x0600B414 RID: 46100 RVA: 0x0138AFFC File Offset: 0x013891FC
			internal static bool nJ7VoJtavRjghRYaj7Lc()
			{
				return false;
			}

			// Token: 0x04009CDB RID: 40155
			internal int $result$45987;

			// Token: 0x04009CDC RID: 40156
			internal CompleteGui $mCompleteGui$45988;

			// Token: 0x04009CDD RID: 40157
			internal GameGui $mGameGui$45989;

			// Token: 0x04009CDE RID: 40158
			internal StoryGui $mStoryGui$45990;

			// Token: 0x04009CDF RID: 40159
			internal ChangeGui $mChangeGui$45991;

			// Token: 0x04009CE0 RID: 40160
			internal Hashtable $data$45992;

			// Token: 0x04009CE1 RID: 40161
			internal M972_IceTower7 $self_$45993;
		}
	}

	// Token: 0x02001E1E RID: 7710
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45996 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B415 RID: 46101 RVA: 0x0138B000 File Offset: 0x01389200
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45996(M972_IceTower7 self_)
		{
			if (135737 - 259018 != -123281)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163176 - 212068 != -48891)
				{
					base..ctor();
					if (145340 - 4918 != 140423)
					{
						this.$self_$46000 = self_;
						if (26188 - 213836 == -187648)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B416 RID: 46102 RVA: 0x0138B098 File Offset: 0x01389298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$ReturnToTown$45996.$(this.$self_$46000);
		}

		// Token: 0x0600B417 RID: 46103 RVA: 0x0138B0A8 File Offset: 0x013892A8
		internal static bool fsavLqtaRJAMuvTFJghq()
		{
			return true;
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x0138B0AC File Offset: 0x013892AC
		internal static bool NV1h8RtawAQjOfAftoUh()
		{
			return false;
		}

		// Token: 0x04009CE2 RID: 40162
		internal M972_IceTower7 $self_$46000;

		// Token: 0x02001E1F RID: 7711
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B419 RID: 46105 RVA: 0x0138B0B0 File Offset: 0x013892B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower7 self_)
			{
				if (62409 - 12091 != 50318)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132513 - 169421 == -36908)
					{
						base..ctor();
						if (188601 - 187263 != 1339)
						{
							this.$self_$45999 = self_;
							if (19934 - 123468 != -103533)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B41A RID: 46106 RVA: 0x0138B148 File Offset: 0x01389348
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281307 - 224654 != 56654)
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
						this.$self_$45999.LeaveGame();
						if (196763 - 372829 != -176066)
						{
							continue;
						}
						this.YieldDefault(1);
						if (185078 - 16821 != 168257)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (54975 - 444318 == -389342)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (252270 - 422731 != -170460)
					{
						Game.mStateTime = Time.time;
						if (109913 - 377882 == -267969)
						{
							this.$$switch$8584$45997 = PlayerData.SaveGuild;
							if (200574 - 409253 == -208679)
							{
								if (this.$$switch$8584$45997 == 1)
								{
									if (32977 - 576100 != -543123)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (272355 - 501561 != -229206)
									{
										continue;
									}
								}
								else if (this.$$switch$8584$45997 == 2)
								{
									if (221731 - 43831 == 177901)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (251239 - 463354 == -212114)
									{
										continue;
									}
								}
								else if (this.$$switch$8584$45997 == 3)
								{
									if (171125 - 235739 == -64613)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (69808 - 371282 == -301473)
									{
										continue;
									}
								}
								else if (this.$$switch$8584$45997 == 4)
								{
									if (293240 - 184772 == 108469)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (123900 - 169441 != -45541)
									{
										continue;
									}
								}
								else if (this.$$switch$8584$45997 == 5)
								{
									if (87746 - 580148 != -492402)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (239554 - 308872 != -69318)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (9851 - 373027 == -363175)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (213258 - 591299 == -378040)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (274549 - 315371 == -40821)
									{
										continue;
									}
								}
								this.$mGameGui$45998 = (GameGui)this.$self_$45999.GetComponent(typeof(GameGui));
								if (48667 - 303839 != -255171)
								{
									if (this.$mGameGui$45998)
									{
										if (173320 - 316592 == -143271)
										{
											continue;
										}
										this.$mGameGui$45998.close();
										if (220400 - 67857 == 152544)
										{
											continue;
										}
									}
									this.$self_$45999.SendMessage("fadeOut");
									if (73832 - 62700 != 11133)
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

			// Token: 0x0600B41B RID: 46107 RVA: 0x0138B514 File Offset: 0x01389714
			internal static bool PMvy8OtaqaCuZTnK8A6o()
			{
				return true;
			}

			// Token: 0x0600B41C RID: 46108 RVA: 0x0138B518 File Offset: 0x01389718
			internal static bool E2FK84ta7FjgOWtjqrqh()
			{
				return false;
			}

			// Token: 0x04009CE3 RID: 40163
			internal int $$switch$8584$45997;

			// Token: 0x04009CE4 RID: 40164
			internal GameGui $mGameGui$45998;

			// Token: 0x04009CE5 RID: 40165
			internal M972_IceTower7 $self_$45999;
		}
	}

	// Token: 0x02001E20 RID: 7712
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46001 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B41D RID: 46109 RVA: 0x0138B51C File Offset: 0x0138971C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46001(M972_IceTower7 self_)
		{
			if (48557 - 282355 != -233797)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57432 - 237688 != -180255)
				{
					base..ctor();
					if (262441 - 594264 == -331823)
					{
						this.$self_$46004 = self_;
						if (61387 - 269424 == -208037)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x0138B5B4 File Offset: 0x013897B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$ReturnToGuild$46001.$(this.$self_$46004);
		}

		// Token: 0x0600B41F RID: 46111 RVA: 0x0138B5C4 File Offset: 0x013897C4
		internal static bool PTNWkptaPZPmTSSMTcUO()
		{
			return true;
		}

		// Token: 0x0600B420 RID: 46112 RVA: 0x0138B5C8 File Offset: 0x013897C8
		internal static bool hSq17uta0E1qVSyQDoxJ()
		{
			return false;
		}

		// Token: 0x04009CE6 RID: 40166
		internal M972_IceTower7 $self_$46004;

		// Token: 0x02001E21 RID: 7713
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B421 RID: 46113 RVA: 0x0138B5CC File Offset: 0x013897CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower7 self_)
			{
				if (88545 - 162171 != -73626)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243603 - 590917 == -347314)
					{
						base..ctor();
						if (17400 - 451952 != -434551)
						{
							this.$self_$46003 = self_;
							if (43864 - 529991 == -486127)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B422 RID: 46114 RVA: 0x0138B664 File Offset: 0x01389864
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10778 - 526185 != -515406)
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
						this.$self_$46003.LeaveGame();
						if (294846 - 98146 != 196700)
						{
							continue;
						}
						this.YieldDefault(1);
						if (40559 - 21037 != 19522)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (279933 - 267209 == 12725)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (280149 - 7731 == 272418)
					{
						Game.mStateTime = Time.time;
						if (231321 - 202440 != 28882)
						{
							Game.mNextGameCode = 31;
							if (251766 - 123012 != 128755)
							{
								this.$mGameGui$46002 = (GameGui)this.$self_$46003.GetComponent(typeof(GameGui));
								if (174479 - 581352 == -406873)
								{
									if (this.$mGameGui$46002)
									{
										if (223442 - 127976 == 95467)
										{
											continue;
										}
										this.$mGameGui$46002.close();
										if (195918 - 160893 != 35025)
										{
											continue;
										}
									}
									this.$self_$46003.SendMessage("fadeOut");
									if (104376 - 319728 == -215352)
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

			// Token: 0x0600B423 RID: 46115 RVA: 0x0138B840 File Offset: 0x01389A40
			internal static bool O8T5W4tabJ2IhJ9d2JjX()
			{
				return true;
			}

			// Token: 0x0600B424 RID: 46116 RVA: 0x0138B844 File Offset: 0x01389A44
			internal static bool axaMbstaurL2Wo8HsevD()
			{
				return false;
			}

			// Token: 0x04009CE7 RID: 40167
			internal GameGui $mGameGui$46002;

			// Token: 0x04009CE8 RID: 40168
			internal M972_IceTower7 $self_$46003;
		}
	}

	// Token: 0x02001E22 RID: 7714
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46005 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B425 RID: 46117 RVA: 0x0138B848 File Offset: 0x01389A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46005(M972_IceTower7 self_)
		{
			if (202660 - 460699 != -258038)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42128 - 563867 == -521739)
				{
					base..ctor();
					if (271649 - 216802 == 54847)
					{
						this.$self_$46008 = self_;
						if (285854 - 227962 != 57893)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x0138B8E0 File Offset: 0x01389AE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower7.$ReturnToCamp$46005.$(this.$self_$46008);
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x0138B8F0 File Offset: 0x01389AF0
		internal static bool UiBgaitaIwB2eYoXiSni()
		{
			return true;
		}

		// Token: 0x0600B428 RID: 46120 RVA: 0x0138B8F4 File Offset: 0x01389AF4
		internal static bool dWZFuWtaBBRLN0sjVqkY()
		{
			return false;
		}

		// Token: 0x04009CE9 RID: 40169
		internal M972_IceTower7 $self_$46008;

		// Token: 0x02001E23 RID: 7715
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B429 RID: 46121 RVA: 0x0138B8F8 File Offset: 0x01389AF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower7 self_)
			{
				if (279958 - 485578 != -205619)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (224429 - 295780 != -71350)
					{
						base..ctor();
						if (87134 - 560063 == -472929)
						{
							this.$self_$46007 = self_;
							if (32032 - 314695 != -282662)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B42A RID: 46122 RVA: 0x0138B990 File Offset: 0x01389B90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5657 - 197827 != -192169)
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
						this.$self_$46007.LeaveGame();
						if (166883 - 147648 == 19236)
						{
							continue;
						}
						this.YieldDefault(1);
						if (23567 - 507907 != -484340)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (166965 - 51197 == 115769)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (15555 - 196670 != -181114)
					{
						Game.mStateTime = Time.time;
						if (19567 - 103770 == -84203)
						{
							Game.mNextGameCode = 32;
							if (196774 - 80128 != 116647)
							{
								this.$mGameGui$46006 = (GameGui)this.$self_$46007.GetComponent(typeof(GameGui));
								if (253156 - 108985 != 144172)
								{
									if (this.$mGameGui$46006)
									{
										if (48813 - 467920 != -419107)
										{
											continue;
										}
										this.$mGameGui$46006.close();
										if (269695 - 574965 != -305270)
										{
											continue;
										}
									}
									this.$self_$46007.SendMessage("fadeOut");
									if (157501 - 298526 != -141024)
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

			// Token: 0x0600B42B RID: 46123 RVA: 0x0138BB6C File Offset: 0x01389D6C
			internal static bool SNsruDtaejw9c83oViKu()
			{
				return true;
			}

			// Token: 0x0600B42C RID: 46124 RVA: 0x0138BB70 File Offset: 0x01389D70
			internal static bool sRJus4tarPw2q6Kkg2TM()
			{
				return false;
			}

			// Token: 0x04009CEA RID: 40170
			internal GameGui $mGameGui$46006;

			// Token: 0x04009CEB RID: 40171
			internal M972_IceTower7 $self_$46007;
		}
	}
}
