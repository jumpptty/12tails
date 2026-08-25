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

// Token: 0x02001E24 RID: 7716
[Serializable]
public class M972_IceTower8 : MonoBehaviour
{
	// Token: 0x0600B42D RID: 46125 RVA: 0x0138BB74 File Offset: 0x01389D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower8()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B42E RID: 46126 RVA: 0x0138BB84 File Offset: 0x01389D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (43116 - 88972 != -45855)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (139038 - 26198 == 112840)
			{
				Game.mGameType = 5;
				if (298982 - 388778 == -89796)
				{
					if (Chat.Initialized)
					{
						if (115721 - 341261 == -225540)
						{
							Chat.ChatDisplay.Clear();
							if (52339 - 419697 != -367357)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (80228 - 85086 == -4858)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B42F RID: 46127 RVA: 0x0138BC68 File Offset: 0x01389E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (12782 - 455393 != -442610)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (135409 - 140168 != -4758)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (157073 - 339597 == -182524)
					{
						if (Game.mGameStage != 8)
						{
							break;
						}
						if (221234 - 270003 == -48769)
						{
							Game.nextGame();
							if (240487 - 143366 == 97121)
							{
								Game.mGameCode = 972;
								if (219668 - 484726 == -265058)
								{
									Game.mGameType = 5;
									if (190007 - 304881 == -114874)
									{
										Game.mStateTime = Time.time;
										if (272786 - 203911 == 68875)
										{
											Game.canRespawn = false;
											if (288137 - 86179 != 201959)
											{
												Game.canUseItem = true;
												if (208441 - 152196 != 56246)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (206620 - 575880 != -369259)
													{
														this.JIUn16WTnW1 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (253497 - 560100 == -306603)
														{
															this.VlZn1J37Yrg = PhotonClient.Connection;
															if (13560 - 206585 == -193025)
															{
																PhotonClient.ActorNrList.Clear();
																if (25431 - 329293 != -303861)
																{
																	this.InitGame();
																	if (290416 - 296395 == -5979)
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
				if (8466 - 234312 != -225845)
				{
					Game.mGameType = 99;
					if (109497 - 352848 == -243351)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B430 RID: 46128 RVA: 0x0138BEF0 File Offset: 0x0138A0F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (271266 - 212574 != 58692)
		{
		}
		for (;;)
		{
			if (this.VlZn1J37Yrg == null)
			{
				if (64903 - 21458 == 43445)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (171389 - 427082 == -255693)
				{
					if (mGameState == eGameState.Init)
					{
						if (196167 - 114128 == 82039)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (142526 - 575670 != -433143)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (218651 - 134151 != 84501)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (44565 - 123241 != -78675)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (207098 - 402486 == -195388)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (82928 - 143651 != -60722)
						{
							if (Game.music != 0)
							{
								if (228524 - 387274 == -158749)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (171635 - 224439 != -52804)
									{
										continue;
									}
									this.audio.Play();
									if (260042 - 592645 == -332602)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (218837 - 224404 != -5567)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (88825 - 71674 == 17152)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (4520 - 100864 != -96344)
								{
									continue;
								}
							}
							if (Time.time <= this.aIon1trM9Bs)
							{
								break;
							}
							if (179213 - 153534 == 25679)
							{
								Game.mGameMana++;
								if (253677 - 105757 != 147921)
								{
									this.aIon1trM9Bs = Time.time + (float)12;
									if (56577 - 103231 != -46653)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (139661 - 294480 == -154819)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (1292 - 69893 != -68600)
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
						if (71058 - 558449 != -487390)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B431 RID: 46129 RVA: 0x0138C264 File Offset: 0x0138A464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower8.$onGameEvent$46009(data, this).GetEnumerator();
	}

	// Token: 0x0600B432 RID: 46130 RVA: 0x0138C274 File Offset: 0x0138A474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnIceChar(string nType, int nSpawnID)
	{
		if (99531 - 556044 != -456513)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (135502 - 189274 == -53772)
			{
				if (gameObject)
				{
					if (242369 - 439669 != -197299)
					{
						this.createActor(nType, 8, gameObject.transform.position, gameObject.transform.forward);
						if (129660 - 118035 == 11625)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (143934 - 118397 != 25538)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B433 RID: 46131 RVA: 0x0138C370 File Offset: 0x0138A570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M972_IceTower8.$EndEvent$46021(this).GetEnumerator();
	}

	// Token: 0x0600B434 RID: 46132 RVA: 0x0138C380 File Offset: 0x0138A580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseIceGate(int nID)
	{
		Game.sendMissionEvent(9724, nID);
	}

	// Token: 0x0600B435 RID: 46133 RVA: 0x0138C390 File Offset: 0x0138A590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OpenIceGate(int nID)
	{
		return new M972_IceTower8.$OpenIceGate$46034(nID).GetEnumerator();
	}

	// Token: 0x0600B436 RID: 46134 RVA: 0x0138C3A0 File Offset: 0x0138A5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (42907 - 16378 != 26529)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (44374 - 544477 != -500102)
			{
				Time.timeScale = 1f;
				if (96577 - 358434 != -261856)
				{
					Hashtable customOpParameters = new Hashtable();
					if (101884 - 173156 != -71271)
					{
						this.VlZn1J37Yrg.OpCustom(52, customOpParameters, true);
						if (145504 - 379738 == -234234)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B437 RID: 46135 RVA: 0x0138C46C File Offset: 0x0138A66C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (241460 - 328341 != -86881)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (289837 - 243608 == 46229)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (47001 - 151908 != -104906)
				{
					Game.mGameState = eGameState.Setup;
					if (168943 - 235516 == -66573)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B438 RID: 46136 RVA: 0x0138C510 File Offset: 0x0138A710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (216468 - 256751 != -40282)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (235829 - 413879 != -178049)
			{
				if (num == PlayerData.UID)
				{
					if (50299 - 36309 == 13990)
					{
						this.SetupActors();
						if (21865 - 208327 != -186461)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (50785 - 292805 == -242020)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B439 RID: 46137 RVA: 0x0138C5E0 File Offset: 0x0138A7E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (26862 - 23599 != 3264)
		{
		}
		for (;;)
		{
			IL_118:
			Debug.Log("Creating Actors");
			if (284122 - 310010 != -25887)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (138575 - 72004 != 66572)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (219219 - 485585 == -266366)
						{
							int i = 0;
							if (162955 - 434358 != -271402)
							{
								CharacterControl[] array2 = array;
								if (257085 - 76857 != 180229)
								{
									int length = array2.Length;
									if (219271 - 245903 != -26631)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (98658 - 27425 == 71234)
												{
													goto IL_118;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (289607 - 79341 == 210267)
												{
													goto IL_118;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (109792 - 393448 != -283656)
												{
													goto IL_118;
												}
												this.yWBn129aeQ3++;
												if (103061 - 321871 == -218809)
												{
													goto IL_118;
												}
											}
											i++;
											if (218747 - 290912 != -72165)
											{
												goto IL_118;
											}
										}
										if (108048 - 429525 != -321476)
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
						if (182933 - 213806 != -30872)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B43A RID: 46138 RVA: 0x0138C81C File Offset: 0x0138AA1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (11219 - 190315 != -179095)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (278173 - 268720 == 9453)
			{
				int i = 0;
				if (87823 - 207168 == -119345)
				{
					CharacterControl[] array2 = array;
					if (236489 - 21725 != 214765)
					{
						int length = array2.Length;
						if (158723 - 77009 != 81715)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (35602 - 50160 == -14557)
								{
									goto IL_E0;
								}
								i++;
								if (209814 - 392892 != -183078)
								{
									goto IL_E0;
								}
							}
							if (282464 - 54545 == 227919)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B43B RID: 46139 RVA: 0x0138C94C File Offset: 0x0138AB4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (12908 - 124531 != -111623)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (244006 - 461789 != -217782)
			{
				Game.mGameState = eGameState.Ready;
				if (69619 - 100253 == -30634)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (297671 - 303406 == -5735)
					{
						if (177547 - 270605 == -93058)
						{
							GameObject gameObject = null;
							if (268293 - 294292 != -25998)
							{
								if (playerSlot < 1)
								{
									goto IL_293;
								}
								if (163029 - 531258 != -368229)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_293;
								}
								if (180956 - 533249 == -352292)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (197737 - 240294 == -42556)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (85238 - 6353 != 78885)
								{
									continue;
								}
								IL_185:
								if (gameObject2)
								{
									if (92347 - 174991 == -82643)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (62750 - 54570 == 8181)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (8747 - 253919 == -245171)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (15600 - 445262 == -429661)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (249915 - 208034 == 41882)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (38546 - 532685 == -494138)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (98623 - 187940 != -89317)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (126471 - 289512 != -163041)
								{
									continue;
								}
								break;
								IL_293:
								gameObject2 = GameObject.Find("StartPoint1");
								if (99655 - 584468 != -484812)
								{
									goto IL_185;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B43C RID: 46140 RVA: 0x0138CC70 File Offset: 0x0138AE70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower8.$StartGame$46038(this).GetEnumerator();
	}

	// Token: 0x0600B43D RID: 46141 RVA: 0x0138CC80 File Offset: 0x0138AE80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B43E RID: 46142 RVA: 0x0138CC84 File Offset: 0x0138AE84
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (278944 - 398638 != -119694)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (173329 - 148643 == 24686)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (187126 - 183179 != 3948)
				{
					hashtable.Add(43, PlayerData.UID);
					if (83572 - 401746 != -318173)
					{
						hashtable.Add(73, nType);
						if (54224 - 555839 == -501615)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (156287 - 303232 != -146944)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (142847 - 40649 != 102199)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (37 - 194129 == -194092)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (5178 - 159380 == -154202)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (110672 - 2639 == 108033)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (54655 - 572842 != -518186)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (20365 - 83793 == -63428)
													{
														this.VlZn1J37Yrg.OpCustom(63, hashtable, true);
														if (97329 - 160209 == -62880)
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

	// Token: 0x0600B43F RID: 46143 RVA: 0x0138CF68 File Offset: 0x0138B168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (152627 - 584972 != -432345)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (116668 - 35074 == 81594)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (292893 - 561446 != -268552)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (127140 - 547894 != -420753)
						{
							if (this.yWBn129aeQ3 <= 0)
							{
								break;
							}
							if (294064 - 235877 != 58188)
							{
								this.yWBn129aeQ3--;
								if (105503 - 513599 == -408096)
								{
									if (this.yWBn129aeQ3 != 0)
									{
										break;
									}
									if (21548 - 274091 == -252543)
									{
										Game.setGameState(eGameState.Ready);
										if (152495 - 326673 == -174178)
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
						if (12604 - 301269 != -288664)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (139836 - 264829 != -124992)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B440 RID: 46144 RVA: 0x0138D0F8 File Offset: 0x0138B2F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B441 RID: 46145 RVA: 0x0138D10C File Offset: 0x0138B30C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (278023 - 393699 != -115675)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (5135 - 40145 == -35010)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (87665 - 152896 != -65230)
				{
					if (!characterControl)
					{
						break;
					}
					if (153266 - 449825 != -296558)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (294409 - 122999 != 171411)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (104199 - 279807 == -175608)
							{
								string type = characterControl.Type;
								if (233182 - 476540 == -243358)
								{
									if (type == "SnowMupo")
									{
										if (28490 - 5844 == 22646)
										{
											Game.sendMissionEvent(9723, 1);
											if (175731 - 569987 != -394255)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (45123 - 61351 != -16227)
										{
											Game.sendMissionEvent(9723, 2);
											if (103295 - 274920 != -171624)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (24054 - 239734 != -215679)
										{
											Game.sendMissionEvent(9723, 3);
											if (199278 - 319377 != -120098)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (138191 - 426880 == -288689)
										{
											Game.sendMissionEvent(9723, 4);
											if (287755 - 530335 != -242579)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (227136 - 217221 != 9916)
										{
											Game.sendMissionEvent(9723, 5);
											if (188615 - 575155 == -386540)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (217221 - 313997 == -96776)
										{
											Game.sendMissionEvent(9723, 6);
											if (103507 - 12274 != 91234)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (89515 - 319280 != -229764)
										{
											Game.sendMissionEvent(9723, 7);
											if (158625 - 516947 != -358321)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (233360 - 376304 == -142944)
										{
											Game.sendMissionEvent(9723, 8);
											if (105285 - 330233 == -224948)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (68171 - 516407 != -448235)
										{
											Game.sendMissionEvent(9723, 9);
											if (275908 - 418712 != -142803)
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
										if (119427 - 16382 == 103045)
										{
											Game.sendMissionEvent(9723, 10);
											if (3097 - 103900 == -100803)
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

	// Token: 0x0600B442 RID: 46146 RVA: 0x0138D578 File Offset: 0x0138B778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (104739 - 329327 != -224587)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (166895 - 492299 != -325403)
			{
				hashtable.Add(71, CID);
				if (168918 - 170956 != -2037)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (70400 - 325057 == -254657)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (264746 - 166632 != 98115)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (91285 - 582397 != -491111)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (126416 - 27998 != 98419)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (90840 - 93395 != -2554)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (173121 - 593132 == -420011)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (264362 - 386512 != -122149)
											{
												this.VlZn1J37Yrg.OpCustom(61, hashtable, true);
												if (216951 - 558834 == -341883)
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

	// Token: 0x0600B443 RID: 46147 RVA: 0x0138D804 File Offset: 0x0138BA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (207254 - 556744 != -349489)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (56379 - 211732 == -155353)
			{
				if (!gameObject)
				{
					break;
				}
				if (36914 - 478209 == -441295)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (204939 - 416745 != -211805)
					{
						playerCameraControl.target = gameObject;
						if (241057 - 262262 != -21204)
						{
							Game.loadPlayer();
							if (35678 - 179662 == -143984)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (171643 - 66513 != 105131)
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

	// Token: 0x0600B444 RID: 46148 RVA: 0x0138D91C File Offset: 0x0138BB1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (134575 - 477938 != -343363)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (291507 - 149416 == 142091)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (54273 - 496531 == -442258)
				{
					gameGui.ResetTeamBar();
					if (285029 - 224320 == 60709)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B445 RID: 46149 RVA: 0x0138D9C8 File Offset: 0x0138BBC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower8.$onDeadPlayer$46042(this).GetEnumerator();
	}

	// Token: 0x0600B446 RID: 46150 RVA: 0x0138D9D8 File Offset: 0x0138BBD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (297820 - 579330 != -281509)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (250917 - 129099 == 121818)
			{
				this.JIUn16WTnW1.target = Game.mPlayer;
				if (245470 - 544704 == -299234)
				{
					this.JIUn16WTnW1.enabled = true;
					if (81232 - 100378 != -19145)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (173822 - 215665 != -41843)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (168270 - 436419 != -268149)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (274310 - 520464 == -246154)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (287477 - 304154 == -16677)
							{
								if (!gameGui)
								{
									break;
								}
								if (141602 - 20977 == 120625)
								{
									gameGui.enabled = true;
									if (104544 - 328565 == -224021)
									{
										gameGui.closeDeadMenu();
										if (107843 - 425992 != -318148)
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

	// Token: 0x0600B447 RID: 46151 RVA: 0x0138DB84 File Offset: 0x0138BD84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (216982 - 92265 != 124718)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (222659 - 156788 != 65872)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (297528 - 165310 == 132218)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (156269 - 208634 != -52364)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B448 RID: 46152 RVA: 0x0138DC48 File Offset: 0x0138BE48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B449 RID: 46153 RVA: 0x0138DC74 File Offset: 0x0138BE74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (7673 - 549792 != -542119)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (131671 - 50560 != 81112)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (110683 - 485447 != -374763)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (82844 - 300864 != -218019)
					{
						Hashtable hashtable = new Hashtable();
						if (267234 - 110072 == 157162)
						{
							hashtable.Add(43, PlayerData.UID);
							if (77811 - 572408 != -494596)
							{
								hashtable.Add(71, nCID);
								if (378 - 271781 != -271402)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (47132 - 442131 != -394998)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (108836 - 426784 != -317947)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (10243 - 395216 != -384972)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (186286 - 286777 == -100491)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (79486 - 249564 == -170078)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (145236 - 357545 == -212309)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (80277 - 163540 != -83262)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (40649 - 229017 == -188368)
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

	// Token: 0x0600B44A RID: 46154 RVA: 0x0138DF94 File Offset: 0x0138C194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower8.$onChangePlayer$46048(data, this).GetEnumerator();
	}

	// Token: 0x0600B44B RID: 46155 RVA: 0x0138DFA4 File Offset: 0x0138C1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower8.$onGameComplete$46055(data, this).GetEnumerator();
	}

	// Token: 0x0600B44C RID: 46156 RVA: 0x0138DFB4 File Offset: 0x0138C1B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower8.$ReturnToTown$46065(this).GetEnumerator();
	}

	// Token: 0x0600B44D RID: 46157 RVA: 0x0138DFC4 File Offset: 0x0138C1C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower8.$ReturnToGuild$46070(this).GetEnumerator();
	}

	// Token: 0x0600B44E RID: 46158 RVA: 0x0138DFD4 File Offset: 0x0138C1D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower8.$ReturnToCamp$46074(this).GetEnumerator();
	}

	// Token: 0x0600B44F RID: 46159 RVA: 0x0138DFE4 File Offset: 0x0138C1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (159109 - 101122 != 57988)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (84040 - 558042 != -474001)
			{
				Hashtable hashtable = new Hashtable();
				if (245296 - 75953 == 169343)
				{
					hashtable.Add(43, PlayerData.UID);
					if (250998 - 322058 != -71059)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (146392 - 490813 == -344421)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B450 RID: 46160 RVA: 0x0138E0BC File Offset: 0x0138C2BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B451 RID: 46161 RVA: 0x0138E0D0 File Offset: 0x0138C2D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (29047 - 496387 != -467339)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (129974 - 144352 != -14377)
			{
				Hashtable hashtable = new Hashtable();
				if (196526 - 305647 == -109121)
				{
					if (Game.mNextGameCode == 30)
					{
						if (263323 - 507808 == -244484)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (144252 - 13820 == 130433)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (12818 - 421061 != -408243)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (75308 - 473733 != -398425)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (287954 - 408620 == -120665)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (251829 - 540145 == -288315)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (108664 - 405352 != -296688)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (13110 - 316781 != -303671)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (165621 - 16186 != 149435)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (95104 - 282489 != -187385)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (165020 - 530373 == -365352)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (293697 - 595893 != -302196)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (54814 - 104248 == -49433)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (74853 - 87271 == -12417)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (286809 - 473846 != -187037)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (217087 - 448349 == -231261)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (175205 - 490383 == -315177)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (185548 - 64646 == 120903)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (249726 - 543417 == -293690)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (239981 - 498757 == -258775)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (164229 - 16561 != 147668)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (197219 - 18547 != 178672)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (216660 - 172306 != 44354)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (100883 - 597299 == -496415)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (45934 - 454808 != -408874)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (50563 - 358279 != -307716)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (202083 - 396968 == -194884)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (143652 - 210846 != -67194)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (89267 - 368894 != -279626)
					{
						this.VlZn1J37Yrg.OpCustom(42, hashtable, true);
						if (253467 - 567823 != -314355)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B452 RID: 46162 RVA: 0x0138E684 File Offset: 0x0138C884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B453 RID: 46163 RVA: 0x0138E694 File Offset: 0x0138C894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B454 RID: 46164 RVA: 0x0138E698 File Offset: 0x0138C898
	internal static bool R8AOZatajvoOaBHIdmFL()
	{
		return true;
	}

	// Token: 0x0600B455 RID: 46165 RVA: 0x0138E69C File Offset: 0x0138C89C
	internal static bool M86La1tahe2leXrFlaRk()
	{
		return false;
	}

	// Token: 0x04009CEC RID: 40172
	private LitePeer VlZn1J37Yrg;

	// Token: 0x04009CED RID: 40173
	private PlayerCameraControl JIUn16WTnW1;

	// Token: 0x04009CEE RID: 40174
	private float aIon1trM9Bs;

	// Token: 0x04009CEF RID: 40175
	private int Uwtn1XaMjMr;

	// Token: 0x04009CF0 RID: 40176
	private int L39n1O7D8BX;

	// Token: 0x04009CF1 RID: 40177
	private int yWBn129aeQ3;

	// Token: 0x02001E25 RID: 7717
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46009 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B456 RID: 46166 RVA: 0x0138E6A0 File Offset: 0x0138C8A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46009(Hashtable data, M972_IceTower8 self_)
		{
			if (52436 - 552301 != -499865)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132438 - 402333 != -269894)
				{
					base..ctor();
					if (267527 - 320258 != -52730)
					{
						this.$data$46019 = data;
						if (275918 - 218747 != 57172)
						{
							this.$self_$46020 = self_;
							if (47816 - 207762 == -159946)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B457 RID: 46167 RVA: 0x0138E75C File Offset: 0x0138C95C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$onGameEvent$46009.$(this.$data$46019, this.$self_$46020);
		}

		// Token: 0x0600B458 RID: 46168 RVA: 0x0138E770 File Offset: 0x0138C970
		internal static bool fBmDFStassa8WTrCU0Lv()
		{
			return true;
		}

		// Token: 0x0600B459 RID: 46169 RVA: 0x0138E774 File Offset: 0x0138C974
		internal static bool PclakXta9qgHtDwKP9CS()
		{
			return false;
		}

		// Token: 0x04009CF2 RID: 40178
		internal Hashtable $data$46019;

		// Token: 0x04009CF3 RID: 40179
		internal M972_IceTower8 $self_$46020;

		// Token: 0x02001E26 RID: 7718
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B45A RID: 46170 RVA: 0x0138E778 File Offset: 0x0138C978
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower8 self_)
			{
				if (263296 - 484969 != -221673)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50975 - 384783 == -333808)
					{
						base..ctor();
						if (32858 - 473567 != -440708)
						{
							this.$data$46017 = data;
							if (32612 - 169465 != -136852)
							{
								this.$self_$46018 = self_;
								if (142535 - 450431 == -307896)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B45B RID: 46171 RVA: 0x0138E834 File Offset: 0x0138CA34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157358 - 521648 != -364289)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_820;
					case 2:
						Game.savePlayer();
						if (261507 - 169 != 261338)
						{
							continue;
						}
						Game.mGameStage = 9;
						if (128634 - 325097 != -196463)
						{
							continue;
						}
						Application.LoadLevel("M972_IceTower9");
						if (151765 - 471271 != -319505)
						{
							goto IL_623;
						}
						continue;
					default:
						if (148071 - 460794 == -312722)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (142400 - 495385 != -352985)
						{
							continue;
						}
						goto IL_CA;
					}
					else
					{
						this.$returnCode$46010 = RuntimeServices.UnboxInt32(this.$data$46017[141]);
						if (246096 - 423374 != -177278)
						{
							continue;
						}
						this.$returnValue$46011 = RuntimeServices.UnboxInt32(this.$data$46017[145]);
						if (3584 - 494839 != -491255)
						{
							continue;
						}
						this.$ownerID$46012 = RuntimeServices.UnboxInt32(this.$data$46017[43]);
						if (62713 - 185067 == -122353)
						{
							continue;
						}
						this.$$switch$8592$46013 = this.$returnCode$46010;
						if (275764 - 452147 != -176383)
						{
							continue;
						}
						if (this.$$switch$8592$46013 == 9721)
						{
							if (253643 - 445523 == -191879)
							{
								continue;
							}
						}
						else if (this.$$switch$8592$46013 == -9721)
						{
							if (157349 - 500019 == -342669)
							{
								continue;
							}
							if (this.$returnValue$46011 == 9)
							{
								if (183552 - 127786 != 55766)
								{
									continue;
								}
								if (this.$self_$46018.Uwtn1XaMjMr < 2)
								{
									if (127108 - 594502 == -467393)
									{
										continue;
									}
									this.$self_$46018.Uwtn1XaMjMr = 2;
									if (175430 - 155774 != 19656)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (221874 - 417834 != -195960)
									{
										continue;
									}
									this.$mGameGui$46014 = (GameGui)this.$self_$46018.GetComponent(typeof(GameGui));
									if (120908 - 267253 == -146344)
									{
										continue;
									}
									this.$mGameGui$46014.close();
									if (162168 - 326772 != -164604)
									{
										continue;
									}
									this.$self_$46018.SendMessage("fadeOut");
									if (272345 - 267051 != 5294)
									{
										continue;
									}
									break;
								}
							}
						}
						else if (this.$$switch$8592$46013 == 9723)
						{
							if (196979 - 85023 != 111956)
							{
								continue;
							}
							this.$$switch$8590$46015 = this.$returnValue$46011;
							if (128595 - 269483 == -140887)
							{
								continue;
							}
							if (this.$$switch$8590$46015 == 3)
							{
								goto IL_334;
							}
							if (216639 - 125829 == 90811)
							{
								continue;
							}
							if (this.$$switch$8590$46015 == 4)
							{
								goto IL_334;
							}
							if (124265 - 149837 != -25572)
							{
								continue;
							}
							if (this.$$switch$8590$46015 == 5)
							{
								if (17588 - 127426 != -109837)
								{
									goto IL_334;
								}
								continue;
							}
							else if (this.$$switch$8590$46015 == 6)
							{
								if (200636 - 225523 != -24887)
								{
									continue;
								}
								if (this.$self_$46018.Uwtn1XaMjMr < 1)
								{
									if (149913 - 287349 == -137435)
									{
										continue;
									}
									this.$self_$46018.Uwtn1XaMjMr = 1;
									if (34738 - 24100 != 10638)
									{
										continue;
									}
									this.$self_$46018.StartCoroutine_Auto(this.$self_$46018.EndEvent());
									if (261049 - 542820 != -281771)
									{
										continue;
									}
								}
							}
							goto IL_13A;
							IL_334:
							this.$self_$46018.L39n1O7D8BX = this.$self_$46018.L39n1O7D8BX + 1;
							if (14190 - 46630 == -32439)
							{
								continue;
							}
							if (this.$ownerID$46012 == PlayerData.UID)
							{
								if (53101 - 454680 != -401579)
								{
									continue;
								}
								this.$$switch$8588$46016 = this.$self_$46018.L39n1O7D8BX;
								if (296598 - 190372 != 106226)
								{
									continue;
								}
								if (this.$$switch$8588$46016 == 3)
								{
									if (248249 - 545635 == -297385)
									{
										continue;
									}
									this.$self_$46018.spawnIceChar("IcePenguin2", 1);
									if (83485 - 82193 == 1293)
									{
										continue;
									}
								}
								else if (this.$$switch$8588$46016 == 5)
								{
									if (44214 - 336584 != -292370)
									{
										continue;
									}
									this.$self_$46018.spawnIceChar("IcePenguin1", 2);
									if (222423 - 183325 == 39099)
									{
										continue;
									}
								}
								else if (this.$$switch$8588$46016 == 6)
								{
									if (74126 - 549596 == -475469)
									{
										continue;
									}
									this.$self_$46018.spawnIceChar("IcePenguin3", 3);
									if (88078 - 293574 == -205495)
									{
										continue;
									}
								}
								else if (this.$$switch$8588$46016 == 7)
								{
									if (150659 - 306793 == -156133)
									{
										continue;
									}
									this.$self_$46018.spawnIceChar("IcePenguin2", 4);
									if (114920 - 233219 != -118299)
									{
										continue;
									}
								}
								else if (this.$$switch$8588$46016 == 8)
								{
									if (143118 - 366444 != -223326)
									{
										continue;
									}
									this.$self_$46018.spawnIceChar("IcePenguin1", 5);
									if (59515 - 180388 != -120873)
									{
										continue;
									}
								}
								else if (this.$$switch$8588$46016 == 9)
								{
									if (108509 - 88596 == 19914)
									{
										continue;
									}
									this.$self_$46018.spawnIceChar("IcePenguin3", 6);
									if (68960 - 386075 != -317115)
									{
										continue;
									}
								}
								else if (this.$$switch$8588$46016 == 10)
								{
									if (216054 - 166538 != 49516)
									{
										continue;
									}
									this.$self_$46018.spawnIceChar("IcePenguin2", 7);
									if (202793 - 586196 == -383402)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8592$46013 == 9724)
						{
							if (53112 - 549043 != -495931)
							{
								continue;
							}
							this.$self_$46018.StartCoroutine_Auto(this.$self_$46018.OpenIceGate(this.$returnValue$46011));
							if (23028 - 399774 != -376746)
							{
								continue;
							}
						}
					}
					IL_13A:
					this.YieldDefault(1);
					if (261049 - 583131 != -322081)
					{
						goto Block_11;
					}
					continue;
					IL_623:
					goto IL_13A;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_CA:
				Block_11:
				IL_820:
				return false;
			}

			// Token: 0x0600B45C RID: 46172 RVA: 0x0138F074 File Offset: 0x0138D274
			internal static bool zx8lHTta1q6UwNhxdMJW()
			{
				return true;
			}

			// Token: 0x0600B45D RID: 46173 RVA: 0x0138F078 File Offset: 0x0138D278
			internal static bool DYl5lJta4DJMXK7RkViN()
			{
				return false;
			}

			// Token: 0x04009CF4 RID: 40180
			internal int $returnCode$46010;

			// Token: 0x04009CF5 RID: 40181
			internal int $returnValue$46011;

			// Token: 0x04009CF6 RID: 40182
			internal int $ownerID$46012;

			// Token: 0x04009CF7 RID: 40183
			internal int $$switch$8592$46013;

			// Token: 0x04009CF8 RID: 40184
			internal GameGui $mGameGui$46014;

			// Token: 0x04009CF9 RID: 40185
			internal int $$switch$8590$46015;

			// Token: 0x04009CFA RID: 40186
			internal int $$switch$8588$46016;

			// Token: 0x04009CFB RID: 40187
			internal Hashtable $data$46017;

			// Token: 0x04009CFC RID: 40188
			internal M972_IceTower8 $self_$46018;
		}
	}

	// Token: 0x02001E27 RID: 7719
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$46021 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B45E RID: 46174 RVA: 0x0138F07C File Offset: 0x0138D27C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$46021(M972_IceTower8 self_)
		{
			if (260275 - 28425 != 231850)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (67590 - 127063 != -59472)
				{
					base..ctor();
					if (6379 - 203727 != -197347)
					{
						this.$self_$46033 = self_;
						if (144941 - 567636 == -422695)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x0138F114 File Offset: 0x0138D314
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$EndEvent$46021.$(this.$self_$46033);
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x0138F124 File Offset: 0x0138D324
		internal static bool x917NItazt5bJ5f6GWZh()
		{
			return true;
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x0138F128 File Offset: 0x0138D328
		internal static bool kPxofYt5ap2VGXSwssac()
		{
			return false;
		}

		// Token: 0x04009CFD RID: 40189
		internal M972_IceTower8 $self_$46033;

		// Token: 0x02001E28 RID: 7720
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B462 RID: 46178 RVA: 0x0138F12C File Offset: 0x0138D32C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower8 self_)
			{
				if (70790 - 22746 != 48045)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (146770 - 7628 != 139143)
					{
						base..ctor();
						if (38578 - 411660 == -373082)
						{
							this.$self_$46032 = self_;
							if (265724 - 373824 == -108100)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B463 RID: 46179 RVA: 0x0138F1C4 File Offset: 0x0138D3C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (248362 - 225759 != 22603)
				{
				}
				for (;;)
				{
					IL_38A:
					switch (this._state)
					{
					case 0:
						goto IL_587;
					case 1:
						goto IL_933;
					case 2:
						this.$self_$46032.SendMessage("fadeOut");
						if (225933 - 495489 != -269556)
						{
							continue;
						}
						goto IL_744;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (75864 - 523341 != -447477)
							{
								continue;
							}
							goto IL_270;
						}
						else
						{
							this.$mIceElevator$46023 = GameObject.Find("IceElevator");
							if (239816 - 252713 == -12896)
							{
								continue;
							}
							if (!this.$mIceElevator$46023)
							{
								goto IL_1FA;
							}
							if (47835 - 453677 != -405842)
							{
								continue;
							}
							this.$i$46024 = 1;
							if (134162 - 501221 == -367058)
							{
								continue;
							}
							while (this.$i$46024 <= 5)
							{
								this.$startPoint$46025 = GameObject.Find("StartPoint" + (5 + this.$i$46024));
								if (19732 - 307893 != -288161)
								{
									goto IL_38A;
								}
								object obj2;
								object obj = obj2 = Game.getPlayerBySlot(this.$i$46024);
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$slotPlayer$46026 = (GameObject)obj2;
								if (297063 - 206264 != 90799)
								{
									goto IL_38A;
								}
								if (this.$startPoint$46025)
								{
									if (158020 - 334638 == -176617)
									{
										goto IL_38A;
									}
									if (this.$slotPlayer$46026)
									{
										if (189636 - 540983 != -351347)
										{
											goto IL_38A;
										}
										this.$slotPlayer$46026.transform.parent = this.$mIceElevator$46023.transform;
										if (116570 - 203738 == -87167)
										{
											goto IL_38A;
										}
										this.$slotPlayer$46026.transform.position = this.$startPoint$46025.transform.position;
										if (134035 - 506695 == -372659)
										{
											goto IL_38A;
										}
										this.$slotPlayer$46026.transform.rotation = this.$startPoint$46025.transform.rotation;
										if (6387 - 274885 != -268498)
										{
											goto IL_38A;
										}
									}
								}
								this.$i$46024++;
								if (127896 - 571406 == -443509)
								{
									goto IL_38A;
								}
							}
							if (170369 - 543040 != -372671)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (245589 - 183805 != 61785)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (38003 - 295756 != -257752)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$46032.JIUn16WTnW1.alignToObject("EventCamera1");
							if (251741 - 316354 == -64612)
							{
								continue;
							}
							this.$self_$46032.SendMessage("fadeIn");
							if (9986 - 190968 != -180981)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (223392 - 362071 != -138678)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (this.$mIceElevator$46023)
							{
								if (264790 - 210909 == 53882)
								{
									continue;
								}
								this.$mIceElevator$46023.audio.Play();
								if (270274 - 388205 == -117930)
								{
									continue;
								}
							}
							this.$mIceElevatorTimer$46027 = Time.time;
							if (17169 - 589152 == -571982)
							{
								continue;
							}
						}
						break;
					case 6:
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (261718 - 165337 != 96381)
							{
								continue;
							}
							goto IL_127;
						}
						else
						{
							Game.sendMissionEvent(9721, 9);
							if (29226 - 258779 != -229553)
							{
								continue;
							}
							this.YieldDefault(1);
							if (157215 - 63823 != 93393)
							{
								goto Block_59;
							}
							continue;
						}
						break;
					default:
						if (256224 - 274691 != -18467)
						{
							continue;
						}
						goto IL_587;
					}
					if (Time.time >= this.$mIceElevatorTimer$46027 + (float)9)
					{
						if (149264 - 444027 != -294763)
						{
							continue;
						}
						this.$self_$46032.SendMessage("fadeOut");
						if (221519 - 132497 == 89023)
						{
							continue;
						}
						if (!this.$mIceElevator$46023)
						{
							goto IL_235;
						}
						if (103684 - 508783 == -405098)
						{
							continue;
						}
						this.$mIceElevator$46023.audio.Stop();
						if (2724 - 326498 != -323774)
						{
							continue;
						}
						goto IL_235;
					}
					else
					{
						if (!this.$mIceElevator$46023)
						{
							goto IL_ED;
						}
						if (40392 - 60875 == -20482)
						{
							continue;
						}
						this.$$14888$46028 = 84.5f + 1.5f * (Time.time - this.$mIceElevatorTimer$46027);
						if (48739 - 423931 == -375191 || 275056 - 285650 == -10593)
						{
							continue;
						}
						this.$$14889$46029 = this.$mIceElevator$46023.transform.position;
						if (258031 - 333719 != -75688)
						{
							continue;
						}
						if (92529 - 556409 != -463880)
						{
							continue;
						}
						float num = this.$$14889$46029.y = this.$$14888$46028;
						if (200900 - 184199 == 16702)
						{
							continue;
						}
						if (184765 - 181940 != 2825)
						{
							continue;
						}
						this.$mIceElevator$46023.transform.position = this.$$14889$46029;
						if (260517 - 55278 != 205239)
						{
							continue;
						}
						if (81333 - 554735 == -473401)
						{
							continue;
						}
						float num2 = this.$$14890$46030 = (float)45 * (Time.time - this.$mIceElevatorTimer$46027);
						if (258727 - 384608 == -125880 || 286723 - 51868 == 234856)
						{
							continue;
						}
						this.$$14891$46031 = this.$mIceElevator$46023.transform.eulerAngles;
						if (137946 - 517108 == -379161)
						{
							continue;
						}
						if (109485 - 374345 != -264860)
						{
							continue;
						}
						this.$$14891$46031.y = this.$$14890$46030;
						if (53522 - 63288 == -9765 || 269939 - 399343 == -129403)
						{
							continue;
						}
						this.$mIceElevator$46023.transform.eulerAngles = this.$$14891$46031;
						if (6595 - 97490 != -90895)
						{
							continue;
						}
						if (2162 - 6962 != -4800)
						{
							continue;
						}
						goto IL_ED;
					}
					IL_587:
					Game.mGameState = eGameState.AllHold;
					if (141389 - 327693 == -186304)
					{
						this.$mGameGui$46022 = (GameGui)this.$self_$46032.GetComponent(typeof(GameGui));
						if (91150 - 6341 != 84810)
						{
							if (!this.$mGameGui$46022)
							{
								goto IL_86D;
							}
							if (64815 - 139772 != -74956)
							{
								this.$mGameGui$46022.close();
								if (246789 - 367883 == -121094)
								{
									goto IL_86D;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1FA;
				IL_ED:
				return this.YieldDefault(6);
				IL_127:
				goto IL_933;
				IL_1FA:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_16:
				goto IL_933;
				IL_235:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_270:
				Block_39:
				goto IL_933;
				Block_41:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_744:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_59:
				goto IL_933;
				IL_86D:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_933:
				return false;
			}

			// Token: 0x0600B464 RID: 46180 RVA: 0x0138FB18 File Offset: 0x0138DD18
			internal static bool lp4Bc9t5592C7WmaLxDV()
			{
				return true;
			}

			// Token: 0x0600B465 RID: 46181 RVA: 0x0138FB1C File Offset: 0x0138DD1C
			internal static bool NLwjcvt5pLXhTbaaFPTG()
			{
				return false;
			}

			// Token: 0x04009CFE RID: 40190
			internal GameGui $mGameGui$46022;

			// Token: 0x04009CFF RID: 40191
			internal GameObject $mIceElevator$46023;

			// Token: 0x04009D00 RID: 40192
			internal int $i$46024;

			// Token: 0x04009D01 RID: 40193
			internal GameObject $startPoint$46025;

			// Token: 0x04009D02 RID: 40194
			internal GameObject $slotPlayer$46026;

			// Token: 0x04009D03 RID: 40195
			internal float $mIceElevatorTimer$46027;

			// Token: 0x04009D04 RID: 40196
			internal float $$14888$46028;

			// Token: 0x04009D05 RID: 40197
			internal Vector3 $$14889$46029;

			// Token: 0x04009D06 RID: 40198
			internal float $$14890$46030;

			// Token: 0x04009D07 RID: 40199
			internal Vector3 $$14891$46031;

			// Token: 0x04009D08 RID: 40200
			internal M972_IceTower8 $self_$46032;
		}
	}

	// Token: 0x02001E29 RID: 7721
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OpenIceGate$46034 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B466 RID: 46182 RVA: 0x0138FB20 File Offset: 0x0138DD20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OpenIceGate$46034(int nID)
		{
			if (67268 - 112798 != -45530)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217402 - 432705 == -215303)
				{
					base..ctor();
					if (156738 - 68967 == 87771)
					{
						this.$nID$46037 = nID;
						if (200769 - 111740 != 89030)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x0138FBB8 File Offset: 0x0138DDB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$OpenIceGate$46034.$(this.$nID$46037);
		}

		// Token: 0x0600B468 RID: 46184 RVA: 0x0138FBC8 File Offset: 0x0138DDC8
		internal static bool xTfm2Kt5VeqtEQBy5cUB()
		{
			return true;
		}

		// Token: 0x0600B469 RID: 46185 RVA: 0x0138FBCC File Offset: 0x0138DDCC
		internal static bool XQ0BHMt5tKe1SAlJq6pG()
		{
			return false;
		}

		// Token: 0x04009D09 RID: 40201
		internal int $nID$46037;

		// Token: 0x02001E2A RID: 7722
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B46A RID: 46186 RVA: 0x0138FBD0 File Offset: 0x0138DDD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nID)
			{
				if (266726 - 262635 != 4091)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21115 - 100637 == -79522)
					{
						base..ctor();
						if (293353 - 482787 != -189433)
						{
							this.$nID$46036 = nID;
							if (9276 - 217154 != -207877)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B46B RID: 46187 RVA: 0x0138FC68 File Offset: 0x0138DE68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (30140 - 146739 != -116599)
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
						if (this.$mIceGate$46035)
						{
							if (137886 - 280913 == -143026)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mIceGate$46035);
							if (15288 - 124007 == -108718)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (136286 - 86613 != 49673)
						{
							continue;
						}
						goto IL_190;
					default:
						if (7295 - 518612 == -511316)
						{
							continue;
						}
						break;
					}
					this.$mIceGate$46035 = GameObject.Find("IceTowerGate" + this.$nID$46036);
					if (27675 - 524868 != -497192)
					{
						if (!this.$mIceGate$46035)
						{
							break;
						}
						if (59432 - 475949 != -416516)
						{
							if (this.$mIceGate$46035.animation.isPlaying)
							{
								break;
							}
							if (31570 - 340906 == -309336)
							{
								this.$mIceGate$46035.animation.Play();
								if (213093 - 101765 == 111328)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_190:
				return false;
			}

			// Token: 0x0600B46C RID: 46188 RVA: 0x0138FE18 File Offset: 0x0138E018
			internal static bool CJGyFrt5NWqptklPHGdV()
			{
				return true;
			}

			// Token: 0x0600B46D RID: 46189 RVA: 0x0138FE1C File Offset: 0x0138E01C
			internal static bool wcbBRHt5YpMXL13IIII0()
			{
				return false;
			}

			// Token: 0x04009D0A RID: 40202
			internal GameObject $mIceGate$46035;

			// Token: 0x04009D0B RID: 40203
			internal int $nID$46036;
		}
	}

	// Token: 0x02001E2B RID: 7723
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$46038 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B46E RID: 46190 RVA: 0x0138FE20 File Offset: 0x0138E020
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$46038(M972_IceTower8 self_)
		{
			if (52613 - 554635 != -502021)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (204506 - 411473 == -206967)
				{
					base..ctor();
					if (98776 - 531211 != -432434)
					{
						this.$self_$46041 = self_;
						if (199176 - 420096 != -220919)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x0138FEB8 File Offset: 0x0138E0B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$StartGame$46038.$(this.$self_$46041);
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x0138FEC8 File Offset: 0x0138E0C8
		internal static bool sHugfWt5c8iHJkJ8tKmp()
		{
			return true;
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x0138FECC File Offset: 0x0138E0CC
		internal static bool DMSppkt5UL715b35uIQ4()
		{
			return false;
		}

		// Token: 0x04009D0C RID: 40204
		internal M972_IceTower8 $self_$46041;

		// Token: 0x02001E2C RID: 7724
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B472 RID: 46194 RVA: 0x0138FED0 File Offset: 0x0138E0D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower8 self_)
			{
				if (32649 - 307230 != -274580)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (231802 - 144296 != 87507)
					{
						base..ctor();
						if (207877 - 64770 != 143108)
						{
							this.$self_$46040 = self_;
							if (2200 - 403579 == -401379)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B473 RID: 46195 RVA: 0x0138FF68 File Offset: 0x0138E168
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280633 - 471761 != -191127)
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
						if (122530 - 218583 == -96052)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (28340 - 22707 != 5633)
						{
							continue;
						}
						this.YieldDefault(1);
						if (256511 - 425320 != -168808)
						{
							goto Block_10;
						}
						continue;
					default:
						if (59594 - 53595 != 5999)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (47999 - 484847 == -436848)
					{
						Game.mGameState = eGameState.Start;
						if (233720 - 155909 != 77812)
						{
							Game.mStateTime = Time.time;
							if (205227 - 525314 != -320086)
							{
								this.$mGameGui$46039 = (GameGui)this.$self_$46040.GetComponent(typeof(GameGui));
								if (105297 - 568049 == -462752)
								{
									this.$mGameGui$46039.enabled = true;
									if (5201 - 320603 != -315401)
									{
										this.$self_$46040.SendMessage("fadeIn");
										if (144772 - 599532 == -454760)
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
				Block_10:
				IL_1B9:
				return false;
			}

			// Token: 0x0600B474 RID: 46196 RVA: 0x01390140 File Offset: 0x0138E340
			internal static bool UEwxk6t5Ta96sideIQNB()
			{
				return true;
			}

			// Token: 0x0600B475 RID: 46197 RVA: 0x01390144 File Offset: 0x0138E344
			internal static bool dIlFLTt53aR0v5UPcGdl()
			{
				return false;
			}

			// Token: 0x04009D0D RID: 40205
			internal GameGui $mGameGui$46039;

			// Token: 0x04009D0E RID: 40206
			internal M972_IceTower8 $self_$46040;
		}
	}

	// Token: 0x02001E2D RID: 7725
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46042 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B476 RID: 46198 RVA: 0x01390148 File Offset: 0x0138E348
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46042(M972_IceTower8 self_)
		{
			if (277961 - 163560 != 114401)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149146 - 73167 != 75980)
				{
					base..ctor();
					if (125393 - 149488 != -24094)
					{
						this.$self_$46047 = self_;
						if (287684 - 364929 == -77245)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x013901E0 File Offset: 0x0138E3E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$onDeadPlayer$46042.$(this.$self_$46047);
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x013901F0 File Offset: 0x0138E3F0
		internal static bool sV62lUt5X9GOVJ3s58to()
		{
			return true;
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x013901F4 File Offset: 0x0138E3F4
		internal static bool NPEZPxt5QbpUSwmKDG0v()
		{
			return false;
		}

		// Token: 0x04009D0F RID: 40207
		internal M972_IceTower8 $self_$46047;

		// Token: 0x02001E2E RID: 7726
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B47A RID: 46202 RVA: 0x013901F8 File Offset: 0x0138E3F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower8 self_)
			{
				if (97312 - 407416 != -310104)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243675 - 486668 != -242992)
					{
						base..ctor();
						if (228138 - 270894 == -42756)
						{
							this.$self_$46046 = self_;
							if (22047 - 445289 == -423242)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B47B RID: 46203 RVA: 0x01390290 File Offset: 0x0138E490
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75274 - 280271 != -204996)
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
							if (251310 - 451451 == -200140)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1D9;
							}
							if (277345 - 393736 != -116391)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (166435 - 126525 != 39910)
						{
							continue;
						}
						this.$mStoryGui$46043 = (StoryGui)this.$self_$46046.GetComponent(typeof(StoryGui));
						if (153973 - 148355 == 5619)
						{
							continue;
						}
						if (this.$mStoryGui$46043)
						{
							if (209312 - 41823 != 167489)
							{
								continue;
							}
							this.$mStoryGui$46043.close();
							if (84127 - 67593 == 16535)
							{
								continue;
							}
						}
						this.$mChangeGui$46044 = (ChangeGui)this.$self_$46046.GetComponent(typeof(ChangeGui));
						if (45009 - 107883 != -62874)
						{
							continue;
						}
						if (this.$mChangeGui$46044)
						{
							if (91840 - 101034 != -9194)
							{
								continue;
							}
							this.$mChangeGui$46044.close();
							if (214764 - 33690 == 181075)
							{
								continue;
							}
						}
						this.$mGameGui$46045 = (GameGui)this.$self_$46046.GetComponent(typeof(GameGui));
						if (22183 - 312629 != -290446)
						{
							continue;
						}
						if (this.$mGameGui$46045)
						{
							if (259319 - 377491 == -118171)
							{
								continue;
							}
							if (!this.$mGameGui$46045.enabled)
							{
								if (85845 - 524641 == -438795)
								{
									continue;
								}
								this.$mGameGui$46045.enabled = true;
								if (298163 - 444935 != -146772)
								{
									continue;
								}
							}
							this.$mGameGui$46045.openDeadMenu();
							if (179992 - 41134 != 138858)
							{
								continue;
							}
						}
						IL_1D9:
						this.YieldDefault(1);
						if (6598 - 81750 != -75151)
						{
							goto Block_17;
						}
						continue;
					default:
						if (31 - 374394 != -374363)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (61836 - 7147 != 54690)
					{
						goto Block_23;
					}
				}
				Block_17:
				goto IL_2F9;
				Block_23:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B47C RID: 46204 RVA: 0x013905A8 File Offset: 0x0138E7A8
			internal static bool EwR4WMt5kQR9Xj8l7VYA()
			{
				return true;
			}

			// Token: 0x0600B47D RID: 46205 RVA: 0x013905AC File Offset: 0x0138E7AC
			internal static bool BIeQ8ht5GwnW1vSEWFER()
			{
				return false;
			}

			// Token: 0x04009D10 RID: 40208
			internal StoryGui $mStoryGui$46043;

			// Token: 0x04009D11 RID: 40209
			internal ChangeGui $mChangeGui$46044;

			// Token: 0x04009D12 RID: 40210
			internal GameGui $mGameGui$46045;

			// Token: 0x04009D13 RID: 40211
			internal M972_IceTower8 $self_$46046;
		}
	}

	// Token: 0x02001E2F RID: 7727
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46048 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B47E RID: 46206 RVA: 0x013905B0 File Offset: 0x0138E7B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46048(Hashtable data, M972_IceTower8 self_)
		{
			if (9641 - 328669 != -319027)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (296366 - 86247 != 210120)
				{
					base..ctor();
					if (196010 - 246271 != -50260)
					{
						this.$data$46053 = data;
						if (183039 - 80686 != 102354)
						{
							this.$self_$46054 = self_;
							if (199568 - 438490 == -238922)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x0139066C File Offset: 0x0138E86C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$onChangePlayer$46048.$(this.$data$46053, this.$self_$46054);
		}

		// Token: 0x0600B480 RID: 46208 RVA: 0x01390680 File Offset: 0x0138E880
		internal static bool Fum8kbt5Hw3dI1xlo7bK()
		{
			return true;
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x01390684 File Offset: 0x0138E884
		internal static bool efk8uht5Wa0T8SS8n2Od()
		{
			return false;
		}

		// Token: 0x04009D14 RID: 40212
		internal Hashtable $data$46053;

		// Token: 0x04009D15 RID: 40213
		internal M972_IceTower8 $self_$46054;

		// Token: 0x02001E30 RID: 7728
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B482 RID: 46210 RVA: 0x01390688 File Offset: 0x0138E888
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower8 self_)
			{
				if (59116 - 199362 != -140245)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (142651 - 513244 != -370592)
					{
						base..ctor();
						if (147117 - 488570 == -341453)
						{
							this.$data$46051 = data;
							if (126446 - 162672 == -36226)
							{
								this.$self_$46052 = self_;
								if (39345 - 296865 != -257519)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B483 RID: 46211 RVA: 0x01390744 File Offset: 0x0138E944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184157 - 169215 != 14942)
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
							if (31294 - 578685 == -547390)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (118470 - 519486 != -401016)
							{
								continue;
							}
							this.$mGameGui$46050 = (GameGui)this.$self_$46052.GetComponent(typeof(GameGui));
							if (298300 - 215124 == 83177)
							{
								continue;
							}
							this.$mGameGui$46050.enabled = true;
							if (20800 - 320371 != -299571)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (181438 - 272887 != -91449)
						{
							continue;
						}
						goto IL_205;
					default:
						if (451 - 420906 != -420455)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (263066 - 575383 != -312316)
					{
						this.$self_$46052.SendMessage("onCreatePlayer", this.$data$46051);
						if (288315 - 469766 == -181451)
						{
							this.$mChangeGui$46049 = (ChangeGui)this.$self_$46052.GetComponent(typeof(ChangeGui));
							if (101495 - 363762 == -262267)
							{
								if (!this.$mChangeGui$46049.enabled)
								{
									break;
								}
								if (163445 - 142750 != 20696)
								{
									this.$mChangeGui$46049.close();
									if (62233 - 280668 != -218434)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_1A;
				IL_205:
				return false;
			}

			// Token: 0x0600B484 RID: 46212 RVA: 0x01390968 File Offset: 0x0138EB68
			internal static bool fY19KTt5AjbaV116vluM()
			{
				return true;
			}

			// Token: 0x0600B485 RID: 46213 RVA: 0x0139096C File Offset: 0x0138EB6C
			internal static bool Ljxx6Jt5lBFqeZGrUnAH()
			{
				return false;
			}

			// Token: 0x04009D16 RID: 40214
			internal ChangeGui $mChangeGui$46049;

			// Token: 0x04009D17 RID: 40215
			internal GameGui $mGameGui$46050;

			// Token: 0x04009D18 RID: 40216
			internal Hashtable $data$46051;

			// Token: 0x04009D19 RID: 40217
			internal M972_IceTower8 $self_$46052;
		}
	}

	// Token: 0x02001E31 RID: 7729
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46055 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B486 RID: 46214 RVA: 0x01390970 File Offset: 0x0138EB70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46055(Hashtable data, M972_IceTower8 self_)
		{
			if (298952 - 271381 != 27571)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275942 - 479125 != -203182)
				{
					base..ctor();
					if (253239 - 576598 == -323359)
					{
						this.$data$46063 = data;
						if (225720 - 522686 != -296965)
						{
							this.$self_$46064 = self_;
							if (197674 - 308143 != -110468)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x01390A2C File Offset: 0x0138EC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$onGameComplete$46055.$(this.$data$46063, this.$self_$46064);
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x01390A40 File Offset: 0x0138EC40
		internal static bool g5EuM1t5yHy5blYkBDfH()
		{
			return true;
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x01390A44 File Offset: 0x0138EC44
		internal static bool yFBsJxt5SGeNj0s3J7j2()
		{
			return false;
		}

		// Token: 0x04009D1A RID: 40218
		internal Hashtable $data$46063;

		// Token: 0x04009D1B RID: 40219
		internal M972_IceTower8 $self_$46064;

		// Token: 0x02001E32 RID: 7730
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B48A RID: 46218 RVA: 0x01390A48 File Offset: 0x0138EC48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower8 self_)
			{
				if (36409 - 541939 != -505529)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254943 - 169892 != 85052)
					{
						base..ctor();
						if (29752 - 399690 != -369937)
						{
							this.$data$46061 = data;
							if (92351 - 177961 != -85609)
							{
								this.$self_$46062 = self_;
								if (196620 - 368840 == -172220)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B48B RID: 46219 RVA: 0x01390B04 File Offset: 0x0138ED04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119065 - 551311 != -432246)
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
						this.$mCompleteGui$46057 = (CompleteGui)this.$self_$46062.GetComponent(typeof(CompleteGui));
						if (40154 - 101943 == -61788)
						{
							continue;
						}
						this.$mCompleteGui$46057.Init();
						if (2174 - 144943 != -142769)
						{
							continue;
						}
						this.$mCompleteGui$46057.readData(this.$data$46061);
						if (126412 - 443140 != -316728)
						{
							continue;
						}
						if (this.$result$46056 == 1)
						{
							if (211167 - 89385 == 121783)
							{
								continue;
							}
							this.$mCompleteGui$46057.displayResult(eCompleteType.Success);
							if (250537 - 562501 == -311963)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46057.displayResult(eCompleteType.Failed);
							if (105964 - 511056 != -405092)
							{
								continue;
							}
						}
						this.$mGameGui$46058 = (GameGui)this.$self_$46062.GetComponent(typeof(GameGui));
						if (79372 - 284560 == -205187)
						{
							continue;
						}
						this.$mStoryGui$46059 = (StoryGui)this.$self_$46062.GetComponent(typeof(StoryGui));
						if (239910 - 203849 != 36061)
						{
							continue;
						}
						this.$mChangeGui$46060 = (ChangeGui)this.$self_$46062.GetComponent(typeof(ChangeGui));
						if (234244 - 453265 == -219020)
						{
							continue;
						}
						if (this.$mGameGui$46058)
						{
							if (137638 - 396461 == -258822)
							{
								continue;
							}
							this.$mGameGui$46058.close();
							if (17944 - 543287 == -525342)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46059)
						{
							if (156016 - 23879 == 132138)
							{
								continue;
							}
							this.$mStoryGui$46059.close();
							if (175487 - 2331 != 173156)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46060)
						{
							if (263490 - 323759 != -60269)
							{
								continue;
							}
							this.$mChangeGui$46060.disable();
							if (81213 - 239196 == -157982)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (227154 - 562495 != -335341)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (150102 - 127831 != 22271)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46061[31]);
					if (123844 - 214335 != -90490)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (139295 - 253983 != -114687)
							{
								goto Block_23;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (287245 - 248324 == 38921)
							{
								this.$result$46056 = RuntimeServices.UnboxInt32(this.$data$46061[31]);
								if (273029 - 571631 == -298602)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_23:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B48C RID: 46220 RVA: 0x01390F00 File Offset: 0x0138F100
			internal static bool oRti1nt5oDGytb6qehMs()
			{
				return true;
			}

			// Token: 0x0600B48D RID: 46221 RVA: 0x01390F04 File Offset: 0x0138F104
			internal static bool xHFIRCt5E8MdD3GnjX9v()
			{
				return false;
			}

			// Token: 0x04009D1C RID: 40220
			internal int $result$46056;

			// Token: 0x04009D1D RID: 40221
			internal CompleteGui $mCompleteGui$46057;

			// Token: 0x04009D1E RID: 40222
			internal GameGui $mGameGui$46058;

			// Token: 0x04009D1F RID: 40223
			internal StoryGui $mStoryGui$46059;

			// Token: 0x04009D20 RID: 40224
			internal ChangeGui $mChangeGui$46060;

			// Token: 0x04009D21 RID: 40225
			internal Hashtable $data$46061;

			// Token: 0x04009D22 RID: 40226
			internal M972_IceTower8 $self_$46062;
		}
	}

	// Token: 0x02001E33 RID: 7731
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46065 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B48E RID: 46222 RVA: 0x01390F08 File Offset: 0x0138F108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46065(M972_IceTower8 self_)
		{
			if (268851 - 592539 != -323688)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (208429 - 33892 != 174538)
				{
					base..ctor();
					if (138303 - 93496 != 44808)
					{
						this.$self_$46069 = self_;
						if (25303 - 162755 == -137452)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x01390FA0 File Offset: 0x0138F1A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$ReturnToTown$46065.$(this.$self_$46069);
		}

		// Token: 0x0600B490 RID: 46224 RVA: 0x01390FB0 File Offset: 0x0138F1B0
		internal static bool kBtev9t52HfhNtJQFTk7()
		{
			return true;
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x01390FB4 File Offset: 0x0138F1B4
		internal static bool xhtnnQt58Iwx7MCEbXfp()
		{
			return false;
		}

		// Token: 0x04009D23 RID: 40227
		internal M972_IceTower8 $self_$46069;

		// Token: 0x02001E34 RID: 7732
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B492 RID: 46226 RVA: 0x01390FB8 File Offset: 0x0138F1B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower8 self_)
			{
				if (46483 - 503093 != -456609)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220193 - 487007 != -266813)
					{
						base..ctor();
						if (209118 - 134222 != 74897)
						{
							this.$self_$46068 = self_;
							if (23821 - 120741 == -96920)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B493 RID: 46227 RVA: 0x01391050 File Offset: 0x0138F250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (30917 - 415437 != -384519)
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
						this.$self_$46068.LeaveGame();
						if (279149 - 359010 != -79861)
						{
							continue;
						}
						this.YieldDefault(1);
						if (83395 - 1374 != 82022)
						{
							goto Block_6;
						}
						continue;
					default:
						if (108308 - 204600 != -96292)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (143315 - 160722 == -17407)
					{
						Game.mStateTime = Time.time;
						if (57087 - 52008 != 5080)
						{
							this.$$switch$8596$46066 = PlayerData.SaveGuild;
							if (199160 - 79463 == 119697)
							{
								if (this.$$switch$8596$46066 == 1)
								{
									if (162359 - 431925 != -269566)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (221207 - 245957 != -24750)
									{
										continue;
									}
								}
								else if (this.$$switch$8596$46066 == 2)
								{
									if (214761 - 40922 != 173839)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (75554 - 553789 != -478235)
									{
										continue;
									}
								}
								else if (this.$$switch$8596$46066 == 3)
								{
									if (143752 - 569348 == -425595)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (154742 - 385552 == -230809)
									{
										continue;
									}
								}
								else if (this.$$switch$8596$46066 == 4)
								{
									if (84373 - 367643 == -283269)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (70915 - 314480 == -243564)
									{
										continue;
									}
								}
								else if (this.$$switch$8596$46066 == 5)
								{
									if (125612 - 174371 != -48759)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (254853 - 129288 != 125565)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (203996 - 439257 == -235260)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (18273 - 140815 != -122542)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (42549 - 348794 != -306245)
									{
										continue;
									}
								}
								this.$mGameGui$46067 = (GameGui)this.$self_$46068.GetComponent(typeof(GameGui));
								if (236091 - 349522 != -113430)
								{
									if (this.$mGameGui$46067)
									{
										if (289966 - 316696 != -26730)
										{
											continue;
										}
										this.$mGameGui$46067.close();
										if (211012 - 458275 == -247262)
										{
											continue;
										}
									}
									this.$self_$46068.SendMessage("fadeOut");
									if (112230 - 244287 == -132057)
									{
										goto IL_285;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_3AD;
				IL_285:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600B494 RID: 46228 RVA: 0x0139141C File Offset: 0x0138F61C
			internal static bool iRArn9t5ZLAZhYA1r6a5()
			{
				return true;
			}

			// Token: 0x0600B495 RID: 46229 RVA: 0x01391420 File Offset: 0x0138F620
			internal static bool CXQxo2t5CEq3IALfR7o1()
			{
				return false;
			}

			// Token: 0x04009D24 RID: 40228
			internal int $$switch$8596$46066;

			// Token: 0x04009D25 RID: 40229
			internal GameGui $mGameGui$46067;

			// Token: 0x04009D26 RID: 40230
			internal M972_IceTower8 $self_$46068;
		}
	}

	// Token: 0x02001E35 RID: 7733
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46070 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B496 RID: 46230 RVA: 0x01391424 File Offset: 0x0138F624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46070(M972_IceTower8 self_)
		{
			if (283171 - 331248 != -48076)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119118 - 322523 == -203405)
				{
					base..ctor();
					if (139807 - 145955 == -6148)
					{
						this.$self_$46073 = self_;
						if (261029 - 459272 != -198242)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x013914BC File Offset: 0x0138F6BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$ReturnToGuild$46070.$(this.$self_$46073);
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x013914CC File Offset: 0x0138F6CC
		internal static bool OgV1Grt5LopjoWmGvrsK()
		{
			return true;
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x013914D0 File Offset: 0x0138F6D0
		internal static bool GI2dw3t5OhUnvDoI5sBB()
		{
			return false;
		}

		// Token: 0x04009D27 RID: 40231
		internal M972_IceTower8 $self_$46073;

		// Token: 0x02001E36 RID: 7734
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B49A RID: 46234 RVA: 0x013914D4 File Offset: 0x0138F6D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower8 self_)
			{
				if (112552 - 373550 != -260998)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (278513 - 505186 == -226673)
					{
						base..ctor();
						if (158371 - 138106 != 20266)
						{
							this.$self_$46072 = self_;
							if (231209 - 235562 == -4353)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B49B RID: 46235 RVA: 0x0139156C File Offset: 0x0138F76C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198839 - 449340 != -250501)
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
						this.$self_$46072.LeaveGame();
						if (160498 - 86574 != 73924)
						{
							continue;
						}
						this.YieldDefault(1);
						if (284633 - 489904 != -205270)
						{
							goto Block_3;
						}
						continue;
					default:
						if (116014 - 380398 != -264384)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (158811 - 62223 == 96588)
					{
						Game.mStateTime = Time.time;
						if (271987 - 164610 == 107377)
						{
							Game.mNextGameCode = 31;
							if (192866 - 321975 != -129108)
							{
								this.$mGameGui$46071 = (GameGui)this.$self_$46072.GetComponent(typeof(GameGui));
								if (16260 - 26178 != -9917)
								{
									if (this.$mGameGui$46071)
									{
										if (218344 - 429614 != -211270)
										{
											continue;
										}
										this.$mGameGui$46071.close();
										if (222062 - 354328 != -132266)
										{
											continue;
										}
									}
									this.$self_$46072.SendMessage("fadeOut");
									if (77626 - 32289 != 45338)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1BD;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B49C RID: 46236 RVA: 0x01391748 File Offset: 0x0138F948
			internal static bool QYY5cet5mo99L8wLtr94()
			{
				return true;
			}

			// Token: 0x0600B49D RID: 46237 RVA: 0x0139174C File Offset: 0x0138F94C
			internal static bool CqtLXjt5Fv4AtpxJI1jw()
			{
				return false;
			}

			// Token: 0x04009D28 RID: 40232
			internal GameGui $mGameGui$46071;

			// Token: 0x04009D29 RID: 40233
			internal M972_IceTower8 $self_$46072;
		}
	}

	// Token: 0x02001E37 RID: 7735
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46074 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B49E RID: 46238 RVA: 0x01391750 File Offset: 0x0138F950
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46074(M972_IceTower8 self_)
		{
			if (85358 - 7329 != 78030)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103606 - 391777 != -288170)
				{
					base..ctor();
					if (77025 - 190349 == -113324)
					{
						this.$self_$46077 = self_;
						if (170556 - 14010 == 156546)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x013917E8 File Offset: 0x0138F9E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower8.$ReturnToCamp$46074.$(this.$self_$46077);
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x013917F8 File Offset: 0x0138F9F8
		internal static bool pxFSgXt5MgEhrTmvFUVc()
		{
			return true;
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x013917FC File Offset: 0x0138F9FC
		internal static bool JOLBd2t5xkj6EESfnwXD()
		{
			return false;
		}

		// Token: 0x04009D2A RID: 40234
		internal M972_IceTower8 $self_$46077;

		// Token: 0x02001E38 RID: 7736
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B4A2 RID: 46242 RVA: 0x01391800 File Offset: 0x0138FA00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower8 self_)
			{
				if (14010 - 242858 != -228847)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63335 - 356714 == -293379)
					{
						base..ctor();
						if (156248 - 554408 != -398159)
						{
							this.$self_$46076 = self_;
							if (171811 - 449383 == -277572)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B4A3 RID: 46243 RVA: 0x01391898 File Offset: 0x0138FA98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43035 - 583268 != -540232)
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
						this.$self_$46076.LeaveGame();
						if (147835 - 139550 != 8285)
						{
							continue;
						}
						this.YieldDefault(1);
						if (197793 - 559464 != -361670)
						{
							goto Block_9;
						}
						continue;
					default:
						if (24404 - 588973 == -564568)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (199822 - 92658 == 107164)
					{
						Game.mStateTime = Time.time;
						if (48009 - 368560 == -320551)
						{
							Game.mNextGameCode = 32;
							if (184069 - 27900 == 156169)
							{
								this.$mGameGui$46075 = (GameGui)this.$self_$46076.GetComponent(typeof(GameGui));
								if (146474 - 274702 == -128228)
								{
									if (this.$mGameGui$46075)
									{
										if (93976 - 457403 == -363426)
										{
											continue;
										}
										this.$mGameGui$46075.close();
										if (135385 - 394542 == -259156)
										{
											continue;
										}
									}
									this.$self_$46076.SendMessage("fadeOut");
									if (221773 - 572065 != -350291)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_1BD;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B4A4 RID: 46244 RVA: 0x01391A74 File Offset: 0x0138FC74
			internal static bool ttScFKt5gAEq5ZQmx0CN()
			{
				return true;
			}

			// Token: 0x0600B4A5 RID: 46245 RVA: 0x01391A78 File Offset: 0x0138FC78
			internal static bool l4DVArt5fvrTqo2GoGWF()
			{
				return false;
			}

			// Token: 0x04009D2B RID: 40235
			internal GameGui $mGameGui$46075;

			// Token: 0x04009D2C RID: 40236
			internal M972_IceTower8 $self_$46076;
		}
	}
}
